namespace app.Ventas.Formularios
{
    partial class UCProductos
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
            this.txtBoxBuscarProductos = new System.Windows.Forms.TextBox();
            this.ibtnAgregar = new FontAwesome.Sharp.IconButton();
            this.ibtnEliminar = new FontAwesome.Sharp.IconButton();
            this.lblListado = new System.Windows.Forms.Label();
            this.cuiPanelContenedor = new CuoreUI.Controls.cuiPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cuiTxtBuscar = new CuoreUI.Controls.cuiTextBox();
            this.cuiPanelContenedor.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxBuscarProductos
            // 
            this.txtBoxBuscarProductos.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxBuscarProductos.Location = new System.Drawing.Point(35, 575);
            this.txtBoxBuscarProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxBuscarProductos.Name = "txtBoxBuscarProductos";
            this.txtBoxBuscarProductos.Size = new System.Drawing.Size(556, 29);
            this.txtBoxBuscarProductos.TabIndex = 1;
            this.txtBoxBuscarProductos.Text = "Buscar Productos";
            this.txtBoxBuscarProductos.TextChanged += new System.EventHandler(this.txtBoxBuscarProductos_TextChanged);
            this.txtBoxBuscarProductos.Enter += new System.EventHandler(this.txtBoxBuscarProductos_Enter);
            this.txtBoxBuscarProductos.Leave += new System.EventHandler(this.txtBoxBuscarProductos_Leave);
            // 
            // ibtnAgregar
            // 
            this.ibtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ibtnAgregar.BackColor = System.Drawing.Color.White;
            this.ibtnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ibtnAgregar.IconColor = System.Drawing.Color.Black;
            this.ibtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAgregar.IconSize = 30;
            this.ibtnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnAgregar.Location = new System.Drawing.Point(4, 5);
            this.ibtnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ibtnAgregar.Name = "ibtnAgregar";
            this.ibtnAgregar.Size = new System.Drawing.Size(117, 45);
            this.ibtnAgregar.TabIndex = 2;
            this.ibtnAgregar.Text = "Agregar";
            this.ibtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAgregar.UseVisualStyleBackColor = false;
            this.ibtnAgregar.Click += new System.EventHandler(this.ibtnAgregar_Click);
            // 
            // ibtnEliminar
            // 
            this.ibtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ibtnEliminar.BackColor = System.Drawing.Color.White;
            this.ibtnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnEliminar.IconColor = System.Drawing.Color.Black;
            this.ibtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEliminar.IconSize = 30;
            this.ibtnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnEliminar.Location = new System.Drawing.Point(159, 5);
            this.ibtnEliminar.Name = "ibtnEliminar";
            this.ibtnEliminar.Size = new System.Drawing.Size(112, 45);
            this.ibtnEliminar.TabIndex = 3;
            this.ibtnEliminar.Text = "Eliminar";
            this.ibtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEliminar.UseVisualStyleBackColor = false;
            this.ibtnEliminar.Click += new System.EventHandler(this.ibtnEliminar_Click);
            // 
            // lblListado
            // 
            this.lblListado.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(4, 0);
            this.lblListado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(285, 40);
            this.lblListado.TabIndex = 0;
            this.lblListado.Text = "Listado de Productos";
            // 
            // cuiPanelContenedor
            // 
            this.cuiPanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanelContenedor.Controls.Add(this.tableLayoutPanel4);
            this.cuiPanelContenedor.Controls.Add(this.tableLayoutPanel2);
            this.cuiPanelContenedor.Controls.Add(this.tableLayoutPanel1);
            this.cuiPanelContenedor.Controls.Add(this.tableLayoutPanel3);
            this.cuiPanelContenedor.Location = new System.Drawing.Point(35, 31);
            this.cuiPanelContenedor.Name = "cuiPanelContenedor";
            this.cuiPanelContenedor.OutlineThickness = 1F;
            this.cuiPanelContenedor.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.cuiPanelContenedor.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanelContenedor.Rounding = new System.Windows.Forms.Padding(20);
            this.cuiPanelContenedor.Size = new System.Drawing.Size(1047, 523);
            this.cuiPanelContenedor.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dgvProductos, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(13, 160);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1018, 349);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.GridColor = System.Drawing.Color.LightGray;
            this.dgvProductos.Location = new System.Drawing.Point(3, 3);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1012, 343);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ibtnEliminar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ibtnAgregar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(718, 79);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(313, 55);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblListado, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.cuiTxtBuscar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 79);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(575, 55);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // cuiTxtBuscar
            // 
            this.cuiTxtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiTxtBuscar.BackgroundColor = System.Drawing.Color.White;
            this.cuiTxtBuscar.Content = "";
            this.cuiTxtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTxtBuscar.FocusBackgroundColor = System.Drawing.Color.White;
            this.cuiTxtBuscar.FocusImageTint = System.Drawing.Color.White;
            this.cuiTxtBuscar.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiTxtBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiTxtBuscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cuiTxtBuscar.Image = null;
            this.cuiTxtBuscar.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiTxtBuscar.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiTxtBuscar.Location = new System.Drawing.Point(4, 5);
            this.cuiTxtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cuiTxtBuscar.Multiline = false;
            this.cuiTxtBuscar.Name = "cuiTxtBuscar";
            this.cuiTxtBuscar.NormalImageTint = System.Drawing.Color.White;
            this.cuiTxtBuscar.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiTxtBuscar.Padding = new System.Windows.Forms.Padding(22, 11, 22, 0);
            this.cuiTxtBuscar.PasswordChar = false;
            this.cuiTxtBuscar.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cuiTxtBuscar.PlaceholderText = "Buscar Productos";
            this.cuiTxtBuscar.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiTxtBuscar.Size = new System.Drawing.Size(567, 45);
            this.cuiTxtBuscar.TabIndex = 0;
            this.cuiTxtBuscar.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTxtBuscar.UnderlinedStyle = true;
            this.cuiTxtBuscar.ContentChanged += new System.EventHandler(this.cuiTxtBuscar_ContentChanged);
            // 
            // UCProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.cuiPanelContenedor);
            this.Controls.Add(this.txtBoxBuscarProductos);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCProductos";
            this.Size = new System.Drawing.Size(1112, 644);
            this.Load += new System.EventHandler(this.UCProductos_Load);
            this.cuiPanelContenedor.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxBuscarProductos;
        private System.Windows.Forms.Label lblListado;
        private FontAwesome.Sharp.IconButton ibtnAgregar;
        private FontAwesome.Sharp.IconButton ibtnEliminar;
        private CuoreUI.Controls.cuiPanel cuiPanelContenedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CuoreUI.Controls.cuiTextBox cuiTxtBuscar;
    }
}
