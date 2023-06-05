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
    public partial class frmGestionDireccion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.DIRECCIONES();
                dtgDireccion.AutoGenerateColumns = false;
                dtgDireccion.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        public frmGestionDireccion()
        {
            InitializeComponent();
        }

        private void frmGestionDireccion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DIRECCION.frmEditarDireccion f = new DIRECCION.frmEditarDireccion();
                f.txtId.Text = dtgDireccion.CurrentRow.Cells["id_direccion"].Value.ToString();
                f.txtNumCasa.Text = dtgDireccion.CurrentRow.Cells["numero_casa"].Value.ToString();
                f.txtPasaje.Text = dtgDireccion.CurrentRow.Cells["pasaje_poligono"].Value.ToString();
                f.txtCalle.Text = dtgDireccion.CurrentRow.Cells["calle"].Value.ToString();
                f.txtColonia.Text = dtgDireccion.CurrentRow.Cells["colonia"].Value.ToString();
                f.txtCanton.Text = dtgDireccion.CurrentRow.Cells["canton"].Value.ToString();
                f.txtCaserio.Text = dtgDireccion.CurrentRow.Cells["caserio"].Value.ToString();
                f.txtCodigoPostal.Text = dtgDireccion.CurrentRow.Cells["codigo_postal"].Value.ToString();
                f.cbbMunicipio.Text = dtgDireccion.CurrentRow.Cells["id_municipio"].Value.ToString();
                f.checkEstado.Checked = Convert.ToBoolean(dtgDireccion.CurrentRow.Cells["estado"].Value.ToString());
                f.ShowDialog();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DIRECCION.frmEditarDireccion f = new DIRECCION.frmEditarDireccion();
            f.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Direccion direccion = new CLS.Direccion();
                direccion.IdDireccion = dtgDireccion.CurrentRow.Cells["id_direccion"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (direccion.Eliminar())
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

        private void dtgDireccion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DIRECCION.frmEditarDireccion f = new DIRECCION.frmEditarDireccion();
                f.txtId.Text = dtgDireccion.CurrentRow.Cells["id_direccion"].Value.ToString();
                f.txtNumCasa.Text = dtgDireccion.CurrentRow.Cells["numero_casa"].Value.ToString();
                f.txtPasaje.Text = dtgDireccion.CurrentRow.Cells["pasaje_poligono"].Value.ToString();
                f.txtCalle.Text = dtgDireccion.CurrentRow.Cells["calle"].Value.ToString();
                f.txtColonia.Text = dtgDireccion.CurrentRow.Cells["colonia"].Value.ToString();
                f.txtCanton.Text = dtgDireccion.CurrentRow.Cells["canton"].Value.ToString();
                f.txtCaserio.Text = dtgDireccion.CurrentRow.Cells["caserio"].Value.ToString();
                f.txtCodigoPostal.Text = dtgDireccion.CurrentRow.Cells["codigo_postal"].Value.ToString();
                f.cbbMunicipio.Text = dtgDireccion.CurrentRow.Cells["id_municipio"].Value.ToString();
                f.checkEstado.Checked = Convert.ToBoolean(dtgDireccion.CurrentRow.Cells["estado"].Value.ToString());
                f.ShowDialog();
            }
        }
    }
}
