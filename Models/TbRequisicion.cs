using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbRequisicion
{
    public int IdReq { get; set; }

    public string? NumReq { get; set; }

    public string? IdProyecto { get; set; }

    public string? NumEnsamble { get; set; }

    public string? IdOcompra { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdDepto { get; set; }

    public string? IdTiporeq { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdUsuario { get; set; }

    public string? Observaciones { get; set; }

    public string? Estatus { get; set; }

    public DateOnly? FechaSolicitud { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public string? IdFormato { get; set; }

    public string? DescRev { get; set; }

    public DateTime? FechaCierre { get; set; }

    public bool? SendMail { get; set; }

    public string? IdEstatus { get; set; }

    public int? IdRev { get; set; }

    public string? LetRev { get; set; }

    public bool? ModPda { get; set; }

    public bool? RevCom { get; set; }

    public virtual TbUser? IdUsuarioNavigation { get; set; }

    public virtual ICollection<TbReqDetum> TbReqDeta { get; set; } = new List<TbReqDetum>();
}
