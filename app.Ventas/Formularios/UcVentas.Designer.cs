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
            this.cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.ibtnQuitarProducto = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.ibtnGuardarVenta = new FontAwesome.Sharp.IconButton();
            this.ibtnFactura = new FontAwesome.Sharp.IconButton();
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
            this.cuiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.cuiPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.cuiPanel1.Controls.Add(this.cuiPanel3);
            this.cuiPanel1.Controls.Add(this.panel1);
            this.cuiPanel1.Controls.Add(this.cuiPanel2);
            this.cuiPanel1.Controls.Add(this.separadorSuperior);
            this.cuiPanel1.Controls.Add(this.cuiPanelTop);
            this.cuiPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiPanel1.Location = new System.Drawing.Point(27, 25);
            this.cuiPanel1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cuiPanel1.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(1431, 768);
            this.cuiPanel1.TabIndex = 0;
            // 
            // cuiPanel3
            // 
            this.cuiPanel3.Controls.Add(this.dgvDetalles);
            this.cuiPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuiPanel3.Location = new System.Drawing.Point(13, 133);
            this.cuiPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuiPanel3.Name = "cuiPanel3";
            this.cuiPanel3.OutlineThickness = 1F;
            this.cuiPanel3.PanelColor = System.Drawing.Color.White;
            this.cuiPanel3.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel3.Size = new System.Drawing.Size(1118, 623);
            this.cuiPanel3.TabIndex = 25;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToOrderColumns = true;
            this.dgvDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(28, 28);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(1052, 569);
            this.dgvDetalles.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1131, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 623);
            this.panel1.TabIndex = 24;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.cuiPanel2.Controls.Add(this.ibtnQuitarProducto);
            this.cuiPanel2.Controls.Add(this.tableLayoutPanel2);
            this.cuiPanel2.Controls.Add(this.ibtnGuardarVenta);
            this.cuiPanel2.Controls.Add(this.ibtnFactura);
            this.cuiPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.cuiPanel2.Location = new System.Drawing.Point(1142, 133);
            this.cuiPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cuiPanel2.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel2.Size = new System.Drawing.Size(276, 623);
            this.cuiPanel2.TabIndex = 23;
            // 
            // ibtnQuitarProducto
            // 
            this.ibtnQuitarProducto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnQuitarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnQuitarProducto.IconColor = System.Drawing.Color.Black;
            this.ibtnQuitarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnQuitarProducto.Location = new System.Drawing.Point(7, 452);
            this.ibtnQuitarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibtnQuitarProducto.Name = "ibtnQuitarProducto";
            this.ibtnQuitarProducto.Size = new System.Drawing.Size(262, 55);
            this.ibtnQuitarProducto.TabIndex = 15;
            this.ibtnQuitarProducto.Text = "Quitar Producto";
            this.ibtnQuitarProducto.UseVisualStyleBackColor = true;
            this.ibtnQuitarProducto.Click += new System.EventHandler(this.ibtnQuitarProducto_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblCliente, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalVenta, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 6);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(262, 123);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // lblCliente
            // 
            this.lblCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCliente.Location = new System.Drawing.Point(4, 0);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(254, 61);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente Seleccionado:";
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalVenta.Location = new System.Drawing.Point(4, 61);
            this.lblTotalVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(254, 62);
            this.lblTotalVenta.TabIndex = 8;
            this.lblTotalVenta.Text = "Total General C$:";
            // 
            // ibtnGuardarVenta
            // 
            this.ibtnGuardarVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnGuardarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnGuardarVenta.IconColor = System.Drawing.Color.Black;
            this.ibtnGuardarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGuardarVenta.Location = new System.Drawing.Point(7, 507);
            this.ibtnGuardarVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibtnGuardarVenta.Name = "ibtnGuardarVenta";
            this.ibtnGuardarVenta.Size = new System.Drawing.Size(262, 55);
            this.ibtnGuardarVenta.TabIndex = 12;
            this.ibtnGuardarVenta.Text = "Finalizar Venta";
            this.ibtnGuardarVenta.UseVisualStyleBackColor = true;
            this.ibtnGuardarVenta.Click += new System.EventHandler(this.ibtnGuardarVenta_Click);
            // 
            // ibtnFactura
            // 
            this.ibtnFactura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnFactura.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ibtnFactura.IconColor = System.Drawing.Color.Black;
            this.ibtnFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnFactura.IconSize = 30;
            this.ibtnFactura.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnFactura.Location = new System.Drawing.Point(7, 562);
            this.ibtnFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibtnFactura.Name = "ibtnFactura";
            this.ibtnFactura.Size = new System.Drawing.Size(262, 55);
            this.ibtnFactura.TabIndex = 13;
            this.ibtnFactura.Text = "Factura";
            this.ibtnFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnFactura.UseVisualStyleBackColor = true;
            // 
            // separadorSuperior
            // 
            this.separadorSuperior.BackColor = System.Drawing.SystemColors.Control;
            this.separadorSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.separadorSuperior.Location = new System.Drawing.Point(13, 123);
            this.separadorSuperior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.separadorSuperior.Name = "separadorSuperior";
            this.separadorSuperior.Size = new System.Drawing.Size(1405, 10);
            this.separadorSuperior.TabIndex = 22;
            // 
            // cuiPanelTop
            // 
            this.cuiPanelTop.BackColor = System.Drawing.SystemColors.Control;
            this.cuiPanelTop.Controls.Add(this.tableLayoutPanel3);
            this.cuiPanelTop.Controls.Add(this.tableLayoutPanel1);
            this.cuiPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuiPanelTop.Location = new System.Drawing.Point(13, 12);
            this.cuiPanelTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuiPanelTop.Name = "cuiPanelTop";
            this.cuiPanelTop.OutlineThickness = 1F;
            this.cuiPanelTop.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.cuiPanelTop.PanelColor = System.Drawing.SystemColors.Control;
            this.cuiPanelTop.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanelTop.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanelTop.Size = new System.Drawing.Size(1405, 111);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1032, 37);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(369, 66);
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
            this.ibtnLimpiar.Location = new System.Drawing.Point(188, 4);
            this.ibtnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibtnLimpiar.Name = "ibtnLimpiar";
            this.ibtnLimpiar.Size = new System.Drawing.Size(177, 55);
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
            this.IbtnAgregarProducto.Location = new System.Drawing.Point(4, 4);
            this.IbtnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IbtnAgregarProducto.Name = "IbtnAgregarProducto";
            this.IbtnAgregarProducto.Size = new System.Drawing.Size(176, 55);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 17);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(921, 86);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbClientes
            // 
            this.cmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(5, 47);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(356, 36);
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
            this.cmbProductos.Location = new System.Drawing.Point(372, 47);
            this.cmbProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(356, 36);
            this.cmbProductos.TabIndex = 2;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(739, 47);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(99, 34);
            this.numCantidad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccionar Cliente:";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(372, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccionar Producto";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(739, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // UcVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cuiPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcVentas";
            this.Size = new System.Drawing.Size(1483, 817);
            this.Load += new System.EventHandler(this.UcVentas_Load);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.cuiPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton ibtnGuardarVenta;
        private FontAwesome.Sharp.IconButton ibtnFactura;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private CuoreUI.Controls.cuiPanel cuiPanelTop;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private FontAwesome.Sharp.IconButton IbtnAgregarProducto;
        private FontAwesome.Sharp.IconButton ibtnLimpiar;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton ibtnQuitarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
