use Tienda
go

ALTER TABLE facturas
ADD descuento_aplicado money,
    razon_descuento varchar(255);


CREATE TABLE descuentos_facturas (
    id_descuento bigint identity(1,1) primary key,
    id_factura bigint not null,
    monto_descuento money not null,
    razon_descuento varchar(255),
    foreign key (id_factura) references facturas(id_factura)
);
