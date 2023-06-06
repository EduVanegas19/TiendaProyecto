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
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.USUARIOS();
                dtgvUsuario.AutoGenerateColumns = false;
                dtgvUsuario.DataSource = _DATOS;
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
        }

        private void dtgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLIENTES.frmEditarCliente f = new CLIENTES.frmEditarCliente();
                
                f.ShowDialog();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
