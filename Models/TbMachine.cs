using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbMachine
{
    public string? NumSerie { get; set; }

    public string? Detail { get; set; }

    public string? Title { get; set; }

    public string? Usuario { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string? IdSector { get; set; }

    public int? IdCliente { get; set; }

    public string? IdProyect { get; set; }
}
