using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.EMPLEADO
{
    public partial class frmVisorEmpleado : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.EMPLEADOS();
                dtgEmpleado.AutoGenerateColumns = false;
                dtgEmpleado.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        public frmVisorEmpleado()
        {
            InitializeComponent();
        }

        private void frmVisorEmpleado_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public CLS.Empleado _empleado { get; set; }
        private void dtgEmpleado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dtgEmpleado.Columns[e.ColumnIndex].Name == "btnSeleccionar")
                {
                    _empleado = new CLS.Empleado()
                    {
                        IdEmpleado = dtgEmpleado.Rows[index].Cells["id_empleado"].Value.ToString(),
                        Nombre = dtgEmpleado.Rows[index].Cells["nombre"].Value.ToString(),
                        Apellido = dtgEmpleado.Rows[index].Cells["apellido"].Value.ToString()
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }
    }
}
