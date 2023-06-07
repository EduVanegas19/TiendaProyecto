using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.DIRECCION
{
    public partial class frmEditarDireccion : Form
    {
        //Evento que se activara cuando se cierre el formulario y se actualicen los datos de datagrid gestion
        public event EventHandler DataUpdated;
        public frmEditarDireccion()
        {
            InitializeComponent();
        }

        private void frmEditarDireccion_Load(object sender, EventArgs e)
        {
            //Le digo que si el checked es flase, se muestre como nuevo proveedor
            if (checkControl.Checked != false)
            {
                // Configurar los TextBox como no editables
                txtId.ReadOnly = true;
                txtNumCasa.ReadOnly = false;
                txtPasaje.ReadOnly = false;
                txtCalle.ReadOnly = false;
                txtColonia.ReadOnly = false;
                txtCanton.ReadOnly = false;
                txtCaserio.ReadOnly = false;
                txtCodigoPostal.ReadOnly = false;
                txtMunicipio.ReadOnly = true;
                //Combobox
                //PictureBox
                btnEliminar.Visible = false;
                btnEditar.Visible = false;

                lblVisor.Text = "NUEVA DIRECCION";
            }
            // Y si el checked es true, entonces que se muestre como visor de lectura
            else
            {
                // Configurar los TextBox como no editables
                txtId.ReadOnly = true;
                txtNumCasa.ReadOnly = true;
                txtPasaje.ReadOnly = true;
                txtCalle.ReadOnly = true;
                txtColonia.ReadOnly = true;
                txtCanton.ReadOnly = true;
                txtCaserio.ReadOnly = true;
                txtCodigoPostal.ReadOnly = true;
                txtMunicipio.ReadOnly = true;
                //Combobox
                //PictureBox
                btnGuardar.Visible = false;
                btnEliminar.Visible = false;
                //ChecKbox
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Configurar los TextBox como no editables
            txtId.ReadOnly = true;
            txtNumCasa.ReadOnly = false;
            txtPasaje.ReadOnly = false;
            txtCalle.ReadOnly = false;
            txtColonia.ReadOnly = false;
            txtCanton.ReadOnly = false;
            txtCaserio.ReadOnly = false;
            txtCodigoPostal.ReadOnly = false;
            txtMunicipio.ReadOnly = true;
            //Combobox
            //PictureBox
            btnGuardar.Visible = true;
            btnEliminar.Visible = true;

            lblVisor.Text = "MODO EDICION";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Direccion direc = new CLS.Direccion();
            //Sincronizar la entidad con la interfaz
            int estado = 1;
            direc.IdDireccion = txtId.Text;
            direc.NumeroCasa = txtNumCasa.Text;
            direc.PasajePoligono = txtPasaje.Text;
            direc.Calle = txtCalle.Text;
            direc.Colonia = txtColonia.Text;
            direc.Canton = txtCanton.Text;
            direc.Caserio = txtCaserio.Text;
            direc.CodigoPostal = txtCodigoPostal.Text;
            direc.IdMunicipio = txtMunicipio.Text;
            direc.Estado = estado.ToString();
            //Identificar la accion a realizar
            if (txtId.TextLength > 0)
            {
                //Realizar la operacion de actualizar
                if (direc.Actualizar())
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
                if (direc.Insertar())
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

        private void frmEditarDireccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se activa el evento declarado al principio y le notifica al frmGestion que se han actualizado los datos
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    txtMunicipio.Text = _Municipio.IdMunicipio;
                }
            }
        }
    }
}
