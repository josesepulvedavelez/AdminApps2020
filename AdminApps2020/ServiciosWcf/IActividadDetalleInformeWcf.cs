using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Negocio;
using Entidades; 

namespace ServiciosWcf
{    
    [ServiceContract]
    public interface IActividadDetalleInformeWcf
    {
        [OperationContract]
        List<ActividadDetalleInformeENT> SeleccionarTodos();

        [OperationContract]
        List<ActividadDetalleInformeENT> BuscarActividadDetalleInforme(string campo, string texto);

        [OperationContract]
        List<ActividadDetalleInformeENT> BuscarActividadFecha(DateTime fechaInicio, DateTime fechaFinal);
    }
}
