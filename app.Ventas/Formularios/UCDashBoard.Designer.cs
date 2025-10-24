namespace app.Ventas.Formularios
{
    partial class UCDashBoard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.lblTotalVentasHoy = new CuoreUI.Controls.cuiLabel();
            this.lblProductosVendidosHoy = new CuoreUI.Controls.cuiLabel();
            this.chartVentasSemana = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasSemana)).BeginInit();
            this.SuspendLayout();
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.chartVentasSemana);
            this.cuiPanel1.Controls.Add(this.lblProductosVendidosHoy);
            this.cuiPanel1.Controls.Add(this.lblTotalVentasHoy);
            this.cuiPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiPanel1.Location = new System.Drawing.Point(43, 15);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.White;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Size = new System.Drawing.Size(888, 525);
            this.cuiPanel1.TabIndex = 0;
            // 
            // lblTotalVentasHoy
            // 
            this.lblTotalVentasHoy.Content = "Your\\ text\\ here!";
            this.lblTotalVentasHoy.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblTotalVentasHoy.Location = new System.Drawing.Point(98, 56);
            this.lblTotalVentasHoy.Name = "lblTotalVentasHoy";
            this.lblTotalVentasHoy.Size = new System.Drawing.Size(210, 47);
            this.lblTotalVentasHoy.TabIndex = 0;
            this.lblTotalVentasHoy.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblProductosVendidosHoy
            // 
            this.lblProductosVendidosHoy.Content = "Your\\ text\\ here!";
            this.lblProductosVendidosHoy.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblProductosVendidosHoy.Location = new System.Drawing.Point(512, 56);
            this.lblProductosVendidosHoy.Name = "lblProductosVendidosHoy";
            this.lblProductosVendidosHoy.Size = new System.Drawing.Size(210, 47);
            this.lblProductosVendidosHoy.TabIndex = 1;
            this.lblProductosVendidosHoy.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // chartVentasSemana
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVentasSemana.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartVentasSemana.Legends.Add(legend2);
            this.chartVentasSemana.Location = new System.Drawing.Point(111, 178);
            this.chartVentasSemana.Name = "chartVentasSemana";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartVentasSemana.Series.Add(series2);
            this.chartVentasSemana.Size = new System.Drawing.Size(634, 300);
            this.chartVentasSemana.TabIndex = 2;
            this.chartVentasSemana.Text = "chart1";
            // 
            // UCDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cuiPanel1);
            this.Name = "UCDashBoard";
            this.Size = new System.Drawing.Size(968, 574);
            this.Load += new System.EventHandler(this.UCDashBoard_Load);
            this.cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasSemana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentasSemana;
        private CuoreUI.Controls.cuiLabel lblProductosVendidosHoy;
        private CuoreUI.Controls.cuiLabel lblTotalVentasHoy;
    }
}
