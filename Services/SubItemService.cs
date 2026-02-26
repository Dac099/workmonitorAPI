using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Data;
using workmonitorAPI.DTOs.SubItemDTOs;
using workmonitorAPI.DTOs.TableValueDTOs;
using workmonitorAPI.Models;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Services;

public class SubItemService : ISubItemService
{
  private readonly AppDbContext _db;

  public SubItemService(AppDbContext db)
  {
    _db = db;
  }

  public async Task<IEnumerable<SubItemWithValuesDto>> GetByItemIdWithValuesAsync(Guid itemId)
  {
    var itemExists = await _db.Items
        .AsNoTracking()
        .AnyAsync(i => i.Id == itemId && i.DeletedAt == null);

    if (!itemExists)
      throw new KeyNotFoundException("Item not found");

    var subItems = await _db.SubItems
        .AsNoTracking()
        .Where(s => s.ItemParent == itemId && s.DeletedAt == null)
        .Select(s => new SubItemDto(s.Id, s.Name, s.ItemParent))
        .ToListAsync();

    if (subItems.Count == 0)
      return [];

    var subItemIds = subItems.Select(s => s.Id).ToList();

    var values = await _db.TableValues
        .AsNoTracking()
      .Where(tv => tv.ItemId.HasValue && subItemIds.Contains(tv.ItemId.Value) && tv.DeletedAt == null)
        .Join(
            _db.Columns.AsNoTracking(),
            tv => tv.ColumnId,
            c => c.Id,
        (tv, c) => new
        {
          ItemId = tv.ItemId,
          Value = new TableValueWithTypeDto(tv.Id, tv.ItemId, tv.ColumnId, tv.Value, c.Type)
        }
        )
        .ToListAsync();

    var valuesBySubItemId = values
      .Where(v => v.ItemId.HasValue)
      .GroupBy(v => v.ItemId!.Value)
      .ToDictionary(g => g.Key, g => g.Select(x => x.Value).ToList());

    return subItems.Select(s => new SubItemWithValuesDto(
        s.Id,
        s.ItemParent,
        s.Name,
      valuesBySubItemId.TryGetValue(s.Id, out var subItemValues)
        ? subItemValues
        : []
    )).ToList();
  }

  public async Task<SubItemDto> CreateAsync(CreateSubItemDto dto)
  {
    var itemExists = await _db.Items
        .AsNoTracking()
        .AnyAsync(i => i.Id == dto.ItemParent && i.DeletedAt == null);

    if (!itemExists)
      throw new KeyNotFoundException("Item not found");

    var now = DateTime.Now;
    var subItem = new SubItem
    {
      Name = dto.Name,
      ItemParent = dto.ItemParent,
      CreatedAt = now,
      UpdatedAt = now
    };

    _db.SubItems.Add(subItem);
    await _db.SaveChangesAsync();

    return new SubItemDto(subItem.Id, subItem.Name, subItem.ItemParent);
  }

  public async Task UpdateAsync(Guid id, UpdateSubItemDto dto)
  {
    var subItem = await _db.SubItems.FindAsync(id)
        ?? throw new KeyNotFoundException("SubItem not found");

    if (subItem.DeletedAt != null)
      throw new KeyNotFoundException("SubItem not found");

    if (dto.Name != null)
      subItem.Name = dto.Name;

    subItem.UpdatedAt = DateTime.Now;

    _db.SubItems.Update(subItem);
    await _db.SaveChangesAsync();
  }

  public async Task DeleteAsync(Guid id)
  {
    var subItem = await _db.SubItems
        .FirstOrDefaultAsync(s => s.Id == id && s.DeletedAt == null)
        ?? throw new KeyNotFoundException("SubItem not found");

    var now = DateTime.Now;
    subItem.DeletedAt = now;
    subItem.UpdatedAt = now;

    _db.SubItems.Update(subItem);
    await _db.SaveChangesAsync();
  }
}
