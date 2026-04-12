using System;
using System.Windows.Forms;
using AgendaContactos.GUI.Contactos;
using AgendaContactos.GUI.Categorias;

namespace AgendaContactos.GUI
{
    public partial class MainForm : Form
    {
        public string NombreUsuario { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Saludo personalizado
            string mostrar = string.IsNullOrEmpty(NombreUsuario) ? "yami" : NombreUsuario;
            lblBienvenida.Text = "Bienvenida, " + mostrar;

            // Hora y fecha inicial
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt | dddd, dd MMMM yyyy");
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt | dddd, dd MMMM yyyy");
        }

        // 1. ABRE: GestionContactos
        private void btnContactos_Click(object sender, EventArgs e)
        {
            GestionContactos fGestion = new GestionContactos();
            fGestion.ShowDialog();
        }

        // 2. ABRE: ListadoCategorias
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            ListadoCategorias fListaCat = new ListadoCategorias();
            fListaCat.ShowDialog();
        }

        // 3. EVENTO PARA UBICACIONES (Cuando tengas el form creado lo conectamos igual)
        private void btnUbicaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de Ubicaciones en desarrollo...");
        }

        // 4. EVENTO PARA REPORTES
        private void btnReportes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de Reportes en desarrollo...");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Smart Contacts",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}