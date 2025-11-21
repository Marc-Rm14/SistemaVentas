namespace app.Ventas.Formularios
{
    partial class frmAgregarCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            this.cuiFormAnimator1 = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.lblCategoria = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardarCat = new FontAwesome.Sharp.IconButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAgCategoria = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActivo = new CuoreUI.Controls.cuiCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(399, 41);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Registro de Categorias";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // cuiFormRounder1
            // 
            this.cuiFormRounder1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiFormRounder1.Rounding = 15;
            this.cuiFormRounder1.TargetForm = this;
            // 
            // cuiFormAnimator1
            // 
            this.cuiFormAnimator1.AnimateOnStart = true;
            this.cuiFormAnimator1.Duration = 400;
            this.cuiFormAnimator1.EasingType = CuoreUI.Helpers.DrawingHelper.EasingTypes.QuadOut;
            this.cuiFormAnimator1.StartOpacity = 0D;
            this.cuiFormAnimator1.TargetForm = this;
            this.cuiFormAnimator1.TargetOpacity = 1D;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategoria.Location = new System.Drawing.Point(4, 2);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(88, 71);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardarCat);
            this.panel1.Location = new System.Drawing.Point(63, 222);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 59);
            this.panel1.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.Location = new System.Drawing.Point(175, 11);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarCat
            // 
            this.btnGuardarCat.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCat.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardarCat.IconColor = System.Drawing.Color.Black;
            this.btnGuardarCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCat.Location = new System.Drawing.Point(10, 11);
            this.btnGuardarCat.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCat.Name = "btnGuardarCat";
            this.btnGuardarCat.Size = new System.Drawing.Size(100, 40);
            this.btnGuardarCat.TabIndex = 0;
            this.btnGuardarCat.Text = "Guardar";
            this.btnGuardarCat.UseVisualStyleBackColor = false;
            this.btnGuardarCat.Click += new System.EventHandler(this.btnGuardarCat_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 307);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 18;
            this.txtId.Visible = false;
            // 
            // txtAgCategoria
            // 
            this.txtAgCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAgCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAgCategoria.Location = new System.Drawing.Point(96, 23);
            this.txtAgCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgCategoria.Name = "txtAgCategoria";
            this.txtAgCategoria.Size = new System.Drawing.Size(274, 29);
            this.txtAgCategoria.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lblCategoria, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkActivo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAgCategoria, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 146);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 71);
            this.label1.TabIndex = 18;
            this.label1.Text = "Activo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkActivo
            // 
            this.chkActivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkActivo.Checked = false;
            this.chkActivo.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.chkActivo.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.chkActivo.CheckedSymbolColor = System.Drawing.Color.White;
            this.chkActivo.Content = "Activo";
            this.chkActivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkActivo.Enabled = false;
            this.chkActivo.Location = new System.Drawing.Point(97, 91);
            this.chkActivo.MinimumSize = new System.Drawing.Size(16, 16);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.OutlineStyle = true;
            this.chkActivo.OutlineThickness = 1F;
            this.chkActivo.Rounding = 15;
            this.chkActivo.ShowSymbols = true;
            this.chkActivo.Size = new System.Drawing.Size(273, 34);
            this.chkActivo.TabIndex = 19;
            this.chkActivo.Text = "cuiCheckbox1";
            this.chkActivo.UncheckedForeground = System.Drawing.Color.Empty;
            this.chkActivo.UncheckedOutlineColor = System.Drawing.Color.Gray;
            this.chkActivo.UncheckedSymbolColor = System.Drawing.Color.Empty;
            // 
            // frmAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(399, 339);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardarCat;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAgCategoria;
        private System.Windows.Forms.Label label1;
        private CuoreUI.Controls.cuiCheckbox chkActivo;
    }
}