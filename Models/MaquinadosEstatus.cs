using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class MaquinadosEstatus
{
    public string IdEstatus { get; set; } = null!;

    public string? DescEstatus { get; set; }

    public double? Orden { get; set; }

    public string? Nota { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<TbOrdenCompra> TbOrdenCompras { get; set; } = new List<TbOrdenCompra>();
}
