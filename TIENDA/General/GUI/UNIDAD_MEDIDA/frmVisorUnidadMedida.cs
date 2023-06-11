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
        //Le decimos que cargue datos despues de cerrar el frmEditor
        private void FormEditor_DataUpdated(object sender, EventArgs e)
        {
            CargarDatos();
        }

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
                else if (dtgUnidadMedida.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CLS.Unidad_medida unidad = new CLS.Unidad_medida();
                        unidad.IdUnidadMedida = dtgUnidadMedida.CurrentRow.Cells["id_unidadmedida"].Value.ToString().ToUpper(); ;
                        //Realizar la operacion de Eliminar
                        if (unidad.Eliminar())
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

        private void frmVisorUnidadMedida_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEditarUnidadMedida f = new frmEditarUnidadMedida();
            //establecer la suscripción al evento 'DataUpdated' del frmEditor con actualizacion de datos
            f.DataUpdated += FormEditor_DataUpdated;
            f.ShowDialog();
        }
    }
}
