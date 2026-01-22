using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbCompra
{
    public int IdDetalleCompra { get; set; }

    public int IdOrdenCompra { get; set; }

    public int Pda { get; set; }

    public string PomNumber { get; set; } = null!;

    public string? NoParte { get; set; }

    public string DescArticulo { get; set; } = null!;

    public double Cantidad { get; set; }

    public double? PrecioUnitario { get; set; }

    public double? Total { get; set; }

    public string UnidadMedida { get; set; } = null!;

    public double? PoItemQtyrecived { get; set; }

    public bool? PoItemEstatus { get; set; }

    public string? IdEntrega { get; set; }

    public string? RevItem { get; set; }

    public DateTime? FechaRec { get; set; }

    public string? Observaciones { get; set; }

    public string? IdProyCt { get; set; }

    public string? NotaRfq { get; set; }

    public int? IdDetaRfq { get; set; }

    public virtual TbOrdenCompra IdOrdenCompraNavigation { get; set; } = null!;

    public virtual TbUm UnidadMedidaNavigation { get; set; } = null!;
}
