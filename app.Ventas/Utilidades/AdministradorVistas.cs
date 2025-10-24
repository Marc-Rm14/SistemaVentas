using System;
using System.Linq;
using System.Windows.Forms;

namespace app.Ventas.Utilidades
{
    public static class AdministradorVistas
    {
        /// <summary>
        /// Este método permite mostrar un UserControl en cualquier formulario,
        /// dentro de cualquier panel que lo contenga.
        /// </summary>
        /// <param name="panel">Panel del formulario donde se mostrará el UserControl.</param>
        /// <param name="nuevaVista">El UserControl que se desea mostrar.</param>
        public static void MostrarVista(this Panel panel, UserControl nuevaVista)
        {
            if (panel == null || nuevaVista == null) return;

            try
            {
                panel.SuspendLayout();

                foreach (Control controlAnterior in panel.Controls.OfType<Control>().ToList())
                {
                    if (controlAnterior != nuevaVista)
                    {
                        panel.Controls.Remove(controlAnterior);
                        controlAnterior.Dispose();
                    }
                }

                if (!panel.Controls.Contains(nuevaVista))
                {
                    nuevaVista.Dock = DockStyle.Fill;
                    
                    panel.Controls.Add(nuevaVista);
                }

                nuevaVista.BringToFront(); 
            }
            finally
            {
                panel.ResumeLayout(true);
            }
        }


    }
}