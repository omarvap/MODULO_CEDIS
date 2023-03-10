create database CEDIS
GO

use CEDIS
GO

create table persona
(
id int primary key not null,
Nombre varchar(50) not null,
Apellido_razon varchar(50) not null,
Direccion nvarchar(100) not null,
Telefono int not null,
DNI nvarchar(18) not null,
Estado varchar(1) not null,
Descripcion varchar(50) not null
)
GO


create table cargo
(
id int primary key not null,
Nombre_car varchar(50) not null,
Estado varchar(1) not null,
Descripcion varchar(100) not null
)
GO

create table empleado
(
id int primary key not null,
id_per int,
No_INSS nvarchar(18) not null,
Estado varchar(1) not null,
Descripcion varchar(100) not null,
CONSTRAINT fk_persona FOREIGN KEY (id_per) REFERENCES persona(id),
)
GO

select *from producto

create table asignar_cargo
(
id int primary key, 
id_empleado int not null,
id_cargo int not null,
CONSTRAINT fk_cargo FOREIGN KEY (id_cargo) REFERENCES cargo(id),
CONSTRAINT fk_empleado FOREIGN KEY (id_empleado) REFERENCES empleado(id),
)
GO 

create table CEDIS
(
id int primary key not null,
Nombre_CEDIS nvarchar(50) not null,
Direccion_CEDIS nvarchar(50) not null,
Telefono_CEDIS int not null,
Estado varchar(1) not null, 
Descripcion varchar(100) not null,
)
GO

select * from CEDIS

insert into CEDIS (id,Nombre_CEDIS,Direccion_CEDIS,Telefono_CEDIS,Estado,Descripcion) values (1,'Principal','Carretera masaya','22222225','A','masaya')
GO

create table sucursal
(
id int primary key not null,
id_CEDIS int,
Nombre_sur nvarchar(50) not null,
Direccion_sur nvarchar(50) not null,
Telefono_sur int not null,
Estado varchar(1)not null,
Descripcion varchar(100) not null,
CONSTRAINT fk_CEDIS FOREIGN KEY (id_CEDIS) REFERENCES CEDIS(id),
)
GO

select * from sucursal

insert into sucursal(id,Nombre_sur,Direccion_sur,Telefono_sur,Estado,Descripcion) values (1,'1','S1','Managua','22222235','A','Managua')
GO

create table usuario
(
id int primary key not null,
id_sur int not null,
id_asig int not null,
Name_User nvarchar(50),
Pass nvarchar(50),
CONSTRAINT fk_sucursal FOREIGN KEY (id_sur) REFERENCES sucursal(id),
CONSTRAINT fk_asignar_cargo FOREIGN KEY (id_asig) REFERENCES asignar_cargo(id),
)
GO

select * from usuario

create table traslado_producto
(
id_traslado int primary key not null,
fechaTraslado varchar(50) not null,
fechaModificacion varchar(50) not null,
id_almacenOrigen varchar(5) not null,
id_almacenDestino varchar(5) not null,
id_motivo varchar(50) not null,
estado varchar(1) not null
)
GO


create table unidad_medida
(
id int primary key not null,
Nombre_unidad nvarchar(10) not null,
Cantidad numeric(10,2) not null
)
GO

select *from categoria

create table categoria
(
id int primary key not null,
Nombre_Cat nvarchar(100) not null,
Fecha_registro date not null,
Descripcion nvarchar(100) not null,
)
GO

create table presentacion
(
id int primary key not null,
Descripcion nvarchar(100) not null,
Cantidad_reflejada int not null,
)
GO

Create Table marca
(
  id int primary key not null,
  Marca_producto nvarchar(50) not null
)
GO
create table proveedor
(
id int primary key not null,
id_per int foreign key references persona(id) not null,
Politica_venta varchar(3) not null,--('CRE','COT', 'CON')) not null, --crédito, contado, consignacion
Tiempo_entrega nvarchar(50) not null,
Observacion varchar(200),
SitioWeb nvarchar(100),
Estado varchar(1), --(estado IN ('A','I'))
)
GO

create table producto
(
id int primary key not null,
id_cat int not null,
id_pres int not null,
id_unidad int not null,
id_marca int not null,
nombre varchar(50) NOT NULL,
imagen image NULL,
Estado varchar(1),--(estado IN ('A','I'))
Descripcion varchar(100) not null,
CONSTRAINT fk_categoria FOREIGN KEY (id_cat) REFERENCES categoria(id),
CONSTRAINT fk_presentacion FOREIGN KEY (id_pres) REFERENCES presentacion(id),
CONSTRAINT fk_unidad_medida FOREIGN KEY (id_unidad) REFERENCES unidad_medida(id),
CONSTRAINT fk_marca FOREIGN KEY (id_marca) REFERENCES marca(id),

)
GO