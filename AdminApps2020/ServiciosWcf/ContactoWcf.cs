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
    public class ContactoWcf : IContactoWcf
    {
        ContactoBLL contactoBLL; 

        public List<ContactoENT> SeleccionarTodos()
        {
            contactoBLL = new ContactoBLL();

            return contactoBLL.SeleccionarTodos();
        }

        public List<ContactoENT> SeleccionarContacto(int ProveedorId)
        {
            contactoBLL = new ContactoBLL();

            return contactoBLL.SeleccionarContacto(ProveedorId);
        }

        public int Insertar(ContactoENT contactoENT)
        {
            contactoBLL = new ContactoBLL();

            return contactoBLL.Insertar(contactoENT);
        }

        public int Actualizar(ContactoENT contactoENT)
        {
            contactoBLL = new ContactoBLL();

            return contactoBLL.Actualizar(contactoENT);
        }

        public List<ProveedorENT> SeleccionarProveedor()
        {
            contactoBLL = new ContactoBLL();

            return contactoBLL.SeleccionarProveedor();
        }

        public List<ContactoENT> BuscarContacto(string campo, string texto)
        {
            contactoBLL = new ContactoBLL();

            return contactoBLL.BuscarContacto(campo, texto);
        }
    }
}
