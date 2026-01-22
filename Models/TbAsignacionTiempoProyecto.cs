using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbAsignacionTiempoProyecto
{
    public int IdAsignacionProyecto { get; set; }

    public int? IdAsignacionGeneral { get; set; }

    public string? AsignacionEspecifica { get; set; }

    public double? CostoHora { get; set; }

    public bool? Activo { get; set; }
}
