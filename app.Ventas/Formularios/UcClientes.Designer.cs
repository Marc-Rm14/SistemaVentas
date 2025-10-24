namespace app.Ventas.Formularios
{
    partial class UcClientes
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
            this.panelBotones = new System.Windows.Forms.Panel();
            this.ibtnEliminar = new FontAwesome.Sharp.IconButton();
            this.ibtnAgregar = new FontAwesome.Sharp.IconButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtBoxBuscarClientes = new System.Windows.Forms.TextBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Controls.Add(this.panelBotones);
            this.panelContenedor.Controls.Add(this.dgvClientes);
            this.panelContenedor.Controls.Add(this.txtBoxBuscarClientes);
            this.panelContenedor.Controls.Add(this.lblListado);
            this.panelContenedor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContenedor.Location = new System.Drawing.Point(12, 17);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(765, 560);
            this.panelContenedor.TabIndex = 1;
            // 
            // panelBotones
            // 
            this.panelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotones.Controls.Add(this.ibtnEliminar);
            this.panelBotones.Controls.Add(this.ibtnAgregar);
            this.panelBotones.Location = new System.Drawing.Point(468, 31);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(2);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(270, 53);
            this.panelBotones.TabIndex = 4;
            // 
            // ibtnEliminar
            // 
            this.ibtnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnEliminar.IconColor = System.Drawing.Color.Black;
            this.ibtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEliminar.IconSize = 30;
            this.ibtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnEliminar.Location = new System.Drawing.Point(127, 3);
            this.ibtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnEliminar.Name = "ibtnEliminar";
            this.ibtnEliminar.Size = new System.Drawing.Size(112, 47);
            this.ibtnEliminar.TabIndex = 3;
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
            this.ibtnAgregar.Location = new System.Drawing.Point(18, 3);
            this.ibtnAgregar.Name = "ibtnAgregar";
            this.ibtnAgregar.Size = new System.Drawing.Size(104, 48);
            this.ibtnAgregar.TabIndex = 2;
            this.ibtnAgregar.Text = "Agregar";
            this.ibtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAgregar.UseVisualStyleBackColor = true;
            this.ibtnAgregar.Click += new System.EventHandler(this.ibtnAgregar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvClientes.Location = new System.Drawing.Point(21, 114);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(717, 413);
            this.dgvClientes.TabIndex = 3;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // txtBoxBuscarClientes
            // 
            this.txtBoxBuscarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxBuscarClientes.Location = new System.Drawing.Point(21, 57);
            this.txtBoxBuscarClientes.Name = "txtBoxBuscarClientes";
            this.txtBoxBuscarClientes.Size = new System.Drawing.Size(372, 27);
            this.txtBoxBuscarClientes.TabIndex = 1;
            this.txtBoxBuscarClientes.Text = "Buscar Clientes";
            this.txtBoxBuscarClientes.TextChanged += new System.EventHandler(this.txtBoxBuscarClientes_TextChanged);
            this.txtBoxBuscarClientes.Enter += new System.EventHandler(this.txtBoxBuscarProductos_Enter);
            this.txtBoxBuscarClientes.Leave += new System.EventHandler(this.txtBoxBuscarClientes_Leave);
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(17, 10);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(192, 30);
            this.lblListado.TabIndex = 0;
            this.lblListado.Text = "Listado de Clientes";
            // 
            // UcClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContenedor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcClientes";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.UcClientes_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelBotones;
        private FontAwesome.Sharp.IconButton ibtnEliminar;
        private FontAwesome.Sharp.IconButton ibtnAgregar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtBoxBuscarClientes;
        private System.Windows.Forms.Label lblListado;
    }
}
