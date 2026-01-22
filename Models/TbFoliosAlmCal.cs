using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbFoliosAlmCal
{
    public int IdFolioAlmCal { get; set; }

    public string? FolioAlmCal { get; set; }

    public DateTime? FCreacion { get; set; }

    public string? Depa { get; set; }

    public int? IdUser { get; set; }

    public string? OrdenCom { get; set; }

    public bool? Estatus { get; set; }
}
