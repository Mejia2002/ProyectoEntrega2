
CREATE PROCEDURE InsertarEmpleado
    @Nombre NVARCHAR(50),
    @Correo NVARCHAR(50),
    @Identificacion NVARCHAR(50),
    @Telefono NVARCHAR(50),
    @SalarioBase DECIMAL,
    @Bonificacion DECIMAL,
    @MesE INT,
    @AñoE INT,
    @SalarioTotal DECIMAL
AS
BEGIN
    -- Verificar si la identificación ya existe
    IF NOT EXISTS (SELECT 1 FROM Empleado WHERE Identificacion = @Identificacion)
    BEGIN
        -- La identificación no existe, se puede realizar la inserción
        INSERT INTO Empleado (Nombre, Correo, Identificacion, Telefono, SalarioBase, Bonificacion, MesE, AñoE, SalarioTotal)
        VALUES (@Nombre, @Correo, @Identificacion, @Telefono, @SalarioBase, @Bonificacion, @MesE, @AñoE, @SalarioTotal);
    END
    ELSE
    BEGIN
        -- La identificación ya existe, puedes manejar esto según tus necesidades
        PRINT 'La identificación ya existe. No se puede realizar la inserción.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;

select * from Empleado

CREATE PROCEDURE EliminarEmpleado
    @Identificacion NVARCHAR(50)
AS
BEGIN
    -- Verificar si la identificación existe
    IF EXISTS (SELECT 1 FROM Empleado WHERE Identificacion = @Identificacion)
    BEGIN
        -- La identificación existe, se puede realizar la eliminación
        DELETE FROM Empleado WHERE Identificacion = @Identificacion;
    END
    ELSE
    BEGIN
        -- La identificación no existe, puedes manejar esto según tus necesidades
        PRINT 'La identificación no existe. No se puede realizar la eliminación.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;



CREATE PROCEDURE ActualizarEmpleado
    @Identificacion NVARCHAR(50),
    @NuevoNombre NVARCHAR(MAX),
    @NuevoCorreo NVARCHAR(MAX),
    @NuevoTelefono NVARCHAR(MAX),
    @NuevoSalarioBase DECIMAL,
    @NuevaBonificacion DECIMAL,
    @NuevoMesE INT,
    @NuevoAñoE INT,
    @NuevoSalarioTotal DECIMAL
AS
BEGIN
    -- Verificar si la identificación existe
    IF EXISTS (SELECT 1 FROM Empleado WHERE Identificacion = @Identificacion)
    BEGIN
        -- La identificación existe, se puede realizar la actualización
        UPDATE Empleado
        SET 
            Nombre = @NuevoNombre,
            Correo = @NuevoCorreo,
            Telefono = @NuevoTelefono,
            SalarioBase = @NuevoSalarioBase,
            Bonificacion = @NuevaBonificacion,
            MesE = @NuevoMesE,
            AñoE = @NuevoAñoE,
            SalarioTotal = @NuevoSalarioTotal
        WHERE Identificacion = @Identificacion;
    END
    ELSE
    BEGIN
        -- La identificación no existe, puedes manejar esto según tus necesidades
        PRINT 'La identificación no existe. No se puede realizar la actualización.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;



CREATE PROCEDURE ObtenerEmpleadoPorIdentificacion
    @Identificacion NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Empleado
    WHERE Identificacion = @Identificacion;
END;


--CREATE PROCEDURE BuscarEmpleado
--    @Busqueda NVARCHAR(MAX)
--AS
--BEGIN
--    SELECT *
--    FROM Empleado
--    WHERE 
--        Nombre LIKE '%' + @Busqueda + '%' OR
--        Correo LIKE '%' + @Busqueda + '%' OR
--        Identificacion LIKE '%' + @Busqueda + '%' OR
--        Telefono LIKE '%' + @Busqueda + '%';
--END;

CREATE PROCEDURE BuscarEmpleado
    @Busqueda NVARCHAR(MAX)
