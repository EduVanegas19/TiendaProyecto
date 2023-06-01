using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class subopciones
    {
        String _IdSubOpcion;
        String _IdOpcion;
        String _Nombre;
        String _NombreFormulario;
        String _Estado;

        public string IdSubOpcion { get => _IdSubOpcion; set => _IdSubOpcion = value; }
        public string IdOpcion { get => _IdOpcion; set => _IdOpcion = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string NombreFormulario { get => _NombreFormulario; set => _NombreFormulario = value; }
        public string Estado { get => _Estado; set => _Estado = value; }

        //CRUD
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec AgregarSubOpcion " + _IdOpcion + ",'" + _Nombre + "','" + _NombreFormulario + "'," + _Estado + ";";
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
                Sentencia = @"exec ModificarSubOpcion " + _IdSubOpcion + "," + _IdOpcion + ",'" + _Nombre + "','" + _NombreFormulario + "'," + _Estado + ";";
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
                Sentencia = @"exec EliminarSubOpcion " + _IdSubOpcion + ";";
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
