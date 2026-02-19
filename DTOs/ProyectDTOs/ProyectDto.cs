
namespace workmonitorAPI.DTOs.ProyectDTOs;

public record ProyectDto(
    string IdProyect,
    string? NomProyecto,
    string? NomCliente,
    int? IdCliente
);
