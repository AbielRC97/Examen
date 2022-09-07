use IntelisisTmp
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='p' AND s.name='SpCOMPAgregaSucursalJPB')
DROP PROCEDURE SpCOMPAgregaSucursalJPB
GO
/*
=============================================================================--
NOMBRE         : SpCOMPAgregaSucursalJPB
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 07/09/2022
DESCRIPCION    : Realiza el Agregado de una Sucursal nueva
DESARROLLO     : Ejercicios SQL
EJEMPLO        : exec SpCOMPAgregaSucursalJPB 'Matriz', NULL, 'En Linea', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Mexico', 0, '1404-8080 / 01800-101-2272', NULL, 'Alta', NULL, NULL, NULL, NULL, 0, 1, 0, NULL, 0, NULL, 0, NULL, NULL, NULL, NULL, NULL, ADMIN_MAVI, NULL, NULL, 'Pedido', NULL, NULL, NULL, NULL, NULL, 'Tesoreria', NULL, NULL, NULL, NULL, NULL, Null, NULL, NULL, '(Costo Reposicion)', NULL, NULL, 0, NULL, 1, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, 1, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/

CREATE PROCEDURE SpCOMPAgregaSucursalJPB
@Nombre varchar(100),
@Prefijo char(5),
@Relacion varchar(20),
@Direccion varchar(100),
@DireccionNumero varchar(20),
@DireccionNumeroInt varchar(20),
@Delegacion varchar(100),
@GLN varchar(50),
@Colonia varchar(100),
@Poblacion varchar(30),
@Estado varchar(30),
@Pais varchar(100),
@CodigoPostal varchar(15),
@Telefonos varchar(100),
@Fax varchar(50),
@Estatus char(15),
@RFC varchar(20),
@RegistroPatronal varchar(50),
@Encargado varchar(100),
@Region varchar(50),
@CentralRegional bit,
@EnLinea bit,
@SucursalPrincipal int,
@ListaPreciosEsp varchar(20),
@Cajeros bit,
@CentroCostos varchar(20),
@OperacionContinua bit,
@ZonaEconomica varchar(30),
@Grupo varchar(50),
@AlmacenPrincipal char(10),
@Servidor varchar(50),
@BaseDatos varchar(50),
@Usuario varchar(10),
@ZonaImpuesto varchar(30),
@CajaCentral varchar(10),
@wMovVentas varchar(20),
@wAlmacen varchar(10),
@wAgente varchar(10),
@wUsuario varchar(10),
@wUEN int,
@wConcepto varchar(50),
@CRTipoCredito varchar(20),
@Cliente varchar(10),
@Categoria varchar(50),
@Acreedor varchar(10),
@LocalidadCNBV varchar(10),
@Tipo varchar(50),
@FechaApertura datetime,
@VencimientoContrato datetime,
@Metros float,
@CostoBase varchar(50),
@UltimaSincronizacion datetime,
@IP varchar(20),
@IPDinamica bit,
@IPPuerto int,
@ComunicacionEncriptada bit,
@PropreEstatus varchar(15),
@ProprePorcentajeNormal float,
@PropreMarca varchar(30),
@CFDFlex bit,
@noCertificado varchar(20),
@Llave varchar(255),
@ContrasenaSello varchar(100),
@CertificadoBase64 text,
@RutaCertificado varchar(255),
@LiberaAut bit,
@MapaLatitud float,
@MapaLongitud float,
@MapaPrecision int,
@BloquearCobroTarjeta bit,
@FiscalRegimen varchar(30),
@FiscalZona varchar(30),
@ReferenciaIntelisisService varchar(15),
@SucursalLDI varchar(20),
@eCommerce bit,
@eCommerceOffLine bit,
@eCommerceSucursal varchar(10),
@eCommerceImagenes varchar(50),
@eCommerceAlmacen varchar(10),
@eCommerceListaPrecios varchar(20),
@eCommercePedido varchar(20),
@eCommerceEstrategiaDescuento varchar(50),
@eCommerceArticuloFlete varchar(20),
@eCommerceTipoConsecutivo varchar(20),
@eCommerceTipoConsecutivoFact varchar(20),
@eCommerceCondicion varchar(50),
@eCommerceCajero varchar(10),
@eCommerceCteCat varchar(50),
@eCommerceAgente varchar(10),
@eCommerceSincroniza bit,
@eCommerceImpuestoIncluido bit,
@POSMensajeLimiteCaja bit,
@HOST varchar(20),
@POSLimiteCaja float,
@ParamAccDirIntelisisMES varchar(255),
@eCommerceConsultaExistencias bit,
@eCommerceURL varchar(100),
@eCommerceEnvolturaOmision int,
@eCommerceCRModo varchar(20),
@eCommerceCRArticulo varchar(20),
@eCommerceCRArticuloAplica varchar(20),
@eCommerceCRMinimo float,
@eCommerceCRMaximo float,
@eCommerceCRTipo varchar(50),
@eCommerceCRConcepto varchar(50),
@EnviaCorreo bit,
@Perfil varchar(20),
@Remitente varchar(255),
@BDMES varchar(50),
@MapaUbicacion varchar(100),
@PinPadUsuario varchar(50),
@PinPadContrasena varchar(50),
@PinPadMoneda varchar(50),
@Directora varchar(10),
@Supervisor varchar(100),
@JefeSector varchar(10),
@Sector varchar(10),
@Zona varchar(10),
@DifHorariaVerano float,
@DifHorariaInvierno float

AS
BEGIN
declare
@UltimoCambio datetime = getdate(),
@Alta datetime = getdate()

 	begin TRY

		begin TRANSACTION
		
		insert into Sucursal(Nombre, Prefijo, Relacion, Direccion, DireccionNumero, DireccionNumeroInt, Delegacion, GLN, Colonia, Poblacion, Estado, Pais, CodigoPostal, Telefonos, Fax, Estatus, RFC, RegistroPatronal, Encargado, Region, CentralRegional, EnLinea, SucursalPrincipal, ListaPreciosEsp, Cajeros, CentroCostos, OperacionContinua, ZonaEconomica, Grupo, AlmacenPrincipal, Servidor, BaseDatos, Usuario, ZonaImpuesto, CajaCentral, wMovVentas, wAlmacen, wAgente, wUsuario, wUEN, wConcepto, CRTipoCredito, Cliente, Categoria, Acreedor, LocalidadCNBV, Tipo, FechaApertura, VencimientoContrato, Metros, CostoBase, UltimaSincronizacion, IP, IPDinamica, IPPuerto, ComunicacionEncriptada, PropreEstatus, ProprePorcentajeNormal, PropreMarca, CFDFlex, noCertificado, Llave, ContrasenaSello, CertificadoBase64, RutaCertificado, LiberaAut, MapaLatitud, MapaLongitud, MapaPrecision, BloquearCobroTarjeta, FiscalRegimen, FiscalZona, ReferenciaIntelisisService, SucursalLDI, eCommerce, eCommerceOffLine, eCommerceSucursal, eCommerceImagenes, eCommerceAlmacen, eCommerceListaPrecios, eCommercePedido, eCommerceEstrategiaDescuento, eCommerceArticuloFlete, eCommerceTipoConsecutivo, eCommerceTipoConsecutivoFact, eCommerceCondicion, eCommerceCajero, eCommerceCteCat, eCommerceAgente, eCommerceSincroniza, eCommerceImpuestoIncluido, POSMensajeLimiteCaja, HOST, POSLimiteCaja, ParamAccDirIntelisisMES, eCommerceConsultaExistencias, eCommerceURL, eCommerceEnvolturaOmision, eCommerceCRModo, eCommerceCRArticulo, eCommerceCRArticuloAplica, eCommerceCRMinimo, eCommerceCRMaximo, eCommerceCRTipo, eCommerceCRConcepto, EnviaCorreo, Perfil, Remitente, BDMES, MapaUbicacion, PinPadUsuario, PinPadContrasena, PinPadMoneda, Directora, Supervisor, JefeSector, Sector, Zona, DifHorariaVerano, DifHorariaInvierno, Alta, UltimoCambio) Values
			(@Nombre, @Prefijo, @Relacion, @Direccion, @DireccionNumero, @DireccionNumeroInt, @Delegacion, @GLN, @Colonia, @Poblacion, @Estado, @Pais, @CodigoPostal, @Telefonos, @Fax, @Estatus, @RFC, @RegistroPatronal, @Encargado, @Region, @CentralRegional, @EnLinea, @SucursalPrincipal, @ListaPreciosEsp, @Cajeros, @CentroCostos, @OperacionContinua, @ZonaEconomica, @Grupo, @AlmacenPrincipal, @Servidor, @BaseDatos, @Usuario, @ZonaImpuesto, @CajaCentral, @wMovVentas, @wAlmacen, @wAgente, @wUsuario, @wUEN, @wConcepto, @CRTipoCredito, @Cliente, @Categoria, @Acreedor, @LocalidadCNBV, @Tipo, @FechaApertura, @VencimientoContrato, @Metros, @CostoBase, @UltimaSincronizacion, @IP, @IPDinamica, @IPPuerto, @ComunicacionEncriptada, @PropreEstatus, @ProprePorcentajeNormal, @PropreMarca, @CFDFlex, @noCertificado, @Llave, @ContrasenaSello, @CertificadoBase64, @RutaCertificado, @LiberaAut, @MapaLatitud, @MapaLongitud, @MapaPrecision, @BloquearCobroTarjeta, @FiscalRegimen, @FiscalZona, @ReferenciaIntelisisService, @SucursalLDI, @eCommerce, @eCommerceOffLine, @eCommerceSucursal, @eCommerceImagenes, @eCommerceAlmacen, @eCommerceListaPrecios, @eCommercePedido, @eCommerceEstrategiaDescuento, @eCommerceArticuloFlete, @eCommerceTipoConsecutivo, @eCommerceTipoConsecutivoFact, @eCommerceCondicion, @eCommerceCajero, @eCommerceCteCat, @eCommerceAgente, @eCommerceSincroniza, @eCommerceImpuestoIncluido, @POSMensajeLimiteCaja, @HOST, @POSLimiteCaja, @ParamAccDirIntelisisMES, @eCommerceConsultaExistencias, @eCommerceURL, @eCommerceEnvolturaOmision, @eCommerceCRModo, @eCommerceCRArticulo, @eCommerceCRArticuloAplica, @eCommerceCRMinimo, @eCommerceCRMaximo, @eCommerceCRTipo, @eCommerceCRConcepto, @EnviaCorreo, @Perfil, @Remitente, @BDMES, @MapaUbicacion, @PinPadUsuario, @PinPadContrasena, @PinPadMoneda, @Directora, @Supervisor, @JefeSector, @Sector, @Zona, @DifHorariaVerano, @DifHorariaInvierno, @Alta, @UltimoCambio)

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

