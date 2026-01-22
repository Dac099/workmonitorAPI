using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class ExchangeRate
{
    public int Id { get; set; }

    public string Currency { get; set; } = null!;

    public decimal CurrencyInDollar { get; set; }

    public DateTime UpdatedAt { get; set; }
}
