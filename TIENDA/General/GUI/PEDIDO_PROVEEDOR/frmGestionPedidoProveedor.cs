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
    public partial class frmGestionPedidoProveedor : Form
    {
        //Le decimos que cargue datos despues de cerrar el frmEditor
        private void FormEditor_DataUpdated(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public frmGestionPedidoProveedor()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            DataTable pedido_proveedor = new DataTable();
            int pId = 2;
            try
            {
                pedido_proveedor = DataManager.DBConsultas.LISTARPEDIDOOPCION(pId);
                dtgPedidoProveedor.AutoGenerateColumns = false;
                dtgPedidoProveedor.DataSource = pedido_proveedor;
            }
            catch (Exception)
            {

            }
        }
        private void CargarOrden()
        {
            DataTable pedido_proveedor = new DataTable();
            //le digo que dependiendo de la opcion que se seleccione se muestre en orden correspondiente
            int pId = cbbOrdenar.SelectedIndex + 1;
            try
            {
                pedido_proveedor = DataManager.DBConsultas.LISTARPEDIDOOPCION(pId);
                dtgPedidoProveedor.AutoGenerateColumns = false;
                dtgPedidoProveedor.DataSource = pedido_proveedor;
            }
            catch (Exception)
            {

            }
        }
        private void frmGestionPedidoProveedor_Load(object sender, EventArgs e)
        {
            CargarDatos();
            lblUsuario.Text = Session.Instancia.usuario;
            lblRol.Text = Session.Instancia.rol;
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

                DataGridViewCell nameCell = row.Cells["proveedor"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell codeCell = row.Cells["numero_documento"]; // Ajusta el nombre de la columna según tu caso

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
            dtgPedidoProveedor.BindingContext[dtgPedidoProveedor.DataSource].ResumeBinding();
        }

        private void cbbOrdenar_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarOrden();
        }
        private void cbbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DETALLE_PEDIDO.frmGestionDetallePedido detalle_pedido = new DETALLE_PEDIDO.frmGestionDetallePedido();
            detalle_pedido.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

    }
}
