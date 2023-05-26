using System;
using System.Data;
using System.Data.SqlClient;

namespace DataManager
{
    public class DBOperacion : DBConexion
    {
        public Int32 EjecutarSentencia(String pSentencia)
        {
            Int32 FilasAfectadas = 0;
            SqlCommand Comando = new SqlCommand();
            if (base.Conectar())
            {
                Comando.Connection = base._CONEXION;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = pSentencia;
                try
                {
                    FilasAfectadas = Comando.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    String Mensaje = Ex.Message;
                    FilasAfectadas = -1;
                }
                base.Desconectar();
            }
            return FilasAfectadas;
        }

        public Int32 EjecutarProcedimiento(String nombreProcedimiento)
        {
            Int32 FilasAfectadas = 0;
            SqlCommand Comando = new SqlCommand();
            if (base.Conectar())
            {
                Comando.Connection = base._CONEXION;
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.CommandText = nombreProcedimiento;

                try
                {
                    FilasAfectadas = Comando.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    String Mensaje = Ex.Message;
                    FilasAfectadas = -1;
                }
                base.Desconectar();
            }
            return FilasAfectadas;
        }
        public DataTable Consultar(String pConsulta)
        {
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            SqlCommand Comando = new SqlCommand();
            DataTable Resultado = new DataTable();
            if (base.Conectar())
            {
                Comando.Connection = base._CONEXION;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = pConsulta;
                Adaptador.SelectCommand = Comando;
                try
                {
                    Adaptador.Fill(Resultado);
                }
                catch (Exception Ex)
                {
                    String Mensaje = Ex.Message;
                    Resultado = new DataTable();
                }
                base.Desconectar();
            }
            return Resultado;
        }
    }
}
