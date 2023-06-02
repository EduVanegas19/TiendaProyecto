Create database Tienda
GO
use Tienda
GO

Create table opciones(
	id_opcion bigint identity(1,1) primary key,
	nombre varchar(100) not null,
	estado bit not null,

);

Create table subopciones(
	id_subopcion bigint identity(1,1) primary key,
	id_opcion bigint not null,
	nombre varchar(100) not null,
	nombreFormulario varchar(100) not null,
	estado bit not null,

	foreign key (id_opcion) references opciones(id_opcion)
);

create table roles(
	id_rol bigint identity(1,1) primary key,
	rol varchar(50) not null,
	estado bit not null,

);

create table permisos(
	id_permiso bigint identity(1,1) primary key,
	id_rol bigint not null,
	id_subopcion bigint not null,
	estado bit not null,

	foreign key (id_rol) references roles(id_rol),
	foreign key (id_subopcion) references subopciones(id_subopcion)
);

create table departamentos(
	id_departamento bigint identity(1,1) primary key,
	departamento varchar(50) not null,

);

create table municipios(
	id_municipio bigint identity(1,1) primary key,
	municipio varchar(50) not null,
	estado bit not null,
	id_departamento bigint not null,

	foreign key (id_departamento) references departamentos(id_departamento),
);

create table direcciones(
	id_direccion bigint identity(1,1) primary key,
	numero_casa varchar(10),
	pasaje_poligono varchar(50),
	calle varchar(50),
	colonia varchar(50),
	canton varchar(50),
	caserio varchar(50),
	codigo_postal varchar(10),
	estado bit not null,
	id_municipio bigint,

	foreign key (id_municipio) references municipios(id_municipio)
);

create table empleados(
	id_empleado bigint identity(1,1) primary key,
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	genero varchar(50) not null,
	telefono varchar(50) not null,
	correo varchar(50),
	DUI varchar(50) not null,
	fechanac date,
	id_direccion bigint not null,
	estado bit not null,

	foreign key (id_direccion) references direcciones(id_direccion)
);

create table usuarios(
	id_usuario bigint identity(1,1) primary key,
	usuario varchar(50) not null,
	clave varchar(50) not null,
	estado bit not null,
	id_rol bigint not null,
	id_empleado bigint not null

	foreign key (id_rol) references roles(id_rol),
	foreign key (id_empleado) references empleados(id_empleado)
);

create table clientes(
	id_cliente bigint identity(1,1) primary key,
	identificacion varchar(45) not null,
	nombre varchar(100) not null,
	credito float not null,
	estado bit not null,
	id_direccion bigint not null,

	foreign key (id_direccion) references direcciones(id_direccion)
);

create table tipo_pagos(
	id_tipopago bigint identity(1,1) primary key,
	tipo_pago varchar(50) not null,
	estado bit not null
);

create table facturas(
	id_factura bigint identity(1,1) primary key,

	fecha date not null,
	descripcion varchar(100),
	numero_documento varchar(12),
	monto_total money not null,
	cantidad_productos int not null,
	monto_cliente money not null,
	cambio money not null,
	estado bit not null,
	id_tipopago bigint not null,
	id_empleado bigint not null,
	id_cliente bigint,

	foreign key (id_cliente) references clientes(id_cliente),
	foreign key (id_tipopago) references tipo_pagos(id_tipopago),
	foreign key (id_empleado) references empleados(id_empleado)
);

create table proveedores(
	id_proveedor bigint identity(1,1) primary key,
	proveedor varchar(100) not null,
	numero_documento varchar(12),
	esLaboratorio bit not null,
	estado bit not null

);

create table pedidos_proveedor(
	id_pedido bigint identity(1,1) primary key,
	numero_documento varchar(12) not null,
	fecha_registro date not null,
	monto_total money not null,
	estado bit not null,
	id_proveedor bigint not null,

	foreign key (id_proveedor) references proveedores(id_proveedor)
);

