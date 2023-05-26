using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA.CLS
{
    public class Factura
    {
        public Int64 IdFactura { get; set; }

        public string FechaRegistro { get; set; }

        public string  Descripcion { get; set; }

        public string NumeroDocumento { get; set; }

        public string MontoTotal { get; set; }

        public int CantidadProductos { get; set; }

        public int MontoCliente { get; set; }

        public string Cambio { get; set; }

        public bool Estado { get; set; }

        public Int64 IdTipoPago { get; set; }

        public Int64 IdCliente { get; set; }

        public Int64  IdEmpleado { get; set; }

        public Tipo_pago Tipo_pago { get; set; }

        public Cliente Cliente { get; set; }

        public Empleado Empleado { get; set; }
    }
}