AS
BEGIN
    DECLARE @Mensaje NVARCHAR(MAX);

    IF EXISTS (
        SELECT 1
        FROM Empleado
        WHERE 
            Nombre LIKE '%' + @Busqueda + '%' OR
            Correo LIKE '%' + @Busqueda + '%' OR
            Identificacion LIKE '%' + @Busqueda + '%' OR
            Telefono LIKE '%' + @Busqueda + '%'
    )
    BEGIN
        -- Se encontraron registros
        SET @Mensaje = 'Registros encontrados.';
        SELECT *, @Mensaje AS Mensaje
        FROM Empleado
        WHERE 
            Nombre LIKE '%' + @Busqueda + '%' OR
            Correo LIKE '%' + @Busqueda + '%' OR
            Identificacion LIKE '%' + @Busqueda + '%' OR
            Telefono LIKE '%' + @Busqueda + '%';
    END
    ELSE
    BEGIN
        -- No se encontraron registros
        SET @Mensaje = 'No existe registro en la tabla Empleado del Nombre, Correo, Identificación o Teléfono buscado.';
        SELECT @Mensaje AS Mensaje;
    END
END;

-----------Factura---------------

CREATE PROCEDURE InsertarFactura
    @CodigoFactura NVARCHAR(MAX),
    @IdentificacionF NVARCHAR(50),
    @MesF INT,
    @AñoF INT,
    @SueldoBaseF DECIMAL,
    @BonificacionF DECIMAL,
    @TotalPagadoF DECIMAL
AS
BEGIN
    -- Verificar si la identificación del empleado existe
    IF EXISTS (SELECT 1 FROM Empleado WHERE Identificacion = @IdentificacionF)
    BEGIN
        -- La identificación del empleado existe, se puede realizar la inserción de la factura
        INSERT INTO Factura (CodigoFactura, IdentificacionF, MesF, AñoF, SueldoBaseF, BonificacionF, TotalPagadoF)
        VALUES (@CodigoFactura, @IdentificacionF, @MesF, @AñoF, @SueldoBaseF, @BonificacionF, @TotalPagadoF);
    END
    ELSE
    BEGIN
        -- La identificación del empleado no existe, puedes manejar esto según tus necesidades
        PRINT 'La identificación del empleado no existe. No se puede realizar la inserción de la factura.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;



CREATE PROCEDURE EliminarFactura
    @CodigoFactura NVARCHAR(MAX),
    @IdentificacionF NVARCHAR(50)
AS
BEGIN
    -- Verificar si la factura existe
    IF EXISTS (SELECT 1 FROM Factura WHERE CodigoFactura = @CodigoFactura AND IdentificacionF = @IdentificacionF)
    BEGIN
        -- La factura existe, se puede realizar la eliminación
        DELETE FROM Factura WHERE CodigoFactura = @CodigoFactura AND IdentificacionF = @IdentificacionF;
    END
    ELSE
    BEGIN
        -- La factura no existe, puedes manejar esto según tus necesidades
        PRINT 'La factura no existe. No se puede realizar la eliminación.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;


CREATE PROCEDURE ActualizarFactura
    @CodigoFactura NVARCHAR(MAX),
    @IdentificacionF NVARCHAR(50),
    @NuevoMesF INT,
    @NuevoAñoF INT,
    @NuevoSueldoBaseF DECIMAL,
    @NuevaBonificacionF DECIMAL,
    @NuevoTotalPagadoF DECIMAL
AS
BEGIN
    -- Verificar si la factura existe
    IF EXISTS (SELECT 1 FROM Factura WHERE CodigoFactura = @CodigoFactura AND IdentificacionF = @IdentificacionF)
    BEGIN
        -- La factura existe, se puede realizar la actualización
        UPDATE Factura
        SET
            MesF = @NuevoMesF,
            AñoF = @NuevoAñoF,
            SueldoBaseF = @NuevoSueldoBaseF,
            BonificacionF = @NuevaBonificacionF,
            TotalPagadoF = @NuevoTotalPagadoF
        WHERE CodigoFactura = @CodigoFactura AND IdentificacionF = @IdentificacionF;
    END
    ELSE
    BEGIN
        -- La factura no existe, puedes manejar esto según tus necesidades
        PRINT 'La factura no existe. No se puede realizar la actualización.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;


CREATE PROCEDURE BuscarFactura
    @CodigoFactura NVARCHAR(MAX),
    @IdentificacionF NVARCHAR(50)
AS
BEGIN
    DECLARE @Mensaje NVARCHAR(MAX);

    IF EXISTS (SELECT 1 FROM Factura WHERE CodigoFactura = @CodigoFactura AND IdentificacionF = @IdentificacionF)
    BEGIN
        -- La factura existe, imprimir mensaje
        SET @Mensaje = 'La factura con CodigoFactura ' + @CodigoFactura + ' e Identificacion ' + @IdentificacionF + ' existe.';
        PRINT @Mensaje;

        -- Seleccionar la factura
        SELECT *
        FROM Factura
        WHERE CodigoFactura = @CodigoFactura AND IdentificacionF = @IdentificacionF;
    END
    ELSE
    BEGIN
        -- La factura no existe, imprimir mensaje
        SET @Mensaje = 'La factura con CodigoFactura ' + @CodigoFactura + ' e Identificacion ' + @IdentificacionF + ' no existe.';
        PRINT @Mensaje;
    END
