using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class MaqTipoMaquinado
{
    public string IdTipoMaquinado { get; set; } = null!;

    public string? NomTipoMaquinado { get; set; }

    public int? Orden { get; set; }

    public bool? Activo { get; set; }
}
