-- Active: 1697551938435@@127.0.0.1@3306@bd_minimarket

DROP DATABASE bd_minimarket;
USE bd_minimarket;


Create table MiniMarket(
	idMiniMarket int Auto_increment,
	nit VARCHAR(50) not null,
	razonSocial varchar(50) not null,
	telefono varchar(10) not null, 
	nomenclatura varchar(50) not null,
	ciudad varchar(50) not null, 
	departamento varchar(50) not null,
	correo varchar(50) not null, 
	sitioWeb varchar(50) not null,
	facebook varchar(50) not null,
	whatsapp varchar(50) not null,
	CONSTRAINT pk_minimarket PRIMARY KEY (idMinimarket),
	CONSTRAINT unico_nit UNIQUE (nit)
);

INSERT INTO MiniMarket (nit, razonSocial, telefono, nomenclatura, ciudad, departamento, correo, sitioWeb, facebook, whatsapp)
VALUES ('123456789', 'Ctrl+buy', '3119645512', 'Cra 5 # 5-7', 'Cali', 'Valle del Cauca', 'Ctrl+buy@gmail.com', 'www.Ctrl+buy.com', 'facebook.com/Ctrl+buy', '3119645512');

SELECT * FROM minimarket;

select nit, razonSocial, telefono, nomenclatura, ciudad, departamento, correo, sitioWeb, facebook, whatsapp from minimarket where idMiniMarket=1;

Create table Proveedor(
	idProveedor int AUTO_INCREMENT,
	Nit VARCHAR(10) not null,
	razonSocial varchar(50) not null, 
	telefono varchar(10) not null,
	nomenclatura varchar(50) not null,
	ciudad varchar(50) not null, 
	departamento varchar(50) not null,
	correo varchar(50) not null, 
	
	CONSTRAINT pk_proveedor PRIMARY KEY (idProveedor),
	CONSTRAINT unico_nit_proveedor UNIQUE(nit),
	CONSTRAINT unico_razonSocial_proveedor UNIQUE (razonSocial)
);

SELECT * FROM proveedor;

DELETE FROM proveedor;

Create table Categoria(
	idCategoria INT AUTO_INCREMENT,
	nombre VARCHAR(50) not null,
	descripcion VARCHAR(200) NOT NULL,
	CONSTRAINT pk_categoria PRIMARY KEY (idCategoria),
	CONSTRAINT unico_nombre UNIQUE (nombre)
);
Create table Cliente(
	idCliente INT AUTO_INCREMENT,	
	tipoDocumento ENUM('CC', 'TI', 'PAS', 'PEP', 'PPT', 'CE', 'Otro'),
	identificacion VARCHAR(11) not null,
	nombres VARCHAR(50) not null, 
	apellidos VARCHAR(50) not null,
	correo VARCHAR(50) not null,
	celular VARCHAR(50) not null,
	CONSTRAINT pk_cliente PRIMARY KEY (idCliente),
	CONSTRAINT unico_identificacion UNIQUE (identificacion)
);

Create table Producto(
	idProducto int AUTO_INCREMENT,		 
	nombre VARCHAR(50) not null,
	marca VARCHAR(50) not null,
	stock int not null default 0,
	PVP int not null default 0,
	descripcion VARCHAR(200) null,
	unidadMedida ENUM('UND', 'gr'),
	idCategoria int not null,
	
	CONSTRAINT pk_prodcuto PRIMARY KEY (idProducto),
	CONSTRAINT unico_nombre UNIQUE (nombre),
	CONSTRAINT foreign key (idCategoria) references Categoria (idCategoria)
);

Create table Empleado(
	idEmpleado int AUTO_INCREMENT,
	tipoDocumento ENUM('CC', 'TI', 'PAS', 'PEP', 'PPT', 'CE', 'Otro'),
	identificacion VARCHAR(11) not null,
	nombres VARCHAR(50) not null, 
	apellidos VARCHAR(50) not null,
	correo VARCHAR(50) not null,
	celular VARCHAR(11) NOT NULL,
	clave VARCHAR(8) not null,
	idMiniMarket int not null,
	CONSTRAINT pk_empleado PRIMARY KEY (idEmpleado),
	CONSTRAINT unico_identificacion_empleado UNIQUE (identificacion),
	CONSTRAINT unico_correo_empleado UNIQUE (correo),
	CONSTRAINT FK_minimarket foreign key (idMinimarket) references Minimarket (idMinimarket)	
);
Create table Factura(
	idFactura int AUTO_INCREMENT,
	codigoFactura VARCHAR(8) not null,
	fechaGeneracion DATETIME  not null,
	Iva int not null,
	SinIva int not null,
	total int not null,
	idEmpleado int not null,
	idCliente int not null,
	
	CONSTRAINT pk_factura PRIMARY KEY (idFactura),
	CONSTRAINT unico_factura UNIQUE (codigoFactura),
	CONSTRAINT fk_empleado foreign key (idEmpleado) references Empleado (idEmpleado),
	CONSTRAINT fk_cliente foreign key (idCliente) references Cliente (idCliente)
);

Create table DetalleFactura(
	idDetalleFactura int AUTO_INCREMENT,
	cantidadProducto int not null,
	precioVenta int not null,
	subtotal int not null,
	idProducto int not null, 
	idFactura int not null,
	
	CONSTRAINT pk_detalleFactura PRIMARY KEY (idDetalleFactura),
	CONSTRAINT fk_producto foreign key (idProducto) references Producto (idProducto),
	CONSTRAINT fk_factura foreign key (idFactura) references Factura (idFactura)
);
CREATE table OrdenDeCompra(
	idOrdenDeCompra int AUTO_INCREMENT,
	codigoOrdenDeCompra VARCHAR(8) not null,
	Iva int not null,
	precioTotal int not null,
	fechaPedido DATETIME not null,
	fechaEntrega DATETIME NOT NULL,
	totalSinIva int not null,  
	idProveedor int not null,
	idEMpleado int NOT NULL,
	CONSTRAINT pk_ordenDeCompra PRIMARY KEY (idOrdenDeCompra),
	CONSTRAINT fk_proveedor foreign key (idProveedor) references Proveedor (idProveedor),
	CONSTRAINT fk_factura foreign key (idEmpleado) references Empleado (idEmpleado)
);

Create Table DetalleOrdenDeCompra(
	idDetalleOrdenDeCompra int AUTO_INCREMENT,
	codigoDetalleOrdenDeCompra VARCHAR(8) not null,
	cantidadProducto int not null,
	precioCompra int not null,
	subtotal int not null,
	idOrdenDeCompra int not null,
	idProducto int not null,
	CONSTRAINT pk_detalleOrdenDeCompra PRIMARY KEY (idDetalleDeCompra),
	CONSTRAINT fk_ordenDeCompra foreign key(idOrdenDeCompra) references OrdenDeCompra (idOrdenDeCompra),
	CONSTRAINT fk_producto foreign key (idProducto) references Producto (idProducto),
);