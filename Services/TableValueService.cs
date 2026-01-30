using System;
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
}
