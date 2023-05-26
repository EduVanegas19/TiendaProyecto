using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA.CLS
{
    public class Empleado
    {
        public Int64 IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string DUI { get; set; }
        public string FechaNacimiento { get; set; }
        public bool Estado { get; set; }
        public Int64 IdDireccion { get; set; }
        public Direccion Direccion { get; set; }
    }
}
