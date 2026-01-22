using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbOrdenCompra
{
    public int IdOrdenCompra { get; set; }

    public string? IdProyecto { get; set; }

    public int IdEmpresa { get; set; }

    public int IdProveedor { get; set; }

    public int IdUsuario { get; set; }

    public string? IdFormato { get; set; }

    public string? IdEnvio { get; set; }

    public string? IdProCosto { get; set; }

    public string? IdCfdiUso { get; set; }

    public string? Estatus { get; set; }

    public string? PomNumner { get; set; }

    public DateTime? FechaCompra { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string? NumFacProvedor { get; set; }

    public double? Importe { get; set; }

    public double? Iva { get; set; }

    public double? Total { get; set; }

    public string? ImporteLeta { get; set; }

    public string? Descuento { get; set; }

    public string? Observaciones { get; set; }

    public string? DiasCredito { get; set; }

    public string? Moneda { get; set; }

    public string? DescRecibo { get; set; }

    public bool? EstatusEntrega { get; set; }

    public int? IdArea { get; set; }

    public int? IdCenCost { get; set; }

    public bool? AutMeca { get; set; }

    public bool? AutElec { get; set; }

    public bool? AutCompras { get; set; }

    public bool? AutGerencia { get; set; }

    public bool? AutAplica { get; set; }

    public bool? AutMaquinado { get; set; }

    public bool? AutEnsambles { get; set; }

    public bool? AutRefDim { get; set; }

    public double? VaTiCambio { get; set; }

    public string? SerieOc { get; set; }

    public int? RefContacto { get; set; }

    public int? IdSolicita { get; set; }

    public decimal? IdConcentrado { get; set; }

    public bool? AutSisIt { get; set; }

    public bool? AutProyects { get; set; }

    public string? TipoOc { get; set; }

    public string? IdAlmacen { get; set; }

    public string? VaIva { get; set; }

    public string? EstatusLey { get; set; }

    public string? Rev { get; set; }

    public string? RevRfq { get; set; }

    public string? Referencia { get; set; }

    public double? MontoDescuento { get; set; }

    public int? IdPrioridad { get; set; }

    public virtual MaquinadosEstatus? EstatusNavigation { get; set; }

    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    public virtual TbSgcFor? IdFormatoNavigation { get; set; }

    public virtual TbProveedor IdProveedorNavigation { get; set; } = null!;

    public virtual TbUser IdUsuarioNavigation { get; set; } = null!;

    public virtual TbOcMonedum? MonedaNavigation { get; set; }

    public virtual ICollection<TbAutOcLog> TbAutOcLogs { get; set; } = new List<TbAutOcLog>();

    public virtual ICollection<TbCompra> TbCompras { get; set; } = new List<TbCompra>();
}
