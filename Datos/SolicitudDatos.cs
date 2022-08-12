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
            try
            { 
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("ActualizarSolicitud", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("idSol", OracleType.Number).Value = solicitudEntidad.Id;
                        cmd.Parameters.Add("asuntoG", OracleType.NVarChar).Value = solicitudEntidad.Asunto;
                        cmd.Parameters.Add("descripcionG", OracleType.NVarChar).Value = solicitudEntidad.Descripcion;
                        cmd.Parameters.Add("urgenciaG", OracleType.NVarChar).Value = solicitudEntidad.Urgencia;
                        cmd.Parameters.Add("dispocitivoG", OracleType.NVarChar).Value = solicitudEntidad.Dispositivo;
                        cmd.Parameters.Add("areaG", OracleType.NVarChar).Value = solicitudEntidad.Area;
                        cmd.Parameters.Add("fechaG", OracleType.DateTime).Value = solicitudEntidad.Fecha;
                        cmd.Parameters.Add("estadoG", OracleType.Number).Value = Convert.ToInt16(solicitudEntidad.Estado);
                        cmd.Parameters.Add("idT", OracleType.Number).Value = solicitudEntidad.IdTecnico;

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

        public static SolicitudEntidad BuscarSolicitud(int idSolicitud)
        {
            try
            {
                SolicitudEntidad solicitud = new SolicitudEntidad();

                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("BuscarSolicitudID", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("idS", OracleType.Number).Value = idSolicitud;
                        cmd.Parameters.Add("buscar", OracleType.Cursor).Direction = ParameterDirection.Output;

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                solicitud.Id = Convert.ToInt32(dr["ID"].ToString());
                                solicitud.IdUsuario = Convert.ToInt32(dr["ID_USU"].ToString());
                                if (dr["ID_TEC"].ToString() == "")
                                    solicitud.IdTecnico = 0;
                                else
                                    solicitud.IdTecnico = Convert.ToInt32(dr["ID_TEC"].ToString());
                                solicitud.Asunto = dr["ASUNTO"].ToString();
                                solicitud.Descripcion = dr["DESCRIP"].ToString();
                                solicitud.Urgencia = dr["URGENCI"].ToString();
                                solicitud.Dispositivo = dr["DISPOCI"].ToString();
                                solicitud.Area = dr["AREA"].ToString();
                                solicitud.Fecha = (DateTime)(dr["FECHA"]);
                                solicitud.Estado = Convert.ToBoolean(dr["ESTADO"]);
                            }
                        }

                    }
                }
                return solicitud;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool EliminarSolicitud(int id)
        {
            try
            {
                int filasAfectadas = 0;
                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("EliminarSolicitud", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("idS", OracleType.Number).Value = id;

                        filasAfectadas = Convert.ToInt32(cmd.ExecuteNonQuery());
                    }
                }
                return filasAfectadas>0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<SolicitudEntidad> ListaSolicitudesCompleta()
        {
            try
            {
                List<SolicitudEntidad> listaSolicitud = new List<SolicitudEntidad>();

                using (OracleConnection connection = Conexion.ObtenerConexion())
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("ListaUsuariosC", connection))
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
                                listaSolicitud.Add(new SolicitudEntidad(
                                    Convert.ToInt32(dr["ID"].ToString()),
                                    Convert.ToInt32(dr["ID_USU"].ToString()),
                                    c, dr["ASUNTO"].ToString(),
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
                return listaSolicitud;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
