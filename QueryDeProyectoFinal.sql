CREATE DATABASE VirTian
USE VirTian

CREATE TABLE Clientes (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	RFC NVARCHAR(18) NOT NULL,
	Nombre NVARCHAR(50),
	APaterno NVARCHAR(50),
	AMaterno NVARCHAR(50),
	Estado NVARCHAR(50),
	Ciudad NVARCHAR(50),
	Calle NVARCHAR(50),
	NoExt INT,
	NoInt INT,
	Colonia NVARCHAR(50),
	CodigoPostal INT,
	ClienteActivo BIT
);

CREATE TABLE Factura (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FechaFacturacion DATE,
	UsuarioEmisor NVARCHAR(50),
	Pago FLOAT,
	Productos INT,
	NoVenta INT,
	Cliente INT,
	FacturaActiva BIT
)

CREATE TABLE Ventas (
	NoVenta INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Fecha DATE,
	Total INT,
	Empleado INT,
	Detalle INT,
	VentaActiva BIT
)

CREATE TABLE DetalleVentas (
	IdDetalleVenta INT,
	Producto int
)

create table Empleado(
	Id_empleado int not null IDENTITY(1,1) primary key,
	Nombre nvarchar(50),
	Apaterno nvarchar(50),
	Amaterno nvarchar(50),
	Nombre_usuario nvarchar(50),
	Edad int,
	Oficio nvarchar(50),
	--Puesto int /*foreign key*/,
	Editar BIT,
	Almacen BIT,
	Vender BIT,
	Fecha_alta date,
	Salario float,
	Contraseña nvarchar(50),
	EmpleadoActivo BIT
)

create table Producto(
	Id_producto int not null IDENTITY(1,1) primary key,
	Nombre nvarchar(50),
	Marca nvarchar(50),
	Precio float,
	--No_exist int, 
	Categoria nvarchar(50),
	Descripcion ntext,
	Proveedor int,
	ProductoActivo BIT
)

create table Inventario(
	Productos int,
	NumeroExistencias int
)

create table Relacion_Proveedor_Producto(
	Proveedor int,
	Producto int
)

create table Proveedor(
	Id_proveedor int not null IDENTITY(1,1) primary key,
	Nombre nvarchar(50),
	ProveedorActivo BIT
)
