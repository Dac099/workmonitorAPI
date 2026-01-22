using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbEmpresa
{
    public int IdEmpresa { get; set; }

    public string? NomEmpresa { get; set; }

    public string? Rfc { get; set; }

    public string? Direccion { get; set; }

    public string? DescEmpresa { get; set; }

    public string? PagWeb { get; set; }

    public string? TelEmp { get; set; }

    public string? MailComtacto { get; set; }

    public string? MailVentas { get; set; }

    public string? MailCxp { get; set; }

    public string? MailCompras { get; set; }

    public string? MailSistema { get; set; }

    public string? Estatus { get; set; }

    public string? Tipo { get; set; }

    public string? User01 { get; set; }

    public string? User02 { get; set; }

    public string? Nota { get; set; }

    public string? Tarjeta { get; set; }

    public byte[]? Imagen { get; set; }

    public string? Comfis { get; set; }

    public string? Acma { get; set; }

    public virtual ICollection<TbComContrarec> TbComContrarecs { get; set; } = new List<TbComContrarec>();

    public virtual ICollection<TbOrdenCompra> TbOrdenCompras { get; set; } = new List<TbOrdenCompra>();
}
