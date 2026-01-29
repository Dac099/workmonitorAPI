using System;
using System.Threading.Tasks;
using workmonitorAPI.DTOs.ItemDTOs;

namespace workmonitorAPI.Services.Interfaces;

public interface IItemService
{
    Task<ItemDto> CreateAsync(CreateItemDto dto);
    Task UpdateAsync(Guid id, UpdateItemDto dto);
    Task DeleteAsync(Guid id);
    Task MoveToGroupAsync(Guid id, Guid targetGroupId);
}
