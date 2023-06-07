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
    public partial class visorProveedor : Form
    {
        private void CargarReportes()
        {
            DataTable Datos = new DataTable();
            Reporte.REP.Proveedores oReporte = new REP.Proveedores();
            Datos = DataManager.DBConsultas.ReporteProveedores();
            oReporte.SetDataSource(Datos);
            crvVisor.ReportSource = oReporte;
        }
        public visorProveedor()
        {
            InitializeComponent();
        }

        private void visorProveedor_Load(object sender, EventArgs e)
        {
            CargarReportes();
        }
    }
}
