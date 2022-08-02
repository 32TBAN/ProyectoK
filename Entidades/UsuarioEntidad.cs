using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioEntidad
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public byte[] Foto { get; set; }
        public string Perfil { get; set; }
        public UsuarioEntidad()
        {

        }

        public UsuarioEntidad(int id, string cedula, string nombre, string apellido, string email, byte[] foto, string perfil)
        {
            Id = id;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Foto = foto;
            Perfil = perfil;
        }
    }
}
