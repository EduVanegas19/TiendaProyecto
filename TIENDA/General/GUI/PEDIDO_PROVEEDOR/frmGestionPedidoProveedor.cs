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
    public partial class frmGestionPedidoProveedor : Form
    {
        public frmGestionPedidoProveedor()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            DataTable direcciones = new DataTable();
            int pId = 2;
            try
            {
                direcciones = DataManager.DBConsultas.LISTARDIRECCIONOPCION(pId);
                dtgDireccion.AutoGenerateColumns = false;
                dtgDireccion.DataSource = direcciones;
            }
            catch (Exception)
            {

            }
        }
        private void frmGestionPedidoProveedor_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBuscar.Text.ToLower();

            // Deshabilitar el administrador de divisas
            dtgPedidoProveedor.BindingContext[dtgPedidoProveedor.DataSource].SuspendBinding();

            // Filtra los datos en la columna 'nombre' de manera flexible
            foreach (DataGridViewRow row in dtgPedidoProveedor.Rows)
            {
                bool isVisible = false;

                DataGridViewCell nameCell = row.Cells["numero_documento"]; // Ajusta el nombre de la columna según tu caso

                if (nameCell != null && nameCell.Value != null)
                {
                    string nameCellValue = nameCell.Value.ToString().ToLower();

                    if (nameCellValue.Contains(searchText) )
                    {
                        isVisible = true;
                    }
                }

                row.Visible = isVisible;
            }

            // Habilitar el administrador de divisas
            dtgPedidoProveedor.BindingContext[dtgPedidoProveedor.DataSource].ResumeBinding();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void cbbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
