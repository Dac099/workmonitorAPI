using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class Chat
{
    public Guid Id { get; set; }

    public Guid? ItemId { get; set; }

    public string? Message { get; set; }

    public string? CreatedBy { get; set; }

    public string? Responses { get; set; }

    public string? Tasks { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Item? Item { get; set; }
}
