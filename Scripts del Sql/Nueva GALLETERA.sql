-- Crear la base de datos (si aún no existe)
CREATE DATABASE Galletera;
GO

USE Galletera;
GO

-- Tabla de Productos
CREATE TABLE Productos (
    id_producto INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    descripcion TEXT
);
GO

-- Tabla de Ingredientes (Materiales)
CREATE TABLE Ingredientes (
    id_material INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    precio_unitario DECIMAL(10, 2) NOT NULL
);
GO

-- Tabla de Recetas
CREATE TABLE Recetas (
    id_receta INT IDENTITY(1,1) PRIMARY KEY,
    id_producto INT,
    id_material INT,
    cantidad DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto),
    FOREIGN KEY (id_material) REFERENCES Ingredientes(id_material)
);
GO

-- Tabla de Empleados
CREATE TABLE Empleados (
    id_empleado INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    puesto VARCHAR(100) NOT NULL,
    fecha_ingreso DATE NOT NULL
);
GO

create table Cliente(
	id_cliente INT IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(100) NOT NULL,
	apellidos varchar(100),
	dni char(8)
)

-- Tabla de Pedidos
CREATE TABLE Pedidos (
    id_pedido INT IDENTITY(1,1) PRIMARY KEY,
    id_cliente int foreign key references cliente(id_cliente),
    fecha_pedido DATE NOT NULL,
);
GO


-- Tabla de Productos por Pedido (relación muchos a muchos)
CREATE TABLE ProductosPorPedido (
    id_pedido INT,
    id_producto INT,
    cantidad DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (id_pedido, id_producto),
    FOREIGN KEY (id_pedido) REFERENCES Pedidos(id_pedido),
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);
GO

-- Tabla de Producción (Hoja de Producción)
CREATE TABLE Produccion (
    id_produccion INT IDENTITY(1,1) PRIMARY KEY,
    id_producto INT,
    cantidad DECIMAL(10, 2) NOT NULL,
    fecha DATE NOT NULL,
    id_pedido INT,
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto),
    FOREIGN KEY (id_pedido) REFERENCES Pedidos(id_pedido)
);
GO

-- Tabla de Empleados por Producción (relación muchos a muchos)
CREATE TABLE EmpleadosPorProduccion (
    id_produccion INT,
    id_empleado INT,
    PRIMARY KEY (id_produccion, id_empleado),
    FOREIGN KEY (id_produccion) REFERENCES Produccion(id_produccion),
    FOREIGN KEY (id_empleado) REFERENCES Empleados(id_empleado)
);
GO




