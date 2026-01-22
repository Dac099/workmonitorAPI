using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbMachDiv
{
    public string IdDiv { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? DescDiv { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string? Usuario { get; set; }
}
