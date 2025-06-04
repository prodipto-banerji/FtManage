-- Truck table creation script for FleetManagement database
CREATE TABLE Truck (
    TruckId INT IDENTITY(1,1) PRIMARY KEY,
    TruckCode NVARCHAR(50) NOT NULL,
    Description NVARCHAR(255),
    LiscencePlate NVARCHAR(50),
    MaxCubic DECIMAL(18,2),
    MaxUnits INT,
    MaxWeight DECIMAL(18,2),
    Status NVARCHAR(20)
);
