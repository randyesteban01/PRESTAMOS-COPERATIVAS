-- Autor: Enrique José Escobar Maradiaga
-- Fecha: 19/02/2023
-- Descripcion: Script para unificar estructura de base de datos

ALTER TABLE cb_tbl_maestro_concepto CHANGE fld_cod_mc fld_id_doc int(11);
ALTER TABLE cb_tbl_maestro_concepto CHANGE fld_descripcion_mc fld_cod_concepto longblob;

ALTER TABLE solicitudcredito MODIFY Clasificacion VARCHAR(75);
ALTER TABLE solicitudcredito MODIFY Condicion VARCHAR(75);
ALTER TABLE solicitudcredito MODIFY CantCuotas smallint(11);

ALTER TABLE solicitudcredito ADD COLUMN cedula VARCHAR(14) NULL;
ALTER TABLE solicitudcredito ADD COLUMN direccion  VARCHAR(255)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN provincia  VARCHAR(20)   NULL;
ALTER TABLE solicitudcredito ADD COLUMN municipio  VARCHAR(20)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN barrio  VARCHAR(20)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN phone  VARCHAR(13)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN phone2  VARCHAR(13)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN casa_propia  char(2)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN tiempo_casa  smallint(6)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN casa_alquiler  char(2)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN tiempo_alquiler  smallint(6)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN correo  VARCHAR(255)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN empresa  VARCHAR(50)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN phone3  VARCHAR(13)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN empresa_agno  smallint(6)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN empresa_meses  smallint(6)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN nomconyugue  VARCHAR(50)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN phone4  VARCHAR(13)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN nomflia  VARCHAR(50)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN phone5  VARCHAR(13)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN codeudor  VARCHAR(50)   NULL; 
ALTER TABLE solicitudcredito ADD COLUMN phone6  VARCHAR(13)   NULL;

ALTER TABLE solicitudcreditonota ADD COLUMN comentario_Officer_negocio  VARCHAR(255)   NULL;
ALTER TABLE solicitudcreditonota ADD COLUMN comentario_enc_negocio  VARCHAR(255)   NULL;
ALTER TABLE solicitudcreditonota ADD COLUMN comentario_analista_de_credito  VARCHAR(255)   NULL;

ALTER TABLE tbl_ahorros_categorias CHANGE TasaCuentas tasaCuenta decimal(10, 2);

ALTER TABLE tbl_catalogo ADD COLUMN Nivel  int(11) NOT NULL default 1 ;
UPDATE tbl_catalogo SET ID=279 WHERE CuentaNo='103-00-01-03';
UPDATE tbl_catalogo SET ID=280 WHERE CuentaNo='400-99';
UPDATE tbl_catalogo SET ID=281 WHERE CuentaNo='601-15';
UPDATE tbl_catalogo SET ID=282 WHERE CuentaNo='601-16';
UPDATE tbl_catalogo SET ID=283 WHERE CuentaNo='601-17';
UPDATE tbl_catalogo SET ID=284 WHERE CuentaNo='103-00-01-04';
UPDATE tbl_catalogo SET ID=285 WHERE CuentaNo='101-00-01-99';
UPDATE tbl_catalogo SET ID=286 WHERE CuentaNo='200-03-09';
UPDATE tbl_catalogo SET ID=287 WHERE CuentaNo='200-02-06';
UPDATE tbl_catalogo SET ID=288 WHERE CuentaNo='200-02-07';
UPDATE tbl_catalogo SET ID=289 WHERE CuentaNo='605-03';
UPDATE tbl_catalogo SET ID=290 WHERE CuentaNo='11-01-02-07';
UPDATE tbl_catalogo SET ID=291 WHERE CuentaNo='201-02-99';
UPDATE tbl_catalogo SET ID=292 WHERE CuentaNo='100-04-04';
UPDATE tbl_catalogo SET ID=293 WHERE CuentaNo='601-24';
UPDATE tbl_catalogo SET ID=294 WHERE CuentaNo='101-00-01-08';

ALTER TABLE tbl_clientes MODIFY fld_Identity VARCHAR(16);
ALTER TABLE tbl_clientes MODIFY fld_cedula_con VARCHAR(16) default '000-0000000-0';
ALTER TABLE tbl_clientes MODIFY fld_cedula_gar VARCHAR(16) default '0';
ALTER TABLE tbl_clientes MODIFY fld_cedula_con_gar VARCHAR(16) default '0';
ALTER TABLE tbl_clientes MODIFY fld_edad_gar int(50) default '0';
UPDATE tbl_clientes SET agno_labor_gar=0 WHERE agno_labor_gar='';
ALTER TABLE tbl_clientes MODIFY agno_labor_gar int(50) default '0';
ALTER TABLE tbl_clientes MODIFY fld_ced_ref_personal_clie1 VARCHAR(16);
ALTER TABLE tbl_clientes MODIFY fld_ced_ref_personal_clie2 VARCHAR(16);
ALTER TABLE tbl_clientes MODIFY fld_cedula_ref_gar1 VARCHAR(16);
ALTER TABLE tbl_clientes MODIFY fld_cedula_ref_gar2 VARCHAR(16);
ALTER TABLE tbl_clientes MODIFY fld_nom_ref_flia_clie1 VARCHAR(50);
ALTER TABLE tbl_clientes MODIFY fld_ced_ref_flia_clie1 VARCHAR(16);
ALTER TABLE tbl_clientes MODIFY fld_ced_ref_flia_clie2 VARCHAR(16);

ALTER TABLE tbl_clientes ADD COLUMN fld_provincia_id  int(11)   NULL default 0;
UPDATE tbl_clientes SET fld_provincia_id=0;

ALTER TABLE tbl_clientes ADD COLUMN fld_provincia  varchar(255)   NULL default 'N/A';
UPDATE tbl_clientes SET fld_provincia='N/A';

ALTER TABLE tlb_segundo_titular_cta_ahorros ADD COLUMN fldIdAhorro  int(11) NULL AFTER fldCod2doTitular;
ALTER TABLE tlb_segundo_titular_cta_ahorros ADD COLUMN fldNotas2doTitular  varchar(255) NULL;

ALTER TABLE parametrosgenerales ADD COLUMN VersionPublicacionSistema  varchar(100)   NULL default '01.00.00.000';
UPDATE parametrosgenerales SET VersionPublicacionSistema='01.00.00.001';


DROP 
  PROCEDURE IF EXISTS CargarDepositosLibreta;
CREATE  PROCEDURE CargarDepositosLibreta(
  in _CodSocio INT, 
  in _NroCuenta VARCHAR(15), 
  in _fecha DATE
) BEGIN 
SELECT 
  d.fecha, 
  d.monto AS Deposito, 
  a.saldointeres AS Intereses, 
  a.saldocapital AS Balance, 
  d.Usuario AS Cajero 
FROM 
  tbl_ahorros_depositos AS d 
  INNER JOIN tbl_ahorros_cuentas AS a ON d.idcliente = a.idcliente 
WHERE 
  d.idcliente = _CodSocio 
  AND a.CuentaNo = _NroCuenta 
  AND d.fecha = _Fecha;
END;


DROP 
  PROCEDURE IF EXISTS Imprimir_Libretas;
CREATE PROCEDURE Imprimir_Libretas(
  in _FechaImpresion date, 
  in _HoraImpresion time, 
  in _IdSocio int, 
  in _NroLibreta int, 
  in _NroCuenta varchar(7), 
  in _Retiro double(14, 4), 
  in _Deposito double(14, 4), 
  in _Balance double(14, 4), 
  in _InteresesAcomulados double(14, 4), 
  in _IdCaja int, 
  in _IdCajero int
) Begin insert into Impresion_Libreta (
  FechaImpresion, HoraImpresion, IdSocio, 
  NroLibreta, NroCuenta, Retiro, Deposito, 
  Balance, InteresesAcomulados, IdCaja, 
  IdCajero
) 
values 
  (
    _FechaImpresion, _HoraImpresion, 
    _IdSocio, _NroLibreta, _NroCuenta, 
    _Retiro, _Deposito, _Balance, _InteresesAcomulados, 
    _IdCaja, _IdCajero
  );
end;


DROP 
  PROCEDURE IF EXISTS solicitudcreditogastos_flia;
