using app.Ventas.Utilidades;
using System;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class FrmPanelControl : Form
    {
        private UCProductos _ucProductos;
        private UcClientes _ucClientes;
        private bool salirDesdeBoton = false;
        private Usuario _usuario;
        private UcUsuarios _ucUsuarios;
        private UcCategorias _ucCategorias;
        private UcVentas _UcVentas;
        private UcDashBoard _ucdashBoard;
        private UcReportes _ucReportes;
      

        public FrmPanelControl()
        {
            InitializeComponent();
            this.CancelButton = ibtnSalir;
            
        }

        public FrmPanelControl(Usuario usuario)// Segundo Constructor que recibe el objeto usuario.
        {
            InitializeComponent();
            _usuario = usuario;

            AplicarPermisos();
        }
        private void AplicarPermisos()
        {
            if (_usuario.Rol == "Vendedor")
            {
                ibtnClientes.Enabled = false;
                ibtnUsuarios.Enabled = false;

            }
            //Despues de configurar Roles mostramos el label
            lblUsuario.Text = $"Bienvenido,\n{_usuario.NombreCompleto} ({_usuario.Rol})";
        }

        //NOTA: El método mostrarContenido fue eliminado porque solo funcionaba dentro de este formulario.
        // Se reemplazó por mostrarVistas(panel, userControl) para mayor flexibilidad.
        /*
        private void mostrarContenido(UserControl control, Panel panelDestino)
        {
            panelDestino.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelDestino.Controls.Add(control);
        }
        */
        #region botones del panel control
        private void ibtnProductos_Click(object sender, EventArgs e) //NOTA: Seguir la misma estructura o estilo para cada UC
        {
            
            // 1. ¿La vista de productos no ha sido creada o fue desechada?
            if (_ucProductos == null || _ucProductos.IsDisposed)
            {
                // 2. Si es así, la creamos UNA SOLA VEZ.
                _ucProductos = new UCProductos(_usuario);

                // 3. Y nos suscribimos a sus eventos UNA SOLA VEZ. 
                _ucProductos.OnAgregarProductoClick += UcProductos_OnAgregarProductoClick; //forma explicita en vez de lambda
            }

            // 4. Finalmente, mostramos la vista (ya sea la recién creada o la que ya existía).
            panelCentral.MostrarVista(_ucProductos);

        }


        private void UcProductos_OnAgregarProductoClick()
        {
            using (var frmAgregar = new FrmAgregarProductos())
            {
                //NOTA: Se cambio la expresion lamda por un metodo explicito
                frmAgregar.registroAgregado += FrmAgregar_productoAgregado;

                MostrarModal.MostrarConCapa(this, frmAgregar);
            }
            
        }
        private void FrmAgregar_productoAgregado()
        {
            //despues de agregar el producto refrescamos
            _ucProductos?.RefrescarDatos();
        }

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea salir del sistema de ventas?\n\nLos cambios no guardados se perderán.",
                "Salir del sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                salirDesdeBoton = true; // Indicamos que el cierre viene del botón
                this.Close(); // Esto dispara FormClosing
            }
        }

        private void ibtnClientes_Click(object sender, EventArgs e)
        {
            if (_ucClientes == null || _ucClientes.IsDisposed)
            {
                _ucClientes = new UcClientes();

                _ucClientes.OnAgregarClienteClick += UcProductos_OnClienteProductoClick; //forma explicita en vez de lamda
            }
            panelCentral.MostrarVista(_ucClientes);
        }
        
        private void UcProductos_OnClienteProductoClick()
        {
            using (var frmAgregar = new FrmAgregarCliente())
            {
                //NOTA: se cambio la expresion lambda por un metodo explicito
                frmAgregar.registroAgregado += FrmAgregar_clienteAgregado;

                MostrarModal.MostrarConCapa(this, frmAgregar);
            }
        }

        private void FrmAgregar_clienteAgregado()
        {
            //despues de agregar el registro, refrescamos.
            _ucClientes?.RefrescarDatos();
        }

        private void ibtnUsuarios_Click(object sender, EventArgs e)
        {
            if (_ucUsuarios == null || _ucUsuarios.IsDisposed)
            {
                _ucUsuarios = new UcUsuarios();
                _ucUsuarios.OnAgregarUsuarioClick += UcUsuarios_OnUsuarioClick;
            }
            panelCentral.MostrarVista(_ucUsuarios);
        }


        private void UcUsuarios_OnUsuarioClick()
        {
            using (var frmAgregar = new FrmAgregarUsuario())
            {
                frmAgregar.registroAgregado += FrmAgregar_usuarioAgregado;
                MostrarModal.MostrarConCapa(this, frmAgregar);
            }

        }
        private void FrmAgregar_usuarioAgregado()
        {
            //despues de agregar el registro, refrescamos.
            _ucUsuarios?.refrescarDatos();
        }

        private void ibtnCategorias_Click(object sender, EventArgs e)
        {
            if (_ucCategorias == null || _ucCategorias.IsDisposed)
            {
                _ucCategorias = new UcCategorias(_usuario);

                _ucCategorias.OnAgregarCategoriaClick += UcProductos_OnCategoriaProductoClick; //forma explicita en vez de lambda

            }
            panelCentral.MostrarVista(_ucCategorias);
        }

        private void UcProductos_OnCategoriaProductoClick()
        {
            using (var frmAgregar = new frmAgregarCategoria())
            {

                frmAgregar.registroAgregado += FrmAgregar_categoriaAgregada;

                MostrarModal.MostrarConCapa(this, frmAgregar);
            }
        }

        private void FrmAgregar_categoriaAgregada()
        {
            //despues de agregar el registro, refrescamos.
            _ucCategorias?.refrescarDatos();
        }

        private void ibtnVentas_Click(object sender, EventArgs e)
        {
            if (_UcVentas == null || _UcVentas.IsDisposed) 
            {
                _UcVentas = new UcVentas(_usuario);
                
                _UcVentas.VentaGuardada += UcVentas_VentaGuardada;
            }
            
            panelCentral.MostrarVista(_UcVentas);
        }

        private void UcVentas_VentaGuardada()
        {
            // Llamamos al refresco solo si existe la instancia de productos
            _ucProductos?.RefrescarDatos();
        }


        private void ibtnDashBoard_Click(object sender, EventArgs e)
        {
            _ucdashBoard = new UcDashBoard();
            panelCentral.MostrarVista(_ucdashBoard);
        }

        private void ibtnReportes_Click(object sender, EventArgs e)
        {
            _ucReportes = new UcReportes();
            panelCentral.MostrarVista(_ucReportes);
        }
        #endregion


        #region Eventos del formulario
        private void FrmPanelControl_Load(object sender, EventArgs e)
        {
            ibtnProductos_Click(sender, e);
        }

        private void FrmPanelControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!salirDesdeBoton) // Solo mostramos confirmación si NO viene del botón
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro que desea salir?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

    }
}
