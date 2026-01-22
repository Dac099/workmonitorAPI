using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbComprasTemp
{
    public int IdRecepcionCompra { get; set; }

    public int IdDetalleCompra { get; set; }

    public int IdOrdenCompra { get; set; }

    public int? Pda { get; set; }

    public string? PomNumber { get; set; }

    public string? NoParte { get; set; }

    public string DescArticulo { get; set; } = null!;

    public string UnidadMedida { get; set; } = null!;

    public double? CantidadRecibida { get; set; }

    public DateTime? FechaRecepcion { get; set; }
}
