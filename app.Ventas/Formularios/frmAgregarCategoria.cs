using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using app.Ventas.Utilidades;

namespace app.Ventas.Formularios
{
    public partial class frmAgregarCategoria : Form
    {
        public event Action registroAgregado;

        //NOTA: Nueva variable para recordar el estado original
        private bool _estadoOriginalActivo;

        public frmAgregarCategoria()
        {
            InitializeComponent();
            chkActivo.Checked = true;
            this._estadoOriginalActivo = true;
        }

        public frmAgregarCategoria(int categoriaId, string nombre, bool activo, string textoCheck)
        {

            InitializeComponent();
            chkActivo.Enabled = true;   
            chkActivo.Content = textoCheck;
            
            txtId.Text = categoriaId.ToString();
            txtAgCategoria.Text = nombre;
            chkActivo.Checked = activo;


            //NOTA: Guardamos el estado original 
            this._estadoOriginalActivo = activo;

        }

        #region Metodos

        private void ActualizarCategoria(int categoriaId, string categoria, bool activo)
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();
                string consulta = @"UPDATE Categorias
                                    SET Nombre = @Categoria,
                                        Activo = @Activo
                                    WHERE CategoriaID = @CategoriaID";
                using (SqlConnection conexion = new SqlConnection(connetionString))
                using (SqlCommand command = new SqlCommand(consulta, conexion))
                {
                    command.Parameters.Add("@Categoria", SqlDbType.NVarChar, 100).Value = categoria;
                    command.Parameters.Add("@Activo", SqlDbType.Bit).Value = activo;
                    command.Parameters.Add("@CategoriaID", SqlDbType.Int).Value = categoriaId;

                    conexion.Open();
                    int resultado = command.ExecuteNonQuery();

                    if (resultado <= 0)
                    {
                        MessageBox.Show("No se actualizo correctamente el registro", "Información",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Registro Actualizado correctamente", "Información",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private bool validarCampos()
        {
            bool datosValidos = true;

            if (string.IsNullOrEmpty(txtAgCategoria.Text))
            {
                errorIcono.SetError(txtAgCategoria, "Este campo es obligatorio");
                datosValidos = false;
            }

            return datosValidos;

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


        private void GuardarCategoria(string categoria)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string sql = @"INSERT INTO Categorias (Nombre)
                               VALUES (@Categoria)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Categoria", categoria);


                    conn.Open();
                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado <= 0)
                    {
                        MessageBox.Show("No se almacenó correctamente el registro", "Información",
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

        #endregion

        #region Botones

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarCat_Click(object sender, EventArgs e)
        {
            errorIcono.Clear();

            if (!validarCampos())
            {
                MessageBox.Show("Informacion Incompleta, seran remarcados los campos faltantes",
                                "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string nombre = txtAgCategoria.Text.Trim();
            bool estadoNuevo = chkActivo.Checked; //NOTA: Nuevo nombre de variable para claridad
            bool operacionExitosa = false;

            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text.Trim()))
                {
                    DialogResult resultado = MessageBox.Show("Desea guardar la nueva categoria",
                                "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        return;
                    }

                    GuardarCategoria(nombre);
                    operacionExitosa = true;
                }
                else
                {
                    if (!int.TryParse(txtId.Text.Trim(), out int categoriaId))
                    {
                        MessageBox.Show("El ID de la categoria es inválido", "Validación",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // ¿El usuario está intentando desactivar una categoría que antes estaba activa?
                    if (this._estadoOriginalActivo == true && estadoNuevo == false)
                    {
                        // Si es así, corremos la validación de productos.
                        if (!ValidarCategoria(categoriaId))
                        {
                            // La validación falló y mostró un error.
                            // Detenemos el guardado.
                            return;
                        }
                    }

                    DialogResult resultado = MessageBox.Show("Desea aplicar los cambios", "Informaciobn",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resultado == DialogResult.No) return;

                    ActualizarCategoria(categoriaId, nombre, estadoNuevo);
                    operacionExitosa = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (operacionExitosa) registroAgregado?.Invoke();
        }

        #endregion




    }
}
