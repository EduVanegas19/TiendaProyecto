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
        internal Producto _Producto;

        public frmEditarProducto()
        {
            InitializeComponent();
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
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
            prod.IdUnidadMedida = cbbUnidadMedida.SelectedValue.ToString();
            prod.IdArea = cbbArea.SelectedValue.ToString();
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
    }
}
