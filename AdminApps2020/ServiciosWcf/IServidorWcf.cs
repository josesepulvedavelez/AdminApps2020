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
    public interface IServidorWcf
    {
        [OperationContract]
        List<ServidorENT> SeleccionarTodos();

        [OperationContract]
        int Insertar(ServidorENT servidorENT);

        [OperationContract]
        int Actualizar(ServidorENT servidorENT);

        [OperationContract]
        List<ServidorENT> BuscarServidor(string campo, string texto);
    }
}
