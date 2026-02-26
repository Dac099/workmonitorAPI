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
    private static readonly HashSet<string> _companyKeywords = new(StringComparer.OrdinalIgnoreCase)
    {
        "company", "empresa", "compañia", "compania", "cliente", "client"
    };

    private static readonly HashSet<string> _statusKeywords = new(StringComparer.OrdinalIgnoreCase)
    {
        "status", "estado", "estatus", "estado", "situacion", "situación", "estados", "statuses"
    };

    private static bool IsCompanyColumn(string name) =>
        _companyKeywords.Any(k => k.Contains(name, StringComparison.OrdinalIgnoreCase));

    private static bool IsStatusColumn(string name) =>
        _statusKeywords.Any(k => k.Contains(name, StringComparison.OrdinalIgnoreCase));

    public TableValueService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<DefinedColumnsValue>> GetDefinedValuesByTypeAsync(GetDefinedValuesDto dto)
    {
        if (IsCompanyColumn(dto.ColumnType))
        {
            return await _db.DefinedColumnsValues
                .Where(v => v.Name == "company")
                .AsNoTracking()
                .ToListAsync();
        }
        else if (IsStatusColumn(dto.ColumnType))
        {
            return await _db.DefinedColumnsValues
                .Where(v => v.Name == "status")
                .AsNoTracking()
                .ToListAsync();
        }

        return new List<DefinedColumnsValue>();
    }

    /*
        If itemId is NULL, it's a creation for a new tag
        otherwiser it's a new value for an existing item
    */
    public async Task<TableValueDto> CreateAsync(CreateTableValueDto dto)
    {
        var column = await _db.Columns.FindAsync(dto.ColumnId)
            ?? throw new KeyNotFoundException("Column not found");

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

    public async Task<IEnumerable<StatusValuesByColumnDto>> GetStatusValuesGroupedByColumnAsync(Guid boardId)
    {
        var columns = await _db.Columns
            .AsNoTracking()
            .Where(c => c.BoardId == boardId && c.Type == "status" && c.DeletedAt == null)
            .ToListAsync();

        if (columns.Count == 0)
            return [];

        var columnIds = columns.Select(c => c.Id).ToList();

        var tableValues = await _db.TableValues
            .AsNoTracking()
            .Where(tv => columnIds.Contains(tv.ColumnId) && tv.ItemId == null && tv.DeletedAt == null)
            .ToListAsync();

        var definedValues = await _db.DefinedColumnsValues
            .AsNoTracking()
            .ToListAsync();

        var companyDefinedValues = definedValues
            .Where(d => d.Name != null && d.Name.Trim().Equals("company", StringComparison.OrdinalIgnoreCase))
            .ToList();

        var statusDefinedValues = definedValues
            .Where(d => d.Name != null && d.Name.Trim().Equals("status", StringComparison.OrdinalIgnoreCase))
            .ToList();



        var result = new List<StatusValuesByColumnDto>();

        foreach (var column in columns)
        {
            List<TableValueDto> values;

            if (IsCompanyColumn(column.Name))
            {
                values = companyDefinedValues
                    .Select(d => new TableValueDto(Guid.Empty, null, column.Id, d.Value))
                    .ToList();
            }
            else if (IsStatusColumn(column.Name))
            {
                values = statusDefinedValues
                    .Select(d => new TableValueDto(Guid.Empty, null, column.Id, d.Value))
                    .ToList();
            }
            else
            {
                values = tableValues
                    .Where(tv => tv.ColumnId == column.Id)
                    .DistinctBy(tv => tv.Value)
                    .Select(tv => new TableValueDto(tv.Id, tv.ItemId, tv.ColumnId, tv.Value))
                    .ToList();
            }

            result.Add(new StatusValuesByColumnDto(column.Id, column.Name, values));
        }

        return result;
    }
}
