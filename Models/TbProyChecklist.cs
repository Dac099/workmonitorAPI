using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProyChecklist
{
    public int IdProyectoChecklist { get; set; }

    public string? IdProyecto { get; set; }

    public string? EspecificacionCliente { get; set; }

    public string? NormasEstandares { get; set; }

    public string? Cotizacion { get; set; }

    public string? Archivo3d { get; set; }

    public string? Archivo2d { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
