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
                    frmCrearUsuario form1 = new frmCrearUsuario();
                    form1.Show();
                // Agrega más condiciones para cada formulario que desees abrir según los permisos del usuario
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a este formulario.");
            }
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
