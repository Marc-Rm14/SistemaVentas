using app.Ventas.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class UcReportes : UserControl
    {
        public UcReportes()
        {
            InitializeComponent();
        }


        private void FiltrarProductos(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvReportes.DataSource = null;
                return;
            }

            string connectionString = ConexionDB.ObtenerConexion();
            string sql;

            switch (filtro.Trim())
            {
                case "Clientes":
                    sql = "SELECT * FROM Productos";
                    break;
                case "Usuarios":
                    sql = "SELECT * FROM Productos";
                    break;
                
                default:
                    sql = "SELECT TOP 0 * FROM Clientes"; 
                    break;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReportes.DataSource = dt;
            }
        }


        private void cmbFliltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoFltro = cmbFiltrar.SelectedItem.ToString().Trim();
            Debug.Write(tipoFltro);

            FiltrarProductos(tipoFltro);



        }
    }
}
