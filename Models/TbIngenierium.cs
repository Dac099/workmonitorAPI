using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbIngenierium
{
    public int IdInge { get; set; }

    public string? NParte { get; set; }

    public int? DiagGerarquia { get; set; }

    public string? TipoDiag { get; set; }

    public string? Job { get; set; }

    public int? IdUser { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public virtual TbTipoDiagrama? TipoDiagNavigation { get; set; }
}
