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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UsuarioWcf" en el código y en el archivo de configuración a la vez.
    public class UsuarioWcf : IUsuarioWcf
    {
        UsuarioBLL usuarioBLL;
        
        public bool Ingresar(UsuarioENT usuarioENT)
        {
            usuarioBLL = new UsuarioBLL();
            return usuarioBLL.Ingresar(usuarioENT);
        }

        public List<UsuarioENT> SelecccionarUsuario()
        {
            usuarioBLL = new UsuarioBLL();
            return usuarioBLL.SelecccionarUsuario();
        }
    }
}
