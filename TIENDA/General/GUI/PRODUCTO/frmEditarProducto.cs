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
        //Evento que se activara cuando se cierre el formulario y se actualicen los datos de datagrid gestion
        public event EventHandler DataUpdated;

        public frmEditarProducto()
        {
            InitializeComponent();
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            //Le digo que si el checked es flase, se muestre como nuevo proveedor
            if (checkControl.Checked != false)
            {
                btnEliminar.Visible = false;
                btnEditar.Visible = false;
                //ChecKbox

                lblVisor.Text = "NUEVO PRODUCTO";
            }
            else
            {
                // Configurar los TextBox como no editables
                txtCodigoB.ReadOnly = true;
                txtDescripcion.ReadOnly = true;
                txtPrecioUni.ReadOnly = true;
                txtPrecioVenta.ReadOnly = true;
                txtCantidad.ReadOnly = true;
                txtNombre.ReadOnly = true;
                txtMedida.ReadOnly = true;
                //Combobox
                //DateTimePicker
                dtpFechaIngreso.Enabled = false;
                dtpFechaVencimiento.Enabled = false;
                //PictureBox
                btnGuardar.Visible = false;
                btnBuscarArea.Visible = false;
                btnBuscarUnidad.Visible = false;
                //ChecKbox
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Configurar los TextBox como no editables
            txtCodigoB.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
            txtPrecioUni.ReadOnly = false;
            txtPrecioVenta.ReadOnly = false;
            txtCantidad.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtMedida.ReadOnly = false;
            //Combobox
            //DateTimePicker
            dtpFechaIngreso.Enabled = true;
            dtpFechaVencimiento.Enabled = true;
            //PictureBox
            btnGuardar.Visible = true;
            btnBuscarArea.Visible = true;
            btnBuscarUnidad.Visible = true;
            //ChecKbox

            lblVisor.Text = "MODO EDICION";
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
            prod.IdUnidadMedida = txtIdUnidad.Text;
            prod.IdArea = txtIdArea.Text;
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

        private void frmEditarProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se activa el evento declarado al principio y le notifica al frmGestion que se han actualizado los datos
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }

        private static CLS.Unidad_medida _unidad = null;
        private void btnBuscarUnidad_Click(object sender, EventArgs e)
        {
            using (var Iform = new UNIDAD_MEDIDA.frmVisorUnidadMedida())
            {
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _unidad = Iform._Unidad;
                    txtUnidadMedida.BackColor = Color.Honeydew;
                    txtIdUnidad.Text = _unidad.IdUnidadMedida;
                    txtUnidadMedida.Text = _unidad.UnidadMedida;
                }
            }
        }

        private static CLS.Area _area = null;
        private void btnBuscarArea_Click(object sender, EventArgs e)
        {
            using (var Iform = new AREA.frmVisorArea())
            {
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _area = Iform._Area;
                    txtAarea.BackColor = Color.Honeydew;
                    txtIdArea.Text = _area.IdArea;
                    txtAarea.Text = _area.Nombre;
                }
            }
        }
    }
}
