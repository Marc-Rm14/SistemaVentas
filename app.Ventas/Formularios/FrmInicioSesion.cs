using app.Ventas.Utilidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace app.Ventas.Formularios
{
    public partial class FrmInicioSesion : Form
    {
        public Usuario UsuarioAutenticado { get; private set; }
        private const string txtusuarioPlaceholder = "Usuario";
        private const string txtcontrasenaPlaceholder = "Contraseña";
        private bool cambiando;
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        public FrmInicioSesion(bool cambiandoUsuario)
        {
            InitializeComponent();
            cambiando = cambiandoUsuario; //Nueva variable para saber en donde esta el formualario
        }

        private Usuario AutenticarUsuario(string usuario, string contrasena)
        {
            try
            {
                string connectionString = ConexionDB.ObtenerConexion();
                string sql = @"
            SELECT 
                u.UsuarioID, 
                u.NombreUsuario,
                u.NombreCompleto,
                u.Activo,
                r.NombreRol as Rol,
                r.RolID
            FROM Usuarios u
            INNER JOIN Roles r ON u.RolID = r.RolID
            WHERE u.NombreUsuario = @user 
            AND u.Contrasena = @pass
            ";

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = usuario ?? string.Empty;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar, 255).Value = contrasena ?? string.Empty;

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Ahora usamos el constructor, con esto nos aseguramos que nunca cambien la propiedades en memoria
                            return new Usuario(
                                (int)reader["UsuarioID"],
                                reader["NombreUsuario"].ToString(),
                                reader["NombreCompleto"].ToString(),
                                reader["Rol"].ToString(),
                                (bool)reader["Activo"]
                            );
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al autenticar: " + ex.Message);
                return null;
            }
        }





        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Gray;
                //panelUsuario.BackColor = Color.RoyalBlue;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = txtusuarioPlaceholder;
                txtUsuario.ForeColor = Color.Gray;
                //panelUsuario.BackColor = Color.White;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Gray;
                //panel2.BackColor = Color.RoyalBlue;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = txtcontrasenaPlaceholder;
                txtContrasena.ForeColor = Color.Gray;
                //panel2.BackColor = Color.White;
                txtContrasena.PasswordChar = '\0';
                txtContrasena.UseSystemPasswordChar = false;

            }
            else
            {
                txtContrasena.PasswordChar = '*';
                txtContrasena.UseSystemPasswordChar = true;
                //panel2.BackColor = Color.White;
            }
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasena.Text != "Contraseña")
            {
                txtContrasena.PasswordChar = '*';
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string pass = txtContrasena.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass) || user == txtusuarioPlaceholder || pass == txtcontrasenaPlaceholder)
            {
                MessageBox.Show("Debe ingresar usuario y contraseña.");
                return;
            }

            var usuario = AutenticarUsuario(user, pass);
            

            if (usuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                return;
            }
            UsuarioAutenticado = usuario; // Guardamos el objeto

            if (UsuarioAutenticado.Activo == false)
            {
                MessageBox.Show("El Usuario esta inactivo, contacte con el adminstrador");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtContrasena.Focus();
                e.Handled = true;
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (cambiando == true) //NOTA: verificamos endonde esta abierto el formulario, YA.
            {
                this.Close();
                return;
            }
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?",
                                                       "Confirmar",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

            if (result == DialogResult.No) return;


            Application.Exit();
            
        }
    }
}
