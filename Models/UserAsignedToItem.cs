using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class UserAsignedToItem
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid ItemId { get; set; }

    public int AsignedBy { get; set; }

    public DateTime? AsignedDate { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TbUser AsignedByNavigation { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;

    public virtual Employee User { get; set; } = null!;
}
