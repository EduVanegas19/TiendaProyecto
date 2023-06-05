
namespace General.GUI.DIRECCION
{
    partial class frmEditarDireccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarDireccion));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.lblVisor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.txtPasaje = new System.Windows.Forms.TextBox();
            this.txtNumCasa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCanton = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaserio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbMunicipio = new System.Windows.Forms.ComboBox();
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
            this.panel1.Controls.Add(this.cbbMunicipio);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtCodigoPostal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtCaserio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCanton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtColonia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCalle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.checkEstado);
            this.panel1.Controls.Add(this.txtPasaje);
            this.panel1.Controls.Add(this.txtNumCasa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtIdCliente);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(13, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 558);
            this.panel1.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(182, 57);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(64, 22);
            this.txtId.TabIndex = 17;
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(182, 431);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(18, 17);
            this.checkEstado.TabIndex = 16;
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // txtPasaje
            // 
            this.txtPasaje.Location = new System.Drawing.Point(179, 142);
            this.txtPasaje.Name = "txtPasaje";
            this.txtPasaje.Size = new System.Drawing.Size(141, 22);
            this.txtPasaje.TabIndex = 15;
            // 
            // txtNumCasa
            // 
            this.txtNumCasa.Location = new System.Drawing.Point(182, 99);
            this.txtNumCasa.Name = "txtNumCasa";
            this.txtNumCasa.Size = new System.Drawing.Size(141, 22);
            this.txtNumCasa.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pasaje o Poligono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Numero de casa:";
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
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "DIRECCION:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(259, 482);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 60);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(53, 480);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(67, 62);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 19;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(179, 179);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(141, 22);
            this.txtCalle.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Calle:";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(179, 220);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(141, 22);
            this.txtColonia.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Colonia:";
            // 
            // txtCanton
            // 
            this.txtCanton.Location = new System.Drawing.Point(182, 262);
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.Size = new System.Drawing.Size(141, 22);
            this.txtCanton.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Canton:";
            // 
            // txtCaserio
            // 
            this.txtCaserio.Location = new System.Drawing.Point(182, 305);
            this.txtCaserio.Name = "txtCaserio";
            this.txtCaserio.Size = new System.Drawing.Size(141, 22);
            this.txtCaserio.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Caserio:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(182, 347);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(141, 22);
            this.txtCodigoPostal.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Codigo postal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Municipio:";
            // 
            // cbbMunicipio
            // 
            this.cbbMunicipio.FormattingEnabled = true;
            this.cbbMunicipio.Location = new System.Drawing.Point(182, 389);
            this.cbbMunicipio.Name = "cbbMunicipio";
            this.cbbMunicipio.Size = new System.Drawing.Size(121, 24);
            this.cbbMunicipio.TabIndex = 31;
            // 
            // frmEditarDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmEditarDireccion";
            this.Text = "Editar Direccion";
            this.Load += new System.EventHandler(this.frmEditarDireccion_Load);
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
        public System.Windows.Forms.CheckBox checkEstado;
        public System.Windows.Forms.TextBox txtPasaje;
        public System.Windows.Forms.TextBox txtNumCasa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtIdCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtCaserio;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCanton;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbbMunicipio;
    }
}