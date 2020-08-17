using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace ServiciosWcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuarioWcf" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuarioWcf
    {
        [OperationContract]
        bool Ingresar(UsuarioENT usuarioENT);

        [OperationContract]
        List<UsuarioENT> SelecccionarUsuario();
    }
}
