using System;
using System.Windows.Forms;

namespace AgendaContactos.GUI.Autenticacion
{
    public partial class Login : Form
    {
        // 1.Es la que guardará el nombre "yami"
        public string UsuarioLogueado { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Validar las credenciales
            if (txtUsuario.Text.Trim().Equals("yami") && txtContraseña.Text.Trim().Equals("tokio25"))
            {
                // 2.Guardamos el texto del cuadro antes de cerrar
                this.UsuarioLogueado = txtUsuario.Text.Trim();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.", "Smart Contacts | Inicio de Sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
