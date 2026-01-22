using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbInvProPiso
{
    public int IdProPiso { get; set; }

    public string? IdDetalleCompra { get; set; }

    public string? NumParte { get; set; }

    public string? NomArticulo { get; set; }

    public string? UnidadMedida { get; set; }

    public double? Cantidad { get; set; }

    public double? PrecioUnitario { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? Observacion { get; set; }

    public int? Estatus { get; set; }

    public string? Tipo { get; set; }

    public int? IdDestino { get; set; }

    public int? IdOrigen { get; set; }

    public int? Cliente { get; set; }

    public int? IdRegEntrada { get; set; }

    public double? CantidadRecibida { get; set; }

    public double? CantidadDisponible { get; set; }

    public string? Moneda { get; set; }

    public int? IdDevolucionOCambio { get; set; }

    public int? IdAutorizaAutCam { get; set; }

    public int? IdSolicitaDevolucionOCambio { get; set; }

    public string? Observaciones { get; set; }

    public string? IdEstatus { get; set; }

    public int? IdUser { get; set; }
}
