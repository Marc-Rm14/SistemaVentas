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
            this.cuiGroupBox1 = new CuoreUI.Controls.cuiGroupBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.ibtnReporte = new FontAwesome.Sharp.IconButton();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.cuiCalendarDatePicker2 = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.cuiCalendarDatePicker1 = new CuoreUI.Controls.cuiCalendarDatePicker();
            this.cuiPanel1.SuspendLayout();
            this.cuiGroupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cuiPanel1.Controls.Add(this.cuiGroupBox1);
            this.cuiPanel1.Location = new System.Drawing.Point(18, 15);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(1139, 587);
            this.cuiPanel1.TabIndex = 0;
            // 
            // cuiGroupBox1
            // 
            this.cuiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiGroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.cuiGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiGroupBox1.Content = "";
            this.cuiGroupBox1.Controls.Add(this.cmbClientes);
            this.cuiGroupBox1.Controls.Add(this.tableLayoutPanel1);
            this.cuiGroupBox1.Controls.Add(this.cmbUsuarios);
            this.cuiGroupBox1.Controls.Add(this.ibtnReporte);
            this.cuiGroupBox1.Controls.Add(this.cmbFiltrar);
            this.cuiGroupBox1.Controls.Add(this.cuiCalendarDatePicker2);
            this.cuiGroupBox1.Controls.Add(this.cuiCalendarDatePicker1);
            this.cuiGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiGroupBox1.Location = new System.Drawing.Point(25, 23);
            this.cuiGroupBox1.Name = "cuiGroupBox1";
            this.cuiGroupBox1.Padding = new System.Windows.Forms.Padding(15, 35, 15, 15);
            this.cuiGroupBox1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiGroupBox1.Size = new System.Drawing.Size(1088, 550);
            this.cuiGroupBox1.TabIndex = 0;
            // 
            // cmbClientes
            // 
            this.cmbClientes.Location = new System.Drawing.Point(548, 134);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(245, 29);
            this.cmbClientes.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvReportes, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 196);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1052, 336);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.AllowUserToOrderColumns = true;
            this.dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportes.Location = new System.Drawing.Point(3, 3);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReportes.RowHeadersWidth = 51;
            this.dgvReportes.RowTemplate.Height = 28;
            this.dgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportes.Size = new System.Drawing.Size(1046, 330);
            this.dgvReportes.TabIndex = 4;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(548, 86);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(245, 29);
            this.cmbUsuarios.TabIndex = 5;
            // 
            // ibtnReporte
            // 
            this.ibtnReporte.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnReporte.IconColor = System.Drawing.Color.Black;
            this.ibtnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnReporte.Location = new System.Drawing.Point(855, 45);
            this.ibtnReporte.Name = "ibtnReporte";
            this.ibtnReporte.Size = new System.Drawing.Size(129, 54);
            this.ibtnReporte.TabIndex = 3;
            this.ibtnReporte.Text = "Generar Reporte";
            this.ibtnReporte.UseVisualStyleBackColor = true;
            this.ibtnReporte.Click += new System.EventHandler(this.ibtnReporte_Click);
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Items.AddRange(new object[] {
            "Clientes",
            "Usuarios"});
            this.cmbFiltrar.Location = new System.Drawing.Point(548, 40);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(245, 29);
            this.cmbFiltrar.TabIndex = 2;
            this.cmbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cmbFliltrar_SelectedIndexChanged);
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
            this.cuiCalendarDatePicker2.Location = new System.Drawing.Point(262, 40);
            this.cuiCalendarDatePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiCalendarDatePicker2.Name = "cuiCalendarDatePicker2";
            this.cuiCalendarDatePicker2.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker2.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker2.OutlineThickness = 1.5F;
            this.cuiCalendarDatePicker2.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
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
            this.cuiCalendarDatePicker1.Location = new System.Drawing.Point(44, 40);
            this.cuiCalendarDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiCalendarDatePicker1.Name = "cuiCalendarDatePicker1";
            this.cuiCalendarDatePicker1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.OutlineThickness = 1.5F;
            this.cuiCalendarDatePicker1.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            this.cuiCalendarDatePicker1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiCalendarDatePicker1.Rounding = 15;
            this.cuiCalendarDatePicker1.ShowIcon = true;
            this.cuiCalendarDatePicker1.Size = new System.Drawing.Size(172, 59);
            this.cuiCalendarDatePicker1.TabIndex = 0;
            this.cuiCalendarDatePicker1.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // UcReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.cuiPanel1);
            this.Name = "UcReportes";
            this.Size = new System.Drawing.Size(1174, 621);
            this.Load += new System.EventHandler(this.UcReportes_Load);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiGroupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox1;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private CuoreUI.Controls.cuiCalendarDatePicker cuiCalendarDatePicker2;
        private CuoreUI.Controls.cuiCalendarDatePicker cuiCalendarDatePicker1;
        private System.Windows.Forms.DataGridView dgvReportes;
        private FontAwesome.Sharp.IconButton ibtnReporte;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
        private System.Windows.Forms.ComboBox cmbClientes;
    }
}
