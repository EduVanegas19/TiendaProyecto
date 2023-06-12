
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisorUnidadMedida));
            this.dtgUnidadMedida = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_unidadmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnidadMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
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
            this.unidad_medida,
            this.btnEliminar});
            this.dtgUnidadMedida.Location = new System.Drawing.Point(12, 12);
            this.dtgUnidadMedida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgUnidadMedida.MultiSelect = false;
            this.dtgUnidadMedida.Name = "dtgUnidadMedida";
            this.dtgUnidadMedida.ReadOnly = true;
            this.dtgUnidadMedida.RowHeadersWidth = 51;
            this.dtgUnidadMedida.RowTemplate.Height = 24;
            this.dtgUnidadMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUnidadMedida.Size = new System.Drawing.Size(648, 290);
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
            // btnEliminar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(12, 310);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(52, 39);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmVisorUnidadMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(679, 359);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgUnidadMedida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVisorUnidadMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisorUnidadMedida";
            this.Load += new System.EventHandler(this.frmVisorUnidadMedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUnidadMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUnidadMedida;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_unidadmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad_medida;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.PictureBox btnAgregar;
    }
}