END;


------------Ganancia---------------

CREATE PROCEDURE InsertarGanancia
    @MesGanancia INT,
    @AñoGanancia INT,
    @IngresoMensual DECIMAL,
    @TotalGastoG DECIMAL,
    @TotalGanancia DECIMAL
AS
BEGIN
    -- Verificar si la ganancia ya existe para el Mes y Año dados
    IF NOT EXISTS (SELECT 1 FROM Ganancia WHERE MesGanancia = @MesGanancia AND AñoGanancia = @AñoGanancia)
    BEGIN
        -- La ganancia no existe, se puede realizar la inserción
        INSERT INTO Ganancia (MesGanancia, AñoGanancia, IngresoMensual, TotalGastoG, TotalGanancia)
        VALUES (@MesGanancia, @AñoGanancia, @IngresoMensual, @TotalGastoG, @TotalGanancia);
        PRINT 'La ganancia para el Mes ' + CONVERT(NVARCHAR(10), @MesGanancia) + ' y Año ' + CONVERT(NVARCHAR(10), @AñoGanancia) + ' ha sido insertada correctamente.';
    END
    ELSE
    BEGIN
        -- La ganancia ya existe, imprimir mensaje
        PRINT 'La ganancia para el Mes ' + CONVERT(NVARCHAR(10), @MesGanancia) + ' y Año ' + CONVERT(NVARCHAR(10), @AñoGanancia) + ' ya existe. No se puede realizar la inserción.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;



CREATE PROCEDURE EliminarGanancia
    @MesGanancia INT,
    @AñoGanancia INT
AS
BEGIN
    -- Verificar si la ganancia existe para el Mes y Año dados
    IF EXISTS (SELECT 1 FROM Ganancia WHERE MesGanancia = @MesGanancia AND AñoGanancia = @AñoGanancia)
    BEGIN
        -- La ganancia existe, se puede realizar la eliminación
        DELETE FROM Ganancia WHERE MesGanancia = @MesGanancia AND AñoGanancia = @AñoGanancia;
        PRINT 'La ganancia para el Mes ' + CONVERT(NVARCHAR(10), @MesGanancia) + ' y Año ' + CONVERT(NVARCHAR(10), @AñoGanancia) + ' ha sido eliminada correctamente.';
    END
    ELSE
    BEGIN
        -- La ganancia no existe, imprimir mensaje
        PRINT 'La ganancia para el Mes ' + CONVERT(NVARCHAR(10), @MesGanancia) + ' y Año ' + CONVERT(NVARCHAR(10), @AñoGanancia) + ' no existe. No se puede realizar la eliminación.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;




CREATE PROCEDURE BuscarGanancia
    @MesGanancia INT,
    @AñoGanancia INT,
    @IngresoMensual DECIMAL,
    @TotalGastoG DECIMAL,
    @TotalGanancia DECIMAL
AS
BEGIN
    DECLARE @Mensaje NVARCHAR(MAX);

    IF EXISTS (SELECT 1 FROM Ganancia WHERE MesGanancia = @MesGanancia AND AñoGanancia = @AñoGanancia AND IngresoMensual = @IngresoMensual AND TotalGastoG = @TotalGastoG AND TotalGanancia = @TotalGanancia)
    BEGIN
        -- La ganancia existe, imprimir mensaje
        SET @Mensaje = 'La ganancia para el Mes ' + CONVERT(NVARCHAR(10), @MesGanancia) + ', Año ' + CONVERT(NVARCHAR(10), @AñoGanancia) + ', IngresoMensual ' + CONVERT(NVARCHAR(50), @IngresoMensual) + ', TotalGastoG ' + CONVERT(NVARCHAR(50), @TotalGastoG) + ' y TotalGanancia ' + CONVERT(NVARCHAR(50), @TotalGanancia) + ' existe.';
        PRINT @Mensaje;

        -- Seleccionar la ganancia
        SELECT *
        FROM Ganancia
        WHERE MesGanancia = @MesGanancia AND AñoGanancia = @AñoGanancia AND IngresoMensual = @IngresoMensual AND TotalGastoG = @TotalGastoG AND TotalGanancia = @TotalGanancia;
    END
    ELSE
    BEGIN
        -- La ganancia no existe, imprimir mensaje
        SET @Mensaje = 'La ganancia para el Mes ' + CONVERT(NVARCHAR(10), @MesGanancia) + ', Año ' + CONVERT(NVARCHAR(10), @AñoGanancia) + ', IngresoMensual ' + CONVERT(NVARCHAR(50), @IngresoMensual) + ', TotalGastoG ' + CONVERT(NVARCHAR(50), @TotalGastoG) + ' y TotalGanancia ' + CONVERT(NVARCHAR(50), @TotalGanancia) + ' no existe.';
        PRINT @Mensaje;
    END
