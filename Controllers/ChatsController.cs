using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workmonitorAPI.DTOs.ChatDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChatsController : ControllerBase
{
  private readonly IChatService _chatService;

  public ChatsController(IChatService chatService)
  {
    _chatService = chatService;
  }

  [HttpPost]
  public async Task<IActionResult> Create([FromBody] CreateChatDto dto)
  {
    try
    {
      var chatDto = await _chatService.CreateAsync(dto);
      return CreatedAtAction(nameof(Create), new { id = chatDto.Id }, chatDto);
    }
    catch (KeyNotFoundException ex)
    {
      return NotFound(new { message = ex.Message });
    }
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> Update(Guid id, [FromBody] UpdateChatDto dto)
  {
    try
    {
      var chatDto = await _chatService.UpdateAsync(id, dto);
      return Ok(chatDto);
    }
    catch (KeyNotFoundException ex)
    {
      return NotFound(new { message = ex.Message });
    }
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> Delete(Guid id)
  {
    try
    {
      await _chatService.DeleteAsync(id);
      return NoContent();
    }
    catch (KeyNotFoundException ex)
    {
      return NotFound(new { message = ex.Message });
    }
  }
}
