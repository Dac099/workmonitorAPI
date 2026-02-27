using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workmonitorAPI.DTOs.BoardDTOs;
using workmonitorAPI.DTOs.GanttDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BoardsController : ControllerBase
{
    private readonly IBoardService _boardService;
    private readonly IExportService _exportService;

    public BoardsController(IBoardService boardService, IExportService exportService)
    {
        _boardService = boardService;
        _exportService = exportService;
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

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BoardWithWorkspaceNameDto>>> GetAll()
    {
        var boards = await _boardService.GetAllWithWorkspaceNameAsync();
        return Ok(boards);
    }

    [HttpGet("{boardId}/gantt")]
    public async Task<ActionResult<GanttBoardDto>> GetGanttData(Guid boardId, [FromQuery] Guid? timelineColumnId)
    {
        try
        {
            var data = await _boardService.GetGanttDataAsync(boardId, timelineColumnId);
            return Ok(data);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpGet("cobranza")]
    public async Task<ActionResult<BoardDto>> GetCollectionBoard()
    {
        try
        {
            var board = await _boardService.GetCollectionBoardAsync();
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

    [HttpPost("{boardId}/export")]
    public async Task<IActionResult> ExportToExcel(Guid boardId, [FromBody] ExportBoardDto exportDto)
    {
        try
        {
            var excelBytes = await _exportService.ExportBoardToExcelAsync(boardId, exportDto);
            
            var board = await _boardService.GetByIdAsync(boardId);
            var fileName = $"{board.Name}_Export_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
            
            return File(excelBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }
}
