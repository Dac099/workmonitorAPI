using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class Comentario
{
    public int ComentarioId { get; set; }

    public int? ParentComentarioId { get; set; }

    public string? Comment { get; set; }

    public string? CommentSenderName { get; set; }

    public int? IdReg { get; set; }

    public DateTime? Date { get; set; }
}
