using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProPartList
{
    public int IdPartList { get; set; }

    public string? IdProyecto { get; set; }

    public string? IdNomPl { get; set; }

    public string? NomPartList { get; set; }

    public string? ObserPartList { get; set; }

    public string? NumRev { get; set; }

    public string? Usuario { get; set; }

    public bool? Estatus { get; set; }

    public string? NomMaquina { get; set; }

    public string? NumSerie { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public DateOnly? FechaRevision { get; set; }

    public string? Referencia { get; set; }

    public string? Proceso { get; set; }

    public string? Tipo { get; set; }
}
