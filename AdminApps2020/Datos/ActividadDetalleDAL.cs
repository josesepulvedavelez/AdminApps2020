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
    public class ActividadDetalleDAL
    {
        SqlConnection conexion;
        SqlDataReader lector;
        SqlCommand comando;
        int res;

        public List<ActividadDetalleENT> SeleccionarTodos(ActividadDetalleENT actividadDetalleENT)
        {
            List<ActividadDetalleENT> lstActividadDetalle = new List<ActividadDetalleENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select * from actividaddetalle where actividadid=@actividadid", conexion))
                {
                    comando.Parameters.AddWithValue("@actividadid", actividadDetalleENT.ActividadId); 

                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ActividadDetalleENT ad = new ActividadDetalleENT()
                        {
                            Fecha = Convert.ToDateTime(lector["fecha"]),
                            Descripcion = Convert.ToString(lector["descripcion"]),
                            Minutos = Convert.ToInt32(lector["minutos"]),
                            Responsable = Convert.ToString(lector["responsable"]),
                            Observaciones = Convert.ToString(lector["observaciones"]),
                            ActividadId = Convert.ToInt32(lector["actividadid"]),
                            Id = Convert.ToInt32(lector["id"])
                        };
                        lstActividadDetalle.Add(ad);
                    }
                }
            }
            return lstActividadDetalle;
        }

        public int Insertar(ActividadDetalleENT actividadDetalleENT)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand("insert into actividaddetalle(fecha, descripcion, minutos, responsable, observaciones, actividadid) values(@fecha, @descripcion, @minutos, @responsable, @observaciones, @actividadid)", conexion))
                {
                    comando.Parameters.AddWithValue("@fecha", actividadDetalleENT.Fecha);
                    comando.Parameters.AddWithValue("@descripcion", actividadDetalleENT.Descripcion);
                    comando.Parameters.AddWithValue("@minutos", actividadDetalleENT.Minutos);
                    comando.Parameters.AddWithValue("@responsable", actividadDetalleENT.Responsable);
                    comando.Parameters.AddWithValue("@observaciones", actividadDetalleENT.Observaciones);
                    comando.Parameters.AddWithValue("@actividadid", actividadDetalleENT.ActividadId);

                    conexion.Open();
                    res = comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            return res;
        }

        public int Actualizar(ActividadDetalleENT actividadDetalleENT)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand("update actividaddetalle set fecha=@fecha, descripcion=@descripcion, minutos=@minutos, responsable=@responsable, observaciones=@observaciones, actividadid=@actividadid where id=@id", conexion))
                {
                    comando.Parameters.AddWithValue("@fecha", actividadDetalleENT.Fecha);
                    comando.Parameters.AddWithValue("@descripcion", actividadDetalleENT.Descripcion);
                    comando.Parameters.AddWithValue("@minutos", actividadDetalleENT.Minutos);
                    comando.Parameters.AddWithValue("@responsable", actividadDetalleENT.Responsable);
                    comando.Parameters.AddWithValue("@observaciones", actividadDetalleENT.Observaciones);
                    comando.Parameters.AddWithValue("@actividadid", actividadDetalleENT.ActividadId);
                    comando.Parameters.AddWithValue("@id", actividadDetalleENT.Id);

                    conexion.Open();
                    res = comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            return res;
        }

    }
}
