
use Galletera

INSERT INTO Productos (nombre, descripcion)
VALUES 
('Galleta de Vainilla', 'Deliciosa galleta con sabor a vainilla'),
('Galleta de Chocolate', 'Galleta clásica con trozos de chocolate'),
('Galleta de Avena', 'Galleta saludable con avena y miel'),
('Galleta de Mantequilla', 'Galleta suave con sabor a mantequilla'),
('Galleta de Almendra', 'Galleta con trozos de almendra'),
('Galleta de Coco', 'Galleta con sabor a coco rallado'),
('Galleta de Fresa', 'Galleta con trozos de fresa fresca'),
('Galleta de Limón', 'Galleta refrescante con toque de limón'),
('Galleta de Canela', 'Galleta especiada con canela'),
('Galleta de Café', 'Galleta con intenso sabor a café');


INSERT INTO Ingredientes (nombre, precio_unitario)
VALUES
('Harina', 0.50),        -- Precio por kg
('Azúcar', 1.00),        -- Precio por kg
('Mantequilla', 4.00),   -- Precio por kg
('Huevo', 0.20),         -- Precio por unidad
('Coco rallado', 12.00),  -- Precio por kg
('Almendras', 20.00),     -- Precio por kg
('Chocolate', 11.00),     -- Precio por Kg
('Vainilla', 11.00),      -- Precio por litro
('Leche', 1.00),         -- Precio por litro
('Canela', 3.00),        -- Precio por kg
('Fresas', 4.00),        -- Precio por kg
('Café molido', 10.00);   -- Precio por kg



-- Insertar recetas para los productos
INSERT INTO Recetas (id_producto, id_material, cantidad)
VALUES 
-- Galleta de Vainilla
(1, 1, 0.2),  -- Harina (kg)
(1, 2, 0.1),  -- Azúcar (kg)
(1, 3, 0.1),  -- Mantequilla (kg)
(1, 4, 2),    -- Huevo (2 unidades)
(1, 8, 0.01),   -- Vainilla (l)

-- Galleta de Chocolate
(2, 1, 0.2),  -- Harina (kg)
(2, 2, 0.12),  -- Azúcar (kg)
(2, 3, 0.1),  -- Mantequilla (kg)
(2, 4, 1),    -- Huevo (1 unidad)
(2, 7, 0.1),  -- Chocolate (kg, troceado)
(2, 8, 0.005),    -- Vainilla (l)

-- Galleta de Avena
(3, 1, 0.15),  -- Harina (kg)
(3, 2, 0.08),   -- Azúcar (kg)
(3, 3, 0.1),  -- Mantequilla (kg)
(3, 4, 1),    -- Huevo (1 unidad)
(3, 5, 0.05),   -- Coco rallado (kg)
(3, 6, 0.1),  -- Almendras (kg)
(3, 9, 0.05),   -- Leche (l)

-- Galleta de Mantequilla
(4, 1, 0.25),  -- Harina (kg)
(4, 2, 0.15),  -- Azúcar (kg)
(4, 3, 0.2),  -- Mantequilla (kg)
(4, 4, 1),    -- Huevo (1 unidad)

-- Galleta de Almendra
(5, 1, 0.18),  -- Harina (kg)
(5, 2, 0.1),  -- Azúcar (100 g)
(5, 3, 0.1),  -- Mantequilla (kg)
(5, 4, 1),    -- Huevo (1 unidad)
(5, 6, 0.05),   -- Almendras (kg)

-- Galleta de Coco
(6, 1, 0.18),  -- Harina (kg)
(6, 2, 0.1),  -- Azúcar (kg)
(6, 3, 0.1),  -- Mantequilla (kg)
(6, 4, 1),    -- Huevo (1 unidad)
(6, 5, 0.05),   -- Coco rallado (kg)

-- Galleta de Fresa
(7, 1, 0.2),  -- Harina (kg)
(7, 2, 0.1),  -- Azúcar (kg)
(7, 3, 0.1),  -- Mantequilla (kg)
(7, 4, 1),    -- Huevo (1 unidad)
(7, 11, 0.05),  -- Fresas (kg, picadas)

-- Galleta de Limón
(8, 1, 0.2),  -- Harina (kg)
(8, 2, 0.1),  -- Azúcar (kg)
(8, 3, 0.1),  -- Mantequilla (kg)
(8, 4, 1),    -- Huevo (1 unidad)
(8, 8, 0.01),   -- Vainilla (l)
(8, 10, 0.01),  -- Limón (l de jugo)

-- Galleta de Canela
(9, 1, 0.2),  -- Harina (kg)
(9, 2, 0.1),  -- Azúcar (kg)
(9, 3, 0.1),  -- Mantequilla (kg)
(9, 4, 1),    -- Huevo (1 unidad)
(9, 10, 0.005),   -- Canela (kg)

