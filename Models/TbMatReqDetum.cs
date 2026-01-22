using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbMatReqDetum
{
    public int IdDetaReq { get; set; }

    public int IdReq { get; set; }

    public string DescArticulo { get; set; } = null!;

    public int? Pda { get; set; }

    public double? Cantidad { get; set; }

    public string? NoParte { get; set; }

    public string? UnidadM { get; set; }

    public double? CantEntregada { get; set; }

    public int? Estatus { get; set; }

    public string? IdYat { get; set; }

    public string? IdProyecto { get; set; }

    public int? IdTratamiento { get; set; }

    public int? IdAcabado { get; set; }

    public double? PesoTotal { get; set; }

    public int? EsPiso { get; set; }

    public double? PrecioUnitario { get; set; }

    public string? Moneda { get; set; }

    public string? Medidas { get; set; }

    public int? IdUbicacionAlmacen { get; set; }

    public string? Observaciones { get; set; }

    public string? IdEstatus { get; set; }
}
