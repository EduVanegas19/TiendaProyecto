using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Departamento
    {
        String _IdDepartamento;
        String _Nombre;

        public string IdDepartamento { get => _IdDepartamento; set => _IdDepartamento = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }

    }
}
