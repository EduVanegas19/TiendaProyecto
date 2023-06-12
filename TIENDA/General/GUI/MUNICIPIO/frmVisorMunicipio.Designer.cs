
namespace General.GUI.MUNICIPIO
{
    partial class frmVisorMunicipio
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
            this.dtgMunicipio = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMunicipio)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMunicipio
            // 
            this.dtgMunicipio.AllowUserToAddRows = false;
            this.dtgMunicipio.AllowUserToDeleteRows = false;
            this.dtgMunicipio.BackgroundColor = System.Drawing.Color.White;
            this.dtgMunicipio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgMunicipio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMunicipio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_municipio,
            this.municipio,
            this.id_departamento,
            this.estado});
            this.dtgMunicipio.Location = new System.Drawing.Point(12, 12);
            this.dtgMunicipio.MultiSelect = false;
            this.dtgMunicipio.Name = "dtgMunicipio";
            this.dtgMunicipio.ReadOnly = true;
            this.dtgMunicipio.RowHeadersWidth = 51;
            this.dtgMunicipio.RowTemplate.Height = 24;
            this.dtgMunicipio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMunicipio.Size = new System.Drawing.Size(718, 284);
            this.dtgMunicipio.TabIndex = 17;
            this.dtgMunicipio.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDireccion_CellContentDoubleClick);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnSeleccionar.Width = 35;
            // 
            // id_municipio
            // 
            this.id_municipio.DataPropertyName = "id_municipio";
            this.id_municipio.HeaderText = "id";
            this.id_municipio.MinimumWidth = 6;
            this.id_municipio.Name = "id_municipio";
            this.id_municipio.ReadOnly = true;
            this.id_municipio.Width = 142;
            // 
            // municipio
            // 
            this.municipio.DataPropertyName = "municipio";
            this.municipio.HeaderText = "Municipio";
            this.municipio.MinimumWidth = 6;
            this.municipio.Name = "municipio";
            this.municipio.ReadOnly = true;
            this.municipio.Width = 142;
            // 
            // id_departamento
            // 
            this.id_departamento.DataPropertyName = "id_departamento";
            this.id_departamento.HeaderText = "Departamento";
            this.id_departamento.MinimumWidth = 6;
            this.id_departamento.Name = "id_departamento";
            this.id_departamento.ReadOnly = true;
            this.id_departamento.Width = 141;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            this.estado.Width = 142;
            // 
            // frmVisorMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(742, 305);
            this.Controls.Add(this.dtgMunicipio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVisorMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor Municipio";
            this.Load += new System.EventHandler(this.frmVisorMunicipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMunicipio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMunicipio;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}