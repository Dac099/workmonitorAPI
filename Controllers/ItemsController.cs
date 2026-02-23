using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workmonitorAPI.DTOs.ItemDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ItemsController : ControllerBase
{
    private readonly IItemService _itemService;

    public ItemsController(IItemService itemService)
    {
        _itemService = itemService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateItemDto dto)
    {
        var itemDto = await _itemService.CreateAsync(dto);
        return CreatedAtAction(nameof(Create), new { id = itemDto.Id }, itemDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateItemDto dto)
    {
        try
        {
            await _itemService.UpdateAsync(id, dto);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteItemsDto dto)
    {
        try
        {
            await _itemService.DeleteAsync(dto);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
    }

    [HttpPut("move")]
    public async Task<IActionResult> Move([FromBody] MoveItemRequestDto dto)
    {
        try
        {
            await _itemService.MoveToGroupAsync(dto);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
    }

    [HttpPost("copy")]
    public async Task<IActionResult> CopyItems([FromBody] CopyItemsDto dto)
    {
        try
        {
            var copiedItems = await _itemService.CopyItemsAsync(dto);
            return Ok(copiedItems);
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
    }
}
