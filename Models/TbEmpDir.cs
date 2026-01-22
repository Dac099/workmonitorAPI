using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbEmpDir
{
    public string IdDir { get; set; } = null!;

    public string? DescDireccion { get; set; }

    public string? Nota { get; set; }

    public bool? EstatusDir { get; set; }
}
