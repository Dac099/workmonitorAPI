using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class MaqComentario
{
    public int IdComent { get; set; }

    public string Comentario { get; set; } = null!;

    public int IdUsuario { get; set; }

    public string PartNumber { get; set; } = null!;

    public DateOnly FCreacion { get; set; }

    public string? Archivo { get; set; }

    public int? Respuesta { get; set; }

    public string? NomFile { get; set; }
}
