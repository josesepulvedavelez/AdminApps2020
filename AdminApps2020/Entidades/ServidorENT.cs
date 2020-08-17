using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ServidorENT
    {
        public string Nombre { get; set; }
        public string Ip { get; set; }
        public string Usuario { get; set; }
        public string Pw { get; set; }
        public string Ambiente { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public string Tipo { get; set; }
        public bool Estado { get; set; }
        public int Id { get; set; }
    }
}
