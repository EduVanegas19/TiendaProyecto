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
    public partial class frmGestionVenta : Form
    {
        //Le decimos que cargue datos despues de cerrar el frmEditor
        private void FormEditor_DataUpdated(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public frmGestionVenta()
        {
            InitializeComponent();
        }
        private void CargarDatos()
        {
            DataTable factura = new DataTable();
            int pId = 2;
            try
            {
                factura = DataManager.DBConsultas.LISTARVENTAOPCION(pId);
                dtgfactura.AutoGenerateColumns = false;
                dtgfactura.DataSource = factura;
            }
            catch (Exception)
            {

            }
        }
        private void CargarOrden()
        {
            DataTable factura = new DataTable();
            //le digo que dependiendo de la opcion que se seleccione se muestre en orden correspondiente
            int pId = cbbOrdenar.SelectedIndex + 1;
            try
            {
                factura = DataManager.DBConsultas.LISTARVENTAOPCION(pId);
                dtgfactura.AutoGenerateColumns = false;
                dtgfactura.DataSource = factura;
            }
            catch (Exception)
            {

            }
        }

        private void frmGestionVenta_Load(object sender, EventArgs e)
        {
            CargarDatos();
            lblUsuario.Text = Session.Instancia.usuario;
            lblRol.Text = Session.Instancia.rol;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBuscar.Text.ToLower();

            // Deshabilitar el administrador de divisas
            dtgfactura.BindingContext[dtgfactura.DataSource].SuspendBinding();

            // Filtra los datos en la columna 'nombre' de manera flexible
            foreach (DataGridViewRow row in dtgfactura.Rows)
            {
                bool isVisible = false;

                DataGridViewCell nameCell = row.Cells["fecha"]; // Ajusta el nombre de la columna según tu caso
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
            dtgfactura.BindingContext[dtgfactura.DataSource].ResumeBinding();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DETALLE_VENTA.frmGestionDetalleVenta detalle_venta = new DETALLE_VENTA.frmGestionDetalleVenta();
            detalle_venta.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbOrdenar_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarOrden();
        }

        private void frmCrearReporte_Click(object sender, EventArgs e)
        {
            Reporte.GUI.visorUsuario f = new Reporte.GUI.visorUsuario();
            this.Close();
            f.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
