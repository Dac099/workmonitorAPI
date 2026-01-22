using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class SubItem
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid ItemParent { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Item ItemParentNavigation { get; set; } = null!;
}
