using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.EMPLEADO
{
    public partial class frmEditarEmpleado : Form
    {
        //Evento que se activara cuando se cierre el formulario y se actualicen los datos de datagrid gestion
        public event EventHandler DataUpdated;
        public frmEditarEmpleado()
        {
            InitializeComponent();
        }

        private void frmEditarEmpleado_Load(object sender, EventArgs e)
        {
            //Le digo que si el checked es flase, se muestre como nuevo proveedor
            if (checkControl.Checked != false)
            {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;

                lblVisor.Text = "NUEVO EMPLEADO";
            }
            else
            {
                // Configurar los TextBox como no editables
                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = true;
                txtGenero.ReadOnly = true;
                txtTelefono.ReadOnly = true;
                txtCorreo.ReadOnly = true;
                txtDUI.ReadOnly = true;

                txtNumeroCasa.ReadOnly = true;
                txtPasaje.ReadOnly = true;
                txtCalle.ReadOnly = true;
                txtColonia.ReadOnly = true;
                txtCanton.ReadOnly = true;
                txtCaserio.ReadOnly = true;
                txtCodigoPostal.ReadOnly = true;
                //Combobox
                //DateTimePicker
                dtpFecha.Enabled = false;
                //PictureBox
                btnGuardar.Visible = false;
                //ChecKbox
            }
        }

        private void frmEditarEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se activa el evento declarado al principio y le notifica al frmGestion que se han actualizado los datos
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Empleado emp = new CLS.Empleado();
                emp.IdEmpleado = txtIdEmpleado.Text;
                //Realizar la operacion de Eliminar
                if (emp.Eliminar())
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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            // Configurar los TextBox como no editables
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtGenero.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtCorreo.ReadOnly = false;
            txtDUI.ReadOnly = false;

            txtNumeroCasa.ReadOnly = false;
            txtPasaje.ReadOnly = false;
            txtCalle.ReadOnly = false;
            txtColonia.ReadOnly = false;
            txtCanton.ReadOnly = false;
            txtCaserio.ReadOnly = false;
            txtCodigoPostal.ReadOnly = false;
            //Combobox
            //DateTimePicker
            dtpFecha.Enabled = true;
            //PictureBox
            btnGuardar.Visible = true;
            //ChecKbox

            lblVisor.Text = "MODO EDICION";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Empleado emp = new CLS.Empleado();
            //Sincronizar la entidad con la interfaz
            emp.IdEmpleado = txtIdEmpleado.Text;
            emp.Apellido = txtApellido.Text;
            emp.Nombre = txtNombre.Text;
            emp.Genero = txtGenero.Text;
            emp.Telefono = txtTelefono.Text;
            emp.Correo = txtCorreo.Text;
            emp.DUI = txtDUI.Text;
            emp.FechaNac = dtpFecha.Text;
            emp.NumeroCasa = txtNumeroCasa.Text;
            emp.PasajePoligono = txtPasaje.Text;
            emp.Calle = txtCalle.Text;
            emp.Colonia = txtColonia.Text;
            emp.Canton = txtCanton.Text;
            emp.Caserio = txtCaserio.Text;
            emp.CodigoPostal = txtCodigoPostal.Text;
            emp.IdMunicipio = txtIdMunicipio.Text;
            //Identificar la accion a realizar
            if (txtIdEmpleado.TextLength > 0)
            {
                //Realizar la operacion de actualizar
                if (emp.Actualizar())
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
                if (emp.Insertar())
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

        private static CLS.Municipio _Municipio = null;
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            using (var Iform = new MUNICIPIO.frmVisorMunicipio())
            {
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _Municipio = Iform._Municipio;
                    txtMunicipio.BackColor = Color.Honeydew;
                    txtIdMunicipio.Text = _Municipio.IdMunicipio;
                    txtMunicipio.Text = _Municipio.Nombre;
                }
            }
        }
    }
}
