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

namespace General.GUI.DETALLE_VENTA
{
    public partial class frmGestionDetalleVenta : Form
    {
        private static CLS.Producto _producto = null;
        void limpiar()
        {
            txtCodigoB.Text = "";
            txtCantidad.Text = "";
            txtEstado.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }
        public frmGestionDetalleVenta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private bool producto_agregado()
        {
            bool respuesta = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataGridView1.Rows)
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

        //public List<Producto> CrearListaDeProductos(DataGridView dataGridView)
        //{
        //    List<Producto> productos = new List<Producto>();

        //    foreach (DataGridViewRow row in dataGridView.Rows)
        //    {
        //        // Obtener los valores de cada columna
        //        string nombre = row.Cells["producto"].Value.ToString();
        //        decimal cantidad = Convert.ToDecimal(row.Cells["cantidad"].Value);
        //        float cantidad = Convert.ToInt32(row.Cells["precio_venta"].Value);

        //        // Crear un objeto Producto y agregarlo a la lista
        //        Producto producto = new Producto
        //        {
        //            Nombre = nombre,
        //            Precio = precio,
        //            Cantidad = cantidad
        //        };

        //        productos.Add(producto);
        //    }

        //    return productos;
        //}

        private void frmGestionDetalleVenta_Load(object sender, EventArgs e)
        {

        }


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            using (var Iform = new PRODUCTO.frmEditarProducto())
            {
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _producto = Iform._Producto;
                    txtCodigoB.BackColor = Color.Honeydew;
                    txtCodigoB.Text = _producto.IdProducto.ToString();
                    txtNombre.Text = _producto.Nombre;
                    txtEstado.Text = _producto.Estado.ToString();
                    txtPrecio.Text = _producto.PrecioVenta;
                    txtCantidad.Select();
                }
                else
                {
                    txtCodigoB.Select();
                }
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
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

            if (txtCantidad.Value > _producto.Stock)
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
            string mensaje = string.Empty;

            // esto se agrega al dtgv
            dataGridView1.Rows.Add(new object[] {
                    _producto.IdProducto.ToString(),
                    _producto.Nombre,
                    txtCantidad.Value.ToString(),
                    precioventa.ToString("0.00"),

                });
            //int operaciones = CLS.Producto.Instancia.reducirStock(_producto.IdProducto, Convert.ToInt32(txtcantidad.Value.ToString()), out mensaje);

            //if (operaciones > 0)
            //{
            //    subtotal = Convert.ToDecimal(txtcantidad.Value.ToString()) * precioventa;

            //    dataGridView1.Rows.Add(new object[] {
            //        _producto.IdProducto.ToString(),
            //        _producto.Nombre,
            //        _producto.Descripcion,
            //        _producto.IdArea,
            //        _producto.Medida,
            //        txtCantidad.Value.ToString(),
            //        precioventa.ToString("0.00"),
            //        subtotal.ToString("0.00")
            //    });

            //    calcularTotal();

            //    _producto = null;
            //    txtcodproducto.Text = "";
            //    txtcodproducto.BackColor = Color.White;
            //    txtproducto.Text = "";
            //    txtstock.Text = "";
            //    txtprecioventa.Text = "";
            //    txtcantidad.Value = 1;
            //    txtcodproducto.Select();
            //}
            //else
            //{
            //    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void btnFactura_Click_1(object sender, EventArgs e)
        {
            frmGestionVenta f = new frmGestionVenta();
            f.ShowDialog();
        }
    }
}