-- Galleta de Café
(10, 1, 0.2), -- Harina (kg)
(10, 2, 0.12), -- Azúcar (kg)
(10, 3, 0.1), -- Mantequilla (kg)
(10, 4, 1),   -- Huevo (1 unidad)
(10, 12, 0.02); -- Café molido (kg)


INSERT INTO Empleados (nombre, apellidos, puesto, fecha_ingreso)
VALUES
('Juan', 'Pérez', 'Panadero', '2000-01-15'), --1
('María', 'Gómez', 'Jefe de Producción', '1999-05-22'), --2
('Carlos', 'Rodríguez', 'Vendedor', '2001-07-10'), --3
('Ana', 'Martínez', 'Panadero', '2004-03-03'), --4
('Luis', 'López', 'Operario', '2000-10-19'), --5
('Laura', 'Hernández', 'Supervisor de Calidad', '2010-02-14'), --6
('Pedro', 'Sánchez', 'Panadero', '1998-08-20'), --7
('Sofía', 'Torres', 'Jefe de Ventas', '1990-09-15'), --8
('Miguel', 'González', 'Operario', '2000-06-07'), --9
('Elena', 'Morales', 'Vendedora', '2001-01-12'), --10
('Ricardo', 'Vázquez', 'Panadero', '2003-11-01'), --11
('Beatriz', 'Álvarez', 'Jefe de Producción', '2005-02-28'), --12
('Raúl', 'Fernández', 'Supervisor de Producción', '2000-04-03'),  --13
('Marta', 'Jiménez', 'Panadera', '1998-03-25'), --14
('David', 'Ruiz', 'Operario', '1999-04-19'), --15
('Cristina', 'Romero', 'Vendedora', '2001-07-22'), --16
('Fernando', 'García', 'Panadero', '2004-11-05'), --17
('Juliana', 'Pérez', 'Supervisor de Calidad', '2003-09-10'), --18
('Samuel', 'Jiménez', 'Jefe de Producción', '2006-12-17'), --19
('Marcos', 'Suárez', 'Operario', '1999-08-10'); --20


INSERT INTO Cliente (nombre, apellidos, dni)
VALUES
('Juan', 'Pérez','75308553'),
('María', 'González','75305553'),
('Carlos', 'Ramírez','75332553'),
('Ana', 'Martínez','75308123'),
('Luis', 'Fernández','78308453');

-- Insertar 30 pedidos para 5 panaderías con fechas entre 2017 y 2023, ordenados por fecha
-- Asignar múltiples pedidos aleatorios a los clientes
INSERT INTO pedidos (id_cliente, fecha_pedido)
VALUES
(1, '2017-12-01'),
(1, '2024-12-03'),
(1, '2024-12-05'),
(1, '2018-12-07'),

(2, '2024-12-02'),
(2, '2023-12-04'),
(2, '2024-12-06'),
(2, '2023-12-08'),

(3, '2024-12-01'),
(3, '2021-12-02'),
(3, '2024-12-03'),
(3, '2018-12-04'),

(4, '2024-12-05'),
(4, '2024-12-06'),
(4, '2018-12-07'),
(4, '2024-12-08'),

(5, '2019-12-01'),
(5, '2024-12-03'),
(5, '2018-12-05'),
(5, '2020-12-07');


-- Insertar productos por pedido (relación muchos a muchos)
INSERT INTO ProductosPorPedido (id_pedido, id_producto, cantidad)
VALUES
(1, 1, 10),  -- Pedido 1, Galleta de Vainilla (10 unidades)
(1, 2, 8),   -- Pedido 1, Galleta de Chocolate (8 unidades)
(2, 3, 15),  -- Pedido 2, Galleta de Avena (15 unidades)
(2, 4, 12),  -- Pedido 2, Galleta de Mantequilla (12 unidades)
(3, 5, 20),  -- Pedido 3, Galleta de Almendra (20 unidades)
(3, 6, 25),  -- Pedido 3, Galleta de Coco (25 unidades)
(4, 7, 30),  -- Pedido 4, Galleta de Fresa (30 unidades)
(4, 8, 10),  -- Pedido 4, Galleta de Limón (10 unidades)
(5, 9, 40),  -- Pedido 5, Galleta de Canela (40 unidades)
(5, 10, 12), -- Pedido 5, Galleta de Café (12 unidades)

