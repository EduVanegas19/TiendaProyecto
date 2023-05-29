﻿using System;
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
    }
}