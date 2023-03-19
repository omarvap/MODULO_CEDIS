/*name: procedimentos almacenados para el modulo de CEDIS*/

use CEDIS
GO

create proc spmostrarpersona
as
SELECT  top 100 * FROM persona
order by id asc
GO
/*
create proc spbuscar_proveedor_Num_Proveedor
@textobuscar varchar(50)
as
SELECT * FROM Cat__Proveedor
where Num_Proveedor like @textobuscar + '%'
GO*/

create proc spinsertarpersona
@id int,
@Nombre int,
@Apellido_razon varchar(50),
@Dirreccion nvarchar(100),
@Telefono int,
@DNI nvarchar(18),
@Estado varchar(1),
@Descripcion varchar(50)
as
insert into persona(id,Nombre,Apellido_razon,Direccion,Telefono,DNI,Estado,Descripcion)
values (@id,@Nombre,@Apellido_razon,@Dirreccion,@Telefono,@DNI,@Estado,@Descripcion)
GO

create proc spinsertarempleado
@id int,
@id_per int,
@No_INSS nvarchar(18),
@Estado varchar(1),
@Descripcion varchar(100)
as
insert into empleado(id,id_per,No_INSS,Estado,Descripcion)
values (@id,@id_per,@No_INSS,@Estado,@Descripcion)
GO


create proc spinsertarcargo
@id int,
@Nombre_car varchar(50),
@Estado varchar(1),
@Descripcion nvarchar(100)
as
insert into cargo(id,Nombre_car,Estado,Descripcion)
values (@id,@Nombre_car,@Estado,@Descripcion)
GO