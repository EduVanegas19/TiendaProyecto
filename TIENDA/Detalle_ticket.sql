-- ULTIMA FACTURA
GO
CREATE PROCEDURE ObtenerUltimaFactura
AS
BEGIN
    DECLARE @UltimaFacturaId INT;

    -- Obtener el ID de la última factura ingresada
    SELECT @UltimaFacturaId = MAX(id_factura) FROM facturas;

    -- Obtener los datos relacionados con la última factura
    SELECT f.fecha, f.descripcion, f.monto_total, f.cantidad_productos, f.monto_cliente, f.cambio,
		   tg.tipo_pago, 
		   p.nombre,
		   df.precio_venta, df.cantidad
    FROM facturas f
    INNER JOIN detalle_factura df ON f.id_factura = df.id_factura
    INNER JOIN productos p ON df.id_producto = p.id_producto
	INNER JOIN tipo_pagos tg ON tg.id_tipopago = f.id_tipopago
    WHERE f.id_factura = @UltimaFacturaId;
END;


-- *******************************************************************
-- REPORTE DE CLIENTES
GO
CREATE PROCEDURE ReporteClientes
AS
BEGIN

    -- Obtener los datos relacionados con clientes
    SELECT c.*,
		   m.municipio,
		   dep.departamento
    FROM clientes c
    LEFT JOIN direcciones d ON c.id_direccion = d.id_direccion
    LEFT JOIN municipios m ON d.id_municipio = m.id_municipio
	LEFT JOIN departamentos dep ON m.id_departamento = dep.id_departamento
	WHERE c.estado=1

END;

-- *******************************************************************
-- REPORTE DE EMPLEADOS
GO
CREATE PROCEDURE ReporteEmpleados
AS
BEGIN

    -- Obtener los datos relacionados con EMPLEADOS
    SELECT emp.*,
		   m.municipio,
		   dep.departamento
    FROM empleados emp
    LEFT JOIN direcciones d ON emp.id_direccion = d.id_direccion
    LEFT JOIN municipios m ON d.id_municipio = m.id_municipio
	LEFT JOIN departamentos dep ON m.id_departamento = dep.id_departamento
	WHERE emp.estado = 1

END;

-- *******************************************************************
-- REPORTE DE PRODUCTOS
GO
CREATE PROCEDURE ReporteProductos
AS
BEGIN

    -- Obtener los datos relacionados con PRODUCTOS
    SELECT p.*,
		   um.unidad_medida,
		   a.area,
		   prov.proveedor
    FROM productos p
    LEFT JOIN unidad_medida um ON p.id_unidadmedida = um.id_unidadmedida
    LEFT JOIN areas a ON p.id_area = a.id_area
	LEFT JOIN detalle_pedido dp ON p.id_producto = dp.id_producto
	LEFT JOIN pedidos_proveedor pp ON dp.id_pedido = pp.id_pedido
	LEFT JOIN proveedores prov ON pp.id_proveedor = prov.id_proveedor
	WHERE p.estado=1

END;

-- *******************************************************************
-- REPORTE DE PROVEEDORES
GO
CREATE PROCEDURE ReporteProveedores
AS
BEGIN

    -- Obtener los datos relacionados con PROVEEDORES
    SELECT prov.*,
		   pp.id_pedido, pp.fecha_registro,
		   dp.cantidad
    FROM proveedores prov
	LEFT JOIN pedidos_proveedor pp ON prov.id_proveedor = pp.id_proveedor
	LEFT JOIN detalle_pedido dp ON pp.id_pedido = dp.id_pedido
	WHERE prov.estado = 1

END;

-- *******************************************************************
-- REPORTE DE USUARIOS
GO
CREATE PROCEDURE ReporteUsuarios
AS
BEGIN

    -- Obtener los datos relacionados con USUARIOS
    SELECT DISTINCT u.*,
		   emp.nombre, emp.apellido,
		   r.rol,
		   op.nombre as Acceso
    FROM usuarios u
	LEFT JOIN empleados emp ON u.id_empleado = emp.id_empleado
	LEFT JOIN roles r ON u.id_rol = r.id_rol
	LEFT JOIN permisos p ON r.id_rol = p.id_rol
	LEFT JOIN subopciones subop ON p.id_subopcion = subop.id_subopcion
	LEFT JOIN opciones op ON subop.id_opcion = op.id_opcion
	WHERE u.estado=1

END;