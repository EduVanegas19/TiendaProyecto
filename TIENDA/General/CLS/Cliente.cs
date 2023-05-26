using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Cliente
    {
        public Int64 IdCliente { get; set; }

        public string Identificacion { get; set; }

        public string Nombre { get; set; }

        public float Credito { get; set; }

        public bool Estado { get; set; }

        public List<Direccion> Direccion { get; set; }
    }
}
