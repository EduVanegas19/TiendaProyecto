using General.CLS;
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

        private void CargarMedida()
        {
            DataTable Medida = new DataTable();
            //String pIDRol = cbbRoles.SelectedValue.ToString();
            try
            {
                Medida = DataManager.DBConsultas.UNIDAD_MEDIDA();
                cbbUnidadMedida.DataSource = Medida;
                cbbUnidadMedida.DisplayMember = "unidad_medida";
                cbbUnidadMedida.ValueMember = "id_unidadmedida";
            }
            catch (Exception)
            {

            }
        }
        private void CargarArea()
        {
            DataTable area = new DataTable();
            try
            {
                area = DataManager.DBConsultas.AREAS();
                cbbArea.DataSource = area;
                cbbArea.DisplayMember = "area";
                cbbArea.ValueMember = "id_area";
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
            CargarArea();
            CargarMedida();
            //Le digo que si el checked es flase, se muestre como nuevo proveedor
            if (checkControl.Checked != false)
            {
                // Configurar los TextBox como no editables
                txtId.ReadOnly = true;
                txtCodigoB.ReadOnly = false;
                txtDescripcion.ReadOnly = false;
                txtPrecioUni.ReadOnly = false;
                txtPrecioVenta.ReadOnly = false;
                txtCantidad.ReadOnly = false;
                txtNombre.ReadOnly = false;
                txtMedida.ReadOnly = false;
                //Combobox
                cbbUnidadMedida.Enabled = true;
                cbbArea.Enabled = true;
                //DateTimePicker
                dtpFechaIngreso.Enabled = true;
                dtpFechaVencimiento.Enabled = true;
                //PictureBox
                btnGuardar.Visible = true;
                btnEliminar.Visible = false;
                btnEditar.Visible = false;
                //ChecKbox

                lblVisor.Text = "NUEVO PRODUCTO";
            }
            else
            {
                // Configurar los TextBox como no editables
                txtId.ReadOnly = true;
                txtCodigoB.ReadOnly = true;
                txtDescripcion.ReadOnly = true;
                txtPrecioUni.ReadOnly = true;
                txtPrecioVenta.ReadOnly = true;
                txtCantidad.ReadOnly = true;
                txtNombre.ReadOnly = true;
                txtMedida.ReadOnly = true;
                //Combobox
                cbbUnidadMedida.Enabled = false;
                cbbArea.Enabled = false;
                //DateTimePicker
                dtpFechaIngreso.Enabled = false;
                dtpFechaVencimiento.Enabled = false;
                //PictureBox
                btnGuardar.Visible = false;
                btnEliminar.Visible = false;
                //ChecKbox
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Configurar los TextBox como no editables
            txtId.ReadOnly = false;
            txtCodigoB.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
            txtPrecioUni.ReadOnly = false;
            txtPrecioVenta.ReadOnly = false;
            txtCantidad.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtMedida.ReadOnly = false;
            //Combobox
            cbbUnidadMedida.Enabled = true;
            cbbArea.Enabled = true;
            //DateTimePicker
            dtpFechaIngreso.Enabled = true;
            dtpFechaVencimiento.Enabled = true;
            //PictureBox
            btnGuardar.Visible = true;
            btnEliminar.Visible = true;
            //ChecKbox
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int medida = cbbUnidadMedida.SelectedIndex + 1;
            int area = cbbArea.SelectedIndex + 1;
            //Creacion del objeto entidad
            CLS.Producto prod = new CLS.Producto();
            //Sincronizar la entidad con la interfaz
            prod.IdProducto = txtId.Text;
            prod.CodigoBarras = txtCodigoB.Text;
            prod.Descripcion = txtDescripcion.Text;
            prod.PrecioUnidad = txtPrecioUni.Text;
            prod.PrecioVenta = txtPrecioVenta.Text;
            prod.Stock = txtCantidad.Text;
            prod.Nombre = txtNombre.Text;
            prod.FechaIngreso = dtpFechaIngreso.Text;
            prod.FechaVencimiento = dtpFechaVencimiento.Text;
            prod.Medida = txtMedida.Text;
            prod.IdUnidadMedida = area.ToString();
            prod.IdArea = area.ToString();
            //Identificar la accion a realizar
            if (txtId.TextLength > 0)
            {
                //Realizar la operacion de actualizar
                if (prod.Actualizar())
                {
                    MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue actualizado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Realizar la operacion de insertar
                if (prod.Insertar())
                {
                    MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue insertado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Producto producto = new CLS.Producto();
                producto.IdProducto = txtId.Text;
                //Realizar la operacion de Eliminar
                if (producto.Eliminar())
                {
                    MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue eliminado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