END;


CREATE PROCEDURE ActualizarGanancia
    @MesGanancia INT,
    @AñoGanancia INT,
    @NuevoIngresoMensual DECIMAL,
    @NuevoTotalGastoG DECIMAL,
    @NuevoTotalGanancia DECIMAL
AS
BEGIN
    -- Verificar si la ganancia existe para el Mes y Año dados
    IF EXISTS (SELECT 1 FROM Ganancia WHERE MesGanancia = @MesGanancia AND AñoGanancia = @AñoGanancia)
    BEGIN
        -- La ganancia existe, se puede realizar la actualización
        UPDATE Ganancia
        SET
            IngresoMensual = @NuevoIngresoMensual,
            TotalGastoG = @NuevoTotalGastoG,
            TotalGanancia = @NuevoTotalGanancia
        WHERE MesGanancia = @MesGanancia AND AñoGanancia = @AñoGanancia;
        PRINT 'La ganancia para el Mes ' + CONVERT(NVARCHAR(10), @MesGanancia) + ' y Año ' + CONVERT(NVARCHAR(10), @AñoGanancia) + ' ha sido actualizada correctamente.';
    END
    ELSE
    BEGIN
        -- La ganancia no existe, imprimir mensaje
        PRINT 'La ganancia para el Mes ' + CONVERT(NVARCHAR(10), @MesGanancia) + ' y Año ' + CONVERT(NVARCHAR(10), @AñoGanancia) + ' no existe. No se puede realizar la actualización.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;


----------GastoMensual----------

CREATE PROCEDURE InsertarGastoMensual
    @MesGastoMensual INT,
    @AñoGastoMensual INT,
    @TotalGastoSueldos DECIMAL,
    @TotalGastoInsumos DECIMAL,
    @GastoLiquidaciones DECIMAL,
    @TotalGastado DECIMAL
AS
BEGIN
    -- Verificar si el gasto mensual ya existe para el Mes y Año dados
    IF NOT EXISTS (SELECT 1 FROM GastoMensual WHERE MesGastoMensual = @MesGastoMensual AND AñoGastoMensual = @AñoGastoMensual)
    BEGIN
        -- El gasto mensual no existe, se puede realizar la inserción
        INSERT INTO GastoMensual (MesGastoMensual, AñoGastoMensual, TotalGastoSueldos, TotalGastoInsumos, GastoLiquidaciones, TotalGastado)
        VALUES (@MesGastoMensual, @AñoGastoMensual, @TotalGastoSueldos, @TotalGastoInsumos, @GastoLiquidaciones, @TotalGastado);
        PRINT 'El gasto mensual para el Mes ' + CONVERT(NVARCHAR(10), @MesGastoMensual) + ' y Año ' + CONVERT(NVARCHAR(10), @AñoGastoMensual) + ' ha sido insertado correctamente.';
    END
    ELSE
    BEGIN
        -- El gasto mensual ya existe, imprimir mensaje
        PRINT 'El gasto mensual para el Mes ' + CONVERT(NVARCHAR(10), @MesGastoMensual) + ' y Año ' + CONVERT(NVARCHAR(10), @AñoGastoMensual) + ' ya existe. No se puede realizar la inserción.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;


CREATE PROCEDURE EliminarGastoMensual
    @MesGastoMensual INT,
    @AñoGastoMensual INT
