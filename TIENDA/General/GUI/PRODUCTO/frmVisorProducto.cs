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
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBuscar.Text.ToLower();

            // Deshabilitar el administrador de divisas
            dtgProducto.BindingContext[dtgProducto.DataSource].SuspendBinding();

            // Filtra los datos en la columna 'nombre' de manera flexible
            foreach (DataGridViewRow row in dtgProducto.Rows)
            {
                bool isVisible = false;

                DataGridViewCell nameCell = row.Cells["nombre"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell codeCell = row.Cells["codigo_barras"]; // Ajusta el nombre de la columna según tu caso

                if (nameCell != null && nameCell.Value != null && codeCell != null && codeCell.Value != null)
                {
                    string nameCellValue = nameCell.Value.ToString().ToLower();
                    string codeCellValue = codeCell.Value.ToString().ToLower();

                    if (nameCellValue.Contains(searchText) || codeCellValue.Contains(searchText))
                    {
                        isVisible = true;
                    }
                }

                row.Visible = isVisible;
            }

            // Habilitar el administrador de divisas
            dtgProducto.BindingContext[dtgProducto.DataSource].ResumeBinding();
        }

    }
}
