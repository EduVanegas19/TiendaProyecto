using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Detalle_pedido
    {
        String _IdDetallePedido;
        String _Cantidad;
        String _SubTotal;
        String _IdProducto;

        public string IdDetallePedido { get => _IdDetallePedido; set => _IdDetallePedido = value; }
        public string Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string SubTotal { get => _SubTotal; set => _SubTotal = value; }
        public string IdProducto { get => _IdProducto; set => _IdProducto = value; }

        //CRUD
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec AgregarDetallePedido " + _Cantidad + "," + _SubTotal + "," + _IdProducto + ";";
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
                Sentencia = @"exec ModificarDetallePedido " + _IdDetallePedido + "" + _Cantidad + "," + _SubTotal + "," + _IdProducto + ";";
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
    }
}
