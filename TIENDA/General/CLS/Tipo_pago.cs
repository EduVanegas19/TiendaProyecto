using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Tipo_pago
    {
        String _IdTipoPago;
        String _TipoPago;

        public string IdTipoPago { get => _IdTipoPago; set => _IdTipoPago = value; }
        public string TipoPago { get => _TipoPago; set => _TipoPago = value; }

        //CRUD
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec AgregarTipoPago '" + _TipoPago + "';";
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
                Sentencia = @"exec ModificarTipoPago " + _IdTipoPago + ",'" + _TipoPago + ";";
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
                Sentencia = @"exec EliminarTipoPago " + _TipoPago + ";";
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