CREATE PROCEDURE solicitudcreditogastos_flia(
  in _fld_id_sol int, 
  in _fld_vivienda double(10, 2), 
  in _fld_alimentacion double(10, 2), 
  in _fld_transporte double(10, 2), 
  in _fld_educacion double(10, 2), 
  in _fld_otros double(10, 2), 
  _fld_total_gastos double(10, 2)
) begin insert into tbl_solicitudcreditogastos_flia(
  fldid, fld_id_sol, fld_vivienda, fld_alimentacion, 
  fld_transporte, fld_educacion, fld_otros, 
  fld_total_gastos
) 
values 
  (
    null, _fld_id_sol, _fld_vivienda, 
    _fld_alimentacion, _fld_transporte, 
    _fld_educacion, _fld_otros, _fld_total_gastos
  );
end;

DROP 
  PROCEDURE IF EXISTS spActualizarSegundoTitular;
CREATE PROCEDURE spActualizarSegundoTitular(
  IN _fldCodSocio INT, 
  IN _fldNombre2doTitular VARCHAR(100), 
  IN _fldCedula2doTitular VARCHAR(16), 
  IN _fldTelefono2doTitular VARCHAR(14), 
  IN _fldCelular2doTitular VARCHAR(14), 
  IN _fldWhatsaap2doTitular VARCHAR(14), 
  IN _fldNotas2doTitular VARCHAR(255)
) BEGIN 
update 
  tlb_segundo_titular_cta_ahorros 
set 
  fldCodSocio = _fldCodSocio, 
  fldNombre2doTitular = _fldNombre2doTitular, 
  fldCedula2doTitular = _fldCedula2doTitular, 
  fldTelefono2doTitular = _fldTelefono2doTitular, 
  fldCelular2doTitular = _fldCelular2doTitular, 
  fldWhatsapp2doTitular = _fldWhatsaap2doTitular, 
  fldNotas2doTitular = _fldNotas2doTitular 
where 
  fldCodSocio = _fldCodSocio;
END;

DROP 
  PROCEDURE IF EXISTS spInSertarBeneficiarios;
CREATE PROCEDURE spInSertarBeneficiarios(
  in _CodCliente int, 
  in _NombreBeneficiario varchar(100), 
  in _ParentescoBeneficiario varchar(50), 
  in _CedulaBeneficiario varchar(16), 
  in _TelBeneficiario varchar(13), 
  in _CelularBeneficiario varchar(13), 
  in _WhatsappBeneficiario varchar(13), 
  IN _NombreBeneficiario2 VARCHAR(100), 
  IN _ParentescoBeneficiario2 VARCHAR(50), 
  IN _CedulaBeneficiario2 VARCHAR(16), 
  IN _TelBeneficiario2 VARCHAR(13), 
  IN _CelularBeneficiario2 VARCHAR(13), 
  IN _WhatsappBeneficiario2 VARCHAR(13)
) Begin insert into tbl_beneficiarios_Aportes(
  CodCliente, NombreBeneficiario, ParentescoBeneficiario, 
  CedulaBeneficiario, TelBeneficiario, 
  CelularBeneficiario, WhatsappBeneficiario, 
  NombreBeneficiario2, ParentescoBeneficiario2, 
  CedulaBeneficiario2, TelBeneficiario2, 
  CelularBeneficiario2, WhatsappBeneficiario2
) 
values 
  (
    _CodCliente, _NombreBeneficiario, 
    _ParentescoBeneficiario, _CedulaBeneficiario, 
    _TelBeneficiario, _CelularBeneficiario, 
    _WhatsappBeneficiario, _NombreBeneficiario2, 
    _ParentescoBeneficiario2, _CedulaBeneficiario2, 
    _TelBeneficiario2, _CelularBeneficiario2, 
    _WhatsappBeneficiario2
  );
end;


DROP 
  PROCEDURE IF EXISTS spInsertarMnuArchivo;
CREATE PROCEDURE spInsertarMnuArchivo(
  in _IDUsuario integer, 
  IN _mnuPermisosUsuarios varchar(5), 
  in _mnuArchivo varchar(5), 
  in mnuCambiarMiClave varchar(5), 
  in mnuCambiarUsuario varchar(5), 
  in mnuFormatoCheque varchar(5), 
  in mnuTimbrado varchar(5)
) BEGIN insert into tbl_userarchivo (
  ID, IDUsuario, mnuPermisosUsuarios, 
  mnuArchivo, mnuCambiarMiClave, mnuCambiarUsuario, 
  mnuFormatoCheque, mnuTimbrado
) 
values 
  (
    null, _IDUsuario, _mnuPermisosUsuarios, 
    _mnuArchivo, mnuCambiarMiClave, 
    mnuCambiarUsuario, mnuFormatoCheque, 
    mnuTimbrado
  );
END;

DROP 
  PROCEDURE IF EXISTS spInsertarMnuBanco;
CREATE PROCEDURE spInsertarMnuBanco(
  in _Idusuario Int, 
  in _mnuBanco varchar(5), 
  in _mnuMaestroBanco varchar(5), 
  in _mnuDiarioBanco varchar(5), 
  in _mnuDiarioBancoSolicitud varchar(5), 
  in _mnuDiarioBancoCheque varchar(5), 
  in _mnuDiarioBancoDeposito varchar(5), 
  in _mnuDiarioBancoND varchar(5), 
  in _mnuDiarioBancoNC varchar(5), 
  in _mnuDiarioBancoCargosComisiones varchar(5), 
  in _mnuDiarioBancoConciliacion varchar(5), 
  in _repEstadoBanco varchar(5), 
  in _repDepositos varchar(5), 
  in _repCheques varchar(5), 
  in _repNCBanco varchar(5), 
  in _repNDBanco varchar(5)
) BEGIN insert into tbl_userbanco(
  ID, IDUsuario, mnuBanco, mnuMaestroBanco, 
  mnuDiarioBanco, mnuDiarioBancoSolicitud, 
  mnuDiarioBancoCheque, mnuDiarioBancoDeposito, 
  mnuDiarioBancoND, mnuDiarioBancoNC, 
  mnuDiarioBancoCargosComisiones, 
  mnuConciliacion, repEstadoBanco, 
  repDepositos, repCheques, repNCBanco, 
  repNDBanco
) 
values 
  (
    null, _Idusuario, _mnuBanco, _mnuMaestroBanco, 
    _mnuDiarioBanco, _mnuDiarioBancoSolicitud, 
    _mnuDiarioBancoCheque, _mnuDiarioBancoCheque, 
    _mnuDiarioBancoDeposito, _mnuDiarioBancoND, 
    _mnuDiarioBancoNC, _mnuDiarioBancoCargosComisiones, 
    _mnuDiarioBancoConciliacion, _repEstadoBanco, 
    _repDepositos, _repCheques, _repNCBanco
  );
END;

DROP 
  PROCEDURE IF EXISTS spInsertarMnuMantenimiento;
CREATE PROCEDURE spInsertarMnuMantenimiento(
  IN _IDUsuario INTEGER, 
  IN _mnuManteniemiento VARCHAR(5), 
  IN _mnuCliente VARCHAR(5), 
  IN _mnuInmuebles VARCHAR(5), 
  IN _mnuUsuarioNuevo VARCHAR(5), 
  IN _mnuCobradores VARCHAR(5), 
  IN _mnuZonas VARCHAR(5), 
  in _mnuUrbanizaciones varchar(5), 
  in _mnuCiudad varchar(5), 
  in _mnuProvincia varchar(5), 
  in _mnuTipoDocIdentidad varchar(5), 
  in _mnuPrefCuentaAhorro varchar(5), 
  in _mnuCatAhorro varchar(5)
) BEGIN INSERT INTO tbl_usermantenimiento (
  ID, IDUsuario, mnuMantenimiento, mnuCliente, 
  mnuInmuebles, mnuUsuarioNuevo, mnuCobradores, 
  mnuZonas, mnuUrbanizaciones, mnuCiudad, 
  mnuProvincias, mnuTipoDocIdentidad, 
  mnuPrefCuentaAhorro, mnuCatAhorro
) 
VALUES 
  (
    NULL, _IDUsuario, _mnuManteniemiento, 
    _mnuCliente, _mnuInmuebles, _mnuUsuarioNuevo, 
    _mnuCobradores, _mnuZonas, _mnuUrbanizaciones, 
    _mnuCiudad, _mnuProvincia, _mnuTipoDocIdentidad, 
    _mnuPrefCuentaAhorro, _mnuCatAhorro
  );
END;


DROP 
  PROCEDURE IF EXISTS spInsertarSegundoTitular;
