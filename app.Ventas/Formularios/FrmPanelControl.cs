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
        private Usuario _usuarioAnterior;

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
            ibtnClientes.Enabled = true;
            ibtnUsuarios.Enabled = true;
            ibtnCategorias.Enabled = true;
            ibtnDashBoard.Enabled = true;
            ibtnReportes.Enabled = true;

            if (_usuario.Rol == "Vendedor")
            {
                ibtnClientes.Enabled = false;
                ibtnUsuarios.Enabled = false;
                ibtnCategorias.Enabled = false;
                ibtnDashBoard.Enabled = false;
                ibtnReportes.Enabled = false;
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
                //forma explicita en vez de lambda:
                _ucProductos.OnAgregarProductoClick += UcProductos_OnAgregarProductoClick;
                _ucProductos.OnDatosCambiados += RefrescarVentas;
            }

            // 4. Finalmente, mostramos la vista (ya sea la recién creada o la que ya existía).
            panelCentral.MostrarVista(_ucProductos);

        }

        private void RefrescarVentas() 
        {
            _UcVentas?.RefrescarDatos();
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
            _UcVentas?.RefrescarDatos();
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
                _ucCategorias = new UcCategorias();

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

            // NOTA: El metodo suscrito al evento ahora tambien refresca nuestros graficos
            _ucdashBoard?.RefrescarDashBoard();
        }

        


        private void ibtnDashBoard_Click(object sender, EventArgs e)
        {
            if(_ucdashBoard == null  || _ucdashBoard.IsDisposed) 
            { _ucdashBoard = new UcDashBoard(); }
               
            panelCentral.MostrarVista(_ucdashBoard);
        }

        private void ibtnReportes_Click(object sender, EventArgs e)
        {
            if(_ucReportes == null  || _ucReportes.IsDisposed) _ucReportes = new UcReportes();

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

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            _usuarioAnterior = _usuario;

            using (var login = new FrmInicioSesion(true))
            {
                if (login.ShowDialog() == DialogResult.OK && login.UsuarioAutenticado != null)
                {
                    var nuevoUsuario = login.UsuarioAutenticado;

                    // Comparamos las propiedades de nuestra clasa
                    if (nuevoUsuario.UsuarioID == _usuarioAnterior.UsuarioID &&
                       nuevoUsuario.NombreUsuario == _usuarioAnterior.NombreUsuario)
                    {
                        MessageBox.Show($"El usuario: {_usuarioAnterior.NombreCompleto} ya está logeado",
                            "No se cambió el usuario",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }

                    //NOTA: ahora ven todo esta bien entonces cambiamos nuestro usuario
                    _usuario = nuevoUsuario;
                    AplicarPermisos();
                    LimpiarYRefrescarControles();

                    MessageBox.Show($"Usuario cambiado a: {_usuario.NombreCompleto}",
                             "Usuario cambiado",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
                }
            }
        }

        private void LimpiarYRefrescarControles()
        {
            // Limpiamos el panel central
            panelCentral.Controls.Clear();

            // Dispose de los controles de usuario existentes
            _ucProductos?.Dispose();
            _ucClientes?.Dispose();
            _ucUsuarios?.Dispose();
            _ucCategorias?.Dispose();
            _UcVentas?.Dispose();
            _ucdashBoard?.Dispose();
            _ucReportes?.Dispose();

            // Reiniciamos las referencias
            _ucProductos = null;
            _ucClientes = null;
            _ucUsuarios = null;
            _ucCategorias = null;
            _UcVentas = null;
            _ucdashBoard = null;
            _ucReportes = null;

            // Mostramos la vista por defecto (productos)
            ibtnProductos_Click(null, EventArgs.Empty);
        }

    }
}
