using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class MaqTipoMetale
{
    public string IdTipoMetal { get; set; } = null!;

    public string? IdMetal { get; set; }

    public string? NomTipo { get; set; }

    public string? DescTipo { get; set; }

    public decimal PrecioKg { get; set; }

    public decimal? Densidad { get; set; }

    public string? IdMoneda { get; set; }

    public DateOnly? FIngreso { get; set; }

    public DateOnly? FActualizacion { get; set; }

    public string? NPartMetal { get; set; }

    public virtual MaqMetale? IdMetalNavigation { get; set; }
}
