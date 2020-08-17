using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AplicacionBLL
    {
        AplicacionDAL aplicacionDAL;
        List<AplicacionENT> lstAplicacion;
        List<ProveedorENT> lstProveedor;
        List<ServidorENT> lstServidor;
        int res;

        public List<AplicacionENT> SeleccionarTodos()
        {
            aplicacionDAL = new AplicacionDAL();
            lstAplicacion = aplicacionDAL.SelecccionarTodos();

            return lstAplicacion;
        }

        public List<AplicacionENT> SelecccionarAplicacion(int ProveedorId)
        {
            aplicacionDAL = new AplicacionDAL();
            lstAplicacion = aplicacionDAL.SelecccionarAplicacion(ProveedorId);

            return lstAplicacion;
        }

        public int Insertar(AplicacionENT aplicacionENT)
        {
            aplicacionDAL = new AplicacionDAL();
            res = aplicacionDAL.Insertar(aplicacionENT);

            return res; 
        }

        public int Actualizar(AplicacionENT aplicacionENT)
        {
            aplicacionDAL = new AplicacionDAL();
            res = aplicacionDAL.Actualizar(aplicacionENT);

            return res;
        }

        public List<ProveedorENT> SeleccionarProveedor()
        {
            aplicacionDAL = new AplicacionDAL();
            lstProveedor = aplicacionDAL.SeleccionarProveedor();

            return lstProveedor;
        }

        public List<ServidorENT> SeleccionarServidor()
        {
            aplicacionDAL = new AplicacionDAL();
            lstServidor = aplicacionDAL.SeleccionarServidor();

            return lstServidor;
        }

        public List<AplicacionENT> BuscarAplicacion(string campo, string texto)
        {
            aplicacionDAL = new AplicacionDAL();
            lstAplicacion = aplicacionDAL.BuscarAplicacion(campo, texto);

            return lstAplicacion;
        }
    }
}
