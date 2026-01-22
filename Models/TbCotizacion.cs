using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbCotizacion
{
    public int IdCotizacion { get; set; }

    public string Cotizacion { get; set; } = null!;

    public string? Revision { get; set; }

    public int? IdCliente { get; set; }

    public string? NomProyecto { get; set; }

    public double? PresupuestoMaquinados { get; set; }

    public double? PresupuestoPLineaMecanica { get; set; }

    public double? PresupuestoElectrico { get; set; }

    public double? PresupuestoComponentesEspeciales { get; set; }

    public int? HorasDiseñoMecanico { get; set; }

    public int? HorasDiseñoElectrico { get; set; }

    public int? HorasEnsambleProgramacion { get; set; }

    public int? HorasOtro { get; set; }

    public int? SemanasPropuestas { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaPo { get; set; }

    public string? OcCliente { get; set; }

    public string? UrlCotizacion { get; set; }

    public string? UrlPo { get; set; }

    public string? Estatus { get; set; }

    public int? IdUser { get; set; }

    public string? Notas { get; set; }

    public string? TipoCotizacion { get; set; }

    public int? IdResponsable { get; set; }

    public DateTime? ProximaComunicacion { get; set; }

    public DateTime? UltimaComunicacion { get; set; }

    public string? ProbabilidadCierre { get; set; }

    public DateTime? FechaObjetivo { get; set; }

    public DateTime? FechaEnvio { get; set; }

    public double? MontoTotal { get; set; }

    public string? NumeroTrabajo { get; set; }

    public string? Relevancia { get; set; }

    public DateTime? FechaAutorizacion { get; set; }

    public int? IdAutoriza { get; set; }

    public int? IdSupervisor { get; set; }

    public string? Lenguaje { get; set; }

    public string? TipoProyecto { get; set; }

    public string? HorasProgramacion { get; set; }
}
