
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
            this.btnPedidos = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnVentas = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frmGestionCliente = new System.Windows.Forms.PictureBox();
            this.frmGestionEmpleado = new System.Windows.Forms.PictureBox();
            this.frmGestionProveedor = new System.Windows.Forms.PictureBox();
            this.frmGestionPedidoProveedor = new System.Windows.Forms.PictureBox();
            this.frmGestionReporte = new System.Windows.Forms.PictureBox();
            this.frmGestionDetallePedido = new System.Windows.Forms.PictureBox();
            this.frmGestionDetalleVenta = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.frmGestionUsuario = new System.Windows.Forms.PictureBox();
            this.frmGestionVenta = new System.Windows.Forms.PictureBox();
            this.frmGestionDireccion = new System.Windows.Forms.PictureBox();
            this.frmGestionProducto = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
            this.btnPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVentas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionPedidoProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionDetallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPedidos.BackgroundImage")));
            this.btnPedidos.Controls.Add(this.btnConfig);
            this.btnPedidos.Controls.Add(this.btnSalir);
            this.btnPedidos.Controls.Add(this.btnCerrarSesion);
            this.btnPedidos.Controls.Add(this.frmGestionProducto);
            this.btnPedidos.Controls.Add(this.frmGestionDireccion);
            this.btnPedidos.Controls.Add(this.frmGestionVenta);
            this.btnPedidos.Controls.Add(this.frmGestionUsuario);
            this.btnPedidos.Controls.Add(this.pictureBox3);
            this.btnPedidos.Controls.Add(this.frmGestionDetalleVenta);
            this.btnPedidos.Controls.Add(this.frmGestionDetallePedido);
            this.btnPedidos.Controls.Add(this.frmGestionReporte);
            this.btnPedidos.Controls.Add(this.frmGestionPedidoProveedor);
            this.btnPedidos.Controls.Add(this.frmGestionProveedor);
            this.btnPedidos.Controls.Add(this.frmGestionEmpleado);
            this.btnPedidos.Controls.Add(this.frmGestionCliente);
            this.btnPedidos.Controls.Add(this.btnVentas);
            this.btnPedidos.Location = new System.Drawing.Point(0, 56);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(921, 482);
            this.btnPedidos.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(838, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 50);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 25;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Location = new System.Drawing.Point(-103, -63);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(100, 100);
            this.btnVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVentas.TabIndex = 11;
            this.btnVentas.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblRol});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(921, 24);
            this.statusStrip1.TabIndex = 14;
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
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 53);
            this.panel1.TabIndex = 15;
            // 
            // frmGestionCliente
            // 
            this.frmGestionCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmGestionCliente.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionCliente.Image")));
            this.frmGestionCliente.Location = new System.Drawing.Point(92, 63);
            this.frmGestionCliente.Name = "frmGestionCliente";
            this.frmGestionCliente.Size = new System.Drawing.Size(100, 100);
            this.frmGestionCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionCliente.TabIndex = 12;
            this.frmGestionCliente.TabStop = false;
            this.frmGestionCliente.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // frmGestionEmpleado
            // 
            this.frmGestionEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmGestionEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionEmpleado.Image")));
            this.frmGestionEmpleado.Location = new System.Drawing.Point(239, 63);
            this.frmGestionEmpleado.Name = "frmGestionEmpleado";
            this.frmGestionEmpleado.Size = new System.Drawing.Size(100, 100);
            this.frmGestionEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionEmpleado.TabIndex = 13;
            this.frmGestionEmpleado.TabStop = false;
            this.frmGestionEmpleado.Click += new System.EventHandler(this.frmGestionEmpleado_Click);
            // 
            // frmGestionProveedor
            // 
            this.frmGestionProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmGestionProveedor.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionProveedor.Image")));
            this.frmGestionProveedor.Location = new System.Drawing.Point(403, 63);
            this.frmGestionProveedor.Name = "frmGestionProveedor";
            this.frmGestionProveedor.Size = new System.Drawing.Size(100, 100);
            this.frmGestionProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionProveedor.TabIndex = 14;
            this.frmGestionProveedor.TabStop = false;
            this.frmGestionProveedor.Click += new System.EventHandler(this.frmGestionProveedor_Click);
            // 
            // frmGestionPedidoProveedor
            // 
            this.frmGestionPedidoProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmGestionPedidoProveedor.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionPedidoProveedor.Image")));
            this.frmGestionPedidoProveedor.Location = new System.Drawing.Point(92, 242);
            this.frmGestionPedidoProveedor.Name = "frmGestionPedidoProveedor";
            this.frmGestionPedidoProveedor.Size = new System.Drawing.Size(100, 100);
            this.frmGestionPedidoProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionPedidoProveedor.TabIndex = 15;
            this.frmGestionPedidoProveedor.TabStop = false;
            this.frmGestionPedidoProveedor.Click += new System.EventHandler(this.frmGestionPedidoProveedor_Click);
            // 
            // frmGestionReporte
            // 
            this.frmGestionReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmGestionReporte.Enabled = false;
            this.frmGestionReporte.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionReporte.Image")));
            this.frmGestionReporte.Location = new System.Drawing.Point(92, 371);
            this.frmGestionReporte.Name = "frmGestionReporte";
            this.frmGestionReporte.Size = new System.Drawing.Size(100, 100);
            this.frmGestionReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionReporte.TabIndex = 16;
            this.frmGestionReporte.TabStop = false;
            this.frmGestionReporte.Visible = false;
            this.frmGestionReporte.Click += new System.EventHandler(this.frmGestionReporte_Click);
            // 
            // frmGestionDetallePedido
            // 
            this.frmGestionDetallePedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.frmGestionDetallePedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmGestionDetallePedido.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionDetallePedido.Image")));
            this.frmGestionDetallePedido.Location = new System.Drawing.Point(403, 242);
            this.frmGestionDetallePedido.Name = "frmGestionDetallePedido";
            this.frmGestionDetallePedido.Size = new System.Drawing.Size(100, 100);
            this.frmGestionDetallePedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionDetallePedido.TabIndex = 17;
            this.frmGestionDetallePedido.TabStop = false;
            this.frmGestionDetallePedido.Click += new System.EventHandler(this.frmGestionDetallePedido_Click_1);
            // 
            // frmGestionDetalleVenta
            // 
            this.frmGestionDetalleVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.frmGestionDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmGestionDetalleVenta.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionDetalleVenta.Image")));
            this.frmGestionDetalleVenta.Location = new System.Drawing.Point(559, 242);
            this.frmGestionDetalleVenta.Name = "frmGestionDetalleVenta";
            this.frmGestionDetalleVenta.Size = new System.Drawing.Size(100, 100);
            this.frmGestionDetalleVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionDetalleVenta.TabIndex = 18;
            this.frmGestionDetalleVenta.TabStop = false;
            this.frmGestionDetalleVenta.Click += new System.EventHandler(this.frmGestionDetalleVenta_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(239, 371);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // frmGestionUsuario
            // 
            this.frmGestionUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.frmGestionUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmGestionUsuario.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionUsuario.Image")));
            this.frmGestionUsuario.Location = new System.Drawing.Point(559, 63);
            this.frmGestionUsuario.Name = "frmGestionUsuario";
            this.frmGestionUsuario.Size = new System.Drawing.Size(100, 100);
            this.frmGestionUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionUsuario.TabIndex = 20;
            this.frmGestionUsuario.TabStop = false;
            this.frmGestionUsuario.Click += new System.EventHandler(this.frmGestionUsuario_Click);
            // 
            // frmGestionVenta
            // 
            this.frmGestionVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.frmGestionVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmGestionVenta.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionVenta.Image")));
            this.frmGestionVenta.Location = new System.Drawing.Point(706, 242);
            this.frmGestionVenta.Name = "frmGestionVenta";
            this.frmGestionVenta.Size = new System.Drawing.Size(100, 100);
            this.frmGestionVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionVenta.TabIndex = 21;
            this.frmGestionVenta.TabStop = false;
            this.frmGestionVenta.Click += new System.EventHandler(this.frmGestionVenta_Click);
            // 
            // frmGestionDireccion
            // 
            this.frmGestionDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.frmGestionDireccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmGestionDireccion.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionDireccion.Image")));
            this.frmGestionDireccion.Location = new System.Drawing.Point(706, 63);
            this.frmGestionDireccion.Name = "frmGestionDireccion";
            this.frmGestionDireccion.Size = new System.Drawing.Size(100, 100);
            this.frmGestionDireccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionDireccion.TabIndex = 22;
            this.frmGestionDireccion.TabStop = false;
            this.frmGestionDireccion.Click += new System.EventHandler(this.frmGestionDireccion_Click);
            // 
            // frmGestionProducto
            // 
            this.frmGestionProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.frmGestionProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frmGestionProducto.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionProducto.Image")));
            this.frmGestionProducto.Location = new System.Drawing.Point(239, 242);
            this.frmGestionProducto.Name = "frmGestionProducto";
            this.frmGestionProducto.Size = new System.Drawing.Size(100, 100);
            this.frmGestionProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionProducto.TabIndex = 23;
            this.frmGestionProducto.TabStop = false;
            this.frmGestionProducto.Click += new System.EventHandler(this.frmGestionProducto_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(677, 405);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(50, 50);
            this.btnConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConfig.TabIndex = 26;
            this.btnConfig.TabStop = false;
            this.btnConfig.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(756, 405);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(50, 50);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSesion.TabIndex = 24;
            this.btnCerrarSesion.TabStop = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPedidos);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Main_Load);
            this.btnPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVentas)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionPedidoProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel btnPedidos;
        private System.Windows.Forms.PictureBox btnVentas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnConfig;
        private System.Windows.Forms.PictureBox btnCerrarSesion;
        private System.Windows.Forms.PictureBox frmGestionProducto;
        private System.Windows.Forms.PictureBox frmGestionDireccion;
        private System.Windows.Forms.PictureBox frmGestionVenta;
        private System.Windows.Forms.PictureBox frmGestionUsuario;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox frmGestionDetalleVenta;
        private System.Windows.Forms.PictureBox frmGestionDetallePedido;
        private System.Windows.Forms.PictureBox frmGestionReporte;
        private System.Windows.Forms.PictureBox frmGestionPedidoProveedor;
        private System.Windows.Forms.PictureBox frmGestionProveedor;
        private System.Windows.Forms.PictureBox frmGestionEmpleado;
        private System.Windows.Forms.PictureBox frmGestionCliente;
    }
}