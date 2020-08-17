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
    public class ActividadDetalleInformeDAL
    {
        SqlConnection conexion;
        SqlDataReader lector;
        SqlCommand comando;
        string sql; 

        public List<ActividadDetalleInformeENT> SeleccionarTodos()
        {
            List<ActividadDetalleInformeENT> lstActividadDetalleInforme = new List<ActividadDetalleInformeENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select * from ACTIVIDADINFORME_VIEW order by fecha desc, id, fechaDet desc", conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ActividadDetalleInformeENT actividadDetalleInformeENT = new ActividadDetalleInformeENT()
                        {
                            Fecha = Convert.ToDateTime(lector["Fecha"]),
                            Tipo = Convert.ToString(lector["Tipo"]),
                            Nombre = Convert.ToString(lector["Nombre"]),
                            Descripcion = Convert.ToString(lector["Descripcion"]),
                            Aplicacion = Convert.ToString(lector["Aplicacion"]),
                            usuario = Convert.ToString(lector["Usuario"]),
                            Id = Convert.ToInt32(lector["Id"]),
                            FechaDet = Convert.ToDateTime(lector["FechaDet"]),
                            DescripcionDet = Convert.ToString(lector["DescripcionDet"]),
                            Observaciones = Convert.ToString(lector["Observaciones"])
                        };
                        lstActividadDetalleInforme.Add(actividadDetalleInformeENT);
                    }
                }
            }
            return lstActividadDetalleInforme;
        }

        public List<ActividadDetalleInformeENT> BuscarActividadDetalleInforme(string campo, string texto)
        {
            List<ActividadDetalleInformeENT> lstActividadDetalleInformeENT = new List<ActividadDetalleInformeENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                sql = "select * from ACTIVIDADINFORME_VIEW where " + campo + " like '%" + texto + "%' ";

                using (comando = new SqlCommand(sql, conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ActividadDetalleInformeENT actividadDetalleInformeENT = new ActividadDetalleInformeENT()
                        {
                            Fecha = Convert.ToDateTime(lector["Fecha"]),
                            Tipo = Convert.ToString(lector["Tipo"]),
                            Nombre = Convert.ToString(lector["Nombre"]),
                            Descripcion = Convert.ToString(lector["Descripcion"]),
                            Aplicacion = Convert.ToString(lector["Aplicacion"]),
                            usuario = Convert.ToString(lector["Usuario"]),
                            Id = Convert.ToInt32(lector["Id"]),
                            FechaDet = Convert.ToDateTime(lector["FechaDet"]),
                            DescripcionDet = Convert.ToString(lector["DescripcionDet"]),
                            Observaciones = Convert.ToString(lector["Observaciones"])
                        };
                        lstActividadDetalleInformeENT.Add(actividadDetalleInformeENT);
                    }
                }
            }
            return lstActividadDetalleInformeENT;
        }

        public List<ActividadDetalleInformeENT> BuscarActividadFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            List<ActividadDetalleInformeENT> lstActividadDetalleInformeENT = new List<ActividadDetalleInformeENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                sql = "select * from ACTIVIDADINFORME_VIEW where fecha between @fechaInicio and @fechaFinal";

                using (comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    comando.Parameters.AddWithValue("@fechaFInal", fechaFinal);

                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ActividadDetalleInformeENT actividadDetalleInformeENT = new ActividadDetalleInformeENT()
                        {
                            Fecha = Convert.ToDateTime(lector["Fecha"]),
                            Tipo = Convert.ToString(lector["Tipo"]),
                            Nombre = Convert.ToString(lector["Nombre"]),
                            Descripcion = Convert.ToString(lector["Descripcion"]),
                            Aplicacion = Convert.ToString(lector["Aplicacion"]),
                            usuario = Convert.ToString(lector["Usuario"]),
                            Id = Convert.ToInt32(lector["Id"]),
                            FechaDet = Convert.ToDateTime(lector["FechaDet"]),
                            DescripcionDet = Convert.ToString(lector["DescripcionDet"]),
                            Observaciones = Convert.ToString(lector["Observaciones"])
                        };
                        lstActividadDetalleInformeENT.Add(actividadDetalleInformeENT);
                    }
                }
            }
            return lstActividadDetalleInformeENT;
        }

    }
}
