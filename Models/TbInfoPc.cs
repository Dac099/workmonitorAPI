using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbInfoPc
{
    public string NSerie { get; set; } = null!;

    public string? NSeriebios { get; set; }

    public string? Tag { get; set; }

    public string? Encargado { get; set; }

    public int? IdArea { get; set; }

    public string? TipoPc { get; set; }

    public string? Modelo { get; set; }

    public string? FabricantePb { get; set; }

    public string? IdProductoPb { get; set; }

    public string? FabricanteBios { get; set; }

    public string? VerBios { get; set; }

    public string? FechaBios { get; set; }

    public string? NombreProc { get; set; }

    public string? FabricanteProc { get; set; }

    public string? VelProc { get; set; }

    public string? MRam { get; set; }

    public string? TVideo { get; set; }

    public string? SistemaO { get; set; }

    public string? VerSo { get; set; }

    public string? Arquitectura { get; set; }

    public string? Hostname { get; set; }

    public int? NumMonitores { get; set; }

    public bool? Monitor { get; set; }

    public bool? Teclado { get; set; }

    public bool? Nobreak { get; set; }

    public bool? Mouse { get; set; }

    public DateOnly? FechaIngreso { get; set; }

    public DateOnly? FechaActualizacion { get; set; }

    public int? Estatus { get; set; }

    public string? Observaciones { get; set; }

    public int? IdUbicacion { get; set; }

    public string? CapAlmacenamiento { get; set; }

    public DateOnly? FechaCompra { get; set; }

    public int? TiempoVida { get; set; }

    public int? IdTipocustodia { get; set; }

    public string? EtqReport { get; set; }

    public DateTime? LastConection { get; set; }

    public string? ImpTicket { get; set; }

    public string? VersionSysqb { get; set; }

    public string? UserSysqb { get; set; }

    public virtual TbEstatusEquipo? EstatusNavigation { get; set; }

    public virtual TbArea? IdAreaNavigation { get; set; }

    public virtual TbTipocustodium? IdTipocustodiaNavigation { get; set; }

    public virtual TbUbiEquipo? IdUbicacionNavigation { get; set; }
}
