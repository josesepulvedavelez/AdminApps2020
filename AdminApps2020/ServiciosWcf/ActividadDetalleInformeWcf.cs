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
    public class ActividadDetalleInformeWcf : IActividadDetalleInformeWcf
    {
        ActividadDetalleInformeBLL actividadDetalleInformeBLL;

        public List<ActividadDetalleInformeENT> SeleccionarTodos()
        {
            actividadDetalleInformeBLL = new ActividadDetalleInformeBLL();

            return actividadDetalleInformeBLL.SeleccionarTodos();
        }

        public List<ActividadDetalleInformeENT> BuscarActividadDetalleInforme(string campo, string texto)
        {
            actividadDetalleInformeBLL = new ActividadDetalleInformeBLL();

            return actividadDetalleInformeBLL.BuscarActividadDetalleInforme(campo, texto);
        }

        public List<ActividadDetalleInformeENT> BuscarActividadFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            actividadDetalleInformeBLL = new ActividadDetalleInformeBLL();

            return actividadDetalleInformeBLL.BuscarActividadFecha(fechaInicio, fechaFinal);
        }
    }
}
