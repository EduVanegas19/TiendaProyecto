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
    public partial class frmGestionProveedor : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.PROVEEDORES();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _DATOS;
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Proveedor proveedor = new CLS.Proveedor();
                proveedor.IdProveedor = dataGridView1.CurrentRow.Cells["id_proveedor"].Value.ToString().ToUpper(); ;
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            PROVEEDOR.frmEditarProveedor f = new PROVEEDOR.frmEditarProveedor();
            f.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PROVEEDOR.frmEditarProveedor f = new PROVEEDOR.frmEditarProveedor();
                f.textBox1.Text = dataGridView1.CurrentRow.Cells["id_proveedor"].Value.ToString();
                f.txtProveedor.Text = dataGridView1.CurrentRow.Cells["proveedor"].Value.ToString();
                f.txtNumDoc.Text = dataGridView1.CurrentRow.Cells["numero_documento"].Value.ToString();
                f.checkLab.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["esLaboratorio"].Value.ToString());
                f.ShowDialog();
                CargarDatos();
            }
        }
    }
}
