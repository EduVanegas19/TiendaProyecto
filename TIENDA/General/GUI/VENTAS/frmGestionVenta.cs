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
            txtFechaEspecial.KeyPress += new KeyPressEventHandler(txtFechaEspecial_KeyPress);
        }
        // Evento KeyPress para el campo de texto
        private void txtFechaEspecial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && cbbOrdenar.SelectedIndex + 1 == 8)
            {
                DateTime? pfecha = ObtenerFechaDigitada();
                if (pfecha != null)
                {
                    try
                    {
                        DataTable factura = DataManager.DBConsultas.LISTARVENTAOPCION(8, pfecha);
                        dtgfactura.AutoGenerateColumns = false;
                        dtgfactura.DataSource = factura;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void CargarDatos()
        {
            DataTable factura = new DataTable();
            int pId = 2;
            DateTime? pfecha = null;
            try
            {
                factura = DataManager.DBConsultas.LISTARVENTAOPCION(pId, pfecha);
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
            int pId = cbbOrdenar.SelectedIndex + 1;

            lblFechaEspecial.Visible = pId == 8;
            txtFechaEspecial.Visible = pId == 8;

            if (pId != 8)
            {
                try
                {
                    factura = DataManager.DBConsultas.LISTARVENTAOPCION(pId, null);
                    dtgfactura.AutoGenerateColumns = false;
                    dtgfactura.DataSource = factura;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // No se maneja aquí la opción 8, se deja para el evento KeyPress de txtFechaEspecial
        }


        private DateTime? ObtenerFechaDigitada()
        {
            // Implementa la lógica para obtener la fecha digitada
            DateTime fechaDigitada;
            if (DateTime.TryParse(txtFechaEspecial.Text, out fechaDigitada))
            {
                // Formatear la fecha en un formato compatible con SQL (por ejemplo, yyyy-MM-dd)
                string fechaFormateada = fechaDigitada.ToString("dd-MM-yyyy");

                // Convertir la fecha formateada de nuevo a DateTime
                if (DateTime.TryParse(fechaFormateada, out DateTime fechaFormateadaDateTime))
                {
                    return fechaFormateadaDateTime;
                }
                else
                {
                    // Manejar si la conversión no es exitosa (esto debería ser poco probable)
                    MessageBox.Show("Error al formatear la fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                // Si la fecha no es válida, podrías manejarlo de alguna manera, como mostrar un mensaje al usuario
                MessageBox.Show("Fecha no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void frmGestionVenta_Load(object sender, EventArgs e)
        {
            lblFechaEspecial.Visible = false;
            txtFechaEspecial.Visible = false;
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
            int pIdOrden = cbbOrdenar.SelectedIndex + 1;
            DateTime? pfechaSeleccionada = null;

            if (pIdOrden == 8)
            {
                pfechaSeleccionada = ObtenerFechaDigitada();
                if (pfechaSeleccionada == null)
                {
                    MessageBox.Show("Fecha no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si la fecha no es válida
                }
            }

            Reporte.GUI.VisorVenta visor = new Reporte.GUI.VisorVenta(pIdOrden, pfechaSeleccionada);
            this.Close(); // Cierra el formulario actual
            visor.ShowDialog(); // Muestra el nuevo formulario
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cbbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
