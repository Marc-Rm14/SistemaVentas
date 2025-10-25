using app.Ventas.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class UcUsuarios : UserControl
    {
        
        public event Action OnAgregarUsuarioClick;
        public UcUsuarios()
        {
            InitializeComponent();
        }


        private void listarRegistros() 
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string consultaSql = @"SELECT u.UsuarioID AS id, u.NombreUsuario AS usuario, u.Contrasena,
                                      u.NombreCompleto AS nombre, u.RolID, r.NombreRol AS Rol 
                                      FROM Usuarios u
                                      INNER JOIN Roles r ON u.RolID = r.RolID";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(consultaSql, conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvUsuarios.DataSource = dt;
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
            listarRegistros();
        }

        private void formatoGrid()
        {

            // Sólo si hay columnas
            if (dgvUsuarios.Columns == null || dgvUsuarios.Columns.Count == 0) return;

            
            
            
            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[1].HeaderText = "Usuario"; //dgvUsuarios.Columns[1].Width = 250;
            dgvUsuarios.Columns[2].HeaderText = "Contraseña"; //dgvUsuarios.Columns[2].Width = 100;
            dgvUsuarios.Columns[3].HeaderText = "Nombre"; //dgvUsuarios.Columns[3].Width = 130;
            
            dgvUsuarios.Columns[4].Visible = false;
            dgvUsuarios.Columns[5].HeaderText = "Rol";
            
        }


        private void eliminarUsuario(int usuario) 
        {
            try
            {
                string connection = ConexionDB.ObtenerConexion();
                string consultaSql = @"DELETE FROM Usuarios WHERE UsuarioID = @idUsuario";
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(consultaSql, con)) 
                {
                    cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = usuario;
                    con.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result <= 0)
                    {
                        MessageBox.Show("Error al eliminar el Usuario.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("El usuario fue eliminado con exito.", "Informacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    listarRegistros();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int id = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["id"].Value);
                    string nombreUsuario = Convert.ToString(dgvUsuarios.Rows[e.RowIndex].Cells["usuario"].Value);
                    string contrasenaUsuario = Convert.ToString(dgvUsuarios.Rows[e.RowIndex].Cells["Contrasena"].Value);
                    string nombreCompleto = Convert.ToString(dgvUsuarios.Rows[e.RowIndex].Cells["nombre"].Value);
                    
                    int rolId = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["RolID"].Value);

                    // Ahora el formulario no debería recibir 'codigo' como parámetro editable
                    FrmAgregarUsuario frm = new FrmAgregarUsuario(id, nombreUsuario, contrasenaUsuario, nombreCompleto, rolId);

                    frm.registroAgregado += listarRegistros;
                    MostrarModal.MostrarConCapa(this, frm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void UcUsuarios_Load(object sender, EventArgs e)
        {
            listarRegistros();
        }

        

        

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {

            


            string connectionString = ConexionDB.ObtenerConexion();
            string consultasSql = @"SELECT u.UsuarioID AS id, u.NombreUsuario AS usuario, u.Contraseña,
                                      u.NombreCompleto AS nombre, u.RolID, r.NombreRol AS Rol 
                                      FROM Usuarios u
                                      INNER JOIN Roles r ON u.RolID = r.RolID
                                      WHERE u.NombreUsuario LIKE @texto OR u.NombreCompleto LIKE @texto OR r.NombreRol LIKE @texto";
            try
            {

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(consultasSql, conexion);
                    //adapter.SelectCommand.Parameters.Add("@texto", SqlDbType.VarChar, 100).Value = "%" +  + "%";

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvUsuarios.DataSource = dt;


                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al buscar registros: " + ex.Message);
            }
        }

        private void ibtnAgregar_Click(object sender, EventArgs e)
        {
            OnAgregarUsuarioClick?.Invoke();
        }

        private void ibtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count <= 0)
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
                    int.TryParse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString(), out int idUsuario);
                    eliminarUsuario(idUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la operacion" + ex);
            }
        }
    }
}
