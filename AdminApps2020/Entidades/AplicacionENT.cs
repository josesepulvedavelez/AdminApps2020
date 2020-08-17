using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AplicacionENT
    {
        public string Proveedor { get; set; }
        public string Servidor { get; set; }
        public string Ip { get; set; }
        public string Ambiente { get; set; }
        public string Aplicacion { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public string Administrador { get; set; }
        public string Observaciones { get; set; }

        public int ProveedorId { get; set; }
        public int ServidorId { get; set; }

        public bool Estado { get; set; }
        public int Id { get; set; }
    }
}
