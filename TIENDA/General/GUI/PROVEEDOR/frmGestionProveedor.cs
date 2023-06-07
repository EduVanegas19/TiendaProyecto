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

namespace General.GUI
{
    public partial class frmGestionProveedor : Form
    {
        //Le decimos que cargue datos despues de cerrar el frmEditor
        private void FormEditor_DataUpdated(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            DataTable proveedores = new DataTable();
            int pId = 2;
            try
            {
                proveedores = DataManager.DBConsultas.LISTARPROVEEDORESOPCION(pId);
                dtgProveedores.AutoGenerateColumns = false;
                dtgProveedores.DataSource = proveedores;
            }
            catch (Exception)
            {

            }
        }
        private void CargarOrden()
        {
            DataTable proveedores = new DataTable();
            //le digo que dependiendo de la opcion que se seleccione se muestre en orden correspondiente
            int pId = cbbOrdenar.SelectedIndex+1;
            try
            {
                proveedores = DataManager.DBConsultas.LISTARPROVEEDORESOPCION(pId);
                dtgProveedores.AutoGenerateColumns = false;
                dtgProveedores.DataSource = proveedores;
            }
            catch (Exception)
            {

            }
        }
        public frmGestionProveedor()
        {
            InitializeComponent();
        }

        private void frmGestionProveedor_Load(object sender, EventArgs e)
        {
            CargarDatos();

            lblUsuario.Text = Session.Instancia.usuario;
            lblRol.Text = Session.Instancia.rol;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PROVEEDOR.frmEditarProveedor f = new PROVEEDOR.frmEditarProveedor();
                f.txtId.Text = dtgProveedores.CurrentRow.Cells["id_proveedor"].Value.ToString();
                f.txtProveedor.Text = dtgProveedores.CurrentRow.Cells["proveedor"].Value.ToString();
                f.txtNumDoc.Text = dtgProveedores.CurrentRow.Cells["numero_documento"].Value.ToString();
                f.checkLab.Checked = Convert.ToBoolean(dtgProveedores.CurrentRow.Cells["esLaboratorio"].Value.ToString());
                //establecemos el tipo de check para saber que opciones mostrar
                f.checkControl.Checked = false;
                //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
                f.DataUpdated += FormEditor_DataUpdated;
                f.ShowDialog();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PROVEEDOR.frmEditarProveedor f = new PROVEEDOR.frmEditarProveedor();
            //establecemos el tipo de check para saber que opciones mostrar
            f.checkControl.Checked = true;
            //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
            f.DataUpdated += FormEditor_DataUpdated;
            f.ShowDialog();
            
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Proveedor proveedor = new CLS.Proveedor();
                proveedor.IdProveedor = dtgProveedores.CurrentRow.Cells["id_proveedor"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (proveedor.Eliminar())
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

        private void dtgProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PROVEEDOR.frmEditarProveedor f = new PROVEEDOR.frmEditarProveedor();
                f.txtId.Text = dtgProveedores.CurrentRow.Cells["id_proveedor"].Value.ToString();
                f.txtProveedor.Text = dtgProveedores.CurrentRow.Cells["proveedor"].Value.ToString();
                f.txtNumDoc.Text = dtgProveedores.CurrentRow.Cells["numero_documento"].Value.ToString();
                f.checkLab.Checked = Convert.ToBoolean(dtgProveedores.CurrentRow.Cells["esLaboratorio"].Value.ToString());
                //establecemos el tipo de check para saber que opciones mostrar
                f.checkControl.Checked = false;
                //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
                f.DataUpdated += FormEditor_DataUpdated;
                f.ShowDialog();
                
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
            dtgProveedores.BindingContext[dtgProveedores.DataSource].SuspendBinding();

            // Filtra los datos en la columna 'nombre' de manera flexible
            foreach (DataGridViewRow row in dtgProveedores.Rows)
            {
                bool isVisible = false;

                DataGridViewCell nameCell = row.Cells["proveedor"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell codeCell = row.Cells["id_proveedor"]; // Ajusta el nombre de la columna según tu caso

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
            dtgProveedores.BindingContext[dtgProveedores.DataSource].ResumeBinding();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Reporte.GUI.visorProveedor form1 = new Reporte.GUI.visorProveedor();
            form1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
