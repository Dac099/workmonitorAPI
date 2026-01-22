using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class MaqEquipo
{
    public string IdEquipo { get; set; } = null!;

    public string? NomEquipo { get; set; }

    public string? Ubicacion { get; set; }

    public string? IdTipoEquipo { get; set; }
}
