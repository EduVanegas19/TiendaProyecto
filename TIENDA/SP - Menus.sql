GO
CREATE PROCEDURE usp_LoginUsuario
(
	@Usuario varchar(50),
	@Clave varchar(50),
	@id_usuario int output
)
as
BEGIN
	SET @id_usuario = 0
	if EXISTS ( select * from usuarios 
				where usuario COLLATE Latin1_General_CS_AS = @Usuario 
				AND 
				clave COLLATE Latin1_General_CS_AS = @Clave)

	set @id_usuario = (select id_usuario from usuarios 
						where usuario COLLATE Latin1_General_CS_AS = @Usuario 
						AND 
						clave COLLATE Latin1_General_CS_AS = @Clave)
END

--DECLARE @IdUsuario INT
--exec usp_LoginUsuario 'EduV', '123', @IdUsuario output
--select @IdUsuario

-- OBTENER MENUS DE OPCIONES ***************************
SELECT DISTINCT op.* FROM permisos p
JOIN roles r ON r.id_rol = p.id_rol
JOIN subopciones so ON so.id_subopcion = p.id_subopcion
JOIN opciones op ON op.id_opcion = so.id_opcion
JOIN usuarios u ON u.id_rol = p.id_rol AND p.estado=1
WHERE u.id_usuario = 1

-- OBTENER SUBMENUS DE SUBOPCIONES **********************
SELECT DISTINCT so.* FROM permisos p
JOIN roles r ON r.id_rol = p.id_rol
JOIN subopciones so ON so.id_subopcion = p.id_subopcion
JOIN opciones op ON op.id_opcion = so.id_opcion
JOIN usuarios u ON u.id_rol = p.id_rol AND p.estado=1
WHERE u.id_usuario = 2



GO
CREATE PROCEDURE usp_ObtenerPermisos
(
	@id_usuario int 
)
as
BEGIN
	-- Vista del MENU *********************************************
	SELECT
		(SELECT vistamenu.nombre, vistamenu.icono,

			(SELECT DISTINCT so.nombre, so.nombreFormulario FROM permisos p
			JOIN roles r ON r.id_rol = p.id_rol
			JOIN subopciones so ON so.id_subopcion = p.id_subopcion
			JOIN opciones op ON op.id_opcion = so.id_opcion
			JOIN usuarios u ON u.id_rol = p.id_rol AND p.estado=1
			WHERE u.id_usuario = us.id_usuario AND so.id_opcion = vistamenu.id_opcion
			for xml path('SubOpciones'), TYPE) AS 'DetalleSubMenu'

		FROM
		(
			SELECT DISTINCT op.* FROM permisos p
			JOIN roles r ON r.id_rol = p.id_rol
			JOIN subopciones so ON so.id_subopcion = p.id_subopcion
			JOIN opciones op ON op.id_opcion = so.id_opcion
			JOIN usuarios u ON u.id_rol = p.id_rol AND p.estado=1
			WHERE u.id_usuario = us.id_usuario


		)vistamenu
		for xml path('Opciones'), TYPE) AS 'DetalleMenu'

	FROM usuarios us
	WHERE us.id_usuario = @id_usuario
	for xml path(''), root('permisos')
END

exec usp_ObtenerPermisos 2