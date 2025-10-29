using app.Ventas.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class UCProductos : UserControl
    {
        public event Action OnAgregarProductoClick;
        private Usuario _usuario;
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

            if (dgvProductos == null)
                throw new InvalidOperationException("dgvProductos no está inicializado.");

            if (dgvProductos.Columns == null)
                throw new InvalidOperationException("La colección Columns es null.");

            const int columnasTotales = 7;
            if (dgvProductos.Columns.Count < columnasTotales) //por que 7 si el indice lega hasta 6
                                                              //el metodo count cuenta los elementos
            {
                // No hay suficientes columnas: salir sin cambiar nada
                return;
            }

            dgvProductos.SuspendLayout();
            
            try
            {
                dgvProductos.Columns[0].Visible = false;
                dgvProductos.Columns[1].HeaderText = "Nombre";
                dgvProductos.Columns[2].HeaderText = "Precio";
                dgvProductos.Columns[3].HeaderText = "Codigo";
                dgvProductos.Columns[4].HeaderText = "Existencia";
                dgvProductos.Columns[5].Visible = false;
                dgvProductos.Columns[6].HeaderText = "Categoria";
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
                
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string consultaSql = "SELECT *FROM vw_MostrarRegistroProductos";
                    SqlDataAdapter adapter = new SqlDataAdapter(consultaSql, conexion);
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

                using (SqlConnection conexion = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand("DELETE FROM Productos WHERE ProductoID = @IdProducto", conexion))
                {
                    command.Parameters.AddWithValue("@IdProducto", idProducto);
                    conexion.Open();

                    int result = command.ExecuteNonQuery();

                    if (result <= 0)
                    {
                        MessageBox.Show("Error al eliminar el producto.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("El producto fue eliminado con exito.", "Informacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    listarRegistro();
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
            // Al mostrar el uc cargamos el datagrid
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

                // Ahora el formulario no debería recibir 'codigo' como parámetro editable
                FrmAgregarProductos frm = new FrmAgregarProductos(id, nombre, precio, codigo, existencia, categoriaId);

                frm.registroAgregado += listarRegistro;
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
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string consultaSql = @"
                        SELECT p.ProductoID,
                               p.Nombre,
                               p.Precio,
                               p.Codigo,
                               p.Existencias,
                               p.CategoriaID,
                               c.Nombre AS Categoria
                        FROM Productos p
                        LEFT JOIN Categorias c ON p.CategoriaID = c.CategoriaID
                        WHERE p.Codigo LIKE @texto OR p.Nombre LIKE @texto OR c.Nombre LIKE @texto";

                    SqlDataAdapter adapter = new SqlDataAdapter(consultaSql, conexion);
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

        //TODO: limpiar el los bloques codigo de los places holder y text changed; ahora se usa los controles de la libreria Coure UL.
        #endregion

        #region Bottones
        private void ibtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seccione un registro para eliminar.",
                   "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (MessageBox.Show("¿seguro que desea eliminar el registro?",
                        "Confirmacion", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int.TryParse(dgvProductos.CurrentRow.Cells[0].Value.ToString(), out int idProducto);
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
    }
}
