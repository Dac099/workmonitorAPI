using System;
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

    public async Task MoveToGroupAsync(Guid id, Guid targetGroupId)
    {
        var item = await _db.Items.FindAsync(id)
            ?? throw new KeyNotFoundException("Item not found");

        if (item.DeletedAt != null)
            throw new KeyNotFoundException("Item not found");

        var targetGroup = await _db.Groups.FindAsync(targetGroupId)
            ?? throw new KeyNotFoundException("Target group not found");

        var oldGroupId = item.GroupId;
        var oldPosition = item.Position;

        await ShiftPositionsAfterRemovalAsync(oldGroupId, oldPosition, id);

        var maxPosition = await _db.Items
            .Where(i => i.GroupId == targetGroupId && i.DeletedAt == null)
            .MaxAsync(i => (int?)i.Position) ?? -1;

        item.GroupId = targetGroup.Id;
        item.Position = maxPosition + 1;
        item.UpdatedAt = DateTime.Now;

        _db.Items.Update(item);
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
}
