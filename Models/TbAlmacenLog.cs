using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbAlmacenLog
{
    public int IdLog { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? DescLog { get; set; }

    public string? Tipo { get; set; }
}
