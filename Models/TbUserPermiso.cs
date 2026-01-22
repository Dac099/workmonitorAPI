using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbUserPermiso
{
    public int IdUserPermiso { get; set; }

    public int? IdUser { get; set; }

    public int? IdPermiso { get; set; }

    public bool? PerCreate { get; set; }

    public bool? PerRead { get; set; }

    public bool? PerUpdate { get; set; }

    public bool? PerDelete { get; set; }
}
