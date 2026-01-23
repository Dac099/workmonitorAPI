using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using workmonitorAPI.DTOs.BoardDTOs;
using workmonitorAPI.Models;

namespace workmonitorAPI.Services.Interfaces;

public interface IBoardService
{
    Task<BoardDto> GetByIdAsync(Guid id);
    Task<BoardDto> CreateAsync(CreateBoardDto dto);
    Task DeleteAsync(Guid id);
    Task UpdateAsync(Guid id, UpdateBoardDto dto);
    Task<IEnumerable<BoardDto>> GetByWorkspaceIdAsync(Guid workspaceId);
}
