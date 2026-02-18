using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class Maquinado
{
    public int IdMaquinado { get; set; }

    public string? NumParte { get; set; }

    public string? IdProyecto { get; set; }

    public string? Medidas { get; set; }

    public decimal? NumPiezas { get; set; }

    public string? IdTipoMaterial { get; set; }

    public decimal? PrecioKg { get; set; }

    public decimal? KgPiezas { get; set; }

    public decimal? LargoM { get; set; }

    public decimal? AnchoM { get; set; }

    public decimal? AlturaMm { get; set; }

    public decimal? TotalLongitud { get; set; }

    public decimal? CostoTotal { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public string? Observaciones { get; set; }

    public int? IdUser { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? Um { get; set; }

    public decimal? CostoGlobal { get; set; }

    public bool? EstatusSol { get; set; }

    public bool? ReTrabajo { get; set; }

    public decimal? HorasTrabajo { get; set; }

    public string? IdEquipo { get; set; }

    public string? TipoMaquinado { get; set; }

    public string? Especificaciones { get; set; }

    public int? IdRequisicion { get; set; }

    public int? PdaRfq { get; set; }

    public string? IdMoneda { get; set; }

    public string? EstatusInt { get; set; }

    public string? MqEstatusInt { get; set; }

    public string? Mecanizado { get; set; }

    public string? Rev { get; set; }

    public string? Marca { get; set; }

    public string? Prioridad { get; set; }

    public string? Spare { get; set; }

    public string? Material { get; set; }

    public string? Acabado { get; set; }

    public double? PesoT { get; set; }

    public string? DmAncho { get; set; }

    public decimal? CostoHorasMaquinas { get; set; }

    public decimal? CostoFinal { get; set; }

    public int? IdPrioridad { get; set; }

    public int? TiempoProgramacion { get; set; }

    public double? TipCambio { get; set; }

    public string? FolioReqMat { get; set; }

    public int? MaquiPadre { get; set; }

    public bool? RechazoCalidad { get; set; }

    public int? IdMaquinadoCalidad { get; set; }

    public virtual TbArticulo? NumParteNavigation { get; set; }
}
