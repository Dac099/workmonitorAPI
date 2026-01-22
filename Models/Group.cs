using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class Group
{
    public Guid Id { get; set; }

    public Guid BoardId { get; set; }

    public string Name { get; set; } = null!;

    public int Position { get; set; }

    public string? Color { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Board Board { get; set; } = null!;

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
