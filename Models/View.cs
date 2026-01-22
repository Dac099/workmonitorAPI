using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class View
{
    public Guid Id { get; set; }

    public Guid BoardId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool IsDefault { get; set; }

    public int Position { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Board Board { get; set; } = null!;

    public virtual ICollection<ViewSetting> ViewSettings { get; set; } = new List<ViewSetting>();
}
