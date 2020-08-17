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
    public class ProveedorDAL
    {
        SqlConnection conexion;
        SqlDataReader lector;
        SqlCommand comando;
        int res;
        string sql;

        public List<ProveedorENT> SeleccionarTodos()
        {
            List<ProveedorENT> lstUsuarioENT = new List<ProveedorENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select * from  proveedor", conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ProveedorENT proveedorENT = new ProveedorENT()
                        {
                            Proveedor = Convert.ToString(lector["proveedor"]),
                            Nit = Convert.ToString(lector["nit"]),
                            Observaciones = Convert.ToString(lector["Observaciones"]),
                            Estado = Convert.ToBoolean(lector["Estado"]),
                            Id = Convert.ToInt16(lector["Id"])
                        };
                        lstUsuarioENT.Add(proveedorENT);
                    }
                }
            }
            return lstUsuarioENT;
        }

        public int Insertar(ProveedorENT proveedorENT)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand("insert into proveedor(proveedor, nit, observaciones, estado) values(@proveedor, @nit, @observaciones, @estado)", conexion))
                {
                    comando.Parameters.AddWithValue("@proveedor", proveedorENT.Proveedor);
                    comando.Parameters.AddWithValue("@nit", proveedorENT.Nit);
                    comando.Parameters.AddWithValue("@observaciones", proveedorENT.Observaciones);
                    comando.Parameters.AddWithValue("@estado", proveedorENT.Estado);

                    conexion.Open();
                    res = comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            return res;
        }

        public int Actualizar(ProveedorENT proveedorENT)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand("update proveedor set proveedor=@proveedor, nit=@nit, observaciones=@observaciones, estado=@estado where id=@id", conexion))
                {
                    comando.Parameters.AddWithValue("@proveedor", proveedorENT.Proveedor);
                    comando.Parameters.AddWithValue("@nit", proveedorENT.Nit);
                    comando.Parameters.AddWithValue("@observaciones", proveedorENT.Observaciones);
                    comando.Parameters.AddWithValue("@estado", proveedorENT.Estado);
                    comando.Parameters.AddWithValue("@id", proveedorENT.Id);

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

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select proveedor, id from proveedor", conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ProveedorENT proveedorENT = new ProveedorENT()
                        {
                            Proveedor = Convert.ToString(lector["proveedor"]),
                            Id = Convert.ToInt32(lector["id"])
                        };
                        lstProveedor.Add(proveedorENT);
                    }
                }
            }
            return lstProveedor;
        }

        public List<ProveedorENT> BuscarProveedor(string campo, string texto)
        {            
            List<ProveedorENT> lstUsuarioENT = new List<ProveedorENT>();                        
                                    
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                sql = "select * from proveedor where " + campo + " like '%" + texto + "%' ";

                using (comando = new SqlCommand(sql, conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ProveedorENT proveedorENT = new ProveedorENT()
                        {
                            Proveedor = Convert.ToString(lector["proveedor"]),
                            Nit = Convert.ToString(lector["nit"]),
                            Observaciones = Convert.ToString(lector["Observaciones"]),
                            Estado = Convert.ToBoolean(lector["Estado"]),
                            Id = Convert.ToInt16(lector["Id"])
                        };
                        lstUsuarioENT.Add(proveedorENT);
                    }
                }
            }
            return lstUsuarioENT;
        }

        

    }
}
