using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class Item
{
    public Guid Id { get; set; }

    public Guid GroupId { get; set; }

    public string? ProjectId { get; set; }

    public string Name { get; set; } = null!;

    public int Position { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();

    public virtual Group Group { get; set; } = null!;

    public virtual TbProyect? Project { get; set; }

    public virtual ICollection<SubItem> SubItems { get; set; } = new List<SubItem>();

    public virtual ICollection<UserAsignedToItem> UserAsignedToItems { get; set; } = new List<UserAsignedToItem>();
}
