using DataManager;
using General.CLS;
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




        //public static int Loguear(string usuario, string clave)
        //{
        //    int idusuario = 0;

        //    using (SqlConnection cn = new SqlConnection(DBConexion.cn))
        //    {
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand("usp_LoginUsuario", cn);
        //            cmd.Parameters.AddWithValue("usuario", usuario);
        //            cmd.Parameters.AddWithValue("clave", clave);
        //            cmd.Parameters.Add("id_usuario", SqlDbType.Int).Direction = ParameterDirection.Output;
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            cn.Open();
        //            cmd.ExecuteNonQuery();

        //            idusuario = Convert.ToInt32(cmd.Parameters["id_usuario"].Value);
        //        }
        //        catch (Exception)
        //        {
        //            idusuario = 0;
        //        }
        //    }
        //    return idusuario;
        //}

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







        //public static List<opciones> ObtenerPermisos(int pIdUsuario)
        //{
        //    List<opciones> Permisos = new List<opciones>();
        //    String Sentencia = "exec usp_ObtenerPermisos "+pIdUsuario;

        //    using (SqlConnection cn = new SqlConnection(DBConexion.cn))
        //    {
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand("usp_ObtenerPermisos", cn);
        //            cmd.Parameters.AddWithValue("id_usuario", pIdUsuario);
        //            cmd.CommandType = CommandType.StoredProcedure;

        //            cn.Open();

        //            XmlReader leerxml = cmd.ExecuteXmlReader();

        //            while (leerxml.Read())
        //            {
        //                XDocument doc = XDocument.Load(leerxml);

        //                if (doc.Element("permisos") != null)
        //                {
        //                    Permisos = doc.Element("permisos").Element("DetalleMenu") == null ? new List<opciones>() :
        //                    (from opciones in doc.Element("permisos").Element("DetalleMenu").Elements("Opciones")
        //                     select new opciones()
        //                     {
        //                         nombre = opciones.Element("nombre").Value,
        //                         icono = opciones.Element("icono").Value,
        //                         listaSubopciones = opciones.Element("DetalleSubMenu") == null ? new List<subopciones>() :
        //                         (from subopciones in opciones.Element("DetalleSubMenu").Elements("SubOpciones")
        //                          select new subopciones()
        //                          {
        //                              nombre = subopciones.Element("nombre").Value,
        //                              nombreFormulario = subopciones.Element("nombreFormulario").Value,
        //                          }
        //                         ).ToList()
        //                     }
        //                    ).ToList();
        //                }
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            Permisos = new List<opciones>();
        //        }

        //        return Permisos;
        //    }
        //}
    }
}
