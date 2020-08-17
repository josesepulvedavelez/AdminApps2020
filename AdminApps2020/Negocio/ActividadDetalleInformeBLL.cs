using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ActividadDetalleInformeBLL
    {
        ActividadDetalleInformeDAL actividadDetalleInformeDAL;
        List<ActividadDetalleInformeENT> lstActividadDetalleInforme; 

        public List<ActividadDetalleInformeENT> SeleccionarTodos()
        {
            actividadDetalleInformeDAL = new ActividadDetalleInformeDAL();
            lstActividadDetalleInforme = actividadDetalleInformeDAL.SeleccionarTodos();

            return lstActividadDetalleInforme;
        }

        public List<ActividadDetalleInformeENT> BuscarActividadDetalleInforme(string campo, string texto)
        {
            actividadDetalleInformeDAL = new ActividadDetalleInformeDAL();
            lstActividadDetalleInforme = actividadDetalleInformeDAL.BuscarActividadDetalleInforme(campo, texto);

            return lstActividadDetalleInforme;
        }

        public List<ActividadDetalleInformeENT> BuscarActividadFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            actividadDetalleInformeDAL = new ActividadDetalleInformeDAL();
            lstActividadDetalleInforme = actividadDetalleInformeDAL.BuscarActividadFecha(fechaInicio, fechaFinal);

            return lstActividadDetalleInforme;
        }
    }
}
