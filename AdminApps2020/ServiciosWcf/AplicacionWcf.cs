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
    public class AplicacionWcf : IAplicacionWcf
    {
        AplicacionBLL aplicacionBLL;

        public List<AplicacionENT> SeleccionarTodos()
        {
            aplicacionBLL = new AplicacionBLL();

            return aplicacionBLL.SeleccionarTodos();
        }

        public List<AplicacionENT> SelecccionarAplicacion(int ProveedorId)
        {
            aplicacionBLL = new AplicacionBLL();

            return aplicacionBLL.SelecccionarAplicacion(ProveedorId);
        }

        public int Insertar(AplicacionENT aplicacionENT)
        {
            aplicacionBLL = new AplicacionBLL();

            return aplicacionBLL.Insertar(aplicacionENT);
        }

        public int Actualizar(AplicacionENT aplicacionENT)
        {
            aplicacionBLL = new AplicacionBLL();
            return aplicacionBLL.Actualizar(aplicacionENT);
        }

        public List<ProveedorENT> SeleccionarProveedor()
        {
            aplicacionBLL = new AplicacionBLL();

            return aplicacionBLL.SeleccionarProveedor();
        }

        public List<ServidorENT> SeleccionarServidor()
        {
            aplicacionBLL = new AplicacionBLL();

            return aplicacionBLL.SeleccionarServidor();
        }

        public List<AplicacionENT> BuscarAplicacion(string campo, string texto)
        {
            aplicacionBLL = new AplicacionBLL();

            return aplicacionBLL.BuscarAplicacion(campo, texto);
        }
    }
}
