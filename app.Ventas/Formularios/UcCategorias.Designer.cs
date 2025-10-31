namespace app.Ventas.Formularios
{
    partial class UcCategorias
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
            this.cuiPanelContenedor = new CuoreUI.Controls.cuiPanel();
            this.cuiGroupBox1 = new CuoreUI.Controls.cuiGroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ibtnEliminar = new FontAwesome.Sharp.IconButton();
            this.ibtnAgregar = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cuiTxtBuscar = new CuoreUI.Controls.cuiTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblListado = new System.Windows.Forms.Label();
            this.cuiPanelContenedor.SuspendLayout();
            this.cuiGroupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiPanelContenedor
            // 
            this.cuiPanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanelContenedor.Controls.Add(this.cuiGroupBox1);
            this.cuiPanelContenedor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiPanelContenedor.Location = new System.Drawing.Point(22, 21);
            this.cuiPanelContenedor.Name = "cuiPanelContenedor";
            this.cuiPanelContenedor.OutlineThickness = 1F;
            this.cuiPanelContenedor.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.cuiPanelContenedor.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanelContenedor.Rounding = new System.Windows.Forms.Padding(20);
            this.cuiPanelContenedor.Size = new System.Drawing.Size(1068, 602);
            this.cuiPanelContenedor.TabIndex = 5;
            // 
            // cuiGroupBox1
            // 
            this.cuiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiGroupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cuiGroupBox1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cuiGroupBox1.Content = "";
            this.cuiGroupBox1.Controls.Add(this.tableLayoutPanel2);
            this.cuiGroupBox1.Controls.Add(this.tableLayoutPanel4);
            this.cuiGroupBox1.Controls.Add(this.tableLayoutPanel3);
            this.cuiGroupBox1.Controls.Add(this.tableLayoutPanel1);
            this.cuiGroupBox1.Location = new System.Drawing.Point(21, 23);
            this.cuiGroupBox1.Name = "cuiGroupBox1";
            this.cuiGroupBox1.Padding = new System.Windows.Forms.Padding(4, 24, 4, 4);
            this.cuiGroupBox1.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiGroupBox1.Size = new System.Drawing.Size(1025, 566);
            this.cuiGroupBox1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ibtnEliminar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ibtnAgregar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(764, 87);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(239, 58);
            this.tableLayoutPanel2.TabIndex = 7;
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
            this.ibtnEliminar.Location = new System.Drawing.Point(122, 6);
            this.ibtnEliminar.Name = "ibtnEliminar";
            this.ibtnEliminar.Size = new System.Drawing.Size(112, 45);
            this.ibtnEliminar.TabIndex = 3;
            this.ibtnEliminar.Text = "Eliminar";
            this.ibtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEliminar.UseVisualStyleBackColor = false;
            this.ibtnEliminar.Click += new System.EventHandler(this.ibtnEliminarCat_Click);
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
            this.ibtnAgregar.Location = new System.Drawing.Point(4, 6);
            this.ibtnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ibtnAgregar.Name = "ibtnAgregar";
            this.ibtnAgregar.Size = new System.Drawing.Size(111, 45);
            this.ibtnAgregar.TabIndex = 2;
            this.ibtnAgregar.Text = "Agregar";
            this.ibtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAgregar.UseVisualStyleBackColor = false;
            this.ibtnAgregar.Click += new System.EventHandler(this.ibtnAgregarCat_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dgvCategorias, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(22, 167);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(981, 382);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AllowUserToOrderColumns = true;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategorias.GridColor = System.Drawing.Color.LightGray;
            this.dgvCategorias.Location = new System.Drawing.Point(3, 3);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 28;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(975, 376);
            this.dgvCategorias.TabIndex = 0;
            this.dgvCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellDoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.cuiTxtBuscar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(22, 87);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(548, 58);
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
            this.cuiTxtBuscar.Location = new System.Drawing.Point(4, 6);
            this.cuiTxtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cuiTxtBuscar.Multiline = false;
            this.cuiTxtBuscar.Name = "cuiTxtBuscar";
            this.cuiTxtBuscar.NormalImageTint = System.Drawing.Color.White;
            this.cuiTxtBuscar.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiTxtBuscar.Padding = new System.Windows.Forms.Padding(22, 11, 22, 0);
            this.cuiTxtBuscar.PasswordChar = false;
            this.cuiTxtBuscar.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cuiTxtBuscar.PlaceholderText = "Buscar Categorias";
            this.cuiTxtBuscar.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiTxtBuscar.Size = new System.Drawing.Size(540, 45);
            this.cuiTxtBuscar.TabIndex = 0;
            this.cuiTxtBuscar.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTxtBuscar.UnderlinedStyle = true;
            this.cuiTxtBuscar.ContentChanged += new System.EventHandler(this.cuiTxtBuscarCat_ContentChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblListado, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblListado
            // 
            this.lblListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(4, 0);
            this.lblListado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(973, 57);
            this.lblListado.TabIndex = 0;
            this.lblListado.Text = "Listado de Categorias";
            // 
            // UcCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.cuiPanelContenedor);
            this.Name = "UcCategorias";
            this.Size = new System.Drawing.Size(1112, 644);
            this.Load += new System.EventHandler(this.UcCategorias_Load);
            this.cuiPanelContenedor.ResumeLayout(false);
            this.cuiGroupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanelContenedor;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton ibtnEliminar;
        private FontAwesome.Sharp.IconButton ibtnAgregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CuoreUI.Controls.cuiTextBox cuiTxtBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblListado;
    }
}
