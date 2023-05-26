using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Direccion
    {
        public Int64 IdDireccion { get; set; }

        public string NumeroCasa { get; set; }

        public string PasajePoligono { get; set; }

        public string calle { get; set; }

        public string colonia { get; set; }

        public string canton { get; set; }

        public string caserio { get; set; }

        public string CodigoPostal { get; set; }

        public bool Estado { get; set; }

        public Int64 IdMunicipio { get; set; }

        public Municipio Municipio { get; set; }

    }
}
