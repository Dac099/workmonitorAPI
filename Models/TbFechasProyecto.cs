using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbFechasProyecto
{
    public int IdFechaProyecto { get; set; }

    public string? IdProyecto { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public string? Color { get; set; }

    public int? Porcentaje { get; set; }
}
