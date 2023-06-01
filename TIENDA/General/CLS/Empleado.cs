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
        String _IdDireccion;
        String _Estado;

        public string IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Genero { get => _Genero; set => _Genero = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string DUI { get => _DUI; set => _DUI = value; }
        public string FechaNac { get => _FechaNac; set => _FechaNac = value; }
        public string IdDireccion { get => _IdDireccion; set => _IdDireccion = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

        //CRUD
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec AgregarEmpleados '" + _Nombre + "','" + _Apellido + "','" + _Genero + "','" + _Telefono + "','" + _Correo + "','" + _DUI + "','" + _FechaNac + "'," + _IdDireccion + "," + _Estado + ";";
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
                Sentencia = @"exec ModificarEmpleados " + _IdEmpleado + ",'" + _Nombre + "','" + _Apellido + "','" + _Genero + "','" + _Telefono + "','" + _Correo + "','" + _DUI + "','" + _FechaNac + "'," + _IdDireccion + "," + _Estado + ";";
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
