using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Data;
using workmonitorAPI.DTOs.ItemDTOs;
using workmonitorAPI.Models;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Services;

public class ItemService : IItemService
{
    private readonly AppDbContext _db;

    public ItemService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<ItemDto> CreateAsync(CreateItemDto dto)
    {
        var maxPosition = await _db.Items
            .Where(i => i.GroupId == dto.GroupId && i.DeletedAt == null)
            .MaxAsync(i => (int?)i.Position) ?? -1;

        var nextPosition = maxPosition + 1;

        var item = new Item
        {
            GroupId = dto.GroupId,
            Name = dto.Name,
            Position = nextPosition,
            ProjectId = dto.ProjectId,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        _db.Items.Add(item);
        await _db.SaveChangesAsync();
        return new ItemDto(item.Id, item.GroupId, item.Name, item.Position, item.ProjectId);
    }

    public async Task UpdateAsync(Guid id, UpdateItemDto dto)
    {
        var item = await _db.Items.FindAsync(id)
            ?? throw new KeyNotFoundException("Item not found");

        if (item.DeletedAt != null)
            throw new KeyNotFoundException("Item not found");

        var oldPosition = item.Position;
        var newPosition = dto.Position;

        if (dto.Name != null)
            item.Name = dto.Name;
        if (newPosition.HasValue)
        {
            item.Position = newPosition.Value;
            await ReorderPositionsAsync(id, item.GroupId, oldPosition, newPosition.Value);
        }

        item.UpdatedAt = DateTime.Now;

        _db.Items.Update(item);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var item = await _db.Items.FindAsync(id)
            ?? throw new KeyNotFoundException("Item not found");

        item.DeletedAt = DateTime.Now;
        _db.Items.Update(item);
        await _db.SaveChangesAsync();
    }

    public async Task MoveToGroupAsync(MoveItemRequestDto dto)
    {
        // Validate target group exists
        var targetGroup = await _db.Groups.FindAsync(dto.TargetGroupId)
            ?? throw new KeyNotFoundException("Target group not found");

        // Get all items to move
        var itemsToMove = await _db.Items
            .Where(i => dto.ItemIds.Contains(i.Id) && i.DeletedAt == null)
            .ToListAsync();

        Guid? originalGroupId = itemsToMove.FirstOrDefault()?.GroupId;

        if (originalGroupId == dto.TargetGroupId)
            throw new InvalidOperationException("Cannot move items to the same group");

        if (itemsToMove.Count == 0)
            throw new KeyNotFoundException("No valid items found to move");

        // Get the maximum position in the target group
        var maxPosition = await _db.Items
            .Where(i => i.GroupId == dto.TargetGroupId && i.DeletedAt == null)
            .MaxAsync(i => (int?)i.Position) ?? -1;

        // Move each item to the target group
        foreach (var item in itemsToMove)
        {
            var oldGroupId = item.GroupId;
            var oldPosition = item.Position;

            // Shift positions in the old group
            await ShiftPositionsAfterRemovalAsync(oldGroupId, oldPosition, item.Id);

            // Update item with new group and position
            item.GroupId = dto.TargetGroupId;
            item.Position = ++maxPosition;
            item.UpdatedAt = DateTime.Now;

            _db.Items.Update(item);
        }

        await _db.SaveChangesAsync();
    }

    private async Task ReorderPositionsAsync(Guid itemId, Guid groupId, int oldPosition, int newPosition)
    {
        var items = await _db.Items
            .Where(i => i.GroupId == groupId && i.DeletedAt == null && i.Id != itemId)
            .OrderBy(i => i.Position)
            .ToListAsync();

        if (newPosition < oldPosition)
        {
            foreach (var it in items.Where(i => i.Position >= newPosition && i.Position < oldPosition))
            {
                it.Position++;
                it.UpdatedAt = DateTime.Now;
                _db.Items.Update(it);
            }
        }
        else if (newPosition > oldPosition)
        {
            foreach (var it in items.Where(i => i.Position > oldPosition && i.Position <= newPosition))
            {
                it.Position--;
                it.UpdatedAt = DateTime.Now;
                _db.Items.Update(it);
            }
        }

        await _db.SaveChangesAsync();
    }

    private async Task ShiftPositionsAfterRemovalAsync(Guid groupId, int removedPosition, Guid removedItemId)
    {
        var items = await _db.Items
            .Where(i => i.GroupId == groupId && i.DeletedAt == null && i.Id != removedItemId)
            .Where(i => i.Position > removedPosition)
            .OrderBy(i => i.Position)
            .ToListAsync();

        foreach (var it in items)
        {
            it.Position--;
            it.UpdatedAt = DateTime.Now;
            _db.Items.Update(it);
        }

        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<ItemDto>> CopyItemsAsync(CopyItemsDto dto)
    {
        // Validate target group exists
        var targetGroup = await _db.Groups.FindAsync(dto.TargetGroupId)
            ?? throw new KeyNotFoundException("Target group not found");

        // Get all source items
        var sourceItems = await _db.Items
            .Where(i => dto.ItemIds.Contains(i.Id) && i.DeletedAt == null)
            .ToListAsync();

        var originalGroupId = sourceItems.FirstOrDefault()?.GroupId;

        if (originalGroupId == dto.TargetGroupId)
            throw new InvalidOperationException("Cannot copy items to the same group");

        if (sourceItems.Count == 0)
            throw new KeyNotFoundException("No valid items found to copy");

        // Get the maximum position in the target group
        var maxPosition = await _db.Items
            .Where(i => i.GroupId == dto.TargetGroupId && i.DeletedAt == null)
            .MaxAsync(i => (int?)i.Position) ?? -1;

        var createdItems = new List<ItemDto>();
        var newItemsWithSourceIds = new Dictionary<Guid, Item>();

        // Create new items in the target group
        foreach (var sourceItem in sourceItems)
        {
            var newItem = new Item
            {
                GroupId = dto.TargetGroupId,
                Name = sourceItem.Name,
                Position = ++maxPosition,
                ProjectId = sourceItem.ProjectId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _db.Items.Add(newItem);
            newItemsWithSourceIds[sourceItem.Id] = newItem;
        }

        await _db.SaveChangesAsync();

        // Get all TableValues for the source items in one query
        var sourceItemIds = sourceItems.Select(i => i.Id).ToList();
        var allSourceTableValues = await _db.TableValues
            .Where(tv => tv.ItemId.HasValue && sourceItemIds.Contains(tv.ItemId.Value) && tv.DeletedAt == null)
            .ToListAsync();

        // Group TableValues by their source ItemId
        var tableValuesBySourceItem = allSourceTableValues
            .Where(tv => tv.ItemId.HasValue)
            .GroupBy(tv => tv.ItemId!.Value)
            .ToDictionary(g => g.Key, g => g.ToList());

        // Copy TableValues for each new item
        foreach (var sourceItemId in sourceItemIds)
        {
            if (tableValuesBySourceItem.TryGetValue(sourceItemId, out var sourceTableValues))
            {
                var newItem = newItemsWithSourceIds[sourceItemId];

                foreach (var sourceTableValue in sourceTableValues)
                {
                    var newTableValue = new TableValue
                    {
                        ItemId = newItem.Id,
                        ColumnId = sourceTableValue.ColumnId,
                        Value = sourceTableValue.Value,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    };

                    _db.TableValues.Add(newTableValue);
                }
            }

            createdItems.Add(new ItemDto(
                newItemsWithSourceIds[sourceItemId].Id,
                newItemsWithSourceIds[sourceItemId].GroupId,
                newItemsWithSourceIds[sourceItemId].Name,
                newItemsWithSourceIds[sourceItemId].Position,
                newItemsWithSourceIds[sourceItemId].ProjectId
            ));
        }

        await _db.SaveChangesAsync();

        return createdItems;
    }
}
