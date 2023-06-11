using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Cliente
    {
        String _IdCliente;
        String _Identificacion;
        String _Nombre;
        String _Credito;
        String _NumeroCasa;
        String _PasajePoligono;
        String _Calle;
        String _Colonia;
        String _Canton;
        String _Caserio;
        String _CodigoPostal;
        String _IdMunicipio;
        String _IdDireccion;

        public string NumeroCasa { get => _NumeroCasa; set => _NumeroCasa = value; }
        public string PasajePoligono { get => _PasajePoligono; set => _PasajePoligono = value; }
        public string Calle { get => _Calle; set => _Calle = value; }
        public string Colonia { get => _Colonia; set => _Colonia = value; }
        public string Canton { get => _Canton; set => _Canton = value; }
        public string Caserio { get => _Caserio; set => _Caserio = value; }
        public string CodigoPostal { get => _CodigoPostal; set => _CodigoPostal = value; }
        public string IdMunicipio { get => _IdMunicipio; set => _IdMunicipio = value; }
        public string IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public string Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Credito { get => _Credito; set => _Credito = value; }
        public string IdDireccion { get => _IdDireccion; set => _IdDireccion = value; }

        //CRUD
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec AgregarClientes '" + _Identificacion + "', '" + _Nombre + "', " + _Credito + ",'" + _NumeroCasa + "','" + _PasajePoligono + "','" + _Calle + "','" + _Colonia + "','" + _Canton + "','" + _Caserio + "','" + _CodigoPostal + "'," + _IdMunicipio + ";";
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
                Sentencia = @"exec ModificarClientes " + _IdCliente + ", '" + _Identificacion + "', '" + _Nombre + "', " + _Credito + ",'" + _NumeroCasa + "','" + _PasajePoligono + "','" + _Calle + "','" + _Colonia + "','" + _Canton + "','" + _Caserio + "','" + _CodigoPostal + "'," + _IdMunicipio + "," + _IdDireccion + ";";
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
                Sentencia = @"exec EliminarClientes " + _IdCliente + ";";
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
