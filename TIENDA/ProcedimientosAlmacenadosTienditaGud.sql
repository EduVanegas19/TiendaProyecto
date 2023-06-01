USE Tienda
GO

/*STORE PROCEDURES PRODUCTOS*/

--AGREGAR PRODUCTOS--

CREATE PROCEDURE AGREGARPRODUCTO
--@id_producto BIGINT,
@codigo_barras VARCHAR(45),
@descripcion VARCHAR(100),
@precio_unidad MONEY,
@precio_venta MONEY,
@stock INT,
@nombre VARCHAR(100),
@fecha_ingreso DATE,
@fecha_vencimiento DATE,
@medida VARCHAR(45),
@estado BIT,
@id_unidadmedida BIGINT,
@id_area BIGINT
AS
BEGIN
INSERT INTO productos (codigo_barras,descripcion,precio_unidad,precio_venta,stock,nombre,fecha_ingreso,
fecha_vencimiento, medida,estado,id_unidadmedida,id_area)
VALUES (@codigo_barras,@descripcion,@precio_unidad,@precio_venta,@stock,@nombre,@fecha_ingreso,
@fecha_vencimiento,@medida,1,@id_unidadmedida,@id_area)
END

--MODIFICAR PRODUCTOS--

CREATE PROCEDURE ModificarProducto
@id_producto BIGINT,
@codigo_barras VARCHAR(45),
@descripcion VARCHAR(100),
@precio_unidad MONEY,     
@precio_venta MONEY,
@stock INT,
@nombre VARCHAR(100),
@fecha_ingreso DATE,
@fecha_vencimiento DATE,
@medida VARCHAR(45),
@estado BIT,
@id_unidadmedida BIGINT,
@id_area BIGINT
AS
BEGIN
UPDATE productos 
SET codigo_barras=@codigo_barras,descripcion=@descripcion,precio_unidad=@precio_unidad,precio_venta=@precio_venta,stock=@stock,nombre=@nombre,fecha_ingreso=@fecha_ingreso,
fecha_vencimiento=@fecha_vencimiento, medida=@medida,estado=1,id_unidadmedida=@id_unidadmedida,id_area=@id_area
WHERE id_producto=@id_producto
END

--ELIMINAR PRODUCTOS--

CREATE PROCEDURE ELIMINARPRODUCTO
@id_producto BIGINT,
@estado BIT
AS
BEGIN
UPDATE productos 
SET estado=0
WHERE id_producto=@id_producto
END

--LISTAR PRODUCTOS ORDEN ALFABETICO--

CREATE PROCEDURE LISTARPRODUCTOALFABETICAMENTE
AS
BEGIN
SELECT p.id_producto,p.codigo_barras,p.descripcion,p.precio_unidad,p.precio_venta,p.stock,p.nombre,p.fecha_ingreso,p.fecha_vencimiento,p.medida,p.estado,p.id_unidadmedida,p.id_area
FROM productos p
INNER JOIN areas a ON p.id_area =  a.id_area
INNER JOIN unidad_medida um ON p.id_unidadmedida = um.id_unidadmedida
WHERE estado=1
ORDER BY nombre ASC
END

--LISTAR PRODUCTOS ORDEN NO ALFABETICO--

CREATE PROCEDURE LISTARPRODUCTOALFABETICAMENTEINVERSO
AS
BEGIN
SELECT p.id_producto,p.codigo_barras,p.descripcion,p.precio_unidad,p.precio_venta,p.stock,p.nombre,p.fecha_ingreso,p.fecha_vencimiento,p.medida,p.estado,p.id_unidadmedida,p.id_area
FROM productos p
INNER JOIN areas a ON p.id_area =  a.id_area
INNER JOIN unidad_medida um ON p.id_unidadmedida = um.id_unidadmedida
WHERE estado=1
ORDER BY nombre DESC
END

--BUSCAR PRODUCTOS X ID--

CREATE PROCEDURE BUSCARPRODUCTOSXID
@id_producto BIGINT
AS
BEGIN
SELECT * FROM productos
WHERE id_producto=@id_producto AND estado=1
END

--BUSCAR PRODUCTOS X NOMBRE--

