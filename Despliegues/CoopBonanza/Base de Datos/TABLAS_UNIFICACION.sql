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

ALTER TABLE tbl_ahorros_categorias ADD COLUMN tasaCuenta decimal(10, 2);

ALTER TABLE tbl_catalogo ADD COLUMN Nivel  int(11) NOT NULL default 1 ;

ALTER TABLE tbl_clientes MODIFY fld_edad_gar int(50) default '0';
ALTER TABLE tbl_clientes MODIFY agno_labor_gar int(50) default '0';
UPDATE tbl_clientes SET agno_labor_gar=0 WHERE agno_labor_gar='';
ALTER TABLE tbl_clientes MODIFY fld_nom_ref_flia_clie1 VARCHAR(50);

ALTER TABLE tbl_clientes ADD COLUMN fld_provincia_id  int(11)   NULL default 0;
UPDATE tbl_clientes SET fld_provincia_id=0;

ALTER TABLE tbl_clientes ADD COLUMN fld_provincia  varchar(255)   NULL default 'N/A';
UPDATE tbl_clientes SET fld_provincia='N/A';

-- ----------------------------
--  Table structure for `tbl_reporte_saldos`
-- ----------------------------
DROP 
  TABLE IF EXISTS `tbl_reporte_saldos`;
CREATE TABLE `tbl_reporte_saldos` (
  `fld_entidad` varchar(100) default NULL, 
  `fld_cod_cliente` int(11) default NULL, 
  `fld_relacion_cliente` varchar(255) default NULL, 
  `fld_cliente` varchar(255) default NULL, 
  `fld_cedula` varchar(16) default NULL, 
  `fld_direccion` varchar(255) default NULL, 
  `fld_celular` varchar(16) default NULL, 
  `fld_razon_social` varchar(100) default NULL, 
  `fld_cod_prestamo` int(11) default NULL, 
  `fld_unidad_moneda` char(6) default NULL, 
  `fld_clasificacion` varchar(100) default NULL, 
  `fld_forma_pago` varchar(50) default NULL, 
  `fld_fecha` date default NULL, 
  `fld_fecha_vencimiento` date default NULL, 
  `fld_monto_prestamo` double(11, 2) default NULL, 
  `fld_monto_cuota` double(11, 2) default NULL, 
  `fld_cantidad_cuotas` int(11) default NULL, 
  `fld_fecha_ult_corte_prestamo` date default NULL, 
  `fld_fecha_ult_abono` date default NULL, 
  `fld_monto_ultimo_pago` double(11, 2) default NULL, 
  `fld_balance` double(11, 2) default NULL, 
  `fld_atraso` double(11, 2) default NULL, 
  `fld_cant_cuotas_atrasadas` int(11) default NULL, 
  `fld_status` varchar(5) default NULL, 
  `fld_estado_ctas` char(6) default NULL, 
  `fld_saldo_vencido30` double(11, 2) default NULL, 
  `fld_saldo_vencido60` double(11, 2) default NULL, 
  `fld_saldo_vencido90` double(11, 2) default NULL, 
  `fld_saldo_vencido120` double(11, 2) default NULL, 
  `fld_saldo_vencido150` double(11, 2) default NULL, 
  `fld_saldo_vencido180` double(11, 2) default NULL, 
  `fld_saldo_vencido181` double(11, 2) default NULL
) ENGINE = InnoDB DEFAULT CHARSET = latin1;

ALTER TABLE tlb_segundo_titular_cta_ahorros ADD COLUMN fldIdAhorro  int(11) NULL AFTER fldCod2doTitular;
ALTER TABLE tlb_segundo_titular_cta_ahorros ADD COLUMN fldNotas2doTitular  varchar(255) NULL;

ALTER TABLE parametrosgenerales ADD COLUMN VersionPublicacionSistema  varchar(100)   NULL default '01.00.00.000';
UPDATE parametrosgenerales SET VersionPublicacionSistema='01.00.00.001';

