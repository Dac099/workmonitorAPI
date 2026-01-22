using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbEmpresaCliente
{
    public int Id { get; set; }

    public string? Empresa { get; set; }

    public bool? Activo { get; set; }
}
