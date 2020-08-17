using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ServidorBLL
    {
        ServidorDAL servidorDAL;
        List<ServidorENT> lstServidor;
        int res;

        public List<ServidorENT> SeleccionarTodos()
        {
            servidorDAL = new ServidorDAL();
            lstServidor = servidorDAL.SeleccionarTodos();

            return lstServidor;
        }

        public int Insertar(ServidorENT servidorENT)
        {
            servidorDAL = new ServidorDAL();

            res = servidorDAL.Insertar(servidorENT);
            return res;
        }

        public int Actualizar(ServidorENT servidorENT)
        {
            servidorDAL = new ServidorDAL();

            res = servidorDAL.Actualizar(servidorENT);
            return res;
        }

        public List<ServidorENT> BuscarServidor(string campo, string texto)
        {
            servidorDAL = new ServidorDAL();

            lstServidor = servidorDAL.BuscarServidor(campo, texto);

            return lstServidor;
        }
    }
}
