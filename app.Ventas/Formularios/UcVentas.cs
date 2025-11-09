using app.Ventas.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class UcVentas : UserControl
    {
        private Usuario _usuarioLogueado;
        public event Action VentaGuardada;
        private decimal _totalVenta;
        public UcVentas()
        {
            InitializeComponent();

        }


        public UcVentas(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogueado = usuario;
        }

        private void CargarProductos()
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string sql = @"
                            SELECT ProductoID,
                                   Nombre,
                                   Precio,
                                   CONCAT(Nombre, ' - C$', Precio) AS Producto,
                                   Codigo,
                                   Existencias,
                                   CategoriaID
                            FROM Productos
                            WHERE Activo = 1
                            ORDER BY Producto
                            ";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbProductos.DataSource = dt;
                    cmbProductos.DisplayMember = "Producto";
                    cmbProductos.ValueMember = "ProductoID";
                    cmbProductos.SelectedIndex = -1;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los registros: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarClientes()
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();

                string consultaSql = @"SELECT ClienteID, Cedula, NombreCompleto, telefono
                                   From Clientes
                                   WHERE Activo = 1
                                   ORDER BY NombreCompleto
                                   ";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(consultaSql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbClientes.DataSource = dt;
                    cmbClientes.DisplayMember = "NombreCompleto";
                    cmbClientes.ValueMember = "ClienteID";
                    cmbClientes.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los registros: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnasGrid()
        {

            dgvDetalles.Columns.Clear(); // Limpiar por si acaso jeje
            dgvDetalles.Columns.Add("ProductoID", "ID Producto");
            dgvDetalles.Columns.Add("Nombre", "Producto");
            dgvDetalles.Columns.Add("Cantidad", "Cantidad");
            dgvDetalles.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvDetalles.Columns.Add("Subtotal", "Subtotal");

            //dgvDetalles.Visible = false;
            dgvDetalles.Columns["ProductoID"].Visible = false;

        }


        private bool GuardarVenta(int cliente, int usuario, decimal totalVentas)
        {
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe añadir al menos un producto a la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbClientes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string connectionString = ConexionDB.ObtenerConexion();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insertar venta
                    string sqlVenta = @"
                                INSERT INTO Ventas (ClienteID, UsuarioID, Total, FechaVenta) 
                                VALUES (@ClienteID, @UsuarioID, @Total, GETDATE());
                                SELECT SCOPE_IDENTITY();";

                    int nuevaVentaID;
                    using (SqlCommand cmdVenta = new SqlCommand(sqlVenta, conn, transaction))
                    {
                        cmdVenta.Parameters.Add("@ClienteID", SqlDbType.Int).Value = cliente;
                        cmdVenta.Parameters.Add("@UsuarioID", SqlDbType.Int).Value = usuario;
                        cmdVenta.Parameters.Add("@Total", SqlDbType.Decimal).Value = totalVentas;

                        nuevaVentaID = Convert.ToInt32(cmdVenta.ExecuteScalar());
                    }

                    // Insertar detalles
                    string sqlDetalle = @"
                                    INSERT INTO DetallesVenta (VentaID, ProductoID, Cantidad, PrecioUnitario)
                                    VALUES (@VentaID, @ProductoID, @Cantidad, @PrecioUnitario);";

                    //Actualizar las exsitencias
                    string sqlActualizarExistencias = @"
                                                UPDATE Productos
                                                SET Existencias = Existencias - @Cantidad
                                                WHERE ProductoID = @ProductoID;";

                    foreach (DataGridViewRow row in dgvDetalles.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int productoId = Convert.ToInt32(row.Cells["ProductoID"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        decimal precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);

                        // Insertar detalle
                        using (SqlCommand cmdDetalle = new SqlCommand(sqlDetalle, conn, transaction))
                        {
                            cmdDetalle.Parameters.AddWithValue("@VentaID", nuevaVentaID);
                            cmdDetalle.Parameters.AddWithValue("@ProductoID", productoId);
                            cmdDetalle.Parameters.AddWithValue("@Cantidad", cantidad);
                            cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", precio);
                            cmdDetalle.ExecuteNonQuery();
                        }

                        // Actualizar existencias
                        using (SqlCommand cmdActualizar = new SqlCommand(sqlActualizarExistencias, conn, transaction))
                        {
                            cmdActualizar.Parameters.AddWithValue("@ProductoID", productoId);
                            cmdActualizar.Parameters.AddWithValue("@Cantidad", cantidad);
                            cmdActualizar.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    VentaGuardada?.Invoke();
                    MessageBox.Show("Venta guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error al guardar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }



        private void LimpiarFormularioVenta()
        {
            cmbClientes.SelectedIndex = -1;
            cmbProductos.SelectedIndex = -1;
            // ...limpiar otros campos...
            dgvDetalles.Rows.Clear();
            lblTotalVenta.Text = "C$: 0.00";
        }

        private void UcVentas_Load(object sender, EventArgs e)
        {

            ConfigurarColumnasGrid();
            CargarProductos();
            CargarClientes();
            numCantidad.Value = 1;

        }


        private void ibtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem == null) //NOTA: Primeramente hacemos validaciones
            {
                MessageBox.Show("Selecione un Producto");
                return;
            }


            DataRowView drv = (DataRowView)cmbProductos.SelectedItem;

            //Hacemos las coverciones si es ncesario
            int id = Convert.ToInt32(drv["ProductoID"]);
            string nombre = drv["Nombre"].ToString();
            decimal precio = Convert.ToDecimal(drv["Precio"]);
            int existencias = Convert.ToInt32(drv["Existencias"]);
            int cantidadAAgregar = (int)numCantidad.Value;

            if (cantidadAAgregar <= 0)
            {
                MessageBox.Show("La cantida debe ser mayor a cero");
                return;// El return sirve como un guardian ; si la condicionse cumple se detiene la ejecucion del metodo.
            }

            if (cantidadAAgregar > existencias)
            {
                MessageBox.Show($"Stock insuficiente. Solo quedan {existencias} unidades de {nombre}.", "Stock Agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución, no añade el producto
            }

            // --- NOTA: Lógica para buscar duplicados ---

            bool productoYaExiste = false;

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.IsNewRow) continue; // Ignorar la fila nueva al final

                // Comparamos el ID del producto a agregar con los IDs en el grid
                int idEnGrid = Convert.ToInt32(row.Cells["ProductoID"].Value);

                if (idEnGrid == id)
                {
                    //El producto ya esta entonces Actualizamos la cantidad
                    productoYaExiste = true;
                    int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    int nuevaCantidad = cantidadActual + cantidadAAgregar;

                    // Tenemos que revalidar las existencias nuevamente
                    if (nuevaCantidad > existencias)
                    {
                        MessageBox.Show($"Stock insuficiente. Ya tiene {cantidadActual} en el carrito y solo quedan {existencias} unidades de {nombre}.", "Stock Agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Detiene la ejecución
                    }

                    // Si hay stock, actualizamos la fila existente
                    decimal nuevoSubtotal = nuevaCantidad * precio;
                    row.Cells["Cantidad"].Value = nuevaCantidad;
                    row.Cells["Subtotal"].Value = nuevoSubtotal;

                    break; // La Palabra reservada 'break' nos ayuda a salir inmediatanmente del bucle si encontramos el producto
                }
            }


            // Si el producto no se encontró en el bucle anterior, lo agregamos como nuevo
            if (!productoYaExiste)
            {
                // Validamos el stock (esta validación es solo para productos nuevos)
                if (cantidadAAgregar > existencias)
                {
                    MessageBox.Show($"Stock insuficiente. Solo quedan {existencias} unidades de {nombre}.", "Stock Agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detiene la ejecución, no añade el producto
                }

                // --- FIN DE LA VALIDACIÓN  ---

                decimal subtotal = cantidadAAgregar * precio;
                dgvDetalles.Rows.Add(id, nombre, cantidadAAgregar, precio, subtotal);
            }


            //Actualizar el total general
            CalcularTotalVenta();

            //Limpiar controles para el siguiente producto
            cmbProductos.SelectedIndex = -1;
            numCantidad.Value = 1;

        }


       

        private void CalcularTotalVenta()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.IsNewRow) continue;
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            _totalVenta = total;

            // Formatear solo para visualización (moneda local) Y que VIVA NICARAGUA.
            var cultura = new System.Globalization.CultureInfo("es-NI");
            lblTotalVenta.Text = $"El total es: {total.ToString("C", cultura)}";
        }



        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem == null)
            {
                lblCliente.Text = "Cliente Selecionado:\nN/A";
                return;
            }
            DataRowView drv = (DataRowView)cmbClientes.SelectedItem;
            int id = Convert.ToInt32(drv["ClienteID"]);
            string nombre = drv["NombreCompleto"].ToString();
            string cedula = drv["Cedula"].ToString();
            string telefono = drv["Telefono"].ToString(); //Accedemos por nombre de columna

            lblCliente.Text = $"Cliente seleccionado:\n{nombre}";


        }

        private void ibtnLimpiar_Click(object sender, EventArgs e)
        {
            cmbClientes.SelectedIndex = -1;
            cmbProductos.SelectedIndex = -1;
            numCantidad.Value = 1;
            dgvDetalles.Rows.Clear();
            CalcularTotalVenta();
        }

        private void ibtnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un cliente antes de guardar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe añadir al menos un producto a la venta.", "Error");
                return;
            }


            decimal totalVenta = _totalVenta;
            int cliente = Convert.ToInt32(cmbClientes.SelectedValue);
            int usuarioActual = _usuarioLogueado.UsuarioID;

            DialogResult resultado = MessageBox.Show("¿Confirmar venta?", "Confirmación de Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            //NOTA: Si nuestro Usuario dice no, salimos del bloque de codigo
            if (resultado == DialogResult.No) return;

            bool guardar = GuardarVenta(cliente, usuarioActual, totalVenta);

            if(guardar) LimpiarFormularioVenta();
        }

        private void ibtnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el producto que desea quitar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow filaSeleccionada = dgvDetalles.SelectedRows[0];

            if (!filaSeleccionada.IsNewRow)
            {
                //NOTA: Preguntar por seguridad
                string producto = filaSeleccionada.Cells["Nombre"].Value.ToString();
                var confirmacion = MessageBox.Show($"¿Está seguro de que desea quitar '{producto}' de la venta?",
                                                   "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {

                    dgvDetalles.Rows.Remove(filaSeleccionada);


                    CalcularTotalVenta();
                }
            }
        }

        
    }
}
