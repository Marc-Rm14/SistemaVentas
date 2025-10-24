using app.Ventas.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class FrmAgregarProductos : Form
    {
        public event Action registroAgregado;
        
        public FrmAgregarProductos()
        {
            InitializeComponent();
            this.txtExistencias.KeyPress += new KeyPressEventHandler(txtExistencias_KeyPress);
            CargarCategorias();
            this.CancelButton = btnCancelar;
            txtCodigo.Text = "(Se generará al guardar)"; //NOTA: se genera en base de datos, solo informamos la situacion.
            
        }

        public FrmAgregarProductos(int idProducto, string nombre, decimal precio, string codigo, int existencia, int idCategoria)
        {
            InitializeComponent();
            CargarCategorias(); // importante: cargar antes de fijar SelectedValue
            
            this.txtExistencias.KeyPress += new KeyPressEventHandler(txtExistencias_KeyPress);

            txtId.Text = idProducto.ToString();
            txtNombre.Text = nombre;
            txtPrecio.Text = precio.ToString();
            txtCodigo.Text = codigo;
            txtExistencias.Text = existencia.ToString();
            
            // Selecciona la categoría en el combobox (si existe)
            try
            {  
                cmbCategorias.SelectedValue = idCategoria;

            }
            catch { /* si no encuentra, no hacemos nada */ }
            
        }
        #region metodos
        

        private void CargarCategorias()
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string sql = @"SELECT CategoriaID, Nombre 
                               FROM Categorias
                               ORDER BY Nombre";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCategorias.DataSource = dt;
                    cmbCategorias.DisplayMember = "Nombre";
                    cmbCategorias.ValueMember = "CategoriaID";
                    cmbCategorias.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarProducto(int productoId, string nombre, decimal precio, int categoriaId, int existencias)
        {
            try
            {
                string connetionString = ConexionDB.ObtenerConexion();

                using (SqlConnection conexion = new SqlConnection(connetionString))
                {
                    string consulta = @"UPDATE Productos
                                SET Nombre = @Nombre,
                                    Precio = @Precio,
                                    Existencias = @Existencias,
                                    CategoriaID = @CategoriaID
                                WHERE ProductoID = @ProductoID";

                    using (SqlCommand command = new SqlCommand(consulta, conexion)) //TODO: cambiar addwithvalue a ADD y expecificar tipo de datos
                                                                                     //extension y demas.
                    {
                        command.Parameters.Add("@ProductoID",SqlDbType.Int).Value = productoId;// De esta manera
                        command.Parameters.Add("@Nombre", SqlDbType.NVarChar,150).Value = nombre; 
                        command.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;
                        command.Parameters.Add("@Existencias", SqlDbType.Int).Value = existencias;
                        command.Parameters.Add("@CategoriaID", SqlDbType.Int).Value =categoriaId;

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



        private void GuardarProducto(string nombre, decimal precio, int categoriaId, int existencias)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string sql = @"INSERT INTO Productos (Nombre, Precio, Existencias, CategoriaID)
                       VALUES (@Nombre, @Precio, @Existencias, @CategoriaID)"; 

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 150).Value = nombre;
                    cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;
                    cmd.Parameters.Add("@Existencias", SqlDbType.Int).Value = existencias;
                    cmd.Parameters.Add("@CategoriaID", SqlDbType.Int).Value = categoriaId;

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
        #endregion


        #region Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorIcono.Clear();

            if (!validarCampos())
            {
                MessageBox.Show("Información incompleta, se remarcarán los campos faltantes",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string nombre = txtNombre.Text.Trim();

            //NOTA: Se añadio mas seguridad a la información proporcionada por el usuario
            decimal precio;

            if(!decimal.TryParse(txtPrecio.Text.Trim(),out precio))
            {
                MessageBox.Show("El formato del precio no es válido", "Validación");
                errorIcono.SetError(txtPrecio, "Ingrese un numero válido");
                txtPrecio.Focus();
                return;
            }

            // Validar categoría seleccionada
            if (cmbCategorias.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoría", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategorias.Focus();
                return;
            }
            int categoriaId = (int)cmbCategorias.SelectedValue;


            // Mas seguro
            int existencias;

            if(!int.TryParse(txtExistencias.Text.Trim(),out existencias)) 
            {
                MessageBox.Show("El formato de las existencias no es valido", "validación");
                errorIcono.SetError(txtExistencias,"Ingrese un numero entero");
                txtExistencias.Focus();
                return;
            }

            //NOTA: Añadi una bandera que sirve como seguro para recargar los datos cuando la operacion tiene exito, por defecto es false.
            bool operacionExitosa = false;

            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text.Trim()))
                {
                    //Solo si el dialogo es si seguimos con la ejecucion del codigo, si no salimos.
                    if (MessageBox.Show("¿Desea guardar el nuevo producto?", "Información",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                    // GUARDAR NUEVO PRODUCTO
                    GuardarProducto(nombre, precio, categoriaId, existencias);
                        
                    operacionExitosa = true;
                    
                }
                else
                {
                    if (!int.TryParse(txtId.Text.Trim(), out int productoId))
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
                    ActualizarProducto(productoId, nombre, precio, categoriaId, existencias);

                    operacionExitosa = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //NOTA: Incocar el evento solo si la Db tuvo éxito.
            if (operacionExitosa) registroAgregado?.Invoke();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region eventos


        private void txtExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGuardar.PerformClick();
                e.Handled = true;
            }
        }
        #endregion

        private void FrmAgregarProductos_Load(object sender, EventArgs e)
        {
            UtilsFormularios.ActivarMoverFocoConEnter(this);
        }
    }
}
