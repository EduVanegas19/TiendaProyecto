/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [IdUsuario]
      ,[Usuario]
      ,[Clave]
      ,[IdEmpleado]
      ,[IdRol]
  FROM [sistema].[sistema].[usuarios]

 SELECT * FROM sistema.usuarios;
/*Es un espejismo para que nadie sepa cual es la contraseña correcta*/
update sistema.usuarios set Clave=HashBytes('SHA1',HashBytes('md5', '123')) where IdUsuario=2;

SELECT 
            a.IdUsuario,a.Usuario, a.IdEmpleado, a.IdRol,
            b.Nombres, b.Apellidos,c.Rol  
            FROM sistema.usuarios a, sistema.empleados b, sistema.roles c
            WHERE a.Usuario='"+pUsuario+ @"' 
            AND a.Clave=HashBytes('SHA1',HashBytes('md5', '" + pClave + @"'))
            AND a.IdEmpleado=b.IdEmpleados
            AND a.IdRol=c.IdRol