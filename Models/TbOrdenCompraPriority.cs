using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbOrdenCompraPriority
{
    public int IdPrioridad { get; set; }

    public string Descripcion { get; set; } = null!;
}
