using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Data;
using workmonitorAPI.DTOs.ChatDTOs;
using workmonitorAPI.DTOs.GroupDTOs;
using workmonitorAPI.DTOs.ItemDTOs;
using workmonitorAPI.DTOs.TableValueDTOs;
using workmonitorAPI.Models;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Services;

public class GroupService : IGroupService
{
    private readonly AppDbContext _db;

    public GroupService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<GroupDto> CreateAsync(CreateGroupDto dto)
    {
        var maxPosition = await _db.Groups
            .Where(g => g.BoardId == dto.BoardId && g.DeletedAt == null)
            .MaxAsync(g => (int?)g.Position) ?? -1;

        var nextPosition = maxPosition + 1;

        var group = new Group
        {
            BoardId = dto.BoardId,
            Name = dto.Name,
            Position = nextPosition,
            Color = dto.Color,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        _db.Groups.Add(group);
        await _db.SaveChangesAsync();
        return new GroupDto(group.Id, group.BoardId, group.Name, group.Position, group.Color);
    }

    public async Task DeleteAsync(Guid id)
    {
        var group = await _db.Groups.FindAsync(id)
            ?? throw new KeyNotFoundException("Group not found");

        group.DeletedAt = DateTime.Now;
        _db.Groups.Update(group);
        await _db.SaveChangesAsync();
    }

    public async Task UpdateAsync(Guid id, UpdateGroupDto dto)
    {
        var group = await _db.Groups.FindAsync(id)
            ?? throw new KeyNotFoundException("Group not found");

        if (dto.Name != null)
            group.Name = dto.Name;
        if (dto.Position.HasValue)
            group.Position = dto.Position.Value;
        if (dto.Color != null)
            group.Color = dto.Color;

        group.UpdatedAt = DateTime.Now;

        _db.Groups.Update(group);
        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<GroupDto>> GetByBoardIdAsync(Guid boardId)
    {
        return await _db.Groups
            .AsNoTracking()
            .Where(g => g.BoardId == boardId && g.DeletedAt == null)
            .OrderBy(g => g.Position)
            .Select(g => new GroupDto(g.Id, g.BoardId, g.Name, g.Position, g.Color))
            .ToListAsync();
    }

    public async Task<IEnumerable<GroupDto>> SearchAsync(SearchGroupsQueryDto queryDto)
    {
        var query = _db.Groups
            .AsNoTracking()
            .Where(g => g.DeletedAt == null)
            .AsQueryable();

        if (queryDto.BoardId.HasValue)
            query = query.Where(g => g.BoardId == queryDto.BoardId.Value);

        if (queryDto.GroupId.HasValue)
            query = query.Where(g => g.Id == queryDto.GroupId.Value);

        if (!string.IsNullOrWhiteSpace(queryDto.GroupName))
        {
            var normalizedGroupName = queryDto.GroupName.ToLower().Replace(" ", string.Empty);
            query = query.Where(g =>
                EF.Functions.Like(
                    (g.Name ?? string.Empty).ToLower().Replace(" ", string.Empty),
                    $"%{normalizedGroupName}%"));
        }

        return await query
            .OrderBy(g => g.Position)
            .Select(g => new GroupDto(g.Id, g.BoardId, g.Name, g.Position, g.Color))
            .ToListAsync();
    }

    public async Task<GroupDetailDto> GetByIdAsync(Guid id)
    {
        var group = await _db.Groups
            .AsNoTracking()
            .Where(g => g.Id == id && g.DeletedAt == null)
            .Select(g => new GroupDto(g.Id, g.BoardId, g.Name, g.Position, g.Color))
            .FirstOrDefaultAsync()
            ?? throw new KeyNotFoundException("Group not found");

        var items = await _db.Items
            .AsNoTracking()
            .Where(i => i.GroupId == id && i.DeletedAt == null)
            .OrderBy(i => i.Position)
            .Select(i => new ItemDto(i.Id, i.GroupId, i.Name, i.Position, i.ProjectId))
            .ToListAsync();

        var itemIds = items.Select(i => i.Id).ToList();

        var values = await _db.TableValues
            .AsNoTracking()
            .Where(tv => tv.ItemId != null && itemIds.Contains(tv.ItemId.Value) && tv.DeletedAt == null)
            .Join(
                _db.Columns.AsNoTracking(),
                tv => tv.ColumnId,
                c => c.Id,
                (tv, c) => new { tv.Id, tv.ItemId, tv.ColumnId, tv.Value, ColumnType = c.Type }
            )
            .ToListAsync();

        var chats = await _db.Chats
            .AsNoTracking()
            .Where(c => c.ItemId != null && itemIds.Contains(c.ItemId.Value) && c.DeletedAt == null)
            .Select(c => new ChatDto(c.Id, c.ItemId, c.Message, c.CreatedBy, c.Responses, c.Tasks, c.CreatedAt.ToString()))
            .ToListAsync();

        var valuesByItem = values
            .GroupBy(v => v.ItemId!.Value)
            .ToDictionary(
                g => g.Key,
                g => g.Select(v => new TableValueWithTypeDto(v.Id, v.ItemId, v.ColumnId, v.Value, v.ColumnType)).ToList()
            );

        var chatsByItem = chats
            .GroupBy(c => c.ItemId!.Value)
            .ToDictionary(
                g => g.Key,
                g => g.Select(c => new ChatDto(c.Id, c.ItemId, c.Message, c.CreatedBy, c.Responses, c.Tasks, c.CreatedAt)).ToList()
            );

        var itemDtos = items.Select(i =>
        {
            valuesByItem.TryGetValue(i.Id, out var itemValues);
            chatsByItem.TryGetValue(i.Id, out var itemChats);

            return new ItemWithValuesDto(
                i.Id,
                i.GroupId,
                i.Name,
                i.Position,
                i.ProjectId,
                itemValues ?? new List<TableValueWithTypeDto>(),
                itemChats ?? new List<ChatDto>()
            );
        }).ToList();

        return new GroupDetailDto(group.Id, group.BoardId, group.Name, group.Position, group.Color, itemDtos);
    }

    public async Task CopyToAsync(Guid groupId, Guid targetBoardId)
    {
        var sourceGroup = await _db.Groups
            .Include(g => g.Items)
            .FirstOrDefaultAsync(g => g.Id == groupId && g.DeletedAt == null)
            ?? throw new KeyNotFoundException("Group not found");

        var newGroup = new Group
        {
            BoardId = targetBoardId,
            Name = sourceGroup.Name,
            Position = sourceGroup.Position,
            Color = sourceGroup.Color,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        _db.Groups.Add(newGroup);
        await _db.SaveChangesAsync();
    }

    public async Task MoveToAsync(Guid groupId, Guid targetBoardId)
    {
        var group = await _db.Groups.FindAsync(groupId)
            ?? throw new KeyNotFoundException("Group not found");

        var _ = await _db.Boards.FindAsync(targetBoardId)
            ?? throw new KeyNotFoundException("Target board not found");

        group.BoardId = targetBoardId;
        group.UpdatedAt = DateTime.Now;

        _db.Groups.Update(group);
        await _db.SaveChangesAsync();
    }
}
