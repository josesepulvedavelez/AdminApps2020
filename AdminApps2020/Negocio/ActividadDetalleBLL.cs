using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos; 

namespace Negocio
{    
    public class ActividadDetalleBLL
    {
        ActividadDetalleDAL actividadDetalleDAL;
        List<ActividadDetalleENT> lstActividadDetalle;
        int res;

        public List<ActividadDetalleENT> SeleccionarTodos(ActividadDetalleENT actividadDetalleENT)
        {
            actividadDetalleDAL = new ActividadDetalleDAL();
            lstActividadDetalle = actividadDetalleDAL.SeleccionarTodos(actividadDetalleENT);

            return lstActividadDetalle;
        }

        public int Insertar(ActividadDetalleENT actividadDetalleENT)
        {
            actividadDetalleDAL = new ActividadDetalleDAL();
            res = actividadDetalleDAL.Insertar(actividadDetalleENT);

            return res;
        }

        public int Actualizar(ActividadDetalleENT actividadDetalleENT)
        {
            actividadDetalleDAL = new ActividadDetalleDAL();
            res = actividadDetalleDAL.Actualizar(actividadDetalleENT);

            return res;
        }
    }
}
