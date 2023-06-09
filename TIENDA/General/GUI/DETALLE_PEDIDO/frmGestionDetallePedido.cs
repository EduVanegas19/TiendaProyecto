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

namespace General.GUI.DETALLE_PEDIDO
{
    public partial class frmGestionDetallePedido : Form
    {
        private static CLS.Producto _producto = null;
        private static CLS.Proveedor _proveedor = null;
        public frmGestionDetallePedido()
        {
            InitializeComponent();
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
        private void frmGestionDetallePedido_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Session.Instancia.usuario;
            lblRol.Text = Session.Instancia.rol;
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
            if (dtgCompra.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dtgCompra.Rows)
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

        private void btnCrearPedido_Click(object sender, EventArgs e)
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

            decimal precioventa = 0;
            decimal subtotal = 0;
            if (!decimal.TryParse(_producto.PrecioVenta, out precioventa))
            {
                MessageBox.Show("Error al convertir internamente el tipo de moneda - Precio Venta\nEjemplo Formato ##.##", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            fila.CreateCells(dtgCompra);
            fila.Cells[0].Value = idproducto; // Asigna el valor del TextBox a la primera celda de la fila
            fila.Cells[1].Value = nombre;
            fila.Cells[2].Value = precioVenta;
            fila.Cells[3].Value = codBarras;
            fila.Cells[4].Value = cantidad;
            fila.Cells[5].Value = precioUnidad;

            // Agrega la fila al DataGridView
            dtgCompra.Rows.Add(fila);

            // Limpia el TextBox después de agregar los datos
            txtCodigoB.Text = string.Empty;

            calcularTotal();
            limpiar();
            calcularTotalProductos();
        }
        private void calcularTotal()
        {
            decimal total = 0;
            if (dtgCompra.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgCompra.Rows)
                {
                    total += Convert.ToDecimal((Convert.ToDecimal(row.Cells["precio_venta"].Value.ToString()) * Convert.ToInt32(row.Cells["cantidad"].Value.ToString())));
                }
            }
            txtTotalPagar.Text = total.ToString("0.00");
        }
        private void calcularTotalProductos()
        {
            int total = 0;
            if (dtgCompra.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgCompra.Rows)
                {
                    total += Convert.ToInt32(row.Cells["cantidad"].Value.ToString());
                }
            }
            txtTotalProductos.Text = total.ToString();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var Iform = new PROVEEDOR.frmVisorProveedor())
            {
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _proveedor = Iform._proveedor;
                    txtIdProveedor.BackColor = Color.Honeydew;
                    txtIdProveedor.Text = _proveedor.IdProveedor.ToString();
                    txtNombreProveedor.Text = _proveedor.Nombre.ToString();
                }
                else
                {
                    btnBuscarProveedor.Select();
                }
            }
        }
    }
}
