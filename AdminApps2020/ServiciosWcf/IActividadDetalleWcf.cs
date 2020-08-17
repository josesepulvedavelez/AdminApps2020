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
    public interface IActividadDetalleWcf
    {
        [OperationContract]
        List<ActividadDetalleENT> SeleccionarTodos(ActividadDetalleENT actividadDetalleENT);

        [OperationContract]
        int Insertar(ActividadDetalleENT actividadDetalleENT);

        [OperationContract]
        int Actualizar(ActividadDetalleENT actividadDetalleENT);
    }
}