AS
BEGIN
    -- Verificar si el gasto mensual existe para el Mes y Año dados
    IF EXISTS (SELECT 1 FROM GastoMensual WHERE MesGastoMensual = @MesGastoMensual AND AñoGastoMensual = @AñoGastoMensual)
    BEGIN
        -- El gasto mensual existe, se puede realizar la eliminación
        DELETE FROM GastoMensual WHERE MesGastoMensual = @MesGastoMensual AND AñoGastoMensual = @AñoGastoMensual;
        PRINT 'El gasto mensual para el Mes ' + CONVERT(NVARCHAR(10), @MesGastoMensual) + ' y Año ' + CONVERT(NVARCHAR(10), @AñoGastoMensual) + ' ha sido eliminado correctamente.';
    END
    ELSE
    BEGIN
        -- El gasto mensual no existe, imprimir mensaje
        PRINT 'El gasto mensual para el Mes ' + CONVERT(NVARCHAR(10), @MesGastoMensual) + ' y Año ' + CONVERT(NVARCHAR(10), @AñoGastoMensual) + ' no existe. No se puede realizar la eliminación.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;


CREATE PROCEDURE BuscarGastoMensual
    @MesGastoMensual INT,
    @AñoGastoMensual INT,
    @TotalGastoSueldos DECIMAL,
    @TotalGastoInsumos DECIMAL,
    @GastoLiquidaciones DECIMAL,
    @TotalGastado DECIMAL
AS
BEGIN
    DECLARE @Mensaje NVARCHAR(MAX);

    IF EXISTS (SELECT 1 FROM GastoMensual WHERE MesGastoMensual = @MesGastoMensual AND AñoGastoMensual = @AñoGastoMensual AND TotalGastoSueldos = @TotalGastoSueldos AND TotalGastoInsumos = @TotalGastoInsumos AND GastoLiquidaciones = @GastoLiquidaciones AND TotalGastado = @TotalGastado)
    BEGIN
        -- El gasto mensual existe, imprimir mensaje
        SET @Mensaje = 'El gasto mensual para el Mes ' + CONVERT(NVARCHAR(10), @MesGastoMensual) + ', Año ' + CONVERT(NVARCHAR(10), @AñoGastoMensual) + ', TotalGastoSueldos ' + CONVERT(NVARCHAR(50), @TotalGastoSueldos) + ', TotalGastoInsumos ' + CONVERT(NVARCHAR(50), @TotalGastoInsumos) + ', GastoLiquidaciones ' + CONVERT(NVARCHAR(50), @GastoLiquidaciones) + ' y TotalGastado ' + CONVERT(NVARCHAR(50), @TotalGastado) + ' existe.';
        PRINT @Mensaje;

        -- Seleccionar el gasto mensual
        SELECT *
        FROM GastoMensual
        WHERE MesGastoMensual = @MesGastoMensual AND AñoGastoMensual = @AñoGastoMensual AND TotalGastoSueldos = @TotalGastoSueldos AND TotalGastoInsumos = @TotalGastoInsumos AND GastoLiquidaciones = @GastoLiquidaciones AND TotalGastado = @TotalGastado;
    END
    ELSE
    BEGIN
        -- El gasto mensual no existe, imprimir mensaje
        SET @Mensaje = 'El gasto mensual para el Mes ' + CONVERT(NVARCHAR(10), @MesGastoMensual) + ', Año ' + CONVERT(NVARCHAR(10), @AñoGastoMensual) + ', TotalGastoSueldos ' + CONVERT(NVARCHAR(50), @TotalGastoSueldos) + ', TotalGastoInsumos ' + CONVERT(NVARCHAR(50), @TotalGastoInsumos) + ', GastoLiquidaciones ' + CONVERT(NVARCHAR(50), @GastoLiquidaciones) + ' y TotalGastado ' + CONVERT(NVARCHAR(50), @TotalGastado) + ' no existe.';
        PRINT @Mensaje;
    END
END;


CREATE PROCEDURE ActualizarGastoMensual
    @MesGastoMensual INT,
    @AñoGastoMensual INT,
    @NuevoTotalGastoSueldos DECIMAL,
    @NuevoTotalGastoInsumos DECIMAL,
    @NuevoGastoLiquidaciones DECIMAL,
    @NuevoTotalGastado DECIMAL
