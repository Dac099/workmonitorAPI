using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbArticulo
{
    public int IdArticulo { get; set; }

    public string? IdUm { get; set; }

    public string? Usuario { get; set; }

    public int? IdArea { get; set; }

    public string? TipoArticulo { get; set; }

    public string NumParte { get; set; } = null!;

    public string? NomArticulo { get; set; }

    public string? Descripcion { get; set; }

    public double? PrecioArticulo { get; set; }

    public bool? InteExterno { get; set; }

    public string? Nota { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string? Estatus { get; set; }

    public string? NumRevision { get; set; }

    public DateOnly? FechaRevision { get; set; }

    public string? Marca { get; set; }

    public string? PartList { get; set; }

    public double? Cant { get; set; }

    public string? IdMoneda { get; set; }

    public string? Caracteristicas { get; set; }

    public string? Job { get; set; }

    public string? TipoMq { get; set; }

    public string? DescProveedor { get; set; }

    public string? RutaImagen { get; set; }

    public string? DivisionArt { get; set; }

    public DateTime? FechaUpdate { get; set; }

    public string? IdProveedor { get; set; }

    public string? Peso { get; set; }

    public int? ArticleGroup { get; set; }

    public virtual ArticleGroup? ArticleGroupNavigation { get; set; }

    public virtual TbUm? IdUmNavigation { get; set; }

    public virtual ICollection<Maquinado> Maquinados { get; set; } = new List<Maquinado>();

    public virtual TbReqTipo? TipoArticuloNavigation { get; set; }
}
