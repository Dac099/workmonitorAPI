using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbClientContact
{
    public int IdContacto { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public bool IsActive { get; set; }

    public string Position { get; set; } = null!;

    public int IdCliente { get; set; }

    public virtual TbCliente IdClienteNavigation { get; set; } = null!;
}
