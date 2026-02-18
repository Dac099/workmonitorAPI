using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using workmonitorAPI.DTOs.TableValueDTOs;

namespace workmonitorAPI.Services.Interfaces;

public interface ITableValueService
{
    Task<TableValueDto> CreateAsync(CreateTableValueDto dto);
    Task UpdateAsync(Guid id, UpdateTableValueDto dto);
    Task<IEnumerable<StatusValuesByColumnDto>> GetStatusValuesGroupedByColumnAsync(Guid boardId);
    Task<bool> DeleteAsync(Guid id);
}
