using System.Collections.Generic;
using System.Threading.Tasks;
using workmonitorAPI.DTOs.ProyectDTOs;

namespace workmonitorAPI.Services.Interfaces;

public interface IProyectService
{
    Task<IEnumerable<ProyectDto>> GetProyectsAsync(string? search);
    Task<ProyectDto> GetProyectByIdAsync(Guid id);
}
