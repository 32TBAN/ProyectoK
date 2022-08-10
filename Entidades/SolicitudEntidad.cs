using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SolicitudEntidad
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdTecnico { get; set; }
        public string Asunto { get; set; }
        public string Descripcion { get; set; }
        public string Urgencia { get; set; }
        public string Dispositivo { get; set; }
        public string Area { get; set; }
        public DateTime Fecha { get; set; }
        public bool Estado { get; set; }
        public SolicitudEntidad()
        {

        }

        public SolicitudEntidad(int id, int idUsuario, int idTecnico, string asunto, string descripcion, string urgencia, string dispositivo, string area, DateTime fecha, bool estado)
        {
            Id = id;
            IdUsuario = idUsuario;
            IdTecnico = idTecnico;
            Asunto = asunto;
            Descripcion = descripcion;
            Urgencia = urgencia;
            Dispositivo = dispositivo;
            Area = area;
            Fecha = fecha;
            Estado = estado;
        }
    }
}
