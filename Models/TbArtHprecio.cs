using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbArtHprecio
{
    public string Np { get; set; } = null!;

    public int IdArt { get; set; }

    public decimal? Precio { get; set; }

    public string? IdMoneda { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string? IdUm { get; set; }

    public int? IdUsuario { get; set; }

    public virtual TbArticulo IdArtNavigation { get; set; } = null!;
}
