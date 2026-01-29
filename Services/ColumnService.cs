using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Data;
using workmonitorAPI.DTOs.ColumnDTOs;
using workmonitorAPI.Models;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Services;

public class ColumnService : IColumnService
{
    private readonly AppDbContext _db;

    public ColumnService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<ColumnDto> CreateAsync(CreateColumnDto dto)
    {
        var maxPosition = await _db.Columns
            .Where(c => c.BoardId == dto.BoardId && c.DeletedAt == null)
            .MaxAsync(c => (int?)c.Position) ?? -1;

        var nextPosition = maxPosition + 1;

        var column = new Column
        {
            BoardId = dto.BoardId,
            Name = dto.Name,
            Type = dto.Type,
            Settings = dto.Settings,
            Position = nextPosition,
            ColumnWidth = dto.ColumnWidth,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        _db.Columns.Add(column);
        await _db.SaveChangesAsync();
        return new ColumnDto(column.Id, column.BoardId, column.Name, column.Type, column.Settings, column.Position, column.ColumnWidth);
    }

    public async Task UpdateAsync(Guid id, UpdateColumnDto dto)
    {
        var column = await _db.Columns.FindAsync(id)
            ?? throw new KeyNotFoundException("Column not found");

        var oldPosition = column.Position;
        var newPosition = dto.Position;

        if (dto.Name != null)
            column.Name = dto.Name;
        if (dto.Settings != null)
            column.Settings = dto.Settings;
        if (newPosition.HasValue)
        {
            column.Position = newPosition.Value;
            await ReorderPositionsAsync(id, column.BoardId, oldPosition, newPosition.Value);
        }
        if (dto.ColumnWidth.HasValue)
            column.ColumnWidth = dto.ColumnWidth.Value;

        column.UpdatedAt = DateTime.Now;

        _db.Columns.Update(column);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var column = await _db.Columns.FindAsync(id)
            ?? throw new KeyNotFoundException("Column not found");

        column.DeletedAt = DateTime.Now;
        _db.Columns.Update(column);
        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<ColumnDto>> GetByBoardIdAsync(Guid boardId)
    {
        return await _db.Columns
            .AsNoTracking()
            .Where(c => c.BoardId == boardId && c.DeletedAt == null)
            .OrderBy(c => c.Position)
            .Select(c => new ColumnDto(c.Id, c.BoardId, c.Name, c.Type, c.Settings, c.Position, c.ColumnWidth))
            .ToListAsync();
    }

    /*
        Reorder the position of the columns in a board between the old position
        and the new position
    */
    private async Task ReorderPositionsAsync(Guid columnId, Guid boardId, int oldPosition, int newPosition)
    {
        var columns = await _db.Columns
            .Where(c => c.BoardId == boardId && c.DeletedAt == null && c.Id != columnId)
            .OrderBy(c => c.Position)
            .ToListAsync();

        if (newPosition < oldPosition)
        {
            foreach (var col in columns.Where(c => c.Position >= newPosition && c.Position < oldPosition))
            {
                col.Position++;
                col.UpdatedAt = DateTime.Now;
                _db.Columns.Update(col);
            }
        }
        else if (newPosition > oldPosition)
        { 
            foreach (var col in columns.Where(c => c.Position > oldPosition && c.Position <= newPosition))
            {
                col.Position--;
                col.UpdatedAt = DateTime.Now;
                _db.Columns.Update(col);
            }
        }

        await _db.SaveChangesAsync();
    }
}

