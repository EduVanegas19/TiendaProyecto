using DataManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DataManager
{
    public static class DBConsultas
    {
        public static DataTable VALIDAR_USUARIO(String pUsuario, String pClave)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"select
            a.id_usuario, a.usuario, a.id_empleado, a.id_rol, 
            b.nombre, b.apellido, c.Rol
            from usuarios a, empleados b, roles c
            where a.usuario = '" + pUsuario + @"'
            and a.clave = " + pClave + @"
            and a.id_empleado = b.id_empleado
            and a.id_rol = c.id_rol;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }

            return Resultado;
        }

        public static DataTable ROLES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT id_rol, Rol FROM roles;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static List<string> ObtenerPermisosUsuario(string pIdUsuario)
        {
            string connectionString = DBConexion.cn;

            List<string> permisosUsuario = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string Sentencia = @"SELECT DISTINCT u.id_usuario, u.usuario, so.nombre, so.nombreFormulario FROM permisos p
			                    JOIN roles r ON r.id_rol = p.id_rol
			                    JOIN subopciones so ON so.id_subopcion = p.id_subopcion
			                    JOIN opciones op ON op.id_opcion = so.id_opcion
			                    JOIN usuarios u ON u.id_rol = p.id_rol AND p.estado=1
			                    WHERE u.id_usuario = " + pIdUsuario + ";";

                using (SqlCommand command = new SqlCommand(Sentencia, connection))
                {
                    command.Parameters.AddWithValue("id_usuario", pIdUsuario);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        permisosUsuario.Add(reader["nombreFormulario"].ToString());
                    }
                }
            }
            return permisosUsuario;
        }

        // CARGANDO VER TABLA DE DATOS
        public static DataTable USUARIOS()  
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM usuarios;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable AREAS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM  areas;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable CLIENTES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM clientes;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable DEPARTAMENTOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM departamentos;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable MUNICIPIOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM municipios;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable DETALLE_VENTA()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM detalle_factura;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable DETALLE_PEDIDO()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM detalle_pedido;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable DIRECCIONES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM direcciones;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM empleados;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable VENTAS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM facturas;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable OPCIONES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM opciones;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable PEDIDOS_PROVEEDOR()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM pedidos_proveedor;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable PRODUCTOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM productos;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable PROVEEDORES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM proveedores;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable TIPO_PAGOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM tipo_pagos;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable UNIDAD_MEDIDA()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"SELECT * FROM unidad_medida;";
            DBOperacion Consultor = new DBOperacion();
            try
            {
                Resultado = Consultor.Consultar(Sentencia);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
    }
}
