using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Proveedor
    {
        public Int64 IdProveedor { get; set; }

        public string Nombre { get; set; }

        public string NumeroDocumento { get; set; }

        public bool EsLaboratorio { get; set; }
    }
}
