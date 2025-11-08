using app.Ventas.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class UcCategorias : UserControl
    {
        
        public event Action OnAgregarCategoriaClick;
        private Usuario _usuario;
        private string consultaSql = @"
                        SELECT CategoriaID,
                               Nombre AS Categoria, Activo
                        FROM Categorias";

        public UcCategorias()
        {
            InitializeComponent();
        }

        private string ObtenerFiltroActivoSQL()
        {
            switch (cmbEstado.SelectedItem.ToString())
            {
                case "Inactivos":
                    return " WHERE u.Activo = 0";
                case "Todos":
                    return ""; // Sin filtro
                case "Activos":
                default:
                    return " WHERE u.Activo = 1";
            }
        }

        public UcCategorias(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            AplicarPermisosInternos();
        }

        

        private void AplicarPermisosInternos()
        {
            if (_usuario.Rol == "Vendedor")
            {
                ibtnAgregar.Enabled = false;
                ibtnEliminar.Enabled = false;
                dgvCategorias.ReadOnly = true;
                dgvCategorias.ClearSelection();
                
            }
        }

        #region Eventos del UC
        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0)
                {
                    int categoriaId = Convert.ToInt32(dgvCategorias.Rows[e.RowIndex].Cells["CategoriaID"].Value);
                    string nombre = Convert.ToString(dgvCategorias.Rows[e.RowIndex].Cells["Categoria"].Value);

                    frmAgregarCategoria frm = new frmAgregarCategoria(categoriaId, nombre);
                    frm.registroAgregado += refrescarDatos;
                    MostrarModal.MostrarConCapa(this, frm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void cuiTxtBuscarCat_ContentChanged(object sender, EventArgs e)
        {
            string textoBusqueda1 = cuiTxtBuscar.Content.Trim();

            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string consultaSql = @"
                        SELECT Nombre AS Categoria
                        FROM Categorias
                        WHERE Nombre LIKE @texto";

                    SqlDataAdapter adapter = new SqlDataAdapter(consultaSql, conexion);
                    adapter.SelectCommand.Parameters.Add("@texto", SqlDbType.NVarChar, 100).Value = "%" + textoBusqueda1 + "%";

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCategorias.DataSource = dt;
                    formatoGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar registros: " + ex.Message);
            }
        }




        #endregion

        #region Metodos

        private void listarRegistros(string consultaBase)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string consultaFinal = consultaSql + ObtenerFiltroActivoSQL();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(consultaSql, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCategorias.DataSource = dt;
                    formatoGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar registros: " + ex.Message);
            }
        }

        public void refrescarDatos()
        {
            listarRegistros(consultaSql);
        }

        private void formatoGrid()
        {

            // Sólo si hay columnas
            if (dgvCategorias.Columns == null || dgvCategorias.Columns.Count == 0) return;

            // Usamos conteo mínimo para no lanzar excepciones
            if (dgvCategorias.Columns.Count >= 2)
            {
                dgvCategorias.Columns[0].Visible = false;
                dgvCategorias.Columns[1].HeaderText = "Nombre";
            }
        }

        private void UcCategorias_Load(object sender, EventArgs e)
        {
            // <-- NUEVO: Configuramos el ComboBox al cargar
            cmbEstado.Items.AddRange(new object[] { "Activos", "Inactivos", "Todos" });
            cmbEstado.SelectedItem = "Activos";

            // <-- CAMBIO: Ya no está condicionado, siempre es visible.
            cmbEstado.Visible = true;

            // Ahora listamos los registros
            refrescarDatos();
        }


        #endregion


        #region Botones

        private void ibtnEliminarCat_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {

                try
                {
                    if (MessageBox.Show("¿seguro que desea eliminar el registro?",
                        "Confirmacion", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int.TryParse(dgvCategorias.CurrentRow.Cells[0].Value.ToString(), out int idCategoria);
                        eliminarCategoria(idCategoria);
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


        private void eliminarCategoria(int idCategoria)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string consultaSQL = @"
                                        UPDATE Categorias SET Activivo = 0 WHERE CategoriaID = @idCategoria";


                    SqlCommand command = new SqlCommand(consultaSQL, conexion);
                    command.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    conexion.Open();

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("La categoria fue eliminada con exito.", "Informacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la categoria.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    refrescarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al eliminar : " + ex);
            }
        }

        private void ibtnAgregarCat_Click(object sender, EventArgs e)
        {
            OnAgregarCategoriaClick?.Invoke();
        }

        #endregion

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrescarDatos();
        }
    }

}
