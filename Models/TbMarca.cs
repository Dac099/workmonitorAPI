using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbMarca
{
    public int IdMarca { get; set; }

    public string NomMarca { get; set; } = null!;

    public string? ObserMarca { get; set; }

    public string? DivTipo { get; set; }
}
