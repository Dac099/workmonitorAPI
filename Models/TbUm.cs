using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbUm
{
    public string IdMedida { get; set; } = null!;

    public string? DescMedida { get; set; }

    public bool? DivEtq { get; set; }

    public string? Abrev { get; set; }

    public string? Maq { get; set; }

    public virtual ICollection<TbArticulo> TbArticulos { get; set; } = new List<TbArticulo>();

    public virtual ICollection<TbCompra> TbCompras { get; set; } = new List<TbCompra>();

    public virtual ICollection<TbProyArtAlmacen> TbProyArtAlmacens { get; set; } = new List<TbProyArtAlmacen>();
}
