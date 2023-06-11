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
INSERT INTO productos(codigo_barras,descripcion,precio_unidad,precio_venta,stock,nombre,fecha_ingreso,
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

	@id_producto BIGINT

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
WHERE p.estado=1
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
WHERE p.estado=1
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

-- LISTAR CLIENTE
GO
CREATE PROCEDURE LISTARCLIENTEOPCION
@opcion INT
AS
BEGIN
    IF @opcion = 1
    BEGIN
        --ListarCliente ultimo agregado
        SELECT c.*,
			   d.*,
			   m.*
		FROM clientes c
		LEFT JOIN direcciones d ON c.id_direccion = d.id_direccion
		LEFT JOIN municipios m ON d.id_municipio = m.id_municipio
		WHERE c.estado = 1
		ORDER BY id_cliente DESC
    END
    ELSE IF @opcion = 2
    BEGIN
        --ListarCliente primero agregado
        SELECT c.*,
			   d.*,
			   m.*
		FROM clientes c
		LEFT JOIN direcciones d ON c.id_direccion = d.id_direccion
		LEFT JOIN municipios m ON d.id_municipio = m.id_municipio
		WHERE c.estado = 1
		ORDER BY id_cliente ASC
    END
    ELSE IF @opcion = 3
    BEGIN
        --Listar clientes a-z
        SELECT c.*,
			   d.*,
			   m.*
		FROM clientes c
		LEFT JOIN direcciones d ON c.id_direccion = d.id_direccion
		LEFT JOIN municipios m ON d.id_municipio = m.id_municipio
		WHERE c.estado=1
		ORDER BY nombre ASC
    END
    ELSE IF @opcion = 4
    BEGIN
        --Listar clientes z-a
        SELECT c.*,
			   d.*,
			   m.*
		FROM clientes c
		LEFT JOIN direcciones d ON c.id_direccion = d.id_direccion
		LEFT JOIN municipios m ON d.id_municipio = m.id_municipio
		WHERE c.estado=1
		ORDER BY nombre DESC
    END
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
DECLARE @id_direccion BIGINT
INSERT INTO direcciones(numero_casa,pasaje_poligono,calle,colonia,canton,caserio,codigo_postal,estado,id_municipio)
VALUES (@numero_casa,@pasaje_poligono,@calle,@colonia,@canton,@caserio,@codigo_postal,1,@id_municipio)

SET @id_direccion = SCOPE_IDENTITY()

INSERT INTO clientes(identificacion,nombre,credito, estado,id_direccion)
VALUES (@identificacion,@nombre,@credito,1,@id_direccion)
END

--MODIFICAR CLIENTES--

ALTER PROCEDURE ModificarClientes
@id_cliente BIGINT,
@identificacion VARCHAR(45),
@nombre VARCHAR(100),
@credito FLOAT,
@numero_casa VARCHAR(10),
@pasaje_poligono VARCHAR(50),
@calle VARCHAR(50),
@colonia VARCHAR(50),
@canton VARCHAR(50),
@caserio VARCHAR(50),
@codigo_postal VARCHAR(10),
@id_municipio BIGINT,
@id_direcccion BIGINT
AS
BEGIN
UPDATE clientes
SET identificacion=@identificacion,nombre=@nombre,credito=@credito,estado=1,id_direccion=@id_direcccion
WHERE id_cliente=@id_cliente

UPDATE direcciones
SET numero_casa=@numero_casa,pasaje_poligono=@pasaje_poligono,calle=@calle,colonia=@colonia,canton=@canton,caserio=@caserio,codigo_postal=@codigo_postal,estado=1,id_municipio=@id_municipio
WHERE id_direccion = (SELECT id_direccion FROM clientes WHERE id_cliente=@id_cliente)

END

--ELIMINAR CLIENTES--

CREATE PROCEDURE EliminarClientes

	@id_cliente BIGINT

AS
BEGIN
	UPDATE clientes 
	SET estado=0
	WHERE id_cliente=@id_cliente

	UPDATE direcciones 
	SET estado=0
	WHERE id_direccion= (SELECT id_direccion FROM clientes WHERE id_cliente=@id_cliente)
END

SELECT * FROM clientes WHERE estado=1

--***************************************************************************************************************************--

/*PROCEDIMIENTOS ALMACENADOS PARA CLIENTES*/

--LISTAR PEDIDOS--

CREATE PROCEDURE ListarPedidos
AS
BEGIN
SELECT pp.id_pedido, pp.numero_documento, pp.fecha_registro, pp.monto_total
FROM pedidos_proveedor pp
INNER JOIN proveedores p ON pp.id_proveedor = p.id_proveedor
WHERE pp.estado=1
ORDER BY id_pedido DESC
END

--LISTAR PEDIDOS POR ANTIGUEDAD--

CREATE PROCEDURE LISTARPEDIDOSXANTIGUEDAD
AS
BEGIN
SELECT pp.id_pedido, pp.numero_documento, pp.fecha_registro, pp.monto_total
FROM pedidos_proveedor pp
INNER JOIN proveedores p ON pp.id_proveedor = p.id_proveedor
WHERE pp.estado=1
ORDER BY fecha_registro ASC
END

--LISTAR PEDIDOS POR MÁS RECIENTES--

CREATE PROCEDURE LISTARPEDIDOSMÁSRECIENTES
AS
BEGIN
SELECT pp.id_pedido, pp.numero_documento, pp.fecha_registro, pp.monto_total
FROM pedidos_proveedor pp
INNER JOIN proveedores p ON pp.id_proveedor = p.id_proveedor
WHERE pp.estado=1
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

-- LISTAR PEDIDO
GO
ALTER PROCEDURE LISTARPEDIDOOPCION
@opcion INT
AS
BEGIN
    IF @opcion = 1
    BEGIN
        --ListarPEDIDO ultimo agregado
        SELECT pp.id_pedido, pp.numero_documento, pp.fecha_registro, pp.monto_total, p.proveedor
		FROM pedidos_proveedor pp
		LEFT JOIN proveedores p ON pp.id_proveedor = p.id_proveedor
		WHERE pp.estado=1
		ORDER BY pp.id_pedido DESC
    END
    ELSE IF @opcion = 2
    BEGIN
        --ListarPEDIDO primero agregado
        SELECT pp.id_pedido, pp.numero_documento, pp.fecha_registro, pp.monto_total, p.proveedor
		FROM pedidos_proveedor pp
		LEFT JOIN proveedores p ON pp.id_proveedor = p.id_proveedor
		WHERE pp.estado=1
		ORDER BY pp.id_pedido ASC
    END
    ELSE IF @opcion = 3
    BEGIN
        --Listar PEDIDO a-z
        SELECT pp.id_pedido, pp.numero_documento, pp.fecha_registro, pp.monto_total, p.proveedor
		FROM pedidos_proveedor pp
		LEFT JOIN proveedores p ON pp.id_proveedor = p.id_proveedor
		WHERE pp.estado=1
		ORDER BY p.proveedor ASC
    END
    ELSE IF @opcion = 4
    BEGIN
        --Listar PEDIDO z-a
        SELECT pp.id_pedido, pp.numero_documento, pp.fecha_registro, pp.monto_total, p.proveedor
		FROM pedidos_proveedor pp
		LEFT JOIN proveedores p ON pp.id_proveedor = p.id_proveedor
		WHERE pp.estado=1
		ORDER BY p.proveedor DESC
    END
END

EXEC LISTARPEDIDOOPCION 4
------------------------------------------------------
------------------------------------------------------
--PARTE DE EDÚ - APLICADO A EL ENTORNO DE USUARIOS 

---- Agregar Usuario
--CREATE PROCEDURE AgregarUsuario

--	@usuario VARCHAR(50),
--	@clave VARCHAR(50),
--	@estado BIT,
--	@id_rol BIGINT,
--	@id_empleado BIGINT

--AS
--BEGIN

--	INSERT INTO usuarios(usuario, clave, estado, id_rol, id_empleado)
--	VALUES (@usuario, @clave, @estado, @id_rol, @id_empleado)
--END

---- Modificar usuario
--CREATE PROCEDURE ModificarUsuario

--	@id_usuario BIGINT,
--	@usuario VARCHAR(50),
--	@clave VARCHAR(50),
--	@estado BIT,
--	@id_rol BIGINT,
--	@id_empleado BIGINT

--AS
--BEGIN

--	UPDATE usuarios 
--	SET usuario=@usuario, clave=@clave, estado=@estado, id_rol=@id_rol, id_empleado=@id_empleado
--	WHERE id_usuario=@id_usuario
--END

---- Eliminar usuario
--CREATE PROCEDURE EliminarUsuario

--	@id_usuario BIGINT

--AS
--BEGIN

--	UPDATE usuarios 
--	SET estado=0
--	WHERE id_usuario=@id_usuario
--END

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
	VALUES (@usuario, @clave, 1, @id_rol, @id_empleado)
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
	SET usuario=@usuario, clave=@clave, estado=1, id_rol=@id_rol, id_empleado=@id_empleado
	WHERE id_usuario=@id_usuario
END

-- Eliminar usuario
CREATE PROCEDURE EliminarUsuario

	@id_usuario BIGINT

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
	@esLaboratorio BIT,
	@estado bit

AS
BEGIN

	INSERT INTO proveedores(proveedor, numero_documento, esLaboratorio, estado)
	VALUES (@nombre, @numeroDocumeto, @esLaboratorio, @estado)
END

-- Modificar proveedor
CREATE PROCEDURE ModificarProveedor

	@id_proveedor BIGINT,
	@nombre VARCHAR(50),
	@numeroDocumeto VARCHAR(50),
	@esLaboratorio BIT,
	@estado bit

AS
BEGIN

	UPDATE proveedores 
	SET proveedor=@nombre, numero_documento=@numeroDocumeto, esLaboratorio=@esLaboratorio, estado=@estado
	WHERE id_proveedor = @id_proveedor;
END

-- Eliminar proveedor
CREATE PROCEDURE EliminarProveedor

	@id_proveedor BIGINT

AS
BEGIN

	UPDATE proveedores
	SET estado=0
	WHERE id_proveedor=@id_proveedor
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


--*********************************************************************
--******* AREAS ***************************************************

-- Agregar Areas
GO
CREATE PROCEDURE AgregarAreas

	@area VARCHAR(50),
	@estado bit

AS
BEGIN

	INSERT INTO areas(area, estado)
	VALUES (@area, @estado)
END

-- Modificar Areas
GO
CREATE PROCEDURE ModificarAreas

	@id_area BIGINT,
	@area VARCHAR(50),
	@estado bit

AS
BEGIN

	UPDATE areas 
	SET area=@area, estado=@estado
	WHERE id_area = @id_area;
END

-- Eliminar Areas
GO
CREATE PROCEDURE EliminarAreas

	@id_area BIGINT

AS
BEGIN

	UPDATE areas
	SET  estado=0 
	WHERE id_area=@id_area

END


--*********************************************************************
--******* DETALLE FACTURA ***************************************************

-- Agregar Detalle Factura
GO
CREATE PROCEDURE AgregarDetalleFactura

	@precioUnitario money,
	@precioVenta money,
	@cantidad int,
	@idProducto bigint,
	@estado bit

AS
BEGIN
	DECLARE @IdFactura INT

    -- Obtener el último ID de la tabla "facturas"
    SELECT @IdFactura = MAX(id_factura) FROM facturas

	INSERT INTO detalle_factura(precio_unitario, precio_venta, cantidad, id_producto, id_factura, estado)
	VALUES (@precioUnitario, @precioVenta, @cantidad, @idProducto, @IdFactura, @estado)

	UPDATE productos 
    SET stock = (stock - @cantidad) 
    WHERE id_producto = @idProducto;
END

-- Modificar Detalle Factura
GO
CREATE PROCEDURE ModificarDetalleFactura

	@idDetalleFactura bigint,
	@precioUnitario money,
	@precioVenta money,
	@cantidad int,
	@idProducto bigint,
	@idFactura bigint,
	@estado bit

AS
BEGIN

	UPDATE detalle_factura
	SET precio_unitario=@precioUnitario, precio_venta=@precioVenta, cantidad=@cantidad, id_producto=@idProducto, id_factura=@idFactura, estado=@estado
	WHERE id_detallefactura = @idDetalleFactura;
END

---- Eliminar Detalle Factura
--GO
--CREATE PROCEDURE EliminarDetalleFactura

--	@idDetalleFactura BIGINT

--AS
--BEGIN

--	delete from detalle_factura WHERE id_area=@id_area

--END*/

--*********************************************************************
--******* DETALLE PEDIDO ***************************************************

-- Agregar Detalle Pedido
/*GO
CREATE PROCEDURE AgregarDetallePedido

	@cantidad int,
	@montoTotal money,
	@estado bit,
	@idPedido bigint,
	@idProducto bigint

AS
BEGIN

	INSERT INTO detalle_pedido(cantidad, monto_total, estado, id_pedido, id_producto)
	VALUES (@cantidad, @montoTotal, @estado, @idPedido, @idProducto)
END

-- Modificar Detalle Pedido
GO
CREATE PROCEDURE ModificarDetallePedido

	@idDetallePedido bigint,
	@cantidad int,
	@montoTotal money,
	@estado bit,
	@idProducto bigint,
	@idPedido bigint

AS
BEGIN

	UPDATE detalle_pedido
	SET cantidad=@cantidad, monto_total=@montoTotal, estado=@estado, id_pedido=@idPedido, id_producto=@idProducto
	WHERE id_detallepedido = @idDetallePedido;
END
*/
--*********************************************************************
--******* Direcciones ***************************************************

-- Agregar Direcciones
/*GO
CREATE PROCEDURE AgregarDirecciones

	@numeroCasa varchar(10),
	@pasajePoligono varchar(50),
	@calle varchar(50),
	@colonia varchar(50),
	@canton varchar(50),
	@caserio varchar(50),
	@codigoPostal varchar(10),
	@estado bit,
	@idMunicipio int

AS
BEGIN

	INSERT INTO direcciones(numero_casa, pasaje_poligono, calle, colonia, canton, caserio, codigo_postal, estado, id_municipio)
	VALUES (@numeroCasa, @pasajePoligono, @calle, @colonia, @canton, @caserio, @codigoPostal, @estado, @idMunicipio)
END

-- Modificar Direcciones
GO
CREATE PROCEDURE ModificarDirecciones

	@idDireccion bigint,
	@numeroCasa varchar(10),
	@pasajePoligono varchar(50),
	@calle varchar(50),
	@colonia varchar(50),
	@canton varchar(50),
	@caserio varchar(50),
	@codigoPostal varchar(10),
	@estado bit,
	@idMunicipio int

AS
BEGIN

	UPDATE direcciones 
	SET numero_casa=@numeroCasa, pasaje_poligono=@pasajePoligono, calle=@calle, colonia=@colonia, canton=@canton, caserio=@caserio, codigo_postal=@codigoPostal, estado=@estado, id_municipio=@idMunicipio
	WHERE id_direccion = @idDireccion;
END

-- Eliminar Direcciones
GO
CREATE PROCEDURE EliminarDirecciones

	@idDireccion bigint

AS
BEGIN

	UPDATE direcciones
	SET estado=0 
	WHERE id_direccion=@idDireccion

END
*/

--*********************************************************************
--******* Empleados ***************************************************

-- Agregar Empleados
/*GO
CREATE PROCEDURE AgregarEmpleados

	@nombre varchar(50),
	@apellido varchar(50),
	@genero varchar(50),
	@telefono varchar(50),
	@correo varchar(50),
	@DUI varchar(50),
	@fechaNac date,
	@estado bit,
	@idDireccion int

AS
BEGIN

	INSERT INTO empleados(nombre, apellido, genero, telefono, correo, DUI, fechanac, id_direccion, estado)
	VALUES (@nombre, @apellido, @genero, @telefono, @correo, @DUI, @fechaNac, @idDireccion, @estado)
END

-- Modificar Empleados
GO
CREATE PROCEDURE ModificarEmpleados

	@idEmpleado bigint,
	@nombre varchar(50),
	@apellido varchar(50),
	@genero varchar(50),
	@telefono varchar(50),
	@correo varchar(50),
	@DUI varchar(50),
	@fechaNac date,
	@estado bit,
	@idDireccion int

AS
BEGIN

	UPDATE empleados 
	SET nombre=@nombre, apellido=@apellido, genero=@genero, telefono=@telefono, correo=@correo, DUI=@DUI, fechanac=@fechaNac, id_direccion=@idDireccion, estado=@estado
	WHERE id_empleado = @idEmpleado;
END

-- Eliminar Empleados
GO
CREATE PROCEDURE EliminarEmpleados

	@idEmpleado bigint

AS
BEGIN

	UPDATE empleados
	SET estado=0 
	WHERE id_empleado=@idEmpleado

END*/

--AGREGAR CLIENTES--

CREATE PROCEDURE AgregarEmpleados

	@nombre varchar(50),
	@apellido varchar(50),
	@genero varchar(50),
	@telefono varchar(50),
	@correo varchar(50),
	@DUI varchar(50),
	@fechaNac date,
	@estado bit,
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
DECLARE @id_direccion BIGINT
INSERT INTO direcciones(numero_casa,pasaje_poligono,calle,colonia,canton,caserio,codigo_postal,id_municipio)
VALUES (@numero_casa,@pasaje_poligono,@calle,@colonia,@canton,@caserio,@codigo_postal,@id_municipio)

SET @id_direccion = SCOPE_IDENTITY()

INSERT INTO empleados(nombre, apellido, genero, telefono, correo, DUI, fechanac, id_direccion, estado)
	VALUES (@nombre, @apellido, @genero, @telefono, @correo, @DUI, @fechaNac, @idDireccion, @estado)
END

--MODIFICAR CLIENTES--

CREATE PROCEDURE ModificarEmpleados
	@idEmpleado bigint,
	@nombre varchar(50),
	@apellido varchar(50),
	@genero varchar(50),
	@telefono varchar(50),
	@correo varchar(50),
	@DUI varchar(50),
	@fechaNac date,
	@estado bit,
	@numero_casa VARCHAR(10),
	@pasaje_poligono VARCHAR(50),
	@calle VARCHAR(50),
	@colonia VARCHAR(50),
	@canton VARCHAR(50),
	@caserio VARCHAR(50),
	@codigo_postal VARCHAR(10),
	@id_municipio BIGINT,
	@idDireccion BIGINT
AS
BEGIN
UPDATE empleados 
	SET nombre=@nombre, apellido=@apellido, genero=@genero, telefono=@telefono, correo=@correo, DUI=@DUI, fechanac=@fechaNac, id_direccion=@idDireccion, estado=@estado
	WHERE id_empleado = @idEmpleado;

UPDATE direcciones
SET numero_casa=@numero_casa,pasaje_poligono=@pasaje_poligono,calle=@calle,colonia=@colonia,canton=@canton,caserio=@caserio,codigo_postal=@codigo_postal,id_municipio=@id_municipio
WHERE id_direccion = (SELECT id_direccion FROM empleados WHERE id_empleado=@idEmpleado)

END

--ELIMINAR CLIENTES--

CREATE PROCEDURE EliminarEmpleados

	@idEmpleado BIGINT,
	@idDireccion BIGINT

AS
BEGIN
	UPDATE empleados 
	SET estado=0
	WHERE id_empleado = @idEmpleado;

	UPDATE direcciones 
	SET estado=0
	WHERE id_direccion= (SELECT id_direccion FROM empleados WHERE id_empleado=@idEmpleado)
END

--*********************************************************************
--******* Factura ***************************************************

-- Agregar Factura
GO

CREATE PROCEDURE AgregarFactura

	@fecha date,
	@descripcion varchar(100),
	@numeroDocumento varchar(12),
	@montoTotal money,
	@cantidadProductos int,
	@montoCliente money,
	@cambio money,
	@estado bit,
	@idTipoPago int,
	@idEmpleado int,
	@idCliente int,

	@precioUnitario money,
	@precioVenta money,
	@cantidad int,
	@idProducto bigint

AS
BEGIN
	

	BEGIN TRY
        DECLARE @id_Factura BIGINT;

        INSERT INTO facturas(fecha, descripcion, numero_documento, monto_total, cantidad_productos, monto_cliente, cambio, estado, id_tipopago, id_empleado, id_cliente)
		VALUES (@fecha, @descripcion, @numeroDocumento, @montoTotal, @cantidadProductos, @montoCliente, @cambio, 1, @idTipoPago, @idEmpleado, @idCliente)

		SELECT @id_Factura = MAX(id_factura) FROM facturas
		INSERT INTO detalle_factura(precio_unitario, precio_venta, cantidad, id_producto, id_factura, estado)
		VALUES (@precioUnitario, @precioVenta, @cantidad, @idProducto, @id_Factura, 1)
	
        UPDATE productos 
        SET stock = (stock - @cantidad) 
        WHERE id_producto = @idProducto;

    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        -- Use RAISERROR inside the CATCH block to return 
        -- error information about the original error that 
        -- caused execution to jump to the CATCH block.
        RAISERROR (@ErrorMessage, -- Message text.
                   @ErrorSeverity, -- Severity.
                   @ErrorState -- State.
                   );
    END CATCH
	
END

-- LISTAR VENTA
GO
CREATE PROCEDURE LISTARVENTAOPCION
@opcion INT
AS
BEGIN
    IF @opcion = 1
    BEGIN
        --ListarPEDIDO ultimo agregado
        SELECT pp.id_factura, pp.fecha, pp.descripcion, pp.numero_documento, pp.monto_total, pp.cantidad_productos,
        pp.monto_cliente, pp.cambio, s.tipo_pago, CONCAT(p.nombre, ' ', p.apellido) AS NombreCompleto, c.nombre
        FROM facturas pp
        LEFT JOIN empleados p ON pp.id_empleado = p.id_empleado
        LEFT JOIN tipo_pagos s ON pp.id_tipopago = s.id_tipopago
        LEFT JOIN clientes c ON pp.id_cliente = c.id_cliente
        WHERE pp.estado=1
        ORDER BY pp.id_factura DESC
    END
    ELSE IF @opcion = 2
    BEGIN
        SELECT pp.id_factura, pp.fecha, pp.descripcion, pp.numero_documento, pp.monto_total, pp.cantidad_productos,
        pp.monto_cliente, pp.cambio, s.tipo_pago, CONCAT(p.nombre, ' ', p.apellido) AS NombreCompleto, c.nombre
        FROM facturas pp
        LEFT JOIN empleados p ON pp.id_empleado = p.id_empleado
        LEFT JOIN tipo_pagos s ON pp.id_tipopago = s.id_tipopago
        LEFT JOIN clientes c ON pp.id_cliente = c.id_cliente
        WHERE pp.estado=1
        ORDER BY pp.id_factura ASC
    END
    ELSE IF @opcion = 3
    BEGIN
        SELECT pp.id_factura, pp.fecha, pp.descripcion, pp.numero_documento, pp.monto_total, pp.cantidad_productos,
        pp.monto_cliente, pp.cambio, s.tipo_pago, CONCAT(p.nombre, ' ', p.apellido) AS NombreCompleto, c.nombre
        FROM facturas pp
        LEFT JOIN empleados p ON pp.id_empleado = p.id_empleado
        LEFT JOIN tipo_pagos s ON pp.id_tipopago = s.id_tipopago
        LEFT JOIN clientes c ON pp.id_cliente = c.id_cliente
        WHERE pp.estado=1
        ORDER BY pp.fecha DESC
    END
    ELSE IF @opcion = 4
    BEGIN
        --Listar PEDIDO z-a
        SELECT pp.id_factura, pp.fecha, pp.descripcion, pp.numero_documento, pp.monto_total, pp.cantidad_productos,
        pp.monto_cliente, pp.cambio, s.tipo_pago, CONCAT(p.nombre, ' ', p.apellido) AS NombreCompleto, c.nombre
        FROM facturas pp
        LEFT JOIN empleados p ON pp.id_empleado = p.id_empleado
        LEFT JOIN tipo_pagos s ON pp.id_tipopago = s.id_tipopago
        LEFT JOIN clientes c ON pp.id_cliente = c.id_cliente
        WHERE pp.estado=1
        ORDER BY pp.fecha ASC
    END
END

EXEC LISTARVENTAOPCION 1
----------------------------------------------------
GO
CREATE PROCEDURE AgregarFactura

	@fecha date,
	@descripcion varchar(100),
	@numeroDocumento varchar(12),
	@montoTotal money,
	@cantidadProductos int,
	@montoCliente money,
	@cambio money,
	@estado bit,
	@idTipoPago int,
	@idEmpleado int,
	@idCliente int

AS
BEGIN

        INSERT INTO facturas(fecha, descripcion, numero_documento, monto_total, cantidad_productos, monto_cliente, cambio, estado, id_tipopago, id_empleado, id_cliente)
		VALUES (@fecha, @descripcion, @numeroDocumento, @montoTotal, @cantidadProductos, @montoCliente, @cambio, 1, @idTipoPago, @idEmpleado, @idCliente)

END

-- Modificar Factura
GO
CREATE PROCEDURE ModificarFactura

	@idFactura bigint,
	@fecha date,
	@descripcion varchar(100),
	@numeroDocumento varchar(12),
	@montoTotal money,
	@cantidadProductos int,
	@montoCliente money,
	@cambio money,
	@estado bit,
	@idTipoPago int,
	@idEmpleado int,
	@idCliente int,

	@precioUnitario money,
	@precioVenta money,
	@cantidad int,
	@idProducto bigint,
	@id_detallefactura bigint

AS
BEGIN

	UPDATE facturas 
	SET fecha=@fecha, descripcion=@descripcion, numero_documento=@numeroDocumento, monto_total=@montoTotal, cantidad_productos=@cantidadProductos, monto_cliente=@montoCliente, cambio=@cambio, estado=@estado, id_tipopago=@idTipoPago, id_empleado=@idEmpleado, id_cliente=@idCliente
	WHERE id_factura = @idFactura;

	UPDATE detalle_factura
	SET precio_unitario=@precioUnitario, precio_venta=@precioVenta, cantidad=@cantidad, id_producto=@idProducto, id_factura=@idFactura, estado=1
	WHERE id_detallefactura = @id_detallefactura;

	UPDATE productos 
        SET stock = (stock - @cantidad) 
        WHERE id_producto = @idProducto;
END

-- Eliminar Factura
GO
CREATE PROCEDURE EliminarFactura

	@idFactura bigint,
	@id_detallefactura bigint

AS
BEGIN

	UPDATE facturas
	SET estado=0 
	WHERE id_factura=@idFactura;

	UPDATE detalle_factura
	SET estado=0
	WHERE id_detallefactura = @id_detallefactura;

END

--*********************************************************************
--******* Municipio ***************************************************

-- Agregar Municipio
GO
CREATE PROCEDURE AgregarMunicipio

	@municipio varchar(50),
	@estado bit,
	@idDepartamento int

AS
BEGIN

	INSERT INTO municipios(municipio, estado, id_departamento)
	VALUES (@municipio, @estado, @idDepartamento)
END

-- Modificar Municipio
GO
CREATE PROCEDURE ModificarMunicipio

	@idMunicipio bigint,
	@municipio varchar(50),
	@estado bit,
	@idDepartamento int

AS
BEGIN

	UPDATE municipios 
	SET municipio=@municipio, estado=@estado, id_departamento=@idDepartamento
	WHERE id_municipio = @idMunicipio;
END

-- Eliminar Municipio
GO
CREATE PROCEDURE EliminarMunicipio

	@idMunicipio bigint

AS
BEGIN

	UPDATE municipios
	SET estado=0 
	WHERE id_municipio=@idMunicipio

END

--*********************************************************************
--******* Opciones ***************************************************

-- Agregar Opciones
GO
CREATE PROCEDURE AgregarOpciones

	@nombre varchar(100),
	@estado bit

AS
BEGIN

	INSERT INTO opciones(nombre, estado)
	VALUES (@nombre, @estado)
END

-- Modificar Opciones
GO
CREATE PROCEDURE ModificarOpciones

	@idOpciones bigint,
	@nombre varchar(100),
	@estado bit

AS
BEGIN

	UPDATE opciones 
	SET nombre=@nombre, estado=@estado
	WHERE id_opcion = @idOpciones;
END

-- Eliminar Opciones
GO
CREATE PROCEDURE EliminarOpciones

	@idOpcion bigint

AS
BEGIN

	UPDATE opciones
	SET estado=0 
	WHERE id_opcion=@idOpcion

END

--*********************************************************************
--******* Pedido Proveedor ***************************************************

-- Agregar Pedido Proveedor
/*GO
CREATE PROCEDURE AgregarPedidoProveedor

	@numeroDocumento varchar(12),
	@fecha date,
	@montoTotal money,
	@estado bit,
	@idProveedor bigint

AS
BEGIN

	INSERT INTO pedidos_proveedor(numero_documento, fecha_registro, monto_total, estado, id_proveedor)
	VALUES (@numeroDocumento, @fecha, @montoTotal, @estado, @idProveedor)
END

-- Modificar Pedido Proveedor
GO
CREATE PROCEDURE ModificarPedidoProveedor

	@idPedidoProveedor bigint,
	@numeroDocumento varchar(12),
	@fecha date,
	@montoTotal money,
	@estado bit,
	@idProveedor bigint

AS
BEGIN

	UPDATE pedidos_proveedor 
	SET numero_documento=@numeroDocumento, fecha_registro=@fecha, monto_total=@montoTotal, estado=@estado, id_proveedor=@idProveedor
	WHERE id_pedido = @idPedidoProveedor;
END

-- Eliminar Pedido Proveedor
GO
CREATE PROCEDURE EliminarPedidoProveedor

	@idProveedor bigint

AS
BEGIN

	UPDATE pedidos_proveedor
	SET estado=0 
	WHERE id_pedido=@idProveedor

END*/

CREATE PROCEDURE AgregarPedidoProveedor(

    @fecha_registro DATE,
    @monto_total MONEY,
    @id_proveedor BIGINT
)
AS
BEGIN
        INSERT INTO pedidos_proveedor (numero_documento, fecha_registro, monto_total, estado, id_proveedor ) 
		VALUES ('numdoc12', @fecha_registro, @monto_total, 1, @id_proveedor );

END

exec AgregarPedidoProveedor '2023-06-09', 6.99, 1;

--MODIFICAR PEDIDOS--

CREATE PROCEDURE MODIFICARPEDIDO(
	@id_pedido BIGINT,
    @numero_documento VARCHAR(12),
    @fecha_registro DATE,
    @sub_total MONEY,
    @id_proveedor BIGINT
	
)
AS
BEGIN
    BEGIN TRY
        --DECLARE @id_pedido BIGINT;

        UPDATE pedidos_proveedor 
		SET numero_documento = @numero_documento, fecha_registro = @fecha_registro, monto_total = monto_total,
		estado = 1, id_proveedor = @id_proveedor
		WHERE id_pedido = @id_pedido;

    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        -- Use RAISERROR inside the CATCH block to return 
        -- error information about the original error that 
        -- caused execution to jump to the CATCH block.
        RAISERROR (@ErrorMessage, -- Message text.
                   @ErrorSeverity, -- Severity.
                   @ErrorState -- State.
                   );
    END CATCH
END

--ELIMINAR PEDIDOS--

CREATE PROCEDURE ELIMINARPEDIDO(
	@id_pedido BIGINT
)
AS
BEGIN
    BEGIN TRY
        --DECLARE @id_pedido BIGINT;

        UPDATE pedidos_proveedor 
		SET estado = 0
		WHERE id_pedido = @id_pedido;


    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        -- Use RAISERROR inside the CATCH block to return 
        -- error information about the original error that 
        -- caused execution to jump to the CATCH block.
        RAISERROR (@ErrorMessage, -- Message text.
                   @ErrorSeverity, -- Severity.
                   @ErrorState -- State.
                   );
    END CATCH
END

--*********************************************************************
--******* DETALLE PEDIDO ***************************************************

-- Agregar Detalle Pedido
GO
CREATE PROCEDURE AgregarDetallePedido

	@cantidad int,
	@subTotal money,
	@idProducto bigint

AS
BEGIN
	DECLARE @IdPedido INT

    -- Obtener el último ID de la tabla "facturas"
    SELECT @IdPedido = MAX(id_pedido) FROM pedidos_proveedor

	INSERT INTO detalle_pedido(cantidad, monto_total, estado, id_pedido, id_producto)
	VALUES (@cantidad, @subTotal, 1, @IdPedido, @idProducto)

	UPDATE productos 
    SET stock = (stock + @cantidad) 
    WHERE id_producto = @idProducto;
END

-- Modificar Detalle Pedido
GO
CREATE PROCEDURE ModificarDetallePedido

	@idDetallePedido bigint,
	@cantidad int,
	@montoTotal money,
	@idProducto bigint,
	@idPedido bigint

AS
BEGIN

	UPDATE detalle_pedido
	SET cantidad=@cantidad, monto_total=@montoTotal, estado=1, id_pedido=@idPedido, id_producto=@idProducto
	WHERE id_detallepedido = @idDetallePedido;
END

--ELIMINAR PEDIDOS--

CREATE PROCEDURE EliminarDetallePedido(
	@id_detallepedido BIGINT
)
AS
BEGIN
    BEGIN TRY
        --DECLARE @id_pedido BIGINT;

        UPDATE detalle_pedido 
		SET estado = 0
		WHERE id_detallepedido = @id_detallepedido;


    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        -- Use RAISERROR inside the CATCH block to return 
        -- error information about the original error that 
        -- caused execution to jump to the CATCH block.
        RAISERROR (@ErrorMessage, -- Message text.
                   @ErrorSeverity, -- Severity.
                   @ErrorState -- State.
                   );
    END CATCH
END

--*********************************************************************
--******* Permisos ***************************************************

-- Agregar Permisos
GO
CREATE PROCEDURE AgregarPermisos

	@idRol int,
	@idSubOpcion bigint,
	@estado bit

AS
BEGIN

	INSERT INTO permisos(id_rol, id_subopcion, estado)
	VALUES (@idRol, @idSubOpcion, @estado)
END

-- Modificar Permisos
GO
CREATE PROCEDURE ModificarPermisos

	@idPermiso bigint,
	@idRol int,
	@idSubOpcion bigint,
	@estado bit

AS
BEGIN

	UPDATE permisos 
	SET id_rol=@idRol, id_subopcion=@idSubOpcion, estado=@estado
	WHERE id_permiso = @idPermiso;
END

-- Eliminar Permisos
GO
CREATE PROCEDURE EliminarPermisos

	@idPermiso bigint

AS
BEGIN

	UPDATE permisos
	SET estado=0 
	WHERE id_permiso=@idPermiso

END

--*********************************************************************
--******* Rol ***************************************************

-- Agregar Rol
GO
CREATE PROCEDURE AgregarRol

	@rol varchar(50),
	@estado bit

AS
BEGIN

	INSERT INTO roles(rol, estado)
	VALUES (@rol, @estado)
END

-- Modificar Rol
GO
CREATE PROCEDURE ModificarRol

	@idRol int,
	@rol varchar(50),
	@estado bit

AS
BEGIN

	UPDATE roles 
	SET rol=@rol, estado=@estado
	WHERE id_rol = @idRol;
END

-- Eliminar Rol
GO
CREATE PROCEDURE EliminarRol

	@idRol bigint

AS
BEGIN

	UPDATE roles
	SET estado=0 
	WHERE id_rol=@idRol

END

--*********************************************************************
--******* Sub Opcion ***************************************************

-- Agregar Sub Opcion
GO
CREATE PROCEDURE AgregarSubOpcion

	@idOpcion int,
	@nombre varchar(100),
	@nombreFormulario varchar(100),
	@estado bit

AS
BEGIN

	INSERT INTO subopciones(id_opcion, nombre, nombreFormulario, estado)
	VALUES (@idOpcion, @nombre, @nombreFormulario, @estado)
END

-- Modificar Sub Opcion
GO
CREATE PROCEDURE ModificarSubOpcion

	@idSubopcion bigint,
	@idOpcion int,
	@nombre varchar(100),
	@nombreFormulario varchar(100),
	@estado bit

AS
BEGIN

	UPDATE subopciones 
	SET id_opcion=@idOpcion, nombre=@nombre, nombreFormulario=@nombreFormulario, estado=@estado
	WHERE id_subopcion = @idSubopcion;
END

-- Eliminar Sub Opcion
GO
CREATE PROCEDURE EliminarSubOpcion

	@idSubopcion bigint

AS
BEGIN

	UPDATE subopciones
	SET estado=0 
	WHERE id_subopcion=@idSubopcion

END

--*********************************************************************
--******* Tipo Pago ***************************************************

-- Agregar Tipo Pago
GO
CREATE PROCEDURE AgregarTipoPago

	@tipoPago varchar(50),
	@estado bit

AS
BEGIN

	INSERT INTO tipo_pagos(tipo_pago, estado)
	VALUES (@tipoPago, @estado)
END

-- Modificar Tipo Pago
GO
CREATE PROCEDURE ModificarTipoPago

	@idTipopago int,
	@tipoPago varchar(50),
	@estado bit

AS
BEGIN

	UPDATE tipo_pagos 
	SET tipo_pago=@tipoPago, estado=@estado
	WHERE id_tipopago = @idTipopago;
END

-- Eliminar Tipo Pago
GO
CREATE PROCEDURE EliminarTipoPago

	@idTipopago int

AS
BEGIN

	UPDATE tipo_pagos
	SET estado=0
	WHERE id_tipopago=@idTipopago

END

--*********************************************************************
--******* Unidad Medida ***************************************************

-- Agregar Unidad Medida
GO
CREATE PROCEDURE AgregarUnidadMedida

	@unidadMedida varchar(45),
	@estado bit

AS
BEGIN

	INSERT INTO unidad_medida(unidad_medida, estado)
	VALUES (@unidadMedida, @estado)
END

-- Modificar Unidad Medida
GO
CREATE PROCEDURE ModificarUnidadMedida

	@idUnidadmedida int,
	@unidadMedida varchar(45),
	@estado bit

AS
BEGIN

	UPDATE unidad_medida 
	SET unidad_medida=@unidadMedida, estado=@estado
	WHERE id_unidadmedida = @idUnidadmedida;
END

-- Eliminar Unidad Medida
GO
CREATE PROCEDURE EliminarUnidadMedida

	@idUnidadmedida int

AS
BEGIN

	UPDATE unidad_medida
	SET estado=0
	WHERE id_unidadmedida=@idUnidadmedida

END

/*SE ANADEN NUEVAS CONSULTAS CON RESPECTO A PROVEEDORES*/

--LISTAR PROVEEDORES--

CREATE PROCEDURE ListarProveedores
AS
BEGIN
SELECT c.id_proveedor, c.proveedor, c.numero_documento, c.esLaboratorio,c.estado 
FROM proveedores c                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
WHERE c.estado = 1
ORDER BY c.id_proveedor DESC
END

--LISTAR PROVEEDORES ALFABETICAMENTE--

CREATE PROCEDURE LISTARPROVEEDORALFABETICAMENTE
AS
BEGIN
SELECT c.id_proveedor, c.proveedor, c.numero_documento, c.esLaboratorio,c.estado 
FROM proveedores c
WHERE c.estado=1
ORDER BY c.proveedor ASC
END

--LISTAR PROVEEDORES ALFABETICAMENTE INVERSO--

CREATE PROCEDURE LISTARPROVEEDORALFABETICAMENTEINVERSO
AS
BEGIN
SELECT c.id_proveedor, c.proveedor, c.numero_documento, c.esLaboratorio,c.estado 
FROM proveedores c
WHERE c.estado=1
ORDER BY c.proveedor DESC
END

--BUSCAR PROVEEDORES X IDENTIFICACION--

CREATE PROCEDURE BUSCARPROVEEDORXIDENTIFICACION
@id_proveedor VARCHAR(45)
AS
BEGIN
SELECT * FROM proveedor
WHERE id_proveedor LIKE '%' + @id_proveedor + '%' AND estado=1
END

--BUSCAR PROVEEDORES X NOMBRE--

CREATE PROCEDURE BUSCARPROVEEDORXNOMBRE
@nombre VARCHAR(45)
AS
BEGIN
SELECT * FROM proveedor
WHERE proveedor LIKE '%' + @nombre + '%' AND estado=1
END

---BUSCAR PROVEEDORES POR NUMERO DOCUMENTO

CREATE PROCEDURE BUSCARPROVEEDORXNOMBRE
@numero_documento VARCHAR(45)
AS
BEGIN
SELECT * FROM proveedor
WHERE numero_documento LIKE '%' + @numero_documento + '%' AND estado=1
END

-- LISTAR PROVEEDORES
GO
CREATE PROCEDURE LISTARPROVEEDORESOPCION
@opcion INT
AS
BEGIN
    IF @opcion = 1
    BEGIN
        --ListarProveedores
        SELECT c.id_proveedor, c.proveedor, c.numero_documento, c.esLaboratorio
        FROM proveedores c
        WHERE c.estado = 1
        ORDER BY c.id_proveedor DESC
    END
    ELSE IF @opcion = 2
    BEGIN
        --ListarProveedores
        SELECT c.id_proveedor, c.proveedor, c.numero_documento, c.esLaboratorio
        FROM proveedores c
        WHERE c.estado = 1
        ORDER BY c.id_proveedor ASC
    END
    ELSE IF @opcion = 3
    BEGIN
        --ListarProveedores
        SELECT c.id_proveedor, c.proveedor, c.numero_documento, c.esLaboratorio
        FROM proveedores c
        WHERE c.estado = 1
        ORDER BY c.proveedor ASC
    END
    ELSE IF @opcion = 4
    BEGIN
        --ListarProveedores
        SELECT c.id_proveedor, c.proveedor, c.numero_documento, c.esLaboratorio
        FROM proveedores c
        WHERE c.estado = 1
        ORDER BY c.proveedor DESC
    END
    ELSE IF @opcion = 5
    BEGIN
        --ListarProveedores
        SELECT c.id_proveedor, c.proveedor, c.numero_documento, c.esLaboratorio
        FROM proveedores c
        WHERE c.estado = 1 AND c.esLaboratorio = 1
        ORDER BY c.id_proveedor DESC
    END
END 


-- LISTAR DIRECCIONES
GO
CREATE PROCEDURE LISTARDIRECCIONOPCION
	@opcion INT
AS
BEGIN
    IF @opcion = 1
    BEGIN
        --ListarDirecciones
        SELECT d.*,
			   m.municipio,
			   dep.departamento
        FROM direcciones d
		INNER JOIN municipios m ON d.id_municipio=m.id_municipio
		INNER JOIN departamentos dep ON m.id_departamento=dep.id_departamento
        WHERE d.estado = 1
        ORDER BY d.id_direccion DESC
    END
    ELSE IF @opcion = 2
    BEGIN
        --ListarDirecciones
        SELECT d.*,
			   m.municipio,
			   dep.departamento
        FROM direcciones d
		INNER JOIN municipios m ON d.id_municipio=m.id_municipio
		INNER JOIN departamentos dep ON m.id_departamento=dep.id_departamento
        WHERE d.estado = 1
        ORDER BY d.id_direccion ASC
    END
    ELSE IF @opcion = 3
    BEGIN
        --ListarDirecciones
        SELECT d.*,
			   m.municipio,
			   dep.departamento
        FROM direcciones d
		INNER JOIN municipios m ON d.id_municipio=m.id_municipio
		INNER JOIN departamentos dep ON m.id_departamento=dep.id_departamento
        WHERE d.estado = 1
        ORDER BY d.codigo_postal ASC
    END
    ELSE IF @opcion = 4
    BEGIN
        --ListarDirecciones
        SELECT d.*,
			   m.municipio,
			   dep.departamento
        FROM direcciones d
		INNER JOIN municipios m ON d.id_municipio=m.id_municipio
		INNER JOIN departamentos dep ON m.id_departamento=dep.id_departamento
        WHERE d.estado = 1
        ORDER BY d.codigo_postal DESC
    END
END 

exec LISTARDIRECCIONOPCION 2