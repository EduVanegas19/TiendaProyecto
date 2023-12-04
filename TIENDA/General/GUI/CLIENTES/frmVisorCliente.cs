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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBuscar.Text.ToLower();

            // Deshabilitar el administrador de divisas
            dtgCliente.BindingContext[dtgCliente.DataSource].SuspendBinding();

            // Filtra los datos en las columnas 'nombre', 'identificacion', 'id_cliente' de manera flexible
            foreach (DataGridViewRow row in dtgCliente.Rows)
            {
                bool isVisible = false;

                DataGridViewCell identificacionCell = row.Cells["identificacion"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell nameCell = row.Cells["nombre"]; // Ajusta el nombre de la columna según tu caso

                if (identificacionCell != null && identificacionCell.Value != null && nameCell != null && nameCell.Value != null)
                {
                    string identificacionCellValue = identificacionCell.Value.ToString().ToLower();
                    string nameCellValue = nameCell.Value.ToString().ToLower();

                    if ( identificacionCellValue.Contains(searchText) || nameCellValue.Contains(searchText))
                    {
                        isVisible = true;
                    }
                }

                row.Visible = isVisible;
            }

            // Habilitar el administrador de divisas
            dtgCliente.BindingContext[dtgCliente.DataSource].ResumeBinding();
        }

    }
}
