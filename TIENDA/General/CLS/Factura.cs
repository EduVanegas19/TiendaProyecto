using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Factura
    {

        public Int64 IdFactura { get; set; }

        public string FechaRegistro { get; set; }

        public string Descripcion { get; set; }

        public string NumeroDocumento { get; set; }

        public string MontoTotal { get; set; }

        public int CantidadProductos { get; set; }

        public int MontoCliente { get; set; }

        public string Cambio { get; set; }

        public bool Estado { get; set; }

        public Int64 IdTipoPago { get; set; }

        public Int64 IdCliente { get; set; }

        public Int64 IdEmpleado { get; set; }

        public Tipo_pago Tipo_pago { get; set; }

        public Cliente Cliente { get; set; }

        public Empleado Empleado { get; set; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO facturas(fecha, descripcion, numero_documento, monto_total, cantidad_productos, monto_cliente, cambio, estado, id_tipopago, id_empleado, id_cliente) 
                VALUES('" + FechaRegistro + "','" + Descripcion + "'," + NumeroDocumento + ",'" + MontoTotal + "'," + CantidadProductos + "','" + MontoCliente + "'," + Cambio + ",'" + Estado + "'," + IdTipoPago + "'," + IdEmpleado + "'," + IdCliente + ");";
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
