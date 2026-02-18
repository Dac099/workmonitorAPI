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

    /*
        If itemId is NULL, it's a creation for a new tag
        otherwiser it's a new value for an existing item
    */
    public async Task<TableValueDto> CreateAsync(CreateTableValueDto dto)
    {
        var column = await _db.Columns.FindAsync(dto.ColumnId)
            ?? throw new KeyNotFoundException("Column not found");

        if (dto.ItemId.HasValue)
        {
            var _ = await _db.Items.FindAsync(dto.ItemId.Value)
                ?? throw new KeyNotFoundException("Item not found");
        }

        if (IsCompanyColumn(column.Name))
        {
            _db.DefinedColumnsValues.Add(new DefinedColumnsValue
            {
                Name = "company",
                Value = dto.Value
            });
        }
        else if (IsStatusColumn(column.Name))
        {
            _db.DefinedColumnsValues.Add(new DefinedColumnsValue
            {
                Name = "status",
                Value = dto.Value
            });
        }

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

    public async Task<bool> DeleteAsync(Guid id)
    {
        var tableValue = await _db.TableValues.FindAsync(id)
            ?? throw new KeyNotFoundException("TableValue not found");

        var isInUse = await _db.TableValues
            .AnyAsync(tv => tv.ItemId != null && tv.Value == tableValue.Value && tv.DeletedAt == null);

        if (isInUse)
            return false;

        tableValue.DeletedAt = DateTime.Now;
        await _db.SaveChangesAsync();
        return true;
    }

    // Keywords that identify "company" or "status" columns (EN + ES variants)
    private static readonly HashSet<string> _companyKeywords = new(StringComparer.OrdinalIgnoreCase)
    {
        "company", "empresa", "compañia", "compania", "cliente", "client"
    };

    private static readonly HashSet<string> _statusKeywords = new(StringComparer.OrdinalIgnoreCase)
    {
        "status", "estado", "estatus", "estado", "situacion", "situación"
    };

    private static bool IsCompanyColumn(string name) =>
        _companyKeywords.Any(k => name.Contains(k, StringComparison.OrdinalIgnoreCase));

    private static bool IsStatusColumn(string name) =>
        _statusKeywords.Any(k => name.Contains(k, StringComparison.OrdinalIgnoreCase));

    public async Task<IEnumerable<StatusValuesByColumnDto>> GetStatusValuesGroupedByColumnAsync(Guid boardId)
    {
        // 1. Get all active columns for the board
        var boardColumns = await _db.Columns
            .AsNoTracking()
            .Where(c => c.BoardId == boardId && c.DeletedAt == null)
            .ToListAsync();

        // 2. Identify company-like and status-like columns
        var companyColumns = boardColumns.Where(c => IsCompanyColumn(c.Name)).ToList();
        var statusColumns  = boardColumns.Where(c => IsStatusColumn(c.Name)).ToList();
        var definedColumnIds = companyColumns.Concat(statusColumns)
            .Select(c => c.Id)
            .ToHashSet();

        // 3. Load DefinedColumnsValues grouped by Name (company / status)
        var definedValues = await _db.DefinedColumnsValues
            .AsNoTracking()
            .ToListAsync();

        var companyDefinedValues = definedValues
            .Where(d => d.Name != null && IsCompanyColumn(d.Name))
            .ToList();

        var statusDefinedValues = definedValues
            .Where(d => d.Name != null && IsStatusColumn(d.Name))
            .ToList();

        // 4. Get TableValues as before (status-type columns for the board)
        var rows = await _db.TableValues
            .AsNoTracking()
            .Include(tv => tv.Column)
            .Where(tv =>
                tv.ItemId == null &&
                tv.DeletedAt == null &&
                tv.Column.BoardId == boardId &&
                tv.Column.Type == "status" &&
                tv.Column.DeletedAt == null)
            .ToListAsync();

        // 5. Build result, replacing values for company/status columns with DefinedColumnsValues
        var result = rows
            .GroupBy(tv => new { tv.ColumnId, tv.Column.Name })
            .Select(g =>
            {
                List<TableValueDto> values;

                if (companyColumns.Any(c => c.Id == g.Key.ColumnId))
                {
                    // Replace with company defined values
                    values = companyDefinedValues
                        .Select(d => new TableValueDto(Guid.Empty, null, g.Key.ColumnId, d.Value))
                        .ToList();
                }
                else if (statusColumns.Any(c => c.Id == g.Key.ColumnId))
                {
                    // Replace with status defined values
                    values = statusDefinedValues
                        .Select(d => new TableValueDto(Guid.Empty, null, g.Key.ColumnId, d.Value))
                        .ToList();
                }
                else
                {
                    // Keep original TableValues
                    values = g.DistinctBy(tv => tv.Value)
                        .Select(tv => new TableValueDto(tv.Id, tv.ItemId, tv.ColumnId, tv.Value))
                        .ToList();
                }

                return new StatusValuesByColumnDto(g.Key.ColumnId, g.Key.Name, values);
            })
            .ToList();

        return result;
    }
}
