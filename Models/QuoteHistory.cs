using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class QuoteHistory
{
    public int Id { get; set; }

    public string Target { get; set; } = null!;

    public int TargetId { get; set; }

    public DateTime RecordDate { get; set; }

    public string Field { get; set; } = null!;

    public string? PrevValue { get; set; }

    public string? NewValue { get; set; }

    public string? UpdateReason { get; set; }

    public string UpdatedBy { get; set; } = null!;
}
