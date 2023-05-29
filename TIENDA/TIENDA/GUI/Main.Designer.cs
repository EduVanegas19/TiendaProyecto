
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
            this.btnVentas = new System.Windows.Forms.PictureBox();
            this.btnClientes = new System.Windows.Forms.PictureBox();
            this.btnEmpleados = new System.Windows.Forms.PictureBox();
            this.btnProveedores = new System.Windows.Forms.PictureBox();
            this.Pedidos = new System.Windows.Forms.PictureBox();
            this.btnReportes = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReportes)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(632, 43);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Usuario
            // 
            this.Usuario.AccessibleName = "frmGestionUsuario";
            this.Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Usuario.Image")));
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(59, 39);
            this.Usuario.Text = "Usuario";
            this.Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Usuario.Click += new System.EventHandler(this.frmCrearUsuario_Click);
            // 
            // Ventas
            // 
            this.Ventas.AccessibleName = "frmGestionVenta";
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(53, 39);
            this.Ventas.Text = "Ventas";
            this.Ventas.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // Reportes
            // 
            this.Reportes.AccessibleName = "frmGestionReporte";
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(65, 39);
            this.Reportes.Text = "Reportes";
            this.Reportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // Clientes
            // 
            this.Clientes.AccessibleName = "frmGestionCliente";
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(61, 39);
            this.Clientes.Text = "Clientes";
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Empleados
            // 
            this.Empleados.AccessibleName = "frmGestionEmpleado";
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(77, 39);
            this.Empleados.Text = "Empleados";
            this.Empleados.Click += new System.EventHandler(this.Empleados_Click);
            // 
            // Proveedores
            // 
            this.Proveedores.AccessibleName = "frmGestionProveedor";
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(84, 39);
            this.Proveedores.Text = "Proveedores";
            this.Proveedores.Click += new System.EventHandler(this.Proveedores_Click);
            // 
            // PedidosProveedores
            // 
            this.PedidosProveedores.AccessibleName = "frmGestionPedidoProveedor";
            this.PedidosProveedores.Name = "PedidosProveedores";
            this.PedidosProveedores.Size = new System.Drawing.Size(129, 39);
            this.PedidosProveedores.Text = "Pedidos Proveedores";
            this.PedidosProveedores.Click += new System.EventHandler(this.PedidosProveedores_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(88, 39);
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleName = "btnSalir";
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 39);
            this.btnSalir.Text = "SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblRol});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(632, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 19);
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblRol
            // 
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(29, 19);
            this.lblRol.Text = "ROL";
            // 
            // btnVentas
            // 
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Location = new System.Drawing.Point(45, 83);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(100, 100);
            this.btnVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVentas.TabIndex = 5;
            this.btnVentas.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(184, 83);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(100, 100);
            this.btnClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClientes.TabIndex = 6;
            this.btnClientes.TabStop = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.Location = new System.Drawing.Point(327, 83);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(100, 100);
            this.btnEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmpleados.TabIndex = 7;
            this.btnEmpleados.TabStop = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.Location = new System.Drawing.Point(466, 83);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(100, 100);
            this.btnProveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProveedores.TabIndex = 8;
            this.btnProveedores.TabStop = false;
            // 
            // Pedidos
            // 
            this.Pedidos.Image = ((System.Drawing.Image)(resources.GetObject("Pedidos.Image")));
            this.Pedidos.Location = new System.Drawing.Point(128, 270);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(100, 100);
            this.Pedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pedidos.TabIndex = 9;
            this.Pedidos.TabStop = false;
            // 
            // btnReportes
            // 
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.Location = new System.Drawing.Point(409, 270);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(100, 100);
            this.btnReportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReportes.TabIndex = 10;
            this.btnReportes.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.Pedidos);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReportes)).EndInit();
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
        private System.Windows.Forms.PictureBox btnVentas;
        private System.Windows.Forms.PictureBox btnClientes;
        private System.Windows.Forms.PictureBox btnEmpleados;
        private System.Windows.Forms.PictureBox btnProveedores;
        private System.Windows.Forms.PictureBox Pedidos;
        private System.Windows.Forms.PictureBox btnReportes;
    }
}