using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ActividadDetalleInformeENT
    {
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Aplicacion { get; set; }
        public string usuario { get; set; }
        public string Estado { get; set; }
        public int Id { get; set; }
        public DateTime FechaDet { get; set; }
        public string DescripcionDet { get; set; }
        public string Observaciones { get; set; }
    }
}