(6, 1, 10),  -- Pedido 6, Galleta de Vainilla (10 unidades)
(6, 2, 8),   -- Pedido 6, Galleta de Chocolate (8 unidades)
(7, 3, 15),  -- Pedido 7, Galleta de Avena (15 unidades)
(7, 4, 12),  -- Pedido 7, Galleta de Mantequilla (12 unidades)
(8, 5, 20),  -- Pedido 8, Galleta de Almendra (20 unidades)
(8, 6, 25),  -- Pedido 8, Galleta de Coco (25 unidades)
(9, 7, 30),  -- Pedido 9, Galleta de Fresa (30 unidades)
(9, 8, 10),  -- Pedido 9, Galleta de Limón (10 unidades)
(10, 9, 40), -- Pedido 10, Galleta de Canela (40 unidades)
(10, 10, 12),-- Pedido 10, Galleta de Café (12 unidades)

(11, 1, 15), -- Pedido 11, Galleta de Vainilla (15 unidades)
(11, 2, 18), -- Pedido 11, Galleta de Chocolate (18 unidades)
(12, 3, 25), -- Pedido 12, Galleta de Avena (25 unidades)
(12, 4, 10), -- Pedido 12, Galleta de Mantequilla (10 unidades)
(13, 5, 30), -- Pedido 13, Galleta de Almendra (30 unidades)
(13, 6, 20), -- Pedido 13, Galleta de Coco (20 unidades)
(14, 7, 50), -- Pedido 14, Galleta de Fresa (50 unidades)
(14, 8, 20), -- Pedido 14, Galleta de Limón (20 unidades)
(15, 9, 60), -- Pedido 15, Galleta de Canela (60 unidades)
(15, 10, 30),-- Pedido 15, Galleta de Café (30 unidades)

(16, 1, 20), -- Pedido 16, Galleta de Vainilla (20 unidades)
(16, 2, 10), -- Pedido 16, Galleta de Chocolate (10 unidades)
(17, 3, 18), -- Pedido 17, Galleta de Avena (18 unidades)
(17, 4, 25), -- Pedido 17, Galleta de Mantequilla (25 unidades)
(18, 5, 40), -- Pedido 18, Galleta de Almendra (40 unidades)
(18, 6, 30), -- Pedido 18, Galleta de Coco (30 unidades)
(19, 7, 35), -- Pedido 19, Galleta de Fresa (35 unidades)
(19, 8, 15), -- Pedido 19, Galleta de Limón (15 unidades)
(20, 9, 70), -- Pedido 20, Galleta de Canela (70 unidades)
(20, 10, 40)-- Pedido 20, Galleta de Café (40 unidades)



INSERT INTO Produccion (id_producto, cantidad, fecha, id_pedido)
VALUES
(1, 10, '2017-06-16', 1), 
(2, 8, '2017-06-16', 1),
(3, 15, '2017-11-02', 2), 
(4, 12, '2017-11-02', 2),
(5, 20, '2018-11-17', 3),
(6, 25, '2018-11-17', 3),
(7, 30, '2018-07-22', 4),
(8, 10, '2018-07-22', 4),
(9, 40, '2018-03-11', 5),
(10, 12, '2018-03-11', 5),
(1, 10, '2018-05-14', 6),
(2, 8, '2018-05-14', 6),
(3, 15, '2019-01-18', 7),
(4, 12, '2019-01-18', 7),
(5, 20, '2019-03-07', 8),
(6, 25, '2019-03-07', 8),
(7, 30, '2019-09-03', 9),
(8, 10, '2019-09-03', 9),
(9, 40, '2019-02-07', 10),
(10, 12, '2019-02-07', 10),
(1, 15, '2019-05-17', 11),
(2, 18, '2019-05-17', 11),
(3, 25, '2019-12-10', 12),
(4, 10, '2019-12-10', 12),
(5, 30, '2020-06-09', 13),
(6, 20, '2020-06-09', 13),
(7, 50, '2020-05-04', 14),
(8, 20, '2020-05-04', 14),
(9, 60, '2020-01-08', 15),
(10, 30, '2020-01-08', 15),
(1, 20, '2020-04-15', 16),
(2, 10, '2020-04-15', 16),
(3, 18, '2020-12-14', 17),
(4, 25, '2020-12-14', 17),
(5, 40, '2020-12-20', 18),
(6, 30, '2020-12-20', 18),
(7, 35, '2020-09-06', 19),
(8, 15, '2020-09-06', 19),
(9, 70, '2020-02-13', 20),
(10, 40, '2020-02-13', 20)

select *from produccion