create table unidad_medida(
	id_unidadmedida bigint identity(1,1) primary key,
	unidad_medida varchar(45) not null,
	estado bit not null

);

create table areas(
	id_area bigint identity(1,1) primary key,
	area varchar(50) not null,
	estado bit not null

);

create table productos(
	id_producto bigint identity(1,1) primary key,
	codigo_barras varchar(45) not null,
	descripcion varchar(100),
	precio_unidad money not null,
	precio_venta money not null,
	stock int not null,
	nombre varchar(100) not null,
	fecha_ingreso date not null,
	fecha_vencimiento date,
	medida varchar(45),
	estado bit not null,
	id_unidadmedida bigint,
	id_area bigint not null

	foreign key (id_unidadmedida) references unidad_medida(id_unidadmedida),
	foreign key (id_area) references areas(id_area)
);

create table detalle_pedido(
	id_detallepedido bigint identity(1,1) primary key,
	cantidad int not null,
	monto_total money not null,
	estado bit not null,
	id_pedido bigint not null,
	id_producto bigint not null,


	foreign key (id_pedido) references pedidos_proveedor(id_pedido),
	foreign key (id_producto) references productos(id_producto)
);

create table detalle_factura(
	id_detallefactura bigint identity(1,1) primary key,
	precio_unitario money not null,
	precio_venta money not null,
	cantidad int not null,
	id_producto bigint not null,
	id_factura bigint not null,
	estado bit not null,

	foreign key (id_factura) references facturas(id_factura),
	foreign key (id_producto) references productos(id_producto)
);

-- TABLAS INDEPENDIENTES
create table tramites(
	id_tramite int identity(1,1) not null primary key,
	tramite varchar(50) not null,
	descripcion varchar(100)

);

create table banco(
	id_transaccion bigint identity(1,1) not null primary key,
	fecha datetime not null,
	DUI varchar(10) not null,
	nombre_persona varchar(100) not null,
	deposito money,
	retiro money,
	saldo_inicio money not null,
	saldo_final money not null,
	--saldo_sistema campo temporal para mostrar en el sistema--
	id_tramite int not null,

	foreign key (id_tramite) references tramites(id_tramite)
);

--create table tipo_copias(
--	id_tipocopia bigint identity(1,1) not null primary key,
--	tipo_copia varchar(100) not null,
--	costo_copia money not null
--);

--create table copias(
--	id_copia bigint identity(1,1) not null primary key,
--	id_tipocopia int not null,
--	cantidad int not null,

--	foreign key (id_tipocopia) references tipo_copias(id_tipocopia)
--);


-- Agregando datos a tabla OPCIONES
GO
insert into opciones(nombre, estado)
values ('Usuarios', 1),
	   ('Ventas', 1),
	   ('Reportes', 1),
	   ('Empleados', 1),
	   ('Clientes', 1),
	   ('Direcciones', 1),
	   ('DetalleVentas', 1),
	   ('Productos', 1),
	   ('PedidoProveedor', 1),
	   ('DetallePedidos', 1),
	   ('Proveedor', 1);


