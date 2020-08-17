using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using Negocio;

namespace ServiciosWcf
{    
    public class ActividadWcf : IActividadWcf
    {
        ActividadBLL actividadBLL; 

        public List<ActividadENT> SeleccionarTodos()
        {
            actividadBLL = new ActividadBLL();

            return actividadBLL.SeleccionarTodos();
        }

        public List<ActividadENT> SeleccionarUsuario()
        {
            actividadBLL = new ActividadBLL();

            return actividadBLL.SeleccionarUsuario();
        }

        public int Insertar(ActividadENT actividadENT)
        {
            actividadBLL = new ActividadBLL();

            return actividadBLL.Insertar(actividadENT);
        }

        public int Actualizar(ActividadENT actividadENT)
        {
            actividadBLL = new ActividadBLL(); 

            return actividadBLL.Actualizar(actividadENT);
        }

        public List<ActividadENT> BuscarActividad(string campo, string texto)
        {
            actividadBLL = new ActividadBLL();

            return actividadBLL.BuscarActividad(campo, texto);
        }

        public List<ActividadENT> BuscarActividadFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            actividadBLL = new ActividadBLL();

            return actividadBLL.BuscarActividadFecha(fechaInicio, fechaFinal);
        }

    }
}
