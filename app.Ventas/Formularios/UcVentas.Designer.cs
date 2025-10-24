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
            this.cuiGroupBox1 = new CuoreUI.Controls.cuiGroupBox();
            this.cuiGroupBox2 = new CuoreUI.Controls.cuiGroupBox();
            this.ibtnFactura = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.ibtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.IbtnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.ibtnGuardarVenta = new FontAwesome.Sharp.IconButton();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.cuiPanel1.SuspendLayout();
            this.cuiGroupBox1.SuspendLayout();
            this.cuiGroupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.cuiPanel1.Controls.Add(this.cuiGroupBox1);
            this.cuiPanel1.Location = new System.Drawing.Point(25, 24);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(1221, 672);
            this.cuiPanel1.TabIndex = 0;
            // 
            // cuiGroupBox1
            // 
            this.cuiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiGroupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cuiGroupBox1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cuiGroupBox1.Content = "";
            this.cuiGroupBox1.Controls.Add(this.cuiGroupBox2);
            this.cuiGroupBox1.Controls.Add(this.tableLayoutPanel1);
            this.cuiGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiGroupBox1.Location = new System.Drawing.Point(15, 21);
            this.cuiGroupBox1.Name = "cuiGroupBox1";
            this.cuiGroupBox1.Padding = new System.Windows.Forms.Padding(8, 28, 8, 8);
            this.cuiGroupBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGroupBox1.Size = new System.Drawing.Size(1168, 629);
            this.cuiGroupBox1.TabIndex = 0;
            // 
            // cuiGroupBox2
            // 
            this.cuiGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiGroupBox2.Content = "";
            this.cuiGroupBox2.Controls.Add(this.ibtnFactura);
            this.cuiGroupBox2.Controls.Add(this.tableLayoutPanel2);
            this.cuiGroupBox2.Controls.Add(this.ibtnLimpiar);
            this.cuiGroupBox2.Controls.Add(this.IbtnAgregarProducto);
            this.cuiGroupBox2.Controls.Add(this.ibtnGuardarVenta);
            this.cuiGroupBox2.Controls.Add(this.numCantidad);
            this.cuiGroupBox2.Controls.Add(this.cmbClientes);
            this.cuiGroupBox2.Controls.Add(this.cmbProductos);
            this.cuiGroupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.cuiGroupBox2.Location = new System.Drawing.Point(934, 28);
            this.cuiGroupBox2.Name = "cuiGroupBox2";
            this.cuiGroupBox2.Padding = new System.Windows.Forms.Padding(4, 24, 4, 4);
            this.cuiGroupBox2.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiGroupBox2.Size = new System.Drawing.Size(226, 593);
            this.cuiGroupBox2.TabIndex = 14;
            // 
            // ibtnFactura
            // 
            this.ibtnFactura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnFactura.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ibtnFactura.IconColor = System.Drawing.Color.Black;
            this.ibtnFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnFactura.IconSize = 30;
            this.ibtnFactura.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnFactura.Location = new System.Drawing.Point(4, 384);
            this.ibtnFactura.Name = "ibtnFactura";
            this.ibtnFactura.Size = new System.Drawing.Size(218, 45);
            this.ibtnFactura.TabIndex = 13;
            this.ibtnFactura.Text = "Factura";
            this.ibtnFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnFactura.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblCliente, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalVenta, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(209, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(3, 50);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(166, 21);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Seleccione un Cliente";
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Location = new System.Drawing.Point(3, 0);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(33, 21);
            this.lblTotalVenta.TabIndex = 8;
            this.lblTotalVenta.Text = "C$:";
            // 
            // ibtnLimpiar
            // 
            this.ibtnLimpiar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnLimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLimpiar.IconSize = 30;
            this.ibtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnLimpiar.Location = new System.Drawing.Point(4, 429);
            this.ibtnLimpiar.Name = "ibtnLimpiar";
            this.ibtnLimpiar.Size = new System.Drawing.Size(218, 45);
            this.ibtnLimpiar.TabIndex = 11;
            this.ibtnLimpiar.Text = "Limpiar Seleciones";
            this.ibtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLimpiar.UseVisualStyleBackColor = true;
            this.ibtnLimpiar.Click += new System.EventHandler(this.ibtnLimpiar_Click);
            // 
            // IbtnAgregarProducto
            // 
            this.IbtnAgregarProducto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IbtnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.IbtnAgregarProducto.IconColor = System.Drawing.Color.Black;
            this.IbtnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnAgregarProducto.IconSize = 30;
            this.IbtnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.IbtnAgregarProducto.Location = new System.Drawing.Point(4, 474);
            this.IbtnAgregarProducto.Name = "IbtnAgregarProducto";
            this.IbtnAgregarProducto.Size = new System.Drawing.Size(218, 45);
            this.IbtnAgregarProducto.TabIndex = 6;
            this.IbtnAgregarProducto.Text = "Añadir";
            this.IbtnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnAgregarProducto.UseVisualStyleBackColor = true;
            this.IbtnAgregarProducto.Click += new System.EventHandler(this.ibtnAgregarProducto_Click);
            // 
            // ibtnGuardarVenta
            // 
            this.ibtnGuardarVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnGuardarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnGuardarVenta.IconColor = System.Drawing.Color.Black;
            this.ibtnGuardarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnGuardarVenta.Location = new System.Drawing.Point(4, 519);
            this.ibtnGuardarVenta.Name = "ibtnGuardarVenta";
            this.ibtnGuardarVenta.Size = new System.Drawing.Size(218, 41);
            this.ibtnGuardarVenta.TabIndex = 12;
            this.ibtnGuardarVenta.Text = "Finalizar Venta";
            this.ibtnGuardarVenta.UseVisualStyleBackColor = true;
            this.ibtnGuardarVenta.Click += new System.EventHandler(this.ibtnGuardarVenta_Click);
            // 
            // numCantidad
            // 
            this.numCantidad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numCantidad.Location = new System.Drawing.Point(4, 560);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(218, 29);
            this.numCantidad.TabIndex = 4;
            // 
            // cmbClientes
            // 
            this.cmbClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(3, 142);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(213, 29);
            this.cmbClientes.TabIndex = 3;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // cmbProductos
            // 
            this.cmbProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(4, 196);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(212, 29);
            this.cmbProductos.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDetalles, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 593);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToOrderColumns = true;
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalles.Location = new System.Drawing.Point(6, 6);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(905, 581);
            this.dgvDetalles.TabIndex = 7;
            // 
            // UcVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cuiPanel1);
            this.Name = "UcVentas";
            this.Size = new System.Drawing.Size(1278, 723);
            this.Load += new System.EventHandler(this.UcVentas_Load);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiGroupBox1.ResumeLayout(false);
            this.cuiGroupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private FontAwesome.Sharp.IconButton IbtnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCliente;
        private FontAwesome.Sharp.IconButton ibtnLimpiar;
        private FontAwesome.Sharp.IconButton ibtnGuardarVenta;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton ibtnFactura;
    }
}
