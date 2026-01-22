using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class MaqTiempo
{
    public int IdMaqTiempo { get; set; }

    public string? NumParte { get; set; }

    public decimal? Cantidad { get; set; }

    public string? IdProyecto { get; set; }

    public string? IdMaquina { get; set; }

    public string? TipoMaquinado { get; set; }

    public decimal? IdOperador { get; set; }

    public DateTime? FechaHoraInicio { get; set; }

    public DateTime? FechaHoraFin { get; set; }

    public TimeOnly? DifHoras { get; set; }

    public bool? EsArchivado { get; set; }

    public bool? EsCierreAut { get; set; }

    public double? PrecioTot { get; set; }

    public int? HorasProgramacion { get; set; }

    public int? HorasMaquinado { get; set; }

    public bool? HorasTeoricas { get; set; }
}
