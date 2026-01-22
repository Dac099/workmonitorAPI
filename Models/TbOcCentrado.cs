using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbOcCentrado
{
    public decimal IdConcentrado { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdUser { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? TotFact { get; set; }

    public int? IdProveedor { get; set; }

    public string? Observaciones { get; set; }
}
