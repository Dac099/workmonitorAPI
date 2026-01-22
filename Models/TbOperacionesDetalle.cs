using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbOperacionesDetalle
{
    public int IdOperacionesDetalles { get; set; }

    public int? IdOperacion { get; set; }

    public DateTime? FechaHoraInicio { get; set; }

    public DateTime? FechaHoraFin { get; set; }

    public string? TiempoTotalOperacionReal { get; set; }

    public string? EstatusOpIndividual { get; set; }

    public bool? Finalizado { get; set; }

    public decimal? CostoFinal { get; set; }

    public int? IdMaquinadoDetalle { get; set; }

    public string? FolioReqMatInd { get; set; }

    public double? CostoCortePieza { get; set; }

    public double? SetupPieza { get; set; }

    public double? CostoSetupPieza { get; set; }

    public bool? OperacionFallida { get; set; }

    public string? FolioDesp { get; set; }
}
