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
    public class ActividadDAL
    {
        SqlConnection conexion;
        SqlDataReader lector;
        SqlCommand comando;
        int res;
        string sql; 

        public List<ActividadENT> SeleccionarTodos()
        {
            List<ActividadENT> lstActividad = new List<ActividadENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select * from actividad", conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ActividadENT actividadENT = new ActividadENT()
                        {
                            Fecha = Convert.ToDateTime(lector["fecha"]),
                            Tipo = Convert.ToString(lector["tipo"]),
                            Nombre = Convert.ToString(lector["nombre"]),
                            Descripcion = Convert.ToString(lector["descripcion"]),
                            Aplicacion = Convert.ToString(lector["aplicacion"]),
                            Usuario = Convert.ToString(lector["usuario"]),
                            Estado = Convert.ToString(lector["estado"]),
                            Id = Convert.ToInt32(lector["id"])
                        };
                        lstActividad.Add(actividadENT);
                    }
                }
            }
            return lstActividad;
        }

        public List<ActividadENT> SeleccionarUsuario()
        {
            List<ActividadENT> lstActividad = new List<ActividadENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select usuario, id from actividad", conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ActividadENT actividadENT = new ActividadENT()
                        {                            
                            Usuario = Convert.ToString(lector["usuario"]),                            
                            Id = Convert.ToInt32(lector["id"])
                        };
                        lstActividad.Add(actividadENT);
                    }
                }
            }
            return lstActividad;
        }

        public int Insertar(ActividadENT actividadENT)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand("insert into actividad(fecha, tipo, nombre, descripcion, aplicacion, usuario, estado) values(@fecha, @tipo, @nombre, @descripcion, @aplicacion, @usuario, @estado)", conexion))
                {
                    comando.Parameters.AddWithValue("@fecha", actividadENT.Fecha);
                    comando.Parameters.AddWithValue("@tipo", actividadENT.Tipo);
                    comando.Parameters.AddWithValue("@nombre", actividadENT.Nombre);
                    comando.Parameters.AddWithValue("@descripcion", actividadENT.Descripcion);
                    comando.Parameters.AddWithValue("@aplicacion", actividadENT.Aplicacion);
                    comando.Parameters.AddWithValue("@usuario", actividadENT.Usuario);
                    comando.Parameters.AddWithValue("@estado", actividadENT.Estado);

                    conexion.Open();
                    res = comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            return res; 
        }

        public int Actualizar(ActividadENT actividadENT)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand("update actividad set fecha=@fecha, tipo=@tipo, nombre=@nombre, descripcion=@descripcion, aplicacion=@aplicacion, usuario=@usuario, estado=@estado where id=@id", conexion))
                {
                    comando.Parameters.AddWithValue("@fecha", actividadENT.Fecha);
                    comando.Parameters.AddWithValue("@tipo", actividadENT.Tipo);
                    comando.Parameters.AddWithValue("@nombre", actividadENT.Nombre);
                    comando.Parameters.AddWithValue("@descripcion", actividadENT.Descripcion);
                    comando.Parameters.AddWithValue("@aplicacion", actividadENT.Aplicacion);
                    comando.Parameters.AddWithValue("@usuario", actividadENT.Usuario);
                    comando.Parameters.AddWithValue("@estado", actividadENT.Estado);
                    comando.Parameters.AddWithValue("@id", actividadENT.Id);

                    conexion.Open();
                    res = comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            return res;
        }

        public List<ActividadENT> BuscarActividad(string campo, string texto)
        {
            List<ActividadENT> lstActividadENT = new List<ActividadENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                sql = "select * from actividad where " + campo + " like '%" + texto + "%' ";

                using (comando = new SqlCommand(sql, conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ActividadENT actividadENT = new ActividadENT()
                        {
                            Fecha = Convert.ToDateTime(lector["fecha"]),
                            Tipo = Convert.ToString(lector["tipo"]),
                            Nombre = Convert.ToString(lector["nombre"]),
                            Descripcion = Convert.ToString(lector["descripcion"]),
                            Aplicacion = Convert.ToString(lector["aplicacion"]),
                            Usuario = Convert.ToString(lector["usuario"]),
                            Estado = Convert.ToString(lector["estado"]),
                            Id = Convert.ToInt32(lector["id"])
                        };
                        lstActividadENT.Add(actividadENT);
                    }
                }
            }
            return lstActividadENT;
        }

        public List<ActividadENT> BuscarActividadFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            List<ActividadENT> lstActividadENT = new List<ActividadENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                sql = "select * from actividad where fecha between @fechaInicio and @fechaFinal";

                using (comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    comando.Parameters.AddWithValue("@fechaFInal", fechaFinal);

                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ActividadENT actividadENT = new ActividadENT()
                        {
                            Fecha = Convert.ToDateTime(lector["fecha"]),
                            Tipo = Convert.ToString(lector["tipo"]),
                            Nombre = Convert.ToString(lector["nombre"]),
                            Descripcion = Convert.ToString(lector["descripcion"]),
                            Aplicacion = Convert.ToString(lector["aplicacion"]),
                            Usuario = Convert.ToString(lector["usuario"]),
                            Estado = Convert.ToString(lector["estado"]),
                            Id = Convert.ToInt32(lector["id"])
                        };
                        lstActividadENT.Add(actividadENT);
                    }
                }
            }
            return lstActividadENT;
        }

    }
}
