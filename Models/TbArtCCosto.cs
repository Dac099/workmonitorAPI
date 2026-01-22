using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbArtCCosto
{
    public int IdCCosto { get; set; }

    public string? IdPn { get; set; }

    public string? IdType { get; set; }

    public string? Title { get; set; }

    public string? Detail { get; set; }

    public virtual TbReqTipo? IdTypeNavigation { get; set; }
}
