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
        public static Asignaciones Guardar(Asignaciones asignacion)
        {
            return AsignacionesDatos.Guardar(asignacion);
        }
    }
}