-- Agregando datos a tabla SUBOPCIONES
GO
insert into subopciones(id_opcion, nombre, nombreFormulario, estado)
values (1, 'Gestion Usuario', 'frmGestionUsuario', 1),
	   (1, 'Crear Usuario', 'frmCrearUsuario', 1),
	   (1, 'Editar Usuario', 'frmEditarUsuario', 1),
	   (1, 'Eliminar Usuario', 'frmEliminarUsuario', 1),
	   (2, 'Gestion Venta', 'frmGestionVenta', 1),
	   (2, 'Crear Venta', 'frmCrearVenta', 1),
	   (2, 'Editar Venta', 'frmEditarVenta', 1),
	   (2, 'Eliminar Venta', 'frmEliminarVenta', 1),
	   (3, 'Gestion Reporte', 'frmGestionReporte', 1),
	   (3, 'Crear Reporte', 'frmCrearReporte', 1),
	   (3, 'Editar Reporte', 'frmEditarReporte', 1),
	   (3, 'Eliminar Reporte', 'frmEliminarReporte', 1),
	   (4, 'Gestion Empleado', 'frmGestionEmpleado', 1),
	   (4, 'Crear Empleado', 'frmCrearEmpleado', 1),
	   (4, 'Editar Empleado', 'frmEditarEmpleado', 1),
	   (4, 'Eliminar Empleado', 'frmEliminarEmpleado', 1),
	   (5, 'Gestion Cliente', 'frmGestionCliente', 1),
	   (5, 'Crear Cliente', 'frmCrearCliente', 1),
	   (5, 'Editar Cliente', 'frmEditarCliente', 1),
	   (5, 'Eliminar Cliente', 'frmEliminarCliente', 1),
	   (6, 'Gestion Direccion', 'frmGestionDireccion', 1),
	   (6, 'Crear Direccion', 'frmCrearDireccion', 1),
	   (6, 'Editar Direccion', 'frmEditarDireccion', 1),
	   (6, 'Eliminar Direccion', 'frmEliminarDireccion', 1),
	   (7, 'Gestion DetalleVenta', 'frmGestionDetalleVenta', 1),
	   (7, 'Crear DetalleVenta', 'frmCrearDetalleVenta', 1),
	   (7, 'Editar DetalleVenta', 'frmEditarDetalleVenta', 1),
	   (7, 'Eliminar DetalleVenta', 'frmEliminarDetalleVenta', 1),
	   (8, 'Gestion Producto', 'frmGestionProducto', 1),
	   (8, 'Crear Producto', 'frmCrearProducto', 1),
	   (8, 'Editar Producto', 'frmEditarProducto', 1),
	   (8, 'Eliminar Producto', 'frmEliminarProducto', 1),
	   (9, 'Gestion PedidoProveedor', 'frmGestionPedidoProveedor', 1),
	   (9, 'Crear PedidoProveedor', 'frmCrearPedidoProveedor', 1),
	   (9, 'Editar PedidoProveedor', 'frmEditarPedidoProveedor', 1),
	   (9, 'Eliminar PedidoProveedor', 'frmEliminarPedidoProveedor', 1),
	   (10, 'Gestion DetallePedido', 'frmGestionDetallePedido', 1),
	   (10, 'Crear DetallePedido', 'frmCrearDetallePedido', 1),
	   (10, 'Editar DetallePedido', 'frmEditarDetallePedido', 1),
	   (10, 'Eliminar DetallePedido', 'frmEliminarDetallePedido', 1),
	   (11, 'Gestion Proveedor', 'frmGestionProveedor', 1),
	   (11, 'Crear Proveedor', 'frmCrearProveedor', 1),
	   (11, 'Editar Proveedor', 'frmEditarProveedor', 1),
	   (11, 'Eliminar Proveedor', 'frmEliminarProveedor', 1);
	   

GO
INSERT INTO roles(rol, estado)
values ('Gerente', 1),
	   ('Empleado', 1),
	   ('Supervisor', 1),
	   ('Bodega', 1);

