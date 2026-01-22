using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbSgcFor
{
    public string IdFormato { get; set; } = null!;

    public string? CodFormato { get; set; }

    public string? NomFormato { get; set; }

    public string? NoRevision { get; set; }

    public DateTime? FechaRev { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaMod { get; set; }

    public int? IdUser { get; set; }

    public int? IdArea { get; set; }

    public int? TimeVig { get; set; }

    public DateTime? ProxRenovacion { get; set; }

    public string? Observaciones { get; set; }

    public string? MotivoCambio { get; set; }

    public string? Nota { get; set; }

    public string? LinkFormato { get; set; }

    public double? Orden { get; set; }

    public bool? Estatus { get; set; }

    public string? User01 { get; set; }

    public string? User02 { get; set; }

    public string? User03 { get; set; }

    public string? User04 { get; set; }

    public virtual TbArea? IdAreaNavigation { get; set; }

    public virtual ICollection<TbOrdenCompra> TbOrdenCompras { get; set; } = new List<TbOrdenCompra>();
}
