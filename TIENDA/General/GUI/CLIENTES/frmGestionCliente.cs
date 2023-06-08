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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmGestionCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();

            lblUsuario.Text = Session.Instancia.usuario;
            lblRol.Text = Session.Instancia.rol;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Cliente clien = new CLS.Cliente();
                clien.IdCliente = dtgCliente.CurrentRow.Cells["id_proveedor"].Value.ToString().ToUpper(); ;
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
    }
}
