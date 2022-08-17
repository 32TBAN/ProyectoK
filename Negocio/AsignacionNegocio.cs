using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public static class AsignacionNegocio
    {
        public static AsignacionesEntidad Actualizar(AsignacionesEntidad asignacion)
        {
            return AsignacionesDatos.Actualizar(asignacion);
        }

        public static bool Eliminar(int id, int idTecnico)
        {
            return AsignacionesDatos.Eliminar(id,idTecnico);
        }

        public static AsignacionesEntidad Guardar(AsignacionesEntidad asignacion)
        {
            return AsignacionesDatos.Guardar(asignacion);
        }

        public static List<AsignacionesEntidad> ListaAsignacionTerminada()
        {
            return AsignacionesDatos.ListaAsignacionTerminada();
        }

        public static List<AsignacionesEntidad> ListaTotalSemana(DateTime dateTime, DateTime now)
        {
            return AsignacionesDatos.ListaTotalSemana(dateTime,now);
        }
    }
}
