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
        public static DataTable LISTARPROVEEDORESOPCION(int pIdOrden)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec LISTARPROVEEDORESOPCION " + pIdOrden + ";";
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
        public static DataTable LISTARPRODUCTOsOPCION(int pIdOrden)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec LISTARPRODUCTOSOPCION " + pIdOrden + ";";
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
        public static DataTable LISTARVENTAOPCION(int pIdOrden)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec LISTARVENTAOPCION " + pIdOrden + ";";
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
        public static DataTable LISTARCLIENTEOPCION(int pIdOrden)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec LISTARCLIENTEOPCION " + pIdOrden + ";";
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
        public static DataTable LISTARDIRECCIONOPCION(int pIdOrden)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec LISTARDIRECCIONOPCION " + pIdOrden + ";";
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
        public static DataTable LISTARUSUARIOSOPCION(int pIdOrden)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec LISTARUSUARIOSOPCION " + pIdOrden + ";";
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
        public static DataTable LISTAREMPLEADOOPCION(int pIdOrden)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec LISTAREMPLEADOOPCION " + pIdOrden + ";";
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
        public static DataTable LISTARPEDIDOOPCION(int pIdOrden)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec LISTARPEDIDOOPCION " + pIdOrden + ";";
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

        //DATOS QUE SE MOSTRARAN AL TICKET
        public static DataTable TICKET()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec ObtenerUltimaFactura";
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
        public static DataTable ReporteClientes()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec ReporteClientes";
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
        public static DataTable ReporteEmpleados()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec ReporteEmpleados";
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
        public static DataTable ReporteProductos()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec ReporteProductos";
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
        public static DataTable ReporteProveedores()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec ReporteProveedores";
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
        public static DataTable ReporteUsuarios()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"exec ReporteUsuarios";
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
            String Sentencia = @"SELECT * FROM  areas WHERE estado=1";
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
            String Sentencia = @"SELECT * FROM clientes WHERE estado=1;";
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
            String Sentencia = @"SELECT * FROM unidad_medida WHERE estado=1;";
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

        /*CONSULTAS ESPECIFICAS PARA LA TABLA DE PRODUCTO*/
        public static DataTable LISTARPRODUCTOSALFABETICAMENTE()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC LISTARPRODUCTOALFABETICAMENTE";
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
        public static DataTable LISTARPRODUCTOALFABETICAMENTEINVERSO()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC LISTARPRODUCTOALFABETICAMENTEINVERSO";
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
        public static DataTable BUSCARPRODUCTOSXID(string pIdProducto)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC BUSCARPRODUCTOSXID" + pIdProducto;
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
        public static DataTable BUSCARPRODUCTOSXNOMBRE(string pNombre)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC BUSCARPRODUCTOSXNOMBRE" + pNombre;
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
        public static DataTable VERIFICARPRODUCTOREGISTRADO(string pCodigoBarras)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC VERIFICARPRODUCTOREGISTRADO" + pCodigoBarras;
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

        /*CONSULTAS ESPECIFICAS PARA LA TABLA DE CLIENTES*/
        public static DataTable LISTARCLIENTES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC LISTARCLIENTES";
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
        public static DataTable LISTARCLIENTESALFABETICAMENTE()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC LISTARCLIENTESALFABETICAMENTE";
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
        public static DataTable LISTARCLIENTESALFABETICAMENTEINVERSO()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC LISTARCLIENTESALFABETICAMENTEINVERSO";
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
        public static DataTable BUSCARCLIENTESXIDENTIFICACION(string pIdentificacion)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC BUSCARCLIENTESXIDENTIFICACION" + pIdentificacion;
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
        public static DataTable BUSCARCLIENTESXNOMBRE(string pNombre)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC BUSCARCLIENTESXNOMBRE" + pNombre;
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

        /*CONSULTAS ESPECIFICAS PARA LA TABLA PEDIDOS*/
        public static DataTable LISTARPEDIDOS()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC LISTARPEDIDOS";
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
        public static DataTable LISTARPEDIDOSXANTIGUEDAD()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC LISTARPEDIDOSXANTIGUEDAD";
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
        public static DataTable LISTARPEDIDOSMÁSRECIENTES()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC LISTARPEDIDOSMÁSRECIENTES";
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
        public static DataTable MOSTRARPEDIDOCONDETALLES(string pIdPedido)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC MOSTRARPEDIDOCONDETALLES" + pIdPedido;
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
        public static DataTable RESUMENPEDIDO()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC RESUMENPEDIDO";
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
        public static DataTable OBTENERNUMERODOCUMENTO(string pNumeroDocumento)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC OBTENERNUMERODOCUMENTO" + pNumeroDocumento;
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

        /*CONSULTAS ESPECIFICAS PARA USUARIOS*/

        public static DataTable ListarUsarioAlfabeticamente()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC ListarUsarioAlfabeticamente";
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
        public static DataTable ListarUsuariosNoAlfabeticamente()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC ListarUsuariosNoAlfabeticamente";
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
        public static DataTable BuscarUsuarioID(string pIdUsuario)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC BuscarUsuarioID" + pIdUsuario;
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
        public static DataTable BuscarUsuariosNombre(string pUsuario)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC BuscarUsuariosNombre" + pUsuario;
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
        public static DataTable VerificarUsuario(string pUsuario)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC VerificarUsuario" + pUsuario;
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
        public static DataTable PermisosUsuario(string pIdUsuario)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC PermisosUsuario" + pIdUsuario;
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

        /*CONSULTAS ESPECIFICAS PARA PROVEEDORES*/

        public static DataTable ListarUsariosAlfabeticamente()
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC ListarUsarioAlfabeticamente";
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
        public static DataTable BuscarUsuariosID(string pIdUsuario)
        {
            DataTable Resultado = new DataTable();
            String Sentencia = @"EXEC BuscarUsuarioID" + pIdUsuario;
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
