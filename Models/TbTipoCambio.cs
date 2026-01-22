using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbTipoCambio
{
    public int IdTc { get; set; }

    public double? ValTc { get; set; }

    public string? IdMoneda { get; set; }

    public int? IdUser { get; set; }

    public DateTime? FechaTc { get; set; }

    public virtual TbOcMonedum? IdMonedaNavigation { get; set; }

    public virtual TbUser? IdUserNavigation { get; set; }
}
