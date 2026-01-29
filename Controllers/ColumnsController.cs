using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workmonitorAPI.DTOs.ColumnDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ColumnsController : ControllerBase
{
    private readonly IColumnService _columnService;

    public ColumnsController(IColumnService columnService)
    {
        _columnService = columnService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateColumnDto dto)
    {
        var columnDto = await _columnService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetByBoardId), new { boardId = columnDto.BoardId }, columnDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateColumnDto dto)
    {
        try
        {
            await _columnService.UpdateAsync(id, dto);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _columnService.DeleteAsync(id);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpGet("board/{boardId}")]
    public async Task<ActionResult<IEnumerable<ColumnDto>>> GetByBoardId(Guid boardId)
    {
        var columns = await _columnService.GetByBoardIdAsync(boardId);
        return Ok(columns);
    }
}
