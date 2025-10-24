using app.Ventas.Utilidades;
using System;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class frmConexion : Form
    {
        public frmConexion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var parametros = new ParametrosDeConexion
            {
                servidor = txtServidor.Text.Trim(),
                baseDatos = txtBaseDatos.Text.Trim()
            };

            if (!AdministrarConexion.ProbarConexion(parametros, out string error))
            {
                MessageBox.Show($"No se pudo establecer conexión a la base de datos.\n\nPor favor, verifica los datos e intenta de nuevo.\n\nDetalles: {error}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Simplemente regresamos, permitiendo al usuario corregir el servidor o la base de datos.
                return;
            }

            try
            {
                AdministrarConexion.Guardar(parametros);
                MessageBox.Show("Datos de conexion registrados con exito.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
