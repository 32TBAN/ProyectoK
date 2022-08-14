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
        public static bool Eliminar(int id, int idTecnico)
        {
            try
            {
                int filas = 0 ;
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("EliminarAsignacion", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("id_sol", OracleType.Number).Value = id;
                        cmd.Parameters.Add("id_tec", OracleType.Number).Value =idTecnico;

                        filas = Convert.ToInt16(cmd.ExecuteNonQuery());
                    }
                }
                return filas > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

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

        public static List<Asignaciones> ListaAsignacionTerminada()
        {
            try
            {
                List<Asignaciones> asignacionesTerminadas = new List<Asignaciones>();

                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("ListaAsignacionTerminada", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("buscar", OracleType.Cursor).Direction = ParameterDirection.Output;

                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                int c = 0;
                                if (dr["ID_TEC"].ToString() == "")
                                    c = 0;
                                else
                                    c = Convert.ToInt32(dr["ID_TEC"].ToString());

                                asignacionesTerminadas.Add(new Asignaciones(
                                    Convert.ToInt32(dr["ID_SOL"].ToString()),
                                    Convert.ToInt32(dr["ID_TEC"].ToString()),
                                    dr["RESPUESTA"].ToString(),
                                    Convert.ToBoolean(dr["TERMINADA"].ToString()),
                                    Convert.ToSingle(dr["TOTAL"].ToString()),
                                    Convert.ToDateTime(dr["FEC_FIN"])));
                            }
                        }

                    }
                }

                return asignacionesTerminadas;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
