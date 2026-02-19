using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workmonitorAPI.DTOs.ProyectDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProyectsController : ControllerBase
{
    private readonly IProyectService _proyectService;

    public ProyectsController(IProyectService proyectService)
    {
        _proyectService = proyectService;
    }

    [HttpGet("search/{search?}")]
    public async Task<IActionResult> Search(string? search = null)
    {
        var result = await _proyectService.GetProyectsAsync(search);
        return Ok(result);
    }
}
