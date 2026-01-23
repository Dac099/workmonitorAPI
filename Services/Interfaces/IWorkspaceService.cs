using System.Collections.Generic;
using System.Threading.Tasks;
using workmonitorAPI.DTOs.WorkspaceDTOs;
using workmonitorAPI.Models;

namespace workmonitorAPI.Services.Interfaces;

public interface IWorkspaceService
{
    Task<Workspace> CreateAsync(CreateWorkspaceDto dto);
    Task<IEnumerable<WorkspaceDto>> GetAllAsync();
    Task UpdateAsync(Guid id, UpdateWorkspaceDto dto);
    Task DeleteAsync(Guid id);
    Task<WorkspaceDto> GetByIdAsync(Guid id);
}
