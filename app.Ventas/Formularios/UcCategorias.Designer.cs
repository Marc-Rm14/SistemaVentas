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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ibtnEliminarCat = new FontAwesome.Sharp.IconButton();
            this.ibtnAgregarCat = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cuiTxtBuscarCat = new CuoreUI.Controls.cuiTextBox();
            this.panelContenedor.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Controls.Add(this.tableLayoutPanel4);
            this.panelContenedor.Controls.Add(this.tableLayoutPanel3);
            this.panelContenedor.Controls.Add(this.tableLayoutPanel2);
            this.panelContenedor.Controls.Add(this.tableLayoutPanel1);
            this.panelContenedor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContenedor.Location = new System.Drawing.Point(21, 18);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1025, 702);
            this.panelContenedor.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dgvCategorias, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(27, 140);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(975, 535);
            this.tableLayoutPanel4.TabIndex = 3;
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
            this.dgvCategorias.Location = new System.Drawing.Point(4, 4);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 28;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(967, 527);
            this.dgvCategorias.TabIndex = 0;
            this.dgvCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellDoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.cuiTxtBuscarCat, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(27, 70);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(575, 63);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ibtnEliminarCat, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ibtnAgregarCat, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(644, 70);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(361, 63);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ibtnEliminarCat
            // 
            this.ibtnEliminarCat.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnEliminarCat.IconColor = System.Drawing.Color.Black;
            this.ibtnEliminarCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEliminarCat.IconSize = 30;
            this.ibtnEliminarCat.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnEliminarCat.Location = new System.Drawing.Point(183, 2);
            this.ibtnEliminarCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnEliminarCat.Name = "ibtnEliminarCat";
            this.ibtnEliminarCat.Size = new System.Drawing.Size(171, 58);
            this.ibtnEliminarCat.TabIndex = 4;
            this.ibtnEliminarCat.Text = "Eliminar";
            this.ibtnEliminarCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEliminarCat.UseVisualStyleBackColor = true;
            this.ibtnEliminarCat.Click += new System.EventHandler(this.ibtnEliminarCat_Click);
            // 
            // ibtnAgregarCat
            // 
            this.ibtnAgregarCat.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ibtnAgregarCat.IconColor = System.Drawing.Color.Black;
            this.ibtnAgregarCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAgregarCat.IconSize = 30;
            this.ibtnAgregarCat.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnAgregarCat.Location = new System.Drawing.Point(4, 4);
            this.ibtnAgregarCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibtnAgregarCat.Name = "ibtnAgregarCat";
            this.ibtnAgregarCat.Size = new System.Drawing.Size(172, 55);
            this.ibtnAgregarCat.TabIndex = 3;
            this.ibtnAgregarCat.Text = "Agregar";
            this.ibtnAgregarCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAgregarCat.UseVisualStyleBackColor = true;
            this.ibtnAgregarCat.Click += new System.EventHandler(this.ibtnAgregarCat_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 17);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(971, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado Categorias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cuiTxtBuscarCat
            // 
            this.cuiTxtBuscarCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiTxtBuscarCat.BackgroundColor = System.Drawing.Color.White;
            this.cuiTxtBuscarCat.Content = "";
            this.cuiTxtBuscarCat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cuiTxtBuscarCat.FocusBackgroundColor = System.Drawing.Color.White;
            this.cuiTxtBuscarCat.FocusImageTint = System.Drawing.Color.White;
            this.cuiTxtBuscarCat.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiTxtBuscarCat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiTxtBuscarCat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cuiTxtBuscarCat.Image = null;
            this.cuiTxtBuscarCat.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiTxtBuscarCat.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiTxtBuscarCat.Location = new System.Drawing.Point(4, 4);
            this.cuiTxtBuscarCat.Margin = new System.Windows.Forms.Padding(4);
            this.cuiTxtBuscarCat.Multiline = false;
            this.cuiTxtBuscarCat.Name = "cuiTxtBuscarCat";
            this.cuiTxtBuscarCat.NormalImageTint = System.Drawing.Color.White;
            this.cuiTxtBuscarCat.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiTxtBuscarCat.Padding = new System.Windows.Forms.Padding(27, 9, 27, 0);
            this.cuiTxtBuscarCat.PasswordChar = false;
            this.cuiTxtBuscarCat.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.cuiTxtBuscarCat.PlaceholderText = "Buscar Categorias";
            this.cuiTxtBuscarCat.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiTxtBuscarCat.Size = new System.Drawing.Size(567, 45);
            this.cuiTxtBuscarCat.TabIndex = 0;
            this.cuiTxtBuscarCat.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTxtBuscarCat.UnderlinedStyle = true;
            this.cuiTxtBuscarCat.ContentChanged += new System.EventHandler(this.cuiTxtBuscarCat_ContentChanged);
            // 
            // UcCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContenedor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcCategorias";
            this.Size = new System.Drawing.Size(1067, 738);
            this.Load += new System.EventHandler(this.UcCategorias_Load);
            this.panelContenedor.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton ibtnEliminarCat;
        private FontAwesome.Sharp.IconButton ibtnAgregarCat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private CuoreUI.Controls.cuiTextBox cuiTxtBuscarCat;
    }
}
