using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProyTransArtAlm
{
    public int? IdDetaAlmArt { get; set; }

    public string? NumParte { get; set; }

    public string? DescArticulo { get; set; }

    public double? NumPzaTransfer { get; set; }

    public string? UnidadMedida { get; set; }

    public string? NumRev { get; set; }

    public DateTime? Fingreso { get; set; }

    public string? Usuario { get; set; }

    public string? NumProyecto { get; set; }

    public string? IdAlmacen { get; set; }

    public int? IdSolicita { get; set; }
}
