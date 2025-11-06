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
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cuiPanelReportes = new CuoreUI.Controls.cuiPanel();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.cuiLblTotalVendido = new CuoreUI.Controls.cuiLabel();
            this.cuiLblTotalRegistros = new CuoreUI.Controls.cuiLabel();
            this.cuiGbFiltros = new CuoreUI.Controls.cuiGroupBox();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.ibtnLimpiarFiltros = new FontAwesome.Sharp.IconButton();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.ibtnReporte = new FontAwesome.Sharp.IconButton();
            this.cuiDtpFechaFin = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.cuiDtpFechaInicio = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.cuiPanel1.SuspendLayout();
            this.cuiPanelReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.cuiPanel2.SuspendLayout();
            this.cuiGbFiltros.SuspendLayout();
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
            this.cuiPanel1.Location = new System.Drawing.Point(34, 31);
            this.cuiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(1694, 912);
            this.cuiPanel1.TabIndex = 0;
            // 
            // cuiPanelReportes
            // 
            this.cuiPanelReportes.BackColor = System.Drawing.SystemColors.Control;
            this.cuiPanelReportes.Controls.Add(this.dgvReportes);
            this.cuiPanelReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiPanelReportes.Location = new System.Drawing.Point(0, 318);
            this.cuiPanelReportes.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cuiPanelReportes.Name = "cuiPanelReportes";
            this.cuiPanelReportes.OutlineThickness = 1F;
            this.cuiPanelReportes.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cuiPanelReportes.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanelReportes.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanelReportes.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanelReportes.Size = new System.Drawing.Size(1694, 459);
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
            this.dgvReportes.Location = new System.Drawing.Point(8, 8);
            this.dgvReportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 28;
            this.dgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportes.Size = new System.Drawing.Size(1678, 443);
            this.dgvReportes.TabIndex = 5;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.cuiPanel2.Controls.Add(this.cuiLblTotalVendido);
            this.cuiPanel2.Controls.Add(this.cuiLblTotalRegistros);
            this.cuiPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cuiPanel2.Location = new System.Drawing.Point(0, 777);
            this.cuiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel2.Size = new System.Drawing.Size(1694, 135);
            this.cuiPanel2.TabIndex = 10;
            // 
            // cuiLblTotalVendido
            // 
            this.cuiLblTotalVendido.Content = "Suma\\ Total:\\ C\\$0\\.00";
            this.cuiLblTotalVendido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLblTotalVendido.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLblTotalVendido.Location = new System.Drawing.Point(1246, 43);
            this.cuiLblTotalVendido.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cuiLblTotalVendido.Name = "cuiLblTotalVendido";
            this.cuiLblTotalVendido.Size = new System.Drawing.Size(315, 72);
            this.cuiLblTotalVendido.TabIndex = 1;
            this.cuiLblTotalVendido.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLblTotalRegistros
            // 
            this.cuiLblTotalRegistros.Content = "Mostrando:\\ 0\\ Ventas";
            this.cuiLblTotalRegistros.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLblTotalRegistros.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLblTotalRegistros.Location = new System.Drawing.Point(75, 43);
            this.cuiLblTotalRegistros.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cuiLblTotalRegistros.Name = "cuiLblTotalRegistros";
            this.cuiLblTotalRegistros.Size = new System.Drawing.Size(315, 72);
            this.cuiLblTotalRegistros.TabIndex = 0;
            this.cuiLblTotalRegistros.VerticalAlignment = System.Drawing.StringAlignment.Near;
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
            this.cuiGbFiltros.Controls.Add(this.cuiDtpFechaFin);
            this.cuiGbFiltros.Controls.Add(this.cuiDtpFechaInicio);
            this.cuiGbFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuiGbFiltros.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiGbFiltros.Location = new System.Drawing.Point(0, 0);
            this.cuiGbFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiGbFiltros.Name = "cuiGbFiltros";
            this.cuiGbFiltros.Padding = new System.Windows.Forms.Padding(15, 43, 15, 15);
            this.cuiGbFiltros.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiGbFiltros.Size = new System.Drawing.Size(1694, 318);
            this.cuiGbFiltros.TabIndex = 0;
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.Content = "Clientes:";
            this.cuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel4.Location = new System.Drawing.Point(849, 178);
            this.cuiLabel4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(315, 72);
            this.cuiLabel4.TabIndex = 13;
            this.cuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.Content = "Usuarios:";
            this.cuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel3.Location = new System.Drawing.Point(849, 37);
            this.cuiLabel3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(315, 72);
            this.cuiLabel3.TabIndex = 12;
            this.cuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Hasta:";
            this.cuiLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel2.Location = new System.Drawing.Point(351, 37);
            this.cuiLabel2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(315, 72);
            this.cuiLabel2.TabIndex = 11;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Desde:";
            this.cuiLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(27, 37);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(315, 72);
            this.cuiLabel1.TabIndex = 10;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ibtnLimpiarFiltros
            // 
            this.ibtnLimpiarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnLimpiarFiltros.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnLimpiarFiltros.IconColor = System.Drawing.Color.Black;
            this.ibtnLimpiarFiltros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLimpiarFiltros.Location = new System.Drawing.Point(1414, 217);
            this.ibtnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ibtnLimpiarFiltros.Name = "ibtnLimpiarFiltros";
            this.ibtnLimpiarFiltros.Size = new System.Drawing.Size(194, 83);
            this.ibtnLimpiarFiltros.TabIndex = 9;
            this.ibtnLimpiarFiltros.Text = "LImpiar";
            this.ibtnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.ibtnLimpiarFiltros.Click += new System.EventHandler(this.ibtnLimpiarFiltros_Click);
            // 
            // cmbClientes
            // 
            this.cmbClientes.Location = new System.Drawing.Point(822, 265);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(366, 39);
            this.cmbClientes.TabIndex = 8;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(822, 118);
            this.cmbUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(366, 39);
            this.cmbUsuarios.TabIndex = 5;
            // 
            // ibtnReporte
            // 
            this.ibtnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnReporte.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnReporte.IconColor = System.Drawing.Color.Black;
            this.ibtnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnReporte.Location = new System.Drawing.Point(1414, 70);
            this.ibtnReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ibtnReporte.Name = "ibtnReporte";
            this.ibtnReporte.Size = new System.Drawing.Size(194, 83);
            this.ibtnReporte.TabIndex = 3;
            this.ibtnReporte.Text = "Generar Reporte";
            this.ibtnReporte.UseVisualStyleBackColor = true;
            this.ibtnReporte.Click += new System.EventHandler(this.ibtnReporte_Click);
            // 
            // cuiDtpFechaFin
            // 
            this.cuiDtpFechaFin.Content = new System.DateTime(2025, 10, 21, 0, 0, 0, 0);
            this.cuiDtpFechaFin.EnableThemeChangeButton = true;
            this.cuiDtpFechaFin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiDtpFechaFin.ForeColor = System.Drawing.Color.Gray;
            this.cuiDtpFechaFin.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiDtpFechaFin.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiDtpFechaFin.Icon = null;
            this.cuiDtpFechaFin.IconTint = System.Drawing.Color.Gray;
            this.cuiDtpFechaFin.Location = new System.Drawing.Point(386, 122);
            this.cuiDtpFechaFin.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cuiDtpFechaFin.Name = "cuiDtpFechaFin";
            this.cuiDtpFechaFin.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiDtpFechaFin.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiDtpFechaFin.OutlineThickness = 1.5F;
            this.cuiDtpFechaFin.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.BottomRight;
            this.cuiDtpFechaFin.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiDtpFechaFin.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiDtpFechaFin.Rounding = 15;
            this.cuiDtpFechaFin.ShowIcon = true;
            this.cuiDtpFechaFin.Size = new System.Drawing.Size(258, 91);
            this.cuiDtpFechaFin.TabIndex = 1;
            this.cuiDtpFechaFin.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // cuiDtpFechaInicio
            // 
            this.cuiDtpFechaInicio.Content = new System.DateTime(2025, 10, 21, 0, 0, 0, 0);
            this.cuiDtpFechaInicio.EnableThemeChangeButton = true;
            this.cuiDtpFechaInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiDtpFechaInicio.ForeColor = System.Drawing.Color.Gray;
            this.cuiDtpFechaInicio.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiDtpFechaInicio.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiDtpFechaInicio.Icon = null;
            this.cuiDtpFechaInicio.IconTint = System.Drawing.Color.Gray;
            this.cuiDtpFechaInicio.Location = new System.Drawing.Point(54, 122);
            this.cuiDtpFechaInicio.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cuiDtpFechaInicio.Name = "cuiDtpFechaInicio";
            this.cuiDtpFechaInicio.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiDtpFechaInicio.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiDtpFechaInicio.OutlineThickness = 1.5F;
            this.cuiDtpFechaInicio.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.BottomRight;
            this.cuiDtpFechaInicio.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiDtpFechaInicio.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiDtpFechaInicio.Rounding = 15;
            this.cuiDtpFechaInicio.ShowIcon = true;
            this.cuiDtpFechaInicio.Size = new System.Drawing.Size(258, 91);
            this.cuiDtpFechaInicio.TabIndex = 0;
            this.cuiDtpFechaInicio.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // UcReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.cuiPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcReportes";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Size = new System.Drawing.Size(1761, 955);
            this.Load += new System.EventHandler(this.UcReportes_Load);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanelReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.cuiPanel2.ResumeLayout(false);
            this.cuiGbFiltros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiGroupBox cuiGbFiltros;
        private CuoreUI.Controls.cuiCalendarDatePicker cuiDtpFechaFin;
        private CuoreUI.Controls.cuiCalendarDatePicker cuiDtpFechaInicio;
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