CREATE PROCEDURE BUSCARPRODUCTOSXNOMBRE
@nombre VARCHAR(100)
AS
BEGIN
SELECT * FROM productos
WHERE nombre LIKE '%' + @nombre + '%' AND estado=1
END

--VERIFICAR SI EL PRODUCTO YA EXISTE--

CREATE PROCEDURE VERIFICARPRODUCTOREGISTRADO
@codigo_barras VARCHAR(45)
AS
BEGIN
SET NOCOUNT ON;
IF EXISTS(SELECT * FROM productos WHERE codigo_barras=@codigo_barras)
	SELECT 1 AS Resultado
ELSE
	SELECT 0 AS Resultado
END


--***************************************************************************************************************************--

/*PROCEDIMIENTOS ALMACENADOS PARA CLIENTES*/

--LISTAR CLIENTES--

CREATE PROCEDURE ListarClientes
AS
BEGIN
SELECT c.id_cliente, c.identificacion, c.nombre, c.credito,d.colonia,d.numero_casa,c.estado 
FROM clientes c
INNER JOIN direcciones d ON c.id_direccion = d.id_direccion
WHERE c.estado = 1
ORDER BY id_cliente DESC
END

--LISTAR CLIENTES ALFABETICAMENTE--

CREATE PROCEDURE LISTARCLIENTESALFABETICAMENTE
AS
BEGIN
SELECT c.id_cliente, c.identificacion, c.nombre, c.credito,d.colonia,d.numero_casa,c.estado 
FROM clientes c
INNER JOIN direcciones d ON c.id_direccion = d.id_direccion
WHERE estado=1
ORDER BY nombre ASC
END

--LISTAR CLIENTES ALFABETICAMENTE INVERSO--

CREATE PROCEDURE LISTARCLIENTESALFABETICAMENTEINVERSO
AS
BEGIN
SELECT c.id_cliente, c.identificacion, c.nombre, c.credito,d.colonia,d.numero_casa,c.estado 
FROM clientes c
INNER JOIN direcciones d ON c.id_direccion = d.id_direccion
WHERE estado=1
ORDER BY nombre DESC
END

--BUSCAR CLIENTES X IDENTIFICACION--

CREATE PROCEDURE BUSCARCLIENTESXIDENTIFICACION
@identificacion VARCHAR(45)
AS
BEGIN
SELECT * FROM clientes
WHERE identificacion LIKE '%' + @identificacion + '%' AND estado=1
END

--BUSCAR CLIENTES X NOMBRE--

CREATE PROCEDURE BUSCARCLIENTESXNOMBRE
@nombre VARCHAR(45)
AS
BEGIN
SELECT * FROM clientes
WHERE nombre LIKE '%' + @nombre + '%' AND estado=1
END

--AGREGAR CLIENTES--

CREATE PROCEDURE AgregarClientes
--@id_cliente BIGINT,
@identificacion VARCHAR(45),
@nombre VARCHAR(100),
@credito FLOAT,
@estado BIT,
@numero_casa VARCHAR(10),
@pasaje_poligono VARCHAR(50),
@calle VARCHAR(50),
@colonia VARCHAR(50),
@canton VARCHAR(50),
@caserio VARCHAR(50),
@codigo_postal VARCHAR(10),
@id_municipio BIGINT
AS
BEGIN
SET NOCOUNT ON
DECLARE @id_direccion BIGINT
INSERT INTO direcciones(numero_casa,pasaje_poligono,calle,colonia,canton,caserio,codigo_postal,id_municipio)
VALUES (@numero_casa,@pasaje_poligono,@calle,@colonia,@canton,@caserio,@codigo_postal,@id_municipio)

SET @id_direccion = SCOPE_IDENTITY()

INSERT INTO clientes(identificacion,nombre,credito, estado,id_direccion)
VALUES (@identificacion,@nombre,@credito,1,@id_direccion)
END

--MODIFICAR CLIENTES--

