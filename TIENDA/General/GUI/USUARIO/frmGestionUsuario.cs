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
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = _DATOS;
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
    }
}
