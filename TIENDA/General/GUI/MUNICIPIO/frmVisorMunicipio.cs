using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.MUNICIPIO
{
    public partial class frmVisorMunicipio : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.MUNICIPIOS();
                dtgMunicipio.AutoGenerateColumns = false;
                dtgMunicipio.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        public frmVisorMunicipio()
        {
            InitializeComponent();
        }

        private void frmVisorMunicipio_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public CLS.Municipio _Municipio { get; set; }
        private void dtgDireccion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dtgMunicipio.Columns[e.ColumnIndex].Name == "btnSeleccionar")
                {
                    _Municipio = new CLS.Municipio()
                    {
                        IdMunicipio = dtgMunicipio.Rows[index].Cells["id_municipio"].Value.ToString(),
                        Nombre = dtgMunicipio.Rows[index].Cells["municipio"].Value.ToString()
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }

        }
    }
}
