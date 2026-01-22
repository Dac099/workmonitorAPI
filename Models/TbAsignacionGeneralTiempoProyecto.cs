using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbAsignacionGeneralTiempoProyecto
{
    public int IdAsignacionGeneralProyecto { get; set; }

    public string? AsignacionGeneral { get; set; }

    public double? CostoHora { get; set; }

    public bool? Activo { get; set; }
}
