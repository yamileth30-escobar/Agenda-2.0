using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaContactos.GUI.Contactos
{
    public partial class GestionContactos : Form
    {
        // Instancia de tu clase de conexión en la carpeta DAL
        DAL.Conexion conexionDAL = new DAL.Conexion();

        public GestionContactos()
        {
            InitializeComponent();
            CargarDatos(); // Carga la base de datos al abrir el programa
        }

        // --- 1. MÉTODO PARA CARGAR DATOS DE SQL A LA TABLA ---
        private void CargarDatos()
        {
            try
            {
                using (SqlConnection con = conexionDAL.ObtenerConexion())
                {
                    string query = "SELECT * FROM Contactos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dvListadoClientes.Rows.Clear();
                    foreach (DataRow fila in dt.Rows)
                    {
                        dvListadoClientes.Rows.Add(
                            fila["Id"],
                            fila["Nombres"],
                            fila["Apellidos"],
                            fila["Email"],
                            fila["Telefono"],
                            fila["Categoria"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                // Si da error es porque la tabla aún no existe o la conexión está mal configurada
                MessageBox.Show("Aviso: No se pudieron cargar los datos. " + ex.Message);
            }
        }

        // --- 2. LÓGICA PARA GUARDAR EN LA BASE DE DATOS ---
        private void GuardarContacto()
        {
            // Validación básica
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor, completa Nombres y Apellidos.");
                return;
            }

            try
            {
                using (SqlConnection con = conexionDAL.ObtenerConexion())
                {
                    string query = "INSERT INTO Contactos (Nombres, Apellidos, Email, Telefono, Categoria) " +
                                   "VALUES (@nom, @ape, @mail, @tel, @cat)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    // Según tu diseño: txtID = Nombres, txtNombre = Apellidos
                    cmd.Parameters.AddWithValue("@nom", txtID.Text);
                    cmd.Parameters.AddWithValue("@ape", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@mail", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@cat", cmbCategoria.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("¡Contacto guardado con éxito!");
                CargarDatos(); // Refresca la tabla
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        // --- 3. EVENTOS DE LOS BOTONES (CON LOS NOMBRES CORREGIDOS) ---

        private void button3_Click(object sender, EventArgs e) // Botón Agregar
        {
            GuardarContacto();
        }

        private void button2_Click(object sender, EventArgs e) // Botón Guardar
        {
            GuardarContacto();
        }

        private void button1_Click(object sender, EventArgs e) // Botón Eliminar
        {
            if (dvListadoClientes.CurrentRow != null)
            {
                // Aquí podrías agregar un DELETE FROM Contactos WHERE Id = ...
                dvListadoClientes.Rows.Remove(dvListadoClientes.CurrentRow);
                MessageBox.Show("Registro eliminado de la vista.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) // Botón Cancelar
        {
            LimpiarCampos();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e) // Botón Buscar
        {
            string busqueda = textBox2.Text.ToLower();
            if (string.IsNullOrEmpty(busqueda)) { CargarDatos(); return; }

            bool encontrado = false;
            dvListadoClientes.ClearSelection();

            foreach (DataGridViewRow fila in dvListadoClientes.Rows)
            {
                if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString().ToLower().Contains(busqueda))
                {
                    fila.Selected = true;
                    dvListadoClientes.FirstDisplayedScrollingRowIndex = fila.Index;
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado) MessageBox.Show("No se encontró el contacto.");
        }

        // --- 4. MÉTODO PARA LIMPIAR EL FORMULARIO ---
        private void LimpiarCampos()
        {
            textBox1.Clear(); // ID visual
            txtID.Clear();    // Nombres
            txtNombre.Clear(); // Apellidos
            txtCorreo.Clear();
            txtTelefono.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtID.Focus();
        }
    }
}