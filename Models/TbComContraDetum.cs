using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbComContraDetum
{
    public int IdDetaContra { get; set; }

    public int? IdContrarec { get; set; }

    public string? NumFactura { get; set; }

    public DateOnly? Fecha { get; set; }

    public double? Importe { get; set; }

    public string? IdMoneda { get; set; }

    public virtual TbComContrarec? IdContrarecNavigation { get; set; }
}
