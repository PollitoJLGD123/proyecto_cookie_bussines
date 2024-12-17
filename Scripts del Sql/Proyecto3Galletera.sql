--AQUI EMPIEZA
use Galletera;
go

--PRIMER FORMULARIO FRM PEDIDOS
--INSERTAR UN PEDIDO
CREATE or ALTER PROCEDURE sp_InsertarPedido
    @FechaPedido DATE,
    @IdPedido INT OUTPUT,
	@nombre varchar(100),
	@apellido varchar(100),
	@dni char(8)
AS
BEGIN
	declare @IdCliente int;

	INSERT INTO Cliente(nombre,apellidos,dni)
	VALUES (@nombre,@apellido,@dni)

	SET @IdCliente = SCOPE_IDENTITY();

    INSERT INTO Pedidos (id_cliente, fecha_pedido)
    VALUES (@IdCliente, @FechaPedido);

	SET @IdPedido = SCOPE_IDENTITY();
END


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

    SELECT C.nombre + ' ' + C.apellidos as [nombre] 
    FROM Pedidos P INNER JOIN Cliente C ON C.id_cliente = P.id_cliente 
    WHERE id_pedido = @IdPedido;

    SELECT p.id_producto, p.nombre, pp.cantidad 
    FROM Productos p
    INNER JOIN ProductosPorPedido pp ON p.id_producto = pp.id_producto
    WHERE pp.id_pedido = @IdPedido;
END;


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
END


--Registrar Hoja de Produccion
CREATE PROCEDURE sp_RegistrarProduccion
    @Fecha DATE,
    @IdPedido INT,
    @IdProduccion INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO Produccion (fecha, id_pedido)
        VALUES (@Fecha, @IdPedido);

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

CREATE PROCEDURE sp_ClientePorPedido
    @id_pedido INT
AS
BEGIN
    SELECT 
        p.id_pedido,
        c.id_cliente,
        c.nombre AS nombre_cliente,
        c.apellidos AS apellido_cliente,
        c.dni AS dni_cliente
    FROM 
        Pedidos p
    INNER JOIN Cliente c ON p.id_cliente = c.id_cliente
    WHERE 
        p.id_pedido = @id_pedido;
END;
GO


CREATE PROCEDURE sp_ProductosPorPedido
    @id_pedido INT
AS
BEGIN
    SELECT 
        p.id_pedido,
        pr.id_producto,
        pr.nombre AS nombre_producto,
        pxp.cantidad AS cantidad_producto
    FROM 
        Pedidos p
    INNER JOIN ProductosPorPedido pxp ON p.id_pedido = pxp.id_pedido
    INNER JOIN Productos pr ON pxp.id_producto = pr.id_producto
    WHERE 
        p.id_pedido = @id_pedido;
END;
GO



CREATE PROCEDURE sp_EmpleadosPorPedido
    @id_pedido INT
AS
BEGIN
    SELECT 
        p.id_pedido,
        e.id_empleado,
        e.nombre AS nombre_empleado,
        e.apellidos AS apellido_empleado,
        prod.fecha AS fecha_produccion
    FROM 
        Pedidos p
    INNER JOIN Produccion prod ON p.id_pedido = prod.id_pedido
    INNER JOIN EmpleadosPorProduccion epp ON prod.id_produccion = epp.id_produccion
    INNER JOIN Empleados e ON epp.id_empleado = e.id_empleado
    WHERE 
        p.id_pedido = @id_pedido;
END;
GO

--ESTO LO QUITAS PERO ES PARA ACTUALIZAR las tablas
DELETE FROM Recetas WHERE id_receta = 70;
DBCC CHECKIDENT ('Recetas', RESEED, 58);

DELETE FROM Productos WHERE id_producto = 11;
DBCC CHECKIDENT ('Productos', RESEED, 10);
