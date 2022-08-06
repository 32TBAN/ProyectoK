using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class UsuarioDatos : Conexion
    {
        public static UsuarioEntidad BuscarUsuarioEmail(string texts)
        {
            try
            {
                UsuarioEntidad usuarioEntidad = new UsuarioEntidad();

                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("BuscarUsuario",connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("email", OracleType.VarChar).Value = texts;
                        cmd.Parameters.Add("buscar", OracleType.Cursor).Direction = ParameterDirection.Output;

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                usuarioEntidad.Id = Convert.ToInt16(dr["ID"].ToString());
                                usuarioEntidad.Cedula = dr["CEDULA"].ToString();
                                usuarioEntidad.Nombre = dr["NOMBRE"].ToString();
                                usuarioEntidad.Apellido = dr["APELLIDO"].ToString();
                                usuarioEntidad.Email = dr["EMAIL"].ToString();
                                usuarioEntidad.Perfil = dr["PERFIL"].ToString();
                                usuarioEntidad.Contraseña = dr["CONTRASE"].ToString();
                            }
                        }
                     
                    }
                }

                return usuarioEntidad;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string RecuperarContraseña(string text)
        {
            try
            {
                UsuarioEntidad usuarioEntidad = BuscarUsuarioEmail(text);

                if (usuarioEntidad.Id == 0)
                {
                    return "No existe el nombre de usuario: " + text +
                        " Verifique e intente de nuevo";
                }
                string nombre = usuarioEntidad.Nombre;
                string mail = usuarioEntidad.Email;
                string contraseña = usuarioEntidad.Contraseña;

                var servicioMail = new MensajesEmail.SoporteEmail();
                servicioMail.sendMail(
                    sujeto: "SYSTEM: Recuperacion de contraseña",
                    boby: "Hola " + nombre +
                    "\nTe recordamos que tu contraseña es:" + contraseña,
                    recipienteMail: new List<string> { mail });

                return "Se ha enviado un mensaje a su correo";
            }
            catch (Exception)
            {
                return "Error no se ha encontrado su correo";
            }
        }
    }
}
