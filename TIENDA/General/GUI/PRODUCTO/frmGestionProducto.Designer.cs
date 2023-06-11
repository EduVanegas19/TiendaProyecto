
namespace General.GUI.PRODUCTO
{
    partial class frmGestionProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionProducto));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnReporte = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbOrdenar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgProducto = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_unidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReporte)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblRol});
            this.statusStrip1.Location = new System.Drawing.Point(0, 573);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1233, 30);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 24);
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblRol
            // 
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(36, 24);
            this.lblRol.Text = "ROL";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1233, 67);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANNER DE LOGO DE LA EMPRESA COMO EL SPLASH";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnReporte);
            this.panel2.Location = new System.Drawing.Point(1144, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 497);
            this.panel2.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(13, 53);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 62);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(13, 133);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(67, 62);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditar.TabIndex = 1;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 337);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "*REPORTE *";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(13, 213);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 62);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(13, 435);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 58);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 4;
            this.btnSalir.TabStop = false;
            // 
            // btnReporte
            // 
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(13, 358);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(64, 60);
            this.btnReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReporte.TabIndex = 3;
            this.btnReporte.TabStop = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.cbbOrdenar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtgProducto);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(3, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 497);
            this.panel1.TabIndex = 5;
            // 
            // cbbOrdenar
            // 
            this.cbbOrdenar.FormattingEnabled = true;
            this.cbbOrdenar.Location = new System.Drawing.Point(671, 21);
            this.cbbOrdenar.Name = "cbbOrdenar";
            this.cbbOrdenar.Size = new System.Drawing.Size(121, 24);
            this.cbbOrdenar.TabIndex = 14;
            this.cbbOrdenar.SelectedIndexChanged += new System.EventHandler(this.cbbOrdenar_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ordenar por:";
            // 
            // dtgProducto
            // 
            this.dtgProducto.AllowUserToAddRows = false;
            this.dtgProducto.AllowUserToDeleteRows = false;
            this.dtgProducto.BackgroundColor = System.Drawing.Color.White;
            this.dtgProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.descripcion,
            this.codigo_barras,
            this.nombre,
            this.precio_unidad,
            this.precio_venta,
            this.fecha_ingreso,
            this.fecha_vencimiento,
            this.medida,
            this.id_unidadMedida,
            this.id_area,
            this.stock,
            this.estado});
            this.dtgProducto.Location = new System.Drawing.Point(10, 57);
            this.dtgProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dtgProducto.MultiSelect = false;
            this.dtgProducto.Name = "dtgProducto";
            this.dtgProducto.ReadOnly = true;
            this.dtgProducto.RowHeadersWidth = 51;
            this.dtgProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProducto.Size = new System.Drawing.Size(1123, 430);
            this.dtgProducto.TabIndex = 0;
            this.dtgProducto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProducto_CellContentDoubleClick);
            // 
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.HeaderText = "ID";
            this.id_producto.MinimumWidth = 6;
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Visible = false;
            this.descripcion.Width = 125;
            // 
            // codigo_barras
            // 
            this.codigo_barras.DataPropertyName = "codigo_barras";
            this.codigo_barras.HeaderText = "CODIGO BARRA";
            this.codigo_barras.MinimumWidth = 6;
            this.codigo_barras.Name = "codigo_barras";
            this.codigo_barras.ReadOnly = true;
            this.codigo_barras.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // precio_unidad
            // 
            this.precio_unidad.DataPropertyName = "precio_unidad";
            this.precio_unidad.HeaderText = "PRECIO UNIDAD";
            this.precio_unidad.MinimumWidth = 6;
            this.precio_unidad.Name = "precio_unidad";
            this.precio_unidad.ReadOnly = true;
            this.precio_unidad.Width = 125;
            // 
            // precio_venta
            // 
            this.precio_venta.DataPropertyName = "precio_venta";
            this.precio_venta.HeaderText = "PRECIO VENTA";
            this.precio_venta.MinimumWidth = 6;
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.ReadOnly = true;
            this.precio_venta.Width = 125;
            // 
            // fecha_ingreso
            // 
            this.fecha_ingreso.DataPropertyName = "fecha_ingreso";
            this.fecha_ingreso.HeaderText = "FECHA INGRESO";
            this.fecha_ingreso.MinimumWidth = 6;
            this.fecha_ingreso.Name = "fecha_ingreso";
            this.fecha_ingreso.ReadOnly = true;
            this.fecha_ingreso.Width = 125;
            // 
            // fecha_vencimiento
            // 
            this.fecha_vencimiento.DataPropertyName = "fecha_vencimiento";
            this.fecha_vencimiento.HeaderText = "FECHA VENCIMIENTO";
            this.fecha_vencimiento.MinimumWidth = 6;
            this.fecha_vencimiento.Name = "fecha_vencimiento";
            this.fecha_vencimiento.ReadOnly = true;
            this.fecha_vencimiento.Width = 125;
            // 
            // medida
            // 
            this.medida.DataPropertyName = "medida";
            this.medida.HeaderText = "MEDIDA";
            this.medida.MinimumWidth = 6;
            this.medida.Name = "medida";
            this.medida.ReadOnly = true;
            this.medida.Width = 125;
            // 
            // id_unidadMedida
            // 
            this.id_unidadMedida.DataPropertyName = "id_unidadMedida";
            this.id_unidadMedida.HeaderText = "UNIDAD MEDIDA";
            this.id_unidadMedida.MinimumWidth = 6;
            this.id_unidadMedida.Name = "id_unidadMedida";
            this.id_unidadMedida.ReadOnly = true;
            this.id_unidadMedida.Width = 125;
            // 
            // id_area
            // 
            this.id_area.DataPropertyName = "id_area";
            this.id_area.HeaderText = "AREA";
            this.id_area.MinimumWidth = 6;
            this.id_area.Name = "id_area";
            this.id_area.ReadOnly = true;
            this.id_area.Width = 125;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "CANTIDAD";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Visible = false;
            this.stock.Width = 125;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "ESTADO";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 125;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(370, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 25);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digite aqui para buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(194, 23);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(156, 22);
            this.txtBuscar.TabIndex = 6;
            // 
            // frmGestionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 603);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmGestionProducto";
            this.Text = "Gestion de Producto";
            this.Load += new System.EventHandler(this.frmGestionProducto_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReporte)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnReporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbOrdenar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_unidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}