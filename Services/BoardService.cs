using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Data;
using workmonitorAPI.DTOs.BoardDTOs;
using workmonitorAPI.DTOs.GanttDTOs;
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
            .Select(b => new {
                b.Id,
                b.WorkspaceId,
                b.Name,
                b.Description,
                HasTimeline = _db.Columns
                    .AsNoTracking()
                    .Any(c => c.BoardId == b.Id && c.Type == "timeline" && c.DeletedAt == null)
            })
            .FirstOrDefaultAsync()
            ?? throw new KeyNotFoundException("Board not found");
        
        return new BoardDto(board.Id, board.WorkspaceId, board.Name, board.Description, board.HasTimeline);
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
        return new BoardDto(board.Id, board.WorkspaceId, board.Name, board.Description, false);
    }

    public async Task<BoardDto> GetCollectionBoardAsync()
    {
        var board = await _db.Boards
            .AsNoTracking()
            .Where(b => b.DeletedAt == null
                && EF.Functions.Like(b.Workspace.Name, "%Cobranza%")
                && EF.Functions.Like(b.Name, "Cobranza%"))
            .Select(b => new {
                b.Id,
                b.WorkspaceId,
                b.Name,
                b.Description,
                HasTimeline = _db.Columns
                    .AsNoTracking()
                    .Any(c => c.BoardId == b.Id && c.Type == "timeline" && c.DeletedAt == null)
            })
            .FirstOrDefaultAsync()
            ?? throw new KeyNotFoundException("Board not found");

        return new BoardDto(board.Id, board.WorkspaceId, board.Name, board.Description, board.HasTimeline);
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
            .Select(b => new BoardDto(
                b.Id,
                b.WorkspaceId,
                b.Name,
                b.Description,
                _db.Columns
                    .AsNoTracking()
                    .Any(c => c.BoardId == b.Id && c.Type == "timeline" && c.DeletedAt == null)))
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
                b.Description,
                _db.Columns
                    .AsNoTracking()
                    .Any(c => c.BoardId == b.Id && c.Type == "timeline" && c.DeletedAt == null)))
            .ToListAsync();
    }

    public async Task<GanttBoardDto> GetGanttDataAsync(Guid boardId, Guid? timelineColumnId)
    {
        var boardExists = await _db.Boards
            .AsNoTracking()
            .AnyAsync(b => b.Id == boardId && b.DeletedAt == null);

        if (!boardExists)
            throw new KeyNotFoundException("Board not found");

        var groups = await _db.Groups
            .AsNoTracking()
            .Where(g => g.BoardId == boardId && g.DeletedAt == null)
            .OrderBy(g => g.Position)
            .Select(g => new GanttGroupDto(g.Id, g.BoardId, g.Name, g.Position, g.Color))
            .ToListAsync();

        var groupIds = groups.Select(g => g.Id).ToList();

        var items = await _db.Items
            .AsNoTracking()
            .Where(i => groupIds.Contains(i.GroupId) && i.DeletedAt == null)
            .OrderBy(i => i.Position)
            .Select(i => new { i.Id, i.GroupId, i.Name, i.Position })
            .ToListAsync();

        var timelineColumns = await _db.Columns
            .AsNoTracking()
            .Where(c => c.BoardId == boardId && c.Type == "timeline" && c.DeletedAt == null)
            .OrderBy(c => c.Position)
            .ToListAsync();

        var selectedColumn = timelineColumns.FirstOrDefault(c => c.Id == timelineColumnId)
            ?? timelineColumns.FirstOrDefault();

        Guid? selectedColumnId = selectedColumn?.Id;
        string? selectedColumnName = selectedColumn?.Name;

        var itemIds = items.Select(i => i.Id).ToList();

        var timelineValues = new Dictionary<Guid, (Guid Id, string? Value)>();

        if (selectedColumnId.HasValue && itemIds.Count > 0)
        {
            var tableValues = await _db.TableValues
                .AsNoTracking()
                .Where(tv =>
                    tv.ItemId != null
                    && itemIds.Contains(tv.ItemId.Value)
                    && tv.ColumnId == selectedColumnId.Value
                    && tv.DeletedAt == null)
                .Select(tv => new { tv.Id, tv.ItemId, tv.Value, tv.UpdatedAt })
                .ToListAsync();

            timelineValues = tableValues
                .Where(tv => tv.ItemId.HasValue)
                .GroupBy(tv => tv.ItemId!.Value)
                .Select(g => g.OrderByDescending(tv => tv.UpdatedAt).First())
                .ToDictionary(tv => tv.ItemId!.Value, tv => (tv.Id, tv.Value));
        }

        var itemDtos = items.Select(i =>
        {
            if (timelineValues.TryGetValue(i.Id, out var timelineValue))
            {
                return new GanttItemDto(
                    i.Id,
                    i.GroupId,
                    i.Name,
                    i.Position,
                    timelineValue.Id,
                    timelineValue.Value
                );
            }

            return new GanttItemDto(
                i.Id,
                i.GroupId,
                i.Name,
                i.Position,
                null,
                null
            );
        }).ToList();

        return new GanttBoardDto(boardId, selectedColumnId, selectedColumnName, groups, itemDtos);
    }
}
