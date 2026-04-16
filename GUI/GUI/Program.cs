using System;
using System.Windows.Forms;
using AgendaContactos.GUI.Autenticacion; // Verifica que esta ruta sea correcta

namespace AgendaContactos.GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login fLogin = new Login();
            fLogin.ShowDialog();
            // 1. Mostramos el Login
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                // 2. CREAMOS el MainForm en una variable
                MainForm fMain = new MainForm();

                // 3. PASAMOS el nombre antes de mostrarlo
                // (Esto es lo que hace que cambie el "Bienvenida...")
                fMain.NombreUsuario = fLogin.UsuarioLogueado;

                // 4. ABRIMOS esa misma variable 'fMain'
                Application.Run(fMain);
            }
        }
    }
}