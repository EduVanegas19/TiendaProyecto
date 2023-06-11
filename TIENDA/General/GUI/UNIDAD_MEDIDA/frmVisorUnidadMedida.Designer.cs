
namespace General.GUI.UNIDAD_MEDIDA
{
    partial class frmVisorUnidadMedida
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
            this.dtgUnidadMedida = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_unidadmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnidadMedida)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUnidadMedida
            // 
            this.dtgUnidadMedida.AllowUserToAddRows = false;
            this.dtgUnidadMedida.AllowUserToDeleteRows = false;
            this.dtgUnidadMedida.BackgroundColor = System.Drawing.Color.White;
            this.dtgUnidadMedida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgUnidadMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUnidadMedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_unidadmedida,
            this.unidad_medida});
            this.dtgUnidadMedida.Location = new System.Drawing.Point(12, 12);
            this.dtgUnidadMedida.MultiSelect = false;
            this.dtgUnidadMedida.Name = "dtgUnidadMedida";
            this.dtgUnidadMedida.ReadOnly = true;
            this.dtgUnidadMedida.RowHeadersWidth = 51;
            this.dtgUnidadMedida.RowTemplate.Height = 24;
            this.dtgUnidadMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUnidadMedida.Size = new System.Drawing.Size(679, 284);
            this.dtgUnidadMedida.TabIndex = 18;
            this.dtgUnidadMedida.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUnidadMedida_CellContentDoubleClick);
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
            // id_unidadmedida
            // 
            this.id_unidadmedida.DataPropertyName = "id_unidadmedida";
            this.id_unidadmedida.HeaderText = "id";
            this.id_unidadmedida.MinimumWidth = 6;
            this.id_unidadmedida.Name = "id_unidadmedida";
            this.id_unidadmedida.ReadOnly = true;
            this.id_unidadmedida.Width = 142;
            // 
            // unidad_medida
            // 
            this.unidad_medida.DataPropertyName = "unidad_medida";
            this.unidad_medida.HeaderText = "Unidad Medida";
            this.unidad_medida.MinimumWidth = 6;
            this.unidad_medida.Name = "unidad_medida";
            this.unidad_medida.ReadOnly = true;
            this.unidad_medida.Width = 142;
            // 
            // frmVisorUnidadMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 315);
            this.Controls.Add(this.dtgUnidadMedida);
            this.Name = "frmVisorUnidadMedida";
            this.Text = "frmVisorUnidadMedida";
            this.Load += new System.EventHandler(this.frmVisorUnidadMedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnidadMedida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUnidadMedida;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_unidadmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad_medida;
    }
}