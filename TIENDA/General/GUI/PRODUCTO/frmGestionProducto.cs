using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;
using SessionManager;

namespace General.GUI.PRODUCTO
{
    public partial class frmGestionProducto : Form
    {
        //Le decimos que cargue datos despues de cerrar el frmEditor
        private void FormEditor_DataUpdated(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            DataTable producto = new DataTable();
            int pId = 1;
            try
            {
                producto = DataManager.DBConsultas.LISTARPRODUCTOsOPCION(pId);
                dtgProducto.AutoGenerateColumns = false;
                dtgProducto.DataSource = producto;
            }
            catch (Exception)
            {

            }
        }
        private void CargarOrden()
        {
            DataTable producto = new DataTable();
            //le digo que dependiendo de la opcion que se seleccione se muestre en orden correspondiente
            int pId = cbbOrdenar.SelectedIndex + 1;
            try
            {
                producto = DataManager.DBConsultas.LISTARPRODUCTOsOPCION(pId);
                dtgProducto.AutoGenerateColumns = false;
                dtgProducto.DataSource = producto;
            }
            catch (Exception)
            {

            }
        }
        public frmGestionProducto()
        {
            InitializeComponent();
        }

        private void frmGestionProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();

            lblUsuario.Text = Session.Instancia.usuario;
            lblRol.Text = Session.Instancia.rol;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PRODUCTO.frmEditarProducto f = new PRODUCTO.frmEditarProducto();
                f.txtId.Text = dtgProducto.CurrentRow.Cells["id_producto"].Value.ToString();
                f.txtCodigoB.Text = dtgProducto.CurrentRow.Cells["codigo_barras"].Value.ToString();
                f.txtDescripcion.Text = dtgProducto.CurrentRow.Cells["descripcion"].Value.ToString();
                f.txtPrecioUni.Text = dtgProducto.CurrentRow.Cells["precio_unidad"].Value.ToString();
                f.txtPrecioVenta.Text = dtgProducto.CurrentRow.Cells["precio_venta"].Value.ToString();
                f.txtCantidad.Text = dtgProducto.CurrentRow.Cells["stock"].Value.ToString();
                f.txtNombre.Text = dtgProducto.CurrentRow.Cells["nombre"].Value.ToString();
                f.dtpFechaIngreso.Text = dtgProducto.CurrentRow.Cells["fecha_ingreso"].Value.ToString();
                f.dtpFechaVencimiento.Text = dtgProducto.CurrentRow.Cells["fecha_vencimiento"].Value.ToString();
                f.txtIdUnidad.Text = dtgProducto.CurrentRow.Cells["id_unidadmedida"].Value.ToString();
                f.txtUnidadMedida.Text = dtgProducto.CurrentRow.Cells["unidad_medida"].Value.ToString();
                f.txtIdArea.Text = dtgProducto.CurrentRow.Cells["id_area"].Value.ToString();
                f.txtIdArea.Text = dtgProducto.CurrentRow.Cells["area"].Value.ToString();
                f.checkControl.Checked = false;
                //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
                f.DataUpdated += FormEditor_DataUpdated;
                f.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Producto producto = new CLS.Producto();
                producto.IdProducto = dtgProducto.CurrentRow.Cells["id_producto"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (producto.Eliminar())
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PRODUCTO.frmEditarProducto f = new PRODUCTO.frmEditarProducto();
            f.checkControl.Checked = true;
            //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
            f.DataUpdated += FormEditor_DataUpdated;
            f.ShowDialog();
        }

        private void dtgProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PRODUCTO.frmEditarProducto f = new PRODUCTO.frmEditarProducto();
                f.txtId.Text = dtgProducto.CurrentRow.Cells["id_producto"].Value.ToString();
                f.txtCodigoB.Text = dtgProducto.CurrentRow.Cells["codigo_barras"].Value.ToString();
                f.txtDescripcion.Text = dtgProducto.CurrentRow.Cells["descripcion"].Value.ToString();
                f.txtPrecioUni.Text = dtgProducto.CurrentRow.Cells["precio_unidad"].Value.ToString();
                f.txtPrecioVenta.Text = dtgProducto.CurrentRow.Cells["precio_venta"].Value.ToString();
                f.txtCantidad.Text = dtgProducto.CurrentRow.Cells["stock"].Value.ToString();
                f.txtNombre.Text = dtgProducto.CurrentRow.Cells["nombre"].Value.ToString();
                f.dtpFechaIngreso.Text = dtgProducto.CurrentRow.Cells["fecha_ingreso"].Value.ToString();
                f.dtpFechaVencimiento.Text = dtgProducto.CurrentRow.Cells["fecha_vencimiento"].Value.ToString();
                f.txtIdUnidad.Text = dtgProducto.CurrentRow.Cells["id_unidadmedida"].Value.ToString();
                f.txtUnidadMedida.Text = dtgProducto.CurrentRow.Cells["unidad_medida"].Value.ToString();
                f.txtIdArea.Text = dtgProducto.CurrentRow.Cells["id_area"].Value.ToString();
                f.txtIdArea.Text = dtgProducto.CurrentRow.Cells["area"].Value.ToString();
                f.checkControl.Checked = false;
                //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
                f.DataUpdated += FormEditor_DataUpdated;
                f.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbOrdenar_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarOrden();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBuscar.Text.ToLower();

            // Deshabilitar el administrador de divisas
            dtgProducto.BindingContext[dtgProducto.DataSource].SuspendBinding();

            // Filtra los datos en la columna 'nombre' de manera flexible
            foreach (DataGridViewRow row in dtgProducto.Rows)
            {
                bool isVisible = false;

                DataGridViewCell nameCell = row.Cells["nombre"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell codeCell = row.Cells["codigo_barras"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell area = row.Cells["area"]; // Ajusta el nombre de la columna según tu caso
                DataGridViewCell proveedor = row.Cells["area"]; // Ajusta el nombre de la columna según tu caso

                if (nameCell != null && nameCell.Value != null && codeCell != null && codeCell.Value != null && area != null && area.Value != null && proveedor != null && proveedor.Value != null)
                {
                    string nameCellValue = nameCell.Value.ToString().ToLower();
                    string codeCellValue = codeCell.Value.ToString().ToLower();
                    string areaValue = area.Value.ToString().ToLower();
                    string proveedorValue = proveedor.Value.ToString().ToLower();

                    if (nameCellValue.Contains(searchText) || codeCellValue.Contains(searchText) || areaValue.Contains(searchText) || proveedorValue.Contains(searchText))
                    {
                        isVisible = true;
                    }
                }

                row.Visible = isVisible;
            }

            // Habilitar el administrador de divisas
            dtgProducto.BindingContext[dtgProducto.DataSource].ResumeBinding();
        }

        private void frmCrearReporte_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(frmCrearReporte.Name))
            {
                Reporte.GUI.visorProducto f = new Reporte.GUI.visorProducto();
                this.Close();
                f.ShowDialog();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
            
        }
    }
}
