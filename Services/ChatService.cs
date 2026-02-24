using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Data;
using workmonitorAPI.DTOs.ChatDTOs;
using workmonitorAPI.Models;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Services;

public class ChatService : IChatService
{
  private readonly AppDbContext _db;

  public ChatService(AppDbContext db)
  {
    _db = db;
  }

  public async Task<ChatDto> CreateAsync(CreateChatDto dto)
  {
    var item = await _db.Items.FindAsync(dto.ItemId)
        ?? throw new KeyNotFoundException("Item not found");

    if (item.DeletedAt != null)
      throw new KeyNotFoundException("Item not found");

    var chat = new Chat
    {
      ItemId = dto.ItemId,
      Message = dto.Message,
      Responses = dto.Responses,
      Tasks = dto.Tasks,
      CreatedAt = DateTime.Now,
      UpdatedAt = DateTime.Now
    };

    _db.Chats.Add(chat);
    await _db.SaveChangesAsync();

    return new ChatDto(
        chat.Id,
        chat.ItemId,
        chat.Message,
        chat.CreatedBy,
        chat.Responses,
        chat.Tasks,
        chat.CreatedAt.ToString()
    );
  }

  public async Task<ChatDto> UpdateAsync(Guid id, UpdateChatDto dto)
  {
    var chat = await _db.Chats.FindAsync(id)
        ?? throw new KeyNotFoundException("Chat not found");

    if (chat.DeletedAt != null)
      throw new KeyNotFoundException("Chat not found");

    if (dto.Message != null)
      chat.Message = dto.Message;

    if (dto.Responses != null)
      chat.Responses = dto.Responses;

    if (dto.Tasks != null)
      chat.Tasks = dto.Tasks;

    chat.UpdatedAt = DateTime.Now;

    _db.Chats.Update(chat);
    await _db.SaveChangesAsync();

    return new ChatDto(
        chat.Id,
        chat.ItemId,
        chat.Message,
        chat.CreatedBy,
        chat.Responses,
        chat.Tasks,
        chat.CreatedAt.ToString()
    );
  }

  public async Task DeleteAsync(Guid id)
  {
    var chat = await _db.Chats.FindAsync(id)
        ?? throw new KeyNotFoundException("Chat not found");

    if (chat.DeletedAt != null)
      throw new KeyNotFoundException("Chat not found");

    chat.DeletedAt = DateTime.Now;
    chat.UpdatedAt = DateTime.Now;

    _db.Chats.Update(chat);
    await _db.SaveChangesAsync();
  }
}
