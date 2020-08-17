using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ProveedorBLL
    {        
        ProveedorDAL ProveedorDAL;
        List<ProveedorENT> lstProveedor;
        int res; 

        public List<ProveedorENT> SeleccionarTodos()
        {            
            ProveedorDAL = new ProveedorDAL();
            lstProveedor = ProveedorDAL.SeleccionarTodos();

            return lstProveedor;
        }

        public int Insertar(ProveedorENT proveedorENT)
        {
            ProveedorDAL = new ProveedorDAL();

            res = ProveedorDAL.Insertar(proveedorENT);
            return res;
        }

        public int Actualizar(ProveedorENT proveedorENT)
        {
            ProveedorDAL = new ProveedorDAL();

            res = ProveedorDAL.Actualizar(proveedorENT);
            return res;
        }

        public List<ProveedorENT> SeleccionarProveedor()
        {
            ProveedorDAL = new ProveedorDAL();

            lstProveedor = ProveedorDAL.SeleccionarProveedor();
            return lstProveedor;
        }

        public List<ProveedorENT> BuscarProveedor(string campo, string texto)
        {
            ProveedorDAL = new ProveedorDAL();

            lstProveedor = ProveedorDAL.BuscarProveedor(campo, texto);

            return lstProveedor;
        }
    }
}
