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
    public partial class visorEmpleado : Form
    {
        private void CargarReportes()
        {
            DataTable Datos = new DataTable();
            Reporte.REP.Empleados oReporte = new REP.Empleados();
            Datos = DataManager.DBConsultas.ReporteEmpleados();
            oReporte.SetDataSource(Datos);
            crvVisor.ReportSource = oReporte;
        }
        public visorEmpleado()
        {
            InitializeComponent();
        }

        private void visorEmpleado_Load(object sender, EventArgs e)
        {
            CargarReportes();
        }
    }
}
