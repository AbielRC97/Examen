use IntelisisTmp
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='p' AND s.name='SpCOMPEliminaSucursalJPB')
DROP PROCEDURE SpCOMPEliminaSucursalJPB
GO
/*
=============================================================================--
NOMBRE         : SpCOMPEliminaSucursalJPB
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 07/09/2022
DESCRIPCION    : Realiza la Eliminacion en la Sucursal
DESARROLLO     : Ejercicios SQL
EJEMPLO        : exec SpCOMPEliminaSucursalJPB 1
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/

CREATE PROCEDURE SpCOMPEliminaSucursalJPB
@Sucursal int

AS
BEGIN

 	begin TRY

		begin TRANSACTION
		
		delete from Sucursal where Sucursal = @Sucursal

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

