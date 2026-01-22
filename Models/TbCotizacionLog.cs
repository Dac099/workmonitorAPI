using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbCotizacionLog
{
    public int IdCotizacionLog { get; set; }

    public string? IdCotizacion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUser { get; set; }

    public string? Descrip { get; set; }
}
