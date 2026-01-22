using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbRegistroAusencia
{
    public int IdAusencias { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdTipoAusencia { get; set; }

    public string? Descripcion { get; set; }

    public string? TipoJornada { get; set; }

    public DateOnly? FechaInicioAusencia { get; set; }

    public DateOnly? FechaFinAusencia { get; set; }

    public string? EstatusJornada { get; set; }

    public bool? Autorizacion { get; set; }
}
