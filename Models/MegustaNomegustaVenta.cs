using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class MegustaNomegustaVenta
{
    public int Id { get; set; }

    public int? MemberId { get; set; }

    public int? ComentarioId { get; set; }

    public int? LikeUnlike { get; set; }

    public DateTime? Date { get; set; }
}
