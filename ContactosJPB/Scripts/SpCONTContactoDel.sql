use IntelisisTmp
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='p' AND s.name='SpCONTContactoDel')
DROP PROCEDURE SpCONTContactoDel
GO
/*
=============================================================================--
NOMBRE         : SpCONTContactoDel
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 08/09/2022
DESCRIPCION    : Borra Contacto a Usuario
DESARROLLO     : Ejercicios SQL y Windows Forms
EJEMPLO        : exec SpCONTContactoDel '1234567890', 1
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/
CREATE PROCEDURE SpCONTContactoDel
@IdContacto int

WITH ENCRYPTION
AS
BEGIN
 
 	begin TRY

		begin TRANSACTION
		
		delete from CONTCContactoJPB 
		where IdContacto = @IdContacto
			

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