INSERT INTO EmpleadosPorProduccion (id_produccion, id_empleado)
VALUES
(1, 1),(1, 2),(1, 3),(2, 4),(2, 5),(2, 6),(3, 6),(3, 7),(4, 12),(4, 11),(5, 8),(5, 14),(6, 16),(6, 20),(7, 15),(7, 1),(7, 19),(8, 10),(8, 2),
(9, 3),(9, 4),(10, 8),(10, 9),(11, 13),(11, 17),(12, 1),(12, 19),(13, 18),(13, 4),(14, 8),(14, 16),(15, 2),(15, 5),(16, 7),(16, 15),(17, 3),(17, 20),
(18, 8),(18, 4),(19, 6),(19, 10),(20, 11),(20, 20),(21, 4),(21, 5),(22, 7),(22, 2),(23, 6),(23, 1),(24, 8),(24, 11),(25, 8),(25, 5),(26, 10),(26, 11),
(27, 4),(27, 10),(28, 7),(28, 9),(29, 7),(29, 8),(30, 1),(30, 2),(31, 3),(31, 10),(32, 14),(32, 19),(33, 20),(33, 1),(34, 4),(34, 6),(35, 17),(35, 13),
(36, 14),(36, 2),(37, 18),(37, 20),(38, 3),(38, 9),(39, 4),(39, 14),(40, 12),(40, 3),(41, 5),(41, 2),(42, 15),(42, 20),(43, 4),(43, 6),(44, 1),(44, 2),
(45, 5),(45, 15),(46, 20),(46, 17),(47, 13),(47, 12),(48, 4),(48, 3),(49, 6),(49, 5),(50, 18),(50, 20),(51, 13),(51, 11),(52, 5),(52, 1),(53, 2),(53, 6),
(54, 8),(54, 7),(55, 14),(55, 3),(56, 5),(56, 8),(57, 6),(57, 11),(58, 5),(58, 2),(59, 17),(59, 20),(60, 6),(60, 1),(61, 7),(61, 15),(62, 13),(62, 2),
(63, 4),(63, 10),(64, 20),(64, 6),(65, 3),(65, 4),(66, 16),(66, 11),(67, 10),(67, 1),(68, 15),(68, 7),(69, 5),(69, 9),(70, 4),(70, 3),(71, 1),(71, 3),
(72, 11),(72, 19),(73, 7),(73, 15),(74, 8),(74, 5),(75, 1),(75, 3),(76, 6),(76, 8),(77, 5),(77, 18),(78, 20),(78, 4),(79, 3),(79, 9),(80, 17),(80, 15),
(81, 17),(81, 11),(82, 13),(82, 16),(83, 2),(83, 4),(84, 8),(84, 6);


-- (1, 1),(1, 2),(1, 3),(2, 4),(2, 5),(2, 6),(3, 6),(3, 7),(4, 12),(4, 11),(5, 8),(5, 14),(6, 16),(6, 20),(7, 15),(7, 1),(7, 19),(8, 10),(8, 2),
-- (9, 3),(9, 4),(10, 8),(10, 9),(11, 13),(11, 17),(12, 1),(12, 19),(13, 18),(13, 4),(14, 8),(14, 16),(15, 2),(15, 5),(16, 7),(16, 15),(17, 3),(17, 20),
-- (18, 8),(18, 4),(19, 6),(19, 10),(20, 11),(20, 20),(21, 4),(21, 5),(22, 7),(22, 2),(23, 6),(23, 1),(24, 8),(24, 11),(25, 8),(25, 5),(26, 10),(26, 11),
-- (27, 4),(27, 10),(28, 7),(28, 9),(29, 7),(29, 8),(30, 1),(30, 2),(31, 3),(31, 10),(32, 14),(32, 19),(33, 20),(33, 1),(34, 4),(34, 6),(35, 17),(35, 13),
--(36, 14),(36, 2),(37, 18),(37, 20),(38, 3),(38, 9),(39, 4),(39, 14),(40, 12),(40, 3),(41, 5),(41, 2),(42, 15),(42, 20),(43, 4),(43, 6),(44, 1),(44, 2),
-- (45, 5),(45, 15),(46, 20),(46, 17),(47, 13),(47, 12),(48, 4),(48, 3),(49, 6),(49, 5),(50, 18),(50, 20),(51, 13),(51, 11),(52, 5),(52, 1),(53, 2),(53, 6),
-- (54, 8),(54, 7),(55, 14),(55, 3),(56, 5),(56, 8),(57, 6),(57, 11),(58, 5),(58, 2),(59, 17),(59, 20),(60, 6),(60, 1),(61, 7),(61, 15),(62, 13),(62, 2),
-- (63, 4),(63, 10),(64, 20),(64, 6),(65, 3),(65, 4),(66, 16),(66, 11),(67, 10),(67, 1),(68, 15),(68, 7),(69, 5),(69, 9),(70, 4),(70, 3),(71, 1),(71, 3),
-- (72, 11),(72, 19),(73, 7),(73, 15),(74, 8),(74, 5),(75, 1),(75, 3),(76, 6),(76, 8),(77, 5),(77, 18),(78, 20),(78, 4),(79, 3),(79, 9),(80, 17),(80, 15),
-- (81, 17),(81, 11),(82, 13),(82, 16),(83, 2),(83, 4),(84, 8),(84, 6);