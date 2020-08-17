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
    public interface IContactoWcf
    {
        [OperationContract]
        List<ContactoENT> SeleccionarTodos();

        [OperationContract]
        List<ContactoENT> SeleccionarContacto(int ProveedorId);

        [OperationContract]
        int Insertar(ContactoENT contactoENT);

        [OperationContract]
        int Actualizar(ContactoENT contactoENT);

        [OperationContract]
        List<ProveedorENT> SeleccionarProveedor();

        [OperationContract]
        List<ContactoENT> BuscarContacto(string campo, string texto);
    }
}
