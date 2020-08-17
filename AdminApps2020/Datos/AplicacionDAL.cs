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
    public class AplicacionDAL
    {
        SqlConnection conexion;
        SqlDataReader lector;
        SqlCommand comando;
        int res;
        string sql; 

        public List<AplicacionENT> SelecccionarTodos()
        {
            List<AplicacionENT> lstAplicacionENT = new List<AplicacionENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select * from APLICACION_VIEW", conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        AplicacionENT aplicacionENT = new AplicacionENT()
                        {
                            Proveedor = lector.GetString(0),
                            Servidor = lector.GetString(1),
                            Ip = lector.GetString(2),
                            Ambiente = lector.GetString(3),
                            Aplicacion = lector.GetString(4),
                            Descripcion = lector.GetString(5),
                            Tipo = lector.GetString(6),
                            Administrador = lector.GetString(7), 
                            Observaciones = lector.GetString(8),
                            ProveedorId = lector.GetInt32(9),
                            ServidorId = lector.GetInt32(10),
                            Estado = lector.GetBoolean(11),
                            Id = lector.GetInt32(12)
                        };
                        lstAplicacionENT.Add(aplicacionENT);
                    }
                }
            }
            return lstAplicacionENT;
        }

        public List<AplicacionENT> SelecccionarAplicacion(int ProveedorId)
        {
            List<AplicacionENT> lstAplicacionENT = new List<AplicacionENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select * from APLICACION_VIEW where ProveedorId=@ProveedorId", conexion))
                {
                    comando.Parameters.AddWithValue("@ProveedorId", ProveedorId);
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        AplicacionENT aplicacionENT = new AplicacionENT()
                        {
                            Proveedor = lector.GetString(0),
                            Servidor = lector.GetString(1),
                            Ip = lector.GetString(2),
                            Ambiente = lector.GetString(3),
                            Aplicacion = lector.GetString(4),
                            Descripcion = lector.GetString(5),
                            Tipo = lector.GetString(6),
                            Administrador = lector.GetString(7),
                            Observaciones = lector.GetString(8),
                            ProveedorId = lector.GetInt32(9),
                            ServidorId = lector.GetInt32(10),
                            Estado = lector.GetBoolean(11),
                            Id = lector.GetInt32(12)
                        };
                        lstAplicacionENT.Add(aplicacionENT);
                    }
                }
            }
            return lstAplicacionENT;
        }

        public int Insertar(AplicacionENT aplicacionENT)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand("insert into aplicacion(nombre, descripcion, tipo, administrador, observaciones, proveedorId, ServidorId, estado) values(@nombre, @descripcion, @tipo, @administrador, @observaciones, @proveedorId, @ServidorId, @estado)", conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", aplicacionENT.Aplicacion);
                    comando.Parameters.AddWithValue("@descripcion", aplicacionENT.Descripcion);
                    comando.Parameters.AddWithValue("@tipo", aplicacionENT.Tipo);
                    comando.Parameters.AddWithValue("@administrador", aplicacionENT.Administrador);
                    comando.Parameters.AddWithValue("@observaciones", aplicacionENT.Observaciones);
                    comando.Parameters.AddWithValue("@proveedorId", aplicacionENT.ProveedorId);
                    comando.Parameters.AddWithValue("@servidorId", aplicacionENT.ServidorId);
                    comando.Parameters.AddWithValue("@estado", aplicacionENT.Estado);

                    conexion.Open();
                    res = comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            return res;
        }

        public int Actualizar(AplicacionENT aplicacionENT)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand("update aplicacion set nombre=@nombre, descripcion=@descripcion, tipo=@tipo, administrador=@administrador, observaciones=@observaciones, proveedorId=@proveedorId, ServidorId=@ServidorId, estado=@estado where id=@id", conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", aplicacionENT.Aplicacion);
                    comando.Parameters.AddWithValue("@descripcion", aplicacionENT.Descripcion);
                    comando.Parameters.AddWithValue("@tipo", aplicacionENT.Tipo);
                    comando.Parameters.AddWithValue("@administrador", aplicacionENT.Administrador);
                    comando.Parameters.AddWithValue("@observaciones", aplicacionENT.Observaciones);
                    comando.Parameters.AddWithValue("@proveedorId", aplicacionENT.ProveedorId);
                    comando.Parameters.AddWithValue("@servidorId", aplicacionENT.ServidorId);
                    comando.Parameters.AddWithValue("@estado", aplicacionENT.Estado);
                    comando.Parameters.AddWithValue("@id", aplicacionENT.Id);

                    conexion.Open();
                    res = comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            return res;
        }

        public List<ProveedorENT> SeleccionarProveedor()
        {
            List<ProveedorENT> lstProveedor = new List<ProveedorENT>();
            ProveedorDAL proveedorDAL = new ProveedorDAL();

            lstProveedor = proveedorDAL.SeleccionarProveedor();

            return lstProveedor;
        }

        public List<ServidorENT> SeleccionarServidor()
        {
            List<ServidorENT> lstServidor = new List<ServidorENT>();
            ServidorDAL servidorDAL = new ServidorDAL();

            lstServidor = servidorDAL.SeleccionarServidor();

            return lstServidor;
        }

        public List<AplicacionENT> BuscarAplicacion(string campo, string texto)
        {
            List<AplicacionENT> lstAplicacion = new List<AplicacionENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();
                sql = "select * from aplicacion_view where " + campo + " like '%" + texto + "%' ";

                using (comando = new SqlCommand(sql, conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        AplicacionENT aplicacionENT = new AplicacionENT()
                        {
                            Proveedor = lector.GetString(0),
                            Servidor = lector.GetString(1),
                            Ip = lector.GetString(2),
                            Ambiente = lector.GetString(3),
                            Aplicacion = lector.GetString(4),
                            Descripcion = lector.GetString(5),
                            Tipo = lector.GetString(6),
                            Administrador = lector.GetString(7),
                            Observaciones = lector.GetString(8),
                            Estado = lector.GetBoolean(9),
                            Id = lector.GetInt32(10)
                        };
                        lstAplicacion.Add(aplicacionENT);
                    }
                }
            }
            return lstAplicacion;
        }
    }
}
