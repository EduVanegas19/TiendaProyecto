using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.CLIENTES
{
    public partial class frmEditarCliente : Form
    {
        //Evento que se activara cuando se cierre el formulario y se actualicen los datos de datagrid gestion
        public event EventHandler DataUpdated;
        public frmEditarCliente()
        {
            InitializeComponent();
        }


        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            //Le digo que si el checked es flase, se muestre como nuevo proveedor
            if (checkControl.Checked != false)
            {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;

                lblVisor.Text = "NUEVO CLIENTE";
            }
            else
            {
                // Configurar los TextBox como no editables
                txtIdenficacion.ReadOnly = true;
                txtNombre.ReadOnly = true;
                txtCredito.ReadOnly = true;
                txtNumCasa.ReadOnly = true;
                txtPasaje.ReadOnly = true;
                txtCalle.ReadOnly = true;
                txtColonia.ReadOnly = true;
                txtCanton.ReadOnly = true;
                txtCaserio.ReadOnly = true;
                txtCodigoPostal.ReadOnly = true;
                //Combobox
                //DateTimePicker
                //PictureBox
                btnGuardar.Visible = false;
                //ChecKbox
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Cliente clien = new CLS.Cliente();
                clien.IdCliente = txtIdClient.Text ;
                //Realizar la operacion de Eliminar
                if (clien.Eliminar())
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

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Configurar los TextBox como no editables
            txtIdenficacion.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtCredito.ReadOnly = false;
            txtNumCasa.ReadOnly = false;
            txtPasaje.ReadOnly = false;
            txtCalle.ReadOnly = false;
            txtColonia.ReadOnly = false;
            txtCanton.ReadOnly = false;
            txtCaserio.ReadOnly = false;
            txtCodigoPostal.ReadOnly = false;
            //Combobox
            //DateTimePicker
            //PictureBox
            btnGuardar.Visible = true;
            //ChecKbox

            lblVisor.Text = "MODO EDICION";
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Cliente cli = new CLS.Cliente();
            //Sincronizar la entidad con la interfaz
            cli.IdCliente = txtIdClient.Text;
            cli.Identificacion = txtIdenficacion.Text;
            cli.Nombre = txtNombre.Text;
            cli.Credito = txtCredito.Text;
            cli.NumeroCasa = txtNumCasa.Text;
            cli.PasajePoligono = txtPasaje.Text;
            cli.Calle = txtCalle.Text;
            cli.Colonia = txtColonia.Text;
            cli.Canton = txtCanton.Text;
            cli.Caserio = txtCaserio.Text;
            cli.CodigoPostal = txtCodigoPostal.Text;
            cli.IdMunicipio = txtIdMunicipio.Text;
            cli.IdDireccion = txtIdDirec.Text;
            //Identificar la accion a realizar
            if (txtIdClient.TextLength > 0)
            {
                //Realizar la operacion de actualizar
                if (cli.Actualizar())
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
                if (cli.Insertar())
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

        private void cbbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private static CLS.Municipio _Municipio = null;
        private void btnBuscar_Click(object sender, EventArgs e)
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

        private void frmEditarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se activa el evento declarado al principio y le notifica al frmGestion que se han actualizado los datos
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
