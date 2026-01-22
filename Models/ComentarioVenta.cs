using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class ComentarioVenta
{
    public int ComentarioId { get; set; }

    public int? ParentComentarioId { get; set; }

    public string? Comment { get; set; }

    public string? CommentSenderName { get; set; }

    public string? IdCotizacion { get; set; }

    public DateTime? Date { get; set; }
}
