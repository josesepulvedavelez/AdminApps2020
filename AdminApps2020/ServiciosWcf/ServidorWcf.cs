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
    public class ServidorWcf : IServidorWcf
    {
        ServidorBLL servidorBLL;

        public List<ServidorENT> SeleccionarTodos()
        {
            servidorBLL = new ServidorBLL();

            return servidorBLL.SeleccionarTodos();
        }

        public int Insertar(ServidorENT servidorENT)
        {
            servidorBLL = new ServidorBLL();

            return servidorBLL.Insertar(servidorENT);
        }

        public int Actualizar(ServidorENT servidorENT)
        {
            servidorBLL = new ServidorBLL();

            return servidorBLL.Actualizar(servidorENT);
        }

        public List<ServidorENT> BuscarServidor(string campo, string texto)
        {
            servidorBLL = new ServidorBLL();

            return servidorBLL.BuscarServidor(campo, texto);
        }
    }
}
