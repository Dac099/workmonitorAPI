using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProyect
{
    public string IdProyect { get; set; } = null!;

    public int? IdCliente { get; set; }

    public int? IdUser { get; set; }

    public string? IdTipoPro { get; set; }

    public string? IdEstado { get; set; }

    public string? IdSector { get; set; }

    public string? NomProyecto { get; set; }

    public string? DescProyecto { get; set; }

    public int? LiderProyecto { get; set; }

    public double? PresupuestoInicial { get; set; }

    public double? PresupuestoAut { get; set; }

    public string? IdMoneda { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public string? RutaArchivos { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? Nota { get; set; }

    public string? User01 { get; set; }

    public string? NumSerie { get; set; }

    public double? TipoCambio { get; set; }

    public string? NumOc { get; set; }

    public string? NumCot { get; set; }

    public bool? Facturado { get; set; }

    public string? NumFactura { get; set; }

    public double? PresupuestoMeca { get; set; }

    public double? PresupuestoAutMeca { get; set; }

    public double? PresupuestoMaqui { get; set; }

    public double? PresupuestoAutMaqui { get; set; }

    public double? PresupuestoElect { get; set; }

    public double? PresupuestoAutElect { get; set; }

    public double? PresupuestoOtro { get; set; }

    public double? PresupuestoAutOtro { get; set; }

    public int? CantidadJobs { get; set; }

    public int? HorasDiseñoMecanico { get; set; }

    public int? HorasDiseñoElectrico { get; set; }

    public int? HorasEnsambleProgramacion { get; set; }

    public int? HorasProgramacion { get; set; }

    public int? HorasOtros { get; set; }

    public DateOnly? FechaKickoff { get; set; }

    public DateOnly? FechaPo { get; set; }

    public bool? FechaIguales { get; set; }

    public int? SemanasPropuestas { get; set; }

    public string? ResponsableProjectManager { get; set; }

    public string? ResponsableDiseñadorMecanico { get; set; }

    public string? ResponsableDiseñadorElectrico { get; set; }

    public string? ResponsableProgramador { get; set; }

    public string? ResponsableEnsamblador { get; set; }

    public string? LinkCarpeta { get; set; }

    public virtual TbCliente? IdClienteNavigation { get; set; }

    public virtual TbEqEstatus? IdEstadoNavigation { get; set; }

    public virtual TbOcMonedum? IdMonedaNavigation { get; set; }

    public virtual TbProTipo? IdTipoProNavigation { get; set; }

    public virtual TbUser? IdUserNavigation { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual TbProyLider? LiderProyectoNavigation { get; set; }

    public virtual ICollection<TbMachinesProject> TbMachinesProjects { get; set; } = new List<TbMachinesProject>();

    public virtual ICollection<TbProRev> TbProRevs { get; set; } = new List<TbProRev>();
}
