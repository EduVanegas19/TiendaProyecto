
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
            this.Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.Direcciones = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Productos,
            this.Direcciones,
            this.btnCerrarSesion,
            this.btnSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(901, 48);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // Productos
            // 
            this.Productos.AccessibleName = "frmGestionProducto";
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(83, 44);
            this.Productos.Text = "Producto";
            this.Productos.Click += new System.EventHandler(this.Productos_Click);
            // 
            // Direcciones
            // 
            this.Direcciones.AccessibleName = "frmGestionDireccion";
            this.Direcciones.Name = "Direcciones";
            this.Direcciones.Size = new System.Drawing.Size(100, 44);
            this.Direcciones.Text = "Direcciones";
            this.Direcciones.Click += new System.EventHandler(this.Direcciones_Click);
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
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(901, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
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
            // btnVentas
            // 
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Location = new System.Drawing.Point(60, 102);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(133, 123);
            this.btnVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVentas.TabIndex = 5;
            this.btnVentas.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(245, 102);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(133, 123);
            this.btnClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClientes.TabIndex = 6;
            this.btnClientes.TabStop = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.Location = new System.Drawing.Point(436, 102);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(133, 123);
            this.btnEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmpleados.TabIndex = 7;
            this.btnEmpleados.TabStop = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.Location = new System.Drawing.Point(621, 102);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(133, 123);
            this.btnProveedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProveedores.TabIndex = 8;
            this.btnProveedores.TabStop = false;
            // 
            // Pedidos
            // 
            this.Pedidos.Image = ((System.Drawing.Image)(resources.GetObject("Pedidos.Image")));
            this.Pedidos.Location = new System.Drawing.Point(171, 332);
            this.Pedidos.Margin = new System.Windows.Forms.Padding(4);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(133, 123);
            this.Pedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pedidos.TabIndex = 9;
            this.Pedidos.TabStop = false;
            // 
            // btnReportes
            // 
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.Location = new System.Drawing.Point(545, 332);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(133, 123);
            this.btnReportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReportes.TabIndex = 10;
            this.btnReportes.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 558);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ToolStripMenuItem Productos;
        private System.Windows.Forms.ToolStripMenuItem Direcciones;
    }
}