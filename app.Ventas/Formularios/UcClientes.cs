using app.Ventas.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    
    public partial class UcClientes : UserControl
    {
        private string consultaSql = @"
                        SELECT ClienteID AS id,
                               Cedula,
                               NombreCompleto AS Cliente,
                               Telefono,
                               Activo
                        FROM Clientes";


        public event Action OnAgregarClienteClick;
        public UcClientes()
        {
            InitializeComponent();
        }
        #region metodos


        private string ObtenerFiltroActivoSQL()
        {
            switch (cmbEstado.SelectedItem.ToString())
            {
                case "Inactivos":
                    return " WHERE Activo = 0";
                case "Todos":
                    return ""; // Sin filtro
                case "Activos":
                default:
                    return " WHERE Activo = 1";
            }
        }


        public void RefrescarDatos()
        {
            listarRegistro(consultaSql);
        }

        private void listarRegistro(string consultaBase)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();

                string consultaFinal = consultaSql + ObtenerFiltroActivoSQL();

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(consultaFinal, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvClientes.DataSource = dt;
                    formatoGrid();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar registros: " + ex.Message);
            }
        }

        private void formatoGrid()
        {

            // Sólo si hay columnas
            if (dgvClientes.Columns == null || dgvClientes.Columns.Count == 0) return;




            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[1].HeaderText = "Cedula"; //dgvUsuarios.Columns[1].Width = 250;
            dgvClientes.Columns[2].HeaderText = "Cliente"; //dgvUsuarios.Columns[2].Width = 100;
            dgvClientes.Columns[3].HeaderText = "Telefono"; //dgvUsuarios.Columns[3].Width = 130;

            

        }


        private void eliminarProducto(int idCliente)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string consultaSQL = @"
                                        UPDATE Clientes SET Activo = 0 WHERE ClienteID = @idCliente";


                    SqlCommand command = new SqlCommand(consultaSQL, conexion);
                    command.Parameters.AddWithValue("@IdCliente", idCliente);
                    conexion.Open();

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("El registro fue eliminado con exito.", "Informacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el registro.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al eliminar : " + ex);
            }
            refrescarDatos();
        }
        

        #endregion

        #region eventos
        

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["id"].Value);
                    string cedula = dgvClientes.Rows[e.RowIndex].Cells["Cedula"].Value.ToString();
                    string nombre = dgvClientes.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
                    string telefono = dgvClientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

                    bool activo = false;
                    var activoVal = dgvClientes.Rows[e.RowIndex].Cells["Activo"].Value;
                    if (activoVal != null && activoVal != DBNull.Value)
                        activo = Convert.ToBoolean(activoVal);

                    FrmAgregarCliente frm = new FrmAgregarCliente(id, cedula, nombre, telefono, activo);
                    frm.registroAgregado += refrescarDatos;
                    MostrarModal.MostrarConCapa(this, frm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void refrescarDatos()
        {
            listarRegistro(consultaSql);
        }

        private void UcClientes_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.AddRange(new object[] { "Activos", "Inactivos", "Todos" });
            cmbEstado.SelectedItem = "Activos";
            cmbEstado.Visible = true;
            refrescarDatos();
            
        }

        private void txtBoxBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = cuiTxtBuscar.Content.Trim();

            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string consultaSql = @"
                        SELECT Cedula,
                               NombreCompleto,
                               Telefono
                        FROM Clientes
                        WHERE Cedula LIKE @texto OR NombreCompleto LIKE @texto OR Telefono LIKE @texto";

                    SqlDataAdapter adapter = new SqlDataAdapter(consultaSql, conexion);
                    adapter.SelectCommand.Parameters.Add("@texto", SqlDbType.NVarChar, 100).Value = "%" + textoBusqueda + "%";

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvClientes.DataSource = dt;
                    //formatoGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar registros: " + ex.Message);
            }
        }
        #endregion

        #region Botones
        private void ibtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {

                try
                {
                    if (MessageBox.Show("¿seguro que desea eliminar el registro?",
                        "Confirmacion", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int.TryParse(dgvClientes.CurrentRow.Cells[0].Value.ToString(), out int idCliente);
                        eliminarProducto(idCliente);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la operacion" + ex);
                }
            }
            else
            {
                MessageBox.Show("Seccione un registro para eliminar.",
                    "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void ibtnAgregar_Click(object sender, EventArgs e)
        {
            OnAgregarClienteClick?.Invoke();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrescarDatos();
        }
    }
}
