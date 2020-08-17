using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades; 

namespace Datos
{
    public class UsuarioDAL
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        int res;

        public List<UsuarioENT> SelecccionarUsuario()
        {
            List<UsuarioENT> lstusuario = new List<UsuarioENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select usuario, id from usuario", conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        UsuarioENT usuarioENT = new UsuarioENT()
                        {
                            Usuario = Convert.ToString(lector["Usuario"]),
                            Id = Convert.ToInt32(lector["Id"])
                        };
                        lstusuario.Add(usuarioENT);
                    }
                }
            }
            return lstusuario;
        }

        public bool Ingresar(UsuarioENT usuarioENT)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand("select count(*) from usuario where usuario=@usuario and contraseña=@contraseña", conexion))
                {
                    comando.Parameters.AddWithValue("@usuario", usuarioENT.Usuario);
                    comando.Parameters.AddWithValue("@contraseña", usuarioENT.Contraseña);

                    conexion.Open();
                    res = Convert.ToInt16(comando.ExecuteScalar());
                    conexion.Close();
                }
            }

            if (res == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
