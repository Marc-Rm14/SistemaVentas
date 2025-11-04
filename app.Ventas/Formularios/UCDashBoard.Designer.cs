namespace app.Ventas.Formularios
{
    partial class UcDashBoard
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
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTop = new CuoreUI.Controls.cuiLabel();
            this.lblCategoria = new CuoreUI.Controls.cuiLabel();
            this.formsPlotBarras = new ScottPlot.WinForms.FormsPlot();
            this.formsPlotPastel = new ScottPlot.WinForms.FormsPlot();
            this.cuiPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel1.Controls.Add(this.tableLayoutPanel1);
            this.cuiPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiPanel1.Location = new System.Drawing.Point(20, 20);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(1243, 688);
            this.cuiPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCategoria, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.formsPlotBarras, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.formsPlotPastel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1207, 651);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblTop
            // 
            this.lblTop.Content = "Top\\ 5\\ Productos\\ mas\\ Vendidos";
            this.lblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblTop.Location = new System.Drawing.Point(5, 5);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(595, 91);
            this.lblTop.TabIndex = 0;
            this.lblTop.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Content = "Top\\ 5\\ Categorías";
            this.lblCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblCategoria.Location = new System.Drawing.Point(606, 5);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(596, 91);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // formsPlotBarras
            // 
            this.formsPlotBarras.DisplayScale = 0F;
            this.formsPlotBarras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotBarras.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formsPlotBarras.Location = new System.Drawing.Point(5, 102);
            this.formsPlotBarras.Name = "formsPlotBarras";
            this.formsPlotBarras.Size = new System.Drawing.Size(595, 544);
            this.formsPlotBarras.TabIndex = 2;
            // 
            // formsPlotPastel
            // 
            this.formsPlotPastel.DisplayScale = 0F;
            this.formsPlotPastel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotPastel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formsPlotPastel.Location = new System.Drawing.Point(606, 102);
            this.formsPlotPastel.Name = "formsPlotPastel";
            this.formsPlotPastel.Size = new System.Drawing.Size(596, 544);
            this.formsPlotPastel.TabIndex = 3;
            // 
            // UcDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cuiPanel1);
            this.Name = "UcDashBoard";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.UCDashBoard_Load);
            this.cuiPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel lblCategoria;
        private CuoreUI.Controls.cuiLabel lblTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ScottPlot.WinForms.FormsPlot formsPlotBarras;
        private ScottPlot.WinForms.FormsPlot formsPlotPastel;
    }
}
