using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbMachinesProject
{
    public int IdMachine { get; set; }

    public string? IdProject { get; set; }

    public double? InitialBudget { get; set; }

    public string? NumSerie { get; set; }

    public double? MechanicalBudget { get; set; }

    public double? MachiningBudget { get; set; }

    public double? ElectricalBudget { get; set; }

    public double? OtherBudget { get; set; }

    public int? HoursMechanicalDesign { get; set; }

    public int? HoursElectricalDesign { get; set; }

    public int? HoursAsemblyDevelopment { get; set; }

    public int? HoursDevelopment { get; set; }

    public int? HoursOther { get; set; }

    public int? ProjectManager { get; set; }

    public int? MechanicalDesigner { get; set; }

    public int? ElectricalDesigner { get; set; }

    public int? Developer { get; set; }

    public int? Assembler { get; set; }

    public virtual TbProyect? IdProjectNavigation { get; set; }
}
