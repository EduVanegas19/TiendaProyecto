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
        //Le decimos que cargue datos despues de cerrar el frmEditor
        private void FormEditor_DataUpdated(object sender, EventArgs e)
        {
            CargarDatos();
        }


        private void CargarDatos()
        {
            DataTable area = new DataTable();
            try
            {
                area = DataManager.DBConsultas.AREAS();
                dtgArea.AutoGenerateColumns = false;
                dtgArea.DataSource = area;
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
                else if (dtgArea.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CLS.Area area = new CLS.Area();
                        area.IdArea = dtgArea.CurrentRow.Cells["id_area"].Value.ToString().ToUpper(); ;
                        //Realizar la operacion de Eliminar
                        if (area.Eliminar())
                        {
                            MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("¡El registro no fue eliminado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEditarArea f = new frmEditarArea();
            //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
            f.DataUpdated += FormEditor_DataUpdated;
            f.ShowDialog();
        }
    }
}
