using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbUbiEquipo
{
    public int IdUbicacion { get; set; }

    public string? NomUbicacion { get; set; }

    public virtual ICollection<TbInfoPc> TbInfoPcs { get; set; } = new List<TbInfoPc>();
}
