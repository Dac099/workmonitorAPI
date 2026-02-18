using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Data;
using workmonitorAPI.DTOs.TableValueDTOs;
using workmonitorAPI.Models;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Services;

public class TableValueService : ITableValueService
{
    private readonly AppDbContext _db;

    public TableValueService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<TableValueDto> CreateAsync(CreateTableValueDto dto)
    {
        var _ = await _db.Columns.FindAsync(dto.ColumnId)
            ?? throw new KeyNotFoundException("Column not found");

        var __ = await _db.Items.FindAsync(dto.ItemId)
            ?? throw new KeyNotFoundException("Item not found");

        var tableValue = new TableValue
        {
            ItemId = dto.ItemId,
            ColumnId = dto.ColumnId,
            Value = dto.Value,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        _db.TableValues.Add(tableValue);
        await _db.SaveChangesAsync();

        return new TableValueDto(tableValue.Id, tableValue.ItemId, tableValue.ColumnId, tableValue.Value);
    }

    public async Task UpdateAsync(Guid id, UpdateTableValueDto dto)
    {
        var tableValue = await _db.TableValues.FindAsync(id)
            ?? throw new KeyNotFoundException("TableValue not found");

        tableValue.Value = dto.Value;
        tableValue.UpdatedAt = DateTime.Now;

        _db.TableValues.Update(tableValue);
        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<StatusValuesByColumnDto>> GetStatusValuesGroupedByColumnAsync(Guid boardId)
    {
        var rows = await _db.TableValues
            .AsNoTracking()
            .Include(tv => tv.Column)
            .Where(tv =>
                tv.ItemId != null &&
                tv.DeletedAt == null &&
                tv.Column.BoardId == boardId &&
                tv.Column.Type == "status" &&
                tv.Column.DeletedAt == null)
            .ToListAsync();

        var result = rows
            .GroupBy(tv => new { tv.ColumnId, tv.Column.Name })
            .Select(g => new StatusValuesByColumnDto(
                g.Key.ColumnId,
                g.Key.Name,
                g.DistinctBy(tv => tv.Value)
                 .Select(tv => new TableValueDto(
                     tv.Id,
                     tv.ItemId,
                     tv.ColumnId,
                     tv.Value
                 )).ToList()
            ))
            .ToList();

        return result;
    }
}
