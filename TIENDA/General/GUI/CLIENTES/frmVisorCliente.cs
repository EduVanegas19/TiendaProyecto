using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.CLIENTES
{
    public partial class frmVisorCliente : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.CLIENTES();
                dtgCliente.AutoGenerateColumns = false;
                dtgCliente.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        public frmVisorCliente()
        {
            InitializeComponent();
        }

        private void frmVisorCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public CLS.Cliente _cliente { get; set; }
        private void dtgProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dtgCliente.Columns[e.ColumnIndex].Name == "btnSeleccionar")
                {
                    _cliente = new CLS.Cliente()
                    {
                        IdCliente = dtgCliente.Rows[index].Cells["id_cliente"].Value.ToString(),
                        Nombre = dtgCliente.Rows[index].Cells["nombre"].Value.ToString(),
                        Identificacion = dtgCliente.Rows[index].Cells["identificacion"].Value.ToString()
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }
    }
}
