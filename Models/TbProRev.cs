using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProRev
{
    public int IdRev { get; set; }

    public string IdProyecto { get; set; } = null!;

    public DateTime? FechaIngreso { get; set; }

    public int? IdUser { get; set; }

    public string? Desc { get; set; }

    public virtual TbProyect IdProyectoNavigation { get; set; } = null!;
}
