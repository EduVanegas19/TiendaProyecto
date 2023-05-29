using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.VENTAS
{
    public partial class frmCrearVenta : Form
    {
        public frmCrearVenta()
        {
            InitializeComponent();
        }

        private void crearTicket_Click(object sender, EventArgs e)
        {
            CLS.Factura f = new CLS.Factura();
            f.Insertar();

            CLS.Detalle_factura df = new CLS.Detalle_factura();
            
        }
    }
}
