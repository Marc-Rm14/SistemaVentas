using app.Ventas.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class UCProductos : UserControl
    {
        public event Action OnAgregarProductoClick; // Avisamos que se hubo un click en el boton

        public event Action OnDatosCambiados; // Avisamos que hubo un cambio

        private Usuario _usuario;

        private string consultaSql = @"SELECT p.ProductoID,
                                        p.Nombre,
                                        p.Precio,
                                        p.Codigo,
                                        p.Existencias,
                                        p.CategoriaID,
                                        c.Nombre AS Categoria,
                                        p.Activo
                                    FROM Productos p
                                    LEFT JOIN Categorias c ON p.CategoriaID = c.CategoriaID";

        public UCProductos()
        {
            InitializeComponent();
        }

        public UCProductos(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            AplicarPermisosInternos();
        }

        #region Metodos de Acceso a Datos y Configuarcion de Roles.
        private void AplicarPermisosInternos() 
        {
            if (_usuario.Rol == "Vendedor") 
            {
                ibtnAgregar.Enabled = false;
                ibtnEliminar.Enabled = false;
                dgvProductos.ReadOnly = true;
                dgvProductos.ClearSelection();
                dgvProductos.CellDoubleClick -= dgvProductos_CellDoubleClick;
                if (cmbEstado != null)
                    cmbEstado.Visible = false;
            }
        }


        private string ObtenerFiltroActivoSQL()
        {
            // Si es Vendedor, SIEMPRE mostramos solo lo Activo
            if (_usuario.Rol == "Vendedor")
            {
                return " WHERE p.Activo = 1 AND c.Activo = 1";
            }

            // Si es Admin
            switch (cmbEstado.SelectedItem.ToString())
            {
                case "Inactivos":
                    return " WHERE p.Activo = 0";
                case "Todos":
                    return ""; // Sin filtro
                case "Activos":
                default:
                    return " WHERE p.Activo = 1 AND c.Activo = 1";
            }
        }


        /*private void ibtnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new FrmAgregarProductos(); 
            frm.productoAgregado += listarRegistro;
            MostrarModal.MostrarConCapa(this, frm);
        }*/

        public void RefrescarDatos() //Necesario para refrescar desde el panel control
        {
            listarRegistro();
        }

        private void formatoGrid()
        {
            if (dgvProductos == null || dgvProductos.Columns == null) return;

            //NOTA: Ahora son 8 columnas porque añadimos P.Activo
            const int columnasTotales = 8;
            if (dgvProductos.Columns.Count < columnasTotales)
            {
                return;
            }

            dgvProductos.SuspendLayout();

            try
            {
                dgvProductos.Columns["ProductoID"].Visible = false;
                dgvProductos.Columns["Nombre"].HeaderText = "Nombre";
                dgvProductos.Columns["Precio"].HeaderText = "Precio";
                dgvProductos.Columns["Codigo"].HeaderText = "Codigo";
                dgvProductos.Columns["Existencias"].HeaderText = "Existencia";
                dgvProductos.Columns["CategoriaID"].Visible = false;
                dgvProductos.Columns["Categoria"].HeaderText = "Categoria";
                dgvProductos.Columns["Activo"].HeaderText = "Activo"; //NOTA: Mostramos el estado
            }
            finally
            {
                dgvProductos.ResumeLayout();
            }
        }

        private void listarRegistro()
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();

                // Usamos la consulta base + el filtro de rol/estado
                string consultaFinal = consultaSql + ObtenerFiltroActivoSQL();

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    //Ya no usamos la vista, usamos la consulta final, por ahora.
                    SqlDataAdapter adapter = new SqlDataAdapter(consultaFinal, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProductos.DataSource = dt;
                    formatoGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar registros: " + ex.Message);
            }
        }

        private void eliminarProducto(int idProducto)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();

                //NOTA: De DELETE a UPDATE
                string consultaUpdate = "UPDATE Productos SET Activo = 0 WHERE ProductoID = @IdProducto";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(consultaUpdate, conexion))
                {
                    command.Parameters.AddWithValue("@IdProducto", idProducto);
                    conexion.Open();

                    int result = command.ExecuteNonQuery();

                    if (result <= 0)
                    {
                        MessageBox.Show("Error al desactivar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("El producto fue desactivado con exito.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarRegistro(); // Refrescamos la lista
                    OnDatosCambiados?.Invoke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private void UCProductos_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.AddRange(new object[] { "Activos", "Inactivos", "Todos" });
            cmbEstado.SelectedItem = "Activos";

            AplicarPermisosInternos();

            listarRegistro();
        }

        #region Eventos del UC

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                int id = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["ProductoID"].Value);
                string nombre = Convert.ToString(dgvProductos.Rows[e.RowIndex].Cells["Nombre"].Value);
                decimal precio = Convert.ToDecimal(dgvProductos.Rows[e.RowIndex].Cells["Precio"].Value);
                string codigo = Convert.ToString(dgvProductos.Rows[e.RowIndex].Cells["Codigo"].Value);
                int existencia = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Existencias"].Value);
                int categoriaId = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["CategoriaID"].Value);

                //NOTA: Pasamos el estado 'Activo' al formulario de edición
                bool activo = Convert.ToBoolean(dgvProductos.Rows[e.RowIndex].Cells["Activo"].Value);

                FrmAgregarProductos frm = new FrmAgregarProductos(id, nombre, precio, codigo, existencia, categoriaId, activo);

                frm.registroAgregado += () =>
                {
                    RefrescarDatos();           
                    OnDatosCambiados?.Invoke(); 
                };


                MostrarModal.MostrarConCapa(this, frm);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos de la fila: " + ex.Message);
            }
        }


        private void cuiTxtBuscar_ContentChanged(object sender, EventArgs e)
        {
            string textoBusqueda1 = cuiTxtBuscar.Content.Trim();

            try
            {
                string connectionString = ConexionDB.ObtenerConexion();

                //NOTA: El buscador ahora respeta los filtros
                string filtroActivo = ObtenerFiltroActivoSQL();
                string conector = (filtroActivo == "") ? " WHERE " : " AND ";

                string consultaFinalBusqueda = consultaSql 
                                    + filtroActivo 
                                    + conector     
                                    + " (p.Codigo LIKE @texto OR p.Nombre LIKE @texto OR c.Nombre LIKE @texto)";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(consultaFinalBusqueda, conexion);
                    adapter.SelectCommand.Parameters.Add("@texto", SqlDbType.NVarChar, 100).Value = "%" + textoBusqueda1 + "%";

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProductos.DataSource = dt;
                    formatoGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar registros: " + ex.Message);
            }
        }

        
        #endregion

        #region Bottones
        private void ibtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seccione un registro para eliminar.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (MessageBox.Show("¿Seguro que desea desactivar este producto?",
                                "Confirmacion", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int.TryParse(dgvProductos.CurrentRow.Cells["ProductoID"].Value.ToString(), out int idProducto);
                    eliminarProducto(idProducto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la operacion" + ex);
            }
        }

        private void ibtnAgregar_Click(object sender, EventArgs e)
        {
            OnAgregarProductoClick?.Invoke();
        }

        #endregion

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
    }
}
