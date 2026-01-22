using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbCalidadLog
{
    public int IdLog { get; set; }

    public string? NumParte { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public int? IdUser { get; set; }

    public string? Descripcion { get; set; }
}
