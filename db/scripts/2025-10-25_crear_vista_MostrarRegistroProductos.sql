USE SistemaVentasDB
GO

CREATE VIEW vw_MostrarRegistroProductos AS
SELECT p.ProductoID,
       p.Nombre,
       p.Precio,
       p.Codigo,
       p.Existencias,
       p.CategoriaID,
       c.Nombre AS Categoria
FROM Productos p
INNER JOIN Categorias c ON p.CategoriaID = c.CategoriaID;
GO