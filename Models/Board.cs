using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class Board
{
    public Guid Id { get; set; }

    public Guid WorkspaceId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<Column> Columns { get; set; } = new List<Column>();

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual ICollection<View> Views { get; set; } = new List<View>();

    public virtual Workspace Workspace { get; set; } = null!;
}
