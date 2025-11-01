using app.Ventas.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class UcReportes : UserControl
    {
        public UcReportes()
        {
            InitializeComponent();
        }


        private void CargarUsuarios()
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string consultaSql = @"SELECT UsuarioID, NombreCompleto AS Nombre FROM Usuarios
                                        ORDER BY Nombre";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(consultaSql, conexion)) 
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);

                    cmbUsuarios.DataSource = dataTable;
                    cmbUsuarios.DisplayMember = "Nombre";
                    cmbUsuarios.ValueMember = "UsuarioID";
                    cmbUsuarios.SelectedIndex = -1;


                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocurrio un error al cargar los registros contacte con el administrador" + ex.Message);
            }
        }

        private void FiltroUsuarios(int idUsuario) 
        {
            string connectionString = ConexionDB.ObtenerConexion();
            string consultaSql = @"SELECT v.FechaVenta, v.Total, p.Nombre, dv.Cantidad, dv.PrecioUnitario
                                    FROM Ventas v
                                    INNER JOIN DetallesVenta dv ON v.VentaID = dv.VentaID
                                    INNER JOIN Productos p ON dv.ProductoID = p.ProductoID
                                    WHERE v.UsuarioID = @idUsuario";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(consultaSql, conexion)) 
            {
                da.SelectCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                dgvReportes.DataSource = dataTable;
                
            }
        }

        private void cargarClientes()
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string consultaSql = @"SELECT ClienteID, NombreCompleto AS Nombre FROM Clientes
                                        ORDER BY Nombre";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(consultaSql, conexion))
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);

                    cmbClientes.DataSource = dataTable;
                    cmbClientes.DisplayMember = "Nombre";
                    cmbClientes.ValueMember = "ClienteID";
                    cmbClientes.SelectedIndex = -1;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cargar los registros contacte con el administrador" + ex.Message);
            }
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

        private void FiltroClientes(int idCliente)
        {
            string connectionString = ConexionDB.ObtenerConexion();
            string consultaSql = @"SELECT v.FechaVenta, v.Total, p.Nombre, dv.Cantidad, dv.PrecioUnitario
                                   FROM Ventas v
                                   INNER JOIN DetallesVenta dv ON v.VentaID = dv.VentaID
                                   INNER JOIN Productos p ON dv.ProductoID = p.ProductoID
                                   WHERE v.ClienteID = @idCliente";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(consultaSql, conexion))
            {
                da.SelectCommand.Parameters.AddWithValue("@idCliente", idCliente);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                dgvReportes.DataSource = dataTable;
            }
        }



        private void cmbFliltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoFltro = cmbFiltrar.SelectedItem.ToString().Trim();
            Debug.Write(tipoFltro);

            FiltrarProductos(tipoFltro);



        }

        private void UcReportes_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            cargarClientes();
        }

        private void ibtnReporte_Click(object sender, EventArgs e)
        {
            bool usuarioSeleccionado = cmbUsuarios.SelectedValue != null;
            bool clienteSeleccionado = cmbClientes.SelectedValue != null;

            if (!usuarioSeleccionado && !clienteSeleccionado)
            {
                MessageBox.Show("Seleccione al menos un filtro: usuario o cliente.");
                return;
            }

            if (usuarioSeleccionado && clienteSeleccionado)
            {
                MessageBox.Show("Seleccione sólo un filtro: usuario o cliente, no ambos.");
                return;
            }

            if (usuarioSeleccionado)
            {
                FiltroUsuarios((int)cmbUsuarios.SelectedValue);
                cmbUsuarios.SelectedIndex = -1;
                return;
            }

            if (clienteSeleccionado)
            {
                FiltroClientes((int)cmbClientes.SelectedValue);
                cmbClientes.SelectedIndex = -1;
                return;
            }

        }

    }
}
