using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TIENDA.CLS
{
    public class Producto
    {
        public Int64 IdProducto { get; set; }

        public string CodigoBarras { get; set; }

        public string Descripcion { get; set; }

        public string PrecioUnidad { get; set; }

        public string PrecioVenta { get; set; }

        public int Stock { get; set; }

        public string Nombre { get; set; }

        public string FechaIngreso { get; set; }

        public string FechaVencimiento { get; set; }

        public string Medida { get; set; }

        public bool Estado { get; set; }

        public Int64 IdUnidadMedida { get; set; }

        public Int64 IdArea { get; set; }

        public Unidad_medida Unidad_medida { get; set; }

        public Area Area { get; set; }

        private static Producto _instancia = null;

        public Producto()
        {

        }

        public static Producto Instancia
        {
            get
            {
                if (_instancia == null) _instancia = new Producto();
                return _instancia;
            }
        }

        //public List<Producto> Listar(out string mensaje)
        //{
        //    mensaje = string.Empty;
        //    List<Producto> oLista = new List<Producto>();

        //    try
        //    {
        //        using (SqlConnection conexion = new SqlConnection(DataManager.DBConexion))
        //    }
        //}
        

    }
}
