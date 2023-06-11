using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.ROLES
{
    public partial class frmVisorRol : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.ROLES();
                dtgRoles.AutoGenerateColumns = false;
                dtgRoles.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        public frmVisorRol()
        {
            InitializeComponent();
        }

        private void frmVisorRol_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public CLS.Roles _roles { get; set; }
        private void dtgMunicipio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                if (dtgRoles.Columns[e.ColumnIndex].Name == "btnSeleccionar")
                {
                    _roles = new CLS.Roles()
                    {
                        IdRol = dtgRoles.Rows[index].Cells["id_rol"].Value.ToString(),
                        Rol = dtgRoles.Rows[index].Cells["rol"].Value.ToString()
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }
    }
}
