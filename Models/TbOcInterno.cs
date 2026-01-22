using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbOcInterno
{
    public int IdOcInternos { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdUsuario { get; set; }

    public string? Estatus { get; set; }

    public string? PomNumberInt { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public double? Importe { get; set; }

    public double? Iva { get; set; }

    public double? Total { get; set; }

    public string? Moneda { get; set; }
}
