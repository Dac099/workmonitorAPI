using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbOcCotizacion
{
    public int IdOcCotizacion { get; set; }

    public int? NumOc { get; set; }

    public string? IdCotizacion { get; set; }

    public string? PoCliente { get; set; }

    public DateOnly? FechaPo { get; set; }

    public string? NombreArchivoPo { get; set; }
}
