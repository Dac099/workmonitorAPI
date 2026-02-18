using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using workmonitorAPI.Models;

namespace workmonitorAPI.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Access> Accesses { get; set; }

    public virtual DbSet<ArticleGroup> ArticleGroups { get; set; }

    public virtual DbSet<Board> Boards { get; set; }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<Column> Columns { get; set; }

    public virtual DbSet<Comentario> Comentarios { get; set; }

    public virtual DbSet<ComentarioVenta> ComentarioVentas { get; set; }

    public virtual DbSet<DefinedColumnsValue> DefinedColumnsValues { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EntryLog> EntryLogs { get; set; }

    public virtual DbSet<FileDataCache> FileDataCaches { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<MaqComentario> MaqComentarios { get; set; }

    public virtual DbSet<MaqEquipo> MaqEquipos { get; set; }

    public virtual DbSet<MaqLogTipoMetale> MaqLogTipoMetales { get; set; }

    public virtual DbSet<MaqMetale> MaqMetales { get; set; }

    public virtual DbSet<MaqTiempo> MaqTiempos { get; set; }

    public virtual DbSet<MaqTipoEquipo> MaqTipoEquipos { get; set; }

    public virtual DbSet<MaqTipoMaquinado> MaqTipoMaquinados { get; set; }

    public virtual DbSet<MaqTipoMetale> MaqTipoMetales { get; set; }

    public virtual DbSet<MaquiMetale> MaquiMetales { get; set; }

    public virtual DbSet<Maquinado> Maquinados { get; set; }

    public virtual DbSet<MaquinadosDetalle> MaquinadosDetalles { get; set; }

    public virtual DbSet<MaquinadosEstatus> MaquinadosEstatuses { get; set; }

    public virtual DbSet<MegustaNomegustaVenta> MegustaNomegustaVentas { get; set; }

    public virtual DbSet<Menumaster> Menumasters { get; set; }

    public virtual DbSet<Revisione> Revisiones { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<SubItem> SubItems { get; set; }

    public virtual DbSet<TableValue> TableValues { get; set; }

    public virtual DbSet<TbAlmacenLog> TbAlmacenLogs { get; set; }

    public virtual DbSet<TbArea> TbAreas { get; set; }

    public virtual DbSet<TbArtCCosto> TbArtCCostos { get; set; }

    public virtual DbSet<TbArtHprecio> TbArtHprecios { get; set; }

    public virtual DbSet<TbArticulo> TbArticulos { get; set; }

    public virtual DbSet<TbAsignacionGeneralTiempoProyecto> TbAsignacionGeneralTiempoProyectos { get; set; }

    public virtual DbSet<TbAsignacionTiempoProyecto> TbAsignacionTiempoProyectos { get; set; }

    public virtual DbSet<TbAutOcLog> TbAutOcLogs { get; set; }

    public virtual DbSet<TbBanco> TbBancos { get; set; }

    public virtual DbSet<TbCalidadLog> TbCalidadLogs { get; set; }

    public virtual DbSet<TbCargo> TbCargos { get; set; }

    public virtual DbSet<TbCliente> TbClientes { get; set; }

    public virtual DbSet<TbComContraDetum> TbComContraDeta { get; set; }

    public virtual DbSet<TbComContrarec> TbComContrarecs { get; set; }

    public virtual DbSet<TbCompInterno> TbCompInternos { get; set; }

    public virtual DbSet<TbCompra> TbCompras { get; set; }

    public virtual DbSet<TbComprasTemp> TbComprasTemps { get; set; }

    public virtual DbSet<TbCostoVentaJob> TbCostoVentaJobs { get; set; }

    public virtual DbSet<TbCotizacion> TbCotizacions { get; set; }

    public virtual DbSet<TbCotizacionLog> TbCotizacionLogs { get; set; }

    public virtual DbSet<TbDepartamento> TbDepartamentos { get; set; }

    public virtual DbSet<TbDetaDevolucion> TbDetaDevolucions { get; set; }

    public virtual DbSet<TbDevolucionOCambio> TbDevolucionOCambios { get; set; }

    public virtual DbSet<TbEmpDir> TbEmpDirs { get; set; }

    public virtual DbSet<TbEmpleado> TbEmpleados { get; set; }

    public virtual DbSet<TbEmpresa> TbEmpresas { get; set; }

    public virtual DbSet<TbEmpresaCliente> TbEmpresaClientes { get; set; }

    public virtual DbSet<TbEqEstatus> TbEqEstatuses { get; set; }

    public virtual DbSet<TbEstEmail> TbEstEmails { get; set; }

    public virtual DbSet<TbEstatusEquipo> TbEstatusEquipos { get; set; }

    public virtual DbSet<TbFechasProyecto> TbFechasProyectos { get; set; }

    public virtual DbSet<TbFolioRecep> TbFolioReceps { get; set; }

    public virtual DbSet<TbFoliosAlmCal> TbFoliosAlmCals { get; set; }

    public virtual DbSet<TbFoliosDesperdicio> TbFoliosDesperdicios { get; set; }

    public virtual DbSet<TbFoliosDevolucion> TbFoliosDevolucions { get; set; }

    public virtual DbSet<TbHorasExtra> TbHorasExtras { get; set; }

    public virtual DbSet<TbInfoPc> TbInfoPcs { get; set; }

    public virtual DbSet<TbIngenierium> TbIngenieria { get; set; }

    public virtual DbSet<TbInvAlmacenRack> TbInvAlmacenRacks { get; set; }

    public virtual DbSet<TbInvProPiso> TbInvProPisos { get; set; }

    public virtual DbSet<TbMachDiv> TbMachDivs { get; set; }

    public virtual DbSet<TbMachine> TbMachines { get; set; }

    public virtual DbSet<TbMachinesProject> TbMachinesProjects { get; set; }

    public virtual DbSet<TbMaquinadosCalidad> TbMaquinadosCalidads { get; set; }

    public virtual DbSet<TbMarca> TbMarcas { get; set; }

    public virtual DbSet<TbMatReqDetum> TbMatReqDeta { get; set; }

    public virtual DbSet<TbNivel> TbNivels { get; set; }

    public virtual DbSet<TbOcCentrado> TbOcCentrados { get; set; }

    public virtual DbSet<TbOcCotizacion> TbOcCotizacions { get; set; }

    public virtual DbSet<TbOcInterno> TbOcInternos { get; set; }

    public virtual DbSet<TbOcMonedum> TbOcMoneda { get; set; }

    public virtual DbSet<TbOcUsoCdfi> TbOcUsoCdfis { get; set; }

    public virtual DbSet<TbOperacionesDetalle> TbOperacionesDetalles { get; set; }

    public virtual DbSet<TbOperacionesMaquinado> TbOperacionesMaquinados { get; set; }

    public virtual DbSet<TbOrdenCompra> TbOrdenCompras { get; set; }

    public virtual DbSet<TbOrdenCompraPriority> TbOrdenCompraPriorities { get; set; }

    public virtual DbSet<TbPeriodo> TbPeriodos { get; set; }

    public virtual DbSet<TbPeriodoAusencium> TbPeriodoAusencia { get; set; }

    public virtual DbSet<TbProComp> TbProComps { get; set; }

    public virtual DbSet<TbProPartList> TbProPartLists { get; set; }

    public virtual DbSet<TbProRev> TbProRevs { get; set; }

    public virtual DbSet<TbProTipo> TbProTipos { get; set; }

    public virtual DbSet<TbProfile> TbProfiles { get; set; }

    public virtual DbSet<TbProvTipo> TbProvTipos { get; set; }

    public virtual DbSet<TbProveedor> TbProveedors { get; set; }

    public virtual DbSet<TbProyAlmacen> TbProyAlmacens { get; set; }

    public virtual DbSet<TbProyArtAlmacen> TbProyArtAlmacens { get; set; }

    public virtual DbSet<TbProyChecklist> TbProyChecklists { get; set; }

    public virtual DbSet<TbProyChecklistMeca> TbProyChecklistMecas { get; set; }

    public virtual DbSet<TbProyLider> TbProyLiders { get; set; }

    public virtual DbSet<TbProyTransArtAlm> TbProyTransArtAlms { get; set; }

    public virtual DbSet<TbProyect> TbProyects { get; set; }

    public virtual DbSet<TbProyectCosto> TbProyectCostos { get; set; }

    public virtual DbSet<TbProyectLog> TbProyectLogs { get; set; }

    public virtual DbSet<TbRegHorasJob> TbRegHorasJobs { get; set; }

    public virtual DbSet<TbRegPrestamosAsignacion> TbRegPrestamosAsignacions { get; set; }

    public virtual DbSet<TbRegistroAusencia> TbRegistroAusencias { get; set; }

    public virtual DbSet<TbReqDetum> TbReqDeta { get; set; }

    public virtual DbSet<TbReqMaterial> TbReqMaterials { get; set; }

    public virtual DbSet<TbReqMecanizado> TbReqMecanizados { get; set; }

    public virtual DbSet<TbReqPrioridad> TbReqPrioridads { get; set; }

    public virtual DbSet<TbReqTipo> TbReqTipos { get; set; }

    public virtual DbSet<TbRequisicion> TbRequisicions { get; set; }

    public virtual DbSet<TbRfqLog> TbRfqLogs { get; set; }

    public virtual DbSet<TbSalidaMat> TbSalidaMats { get; set; }

    public virtual DbSet<TbSalidaTratamientoAcabado> TbSalidaTratamientoAcabados { get; set; }

    public virtual DbSet<TbSgcFor> TbSgcFors { get; set; }

    public virtual DbSet<TbTipoAusencium> TbTipoAusencia { get; set; }

    public virtual DbSet<TbTipoCambio> TbTipoCambios { get; set; }

    public virtual DbSet<TbTipoDiagrama> TbTipoDiagramas { get; set; }

    public virtual DbSet<TbTipocustodium> TbTipocustodia { get; set; }

    public virtual DbSet<TbTratamientoAcabado> TbTratamientoAcabados { get; set; }

    public virtual DbSet<TbUbiEquipo> TbUbiEquipos { get; set; }

    public virtual DbSet<TbUm> TbUms { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<TbUserPermiso> TbUserPermisos { get; set; }

    public virtual DbSet<TbWebPermiso> TbWebPermisos { get; set; }

    public virtual DbSet<UserAsignedToItem> UserAsignedToItems { get; set; }

    public virtual DbSet<View> Views { get; set; }

    public virtual DbSet<ViewSetting> ViewSettings { get; set; }

    public virtual DbSet<Workspace> Workspaces { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
    }
 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Access>(entity =>
        {
            entity.HasKey(e => e.SrId);

            entity.ToTable("ACCESS");

            entity.Property(e => e.SrId).HasColumnName("SrID");
            entity.Property(e => e.AccessId).HasColumnName("AccessID");
            entity.Property(e => e.MenuId).HasColumnName("MenuID");

            entity.HasOne(d => d.Menu).WithMany(p => p.Accesses)
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("FK_ACCESS_MENUMASTER");
        });

        modelBuilder.Entity<ArticleGroup>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__ArticleG__06370DAD53DB7A44");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<Board>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Boards__3213E83F8F8FF0DE");

            entity.HasIndex(e => e.WorkspaceId, "IX_Boards_WorkspaceId");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");
            entity.Property(e => e.WorkspaceId).HasColumnName("workspace_id");

            entity.HasOne(d => d.Workspace).WithMany(p => p.Boards)
                .HasForeignKey(d => d.WorkspaceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Boards__workspac__2082B559");
        });

        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Chats__3213E83F7A439895");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("deleted_at");
            entity.Property(e => e.ItemId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("item_id");
            entity.Property(e => e.Message)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.Responses)
                .HasDefaultValue("{[]}")
                .HasColumnName("responses");
            entity.Property(e => e.Tasks)
                .HasDefaultValue("{[]}")
                .HasColumnName("tasks");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Item).WithMany(p => p.Chats)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK__Chats__item_id__6C0EED1A");
        });

        modelBuilder.Entity<Column>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Columns__3213E83F13CFAEA3");

            entity.HasIndex(e => e.BoardId, "IX_Columns_BoardId");

            entity.HasIndex(e => e.Position, "IX_Columns_Position");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.BoardId).HasColumnName("board_id");
            entity.Property(e => e.ColumnWidth)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("column_width");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Settings)
                .HasMaxLength(255)
                .HasColumnName("settings");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Board).WithMany(p => p.Columns)
                .HasForeignKey(d => d.BoardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Columns__board_i__4C9641C1");
        });

        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.ToTable("comentario");

            entity.Property(e => e.ComentarioId)
                .HasDefaultValueSql("(NEXT VALUE FOR [comentario_ids])")
                .HasColumnName("comentario_id");
            entity.Property(e => e.Comment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("comment");
            entity.Property(e => e.CommentSenderName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("comment_sender_name");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.IdReg).HasColumnName("id_reg");
            entity.Property(e => e.ParentComentarioId).HasColumnName("parent_comentario_id");
        });

        modelBuilder.Entity<ComentarioVenta>(entity =>
        {
            entity.HasKey(e => e.ComentarioId);

            entity.ToTable("comentario_ventas");

            entity.Property(e => e.ComentarioId)
                .HasDefaultValueSql("(NEXT VALUE FOR [comentario_ventas_ids])")
                .HasColumnName("comentario_id");
            entity.Property(e => e.Comment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("comment");
            entity.Property(e => e.CommentSenderName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("comment_sender_name");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.IdCotizacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id_cotizacion");
            entity.Property(e => e.ParentComentarioId).HasColumnName("parent_comentario_id");
        });

        modelBuilder.Entity<DefinedColumnsValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__definedC__3213E83FE22CCA4D");

            entity.ToTable("definedColumnsValues");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .IsUnicode(false)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83FA8B54DEE");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("birthDate");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.Curp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("curp");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("department");
            entity.Property(e => e.Imss)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("imss");
            entity.Property(e => e.MaternalSurname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maternalSurname");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PaternalSurname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("paternalSurname");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.Rfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("userId");
        });

        modelBuilder.Entity<EntryLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EntryLog__3213E83FC8677260");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Msg)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("msg");
            entity.Property(e => e.Resource)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("resource");
            entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            entity.Property(e => e.Type)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.ValueLog)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("value_log");
        });

        modelBuilder.Entity<FileDataCache>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FileData__3213E83FCD882E89");

            entity.ToTable("FileDataCache");

            entity.HasIndex(e => e.BatchId, "IX_FileDataCache_batchId");

            entity.HasIndex(e => new { e.Project, e.ManufacturerNumber, e.RfqSys }, "IX_FileDataCache_project_manufacturerNumber_rfqSys");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BatchId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("batchId");
            entity.Property(e => e.InvoiceDate).HasColumnName("invoiceDate");
            entity.Property(e => e.InvoiceNumbers)
                .HasMaxLength(255)
                .HasColumnName("invoiceNumbers");
            entity.Property(e => e.InvoicedPercentAmount)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("invoicedPercentAmount");
            entity.Property(e => e.InvoicedPercentQuantity)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("invoicedPercentQuantity");
            entity.Property(e => e.InvoicedQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("invoicedQuantity");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(500)
                .HasColumnName("itemCode");
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(2000)
                .HasColumnName("itemDescription");
            entity.Property(e => e.LineStatus)
                .HasMaxLength(100)
                .HasColumnName("lineStatus");
            entity.Property(e => e.ManufacturerNumber)
                .HasMaxLength(500)
                .HasColumnName("manufacturerNumber");
            entity.Property(e => e.OrderDate).HasColumnName("orderDate");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(200)
                .HasColumnName("orderNumber");
            entity.Property(e => e.OrderedQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("orderedQuantity");
            entity.Property(e => e.PendingInvoiceAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pendingInvoiceAmount");
            entity.Property(e => e.PendingInvoiceAmountFc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pendingInvoiceAmountFC");
            entity.Property(e => e.PendingInvoiceQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pendingInvoiceQuantity");
            entity.Property(e => e.PendingReceiptAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pendingReceiptAmount");
            entity.Property(e => e.PendingReceiptAmountFc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pendingReceiptAmountFC");
            entity.Property(e => e.PendingReceiptQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pendingReceiptQuantity");
            entity.Property(e => e.PoStatus)
                .HasMaxLength(100)
                .HasColumnName("poStatus");
            entity.Property(e => e.PriceCurrency)
                .HasMaxLength(10)
                .HasColumnName("priceCurrency");
            entity.Property(e => e.Project)
                .HasMaxLength(200)
                .HasColumnName("project");
            entity.Property(e => e.PromisedDeliveryDate).HasColumnName("promisedDeliveryDate");
            entity.Property(e => e.ReceiptNumbers)
                .HasMaxLength(255)
                .HasColumnName("receiptNumbers");
            entity.Property(e => e.ReceivedDate).HasColumnName("receivedDate");
            entity.Property(e => e.ReceivedPercentAmount)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("receivedPercentAmount");
            entity.Property(e => e.ReceivedPercentQuantity)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("receivedPercentQuantity");
            entity.Property(e => e.ReceivedQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("receivedQuantity");
            entity.Property(e => e.RfqSys)
                .HasMaxLength(200)
                .HasColumnName("rfqSys");
            entity.Property(e => e.TotalInvoicedAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalInvoicedAmount");
            entity.Property(e => e.TotalInvoicedAmountFc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalInvoicedAmountFC");
            entity.Property(e => e.TotalOrderAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalOrderAmount");
            entity.Property(e => e.TotalOrderAmountFc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalOrderAmountFC");
            entity.Property(e => e.TotalReceivedAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalReceivedAmount");
            entity.Property(e => e.TotalReceivedAmountFc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalReceivedAmountFC");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("unitPrice");
            entity.Property(e => e.UploadTimestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("uploadTimestamp");
            entity.Property(e => e.VendorCode)
                .HasMaxLength(200)
                .HasColumnName("vendorCode");
            entity.Property(e => e.VendorName)
                .HasMaxLength(1000)
                .HasColumnName("vendorName");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Groups__3213E83FDB9B2AC0");

            entity.HasIndex(e => e.BoardId, "IX_Groups_BoardId");

            entity.HasIndex(e => e.Position, "IX_Groups_Position");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.BoardId).HasColumnName("board_id");
            entity.Property(e => e.Color)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValue("#000000")
                .HasColumnName("color");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Board).WithMany(p => p.Groups)
                .HasForeignKey(d => d.BoardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Groups__board_id__40306ADC");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Items__3213E83FAA2B5F44");

            entity.HasIndex(e => e.GroupId, "IX_Items_GroupId");

            entity.HasIndex(e => e.Position, "IX_Items_Position");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.ProjectId)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("project_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Group).WithMany(p => p.Items)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Items__group_id__45E94432");

            entity.HasOne(d => d.Project).WithMany(p => p.Items)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK__Items__project_i__46DD686B");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Manufact__3213E83F07D717FF");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<MaqComentario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Maq_Comentarios");

            entity.Property(e => e.Archivo).HasMaxLength(150);
            entity.Property(e => e.Comentario).HasMaxLength(700);
            entity.Property(e => e.FCreacion).HasColumnName("F_creacion");
            entity.Property(e => e.IdComent)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_coment");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_usuario");
            entity.Property(e => e.NomFile)
                .HasMaxLength(50)
                .HasColumnName("Nom_File");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(60)
                .HasColumnName("Part_number");
        });

        modelBuilder.Entity<MaqEquipo>(entity =>
        {
            entity.HasKey(e => e.IdEquipo);

            entity.ToTable("Maq_Equipo");

            entity.Property(e => e.IdEquipo)
                .HasMaxLength(10)
                .HasColumnName("Id_Equipo");
            entity.Property(e => e.IdTipoEquipo)
                .HasMaxLength(10)
                .HasColumnName("Id_Tipo_Equipo");
            entity.Property(e => e.NomEquipo)
                .HasMaxLength(25)
                .HasColumnName("Nom_Equipo");
            entity.Property(e => e.Ubicacion).HasMaxLength(20);
        });

        modelBuilder.Entity<MaqLogTipoMetale>(entity =>
        {
            entity.HasKey(e => e.IdRegLog);

            entity.ToTable("Maq_Log_Tipo_Metales");

            entity.Property(e => e.IdRegLog).HasColumnName("Id_Reg_Log");
            entity.Property(e => e.DescLog)
                .HasMaxLength(800)
                .HasColumnName("desc_log");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(15)
                .HasColumnName("id_proyecto");
            entity.Property(e => e.NPartMetal)
                .HasMaxLength(30)
                .HasColumnName("n_part_metal");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
            entity.Property(e => e.VentanaTipo)
                .HasMaxLength(30)
                .HasColumnName("Ventana_Tipo");
        });

        modelBuilder.Entity<MaqMetale>(entity =>
        {
            entity.HasKey(e => e.IdMetal).HasName("PK_Maq_Material");

            entity.ToTable("Maq_Metales");

            entity.Property(e => e.IdMetal)
                .HasMaxLength(10)
                .HasColumnName("Id_Metal");
            entity.Property(e => e.DescMetal)
                .HasMaxLength(50)
                .HasColumnName("Desc_Metal");
            entity.Property(e => e.FIngreso)
                .HasColumnType("datetime")
                .HasColumnName("F_Ingreso");
            entity.Property(e => e.NomMetal)
                .HasMaxLength(25)
                .HasColumnName("Nom_Metal");
            entity.Property(e => e.Um)
                .HasMaxLength(10)
                .HasColumnName("UM");
        });

        modelBuilder.Entity<MaqTiempo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("maq_tiempos");

            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("cantidad");
            entity.Property(e => e.DifHoras).HasColumnName("dif_horas");
            entity.Property(e => e.EsArchivado).HasColumnName("es_archivado");
            entity.Property(e => e.EsCierreAut).HasColumnName("es_cierre_aut");
            entity.Property(e => e.FechaHoraFin)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hora_Fin");
            entity.Property(e => e.FechaHoraInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hora_inicio");
            entity.Property(e => e.HorasMaquinado).HasColumnName("horas_maquinado");
            entity.Property(e => e.HorasProgramacion).HasColumnName("horas_programacion");
            entity.Property(e => e.HorasTeoricas).HasColumnName("horas_teoricas");
            entity.Property(e => e.IdMaqTiempo)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_maq_tiempo");
            entity.Property(e => e.IdMaquina)
                .HasMaxLength(60)
                .HasColumnName("id_maquina");
            entity.Property(e => e.IdOperador)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("id_operador");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(15)
                .HasColumnName("id_proyecto");
            entity.Property(e => e.NumParte)
                .HasMaxLength(60)
                .HasColumnName("num_parte");
            entity.Property(e => e.PrecioTot).HasColumnName("precio_tot");
            entity.Property(e => e.TipoMaquinado)
                .HasMaxLength(50)
                .HasColumnName("tipo_maquinado");
        });

        modelBuilder.Entity<MaqTipoEquipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoEquipo);

            entity.ToTable("Maq_Tipo_Equipo");

            entity.Property(e => e.IdTipoEquipo)
                .HasMaxLength(10)
                .HasColumnName("Id_Tipo_Equipo");
            entity.Property(e => e.CostoHora)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Costo_Hora");
            entity.Property(e => e.CostoHoraPro)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Costo_Hora_Pro");
            entity.Property(e => e.DescTipo)
                .HasMaxLength(50)
                .HasColumnName("Desc_Tipo");
            entity.Property(e => e.FActualizacion).HasColumnName("F_Actualizacion");
            entity.Property(e => e.FIngreso).HasColumnName("F_Ingreso");
            entity.Property(e => e.IdMoneda)
                .HasMaxLength(10)
                .HasColumnName("Id_moneda");
            entity.Property(e => e.NomTipo)
                .HasMaxLength(25)
                .HasColumnName("Nom_Tipo");
        });

        modelBuilder.Entity<MaqTipoMaquinado>(entity =>
        {
            entity.HasKey(e => e.IdTipoMaquinado);

            entity.ToTable("Maq_Tipo_Maquinado");

            entity.Property(e => e.IdTipoMaquinado)
                .HasMaxLength(10)
                .HasColumnName("id_tipo_maquinado");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.NomTipoMaquinado)
                .HasMaxLength(25)
                .HasColumnName("nom_tipo_maquinado");
            entity.Property(e => e.Orden).HasColumnName("orden");
        });

        modelBuilder.Entity<MaqTipoMetale>(entity =>
        {
            entity.HasKey(e => e.IdTipoMetal).HasName("PK_Maq_Tipo_Material");

            entity.ToTable("Maq_Tipo_Metales");

            entity.Property(e => e.IdTipoMetal)
                .HasMaxLength(10)
                .HasColumnName("Id_Tipo_Metal");
            entity.Property(e => e.Densidad).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DescTipo)
                .HasMaxLength(50)
                .HasColumnName("Desc_Tipo");
            entity.Property(e => e.FActualizacion).HasColumnName("F_Actualizacion");
            entity.Property(e => e.FIngreso).HasColumnName("F_Ingreso");
            entity.Property(e => e.IdMetal)
                .HasMaxLength(10)
                .HasColumnName("Id_Metal");
            entity.Property(e => e.IdMoneda)
                .HasMaxLength(10)
                .HasColumnName("Id_moneda");
            entity.Property(e => e.NPartMetal)
                .HasMaxLength(30)
                .HasColumnName("n_part_metal");
            entity.Property(e => e.NomTipo)
                .HasMaxLength(25)
                .HasColumnName("Nom_Tipo");
            entity.Property(e => e.PrecioKg)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Precio_Kg");

            entity.HasOne(d => d.IdMetalNavigation).WithMany(p => p.MaqTipoMetales)
                .HasForeignKey(d => d.IdMetal)
                .HasConstraintName("FK_Maq_Tipo_Metales_Maq_Metales");
        });

        modelBuilder.Entity<MaquiMetale>(entity =>
        {
            entity.HasKey(e => e.IdMetal).HasName("PK__Maqui_Me__55129042D8C45ECE");

            entity.ToTable("Maqui_Metales");

            entity.Property(e => e.IdMetal).HasColumnName("id_metal");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(70)
                .HasColumnName("descripcion");
            entity.Property(e => e.FActualiza)
                .HasColumnType("datetime")
                .HasColumnName("f_actualiza");
            entity.Property(e => e.FRegistro)
                .HasColumnType("datetime")
                .HasColumnName("f_registro");
            entity.Property(e => e.GrupoArt)
                .HasMaxLength(15)
                .HasColumnName("grupo_art");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .HasColumnName("moneda");
            entity.Property(e => e.NumMetal)
                .HasMaxLength(30)
                .HasColumnName("num_metal");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.Um)
                .HasMaxLength(10)
                .HasColumnName("um");
        });

        modelBuilder.Entity<Maquinado>(entity =>
        {
            entity.HasKey(e => e.IdMaquinado);

            entity.Property(e => e.IdMaquinado).HasColumnName("Id_Maquinado");
            entity.Property(e => e.Acabado).HasMaxLength(55);
            entity.Property(e => e.AlturaMm)
                .HasColumnType("numeric(8, 4)")
                .HasColumnName("Altura_mm");
            entity.Property(e => e.AnchoM)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("Ancho_M");
            entity.Property(e => e.CostoFinal)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("Costo_Final");
            entity.Property(e => e.CostoGlobal)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("Costo_Global");
            entity.Property(e => e.CostoHorasMaquinas)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("Costo_Horas_Maquinas");
            entity.Property(e => e.CostoTotal)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("Costo_Total");
            entity.Property(e => e.DmAncho)
                .HasMaxLength(5)
                .HasColumnName("DM_Ancho");
            entity.Property(e => e.Especificaciones).HasMaxLength(1500);
            entity.Property(e => e.EstatusInt)
                .HasMaxLength(5)
                .HasColumnName("Estatus_Int");
            entity.Property(e => e.EstatusSol).HasColumnName("estatus_sol");
            entity.Property(e => e.FechaFin).HasColumnName("Fecha_Fin");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_Inicio");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.FolioReqMat)
                .HasMaxLength(12)
                .HasColumnName("folio_req_mat");
            entity.Property(e => e.HorasTrabajo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("Horas_Trabajo");
            entity.Property(e => e.IdEquipo)
                .HasMaxLength(50)
                .HasColumnName("Id_Equipo");
            entity.Property(e => e.IdMaquinadoCalidad).HasColumnName("id_maquinado_calidad");
            entity.Property(e => e.IdMoneda)
                .HasMaxLength(10)
                .HasColumnName("id_moneda");
            entity.Property(e => e.IdPrioridad).HasColumnName("id_prioridad");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(15)
                .HasColumnName("Id_Proyecto");
            entity.Property(e => e.IdRequisicion).HasColumnName("Id_Requisicion");
            entity.Property(e => e.IdTipoMaterial)
                .HasMaxLength(10)
                .HasColumnName("Id_Tipo_Material");
            entity.Property(e => e.IdUser).HasColumnName("Id_User");
            entity.Property(e => e.KgPiezas)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Kg_Piezas");
            entity.Property(e => e.LargoM)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("Largo_M");
            entity.Property(e => e.MaquiPadre).HasColumnName("maqui_padre");
            entity.Property(e => e.Marca).HasMaxLength(50);
            entity.Property(e => e.Material).HasMaxLength(55);
            entity.Property(e => e.Mecanizado).HasMaxLength(25);
            entity.Property(e => e.Medidas).HasMaxLength(120);
            entity.Property(e => e.MqEstatusInt)
                .HasMaxLength(5)
                .HasColumnName("Mq_Estatus_Int");
            entity.Property(e => e.NumParte)
                .HasMaxLength(60)
                .HasColumnName("Num_Parte");
            entity.Property(e => e.NumPiezas)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Num_Piezas");
            entity.Property(e => e.Observaciones).HasMaxLength(150);
            entity.Property(e => e.PdaRfq).HasColumnName("pda_rfq");
            entity.Property(e => e.PrecioKg)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("Precio_Kg");
            entity.Property(e => e.Prioridad).HasMaxLength(25);
            entity.Property(e => e.ReTrabajo).HasColumnName("re_trabajo");
            entity.Property(e => e.RechazoCalidad).HasColumnName("rechazo_calidad");
            entity.Property(e => e.Rev).HasMaxLength(5);
            entity.Property(e => e.Spare).HasMaxLength(55);
            entity.Property(e => e.TiempoProgramacion).HasColumnName("tiempo_programacion");
            entity.Property(e => e.TipCambio).HasColumnName("tip_cambio");
            entity.Property(e => e.TipoMaquinado)
                .HasMaxLength(10)
                .HasColumnName("tipo_maquinado");
            entity.Property(e => e.TotalLongitud)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("Total_Longitud");
            entity.Property(e => e.Um)
                .HasMaxLength(10)
                .HasColumnName("um");

            entity.HasOne(d => d.NumParteNavigation).WithMany(p => p.Maquinados)
                .HasPrincipalKey(p => p.NumParte)
                .HasForeignKey(d => d.NumParte)
                .HasConstraintName("FK_Maquinados_tb_articulo");
        });

        modelBuilder.Entity<MaquinadosDetalle>(entity =>
        {
            entity.HasKey(e => e.IdMaquinadoDetalles).HasName("PK__Maquinad__07B95DE7F358BB49");

            entity.ToTable("Maquinados_Detalles");

            entity.Property(e => e.IdMaquinadoDetalles).HasColumnName("Id_Maquinado_Detalles");
            entity.Property(e => e.IdMaquinado).HasColumnName("Id_Maquinado");
            entity.Property(e => e.KgPiezaIndiv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("kg_pieza_indiv");
            entity.Property(e => e.MaqDetaEstatus)
                .HasMaxLength(5)
                .HasColumnName("maq_deta_estatus");
            entity.Property(e => e.MedidasDeta)
                .HasMaxLength(120)
                .HasColumnName("medidas_deta");
            entity.Property(e => e.NParte)
                .HasMaxLength(60)
                .HasColumnName("n_parte");
            entity.Property(e => e.SolMat).HasColumnName("sol_mat");
        });

        modelBuilder.Entity<MaquinadosEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("Maquinados_Estatus");

            entity.Property(e => e.IdEstatus)
                .HasMaxLength(10)
                .HasColumnName("Id_Estatus");
            entity.Property(e => e.DescEstatus)
                .HasMaxLength(25)
                .HasColumnName("Desc_Estatus");
            entity.Property(e => e.Nota).HasMaxLength(10);
            entity.Property(e => e.Observaciones).HasMaxLength(100);
        });

        modelBuilder.Entity<MegustaNomegustaVenta>(entity =>
        {
            entity.ToTable("megusta_nomegusta_ventas");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(NEXT VALUE FOR [megusta_ventas_ids])")
                .HasColumnName("id");
            entity.Property(e => e.ComentarioId).HasColumnName("comentario_id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.LikeUnlike).HasColumnName("like_unlike");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
        });

        modelBuilder.Entity<Menumaster>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("MENUMASTER");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.FormName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsActive)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MainMenuId).HasColumnName("MainMenuID");
            entity.Property(e => e.MenuText)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Revisione>(entity =>
        {
            entity.HasKey(e => e.IdRev);

            entity.Property(e => e.IdRev).HasColumnName("Id_Rev");
            entity.Property(e => e.LetraRev)
                .HasMaxLength(3)
                .HasColumnName("Letra_Rev");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.IdSett);

            entity.ToTable("SETTINGS");

            entity.Property(e => e.IdSett)
                .HasMaxLength(50)
                .HasColumnName("id_sett");
            entity.Property(e => e.DateReg)
                .HasColumnType("datetime")
                .HasColumnName("date_reg");
            entity.Property(e => e.DescSett)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("desc_sett");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("tipo_dato");
            entity.Property(e => e.ValueSett)
                .HasMaxLength(110)
                .HasColumnName("value_sett");
        });

        modelBuilder.Entity<SubItem>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.ItemParent).HasColumnName("item_parent");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.ItemParentNavigation).WithMany(p => p.SubItems)
                .HasForeignKey(d => d.ItemParent)
                .HasConstraintName("FK_subItem_parentItem");
        });

        modelBuilder.Entity<TableValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TableVal__3213E83FECDA32DF");

            entity.HasIndex(e => e.ColumnId, "IX_Values_ColumnId");

            entity.HasIndex(e => e.ItemId, "IX_Values_ItemId");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.ColumnId).HasColumnName("column_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.ItemId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("item_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");

            entity.HasOne(d => d.Column).WithMany(p => p.TableValues)
                .HasForeignKey(d => d.ColumnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TableValu__colum__54376389");
        });

        modelBuilder.Entity<TbAlmacenLog>(entity =>
        {
            entity.HasKey(e => e.IdLog).HasName("PK_tb_req_mat_log");

            entity.ToTable("tb_almacen_log");

            entity.Property(e => e.IdLog).HasColumnName("id_log");
            entity.Property(e => e.DescLog)
                .HasMaxLength(500)
                .HasColumnName("desc_log");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Tipo)
                .HasMaxLength(25)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TbArea>(entity =>
        {
            entity.HasKey(e => e.IdArea);

            entity.ToTable("tb_area");

            entity.Property(e => e.IdArea).HasColumnName("id_area");
            entity.Property(e => e.Adic01)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("adic_01");
            entity.Property(e => e.DescAre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("desc_are");
            entity.Property(e => e.MailGrupo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("mail_grupo");
            entity.Property(e => e.NomArea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_area");
            entity.Property(e => e.NomGere)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_gere");
            entity.Property(e => e.Not01)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("not_01");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.PathFile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("path_file");
            entity.Property(e => e.TiempoMod)
                .HasComment("Tiepo de modificación registros")
                .HasColumnName("tiempo_mod");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
            entity.Property(e => e.User01)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("user_01");
        });

        modelBuilder.Entity<TbArtCCosto>(entity =>
        {
            entity.HasKey(e => e.IdCCosto);

            entity.ToTable("tb_art_c_costos");

            entity.Property(e => e.IdCCosto).HasColumnName("id_c_costo");
            entity.Property(e => e.Detail)
                .HasMaxLength(500)
                .HasColumnName("detail");
            entity.Property(e => e.IdPn)
                .HasMaxLength(50)
                .HasColumnName("id_pn");
            entity.Property(e => e.IdType)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_type");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");

            entity.HasOne(d => d.IdTypeNavigation).WithMany(p => p.TbArtCCostos)
                .HasForeignKey(d => d.IdType)
                .HasConstraintName("FK_tb_art_c_costos_tb_req_tipo");
        });

        modelBuilder.Entity<TbArtHprecio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_art_hprecios");

            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdArt).HasColumnName("id_art");
            entity.Property(e => e.IdMoneda)
                .HasMaxLength(10)
                .HasColumnName("id_moneda");
            entity.Property(e => e.IdUm)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_um");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Np)
                .HasMaxLength(60)
                .HasColumnName("np");
            entity.Property(e => e.Precio)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("precio");

            entity.HasOne(d => d.IdArtNavigation).WithMany()
                .HasForeignKey(d => d.IdArt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_art_hprecios_tb_articulo");
        });

        modelBuilder.Entity<TbArticulo>(entity =>
        {
            entity.HasKey(e => e.IdArticulo);

            entity.ToTable("tb_articulo");

            entity.HasIndex(e => e.NumParte, "num_parte_unique").IsUnique();

            entity.Property(e => e.IdArticulo).HasColumnName("id_articulo");
            entity.Property(e => e.ArticleGroup).HasColumnName("article_group");
            entity.Property(e => e.Cant).HasColumnName("cant");
            entity.Property(e => e.Caracteristicas)
                .HasMaxLength(700)
                .HasColumnName("caracteristicas");
            entity.Property(e => e.DescProveedor)
                .HasMaxLength(120)
                .HasColumnName("desc_proveedor");
            entity.Property(e => e.Descripcion)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.DivisionArt)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("division_art");
            entity.Property(e => e.Estatus)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasDefaultValueSql("((0))", "DF_tb_articulo_estatus")
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaRevision).HasColumnName("fecha_revision");
            entity.Property(e => e.FechaUpdate)
                .HasColumnType("datetime")
                .HasColumnName("fecha_update");
            entity.Property(e => e.IdArea).HasColumnName("id_area");
            entity.Property(e => e.IdMoneda)
                .HasMaxLength(10)
                .HasColumnName("id_moneda");
            entity.Property(e => e.IdProveedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("id_proveedor");
            entity.Property(e => e.IdUm)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_um");
            entity.Property(e => e.InteExterno).HasColumnName("inte_externo");
            entity.Property(e => e.Job)
                .HasMaxLength(15)
                .HasColumnName("job");
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .HasColumnName("marca");
            entity.Property(e => e.NomArticulo)
                .HasMaxLength(500)
                .HasColumnName("nom_articulo");
            entity.Property(e => e.Nota)
                .HasMaxLength(250)
                .HasColumnName("nota");
            entity.Property(e => e.NumParte)
                .HasMaxLength(60)
                .HasColumnName("num_parte");
            entity.Property(e => e.NumRevision)
                .HasMaxLength(10)
                .HasColumnName("num_revision");
            entity.Property(e => e.PartList)
                .HasMaxLength(30)
                .HasColumnName("part_list");
            entity.Property(e => e.Peso)
                .HasMaxLength(10)
                .HasColumnName("peso");
            entity.Property(e => e.PrecioArticulo).HasColumnName("precio_articulo");
            entity.Property(e => e.RutaImagen)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ruta_imagen");
            entity.Property(e => e.TipoArticulo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("tipo_articulo");
            entity.Property(e => e.TipoMq)
                .HasMaxLength(2)
                .HasColumnName("tipo_mq");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");

            entity.HasOne(d => d.ArticleGroupNavigation).WithMany(p => p.TbArticulos)
                .HasForeignKey(d => d.ArticleGroup)
                .HasConstraintName("FK_tb_articulo_ArticleGroups");

            entity.HasOne(d => d.IdUmNavigation).WithMany(p => p.TbArticulos)
                .HasForeignKey(d => d.IdUm)
                .HasConstraintName("FK_tb_articulo_tb_um");

            entity.HasOne(d => d.TipoArticuloNavigation).WithMany(p => p.TbArticulos)
                .HasForeignKey(d => d.TipoArticulo)
                .HasConstraintName("FK_tb_articulo_tb_req_tipo");
        });

        modelBuilder.Entity<TbAsignacionGeneralTiempoProyecto>(entity =>
        {
            entity.HasKey(e => e.IdAsignacionGeneralProyecto).HasName("PK_id_asignacion_g_proyecto");

            entity.ToTable("tb_asignacion_general_tiempo_proyectos");

            entity.Property(e => e.IdAsignacionGeneralProyecto)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_asignacion_general_proyecto])")
                .HasColumnName("id_asignacion_general_proyecto");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.AsignacionGeneral)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asignacion_general");
            entity.Property(e => e.CostoHora).HasColumnName("costo_hora");
        });

        modelBuilder.Entity<TbAsignacionTiempoProyecto>(entity =>
        {
            entity.HasKey(e => e.IdAsignacionProyecto).HasName("PK_id_asignacion_proyecto");

            entity.ToTable("tb_asignacion_tiempo_proyectos");

            entity.Property(e => e.IdAsignacionProyecto)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_asignacion_proyecto])")
                .HasColumnName("id_asignacion_proyecto");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.AsignacionEspecifica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asignacion_especifica");
            entity.Property(e => e.CostoHora).HasColumnName("costo_hora");
            entity.Property(e => e.IdAsignacionGeneral).HasColumnName("id_asignacion_general");
        });

        modelBuilder.Entity<TbAutOcLog>(entity =>
        {
            entity.HasKey(e => e.IdLog).HasName("PK__tb_aut_o__6CC851FEA04804C8");

            entity.ToTable("tb_aut_oc_log");

            entity.Property(e => e.IdLog).HasColumnName("id_log");
            entity.Property(e => e.Descrip)
                .HasMaxLength(350)
                .HasColumnName("descrip");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdOrdenCompra).HasColumnName("id_orden_compra");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdOrdenCompraNavigation).WithMany(p => p.TbAutOcLogs)
                .HasForeignKey(d => d.IdOrdenCompra)
                .HasConstraintName("fk_tb_aut_oc_log_tb_orden_compra");
        });

        modelBuilder.Entity<TbBanco>(entity =>
        {
            entity.HasKey(e => e.IdBanco).HasName("PK__tb_banco__70BD16423D8B7B97");

            entity.ToTable("tb_bancos");

            entity.Property(e => e.IdBanco).HasColumnName("id_banco");
            entity.Property(e => e.NomBanco)
                .HasMaxLength(60)
                .HasColumnName("nom_banco");
        });

        modelBuilder.Entity<TbCalidadLog>(entity =>
        {
            entity.HasKey(e => e.IdLog).HasName("PK_id_log");

            entity.ToTable("tb_calidad_log");

            entity.Property(e => e.IdLog)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_calidad_log])")
                .HasColumnName("id_log");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.NumParte)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("num_parte");
        });

        modelBuilder.Entity<TbCargo>(entity =>
        {
            entity.HasKey(e => e.IdCargo);

            entity.ToTable("tb_cargos");

            entity.Property(e => e.IdCargo)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_cargos])")
                .HasColumnName("id_cargo");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TbCliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.ToTable("tb_cliente");

            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(30)
                .HasColumnName("cod_cliente");
            entity.Property(e => e.CorreoContacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo_contacto");
            entity.Property(e => e.DirCliente00)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dir_cliente_00");
            entity.Property(e => e.DirCliente01)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("dir_cliente_01");
            entity.Property(e => e.DirRutaGral)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dir_ruta_gral");
            entity.Property(e => e.EstadoCliente)
                .HasDefaultValue(true, "DF_tb_cliente_estado_cliente")
                .HasColumnName("estado_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdSector)
                .HasMaxLength(5)
                .HasColumnName("id_sector");
            entity.Property(e => e.NomCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nom_cliente");
            entity.Property(e => e.NomContacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_contacto");
            entity.Property(e => e.Puesto)
                .HasMaxLength(70)
                .HasColumnName("puesto");
            entity.Property(e => e.Rfc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.TelCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tel_cliente");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
        });

        modelBuilder.Entity<TbComContraDetum>(entity =>
        {
            entity.HasKey(e => e.IdDetaContra);

            entity.ToTable("tb_com_contra_deta");

            entity.Property(e => e.IdDetaContra).HasColumnName("id__deta_contra");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.IdContrarec).HasColumnName("id_contrarec");
            entity.Property(e => e.IdMoneda)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_moneda");
            entity.Property(e => e.Importe).HasColumnName("importe");
            entity.Property(e => e.NumFactura)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("num_factura");

            entity.HasOne(d => d.IdContrarecNavigation).WithMany(p => p.TbComContraDeta)
                .HasForeignKey(d => d.IdContrarec)
                .HasConstraintName("FK_tb_com_contra_deta_tb_com_contrarec");
        });

        modelBuilder.Entity<TbComContrarec>(entity =>
        {
            entity.HasKey(e => e.IdContrarec);

            entity.ToTable("tb_com_contrarec");

            entity.Property(e => e.IdContrarec).HasColumnName("id_contrarec");
            entity.Property(e => e.Batch)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("batch");
            entity.Property(e => e.CantPagada).HasColumnName("cant_pagada");
            entity.Property(e => e.CodCancelacion)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cod_cancelacion");
            entity.Property(e => e.DiasCredito)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dias_credito");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaMod)
                .HasColumnType("datetime")
                .HasColumnName("fecha_mod");
            entity.Property(e => e.FechaPago)
                .HasColumnType("datetime")
                .HasColumnName("fecha_pago");
            entity.Property(e => e.FechaRcontra)
                .HasColumnType("datetime")
                .HasColumnName("fecha_rcontra");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .HasColumnName("moneda");
            entity.Property(e => e.NotaMod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nota_mod");
            entity.Property(e => e.Observaciones)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Pago).HasColumnName("pago");
            entity.Property(e => e.Pbatch).HasColumnName("pbatch");
            entity.Property(e => e.Pfacturada).HasColumnName("pfacturada");
            entity.Property(e => e.Pproceso).HasColumnName("pproceso");
            entity.Property(e => e.TotalFacturas).HasColumnName("total_facturas");
            entity.Property(e => e.UserMod).HasColumnName("user_mod");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbComContrarecs)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_com_contrarec_tb_empresa");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.TbComContrarecs)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_com_contrarec_tb_proveedor");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbComContrarecs)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_com_contrarec_tb_user");
        });

        modelBuilder.Entity<TbCompInterno>(entity =>
        {
            entity.HasKey(e => e.IdDetalleComInternos).HasName("PK__tb_comp___E0F3FCBAC5C202CB");

            entity.ToTable("tb_comp_internos");

            entity.Property(e => e.IdDetalleComInternos).HasColumnName("id_detalle_com_internos");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.DescArticulo)
                .IsUnicode(false)
                .HasColumnName("desc_articulo");
            entity.Property(e => e.FechaRec)
                .HasColumnType("datetime")
                .HasColumnName("fecha_rec");
            entity.Property(e => e.IdDetaRfq).HasColumnName("id_deta_rfq");
            entity.Property(e => e.IdOcInternos).HasColumnName("id_oc_internos");
            entity.Property(e => e.IdProyCt)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("id_proy_ct");
            entity.Property(e => e.NoParte)
                .HasMaxLength(60)
                .HasColumnName("no_parte");
            entity.Property(e => e.Pda).HasColumnName("pda");
            entity.Property(e => e.PoItemEstatus).HasColumnName("po_item_estatus");
            entity.Property(e => e.PoItemQtyrecived).HasColumnName("po_item_qtyrecived");
            entity.Property(e => e.PomNumberInt)
                .HasMaxLength(15)
                .HasColumnName("pom_number_int");
            entity.Property(e => e.PrecioUnitario).HasColumnName("precio_unitario");
            entity.Property(e => e.RevItem)
                .HasMaxLength(10)
                .HasColumnName("rev_item");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("unidad_medida");
        });

        modelBuilder.Entity<TbCompra>(entity =>
        {
            entity.HasKey(e => e.IdDetalleCompra);

            entity.ToTable("tb_compras");

            entity.Property(e => e.IdDetalleCompra).HasColumnName("id_detalle_compra");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.DescArticulo)
                .IsUnicode(false)
                .HasColumnName("desc_articulo");
            entity.Property(e => e.FechaRec)
                .HasColumnType("datetime")
                .HasColumnName("fecha_rec");
            entity.Property(e => e.IdDetaRfq).HasColumnName("id_deta_rfq");
            entity.Property(e => e.IdEntrega)
                .HasMaxLength(15)
                .HasColumnName("id_entrega");
            entity.Property(e => e.IdOrdenCompra).HasColumnName("id_orden_compra");
            entity.Property(e => e.IdProyCt)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("id_proy_ct");
            entity.Property(e => e.NoParte)
                .HasMaxLength(60)
                .HasColumnName("no_parte");
            entity.Property(e => e.NotaRfq)
                .HasMaxLength(700)
                .HasColumnName("nota_rfq");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(350)
                .HasColumnName("observaciones");
            entity.Property(e => e.Pda).HasColumnName("pda");
            entity.Property(e => e.PoItemEstatus)
                .HasDefaultValue(false, "DF_tb_compras_po_item_estatus")
                .HasColumnName("po_item_estatus");
            entity.Property(e => e.PoItemQtyrecived)
                .HasDefaultValue(0.0, "DF_tb_compras_po_item_qtyrecived")
                .HasColumnName("po_item_qtyrecived");
            entity.Property(e => e.PomNumber)
                .HasMaxLength(15)
                .HasColumnName("pom_number");
            entity.Property(e => e.PrecioUnitario).HasColumnName("precio_unitario");
            entity.Property(e => e.RevItem)
                .HasMaxLength(10)
                .HasColumnName("rev_item");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("unidad_medida");

            entity.HasOne(d => d.IdOrdenCompraNavigation).WithMany(p => p.TbCompras)
                .HasForeignKey(d => d.IdOrdenCompra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_compras_tb_orden_compra");

            entity.HasOne(d => d.UnidadMedidaNavigation).WithMany(p => p.TbCompras)
                .HasForeignKey(d => d.UnidadMedida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_compras_tb_um");
        });

        modelBuilder.Entity<TbComprasTemp>(entity =>
        {
            entity.HasKey(e => e.IdRecepcionCompra);

            entity.ToTable("tb_compras_temp");

            entity.Property(e => e.IdRecepcionCompra).HasColumnName("id_recepcion_compra");
            entity.Property(e => e.CantidadRecibida).HasColumnName("cantidad_recibida");
            entity.Property(e => e.DescArticulo)
                .IsUnicode(false)
                .HasColumnName("desc_articulo");
            entity.Property(e => e.FechaRecepcion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_recepcion");
            entity.Property(e => e.IdDetalleCompra).HasColumnName("id_detalle_compra");
            entity.Property(e => e.IdOrdenCompra).HasColumnName("id_orden_compra");
            entity.Property(e => e.NoParte)
                .HasMaxLength(60)
                .HasColumnName("no_parte");
            entity.Property(e => e.Pda).HasColumnName("pda");
            entity.Property(e => e.PomNumber)
                .HasMaxLength(15)
                .HasColumnName("pom_number");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("unidad_medida");
        });

        modelBuilder.Entity<TbCostoVentaJob>(entity =>
        {
            entity.HasKey(e => e.IdCostoVenta).HasName("PK_id_costo_venta");

            entity.ToTable("tb_costo_venta_job");

            entity.Property(e => e.IdCostoVenta)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_costo_venta])")
                .HasColumnName("id_costo_venta");
            entity.Property(e => e.Costo).HasColumnName("costo");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_proyecto");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
        });

        modelBuilder.Entity<TbCotizacion>(entity =>
        {
            entity.HasKey(e => e.IdCotizacion).HasName("PK_id_cotizacion");

            entity.ToTable("tb_cotizacion");

            entity.Property(e => e.IdCotizacion)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_cotizacion])", "DF__tb_cotiza__id_co__0F03239C")
                .HasColumnName("id_cotizacion");
            entity.Property(e => e.Cotizacion)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("cotizacion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaAutorizacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_autorizacion");
            entity.Property(e => e.FechaEnvio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_envio");
            entity.Property(e => e.FechaObjetivo)
                .HasColumnType("datetime")
                .HasColumnName("fecha_objetivo");
            entity.Property(e => e.FechaPo)
                .HasColumnType("datetime")
                .HasColumnName("fecha_po");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.HorasDiseñoElectrico).HasColumnName("horas_diseño_electrico");
            entity.Property(e => e.HorasDiseñoMecanico).HasColumnName("horas_diseño_mecanico");
            entity.Property(e => e.HorasEnsambleProgramacion).HasColumnName("horas_ensamble_programacion");
            entity.Property(e => e.HorasOtro).HasColumnName("horas_otro");
            entity.Property(e => e.HorasProgramacion)
                .HasMaxLength(5)
                .HasColumnName("horas_programacion");
            entity.Property(e => e.IdAutoriza).HasColumnName("id_autoriza");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdResponsable).HasColumnName("id_responsable");
            entity.Property(e => e.IdSupervisor).HasColumnName("id_supervisor");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Lenguaje)
                .HasMaxLength(5)
                .HasColumnName("lenguaje");
            entity.Property(e => e.MontoTotal).HasColumnName("monto_total");
            entity.Property(e => e.NomProyecto)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("nom_proyecto");
            entity.Property(e => e.Notas)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("notas");
            entity.Property(e => e.NumeroTrabajo)
                .HasMaxLength(20)
                .HasColumnName("numero_trabajo");
            entity.Property(e => e.OcCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("oc_cliente");
            entity.Property(e => e.PresupuestoComponentesEspeciales).HasColumnName("presupuesto_componentes_especiales");
            entity.Property(e => e.PresupuestoElectrico).HasColumnName("presupuesto_electrico");
            entity.Property(e => e.PresupuestoMaquinados).HasColumnName("presupuesto_maquinados");
            entity.Property(e => e.PresupuestoPLineaMecanica).HasColumnName("presupuesto_p_linea_mecanica");
            entity.Property(e => e.ProbabilidadCierre)
                .HasMaxLength(20)
                .HasColumnName("probabilidad_cierre");
            entity.Property(e => e.ProximaComunicacion)
                .HasColumnType("datetime")
                .HasColumnName("proxima_comunicacion");
            entity.Property(e => e.Relevancia)
                .HasMaxLength(20)
                .HasColumnName("relevancia");
            entity.Property(e => e.Revision)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("revision");
            entity.Property(e => e.SemanasPropuestas).HasColumnName("semanas_propuestas");
            entity.Property(e => e.TipoCotizacion)
                .HasMaxLength(10)
                .HasColumnName("tipo_cotizacion");
            entity.Property(e => e.TipoProyecto)
                .HasMaxLength(10)
                .HasColumnName("tipo_proyecto");
            entity.Property(e => e.UltimaComunicacion)
                .HasColumnType("datetime")
                .HasColumnName("ultima_comunicacion");
            entity.Property(e => e.UrlCotizacion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("url_cotizacion");
            entity.Property(e => e.UrlPo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("url_po");
        });

        modelBuilder.Entity<TbCotizacionLog>(entity =>
        {
            entity.HasKey(e => e.IdCotizacionLog).HasName("PK_id_cotizacion_log");

            entity.ToTable("tb_cotizacion_log");

            entity.Property(e => e.IdCotizacionLog)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_cotizacion_log])")
                .HasColumnName("id_cotizacion_log");
            entity.Property(e => e.Descrip)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("descrip");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdCotizacion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_cotizacion");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
        });

        modelBuilder.Entity<TbDepartamento>(entity =>
        {
            entity.HasKey(e => e.IdDepartamento);

            entity.ToTable("tb_departamentos");

            entity.Property(e => e.IdDepartamento)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_departamentos])")
                .HasColumnName("id_departamento");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.IdLiderDepartamento).HasColumnName("id_lider_departamento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TbDetaDevolucion>(entity =>
        {
            entity.HasKey(e => e.IdDetaDevolucion).HasName("PK__tb_deta___A1B6373FADF94F68");

            entity.ToTable("tb_deta_devolucion");

            entity.Property(e => e.IdDetaDevolucion).HasColumnName("id_deta_devolucion");
            entity.Property(e => e.CambioPrecio).HasColumnName("cambio_precio");
            entity.Property(e => e.CantDevuelta).HasColumnName("cant_devuelta");
            entity.Property(e => e.FFolioDev)
                .HasColumnType("datetime")
                .HasColumnName("f_folio_dev");
            entity.Property(e => e.FolioDetaDev)
                .HasMaxLength(15)
                .HasColumnName("folio_deta_dev");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .HasColumnName("moneda");
            entity.Property(e => e.NParte)
                .HasMaxLength(60)
                .HasColumnName("n_parte");
            entity.Property(e => e.OCompra)
                .HasMaxLength(15)
                .HasColumnName("o_compra");
            entity.Property(e => e.PrecioU).HasColumnName("precio_u");
        });

        modelBuilder.Entity<TbDevolucionOCambio>(entity =>
        {
            entity.HasKey(e => e.IdDevolucionOCambio).HasName("PK_devolucion_o_cambio");

            entity.ToTable("tb_devolucion_o_cambio");

            entity.Property(e => e.IdDevolucionOCambio)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_devolucion_o_cambio])")
                .HasColumnName("id_devolucion_o_cambio");
            entity.Property(e => e.Articulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("articulo");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.EsDevolucionOCambio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("es_devolucion_o_cambio");
            entity.Property(e => e.IdDetalleCompra).HasColumnName("id_detalle_compra");
            entity.Property(e => e.IdUbicacion).HasColumnName("id_ubicacion");
            entity.Property(e => e.IdUserSolicita).HasColumnName("id_user_solicita");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("moneda");
            entity.Property(e => e.NumParte)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("num_parte");
            entity.Property(e => e.PrecioUnitario).HasColumnName("precio_unitario");
            entity.Property(e => e.TipoUbicacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo_ubicacion");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("unidad_medida");
        });

        modelBuilder.Entity<TbEmpDir>(entity =>
        {
            entity.HasKey(e => e.IdDir);

            entity.ToTable("tb_emp_dir");

            entity.Property(e => e.IdDir)
                .HasMaxLength(15)
                .HasColumnName("id_dir");
            entity.Property(e => e.DescDireccion)
                .HasMaxLength(350)
                .HasColumnName("desc_direccion");
            entity.Property(e => e.EstatusDir).HasColumnName("estatus_dir");
            entity.Property(e => e.Nota)
                .HasMaxLength(50)
                .HasColumnName("nota");
        });

        modelBuilder.Entity<TbEmpleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado);

            entity.ToTable("tb_empleados");

            entity.Property(e => e.IdEmpleado)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_empleados])")
                .HasColumnName("id_empleado");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido_materno");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido_paterno");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.Clabe)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("clabe");
            entity.Property(e => e.CodigoPostal).HasColumnName("codigo_postal");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo_electronico");
            entity.Property(e => e.CuentaBancaria)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cuenta_bancaria");
            entity.Property(e => e.Curp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("curp");
            entity.Property(e => e.Direccion1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("direccion_1");
            entity.Property(e => e.Direccion2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("direccion_2");
            entity.Property(e => e.EsPeriodoPrueba)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("es_periodo_prueba");
            entity.Property(e => e.EstadoProvinciaRegion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("estado_provincia_region");
            entity.Property(e => e.FechaAltaImss)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta_imss");
            entity.Property(e => e.FechaInicioContrato)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio_contrato");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_nacimiento");
            entity.Property(e => e.Genero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("genero");
            entity.Property(e => e.IdCargo).HasColumnName("id_cargo");
            entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEntidadBancaria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_entidad_bancaria");
            entity.Property(e => e.IdIdentificadorEmpresa).HasColumnName("id_identificador_empresa");
            entity.Property(e => e.IdNivel).HasColumnName("id_nivel");
            entity.Property(e => e.IdReportaA).HasColumnName("id_reporta_a");
            entity.Property(e => e.IdSupervisorAusencias).HasColumnName("id_supervisor_ausencias");
            entity.Property(e => e.IdTipoPago).HasColumnName("id_tipo_pago");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Nacionalidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nacionalidad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreContactoEmergencia)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("nombre_contacto_emergencia");
            entity.Property(e => e.NumeroCuenta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_cuenta");
            entity.Property(e => e.NumeroImss)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numero_imss");
            entity.Property(e => e.Pais)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("pais");
            entity.Property(e => e.Rfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Sueldo).HasColumnName("sueldo");
            entity.Property(e => e.SwiftBic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("swift_bic");
            entity.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.TelefonoContactoEmergencia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telefono_contacto_emergencia");
            entity.Property(e => e.TokenEmpleado)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("token_empleado");
        });

        modelBuilder.Entity<TbEmpresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa);

            entity.ToTable("tb_empresa");

            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.Acma)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("acma");
            entity.Property(e => e.Comfis)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("comfis");
            entity.Property(e => e.DescEmpresa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("desc_empresa");
            entity.Property(e => e.Direccion)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.Imagen)
                .HasColumnType("image")
                .HasColumnName("imagen");
            entity.Property(e => e.MailCompras)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail_compras");
            entity.Property(e => e.MailComtacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail_comtacto");
            entity.Property(e => e.MailCxp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail_cxp");
            entity.Property(e => e.MailSistema)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("mail_sistema");
            entity.Property(e => e.MailVentas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail_ventas");
            entity.Property(e => e.NomEmpresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nom_empresa");
            entity.Property(e => e.Nota)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("nota");
            entity.Property(e => e.PagWeb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pag_web");
            entity.Property(e => e.Rfc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Tarjeta)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("tarjeta");
            entity.Property(e => e.TelEmp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tel_emp");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.User01)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("user_01");
            entity.Property(e => e.User02)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("user_02");
        });

        modelBuilder.Entity<TbEmpresaCliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_empresa_clientes");

            entity.ToTable("tb_empresa_clientes");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(NEXT VALUE FOR [empresa_cliente_id])", "DF__tb_empresa_c__id__371114F6")
                .HasColumnName("id");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Empresa)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("empresa");
        });

        modelBuilder.Entity<TbEqEstatus>(entity =>
        {
            entity.HasKey(e => e.IdEstado);

            entity.ToTable("tb_eq_estatus");

            entity.Property(e => e.IdEstado)
                .HasMaxLength(50)
                .HasColumnName("id_estado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.NomEstado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_estado");
            entity.Property(e => e.NotaEstado0)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("nota_estado0");
            entity.Property(e => e.Orden).HasColumnName("orden");
        });

        modelBuilder.Entity<TbEstEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_est_email");

            entity.Property(e => e.FechaRealizo)
                .HasColumnType("datetime")
                .HasColumnName("fecha_realizo");
            entity.Property(e => e.IdDepto).HasColumnName("id_depto");
            entity.Property(e => e.IdOrdenCompra).HasColumnName("id_orden_compra");
            entity.Property(e => e.IdRealizo).HasColumnName("id_realizo");
            entity.Property(e => e.IdSolicito).HasColumnName("id_solicito");
        });

        modelBuilder.Entity<TbEstatusEquipo>(entity =>
        {
            entity.HasKey(e => e.IdEstatus);

            entity.ToTable("tb_estatus_equipo");

            entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");
            entity.Property(e => e.NombreEstatus)
                .HasMaxLength(50)
                .HasColumnName("nombre_estatus");
        });

        modelBuilder.Entity<TbFechasProyecto>(entity =>
        {
            entity.HasKey(e => e.IdFechaProyecto).HasName("PK_id_fecha_proyecto");

            entity.ToTable("tb_fechas_proyectos");

            entity.Property(e => e.IdFechaProyecto)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_fechas_proyectos])")
                .HasColumnName("id_fecha_proyecto");
            entity.Property(e => e.Color)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaFin)
                .HasColumnType("datetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_proyecto");
            entity.Property(e => e.Porcentaje).HasColumnName("porcentaje");
        });

        modelBuilder.Entity<TbFolioRecep>(entity =>
        {
            entity.HasKey(e => e.IdFolioRecep).HasName("PK__tb_folio__32742C432795C98A");

            entity.ToTable("tb_folio_recep");

            entity.Property(e => e.IdFolioRecep).HasColumnName("id_folio_recep");
            entity.Property(e => e.CantRecibida).HasColumnName("cant_recibida");
            entity.Property(e => e.FFolioRecep)
                .HasColumnType("datetime")
                .HasColumnName("f_folio_recep");
            entity.Property(e => e.FolioRecep)
                .HasMaxLength(15)
                .HasColumnName("folio_recep");
            entity.Property(e => e.IdProyCt)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_proy_ct");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.NParte)
                .HasMaxLength(60)
                .HasColumnName("n_parte");
            entity.Property(e => e.OCompra)
                .HasMaxLength(15)
                .HasColumnName("o_compra");
        });

        modelBuilder.Entity<TbFoliosAlmCal>(entity =>
        {
            entity.HasKey(e => e.IdFolioAlmCal).HasName("PK__tb_folio__1D98EF85DC4648C9");

            entity.ToTable("tb_folios_alm_cal");

            entity.Property(e => e.IdFolioAlmCal).HasColumnName("id_folio_alm_cal");
            entity.Property(e => e.Depa)
                .HasMaxLength(15)
                .HasColumnName("depa");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.FCreacion)
                .HasColumnType("datetime")
                .HasColumnName("f_creacion");
            entity.Property(e => e.FolioAlmCal)
                .HasMaxLength(15)
                .HasColumnName("folio_alm_cal");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.OrdenCom)
                .HasMaxLength(15)
                .HasColumnName("orden_com");
        });

        modelBuilder.Entity<TbFoliosDesperdicio>(entity =>
        {
            entity.HasKey(e => e.IdDesperdicioMaq).HasName("PK__tb_folio__B1CF2227B31F484A");

            entity.ToTable("tb_folios_desperdicio");

            entity.Property(e => e.IdDesperdicioMaq).HasColumnName("id_desperdicio_maq");
            entity.Property(e => e.CostoInicial).HasColumnName("costo_inicial");
            entity.Property(e => e.Disponibilidad).HasColumnName("disponibilidad");
            entity.Property(e => e.FDesperdicio)
                .HasColumnType("datetime")
                .HasColumnName("f_desperdicio");
            entity.Property(e => e.FolioDesperdicio)
                .HasMaxLength(15)
                .HasColumnName("folio_desperdicio");
            entity.Property(e => e.IdMaquinado).HasColumnName("id_maquinado");
            entity.Property(e => e.IdMaterial)
                .HasMaxLength(10)
                .HasColumnName("id_material");
            entity.Property(e => e.KgDesperdicio)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("kg_desperdicio");
            entity.Property(e => e.Medidas)
                .HasMaxLength(50)
                .HasColumnName("medidas");
            entity.Property(e => e.Motivo)
                .IsUnicode(false)
                .HasColumnName("motivo");
            entity.Property(e => e.NOperaciones).HasColumnName("n_operaciones");
            entity.Property(e => e.NParte)
                .HasMaxLength(60)
                .HasColumnName("n_parte");
            entity.Property(e => e.PrecioDesp)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("precio_desp");
            entity.Property(e => e.Proyecto)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("proyecto");
            entity.Property(e => e.Reutilizable).HasColumnName("reutilizable");
            entity.Property(e => e.TipoDes).HasColumnName("tipo_des");
            entity.Property(e => e.Usuario).HasColumnName("usuario");
        });

        modelBuilder.Entity<TbFoliosDevolucion>(entity =>
        {
            entity.HasKey(e => e.IdFolioDevolucion).HasName("PK__tb_folio__A0128AB1CDB5BF50");

            entity.ToTable("tb_folios_devolucion");

            entity.Property(e => e.IdFolioDevolucion).HasColumnName("id_folio_devolucion");
            entity.Property(e => e.Depa)
                .HasMaxLength(15)
                .HasColumnName("depa");
            entity.Property(e => e.FCreacion)
                .HasColumnType("datetime")
                .HasColumnName("f_creacion");
            entity.Property(e => e.FolioDevolucion)
                .HasMaxLength(15)
                .HasColumnName("folio_devolucion");
            entity.Property(e => e.Proyecto)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("proyecto");
            entity.Property(e => e.UserEntrega).HasColumnName("user_entrega");
            entity.Property(e => e.UserRecibe).HasColumnName("user_recibe");
        });

        modelBuilder.Entity<TbHorasExtra>(entity =>
        {
            entity.HasKey(e => e.IdHorasExtras);

            entity.ToTable("tb_horas_extras");

            entity.Property(e => e.IdHorasExtras)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_horas_extras])")
                .HasColumnName("id_horas_extras");
            entity.Property(e => e.Autorizacion).HasColumnName("autorizacion");
            entity.Property(e => e.CantidadHoras).HasColumnName("cantidad_horas");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaHorasExtras).HasColumnName("fecha_horas_extras");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        });

        modelBuilder.Entity<TbInfoPc>(entity =>
        {
            entity.HasKey(e => e.NSerie);

            entity.ToTable("tb_info_pc");

            entity.Property(e => e.NSerie)
                .HasMaxLength(70)
                .HasColumnName("n_serie");
            entity.Property(e => e.Arquitectura)
                .HasMaxLength(70)
                .HasColumnName("arquitectura");
            entity.Property(e => e.CapAlmacenamiento)
                .HasMaxLength(200)
                .HasColumnName("cap_almacenamiento");
            entity.Property(e => e.Encargado)
                .HasMaxLength(100)
                .HasColumnName("encargado");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.EtqReport)
                .HasMaxLength(50)
                .HasColumnName("etq_report");
            entity.Property(e => e.FabricanteBios)
                .HasMaxLength(70)
                .HasColumnName("fabricante_bios");
            entity.Property(e => e.FabricantePb)
                .HasMaxLength(70)
                .HasColumnName("fabricante_pb");
            entity.Property(e => e.FabricanteProc)
                .HasMaxLength(70)
                .HasColumnName("fabricante_proc");
            entity.Property(e => e.FechaActualizacion).HasColumnName("fecha_actualizacion");
            entity.Property(e => e.FechaBios)
                .HasMaxLength(70)
                .HasColumnName("fecha_bios");
            entity.Property(e => e.FechaCompra).HasColumnName("fecha_compra");
            entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");
            entity.Property(e => e.Hostname)
                .HasMaxLength(70)
                .HasColumnName("hostname");
            entity.Property(e => e.IdArea).HasColumnName("id_area");
            entity.Property(e => e.IdProductoPb)
                .HasMaxLength(70)
                .HasColumnName("id_producto_pb");
            entity.Property(e => e.IdTipocustodia).HasColumnName("id_tipocustodia");
            entity.Property(e => e.IdUbicacion).HasColumnName("id_ubicacion");
            entity.Property(e => e.ImpTicket)
                .HasMaxLength(50)
                .HasColumnName("imp_ticket");
            entity.Property(e => e.LastConection)
                .HasColumnType("datetime")
                .HasColumnName("last_conection");
            entity.Property(e => e.MRam)
                .HasMaxLength(70)
                .HasColumnName("m_ram");
            entity.Property(e => e.Modelo)
                .HasMaxLength(70)
                .HasColumnName("modelo");
            entity.Property(e => e.Monitor).HasColumnName("monitor");
            entity.Property(e => e.Mouse).HasColumnName("mouse");
            entity.Property(e => e.NSeriebios)
                .HasMaxLength(70)
                .HasColumnName("n_seriebios");
            entity.Property(e => e.Nobreak).HasColumnName("nobreak");
            entity.Property(e => e.NombreProc)
                .HasMaxLength(100)
                .HasColumnName("nombre_proc");
            entity.Property(e => e.NumMonitores).HasColumnName("num_monitores");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(200)
                .HasColumnName("observaciones");
            entity.Property(e => e.SistemaO)
                .HasMaxLength(70)
                .HasColumnName("sistema_O");
            entity.Property(e => e.TVideo)
                .HasMaxLength(300)
                .HasColumnName("t_video");
            entity.Property(e => e.Tag)
                .HasMaxLength(50)
                .HasColumnName("tag");
            entity.Property(e => e.Teclado).HasColumnName("teclado");
            entity.Property(e => e.TiempoVida).HasColumnName("tiempo_vida");
            entity.Property(e => e.TipoPc)
                .HasMaxLength(70)
                .HasColumnName("tipo_pc");
            entity.Property(e => e.UserSysqb)
                .HasMaxLength(50)
                .HasColumnName("user_sysqb");
            entity.Property(e => e.VelProc)
                .HasMaxLength(70)
                .HasColumnName("vel_proc");
            entity.Property(e => e.VerBios)
                .HasMaxLength(70)
                .HasColumnName("ver_bios");
            entity.Property(e => e.VerSo)
                .HasMaxLength(70)
                .HasColumnName("ver_so");
            entity.Property(e => e.VersionSysqb)
                .HasMaxLength(50)
                .HasColumnName("version_sysqb");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.TbInfoPcs)
                .HasForeignKey(d => d.Estatus)
                .HasConstraintName("FK_tb_info_pc_tb_estatus_equipo");

            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.TbInfoPcs)
                .HasForeignKey(d => d.IdArea)
                .HasConstraintName("FK_tb_info_pc_tb_area");

            entity.HasOne(d => d.IdTipocustodiaNavigation).WithMany(p => p.TbInfoPcs)
                .HasForeignKey(d => d.IdTipocustodia)
                .HasConstraintName("FK_tb_info_pc_tb_tipocustodia");

            entity.HasOne(d => d.IdUbicacionNavigation).WithMany(p => p.TbInfoPcs)
                .HasForeignKey(d => d.IdUbicacion)
                .HasConstraintName("FK_tb_info_pc_tb_ubi_equipos");
        });

        modelBuilder.Entity<TbIngenierium>(entity =>
        {
            entity.HasKey(e => e.IdInge).HasName("PK__tb_ingen__8674137707110D0F");

            entity.ToTable("tb_ingenieria");

            entity.Property(e => e.IdInge).HasColumnName("id_inge");
            entity.Property(e => e.DiagGerarquia).HasColumnName("diag_gerarquia");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Job)
                .HasMaxLength(15)
                .HasColumnName("job");
            entity.Property(e => e.NParte)
                .HasMaxLength(60)
                .HasColumnName("n_parte");
            entity.Property(e => e.TipoDiag)
                .HasMaxLength(15)
                .HasColumnName("tipo_diag");

            entity.HasOne(d => d.TipoDiagNavigation).WithMany(p => p.TbIngenieria)
                .HasForeignKey(d => d.TipoDiag)
                .HasConstraintName("FK_tb_ingenieria_tb_tipo_diagrama");
        });

        modelBuilder.Entity<TbInvAlmacenRack>(entity =>
        {
            entity.HasKey(e => e.IdRack);

            entity.ToTable("tb_inv_almacen_rack");

            entity.Property(e => e.IdRack)
                .HasMaxLength(50)
                .HasColumnName("id_rack");
            entity.Property(e => e.Columna).HasColumnName("columna");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsFixedLength()
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdAlmacen)
                .HasMaxLength(10)
                .HasColumnName("id_almacen");
            entity.Property(e => e.Nivel).HasColumnName("nivel");
            entity.Property(e => e.Nombre)
                .HasMaxLength(85)
                .IsFixedLength()
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdAlmacenNavigation).WithMany(p => p.TbInvAlmacenRacks)
                .HasForeignKey(d => d.IdAlmacen)
                .HasConstraintName("FK_tb_inv_almacen_rack_tb_proy_almacen");
        });

        modelBuilder.Entity<TbInvProPiso>(entity =>
        {
            entity.HasKey(e => e.IdProPiso);

            entity.ToTable("tb_inv_pro_piso");

            entity.Property(e => e.IdProPiso).HasColumnName("id_pro_piso");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.CantidadDisponible).HasColumnName("cantidad_disponible");
            entity.Property(e => e.CantidadRecibida).HasColumnName("cantidad_recibida");
            entity.Property(e => e.Cliente).HasColumnName("cliente");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdAutorizaAutCam).HasColumnName("id_autoriza_aut_cam");
            entity.Property(e => e.IdDestino).HasColumnName("id_destino");
            entity.Property(e => e.IdDetalleCompra)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_detalle_compra");
            entity.Property(e => e.IdDevolucionOCambio).HasColumnName("id_devolucion_o_cambio");
            entity.Property(e => e.IdEstatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id_estatus");
            entity.Property(e => e.IdOrigen).HasColumnName("id_origen");
            entity.Property(e => e.IdRegEntrada).HasColumnName("id_reg_entrada");
            entity.Property(e => e.IdSolicitaDevolucionOCambio).HasColumnName("id_solicita_devolucion_o_cambio");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("moneda");
            entity.Property(e => e.NomArticulo)
                .IsUnicode(false)
                .HasColumnName("nom_articulo");
            entity.Property(e => e.NumParte)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("num_parte");
            entity.Property(e => e.Observacion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.PrecioUnitario).HasColumnName("precio_unitario");
            entity.Property(e => e.Tipo)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("unidad_medida");
        });

        modelBuilder.Entity<TbMachDiv>(entity =>
        {
            entity.HasKey(e => e.IdDiv);

            entity.ToTable("tb_mach_div");

            entity.Property(e => e.IdDiv)
                .HasMaxLength(5)
                .HasColumnName("id_div");
            entity.Property(e => e.DescDiv)
                .HasMaxLength(50)
                .HasColumnName("desc_div");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .HasColumnName("nombre");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TbMachine>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_machine");

            entity.Property(e => e.Detail)
                .HasMaxLength(100)
                .HasColumnName("detail");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdProyect)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("id_proyect");
            entity.Property(e => e.IdSector)
                .HasMaxLength(5)
                .HasColumnName("id_sector");
            entity.Property(e => e.NumSerie)
                .HasMaxLength(50)
                .HasColumnName("num_serie");
            entity.Property(e => e.Title)
                .HasMaxLength(500)
                .HasColumnName("title");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TbMachinesProject>(entity =>
        {
            entity.HasKey(e => e.IdMachine).HasName("PK__tb_machi__3C2F89144771161F");

            entity.ToTable("tb_machines_projects");

            entity.Property(e => e.IdMachine).HasColumnName("id_machine");
            entity.Property(e => e.Assembler).HasColumnName("assembler");
            entity.Property(e => e.Developer).HasColumnName("developer");
            entity.Property(e => e.ElectricalBudget).HasColumnName("electrical_budget");
            entity.Property(e => e.ElectricalDesigner).HasColumnName("electrical_designer");
            entity.Property(e => e.HoursAsemblyDevelopment).HasColumnName("hours_asembly_development");
            entity.Property(e => e.HoursDevelopment).HasColumnName("hours_development");
            entity.Property(e => e.HoursElectricalDesign).HasColumnName("hours_electrical_design");
            entity.Property(e => e.HoursMechanicalDesign).HasColumnName("hours_mechanical_design");
            entity.Property(e => e.HoursOther).HasColumnName("hours_other");
            entity.Property(e => e.IdProject)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("id_project");
            entity.Property(e => e.InitialBudget).HasColumnName("initial_budget");
            entity.Property(e => e.MachiningBudget).HasColumnName("machining_budget");
            entity.Property(e => e.MechanicalBudget).HasColumnName("mechanical_budget");
            entity.Property(e => e.MechanicalDesigner).HasColumnName("mechanical_designer");
            entity.Property(e => e.NumSerie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("num_serie");
            entity.Property(e => e.OtherBudget).HasColumnName("other_budget");
            entity.Property(e => e.ProjectManager).HasColumnName("project_manager");

            entity.HasOne(d => d.IdProjectNavigation).WithMany(p => p.TbMachinesProjects)
                .HasForeignKey(d => d.IdProject)
                .HasConstraintName("FK_machine_proyect");
        });

        modelBuilder.Entity<TbMaquinadosCalidad>(entity =>
        {
            entity.HasKey(e => e.IdMaquinadoCalida).HasName("PK_id_maquinado_calida");

            entity.ToTable("tb_maquinados_calidad");

            entity.Property(e => e.IdMaquinadoCalida)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_maquinado_calida])", "DF__tb_maquin__id_ma__25E688F4")
                .HasColumnName("id_maquinado_calida");
            entity.Property(e => e.Acabado)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("acabado");
            entity.Property(e => e.CantPendienteRec).HasColumnName("cant_pendiente_rec");
            entity.Property(e => e.CantRechazada).HasColumnName("cant_rechazada");
            entity.Property(e => e.CantRecibida).HasColumnName("cant_recibida");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Estatus)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.EstatusRechazo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estatus_rechazo");
            entity.Property(e => e.FechaRechazo)
                .HasColumnType("datetime")
                .HasColumnName("fecha_rechazo");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.FolioSalida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("folio_salida");
            entity.Property(e => e.IdDetaRfq).HasColumnName("id_deta_rfq");
            entity.Property(e => e.IdMaquinadoRechazo).HasColumnName("id_maquinado_rechazo");
            entity.Property(e => e.IdOrdenCompra).HasColumnName("id_orden_compra");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_proyecto");
            entity.Property(e => e.Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mecanizado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mecanizado");
            entity.Property(e => e.MotivoRechazo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("motivo_rechazo");
            entity.Property(e => e.NumParte)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("num_parte");
            entity.Property(e => e.NumSalida).HasColumnName("num_salida");
            entity.Property(e => e.PesoTeorico).HasColumnName("peso_teorico");
            entity.Property(e => e.RazonSinProceso)
                .HasMaxLength(100)
                .HasColumnName("razon_sin_proceso");
            entity.Property(e => e.Revision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("revision");
            entity.Property(e => e.Spare)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TipoMaquinado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tipo_maquinado");
        });

        modelBuilder.Entity<TbMarca>(entity =>
        {
            entity.HasKey(e => e.IdMarca);

            entity.ToTable("tb_marca");

            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.DivTipo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("div_tipo");
            entity.Property(e => e.NomMarca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_marca");
            entity.Property(e => e.ObserMarca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("obser_marca");
        });

        modelBuilder.Entity<TbMatReqDetum>(entity =>
        {
            entity.HasKey(e => e.IdDetaReq).HasName("PK_tb_ref_req_deta");

            entity.ToTable("tb_mat_req_deta");

            entity.Property(e => e.IdDetaReq).HasColumnName("id_deta_req");
            entity.Property(e => e.CantEntregada).HasColumnName("cant_entregada");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.DescArticulo)
                .IsUnicode(false)
                .HasColumnName("desc_articulo");
            entity.Property(e => e.EsPiso).HasColumnName("es_piso");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.IdAcabado).HasColumnName("id_acabado");
            entity.Property(e => e.IdEstatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id_estatus");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_proyecto");
            entity.Property(e => e.IdReq).HasColumnName("id_req");
            entity.Property(e => e.IdTratamiento).HasColumnName("id_tratamiento");
            entity.Property(e => e.IdUbicacionAlmacen).HasColumnName("id_ubicacion_almacen");
            entity.Property(e => e.IdYat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id_yat");
            entity.Property(e => e.Medidas).HasMaxLength(60);
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("moneda");
            entity.Property(e => e.NoParte)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("no_parte");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Pda).HasColumnName("pda");
            entity.Property(e => e.PesoTotal).HasColumnName("peso_total");
            entity.Property(e => e.PrecioUnitario).HasColumnName("precio_unitario");
            entity.Property(e => e.UnidadM)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("unidad_m");
        });

        modelBuilder.Entity<TbNivel>(entity =>
        {
            entity.HasKey(e => e.IdNivel);

            entity.ToTable("tb_nivel");

            entity.Property(e => e.IdNivel)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_nivel])")
                .HasColumnName("id_nivel");
            entity.Property(e => e.IdCargo).HasColumnName("id_cargo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TbOcCentrado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_oc_centrado");

            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdConcentrado)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id_concentrado");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .HasColumnName("observaciones");
            entity.Property(e => e.TotFact).HasColumnName("tot_fact");
        });

        modelBuilder.Entity<TbOcCotizacion>(entity =>
        {
            entity.HasKey(e => e.IdOcCotizacion).HasName("PK_id_oc_cotizacion");

            entity.ToTable("tb_oc_cotizacion");

            entity.Property(e => e.IdOcCotizacion)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_oc_cotizacion])")
                .HasColumnName("id_oc_cotizacion");
            entity.Property(e => e.FechaPo).HasColumnName("fecha_po");
            entity.Property(e => e.IdCotizacion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_cotizacion");
            entity.Property(e => e.NombreArchivoPo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_archivo_po");
            entity.Property(e => e.NumOc).HasColumnName("num_oc");
            entity.Property(e => e.PoCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("po_cliente");
        });

        modelBuilder.Entity<TbOcInterno>(entity =>
        {
            entity.HasKey(e => e.IdOcInternos).HasName("PK__tb_oc_in__F59506D696EE71CA");

            entity.ToTable("tb_oc_internos");

            entity.Property(e => e.IdOcInternos).HasColumnName("id_oc_internos");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Importe).HasColumnName("importe");
            entity.Property(e => e.Iva).HasColumnName("iva");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .HasColumnName("moneda");
            entity.Property(e => e.PomNumberInt)
                .HasMaxLength(15)
                .HasColumnName("pom_number_int");
            entity.Property(e => e.Total).HasColumnName("total");
        });

        modelBuilder.Entity<TbOcMonedum>(entity =>
        {
            entity.HasKey(e => e.IdMoneda);

            entity.ToTable("tb_oc_moneda");

            entity.Property(e => e.IdMoneda)
                .HasMaxLength(10)
                .HasColumnName("id_moneda");
            entity.Property(e => e.DescMoneda)
                .HasMaxLength(50)
                .HasColumnName("desc_moneda");
            entity.Property(e => e.Orden).HasColumnName("orden");
        });

        modelBuilder.Entity<TbOcUsoCdfi>(entity =>
        {
            entity.HasKey(e => e.CUsoCfdi).HasName("PK_tb_uso_cdfi");

            entity.ToTable("tb_oc_uso_cdfi");

            entity.Property(e => e.CUsoCfdi)
                .HasMaxLength(5)
                .HasColumnName("c_UsoCFDI");
            entity.Property(e => e.DescCdfi)
                .HasMaxLength(100)
                .HasColumnName("Desc_cdfi");
        });

        modelBuilder.Entity<TbOperacionesDetalle>(entity =>
        {
            entity.HasKey(e => e.IdOperacionesDetalles).HasName("PK__tb_opera__98FAAE217741F03E");

            entity.ToTable("tb_operaciones_detalles");

            entity.Property(e => e.IdOperacionesDetalles).HasColumnName("id_operaciones_detalles");
            entity.Property(e => e.CostoCortePieza).HasColumnName("costo_corte_pieza");
            entity.Property(e => e.CostoFinal)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("costo_final");
            entity.Property(e => e.CostoSetupPieza).HasColumnName("costo_setup_pieza");
            entity.Property(e => e.EstatusOpIndividual)
                .HasMaxLength(5)
                .HasColumnName("estatus_op_individual");
            entity.Property(e => e.FechaHoraFin)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hora_Fin");
            entity.Property(e => e.FechaHoraInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hora_inicio");
            entity.Property(e => e.Finalizado).HasColumnName("finalizado");
            entity.Property(e => e.FolioDesp)
                .HasMaxLength(15)
                .HasColumnName("folio_desp");
            entity.Property(e => e.FolioReqMatInd)
                .HasMaxLength(12)
                .HasColumnName("folio_req_mat_ind");
            entity.Property(e => e.IdMaquinadoDetalle).HasColumnName("id_maquinado_detalle");
            entity.Property(e => e.IdOperacion).HasColumnName("id_operacion");
            entity.Property(e => e.OperacionFallida).HasColumnName("operacion_fallida");
            entity.Property(e => e.SetupPieza).HasColumnName("setup_pieza");
            entity.Property(e => e.TiempoTotalOperacionReal)
                .HasMaxLength(10)
                .HasColumnName("tiempo_total_operacion_real");
        });

        modelBuilder.Entity<TbOperacionesMaquinado>(entity =>
        {
            entity.HasKey(e => e.IdOperacionMaquinado).HasName("PK__tb_opera__189694F39D844F21");

            entity.ToTable("tb_operaciones_maquinados");

            entity.Property(e => e.IdOperacionMaquinado).HasColumnName("id_operacion_maquinado");
            entity.Property(e => e.CambiosHerramientas).HasColumnName("cambios_herramientas");
            entity.Property(e => e.CambiosPosicion).HasColumnName("cambios_posicion");
            entity.Property(e => e.EstatusOp)
                .HasMaxLength(5)
                .HasColumnName("estatus_op");
            entity.Property(e => e.FechaHoraFin)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hora_Fin");
            entity.Property(e => e.FechaHoraInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hora_inicio");
            entity.Property(e => e.Finalizado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("finalizado");
            entity.Property(e => e.IdMaquina)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_maquina");
            entity.Property(e => e.IdMaquinados).HasColumnName("id_maquinados");
            entity.Property(e => e.IdOperacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("id_operacion");
            entity.Property(e => e.IdOperador).HasColumnName("id_operador");
            entity.Property(e => e.NumParte)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("num_parte");
            entity.Property(e => e.TiempoEstimado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tiempo_estimado");
            entity.Property(e => e.TiempoTotalOperacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tiempo_total_operacion");
            entity.Property(e => e.TiempoTotalOperacionReal)
                .HasMaxLength(10)
                .HasColumnName("tiempo_total_operacion_real");
        });

        modelBuilder.Entity<TbOrdenCompra>(entity =>
        {
            entity.HasKey(e => e.IdOrdenCompra);

            entity.ToTable("tb_orden_compra");

            entity.Property(e => e.IdOrdenCompra).HasColumnName("id_orden_compra");
            entity.Property(e => e.AutAplica)
                .HasDefaultValue(false, "DF_tb_orden_compra_aut_aplica")
                .HasColumnName("aut_aplica");
            entity.Property(e => e.AutCompras)
                .HasDefaultValue(false, "DF_tb_orden_compra_aut_compras")
                .HasColumnName("aut_compras");
            entity.Property(e => e.AutElec)
                .HasDefaultValue(false, "DF_tb_orden_compra_aut_elec")
                .HasColumnName("aut_elec");
            entity.Property(e => e.AutEnsambles)
                .HasDefaultValue(false, "DF_tb_orden_compra_aut_ensambles")
                .HasColumnName("aut_ensambles");
            entity.Property(e => e.AutGerencia)
                .HasDefaultValue(false, "DF_tb_orden_compra_aut_gerencia")
                .HasColumnName("aut_gerencia");
            entity.Property(e => e.AutMaquinado)
                .HasDefaultValue(false, "DF_tb_orden_compra_aut_maquinado")
                .HasColumnName("aut_maquinado");
            entity.Property(e => e.AutMeca)
                .HasDefaultValue(false, "DF_tb_orden_compra_aut_meca")
                .HasColumnName("aut_meca");
            entity.Property(e => e.AutProyects)
                .HasDefaultValue(false, "def_vault")
                .HasColumnName("aut_proyects");
            entity.Property(e => e.AutRefDim)
                .HasDefaultValue(false, "DF_tb_orden_compra_aut_ref_dim")
                .HasColumnName("aut_ref_dim");
            entity.Property(e => e.AutSisIt)
                .HasDefaultValue(false, "def_value")
                .HasColumnName("aut_sis_it");
            entity.Property(e => e.DescRecibo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("desc_recibo");
            entity.Property(e => e.Descuento)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descuento");
            entity.Property(e => e.DiasCredito)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("dias_credito");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .HasColumnName("estatus");
            entity.Property(e => e.EstatusEntrega).HasColumnName("estatus_entrega");
            entity.Property(e => e.EstatusLey)
                .HasMaxLength(12)
                .HasColumnName("estatus_ley");
            entity.Property(e => e.FechaCierre)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cierre");
            entity.Property(e => e.FechaCompra)
                .HasColumnType("datetime")
                .HasColumnName("fecha_compra");
            entity.Property(e => e.FechaEntrega)
                .HasColumnType("datetime")
                .HasColumnName("fecha_entrega");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdAlmacen)
                .HasMaxLength(10)
                .HasColumnName("id_almacen");
            entity.Property(e => e.IdArea).HasColumnName("id_area");
            entity.Property(e => e.IdCenCost).HasColumnName("id_cen_cost");
            entity.Property(e => e.IdCfdiUso)
                .HasMaxLength(5)
                .HasColumnName("id_cfdi_uso");
            entity.Property(e => e.IdConcentrado)
                .HasDefaultValue(0m, "DF_tb_orden_compra_id_concentrado")
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id_concentrado");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEnvio)
                .HasMaxLength(15)
                .HasColumnName("id_envio");
            entity.Property(e => e.IdFormato)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_formato");
            entity.Property(e => e.IdPrioridad)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("id_prioridad");
            entity.Property(e => e.IdProCosto)
                .HasMaxLength(25)
                .HasColumnName("id_pro_costo");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("id_proyecto");
            entity.Property(e => e.IdSolicita).HasColumnName("id_solicita");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Importe).HasColumnName("importe");
            entity.Property(e => e.ImporteLeta)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("importe_leta");
            entity.Property(e => e.Iva).HasColumnName("iva");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .HasColumnName("moneda");
            entity.Property(e => e.MontoDescuento).HasColumnName("monto_descuento");
            entity.Property(e => e.NumFacProvedor)
                .HasMaxLength(50)
                .HasColumnName("num_fac_provedor");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.PomNumner)
                .HasMaxLength(15)
                .HasColumnName("pom_numner");
            entity.Property(e => e.RefContacto).HasColumnName("ref_contacto");
            entity.Property(e => e.Referencia).HasMaxLength(50);
            entity.Property(e => e.Rev)
                .HasMaxLength(5)
                .HasDefaultValueSql("((0))", "DF_tb_orden_compra_rev")
                .HasColumnName("rev");
            entity.Property(e => e.RevRfq)
                .HasMaxLength(1000)
                .HasColumnName("RevRFQ");
            entity.Property(e => e.SerieOc)
                .HasMaxLength(5)
                .HasColumnName("serie_oc");
            entity.Property(e => e.TipoOc)
                .HasMaxLength(5)
                .HasColumnName("tipo_oc");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.VaIva)
                .HasMaxLength(10)
                .HasColumnName("va_iva");
            entity.Property(e => e.VaTiCambio).HasColumnName("va_ti_cambio");

            entity.HasOne(d => d.EstatusNavigation).WithMany(p => p.TbOrdenCompras)
                .HasForeignKey(d => d.Estatus)
                .HasConstraintName("FK_tb_orden_compra_Maquinados_Estatus");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbOrdenCompras)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_orden_compra_tb_empresa");

            entity.HasOne(d => d.IdFormatoNavigation).WithMany(p => p.TbOrdenCompras)
                .HasForeignKey(d => d.IdFormato)
                .HasConstraintName("FK_tb_orden_compra_tb_sgc_for");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.TbOrdenCompras)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_orden_compra_tb_proveedor");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbOrdenCompras)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_orden_compra_tb_user");

            entity.HasOne(d => d.MonedaNavigation).WithMany(p => p.TbOrdenCompras)
                .HasForeignKey(d => d.Moneda)
                .HasConstraintName("FK_tb_orden_compra_tb_oc_moneda");
        });

        modelBuilder.Entity<TbOrdenCompraPriority>(entity =>
        {
            entity.HasKey(e => e.IdPrioridad).HasName("PK__tb_orden__EF3DAB40CEAD1154");

            entity.ToTable("tb_orden_compra_priority");

            entity.HasIndex(e => e.Descripcion, "UQ__tb_orden__298336B6357CC3D7").IsUnique();

            entity.Property(e => e.IdPrioridad).HasColumnName("id_prioridad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TbPeriodo>(entity =>
        {
            entity.HasKey(e => e.IdPeriodo);

            entity.ToTable("tb_periodos");

            entity.Property(e => e.IdPeriodo)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_periodos])")
                .HasColumnName("id_periodo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TbPeriodoAusencium>(entity =>
        {
            entity.HasKey(e => e.IdPeriodoAusencia).HasName("PK_periodo_ausencia");

            entity.ToTable("tb_periodo_ausencia");

            entity.Property(e => e.IdPeriodoAusencia)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_periodo_ausencia])")
                .HasColumnName("id_periodo_ausencia");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.NoAnosTrabajados).HasColumnName("no_anos_trabajados");
            entity.Property(e => e.NoDiasVacaciones).HasColumnName("no_dias_vacaciones");
        });

        modelBuilder.Entity<TbProComp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_pro_comp");

            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdComplemento)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("id_complemento");
            entity.Property(e => e.IdCon)
                .HasDefaultValueSql("(NEXT VALUE FOR [Complemento])", "DF_tb_pro_comp_id_con")
                .HasColumnName("id_con");
            entity.Property(e => e.IdProyect)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("id_proyect");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdProyectNavigation).WithMany()
                .HasForeignKey(d => d.IdProyect)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_pro_comp_tb_proyect");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_tb_pro_comp_tb_user");
        });

        modelBuilder.Entity<TbProPartList>(entity =>
        {
            entity.HasKey(e => e.IdPartList);

            entity.ToTable("tb_pro_part_list");

            entity.Property(e => e.IdPartList).HasColumnName("id_part_list");
            entity.Property(e => e.Estatus)
                .HasDefaultValue(false, "DF_tb_pro_part_list_estatus")
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaRevision).HasColumnName("fecha_revision");
            entity.Property(e => e.IdNomPl)
                .HasMaxLength(15)
                .HasColumnName("id_nom_pl");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("id_proyecto");
            entity.Property(e => e.NomMaquina)
                .HasMaxLength(50)
                .HasColumnName("nom_maquina");
            entity.Property(e => e.NomPartList)
                .HasMaxLength(100)
                .HasColumnName("nom_part_list");
            entity.Property(e => e.NumRev)
                .HasMaxLength(5)
                .HasColumnName("num_rev");
            entity.Property(e => e.NumSerie)
                .HasMaxLength(50)
                .HasColumnName("num_serie");
            entity.Property(e => e.ObserPartList)
                .HasMaxLength(100)
                .HasColumnName("obser_part_list");
            entity.Property(e => e.Proceso)
                .HasMaxLength(50)
                .HasColumnName("proceso");
            entity.Property(e => e.Referencia)
                .HasMaxLength(20)
                .HasColumnName("referencia");
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .HasColumnName("tipo");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TbProRev>(entity =>
        {
            entity.HasKey(e => e.IdRev);

            entity.ToTable("tb_pro_rev");

            entity.Property(e => e.IdRev).HasColumnName("id_rev");
            entity.Property(e => e.Desc)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("desc");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("id_proyecto");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdProyectoNavigation).WithMany(p => p.TbProRevs)
                .HasForeignKey(d => d.IdProyecto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_pro_rev_tb_proyect");
        });

        modelBuilder.Entity<TbProTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoPro);

            entity.ToTable("tb_pro_tipo");

            entity.Property(e => e.IdTipoPro)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_tipo_pro");
            entity.Property(e => e.ContadorActual).HasColumnName("contador_actual");
            entity.Property(e => e.ContadorInicial).HasColumnName("contador_inicial");
            entity.Property(e => e.DescTipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desc_tipo");
            entity.Property(e => e.Estatus)
                .HasDefaultValue(true, "DF_tb_pro_tipo_estatus")
                .HasColumnName("estatus");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Identificador)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("identificador");
            entity.Property(e => e.NomTipo)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("nom_tipo");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.Suggest).HasColumnName("suggest");
            entity.Property(e => e.TipoSel)
                .HasMaxLength(10)
                .HasColumnName("tipo_sel");
        });

        modelBuilder.Entity<TbProfile>(entity =>
        {
            entity.HasKey(e => e.IdPerfil);

            entity.ToTable("tb_profile");

            entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");
            entity.Property(e => e.DescPerfil)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("desc_perfil");
            entity.Property(e => e.EstatusProfile).HasColumnName("estatus_profile");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.NomPerfil)
                .HasMaxLength(50)
                .HasColumnName("nom_perfil");
            entity.Property(e => e.Nota)
                .HasMaxLength(25)
                .HasColumnName("nota");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .HasColumnName("observacion");
        });

        modelBuilder.Entity<TbProvTipo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tb_Prov_Tipo");

            entity.Property(e => e.DescTipoP)
                .HasMaxLength(50)
                .HasColumnName("Desc_TipoP");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Ingreso");
            entity.Property(e => e.IdTipoP)
                .HasMaxLength(10)
                .HasColumnName("Id_TipoP");
        });

        modelBuilder.Entity<TbProveedor>(entity =>
        {
            entity.HasKey(e => e.IdProveedor);

            entity.ToTable("tb_proveedor");

            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.Adress)
                .HasMaxLength(350)
                .HasColumnName("adress");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .HasColumnName("code");
            entity.Property(e => e.CondPago)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cond_pago");
            entity.Property(e => e.Contact1)
                .HasMaxLength(50)
                .HasColumnName("contact1");
            entity.Property(e => e.Contact2)
                .HasMaxLength(50)
                .HasColumnName("contact2");
            entity.Property(e => e.CorreoProv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo_prov");
            entity.Property(e => e.DiasCredito)
                .HasMaxLength(200)
                .HasColumnName("dias_credito");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .HasColumnName("fax");
            entity.Property(e => e.IdMoneda)
                .HasMaxLength(10)
                .HasColumnName("id_moneda");
            entity.Property(e => e.IdTipoP)
                .HasMaxLength(10)
                .HasColumnName("Id_TipoP");
            entity.Property(e => e.Mail1)
                .HasMaxLength(50)
                .HasColumnName("mail1");
            entity.Property(e => e.Mail2)
                .HasMaxLength(50)
                .HasColumnName("mail2");
            entity.Property(e => e.Marca).HasMaxLength(50);
            entity.Property(e => e.NomProveedor)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nom_proveedor");
            entity.Property(e => e.Notes)
                .HasMaxLength(250)
                .HasColumnName("notes");
            entity.Property(e => e.Phone1)
                .HasMaxLength(50)
                .HasColumnName("phone1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(50)
                .HasColumnName("phone_2");
            entity.Property(e => e.RfcProv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rfc_prov");
            entity.Property(e => e.TelefonoProv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono_prov");
            entity.Property(e => e.Usuario).HasMaxLength(50);
            entity.Property(e => e.Web)
                .HasMaxLength(350)
                .HasColumnName("web");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.TbProveedors)
                .HasForeignKey(d => d.IdMoneda)
                .HasConstraintName("FK_tb_proveedor_tb_oc_moneda");
        });

        modelBuilder.Entity<TbProyAlmacen>(entity =>
        {
            entity.HasKey(e => e.IdAlmacen);

            entity.ToTable("tb_proy_almacen");

            entity.Property(e => e.IdAlmacen)
                .HasMaxLength(10)
                .HasColumnName("id_almacen");
            entity.Property(e => e.DescAlmacen)
                .HasMaxLength(100)
                .HasColumnName("desc_almacen");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.NomAlmacen)
                .HasMaxLength(50)
                .HasColumnName("nom_almacen");
        });

        modelBuilder.Entity<TbProyArtAlmacen>(entity =>
        {
            entity.HasKey(e => e.IdAuto).HasName("PK_tb_proy_art_almacen_1");

            entity.ToTable("tb_proy_art_almacen");

            entity.Property(e => e.IdAuto).HasColumnName("id_auto");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.DescArticulo)
                .IsUnicode(false)
                .HasColumnName("desc_articulo");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.Fingreso)
                .HasColumnType("datetime")
                .HasColumnName("fingreso");
            entity.Property(e => e.IdAutorizaAutCam).HasColumnName("id_autoriza_aut_cam");
            entity.Property(e => e.IdDetaAlmArt).HasColumnName("id_deta_alm_art");
            entity.Property(e => e.IdDetaRfq).HasColumnName("id_deta_rfq");
            entity.Property(e => e.IdDevolucionOCambio).HasColumnName("id_devolucion_o_cambio");
            entity.Property(e => e.IdEntrega)
                .HasMaxLength(10)
                .HasColumnName("id_entrega");
            entity.Property(e => e.IdEstatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id_estatus");
            entity.Property(e => e.IdOrdeCompra).HasColumnName("id_orde_compra");
            entity.Property(e => e.IdProyect)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("id_proyect");
            entity.Property(e => e.IdSolicitaDevolucionOCambio).HasColumnName("id_solicita_devolucion_o_cambio");
            entity.Property(e => e.IdUbicacion)
                .HasMaxLength(50)
                .HasColumnName("id_ubicacion");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("moneda");
            entity.Property(e => e.NoParte)
                .HasMaxLength(60)
                .HasColumnName("no_parte");
            entity.Property(e => e.Nota)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nota");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.PoItemEstatus).HasColumnName("po_item_estatus");
            entity.Property(e => e.PoItemQtyrecived).HasColumnName("po_item_qtyrecived");
            entity.Property(e => e.PrecioUnitario).HasColumnName("precio_unitario");
            entity.Property(e => e.PzasDisponibles).HasColumnName("pzas_disponibles");
            entity.Property(e => e.PzasTransferidas).HasColumnName("pzas_transferidas");
            entity.Property(e => e.RevItem)
                .HasMaxLength(10)
                .HasColumnName("rev_item");
            entity.Property(e => e.TipoMaq)
                .HasMaxLength(10)
                .HasColumnName("tipo_maq");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("unidad_medida");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");

            entity.HasOne(d => d.UnidadMedidaNavigation).WithMany(p => p.TbProyArtAlmacens)
                .HasForeignKey(d => d.UnidadMedida)
                .HasConstraintName("FK_tb_proy_art_almacen_tb_um");
        });

        modelBuilder.Entity<TbProyChecklist>(entity =>
        {
            entity.HasKey(e => e.IdProyectoChecklist).HasName("PK_id_proyecto_checklist");

            entity.ToTable("tb_proy_checklist");

            entity.Property(e => e.IdProyectoChecklist)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_proyecto_checklist])")
                .HasColumnName("id_proyecto_checklist");
            entity.Property(e => e.Archivo2d)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("archivo2d");
            entity.Property(e => e.Archivo3d)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("archivo3d");
            entity.Property(e => e.Cotizacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cotizacion");
            entity.Property(e => e.EspecificacionCliente)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("especificacion_cliente");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_proyecto");
            entity.Property(e => e.NormasEstandares)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("normas_estandares");
        });

        modelBuilder.Entity<TbProyChecklistMeca>(entity =>
        {
            entity.HasKey(e => e.IdProyectoChecklistMeca).HasName("PK_id_proyecto_checklist_meca");

            entity.ToTable("tb_proy_checklist_meca");

            entity.Property(e => e.IdProyectoChecklistMeca)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_proyecto_checklist_meca])")
                .HasColumnName("id_proyecto_checklist_meca");
            entity.Property(e => e.AcotacionFuncionalPieza)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("acotacion_funcional_pieza");
            entity.Property(e => e.AnalisisEstudioEspecificaciones)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("analisis_estudio_especificaciones");
            entity.Property(e => e.AnalisisRuteoManguerasCables)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("analisis_ruteo_mangueras_cables");
            entity.Property(e => e.AsignacionTodasPropiedadesPieza)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("asignacion_todas_propiedades_pieza");
            entity.Property(e => e.AsignarNumeroPartePiezas)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("asignar_numero_parte_piezas");
            entity.Property(e => e.ConfiguracionesComponentesLinea)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("configuraciones_componentes_linea");
            entity.Property(e => e.ElaboracionAmef)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("elaboracion_amef");
            entity.Property(e => e.FormatoLiberacionDiseño)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("formato_liberacion_diseño");
            entity.Property(e => e.GeneracionCarpetaServidor)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("generacion_carpeta_servidor");
            entity.Property(e => e.GeneracionEnsamblePrincipalSubensamble)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("generacion_ensamble_principal_subensamble");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_proyecto");
            entity.Property(e => e.ListadosBomSpareParts)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("listados_bom_spare_parts");
            entity.Property(e => e.ModeladoPiezasMecanicas)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("modelado_piezas_mecanicas");
            entity.Property(e => e.PlanosEnsambleSubensamble)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("planos_ensamble_subensamble");
            entity.Property(e => e.RealizarCambiosSolicitadosDiseñoPreliminar)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("realizar_cambios_solicitados_diseño_preliminar");
            entity.Property(e => e.RelacionMovimeintoEnsamble)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("relacion_movimeinto_ensamble");
            entity.Property(e => e.RelecionesPosicionRespectoPernosBarrenos)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("releciones_posicion_respecto_pernos_barrenos");
            entity.Property(e => e.RequisicionMaterial)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("requisicion_material");
            entity.Property(e => e.RevisarColocarChaflanesRedondeosPieza)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("revisar_colocar_chaflanes_redondeos_pieza");
            entity.Property(e => e.RevisarSecuanciasMovimientosProgramador)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("revisar_secuancias_movimientos_programador");
            entity.Property(e => e.RevisarTiemposEntregaComponentes)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("revisar_tiempos_entrega_componentes");
            entity.Property(e => e.RevisionDiseñoFinal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("revision_diseño_final");
            entity.Property(e => e.RevisionDiseñoPreliminar)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("revision_diseño_preliminar");
            entity.Property(e => e.SeleccionComponentesLineaAdecuandos)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("seleccion_componentes_linea_adecuandos");
            entity.Property(e => e.SolicitudPartesLineaCriticos)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("solicitud_partes_linea_criticos");
            entity.Property(e => e.SubirInformacionIngenieriaEnsamble)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("subir_informacion_ingenieria_ensamble");
            entity.Property(e => e.VerificacionAdecuadaPernosBarrenos)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("verificacion_adecuada_pernos_barrenos");
            entity.Property(e => e.VerificacionFuncionalEnsamble)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("verificacion_funcional_ensamble");
        });

        modelBuilder.Entity<TbProyLider>(entity =>
        {
            entity.HasKey(e => e.IdLid);

            entity.ToTable("tb_proy_lider");

            entity.Property(e => e.IdLid).HasColumnName("id_lid");
            entity.Property(e => e.Amaterno)
                .HasMaxLength(20)
                .HasColumnName("amaterno");
            entity.Property(e => e.Aparteno)
                .HasMaxLength(20)
                .HasColumnName("aparteno");
            entity.Property(e => e.Cel)
                .HasMaxLength(30)
                .HasColumnName("cel");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .HasColumnName("email");
            entity.Property(e => e.Estatus)
                .HasDefaultValue(true, "DF_tb_proy_lider_estatus")
                .HasColumnName("estatus");
            entity.Property(e => e.IdArea).HasColumnName("id_area");
            entity.Property(e => e.NomCompleto)
                .HasMaxLength(60)
                .HasColumnName("nom_completo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .HasColumnName("nombre");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .HasColumnName("tel");
        });

        modelBuilder.Entity<TbProyTransArtAlm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_proy_trans_art_alm");

            entity.Property(e => e.DescArticulo)
                .IsUnicode(false)
                .HasColumnName("desc_articulo");
            entity.Property(e => e.Fingreso)
                .HasColumnType("datetime")
                .HasColumnName("fingreso");
            entity.Property(e => e.IdAlmacen)
                .HasMaxLength(10)
                .HasColumnName("id_almacen");
            entity.Property(e => e.IdDetaAlmArt).HasColumnName("id_deta_alm_art");
            entity.Property(e => e.IdSolicita).HasColumnName("id_solicita");
            entity.Property(e => e.NumParte)
                .HasMaxLength(50)
                .HasColumnName("num_parte");
            entity.Property(e => e.NumProyecto)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("num_proyecto");
            entity.Property(e => e.NumPzaTransfer).HasColumnName("num_pza_transfer");
            entity.Property(e => e.NumRev)
                .HasMaxLength(10)
                .HasColumnName("num_rev");
            entity.Property(e => e.UnidadMedida)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("unidad_medida");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TbProyect>(entity =>
        {
            entity.HasKey(e => e.IdProyect);

            entity.ToTable("tb_proyect");

            entity.Property(e => e.IdProyect)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("id_proyect");
            entity.Property(e => e.CantidadJobs).HasColumnName("cantidad_jobs");
            entity.Property(e => e.DescProyecto)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("desc_proyecto");
            entity.Property(e => e.Facturado).HasColumnName("facturado");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaIguales).HasColumnName("fecha_iguales");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaKickoff).HasColumnName("fecha_kickoff");
            entity.Property(e => e.FechaPo).HasColumnName("fecha_po");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.HorasDiseñoElectrico).HasColumnName("horas_diseño_electrico");
            entity.Property(e => e.HorasDiseñoMecanico).HasColumnName("horas_diseño_mecanico");
            entity.Property(e => e.HorasEnsambleProgramacion).HasColumnName("horas_ensamble_programacion");
            entity.Property(e => e.HorasOtros).HasColumnName("horas_otros");
            entity.Property(e => e.HorasProgramacion).HasColumnName("horas_programacion");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEstado)
                .HasMaxLength(50)
                .HasColumnName("id_estado");
            entity.Property(e => e.IdMoneda)
                .HasMaxLength(10)
                .HasColumnName("id_moneda");
            entity.Property(e => e.IdSector)
                .HasMaxLength(5)
                .HasColumnName("id_sector");
            entity.Property(e => e.IdTipoPro)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_tipo_pro");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.LiderProyecto).HasColumnName("lider_proyecto");
            entity.Property(e => e.LinkCarpeta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("link_carpeta");
            entity.Property(e => e.NomProyecto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nom_proyecto");
            entity.Property(e => e.Nota)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nota");
            entity.Property(e => e.NumCot)
                .HasMaxLength(50)
                .HasColumnName("num_cot");
            entity.Property(e => e.NumFactura)
                .HasMaxLength(20)
                .HasColumnName("num_factura");
            entity.Property(e => e.NumOc)
                .HasMaxLength(50)
                .HasColumnName("num_oc");
            entity.Property(e => e.NumSerie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("num_serie");
            entity.Property(e => e.PresupuestoAut).HasColumnName("presupuesto_aut");
            entity.Property(e => e.PresupuestoAutElect).HasColumnName("presupuesto_aut_elect");
            entity.Property(e => e.PresupuestoAutMaqui).HasColumnName("presupuesto_aut_maqui");
            entity.Property(e => e.PresupuestoAutMeca).HasColumnName("presupuesto_aut_meca");
            entity.Property(e => e.PresupuestoAutOtro).HasColumnName("presupuesto_aut_otro");
            entity.Property(e => e.PresupuestoElect).HasColumnName("presupuesto_elect");
            entity.Property(e => e.PresupuestoInicial).HasColumnName("presupuesto_inicial");
            entity.Property(e => e.PresupuestoMaqui).HasColumnName("presupuesto_maqui");
            entity.Property(e => e.PresupuestoMeca).HasColumnName("presupuesto_meca");
            entity.Property(e => e.PresupuestoOtro).HasColumnName("presupuesto_otro");
            entity.Property(e => e.ResponsableDiseñadorElectrico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("responsable_diseñador_electrico");
            entity.Property(e => e.ResponsableDiseñadorMecanico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("responsable_diseñador_mecanico");
            entity.Property(e => e.ResponsableEnsamblador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("responsable_ensamblador");
            entity.Property(e => e.ResponsableProgramador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("responsable_programador");
            entity.Property(e => e.ResponsableProjectManager)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("responsable_project_manager");
            entity.Property(e => e.RutaArchivos)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ruta_archivos");
            entity.Property(e => e.SemanasPropuestas).HasColumnName("semanas_propuestas");
            entity.Property(e => e.TipoCambio).HasColumnName("tipo_cambio");
            entity.Property(e => e.User01)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_01");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.TbProyects)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK_tb_proyect_tb_cliente1");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.TbProyects)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK_tb_proyect_tb_eq_estatus");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.TbProyects)
                .HasForeignKey(d => d.IdMoneda)
                .HasConstraintName("FK_tb_proyect_tb_oc_moneda");

            entity.HasOne(d => d.IdTipoProNavigation).WithMany(p => p.TbProyects)
                .HasForeignKey(d => d.IdTipoPro)
                .HasConstraintName("FK_tb_proyect_tb_pro_tipo");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.TbProyects)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_tb_proyect_tb_user");

            entity.HasOne(d => d.LiderProyectoNavigation).WithMany(p => p.TbProyects)
                .HasForeignKey(d => d.LiderProyecto)
                .HasConstraintName("FK_tb_proyect_tb_proy_lider");
        });

        modelBuilder.Entity<TbProyectCosto>(entity =>
        {
            entity.HasKey(e => e.IdProCosto);

            entity.ToTable("tb_proyect_costos");

            entity.HasIndex(e => e.IdProCosto, "ID_COSTO_UNICO").IsUnique();

            entity.Property(e => e.IdProCosto)
                .HasMaxLength(25)
                .HasColumnName("id_pro_costo");
            entity.Property(e => e.Detail)
                .HasMaxLength(200)
                .HasColumnName("detail");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
        });

        modelBuilder.Entity<TbProyectLog>(entity =>
        {
            entity.HasKey(e => e.IdProyectLog).HasName("PK_id_proyect_log");

            entity.ToTable("tb_proyect_log");

            entity.Property(e => e.IdProyectLog)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_proyect_log])")
                .HasColumnName("id_proyect_log");
            entity.Property(e => e.Descrip)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("descrip");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_proyecto");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
        });

        modelBuilder.Entity<TbRegHorasJob>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_reg_horas_job");

            entity.Property(e => e.Asignacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asignacion");
            entity.Property(e => e.AsignacionGeneral)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asignacion_general");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.FechaReg)
                .HasColumnType("datetime")
                .HasColumnName("fecha_reg");
            entity.Property(e => e.Horas).HasColumnName("horas");
            entity.Property(e => e.HorasCostos).HasColumnName("horas_costos");
            entity.Property(e => e.IdArea).HasColumnName("id_area");
            entity.Property(e => e.IdReg)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_reg");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Job)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("job");
        });

        modelBuilder.Entity<TbRegPrestamosAsignacion>(entity =>
        {
            entity.HasKey(e => e.IdReg).HasName("PK_tb_reg_prestamos");

            entity.ToTable("tb_reg_prestamos_asignacion");

            entity.Property(e => e.IdReg)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_reg_prestamos_asignacion])")
                .HasColumnName("id_reg");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaEntrega)
                .HasColumnType("datetime")
                .HasColumnName("fecha_entrega");
            entity.Property(e => e.FechaPrestamo)
                .HasColumnType("datetime")
                .HasColumnName("fecha_prestamo");
            entity.Property(e => e.IdUserAsignado).HasColumnName("id_user_asignado");
            entity.Property(e => e.IdUserEncargado).HasColumnName("id_user_encargado");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TbRegistroAusencia>(entity =>
        {
            entity.HasKey(e => e.IdAusencias);

            entity.ToTable("tb_registro_ausencias");

            entity.Property(e => e.IdAusencias)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_ausencias])")
                .HasColumnName("id_ausencias");
            entity.Property(e => e.Autorizacion).HasColumnName("autorizacion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusJornada)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("estatus_jornada");
            entity.Property(e => e.FechaFinAusencia).HasColumnName("fecha_fin_ausencia");
            entity.Property(e => e.FechaInicioAusencia).HasColumnName("fecha_inicio_ausencia");
            entity.Property(e => e.IdTipoAusencia).HasColumnName("id_tipo_ausencia");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.TipoJornada)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo_jornada");
        });

        modelBuilder.Entity<TbReqDetum>(entity =>
        {
            entity.HasKey(e => e.IdDetaReq);

            entity.ToTable("tb_req_deta");

            entity.Property(e => e.IdDetaReq).HasColumnName("id_deta_req");
            entity.Property(e => e.Autorizacion).HasColumnName("autorizacion");
            entity.Property(e => e.CantPendiente).HasColumnName("cant_pendiente");
            entity.Property(e => e.CantPendienteSap).HasColumnName("cant_pendiente_sap");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.DescArticulo)
                .IsUnicode(false)
                .HasColumnName("desc_articulo");
            entity.Property(e => e.DescRev)
                .HasMaxLength(5)
                .HasColumnName("desc_rev");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .HasColumnName("estatus");
            entity.Property(e => e.IdAutoriza).HasColumnName("id_autoriza");
            entity.Property(e => e.IdOrdenCompra)
                .HasMaxLength(120)
                .HasColumnName("id_orden_compra");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("id_proyecto");
            entity.Property(e => e.IdReq).HasColumnName("id_req");
            entity.Property(e => e.NoParte)
                .HasMaxLength(60)
                .HasColumnName("no_parte");
            entity.Property(e => e.Nota)
                .HasMaxLength(350)
                .HasColumnName("nota");
            entity.Property(e => e.Pda).HasColumnName("pda");
            entity.Property(e => e.PrecioUnitario).HasColumnName("precio_unitario");
            entity.Property(e => e.Racabado)
                .HasMaxLength(55)
                .HasColumnName("RAcabado");
            entity.Property(e => e.Rmarca)
                .HasMaxLength(50)
                .HasColumnName("RMarca");
            entity.Property(e => e.Rmaterial)
                .HasMaxLength(50)
                .HasColumnName("RMaterial");
            entity.Property(e => e.Rmecanizado)
                .HasMaxLength(50)
                .HasColumnName("RMecanizado");
            entity.Property(e => e.Rpeso).HasColumnName("RPeso");
            entity.Property(e => e.Rprioridad)
                .HasMaxLength(25)
                .HasColumnName("RPrioridad");
            entity.Property(e => e.Rspare)
                .HasMaxLength(50)
                .HasColumnName("RSpare");
            entity.Property(e => e.SolOcSap)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sol_oc_sap");
            entity.Property(e => e.TipoMaquinado)
                .HasMaxLength(10)
                .HasColumnName("tipo_maquinado");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.UnidadM)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("unidad_m");

            entity.HasOne(d => d.IdReqNavigation).WithMany(p => p.TbReqDeta)
                .HasForeignKey(d => d.IdReq)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_req_deta_tb_requisicion");
        });

        modelBuilder.Entity<TbReqMaterial>(entity =>
        {
            entity.HasKey(e => e.IdReq);

            entity.ToTable("tb_req_material");

            entity.Property(e => e.IdReq).HasColumnName("id_req");
            entity.Property(e => e.EsSalidaProveedor).HasColumnName("es_salida_proveedor");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FProcesoSap)
                .HasColumnType("datetime")
                .HasColumnName("f_proceso_sap");
            entity.Property(e => e.FechaEntrega)
                .HasColumnType("datetime")
                .HasColumnName("fecha_entrega");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .HasColumnName("folio");
            entity.Property(e => e.IdDepto).HasColumnName("id_depto");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdUserAutoriza).HasColumnName("id_user_autoriza");
            entity.Property(e => e.IdUserReceives).HasColumnName("id_user_receives");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Impreso).HasColumnName("impreso");
            entity.Property(e => e.NumReqSal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("(format(NEXT VALUE FOR [id_req_salida],'REQS-#'))", "DF__tb_req_ma__num_r__0E7913B7")
                .HasColumnName("num_req_sal");
            entity.Property(e => e.ObserEntrerga)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("obser_entrerga");
            entity.Property(e => e.ObservSol)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observ_sol");
            entity.Property(e => e.TipoReq)
                .HasMaxLength(15)
                .HasColumnName("tipo_req");
            entity.Property(e => e.UserEntrega)
                .HasMaxLength(50)
                .HasColumnName("user_entrega");
        });

        modelBuilder.Entity<TbReqMecanizado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_req_mecanizado");

            entity.Property(e => e.ColorFondo)
                .HasMaxLength(10)
                .HasColumnName("color_fondo");
            entity.Property(e => e.DecMecanizado)
                .HasMaxLength(20)
                .HasColumnName("dec_mecanizado");
            entity.Property(e => e.IdMeca)
                .HasMaxLength(10)
                .HasColumnName("id_meca");
            entity.Property(e => e.TipoMaq).HasColumnName("tipo_maq");
        });

        modelBuilder.Entity<TbReqPrioridad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_req_prioridad");

            entity.Property(e => e.ColorFondo)
                .HasMaxLength(10)
                .HasColumnName("color_fondo");
            entity.Property(e => e.DescPrioridsd)
                .HasMaxLength(20)
                .HasColumnName("desc_prioridsd");
            entity.Property(e => e.IdPrioridad)
                .HasMaxLength(10)
                .HasColumnName("id_prioridad");
        });

        modelBuilder.Entity<TbReqTipo>(entity =>
        {
            entity.HasKey(e => e.IdTipoReq);

            entity.ToTable("tb_req_tipo");

            entity.Property(e => e.IdTipoReq)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_tipo_req");
            entity.Property(e => e.DescTipoReq)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desc_tipo_req");
            entity.Property(e => e.NomTipoReq)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_tipo_req");
            entity.Property(e => e.Orden).HasColumnName("orden");
        });

        modelBuilder.Entity<TbRequisicion>(entity =>
        {
            entity.HasKey(e => e.IdReq);

            entity.ToTable("tb_requisicion");

            entity.Property(e => e.IdReq).HasColumnName("id_req");
            entity.Property(e => e.DescRev)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("desc_rev");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.FechaCierre)
                .HasColumnType("datetime")
                .HasColumnName("fecha_cierre");
            entity.Property(e => e.FechaEntrega)
                .HasColumnType("datetime")
                .HasColumnName("fecha_entrega");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.FechaSolicitud).HasColumnName("fecha_solicitud");
            entity.Property(e => e.IdDepto).HasColumnName("id_depto");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEstatus)
                .HasMaxLength(10)
                .HasColumnName("Id_Estatus");
            entity.Property(e => e.IdFormato)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_formato");
            entity.Property(e => e.IdOcompra)
                .HasMaxLength(15)
                .HasColumnName("id_ocompra");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.IdProyecto)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("id_proyecto");
            entity.Property(e => e.IdRev).HasColumnName("Id_Rev");
            entity.Property(e => e.IdTiporeq)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_tiporeq");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.LetRev)
                .HasMaxLength(3)
                .HasColumnName("Let_Rev");
            entity.Property(e => e.ModPda).HasColumnName("Mod_Pda");
            entity.Property(e => e.NumEnsamble)
                .HasMaxLength(50)
                .HasColumnName("num_ensamble");
            entity.Property(e => e.NumReq)
                .HasMaxLength(20)
                .HasColumnName("num_req");
            entity.Property(e => e.Observaciones)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.RevCom)
                .HasDefaultValue(false, "DF_tb_requisicion_Rev_Com")
                .HasColumnName("Rev_Com");
            entity.Property(e => e.SendMail)
                .HasDefaultValue(false, "DF_tb_requisicion_send_mail")
                .HasColumnName("send_mail");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbRequisicions)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK_tb_requisicion_tb_user");
        });

        modelBuilder.Entity<TbRfqLog>(entity =>
        {
            entity.HasKey(e => e.IdRgLog);

            entity.ToTable("tb_Rfq_Log");

            entity.Property(e => e.IdRgLog).HasColumnName("Id_Rg_Log");
            entity.Property(e => e.DescMovimiento)
                .HasMaxLength(500)
                .HasColumnName("Desc_Movimiento");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.ForVentana)
                .HasMaxLength(30)
                .HasColumnName("For_Ventana");
            entity.Property(e => e.Movimiento).HasMaxLength(15);
            entity.Property(e => e.NumReq)
                .HasMaxLength(20)
                .HasColumnName("num_req");
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<TbSalidaMat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_salida_mat");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.FechaSalida)
                .HasColumnType("datetime")
                .HasColumnName("fecha_salida");
            entity.Property(e => e.IdDetaReq).HasColumnName("id_deta_req");
            entity.Property(e => e.IdSalida)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_salida");
            entity.Property(e => e.IdUbicacion)
                .HasMaxLength(50)
                .HasColumnName("id_ubicacion");
            entity.Property(e => e.TipoUbicacion).HasColumnName("tipo_ubicacion");
        });

        modelBuilder.Entity<TbSalidaTratamientoAcabado>(entity =>
        {
            entity.HasKey(e => e.IdSalidaTratAca).HasName("PK_id_salida_trat_aca");

            entity.ToTable("tb_salida_tratamiento_acabado");

            entity.Property(e => e.IdSalidaTratAca)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_salida_trat_aca])")
                .HasColumnName("id_salida_trat_aca");
            entity.Property(e => e.Estatus)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.FechaRetornoProv)
                .HasColumnType("datetime")
                .HasColumnName("fecha_retorno_prov");
            entity.Property(e => e.FechaSalida)
                .HasColumnType("datetime")
                .HasColumnName("fecha_salida");
            entity.Property(e => e.Folio)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("folio");
            entity.Property(e => e.IdProveedor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("id_proveedor");
            entity.Property(e => e.Peso).HasColumnName("peso");
            entity.Property(e => e.TipoFolio).HasColumnName("tipo_folio");
            entity.Property(e => e.UsuarioCrea)
                .HasMaxLength(30)
                .HasColumnName("usuario_crea");
        });

        modelBuilder.Entity<TbSgcFor>(entity =>
        {
            entity.HasKey(e => e.IdFormato);

            entity.ToTable("tb_sgc_for");

            entity.Property(e => e.IdFormato)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_formato");
            entity.Property(e => e.CodFormato)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("cod_formato");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fecha_ingreso");
            entity.Property(e => e.FechaMod)
                .HasColumnType("datetime")
                .HasColumnName("fecha_mod");
            entity.Property(e => e.FechaRev)
                .HasColumnType("datetime")
                .HasColumnName("fecha_rev");
            entity.Property(e => e.IdArea).HasColumnName("id_area");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.LinkFormato)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("link_formato");
            entity.Property(e => e.MotivoCambio)
                .IsUnicode(false)
                .HasColumnName("motivo_cambio");
            entity.Property(e => e.NoRevision)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("no_revision");
            entity.Property(e => e.NomFormato)
                .IsUnicode(false)
                .HasColumnName("nom_formato");
            entity.Property(e => e.Nota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nota");
            entity.Property(e => e.Observaciones)
                .IsUnicode(false)
                .HasColumnName("observaciones");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.ProxRenovacion)
                .HasColumnType("datetime")
                .HasColumnName("prox_renovacion");
            entity.Property(e => e.TimeVig).HasColumnName("time_vig");
            entity.Property(e => e.User01)
                .HasMaxLength(500)
                .HasColumnName("user_01");
            entity.Property(e => e.User02)
                .HasMaxLength(500)
                .HasColumnName("user_02");
            entity.Property(e => e.User03)
                .HasMaxLength(500)
                .HasColumnName("user_03");
            entity.Property(e => e.User04)
                .HasMaxLength(500)
                .HasColumnName("user_04");

            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.TbSgcFors)
                .HasForeignKey(d => d.IdArea)
                .HasConstraintName("FK_tb_sgc_for_tb_area");
        });

        modelBuilder.Entity<TbTipoAusencium>(entity =>
        {
            entity.HasKey(e => e.IdTipoAusencia).HasName("PK_tipo_ausencia");

            entity.ToTable("tb_tipo_ausencia");

            entity.Property(e => e.IdTipoAusencia)
                .HasDefaultValueSql("(NEXT VALUE FOR [id_tipo_ausencia])")
                .HasColumnName("id_tipo_ausencia");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TbTipoCambio>(entity =>
        {
            entity.HasKey(e => e.IdTc);

            entity.ToTable("tb_tipo_cambio");

            entity.Property(e => e.IdTc).HasColumnName("id_tc");
            entity.Property(e => e.FechaTc)
                .HasColumnType("datetime")
                .HasColumnName("fecha_tc");
            entity.Property(e => e.IdMoneda)
                .HasMaxLength(10)
                .HasColumnName("id_moneda");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.ValTc).HasColumnName("val_tc");

            entity.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.TbTipoCambios)
                .HasForeignKey(d => d.IdMoneda)
                .HasConstraintName("FK_tb_tipo_cambio_tb_oc_moneda");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.TbTipoCambios)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_tb_tipo_cambio_tb_user");
        });

        modelBuilder.Entity<TbTipoDiagrama>(entity =>
        {
            entity.HasKey(e => e.IdTipoDiag).HasName("PK__tb_tipo___FF658ED5646B67B0");

            entity.ToTable("tb_tipo_diagrama");

            entity.Property(e => e.IdTipoDiag)
                .HasMaxLength(15)
                .HasColumnName("id_tipo_diag");
            entity.Property(e => e.DescripDiag)
                .HasMaxLength(60)
                .HasColumnName("descrip_diag");
        });

        modelBuilder.Entity<TbTipocustodium>(entity =>
        {
            entity.HasKey(e => e.IdTipocustodia).HasName("PK__tb_tipoc__6B582DD24C005A02");

            entity.ToTable("tb_tipocustodia");

            entity.Property(e => e.IdTipocustodia)
                .ValueGeneratedNever()
                .HasColumnName("id_tipocustodia");
            entity.Property(e => e.NomTipocustodia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_tipocustodia");
        });

        modelBuilder.Entity<TbTratamientoAcabado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_tratamiento_acabado");

            entity.Property(e => e.Aplica).HasColumnName("aplica");
            entity.Property(e => e.DescTratAca)
                .IsUnicode(false)
                .HasColumnName("desc_trat_aca");
            entity.Property(e => e.IdTratAca)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_trat_aca");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TbUbiEquipo>(entity =>
        {
            entity.HasKey(e => e.IdUbicacion);

            entity.ToTable("tb_ubi_equipos");

            entity.Property(e => e.IdUbicacion).HasColumnName("id_ubicacion");
            entity.Property(e => e.NomUbicacion)
                .HasMaxLength(50)
                .HasColumnName("nom_ubicacion");
        });

        modelBuilder.Entity<TbUm>(entity =>
        {
            entity.HasKey(e => e.IdMedida);

            entity.ToTable("tb_um");

            entity.Property(e => e.IdMedida)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id_medida");
            entity.Property(e => e.Abrev)
                .HasMaxLength(5)
                .HasColumnName("abrev");
            entity.Property(e => e.DescMedida)
                .HasMaxLength(15)
                .HasColumnName("desc_medida");
            entity.Property(e => e.DivEtq).HasColumnName("div_etq");
            entity.Property(e => e.Maq)
                .HasMaxLength(5)
                .HasColumnName("maq");
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("tb_user");

            entity.HasIndex(e => e.Usuario, "UQ__tb_user__9AFF8FC657F1B756").IsUnique();

            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.Amaterno)
                .HasMaxLength(20)
                .HasColumnName("amaterno");
            entity.Property(e => e.Aparteno)
                .HasMaxLength(20)
                .HasColumnName("aparteno");
            entity.Property(e => e.AutMov).HasColumnName("aut_mov");
            entity.Property(e => e.Cel)
                .HasMaxLength(30)
                .HasColumnName("cel");
            entity.Property(e => e.ChangePassword).HasColumnName("change_password");
            entity.Property(e => e.Correo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.EdoUser)
                .HasDefaultValue(true, "DF_tb_user_edo_user")
                .HasColumnName("edo_user");
            entity.Property(e => e.Email)
                .HasMaxLength(80)
                .HasColumnName("email");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.FirmaDifital)
                .HasColumnType("image")
                .HasColumnName("firma_difital");
            entity.Property(e => e.IdDepto).HasColumnName("id_depto");
            entity.Property(e => e.IdProfile).HasColumnName("id_profile");
            entity.Property(e => e.LastClosure)
                .HasColumnType("datetime")
                .HasColumnName("last_closure");
            entity.Property(e => e.LastConection)
                .HasColumnType("datetime")
                .HasColumnName("last_conection");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.MondayAccess)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("text")
                .HasColumnName("monday_access");
            entity.Property(e => e.MsjFecha).HasColumnName("msj_fecha");
            entity.Property(e => e.NomUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom_user");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .HasColumnName("nombre");
            entity.Property(e => e.PasswdUser)
                .HasMaxLength(100)
                .HasColumnName("passwd_user");
            entity.Property(e => e.ProyectoPer)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("proyecto_per");
            entity.Property(e => e.PublicIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("public_ip");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
            entity.Property(e => e.VistaInicio)
                .HasMaxLength(100)
                .HasColumnName("vista_inicio");
            entity.Property(e => e.WmPermission)
                .HasDefaultValue("{\"pages\": [{\"path\": \"/\", \"permissions\": [\"update\", \"create\", \"delete\"]}], \"workspaces\": []}")
                .HasColumnName("wm_permission");

            entity.HasOne(d => d.IdDeptoNavigation).WithMany(p => p.TbUsers)
                .HasForeignKey(d => d.IdDepto)
                .HasConstraintName("fk_tb_user_tb_area");

            entity.HasOne(d => d.IdProfileNavigation).WithMany(p => p.TbUsers)
                .HasForeignKey(d => d.IdProfile)
                .HasConstraintName("FK_tb_user_tb_profile");
        });

        modelBuilder.Entity<TbUserPermiso>(entity =>
        {
            entity.HasKey(e => e.IdUserPermiso);

            entity.ToTable("tb_user_permiso");

            entity.Property(e => e.IdUserPermiso).HasColumnName("id_user_permiso");
            entity.Property(e => e.IdPermiso).HasColumnName("id_permiso");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.PerCreate).HasColumnName("per_create");
            entity.Property(e => e.PerDelete).HasColumnName("per_delete");
            entity.Property(e => e.PerRead).HasColumnName("per_read");
            entity.Property(e => e.PerUpdate).HasColumnName("per_update");
        });

        modelBuilder.Entity<TbWebPermiso>(entity =>
        {
            entity.HasKey(e => e.IdPermisos);

            entity.ToTable("tb_web_permisos");

            entity.Property(e => e.IdPermisos).HasColumnName("id_permisos");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("descripcion");
            entity.Property(e => e.EsInicial).HasColumnName("es_inicial");
            entity.Property(e => e.EsMantenimiento).HasColumnName("es_mantenimiento");
            entity.Property(e => e.Estatus).HasColumnName("estatus");
            entity.Property(e => e.Icono)
                .HasMaxLength(200)
                .HasColumnName("icono");
            entity.Property(e => e.IdMenuPadre).HasColumnName("id_menu_padre");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("nombre");
            entity.Property(e => e.Orden).HasColumnName("orden");
            entity.Property(e => e.PathUrl)
                .HasMaxLength(400)
                .HasColumnName("path_url");
        });

        modelBuilder.Entity<UserAsignedToItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserAsig__3213E83FC977BEB1");

            entity.ToTable("UserAsignedToItem");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.AsignedBy).HasColumnName("asignedBy");
            entity.Property(e => e.AsignedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("asignedDate");
            entity.Property(e => e.DeletedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.ItemId).HasColumnName("itemId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.AsignedByNavigation).WithMany(p => p.UserAsignedToItems)
                .HasForeignKey(d => d.AsignedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Asigned_By_Id");

            entity.HasOne(d => d.Item).WithMany(p => p.UserAsignedToItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Assigned_Item_Id");

            entity.HasOne(d => d.User).WithMany(p => p.UserAsignedToItems)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Nominal_Id");
        });

        modelBuilder.Entity<View>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Views__3213E83FE606468E");

            entity.HasIndex(e => e.BoardId, "IX_Views_BoardId");

            entity.HasIndex(e => e.IsDefault, "IX_Views_IsDefault");

            entity.HasIndex(e => e.Position, "IX_Views_Position");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.BoardId).HasColumnName("board_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.IsDefault).HasColumnName("is_default");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Board).WithMany(p => p.Views)
                .HasForeignKey(d => d.BoardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Views__board_id__5AE46118");
        });

        modelBuilder.Entity<ViewSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ViewSett__3213E83F11065339");

            entity.HasIndex(e => e.ViewId, "IX_ViewSettings_ViewId");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.SettingKey)
                .HasMaxLength(100)
                .HasColumnName("setting_key");
            entity.Property(e => e.SettingValue).HasColumnName("setting_value");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");
            entity.Property(e => e.ViewId).HasColumnName("view_id");

            entity.HasOne(d => d.View).WithMany(p => p.ViewSettings)
                .HasForeignKey(d => d.ViewId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ViewSetti__view___609D3A6E");
        });

        modelBuilder.Entity<Workspace>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Workspac__3213E83F22B601AA");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updated_at");
        });
        modelBuilder.HasSequence<int>("comentario_ids");
        modelBuilder.HasSequence<int>("comentario_ventas_ids");
        modelBuilder.HasSequence<int>("Complemento");
        modelBuilder.HasSequence<int>("empresa_cliente_id");
        modelBuilder.HasSequence<int>("id_asignacion_general_proyecto");
        modelBuilder.HasSequence<int>("id_asignacion_proyecto");
        modelBuilder.HasSequence<int>("id_ausencias");
        modelBuilder.HasSequence<int>("id_calidad_log");
        modelBuilder.HasSequence<int>("id_cargos");
        modelBuilder.HasSequence<int>("id_costo_venta");
        modelBuilder.HasSequence<int>("id_cotizacion");
        modelBuilder.HasSequence<int>("id_cotizacion_log");
        modelBuilder.HasSequence<int>("id_departamentos");
        modelBuilder.HasSequence<int>("id_devolucion_o_cambio");
        modelBuilder.HasSequence<int>("id_empleados");
        modelBuilder.HasSequence<int>("id_fechas_proyectos");
        modelBuilder.HasSequence<int>("id_horas_extras");
        modelBuilder.HasSequence<int>("id_maquinado_calida").StartsAt(12L);
        modelBuilder.HasSequence<int>("id_nivel");
        modelBuilder.HasSequence<int>("id_oc_cotizacion").StartsAt(3L);
        modelBuilder.HasSequence<int>("id_operacion_maquinado");
        modelBuilder.HasSequence<int>("id_periodo_ausencia");
        modelBuilder.HasSequence<int>("id_periodos");
        modelBuilder.HasSequence<int>("id_proyect_log");
        modelBuilder.HasSequence<int>("id_proyecto_checklist");
        modelBuilder.HasSequence<int>("id_proyecto_checklist_meca");
        modelBuilder.HasSequence<int>("id_reg_prestamos_asignacion");
        modelBuilder.HasSequence<int>("id_req_salida").StartsAt(2746L);
        modelBuilder.HasSequence<int>("id_salida_trat_aca");
        modelBuilder.HasSequence<int>("id_tipo_ausencia");
        modelBuilder.HasSequence<int>("megusta_ids");
        modelBuilder.HasSequence<int>("megusta_ventas_ids");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
