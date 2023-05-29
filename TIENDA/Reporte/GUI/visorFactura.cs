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
    public partial class visorFactura : Form
    {
        private void CargarReportes()
        {
            DataTable Datos = new DataTable();
            Reporte.REP.Ticket oReporte = new REP.Ticket();
            Datos = DataManager.DBConsultas.TICKET();
            oReporte.SetDataSource(Datos);
            crvVisor.ReportSource = oReporte;
        }
        public visorFactura()
        {
            InitializeComponent();
        }

        private void visorFactura_Load(object sender, EventArgs e)
        {
            CargarReportes();
        }
    }
}
