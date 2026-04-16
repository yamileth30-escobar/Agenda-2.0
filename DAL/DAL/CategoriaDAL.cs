using System;
using System.Data;
using System.Data.SqlClient;
using AgendaContactos.EL;

namespace AgendaContactos.DAL
{
    public class CategoriaDAL
    {
        // Instancia de tu clase Conexion.cs
        Conexion con = new Conexion();

        public void Insertar(Categoria entidad)
        {
            using (SqlConnection cn = con.ObtenerConexion())
            {
                string sql = "INSERT INTO Categorias (NombreCategoria) VALUES (@nom)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@nom", entidad.NombreCategoria);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Listar()
        {
            using (SqlConnection cn = con.ObtenerConexion())
            {
                // Usamos un DataAdapter para llenar la tabla
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Categorias", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}

