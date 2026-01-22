using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbEstEmail
{
    public int? IdOrdenCompra { get; set; }

    public int? IdRealizo { get; set; }

    public int? IdSolicito { get; set; }

    public DateTime? FechaRealizo { get; set; }

    public int? IdDepto { get; set; }
}
