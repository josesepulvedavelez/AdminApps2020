using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades; 

namespace Negocio
{
    public class UsuarioBLL
    {
        UsuarioDAL usuarioDAL;
        List<UsuarioENT> lstUsuario;
        bool res;

        public bool Ingresar(UsuarioENT usuarioENT)
        {
            usuarioDAL = new UsuarioDAL();
            res = usuarioDAL.Ingresar(usuarioENT);

            return res;
        }

        public List<UsuarioENT> SelecccionarUsuario()
        {
            usuarioDAL = new UsuarioDAL();
            lstUsuario = usuarioDAL.SelecccionarUsuario();

            return lstUsuario;
        }
    }
}
