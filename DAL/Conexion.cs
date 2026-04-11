using System.Configuration;
using System.Data.SqlClient;

namespace AgendaContactos.DAL
{
    internal class Conexion
    {
        internal SqlConnection ObtenerConexion()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexionBD"]?.ConnectionString;

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ConfigurationErrorsException(
                    "No se encontró la cadena de conexión 'conexionBD' en App.config.");
            }

            return new SqlConnection(connectionString);
        }
    }
}
