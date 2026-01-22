using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbRfqLog
{
    public int IdRgLog { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? NumReq { get; set; }

    public string? Usuario { get; set; }

    public string? ForVentana { get; set; }

    public string? Movimiento { get; set; }

    public string? DescMovimiento { get; set; }
}
