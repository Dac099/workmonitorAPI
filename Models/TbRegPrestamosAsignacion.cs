using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbRegPrestamosAsignacion
{
    public int IdReg { get; set; }

    public string? Descripcion { get; set; }

    public int? Cantidad { get; set; }

    public int? IdUserEncargado { get; set; }

    public int? IdUserAsignado { get; set; }

    public string? Tipo { get; set; }

    public DateTime? FechaPrestamo { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public string? Estatus { get; set; }
}
