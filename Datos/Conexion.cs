using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace Datos
{
    public abstract class Conexion
    {
        protected static OracleConnection ObtenerConexion()
        {
            return new OracleConnection("DATA SOURSE = xe; PASSWORD = MI3deenero; USER ID = SYSTEM;");
        }

    }
}
