using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Empleado
    {
        String _IdEmpleado;
        String _Nombre;
        String _Apellido;
        String _Genero;
        String _Telefono;
        String _Correo;
        String _DUI;
        String _FechaNac;
        String _NumeroCasa;
        String _PasajePoligono;
        String _Calle;
        String _Colonia;
        String _Canton;
        String _Caserio;
        String _CodigoPostal;
        String _IdMunicipio;

        public string NumeroCasa { get => _NumeroCasa; set => _NumeroCasa = value; }
        public string PasajePoligono { get => _PasajePoligono; set => _PasajePoligono = value; }
        public string Calle { get => _Calle; set => _Calle = value; }
        public string Colonia { get => _Colonia; set => _Colonia = value; }
        public string Canton { get => _Canton; set => _Canton = value; }
        public string Caserio { get => _Caserio; set => _Caserio = value; }
        public string CodigoPostal { get => _CodigoPostal; set => _CodigoPostal = value; }
        public string IdMunicipio { get => _IdMunicipio; set => _IdMunicipio = value; }

        public string IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string DUI { get => _DUI; set => _DUI = value; }
        public string FechaNac { get => _FechaNac; set => _FechaNac = value; }

        //CRUD
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec AgregarEmpleados '" + _Nombre + "','" + _Apellido + "','" + _Genero + "','" + _Telefono + "','" + _Correo + "','" + _DUI + "','" + _FechaNac + "','" + _NumeroCasa + "','" + _PasajePoligono + "','" + _Calle + "','" + _Colonia + "','" + _Canton + "','" + _Caserio + "','" + _CodigoPostal + "'," + _IdMunicipio + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec ModificarEmpleados " + _IdEmpleado + ",'" + _Nombre + "','" + _Apellido + "','" + _Genero + "','" + _Telefono + "','" + _Correo + "','" + _DUI + "','" + _FechaNac + "','" + _NumeroCasa + "','" + _PasajePoligono + "','" + _Calle + "','" + _Colonia + "','" + _Canton + "','" + _Caserio + "','" + _CodigoPostal + "'," + _IdMunicipio + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasEliminadas = 0;
            try
            {
                Sentencia = @"exec EliminarEmpleados " + _IdEmpleado + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasEliminadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasEliminadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
    }
}
