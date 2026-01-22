using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class Build
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public string CreatedBy { get; set; } = null!;

    public decimal ExchangeRate { get; set; }

    public decimal? Utility { get; set; }

    public int? EnginneringHoursId { get; set; }

    public virtual ICollection<BuildComponent> BuildComponents { get; set; } = new List<BuildComponent>();

    public virtual EnginneringHour? EnginneringHours { get; set; }

    public virtual ICollection<QuoteBuild> QuoteBuilds { get; set; } = new List<QuoteBuild>();
}
