using app.Ventas.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class UcDashBoard : UserControl
    {
        public UcDashBoard()
        {
            InitializeComponent();
        }


        private void UCDashBoard_Load(object sender, EventArgs e)
        {
            CargarGraficoBarrasTop();
            CargarGraficoPastel();
        }

        public void RefrescarDashBoard()
        {
            CargarGraficoBarrasTop();
            CargarGraficoPastel();
        }

        private void CargarGraficoBarrasTop()
        {
            try
            {

                string connectionString = ConexionDB.ObtenerConexion();
                const string sql = @"
                            SELECT TOP 5 p.Nombre AS Nombre, SUM(dv.Cantidad) AS CantidadTotal
                            FROM DetallesVenta dv
                            INNER JOIN Productos p ON dv.ProductoID = p.ProductoID
                            GROUP BY p.Nombre
                            ORDER BY CantidadTotal DESC;";

                /// Creamos dos listas
                var nombres = new List<string>();
                var cantidades = new List<double>();

                using (var con = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nombres.Add(reader["Nombre"].ToString());
                            cantidades.Add(Convert.ToDouble(reader["CantidadTotal"]));
                        }
                    }
                }

                // Si no hay datos, limpiar y salir
                if (nombres.Count == 0)
                {
                    formsPlotBarras.Plot.Clear();
                    formsPlotBarras.Refresh();
                    return;
                }


                formsPlotBarras.Plot.Clear();

                formsPlotBarras.Plot.FigureBackground.Color = ScottPlot.Colors.Transparent;
                formsPlotBarras.Plot.DataBackground.Color = ScottPlot.Colors.Transparent;

                // Crear posiciones
                double[] positions = new double[nombres.Count];
                for (int i = 0; i < nombres.Count; i++)
                    positions[i] = i;

                // Agregar cada barra individualmente con su color
                ScottPlot.Color[] colores = new ScottPlot.Color[]
                                        {
                                            new ScottPlot.Color(120, 0, 0),       // #780000 - Rojo oscuro
                                            new ScottPlot.Color(193, 18, 31),     // #c1121f - Rojo
                                            new ScottPlot.Color(0, 48, 73),       // #003049 - Azul oscuro
                                            new ScottPlot.Color(253, 240, 213),   // #fdf0d5 - Beige claro
                                            new ScottPlot.Color(102, 155, 188)    // #669bbc - Azul medio
                                        };

                //NOTA: Podemos usar HEX(Color.FromHex) o color 

                // Crear cada barra individualmente y asignar color
                for (int i = 0; i < positions.Length; i++)
                {
                    var bar = formsPlotBarras.Plot.Add.Bar(positions[i], cantidades[i]);
                    bar.Color = colores[i];
                }

                // Configurar ejes
                formsPlotBarras.Plot.Axes.Bottom.SetTicks(positions, nombres.ToArray());
                formsPlotBarras.Plot.Axes.Bottom.Label.Text = "Productos";
                formsPlotBarras.Plot.Axes.Left.Label.Text = "Cantidad Vendida";
                //NOTA: Elimine el titulo, se agrego un label.

                formsPlotBarras.Plot.Axes.SetLimits(bottom: 0);

                formsPlotBarras.Plot.HideGrid();
                
                //formsPlotBarras.Plot.Axes.AutoScale();
                formsPlotBarras.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private void CargarGraficoBarrasVentas()
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                const string sql = @"SELECT
                                CONVERT(date, FechaVenta) AS Dia,
                                SUM(Total) AS TotalVendido
                            FROM
                                Ventas
                            WHERE
                                FechaVenta >= DATEADD(day, -7, GETDATE()) 
                            GROUP BY
                                CONVERT(date, FechaVenta)
                            ORDER BY
                                Dia ASC;";

                var fechas = new List<DateTime>();
                var totales = new List<double>();

                using (var con = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            fechas.Add(Convert.ToDateTime(reader["Dia"]));
                            totales.Add(Convert.ToDouble(reader["TotalVendido"]));
                        }
                    }
                }

                formsPlotBarras.Plot.Clear();

                // Crear posiciones
                double[] positions = new double[fechas.Count];
                for (int i = 0; i < fechas.Count; i++)
                    positions[i] = i;

                // Definir colores
                ScottPlot.Color[] colores = new ScottPlot.Color[]
                {
                    new ScottPlot.Color(120, 0, 0),       // #780000 - Rojo oscuro
                    new ScottPlot.Color(193, 18, 31),    // #c1121f - Rojo
                    new ScottPlot.Color(0, 48, 73),      // #003049 - Azul oscuro
                    new ScottPlot.Color(253, 240, 213),  // #fdf0d5 - Beige claro
                    new ScottPlot.Color(102, 155, 188),  // #669bbc - Azul medio
                    new ScottPlot.Color(253, 240, 213),  // #fdf0d5 - Beige claro
                    new ScottPlot.Color(102, 155, 188)   // #669bbc - Azul medio
                };

                
                for (int i = 0; i < positions.Length; i++)
                {
                    var bar = formsPlotBarras.Plot.Add.Bar(positions[i], totales[i]);

                    
                    bar.Color = colores[i % colores.Length];
                }

                
                //Esta vaina es lambda 
                string[] etiquetas = fechas.Select(f => f.ToString("dd/MM")).ToArray();

                
                formsPlotBarras.Plot.Axes.Bottom.SetTicks(positions, etiquetas);

                
                formsPlotBarras.Plot.Axes.Bottom.Label.Text = "Día";
                formsPlotBarras.Plot.Axes.Left.Label.Text = "Total Vendido";

                formsPlotBarras.Plot.Axes.SetLimits(bottom: 0);
                formsPlotBarras.Plot.Axes.AutoScale();
                formsPlotBarras.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el gráfico: {ex.Message}");
            }
        }


        private void CargarGraficoPastel()
        {
            try
            {
                
                string connectionString = ConexionDB.ObtenerConexion();
                const string sql = @"
                                    SELECT TOP 5 c.Nombre AS Categoria, SUM(dv.Cantidad) AS TotalVendido
                                    FROM DetallesVenta dv
                                    INNER JOIN Productos p ON dv.ProductoID = p.ProductoID
                                    INNER JOIN Categorias c ON p.CategoriaID = c.CategoriaID
                                    GROUP BY c.Nombre
                                    ORDER BY TotalVendido DESC;";

                var categorias = new List<string>();
                var totales = new List<double>();

                using (var con = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorias.Add(reader["Categoria"].ToString());
                            totales.Add(Convert.ToDouble(reader["TotalVendido"]));
                        }
                    }
                }

                // Si no hay datos, limpiar y salir
                if (categorias.Count == 0)
                {
                    formsPlotPastel.Plot.Clear();
                    formsPlotPastel.Refresh();
                    MessageBox.Show("No se encontraron datos para graficar.", "Advertencia",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                formsPlotPastel.Plot.Clear();

                formsPlotPastel.Plot.FigureBackground.Color = ScottPlot.Colors.Transparent;
                formsPlotPastel.Plot.DataBackground.Color = ScottPlot.Colors.Transparent;

                var slices = new List<ScottPlot.PieSlice>();
                // SOLO 5 COLORES (igual que el gráfico de barras)
                ScottPlot.Color[] coloresPastel = new ScottPlot.Color[]
                {
                    ScottPlot.Color.FromHex("#780000"),  // Rojo oscuro
                    ScottPlot.Color.FromHex("#c1121f"),  // Rojo
                    ScottPlot.Color.FromHex("#003049"),  // Azul oscuro
                    ScottPlot.Color.FromHex("#669bbc"),  // Azul medio
                    ScottPlot.Color.FromHex("#fdf0d5")   // Beige
                                
                };

                for (int i = 0; i < categorias.Count; i++)
                {
                    var slice = new ScottPlot.PieSlice();
                    slice.Value = totales[i];
                    slice.FillColor = coloresPastel[i % coloresPastel.Length];
                    slice.Label = categorias[i];
                    slice.LegendText = categorias[i];
                    slices.Add(slice);
                }

                var pie = formsPlotPastel.Plot.Add.Pie(slices);

                
                pie.ExplodeFraction = 0.1; // Separación entre rebanadas
                pie.SliceLabelDistance = 1.4; // Distancia de las etiquetas

                
                pie.LineColor = ScottPlot.Colors.Black;
                pie.LineWidth = 1;

                
                formsPlotPastel.Plot.ShowLegend();

                // Configurar la leyenda basado en propiedades disponibles
                formsPlotPastel.Plot.Legend.FontSize = 10;
                formsPlotPastel.Plot.Legend.Alignment = ScottPlot.Alignment.UpperRight;

                

                // Ocultar ejes y grid para mejor visualización
                formsPlotPastel.Plot.Axes.Frameless();
                formsPlotPastel.Plot.HideGrid();

                formsPlotPastel.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el gráfico: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
