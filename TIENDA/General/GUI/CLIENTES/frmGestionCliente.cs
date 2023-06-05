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
    public partial class frmGestionCliente : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.USUARIOS();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _DATOS;
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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLIENTES.frmEditarCliente f = new CLIENTES.frmEditarCliente();
            f.ShowDialog();
            CargarDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Cliente clien = new CLS.Cliente();
                clien.IdCliente = dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString().ToUpper(); ;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLIENTES.frmEditarCliente f = new CLIENTES.frmEditarCliente();
                f.txtId.Text = dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString();
                f.txtIdentificacion.Text = dataGridView1.CurrentRow.Cells["identificacion"].Value.ToString();
                f.txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                f.txtCredito.Text = dataGridView1.CurrentRow.Cells["credito"].Value.ToString();
                f.txtDireccion.Text = dataGridView1.CurrentRow.Cells["id_direccion"].Value.ToString();
                f.checkEstado.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["estado"].Value.ToString());
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
