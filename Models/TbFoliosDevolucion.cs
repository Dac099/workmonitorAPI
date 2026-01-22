using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbFoliosDevolucion
{
    public int IdFolioDevolucion { get; set; }

    public string? FolioDevolucion { get; set; }

    public DateTime? FCreacion { get; set; }

    public string? Proyecto { get; set; }

    public string? Depa { get; set; }

    public int? UserRecibe { get; set; }

    public int? UserEntrega { get; set; }
}
