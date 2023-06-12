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
        //Le decimos que cargue datos despues de cerrar el frmEditor
        private void FormEditor_DataUpdated(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            DataTable direcciones = new DataTable();
            int pId = 2;
            try
            {
                direcciones = DataManager.DBConsultas.LISTARDIRECCIONOPCION(pId);
                dtgDireccion.AutoGenerateColumns = false;
                dtgDireccion.DataSource = direcciones;
            }
            catch (Exception)
            {

            }
        }
        private void CargarOrden()
        {
            DataTable direcciones = new DataTable();
            //le digo que dependiendo de la opcion que se seleccione se muestre en orden correspondiente
            int pId = cbbOrdenar.SelectedIndex + 1;
            try
            {
                direcciones = DataManager.DBConsultas.LISTARDIRECCIONOPCION(pId);
                dtgDireccion.AutoGenerateColumns = false;
                dtgDireccion.DataSource = direcciones;
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
                //establecemos el tipo de check para saber que opciones mostrar
                f.checkControl.Checked = false;
                //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
                f.DataUpdated += FormEditor_DataUpdated;
                f.ShowDialog();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DIRECCION.frmEditarDireccion f = new DIRECCION.frmEditarDireccion();
            //establecemos el tipo de check para saber que opciones mostrar
            f.checkControl.Checked = true;
            //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
            f.DataUpdated += FormEditor_DataUpdated;
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
                //establecemos el tipo de check para saber que opciones mostrar
                f.checkControl.Checked = false;
                //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
                f.DataUpdated += FormEditor_DataUpdated;
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
                DataGridViewCell mun = row.Cells["municipio"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell dep = row.Cells["departamento"]; // Ajusta el nombre de la columna según tu caso

                if (canton != null && canton.Value != null && colonia != null && colonia.Value != null && mun != null && mun.Value != null && dep != null && dep.Value != null)
                {
                    string cantonCellValue = canton.Value.ToString().ToLower();
                    string coloniaCellValue = colonia.Value.ToString().ToLower();
                    string munCellValue = canton.Value.ToString().ToLower();
                    string depCellValue = colonia.Value.ToString().ToLower();

                    if (cantonCellValue.Contains(searchText) || coloniaCellValue.Contains(searchText) || munCellValue.Contains(searchText) || depCellValue.Contains(searchText))
                    {
                        isVisible = true;
                    }
                }

                row.Visible = isVisible;
            }

            // Habilitar el administrador de divisas
            dtgDireccion.BindingContext[dtgDireccion.DataSource].ResumeBinding();
        }

        private void cbbOrdenar_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarOrden();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
