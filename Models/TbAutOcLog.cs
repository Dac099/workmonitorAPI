using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbAutOcLog
{
    public int IdLog { get; set; }

    public int? IdOrdenCompra { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public int? IdUser { get; set; }

    public string? Descrip { get; set; }

    public virtual TbOrdenCompra? IdOrdenCompraNavigation { get; set; }
}
