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
    public class ProveedorWcf : IProveedorWcf
    {        
        ProveedorBLL proveedorBLL;

        public List<ProveedorENT> SeleccionarTodos()
        {
            proveedorBLL = new ProveedorBLL();
            return proveedorBLL.SeleccionarTodos();
        }

        public int Insertar(ProveedorENT proveedorENT)
        {
            proveedorBLL = new ProveedorBLL();
            return proveedorBLL.Insertar(proveedorENT);
        }

        public int Actualizar(ProveedorENT proveedorENT)
        {
            proveedorBLL = new ProveedorBLL();
            return proveedorBLL.Actualizar(proveedorENT);
        }

        public List<ProveedorENT> SeleccionarProveedor()
        {
            proveedorBLL = new ProveedorBLL();
            return proveedorBLL.SeleccionarProveedor();
        }

        public List<ProveedorENT> BuscarProveedor(string campo, string texto)
        {
            proveedorBLL = new ProveedorBLL();

            return proveedorBLL.BuscarProveedor(campo, texto);
        }
    }
}
