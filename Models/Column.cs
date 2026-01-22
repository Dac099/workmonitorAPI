using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class Column
{
    public Guid Id { get; set; }

    public Guid BoardId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Settings { get; set; }

    public int Position { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public int? ColumnWidth { get; set; }

    public virtual Board Board { get; set; } = null!;

    public virtual ICollection<TableValue> TableValues { get; set; } = new List<TableValue>();
}
