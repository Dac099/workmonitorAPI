using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class TbProyChecklistMeca
{
    public int IdProyectoChecklistMeca { get; set; }

    public string? IdProyecto { get; set; }

    public string? GeneracionCarpetaServidor { get; set; }

    public string? AnalisisEstudioEspecificaciones { get; set; }

    public string? SolicitudPartesLineaCriticos { get; set; }

    public string? ElaboracionAmef { get; set; }

    public string? ModeladoPiezasMecanicas { get; set; }

    public string? GeneracionEnsamblePrincipalSubensamble { get; set; }

    public string? SeleccionComponentesLineaAdecuandos { get; set; }

    public string? ConfiguracionesComponentesLinea { get; set; }

    public string? RelacionMovimeintoEnsamble { get; set; }

    public string? RevisarTiemposEntregaComponentes { get; set; }

    public string? VerificacionAdecuadaPernosBarrenos { get; set; }

    public string? RelecionesPosicionRespectoPernosBarrenos { get; set; }

    public string? VerificacionFuncionalEnsamble { get; set; }

    public string? RevisarColocarChaflanesRedondeosPieza { get; set; }

    public string? AnalisisRuteoManguerasCables { get; set; }

    public string? RevisarSecuanciasMovimientosProgramador { get; set; }

    public string? RevisionDiseñoPreliminar { get; set; }

    public string? RealizarCambiosSolicitadosDiseñoPreliminar { get; set; }

    public string? AsignarNumeroPartePiezas { get; set; }

    public string? AsignacionTodasPropiedadesPieza { get; set; }

    public string? RevisionDiseñoFinal { get; set; }

    public string? FormatoLiberacionDiseño { get; set; }

    public string? AcotacionFuncionalPieza { get; set; }

    public string? PlanosEnsambleSubensamble { get; set; }

    public string? ListadosBomSpareParts { get; set; }

    public string? RequisicionMaterial { get; set; }

    public string? SubirInformacionIngenieriaEnsamble { get; set; }
}
