using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TableValue
{
    public Guid Id { get; set; }

    public Guid? ItemId { get; set; }

    public Guid ColumnId { get; set; }

    public string? Value { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Column Column { get; set; } = null!;
}
