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

                usuarioEntidad.Perfil = TipoPerfil(usuarioEntidad.Perfil);
 
                return usuarioEntidad;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static UsuarioEntidad Actualizar(UsuarioEntidad usuarioEntidad)
        {
            throw new NotImplementedException();
        }

        public static UsuarioEntidad Guardar(UsuarioEntidad usuarioEntidad)
        {
            try
            {
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("GuardarUsuarios", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("cedulaG", OracleType.VarChar).Value = usuarioEntidad.Cedula;
                        cmd.Parameters.Add("nombreG", OracleType.VarChar).Value = usuarioEntidad.Nombre;
                        cmd.Parameters.Add("apellidoG", OracleType.VarChar).Value = usuarioEntidad.Apellido;
                        cmd.Parameters.Add("emailG", OracleType.VarChar).Value = usuarioEntidad.Email;
                        cmd.Parameters.Add("fotoG", OracleType.Blob).Value = usuarioEntidad.Foto;
                        cmd.Parameters.Add("perfilG", OracleType.VarChar).Value = usuarioEntidad.Perfil;
                        cmd.Parameters.Add("contraseG", OracleType.VarChar).Value = usuarioEntidad.Contraseña;

                        cmd.ExecuteNonQuery();
                    }
                }
                return usuarioEntidad;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static UsuarioEntidad BuscarUsuarioCedula(string texts)
        {
            try
            {
                UsuarioEntidad usuarioEntidad = new UsuarioEntidad();

                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("BuscarUsuarioCedula", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("cedula", OracleType.VarChar).Value = texts;
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

                usuarioEntidad.Perfil = TipoPerfil(usuarioEntidad.Perfil);

                return usuarioEntidad;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static string TipoPerfil(string perfil)
        {
            if (perfil == "G")
            {
                return "Gerente";
            }
            else if (perfil == "J")
            {
                return "Jefe Tecnico";
            }
            else if (perfil == "T")
            {
                return  "Tecnico";
            }
            else if (perfil == "U")
            {
                return "Usuario";
            }
            else
            {
                return "None";
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
