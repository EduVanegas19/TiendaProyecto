using System;
using System.Data;

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
    }
}
