using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProyAlmacen
{
    public string IdAlmacen { get; set; } = null!;

    public string? NomAlmacen { get; set; }

    public string? DescAlmacen { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public virtual ICollection<TbInvAlmacenRack> TbInvAlmacenRacks { get; set; } = new List<TbInvAlmacenRack>();
}
