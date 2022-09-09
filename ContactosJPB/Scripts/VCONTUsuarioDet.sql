use IntelisisTmp
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='p' AND s.name='VCONTUsuarioDet')
DROP PROCEDURE VCONTUsuarioDet
GO
/*
=============================================================================--
NOMBRE         : VCONTUsuarioDet
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 08/09/2022
DESCRIPCION    : Consulta a detalle de Usuario y Contactos
DESARROLLO     : Ejercicios SQL
EJEMPLO        : exec VCONTUsuarioDet 1
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/
CREATE PROCEDURE VCONTUsuarioDet
@IdUsuario int

AS
BEGIN

	Select  u.IdUsuario, u.Nickname, Convert(varchar(10), u.FechaRegistro, 103) as FechaRegistro, u.Email, u.Estatus
		,c.IdContacto, c.NumeroTelefono
	from CONTCUsuariosJPB as u with (nolock)
	join CONTCContactoJPB as c with (nolock) on c.IdUsuario = u.IdUsuario
	where u.IdUsuario like @IdUsuario

end



