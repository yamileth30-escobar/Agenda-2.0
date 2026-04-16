using System;
using System.Data;
using System.Windows.Forms;
using AgendaContactos.BLL;
using AgendaContactos.EL;   // Importamos la entidad

namespace AgendaContactos.GUI.Categorias
{
    public partial class ListadoCategorias : Form
    {
        // Usamos la lógica, NO la conexión directa
        CategoriaBLL bll = new CategoriaBLL();

        public ListadoCategorias()
        {
            InitializeComponent();
        }

        private void ListadoCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                // Llamamos al método que ya hicimos en la BLL
                dgvCategorias.DataSource = bll.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar
                if (string.IsNullOrWhiteSpace(txtNombreCat.Text))
                {
                    MessageBox.Show("Ingrese un nombre");
                    return;
                }

                // 2. Llenar entidad
                Categoria entidad = new Categoria();
                entidad.NombreCategoria = txtNombreCat.Text;

                // 3. Guardar usando la BLL
                bll.Guardar(entidad);

                MessageBox.Show("¡Guardado!");
                txtNombreCat.Clear();
                CargarCategorias(); // Refrescar la tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuardarCat_Click(object sender, EventArgs e)
        {
            btnGuardar_Click(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}