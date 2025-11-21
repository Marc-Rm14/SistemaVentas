using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace app.Ventas.Utilidades
{
    /// <summary>
    /// Esta Clase genera un objeto tipo Usuario
    /// </summary>
    public class Usuario
        
    {
        
        public int UsuarioID { get; private set; }
        public string NombreUsuario { get; private set; }
        public string NombreCompleto { get; private set; }
        public string Rol { get; private set; }

        public bool Activo { get; private set; }

        public Usuario(int usuarioID, string nombreUsuario, string nombreCompleto, string rol, bool activo) 
        {
            UsuarioID = usuarioID;
            NombreUsuario = nombreUsuario;
            NombreCompleto = nombreCompleto;
            Rol = rol;
            Activo = activo;
        }

    }
}
