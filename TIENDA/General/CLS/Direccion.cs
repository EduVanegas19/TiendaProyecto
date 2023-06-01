using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Direccion
    {
        String _IdDireccion;
        String _NumeroCasa;
        String _PasajePoligono;
        String _Calle;
        String _Colonia;
        String _Canton;
        String _Caserio;
        String _CodigoPostal;
        String _Estado;
        String _IdMunicipio;

        public string IdDireccion { get => _IdDireccion; set => _IdDireccion = value; }
        public string NumeroCasa { get => _NumeroCasa; set => _NumeroCasa = value; }
        public string PasajePoligono { get => _PasajePoligono; set => _PasajePoligono = value; }
        public string Calle { get => _Calle; set => _Calle = value; }
        public string Colonia { get => _Colonia; set => _Colonia = value; }
        public string Canton { get => _Canton; set => _Canton = value; }
        public string Caserio { get => _Caserio; set => _Caserio = value; }
        public string CodigoPostal { get => _CodigoPostal; set => _CodigoPostal = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string IdMunicipio { get => _IdMunicipio; set => _IdMunicipio = value; }

        //CRUD
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec AgregarDirecciones '" + _NumeroCasa + "','" + _PasajePoligono + "','" + _Calle + "','" + _Colonia + "','" + _Canton + "','" + _Caserio + "','" + _CodigoPostal + "'," + _Estado + "," + _IdMunicipio + ";";
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
                Sentencia = @"exec ModificarDirecciones " + _IdDireccion + ",'" + _NumeroCasa + "','" + _PasajePoligono + "','" + _Calle + "','" + _Colonia + "','" + _Canton + "','" + _Caserio + "','" + _CodigoPostal + "'," + _Estado + "," + _IdMunicipio + ";";
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
                Sentencia = @"exec EliminarDirecciones " + _IdDireccion + ";";
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
