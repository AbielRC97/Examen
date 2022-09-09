use IntelisisTmp
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='p' AND s.name='SpCONTContactoAdd')
DROP PROCEDURE SpCONTContactoAdd
GO
/*
=============================================================================--
NOMBRE         : SpCONTContactoAdd
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 08/09/2022
DESCRIPCION    : Agrega Contacto nuevo a Usuario
DESARROLLO     : Ejercicios SQL y Windows Forms
EJEMPLO        : exec SpCONTContactoAdd '1234567890', 1
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/

CREATE PROCEDURE SpCONTContactoAdd
@NumeroTelefono varchar(10),
@IdUsuario int

WITH ENCRYPTION
AS
BEGIN
Declare
@Fecha date = getdate()
 
 	begin TRY

		begin TRANSACTION
		
		insert into CONTCContactoJPB (NumeroTelefono, FechaRegistro, IdUsuario) Values
			(@NumeroTelefono, @Fecha, @IdUsuario)

		COMMIT TRAN
	end TRY

	begin CATCH
		if @@TRANCOUNT <> 0
		begin
			rollback tran

			return
		end
	end CATCH
	select IdContacto from CONTCContactoJPB where IdUsuario = @IdUsuario and FechaRegistro = @Fecha and NumeroTelefono = @NumeroTelefono
end
