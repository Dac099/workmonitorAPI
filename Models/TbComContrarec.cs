using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbComContrarec
{
    public int IdContrarec { get; set; }

    public DateTime? FechaRcontra { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int IdEmpresa { get; set; }

    public int IdProveedor { get; set; }

    public string? Observaciones { get; set; }

    public int IdUsuario { get; set; }

    public string? Estatus { get; set; }

    public int? UserMod { get; set; }

    public string? NotaMod { get; set; }

    public DateTime? FechaMod { get; set; }

    public bool? Pproceso { get; set; }

    public bool? Pfacturada { get; set; }

    public bool? Pbatch { get; set; }

    public bool? Pago { get; set; }

    public double? CantPagada { get; set; }

    public string? Batch { get; set; }

    public string? CodCancelacion { get; set; }

    public DateTime? FechaPago { get; set; }

    public string? DiasCredito { get; set; }

    public double? TotalFacturas { get; set; }

    public string? Moneda { get; set; }

    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbProveedor IdProveedorNavigation { get; set; } = null!;

    public virtual TbUser IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<TbComContraDetum> TbComContraDeta { get; set; } = new List<TbComContraDetum>();
}
