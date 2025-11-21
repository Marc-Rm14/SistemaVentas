using app.Ventas.Formularios;
using app.Ventas.Utilidades;
using PdfSharp.Fonts;
using PdfSharp.Snippets.Font;
using System;
using System.Windows.Forms;
namespace app.Ventas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalFontSettings.FontResolver = new FailsafeFontResolver();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            var conexion = AdministrarConexion.Cargar();
            if (string.IsNullOrWhiteSpace(conexion.servidor) || string.IsNullOrWhiteSpace(conexion.baseDatos))
            {
                using (var frm = new frmConexion())
                {
                    if (frm.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("No se configuró la conexión. La aplicación se cerrará.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }

            // Aquí el login se usa como diálogo
            using (var login = new FrmInicioSesion())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FrmPanelControl(login.UsuarioAutenticado)); // si todo es correcto lanzamos nuestro panel de control
                }
            }
        }
    }
}
