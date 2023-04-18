-- Agregar nueva columna retiro de intereses certificados
ALTER TABLE tbl_interfascontableotras ADD COLUMN CertificadoInteres VARCHAR(10) default '500-03' ;
ALTER TABLE tbl_interfascontableotras ADD COLUMN CertificadoInteresGenerado VARCHAR(10) default '201-02-01' ;

-- agregar nuevos permisos 
ALTER TABLE tbl_userahorros ADD COLUMN CambiarFechadeposito VARCHAR(5) default 'true' ;
ALTER TABLE tbl_usercaja ADD COLUMN CambiarFechaRecibo VARCHAR(5) default 'true' ;

-- Backlog Opción rebajar balance aportación. CREESCOOP, COOPEMPROF
INSERT INTO tbl_interfascontableotrastipo(fld_descripcion) VALUES ('RETIRO APORTE SOCIOS')
INSERT INTO tbl_interfascontabletipotrans_conf(IdTipo,Frm) VALUES (21,'Retiro Aporte de Socio')

-- ----------------------------
-- Table structure for tbl_retiro_ahorros_aportacion
-- ----------------------------
DROP TABLE IF EXISTS `tbl_retiro_ahorros_aportacion`;
CREATE TABLE `tbl_retiro_ahorros_aportacion` (
  `ID` int(11) NOT NULL auto_increment,
  `IDSocio` int(11) default NULL,
  `Fecha` datetime default NULL,
  `Monto` double(12,2) default NULL,
  `Concepto` varchar(255) default NULL,
  `IDCaja` int(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;


-- agregar nuevos permisos 
ALTER TABLE tbl_userahorros ADD COLUMN CambiarFechaRetiroAporte VARCHAR(5) default 'true' ;

-- Agregar nueva cuenta aportaciones
ALTER TABLE tbl_interfascontableotras ADD COLUMN CtaAportacionSocio VARCHAR(10) default '300-00-01' ;

-- Agregar nuevos campos a cheke
ALTER TABLE tbl_cheques ADD COLUMN CkSocio VARCHAR(5) default  'false' ;
ALTER TABLE tbl_cheques ADD COLUMN CkProveedor VARCHAR(5) default  'false' ;
ALTER TABLE tbl_cheques ADD COLUMN CkManual VARCHAR(5) default  'false' ;
ALTER TABLE tbl_cheques ADD COLUMN RetCtaAhorro VARCHAR(5) default  'false' ;
ALTER TABLE tbl_cheques ADD COLUMN RetCtaAportacion VARCHAR(5) default  'false' ;
ALTER TABLE tbl_cheques ADD COLUMN RetCtaNinguno VARCHAR(5) default  'false' ;

ALTER TABLE tbl_cheques ADD COLUMN NoCta VARCHAR(10) default  '0' ;
ALTER TABLE tbl_cheques ADD COLUMN IDSocio INT(11) default  '0' ;
ALTER TABLE tbl_cheques ADD COLUMN IDProveedor INT(11) default  '0' ;
ALTER TABLE tbl_cheques ADD COLUMN IDRetiroAhorro INT(11) default  '0' ;
ALTER TABLE tbl_cheques ADD COLUMN IDRetiroAportacion INT(11) default  '0' ;

-- Agregar nuevos campos a solicitud cheke
ALTER TABLE tbl_cheques_solicitud ADD COLUMN CkSocio VARCHAR(5) default  'false' ;
ALTER TABLE tbl_cheques_solicitud ADD COLUMN CkProveedor VARCHAR(5) default  'false' ;
ALTER TABLE tbl_cheques_solicitud ADD COLUMN CkManual VARCHAR(5) default  'false' ;
ALTER TABLE tbl_cheques_solicitud ADD COLUMN RetCtaAhorro VARCHAR(5) default  'false' ;
ALTER TABLE tbl_cheques_solicitud ADD COLUMN RetCtaAportacion VARCHAR(5) default  'false' ;
ALTER TABLE tbl_cheques_solicitud ADD COLUMN RetCtaNinguno VARCHAR(5) default  'false' ;

ALTER TABLE tbl_cheques_solicitud ADD COLUMN NoCta VARCHAR(10) default  '0' ;
ALTER TABLE tbl_cheques_solicitud ADD COLUMN IDSocio INT(11) default  '0' ;
ALTER TABLE tbl_cheques_solicitud ADD COLUMN IDProveedor INT(11) default  '0' ;
