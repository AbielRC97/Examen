use IntelisisTmp
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='p' AND s.name='SpCONTUsuarioValida')
DROP PROCEDURE SpCONTUsuarioValida
GO
/*
=============================================================================--
NOMBRE         : SpCONTUsuarioValida
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 08/09/2022
DESCRIPCION    : Agrega Usuario Nuevo
DESARROLLO     : Ejercicios SQL y Windows Forms
EJEMPLO        : exec SpCONTUsuarioValida 'mariam@hotmail.com', '12345'
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/

CREATE PROCEDURE SpCONTUsuarioValida
@Email varchar(100),
@Contrasena varchar(20)

WITH ENCRYPTION
AS
BEGIN
Declare
@Fecha date = getdate(),
@Estatus bit = 1,
@PWD1 varchar(255)

	Select @PWD1 = convert(varchar(255), DECRYPTBYPASSPHRASE('GrupoMAVI', contrasena)) from CONTCUsuariosJPB where Email = @Email and Estatus = 1	
	
	if exists(Select * from CONTCUsuariosJPB where Email = @Email and  @PWD1 = @Contrasena and Estatus = 1)
	begin
		Select IdUsuario from CONTCUsuariosJPB where Email = @Email and Estatus = 1 
	end
	else
	begin
		Select '0' as IdUsuario
	end


end

