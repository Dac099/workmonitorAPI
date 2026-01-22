using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbPeriodoAusencium
{
    public int IdPeriodoAusencia { get; set; }

    public string? Descripcion { get; set; }

    public int? NoAnosTrabajados { get; set; }

    public int? NoDiasVacaciones { get; set; }
}
