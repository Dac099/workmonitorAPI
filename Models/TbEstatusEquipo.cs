using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbEstatusEquipo
{
    public int IdEstatus { get; set; }

    public string? NombreEstatus { get; set; }

    public virtual ICollection<TbInfoPc> TbInfoPcs { get; set; } = new List<TbInfoPc>();
}
