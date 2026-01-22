using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbEqEstatus
{
    public string IdEstado { get; set; } = null!;

    public string? NomEstado { get; set; }

    public string? NotaEstado0 { get; set; }

    public string? Descripcion { get; set; }

    public int? Orden { get; set; }

    public virtual ICollection<TbProyect> TbProyects { get; set; } = new List<TbProyect>();
}
