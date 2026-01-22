using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbRegHorasJob
{
    public int IdReg { get; set; }

    public int? IdUser { get; set; }

    public string? Job { get; set; }

    public int? Horas { get; set; }

    public DateTime? FechaReg { get; set; }

    public bool? Estatus { get; set; }

    public int? IdArea { get; set; }

    public string? Asignacion { get; set; }

    public string? AsignacionGeneral { get; set; }

    public double? HorasCostos { get; set; }
}
