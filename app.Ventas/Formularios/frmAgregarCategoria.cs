using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using app.Ventas.Utilidades;

namespace app.Ventas.Formularios
{
    public partial class frmAgregarCategoria : Form
    {
        public event Action registroAgregado;
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        public frmAgregarCategoria(int categoriaId, string nombre)
        {
            InitializeComponent();
            txtId.Text = categoriaId.ToString();
            txtAgCategoria.Text = nombre;
        }

        #region

        private void ActualizarCategoria(int categoriaId, string categoria)
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consulta = @"UPDATE Categorias
                                        SET Nombre = @Categoria
                                        WHERE CategoriaID = @CategoriaID";

                    SqlCommand command = new SqlCommand(consulta, conexion);


                    command.Parameters.AddWithValue("@Categoria", categoria);
                    command.Parameters.AddWithValue("@CategoriaID", categoriaId);
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

            // TODO: CONTINUAR DESDE AQUI


            string nombre = txtAgCategoria.Text.Trim();

            bool operacionExitosa = false;

            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text.Trim()))
                {
                    DialogResult resultado = MessageBox.Show("Desea guardar la nueva categoria",
                        "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // GUARDAR NUEVO PRODUCTO
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
                    DialogResult resultado = MessageBox.Show("Desea aplicar los cambios", "Informaciobn",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resultado == DialogResult.No) return;

                    ActualizarCategoria(categoriaId, nombre);
                    operacionExitosa = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (operacionExitosa) registroAgregado?.Invoke(); //Si la Operacion se completo refrecamos. 
        }

        #endregion




    }
}
