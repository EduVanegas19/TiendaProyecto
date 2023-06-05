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
        public frmEditarDireccion()
        {
            InitializeComponent();
        }

        private void frmEditarDireccion_Load(object sender, EventArgs e)
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
            //Combobox
            cbbMunicipio.Enabled = false;
            //PictureBox
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            //ChecKbox
            checkEstado.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Configurar los TextBox como no editables
            txtId.ReadOnly = false;
            txtNumCasa.ReadOnly = false;
            txtPasaje.ReadOnly = false;
            txtCalle.ReadOnly = false;
            txtColonia.ReadOnly = false;
            txtCanton.ReadOnly = false;
            txtCaserio.ReadOnly = false;
            txtCodigoPostal.ReadOnly = false;
            //Combobox
            cbbMunicipio.Enabled = true;
            //PictureBox
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            //ChecKbox
            checkEstado.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Direccion direc = new CLS.Direccion();
            //Sincronizar la entidad con la interfaz
            direc.IdDireccion = txtId.Text;
            direc.NumeroCasa = txtNumCasa.Text;
            direc.PasajePoligono = txtPasaje.Text;
            direc.Calle = txtCalle.Text;
            direc.Colonia = txtColonia.Text;
            direc.Canton = txtCanton.Text;
            direc.Caserio = txtCaserio.Text;
            direc.CodigoPostal = txtCodigoPostal.Text;
            direc.Estado = checkEstado.Checked.ToString();
            direc.IdMunicipio = cbbMunicipio.SelectedValue.ToString();
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
    }
}
