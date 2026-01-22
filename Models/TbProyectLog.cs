using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProyectLog
{
    public int IdProyectLog { get; set; }

    public string? IdProyecto { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdUser { get; set; }

    public string? Descrip { get; set; }
}
