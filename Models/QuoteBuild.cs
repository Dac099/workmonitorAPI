using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class QuoteBuild
{
    public int Id { get; set; }

    public int QuoteId { get; set; }

    public int BuildId { get; set; }

    public virtual Build Build { get; set; } = null!;

    public virtual TbCotizacion Quote { get; set; } = null!;
}
