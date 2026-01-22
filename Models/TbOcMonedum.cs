using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbOcMonedum
{
    public string IdMoneda { get; set; } = null!;

    public string? DescMoneda { get; set; }

    public int? Orden { get; set; }

    public virtual ICollection<TbOrdenCompra> TbOrdenCompras { get; set; } = new List<TbOrdenCompra>();

    public virtual ICollection<TbProveedor> TbProveedors { get; set; } = new List<TbProveedor>();

    public virtual ICollection<TbProyect> TbProyects { get; set; } = new List<TbProyect>();

    public virtual ICollection<TbTipoCambio> TbTipoCambios { get; set; } = new List<TbTipoCambio>();
}
