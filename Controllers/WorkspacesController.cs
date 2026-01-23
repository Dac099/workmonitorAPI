using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workmonitorAPI.DTOs.WorkspaceDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WorkspacesController : ControllerBase
{
    private readonly IWorkspaceService _workspaceService;

    public WorkspacesController(IWorkspaceService workspaceService)
    {
        _workspaceService = workspaceService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateWorkspaceDto dto)
    {
        var workspace = await _workspaceService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = workspace.Id }, workspace);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<WorkspaceDto>>> GetAll()
    {
        var workspaces = await _workspaceService.GetAllAsync();
        return Ok(workspaces);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<WorkspaceDto>> GetById(Guid id)
    {
        try
        {
            var workspace = await _workspaceService.GetByIdAsync(id);
            return Ok(workspace);

        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateWorkspaceDto dto)
    {
        try
        {
            await _workspaceService.UpdateAsync(id, dto);
        }catch (KeyNotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _workspaceService.DeleteAsync(id);
        }catch(KeyNotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