AS
BEGIN
    -- Verificar si el gasto mensual existe para el Mes y Año dados
    IF EXISTS (SELECT 1 FROM GastoMensual WHERE MesGastoMensual = @MesGastoMensual AND AñoGastoMensual = @AñoGastoMensual)
    BEGIN
        -- El gasto mensual existe, se puede realizar la actualización
        UPDATE GastoMensual
        SET
            TotalGastoSueldos = @NuevoTotalGastoSueldos,
            TotalGastoInsumos = @NuevoTotalGastoInsumos,
            GastoLiquidaciones = @NuevoGastoLiquidaciones,
            TotalGastado = @NuevoTotalGastado
        WHERE MesGastoMensual = @MesGastoMensual AND AñoGastoMensual = @AñoGastoMensual;
        PRINT 'El gasto mensual para el Mes ' + CONVERT(NVARCHAR(10), @MesGastoMensual) + ' y Año ' + CONVERT(NVARCHAR(10), @AñoGastoMensual) + ' ha sido actualizado correctamente.';
    END
    ELSE
    BEGIN
        -- El gasto mensual no existe, imprimir mensaje
        PRINT 'El gasto mensual para el Mes ' + CONVERT(NVARCHAR(10), @MesGastoMensual) + ' y Año ' + CONVERT(NVARCHAR(10), @AñoGastoMensual) + ' no existe. No se puede realizar la actualización.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;

-----------GastoOtrosInsumos------------

CREATE PROCEDURE InsertarGastosOtrosInsumos
    @FechaCompra DATETIME,
    @NombreProducto NVARCHAR(MAX),
    @CostoProducto DECIMAL
AS
BEGIN
    -- Verificar si la compra ya existe para la Fecha y Nombre del Producto dados
    IF NOT EXISTS (SELECT 1 FROM GastosOtrosInsumos WHERE FechaCompra = @FechaCompra AND NombreProducto = @NombreProducto)
    BEGIN
        -- La compra no existe, se puede realizar la inserción
        INSERT INTO GastosOtrosInsumos (FechaCompra, NombreProducto, CostoProducto)
        VALUES (@FechaCompra, @NombreProducto, @CostoProducto);
        PRINT 'La compra para la Fecha ' + CONVERT(NVARCHAR(20), @FechaCompra, 120) + ' y Nombre del Producto ' + @NombreProducto + ' ha sido insertada correctamente.';
    END
    ELSE
    BEGIN
        -- La compra ya existe, imprimir mensaje
        PRINT 'La compra para la Fecha ' + CONVERT(NVARCHAR(20), @FechaCompra, 120) + ' y Nombre del Producto ' + @NombreProducto + ' ya existe. No se puede realizar la inserción.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;


CREATE PROCEDURE EliminarGastosOtrosInsumos
    @FechaCompra DATETIME,
    @NombreProducto NVARCHAR(MAX)
AS
BEGIN
    -- Verificar si la compra existe para la Fecha y Nombre del Producto dados
    IF EXISTS (SELECT 1 FROM GastosOtrosInsumos WHERE FechaCompra = @FechaCompra AND NombreProducto = @NombreProducto)
    BEGIN
        -- La compra existe, se puede realizar la eliminación
        DELETE FROM GastosOtrosInsumos WHERE FechaCompra = @FechaCompra AND NombreProducto = @NombreProducto;
        PRINT 'La compra para la Fecha ' + CONVERT(NVARCHAR(20), @FechaCompra, 120) + ' y Nombre del Producto ' + @NombreProducto + ' ha sido eliminada correctamente.';
    END
    ELSE
    BEGIN
        -- La compra no existe, imprimir mensaje
        PRINT 'La compra para la Fecha ' + CONVERT(NVARCHAR(20), @FechaCompra, 120) + ' y Nombre del Producto ' + @NombreProducto + ' no existe. No se puede realizar la eliminación.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;


CREATE PROCEDURE BuscarGastosOtrosInsumos
    @FechaCompra DATETIME,
    @NombreProducto NVARCHAR(MAX),
    @CostoProducto DECIMAL
AS
BEGIN
    DECLARE @Mensaje NVARCHAR(MAX);

    IF EXISTS (SELECT 1 FROM GastosOtrosInsumos WHERE FechaCompra = @FechaCompra AND NombreProducto = @NombreProducto AND CostoProducto = @CostoProducto)
    BEGIN
        -- La compra existe, imprimir mensaje
        SET @Mensaje = 'La compra para la Fecha ' + CONVERT(NVARCHAR(20), @FechaCompra, 120) + ', Nombre del Producto ' + @NombreProducto + ' y Costo ' + CONVERT(NVARCHAR(50), @CostoProducto) + ' existe.';
        PRINT @Mensaje;

        -- Seleccionar la compra
        SELECT *
        FROM GastosOtrosInsumos
        WHERE FechaCompra = @FechaCompra AND NombreProducto = @NombreProducto AND CostoProducto = @CostoProducto;
    END
    ELSE
    BEGIN
        -- La compra no existe, imprimir mensaje
        SET @Mensaje = 'La compra para la Fecha ' + CONVERT(NVARCHAR(20), @FechaCompra, 120) + ', Nombre del Producto ' + @NombreProducto + ' y Costo ' + CONVERT(NVARCHAR(50), @CostoProducto) + ' no existe.';
        PRINT @Mensaje;
    END
