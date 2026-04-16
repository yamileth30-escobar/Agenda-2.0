using Agenda.EL;
using AgendaContactos.EL;
using System;
using System.Data.SqlClient;

namespace AgendaContactos.DAL
{
    public class UsuarioDAL
    {
        private readonly Conexion conexion = new Conexion();

        public bool Login(UsuarioEL u)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
             
                if (con.State == System.Data.ConnectionState.Closed) con.Open();

                string sql = "SELECT COUNT(*) FROM Usuarios WHERE Username=@u AND Password=@p";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@u", u.Username);
                    cmd.Parameters.AddWithValue("@p", u.Password);

                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        public void AsegurarUsuarioPorDefecto()
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                if (con.State == System.Data.ConnectionState.Closed) con.Open();

                string sql = @"
                IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE Username = @u)
                BEGIN
                    INSERT INTO Usuarios (Username, Password)
                    VALUES (@u, @p)
                END";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@u", "yami");
                    cmd.Parameters.AddWithValue("@p", "Tokio25");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ELIMINÉ EL BLOQUE QUE ESTABA AQUÍ ABAJO PORQUE ESTABA REPETIDO
    }
}