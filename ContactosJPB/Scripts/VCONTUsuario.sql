use IntelisisTmp
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='p' AND s.name='VCONTUsuario')
DROP PROCEDURE VCONTUsuario
GO
/*
=============================================================================--
NOMBRE         : VCONTUsuario
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 07/09/2022
DESCRIPCION    : Realiza Consulta de Usuario 
DESARROLLO     : Ejercicios SQL y Windows Forms
EJEMPLO        : exec VCONTUsuario 1
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/
CREATE PROCEDURE VCONTUsuario
@IdUsuario int

WITH ENCRYPTION
AS
BEGIN

	Select IdUsuario, Nickname, Convert(varchar(10), FechaRegistro, 103) as FechaRegistro, Email, convert(varchar(255), DECRYPTBYPASSPHRASE('GrupoMAVI', contrasena)) as Contrasena, Estatus 
	from CONTCUsuariosJPB  with (nolock)
	where IdUsuario like @IdUsuario

end
