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
                            ORDER BY Producto";

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
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarClientes()
        {
            string connectionString = ConexionDB.ObtenerConexion();

            string consultaSql = @"SELECT ClienteID, Cedula, NombreCompleto, telefono
                                   From Clientes
                                   ORDER BY NombreCompleto";

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


        private void GuardarVenta(int cliente, int usuario, decimal totalVentas, DataGridView detalles)
        {
            if (cmbClientes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (detalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe añadir al menos un producto a la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

                    foreach (DataGridViewRow row in detalles.Rows)
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
                    MessageBox.Show("Venta guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error al guardar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        }


        private void ibtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem == null) //NOTA: Primeramente hacemso validaciones
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
            int cantidad = (int)numCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantida debe ser mayor a cero");
                return;// El return sirve como un guardian ; si la condicionse cumple se detiene la ejecucion del metodo.
            }

            if (cantidad > existencias)
            {
                MessageBox.Show($"Stock insuficiente. Solo quedan {existencias} unidades de {nombre}.", "Stock Agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución, no añade el producto
            }


            // --- FIN DE LA VALIDACIÓN ---

            decimal subtotal = cantidad * precio;
            dgvDetalles.Rows.Add(id, nombre, cantidad, precio, subtotal);


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
                lblCliente.Text = "Cliente Selecionado: N/A";
                return;
            }
            DataRowView drv = (DataRowView)cmbClientes.SelectedItem;
            int id = Convert.ToInt32(drv["ClienteID"]);
            string nombre = drv["NombreCompleto"].ToString();
            string cedula = drv["Cedula"].ToString();
            string telefono = drv["Telefono"].ToString(); //Accedemos por nombre de columna

            lblCliente.Text = $"Cliente seleccionado: {nombre}";


        }

        private void ibtnLimpiar_Click(object sender, EventArgs e)
        {
            cmbClientes.SelectedIndex = -1;
            cmbProductos.SelectedIndex = -1;
            numCantidad.Value = 1;
            dgvDetalles.Rows.Clear();
        }

        private void ibtnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un cliente antes de guardar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            decimal totalVenta = _totalVenta;
            int cliente = Convert.ToInt32(cmbClientes.SelectedValue);
            int usuarioActual = _usuarioLogueado.UsuarioID;

            GuardarVenta(cliente, usuarioActual, totalVenta, dgvDetalles); //NOTA: El ultimo paramtero es
                                                                           //el datagridView que llenamos con la selecciones.
            LimpiarFormularioVenta();
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
