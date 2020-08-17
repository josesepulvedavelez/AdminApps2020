using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Datos;

namespace Datos
{
    public class ServidorDAL
    {
        SqlConnection conexion;
        SqlDataReader lector;
        SqlCommand comando;
        int res;
        string sql; 

        public List<ServidorENT> SeleccionarTodos()
        {
            List<ServidorENT> lstServidor = new List<ServidorENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select * from servidor", conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ServidorENT servidorENT = new ServidorENT()
                        {
                            Nombre = Convert.ToString(lector["nombre"]),
                            Ip = Convert.ToString(lector["ip"]),
                            Usuario = Convert.ToString(lector["usuario"]),
                            Pw = Convert.ToString(lector["pw"]),
                            Ambiente = Convert.ToString(lector["ambiente"]),
                            Descripcion = Convert.ToString(lector["descripcion"]),
                            Observaciones = Convert.ToString(lector["observaciones"]),
                            Tipo = Convert.ToString(lector["tipo"]),
                            Estado = Convert.ToBoolean(lector["estado"]),
                            Id = Convert.ToInt16(lector["id"])
                        };
                        lstServidor.Add(servidorENT);
                    }
                }
            }
            return lstServidor;
        }

        public int Insertar(ServidorENT servidorENT)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand("insert into servidor(nombre, ip, usuario, pw, ambiente, descripcion, observaciones, tipo, estado) values(@nombre, @ip, @usuario, @pw, @ambiente, @descripcion, @observaciones, @tipo, @estado)", conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", servidorENT.Nombre);
                    comando.Parameters.AddWithValue("@ip", servidorENT.Ip);
                    comando.Parameters.AddWithValue("@usuario", servidorENT.Usuario);
                    comando.Parameters.AddWithValue("@pw", servidorENT.Pw);
                    comando.Parameters.AddWithValue("@ambiente", servidorENT.Ambiente);
                    comando.Parameters.AddWithValue("@descripcion", servidorENT.Descripcion);
                    comando.Parameters.AddWithValue("@observaciones", servidorENT.Observaciones);
                    comando.Parameters.AddWithValue("@tipo", servidorENT.Tipo);
                    comando.Parameters.AddWithValue("@estado", servidorENT.Estado);

                    conexion.Open();
                    res = comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            return res;
        }

        public int Actualizar(ServidorENT servidorENT)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand("update servidor set nombre=@nombre, ip=@ip, usuario=@usuario, pw=@pw, ambiente=@ambiente, descripcion=@descripcion, observaciones=@observaciones, tipo=@tipo, estado=@estado where id=@id", conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", servidorENT.Nombre);
                    comando.Parameters.AddWithValue("@ip", servidorENT.Ip);
                    comando.Parameters.AddWithValue("@usuario", servidorENT.Usuario);
                    comando.Parameters.AddWithValue("@pw", servidorENT.Pw);
                    comando.Parameters.AddWithValue("@ambiente", servidorENT.Ambiente);
                    comando.Parameters.AddWithValue("@descripcion", servidorENT.Descripcion);
                    comando.Parameters.AddWithValue("@observaciones", servidorENT.Observaciones);
                    comando.Parameters.AddWithValue("@tipo", servidorENT.Tipo);
                    comando.Parameters.AddWithValue("@estado", servidorENT.Estado);
                    comando.Parameters.AddWithValue("@id", servidorENT.Id);

                    conexion.Open();
                    res = comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            return res;
        }

        public List<ServidorENT> SeleccionarServidor()
        {
            List<ServidorENT> lstServidor = new List<ServidorENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select nombre, id from servidor", conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ServidorENT servidorENT = new ServidorENT()
                        {
                            Nombre = Convert.ToString(lector["nombre"]),
                            Id = Convert.ToInt16(lector["id"])
                        };
                        lstServidor.Add(servidorENT);
                    }
                }
            }
            return lstServidor;
        }

        public List<ServidorENT> BuscarServidor(string campo, string texto)
        {
            List<ServidorENT> lstServidorENT = new List<ServidorENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                sql = "select * from servidor where " + campo + " like '%" + texto + "%' ";

                using (comando = new SqlCommand(sql, conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ServidorENT servidorENT = new ServidorENT()
                        {
                            Nombre = Convert.ToString(lector["Nombre"]),
                            Ip = Convert.ToString(lector["Ip"]),
                            Usuario = Convert.ToString(lector["Usuario"]),
                            Pw = Convert.ToString(lector["Pw"]),
                            Ambiente = Convert.ToString(lector["Ambiente"]),
                            Descripcion = Convert.ToString(lector["Descripcion"]),
                            Observaciones = Convert.ToString(lector["Observaciones"]),
                            Tipo = Convert.ToString(lector["Tipo"]),
                            Estado = Convert.ToBoolean(lector["Estado"]),
                            Id = Convert.ToInt16(lector["Id"])
                        };
                        lstServidorENT.Add(servidorENT);
                    }
                }
            }
            return lstServidorENT;
        }
    }
}
