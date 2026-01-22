using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbReqDetum
{
    public int IdDetaReq { get; set; }

    public int IdReq { get; set; }

    public string DescArticulo { get; set; } = null!;

    public int? Pda { get; set; }

    public double? Cantidad { get; set; }

    public double? CantPendiente { get; set; }

    public double? PrecioUnitario { get; set; }

    public double? Total { get; set; }

    public string? NoParte { get; set; }

    public string? UnidadM { get; set; }

    public string? DescRev { get; set; }

    public bool? Autorizacion { get; set; }

    public int? IdAutoriza { get; set; }

    public string? Nota { get; set; }

    public string? IdProyecto { get; set; }

    public string? IdOrdenCompra { get; set; }

    public string? TipoMaquinado { get; set; }

    public string? Estatus { get; set; }

    public string? Rmarca { get; set; }

    public string? Rprioridad { get; set; }

    public string? Rspare { get; set; }

    public string? Rmaterial { get; set; }

    public string? Racabado { get; set; }

    public string? Rmecanizado { get; set; }

    public double? Rpeso { get; set; }

    public string? SolOcSap { get; set; }

    public int? CantPendienteSap { get; set; }

    public virtual TbRequisicion IdReqNavigation { get; set; } = null!;
}
