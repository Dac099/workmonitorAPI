using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbDetaDevolucion
{
    public int IdDetaDevolucion { get; set; }

    public string? FolioDetaDev { get; set; }

    public DateTime? FFolioDev { get; set; }

    public string? OCompra { get; set; }

    public string? NParte { get; set; }

    public double? CantDevuelta { get; set; }

    public double? PrecioU { get; set; }

    public string? Moneda { get; set; }

    public bool? CambioPrecio { get; set; }
}
