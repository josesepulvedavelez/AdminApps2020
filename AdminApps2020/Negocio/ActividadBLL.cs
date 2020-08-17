using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos; 

namespace Negocio
{
    public class ActividadBLL
    {
        ActividadDAL actividadDAL;
        List<ActividadENT> lstActividad;
        int res;

        public List<ActividadENT> SeleccionarTodos()
        {
            actividadDAL = new ActividadDAL();
            lstActividad = actividadDAL.SeleccionarTodos();

            return lstActividad;
        }

        public List<ActividadENT> SeleccionarUsuario()
        {
            actividadDAL = new ActividadDAL();
            lstActividad = actividadDAL.SeleccionarUsuario();

            return lstActividad;
        }

        public int Insertar(ActividadENT actividadENT)
        {
            actividadDAL = new ActividadDAL();
            res = actividadDAL.Insertar(actividadENT);

            return res;
        }

        public int Actualizar(ActividadENT actividadENT)
        {
            actividadDAL = new ActividadDAL();
            res = actividadDAL.Actualizar(actividadENT);

            return res;
        }

        public List<ActividadENT> BuscarActividad(string campo, string texto)
        {
            actividadDAL = new ActividadDAL();
            lstActividad = actividadDAL.BuscarActividad(campo, texto);

            return lstActividad;
        }

        public List<ActividadENT> BuscarActividadFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            actividadDAL = new ActividadDAL();
            lstActividad = actividadDAL.BuscarActividadFecha(fechaInicio, fechaFinal);

            return lstActividad;
        }
    }
}