CREATE  PROCEDURE spInsertarSegundoTitular(
  in _fldCodSocio int, 
  in _fldNombre2doTitular varchar(100), 
  in _fldCedula2doTitular varchar(16), 
  in _fldTelefono2doTitular varchar(14), 
  in _fldCelular2doTitular varchar(14), 
  in _fldWhatsaap2doTitular varchar(14), 
  in _fldNotas2doTitular varchar(255)
) BEGIN insert into tlb_segundo_titular_cta_ahorros(
  fldCodSocio, fldNombre2doTitular, 
  fldCedula2doTitular, fldTelefono2doTitular, 
  fldCelular2doTitular, fldWhatsapp2doTitular, 
  fldNotas2doTitular
) 
values 
  (
    _fldCodSocio, _fldNombre2doTitular, 
    _fldCedula2doTitular, _fldTelefono2doTitular, 
    _fldCelular2doTitular, _fldWhatsaap2doTitular, 
    _fldNotas2doTitular
  );
END;

DROP 
  PROCEDURE IF EXISTS sp_Actualiar_socios;
CREATE PROCEDURE sp_Actualiar_socios(
  in _fld_ID int, 
  IN _fld_FullName VARCHAR(255), 
  IN _fld_apodo VARCHAR(55), 
  IN _TipoDocumento INT, 
  IN _fld_Identity VARCHAR(16), 
  IN _fld_Phone VARCHAR(255), 
  IN _fld_Phone2 VARCHAR(255), 
  IN _fld_Address VARCHAR(255), 
  IN _fld_City VARCHAR(55), 
  IN _fld_Status VARCHAR(6), 
  IN _fld_bce DOUBLE(11, 2), 
  IN _fld_cod_zona INT, 
  IN _fld_zona VARCHAR(255), 
  IN _fld_nombre_con VARCHAR(55), 
  IN _fld_apodo_con VARCHAR(55), 
  IN _fld_cedula_con VARCHAR(16), 
  IN _fld_telefono_con VARCHAR(14), 
  IN _fld_celular_con VARCHAR(13), 
  IN _fld_ref_personales_cliente VARCHAR(50), 
  IN _fld_ref_comerciales_cliente VARCHAR(50), 
  IN _fld_nombre_gar VARCHAR(55), 
  IN _fld_apodo_gar VARCHAR(50), 
  IN _fld_cedula_gar VARCHAR(16), 
  IN _fld_telefono_gar VARCHAR(13), 
  IN _fld_celular_gar VARCHAR(13), 
  IN _fld_direccion_gar VARCHAR(255), 
  _fld_ciudad_gar VARCHAR(55), 
  IN _fld_ref_personales_gar VARCHAR(50), 
  IN _fld_ref_comerciales_gar VARCHAR(50), 
  IN _fld_ingresos_mesuales double(12, 2), 
  IN _fld_nombre_banco1 VARCHAR(1000), 
  IN _fld_cuenta_banco1 VARCHAR(15), 
  IN _fld_nombre_banco2 VARCHAR(1000), 
  IN _fld_cuenta_banco2 VARCHAR(15), 
  IN _fld_otra_informacion VARCHAR(1000), 
  IN _fld_nombre_con_gar VARCHAR(55), 
  IN _fld_apodo_con_gar VARCHAR(55), 
  IN _fld_cedula_con_gar VARCHAR(16), 
  IN _fld_telefono_con_gar VARCHAR(13), 
  IN _fld_celular_con_gar VARCHAR(13), 
  IN _fld_edad DATE, 
  IN _fld_estado_civil VARCHAR(15), 
  IN _fld_edad_gar VARCHAR(50), 
  IN _fld_estado_civil_gar VARCHAR(15), 
  IN _fld_ocupacion_cliente VARCHAR(55), 
  IN _fld_ocupacion_gar VARCHAR(55), 
  IN _fld_categoria VARCHAR(25), 
  IN _Puesto VARCHAR(100), 
  IN _ReferidoPor VARCHAR(100), 
  IN _Oriundo VARCHAR(100), 
  IN _ctaContable CHAR(200), 
  IN _email VARCHAR(255), 
  IN _fechaIngreso DATE, 
  IN _whatsapp VARCHAR(13), 
  IN _whatsapp_con VARCHAR(13), 
  IN _parentezco_gar VARCHAR(20), 
  IN _fecha_nac_gar DATE, 
  IN _whatsapp_gar VARCHAR(13), 
  IN _email_gar VARCHAR(255), 
  IN _empresa_gar VARCHAR(50), 
  IN _telefono_empresa_gar VARCHAR(13), 
  IN _agno_labor_gar VARCHAR(50), 
  IN _salario_gar DOUBLE(10, 2), 
  IN _whatsapp_con_gar VARCHAR(13), 
  IN _fld_ref_parentesco_clie1 VARCHAR(20), 
  IN _fld_ced_ref_personal_clie1 VARCHAR(16), 
  IN _fld_tel_ref_personal_clie1 VARCHAR(13), 
  IN _fld_cel_ref_personal_clie1 VARCHAR(13), 
  IN _fld_whatsapp_ref_personal_clie1 VARCHAR(13), 
  IN _fld_ref_personal_clie2 VARCHAR(50), 
  IN _fld_ref_parentesco_clie2 VARCHAR(20), 
  IN _fld_ced_ref_personal_clie2 VARCHAR(16), 
  IN _fld_tel_ref_personal_clie2 VARCHAR(13), 
  IN _fld_cel_ref_personal_clie2 VARCHAR(13), 
  IN _fld_whatsapp_ref_personal_clie2 VARCHAR(13), 
  IN _Fld_Dir_Ref_Com_Clie1 VARCHAR(255), 
  IN _Fld_Rnc_Refe_Com_Clie1 VARCHAR(9), 
  IN _Fld_Tel_Com_clie1 VARCHAR(13), 
  IN _Fld_Whatsapp_Com_Clie1 VARCHAR(13), 
  IN _fld_ref_comerciales_cliente2 VARCHAR(50), 
  IN _Fld_Dir_Ref_Com_Clie2 VARCHAR(255), 
  IN _Fld_Rnc_Refe_Com_Clie2 VARCHAR(9), 
  IN _Fld_Tel_Com_clie2 VARCHAR(13), 
  IN _Fld_Whatsapp_Com_Clie2 VARCHAR(13), 
  IN _fld_parentesco_ref_gar1 VARCHAR(50), 
  IN _fld_cedula_ref_gar1 VARCHAR(16), 
  IN _fld_tel_ref_gar1 VARCHAR(13), 
  IN _fld_cel_ref_gar1 VARCHAR(13), 
  IN _fld_whatsapp_ref_gar1 VARCHAR(13), 
  IN _fld_ref_personal_gar2 VARCHAR(50), 
  IN _fld_parentesco_ref_gar2 VARCHAR(20), 
  IN _fld_cedula_ref_gar2 VARCHAR(16), 
  IN _fld_tel_ref_gar2 VARCHAR(13), 
  IN _fld_cel_ref_gar2 VARCHAR(13), 
  IN _fld_whatsapp_ref_gar2 VARCHAR(13), 
  IN _Fdl_Dir_Emp_Gar1 VARCHAR(255), 
  IN _Fld_Rnc_Emp_Gar1 VARCHAR(11), 
  IN _Fld_Tel_Emp_Gar1 VARCHAR(13), 
  IN _Fld_Whatsapp_emp_Gar1 VARCHAR(13), 
  IN _Fld_Empra_Gar2 VARCHAR(50), 
  IN _Fld_Dir_Emp_Gar2 VARCHAR(255), 
  IN _Fld_Rnc_Emp_Gar2 VARCHAR(11), 
  IN _Fld_Tel_Emp_Gar2 VARCHAR(13), 
  IN _Fld_Whatsapp_Emp_Gar2 VARCHAR(13), 
  IN _fld_nom_ref_flia_clie1 VARCHAR(50), 
  IN _fld_parentesco_ref_flia_clie1 VARCHAR(20), 
  IN _fld_ced_ref_flia_clie1 VARCHAR(16), 
  IN _fld_tel_ref_flia_clie1 VARCHAR(13), 
  IN _fld_cel_ref_flia_clie1 VARCHAR(13), 
  IN _fld_whatsapp_ref_flia_clie1 VARCHAR(13), 
  IN _fld_nom_ref_flia_clie2 VARCHAR(50), 
  IN _fld_parentesco_ref_flia_clie2 VARCHAR(20), 
  IN _fld_ced_ref_flia_clie2 VARCHAR(16), 
  IN _fld_tel_ref_flia_clie2 VARCHAR(13), 
  IN _fld_cel_ref_flia_clie2 VARCHAR(13), 
  IN _fld_whats_ref_flia_clie2 VARCHAR(13), 
  IN _fld_sector_id int, 
  IN _fld_sector varchar(255), 
  IN _fld_provincia_id int, 
  IN _fld_provincia varchar(255)
) BEGIN 
UPDATE 
  tbl_clientes 
