using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbReqMaterial
{
    public int IdReq { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdDepto { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdUserAutoriza { get; set; }

    public int? IdUserReceives { get; set; }

    public string? ObservSol { get; set; }

    public string? Estatus { get; set; }

    public bool? EsSalidaProveedor { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public string? UserEntrega { get; set; }

    public string? ObserEntrerga { get; set; }

    public int? Impreso { get; set; }

    public string? NumReqSal { get; set; }

    public string? Folio { get; set; }

    public string? TipoReq { get; set; }

    public DateTime? FProcesoSap { get; set; }
}
