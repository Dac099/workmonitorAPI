using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbDepartamento
{
    public int IdDepartamento { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? IdLiderDepartamento { get; set; }

    public bool? Estatus { get; set; }
}
