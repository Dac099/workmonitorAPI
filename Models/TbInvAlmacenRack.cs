using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbInvAlmacenRack
{
    public string IdRack { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public int? Nivel { get; set; }

    public int? Columna { get; set; }

    public string? IdAlmacen { get; set; }

    public bool? Estatus { get; set; }

    public virtual TbProyAlmacen? IdAlmacenNavigation { get; set; }
}
