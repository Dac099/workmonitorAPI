using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Data;
using workmonitorAPI.DTOs.BoardDTOs;
using workmonitorAPI.Models;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Services;

public class BoardService : IBoardService
{
    private readonly AppDbContext _db;

    public BoardService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<BoardDto> GetByIdAsync(Guid id)
    {
        var board = await _db.Boards
            .AsNoTracking()
            .Where(b => b.Id == id && b.DeletedAt == null)
            .Select(b => new BoardDto(b.Id, b.WorkspaceId, b.Name, b.Description))
            .FirstOrDefaultAsync()
            ?? throw new KeyNotFoundException("Board not found");
        return board;
    }

    public async Task<BoardDto> CreateAsync(CreateBoardDto dto)
    {
        var board = new Board
        {
            WorkspaceId = dto.WorkspaceId,
            Name = dto.Name,
            Description = dto.Description,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        _db.Boards.Add(board);
        await _db.SaveChangesAsync();
        return new BoardDto(board.Id, board.WorkspaceId, board.Name, board.Description);
    }

    public async Task<BoardDto> GetCollectionBoardAsync()
    {
        var board = await _db.Boards
            .AsNoTracking()
            .Where(b => b.DeletedAt == null
                && EF.Functions.Like(b.Workspace.Name, "%Cobranza%")
                && EF.Functions.Like(b.Name, "Cobranza%"))
            .Select(b => new BoardDto(b.Id, b.WorkspaceId, b.Name, b.Description))
            .FirstOrDefaultAsync()
            ?? throw new KeyNotFoundException("Board not found");

        return board;
    }

    public async Task DeleteAsync(Guid id)
    {
        var board = await _db.Boards.FindAsync(id)
            ?? throw new KeyNotFoundException("Board not found");

        board.DeletedAt = DateTime.Now;
        _db.Boards.Update(board);
        await _db.SaveChangesAsync();
    }

    public async Task UpdateAsync(Guid id, UpdateBoardDto dto)
    {
        var board = await _db.Boards.FindAsync(id)
            ?? throw new KeyNotFoundException("Board not found");

        board.Name = dto.Name ?? board.Name;
        board.Description = dto.Description ?? board.Description;
        board.UpdatedAt = DateTime.Now;

        _db.Boards.Update(board);
        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<BoardDto>> GetByWorkspaceIdAsync(Guid workspaceId)
    {
        return await _db.Boards
            .AsNoTracking()
            .Where(b => b.WorkspaceId == workspaceId && b.DeletedAt == null)
            .Select(b => new BoardDto(b.Id, b.WorkspaceId, b.Name, b.Description))
            .ToListAsync();
    }

    public async Task<IEnumerable<BoardWithWorkspaceNameDto>> GetAllWithWorkspaceNameAsync()
    {
        return await _db.Boards
            .AsNoTracking()
            .Where(b => b.DeletedAt == null)
            .Select(b => new BoardWithWorkspaceNameDto(
                b.Id,
                b.WorkspaceId,
                b.Workspace.Name,
                b.Name,
                b.Description))
            .ToListAsync();
    }
}
