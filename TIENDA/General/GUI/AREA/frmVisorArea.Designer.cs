﻿
namespace General.GUI.AREA
{
    partial class frmVisorArea
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
            this.dtgArea = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArea)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgArea
            // 
            this.dtgArea.AllowUserToAddRows = false;
            this.dtgArea.AllowUserToDeleteRows = false;
            this.dtgArea.BackgroundColor = System.Drawing.Color.White;
            this.dtgArea.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_area,
            this.area});
            this.dtgArea.Location = new System.Drawing.Point(12, 12);
            this.dtgArea.MultiSelect = false;
            this.dtgArea.Name = "dtgArea";
            this.dtgArea.ReadOnly = true;
            this.dtgArea.RowHeadersWidth = 51;
            this.dtgArea.RowTemplate.Height = 24;
            this.dtgArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgArea.Size = new System.Drawing.Size(679, 284);
            this.dtgArea.TabIndex = 18;
            this.dtgArea.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArea_CellContentDoubleClick);
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
            // id_area
            // 
            this.id_area.DataPropertyName = "id_area";
            this.id_area.HeaderText = "id";
            this.id_area.MinimumWidth = 6;
            this.id_area.Name = "id_area";
            this.id_area.ReadOnly = true;
            this.id_area.Width = 142;
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "Area";
            this.area.MinimumWidth = 6;
            this.area.Name = "area";
            this.area.ReadOnly = true;
            this.area.Width = 142;
            // 
            // frmVisorArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 321);
            this.Controls.Add(this.dtgArea);
            this.Name = "frmVisorArea";
            this.Text = "frmVisorArea";
            this.Load += new System.EventHandler(this.frmVisorArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgArea;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
    }
}