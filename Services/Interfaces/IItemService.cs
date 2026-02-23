using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using workmonitorAPI.DTOs.ItemDTOs;

namespace workmonitorAPI.Services.Interfaces;

public interface IItemService
{
    Task<ItemDto> CreateAsync(CreateItemDto dto);
    Task UpdateAsync(Guid id, UpdateItemDto dto);
    Task DeleteAsync(Guid id);
    Task MoveToGroupAsync(MoveItemRequestDto dto);
    Task<IEnumerable<ItemDto>> CopyItemsAsync(CopyItemsDto dto);
}
