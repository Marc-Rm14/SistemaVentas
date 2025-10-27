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

            //Si el Uc ya esta mostrado no se hace nada!
            if (panel.Controls.Count == 1 && panel.Controls[0] == nuevaVista)
                return;

            panel.SuspendLayout();
            try
            {
                //NOTA: Se simplifico la logica ya que solo mostramos UC en nuestro panel no es necesario hacer ninguna comprbacion
                //Rapido y eficiente
                panel.Controls.Clear();  
                nuevaVista.Dock = DockStyle.Fill;
                panel.Controls.Add(nuevaVista);
            }
            finally // Finally asegura que se reanude el panel en cualquier caso 
            {
                panel.ResumeLayout(true);
            }
        }
    }
}