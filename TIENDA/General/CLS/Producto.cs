using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Producto
    {
        String _IdProducto;
        String _CodigoBarras;
        String _Descripcion;
        String _PrecioUnidad;
        String _PrecioVenta;
        String _Stock;
        String _Nombre;
        String _FechaIngreso;
        String _FechaVencimiento;
        String _Medida;
        String _Estado;
        String _IdUnidadMedida;
        String _IdArea;

        public string IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public string CodigoBarras { get => _CodigoBarras; set => _CodigoBarras = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string PrecioUnidad { get => _PrecioUnidad; set => _PrecioUnidad = value; }
        public string PrecioVenta { get => _PrecioVenta; set => _PrecioVenta = value; }
        public string Stock { get => _Stock; set => _Stock = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string FechaIngreso { get => _FechaIngreso; set => _FechaIngreso = value; }
        public string FechaVencimiento { get => _FechaVencimiento; set => _FechaVencimiento = value; }
        public string Medida { get => _Medida; set => _Medida = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string IdUnidadMedida { get => _IdUnidadMedida; set => _IdUnidadMedida = value; }
        public string IdArea { get => _IdArea; set => _IdArea = value; }


        //public Int64 IdProducto { get; set; }

        //public string CodigoBarras { get; set; }

        //public string Descripcion { get; set; }

        //public string PrecioUnidad { get; set; }

        //public string PrecioVenta { get; set; }

        //public int Stock { get; set; }

        //public string Nombre { get; set; }

        //public string FechaIngreso { get; set; }

        //public string FechaVencimiento { get; set; }

        //public string Medida { get; set; }

        //public bool Estado { get; set; }

        //public Int64 IdUnidadMedida { get; set; }

        //public Int64 IdArea { get; set; }

        //public Unidad_medida Unidad_medida { get; set; }

        //public Area Area { get; set; }

        //private static Producto _instancia = null;

        //CRUD
        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"exec AGREGARPRODUCTO '" + _CodigoBarras + "', '" + _Descripcion + "', " + _PrecioUnidad + ", " + _PrecioVenta + ", " + _Stock + ",'" + _Nombre + "', '" + _FechaIngreso + "','" + _FechaVencimiento + "', " + _Medida + ", " + _Estado + ", " + _IdUnidadMedida + ", " + _IdArea + ";";
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
                Sentencia = @"exec ModificarProducto " + _IdProducto + ", '" + _CodigoBarras + "', '" + _Descripcion + "', " + _PrecioUnidad + ", " + _PrecioVenta + ", " + _Stock + ",'" + _Nombre + "', '" + _FechaIngreso + "','" + _FechaVencimiento + "', " + _Medida + ", " + _Estado + ", " + _IdUnidadMedida + ", " + _IdArea + ";";
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
                Sentencia = @"exec ELIMINARPRODUCTO " + _IdProducto + ";";
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
