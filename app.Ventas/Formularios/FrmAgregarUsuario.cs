using app.Ventas.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    
    public partial class FrmAgregarUsuario : Form
    {
        public event Action registroAgregado;
        public FrmAgregarUsuario()
        {
            InitializeComponent();
            CargarRoles();
            chkActivo.Checked = true;
        }

        public FrmAgregarUsuario(int usuarioId, string nombreUsuario, string contrasenaUsuario, string nombreCompleto, int idRol, bool activo)
        {
            InitializeComponent();
            CargarRoles();
            chkActivo.Enabled = true;
            
            txtId.Text = usuarioId.ToString();
            txtNombreUsuario.Text = nombreUsuario;
            txtContrasenaUsuario.Text = contrasenaUsuario;
            txtNombreCompleto.Text = nombreCompleto;
            cmbRoles.SelectedValue = idRol;
            chkActivo.Checked = activo;
        }



        private void CargarRoles()
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string sql = @"SELECT RolID, NombreRol 
                               FROM Roles
                               ORDER BY NombreRol";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbRoles.DataSource = dt;
                    cmbRoles.DisplayMember = "NombreRol";
                    cmbRoles.ValueMember = "RolID";
                    cmbRoles.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los Roles: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void GuardarUsuario(string nombreUsuario, string contrasenaUsuario, string nombreCompleto, int idRol)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string sql = @"INSERT INTO Usuarios (NombreUsuario, Contrasena, NombreCompleto, RolId)
                       VALUES (@nombreUsuario, @contrasenaUsuario, @nombreCompleto, @RolID)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@nombreUsuario", SqlDbType.NVarChar, 50).Value = nombreUsuario;
                    cmd.Parameters.Add("@contrasenaUsuario", SqlDbType.VarChar,255).Value = contrasenaUsuario;
                    cmd.Parameters.Add("@nombreCompleto", SqlDbType.NVarChar, 100).Value = nombreCompleto;
                    cmd.Parameters.Add("@RolID", SqlDbType.Int).Value = idRol;

                    conn.Open();
                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado <= 0)
                    {
                        MessageBox.Show("No se almacenó el registro", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    MessageBox.Show("Registro almacenado correctamente", "Información",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private void ActualizarProducto(int idUsuario, string nombreUsuario, string contrasenaUsuario ,string nombreCompleto, int idRol, bool Activo)
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consulta = @"UPDATE Usuarios
                                SET NombreUsuario = @NombreUsuario,
                                    Contrasena = @ContrasenaUsuario,
                                    NombreCompleto = @NombreCompleto,
                                    RolID = @IdRol,
                                    Activo = @Activo
                                WHERE UsuarioID = @IdUsuario";

                    using (SqlCommand command = new SqlCommand(consulta, conexion))
                    {
                        command.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idUsuario;
                        command.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = nombreUsuario;
                        command.Parameters.Add("@ContrasenaUsuario", SqlDbType.VarChar, 255).Value = contrasenaUsuario;
                        command.Parameters.Add("@NombreCompleto", SqlDbType.NVarChar, 100).Value = nombreCompleto;
                        command.Parameters.Add("@IdRol", SqlDbType.Int).Value = idRol;
                        command.Parameters.Add("@Activo", SqlDbType.Bit).Value = Activo;

                        conexion.Open();
                        int resultado = command.ExecuteNonQuery();

                        if (resultado <= 0)
                        {
                            MessageBox.Show("No se actualizó correctamente el registro", "Información",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        MessageBox.Show("Registro actualizado correctamente", "Información",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool validarCampos()
        {
            bool datosValidos = true;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is TextBox cajaTexto)
                {
                    if (string.IsNullOrWhiteSpace(cajaTexto.Text))
                    {
                        errorIcono.SetError(cajaTexto, "Este campo es obligatorio");
                        datosValidos = false;
                    }
                }
            }

            return datosValidos;
        }


        //NOTA: Cambie un poco la logica del metodo, hacemos comprobaciones antes
        // de realizar cualquier operacion, es necesario hacer estos cambios en los demas formularios.
        private void btnGuardar_Click(object sender, EventArgs e) 
        {
            errorIcono.Clear();

            if (!validarCampos())
            {
                MessageBox.Show("Información incompleta, se remarcarán los campos faltantes",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool activo = chkActivo.Checked;
            string nombreUsuario = txtNombreUsuario.Text.Trim();
            string contrasena = txtContrasenaUsuario.Text.Trim();

            // Validar categoría seleccionada
            if (cmbRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una rol", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbRoles.Focus();
                return;
            }
            int rolId = (int)cmbRoles.SelectedValue;

            string nombreCompleto = txtNombreCompleto.Text.Trim();

            bool operacionExitosa = false;
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text.Trim()))
                {
                    
                    if (MessageBox.Show("¿Desea guardar el nuevo producto?", "Información",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                       return;
                    }
                    // GUARDAR NUEVO PRODUCTO
                    GuardarUsuario(nombreUsuario, contrasena, nombreCompleto, rolId);
                    operacionExitosa = true;
                    
                }
                else
                {
                    if (!int.TryParse(txtId.Text.Trim(), out int usuarioId))
                    {
                        MessageBox.Show("El ID del producto es inválido", "Validación",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult resultado = MessageBox.Show("¿Desea aplicar los cambios?", "Información",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resultado == DialogResult.No)
                    {
                        return;
                        
                    }
                    // ACTUALIZAR PRODUCTO EXISTENTE
                    ActualizarProducto(usuarioId, nombreUsuario, contrasena, nombreCompleto, rolId, activo);
                    operacionExitosa = true;

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (operacionExitosa) { registroAgregado?.Invoke();}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
