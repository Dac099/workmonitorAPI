using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class MaqTipoEquipo
{
    public string IdTipoEquipo { get; set; } = null!;

    public string? NomTipo { get; set; }

    public string? DescTipo { get; set; }

    public decimal? CostoHora { get; set; }

    public string? IdMoneda { get; set; }

    public DateOnly? FIngreso { get; set; }

    public DateOnly? FActualizacion { get; set; }

    public decimal? CostoHoraPro { get; set; }
}