SET 
  fld_FullName = _fld_FullName, 
  fld_apodo = _fld_apodo, 
  TipoDocumento = _TipoDocumento, 
  fld_Identity = _fld_Identity, 
  fld_Phone = _fld_Phone, 
  fld_Phone2 = _fld_Phone2, 
  fld_Address = _fld_Address, 
  fld_City = _fld_City, 
  fld_Status = _fld_Status, 
  fld_bce = _fld_bce, 
  fld_cod_zona = _fld_cod_zona, 
  fld_zona = _fld_zona, 
  fld_nombre_con = _fld_nombre_con, 
  fld_apodo_con = _fld_apodo_con, 
  fld_cedula_con = _fld_cedula_con, 
  fld_telefono_con = _fld_telefono_con, 
  fld_celular_con = _fld_celular_con, 
  fld_ref_personales_cliente = _fld_ref_personales_cliente, 
  fld_ref_comerciales_cliente = _fld_ref_comerciales_cliente, 
  fld_nombre_gar = _fld_nombre_gar, 
  fld_apodo_gar = _fld_apodo_gar, 
  fld_cedula_gar = _fld_cedula_gar, 
  fld_telefono_gar = _fld_telefono_gar, 
  fld_celular_gar = _fld_celular_gar, 
  fld_direccion_gar = _fld_direccion_gar, 
  fld_ciudad_gar = _fld_ciudad_gar, 
  fld_ref_personales_gar = _fld_ref_personales_gar, 
  fld_ref_comerciales_gar = _fld_ref_comerciales_gar, 
  fld_ingresos_mesuales = _fld_ingresos_mesuales, 
  fld_nombre_banco1 = _fld_nombre_banco1, 
  fld_cuenta_banco1 = _fld_cuenta_banco1, 
  fld_nombre_banco2 = _fld_nombre_banco2, 
  fld_cuenta_banco2 = _fld_cuenta_banco2, 
  fld_otra_informacion = _fld_otra_informacion, 
  fld_nombre_con_gar = _fld_nombre_con_gar, 
  fld_apodo_con_gar = _fld_apodo_con_gar, 
  fld_cedula_con_gar = _fld_cedula_con_gar, 
  fld_telefono_con_gar = _fld_telefono_con_gar, 
  fld_celular_con_gar = _fld_celular_con_gar, 
  fld_edad = _fld_edad, 
  fld_estado_civil = _fld_estado_civil, 
  fld_edad_gar = _fld_edad_gar, 
  fld_estado_civil_gar = _fld_estado_civil_gar, 
  fld_ocupacion_cliente = _fld_ocupacion_cliente, 
  fld_ocupacion_gar = _fld_ocupacion_gar, 
  fld_categoria = _fld_categoria, 
  Puesto = _Puesto, 
  ReferidoPor = _ReferidoPor, 
  Oriundo = _Oriundo, 
  ctaContable = _ctaContable, 
  email = _email, 
  fld_parentesco_ref_gar2 = _fld_parentesco_ref_gar2, 
  fld_cedula_ref_gar2 = _fld_cedula_ref_gar2, 
  fld_tel_ref_gar2 = _fld_tel_ref_gar2, 
  fld_cel_ref_gar2 = _fld_cel_ref_gar2, 
  fld_whatsapp_ref_gar2 = _fld_whatsapp_ref_gar2, 
  Fdl_Dir_Emp_Gar1 = _Fdl_Dir_Emp_Gar1, 
  Fld_Rnc_Emp_Gar1 = _Fld_Rnc_Emp_Gar1, 
  Fld_Tel_Emp_Gar1 = _Fld_Tel_Emp_Gar1, 
  Fld_Whatsapp_emp_Gar1 = _Fld_Whatsapp_emp_Gar1, 
  Fld_Empra_Gar2 = _Fld_Empra_Gar2, 
  Fld_Dir_Emp_Gar2 = _Fld_Dir_Emp_Gar2, 
  Fld_Rnc_Emp_Gar2 = _Fld_Rnc_Emp_Gar2, 
  Fld_Tel_Emp_Gar2 = _Fld_Tel_Emp_Gar2, 
  Fld_Whatsapp_Emp_Gar2 = _Fld_Whatsapp_Emp_Gar2, 
  fld_nom_ref_flia_clie1 = _fld_nom_ref_flia_clie1, 
  fld_parentesco_ref_flia_clie1 = _fld_parentesco_ref_flia_clie1, 
  fld_ced_ref_flia_clie1 = _fld_ced_ref_flia_clie1, 
  fld_tel_ref_flia_clie1 = _fld_tel_ref_flia_clie1, 
  fechaIngreso = _fechaIngreso, 
  whatsapp = _whatsapp, 
  whatsapp_con = _whatsapp_con, 
  parentezco_gar = _parentezco_gar, 
  fecha_nac_gar = _fecha_nac_gar, 
  whatsapp_gar = _whatsapp_gar, 
  email_gar = _email_gar, 
  empresa_gar = _empresa_gar, 
  telefono_empresa_gar = _telefono_empresa_gar, 
  agno_labor_gar = _agno_labor_gar, 
  salario_gar = _salario_gar, 
  whatsapp_con_gar = _whatsapp_con_gar, 
  fld_ref_parentesco_clie1 = _fld_ref_parentesco_clie1, 
  fld_ced_ref_personal_clie1 = _fld_ced_ref_personal_clie1, 
  fld_tel_ref_personal_clie1 = _fld_tel_ref_personal_clie1, 
  fld_cel_ref_personal_clie1 = _fld_cel_ref_personal_clie1, 
  fld_whatsapp_ref_personal_clie1 = _fld_whatsapp_ref_personal_clie1, 
  fld_ref_personal_clie2 = _fld_ref_personal_clie2, 
  fld_ref_parentesco_clie2 = _fld_ref_parentesco_clie2, 
  fld_ced_ref_personal_clie2 = _fld_ced_ref_personal_clie2, 
  fld_tel_ref_personal_clie2 = _fld_tel_ref_personal_clie2, 
  fld_cel_ref_personal_clie2 = _fld_cel_ref_personal_clie2, 
  fld_whatsapp_ref_personal_clie2 = _fld_whatsapp_ref_personal_clie2, 
  Fld_Dir_Ref_Com_Clie1 = _Fld_Dir_Ref_Com_Clie1, 
  Fld_Rnc_Refe_Com_Clie1 = _Fld_Dir_Ref_Com_Clie1, 
  Fld_Tel_Com_clie1 = _Fld_Tel_Com_clie1, 
  Fld_Whatsapp_Com_Clie1 = _Fld_Whatsapp_Com_Clie1, 
  fld_ref_comerciales_cliente2 = _fld_ref_comerciales_cliente2, 
  Fld_Dir_Ref_Com_Clie2 = _Fld_Dir_Ref_Com_Clie2, 
  Fld_Rnc_Refe_Com_Clie2 = _Fld_Rnc_Refe_Com_Clie2, 
  Fld_Tel_Com_clie2 = _Fld_Tel_Com_clie2, 
  Fld_Whatsapp_Com_Clie2 = _Fld_Whatsapp_Com_Clie2, 
  fld_parentesco_ref_gar1 = _fld_parentesco_ref_gar1, 
  fld_cedula_ref_gar1 = _fld_cedula_ref_gar1, 
  fld_tel_ref_gar1 = _fld_tel_ref_gar1, 
  fld_cel_ref_gar1 = _fld_cel_ref_gar1, 
  fld_whatsapp_ref_gar1 = _fld_whatsapp_ref_gar1, 
  fld_ref_personal_gar2 = _fld_ref_personal_gar2, 
  fld_cel_ref_flia_clie1 = _fld_cel_ref_flia_clie1, 
  fld_whatsapp_ref_flia_clie1 = _fld_whatsapp_ref_flia_clie1, 
  fld_nom_ref_flia_clie2 = _fld_nom_ref_flia_clie2, 
  fld_parentesco_ref_flia_clie2 = _fld_parentesco_ref_flia_clie2, 
  fld_ced_ref_flia_clie2 = _fld_ced_ref_flia_clie2, 
  fld_tel_ref_flia_clie2 = _fld_tel_ref_flia_clie2, 
  fld_cel_ref_flia_clie2 = _fld_cel_ref_flia_clie2, 
  fld_whats_ref_flia_clie2 = _fld_whats_ref_flia_clie2, 
  fld_sector_id = _fld_sector_id, 
  fld_sector = _fld_sector, 
  fld_provincia_id = _fld_provincia_id, 
  fld_provincia = _fld_provincia 
