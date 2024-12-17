--AQUI EMPIEZA
use Galletera;
go

--PRIMER FORMULARIO FRM PEDIDOS
--INSERTAR UN PEDIDO
CREATE PROCEDURE sp_InsertarPedido
    @Cliente VARCHAR(100),
    @FechaPedido DATE,
    @IdPedido INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO Pedidos (cliente, fecha_pedido)
        VALUES (@Cliente, @FechaPedido);

        -- Capturar el ID del pedido generado automáticamente
        SET @IdPedido = SCOPE_IDENTITY();
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
-- CAMBIASOOOOOOOOOOOOOOOOOOOOOOOOOO
-- CAMBIASOOOOOOOOOOOOOOOOOOOOOOOOOO
-- CAMBIASOOOOOOOOOOOOOOOOOOOOOOOOOO
-- CAMBIASOOOOOOOOOOOOOOOOOOOOOOOOOO
-- CAMBIASOOOOOOOOOOOOOOOOOOOOOOOOOO



CREATE PROCEDURE sp_InsertarProductosPorPedido
    @IdPedido INT,
    @IdProducto INT,
    @Cantidad DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO ProductosPorPedido (id_pedido, id_producto, cantidad)
        VALUES (@IdPedido, @IdProducto, @Cantidad);
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;

CREATE PROCEDURE sp_ListarProductos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_producto, nombre, descripcion
    FROM Productos;
END;


select*from Pedidos

select*from ProductosPorPedido

--SEGUNDO FORMULARIO FRMPRODUCTO

CREATE PROCEDURE sp_InsertarProducto
    @Nombre VARCHAR(100),
    @Descripcion TEXT,
    @IdProducto INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO Productos (nombre, descripcion)
        VALUES (@Nombre, @Descripcion);

        -- Obtener el ID del producto recién insertado
        SET @IdProducto = SCOPE_IDENTITY();
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;


CREATE PROCEDURE sp_InsertarReceta
    @IdProducto INT,
    @IdMaterial INT,
    @Cantidad DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO Recetas (id_producto, id_material, cantidad)
        VALUES (@IdProducto, @IdMaterial, @Cantidad);
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;


CREATE PROCEDURE sp_ListarIngredientes
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_material, nombre, precio_unitario
    FROM Ingredientes;
END;


CREATE PROCEDURE sp_InsertarIngrediente
    @Nombre VARCHAR(100),
    @PrecioUnitario DECIMAL(10, 2),
    @IdMaterial INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO Ingredientes (nombre, precio_unitario)
        VALUES (@Nombre, @PrecioUnitario);

        -- Obtener el ID del ingrediente recién insertado
        SET @IdMaterial = SCOPE_IDENTITY();
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;

select*from Productos
select*from Recetas
select*from Ingredientes


--tercer Formulario FRMPRODUCCION

--Listar pedidos solo por fecha
CREATE PROCEDURE sp_ListarPedidos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_pedido, fecha_pedido 
    FROM Pedidos;
END;

--Obtener datos del pedido 
CREATE PROCEDURE sp_ObtenerPedidoPorId
    @IdPedido INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT cliente 
    FROM Pedidos 
    WHERE id_pedido = @IdPedido;

    SELECT p.id_producto, p.nombre, pp.cantidad 
    FROM Productos p
    INNER JOIN ProductosPorPedido pp ON p.id_producto = pp.id_producto
    WHERE pp.id_pedido = @IdPedido;
END;
-- CAMBIASOOOOOOOOOOOOOOOOOOOOOOOOOO




--Obtener receta del producto
CREATE PROCEDURE sp_ObtenerRecetaPorProducto
    @IdProducto INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT i.nombre AS Ingrediente, r.cantidad AS CantidadUsada, i.precio_unitario AS PrecioUnitario,
           r.cantidad * i.precio_unitario AS PrecioCalculado
    FROM Recetas r
    INNER JOIN Ingredientes i ON r.id_material = i.id_material
    WHERE r.id_producto = @IdProducto;
END;

--Listar Empleados
CREATE PROCEDURE sp_ListarEmpleados
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        id_empleado, 
        nombre, 
        apellidos, 
        puesto, 
        fecha_ingreso
    FROM Empleados;
END;


