select 
            a.id_usuario, a.usuario, a.id_empleado, a.id_rol, 
            b.nombre, b.apellido, c.Rol
            from usuarios a, empleados b, roles c
            where a.usuario = 'Eduv'
            and a.clave = 123
            and a.id_empleado = b.id_empleado
            and a.id_rol = c.id_rol;