--NOTA: Crear el campo activo o Crear nuevamente la DB
ALTER TABLE Categorias
ADD Activo BIT DEFAULT(1)


--Crear nuevamente la DB
CREATE DATABASE SistemaVentasDB
GO


USE SistemaVentasDB
GO

-- Tabla de Categorías
CREATE TABLE Categorias (
    CategoriaID INT IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Activo BIT DEFAULT(1)

    CONSTRAINT [UN_Categorias_Nombre] UNIQUE(Nombre),
    CONSTRAINT [PK_Categorias_CategoriaID] PRIMARY KEY(CategoriaID)
);
GO

-- Tabla de Productos
CREATE TABLE Productos(
    ProductoID INT IDENTITY(1,1),
    Nombre NVARCHAR(150) NOT NULL,
    Precio DECIMAL(18, 2) NOT NULL,
    CategoriaID INT NOT NULL,
    Codigo AS ('P' + RIGHT('0000' + CAST(ProductoID AS VARCHAR(4)), 4)) PERSISTED,
    Existencias INT NOT NULL DEFAULT 0,

    CONSTRAINT [PK_Productos_ProductoID] PRIMARY KEY(ProductoID),
    CONSTRAINT [FK_Productos_CategoriaID] FOREIGN KEY (CategoriaID) REFERENCES Categorias(CategoriaID),
    CONSTRAINT [CK_Productos_Precio] CHECK (Precio >= 0),
    CONSTRAINT [CK_Productos_Existencias] CHECK (Existencias >= 0),
);
GO





-- Tabla de Clientes
CREATE TABLE Clientes (
    ClienteID INT IDENTITY(1,1),
    Cedula VARCHAR(20) NOT NULL,
    NombreCompleto NVARCHAR(100) NOT NULL,
    Telefono VARCHAR(20),
    Activo BIT DEFAULT(1), --El nuevo campo 

    CONSTRAINT [PK_Clientes_ClienteID] PRIMARY KEY(ClienteID),
    CONSTRAINT [UN_Clientes_Cedula] UNIQUE(Cedula) 
);
GO

CREATE TABLE Roles (
    RolID INT IDENTITY(1,1) PRIMARY KEY,
    NombreRol NVARCHAR(50) NOT NULL UNIQUE,
    Descripcion NVARCHAR(255) NULL
);
GO

-- Tabla de Usuarios 
CREATE TABLE Usuarios (
    UsuarioID INT IDENTITY(1,1),
    NombreUsuario NVARCHAR(50) NOT NULL,
    Contrasena VARCHAR(255) NOT NULL, 
    NombreCompleto NVARCHAR(100) NOT NULL,
    RolID INT NULL,
    Activo BIT DEFAULT(1) --El nuevo campo 

    CONSTRAINT [PK_Usuarios_UsuarioID] PRIMARY KEY(UsuarioID),
    CONSTRAINT [UN_Usuarios_NombreUsuario] UNIQUE(NombreUsuario),
    CONSTRAINT [FK_Usuarios_RolID] FOREIGN KEY (RolID) REFERENCES Roles(RolID)
);
GO

-- Tabla de Ventas
CREATE TABLE Ventas (
    VentaID INT IDENTITY(1,1),
    ClienteID INT NOT NULL,
    UsuarioID INT NOT NULL,
    FechaVenta DATETIME DEFAULT GETDATE(),
    Total DECIMAL(18, 2) NOT NULL,

    CONSTRAINT [PK_Ventas_VentaID] PRIMARY KEY(VentaID),
    CONSTRAINT [FK_Ventas_ClienteID] FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID),
    CONSTRAINT [FK_Ventas_UsuarioID] FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
);
GO

-- Tabla de Detalles de Venta
CREATE TABLE DetallesVenta (
    DetalleID INT IDENTITY(1,1),
    VentaID INT NOT NULL,
    ProductoID INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(18, 2) NOT NULL,

    CONSTRAINT [PK_DetallesVenta_DetalleID] PRIMARY KEY(DetalleID),
    CONSTRAINT [FK_DetallesVenta_VentaID] FOREIGN KEY (VentaID) REFERENCES Ventas(VentaID),
    CONSTRAINT [FK_DetallesVenta_ProductoID] FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID),
    CONSTRAINT [CK_DetallesVenta_Cantidad] CHECK (Cantidad > 0)
);
GO



INSERT INTO Categorias (Nombre) VALUES
('Electrónicos'),
('Ropa'),
('Hogar'),
('Deportes'),
('Libros');
GO

INSERT INTO Productos (Nombre, Precio, CategoriaID, Existencias) VALUES
('Laptop HP 15"', 8500.00, 1, 10),
('Mouse Inalámbrico', 350.00, 1, 25),
('Teclado Mecánico', 1200.00, 1, 15),
('Camiseta de Algodón', 250.00, 2, 50),
('Pantalón Jeans', 800.00, 2, 30),
('Sartén Antiadherente', 450.00, 3, 20),
('Juego de Sábanas', 600.00, 3, 25),
('Balón de Fútbol', 300.00, 4, 40),
('Raqueta de Tenis', 950.00, 4, 12),
('Novela Best Seller', 350.00, 5, 60);
GO




INSERT INTO Roles (NombreRol, Descripcion) VALUES 
('Administrador', 'Acceso completo al sistema'),
('Vendedor', 'Puede realizar ventas y consultas')
GO


-- LUEGO insertar usuarios con RolID CORRECTO
IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE NombreUsuario = 'admin')
BEGIN
    INSERT INTO Usuarios (NombreUsuario, Contrasena, NombreCompleto, RolID)
    VALUES ('admin', 'admin123', 'Administrador Principal', 1); -- 1 = Administrador
END
GO

-- Insertar más usuarios de ejemplo
IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE NombreUsuario = 'vendedor1')
BEGIN
    INSERT INTO Usuarios (NombreUsuario, Contrasena, NombreCompleto, RolID)
    VALUES ('vendedor1', 'vendedor123', 'Juan Vendedor', 2); -- 2 = Vendedor
END
GO


IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE NombreUsuario = 'vendedor2')
BEGIN
    INSERT INTO Usuarios (NombreUsuario, Contrasena, NombreCompleto, RolID, Activo)
    VALUES ('vendedor2', 'vendedor123', 'Maria Vendedor', 2, 0); -- 2 = Vendedor
END
GO


USE SistemaVentasDB
GO

-- Inserta un cliente activo (usando el valor DEFAULT para 'Activo')
INSERT INTO Clientes (Cedula, NombreCompleto, Telefono) 
VALUES ('123-456789-0', 'Ana Sofía Torres', '8877-6655');
GO

-- Inserta otro cliente activo
INSERT INTO Clientes (Cedula, NombreCompleto, Telefono) 
VALUES ('001-150795-1234A', 'Mario José Pérez', '8123-4567');
GO

-- Inserta un cliente inactivo a propósito (especificando 'Activo = 0')
INSERT INTO Clientes (Cedula, NombreCompleto, Telefono, Activo) 
VALUES ('J-98765432', 'Registro de Prueba (Inactiva)', '2233-4455', 0);
GO

