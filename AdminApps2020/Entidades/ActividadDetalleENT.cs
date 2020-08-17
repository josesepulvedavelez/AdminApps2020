using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ActividadDetalleENT
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Minutos { get; set; }
        public string Responsable { get; set; }
        public string Observaciones { get; set; }
        public int ActividadId { get; set; }
        public int Id { get; set; }
    }
}
