using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using workmonitorAPI.DTOs.GroupDTOs;

namespace workmonitorAPI.Services.Interfaces;

public interface IGroupService
{
    Task<GroupDto> CreateAsync(CreateGroupDto dto);
    Task<GroupDetailDto> GetByIdAsync(Guid id);
    Task DeleteAsync(Guid id);
    Task UpdateAsync(Guid id, UpdateGroupDto dto);
    Task<IEnumerable<GroupDto>> GetByBoardIdAsync(Guid boardId);
    Task CopyToAsync(Guid groupId, Guid targetBoardId);
    Task MoveToAsync(Guid groupId, Guid targetBoardId);
}
