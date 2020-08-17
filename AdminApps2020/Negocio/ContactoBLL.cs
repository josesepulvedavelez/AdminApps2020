using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class ContactoBLL
    {
        ContactoDAL contactoDAL;
        List<ContactoENT> lstContacto;
        List<ProveedorENT> lstProveedor;
        int res;

        public List<ContactoENT> SeleccionarTodos()
        {
            contactoDAL = new ContactoDAL();
            lstContacto = contactoDAL.SeleccionarTodos();

            return lstContacto;
        }

        public List<ContactoENT> SeleccionarContacto(int ProveedorId)
        {
            contactoDAL = new ContactoDAL();
            lstContacto = contactoDAL.SeleccionarContacto(ProveedorId);

            return lstContacto;
        }

        public int Insertar(ContactoENT contactoENT)
        {
            contactoDAL = new ContactoDAL();
            res = contactoDAL.Insertar(contactoENT);

            return res;
        }

        public int Actualizar(ContactoENT contactoENT)
        {
            contactoDAL = new ContactoDAL();
            res = contactoDAL.Actualizar(contactoENT);

            return res;
        }

        public List<ProveedorENT> SeleccionarProveedor()
        {
            contactoDAL = new ContactoDAL();
            lstProveedor = contactoDAL.SeleccionarProveedor();

            return lstProveedor;
        }

        public List<ContactoENT> BuscarContacto(string campo, string texto)
        {
            contactoDAL = new ContactoDAL();
            lstContacto = contactoDAL.BuscarContacto(campo, texto);

            return lstContacto;
        }
    }
}
