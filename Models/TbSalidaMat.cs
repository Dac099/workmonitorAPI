using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbSalidaMat
{
    public int IdSalida { get; set; }

    public int? IdDetaReq { get; set; }

    public string? IdUbicacion { get; set; }

    public double? Cantidad { get; set; }

    public int? TipoUbicacion { get; set; }

    public DateTime? FechaSalida { get; set; }
}
