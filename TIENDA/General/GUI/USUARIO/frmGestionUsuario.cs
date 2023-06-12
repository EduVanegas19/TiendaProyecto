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
    public partial class frmGestionUsuario : Form
    {
        //Le decimos que cargue datos despues de cerrar el frmEditor
        private void FormEditor_DataUpdated(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            DataTable usuario = new DataTable();
            int pId = 1;
            try
            {
                usuario = DataManager.DBConsultas.LISTARUSUARIOSOPCION(pId);
                dtgvUsuario.AutoGenerateColumns = false;
                dtgvUsuario.DataSource = usuario;
            }
            catch (Exception)
            {

            }
        }
        private void CargarOrden()
        {
            DataTable usuario = new DataTable();
            //le digo que dependiendo de la opcion que se seleccione se muestre en orden correspondiente
            int pId = cbbOrdenar.SelectedIndex + 1;
            try
            {
                usuario = DataManager.DBConsultas.LISTARUSUARIOSOPCION(pId);
                dtgvUsuario.AutoGenerateColumns = false;
                dtgvUsuario.DataSource = usuario;
            }
            catch (Exception)
            {

            }
        }

        public frmGestionUsuario()
        {
            InitializeComponent();
        }

        private void frmGestionUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();

            lblUsuario.Text = Session.Instancia.usuario;
            lblRol.Text = Session.Instancia.rol;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbOrdenar_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarOrden();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBuscar.Text.ToLower();

            // Deshabilitar el administrador de divisas
            dtgvUsuario.BindingContext[dtgvUsuario.DataSource].SuspendBinding();

            // Filtra los datos en la columna 'nombre' de manera flexible
            foreach (DataGridViewRow row in dtgvUsuario.Rows)
            {
                bool isVisible = false;

                DataGridViewCell nameCell = row.Cells["usuario"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell name = row.Cells["nombre"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell codeCell = row.Cells["rol"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell apellido = row.Cells["apellido"]; // Ajusta el nombre de la columna según tu caso

                if (nameCell != null && nameCell.Value != null && name != null && name.Value != null && codeCell != null && codeCell.Value != null && apellido != null && apellido.Value != null)
                {
                    string nameCellValue = nameCell.Value.ToString().ToLower();
                    string nameValue = name.Value.ToString().ToLower();
                    string codeCellValue = codeCell.Value.ToString().ToLower();
                    string apellidoValue = apellido.Value.ToString().ToLower();

                    if (nameCellValue.Contains(searchText) || nameValue.Contains(searchText) || codeCellValue.Contains(searchText) || apellidoValue.Contains(searchText))
                    {
                        isVisible = true;
                    }
                }

                row.Visible = isVisible;
            }

            // Habilitar el administrador de divisas
            dtgvUsuario.BindingContext[dtgvUsuario.DataSource].ResumeBinding();
        }

        private void dtgvUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmEditarUsuario f = new frmEditarUsuario();
                f.txtIdUsuario.Text = dtgvUsuario.CurrentRow.Cells["id_usuario"].Value.ToString();
                f.txtUsuario.Text = dtgvUsuario.CurrentRow.Cells["usuario"].Value.ToString();
                f.txtClave.Text = dtgvUsuario.CurrentRow.Cells["clave"].Value.ToString();

                f.txtIdEmpleado.Text = dtgvUsuario.CurrentRow.Cells["id_empleado"].Value.ToString();
                f.txtNombre.Text = dtgvUsuario.CurrentRow.Cells["nombre"].Value.ToString();
                f.txtApellido.Text = dtgvUsuario.CurrentRow.Cells["apellido"].Value.ToString();

                f.txtIdRol.Text = dtgvUsuario.CurrentRow.Cells["id_rol"].Value.ToString();
                f.txtRol.Text = dtgvUsuario.CurrentRow.Cells["rol"].Value.ToString();

                f.checkControl.Checked = false;
                //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
                f.DataUpdated += FormEditor_DataUpdated;
                f.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Usuario usuario = new CLS.Usuario();
                usuario.IdUsuario = dtgvUsuario.CurrentRow.Cells["id_usuario"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (usuario.Eliminar())
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEditarUsuario f = new frmEditarUsuario();
            f.checkControl.Checked = true;
            //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
            f.DataUpdated += FormEditor_DataUpdated;
            f.ShowDialog();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmEditarUsuario f = new frmEditarUsuario();
                f.txtIdUsuario.Text = dtgvUsuario.CurrentRow.Cells["id_usuario"].Value.ToString();
                f.txtUsuario.Text = dtgvUsuario.CurrentRow.Cells["usuario"].Value.ToString();
                f.txtClave.Text = dtgvUsuario.CurrentRow.Cells["clave"].Value.ToString();

                f.txtIdEmpleado.Text = dtgvUsuario.CurrentRow.Cells["id_empleado"].Value.ToString();
                f.txtNombre.Text = dtgvUsuario.CurrentRow.Cells["nombre"].Value.ToString();
                f.txtApellido.Text = dtgvUsuario.CurrentRow.Cells["apellido"].Value.ToString();

                f.txtIdRol.Text = dtgvUsuario.CurrentRow.Cells["id_rol"].Value.ToString();
                f.txtRol.Text = dtgvUsuario.CurrentRow.Cells["rol"].Value.ToString();

                f.checkControl.Checked = false;
                //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
                f.DataUpdated += FormEditor_DataUpdated;
                f.ShowDialog();
            }
        }

        private void frmCrearReporte_Click(object sender, EventArgs e)
        {
            Reporte.GUI.visorUsuario f = new Reporte.GUI.visorUsuario();
            this.Close();
            f.ShowDialog();
        }
    }
}
