using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.AREA
{
    public partial class frmVisorArea : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.AREAS();
                dtgArea.AutoGenerateColumns = false;
                dtgArea.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        public frmVisorArea()
        {
            InitializeComponent();
        }

        private void frmVisorArea_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public CLS.Area _Area { get; set; }
        private void dtgArea_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dtgArea.Columns[e.ColumnIndex].Name == "btnSeleccionar")
                {
                    _Area = new CLS.Area()
                    {
                        IdArea = dtgArea.Rows[index].Cells["id_area"].Value.ToString(),
                        Nombre = dtgArea.Rows[index].Cells["area"].Value.ToString()
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }
    }
}
