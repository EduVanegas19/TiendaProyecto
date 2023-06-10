using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Pedido_proveedor
    {
        String _IdPedido;
        String _FechaRegistro;
        String _MontoTotal;
        String _IdProveedor;
        String _NumDocumento;

        public string IdPedido { get => _IdPedido; set => _IdPedido = value; }
        public string FechaRegistro { get => _FechaRegistro; set => _FechaRegistro = value; }
        public string MontoTotal { get => _MontoTotal; set => _MontoTotal = value; }
        public string IdProveedor { get => _IdProveedor; set => _IdProveedor = value; }
        public string NumDocumento { get => _NumDocumento; set => _NumDocumento = value; }

        //CRUD
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec AgregarPedidoProveedor '"+ _NumDocumento +"','" + _FechaRegistro + "', " + _MontoTotal + ", " + _IdProveedor + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec ModificarPedidoProveedor " + _IdPedido + ",'" + _FechaRegistro + "'," + _MontoTotal + ","  + _IdProveedor + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasEliminadas = 0;
            try
            {
                Sentencia = @"exec EliminarPedidoProveedor " + _IdPedido + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasEliminadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasEliminadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
    }
}