CREATE PROCEDURE ModificarClientes
@id_cliente BIGINT,
@identificacion VARCHAR(45),
@nombre VARCHAR(100),
@credito FLOAT,
@estado BIT,
@numero_casa VARCHAR(10),
@pasaje_poligono VARCHAR(50),
@calle VARCHAR(50),
@colonia VARCHAR(50),
@canton VARCHAR(50),
@caserio VARCHAR(50),
@codigo_postal VARCHAR(10),
@id_municipio BIGINT
AS
BEGIN
UPDATE clientes
SET identificacion=@identificacion,nombre=@nombre,credito=@credito,estado=1
WHERE id_cliente=@id_cliente

UPDATE direcciones
SET numero_casa=@numero_casa,pasaje_poligono=@pasaje_poligono,calle=@calle,colonia=@colonia,canton=@canton,caserio=@caserio,codigo_postal=@codigo_postal,id_municipio=@id_municipio
WHERE id_direccion = (SELECT id_direccion FROM clientes WHERE id_cliente=@id_cliente)

END

--ELIMINAR CLIENTES--

CREATE PROCEDURE EliminarClientes
@id_cliente BIGINT,
@estado BIT
AS
BEGIN
UPDATE clientes 
SET estado=0
WHERE id_cliente=@id_cliente

UPDATE direcciones 
SET estado=0
WHERE id_direccion= (SELECT id_direccion FROM clientes WHERE id_cliente=@id_cliente)
END

--***************************************************************************************************************************--

/*PROCEDIMIENTOS ALMACENADOS PARA CLIENTES*/

--LISTAR PEDIDOS--

CREATE PROCEDURE ListarPedidos
AS
BEGIN
SELECT pp.id_pedido, pp.numero_documento, pp.fecha_registro, pp.monto_total
FROM pedidos_proveedor pp
INNER JOIN proveedor p ON pp.id_proveedor = p.id_proveedor
WHERE pp.estado=1
ORDER BY id_pedido DESC
END

--LISTAR PEDIDOS POR ANTIGUEDAD--

CREATE PROCEDURE LISTARPEDIDOSXANTIGUEDAD
AS
BEGIN
SELECT pp.id_pedido, pp.numero_documento, pp.fecha_registro, pp.monto_total
FROM pedidos_proveedor pp
INNER JOIN proveedor p ON pp.id_proveedor = p.id_proveedor
WHERE estado=1
ORDER BY fecha_registro ASC
END

--LISTAR PEDIDOS POR MÁS RECIENTES--

CREATE PROCEDURE LISTARPEDIDOSMÁSRECIENTES
AS
BEGIN
SELECT pp.id_pedido, pp.numero_documento, pp.fecha_registro, pp.monto_total
FROM pedidos_proveedor pp
INNER JOIN proveedor p ON pp.id_proveedor = p.id_proveedor
WHERE estado=1
ORDER BY fecha_registro DESC
END

--LISTAR PEDIDOS CON SUS DETALLES--

CREATE PROCEDURE MOSTRARPEDIDOCONDETALLES
@id_pedido BIGINT
AS
BEGIN
--MUESTRA INFORMACIÓN DEL PEDIDO
	SELECT p.id_pedido, p.numero_documento, strftime('%d/%m/%Y', date(p.fecha_registro))[fecha_registro], p.monto_total, p.id_proveedor,
	d.id_detallepedido, d.cantidad, d.monto_total, d.id_producto 
	FROM pedidos_proveedor p
	JOIN detalle_pedido d ON p.id_pedido=d.id_pedido
	WHERE p.id_pedido = @id_pedido AND p.estado=1;
END

CREATE PROCEDURE AGREGARPEDIDO(
    @numero_documento VARCHAR(12),
    @fecha_registro DATE,
    @sub_total MONEY,
    @id_proveedor BIGINT,
    @cantidad INT,
    @monto_total MONEY,
	@id_producto BIGINT
)
AS
BEGIN
    DECLARE @id_pedido BIGINT;

    CREATE TABLE #TEMP (
        Id BIGINT
    );

    INSERT INTO pedidos_proveedor (
        numero_documento, fecha_registro, monto_total,
        estado, id_proveedor 
    ) VALUES (
        @numero_documento, @fecha_registro,@sub_total,
		1, @id_proveedor 
    );

    SET @id_pedido = SCOPE_IDENTITY();

    INSERT INTO detalle_pedido (
        id_pedido, cantidad, monto_total, estado, id_producto
    ) VALUES (
        @id_pedido, @cantidad, @monto_total, 1, @id_producto
    );

    UPDATE PRODUCTO 
    SET precio_unidad = @precio_unidad, precio_venta = @precio_venta, stock = (stock + @cantidad) 
    WHERE id_producto = @id_producto;

    DROP TABLE #TEMP;
