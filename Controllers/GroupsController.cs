using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workmonitorAPI.DTOs.GroupDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GroupsController : ControllerBase
{
    private readonly IGroupService _groupService;

    public GroupsController(IGroupService groupService)
    {
        _groupService = groupService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateGroupDto dto)
    {
        var groupDto = await _groupService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetByBoardId), new { boardId = groupDto.BoardId }, groupDto);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _groupService.DeleteAsync(id);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateGroupDto dto)
    {
        try
        {
            await _groupService.UpdateAsync(id, dto);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpGet("board/{boardId}")]
    public async Task<ActionResult<IEnumerable<GroupDto>>> GetByBoardId(Guid boardId)
    {
        var groups = await _groupService.GetByBoardIdAsync(boardId);
        return Ok(groups);
    }

    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<GroupDto>>> Search([FromQuery] SearchGroupsQueryDto queryDto)
    {
        var groups = await _groupService.SearchAsync(queryDto);
        return Ok(groups);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GroupDetailDto>> GetById(Guid id)
    {
        try
        {
            var group = await _groupService.GetByIdAsync(id);
            return Ok(group);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpPost("{id}/copy")]
    public async Task<IActionResult> Copy(Guid id, [FromBody] CopyGroupRequestDto request)
    {
        try
        {
            await _groupService.CopyToAsync(id, request.TargetBoardId);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpPut("{id}/move")]
    public async Task<IActionResult> Move(Guid id, [FromBody] MoveGroupRequestDto request)
    {
        try
        {
            await _groupService.MoveToAsync(id, request.TargetBoardId);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }
}
