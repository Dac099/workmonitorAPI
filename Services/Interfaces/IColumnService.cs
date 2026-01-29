using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using workmonitorAPI.DTOs.ColumnDTOs;

namespace workmonitorAPI.Services.Interfaces;

public interface IColumnService
{
    Task<ColumnDto> CreateAsync(CreateColumnDto dto);
    Task UpdateAsync(Guid id, UpdateColumnDto dto);
    Task DeleteAsync(Guid id);
    Task<IEnumerable<ColumnDto>> GetByBoardIdAsync(Guid boardId);
}
