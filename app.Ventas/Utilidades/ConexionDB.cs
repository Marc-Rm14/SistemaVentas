using System;

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

                _cadenaConexion = conexion.cadenaConexion;
            }
            return _cadenaConexion;
        }
    }
}
