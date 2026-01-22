using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class Component
{
    public int Id { get; set; }

    public string Supplier { get; set; } = null!;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public decimal TotalPrice { get; set; }

    public string? ItemCode { get; set; }

    public string? SupplierCode { get; set; }

    public string Description { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal Utility { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? OriginalCurrency { get; set; }

    public virtual ICollection<BuildComponent> BuildComponents { get; set; } = new List<BuildComponent>();
}
