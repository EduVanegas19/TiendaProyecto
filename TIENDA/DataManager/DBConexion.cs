using System;
using System.Data.SqlClient;

namespace DataManager
{
    public class DBConexion
    {
        protected SqlConnection _CONEXION = new SqlConnection();

        //static string servidor = "localhost";
        //static string BD = "Tienda";
        //static string usuario = "usuario";
        //static string password = "123";
        //static string puerto = "1433";

        String _CadenaConexion = "Data Source=localhost;Initial Catalog = Tienda; User ID = usuario; Password=123;Application Name = MyApp";

        public Boolean Conectar()
        {
            Boolean result = false;
            try
            {
                _CONEXION.ConnectionString = _CadenaConexion;
                _CONEXION.Open();
                result = true;
            }
            catch (Exception)
            {
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
