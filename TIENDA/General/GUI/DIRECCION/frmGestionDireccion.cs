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
            lblUsuario.Text = Session.Instancia.usuario;
            lblRol.Text = Session.Instancia.rol;
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
                f.txtMunicipio.Text = dtgDireccion.CurrentRow.Cells["id_municipio"].Value.ToString();
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
                f.txtMunicipio.Text = dtgDireccion.CurrentRow.Cells["id_municipio"].Value.ToString();
                f.ShowDialog();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBuscar.Text.ToLower();

            // Deshabilitar el administrador de divisas
            dtgDireccion.BindingContext[dtgDireccion.DataSource].SuspendBinding();

            // Filtra los datos en la columna 'nombre' de manera flexible
            foreach (DataGridViewRow row in dtgDireccion.Rows)
            {
                bool isVisible = false;

                DataGridViewCell canton = row.Cells["canton"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell colonia = row.Cells["colonia"]; // Ajusta el nombre de la columna según tu caso

                if (canton != null && canton.Value != null && colonia != null && colonia.Value != null)
                {
                    string nameCellValue = canton.Value.ToString().ToLower();
                    string codeCellValue = colonia.Value.ToString().ToLower();

                    if (nameCellValue.Contains(searchText) || codeCellValue.Contains(searchText))
                    {
                        isVisible = true;
                    }
                }

                row.Visible = isVisible;
            }

            // Habilitar el administrador de divisas
            dtgDireccion.BindingContext[dtgDireccion.DataSource].ResumeBinding();
        }
    }
}
