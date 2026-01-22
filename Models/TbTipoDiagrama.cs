using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbTipoDiagrama
{
    public string IdTipoDiag { get; set; } = null!;

    public string? DescripDiag { get; set; }

    public virtual ICollection<TbIngenierium> TbIngenieria { get; set; } = new List<TbIngenierium>();
}