where 
  fld_Id = _fld_ID;
END;

DROP 
  PROCEDURE IF EXISTS Sp_Actualizar_Roles;
CREATE PROCEDURE Sp_Actualizar_Roles(
  in _IDRol int, 
  in _Roles Varchar(50)
) Begin 
update 
  tbl_roles 
set 
  rol = _Roles 
where 
  IDROL = _IDROL;
End;


DROP 
  PROCEDURE IF EXISTS sp_InsertarAhorro;
CREATE PROCEDURE sp_InsertarAhorro(
  in _IDUsuario int, 
  in _mnuAhorros varchar(5), 
  in _mnuAhorrosNuevo varchar(5), 
  in _mnuAhorrosRealizarRetiros varchar(5), 
  in _mnuAhorrosEstadoCuenta varchar(5), 
  in _mnuAhorrosRetiros varchar(5), 
  in _mnuAhorrosSaldos varchar(5)
) BEGIN insert into tbl_userahorros(
  ID, IDUsuario, mnuAhorros, mnuAhorrosNuevo, 
  mnuAhorrosRealizarRetiros, mnuAhorrosEstadoCuenta, 
  mnuAhorrosRetiros, mnuAhorrosSaldos
) 
values 
  (
    null, _IDUsuario, _mnuAhorros, _mnuAhorrosNuevo, 
    _mnuAhorrosRealizarRetiros, _mnuAhorrosEstadoCuenta, 
    _mnuAhorrosRetiros, _mnuAhorrosSaldos
  );
END;

DROP 
  PROCEDURE IF EXISTS sp_Insertar_puestos;
CREATE PROCEDURE sp_Insertar_puestos(
  in _Puestos varchar(50)
) BEGIN insert into tbl_puestos(IdCargo, descripcion) 
values 
  (null, _Puestos);
END;

DROP 
  PROCEDURE IF EXISTS sp_insertar_roles;
CREATE PROCEDURE sp_insertar_roles(
  in _roles VARCHAR(50)
) Begin insert into tbl_user_rol (rol) 
values 
  (_roles);
End;

DROP 
  PROCEDURE IF EXISTS sp_Insertar_socios;
