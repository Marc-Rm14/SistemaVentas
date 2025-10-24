using app.Ventas.Utilidades;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class FrmAgregarCliente : Form
    {
        public event Action registroAgregado;
        public FrmAgregarCliente()
        {
            InitializeComponent();
        }

        
        public FrmAgregarCliente(int id, string cedula, string nombre, string telefono)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
            txtCedula.Text = cedula;
            txtNombre.Text = nombre;
            txtTelefono.Text = telefono;

        }

        private void ActualizarCliente(int usuarioId, string cedula, string nombre, string telefono)
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consulta = @"UPDATE Clientes
                                        SET Cedula = @Cedula,
                                            NombreCompleto = @Nombre,
                                            Telefono = @Telefono
                                        WHERE ClienteID = @usuarioId";

                    SqlCommand command = new SqlCommand(consulta, conexion);
                    command.Parameters.Add("@usuarioId",SqlDbType.Int).Value = usuarioId;
                    command.Parameters.Add("@Cedula", SqlDbType.VarChar, 20).Value = cedula;
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = nombre;
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar,20).Value = telefono;
                    
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

        private void GuardarCliente(string cedula, string nombre, string telefono)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string sql = @"INSERT INTO Clientes (Cedula, NombreCompleto, Telefono)
                               VALUES (@Cedula, @Nombre, @Telefono)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Cedula", SqlDbType.VarChar, 20).Value = cedula ;
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = nombre;
                    cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 20).Value = telefono;
                    

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
                    
                    //LimpiarControles();
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


        private void LimpiarControles()
        {
            
            foreach (var cajaTexto in tableLayoutPanel1.Controls.OfType<TextBox>())
            {
                cajaTexto.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorIcono.Clear();

            //TODO: AQUI sigo
            if (!validarCampos())
            {
                MessageBox.Show("Informacion Incompleta, seran remarcados los campos faltantes",
                    "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // TODO: CONTINUAMOS DESDE AQUÍ
            string cedula = txtCedula.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();



            bool operacionExitosa = false;
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text.Trim()))
                {
                    
                    if (MessageBox.Show("Desea guardar el nuevo Cliente", "Informacion", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                    //Verificamos que el usuario este seguro de la operación
                    //Si el resultado del dialogo es 'No' entonces salimos
                    //de este bloque de codigo inmediatamente 

                    // GUARDAR NUEVO PRODUCTO
                    GuardarCliente(cedula, nombre, telefono);
                    operacionExitosa = true;

                }
                else
                {
                    if (!int.TryParse(txtId.Text.Trim(), out int clienteId))
                    {
                        MessageBox.Show("El ID del producto es inválido", "Validación",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DialogResult resultado = MessageBox.Show("Desea aplicar los cambios", "Informaciobn",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resultado == DialogResult.No) return;

                        // ACTUALIZAR PRODUCTO EXISTENTE
                    ActualizarCliente(clienteId, cedula, nombre, telefono);

                    operacionExitosa = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (operacionExitosa) 
            { registroAgregado?.Invoke(); }
        }
    }
}
