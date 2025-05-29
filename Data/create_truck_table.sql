-- Truck table creation script for SQL Server
CREATE TABLE Truck (
    TruckCode NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500),
    LiscencePlate NVARCHAR(100),
    MaxCubic FLOAT,
    MaxWeight FLOAT,
    MaxUnits INT,
    Status NVARCHAR(50),
    Vendor NVARCHAR(100),
    HomeDC NVARCHAR(100)
);
