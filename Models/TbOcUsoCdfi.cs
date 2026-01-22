using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbOcUsoCdfi
{
    public string CUsoCfdi { get; set; } = null!;

    public string? DescCdfi { get; set; }

    public bool? Fisica { get; set; }

    public bool? Moral { get; set; }
}
