using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbMaquinadosCalidad
{
    public int IdMaquinadoCalida { get; set; }

    public string? NumParte { get; set; }

    public string? IdProyecto { get; set; }

    public string? TipoMaquinado { get; set; }

    public double? Cantidad { get; set; }

    public string? Spare { get; set; }

    public string? Material { get; set; }

    public string? Estatus { get; set; }

    public string? Mecanizado { get; set; }

    public string? Acabado { get; set; }

    public string? Revision { get; set; }

    public double? PesoTeorico { get; set; }

    public string? FolioSalida { get; set; }

    public int? IdDetaRfq { get; set; }

    public int? NumSalida { get; set; }

    public int? IdOrdenCompra { get; set; }

    public string? MotivoRechazo { get; set; }

    public string? EstatusRechazo { get; set; }

    public int? IdMaquinadoRechazo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? CantPendienteRec { get; set; }

    public int? CantRecibida { get; set; }

    public int? CantRechazada { get; set; }

    public DateTime? FechaRechazo { get; set; }
}