GO
INSERT INTO permisos(id_rol, id_subopcion, estado)
values ( 1, 1, 1), --Gerente
	   ( 1, 2, 1),
	   ( 1, 3, 1),
	   ( 1, 4, 1),
	   ( 1, 5, 1),
	   ( 1, 6, 1),
	   ( 1, 7, 1),
	   ( 1, 8, 1),
	   ( 1, 9, 1),
	   ( 1, 10, 1),
	   ( 1, 11, 1),
	   ( 1, 12, 1),
	   ( 1, 13, 1),
	   ( 1, 14, 1),
	   ( 1, 15, 1),
	   ( 1, 16, 1),
	   ( 1, 17, 1),
	   ( 1, 18, 1),
	   ( 1, 19, 1),
	   ( 1, 20, 1),
	   ( 1, 21, 1),
	   ( 1, 22, 1),
	   ( 1, 23, 1),
	   ( 1, 24, 1),
	   ( 1, 25, 1),
	   ( 1, 26, 1),
	   ( 1, 27, 1),
	   ( 1, 28, 1),
	   ( 1, 29, 1),
	   ( 1, 30, 1),
	   ( 1, 31, 1),
	   ( 1, 32, 1),
	   ( 1, 33, 1),
	   ( 1, 34, 1),
	   ( 1, 35, 1),
	   ( 1, 36, 1),
	   ( 1, 37, 1),
	   ( 1, 38, 1),
	   ( 1, 39, 1),
	   ( 1, 40, 1),
	   ( 1, 41, 1),
	   ( 1, 42, 1),
	   ( 1, 43, 1),
	   ( 1, 44, 1),
	   -- Empleado
	   ( 2, 1, 0),
	   ( 2, 2, 0),
	   ( 2, 3, 0),
	   ( 2, 4, 0),
	   ( 2, 5, 1),
	   ( 2, 6, 1),
	   ( 2, 7, 1),
	   ( 2, 8, 0),
	   ( 2, 9, 0),
	   ( 2, 10, 0),
	   ( 2, 11, 0),
	   ( 2, 12, 0),
	   ( 2, 13, 0),
	   ( 2, 14, 0),
	   ( 2, 15, 0),
	   ( 2, 16, 0),
	   ( 2, 17, 1),
	   ( 2, 18, 1),
	   ( 2, 19, 1),
	   ( 2, 20, 0),
	   ( 2, 21, 1),
	   ( 2, 22, 1),
	   ( 2, 23, 1),
	   ( 2, 24, 0),
	   ( 2, 25, 1),
	   ( 2, 26, 1),
	   ( 2, 27, 1),
	   ( 2, 28, 0),
	   ( 2, 29, 1),
	   ( 2, 30, 1),
	   ( 2, 31, 1),
	   ( 2, 32, 0),
	   ( 2, 33, 0),
	   ( 2, 34, 0),
	   ( 2, 35, 0),
	   ( 2, 36, 0),
	   ( 2, 37, 0),
	   ( 2, 38, 0),
	   ( 2, 39, 0),
	   ( 2, 40, 0),
	   ( 2, 41, 0),
	   ( 2, 42, 0),
	   ( 2, 43, 0),
	   ( 2, 44, 0);

GO
INSERT INTO departamentos(departamento)
values ('Sonsonate'),
	   ('Ahuachapan'),
	   ('Santa Ana'),
	   ('La Libertad'),
	   ('San Salvador');

GO
INSERT INTO municipios(municipio, estado, id_departamento)
values ('Acajutla', 1, 1),
	   ('Armenia', 1, 1),
	   ('Caluco', 1, 1),
	   ('Cuisnahuat', 1, 1),
	   ('Izalco', 1, 1),
	   ('Juayúa', 1, 1),
	   ('Nahuizalco', 1, 1),
	   ('Nahulingo', 1, 1),
	   ('Salcoatitán', 1, 1),
	   ('Santa Catarina Masahuat', 1, 1),
	   ('Santa Isabel Ishuatán', 1, 1),
	   ('Santo Domingo de Guzmán', 1, 1),
	   ('Sonsonate', 1, 1),
	   ('Sonzacate', 1, 1),
	   ('San Julián', 1, 1);

GO
INSERT INTO direcciones(numero_casa, pasaje_poligono, calle, colonia, canton, caserio, codigo_postal, estado, id_municipio)
values ('121', 'PASAJE A', '1 Avenida Norte', 'Santa Maria', 'El Cacao', 'Caserio11', '03014', 1, 13),
	   ('154', 'PASAJE B', '1 Avenida Sur', 'Santa Marta', 'El Presidio', 'Caserio22', '03013', 1, 12),
	   ('223', 'PASAJE C', '10a Avenida Norte', 'Santa Eugenia', 'Maravilles', '', '03015', 1, 14),
	   ('23', 'PASAJE 1', '11a Avenida Sur', '14 de Diciembre', 'Santa Emilia', '', '03014', 1, 13),
	   ('04', 'PASAJE 2', '14a Avenida Poniente', 'Altos del rio', '', 'Caserio33', '03014', 1, 13);

