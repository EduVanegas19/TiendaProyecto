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
    public partial class frmCrearDetalleVenta : Form
    {
        public frmCrearDetalleVenta()
        {
            InitializeComponent();
        }

        private void frmCrearDetalleVenta_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCrearDetalleVenta
            // 
            this.ClientSize = new System.Drawing.Size(1047, 491);
            this.Name = "frmCrearDetalleVenta";
            this.Text = "Crear Venta";
            this.Load += new System.EventHandler(this.frmCrearDetalleVenta_Load_1);
            this.ResumeLayout(false);

        }

        private void frmCrearDetalleVenta_Load_1(object sender, EventArgs e)
        {

        }
    }
}
