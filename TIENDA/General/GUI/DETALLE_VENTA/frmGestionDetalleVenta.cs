using General.CLS;
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

namespace General.GUI.DETALLE_VENTA
{
    public partial class frmGestionDetalleVenta : Form
    {
        private static CLS.Producto _producto = null;
        private static CLS.Cliente _cliente = null;
        private decimal cantidadDescuento = 0;
        private string razonDescuento = string.Empty;
        private bool aplicarDescuento = false;

        private void CargarTipoPagos()
        {
            DataTable pagos = new DataTable();
            try
            {
                pagos = DataManager.DBConsultas.TIPO_PAGOS();
                cbbPagos.DataSource = pagos;
                cbbPagos.DisplayMember = "tipo_pago";
                cbbPagos.ValueMember = "id_tipopago";
            }
            catch (Exception)
            {

            }
        }
        void limpiar()
        {
            txtCodigoB.Text = "";
            txtCantidad.Text = "";
            txtNombreProducto.Text = "";
            txtPrecio.Text = "";
            txtIdProducto.Text = "";
            txtPrecioUnidad.Text = "";
            txtStock.Text = "";
        }
        public frmGestionDetalleVenta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGestionDetalleVenta_Load(object sender, EventArgs e)
        {
            CargarTipoPagos();

            lblUsuario.Text = Session.Instancia.usuario;
            lblRol.Text = Session.Instancia.rol;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var Iform = new PRODUCTO.frmVisorProducto())
            {
                var result = Iform.ShowDialog();
                decimal valor;
                if (result == DialogResult.OK)
                {
                    _producto = Iform._producto;
                    txtCodigoB.BackColor = Color.Honeydew;
                    txtIdProducto.Text = _producto.IdProducto;
                    txtCodigoB.Text = _producto.CodigoBarras;
                    txtNombreProducto.Text = _producto.Nombre;
                    valor = Convert.ToDecimal(_producto.PrecioVenta);
                    txtPrecio.Text = valor.ToString("0.00");
                    txtPrecioUnidad.Text = _producto.PrecioUnidad;
                    txtStock.Text = _producto.Stock;
                }
                else
                {
                    btnBuscar.Select();
                }
            }
        }
        private bool producto_agregado()
        {
            bool respuesta = false;
            if (dtgVenta.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dtgVenta.Rows)
                {
                    if (fila.Cells["id_producto"].Value.ToString() == _producto.IdProducto.ToString())
                    {
                        respuesta = true;
                        break;
                    }
                }
            }