END;



CREATE PROCEDURE ActualizarGastosOtrosInsumos
    @FechaCompra DATETIME,
    @NombreProducto NVARCHAR(MAX),
    @NuevoCostoProducto DECIMAL
AS
BEGIN
    -- Verificar si la compra existe para la Fecha y Nombre del Producto dados
    IF EXISTS (SELECT 1 FROM GastosOtrosInsumos WHERE FechaCompra = @FechaCompra AND NombreProducto = @NombreProducto)
    BEGIN
        -- La compra existe, se puede realizar la actualización
        UPDATE GastosOtrosInsumos
        SET CostoProducto = @NuevoCostoProducto
        WHERE FechaCompra = @FechaCompra AND NombreProducto = @NombreProducto;
        PRINT 'La compra para la Fecha ' + CONVERT(NVARCHAR(20), @FechaCompra, 120) + ' y Nombre del Producto ' + @NombreProducto + ' ha sido actualizada correctamente.';
    END
    ELSE
    BEGIN
        -- La compra no existe, imprimir mensaje
        PRINT 'La compra para la Fecha ' + CONVERT(NVARCHAR(20), @FechaCompra, 120) + ' y Nombre del Producto ' + @NombreProducto + ' no existe. No se puede realizar la actualización.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;


---------Liquidacion-----------

CREATE PROCEDURE InsertarLiquidacion
    @CodigoLiquidacion NVARCHAR(MAX),
    @IdentificacionL NVARCHAR(50),
    @MesL INT,
    @AñoL INT,
    @DiasTrabajados INT,
    @LiquidacionPorDia DECIMAL,
    @TotalLiquidacion DECIMAL
AS
BEGIN
    -- Verificar si la liquidación ya existe para el Código y Identificación del Empleado dados
    IF NOT EXISTS (SELECT 1 FROM Liquidacion WHERE CodigoLiquidacion = @CodigoLiquidacion AND IdentificacionL = @IdentificacionL)
    BEGIN
        -- La liquidación no existe, se puede realizar la inserción
        INSERT INTO Liquidacion (CodigoLiquidacion, IdentificacionL, MesL, AñoL, DiasTrabajados, LiquidacionPorDia, TotalLiquidacion)
        VALUES (@CodigoLiquidacion, @IdentificacionL, @MesL, @AñoL, @DiasTrabajados, @LiquidacionPorDia, @TotalLiquidacion);
        PRINT 'La liquidación con Código ' + @CodigoLiquidacion + ' e Identificación del Empleado ' + @IdentificacionL + ' ha sido insertada correctamente.';
    END
    ELSE
    BEGIN
        -- La liquidación ya existe, imprimir mensaje
        PRINT 'La liquidación con Código ' + @CodigoLiquidacion + ' e Identificación del Empleado ' + @IdentificacionL + ' ya existe. No se puede realizar la inserción.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;


CREATE PROCEDURE EliminarLiquidacion
    @CodigoLiquidacion NVARCHAR(MAX),
    @IdentificacionL NVARCHAR(50)
AS
BEGIN
    -- Verificar si la liquidación existe para el Código y Identificación del Empleado dados
    IF EXISTS (SELECT 1 FROM Liquidacion WHERE CodigoLiquidacion = @CodigoLiquidacion AND IdentificacionL = @IdentificacionL)
    BEGIN
        -- La liquidación existe, se puede realizar la eliminación
        DELETE FROM Liquidacion WHERE CodigoLiquidacion = @CodigoLiquidacion AND IdentificacionL = @IdentificacionL;
        PRINT 'La liquidación con Código ' + @CodigoLiquidacion + ' e Identificación del Empleado ' + @IdentificacionL + ' ha sido eliminada correctamente.';
    END
    ELSE
    BEGIN
        -- La liquidación no existe, imprimir mensaje
        PRINT 'La liquidación con Código ' + @CodigoLiquidacion + ' e Identificación del Empleado ' + @IdentificacionL + ' no existe. No se puede realizar la eliminación.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;


