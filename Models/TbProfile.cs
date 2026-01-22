using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProfile
{
    public int IdPerfil { get; set; }

    public string? NomPerfil { get; set; }

    public DateTime? Fecha { get; set; }

    public string? DescPerfil { get; set; }

    public string? Nota { get; set; }

    public string? Observacion { get; set; }

    public bool? EstatusProfile { get; set; }

    public virtual ICollection<TbUser> TbUsers { get; set; } = new List<TbUser>();
}
