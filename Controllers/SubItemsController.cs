using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workmonitorAPI.DTOs.SubItemDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubItemsController : ControllerBase
{
  private readonly ISubItemService _subItemService;

  public SubItemsController(ISubItemService subItemService)
  {
    _subItemService = subItemService;
  }

  [HttpGet("parent/{itemId}")]
  public async Task<IActionResult> GetByItemId(Guid itemId)
  {
    try
    {
      var subItems = await _subItemService.GetByItemIdWithValuesAsync(itemId);
      return Ok(subItems);
    }
    catch (KeyNotFoundException ex)
    {
      return NotFound(new { message = ex.Message });
    }
  }

  [HttpPost]
  public async Task<IActionResult> Create([FromBody] CreateSubItemDto dto)
  {
    try
    {
      var subItem = await _subItemService.CreateAsync(dto);
      return CreatedAtAction(nameof(Create), new { id = subItem.Id }, subItem);
    }
    catch (KeyNotFoundException ex)
    {
      return NotFound(new { message = ex.Message });
    }
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> Update(Guid id, [FromBody] UpdateSubItemDto dto)
  {
    try
    {
      await _subItemService.UpdateAsync(id, dto);
      return NoContent();
    }
    catch (KeyNotFoundException ex)
    {
      return NotFound(new { message = ex.Message });
    }
  }

  [HttpDelete]
  public async Task<IActionResult> Delete([FromBody] DeleteSubItemsDto dto)
  {
    try
    {
      await _subItemService.DeleteAsync(dto);
      return NoContent();
    }
    catch (KeyNotFoundException ex)
    {
      return NotFound(new { message = ex.Message });
    }
  }
}