CREATE PROCEDURE BuscarLiquidacion
    @CodigoLiquidacion NVARCHAR(MAX),
    @IdentificacionL NVARCHAR(50),
    @MesL INT,
    @AñoL INT,
    @DiasTrabajados INT,
    @LiquidacionPorDia DECIMAL,
    @TotalLiquidacion DECIMAL
AS
BEGIN
    DECLARE @Mensaje NVARCHAR(MAX);

    IF EXISTS (SELECT 1 FROM Liquidacion WHERE CodigoLiquidacion = @CodigoLiquidacion AND IdentificacionL = @IdentificacionL AND MesL = @MesL AND AñoL = @AñoL AND DiasTrabajados = @DiasTrabajados AND LiquidacionPorDia = @LiquidacionPorDia AND TotalLiquidacion = @TotalLiquidacion)
    BEGIN
        -- La liquidación existe, imprimir mensaje
        SET @Mensaje = 'La liquidación con Código ' + @CodigoLiquidacion + ', Identificación del Empleado ' + @IdentificacionL + ', Mes ' + CONVERT(NVARCHAR(10), @MesL) + ', Año ' + CONVERT(NVARCHAR(10), @AñoL) + ', Días Trabajados ' + CONVERT(NVARCHAR(10), @DiasTrabajados) + ', Liquidación por Día ' + CONVERT(NVARCHAR(50), @LiquidacionPorDia) + ' y Total de Liquidación ' + CONVERT(NVARCHAR(50), @TotalLiquidacion) + ' existe.';
        PRINT @Mensaje;

        -- Seleccionar la liquidación
        SELECT *
        FROM Liquidacion
        WHERE CodigoLiquidacion = @CodigoLiquidacion AND IdentificacionL = @IdentificacionL AND MesL = @MesL AND AñoL = @AñoL AND DiasTrabajados = @DiasTrabajados AND LiquidacionPorDia = @LiquidacionPorDia AND TotalLiquidacion = @TotalLiquidacion;
    END
    ELSE
    BEGIN
        -- La liquidación no existe, imprimir mensaje
        SET @Mensaje = 'La liquidación con Código ' + @CodigoLiquidacion + ', Identificación del Empleado ' + @IdentificacionL + ', Mes ' + CONVERT(NVARCHAR(10), @MesL) + ', Año ' + CONVERT(NVARCHAR(10), @AñoL) + ', Días Trabajados ' + CONVERT(NVARCHAR(10), @DiasTrabajados) + ', Liquidación por Día ' + CONVERT(NVARCHAR(50), @LiquidacionPorDia) + ' y Total de Liquidación ' + CONVERT(NVARCHAR(50), @TotalLiquidacion) + ' no existe.';
        PRINT @Mensaje;
    END
END;



CREATE PROCEDURE ActualizarLiquidacion
    @CodigoLiquidacion NVARCHAR(MAX),
    @IdentificacionL NVARCHAR(50),
    @MesL INT,
    @AñoL INT,
    @NuevoDiasTrabajados INT,
    @NuevoLiquidacionPorDia DECIMAL,
    @NuevoTotalLiquidacion DECIMAL
AS
BEGIN
    -- Verificar si la liquidación existe para el Código y Identificación del Empleado dados
    IF EXISTS (SELECT 1 FROM Liquidacion WHERE CodigoLiquidacion = @CodigoLiquidacion AND IdentificacionL = @IdentificacionL)
    BEGIN
        -- La liquidación existe, se puede realizar la actualización
        UPDATE Liquidacion
        SET
            MesL = @MesL,
            AñoL = @AñoL,
            DiasTrabajados = @NuevoDiasTrabajados,
            LiquidacionPorDia = @NuevoLiquidacionPorDia,
            TotalLiquidacion = @NuevoTotalLiquidacion
        WHERE CodigoLiquidacion = @CodigoLiquidacion AND IdentificacionL = @IdentificacionL;
        PRINT 'La liquidación con Código ' + @CodigoLiquidacion + ' e Identificación del Empleado ' + @IdentificacionL + ' ha sido actualizada correctamente.';
    END
    ELSE
    BEGIN
        -- La liquidación no existe, imprimir mensaje
        PRINT 'La liquidación con Código ' + @CodigoLiquidacion + ' e Identificación del Empleado ' + @IdentificacionL + ' no existe. No se puede realizar la actualización.';
        -- Puedes lanzar una excepción, devolver un código de error, etc.
    END
END;


