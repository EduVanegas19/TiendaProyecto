using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;
using SessionManager;

namespace General.GUI
{
    public partial class frmGestionCliente : Form
    {
        //Le decimos que cargue datos despues de cerrar el frmEditor
        private void FormEditor_DataUpdated(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            DataTable clientes = new DataTable();
            int pId = 1;
            try
            {
                clientes = DataManager.DBConsultas.LISTARCLIENTEOPCION(pId);
                dtgCliente.AutoGenerateColumns = false;
                dtgCliente.DataSource = clientes;
            }
            catch (Exception)
            {

            }
        }
        private void CargarOrden()
        {
            DataTable clientes = new DataTable();
            //le digo que dependiendo de la opcion que se seleccione se muestre en orden correspondiente
            int pId = cbbOrdenar.SelectedIndex + 1;
            try
            {
                clientes = DataManager.DBConsultas.LISTARCLIENTEOPCION(pId);
                dtgCliente.AutoGenerateColumns = false;
                dtgCliente.DataSource = clientes;
            }
            catch (Exception)
            {

            }
        }
        public frmGestionCliente()
        {
            InitializeComponent();
        }


        private void frmGestionCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();

            lblUsuario.Text = Session.Instancia.usuario;
            lblRol.Text = Session.Instancia.rol;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Cliente clien = new CLS.Cliente();
                clien.IdCliente = dtgCliente.CurrentRow.Cells["id_cliente"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (clien.Eliminar())
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

        private void cbbBuscar_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarOrden();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBuscar.Text.ToLower();

            // Deshabilitar el administrador de divisas
            dtgCliente.BindingContext[dtgCliente.DataSource].SuspendBinding();

            // Filtra los datos en la columna 'nombre' de manera flexible
            foreach (DataGridViewRow row in dtgCliente.Rows)
            {
                bool isVisible = false;

                DataGridViewCell nameCell = row.Cells["nombre"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell codeCell = row.Cells["municipio"]; // Ajusta el nombre de la columna según tu caso

                if (nameCell != null && nameCell.Value != null && codeCell != null && codeCell.Value != null)
                {
                    string nameCellValue = nameCell.Value.ToString().ToLower();
                    string codeCellValue = codeCell.Value.ToString().ToLower();

                    if (nameCellValue.Contains(searchText) || codeCellValue.Contains(searchText))
                    {
                        isVisible = true;
                    }
                }

                row.Visible = isVisible;
            }

            // Habilitar el administrador de divisas
            dtgCliente.BindingContext[dtgCliente.DataSource].ResumeBinding();
        }

        private void cbbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLIENTES.frmEditarCliente f = new CLIENTES.frmEditarCliente();
                f.txtIdClient.Text = dtgCliente.CurrentRow.Cells["id_cliente"].Value.ToString();
                f.txtIdenficacion.Text = dtgCliente.CurrentRow.Cells["identificacion"].Value.ToString();
                f.txtNombre.Text = dtgCliente.CurrentRow.Cells["nombre"].Value.ToString();
                f.txtCredito.Text = dtgCliente.CurrentRow.Cells["credito"].Value.ToString();
                f.txtIdDirec.Text = dtgCliente.CurrentRow.Cells["id_direccion"].Value.ToString();
                f.txtNumCasa.Text = dtgCliente.CurrentRow.Cells["numero_casa"].Value.ToString();
                f.txtPasaje.Text = dtgCliente.CurrentRow.Cells["pasaje_poligono"].Value.ToString();
                f.txtCalle.Text = dtgCliente.CurrentRow.Cells["calle"].Value.ToString();
                f.txtColonia.Text = dtgCliente.CurrentRow.Cells["colonia"].Value.ToString();
                f.txtCanton.Text = dtgCliente.CurrentRow.Cells["canton"].Value.ToString();
                f.txtCaserio.Text = dtgCliente.CurrentRow.Cells["caserio"].Value.ToString();
                f.txtCodigoPostal.Text = dtgCliente.CurrentRow.Cells["codigo_postal"].Value.ToString();
                f.txtIdMunicipio.Text = dtgCliente.CurrentRow.Cells["id_municipio"].Value.ToString();
                f.txtMunicipio.Text = dtgCliente.CurrentRow.Cells["municipio"].Value.ToString();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CLIENTES.frmEditarCliente f = new CLIENTES.frmEditarCliente();
            f.checkControl.Checked = true;
            //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
            f.DataUpdated += FormEditor_DataUpdated;
            f.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLIENTES.frmEditarCliente f = new CLIENTES.frmEditarCliente();
                f.txtIdClient.Text = dtgCliente.CurrentRow.Cells["id_cliente"].Value.ToString();
                f.txtIdenficacion.Text = dtgCliente.CurrentRow.Cells["identificacion"].Value.ToString();
                f.txtNombre.Text = dtgCliente.CurrentRow.Cells["nombre"].Value.ToString();
                f.txtCredito.Text = dtgCliente.CurrentRow.Cells["credito"].Value.ToString();
                f.txtIdDirec.Text = dtgCliente.CurrentRow.Cells["id_direccion"].Value.ToString();
                f.txtNumCasa.Text = dtgCliente.CurrentRow.Cells["numero_casa"].Value.ToString();
                f.txtPasaje.Text = dtgCliente.CurrentRow.Cells["pasaje_poligono"].Value.ToString();
                f.txtCalle.Text = dtgCliente.CurrentRow.Cells["calle"].Value.ToString();
                f.txtColonia.Text = dtgCliente.CurrentRow.Cells["colonia"].Value.ToString();
                f.txtCanton.Text = dtgCliente.CurrentRow.Cells["canton"].Value.ToString();
                f.txtCaserio.Text = dtgCliente.CurrentRow.Cells["caserio"].Value.ToString();
                f.txtIdMunicipio.Text = dtgCliente.CurrentRow.Cells["id_municipio"].Value.ToString();
                f.txtMunicipio.Text = dtgCliente.CurrentRow.Cells["municipio"].Value.ToString(); 
                f.checkControl.Checked = false;
                //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
                f.DataUpdated += FormEditor_DataUpdated;
                f.ShowDialog();
            }
        }

        private void frmCrearReporte_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(frmCrearReporte.Name))
            {
                Reporte.GUI.visorClientes f = new Reporte.GUI.visorClientes();
                this.Close();
                f.ShowDialog();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }
    }
}
