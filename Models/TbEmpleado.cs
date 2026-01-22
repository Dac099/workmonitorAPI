using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbEmpleado
{
    public int IdEmpleado { get; set; }

    public int? IdUser { get; set; }

    public bool? Activo { get; set; }

    public string? TokenEmpleado { get; set; }

    public int? IdIdentificadorEmpresa { get; set; }

    public string? Nombre { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? CorreoElectronico { get; set; }

    public int? IdDepartamento { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdCargo { get; set; }

    public int? IdNivel { get; set; }

    public int? IdReportaA { get; set; }

    public int? IdSupervisorAusencias { get; set; }

    public double? Sueldo { get; set; }

    public int? IdTipoPago { get; set; }

    public DateTime? FechaInicioContrato { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Genero { get; set; }

    public string? Nacionalidad { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion1 { get; set; }

    public string? Direccion2 { get; set; }

    public string? Ciudad { get; set; }

    public int? CodigoPostal { get; set; }

    public string? EstadoProvinciaRegion { get; set; }

    public string? Pais { get; set; }

    public string? NombreContactoEmergencia { get; set; }

    public string? TelefonoContactoEmergencia { get; set; }

    public string? CuentaBancaria { get; set; }

    public string? SwiftBic { get; set; }

    public string? Clabe { get; set; }

    public string? IdEntidadBancaria { get; set; }

    public string? NumeroCuenta { get; set; }

    public string? Rfc { get; set; }

    public string? NumeroImss { get; set; }

    public string? Curp { get; set; }

    public DateTime? FechaAltaImss { get; set; }

    public string? EsPeriodoPrueba { get; set; }
}
