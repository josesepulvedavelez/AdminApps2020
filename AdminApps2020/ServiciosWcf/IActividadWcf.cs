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
    [ServiceContract]
    public interface IActividadWcf
    {
        [OperationContract]
        List<ActividadENT> SeleccionarTodos();

        [OperationContract]
        List<ActividadENT> SeleccionarUsuario();

        [OperationContract]
        int Insertar(ActividadENT actividadENT);

        [OperationContract]
        int Actualizar(ActividadENT actividadENT);

        [OperationContract]
        List<ActividadENT> BuscarActividad(string campo, string texto);

        [OperationContract]
        List<ActividadENT> BuscarActividadFecha(DateTime fechaInicio, DateTime fechaFinal);
    }
}
