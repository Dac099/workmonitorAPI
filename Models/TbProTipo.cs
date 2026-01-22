using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProTipo
{
    public string IdTipoPro { get; set; } = null!;

    public string? Identificador { get; set; }

    public string? NomTipo { get; set; }

    public string? DescTipo { get; set; }

    public int? IdUsuario { get; set; }

    public bool? Estatus { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public int? Orden { get; set; }

    public int? ContadorInicial { get; set; }

    public int? ContadorActual { get; set; }

    public string? TipoSel { get; set; }

    public bool? Suggest { get; set; }

    public virtual ICollection<TbProyect> TbProyects { get; set; } = new List<TbProyect>();
}
