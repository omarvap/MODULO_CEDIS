use master
Go
if(db_id('CEDIS')Is Not Null)
drop database CEDIS
create database CEDIS
GO
use CEDIS
GO
			/*----------->Tablas administrativas y gestion de ingreso<-----------*/
									 /*---->Inicio<----*/
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('persona') is not null)
begin drop table persona end 
Go
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
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('cargo') is not null)
begin drop table cargo end 
Go
create table cargo
(
id int primary key not null,
Nombre_car varchar(50) not null,
Estado varchar(1) not null,
Descripcion varchar(100) not null
)
GO
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('empleado') is not null)
begin drop table empleado end 
Go
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
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('asignar_cargo') is not null)
begin drop table asignar_cargo end 
Go
create table asignar_cargo
(
id int primary key, 
id_empleado int not null,
id_cargo int not null,
CONSTRAINT fk_cargo FOREIGN KEY (id_cargo) REFERENCES cargo(id),
CONSTRAINT fk_empleado FOREIGN KEY (id_empleado) REFERENCES empleado(id),
)
GO 
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('usuario') is not null)
begin drop table usuario end 
Go
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
/*-----------------------------------------------------------------------------------------------*/
									 /*---->Final<----*/

			/*----------->Tablas de sucursales y almacenes ABC<-----------*/
									/*---->Inicio<----*/
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('CEDIS') is not null)
begin drop table CEDIS end 
Go
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
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('sucursal') is not null)
begin drop table sucursal end 
Go
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
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('traslado_producto') is not null)
begin drop table traslado_producto end 
Go
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
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('ABC') is not null)
begin drop table ABC end 
Go
create table ABC 
(
id int primary key not null,
Nombre_ABC varchar(1) not null,
Tipo_ABC varchar(50) not null,
Peso_max numeric(10,2) not null,
Peso_min numeric(10,2) not null,
Estado varchar(1) not null,
Descripcion varchar(100) not null
)
GO
/*-----------------------------------------------------------------------------------------------*/
						          /*---->Final<----*/

			/*----------->Tablas descriptivas del producto<-----------*/
								/*---->Inicio<----*/
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('unidad_medida') is not null)
begin drop table unidad_medida end 
Go
create table unidad_medida
(
id int primary key not null,
Nombre_unidad nvarchar(10) not null,
Cantidad numeric(10,2) not null
)
GO
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('categoria') is not null)
begin drop table categoria end 
Go
create table categoria
(
id int primary key not null,
Nombre_Cat nvarchar(100) not null,
Fecha_registro date not null,
Descripcion nvarchar(100) not null,
)
GO
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('precentacion') is not null)
begin drop table presentacion end 
Go
create table presentacion
(
id int primary key not null,
Descripcion nvarchar(100) not null,
Cantidad_reflejada int not null,
)
GO
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('marca') is not null)
begin drop table marca end 
Go
Create Table marca
(
  id int primary key not null,
  Marca_producto nvarchar(50) not null
)
GO
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('proveedor') is not null)
begin drop table proveedor end 
Go
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
/*-----------------------------------------------------------------------------------------------*/
if(OBJECT_ID('producto') is not null)
begin drop table producto end 
Go
create table producto
(
id int primary key not null,
Ubicacion int not null,
id_cat int not null,
id_pres int not null,
id_unidad int not null,
id_marca int not null,
nombre varchar(50) NOT NULL,
imagen image NULL,
Estado varchar(1),--(estado IN ('A','I'))
Descripcion varchar(100) not null,
CONSTRAINT fk_ABC FOREIGN KEY (Ubicacion) REFERENCES ABC(id),
CONSTRAINT fk_categoria FOREIGN KEY (id_cat) REFERENCES categoria(id),
CONSTRAINT fk_presentacion FOREIGN KEY (id_pres) REFERENCES presentacion(id),
CONSTRAINT fk_unidad_medida FOREIGN KEY (id_unidad) REFERENCES unidad_medida(id),
CONSTRAINT fk_marca FOREIGN KEY (id_marca) REFERENCES marca(id),
)
GO
/*-----------------------------------------------------------------------------------------------*/
									  /*---->Final<----*/

			/*----------->Tablas de inventario y los movimientos<-----------*/
									/*---->Inicio<----*/