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
            // Configurar los TextBox como no editables
            txtId.ReadOnly = true;
            txtProveedor.ReadOnly = true;
            txtNumDoc.ReadOnly = true;
            checkLab.Enabled = false;
            btnGuardar.Visible = false;
            btnEliminar.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Proveedor prov = new CLS.Proveedor();
            //Sincronizar la entidad con la interfaz
            prov.IdProveedor = txtId.Text;
            prov.Nombre = txtProveedor.Text;
            prov.NumeroDocumento = txtNumDoc.Text;
            prov.EsLaboratorio = checkLab.Checked.ToString();
            //Identificar la accion a realizar
            if (txtId.TextLength > 0)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Configurar los TextBox como editables
            txtId.ReadOnly = false;
            txtProveedor.ReadOnly = false;
            txtNumDoc.ReadOnly = false;
            checkLab.Enabled = true;
            btnGuardar.Visible = true;
            btnEliminar.Visible = true;

            lblVisor.Text = "MODO EDICION";
        }
    }
}