            return respuesta;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_producto == null)
            {
                MessageBox.Show("Debe ingresar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (producto_agregado())
            {
                MessageBox.Show("El producto ya está agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Convert.ToInt32(txtCantidad.Value) > Convert.ToInt32(_producto.Stock))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Obtén el valor del TextBox
            string idproducto = txtIdProducto.Text;
            string nombre = txtNombreProducto.Text;
            string codBarras = txtCodigoB.Text;
            string precioVenta = txtPrecio.Text;
            string cantidad = txtCantidad.Text;
            string precioUnidad = txtPrecioUnidad.Text;

            // Crea una nueva fila y agrega las celdas con los datos
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dtgVenta);
            fila.Cells[0].Value = idproducto; // Asigna el valor del TextBox a la primera celda de la fila
            fila.Cells[1].Value = nombre;
            fila.Cells[2].Value = precioVenta;
            fila.Cells[3].Value = codBarras;
            fila.Cells[4].Value = cantidad;
            fila.Cells[5].Value = precioUnidad;

            // Agrega la fila al DataGridView
            dtgVenta.Rows.Add(fila);

            // Limpia el TextBox después de agregar los datos
            txtCodigoB.Text = string.Empty;

            calcularTotal();
            limpiar();
            calcularTotalProductos();
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            // Establecer aplicarDescuento en true
            aplicarDescuento = true;

            // Crear el formulario de descuento
            using (var formularioDescuento = new frmDescuento())
            {
                // Mostrar el formulario de descuento como un cuadro de diálogo
                DialogResult result = formularioDescuento.ShowDialog(this);

                // Verificar si el formulario de descuento se cerró con OK
                if (result == DialogResult.OK)
                {
                    // Actualizar la variable cantidadDescuento en el formulario principal
                    cantidadDescuento = formularioDescuento.CantidadDescuento;

                    // Actualizar la variable razonDescuento en el formulario principal
                    razonDescuento = formularioDescuento.RazonDescuento;

                    // Volver a calcular el total con el descuento
                    calcularTotal();
                }
            }
        }


        private void calcularTotalProductos()
        {
            int total = 0;
            if (dtgVenta.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgVenta.Rows)
                {
                    // Verificar si la celda tiene un valor antes de intentar convertirlo
                    if (row.Cells["cantidad"].Value != null)
                    {
                        int cantidad;
                        if (int.TryParse(row.Cells["cantidad"].Value.ToString(), out cantidad))
                        {
                            total += cantidad;
                        }
                    }
                }
            }
            txtTotalProductos.Text = total.ToString();
        }

        private void calcularTotal()
        {
            try
            {
                decimal total = 0;

                // Calcular el total de los productos
                if (dtgVenta.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dtgVenta.Rows)
                    {
                        // Verificar si las celdas tienen valores y son numéricos antes de operar
                        if (row.Cells["precio_venta"].Value != null && row.Cells["cantidad"].Value != null)
                        {
                            if (decimal.TryParse(row.Cells["precio_venta"].Value.ToString(), out decimal precioVenta) &&
                                int.TryParse(row.Cells["cantidad"].Value.ToString(), out int cantidad))
                            {
                                total += precioVenta * cantidad;
                            }
                            else
                            {
                                // Manejar el caso en que los valores no se puedan convertir
                                MessageBox.Show("Error de formato en las celdas de precio_venta o cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }

                // Resta el descuento al total después de calcular el total de los productos
                total -= cantidadDescuento;

                txtTotalPagar.Text = total.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular el total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var Iform = new CLIENTES.frmVisorCliente())
            {
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _cliente = Iform._cliente;
                    txtIdCliente.BackColor = Color.Honeydew;
                    txtIdCliente.Text = _cliente.IdCliente.ToString();
                    txtNombreClient.Text = _cliente.Nombre.ToString();
                }
                else
                {
                    btnBuscarCliente.Select();
                }
            }
        }

        private void txtPagoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Cancela el evento para evitar que se muestre la tecla en el TextBox
            }
            else if ((e.KeyChar == '.' || e.KeyChar == ',') && ((TextBox)sender).Text.Contains(".") && !((TextBox)sender).SelectedText.Contains("."))
            {
                e.Handled = true; // Cancela el evento si ya existe un punto decimal en el TextBox
            }
        }
        private void CalcularCambio()
        {
            if (decimal.TryParse(txtPagoCliente.Text, out decimal valor1) && decimal.TryParse(txtTotalPagar.Text, out decimal valor2))
            {
                decimal resultado = valor1 - valor2;
                txtCambio.Text = resultado.ToString("0.00");
            }
        }

        private void txtCambio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalPagar_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void txtPagoCliente_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            // Crear variables para los textbox
            int estado = 1;
            string numdoc = "1122";
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            decimal totalpagar = Convert.ToDecimal(txtTotalPagar.Text);
            decimal montocliente = Convert.ToDecimal(txtPagoCliente.Text);
            decimal cambio = Convert.ToDecimal(txtCambio.Text);

            // Crear objeto entidad Factura
            CLS.Factura fac = new CLS.Factura();

            // Sincronizar la entidad con la interfaz
            fac.NumeroDocumento = numdoc.ToString();
            fac.Descripcion = "gracias por preferirnos";
            fac.Fecha = fecha.ToString();
            fac.MontoTotal = totalpagar.ToString("0.00");
            fac.CantidadProductos = txtTotalProductos.Text;
            fac.MontoCliente = montocliente.ToString("0.00");
            fac.Cambio = cambio.ToString("0.00");
            fac.IdTipoPago = Convert.ToString(Convert.ToInt32(cbbPagos.SelectedIndex.ToString()) + 1);
            fac.IdEmpleado = Session.Instancia.id_empleado.ToString();

            if (txtIdCliente.Text.Length > 0)
            {
                fac.IdCliente = txtIdCliente.Text;
            }
            else
            {
                fac.IdCliente = "NULL";
            }

            decimal descuentoMonto = cantidadDescuento;
            string descuentoRazon = razonDescuento;

            Console.WriteLine("DescuentoRazon: " + descuentoRazon);

            // Asignar datos de descuento a la entidad Factura
            fac.DescuentoMonto = descuentoMonto.ToString("0.00");
            fac.DescuentoRazon = descuentoRazon;

            // Realizar la operacion de insertar factura
            if (fac.Insertar())
            {
                int rowIndex = 0;

                while (rowIndex < dtgVenta.Rows.Count && dtgVenta.Rows[rowIndex].Cells[0].Value != null)
                {
                    DataGridViewRow fila = dtgVenta.Rows[rowIndex];

                    CLS.Detalle_factura factura = new CLS.Detalle_factura();

                    string precioventa = Convert.ToString(Convert.ToDecimal(fila.Cells["precio_venta"].Value.ToString()) * Convert.ToInt32(fila.Cells["cantidad"].Value.ToString()));

                    factura.PrecioUnitario = fila.Cells["precio_venta"].Value.ToString();
                    factura.PrecioVenta = precioventa.ToString();
                    factura.Cantidad = fila.Cells["cantidad"].Value.ToString();
                    factura.IdProducto = fila.Cells["id_producto"].Value.ToString();
                    factura.Estado = estado.ToString();

                    // Asigna los valores de las demás propiedades según las columnas del DataGridView
                    factura.Insertar();

                    rowIndex++;
                }

                Reporte.GUI.visorFactura f = new Reporte.GUI.visorFactura();
                this.Close();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("¡El registro no fue insertado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dtgVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            CLIENTES.frmEditarCliente f = new CLIENTES.frmEditarCliente();
            f.ShowDialog();
        }

        

    }
}