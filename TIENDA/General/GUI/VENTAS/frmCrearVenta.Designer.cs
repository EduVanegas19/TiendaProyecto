
namespace General.GUI.VENTAS
{
    partial class frmCrearVenta
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtMontoCliente = new System.Windows.Forms.TextBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.txtTipoPago = new System.Windows.Forms.TextBox();
            this.txtIdEmp = new System.Windows.Forms.TextBox();
            this.crearTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(143, 92);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(200, 22);
            this.txtMonto.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(143, 129);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 22);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtMontoCliente
            // 
            this.txtMontoCliente.Location = new System.Drawing.Point(143, 171);
            this.txtMontoCliente.Name = "txtMontoCliente";
            this.txtMontoCliente.Size = new System.Drawing.Size(200, 22);
            this.txtMontoCliente.TabIndex = 3;
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(143, 215);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(200, 22);
            this.txtCambio.TabIndex = 4;
            // 
            // txtTipoPago
            // 
            this.txtTipoPago.Location = new System.Drawing.Point(143, 255);
            this.txtTipoPago.Name = "txtTipoPago";
            this.txtTipoPago.Size = new System.Drawing.Size(101, 22);
            this.txtTipoPago.TabIndex = 5;
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.Location = new System.Drawing.Point(143, 296);
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.Size = new System.Drawing.Size(101, 22);
            this.txtIdEmp.TabIndex = 6;
            // 
            // crearTicket
            // 
            this.crearTicket.Location = new System.Drawing.Point(216, 360);
            this.crearTicket.Name = "crearTicket";
            this.crearTicket.Size = new System.Drawing.Size(127, 42);
            this.crearTicket.TabIndex = 7;
            this.crearTicket.Text = "crear ticket";
            this.crearTicket.UseVisualStyleBackColor = true;
            this.crearTicket.Click += new System.EventHandler(this.crearTicket_Click);
            // 
            // frmCrearVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crearTicket);
            this.Controls.Add(this.txtIdEmp);
            this.Controls.Add(this.txtTipoPago);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.txtMontoCliente);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmCrearVenta";
            this.Text = "Crear Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtMontoCliente;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.TextBox txtTipoPago;
        private System.Windows.Forms.TextBox txtIdEmp;
        private System.Windows.Forms.Button crearTicket;
    }
}