
namespace General.GUI.DETALLE_VENTA
{
    partial class frmGestionDetalleVenta
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
            this.btnFactura = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_facutura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(453, 475);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(126, 23);
            this.btnFactura.TabIndex = 20;
            this.btnFactura.Text = "Crear Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click_1);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(134, 206);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 22);
            this.txtCantidad.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(669, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 422);
            this.panel1.TabIndex = 18;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(304, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 27);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(134, 247);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 32);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(134, 167);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 22);
            this.txtEstado.TabIndex = 15;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(134, 124);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 13;
            // 
            // txtCodigoB
            // 
            this.txtCodigoB.Location = new System.Drawing.Point(134, 48);
            this.txtCodigoB.Name = "txtCodigoB";
            this.txtCodigoB.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoB.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_barras,
            this.nombre,
            this.cantidad,
            this.id_producto,
            this.id_facutura});
            this.dataGridView1.Location = new System.Drawing.Point(62, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 169);
            this.dataGridView1.TabIndex = 11;
            // 
            // codigo_barras
            // 
            this.codigo_barras.DataPropertyName = "precio_unitario";
            this.codigo_barras.HeaderText = "PrecioUnidad";
            this.codigo_barras.MinimumWidth = 6;
            this.codigo_barras.Name = "codigo_barras";
            this.codigo_barras.ReadOnly = true;
            this.codigo_barras.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "precio_venta";
            this.nombre.HeaderText = "PrecioVenta";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 125;
            // 
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.HeaderText = "Producto";
            this.id_producto.MinimumWidth = 6;
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Width = 125;
            // 
            // id_facutura
            // 
            this.id_facutura.DataPropertyName = "id_factura";
            this.id_facutura.HeaderText = "Factura";
            this.id_facutura.MinimumWidth = 6;
            this.id_facutura.Name = "id_facutura";
            this.id_facutura.ReadOnly = true;
            this.id_facutura.Width = 125;
            // 
            // frmGestionDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 545);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmGestionDetalleVenta";
            this.Text = "Gestion Detalle de Venta";
            this.Load += new System.EventHandler(this.frmGestionDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.TextBox txtEstado;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtCodigoB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_facutura;
        public System.Windows.Forms.NumericUpDown txtCantidad;
    }
}