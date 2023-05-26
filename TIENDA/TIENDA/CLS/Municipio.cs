using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA.CLS
{
    public class Municipio
    {
        public Int64 IdMunicipio { get; set; }

        public string Nombre { get; set; }

        public bool Estado { get; set; }

        public Int64 IdDepartamento { get; set; }

        public Departamento Departamento { get; set; }
    }
}
