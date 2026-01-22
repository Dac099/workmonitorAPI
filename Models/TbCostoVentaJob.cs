using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbCostoVentaJob
{
    public int IdCostoVenta { get; set; }

    public string? IdProyecto { get; set; }

    public double? Costo { get; set; }

    public int? IdUser { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
