using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbOperacionesMaquinado
{
    public int IdOperacionMaquinado { get; set; }

    public string? NumParte { get; set; }

    public string? IdMaquina { get; set; }

    public string? IdOperacion { get; set; }

    public int? CambiosHerramientas { get; set; }

    public int? CambiosPosicion { get; set; }

    public string? TiempoEstimado { get; set; }

    public string? Finalizado { get; set; }

    public int? IdOperador { get; set; }

    public string? TiempoTotalOperacion { get; set; }

    public DateTime? FechaHoraInicio { get; set; }

    public DateTime? FechaHoraFin { get; set; }

    public string? TiempoTotalOperacionReal { get; set; }

    public int? IdMaquinados { get; set; }

    public string? EstatusOp { get; set; }
}
