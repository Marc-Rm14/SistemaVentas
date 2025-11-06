namespace app.Ventas.Formularios
{
    partial class UcReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcReportes));
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cuiGbFiltros = new CuoreUI.Controls.cuiGroupBox();
            this.ibtnLimpiarFiltros = new FontAwesome.Sharp.IconButton();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.ibtnReporte = new FontAwesome.Sharp.IconButton();
            this.cuiCalendarDatePicker2 = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.cuiCalendarDatePicker1 = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.cuiPanelReportes = new CuoreUI.Controls.cuiPanel();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.cuiLblTotalRegistros = new CuoreUI.Controls.cuiLabel();
            this.cuiLblTotalVendido = new CuoreUI.Controls.cuiLabel();
            this.cuiPanel1.SuspendLayout();
            this.cuiGbFiltros.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            this.cuiPanelReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cuiPanel1.Controls.Add(this.cuiPanelReportes);
            this.cuiPanel1.Controls.Add(this.cuiPanel2);
            this.cuiPanel1.Controls.Add(this.cuiGbFiltros);
            this.cuiPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiPanel1.Location = new System.Drawing.Point(23, 20);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(1129, 593);
            this.cuiPanel1.TabIndex = 0;
            // 
            // cuiGbFiltros
            // 
            this.cuiGbFiltros.BackColor = System.Drawing.SystemColors.Control;
            this.cuiGbFiltros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiGbFiltros.Content = "Filtros de Reporte";
            this.cuiGbFiltros.Controls.Add(this.cuiLabel4);
            this.cuiGbFiltros.Controls.Add(this.cuiLabel3);
            this.cuiGbFiltros.Controls.Add(this.cuiLabel2);
            this.cuiGbFiltros.Controls.Add(this.cuiLabel1);
            this.cuiGbFiltros.Controls.Add(this.ibtnLimpiarFiltros);
            this.cuiGbFiltros.Controls.Add(this.cmbClientes);
            this.cuiGbFiltros.Controls.Add(this.cmbUsuarios);
            this.cuiGbFiltros.Controls.Add(this.ibtnReporte);
            this.cuiGbFiltros.Controls.Add(this.cuiCalendarDatePicker2);
            this.cuiGbFiltros.Controls.Add(this.cuiCalendarDatePicker1);
            this.cuiGbFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuiGbFiltros.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiGbFiltros.Location = new System.Drawing.Point(0, 0);
            this.cuiGbFiltros.Name = "cuiGbFiltros";
            this.cuiGbFiltros.Padding = new System.Windows.Forms.Padding(15, 33, 15, 15);
            this.cuiGbFiltros.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiGbFiltros.Size = new System.Drawing.Size(1129, 207);
            this.cuiGbFiltros.TabIndex = 0;
            // 
            // ibtnLimpiarFiltros
            // 
            this.ibtnLimpiarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnLimpiarFiltros.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnLimpiarFiltros.IconColor = System.Drawing.Color.Black;
            this.ibtnLimpiarFiltros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLimpiarFiltros.Location = new System.Drawing.Point(938, 146);
            this.ibtnLimpiarFiltros.Name = "ibtnLimpiarFiltros";
            this.ibtnLimpiarFiltros.Size = new System.Drawing.Size(129, 54);
            this.ibtnLimpiarFiltros.TabIndex = 9;
            this.ibtnLimpiarFiltros.Text = "LImpiar";
            this.ibtnLimpiarFiltros.UseVisualStyleBackColor = true;
            // 
            // cmbClientes
            // 
            this.cmbClientes.Location = new System.Drawing.Point(548, 172);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(245, 28);
            this.cmbClientes.TabIndex = 8;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(548, 77);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(245, 28);
            this.cmbUsuarios.TabIndex = 5;
            // 
            // ibtnReporte
            // 
            this.ibtnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnReporte.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnReporte.IconColor = System.Drawing.Color.Black;
            this.ibtnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnReporte.Location = new System.Drawing.Point(938, 51);
            this.ibtnReporte.Name = "ibtnReporte";
            this.ibtnReporte.Size = new System.Drawing.Size(129, 54);
            this.ibtnReporte.TabIndex = 3;
            this.ibtnReporte.Text = "Generar Reporte";
            this.ibtnReporte.UseVisualStyleBackColor = true;
            this.ibtnReporte.Click += new System.EventHandler(this.ibtnReporte_Click);
            // 
            // cuiCalendarDatePicker2
            // 
            this.cuiCalendarDatePicker2.Content = new System.DateTime(2025, 10, 21, 0, 0, 0, 0);
            this.cuiCalendarDatePicker2.EnableThemeChangeButton = true;
            this.cuiCalendarDatePicker2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiCalendarDatePicker2.ForeColor = System.Drawing.Color.Gray;
            this.cuiCalendarDatePicker2.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker2.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker2.Icon = ((System.Drawing.Image)(resources.GetObject("cuiCalendarDatePicker2.Icon")));
            this.cuiCalendarDatePicker2.IconTint = System.Drawing.Color.Gray;
            this.cuiCalendarDatePicker2.Location = new System.Drawing.Point(257, 79);
            this.cuiCalendarDatePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiCalendarDatePicker2.Name = "cuiCalendarDatePicker2";
            this.cuiCalendarDatePicker2.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker2.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker2.OutlineThickness = 1.5F;
            this.cuiCalendarDatePicker2.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.BottomRight;
            this.cuiCalendarDatePicker2.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker2.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker2.Rounding = 15;
            this.cuiCalendarDatePicker2.ShowIcon = true;
            this.cuiCalendarDatePicker2.Size = new System.Drawing.Size(172, 59);
            this.cuiCalendarDatePicker2.TabIndex = 1;
            this.cuiCalendarDatePicker2.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // cuiCalendarDatePicker1
            // 
            this.cuiCalendarDatePicker1.Content = new System.DateTime(2025, 10, 21, 0, 0, 0, 0);
            this.cuiCalendarDatePicker1.EnableThemeChangeButton = true;
            this.cuiCalendarDatePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiCalendarDatePicker1.ForeColor = System.Drawing.Color.Gray;
            this.cuiCalendarDatePicker1.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("cuiCalendarDatePicker1.Icon")));
            this.cuiCalendarDatePicker1.IconTint = System.Drawing.Color.Gray;
            this.cuiCalendarDatePicker1.Location = new System.Drawing.Point(36, 79);
            this.cuiCalendarDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiCalendarDatePicker1.Name = "cuiCalendarDatePicker1";
            this.cuiCalendarDatePicker1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.OutlineThickness = 1.5F;
            this.cuiCalendarDatePicker1.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.BottomRight;
            this.cuiCalendarDatePicker1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.Rounding = 15;
            this.cuiCalendarDatePicker1.ShowIcon = true;
            this.cuiCalendarDatePicker1.Size = new System.Drawing.Size(172, 59);
            this.cuiCalendarDatePicker1.TabIndex = 0;
            this.cuiCalendarDatePicker1.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Desde:";
            this.cuiLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(18, 24);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(210, 47);
            this.cuiLabel1.TabIndex = 10;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Hasta:";
            this.cuiLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel2.Location = new System.Drawing.Point(234, 24);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(210, 47);
            this.cuiLabel2.TabIndex = 11;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.Content = "Usuarios:";
            this.cuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel3.Location = new System.Drawing.Point(566, 24);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(210, 47);
            this.cuiLabel3.TabIndex = 12;
            this.cuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.Content = "Clientes:";
            this.cuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel4.Location = new System.Drawing.Point(566, 116);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(210, 47);
            this.cuiLabel4.TabIndex = 13;
            this.cuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.cuiPanel2.Controls.Add(this.cuiLblTotalVendido);
            this.cuiPanel2.Controls.Add(this.cuiLblTotalRegistros);
            this.cuiPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cuiPanel2.Location = new System.Drawing.Point(0, 505);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel2.Size = new System.Drawing.Size(1129, 88);
            this.cuiPanel2.TabIndex = 10;
            // 
            // cuiPanelReportes
            // 
            this.cuiPanelReportes.BackColor = System.Drawing.SystemColors.Control;
            this.cuiPanelReportes.Controls.Add(this.dgvReportes);
            this.cuiPanelReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiPanelReportes.Location = new System.Drawing.Point(0, 207);
            this.cuiPanelReportes.Margin = new System.Windows.Forms.Padding(5);
            this.cuiPanelReportes.Name = "cuiPanelReportes";
            this.cuiPanelReportes.OutlineThickness = 1F;
            this.cuiPanelReportes.Padding = new System.Windows.Forms.Padding(5);
            this.cuiPanelReportes.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanelReportes.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanelReportes.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanelReportes.Size = new System.Drawing.Size(1129, 298);
            this.cuiPanelReportes.TabIndex = 11;
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.AllowUserToOrderColumns = true;
            this.dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportes.Location = new System.Drawing.Point(5, 5);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 28;
            this.dgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportes.Size = new System.Drawing.Size(1119, 288);
            this.dgvReportes.TabIndex = 5;
            // 
            // cuiLblTotalRegistros
            // 
            this.cuiLblTotalRegistros.Content = "Mostrando:\\ 0\\ Ventas";
            this.cuiLblTotalRegistros.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLblTotalRegistros.Location = new System.Drawing.Point(50, 28);
            this.cuiLblTotalRegistros.Name = "cuiLblTotalRegistros";
            this.cuiLblTotalRegistros.Size = new System.Drawing.Size(210, 47);
            this.cuiLblTotalRegistros.TabIndex = 0;
            this.cuiLblTotalRegistros.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLblTotalVendido
            // 
            this.cuiLblTotalVendido.Content = "Suma\\ Total:\\ C\\$0\\.00";
            this.cuiLblTotalVendido.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLblTotalVendido.Location = new System.Drawing.Point(831, 28);
            this.cuiLblTotalVendido.Name = "cuiLblTotalVendido";
            this.cuiLblTotalVendido.Size = new System.Drawing.Size(210, 47);
            this.cuiLblTotalVendido.TabIndex = 1;
            this.cuiLblTotalVendido.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // UcReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.cuiPanel1);
            this.Name = "UcReportes";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1174, 621);
            this.Load += new System.EventHandler(this.UcReportes_Load);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiGbFiltros.ResumeLayout(false);
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanelReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiGroupBox cuiGbFiltros;
        private CuoreUI.Controls.cuiCalendarDatePicker cuiCalendarDatePicker2;
        private CuoreUI.Controls.cuiCalendarDatePicker cuiCalendarDatePicker1;
        private FontAwesome.Sharp.IconButton ibtnReporte;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        
        private System.Windows.Forms.ComboBox cmbClientes;
        private FontAwesome.Sharp.IconButton ibtnLimpiarFiltros;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanelReportes;
        private System.Windows.Forms.DataGridView dgvReportes;
        private CuoreUI.Controls.cuiLabel cuiLblTotalVendido;
        private CuoreUI.Controls.cuiLabel cuiLblTotalRegistros;
    }
}
