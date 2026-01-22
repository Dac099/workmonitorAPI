using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class MaqMetale
{
    public string IdMetal { get; set; } = null!;

    public string? NomMetal { get; set; }

    public string? DescMetal { get; set; }

    public DateTime? FIngreso { get; set; }

    public string? Um { get; set; }

    public virtual ICollection<MaqTipoMetale> MaqTipoMetales { get; set; } = new List<MaqTipoMetale>();
}
