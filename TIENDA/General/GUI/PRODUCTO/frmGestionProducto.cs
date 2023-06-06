using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SessionManager;

namespace General.GUI.PRODUCTO
{
    public partial class frmGestionProducto : Form
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
        public frmGestionProducto()
        {
            InitializeComponent();
        }

        private void frmGestionProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
            lblUsuario.Text = Session.Instancia.usuario;
            lblRol.Text = Session.Instancia.rol;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PRODUCTO.frmEditarProducto f = new PRODUCTO.frmEditarProducto();
                f.txtId.Text = dtgProducto.CurrentRow.Cells["id_producto"].Value.ToString();
                f.txtCodigoB.Text = dtgProducto.CurrentRow.Cells["codigo_barras"].Value.ToString();
                f.txtDescripcion.Text = dtgProducto.CurrentRow.Cells["descripcion"].Value.ToString();
                f.txtPrecioUni.Text = dtgProducto.CurrentRow.Cells["precio_unidad"].Value.ToString();
                f.txtPrecioVenta.Text = dtgProducto.CurrentRow.Cells["precio_venta"].Value.ToString();
                f.txtCantidad.Text = dtgProducto.CurrentRow.Cells["stock"].Value.ToString();
                f.txtNombre.Text = dtgProducto.CurrentRow.Cells["nombre"].Value.ToString();
                f.dtpFechaIngreso.Text = dtgProducto.CurrentRow.Cells["fecha_ingreso"].Value.ToString();
                f.dtpFechaVencimiento.Text = dtgProducto.CurrentRow.Cells["fecha_vencimiento"].Value.ToString();
                f.cbbUnidadMedida.Text = dtgProducto.CurrentRow.Cells["id_unidadmedida"].Value.ToString();
                f.cbbArea.Text = dtgProducto.CurrentRow.Cells["id_area"].Value.ToString();
                f.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Producto producto = new CLS.Producto();
                producto.IdProducto = dtgProducto.CurrentRow.Cells["id_producto"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (producto.Eliminar())
                {
                    MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue eliminado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PRODUCTO.frmEditarProducto f = new PRODUCTO.frmEditarProducto();
            f.ShowDialog();
        }

        private void dtgProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PRODUCTO.frmEditarProducto f = new PRODUCTO.frmEditarProducto();
                f.txtId.Text = dtgProducto.CurrentRow.Cells["id_producto"].Value.ToString();
                f.txtCodigoB.Text = dtgProducto.CurrentRow.Cells["codigo_barras"].Value.ToString();
                f.txtDescripcion.Text = dtgProducto.CurrentRow.Cells["descripcion"].Value.ToString();
                f.txtPrecioUni.Text = dtgProducto.CurrentRow.Cells["precio_unidad"].Value.ToString();
                f.txtPrecioVenta.Text = dtgProducto.CurrentRow.Cells["precio_venta"].Value.ToString();
                f.txtCantidad.Text = dtgProducto.CurrentRow.Cells["stock"].Value.ToString();
                f.txtNombre.Text = dtgProducto.CurrentRow.Cells["nombre"].Value.ToString();
                f.dtpFechaIngreso.Text = dtgProducto.CurrentRow.Cells["fecha_ingreso"].Value.ToString();
                f.dtpFechaVencimiento.Text = dtgProducto.CurrentRow.Cells["fecha_vencimiento"].Value.ToString();
                f.cbbUnidadMedida.Text = dtgProducto.CurrentRow.Cells["id_unidadmedida"].Value.ToString();
                f.cbbArea.Text = dtgProducto.CurrentRow.Cells["id_area"].Value.ToString();
                f.ShowDialog();
            }
        }
    }
}
