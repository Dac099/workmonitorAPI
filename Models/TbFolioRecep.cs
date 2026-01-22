using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbFolioRecep
{
    public int IdFolioRecep { get; set; }

    public string? FolioRecep { get; set; }

    public DateTime? FFolioRecep { get; set; }

    public string? OCompra { get; set; }

    public string? NParte { get; set; }

    public double? CantRecibida { get; set; }

    public int? IdUser { get; set; }

    public string? IdProyCt { get; set; }
}
