using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbCargo
{
    public int IdCargo { get; set; }

    public string? Nombre { get; set; }

    public bool? Estatus { get; set; }
}
