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
    public partial class frmEditarUnidadMedida : Form
    {
        //Evento que se activara cuando se cierre el formulario y se actualicen los datos de datagrid gestion
        public event EventHandler DataUpdated;
        public frmEditarUnidadMedida()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditarUnidadMedida_Load(object sender, EventArgs e)
        {

        }

        private void frmEditarUnidadMedida_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se activa el evento declarado al principio y le notifica al frmGestion que se han actualizado los datos
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Unidad_medida prov = new CLS.Unidad_medida();
            //Sincronizar la entidad con la interfaz
            prov.IdUnidadMedida = txtId.Text;
            prov.UnidadMedida = txtUnidadMedida.Text;
            //Realizar la operacion de insertar
            if (prov.Insertar())
            {
                MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("¡El registro no fue insertado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