GO
INSERT INTO empleados(nombre, apellido, genero, telefono, correo, DUI, fechanac, id_direccion, estado)
values ('fulanito', 'lejano', 'Hombre', '00000000', 'correo@gmail.com', '121212-0', '2000-12-12', 1, 1),
	  ('Menganito', 'cercano', 'Mujer', '11111111', 'nuevo@gmail.com', '232323-1', '1990-04-7', 2, 1),
	  ('Alfonso', 'hernandez', 'Hombre', '22222222', 'mouse@gmail.com', '343434-2', '1995-08-20', 3, 1),
	  ('Carlos', 'martinez', 'Mujer', '33333333', 'teclado@gmail.com', '454545-3', '2001-06-29', 4, 1),
	  ('Ricardo', 'bueno', 'No Binario', '44444444', 'pantalla@gmail.com', '565656-4', '1998-02-1', 5, 1);

GO
INSERT INTO usuarios(usuario, clave, estado, id_rol, id_empleado)
values ('EduV', '123', 1, 1, 5),
	  ('Oscar', '123', 1, 2, 4),
	  ('Maykol', '123', 1, 2, 3),
	  ('LuisT', '123', 1, 3, 2),
	  ('Prueba', '1234', 1, 3, 1);

GO
INSERT INTO clientes(identificacion, nombre, credito, estado, id_direccion)
values ('010101', 'Fernando Fnernando', 10.50, 1, 1),
	  ('020202', 'Alonso Alonso', 5.50, 1, 2),
	  ('030303', 'Midel Midel', 90.50, 1, 3),
	  ('040404', 'Mauro Mauro', 0.50, 0, 4),
	  ('050505', 'Ernesto Ernesto', 3.55, 1, 5);

GO 
INSERT INTO tipo_pagos(tipo_pago, estado)
values ('Tarjeta', 1),
	  ('Bitcoin', 1),
	  ('Efectivo', 1);

GO
INSERT INTO facturas(fecha, descripcion, numero_documento, monto_total, cantidad_productos, monto_cliente, cambio, estado, id_tipopago, id_empleado, id_cliente)
values ('2005-01-21', '', '', 13.50, 5, 15.00, 1.50, 1, 3, 1, null),
	  ('2006-02-22', 'problemas', '', 13.50, 5, 15.00, 1.50, 1, 3, 1, null),
	  ('2007-03-23', '', '', 13.50, 5, 15.00, 1.50, 1, 3, 1, null),
	  ('2008-04-24', '', '', 13.50, 5, 15.00, 1.50, 1, 3, 1, null),
	  ('2009-05-25', 'comentario', '', 13.50, 5, 15.00, 1.50, 1, 3, 1, null),
	  ('2010-06-26', '', '', 13.50, 5, 15.00, 1.50, 1, 3, 1, null),
	  ('2011-07-27', '', '', 13.50, 5, 15.00, 1.50, 1, 3, 1, null),
	  ('2012-08-28', '', '', 13.50, 5, 15.00, 1.50, 1, 3, 1, null),
	  ('2013-09-29', 'nada', '', 13.50, 5, 15.00, 1.50, 1, 3, 1, null),
	  ('2014-10-30', '', '', 13.50, 5, 15.00, 1.50, 1, 3, 1, null);

GO
INSERT INTO proveedores(proveedor, numero_documento, esLaboratorio, estado)
values ('Salud', '', 0, 1),
	  ('Diana', '', 0, 1),
	  ('Laboratorios Suizos', '', 1, 1),
	  ('ZonaDigital', '', 0, 1),
	  ('Pepsi', '', 0, 1);

