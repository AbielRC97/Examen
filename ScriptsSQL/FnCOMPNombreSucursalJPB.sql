use IntelisisTmp
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='fn' AND s.name='FnCOMPNombreSucursalJPB')
DROP FUNCTION FnCOMPNombreSucursalJPB
GO
/*
=============================================================================--
NOMBRE         : FnCOMPNombreSucursalJPB
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 07/09/2022
DESCRIPCION    : Realiza el Agregado de una Sucursal nueva
DESARROLLO     : Ejercicios SQL
EJEMPLO        : select @Nombre = dbo.FnCOMPNombreSucursalJPB(1)
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/

CREATE FUNCTION FnCOMPNombreSucursalJPB(
@Sucursal Int
)
returns varchar(100)
 
AS
BEGIN
declare
@Nombre varchar(100) = ''

	select @Nombre = Nombre from Sucursal where Sucursal = @Sucursal
	
	return @Nombre

end
go 
