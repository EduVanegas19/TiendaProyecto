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
        String _NumeroDocumento;
        String _FechaRegistro;
        String _MontoTotal;
        String _IdProveedor;
        String _Cantidad;
        String _subTotal;
        String _IdProducto;
        String _PrecioUnidad;
        String _PrecioVenta;
        

        public string IdPedido { get => _IdPedido; set => _IdPedido = value; }
        public string NumeroDocumento { get => _NumeroDocumento; set => _NumeroDocumento = value; }
        public string FechaRegistro { get => _FechaRegistro; set => _FechaRegistro = value; }
        public string MontoTotal { get => _MontoTotal; set => _MontoTotal = value; }
        public string IdProveedor { get => _IdProveedor; set => _IdProveedor = value; }

        public string Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string subTotal { get => _subTotal; set => _subTotal = value; }
        public string IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public string PrecioVenta { get => _PrecioVenta; set => _PrecioVenta = value; }
        public string PrecioUnidad { get => _PrecioUnidad; set => _PrecioUnidad = value; }

        //CRUD
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec AgregarPedidoProveedor '" + _NumeroDocumento + "','" + _FechaRegistro + "'," + _MontoTotal + "," + _IdProveedor + "," + _Cantidad + "," + _subTotal + "," + _IdProducto + "," + _PrecioUnidad + "," + _PrecioVenta +  ";";
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
                Sentencia = @"exec ModificarPedidoProveedor " + _IdPedido + ",'" + _NumeroDocumento + "','" + _FechaRegistro + "'," + _MontoTotal + ","  + _IdProveedor + "," + _Cantidad + "," + _subTotal + "," + _IdProducto + "," + _PrecioUnidad + "," + _PrecioVenta + ";";
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
