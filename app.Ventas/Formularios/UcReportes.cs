using app.Ventas.Utilidades;
using System;
using System.Collections.Generic; // Para usar List<T>
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class UcReportes : UserControl
    {
        public UcReportes()
        {
            InitializeComponent();
        }

        

        private void UcReportes_Load(object sender, EventArgs e)
        {
            // Cargamos los combobox
            CargarUsuarios();
            cargarClientes();

            // Llamamos al botón Limpiar para establecer los valores por defecto
            ibtnLimpiarFiltros_Click(sender, e);
        }

        private void ibtnReporte_Click(object sender, EventArgs e)
        {
            // Recolectar todos los valores de los filtros
            int idUsuarioSeleccionado = (cmbUsuarios.SelectedValue != null) ? (int)cmbUsuarios.SelectedValue : 0;
            int idClienteSeleccionado = (cmbClientes.SelectedValue != null) ? (int)cmbClientes.SelectedValue : 0;

            
            // Usamos .Content en lugar de .Value acuerdece que usamos controles de otra libreria
            DateTime fechaInicio = cuiDtpFechaInicio.Content;
            DateTime fechaFin = cuiDtpFechaFin.Content;
            

            // Validar que las fechas sean lógicas
            if (fechaInicio.Date > fechaFin.Date)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.", "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llamar al método de generación
            try
            {
                GenerarReporte(idUsuarioSeleccionado, idClienteSeleccionado, fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
            }
        }

        private void ibtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            // Resetear ComboBoxes a "[Todos]"
            cmbClientes.SelectedIndex = 0;
            cmbUsuarios.SelectedIndex = 0;

            
            // Usamos .Content en lugar de .Value para asignar las fechas
            // Establecer un rango de fechas por defecto (El mes actual)
            cuiDtpFechaInicio.Content = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // se crea una nueva intancia de esta clase
            cuiDtpFechaFin.Content = DateTime.Now;
            

            
            dgvReportes.DataSource = null;

            
            cuiLblTotalRegistros.Content = "Mostrando: 0 ventas";
            cuiLblTotalVendido.Content = "Suma Total: $0.00";
        }

        private void CargarUsuarios()
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string consultaSql = "SELECT UsuarioID, NombreCompleto AS Nombre FROM Usuarios ORDER BY Nombre";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(consultaSql, conexion))
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);

                    // Añadir la fila "TODOS"
                    DataRow filaTodos = dataTable.NewRow();
                    filaTodos["UsuarioID"] = 0; // ID 0 significa "Todos"
                    filaTodos["Nombre"] = "[Todos los Usuarios]";
                    dataTable.Rows.InsertAt(filaTodos, 0); // Insertar al inicio

                    cmbUsuarios.DataSource = dataTable;
                    cmbUsuarios.DisplayMember = "Nombre";
                    cmbUsuarios.ValueMember = "UsuarioID";
                    cmbUsuarios.SelectedIndex = 0; // Dejar "[Todos]" seleccionado
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cargar los usuarios: " + ex.Message);
            }
        }

        private void cargarClientes()
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string consultaSql = "SELECT ClienteID, NombreCompleto AS Nombre FROM Clientes ORDER BY Nombre";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(consultaSql, conexion))
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);

                    //Añadir la fila "TODOS" 
                    DataRow filaTodos = dataTable.NewRow();
                    filaTodos["ClienteID"] = 0; // ID 0 significa "Todos"
                    filaTodos["Nombre"] = "[Todos los Clientes]";
                    dataTable.Rows.InsertAt(filaTodos, 0); // Insertar al inicio

                    cmbClientes.DataSource = dataTable;
                    cmbClientes.DisplayMember = "Nombre";
                    cmbClientes.ValueMember = "ClienteID";
                    cmbClientes.SelectedIndex = 0; // Dejar "[Todos]" seleccionado
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cargar los clientes: " + ex.Message);
            }
        }


        /// <summary>
        /// Genera el reporte construyendo una consulta SQL dinámica y segura
        /// basada en todos los filtros seleccionados.
        /// </summary>
        private void GenerarReporte(int idUsuario, int idCliente, DateTime fechaInicio, DateTime fechaFin)
        {
            string connectionString = ConexionDB.ObtenerConexion();

            // 1. Consulta Base (el "esqueleto")
            string consultaSql = @"SELECT v.FechaVenta, v.Total, p.Nombre, dv.Cantidad, dv.PrecioUnitario
                                   FROM Ventas v
                                   INNER JOIN DetallesVenta dv ON v.VentaID = dv.VentaID
                                   INNER JOIN Productos p ON dv.ProductoID = p.ProductoID";

            // Listas para los "partes" de la consulta
            List<string> condiciones = new List<string>();
            List<SqlParameter> parametros = new List<SqlParameter>();

            // Añadir filtro de FECHAS (siempre se aplica)
            // Usamos >= para el inicio y < (menor que) para el fin
            // "FechaFin.Date.AddDays(1)" asegura que se incluya el día completo.
            condiciones.Add("v.FechaVenta >= @fechaInicio");
            parametros.Add(new SqlParameter("@fechaInicio", fechaInicio.Date));

            condiciones.Add("v.FechaVenta < @fechaFin");
            parametros.Add(new SqlParameter("@fechaFin", fechaFin.Date.AddDays(1)));

            // Añadir filtro de USUARIO (solo si no es "Todos")
            // Por eso le asignamos el 0, es nuestra señal para ignorar este filtro
            if (idUsuario != 0)
            {
                condiciones.Add("v.UsuarioID = @idUsuario");
                parametros.Add(new SqlParameter("@idUsuario", idUsuario));
            }

            //Añadir filtro de CLIENTE (solo si no es "Todos")
            if (idCliente != 0)
            {
                condiciones.Add("v.ClienteID = @idCliente");
                parametros.Add(new SqlParameter("@idCliente", idCliente));
            }

            // Armar la consulta final
            // Unimos todas las condiciones con " AND "
            // string.Join va concatenando
            consultaSql += " WHERE " + string.Join(" AND ", condiciones);

            //Añadir orden
            consultaSql += " ORDER BY v.FechaVenta DESC";

            // Ejecutar la consulta
            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(consultaSql, conexion))
            {
                // Añadimos todos los parámetros de forma segura
                da.SelectCommand.Parameters.AddRange(parametros.ToArray());

                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                dgvReportes.DataSource = dataTable;

                //Calcular y mostrar los totales
                CalcularTotales(dataTable);
            }
        }

        /// <summary>
        /// Calcula los totales del DataTable y los muestra en los Labels.
        /// </summary>
        private void CalcularTotales(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                cuiLblTotalRegistros.Content = "Mostrando: 0 ventas";
                cuiLblTotalVendido.Content = "Suma Total: $0.00";
                return;
            }

            int totalRegistros = dt.Rows.Count;
            decimal sumaTotalVentas = 0;

            foreach (DataRow fila in dt.Rows)
            {
                // Sumamos la columna "Total" de cada fila
                if (fila["Total"] != DBNull.Value) // Que no sea nula la vaina, YA!!!!!
                {
                    sumaTotalVentas += Convert.ToDecimal(fila["Total"]);
                }
            }
            //Recordar que en vez de Text usamos Content es equivalente en estos controles
            //Damos formato a los labels
            cuiLblTotalRegistros.Content = $"Mostrando: {totalRegistros} ventas";
            cuiLblTotalVendido.Content = $"Suma Total: {sumaTotalVentas:C}"; // "C" da formato de moneda
        }
    }

    //---- Final quedo perron ----
    //TODO: agregar un boton para generar un excel ajajjaja.
}