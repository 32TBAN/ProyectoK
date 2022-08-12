using Entidades;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AsignacionesDatos : Conexion
    {
        public static Asignaciones Guardar(Asignaciones asignacion)
        {
			try
			{
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("GuardarAsignacion", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("id_sol", OracleType.Number).Value = asignacion.IdSolicitud;
                        cmd.Parameters.Add("id_tec", OracleType.Number).Value = asignacion.IdTecnico;
                        cmd.Parameters.Add("resp", OracleType.NVarChar).Value = asignacion.Respuesta;
                        cmd.Parameters.Add("termi", OracleType.Number).Value = Convert.ToInt32(asignacion.Terminada);
                        cmd.Parameters.Add("tot", OracleType.Number).Value = asignacion.Total;

                        cmd.ExecuteNonQuery();
                    }
                }
                return asignacion;
            }
			catch (Exception)
			{

				throw;
			}
        }
    }
}
