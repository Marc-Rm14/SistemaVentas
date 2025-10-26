using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Ventas.Utilidades
{
    public static class ConexionDB
    {
        private static string _cadenaConexion;

        public static string ObtenerConexion()
        {
            if (string.IsNullOrEmpty(_cadenaConexion))
            {
                var conexion = AdministrarConexion.Cargar();

                if (string.IsNullOrWhiteSpace(conexion?.servidor) || string.IsNullOrWhiteSpace(conexion?.baseDatos))
                    throw new InvalidOperationException("La conexion no esta configurada.");

                return conexion.cadenaConexion;
            }
            return _cadenaConexion;
        }
    }
}
