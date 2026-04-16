using AgendaContactos.EL;
using System.Data;
using System.Data.SqlClient;

namespace AgendaContactos.DAL
{
    public class ContactoDAL
    {
        private readonly Conexion conexion = new Conexion();

        public DataTable Listar()
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Id, Nombre, Telefono, Correo, Direccion FROM Contactos ORDER BY Id DESC", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Insertar(Contacto c)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO Contactos (Nombre, Telefono, Correo, Categoria) VALUES (@n, @t, @c, @d)", con))
            {
                cmd.Parameters.AddWithValue("@n", c.Nombre ?? string.Empty);
                cmd.Parameters.AddWithValue("@t", c.Telefono ?? string.Empty);
                cmd.Parameters.AddWithValue("@c", c.Correo ?? string.Empty);
                cmd.Parameters.AddWithValue("@d", c.Categoria ?? string.Empty);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Contacto c)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE Contactos SET Nombre=@n, Telefono=@t, Correo=@c, Categoria=@d WHERE Id=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.Parameters.AddWithValue("@n", c.Nombre ?? string.Empty);
                cmd.Parameters.AddWithValue("@t", c.Telefono ?? string.Empty);
                cmd.Parameters.AddWithValue("@c", c.Correo ?? string.Empty);
                cmd.Parameters.AddWithValue("@d", c.Categoria ?? string.Empty);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Contactos WHERE Id=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Buscar(string valor)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT Id, Nombre, Telefono, Correo, Direccion
                  FROM Contactos
                  WHERE Nombre LIKE @b OR Telefono LIKE @b OR Correo LIKE @b OR Direccion LIKE @b
                  ORDER BY Id DESC", con))
            {
                da.SelectCommand.Parameters.AddWithValue("@b", "%" + valor + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
