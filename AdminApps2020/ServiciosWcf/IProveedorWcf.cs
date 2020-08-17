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
    public interface IProveedorWcf
    {
        [OperationContract]
        List<ProveedorENT> SeleccionarTodos();

        [OperationContract]
        int Insertar(ProveedorENT proveedorENT);

        [OperationContract]
        int Actualizar(ProveedorENT proveedorENT);

        [OperationContract]
        List<ProveedorENT> SeleccionarProveedor();

        [OperationContract]
        List<ProveedorENT> BuscarProveedor(string campo, string texto);
    }
}
