﻿
namespace General.GUI
{
    partial class frmGestionEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionEmpleado));
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
            this.dtgEmpleado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_casa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasaje_poligono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caserio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReporte)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-1, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1210, 67);
            this.panel3.TabIndex = 10;
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
            this.panel2.Location = new System.Drawing.Point(1120, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 497);
            this.panel2.TabIndex = 9;
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.panel1.Controls.Add(this.dtgEmpleado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(2, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 497);
            this.panel1.TabIndex = 8;
            // 
            // cbbOrdenar
            // 
            this.cbbOrdenar.FormattingEnabled = true;
            this.cbbOrdenar.Items.AddRange(new object[] {
            "Ultimo Agregado",
            "Primero Agregado",
            "A - Z",
            "Z - A"});
            this.cbbOrdenar.Location = new System.Drawing.Point(955, 21);
            this.cbbOrdenar.Name = "cbbOrdenar";
            this.cbbOrdenar.Size = new System.Drawing.Size(121, 24);
            this.cbbOrdenar.TabIndex = 14;
            this.cbbOrdenar.SelectedValueChanged += new System.EventHandler(this.cbbOrdenar_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(847, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ordenar por:";
            // 
            // dtgEmpleado
            // 
            this.dtgEmpleado.AllowUserToAddRows = false;
            this.dtgEmpleado.AllowUserToDeleteRows = false;
            this.dtgEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.dtgEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_empleado,
            this.nombre,
            this.apellido,
            this.genero,
            this.telefono,
            this.correo,
            this.DUI,
            this.fechanac,
            this.id_direccion,
            this.numero_casa,
            this.pasaje_poligono,
            this.calle,
            this.colonia,
            this.canton,
            this.caserio,
            this.codigo_postal,
            this.id_municipio,
            this.municipio,
            this.usuario,
            this.rol});
            this.dtgEmpleado.Location = new System.Drawing.Point(19, 63);
            this.dtgEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.dtgEmpleado.MultiSelect = false;
            this.dtgEmpleado.Name = "dtgEmpleado";
            this.dtgEmpleado.ReadOnly = true;
            this.dtgEmpleado.RowHeadersWidth = 51;
            this.dtgEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmpleado.Size = new System.Drawing.Size(1078, 430);
            this.dtgEmpleado.TabIndex = 0;
            this.dtgEmpleado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpleado_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digite aqui para buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(223, 21);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(156, 22);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            this.statusStrip1.Size = new System.Drawing.Size(1210, 30);
            this.statusStrip1.TabIndex = 11;
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
            // id_empleado
            // 
            this.id_empleado.DataPropertyName = "id_empleado";
            this.id_empleado.HeaderText = "ID";
            this.id_empleado.MinimumWidth = 6;
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.ReadOnly = true;
            this.id_empleado.Width = 50;
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
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "APELLIDO";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 125;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "GENERO";
            this.genero.MinimumWidth = 6;
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "CORREO";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 125;
            // 
            // DUI
            // 
            this.DUI.DataPropertyName = "DUI";
            this.DUI.HeaderText = "DUI";
            this.DUI.MinimumWidth = 6;
            this.DUI.Name = "DUI";
            this.DUI.ReadOnly = true;
            this.DUI.Width = 125;
            // 
            // fechanac
            // 
            this.fechanac.DataPropertyName = "fechanac";
            this.fechanac.HeaderText = "NACIMIENTO";
            this.fechanac.MinimumWidth = 6;
            this.fechanac.Name = "fechanac";
            this.fechanac.ReadOnly = true;
            this.fechanac.Width = 125;
            // 
            // id_direccion
            // 
            this.id_direccion.DataPropertyName = "id_direccion";
            this.id_direccion.HeaderText = "idDireccion";
            this.id_direccion.MinimumWidth = 6;
            this.id_direccion.Name = "id_direccion";
            this.id_direccion.ReadOnly = true;
            this.id_direccion.Visible = false;
            this.id_direccion.Width = 125;
            // 
            // numero_casa
            // 
            this.numero_casa.DataPropertyName = "numero_casa";
            this.numero_casa.HeaderText = "NUMEROCASA";
            this.numero_casa.MinimumWidth = 6;
            this.numero_casa.Name = "numero_casa";
            this.numero_casa.ReadOnly = true;
            this.numero_casa.Visible = false;
            this.numero_casa.Width = 125;
            // 
            // pasaje_poligono
            // 
            this.pasaje_poligono.DataPropertyName = "pasaje_poligono";
            this.pasaje_poligono.HeaderText = "PASAJE/POLIGONO";
            this.pasaje_poligono.MinimumWidth = 6;
            this.pasaje_poligono.Name = "pasaje_poligono";
            this.pasaje_poligono.ReadOnly = true;
            this.pasaje_poligono.Visible = false;
            this.pasaje_poligono.Width = 125;
            // 
            // calle
            // 
            this.calle.DataPropertyName = "calle";
            this.calle.HeaderText = "CALLE";
            this.calle.MinimumWidth = 6;
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            this.calle.Width = 125;
            // 
            // colonia
            // 
            this.colonia.DataPropertyName = "colonia";
            this.colonia.HeaderText = "COLONIA";
            this.colonia.MinimumWidth = 6;
            this.colonia.Name = "colonia";
            this.colonia.ReadOnly = true;
            this.colonia.Width = 125;
            // 
            // canton
            // 
            this.canton.DataPropertyName = "canton";
            this.canton.HeaderText = "CANTON";
            this.canton.MinimumWidth = 6;
            this.canton.Name = "canton";
            this.canton.ReadOnly = true;
            this.canton.Visible = false;
            this.canton.Width = 125;
            // 
            // caserio
            // 
            this.caserio.DataPropertyName = "caserio";
            this.caserio.HeaderText = "CASERIO";
            this.caserio.MinimumWidth = 6;
            this.caserio.Name = "caserio";
            this.caserio.ReadOnly = true;
            this.caserio.Visible = false;
            this.caserio.Width = 125;
            // 
            // codigo_postal
            // 
            this.codigo_postal.DataPropertyName = "codigo_postal";
            this.codigo_postal.HeaderText = "CODIGO POSTAL";
            this.codigo_postal.MinimumWidth = 6;
            this.codigo_postal.Name = "codigo_postal";
            this.codigo_postal.ReadOnly = true;
            this.codigo_postal.Width = 125;
            // 
            // id_municipio
            // 
            this.id_municipio.DataPropertyName = "id_municipio";
            this.id_municipio.HeaderText = "idMunicipio";
            this.id_municipio.MinimumWidth = 6;
            this.id_municipio.Name = "id_municipio";
            this.id_municipio.ReadOnly = true;
            this.id_municipio.Visible = false;
            this.id_municipio.Width = 125;
            // 
            // municipio
            // 
            this.municipio.DataPropertyName = "municipio";
            this.municipio.HeaderText = "MUNICIPIO";
            this.municipio.MinimumWidth = 6;
            this.municipio.Name = "municipio";
            this.municipio.ReadOnly = true;
            this.municipio.Width = 125;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "USUARIO";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 125;
            // 
            // rol
            // 
            this.rol.DataPropertyName = "rol";
            this.rol.HeaderText = "ROL";
            this.rol.MinimumWidth = 6;
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            this.rol.Width = 125;
            // 
            // frmGestionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 603);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmGestionEmpleado";
            this.Text = "Gestion de Empleado";
            this.Load += new System.EventHandler(this.frmGestionEmpleado_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dtgEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanac;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_casa;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasaje_poligono;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn canton;
        private System.Windows.Forms.DataGridViewTextBoxColumn caserio;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
    }
}