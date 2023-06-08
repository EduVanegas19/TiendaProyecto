using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.PRODUCTO
{
    public partial class frmVisorProducto : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.PRODUCTOS();
                dtgProducto.AutoGenerateColumns = false;
                dtgProducto.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        public frmVisorProducto()
        {
            InitializeComponent();
        }

        private void frmVisorProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public CLS.Producto _producto { get; set; }
        private void dtgProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dtgProducto.Columns[e.ColumnIndex].Name == "btnSeleccionar")
                {
                    _producto = new CLS.Producto()
                    {
                        IdProducto = dtgProducto.Rows[index].Cells["id_producto"].Value.ToString(),
                        Nombre = dtgProducto.Rows[index].Cells["nombre"].Value.ToString(),
                        CodigoBarras = dtgProducto.Rows[index].Cells["codigo_barras"].Value.ToString(),
                        PrecioUnidad = dtgProducto.Rows[index].Cells["precio_unidad"].Value.ToString(),
                        PrecioVenta = dtgProducto.Rows[index].Cells["precio_venta"].Value.ToString(),
                        Stock = dtgProducto.Rows[index].Cells["stock"].Value.ToString(),
                        FechaIngreso = dtgProducto.Rows[index].Cells["fecha_ingreso"].Value.ToString(),
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }
    }
}
