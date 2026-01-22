using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class MaqLogTipoMetale
{
    public int IdRegLog { get; set; }

    public string? VentanaTipo { get; set; }

    public string? IdProyecto { get; set; }

    public string? NPartMetal { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string? DescLog { get; set; }
}
