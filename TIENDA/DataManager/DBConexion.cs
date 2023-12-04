using System;
using System.Data.SqlClient;

namespace DataManager
{
    public class DBConexion
    {
        protected SqlConnection _CONEXION = new SqlConnection();

        String _CadenaConexion = "Data Source=alfredserver.com;Initial Catalog=Tienda;User ID=OscarAppUser;Password=OQl&@%(R";
        public static string cn = "Data Source=alfredserver.com;Initial Catalog=Tienda;User ID=OscarAppUser;Password=OQl&@%(R";

        public Boolean Conectar()
        {
            Boolean result = false;
            try
            {
                _CONEXION.ConnectionString = _CadenaConexion;
                _CONEXION.Open();
                // Accediendo a ServerVersion después de abrir la conexión.
                string serverVersion = _CONEXION.ServerVersion;

                // Haz algo con serverVersion, como imprimirlo a la consola
                Console.WriteLine(serverVersion);
                result = true;
            }
            catch (Exception ex)
            {
                // Es útil incluir algún tipo de manejo de errores o registro aquí.
                Console.WriteLine(ex.Message);
                result = false;
            }
            return result;
        }

        public SqlConnection ObtenerConexion()
        {
            return _CONEXION;
        }


        public void Desconectar()
        {
            try
            {
                if (_CONEXION.State == System.Data.ConnectionState.Open)
                {
                    _CONEXION.Close();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
