use IntelisisTmp
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='p' AND s.name='SpCONTUsuarioDel')
DROP PROCEDURE SpCONTUsuarioDel
GO
/*
=============================================================================--
NOMBRE         : SpCONTUsuarioDel
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 08/09/2022
DESCRIPCION    : Elimina Usuario 
DESARROLLO     : Ejercicios SQL y Windows Forms
EJEMPLO        : exec SpCONTUsuarioDel 1
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/
CREATE PROCEDURE SpCONTUsuarioDel
@IdUsuario int

WITH ENCRYPTION
AS
BEGIN
 
 	begin TRY

		begin TRANSACTION
		
		delete from CONTCUsuariosJPB 
		where IdUsuario = @IdUsuario
			

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
