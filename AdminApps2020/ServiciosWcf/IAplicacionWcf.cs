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
    public interface IAplicacionWcf
    {
        [OperationContract]
        List<AplicacionENT> SeleccionarTodos();

        [OperationContract]
        List<AplicacionENT> SelecccionarAplicacion(int ProveedorId);

        [OperationContract]
        int Insertar(AplicacionENT aplicacionENT);

        [OperationContract]
        int Actualizar(AplicacionENT aplicacionENT);

        [OperationContract]
        List<ProveedorENT> SeleccionarProveedor();

        [OperationContract]
        List<ServidorENT> SeleccionarServidor();

        [OperationContract]
        List<AplicacionENT> BuscarAplicacion(string campo, string texto);
    }
}
