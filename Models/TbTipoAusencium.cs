using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbTipoAusencium
{
    public int IdTipoAusencia { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Color { get; set; }
}
