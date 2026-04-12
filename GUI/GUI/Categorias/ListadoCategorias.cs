using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaContactos.GUI.Categorias
{
    public partial class ListadoCategorias : Form
    {
        // Instancia nuestra clase de conexión
        DAL.Conexion conexionDAL = new DAL.Conexion();


        public ListadoCategorias()
        {
            InitializeComponent();
            CargarCategorias(); // Carga los datos apenas abre la ventana
        }

        // --- MÉTODO PARA LLENAR EL DATAGRIDVIEW ---
        private void CargarCategorias()
        {
            try
            {
                using (SqlConnection con = conexionDAL.ObtenerConexion())
                {
                    string query = "SELECT Id, NombreCategoria AS [Categoría] FROM Categorias";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // dgvCategorias es el nombre que le daremos al DataGridView en el diseño
                    dgvCategorias.DataSource = dt;

                    // Ajuste visual opcional
                    if (dgvCategorias.Columns.Count > 1)
                        dgvCategorias.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aún no hay categorías o la tabla no existe: " + ex.Message);
            }
        }

        // --- EVENTO DEL BOTÓN GUARDAR ---
        private void btnGuardarCat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCat.Text))
            {
                MessageBox.Show("Por favor, escribe el nombre de la categoría.");
                return;
            }

            try
            {
                using (SqlConnection con = conexionDAL.ObtenerConexion())
                {
                    string query = "INSERT INTO Categorias (NombreCategoria) VALUES (@nombre)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreCat.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("¡Categoría registrada con éxito!");
                txtNombreCat.Clear();
                CargarCategorias(); // Actualiza la tabla automáticamente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        // --- EVENTO DEL BOTÓN CERRAR/REGRESAR ---
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}