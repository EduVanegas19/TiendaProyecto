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
    public partial class frmEditarProducto : Form
    {
        BindingSource _DATOS = new BindingSource();
        public CLS.Producto _Producto { get; set; }
        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.PRODUCTOS();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        public frmEditarProducto()
        {
            InitializeComponent();
        }


        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //DETALLE_VENTA.frmGestionDetalleVenta f = new DETALLE_VENTA.frmGestionDetalleVenta();
            //string id = dataGridView1.CurrentRow.Cells["id_producto"].Value.ToString();
            //string nombre = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            //string precio = dataGridView1.CurrentRow.Cells["precio_venta"].Value.ToString();
            //string estado = dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
            //f.GuardarDatosTemporales();

            //// Mostrar el formulario padre si no está visible
            //f.Show();

            //// Llamar al método del formulario padre para actualizar los datos
            //f.ActualizarDatosProducto(id, estado, nombre, precio);

            //// Restaurar datos temporales del DataGridView después de que se cierre el formulario padre
            //f.RestaurarDatosTemporales();

            //this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnSeleccionar")
                {
                    _Producto = new CLS.Producto()
                    {
                        IdProducto = Convert.ToInt32(dataGridView1.Rows[index].Cells["id_producto"].Value.ToString()),
                        Nombre = dataGridView1.Rows[index].Cells["nombre"].Value.ToString(),
                        PrecioVenta = dataGridView1.Rows[index].Cells["precio_venta"].Value.ToString(),
                        Stock = Convert.ToInt32(dataGridView1.Rows[index].Cells["stock"].Value.ToString()),
                        Estado = Convert.ToBoolean(dataGridView1.Rows[index].Cells["estado"].Value.ToString()),
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
