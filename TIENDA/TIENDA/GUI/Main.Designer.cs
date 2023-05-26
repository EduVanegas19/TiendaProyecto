
namespace TIENDA.GUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.Ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Empleados = new System.Windows.Forms.ToolStripMenuItem();
            this.Proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.PedidosProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Usuario,
            this.Ventas,
            this.Reportes,
            this.Clientes,
            this.Empleados,
            this.Proveedores,
            this.PedidosProveedores,
            this.btnCerrarSesion,
            this.btnSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 48);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Usuario
            // 
            this.Usuario.AccessibleName = "frmGestionUsuario";
            this.Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Usuario.Image")));
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(73, 44);
            this.Usuario.Text = "Usuario";
            this.Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Usuario.Click += new System.EventHandler(this.frmCrearUsuario_Click);
            // 
            // Ventas
            // 
            this.Ventas.AccessibleName = "frmGestionVenta";
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(66, 44);
            this.Ventas.Text = "Ventas";
            this.Ventas.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // Reportes
            // 
            this.Reportes.AccessibleName = "frmGestionReporte";
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(82, 44);
            this.Reportes.Text = "Reportes";
            this.Reportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // Clientes
            // 
            this.Clientes.AccessibleName = "frmGestionCliente";
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(75, 44);
            this.Clientes.Text = "Clientes";
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Empleados
            // 
            this.Empleados.AccessibleName = "frmGestionEmpleado";
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(97, 44);
            this.Empleados.Text = "Empleados";
            this.Empleados.Click += new System.EventHandler(this.Empleados_Click);
            // 
            // Proveedores
            // 
            this.Proveedores.AccessibleName = "frmGestionProveedor";
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(105, 44);
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.Click += new System.EventHandler(this.Proveedores_Click);
            // 
            // PedidosProveedores
            // 
            this.PedidosProveedores.AccessibleName = "frmGestionPedidoProveedor";
            this.PedidosProveedores.Name = "PedidosProveedores";
            this.PedidosProveedores.Size = new System.Drawing.Size(161, 44);
            this.PedidosProveedores.Text = "Pedidos Proveedores";
            this.PedidosProveedores.Click += new System.EventHandler(this.PedidosProveedores_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(110, 44);
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleName = "btnSalir";
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 44);
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblRol});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(843, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 24);
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblRol
            // 
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(36, 24);
            this.lblRol.Text = "ROL";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.ToolStripMenuItem Ventas;
        private System.Windows.Forms.ToolStripMenuItem Reportes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
        private System.Windows.Forms.ToolStripMenuItem Clientes;
        private System.Windows.Forms.ToolStripMenuItem Empleados;
        private System.Windows.Forms.ToolStripMenuItem Proveedores;
        private System.Windows.Forms.ToolStripMenuItem PedidosProveedores;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripMenuItem btnCerrarSesion;
    }
}