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
    public class ContactoDAL
    {
        SqlConnection conexion;
        SqlDataReader lector;
        SqlCommand comando;
        int res;
        string sql; 

        public List<ContactoENT> SeleccionarTodos()
        {
            List<ContactoENT> lstContacto = new List<ContactoENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select * from contacto_view order by proveedor, nombres", conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ContactoENT contactoENT = new ContactoENT()
                        {
                            Proveedor = lector.GetString(0),
                            Nombres = lector.GetString(1),
                            Cargo = lector.GetString(2),
                            Telefonos = lector.GetString(3),
                            Ext = lector.GetString(4),
                            Celulares = lector.GetString(5),
                            Observaciones = lector.GetString(6),
                            Correos = lector.GetString(7),
                            Vpn = lector.GetString(8),
                            ProveedorId = lector.GetInt32(9),
                            Estado = lector.GetBoolean(10),
                            Id = lector.GetInt32(11)
                        };
                        lstContacto.Add(contactoENT);
                    }
                }
            }
            return lstContacto;
        }

        public List<ContactoENT> SeleccionarContacto(int ProveedorId)
        {
            List<ContactoENT> lstContacto = new List<ContactoENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();

                using (comando = new SqlCommand("select * from contacto_view where ProveedorId=@ProveedorId order by proveedor, nombres", conexion))
                {
                    comando.Parameters.AddWithValue("@ProveedorId", ProveedorId);
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        ContactoENT contactoENT = new ContactoENT()
                        {
                            Proveedor = lector.GetString(0),
                            Nombres = lector.GetString(1),
                            Cargo = lector.GetString(2),
                            Telefonos = lector.GetString(3),
                            Ext = lector.GetString(4),
                            Celulares = lector.GetString(5),
                            Observaciones = lector.GetString(6),
                            Correos = lector.GetString(7),
                            Vpn = lector.GetString(8),
                            ProveedorId = lector.GetInt32(9),
                            Estado = lector.GetBoolean(10),
                            Id = lector.GetInt32(11)
                        };
                        lstContacto.Add(contactoENT);
                    }
                }
            }
            return lstContacto;
        }

        public int Insertar(ContactoENT contactoENT)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand("insert into contacto(nombres, cargo, telefonos, ext, celulares, observaciones, correos, Vpn, proveedorId, estado) values(@nombres, @cargo, @telefonos, @ext, @celulares, @observaciones, @correos, @Vpn, @proveedorId, @estado)", conexion))
                {                    
                    comando.Parameters.AddWithValue("@nombres", contactoENT.Nombres);
                    comando.Parameters.AddWithValue("@cargo", contactoENT.Cargo);
                    comando.Parameters.AddWithValue("@telefonos", contactoENT.Telefonos);
                    comando.Parameters.AddWithValue("@ext", contactoENT.Ext);
                    comando.Parameters.AddWithValue("@celulares", contactoENT.Celulares);
                    comando.Parameters.AddWithValue("@observaciones", contactoENT.Observaciones);
                    comando.Parameters.AddWithValue("@correos", contactoENT.Correos);
                    comando.Parameters.AddWithValue("@Vpn", contactoENT.Vpn);
                    comando.Parameters.AddWithValue("@proveedorId", contactoENT.ProveedorId);
                    comando.Parameters.AddWithValue("@estado", contactoENT.Estado);
                    
                    conexion.Open();
                    res = comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            return res;
        }

        public int Actualizar(ContactoENT contactoENT)
        {
            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                using (comando = new SqlCommand("update contacto set nombres=@nombres, cargo=@cargo, telefonos=@telefonos, ext=@ext, celulares=@celulares, observaciones=@observaciones, correos=@correos, Vpn=@Vpn, proveedorId=@proveedorId, estado=@estado where id=@id", conexion))
                {
                    comando.Parameters.AddWithValue("@nombres", contactoENT.Nombres);
                    comando.Parameters.AddWithValue("@cargo", contactoENT.Cargo);
                    comando.Parameters.AddWithValue("@telefonos", contactoENT.Telefonos);
                    comando.Parameters.AddWithValue("@ext", contactoENT.Ext);
                    comando.Parameters.AddWithValue("@celulares", contactoENT.Celulares);
                    comando.Parameters.AddWithValue("@observaciones", contactoENT.Observaciones);
                    comando.Parameters.AddWithValue("@correos", contactoENT.Correos);
                    comando.Parameters.AddWithValue("@Vpn", contactoENT.Vpn);
                    comando.Parameters.AddWithValue("@proveedorId", contactoENT.ProveedorId);
                    comando.Parameters.AddWithValue("@estado", contactoENT.Estado);
                    comando.Parameters.AddWithValue("@Id", contactoENT.Id);

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

        public List<ContactoENT> BuscarContacto(string campo, string texto)
        {
            List<ContactoENT> lstContacto = new List<ContactoENT>();

            using (conexion = new SqlConnection(Conexion.Conectar()))
            {
                conexion.Open();
                sql = "select * from contacto_view where " + campo + " like '%" + texto + "%' order by proveedor, nombres ";
                
                using (comando = new SqlCommand(sql, conexion))
                {
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                       ContactoENT contactoENT = new ContactoENT()
                        {
                           Proveedor = lector.GetString(0),
                           Nombres = lector.GetString(1),
                           Cargo = lector.GetString(2),
                           Telefonos = lector.GetString(3),
                           Ext = lector.GetString(4),
                           Celulares = lector.GetString(5),
                           Observaciones = lector.GetString(6),
                           Correos = lector.GetString(7),
                           Vpn = lector.GetString(8),
                           ProveedorId = lector.GetInt32(9),
                           Estado = lector.GetBoolean(10),
                           Id = lector.GetInt32(11)
                       };
                       lstContacto.Add(contactoENT);
                    }
                }
            }
            return lstContacto;
        }

    }
}
