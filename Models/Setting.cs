using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class Setting
{
    public string IdSett { get; set; } = null!;

    public string? DescSett { get; set; }

    public string? ValueSett { get; set; }

    public DateTime? DateReg { get; set; }

    public string? TipoDato { get; set; }

    public bool? Estado { get; set; }
}
