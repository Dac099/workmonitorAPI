using System.Threading.Tasks;
using workmonitorAPI.DTOs.SearcherDTOs;

namespace workmonitorAPI.Services.Interfaces;

public interface ISearcherService
{
  Task<SearcherResultDto> SearchAsync(SearcherQueryDto queryDto);
}
