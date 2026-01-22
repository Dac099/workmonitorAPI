using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProyLider
{
    public int IdLid { get; set; }

    public string? NomCompleto { get; set; }

    public bool? Estatus { get; set; }

    public string? Tel { get; set; }

    public string? Cel { get; set; }

    public string? Email { get; set; }

    public string? Nombre { get; set; }

    public string? Aparteno { get; set; }

    public string? Amaterno { get; set; }

    public int? IdArea { get; set; }

    public virtual ICollection<TbProyect> TbProyects { get; set; } = new List<TbProyect>();
}
