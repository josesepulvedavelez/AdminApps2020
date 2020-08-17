using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContactoENT
    {
        public string Proveedor { get; set; }
        public string Nombres { get; set; }
        public string Cargo { get; set; }
        public string Telefonos { get; set; }
        public string Ext { get; set; }
        public string Celulares { get; set; }
        public string Observaciones { get; set; }
        public string Correos { get; set; }
        public string Vpn { get; set; }
        public int ProveedorId { get; set; }
        public bool Estado { get; set; }
        public int Id { get; set; }
    }
}
