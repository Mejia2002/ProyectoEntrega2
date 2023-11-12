create database FinanzaDB
go

use FinanzaDB
go

CREATE TABLE Empleado (
    Identificacion NVARCHAR(50) PRIMARY KEY,
    Nombre NVARCHAR(50),
    Correo NVARCHAR(50),
    Telefono NVARCHAR(50),
    SalarioBase DECIMAL,
    Bonificacion DECIMAL,
    MesE INT,
    A�oE INT,
    SalarioTotal DECIMAL
);


CREATE TABLE Factura (
    CodigoFactura NVARCHAR(50) PRIMARY KEY,
    IdentificacionF NVARCHAR(50) FOREIGN KEY REFERENCES Empleado(Identificacion),
    MesF INT,
    A�oF INT,
    SueldoBaseF DECIMAL,
    BonificacionF DECIMAL,
    TotalPagadoF DECIMAL
);


CREATE TABLE Ganancia (
    MesGanancia INT,
    A�oGanancia INT,
    IngresoMensual DECIMAL,
    TotalGastoG DECIMAL,
    TotalGanancia DECIMAL,
);



CREATE TABLE GastoMensual (
    MesGastoMensual INT,
    A�oGastoMensual INT,
    TotalGastoSueldos DECIMAL,
    TotalGastoInsumos DECIMAL,
    GastoLiquidaciones DECIMAL,
    TotalGastado DECIMAL
);



CREATE TABLE GastosOtrosInsumos (
    FechaCompra DATETIME,
    NombreProducto NVARCHAR(50),
    CostoProducto DECIMAL
);



CREATE TABLE Liquidacion (
    CodigoLiquidacion NVARCHAR(50) PRIMARY KEY,
    IdentificacionL NVARCHAR(50) FOREIGN KEY REFERENCES Empleado(Identificacion),
    MesL INT,
    A�oL INT,
    DiasTrabajados INT,
    LiquidacionPorDia DECIMAL,
    TotalLiquidacion DECIMAL
);

