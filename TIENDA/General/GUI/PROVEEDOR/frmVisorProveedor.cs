using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.PROVEEDOR
{
    public partial class frmVisorProveedor : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.PROVEEDORES();
                dtgProveedores.AutoGenerateColumns = false;
                dtgProveedores.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        public frmVisorProveedor()
        {
            InitializeComponent();
        }

        private void frmVisorProveedor_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public CLS.Proveedor _proveedor { get; set; }
        private void dtgProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dtgProveedores.Columns[e.ColumnIndex].Name == "btnSeleccionar")
                {
                    _proveedor = new CLS.Proveedor()
                    {
                        IdProveedor = dtgProveedores.Rows[index].Cells["id_proveedor"].Value.ToString(),
                        Nombre = dtgProveedores.Rows[index].Cells["proveedor"].Value.ToString(),
                        NumeroDocumento = dtgProveedores.Rows[index].Cells["numero_documento"].Value.ToString(),
                        EsLaboratorio = dtgProveedores.Rows[index].Cells["esLaboratorio"].Value.ToString()

                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }
    }
}