--Registrar Hoja de Produccion
CREATE PROCEDURE sp_RegistrarProduccion
    @IdProducto INT,
    @CantidadProduccion DECIMAL(10, 2),
    @Fecha DATE,
    @IdPedido INT,
    @IdProduccion INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO Produccion (id_producto, cantidad, fecha, id_pedido)
        VALUES (@IdProducto, @CantidadProduccion, @Fecha, @IdPedido);

        SET @IdProduccion = SCOPE_IDENTITY();
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;


--Asignar Empleados a una produccion:

CREATE PROCEDURE sp_AsignarEmpleadoAProduccion
    @IdProduccion INT,
    @IdEmpleado INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO EmpleadosPorProduccion (id_produccion, id_empleado)
        VALUES (@IdProduccion, @IdEmpleado);
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;


select*from Produccion
select*from EmpleadosPorProduccion

select*from Pedidos
select*from ProductosPorPedido
select*from Productos

--FRMEDITAR PRODUCTOS:
CREATE PROCEDURE sp_ListarProductos2
AS
BEGIN
    SET NOCOUNT ON;
    SELECT id_producto, nombre
    FROM Productos;
END;

--Detalles del producto y su receta
CREATE PROCEDURE sp_ObtenerProductoConReceta
    @IdProducto INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Datos del producto
    SELECT id_producto, nombre, descripcion
    FROM Productos
    WHERE id_producto = @IdProducto;

    -- Ingredientes de la receta
    SELECT i.nombre AS Ingrediente, r.cantidad AS Cantidad
    FROM Recetas r
    INNER JOIN Ingredientes i ON r.id_material = i.id_material
    WHERE r.id_producto = @IdProducto;
END;

--Actualizar producto
CREATE PROCEDURE sp_ActualizarProducto
    @IdProducto INT,
    @NuevoNombre VARCHAR(100),
    @NuevaDescripcion TEXT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Productos
    SET nombre = @NuevoNombre, descripcion = @NuevaDescripcion
    WHERE id_producto = @IdProducto;
END;


--Actualizar Receta

Create PROCEDURE sp_ActualizarReceta
    @IdProducto INT,
    @IdMaterial INT,
    @Cantidad DECIMAL(10, 2)
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertamos la nueva receta
    INSERT INTO Recetas (id_producto, id_material, cantidad)
    VALUES (@IdProducto, @IdMaterial, @Cantidad);
END;


select*from Recetas
select*from Productos


Create PROCEDURE sp_EliminarReceta
    @IdProducto INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Paso 1: Eliminar las recetas asociadas al producto especificado
    DELETE FROM Recetas
    WHERE id_producto = @IdProducto;

    -- Paso 2: Insertar nuevamente las recetas posteriores al IdProducto, desplazando el id_receta
    DECLARE @IdReceta INT;
    DECLARE @IdProductoPosterior INT;
    DECLARE @Cantidad DECIMAL;
    DECLARE @IdMaterial INT;

    -- Cursor para seleccionar las recetas posteriores
    DECLARE receta_cursor CURSOR FOR
    SELECT id_receta, id_producto, id_material, cantidad
    FROM Recetas
    WHERE id_producto > @IdProducto
    ORDER BY id_receta, id_producto, id_material, cantidad;

    OPEN receta_cursor;

    FETCH NEXT FROM receta_cursor INTO @IdReceta, @IdProductoPosterior, @IdMaterial, @Cantidad;

    -- Reinsertar las recetas desplazadas con nuevo id_receta
    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Insertar nuevamente con un nuevo id_receta
        INSERT INTO Recetas (id_producto, id_material, cantidad)
        VALUES (@IdProductoPosterior, @IdMaterial, @Cantidad);

        -- Mover al siguiente registro
        FETCH NEXT FROM receta_cursor INTO @IdReceta, @IdProductoPosterior, @IdMaterial, @Cantidad;
    END;

    CLOSE receta_cursor;
    DEALLOCATE receta_cursor;

    -- Paso 3: Ajustar el contador de IDs para que el próximo ID continúe correctamente
    DBCC CHECKIDENT ('Recetas', RESEED);
END;






--ESTO LO QUITAS PERO ES PARA ACTUALIZAR las tablas
DELETE FROM Recetas WHERE id_receta = 70;
DBCC CHECKIDENT ('Recetas', RESEED, 58);

DELETE FROM Productos WHERE id_producto = 11;
DBCC CHECKIDENT ('Productos', RESEED, 10);