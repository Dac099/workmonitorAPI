using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using workmonitorAPI.DTOs.ChatDTOs;

namespace workmonitorAPI.Services.Interfaces;

public interface IChatService
{
  Task<ChatDto> CreateAsync(CreateChatDto dto);
  Task<ChatDto> UpdateAsync(Guid id, UpdateChatDto dto);
  Task DeleteAsync(Guid id);
}
