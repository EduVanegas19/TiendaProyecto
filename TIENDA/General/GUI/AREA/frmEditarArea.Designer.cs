﻿
namespace General.GUI.AREA
{
    partial class frmEditarArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarArea));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.lblVisor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.control = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.lblVisor);
            this.panel3.Location = new System.Drawing.Point(13, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 75);
            this.panel3.TabIndex = 19;
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
            this.btnEliminar.Location = new System.Drawing.Point(571, 9);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 58);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblVisor
            // 
            this.lblVisor.AutoSize = true;
            this.lblVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.Location = new System.Drawing.Point(205, 18);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(223, 36);
            this.lblVisor.TabIndex = 0;
            this.lblVisor.Text = "NUEVA AREA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.control);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtArea);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtIdCliente);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(13, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 456);
            this.panel1.TabIndex = 18;
            // 
            // control
            // 
            this.control.AutoSize = true;
            this.control.Location = new System.Drawing.Point(507, 35);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(0, 17);
            this.control.TabIndex = 21;
            this.control.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(275, 214);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 60);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(198, 57);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(64, 22);
            this.txtId.TabIndex = 17;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(198, 99);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(141, 22);
            this.txtArea.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Area:";
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
            this.label8.Location = new System.Drawing.Point(76, 62);
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
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "AREA:";
            // 
            // frmEditarArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 545);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmEditarArea";
            this.Text = "frmEditarArea";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditarArea_FormClosed);
            this.Load += new System.EventHandler(this.frmEditarArea_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label control;
        private System.Windows.Forms.PictureBox btnGuardar;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtIdCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}