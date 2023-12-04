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
    public partial class frmDescuento : Form
    {
        // Propiedades para acceder a las variables temporales desde el formulario principal
        public decimal CantidadDescuento { get; private set; }
        public string RazonDescuento { get; private set; }

        public frmDescuento()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Cambiar DialogResult a Cancel cuando se cierra el formulario sin guardar
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRazon.Text))
            {
                MessageBox.Show("Ingrese la razón del descuento.");
                return;
            }

            // Obtener la cantidad y la razón del descuento
            CantidadDescuento = numDescuento.Value; // Obtener el valor del NumericUpDown
            RazonDescuento = txtRazon.Text;

            // Mensajes de depuración
            Console.WriteLine("CantidadDescuento: " + CantidadDescuento);
            Console.WriteLine("RazonDescuento: " + RazonDescuento);

            DialogResult = DialogResult.OK; // Cambiar DialogResult a OK cuando se guarda el descuento
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
