using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbHorasExtra
{
    public int IdHorasExtras { get; set; }

    public int? IdUsuario { get; set; }

    public DateOnly? FechaHorasExtras { get; set; }

    public TimeOnly? CantidadHoras { get; set; }

    public string? Descripcion { get; set; }

    public bool? Autorizacion { get; set; }
}
