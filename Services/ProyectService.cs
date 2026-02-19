using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Data;
using workmonitorAPI.DTOs.ProyectDTOs;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Services;

public class ProyectService : IProyectService
{
    private readonly AppDbContext _db;

    public ProyectService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<ProyectDto>> GetProyectsAsync(string? search)
    {
        var query = _db.TbProyects
            .AsNoTracking()
            .Include(p => p.IdClienteNavigation)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(search))
        {
            var searchLower = search.ToLower();
            query = query.Where(p => 
                p.IdProyect.ToLower().Contains(searchLower) ||
                (p.NomProyecto != null && p.NomProyecto.ToLower().Contains(searchLower)) ||
                (p.IdClienteNavigation != null && p.IdClienteNavigation.NomCliente != null && p.IdClienteNavigation.NomCliente.ToLower().Contains(searchLower))
            );
        }

        var result = await query
            .Select(p => new ProyectDto(
                p.IdProyect,
                p.NomProyecto,
                p.IdClienteNavigation != null ? p.IdClienteNavigation.NomCliente : null,
                p.IdCliente
            ))
            .ToListAsync();

        return result;
    }
}
