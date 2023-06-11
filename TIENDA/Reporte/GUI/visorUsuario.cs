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
    public partial class visorUsuario : Form
    {
        private void CargarReportes()
        {
            DataTable Datos = new DataTable();
            Reporte.REP.Usuarios oReporte = new REP.Usuarios();
            Datos = DataManager.DBConsultas.ReporteUsuarios();
            oReporte.SetDataSource(Datos);
            crvVisor.ReportSource = oReporte;
        }
        public visorUsuario()
        {
            InitializeComponent();
        }

        private void visorUsuario_Load(object sender, EventArgs e)
        {
            CargarReportes();
        }
    }
}
