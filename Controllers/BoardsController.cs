using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workmonitorAPI.DTOs.BoardDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BoardsController : ControllerBase
{
    private readonly IBoardService _boardService;

    public BoardsController(IBoardService boardService)
    {
        _boardService = boardService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateBoardDto dto)
    {
        var boardDto = await _boardService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = boardDto.Id }, boardDto);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<BoardDto>> GetById(Guid id)
    {
        try
        {
            var board = await _boardService.GetByIdAsync(id);
            return Ok(board);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpGet("workspace/{workspaceId}")]
    public async Task<ActionResult<IEnumerable<BoardDto>>> GetByWorkspaceId(Guid workspaceId)
    {
        var boards = await _boardService.GetByWorkspaceIdAsync(workspaceId);
        return Ok(boards);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateBoardDto dto)
    {
        try
        {
            await _boardService.UpdateAsync(id, dto);
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
            await _boardService.DeleteAsync(id);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }
}