GO
INSERT INTO pedidos_proveedor(numero_documento, fecha_registro, monto_total, estado, id_proveedor)
values ('', '2011-01-10', 100.90, 1, 4),
	  ('', '2012-02-12', 15.90, 1, 2),
	  ('', '2013-03-14', 70.90, 1, 1),
	  ('', '2014-04-16', 90.90, 1, 3),
	  ('', '2014-04-16', 76.90, 1, 3),
	  ('', '2015-05-18', 1500.90, 1, 5);

GO
INSERT INTO unidad_medida(unidad_medida, estado)
values ('Gramo', 1),
	  ('Kilogramo', 1),
	  ('Libra', 1),
	  ('Pulgada', 1),
	  ('Litro', 1);

GO
INSERT INTO areas(area, estado)
values ('Medicina', 1),
	  ('Electrodomesticos', 1),
	  ('Comida', 1),
	  ('Accesorios', 1),
	  ('Ropa', 1);

GO
INSERT INTO productos(codigo_barras, descripcion, precio_unidad, precio_venta, stock, nombre, fecha_ingreso, fecha_vencimiento, medida, estado, id_unidadmedida, id_area)
values ('11111', 'nuevo ingreso', 0.50, 0.70, 33, 'Cepillo dental', '2022-08-22', '2030-10-30', 3, 1, 1, 4),
	  ('22222', 'retornable', 1.00, 1.10, 50, 'Coca-Cola', '2022-08-22', '2021-12-22', 1.5, 1, 5, 3),
	  ('33333', 'nuevo', 0.10, 0.15, 100, 'Cepillo dental', '2022-08-22', '2030-10-30', 3, 1, 1, 4),
	  ('44444', 'reingreso', 0.70, 0.90, 20, 'Cepillo dental', '2022-08-22', '2030-10-30', 3, 1, 1, 4),
	  ('55555', 'usado', 5.00, 6.50, 2, 'Televisor', '2022-08-22', '', null, 1, null, 2),
	  ('66666', 'tiene problema', 3.50, 4.00, 1, 'Cepillo dental', '2022-08-22', '2030-10-30', 3, 1, 1, 4),
	  ('77777', 'vender rapido', 0.25, 0.35, 10, 'Pan', '2022-08-22', '2022-08-30', null, 1, 1, 3),
	  ('88888', '', 1.25, 1.35, 15, 'Pan Lido', '2022-08-22', '2030-10-30', 3, 1, 1, 4),
	  ('99999', 'refrigerable', 0.50, 0.70, 33, 'Sorbete Fresa', '2022-08-22', '2022-12-30', null, 1, null, 3),
	  ('101010', 'delicado', 2.25, 2.50, 8, 'Vaso de vidrio', '2022-08-22', '', null, 1, null, 4);

GO
INSERT INTO detalle_pedido(cantidad, monto_total, estado, id_pedido, id_producto)
values (33, 15.90, 1, 1, 1),
	  (50, 70.90, 1, 2, 2),
	  (8, 90.90, 1, 3, 10),
	  (44, 76.90, 1, 4, 9),
	  (2, 1500.90, 1, 5, 5);

GO
INSERT INTO detalle_factura(precio_unitario, precio_venta, cantidad, id_producto, id_factura, estado)
values (0.20, 0.70, 3, 1, 10, 1),
	  (0.20, 0.90, 3, 3, 8, 1),
	  (0.20, 0.30, 3, 10, 8, 1),
	  (0.20, 0.40, 3, 9, 8, 1),
	  (0.20, 0.50, 4, 8, 8, 1),
	  (0.20, 0.60, 7, 7, 4, 1),
	  (0.20, 0.70, 3, 1, 4, 1),
	  (0.20, 0.70, 3, 9, 5, 1),
	  (0.20, 1.35, 3, 8, 5, 1),
	  (0.20, 1.10, 3, 2, 5, 1);


-- //////////////////////////////////////////////////////////////////////////// --
-- //////////////////////////////////////////////////////////////////////////// --
