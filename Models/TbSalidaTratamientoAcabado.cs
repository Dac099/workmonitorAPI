using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbSalidaTratamientoAcabado
{
    public int IdSalidaTratAca { get; set; }

    public string? Folio { get; set; }

    public string? IdProveedor { get; set; }

    public double? Peso { get; set; }

    public string? Estatus { get; set; }

    public DateTime? FechaSalida { get; set; }

    public DateTime? FechaRetornoProv { get; set; }

    public int? TipoFolio { get; set; }

    public string? UsuarioCrea { get; set; }
}
