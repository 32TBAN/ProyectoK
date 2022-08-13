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
        public static bool Eliminar(int id, int idTecnico)
        {
            return AsignacionesDatos.Eliminar(id,idTecnico);
        }

        public static Asignaciones Guardar(Asignaciones asignacion)
        {
            return AsignacionesDatos.Guardar(asignacion);
        }

        public static List<Asignaciones> ListaAsignacionTerminada()
        {
            return AsignacionesDatos.ListaAsignacionTerminada();
        }
    }
}
