using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class BuildComponent
{
    public int Id { get; set; }

    public int BuildId { get; set; }

    public int ComponentId { get; set; }

    public virtual Build Build { get; set; } = null!;

    public virtual Component Component { get; set; } = null!;
}
