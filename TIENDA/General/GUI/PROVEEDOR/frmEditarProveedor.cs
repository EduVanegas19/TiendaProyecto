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
        //Evento que se activara cuando se cierre el formulario y se actualicen los datos de datagrid gestion
        public event EventHandler DataUpdated;
        public frmEditarProveedor()
        {
            InitializeComponent();
        }

        private void frmEditarProveedor_Load(object sender, EventArgs e)
        {
            //Le digo que si el checked es flase, se muestre como nuevo proveedor
            if (checkControl.Checked != false)
            {
                txtProveedor.ReadOnly = false;
                txtNumDoc.ReadOnly = false;
                checkLab.Enabled = true;
                btnGuardar.Visible = true;
                btnEliminar.Visible = false;
                btnEditar.Visible = false;

                lblVisor.Text = "NUEVO PROVEEDOR";
            }
            // Y si el checked es true, entonces que se muestre como visor de lectura
            else
            {
                txtProveedor.ReadOnly = true;
                txtNumDoc.ReadOnly = true;
                checkLab.Enabled = false;
                btnGuardar.Visible = false;
                btnEliminar.Visible = false;
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Proveedor prov = new CLS.Proveedor();
            //Sincronizar la entidad con la interfaz
            int estado = 1;
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
            txtProveedor.ReadOnly = false;
            txtNumDoc.ReadOnly = false;
            checkLab.Enabled = true;
            btnGuardar.Visible = true;
            btnEliminar.Visible = true;

            lblVisor.Text = "MODO EDICION";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmEditarProveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se activa el evento declarado al principio y le notifica al frmGestion que se han actualizado los datos
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Proveedor proveedor = new CLS.Proveedor();
                proveedor.IdProveedor = txtId.Text ;
                //Realizar la operacion de Eliminar
                if (proveedor.Eliminar())
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
