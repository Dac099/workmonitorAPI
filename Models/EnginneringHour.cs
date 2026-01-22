using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class EnginneringHour
{
    public int Id { get; set; }

    public int MechanicalDesign { get; set; }

    public int ElectricalDesign { get; set; }

    public int Assembly { get; set; }

    public int Other { get; set; }

    public int Programming { get; set; }

    public virtual Build? Build { get; set; }
}
