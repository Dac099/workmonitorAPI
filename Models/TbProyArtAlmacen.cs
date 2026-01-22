using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProyArtAlmacen
{
    public int IdAuto { get; set; }

    public int IdDetaAlmArt { get; set; }

    public int? IdOrdeCompra { get; set; }

    public string? NoParte { get; set; }

    public string? DescArticulo { get; set; }

    public double? Cantidad { get; set; }

    public double? PrecioUnitario { get; set; }

    public string? UnidadMedida { get; set; }

    public double? PoItemQtyrecived { get; set; }

    public bool? PoItemEstatus { get; set; }

    public string? IdEntrega { get; set; }

    public string? RevItem { get; set; }

    public string? IdProyect { get; set; }

    public DateTime? Fingreso { get; set; }

    public string? Usuario { get; set; }

    public double? PzasDisponibles { get; set; }

    public double? PzasTransferidas { get; set; }

    public string? IdUbicacion { get; set; }

    public int? IdUsuario { get; set; }

    public string? Nota { get; set; }

    public bool? Estatus { get; set; }

    public string? Moneda { get; set; }

    public int? IdDevolucionOCambio { get; set; }

    public int? IdAutorizaAutCam { get; set; }

    public int? IdSolicitaDevolucionOCambio { get; set; }

    public string? Observaciones { get; set; }

    public string? IdEstatus { get; set; }

    public string? TipoMaq { get; set; }

    public int? IdDetaRfq { get; set; }

    public virtual TbUm? UnidadMedidaNavigation { get; set; }
}