END

CREATE PROCEDURE RESUMENPEDIDO
AS
BEGIN
--MUESTRA INFORMACIÓN DEL PEDIDO
	SELECT p.id_pedido, p.numero_documento, strftime('%d/%m/%Y', date(p.fecha_registro))[fecha_registro], p.monto_total, p.id_proveedor,
	d.id_detallepedido, d.cantidad, d.monto_total, d.id_producto 
	FROM pedidos_proveedor p
	INNER JOIN detalle_pedido d ON p.id_pedido=d.id_pedido
	WHERE DATE(p.fecha_registro) BETWEEN DATE(@fechainicio) AND DATE(@fechafin) AND p.estado=1;
END

CREATE PROCEDURE OBTENERNUMERODOCUMENTO
@numero_documento VARCHAR(12)
AS
BEGIN
SELECT id_pedido, numero_documento, strftime('%d/%m/%Y', date(p.fecha_registro))[fecha_registro], monto_total, id_proveedor
FROM pedidos_proveedor 
WHERE numero_documento = @numero_documento AND estado = 1
END

------------------------------------------------------
------------------------------------------------------
--PARTE DE EDÚ - APLICADO A EL ENTORNO DE USUARIOS 

-- Agregar Usuario
CREATE PROCEDURE AgregarUsuario

	@usuario VARCHAR(50),
	@clave VARCHAR(50),
	@estado BIT,
	@id_rol BIGINT,
	@id_empleado BIGINT

AS
BEGIN

	INSERT INTO usuarios(usuario, clave, estado, id_rol, id_empleado)
	VALUES (@usuario, @clave, @estado, @id_rol, @id_empleado)
END

-- Modificar usuario
CREATE PROCEDURE ModificarUsuario

	@id_usuario BIGINT,
	@usuario VARCHAR(50),
	@clave VARCHAR(50),
	@estado BIT,
	@id_rol BIGINT,
	@id_empleado BIGINT

AS
BEGIN

	UPDATE usuarios 
	SET usuario=@usuario, clave=@clave, estado=@estado, id_rol=@id_rol, id_empleado=@id_empleado
	WHERE id_usuario=@id_usuario
END

-- Eliminar usuario
CREATE PROCEDURE EliminarUsuario

	@id_usuario BIGINT,
	@estado BIT

AS
BEGIN

	UPDATE usuarios 
	SET estado=0
	WHERE id_usuario=@id_usuario
END

-- Listar usuario alfabeticamente
CREATE PROCEDURE ListarUsarioAlfabeticamente

AS
BEGIN

	SELECT * 
	FROM usuarios u
	INNER JOIN roles r ON u.id_rol =  r.id_rol
	INNER JOIN empleados e ON u.id_empleado = e.id_empleado
	WHERE u.estado=1
	ORDER BY u.usuario ASC
END

-- Listar usuario no alfabeticamente
CREATE PROCEDURE ListarUsuariosNoAlfabeticamente

AS
BEGIN

	SELECT *
	FROM usuarios u
	INNER JOIN roles r ON u.id_rol =  r.id_rol
	INNER JOIN empleados e ON u.id_empleado = e.id_empleado
	WHERE u.estado=1
	ORDER BY u.usuario DESC
END

-- Buscar usuario por ID
CREATE PROCEDURE BuscarUsuarioID

	@id_usuario BIGINT

AS
BEGIN

	SELECT * FROM usuarios
	WHERE id_usuario=@id_usuario AND estado=1n 
END

-- Buscar usuarios por nombre
CREATE PROCEDURE BuscarUsuariosNombre

	@usuario VARCHAR(50)

AS
BEGIN

	SELECT * FROM usuarios
	WHERE usuario LIKE '%' + @usuario + '%' AND estado=1
END

-- Verificar si el usuario existe
CREATE PROCEDURE VerificarUsuario

	@usuario VARCHAR(45)

