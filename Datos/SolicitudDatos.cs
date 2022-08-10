using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class SolicitudDatos : Conexion
    {
        public static SolicitudEntidad Guardar(SolicitudEntidad solicitudEntidad)
        {
            try
            {
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("GuardarSolicitud", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("id_usuG", OracleType.Number).Value = solicitudEntidad.IdUsuario;
                        cmd.Parameters.Add("asuntoG", OracleType.NVarChar).Value = solicitudEntidad.Asunto;
                        cmd.Parameters.Add("descripcionG", OracleType.NVarChar).Value = solicitudEntidad.Descripcion;
                        cmd.Parameters.Add("urgenciaG", OracleType.NVarChar).Value = solicitudEntidad.Urgencia;
                        cmd.Parameters.Add("dispocitivoG", OracleType.NVarChar).Value = solicitudEntidad.Dispositivo;
                        cmd.Parameters.Add("areaG", OracleType.NVarChar).Value = solicitudEntidad.Area;
                        cmd.Parameters.Add("fechaG", OracleType.DateTime).Value = solicitudEntidad.Fecha;
                        cmd.Parameters.Add("estadoG", OracleType.Number).Value = Convert.ToInt16(solicitudEntidad.Estado);

                        cmd.ExecuteNonQuery();
                    }
                }
                return solicitudEntidad;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<SolicitudEntidad> ListaSolicitudes(int idUsu)
        {
            try
            {
                List<SolicitudEntidad> solicituds = new List<SolicitudEntidad>();

                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("ListaSolicitudes", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("idUsu", OracleType.Number).Value = idUsu;
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
                                solicituds.Add(new SolicitudEntidad(
                                    Convert.ToInt32(dr["ID"].ToString()),
                                    Convert.ToInt32(dr["ID_USU"].ToString()),
                                    c,
                                    dr["ASUNTO"].ToString(),
                                    dr["DESCRIP"].ToString(),
                                    dr["URGENCI"].ToString(),
                                    dr["DISPOCI"].ToString(),
                                    dr["AREA"].ToString(),
                                    (DateTime)(dr["FECHA"]),
                                    Convert.ToBoolean(dr["ESTADO"])));
                            }
                        }

                    }
                }

                return solicituds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static SolicitudEntidad Actualizar(SolicitudEntidad solicitudEntidad)
        {
            throw new NotImplementedException();
        }

     
    }
}
