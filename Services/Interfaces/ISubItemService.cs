using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using workmonitorAPI.DTOs.SubItemDTOs;

namespace workmonitorAPI.Services.Interfaces;

public interface ISubItemService
{
  Task<IEnumerable<SubItemWithValuesDto>> GetByItemIdWithValuesAsync(Guid itemId);
  Task<SubItemDto> CreateAsync(CreateSubItemDto dto);
  Task UpdateAsync(Guid id, UpdateSubItemDto dto);
  Task DeleteAsync(Guid id);
}
