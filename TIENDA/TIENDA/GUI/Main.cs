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

        private void frmCrearUsuario_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(Usuario.AccessibleName))
            {
                    General.GUI.frmGestionUsuario form1 = new General.GUI.frmGestionUsuario();
                    form1.Show();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(Ventas.AccessibleName))
            {
                General.GUI.DETALLE_VENTA.frmGestionDetalleVenta form1 = new General.GUI.DETALLE_VENTA.frmGestionDetalleVenta();
                form1.Show();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(Reportes.AccessibleName))
            {

                Reporte.GUI.visorClientes form1 = new Reporte.GUI.visorClientes();
                form1.Show();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(Clientes.AccessibleName))
            {
                General.GUI.frmGestionCliente form1 = new General.GUI.frmGestionCliente();
                form1.Show();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(Empleados.AccessibleName))
            {
                General.GUI.frmGestionEmpleado form1 = new General.GUI.frmGestionEmpleado();
                form1.Show();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void Proveedores_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(Proveedores.AccessibleName))
            {
                General.GUI.frmGestionProveedor form1 = new General.GUI.frmGestionProveedor();
                form1.Show();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void PedidosProveedores_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(PedidosProveedores.AccessibleName))
            {
                General.GUI.frmGestionPedidoProveedor form1 = new General.GUI.frmGestionPedidoProveedor();
                form1.Show();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

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

        public void btnCerrarSesion_Click(object sender, EventArgs e)
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void Productos_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(Productos.AccessibleName))
            {
                General.GUI.PRODUCTO.frmGestionProducto form1 = new General.GUI.PRODUCTO.frmGestionProducto();
                form1.Show();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void Direcciones_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario tiene permiso para acceder al formulario
            List<string> permisos = DBConsultas.ObtenerPermisosUsuario(Session.Instancia.id_usuario);

            if (permisos.Contains(Direcciones.AccessibleName))
            {
                General.GUI.DIRECCION.frmGestionDireccion form1 = new General.GUI.DIRECCION.frmGestionDireccion();
                form1.Show();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


























        //private void Main_Load(object sender, EventArgs e)
        //{
        //     MOSTRANDO MENU INTERACTIVO, ORDENADO DESDE LA BASE DE DATOS
        //    List<opciones> permisos_esperados = DBConsultas.ObtenerPermisos(idusuario);

        //    MenuStrip MiMenu = new MenuStrip();

        //    foreach (opciones objMenu in permisos_esperados)
        //    {
        //        ToolStripMenuItem menuPadre = new ToolStripMenuItem(objMenu.nombre);
        //        menuPadre.TextImageRelation = TextImageRelation.ImageAboveText;

        //        string rutaimagen = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../") + @objMenu.icono);

        //        menuPadre.Image = new Bitmap(rutaimagen);
        //        menuPadre.ImageScaling = ToolStripItemImageScaling.None;

        //        foreach (subopciones objSubMenu in objMenu.listaSubopciones)
        //        {
        //            ToolStripMenuItem menuHijo = new ToolStripMenuItem(objSubMenu.nombre, null, click_en_menu, objSubMenu.nombreFormulario);

        //            menuPadre.DropDownItems.Add(menuHijo);
        //        }


        //        MiMenu.Items.Add(menuPadre);
        //    }

        //    this.MainMenuStrip = MiMenu;
        //    Controls.Add(MiMenu);
        //}

        //private void click_en_menu(object sender, System.EventArgs e)
        //{
        //    ToolStripMenuItem menuSeleccionado = (ToolStripMenuItem)sender;

        //    Assembly asm =  Assembly.GetEntryAssembly();

        //    Type elemento = asm.GetType(asm.GetName().Name + "." + menuSeleccionado.Name);

        //    if (elemento == null)
        //    {
        //        MessageBox.Show("formulario no encontrado");
        //    }
        //    else
        //    {
        //        Form formularioCreado = (Form)Activator.CreateInstance(elemento);

        //        int encontrado = this.MdiChildren.Where(x => x.Name == formularioCreado.Name).ToList().Count();

        //        if (encontrado != 0)
        //        {
        //            ((Form)(this.MdiChildren.Where(x => x.Name == formularioCreado.Name).FirstOrDefault())).WindowState = FormWindowState.Normal;

        //            ((Form)(this.MdiChildren.Where(x => x.Name == formularioCreado.Name).FirstOrDefault())).Activate();
        //        }
        //        else
        //        {

        //            formularioCreado.MdiParent = this;
        //            formularioCreado.Show();
        //        }

        //        formularioCreado.MdiParent = this;
        //        formularioCreado.Show();
        //    }

        //}
    }
}
