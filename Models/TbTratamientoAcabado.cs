using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbTratamientoAcabado
{
    public int IdTratAca { get; set; }

    public string? Tipo { get; set; }

    public string DescTratAca { get; set; } = null!;

    public int? OrdenT { get; set; }

    public bool? Aplica { get; set; }
}
