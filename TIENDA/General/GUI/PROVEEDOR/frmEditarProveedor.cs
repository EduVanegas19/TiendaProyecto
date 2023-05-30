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
    public partial class frmEditarProveedor : Form
    {
        public frmEditarProveedor()
        {
            InitializeComponent();
        }

        private void frmEditarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Proveedor prov = new CLS.Proveedor();
            //Sincronizar la entidad con la interfaz
            prov.IdProveedor = textBox1.Text;
            prov.Nombre = txtProveedor.Text;
            prov.NumeroDocumento = txtNumDoc.Text;
            prov.EsLaboratorio = checkLab.Checked.ToString();
            //Identificar la accion a realizar
            if (textBox1.TextLength > 0)
            {
                //Realizar la operacion de actualizar
                if (prov.Actualizar())
                {
                    MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue actualizado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkLab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNumDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
