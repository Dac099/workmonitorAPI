using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class EntryLog
{
    public Guid Id { get; set; }

    public string? Msg { get; set; }

    public Guid? ResourceId { get; set; }

    public string? ValueLog { get; set; }

    public string? Resource { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string Type { get; set; } = null!;
}
