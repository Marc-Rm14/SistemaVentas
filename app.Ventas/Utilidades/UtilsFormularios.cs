using System.Windows.Forms;

namespace app.Ventas.Utilidades
{
    public static class UtilsFormularios
    {
        public static void ActivarMoverFocoConEnter(Form formulario)
        {
            foreach (Control control in formulario.Controls)
            {
                // Si el control admite KeyPress, le asignamos el evento
                control.KeyPress += MoverFocoConEnter;

                // Si el control tiene hijos (ej. Panel, GroupBox, TabPage)
                if (control.HasChildren)
                {
                    ActivarMoverFocoEnHijos(control);
                }
            }
        }

        private static void ActivarMoverFocoEnHijos(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                child.KeyPress += MoverFocoConEnter;
                if (child.HasChildren)
                {
                    ActivarMoverFocoEnHijos(child);
                }
            }
        }

        public static void MoverFocoConEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Control controlActual = sender as Control;
                Form formulario = controlActual?.FindForm();

                if (formulario != null)
                {
                    formulario.SelectNextControl(controlActual, true, true, true, true);
                }

                e.Handled = true;
            }
        }
    }
}

