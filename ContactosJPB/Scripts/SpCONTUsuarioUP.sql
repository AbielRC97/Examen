use IntelisisTmp
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='p' AND s.name='SpCONTUsuarioUP')
DROP PROCEDURE SpCONTUsuarioUP
GO
/*
=============================================================================--
NOMBRE         : SpCONTUsuarioUP
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 08/09/2022
DESCRIPCION    : Modifica Usuario
DESARROLLO     : Ejercicios SQL y Windows Forms
EJEMPLO        : exec SpCONTUsuarioUP 3, 'Maria Felix', 'mariam@hotmail.com', '12345', 1
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/
CREATE PROCEDURE SpCONTUsuarioUP
@IdUsuario int,
@Nickname varchar(100),
@Email varchar(100),
@Contrasena varchar(20),
@Estatus bit

WITH ENCRYPTION
AS
BEGIN
declare
@pwd varchar(255)
 
	--select 
 	begin TRY

		begin TRANSACTION
		
		Update CONTCUsuariosJPB set Nickname = @Nickname, Contrasena = ENCRYPTBYPASSPHRASE( 'GrupoMAVI', @Contrasena ), Estatus = @Estatus
		where IdUsuario = @IdUsuario and Email = @Email
			

		COMMIT TRAN
	end TRY

	begin CATCH
		if @@TRANCOUNT <> 0
		begin
			rollback tran

			return
		end
	end CATCH

end
