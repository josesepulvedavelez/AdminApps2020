using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using Negocio; 

namespace ServiciosWcf
{    
    public class ActividadDetalleWcf : IActividadDetalleWcf
    {
        ActividadDetalleBLL actividadDetalleBLL; 

        public List<ActividadDetalleENT> SeleccionarTodos(ActividadDetalleENT actividadDetalleENT)
        {
            actividadDetalleBLL = new ActividadDetalleBLL(); 

            return actividadDetalleBLL.SeleccionarTodos(actividadDetalleENT);
        }

        public int Insertar(ActividadDetalleENT actividadDetalleENT)
        {
            actividadDetalleBLL = new ActividadDetalleBLL();

            return actividadDetalleBLL.Insertar(actividadDetalleENT);
        }

        public int Actualizar(ActividadDetalleENT actividadDetalleENT)
        {
            actividadDetalleBLL = new ActividadDetalleBLL();

            return actividadDetalleBLL.Actualizar(actividadDetalleENT);
        }
    }
}
