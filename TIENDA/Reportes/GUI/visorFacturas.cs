using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes.GUI
{
    public partial class visorFacturas : Form
    {
        private void CargarReportes()
        {
            DataTable Datos = new DataTable();
            Reportes.TICKET.Ticket oReporte = new TICKET.Ticket();
            Datos = DataManager.DBConsultas.TICKET();
            oReporte.SetDataSource(Datos);
            crvVisor.ReportSource = oReporte;
        }
        public visorFacturas()
        {
            InitializeComponent();
        }
        private void visorFacturas_Load(object sender, EventArgs e)
        {
            CargarReportes();
            
        }
    }
}
