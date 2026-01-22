using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbCliente
{
    public int IdCliente { get; set; }

    public string? CodCliente { get; set; }

    public string? NomCliente { get; set; }

    public string? DirCliente00 { get; set; }

    public string? DirCliente01 { get; set; }

    public string? NomContacto { get; set; }

    public string? CorreoContacto { get; set; }

    public string? TelCliente { get; set; }

    public string? Rfc { get; set; }

    public bool? EstadoCliente { get; set; }

    public string? DirRutaGral { get; set; }

    public bool? Tipo { get; set; }

    public string? IdSector { get; set; }

    public string? Puesto { get; set; }

    public int? IdEmpresa { get; set; }

    public virtual ICollection<TbProyect> TbProyects { get; set; } = new List<TbProyect>();
}
