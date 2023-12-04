using System;

namespace General.CLS
{
    public class Factura
    {
        String _IdFactura;
        String _Fecha;
        String _Descripcion;
        String _NumeroDocumento;
        String _CantidadProductos;
        String _MontoTotal;
        String _MontoCliente;
        String _Cambio;
        String _IdTipoPago;
        String _IdEmpleado;
        String _IdCliente;
        String _DescuentoMonto;
        String _DescuentoRazon;

        public string IdFactura { get => _IdFactura; set => _IdFactura = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string NumeroDocumento { get => _NumeroDocumento; set => _NumeroDocumento = value; }
        public string CantidadProductos { get => _CantidadProductos; set => _CantidadProductos = value; }
        public string IdTipoPago { get => _IdTipoPago; set => _IdTipoPago = value; }
        public string IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }
        public string IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public string MontoTotal { get => _MontoTotal; set => _MontoTotal = value; }
        public string MontoCliente { get => _MontoCliente; set => _MontoCliente = value; }
        public string Cambio { get => _Cambio; set => _Cambio = value; }
        public string DescuentoMonto { get => _DescuentoMonto; set => _DescuentoMonto = value; }
        public string DescuentoRazon { get => _DescuentoRazon; set => _DescuentoRazon = value; }

        // CRUD 
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = $@"exec AgregarFactura '{_Fecha}','{_Descripcion}','{_NumeroDocumento}',{_MontoTotal},{_CantidadProductos},{_MontoCliente},{_Cambio},{_IdTipoPago},{_IdEmpleado},{_IdCliente},'{_DescuentoMonto}','{_DescuentoRazon}';";
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
                Sentencia = $@"exec ModificarFactura {_IdFactura},'{_Fecha}','{_Descripcion}','{_NumeroDocumento}',{_MontoTotal},{_CantidadProductos},{_MontoCliente},{_Cambio},{_IdTipoPago},{_IdEmpleado},{_IdCliente},'{_DescuentoMonto}','{_DescuentoRazon}';";
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
                Sentencia = $@"exec EliminarFactura {_IdFactura};";
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
