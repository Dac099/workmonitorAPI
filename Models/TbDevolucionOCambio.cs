using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbDevolucionOCambio
{
    public int IdDevolucionOCambio { get; set; }

    public int? IdUbicacion { get; set; }

    public string? TipoUbicacion { get; set; }

    public int? IdDetalleCompra { get; set; }

    public string? EsDevolucionOCambio { get; set; }

    public string? NumParte { get; set; }

    public string? Articulo { get; set; }

    public double? Cantidad { get; set; }

    public string? UnidadMedida { get; set; }

    public double? PrecioUnitario { get; set; }

    public string? Moneda { get; set; }

    public int? IdUserSolicita { get; set; }
}