CREATE  PROCEDURE sp_Insertar_socios(
  in _fld_FullName varchar(255), 
  in _fld_apodo varchar(55), 
  in _TipoDocumento int, 
  in _fld_Identity varchar(16), 
  in _fld_Phone varchar(255), 
  in _fld_Phone2 varchar(255), 
  in _fld_Address varchar(255), 
  in _fld_City varchar(55), 
  in _fld_Status varchar(6), 
  in _fld_bce double(11, 2), 
  in _fld_cod_zona int, 
  in _fld_zona varchar(255), 
  in _fld_nombre_con varchar(55), 
  in _fld_apodo_con varchar(55), 
  in _fld_cedula_con varchar(16), 
  in _fld_telefono_con varchar(14), 
  in _fld_celular_con varchar(13), 
  in _fld_ref_personales_cliente varchar(50), 
  in _fld_ref_comerciales_cliente varchar(50), 
  in _fld_nombre_gar varchar(55), 
  in _fld_apodo_gar varchar(50), 
  in _fld_cedula_gar varchar(16), 
  in _fld_telefono_gar varchar(13), 
  in _fld_celular_gar varchar(13), 
  in _fld_direccion_gar varchar(255), 
  _fld_ciudad_gar varchar(55), 
  in _fld_ref_personales_gar varchar(50), 
  in _fld_ref_comerciales_gar varchar(50), 
  in _fld_ingresos_mesuales double(12, 2), 
  in _fld_nombre_banco1 varchar(1000), 
  in _fld_cuenta_banco1 varchar(15), 
  in _fld_nombre_banco2 varchar(1000), 
  in _fld_cuenta_banco2 varchar(15), 
  in _fld_otra_informacion varchar(1000), 
  in _fld_nombre_con_gar varchar(55), 
  in _fld_apodo_con_gar varchar(55), 
  in _fld_cedula_con_gar varchar(16), 
  in _fld_telefono_con_gar varchar(13), 
  in _fld_celular_con_gar varchar(13), 
  in _fld_edad date, 
  in _fld_estado_civil varchar(15), 
  in _fld_edad_gar varchar(50), 
  in _fld_estado_civil_gar varchar(15), 
  in _fld_ocupacion_cliente varchar(55), 
  in _fld_ocupacion_gar varchar(55), 
  in _fld_categoria varchar(25), 
  in _Puesto varchar(100), 
  in _ReferidoPor varchar(100), 
  in _Oriundo varchar(100), 
  in _ctaContable char(200), 
  in _email varchar(255), 
  in _fechaIngreso date, 
  in _whatsapp varchar(13), 
  in _whatsapp_con varchar(13), 
  in _parentezco_gar varchar(20), 
  in _fecha_nac_gar date, 
  in _whatsapp_gar varchar(13), 
  in _email_gar varchar(255), 
  in _empresa_gar varchar(50), 
  in _telefono_empresa_gar varchar(13), 
  in _agno_labor_gar varchar(50), 
  in _salario_gar double(10, 2), 
  in _whatsapp_con_gar varchar(13), 
  in _fld_ref_parentesco_clie1 varchar(20), 
  in _fld_ced_ref_personal_clie1 varchar(16), 
  in _fld_tel_ref_personal_clie1 varchar(13), 
  in _fld_cel_ref_personal_clie1 varchar(13), 
  in _fld_whatsapp_ref_personal_clie1 varchar(13), 
  in _fld_ref_personal_clie2 varchar(50), 
  in _fld_ref_parentesco_clie2 varchar(20), 
  in _fld_ced_ref_personal_clie2 varchar(16), 
  in _fld_tel_ref_personal_clie2 varchar(13), 
  in _fld_cel_ref_personal_clie2 varchar(13), 
  in _fld_whatsapp_ref_personal_clie2 varchar(13), 
  in _Fld_Dir_Ref_Com_Clie1 varchar(255), 
  in _Fld_Rnc_Refe_Com_Clie1 varchar(9), 
  in _Fld_Tel_Com_clie1 varchar(13), 
  in _Fld_Whatsapp_Com_Clie1 varchar(13), 
  in _fld_ref_comerciales_cliente2 varchar(50), 
  in _Fld_Dir_Ref_Com_Clie2 varchar(255), 
  in _Fld_Rnc_Refe_Com_Clie2 varchar(9), 
  in _Fld_Tel_Com_clie2 varchar(13), 
  in _Fld_Whatsapp_Com_Clie2 varchar(13), 
  in _fld_parentesco_ref_gar1 varchar(50), 
  in _fld_cedula_ref_gar1 varchar(16), 
  in _fld_tel_ref_gar1 varchar(13), 
  in _fld_cel_ref_gar1 varchar(13), 
  in _fld_whatsapp_ref_gar1 varchar(13), 
  in _fld_ref_personal_gar2 varchar(50), 
  in _fld_parentesco_ref_gar2 varchar(20), 
  in _fld_cedula_ref_gar2 varchar(16), 
  in _fld_tel_ref_gar2 varchar(13), 
  in _fld_cel_ref_gar2 varchar(13), 
  in _fld_whatsapp_ref_gar2 varchar(13), 
  in _Fdl_Dir_Emp_Gar1 varchar(255), 
  in _Fld_Rnc_Emp_Gar1 varchar(11), 
  in _Fld_Tel_Emp_Gar1 varchar(13), 
  in _Fld_Whatsapp_emp_Gar1 varchar(13), 
  in _Fld_Empra_Gar2 varchar(50), 
  in _Fld_Dir_Emp_Gar2 varchar(255), 
  in _Fld_Rnc_Emp_Gar2 varchar(11), 
  in _Fld_Tel_Emp_Gar2 varchar(13), 
  in _Fld_Whatsapp_Emp_Gar2 varchar(13), 
  in _fld_nom_ref_flia_clie1 varchar(50), 
  in _fld_parentesco_ref_flia_clie1 varchar(20), 
  in _fld_ced_ref_flia_clie1 varchar(16), 
  in _fld_tel_ref_flia_clie1 varchar(13), 
  in _fld_cel_ref_flia_clie1 varchar(13), 
  in _fld_whatsapp_ref_flia_clie1 varchar(13), 
  in _fld_nom_ref_flia_clie2 varchar(50), 
  in _fld_parentesco_ref_flia_clie2 varchar(20), 
  in _fld_ced_ref_flia_clie2 varchar(16), 
  in _fld_tel_ref_flia_clie2 varchar(13), 
  in _fld_cel_ref_flia_clie2 varchar(13), 
  in _fld_whats_ref_flia_clie2 varchar(13), 
  in _fld_sector_id int, 
  in _fld_sector varchar(255), 
  in _fld_provincia_id int, 
  in _fld_provincia varchar(255)
) BEGIN insert into tbl_clientes(
  fld_FullName, fld_apodo, TipoDocumento, 
  fld_Identity, fld_Phone, fld_Phone2, 
  fld_Address, fld_City, fld_Status, 
  fld_bce, fld_cod_zona, fld_zona, 
  fld_nombre_con, fld_apodo_con, fld_cedula_con, 
  fld_telefono_con, fld_celular_con, 
  fld_ref_personales_cliente, fld_ref_comerciales_cliente, 
  fld_nombre_gar, fld_apodo_gar, fld_cedula_gar, 
  fld_telefono_gar, fld_celular_gar, 
  fld_direccion_gar, fld_ciudad_gar, 
  fld_ref_personales_gar, fld_ref_comerciales_gar, 
  fld_ingresos_mesuales, fld_nombre_banco1, 
  fld_cuenta_banco1, fld_nombre_banco2, 
  fld_cuenta_banco2, fld_otra_informacion, 
  fld_nombre_con_gar, fld_apodo_con_gar, 
  fld_cedula_con_gar, fld_telefono_con_gar, 
  fld_celular_con_gar, fld_edad, fld_estado_civil, 
  fld_edad_gar, fld_estado_civil_gar, 
  fld_ocupacion_cliente, fld_ocupacion_gar, 
  fld_categoria, Puesto, ReferidoPor, 
  Oriundo, ctaContable, email, fechaIngreso, 
  whatsapp, whatsapp_con, parentezco_gar, 
  fecha_nac_gar, whatsapp_gar, email_gar, 
  empresa_gar, telefono_empresa_gar, 
  agno_labor_gar, salario_gar, whatsapp_con_gar, 
  fld_ref_parentesco_clie1, fld_ced_ref_personal_clie1, 
  fld_tel_ref_personal_clie1, fld_cel_ref_personal_clie1, 
  fld_whatsapp_ref_personal_clie1, 
  fld_ref_personal_clie2, fld_ref_parentesco_clie2, 
  fld_ced_ref_personal_clie2, fld_tel_ref_personal_clie2, 
  fld_cel_ref_personal_clie2, fld_whatsapp_ref_personal_clie2, 
  Fld_Dir_Ref_Com_Clie1, Fld_Rnc_Refe_Com_Clie1, 
  Fld_Tel_Com_clie1, Fld_Whatsapp_Com_Clie1, 
  fld_ref_comerciales_cliente2, Fld_Dir_Ref_Com_Clie2, 
  Fld_Rnc_Refe_Com_Clie2, Fld_Tel_Com_clie2, 
  Fld_Whatsapp_Com_Clie2, fld_parentesco_ref_gar1, 
  fld_cedula_ref_gar1, fld_tel_ref_gar1, 
  fld_cel_ref_gar1, fld_whatsapp_ref_gar1, 
  fld_ref_personal_gar2, fld_parentesco_ref_gar2, 
  fld_cedula_ref_gar2, fld_tel_ref_gar2, 
  fld_cel_ref_gar2, fld_whatsapp_ref_gar2, 
  Fdl_Dir_Emp_Gar1, Fld_Rnc_Emp_Gar1, 
  Fld_Tel_Emp_Gar1, Fld_Whatsapp_emp_Gar1, 
  Fld_Empra_Gar2, Fld_Dir_Emp_Gar2, 
  Fld_Rnc_Emp_Gar2, Fld_Tel_Emp_Gar2, 
  Fld_Whatsapp_Emp_Gar2, fld_nom_ref_flia_clie1, 
  fld_parentesco_ref_flia_clie1, 
  fld_ced_ref_flia_clie1, fld_tel_ref_flia_clie1, 
  fld_cel_ref_flia_clie1, fld_whatsapp_ref_flia_clie1, 
  fld_nom_ref_flia_clie2, fld_parentesco_ref_flia_clie2, 
  fld_ced_ref_flia_clie2, fld_tel_ref_flia_clie2, 
  fld_cel_ref_flia_clie2, fld_whats_ref_flia_clie2, 
  fld_sector_id, fld_sector, fld_provincia_id, 
  fld_provincia
) 
values 
  (
    _fld_FullName, _fld_apodo, _TipoDocumento, 
    _fld_Identity, _fld_Phone, _fld_Phone2, 
    _fld_Address, _fld_City, _fld_Status, 
    _fld_bce, _fld_cod_zona, _fld_zona, 
    _fld_nombre_con, _fld_apodo_con, 
    _fld_cedula_con, _fld_telefono_con, 
    _fld_celular_con, _fld_ref_personales_cliente, 
    _fld_ref_comerciales_cliente, _fld_nombre_gar, 
    _fld_apodo_gar, _fld_cedula_gar, 
    _fld_telefono_gar, _fld_celular_gar, 
    _fld_direccion_gar, _fld_ciudad_gar, 
    _fld_ref_personales_gar, _fld_ref_comerciales_gar, 
    _fld_ingresos_mesuales, _fld_nombre_banco1, 
    _fld_cuenta_banco1, _fld_nombre_banco2, 
    _fld_cuenta_banco2, _fld_otra_informacion, 
    _fld_nombre_con_gar, _fld_apodo_con_gar, 
    _fld_cedula_con_gar, _fld_telefono_con_gar, 
    _fld_celular_con_gar, _fld_edad, 
    _fld_estado_civil, _fld_edad_gar, 
    _fld_estado_civil_gar, _fld_ocupacion_cliente, 
    _fld_ocupacion_gar, _fld_categoria, 
    _Puesto, _ReferidoPor, _Oriundo, 
    _ctaContable, _email, _fechaIngreso, 
    _whatsapp, _whatsapp_con, _parentezco_gar, 
    _fecha_nac_gar, _whatsapp_gar, _email_gar, 
    _empresa_gar, _telefono_empresa_gar, 
    _agno_labor_gar, _salario_gar, _whatsapp_con_gar, 
    _fld_ref_parentesco_clie1, _fld_ced_ref_personal_clie1, 
    _fld_tel_ref_personal_clie1, _fld_cel_ref_personal_clie1, 
    _fld_whatsapp_ref_personal_clie1, 
    _fld_ref_personal_clie2, _fld_ref_parentesco_clie2, 
    _fld_ced_ref_personal_clie2, _fld_tel_ref_personal_clie2, 
    _fld_cel_ref_personal_clie2, _fld_whatsapp_ref_personal_clie2, 
    _Fld_Dir_Ref_Com_Clie1, _Fld_Rnc_Refe_Com_Clie1, 
    _Fld_Tel_Com_clie1, _Fld_Whatsapp_Com_Clie1, 
    _fld_ref_comerciales_cliente2, 
    _Fld_Dir_Ref_Com_Clie2, _Fld_Rnc_Refe_Com_Clie2, 
    _Fld_Tel_Com_clie2, _Fld_Whatsapp_Com_Clie2, 
    _fld_parentesco_ref_gar1, _fld_cedula_ref_gar1, 
    _fld_tel_ref_gar1, _fld_cel_ref_gar1, 
    _fld_whatsapp_ref_gar1, _fld_ref_personal_gar2, 
    _fld_parentesco_ref_gar2, _fld_cedula_ref_gar2, 
    _fld_tel_ref_gar2, _fld_cel_ref_gar2, 
    _fld_whatsapp_ref_gar2, _Fdl_Dir_Emp_Gar1, 
    _Fld_Rnc_Emp_Gar1, _Fld_Tel_Emp_Gar1, 
    _Fld_Whatsapp_emp_Gar1, _Fld_Empra_Gar2, 
    _Fld_Dir_Emp_Gar2, _Fld_Rnc_Emp_Gar2, 
    _Fld_Tel_Emp_Gar2, _Fld_Whatsapp_Emp_Gar2, 
    _fld_nom_ref_flia_clie1, _fld_parentesco_ref_flia_clie1, 
    _fld_ced_ref_flia_clie1, _fld_tel_ref_flia_clie1, 
    _fld_cel_ref_flia_clie1, _fld_whatsapp_ref_flia_clie1, 
    _fld_nom_ref_flia_clie2, _fld_parentesco_ref_flia_clie2, 
    _fld_ced_ref_flia_clie2, _fld_tel_ref_flia_clie2, 
    _fld_cel_ref_flia_clie2, _fld_whats_ref_flia_clie2, 
    _fld_sector_id, _fld_sector, _fld_provincia_id, 
    _fld_provincia
  );
