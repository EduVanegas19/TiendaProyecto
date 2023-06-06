using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.CLIENTES
{
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Cliente clien = new CLS.Cliente();
            //Sincronizar la entidad con la interfaz
            //clien.IdCliente = txtId.Text;
            //clien.Identificacion = txtIdentificacion.Text;
            //clien.Nombre = txtNombre.Text;
            //clien.Credito = txtCredito.Text;
            //clien.Estado = checkEstado.Checked.ToString();
            //clien.IdDireccion = txtDireccion.Text;
            ////Identificar la accion a realizar
            //if (txtId.TextLength > 0)
            //{
            //    //Realizar la operacion de actualizar
            //    if (clien.Actualizar())
            //    {
            //        MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("¡El registro no fue actualizado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //else
            //{
            //    //Realizar la operacion de insertar
            //    if (clien.Insertar())
            //    {
            //        MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("¡El registro no fue insertado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
        }
    }
}
