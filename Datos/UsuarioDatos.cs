using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
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
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = @"";

                        cmd.Parameters.AddWithValue("",texts);
                    }
                }

                return usuarioEntidad;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