END;

DROP 
  PROCEDURE IF EXISTS sp_insertar_solicitud_credito;
CREATE PROCEDURE sp_insertar_solicitud_credito(
  in _fechaCreada datetime, 
  in _fechaAprobacion datetime, 
  in _creadoPor int, 
  in _AprobadoPor int, 
  in _clasificacion varchar(75), 
  in _condicion varchar(75), 
  in _fechaInicio date, 
  in _montoSolicitado double(12, 2), 
  in _monto double(10, 2), 
  in _seguro double(12, 2), 
  in _montoLegal double(12, 2), 
  in _interes double(12, 2), 
  in _cantCuotas smallint, 
  in _montoCuotas double(12, 2), 
  in _socio int, 
  in s_ocioExistente int, 
  in _estado char(25), 
  in _cedula varchar(14), 
  in _direccion varchar(255), 
  in _provincia varchar(20), 
  in _municipio varchar(20), 
  in _barrio varchar(20), 
  in _phone varchar(13), 
  in _phone2 varchar(13), 
  in _casa_propia char(2), 
  in _tiempo_vivienda smallint, 
  in _casa_alquilada char(2), 
  in _tiempo_alquiler smallint, 
  in _correo varchar(255), 
  in _empresa varchar(50), 
  in _phone3 varchar(13), 
  in _empresa_agno smallint, 
  in _empresa_meses smallint, 
  in _nomconyugue varchar(50), 
  in _tel_conyugue varchar(13), 
  in _nomflila varchar(50), 
  in _tel_flia varchar(13), 
  in _codeudor varchar(50), 
  in _tel_codeudor varchar(13)
) Begin insert into solicitudcredito (
  Id, FechaCreada, FechaAprobacion, 
  CreadoPor, AprobadoPor, Clasificacion, 
  Condicion, FechaInicio, MontoSolicitado, 
  Seguro, MontoLegal, Monto, Interes, 
  CantCuotas, MontoCuotas, Socio, SocioExistente, 
  Estado, cedula, direccion, provincia, 
  municipio, barrio, phone, phone2, 
  casa_propia, tiempo_casa, casa_alquiler, 
  tiempo_alquiler, correo, empresa, 
  phone3, empresa_agno, empresa_meses, 
  nomconyugue, phone4, nomflia, phone5, 
  codeudor, phone6
) 
values 
  (
    null, _fechaCreada, _fechaAprobacion, 
    _creadoPor, _AprobadoPor, _clasificacion, 
    _condicion, _fechaInicio, _montoSolicitado, 
    _monto, _seguro, _montoLegal, _interes, 
    _cantCuotas, _montoCuotas, _socio, 
    s_ocioExistente, _estado, _cedula, 
    _direccion, _provincia, _municipio, 
    _barrio, _phone, _phone2, _casa_propia, 
    _tiempo_vivienda, _casa_alquilada, 
    _tiempo_alquiler, _correo, _empresa, 
    _phone3, _empresa_agno, _empresa_meses, 
    _nomconyugue, _tel_conyugue, _nomflila, 
    _tel_flia, _codeudor, _tel_codeudor
  );
end;

DROP 
  PROCEDURE IF EXISTS sp_mmnuCxPm;
CREATE PROCEDURE sp_mmnuCxPm(
  in _IDUsuario int, 
  in _mnuCuentaPorPagar varchar(5), 
  in _mnuProveedores varchar(5), 
  in _mnuIngresosCajaCxP varchar(5), 
  in _mnuCxPND varchar(5), 
  in _mnuCxPNC varchar(5), 
  in _repEstadoProveedor varchar(5), 
  in _repCuentaPorPagar varchar(5), 
  _repNDCuentaPorPagar varchar(5), 
  in _repNCCuentaPorPagar varchar(5), 
  in _repTodoProveedores varchar(5)
) BEGIN insert into tbl_usercuentaporpagar(
  ID, IDUsuario, mnuCuentaPorPagar, 
  mnuproveedores, mnuIngresosCajaCxP, 
  mnuCxPND, mnuCxPNC, repEstadoProveedor, 
  repCuentaPorPagar, repNDCuentaPorPagar, 
  repNCCuentaPorPagar, repTodoProveedores
) 
values 
  (
    null, _IDUsuario, _mnuCuentaPorPagar, 
    _mnuProveedores, _mnuIngresosCajaCxP, 
    _mnuCxPND, _mnuCxPNC, _repEstadoProveedor, 
    _repCuentaPorPagar, _repNDCuentaPorPagar, 
    _repNCCuentaPorPagar, _repTodoProveedores
  );
END;

DROP 
  PROCEDURE IF EXISTS sp_MnuCaja;
CREATE PROCEDURE sp_MnuCaja(
  in _IDUsuario int, 
  in _MnuCaja varchar(5), 
  in _MnuRecibosIngresos varchar(5), 
  in _MnuOtrosIngresos varchar(5), 
  in _MnuConsultaIngresos varchar(5), 
  in _MnuEgresos varchar(5), 
  in _mnuCuadreCaja varchar(5), 
  in _repRecibosIngresos varchar(5), 
  in _repRecibosIngresosNulos varchar(5), 
  in _repEgresosCaja varchar(5)
) BEGIN insert into tbl_usercaja(
  ID, IDUsuario, mnuCaja, mnuRecibosIngresos, 
  mnuOtrosIngresos, mnuConsultaIngresos, 
  mnuEgresos, mnuCuadreCaja, repRecibosIngresos, 
  repRecibosIngresosNulos, repEgresosCaja
) 
values 
  (
    null, _IDUsuario, _MnuCaja, _MnuRecibosIngresos, 
    _MnuOtrosIngresos, _MnuConsultaIngresos, 
    _MnuEgresos, _mnuCuadreCaja, _repRecibosIngresos, 
    _repRecibosIngresosNulos, _repEgresosCaja
  );
END;

DROP 
  PROCEDURE IF EXISTS sp_mnuCXC;
CREATE PROCEDURE sp_mnuCXC(
  in _IDUsuario int, 
  in _MnuCuentaPorCobrar varchar(5), 
  in _MnuGenerarRecibos varchar(5), 
  in _MnuCxCND varchar(5), 
  in _MnuCxCNC varchar(5), 
  in _MnuConsultarCxCNC varchar(5), 
  in _repEstadoCliente varchar(5), 
  in _RepNDCxC varchar(5), 
  in _repNCCxC varchar(5), 
  in _repCuentaPorCobrar varchar(5), 
  in _repCuentaPorCobrarCuotasFechas varchar(5), 
  in _repCuentaPorCobrarCapital varchar(5), 
  in _repCuentaPorCobrarInteres varchar(5), 
  in _repTodosClientes varchar(5), 
  _MnuPrestamosNuevos varchar(5), 
  in _repPrestamosEntregados varchar(5), 
  in _rePrestamosPendientes varchar(5), 
  in repPrestamosSaldos varchar(5)
) BEGIN insert into tbl_usercuentaporcobrar(
  ID, IDUsuario, mnucuentaPorCobrar, 
  mnuGeneraRecibos, mnuCxCND, mnuCxCNC, 
  mnuConsultaCxCNC, repEstadoCliente, 
  repNDCxC, repNCCxC, repCuentaPorCobrar, 
  repCuentaPorCobrarCuotasFechas, 
  repCuentaPorCobrarCapital, repCuentaPorCobrarIntes, 
  repTodosClientes, mnuPrestamosNuevos, 
  repPrestamosEntregados, repPrestamosPendientes, 
  repPrestamosSaldos
) 
values 
  (
    null, _IDUsuario, _MnuCuentaPorCobrar, 
    _MnuGenerarRecibos, _MnuCxCND, _MnuCxCNC, 
    _MnuConsultarCxCNC, _repEstadoCliente, 
    _RepNDCxC, _repNCCxC, _repCuentaPorCobrar, 
    _repCuentaPorCobrarCuotasFechas, 
    _repCuentaPorCobrarCapital, _repCuentaPorCobrarInteres, 
    _repTodosClientes, _MnuPrestamosNuevos, 
    _repPrestamosEntregados, _rePrestamosPendientes, 
    repPrestamosSaldos
  );
END;

DROP 
  PROCEDURE IF EXISTS sp_reporte_CxC;
