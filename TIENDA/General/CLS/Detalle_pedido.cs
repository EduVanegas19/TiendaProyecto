using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Detalle_pedido
    {
        public Int64 IdDetallePedido { get; set; }

        public int Cantidad { get; set; }

        public string MontoSubTotal { get; set; }

        public bool Estado { get; set; }

        public Int64 IdPedido { get; set; }

        public Int64 IdProducto { get; set; }

        public Pedido_proveedor Pedido_Proveedor { get; set; }

        public Producto Producto { get; set; }
    }
}
