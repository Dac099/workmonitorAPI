using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class ArticleGroup
{
    public int Codigo { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<TbArticulo> TbArticulos { get; set; } = new List<TbArticulo>();
}
