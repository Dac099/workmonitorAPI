using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Data;
using workmonitorAPI.DTOs.WorkspaceDTOs;
using workmonitorAPI.Models;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Services;

public class WorkspaceService : IWorkspaceService
{
    private readonly AppDbContext _db;

    public WorkspaceService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<WorkspaceDto> CreateAsync(CreateWorkspaceDto dto)
    {
        var workspace = new Workspace
        {
            Name = dto.Name,
            Description = dto.Description,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        _db.Workspaces.Add(workspace);
        await _db.SaveChangesAsync();
        return new WorkspaceDto(workspace.Id, workspace.Name, workspace.Description);
    }

    public async Task UpdateAsync(Guid id, UpdateWorkspaceDto dto)
    {
        var workspace = await _db.Workspaces.FindAsync(id) 
            ?? throw new KeyNotFoundException("Workspace not found");

        workspace.Name = dto.Name ?? workspace.Name;
        workspace.Description = dto.Description ?? workspace.Description;
        workspace.UpdatedAt = DateTime.Now;

        _db.Workspaces.Update(workspace);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var workspace = await _db.Workspaces.FindAsync(id)
            ?? throw new KeyNotFoundException("Workspace not found");

        workspace.DeletedAt = DateTime.Now;
        _db.Workspaces.Update(workspace);
        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<WorkspaceDto>> GetAllAsync()
    {
        return await _db.Workspaces
            .AsNoTracking()
            .Where(w => w.DeletedAt == null)
            .Select(w => new WorkspaceDto(w.Id, w.Name, w.Description))
            .ToListAsync();
    }

    public async Task<WorkspaceDto> GetByIdAsync(Guid id)
    {
        var workspace = await _db.Workspaces
            .AsNoTracking()
            .Where(w => w.Id == id && w.DeletedAt == null)
            .Select(w => new WorkspaceDto(w.Id, w.Name, w.Description))
            .FirstOrDefaultAsync()
            ?? throw new KeyNotFoundException("Workspace not found");
        return workspace;
    }
}
