using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Ventas.Utilidades
{
    public static class ConexionDB
    {
        public static string ObtenerConexion()
        {
            var conexion = AdministrarConexion.Cargar();

            if (string.IsNullOrWhiteSpace(conexion?.servidor) || string.IsNullOrWhiteSpace(conexion?.baseDatos))
                throw new InvalidOperationException("La conexion no esta configurada.");

            return conexion.cadenaConexion;
        }
    }
}
