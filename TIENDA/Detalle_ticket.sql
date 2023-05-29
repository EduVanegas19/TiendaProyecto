
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

