﻿
namespace General.GUI.PROVEEDOR
{
    partial class frmVisorProveedor
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
            this.dtgProveedores = new System.Windows.Forms.DataGridView();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProveedores
            // 
            this.dtgProveedores.AllowUserToAddRows = false;
            this.dtgProveedores.AllowUserToDeleteRows = false;
            this.dtgProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dtgProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_proveedor,
            this.proveedor,
            this.numero_documento,
            this.esLaboratorio,
            this.estado});
            this.dtgProveedores.Location = new System.Drawing.Point(19, 10);
            this.dtgProveedores.MultiSelect = false;
            this.dtgProveedores.Name = "dtgProveedores";
            this.dtgProveedores.ReadOnly = true;
            this.dtgProveedores.RowHeadersWidth = 51;
            this.dtgProveedores.RowTemplate.Height = 24;
            this.dtgProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProveedores.Size = new System.Drawing.Size(479, 284);
            this.dtgProveedores.TabIndex = 16;
            // 
            // id_proveedor
            // 
            this.id_proveedor.DataPropertyName = "id_proveedor";
            this.id_proveedor.HeaderText = "id";
            this.id_proveedor.MinimumWidth = 6;
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.ReadOnly = true;
            this.id_proveedor.Visible = false;
            this.id_proveedor.Width = 142;
            // 
            // proveedor
            // 
            this.proveedor.DataPropertyName = "proveedor";
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.MinimumWidth = 6;
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            this.proveedor.Width = 142;
            // 
            // numero_documento
            // 
            this.numero_documento.DataPropertyName = "numero_documento";
            this.numero_documento.HeaderText = "Numero documento";
            this.numero_documento.MinimumWidth = 6;
            this.numero_documento.Name = "numero_documento";
            this.numero_documento.ReadOnly = true;
            this.numero_documento.Width = 141;
            // 
            // esLaboratorio
            // 
            this.esLaboratorio.DataPropertyName = "esLaboratorio";
            this.esLaboratorio.HeaderText = "Laboratorio";
            this.esLaboratorio.MinimumWidth = 6;
            this.esLaboratorio.Name = "esLaboratorio";
            this.esLaboratorio.ReadOnly = true;
            this.esLaboratorio.Width = 142;
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
            // frmVisorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 303);
            this.Controls.Add(this.dtgProveedores);
            this.Name = "frmVisorProveedor";
            this.Text = "frmVisorProveedor";
            this.Load += new System.EventHandler(this.frmVisorProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn esLaboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}