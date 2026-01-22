using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class Access
{
    public int SrId { get; set; }

    public int? AccessId { get; set; }

    public int? MenuId { get; set; }

    public virtual Menumaster? Menu { get; set; }
}
