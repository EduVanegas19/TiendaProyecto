using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.UNIDAD_MEDIDA
{
    public partial class frmVisorUnidadMedida : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.UNIDAD_MEDIDA();
                dtgUnidadMedida.AutoGenerateColumns = false;
                dtgUnidadMedida.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        public frmVisorUnidadMedida()
        {
            InitializeComponent();
        }

        public CLS.Unidad_medida _Unidad { get; set; }
        private void dtgUnidadMedida_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dtgUnidadMedida.Columns[e.ColumnIndex].Name == "btnSeleccionar")
                {
                    _Unidad = new CLS.Unidad_medida()
                    {
                        IdUnidadMedida = dtgUnidadMedida.Rows[index].Cells["id_unidadmedida"].Value.ToString(),
                        UnidadMedida = dtgUnidadMedida.Rows[index].Cells["unidad_medida"].Value.ToString()
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }

        private void frmVisorUnidadMedida_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
