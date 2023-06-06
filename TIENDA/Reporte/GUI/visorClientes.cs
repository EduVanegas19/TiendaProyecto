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
    public partial class visorClientes : Form
    {
        private void CargarReportes()
        {
            DataTable Datos = new DataTable();
            Reporte.REP.Clientes oReporte = new REP.Clientes();
            Datos = DataManager.DBConsultas.ReporteClientes();
            oReporte.SetDataSource(Datos);
            crvVisor.ReportSource = oReporte;
        }
        public visorClientes()
        {
            InitializeComponent();
        }

        private void visorClientes_Load(object sender, EventArgs e)
        {
            CargarReportes();
        }
    }
}