AS
BEGIN

	SET NOCOUNT ON;
	IF EXISTS(SELECT * FROM usuarios WHERE usuario=@usuario)
		SELECT 1 AS Resultado
	ELSE
		SELECT 0 AS Resultado
END


--join para saber que tipo de permiso/rol tiene cada usuario
CREATE PROCEDURE PermisosUsuario

	@id_usuario BIGINT

AS
BEGIN

	Select u.usuario, r.rol, o.opcion
	From usuarios u
	inner join roles r on u.id_rol=r.id_rol
	inner join permisos p on r.id_rol=p.id_rol
	inner join opciones o on p.id_opcion=o.id_opcion
	where u.id_usuario = @id_usuario
END

--*********************************************************************
--******* PROVEEDOR ***************************************************

-- Agregar Proveedor
CREATE PROCEDURE AgregarProveedor

	@nombre VARCHAR(50),
	@numeroDocumeto VARCHAR(50),
	@esLaboratorio BIT

AS
BEGIN

	INSERT INTO proveedores(proveedor, numero_documento, esLaboratorio)
	VALUES (@nombre, @numeroDocumeto, @esLaboratorio)
END

-- Modificar proveedor
CREATE PROCEDURE ModificarProveedor

	@id_proveedor BIGINT,
	@nombre VARCHAR(50),
	@numeroDocumeto VARCHAR(50),
	@esLaboratorio BIT

AS
BEGIN

	UPDATE proveedores 
	SET proveedor=@nombre, numero_documento=@numeroDocumeto, esLaboratorio=@esLaboratorio
	WHERE id_proveedor = @id_proveedor;
END

-- Eliminar proveedor
CREATE PROCEDURE EliminarProveedor

	@id_proveedor BIGINT

AS
BEGIN

	delete from proveedores WHERE id_proveedor=@id_proveedor
END

exec AgregarProveedor 'Lenovo', '11223344', 0;
exec ModificarProveedor 6, 'Lenovo', numdoc12, 1;
exec EliminarProveedor 6;
select * from proveedores

-- Listar usuario alfabeticamente
CREATE PROCEDURE ListarUsarioAlfabeticamente

AS
BEGIN

	SELECT * 
	FROM usuarios u
	INNER JOIN roles r ON u.id_rol =  r.id_rol
	INNER JOIN empleados e ON u.id_empleado = e.id_empleado
	WHERE u.estado=1
	ORDER BY u.usuario ASC
END

-- Listar usuario no alfabeticamente
CREATE PROCEDURE ListarUsuariosNoAlfabeticamente

AS
BEGIN

	SELECT *
	FROM usuarios u
	INNER JOIN roles r ON u.id_rol =  r.id_rol
	INNER JOIN empleados e ON u.id_empleado = e.id_empleado
	WHERE u.estado=1
	ORDER BY u.usuario DESC
END

-- Buscar usuario por ID
CREATE PROCEDURE BuscarUsuarioID

	@id_usuario BIGINT

AS
BEGIN

	SELECT * FROM usuarios
	WHERE id_usuario=@id_usuario AND estado=1n 
END

-- Buscar usuarios por nombre
CREATE PROCEDURE BuscarUsuariosNombre

	@usuario VARCHAR(50)

AS
BEGIN

	SELECT * FROM usuarios
	WHERE usuario LIKE '%' + @usuario + '%' AND estado=1
END

-- Verificar si el usuario existe
CREATE PROCEDURE VerificarUsuario

	@usuario VARCHAR(45)

AS
BEGIN

	SET NOCOUNT ON;
	IF EXISTS(SELECT * FROM usuarios WHERE usuario=@usuario)
		SELECT 1 AS Resultado
	ELSE
		SELECT 0 AS Resultado
END


--join para saber que tipo de permiso/rol tiene cada usuario
CREATE PROCEDURE PermisosUsuario

	@id_usuario BIGINT

AS
BEGIN

	Select u.usuario, r.rol, o.opcion
	From usuarios u
	inner join roles r on u.id_rol=r.id_rol
	inner join permisos p on r.id_rol=p.id_rol
	inner join opciones o on p.id_opcion=o.id_opcion
	where u.id_usuario = @id_usuario
END

