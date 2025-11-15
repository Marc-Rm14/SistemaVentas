namespace app.Ventas.Formularios
{
    partial class UcVentas
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
            this.cuiPanelCentral = new CuoreUI.Controls.cuiPanel();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ibtnGuardarVenta = new FontAwesome.Sharp.IconButton();
            this.ibtnFactura = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.separadorSuperior = new System.Windows.Forms.Panel();
            this.cuiPanelTop = new CuoreUI.Controls.cuiPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ibtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.IbtnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cuiPanel1.SuspendLayout();
            this.cuiPanelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.cuiPanel2.SuspendLayout();
            this.cuiPanel4.SuspendLayout();
            this.cuiPanelTop.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cuiPanel1.Controls.Add(this.cuiPanelCentral);
            this.cuiPanel1.Controls.Add(this.panel1);
            this.cuiPanel1.Controls.Add(this.cuiPanel2);
            this.cuiPanel1.Controls.Add(this.panel2);
            this.cuiPanel1.Controls.Add(this.cuiPanel4);
            this.cuiPanel1.Controls.Add(this.separadorSuperior);
            this.cuiPanel1.Controls.Add(this.cuiPanelTop);
            this.cuiPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiPanel1.Location = new System.Drawing.Point(20, 20);
            this.cuiPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(1073, 619);
            this.cuiPanel1.TabIndex = 0;
            // 
            // cuiPanelCentral
            // 
            this.cuiPanelCentral.BackColor = System.Drawing.SystemColors.Control;
            this.cuiPanelCentral.Controls.Add(this.dgvDetalles);
            this.cuiPanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiPanelCentral.Location = new System.Drawing.Point(15, 113);
            this.cuiPanelCentral.Name = "cuiPanelCentral";
            this.cuiPanelCentral.OutlineThickness = 1F;
            this.cuiPanelCentral.Padding = new System.Windows.Forms.Padding(8);
            this.cuiPanelCentral.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.cuiPanelCentral.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanelCentral.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanelCentral.Size = new System.Drawing.Size(841, 429);
            this.cuiPanelCentral.TabIndex = 30;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToOrderColumns = true;
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalles.GridColor = System.Drawing.Color.LightGray;
            this.dgvDetalles.Location = new System.Drawing.Point(8, 8);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 28;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(825, 413);
            this.dgvDetalles.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(856, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 429);
            this.panel1.TabIndex = 29;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.cuiPanel2.Controls.Add(this.iconButton1);
            this.cuiPanel2.Controls.Add(this.ibtnGuardarVenta);
            this.cuiPanel2.Controls.Add(this.ibtnFactura);
            this.cuiPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.cuiPanel2.Location = new System.Drawing.Point(864, 113);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.Padding = new System.Windows.Forms.Padding(15);
            this.cuiPanel2.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel2.Size = new System.Drawing.Size(194, 429);
            this.cuiPanel2.TabIndex = 28;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(15, 369);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(164, 45);
            this.iconButton1.TabIndex = 14;
            this.iconButton1.Text = "Quitar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.ibtnQuitarProducto_Click);
            // 
            // ibtnGuardarVenta
            // 
            this.ibtnGuardarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnGuardarVenta.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.ibtnGuardarVenta.IconColor = System.Drawing.Color.Black;
            this.ibtnGuardarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGuardarVenta.IconSize = 30;
            this.ibtnGuardarVenta.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnGuardarVenta.Location = new System.Drawing.Point(15, 15);
            this.ibtnGuardarVenta.Name = "ibtnGuardarVenta";
            this.ibtnGuardarVenta.Padding = new System.Windows.Forms.Padding(5);
            this.ibtnGuardarVenta.Size = new System.Drawing.Size(164, 45);
            this.ibtnGuardarVenta.TabIndex = 12;
            this.ibtnGuardarVenta.Text = "Finalizar Venta";
            this.ibtnGuardarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnGuardarVenta.UseVisualStyleBackColor = true;
            this.ibtnGuardarVenta.Click += new System.EventHandler(this.ibtnGuardarVenta_Click);
            // 
            // ibtnFactura
            // 
            this.ibtnFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnFactura.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.ibtnFactura.IconColor = System.Drawing.Color.Black;
            this.ibtnFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnFactura.IconSize = 30;
            this.ibtnFactura.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnFactura.Location = new System.Drawing.Point(16, 185);
            this.ibtnFactura.Name = "ibtnFactura";
            this.ibtnFactura.Padding = new System.Windows.Forms.Padding(5);
            this.ibtnFactura.Size = new System.Drawing.Size(163, 45);
            this.ibtnFactura.TabIndex = 13;
            this.ibtnFactura.Text = "Factura";
            this.ibtnFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnFactura.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(15, 542);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 8);
            this.panel2.TabIndex = 27;
            // 
            // cuiPanel4
            // 
            this.cuiPanel4.BackColor = System.Drawing.SystemColors.Control;
            this.cuiPanel4.Controls.Add(this.lblTotalVenta);
            this.cuiPanel4.Controls.Add(this.lblCliente);
            this.cuiPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cuiPanel4.Location = new System.Drawing.Point(15, 550);
            this.cuiPanel4.Name = "cuiPanel4";
            this.cuiPanel4.OutlineThickness = 1F;
            this.cuiPanel4.Padding = new System.Windows.Forms.Padding(2);
            this.cuiPanel4.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanel4.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel4.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel4.Size = new System.Drawing.Size(1043, 54);
            this.cuiPanel4.TabIndex = 26;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalVenta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenta.Location = new System.Drawing.Point(762, 5);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(278, 45);
            this.lblTotalVenta.TabIndex = 8;
            this.lblTotalVenta.Text = "Total General C$:";
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(3, 3);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(469, 47);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente Seleccionado:";
            // 
            // separadorSuperior
            // 
            this.separadorSuperior.BackColor = System.Drawing.SystemColors.Control;
            this.separadorSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.separadorSuperior.Location = new System.Drawing.Point(15, 105);
            this.separadorSuperior.Name = "separadorSuperior";
            this.separadorSuperior.Size = new System.Drawing.Size(1043, 8);
            this.separadorSuperior.TabIndex = 22;
            // 
            // cuiPanelTop
            // 
            this.cuiPanelTop.BackColor = System.Drawing.SystemColors.Control;
            this.cuiPanelTop.Controls.Add(this.tableLayoutPanel3);
            this.cuiPanelTop.Controls.Add(this.tableLayoutPanel1);
            this.cuiPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuiPanelTop.Location = new System.Drawing.Point(15, 15);
            this.cuiPanelTop.Name = "cuiPanelTop";
            this.cuiPanelTop.OutlineThickness = 1F;
            this.cuiPanelTop.Padding = new System.Windows.Forms.Padding(15);
            this.cuiPanelTop.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanelTop.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanelTop.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanelTop.Size = new System.Drawing.Size(1043, 90);
            this.cuiPanelTop.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ibtnLimpiar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.IbtnAgregarProducto, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(763, 30);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(277, 54);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // ibtnLimpiar
            // 
            this.ibtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnLimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLimpiar.IconSize = 30;
            this.ibtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnLimpiar.Location = new System.Drawing.Point(141, 3);
            this.ibtnLimpiar.Name = "ibtnLimpiar";
            this.ibtnLimpiar.Size = new System.Drawing.Size(133, 45);
            this.ibtnLimpiar.TabIndex = 11;
            this.ibtnLimpiar.Text = "Limpiar Seleciones";
            this.ibtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLimpiar.UseVisualStyleBackColor = true;
            this.ibtnLimpiar.Click += new System.EventHandler(this.ibtnLimpiar_Click);
            // 
            // IbtnAgregarProducto
            // 
            this.IbtnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IbtnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.IbtnAgregarProducto.IconColor = System.Drawing.Color.Black;
            this.IbtnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnAgregarProducto.IconSize = 30;
            this.IbtnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.IbtnAgregarProducto.Location = new System.Drawing.Point(3, 3);
            this.IbtnAgregarProducto.Name = "IbtnAgregarProducto";
            this.IbtnAgregarProducto.Size = new System.Drawing.Size(132, 45);
            this.IbtnAgregarProducto.TabIndex = 6;
            this.IbtnAgregarProducto.Text = "Añadir";
            this.IbtnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnAgregarProducto.UseVisualStyleBackColor = true;
            this.IbtnAgregarProducto.Click += new System.EventHandler(this.ibtnAgregarProducto_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.cmbClientes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbProductos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numCantidad, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbClientes
            // 
            this.cmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(4, 38);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(265, 29);
            this.cmbClientes.TabIndex = 3;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // cmbProductos
            // 
            this.cmbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(275, 38);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(265, 29);
            this.cmbProductos.TabIndex = 2;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(546, 38);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(74, 29);
            this.numCantidad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccionar Cliente:";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(275, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccionar Producto:";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(546, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // UcVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cuiPanel1);
            this.Name = "UcVentas";
            this.Size = new System.Drawing.Size(1112, 664);
            this.Load += new System.EventHandler(this.UcVentas_Load);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel4.ResumeLayout(false);
            this.cuiPanelTop.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private System.Windows.Forms.Panel separadorSuperior;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.Label lblCliente;
        private FontAwesome.Sharp.IconButton ibtnFactura;
        private CuoreUI.Controls.cuiPanel cuiPanelTop;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private FontAwesome.Sharp.IconButton IbtnAgregarProducto;
        private FontAwesome.Sharp.IconButton ibtnLimpiar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton ibtnGuardarVenta;
        private CuoreUI.Controls.cuiPanel cuiPanelCentral;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Panel panel1;
    }
}
