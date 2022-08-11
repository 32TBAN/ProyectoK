﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class SolicitudNegocio
    {
        public static SolicitudEntidad BuscarSolicitud(int idSolicitud)
        {
            return SolicitudDatos.BuscarSolicitud(idSolicitud);
        }

        public static bool EliminarSolicitud(int id)
        {
            return SolicitudDatos.EliminarSolicitud(id);
        }

        public static SolicitudEntidad Guardar(SolicitudEntidad solicitudEntidad)
        {
            if (solicitudEntidad.Id == 0)
                return SolicitudDatos.Guardar(solicitudEntidad);
            else
                return SolicitudDatos.Actualizar(solicitudEntidad);
        }

        public static List<SolicitudEntidad> ListaSolicitudes(int idUsu)
        {
            return SolicitudDatos.ListaSolicitudes(idUsu);
        }

        public static List<SolicitudEntidad> ListaSolicitudesCompleta()
        {
            return SolicitudDatos.ListaSolicitudesCompleta();
        }
    }
}
