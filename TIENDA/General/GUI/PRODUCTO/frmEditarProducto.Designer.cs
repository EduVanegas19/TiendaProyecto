
namespace General.GUI.PRODUCTO
{
    partial class frmEditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarProducto));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.lblVisor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cbbArea = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioUni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigoB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkControl = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.lblVisor);
            this.panel3.Location = new System.Drawing.Point(13, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 75);
            this.panel3.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "*logo*";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(487, 5);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 62);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(571, 9);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 58);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 10;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblVisor
            // 
            this.lblVisor.AutoSize = true;
            this.lblVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.Location = new System.Drawing.Point(100, 18);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(266, 36);
            this.lblVisor.TabIndex = 0;
            this.lblVisor.Text = "MODO LECTURA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkControl);
            this.panel1.Controls.Add(this.cbbUnidadMedida);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.dtpFechaVencimiento);
            this.panel1.Controls.Add(this.dtpFechaIngreso);
            this.panel1.Controls.Add(this.cbbArea);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtMedida);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrecioVenta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPrecioUni);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtCodigoB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtIdCliente);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(13, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 706);
            this.panel1.TabIndex = 16;
            // 
            // cbbUnidadMedida
            // 
            this.cbbUnidadMedida.FormattingEnabled = true;
            this.cbbUnidadMedida.Location = new System.Drawing.Point(186, 480);
            this.cbbUnidadMedida.Name = "cbbUnidadMedida";
            this.cbbUnidadMedida.Size = new System.Drawing.Size(121, 24);
            this.cbbUnidadMedida.TabIndex = 40;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(263, 632);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 60);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(50, 630);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(67, 62);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 38;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(186, 390);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(141, 22);
            this.dtpFechaVencimiento.TabIndex = 37;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(186, 347);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(141, 22);
            this.dtpFechaIngreso.TabIndex = 36;
            // 
            // cbbArea
            // 
            this.cbbArea.FormattingEnabled = true;
            this.cbbArea.Location = new System.Drawing.Point(186, 529);
            this.cbbArea.Name = "cbbArea";
            this.cbbArea.Size = new System.Drawing.Size(121, 24);
            this.cbbArea.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(50, 529);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "Area:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Unidad medida:";
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(186, 436);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(141, 22);
            this.txtMedida.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 439);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Medida:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Fecha vencimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Fecha ingreso:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 309);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(141, 22);
            this.txtNombre.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nombre: ";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(186, 266);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(141, 22);
            this.txtCantidad.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(186, 223);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(141, 22);
            this.txtPrecioVenta.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Precio venta:";
            // 
            // txtPrecioUni
            // 
            this.txtPrecioUni.Location = new System.Drawing.Point(186, 181);
            this.txtPrecioUni.Name = "txtPrecioUni";
            this.txtPrecioUni.Size = new System.Drawing.Size(141, 22);
            this.txtPrecioUni.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Precio unidad:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(186, 57);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(64, 22);
            this.txtId.TabIndex = 17;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(186, 142);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(141, 22);
            this.txtDescripcion.TabIndex = 15;
            // 
            // txtCodigoB
            // 
            this.txtCodigoB.Location = new System.Drawing.Point(186, 99);
            this.txtCodigoB.Name = "txtCodigoB";
            this.txtCodigoB.Size = new System.Drawing.Size(141, 22);
            this.txtCodigoB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descripcion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Codigo Barras:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.AutoSize = true;
            this.txtIdCliente.Location = new System.Drawing.Point(76, 60);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(0, 17);
            this.txtIdCliente.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "CLIENTES";
            // 
            // checkControl
            // 
            this.checkControl.AutoSize = true;
            this.checkControl.Location = new System.Drawing.Point(558, 57);
            this.checkControl.Name = "checkControl";
            this.checkControl.Size = new System.Drawing.Size(18, 17);
            this.checkControl.TabIndex = 41;
            this.checkControl.UseVisualStyleBackColor = true;
            this.checkControl.Visible = false;
            // 
            // frmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 799);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmEditarProducto";
            this.Text = "Editar Producto";
            this.Load += new System.EventHandler(this.frmEditarProducto_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtCodigoB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtIdCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPrecioUni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnEditar;
        public System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.PictureBox btnGuardar;
        public System.Windows.Forms.ComboBox cbbArea;
        public System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        public System.Windows.Forms.ComboBox cbbUnidadMedida;
        public System.Windows.Forms.CheckBox checkControl;
    }
}