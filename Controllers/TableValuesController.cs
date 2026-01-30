using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workmonitorAPI.DTOs.TableValueDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TableValuesController : ControllerBase
{
    private readonly ITableValueService _tableValueService;

    public TableValuesController(ITableValueService tableValueService)
    {
        _tableValueService = tableValueService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateTableValueDto dto)
    {
        try
        {
            var tableValueDto = await _tableValueService.CreateAsync(dto);
            return CreatedAtAction(nameof(Create), new { id = tableValueDto.Id }, tableValueDto);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateTableValueDto dto)
    {
        try
        {
            await _tableValueService.UpdateAsync(id, dto);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
    }
}
