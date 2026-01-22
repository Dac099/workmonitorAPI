using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class MaquinadosDetalle
{
    public int IdMaquinadoDetalles { get; set; }

    public int? IdMaquinado { get; set; }

    public string? NParte { get; set; }

    public string? MedidasDeta { get; set; }

    public string? MaqDetaEstatus { get; set; }

    public decimal? KgPiezaIndiv { get; set; }

    public bool? SolMat { get; set; }
}
