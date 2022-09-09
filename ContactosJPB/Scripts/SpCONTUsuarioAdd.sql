use IntelisisTmp
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='p' AND s.name='SpCONTUsuarioAdd')
DROP PROCEDURE SpCONTUsuarioAdd
GO
/*
=============================================================================--
NOMBRE         : SpCONTUsuarioAdd
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 08/09/2022
DESCRIPCION    : Agrega Usuario Nuevo
DESARROLLO     : Ejercicios SQL y Windows Forms
EJEMPLO        : exec SpCONTUsuarioAdd 'Juan Jesus Picazo', 'johnnyjpb@hotmail.com', 'visual'
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/

CREATE PROCEDURE SpCONTUsuarioAdd
@Nickname varchar(100),
@Email varchar(100),
@Contrasena varchar(20)

AS
BEGIN
Declare
@Fecha date = getdate(),
@Estatus bit = 1

 
 	begin TRY

		begin TRANSACTION
		
		insert into CONTCUsuariosJPB (Nickname, FechaRegistro, Email, Contrasena, Estatus) Values
			(@Nickname, @Fecha, @Email, ENCRYPTBYPASSPHRASE('GrupoMAVI', @Contrasena ), @Estatus)

		COMMIT TRAN
	end TRY

	begin CATCH
		if @@TRANCOUNT <> 0
		begin
			rollback tran

			return
		end
	end CATCH

	select IdUsuario as Id from CONTCUsuariosJPB where Nickname = @Nickname and Email = @Email

end
