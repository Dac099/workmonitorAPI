using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbUser
{
    public int IdUser { get; set; }

    public string? NomUser { get; set; }

    public bool? EdoUser { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? Usuario { get; set; }

    public int? IdProfile { get; set; }

    public byte[]? FirmaDifital { get; set; }

    public int? MsjFecha { get; set; }

    public bool? AutMov { get; set; }

    public string? Correo { get; set; }

    public int? IdDepto { get; set; }

    public string? Cel { get; set; }

    public string? Email { get; set; }

    public string? Nombre { get; set; }

    public string? Aparteno { get; set; }

    public string? Amaterno { get; set; }

    public string? ProyectoPer { get; set; }

    public DateTime? LastConection { get; set; }

    public string? VistaInicio { get; set; }

    public string? PasswdUser { get; set; }

    public DateTime? LastClosure { get; set; }

    public bool? ChangePassword { get; set; }

    public string? PublicIp { get; set; }

    public string? Location { get; set; }

    public string? MondayAccess { get; set; }

    public string? WmPermission { get; set; }

    public virtual TbArea? IdDeptoNavigation { get; set; }

    public virtual TbProfile? IdProfileNavigation { get; set; }

    public virtual ICollection<TbComContrarec> TbComContrarecs { get; set; } = new List<TbComContrarec>();

    public virtual ICollection<TbOrdenCompra> TbOrdenCompras { get; set; } = new List<TbOrdenCompra>();

    public virtual ICollection<TbProyect> TbProyects { get; set; } = new List<TbProyect>();

    public virtual ICollection<TbRequisicion> TbRequisicions { get; set; } = new List<TbRequisicion>();

    public virtual ICollection<TbTipoCambio> TbTipoCambios { get; set; } = new List<TbTipoCambio>();

    public virtual ICollection<UserAsignedToItem> UserAsignedToItems { get; set; } = new List<UserAsignedToItem>();
}
