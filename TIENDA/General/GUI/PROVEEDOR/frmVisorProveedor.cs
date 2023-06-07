﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.PROVEEDOR
{
    public partial class frmVisorProveedor : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.PROVEEDORES();
                dtgProveedores.AutoGenerateColumns = false;
                dtgProveedores.DataSource = _DATOS;
            }
            catch (Exception)
            {

            }
        }
        public frmVisorProveedor()
        {
            InitializeComponent();
        }

        private void frmVisorProveedor_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
