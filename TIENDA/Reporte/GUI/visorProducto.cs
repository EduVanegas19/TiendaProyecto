using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporte.GUI
{
    public partial class visorProducto : Form
    {
        private void CargarReportes()
        {
            DataTable Datos = new DataTable();
            Reporte.REP.Productos oReporte = new REP.Productos();
            Datos = DataManager.DBConsultas.ReporteProductos();
            oReporte.SetDataSource(Datos);
            crvVisor.ReportSource = oReporte;
        }
        public visorProducto()
        {
            InitializeComponent();
        }

        private void visorProducto_Load(object sender, EventArgs e)
        {
            CargarReportes();
        }
    }
}
