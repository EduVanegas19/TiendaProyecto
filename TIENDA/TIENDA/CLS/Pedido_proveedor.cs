using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA.CLS
{
    public class Pedido_proveedor
    {
        public Int64 IdPedido { get; set; }

        public string NumeroDocumento { get; set; }

        public string FechaRegistro { get; set; }

        public string MontoTotal { get; set; }

        public bool Estado { get; set; }

        public Int64 IdProveedor { get; set; }

        public Proveedor Proveedor { get; set; }

        public List<Detalle_pedido> Detalle_pedido { get; set; }

    }
}
