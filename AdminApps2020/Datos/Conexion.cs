﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Datos
{
    public class Conexion
    {
        public static string Conectar()
        {
            string cnx = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;            
            return cnx;
        }
    }
}
