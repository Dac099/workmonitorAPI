using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProyectCosto
{
    public string IdProCosto { get; set; } = null!;

    public string? Title { get; set; }

    public string? Detail { get; set; }
}
