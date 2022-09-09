use IntelisisTmp
/*
=============================================================================--
NOMBRE         : Script Crea tablas Contacto
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 08/09/2022
DESCRIPCION    : Agrega tablas de Contactos y Usuarios
DESARROLLO     : Ejercicios SQL y Windows Forms
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/

if OBJECT_ID('CONTCUsuariosJPB') is null
Begin
	CREATE Table CONTCUsuariosJPB (
		IdUsuario int not null identity,
		Nickname varchar(100) not null,
		FechaRegistro date not null,
		Email varchar(100) not null,
		Contrasena varbinary(255) ,
		Estatus bit not null default 1,

		Constraint PK_CONTCUsuariosJPB_IdUsuario Primary Key (IdUsuario),
		Constraint UQ_CONTCUsuariosJPB_Email UNIQUE (Email)
	 

	) 


End

if OBJECT_ID('CONTCContactoJPB') is null
Begin
	CREATE Table CONTCContactoJPB (
		IdContacto int not null identity,
		FechaRegistro date not null,
		NumeroTelefono varchar(10) not null,
		IdUsuario int not null ,

		Constraint PK_CONTCContactoJPB_IdContacto Primary Key (IdContacto),
		Constraint fK_CONTCContactoJPB_IdUsuario FOREIGN KEY (IdUsuario) References CONTCUsuariosJPB(IdUsuario) ,
			 

	) 


End
