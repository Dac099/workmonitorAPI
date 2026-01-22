using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbWebPermiso
{
    public int IdPermisos { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? IdMenuPadre { get; set; }

    public string? PathUrl { get; set; }

    public string? Icono { get; set; }

    public int? Orden { get; set; }

    public bool? Estatus { get; set; }

    public bool? EsInicial { get; set; }

    public bool? EsMantenimiento { get; set; }
}
