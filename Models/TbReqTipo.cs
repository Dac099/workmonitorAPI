using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbReqTipo
{
    public string IdTipoReq { get; set; } = null!;

    public string? NomTipoReq { get; set; }

    public string? DescTipoReq { get; set; }

    public short? Orden { get; set; }

    public virtual ICollection<TbArtCCosto> TbArtCCostos { get; set; } = new List<TbArtCCosto>();

    public virtual ICollection<TbArticulo> TbArticulos { get; set; } = new List<TbArticulo>();
}
