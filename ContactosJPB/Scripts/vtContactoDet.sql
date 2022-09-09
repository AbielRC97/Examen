use [ServicioAndroid]
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='p' AND s.name='vtContactoDet')
DROP PROCEDURE vtContactoDet
GO
CREATE PROCEDURE vtContactoDet
@Id int

WITH ENCRYPTION
AS
BEGIN

	Select IdContacto, Nombre, TipoContacto, TelFijo, TelMovil, FechaNacimiento, Sexo, EstadoCivil from ContactosMAVIJuanPicazo  
	where IdContacto = @Id

end

--exec vtContactoDet 2
