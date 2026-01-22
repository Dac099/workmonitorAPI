using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProComp
{
    public int? IdCon { get; set; }

    public string IdProyect { get; set; } = null!;

    public int? IdCliente { get; set; }

    public string? IdComplemento { get; set; }

    public int? IdUser { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public virtual TbProyect IdProyectNavigation { get; set; } = null!;

    public virtual TbUser? IdUserNavigation { get; set; }
}
