using System;
using System.Configuration;
using System.Data.SqlClient;

namespace AgendaContactos.DAL
{
    public class Conexion
    {
        public SqlConnection ObtenerConexion()
        {
            // Lee la cadena 'conexionBD' que pusimos en el App.config
            string connectionString = ConfigurationManager.ConnectionStrings["conexionBD"]?.ConnectionString;

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new Exception("Error: No se encontró la configuración 'conexionBD' en App.config.");
            }

            return new SqlConnection(connectionString);
        }
    }
}
