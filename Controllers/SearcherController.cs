using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using workmonitorAPI.DTOs.SearcherDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SearcherController : ControllerBase
{
  private readonly ISearcherService _searcherService;

  public SearcherController(ISearcherService searcherService)
  {
    _searcherService = searcherService;
  }

  [HttpGet]
  public async Task<ActionResult<SearcherResultDto>> Search([FromQuery] SearcherQueryDto queryDto)
  {
    var searchResult = await _searcherService.SearchAsync(queryDto);
    return Ok(searchResult);
  }
}
