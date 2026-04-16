using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaContactos.GUI.Categorias
{
    public partial class RegistrarCategoria : Form
    {
        // Instancia de conexión a la base de datos
        DAL.Conexion conexionDAL = new DAL.Conexion();

        public RegistrarCategoria()
        {
            InitializeComponent();
        }

        // --- MÉTODO PARA GUARDAR ---
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Validamos que el cuadro de texto no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
            {
                MessageBox.Show("Por favor, escriba el nombre de la categoría.");
                return;
            }

            try
            {
                using (SqlConnection con = conexionDAL.ObtenerConexion())
                {
                    string query = "INSERT INTO Categorias (NombreCategoria) VALUES (@nombre)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreCategoria.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("¡Categoría registrada correctamente!");

                // Indicamos que el resultado fue exitoso para que el listado se refresque
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}