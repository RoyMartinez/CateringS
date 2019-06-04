drop database Sta_Lucia_Catering;
Create Database Sta_Lucia_Catering;
go
use Sta_Lucia_Catering;
Go
create table Usuario
(
Id int identity(1,1),
Nombre nvarchar(20),
Contraseña nvarchar(20),
Grupo nvarchar(10),
constraint Pk_Usuario primary key (Id)
);
create table Tipo_Servicio
(
Id int identity(1,1),
Descripcion nvarchar(50),
constraint Pk_Tipo_Servicio primary key(Id)
);
create table Servicio
(
Id int identity(1,1),
Nombre nvarchar(100),
Tipo int,--Guarnision, Carne, Etc
constraint Pk_Servicio primary key (Id),
constraint Fk_Tipo_Servicio foreign key(Tipo) references Tipo_Servicio(Id)
);
create table Tipo_Plato
(
Id int identity(1,1),
Descripcion nvarchar(50),
constraint Pk_Tipo_Plato primary key(Id)
);
create table Plato
(
Id int identity(1,1),
Nombre nvarchar(50),
Tipo int,--Desayuno, Almuerzo, Etc
constraint Pk_Plato primary key(Id),
constraint Fk_Tipo_Plato Foreign key(Tipo) references Tipo_Plato(Id)
);
create table Tipo_Menu
(
Id int identity(1,1),
Descripcion nvarchar(50),
constraint Pk_Tipo_Menu primary key(Id)
);
create table Menu
(
Id int identity(1,1),
Nombre nvarchar(50),
Tipo int,--Ejecutivo,Premium,Plato del dia,Etc
constraint Pk_Menu primary key(Id),
Constraint Fk_Tipo_Menu foreign key(Tipo) references Tipo_Menu(Id)
);
create table Plato_Servicio
(
Plato int,
Servicio int,
Menu int,
Dia nvarchar(30),
constraint Pk_Plato_Servicio primary key(Plato,Servicio),
constraint FK_Plato foreign key (Plato) references Plato(Id),
constraint FK_Servicio foreign key (Servicio) references Servicio(Id),
constraint Fk_Menu foreign key(Menu) references Menu(Id)
);

create table Tipo_Cliente
(
Id int identity(1,1),
Descripcion nvarchar(50),
constraint Pk_Tipo_Cliente primary key(Id)
);
create table Cliente
(
Id int identity(1,1),
Identificacion nvarchar(30),
Nombre nvarchar(200),--Nombre de empresa
Encargado nvarchar(200),--Nombre de quien lo solicito
Telefono nvarchar(20),
Email nvarchar(50),
Direccion nvarchar(400),
Tipo int,--Empresarial,Persona Natural, etc
constraint Pk_Cliente primary key(id),
constraint Fk_Tipo foreign key(Tipo) references Tipo_Cliente(Id)
);
Create table Mesero
(
Id int identity(1,1),
Nombre nvarchar(50),
Constraint Pk_Mesero primary key(Id)
);
create table Tipo_Pedido
(
Id int identity(1,1),
Descripcion nvarchar(50),
constraint Pk_Tipo_Pedido primary key(Id)
);
create table Pedido
(
Id int identity(1,1),
Fecha_Creacion datetime,
Fecha_Pedido datetime,
Tipo int,--Servido,Empacado
Cliente int,
Usuario int,
Constraint Pk_Pedido primary key(Id),
Constraint Fk_Pedido_Tipo foreign key(Tipo) references Tipo_Pedido(Id),
Constraint Fk_Pedido_Cliente foreign key(Cliente) references Cliente(Id),
Constraint Fk_Pedido_Usuario foreign key(Usuario) references Usuario(Id)
);
Create table Pedido_Menus
(
Pedido int,
Menu int,
Constraint Pk_Pedido_Menus primary key (Pedido,Menu),
Constraint Fk_Pedidos_pedidomenu foreign key(Pedido) references Pedido(Id),
Constraint Fk_Menu_pedidomenu foreign key(Menu) references Menu(Id)
)
create table Horario
(
Pedido int,
Mesero int,
Cantidad int,
Constraint Pk_Horario Primary key(Pedido,Mesero),
Constraint Fk_Horario_Mesero foreign key (Mesero) references Mesero(Id),
Constraint Fk_Horario_Pedido foreign key (Pedido) references Pedido(Id),
);

