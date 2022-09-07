use IntelisisTmp
IF EXISTS(SELECT * FROM sysobjects AS s WHERE s.[type]='v' AND s.name='VCOMPSucursalesJPB')
DROP View VCOMPSucursalesJPB
GO
/*
=============================================================================--
NOMBRE         : VCOMPSucursalesJPB
AUTOR          : Juan Jesus Picazo Boijseauneau
FECHA CREACION : 07/09/2022
DESCRIPCION    : Realiza la Eliminacion en la Sucursal
DESARROLLO     : Ejercicios SQL
EJEMPLO        : Select * from VCOMPSucursalesJPB where Sucursal = 1
=============================================================================
FECHA Y AUTOR MODIFICACION:
*/

CREATE View VCOMPSucursalesJPB
AS

	Select Sucursal, Nombre, Prefijo, Relacion, Direccion, DireccionNumero, DireccionNumeroInt, Delegacion, GLN, Colonia, Poblacion, Estado, Pais, CodigoPostal, Telefonos, Fax, Estatus, RFC, RegistroPatronal, Encargado, Region, CentralRegional, EnLinea, SucursalPrincipal, ListaPreciosEsp, Cajeros, CentroCostos, OperacionContinua, ZonaEconomica, Grupo, AlmacenPrincipal, Servidor, BaseDatos, Usuario, ZonaImpuesto, CajaCentral, wMovVentas, wAlmacen, wAgente, wUsuario, wUEN, wConcepto, CRTipoCredito, Cliente, Categoria, Acreedor, LocalidadCNBV, Tipo, FechaApertura, VencimientoContrato, Metros, CostoBase, UltimaSincronizacion, IP, IPDinamica, IPPuerto, ComunicacionEncriptada, PropreEstatus, ProprePorcentajeNormal, PropreMarca, CFDFlex, noCertificado, Llave, ContrasenaSello, CertificadoBase64, RutaCertificado, LiberaAut, MapaLatitud, MapaLongitud, MapaPrecision, BloquearCobroTarjeta, FiscalRegimen, FiscalZona, ReferenciaIntelisisService, SucursalLDI, eCommerce, eCommerceOffLine, eCommerceSucursal, eCommerceImagenes, eCommerceAlmacen, eCommerceListaPrecios, eCommercePedido, eCommerceEstrategiaDescuento, eCommerceArticuloFlete, eCommerceTipoConsecutivo, eCommerceTipoConsecutivoFact, eCommerceCondicion, eCommerceCajero, eCommerceCteCat, eCommerceAgente, eCommerceSincroniza, eCommerceImpuestoIncluido, POSMensajeLimiteCaja, HOST, POSLimiteCaja, ParamAccDirIntelisisMES, eCommerceConsultaExistencias, eCommerceURL, eCommerceEnvolturaOmision, eCommerceCRModo, eCommerceCRArticulo, eCommerceCRArticuloAplica, eCommerceCRMinimo, eCommerceCRMaximo, eCommerceCRTipo, eCommerceCRConcepto, EnviaCorreo, Perfil, Remitente, BDMES, MapaUbicacion, PinPadUsuario, PinPadContrasena, PinPadMoneda, Directora, Supervisor, JefeSector, Sector, Zona, DifHorariaVerano, DifHorariaInvierno, Alta, UltimoCambio
	from Sucursal with(nolock)

go