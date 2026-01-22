using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbArea
{
    public int IdArea { get; set; }

    public string? NomArea { get; set; }

    public string? NomGere { get; set; }

    public string? DescAre { get; set; }

    public string? Not01 { get; set; }

    public string? Adic01 { get; set; }

    public string? User01 { get; set; }

    public int? Tipo { get; set; }

    public string? PathFile { get; set; }

    public int? Orden { get; set; }

    /// <summary>
    /// Tiepo de modificación registros
    /// </summary>
    public int? TiempoMod { get; set; }

    public string? MailGrupo { get; set; }

    public virtual ICollection<TbInfoPc> TbInfoPcs { get; set; } = new List<TbInfoPc>();

    public virtual ICollection<TbSgcFor> TbSgcFors { get; set; } = new List<TbSgcFor>();

    public virtual ICollection<TbUser> TbUsers { get; set; } = new List<TbUser>();
}
