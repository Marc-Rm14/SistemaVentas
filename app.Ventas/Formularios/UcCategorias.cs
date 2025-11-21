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
        
        private string consultaSql = @"
                        SELECT CategoriaID,
                               Nombre AS Categoria, Activo
                        FROM Categorias";

        public UcCategorias()
        {
            InitializeComponent();
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
                    
                    bool activo = false;
                    var activoVal = dgvCategorias.Rows[e.RowIndex].Cells["Activo"].Value;
                    if (activoVal != null && activoVal != DBNull.Value)
                        activo = Convert.ToBoolean(activoVal);

                    frmAgregarCategoria frm = new frmAgregarCategoria(categoriaId, nombre, activo);
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

            // Esto para respetar el filtro:

            string filtroActivo = ObtenerFiltroActivoSQL();

            string conector;
            if (filtroActivo == "")
            {
                // Si no hay filtro, la búsqueda debe empezar con WHERE
                conector = " WHERE ";
            }
            else
            {
                // Si ya hay un filtro (ej: " WHERE Activo = 1"), la búsqueda debe ser un AND
                conector = " AND ";
            }

            string consultaFinal = consultaSql // Usamos la consulta base
                        + filtroActivo // Añadimos el filtro (Ej: "WHERE Activo = 1")
                        + conector     // Añadimos el conector (Ej: "AND" o "WHERE")
                        + " (Nombre LIKE @texto)"; // Añadimos la búsqueda

            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    

                    SqlDataAdapter adapter = new SqlDataAdapter(consultaFinal, conexion);
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

            //Ven al final igual que antes.
        }


        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrescarDatos();
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

        #region Metodos
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

        private void listarRegistros(string consultaBase)
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
            if (dgvCategorias.Columns.Count >= 3)
            {
                dgvCategorias.Columns["CategoriaID"].Visible = false;
                dgvCategorias.Columns["Categoria"].HeaderText = "Nombre";
                dgvCategorias.Columns["Activo"].HeaderText = "Activo"; 
            }
        }

        private bool ValidarCategoria(int idCategoria)
        {
            int conteoProductos = 0;
            string connectionString = ConexionDB.ObtenerConexion();
            string consultaConteo = @"SELECT COUNT(*) 
                                    FROM Productos 
                                    WHERE CategoriaID = @idCategoria AND Activo = 1;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(consultaConteo, con))
                {
                    cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
                    con.Open();
                    conteoProductos = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar productos activos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (conteoProductos > 0)
            {
                MessageBox.Show($"No se puede desactivar. Esta categoría tiene {conteoProductos} productos activos.",
                                "Acción Denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        #endregion


        #region Botones

        private void ibtnEliminarCat_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seccione un registro para eliminar.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int.TryParse(dgvCategorias.CurrentRow.Cells["CategoriaID"].Value.ToString(), out int idCategoria);

            
            var categoriaActiva = Convert.ToBoolean(dgvCategorias.CurrentRow.Cells["Activo"].Value);
            if (!categoriaActiva)
            {
                MessageBox.Show("Esta categoría ya se encuentra inactiva.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Validar primero
            bool validacion = ValidarCategoria(idCategoria);

            try
            {
                // 2. Si es válido, preguntar y eliminar
                if (validacion)
                {
                    if (MessageBox.Show("¿Seguro que desea DESACTIVAR esta categoría?",
                                "Confirmacion", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        eliminarCategoria(idCategoria);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la operacion: " + ex);
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
                                        UPDATE Categorias SET Activo = 0 WHERE CategoriaID = @idCategoria";


                    SqlCommand command = new SqlCommand(consultaSQL, conexion);
                    command.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    conexion.Open();

                    int result = command.ExecuteNonQuery();

                    if (result == 0)
                    {

                        MessageBox.Show("Error al eliminar la categoria.", "Error", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                        return;
                    }
                    
                    MessageBox.Show("La categoria fue eliminada con exito.", "Informacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
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

    }

}
