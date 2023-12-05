using CrystalDecisions.CrystalReports.Engine;
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
    public partial class VisorVenta : Form
    {
        private int _pIdOrden;
        private DateTime? _pfechaSeleccionada;

        public VisorVenta(int pIdOrden, DateTime? pfechaSeleccionada)
        {
            InitializeComponent();
            _pIdOrden = pIdOrden;
            _pfechaSeleccionada = pfechaSeleccionada;
        }
        private void CargarReportes()
        {
            
            DataTable Datos = new DataTable();
            Reporte.REP.Ventas oReporte = new REP.Ventas();
            Datos = DataManager.DBConsultas.LISTARVENTAOPCION(_pIdOrden,_pfechaSeleccionada);
            oReporte.SetDataSource(Datos);

            // Acceder al objeto de texto en el reporte
            TextObject textObject = oReporte.ReportDefinition.ReportObjects["Text3"] as TextObject;

            // Verificar que el objeto de texto existe
            if (textObject != null)
            {
                // Cambiar el contenido del objeto de texto
                switch (_pIdOrden)
                {
                    case 1:
                        textObject.Text = "Reporte de Ventas Ultimos Agregados";
                        break;
                    case 2:
                        textObject.Text = "Reporte de Ventas Primeros Agregados";
                        break;
                    case 3:
                        textObject.Text = "Reporte de Ventas Fecha Más Reciente";
                        break;
                    case 4:
                        textObject.Text = "Reporte de Ventas Fecha Más Antigua";
                        break;
                    case 5:
                        textObject.Text = "Reporte de Ventas Ultima Semana";
                        break;
                    case 6:
                        textObject.Text = "Reporte de Ventas Ultimo Mes";
                        break;
                    case 7:
                        textObject.Text = "Reporte de Ventas Ultimo Año";
                        break;
                    case 8:
                        // Formatear y mostrar la fecha en un formato específico
                        if (_pfechaSeleccionada.HasValue)
                        {
                            string formattedDate = _pfechaSeleccionada.Value.ToString("dd/MM/yyyy");
                            textObject.Text = "Reporte de Ventas Fecha Especifica: " + formattedDate;
                        }
                        else
                        {
                            textObject.Text = "Reporte de Ventas Fecha Especifica: Sin fecha";
                        }
                        // Cambiar el tamaño de la letra para el caso 8
                        textObject.ApplyFont(new Font("Arial", 17));
                        break;
                    default:
                        textObject.Text = "Reporte de Ventas"; // Un título genérico para cualquier otro caso
                        break;
                }
            }

            crystalReportViewer1.ReportSource = oReporte;


        }
        private void VisorVenta_Load(object sender, EventArgs e)
        {
            CargarReportes();
        }
    }
}
