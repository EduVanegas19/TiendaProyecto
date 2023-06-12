
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
            this.frmGestionReporte = new System.Windows.Forms.PictureBox();
            this.frmGestionDetallePedido = new System.Windows.Forms.PictureBox();
            this.frmGestionProveedor = new System.Windows.Forms.PictureBox();
            this.frmGestionEmpleado = new System.Windows.Forms.PictureBox();
            this.frmGestionCliente = new System.Windows.Forms.PictureBox();
            this.btnVentas = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionDetallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVentas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.White;
            this.btnPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPedidos.BackgroundImage")));
            this.btnPedidos.Controls.Add(this.frmGestionReporte);
            this.btnPedidos.Controls.Add(this.frmGestionDetallePedido);
            this.btnPedidos.Controls.Add(this.frmGestionProveedor);
            this.btnPedidos.Controls.Add(this.frmGestionEmpleado);
            this.btnPedidos.Controls.Add(this.frmGestionCliente);
            this.btnPedidos.Controls.Add(this.btnVentas);
            this.btnPedidos.Location = new System.Drawing.Point(0, 79);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(1228, 583);
            this.btnPedidos.TabIndex = 13;
            // 
            // frmGestionReporte
            // 
            this.frmGestionReporte.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionReporte.Image")));
            this.frmGestionReporte.Location = new System.Drawing.Point(455, 274);
            this.frmGestionReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.frmGestionReporte.Name = "frmGestionReporte";
            this.frmGestionReporte.Size = new System.Drawing.Size(133, 123);
            this.frmGestionReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionReporte.TabIndex = 16;
            this.frmGestionReporte.TabStop = false;
            this.frmGestionReporte.Click += new System.EventHandler(this.frmGestionReporte_Click);
            // 
            // frmGestionDetallePedido
            // 
            this.frmGestionDetallePedido.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionDetallePedido.Image")));
            this.frmGestionDetallePedido.Location = new System.Drawing.Point(163, 274);
            this.frmGestionDetallePedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.frmGestionDetallePedido.Name = "frmGestionDetallePedido";
            this.frmGestionDetallePedido.Size = new System.Drawing.Size(133, 123);
            this.frmGestionDetallePedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionDetallePedido.TabIndex = 15;
            this.frmGestionDetallePedido.TabStop = false;
            this.frmGestionDetallePedido.Click += new System.EventHandler(this.frmGestionDetallePedido_Click);
            // 
            // frmGestionProveedor
            // 
            this.frmGestionProveedor.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionProveedor.Image")));
            this.frmGestionProveedor.Location = new System.Drawing.Point(751, 53);
            this.frmGestionProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.frmGestionProveedor.Name = "frmGestionProveedor";
            this.frmGestionProveedor.Size = new System.Drawing.Size(133, 123);
            this.frmGestionProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionProveedor.TabIndex = 14;
            this.frmGestionProveedor.TabStop = false;
            this.frmGestionProveedor.Click += new System.EventHandler(this.frmGestionProveedor_Click);
            // 
            // frmGestionEmpleado
            // 
            this.frmGestionEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionEmpleado.Image")));
            this.frmGestionEmpleado.Location = new System.Drawing.Point(455, 53);
            this.frmGestionEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.frmGestionEmpleado.Name = "frmGestionEmpleado";
            this.frmGestionEmpleado.Size = new System.Drawing.Size(133, 123);
            this.frmGestionEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionEmpleado.TabIndex = 13;
            this.frmGestionEmpleado.TabStop = false;
            this.frmGestionEmpleado.Click += new System.EventHandler(this.frmGestionEmpleado_Click);
            // 
            // frmGestionCliente
            // 
            this.frmGestionCliente.Image = ((System.Drawing.Image)(resources.GetObject("frmGestionCliente.Image")));
            this.frmGestionCliente.Location = new System.Drawing.Point(163, 53);
            this.frmGestionCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.frmGestionCliente.Name = "frmGestionCliente";
            this.frmGestionCliente.Size = new System.Drawing.Size(133, 123);
            this.frmGestionCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frmGestionCliente.TabIndex = 12;
            this.frmGestionCliente.TabStop = false;
            this.frmGestionCliente.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // btnVentas
            // 
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Location = new System.Drawing.Point(-137, -78);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(133, 123);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1228, 30);
            this.statusStrip1.TabIndex = 14;
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
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 74);
            this.panel1.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1228, 695);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPedidos);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.btnPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmGestionCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVentas)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel btnPedidos;
        private System.Windows.Forms.PictureBox frmGestionReporte;
        private System.Windows.Forms.PictureBox frmGestionDetallePedido;
        private System.Windows.Forms.PictureBox frmGestionProveedor;
        private System.Windows.Forms.PictureBox frmGestionEmpleado;
        private System.Windows.Forms.PictureBox frmGestionCliente;
        private System.Windows.Forms.PictureBox btnVentas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
        private System.Windows.Forms.Panel panel1;
    }
}