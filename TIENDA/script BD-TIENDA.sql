Create database Tienda
GO
use Tienda

Create table opciones(
	id_opcion bigint identity(1,1) not null primary key,
	opcion varchar(100) not null,
	estado bit not null,

);

create table roles(
	id_rol bigint identity(1,1) not null primary key,
	rol varchar(50) not null,
	estado bit not null,

);

create table permisos(
	id_permiso bigint identity(1,1) not null primary key,
	id_rol bigint not null,
	id_opcion bigint not null,

	foreign key (id_rol) references roles(id_rol),
	foreign key (id_opcion) references opciones(id_opcion)
);

create table departamentos(
	id_departamento bigint identity(1,1) not null primary key,
	departamento varchar(50) not null,

);

create table municipios(
	id_municipio bigint identity(1,1) not null primary key,
	municipio varchar(50) not null,
	estado bit not null,
	id_departamento bigint not null,

	foreign key (id_departamento) references departamentos(id_departamento),
);

create table direcciones(
	id_direccion bigint identity(1,1) not null primary key,
	numero_casa varchar(10),
	pasaje_poligono varchar(50),
	calle varchar(50),
	colonia varchar(50),
	canton varchar(50),
	caserio varchar(50),
	codigo_postal varchar(5),
	pais varchar(50),
	id_municipio bigint,

	foreign key (id_municipio) references municipios(id_municipio)
);

create table empleados(
	id_empleado bigint identity(1,1) not null primary key,
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
	id_usuario bigint identity(1,1) not null primary key,
	usuario varchar(50) not null,
	clave varchar(50) not null,
	estado bit not null,
	id_rol bigint not null,
	id_empleado bigint not null

	foreign key (id_rol) references roles(id_rol),
	foreign key (id_empleado) references empleados(id_empleado)
);

create table clientes(
	id_cliente bigint identity(1,1) not null primary key,
	identificacion varchar(45) not null,
	nombre varchar(100) not null,
	credito float not null,
	estado bit not null,
	id_direccion bigint not null,

	foreign key (id_direccion) references direcciones(id_direccion)
);

create table facturas(
	id_factura bigint identity(1,1) not null primary key,
	cantidad int not null,
	precio_unitario money not null,
	fecha date not null,
	descripcion varchar(100),
	numero_documento varchar(12),
	cantidad_productos int not null,
	monto_total money not null,
	pago_tarjeta bit not null,
	cambio money not null,
	estado bit not null,
	id_cliente bigint,

	foreign key (id_cliente) references clientes(id_cliente)
);

create table proveedores(
	id_proveedor bigint identity(1,1) not null primary key,
	proveedor varchar(100) not null,
	numero_documento varchar(12),
	esLaboratorio bit not null,

);

create table pedidos_proveedor(
	id_pedido bigint identity(1,1) not null primary key,
	numero_documento varchar(12) not null,
	fecha_registro date not null,
	monto_total money not null,
	estado bit not null,
	id_proveedor bigint not null,

	foreign key (id_proveedor) references proveedores(id_proveedor)
);

create table unidad_medida(
	id_unidadmedida bigint identity(1,1) not null primary key,
	unidad_medida varchar(45) not null,

);

create table areas(
	id_area bigint identity(1,1) not null primary key,
	area varchar(50) not null,

);

create table productos(
	id_producto bigint identity(1,1) not null primary key,
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
	id_detallepedido bigint identity(1,1) not null primary key,
	cantidad int not null,
	monto_total money not null,
	estado bit not null,
	id_pedido bigint not null,
	id_producto bigint not null,


	foreign key (id_pedido) references pedidos_proveedor(id_pedido),
	foreign key (id_producto) references productos(id_producto)
);

create table detalle_factura(
	id_detallefactura bigint identity(1,1) not null primary key,
	precio_venta money not null,
	cantidad int not null,
	monto_total money not null,
	estado bit not null,
	id_producto bigint not null,
	id_factura bigint not null,

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
