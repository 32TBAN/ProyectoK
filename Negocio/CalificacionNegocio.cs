using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class CalificacionNegocio
    {
        public static CalificacionEntidad Calificar(CalificacionEntidad calificacionEntidad)
        {
            return CalificacionDatos.Calificar(calificacionEntidad);
        }

        public static CalificacionEntidad SolicitudCal(int id)
        {
            return CalificacionDatos.SolicitudCal(id);
        }
    }
}
