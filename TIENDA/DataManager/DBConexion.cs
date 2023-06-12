using System;
using System.Data.SqlClient;

namespace DataManager
{
    public class DBConexion
    {
        protected SqlConnection _CONEXION = new SqlConnection();

<<<<<<< Updated upstream
        String _CadenaConexion = "Data Source=alfredserver.com;Initial Catalog=Tienda;User ID=OscarAppUser;Password=OQl&@%(R"; 
=======
        //static string servidor = "localhost";
        //static string BD = "Tienda";
        //static string usuario = "usuario";
        //static string password = "123";
        //static string puerto = "1433";

        String _CadenaConexion = "Data Source=alfredserver.com;Initial Catalog=Tienda;User ID=OscarAppUser;Password=OQl&@%(R";
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream


=======
>>>>>>> Stashed changes
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
