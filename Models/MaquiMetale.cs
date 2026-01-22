using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class MaquiMetale
{
    public int IdMetal { get; set; }

    public string NumMetal { get; set; } = null!;

    public string? Descripcion { get; set; }

    public double? Stock { get; set; }

    public string? GrupoArt { get; set; }

    public string? Um { get; set; }

    public double? Precio { get; set; }

    public string? Moneda { get; set; }

    public DateTime? FRegistro { get; set; }

    public DateTime? FActualiza { get; set; }
}
