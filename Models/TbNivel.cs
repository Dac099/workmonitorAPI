using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbNivel
{
    public int IdNivel { get; set; }

    public string? Nombre { get; set; }

    public int? IdCargo { get; set; }
}
