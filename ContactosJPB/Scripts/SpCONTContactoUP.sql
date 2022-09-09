use IntelisisTmp
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='p' AND s.name='SpCONTContactoUP')
DROP PROCEDURE SpCONTContactoUP
GO
/*
=============================================================================--
NOMBRE         : SpCONTContactoUP
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 08/09/2022
DESCRIPCION    : Modifica Contacto a Usuario
DESARROLLO     : Ejercicios SQL y Windows Forms
EJEMPLO        : exec SpCONTContactoUP '1234567890', 1
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/

CREATE PROCEDURE SpCONTContactoUP
@IdContacto int,
@NumeroTelefono varchar(10)

WITH ENCRYPTION
AS
BEGIN
Declare
@Fecha date = getdate()
 
 	begin TRY

		begin TRANSACTION
		
		Update CONTCContactoJPB set NumeroTelefono = @NumeroTelefono, FechaRegistro = @Fecha
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
	select 'CORRECTO' as Usuario
end
