
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
            this.frmEditarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.noDebeNada = new System.Windows.Forms.ToolStripMenuItem();
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
            this.frmEditarUsuario,
            this.noDebeNada});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 48);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Usuario
            // 
            this.Usuario.AccessibleName = "frmCrearUsuario";
            this.Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Usuario.Image")));
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(73, 44);
            this.Usuario.Text = "Usuario";
            this.Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Usuario.Click += new System.EventHandler(this.frmCrearUsuario_Click);
            // 
            // frmEditarUsuario
            // 
            this.frmEditarUsuario.Name = "frmEditarUsuario";
            this.frmEditarUsuario.Size = new System.Drawing.Size(135, 44);
            this.frmEditarUsuario.Text = "frmEditarUsuario";
            // 
            // noDebeNada
            // 
            this.noDebeNada.Name = "noDebeNada";
            this.noDebeNada.Size = new System.Drawing.Size(115, 44);
            this.noDebeNada.Text = "no debe nada";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblRol});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuario.Image")));
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(95, 24);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
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
        private System.Windows.Forms.ToolStripMenuItem frmEditarUsuario;
        private System.Windows.Forms.ToolStripMenuItem noDebeNada;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
    }
}