namespace app.Ventas.Formularios
{
    partial class UcUsuarios
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cuiTxtBuscar = new CuoreUI.Controls.cuiTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.ibtnEliminar = new FontAwesome.Sharp.IconButton();
            this.ibtnAgregar = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cuiGroupBox1 = new CuoreUI.Controls.cuiGroupBox();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.cuiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dgvUsuarios, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(29, 175);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(977, 400);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.GridColor = System.Drawing.Color.LightGray;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(971, 394);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.cuiTxtBuscar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(29, 79);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(548, 58);
            this.tableLayoutPanel3.TabIndex = 2;
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
            this.cuiTxtBuscar.PlaceholderText = "Buscar Usuarios";
            this.cuiTxtBuscar.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiTxtBuscar.Size = new System.Drawing.Size(540, 45);
            this.cuiTxtBuscar.TabIndex = 1;
            this.cuiTxtBuscar.TextOffset = new System.Drawing.Size(0, 0);
            this.cuiTxtBuscar.UnderlinedStyle = true;
            this.cuiTxtBuscar.ContentChanged += new System.EventHandler(this.cuiTxtBuscar_ContentChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.cmbEstado, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ibtnEliminar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ibtnAgregar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(639, 79);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(367, 58);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(247, 18);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(117, 29);
            this.cmbEstado.TabIndex = 4;
            this.cmbEstado.Visible = false;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // ibtnEliminar
            // 
            this.ibtnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnEliminar.IconColor = System.Drawing.Color.Black;
            this.ibtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEliminar.IconSize = 30;
            this.ibtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnEliminar.Location = new System.Drawing.Point(124, 2);
            this.ibtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnEliminar.Name = "ibtnEliminar";
            this.ibtnEliminar.Size = new System.Drawing.Size(118, 47);
            this.ibtnEliminar.TabIndex = 4;
            this.ibtnEliminar.Text = "Eliminar";
            this.ibtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEliminar.UseVisualStyleBackColor = true;
            this.ibtnEliminar.Click += new System.EventHandler(this.ibtnEliminar_Click);
            // 
            // ibtnAgregar
            // 
            this.ibtnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ibtnAgregar.IconColor = System.Drawing.Color.Black;
            this.ibtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAgregar.IconSize = 30;
            this.ibtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAgregar.Location = new System.Drawing.Point(3, 3);
            this.ibtnAgregar.Name = "ibtnAgregar";
            this.ibtnAgregar.Size = new System.Drawing.Size(116, 45);
            this.ibtnAgregar.TabIndex = 3;
            this.ibtnAgregar.Text = "Agregar";
            this.ibtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAgregar.UseVisualStyleBackColor = true;
            this.ibtnAgregar.Click += new System.EventHandler(this.ibtnAgregar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(967, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel1.Controls.Add(this.cuiGroupBox1);
            this.cuiPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiPanel1.Location = new System.Drawing.Point(19, 19);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiPanel1.Size = new System.Drawing.Size(1073, 624);
            this.cuiPanel1.TabIndex = 1;
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
            this.cuiGroupBox1.Controls.Add(this.tableLayoutPanel3);
            this.cuiGroupBox1.Controls.Add(this.tableLayoutPanel4);
            this.cuiGroupBox1.Controls.Add(this.tableLayoutPanel1);
            this.cuiGroupBox1.Location = new System.Drawing.Point(21, 18);
            this.cuiGroupBox1.Name = "cuiGroupBox1";
            this.cuiGroupBox1.Padding = new System.Windows.Forms.Padding(4, 24, 4, 4);
            this.cuiGroupBox1.Rounding = new System.Windows.Forms.Padding(4);
            this.cuiGroupBox1.Size = new System.Drawing.Size(1035, 593);
            this.cuiGroupBox1.TabIndex = 0;
            // 
            // UcUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cuiPanel1);
            this.Name = "UcUsuarios";
            this.Size = new System.Drawing.Size(1112, 664);
            this.Load += new System.EventHandler(this.UcUsuarios_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private FontAwesome.Sharp.IconButton ibtnAgregar;
        private FontAwesome.Sharp.IconButton ibtnEliminar;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiGroupBox cuiGroupBox1;
        private CuoreUI.Controls.cuiTextBox cuiTxtBuscar;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}