CREATE PROCEDURE sp_reporte_CxC(in _fecha1 date, in _fecha2 date) begin 
select 
  p.fld_balance, 
  p.fld_fecha_ultimo_abono, 
  c.fld_fullname, 
  fld_apodo, 
  c.fld_phone 
from 
  tbl_prestamos as p 
  inner join tbl_clientes as c on p.fld_id_del_cliente = c.fld_id 
where 
  p.fld_fecha_ultimo_abono between _fecha1 
  and _fecha2;
end;

DROP 
  PROCEDURE IF EXISTS sp_score_Cliente;
CREATE PROCEDURE sp_score_Cliente(
  in _fld_id_cliente int, 
  in _fld_id_prestamos int, 
  in _fld_monto_cuotas double(10, 2), 
  in _fld_disponibilidad double(10, 2), 
  in _fld_puntuacion smallint, 
  in _fld_status varchar(20), 
  in _fld_monto_recomendado double(10, 2)
) begin insert into tbl_score_cliente(
  fld_id, fld_id_cliente, fld_id_prestamos, 
  fld_monto_cuotas, fld_disponiblidad, 
  fld_puntuacion, fld_status, fld_monto_recomendado
) 
values 
  (
    null, _fld_id_cliente, _fld_id_prestamos, 
    _fld_monto_cuotas, _fld_disponibilidad, 
    _fld_puntuacion, _fld_status, _fld_monto_recomendado
  );
end;

DROP 
  PROCEDURE IF EXISTS sp_solicitudcreditoingresos_flia;
CREATE PROCEDURE sp_solicitudcreditoingresos_flia(
  in _fld_id_sol int, 
  in _fld_ingreso_conyugue double(10, 2), 
  in _fld_otros_negocios double(10, 2), 
  in _fld_remensa_fliares double(10, 2), 
  in _fld_ingresos_flia double(10, 2)
) begin insert into tbl_solicitudcreditoingresos_flia(
  fldid, fld_id_sol, fld_ingreso_conyugue, 
  fld_otros_negocios, fld_remensa_fliares, 
  fld_ingresos_flia
) 
values 
  (
    null, _fld_id_sol, _fld_ingreso_conyugue, 
    _fld_otros_negocios, _fld_remensa_fliares, 
    _fld_ingresos_flia
  );
end;


DROP 
  PROCEDURE IF EXISTS sp_solicitudcreditoingresos_gastos;
CREATE PROCEDURE sp_solicitudcreditoingresos_gastos(
  in _fld_id_sol int, 
  in _fld_ventas_ingresos_fijos double(10, 2), 
  in _fld_compra_mes double(10, 2), 
  in _fld_margen_bruto double(10, 2), 
  in _fld_Salario double(10, 2), 
  in _fld_alquileres double(10, 2), 
  in _mant_repacion double(10, 2), 
  in _fld_servicios double(10, 2), 
  in _fld_cuotas_otros_prestamos double(10, 2), 
  in _fld_trans_combustible double(10, 2), 
  in _fld_otros_gastos double(10, 2), 
  in _fld_total_gastos double(10, 2), 
  _fld_beneficio_neto double(10, 2)
) BEGIN insert into tbl_solicitudcreditoingresos_gastos(
  fldid, fld_id_sol, fld_ventas_ingresos_fijos, 
  fld_compra_mes, fld_margen_bruto, 
  fld_Salario, fld_alquileres, fld_mant_repacion, 
  fld_servicios, fld_cuotas_otros_prestamos, 
  fld_trans_combustible, fld_otros_gastos, 
  fld_total_gasto, fld_beneficio_neto
) 
values 
  (
    null, _fld_id_sol, _fld_ventas_ingresos_fijos, 
    _fld_compra_mes, _fld_margen_bruto, 
    _fld_Salario, _fld_alquileres, _mant_repacion, 
    _fld_servicios, _fld_cuotas_otros_prestamos, 
    _fld_trans_combustible, _fld_otros_gastos, 
    _fld_total_gastos, _fld_beneficio_neto
  );
END;

DROP 
  PROCEDURE IF EXISTS sp_solicitudcreditonota;
CREATE PROCEDURE sp_solicitudcreditonota(
  in _Fecha datetime, 
  in _IdSolicitud int, 
  in _IdUser int, 
  in _Nota varchar(255), 
  in _comentario_Officer_negocio varchar(255), 
  in _comentario_enc_negocio varchar(255), 
  in _comentario_analista_de_credito varchar(255)
) Begin insert into solicitudcreditonota(
  Id, Fecha, Idsolicitud, IdUser, Nota, 
  comentario_Officer_negocio, comentario_enc_negocio, 
  comentario_analista_de_credito
) 
values 
  (
    null, _Fecha, _IdSolicitud, _IdUser, 
    _Nota, _comentario_Officer_negocio, 
    _comentario_enc_negocio, _comentario_analista_de_credito
  );
End;

DROP 
  PROCEDURE IF EXISTS sp_solicitudcreditopatrimonio;
CREATE PROCEDURE sp_solicitudcreditopatrimonio(
  in _fld_id_sol int, 
  in _fldefectivo double(10, 2), 
  in _fldcxc double(10, 2), 
  in _fldinventario double(10, 2), 
  in _fldtotal_activo_corriente double(10, 2), 
  in _fldmaquina_equipos double(10, 2), 
  in _fldmobiliario double(10, 2), 
  in _fldinmueble double(10, 2), 
  in _fld_otros_activos double(10, 2), 
  in _fldtotal_activos_fijos double(10, 2), 
  in _fldtotal_activos double(10, 2), 
  in _fld_deuda_bancarias double(10, 2), 
  in _fld_cxc_suplidores double(10, 2), 
  in _fld_otras_cxc double(10, 2), 
  in _fld_total_pasivo double(10, 2), 
  in _fld_capital double(10, 2), 
  in _fld_pasivo_capital double(10, 2)
) BEGIN insert into tbl_solicitudcreditopatrimonio(
  id_sol_Pat, fld_id_sol, fldefectivo, 
  fldcxc, fldinventario, fldtotal_activo_corriente, 
  fldmaquina_equipos, fldmobiliario, 
  fldinmueble, fld_otros_activos, 
  fldtotal_activos_fijos, fld_total_activos, 
  fld_deuda_bancarias, fld_cxc_suplidores, 
  fld_Otras_cxc, fld_total_pasivo, 
  fld_capital, fld_pasivo_capital
) 
values 
  (
    null, _fld_id_sol, _fldefectivo, _fldcxc, 
    _fldinventario, _fldtotal_activo_corriente, 
    _fldmaquina_equipos, _fldmobiliario, 
    _fldinmueble, _fld_otros_activos, 
    _fldtotal_activos_fijos, _fldtotal_activos, 
    _fld_deuda_bancarias, _fld_cxc_suplidores, 
    _fld_otras_cxc, _fld_total_pasivo, 
    _fld_capital, _fld_pasivo_capital
  );
end;

DROP 
  VIEW IF EXISTS wiew_cuentasprestamo;
CREATE  VIEW wiew_cuentasprestamo AS 
select 
  Descripcion 
from 
  tbl_catalogo 
where 
   
  CuentaNo in(
    '101-01-01-01', '101-01-01-02', '101-01-01-03', 
    '101-01-01-04', '101-01-01-05', 
													  
    '101-01-01-06', '101-01-02', '101-01-02-01', 
    '101-01-02-02', '101-01-02-03'
	 
  );

DROP 
  VIEW IF EXISTS wiew_cuentasprestamos;
CREATE  VIEW wiew_cuentasprestamos AS 
select 
  CuentaNo, 
  Descripcion 
from 
  tbl_catalogo 
where 
  CuentaNo in(
    '101-01-01-01', '101-01-01-02', '101-01-01-03', 
    '101-01-01-04', '101-01-01-05', 
    '101-01-01-06', '101-01-02', '101-01-02-01', 
    '101-01-02-02', '101-01-02-03'
  );

DROP 
  VIEW IF EXISTS _viewlibretadepositos;
CREATE  VIEW _viewlibretadepositos AS 
SELECT 
  DISTINCT d.fecha, 
  d.monto AS Depositos, 
  va.saldointeres AS Intereses, 
  va.saldocapital AS Balance, 
  d.Usuario AS Cajero, 
  va.Descripcion, 
  d.idcliente, 
  va.fld_FullName, 
  va.CuentaNo 
FROM 
  tbl_ahorros_depositos AS d 
  INNER JOIN view_ahorros AS va ON d.idcliente = va.idcliente;
