using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class Menumaster
{
    public int MenuId { get; set; }

    public int? PadreId { get; set; }

    public string? MenuText { get; set; }

    public int? MainMenuId { get; set; }

    public int? MenuOrder { get; set; }

    public string? IsActive { get; set; }

    public string? FormName { get; set; }

    public virtual ICollection<Access> Accesses { get; set; } = new List<Access>();
}
