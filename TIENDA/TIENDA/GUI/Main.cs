using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataManager;
using SessionManager;
using General.GUI;

namespace TIENDA.GUI
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Session.Instancia.usuario;
            lblRol.Text = Session.Instancia.rol;

        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(frmGestionCliente.Name))
            {
                General.GUI.frmGestionCliente form1 = new General.GUI.frmGestionCliente();
                form1.ShowDialog();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void frmGestionEmpleado_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(frmGestionEmpleado.Name))
            {
                General.GUI.frmGestionEmpleado form1 = new General.GUI.frmGestionEmpleado();
                form1.ShowDialog();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void frmGestionProveedor_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(frmGestionProveedor.Name))
            {
                General.GUI.frmGestionProveedor form1 = new General.GUI.frmGestionProveedor();
                form1.ShowDialog();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }


        //private void frmGestionReporte_Click(object sender, EventArgs e)
        //{
        //    // Verificar si el usuario tiene permiso para acceder al formulario
        //    List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

        //    if (permisos.Contains(frmGestionReporte.Name))
        //    {
        //        Reporte.GUI.visorProducto form1 = new Reporte.GUI.visorProducto();
        //        form1.ShowDialog();
        //        // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
        //    }
        //    else
        //    {
        //        MessageBox.Show("No tienes permisos para acceder a este formulario.");
        //    }
        //}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir del programa?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar sesion?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Hide();
                CLS.AppManager l = new CLS.AppManager();
                l.Login();
            }
            else
            {

            }
        }

        private void frmGestionProducto_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(frmGestionProducto.Name))
            {
                General.GUI.PRODUCTO.frmGestionProducto form1 = new General.GUI.PRODUCTO.frmGestionProducto();
                form1.ShowDialog();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void frmGestionDetallePedido_Click_1(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(frmGestionDetallePedido.Name))
            {
                General.GUI.DETALLE_PEDIDO.frmGestionDetallePedido form1 = new General.GUI.DETALLE_PEDIDO.frmGestionDetallePedido();
                form1.ShowDialog();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void frmGestionUsuario_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(frmGestionUsuario.Name))
            {
                General.GUI.frmGestionUsuario form1 = new General.GUI.frmGestionUsuario();
                form1.ShowDialog();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void frmGestionDireccion_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(frmGestionDireccion.Name))
            {
                General.GUI.DIRECCION.frmGestionDireccion form1 = new General.GUI.DIRECCION.frmGestionDireccion();
                form1.ShowDialog();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void frmGestionVenta_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(frmGestionVenta.Name))
            {
                General.GUI.frmGestionVenta form1 = new General.GUI.frmGestionVenta();
                form1.ShowDialog();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void frmGestionPedidoProveedor_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(frmGestionPedidoProveedor.Name))
            {
                General.GUI.frmGestionPedidoProveedor form1 = new General.GUI.frmGestionPedidoProveedor();
                form1.ShowDialog();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void frmGestionDetalleVenta_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(frmGestionDetalleVenta.Name))
            {
                General.GUI.DETALLE_VENTA.frmGestionDetalleVenta form1 = new General.GUI.DETALLE_VENTA.frmGestionDetalleVenta();
                form1.ShowDialog();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void frmGestionReporte_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
            {
                // Crear e mostrar la ventana de configuración
                ConfigForm configForm = new ConfigForm();
                configForm.ShowDialog();
            }
    }
}
