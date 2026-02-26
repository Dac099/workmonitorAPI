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

    var values = await _db.TableValues
        .AsNoTracking()
        .Where(tv => tv.ItemId == itemId && tv.DeletedAt == null)
        .Join(
            _db.Columns.AsNoTracking(),
            tv => tv.ColumnId,
            c => c.Id,
            (tv, c) => new TableValueWithTypeDto(tv.Id, tv.ItemId, tv.ColumnId, tv.Value, c.Type)
        )
        .ToListAsync();

    return subItems.Select(s => new SubItemWithValuesDto(
        s.Id,
        s.ItemParent,
        s.Name,
        values
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

  public async Task DeleteAsync(DeleteSubItemsDto dto)
  {
    var subItemIds = dto.SubItemIds.Distinct().ToList();
    if (subItemIds.Count == 0)
      throw new KeyNotFoundException("No valid subitems found to delete");

    var subItems = await _db.SubItems
        .Where(s => subItemIds.Contains(s.Id) && s.DeletedAt == null)
        .ToListAsync();

    if (subItems.Count == 0)
      throw new KeyNotFoundException("No valid subitems found to delete");

    var now = DateTime.Now;
    foreach (var subItem in subItems)
    {
      subItem.DeletedAt = now;
      subItem.UpdatedAt = now;
    }

    _db.SubItems.UpdateRange(subItems);
    await _db.SaveChangesAsync();
  }
}
