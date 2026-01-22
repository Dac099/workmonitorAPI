using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbCompInterno
{
    public int IdDetalleComInternos { get; set; }

    public int? IdOcInternos { get; set; }

    public int? Pda { get; set; }

    public string? PomNumberInt { get; set; }

    public string? NoParte { get; set; }

    public string? DescArticulo { get; set; }

    public double? Cantidad { get; set; }

    public double? PrecioUnitario { get; set; }

    public double? Total { get; set; }

    public string? UnidadMedida { get; set; }

    public double? PoItemQtyrecived { get; set; }

    public bool? PoItemEstatus { get; set; }

    public string? RevItem { get; set; }

    public DateTime? FechaRec { get; set; }

    public string? IdProyCt { get; set; }

    public int? IdDetaRfq { get; set; }
}
