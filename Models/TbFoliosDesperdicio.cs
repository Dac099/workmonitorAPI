using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbFoliosDesperdicio
{
    public int IdDesperdicioMaq { get; set; }

    public string? FolioDesperdicio { get; set; }

    public int? IdMaquinado { get; set; }

    public string? NParte { get; set; }

    public string? Proyecto { get; set; }

    public DateTime? FDesperdicio { get; set; }

    public int? Usuario { get; set; }

    public string? Motivo { get; set; }

    public string? IdMaterial { get; set; }

    public string? Medidas { get; set; }

    public decimal? KgDesperdicio { get; set; }

    public int? NOperaciones { get; set; }

    public decimal? PrecioDesp { get; set; }

    public bool? Disponibilidad { get; set; }

    public bool? Reutilizable { get; set; }

    public bool? TipoDes { get; set; }

    public bool? CostoInicial { get; set; }
}
