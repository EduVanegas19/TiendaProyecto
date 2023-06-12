using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class frmEditarUsuario : Form
    {
        //Evento que se activara cuando se cierre el formulario y se actualicen los datos de datagrid gestion
        public event EventHandler DataUpdated;
        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            //Le digo que si el checked es flase, se muestre como nuevo proveedor
            if (checkControl.Checked != false)
            {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;

                lblVisor.Text = "NUEVO USUARIO";
            }
            else
            {
                // Configurar los TextBox como no editables
                txtUsuario.ReadOnly = true;
                txtClave.ReadOnly = true;
                btnBuscarEmpleado.Visible = false;
                btnBuscarRol.Visible = false;
                //Combobox
                //DateTimePicker
                //PictureBox
                btnGuardar.Visible = false;
                //ChecKbox
            }
        }

        private void btnSali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se activa el evento declarado al principio y le notifica al frmGestion que se han actualizado los datos
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Usuario usuario = new CLS.Usuario();
                usuario.IdUsuario = txtIdUsuario.Text ;
                //Realizar la operacion de Eliminar
                if (usuario.Eliminar())
                {
                    MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue eliminado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Configurar los TextBox como no editables
            txtUsuario.ReadOnly = false;
            txtClave.ReadOnly = false;
            btnBuscarEmpleado.Visible = true;
            btnBuscarRol.Visible = true;
            //Combobox
            //DateTimePicker
            //PictureBox
            btnGuardar.Visible = true;

            lblVisor.Text = "EDICION USUARIO";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Creacion del objeto entidad
            CLS.Usuario usuario = new CLS.Usuario();
            //Sincronizar la entidad con la interfaz
            usuario.IdUsuario = txtIdUsuario.Text;
            usuario.Nombre = txtUsuario.Text;
            usuario.Clave = txtClave.Text;
            usuario.IdEmpleado = txtIdEmpleado.Text;
            usuario.IdRol = txtIdRol.Text;
            //Identificar la accion a realizar
            if (txtIdUsuario.TextLength > 0)
            {
                //Realizar la operacion de actualizar
                if (usuario.Actualizar())
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
                if (usuario.Insertar())
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

        private static CLS.Empleado _Empleado = null;
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            using (var Iform = new EMPLEADO.frmVisorEmpleado())
            {
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _Empleado = Iform._empleado;
                    txtIdEmpleado.BackColor = Color.Honeydew;
                    txtIdEmpleado.Text = _Empleado.IdEmpleado;
                    txtNombre.Text = _Empleado.Nombre;
                    txtApellido.Text = _Empleado.Apellido;
                }
            }
        }

        private static CLS.Roles _Rol = null;
        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            using (var Iform = new ROLES.frmVisorRol())
            {
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _Rol = Iform._roles;
                    txtIdRol.BackColor = Color.Honeydew;
                    txtIdRol.Text = _Rol.IdRol;
                    txtRol.Text = _Rol.Rol;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_CheckedChanged(object sender, EventArgs e)
        {
            if (btnVer.Checked != false)
            {
                txtClave.UseSystemPasswordChar = false;
            }
            else
            {
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
