use TIENDA
go

CREATE PROCEDURE ObtenerConfiguracionEmpresa
AS
BEGIN
    SELECT TOP 1
        NombreEmpresa,
        DireccionEmpresa,
        TelefonoEmpresa,
        RutaImagenEmpresa
    FROM empresa;
END;
