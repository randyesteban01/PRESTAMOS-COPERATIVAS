-- Autor: Enrique José Escobar Maradiaga
-- Fecha: 27/02/2023
-- Descripcion: Script para unificar estructura de base de datos

ALTER TABLE parametrosgenerales ADD COLUMN VersionPublicacionSistema VARCHAR(100) NULL default '01.00.00.000';
UPDATE parametrosgenerales SET VersionPublicacionSistema='01.00.00.001';


ALTER TABLE solicitudcredito MODIFY MontoSolicitado decimal(12, 2) NOT NULL default '0.00';
ALTER TABLE solicitudcredito MODIFY Seguro DECIMAL(12,2) NOT NULL default '0.00';
ALTER TABLE solicitudcredito MODIFY Montolegal DECIMAL(12,2) NOT NULL default '0.00';
ALTER TABLE solicitudcredito MODIFY Monto DECIMAL(12,2);
ALTER TABLE solicitudcredito MODIFY Interes DECIMAL(12,2);
ALTER TABLE solicitudcredito MODIFY MontoCuotas DECIMAL(12,2);
ALTER TABLE solicitudcredito ADD COLUMN Notas VARCHAR(1024) NULL AFTER MontoCuotas;

ALTER TABLE solicitudcreditonota MODIFY Nota varchar(2048);

ALTER TABLE tbl_ahorros_aportacion MODIFY Fecha datetime;

ALTER TABLE tbl_ahorros_categorias MODIFY tasaCuenta decimal(10,2) default NULL;

ALTER TABLE tbl_ahorros_retiros MODIFY Fecha datetime default NULL;

ALTER TABLE tbl_catalogo ADD COLUMN Nivel int(11) NOT NULL default '1';

ALTER TABLE tbl_ahorros_retiros MODIFY Fecha datetime default NULL;

ALTER TABLE tbl_clientes MODIFY fld_Phone  varchar(255) default '809-000-0000';
ALTER TABLE tbl_clientes MODIFY fld_Phone2  varchar(255) default '809-000-0000';
ALTER TABLE tbl_clientes MODIFY fld_telefono_con  varchar(14) default '809-000-0000';
ALTER TABLE tbl_clientes MODIFY fld_celular_con  varchar(13) default '809-000-0000';
ALTER TABLE tbl_clientes MODIFY fld_ref_personales_cliente  varchar(510) default 'N/A';
ALTER TABLE tbl_clientes MODIFY fld_ref_comerciales_cliente  varchar(510) default 'N/A';
ALTER TABLE tbl_clientes MODIFY fld_ref_personales_gar  varchar(510) default 'N/A';
ALTER TABLE tbl_clientes MODIFY fld_ref_comerciales_gar  varchar(510) default 'N/A';
ALTER TABLE tbl_clientes MODIFY fld_cedula_con_gar  varchar(16) default '0';
ALTER TABLE tbl_clientes MODIFY fld_edad_gar  int(50) default '0';
ALTER TABLE tbl_clientes MODIFY agno_labor_gar   int(50) default '0';
UPDATE tbl_clientes SET agno_labor_gar=0 WHERE agno_labor_gar='';
ALTER TABLE tbl_clientes MODIFY fld_ced_ref_personal_clie1 varchar(16) default NULL;
ALTER TABLE tbl_clientes MODIFY Fld_Tel_Com_clie2 varchar(13) default 'N/A';
ALTER TABLE tbl_clientes MODIFY fld_cedula_ref_gar1 varchar(16) default NULL;
ALTER TABLE tbl_clientes MODIFY fld_cedula_ref_gar2 varchar(16) default NULL;
ALTER TABLE tbl_clientes MODIFY Fld_Rnc_Emp_Gar1  varchar(11) default NULL;
ALTER TABLE tbl_clientes MODIFY Fld_Empra_Gar2   varchar(50) default 'N/A';
ALTER TABLE tbl_clientes MODIFY Fld_Tel_Emp_Gar2   varchar(13) default 'N/A';
ALTER TABLE tbl_clientes MODIFY fld_parentesco_ref_flia_clie1   varchar(50) default NULL;
ALTER TABLE tbl_clientes MODIFY fld_ced_ref_flia_clie1   varchar(16) default NULL;
ALTER TABLE tbl_clientes MODIFY fld_ced_ref_flia_clie2   varchar(16) default NULL;

ALTER TABLE tbl_clientes ADD COLUMN fld_provincia_id int(11) default '0';
UPDATE tbl_clientes SET fld_provincia_id=0;
ALTER TABLE tbl_clientes ADD COLUMN fld_provincia  varchar(255) default 'N/A';
UPDATE tbl_clientes SET fld_provincia='N/A';

ALTER TABLE tbl_nc_cxc MODIFY fld_fecha   datetime default NULL;

ALTER TABLE tlb_segundo_titular_cta_ahorros ADD COLUMN fldIdAhorro  int(11) default NULL AFTER fldCod2doTitular;
ALTER TABLE tlb_segundo_titular_cta_ahorros ADD COLUMN fldNotas2doTitular varchar(255) default NULL;

DROP 
  TABLE IF EXISTS tbl_ahorros_cuentas_copy;

DROP 
  TABLE IF EXISTS tbl_catalogo_copy;

DROP 
  TABLE IF EXISTS _viewlibretadepositos;

UPDATE tbl_catalogo
SET
ID=287
WHERE
CuentaNo='100-01-03';

