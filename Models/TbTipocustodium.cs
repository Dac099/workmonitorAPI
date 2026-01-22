using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbTipocustodium
{
    public int IdTipocustodia { get; set; }

    public string NomTipocustodia { get; set; } = null!;

    public virtual ICollection<TbInfoPc> TbInfoPcs { get; set; } = new List<TbInfoPc>();
}
