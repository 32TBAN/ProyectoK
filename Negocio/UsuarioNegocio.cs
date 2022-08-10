using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public static class UsuarioNegocio
    {
        public static UsuarioEntidad BuscarUsuarioEmail(string texts)
        {
            return UsuarioDatos.BuscarUsuarioEmail(texts);
        }

        public static string RecuperarContraseña(string text)
        {
            return UsuarioDatos.RecuperarContraseña(text);
        }

        public static UsuarioEntidad BuscarUsuarioCedula(string texts)
        {
            return UsuarioDatos.BuscarUsuarioCedula(texts);
        }

        public static UsuarioEntidad Guardar(UsuarioEntidad usuarioEntidad)
        {
            if (usuarioEntidad.Id == 0)
                return UsuarioDatos.Guardar(usuarioEntidad);
            else
                return UsuarioDatos.Actualizar(usuarioEntidad);

        }
    }
}
