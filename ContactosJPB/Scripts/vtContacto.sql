use [ServicioAndroid]
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='p' AND s.name='vtContacto')
DROP PROCEDURE vtContacto
GO
CREATE PROCEDURE vtContacto
@Nombre varchar(100)

WITH ENCRYPTION
AS
BEGIN
declare
@Nombre1 varchar(105) = '%%%'

	if @Nombre <> '' select @Nombre1 = concat('%',@Nombre,'%')

	Select IdContacto, Nombre, TipoContacto, TelFijo, TelMovil, FechaNacimiento, Sexo, EstadoCivil from ContactosMAVIJuanPicazo  
	where Nombre like @Nombre1

end

-- exec vtContacto ''