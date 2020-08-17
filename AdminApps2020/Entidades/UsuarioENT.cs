using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioENT
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nivel { get; set; }
        public bool Estado { get; set; }
        public int Id { get; set; }
    }
}
