using System.Drawing;
using System.Windows.Forms;

namespace app.Ventas.Utilidades
{
    public static class MostrarModal
    {
        /// <summary>
        /// Permite mostrar un formulario en modal sobre un user control
        /// </summary>
        /// <param name="controlPrincipal">Define el control sobre el que se quiere mostrar el frmModal</param>
        /// <param name="formularioModal">El formulario que se quiere mostrar en modal</param>
        public static void MostrarConCapa(Control controlPrincipal, Form formularioModal)
        {
            // Validaciones básicas sin throw
            if (controlPrincipal == null || formularioModal == null)
                return;

            //NOTA: Busca el formulario raiz en nuestro caso FrmPanelControl
            //por que hacerlo?
            //por que usamos uc para mostrar las vistas

            Form owner = controlPrincipal.FindForm(); 
            if (owner == null || owner.IsDisposed)
                return;

            // Crear capa semi-transparente
            using (var capa = new Form()
            {
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.Black,
                Opacity = 0.5,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.Manual,
                TopMost = false,
                Location = owner.PointToScreen(Point.Empty),
                Size = owner.ClientSize,
                Owner = owner
            })
            {
                capa.Show();
                formularioModal.ShowInTaskbar = false;
                formularioModal.ShowDialog();
            }
            //Ahora using se encargar de la limpieza
        }
    }
}
