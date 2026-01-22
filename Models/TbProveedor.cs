using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProveedor
{
    public int IdProveedor { get; set; }

    public string? NomProveedor { get; set; }

    public string? RfcProv { get; set; }

    public string? CorreoProv { get; set; }

    public string? TelefonoProv { get; set; }

    public string? DiasCredito { get; set; }

    public string? Phone1 { get; set; }

    public string? Adress { get; set; }

    public string? Phone2 { get; set; }

    public string? Fax { get; set; }

    public string? Web { get; set; }

    public string? Contact1 { get; set; }

    public string? Contact2 { get; set; }

    public string? Notes { get; set; }

    public string? Code { get; set; }

    public string? Mail1 { get; set; }

    public string? Mail2 { get; set; }

    public string? IdMoneda { get; set; }

    public string? CondPago { get; set; }

    public string? Marca { get; set; }

    public string? IdTipoP { get; set; }

    public string? Usuario { get; set; }

    public bool? Estado { get; set; }

    public virtual TbOcMonedum? IdMonedaNavigation { get; set; }

    public virtual ICollection<TbComContrarec> TbComContrarecs { get; set; } = new List<TbComContrarec>();

    public virtual ICollection<TbOrdenCompra> TbOrdenCompras { get; set; } = new List<TbOrdenCompra>();
}
