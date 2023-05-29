using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Detalle_factura
    {
        public Int64 IdDetalleFactura { get; set; }

        public string PrecioUnitario { get; set; }

        public string PrecioVenta { get; set; }

        public int Cantidad { get; set; }

        public Int64 IdProducto { get; set; }

        public Int64 IdFactura { get; set; }

        public Producto Producto { get; set; }

        public Factura Factura { get; set; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO detalle_factura(precio_unitario, precio_venta, cantidad, id_producto, id_factura) 
                VALUES('" + PrecioUnitario + "','" + PrecioVenta + "'," + Cantidad + ",'" + IdProducto + "'," + IdFactura + ");";
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
