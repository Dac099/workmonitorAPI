using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Data;
using workmonitorAPI.DTOs.GroupDTOs;
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
