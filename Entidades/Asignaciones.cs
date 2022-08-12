using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asignaciones
    {
        public int IdSolicitud { get; set; }
        public int IdTecnico { get; set; }
        public string Respuesta { get; set; }
        public bool Terminada { get; set; }
        public float Total { get; set; }
        public Asignaciones()
        {

        }

        public Asignaciones(int idSolicitud, int idTecnico, string respuesta, bool terminada, float total)
        {
            IdSolicitud = idSolicitud;
            IdTecnico = idTecnico;
            Respuesta = respuesta;
            Terminada = terminada;
            Total = total;
        }
    }
}
