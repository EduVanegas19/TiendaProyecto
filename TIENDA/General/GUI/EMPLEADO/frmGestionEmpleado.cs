using SessionManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class frmGestionEmpleado : Form
    {
        //Le decimos que cargue datos despues de cerrar el frmEditor
        private void FormEditor_DataUpdated(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            DataTable empleados = new DataTable();
            int pId = 1;
            try
            {
                empleados = DataManager.DBConsultas.LISTAREMPLEADOOPCION(pId);
                dtgEmpleado.AutoGenerateColumns = false;
                dtgEmpleado.DataSource = empleados;
            }
            catch (Exception)
            {

            }
        }
        private void CargarOrden()
        {
            DataTable empleados = new DataTable();
            //le digo que dependiendo de la opcion que se seleccione se muestre en orden correspondiente
            int pId = cbbOrdenar.SelectedIndex + 1;
            try
            {
                empleados = DataManager.DBConsultas.LISTAREMPLEADOOPCION(pId);
                dtgEmpleado.AutoGenerateColumns = false;
                dtgEmpleado.DataSource = empleados;
            }
            catch (Exception)
            {

            }
        }
        public frmGestionEmpleado()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGestionEmpleado_Load(object sender, EventArgs e)
        {
            CargarDatos();

            lblUsuario.Text = Session.Instancia.usuario;
            lblRol.Text = Session.Instancia.rol;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Empleado emp = new CLS.Empleado();
                emp.IdEmpleado = dtgEmpleado.CurrentRow.Cells["id_empleado"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (emp.Eliminar())
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

        private void cbbOrdenar_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarOrden();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBuscar.Text.ToLower();

            // Deshabilitar el administrador de divisas
            dtgEmpleado.BindingContext[dtgEmpleado.DataSource].SuspendBinding();

            // Filtra los datos en la columna 'nombre' de manera flexible
            foreach (DataGridViewRow row in dtgEmpleado.Rows)
            {
                bool isVisible = false;

                DataGridViewCell nameCell = row.Cells["nombre"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell codeCell = row.Cells["municipio"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell apellido = row.Cells["apellido"]; // Ajusta el nombre de la columna según tu caso

                if (nameCell != null && nameCell.Value != null && codeCell != null && codeCell.Value != null && apellido != null && apellido.Value != null)
                {
                    string nameCellValue = nameCell.Value.ToString().ToLower();
                    string codeCellValue = codeCell.Value.ToString().ToLower();
                    string apellidoValue = apellido.Value.ToString().ToLower();

                    if (nameCellValue.Contains(searchText) || codeCellValue.Contains(searchText) || apellidoValue.Contains(searchText))
                    {
                        isVisible = true;
                    }
                }

                row.Visible = isVisible;
            }

            // Habilitar el administrador de divisas
            dtgEmpleado.BindingContext[dtgEmpleado.DataSource].ResumeBinding();
        }

        private void dtgEmpleado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EMPLEADO.frmEditarEmpleado f = new EMPLEADO.frmEditarEmpleado();
                f.txtIdEmpleado.Text = dtgEmpleado.CurrentRow.Cells["id_empleado"].Value.ToString();
                f.txtNombre.Text = dtgEmpleado.CurrentRow.Cells["nombre"].Value.ToString();
                f.txtApellido.Text = dtgEmpleado.CurrentRow.Cells["apellido"].Value.ToString();
                f.txtGenero.Text = dtgEmpleado.CurrentRow.Cells["genero"].Value.ToString();
                f.txtTelefono.Text = dtgEmpleado.CurrentRow.Cells["telefono"].Value.ToString();
                f.txtCorreo.Text = dtgEmpleado.CurrentRow.Cells["correo"].Value.ToString();
                f.txtDUI.Text = dtgEmpleado.CurrentRow.Cells["DUI"].Value.ToString();
                f.dtpFecha.Text = dtgEmpleado.CurrentRow.Cells["fechanac"].Value.ToString();

                f.txtNumeroCasa.Text = dtgEmpleado.CurrentRow.Cells["numero_casa"].Value.ToString();
                f.txtPasaje.Text = dtgEmpleado.CurrentRow.Cells["pasaje_poligono"].Value.ToString();
                f.txtCalle.Text = dtgEmpleado.CurrentRow.Cells["calle"].Value.ToString();
                f.txtColonia.Text = dtgEmpleado.CurrentRow.Cells["colonia"].Value.ToString();
                f.txtCanton.Text = dtgEmpleado.CurrentRow.Cells["canton"].Value.ToString();
                f.txtCaserio.Text = dtgEmpleado.CurrentRow.Cells["caserio"].Value.ToString();
                f.txtCodigoPostal.Text = dtgEmpleado.CurrentRow.Cells["codigo_postal"].Value.ToString();
                f.txtIdMunicipio.Text = dtgEmpleado.CurrentRow.Cells["id_municipio"].Value.ToString();
                f.txtMunicipio.Text = dtgEmpleado.CurrentRow.Cells["municipio"].Value.ToString();
                f.checkControl.Checked = false;
                //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
                f.DataUpdated += FormEditor_DataUpdated;
                f.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EMPLEADO.frmEditarEmpleado f = new EMPLEADO.frmEditarEmpleado();
                f.txtIdEmpleado.Text = dtgEmpleado.CurrentRow.Cells["id_empleado"].Value.ToString();
                f.txtNombre.Text = dtgEmpleado.CurrentRow.Cells["nombre"].Value.ToString();
                f.txtApellido.Text = dtgEmpleado.CurrentRow.Cells["apellido"].Value.ToString();
                f.txtGenero.Text = dtgEmpleado.CurrentRow.Cells["genero"].Value.ToString();
                f.txtTelefono.Text = dtgEmpleado.CurrentRow.Cells["telefono"].Value.ToString();
                f.txtCorreo.Text = dtgEmpleado.CurrentRow.Cells["correo"].Value.ToString();
                f.txtDUI.Text = dtgEmpleado.CurrentRow.Cells["DUI"].Value.ToString();
                f.dtpFecha.Text = dtgEmpleado.CurrentRow.Cells["fechanac"].Value.ToString();

                f.txtNumeroCasa.Text = dtgEmpleado.CurrentRow.Cells["numero_casa"].Value.ToString();
                f.txtPasaje.Text = dtgEmpleado.CurrentRow.Cells["pasaje_poligono"].Value.ToString();
                f.txtCalle.Text = dtgEmpleado.CurrentRow.Cells["calle"].Value.ToString();
                f.txtColonia.Text = dtgEmpleado.CurrentRow.Cells["colonia"].Value.ToString();
                f.txtCanton.Text = dtgEmpleado.CurrentRow.Cells["canton"].Value.ToString();
                f.txtCaserio.Text = dtgEmpleado.CurrentRow.Cells["caserio"].Value.ToString();
                f.txtCodigoPostal.Text = dtgEmpleado.CurrentRow.Cells["codigo_postal"].Value.ToString();
                f.txtIdMunicipio.Text = dtgEmpleado.CurrentRow.Cells["id_municipio"].Value.ToString();
                f.txtMunicipio.Text = dtgEmpleado.CurrentRow.Cells["municipio"].Value.ToString();
                f.checkControl.Checked = false;
                //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
                f.DataUpdated += FormEditor_DataUpdated;
                f.ShowDialog();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EMPLEADO.frmEditarEmpleado f = new EMPLEADO.frmEditarEmpleado();
            f.checkControl.Checked = true;
            //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
            f.DataUpdated += FormEditor_DataUpdated;
            f.ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reporte.GUI.visorEmpleado f = new Reporte.GUI.visorEmpleado();
            this.Close();
            f.ShowDialog();
        }
    }
}
