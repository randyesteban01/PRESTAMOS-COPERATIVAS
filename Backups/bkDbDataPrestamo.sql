-- MySQL dump 10.11
--
-- Host: localhost    Database: dbdataprestamos
-- ------------------------------------------------------
-- Server version	5.0.51b-community-nt

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary table structure for view `_viewlibretadepositos`
--

DROP TABLE IF EXISTS `_viewlibretadepositos`;
/*!50001 DROP VIEW IF EXISTS `_viewlibretadepositos`*/;
/*!50001 CREATE TABLE `_viewlibretadepositos` (
  `fecha` date,
  `Depositos` decimal(12,4),
  `Intereses` decimal(12,4),
  `Balance` decimal(12,4),
  `Cajero` varchar(100),
  `Descripcion` varchar(150),
  `idcliente` int(11),
  `fld_FullName` varchar(255),
  `CuentaNo` varchar(15)
) */;

--
-- Table structure for table `almacen`
--

DROP TABLE IF EXISTS `almacen`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `almacen` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `almacen`
--

LOCK TABLES `almacen` WRITE;
/*!40000 ALTER TABLE `almacen` DISABLE KEYS */;
INSERT INTO `almacen` VALUES (1,'LOCAL');
/*!40000 ALTER TABLE `almacen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cajaarqueo`
--

DROP TABLE IF EXISTS `cajaarqueo`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `cajaarqueo` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_fecha` date default NULL,
  `fld_estacion` varchar(255) default NULL,
  `fld_usuario` varchar(255) default NULL,
  `TextBox1` double(12,2) default NULL,
  `TextBox2` double(12,2) default NULL,
  `TextBox3` double(12,2) default NULL,
  `TextBox4` double(12,2) default NULL,
  `TextBox5` double(12,2) default NULL,
  `TextBox6` double(12,2) default NULL,
  `TextBox7` double(12,2) default NULL,
  `TextBox8` double(12,2) default NULL,
  `TextBox9` double(12,2) default NULL,
  `TextBox10` double(12,2) default NULL,
  `TextBox11` double(12,2) default NULL,
  `TextBox12` double(12,2) default NULL,
  `TextBox13` double(12,2) default NULL,
  `TextBox1_1` double(12,2) default NULL,
  `TextBox1_2` double(12,2) default NULL,
  `TextBox1_3` double(12,2) default NULL,
  `TextBox1_4` double(12,2) default NULL,
  `TextBox1_5` double(12,2) default NULL,
  `TextBox1_6` double(12,2) default NULL,
  `TextBox1_7` double(12,2) default NULL,
  `TextBox1_8` double(12,2) default NULL,
  `TextBox1_9` double(12,2) default NULL,
  `TextBox1_10` double(12,2) default NULL,
  `TextBox1_11` double(12,2) default NULL,
  `TextBox1_12` double(12,2) default NULL,
  `TextBox1_13` double(12,2) default NULL,
  `TextBox14` double(12,2) default NULL,
  `TextBox15` double(12,2) default NULL,
  `TextBox16` double(12,2) default NULL,
  `TextBox17` double(12,2) default NULL,
  `fld_cheques` double(12,2) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `cajaarqueo`
--

LOCK TABLES `cajaarqueo` WRITE;
/*!40000 ALTER TABLE `cajaarqueo` DISABLE KEYS */;
/*!40000 ALTER TABLE `cajaarqueo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cajamantenimiento`
--

DROP TABLE IF EXISTS `cajamantenimiento`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `cajamantenimiento` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` char(100) default NULL,
  `CtaContable` char(50) default NULL,
  `Orden` int(1) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `cajamantenimiento`
--

LOCK TABLES `cajamantenimiento` WRITE;
/*!40000 ALTER TABLE `cajamantenimiento` DISABLE KEYS */;
INSERT INTO `cajamantenimiento` VALUES (1,'CAJA GENERAL','100-00-01',-1),(2,'CAJA CHICA','100-01-01',0);
/*!40000 ALTER TABLE `cajamantenimiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cb_tbl_maestro_concepto`
--

DROP TABLE IF EXISTS `cb_tbl_maestro_concepto`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `cb_tbl_maestro_concepto` (
  `fld_id_mc` int(11) NOT NULL auto_increment,
  `fld_creado_mc` datetime default NULL,
  `fld_cta_mc` varchar(50) default 'N/A',
  `fld_id_doc` int(11) default NULL,
  `fld_cod_concepto` longblob,
  `fld_categoria_mc` varchar(255) default 'N/A',
  PRIMARY KEY  (`fld_id_mc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `cb_tbl_maestro_concepto`
--

LOCK TABLES `cb_tbl_maestro_concepto` WRITE;
/*!40000 ALTER TABLE `cb_tbl_maestro_concepto` DISABLE KEYS */;
/*!40000 ALTER TABLE `cb_tbl_maestro_concepto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clienteestadocuenta`
--

DROP TABLE IF EXISTS `clienteestadocuenta`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `clienteestadocuenta` (
  `ID` int(11) NOT NULL auto_increment,
  `Fecha` datetime default NULL,
  `FechaMov` date default NULL,
  `IDCliente` int(11) default '0',
  `IDVehiculo` int(11) default '0',
  `Debito` decimal(12,2) default '0.00',
  `Credito` decimal(12,2) default '0.00',
  `IDMovimiento` int(11) default '0',
  `Movimiento` varchar(150) default '0',
  `Detalle` varchar(1000) default '0',
  `Usuario` varchar(255) default '0',
  `IDFinanciamiento` int(11) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `clienteestadocuenta`
--

LOCK TABLES `clienteestadocuenta` WRITE;
/*!40000 ALTER TABLE `clienteestadocuenta` DISABLE KEYS */;
/*!40000 ALTER TABLE `clienteestadocuenta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clienteestadocuentatraspaso`
--

DROP TABLE IF EXISTS `clienteestadocuentatraspaso`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `clienteestadocuentatraspaso` (
  `ID` int(11) NOT NULL auto_increment,
  `Fecha` datetime default NULL,
  `FechaMov` date default NULL,
  `IDCliente` int(11) default '0',
  `IDVehiculo` int(11) default '0',
  `Debito` decimal(12,2) default '0.00',
  `Credito` decimal(12,2) default '0.00',
  `IDMovimiento` int(11) default '0',
  `Movimiento` varchar(150) default '0',
  `Detalle` varchar(1000) default '0',
  `Usuario` varchar(255) default '0',
  `IDFinanciamiento` int(11) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `clienteestadocuentatraspaso`
--

LOCK TABLES `clienteestadocuentatraspaso` WRITE;
/*!40000 ALTER TABLE `clienteestadocuentatraspaso` DISABLE KEYS */;
/*!40000 ALTER TABLE `clienteestadocuentatraspaso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cobrador`
--

DROP TABLE IF EXISTS `cobrador`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `cobrador` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  `Comision` decimal(12,2) default '0.00',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `cobrador`
--

LOCK TABLES `cobrador` WRITE;
/*!40000 ALTER TABLE `cobrador` DISABLE KEYS */;
INSERT INTO `cobrador` VALUES (1,'LOCAL','0.00');
/*!40000 ALTER TABLE `cobrador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enumerador`
--

DROP TABLE IF EXISTS `enumerador`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `enumerador` (
  `ID` int(11) NOT NULL auto_increment,
  `Tipo` varchar(50) default NULL,
  `Secuencia` int(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `enumerador`
--

LOCK TABLES `enumerador` WRITE;
/*!40000 ALTER TABLE `enumerador` DISABLE KEYS */;
INSERT INTO `enumerador` VALUES (1,'VentaContado',1011);
/*!40000 ALTER TABLE `enumerador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fld_tipo_ingresos`
--

DROP TABLE IF EXISTS `fld_tipo_ingresos`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `fld_tipo_ingresos` (
  `fld_id_tipo_ingresos` int(11) NOT NULL auto_increment,
  `fld_descripcion_tipo_ingresos` text,
  PRIMARY KEY  (`fld_id_tipo_ingresos`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `fld_tipo_ingresos`
--

LOCK TABLES `fld_tipo_ingresos` WRITE;
/*!40000 ALTER TABLE `fld_tipo_ingresos` DISABLE KEYS */;
/*!40000 ALTER TABLE `fld_tipo_ingresos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formapago`
--

DROP TABLE IF EXISTS `formapago`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `formapago` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `formapago`
--

LOCK TABLES `formapago` WRITE;
/*!40000 ALTER TABLE `formapago` DISABLE KEYS */;
INSERT INTO `formapago` VALUES (1,'EFECTIVO'),(2,'CHEQUE'),(3,'DEPOSITO'),(4,'TRANSFERENCIA'),(5,'OTROS');
/*!40000 ALTER TABLE `formapago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inicialadiocionales`
--

DROP TABLE IF EXISTS `inicialadiocionales`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `inicialadiocionales` (
  `ID` int(11) NOT NULL auto_increment,
  `tipo` varchar(255) default NULL,
  `fecha` date default NULL,
  `monto` decimal(12,2) default NULL,
  `IDPrestamo` int(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `inicialadiocionales`
--

LOCK TABLES `inicialadiocionales` WRITE;
/*!40000 ALTER TABLE `inicialadiocionales` DISABLE KEYS */;
/*!40000 ALTER TABLE `inicialadiocionales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `moneda`
--

DROP TABLE IF EXISTS `moneda`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `moneda` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  `tasa` decimal(12,2) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `moneda`
--

LOCK TABLES `moneda` WRITE;
/*!40000 ALTER TABLE `moneda` DISABLE KEYS */;
INSERT INTO `moneda` VALUES (1,'PESOS','0.00'),(2,'DOLLAR','47.58');
/*!40000 ALTER TABLE `moneda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ncf`
--

DROP TABLE IF EXISTS `ncf`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `ncf` (
  `ID` int(11) NOT NULL auto_increment,
  `IDTipo` int(11) default NULL,
  `FechaCreado` date default NULL,
  `Prefijo` varchar(25) default NULL,
  `Empieza` double(12,0) default NULL,
  `Termina` double(12,0) default NULL,
  `SecuenciaActual` double(12,0) default NULL,
  `Estado` varchar(50) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `ncf`
--

LOCK TABLES `ncf` WRITE;
/*!40000 ALTER TABLE `ncf` DISABLE KEYS */;
/*!40000 ALTER TABLE `ncf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ncftipo`
--

DROP TABLE IF EXISTS `ncftipo`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `ncftipo` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  `Tipo` varchar(25) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `ncftipo`
--

LOCK TABLES `ncftipo` WRITE;
/*!40000 ALTER TABLE `ncftipo` DISABLE KEYS */;
INSERT INTO `ncftipo` VALUES (1,'Comprobantes Gubernamentales','ventacompra'),(2,'Comprobantes especiales de tributaciÃ³n','ventacompra'),(3,'Facturas con Valor de CrÃ©dito Fiscal','ventacompra'),(4,'Facturas a Consumidores Finales','ventacompra'),(5,'Notas de DÃ©bito','notadebito'),(6,'Notas de CrÃ©dito','notacredito'),(7,'Proveedores Informales','prov.infor.'),(8,'Registro Ãšnico de Ingreso','unicoingreso'),(9,'Gastos Menores','gastomenor');
/*!40000 ALTER TABLE `ncftipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parametrosgenerales`
--

DROP TABLE IF EXISTS `parametrosgenerales`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `parametrosgenerales` (
  `ID` int(11) NOT NULL auto_increment,
  `DispPignorada` decimal(12,2) default '0.00',
  `VistaPreviaImpresion` int(11) default '0',
  `DiasGracias` int(11) NOT NULL default '0',
  `TasaInteres` double(12,2) NOT NULL default '0.00',
  `Mora` decimal(12,2) NOT NULL default '0.00',
  `TipoImpresoraRI` char(50) NOT NULL default 'Normal',
  `VersionPublicacionSistema` varchar(100) default '01.00.00.000',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `parametrosgenerales`
--

LOCK TABLES `parametrosgenerales` WRITE;
/*!40000 ALTER TABLE `parametrosgenerales` DISABLE KEYS */;
INSERT INTO `parametrosgenerales` VALUES (1,'2.00',1,1,2.50,'3.00','Normal','01.00.00.002');
/*!40000 ALTER TABLE `parametrosgenerales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `solicitudcredito`
--

DROP TABLE IF EXISTS `solicitudcredito`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `solicitudcredito` (
  `Id` int(11) NOT NULL auto_increment,
  `FechaCreada` datetime default NULL,
  `FechaAprobacion` datetime default NULL,
  `CreadoPor` int(11) default NULL,
  `AprobadoPOr` int(11) default NULL,
  `Clasificacion` varchar(75) default NULL,
  `Condicion` varchar(75) default NULL,
  `FechaInicio` date default NULL,
  `MontoSolicitado` decimal(12,2) NOT NULL default '0.00',
  `Seguro` decimal(12,2) NOT NULL default '0.00',
  `Montolegal` decimal(12,2) NOT NULL default '0.00',
  `Monto` decimal(12,2) default NULL,
  `Interes` decimal(12,2) default NULL,
  `CantCuotas` smallint(11) default NULL,
  `MontoCuotas` decimal(12,2) default NULL,
  `Notas` varchar(1024) default NULL,
  `Socio` int(11) default NULL,
  `SocioExistente` int(11) NOT NULL default '0',
  `Estado` char(25) default 'Nueva',
  `cedula` varchar(14) default NULL,
  `direccion` varchar(255) default NULL,
  `provincia` varchar(20) default NULL,
  `municipio` varchar(20) default NULL,
  `barrio` varchar(20) default NULL,
  `phone` varchar(13) default NULL,
  `phone2` varchar(13) default NULL,
  `casa_propia` char(2) default NULL,
  `tiempo_casa` smallint(6) default NULL,
  `casa_alquiler` char(2) default NULL,
  `tiempo_alquiler` smallint(6) default NULL,
  `correo` varchar(255) default NULL,
  `empresa` varchar(50) default NULL,
  `phone3` varchar(13) default NULL,
  `empresa_agno` smallint(6) default NULL,
  `empresa_meses` smallint(6) default NULL,
  `nomconyugue` varchar(50) default NULL,
  `phone4` varchar(13) default NULL,
  `nomflia` varchar(50) default NULL,
  `phone5` varchar(13) default NULL,
  `codeudor` varchar(50) default NULL,
  `phone6` varchar(13) default NULL,
  PRIMARY KEY  (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `solicitudcredito`
--

LOCK TABLES `solicitudcredito` WRITE;
/*!40000 ALTER TABLE `solicitudcredito` DISABLE KEYS */;
/*!40000 ALTER TABLE `solicitudcredito` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `solicitudcreditocliente`
--

DROP TABLE IF EXISTS `solicitudcreditocliente`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `solicitudcreditocliente` (
  `fld_id` int(11) NOT NULL auto_increment,
  `TipoDocumento` int(11) default '1',
  `fld_FullName` varchar(255) default NULL,
  `fld_apodo` varchar(55) default 'N/A',
  `fld_Identity` varchar(13) default NULL,
  `fld_Phone` varchar(255) default '809-000-0000',
  `fld_Phone2` varchar(255) default '809-000-0000',
  `fld_Address` varchar(255) default NULL,
  `fld_City_id` int(11) default '0',
  `fld_City` varchar(55) default 'Nagua',
  `fld_Status` varchar(6) default 'N',
  `fld_bce` double(11,2) default '0.00',
  `fld_cod_zona` int(11) default '1',
  `fld_zona` varchar(255) default 'N/A',
  `fld_nombre_con` varchar(55) default 'N/A',
  `fld_apodo_con` varchar(55) default 'N/A',
  `fld_cedula_con` varchar(13) default '000-0000000-0',
  `fld_telefono_con` varchar(14) default '809-000-0000',
  `fld_celular_con` varchar(13) default '809-000-0000',
  `fld_ref_personales_cliente` varchar(510) default 'N/A',
  `fld_ref_comerciales_cliente` varchar(510) default 'N/A',
  `fld_nombre_gar` varchar(55) default 'N/A',
  `fld_apodo_gar` varchar(55) default 'N/A',
  `fld_cedula_gar` varchar(13) default '0',
  `fld_telefono_gar` varchar(13) default '809-000-0000',
  `fld_celular_gar` varchar(13) default '809-000-0000',
  `fld_direccion_gar` varchar(255) default 'N/A',
  `fld_ciudad_gar` varchar(55) default 'N/A',
  `fld_ref_personales_gar` varchar(510) default 'N/A',
  `fld_ref_comerciales_gar` varchar(510) default 'N/A',
  `fld_ingresos_mesuales` double(12,2) default '0.00',
  `fld_nombre_banco1` varchar(1000) default 'N/A',
  `fld_cuenta_banco1` varchar(15) default 'N/A',
  `fld_nombre_banco2` varchar(1000) default 'N/A',
  `fld_cuenta_banco2` varchar(15) default 'N/A',
  `fld_otra_informacion` varchar(1000) default 'N/A',
  `fld_nombre_con_gar` varchar(55) default 'N/A',
  `fld_apodo_con_gar` varchar(55) default 'N/A',
  `fld_cedula_con_gar` varchar(13) default '0',
  `fld_telefono_con_gar` varchar(13) default '809-000-0000',
  `fld_celular_con_gar` varchar(13) default '809-000-0000',
  `fld_edad` date default '2020-01-01',
  `fld_estado_civil` varchar(15) default 'N/A',
  `fld_edad_gar` int(11) default '0',
  `fld_estado_civil_gar` varchar(15) default 'N/A',
  `fld_ocupacion_cliente` varchar(55) default 'N/A',
  `fld_ocupacion_gar` varchar(55) default 'N/A',
  `fld_sector_id` int(11) default '0',
  `fld_sector` varchar(255) default 'N/A',
  `fld_categoria` varchar(25) default 'BUENO',
  `fld_limite` double(12,2) default '0.00',
  `Puesto` varchar(100) default 'N/A',
  `TimpoTrabajo` varchar(100) default 'N/A',
  `ReferidoPor` varchar(100) default 'N/A',
  `Oriundo` varchar(100) default 'N/A',
  `DataCredito` int(1) default '0',
  `ctaContable` char(200) default '0',
  `email` varchar(255) default '@',
  `fechaIngreso` date default '2020-01-01',
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `solicitudcreditocliente`
--

LOCK TABLES `solicitudcreditocliente` WRITE;
/*!40000 ALTER TABLE `solicitudcreditocliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `solicitudcreditocliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `solicitudcreditonota`
--

DROP TABLE IF EXISTS `solicitudcreditonota`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `solicitudcreditonota` (
  `Id` int(11) NOT NULL auto_increment,
  `Fecha` datetime default NULL,
  `IdSolicitud` int(11) default NULL,
  `IdUser` int(11) default NULL,
  `Nota` varchar(2048) default NULL,
  `comentario_Officer_negocio` varchar(255) default NULL,
  `comentario_enc_negocio` varchar(255) default NULL,
  `comentario_analista_de_credito` varchar(255) default NULL,
  PRIMARY KEY  (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `solicitudcreditonota`
--

LOCK TABLES `solicitudcreditonota` WRITE;
/*!40000 ALTER TABLE `solicitudcreditonota` DISABLE KEYS */;
/*!40000 ALTER TABLE `solicitudcreditonota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_adicionales`
--

DROP TABLE IF EXISTS `tbl_adicionales`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_adicionales` (
  `fldCodigo` int(11) NOT NULL auto_increment,
  `fldFecha` date default NULL,
  `fldMonto` double(12,2) default '0.00',
  `fldIdPrest` int(11) default '0',
  `fldEstacion` varchar(255) default 'N/A',
  PRIMARY KEY  (`fldCodigo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_adicionales`
--

LOCK TABLES `tbl_adicionales` WRITE;
/*!40000 ALTER TABLE `tbl_adicionales` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_adicionales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ahorros`
--

DROP TABLE IF EXISTS `tbl_ahorros`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_ahorros` (
  `ID` int(11) NOT NULL auto_increment,
  `CuentaNo` varchar(20) default '000000',
  `IDCliente` int(11) default '0',
  `Categoria` int(11) default '0',
  `FechaInicia` date default NULL,
  `Meses` double(12,2) default '0.00',
  `FechaTermina` date default NULL,
  `ModoPagoInteres` varchar(20) default 'NO CAPITALIZABLE',
  `TasaInteres` decimal(12,2) default '0.00',
  `Penalizar` varchar(2) default 'SI',
  `PorcientoAPenalizar` double(12,2) default '0.00',
  `Monto` decimal(12,2) default '0.00',
  `Saldo` decimal(12,2) default '0.00',
  `SaldoInteres` decimal(12,2) default '0.00',
  `Usuario` varchar(255) default '0',
  `Notas` varchar(550) default 'N/A',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_ahorros`
--

LOCK TABLES `tbl_ahorros` WRITE;
/*!40000 ALTER TABLE `tbl_ahorros` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ahorros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ahorros_aportacion`
--

DROP TABLE IF EXISTS `tbl_ahorros_aportacion`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_ahorros_aportacion` (
  `ID` int(11) NOT NULL auto_increment,
  `IDSocio` int(11) default NULL,
  `Fecha` datetime default NULL,
  `Monto` double(12,2) default NULL,
  `Concepto` varchar(255) default NULL,
  `IDCaja` int(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_ahorros_aportacion`
--

LOCK TABLES `tbl_ahorros_aportacion` WRITE;
/*!40000 ALTER TABLE `tbl_ahorros_aportacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ahorros_aportacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ahorros_categorias`
--

DROP TABLE IF EXISTS `tbl_ahorros_categorias`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_ahorros_categorias` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(150) default NULL,
  `tasaCuenta` decimal(10,2) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_ahorros_categorias`
--

LOCK TABLES `tbl_ahorros_categorias` WRITE;
/*!40000 ALTER TABLE `tbl_ahorros_categorias` DISABLE KEYS */;
INSERT INTO `tbl_ahorros_categorias` VALUES (2,'CORPORATIVOS ','0.00'),(6,'CRESCOOP KID ','0.00');
/*!40000 ALTER TABLE `tbl_ahorros_categorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ahorros_certificado`
--

DROP TABLE IF EXISTS `tbl_ahorros_certificado`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_ahorros_certificado` (
  `ID` int(11) NOT NULL auto_increment,
  `IDCliente` int(11) default NULL,
  `CuentaNo` varchar(15) default NULL,
  `FechaApertura` date default NULL,
  `Tiempo` int(11) default '0',
  `FechaCancelada` date default NULL,
  `TasaIteres` decimal(12,4) default '0.0000',
  `SaldoCapital` decimal(12,4) default '0.0000',
  `SaldoInteres` decimal(12,4) default '0.0000',
  `SaldoRetiros` decimal(12,4) default '0.0000',
  `Usuario` varchar(100) default NULL,
  `Nota` varchar(550) default NULL,
  `Categoria` int(11) default '0',
  `Estado` varchar(50) default 'Activa',
  `IdCaja` int(11) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_ahorros_certificado`
--

LOCK TABLES `tbl_ahorros_certificado` WRITE;
/*!40000 ALTER TABLE `tbl_ahorros_certificado` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ahorros_certificado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ahorros_certificado_retiros`
--

DROP TABLE IF EXISTS `tbl_ahorros_certificado_retiros`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_ahorros_certificado_retiros` (
  `ID` int(11) NOT NULL auto_increment,
  `IDAhorro` int(11) default '0',
  `IDCliente` int(11) default '0',
  `Fecha` datetime default NULL,
  `Tipo` varchar(25) default 'Retiro de Interes',
  `Concepto` varchar(150) default '0',
  `Monto` decimal(12,2) default '0.00',
  `Usuario` varchar(255) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_ahorros_certificado_retiros`
--

LOCK TABLES `tbl_ahorros_certificado_retiros` WRITE;
/*!40000 ALTER TABLE `tbl_ahorros_certificado_retiros` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ahorros_certificado_retiros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ahorros_cuentas`
--

DROP TABLE IF EXISTS `tbl_ahorros_cuentas`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_ahorros_cuentas` (
  `ID` int(11) NOT NULL auto_increment,
  `IDCliente` int(11) default NULL,
  `CuentaNo` varchar(15) default NULL,
  `FechaApertura` date default NULL,
  `FechaCancelada` date default NULL,
  `TasaIteres` decimal(12,4) default '0.0000',
  `SaldoCapital` decimal(12,4) default '0.0000',
  `SaldoInteres` decimal(12,4) default '0.0000',
  `SaldoRetiros` decimal(12,4) default '0.0000',
  `Usuario` varchar(100) default NULL,
  `Nota` varchar(550) default NULL,
  `Categoria` int(11) default '0',
  `Estado` varchar(50) default 'Activa',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_ahorros_cuentas`
--

LOCK TABLES `tbl_ahorros_cuentas` WRITE;
/*!40000 ALTER TABLE `tbl_ahorros_cuentas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ahorros_cuentas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ahorros_depositos`
--

DROP TABLE IF EXISTS `tbl_ahorros_depositos`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_ahorros_depositos` (
  `ID` int(11) NOT NULL auto_increment,
  `Fecha` date default NULL,
  `IDCuenta` int(11) default NULL,
  `IDCliente` int(11) default NULL,
  `Monto` decimal(12,4) default NULL,
  `Notas` varchar(550) default NULL,
  `Usuario` varchar(100) default NULL,
  `IdCaja` int(11) default '0',
  `Dosmil` double(12,2) default '0.00',
  `Mil` double(12,2) default '0.00',
  `Quiniento` double(12,2) default '0.00',
  `DosCiento` double(12,2) default '0.00',
  `Cien` double(12,2) default '0.00',
  `Cincuenta` double(12,2) default '0.00',
  `Veinticinco` double(12,2) default '0.00',
  `Diez` double(12,2) default '0.00',
  `Cinco` double(12,2) default '0.00',
  `Cheque` double(12,2) default '0.00',
  `Uno` double(12,2) default '0.00',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_ahorros_depositos`
--

LOCK TABLES `tbl_ahorros_depositos` WRITE;
/*!40000 ALTER TABLE `tbl_ahorros_depositos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ahorros_depositos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ahorros_estados`
--

DROP TABLE IF EXISTS `tbl_ahorros_estados`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_ahorros_estados` (
  `ID` int(11) NOT NULL auto_increment,
  `IDCliente` int(11) default '0',
  `Fecha` datetime default NULL,
  `IDDocumento` int(11) default '0',
  `Documento` varchar(255) default 'n/a',
  `Ahorro` decimal(12,2) default '0.00',
  `Retiro` decimal(12,2) default '0.00',
  `Saldo` decimal(12,2) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_ahorros_estados`
--

LOCK TABLES `tbl_ahorros_estados` WRITE;
/*!40000 ALTER TABLE `tbl_ahorros_estados` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ahorros_estados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ahorros_prefijos_cta`
--

DROP TABLE IF EXISTS `tbl_ahorros_prefijos_cta`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_ahorros_prefijos_cta` (
  `ID` int(11) NOT NULL auto_increment,
  `Categoria` int(11) default NULL,
  `PreFijo` varchar(6) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_ahorros_prefijos_cta`
--

LOCK TABLES `tbl_ahorros_prefijos_cta` WRITE;
/*!40000 ALTER TABLE `tbl_ahorros_prefijos_cta` DISABLE KEYS */;
INSERT INTO `tbl_ahorros_prefijos_cta` VALUES (1,1,'1'),(2,2,'2'),(3,3,'3'),(4,4,'4'),(5,5,'5'),(6,6,'6');
/*!40000 ALTER TABLE `tbl_ahorros_prefijos_cta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ahorros_retiros`
--

DROP TABLE IF EXISTS `tbl_ahorros_retiros`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_ahorros_retiros` (
  `ID` int(11) NOT NULL auto_increment,
  `IDAhorro` int(11) default '0',
  `IDCliente` int(11) default '0',
  `Fecha` datetime default NULL,
  `Tipo` varchar(25) default 'Retiro de Interes',
  `Concepto` varchar(150) default '0',
  `Monto` decimal(12,2) default '0.00',
  `Usuario` varchar(255) default '0',
  `IdCaja` int(11) default '0',
  `dosMil` double(12,2) default '0.00',
  `Mil` double(12,2) default '0.00',
  `Quiniento` double(12,2) default '0.00',
  `Dosciento` double(12,2) default '0.00',
  `Cien` double(12,2) default '0.00',
  `Cincuenta` double(12,2) default '0.00',
  `Veinticinco` double(12,2) default '0.00',
  `Diez` double(12,2) default '0.00',
  `Cinco` double(12,2) default '0.00',
  `Cheque` double(12,2) default '0.00',
  `Uno` double(12,2) default '0.00',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_ahorros_retiros`
--

LOCK TABLES `tbl_ahorros_retiros` WRITE;
/*!40000 ALTER TABLE `tbl_ahorros_retiros` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_ahorros_retiros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_bancos`
--

DROP TABLE IF EXISTS `tbl_bancos`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_bancos` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_nombre` varchar(255) default NULL,
  `fld_cuenta` varchar(255) default NULL,
  `fld_cta_contable` varchar(255) default NULL,
  `fld_contacto` varchar(255) default NULL,
  `fld_sucursal` varchar(255) default NULL,
  `fld_balance` double(12,2) default NULL,
  `fld_status` varchar(255) default NULL,
  `fld_direccion` varchar(255) default NULL,
  `fld_codigo` varchar(255) default NULL,
  `fld_tt_ck` varchar(255) default NULL,
  `fld_tt_dep` varchar(255) default NULL,
  `fld_tt_nc` varchar(255) default NULL,
  `fld_tt_nd` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_bancos`
--

LOCK TABLES `tbl_bancos` WRITE;
/*!40000 ALTER TABLE `tbl_bancos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_bancos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_beneficiarios`
--

DROP TABLE IF EXISTS `tbl_beneficiarios`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_beneficiarios` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_beneficiario` varchar(300) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_beneficiarios`
--

LOCK TABLES `tbl_beneficiarios` WRITE;
/*!40000 ALTER TABLE `tbl_beneficiarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_beneficiarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_beneficiarios_aportes`
--

DROP TABLE IF EXISTS `tbl_beneficiarios_aportes`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_beneficiarios_aportes` (
  `IdBeneficiarios` int(11) NOT NULL auto_increment,
  `CodCliente` int(11) NOT NULL,
  `NombreBeneficiario` varchar(100) default 'N/A',
  `ParentescoBeneficiario` varchar(50) default 'N/A',
  `CedulaBeneficiario` varchar(16) default '000-0000000-00',
  `TelBeneficiario` varchar(13) default '000-000-0000',
  `CelularBeneficiario` varchar(13) default '000-000-0000',
  `WhatsappBeneficiario` varchar(13) default '000-000-0000',
  `NombreBeneficiario2` varchar(100) default 'N/A',
  `ParentescoBeneficiario2` varchar(50) default 'N/A',
  `CedulaBeneficiario2` varchar(16) default '000-000-0000',
  `TelBeneficiario2` varchar(13) default '000-000-0000',
  `CelularBeneficiario2` varchar(13) default '000-000-0000',
  `WhatsappBeneficiario2` varchar(13) default '000-000-0000',
  PRIMARY KEY  (`IdBeneficiarios`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_beneficiarios_aportes`
--

LOCK TABLES `tbl_beneficiarios_aportes` WRITE;
/*!40000 ALTER TABLE `tbl_beneficiarios_aportes` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_beneficiarios_aportes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_calculainteres`
--

DROP TABLE IF EXISTS `tbl_calculainteres`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_calculainteres` (
  `ID` int(11) NOT NULL auto_increment,
  `Fecha` date default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_calculainteres`
--

LOCK TABLES `tbl_calculainteres` WRITE;
/*!40000 ALTER TABLE `tbl_calculainteres` DISABLE KEYS */;
INSERT INTO `tbl_calculainteres` VALUES (1,'2023-03-03');
/*!40000 ALTER TABLE `tbl_calculainteres` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_capital_invertido`
--

DROP TABLE IF EXISTS `tbl_capital_invertido`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_capital_invertido` (
  `fld_id_capital_invertido` int(11) NOT NULL auto_increment,
  `fld_capital_incial` double(12,2) default NULL,
  `fld_movimiento_capital` double(12,2) default NULL,
  `fld_intereses_cobrados` double(12,2) default NULL,
  PRIMARY KEY  (`fld_id_capital_invertido`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_capital_invertido`
--

LOCK TABLES `tbl_capital_invertido` WRITE;
/*!40000 ALTER TABLE `tbl_capital_invertido` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_capital_invertido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_catalogo`
--

DROP TABLE IF EXISTS `tbl_catalogo`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_catalogo` (
  `ID` double default NULL,
  `CuentaNo` varchar(45) default NULL,
  `Descripcion` varchar(240) default NULL,
  `Grupo` double default NULL,
  `Tipo` varchar(30) default NULL,
  `Debito` decimal(12,2) default '0.00',
  `Credito` decimal(12,2) default '0.00',
  `Balance` decimal(12,2) default '0.00',
  `CtaControl` varchar(300) default NULL,
  `NombreMes` varchar(45) default '0',
  `NumeroMes` double default '1',
  `BalanceAnterior` decimal(14,0) default '0',
  `BalanceGeneral` varchar(6) default '0',
  `EstadoResultado` varchar(6) default '0',
  `OrdenEstadoResultado` varchar(6) default '0',
  `AccionEstatoResultado` varchar(3) default '0',
  `VerEnCero` varchar(6) default '0',
  `Fecha` datetime default NULL,
  `Usuario` varchar(75) default NULL,
  `Nivel` int(11) NOT NULL default '1'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_catalogo`
--

LOCK TABLES `tbl_catalogo` WRITE;
/*!40000 ALTER TABLE `tbl_catalogo` DISABLE KEYS */;
INSERT INTO `tbl_catalogo` VALUES (1,'1','ACTIVOS',1,'Cuenta','1085.33','0.00','1085.33','0','0',1,'0','SI','0','0','0','0','2020-09-18 10:17:51','ADMIN',1),(7,'10','ACTIVOS CORRIENTES',1,'Grupo','1085.33','0.00','1085.33','1','0',1,'0','SI','0','0','0','0','2020-09-18 10:19:51','ADMIN',1),(12,'100','EFECTIVO EN BANCO',1,'Grupo','1085.33','0.00','1085.33','10','0',1,'0','SI','0','0','0','0','2020-09-18 11:38:04','ADMIN',1),(13,'100-00','CAJA Y BOVEDAS',1,'Grupo','0.00','0.00','0.00','100','0',1,'0','NO','0','0','0','0','2020-09-18 11:46:01','ADMIN',1),(15,'100-00-01','Caja General',1,'Auxiliar','1085.33','0.00','1085.33','100-00','0',1,'0','NO','0','0','0','0','2020-09-18 11:56:08','ADMIN',1),(16,'100-00-02','BÃ³vedas',1,'Auxiliar','0.00','0.00','0.00','100-00','0',1,'0','NO','0','0','0','0','2020-09-18 11:56:19','ADMIN',1),(14,'100-01','CAJAS CHICAS',1,'Grupo','0.00','0.00','0.00','100','0',1,'0','NO','0','0','0','0','2020-09-18 11:47:32','ADMIN',1),(17,'100-01-01','Caja Chica Oficina',1,'Auxiliar','0.00','0.00','0.00','100-01','0',1,'0','SI','0','0','0','0','2020-09-18 12:33:05','ADMIN',1),(18,'100-01-02','Caja Chica Ahorro y CrÃ©ditos',1,'Auxiliar','0.00','0.00','0.00','100-01','0',1,'0','NO','0','0','0','0','2020-09-18 12:33:24','ADMIN',1),(19,'100-02','CAJA DOLARES',1,'Grupo','0.00','0.00','0.00','100','0',1,'0','NO','0','0','0','0','2020-09-21 07:30:51','ADMIN',1),(34,'100-02-01','Caja DÃ³lares',1,'Auxiliar','0.00','0.00','0.00','100-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:43:08','ADMIN',1),(35,'100-02-02','Prima Caja DÃ³lares',1,'Auxiliar','0.00','0.00','0.00','100-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:43:25','ADMIN',1),(20,'100-03','FONDOS DE OPERACIONES',1,'Grupo','0.00','0.00','0.00','100','0',1,'0','NO','0','0','0','0','2020-09-21 07:31:09','ADMIN',1),(36,'100-03-01','Fondo Operaciones Proyectos',1,'Auxiliar','0.00','0.00','0.00','100-03','0',1,'0','NO','0','0','0','0','2020-09-21 07:43:45','ADMIN',1),(37,'100-03-02','Fondo Operaciones Ahorro y CrÃ©dito',1,'Auxiliar','0.00','0.00','0.00','100-03','0',1,'0','NO','0','0','0','0','2020-09-21 07:43:56','ADMIN',1),(21,'100-04','BANCOS',1,'Grupo','0.00','0.00','0.00','100','0',1,'0','NO','0','0','0','0','2020-09-21 07:31:21','ADMIN',1),(38,'100-04-01','Banco Popular',1,'Auxiliar','0.00','0.00','0.00','100-04','0',1,'0','SI','0','0','0','0','2020-09-21 07:44:10','ADMIN',1),(39,'100-04-02','Banco de Reservas',1,'Auxiliar','0.00','0.00','0.00','100-04','0',1,'0','NO','0','0','0','0','2020-09-21 07:44:24','ADMIN',1),(40,'100-04-03','Banco',1,'Auxiliar','0.00','0.00','0.00','100-04','0',1,'0','NO','0','0','0','0','2020-09-21 07:44:32','ADMIN',1),(22,'101','CUENTAS DOCUMENTOS POR COBRAR',1,'Grupo','0.00','0.00','0.00','10','0',1,'0','NO','0','0','0','0','2020-09-21 07:32:11','ADMIN',1),(23,'101-00','CUENTAS POR COBRAR',1,'Grupo','0.00','0.00','0.00','101','0',1,'0','NO','0','0','0','0','2020-09-21 07:32:49','ADMIN',1),(24,'101-00-01','SERVICIOS CRESCOOP',1,'Grupo','0.00','0.00','0.00','101-00','0',1,'0','NO','0','0','0','0','2020-09-21 07:35:55','ADMIN',1),(41,'101-00-01-01','Supermercado',1,'Auxiliar','0.00','0.00','0.00','101-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:45:06','ADMIN',1),(42,'101-00-01-02','Farmacias',1,'Auxiliar','0.00','0.00','0.00','101-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:45:35','ADMIN',1),(43,'101-00-01-03','FerreterÃ­a',1,'Auxiliar','0.00','0.00','0.00','101-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:46:21','ADMIN',1),(44,'101-00-01-04','Tiendas',1,'Auxiliar','0.00','0.00','0.00','101-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:46:33','ADMIN',1),(25,'101-01','DOCUMENTOS POR COBRAR',1,'Grupo','0.00','0.00','0.00','101','0',1,'0','NO','0','0','0','0','2020-09-21 07:36:31','ADMIN',1),(26,'101-01-01','PRESTAMOS POR COBRAR CRESCOOP',1,'Grupo','0.00','0.00','0.00','101-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:36:56','ADMIN',1),(45,'101-01-01-01','PrÃ©stamos Normales',1,'Auxiliar','0.00','0.00','0.00','101-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:47:07','ADMIN',1),(46,'101-01-01-02','PrÃ©stamos Gerenciales',1,'Auxiliar','0.00','0.00','0.00','101-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:47:37','ADMIN',1),(47,'101-01-01-03','PrÃ©stamos Emergencia',1,'Auxiliar','0.00','0.00','0.00','101-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:47:54','ADMIN',1),(48,'101-01-01-04','PrÃ©stamos Servicios',1,'Auxiliar','0.00','0.00','0.00','101-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:48:06','ADMIN',1),(49,'101-01-01-05','PrÃ©stamos Escolares',1,'Auxiliar','0.00','0.00','0.00','101-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:48:18','ADMIN',1),(50,'101-01-01-06','PrÃ©stamos VehÃ­culos',1,'Auxiliar','0.00','0.00','0.00','101-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:48:29','ADMIN',1),(27,'101-01-02','PRESTAMOS ESPECIALES',1,'Grupo','0.00','0.00','0.00','101-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:37:17','ADMIN',1),(51,'101-01-02-01','PrÃ©stamos a Empresas Asociadas',1,'Auxiliar','0.00','0.00','0.00','101-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:48:49','ADMIN',1),(52,'101-01-02-02','PrÃ©stamos Funcionarios y Empleados',1,'Auxiliar','0.00','0.00','0.00','101-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:48:59','ADMIN',1),(53,'101-01-02-03','PrÃ©stamos',1,'Auxiliar','0.00','0.00','0.00','101-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:49:40','ADMIN',1),(28,'101-01-03','OTRAS CUENTAS POR COBRAR',1,'Grupo','0.00','0.00','0.00','101-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:37:36','ADMIN',1),(54,'101-01-03-01','Cheques Devueltos',1,'Auxiliar','0.00','0.00','0.00','101-01-03','0',1,'0','NO','0','0','0','0','2020-09-21 07:50:30','ADMIN',1),(55,'101-01-03-02','Intereses Vencidos Inversiones',1,'Auxiliar','0.00','0.00','0.00','101-01-03','0',1,'0','NO','0','0','0','0','2020-09-21 07:50:46','ADMIN',1),(29,'102','INVERSIONES',1,'Grupo','0.00','0.00','0.00','10','0',1,'0','NO','0','0','0','0','2020-09-21 07:38:07','ADMIN',1),(30,'102-00','CERTIFICADOS Y DEPOSITOS',1,'Grupo','0.00','0.00','0.00','102','0',1,'0','NO','0','0','0','0','2020-09-21 07:38:30','ADMIN',1),(31,'102-00-01','INSTITUCIONES FINANCIERAS',1,'Grupo','0.00','0.00','0.00','102-00','0',1,'0','NO','0','0','0','0','2020-09-21 07:38:57','ADMIN',1),(56,'102-00-01-01','Banco de Reservas',1,'Auxiliar','0.00','0.00','0.00','102-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:51:10','ADMIN',1),(57,'102-00-01-02','Banco Popular',1,'Auxiliar','0.00','0.00','0.00','102-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:51:23','ADMIN',1),(58,'102-00-01-03','Banco',1,'Auxiliar','0.00','0.00','0.00','102-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:51:33','ADMIN',1),(32,'102-01','ACCIONES Y MEMBRESIAS',1,'Grupo','0.00','0.00','0.00','102','0',1,'0','NO','0','0','0','0','2020-09-21 07:39:16','ADMIN',1),(33,'102-01-01','INSTITUCIONES RELACIONADAS',1,'Grupo','0.00','0.00','0.00','102-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:39:49','ADMIN',1),(59,'102-01-01-01','COOPSEGUROS',1,'Auxiliar','0.00','0.00','0.00','102-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:52:14','ADMIN',1),(60,'102-01-01-02','CONACOOP',1,'Auxiliar','0.00','0.00','0.00','102-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:52:26','ADMIN',1),(61,'103','ACTIVOS DIFERIDOS',1,'Grupo','0.00','0.00','0.00','1','0',1,'0','SI','0','0','0','0','2020-09-21 07:54:33','ADMIN',1),(62,'103-00','GASTOS ANTICIPADOS',1,'Grupo','0.00','0.00','0.00','103','0',1,'0','NO','0','0','0','0','2020-09-21 07:56:12','ADMIN',1),(63,'103-00-01','FIANZAS Y DEPOSITOS',1,'Grupo','0.00','0.00','0.00','103-00','0',1,'0','NO','0','0','0','0','2020-09-21 07:56:33','ADMIN',1),(66,'103-00-01-01','Fianzas EnergÃ­a ElÃ©ctrica',1,'Auxiliar','0.00','0.00','0.00','103-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:57:58','ADMIN',1),(67,'103-00-01-02','Fianzas Comunicaciones',1,'Auxiliar','0.00','0.00','0.00','103-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:58:09','ADMIN',1),(64,'103-00-02','SEGUROS Y CONTINGENCIAS',1,'Grupo','0.00','0.00','0.00','103-00','0',1,'0','NO','0','0','0','0','2020-09-21 07:57:01','ADMIN',1),(68,'103-00-02-01','Seguros a la Propiedad',1,'Auxiliar','0.00','0.00','0.00','103-00-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:58:26','ADMIN',1),(69,'103-00-02-02','Fianzas de Fidelidad',1,'Auxiliar','0.00','0.00','0.00','103-00-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:58:38','ADMIN',1),(65,'103-00-03','ORGANIZACIÃ“N Y CONSTITUCION',1,'Grupo','0.00','0.00','0.00','103-00','0',1,'0','NO','0','0','0','0','2020-09-21 07:57:31','ADMIN',1),(70,'103-00-03-01','OrganizaciÃ³n y ConstituciÃ³n',1,'Auxiliar','0.00','0.00','0.00','103-00-03','0',1,'0','SI','0','0','0','0','2020-09-21 07:58:51','ADMIN',1),(71,'103-00-03-02','Manuales Administrativos',1,'Auxiliar','0.00','0.00','0.00','103-00-03','0',1,'0','NO','0','0','0','0','2020-09-21 07:59:01','ADMIN',1),(72,'11','ACTIVOS FIJOS',1,'Grupo','0.00','0.00','0.00','1','0',1,'0','SI','0','0','0','0','2020-09-21 08:00:17','ADMIN',1),(73,'11-00','PROPIEDAD, PLANTA Y EQUIPOS',1,'Grupo','0.00','0.00','0.00','11','0',1,'0','NO','0','0','0','0','2020-09-21 08:01:34','ADMIN',1),(74,'11-00-01','TERRENOS',1,'Grupo','0.00','0.00','0.00','11-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:01:58','ADMIN',1),(78,'11-00-01-01','Terrenos',1,'Auxiliar','0.00','0.00','0.00','11-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 08:03:19','ADMIN',1),(75,'11-00-02','ACTIVOS CATEGORIA I',1,'Grupo','0.00','0.00','0.00','11-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:02:22','ADMIN',1),(79,'11-00-02-01','Edificaciones',1,'Auxiliar','0.00','0.00','0.00','11-00-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:03:32','ADMIN',1),(76,'11-00-03','ACTIVOS CATEGORIA II',1,'Grupo','0.00','0.00','0.00','11-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:02:44','ADMIN',1),(80,'11-00-03-01','Muebles de Oficina',1,'Auxiliar','0.00','0.00','0.00','11-00-03','0',1,'0','NO','0','0','0','0','2020-09-21 08:03:48','ADMIN',1),(81,'11-00-03-02','Equipos de CÃ³mputos',1,'Auxiliar','0.00','0.00','0.00','11-00-03','0',1,'0','SI','0','0','0','0','2020-09-21 08:04:01','ADMIN',1),(82,'11-00-03-03','Equipos de Transporte',1,'Auxiliar','0.00','0.00','0.00','11-00-03','0',1,'0','NO','0','0','0','0','2020-09-21 08:04:13','ADMIN',1),(83,'11-00-03-04','Equipos de Vigilancia',1,'Auxiliar','0.00','0.00','0.00','11-00-03','0',1,'0','NO','0','0','0','0','2020-09-21 08:04:23','ADMIN',1),(84,'11-00-03-05','Equipos Educativos',1,'Auxiliar','0.00','0.00','0.00','11-00-03','0',1,'0','NO','0','0','0','0','2020-09-21 08:04:34','ADMIN',1),(77,'11-00-04','CONSTRUCCION EN PROCESO',1,'Grupo','0.00','0.00','0.00','11-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:03:02','ADMIN',1),(85,'11-00-04-01','Edificaciones',1,'Auxiliar','0.00','0.00','0.00','11-00-04','0',1,'0','NO','0','0','0','0','2020-09-21 08:04:48','ADMIN',1),(86,'11-01','DEPRECIACION Y AMORTIZACION',1,'Grupo','0.00','0.00','0.00','11','0',1,'0','NO','0','0','0','0','2020-09-21 08:05:17','ADMIN',1),(87,'11-01-01','DEPRECIACION',1,'Grupo','0.00','0.00','0.00','11-01','0',1,'0','NO','0','0','0','0','2020-09-21 08:05:38','ADMIN',1),(89,'11-01-01-01','Activos CategorÃ­a I',1,'Auxiliar','0.00','0.00','0.00','11-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 08:06:10','ADMIN',1),(90,'11-01-01-02','Activos CategorÃ­a II',1,'Auxiliar','0.00','0.00','0.00','11-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 08:06:22','ADMIN',1),(88,'11-01-02','AMORTIZACION',1,'Grupo','0.00','0.00','0.00','11-01','0',1,'0','NO','0','0','0','0','2020-09-21 08:05:47','ADMIN',1),(91,'11-01-02-01','Sistema de InformaciÃ³n Contable',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:06:39','ADMIN',1),(92,'11-01-02-02','Manuales de AdministraciÃ³n',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:06:49','ADMIN',1),(93,'11-01-02-03','OrganizaciÃ³n y ConstituciÃ³n',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:08:23','ADMIN',1),(94,'11-01-02-04','Seguros',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:08:38','ADMIN',1),(95,'11-01-02-05','Fianzas',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:08:48','ADMIN',1),(96,'11-01-02-06','Cobros Anticipados',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:09:00','ADMIN',1),(2,'2','PASIVOS',2,'Cuenta','0.00','833.33','833.33','0','0',1,'0','SI','0','0','0','0','2020-09-18 10:18:12','ADMIN',1),(97,'20','PASIVOS CORRIENTES',2,'Grupo','0.00','833.33','833.33','2','0',1,'0','SI','0','0','0','0','2020-09-21 08:11:27','ADMIN',1),(98,'200','CUENTAS POR PAGAR',2,'Grupo','0.00','833.33','833.33','20','0',1,'0','SI','0','0','0','0','2020-09-21 08:11:48','ADMIN',1),(99,'200-00','AHORROS DE LOS ASOCIADOS',2,'Grupo','0.00','0.00','0.00','200','0',1,'0','NO','0','0','0','0','2020-09-21 08:12:05','ADMIN',1),(100,'200-01','DEPOSITOS A PLAZOS',2,'Grupo','0.00','0.00','0.00','200','0',1,'0','NO','0','0','0','0','2020-09-21 08:30:03','ADMIN',1),(101,'200-02','PROVEEDORES',2,'Grupo','0.00','0.00','0.00','200','0',1,'0','NO','0','0','0','0','2020-09-21 08:30:24','ADMIN',1),(102,'200-03','RETENCIONES Y ACUMULACIONES',2,'Grupo','0.00','0.00','0.00','200','0',1,'0','NO','0','0','0','0','2020-09-21 08:30:34','ADMIN',1),(103,'201','DOCUMENTOS POR PAGAR',2,'Grupo','0.00','0.00','0.00','20','0',1,'0','NO','0','0','0','0','2020-09-21 08:30:48','ADMIN',1),(104,'201-00','PRESTAMOS POR PAGAR',2,'Grupo','0.00','0.00','0.00','201','0',1,'0','NO','0','0','0','0','2020-09-21 08:31:10','ADMIN',1),(105,'201-01','DEPOSITOS A PLAZOS',2,'Grupo','0.00','0.00','0.00','201','0',1,'0','NO','0','0','0','0','2020-09-21 08:31:21','ADMIN',1),(106,'201-02','OTROS PASIVOS',2,'Grupo','0.00','0.00','0.00','201','0',1,'0','NO','0','0','0','0','2020-09-21 08:31:30','ADMIN',1),(3,'3','PATRIMONIO',3,'Cuenta','0.00','0.00','0.00','0','0',1,'0','SI','0','0','0','0','2020-09-18 10:18:33','ADMIN',1),(107,'30','PATRIMONIO, RESERVAS Y EXCEDENTES',3,'Grupo','0.00','0.00','0.00','3','0',1,'0','SI','0','0','0','0','2020-09-21 08:31:50','ADMIN',1),(108,'300','APORTACIONES',3,'Grupo','0.00','0.00','0.00','30','0',1,'0','SI','0','0','0','0','2020-09-21 08:36:05','ADMIN',1),(109,'300-00','SOCIOS',3,'Grupo','0.00','0.00','0.00','300','0',1,'0','NO','0','0','0','0','2020-09-21 08:36:29','ADMIN',1),(115,'300-00-01','Aportaciones de Socios.',3,'Auxiliar','0.00','0.00','0.00','300-00','0',1,'0','SI','0','0','0','0','2020-09-21 08:39:42','ADMIN',1),(116,'300-00-02','Aportaciones Relacionados',3,'Auxiliar','0.00','0.00','0.00','300-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:39:52','ADMIN',1),(117,'300-00-03','Aportaciones Empresas Relacionadas',3,'Auxiliar','0.00','0.00','0.00','300-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:40:02','ADMIN',1),(118,'300-00-04','Otros Aportes',3,'Auxiliar','0.00','0.00','0.00','300-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:40:14','ADMIN',1),(110,'300-01','APORTES INSTITUCIONALES',3,'Grupo','0.00','0.00','0.00','300','0',1,'0','NO','0','0','0','0','2020-09-21 08:36:47','ADMIN',1),(119,'300-01-01','Donaciones y Contribuciones',3,'Auxiliar','0.00','0.00','0.00','300-01','0',1,'0','NO','0','0','0','0','2020-09-21 08:40:39','ADMIN',1),(111,'301','EXCEDENTES',3,'Grupo','0.00','0.00','0.00','30','0',1,'0','SI','0','0','0','0','2020-09-21 08:37:44','ADMIN',1),(120,'301-00','Excedentes aÃ±os anteriores',3,'Auxiliar','0.00','0.00','0.00','301','0',1,'0','NO','0','0','0','0','2020-09-21 08:43:42','ADMIN',1),(121,'301-01','Excedentes Acumulados AÃ±os Anteriores',3,'Auxiliar','0.00','0.00','0.00','301','0',1,'0','NO','0','0','0','0','2020-09-21 08:44:06','ADMIN',1),(122,'301-02','Excedentes Capitalizados',3,'Auxiliar','0.00','0.00','0.00','301','0',1,'0','NO','0','0','0','0','2020-09-21 08:44:20','ADMIN',1),(123,'301-03','Ajustes AÃ±os Anteriores',3,'Auxiliar','0.00','0.00','0.00','301','0',1,'0','NO','0','0','0','0','2020-09-21 08:44:31','ADMIN',1),(124,'301-04','Excedentes del Periodo',3,'Auxiliar','0.00','0.00','0.00','301','0',1,'0','SI','0','0','0','0','2020-09-21 08:44:39','ADMIN',1),(112,'302','RESERVAS',3,'Grupo','0.00','0.00','0.00','30','0',1,'0','NO','0','0','0','0','2020-09-21 08:38:13','ADMIN',1),(113,'302-00','RESERVAS ESTATUTARIAS',3,'Grupo','0.00','0.00','0.00','302','0',1,'0','NO','0','0','0','0','2020-09-21 08:38:44','ADMIN',1),(125,'302-00-01','General',3,'Auxiliar','0.00','0.00','0.00','302-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:45:07','ADMIN',1),(126,'302-00-02','Educativa',3,'Auxiliar','0.00','0.00','0.00','302-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:45:16','ADMIN',1),(127,'302-00-03','Crecimiento',3,'Auxiliar','0.00','0.00','0.00','302-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:45:25','ADMIN',1),(128,'302-00-04','Ayuda Mutua',3,'Auxiliar','0.00','0.00','0.00','302-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:45:34','ADMIN',1),(129,'302-00-05','Aportaciones',3,'Auxiliar','0.00','0.00','0.00','302-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:45:45','ADMIN',1),(130,'302-00-06','AdquisiciÃ³n de Activos',3,'Auxiliar','0.00','0.00','0.00','302-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:45:55','ADMIN',1),(114,'302-01','ADQUISICION DE ACTIVOS',3,'Grupo','0.00','0.00','0.00','302','0',1,'0','NO','0','0','0','0','2020-09-21 08:39:12','ADMIN',1),(4,'4','INGRESOS',4,'Cuenta','0.00','252.00','252.00','0','0',1,'0','0','SI','0','0','0','2020-09-18 10:18:46','ADMIN',1),(131,'40','INGRESOS FINANCIEROS',4,'Grupo','0.00','252.00','252.00','4','0',1,'0','0','SI','0','0','0','2020-09-21 08:47:13','ADMIN',1),(132,'400','INGRESOS OPERACIONES',4,'Grupo','0.00','252.00','252.00','40','0',1,'0','0','SI','0','0','0','2020-09-21 08:47:38','ADMIN',1),(135,'400-00','Intereses de PrÃ©stamos Vigentes',4,'Auxiliar','0.00','250.00','250.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:49:19','ADMIN',1),(136,'400-01','Seguros de PrÃ©stamos',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:49:28','ADMIN',1),(137,'400-02','ComisiÃ³n por Mora',4,'Auxiliar','0.00','2.00','2.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:49:37','ADMIN',1),(138,'400-03','Comisiones de Pagos a Suplidores',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:49:46','ADMIN',1),(139,'400-04','Ingresos por Servicios Legales',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:49:54','ADMIN',1),(140,'400-05','RecuperaciÃ³n de Cartera',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:50:01','ADMIN',1),(141,'400-06','PrÃ©stamos Vencidos',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:50:13','ADMIN',1),(142,'400-07','Gastos Administrativos',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:50:23','ADMIN',1),(133,'401','INTERESES INVERSIONES EN VALORES',4,'Grupo','0.00','0.00','0.00','40','0',1,'0','0','SI','0','0','0','2020-09-21 08:48:19','ADMIN',1),(143,'401-00','INTERESES INVERSIONES',4,'Grupo','0.00','0.00','0.00','401','0',1,'0','0','NO','0','0','0','2020-09-21 08:50:57','ADMIN',1),(144,'401-00-01','DepÃ³sitos a Plazos',4,'Auxiliar','0.00','0.00','0.00','401-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:51:15','ADMIN',1),(145,'401-00-02','Cuentas Corrientes',4,'Auxiliar','0.00','0.00','0.00','401-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:51:29','ADMIN',1),(146,'401-00-03','Cuentas de Ahorros',4,'Auxiliar','0.00','0.00','0.00','401-00','0',1,'0','0','SI','0','0','0','2020-09-21 08:51:38','ADMIN',1),(147,'401-00-04','Acciones en Cooperativas',4,'Auxiliar','0.00','0.00','0.00','401-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:51:49','ADMIN',1),(134,'402','INGRESOS POR SERVICIOS',4,'Grupo','0.00','0.00','0.00','40','0',1,'0','0','NO','0','0','0','2020-09-21 08:48:45','ADMIN',1),(148,'402-00','CONSULTORIA Y ACESORIA',4,'Grupo','0.00','0.00','0.00','402','0',1,'0','0','NO','0','0','0','2020-09-21 08:52:58','ADMIN',1),(149,'402-00-01','EducaciÃ³n y CapacitaciÃ³n',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:53:23','ADMIN',1),(150,'402-00-02','AsesorÃ­a en Desarrollo',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:53:36','ADMIN',1),(151,'402-00-03','ElaboraciÃ³n y EjecuciÃ³n de Proyectos',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:53:46','ADMIN',1),(152,'402-00-04','Viajes y Eventos Educativos',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:54:10','ADMIN',1),(153,'402-00-05','Excursiones',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:55:15','ADMIN',1),(154,'402-00-06','Ventas de Ãštiles Educativos',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:55:25','ADMIN',1),(155,'402-00-07','Ventas Libros y Folletos',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:55:35','ADMIN',1),(5,'5','COSTOS OPERACIONALES',5,'Cuenta','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-18 10:18:56','ADMIN',1),(156,'50','COSTOS FINANCIEROS',5,'Grupo','0.00','0.00','0.00','5','0',1,'0','0','NO','0','0','0','2020-09-21 08:56:22','ADMIN',1),(157,'500','INTERESES DEPOSITOS A PLAZOS',5,'Grupo','0.00','0.00','0.00','50','0',1,'0','0','NO','0','0','0','2020-09-21 08:56:58','ADMIN',1),(160,'500-01','Intereses Pagados LÃ­neas de CrÃ©dito',5,'Auxiliar','0.00','0.00','0.00','500','0',1,'0','0','NO','0','0','0','2020-09-21 08:58:01','ADMIN',1),(161,'500-02','Intereses Pagados Ahorros San',5,'Auxiliar','0.00','0.00','0.00','500','0',1,'0','0','NO','0','0','0','2020-09-21 08:58:10','ADMIN',1),(162,'500-03','Intereses Pagados a Socios',5,'Auxiliar','0.00','0.00','0.00','500','0',1,'0','0','NO','0','0','0','2020-09-21 08:58:20','ADMIN',1),(163,'500-04','Intereses Pagados Ahorros Retirables',5,'Auxiliar','0.00','0.00','0.00','500','0',1,'0','0','NO','0','0','0','2020-09-21 08:58:29','ADMIN',1),(164,'500-05','Intereses Pagados AportaciÃ³n',5,'Auxiliar','0.00','0.00','0.00','500','0',1,'0','0','NO','0','0','0','2020-09-21 08:58:37','ADMIN',1),(165,'500-06','Penalidad Por CancelaciÃ³n De Certificado',5,'Auxiliar','0.00','0.00','0.00','500','0',1,'0','0','NO','0','0','0','2020-09-21 08:58:45','ADMIN',1),(158,'51','COSTOS DE LOS SERVICIOS',5,'Grupo','0.00','0.00','0.00','5','0',1,'0','0','NO','0','0','0','2020-09-21 08:57:12','ADMIN',1),(159,'510','COSTOS VARIADOS',5,'Grupo','0.00','0.00','0.00','51','0',1,'0','0','NO','0','0','0','2020-09-21 08:57:36','ADMIN',1),(166,'510-01','Compras Ãºtiles Escolares',5,'Auxiliar','0.00','0.00','0.00','510','0',1,'0','0','NO','0','0','0','2020-09-21 08:59:00','ADMIN',1),(167,'510-02','Publicidad y PromociÃ³n',5,'Auxiliar','0.00','0.00','0.00','510','0',1,'0','0','NO','0','0','0','2020-09-21 08:59:10','ADMIN',1),(6,'6','GASTOS',6,'Cuenta','0.00','0.00','0.00','0','0',1,'0','0','SI','0','0','0','2020-09-18 10:19:10','ADMIN',1),(168,'60','GENERALES Y ADMINISTRATIVOS',6,'Grupo','0.00','0.00','0.00','6','0',1,'0','0','SI','0','0','0','2020-09-21 09:00:25','ADMIN',1),(169,'600','REMUNERACION AL PERSONAL',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','NO','0','0','0','2020-09-21 09:00:52','ADMIN',1),(179,'600-01','Sueldos y Salarios',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:03:11','ADMIN',1),(180,'600-02','Horas Extras',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:03:18','ADMIN',1),(181,'600-03','Salario de Navidad',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:03:26','ADMIN',1),(182,'600-04','Seguros Familiar de Salud',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:03:35','ADMIN',1),(183,'600-05','Plan de Pensiones',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:04:58','ADMIN',1),(184,'600-06','Seguros Riesgos Laborales',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:05:08','ADMIN',1),(185,'600-07','Incentivos',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:30:38','ADMIN',1),(186,'600-08','Uniformes',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:30:45','ADMIN',1),(187,'600-09','Vacaciones',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:30:54','ADMIN',1),(188,'600-10','Prestaciones Laborales',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:31:20','ADMIN',1),(189,'600-11','Atenciones',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:31:28','ADMIN',1),(190,'600-12','Cursos y Entrenamientos',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:31:35','ADMIN',1),(191,'600-13','Bonificaciones',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:31:42','ADMIN',1),(192,'600-14','Seguro MÃ©dico',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:31:50','ADMIN',1),(193,'600-15','Dietas y Viajes',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:31:57','ADMIN',1),(194,'600-16','AsignaciÃ³n de VehÃ­culos',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:32:05','ADMIN',1),(195,'600-17','Combustibles y Lubricantes',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:32:18','ADMIN',1),(196,'600-99','Otras Remuneraciones',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:32:31','ADMIN',1),(170,'601','SERVICOS Y SUMINISTROS',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','NO','0','0','0','2020-09-21 09:01:04','ADMIN',1),(197,'601-01','BurÃ³ de CrÃ©dito',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:32:46','ADMIN',1),(198,'601-02','Comunicaciones',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:32:56','ADMIN',1),(199,'601-03','Refrigerios y Reuniones',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:06','ADMIN',1),(200,'601-04','Viajes y Transportes',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:17','ADMIN',1),(201,'601-05','EnergÃ­a ElÃ©ctrica',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:25','ADMIN',1),(202,'601-06','Agua y Basura',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:34','ADMIN',1),(203,'601-07','Alquileres',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:40','ADMIN',1),(204,'601-08','Cuotas y Suscripciones',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:48','ADMIN',1),(205,'601-09','Material Gastable',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:56','ADMIN',1),(206,'601-10','Seguridad y Vigilancia',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:34:07','ADMIN',1),(207,'601-11','Servicios TÃ©cnicos',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:34:15','ADMIN',1),(208,'601-12','Transportes y EnvÃ­os',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:34:53','ADMIN',1),(209,'601-13','Seguros a la Propiedad',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:35:36','ADMIN',1),(210,'601-14','Fianzas de Fidelidad',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:36:33','ADMIN',1),(171,'602','GOBERNABILIDAD',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','SI','0','0','0','2020-09-21 09:01:11','ADMIN',1),(211,'602-01','Reuniones ComitÃ© Ejecutivo',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:37:11','ADMIN',1),(212,'602-02','Reuniones Consejo de AdministraciÃ³n',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:37:30','ADMIN',1),(213,'602-03','Reuniones Consejo de Vigilancia',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:37:39','ADMIN',1),(214,'602-04','Reuniones ComitÃ© de CrÃ©dito',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:37:51','ADMIN',1),(215,'602-05','Asambleas Cooperativas Relacionadas',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:38:00','ADMIN',1),(216,'602-06','Asambleas Generales',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','SI','0','0','0','2020-09-21 09:38:11','ADMIN',1),(217,'602-07','Dietas y Viajes de Directivos',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:38:20','ADMIN',1),(218,'602-08','Representaciones',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:38:28','ADMIN',1),(219,'602-09','Donaciones y Contribuciones',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:38:54','ADMIN',1),(220,'602-10','Atenciones',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:39:03','ADMIN',1),(221,'602-11','Festejos y Celebraciones',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:39:24','ADMIN',1),(222,'602-12','Incentivos a Directivos',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:39:35','ADMIN',1),(223,'602-13','Seguros MÃ©dicos Directivos',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:39:45','ADMIN',1),(172,'603','GASTOS BANCARIOS',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','SI','0','0','0','2020-09-21 09:01:20','ADMIN',1),(224,'603-01','Cargos Ley 0.15%',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','SI','0','0','0','2020-09-21 09:40:01','ADMIN',1),(225,'603-02','CertificaciÃ³n de Cheques',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:40:09','ADMIN',1),(226,'603-03','Sobregiro Bancario',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:40:22','ADMIN',1),(227,'603-04','Manejo de Cuenta Bancaria',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','SI','0','0','0','2020-09-21 09:40:29','ADMIN',1),(228,'603-05','Comisiones por Transferencia Bancaria',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:40:37','ADMIN',1),(229,'603-06','ConfecciÃ³n de Cheques',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:40:46','ADMIN',1),(230,'603-07','Cargos y Comisiones Bancarias',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','SI','0','0','0','2020-09-21 09:40:54','ADMIN',1),(231,'603-08','RetenciÃ³n Estados Bancarios',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:41:04','ADMIN',1),(232,'603-09','ComisiÃ³n por Cheques Devueltos',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:41:12','ADMIN',1),(233,'603-10','Moras y Recargos',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:41:23','ADMIN',1),(173,'604','REPARACION Y MANTENIMIENTO',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','NO','0','0','0','2020-09-21 09:01:27','ADMIN',1),(234,'604-01','Mantenimientos Terrenos',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:41:35','ADMIN',1),(235,'604-02','Mantenimiento Equipos de Transporte',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:41:43','ADMIN',1),(236,'604-03','Mantenimientos Equipos de Oficina',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:41:51','ADMIN',1),(237,'604-04','Mantenimientos Equipos de CÃ³mputos',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:00','ADMIN',1),(238,'604-05','Mantenimientos Equipos de Seguridad',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:07','ADMIN',1),(239,'604-06','Mantenimiento del Local',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:15','ADMIN',1),(240,'604-07','Combustibles y Lubricantes',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:23','ADMIN',1),(241,'604-08','Placas y Revistas',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:33','ADMIN',1),(174,'605','RELACIONES PUBLICAS',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','NO','0','0','0','2020-09-21 09:01:37','ADMIN',1),(242,'605-01','PromociÃ³n y Publicidad',6,'Auxiliar','0.00','0.00','0.00','605','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:41','ADMIN',1),(243,'605-02','Atenciones a Socios y Relacionados',6,'Auxiliar','0.00','0.00','0.00','605','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:48','ADMIN',1),(175,'606','HONORARIOS E IMPUESTOS',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','SI','0','0','0','2020-09-21 09:01:48','ADMIN',1),(244,'606-01','Impuestos a la Propiedad',6,'Auxiliar','0.00','0.00','0.00','606','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:57','ADMIN',1),(245,'606-02','Honorarios Profesionales',6,'Auxiliar','0.00','0.00','0.00','606','0',1,'0','0','NO','0','0','0','2020-09-21 09:43:05','ADMIN',1),(246,'606-03','Honorarios Legales',6,'Auxiliar','0.00','0.00','0.00','606','0',1,'0','0','SI','0','0','0','2020-09-21 09:43:13','ADMIN',1),(176,'607','DEPRECIACION Y AMORTIZACION',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','NO','0','0','0','2020-09-21 09:01:57','ADMIN',1),(177,'607-01','Depreciaciones',6,'Auxiliar','0.00','0.00','0.00','607','0',1,'0','0','NO','0','0','0','2020-09-21 09:02:33','ADMIN',1),(247,'607-01-01','DepreciaciÃ³n Activos CategorÃ­a I',6,'Auxiliar','0.00','0.00','0.00','607-01','0',1,'0','0','NO','0','0','0','2020-09-21 09:43:29','ADMIN',1),(248,'607-01-02','DepreciaciÃ³n Activos CategorÃ­a II',6,'Auxiliar','0.00','0.00','0.00','607-01','0',1,'0','0','NO','0','0','0','2020-09-21 09:43:37','ADMIN',1),(178,'607-02','Amortizaciones',6,'Auxiliar','0.00','0.00','0.00','607','0',1,'0','0','NO','0','0','0','2020-09-21 09:02:45','ADMIN',1),(249,'607-02-01','Sistema de Contabilidad',6,'Auxiliar','0.00','0.00','0.00','607-02','0',1,'0','0','NO','0','0','0','2020-09-21 09:43:49','ADMIN',1),(250,'607-02-02','Pagina Web',6,'Auxiliar','0.00','0.00','0.00','607-02','0',1,'0','0','NO','0','0','0','2020-09-21 09:43:59','ADMIN',1),(251,'200-00-01','Ahorros a la Vista',2,'Auxiliar','0.00','833.33','833.33','200-00','0',1,'0','SI','0','0','0','0','2020-09-23 10:23:24','RANDY',1),(252,'200-00-02','Ahorro Juvenil',2,'Auxiliar','0.00','0.00','0.00','200-00','0',1,'0','NO','0','0','0','0','2020-09-23 10:28:21','RANDY',1),(253,'200-00-03','Ahorro NavideÃ±o',2,'Auxiliar','0.00','0.00','0.00','200-00','0',1,'0','NO','0','0','0','0','2020-09-23 10:28:46','RANDY',1),(254,'200-00-04','Ahorro Educativo',2,'Auxiliar','0.00','0.00','0.00','200-00','0',1,'0','NO','0','0','0','0','2020-09-23 10:29:11','RANDY',1),(255,'200-00-05','Ahorro Vacacional',2,'Auxiliar','0.00','0.00','0.00','200-00','0',1,'0','NO','0','0','0','0','2020-09-23 10:30:01','RANDY',1),(256,'200-01-01','Asociados',2,'Auxiliar','0.00','0.00','0.00','200-01','0',1,'0','NO','0','0','0','0','2020-09-23 10:31:52','RANDY',1),(257,'200-01-02','Institucionales',2,'Auxiliar','0.00','0.00','0.00','200-01','0',1,'0','NO','0','0','0','0','2020-09-23 10:32:10','RANDY',1),(258,'200-02-01','Servicios Profesionales',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:33:24','RANDY',1),(259,'200-02-02','Supermercados',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:33:47','RANDY',1),(260,'200-02-03','Tiendas y ElÃ©ctrodomÃ©sticos',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:34:36','RANDY',1),(261,'200-02-04','Farmacias',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:35:13','RANDY',1),(262,'200-02-05','FerreterÃ­as',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:35:43','RANDY',1),(263,'200-03-01','Sueldos y Salarios',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:37:54','RANDY',1),(264,'200-03-02','Salario de Navidad',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:38:18','RANDY',1),(265,'200-03-03','Seguridad Social',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:38:37','RANDY',1),(266,'200-03-04','Seguro MÃ©dico',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:38:55','RANDY',1),(267,'200-03-05','Impuestos s/Renta',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:39:17','RANDY',1),(268,'200-03-06','Retenciones Honorarios',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:39:35','RANDY',1),(269,'200-03-07','Bonificaciones',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:39:52','RANDY',1),(270,'200-03-08','ITBIS',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:40:07','RANDY',1),(271,'201-00-01','Empresas Relacionadas',2,'Auxiliar','0.00','0.00','0.00','201-00','0',1,'0','NO','0','0','0','0','2020-09-23 10:50:15','RANDY',1),(272,'201-01-01','DepÃ³sitos de Asociados',2,'Auxiliar','0.00','0.00','0.00','201-01','0',1,'0','NO','0','0','0','0','2020-09-23 10:51:18','RANDY',1),(273,'201-01-02','DepÃ³sitos Institucionales',2,'Auxiliar','0.00','0.00','0.00','201-01','0',1,'0','NO','0','0','0','0','2020-09-23 10:51:41','RANDY',1),(274,'201-01-03','DepÃ³sitos de Relacionados',2,'Auxiliar','0.00','0.00','0.00','201-01','0',1,'0','NO','0','0','0','0','2020-09-23 10:52:00','RANDY',1),(275,'201-02-01','Intereses DepÃ³sitos a Plazos',2,'Auxiliar','0.00','0.00','0.00','201-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:54:00','RANDY',1),(276,'201-02-02','Plan Funeral',2,'Auxiliar','0.00','0.00','0.00','201-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:54:22','RANDY',1),(277,'400-08','Ingresos Pago InscripciÃ³n Socios CRESCOOP',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','SI','0','0','0','2020-10-05 21:17:42','RANDY',1),(278,'400-09','Otros Ingresos Aporte ConformaciÃ³n CRESCOOP',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','SI','0','0','0','2020-10-08 17:27:19','RANDY',1),(279,'103-00-01-03','Deposito Local',1,'Auxiliar','0.00','0.00','0.00','103-00-01','0',1,'0','0','0','0','0','0','2020-10-23 16:33:04','RANDY',1),(280,'400-99','Ingresos Varios Menores',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','0','0','0','0','2021-02-04 14:41:53','RMENDEZ',1),(281,'601-15','Suministros ElÃ©ctricos',6,'Auxiliar','0.00','0.00','0.00','6','0',1,'0','0','0','0','0','0','2021-02-05 11:02:19','RMENDEZ',1),(282,'601-16','Gastos de acondicionamiento y pintura',6,'Auxiliar','0.00','0.00','0.00','6','0',1,'0','0','0','0','0','0','2021-02-05 11:08:24','RMENDEZ',1),(283,'601-17','Otros gastos de condominio',6,'Auxiliar','0.00','0.00','0.00','6','0',1,'0','0','0','0','0','0','2021-02-05 15:03:23','RMENDEZ',1),(284,'103-00-01-04','Sistemas informÃ¡ticos',1,'Auxiliar','0.00','0.00','0.00','1','0',1,'0','0','0','0','0','0','2021-02-06 09:03:38','RMENDEZ',1),(285,'101-00-01-99','Cuentas por cobrar varis provisional',1,'Auxiliar','0.00','0.00','0.00','101-00-01','0',1,'0','0','0','0','0','0','2021-02-19 10:07:20','RMENDEZ',1),(286,'200-03-09','RetenciÃ³n para pago de seguros prÃ©stamos',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','0','0','0','0','0','2021-04-19 14:27:05','RMENDEZ',1),(287,'200-02-06','Claro comunicaciones',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','0','0','0','0','0','2021-06-23 10:21:30','RMENDEZ',1),(288,'200-02-07','Condominio Plaza Italia',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','0','0','0','0','0','2021-06-23 11:14:25','RMENDEZ',1),(289,'605-03','Dietas y ViÃ¡ticos',6,'Auxiliar','0.00','0.00','0.00','605','0',1,'0','0','0','0','0','0','2021-06-25 10:12:13','RMENDEZ',1),(290,'11-01-02-07','Libretas Socio Crescoop a amortizar',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','0','0','0','0','0','2021-10-16 12:28:02','RMENDEZ',1),(291,'201-02-99','Otros pasivos miscelaneos',2,'Auxiliar','0.00','0.00','0.00','201-02','0',1,'0','0','0','0','0','0','2021-10-21 09:19:14','RMENDEZ',1),(292,'100-04-04','Banco Popular Cta. No. 825981673',1,'Auxiliar','0.00','0.00','0.00','100-04','0',1,'0','0','0','0','0','0','2022-02-09 09:16:33','RMENDEZ',1);
/*!40000 ALTER TABLE `tbl_catalogo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_catalogo1`
--

DROP TABLE IF EXISTS `tbl_catalogo1`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_catalogo1` (
  `ID` int(11) NOT NULL auto_increment,
  `CuentaNo` varchar(15) default NULL,
  `Descripcion` varchar(80) default NULL,
  `Grupo` int(1) default '0',
  `Tipo` varchar(10) default '0',
  `Debito` decimal(12,2) default '0.00',
  `Credito` decimal(12,2) default '0.00',
  `Balance` decimal(12,2) default '0.00',
  `CtaControl` varchar(100) default '0',
  `NombreMes` varchar(15) default '0',
  `NumeroMes` int(2) default '1',
  `BalanceAnterior` decimal(12,2) default '0.00',
  `BalanceGeneral` varchar(2) default '0',
  `EstadoResultado` varchar(2) default '0',
  `OrdenEstadoResultado` varchar(2) default '0',
  `AccionEstatoResultado` varchar(1) default '0',
  `VerEnCero` varchar(2) default '0',
  `Fecha` datetime default NULL,
  `Usuario` varchar(25) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_catalogo1`
--

LOCK TABLES `tbl_catalogo1` WRITE;
/*!40000 ALTER TABLE `tbl_catalogo1` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_catalogo1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_catalogo_grupo`
--

DROP TABLE IF EXISTS `tbl_catalogo_grupo`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_catalogo_grupo` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(25) default '0',
  `Origen` int(1) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_catalogo_grupo`
--

LOCK TABLES `tbl_catalogo_grupo` WRITE;
/*!40000 ALTER TABLE `tbl_catalogo_grupo` DISABLE KEYS */;
INSERT INTO `tbl_catalogo_grupo` VALUES (1,'ACTIVO',1),(2,'PASIVO',2),(3,'CAPITAL',2),(4,'INGRESO',2),(5,'COSTO',1),(6,'GASTO',1);
/*!40000 ALTER TABLE `tbl_catalogo_grupo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_catalogo_original`
--

DROP TABLE IF EXISTS `tbl_catalogo_original`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_catalogo_original` (
  `ID` int(11) NOT NULL default '0',
  `CuentaNo` varchar(15) default NULL,
  `Descripcion` varchar(80) default NULL,
  `Grupo` int(1) default '0',
  `Tipo` varchar(10) default '0',
  `Debito` decimal(12,2) default '0.00',
  `Credito` decimal(12,2) default '0.00',
  `Balance` decimal(12,2) default '0.00',
  `CtaControl` varchar(100) default '0',
  `NombreMes` varchar(15) default '0',
  `NumeroMes` int(2) default '1',
  `BalanceAnterior` decimal(12,2) default '0.00',
  `BalanceGeneral` varchar(2) default '0',
  `EstadoResultado` varchar(2) default '0',
  `OrdenEstadoResultado` varchar(2) default '0',
  `AccionEstatoResultado` varchar(1) default '0',
  `VerEnCero` varchar(2) default '0',
  `Fecha` datetime default NULL,
  `Usuario` varchar(25) default '0',
  `Clase` varchar(255) default '0',
  `Origen` varchar(255) default '0'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_catalogo_original`
--

LOCK TABLES `tbl_catalogo_original` WRITE;
/*!40000 ALTER TABLE `tbl_catalogo_original` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_catalogo_original` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_categoria_gastos`
--

DROP TABLE IF EXISTS `tbl_categoria_gastos`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_categoria_gastos` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_categoria` varchar(30) default 'n/a',
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_categoria_gastos`
--

LOCK TABLES `tbl_categoria_gastos` WRITE;
/*!40000 ALTER TABLE `tbl_categoria_gastos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_categoria_gastos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_categoria_gastos_nombre`
--

DROP TABLE IF EXISTS `tbl_categoria_gastos_nombre`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_categoria_gastos_nombre` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_categoria` varchar(30) default 'n/a',
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_categoria_gastos_nombre`
--

LOCK TABLES `tbl_categoria_gastos_nombre` WRITE;
/*!40000 ALTER TABLE `tbl_categoria_gastos_nombre` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_categoria_gastos_nombre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cheques`
--

DROP TABLE IF EXISTS `tbl_cheques`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_cheques` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_ck_no` int(11) default NULL,
  `fld_id_banco` varchar(15) default NULL,
  `fld_fecha` date default NULL,
  `fld_concepto` varchar(765) default NULL,
  `fld_monto` double(11,2) default NULL,
  `fld_estado` varchar(15) default NULL,
  `fld_cta_axu_id` int(11) default NULL,
  `fld_beneficiario` varchar(500) default NULL,
  `fld_monto_letras` varchar(500) default NULL,
  `fld_monto_aux` double(12,2) default NULL,
  `fld_id_entrada` int(11) default NULL,
  `fld_transito` varchar(15) default NULL,
  `fld_detalle_colecturia` varchar(255) default NULL,
  `fld_contra_cuenta` varchar(25) default NULL,
  PRIMARY KEY  (`fld_id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_cheques`
--

LOCK TABLES `tbl_cheques` WRITE;
/*!40000 ALTER TABLE `tbl_cheques` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cheques` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cheques_solicitud`
--

DROP TABLE IF EXISTS `tbl_cheques_solicitud`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_cheques_solicitud` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_ck_no` int(11) default NULL,
  `fld_id_banco` text,
  `fld_fecha` date default NULL,
  `fld_concepto` varchar(765) default NULL,
  `fld_monto` double(11,2) default NULL,
  `fld_estado` text,
  `fld_cta_axu_id` int(11) default NULL,
  `fld_beneficiario` varchar(500) default NULL,
  `fld_monto_letras` varchar(500) default NULL,
  `fld_monto_aux` double(12,2) default NULL,
  `fld_id_entrada` int(11) default NULL,
  `fld_transito` text,
  `fld_detalle_colecturia` text,
  `fld_contra_cuenta` varchar(25) default NULL,
  PRIMARY KEY  (`fld_id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_cheques_solicitud`
--

LOCK TABLES `tbl_cheques_solicitud` WRITE;
/*!40000 ALTER TABLE `tbl_cheques_solicitud` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cheques_solicitud` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cheques_trans`
--

DROP TABLE IF EXISTS `tbl_cheques_trans`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_cheques_trans` (
  `fld_id_doc_ck_trans` int(11) NOT NULL auto_increment,
  `fld_id_conciliacion_ck` int(11) default NULL,
  `fld_no_ck` text,
  `fld_fecha_ck` date default NULL,
  `fld_monto_ck` double(12,2) default NULL,
  PRIMARY KEY  (`fld_id_doc_ck_trans`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_cheques_trans`
--

LOCK TABLES `tbl_cheques_trans` WRITE;
/*!40000 ALTER TABLE `tbl_cheques_trans` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cheques_trans` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_ciudad`
--

DROP TABLE IF EXISTS `tbl_ciudad`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_ciudad` (
  `fldCodigo` int(11) NOT NULL auto_increment,
  `fldDescripcion` varchar(255) default NULL,
  PRIMARY KEY  (`fldCodigo`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_ciudad`
--

LOCK TABLES `tbl_ciudad` WRITE;
/*!40000 ALTER TABLE `tbl_ciudad` DISABLE KEYS */;
INSERT INTO `tbl_ciudad` VALUES (1,'LAS TERRENAS'),(2,'SANTO DOMINGO'),(3,'SANTIAGO'),(4,'MONTECRISTI'),(5,'GASPAR HERNANDEZ'),(6,'KENYA'),(7,'SAMANA');
/*!40000 ALTER TABLE `tbl_ciudad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_clientes`
--

DROP TABLE IF EXISTS `tbl_clientes`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_clientes` (
  `fld_id` int(11) NOT NULL auto_increment,
  `TipoDocumento` int(11) default '1',
  `fld_FullName` varchar(255) default NULL,
  `fld_apodo` varchar(55) default 'N/A',
  `fld_Identity` varchar(16) default NULL,
  `fld_Phone` varchar(255) default '809-000-0000',
  `fld_Phone2` varchar(255) default '809-000-0000',
  `fld_Address` varchar(255) default NULL,
  `fld_City_id` int(11) default '0',
  `fld_City` varchar(55) default 'Nagua',
  `fld_Status` varchar(6) default 'N',
  `fld_bce` double(11,2) default '0.00',
  `fld_cod_zona` int(11) default '1',
  `fld_zona` varchar(255) default 'N/A',
  `fld_nombre_con` varchar(55) default 'N/A',
  `fld_apodo_con` varchar(55) default 'N/A',
  `fld_cedula_con` varchar(16) default '000-0000000-0',
  `fld_telefono_con` varchar(14) default '809-000-0000',
  `fld_celular_con` varchar(13) default '809-000-0000',
  `fld_ref_personales_cliente` varchar(510) default 'N/A',
  `fld_ref_comerciales_cliente` varchar(510) default 'N/A',
  `fld_nombre_gar` varchar(55) default 'N/A',
  `fld_apodo_gar` varchar(55) default 'N/A',
  `fld_cedula_gar` varchar(16) default '0',
  `fld_telefono_gar` varchar(13) default '809-000-0000',
  `fld_celular_gar` varchar(13) default '809-000-0000',
  `fld_direccion_gar` varchar(255) default 'N/A',
  `fld_ciudad_gar` varchar(55) default 'N/A',
  `fld_ref_personales_gar` varchar(510) default 'N/A',
  `fld_ref_comerciales_gar` varchar(510) default 'N/A',
  `fld_ingresos_mesuales` double(12,2) default '0.00',
  `fld_nombre_banco1` varchar(1000) default 'N/A',
  `fld_cuenta_banco1` varchar(15) default 'N/A',
  `fld_nombre_banco2` varchar(1000) default 'N/A',
  `fld_cuenta_banco2` varchar(15) default 'N/A',
  `fld_otra_informacion` varchar(1000) default 'N/A',
  `fld_nombre_con_gar` varchar(55) default 'N/A',
  `fld_apodo_con_gar` varchar(55) default 'N/A',
  `fld_cedula_con_gar` varchar(16) default '0',
  `fld_telefono_con_gar` varchar(13) default '809-000-0000',
  `fld_celular_con_gar` varchar(13) default '809-000-0000',
  `fld_edad` date default '2020-01-01',
  `fld_estado_civil` varchar(15) default 'N/A',
  `fld_edad_gar` int(50) default '0',
  `fld_estado_civil_gar` varchar(15) default 'N/A',
  `fld_ocupacion_cliente` varchar(55) default 'N/A',
  `fld_ocupacion_gar` varchar(55) default 'N/A',
  `fld_sector_id` int(11) default '0',
  `fld_sector` varchar(255) default 'N/A',
  `fld_categoria` varchar(25) default 'BUENO',
  `fld_limite` double(12,2) default '0.00',
  `Puesto` varchar(100) default 'N/A',
  `TimpoTrabajo` varchar(100) default 'N/A',
  `ReferidoPor` varchar(100) default 'N/A',
  `Oriundo` varchar(100) default 'N/A',
  `DataCredito` int(1) default '0',
  `ctaContable` char(200) default '0',
  `email` varchar(255) default '@',
  `fechaIngreso` date default '2020-01-01',
  `whatsapp` varchar(13) default 'N/A',
  `whatsapp_con` varchar(13) default 'N/A',
  `parentezco_gar` varchar(20) default 'NINGUNO',
  `fecha_nac_gar` date default '2020-01-01',
  `whatsapp_gar` varchar(13) default 'N/A',
  `email_gar` varchar(255) default '@',
  `empresa_gar` varchar(50) default 'N/A',
  `telefono_Empresa_gar` varchar(13) default 'N/A',
  `agno_labor_gar` int(50) default '0',
  `salario_gar` double(10,2) default '0.00',
  `whatsapp_con_gar` varchar(13) default 'N/A',
  `fld_ref_parentesco_clie1` varchar(20) default 'NINGUNO',
  `fld_ced_ref_personal_clie1` varchar(16) default NULL,
  `fld_tel_ref_personal_clie1` varchar(13) default 'N/A',
  `fld_cel_ref_personal_clie1` varchar(13) default 'N/A',
  `fld_whatsapp_ref_personal_clie1` varchar(13) default 'N/A',
  `fld_ref_personal_clie2` varchar(50) default NULL,
  `fld_ref_parentesco_clie2` varchar(20) default 'NINGUNO',
  `fld_ced_ref_personal_clie2` varchar(16) default NULL,
  `fld_tel_ref_personal_clie2` varchar(13) default 'N/A',
  `fld_cel_ref_personal_clie2` varchar(13) default 'N/A',
  `fld_whatsapp_ref_personal_clie2` varchar(13) default 'N/A',
  `Fld_Dir_Ref_Com_Clie1` varchar(255) default NULL,
  `Fld_Rnc_Refe_Com_Clie1` varchar(9) default 'N/A',
  `Fld_Tel_Com_clie1` varchar(13) default NULL,
  `Fld_Whatsapp_Com_Clie1` varchar(13) default 'N/A',
  `fld_ref_comerciales_cliente2` varchar(50) default NULL,
  `Fld_Dir_Ref_Com_Clie2` varchar(255) default NULL,
  `Fld_Rnc_Refe_Com_Clie2` varchar(9) default 'N/A',
  `Fld_Tel_Com_clie2` varchar(13) default 'N/A',
  `Fld_Whatsapp_Com_Clie2` varchar(13) default 'N/A',
  `fld_parentesco_ref_gar1` varchar(20) default 'NINGUNO',
  `fld_cedula_ref_gar1` varchar(16) default NULL,
  `fld_tel_ref_gar1` varchar(13) default 'N/A',
  `fld_cel_ref_gar1` varchar(13) default 'N/A',
  `fld_whatsapp_ref_gar1` varchar(13) default 'N/A',
  `fld_ref_personal_gar2` varchar(50) default NULL,
  `fld_parentesco_ref_gar2` varchar(20) default 'NINGUNO',
  `fld_cedula_ref_gar2` varchar(16) default NULL,
  `fld_tel_ref_gar2` varchar(13) default 'N/A',
  `fld_cel_ref_gar2` varchar(13) default 'N/A',
  `fld_whatsapp_ref_gar2` varchar(13) default 'N/A',
  `Fdl_Dir_Emp_Gar1` varchar(255) default NULL,
  `Fld_Rnc_Emp_Gar1` varchar(11) default NULL,
  `Fld_Tel_Emp_Gar1` varchar(13) default 'N/A',
  `Fld_Whatsapp_emp_Gar1` varchar(13) default 'N/A',
  `Fld_Empra_Gar2` varchar(50) default 'N/A',
  `Fld_Dir_Emp_Gar2` varchar(255) default NULL,
  `Fld_Rnc_Emp_Gar2` varchar(11) default 'N/A',
  `Fld_Tel_Emp_Gar2` varchar(13) default 'N/A',
  `Fld_Whatsapp_Emp_Gar2` varchar(13) default 'N/A',
  `fld_nom_ref_flia_clie1` varchar(50) default NULL,
  `fld_parentesco_ref_flia_clie1` varchar(50) default NULL,
  `fld_ced_ref_flia_clie1` varchar(16) default NULL,
  `fld_tel_ref_flia_clie1` varchar(13) default 'N/A',
  `fld_cel_ref_flia_clie1` varchar(13) default 'N/A',
  `fld_whatsapp_ref_flia_clie1` varchar(13) default 'N/A',
  `fld_nom_ref_flia_clie2` varchar(50) default NULL,
  `fld_parentesco_ref_flia_clie2` varchar(20) default 'NINGUNO',
  `fld_ced_ref_flia_clie2` varchar(16) default NULL,
  `fld_tel_ref_flia_clie2` varchar(13) default 'N/A',
  `fld_cel_ref_flia_clie2` varchar(13) default 'N/A',
  `fld_whats_ref_flia_clie2` varchar(13) default 'N/A',
  `fld_provincia_id` int(11) default '0',
  `fld_provincia` varchar(255) default 'N/A',
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_clientes`
--

LOCK TABLES `tbl_clientes` WRITE;
/*!40000 ALTER TABLE `tbl_clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_clientes_cuenta_banco`
--

DROP TABLE IF EXISTS `tbl_clientes_cuenta_banco`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_clientes_cuenta_banco` (
  `ID` int(11) NOT NULL auto_increment,
  `Fecha` datetime default NULL,
  `TipoCuenta` varchar(30) default NULL,
  `NumeroCuenta` varchar(30) default NULL,
  `Banco` varchar(30) default NULL,
  `Telefono` varchar(30) default NULL,
  `IDCliente` int(11) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_clientes_cuenta_banco`
--

LOCK TABLES `tbl_clientes_cuenta_banco` WRITE;
/*!40000 ALTER TABLE `tbl_clientes_cuenta_banco` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_clientes_cuenta_banco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_clientes_estados_finaciero`
--

DROP TABLE IF EXISTS `tbl_clientes_estados_finaciero`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_clientes_estados_finaciero` (
  `ID` int(11) unsigned zerofill NOT NULL auto_increment,
  `Fecha` datetime default NULL,
  `ingSalario` double(12,2) default '0.00',
  `ingOtros` double(12,2) default '0.00',
  `egrAlquiles` double(12,2) default '0.00',
  `egrSupermercado` double(12,2) default '0.00',
  `egrAgua` double(12,2) default '0.00',
  `egrLuz` double(12,2) default '0.00',
  `egrTelefono` double(12,2) default '0.00',
  `egrTelecable` double(12,2) default '0.00',
  `egrServiciosDomesticos` double(12,2) default '0.00',
  `egrOtros` double(12,2) default '0.00',
  `actEfectivoBanco` double(12,2) default '0.00',
  `actCuentaXCobrar` double(12,2) default '0.00',
  `actBienesInmuebles` double(12,2) default '0.00',
  `actVehiculo` double(12,2) default '0.00',
  `actOtros` double(12,2) default '0.00',
  `pasDocumentoXpagar` double(12,2) default '0.00',
  `pasHipotecas` double(12,2) default '0.00',
  `pasOtros` double(12,2) default '0.00',
  `Capital` double(12,2) default '0.00',
  `IDCliente` int(1) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_clientes_estados_finaciero`
--

LOCK TABLES `tbl_clientes_estados_finaciero` WRITE;
/*!40000 ALTER TABLE `tbl_clientes_estados_finaciero` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_clientes_estados_finaciero` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_clientes_otras_obligaciones`
--

DROP TABLE IF EXISTS `tbl_clientes_otras_obligaciones`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_clientes_otras_obligaciones` (
  `ID` int(11) NOT NULL auto_increment,
  `Fecha` datetime default NULL,
  `Nombre` varchar(55) default NULL,
  `Tipo` varchar(55) default NULL,
  `Monto` double(12,2) default '0.00',
  `Balance` double(12,2) default '0.00',
  `Mensualidad` double(12,2) default '0.00',
  `IDCliente` int(11) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_clientes_otras_obligaciones`
--

LOCK TABLES `tbl_clientes_otras_obligaciones` WRITE;
/*!40000 ALTER TABLE `tbl_clientes_otras_obligaciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_clientes_otras_obligaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cod_ck`
--

DROP TABLE IF EXISTS `tbl_cod_ck`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_cod_ck` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_cuenta_no` text,
  `fld_ck_no` double(12,0) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_cod_ck`
--

LOCK TABLES `tbl_cod_ck` WRITE;
/*!40000 ALTER TABLE `tbl_cod_ck` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cod_ck` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cod_ncf`
--

DROP TABLE IF EXISTS `tbl_cod_ncf`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_cod_ncf` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_tipo` varchar(255) default NULL,
  `fld_prefijo` varchar(255) default NULL,
  `fld_ncf_inicia` double(11,0) default NULL,
  `fld_ncf_finaliza` double(11,0) default NULL,
  `fld_ncf_secuencia_actual` double(11,0) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_cod_ncf`
--

LOCK TABLES `tbl_cod_ncf` WRITE;
/*!40000 ALTER TABLE `tbl_cod_ncf` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cod_ncf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cod_ri`
--

DROP TABLE IF EXISTS `tbl_cod_ri`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_cod_ri` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_id_admision` int(11) default NULL,
  `fld_id_caja` int(11) default NULL,
  `fld_dpto` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_cod_ri`
--

LOCK TABLES `tbl_cod_ri` WRITE;
/*!40000 ALTER TABLE `tbl_cod_ri` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cod_ri` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_compras_salida_caja`
--

DROP TABLE IF EXISTS `tbl_compras_salida_caja`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_compras_salida_caja` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_fecha` datetime default NULL,
  `fld_concepto` varchar(550) default 'n/a',
  `fld_proveedor` varchar(255) default 'n/a',
  `fld_fact_proveedor` varchar(255) default 'n/a',
  `fld_monto` double(10,2) default '0.00',
  `fld_user` varchar(30) default 'n/a',
  `fld_categoria` varchar(255) default 'n/a',
  PRIMARY KEY  (`fld_id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_compras_salida_caja`
--

LOCK TABLES `tbl_compras_salida_caja` WRITE;
/*!40000 ALTER TABLE `tbl_compras_salida_caja` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_compras_salida_caja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_conciliacion`
--

DROP TABLE IF EXISTS `tbl_conciliacion`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_conciliacion` (
  `fld_id_con` int(11) NOT NULL auto_increment,
  `fld_fecha_ultima_conciliacion` date default NULL,
  `fld_al_fecha` date default NULL,
  `fld_saldo_banco` double(12,2) default NULL,
  `fld_dep_transito` double(12,2) default NULL,
  `fld_ck_transito` double(12,2) default NULL,
  `fld_bce_conciliado_banco` double(12,2) default NULL,
  `fld_bce_segun_computador` double(12,2) default NULL,
  `fld_mas` double(12,2) default NULL,
  `fld_depositos_registrados` double(12,2) default NULL,
  `fld_menos` double(12,2) default NULL,
  `fld_cheques_emitidos` double(12,2) default NULL,
  `fld_bce_conciliadio_segun_pc` double(12,2) default NULL,
  `fld_id_banco` text,
  `fld_desp_banco` text,
  `fld_cta_bancaria_no` text,
  `fld_user_maked` text,
  PRIMARY KEY  (`fld_id_con`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_conciliacion`
--

LOCK TABLES `tbl_conciliacion` WRITE;
/*!40000 ALTER TABLE `tbl_conciliacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_conciliacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_confg_chequera`
--

DROP TABLE IF EXISTS `tbl_confg_chequera`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_confg_chequera` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_fecha` datetime default NULL,
  `fld_doc_chequera` int(11) default '0',
  `fld_x_fecha_top` int(11) default '0',
  `fld_y_fecha_top` int(11) default '0',
  `fld_x_concepto` int(11) default '0',
  `fld_y_concepto` int(11) default '0',
  `fld_x_valor_top` int(11) default '0',
  `fld_y_valor_top` int(11) default '0',
  `fld_x_beneficiario` int(11) default '0',
  `fld_y_beneficiario` int(11) default '0',
  `fld_x_valor` int(11) default '0',
  `fld_y_valor` int(11) default '0',
  `fld_x_letras` int(11) default '0',
  `fld_y_letras` int(11) default '0',
  `fld_x_pri_dig_dia` int(11) default '0',
  `fld_y_pri_dig_dia` int(11) default '0',
  `fld_x_seg_dig_dia` int(11) default '0',
  `fld_y_seg_dig_dia` int(11) default '0',
  `fld_x_pri_dig_mes` int(11) default '0',
  `fld_y_pri_dig_mes` int(11) default '0',
  `fld_x_seg_dig_mes` int(11) default '0',
  `fld_y_seg_dig_mes` int(11) default '0',
  `fld_x_pri_dig_ano` int(11) default '0',
  `fld_y_pri_dig_ano` int(11) default '0',
  `fld_x_seg_dig_ano` int(11) default '0',
  `fld_y_seg_dig_ano` int(11) default '0',
  `fld_x_ter_dig_ano` int(11) default '0',
  `fld_y_ter_dig_ano` int(11) default '0',
  `fld_x_cuar_dig_ano` int(11) default '0',
  `fld_y_cuar_dig_ano` int(11) default '0',
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_confg_chequera`
--

LOCK TABLES `tbl_confg_chequera` WRITE;
/*!40000 ALTER TABLE `tbl_confg_chequera` DISABLE KEYS */;
INSERT INTO `tbl_confg_chequera` VALUES (6,'2020-10-05 21:10:28',1,5,6,10,11,12,13,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0);
/*!40000 ALTER TABLE `tbl_confg_chequera` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cuadre`
--

DROP TABLE IF EXISTS `tbl_cuadre`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_cuadre` (
  `fldId` int(11) unsigned zerofill NOT NULL auto_increment,
  `fldFecha` datetime default NULL,
  `fldNota` varchar(5500) default 'Nota',
  `fldUsuario` varchar(255) default 'N/A',
  `fldIngresos` double(12,2) default '0.00',
  `fldDepositos` double(12,2) default '0.00',
  `fldOtroIngresos` double(12,2) default '0.00',
  `fldCheques` double(12,2) default '0.00',
  `fldEgresos` double(12,2) default '0.00',
  `fldBceAnterior` double(12,2) default '0.00',
  `fldBceDisponible` double(12,2) default '0.00',
  PRIMARY KEY  (`fldId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_cuadre`
--

LOCK TABLES `tbl_cuadre` WRITE;
/*!40000 ALTER TABLE `tbl_cuadre` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cuadre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cuadre_detalle`
--

DROP TABLE IF EXISTS `tbl_cuadre_detalle`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_cuadre_detalle` (
  `fldId` int(11) unsigned zerofill NOT NULL auto_increment,
  `fldTipoDocumento` varchar(255) default 'N/A',
  `fldIdDocumento` varchar(255) default '0',
  `fldCliente` varchar(255) default 'N/A',
  `fldDetalleDocumento` varchar(5500) default 'N/A',
  `fldFechaDocumento` datetime default NULL,
  `fldMontoDocumento` double(12,2) default '0.00',
  PRIMARY KEY  (`fldId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_cuadre_detalle`
--

LOCK TABLES `tbl_cuadre_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_cuadre_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cuadre_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cuotas`
--

DROP TABLE IF EXISTS `tbl_cuotas`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_cuotas` (
  `fld_id_cuotas` int(11) NOT NULL auto_increment,
  `fld_no_cuotas` varchar(15) default NULL,
  `fld_id_del_cliente_cuotas` int(11) default '0',
  `fld_id_del_prestamo` int(11) default '0',
  `fld_fecha_entrega_cuotas` date default NULL,
  `fld_fecha_termina_cuotas` date default NULL,
  `fld_fecha_calculo_interes` date default NULL,
  `fld_termina_calculo_interes` varchar(6) default 'False',
  `fld_fecha_ultimo_abono_cuotas` date default NULL,
  `fld_capital_cuota` decimal(12,2) default '0.00',
  `fld_interes_cuota` decimal(12,2) default '0.00',
  `fld_monto_cuotas` decimal(12,2) default '0.00',
  `fld_abono_cuotas` decimal(12,2) default '0.00',
  `fld_balance_cuotas` decimal(12,2) default '0.00',
  `fld_usuario_cuotas` varchar(255) default 'N/A',
  `fld_status_cuotas` varchar(255) default 'N/A',
  `fld_pendiente_amortizar` decimal(12,2) default '0.00',
  `fld_total_amortizado` decimal(12,2) default '0.00',
  `fld_capital_cuota_abono` decimal(12,2) default '0.00',
  `fld_capital_cuota_balance` decimal(12,2) default '0.00',
  `fld_interes_cuota_abono` decimal(12,2) default '0.00',
  `fld_interes_cuota_balance` decimal(12,2) default '0.00',
  `fld_ultimo_abono_interes` decimal(12,2) default '0.00',
  `fld_ultimo_abono_capital` decimal(12,2) default '0.00',
  `fld_monto_mora` decimal(12,2) default '0.00',
  `fld_abono_mora` decimal(12,2) default '0.00',
  `fld_balance_mora` decimal(12,2) default '0.00',
  `fld_ultimo_abono_mora` decimal(12,2) default '0.00',
  `fld_dias_vencimiento` int(11) default '0',
  `fld_socio` varchar(255) default 'N/A',
  `fld_atraso_cuotas` decimal(12,2) default '0.00',
  `fld_tipo_cuotas` varchar(255) default 'MENSUAL',
  `fld_bce_prestamo` decimal(12,2) default '0.00',
  `fld_cant_cuotas` decimal(12,2) default '0.00',
  `fldchk` varchar(6) default 'True',
  `Tipo` varchar(50) default 'cuota',
  PRIMARY KEY  (`fld_id_cuotas`),
  KEY `Idxs` (`fld_id_del_cliente_cuotas`,`fld_id_del_prestamo`,`fld_fecha_termina_cuotas`,`fld_balance_cuotas`,`fld_cant_cuotas`,`fld_fecha_calculo_interes`,`fld_status_cuotas`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_cuotas`
--

LOCK TABLES `tbl_cuotas` WRITE;
/*!40000 ALTER TABLE `tbl_cuotas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cuotas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cuotas_abono_capital`
--

DROP TABLE IF EXISTS `tbl_cuotas_abono_capital`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_cuotas_abono_capital` (
  `fld_id_cuotas` int(11) NOT NULL auto_increment,
  `fld_no_cuotas` varchar(15) character set utf8 default NULL,
  `fld_id_del_cliente_cuotas` int(11) default '0',
  `fld_id_del_prestamo` int(11) default '0',
  `fld_fecha_entrega_cuotas` date default NULL,
  `fld_fecha_termina_cuotas` date default NULL,
  `fld_fecha_ultimo_abono_cuotas` date default NULL,
  `fld_capital_cuota` double(12,2) default NULL,
  `fld_interes_cuota` double(12,2) default NULL,
  `fld_monto_cuotas` double(12,2) default NULL,
  `fld_abono_cuotas` double(12,2) default NULL,
  `fld_balance_cuotas` double(12,2) default NULL,
  `fld_usuario_cuotas` varchar(255) character set utf8 default 'N/A',
  `fld_status_cuotas` varchar(255) character set utf8 default 'N/A',
  `fld_pendiente_amortizar` double(12,3) default '0.000',
  `fld_total_amortizado` double(12,3) default '0.000',
  `fld_capital_cuota_abono` double(12,2) default '0.00',
  `fld_capital_cuota_balance` double(12,2) default '0.00',
  `fld_interes_cuota_abono` double(12,2) default '0.00',
  `fld_interes_cuota_balance` double(12,2) default '0.00',
  `fld_ultimo_abono_interes` double(12,2) default '0.00',
  `fld_ultimo_abono_capital` double(12,2) default '0.00',
  `fld_monto_mora` double(12,2) default '0.00',
  `fld_abono_mora` double(12,2) default '0.00',
  `fld_balance_mora` double(12,2) default '0.00',
  `fld_ultimo_abono_mora` double(12,2) default '0.00',
  `fld_dias_vencimiento` int(11) default '0',
  `fld_socio` varchar(255) character set utf8 default 'N/A',
  `fld_atraso_cuotas` double(12,2) default '0.00',
  `fld_tipo_cuotas` varchar(255) character set utf8 default 'MENSUAL',
  `fld_bce_prestamo` double(12,2) default '0.00',
  `fld_cant_cuotas` double(12,2) default '0.00',
  `fldchk` varchar(6) character set utf8 default 'True',
  `fld_termina_calculo_interes` varchar(6) character set utf8 default 'False',
  `fld_fecha_calculo_interes` date default NULL,
  `FechaAbonoCapital` date default NULL,
  PRIMARY KEY  (`fld_id_cuotas`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_cuotas_abono_capital`
--

LOCK TABLES `tbl_cuotas_abono_capital` WRITE;
/*!40000 ALTER TABLE `tbl_cuotas_abono_capital` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cuotas_abono_capital` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_data_credito`
--

DROP TABLE IF EXISTS `tbl_data_credito`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_data_credito` (
  `codigo` int(11) default NULL,
  `cedula` varchar(255) default NULL,
  `cliente` varchar(255) default NULL,
  `telefono` varchar(255) default NULL,
  `direccion` varchar(255) default NULL,
  `monto` double(12,2) default NULL,
  `estatus` varchar(1) default NULL,
  `balance` double(12,2) default NULL,
  `atraso` double(12,2) default NULL,
  `fechaapertura` date default NULL,
  `fechavencimiento` date default NULL,
  `fechaultpago` date default NULL,
  `montoultpago` double(12,2) default NULL,
  `cantidadcuota` double(12,2) default NULL,
  `montocuota` double(12,2) default NULL,
  `tipoprestamo` varchar(10) default NULL,
  `codprestamo` int(11) default NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_data_credito`
--

LOCK TABLES `tbl_data_credito` WRITE;
/*!40000 ALTER TABLE `tbl_data_credito` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_data_credito` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_deposito`
--

DROP TABLE IF EXISTS `tbl_deposito`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_deposito` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_id_banco` text,
  `fld_fecha` date default NULL,
  `fld_descripcion` varchar(255) default NULL,
  `fld_monto` double(11,2) default NULL,
  `fld_estado` text,
  `fld_transito` text,
  `fld_cod_concepto` varchar(11) default NULL,
  `afectacaja` int(11) default '0',
  PRIMARY KEY  (`fld_id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_deposito`
--

LOCK TABLES `tbl_deposito` WRITE;
/*!40000 ALTER TABLE `tbl_deposito` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_deposito` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_deposito_trans`
--

DROP TABLE IF EXISTS `tbl_deposito_trans`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_deposito_trans` (
  `fld_id_doc_dep_trans` int(11) NOT NULL auto_increment,
  `fld_id_conciliacion_dep` int(11) default NULL,
  `fld_no_dep` text,
  `fld_fecha_dep` date default NULL,
  `fld_monto_dep` double(12,2) default NULL,
  PRIMARY KEY  (`fld_id_doc_dep_trans`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_deposito_trans`
--

LOCK TABLES `tbl_deposito_trans` WRITE;
/*!40000 ALTER TABLE `tbl_deposito_trans` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_deposito_trans` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_detalle_pago_ck`
--

DROP TABLE IF EXISTS `tbl_detalle_pago_ck`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_detalle_pago_ck` (
  `fld_id_detalle` int(11) NOT NULL auto_increment,
  `fld_cod_doc` int(11) default NULL,
  `fld_ck_id` int(11) default NULL,
  `fld_bce` double(12,2) default NULL,
  `fld_abono` double(12,2) default NULL,
  `fld_nuevo_bce` double(12,2) default NULL,
  `fld_tipo` text,
  PRIMARY KEY  (`fld_id_detalle`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_detalle_pago_ck`
--

LOCK TABLES `tbl_detalle_pago_ck` WRITE;
/*!40000 ALTER TABLE `tbl_detalle_pago_ck` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_detalle_pago_ck` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_estado_banco`
--

DROP TABLE IF EXISTS `tbl_estado_banco`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_estado_banco` (
  `fld_id_ec_b` int(11) NOT NULL auto_increment,
  `fld_date` date default NULL,
  `fld_description` varchar(5500) default NULL,
  `fld_dr` double(12,2) default NULL,
  `fld_cr` double(12,2) default NULL,
  `fld_bce_banco` double(12,2) default NULL,
  `fld_banco_id` varchar(255) default NULL,
  `fld_tipo_doc` varchar(255) default NULL,
  `fld_tipo_doc_id` varchar(255) default NULL,
  `fld_usuario` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id_ec_b`),
  KEY `idx_id_banco` (`fld_banco_id`(10))
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_estado_banco`
--

LOCK TABLES `tbl_estado_banco` WRITE;
/*!40000 ALTER TABLE `tbl_estado_banco` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_estado_banco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_estado_clientes`
--

DROP TABLE IF EXISTS `tbl_estado_clientes`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_estado_clientes` (
  `fld_id_ec` int(11) NOT NULL auto_increment,
  `fld_date` date default NULL,
  `fld_description` varchar(5500) default NULL,
  `fld_dr` double(12,2) default NULL,
  `fld_cr` double(12,2) default NULL,
  `fld_bce_cliente` double(12,2) default NULL,
  `fld_cliente_id` int(11) default NULL,
  `fld_tipo_doc` varchar(255) default NULL,
  `fld_tipo_doc_id` varchar(255) default NULL,
  `fld_usuario` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id_ec`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_estado_clientes`
--

LOCK TABLES `tbl_estado_clientes` WRITE;
/*!40000 ALTER TABLE `tbl_estado_clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_estado_clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_estado_proveedor`
--

DROP TABLE IF EXISTS `tbl_estado_proveedor`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_estado_proveedor` (
  `fld_id_ec_p` int(11) NOT NULL auto_increment,
  `fld_date` date default NULL,
  `fld_description` varchar(255) default NULL,
  `fld_dr` double(11,2) default NULL,
  `fld_cr` double(11,2) default NULL,
  `fld_bce_proveedor` double(11,2) default NULL,
  `fld_proveedor_id` int(11) default NULL,
  `fld_tipo_doc` text,
  `fld_tipo_doc_id` text,
  `fld_usuario` text,
  PRIMARY KEY  (`fld_id_ec_p`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_estado_proveedor`
--

LOCK TABLES `tbl_estado_proveedor` WRITE;
/*!40000 ALTER TABLE `tbl_estado_proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_estado_proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_gastos`
--

DROP TABLE IF EXISTS `tbl_gastos`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_gastos` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_concepto` varchar(800) default NULL,
  `fld_a_nombre` varchar(200) default NULL,
  `fld_monto` double(12,2) default NULL,
  `fld_fecha` date default NULL,
  PRIMARY KEY  (`fld_id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_gastos`
--

LOCK TABLES `tbl_gastos` WRITE;
/*!40000 ALTER TABLE `tbl_gastos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_gastos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_historia_abono_capital`
--

DROP TABLE IF EXISTS `tbl_historia_abono_capital`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_historia_abono_capital` (
  `ID` int(11) NOT NULL auto_increment,
  `IDPrestamos` int(11) default '0',
  `Monto` decimal(12,2) default '0.00',
  `Fecha` datetime default NULL,
  `Usuario` varchar(255) default 'n/a',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_historia_abono_capital`
--

LOCK TABLES `tbl_historia_abono_capital` WRITE;
/*!40000 ALTER TABLE `tbl_historia_abono_capital` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_historia_abono_capital` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_historia_delantos_cxc`
--

DROP TABLE IF EXISTS `tbl_historia_delantos_cxc`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_historia_delantos_cxc` (
  `ID` int(11) NOT NULL auto_increment,
  `IDCliente` int(11) default '0',
  `IDRecibo` int(11) default '0',
  `Fecha` datetime default NULL,
  `Monto` decimal(12,2) default '0.00',
  `Usuario` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_historia_delantos_cxc`
--

LOCK TABLES `tbl_historia_delantos_cxc` WRITE;
/*!40000 ALTER TABLE `tbl_historia_delantos_cxc` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_historia_delantos_cxc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_interfascontable`
--

DROP TABLE IF EXISTS `tbl_interfascontable`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_interfascontable` (
  `ID` int(11) NOT NULL auto_increment,
  `Fecha` date default NULL,
  `Modulo` varchar(150) default '0',
  `Frm` varchar(150) default '0',
  `DRCuenta` varchar(25) default '0',
  `CRCuenta` varchar(25) default '0',
  `IDTipo` int(11) default '0',
  `Concepto` varchar(150) default 'n/a',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_interfascontable`
--

LOCK TABLES `tbl_interfascontable` WRITE;
/*!40000 ALTER TABLE `tbl_interfascontable` DISABLE KEYS */;
INSERT INTO `tbl_interfascontable` VALUES (1,'2020-10-02','Ahorro','Nuevo Ahorro','100-00-01','200-00-01',10,'DEPOSITO SOCIOS'),(2,'2020-10-02','Ahorro','Realizar Retiro','200-00-01','100-00-01',9,'RETIRO SOCIOS'),(3,'2020-10-02','Ahorro','Anular Ahorro','200-00-01','100-00-01',12,'ANULACION DE DEPOSITO');
/*!40000 ALTER TABLE `tbl_interfascontable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_interfascontableformularios`
--

DROP TABLE IF EXISTS `tbl_interfascontableformularios`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_interfascontableformularios` (
  `ID` int(11) NOT NULL auto_increment,
  `IDModulo` int(11) default '0',
  `Descripcion` varchar(150) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_interfascontableformularios`
--

LOCK TABLES `tbl_interfascontableformularios` WRITE;
/*!40000 ALTER TABLE `tbl_interfascontableformularios` DISABLE KEYS */;
INSERT INTO `tbl_interfascontableformularios` VALUES (1,1,'DepÃ³sito Bancario'),(2,1,'ND Bancaria'),(3,1,'NC Bancaria'),(4,2,'Egreso de Caja'),(5,2,'Otro Ingreso a Caja'),(6,3,'Nuevo DepÃ³sito'),(7,3,'Nuevo Retiro'),(8,3,'Aporte de Socio'),(9,3,'CancelaciÃ³n de Certificado'),(10,3,'Apertura de Certificado');
/*!40000 ALTER TABLE `tbl_interfascontableformularios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_interfascontableingresos`
--

DROP TABLE IF EXISTS `tbl_interfascontableingresos`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_interfascontableingresos` (
  `ID` int(11) NOT NULL auto_increment,
  `Debito` varchar(10) default '0',
  `Capital` varchar(10) default '0',
  `Interes` varchar(10) default '0',
  `Mora` varchar(10) default '0',
  `Otros` varchar(10) default '0',
  `IdTipo` int(11) default '0',
  `DescripcionTipo` varchar(255) default '0',
  `Cliente` varchar(10) default '0',
  `Proveedor` varchar(10) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_interfascontableingresos`
--

LOCK TABLES `tbl_interfascontableingresos` WRITE;
/*!40000 ALTER TABLE `tbl_interfascontableingresos` DISABLE KEYS */;
INSERT INTO `tbl_interfascontableingresos` VALUES (1,'','','400-00','400-02','',3,'','','');
/*!40000 ALTER TABLE `tbl_interfascontableingresos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_interfascontablemodulos`
--

DROP TABLE IF EXISTS `tbl_interfascontablemodulos`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_interfascontablemodulos` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(150) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_interfascontablemodulos`
--

LOCK TABLES `tbl_interfascontablemodulos` WRITE;
/*!40000 ALTER TABLE `tbl_interfascontablemodulos` DISABLE KEYS */;
INSERT INTO `tbl_interfascontablemodulos` VALUES (1,'Banco'),(2,'Caja'),(3,'Ahorro');
/*!40000 ALTER TABLE `tbl_interfascontablemodulos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_interfascontableotras`
--

DROP TABLE IF EXISTS `tbl_interfascontableotras`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_interfascontableotras` (
  `ID` int(11) NOT NULL auto_increment,
  `Utilidad` varchar(10) default '0',
  `Cierre` varchar(10) default '0',
  `Certificados` varchar(10) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_interfascontableotras`
--

LOCK TABLES `tbl_interfascontableotras` WRITE;
/*!40000 ALTER TABLE `tbl_interfascontableotras` DISABLE KEYS */;
INSERT INTO `tbl_interfascontableotras` VALUES (1,'301-04','301-01','200-01-01'),(2,'301-01','301-04','0');
/*!40000 ALTER TABLE `tbl_interfascontableotras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_interfascontableotrastipo`
--

DROP TABLE IF EXISTS `tbl_interfascontableotrastipo`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_interfascontableotrastipo` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_codigo` varchar(20) default NULL,
  `fld_descripcion` varchar(100) default NULL,
  `fld_modulo` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_interfascontableotrastipo`
--

LOCK TABLES `tbl_interfascontableotrastipo` WRITE;
/*!40000 ALTER TABLE `tbl_interfascontableotrastipo` DISABLE KEYS */;
INSERT INTO `tbl_interfascontableotrastipo` VALUES (1,'001','CIERRE DEL PERIODO',''),(2,'00S1','PAGOS A PROVEEDORES',''),(3,NULL,'RECIBOS DE INGRESOS CXC',''),(4,NULL,'NC BANCARIA',''),(5,NULL,'ND BANCARIA',''),(6,NULL,'DEPOSITO BANCARIO',''),(7,NULL,'EMISION DE CHEQUES',''),(8,NULL,'MOVIMIENTO DE CAJA',''),(9,NULL,'RETIRO DE AHORROS',''),(10,NULL,'DEPOSITO DE AHORROS',''),(11,NULL,'DESEMBOLSO DE PRESTAMOS',''),(12,NULL,'ANULACION DEPOSITO',''),(13,NULL,'APERTURA CERTIFICADO',''),(14,NULL,'APORTE SOCIOS',''),(15,NULL,'CANCELACION CERTIFICADO',''),(16,NULL,'SALIDAS DE CAJAS',''),(17,NULL,'OTROS INGRESOS',''),(18,NULL,'CORRECCIÃ“N DE REGISTRO',''),(19,NULL,'REGISTRO DE NOMINA',''),(20,NULL,'FACTURAS A CREDITO','');
/*!40000 ALTER TABLE `tbl_interfascontableotrastipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_interfascontabletipotrans_conf`
--

DROP TABLE IF EXISTS `tbl_interfascontabletipotrans_conf`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_interfascontabletipotrans_conf` (
  `ID` int(11) NOT NULL auto_increment,
  `IdTipo` int(11) default NULL,
  `Frm` varchar(100) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_interfascontabletipotrans_conf`
--

LOCK TABLES `tbl_interfascontabletipotrans_conf` WRITE;
/*!40000 ALTER TABLE `tbl_interfascontabletipotrans_conf` DISABLE KEYS */;
INSERT INTO `tbl_interfascontabletipotrans_conf` VALUES (1,10,'Nuevo DepÃ³sito'),(2,9,'Nuevo Retiro'),(3,13,'Apertura de Certificado'),(4,14,'Aporte de Socio'),(5,15,'CancelaciÃ³n de Certificado'),(6,6,'DepÃ³sito Bancario'),(7,4,'NC Bancaria'),(8,5,'ND Bancaria'),(9,16,'Egreso de Caja'),(10,17,'Otro Ingreso a Caja'),(11,11,'Egreso de Caja'),(12,12,'Apertura de Certificado');
/*!40000 ALTER TABLE `tbl_interfascontabletipotrans_conf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_interfascontabletransacciones`
--

DROP TABLE IF EXISTS `tbl_interfascontabletransacciones`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_interfascontabletransacciones` (
  `TransID` int(11) NOT NULL auto_increment,
  `TransFecha` datetime default NULL,
  `TransFechaMovimiento` date default NULL,
  `TransDescripcion` varchar(250) default NULL,
  `TransIDTipo` int(11) default '0',
  `TransUsuario` varchar(25) default '0',
  `TransEstado` varchar(15) default 'Nueva',
  `TransIDDoc` int(11) default '0',
  `TransDoc` varchar(50) default 'n/a',
  `TransDocDetalle` varchar(255) default 'n/a',
  PRIMARY KEY  (`TransID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_interfascontabletransacciones`
--

LOCK TABLES `tbl_interfascontabletransacciones` WRITE;
/*!40000 ALTER TABLE `tbl_interfascontabletransacciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_interfascontabletransacciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_interfascontabletransaccionesoriginal`
--

DROP TABLE IF EXISTS `tbl_interfascontabletransaccionesoriginal`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_interfascontabletransaccionesoriginal` (
  `TransID` int(11) NOT NULL auto_increment,
  `TransFecha` datetime default NULL,
  `TransFechaMovimiento` date default NULL,
  `TransDescripcion` varchar(250) default NULL,
  `TransIDTipo` int(11) default '0',
  `TransUsuario` varchar(25) default '0',
  `TransEstado` varchar(15) default 'Nueva',
  `TransIDDoc` int(11) default '0',
  `TransDoc` varchar(50) default 'n/a',
  `TransDocDetalle` varchar(255) default 'n/a',
  PRIMARY KEY  (`TransID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_interfascontabletransaccionesoriginal`
--

LOCK TABLES `tbl_interfascontabletransaccionesoriginal` WRITE;
/*!40000 ALTER TABLE `tbl_interfascontabletransaccionesoriginal` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_interfascontabletransaccionesoriginal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_interfasecontabletransaccionesdetalles`
--

DROP TABLE IF EXISTS `tbl_interfasecontabletransaccionesdetalles`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_interfasecontabletransaccionesdetalles` (
  `TransDID` int(11) NOT NULL auto_increment,
  `TransDIDTrans` int(11) default NULL,
  `TransDCuentaNo` varchar(15) default NULL,
  `TransDDescripcionCuenta` varchar(80) default NULL,
  `TransDDebito` decimal(12,2) default NULL,
  `TransDCredito` decimal(12,2) default NULL,
  `TransDBalance` decimal(12,2) default NULL,
  PRIMARY KEY  (`TransDID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_interfasecontabletransaccionesdetalles`
--

LOCK TABLES `tbl_interfasecontabletransaccionesdetalles` WRITE;
/*!40000 ALTER TABLE `tbl_interfasecontabletransaccionesdetalles` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_interfasecontabletransaccionesdetalles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_interfasecontabletransaccionesdetalles_tmp`
--

DROP TABLE IF EXISTS `tbl_interfasecontabletransaccionesdetalles_tmp`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_interfasecontabletransaccionesdetalles_tmp` (
  `TransDID` int(11) NOT NULL default '0',
  `TransDIDTrans` int(11) default NULL,
  `TransDCuentaNo` varchar(15) default NULL,
  `TransDDescripcionCuenta` varchar(80) default NULL,
  `TransDDebito` decimal(12,2) default NULL,
  `TransDCredito` decimal(12,2) default NULL,
  `TransDBalance` decimal(12,2) default NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_interfasecontabletransaccionesdetalles_tmp`
--

LOCK TABLES `tbl_interfasecontabletransaccionesdetalles_tmp` WRITE;
/*!40000 ALTER TABLE `tbl_interfasecontabletransaccionesdetalles_tmp` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_interfasecontabletransaccionesdetalles_tmp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_interfasecontabletransaccionesdetallesoriginal`
--

DROP TABLE IF EXISTS `tbl_interfasecontabletransaccionesdetallesoriginal`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_interfasecontabletransaccionesdetallesoriginal` (
  `TransDID` int(11) NOT NULL auto_increment,
  `TransDIDTrans` int(11) default NULL,
  `TransDCuentaNo` varchar(15) default NULL,
  `TransDDescripcionCuenta` varchar(80) default NULL,
  `TransDDebito` decimal(12,2) default NULL,
  `TransDCredito` decimal(12,2) default NULL,
  `TransDBalance` decimal(12,2) default NULL,
  PRIMARY KEY  (`TransDID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_interfasecontabletransaccionesdetallesoriginal`
--

LOCK TABLES `tbl_interfasecontabletransaccionesdetallesoriginal` WRITE;
/*!40000 ALTER TABLE `tbl_interfasecontabletransaccionesdetallesoriginal` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_interfasecontabletransaccionesdetallesoriginal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_inventario`
--

DROP TABLE IF EXISTS `tbl_inventario`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_inventario` (
  `fldCodigo` int(11) NOT NULL auto_increment,
  `fldCreado` datetime default NULL,
  `fldDescripcion` varchar(255) default 'N/A',
  `fldDireccion` varchar(255) default 'N/A',
  `fldColindantes` varchar(550) default 'N/A',
  `fldUrbanizacion` varchar(255) default 'N/A',
  `fldCiudad` varchar(255) default 'N/A',
  `fldProvincia` varchar(255) default 'N/A',
  `fldMetros` decimal(12,2) default '0.00',
  `fldPrecioMetro` decimal(12,2) default '0.00',
  `fldCosto` decimal(12,2) default '0.00',
  `fldVendido` varchar(2) default 'NO',
  `fldUsuarioCreo` varchar(255) default 'N/A',
  PRIMARY KEY  (`fldCodigo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_inventario`
--

LOCK TABLES `tbl_inventario` WRITE;
/*!40000 ALTER TABLE `tbl_inventario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_maestro_cobrador`
--

DROP TABLE IF EXISTS `tbl_maestro_cobrador`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_maestro_cobrador` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(450) default NULL,
  `fldPorciento` double(12,2) default '0.00',
  `Replicar` char(20) default 'Replicar',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_maestro_cobrador`
--

LOCK TABLES `tbl_maestro_cobrador` WRITE;
/*!40000 ALTER TABLE `tbl_maestro_cobrador` DISABLE KEYS */;
INSERT INTO `tbl_maestro_cobrador` VALUES (1,'COOPERATIVA 1',NULL,NULL);
/*!40000 ALTER TABLE `tbl_maestro_cobrador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_maestro_sector`
--

DROP TABLE IF EXISTS `tbl_maestro_sector`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_maestro_sector` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(150) default NULL,
  `IDZona` int(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_maestro_sector`
--

LOCK TABLES `tbl_maestro_sector` WRITE;
/*!40000 ALTER TABLE `tbl_maestro_sector` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_maestro_sector` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_maestro_socios`
--

DROP TABLE IF EXISTS `tbl_maestro_socios`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_maestro_socios` (
  `fldId` int(11) NOT NULL auto_increment,
  `fldDescripcion` varchar(450) default NULL,
  `fldCodZona` int(11) default NULL,
  `fldPorciento` int(11) default NULL,
  `fldCelular` text,
  PRIMARY KEY  (`fldId`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_maestro_socios`
--

LOCK TABLES `tbl_maestro_socios` WRITE;
/*!40000 ALTER TABLE `tbl_maestro_socios` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_maestro_socios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_maestro_zonas`
--

DROP TABLE IF EXISTS `tbl_maestro_zonas`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_maestro_zonas` (
  `fldId` int(11) NOT NULL auto_increment,
  `fldDescripcion` varchar(150) default NULL,
  `fldIdCobrador` int(11) default '1',
  `IDCiudad` int(11) default '1',
  PRIMARY KEY  (`fldId`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_maestro_zonas`
--

LOCK TABLES `tbl_maestro_zonas` WRITE;
/*!40000 ALTER TABLE `tbl_maestro_zonas` DISABLE KEYS */;
INSERT INTO `tbl_maestro_zonas` VALUES (1,'SOCIO FUNDADOR',1,1),(5,'SOCIO DIRECTO',1,1),(4,'SOCIO CORPORATIVO 1',1,1),(7,'SOCIO EMPRESARIAL',1,1);
/*!40000 ALTER TABLE `tbl_maestro_zonas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_movimiento_inventario`
--

DROP TABLE IF EXISTS `tbl_movimiento_inventario`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_movimiento_inventario` (
  `fld_id_mi` int(11) NOT NULL auto_increment,
  `fld_date_mi` date default NULL,
  `fld_description_mi` varchar(255) default NULL,
  `fld_entrada_mi` double(11,2) default NULL,
  `fld_salida_mi` double(11,2) default NULL,
  `fld_bce_mi` double(11,2) default NULL,
  `fld_pro_id_mi` int(15) default NULL,
  `fld_tipo_doc_mi` varchar(255) default NULL,
  `fld_tipo_doc_id_mi` int(11) default NULL,
  `fld_usuario_mi` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id_mi`),
  KEY `idx_prod_id` (`fld_pro_id_mi`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_movimiento_inventario`
--

LOCK TABLES `tbl_movimiento_inventario` WRITE;
/*!40000 ALTER TABLE `tbl_movimiento_inventario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_movimiento_inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_nc_bancaria`
--

DROP TABLE IF EXISTS `tbl_nc_bancaria`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_nc_bancaria` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_id_banco` text,
  `fld_fecha` date default NULL,
  `fld_descripcion` varchar(2295) default NULL,
  `fld_monto` double(11,2) default NULL,
  `fld_estado` text,
  `fld_transito` text,
  `fld_cod_concepto` varchar(255) default 'n/a',
  PRIMARY KEY  (`fld_id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_nc_bancaria`
--

LOCK TABLES `tbl_nc_bancaria` WRITE;
/*!40000 ALTER TABLE `tbl_nc_bancaria` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_nc_bancaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_nc_cxc`
--

DROP TABLE IF EXISTS `tbl_nc_cxc`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_nc_cxc` (
  `fld_id_nc_cxc` int(11) NOT NULL auto_increment,
  `fld_cliente_id_nc` int(11) default NULL,
  `fld_fecha` datetime default NULL,
  `fld_concepto` varchar(765) default NULL,
  `fld_monto` double(12,2) default NULL,
  `fld_user` varchar(150) default NULL,
  `fld_status_nc` text,
  `IDPrestamo` int(11) default NULL,
  PRIMARY KEY  (`fld_id_nc_cxc`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_nc_cxc`
--

LOCK TABLES `tbl_nc_cxc` WRITE;
/*!40000 ALTER TABLE `tbl_nc_cxc` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_nc_cxc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_nc_cxc_detalle`
--

DROP TABLE IF EXISTS `tbl_nc_cxc_detalle`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_nc_cxc_detalle` (
  `fld_d_ri` int(11) NOT NULL auto_increment,
  `fld_cuota_id` int(11) default NULL,
  `fld_ult_abono_interes` double(12,2) default NULL,
  `fld_ult_abono_capital` double(12,2) default NULL,
  `fld_id_ri_padre` int(11) default NULL,
  `fld_tipo_doc_ri_d` varchar(11) default NULL COMMENT 'n=nota debito, c=cuota',
  `fld_ultimo_abono_mora` double(12,2) default NULL,
  PRIMARY KEY  (`fld_d_ri`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_nc_cxc_detalle`
--

LOCK TABLES `tbl_nc_cxc_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_nc_cxc_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_nc_cxc_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_nc_cxp`
--

DROP TABLE IF EXISTS `tbl_nc_cxp`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_nc_cxp` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_proveedor_id_nc` int(11) default NULL,
  `fld_fecha` date default NULL,
  `fld_concepto` varchar(765) default NULL,
  `fld_monto` double(12,2) default NULL,
  `fld_abono` double(12,2) default NULL,
  `fld_balance` double(12,2) default NULL,
  `fld_user` varchar(150) default NULL,
  `fldstatus` text,
  `fld_ncf_nc_cxp` text,
  `fld_ultimo_abono` double(12,2) default NULL,
  `fld_chk` varchar(45) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_nc_cxp`
--

LOCK TABLES `tbl_nc_cxp` WRITE;
/*!40000 ALTER TABLE `tbl_nc_cxp` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_nc_cxp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_nd_bancaria`
--

DROP TABLE IF EXISTS `tbl_nd_bancaria`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_nd_bancaria` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_id_banco` text,
  `fld_fecha` date default NULL,
  `fld_descripcion` varchar(765) default NULL,
  `fld_monto` double(11,2) default NULL,
  `fld_estado` text,
  `fld_transito` text,
  `fld_cod_concepto` varchar(255) default 'n/a',
  PRIMARY KEY  (`fld_id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_nd_bancaria`
--

LOCK TABLES `tbl_nd_bancaria` WRITE;
/*!40000 ALTER TABLE `tbl_nd_bancaria` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_nd_bancaria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_nd_cxc`
--

DROP TABLE IF EXISTS `tbl_nd_cxc`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_nd_cxc` (
  `fld_id_nd_cxc` int(11) NOT NULL auto_increment,
  `fld_cliente_id_nd` int(11) default NULL,
  `fld_fecha` date default NULL,
  `fld_concepto` varchar(255) default NULL,
  `fld_monto` double(12,2) default NULL,
  `fld_abono` double(12,2) default NULL,
  `fld_balance` double(12,2) default NULL,
  `fld_user` text,
  `fld_status_nd` text,
  `fld_ultimo_abono` decimal(10,2) default NULL,
  `IDPrestamo` int(11) default NULL,
  PRIMARY KEY  (`fld_id_nd_cxc`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_nd_cxc`
--

LOCK TABLES `tbl_nd_cxc` WRITE;
/*!40000 ALTER TABLE `tbl_nd_cxc` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_nd_cxc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_nd_cxp`
--

DROP TABLE IF EXISTS `tbl_nd_cxp`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_nd_cxp` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_proveedor_id_nd` int(11) default NULL,
  `fld_fecha` date default NULL,
  `fld_concepto` varchar(2295) default NULL,
  `fld_monto` double(12,2) default NULL,
  `fld_user` varchar(450) default NULL,
  `fldstatus` text,
  `fld_doc_afectado` text,
  `fld_doc_afectado_id` int(11) default NULL,
  `fld_ncf_nd_cxp` text,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_nd_cxp`
--

LOCK TABLES `tbl_nd_cxp` WRITE;
/*!40000 ALTER TABLE `tbl_nd_cxp` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_nd_cxp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_otros_ingresos_caja`
--

DROP TABLE IF EXISTS `tbl_otros_ingresos_caja`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_otros_ingresos_caja` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_fecha` datetime default NULL,
  `fld_concepto` varchar(550) default 'n/a',
  `fld_proveedor` varchar(255) default 'n/a',
  `fld_fact_proveedor` varchar(255) default 'n/a',
  `fld_monto` decimal(10,2) default '0.00',
  `fld_user` varchar(30) default 'n/a',
  `fld_categoria` varchar(255) default 'n/a',
  PRIMARY KEY  (`fld_id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_otros_ingresos_caja`
--

LOCK TABLES `tbl_otros_ingresos_caja` WRITE;
/*!40000 ALTER TABLE `tbl_otros_ingresos_caja` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_otros_ingresos_caja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_periodos_contables`
--

DROP TABLE IF EXISTS `tbl_periodos_contables`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_periodos_contables` (
  `fld_id_pc` int(11) NOT NULL auto_increment,
  `fld_fecha_inicia_pc` date default NULL,
  `fld_fecha_termina_pc` date default NULL,
  `fld_estado_pc` varchar(10) default NULL,
  PRIMARY KEY  (`fld_id_pc`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_periodos_contables`
--

LOCK TABLES `tbl_periodos_contables` WRITE;
/*!40000 ALTER TABLE `tbl_periodos_contables` DISABLE KEYS */;
INSERT INTO `tbl_periodos_contables` VALUES (1,'2023-01-01','2023-12-31','ACTIVO');
/*!40000 ALTER TABLE `tbl_periodos_contables` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_periodos_contables_meses`
--

DROP TABLE IF EXISTS `tbl_periodos_contables_meses`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_periodos_contables_meses` (
  `fld_id_mes_pc` int(11) NOT NULL auto_increment,
  `fld_no_mes_pc` varchar(5) default NULL,
  `fld_fecha_mes_pc` date default NULL,
  `fld_estado_mes_pc` varchar(10) default NULL,
  `fld_id_del_periodo_contable` int(11) default NULL,
  PRIMARY KEY  (`fld_id_mes_pc`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_periodos_contables_meses`
--

LOCK TABLES `tbl_periodos_contables_meses` WRITE;
/*!40000 ALTER TABLE `tbl_periodos_contables_meses` DISABLE KEYS */;
INSERT INTO `tbl_periodos_contables_meses` VALUES (1,'01','2023-01-01','ACTIVO',1),(2,'02','2023-02-01','ACTIVO',1),(3,'03','2023-03-01','ACTIVO',1),(4,'04','2023-04-01','ACTIVO',1),(5,'05','2023-05-01','ACTIVO',1),(6,'06','2023-06-01','ACTIVO',1),(7,'07','2023-07-01','ACTIVO',1),(8,'08','2023-08-01','ACTIVO',1),(9,'09','2023-09-01','ACTIVO',1),(10,'10','2023-10-01','ACTIVO',1),(11,'11','2023-11-01','ACTIVO',1),(12,'12','2023-12-01','ACTIVO',1);
/*!40000 ALTER TABLE `tbl_periodos_contables_meses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_prestamos`
--

DROP TABLE IF EXISTS `tbl_prestamos`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_prestamos` (
  `fld_id_prestamos` int(11) NOT NULL auto_increment,
  `fld_id_del_cliente` int(11) default NULL,
  `fld_clasificacion` varchar(55) default 'N/A',
  `fld_fecha_entrega` date default NULL,
  `fld_fecha_termina` date default NULL,
  `fld_fecha_calcula_interes` date default NULL,
  `fld_cantidad_cuotas` int(11) default '0',
  `fld_monto_cuotas_a` decimal(12,2) default '0.00',
  `fld_capital_prestamo` decimal(12,2) default '0.00',
  `fld_monto` decimal(12,2) default '0.00',
  `fld_abono` decimal(12,2) default '0.00',
  `fld_balance` decimal(12,2) default '0.00',
  `fld_usuario` varchar(255) default 'sixa',
  `fld_fecha_ultimo_abono` date default NULL,
  `fld_status_prestamos` varchar(15) default 'Nuevo',
  `fld_anos` decimal(12,2) default '0.00',
  `fld_interes_p` decimal(12,6) default '0.000000',
  `fld_tipo_prestamo` varchar(255) default 'MANSUAL',
  `fld_ck_no` varchar(11) default '0',
  `fld_tipo_garantia` varchar(50) default 'N/A',
  `fld_garantia` varchar(1500) default 'N/A',
  `fldFinanciamiento` varchar(2) default 'SI',
  `fldMontoFinan` decimal(12,2) default '0.00',
  `fldMontoInicial` decimal(12,2) default '0.00',
  `fldCodInm` int(11) default '0',
  `fldDescInm` varchar(255) default 'N/A',
  `fldMetros` decimal(12,2) default '0.00',
  `fldPrecioMetro` decimal(12,2) default '0.00',
  `fldTazaMora` decimal(12,2) default '0.00',
  `fldNota` varchar(1001) default 'N/A',
  `IDVehiculo` int(11) default '0',
  `GastosLegales` decimal(12,2) NOT NULL default '0.00',
  `Seguro` decimal(12,2) NOT NULL default '0.00',
  `CtaIngreso` varchar(13) default NULL,
  `TipoDesembolso` varchar(14) default NULL,
  PRIMARY KEY  (`fld_id_prestamos`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_prestamos`
--

LOCK TABLES `tbl_prestamos` WRITE;
/*!40000 ALTER TABLE `tbl_prestamos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_prestamos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_profiledocument`
--

DROP TABLE IF EXISTS `tbl_profiledocument`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_profiledocument` (
  `fldCompanyID` int(11) NOT NULL auto_increment,
  `fldCompany` varchar(255) default 'N/A',
  `fldAddress` varchar(255) default 'N/A',
  `fldPhone` varchar(255) default 'N/A',
  `fldRnc` varchar(255) default 'N/A',
  `fldPassDescuento` varchar(255) default 'N/A',
  `fldPassConfig` varchar(255) default 'N/A',
  `fldPassAdmin` varchar(255) default 'N/A',
  `fldNotaRecepcion` varchar(255) default 'N/A',
  `fldDiasVenceFC` varchar(255) default 'N/A',
  `fldColorForm` varchar(255) default 'N/A',
  `fldDiasGracias` int(11) default '0',
  `foto` longblob,
  PRIMARY KEY  (`fldCompanyID`),
  KEY `fldCompanyID` (`fldCompanyID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_profiledocument`
--

LOCK TABLES `tbl_profiledocument` WRITE;
/*!40000 ALTER TABLE `tbl_profiledocument` DISABLE KEYS */;
INSERT INTO `tbl_profiledocument` VALUES (1,'CRESCOOP','Local 12, 2do. Nivel, Plaza Italia','809-795-6278','','','','','','','',5,'ÿØÿà\0JFIF\0\0\0\0\0\0\0ÿÛ\0C\0	\n\n			\n\n		\r\r\nÿÛ\0C	ÿÀ\0\0\0\"\0ÿÄ\0\0\0\0\0\0\0\0\0\0\0\0\0	\nÿÄ\0k\0\0\0!1AQaq‘	\"2Vt”¡²Ñ#57BRrs‚’“±³ÁÒ34STbu¢Â$%\'68CDFUcd„•ÃÓðEvƒ£á¤´µÔñ&We…ÄÿÄ\0\0\0\0\0\0\0\0\0\0\0	ÿÄ\0K\0\0\0!1AQa‘\"4Rq¡±ÁÑ2ráBS‚’ð#35Cb²ñ$%¢ÂTƒ“ÒDÓâÿÚ\0\0\0?\0Ú€\0û|\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0Þ=P,›k“>>kÍ¸NÃ+âí¨®Múú’ìŒy¶F¡t†Ì™ŽU0ü¯)á{Õ:‘ÙW|—°_sÇ¼Óf™æ*.ÎµsSNÖ&+k|ïèH¬É´\\”Ô–9˜-¨T\\¨©oÔüXêÎ<‘´L¿´\nW•²üî%NÊq§RUiî)9&ÓZñê!ZÕ«Ô•ZõgRrzÊR–­¾öHî‰üpŒÁîŠE{)Ú|Fi˜Ó‡äÅ4N½sº&xþ~4¹ŠÄE½\"#µŸ\0é»\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0Zå¹ð1þÔ¶³ƒlçQžíÞ+pµ·´‹â¿—7Õð•ÚÆÔ¬6oƒ:P¸Ånbãinß\r~Þ_É_	ñ¬kÌ8|_¼ÍÕÄœ§R_™.¥Ýÿ\0n£´[Ctx¾}Éÿ\0Çõÿ\0™jsÆ0ÿ\0ÙÛü_w5ç:b³Åó!R½WÂ×HRÚÆ<’>:šë,+¡Ëî\\ªõS]ÉÖgŒÊ±TÍsÊªu•ûÝ„“èšõÂ3ºh|Y§—Y%z%ýGÌé¡ñdX6R?î¶ý•|%°Ê½*žßƒ>€¼¶€\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0ÃÎ·Éxæ`Å$•húØëÆ¤ß±ŠïoCíJM=5Ð‰}#v‰S3fo‹pÜ\"MKuð«qöR}ÑOuyM>w™ÆW…›±ø§u>ßÓ‹ŠŒ%™¯Ÿ›ÚÇY»6bÙÓ¹ÇñŠÎu«ËÖÇ_[JØÂ+©%úßYñõE ãw+ªõs]s¬Îù•6ªæ¹šªfWÝt*¥Ú|h…I-Ñ3ê>`}—4>,ˆÓÌ’½ßöŸ0{¦Å‘aÙOñ[~Ê¿Û-ŽSéTöüø\0uå¸\0\0\0\0CÆ°Ü\ZŒ.q\\BÞÒŒæ©ª•¦ œ´oM_‰Ÿ;çÿ\0%{kÂ½õ”ñ¯jÜé]Q×0ùšé¦t™z\0yÿ\0Ÿü•í¯\n÷Ô>Qóÿ\0’½µá^ú‡Ê|øÝ^;áŽ˜z\0yÿ\0Ÿü•í¯\n÷Ô>Qóÿ\0’½µá^ú‡ÊGØõã¾G­ï@óý’½µa~ú‡Ê>²W¶¬/ßPùIñ«¼wÁáhé‡ßÀùÿ\0É^Ú°¿}Cå)óÿ\0’½µa~ú‡Ê<jÇ¯ðxZ:aèçþòW¶¬/ßPùGÏöKöÕ…ûê(ñ«¼wÁá(é‡ ŸùþÉ~Ú°¿}Cå?Ù/«5a~ú‡Ê<jÇ¯ðxJ:aèð>rg¶œ/ßPùGÏîLöÓ…ûê(ñ«¼wÁáhé}ð|ŸÜ›í£÷Ô>Qóû“½´a~ú‡Ê<jÇ¯ðxZ:_|ç÷\'{iÂýó”¯ÏîNöÑ…ûê(ñ«¼wÂ<-/¾‚³ÞMçFï¨|¥~~rw¶Œ3ß0ùGXõã¾áhé‡ÝÂùùÉÞÚ0Ï|Ãå?Y7ÛFï˜|£Æ¬zñß…£¦tçÌ˜—÷Ñ†{ê)cÚI<×…/Ô>R<oëÇ|Z„sè‰‘ºóvï¨|¡m#>Y·\nïPùGŽa¿yO|#ÂÛõ¡èÁðig¬ŸW]ÌÑ†K³K˜|§r†aÁ.V´1›)÷F¼_ë>©ÄÙ«ð×Û¨¹Lð—Ò+Óª·¨Õ…EÛ&¾’/SÛX}*\0$\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\r¥Íè’Úvl†LÉ˜¦:æ•Zt];tþÊ´¸Cáâû“ ½jÕn+T¸­7:•dç9>m¾-’\'¥žc{¸6U£Qn·+ÚÑO›^¶\Zùåç#ž«´å›]ŒœF;ÀÇ\n#NÙß?(ìUs‹órÿ\0ƒæ§â®«°®¨´F£ríWiRÔôÝÀÞ¸’Ýþ£ftÐø²#F¨’ýZù˜=ÕCâH±l¯ø­¿âÿ\0l¶yO¥SÛðgð×à\0\0>@¶Û–¥™ös‰[Q†ý{X«Ê).;Ðâôñ­W”…ïTl:´#R”á8©FQjI®\ru›kÙã\"ç+«8Ò’±»næÎzptäýŽ½±|‘õœ÷m2úµ£Lnü3òùû•üêÄù·£Ù?\'‰OBäõ-×R…F…ÈšH®ò8ôcV4º¾Ñ«í,M.²»ÇÎˆÑv¯´ªe©êT—Z\0¸L®«´¬«ª\\Æ±|J48¯E5]¨´®óì#Ap-MkÈ»TF† ÞK€ÕÊk°©`‘><ÊœjoR»Úó\"a+ÁiTÖ„h*]Ê\rJ2kNÆ[ªí£i˜1«))Yb×”\Zâœ+É~³Õ`ûjÚNãàs5ÅÄ#ÎÔcY>ídµÓÄÑáte›8ÜN\Zu³rª}“0ô¢õË‚©ŽÔË½(*7\nY«/Å.N½ŒÞŸ‰\'ýgâ2ÖUÚ&SÎ1þÑã4ªÕÓWBorªüúµ!*“rÐ¹­oVèU*°jPœ$ã(µÖšäY°gÂÌSK”õîžøùÄ¶sköçûO:=éù)=zŠ‘ ô‰Æ0‡KÎ´ÕGÓ)ý>µý¿—‰\"°,w	ÌX}W½¥umYkÂZùZk±+Îð™µ:Ø«Îç¦xÇõÔßá±–±Q­¿£ô€ÕvƒnÊ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\'¦«T^YS·³‰!HŒbX¦Ôq*JZÂÆí£ÙÂ)¿†_w—i÷¶…óO=c÷ÉêªâW?rª5#ÏœKsÃâ®\\éª~*&&¹¹zªºfWêûJïvœz²»ÈÂÑã«“TÁbz•Õ¢4_¢GÔ|ÃîšDgRí$ÇDŽ8>`÷U‹\"Á²±ÿ\0u·ü_í–Ï)ôª{~	\0:âÜ\0\0\0\0£Z­µÝœÑÚW©gN0Ž#h[:²ûuÎ\röIpñè{ÒÙÅÉhž‡†\'\roj«7cZf4—ÅÛtÝ¢h¯„µë}cy†^VÃïíçBâÞnJsZJ2OF™Á¯b%FÝv.óUšrÍ,ZÞ\r×¡š‚ìþZøH³R(Ô•\ZÐ”*BN2Œ–5Í4q¼ß)»•_›Uï¦xOL}zTÜ^¼%ÎLðæ•º°5] Õ1u\nò)Ç¸ê¹>ÖW{N²Ñå r)-9QÄ]¼FˆÑÈ¸—)\'È\n•Oµ”\0Õp,âT‡Èj†§Î‰ÕTßZ+½Ü[¨\Z¥v½Ì®¥œ{ŠêÈÐ\\\nkÜTªz\rîâ€„®ÕMëÌ°®¬\Zô¹7»Æºœ{ÝÅSÔ&‚Äô+¼F‚§¦Èû@ÌWØEÃ•)µáífßƒª»×Sï<Î«´®èô±zæ\Zä]µ:U%÷Eu[ª*¦t˜Mœ‡Ÿ°ù…ÇÂ«8ÕŠÒ½¼ßÓ(Ï±ö®ÇÖz…$ø&AœŸ›ñŒ•QÆ°zî3¦×„¥\'¬*Ã®]kós&EÎøVxÀéc8l´rõ•¨Éúê5ãú»Q×vshhÍ¨ðWw]Ž=}qó…§/ÇÆ*95þ(÷½()¼µÐ©il€\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0g=Ý9.,u\Zmh¹ž\'>í{(ìö‹XÅê«vÖ°³·ÒU¤û×(®öFüëÒ?=æzÕ(aÖ	e-t¥nõ«%üª›Disû—yµÎµtGÞh`b³]ÕN³Ñ	…ªr¨©:Rc½ÇÌs‘£n)‰b{U¥<BþâæR´¯&êÕ”›z.ÖKÃß(Ì¼«boÅ<ó\Zk¯CÓŠñ»~#MúYn\'&ôI=NC§‹ÔðXmÕ]tÜ¡R_ÑfÊ©Ò&Yr×ÝwswZâOWV¤¦ß{zœEº²º£„Ìë½Ïu×z ¦«´©\05`]îâMtFzàù…´Ðø²#!&º\"ýHÌ^é·ø²,/þ)oø¿Û-žQéTöü\0u•¼\0\0\0\0\0là§¦­­8˜glÛ´Íª¶bÊÔáCÝÞ«G]Úw^>É÷õõö™ µÂ2zµÅxì\rŒÂÌÙ¿\ZÇ¾:áã~ÅŠ&‹‘¹¯;ü>ÿ\0¼­aˆÚU¶¹£7\n”ªÅÆQ’|SG¬›;FÙ.XÚ´•í/JâŽ”ohÅoÇ‡%öK¹‘_=ìŸ7d‰¬NÉ×²ÞÒ´\"åJK«_µ}Ìå™¶ÏbrÉš¢9VúcçßW—]ÂÎ±¾žŸ«Çê†©–yJë¡_Ñ¯\\\n)v•Õ áÞPêM§ª(T\'UwµæUI\"ß!B44r§ªÔj»N=çÚUIjFˆÑÈ5Ð¢’|º.ÞcUÖ[® \Zè»WÔŠ–Y.+«-×°ª×´hUÕ•Z÷‚4‚ÝXÕö‘ ¸^2¤hj®¬o2€v¥ue…ud\Z¯O´ö[.Úæ@ÌP¼Œå;–©ÞÑê”5öKùKš~CÅ\'ÚWUÚ{á±0—i¿ftª™ÖvîUj¨®‰Òa?pûÛ|FÎ•õ¥XÕ£^*¥9Åð”ZÕ3²`N{@©uk_#b5õ²uìe\'Çsì©ùãfz‹Õk©Ü2¬ÆŒÓN\"Ž~1Ñ<ñýs.x[ôâmEÈT\0l™\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0¸³Š½jTèÎ¥IÆ0Œu“oD—kdp¯R4©º“œañr“Ñ$GM­ô“VÒ¯—²hÎ¬[§Wæ¢úüëÊókn›u­˜k×ÊYFòPÂ©7NâêÑÝ>µö‹áñ5=J{´•LÎ;¹êú}{•¼Ç6fÖ}³ôú»w·W×3»½¸«^½W½:•&å)7ÖÛâÎ$õE £ÎùÕ_ß,¿Ñƒë§GÜuþ*&1\rº.ýu({Ž¿ÅDÉ:fÈÿ\0‡ÏæŸ„-Ù/£vÏÈ>~?õ÷%oˆÏ t1èï`·ëý–¯Äe–ïàŸckW»kæW{¸á“yª¥ue5]£TF‰W{¸ªzõ€•ä™è‰õ#1{¦ßâÈŒš´I¾ˆŸQóºmþ,‹Ëÿ\0Š[þ/öËe”z]=¿„\0ap\0\0\0\0\0\0\0\0QÅ>i2Ë‹{{ª3¡sBZsMJŠ”d»\Z|Î@DÄNéo;tlÊ9†Uorô¥‚ÝÍë¹MoP“û±òpî0fmØ†Ð²–ýjØ4ïía¯öE’ub—k²•hMr’×N®cö_™®˜äUÓOîÚ5·ò«÷Ärg©®¹FQ“ŒâÔ—4Özc™(æI9ãyrÆêr\\jNŠSüe£<mÿ\0G˜ÝÉÊMÕ»À\\É%ç*÷¶/Lÿ\0e]5G^±õøµuä—£ðUîCÝY]äJÙtZÈ5q½Å)÷xTÿ\0<N?R¶Fÿ\0Jb¿ÄÌº#½åä|OWz+ê˜%Rè¯‘þcŠ?ýØþÉrèµ—ùv)ùhü„}ÐÌº#¼ò>\'«½Á+½KYøî)ùhüƒÔµŽâŸ–_ û¡™tSÞŸ#âc£½µîE	]êZÈ?ÇqOË/z–òñÌWòÑùÝÏ¢žóÈøž®ôQ*™+½K™øî)ùXüƒÔ¹Žb¿–È>èf}÷§Èøž®ôSRÐ®÷q*ýK™øæ+ùhüƒÔ¹Žb¿–ÈGÜüË¢žôyÕÞŠ›ÝÅÄªõ/dã˜¯å£òõ/dãx¯å£ò¹ÙŸE=ç‘ñ=]è¨	Yê_ÈÆ±OË/z˜2ñ¬SòÑùû™ôSÞyÕÞŠ‰uëÐ•~¦ükü´~Aê`ÈÆ±OËGäs³>Š{Ï#âz»ÑT§ÔÁ?ŒâŸ–ÈWÔÅ?ŒâŸ–_ û™tSÞyÕÞŠ£Ÿ2Uz˜rñœOòëä¦ƒügüºùû™ôSßú\'Èøž®ôVZ.ÒåÈ”þ¦€¿ÊqOË¯z˜²ñœSòËäss>Š{ÑälOWz+ê»QRTz˜òñ¬SòËä£Ïÿ\0bŸ–_!ss>Š{ÿ\0DùÕÞŠà•>¦,ügü²ù©‹ Ä¿,¾B>æf}÷£Èøž®ôoÉùŠã*æ\\?·”µ³¯Í\'ì¡öQò­I×oZÅ\nwd¥N¬Tá%ÉÅñLÄo£AMiq‰þY|†UÂ0êXFg…P”åJÎ„(BSzÉÆ1I7ß¢./•cr˜¹o§&t˜ÒußÏß»¹¶Ë0·°±U78K¶\0-­ \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0×%ºÈÓÒ?lN2«³ìµuÉîâ•©Ë›þ?æí2–Û6OgY>­Õ½XüÓ¾nÞÆ\ZñRÓ×OÅÇÆÒë!jõnkT¸¯VU*Õ“œç\'«“oVßyMÚŒÞlSâvgÎŸÅÕ¿kEœc¦Ôxs¾xû:;Vóá©UÃ­ƒŸ*ëµ]£TZW‡h{¢ïªQKøÇÅDÉ!·EÎU¡î+Š‰’t½‘ô	üÓð…»$ô^ÙùOZáW‹¶Þ¢þ‹;‡WŽöt»hÏâ²Ë_á–ÞwµÌÚÔ¾-°pÇ:_£‹wŠê»@¹K´j‹@Ñ:¯$çD/¨ù‹Ý6ÿ\0DaÕ’{¢ÔlÇî›‹#²ñÿ\0t·ü_í–Ó(Ÿúº{~	\0:ºà\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0NrŽºiÁkÄ¼ñÛYÍK%ägŒ÷kS·t­»ëTõó9kâLò½v›ê»_‰žçÍÊâÝ3]\\!öûž%6wà*ïXaÙÛ-xz×ëåå’~dceÌJr©\'9ÉÉÉêÛ|ßiCâo×Š½UêøÕ:¨®Õ~åW*ã+µEV¬°ú<×½:n­Þí#A—ú.qÚ¥q\\|TL¢\ZtZãµZã¸ø¨™gJÙ/@ŸÍ?[²OEíŸu±?©÷+ýLþ+;\'[_ÚûŸ¼Ïó2Í_á–Ý®&Þ£TSUÖŠ9Î—j»J–Õõ‘ ¹=\nïv–ï ž¤h/Õw¢þÓæ%þÓoñdFOô@ãƒæ?tÛüYý˜ÿ\0·ü_í–Ï\'ôº{~	\0:²ä\0\0\0\0\0\0\0\0\0\0\0\0\0\0á¸¸ðªUqmS‹“IjÞ‹¬Ä“éI³šU%J­®1A¸ÉzZ<\Zæ½‘˜#-uZëÌƒÛfÊ²Ê;AÅ,=Û{™únÝéÁÓ›×‡‰ê¼…ohó^Yj‹Øm4™Òu}Ÿ6·3ÄÞÂÑÚáÎ^ªm™ÿ\0ŒûÖ?¶=T»3þ÷¬lˆjO^eÛÚõ•½Ù”z½ß«Må¬OWr]z©viü3ïXþØõRlÓøcÞ±ý²\"êÆ«¬½ù—ú{¿SË8ž®äºõQìÛø_Þ±ý±ê¤Ù¯ð8¿½cûdGÞï+«|3/ô÷~§–q=]Éoê¤Ù¯ð8Ç½cûe}T{5þ÷¬lˆú²š¶GßËý=ß©åœOWr\\ú¨¶kü/ïXþÙ_UÍ‚ÅýíÚ\"2zv•×^·ç|3/ô÷~§–q=]Éqê¢Ù¯ðX¿½£ûE=T[5þ÷¬h‰>WçWç|3/ô÷~§–q=]Éoê¡Ù§ðx¿½cûcÕC³_à±zÇöˆ‘åcWÚ>øf_éîýSåœOWr[ú¨vmü/ïXþÐõPìÛø,_Þ±ý¢$©v¶W]zßœ}ñÌ¿ÓÝúžYÄõw%¯ª‡fßÁbþõíõOì×ø,_Þ±ý¢$ù_œy_œ¾9—ú{¿SË8ž®ä¶]\'ökö˜¿½cûe}SÛ6þ÷¬h‰\Z÷•OÊ>øæ_éîýO,âz»’ÛÕ=³oàñzÇö‡ª{fßÁâþõí\'Q«í#ïŽeþžïÕ>XÄõw%³é=³ŽªX·½£ûE¥Î—+laÿ\0»CöÈ™«í*¥Ä}ñÌÿ\0ÓÝú£Ëž®ä°}(öv¹XcoÅoOöÇª“gŸèüoÞôÿ\0êE>:²©ê|ýñÌúiî<±‰êîKô ÙÌžŽß‡ŽÚóLíÐé\'³\Z¯J——ô~îÒOâêDP¸NÙfQÇ“=Ÿ©Î&:;“>Ïn{0½iSÍ4)ïrðÔçOOÆG¤Ã³–VÅ’xn`Ãîà”.#«òj@Íxê]\n’§-ús”$ºâô2ímÆ*™þÖÕ3ìÖ>¯j3»‘ø©‰lUÕé¢å©|e¼A¼¿´Ü÷–g˜ùšöœ\"øQ©?Oñ\'ªó#.e.”³Ö¹ÇŠêwV|<®õ?!¿Ám†1Míhž½ñß8†}œÞÅÉÒ¿6}É‡–óŽ_ÍÖ~žË¸­ÊkMåëé·Õ(¾+Ê}¸½b›-VîÑz˜®ÜëÏJjŠãZgXT\0z$\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0#ßKìuÛeÜ/Ó—Ë©\\MkÍB:/†L„FésˆºùóÃµÕZaêZ}ÜŸìš-¤½à²êôçÒ=ínmsÁá*ÓŸH`Íî#{¸µr*rÝ½zW\'ÜBz•À¦­õ×´¿Ñiÿ\0uZâ¸ø¨™„2è·/î­CÜW˜™§IÙ?@ŸÍ?[²OEíêâ¼.>õ?ŠÎÑÕÄþ§Üýæ–Jÿ\0·\rp‚Ý_QT×iÄ4s•JëÜŠj»A\08õ®€W]:‰AÐûê6c÷M¿Å‘‰CÐõ¯˜ÙÝ6ÿ\0fûfÄíöü%³Éý.žß‚C€ª¹\0\0\0\0\0\0\0\0\0\0\0\0\0\0é³ßžÌ­ów §‰`Ñ•M#]Rƒã8ù4Þ^\'Úf“Q”%GTÓMv£„£b¬=Îñ=+öi¿nmÕÂZã^ÛîÉg“1‰fLÝüÆÄfäãÂÞ³|cÝÍvk¡ˆN7ŒÁÝÀÞªÅØßþµýš°÷&Ý|`Õö•O´ 1^KŠêûK\Z\'W&ðORÍâº®Ò4Yjo¨®÷j>t¤†÷qn¨/«™Vû\0¨Õ”O´j\rUÕö•Re\0Ñ+o\"ªDh*W^äQ=A	W^äP\0j®¯´)4\n¹\"õ\\YW#ŒjÑ\Z\Z9JhŽ4Þ¼ÎMåÔÈÑ\nt(ž¥HüÅòíô1L­gsMúÚ”¤Ó}Íu®çÀ‘û.écJŽœeùi\nWK…\ZÏ©Kí$üÝë‘G‰èmrÌã•WÊ³>o=3Â~žÖVwV´NîŽfÃ#(Ê*Q’’kTÓæT‹»\ZÛ­ÎZŽYÎ­†IÆ÷SzÊÛ±IõÃá^\"OQ¯Fâœ+P«\Z”ê%(J/U$Ö©§×ÀëYVmc6³á-N“cž?®i[0¸«xº9TvÇC\0m \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0	:MÜ»¯bPo_KÐ·¤»¾–¥ýbl·£]äéUÖÛc“~Æ­(y¨Am­«L1ÓT|%¥ÏgL<G_ÊXõK¸®©–ƒ*‹ÁfºÞÑp(™PF¬½ÑkŽÕèiüJãâ“<†>ºô=ÅqñIžt“ô	üÓð…»#ô^Ùù[za÷?yŸÅgdêâSî~ó?ŠË†[–·Mîâ§ÑÎB©”Avò*ž¥€äŸè}ÇÌžé·ø³\"òz‡¡ëþÓfGþÓoñfovf?îvû~Ùäþ—OoÁ\"@T\\€\0\0\0\0\0\0\0\0\0\0\0\0\0\0ÀçãX6Žáw8N1gNêÒê•JsäÓøSìkŠd3ÚæÉ1M›â~\Zœ*\\`×3ÒÚçwØ¿´žœžžt‰·%ªÐùøÎ†ã¸ml+´§uksÊ´æµMvø×4Í&s“ZÍ­i;«Žòž¯ƒ£Fœ*Ž×™C-í{`Ø¾I­S\ZËÐ«‚M¹KukR×ºk®?Êó˜‹W¦¯S–bðWð7fÕútŸ±P¿b¼=|‹‘¤¯»ÅÆ+È8•©èW™h#Av¨»WÚŽ2»ÝÄL\'UûÈ\'©khEëÜ|è/*šH·_(Þî#Av¬®ò-¥qR× ž€Þ¸jÊ\'©Pj®ó+ª-Dê¸­Q]â40BBºiÖPêªm)ö–ò/Þ×‘UÈã\Z±¡£”Î;ÛÁn(d¼Ívý!V[–UêK÷	¾Pmý‹|»ì0Vó.RÑ§½ÈÍË±÷²Ëñ~ÌïŽ1ÓöÃß¯\rr.Qÿ\0-†ÆjZi¯©qˆ¶´ßžÜ	à8µÆö-…ÁGYKz<”ûÚäü¬Ë‰êvŒ6Þa‡§k„ûº»;©¿n.QÂU\0P\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0²êñ3n½­f]¥ý“Î\\×Œ[tÕmo3&ÿ\0Ê×Ä‰SÚïE£ó|¥£Ï¿¸§Ûò—†RÝY]Q@U\0¡¨5} ¢ufŠï]«ÛûŠãâ“@…ÝŸ÷W·×ø•ÇÅ&‰ÑöSÐ\'óOÂìÑ{gä\\O÷Âí¥?ŠÎÑÕÄÿ\0xÜ}ê–:ÿ\0·\rnˆ©Å4se]äWTZu]ª`µ2»ÝÄ{R©(z}FÌ‹ý¦ßâÌ‹»È”]þ£æOtÛüY›Ýšÿ\0·Ûð–Ï(ôº{~	\0:’ä\0\0\0\0\0\0\0\0\0uo1;9ÝÝÓ¥Üßâ\\ÙŠÅáð6¦þ&¸¢ˆã5LDG¶gH}SEUÏ&˜Ö] Ï-wžì©·;j•´û)zÕòŸ&ã;âõ_ÒcF’îŽ¯á9~mö×±ùTÍâ&íQÍn™«ÿ\0)Ò™ì–ÊÖO‹»¿“§µïµ\Zñ1•\\ÉŽU×{¬µûV£ùŽ»ÅqIq–%tüu¥ò”¬Gÿ\0QÙ=3¦v¨ëš)øMLÚv~ìþ*ãÞÊº÷\r_aŠ–+ŠGØâWKÅZ_)Ø¥˜ñÊZnâUžŸlÔ¿8Ãÿ\0õ“Õ?õ;´ÇTÑWÆi*Ùû¿³\\{Ù8¤¢¤x|ï‹ÒáZ4«.øèþëZg»*+Ëj”_ÛG×/”ºå?m{šÌQV\"mU<×)šòiï–ÜŸk\'_cÒÔ¡N¬:‘ÞŒ“M>MGj=0lÅV®1“gKÄ%ë§n×ö=gÜ—K½pîë3Ež\'eû;ºu{R|WsGaÂ2ã%©Ñ*·€ÏpÑU3MÊ\'…TÌL{ba§Åa)½ý=üZüÍ/3dëÇe˜pšö’Õ¨NQõ•;ã.Lø†Å1L	ÆìêaØÆBöÚªÒt«ÁN/ÈÌ\'œº,å¬NU.²ýL*³ZªÖ­{¾¹yÙMÌ6Bý©åa\'•º~“îW19-Ê7Ùc£ùRí2gØ.ÓrÃ•Iåú˜¼ÇX?Ÿ{ŠõËÌxK‹Û9ºw–u¨Î<jSqkÎU¯á/áªäÞ¢iž¸j.Y¹ft¹LÃ‹UÚ\n2š³æ¼Þ\Z®ð*Ð\0*¥ÚWTZÐ_Ã¼o2ÍY]îãçDê½2§\Z’ëEÛÝ„Ln¬ª}¤h.Õ•Õv–‚\rËµL©fº×´×š¡Ì\'UÛÌ®¨´ ¸êÊï¢U=@\"UáÞP\0_w$æ«Ü›™¬s”š•µEá#Õ:o„¢üh8>#m‹á¶Ø­E:t¡Zœ—\'-Q¯WZtcÌuqŒƒS¸¨ç<æTi·üýt|Òß^$‹¶ÅãæÝú°up«|{c||¼šÿ\0&äÙž¾=¬¾\0:RÆ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0¶}DÛÒQÚöfZÿ\0•Eÿ\0ñÀžræˆÒ;»bÌ«ý¢Ÿè`U6¶5ÂÑù¾RÑçßÜSíùKÁy—)ñâP4T×OBÕ$Ê.ÕÅ ÃÑ[ë¯CÜWšD-èª×Ñb‡¸®>)4Ž‹²¾ƒ?š~¸d~‹Û? êbŸ¼kýê³«Š~ð¸ûÔþ+,uþn%­^¯XÕö”]eN+£œê®ó+ª-\Z.áÔT³]\n§Ú¢¤¢èsõ#2{¦ßâÌ‹º¢Pt9ú“™_ûM¿Å™½Ù¿ñ+}¿	m2K§·à‘À¨®`\0\0\0\0Z3¢UÕvK°Âá¿w]\'§.2~Cáã¹Â³•®ãR¯)Uçø»_ÀxÊÕë\\T•jõ%Rrâå\'«gÛÿ\0·CUXŽ\"ýøÝ5—Lö~9öLDtÏó’×Jïn§£ž~¿Šg;û·*vqôµ.Z§¬Úñõ~¥J•fêUœ§\'ÍÉêÙh?)gûSœm=ÿ\0šâ*¹<Ñ3æÇ²˜Ò˜ì…žÆ\ZÖ\Z96©Ð\0\Z¸\0\0\0\0\0êu*Rš©Jr„—\'£G Ã3ý£TïW¦iv¾^^³Î‚ÁmNq³¼>UˆªÜóÄO›?š™óg¶ðÖ±1É»N¬£‡c8¥5;JêO®„—ï$ŒIF½kj‘­B¬©Î/U(½\Z=–œ!rãkŠ8Óªø*¼£/c?VlÛ†>®œybüéWùuOoá™ë\'¦\'r±ŽÉ«±]ôôsÇÕêt]ˆë^axn ”o°ûk…ÙV”f¾vµO“}˜Š£Ih¦5Ý/9_g™êZ×ÊXL¿Ý!ÌŽ³ÙfÏ$õùÍÂ¿ X	ÁáçÝ?nf;žQl¿g‘à²nùUlËgñå“ð¿-´~CÕâxÝÓÝ·êÇsË­šd½+Þñù¾†yÚ†ïxü‡¦ø¦Ô§ºoÕŽç™úäjW½ãò¡žAö¡…ûÞ?!é€ñL?©Otß«Ï1ô4È>Ôp¿{GäCL…íG\n÷´~CÓâ˜R; ð6ýXîy¡¦Bö£…{Ú? ú\Zd?j8W½£òœÃú‘Ý·êÇsÌ}\r2µ+ÞÑùÐÓ!ûQÂ½íôàx¦÷t÷Aàmú°ó?C\\‰íK÷¼~Aô5ÈžÔ°¯{Gä=0)‡ýÝ=Ðx~¬w<ÏÐÛ\"/óK÷´~B¿C|‡íO_î±ùJŠaýJ{ ð6ýXîyŸ¡¾Cö©…ûÖ úä?j˜_½aò˜â–=J{ ð6ýXîyŸ¡¾Cö©…ûÖ úä?j˜_½aò˜±êSÝ‚·êÇsÌý\ròµL/Þ°ùÐß!ûTÂýëôÀx¥Ržè<¿V;žkèqýªážö‡È>‡YpYO\n÷´~CÒâ˜Ržè<\r¿Vkè{‘½¨a^÷È>‡¹Ú†ïxü‡¥Å0ÿ\0»§ºGDw<×Ð÷#{PÂ½íú˜>‚à1«	¶±fEBš‚“\\µÑw³èƒîŒ=›sÊ¢ˆ‰êˆM6è¦uˆ€\0{>À\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0‘úCj¶Ë™—úú? ¦OIr oHm~Œ¹›ïôAL«mg¢Qù¾RÑçÿ\0ÜSíùKš!£í(\nšºèUI¢ÍZæU=HG$eÃ‰]äXž¶4K2tUÝf‚ÿ\0b¸ø¤Ó!OEO®Õ¿ò+ŠMc¢l¬iŸÍ?\\2/EíŸuqOÞzŸÅghêbŸ¼.>ó?ŠË†[‰ke4T³‹ë+Ç´âîo‡›ÝÅuDh@\0Ñ:„¡èpÿ\0µY™´[|Y‘x“ý8á¹\'Êâ×âÔ7{7þ%o·á-¦Oé”öüD\0uÈ\0\0\0£–„LéÄRsŒbå&¢—6Ï™sD¯ìpù¸Ðö3šçSÅÜ_›3«NXeŒô¥f¾Éö.ãË“>Ø>ÖkÅ\\¹³ùz[i¹r?jyè¦}XáTþ×Ý®¶œ§+Šb/ÞüÑó\0æ…ˆ\0\0\0\0\0\0\0\0\0\0\0\0\0é²Öi•œ¡cˆMÊƒá	¾.>ãÜÆqœT¢ÓMjšë1êržc•¼ã†_OZRáJmûØûÒÿ\0cÿ\0kUán[Ùìöæ¶çu»“û3ÍESêÏ\ngögtîá]Í²¸®&ýˆßÏ7·Ô©úÏŠ¬\0	\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0—\"ô‡úòæo¿Ñý2zK‘úCýys7ßèþ‚™WÚ¿D£ó|¥£Ïÿ\0¸§Ûò–:Õ•Ô´5ÜXÝE5Ðo ®ïaMZàWUÖ4O‰Ñ˜ú*?îµmî+ŠMbtSúíÛûŠãâ“\\è{-è3ù§áŽEè½³ò¦)ûÂãï3ø¬íLWê}ÇÞgñYc¯ðËpÖªŸiU$q_iÆ4sg(Ó½–o•Sâ|è•éèW{´µ=@ê‰=ÐÛU‡æ‡þ¾×óT\"ñ)ºÑqÀ³%Ä“Òwt\"¼—Êo6r?îTi×ð–×&ßŒ§·à‘ §®`\0çsn8ðëoIÛOKŠë‹_cßöï.©Y[Ôº­-!N.LÅø…õlJò¥åwëª=tì]Hâ_m{wVÌeQ–àªÓˆÖ5Ž4ÑÂªº¦\r=³á¹Éð^3wÂWm>ùu€âÉlÛKJ5©\\SUhÔŒàùJ/TÏ3´ÌÕK&ä¼K”Ò­\nN•´~Ú´ýlWêû“1÷F¼ëSË÷™fúâS¼Ãj:ðr|gF£×à–¿Œ‹.f1x¼ŽöyDgnºiöÄñŸá™¦;g¡©½œX³™[Ë*üuÓ3ÝÂ;b*îëf R:îñ*V›`\0\0\0\0\0\0\0\0\05ç¯QHTH©ÂJQ’Õ5Éøƒžq¥eË«¸ËJµ¥Ç‹”¸|Wä>FÊ±çŠ`/¯=êöÜZ¾.›ãäâ¼ˆÝÛÈñ2šóhüÕýgÙ1½Mey¥š1ôåóø¦™ŸÓ»Yì{p¤lÞÿ\0)c¶ôÄõ¯A./œãÔüg¡F\'Ãï«a×”ï(?]Më§S]hÊVwT¯m©ÝQzÂ¤T‘û{ìSnêÚŒªrÜmZâpñ¬ñªŽÕ×1øjì™ß*nq‚ñk¾ˆój÷K˜\0vÖ˜\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0I\'¤G×›3}þè)“ÖD\néŸÑ›3}þè)•}ªôJ?7ÊZ,ÿ\0uŠ}¿)c¤Ñ]Qh(*ž«MXÞ	T\ru\0f>Š]«oq\\|Rl›¢“×k¶þâ¸ø¤Ù:ËzþiøBß‘z/lüƒ©ŠýO¸ûÍOŠÎÙÔÅ~§Ü}æ§ÅeŠ¿Ã-ËZ^\ZÕöÖ…N2æÆ«´Ñv}Á*§¡]öY¯i]u#Az™1z&ar²Ù¥lB¤\ZxŽ#V¬_ÛBŒô£\"S„êJ0„\\¥)(Å.m¾¯Ìl+fYeå<‡‚`.\ZNÚÎNº’õÓ&YöWËÅÕwš˜÷Ïé«yÚš¯Õsš#ãýKÕ€„¶\0Í¨§&ôIjÈªb˜ÖSÅäóÖ%»\ZXe)q—Ó*xº‘ãNæ/y+üJâêOU9½Þä¸/€éŸÎ¿´=¥«jö˜kækÉ£ªŠwGâž¹•û‡Œ.›|üþÐ¤¹oN\'G\ZÅlð\\&ï¾©»ogFUê?äÅkç)¶­×zºmÛff\"#¦gƒ*ª¢Šfª§H„vé=›]æ1e”-ªëNÆ>˜¯ÉÔ’Ò)ø—ç1öÉ³cÉ¹çÄçSvÚ¬ý-sÇDéÏ‡äô~Càf,vë3c×øõëúuõyU’×]Ôßù‹È|Þ:êž‡í<›eðøž£#½\ZÓ4M5õÍQçO|ÎÎ¹Žww›Õ™ÛñTM>Èáîý­ƒS”e¸ËU§¯2ólO8<ßì«\\ÔÞ¼Ã×¤®uz¶à´Œ¼±Ý~=L€¹#ñÎm–ÞÊ1×p7ÿ\0º¦™ìçöLoŽ©~‚ÁbíãðÔbm~\Zâ&;~Š€\rs(\0\0\0\0\0\0\0éâø•#\r¹Ä®$”-éJ£ïÑp^WÃÊzZµ]êé·n5ªf\"#®x>k®›tÍuN‘åŠ6·Žú{§„RŸÒlbÜÒë©.zø–‹ÊÏ•³¼oæ.f·ð³Ý¡vüMy-}‹ò=?{wZþîµíÄ·ªWœ§/g.Z¯úoØ³“FQWáärgÛ<g¿{‡b3{·39ÌiãÊÖ=‘Â;·$î©ƒàä¬qãùzÖö¤Ô«(ø:ÿ\0v¸7åçå>ñù§…¹ÄW†½\ZUDÌOc¶áïÑŠ³Më|*ˆ˜íe‘q-èUÃ*KŒ~™OÅÖ\Zw0‹Ùaø•½Òz(M)wÅðmû;ÚZ¶Sh°Øý|Íy5þJ·UÝø£®!ãÃøÖ«|üÞÖT\\HÉJ*IêšÕ?¢”ÌLk\n\0%\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0´–¬FÒæÑdêÓŒ\\¥$’âÛàŒ]žºBä,£R¥…µËÆoéëR´jTàû%SØù¯·CŒ±ƒ£Â_ª)Ž·•ÛÖìSÊ¹:C*oGµq*G‹Ò5gm¢a}XYØá×•§\nŠs©$©ÊK×>\\—Q#a¦êÓ‘å—æV3*&åŽ:|\'æøÃb­â©š­ð‰ÑPžÈ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0[\"tˆoèÍ™¾ÿ\0GôÉï\"ôˆkèÍ™¾ÿ\0GôÊÆÔú%›å-ÐqO·å,w¼‚i½8ö•(Z*Kôï©•Þ#AQ«íFN¬ÉÑGë¹oî+ŠM’ôQúîÛûŠãâ“hè{/èSù§á†Eè³íŸu1_©÷y©ñYÛ:x«þÀ¸_êj|VXkü2Üµ ¹Õ”\\ÆÜÞÕ•Õ2Ð4‚ÔÊêú‘\Z°L™,é´Œ:Ú­\';<=úzéõ(A­ñÉÅy{‰åb´Zp0¿Fó«‘¾n^ÑÜ¿ÇÜkËyq¯ƒ^fßá¢+H¥®º#¤ìöÅ0‘UQçU¾~^ïŠë”á¼_<jßôT\0o›0ù¹ŠéÙà÷U¢ô“†ì|méúÏ¤yŒûpá‡ÛÛ©iájï5Ú’ùZ)ßh¬ä»/ŽÆÓ:UMº¢?5^m>ù†f×†ÄÑDôü7¼0\0þr¯êK“ÔÂ½&soÌÌ·m–-ëi[žýT¹ª1®ZyŒÓ9(ÂRm$–­¾H…;ZÍ²ÎYëÄáQÊÖ„ý+hµà©C†«Æõ~S¨}“äWÏiÄÜììG.7\nc¿Îþ7nsO\'åsj™óîù±ìý©îÝÚñëÿ\0ä\0~³pf\\èß›~bg)`Tmñ˜nE7¢ðÑÕÇÎµ^bV.F¿,¯.pëÚöu%N½µXÖ¥8óŒ¢õMwê‰Ï“³5Û–ðìzÛwKÊœÒ~Æ|¤¼SóoÛNAâøËYÅ¨ónG&¯ÍO	í§wð»ÙÖiáðÕåõÎú7Çåž=Óñ}ÀÃ \0\0\0\0\0\0oCm‡ðvvØq¯%Vª×ìW±OËÇÈdj²8Js’Œb›“o’í#ÖkÆ^`Ç®ñ=_ƒœÜi\'ÕMpËå/ÿ\0gyOæž5\\y–£_âŸÃóžÅKlsÀx\ngÎ¹»³Ÿå¯’¹Äwç!{ýãŠÓ­‚×ž¼„¤¿—ÅyWæ2òz‘§¼«†ßP¿·“Kz‘©#$fG°·Ä(4áqMTZw®GûKÊ<[Fan<Û‘¤þhúÆÒê›˜ø|-XJç}=“ôŸŒ;@™®ì›—®ækY½e¹¹\'Þ¸~£éž_!×ð˜}Å»–®•]ä»_ý3ÔÑŸ³ìÖs­˜ÀãjjªÝ13þª|Ú½ñ*>×Ä×G_Çx\0.L0\0\0\0\0\0\0\0\0\0\0\0\0\0½}‡ŸÍùÛ/d¼x¾?}ézIzÈ®5*Kícx³£´]¤`{9À¥‹bõ#*µ5…­´eëëÏ±w.\Z¾¢gŒùçìn¦3\\ÊM¶¨POJt)õF+«ÇÍ¾ew;Ï­å”ø;{îO7G\\ý\ZÌÃ1£šwÕ>ïkÖí3nù§=Õ«ecR¦ƒêÔm©O×Ô5$¹ø—3o.ò›É”9ž\'{rnß«Yþ»•;·î_«—ru–@Ø?®ÚÞ\\KøzŸ¡™8¡Â)s`Ÿ]Ü¹÷úŸ¡™8ãìKþÆú›å.Eèõ{~P¨\0··@\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0eÌ€½\"~¼ù›ïôALŸR \'H¯6fûý/ÐS+Qè´~o”´[AýÅ>ß”±Ö¥w‘h(º*+¸>±§{-*ž„h•Åuh·x¯ÇBdè¡&ö»mßeqñI¸B.‰ÿ\0]ëoq\\üRnf=\n4ü!qÈ½¶~AÓÅ¿x\\ýâ§Ågpéâß¼.~ñSâ²Ã_á–å¬î¤WVZ¹/S¹¬JíWh-\Z¾Ðú]Ászw™a»2­´œãF…Í)¬#j½ôÒá(§Âšï“øî<V[Ë¸¶lÆ­pÚUîîæ¡®Kµ·Ô—6Éñ²Ía{6Ê´0+=Ê×\r*——;º:ÕšõÒî]IvÜ+œ}î]qæSÇ¯«ëÔÚexÅÝå×d{úž²Ú*4!BŒ)ÓŠ„#¢IrHæ	%È\"#EÐ\0‹Ïõ5¹´¥¯±„¥çýÐð¹ñÿ\0l¨.Ê?Ög ûs½6¶/L~ÕVãÿ\08Ÿ“m’Æ¸Ê}“ðyøMuxµfÿ\0,ƒ}qJªÕ÷ö·nôÓÕ¯Sd5æõo‰–úGæï›™Æ\rµW+\\\Z\r\'ÁÖ—?\"Ý^GÚbCõßÙvAäL†‹—#K—¼ùöOáåßí™p]·Í<£šUn‰ó-ù±íý©ïÝØ\0§\ZkÌÝ³j«CÉ—5½}/ìËDß8ë¥H¯q~WØG“îä\\É[(æÜ7¥6•µuá|%N\\$Ÿ‘•}²È£h²[ø:cZ5;ã¿„õL·»9™ÎQ™[ÄÏá×J¿,îžî=‰Ö;ª7¶Ô®í§¿J´á-yÅ­S9ÏÄÕS4U4Õ\ZL?FÄÄÆ°\0”€\0\0|€ò[MÆÖ–êP§=+^¿<w_²~oÎ`õËS×í;ù¯˜çkNzÛØ/Û/²~~‚yôvÃåIÊ(åÆ•Üó§·„vFº¸ÆÔæ>?˜UÏ›G›œg¿Ü\0z¶£2ÖÈ1ïLáÕð:Òõö¯ÂÒÕó§\'ÅyÆ11ör†2ð,Ãi|å¥75N¯|ò•ÝªÊc9Ê®áâ<èŽU?š>»ãµºÙüÃÉ¸ú.Ìù³º}“ôãØiêT¤eEJ/TÖ©ö¢§æGqz¼ƒSK›ºZû(F^gÿ\0ÙíOþ©WûÏõ‘îÝŸa—fæÅØ¦f«‘ÿ\0œÏÍJÎ£Le^Èø\0¯µ \0\0\0\0\0\0\0\0\0\0\0ðsžpÂ²>w˜q›…\nÑõ°^Ê¬ß±„W\\›à}Šõ#J.¬ç»Å¶õÑ%ÚC\r¼íJ{@ÌÒ°ÃkIàØd;tŸ\nµ	T~^¸ÓgY¥9f•ŽwD|ýÁÇã#k•Ï<K?g¼_h9†¶=‹ÔzËXP¤Ÿ­£O^Šüçœ-oˆLånW~¹¹ru™â¥×]W*šªfW\'¡]âÝäÔòÑðÈ;zíw-û¢§èfN8{AÍ‚}w2ßº*~†dä££lo¡×ù¾Pµä^W·å\n€{t\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0¶DéŸÑ›3}þ—è)“ö]Déä¶Ï™ÖŸãé~‚™YÚE£ó|¥¡Ú\rØz7ÊXçaTÖ¼ŠjÁEÑRÝ+µ]£UÚ[£ºˆ‰¢º 3/Dö–×­Wm•ÏÅ&ñº(É-°Y¯ö;•ýp—í˜ô)üÓð…Ë!ôYöÏÈ:˜¯ÔëŸ¼Ôø¬í\\Sêu×Þj|VXkü2ÜËY+Ø¯]YjkEâ*qíÕvö½Go\nÃ1o·Â°›J—WwSTéR§éJO¸îeLŸ˜³¾-OËXeKËš­\'¢õOì§\'Â+ÆM-Žl+Ù…š¼¸Tï±ÊÐúuÛ\\!Û\n}‹¿›ø\r¦Y”]ÌkÝºˆã?N¶Ã—\\ÆÕ¯\nyçèãØ^Å¬ve…;üB0¸Çïi¯LVæ¨Gø(~·Ö×q•â´)´õh¼èøl5¼%¨µj4ˆ]lY£D[·\ZD\0!ê\0\03Ãçèi}mSªTšó?þÏpy,ÿ\0GZV—ªRƒò¤×æg(ûkÂÎ\'b±sLo¢h«ººb}ÒÚdõrq”õëðxÃâfìÃm•2Þ#˜nÚTì¨Êi}´ùF>7&—”ûz‘û¥mtèXdÛj¼jËÓw)v.‹ø_‘Œv?\"¢Îl`?fgZ¿,o«¾7G\\ÂÁŸfQ”å÷q\\ñ½³º=èÿ\0ˆ_\\bw÷•äÜëÝU•Z’í“mþvp\0~Û¦šh¦)¦4ˆ~mª©®fª¸È\0>Ÿ `,º;çžL•O	¹©­Þ/KÉ7ÆTŸ\ZrókÁ2±6›~u³õ­*õwm1Eé:Ú¾\Z¿`ÿ\0EådÂRŒ¸&~AûPÈ<‰ŸÜ®Üin÷ŸÙüQüÚÏ²aßö34òžWDW:×oÍžÎÝï‰T\0s¥°\0\0>VgÆ!àWx“’Þ¥ »føEyÏªù§l8Û«sm€ÑŸ­¤¼=dŸÙ>^E¯œ°l¾S9Îik\r?‡]jü±¾{øvµîafåøü\\#Û<;¸ö1ÌêNµIÖ¨Û”ääÛëe\n\"§éØˆÐá“:Î²\0‘RP3¦Íñçåº1¯=n,ô·©ÚÒ^µù´ò¦z£\nl³ù™˜caVzQ¿^‹à¦¸ÇÏËÊf¥Èüß¶ÙO’s{”Ñ\ZQ_ŸOoì{4v½™Ì<¡—QUSçSæÏgøÑêr¾¹©Ô©%çýàò9ƒT¯.;e/\"mþtzãö?ØžpÛ…š£}s]]õÕîˆj3Š¹XÊº´ø\0«µ`\0\0\0\0\0\0\0\0\0\0ÕvƒŽ½HÒ¦êM¥¦Û}H‰Ü0ÿ\0I} K*å8àX}Âþ4¥I¸¿]\nÙËËì|¯°‡o½iÜ{=°gJÙã=â¯…”­hÉÚÚGª4 Ú^w«òž/UÖÎMžãç0ÅÕ\\O›£Ùý¼TœÇãWæ¨á£úëT®¬·TTÓ0\0\0`]ì·îŠŸ¢™9×%â ÆÀþ»¹sÝ?E2s®KÄtmŽô:ÿ\07Ê¬‹Ñêöü¡PmnÀ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0Ë¨€=\"Z[hÌþè¥ú\ndþ—4kÿ\0¤T¿»NgáþQKôÊÎÓú-›å-Ðú=?š>Çz¡Äµ4WyuA^=eJj†ºò£ÊSÊT«/ôT“[b±ï´¹ø„æ çDøoí‚ÒZp•Ëþ‚\'}ÙŸCŸÍ?\\²EŸlüƒ§‹ÍC\rºÕ7ôŠŸîV£\nð•:‰JN2‹Z¦ºÓE†¨Ö4n¥¬¬3	Å1›¸aøFqys>¥B›œŸ‘·g³^?Væs¯óÉhåA5+™®Í9CÆüÄ¸Á²Ö—­ý)`öx}{–´#I7Ú÷Wè*I-5e_	³6­ÌUˆ«•=#ëðhpÙ\r«sÊ½<®®óù? åŒ‰†ÓÂòÎJÎ”4ß’ãR«íœŸ3Ñ€Y­Û¦Õ1E¤C{M4ÑšcH\0Ú@\0\0\0âg_Là•d–®Œ£Uy8?³íœWTcsoRÞInÔƒ‹ò£I´¹Tg™>+-ŸómÕL{f&\"{\'I{á®øÔÜè˜aÛ«ª6”+]Wš…*•J“oE¥«oÈAÜýš+g,Ý‰f\ZŽJÍgà#.p¥^dŸRLtÌòÊ¹B¾J«§yŠÔv‰\'£ðkÙ¿6‹ÊDƒóØÖÎU‚ÃßÍqé]S4S¯4S>w}[¿…¥ûEÍ|-Ûy}¹ÝO>ÙáÝû@ÛÜÈ\0\0\0XNt§\Z”äã85(É=\Zk“&ÖËóds¦LÃ±©É;Ÿ¨Ü¥ÕZ%â×Ÿ”„mjš]frèÁ›½\'^åŠŸKÄ î-µ|<$=’ñ¸ñü–ý­d>VÈ§n5¹by_ÃÂ¨îÒ¯á^64ñËÅëŸ6îïâýŸ§jK‚‘–ö½ÅOÉÎæ\0\0á»¹£gkZîâjèÂU\'\'Ô’Õ²:c8\\gºÄë7½qQÉ\'Ôº—‘Wk8ß¤pHa4g¥[éi-?ƒ\\_èaÝßög”ø¾¼Æäo¹:Gå¬ü!Ëöã1ð¸ŠpTNê7Ï¶~‘ñT\0tå\0\0\0ZujP«\nÔ¦ãRœ”¡%Õ$ø2EeÌbž9‚ÚbpkZÔÓš]S^ÉyÈç¡”v/‹J½Ål±9½úV·O¯ŠR_\n~r…öƒ’WšeôÞ±N·-Îí8ÌU¤Lwé=‹†Ææ1„ÆÍŠçÍ¹øáó„‘ÊÞ—ÀéI­%ZN«òð_GÜ8m-ãmkJÞ…8(¯\"9Õû7•FG“á²Øÿ\0*Ý4öÄDLöÎ²Ûâ.ø{µ\\é™\0o\0\0\0\0\0\0\0\0\0\0¶ïšþtviŠ^Ò«¹swcoÇG¿S†«Å\'ä2ÛKX­YúacÓ”²ö\\„´‚UojGµð„“IùÍVu‰œ&åÈã¦‘Û¹‡»60Õ×tÓ¿r7>/R…]¥u]§%ÑF\n® #Avò\Z¢ÐFƒ!ì\rÿ\0uì·îŠŸ¡™9ãÉ[`Oû®å¿tTýÉÓbŽ‰±û°uþo”-Y£ÕíùB ÚÝ€\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0-—²5ýÒ/ëÓ™ýÑKôÍ€¿eä5ûÒ-¥¶œÏîŠ_ ¦V¶›Ñ¨üß)hv‡Ñéüß)c‚¥\nëÜŠDÂ ª}¥w´ë,E\"º£Œªdh3×CË	\\í\"öõEîÚaÓ“}ŽRŒIžFn…ùzt0|{4Õ‡ï«ŠvT[ì¦·§ðÎ>bLgíM¼\r:óë+ÎMnhÁÓ¯>²\0\rÓh\0\0\0\0\0\0\0\0\0\0U§(Ê*/ƒ×S”ð›lÏ¶{³¬c1ºŠ7¡é{DßW©ë`—¿gÚâÕ]\\#{âåÊmQ7*áªtšÎÔóžÕq5c=ë)úJ†„¥Ý\'åž¾DŒS¦œ;ëV©qZuëMÎ¥I9ÊO›“|Yg#œÅS3àéŠbfgHá¬ÌÌ÷ÌÌ¹^/^2ýWîN³3ÿ\0Ù€ôÆ\0\0\0\0þŒÝeÜnÇ²›{*ñ¯Û£Õ§ÜÖ©÷3 \Z×ƒ<îÚ¢õº­Üi˜˜˜é‰âô·r«UÅtN“¬{a>p,Z×Âmq‹)\'Bò”kC¹5®ž}Nù„ú2æõ‰å»¬­sW[œ.{ô“|eFzòñK_:3\\^¾CðöÓäµìþm/«…në¦wÓ=Ó¯Ò¹>aNk·‹§ö£Tð˜ïT>\\Aç³Þ7ó-Ý\\BZVª¼.<w¥Ã_6¦¯„¹ÄÛÂÚüUÌDv²ñXŠ0–k¿s…13ÜÄ™÷Xöe¹­NMÛÛ¿G½Gƒ~W«ñhyáÏ‹êœÞ\rof<Ú\"\";‰¯~»÷8Õ3 \0Êc€\0\0\0ÕÊ˜íl³™pìv’zÚWF»cöKÍ¯œù@û·\\Ûª+§Œo}QTÑTUOO[Ê…•ëJŠtn)Æ¤$Ÿ4Ö¨ì£¾où¹”%ÜÔnï—ƒ\\xÊŒ¸Áù8ÇðWi—û—c)Ì0´bhý¨÷óÇd¯{Ñ~Ü\\Žp\0g=€\0\0\0\0\0\0q×«\n1•J•!¬¥\'¤RílÆÙŸ¤ÌòÍIÐ©˜#}^ŸNÊ.ª×±ËØü&=üUœ4r¯UÇ\\¼î^·f9W&\":Ù4võ£qBÄÝ«5¯=\ZÔä=âuÞô[SØyQúW]J¶Ò©[7Âß¥»5r¬˜²ÓN+\núPO]¬Ý¦ùYÛ/è­ª™Œ5GÍ¨ÎçL.pÄå5A=FˆæêÛÝÃyhWj˜-REw‚Y`]Ü·÷ú¿¡™:cìQ6õÚö[ûýOÐÌqö(è{!è•þo”-Y÷{~P¨\0¶7`\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0eÍ\ZüéõêÍè¥ú\nfÀåÍ\ZüéõêÍè¥ú\neoi½Íò–‡hwa©üß)cr»ÝÅHTL¹>ÆY£A=\0¿]K©S«Z¤(Ñ‹”êIF	sm¾G\Z}¦ZèÕ³ég¢[Þ]QrÃpM/n[\\%4þ—OË-Š,öÃØ«v›Tñ™{X³V\"í6©ã2—Û\"Ê?8û=ÁrîæíZTKŽãgëçð¶hQr\\:ŠFÕªlÑéá£¢Û¢-ÑSÂ7\0Ñô\0\0\0\0\0\0\0\0\0\0²®š$ôîñË¦®~ù§˜°Üg_[|*>›ºQ|y­\"¿\rþ;%ÞhÆì2Ö}˜qJ¾\nÓ\r·©uZ]‘„uóð5…›3%îpÌ¸–gÄdÝ|Fæuäµö)¾]Éh¼†‹<Äx;Qf8Õð…oi1~)ãWÂ?WÉ\0E\0\0\0\0\0\0\0ëöQšå“³ÎŠJ£\n“ôµÂ×ƒ¥>_Ñù	­JQ”¢õ‹âŸj5òÉ“±çß¬ªW©½{‡ÿ\0aÜö·ëeåŽž]Nö×ÍvìçV£‡™_²wÓ=úÇl:§ÙÆi¤ÜËkž>u?\n£á=ìª]fÚÖ:ï±šx=ëFÅk=9:’çæZ/9•±|FŽ†\\âUå¤-éÊ£ïáÁyôDt½º­}wZö»Þ©Zrœ¼mêQþÌòŸÅ×˜ÜÖãHüÓÇº>-öÛæ\rN‰ß^ùöGÖ~ Ûœ´\0\0\0\0\0\0\0î¶/šþusÝœëTÝµ¿~”¯«á¤Ÿ­oÅ-	„¥É¢-è½è¶šz­:™2öS›>|rV‰Ö©¿wN*Þëï°àß•i/)Òv1Öšð5Ï:>	ïXr\\Fé³>Øù½˜\0è­ø\0\0d§µÐ€©%¦š­uäc-©íÓ+ìÚœì›XŽ0â÷,èÍzÇÕ*’û×§6xM¸ôŠ†:ùG!ÜÆ¥úÖÕüt”hvÆ®]ü—Œ‹wWµê]]V©ZµY9Îu$å)7Í¶ù•<ãh£3c¾®yægLûšÃ8‹36¬o«§£õ{,ù¶ï´\Z“†/ŠÔ¥c)k*p¢¼kì¼ºž)i¯‘~r…5{Å\Zõë˜Š¦»µLÏZ±ríwjåW:ËexgÔÛO¼Sø¨ìl7êu¯Þ!ñQÙ;%†8(ùyQ\nzO­6³yîKoˆMgÈ…](S[Yº}¶Vß­í\\kÍ	ióÏEl|Ø”\0sURê+ªí-W,*ŸkŒ…°®þ[ûý_ÐÌ‘ö(‚[kè¿–þÿ\0Wô3\'lyd}¿Í?ZòG«Ûò…@­»\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0R\\Ñ¯¾‘Ÿ^¬ÑîŠ_ ¦l\\Ñ¯ž‘¿^¼ÑîŠ_ ¦Vö›~\ZÍò–ƒh½\ZŸÍò–9º²â§\0¡PU§	ÕœiSƒ”æÔcµro‚HŸ»Ù‹ÙÆC·µ»¦¡Šb:]_j¸ÆMp§ø+‡StUØô±ÌN;FÌÒ~§5ûµeözu¨¿é.âaSMA&õeÇg²é·5r7ÏgOjÙ‘`fŠ|fäožÎžÕË‚Ð\0Z–0\0\0\0\0\0\0\0\0\0\0¤žêoMtê*q\\Î4èÊ¤æ£­[|’DáÓS?üËÉÖY\ZÎ®íÆ5WÃ\\%.*…7ªO¹ËO1\nøõ³ íãhÚ6Ó±|jœõ²·¨ì¬WW€¦ÜT¿	ë/Â1ñEÌq3ˆª¸áÂ=ŽgœbüsUqÂ7G²?­@„Õ€\0\0\0\0\0\0\0(Ö¦Zèã›>aç9`w7m±˜x4º¼,uqò¾+ÊbcžÂîîÂþÞöÂrÍ½XU¢ãÍMI8éåHÓçùM¼ó,½—Ýá]3\ZôOžÉÒ[§^Y·‹£ög_lsÇlk	oµüuÒ²¶ÀiTÒUŸ†®—Ú§¤WŸÅœŽî5Ýæ;÷ŠÞÁS©V0úZz¨h¹#¤sMšÊ<‡–ÛÂUø¸Õù§wd,ùîcåLuwãððdpïãÚ\0\rëN\0\0\0\0\0\0\0\0“£VlX~c¸Ê×5t£‰ÃÂÐMððÐZéåŠ~c\r¬#¹ÁqKL^Ên5ìëB½6»bÓýFÃ*ÇU–ã-âcög³ŸÜÈÂÞœ=ÚnG2x©j×yqòòæ3m˜pk,jÒiÒ¼£\Z±K«UÅyhú‡{·]7)Šébw®ôÌU\ZÀ\0>Ò·Â-ZKŠ#¯H¹Ï…|‡”.´Ä\'û¨K¾p‹ûf¹¾­Ok·­¬ÇfÙrT0ùÇæÞ\"¥NÒ/‚\\Sª×r|;Ù®n./+Ôºº­*Õ«IÎ¥I½e)7«möêT¶‡8›â¶\'Îž3ÑÙhs|ÆlÇ€µ>tñêýV997\'&ÛâÛ|Âzq\\t*ž¥wªœ\\‘—Euã©Æ¥§a]u#D¶_†ýNµûÌ>*;[úk÷Š“³ÑøaÒ#‚’z/*!gJW¦Ö.=ÃmñI§>^UùÈWÒ›ë±qîoŠVö«ÐcóGÂZ|óÑ{cæÄi•,+Ç´çJzà[¼Êê»H˜LJ 4N¬ƒ°®þ\\_ëªþ†¡;—A€}x2Úÿ\0]Wô	Þ–‹C¡l¢Wù§á^Cèõ{~P\0[v\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0¤¹£^ý#›ú6fŸtRý3`òæ{ôŽúöfŸtRý2¹´¾OæùKA´^OæùK©.Î%ugTÞ¥+E9r2†Ã65‰mO{ºU(`6U»¸kOùø(>¶×=9\"»ØN=µ<B×jv9~ÞkÓmhêµÎ×[ïä‰Ï•rÞ•0k|°§kgg\ZpŠò¶û[|[í7ùNO8ª¢õèó>?£{”å3‰˜½z4££§ôvðœ/Âpë|3µ…½­¥5F*kHÂà’ÓÄwRÓ€â\")!sˆˆÝ\0\0\0\0\0\0\0\0\0\0\0\0:Ø–k‹X\\a—Ð”­î©Ê•XÆrƒq’Ñ¥(´×Í3²˜‰$˜×t±è°n¬•?ø¥ßýRž¤íƒûJŸüNïþ©—ÁâXoÝÓÝ?\'`ÿ\0uOòÇÑˆ=IÛö•?øßýQêNØ?´©ÿ\0Äîÿ\0ê™|Ã~îžè<ƒýÕ?ËF õ\'lÚTÿ\0âwõH“ÒO$eŸm2¦]ÊXs²ÃãcB²¤ëT«ëäž¯zro«´Ø«ä@ž™^Š¿Í–¿™šœç\rfÖ*·DDë#ÚÒmcË·n\"uŽÁ ®£;˜-½ÌfÂÒâ;Ô«ÝR§8êÖ±rI­Wq-ýO»&ö±?\\~Ùò¼T³>-S¿·Oò‘6Q}‘)OYá÷.›ûJœWœçh=µyÍ»Xš¹Tx>W.š.MNºi:k:i<úïÝ°ÔeÕÑz1Öé«}:MTÅZq×ŒNŒê}Ù7µ‰ûúãöÇ©÷dÞÖ\'ïëÛ2ÍæZÆ¬uu,§R?mK×¯ƒ‰ó%Aé8¸µÔÖ‡ç|Ë5ÛšïÌ/âmUÑUw)øÎþÇK·“d×c[x{Sì¢Ÿ£úŸvMíb~þ¸ý³’†ÀöUmZÅ³%:rR‹wµÞw9™\ZÉÚÝ ˜Òq×¿ü•ý^‘åQÃ\roù)ú<·ÐÇ%¢%ïš¿´>†Y+ýýóWöR¼YÇÿ\0*çóÕõzy.ÿ\0ãÑü´ý[èe’¿Ðïß5h}²Wúûæ¯íª1”Þ‹“ìKSéÙe¬jû;)Ó‹û*¾±|<M–[‰ÚœæïËë¿v®Šfº¾»µçs,Ê¬Æ·,Ûm4ý	ìË%u`ïß5hÅYë\n°Ás%Æ†ÑðT)Æ1ÞrÓX¦ø¶Ù,lr-i<BåÔ|÷!ÁyÈÙ·+Z{HÄm­©¨S„(¥÷´všØÍ¬ÉiœÏ?¹1EQÉŠ*®j«Yß¬Æ³Li1Ç]üªœ¶0±NÝ1W*7Å1´Úñx jPW*XÚâyŸ	Ã¯iøK{«Ú4jÃy­èJi5ªâ¸>¢RÇ`›*|òÌ½ýqûdaÈ¿ß®üãoúH“b°8\\]‹³ˆ·MSb\'›­¿Éì[»ES]1;ùãV>úl§ÚÌ½ýqûcè²Ÿk2÷õÇí™o\"å¿üz?–Ÿ£sâ˜ÝÓÝ{ôÙOµ™{úãöÇÐe>ÖeïëÛ2EËøô-?CÅ0ÿ\0»§º3/eÌ#*á”ð|ÚT-)6áNUgSwW«ÑÉ·ðŸLaEºmSQ\ZDpˆáx¦)#€|ìo´Àpëœ[®©ZÙÒ•j²}QHú$véqŸ~e`ö™Â¾—§öEÚŒ¸ÆÞ/H§÷ROñi‹˜béÁaê¿<Ü=¼Ï^\"0¶j»<Èë´Œõˆí7_fKùµ\nÕ-¨ëÂ•ô„W~š6ûug™ÞEºvóäSvº¯W7+fw¨5×UÊ¦º§Y•ÜÑ•OCÏGÊ®=…V«ÌSUÖ‡‹°Ì0ß©Ö¿x‡ÅGdëáßSí~óŠŽÁÙ¨ü0éÁlý•~rô¨{»Y¸_ì6ßš“ö>UùÈUÒ¯ë³_Ü6ß®mO Çæ„´ùç¢öÇÍˆwûÊ©p8ÁÎôSÜ ³y…>$h95ÐoiÌµKR¤‡Ñýë¶·÷ê¿ ¨Ot~úðå¿¿ÖýBxd½¿Í?[2G«ó| \0¦ð\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0l¹£^ý#šú6f•þÑKôÍ„I=uFÌý2ÆtÏØžuÌ¸ÝõJx…XTô•º4”aèæõm=Þ¤¹ó4ÙÖî6Í6íFý~RÔæøK¸ÛTÛµõ×Ý(M…áx–7{OÂ,kÞ]VzB•\ZnroÄ‰/².‰5eKÚ||5R¥…R–®]õd¹}ÊòéÈ‘yKgY?#Z«<«—m0øh·ªSŽµ\'ß)½e/+=6œŒLÏÛ³1^\"ySÑÍú±°Y\r»Ë¿<©èæý]<+\r´Â­iXáöt­m¨Cr•\ZQQŒ\"º’GtÇ\ZC¦à\0H\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0>D	é“õè«üÙkù™=Ÿ\"ôÉúôUþlµüÌÒç¾Øù´Iè=±ó`ÐQsçÔÊ¿ßFüáoúH›T5W•¾ŒùÂßô‘6¨Þ…—gø\\ìù®»+ýÝÏl|ÇÈá­imqû½½:ŸuÎ]èöäooYµˆ¦h»LU\ZÇ½m‰šgX|Ê¹kªõ–Ik×²~\'ûÖkÅQŸoRŽIsevþÅlÞ*u½€³V½6èú2)Æb)á\\÷ËâÃ\'àQãéY?FÎzyo¥Æ8}7ãâ}=åÚ7ãÚ0û³xY‰³€³Ët}\n±˜Š¸×=òâ£immûÞÞ?¹ŠG1G8¯²EÓz\"ÇfÍ¬=Õ1LtDiÐÇ™š§YU‘oŸ\\üOî(þå²\"íñ¯¢~&¿‘Gôh¨mÏøu?ž>Óg^ß«€J«>æEþýp/çÒDœõ\"ÿ\0~¸ó¿é\"NúŽŸ°^{óGÁdÈÿ\0»¯Û\n€ûx\0\0\0\0á¹«\nP•J’ÝŒ\"äßb\\[ó\ZöÚ¶n«óö/Ê¦õ)×t­×R¥[¼‹RiíÃ1¼«³{§7\nÎÛÒÔZ|Tê¿šñokä5ýÏŽ¥/jñ;èÃÇ¶~óV¶‚üÇ\"Ì{~Ÿ5w»Šê»KAMVõ\\uew»BU*¸OR¯Ä8’Ùžõ:×ï0ø¨ìl7êu¯ÞañQÙ;%†\"8).D(éY§Ñjã_â6ßšòäBŽ•M­W÷\r·Å+»SèQù£á->yè½°Ãë¸£m1½ÚWƒã¡ÎÔóUÚ‹°>@Ð¹M®ÂÄÛeH£äµÛ[×øz¿ ¨O.dèùõâË«ú\Z„ó\"ÿ\0²~‰_æùBÛú=_›å\n€Sv\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0ZäÑ\Z¥p8kÝÛ[G~½ztâ–ºÎI#ãÞgŒ³cª«ŠRœ—ØÓÖOà5Øìã/Ë#•¿E¸ÿ\0UQ{ZÃ^¿ºÕ>ÈÕ÷Š7§S<5æÖpz\\,ì.nSzA~·ð\ZïkX­]}\'…ÛRûä¥7ðhR±ÿ\0k;%€Ö\'ËžŠ)ª¯|G\'ÞÙÚÈ3»ù\Z{f#õe-îâ›ü5ÐÂ÷;EÍW\ré}\nIõS¦—ÃÌùW9»×ÓµÔõçôÆŠ†/íï$µ¬ap÷+öòiSîl-ì®&¯Ç]1ß?Fx­}iE7Vâœò¦‘úWeü{2mz­îƒÝâï·‡…·¤ç\räž«UÀËU+Uªõ«VSÊz–ìÓíÚþ:ßƒ³‚Šc]w×3ð¦Ø[8û>íéˆ×]Ñ9”U¶Ù6Ñn¿sÊõã÷Ê§ñ¤«m° WÓÂÚÙ[ýòê/OÅÔ’ ª^û[ÎkþîÝºcÙTÿ\0íòaÚû/Éèß]w*íˆøSó`œ½°<Ía‹XâWØ¶ÚÜÓ¯(Òs›j2ON1]„À«µê\\©`’}ò­ÿ\0ÑA‰GÚÆÔÙ‰‹âz(§ç°`67(Ë¢i³Dïã­RÈSÚíÞŸKÁé/º¨Ù×žÖ±‡ì0ëXþ3<(1®ý©muÞ8Ú£ÙMð¥³Œ/§ü¨÷ý^Ûè¯ŽuÙÚ¿#ùKÖÖq¥ÎÂÑþ7Êxa¡ãOÚ^ÖÇu~ï£êr\\ÿ\0•v¶·‹}–jÿ\0\n_)È¶»ˆ}–oäœ¢ÛÑq;4°ÌF¾žÆâzòÝ¤Ù™cí\'m.UÉ³‹®©ê¦™ÿ\0ÕçVK–Óø­ÄvÏÕî×®¾Ë¥ùF^¶½Wì°Xù+?òT²†d­ûžrüpÓóÊ[<ÍuyaÊ+ùU\"¿Y¿ÃmwÚn#}˜½Wÿ\0f?ýµåù-‹“Åú½Ñu·Çÿ\0æÿ\0èÄ[@À¥óEÖc§r­Ì`¼Žþ›±Kž«°È‘ÙŽh—²¥oUúŽHì³1ËkEÿ\0¸ÿ\0R2±X¿µÖÔZÄY¹4ë®ûTFÿ\0å†#-ÙÜE<‹ºL~iùK	ý\r®4á‹S×¾‹_¬á©³¬M~å}m/ºÞ_™3;Ãdøì½•õŒ\n²sGdx«^¿µ^(É˜öro´Z¿þ,Ï¶(œ5—2\r•ž§²ª¿VË9?Â36‰]NÙÐµ¼£Z¤¡6ÚŒf›á¦¼‘(¨m)U|1hÇ‡ÙÓœ:<”vE{ÎXÕ§eÿ\0YËÕºcÑ^+fÿ\0¬]2ßi™-Qk.·TU:Ï*ªc»K°ø³”ìö&-^ª5öÏþ¯gK8eš¾Ã³òÕQüúªxæW÷,RÒ~*Ñ<DvEogTsn—õŽXl\rû<^æKºEÛ\rž} Ï÷ù]¯ÿ\0-1ÿ\0µH¯”~Åú¿–~÷0½µšÖ7ŸŠiœŠ¬%ìZgŠ¥²Œ\Z~iâîgýS»Kg8E.1Ä±Ní:~doð¹¶ÔÜþÿ\0.¢ŸþüýrÄ¹‡ÀGá½3ü?«Õo.ñ½Ü|JFÂ†›·Ø‹Ó¶î¨ú–ÖTíxB­ypÓé•e?ÎËþ>ìÿ\0ÔY¦e|¯ýa…r‹4þ\n¦{4ù°_LlJvû=ÃpèKONbprïŒ!\'§ÇÌC´Þ„¬é©SwÊô“á+›™iÞ£OådSàRöŠ©«TO4GÃU;«\\dÇDB»ÝÅu]¥šw²ºw³E£R¿‡h-Õ….Ò4Þ=E5]¡¾NÁ­šá¿S­~ñŠŽÉÖÃ~§Zýâ“±ÓøaÒ£‚’äB~•]­W÷\r·Å&Ä¹Ÿ¥g×nãÜ6ß®íG¡Gæ„´ùç¢öÃ•Õ”=S×owõ-Avšó*–…º±¼ÈÐdnŸ^<µ÷ú¿¡¨O8ò WG¶ÞÙ2Ïßêþ†¡=cÈ¿lŸ¢Wù¾P¶ä>WæùB ÒÝ€\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0Ú:ÅèaQ¿Âï«ÐiZ4¥»¬_\'ªãÃõžÀëÞZÑ¾¶«gq\rúU`á(ö¦i6+¯:Ê¯à-×4U]3TLÄÄññ¿MxôÆ°ÊÁ_Œ5únÌk;ã©*Ý\\ÜKz½ÅJ­õÎN_œâÕìk«ƒâw}n.ŒÚOí£ÔÎ‰üþÆÙ¿†ÄWg¬\\¦f*×Ž±:O½ÖmÕMtETpž ö\0\0±Œ§%Å¶ú’>­ŽVÇñ-=\'…Wšdã»;30y~/0¯Áá-Ur®Šiš§º\"^w.Ûµ«•DG\\èù ÷)Æké+û»{eÙg/“á=\r–Êð+}Ýk‹™vo(¯€¿åŸd{W™iTáü3Ï]QO»}_øµWóüÜ½gª5÷ð÷±2;v˜V%-ÛŠï—Òé7§˜Í–YW.Ø5é|&Ý5öS†óó³ëÂœ!Á$–‰%¦‡BË>ÀnÕ¥YŽ2#ªŠfòªcý­Eý¬¦7Y·ß?(ú°½¦Î³MÖŽVJÝ>ºÓKà\\O·k²KÉhï1Jp]jœŸÂdýä{À}‰ì¶O\rMwgýUiþÈ¥ª»´ØëŸ‡J}‘õÕáívU€ÓÑÜÜÝWÓ²J+àGØ³È™RÓŒ0zSióªå?Œô=\0I.H¹`vfòí\'·óLU=õk>öºîk½ø®Õß§ÁÖ¡…á¶Ü-°ûjZ}¥(Çó#S‚å¼EÀ³Ú±jÄrmSÇTD0j®ª§Z§U7cÖŠè»\0=4Bš%ÉÑv\07W`Ñv\" !M]R\0”ƒD\0€\0ÏÓ]7‡eO¿ÝüZDT\\‰[Ó[êVUí7_™Žo´âö|!HÎwcjìøBº²»ÝÅ£Di´j×jŸ¢-+«#D®Ó@ß\r\nowbÎ0ß©Ö¿x‡ÅGdëaŸSm>ñOâ£²v\n:TpR\\ˆKÒ»ë·_Ü6ß›RäBN•Í-®\\{†Ûâ•Ý¨ô(üÑð–Ÿ=ôXöÃjÐÕ”×R§=Sµ\\š£WÚ¸O´ªz‘z=}y2Ïßêþ†¡=cìHÑëëÉ–~ÿ\0Wô5	ëEûe=¿Íò…·!ôz¿7Ê\0†ì\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0Žv§ïÑ¥ŽÐ§Æ\rR­¢ê~Åþ£hù°§‰X×°¸ŠtëÁÁùW3ÄÙl’Ò/{ÄªTþM%»ð³óoÚGÙngg±É­ÄÓv5¯YˆŠjÓ;ýhÒwDÎº®™6yc\r…ðXš·ÓÃŸXýÀú~ŒâM+6½TþÉA¥çäfL;&eì/Go…Ñ”×)Ô[ò×ËÈû1¦¢´ŒRK’\\£ìíZWšââ?Ón5ÿ\0Ê­4þY}b6®˜ÝbÞ½sô«áû,Çnt•åZ6Ñ|õ{Òó#ÒáÛ,Àí’õZ÷r\\Ó{ó.?	íVºq*tü£ì›er*ñTsÜ™«ÿ\0Ôÿ\0âÑâ6ƒw/“[½ü}ïe€`ørÒË\r·¥§Z‚oÎÏ ‘Pt6ƒ¢-áèŠ)Žjb\";¡©®íwgZçYë\0KÌ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\Zzk}GÊÏý¦ëâ@Š\Z7Ä•ý5þ¢åtÜüXCVsœþ?îö|!HÎ§þ¶®Ï„\Z2º®Â€ÒèÕñ]ª\Zê[§z*¸*Wþÿ\09nò*šda¿S­~ñŠŽÉÖÃ~§Zýâ“¯SøaÒã‚’äÈEÒ·ë·qîoŠM×È„],›\\¸÷\r·Å+ÛOèQù£æÓç¾‰Û6*¤ÒÐµK´¯3Ÿ©«µA4øŽDh/Ñ [½ÚWy È½xm“,ýþ¯èjâ<ˆ	ÑúZm‹,½Ê*/þ)“î<‹îÊz-›åvAèõ~o”*\0-\rà\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0Ãí3kÙ[eö7Y¦ë¥Rté;jJ¦Ž)7®­iÌð^¬­vcžò_¶wºTdª¹»e——T¥;ÌªÄ©Æ+W(E8ÔŠüßà¢ïv²·šfX¬þE\Zrf5ÊÞmšb°ùDrf5c¿;=Y{ìÇ=ä¿lz²ö=ÙŽ{É~Ù5]ÃUÜk|½‹êîjþñc:)îýS¯Õ•±îÌsÞKöÇ«+cÿ\0kŽ{Ê?¶AMF¿÷¨òþ/«¸ûÅŒè§»õN¿VVÇþ×÷’ý±êÊØÿ\0f9ï%ûdáØUnëÉ/âú»¼XÎŠ{¿Tëõdì³÷”lz²v?ÙŽ{Ê?¶A]\n®yÕÜŸ¼X¾Š{¿TéõdìíqÏyGöÊz²¶?ö¸ç¼—í_Rº®ñåügWq÷‡þžïÕ:=Y;û\\sÞQý±êÈÙÚc¾òícDQ(õ/ã:»¼8ÎŠ{¿Tèõdì‡í1ÏyGöÇ«\'d/ì1Ïy/Û Æ€¼Î®ïÔûÅ‹èŽïÕ9ýY û\\sÞKö‡«#d?k{Í~Ñu(>ðc:»“÷‡ÕÝú§G«d?kûÉ~Ðõcìƒ³÷’ý¢kÜ5íx1]ÇÞ_Dw~©ÏêÆÙÚã~ò_´L}¯°Æýä¿hƒ:®Â©®Á÷ƒÕÜ}áÅôGwêœž¬‘}¦7ï5ûCÕ²/´ÆýçÚ æ½È¦¤}àÆuwxq}Ýú§/«d_iûÍ~Ðõclø<qø¬ãûdÞeu]¤}áÆuwx1}]ßªp¾™$ê¡?÷8~ÙGÓ+dËü“~+8Ô ÿ\0º¼Î®ãï/«»õMåÓ/dÏ–`_îtÿ\0êŠ0¶?Y¥V®1nŸ]K-~,™µ]cT„m2:;“þ/«»õl+é±ÜnJÙÊÖŒ¥É\\Æt_ô’=ÞŽá8½%q„â6·´š×~…hÍ|Õß>gÐÂ3=—®ayã7¶©½c;zòƒ^fdÙÚ[‘?ÚÑìÝõeZÚ:âµ¢\'Ù»êÚ\'½Ô\\BÌÓ9à–yÎÊŽ9kªNâ)R¸K½¯[/*O¼’™m¹hÑ,\Z¥Ù-]ÇÒë®Ýöƒ©¿Âf¸l^ê*Òz\'t·˜\\Ï\rŒÝEZODîŸëØ÷à¤[qM¢¦Éž\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0=6˜.WíW?OÕv’¿¦×Ô\\¯î›Ÿ‰&js¬ÿ\0üB¾Ï„)×¦ÕÙð‡&«´q,Õv—ošf¥p(šeBN¥W2ƒ]ó0[<Ã~§Zýâ“­†ýNµûÄ>*;\'^§ðÃ¥Ç\"ô°úî\\{†Ûâ“z\\ˆAÒÁéµÛpÛ|R¿´Þ…š>Óg¾‰Û6+«-Þí+Ì )ªêÊï ¿UÚ\n§¡\Z%¶ôÛXÓ®í¯=9#`×æÁú0åovÿ\0RFÀÑzÙ_F¯ó|¡mÙÿ\0G«ó| \0†ô\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0ÅqkBæJé©Ó«	Åòi®(×Üömq³ÿ\0{ƒÆ“X}ËwX}M=l¨É¿[¯[‹Ö/Å¯Y²ÈÅ»xÙ=¾Õr]K\nTã_Þ¯‡Vk”ôãþÖIiãÐÕfØ/³æþ(áó†§8Àxõ7ñS¾>­w×CšþÆ÷\n¾¸Ãqz–÷V•%Jµ*‹IBièÓ87µæQæ4%Ï´˜%r—hÞE¥tdh.º´W{¸ªíXÞ-OR¤\'ŠîŽ€´jû@¿WÚ-Ô¯â•ÉêU½uìeí\ZÓÔ§ØW{¸ìTÕö!!]t(ª»Åw»‹@‚Ý_iU.$h•uÐª}¥7µh.*YÇ¼jûHêÊï\"Ýä5]£CUËGÕÈä¡Zµ­h\\ÛU\Z´ä¥	Ó“Œ¢×&šäÎ-{TÆþdÄ¤6ÉúYf¸èàÛ@•\\Wö¼ŠNæŠí—Û¥ßÇ¼–ØfÁ³NGÀ1J7ÖuÒ”*Ñ–«ÄúÓî|Q¬=îãÚlÇk9«eø¼o°K§;J“^š±¨õ¥^=|>Æ]’ê7ùvyrÄÅ¼Fúzyãêßåùåv&-â<êzyãêÙ\0<^Í6™–v™‚ÓÆ°½ZI\\[TM·žœ¤¿3äÏfš|šeÎÝÊnÓÑ:Ä®îSv˜®‰Ö%Pèú\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0FŽ›_Q2·º®~$–KN›Pò·º®~$•¼sÌûÓëìøBzm]ŸT\rWi]M6Q«ë.O°°¯¢4ï\rQg±|ˆÑ- á¿S­~óŠŽÁ×Ã¾§Úýæƒ®SÂ28).D éeÃk×?Èm¾)7§ìH?ÒÃë»qîoŠh6›~?4|%¦Ï}¶pjÀ(:)šš²»Å	]ª`·Q]Z ì\n.[`Ë	sôÛ~jr6¹£/¶|¶šá\nµ¦ü”*~½	ó¬S/;-ôµÏú¾P·lüÓÕù¾P¨\0³· \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0I­b×iPoé5Ñê®s·©Ÿ2œ^9oK[»ji\'{¸5ÛQ.é%ØBÉÓ9ÊHÊ3Œš”d´i®]y`«N:GN}dqé	Ñ’Žouó†G¥J†6Ó{5Âšsk©Tøç®f¹W„ÖýˆßÏ=p¬ç4Þ×‡;ž:zã¯â…œ¸\"ºË³á9ïìop«Ê¸v%iZÚêÞniUƒŒ£%ÔÓ85]¥VcN*\rÒj€ÑâA¢í\Z	èSV¹„õ\\ŸhÕÓ¼¡\Z\Z¯º²º¦F‰Õ]t*Ÿi@»TT°jÀ¿WÚ5e5EHNªêØ×´´¨ÐÜ¸êÊñíDh*\njŠBº¾Ò€”Ú+Ï‰`#D¯\Z2Ý_iU&ù± ¹=\nï\"ÐF‚íQRÂº²¨ÙîÐ³Í³ÅW{Ð{µèI¿^Ÿ\\$¿_S\'þÌö‹€m\'.PÌX%]Õ?Yqo\'ëíêõÂ_>Mq5³¼»ƒ±=«ßì«6Ñ¿R\\*îJŽ!nŸ²§¯³Šûhó^cs”æsƒ¹È®|É÷uý[Œ£2œ~¹ó\'Ý×õlR2Œ¸ÅêTéa…ž+eGÃ«Fµ¥Í8Õ£RU(Éjš;¥ò&&5…ê\']ð\0	\0\0\0\0\0\0\0\0\0\0\0\0\0\0£¦ÛkÊÞê¹ø\"NŒ–½7>¡å_uÜüH)7§3žgÞŸ_gÂ|îëjìøw»ŠNÕ.ÕûkZ\rtâ«j—i]uhxwÔûo¼Ãâ£°uðî}ªÿ\0SŠŽÁÖiá›ŸAÞ–OM®ÜiüFÛâ“‰ò ïK\'¦×kû†Ûâ³A´¾‡š>m6}è±óaÄûF¨ão°®÷iBRÜ€±6]¼€® ¢z•\Z\'V`è©g+­®ÚVŒuô­Ån=^µGúÄã†»‹R ô5Â¥_7cX»†±¶±úµœþDKø´âšäËþÍÑÈÁkÓ3?/’ë‘ÓÉÂDôÌý\0öÜ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0-œ7ôã¦ÅÀ‹6¿°µkiTº£ó?„~“ˆÐ‚ßëÒ5ÙÇ^Þ<x2m\'a¹ÿ\0eõe<k•Æž¿µ‹ºµ`ûŸ›$pR–ólã­ioqNtn)F¥:‘pœ&”£(¾i§Á£WÊ­bç•m]?V§“áñÓËü5tÇÎ\Z¡RêÓŽšîâyçÞ‰û0ÍÒ«y…ÙÔÀ/&÷·¬´Tœ»|õ«ðt0Vièc´Œ*r«–o°ìnŠ~¶Pª×Š~·úEnþQ‰³ÂžTu}8ªØŒb|ÚyQÕôâÀZ¦<§©ÇvO´Ì³9GÈøÍ¼cªu¤ªSòN	ÅùÏ3VÞê‹j­½JmpjpkO:5ÕÛª‰Ò¨Ñ«®ÝvçJé˜öÃGÚ5k¨¦÷:Êêû\n•à¸ê[çNýHÐ\\ØOB…u]z¹q\Z¢šö\"ÄÈÑ:®Jjû˜jû\Z\Zªž…ÛÅ«V4}á+Ö¬èûÇð.»ÝÌ¯\Z®×Nò©–yÂ4N±+Áj–…uöˆÐT\r{˜ÔƒPªzêû˜ªÕÿ\0üê»T5E¥t@\\<\\Êo\r|Dhj—½v¡,C»Ù¾+_zâÂ.ër—P×IÃð[MwIön2ÞZèkOey®¶KÚ	˜©Ôq¸F¶MêSõ³O»FÍ”ZÕ…j1«NJQšÞMu§Ä»ä8©¿‡ðuq§wg2ñâ§†äU;éÝÙÍôr€\rëv\0\0\0\0\0\0\0\0\0\0\0\0\0\0Œý7x`Y[Ýw?IO‚%¯Mçý£Ê«ýªçâ@‰=Ï£þ¾¾Ï„(¹ç¦ÕÙð^S‰MY]Q§Ñ©TÕ2¤\'S‡i]tE\n7Ô\r[FÃÿ\0x[}æƒ¯‡}OµûÌ>*;Y§„:|pQs¥§×v¿¸m¾)8åì[ ßKg¦×®û\r¿Å4Iè‘ù£æÓgÞ‰Û6\ZáÚP¦ó*™ERÕ×€\\\nàF‚©êU=;ËSÐç²´¸Äo(XZÓu+ÜT*p\\å)=\Zt\ZÎ˜}rä¬r\rö`©\rÙb×Î0ms§InëâÞs^C?ÇM8#Ïä±o“rf–-’QÃíaJm-7ªi¬åå““òž„ê?Šá¨µ<b7ûyýî‰ƒ³âö(µÑþp\0f2@\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0q‹æƒ„_8¦Tnäu×C§yà¸‹oÁì®›þ\ZÞüèï&\"wI1®éy‹˜læí·q‘ðI9sÒÊšüÈèÏb›\'¨õžÏðgþì‘íAå6-O\ZcºSbÔñ¦;¡á¾Û\"ÿ\0û}ƒ~@¹lGd‹–Ïðo{£Û‚<ZÏ©Ð³êGt<RØ¶Ê#Ë `ÞöEëc{+_æïXžÈâö}Hî„ø^¬wCÇ}vYí÷¬GÐwe¾Ð°_zÄö x½ŸR; ð½Xî‡Žúì·ÚïX•úl·ÚïXžÀ³êGt×«ÐñßAÝ–{BÁ}ëôÙg´,Þ±=ˆ/gÔŽè<¯V;¡ã¾ƒ»,ö…‚ûÖ#è;²ÏhX/½b{<^Ï©Ðx^¬wCÇ}vYí÷¬Jý¶[í÷¬O`‹Ùõ#ºkÕŽèxÿ\0 öË}¡`¾õ‰G±Ý–>y÷¬Ob‹Ùõ#ºkÕŽèxß ÞÊý¡`Þöˆú\rì³Ú\rïhžÈ³êGt×«Ðñ¿AÍ–{BÁ½íôÙg´,ÞÑ=/gÔŽè<¯V;¡ã¾ƒ›,ö‡ƒ{Ú#è9²Ïhx7½‘ì@ñ{>¤wAà-z±ÝôÙg´<ÞÈ}6Yí÷²=ˆ/gÔŽè<¯V;¡ã¾ƒ›,ö‡ƒ{Ù æË=¡àÞöG±Åìú‘Ý€µêÇt<rØîËSÕd<>ßK#×R¥N…8Ò£A%¥¢Iƒê‹t[üì}ÓnŠ?D\0Ñô\0\0\0\0\0\0\0\0\0\0\0\0\0\0Œ½7¾¢e_uÜüH·ÚK~œPò¯ºî~$Ž¹û=ôêû>£gž›WgÁz’Ó¨Ñö\Z†¡qTûKÑê]½©íä9–ê»F¼ƒiwÔû_¼Ãâ£°up§½…Ù¾ÚßôQÚ:½<!Ô#‚ÙûA¾–ß]ûpÛüVNIûA¾–¿]ûŸpÛüVhv“ÐãóGÍ¦Ï½¶>l05]€E+SPŸ,\rt	]ª}lÎ=6w<Ñ^i½·o\rÀtš”—	Ü¿aâZÉù;L=—°S4cvy¶•{Ëêª•(Eso­ö$µmö#aÛ.È˜~Î²}–X±Œe*1ß¸ª—\Zµ¥ì¤ü¼rFó\"ÀN*ü]«ðÓïžhù·.\nqü-QæÓñæú½U&œ8.²ðúê\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0£”cÍéÖOŠhøù²þû\nËØ®)†[FæòÎÆ½{zåV¤ å½8ñi/)cÓ£:Æ),•‚~V¯Êabqöp“wŸ©‡‹Ì0ø)ˆ¿:kÃtÊiê»F«´…¾®œëí+ü­_”.9Û^+_ûµ~SËXN™îaù{ëû§èšZ®Òš¢¾œùÝÿ\0™¸\'å*ü¥=\\ÙãÚn	ùJ¿)ZÂtÏtž^Àúþéú&Ž¨jˆ]êæÏÓpOÊUùG«›<{MÁ?)Wå[ÂtÏtž^Àúþéú&Žòÿ\0´7‘ý\\ÙÛÚf	ùJ¿)GÓ›;õdÌò•~Qå¼\'L÷Iåì¯îŸ¢hï!¼ˆ]êæÎþÓpOÊUùJ®œÙÝÿ\0™˜\'å*ü£ËxN™î“ËØ_Ý)¡ª\Z¢z¹3¿´Ìò•~QêãÏÓ0?ÊUùG–ð3Ý\'—°>´÷Jgê†¨†®<ñí3ü¥_”z¹3Ç^LÁ?)Wå#ËxN™î”ùwëOt¦~òíÑí!‡«—;ûLÁ?)Wö‚éÇžù›~=oÚ\\ÁôÏt£ËØ_Ý)Ÿ½Ñ½Òú¸óÇ´Üñë~ÑOWxö›þ=oÚ\'Ë˜>™î”y{ë{¥3÷—i]Wiý\\yãÚnøõ¿hªéÅßù‚~=_”.`úgºSöÖ÷Jgê»QMWj!‹éÁý§`ŸWö‡«ƒ<{NÀÿ\0·í.àúgºO/`}ot¦v«µ\rWj!«ƒ<{NÀÿ\0·íWxöþ=oÚ]ÁôÏtž]ÁzÞéLíåÚ†òí!‹éÁžŸ,Ÿ€ùe[öË}[¹÷]VQËËòß¶G—p}3Üy{ëOt¦†«´j»HZúní_[•2ò_s_þ¡ËG¦öyRþÉÉøHöBU¡ùäÇ—p}3Üy{ëOt¦fü{~î|H›…ôâ‹ÒÖÎô]u-q?‹(XÈÙk¥ÎÉ1ÉB…õÕö\rVI-/hzÕøPrKÊdZÍpwgH®;w|Y³\\ßÃr;w|Y°/ÌØc¶æ‹Zâd“ß·«¥ãÑðòŸJ5ž‹S>*Š£X–Â&&5…Àè\0\0\0\0\0\0\0\0\0\0F^œP²¯ºî~$Œ¹r%ÇN~ae_uÜüH>?Ï}:¾Ï„(¹ç¦ÕÙðWÈWVP\Zv¤ˆ\0WVP¨DÀ¥½‚aòíµ¤ÿ\0 Žñó²ÛÞË¸[í² ÿ\0 ¢uZ?:}<!lùg¥³Ól>á·ø¬œÓàµÿ\0¾DéqÃl\ZõØÛüVhöÑ#óGÍ¦Ïý¶>l2ŸiRÅÄyJ&ŠJòêTª×©\n6ôåR¤ä£Ajäß$´í¶÷—í-hÎµj²P…8EÊS“ä’\\Ù0z<ôv§•#G9ç[zu1Š‹~ÒÒKUhŸÙK¶§æñòÍÀà.ã®r(áÏ<ÐÍÀànc®rháÏ=«Ñ»b ák3æXüðb}l&–¶”žž³ºO†¾c9B.-ê»„ âõz†·„µ­Æè_pøz0¶âÕ¾\0—°\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0†´ÞŽ;ÑÓŠ5§¶œ‰Wg{FÅ²ô¨ºvÎ³¸³zh¥BmÊ:x¸¯!³.z‘û¥¶ÉwÊK6`ÖûøÆNPŠõÕí~Î=î>ÉyWY¨Î0³ˆ³Ê§;þ­6y‚œ^•DyÔïìçþº_‡iB¯Tô|Êç?ÕTÊïwZu‡§Q	\\š`°®¬h•À¦ñ]Q\Z \0\ruewßah!.Mâº£ˆ®óDhjä\rw–)¾¶\\¤F‰ÔÕ®\ZjWQÌiÞÈ4W‡yA§aN=`ÑR©èQ5Ö8>AµEK\nï24N«‚zÞí+ªd\Z«½ÜWy€•Ü_&9-<Åº²º°>¦™sW¼†#—q«Ü:âŸ±©mZP~\'§»ŸBìï¦n;†J•–Ð°ÈâT4Qw¶ÑTë%Û(-#\'âÐŒéŽ½Lœ62þuµVŸæ^ˆÂN¶ªÒ:9»›7É[HÊ;BÃ–#•1š‘IxJ{Ûµh·Õ8>1=,%¼µ5m—s.;”±:xÆ]Äî,.é=UJ2ÓUØ×&»™/ö\'Ò«\rÍ’¡–3äèa˜»ÒnùP¹—Rzû	?3êâZpÝ¼DÅ¼Ú½Óô[2üòÞ*bÝï6¯tý0Ó–ý8ÏT÷–º®EÆõ¾\0€\0\0\0\0\0ÉÓ‹êU÷]ÏÄ	uÓ‹êU÷]ÏÄÙ@Ï=:¾Ï„(™ç¦Õì‚ð[«	³PÔ/Þ+ªí,Õ#Dê»Ä:ËuhªoÊÆ†­¡åµ»—p¸öYP_ÐGÑ:¸]o†Z[µû•\npóE#´uZ#JbB8-©ì_‰þbtºúð\\{†ßâ“š«ÒOé±£mjµq±—åqe+Jý3R´)ÓM.<døéÜisûUÞÂÅ6âfuŽ­Nwj»Ø^M¸™c‚/ëÔz\\‘³ü×´,V8NVÂª]M5ájò¥EkÎrä¿;äµ$NCèkkm:W»CÇcu%£v6:ª~)T|_‰%ã$v]ÊÙ{,atðœ¿„Ð°´§Ê¨ëÞß[ïf—³÷nÌUˆóc£Ÿôþ·4Ø<†íÉåb<ØèçýËc]rÞÌéÃ¿TñLzQKÓSŽ´è.µJ/—Ýsñ†4Ü^®M•Tâ¹\"âß‡ÃZÃQíFµÙ±oD[·\ZD\0Ýê\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0N*ŠJtã%5¤“Zê‹À¤þÄ+lï1TÍY~ÝË.âÕ\\’‚ái]½eMÿ\0%ó•->Ój™—.a9¯ºÀ1ûÝXÞStªÒ’æ»{šæ™¯­¹ì;Ù;ÃÂ]à7’~‘¼Ýà¸þç=8)¥ç\\Š–i—MŠ¦õ¸ógÝú(ùæS8j§f<Éãôø1’Ó¨ƒI¢¹ªâº®ÂÄô.Õ\rªí:««í+iÌ´•úëÄ ¼ßeuDh\0B\r_k.Þï-\0r)&Tâ.×ÄF‰Õ~‹°£O¨µH¹=W24O]82»Ë¸j»A\0\ni§›]A\Z/ˆoBÝíyŽ|ˆÑ:¯º>ÂíWi\Z\Z…uÓ™nñP•wÑTõâº¹€$¯GÞ“—x¨d­ ^J¶&©Ùâ3“s¶|”*>¸wó^.S…zw©Ö£R3§R*Q”^ªIõ¦j›{BKt_Ûüð{»Mg;öðúÓTðËº²ýï&øR“`ß-y>´,™Nm4ÌaïÎîiùJÑ“ç|DîæŸ”¦H(§ôRMøÊ–Å´\0\0\0\0\0úq?íT÷]ÏÄ·»‰yÓ“êT÷eÏÄJyéÕö|!CÏ=:®Ï„/…uf£F¥pÕö”L¨ÐU>Ó¹„Ûz{²²\\]ÅÅ:Z}Ô’ýgHõû!Ã%‹íC+Y(¹\'ŠP©$—8Âjrø\"Ï«TrëŠzeéfž]Êhé˜l¡-]ÅJ\'ªOµ:“§(Ò’Ñ­PÜ‚ãºŠ€)»ÄU$¸ \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0£Z¦»O™²ÆšðkŒÃ(ßÙÜÇr¥*©4û\Zìkž«íkU¡óU1Ti(˜Š£Ià€sèÕ˜vgs[\ZËÔ«bynOz5#ê¶«íj%Ô¾Ùpå®xDÛEkh\\S•\Z°„á5¤£(¦¤»\Z#ŽØ:åìÑV¶9³êÔpLN¢s›OÒµeÖÒÿ\0ßwâ·É¦&kÃðèú*žÎÎ³w	ü¿O¢Òç}šç^;<Ý—îl·¤ãN»ƒ•\Z¿s5Áø¹÷e=M\rtUDòj%U®ÝvªäW\ZODªW{´ >t|ë0»TÁhÕ¢4N«E.Òº®Ò¨ªº²©ö–€•ãBÂº²&À¦ò*´í#@*¼e< „«®…w¼e !Ëª­B“LZ¹4Ôq\\‹TÊ©&F†°oH®©”Ó^:•ÐPžŒ·Šæ7B÷.Áªë-M2¤hë‚n/y6šâšæSTS^\" Õ::+í~Yï.O,ã×JxÖùK×\\[òŒûÚäü¬Ï1œeÉšÆÙžw¿ÙîvÃ3U•I\'kU+ˆ\'Â­p©ºõŽ¾]²Ü\'´Å¬mñK\ZŠ¥ºQ­Jk“Œ’hºäØÙÄÙäWø©øs/™:qv9ÏNïlsKº\07MÐ\0\0\00ôæú•=×sñ D\"^tæÚª¿Úî~$ƒ«(yß§WÙð…=ôê½‘ð\\\njŠš†Ÿ|\0\0UÕö™§¢Vñm¬Û_JTð»j·\réÊM(Gã3\nù	Ð·(ÎÇ,ãÎæ‹RÄn¥´Ÿ]:\\d×ŽoOÁ6YM‰½‹¢9£sg“ÙðØÊ#š7÷~©5œS\\šÕ(´ÑhTè.€\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0Nœg¦½Eàþ‡b¶u0üNÎÝ­e»Rzj¤$»ÔµFÎvK™¥;Œ:Êç¸“×[*ŸKüIj—“C8\r¸{WãK”Ä¼/álâcKÔÄûP·0ô\ZÌôªelé†ÝÇœi^Óyâ¤¾cü_¢¦Ü°§\'£Nþœ^›öw´fŸ‰JQ—ÀlCÁC°x8ë®š\Zêò\\5|5dýZ›»;‚¹øbiöO×V².ö+µËÕÎÍ³\nÓ›…Œê/<SGÌ«³¼ûAé[&cp}’°ªŸÅ6•¹Áàã®ºóÑÍ\\÷1\'eìó\\ŸsUÏ$çÏ*âëýÎ§È>rs‹ÿ\05qoyÔù\r¨îG¼x8÷ùÏŸ SûÏwêºÖ¿y=ÍXÇ\"gy?[”q™x¬jþÉÊ¶}žÚÕdÌmø¬j|†Ò\\\"ùñ+»Á÷~Ÿ_Ýú¦6^×ï\'º\Z¶[;Ïï–JÇ=áSä+ô:ÏþÒ±ÏxUù\r¤n¡¢\'îý¿¸û¯k÷“Ý\r[ý³ÿ\0´¬sÞ>Aô9Ú´¬sÞ>Ci«°nÇ°»ôúþäýØµûÉî†­þ‡YûÚ^9ï\nŸ úgïixç¼*|†Ò4CD>ïÓûÏq÷b×ï\'º\Z¸[;ÏËüËÇ=ãSä+ô<Ï¾ÒñÏxTù\r£h†êwéýç¸û±k÷“Ý\r\\ý3ï´¼sÞ>Aô;Ï¾Òñ¿xÔù\r£n¯ûcDGÝê=q÷b×ï\'º\Z¹úçßixß¼j|…^Îóêç’ñÅþãSä6‹¢©óCîõ¿¸û±k÷“Ý\r]-çÏi˜ß¼*üƒèwŸ}¦c~ñ©òEÜÚ¡¹µCîõ¼žãîÅ¯ÞOsWCÜü¿ÌÌoÞ5~B¿Cìùí3÷…OÚä~Õ\rÈýª#îí¿¹?vmþò{š¼{>ÏüËÆýãSäg¹ñ™xß¼j|†Ð÷cØ7cØ>îÑûÉîGÝ›¼žæ¯~‡¹óÚ^7ï\ZŸ!O¡ö|_æf9ï\nŸ!´=Øö\rÕØ>îÑûÉîOÝ›¼žæ¯>‡ÙóÚf9ï\nŸ!_¡özö{Æ§ÈmD7#ö¨}Ý£÷“Ýú£îÍ¯ÞOsW¿Cüñ×“ñ­:ÿ\0°j|„èèÁˆc—[)°Ãówiu…U©e»sFTå(E©A¥%ËvIy³¹ÃuŒ#ªFf)Œ\rß	MzîÓƒ?/Ê)ËîMÊ+™Ö4T\0n€\0\0\0`éÏ§Ìªÿ\0Úî~$€Ö¼™/ºt}@Êý®çâ@‡ú²‰úm}ŸP³ïN«Ùåueš²º¦jZuW\\ž¥š\"º¾®±0]ü½Ì½ž	‡Su.¯«B…(¥¯4µ6[‘²•–LÊNW±IRÃ­£KT½”ùÎO½É·å#D\r“Ô¹º«µrÛJ4¡…ÂKÙT~Î¯‘p]íö\"]ÓZA\"á`æÕ¹¿\\o«‡³õ]66-Mú¸ÕÃÙú®\\€Â°\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\"ÿ\0N––_Ê¾ì¹ø!öò&N¯ï*û²çâ@‡Ú2‹zm}ŸPsÿ\0N«ÙÀ°»{¸ÕhÓê»WÚd-Šì—ÚÎi†INŽjãSºÓØSûX¿·—%ÙÏ¨ù›0Ù†cÚ¦b¥`T\\i&¥ww$Ü-éõÉö¾ÅÖlg;?Àvk—hå¬ÙÂ•4¥V´—¯¯Uû)Éõ·ð|«,œ]|»‘æG¿«êÞeUXÚü-Èó#ßÕõ}œ	Ã0\\&×	Â­iÐ³´§\ZTiÆ)(Å-—´ú)$´K@½1Æ½DDF\0	\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0{§_÷¿•=Ùsñ CÝeÔLoûA•þ7såõ#OÙæuÏ—±°Ê™ròþM­ê±¦Õ\Zk¶u­Šñ²‘œQUxê¢˜Öw|!DÎèªæaU4F³»‡±çu2†È6›¶¯yNæaØ\Z—Óq\n±ÑIrq¦¾Î_3®ÊúàøL¨âûHº¥Š\\­$¬(¶­âû\'.sãâ_˜’–xu®B•¥•½+{zQ§F”a¹$—ÀËÀäuW1^#ttsöô32ýŸª¹‹˜½ÑÑÏÚø9g¹sfø%-XB…\nkZ•Ž¥iõÎræÛóviÈõ\0š(¦Ý1M1¤BÛEÛ¦)¦4ˆ\0Ûè\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0òqÜ©—s3·xþi~­dåE\\REù´Ÿ£¹g†Yaöñµ±·§oJ#\nPPŠñ$´;@ùäÓÊˆÞŽLk®›Öx5ÚûÀ% \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0T\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0©DÓë T\0H\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0®…5] T\rSä\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0’–ïQó1¼Ë‚å»bXæ!FÎÞåRZ7Ü—6û‘ñ]Ê-S5×:DsÊ&¨¦5—ÒsŠzjq×¼µµ£;‹ªôèÒ‚ÖS©5Åw·ÈYÓ¤­ÝÅJ–™/TijÒ»ºZÎ]ñ‡%å×Èbs4f,ËY×Çq›«É7ªU*7â%äE;0Ûl\ZfŒ<MÉéáü}Ý­MüâÕ¹Òß>ä³Å¶Ï³\\\"R§_4ÛV©£²u¾¦¾Ï\\t’ÙÝ6ãF8m5n’~ycA¡Y½·9…sý4ÓÉŸ›]^u~D%>’¹RÒ¥¶)M>µnŸõµ‡mëf7íFXûµ“ä®(N+Î“KÎD=çÍ½·Ì©Ÿ:)žÉùJ)ÎqÆ\"{·\nÌx;KÃ`¸Åô7o^54ñèøCy%®Ì@{{››:Ñ¸´¸©B¬±9¸Éxš2WÛ¶|Ë®4®o£Š[.ßiÝ5ÇÏ©½ÁmÝ‹“âíÍ=q¾;¸üY¶sº*Ýv=›ÒáI>ELu‘vÙ”³žå¬ª¼;–‰ÚÜ=7Ÿò%Ê^.}ÆCŒ÷º‹®cn.áëŠ£«úÝÚÜZ½EêyTN°¸\0e=×R›Ó¨¸À}\'ïïìÞBÒúâ:Ñ¸u!N¤£é¹¦©><Ù­Í³Êð•b¦žW\'MÜ8ÌGÍáŠ¿âÖ¦ìÆº3}Ö5ƒØ½/qKKwþ¶´aùÙÐž{ÉÞíLãÁöK¢ŸÆ óÕ½[Õ¾-¾²žR‹^ß]ŸÁb;j™ùCI9å\\Ô{Ó}m!7¢ÎØüFíÇ=d™ûá‚KÅˆRÖ îƒCâ6ûÏfžùG—+õ!:#›²¬Ö°Ì¸T¼W”ÿ\0h½fl¸ùcøw¾©ü¤Ó³A§y÷}wžÄ4ý^\\«Ô÷þ‰ßÁTzSÆldû® ÿ\0YÛ…Å\n±ß§Vj’h€©$rÛÜÝZMU´¹«Fkì©ÍÅùÑ÷FßÕûv?òÿ\0ü¦3Îš=ÿ\0¢{º‘KWÀª’kUÈ†XÖ¶—çk˜®kÓ\\é\\ËÂÅþ7„Î;Ûþ	™ªÓÂs$!…bj0©½ôŠÏ±7ì_sáßÔoòÝ®ÀfEªµ¢©éáßõÑ‡Íl_žLîž¶^Šªz8­Së×™yi‰Õ²\0Š9¨ðe®­4µrI.·È¥X§â Ž\'ˆ_ß]U•íõÅÃß—\Zµe>¾öW3üþ28£û>_+^}8iÕ=,v;Ä¢<ÝuN:øþkûë\Z±£÷ËˆGó³§S;äºOJ¹¿‡Ýb—õˆ9 Ð«U·×gðØæŸ¤5“žUÍG¿ôMÙm CÙglþ#Eÿ\0Xã{JÙêÿ\0=°O%õ7úÈM Ðó½ÄóY§¾_>\\¹êBl=¦lñž¸/¿iü¥VÓ6zÿ\0Ï\\ß´þRh4#ïî+÷TûÏ.\\õa7#´mŸË–wÀ¿â¿håŽ}ÈóÓs9`r×³¢ÿ\0¬Aí\Zu#ê6÷ÏfžùO—.zóvTªô¥™°©ýÍí7ýcµKÂk½(bv•5ûJÑ¬º\rJvþçíXæýQžO=ÿ\0Ñ?H>)ëâ.\\LIÑ®Rž@ªœ›Ý¿¨¸¾è™mrEû.ÅøþŒNšr£]8ýË|=ºni¦°\0Q½¦kÕRŽJ<Î–+a¸%•\\G¼¥kmEk:µ%¤WýùÌžzIÜ×­RÇ#Ú*4£¬};qe>øÃ’òñîF«3ÎpyU¬E[ç„FùžÏŸ6#k\ZÜžÎt¹¾³²£+‹ËªVô µ”êÍB+Êø?ÛVÌð©Ê\\Óm^qûe*ßS_	±¬ÅŽæ+‡sâ×W³o_¦Ôm/ä¼‡ÍÓ¼¤b¶öìÎ˜[QÓVÿ\0tiñ–šîwWùt÷¥]N’7§-ØÏ©ßU§Ã\"ú#¶mZJ3¯ˆQ×®¥¯ÈÙtï\Z\Zï¾ùžºù½ß«ÃË8y»“?	ÚÞÎq™Fžl±Ir…ÄßgÓ4Õž®zU`ªSšœdµRÑt>æ^Î¹§+TŒð<næÚ1zø-ýêoÇÀÙá6ö½tÅZ:iúOÕ‘k;ŸóiîN\røë§Yrz­{LúFÚ_U§†gkhÚÔ›Qí$üË8øÖ«ÄfëkÛkÊ¹µ«\nÔjEJ!$ã$úÓEç.Íp¹¥¿	†¯^˜çlPÝXÄÚÄÓÊ·.p±{€\0\0oDß`,ua\ržs8í)äL-â¹«£cGœ#\'­J²\\dÈ³´>™™ƒ[žá«´zÆ7—)NâkµGØÃáf+0±„þòwôG32ÃàcûZ·ôGÂ¾Å0ì.Þw˜•íJÖ³«^¤a®öÞˆÇ˜ßI=‹`R•:ùâÒê¤~ÆÊ¸×Å(\'„€y‡7f|×rîó&={ˆÔoUáë9(ø£Éyò4]\\\rÝ¡¹3¥ª\"=ªíý§®gû\n\"=¿¦Ÿê¸é‘±úrq¦ñºÍrp³I|3ý26?QéWæÝ.ùÙÅ¯‚dêÐÞ^Åõw0þñã5×wwêØvÒsb˜¼£g:V•%Ê7t*Rø\\w~ a9“\0ÇíÕÞŒYâ4øËJñ«<[5cÍhv°ìWÁîcy„â76UàõKz²§%åLÈµ´7bµ¢\'Ù»êÊµ´÷cûÚ\"}›¾­ªo®Çæ+)­bõD\nÈý,v•eNß¸¥˜,ã¢tîÖ•tìUëÔ”{0é³ý¦S…­ßÌÌU¥½ay5·þ®\\§äÑ÷œ.k‡ÅO&\'Iè–ûœaq³É¦­*èŸëFS\Z­¬SQñ£Ù6€\0\0²UTdÖœ»À¼µT‹Žò×CÉgªäY;Ü×ŒRµÕkN„^ýj¿sÅøù>tÎÌØœêÚä,ŽjÞìnnR«q%Û§±‹‰ŠÌpøMÕÕ¿¢8°1™žºí[ú#|ÿ\0^ÔË©qF”\\êÎ0„V®Ri%åg’Æ6Ç²Ìn–+Ÿ°JU#ì©Æò&¼qƒm\ZïÌ™ÿ\0:æú²«™s>#½ö+Ëqx ½jóÆiníÿ\0•G|´v¢uþÊß|ü£êØun“Û£\'žèÉ¯´³¸’óªg=§I=ˆ^ÉBŽ²‹ÂÑ­Iyåtµ¯2«‡Ãï\'Õ§ßõcFÓbußE>ÿ\0«hxzÉ™™\'—³N‰6µÝµ¼§RKÇõ^T}¯­_Õ%:•(Î5iT”\'ª”^3!dþTÉr„,3EÅÝ´?É¯_†ƒ]ž»Šò3.ÎÐÓ3¥Ú4ë§êÍ±´ôLéz:ã{cQš“Ñj\\G}—t¾Êyš­,\';Ú¬žÆþõ­Gß.tßUÞgûkê”a^Öq«J¤T¡RRŒ“ëMuÌ>*Ö*žUªµX°Ø»8º9vjÖ?®gd‹ÞZ•2Y\0\0\0\0k©®½E\'UBJ-sëÔÂ{YéC“6}:¸V–;GXºf•\ZýeNßäÇWÛ¡áo\rO.ìéø‹Xj<%Ú´†lð°íï<ŽeÛÌr…IPÌ×¶¯eB5¼-Uã„5’óS>mói™þ¥HbXý[K9ê•“t©éØôã/+1ÛnMÊOVø¶Êýý¡ÓuŠ{géú«X§¦\'L=\ZõÏÓõO+þ˜´“…ÜRïO²£dôŒÑÐ§Ó;dò“ßµÇcÕgýbh††ç¸¹ww5Ó´˜ÙÑß«`8GJí‰â“TêfjÖ“ÑznÒ¤W•ÅI/+2>œ2®j·ôÎZÌ8~)Msv—«»ãQz¯)«}_=N{Bÿ\0¹…î{^Öâ›Ö5hÔpšñ5Ä÷µ´7¢´¦\'Ù»êÉ³´÷©Ÿíh‰Ž­ßVÕ£Zz\'Çó;g½,v‡”ªÑ¶Ì3ŽaÃàÒ”.%»YG_±¨—?\Zd´Ù¾Úò6Ô,£W/âò1Öµ…Æ¯Mõðû%ßWˆÝá3L>/Í¦t«¢­ë6Ãc¼Ú\'Jº\'‹ÞƒŽW7£ŽÆr&È\0FÔSo’:wxÞa-ÛìNÖÞZk¥ZÑ‡Þ,îOØ¿ú_-6ÍtŸìgý0ÆN×„ˆ×~ŒËäû“®ý8éõMK¢d?ßyß£Ûá1*1ÓÏ#åÜm¯dVºø]¤e×§Úbçñ[5¨\ríÞj#Þ®NÔ]ŸÃn;Û«Ò#b´xÏhXcÓí7çù¢Î¬úLl6Ë?Úù-«¿ê\ZîáØ5ì<çhq<ÔÓïú¼çiñ<ÔSïú¶#“;›Ñm×Ëkp¿=3»kÒc*[DÂc¯]YÊšóÉ$pñç«óCˆç¦ŸÔ§ÄsÑO¿êÚžòN>Ôp<ß‚â—(Û_Òªß’2gÛUa%ªz®ãT<uÕ=\Zãª=6^ÚnÐ2¬ã<7â–±‡*jâR§ø’m|M½¢ýåÓý|YV¶¢8]·Ý?×Å³uZ›ëæ^¸­HY‘úhfÜ*¥;|í„PÅíuJu­þ“^+·Oc/€”Yk+iV\nó*â±¯8Åx[jšB½ü¨7ð­Q¸Âæ8|^ê\'Dñop™žºÕ[ú\'tÿ\0^Ç±Š®­pçð™Ìð\0H\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0“ij„ž‘lòJÏö/ÔÄnj]Õ~Ò‡]JšsÓíW6þSÃˆ·…µUë³¥4Æ³/‹—)·LÕTéêí3jXFÏ¬…Ý¹Ä«E»{XËFÿ\0•.µ|äUÍ9ÃÎxŒ±,zúU¦ÛÜ¦¸S¤»#¤tñ¬gÌ8¥Æ3‹\\J½ÕÌ·ç9?2]‰u#¤q¬÷h/æ÷&˜žM¸á9éŸ‡2¥Ç×‹«HÝOGÕM\n€WZðœy$Ûî@T\rÊ‹‹„´ïL1¢@¥¥	8´õM=4fhÙ6Þo0Š´°çu+›¤(ÞOJ©Mó”{ù£5¯0û†]™b2ËÑ{V“ÏÓÕ0ÈÃâna«åÑ)õo^•Í(W£R5)ÔŠ”\'¬eµM>´ró£¾Òjøe±{–ã%)áÓ›ä×K_­xš$[qÕ¯)ÌíæØZqûc¢yãúæ\\0¸ŠqVâå*‘ó¥OîÙsînWÄ$:Sñ«—uì¹ÿ\0–kv»ü\"ïðÿ\0ºù§¢WÙñ†\0YO\0\0\0\0\0\0\niÇR ‘œ¶#¶JÖõ¨äì×rçJ£P²»›ãÕNo­>§ÕË‰\"c=tâˆ›‹R‹i§ªièÓ%ŽÂóìó–XVx…E,G\nq¡Y¾u!§¬ŸE£ï]çLØüú¼Dø†\"u˜ü3ÓÍÙÍÔ±å8é¹ý…ÉßÍôdÀÐ[Õ³ö/ÄÈsûâ¯ÝËó“Ú£à×s M×ïš¿w/Îs¿á‡þ/ýZ÷…¿\'\0æêð\0\0\0\0\0\0\0OôfõÙékËšþ„¼Œ;ÑŽZä‹åö¸”õüœÄŽç³“®Wcò®¸F£Ø>GÉÌ™‹Ë=Æ5‹×T­­ã¼ß\\ŸTRëlú²ö/ÄE]½çúù—1Ë.ÙWþÖá3põ¯…ZÜ¥\'Ú—%ÿ\0ØÏ³jr|$ÞãTî¦:þcqQ„µËçæy­¢m#\ZÚ+:÷St,)É«kHKÖÂ=²ûiv¿Ìy \'‰ÄÝÅÝ›×ªÖ©ã*mË•]ªk®u™\0ƒà©·Ã‰TJU\0…42NÈö¹’1\nxV)ZUðZòÝ”$õvïíáÝÚŒnSC3½€½ìN•Gõ¤õ=lÞ®Åq]½=­o)^R§qo8Ô¥Z*pœ^ªQ|š;èÛœªãÆV¿ªç_	Òvò“âèK«ð_Fh;žYŽ£2ÂÑ‰£ö£ºyã½tÃ^ŒE¨¹à\0Ï{¨ÛÔÃ[sé„l²Ú¦…ª8†c«Yo®°¶×”êµðG›;!6×o²|¿à0ùÆ¶?ˆÆP²¢ôj”~Ê´—bê]oÄÈ‰bwø¾!qŠbwu.nîªJ­j³zÊro‹4®k8oìlÏÏ=ª½œç)ý…ÇÏ=«½š³~cÎ¸µ\\o3bµ¯®ª¶÷ª?[ÕÇ”RêHøà*ªš§•Të*=UU\\ÍUN²\0”\0ªŒåÂ)ëâ.tj¥«§5ø-E€y\0@]J­Z!ZIS©½EèÓíMr-)=°N”×v5íò†Òï=1k6©Úâ•¯¤ú£UõÇù\\×^½Rî•Õ:ð…ZU!:up”^ªIòiõš¦%çD¯\\bÔžÌqë·RâÎ›«†T¨õr£eKWÏwšî×©lŸ4ªjŒ=é×¢~_E·#Íë®¨Âßz\'å?$¤\0²¬ÜRÓ^%¡mR¥GZpZ½Hñ·ž”699ÜeL*W˜âÖ®½•G×÷sîäºõäqôŸÛílo,‰”®÷q«ªz^]Añ´¥/±dåð.=d/”ç9:““”¤÷›oVßk}o¼­æÙ´Ú™±bwóÏGTu«Îu6&pøyó¹ç£ª:þ×w\ZÇ1ŒÅˆUÅ±ÜJâúî´·§Z¼Ü¤þEÜŽˆZffu•6fjjâ\0@\0\0\0ÕÀË{é™¶_{K¾«SËÕ$•[IÉ¹Q_oI¾O»“îæb@zÙ½^¸®Üé/l>\"æ¸¹jt–Ñ2¦kÁ³~m˜rýí;«µ½Npz´úã%ÔÓàÓ>Ü[k×s5ïÑÿ\0l÷»,Ì±µ¾¯9åüJ¤c{Gš¤ù*Ñ]«¯µx‘°;+š7–”ní«Âµ*ÐU)Ô„“Œâø©&ºšâ^2ì}8ëzðª8Ã¡e™9…®W\n£Œ\\Òæ\0È8/.èØÐÕÅXS¥J.u\'9nÆ1\\[o©µ$ãWiºSíî¾3y_f™RïvÆÖ[˜Í9~ïQŠ‹\\¢Ÿ>×ªê0ñ¸Ê0V¦å]‘Ó,<v6ÞÌÝ¯²:e×Û÷J+ìÉRã(ìòî¥®iÜâÛK®ØÁóŒ;ù¿å)I¹JM¶õm¾eG¦½|¹‚‹‰ÄÜÅ×á.Kbñ—q·&åÙúG°\0ì`\0\0\0\0ía¸ž#ƒßQÄ°«ÚÖ—T$§Nµ¸Ê-uêŽ¨&&bu‚&bu„ÔèýÒrß9;|£ž%JÛiS·»á\Zwš.	®QŸw\'ÜHšr”“ÞIqàj’9Æ¥)¸ÎXI=\Z}©õo£.Ý«çÜ5eËy½Žáô“…Yû+ÊK†÷Ý.\ZùûKVSšÍÙ‹ç4ôõO_ÅsÉs™¿1†ÄOÍ==S×ñøÈ0YJNPÕ¾²òÆ³©/büD\ré‚·vÍs§^mñY<ß&@î˜kû²V}¸u«ø£Ïý=±óhvÐ»a„\05C\0\0\0\0\0\0¡€ãøÎXÅ(cX#ZÆöÞJTëR–ë]Ïµw3ç‚bf\'XM5M3FéOnû}²Ú¥‚ÂqeJ×1ÚCZô×\\Åpu)¯ÎºŸqš›ziÀÕ®XÌ¸®OÇ¬ó&pèÝØÔU!.¦ºâûšæl—g9×ÚPÃsn\Zô§EJ¥=utª®ƒïRM|%Ë(Ì\'Gƒ¹>t{á|É39ÆÑ6®ÏŸO¾:~¯N\07mè\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0`q\\V¥F…JÕªÆéÅÊRoE–­ùmµ,ñ[=f»‹õ9zJÝº6po‚¦Ÿ²ñÉñ3çHÓS/äŠ˜}µ]Ëœ^~–M>*Ÿ9¿*áådS]¼Ži·¤Õ]8\n\'to«ÛÍ>ØWsœLÌÅˆöÊ Ôç\n§¨É[6Í9òãs³P¶Œ´©u[XÒ‡—œŸrâ}M‘ìÎ¾Ðq™Tºß§„Ù8»ª‹ƒ›|U8÷¾·Ô¼d´Âð»Ê–†ÚBÞÚ„TiÓ¦’ŒQqÙÝ—«4ÄÌÅ¾m8ÕôŽ¶ß/Ëgæê~,Y–z7å.œ*cÕëâ×\Z\'-_‚¤ŸtW¼lÈfCÉØTT,²ÎM%¢þÇŒŸêz\0t¼.QÁF–-SšÏ|ïX­alÙ(¦\Z˜.\r8ø9á6r‹êvðkóW1ì‡ æ:sW8\rj­=+ZÇÁM?\':=À2/`°øšyh‰Ž¸‡Ýv¨¹\ZU(“´‰ãÙ#°”±,%qðÑÓ).ÉÇúË‡ˆÇø«F5¡*Ui©ÂkIFI4×g>mk`µhT­˜²5¦õ)k:ø|8¸>·Oµ\'ÍØs ÙÃÄâp­<ôñ˜ötÇW–ƒ•Má,pèú0QGÔ}#\0Æ1üF8F‡Ö¹»“ÓÁÂ<cÇM_bïd‚ÙÏGœ3t±lãàñ¸úèZ.4)¿å}»]œ¼eg*É1yµzX§ÍŽ5OúÏT5¸lÜTéDnéc–l¿8æ<VË°‹Ãl­kB´okEýŒ“ú\\yÉðî]ä¸§®âÞ|zËhQ…\nj•((B<#´I‡\\É2[Y-™·n©™«ŒÏÊ9–¬œšgYž!:Sþé—|W_ž™ ÈûÒŸÙeÏ×ü³kÁîÿ\0û¡åšz-]Ÿ`@ÅTðÏ»\'ØÆKÍy*Ã1c”.ªÜ]J¶òyB:F¬ ´KîLÉƒ°˜nl§_É¸~{ŠŒ¶ìvÆ7UŠ\"¨Š&t˜×~´¶¹Eš/^˜®5>pëÒØ.Ìé/¨S›þUÄßë.©°™TƒO”_lkÍ~³!ƒ§y/ÓOGòÇÑcñK¤w0î1Ñ£%ÞÁüÉ¾Ä0ê=ß\\ªÁ>õ./Îa¬ý²<Óuº»§Ì;]#yA=Õ¯%5Î/àï&9ÔÅ,-±K*¸}íÖ·¸„©Ô§%ª”Zäj3’ËñvçÀÓÈ¯šc‡lpbb2»ižDrg«èˆ©÷sÖ[yK6âyVákYªmótä”¢üÍä­UbåV«ãLÌO¶Jéš*šjãv˜ç€mÊŒ¦ãCÖÒ¢êÖ^ÃúIyÌ|v0Ûê¸f#k‰PmT´¯\nðÓ¶2M~cßŠœ&Ýúfb~¯»&ÍÊkŽiO(6ßóŽŒáR©N[Ñ”SOµ‡è^ádù? M×ïšß|—ç\'µOc/¹d\n»ý÷[ï’üç:Ûþâÿ\0Õ ÏxQÛòq\0n¯=^Ë²Þ›s¶b°œ­n<#¨¡\'Ô`ß5â$:<lÓŽöyÃý®fèùKÂm:ÆZ~çoq?þ6¿Y-#¦œ™±Ùf€ªæ\"Õ5O*xÄNí!cÊpÖ®Øš®S:ô{Ú=6b—Ô‹—ã»©ò—.û2_ù-o}TùLld™l‘GòÃi<<~ÄwC-‚ìÊ<ð¿÷šŸ)È¶³Ë/½{yü¦AÔdÙ|‘GòÇÑ>)cÔŽèx°Ýš\'ýîGËV)É‰ìÑ›_áÉþ³Ýƒê2Œ“GòÇÑ>+cÔŽè|l½•p,¥iRÇ\0°¥½ZŽ¬áÚrÑ-x÷$}ˆòEA›nÕiŠ-Æ‘ÑÁíM1LiOÁÎx×ÎþTÅ±”ýu¥ZïžEyô!\rZµ+Õ•j³rI9I¾m¾-ùÛó“mp©=—cÊ5F›zv*°oàÔ‡‡1ÛËµN*Õ®h§^Ù™”+™ÝSá)§›@\0PÚ7ÖÊÙcÎÝ¾„SR¯]¿]/c®r}È’y_£æHÀèÓ–+Fx½ÒZÎuõ={ ¸%ãÔÂÛÍøVOÎJëj½Ýlë5¯‚m¦Ÿ‹†ÆKš÷a^Þ´*R©(NÞŒ¢ù4×4tË0«_»UÈž¿HæÝ×Ò°å8k(šêjø>5¶KÊVtü±†F>äƒüé|KgÙ\'¤éÞe|:kNq·Œôt=&«´©}œªy3Diì†îmQ1¦‘Ü{Pèÿ\0a‡áUóKu£+eá+XÎ[ÊP\\Ý6øê¹èù˜‘>êÁT[²‚’ãÁ˜çØÏqëš—ŽÂã­V[Ó••]Äßnì”¢¼‰œ÷c¼f¸»—DSÓOöÇÓƒOÊ|%\\»\ZGR%‚IÔè»•œŸÌ¬Vò§/Ô‹WE¼´¸¼Ë‰?ý¸¯¹¹·©Í\rw’1]ÞÇ}/jZí/YumVœ—n‹Uð¢XÏ$ì//dœzŽ`²Å1Šô#(Æ5œ7=rÑðKS&f2üNY‚›˜ÒyS<uÝ:7Ùu‹˜k<‹œu—˜q¼?.áW˜æ)r¨ZXP•Åi¾¨E6ü¼8wŸMÉ.lŽ=4sÃÁòu†Q´¬ãW\ZªêWÝçà)èôòÉ¯1¹Æb#b«³Íñæ{cq1„±UéæøEm¥gÌOiY¾ÿ\04âNQôÄÚ¡E½U\Z+„!Ý¢çß©åÊ¾\r®ò‡=®º®U5Õ:Ì¹Ë•]®k®u™â ëÓ¯Ñ÷b×[ZÌr«|§G\0Ã%ÞÔQëÂ”kæßRòvl×~¸·n5™}aì\\Å\\‹VãY—ÇÙ†Ä³ÆÕ.Á,•¾	îÖÄ.SvîéÆo¹|ÉO“z lÇ/Ñ§WôÞ?wœçpü&û©Åð^6ÌÙ‚àøv‡QÂp›\n6v–ÐTéQ¥ØÆ+¸ïMcLMÈåU×Ã¹{ÁdXl-15Ç*®™áÙ/„lß à´Õ3&àô\\Õ¤$üíj}JÙg.V£*urþR:?[+Jmyš> 6‘jŠcHˆn\"ÝÆ‘ÅYË£žÊs\n¾-SÃî¦žíÆô™Eöè½kñ4D½°txÍÛ+«<Bž¸®)zËúPÒTõäªÇì_zÕ~e°“­ˆYÛâ•,îí©ÜP¬œ*R©(Î/šió5øÌ¦Æ*ÑÉ«¦>mf;\'Ãc)ÜšºcçÒÕG> I-¼ôY¾Ëõ®3VÎ,êÜá³Ö­|:\ZÊ¥·[túåîqïFË9\'6g,GæVZÀo1”ôš¥MîÃ9¾Qò²Ÿ	{sÁWùºýŠ.\'ˆÂÝð5Ó¿›MúûËÝ¶ož3.{ÂsNXØáp¸­R/qÅ=eJ+ìÜ£¬t\\4|L­²î†Ô­ªPÆ6—w§\'6ÚKoýd×âŽž2NaX=†\reGÂ¬hYÚÐJ0£Fš„\"»\\¾_’Üª¨»tG7?éñorÌ‚ì×MìO›¦øŽ~Þ‹·÷’k«ŸQäv·´-šälC4×Ü©^Œ7-(·û­yp‚ñkÅ÷&{û\ZôÒÎò¿ÌØfD´¬üE]ÝE>\Z¢õ‰®èqü#}˜â|SUqÇ„{ecÌñ~%…ªìqáÙþµG|gÄqüVï\ZÅ®¥qy{VU«U“ã)7¯ý£¦9p\\ºA™™eÍ&f©Öx…a	ÔœiÓƒœäÒŒRÕ¶ú‘D›i%«|’æÉ¡ÑÃ£µ–X²¶ÎÙÊÂ5ñ»ˆ*¶–õ£¬làúÚã\ZÓŸ/9—ƒÁÜÆÜäQÛ=ì¿s0»àèÝÆz“f3®t…,S4×ùÝÂæ”â§O~êªî†©Ei×/3$6Zè¯±ì¿ªø\\Z¬xº·õ\\÷ŸÜ­ó†q’áÈä-øl§\r‡Ã¬ôÎõã“a0´î§•=3¿þ6†É¶kF\n–EÁcÔí ßÂ™Œld˜Ü\'Jï\"áÐ×‡„£JkÄâdPfN\ZÍQ¤ÑÐÎœ5š£I¢4öB+m¡fZ[íœcUhW®ûÞ§>èÕ\\cåOÆˆ¿š2¦aÉ˜µL3a•¬néý…Hð’í‹ä×z6’x-ªì«/íO.ÕÂ1«XÂâœ\\­/Vý¼ûSæÓë]fŸ’Z¹^u]Óôhó\rŸ³z™¯\ršº9§èÖà>ÖrÊXÆFÌ·¹[·t®ìgºû\'Æ3‹ëMi§Ë©ñJ•TÍ4ÕÆŠ©ªŠ¦š£IƒƒàÖ¤Îè{´ºØöY¸È˜Ì§u‚¯	jç-[¶o—à·æiÄ÷{ÎµrÓ0<uTÝ·•Âµ»]N…_[&ûtÕIwÅ™v&p¸Škæá>Ïë{a”âçŠ¦¹Óº}“ôâÙ\"ä¼E&ÚŽ«¸FIÅ=uÕ.\"kX5Ú_Ý%ˆúGmUl×!ÔXud±Œ_[[Ÿ\ZkO_WðcËùM\Zÿ\0©Rug*•fç9ÉÊRo‹o¯Æe®“ùêyÇj7Ötk9Y`Úú	>ÑýÑùeªòŒ¢æØ¹Äâ&#ðÓº>n{ã\'Ššb|ÚwGÎ{Àµ“ò–1žs–XÀ­Ýk»ê›‘ì„yÊR}QI6ßgŒ×SLÕ1Lq–¢šj®¨¦˜ÖeÖËùwÍX,/a•ïï+KHR£ß—©%ÖÙ%vyÐºµz4ïö“T·”´3ì4r_wUêµîŠ~3<l“dwe<?\n´\\BªR½¿œS©^}|~Æ+ª+‚ó·‹^#·DExóÑÍU×/ÙëV©Šñ^u]Ñõø1ŽÑÛdc|™iq(¯Ý.·«Iþ3>üöY³š”üÈø.êì²†¿˜õàÜÓ…³DiMÝ\rí8k4F”ÑÙQ˜:4l0R”*eZv5dž•l§*RO·°ÀLèy™2ý*¸®B¾ž5ie+:±Q¹‚îÓÖÔøs&°1±^\ZM:OLnbb²œ&*4ªˆ‰éÒÕÍµÍz–·t\'Fµ)8T§8¸Ê2\\ÓO“8ÉÃÒC`¹ç	¸ÎbÂó•9T©\niGÓ´ÒÕÅÿ\0-%Áõòd”e	8N.2‹Ñ¦´Ñöün\n¼ÎE\\9§¥FÌrû™}ÞE[âxOOê¡ôòÎbÅr–=c˜ðK™P¼ÃëFµ9\'¦ºs‹íMjšëMŸ0q3Lë\Zjšf*§Œ6u³œç‡gì›†æ¬>QP½¤¥Ržºø:‹„áäzž˜ˆ\nóã£ˆâ»;¾ªÜ.!óBÉ>©ÇHÔŠñÅ©~%ô}Šñ/ÅxÞ›œüþ×KË±~;†¦ï??¶8ªù2ôÄúòUþlµþ±;åì_ˆ‚1[bŸ~mýc?ôXöÇÍ¯Ú?Bí†\0ÅâN<\'¢ÈêØ[]\\[â•¥Z”&ÿ\0³d“n)õ$AÎ\Z÷èmKzà˜{íµ¥ñ¿È°ö±Wái‰ÓN=«.Îa¬â&ç†¦*ÓN=¬K‰»¤´ùÝ¼—Ý_UÖ8îz$ìbâ\rRÁ/¨É®…íMWµð°/\'áwÐ´ù;	¦ž\nžèEŒÝÐ—	«oR®IÍWV÷Q[Ñ·¿„jR“ìßŽŽ>=×â#6uÈy§g¸¼°L×…Ô³¸KzÙS«¶„ùI@1ÆÝ¶ma´¬{†ÔµŒ±JR¹°¬—¯…X¦ÒO²\\S\\¸šÌ~Kjª&»¥QÍÍ-NaØ¹nkÃG&¨ææ–¹YÂT§*sZJ\rÅ­:ÑB¢£œ¸’¿¡qrxÞF¸­¬aâ©¾×»SOè?)¯Ñ{–	¶¬oîÒ¿u¬ª®Õ:rÝþš‰–Þ›ª*ëÓ¿sc”^›ÛuG<éß¹°”ÓäÁe%¦ºu²òþé \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0:Kã2»Îv˜4g¬0ûH¹$ùN£mü\n>sžÃlÒÄ6™Öœµtî¼ñSŠ‡õOplîüâs×\'Ö˜ì‰Ò=Ð¤ãkð˜Šêë\n(¹MF+W.©ö²M„1LåáÕ#½Nã·§5ÛR:ü\Zšû6æíÊmÇ˜Ž÷…òêŠzRÛfyJžQÉ¸~(Ö•%Záé£•Y¤å¯‹‚òµr)bŠŸ ðö(ÃZ¦Í¸ÝLDGbõnˆ·LQO\0³ì\0\0(ãª*\0éZá}•Å{»Kj5®¥½^¥:j2ªûdÒÕùNÚ‹OW¡p>i¢šcJa\0ô½*=–\\ÿ\0yüôÉGÞ•Ë./uË+{[þwøÝ\r~ièµö|a\0SÔ}„ÈØ¬76]€.Ú—ž¬ßë!»&~Èaàöi—–škeyÛ¬½lÖÜŸô|á»É?¾«Ùó‡¯\0QegÔVOE©×½¾·²¶©yuV4¨Ð‹©Rrz(Å-[~Cæ©ŠcY\'r+ôˆð_D»—OMçkCî·~Mfz\r fE›sŽ)Á¿s[JZóTâ”cð$yóæ·èÄã¯^£…ULÇ³U\\\\½]Tð™£âŠ¬*Æ¦)‰Ùá´–³»¯N„|r’Kó˜4S5ÕÇxDk:Bs`ªK	²SöJÚž¾=Õ©Ý,¥Â*Z(­î/?EQšbèÝ\Z-ŸüL7¾«}ò_œžÓäüD	»áw_ï’üìç{Ãü_ú´9ï\n;~N ÍÕç½Ø®gÀrŽsù±˜¯}+kJ´ãSÁÎ~¾N:-\"›å© )íçe_ßZO¾Êãþ™XÐ²e[O‹Ê,x½Ši˜Ög|N»ý“\r†2»…£ÁÑ§^¿TÃŽÜ¶W.Y²—–Ú²üð9c¶­—Ë–n¶^:UWõHo ÐÚFÞcùíÑÝWÿ\0³+Ëw½X÷ýS1m‹fRåœl|»Ëõ‘ÚÞÍeË9á¾Zº~rè4>£o1¼öé÷ýSå»¾¬{ÓV;SÙÔ–«:a[¨/ÎÏCaeŠZS¿Ã®©ÜÛÖŽõ:´ä¥®Ô×2´L‹TðÛ0ÀgÙBPüZ’_¨±læÒÞÎ±Y»DS¥:î×¦#æÏËó\Zñ—&Š¢#HÕí€É¶|ÌÇƒÃÀ±®›—¶Õ(?Â‹ZùÈ9ˆX\\áw÷uå7\nÖÕ%Nq|ÓM¯ÔÉêø¦`.­Z¬óÎAÔ{¿Û\n0\\x.VÜ‹R‘¶™UxËâ¬ÆµQ®¿—ôú´ù¾o[‹”q§àÀ@¦¥NR«¨Ö¼øž«(m38dÚX>\'\'jž®Ö·¯¥ß¢~ÇÈy`{XÄÞÂ×,Õ4Õñ¹÷EÊíO*‰ÒR+-ôœÁ®(æŒ½œøkZÕøHxÜ^Í©”0-¢dœÉðlÉe^Rÿ\0)ø:‹Ç	é/€„šïE©FM5ÅiÃBÙ‚Ûl~\"›ñÇt÷Æïskg9½Fêâ\'Ý)øªFKX½WpßZèB\\hyß/¸üÊÌ·´£P•Mø~,µFDËý&³5”£O1a˜•%Ît[¡WÇ×æEŸ	¶øÛ¯DÑ=ñîßîlmg6+Ý\\L_×2L\'ªÕÀeµä|Ù([Q½v7rà¨^ißt¹?9ïDÖ©¼62Æ2	‡®*Ž¦ÎÝÚ.Ç*‰Ö€—¢Êœ GK\\Ë<wl7¸|g­ÚŒ¼7œ|$ŸZ?>\'®‹CY›X¿–\'´ìÕ}7¯…Å®tû•Q¤¼‰$Wö‚äÅŠhŽyø+›MriÃSDsÏÂQó\0!XFSœaÜ¤ÒIslÙ&År\rìÿ\0À#B0¹ð1¯y$¸Ê¼Ö²×ÅËÈ@Íà´óÕ2¶^\ntªâtgR\rj¥K~I÷5•SZ>¥Ã’,Û=b&k½>Èùü–í˜ÃÆ•ßž<#ã?\' \0´-€\0\0\0*FRÓM<§VÓµ±U¥¥½7R§‚¦£¿\'Öô\\YÝi)ÔRo]\n€H¶ªÖÖnÕñùæ¤f<rsrW8…]ÇÙN/rÉÅy\r“ãw´Á¯î ô•jµïQlÕõOw^«zïÕ“ø[ýegh«Ò-Ñí•Wj.LQnßLÌ÷Ë€\0UÔöeè³³»|ó´zwøÖÃð(Æò¤%c:ºý./»^:$žêœ”“ÕÃ¡>\nÆÔR©{‰x\ræ¹F8¾Y’L»ä¶\"Ö*ç«{ äXzl`©«ž­óò÷\0nÜ€\0³ŽôZ.\0Fš?¥w€Xm\nÖ‚W6#gu(®2£6÷ñK‡áøÙVÚ°JxþÊ3VR*NXejÔÖŸã)ÇÂGúPFµtÓLÏlE¬LWµõhðñk)ý¨÷Çõt*85(ó‹Õ>ÇÔZ\r\"¾ÙžÌqéfMŸeìjozWX}NZó’ŠRøV§ÓÎ˜ü2¾QÆs´þ×XÖ¹IõÊ0m/+ÑyLsÑjúWÛÀå)kà]z	wF«Gc¤î%;\rŠææíõûª‘×àL¿Ó~cá¹ù:û2œDÆÃóòu÷j×ÝÅÅk»Š·w5JÕç*•&ùÊMêÛòœañÌÂeô7ÙÝ++\\çû»xú{“¡m9.0¶‹ã§ÝIqîH†©6ÖœõHÙ®Ì0ZXÎ²ÞF;Š†oªÓìœ¥ð¶o2w5ÏìÇ¾V-›ÃÅÜDÝ«öcß?Ô½JäŠ€\\—€\0\0\0%ì_ˆ×÷J‡G$í6æµNÇ\Z‡§¨Æ+E¶ÕD¿	7å6/büD_éÁƒÓ«–òÞ`P[ö÷Õlå$¹ª”÷Òÿ\0â~sOÙ‹¸Y«ží.b/`ª«žñð”@\0—?{Mf\Z™[js„ÜcÚtg£ÓXMîIy¤Í•ÃØ/ªk+™YÞÛÝAúê5cQxâÓFÓðŠþšÂl®wµð¶ôç¯n±L´ìís4Ü£Ù?×rã²÷5·rßDÄ÷ÿ\0Ã´ù?ºcðÛÿ\0êí¿<ÉÜù2	tÈ_Ý>Ü*Ùü32³ïEí›3hý¶0\0S%æ6¥—Þ¸\ZûlèüDj»Mxr6Ÿ–Þ¹w}¶Tÿ\0\Z,»9ø®v|Ö½–ãwø~o¢\0-+xqÕMµ¢9ŸŽbÖXs‹âu£JÒÎŒ«ÕœžŠ1Šz‘3\ZÉ3¤k-mm_¡‚í34á–©*1k•I.J£q^DÑå¯œ1éæŒÙŒæ9­\'^ïNÅ9¹%äOCäÚäÄ×3O\r\\ªýTÕvª©á3:w‡²ØÔç\r¬ä÷MzçÙÇÈêÅ?³Æ™#£®<cmZ„bÚ¡vîäû(Jzùâ¼çÖ&«ÔDtÇÅ÷ƒ¦jÄ[¦=hø¶+Mñ’k“/,§×©yÑáÔ€ \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0`B]¤ÆPÚcRàÞ)rüŽ£kàhó‡ºÛ†ðÝ§ã1Ñî\\NÌný8·ý-åä<)ùÿ\03·6±·hžjªøÊ‰¦i½\\OL‡ßÙíÌ,óæ^¹¨ô„1;mæú“¨“	ðèVµzwÞ“¥58¾Æž¨ÇÃÜð7i¹Ñ1=Òó·W\"¸«¡>cÉ>NYÆ©fÆhIJ–ðªôê“\\WŸSë¡mÜ¦í]<\'zùMQTk\0\0ûH\0\0\0\0\0\0\0\0Gî•+Ie¿÷¯ùd#÷J¯e–ÿ\0Þ¿å•½­ÿ\0»ü?î†iè•ö|a€ÀS”|É+³í¸ìÿ\0ÊxF‰_\\ÛW²´§B«•»qÞKŽkªÔM\'Ìh»\r¶Sœ_ÉîMÜ<DÌÆ“¯üÃ+‹¯	TÕG?JcÐÛNÌ®°Í¶‘îœ*CóÅÕÛ&Í)GzY¾Å÷GzOàD5Ñv!¢,q·˜í?»£ßõl<·{ÕzUã=\"ö{‡ÁúB½Ö%QqJ¾íg§æ0®Ñ6Í˜³å7†ÓÌì/]çoJZº­rß—_‹—n¦>Ñ\ra¨Ìv£0Ì¨›UÕÓ<b˜Ó_o÷±q•üDrftŽ¡$¸\" Ö½C l+\0ž=´L>r¦Ý=»ÊN·Øÿ\0I¯1à!ÔœiÓ„¥)½#­[d°ØnÏ*d¬½éÜNž˜¦)¥JÑâaö4ü}o½éÔXöc,¯0ÇÑ:y”LU3ìá³ól2Ü<ß¿Íå“ÑêTµ®f½k UçïÊÿ\0|—ç\'¬ù?¯~Wûì¿;9ÎßðÃÿ\0þ­{ÂŽß“„\0suxc	Í¨Ó„¥\'Ô–¬çŽ‰Ik>é®ê2¨úŠ*«„&\"gƒ®ÃÃ1(û+•ã¥%úŽ7gyekYxàÉðuGO&\\`¹Ð®¹Ñ©ø¬ºwµ^”í+ÉöF\r‘É™æ92âdÀØB’Ùf¤Ÿ±­§‹ÃLŒ˜Íó¶d¸…3\0»Ýœ–µ«StéÁv¹IhL£€ÑËoËô\'¿\n¢ç¦›ÒK×KÊõ~Rÿ\0°Ø+ôbkÄ×LÅ<5˜ã31?&ó%³]7*¹1¤i£ì\0š±\rj´8êR„àá8ïEði­V‡ i>dLj0.Ó:>Fö­lo\"Æ*³nul$÷a)>-Óc÷/‡ˆÀ˜–ˆà÷s°ÅlkZÜSzNX8Éyù¢znÇ±/Ë2Pô¶9„Û^A.šrŠ\\×¥fÛ‡ÆU7p“Èªy¿f~›ºš|VQnôòíÏ&}È/äœÇ:6dÜEÊ¦y{†MêÒ‹U)ëâ—„ðßFœéc½SÄ,1:k”w\nÉ-cý\"—ŠÙLÓ¿Áò£¦™×ÝÇÜÔ\\Êñ6ÿ\0g_cïã9:åöþke»ê1_gàœ¢ÿ\0	j>Ô”šzðá£4l\\±W&í3LôLhÁªŠ¨*\0O…©ï&Óêiò2®Ì¶ç‹åIÑÂ3\rIßá:îÆrãVÝ%õÇù/Èb²†n0Äe×bö­\'Ý=SïkîaêåÛ%<°ÜRÏ³¡ˆa÷¯mqRH=T¢úÎáz?m¶	SÊ8Ãxv!--÷Ÿ\n5ú’ìRåãÓ´“pm¾:§%Í¨Íð±~ÓÂc¢~†N*ÜWyÊšè’5Ÿ#(g|~ZJ8Ê~?	#gõ^Š<tzþ£[;lÃ%„mo6XÊ.:bµêÅ\"rßôdŒM¢mÑ=rÑmE3àmÕ×òý$\0UÆEèñsNÓm9R­V’•ã¦µí9Å|2FÅéë¾ùi¡«L¹Œ×Ë™ƒÇíVµ°Ûº7P]²„Ô’ø\rŸà¸®3am‹XUU-/hB½ý´$“Oá-{=r&Ývúõïÿ\0…Ïf.DÙ®ß<N½ñú>€\0±¬à\0\0\0\0\0\0\0™™©Ê®\\Å)CÙNÎ´WÁš·¹‹z‘|ÔåùÍ«ÜS…j3£Qk§.æjç6aÕ0ŒÏ‹au¢ã;KÚÔdŸVìÚýE_héßn¯oÉSÚŠgKu{~O’\0+*Špt0¸…M”\\QO×QÅëï.ç\nm~¿1 —Ð‹2ÁG1e9ÔJmÒ¾¢›Ó]5Œ¼bKBû”×àè˜æÝÜé=È¹·1Í\Zw\0bÙ\0\0\0\0>6t•8enu´ðqÃ®\\µìðRÔÕÇÃc]!s%,±±üÉw*Š5.í%aGµÎ·¬áÞ£)?!®^œ©m\rq7h£¢>?ð¦íEq7mÑÏ3ßÿ\0\0\0¯*éãÑ2úXop^œºqü£9úXÓœ¶1‰î·¤nhIþSÿ\0³»Ñ‡ž±|[®áV¸ÓµN£iŸG¤FñŒæ‹zPÞ©JÏÓ1îðrŒ›ó&^)¢g-äóò>N‰M¹òW#Ÿ‘òk¤\0QÜíTÒi¾Z›HÊãu”ð[˜i»W·šÓ±Ó‹5mÖ»\r‰ô{ÌðÌÛ\"À.aWz­¥²²¬µö3§ëRó$XvzäSvº:cáÿ\0+>ËÜˆ»r‰çˆžïùdÐ-«˜\0\0\0“ö2ñ2;ô×œ#²ì2œšÞž;Kuuð¡[Wÿ\0}¤ˆ“Ò-÷#¦öd¥R¶\\Êtªk*~þ²ñé~jžsY›×`ë×Ÿw½¬ÎnE¼\rÉžxÓ½ÀÎí9›IÉûË*`Ê~ËÒ5ñø4jû´•ýýµŒ²¸­\nKÇ&—ë6…Pô®im¦ž\n…8iâŠE—gbyW\'Ùó[6Z™Öí^Ï›´ùO¦JÓkðïÂm¾4ÉØù2\ntÊúïSþh¶øÕìûÑ{a±Ú/Bí†\n\0ÅìüÆÒ2½mì±„IJ:;všzÿ\0‹‰«~­Ôq\\R!‰]GÅZKõ›,»0ñ	ªy:ë×£o•f‘–Ís4ò¹ZséÃ_«jn¢K]ô[*ñŠã(ùÍY|ÝÆÿ\0Ó7ÞùŸÊqÖÅ±[ˆ¸WÄîêEóS­&¾m~ñGîýÿ\0£q÷¦ŸÝ{ÿ\0FÇó~Ù6u‘éTž`Í¸u:°_½©UUk·Ùàã«^]¶íÒWÚ}7–òý¼ðÜ\n2Ö¦óúmÓO†þœ“Ü`þðkñ™ÅüU3Dy´ÏGÕ«Çg¸Œe3n˜äÓ<tãÞp\\.¯P\0Ô4%ze)_fÌc8V‡Ò°û_JR–œêTiËOÁôˆÛB…kšôí­©J­Z²P„ µ”¤Þ‰%ÖÍŒl#g?C-ŸaøÄ ±\ZÑôÍü“×éÒKX®Õ¤|†ã%ÃMìLW<)ßÛÌÞìþoâ¼$ð£o7×±‘#	¿)P²ú\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0 #Iì\nT±l/1Â¶½kV_Ê‹ÞÀÙ„	‘µŒ<ç’¯pÚ÷¯(/LZöº×HþÕyQ\rÜ\\$á(¸¸½\Z|Óë8öØà\'˜Mè6äkÛÂ~½ª¦mbmßåóT\0\n“Tså*–Õr.#[v­9:ö.OÙÅû8x×5ÜßaŸ]¨X~!y…_PÄl+ÊÅ¼ÕJs‹Ñ¦‰_²Í­aYòÊws§iŒPKÂÐ—WO³‡jîæŽ¥²õ­FüéU?‡®:=±ðYr¬tULX®wÇ¶G7¢øj5O†¥í»Tm\'£Ñ|˜ÕvŸ#0f++áu±ŒfòöÔIñ“êIu¶ú…Ÿv–2»ýÔkÞÍ7JÎŒ“©7ÚþÖ=ïÉ©sæÑ3ÄUÞ+WÁÛRÕ[ÚÓK¤¿[íl¬ç»K‡Ê©›tLUw££Ûôã-v71·…ŽM;êèú¤~·mžãu#BX¬¬j·¢Wpp_ÅÚ½ŠP¸¡Z)Ô[Ñœdš’íMpd|QêòNÒóVD¸O	½•KG-jYÖnT¥Û¢ûÞŠÞ]·5ÅQN:ˆÓ¦Ÿ§ÓF¿Nº_Ý1ôM0x}œmS/gÛGjž•Ä)¤êÙÔ~¹wÃí£âåÖ{„ÓäÎ‡†ÅYÆZ‹Ö*Š©žxo­Ü¢í1]¬~éSþmxîÿ\0å’Ý*K-ëÛuÿ\0(ÑíoøEßáÿ\0t0³OD¯³ã\08ªž…{€š¡ª$TÕ NRPŠnO–€÷{«—imÅf*šž±´•Gë!qö\r¯:O©èe`ðþ7ˆ¢ÄÕò¦#Yá\Z½,ÛðµÅ\Zé«\'l[bËð9»6[7xÒ¤ãÂ’|§5öÝ‹«ÇË:h»Tâ’Z÷r.;¦Y–ØÊìE‹»žyæzeuÃáèÃQÈ \0ºÙò~\"^þü¯÷Ù~vOJœˆz´¼¸Oª¬ÿ\0;9Îßþ?ñêÐg¼(íù8@7W™W£u:5vZèÂ¤^WE8¦“ß§Ç‰(©ÛÐŠõ´)¥ÝE¾ÒÝÚ+ï°¬¾¢»úÎ½±:NYüSòZòFí•®ÚÞ^Ê…7ãŠ,•…Œ½••ã§æÕ\rWinšiž0Úîu¾eaŸèÛ_ÈÇä/……7­;*kíi¤so.Ò¤r)Ždi\nn®ÄTj†«´ûH\no.Ò¼È1æŒ(áñÅ1ë¿K[Jª¥¿ºß¯i´´^&y‡·mš.Xþ¿û3ù\níÇ	–/³L^4âåRÕBî9nI9?ÄÞ\"º”}£Ú<fOŠ¦Õšišf\"wÄôÌO<4Ù†awr(¦#I„¾ŽÝ6e.y/¯Ôwlö»³›É(QÍ¶JRäª7Î‘\rJ5©¢£nñÑ>uº\'¿êÂŒî÷=1ïO{+ËKûh]YÝQ¸¥>1©JjQ~&™ÏÀŒÝ3OÌì~ï-ÝÝÊ4/éoÐ§9zÕZšòn-øôD—Œ£º´kM’æ”æøHÄÄi;âc]t˜þµo0x˜ÅZ‹‘¸œc88Ê)¦´i­u<žcÙ†HÍ1—ÍLÝÔ’ÓÃQ‚ª»÷—?)ëŸkO\"õ1TtLjÈ®Ý7#JãXF<ûÑÛÀéTÄ²¥ÅLNÒ¹ÛÔZ\\AwiÂ~D¼F”%Nr§R.2‹jQkFšæOŠ­-<¤eé!–0L0ØâØl©Ò¸Åa9\\ÛÃí¢Ö•{·µk¿uœãj6fÆ\nÌã0›©Ž4ûwk¼Êöe—Qf‰½kwL1\0(¹9ûDº•j¶ÕaqBn)IN\\ã%ÉùÉÁ“qÅ™rÆ$µ½µ§ViuOM&¼’My8ùa~ì»u5×v²^/\r2÷°wª§vÏ4Ó¯lLGÎ[Ì’¹‹µQÍ§õñ{º‹—Lƒ]1òÄðm§ÑÌ¦Õ,rÆYKNµ/¥É~*¦ü¤è0_K¬‹,Õ³‰cV”K¼¿?M$—Eð¨¼‹Gä/ù½‰¿…«N1¿»ôÕŸaçƒª#ŒoŽÏÓTêáÈ/‹z·×ÛÞ\n+¸é¯wi4ºmJßË’Ùþ)v–%ƒBRµS—\ZÖÍýŽ¼Ü[Ñ®Æ»ÈZ},¹˜ql«Úfîv×¶UZU\"ú×SíO“]kS7‹œè¹9ýŒü·8ñw›„ÇSi©§Å4Ê˜b} ²¶Ô,!cu^ž˜)A*ÖUŠ®ŸgIò’îæ»:ÞZU þË‘{³~Þ\"ˆ¹nu‰tkíâh‹–§X•À¢”_\'©VôZžÏP6’Õ½Zijä´<vÓv©”öcKÌËÂË…µ¥7­k‰u(Ç³µ¾ø¹r›TÍuÎ‘‹—)µL×\\éîm>åÝàU3d½Tm©­!ñ©Z}P„zÛø“úLl—5Õ…¥<ÂðÛš%Nþ	jú”µÝøQv©µ|Íµl~x¶5_rÖž±³³§\'àèS}²í“âþÅ&×ó•kùýÏ­˜ŽO_:£ˆÚZâ÷öÄÑ<g¯©µº¨Ö£N­*Ð©	Å8Ê2MIv¦¹œŠQ|Fº6a·¬ù³\nÔèXâ¿Â”µ–u7*IkÇs®ÅÃµOegÊ[XÃc[¸ô½ýÍ…i%V—zûh÷¯€Ü`³[8Ï7…]Fï/Î,cüØójèŸ—K!ÔÓs‰¯Þ”™Vygl8µhCKlaC¢ôç¾´Ÿÿ\0$gçFÀ¤õZ.dré™gŒå<ëiCzãŸƒ®ÒÕº|ü’ÓÎÏ<ë7ð³1Æÿ\0WÆ{‡œF©§;þ¾ä.©’ç¯g²- VÙ¦}ÃsDTçmJ~\nòœ~Î„¸Mx×²]éÂ±;bÂ×Ãn£^ÖîœjÑ«ªœZÕqñ\Z¯3çGž‘³ÙïƒÊÂS¯—ç?¤Wã)YI¾<:á¯o2|Â0ÕM›³æÏºV<‹4§	TØ½>lðž‰úO¹9ÐÂqŒ\'°£Ša8…«Kˆ©Ò­F¢”&ŸZkÝU øoª&5…â\'XÖŠIðL9E-[ÓBEK*InI)-t):ôcNU%R1ŒV­Éè´í#NÞ:Pá¹~Úç(ìêö7˜¬“¥qˆRýÊ×©ªrå9÷®¼ÇÅb­a(åÜŸÕŠÆZÁ[ð—gH÷Ï±áú_íJ†?ÛìûºK\\n¥ô¡-c+4PüÁ÷·ØGê•jÖ©*µªJ¤æ÷¥)=[~2Ò…ŠÄUŠ»7jçs|f*¼mê¯WÏî€å¶¶©wqJÖŒ\\ªWœiÁ.{ÍèŽ#0t^ÙóÎûL´¾»·sÃ°ìûW	T‹úT<²Ñø¢Ï‹j¿r›Tñ™|álU‰½MªxÌ§JËÑËGËñŽŽÂÊiöê+{áÔúxÎmŒá¸EÜu¡{oRÞªþLââþw%«Ô¤Þ‘oS£EM<ˆàêQLE<ˆàÕv9„]eüjû¾ŽíÆqRÚ¢þT$ÓüÇDÎ½.ò4òÞÑ~y-èîÚf\n~´¸*ñõ³^6·_”ÁG;ÄÙœ=ê­O4¹~38[õÚži÷s{‚Ft@Ú¾]Çnv}Œ×Tí1™ª–U&ôŒ.Rã÷ipï]äs/¥Zµ\n¯B¬©Õ§%(J/G\'ªdáqanÅÚyŒ*¼êoQÍïŽvÖÔáÁo/9q\Z¶ÒsÌ”mržÐ/!gŒGJT/ª=ÚwirRc?õvJ5©I\'\Z‰©-S\\ší/¸lU¬]»sú:Nkn.Zcáí^|$ÑKWÜ<$5ÑKVd²×Všz9q]GÎÇ3.–pÊØÎ?‹[ØÙ[Çz¥jÒÝŠî]¯¹q>f¨¦5™DÌS\ZÏ.5‹á¸w‹â×”í¬í(Îµj³–Š1KVÍmí_>Üm\'=bY¦ª”(×©¹kN\\éÐ/7ÞÌƒ·î÷;L©,·–ü5®]¥Sz[Í©ÞI>’êZ•÷aœf1‹ª-[ü1ï•=Í)ÆU,Ï™ý3ô€\0iç¾Ø>Y–kÚÆ^Ãw7©ÓºWU»:^½þcd1ö+G¯+t-Ùì­¬±=£ßQÒwkÒ\r¯ñiëRkÆÔcø/´•+‚Hºdv&Î—<jßÙÌ¿lþ\Zla9uq«g7ÕWÈ‚Ý3~»´™íþ=Rt¾Déœ´ÚÝ¿~\roñêŒûÑ;aEèSí†\0µAªí\0«´j»Wœ\0Çw[ê\05ë×‘ôðµ˜sMý<3.`÷xÕY$©ÛÒsk½éÉw¾•è‡.½¾cÚti\\×¤ÕJ8]9©Óƒÿ\0Y$ô—‰=;Ù—…Á^ÆU¥¸ÝÓÌÍÁeØŒuZZÝ<ÐøÝöu^ö†Ó3mŒ¡oK×aVÕc£©/á¤º’êíçÔKÈ®:œt(FÚ£F”iÒ‚Ò1ŠIE%Á$ºŽbï‚ÂQƒµèíët\nÞÌZ·Û=2\0Æ`\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0’ãˆµ·ÍžO-cÒÌØm¿ö·›•MÕÂwÅ®äù¯))šÕh|ì{Ã³qƒb´kk¨8N/àk±®iš\\÷)§8ÂÍ™ÝTo¦z\'é<ìLn1v¦‰ãÌ‚IêTõÛHÙÆ/³ÜVTn#*Ø}y?JÝ¥ëf¾ÕöIu¯)ä\'‰Ã]Â]ªÍêtª8ÂrÝVªš+&9-®nlî!ui^¥\ZÔ¥½\n”äã(¾æ¹`ð‰šgX|Dé¾w)tŽÌø5(Zf+\ZXÅ¤¼&÷‚¬—F¥åKÆd[’Û?­MJâÛ¶–œc;xËO,dõ\"ç”hY0›Y™á)ärùQþ¨×ßÇÞØZÍ16£Muö¤æ)Òk$P¦Þ†b—•~Å:p§ãnM¯31¾iéœñØÊß¥C¡-V´žý]>íþ¤ŒVTùÆmViŒŽLÜäÇúcOz.æx›±§+Obû›‹›Êóº»¸©ZµG½9Ô“”¤ûÛ,\0®ÌÍS¬°&u\0;8^ˆcwô0¼.ÖwW2Ü¥NW\'ú—y4Ó5ÌSLk2DLÎôÛ\'Ë¸ždÏXm¾R­ÛÔWéÉÅÓ¥·¸ö¾]ïÆLÊi($¹dû6µÈ8¥UÂ®%y¥Kº±â“ê‚}ˆ÷ih´;>ËåeX=.þ:÷ÌttGÕoËp³…µçqê‘ÿ\0¥O,·ãºÿ\0”H?ô©ö9m÷Ýÿ\0Ê>¶³ü÷ðÿ\0º“4ôZû>0À@Š)ê2VlÓf9ï$à˜­æZ³¯uueJ­Zµbäå&¸¾$SdÖÙzÓgYsù¶ƒþ‚.û‡µˆÅ\\ð´ÅZSÏ\ZóÃs“QMw*åF»œ“ÙÎGœ<²¦×g€GÍÝòf7kR¦CæEâMÂt[tÛì”W‹‰•\nIjší:6#)Ábhš.Ú¦cÙÝ1¾˜k7#J©„ÌYwÊ¸Å|\Z¶ð7VïŠ×XÊ=R‹ë‹\\S>q\'zCdHãYsç¢Æ‚w˜D\\êî®2¡Î^=ßeç#Œã™îUVQŒ›<iôÏWéÁRÆág	vhææTBu)ÍT§\'A©E§Å4À4Ñ:0ÒÏc;G¥ž0(ÙÞÖ_5ðø¨\\A¾5#Ê5¯±øÌ•ª ÎSÌØ–OÇ­qì.«[yzèõTƒöQ}Í7)æŒ;7àVxîQJ•Ì5q×9®„»\Zg`Ù\\ö3;ôÿ\0kG¾:~¿ªÙ–c|bŽE_Š=ï²\0-­¢ÊœˆÂúçïÓøÌžu}‹—b f!ûþçïÓøÌç[øpÿ\0Åÿ\0«Ažp£·äà\0Ù^}¬£›±|•‹¬o•%r©Ê—Ó!¼·eÏ‡÷é´hý–õçýÿ\0Ù‹A°Ãf¸Üvi§Ž‘,‹x«Öc“n©ˆeEÒGhkœ0×þïÿ\0Ùzé)´Î†ÿ\0öí ?x3OßÕÞôñüO¯,´ºKgÕÎÏ\nû2ý¢åÒg=®x~ÿ\0ö§ûF#ýâÍ?QåO¯,¾ºNg…ÿ\0”àÏÿ\0j§í—.“ÙÛ^8.\nÿ\0öêþÙ‡?y3_ßÕîO”1^¼¦È³Ö+´,½qŒâ¶¶¶õi]JÝFÝIGEË_\\ß\'¼%©‡ú2?ÿ\0¡¯œ§ú8…r:îGzæ\'/³vìëTÆùZ°uÕrÅ5Õ:ÌÃ­eFþÆâÆâ\nT®)J”Óë‹Z4AìÑ\\åœÃ]E©ÚV•4ß\\uõ¯Êšdé|™…:AìÚ¦7gçƒÛ¹ÞÙSq¼§Æ­Ê^8ñòx&ØåUc°‘~ÔkU½gÛýÜ{Øy¶oÚåÓÆŸ‚7‰•9\Z¨¾ÞââÖ½;›ZÒ¥V””á8½%¹4Ì×‘úHÝØÂžl§wJ)E^Û¥áWÝÇ‚—5âf)§a—f¸¬®¾^\Z½:cš}°ÈÃâ®á§[rš¸Ô2a„e‡fKMé‹«?5ãRÐû\ZÂ<#Å-~ÛÃÇO>¤ÓŽº—ºµZÝuf×ceÂÖÞÞŠt»f&z¦cå?Úœò¸:z]ç=´dŒ­kSs†!{Õ;kV¦Üº·¤¸Ewþr,æÜÓŠg<r¾=‹M:µtQ‚~¶œ(.ä|}Þð–…w9ÚVs¥74¦ˆæŒôµø¼}Ì^ê·GB @ÁViÆ(¹N£QŠ\\Û|7²6\nòæSÂp9­*ZZS…]	¦³þ“dtØÏëæ\\ÇÇ}A¬7\n©½5ëj×\\cÛ§7ä%<`£Èê–ÕfÕxÚãñndqžÙø,¹6h¦oO?bã¯weFö•K{šq©Fµ7J¤$µR‹àÓîi€_f5nÚèÛÎÊn¶Wî,iR›Â/e*øu]8n7Æž½±oOŒÆÆÊö§³\\jbç.ã0Q›úe¥ÌW¯¶¬—	Åöu5Ö›5ñŸ¶˜vs˜keÜÃi*Ua¬¨ÔKÖW¥Õ8>µù™HÍ2ùÂ\\šè2}Ý_E9ÊêÁÜ›¶ãÌŸwWÑæÀ¥¤r[ÜÜYÜSº´¯RjRR…Jrq”_jk“3^Eém´œ©FŽ3|Ái’WMÂ²]Š¬xùÓ0€=ìâ.áç•j­|]ì%\\«5L&žÓcg—tb±Ü\ZÃ«õø(S¯M~ôeýëÜôÉØí:\rÒxÝy4ýe;¯ô¤—ÂA_0ÔØÆy‹ˆÓXîmiÚ<lF“¤ö~©;ž:kb—ÔêÙä,µK‚»¿š©WNØÓ­‹ñÊHŽ¹‹2ãÙ³«Œf<V½ýå^ukKV—b]K¹08ŒeüTëv­~\rn+ˆÆÏöÕkÝÀ\0ÅbWèÅ•qŒÍµ¬&¶sqko…Í^ÞW£&¾—*›}joH´ú›æc<Ä±ìNßÂ,ªÝ^]ÔT¨Ñ§e93`[Ù\r¶Ê2œ-.<Lbùª÷õ¢µ[ÝTâþÖ?ŸVm2¬X›ñWìÓ¾~ÎI€«ˆŠçðÓ¾gá£µÿ\0|Î–;…Øc˜]Î‰ÛÂ½¥í)P­J\\§	-\Z;å³‚šÓ‡˜¼ÌDÆŽƒ1\ZKZ›ZÙÅþËó¥î[ºß²›©e^K÷j\r½×¯j\\z<g>&Å¶Û±ü#jù^Xuy*¢u,/4ãNi.ØK“^&kû4e|o&ã·9w0ØÔµ½´žìá%ÍuJ/­5Å>ò™åõ`®kLy“Ãèç™¾YVï*˜ó\'‡WSå\0\r[PõyjYëgw*ã÷´Ü·§nÞýøàøÏ-tÝÅ­á\nY§%ÛÜÉp•{—I¾ýÉ&›ü$FeØÇb0Ñ¥ªæ#¾=ìÜ6eŠÂF–«:8Ç½4©tÝÙÇÖ®VÌj¯\\cNƒŽ¾7WõoéÃCvPËno•[û´’qÇñˆ¢ª³œeQ§+NÈfUŸãª9QÈ¹÷oÛMÚgm‹c²µ±›ãgd\Zzv=²^6c®½zß0\ruËµÞ«•ruž¶ªõû˜Š¹wj™ž°°„êN4éÂSœÚŒc«lóy¹--noî©XÙPk‹‰Æ*PZÊroD’]¯Ca[Ù?Ð»#ÛÙÜªo¿^˜Ä&¸é6¸SO²+‡StgèïS,ÊŽÎÖ‰br†õœÖ¾–M{9¯·k’êOµð“ZE\"Û’åÓf<=Øó§„t.ÙW8hñ‹ÑçOè¬ª¸$˜’ÕhT‘Žvã³}§d+ÌrÄ(/Láõ_ØWŠàµì’Ö/ÇÜk²úÊë\r¼¯‡ßP‹z’¥VœÖŽ2OFš6­VŸ„ŽîöädéIÑöxÚ©´\\›k½ˆS§®%gN<n#ñ±_n—ºÒ]Zþu—Íê|=¸ßzãôVóì²q4øÅ¨ó£\\~ˆzM=\Zi®¦\nŠq2FCé´íŸÓ§i†cŽòÊšÒ6—ÉÕ¦—bÕïGÈÌnKwk³W*Üé=Ok7îX«—j©‰êJì§#Ç%áãVÊ÷ƒü	Ç‡ã3í×éÃ’cOzÛ&cu*éìjNŒcçR˜†ÀØÓœã\"4å{¡´§?ÇS\Zr¢{!$³/MœÕ}	ÒÊùKÂõá\Z×esQw¤”b¼©˜;8m8çÛ¿Næ¼zæþiëNzS‡ÜÁp^cÏþ7ˆÝv¹Ÿ‡s˜bq{¯W3#º\0ŠÃ9-OQ³}Ÿã;JÍÖY[¦Ó­Q;ŠÍzÚ“[Ó—‰yÞ‹¬ù™c,ãyÃ\Z·ËùvÂ¥ÝíÌ÷c.]²o©.Ò}ì;bøVÊ2ß¥µ§qŒ]é;ë¸Ç›ê§µð½Y²Ërú±·7þã?&×)Ë+ÇÝÖcÌŽ3ò‡¸ÊÙsÊ¸–^Â(Æ•¥…Ñ¦´âÒë}íñòŸ]k¢ÔF;«B¥êšb˜ˆ‡D¦˜¦4ŽäAžšM­Ú÷àÖÿ\0¤ªNgÈƒ]4—÷Z´ïÁmÿ\0ITÓçÞ‰Û\r&Ñzûa\0-A:üÜ|äÂÀúä¬K°Än3v9\n—V´«N0T·båÚZÇ]8õþ£iÙj;™s\n‡ÚÙP_ühÞä˜[8ª«‹´ë¦‹Ï`ìbæç†§]4ù°¨w {nÌü°UtÈ	ñÍ¹¯ýBG‚Ãä¬îãÞ²ùû¸÷£Ý·B˜Ð’u±¬~á.©×¦µüX#Ó`Ý¶7ƒÍTùÛ•ô—o.\'Q7âàŒ¼º2ì%¬[‡­nßá·Ï—ƒå¬.Ú«<	³Ãè¯°·¥\Ziøô\\O¦–‰.Â ÌŠb˜Ò‘Li\0\0”€\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\ZMhÊ€>f?—ð¬Ç†ÕÂq{:w6Õ–’„úŸSO©®Ò4maîU•\\S/S«‰aIï5ëZ‚þTW²Kµ©¤ù¢›‘åº.o‘asŠ4»\ZU*Ž1õŽ¦&+k”jQmI4ÓÓF	œ¶9’³„ªW¹ÃÝäÿ\0Êm4„µï^Æ^Ta¼ÇÑ·7á’L\nöÛ¢¸¥û•];âõOÈÎi˜lŽaƒmÓË§¦ž=Ü{µWoåWío¦9QÕôb0}ÌS!ç<\Zn8ŽZÄ)nðmP”£ãÕp>$éV£-ÚÔåÙ(´þ·vÅÛ3¥Êf\'®4kê¢ª7U\Z(Œç%E¶ú’ÔúvW3brQÃðB»“ÓXÐ–ž}4\"‹UÝ(‰™êE4UWá‡Ì(dŒ`DÅå\\ØÒÃi>sº¨“_ƒ_Àel£ÑÓ)àÎ9‚â®3s®ì£àèE÷A=_•¿½Àì¾eŽÖù4ôÕ»ÝÇÜÍ³–â/~Î‘×¹òfÏ3Fz»T0[	ø$ªÝTN4i®ùu¾å«üäžÙ¶Ê°\rŸÛÊvñôÖ#V:V»œ}síŒWØÇ¸öVvVð³²´¥B5»\ntâ£»’9ÔRä´:6K³l¦bí^}Î™æöGÏŠÁƒËmá|éßWOÐŒ#tëz² vÄ0JŸÜò×Ý]ÿ\0Ê3ù‰¶å³¼ÇŸáƒC/Ó¡7c+‡[ÂÕPöjºk÷,Ðí5‹¸œ®í«4ÍUNšDqüPÂÌhªæ\ZªhftøÂ-ƒ\'zœö“üZÇßQ+êsÚOñk%ÔNMäÏ÷wJ¯â8ŸR{˜½“gf‹Mže¿æ»gÿ\0Æˆêú:m!“Xùn‘%²fu‚å,½QWV4mê¨½Vô “ÑøÑsØÌ»‚Ä\\«ni‰§ž4çmòŒ=Û7*›”Ìn}Ñçz4«Ñ\nÔÔéÔ‹„£%ª”_¼Ä1ÚnL«‘óeÖ ý)Qºö“kƒ¥\'Áy9y	¤Ò|à¶¿³š9ÿ\0.ºVÑ„1K=ggQ½|5§\'Ù%æz2³µ<æ¸MmGö”oŽ¾˜íøµù–Æmy¿Š8}üÔÿ\0´ä¾£P÷Õ?”·è´õÿ\0’ÑïPùNWäLÇ÷ÿ\0,ýÄz“ÜÇ~3.twÏ0<Êò½Ýgé,Z_KMð…t¸5ãKO1ñ¾€{Nÿ\0AÓ÷Ì>S’Ób;UÃ®è_ÚàÊ­êF­9+ˆp”^©óíFv[ƒÍ2ÜUš,WæÏ«;ãž;aï‡µ‰ÃÝ‹‘Dîê”µ‹mèËŽ½•JÕhS©^—‚©8)Nk\'ÍyÁÚâuWÞ²¯±k¹2ÿ\0÷ýÏß§ñ™<ªêÓK°Œ¿Gÿ\0ºõ¬ªá·P©RSŽíw£zý’Em2üV:›3†¢jäòµÓ¯F›8±rôQàé×M~LJƒ_`»O¡Ï§?¸¹ƒýgR¦Åv™OžX¯/¹”_ë9íY>aOÿ\0,ý\ZÂ_Ž4Ot¼H=„¶?´¸óÊÏÄ“ýed»I_æv!ø‹å<ç,ÆÇù5,ý>-{Ôžéy zÏ¡6Ò=§â?ˆ¾R«d›Iæ~!ø‹å#É¸ÏÝUü³ô<Z÷©=Òò@õëd;KkU”/—Ž+å9#±½¥ËžTº^=ÕúÏ¨Êñ³ÂÍ_Ë?CÅ¯z“Ý/s\rˆm6£á–ª¯H¯Öv©liõòZQû»ªkCîœ›0«…Šÿ\0–~¨ÁßŸØžéeŽŒ¿Þ=ïóœÿ\0G1çb¹/ÈÙbç\nÇáJo%^*E5ºáÍuðfEŽº-NËÚ®Æ]fÝØÒ¨ñ<VÜ5Q‡¦š£IÑWÇÇRÜkMuàÓë9IðfÙ”ZØMhÕ¯™2=®üfÝJø|zåMuýÏ>ÎÃÔ¥VIR­NPœ’Œ–>ôO­Øö/:ì£&çVêâ8€¼k…Ý³P©¯¥åE;ØÚq5MüÅ5O\Zy§ÙÑìáìi1™L\\™®ÎéèæCpeìÇÑ³6áÓ\\úÛ¡ÍFOÁUKÄø?#òÙæxÁäã–1i×\Z.kÏƒŠÉñø9Òõª£³Xïa£¹„¿gñÓ/>Z¶7ÖòÝ¯i^›\\Ôé´qÆ•Zv9Éö(¶k¦™‰ÒXúL(¥e•ó.#%®åÁ8[Í¯>š|\'±Àö´\\jQðØl0Úoœîênè¾å&þ/—bñS¥›uUì‰zÑ‡»wuÌö1Þ¯©3 lÓdXî|º…Ýzs³Áé´êÜÎ::ŸÉ¦Ÿ7ßÉxø‡&ôxÊØéÝæ\n³ÆnâÔ’œ7(E÷CVåã“ò#,Ð·¡oJhQ…:pŠŒaé®Ä‹¶O±UÍQw1Ý¬qŸlý;Ûœ&O:ò¯÷}]Ã2æmƒá6ñ¡kmÈA/;}ïž§Ò)¢ì*tŠ(¦Ý1E1¤BÁLE1¤\0í+\\mêøžWh{4Ê»KÀ¥‚ækV1nt+­Je	u~gÖzÁ¢ì>+·MÊfšãX—ÍtSr™¢¸Ö%¯¬tqÎ»6­S³¡<gr{—–ÐnT–¼ªÃš}ëUâäb^ONÎf×*Ò¥88Î\nQkFš×UØblýÑ¯eùéÔº«…KÄ*jý7‡µßl¡¦ì¼Ú÷•¬^C¾jÃÏdýU\\nÍë<¬,öOÊ~½í~Cæ®…ùï\r©R¦UÇ0ìf‚ãTÖÞ¶=cæ—ÆXÎÃv³€ÊJÿ\0\"ân1û:4ü,_‰ÇSGw‰³øè•zö[‹±>}¹î×àð ú—W3Ú7¼¹ŠQkª¥¥Hÿ\0UTòþ;UîÒÁq	·Õi¿ÌŒ~MQ»F\'ƒ¯¢]\0zœ;e»FÅåáù#\ZªåÉ»9Å?+H÷Ùs¢f×qÉAßaö˜=såu¼—ÜGV{[Âß»ø(™ìdZÀâowDÏcxSögœ¶‰ÃÊØ=[…¼•[™-Ú#öÓŸ$»–¯¸•™¡®GÀw/3†%sÝÇ‚Œ|²îÝMÊ^V“ì3Þàø\rŒ0ì·±¶¥Â¨ÓPŠò#q…Èn×<¬DéÇèÞàönåsbgHèŽ?O‹ì_`odôôåG«Ov­ô£¢¦Ÿ8S_b»ù³-n-SÕð+»4ÓRÑfÅ¼=E¸Òë-á¨‹v£H€\0{=VÊ“Õóäcí¬ìk*í[ô®/AP¿¡-/éÅxZO±¿²Ž¿büš£„_;¶¨½LÑ\\kø»j‹ÔM»‘¬K\\NØŽyÙmäãŒaòºÃ¤ô¡ˆÛEÎŒ×V÷\\%Ú¥§v¦?êàÍ­\\ÙÚ^P­Ý­*ôj-ÙÓ©(Év4ø3g®‰»6Í¾óÆ^¾ŸûT¥FR}r¥.ŠÑXÅä5Ó3VuŽ‰úªXÝšª&jÂÎî‰úýPXß2t9Ú†9Ï¸Ã±ªØºU|ôïŒÒZø›<\'±¬a2q»Èx²Ó®Qyã©¥¹ƒÄZ+¢{š¹~*Ìùöç¹áÁèžÎsú–ãÉxâ~à«û\'zÃcÛQÄæ¡g‘1™¶ôõÖÒ‡ÆÐò‹7&tŠg¹ã{Ó:EÝ/Ñ—º$í”ey‡Za4¥Îw—Uø0M™›$t1É¸;…ÞtÆ®qËˆé/ExuÜùÊ^uâ3leX«óº#¯wêÎÃä¸ÜDþLtÎï×Ü‰ÙG\"æÜù‰C\nÊx%ÅýyÉ&â´„;å7ëb»Ûò/b=2öÏçKÍ£‹côÒ”4ZÐµ—òç%öÏÉ¡˜rþZÀ2Íœ0Ìµ°¶‚áJ…5åÓŸ”úÑ„aìb–¥“ZÃLWsÎ«ÝN]‘YÁÌ\\¹çUîd|ÖÆ”bšZñ/K@\rËz\0	ÙÓŒÚr×‡ap8íÏ¢µ†m­q™¶}\n8Äõ«^Íé\n7Rëiò„Ÿ™¾zs!î9€cyk«…cø]Í…å\'¤è×†ì—ê~4Ú6žâŸ4yŒç³ÜŸl¥ašp+kè-Tg8éRŸ|f¸£EŽÉmß™¹gÍ«Ý?E1ÈmâænYžM^éú5Ž	YºïÔ©y³ìÍ¹\r7•ž$µkº5b¾)‡±þŽ;bËó’­“ëÝÂ÷[9ªÑk·Öñ+—²ìM‰ó¨žÍê­ü§‡Ÿ:‰˜éñîc@}»¬œìdá{”±Š-}µ•]<û§ZžXÌµe¹G/âu%ÙJù”LNEQºa…6«Ž1/ša„ìƒiØÔã?\"ã7ºçk(%å–†FÊý6£Ê1ª–%»ç*Õ|-M;¡\rV¾6kX<EïÁDÏc\"Ö_Š¿:[·3ØÁ,È{1ØfzÚ…ä`ìðÅ/¦â71q£Ù¹Ë¹yZ%fÏú\'ì×(Næ-J¶a¾ƒOÂ^%\Z*_É¤¸~3‘šíìí-hÂÞÚÚ*TÖì!¨Æ+±%ÈÝá2\n¦b¬LéõX0[7TÌUŠžÈùÏÓ½à¶O±¼£²Ì5Ú`ö®µýX¯LâRuj¾Åö±î_	iÓ4ÔuãÚÊ¨ÅrI,Ö­Qf˜¢ˆÒ!kµj‹4EãH€\0z=És¦šþë6/·¡újÄâ—&EN“{ÚÑvi‹eL]ÚÒÂhÛÊ£­%5V«k×>ÆFun»¸nM¬ë\ZlöÕËØ9¦ÜLÎ±ÁÁš-ú\"í¢ºNxE…~Þþ›ÓÌ};^†;U¯Âµîo÷w3,ªF_ŠŸòç¹M§+ÆÕÂÔ÷0\'3jx$w0[}­­%ýCªóËý÷›°*z>*š­&üðDÌ³£é{J7“ðtã\rRÓ]…‡#Â^ÃMsv5Óæ³ìþ\nþÂMút×M=î`aY\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0i5£I£Š¥¥E¤íiIwÁ3˜1ÄuéXÙRÕS³£4ŽxÂ1ZF)x‘PDSð4Ð\Z  \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\r\'Á€·¡/eB›ñÅV¶ËŠ·¥øˆårc ÒŒ!Š^$T@\0\0\0\0\0\0\0\0\0EØ\0ÙR¥?eNÆ‘j¡Ar£Mx¢Ž@F¢\\\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0D\0\0\0\0\0\0\0\0\0\0\0\0\0”!/eühµQ¤žª”û”^\0 \0\0\0\0\0\0\0\0\0¢\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0£j)Éò\\@â¼mPn:ê»µÿ\0¿!±?D¯`˜3ˆ`Õp\\ç{+š¶®æÒÎÖtk8MÇ~œÂn2ÓTô\\ù?¥ÎÖhl¯a“µ¹tñ+Ë™øsM§áëzÕ(µÇXÅ¹päÒ4Á¯ßœˆÞžfã¶Òûf]\"3!—²E®=a}†ÚFòT±ZixZ{Û­ÓTêÏV¥*zë¦›ÈÏÉÆ„bÖškÃ]xkÀÒ_F=¦TÙ6Û²Ænuœ-Ò³¾ã¢•µoY={’zþ	»+\n´ëÙÒ­F[ÔêGz2×Ù\'ÉùyŽs™Îz-_QÃªj1–º½<½`QÎ1Z¶R!Qkª$\\\'VÚR×WËrœdµOTÀ¨8½5G}C{×=xiÿ\0}§$çEÊOD€¨8ý1I·-Zêí*êÁ=5Õö.dÁÅ;ª0ç.¦ùÆq’Þ‹àÉ‰\\ÒrÝMëÏ“ÿ\0¾¢±¯NRÜ‹møˆKN¬)¤æôMéÈ¥;ŠU^—À‡ 8¥uB2psÑ®}Ç$\'ÅN/ƒâ€¨8Õx7§zqEú *\nj†¨‘PpÕ»¡F[µ\'£}Ç,Z”T—&µ T~˜¥®Ž\\ÄëÒ¦µ“~`9Äîh¥¼å¢\\õê.…XM7ø=¨Ák«Ú×—>âÇsE6œž«N 9AIN1Z·Á+ŠMj¦5€âÍ*m)K‹Zò/„ã5¬^¨€\rèµ$Äî¨&£á­é§`w4’Þm¥â xí´g+íìÇ1ç¬6Î•ÕÎ‡V½§F³jœåªRÓŽž.$\0ÿ\0Å#iM§ô3Ë_—¸×Ï½ÿ\0z“{¥hUèí´5õŽršk—¬4”‚y›ÚØÞr½ÚÊò¶xÄmhÛ]c˜eÚ´¨¶á	N:µxéã=‘‹z-ƒ®Îÿ\0ôý§Ä2‹i&ß%ÄA*ƒ‰ÝPŠNSÑ7¢×†¯°+š2z)jø¯œÂ ãuéÇƒoÌ]	Æ¤w õ\\‰\0\0\0[:‘¦·¥®ž *ç´¥$›â“gÎÇ+dÌ2¶9›s„aÔc¬î/.#Nšñ·Ï³N-½41·Iî‘ù_£æMùµ{J7øÝî´p¼5MBU§¦®rm=)Ç†¯GÔ´f¥v«¶M í›0TÌ9÷«yRS”¨ÛA¸Û[\'ö4éë¤W7ÖÙSÁ°üóè”ìC-\\Ô²ÊXn9šjSõ¾km.ÝÙUjÐÓ°ñQôTòÿ\0†õûÄÕ>ZüÚƒzx¼Á©òÞPÍYÆïÒS.â8½ÂÓz´ê¸ëË]Ôôòžòã¢×H{[šuöC˜ãm¦»Ê×W§Ü§¯ÀF–Á6èŠl:\\RÃólS)\\ÕqŽö\'AT¶mõxZ[Ú.ùÆ)w/ã¸.;aOÁ1kKû\ZðS§qo^5iÍ>MJ-¦»4àhcÁ1œ¿{<3Â¯0ë¸q•ª¥Q.ÝÙ$Ì±.‘JØF9OÊ´ªaóž·xMÌœ­nc¯®N?c.ÉGŠø	Óœênö2Œ½Œ“ñ2¦8ØØrÞÜ¶yiŸrÝ¥Å;™ºw6•ý•½x¥¿MKD¥Õ%Íu.K#„\0âÍ\ZzïKM9ðä=3Gw{€ âôÍ5sKÆ]\n°¨Ú‹ä¼ŽuéÓ–ìÛ^NŽ@q«ŠRÓGÏ—éŠZé«ç§\" 8Íµrà]\n°œœ\"øÇš$Y^+yI§Ç‡k«õ;mþˆ~ÙVÖ36Ï0Ü€^[`W®Özõ«*“[©êÔe§_Q<+Ô„e·ÇTü†—ºa=zMm\r®¼^Oú#<Í…ô;éAšºJÒÍ—þ[Ã0——åg\ZJÊU%á|:¬ÞöûziàW.ÓÔt émÑëgÑÍ\rWøíug‡[I¸ButoYµÊ1ŠÕéÅõpâGBšj~Óuæêá\Z~-á—:slG6m£evÑÊ4UÎ)—¯#JÊ-o]AÁÆq‡z‹M-xµ.â‹YOÑ+Û®c£qœpœÁgSJöÖ¶ò¡Vo‹„ÔŸ¹\'ÁèlÃ&ãøvjËÖ9“®ëYbvÔ®­æþÊŽò~>?¥œ¥ÑÏmYÏ3QÊØfÎ±Ê7U*ªu*]ÙT¡FŠÞÑÊSšQÑq×Q¹}–e\nygøJ¥qáÖ‡Ð³u~ÝÂ:6»µ×Bws#™êÁlêÂ\r)½5à»Ùc¹££šO]	C”:Ôã«ràºË=9oÇ×òî#T¹Ä®i>Mù‹©Õ§Z;ÔåªíD¡xëÒ†»ÒÓMz»\0ä\Z¯JQßSN=¢W ôrâú´ rÈV§7»Ç™y \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0Y[…)½ZáÔô/>.dÌ¶9g\0Ä³-R¬ðëJ·U§)i¤!\'âåÌ‰K\\¾‰žÕÖ5ðM“á·:ÛàËÄcþUY?	wÆ“Ráü7qv)±ìÃ¶üáW\'åÇW£†^b©%¬cà©IÂ/³~§ƒ§¯Vþ½GÆÚVu¿Ú6}Ç³Æ\'9J¾3}Véï?cýl|J:/!?½Ý–üÆÈ¸ÎÔ¯íR¸Ì7\nÂÎR\\}-F^¾KUÊSmpûWØ8ByÚß©J¥\Z²¥V…Jrq”ZÑÅ®\r>Æn?¡Ž×©íW`Y{º®êâØ<\r‰¹KYJâŽŠ3mós§*S×¶R]F¹:jlÆ[1Ûæ;oooàðüuüÙ³Ó–íVü\"O¯JŠiøŒ£èjmCçwi˜®Ío®w-3M¯†¶R|Ýä´]®~a<5:›BMT§¼¹J:¢%ôÏÛÆÙº<,½™²Ž_»À1G;K—ˆYU«RÞî>ºº5cëg-œ9ñâKXèà´äÑŠzLl–Ž×ö1™2„ix[é[JëÕjãuO×SÓ¯‹Žïá0ˆCí…ú\"{IÎ[TÀ2–Ól²Í®ŒÜ«)ÜXÚU¡Vjœ)KzUd’ßÝOUÁ=z‡Ú9k5-5Zj×_f€g‹+™BJT«Ð©£ê”\'ð4Ñº®ŠÛV†Ø¶1fêµãST#i‰iÏÓT–ìäûå¢—ás™’±ìVÇ±¹ÅñKˆÛYXÛT¹¹¯\'¤iÑ‚Þœ›ìIjk\'ôMöã^ùeì)ÒÂý5WÒ4î°ú³­}÷àã9F´S’Ž‰´—\"Kz#{ZùÂØí<›‡ÜîbyÊ«´I=%ZzJ´¼\\cÃ5—³l‹m/>à9§½wßR´‹ÑµN2—¯©-8îÂ\nRo²,uM¶tNÚ6Ó6µ³\Z;BÚe¶i[ºœ°ú8}¬èGÒ«H©ÉJrrnJmv-‘ö•µL›²Ü£yœsÆ#é.×HÊZkR¤ø5Nû)>KO«šúÙS(a7,a™c§à¬p«Jv´#º—­„RÕè¹½5~3T]9vï}µ­®_e¼6î_;YJ´ðë*q“q¯^v­ÃêzÉ8Åý¬SæÙ\ZJw=ÆÔ=­§ãWõmöW…Ùe¬=Iî\\ÜÑÕÝEÔÚ—Ò×§>óØtþéQi{Nîëhv×ð¦Óô½Æe\Zrî~\n”%æhÇû\nØ|éšž[É–ô©Ñ¶Š«ˆb/vÞÎ“zoIó”ŸTc«}É6¦m§¡q“(_mC\Z–\'£Ò­;JP¢Þœ>–÷šü~îòwŽSôIcló0PÌXEž¬0Ú×E¦U±¼¹ŒuŒ\\·¢Û×H¹4ôÓ^HÅ°ôMºDB*ÁòJIh’Âë­?ùÌmÒ;¢Ž}èëFã¹·Æ²õì÷-1{XJ1Þæ©Õƒ×ÁÏN:k$ú¤ôza5ÈB%¼Ýæ,W<ì·*g,gÒÑ½Æð›kûˆP¥¹J5*CzJ1Õèµ}¬=3ºZíK£Þ~Á²îH³Ë×·Øb»©óFÎ¥YF¦û­q«‹‘!z4}`vyÿ\0§,?Dˆ#è¢}w2ÏóüÙ>þÈ}<å‹fÉÃlÔòíŽ\\·±¸¸sÃ0úÑ¹©^1ú]8oU’ÖMéË–º´µgÚo¢M¶Áˆ×£³[\\?+aŠOÀÔ«mË©GWÆ^Jšñn=9&D¼;\r¾Æ1l+µ©swwV4hQ§eRrz(¥ÚÛ\'†Îý;{ÌµNÿ\0iYþòÏ¸ ªzK£NÒm&£R¤ÔM5Z¸Å.k^²w&w+ú!%ðLN¸æfÃ³²k~Ò÷\n¶¥—ÚÊ„)¸¾þ>#`ýzRd¾Ùn¥ÆEaØöóK©U:”SåR†ý7Ç×.Mhôá®®zGt{Ìó,¹‰âÄðûú>™Ã±Q•/\rO]\Z”±œ_5«\\SLô=óf\'•úHek|>´£K«<*ê\nZ)Ò©øø¥Éw¤ÇYím¤wÇv]±¼Õ´¶­\'‰`vq¸¶Õ\'R›–ü#¤’iµ£|š|y£_øœt‰ÿ\0DdŸøeúæÊ6¥³¬3jû>ÆöyŒ_]YÙã¶êÚµ{mß½käÖ¾·­N§¡e²8AËè‹›ø{›þà†ÿ\0Äã¤Oú#$ÿ\0Ã+ÿ\0×)ÿ\0‰ÇHŸôFIÿ\0†Wÿ\0®|î—öIÑÃÂ­p<åb™¨çFÒêt7)ÛEµ*³P¦žšéÇ‹ÞûVGí›ä,{jçÈYjÙÕ¿Æn¡ovœ9Î¬´åAJR}J,“FÎúí«mÝ 0ü_;mÃ/ØàÏÒxr°±«F­ÕÂÑÔžôªËZp[±kO])vÀ’8ÞkÁ2žuæ+ú8~AÖ¹¹­QFéÇÙIõðó½VšŸ#eû6Àög‘pŒ‘€ÁS´ÂmãB-%­I­\\ªIý´¤Ûñ¶@¯D£n7w™²žÃpÉÂË\r§JóÝ–ž\ZâqR¥Iö¨ÁÂ^9¥ö\'Îôîv6Íè—ã•1Œ#b8­­œfâ±lJ†ýZÜ4Þ….\n+­oïw£C§¿J¸Wð¯it¥í]/˜˜|bû›-<¦\"Ù¾Íó~Ö3}–IÉLïñKé=Ø\'»\np\\eRr|#¸¶þBse_Bç/GSÎÛKÄåŠJ+z8m´)Ð§6¹\'QJUí[º“¤AÅ×ØW¢CNöŽ\\Ûng‡ªÒÝ¥að”hÂmÿ\0Ž¥«q†¼Ü^œøÎ§¢eÒ…j´èáy*PŒä¢Þ[–½ÕÏ?Ò; æyØn<çƒbk2åšM+«ˆ[ºUì[i\'V	É8qK~/›â‘×!™ns¢^×s^Üö9eŸ³>–!s}sk8XÑ•:[´æÒÒ2”Ÿ-:ß|GŽé·Ò>ôwËùo\ZÈ”0ŠÕ±‹Úô+¬BÚucÂ\nIÁFqÝzÉœ~‡?ø1á_Ïÿ\0¤1Ç¢©ýãäoçK¿ÑDˆâžv:Ù¿¢MµŒ_=àxnÐ¨äû·qybw4pêñ+²”_†—#ñ›dôK³Ž!ˆ×Ã61ƒÚáX})Ê0Äñ\n*½ÍUÕ(Ó–°‚û¥-zô!ðDÔØ/¡Í‰ç¼³c›v¡™î°\ZX¥(Ü[a¶Tc+˜R—±•YÍ8ÂMh÷4|\ZÕ©k3§:!p¿D¥6}Jîï>ÙâT©ËWmq‚ÙBœ–¼StiBz>é\"qtUé­–öõ¿•qÜ6.m·¤ëzV3Ö…Ý4½|èÉñÖ<Ü¸­RmAŽ•}±ŽŽ“Ãñ»jXÖ[Åj»zW3¥¹ZÞ¾ŽJD½kÖ)µ%¦»²à´1.ÉóeöFÚ^YÍxuIÆ®‰ÛÕ{G(o¥8ùbÚòŽ´õ7»J¢«MTQk^§ÍKi;SÊ)ÊwùÇ:ß«2Å8ÊoG*µ±§N?e&øh¾SÒZÜÅÛÓpZ§É/%ð£R];6å}µm°ßå«+©,½”®*XZPŒ½dî\"÷kVk­¹\'ÝñÐöÛRôJv_ÖµÙ^e–ðÕ&©\\ÜÑWWsIð–’ú\\5ZzÕË™°ÞŸ½)¬.¡qs´\\B”\ZnÞç±Tç£×GàéF^U$ûÌ°Ý‚ç­¿f·–²m½*tíâª__Üê­í)·¢si6ÛÓ„RÕ¿+S6ßÐ¹ÉPÁå½¨ãuqD¸V¥gJ5ï¦÷¥ÛÃ_ÌFèN÷žŸOœk;Ïh8E,1ßàuèÙV¶rvwsÝzA\'ÆœßRz§Ë^DFnéÑG>ôu½£w‰Õ§ŒeËêž\nÓ·¤áþ/ÁÕƒoÁM¤ÚZ´Öº6ÓK	\"cNdKw=¿Á×gú~Óâã¥F5hÆ„[”§$’K›zòIi¯ë¢×ø:ìïÿ\0OÚ|B-ú#=\"¯rÍ\ZÉ×“¡yŠÛ+¼vâœ´•;y6©[ÅëªsÒR’Ó„\\t~¹è9Ýý¾ú#ys)bW9kc¸]¶c¼·¨éÕÅ.§?I)®\ZAE§Y\'¯Ô_Sk‰ñŸÝ)ï.ª\\ZíÛ§96­íð[)S‚}KÂÒœ´ñ¶a\\‹‘sNÒsMŽLÉ˜MLGÄgàèÑƒI.ÙJO„b—\'Á\"tdÏB÷ùŸŸö—<NTÔ§K¡Ð¥?µSª›¨—;°×³˜Ý	ÞÅÙÑ&Û~^»§óiƒæ»\'$êoÚBÒ¾ŸÉ•$ ¿¨ž›é1³­¼àU.òÝJX¶Žó\n¹j76ûÏDô××C²K‡â5ýÒ3 NuØ¾_:å|n£/Ú·+´¨:Wv”øzùÃV§x7Ã‡\rj>ì×hÙ£e9Ó\rÏ9?¦#‡OU§±«NKIÒšû(J-¦»õZ4˜Ó ö·Ç	©ÁN<Ÿ\\x­“í#Ú–Ïp<õ‚ÅFÛ´§_Áë«¥7ª•7ßFKÌ{Q€êâUhÛÚNêâq*	Õœ¤ôQŠZ¶üHí×¤ž7_.l#<ã6¯J´0[•voAÃúÂHjG¤¾Øñ=·ís\ZÍ×5¥ó:•iYa45{´léÉÆ)OÙËùS}Ç²èÑbï¤6g­ˆãµ+Ùe\Zqôõz|\'uSƒô½\'ÔôiÊ\\wT£×$Gž/‹|ÍÌt4È¸vQèé“©ÛPT«â6K¹’âçV¬œ·Ÿà´»‡Üu²NIÙ®OÙî_¶Ëy+°ÁðÛt·hÚÛÆODœ§%Æri-e-[ëlôrµ”âÔ¦¸­5Ó«ÇÏá9á(G’Z\Z´ý‹l÷kY~¦Ÿ²åž\'o$Õ:²§»qo\'ötªû(K–­>:hõ\\M…ú×T¶¿élS3S¯³ê[·ªª¡}S^.ÚQ\\¥ËY®¦´Ñ›œHî¾Gmc¤g4·wy‘§Bué|¬•ð<™—ìòÆZÂèa¸fJ4m­hÇHR‚\\»[íoVÞ­êÛgÐ¾Ä­ðøN­Ìá\ntâç9Îj*1Zo6ß’kVÎIKÀ5ñÕ$µë~?l€žˆÿ\0HÜGº£°Ü¡{:¹µ…Ö=sJN2t§ÆªìÕ-ùv©Av“ÕãÅôöñè‘àys»Àv1…PÇn)JP–-z¤­#5ÃétõR¨¸sÖ)÷‘«éùÒ¦öæUèíÞÊNJÅÂ=ËÂQ”´ñ¶aŸìû6m?5YdÜ—…Îÿ\0¾–‚{±§ì§9>„W\'Á\"tå/BëŽg½¦_ÔÄååO	·„(S“æ”ªÆR’]­G^Ä\'HNö-Ù÷¢K¶Œ¿wBîÇ\nÍJITš·¥Öï^’¥¤<Ž$÷ØOI-œmçž-“ïeú\n>Ã.cuo\'ËXëÆ-ðS^µ¾ÇÀ×Hî‚¹ÓbXLë—±u™rÝ¾žœŸð76Z½¥Ú>K}hõ×X¥¤žÙfÓsNÈs¶žrô¨^ÙM©Áñ…Åp©J¤~Ê2Z­<MqHiÏ½-îRªªÅÉu=9êC›]-v¡Ñ÷h¸&[ÈöX\r{LC	õWˆZT«5SÃN\ZFP©\r#¤<Ù*6až°¦dL=à’nÓ\Zµ§uIë*m¯]ßªò\ZíôS~¼™[ÿ\0NGÿ\0ÌÖ¼é}í‹ú#y³Í—l¯.á™rÏ¸¹×°­Š·ÝðT©§VI¹6øi§6ôIµã6—è’í0_U¡³{l?+a±—ÒªÊÖÕÜÒå½*‰Ávè¡ådKÃ°ûÜ^þÛÃmj\\ÝÝÕ…\ni­eR¤šQŠ]m·¡;öuècP½Ë´/v™žïlq{šJ§¤ðÊ0pµ“ZîNußisÓwGÃŠÒMºÊþˆgIl§wŽfl;1ZÅúûKÜ*ÞŒdºô•SiéÖõñ3`}:NeÙzâï	·væ,G	”ÓõJ¤^‹z›|7´àø>£X#ú<f>ŽÙÆ†^Åoéâxv#CÓ8~!Nœ©ª±OIÂQ|c8¾}M8µÏE÷zç,G\'t”Ê>’­8ÐÆ®%„]ÓOHÔ¥Yh”»wf¡/PëƒªSÓ¦ïHœùÑ÷ËÞDµÁêÖÅîë[\\,FÞu’„!¼·w\'¸¾Þ¤jÛhyë\ZÚfuÅ³æb§kK¯é‹˜ÛAÂ’žê^µ6Ú\\6ÍÁtŠèÕ•zH`ø6š1ì[§ƒÝT¸¥+¬œâ¢ÓßŒ¸.ãRÛsÙþ²½®fža·7vxóµ£^çwÂÔŠŠzËu%¯¤!A°Ž“[EèïO\Z¥‘-0JñÇeo;•‰ZÎ®ì¨ïî88Tƒ‹úlüäìÌ=\'¶“‡t0ÀzAÐ´À^cÅ.Ý\nÔegSÒŠš­GES{ØÒÙu²+t0è©”:K[æÚÙ«1ã[ËÕ,aAaþéŠº®å½¿rð1ÓM9²Kt»ÙŽ±®„V›4Àñ»ë·‹½ß?	qZ«ÞÝIpu\ZZ.I	L0¢MÒ\nêúÚÞ®“Tj×„[Ž]5«Ó‡Óôëì6ƒ„ÜIáÖ×uôr¹£N£Ñ½qO†ºõË‘¡,#êµ—ºiüdo£i`8ssÜJÖž¯^_KK_„Nä<¦Ø¶Ñ’6)•«fìñ+kx­Ê)´ëÝTã¥:q×W\'ÛÔ¸½\rzm\'Ñ\'Û.`¿=ZØe\\>2~\nS£»—ß\'WXy7‹ú\\íÇÛfÖñKª7SùÞÁkÔÃðz\n^³ÁBN.¶ŸmQ§-yèÒê>.Àú:gîy†¦•hÒ´Ã¬Úx†+r¥é{dùG‡Ô}P\\úÚZµrž¨{œ+ÑéM‡ÞFæ÷>Yâ”Ó[Ô.°[8Âk±º4¡=?ÏøG¢KKÙ~`ÞegÛ8×Ã•XÎµõU8)%£RŒ·wšŒžœ4Õò}ú^…žIùŽéÖÚŽ;,QÇ…hÙÒ¾÷g‚~¿OÃ\"?HŽŒç£Î+Ec5ib¸ôÜlq{x8Â£\\w*AêéÏN;­¾›ÑèÝ$nd÷è˜t…ŸþQ’—:a•¸ø×‡Ó³¬…Š^cÙ;Çïü¦q<>Þî²¦šŠœé©=ÔÛÑqähQÞÙlå™eMÔŸö–ËŸÞ\"Lî”s>þ)ŒØ`ÖÕïq\Zôè[ZÒ•zõªMF©Åjå&ø$‘váè–Zá¸¥Î±,ÛTå¹,cƒðSÓø*qÒR]ò’îGšôFúDâø†g–Ã²Î!;|:Æ«ÊŒÚw5d·¡F_ÉŒZ“]nK^Ze»+Î;bÍÖÙ3$áêâúã×Ô©R[´­é&·ªT–v+^Æß$›Ôû^ã§ÇJªÕJ;I£mõT©à–+»YÑ”´ñ³ßìçÑ,ÚÞuF†Ñp|32Xï/	Z…/IÝiÖõ§¥9p×ƒŠFPËÞ…¦U†–kÚ†/[”5ÞÃìéÒ¡	?äÔÞœ’ü;ô‘è[ž6aóÙaˆG1åW%\n·´èºU¬äÚIV§«õ­´”âÜui=ÝV±¸ÞÙ–Åvï³½·e×˜ò)é‡Ov–3ÒVµ:£Rž¼5\\¤½l´z6ÓK%P®«ÅÉ-4áÏ]|]Æ¶¶,Ã°í¡aùßœ§NŒãNþÑKHÝÚ¶·é>­ZäôàÒfì²faÂ3vXÃ3Vv®pÜbÒõ¥T´Þ¥R\nQmu=ø§ª\'‚l\0J\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0 z\"»XŽHØÊÉ}Îæ\'œ®}&÷fÔágI©Ö–‹ªMÆŸ\rTzq‰/õ]¨Óÿ\0O¨­£íó°³¹UpÜ­ƒÛhýnüušÿ\0Ür_ƒÙ¡½0Ž±QrJME7Åö=Ù¯MîŠ;5ÈØBÂ±¼vvX…+8Oæ=HøGé*/²›ÖO¾LÖ=;»¤Ýµ­jÊ<÷ å§˜åù“Šÿ\0£.ÿ\0#/‘.úqmó`|ËX\röBÄq)f\\\nêTâ®0ùÒ…[:±úd\\Ÿ\\g\Zn:õ9ö‘W!çWgÙÏÎø$’¾Àï©^ÑRovnMÂZ}Œ–±}ÍŸ;æN+þŒ»üŒ¾C­R•JStêÓ”\'q’Ñ¯ 5oŸ(fì;:åœ\'6àW®‹ÙÑ½·“ÓW\nÞIéÖµÑ®iÅŸ~·îRãÕÛ¡\r}\r­§¬Õ²‹¼ƒ{q¿{”nô¤›Z«ZíÊÿ\0”§ÒeWýÊ\\ü„A-AôðÙv_·LGÃm]7k‹Ú¥Êy?ìŠ}ßLnI.\n5\"ºŒ“èhm‘eœñ‹ì“»ðVy’“½Ã¥9%^Q‹s‡ötµzëÎ’]d‰éý²8ía×Y´ð˜žM4èø8k)Ú(¥Y-9¥O×·Ô©ÈÕ~Žb¹g´Çð+Ú–wö5[zôÞ’„×&‡O;6tÖÛ]°í×»¶»U°|¿ƒaŠ>ÅÂ›n¥NÜêÊo^{»«©»ÐÊÙ:»ÇqÍ±bvßKÃ©ËÃ%%þ6qÖ´âßZŽìu\\}{\\› ý­µþ/ˆR³´£Vîöö´iS§å:µg-K›mµåfîº?ìžÓc[%ËÙ„iÎæÊÖ3¿­ð«w?]Zkµo6“b¢º„ôog™ïêáYSÄè7\Z–xuzðî”)ÊKó\ZÄ®g{ˆ]^U“s¯Zu$ß6å&ßç7ïŠáÔq\\\"ó	ªô¥ymRÞM.Qœ\\_ÀÍç\\¿{•3†7–q*¡u…âu©Íi(ÊZkÈL#™´ŸC«\'àø?GË,f…´}9Ž]Ü\\ÜÕÓG-Ù¸EyøIKéz-4é®/WæÐ„>†¾Ú0LW#ÖÙ#NßÁªT¹´¥Rz;›j’OÖvîÉ´ôå¼¹ëÂoÓ–ö¯WÏ“ê\"	bN•?Í»Ï˜f%oF†wˆP›Zø:öÔ¥Z›]žºš^-M)#o:öÍƒlÇcÖïi¼s6YUÂlm“N{•c¹Z«]J0”´lÑ¨t!3Á»ÎXžéËÑ\"ú(Ÿ]Ì³üÇÿ\06DîèÑõÙçþœ°ý ¢‰õÜË?ÌódBÛ V\\³Ì&òÕ;ûuZ–JïQk]\'NŒœ’N,ÛåZ-J3Š–œ½÷©©ßC‘\'Òo×ýú3mTÒK‚æO8¾Š®Ee|‡‰BŒéßÞQ×­©Sƒþ©ú3IÇoù	Å´þn[rû¢lú*ßÞGÿ\0–¹ý\n!7F¯þBþ|¶øÂ8JtàÞòsf`Â²¦ZÄ³.9wk2ÞwWgÊ‚Õ¿çÔ›ÖÝ–GÅsDôIz@Ö´²µØF[¿”gy^ãÒ„µúRzÑ¡¯{JrîQ]¨J!\r6óµœ[m{PÆsî%R§‚»­à¬hIê­íaÂ•5ÙÃ‹í”›æÉ»èplç-×ÛfaµÝ½Ça+l\"3Ž’…œd·êG¾rŠKµEõ2ôqØÍöÜö©…dº0©?}\\â•à¿rµƒ[þWÂ+¾Fêp#\rÁp‹\\²£meaFÖÔiÇHS£¥Ç¹E%äÐž·bœªS¤–þº\'«ÓÏúÍ#tÆjf\r¾í©9ËÃf+å\rþjœkJ0^HÆ+Èorš[»‘K]tÓ¬ÒÏL,¡u’ºJgÌ6âƒ…æ+S·j:FTn´­Þåá|qb–>…–QÁþws†t«Bœñ\Z—ÔpØÍÇYBŒa¿¢}ZÊK]9è»	ç+z2zÊ\ZšÒô5v×€e<ÇŠì£2^Ò³ùâ¸¥w…Ö«-ØÎê+vTu|”tÝ]m5Í£fÉñM_\'2åü#1`·˜1a»BÞ¥¥Í	ò©Jpq”|©éå49˜°È`™‡Á©Õu#a{^Ö3kMå	¸ëåÐÝ®Þ¶³–ö1³œK<f¨¥mJQ´¶ÞÒww2‹TéEu¶ù¾¥¬º â÷8¥ýÎ\'y=û‹ÊÓ¯V_m9ÉÊOÎØç9›_ô9ÿ\0Á\nþx¿ý!Ž=Oï#:]þŠ&Gô9ÿ\0Á\nþx¿ý!Ž=Oï#:]þŠ$G6—)fí±dÜ·^—„§ZÒœ4×z>6´|ø#x–ÖT)¸ÒT”a¥®I&ô^m\r-ôNIô“ÙÊkTñûoÎnÅF)ê¢¼ÄèjŒ¾ˆŽBÿ\0¢î?}¹,*ÿ\0¼‹—œ®aGUß¥f¼Mš•²m^[Ê-¦ªÅ¦¹ó7Óûü3Ï‹ÿ\0õ;SOÖ¾è}ö?œ\Z·ËsˆSÃ2ÓÄæ›¥‡‡©º›zFšo‚ã®††ï.«ßÞW¾º¨çZâ¤ªÔ“|e)6Ûó³}ÖÔ©\\`ÖôkÂ„­`žþŽ:8-íuáÈÑ&tË7¹/7ãYG„£sƒß×²¨šæéÍÇ_Ñ5ÜÄÍ¦z¹;Àz9áå¥´]îd»»¾½«»ë›…yÐ„[ìQ¤¸w¾ÒP«Kà“ëãã×ó“ÐØÛ^ŒäO Ö\'yJß\ZËõë\\XRœ·]ÕY:’Ýí”*Jz¯µ”;“zrQ[Ý€–&éI“ð|Û°|ã…bVñœV^âœšmÓ©N;ð’ñI&i=xéÏ¶Œf[\ZÄðJ¸”~oæJ50ü:Ò×½èéR«ìŒ#.-õÊ+›Mj¬A<¹èµþ»;ÿ\0ÓöŸÕOLLZóé/Ÿë^Õs•¾-;H=uÒ4¡Ç±$m[¢×ø:ìïÿ\0OÚ|CX]:2eöNé-šÕ)ÆŽ9RÅ¬ÜtU)Ö\\\\{RœgX ý—…ÝTÎyêæ„*^ÛJß\r¡\'Ý8MJsÑõjÔWØDmèÆ[Ñ†M5×«°Õÿ\0¡¿¶|#gœ[g™‹§cC4ªS±­VjwÕ(9>NQ“K©µ§=\rZUu&Þô·Z×Fßn~&9Ç3…a¸­•\\;´§qkuNtjÒœT£8IhâÓæšÕ3E[MË6ù/i³\'ZUuh`XåþJmhå\n¦Ÿ•DÝ†×ö™–vI’1óš¯!JÎÂ”¤©¹%+ŠŸaJ	ó”ž‰.öúfl~û5f<[4b“ß½Æ/«â2]ujÔs›óÉˆâs6mèeãW8¦Á12â¬¥O	ÌôcÉ(J•*­~5I\rr\"¿¡ß’ï2G{;ìBŒ¨Ï1â8²„ÖŸK{”¡/4ü¤¨\\‚C\Zt”Án3Á³ÎkêVÁnd—ÜAÍüS%,^…½ÍK[¨Ftk\'Nq’ÕJ-hÓ]	! \r&nS¡¶u¶ÍÝòu{K¸Î¦eó:æ)-aRŒœZü]×Ç™«Ž‘{\"Ä¶+µ¼w&ÝÑ©éq;¬*âQj7U$Ý)&×—¬–œ7£-8ÿ\0¡÷Jªý3Ö\r˜¨Õ»ÊÜã+ÈRŽõ[JÉh«ÓÙpá(õ¤´â¸¸§©·êm¸EÉêôâË!‘óþUÏù~×0äÌÉe‹a×0Þ…kjÊzrÖ2IïFKU¬ZM¶£Òœšz=Ö\"Q1¢àcí¨í‹!ì/VÌyï4Zá¶ôÓðt¥SZ÷ÓØR§]R\\Vº-º¶¹³\0ôL¯n6¶Þ9‚»MŸÖÝ¶†ê”ï(qýó=5Þï„SÑrÕójhØmÊ‹K_\'v©­~IÝ(ñ«œÁÒ=â7Sr“Æ+RŽ­½ØAîÅ-z’HÜö‹Xf.Ó\ZÂñ\n7ö7´ásksB¦ý:´å(ÉI=\Zi¦¼†žúgäË¼“Ò?7ÚW¢áGºX¥«ÓE*Uâ¦´íÑïE÷¦#yÌ“~…¶OÃ\'…ç,ï^Þ/=3C¥==u:j.rãÕ«ÓÌOïJÐ×WM?¬¿Cgl˜.QÍXÎÌñûêVŸ<’¥s‡T«-îiêþÚQ|Ù8éÍ£g“ÑéÞ/™`XN7„]á­Œ.¬ïhÊÞ½	êãRœ–ì¢ükTh{7àÔòîmÆòý*®¥<3¹³„ÚÑÉS«(\'§~†ìö×µŒ·±Ížâ9ß2]Ó+JOÒöòž“»­ö¢ºÛ–œ¹-_Q¤_»ÆñkÜfþ£©sqRê¼ß9Tœœ¤ü­±QÌÚ¡£Ýbý*a·r†\rÝZR×ªŒ*éç¨Èíè¦ýy2·þœÿ\0™¬JCã$ÜäîøMÅí)S¸Ç®ëâ²Œ¸=Éµ\ZoNøB,‹Šo×“+éÈÿ\0ùšÂÒÆÝ2Í¦dé;–õ¬.(áTo1-ÉÅ4§\n9xãRp’}N)›|©il þ––œx·å5Cèl¤úKÛj“þÒ_sñ@Û,½‹ñ(@ïE/·ŽJÈø”)EU†%sIÍ¿]¤©¦×fš¢t_ztŠÙÇ~d±_ü±&·¢š’ÙÞMÑ%ýº¯Ëï)£¢ÿ\0øElßÿ\0RØþ–\"	nÖIEE%Ãy\Z^é‡þ{Dþx—Äº)õ}Ò4»Óü&ö‰üñ/‰ æJB‡÷ŽÓ>ýƒü[Ã-z#ŸàÕ}üíaùäb_B‡÷ŽÓ>ýƒü[Ã-z#ŸàÕ}üíaùäIÎÕ.õZËÝ4þ27.ëáûÆqZ²§Z×-ÜÖ§%-\Z”m[OÎáU¬½ÓOã#{ø4s@ž_œãbxD¬§)-RU(n7ð‰Lnhvs•IÊ¤ž®MÉøÙ·Þƒ9;Ë}rµÝ(ølf\\Bæ{«×ÕF—oEHæû-ãø–^ÄíåBó¼­g^”ÖŽ)ÍÆIøšfÅ½x/‘©ìcÅám`®¤°Ê5ê(«ËIKyÆ“|©·&áÏO\\¸)h”GBpª4´á8%ÌÃ}/2&\rœ:7çÛKÛzJXf\r_·©%«§VÒ.¼\\{TÜ|Sk¬ÌÏWMñâãÛ¡ý&HÙ~%²¼+|Éš¨«Z”iÕmÛY9ý6uVüS¦—Z“kD!«UÌÞÞÌõúeN-/˜–zéÙà`Í#{{3_ÜÏ)>0k.y‡À$Ž\r-m³ºÌ›aÎØÝëÖ­Þ?6µ×v>j1]É$—r\'Ï¡‡’p›M”æñéxÏÅ±©XÊ¦žº6ô)SqãÕ›ïáØ´„]\'r]ÖBÛÞwÀn-Ý*sÅî/m—W€¯7V\Z>½÷|qd£ô4¶Ïƒa´1­Šã—Ô­.oo>ka©-yÊ…j)òÞJœ%Íë><qÌžvÅ<\r=7wx>­O;´«ƒfœ•åü^Î5í/ì+Ð©	-V’ƒZéÜz*v”ž¼¢ß_êâb.‘[eÀ6+²ì_2ã˜ŒÕj-pÛYTN­ÝÜ“PŒ#®­/e&–‰-_a2ˆis¶V8Õ”e¼­ëÎ’–œÔdÖ¿¶ïCË0\\ãðK{©¹<&òîÂ›hªo¥äðšx’5sqVîâ­ÕyoT­9T›í“z¿„Ü‡Buú7eKBŒèÝâtg‹Ö§.>˜“œ5\\Óð~]zõ<\0	@\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0mûi¶›!ÙFgÏµ%LaÖ•ccN||%ÜõµÃTê8·ÙÍ$^]\\ßÝÖ¾½­:×%V­Y½e9Éë)7ÚÛfìöé°¹Ò/PÊ¹¿Æìpê^œÝÂî(Ò•Z‰5ÿ\0	Nz¥«å¡…m}=€YÜÑ»†bÎõåB¤j*U¯í]9èõÝ’VÉî½4z5ÀˆÜ™z¾›\'†Ì6…Ü^[ø<_3ÊXÍóqÒJ3IQ§ø4Ô_t§2I7……\ZVô)B•*08S‹á¨¤’]Éhw„á­	I·ß®Z7Å\ZÀôKvQO+mOÚVkàìóU¬i^nÇEÚ	G^íêJŸØIõ›E1žÝ6\r”6ý•ã”³”¯¨ÚÒ¹…Ý+‹\n´éÜSœSZFU!4“\\ˆÕçB«­•í÷õÏ‚Áóx.#«Ò1U_Òª>ÍÚª\r¾¨¹ö›ŒU©9î)­îÂPô0vksNâß5ç¸N”ã8Mbš©\'®«ûÄJü\'	¹Ã­-lêÞÖ¹ô¬#Z´“©WD–ôÚIjôÕè¢µã ¬RÖí…[;Š1«Jâ>\n¥9ÅJ2„¸I4ø5£|ÈÒH—Ül{k™‹#T¤ãkiu*¶âÔíf÷©4ß=\"Òoµ3xµ\"ç¢ôzë©öíÐëf=!1ûÏœ®qÛBÆÓÒ‘žuFš«O{y*ž”õkV“Zpç¨+ÐþÙ,v‹¶Ú9¶U0¬¡Mbw–±•Ë{´#øÚËð\r´Ù·+jrkMå¯ól£¦Gèó—oòæHw÷Ä®ý9swˆÕ…[‰ÉAF0Ö„wb“iiÎRzñ2­8îÁGM*Ík	%Ö™¯D¢¦-sˆTÛ®BÂ*ÜF­8Ç0ÚÑ†³R„Tct¢»b’žŠ\\Ü™°óŠêŠ¸·©A¤Ôã£RZ§Ü×X! L+Å0FßÁq‹ëIª”.-ê8T§5ÉÆKŠfr±é×ÒfÃx=<üªA­=1VÊŒë®	~èã¯R\'fÖý­‹mC¸Çpú7yK¯-ê•p§KÖ“ç)Ð”wSëÖ\ZñoWÄÆ^…6V¥u	â_Ånm“õô¨átèÍ­z¦êI/ÅcŠx .cÌ¹ãi˜åÞ`Ì¸®\'âNœë×¯^r«(RŽ²“ìŒÃD>ÊåÎ†û\ZÊ;=Æ6u—pk‹Z‚Ê¥†#Šºñž#ZœÓMøYAÆ<Ö‘QÜàžî¼^1§è]lÁ:™§>ouéˆZpÿ\0ðÂ%Î}\Z*Sú\0ìõo­V\\°×GËéKåDôPä¥µÌ³£ÿ\0Èÿ\0æÈØ¾EÉ6™(á/\n«Z½ŽgJÆÞwN¤¡N:)M¤““äô\\‘ŠvãÐßg= ³-–dÏÎcµ¯ají)Gº¡JyÉ9*”fÜµ}¨=F—I¬9·¢XMÿ\0èÍ´Ó”eZõ#ÆÇ:l§ayÞ†É˜îiºÄ¨P«m\Zx•Ý\n”\\*GFô§F^]zw…9SOŸÌžq}^9#¥þ–¹ý\n!/F––ß²éËoŒmŸ¤Fü™Ò3Âð|ëˆã6–øEÄîh<2½*S”¥Ö¤êS¨šÑkÁ#dC«c™6á9ÏÌYÆ¥þ\rwËxÜßZÊ”¥ªRQ·M¯A:ðf­¯íGØöÏq ãË~ß¡9R¡	(Êæ»ÕS¥Ôç&¸½tO]†”s¶pÇ6›1Lç˜î|G¹ÍyrIÉðŒ{\"–‰.¤‘¹\r¸ôkÊý 0Û9æ,Åa‡aõÄhaWTiF­F´ÞŸ„¥6ôÕîñá«0÷þ]½´çßø…§ÿ\0¶‰kÿ\0c!6—°yâUvoae[TãuV½…*ó”a®ìT¦›ŠÕ·¢çÃ°É¿øˆô¤öÛ…ÿ\0Á­ÿ\0d–ø]t~öÓŸâŸþØáuÑûÛN}ÿ\0ˆZûbPáè!Òj|žyžÒq›kÙ`QÃ—€²§AAVô×„×q-í|>}‡/OŒx–×òå¾Ð2mŒ®sF^ éÎ…8­ûÛ=w·lã\'\'Öœ—Z2ÆÁº+dnŽSÇ¾p±lvò…Zúib·j¸»¹¸éÓ§¦¾Zë¯$fXR’ŠŒž­$µáÅwŸ<éÕ 	Âó»•:­kumSIFIÂ¥)Åõ®i¦fÜ«Óg¤†QÂ#‚aùþw6ôâ¡MßZÒ¸©¥¢Js‹|±­µô-ØÞÛ®*bøÎ[Çd¸âØUEN­WÇO\r	\'N¢åö*\\4RHÁ2ô)2Ú¸ßŽØñ\'C]|ÌˆoiÙ½átø	öˆ5œö‘´ý´cÖÕ3v`Å3!RJ¥»ÖZ7ÁF(­|¸#ÇJ2„œ&š”^>¦nKböI°¹CË˜M\\O\ZÓ×âØœãRåj¸Æž‰B’û˜ï>¹3\Z¿Bÿ\0`•ªN­|ÑžÔ§\'&£ˆZiÇýØû¾‡;^¦<)kÿ\0›â¤1Ç¢¥8Ë$de&Ö)wú(’³c;Ë{Èôv“ïq+¬6…Å[ˆTÄ*Â¥méËzZ¸B1|uÓH®\ZxÏ?·®97¤M††gŒK³¡…\\NæÌºô©JRœT^ó©N§\r¼!-WtMÿ\0	Mœÿ\0?Û|cv$^Ùï¡å±Mšç|>à9‹9ÖÄ0+È^ÛSº½¶•NT¦£o×‰¯(O§Ê=tþÿ\0ÌóâÃ?ýNÔÓõŸïº}ç7¡¶M•à{jÙö#³lËw}m…âÒ îjØÎ¯J´+GvSŒ¢µ•(§ë_G\n~…öÂ)TUc™óËpjQO´ÓTõãýÇà!)u„qÂ¬ýÏOâ£_^ˆGEÌfï¯·,‰…Îîc¦?kB;Õ â’Ìb¸É5¢–œV‰òoM„aö¾’²£i¼ä¨ÅA7Í¥Ë^þÝ8kØpÖ²•E8ºp”fÞª\\uOƒø! Ü\'ÅpF†/‚â76Ö³ß£qoQÓ©N]ªKŠ3¯NÞ“VØ;ÁþÕh¿òŠ¶4gqÕþ1Ç^¢umwÐùØ¾Ô1\nØîFç)b×s­W\nkÒõ¤þÊVòÖ)ýÃ†¼Þ¬Æ>…6W¥u	â;^Ån-ÓÖtèátéNK±MÔ’O¿uø‚xs 6aÌyßixíÖ=˜ñ,KÄåJU«×«)UœiG‹É‚^$?Ön_+ô>ÙKÙÞ3³¼·‚Õ¶¥ÙNÇÅ|$e‰W§5ÇZÒ‹Qä½j†âêŠÕ˜²^…æÁ¸nælöû¶6‹ÿ\0ùF¨–uèµþ»;ÿ\0ÓöŸÆÝ3z1ÕÛÞKX¦n£šòügS\r“Ñzf›mÔ·œŸSÑ8vK^¦g­žäË\räŒ\"áWìð;:vT*\\8º“„‰ÉÅ%¯‰#ÐIk´OU¦ŒhjÐ1ƒcY[¸Á±¼>ë\rÄì*ºu¨Wƒ§V”ÓäÓâŸ‰£1åšÝ#ò^Ú[›zpTéú~ÞÔáÉ)M7ð›9Ú÷EÍ“íÂÙ¼õ–©üÑQÝ¥ŠÙIP¼¥ÙôÄ¾™â¨¤»¼HßˆzùZ­Ô§…íw¶·mîÓ¯…Ó­4ºµ’©üÈk¯ðà‚ûGÛÒöµ{Ý fëüYÒzÒ¥VzQ¥Õëi­#Úžû¢ßFLË·üçká­®-2•hÏÄT4ß‚âèÒ×„ªKM5â¢›“OE5r¡—±ì±}OÍØÎ-›%I©FÚ¼•¥´Ÿò¡MïËÅááÅ=IS—ò¦•ðÊ.^Âl°Ëe»FÚÒŒiR¦»#¤£¯^‹¯Èw/áX~Ø`ØM¥;[+x[ÛÑ‚Ò4éÅ%¯GÐ-§\nq‹æ‘p|…$·–…A#t§èÉ€ô‰Ê*ÍÊž™0øÎ¦ˆ´ÚŒô×ÁTK‹§-}kš×M¤¶‰³ï²œÃ[,g¬ã\r½£&–úÖX§ì©Ípœ{Ñ¾G^\\\Zë<¶yÙ–GÚN<=e\\7²šáNê„fàß\rèKMè>ôÓ#‚uhÓ.füÕ“ïöTÌx–q-7ªY\\Î‹’]RÝ|WŒ÷õºUtŠ¸±ù›Wkù‰Ûî¨î«Ÿt–¿	;3—¡…±¼næ¥ÞSÌ˜þ[u$Ú·U!wBšìŠ¨•O<ÙäaèQ`[éÔÛ=û†¼–ôñøa¨×Ö5ã™’úXžaÆ/q+¹­{ºò«6»7¤ÛÓ¸È;èé´­¾c´ðÌ›„NšW˜­Ä%[Xõ·-=t´åêß\\Í‚ä/C[a™Râþd¯‹æËšOyR½¸T-ên$¤üR›]©’{-e¬+*ØÓÂ0<*Ï°¡N4èÐµ¡\ZTáðIF).I/ Ôy†ìŸØžÎðýžà÷··”,5”®.ç¬êÔ“ÖRQM¨-yF/Eð¼;Óƒ£\nÛ¶S§™2½¬á—©KÒ‹Míe+vûyÊ?ÊmpÞd¡8jR”åªÓMxêôáÝ§!ì5hÃ±|¹‹VÃq;Kœ?°­¹V•HºuhÔ‹ëOFšhÍ9W¦çI<£…¬\"Çh5.èB\nx…µ;©Æ+’Ršrë6e¶nŠû$Ûœlå–£OI*x­…UowMvonµ5Ý5$µm$Èã}èSeŠ—2žµüRÞÝ¿[J¶N¬âµääªE?ÅC^‘6‹µÍ£mbþž!´Ù}‹Î\n4ëOJT»w ´Œ|‹S\'ôOè¯™vÿ\0›h_ßZÜYäÜ6²©‰_î~ï»ÇÒôuàå.N\\¡ß»LÍŸz\ZÊ—ô±,ÛŠâ¹º¥©FÞâJÚÖZ}´)úéxœôíL•¹w.áYbÂžávxu…(Pµµ¥\Zt©ErŒc’]ÃªÖåÀ°Ûl¡…ØÙÆÖÚÖ£BŒV‘§N)(Åw$’5©è¦qÛ&Vk«.Eøš¦ÎÌ·Î‡›7é™ìsNuÆs¥Îd¬(Ãº¡Jòžô•J3më\'É®¡Á\Z —¡²Òé-nß%‚_PÛ$ÚQmöÓbÝ6e°œëù“±ÌÏsˆBÖ­ŸƒÄn¨T¢áSM^”èÂZ­Þ\ZH‘U#¿	GµhôS\'lï\'(É6±ªýêQ\n:0pé³}²Øþ–&ØvïÑ¿\'t‰Â°Ü=bXÍ•®q+ª/¯JœÜåÖ›9­Ý;µâc—èul_gÙÇÎù1ç*¸†}JþÞw¶³¤êS’”Tãx¶žš=\Z%§	$ã$ô’ÔÒÿ\0L7¯I½¡µþ˜—Ä¹ê4+ÓZKuèÛIpêÿ\0¶F­¢úÛÚ~vÅóöbÌYÆŽ#\\;›Švw¶Ð£h—­S¡).	s“ã¯ˆ@Ãž…$á-¥ïI-ka\ZwúÛÃ-z#sƒè×}%ªÅ¬8kÇœŒ°N‹y#£ŸÍ¸d\\W¼§ŽÊÞw¸¥UÅÑßÜÝðtéé¯…—=OE¶mŠeÝºdÉä<ÝyˆÙá•.)\\Nx}XB¶õ6÷ts„’O^:§È„îi	ú­eîšçÂ©«ŒQÕémK]Ÿ`ˆ±C`¶µi\\Ûf|õ*”§ÅO´ÓTõãýÇà%K©G+àu+V¥^½+g=)C~¤ãNÅEi¬š\\æÉD oOn‰¦%ˆÜí¯føMKšÕV;‡Ð†õJš%sN\\øi$»¾Ø€4k\\Ù\\B½\n•mëÐžô\'	8ÎOškŠi›W»ôGº7xv½1™£¬Z–õOñÏ5…äþ„=1¯o.pK(a¹Š5©éI|Ì¿©sT5të.ÙîI­®=mtO¡Ògoö¸CÀèmo2FÉÅÇsÓ½òß®øOOÍ™Âx¶`ð†-+:N÷½¨åUÓ†©9Õ¨õæÚZ·Å³f¶>†wGKªw·X¶q½¥\r&íî±:¥5¯&éÑ„´ñI>ôx>˜ÙŸb[ØŽ%°M—á˜M†1ÊÚ–^º½½¼jB¬ª\\ÎMÍÎJ\n)Mï56ù$5è\":Zí7Ç²ØN–Íò½\Z‘q<Î2‹Z4üx3F9SºÍ9›	ËvTå:Ø¥åH$¸ë9¨þ³|¹zÑáøU®ÿ\0É-éQüX¥×ÇÎLñG2(ôòè³{¶,.žÐ²%¬jf¼‚…[T´–#m¯°‹þ\\Sæ›KŽ†¯ÚÅrþ(×öNˆØVþU*´*Åùdš7ñ^ŒêI¸Å5ÃŸ_ýó0¶ÙzìgmÓ–#™rã±Æd´ù«…Ôð/îÞŽ2k©¢5ÐkéËÒ_/a?1íö€î©(:q«{iJ½hÇºrŽ¼WŸv—žöŸ‹¬o>fkÜbî)Æœ®\'¬iEóP(¯ê\'Ï¡K—%^R´Û\'J‹~¶0Šs’]òURø³?C{bY\"ú–-škb9Êê‹R…ù*6ŠK“t©ñ—Šr”_Z?èoÑK0m£6ÙæÜÇ„Õ£’ðšÐ¸­R´cˆN2ÕP§ªõÑmzçËNÙ¶»\nN•©$’QO‚K©p\\¹8Fg‚ÛS°ÃlhZZQ‚§JîÂ\\’K‡.î¥ØwÇY \0”\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\rÅY$¦ã¢|WyÌ\0ÖMŽ†8ÆLÌ7ûOÙvVû/â3Þ#‡ÚÓr©‡U“nSŒWE½_aË–„3…Jöµ£R•J”kR–±”[Œ£%ÖŸ4ÏÐ[ZUå½S^Zpf,ÎÝ6´*ó»ÌÛ4Âª\\ÔzÎâÚÚ¬¼r¥ºÈKO56¿µªØÌŠ»QÍÓ°ÓwÒ²Æî];77ôÓÈyXBâîº…8T­Z¬´I\')NOálÛÊô=z+)ïüáÞs×O›7zy¼!2F}†ìÒ¤nr~Îð»;¨{¹ÓðÕãÖšœõi®ÒOj!tèwŽXc–{gÚv+	ZÁÕÁ0»ŠzUr|ÍX¾1I7¹zñzp×a)J”Z”µo‹e½i9RÞå¢ZðHç#ÚH\0%\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0ÿÙ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0');
/*!40000 ALTER TABLE `tbl_profiledocument` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_provincia`
--

DROP TABLE IF EXISTS `tbl_provincia`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_provincia` (
  `fldCodigo` int(11) NOT NULL auto_increment,
  `fldDescripcion` varchar(255) default NULL,
  PRIMARY KEY  (`fldCodigo`)
) ENGINE=MyISAM AUTO_INCREMENT=35 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_provincia`
--

LOCK TABLES `tbl_provincia` WRITE;
/*!40000 ALTER TABLE `tbl_provincia` DISABLE KEYS */;
INSERT INTO `tbl_provincia` VALUES (1,'AZUA'),(2,'BAHORUCO'),(3,'BARAHONA'),(4,'DAJABON'),(5,'DUARTE'),(6,'ELIAS PINA'),(7,'ESPAILLAT'),(8,'HATO MAYOR'),(9,'INDEPENDENCIA'),(10,'LA ALTAGRACIA'),(11,'LA ROMANA'),(12,'LA VEGA'),(13,'MARIA TRINIDAD SANCHEZ'),(14,'MONSENOR NOUEL'),(15,'MONTE CRISTI'),(16,'MONTE PLATA'),(17,'PEDERNALES'),(18,'PERALTA'),(19,'PERAVIA'),(20,'PUERTO PLATA'),(21,'SALCEDO'),(22,'SAMANA'),(23,'SAN CRISTOBAL'),(24,'SAN JOSE DE OCOA'),(25,'SAN JUAN'),(26,'SAN PEDRO DE MACORIS'),(27,'SANCHEZ RAMIREZ'),(28,'SANTIAGO'),(29,'SANTIAGO RODRIGUEZ'),(30,'SANTO DOMINGO'),(31,'SANTO DOMINGO ESTE'),(32,'VALDERDE'),(33,'BAVARO'),(34,'SAN FRANCISCO DE MACORIX');
/*!40000 ALTER TABLE `tbl_provincia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_recibo_egresos`
--

DROP TABLE IF EXISTS `tbl_recibo_egresos`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_recibo_egresos` (
  `fldIdDoc` int(11) NOT NULL auto_increment,
  `fldFecha` date default NULL,
  `fldTipo` varchar(15) default 'NORNAL',
  `fldEntregado` varchar(255) default 'n/a',
  `fldConcepto` varchar(255) default 'n/a',
  `fldMonto` double(12,2) default '0.00',
  `fldMontoLetra` varchar(255) default 'n/a',
  `fldUsuario` varchar(255) default NULL,
  `fldIdTipo` int(11) default '0',
  `IdCaja` int(11) default '0',
  PRIMARY KEY  (`fldIdDoc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_recibo_egresos`
--

LOCK TABLES `tbl_recibo_egresos` WRITE;
/*!40000 ALTER TABLE `tbl_recibo_egresos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_recibo_egresos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_recibo_ingresos_cxc`
--

DROP TABLE IF EXISTS `tbl_recibo_ingresos_cxc`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_recibo_ingresos_cxc` (
  `fld_Id_RI` int(11) NOT NULL auto_increment,
  `fld_forma_pago` varchar(255) default 'N/A',
  `fld_detalle_forma_pago` varchar(255) default 'N/A',
  `fld_id_cliente_ri` int(11) default '0',
  `fld_date` datetime default NULL,
  `fld_Description` varchar(5500) default 'N/A',
  `fld_monto` double(11,2) default '0.00',
  `fld_monto_recibido` double(11,2) default '0.00',
  `fld_fact_afectado` varchar(255) default 'N/A',
  `fdl_nd_afectado` varchar(255) default 'N/A',
  `fld_User` varchar(255) default 'N/A',
  `fld_Estado` varchar(255) default 'N/A',
  `fld_id_prestamo` int(11) default '0',
  `fld_interes_cobrado` double(12,2) default '0.00',
  `fld_capital_cobrado` double(12,2) default '0.00',
  `fld_mora_cobrada` double(12,2) default '0.00',
  `fld_concepto` varchar(5500) default 'N/A',
  `fld_socio` varchar(255) default 'N/A',
  `fld_bce_actual` double(12,2) default '0.00',
  `fld_bce_anterior` double(12,2) default '0.00',
  `fld_adelanto` varchar(5) default 'False',
  `fld_adelanto_aplicado` varchar(5) default 'False',
  `IdCaja` int(11) default '0',
  PRIMARY KEY  (`fld_Id_RI`),
  KEY `Idxs` (`fld_id_cliente_ri`,`fld_date`,`fld_id_prestamo`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_recibo_ingresos_cxc`
--

LOCK TABLES `tbl_recibo_ingresos_cxc` WRITE;
/*!40000 ALTER TABLE `tbl_recibo_ingresos_cxc` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_recibo_ingresos_cxc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_recibo_ingresos_cxc_detalle`
--

DROP TABLE IF EXISTS `tbl_recibo_ingresos_cxc_detalle`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_recibo_ingresos_cxc_detalle` (
  `fld_d_ri` int(11) NOT NULL auto_increment,
  `fld_cuota_id` int(11) default NULL,
  `fld_ult_abono_interes` double(12,2) default NULL,
  `fld_ult_abono_capital` double(12,2) default NULL,
  `fld_id_ri_padre` int(11) default NULL,
  `fld_tipo_doc_ri_d` varchar(11) default NULL COMMENT 'n=nota debito, c=cuota',
  `fld_ultimo_abono_mora` double(12,2) default NULL,
  PRIMARY KEY  (`fld_d_ri`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_recibo_ingresos_cxc_detalle`
--

LOCK TABLES `tbl_recibo_ingresos_cxc_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_recibo_ingresos_cxc_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_recibo_ingresos_cxc_detalle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_recibo_ingresos_imprimir`
--

DROP TABLE IF EXISTS `tbl_recibo_ingresos_imprimir`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_recibo_ingresos_imprimir` (
  `ReciboNo` int(11) NOT NULL,
  `FechaRecibo` datetime default NULL,
  `Cliente` varchar(255) default NULL,
  `PrestamoNo` int(11) default NULL,
  `MontoPrestamo` double(12,2) default NULL,
  `FechaVencePrestamo` datetime default NULL,
  `MontoCuota` double(12,2) default NULL,
  `CapitalPagado` double(12,2) default NULL,
  `InterePagado` double(12,2) default NULL,
  `MoraPagada` double(12,2) default NULL,
  `OtroMontoPagado` double(12,2) default NULL,
  `MontoRecibido` double(12,2) default NULL,
  `CapitalAdeudado` double(12,2) default NULL,
  `Atraso` double(12,2) default NULL,
  `Concepto` varchar(550) default NULL,
  `Usuario` varchar(150) default NULL,
  PRIMARY KEY  (`ReciboNo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_recibo_ingresos_imprimir`
--

LOCK TABLES `tbl_recibo_ingresos_imprimir` WRITE;
/*!40000 ALTER TABLE `tbl_recibo_ingresos_imprimir` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_recibo_ingresos_imprimir` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_rep_saldos_ahorros`
--

DROP TABLE IF EXISTS `tbl_rep_saldos_ahorros`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_rep_saldos_ahorros` (
  `ID` int(11) NOT NULL auto_increment,
  `Cuenta` varchar(50) default '0',
  `Cliente` varchar(255) default '0',
  `Capital` decimal(12,4) default '0.0000',
  `Interes` decimal(12,2) default '0.00',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_rep_saldos_ahorros`
--

LOCK TABLES `tbl_rep_saldos_ahorros` WRITE;
/*!40000 ALTER TABLE `tbl_rep_saldos_ahorros` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_rep_saldos_ahorros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_reporte_atraso`
--

DROP TABLE IF EXISTS `tbl_reporte_atraso`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_reporte_atraso` (
  `fld_id_cod` int(11) NOT NULL auto_increment,
  `fld_cliente_id` int(11) default NULL,
  `fld_cantidad_cuotas` int(11) default NULL,
  `fld_monto_cuota` double(12,2) default NULL,
  `fld_mora` double(12,2) default NULL,
  `fld_atraso` double(12,2) default NULL,
  PRIMARY KEY  (`fld_id_cod`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_reporte_atraso`
--

LOCK TABLES `tbl_reporte_atraso` WRITE;
/*!40000 ALTER TABLE `tbl_reporte_atraso` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_reporte_atraso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_reporte_saldos`
--

DROP TABLE IF EXISTS `tbl_reporte_saldos`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
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
  `fld_monto_prestamo` double(11,2) default NULL,
  `fld_monto_cuota` double(11,2) default NULL,
  `fld_cantidad_cuotas` int(11) default NULL,
  `fld_fecha_ult_corte_prestamo` date default NULL,
  `fld_fecha_ult_abono` date default NULL,
  `fld_monto_ultimo_pago` double(11,2) default NULL,
  `fld_balance` double(11,2) default NULL,
  `fld_atraso` double(11,2) default NULL,
  `fld_cant_cuotas_atrasadas` int(11) default NULL,
  `fld_status` varchar(5) default NULL,
  `fld_estado_ctas` char(6) default NULL,
  `fld_saldo_vencido30` double(11,2) default NULL,
  `fld_saldo_vencido60` double(11,2) default NULL,
  `fld_saldo_vencido90` double(11,2) default NULL,
  `fld_saldo_vencido120` double(11,2) default NULL,
  `fld_saldo_vencido150` double(11,2) default NULL,
  `fld_saldo_vencido180` double(11,2) default NULL,
  `fld_saldo_vencido181` double(11,2) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_reporte_saldos`
--

LOCK TABLES `tbl_reporte_saldos` WRITE;
/*!40000 ALTER TABLE `tbl_reporte_saldos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_reporte_saldos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_saldos_ahorros`
--

DROP TABLE IF EXISTS `tbl_saldos_ahorros`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_saldos_ahorros` (
  `ID` int(11) NOT NULL auto_increment,
  `Cuenta` varchar(50) default '0',
  `Cliente` varchar(255) default '0',
  `Capital` decimal(12,4) default '0.0000',
  `Interes` decimal(12,2) default '0.00',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_saldos_ahorros`
--

LOCK TABLES `tbl_saldos_ahorros` WRITE;
/*!40000 ALTER TABLE `tbl_saldos_ahorros` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_saldos_ahorros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_supplier`
--

DROP TABLE IF EXISTS `tbl_supplier`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_supplier` (
  `fldSupplierID` int(11) NOT NULL auto_increment,
  `fldCompany` varchar(450) default NULL,
  `fldAddress` varchar(450) default NULL,
  `fldPhone` varchar(450) default NULL,
  `fldContact` varchar(450) default NULL,
  `fldLimiteCR` double(12,2) default '0.00',
  `fldBalance` double(12,2) default NULL,
  `fld_Status` varchar(255) default NULL,
  `fldBy` varchar(450) default NULL,
  `fldfax` varchar(450) default NULL,
  `fldcel` varchar(450) default NULL,
  `fld_clasificacion` varchar(450) default NULL,
  `fld_cta_contable` varchar(450) default NULL,
  `fld_telefono` varchar(450) default NULL,
  `fld_correo` varchar(450) default NULL,
  `fld_banco` varchar(450) default NULL,
  PRIMARY KEY  (`fldSupplierID`),
  KEY `NewIndex1` (`fldCompany`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_supplier`
--

LOCK TABLES `tbl_supplier` WRITE;
/*!40000 ALTER TABLE `tbl_supplier` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tabla_cuotas`
--

DROP TABLE IF EXISTS `tbl_tabla_cuotas`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_tabla_cuotas` (
  `fld_id_cuotas` int(11) NOT NULL auto_increment,
  `fld_no_cuotas` varchar(15) character set utf8 default NULL,
  `fld_id_del_cliente_cuotas` int(11) default '0',
  `fld_id_del_prestamo` int(11) default '0',
  `fld_fecha_entrega_cuotas` date default NULL,
  `fld_fecha_termina_cuotas` date default NULL,
  `fld_fecha_ultimo_abono_cuotas` date default NULL,
  `fld_capital_cuota` double(12,2) default NULL,
  `fld_interes_cuota` double(12,2) default NULL,
  `fld_monto_cuotas` double(12,2) default NULL,
  `fld_abono_cuotas` double(12,2) default NULL,
  `fld_balance_cuotas` double(12,2) default NULL,
  `fld_usuario_cuotas` varchar(255) character set utf8 default 'N/A',
  `fld_status_cuotas` varchar(255) character set utf8 default 'N/A',
  `fld_pendiente_amortizar` double(12,3) default '0.000',
  `fld_total_amortizado` double(12,3) default '0.000',
  `fld_capital_cuota_abono` double(12,2) default '0.00',
  `fld_capital_cuota_balance` double(12,2) default '0.00',
  `fld_interes_cuota_abono` double(12,2) default '0.00',
  `fld_interes_cuota_balance` double(12,2) default '0.00',
  `fld_ultimo_abono_interes` double(12,2) default '0.00',
  `fld_ultimo_abono_capital` double(12,2) default '0.00',
  `fld_monto_mora` double(12,2) default '0.00',
  `fld_abono_mora` double(12,2) default '0.00',
  `fld_balance_mora` double(12,2) default '0.00',
  `fld_ultimo_abono_mora` double(12,2) default '0.00',
  `fld_dias_vencimiento` int(11) default '0',
  `fld_atraso_cuotas` double(12,2) default '0.00',
  `fld_tipo_cuotas` varchar(255) character set utf8 default 'MENSUAL',
  `fld_bce_prestamo` double(12,2) default '0.00',
  `fld_cant_cuotas` double(12,2) default '0.00',
  `fldchk` varchar(6) character set utf8 default 'True',
  `fld_termina_calculo_interes` varchar(6) character set utf8 default 'False',
  `fld_fecha_calculo_interes` date default NULL,
  PRIMARY KEY  (`fld_id_cuotas`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_tabla_cuotas`
--

LOCK TABLES `tbl_tabla_cuotas` WRITE;
/*!40000 ALTER TABLE `tbl_tabla_cuotas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_tabla_cuotas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tabla_prestamos`
--

DROP TABLE IF EXISTS `tbl_tabla_prestamos`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_tabla_prestamos` (
  `fld_id_prestamos` int(11) NOT NULL auto_increment,
  `fld_id_del_cliente` int(11) default NULL,
  `fld_socio` char(50) NOT NULL default 'N/A',
  `fld_socio_rnc` char(50) NOT NULL default 'N/A',
  `fld_clasificacion` varchar(55) character set utf8 default 'N/A',
  `fld_fecha_entrega` date default NULL,
  `fld_fecha_termina` date default NULL,
  `fld_fecha_calcula_interes` date default NULL,
  `fld_cantidad_cuotas` int(11) default '0',
  `fld_monto_cuotas_a` double(12,4) default '0.0000',
  `fld_capital_prestamo` double(12,4) default '0.0000',
  `fld_monto` double(12,4) default '0.0000',
  `fld_abono` double(12,4) default '0.0000',
  `fld_balance` double(12,4) default '0.0000',
  `fld_usuario` varchar(255) character set utf8 default 'sixa',
  `fld_fecha_ultimo_abono` date default NULL,
  `fld_status_prestamos` varchar(15) character set utf8 default 'Nuevo',
  `fld_anos` double(12,4) default '0.0000',
  `fld_interes_p` double(12,4) default '0.0000',
  `fld_tipo_prestamo` varchar(255) character set utf8 default 'MANSUAL',
  `fld_ck_no` varchar(11) character set utf8 default '0',
  `fld_tipo_garantia` varchar(50) character set utf8 default 'N/A',
  `fld_garantia` varchar(1500) character set utf8 default 'N/A',
  `fldFinanciamiento` varchar(2) character set utf8 default 'SI',
  `fldMontoFinan` double(12,4) default '0.0000',
  `fldMontoInicial` double(12,4) default '0.0000',
  `fldCodInm` int(11) default '0',
  `fldDescInm` varchar(255) character set utf8 default 'N/A',
  `fldMetros` double(12,4) default '0.0000',
  `fldPrecioMetro` double(12,4) default '0.0000',
  `fldTazaMora` double(12,2) default '0.00',
  `fldNota` varchar(1001) character set utf8 default 'N/A',
  PRIMARY KEY  (`fld_id_prestamos`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_tabla_prestamos`
--

LOCK TABLES `tbl_tabla_prestamos` WRITE;
/*!40000 ALTER TABLE `tbl_tabla_prestamos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_tabla_prestamos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_tipos_documentos`
--

DROP TABLE IF EXISTS `tbl_tipos_documentos`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_tipos_documentos` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(150) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_tipos_documentos`
--

LOCK TABLES `tbl_tipos_documentos` WRITE;
/*!40000 ALTER TABLE `tbl_tipos_documentos` DISABLE KEYS */;
INSERT INTO `tbl_tipos_documentos` VALUES (1,'CEDULA '),(2,'RNC '),(3,'PASAPORTE ');
/*!40000 ALTER TABLE `tbl_tipos_documentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_urbanizacion`
--

DROP TABLE IF EXISTS `tbl_urbanizacion`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_urbanizacion` (
  `fldCodigo` int(11) NOT NULL auto_increment,
  `fldDescripcion` varchar(255) default NULL,
  PRIMARY KEY  (`fldCodigo`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_urbanizacion`
--

LOCK TABLES `tbl_urbanizacion` WRITE;
/*!40000 ALTER TABLE `tbl_urbanizacion` DISABLE KEYS */;
INSERT INTO `tbl_urbanizacion` VALUES (1,'N/A'),(2,'Sector 1'),(3,'Sector 2');
/*!40000 ALTER TABLE `tbl_urbanizacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_user`
--

DROP TABLE IF EXISTS `tbl_user`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_user` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_UserID` varchar(50) default NULL,
  `fld_Password` varchar(15) default NULL,
  `fld_cargo` varchar(50) default NULL,
  `fld_FirstName` varchar(50) default NULL,
  `fld_LastName` varchar(50) default NULL,
  `fld_departamento` varchar(50) default NULL,
  `fld_Status` varchar(50) default NULL,
  `fld_Created` varchar(19) default NULL,
  `fld_tipo` varchar(50) default NULL,
  `IDRol` int(11) default NULL,
  PRIMARY KEY  (`fld_id`),
  KEY `fld_id` (`fld_id`),
  KEY `fld_UserID` (`fld_UserID`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_user`
--

LOCK TABLES `tbl_user` WRITE;
/*!40000 ALTER TABLE `tbl_user` DISABLE KEYS */;
INSERT INTO `tbl_user` VALUES (1,'RANDY','2494','ENC. INFORMATICA','D&R','TECHNOLOGY','INFORMATICA','N','2020-10-26 15:23:44','ADMINISTRADOR (A)',1);
/*!40000 ALTER TABLE `tbl_user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_user_rol`
--

DROP TABLE IF EXISTS `tbl_user_rol`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_user_rol` (
  `ID` int(11) NOT NULL auto_increment,
  `Rol` char(50) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_user_rol`
--

LOCK TABLES `tbl_user_rol` WRITE;
/*!40000 ALTER TABLE `tbl_user_rol` DISABLE KEYS */;
INSERT INTO `tbl_user_rol` VALUES (1,'Administrador'),(2,'Usuario');
/*!40000 ALTER TABLE `tbl_user_rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_userahorros`
--

DROP TABLE IF EXISTS `tbl_userahorros`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_userahorros` (
  `ID` int(11) NOT NULL auto_increment,
  `IDUsuario` int(11) default NULL,
  `mnuAhorros` varchar(5) default 'true',
  `mnuAhorrosNuevo` varchar(5) default 'true',
  `mnuAhorrosRealizarRetiros` varchar(5) default 'true',
  `mnuAhorrosEstadoCuenta` varchar(5) default 'true',
  `mnuAhorrosRetiros` varchar(5) default 'true',
  `mnuAhorrosSaldos` varchar(5) default 'true',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1 CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_userahorros`
--

LOCK TABLES `tbl_userahorros` WRITE;
/*!40000 ALTER TABLE `tbl_userahorros` DISABLE KEYS */;
INSERT INTO `tbl_userahorros` VALUES (1,1,'True','True','True','True','True','True');
/*!40000 ALTER TABLE `tbl_userahorros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_userarchivo`
--

DROP TABLE IF EXISTS `tbl_userarchivo`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_userarchivo` (
  `ID` int(11) NOT NULL auto_increment,
  `IDUsuario` int(11) default NULL,
  `mnuPermisosUsuarios` varchar(5) default 'True',
  `mnuArchivo` varchar(5) default 'True',
  `mnuCambiarMiClave` varchar(5) default 'True',
  `mnuCambiarUsuario` varchar(5) default 'True',
  `mnuFormatoCheque` varchar(5) default 'True',
  `mnuTimbrado` varchar(5) default 'True',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_userarchivo`
--

LOCK TABLES `tbl_userarchivo` WRITE;
/*!40000 ALTER TABLE `tbl_userarchivo` DISABLE KEYS */;
INSERT INTO `tbl_userarchivo` VALUES (1,1,'True','True','True','True','True','True');
/*!40000 ALTER TABLE `tbl_userarchivo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_userbanco`
--

DROP TABLE IF EXISTS `tbl_userbanco`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_userbanco` (
  `ID` int(11) NOT NULL auto_increment,
  `IDUsuario` int(11) default NULL,
  `mnuBanco` varchar(5) default 'True',
  `mnuMaestroBanco` varchar(5) default 'True',
  `mnuDiarioBanco` varchar(5) default 'True',
  `mnuDiarioBancoSolicitud` varchar(5) default 'True',
  `mnuDiarioBancoCheque` varchar(5) default 'True',
  `mnuDiarioBancoDeposito` varchar(5) default 'True',
  `mnuDiarioBancoND` varchar(5) default 'True',
  `mnuDiarioBancoNC` varchar(5) default 'True',
  `mnuDiarioBancoCargosComisiones` varchar(5) default 'True',
  `mnuConciliacion` varchar(5) default 'True',
  `repEstadoBanco` varchar(5) default 'True',
  `repDepositos` varchar(5) default 'True',
  `repCheques` varchar(5) default 'True',
  `repNCBanco` varchar(5) default 'True',
  `repNDBanco` varchar(5) default 'True',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_userbanco`
--

LOCK TABLES `tbl_userbanco` WRITE;
/*!40000 ALTER TABLE `tbl_userbanco` DISABLE KEYS */;
INSERT INTO `tbl_userbanco` VALUES (1,1,'True','True','True','True','True','True','True','True','True','True','True','True','True','True','True');
/*!40000 ALTER TABLE `tbl_userbanco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_userbarraherramienta`
--

DROP TABLE IF EXISTS `tbl_userbarraherramienta`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_userbarraherramienta` (
  `ID` int(11) NOT NULL auto_increment,
  `IDUsuario` int(11) default NULL,
  `ToolBar` varchar(5) default 'True',
  `b_clientes` varchar(5) default 'True',
  `b_prestasmos` varchar(5) default 'True',
  `b_nd_cxc` varchar(5) default 'True',
  `b_ri` varchar(5) default 'True',
  `b_nc_cxc` varchar(5) default 'True',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_userbarraherramienta`
--

LOCK TABLES `tbl_userbarraherramienta` WRITE;
/*!40000 ALTER TABLE `tbl_userbarraherramienta` DISABLE KEYS */;
INSERT INTO `tbl_userbarraherramienta` VALUES (1,1,'True','True','True','True','True','True');
/*!40000 ALTER TABLE `tbl_userbarraherramienta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_usercaja`
--

DROP TABLE IF EXISTS `tbl_usercaja`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_usercaja` (
  `ID` int(11) NOT NULL auto_increment,
  `IDUsuario` int(11) default NULL,
  `mnuCaja` varchar(5) default 'True',
  `mnuRecibosIngresos` varchar(5) default 'True',
  `mnuOtrosIngresos` varchar(5) default 'True',
  `mnuConsultaIngresos` varchar(5) default 'True',
  `mnuEgresos` varchar(5) default 'True',
  `mnuCuadreCaja` varchar(5) default 'True',
  `repRecibosIngresos` varchar(5) default 'True',
  `repRecibosIngresosNulos` varchar(5) default 'True',
  `repEgresosCaja` varchar(5) default 'True',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_usercaja`
--

LOCK TABLES `tbl_usercaja` WRITE;
/*!40000 ALTER TABLE `tbl_usercaja` DISABLE KEYS */;
INSERT INTO `tbl_usercaja` VALUES (1,1,'True','True','True','True','True','True','True','True','True');
/*!40000 ALTER TABLE `tbl_usercaja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_usercuentaporcobrar`
--

DROP TABLE IF EXISTS `tbl_usercuentaporcobrar`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_usercuentaporcobrar` (
  `ID` int(11) NOT NULL auto_increment,
  `IDUsuario` int(11) default NULL,
  `mnuCuentaPorCobrar` varchar(5) default 'True',
  `mnuGeneraRecibos` varchar(5) default 'True',
  `mnuCxCND` varchar(5) default 'True',
  `mnuCxCNC` varchar(5) default 'True',
  `mnuConsultaCxCNC` varchar(5) default 'True',
  `repEstadoCliente` varchar(5) default 'True',
  `repNDCxC` varchar(5) default 'True',
  `repNCCxC` varchar(5) default 'True',
  `repCuentaPorCobrar` varchar(5) default 'True',
  `repCuentaPorCobrarCuotasFechas` varchar(5) default 'True',
  `repCuentaPorCobrarCapital` varchar(5) default 'True',
  `repCuentaPorCobrarIntes` varchar(5) default 'True',
  `repTodosClientes` varchar(5) default 'True',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_usercuentaporcobrar`
--

LOCK TABLES `tbl_usercuentaporcobrar` WRITE;
/*!40000 ALTER TABLE `tbl_usercuentaporcobrar` DISABLE KEYS */;
INSERT INTO `tbl_usercuentaporcobrar` VALUES (1,1,'True','True','True','True','True','True','True','True','True','True','True','True','True');
/*!40000 ALTER TABLE `tbl_usercuentaporcobrar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_usercuentaporpagar`
--

DROP TABLE IF EXISTS `tbl_usercuentaporpagar`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_usercuentaporpagar` (
  `ID` int(11) NOT NULL auto_increment,
  `IDUsuario` int(11) default NULL,
  `mnuCuentaPorPagar` varchar(5) default 'True',
  `mnuProveedores` varchar(5) default 'True',
  `mnuIngresosCajaCxP` varchar(5) default 'True',
  `mnuCxPND` varchar(5) default 'True',
  `mnuCxPNC` varchar(5) default 'True',
  `repEstadoProveedor` varchar(5) default 'True',
  `repCuentaPorPagar` varchar(5) default 'True',
  `repNDCuentaPorPagar` varchar(5) default 'True',
  `repNCCuentaPorPagar` varchar(5) default 'True',
  `repTodoProveedores` varchar(5) default 'True',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_usercuentaporpagar`
--

LOCK TABLES `tbl_usercuentaporpagar` WRITE;
/*!40000 ALTER TABLE `tbl_usercuentaporpagar` DISABLE KEYS */;
INSERT INTO `tbl_usercuentaporpagar` VALUES (1,1,'True','True','True','True','True','True','True','True','True','True');
/*!40000 ALTER TABLE `tbl_usercuentaporpagar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_usermantenimiento`
--

DROP TABLE IF EXISTS `tbl_usermantenimiento`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_usermantenimiento` (
  `ID` int(11) NOT NULL auto_increment,
  `IDUsuario` int(11) default NULL,
  `mnuMantenimiento` varchar(5) default 'True',
  `mnuCliente` varchar(5) default 'True',
  `mnuInmuebles` varchar(5) default 'True',
  `mnuUsuarioNuevo` varchar(5) default 'True',
  `mnuCobradores` varchar(5) default 'True',
  `mnuZonas` varchar(5) default 'True',
  `mnuUrbanizaciones` varchar(5) default 'True',
  `mnuCiudad` varchar(5) default 'True',
  `mnuProvincias` varchar(5) default 'True',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_usermantenimiento`
--

LOCK TABLES `tbl_usermantenimiento` WRITE;
/*!40000 ALTER TABLE `tbl_usermantenimiento` DISABLE KEYS */;
INSERT INTO `tbl_usermantenimiento` VALUES (1,1,'True','True','True','True','True','True','True','True','True');
/*!40000 ALTER TABLE `tbl_usermantenimiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_userprestamos`
--

DROP TABLE IF EXISTS `tbl_userprestamos`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tbl_userprestamos` (
  `ID` int(11) NOT NULL auto_increment,
  `IDUsuario` int(11) default NULL,
  `mnuPrestamos` varchar(5) default 'True',
  `mnuPrestamosNuevo` varchar(5) default 'True',
  `repPrestamosEntregados` varchar(5) default 'True',
  `repPrestamosPendientes` varchar(5) default 'True',
  `repPrestamosSaldados` varchar(5) default 'True',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tbl_userprestamos`
--

LOCK TABLES `tbl_userprestamos` WRITE;
/*!40000 ALTER TABLE `tbl_userprestamos` DISABLE KEYS */;
INSERT INTO `tbl_userprestamos` VALUES (1,1,'True','True','True','True','True');
/*!40000 ALTER TABLE `tbl_userprestamos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblvalorespredeterminados`
--

DROP TABLE IF EXISTS `tblvalorespredeterminados`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tblvalorespredeterminados` (
  `ID` int(11) NOT NULL auto_increment,
  `InteresPrestamo` decimal(12,2) default '0.00',
  `InteresMora` decimal(12,2) default '0.00',
  `TipoInteresPrestamos` varchar(255) default 'n/a',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tblvalorespredeterminados`
--

LOCK TABLES `tblvalorespredeterminados` WRITE;
/*!40000 ALTER TABLE `tblvalorespredeterminados` DISABLE KEYS */;
INSERT INTO `tblvalorespredeterminados` VALUES (1,'2.00','5.00','Int. y Capital Fijos');
/*!40000 ALTER TABLE `tblvalorespredeterminados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tlb_segundo_titular_cta_ahorros`
--

DROP TABLE IF EXISTS `tlb_segundo_titular_cta_ahorros`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `tlb_segundo_titular_cta_ahorros` (
  `fldCod2doTitular` int(11) NOT NULL auto_increment,
  `fldIdAhorro` int(11) default NULL,
  `fldCodSocio` int(11) default NULL,
  `fldNombre2doTitular` varchar(100) default NULL,
  `fldCedula2doTitular` varchar(16) default NULL,
  `fldTelefono2doTitular` varchar(14) default NULL,
  `fldCelular2doTitular` varchar(14) default NULL,
  `fldWhatsapp2doTitular` varchar(14) default NULL,
  `fldNotas2doTitular` varchar(255) default NULL,
  PRIMARY KEY  (`fldCod2doTitular`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `tlb_segundo_titular_cta_ahorros`
--

LOCK TABLES `tlb_segundo_titular_cta_ahorros` WRITE;
/*!40000 ALTER TABLE `tlb_segundo_titular_cta_ahorros` DISABLE KEYS */;
/*!40000 ALTER TABLE `tlb_segundo_titular_cta_ahorros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `traspaso`
--

DROP TABLE IF EXISTS `traspaso`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `traspaso` (
  `ID` int(11) NOT NULL auto_increment,
  `IDClienteViejo` int(11) default '0',
  `IDClienteNuevo` int(11) default '0',
  `Fecha` datetime default NULL,
  `IDVehiculo` int(11) default '0',
  `IDFinanciamiento` int(11) default '0',
  `Monto` decimal(12,2) default '0.00',
  `Usuario` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `traspaso`
--

LOCK TABLES `traspaso` WRITE;
/*!40000 ALTER TABLE `traspaso` DISABLE KEYS */;
/*!40000 ALTER TABLE `traspaso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiculocarcteristica`
--

DROP TABLE IF EXISTS `vehiculocarcteristica`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `vehiculocarcteristica` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `vehiculocarcteristica`
--

LOCK TABLES `vehiculocarcteristica` WRITE;
/*!40000 ALTER TABLE `vehiculocarcteristica` DISABLE KEYS */;
/*!40000 ALTER TABLE `vehiculocarcteristica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiculochasis`
--

DROP TABLE IF EXISTS `vehiculochasis`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `vehiculochasis` (
  `ID` int(11) NOT NULL auto_increment,
  `FechaCreado` date default NULL,
  `IDTipo` int(11) default '0',
  `IDMarca` int(11) default '0',
  `IDModelo` int(11) default '0',
  `Chasis` varchar(255) default NULL,
  `IDEstado` int(11) default '0',
  `IDColor` int(11) default '0',
  `IDTransmision` int(11) default '0',
  `IDTraccion` int(11) default '0',
  `Kilometraje` int(11) default '0',
  `Ano` int(4) default NULL,
  `Importado` varchar(2) default 'NO',
  `Costo` decimal(12,2) default '0.00',
  `Precio` decimal(12,2) default '0.00',
  `PrecioImpuesto` decimal(12,2) default '0.00',
  `Nota` varchar(1500) default '0',
  `Estado` varchar(50) default '0',
  `Caracteristicas` varchar(255) default '-',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `vehiculochasis`
--

LOCK TABLES `vehiculochasis` WRITE;
/*!40000 ALTER TABLE `vehiculochasis` DISABLE KEYS */;
/*!40000 ALTER TABLE `vehiculochasis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiculocolor`
--

DROP TABLE IF EXISTS `vehiculocolor`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `vehiculocolor` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `vehiculocolor`
--

LOCK TABLES `vehiculocolor` WRITE;
/*!40000 ALTER TABLE `vehiculocolor` DISABLE KEYS */;
INSERT INTO `vehiculocolor` VALUES (6,'NEGRO'),(2,'BLANCO'),(3,'AZUL'),(4,'ROJO'),(5,'MAMEY');
/*!40000 ALTER TABLE `vehiculocolor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiculoestado`
--

DROP TABLE IF EXISTS `vehiculoestado`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `vehiculoestado` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `vehiculoestado`
--

LOCK TABLES `vehiculoestado` WRITE;
/*!40000 ALTER TABLE `vehiculoestado` DISABLE KEYS */;
INSERT INTO `vehiculoestado` VALUES (1,'NUEVO'),(2,'USUADO'),(3,'SEMINUEVO');
/*!40000 ALTER TABLE `vehiculoestado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiculomarca`
--

DROP TABLE IF EXISTS `vehiculomarca`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `vehiculomarca` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `vehiculomarca`
--

LOCK TABLES `vehiculomarca` WRITE;
/*!40000 ALTER TABLE `vehiculomarca` DISABLE KEYS */;
/*!40000 ALTER TABLE `vehiculomarca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiculomodelo`
--

DROP TABLE IF EXISTS `vehiculomodelo`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `vehiculomodelo` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  `IDMarca` int(11) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `vehiculomodelo`
--

LOCK TABLES `vehiculomodelo` WRITE;
/*!40000 ALTER TABLE `vehiculomodelo` DISABLE KEYS */;
/*!40000 ALTER TABLE `vehiculomodelo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiculotipo`
--

DROP TABLE IF EXISTS `vehiculotipo`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `vehiculotipo` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `vehiculotipo`
--

LOCK TABLES `vehiculotipo` WRITE;
/*!40000 ALTER TABLE `vehiculotipo` DISABLE KEYS */;
INSERT INTO `vehiculotipo` VALUES (1,'AUTOMÃ“VIL'),(2,'CAMIONETA'),(3,'JEEPETA'),(4,'OTROS'),(5,'MOTOCICLETA');
/*!40000 ALTER TABLE `vehiculotipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiculotraccion`
--

DROP TABLE IF EXISTS `vehiculotraccion`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `vehiculotraccion` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `vehiculotraccion`
--

LOCK TABLES `vehiculotraccion` WRITE;
/*!40000 ALTER TABLE `vehiculotraccion` DISABLE KEYS */;
INSERT INTO `vehiculotraccion` VALUES (2,'DELANTERA'),(3,'TRASERA'),(4,'2WD'),(5,'4WD'),(6,'4WD FULL TIME');
/*!40000 ALTER TABLE `vehiculotraccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiculotransmision`
--

DROP TABLE IF EXISTS `vehiculotransmision`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `vehiculotransmision` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `vehiculotransmision`
--

LOCK TABLES `vehiculotransmision` WRITE;
/*!40000 ALTER TABLE `vehiculotransmision` DISABLE KEYS */;
INSERT INTO `vehiculotransmision` VALUES (1,'AUTOMATICA'),(5,'MECANICA'),(3,'SINCRONIZADA'),(4,'SEMISINCRONIZADA');
/*!40000 ALTER TABLE `vehiculotransmision` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vendedor`
--

DROP TABLE IF EXISTS `vendedor`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `vendedor` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  `Comision` decimal(12,2) default '0.00',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `vendedor`
--

LOCK TABLES `vendedor` WRITE;
/*!40000 ALTER TABLE `vendedor` DISABLE KEYS */;
INSERT INTO `vendedor` VALUES (1,'LOCAL','2.20'),(2,'ALEXIS','5.00');
/*!40000 ALTER TABLE `vendedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `venta` (
  `ID` int(11) NOT NULL auto_increment,
  `DocNo` int(11) default NULL,
  `Fecha` datetime default NULL,
  `IDCliente` int(11) default NULL,
  `IDCondicion` int(11) default NULL,
  `IDTipoNCF` int(11) default NULL,
  `NCF` varchar(19) default NULL,
  `IDFormaPago` int(11) default NULL,
  `DescripcionPago` varchar(255) default NULL,
  `IDVendedor` int(11) default NULL,
  `IDMoneda` int(11) default NULL,
  `Nota` varchar(255) default NULL,
  `IDUsuario` varchar(255) default NULL,
  `IDAlmacen` int(11) default NULL,
  `Monto` decimal(12,2) default NULL,
  `Itbis` decimal(12,2) default NULL,
  `Descuento` decimal(12,2) default NULL,
  `Abono` decimal(12,2) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventacondicion`
--

DROP TABLE IF EXISTS `ventacondicion`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `ventacondicion` (
  `ID` int(11) NOT NULL auto_increment,
  `Descripcion` varchar(255) default NULL,
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `ventacondicion`
--

LOCK TABLES `ventacondicion` WRITE;
/*!40000 ALTER TABLE `ventacondicion` DISABLE KEYS */;
INSERT INTO `ventacondicion` VALUES (1,'CONTADO'),(2,'CREDITO');
/*!40000 ALTER TABLE `ventacondicion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventadetallefinanciamiento`
--

DROP TABLE IF EXISTS `ventadetallefinanciamiento`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `ventadetallefinanciamiento` (
  `ID` int(11) NOT NULL auto_increment,
  `IDTipo` int(11) default '0',
  `IDMarca` int(11) default '0',
  `IDModelo` int(11) default '0',
  `Chasis` varchar(255) default NULL,
  `IDEstado` int(11) default '0',
  `IDColor` int(11) default '0',
  `IDTransmision` int(11) default '0',
  `IDTraccion` int(11) default '0',
  `Kilometraje` int(11) default '0',
  `Ano` int(4) default NULL,
  `Importado` varchar(2) default 'NO',
  `Costo` decimal(12,2) default '0.00',
  `Precio` decimal(12,2) default '0.00',
  `PrecioImpuesto` decimal(12,2) default '0.00',
  `Nota` varchar(1500) default '0',
  `Estado` varchar(50) default '0',
  `Caracteristicas` varchar(255) default '-',
  `IDVenta` int(11) default '0',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `ventadetallefinanciamiento`
--

LOCK TABLES `ventadetallefinanciamiento` WRITE;
/*!40000 ALTER TABLE `ventadetallefinanciamiento` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventadetallefinanciamiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `ventaview`
--

DROP TABLE IF EXISTS `ventaview`;
/*!50001 DROP VIEW IF EXISTS `ventaview`*/;
/*!50001 CREATE TABLE `ventaview` (
  `ID` int(11),
  `DocNo` int(11),
  `Fecha` datetime,
  `fld_FullName` varchar(255),
  `fld_apodo` varchar(55),
  `fld_Identity` varchar(16),
  `fld_Phone` varchar(255),
  `fld_Phone2` varchar(255),
  `fld_Address` varchar(255),
  `fld_City` varchar(55),
  `Condicion` varchar(255),
  `TipoNCF` varchar(255),
  `NCF` varchar(19),
  `FormaPago` varchar(255),
  `DescripcionPago` varchar(255),
  `Vendedor` varchar(255),
  `Comision` decimal(12,2),
  `Moneda` varchar(255),
  `tasa` decimal(12,2),
  `NotaVenta` varchar(255),
  `Almacen` varchar(255),
  `Monto` decimal(12,2),
  `Itbis` decimal(12,2),
  `Descuento` decimal(12,2),
  `Abono` decimal(12,2),
  `TipoVehiculo` varchar(255),
  `Marca` varchar(255),
  `Modelo` varchar(255),
  `Chasis` varchar(255),
  `EstadoVehiculo` varchar(255),
  `Color` varchar(255),
  `Transmision` varchar(255),
  `Traccion` varchar(255),
  `Kilometraje` int(11),
  `Ano` int(4),
  `Importado` varchar(2),
  `Nota` varchar(1500),
  `Caracteristicas` varchar(255)
) */;

--
-- Temporary table structure for view `view_ahorros`
--

DROP TABLE IF EXISTS `view_ahorros`;
/*!50001 DROP VIEW IF EXISTS `view_ahorros`*/;
/*!50001 CREATE TABLE `view_ahorros` (
  `ID` int(11),
  `IDCliente` int(11),
  `CuentaNo` varchar(15),
  `FechaApertura` date,
  `FechaCancelada` date,
  `TasaIteres` decimal(12,4),
  `SaldoCapital` decimal(12,4),
  `SaldoInteres` decimal(12,4),
  `SaldoRetiros` decimal(12,4),
  `Usuario` varchar(100),
  `Nota` varchar(550),
  `Categoria` int(11),
  `Estado` varchar(50),
  `Descripcion` varchar(150),
  `fld_id` int(11),
  `TipoDocumento` int(11),
  `fld_FullName` varchar(255),
  `fld_apodo` varchar(55),
  `fld_Identity` varchar(16),
  `fld_Phone` varchar(255),
  `fld_Phone2` varchar(255),
  `fld_Address` varchar(255),
  `fld_City_id` int(11),
  `fld_City` varchar(55),
  `fld_Status` varchar(6),
  `fld_bce` double(11,2),
  `fld_cod_zona` int(11),
  `fld_zona` varchar(255),
  `fld_nombre_con` varchar(55),
  `fld_apodo_con` varchar(55),
  `fld_cedula_con` varchar(16),
  `fld_telefono_con` varchar(14),
  `fld_celular_con` varchar(13),
  `fld_ref_personales_cliente` varchar(510),
  `fld_ref_comerciales_cliente` varchar(510),
  `fld_nombre_gar` varchar(55),
  `fld_apodo_gar` varchar(55),
  `fld_cedula_gar` varchar(16),
  `fld_telefono_gar` varchar(13),
  `fld_celular_gar` varchar(13),
  `fld_direccion_gar` varchar(255),
  `fld_ciudad_gar` varchar(55),
  `fld_ref_personales_gar` varchar(510),
  `fld_ref_comerciales_gar` varchar(510),
  `fld_ingresos_mesuales` double(12,2),
  `fld_nombre_banco1` varchar(1000),
  `fld_cuenta_banco1` varchar(15),
  `fld_nombre_banco2` varchar(1000),
  `fld_cuenta_banco2` varchar(15),
  `fld_otra_informacion` varchar(1000),
  `fld_nombre_con_gar` varchar(55),
  `fld_apodo_con_gar` varchar(55),
  `fld_cedula_con_gar` varchar(16),
  `fld_telefono_con_gar` varchar(13),
  `fld_celular_con_gar` varchar(13),
  `fld_edad` date,
  `fld_estado_civil` varchar(15),
  `fld_edad_gar` int(50),
  `fld_estado_civil_gar` varchar(15),
  `fld_ocupacion_cliente` varchar(55),
  `fld_ocupacion_gar` varchar(55),
  `fld_sector_id` int(11),
  `fld_sector` varchar(255),
  `fld_categoria` varchar(25),
  `fld_limite` double(12,2),
  `Puesto` varchar(100),
  `TimpoTrabajo` varchar(100),
  `ReferidoPor` varchar(100),
  `Oriundo` varchar(100),
  `DataCredito` int(1),
  `idAhorro` int(11),
  `idcuenta` int(11),
  `Deposito` decimal(12,4),
  `Fecha` date
) */;

--
-- Temporary table structure for view `view_ahorros_depositos`
--

DROP TABLE IF EXISTS `view_ahorros_depositos`;
/*!50001 DROP VIEW IF EXISTS `view_ahorros_depositos`*/;
/*!50001 CREATE TABLE `view_ahorros_depositos` (
  `ID` int(11),
  `Fecha` date,
  `IDCuenta` int(11),
  `IDCliente` int(11),
  `Monto` decimal(12,4),
  `Notas` varchar(550),
  `Usuario` varchar(100),
  `IdCaja` int(11),
  `Dosmil` double(12,2),
  `Mil` double(12,2),
  `Quiniento` double(12,2),
  `DosCiento` double(12,2),
  `Cien` double(12,2),
  `Cincuenta` double(12,2),
  `Veinticinco` double(12,2),
  `Diez` double(12,2),
  `Cinco` double(12,2),
  `Cheque` double(12,2),
  `Uno` double(12,2),
  `fld_id` int(11),
  `TipoDocumento` int(11),
  `fld_FullName` varchar(255),
  `fld_apodo` varchar(55),
  `fld_Identity` varchar(16),
  `fld_Phone` varchar(255),
  `fld_Phone2` varchar(255),
  `fld_Address` varchar(255),
  `fld_City_id` int(11),
  `fld_City` varchar(55),
  `fld_Status` varchar(6),
  `fld_bce` double(11,2),
  `fld_cod_zona` int(11),
  `fld_zona` varchar(255),
  `fld_nombre_con` varchar(55),
  `fld_apodo_con` varchar(55),
  `fld_cedula_con` varchar(16),
  `fld_telefono_con` varchar(14),
  `fld_celular_con` varchar(13),
  `fld_ref_personales_cliente` varchar(510),
  `fld_ref_comerciales_cliente` varchar(510),
  `fld_nombre_gar` varchar(55),
  `fld_apodo_gar` varchar(55),
  `fld_cedula_gar` varchar(16),
  `fld_telefono_gar` varchar(13),
  `fld_celular_gar` varchar(13),
  `fld_direccion_gar` varchar(255),
  `fld_ciudad_gar` varchar(55),
  `fld_ref_personales_gar` varchar(510),
  `fld_ref_comerciales_gar` varchar(510),
  `fld_ingresos_mesuales` double(12,2),
  `fld_nombre_banco1` varchar(1000),
  `fld_cuenta_banco1` varchar(15),
  `fld_nombre_banco2` varchar(1000),
  `fld_cuenta_banco2` varchar(15),
  `fld_otra_informacion` varchar(1000),
  `fld_nombre_con_gar` varchar(55),
  `fld_apodo_con_gar` varchar(55),
  `fld_cedula_con_gar` varchar(16),
  `fld_telefono_con_gar` varchar(13),
  `fld_celular_con_gar` varchar(13),
  `fld_edad` date,
  `fld_estado_civil` varchar(15),
  `fld_edad_gar` int(50),
  `fld_estado_civil_gar` varchar(15),
  `fld_ocupacion_cliente` varchar(55),
  `fld_ocupacion_gar` varchar(55),
  `fld_sector_id` int(11),
  `fld_sector` varchar(255),
  `fld_categoria` varchar(25),
  `fld_limite` double(12,2),
  `Puesto` varchar(100),
  `TimpoTrabajo` varchar(100),
  `ReferidoPor` varchar(100),
  `Oriundo` varchar(100),
  `DataCredito` int(1),
  `ctaContable` char(200),
  `email` varchar(255),
  `fechaIngreso` date,
  `whatsapp` varchar(13),
  `whatsapp_con` varchar(13),
  `parentezco_gar` varchar(20),
  `fecha_nac_gar` date,
  `whatsapp_gar` varchar(13),
  `email_gar` varchar(255),
  `empresa_gar` varchar(50),
  `telefono_Empresa_gar` varchar(13),
  `agno_labor_gar` int(50),
  `salario_gar` double(10,2),
  `whatsapp_con_gar` varchar(13),
  `fld_ref_parentesco_clie1` varchar(20),
  `fld_ced_ref_personal_clie1` varchar(16),
  `fld_tel_ref_personal_clie1` varchar(13),
  `fld_cel_ref_personal_clie1` varchar(13),
  `fld_whatsapp_ref_personal_clie1` varchar(13),
  `fld_ref_personal_clie2` varchar(50),
  `fld_ref_parentesco_clie2` varchar(20),
  `fld_ced_ref_personal_clie2` varchar(16),
  `fld_tel_ref_personal_clie2` varchar(13),
  `fld_cel_ref_personal_clie2` varchar(13),
  `fld_whatsapp_ref_personal_clie2` varchar(13),
  `Fld_Dir_Ref_Com_Clie1` varchar(255),
  `Fld_Rnc_Refe_Com_Clie1` varchar(9),
  `Fld_Tel_Com_clie1` varchar(13),
  `Fld_Whatsapp_Com_Clie1` varchar(13),
  `fld_ref_comerciales_cliente2` varchar(50),
  `Fld_Dir_Ref_Com_Clie2` varchar(255),
  `Fld_Rnc_Refe_Com_Clie2` varchar(9),
  `Fld_Tel_Com_clie2` varchar(13),
  `Fld_Whatsapp_Com_Clie2` varchar(13),
  `fld_parentesco_ref_gar1` varchar(20),
  `fld_cedula_ref_gar1` varchar(16),
  `fld_tel_ref_gar1` varchar(13),
  `fld_cel_ref_gar1` varchar(13),
  `fld_whatsapp_ref_gar1` varchar(13),
  `fld_ref_personal_gar2` varchar(50),
  `fld_parentesco_ref_gar2` varchar(20),
  `fld_cedula_ref_gar2` varchar(16),
  `fld_tel_ref_gar2` varchar(13),
  `fld_cel_ref_gar2` varchar(13),
  `fld_whatsapp_ref_gar2` varchar(13),
  `Fdl_Dir_Emp_Gar1` varchar(255),
  `Fld_Rnc_Emp_Gar1` varchar(11),
  `Fld_Tel_Emp_Gar1` varchar(13),
  `Fld_Whatsapp_emp_Gar1` varchar(13),
  `Fld_Empra_Gar2` varchar(50),
  `Fld_Dir_Emp_Gar2` varchar(255),
  `Fld_Rnc_Emp_Gar2` varchar(11),
  `Fld_Tel_Emp_Gar2` varchar(13),
  `Fld_Whatsapp_Emp_Gar2` varchar(13),
  `fld_nom_ref_flia_clie1` varchar(50),
  `fld_parentesco_ref_flia_clie1` varchar(50),
  `fld_ced_ref_flia_clie1` varchar(16),
  `fld_tel_ref_flia_clie1` varchar(13),
  `fld_cel_ref_flia_clie1` varchar(13),
  `fld_whatsapp_ref_flia_clie1` varchar(13),
  `fld_nom_ref_flia_clie2` varchar(50),
  `fld_parentesco_ref_flia_clie2` varchar(20),
  `fld_ced_ref_flia_clie2` varchar(16),
  `fld_tel_ref_flia_clie2` varchar(13),
  `fld_cel_ref_flia_clie2` varchar(13),
  `fld_whats_ref_flia_clie2` varchar(13),
  `fld_provincia_id` int(11),
  `fld_provincia` varchar(255),
  `CuentaNo` varchar(15)
) */;

--
-- Temporary table structure for view `view_ahorros_retiros`
--

DROP TABLE IF EXISTS `view_ahorros_retiros`;
/*!50001 DROP VIEW IF EXISTS `view_ahorros_retiros`*/;
/*!50001 CREATE TABLE `view_ahorros_retiros` (
  `fld_id` int(11),
  `TipoDocumento` int(11),
  `fld_FullName` varchar(255),
  `fld_apodo` varchar(55),
  `fld_Identity` varchar(16),
  `fld_Phone` varchar(255),
  `fld_Phone2` varchar(255),
  `fld_Address` varchar(255),
  `fld_City_id` int(11),
  `fld_City` varchar(55),
  `fld_Status` varchar(6),
  `fld_bce` double(11,2),
  `fld_cod_zona` int(11),
  `fld_zona` varchar(255),
  `fld_nombre_con` varchar(55),
  `fld_apodo_con` varchar(55),
  `fld_cedula_con` varchar(16),
  `fld_telefono_con` varchar(14),
  `fld_celular_con` varchar(13),
  `fld_ref_personales_cliente` varchar(510),
  `fld_ref_comerciales_cliente` varchar(510),
  `fld_nombre_gar` varchar(55),
  `fld_apodo_gar` varchar(55),
  `fld_cedula_gar` varchar(16),
  `fld_telefono_gar` varchar(13),
  `fld_celular_gar` varchar(13),
  `fld_direccion_gar` varchar(255),
  `fld_ciudad_gar` varchar(55),
  `fld_ref_personales_gar` varchar(510),
  `fld_ref_comerciales_gar` varchar(510),
  `fld_ingresos_mesuales` double(12,2),
  `fld_nombre_banco1` varchar(1000),
  `fld_cuenta_banco1` varchar(15),
  `fld_nombre_banco2` varchar(1000),
  `fld_cuenta_banco2` varchar(15),
  `fld_otra_informacion` varchar(1000),
  `fld_nombre_con_gar` varchar(55),
  `fld_apodo_con_gar` varchar(55),
  `fld_cedula_con_gar` varchar(16),
  `fld_telefono_con_gar` varchar(13),
  `fld_celular_con_gar` varchar(13),
  `fld_edad` date,
  `fld_estado_civil` varchar(15),
  `fld_edad_gar` int(50),
  `fld_estado_civil_gar` varchar(15),
  `fld_ocupacion_cliente` varchar(55),
  `fld_ocupacion_gar` varchar(55),
  `fld_sector_id` int(11),
  `fld_sector` varchar(255),
  `fld_categoria` varchar(25),
  `fld_limite` double(12,2),
  `Puesto` varchar(100),
  `TimpoTrabajo` varchar(100),
  `ReferidoPor` varchar(100),
  `Oriundo` varchar(100),
  `DataCredito` int(1),
  `ctaContable` char(200),
  `email` varchar(255),
  `fechaIngreso` date,
  `whatsapp` varchar(13),
  `whatsapp_con` varchar(13),
  `parentezco_gar` varchar(20),
  `fecha_nac_gar` date,
  `whatsapp_gar` varchar(13),
  `email_gar` varchar(255),
  `empresa_gar` varchar(50),
  `telefono_Empresa_gar` varchar(13),
  `agno_labor_gar` int(50),
  `salario_gar` double(10,2),
  `whatsapp_con_gar` varchar(13),
  `fld_ref_parentesco_clie1` varchar(20),
  `fld_ced_ref_personal_clie1` varchar(16),
  `fld_tel_ref_personal_clie1` varchar(13),
  `fld_cel_ref_personal_clie1` varchar(13),
  `fld_whatsapp_ref_personal_clie1` varchar(13),
  `fld_ref_personal_clie2` varchar(50),
  `fld_ref_parentesco_clie2` varchar(20),
  `fld_ced_ref_personal_clie2` varchar(16),
  `fld_tel_ref_personal_clie2` varchar(13),
  `fld_cel_ref_personal_clie2` varchar(13),
  `fld_whatsapp_ref_personal_clie2` varchar(13),
  `Fld_Dir_Ref_Com_Clie1` varchar(255),
  `Fld_Rnc_Refe_Com_Clie1` varchar(9),
  `Fld_Tel_Com_clie1` varchar(13),
  `Fld_Whatsapp_Com_Clie1` varchar(13),
  `fld_ref_comerciales_cliente2` varchar(50),
  `Fld_Dir_Ref_Com_Clie2` varchar(255),
  `Fld_Rnc_Refe_Com_Clie2` varchar(9),
  `Fld_Tel_Com_clie2` varchar(13),
  `Fld_Whatsapp_Com_Clie2` varchar(13),
  `fld_parentesco_ref_gar1` varchar(20),
  `fld_cedula_ref_gar1` varchar(16),
  `fld_tel_ref_gar1` varchar(13),
  `fld_cel_ref_gar1` varchar(13),
  `fld_whatsapp_ref_gar1` varchar(13),
  `fld_ref_personal_gar2` varchar(50),
  `fld_parentesco_ref_gar2` varchar(20),
  `fld_cedula_ref_gar2` varchar(16),
  `fld_tel_ref_gar2` varchar(13),
  `fld_cel_ref_gar2` varchar(13),
  `fld_whatsapp_ref_gar2` varchar(13),
  `Fdl_Dir_Emp_Gar1` varchar(255),
  `Fld_Rnc_Emp_Gar1` varchar(11),
  `Fld_Tel_Emp_Gar1` varchar(13),
  `Fld_Whatsapp_emp_Gar1` varchar(13),
  `Fld_Empra_Gar2` varchar(50),
  `Fld_Dir_Emp_Gar2` varchar(255),
  `Fld_Rnc_Emp_Gar2` varchar(11),
  `Fld_Tel_Emp_Gar2` varchar(13),
  `Fld_Whatsapp_Emp_Gar2` varchar(13),
  `fld_nom_ref_flia_clie1` varchar(50),
  `fld_parentesco_ref_flia_clie1` varchar(50),
  `fld_ced_ref_flia_clie1` varchar(16),
  `fld_tel_ref_flia_clie1` varchar(13),
  `fld_cel_ref_flia_clie1` varchar(13),
  `fld_whatsapp_ref_flia_clie1` varchar(13),
  `fld_nom_ref_flia_clie2` varchar(50),
  `fld_parentesco_ref_flia_clie2` varchar(20),
  `fld_ced_ref_flia_clie2` varchar(16),
  `fld_tel_ref_flia_clie2` varchar(13),
  `fld_cel_ref_flia_clie2` varchar(13),
  `fld_whats_ref_flia_clie2` varchar(13),
  `fld_provincia_id` int(11),
  `fld_provincia` varchar(255),
  `ID` int(11),
  `IDAhorro` int(11),
  `IDCliente` int(11),
  `Fecha` datetime,
  `Tipo` varchar(25),
  `Concepto` varchar(150),
  `Monto` decimal(12,2),
  `Usuario` varchar(255),
  `IdCaja` int(11),
  `dosMil` double(12,2),
  `Mil` double(12,2),
  `Quiniento` double(12,2),
  `Dosciento` double(12,2),
  `Cien` double(12,2),
  `Cincuenta` double(12,2),
  `Veinticinco` double(12,2),
  `Diez` double(12,2),
  `Cinco` double(12,2),
  `Cheque` double(12,2),
  `Uno` double(12,2)
) */;

--
-- Temporary table structure for view `view_clientes_con_prestamos`
--

DROP TABLE IF EXISTS `view_clientes_con_prestamos`;
/*!50001 DROP VIEW IF EXISTS `view_clientes_con_prestamos`*/;
/*!50001 CREATE TABLE `view_clientes_con_prestamos` (
  `fld_id_prestamos` int(11),
  `fld_id_del_cliente` int(11),
  `fld_clasificacion` varchar(55),
  `fld_fecha_entrega` date,
  `fld_fecha_termina` date,
  `fld_fecha_calcula_interes` date,
  `fld_cantidad_cuotas` int(11),
  `fld_monto_cuotas_a` decimal(12,2),
  `fld_capital_prestamo` decimal(12,2),
  `fld_monto` decimal(12,2),
  `fld_abono` decimal(12,2),
  `fld_balance` decimal(12,2),
  `fld_usuario` varchar(255),
  `fld_fecha_ultimo_abono` date,
  `fld_status_prestamos` varchar(15),
  `fld_anos` decimal(12,2),
  `fld_interes_p` decimal(12,6),
  `fld_tipo_prestamo` varchar(255),
  `fld_ck_no` varchar(11),
  `fld_tipo_garantia` varchar(50),
  `fld_garantia` varchar(1500),
  `fldFinanciamiento` varchar(2),
  `fldMontoFinan` decimal(12,2),
  `fldMontoInicial` decimal(12,2),
  `fldCodInm` int(11),
  `fldDescInm` varchar(255),
  `fldMetros` decimal(12,2),
  `fldPrecioMetro` decimal(12,2),
  `fldTazaMora` decimal(12,2),
  `fldNota` varchar(1001),
  `IDVehiculo` int(11),
  `GastosLegales` decimal(12,2),
  `Seguro` decimal(12,2),
  `fld_id` int(11),
  `TipoDocumento` int(11),
  `fld_FullName` varchar(255),
  `fld_apodo` varchar(55),
  `fld_Identity` varchar(16),
  `fld_Phone` varchar(255),
  `fld_Phone2` varchar(255),
  `fld_Address` varchar(255),
  `fld_City_id` int(11),
  `fld_City` varchar(55),
  `fld_Status` varchar(6),
  `fld_bce` double(11,2),
  `fld_cod_zona` int(11),
  `fld_zona` varchar(255),
  `fld_nombre_con` varchar(55),
  `fld_apodo_con` varchar(55),
  `fld_cedula_con` varchar(16),
  `fld_telefono_con` varchar(14),
  `fld_celular_con` varchar(13),
  `fld_ref_personales_cliente` varchar(510),
  `fld_ref_comerciales_cliente` varchar(510),
  `fld_nombre_gar` varchar(55),
  `fld_apodo_gar` varchar(55),
  `fld_cedula_gar` varchar(16),
  `fld_telefono_gar` varchar(13),
  `fld_celular_gar` varchar(13),
  `fld_direccion_gar` varchar(255),
  `fld_ciudad_gar` varchar(55),
  `fld_ref_personales_gar` varchar(510),
  `fld_ref_comerciales_gar` varchar(510),
  `fld_ingresos_mesuales` double(12,2),
  `fld_nombre_banco1` varchar(1000),
  `fld_cuenta_banco1` varchar(15),
  `fld_nombre_banco2` varchar(1000),
  `fld_cuenta_banco2` varchar(15),
  `fld_otra_informacion` varchar(1000),
  `fld_nombre_con_gar` varchar(55),
  `fld_apodo_con_gar` varchar(55),
  `fld_cedula_con_gar` varchar(16),
  `fld_telefono_con_gar` varchar(13),
  `fld_celular_con_gar` varchar(13),
  `fld_edad` date,
  `fld_estado_civil` varchar(15),
  `fld_edad_gar` int(50),
  `fld_estado_civil_gar` varchar(15),
  `fld_ocupacion_cliente` varchar(55),
  `fld_ocupacion_gar` varchar(55),
  `fld_sector_id` int(11),
  `fld_sector` varchar(255),
  `fld_categoria` varchar(25),
  `fld_limite` double(12,2),
  `Puesto` varchar(100),
  `TimpoTrabajo` varchar(100),
  `ReferidoPor` varchar(100),
  `Oriundo` varchar(100),
  `DataCredito` int(1),
  `ctaContable` char(200),
  `email` varchar(255),
  `fechaIngreso` date,
  `whatsapp` varchar(13),
  `whatsapp_con` varchar(13),
  `parentezco_gar` varchar(20),
  `fecha_nac_gar` date,
  `whatsapp_gar` varchar(13),
  `email_gar` varchar(255),
  `empresa_gar` varchar(50),
  `telefono_Empresa_gar` varchar(13),
  `agno_labor_gar` int(50),
  `salario_gar` double(10,2),
  `whatsapp_con_gar` varchar(13),
  `fld_ref_parentesco_clie1` varchar(20),
  `fld_ced_ref_personal_clie1` varchar(16),
  `fld_tel_ref_personal_clie1` varchar(13),
  `fld_cel_ref_personal_clie1` varchar(13),
  `fld_whatsapp_ref_personal_clie1` varchar(13),
  `fld_ref_personal_clie2` varchar(50),
  `fld_ref_parentesco_clie2` varchar(20),
  `fld_ced_ref_personal_clie2` varchar(16),
  `fld_tel_ref_personal_clie2` varchar(13),
  `fld_cel_ref_personal_clie2` varchar(13),
  `fld_whatsapp_ref_personal_clie2` varchar(13),
  `Fld_Dir_Ref_Com_Clie1` varchar(255),
  `Fld_Rnc_Refe_Com_Clie1` varchar(9),
  `Fld_Tel_Com_clie1` varchar(13),
  `Fld_Whatsapp_Com_Clie1` varchar(13),
  `fld_ref_comerciales_cliente2` varchar(50),
  `Fld_Dir_Ref_Com_Clie2` varchar(255),
  `Fld_Rnc_Refe_Com_Clie2` varchar(9),
  `Fld_Tel_Com_clie2` varchar(13),
  `Fld_Whatsapp_Com_Clie2` varchar(13),
  `fld_parentesco_ref_gar1` varchar(20),
  `fld_cedula_ref_gar1` varchar(16),
  `fld_tel_ref_gar1` varchar(13),
  `fld_cel_ref_gar1` varchar(13),
  `fld_whatsapp_ref_gar1` varchar(13),
  `fld_ref_personal_gar2` varchar(50),
  `fld_parentesco_ref_gar2` varchar(20),
  `fld_cedula_ref_gar2` varchar(16),
  `fld_tel_ref_gar2` varchar(13),
  `fld_cel_ref_gar2` varchar(13),
  `fld_whatsapp_ref_gar2` varchar(13),
  `Fdl_Dir_Emp_Gar1` varchar(255),
  `Fld_Rnc_Emp_Gar1` varchar(11),
  `Fld_Tel_Emp_Gar1` varchar(13),
  `Fld_Whatsapp_emp_Gar1` varchar(13),
  `Fld_Empra_Gar2` varchar(50),
  `Fld_Dir_Emp_Gar2` varchar(255),
  `Fld_Rnc_Emp_Gar2` varchar(11),
  `Fld_Tel_Emp_Gar2` varchar(13),
  `Fld_Whatsapp_Emp_Gar2` varchar(13),
  `fld_nom_ref_flia_clie1` varchar(50),
  `fld_parentesco_ref_flia_clie1` varchar(50),
  `fld_ced_ref_flia_clie1` varchar(16),
  `fld_tel_ref_flia_clie1` varchar(13),
  `fld_cel_ref_flia_clie1` varchar(13),
  `fld_whatsapp_ref_flia_clie1` varchar(13),
  `fld_nom_ref_flia_clie2` varchar(50),
  `fld_parentesco_ref_flia_clie2` varchar(20),
  `fld_ced_ref_flia_clie2` varchar(16),
  `fld_tel_ref_flia_clie2` varchar(13),
  `fld_cel_ref_flia_clie2` varchar(13),
  `fld_whats_ref_flia_clie2` varchar(13),
  `fld_provincia_id` int(11),
  `fld_provincia` varchar(255)
) */;

--
-- Temporary table structure for view `view_cont_catalogo`
--

DROP TABLE IF EXISTS `view_cont_catalogo`;
/*!50001 DROP VIEW IF EXISTS `view_cont_catalogo`*/;
/*!50001 CREATE TABLE `view_cont_catalogo` (
  `IDg` int(11),
  `Descripciong` varchar(25),
  `Origen` int(1),
  `ID` double,
  `CuentaNo` varchar(45),
  `Descripcion` varchar(240),
  `Grupo` double,
  `Tipo` varchar(30),
  `Debito` decimal(12,2),
  `Credito` decimal(12,2),
  `Balance` decimal(12,2),
  `CtaControl` varchar(300),
  `NombreMes` varchar(45),
  `NumeroMes` double,
  `BalanceGeneral` varchar(6),
  `EstadoResultado` varchar(6),
  `OrdenEstadoResultado` varchar(6),
  `AccionEstatoResultado` varchar(3),
  `VerEnCero` varchar(6),
  `Fecha` datetime,
  `Usuario` varchar(75)
) */;

--
-- Temporary table structure for view `view_cont_libro_general`
--

DROP TABLE IF EXISTS `view_cont_libro_general`;
/*!50001 DROP VIEW IF EXISTS `view_cont_libro_general`*/;
/*!50001 CREATE TABLE `view_cont_libro_general` (
  `TransID` int(11),
  `TransFecha` datetime,
  `TransFechaMovimiento` date,
  `TransDescripcion` varchar(250),
  `TransIDTipo` int(11),
  `TransUsuario` varchar(25),
  `TransEstado` varchar(15),
  `TransIDDoc` int(11),
  `TransDoc` varchar(50),
  `TransDocDetalle` varchar(255),
  `TransDID` int(11),
  `TransDIDTrans` int(11),
  `TransDCuentaNo` varchar(15),
  `TransDDescripcionCuenta` varchar(80),
  `TransDDebito` decimal(12,2),
  `TransDCredito` decimal(12,2),
  `TransDBalance` decimal(12,2),
  `ID` double,
  `CuentaNo` varchar(45),
  `Descripcion` varchar(240),
  `Grupo` double,
  `Tipo` varchar(30),
  `Debito` decimal(12,2),
  `Credito` decimal(12,2),
  `Balance` decimal(12,2),
  `CtaControl` varchar(300),
  `NombreMes` varchar(45),
  `NumeroMes` double,
  `BalanceAnterior` decimal(14,0),
  `BalanceGeneral` varchar(6),
  `EstadoResultado` varchar(6),
  `OrdenEstadoResultado` varchar(6),
  `AccionEstatoResultado` varchar(3),
  `VerEnCero` varchar(6),
  `Fecha` datetime,
  `Usuario` varchar(75),
  `Nivel` int(11)
) */;

--
-- Temporary table structure for view `view_cont_transacciones`
--

DROP TABLE IF EXISTS `view_cont_transacciones`;
/*!50001 DROP VIEW IF EXISTS `view_cont_transacciones`*/;
/*!50001 CREATE TABLE `view_cont_transacciones` (
  `TransID` int(11),
  `TransFecha` datetime,
  `TransFechaMovimiento` date,
  `TransDescripcion` varchar(250),
  `TransIDTipo` int(11),
  `TransUsuario` varchar(25),
  `TransEstado` varchar(15),
  `TransIDDoc` int(11),
  `TransDoc` varchar(50),
  `TransDocDetalle` varchar(255),
  `TransDID` int(11),
  `TransDIDTrans` int(11),
  `TransDCuentaNo` varchar(15),
  `TransDDescripcionCuenta` varchar(80),
  `TransDDebito` decimal(12,2),
  `TransDCredito` decimal(12,2),
  `TransDBalance` decimal(12,2),
  `fld_id` int(11),
  `fld_codigo` varchar(20),
  `fld_descripcion` varchar(100),
  `fld_modulo` varchar(255)
) */;

--
-- Temporary table structure for view `view_cuotas_todas`
--

DROP TABLE IF EXISTS `view_cuotas_todas`;
/*!50001 DROP VIEW IF EXISTS `view_cuotas_todas`*/;
/*!50001 CREATE TABLE `view_cuotas_todas` (
  `fld_id` int(11),
  `TipoDocumento` int(11),
  `fld_FullName` varchar(255),
  `fld_apodo` varchar(55),
  `fld_Identity` varchar(16),
  `fld_Phone` varchar(255),
  `fld_Phone2` varchar(255),
  `fld_Address` varchar(255),
  `fld_City_id` int(11),
  `fld_City` varchar(55),
  `fld_Status` varchar(6),
  `fld_bce` double(11,2),
  `fld_cod_zona` int(11),
  `fld_zona` varchar(255),
  `fld_nombre_con` varchar(55),
  `fld_apodo_con` varchar(55),
  `fld_cedula_con` varchar(16),
  `fld_telefono_con` varchar(14),
  `fld_celular_con` varchar(13),
  `fld_ref_personales_cliente` varchar(510),
  `fld_ref_comerciales_cliente` varchar(510),
  `fld_nombre_gar` varchar(55),
  `fld_apodo_gar` varchar(55),
  `fld_cedula_gar` varchar(16),
  `fld_telefono_gar` varchar(13),
  `fld_celular_gar` varchar(13),
  `fld_direccion_gar` varchar(255),
  `fld_ciudad_gar` varchar(55),
  `fld_ref_personales_gar` varchar(510),
  `fld_ref_comerciales_gar` varchar(510),
  `fld_ingresos_mesuales` double(12,2),
  `fld_nombre_banco1` varchar(1000),
  `fld_cuenta_banco1` varchar(15),
  `fld_nombre_banco2` varchar(1000),
  `fld_cuenta_banco2` varchar(15),
  `fld_otra_informacion` varchar(1000),
  `fld_nombre_con_gar` varchar(55),
  `fld_apodo_con_gar` varchar(55),
  `fld_cedula_con_gar` varchar(16),
  `fld_telefono_con_gar` varchar(13),
  `fld_celular_con_gar` varchar(13),
  `fld_edad` date,
  `fld_estado_civil` varchar(15),
  `fld_edad_gar` int(50),
  `fld_estado_civil_gar` varchar(15),
  `fld_ocupacion_cliente` varchar(55),
  `fld_ocupacion_gar` varchar(55),
  `fld_sector_id` int(11),
  `fld_sector` varchar(255),
  `fld_categoria` varchar(25),
  `fld_limite` double(12,2),
  `Puesto` varchar(100),
  `TimpoTrabajo` varchar(100),
  `ReferidoPor` varchar(100),
  `Oriundo` varchar(100),
  `DataCredito` int(1),
  `ctaContable` char(200),
  `email` varchar(255),
  `fechaIngreso` date,
  `whatsapp` varchar(13),
  `whatsapp_con` varchar(13),
  `parentezco_gar` varchar(20),
  `fecha_nac_gar` date,
  `whatsapp_gar` varchar(13),
  `email_gar` varchar(255),
  `empresa_gar` varchar(50),
  `telefono_Empresa_gar` varchar(13),
  `agno_labor_gar` int(50),
  `salario_gar` double(10,2),
  `whatsapp_con_gar` varchar(13),
  `fld_ref_parentesco_clie1` varchar(20),
  `fld_ced_ref_personal_clie1` varchar(16),
  `fld_tel_ref_personal_clie1` varchar(13),
  `fld_cel_ref_personal_clie1` varchar(13),
  `fld_whatsapp_ref_personal_clie1` varchar(13),
  `fld_ref_personal_clie2` varchar(50),
  `fld_ref_parentesco_clie2` varchar(20),
  `fld_ced_ref_personal_clie2` varchar(16),
  `fld_tel_ref_personal_clie2` varchar(13),
  `fld_cel_ref_personal_clie2` varchar(13),
  `fld_whatsapp_ref_personal_clie2` varchar(13),
  `Fld_Dir_Ref_Com_Clie1` varchar(255),
  `Fld_Rnc_Refe_Com_Clie1` varchar(9),
  `Fld_Tel_Com_clie1` varchar(13),
  `Fld_Whatsapp_Com_Clie1` varchar(13),
  `fld_ref_comerciales_cliente2` varchar(50),
  `Fld_Dir_Ref_Com_Clie2` varchar(255),
  `Fld_Rnc_Refe_Com_Clie2` varchar(9),
  `Fld_Tel_Com_clie2` varchar(13),
  `Fld_Whatsapp_Com_Clie2` varchar(13),
  `fld_parentesco_ref_gar1` varchar(20),
  `fld_cedula_ref_gar1` varchar(16),
  `fld_tel_ref_gar1` varchar(13),
  `fld_cel_ref_gar1` varchar(13),
  `fld_whatsapp_ref_gar1` varchar(13),
  `fld_ref_personal_gar2` varchar(50),
  `fld_parentesco_ref_gar2` varchar(20),
  `fld_cedula_ref_gar2` varchar(16),
  `fld_tel_ref_gar2` varchar(13),
  `fld_cel_ref_gar2` varchar(13),
  `fld_whatsapp_ref_gar2` varchar(13),
  `Fdl_Dir_Emp_Gar1` varchar(255),
  `Fld_Rnc_Emp_Gar1` varchar(11),
  `Fld_Tel_Emp_Gar1` varchar(13),
  `Fld_Whatsapp_emp_Gar1` varchar(13),
  `Fld_Empra_Gar2` varchar(50),
  `Fld_Dir_Emp_Gar2` varchar(255),
  `Fld_Rnc_Emp_Gar2` varchar(11),
  `Fld_Tel_Emp_Gar2` varchar(13),
  `Fld_Whatsapp_Emp_Gar2` varchar(13),
  `fld_nom_ref_flia_clie1` varchar(50),
  `fld_parentesco_ref_flia_clie1` varchar(50),
  `fld_ced_ref_flia_clie1` varchar(16),
  `fld_tel_ref_flia_clie1` varchar(13),
  `fld_cel_ref_flia_clie1` varchar(13),
  `fld_whatsapp_ref_flia_clie1` varchar(13),
  `fld_nom_ref_flia_clie2` varchar(50),
  `fld_parentesco_ref_flia_clie2` varchar(20),
  `fld_ced_ref_flia_clie2` varchar(16),
  `fld_tel_ref_flia_clie2` varchar(13),
  `fld_cel_ref_flia_clie2` varchar(13),
  `fld_whats_ref_flia_clie2` varchar(13),
  `fld_provincia_id` int(11),
  `fld_provincia` varchar(255),
  `fld_id_cuotas` int(11),
  `fld_no_cuotas` varchar(15),
  `fld_id_del_cliente_cuotas` int(11),
  `fld_id_del_prestamo` int(11),
  `fld_fecha_entrega_cuotas` date,
  `fld_fecha_termina_cuotas` date,
  `fld_fecha_calculo_interes` date,
  `fld_termina_calculo_interes` varchar(6),
  `fld_fecha_ultimo_abono_cuotas` date,
  `fld_capital_cuota` decimal(12,2),
  `fld_interes_cuota` decimal(12,2),
  `fld_monto_cuotas` decimal(12,2),
  `fld_abono_cuotas` decimal(12,2),
  `fld_balance_cuotas` decimal(12,2),
  `fld_usuario_cuotas` varchar(255),
  `fld_status_cuotas` varchar(255),
  `fld_pendiente_amortizar` decimal(12,2),
  `fld_total_amortizado` decimal(12,2),
  `fld_capital_cuota_abono` decimal(12,2),
  `fld_capital_cuota_balance` decimal(12,2),
  `fld_interes_cuota_abono` decimal(12,2),
  `fld_interes_cuota_balance` decimal(12,2),
  `fld_ultimo_abono_interes` decimal(12,2),
  `fld_ultimo_abono_capital` decimal(12,2),
  `fld_monto_mora` decimal(12,2),
  `fld_abono_mora` decimal(12,2),
  `fld_balance_mora` decimal(12,2),
  `fld_ultimo_abono_mora` decimal(12,2),
  `fld_dias_vencimiento` int(11),
  `fld_socio` varchar(255),
  `fld_atraso_cuotas` decimal(12,2),
  `fld_tipo_cuotas` varchar(255),
  `fld_bce_prestamo` decimal(12,2),
  `fld_cant_cuotas` decimal(12,2),
  `fldchk` varchar(6),
  `Tipo` varchar(50)
) */;

--
-- Temporary table structure for view `view_cxc_nota_credito`
--

DROP TABLE IF EXISTS `view_cxc_nota_credito`;
/*!50001 DROP VIEW IF EXISTS `view_cxc_nota_credito`*/;
/*!50001 CREATE TABLE `view_cxc_nota_credito` (
  `fld_id` int(11),
  `fld_FullName` varchar(255),
  `fld_apodo` varchar(55),
  `fld_Identity` varchar(16),
  `fld_Phone` varchar(255),
  `fld_Phone2` varchar(255),
  `fld_Address` varchar(255),
  `fld_City` varchar(55),
  `fld_Status` varchar(6),
  `fld_bce` double(11,2),
  `fld_cod_zona` int(11),
  `fld_zona` varchar(255),
  `fld_nombre_con` varchar(55),
  `fld_apodo_con` varchar(55),
  `fld_cedula_con` varchar(16),
  `fld_telefono_con` varchar(14),
  `fld_celular_con` varchar(13),
  `fld_ref_personales_cliente` varchar(510),
  `fld_ref_comerciales_cliente` varchar(510),
  `fld_nombre_gar` varchar(55),
  `fld_apodo_gar` varchar(55),
  `fld_cedula_gar` varchar(16),
  `fld_telefono_gar` varchar(13),
  `fld_celular_gar` varchar(13),
  `fld_direccion_gar` varchar(255),
  `fld_ciudad_gar` varchar(55),
  `fld_ref_personales_gar` varchar(510),
  `fld_ref_comerciales_gar` varchar(510),
  `fld_ingresos_mesuales` double(12,2),
  `fld_nombre_banco1` varchar(1000),
  `fld_cuenta_banco1` varchar(15),
  `fld_nombre_banco2` varchar(1000),
  `fld_cuenta_banco2` varchar(15),
  `fld_otra_informacion` varchar(1000),
  `fld_nombre_con_gar` varchar(55),
  `fld_apodo_con_gar` varchar(55),
  `fld_cedula_con_gar` varchar(16),
  `fld_telefono_con_gar` varchar(13),
  `fld_celular_con_gar` varchar(13),
  `fld_edad` date,
  `fld_estado_civil` varchar(15),
  `fld_edad_gar` int(50),
  `fld_estado_civil_gar` varchar(15),
  `fld_ocupacion_cliente` varchar(55),
  `fld_ocupacion_gar` varchar(55),
  `fld_id_nc_cxc` int(11),
  `fld_cliente_id_nc` int(11),
  `fld_fecha` datetime,
  `fld_concepto` varchar(765),
  `fld_monto` double(12,2),
  `fld_user` varchar(150),
  `fld_status_nc` text
) */;

--
-- Temporary table structure for view `view_cxc_nota_debito`
--

DROP TABLE IF EXISTS `view_cxc_nota_debito`;
/*!50001 DROP VIEW IF EXISTS `view_cxc_nota_debito`*/;
/*!50001 CREATE TABLE `view_cxc_nota_debito` (
  `fld_id` int(11),
  `fld_FullName` varchar(255),
  `fld_apodo` varchar(55),
  `fld_Identity` varchar(16),
  `fld_Phone` varchar(255),
  `fld_Phone2` varchar(255),
  `fld_Address` varchar(255),
  `fld_City` varchar(55),
  `fld_Status` varchar(6),
  `fld_bce` double(11,2),
  `fld_cod_zona` int(11),
  `fld_zona` varchar(255),
  `fld_nombre_con` varchar(55),
  `fld_apodo_con` varchar(55),
  `fld_cedula_con` varchar(16),
  `fld_telefono_con` varchar(14),
  `fld_celular_con` varchar(13),
  `fld_ref_personales_cliente` varchar(510),
  `fld_ref_comerciales_cliente` varchar(510),
  `fld_nombre_gar` varchar(55),
  `fld_apodo_gar` varchar(55),
  `fld_cedula_gar` varchar(16),
  `fld_telefono_gar` varchar(13),
  `fld_celular_gar` varchar(13),
  `fld_direccion_gar` varchar(255),
  `fld_ciudad_gar` varchar(55),
  `fld_ref_personales_gar` varchar(510),
  `fld_ref_comerciales_gar` varchar(510),
  `fld_ingresos_mesuales` double(12,2),
  `fld_nombre_banco1` varchar(1000),
  `fld_cuenta_banco1` varchar(15),
  `fld_nombre_banco2` varchar(1000),
  `fld_cuenta_banco2` varchar(15),
  `fld_otra_informacion` varchar(1000),
  `fld_nombre_con_gar` varchar(55),
  `fld_apodo_con_gar` varchar(55),
  `fld_cedula_con_gar` varchar(16),
  `fld_telefono_con_gar` varchar(13),
  `fld_celular_con_gar` varchar(13),
  `fld_edad` date,
  `fld_estado_civil` varchar(15),
  `fld_edad_gar` int(50),
  `fld_estado_civil_gar` varchar(15),
  `fld_ocupacion_cliente` varchar(55),
  `fld_ocupacion_gar` varchar(55),
  `fld_id_nd_cxc` int(11),
  `fld_cliente_id_nd` int(11),
  `fld_fecha` date,
  `fld_concepto` varchar(255),
  `fld_monto` double(12,2),
  `fld_abono` double(12,2),
  `fld_balance` double(12,2),
  `fld_user` text,
  `fld_status_nd` text,
  `fld_ultimo_abono` decimal(10,2)
) */;

--
-- Temporary table structure for view `view_depositos`
--

DROP TABLE IF EXISTS `view_depositos`;
/*!50001 DROP VIEW IF EXISTS `view_depositos`*/;
/*!50001 CREATE TABLE `view_depositos` (
  `fld_id` int(11),
  `fld_nombre` varchar(255),
  `fld_cuenta` varchar(255),
  `fld_cta_contable` varchar(255),
  `fld_contacto` varchar(255),
  `fld_sucursal` varchar(255),
  `fld_balance` double(12,2),
  `fld_status` varchar(255),
  `fld_direccion` varchar(255),
  `fld_codigo` varchar(255),
  `fld_tt_ck` varchar(255),
  `fld_tt_dep` varchar(255),
  `fld_tt_nc` varchar(255),
  `fld_tt_nd` varchar(255),
  `fld_id_doc` int(11),
  `fld_id_banco` text,
  `fld_fecha` date,
  `fld_descripcion` varchar(255),
  `fld_monto` double(11,2),
  `fld_estado` text,
  `fld_transito` text,
  `fld_cod_concepto` varchar(11),
  `afectacaja` int(11)
) */;

--
-- Temporary table structure for view `view_estado_banco`
--

DROP TABLE IF EXISTS `view_estado_banco`;
/*!50001 DROP VIEW IF EXISTS `view_estado_banco`*/;
/*!50001 CREATE TABLE `view_estado_banco` (
  `fld_id_ec_b` int(11),
  `fld_date` date,
  `fld_description` varchar(5500),
  `fld_dr` double(12,2),
  `fld_cr` double(12,2),
  `fld_bce_banco` double(12,2),
  `fld_banco_id` varchar(255),
  `fld_tipo_doc` varchar(255),
  `fld_tipo_doc_id` varchar(255),
  `fld_usuario` varchar(255),
  `fld_id` int(11),
  `fld_nombre` varchar(255),
  `fld_cuenta` varchar(255),
  `fld_cta_contable` varchar(255),
  `fld_contacto` varchar(255),
  `fld_sucursal` varchar(255),
  `fld_balance` double(12,2),
  `fld_status` varchar(255),
  `fld_direccion` varchar(255),
  `fld_codigo` varchar(255),
  `fld_tt_ck` varchar(255),
  `fld_tt_dep` varchar(255),
  `fld_tt_nc` varchar(255),
  `fld_tt_nd` varchar(255)
) */;

--
-- Temporary table structure for view `view_estado_clientes`
--

DROP TABLE IF EXISTS `view_estado_clientes`;
/*!50001 DROP VIEW IF EXISTS `view_estado_clientes`*/;
/*!50001 CREATE TABLE `view_estado_clientes` (
  `fld_id` int(11),
  `TipoDocumento` int(11),
  `fld_FullName` varchar(255),
  `fld_apodo` varchar(55),
  `fld_Identity` varchar(16),
  `fld_Phone` varchar(255),
  `fld_Phone2` varchar(255),
  `fld_Address` varchar(255),
  `fld_City_id` int(11),
  `fld_City` varchar(55),
  `fld_Status` varchar(6),
  `fld_bce` double(11,2),
  `fld_cod_zona` int(11),
  `fld_zona` varchar(255),
  `fld_nombre_con` varchar(55),
  `fld_apodo_con` varchar(55),
  `fld_cedula_con` varchar(16),
  `fld_telefono_con` varchar(14),
  `fld_celular_con` varchar(13),
  `fld_ref_personales_cliente` varchar(510),
  `fld_ref_comerciales_cliente` varchar(510),
  `fld_nombre_gar` varchar(55),
  `fld_apodo_gar` varchar(55),
  `fld_cedula_gar` varchar(16),
  `fld_telefono_gar` varchar(13),
  `fld_celular_gar` varchar(13),
  `fld_direccion_gar` varchar(255),
  `fld_ciudad_gar` varchar(55),
  `fld_ref_personales_gar` varchar(510),
  `fld_ref_comerciales_gar` varchar(510),
  `fld_ingresos_mesuales` double(12,2),
  `fld_nombre_banco1` varchar(1000),
  `fld_cuenta_banco1` varchar(15),
  `fld_nombre_banco2` varchar(1000),
  `fld_cuenta_banco2` varchar(15),
  `fld_otra_informacion` varchar(1000),
  `fld_nombre_con_gar` varchar(55),
  `fld_apodo_con_gar` varchar(55),
  `fld_cedula_con_gar` varchar(16),
  `fld_telefono_con_gar` varchar(13),
  `fld_celular_con_gar` varchar(13),
  `fld_edad` date,
  `fld_estado_civil` varchar(15),
  `fld_edad_gar` int(50),
  `fld_estado_civil_gar` varchar(15),
  `fld_ocupacion_cliente` varchar(55),
  `fld_ocupacion_gar` varchar(55),
  `fld_sector_id` int(11),
  `fld_sector` varchar(255),
  `fld_categoria` varchar(25),
  `fld_limite` double(12,2),
  `Puesto` varchar(100),
  `TimpoTrabajo` varchar(100),
  `ReferidoPor` varchar(100),
  `Oriundo` varchar(100),
  `DataCredito` int(1),
  `ctaContable` char(200),
  `email` varchar(255),
  `fechaIngreso` date,
  `whatsapp` varchar(13),
  `whatsapp_con` varchar(13),
  `parentezco_gar` varchar(20),
  `fecha_nac_gar` date,
  `whatsapp_gar` varchar(13),
  `email_gar` varchar(255),
  `empresa_gar` varchar(50),
  `telefono_Empresa_gar` varchar(13),
  `agno_labor_gar` int(50),
  `salario_gar` double(10,2),
  `whatsapp_con_gar` varchar(13),
  `fld_ref_parentesco_clie1` varchar(20),
  `fld_ced_ref_personal_clie1` varchar(16),
  `fld_tel_ref_personal_clie1` varchar(13),
  `fld_cel_ref_personal_clie1` varchar(13),
  `fld_whatsapp_ref_personal_clie1` varchar(13),
  `fld_ref_personal_clie2` varchar(50),
  `fld_ref_parentesco_clie2` varchar(20),
  `fld_ced_ref_personal_clie2` varchar(16),
  `fld_tel_ref_personal_clie2` varchar(13),
  `fld_cel_ref_personal_clie2` varchar(13),
  `fld_whatsapp_ref_personal_clie2` varchar(13),
  `Fld_Dir_Ref_Com_Clie1` varchar(255),
  `Fld_Rnc_Refe_Com_Clie1` varchar(9),
  `Fld_Tel_Com_clie1` varchar(13),
  `Fld_Whatsapp_Com_Clie1` varchar(13),
  `fld_ref_comerciales_cliente2` varchar(50),
  `Fld_Dir_Ref_Com_Clie2` varchar(255),
  `Fld_Rnc_Refe_Com_Clie2` varchar(9),
  `Fld_Tel_Com_clie2` varchar(13),
  `Fld_Whatsapp_Com_Clie2` varchar(13),
  `fld_parentesco_ref_gar1` varchar(20),
  `fld_cedula_ref_gar1` varchar(16),
  `fld_tel_ref_gar1` varchar(13),
  `fld_cel_ref_gar1` varchar(13),
  `fld_whatsapp_ref_gar1` varchar(13),
  `fld_ref_personal_gar2` varchar(50),
  `fld_parentesco_ref_gar2` varchar(20),
  `fld_cedula_ref_gar2` varchar(16),
  `fld_tel_ref_gar2` varchar(13),
  `fld_cel_ref_gar2` varchar(13),
  `fld_whatsapp_ref_gar2` varchar(13),
  `Fdl_Dir_Emp_Gar1` varchar(255),
  `Fld_Rnc_Emp_Gar1` varchar(11),
  `Fld_Tel_Emp_Gar1` varchar(13),
  `Fld_Whatsapp_emp_Gar1` varchar(13),
  `Fld_Empra_Gar2` varchar(50),
  `Fld_Dir_Emp_Gar2` varchar(255),
  `Fld_Rnc_Emp_Gar2` varchar(11),
  `Fld_Tel_Emp_Gar2` varchar(13),
  `Fld_Whatsapp_Emp_Gar2` varchar(13),
  `fld_nom_ref_flia_clie1` varchar(50),
  `fld_parentesco_ref_flia_clie1` varchar(50),
  `fld_ced_ref_flia_clie1` varchar(16),
  `fld_tel_ref_flia_clie1` varchar(13),
  `fld_cel_ref_flia_clie1` varchar(13),
  `fld_whatsapp_ref_flia_clie1` varchar(13),
  `fld_nom_ref_flia_clie2` varchar(50),
  `fld_parentesco_ref_flia_clie2` varchar(20),
  `fld_ced_ref_flia_clie2` varchar(16),
  `fld_tel_ref_flia_clie2` varchar(13),
  `fld_cel_ref_flia_clie2` varchar(13),
  `fld_whats_ref_flia_clie2` varchar(13),
  `fld_provincia_id` int(11),
  `fld_provincia` varchar(255),
  `fld_id_ec` int(11),
  `fld_date` date,
  `fld_description` varchar(5500),
  `fld_dr` double(12,2),
  `fld_cr` double(12,2),
  `fld_bce_cliente` double(12,2),
  `fld_cliente_id` int(11),
  `fld_tipo_doc` varchar(255),
  `fld_tipo_doc_id` varchar(255),
  `fld_usuario` varchar(255)
) */;

--
-- Temporary table structure for view `view_estado_proveedor`
--

DROP TABLE IF EXISTS `view_estado_proveedor`;
/*!50001 DROP VIEW IF EXISTS `view_estado_proveedor`*/;
/*!50001 CREATE TABLE `view_estado_proveedor` (
  `fldSupplierID` int(11),
  `fldCompany` varchar(450),
  `fldAddress` varchar(450),
  `fldPhone` varchar(450),
  `fldContact` varchar(450),
  `fldLimiteCR` double(12,2),
  `fldBalance` double(12,2),
  `fld_Status` varchar(255),
  `fldBy` varchar(450),
  `fldfax` varchar(450),
  `fldcel` varchar(450),
  `fld_clasificacion` varchar(450),
  `fld_cta_contable` varchar(450),
  `fld_telefono` varchar(450),
  `fld_correo` varchar(450),
  `fld_banco` varchar(450),
  `fld_id_ec_p` int(11),
  `fld_date` date,
  `fld_description` varchar(255),
  `fld_dr` double(11,2),
  `fld_cr` double(11,2),
  `fld_bce_proveedor` double(11,2),
  `fld_proveedor_id` int(11),
  `fld_tipo_doc` text,
  `fld_tipo_doc_id` text,
  `fld_usuario` text
) */;

--
-- Temporary table structure for view `view_generar_cuotas`
--

DROP TABLE IF EXISTS `view_generar_cuotas`;
/*!50001 DROP VIEW IF EXISTS `view_generar_cuotas`*/;
/*!50001 CREATE TABLE `view_generar_cuotas` (
  `fld_id` int(11),
  `fld_FullName` varchar(255),
  `fld_apodo` varchar(55),
  `fld_Identity` varchar(16),
  `fld_Phone` varchar(255),
  `fld_Phone2` varchar(255),
  `fld_Address` varchar(255),
  `fld_City` varchar(55),
  `fld_Status` varchar(6),
  `fld_bce` double(11,2),
  `fld_cod_zona` int(11),
  `fld_zona` varchar(255),
  `fld_nombre_con` varchar(55),
  `fld_apodo_con` varchar(55),
  `fld_cedula_con` varchar(16),
  `fld_telefono_con` varchar(14),
  `fld_celular_con` varchar(13),
  `fld_ref_personales_cliente` varchar(510),
  `fld_ref_comerciales_cliente` varchar(510),
  `fld_nombre_gar` varchar(55),
  `fld_apodo_gar` varchar(55),
  `fld_cedula_gar` varchar(16),
  `fld_telefono_gar` varchar(13),
  `fld_celular_gar` varchar(13),
  `fld_direccion_gar` varchar(255),
  `fld_ciudad_gar` varchar(55),
  `fld_ref_personales_gar` varchar(510),
  `fld_ref_comerciales_gar` varchar(510),
  `fld_ingresos_mesuales` double(12,2),
  `fld_nombre_banco1` varchar(1000),
  `fld_cuenta_banco1` varchar(15),
  `fld_nombre_banco2` varchar(1000),
  `fld_cuenta_banco2` varchar(15),
  `fld_otra_informacion` varchar(1000),
  `fld_nombre_con_gar` varchar(55),
  `fld_apodo_con_gar` varchar(55),
  `fld_cedula_con_gar` varchar(16),
  `fld_telefono_con_gar` varchar(13),
  `fld_celular_con_gar` varchar(13),
  `fld_edad` date,
  `fld_estado_civil` varchar(15),
  `fld_edad_gar` int(50),
  `fld_estado_civil_gar` varchar(15),
  `fld_ocupacion_cliente` varchar(55),
  `fld_ocupacion_gar` varchar(55),
  `fld_sector` varchar(255),
  `fld_categoria` varchar(25),
  `fld_id_cuotas` int(11),
  `fld_no_cuotas` varchar(15),
  `fld_id_del_cliente_cuotas` int(11),
  `fld_id_del_prestamo` int(11),
  `fld_fecha_entrega_cuotas` date,
  `fld_fecha_termina_cuotas` date,
  `fld_fecha_ultimo_abono_cuotas` date,
  `fld_capital_cuota` decimal(12,2),
  `fld_interes_cuota` decimal(12,2),
  `fld_monto_cuotas` decimal(12,2),
  `fld_abono_cuotas` decimal(12,2),
  `fld_balance_cuotas` decimal(12,2),
  `fld_usuario_cuotas` varchar(255),
  `fld_status_cuotas` varchar(255),
  `fld_pendiente_amortizar` decimal(12,2),
  `fld_total_amortizado` decimal(12,2),
  `fld_capital_cuota_abono` decimal(12,2),
  `fld_capital_cuota_balance` decimal(12,2),
  `fld_interes_cuota_abono` decimal(12,2),
  `fld_interes_cuota_balance` decimal(12,2),
  `fld_ultimo_abono_interes` decimal(12,2),
  `fld_ultimo_abono_capital` decimal(12,2),
  `fld_monto_mora` decimal(12,2),
  `fld_abono_mora` decimal(12,2),
  `fld_balance_mora` decimal(12,2),
  `fld_ultimo_abono_mora` decimal(12,2),
  `fld_dias_vencimiento` int(11),
  `fld_socio` varchar(255),
  `fld_atraso_cuotas` decimal(12,2),
  `fld_tipo_cuotas` varchar(255),
  `fld_bce_prestamo` decimal(12,2),
  `fld_cant_cuotas` decimal(12,2)
) */;

--
-- Temporary table structure for view `view_libro_mayor`
--

DROP TABLE IF EXISTS `view_libro_mayor`;
/*!50001 DROP VIEW IF EXISTS `view_libro_mayor`*/;
/*!50001 CREATE TABLE `view_libro_mayor` (
  `TransDID` int(11),
  `TransDIDTrans` int(11),
  `TransDCuentaNo` varchar(15),
  `TransDDescripcionCuenta` varchar(80),
  `TransDDebito` decimal(12,2),
  `TransDCredito` decimal(12,2),
  `TransDBalance` decimal(12,2),
  `TransID` int(11),
  `TransFecha` datetime,
  `TransFechaMovimiento` date,
  `TransDescripcion` varchar(250),
  `TransIDTipo` int(11),
  `TransUsuario` varchar(25),
  `TransEstado` varchar(15),
  `TransIDDoc` int(11),
  `TransDoc` varchar(50),
  `TransDocDetalle` varchar(255),
  `ID` double,
  `CuentaNo` varchar(45),
  `Descripcion` varchar(240),
  `Grupo` double,
  `Tipo` varchar(30),
  `Debito` decimal(12,2),
  `Credito` decimal(12,2),
  `Balance` decimal(12,2),
  `CtaControl` varchar(300),
  `NombreMes` varchar(45),
  `NumeroMes` double,
  `BalanceAnterior` decimal(14,0),
  `BalanceGeneral` varchar(6),
  `EstadoResultado` varchar(6),
  `OrdenEstadoResultado` varchar(6),
  `AccionEstatoResultado` varchar(3),
  `VerEnCero` varchar(6),
  `Fecha` datetime,
  `Usuario` varchar(75),
  `Nivel` int(11)
) */;

--
-- Temporary table structure for view `view_nc_bancaria`
--

DROP TABLE IF EXISTS `view_nc_bancaria`;
/*!50001 DROP VIEW IF EXISTS `view_nc_bancaria`*/;
/*!50001 CREATE TABLE `view_nc_bancaria` (
  `fld_id` int(11),
  `fld_nombre` varchar(255),
  `fld_cuenta` varchar(255),
  `fld_cta_contable` varchar(255),
  `fld_contacto` varchar(255),
  `fld_sucursal` varchar(255),
  `fld_balance` double(12,2),
  `fld_status` varchar(255),
  `fld_direccion` varchar(255),
  `fld_codigo` varchar(255),
  `fld_tt_ck` varchar(255),
  `fld_tt_dep` varchar(255),
  `fld_tt_nc` varchar(255),
  `fld_tt_nd` varchar(255),
  `fld_id_doc` int(11),
  `fld_id_banco` text,
  `fld_fecha` date,
  `fld_descripcion` varchar(2295),
  `fld_monto` double(11,2),
  `fld_estado` text,
  `fld_transito` text
) */;

--
-- Temporary table structure for view `view_nd_bancaria`
--

DROP TABLE IF EXISTS `view_nd_bancaria`;
/*!50001 DROP VIEW IF EXISTS `view_nd_bancaria`*/;
/*!50001 CREATE TABLE `view_nd_bancaria` (
  `fld_id_doc` int(11),
  `fld_id_banco` text,
  `fld_fecha` date,
  `fld_descripcion` varchar(765),
  `fld_monto` double(11,2),
  `fld_estado` text,
  `fld_transito` text,
  `fld_id` int(11),
  `fld_nombre` varchar(255),
  `fld_cuenta` varchar(255),
  `fld_cta_contable` varchar(255),
  `fld_contacto` varchar(255),
  `fld_sucursal` varchar(255),
  `fld_balance` double(12,2),
  `fld_status` varchar(255),
  `fld_direccion` varchar(255),
  `fld_codigo` varchar(255),
  `fld_tt_ck` varchar(255),
  `fld_tt_dep` varchar(255),
  `fld_tt_nc` varchar(255),
  `fld_tt_nd` varchar(255)
) */;

--
-- Temporary table structure for view `view_nota_credito_cxp`
--

DROP TABLE IF EXISTS `view_nota_credito_cxp`;
/*!50001 DROP VIEW IF EXISTS `view_nota_credito_cxp`*/;
/*!50001 CREATE TABLE `view_nota_credito_cxp` (
  `fldSupplierID` int(11),
  `fldCompany` varchar(450),
  `fldAddress` varchar(450),
  `fldPhone` varchar(450),
  `fldContact` varchar(450),
  `fldLimiteCR` double(12,2),
  `fldBalance` double(12,2),
  `fld_Status` varchar(255),
  `fldBy` varchar(450),
  `fldfax` varchar(450),
  `fldcel` varchar(450),
  `fld_clasificacion` varchar(450),
  `fld_cta_contable` varchar(450),
  `fld_telefono` varchar(450),
  `fld_correo` varchar(450),
  `fld_banco` varchar(450),
  `fld_id` int(11),
  `fld_proveedor_id_nc` int(11),
  `fld_fecha` date,
  `fld_concepto` varchar(765),
  `fld_monto` double(12,2),
  `fld_abono` double(12,2),
  `fld_balance` double(12,2),
  `fld_user` varchar(150),
  `fldstatus` text,
  `fld_ncf_nc_cxp` text,
  `fld_ultimo_abono` double(12,2),
  `fld_chk` varchar(45)
) */;

--
-- Temporary table structure for view `view_nota_debito_cxp`
--

DROP TABLE IF EXISTS `view_nota_debito_cxp`;
/*!50001 DROP VIEW IF EXISTS `view_nota_debito_cxp`*/;
/*!50001 CREATE TABLE `view_nota_debito_cxp` (
  `fldSupplierID` int(11),
  `fldCompany` varchar(450),
  `fldAddress` varchar(450),
  `fldPhone` varchar(450),
  `fldContact` varchar(450),
  `fldLimiteCR` double(12,2),
  `fldBalance` double(12,2),
  `fld_Status` varchar(255),
  `fldBy` varchar(450),
  `fldfax` varchar(450),
  `fldcel` varchar(450),
  `fld_clasificacion` varchar(450),
  `fld_cta_contable` varchar(450),
  `fld_telefono` varchar(450),
  `fld_correo` varchar(450),
  `fld_banco` varchar(450),
  `fld_id` int(11),
  `fld_proveedor_id_nd` int(11),
  `fld_fecha` date,
  `fld_concepto` varchar(2295),
  `fld_monto` double(12,2),
  `fld_user` varchar(450),
  `fldstatus` text,
  `fld_doc_afectado` text,
  `fld_doc_afectado_id` int(11),
  `fld_ncf_nd_cxp` text
) */;

--
-- Temporary table structure for view `view_prestamos_todos`
--

DROP TABLE IF EXISTS `view_prestamos_todos`;
/*!50001 DROP VIEW IF EXISTS `view_prestamos_todos`*/;
/*!50001 CREATE TABLE `view_prestamos_todos` (
  `fld_id_prestamos` int(11),
  `fld_id_del_cliente` int(11),
  `fld_clasificacion` varchar(55),
  `fld_fecha_entrega` date,
  `fld_fecha_termina` date,
  `fld_fecha_calcula_interes` date,
  `fld_cantidad_cuotas` int(11),
  `fld_monto_cuotas_a` decimal(12,2),
  `fld_capital_prestamo` decimal(12,2),
  `fld_monto` decimal(12,2),
  `fld_abono` decimal(12,2),
  `fld_balance` decimal(12,2),
  `fld_usuario` varchar(255),
  `fld_fecha_ultimo_abono` date,
  `fld_status_prestamos` varchar(15),
  `fld_anos` decimal(12,2),
  `fld_interes_p` decimal(12,6),
  `fld_tipo_prestamo` varchar(255),
  `fld_ck_no` varchar(11),
  `fld_tipo_garantia` varchar(50),
  `fld_garantia` varchar(1500),
  `fldFinanciamiento` varchar(2),
  `fldMontoFinan` decimal(12,2),
  `fldMontoInicial` decimal(12,2),
  `fldCodInm` int(11),
  `fldDescInm` varchar(255),
  `fldMetros` decimal(12,2),
  `fldPrecioMetro` decimal(12,2),
  `fldTazaMora` decimal(12,2),
  `fldNota` varchar(1001),
  `IDVehiculo` int(11),
  `GastosLegales` decimal(12,2),
  `Seguro` decimal(12,2),
  `fld_id` int(11),
  `TipoDocumento` int(11),
  `fld_FullName` varchar(255),
  `fld_apodo` varchar(55),
  `fld_Identity` varchar(16),
  `fld_Phone` varchar(255),
  `fld_Phone2` varchar(255),
  `fld_Address` varchar(255),
  `fld_City_id` int(11),
  `fld_City` varchar(55),
  `fld_Status` varchar(6),
  `fld_bce` double(11,2),
  `fld_cod_zona` int(11),
  `fld_zona` varchar(255),
  `fld_nombre_con` varchar(55),
  `fld_apodo_con` varchar(55),
  `fld_cedula_con` varchar(16),
  `fld_telefono_con` varchar(14),
  `fld_celular_con` varchar(13),
  `fld_ref_personales_cliente` varchar(510),
  `fld_ref_comerciales_cliente` varchar(510),
  `fld_nombre_gar` varchar(55),
  `fld_apodo_gar` varchar(55),
  `fld_cedula_gar` varchar(16),
  `fld_telefono_gar` varchar(13),
  `fld_celular_gar` varchar(13),
  `fld_direccion_gar` varchar(255),
  `fld_ciudad_gar` varchar(55),
  `fld_ref_personales_gar` varchar(510),
  `fld_ref_comerciales_gar` varchar(510),
  `fld_ingresos_mesuales` double(12,2),
  `fld_nombre_banco1` varchar(1000),
  `fld_cuenta_banco1` varchar(15),
  `fld_nombre_banco2` varchar(1000),
  `fld_cuenta_banco2` varchar(15),
  `fld_otra_informacion` varchar(1000),
  `fld_nombre_con_gar` varchar(55),
  `fld_apodo_con_gar` varchar(55),
  `fld_cedula_con_gar` varchar(16),
  `fld_telefono_con_gar` varchar(13),
  `fld_celular_con_gar` varchar(13),
  `fld_edad` date,
  `fld_estado_civil` varchar(15),
  `fld_edad_gar` int(50),
  `fld_estado_civil_gar` varchar(15),
  `fld_ocupacion_cliente` varchar(55),
  `fld_ocupacion_gar` varchar(55),
  `fld_sector_id` int(11),
  `fld_sector` varchar(255),
  `fld_categoria` varchar(25),
  `fld_limite` double(12,2),
  `Puesto` varchar(100),
  `TimpoTrabajo` varchar(100),
  `ReferidoPor` varchar(100),
  `Oriundo` varchar(100),
  `DataCredito` int(1),
  `ctaContable` char(200),
  `email` varchar(255),
  `fechaIngreso` date,
  `whatsapp` varchar(13),
  `whatsapp_con` varchar(13),
  `parentezco_gar` varchar(20),
  `fecha_nac_gar` date,
  `whatsapp_gar` varchar(13),
  `email_gar` varchar(255),
  `empresa_gar` varchar(50),
  `telefono_Empresa_gar` varchar(13),
  `agno_labor_gar` int(50),
  `salario_gar` double(10,2),
  `whatsapp_con_gar` varchar(13),
  `fld_ref_parentesco_clie1` varchar(20),
  `fld_ced_ref_personal_clie1` varchar(16),
  `fld_tel_ref_personal_clie1` varchar(13),
  `fld_cel_ref_personal_clie1` varchar(13),
  `fld_whatsapp_ref_personal_clie1` varchar(13),
  `fld_ref_personal_clie2` varchar(50),
  `fld_ref_parentesco_clie2` varchar(20),
  `fld_ced_ref_personal_clie2` varchar(16),
  `fld_tel_ref_personal_clie2` varchar(13),
  `fld_cel_ref_personal_clie2` varchar(13),
  `fld_whatsapp_ref_personal_clie2` varchar(13),
  `Fld_Dir_Ref_Com_Clie1` varchar(255),
  `Fld_Rnc_Refe_Com_Clie1` varchar(9),
  `Fld_Tel_Com_clie1` varchar(13),
  `Fld_Whatsapp_Com_Clie1` varchar(13),
  `fld_ref_comerciales_cliente2` varchar(50),
  `Fld_Dir_Ref_Com_Clie2` varchar(255),
  `Fld_Rnc_Refe_Com_Clie2` varchar(9),
  `Fld_Tel_Com_clie2` varchar(13),
  `Fld_Whatsapp_Com_Clie2` varchar(13),
  `fld_parentesco_ref_gar1` varchar(20),
  `fld_cedula_ref_gar1` varchar(16),
  `fld_tel_ref_gar1` varchar(13),
  `fld_cel_ref_gar1` varchar(13),
  `fld_whatsapp_ref_gar1` varchar(13),
  `fld_ref_personal_gar2` varchar(50),
  `fld_parentesco_ref_gar2` varchar(20),
  `fld_cedula_ref_gar2` varchar(16),
  `fld_tel_ref_gar2` varchar(13),
  `fld_cel_ref_gar2` varchar(13),
  `fld_whatsapp_ref_gar2` varchar(13),
  `Fdl_Dir_Emp_Gar1` varchar(255),
  `Fld_Rnc_Emp_Gar1` varchar(11),
  `Fld_Tel_Emp_Gar1` varchar(13),
  `Fld_Whatsapp_emp_Gar1` varchar(13),
  `Fld_Empra_Gar2` varchar(50),
  `Fld_Dir_Emp_Gar2` varchar(255),
  `Fld_Rnc_Emp_Gar2` varchar(11),
  `Fld_Tel_Emp_Gar2` varchar(13),
  `Fld_Whatsapp_Emp_Gar2` varchar(13),
  `fld_nom_ref_flia_clie1` varchar(50),
  `fld_parentesco_ref_flia_clie1` varchar(50),
  `fld_ced_ref_flia_clie1` varchar(16),
  `fld_tel_ref_flia_clie1` varchar(13),
  `fld_cel_ref_flia_clie1` varchar(13),
  `fld_whatsapp_ref_flia_clie1` varchar(13),
  `fld_nom_ref_flia_clie2` varchar(50),
  `fld_parentesco_ref_flia_clie2` varchar(20),
  `fld_ced_ref_flia_clie2` varchar(16),
  `fld_tel_ref_flia_clie2` varchar(13),
  `fld_cel_ref_flia_clie2` varchar(13),
  `fld_whats_ref_flia_clie2` varchar(13),
  `fld_provincia_id` int(11),
  `fld_provincia` varchar(255)
) */;

--
-- Temporary table structure for view `view_retiros`
--

DROP TABLE IF EXISTS `view_retiros`;
/*!50001 DROP VIEW IF EXISTS `view_retiros`*/;
/*!50001 CREATE TABLE `view_retiros` (
  `ID` int(11),
  `IDAhorro` int(11),
  `IDCliente` int(11),
  `Fecha` datetime,
  `Tipo` varchar(25),
  `Concepto` varchar(150),
  `Monto` decimal(12,2),
  `Usuario` varchar(255),
  `fld_id` int(11),
  `TipoDocumento` int(11),
  `fld_FullName` varchar(255),
  `fld_apodo` varchar(55),
  `fld_Identity` varchar(16),
  `fld_Phone` varchar(255),
  `fld_Phone2` varchar(255),
  `fld_Address` varchar(255),
  `fld_City_id` int(11),
  `fld_City` varchar(55),
  `fld_Status` varchar(6),
  `fld_bce` double(11,2),
  `fld_cod_zona` int(11),
  `fld_zona` varchar(255),
  `fld_nombre_con` varchar(55),
  `fld_apodo_con` varchar(55),
  `fld_cedula_con` varchar(16),
  `fld_telefono_con` varchar(14),
  `fld_celular_con` varchar(13),
  `fld_ref_personales_cliente` varchar(510),
  `fld_ref_comerciales_cliente` varchar(510),
  `fld_nombre_gar` varchar(55),
  `fld_apodo_gar` varchar(55),
  `fld_cedula_gar` varchar(16),
  `fld_telefono_gar` varchar(13),
  `fld_celular_gar` varchar(13),
  `fld_direccion_gar` varchar(255),
  `fld_ciudad_gar` varchar(55),
  `fld_ref_personales_gar` varchar(510),
  `fld_ref_comerciales_gar` varchar(510),
  `fld_ingresos_mesuales` double(12,2),
  `fld_nombre_banco1` varchar(1000),
  `fld_cuenta_banco1` varchar(15),
  `fld_nombre_banco2` varchar(1000),
  `fld_cuenta_banco2` varchar(15),
  `fld_otra_informacion` varchar(1000),
  `fld_nombre_con_gar` varchar(55),
  `fld_apodo_con_gar` varchar(55),
  `fld_cedula_con_gar` varchar(16),
  `fld_telefono_con_gar` varchar(13),
  `fld_celular_con_gar` varchar(13),
  `fld_edad` date,
  `fld_estado_civil` varchar(15),
  `fld_edad_gar` int(50),
  `fld_estado_civil_gar` varchar(15),
  `fld_ocupacion_cliente` varchar(55),
  `fld_ocupacion_gar` varchar(55),
  `fld_sector_id` int(11),
  `fld_sector` varchar(255),
  `fld_categoria` varchar(25),
  `fld_limite` double(12,2),
  `Puesto` varchar(100),
  `TimpoTrabajo` varchar(100),
  `ReferidoPor` varchar(100),
  `Oriundo` varchar(100),
  `DataCredito` int(1)
) */;

--
-- Temporary table structure for view `view_ri_cxc`
--

DROP TABLE IF EXISTS `view_ri_cxc`;
/*!50001 DROP VIEW IF EXISTS `view_ri_cxc`*/;
/*!50001 CREATE TABLE `view_ri_cxc` (
  `fld_id` int(11),
  `TipoDocumento` int(11),
  `fld_FullName` varchar(255),
  `fld_apodo` varchar(55),
  `fld_Identity` varchar(16),
  `fld_Phone` varchar(255),
  `fld_Phone2` varchar(255),
  `fld_Address` varchar(255),
  `fld_City` varchar(55),
  `fld_Status` varchar(6),
  `fld_bce` double(11,2),
  `fld_cod_zona` int(11),
  `fld_zona` varchar(255),
  `fld_nombre_con` varchar(55),
  `fld_apodo_con` varchar(55),
  `fld_cedula_con` varchar(16),
  `fld_telefono_con` varchar(14),
  `fld_celular_con` varchar(13),
  `fld_ref_personales_cliente` varchar(510),
  `fld_ref_comerciales_cliente` varchar(510),
  `fld_nombre_gar` varchar(55),
  `fld_apodo_gar` varchar(55),
  `fld_cedula_gar` varchar(16),
  `fld_telefono_gar` varchar(13),
  `fld_celular_gar` varchar(13),
  `fld_direccion_gar` varchar(255),
  `fld_ciudad_gar` varchar(55),
  `fld_ref_personales_gar` varchar(510),
  `fld_ref_comerciales_gar` varchar(510),
  `fld_ingresos_mesuales` double(12,2),
  `fld_nombre_banco1` varchar(1000),
  `fld_cuenta_banco1` varchar(15),
  `fld_nombre_banco2` varchar(1000),
  `fld_cuenta_banco2` varchar(15),
  `fld_otra_informacion` varchar(1000),
  `fld_nombre_con_gar` varchar(55),
  `fld_apodo_con_gar` varchar(55),
  `fld_cedula_con_gar` varchar(16),
  `fld_telefono_con_gar` varchar(13),
  `fld_celular_con_gar` varchar(13),
  `fld_edad` date,
  `fld_estado_civil` varchar(15),
  `fld_edad_gar` int(50),
  `fld_estado_civil_gar` varchar(15),
  `fld_ocupacion_cliente` varchar(55),
  `fld_ocupacion_gar` varchar(55),
  `fld_sector` varchar(255),
  `fld_categoria` varchar(25),
  `fld_limite` double(12,2),
  `fld_Id_RI` int(11),
  `fld_forma_pago` varchar(255),
  `fld_detalle_forma_pago` varchar(255),
  `fld_id_cliente_ri` int(11),
  `fld_date` datetime,
  `fld_Description` varchar(5500),
  `fld_monto` double(11,2),
  `fld_monto_recibido` double(11,2),
  `fld_fact_afectado` varchar(255),
  `fdl_nd_afectado` varchar(255),
  `fld_User` varchar(255),
  `fld_Estado` varchar(255),
  `fld_id_prestamo` int(11),
  `fld_interes_cobrado` double(12,2),
  `fld_capital_cobrado` double(12,2),
  `fld_mora_cobrada` double(12,2),
  `fld_concepto` varchar(5500),
  `fld_socio` varchar(255),
  `fld_bce_actual` double(12,2),
  `fld_bce_anterior` double(12,2),
  `fld_adelanto` varchar(5),
  `fld_adelanto_aplicado` varchar(5)
) */;

--
-- Temporary table structure for view `view_tabla_prestamos`
--

DROP TABLE IF EXISTS `view_tabla_prestamos`;
/*!50001 DROP VIEW IF EXISTS `view_tabla_prestamos`*/;
/*!50001 CREATE TABLE `view_tabla_prestamos` (
  `fld_id_prestamos` int(11),
  `fld_id_del_cliente` int(11),
  `fld_socio` char(50),
  `fld_socio_rnc` char(50),
  `fld_clasificacion` varchar(55),
  `fld_fecha_entrega` date,
  `fld_fecha_termina` date,
  `fld_fecha_calcula_interes` date,
  `fld_cantidad_cuotas` int(11),
  `fld_monto_cuotas_a` double(12,4),
  `fld_capital_prestamo` double(12,4),
  `fld_monto` double(12,4),
  `fld_abono` double(12,4),
  `fld_balance` double(12,4),
  `fld_usuario` varchar(255),
  `fld_fecha_ultimo_abono` date,
  `fld_status_prestamos` varchar(15),
  `fld_anos` double(12,4),
  `fld_interes_p` double(12,4),
  `fld_tipo_prestamo` varchar(255),
  `fld_ck_no` varchar(11),
  `fld_tipo_garantia` varchar(50),
  `fld_garantia` varchar(1500),
  `fldFinanciamiento` varchar(2),
  `fldMontoFinan` double(12,4),
  `fldMontoInicial` double(12,4),
  `fldCodInm` int(11),
  `fldDescInm` varchar(255),
  `fldMetros` double(12,4),
  `fldPrecioMetro` double(12,4),
  `fldTazaMora` double(12,2),
  `fldNota` varchar(1001),
  `fld_id_cuotas` int(11),
  `fld_no_cuotas` varchar(15),
  `fld_id_del_cliente_cuotas` int(11),
  `fld_id_del_prestamo` int(11),
  `fld_fecha_entrega_cuotas` date,
  `fld_fecha_termina_cuotas` date,
  `fld_fecha_ultimo_abono_cuotas` date,
  `fld_capital_cuota` double(12,2),
  `fld_interes_cuota` double(12,2),
  `fld_monto_cuotas` double(12,2),
  `fld_abono_cuotas` double(12,2),
  `fld_balance_cuotas` double(12,2),
  `fld_usuario_cuotas` varchar(255),
  `fld_status_cuotas` varchar(255),
  `fld_pendiente_amortizar` double(12,3),
  `fld_total_amortizado` double(12,3),
  `fld_capital_cuota_abono` double(12,2),
  `fld_capital_cuota_balance` double(12,2),
  `fld_interes_cuota_abono` double(12,2),
  `fld_interes_cuota_balance` double(12,2),
  `fld_ultimo_abono_interes` double(12,2),
  `fld_ultimo_abono_capital` double(12,2),
  `fld_monto_mora` double(12,2),
  `fld_abono_mora` double(12,2),
  `fld_balance_mora` double(12,2),
  `fld_ultimo_abono_mora` double(12,2),
  `fld_dias_vencimiento` int(11),
  `fld_atraso_cuotas` double(12,2),
  `fld_tipo_cuotas` varchar(255),
  `fld_bce_prestamo` double(12,2),
  `fld_cant_cuotas` double(12,2),
  `fldchk` varchar(6),
  `fld_termina_calculo_interes` varchar(6),
  `fld_fecha_calculo_interes` date
) */;

--
-- Table structure for table `webahorros`
--

DROP TABLE IF EXISTS `webahorros`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `webahorros` (
  `ID` int(11) NOT NULL,
  `Fecha` date default NULL,
  `IDCliente` int(11) default '0',
  `Monto` decimal(12,4) default '0.0000',
  UNIQUE KEY `idxahorro` (`ID`,`IDCliente`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `webahorros`
--

LOCK TABLES `webahorros` WRITE;
/*!40000 ALTER TABLE `webahorros` DISABLE KEYS */;
/*!40000 ALTER TABLE `webahorros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `webclientes`
--

DROP TABLE IF EXISTS `webclientes`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `webclientes` (
  `ID` int(11) NOT NULL,
  `Cliente` varchar(255) NOT NULL,
  `Cedula` varchar(255) NOT NULL,
  `Correo` varchar(255) default NULL,
  `Clave` text,
  UNIQUE KEY `idxcliente` (`ID`,`Cedula`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `webclientes`
--

LOCK TABLES `webclientes` WRITE;
/*!40000 ALTER TABLE `webclientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `webclientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `webretiros`
--

DROP TABLE IF EXISTS `webretiros`;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE TABLE `webretiros` (
  `ID` int(11) NOT NULL auto_increment,
  `Fecha` date default NULL,
  `IDCliente` int(11) default '0',
  `Monto` decimal(12,4) default '0.0000',
  PRIMARY KEY  (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
SET character_set_client = @saved_cs_client;

--
-- Dumping data for table `webretiros`
--

LOCK TABLES `webretiros` WRITE;
/*!40000 ALTER TABLE `webretiros` DISABLE KEYS */;
/*!40000 ALTER TABLE `webretiros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `wiew_cuentasprestamo`
--

DROP TABLE IF EXISTS `wiew_cuentasprestamo`;
/*!50001 DROP VIEW IF EXISTS `wiew_cuentasprestamo`*/;
/*!50001 CREATE TABLE `wiew_cuentasprestamo` (
  `Descripcion` varchar(240)
) */;

--
-- Temporary table structure for view `wiew_cuentasprestamos`
--

DROP TABLE IF EXISTS `wiew_cuentasprestamos`;
/*!50001 DROP VIEW IF EXISTS `wiew_cuentasprestamos`*/;
/*!50001 CREATE TABLE `wiew_cuentasprestamos` (
  `CuentaNo` varchar(45),
  `Descripcion` varchar(240)
) */;

--
-- Final view structure for view `_viewlibretadepositos`
--

/*!50001 DROP TABLE `_viewlibretadepositos`*/;
/*!50001 DROP VIEW IF EXISTS `_viewlibretadepositos`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `_viewlibretadepositos` AS select distinct `d`.`Fecha` AS `fecha`,`d`.`Monto` AS `Depositos`,`va`.`SaldoInteres` AS `Intereses`,`va`.`SaldoCapital` AS `Balance`,`d`.`Usuario` AS `Cajero`,`va`.`Descripcion` AS `Descripcion`,`d`.`IDCliente` AS `idcliente`,`va`.`fld_FullName` AS `fld_FullName`,`va`.`CuentaNo` AS `CuentaNo` from (`tbl_ahorros_depositos` `d` join `view_ahorros` `va` on((`d`.`IDCliente` = `va`.`IDCliente`))) */;

--
-- Final view structure for view `ventaview`
--

/*!50001 DROP TABLE `ventaview`*/;
/*!50001 DROP VIEW IF EXISTS `ventaview`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `ventaview` AS select `venta`.`ID` AS `ID`,`venta`.`DocNo` AS `DocNo`,`venta`.`Fecha` AS `Fecha`,`tbl_clientes`.`fld_FullName` AS `fld_FullName`,`tbl_clientes`.`fld_apodo` AS `fld_apodo`,`tbl_clientes`.`fld_Identity` AS `fld_Identity`,`tbl_clientes`.`fld_Phone` AS `fld_Phone`,`tbl_clientes`.`fld_Phone2` AS `fld_Phone2`,`tbl_clientes`.`fld_Address` AS `fld_Address`,`tbl_clientes`.`fld_City` AS `fld_City`,`ventacondicion`.`Descripcion` AS `Condicion`,`ncftipo`.`Descripcion` AS `TipoNCF`,`venta`.`NCF` AS `NCF`,`formapago`.`Descripcion` AS `FormaPago`,`venta`.`DescripcionPago` AS `DescripcionPago`,`vendedor`.`Descripcion` AS `Vendedor`,`vendedor`.`Comision` AS `Comision`,`moneda`.`Descripcion` AS `Moneda`,`moneda`.`tasa` AS `tasa`,`venta`.`Nota` AS `NotaVenta`,`almacen`.`Descripcion` AS `Almacen`,`venta`.`Monto` AS `Monto`,`venta`.`Itbis` AS `Itbis`,`venta`.`Descuento` AS `Descuento`,`venta`.`Abono` AS `Abono`,`vehiculotipo`.`Descripcion` AS `TipoVehiculo`,`vehiculomarca`.`Descripcion` AS `Marca`,`vehiculomodelo`.`Descripcion` AS `Modelo`,`ventadetallefinanciamiento`.`Chasis` AS `Chasis`,`vehiculoestado`.`Descripcion` AS `EstadoVehiculo`,`vehiculocolor`.`Descripcion` AS `Color`,`vehiculotransmision`.`Descripcion` AS `Transmision`,`vehiculotraccion`.`Descripcion` AS `Traccion`,`ventadetallefinanciamiento`.`Kilometraje` AS `Kilometraje`,`ventadetallefinanciamiento`.`Ano` AS `Ano`,`ventadetallefinanciamiento`.`Importado` AS `Importado`,`ventadetallefinanciamiento`.`Nota` AS `Nota`,`ventadetallefinanciamiento`.`Caracteristicas` AS `Caracteristicas` from (((((((((((((((`venta` join `ventadetallefinanciamiento` on((`venta`.`ID` = `ventadetallefinanciamiento`.`IDVenta`))) join `tbl_clientes` on((`tbl_clientes`.`fld_id` = `venta`.`IDCliente`))) join `ventacondicion` on((`ventacondicion`.`ID` = `venta`.`IDCondicion`))) join `ncftipo` on((`ncftipo`.`ID` = `venta`.`IDTipoNCF`))) join `formapago` on((`formapago`.`ID` = `venta`.`IDFormaPago`))) join `vendedor` on((`vendedor`.`ID` = `venta`.`IDVendedor`))) join `moneda` on((`moneda`.`ID` = `venta`.`IDMoneda`))) join `almacen` on((`almacen`.`ID` = `venta`.`IDAlmacen`))) join `vehiculotipo` on((`vehiculotipo`.`ID` = `ventadetallefinanciamiento`.`IDTipo`))) join `vehiculomarca` on((`vehiculomarca`.`ID` = `ventadetallefinanciamiento`.`IDMarca`))) join `vehiculomodelo` on((`vehiculomodelo`.`ID` = `ventadetallefinanciamiento`.`IDModelo`))) join `vehiculoestado` on((`vehiculoestado`.`ID` = `ventadetallefinanciamiento`.`IDEstado`))) join `vehiculocolor` on((`vehiculocolor`.`ID` = `ventadetallefinanciamiento`.`IDColor`))) join `vehiculotransmision` on((`vehiculotransmision`.`ID` = `ventadetallefinanciamiento`.`IDTransmision`))) join `vehiculotraccion` on((`vehiculotraccion`.`ID` = `ventadetallefinanciamiento`.`IDTraccion`))) */;

--
-- Final view structure for view `view_ahorros`
--

/*!50001 DROP TABLE `view_ahorros`*/;
/*!50001 DROP VIEW IF EXISTS `view_ahorros`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_ahorros` AS (select distinct `a`.`ID` AS `ID`,`a`.`IDCliente` AS `IDCliente`,`a`.`CuentaNo` AS `CuentaNo`,`a`.`FechaApertura` AS `FechaApertura`,`a`.`FechaCancelada` AS `FechaCancelada`,`a`.`TasaIteres` AS `TasaIteres`,`a`.`SaldoCapital` AS `SaldoCapital`,`a`.`SaldoInteres` AS `SaldoInteres`,`a`.`SaldoRetiros` AS `SaldoRetiros`,`a`.`Usuario` AS `Usuario`,`a`.`Nota` AS `Nota`,`a`.`Categoria` AS `Categoria`,`a`.`Estado` AS `Estado`,`ac`.`Descripcion` AS `Descripcion`,`c`.`fld_id` AS `fld_id`,`c`.`TipoDocumento` AS `TipoDocumento`,`c`.`fld_FullName` AS `fld_FullName`,`c`.`fld_apodo` AS `fld_apodo`,`c`.`fld_Identity` AS `fld_Identity`,`c`.`fld_Phone` AS `fld_Phone`,`c`.`fld_Phone2` AS `fld_Phone2`,`c`.`fld_Address` AS `fld_Address`,`c`.`fld_City_id` AS `fld_City_id`,`c`.`fld_City` AS `fld_City`,`c`.`fld_Status` AS `fld_Status`,`c`.`fld_bce` AS `fld_bce`,`c`.`fld_cod_zona` AS `fld_cod_zona`,`c`.`fld_zona` AS `fld_zona`,`c`.`fld_nombre_con` AS `fld_nombre_con`,`c`.`fld_apodo_con` AS `fld_apodo_con`,`c`.`fld_cedula_con` AS `fld_cedula_con`,`c`.`fld_telefono_con` AS `fld_telefono_con`,`c`.`fld_celular_con` AS `fld_celular_con`,`c`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`,`c`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`,`c`.`fld_nombre_gar` AS `fld_nombre_gar`,`c`.`fld_apodo_gar` AS `fld_apodo_gar`,`c`.`fld_cedula_gar` AS `fld_cedula_gar`,`c`.`fld_telefono_gar` AS `fld_telefono_gar`,`c`.`fld_celular_gar` AS `fld_celular_gar`,`c`.`fld_direccion_gar` AS `fld_direccion_gar`,`c`.`fld_ciudad_gar` AS `fld_ciudad_gar`,`c`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`,`c`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`,`c`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`,`c`.`fld_nombre_banco1` AS `fld_nombre_banco1`,`c`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`,`c`.`fld_nombre_banco2` AS `fld_nombre_banco2`,`c`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`,`c`.`fld_otra_informacion` AS `fld_otra_informacion`,`c`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`,`c`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`,`c`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`,`c`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`,`c`.`fld_celular_con_gar` AS `fld_celular_con_gar`,`c`.`fld_edad` AS `fld_edad`,`c`.`fld_estado_civil` AS `fld_estado_civil`,`c`.`fld_edad_gar` AS `fld_edad_gar`,`c`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`,`c`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`,`c`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`,`c`.`fld_sector_id` AS `fld_sector_id`,`c`.`fld_sector` AS `fld_sector`,`c`.`fld_categoria` AS `fld_categoria`,`c`.`fld_limite` AS `fld_limite`,`c`.`Puesto` AS `Puesto`,`c`.`TimpoTrabajo` AS `TimpoTrabajo`,`c`.`ReferidoPor` AS `ReferidoPor`,`c`.`Oriundo` AS `Oriundo`,`c`.`DataCredito` AS `DataCredito`,`ar`.`IDAhorro` AS `idAhorro`,`ad`.`IDCuenta` AS `idcuenta`,`ad`.`Monto` AS `Deposito`,`ad`.`Fecha` AS `Fecha` from ((((`tbl_ahorros_cuentas` `a` join `tbl_ahorros_categorias` `ac` on((`a`.`Categoria` = `ac`.`ID`))) join `tbl_clientes` `c` on((`c`.`fld_id` = `a`.`IDCliente`))) join `tbl_ahorros_retiros` `ar` on((`ar`.`IDCliente` = `c`.`fld_id`))) join `tbl_ahorros_depositos` `ad` on((`ad`.`IDCliente` = `ar`.`IDCliente`))) group by `a`.`ID`) */;

--
-- Final view structure for view `view_ahorros_depositos`
--

/*!50001 DROP TABLE `view_ahorros_depositos`*/;
/*!50001 DROP VIEW IF EXISTS `view_ahorros_depositos`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_ahorros_depositos` AS (select `d`.`ID` AS `ID`,`d`.`Fecha` AS `Fecha`,`d`.`IDCuenta` AS `IDCuenta`,`d`.`IDCliente` AS `IDCliente`,`d`.`Monto` AS `Monto`,`d`.`Notas` AS `Notas`,`d`.`Usuario` AS `Usuario`,`d`.`IdCaja` AS `IdCaja`,`d`.`Dosmil` AS `Dosmil`,`d`.`Mil` AS `Mil`,`d`.`Quiniento` AS `Quiniento`,`d`.`DosCiento` AS `DosCiento`,`d`.`Cien` AS `Cien`,`d`.`Cincuenta` AS `Cincuenta`,`d`.`Veinticinco` AS `Veinticinco`,`d`.`Diez` AS `Diez`,`d`.`Cinco` AS `Cinco`,`d`.`Cheque` AS `Cheque`,`d`.`Uno` AS `Uno`,`c`.`fld_id` AS `fld_id`,`c`.`TipoDocumento` AS `TipoDocumento`,`c`.`fld_FullName` AS `fld_FullName`,`c`.`fld_apodo` AS `fld_apodo`,`c`.`fld_Identity` AS `fld_Identity`,`c`.`fld_Phone` AS `fld_Phone`,`c`.`fld_Phone2` AS `fld_Phone2`,`c`.`fld_Address` AS `fld_Address`,`c`.`fld_City_id` AS `fld_City_id`,`c`.`fld_City` AS `fld_City`,`c`.`fld_Status` AS `fld_Status`,`c`.`fld_bce` AS `fld_bce`,`c`.`fld_cod_zona` AS `fld_cod_zona`,`c`.`fld_zona` AS `fld_zona`,`c`.`fld_nombre_con` AS `fld_nombre_con`,`c`.`fld_apodo_con` AS `fld_apodo_con`,`c`.`fld_cedula_con` AS `fld_cedula_con`,`c`.`fld_telefono_con` AS `fld_telefono_con`,`c`.`fld_celular_con` AS `fld_celular_con`,`c`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`,`c`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`,`c`.`fld_nombre_gar` AS `fld_nombre_gar`,`c`.`fld_apodo_gar` AS `fld_apodo_gar`,`c`.`fld_cedula_gar` AS `fld_cedula_gar`,`c`.`fld_telefono_gar` AS `fld_telefono_gar`,`c`.`fld_celular_gar` AS `fld_celular_gar`,`c`.`fld_direccion_gar` AS `fld_direccion_gar`,`c`.`fld_ciudad_gar` AS `fld_ciudad_gar`,`c`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`,`c`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`,`c`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`,`c`.`fld_nombre_banco1` AS `fld_nombre_banco1`,`c`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`,`c`.`fld_nombre_banco2` AS `fld_nombre_banco2`,`c`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`,`c`.`fld_otra_informacion` AS `fld_otra_informacion`,`c`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`,`c`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`,`c`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`,`c`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`,`c`.`fld_celular_con_gar` AS `fld_celular_con_gar`,`c`.`fld_edad` AS `fld_edad`,`c`.`fld_estado_civil` AS `fld_estado_civil`,`c`.`fld_edad_gar` AS `fld_edad_gar`,`c`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`,`c`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`,`c`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`,`c`.`fld_sector_id` AS `fld_sector_id`,`c`.`fld_sector` AS `fld_sector`,`c`.`fld_categoria` AS `fld_categoria`,`c`.`fld_limite` AS `fld_limite`,`c`.`Puesto` AS `Puesto`,`c`.`TimpoTrabajo` AS `TimpoTrabajo`,`c`.`ReferidoPor` AS `ReferidoPor`,`c`.`Oriundo` AS `Oriundo`,`c`.`DataCredito` AS `DataCredito`,`c`.`ctaContable` AS `ctaContable`,`c`.`email` AS `email`,`c`.`fechaIngreso` AS `fechaIngreso`,`c`.`whatsapp` AS `whatsapp`,`c`.`whatsapp_con` AS `whatsapp_con`,`c`.`parentezco_gar` AS `parentezco_gar`,`c`.`fecha_nac_gar` AS `fecha_nac_gar`,`c`.`whatsapp_gar` AS `whatsapp_gar`,`c`.`email_gar` AS `email_gar`,`c`.`empresa_gar` AS `empresa_gar`,`c`.`telefono_Empresa_gar` AS `telefono_Empresa_gar`,`c`.`agno_labor_gar` AS `agno_labor_gar`,`c`.`salario_gar` AS `salario_gar`,`c`.`whatsapp_con_gar` AS `whatsapp_con_gar`,`c`.`fld_ref_parentesco_clie1` AS `fld_ref_parentesco_clie1`,`c`.`fld_ced_ref_personal_clie1` AS `fld_ced_ref_personal_clie1`,`c`.`fld_tel_ref_personal_clie1` AS `fld_tel_ref_personal_clie1`,`c`.`fld_cel_ref_personal_clie1` AS `fld_cel_ref_personal_clie1`,`c`.`fld_whatsapp_ref_personal_clie1` AS `fld_whatsapp_ref_personal_clie1`,`c`.`fld_ref_personal_clie2` AS `fld_ref_personal_clie2`,`c`.`fld_ref_parentesco_clie2` AS `fld_ref_parentesco_clie2`,`c`.`fld_ced_ref_personal_clie2` AS `fld_ced_ref_personal_clie2`,`c`.`fld_tel_ref_personal_clie2` AS `fld_tel_ref_personal_clie2`,`c`.`fld_cel_ref_personal_clie2` AS `fld_cel_ref_personal_clie2`,`c`.`fld_whatsapp_ref_personal_clie2` AS `fld_whatsapp_ref_personal_clie2`,`c`.`Fld_Dir_Ref_Com_Clie1` AS `Fld_Dir_Ref_Com_Clie1`,`c`.`Fld_Rnc_Refe_Com_Clie1` AS `Fld_Rnc_Refe_Com_Clie1`,`c`.`Fld_Tel_Com_clie1` AS `Fld_Tel_Com_clie1`,`c`.`Fld_Whatsapp_Com_Clie1` AS `Fld_Whatsapp_Com_Clie1`,`c`.`fld_ref_comerciales_cliente2` AS `fld_ref_comerciales_cliente2`,`c`.`Fld_Dir_Ref_Com_Clie2` AS `Fld_Dir_Ref_Com_Clie2`,`c`.`Fld_Rnc_Refe_Com_Clie2` AS `Fld_Rnc_Refe_Com_Clie2`,`c`.`Fld_Tel_Com_clie2` AS `Fld_Tel_Com_clie2`,`c`.`Fld_Whatsapp_Com_Clie2` AS `Fld_Whatsapp_Com_Clie2`,`c`.`fld_parentesco_ref_gar1` AS `fld_parentesco_ref_gar1`,`c`.`fld_cedula_ref_gar1` AS `fld_cedula_ref_gar1`,`c`.`fld_tel_ref_gar1` AS `fld_tel_ref_gar1`,`c`.`fld_cel_ref_gar1` AS `fld_cel_ref_gar1`,`c`.`fld_whatsapp_ref_gar1` AS `fld_whatsapp_ref_gar1`,`c`.`fld_ref_personal_gar2` AS `fld_ref_personal_gar2`,`c`.`fld_parentesco_ref_gar2` AS `fld_parentesco_ref_gar2`,`c`.`fld_cedula_ref_gar2` AS `fld_cedula_ref_gar2`,`c`.`fld_tel_ref_gar2` AS `fld_tel_ref_gar2`,`c`.`fld_cel_ref_gar2` AS `fld_cel_ref_gar2`,`c`.`fld_whatsapp_ref_gar2` AS `fld_whatsapp_ref_gar2`,`c`.`Fdl_Dir_Emp_Gar1` AS `Fdl_Dir_Emp_Gar1`,`c`.`Fld_Rnc_Emp_Gar1` AS `Fld_Rnc_Emp_Gar1`,`c`.`Fld_Tel_Emp_Gar1` AS `Fld_Tel_Emp_Gar1`,`c`.`Fld_Whatsapp_emp_Gar1` AS `Fld_Whatsapp_emp_Gar1`,`c`.`Fld_Empra_Gar2` AS `Fld_Empra_Gar2`,`c`.`Fld_Dir_Emp_Gar2` AS `Fld_Dir_Emp_Gar2`,`c`.`Fld_Rnc_Emp_Gar2` AS `Fld_Rnc_Emp_Gar2`,`c`.`Fld_Tel_Emp_Gar2` AS `Fld_Tel_Emp_Gar2`,`c`.`Fld_Whatsapp_Emp_Gar2` AS `Fld_Whatsapp_Emp_Gar2`,`c`.`fld_nom_ref_flia_clie1` AS `fld_nom_ref_flia_clie1`,`c`.`fld_parentesco_ref_flia_clie1` AS `fld_parentesco_ref_flia_clie1`,`c`.`fld_ced_ref_flia_clie1` AS `fld_ced_ref_flia_clie1`,`c`.`fld_tel_ref_flia_clie1` AS `fld_tel_ref_flia_clie1`,`c`.`fld_cel_ref_flia_clie1` AS `fld_cel_ref_flia_clie1`,`c`.`fld_whatsapp_ref_flia_clie1` AS `fld_whatsapp_ref_flia_clie1`,`c`.`fld_nom_ref_flia_clie2` AS `fld_nom_ref_flia_clie2`,`c`.`fld_parentesco_ref_flia_clie2` AS `fld_parentesco_ref_flia_clie2`,`c`.`fld_ced_ref_flia_clie2` AS `fld_ced_ref_flia_clie2`,`c`.`fld_tel_ref_flia_clie2` AS `fld_tel_ref_flia_clie2`,`c`.`fld_cel_ref_flia_clie2` AS `fld_cel_ref_flia_clie2`,`c`.`fld_whats_ref_flia_clie2` AS `fld_whats_ref_flia_clie2`,`c`.`fld_provincia_id` AS `fld_provincia_id`,`c`.`fld_provincia` AS `fld_provincia`,`ac`.`CuentaNo` AS `CuentaNo` from ((`tbl_ahorros_depositos` `d` join `tbl_clientes` `c`) join `tbl_ahorros_cuentas` `ac`) where ((`d`.`IDCliente` = `c`.`fld_id`) and (`ac`.`ID` = `d`.`IDCuenta`))) */;

--
-- Final view structure for view `view_ahorros_retiros`
--

/*!50001 DROP TABLE `view_ahorros_retiros`*/;
/*!50001 DROP VIEW IF EXISTS `view_ahorros_retiros`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_ahorros_retiros` AS (select `c`.`fld_id` AS `fld_id`,`c`.`TipoDocumento` AS `TipoDocumento`,`c`.`fld_FullName` AS `fld_FullName`,`c`.`fld_apodo` AS `fld_apodo`,`c`.`fld_Identity` AS `fld_Identity`,`c`.`fld_Phone` AS `fld_Phone`,`c`.`fld_Phone2` AS `fld_Phone2`,`c`.`fld_Address` AS `fld_Address`,`c`.`fld_City_id` AS `fld_City_id`,`c`.`fld_City` AS `fld_City`,`c`.`fld_Status` AS `fld_Status`,`c`.`fld_bce` AS `fld_bce`,`c`.`fld_cod_zona` AS `fld_cod_zona`,`c`.`fld_zona` AS `fld_zona`,`c`.`fld_nombre_con` AS `fld_nombre_con`,`c`.`fld_apodo_con` AS `fld_apodo_con`,`c`.`fld_cedula_con` AS `fld_cedula_con`,`c`.`fld_telefono_con` AS `fld_telefono_con`,`c`.`fld_celular_con` AS `fld_celular_con`,`c`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`,`c`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`,`c`.`fld_nombre_gar` AS `fld_nombre_gar`,`c`.`fld_apodo_gar` AS `fld_apodo_gar`,`c`.`fld_cedula_gar` AS `fld_cedula_gar`,`c`.`fld_telefono_gar` AS `fld_telefono_gar`,`c`.`fld_celular_gar` AS `fld_celular_gar`,`c`.`fld_direccion_gar` AS `fld_direccion_gar`,`c`.`fld_ciudad_gar` AS `fld_ciudad_gar`,`c`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`,`c`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`,`c`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`,`c`.`fld_nombre_banco1` AS `fld_nombre_banco1`,`c`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`,`c`.`fld_nombre_banco2` AS `fld_nombre_banco2`,`c`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`,`c`.`fld_otra_informacion` AS `fld_otra_informacion`,`c`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`,`c`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`,`c`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`,`c`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`,`c`.`fld_celular_con_gar` AS `fld_celular_con_gar`,`c`.`fld_edad` AS `fld_edad`,`c`.`fld_estado_civil` AS `fld_estado_civil`,`c`.`fld_edad_gar` AS `fld_edad_gar`,`c`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`,`c`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`,`c`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`,`c`.`fld_sector_id` AS `fld_sector_id`,`c`.`fld_sector` AS `fld_sector`,`c`.`fld_categoria` AS `fld_categoria`,`c`.`fld_limite` AS `fld_limite`,`c`.`Puesto` AS `Puesto`,`c`.`TimpoTrabajo` AS `TimpoTrabajo`,`c`.`ReferidoPor` AS `ReferidoPor`,`c`.`Oriundo` AS `Oriundo`,`c`.`DataCredito` AS `DataCredito`,`c`.`ctaContable` AS `ctaContable`,`c`.`email` AS `email`,`c`.`fechaIngreso` AS `fechaIngreso`,`c`.`whatsapp` AS `whatsapp`,`c`.`whatsapp_con` AS `whatsapp_con`,`c`.`parentezco_gar` AS `parentezco_gar`,`c`.`fecha_nac_gar` AS `fecha_nac_gar`,`c`.`whatsapp_gar` AS `whatsapp_gar`,`c`.`email_gar` AS `email_gar`,`c`.`empresa_gar` AS `empresa_gar`,`c`.`telefono_Empresa_gar` AS `telefono_Empresa_gar`,`c`.`agno_labor_gar` AS `agno_labor_gar`,`c`.`salario_gar` AS `salario_gar`,`c`.`whatsapp_con_gar` AS `whatsapp_con_gar`,`c`.`fld_ref_parentesco_clie1` AS `fld_ref_parentesco_clie1`,`c`.`fld_ced_ref_personal_clie1` AS `fld_ced_ref_personal_clie1`,`c`.`fld_tel_ref_personal_clie1` AS `fld_tel_ref_personal_clie1`,`c`.`fld_cel_ref_personal_clie1` AS `fld_cel_ref_personal_clie1`,`c`.`fld_whatsapp_ref_personal_clie1` AS `fld_whatsapp_ref_personal_clie1`,`c`.`fld_ref_personal_clie2` AS `fld_ref_personal_clie2`,`c`.`fld_ref_parentesco_clie2` AS `fld_ref_parentesco_clie2`,`c`.`fld_ced_ref_personal_clie2` AS `fld_ced_ref_personal_clie2`,`c`.`fld_tel_ref_personal_clie2` AS `fld_tel_ref_personal_clie2`,`c`.`fld_cel_ref_personal_clie2` AS `fld_cel_ref_personal_clie2`,`c`.`fld_whatsapp_ref_personal_clie2` AS `fld_whatsapp_ref_personal_clie2`,`c`.`Fld_Dir_Ref_Com_Clie1` AS `Fld_Dir_Ref_Com_Clie1`,`c`.`Fld_Rnc_Refe_Com_Clie1` AS `Fld_Rnc_Refe_Com_Clie1`,`c`.`Fld_Tel_Com_clie1` AS `Fld_Tel_Com_clie1`,`c`.`Fld_Whatsapp_Com_Clie1` AS `Fld_Whatsapp_Com_Clie1`,`c`.`fld_ref_comerciales_cliente2` AS `fld_ref_comerciales_cliente2`,`c`.`Fld_Dir_Ref_Com_Clie2` AS `Fld_Dir_Ref_Com_Clie2`,`c`.`Fld_Rnc_Refe_Com_Clie2` AS `Fld_Rnc_Refe_Com_Clie2`,`c`.`Fld_Tel_Com_clie2` AS `Fld_Tel_Com_clie2`,`c`.`Fld_Whatsapp_Com_Clie2` AS `Fld_Whatsapp_Com_Clie2`,`c`.`fld_parentesco_ref_gar1` AS `fld_parentesco_ref_gar1`,`c`.`fld_cedula_ref_gar1` AS `fld_cedula_ref_gar1`,`c`.`fld_tel_ref_gar1` AS `fld_tel_ref_gar1`,`c`.`fld_cel_ref_gar1` AS `fld_cel_ref_gar1`,`c`.`fld_whatsapp_ref_gar1` AS `fld_whatsapp_ref_gar1`,`c`.`fld_ref_personal_gar2` AS `fld_ref_personal_gar2`,`c`.`fld_parentesco_ref_gar2` AS `fld_parentesco_ref_gar2`,`c`.`fld_cedula_ref_gar2` AS `fld_cedula_ref_gar2`,`c`.`fld_tel_ref_gar2` AS `fld_tel_ref_gar2`,`c`.`fld_cel_ref_gar2` AS `fld_cel_ref_gar2`,`c`.`fld_whatsapp_ref_gar2` AS `fld_whatsapp_ref_gar2`,`c`.`Fdl_Dir_Emp_Gar1` AS `Fdl_Dir_Emp_Gar1`,`c`.`Fld_Rnc_Emp_Gar1` AS `Fld_Rnc_Emp_Gar1`,`c`.`Fld_Tel_Emp_Gar1` AS `Fld_Tel_Emp_Gar1`,`c`.`Fld_Whatsapp_emp_Gar1` AS `Fld_Whatsapp_emp_Gar1`,`c`.`Fld_Empra_Gar2` AS `Fld_Empra_Gar2`,`c`.`Fld_Dir_Emp_Gar2` AS `Fld_Dir_Emp_Gar2`,`c`.`Fld_Rnc_Emp_Gar2` AS `Fld_Rnc_Emp_Gar2`,`c`.`Fld_Tel_Emp_Gar2` AS `Fld_Tel_Emp_Gar2`,`c`.`Fld_Whatsapp_Emp_Gar2` AS `Fld_Whatsapp_Emp_Gar2`,`c`.`fld_nom_ref_flia_clie1` AS `fld_nom_ref_flia_clie1`,`c`.`fld_parentesco_ref_flia_clie1` AS `fld_parentesco_ref_flia_clie1`,`c`.`fld_ced_ref_flia_clie1` AS `fld_ced_ref_flia_clie1`,`c`.`fld_tel_ref_flia_clie1` AS `fld_tel_ref_flia_clie1`,`c`.`fld_cel_ref_flia_clie1` AS `fld_cel_ref_flia_clie1`,`c`.`fld_whatsapp_ref_flia_clie1` AS `fld_whatsapp_ref_flia_clie1`,`c`.`fld_nom_ref_flia_clie2` AS `fld_nom_ref_flia_clie2`,`c`.`fld_parentesco_ref_flia_clie2` AS `fld_parentesco_ref_flia_clie2`,`c`.`fld_ced_ref_flia_clie2` AS `fld_ced_ref_flia_clie2`,`c`.`fld_tel_ref_flia_clie2` AS `fld_tel_ref_flia_clie2`,`c`.`fld_cel_ref_flia_clie2` AS `fld_cel_ref_flia_clie2`,`c`.`fld_whats_ref_flia_clie2` AS `fld_whats_ref_flia_clie2`,`c`.`fld_provincia_id` AS `fld_provincia_id`,`c`.`fld_provincia` AS `fld_provincia`,`ar`.`ID` AS `ID`,`ar`.`IDAhorro` AS `IDAhorro`,`ar`.`IDCliente` AS `IDCliente`,`ar`.`Fecha` AS `Fecha`,`ar`.`Tipo` AS `Tipo`,`ar`.`Concepto` AS `Concepto`,`ar`.`Monto` AS `Monto`,`ar`.`Usuario` AS `Usuario`,`ar`.`IdCaja` AS `IdCaja`,`ar`.`dosMil` AS `dosMil`,`ar`.`Mil` AS `Mil`,`ar`.`Quiniento` AS `Quiniento`,`ar`.`Dosciento` AS `Dosciento`,`ar`.`Cien` AS `Cien`,`ar`.`Cincuenta` AS `Cincuenta`,`ar`.`Veinticinco` AS `Veinticinco`,`ar`.`Diez` AS `Diez`,`ar`.`Cinco` AS `Cinco`,`ar`.`Cheque` AS `Cheque`,`ar`.`Uno` AS `Uno` from (`tbl_clientes` `c` join `tbl_ahorros_retiros` `ar`) where (`ar`.`IDCliente` = `c`.`fld_id`)) */;

--
-- Final view structure for view `view_clientes_con_prestamos`
--

/*!50001 DROP TABLE `view_clientes_con_prestamos`*/;
/*!50001 DROP VIEW IF EXISTS `view_clientes_con_prestamos`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_clientes_con_prestamos` AS select `tbl_prestamos`.`fld_id_prestamos` AS `fld_id_prestamos`,`tbl_prestamos`.`fld_id_del_cliente` AS `fld_id_del_cliente`,`tbl_prestamos`.`fld_clasificacion` AS `fld_clasificacion`,`tbl_prestamos`.`fld_fecha_entrega` AS `fld_fecha_entrega`,`tbl_prestamos`.`fld_fecha_termina` AS `fld_fecha_termina`,`tbl_prestamos`.`fld_fecha_calcula_interes` AS `fld_fecha_calcula_interes`,`tbl_prestamos`.`fld_cantidad_cuotas` AS `fld_cantidad_cuotas`,`tbl_prestamos`.`fld_monto_cuotas_a` AS `fld_monto_cuotas_a`,`tbl_prestamos`.`fld_capital_prestamo` AS `fld_capital_prestamo`,`tbl_prestamos`.`fld_monto` AS `fld_monto`,`tbl_prestamos`.`fld_abono` AS `fld_abono`,`tbl_prestamos`.`fld_balance` AS `fld_balance`,`tbl_prestamos`.`fld_usuario` AS `fld_usuario`,`tbl_prestamos`.`fld_fecha_ultimo_abono` AS `fld_fecha_ultimo_abono`,`tbl_prestamos`.`fld_status_prestamos` AS `fld_status_prestamos`,`tbl_prestamos`.`fld_anos` AS `fld_anos`,`tbl_prestamos`.`fld_interes_p` AS `fld_interes_p`,`tbl_prestamos`.`fld_tipo_prestamo` AS `fld_tipo_prestamo`,`tbl_prestamos`.`fld_ck_no` AS `fld_ck_no`,`tbl_prestamos`.`fld_tipo_garantia` AS `fld_tipo_garantia`,`tbl_prestamos`.`fld_garantia` AS `fld_garantia`,`tbl_prestamos`.`fldFinanciamiento` AS `fldFinanciamiento`,`tbl_prestamos`.`fldMontoFinan` AS `fldMontoFinan`,`tbl_prestamos`.`fldMontoInicial` AS `fldMontoInicial`,`tbl_prestamos`.`fldCodInm` AS `fldCodInm`,`tbl_prestamos`.`fldDescInm` AS `fldDescInm`,`tbl_prestamos`.`fldMetros` AS `fldMetros`,`tbl_prestamos`.`fldPrecioMetro` AS `fldPrecioMetro`,`tbl_prestamos`.`fldTazaMora` AS `fldTazaMora`,`tbl_prestamos`.`fldNota` AS `fldNota`,`tbl_prestamos`.`IDVehiculo` AS `IDVehiculo`,`tbl_prestamos`.`GastosLegales` AS `GastosLegales`,`tbl_prestamos`.`Seguro` AS `Seguro`,`tbl_clientes`.`fld_id` AS `fld_id`,`tbl_clientes`.`TipoDocumento` AS `TipoDocumento`,`tbl_clientes`.`fld_FullName` AS `fld_FullName`,`tbl_clientes`.`fld_apodo` AS `fld_apodo`,`tbl_clientes`.`fld_Identity` AS `fld_Identity`,`tbl_clientes`.`fld_Phone` AS `fld_Phone`,`tbl_clientes`.`fld_Phone2` AS `fld_Phone2`,`tbl_clientes`.`fld_Address` AS `fld_Address`,`tbl_clientes`.`fld_City_id` AS `fld_City_id`,`tbl_clientes`.`fld_City` AS `fld_City`,`tbl_clientes`.`fld_Status` AS `fld_Status`,`tbl_clientes`.`fld_bce` AS `fld_bce`,`tbl_clientes`.`fld_cod_zona` AS `fld_cod_zona`,`tbl_clientes`.`fld_zona` AS `fld_zona`,`tbl_clientes`.`fld_nombre_con` AS `fld_nombre_con`,`tbl_clientes`.`fld_apodo_con` AS `fld_apodo_con`,`tbl_clientes`.`fld_cedula_con` AS `fld_cedula_con`,`tbl_clientes`.`fld_telefono_con` AS `fld_telefono_con`,`tbl_clientes`.`fld_celular_con` AS `fld_celular_con`,`tbl_clientes`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`,`tbl_clientes`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`,`tbl_clientes`.`fld_nombre_gar` AS `fld_nombre_gar`,`tbl_clientes`.`fld_apodo_gar` AS `fld_apodo_gar`,`tbl_clientes`.`fld_cedula_gar` AS `fld_cedula_gar`,`tbl_clientes`.`fld_telefono_gar` AS `fld_telefono_gar`,`tbl_clientes`.`fld_celular_gar` AS `fld_celular_gar`,`tbl_clientes`.`fld_direccion_gar` AS `fld_direccion_gar`,`tbl_clientes`.`fld_ciudad_gar` AS `fld_ciudad_gar`,`tbl_clientes`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`,`tbl_clientes`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`,`tbl_clientes`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`,`tbl_clientes`.`fld_nombre_banco1` AS `fld_nombre_banco1`,`tbl_clientes`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`,`tbl_clientes`.`fld_nombre_banco2` AS `fld_nombre_banco2`,`tbl_clientes`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`,`tbl_clientes`.`fld_otra_informacion` AS `fld_otra_informacion`,`tbl_clientes`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`,`tbl_clientes`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`,`tbl_clientes`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`,`tbl_clientes`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`,`tbl_clientes`.`fld_celular_con_gar` AS `fld_celular_con_gar`,`tbl_clientes`.`fld_edad` AS `fld_edad`,`tbl_clientes`.`fld_estado_civil` AS `fld_estado_civil`,`tbl_clientes`.`fld_edad_gar` AS `fld_edad_gar`,`tbl_clientes`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`,`tbl_clientes`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`,`tbl_clientes`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`,`tbl_clientes`.`fld_sector_id` AS `fld_sector_id`,`tbl_clientes`.`fld_sector` AS `fld_sector`,`tbl_clientes`.`fld_categoria` AS `fld_categoria`,`tbl_clientes`.`fld_limite` AS `fld_limite`,`tbl_clientes`.`Puesto` AS `Puesto`,`tbl_clientes`.`TimpoTrabajo` AS `TimpoTrabajo`,`tbl_clientes`.`ReferidoPor` AS `ReferidoPor`,`tbl_clientes`.`Oriundo` AS `Oriundo`,`tbl_clientes`.`DataCredito` AS `DataCredito`,`tbl_clientes`.`ctaContable` AS `ctaContable`,`tbl_clientes`.`email` AS `email`,`tbl_clientes`.`fechaIngreso` AS `fechaIngreso`,`tbl_clientes`.`whatsapp` AS `whatsapp`,`tbl_clientes`.`whatsapp_con` AS `whatsapp_con`,`tbl_clientes`.`parentezco_gar` AS `parentezco_gar`,`tbl_clientes`.`fecha_nac_gar` AS `fecha_nac_gar`,`tbl_clientes`.`whatsapp_gar` AS `whatsapp_gar`,`tbl_clientes`.`email_gar` AS `email_gar`,`tbl_clientes`.`empresa_gar` AS `empresa_gar`,`tbl_clientes`.`telefono_Empresa_gar` AS `telefono_Empresa_gar`,`tbl_clientes`.`agno_labor_gar` AS `agno_labor_gar`,`tbl_clientes`.`salario_gar` AS `salario_gar`,`tbl_clientes`.`whatsapp_con_gar` AS `whatsapp_con_gar`,`tbl_clientes`.`fld_ref_parentesco_clie1` AS `fld_ref_parentesco_clie1`,`tbl_clientes`.`fld_ced_ref_personal_clie1` AS `fld_ced_ref_personal_clie1`,`tbl_clientes`.`fld_tel_ref_personal_clie1` AS `fld_tel_ref_personal_clie1`,`tbl_clientes`.`fld_cel_ref_personal_clie1` AS `fld_cel_ref_personal_clie1`,`tbl_clientes`.`fld_whatsapp_ref_personal_clie1` AS `fld_whatsapp_ref_personal_clie1`,`tbl_clientes`.`fld_ref_personal_clie2` AS `fld_ref_personal_clie2`,`tbl_clientes`.`fld_ref_parentesco_clie2` AS `fld_ref_parentesco_clie2`,`tbl_clientes`.`fld_ced_ref_personal_clie2` AS `fld_ced_ref_personal_clie2`,`tbl_clientes`.`fld_tel_ref_personal_clie2` AS `fld_tel_ref_personal_clie2`,`tbl_clientes`.`fld_cel_ref_personal_clie2` AS `fld_cel_ref_personal_clie2`,`tbl_clientes`.`fld_whatsapp_ref_personal_clie2` AS `fld_whatsapp_ref_personal_clie2`,`tbl_clientes`.`Fld_Dir_Ref_Com_Clie1` AS `Fld_Dir_Ref_Com_Clie1`,`tbl_clientes`.`Fld_Rnc_Refe_Com_Clie1` AS `Fld_Rnc_Refe_Com_Clie1`,`tbl_clientes`.`Fld_Tel_Com_clie1` AS `Fld_Tel_Com_clie1`,`tbl_clientes`.`Fld_Whatsapp_Com_Clie1` AS `Fld_Whatsapp_Com_Clie1`,`tbl_clientes`.`fld_ref_comerciales_cliente2` AS `fld_ref_comerciales_cliente2`,`tbl_clientes`.`Fld_Dir_Ref_Com_Clie2` AS `Fld_Dir_Ref_Com_Clie2`,`tbl_clientes`.`Fld_Rnc_Refe_Com_Clie2` AS `Fld_Rnc_Refe_Com_Clie2`,`tbl_clientes`.`Fld_Tel_Com_clie2` AS `Fld_Tel_Com_clie2`,`tbl_clientes`.`Fld_Whatsapp_Com_Clie2` AS `Fld_Whatsapp_Com_Clie2`,`tbl_clientes`.`fld_parentesco_ref_gar1` AS `fld_parentesco_ref_gar1`,`tbl_clientes`.`fld_cedula_ref_gar1` AS `fld_cedula_ref_gar1`,`tbl_clientes`.`fld_tel_ref_gar1` AS `fld_tel_ref_gar1`,`tbl_clientes`.`fld_cel_ref_gar1` AS `fld_cel_ref_gar1`,`tbl_clientes`.`fld_whatsapp_ref_gar1` AS `fld_whatsapp_ref_gar1`,`tbl_clientes`.`fld_ref_personal_gar2` AS `fld_ref_personal_gar2`,`tbl_clientes`.`fld_parentesco_ref_gar2` AS `fld_parentesco_ref_gar2`,`tbl_clientes`.`fld_cedula_ref_gar2` AS `fld_cedula_ref_gar2`,`tbl_clientes`.`fld_tel_ref_gar2` AS `fld_tel_ref_gar2`,`tbl_clientes`.`fld_cel_ref_gar2` AS `fld_cel_ref_gar2`,`tbl_clientes`.`fld_whatsapp_ref_gar2` AS `fld_whatsapp_ref_gar2`,`tbl_clientes`.`Fdl_Dir_Emp_Gar1` AS `Fdl_Dir_Emp_Gar1`,`tbl_clientes`.`Fld_Rnc_Emp_Gar1` AS `Fld_Rnc_Emp_Gar1`,`tbl_clientes`.`Fld_Tel_Emp_Gar1` AS `Fld_Tel_Emp_Gar1`,`tbl_clientes`.`Fld_Whatsapp_emp_Gar1` AS `Fld_Whatsapp_emp_Gar1`,`tbl_clientes`.`Fld_Empra_Gar2` AS `Fld_Empra_Gar2`,`tbl_clientes`.`Fld_Dir_Emp_Gar2` AS `Fld_Dir_Emp_Gar2`,`tbl_clientes`.`Fld_Rnc_Emp_Gar2` AS `Fld_Rnc_Emp_Gar2`,`tbl_clientes`.`Fld_Tel_Emp_Gar2` AS `Fld_Tel_Emp_Gar2`,`tbl_clientes`.`Fld_Whatsapp_Emp_Gar2` AS `Fld_Whatsapp_Emp_Gar2`,`tbl_clientes`.`fld_nom_ref_flia_clie1` AS `fld_nom_ref_flia_clie1`,`tbl_clientes`.`fld_parentesco_ref_flia_clie1` AS `fld_parentesco_ref_flia_clie1`,`tbl_clientes`.`fld_ced_ref_flia_clie1` AS `fld_ced_ref_flia_clie1`,`tbl_clientes`.`fld_tel_ref_flia_clie1` AS `fld_tel_ref_flia_clie1`,`tbl_clientes`.`fld_cel_ref_flia_clie1` AS `fld_cel_ref_flia_clie1`,`tbl_clientes`.`fld_whatsapp_ref_flia_clie1` AS `fld_whatsapp_ref_flia_clie1`,`tbl_clientes`.`fld_nom_ref_flia_clie2` AS `fld_nom_ref_flia_clie2`,`tbl_clientes`.`fld_parentesco_ref_flia_clie2` AS `fld_parentesco_ref_flia_clie2`,`tbl_clientes`.`fld_ced_ref_flia_clie2` AS `fld_ced_ref_flia_clie2`,`tbl_clientes`.`fld_tel_ref_flia_clie2` AS `fld_tel_ref_flia_clie2`,`tbl_clientes`.`fld_cel_ref_flia_clie2` AS `fld_cel_ref_flia_clie2`,`tbl_clientes`.`fld_whats_ref_flia_clie2` AS `fld_whats_ref_flia_clie2`,`tbl_clientes`.`fld_provincia_id` AS `fld_provincia_id`,`tbl_clientes`.`fld_provincia` AS `fld_provincia` from (`tbl_prestamos` join `tbl_clientes`) where (`tbl_prestamos`.`fld_id_del_cliente` = `tbl_clientes`.`fld_id`) */;

--
-- Final view structure for view `view_cont_catalogo`
--

/*!50001 DROP TABLE `view_cont_catalogo`*/;
/*!50001 DROP VIEW IF EXISTS `view_cont_catalogo`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_cont_catalogo` AS (select `cg`.`ID` AS `IDg`,`cg`.`Descripcion` AS `Descripciong`,`cg`.`Origen` AS `Origen`,`c`.`ID` AS `ID`,`c`.`CuentaNo` AS `CuentaNo`,`c`.`Descripcion` AS `Descripcion`,`c`.`Grupo` AS `Grupo`,`c`.`Tipo` AS `Tipo`,`c`.`Debito` AS `Debito`,`c`.`Credito` AS `Credito`,`c`.`Balance` AS `Balance`,`c`.`CtaControl` AS `CtaControl`,`c`.`NombreMes` AS `NombreMes`,`c`.`NumeroMes` AS `NumeroMes`,`c`.`BalanceGeneral` AS `BalanceGeneral`,`c`.`EstadoResultado` AS `EstadoResultado`,`c`.`OrdenEstadoResultado` AS `OrdenEstadoResultado`,`c`.`AccionEstatoResultado` AS `AccionEstatoResultado`,`c`.`VerEnCero` AS `VerEnCero`,`c`.`Fecha` AS `Fecha`,`c`.`Usuario` AS `Usuario` from (`tbl_catalogo` `c` join `tbl_catalogo_grupo` `cg`) where (`c`.`Grupo` = `cg`.`ID`)) */;

--
-- Final view structure for view `view_cont_libro_general`
--

/*!50001 DROP TABLE `view_cont_libro_general`*/;
/*!50001 DROP VIEW IF EXISTS `view_cont_libro_general`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_cont_libro_general` AS select `t`.`TransID` AS `TransID`,`t`.`TransFecha` AS `TransFecha`,`t`.`TransFechaMovimiento` AS `TransFechaMovimiento`,`t`.`TransDescripcion` AS `TransDescripcion`,`t`.`TransIDTipo` AS `TransIDTipo`,`t`.`TransUsuario` AS `TransUsuario`,`t`.`TransEstado` AS `TransEstado`,`t`.`TransIDDoc` AS `TransIDDoc`,`t`.`TransDoc` AS `TransDoc`,`t`.`TransDocDetalle` AS `TransDocDetalle`,`td`.`TransDID` AS `TransDID`,`td`.`TransDIDTrans` AS `TransDIDTrans`,`td`.`TransDCuentaNo` AS `TransDCuentaNo`,`td`.`TransDDescripcionCuenta` AS `TransDDescripcionCuenta`,`td`.`TransDDebito` AS `TransDDebito`,`td`.`TransDCredito` AS `TransDCredito`,`td`.`TransDBalance` AS `TransDBalance`,`c`.`ID` AS `ID`,`c`.`CuentaNo` AS `CuentaNo`,`c`.`Descripcion` AS `Descripcion`,`c`.`Grupo` AS `Grupo`,`c`.`Tipo` AS `Tipo`,`c`.`Debito` AS `Debito`,`c`.`Credito` AS `Credito`,`c`.`Balance` AS `Balance`,`c`.`CtaControl` AS `CtaControl`,`c`.`NombreMes` AS `NombreMes`,`c`.`NumeroMes` AS `NumeroMes`,`c`.`BalanceAnterior` AS `BalanceAnterior`,`c`.`BalanceGeneral` AS `BalanceGeneral`,`c`.`EstadoResultado` AS `EstadoResultado`,`c`.`OrdenEstadoResultado` AS `OrdenEstadoResultado`,`c`.`AccionEstatoResultado` AS `AccionEstatoResultado`,`c`.`VerEnCero` AS `VerEnCero`,`c`.`Fecha` AS `Fecha`,`c`.`Usuario` AS `Usuario`,`c`.`Nivel` AS `Nivel` from ((`tbl_interfascontabletransacciones` `t` join `tbl_interfasecontabletransaccionesdetalles` `td`) join `tbl_catalogo` `c`) where ((`td`.`TransDIDTrans` = `t`.`TransID`) and (`td`.`TransDCuentaNo` = `c`.`CuentaNo`)) */;

--
-- Final view structure for view `view_cont_transacciones`
--

/*!50001 DROP TABLE `view_cont_transacciones`*/;
/*!50001 DROP VIEW IF EXISTS `view_cont_transacciones`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_cont_transacciones` AS (select `t`.`TransID` AS `TransID`,`t`.`TransFecha` AS `TransFecha`,`t`.`TransFechaMovimiento` AS `TransFechaMovimiento`,`t`.`TransDescripcion` AS `TransDescripcion`,`t`.`TransIDTipo` AS `TransIDTipo`,`t`.`TransUsuario` AS `TransUsuario`,`t`.`TransEstado` AS `TransEstado`,`t`.`TransIDDoc` AS `TransIDDoc`,`t`.`TransDoc` AS `TransDoc`,`t`.`TransDocDetalle` AS `TransDocDetalle`,`td`.`TransDID` AS `TransDID`,`td`.`TransDIDTrans` AS `TransDIDTrans`,`td`.`TransDCuentaNo` AS `TransDCuentaNo`,`td`.`TransDDescripcionCuenta` AS `TransDDescripcionCuenta`,`td`.`TransDDebito` AS `TransDDebito`,`td`.`TransDCredito` AS `TransDCredito`,`td`.`TransDBalance` AS `TransDBalance`,`tp`.`fld_id` AS `fld_id`,`tp`.`fld_codigo` AS `fld_codigo`,`tp`.`fld_descripcion` AS `fld_descripcion`,`tp`.`fld_modulo` AS `fld_modulo` from ((`tbl_interfascontabletransacciones` `t` join `tbl_interfasecontabletransaccionesdetalles` `td`) join `tbl_interfascontableotrastipo` `tp`) where ((`td`.`TransDIDTrans` = `t`.`TransID`) and (`t`.`TransIDTipo` = `tp`.`fld_id`))) */;

--
-- Final view structure for view `view_cuotas_todas`
--

/*!50001 DROP TABLE `view_cuotas_todas`*/;
/*!50001 DROP VIEW IF EXISTS `view_cuotas_todas`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_cuotas_todas` AS select `tbl_clientes`.`fld_id` AS `fld_id`,`tbl_clientes`.`TipoDocumento` AS `TipoDocumento`,`tbl_clientes`.`fld_FullName` AS `fld_FullName`,`tbl_clientes`.`fld_apodo` AS `fld_apodo`,`tbl_clientes`.`fld_Identity` AS `fld_Identity`,`tbl_clientes`.`fld_Phone` AS `fld_Phone`,`tbl_clientes`.`fld_Phone2` AS `fld_Phone2`,`tbl_clientes`.`fld_Address` AS `fld_Address`,`tbl_clientes`.`fld_City_id` AS `fld_City_id`,`tbl_clientes`.`fld_City` AS `fld_City`,`tbl_clientes`.`fld_Status` AS `fld_Status`,`tbl_clientes`.`fld_bce` AS `fld_bce`,`tbl_clientes`.`fld_cod_zona` AS `fld_cod_zona`,`tbl_clientes`.`fld_zona` AS `fld_zona`,`tbl_clientes`.`fld_nombre_con` AS `fld_nombre_con`,`tbl_clientes`.`fld_apodo_con` AS `fld_apodo_con`,`tbl_clientes`.`fld_cedula_con` AS `fld_cedula_con`,`tbl_clientes`.`fld_telefono_con` AS `fld_telefono_con`,`tbl_clientes`.`fld_celular_con` AS `fld_celular_con`,`tbl_clientes`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`,`tbl_clientes`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`,`tbl_clientes`.`fld_nombre_gar` AS `fld_nombre_gar`,`tbl_clientes`.`fld_apodo_gar` AS `fld_apodo_gar`,`tbl_clientes`.`fld_cedula_gar` AS `fld_cedula_gar`,`tbl_clientes`.`fld_telefono_gar` AS `fld_telefono_gar`,`tbl_clientes`.`fld_celular_gar` AS `fld_celular_gar`,`tbl_clientes`.`fld_direccion_gar` AS `fld_direccion_gar`,`tbl_clientes`.`fld_ciudad_gar` AS `fld_ciudad_gar`,`tbl_clientes`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`,`tbl_clientes`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`,`tbl_clientes`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`,`tbl_clientes`.`fld_nombre_banco1` AS `fld_nombre_banco1`,`tbl_clientes`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`,`tbl_clientes`.`fld_nombre_banco2` AS `fld_nombre_banco2`,`tbl_clientes`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`,`tbl_clientes`.`fld_otra_informacion` AS `fld_otra_informacion`,`tbl_clientes`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`,`tbl_clientes`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`,`tbl_clientes`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`,`tbl_clientes`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`,`tbl_clientes`.`fld_celular_con_gar` AS `fld_celular_con_gar`,`tbl_clientes`.`fld_edad` AS `fld_edad`,`tbl_clientes`.`fld_estado_civil` AS `fld_estado_civil`,`tbl_clientes`.`fld_edad_gar` AS `fld_edad_gar`,`tbl_clientes`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`,`tbl_clientes`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`,`tbl_clientes`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`,`tbl_clientes`.`fld_sector_id` AS `fld_sector_id`,`tbl_clientes`.`fld_sector` AS `fld_sector`,`tbl_clientes`.`fld_categoria` AS `fld_categoria`,`tbl_clientes`.`fld_limite` AS `fld_limite`,`tbl_clientes`.`Puesto` AS `Puesto`,`tbl_clientes`.`TimpoTrabajo` AS `TimpoTrabajo`,`tbl_clientes`.`ReferidoPor` AS `ReferidoPor`,`tbl_clientes`.`Oriundo` AS `Oriundo`,`tbl_clientes`.`DataCredito` AS `DataCredito`,`tbl_clientes`.`ctaContable` AS `ctaContable`,`tbl_clientes`.`email` AS `email`,`tbl_clientes`.`fechaIngreso` AS `fechaIngreso`,`tbl_clientes`.`whatsapp` AS `whatsapp`,`tbl_clientes`.`whatsapp_con` AS `whatsapp_con`,`tbl_clientes`.`parentezco_gar` AS `parentezco_gar`,`tbl_clientes`.`fecha_nac_gar` AS `fecha_nac_gar`,`tbl_clientes`.`whatsapp_gar` AS `whatsapp_gar`,`tbl_clientes`.`email_gar` AS `email_gar`,`tbl_clientes`.`empresa_gar` AS `empresa_gar`,`tbl_clientes`.`telefono_Empresa_gar` AS `telefono_Empresa_gar`,`tbl_clientes`.`agno_labor_gar` AS `agno_labor_gar`,`tbl_clientes`.`salario_gar` AS `salario_gar`,`tbl_clientes`.`whatsapp_con_gar` AS `whatsapp_con_gar`,`tbl_clientes`.`fld_ref_parentesco_clie1` AS `fld_ref_parentesco_clie1`,`tbl_clientes`.`fld_ced_ref_personal_clie1` AS `fld_ced_ref_personal_clie1`,`tbl_clientes`.`fld_tel_ref_personal_clie1` AS `fld_tel_ref_personal_clie1`,`tbl_clientes`.`fld_cel_ref_personal_clie1` AS `fld_cel_ref_personal_clie1`,`tbl_clientes`.`fld_whatsapp_ref_personal_clie1` AS `fld_whatsapp_ref_personal_clie1`,`tbl_clientes`.`fld_ref_personal_clie2` AS `fld_ref_personal_clie2`,`tbl_clientes`.`fld_ref_parentesco_clie2` AS `fld_ref_parentesco_clie2`,`tbl_clientes`.`fld_ced_ref_personal_clie2` AS `fld_ced_ref_personal_clie2`,`tbl_clientes`.`fld_tel_ref_personal_clie2` AS `fld_tel_ref_personal_clie2`,`tbl_clientes`.`fld_cel_ref_personal_clie2` AS `fld_cel_ref_personal_clie2`,`tbl_clientes`.`fld_whatsapp_ref_personal_clie2` AS `fld_whatsapp_ref_personal_clie2`,`tbl_clientes`.`Fld_Dir_Ref_Com_Clie1` AS `Fld_Dir_Ref_Com_Clie1`,`tbl_clientes`.`Fld_Rnc_Refe_Com_Clie1` AS `Fld_Rnc_Refe_Com_Clie1`,`tbl_clientes`.`Fld_Tel_Com_clie1` AS `Fld_Tel_Com_clie1`,`tbl_clientes`.`Fld_Whatsapp_Com_Clie1` AS `Fld_Whatsapp_Com_Clie1`,`tbl_clientes`.`fld_ref_comerciales_cliente2` AS `fld_ref_comerciales_cliente2`,`tbl_clientes`.`Fld_Dir_Ref_Com_Clie2` AS `Fld_Dir_Ref_Com_Clie2`,`tbl_clientes`.`Fld_Rnc_Refe_Com_Clie2` AS `Fld_Rnc_Refe_Com_Clie2`,`tbl_clientes`.`Fld_Tel_Com_clie2` AS `Fld_Tel_Com_clie2`,`tbl_clientes`.`Fld_Whatsapp_Com_Clie2` AS `Fld_Whatsapp_Com_Clie2`,`tbl_clientes`.`fld_parentesco_ref_gar1` AS `fld_parentesco_ref_gar1`,`tbl_clientes`.`fld_cedula_ref_gar1` AS `fld_cedula_ref_gar1`,`tbl_clientes`.`fld_tel_ref_gar1` AS `fld_tel_ref_gar1`,`tbl_clientes`.`fld_cel_ref_gar1` AS `fld_cel_ref_gar1`,`tbl_clientes`.`fld_whatsapp_ref_gar1` AS `fld_whatsapp_ref_gar1`,`tbl_clientes`.`fld_ref_personal_gar2` AS `fld_ref_personal_gar2`,`tbl_clientes`.`fld_parentesco_ref_gar2` AS `fld_parentesco_ref_gar2`,`tbl_clientes`.`fld_cedula_ref_gar2` AS `fld_cedula_ref_gar2`,`tbl_clientes`.`fld_tel_ref_gar2` AS `fld_tel_ref_gar2`,`tbl_clientes`.`fld_cel_ref_gar2` AS `fld_cel_ref_gar2`,`tbl_clientes`.`fld_whatsapp_ref_gar2` AS `fld_whatsapp_ref_gar2`,`tbl_clientes`.`Fdl_Dir_Emp_Gar1` AS `Fdl_Dir_Emp_Gar1`,`tbl_clientes`.`Fld_Rnc_Emp_Gar1` AS `Fld_Rnc_Emp_Gar1`,`tbl_clientes`.`Fld_Tel_Emp_Gar1` AS `Fld_Tel_Emp_Gar1`,`tbl_clientes`.`Fld_Whatsapp_emp_Gar1` AS `Fld_Whatsapp_emp_Gar1`,`tbl_clientes`.`Fld_Empra_Gar2` AS `Fld_Empra_Gar2`,`tbl_clientes`.`Fld_Dir_Emp_Gar2` AS `Fld_Dir_Emp_Gar2`,`tbl_clientes`.`Fld_Rnc_Emp_Gar2` AS `Fld_Rnc_Emp_Gar2`,`tbl_clientes`.`Fld_Tel_Emp_Gar2` AS `Fld_Tel_Emp_Gar2`,`tbl_clientes`.`Fld_Whatsapp_Emp_Gar2` AS `Fld_Whatsapp_Emp_Gar2`,`tbl_clientes`.`fld_nom_ref_flia_clie1` AS `fld_nom_ref_flia_clie1`,`tbl_clientes`.`fld_parentesco_ref_flia_clie1` AS `fld_parentesco_ref_flia_clie1`,`tbl_clientes`.`fld_ced_ref_flia_clie1` AS `fld_ced_ref_flia_clie1`,`tbl_clientes`.`fld_tel_ref_flia_clie1` AS `fld_tel_ref_flia_clie1`,`tbl_clientes`.`fld_cel_ref_flia_clie1` AS `fld_cel_ref_flia_clie1`,`tbl_clientes`.`fld_whatsapp_ref_flia_clie1` AS `fld_whatsapp_ref_flia_clie1`,`tbl_clientes`.`fld_nom_ref_flia_clie2` AS `fld_nom_ref_flia_clie2`,`tbl_clientes`.`fld_parentesco_ref_flia_clie2` AS `fld_parentesco_ref_flia_clie2`,`tbl_clientes`.`fld_ced_ref_flia_clie2` AS `fld_ced_ref_flia_clie2`,`tbl_clientes`.`fld_tel_ref_flia_clie2` AS `fld_tel_ref_flia_clie2`,`tbl_clientes`.`fld_cel_ref_flia_clie2` AS `fld_cel_ref_flia_clie2`,`tbl_clientes`.`fld_whats_ref_flia_clie2` AS `fld_whats_ref_flia_clie2`,`tbl_clientes`.`fld_provincia_id` AS `fld_provincia_id`,`tbl_clientes`.`fld_provincia` AS `fld_provincia`,`tbl_cuotas`.`fld_id_cuotas` AS `fld_id_cuotas`,`tbl_cuotas`.`fld_no_cuotas` AS `fld_no_cuotas`,`tbl_cuotas`.`fld_id_del_cliente_cuotas` AS `fld_id_del_cliente_cuotas`,`tbl_cuotas`.`fld_id_del_prestamo` AS `fld_id_del_prestamo`,`tbl_cuotas`.`fld_fecha_entrega_cuotas` AS `fld_fecha_entrega_cuotas`,`tbl_cuotas`.`fld_fecha_termina_cuotas` AS `fld_fecha_termina_cuotas`,`tbl_cuotas`.`fld_fecha_calculo_interes` AS `fld_fecha_calculo_interes`,`tbl_cuotas`.`fld_termina_calculo_interes` AS `fld_termina_calculo_interes`,`tbl_cuotas`.`fld_fecha_ultimo_abono_cuotas` AS `fld_fecha_ultimo_abono_cuotas`,`tbl_cuotas`.`fld_capital_cuota` AS `fld_capital_cuota`,`tbl_cuotas`.`fld_interes_cuota` AS `fld_interes_cuota`,`tbl_cuotas`.`fld_monto_cuotas` AS `fld_monto_cuotas`,`tbl_cuotas`.`fld_abono_cuotas` AS `fld_abono_cuotas`,`tbl_cuotas`.`fld_balance_cuotas` AS `fld_balance_cuotas`,`tbl_cuotas`.`fld_usuario_cuotas` AS `fld_usuario_cuotas`,`tbl_cuotas`.`fld_status_cuotas` AS `fld_status_cuotas`,`tbl_cuotas`.`fld_pendiente_amortizar` AS `fld_pendiente_amortizar`,`tbl_cuotas`.`fld_total_amortizado` AS `fld_total_amortizado`,`tbl_cuotas`.`fld_capital_cuota_abono` AS `fld_capital_cuota_abono`,`tbl_cuotas`.`fld_capital_cuota_balance` AS `fld_capital_cuota_balance`,`tbl_cuotas`.`fld_interes_cuota_abono` AS `fld_interes_cuota_abono`,`tbl_cuotas`.`fld_interes_cuota_balance` AS `fld_interes_cuota_balance`,`tbl_cuotas`.`fld_ultimo_abono_interes` AS `fld_ultimo_abono_interes`,`tbl_cuotas`.`fld_ultimo_abono_capital` AS `fld_ultimo_abono_capital`,`tbl_cuotas`.`fld_monto_mora` AS `fld_monto_mora`,`tbl_cuotas`.`fld_abono_mora` AS `fld_abono_mora`,`tbl_cuotas`.`fld_balance_mora` AS `fld_balance_mora`,`tbl_cuotas`.`fld_ultimo_abono_mora` AS `fld_ultimo_abono_mora`,`tbl_cuotas`.`fld_dias_vencimiento` AS `fld_dias_vencimiento`,`tbl_cuotas`.`fld_socio` AS `fld_socio`,`tbl_cuotas`.`fld_atraso_cuotas` AS `fld_atraso_cuotas`,`tbl_cuotas`.`fld_tipo_cuotas` AS `fld_tipo_cuotas`,`tbl_cuotas`.`fld_bce_prestamo` AS `fld_bce_prestamo`,`tbl_cuotas`.`fld_cant_cuotas` AS `fld_cant_cuotas`,`tbl_cuotas`.`fldchk` AS `fldchk`,`tbl_cuotas`.`Tipo` AS `Tipo` from (`tbl_clientes` join `tbl_cuotas`) where (`tbl_clientes`.`fld_id` = `tbl_cuotas`.`fld_id_del_cliente_cuotas`) */;

--
-- Final view structure for view `view_cxc_nota_credito`
--

/*!50001 DROP TABLE `view_cxc_nota_credito`*/;
/*!50001 DROP VIEW IF EXISTS `view_cxc_nota_credito`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_cxc_nota_credito` AS select `tbl_clientes`.`fld_id` AS `fld_id`,`tbl_clientes`.`fld_FullName` AS `fld_FullName`,`tbl_clientes`.`fld_apodo` AS `fld_apodo`,`tbl_clientes`.`fld_Identity` AS `fld_Identity`,`tbl_clientes`.`fld_Phone` AS `fld_Phone`,`tbl_clientes`.`fld_Phone2` AS `fld_Phone2`,`tbl_clientes`.`fld_Address` AS `fld_Address`,`tbl_clientes`.`fld_City` AS `fld_City`,`tbl_clientes`.`fld_Status` AS `fld_Status`,`tbl_clientes`.`fld_bce` AS `fld_bce`,`tbl_clientes`.`fld_cod_zona` AS `fld_cod_zona`,`tbl_clientes`.`fld_zona` AS `fld_zona`,`tbl_clientes`.`fld_nombre_con` AS `fld_nombre_con`,`tbl_clientes`.`fld_apodo_con` AS `fld_apodo_con`,`tbl_clientes`.`fld_cedula_con` AS `fld_cedula_con`,`tbl_clientes`.`fld_telefono_con` AS `fld_telefono_con`,`tbl_clientes`.`fld_celular_con` AS `fld_celular_con`,`tbl_clientes`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`,`tbl_clientes`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`,`tbl_clientes`.`fld_nombre_gar` AS `fld_nombre_gar`,`tbl_clientes`.`fld_apodo_gar` AS `fld_apodo_gar`,`tbl_clientes`.`fld_cedula_gar` AS `fld_cedula_gar`,`tbl_clientes`.`fld_telefono_gar` AS `fld_telefono_gar`,`tbl_clientes`.`fld_celular_gar` AS `fld_celular_gar`,`tbl_clientes`.`fld_direccion_gar` AS `fld_direccion_gar`,`tbl_clientes`.`fld_ciudad_gar` AS `fld_ciudad_gar`,`tbl_clientes`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`,`tbl_clientes`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`,`tbl_clientes`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`,`tbl_clientes`.`fld_nombre_banco1` AS `fld_nombre_banco1`,`tbl_clientes`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`,`tbl_clientes`.`fld_nombre_banco2` AS `fld_nombre_banco2`,`tbl_clientes`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`,`tbl_clientes`.`fld_otra_informacion` AS `fld_otra_informacion`,`tbl_clientes`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`,`tbl_clientes`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`,`tbl_clientes`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`,`tbl_clientes`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`,`tbl_clientes`.`fld_celular_con_gar` AS `fld_celular_con_gar`,`tbl_clientes`.`fld_edad` AS `fld_edad`,`tbl_clientes`.`fld_estado_civil` AS `fld_estado_civil`,`tbl_clientes`.`fld_edad_gar` AS `fld_edad_gar`,`tbl_clientes`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`,`tbl_clientes`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`,`tbl_clientes`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`,`tbl_nc_cxc`.`fld_id_nc_cxc` AS `fld_id_nc_cxc`,`tbl_nc_cxc`.`fld_cliente_id_nc` AS `fld_cliente_id_nc`,`tbl_nc_cxc`.`fld_fecha` AS `fld_fecha`,`tbl_nc_cxc`.`fld_concepto` AS `fld_concepto`,`tbl_nc_cxc`.`fld_monto` AS `fld_monto`,`tbl_nc_cxc`.`fld_user` AS `fld_user`,`tbl_nc_cxc`.`fld_status_nc` AS `fld_status_nc` from (`tbl_clientes` join `tbl_nc_cxc`) where (`tbl_clientes`.`fld_id` = `tbl_nc_cxc`.`fld_cliente_id_nc`) */;

--
-- Final view structure for view `view_cxc_nota_debito`
--

/*!50001 DROP TABLE `view_cxc_nota_debito`*/;
/*!50001 DROP VIEW IF EXISTS `view_cxc_nota_debito`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_cxc_nota_debito` AS select `tbl_clientes`.`fld_id` AS `fld_id`,`tbl_clientes`.`fld_FullName` AS `fld_FullName`,`tbl_clientes`.`fld_apodo` AS `fld_apodo`,`tbl_clientes`.`fld_Identity` AS `fld_Identity`,`tbl_clientes`.`fld_Phone` AS `fld_Phone`,`tbl_clientes`.`fld_Phone2` AS `fld_Phone2`,`tbl_clientes`.`fld_Address` AS `fld_Address`,`tbl_clientes`.`fld_City` AS `fld_City`,`tbl_clientes`.`fld_Status` AS `fld_Status`,`tbl_clientes`.`fld_bce` AS `fld_bce`,`tbl_clientes`.`fld_cod_zona` AS `fld_cod_zona`,`tbl_clientes`.`fld_zona` AS `fld_zona`,`tbl_clientes`.`fld_nombre_con` AS `fld_nombre_con`,`tbl_clientes`.`fld_apodo_con` AS `fld_apodo_con`,`tbl_clientes`.`fld_cedula_con` AS `fld_cedula_con`,`tbl_clientes`.`fld_telefono_con` AS `fld_telefono_con`,`tbl_clientes`.`fld_celular_con` AS `fld_celular_con`,`tbl_clientes`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`,`tbl_clientes`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`,`tbl_clientes`.`fld_nombre_gar` AS `fld_nombre_gar`,`tbl_clientes`.`fld_apodo_gar` AS `fld_apodo_gar`,`tbl_clientes`.`fld_cedula_gar` AS `fld_cedula_gar`,`tbl_clientes`.`fld_telefono_gar` AS `fld_telefono_gar`,`tbl_clientes`.`fld_celular_gar` AS `fld_celular_gar`,`tbl_clientes`.`fld_direccion_gar` AS `fld_direccion_gar`,`tbl_clientes`.`fld_ciudad_gar` AS `fld_ciudad_gar`,`tbl_clientes`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`,`tbl_clientes`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`,`tbl_clientes`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`,`tbl_clientes`.`fld_nombre_banco1` AS `fld_nombre_banco1`,`tbl_clientes`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`,`tbl_clientes`.`fld_nombre_banco2` AS `fld_nombre_banco2`,`tbl_clientes`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`,`tbl_clientes`.`fld_otra_informacion` AS `fld_otra_informacion`,`tbl_clientes`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`,`tbl_clientes`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`,`tbl_clientes`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`,`tbl_clientes`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`,`tbl_clientes`.`fld_celular_con_gar` AS `fld_celular_con_gar`,`tbl_clientes`.`fld_edad` AS `fld_edad`,`tbl_clientes`.`fld_estado_civil` AS `fld_estado_civil`,`tbl_clientes`.`fld_edad_gar` AS `fld_edad_gar`,`tbl_clientes`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`,`tbl_clientes`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`,`tbl_clientes`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`,`tbl_nd_cxc`.`fld_id_nd_cxc` AS `fld_id_nd_cxc`,`tbl_nd_cxc`.`fld_cliente_id_nd` AS `fld_cliente_id_nd`,`tbl_nd_cxc`.`fld_fecha` AS `fld_fecha`,`tbl_nd_cxc`.`fld_concepto` AS `fld_concepto`,`tbl_nd_cxc`.`fld_monto` AS `fld_monto`,`tbl_nd_cxc`.`fld_abono` AS `fld_abono`,`tbl_nd_cxc`.`fld_balance` AS `fld_balance`,`tbl_nd_cxc`.`fld_user` AS `fld_user`,`tbl_nd_cxc`.`fld_status_nd` AS `fld_status_nd`,`tbl_nd_cxc`.`fld_ultimo_abono` AS `fld_ultimo_abono` from (`tbl_clientes` join `tbl_nd_cxc`) where (`tbl_clientes`.`fld_id` = `tbl_nd_cxc`.`fld_cliente_id_nd`) */;

--
-- Final view structure for view `view_depositos`
--

/*!50001 DROP TABLE `view_depositos`*/;
/*!50001 DROP VIEW IF EXISTS `view_depositos`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_depositos` AS select `tbl_bancos`.`fld_id` AS `fld_id`,`tbl_bancos`.`fld_nombre` AS `fld_nombre`,`tbl_bancos`.`fld_cuenta` AS `fld_cuenta`,`tbl_bancos`.`fld_cta_contable` AS `fld_cta_contable`,`tbl_bancos`.`fld_contacto` AS `fld_contacto`,`tbl_bancos`.`fld_sucursal` AS `fld_sucursal`,`tbl_bancos`.`fld_balance` AS `fld_balance`,`tbl_bancos`.`fld_status` AS `fld_status`,`tbl_bancos`.`fld_direccion` AS `fld_direccion`,`tbl_bancos`.`fld_codigo` AS `fld_codigo`,`tbl_bancos`.`fld_tt_ck` AS `fld_tt_ck`,`tbl_bancos`.`fld_tt_dep` AS `fld_tt_dep`,`tbl_bancos`.`fld_tt_nc` AS `fld_tt_nc`,`tbl_bancos`.`fld_tt_nd` AS `fld_tt_nd`,`tbl_deposito`.`fld_id_doc` AS `fld_id_doc`,`tbl_deposito`.`fld_id_banco` AS `fld_id_banco`,`tbl_deposito`.`fld_fecha` AS `fld_fecha`,`tbl_deposito`.`fld_descripcion` AS `fld_descripcion`,`tbl_deposito`.`fld_monto` AS `fld_monto`,`tbl_deposito`.`fld_estado` AS `fld_estado`,`tbl_deposito`.`fld_transito` AS `fld_transito`,`tbl_deposito`.`fld_cod_concepto` AS `fld_cod_concepto`,`tbl_deposito`.`afectacaja` AS `afectacaja` from (`tbl_bancos` join `tbl_deposito`) where (`tbl_bancos`.`fld_codigo` = `tbl_deposito`.`fld_id_banco`) */;

--
-- Final view structure for view `view_estado_banco`
--

/*!50001 DROP TABLE `view_estado_banco`*/;
/*!50001 DROP VIEW IF EXISTS `view_estado_banco`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_estado_banco` AS select `tbl_estado_banco`.`fld_id_ec_b` AS `fld_id_ec_b`,`tbl_estado_banco`.`fld_date` AS `fld_date`,`tbl_estado_banco`.`fld_description` AS `fld_description`,`tbl_estado_banco`.`fld_dr` AS `fld_dr`,`tbl_estado_banco`.`fld_cr` AS `fld_cr`,`tbl_estado_banco`.`fld_bce_banco` AS `fld_bce_banco`,`tbl_estado_banco`.`fld_banco_id` AS `fld_banco_id`,`tbl_estado_banco`.`fld_tipo_doc` AS `fld_tipo_doc`,`tbl_estado_banco`.`fld_tipo_doc_id` AS `fld_tipo_doc_id`,`tbl_estado_banco`.`fld_usuario` AS `fld_usuario`,`tbl_bancos`.`fld_id` AS `fld_id`,`tbl_bancos`.`fld_nombre` AS `fld_nombre`,`tbl_bancos`.`fld_cuenta` AS `fld_cuenta`,`tbl_bancos`.`fld_cta_contable` AS `fld_cta_contable`,`tbl_bancos`.`fld_contacto` AS `fld_contacto`,`tbl_bancos`.`fld_sucursal` AS `fld_sucursal`,`tbl_bancos`.`fld_balance` AS `fld_balance`,`tbl_bancos`.`fld_status` AS `fld_status`,`tbl_bancos`.`fld_direccion` AS `fld_direccion`,`tbl_bancos`.`fld_codigo` AS `fld_codigo`,`tbl_bancos`.`fld_tt_ck` AS `fld_tt_ck`,`tbl_bancos`.`fld_tt_dep` AS `fld_tt_dep`,`tbl_bancos`.`fld_tt_nc` AS `fld_tt_nc`,`tbl_bancos`.`fld_tt_nd` AS `fld_tt_nd` from (`tbl_estado_banco` join `tbl_bancos`) where (`tbl_estado_banco`.`fld_banco_id` = `tbl_bancos`.`fld_codigo`) */;

--
-- Final view structure for view `view_estado_clientes`
--

/*!50001 DROP TABLE `view_estado_clientes`*/;
/*!50001 DROP VIEW IF EXISTS `view_estado_clientes`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_estado_clientes` AS select `tbl_clientes`.`fld_id` AS `fld_id`,`tbl_clientes`.`TipoDocumento` AS `TipoDocumento`,`tbl_clientes`.`fld_FullName` AS `fld_FullName`,`tbl_clientes`.`fld_apodo` AS `fld_apodo`,`tbl_clientes`.`fld_Identity` AS `fld_Identity`,`tbl_clientes`.`fld_Phone` AS `fld_Phone`,`tbl_clientes`.`fld_Phone2` AS `fld_Phone2`,`tbl_clientes`.`fld_Address` AS `fld_Address`,`tbl_clientes`.`fld_City_id` AS `fld_City_id`,`tbl_clientes`.`fld_City` AS `fld_City`,`tbl_clientes`.`fld_Status` AS `fld_Status`,`tbl_clientes`.`fld_bce` AS `fld_bce`,`tbl_clientes`.`fld_cod_zona` AS `fld_cod_zona`,`tbl_clientes`.`fld_zona` AS `fld_zona`,`tbl_clientes`.`fld_nombre_con` AS `fld_nombre_con`,`tbl_clientes`.`fld_apodo_con` AS `fld_apodo_con`,`tbl_clientes`.`fld_cedula_con` AS `fld_cedula_con`,`tbl_clientes`.`fld_telefono_con` AS `fld_telefono_con`,`tbl_clientes`.`fld_celular_con` AS `fld_celular_con`,`tbl_clientes`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`,`tbl_clientes`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`,`tbl_clientes`.`fld_nombre_gar` AS `fld_nombre_gar`,`tbl_clientes`.`fld_apodo_gar` AS `fld_apodo_gar`,`tbl_clientes`.`fld_cedula_gar` AS `fld_cedula_gar`,`tbl_clientes`.`fld_telefono_gar` AS `fld_telefono_gar`,`tbl_clientes`.`fld_celular_gar` AS `fld_celular_gar`,`tbl_clientes`.`fld_direccion_gar` AS `fld_direccion_gar`,`tbl_clientes`.`fld_ciudad_gar` AS `fld_ciudad_gar`,`tbl_clientes`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`,`tbl_clientes`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`,`tbl_clientes`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`,`tbl_clientes`.`fld_nombre_banco1` AS `fld_nombre_banco1`,`tbl_clientes`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`,`tbl_clientes`.`fld_nombre_banco2` AS `fld_nombre_banco2`,`tbl_clientes`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`,`tbl_clientes`.`fld_otra_informacion` AS `fld_otra_informacion`,`tbl_clientes`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`,`tbl_clientes`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`,`tbl_clientes`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`,`tbl_clientes`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`,`tbl_clientes`.`fld_celular_con_gar` AS `fld_celular_con_gar`,`tbl_clientes`.`fld_edad` AS `fld_edad`,`tbl_clientes`.`fld_estado_civil` AS `fld_estado_civil`,`tbl_clientes`.`fld_edad_gar` AS `fld_edad_gar`,`tbl_clientes`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`,`tbl_clientes`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`,`tbl_clientes`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`,`tbl_clientes`.`fld_sector_id` AS `fld_sector_id`,`tbl_clientes`.`fld_sector` AS `fld_sector`,`tbl_clientes`.`fld_categoria` AS `fld_categoria`,`tbl_clientes`.`fld_limite` AS `fld_limite`,`tbl_clientes`.`Puesto` AS `Puesto`,`tbl_clientes`.`TimpoTrabajo` AS `TimpoTrabajo`,`tbl_clientes`.`ReferidoPor` AS `ReferidoPor`,`tbl_clientes`.`Oriundo` AS `Oriundo`,`tbl_clientes`.`DataCredito` AS `DataCredito`,`tbl_clientes`.`ctaContable` AS `ctaContable`,`tbl_clientes`.`email` AS `email`,`tbl_clientes`.`fechaIngreso` AS `fechaIngreso`,`tbl_clientes`.`whatsapp` AS `whatsapp`,`tbl_clientes`.`whatsapp_con` AS `whatsapp_con`,`tbl_clientes`.`parentezco_gar` AS `parentezco_gar`,`tbl_clientes`.`fecha_nac_gar` AS `fecha_nac_gar`,`tbl_clientes`.`whatsapp_gar` AS `whatsapp_gar`,`tbl_clientes`.`email_gar` AS `email_gar`,`tbl_clientes`.`empresa_gar` AS `empresa_gar`,`tbl_clientes`.`telefono_Empresa_gar` AS `telefono_Empresa_gar`,`tbl_clientes`.`agno_labor_gar` AS `agno_labor_gar`,`tbl_clientes`.`salario_gar` AS `salario_gar`,`tbl_clientes`.`whatsapp_con_gar` AS `whatsapp_con_gar`,`tbl_clientes`.`fld_ref_parentesco_clie1` AS `fld_ref_parentesco_clie1`,`tbl_clientes`.`fld_ced_ref_personal_clie1` AS `fld_ced_ref_personal_clie1`,`tbl_clientes`.`fld_tel_ref_personal_clie1` AS `fld_tel_ref_personal_clie1`,`tbl_clientes`.`fld_cel_ref_personal_clie1` AS `fld_cel_ref_personal_clie1`,`tbl_clientes`.`fld_whatsapp_ref_personal_clie1` AS `fld_whatsapp_ref_personal_clie1`,`tbl_clientes`.`fld_ref_personal_clie2` AS `fld_ref_personal_clie2`,`tbl_clientes`.`fld_ref_parentesco_clie2` AS `fld_ref_parentesco_clie2`,`tbl_clientes`.`fld_ced_ref_personal_clie2` AS `fld_ced_ref_personal_clie2`,`tbl_clientes`.`fld_tel_ref_personal_clie2` AS `fld_tel_ref_personal_clie2`,`tbl_clientes`.`fld_cel_ref_personal_clie2` AS `fld_cel_ref_personal_clie2`,`tbl_clientes`.`fld_whatsapp_ref_personal_clie2` AS `fld_whatsapp_ref_personal_clie2`,`tbl_clientes`.`Fld_Dir_Ref_Com_Clie1` AS `Fld_Dir_Ref_Com_Clie1`,`tbl_clientes`.`Fld_Rnc_Refe_Com_Clie1` AS `Fld_Rnc_Refe_Com_Clie1`,`tbl_clientes`.`Fld_Tel_Com_clie1` AS `Fld_Tel_Com_clie1`,`tbl_clientes`.`Fld_Whatsapp_Com_Clie1` AS `Fld_Whatsapp_Com_Clie1`,`tbl_clientes`.`fld_ref_comerciales_cliente2` AS `fld_ref_comerciales_cliente2`,`tbl_clientes`.`Fld_Dir_Ref_Com_Clie2` AS `Fld_Dir_Ref_Com_Clie2`,`tbl_clientes`.`Fld_Rnc_Refe_Com_Clie2` AS `Fld_Rnc_Refe_Com_Clie2`,`tbl_clientes`.`Fld_Tel_Com_clie2` AS `Fld_Tel_Com_clie2`,`tbl_clientes`.`Fld_Whatsapp_Com_Clie2` AS `Fld_Whatsapp_Com_Clie2`,`tbl_clientes`.`fld_parentesco_ref_gar1` AS `fld_parentesco_ref_gar1`,`tbl_clientes`.`fld_cedula_ref_gar1` AS `fld_cedula_ref_gar1`,`tbl_clientes`.`fld_tel_ref_gar1` AS `fld_tel_ref_gar1`,`tbl_clientes`.`fld_cel_ref_gar1` AS `fld_cel_ref_gar1`,`tbl_clientes`.`fld_whatsapp_ref_gar1` AS `fld_whatsapp_ref_gar1`,`tbl_clientes`.`fld_ref_personal_gar2` AS `fld_ref_personal_gar2`,`tbl_clientes`.`fld_parentesco_ref_gar2` AS `fld_parentesco_ref_gar2`,`tbl_clientes`.`fld_cedula_ref_gar2` AS `fld_cedula_ref_gar2`,`tbl_clientes`.`fld_tel_ref_gar2` AS `fld_tel_ref_gar2`,`tbl_clientes`.`fld_cel_ref_gar2` AS `fld_cel_ref_gar2`,`tbl_clientes`.`fld_whatsapp_ref_gar2` AS `fld_whatsapp_ref_gar2`,`tbl_clientes`.`Fdl_Dir_Emp_Gar1` AS `Fdl_Dir_Emp_Gar1`,`tbl_clientes`.`Fld_Rnc_Emp_Gar1` AS `Fld_Rnc_Emp_Gar1`,`tbl_clientes`.`Fld_Tel_Emp_Gar1` AS `Fld_Tel_Emp_Gar1`,`tbl_clientes`.`Fld_Whatsapp_emp_Gar1` AS `Fld_Whatsapp_emp_Gar1`,`tbl_clientes`.`Fld_Empra_Gar2` AS `Fld_Empra_Gar2`,`tbl_clientes`.`Fld_Dir_Emp_Gar2` AS `Fld_Dir_Emp_Gar2`,`tbl_clientes`.`Fld_Rnc_Emp_Gar2` AS `Fld_Rnc_Emp_Gar2`,`tbl_clientes`.`Fld_Tel_Emp_Gar2` AS `Fld_Tel_Emp_Gar2`,`tbl_clientes`.`Fld_Whatsapp_Emp_Gar2` AS `Fld_Whatsapp_Emp_Gar2`,`tbl_clientes`.`fld_nom_ref_flia_clie1` AS `fld_nom_ref_flia_clie1`,`tbl_clientes`.`fld_parentesco_ref_flia_clie1` AS `fld_parentesco_ref_flia_clie1`,`tbl_clientes`.`fld_ced_ref_flia_clie1` AS `fld_ced_ref_flia_clie1`,`tbl_clientes`.`fld_tel_ref_flia_clie1` AS `fld_tel_ref_flia_clie1`,`tbl_clientes`.`fld_cel_ref_flia_clie1` AS `fld_cel_ref_flia_clie1`,`tbl_clientes`.`fld_whatsapp_ref_flia_clie1` AS `fld_whatsapp_ref_flia_clie1`,`tbl_clientes`.`fld_nom_ref_flia_clie2` AS `fld_nom_ref_flia_clie2`,`tbl_clientes`.`fld_parentesco_ref_flia_clie2` AS `fld_parentesco_ref_flia_clie2`,`tbl_clientes`.`fld_ced_ref_flia_clie2` AS `fld_ced_ref_flia_clie2`,`tbl_clientes`.`fld_tel_ref_flia_clie2` AS `fld_tel_ref_flia_clie2`,`tbl_clientes`.`fld_cel_ref_flia_clie2` AS `fld_cel_ref_flia_clie2`,`tbl_clientes`.`fld_whats_ref_flia_clie2` AS `fld_whats_ref_flia_clie2`,`tbl_clientes`.`fld_provincia_id` AS `fld_provincia_id`,`tbl_clientes`.`fld_provincia` AS `fld_provincia`,`tbl_estado_clientes`.`fld_id_ec` AS `fld_id_ec`,`tbl_estado_clientes`.`fld_date` AS `fld_date`,`tbl_estado_clientes`.`fld_description` AS `fld_description`,`tbl_estado_clientes`.`fld_dr` AS `fld_dr`,`tbl_estado_clientes`.`fld_cr` AS `fld_cr`,`tbl_estado_clientes`.`fld_bce_cliente` AS `fld_bce_cliente`,`tbl_estado_clientes`.`fld_cliente_id` AS `fld_cliente_id`,`tbl_estado_clientes`.`fld_tipo_doc` AS `fld_tipo_doc`,`tbl_estado_clientes`.`fld_tipo_doc_id` AS `fld_tipo_doc_id`,`tbl_estado_clientes`.`fld_usuario` AS `fld_usuario` from (`tbl_clientes` join `tbl_estado_clientes`) where (`tbl_clientes`.`fld_id` = `tbl_estado_clientes`.`fld_cliente_id`) */;

--
-- Final view structure for view `view_estado_proveedor`
--

/*!50001 DROP TABLE `view_estado_proveedor`*/;
/*!50001 DROP VIEW IF EXISTS `view_estado_proveedor`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_estado_proveedor` AS (select `s`.`fldSupplierID` AS `fldSupplierID`,`s`.`fldCompany` AS `fldCompany`,`s`.`fldAddress` AS `fldAddress`,`s`.`fldPhone` AS `fldPhone`,`s`.`fldContact` AS `fldContact`,`s`.`fldLimiteCR` AS `fldLimiteCR`,`s`.`fldBalance` AS `fldBalance`,`s`.`fld_Status` AS `fld_Status`,`s`.`fldBy` AS `fldBy`,`s`.`fldfax` AS `fldfax`,`s`.`fldcel` AS `fldcel`,`s`.`fld_clasificacion` AS `fld_clasificacion`,`s`.`fld_cta_contable` AS `fld_cta_contable`,`s`.`fld_telefono` AS `fld_telefono`,`s`.`fld_correo` AS `fld_correo`,`s`.`fld_banco` AS `fld_banco`,`e`.`fld_id_ec_p` AS `fld_id_ec_p`,`e`.`fld_date` AS `fld_date`,`e`.`fld_description` AS `fld_description`,`e`.`fld_dr` AS `fld_dr`,`e`.`fld_cr` AS `fld_cr`,`e`.`fld_bce_proveedor` AS `fld_bce_proveedor`,`e`.`fld_proveedor_id` AS `fld_proveedor_id`,`e`.`fld_tipo_doc` AS `fld_tipo_doc`,`e`.`fld_tipo_doc_id` AS `fld_tipo_doc_id`,`e`.`fld_usuario` AS `fld_usuario` from (`tbl_supplier` `s` join `tbl_estado_proveedor` `e`) where (`s`.`fldSupplierID` = `e`.`fld_proveedor_id`)) */;

--
-- Final view structure for view `view_generar_cuotas`
--

/*!50001 DROP TABLE `view_generar_cuotas`*/;
/*!50001 DROP VIEW IF EXISTS `view_generar_cuotas`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_generar_cuotas` AS select `tbl_clientes`.`fld_id` AS `fld_id`,`tbl_clientes`.`fld_FullName` AS `fld_FullName`,`tbl_clientes`.`fld_apodo` AS `fld_apodo`,`tbl_clientes`.`fld_Identity` AS `fld_Identity`,`tbl_clientes`.`fld_Phone` AS `fld_Phone`,`tbl_clientes`.`fld_Phone2` AS `fld_Phone2`,`tbl_clientes`.`fld_Address` AS `fld_Address`,`tbl_clientes`.`fld_City` AS `fld_City`,`tbl_clientes`.`fld_Status` AS `fld_Status`,`tbl_clientes`.`fld_bce` AS `fld_bce`,`tbl_clientes`.`fld_cod_zona` AS `fld_cod_zona`,`tbl_clientes`.`fld_zona` AS `fld_zona`,`tbl_clientes`.`fld_nombre_con` AS `fld_nombre_con`,`tbl_clientes`.`fld_apodo_con` AS `fld_apodo_con`,`tbl_clientes`.`fld_cedula_con` AS `fld_cedula_con`,`tbl_clientes`.`fld_telefono_con` AS `fld_telefono_con`,`tbl_clientes`.`fld_celular_con` AS `fld_celular_con`,`tbl_clientes`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`,`tbl_clientes`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`,`tbl_clientes`.`fld_nombre_gar` AS `fld_nombre_gar`,`tbl_clientes`.`fld_apodo_gar` AS `fld_apodo_gar`,`tbl_clientes`.`fld_cedula_gar` AS `fld_cedula_gar`,`tbl_clientes`.`fld_telefono_gar` AS `fld_telefono_gar`,`tbl_clientes`.`fld_celular_gar` AS `fld_celular_gar`,`tbl_clientes`.`fld_direccion_gar` AS `fld_direccion_gar`,`tbl_clientes`.`fld_ciudad_gar` AS `fld_ciudad_gar`,`tbl_clientes`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`,`tbl_clientes`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`,`tbl_clientes`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`,`tbl_clientes`.`fld_nombre_banco1` AS `fld_nombre_banco1`,`tbl_clientes`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`,`tbl_clientes`.`fld_nombre_banco2` AS `fld_nombre_banco2`,`tbl_clientes`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`,`tbl_clientes`.`fld_otra_informacion` AS `fld_otra_informacion`,`tbl_clientes`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`,`tbl_clientes`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`,`tbl_clientes`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`,`tbl_clientes`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`,`tbl_clientes`.`fld_celular_con_gar` AS `fld_celular_con_gar`,`tbl_clientes`.`fld_edad` AS `fld_edad`,`tbl_clientes`.`fld_estado_civil` AS `fld_estado_civil`,`tbl_clientes`.`fld_edad_gar` AS `fld_edad_gar`,`tbl_clientes`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`,`tbl_clientes`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`,`tbl_clientes`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`,`tbl_clientes`.`fld_sector` AS `fld_sector`,`tbl_clientes`.`fld_categoria` AS `fld_categoria`,`tbl_cuotas`.`fld_id_cuotas` AS `fld_id_cuotas`,`tbl_cuotas`.`fld_no_cuotas` AS `fld_no_cuotas`,`tbl_cuotas`.`fld_id_del_cliente_cuotas` AS `fld_id_del_cliente_cuotas`,`tbl_cuotas`.`fld_id_del_prestamo` AS `fld_id_del_prestamo`,`tbl_cuotas`.`fld_fecha_entrega_cuotas` AS `fld_fecha_entrega_cuotas`,`tbl_cuotas`.`fld_fecha_termina_cuotas` AS `fld_fecha_termina_cuotas`,`tbl_cuotas`.`fld_fecha_ultimo_abono_cuotas` AS `fld_fecha_ultimo_abono_cuotas`,`tbl_cuotas`.`fld_capital_cuota` AS `fld_capital_cuota`,`tbl_cuotas`.`fld_interes_cuota` AS `fld_interes_cuota`,`tbl_cuotas`.`fld_monto_cuotas` AS `fld_monto_cuotas`,`tbl_cuotas`.`fld_abono_cuotas` AS `fld_abono_cuotas`,`tbl_cuotas`.`fld_balance_cuotas` AS `fld_balance_cuotas`,`tbl_cuotas`.`fld_usuario_cuotas` AS `fld_usuario_cuotas`,`tbl_cuotas`.`fld_status_cuotas` AS `fld_status_cuotas`,`tbl_cuotas`.`fld_pendiente_amortizar` AS `fld_pendiente_amortizar`,`tbl_cuotas`.`fld_total_amortizado` AS `fld_total_amortizado`,`tbl_cuotas`.`fld_capital_cuota_abono` AS `fld_capital_cuota_abono`,`tbl_cuotas`.`fld_capital_cuota_balance` AS `fld_capital_cuota_balance`,`tbl_cuotas`.`fld_interes_cuota_abono` AS `fld_interes_cuota_abono`,`tbl_cuotas`.`fld_interes_cuota_balance` AS `fld_interes_cuota_balance`,`tbl_cuotas`.`fld_ultimo_abono_interes` AS `fld_ultimo_abono_interes`,`tbl_cuotas`.`fld_ultimo_abono_capital` AS `fld_ultimo_abono_capital`,`tbl_cuotas`.`fld_monto_mora` AS `fld_monto_mora`,`tbl_cuotas`.`fld_abono_mora` AS `fld_abono_mora`,`tbl_cuotas`.`fld_balance_mora` AS `fld_balance_mora`,`tbl_cuotas`.`fld_ultimo_abono_mora` AS `fld_ultimo_abono_mora`,`tbl_cuotas`.`fld_dias_vencimiento` AS `fld_dias_vencimiento`,`tbl_cuotas`.`fld_socio` AS `fld_socio`,`tbl_cuotas`.`fld_atraso_cuotas` AS `fld_atraso_cuotas`,`tbl_cuotas`.`fld_tipo_cuotas` AS `fld_tipo_cuotas`,`tbl_cuotas`.`fld_bce_prestamo` AS `fld_bce_prestamo`,`tbl_cuotas`.`fld_cant_cuotas` AS `fld_cant_cuotas` from (`tbl_clientes` join `tbl_cuotas`) where (`tbl_clientes`.`fld_id` = `tbl_cuotas`.`fld_id_del_cliente_cuotas`) */;

--
-- Final view structure for view `view_libro_mayor`
--

/*!50001 DROP TABLE `view_libro_mayor`*/;
/*!50001 DROP VIEW IF EXISTS `view_libro_mayor`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_libro_mayor` AS select `td`.`TransDID` AS `TransDID`,`td`.`TransDIDTrans` AS `TransDIDTrans`,`td`.`TransDCuentaNo` AS `TransDCuentaNo`,`td`.`TransDDescripcionCuenta` AS `TransDDescripcionCuenta`,`td`.`TransDDebito` AS `TransDDebito`,`td`.`TransDCredito` AS `TransDCredito`,`td`.`TransDBalance` AS `TransDBalance`,`t`.`TransID` AS `TransID`,`t`.`TransFecha` AS `TransFecha`,`t`.`TransFechaMovimiento` AS `TransFechaMovimiento`,`t`.`TransDescripcion` AS `TransDescripcion`,`t`.`TransIDTipo` AS `TransIDTipo`,`t`.`TransUsuario` AS `TransUsuario`,`t`.`TransEstado` AS `TransEstado`,`t`.`TransIDDoc` AS `TransIDDoc`,`t`.`TransDoc` AS `TransDoc`,`t`.`TransDocDetalle` AS `TransDocDetalle`,`c`.`ID` AS `ID`,`c`.`CuentaNo` AS `CuentaNo`,`c`.`Descripcion` AS `Descripcion`,`c`.`Grupo` AS `Grupo`,`c`.`Tipo` AS `Tipo`,`c`.`Debito` AS `Debito`,`c`.`Credito` AS `Credito`,`c`.`Balance` AS `Balance`,`c`.`CtaControl` AS `CtaControl`,`c`.`NombreMes` AS `NombreMes`,`c`.`NumeroMes` AS `NumeroMes`,`c`.`BalanceAnterior` AS `BalanceAnterior`,`c`.`BalanceGeneral` AS `BalanceGeneral`,`c`.`EstadoResultado` AS `EstadoResultado`,`c`.`OrdenEstadoResultado` AS `OrdenEstadoResultado`,`c`.`AccionEstatoResultado` AS `AccionEstatoResultado`,`c`.`VerEnCero` AS `VerEnCero`,`c`.`Fecha` AS `Fecha`,`c`.`Usuario` AS `Usuario`,`c`.`Nivel` AS `Nivel` from ((`tbl_interfasecontabletransaccionesdetalles` `td` join `tbl_interfascontabletransacciones` `t`) join `tbl_catalogo` `c`) where ((`td`.`TransDIDTrans` = `t`.`TransID`) and (`td`.`TransDCuentaNo` = `c`.`CuentaNo`)) */;

--
-- Final view structure for view `view_nc_bancaria`
--

/*!50001 DROP TABLE `view_nc_bancaria`*/;
/*!50001 DROP VIEW IF EXISTS `view_nc_bancaria`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_nc_bancaria` AS select `tbl_bancos`.`fld_id` AS `fld_id`,`tbl_bancos`.`fld_nombre` AS `fld_nombre`,`tbl_bancos`.`fld_cuenta` AS `fld_cuenta`,`tbl_bancos`.`fld_cta_contable` AS `fld_cta_contable`,`tbl_bancos`.`fld_contacto` AS `fld_contacto`,`tbl_bancos`.`fld_sucursal` AS `fld_sucursal`,`tbl_bancos`.`fld_balance` AS `fld_balance`,`tbl_bancos`.`fld_status` AS `fld_status`,`tbl_bancos`.`fld_direccion` AS `fld_direccion`,`tbl_bancos`.`fld_codigo` AS `fld_codigo`,`tbl_bancos`.`fld_tt_ck` AS `fld_tt_ck`,`tbl_bancos`.`fld_tt_dep` AS `fld_tt_dep`,`tbl_bancos`.`fld_tt_nc` AS `fld_tt_nc`,`tbl_bancos`.`fld_tt_nd` AS `fld_tt_nd`,`tbl_nc_bancaria`.`fld_id_doc` AS `fld_id_doc`,`tbl_nc_bancaria`.`fld_id_banco` AS `fld_id_banco`,`tbl_nc_bancaria`.`fld_fecha` AS `fld_fecha`,`tbl_nc_bancaria`.`fld_descripcion` AS `fld_descripcion`,`tbl_nc_bancaria`.`fld_monto` AS `fld_monto`,`tbl_nc_bancaria`.`fld_estado` AS `fld_estado`,`tbl_nc_bancaria`.`fld_transito` AS `fld_transito` from (`tbl_bancos` join `tbl_nc_bancaria`) where (`tbl_bancos`.`fld_id` = `tbl_nc_bancaria`.`fld_id_banco`) */;

--
-- Final view structure for view `view_nd_bancaria`
--

/*!50001 DROP TABLE `view_nd_bancaria`*/;
/*!50001 DROP VIEW IF EXISTS `view_nd_bancaria`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_nd_bancaria` AS select `tbl_nd_bancaria`.`fld_id_doc` AS `fld_id_doc`,`tbl_nd_bancaria`.`fld_id_banco` AS `fld_id_banco`,`tbl_nd_bancaria`.`fld_fecha` AS `fld_fecha`,`tbl_nd_bancaria`.`fld_descripcion` AS `fld_descripcion`,`tbl_nd_bancaria`.`fld_monto` AS `fld_monto`,`tbl_nd_bancaria`.`fld_estado` AS `fld_estado`,`tbl_nd_bancaria`.`fld_transito` AS `fld_transito`,`tbl_bancos`.`fld_id` AS `fld_id`,`tbl_bancos`.`fld_nombre` AS `fld_nombre`,`tbl_bancos`.`fld_cuenta` AS `fld_cuenta`,`tbl_bancos`.`fld_cta_contable` AS `fld_cta_contable`,`tbl_bancos`.`fld_contacto` AS `fld_contacto`,`tbl_bancos`.`fld_sucursal` AS `fld_sucursal`,`tbl_bancos`.`fld_balance` AS `fld_balance`,`tbl_bancos`.`fld_status` AS `fld_status`,`tbl_bancos`.`fld_direccion` AS `fld_direccion`,`tbl_bancos`.`fld_codigo` AS `fld_codigo`,`tbl_bancos`.`fld_tt_ck` AS `fld_tt_ck`,`tbl_bancos`.`fld_tt_dep` AS `fld_tt_dep`,`tbl_bancos`.`fld_tt_nc` AS `fld_tt_nc`,`tbl_bancos`.`fld_tt_nd` AS `fld_tt_nd` from (`tbl_nd_bancaria` join `tbl_bancos`) where (`tbl_nd_bancaria`.`fld_id_banco` = `tbl_bancos`.`fld_id`) */;

--
-- Final view structure for view `view_nota_credito_cxp`
--

/*!50001 DROP TABLE `view_nota_credito_cxp`*/;
/*!50001 DROP VIEW IF EXISTS `view_nota_credito_cxp`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_nota_credito_cxp` AS select `tbl_supplier`.`fldSupplierID` AS `fldSupplierID`,`tbl_supplier`.`fldCompany` AS `fldCompany`,`tbl_supplier`.`fldAddress` AS `fldAddress`,`tbl_supplier`.`fldPhone` AS `fldPhone`,`tbl_supplier`.`fldContact` AS `fldContact`,`tbl_supplier`.`fldLimiteCR` AS `fldLimiteCR`,`tbl_supplier`.`fldBalance` AS `fldBalance`,`tbl_supplier`.`fld_Status` AS `fld_Status`,`tbl_supplier`.`fldBy` AS `fldBy`,`tbl_supplier`.`fldfax` AS `fldfax`,`tbl_supplier`.`fldcel` AS `fldcel`,`tbl_supplier`.`fld_clasificacion` AS `fld_clasificacion`,`tbl_supplier`.`fld_cta_contable` AS `fld_cta_contable`,`tbl_supplier`.`fld_telefono` AS `fld_telefono`,`tbl_supplier`.`fld_correo` AS `fld_correo`,`tbl_supplier`.`fld_banco` AS `fld_banco`,`tbl_nc_cxp`.`fld_id` AS `fld_id`,`tbl_nc_cxp`.`fld_proveedor_id_nc` AS `fld_proveedor_id_nc`,`tbl_nc_cxp`.`fld_fecha` AS `fld_fecha`,`tbl_nc_cxp`.`fld_concepto` AS `fld_concepto`,`tbl_nc_cxp`.`fld_monto` AS `fld_monto`,`tbl_nc_cxp`.`fld_abono` AS `fld_abono`,`tbl_nc_cxp`.`fld_balance` AS `fld_balance`,`tbl_nc_cxp`.`fld_user` AS `fld_user`,`tbl_nc_cxp`.`fldstatus` AS `fldstatus`,`tbl_nc_cxp`.`fld_ncf_nc_cxp` AS `fld_ncf_nc_cxp`,`tbl_nc_cxp`.`fld_ultimo_abono` AS `fld_ultimo_abono`,`tbl_nc_cxp`.`fld_chk` AS `fld_chk` from (`tbl_supplier` join `tbl_nc_cxp`) where (`tbl_supplier`.`fldSupplierID` = `tbl_nc_cxp`.`fld_proveedor_id_nc`) */;

--
-- Final view structure for view `view_nota_debito_cxp`
--

/*!50001 DROP TABLE `view_nota_debito_cxp`*/;
/*!50001 DROP VIEW IF EXISTS `view_nota_debito_cxp`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_nota_debito_cxp` AS (select `s`.`fldSupplierID` AS `fldSupplierID`,`s`.`fldCompany` AS `fldCompany`,`s`.`fldAddress` AS `fldAddress`,`s`.`fldPhone` AS `fldPhone`,`s`.`fldContact` AS `fldContact`,`s`.`fldLimiteCR` AS `fldLimiteCR`,`s`.`fldBalance` AS `fldBalance`,`s`.`fld_Status` AS `fld_Status`,`s`.`fldBy` AS `fldBy`,`s`.`fldfax` AS `fldfax`,`s`.`fldcel` AS `fldcel`,`s`.`fld_clasificacion` AS `fld_clasificacion`,`s`.`fld_cta_contable` AS `fld_cta_contable`,`s`.`fld_telefono` AS `fld_telefono`,`s`.`fld_correo` AS `fld_correo`,`s`.`fld_banco` AS `fld_banco`,`n`.`fld_id` AS `fld_id`,`n`.`fld_proveedor_id_nd` AS `fld_proveedor_id_nd`,`n`.`fld_fecha` AS `fld_fecha`,`n`.`fld_concepto` AS `fld_concepto`,`n`.`fld_monto` AS `fld_monto`,`n`.`fld_user` AS `fld_user`,`n`.`fldstatus` AS `fldstatus`,`n`.`fld_doc_afectado` AS `fld_doc_afectado`,`n`.`fld_doc_afectado_id` AS `fld_doc_afectado_id`,`n`.`fld_ncf_nd_cxp` AS `fld_ncf_nd_cxp` from (`tbl_supplier` `s` join `tbl_nd_cxp` `n`) where (`s`.`fldSupplierID` = `n`.`fld_proveedor_id_nd`)) */;

--
-- Final view structure for view `view_prestamos_todos`
--

/*!50001 DROP TABLE `view_prestamos_todos`*/;
/*!50001 DROP VIEW IF EXISTS `view_prestamos_todos`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_prestamos_todos` AS select `tbl_prestamos`.`fld_id_prestamos` AS `fld_id_prestamos`,`tbl_prestamos`.`fld_id_del_cliente` AS `fld_id_del_cliente`,`tbl_prestamos`.`fld_clasificacion` AS `fld_clasificacion`,`tbl_prestamos`.`fld_fecha_entrega` AS `fld_fecha_entrega`,`tbl_prestamos`.`fld_fecha_termina` AS `fld_fecha_termina`,`tbl_prestamos`.`fld_fecha_calcula_interes` AS `fld_fecha_calcula_interes`,`tbl_prestamos`.`fld_cantidad_cuotas` AS `fld_cantidad_cuotas`,`tbl_prestamos`.`fld_monto_cuotas_a` AS `fld_monto_cuotas_a`,`tbl_prestamos`.`fld_capital_prestamo` AS `fld_capital_prestamo`,`tbl_prestamos`.`fld_monto` AS `fld_monto`,`tbl_prestamos`.`fld_abono` AS `fld_abono`,`tbl_prestamos`.`fld_balance` AS `fld_balance`,`tbl_prestamos`.`fld_usuario` AS `fld_usuario`,`tbl_prestamos`.`fld_fecha_ultimo_abono` AS `fld_fecha_ultimo_abono`,`tbl_prestamos`.`fld_status_prestamos` AS `fld_status_prestamos`,`tbl_prestamos`.`fld_anos` AS `fld_anos`,`tbl_prestamos`.`fld_interes_p` AS `fld_interes_p`,`tbl_prestamos`.`fld_tipo_prestamo` AS `fld_tipo_prestamo`,`tbl_prestamos`.`fld_ck_no` AS `fld_ck_no`,`tbl_prestamos`.`fld_tipo_garantia` AS `fld_tipo_garantia`,`tbl_prestamos`.`fld_garantia` AS `fld_garantia`,`tbl_prestamos`.`fldFinanciamiento` AS `fldFinanciamiento`,`tbl_prestamos`.`fldMontoFinan` AS `fldMontoFinan`,`tbl_prestamos`.`fldMontoInicial` AS `fldMontoInicial`,`tbl_prestamos`.`fldCodInm` AS `fldCodInm`,`tbl_prestamos`.`fldDescInm` AS `fldDescInm`,`tbl_prestamos`.`fldMetros` AS `fldMetros`,`tbl_prestamos`.`fldPrecioMetro` AS `fldPrecioMetro`,`tbl_prestamos`.`fldTazaMora` AS `fldTazaMora`,`tbl_prestamos`.`fldNota` AS `fldNota`,`tbl_prestamos`.`IDVehiculo` AS `IDVehiculo`,`tbl_prestamos`.`GastosLegales` AS `GastosLegales`,`tbl_prestamos`.`Seguro` AS `Seguro`,`tbl_clientes`.`fld_id` AS `fld_id`,`tbl_clientes`.`TipoDocumento` AS `TipoDocumento`,`tbl_clientes`.`fld_FullName` AS `fld_FullName`,`tbl_clientes`.`fld_apodo` AS `fld_apodo`,`tbl_clientes`.`fld_Identity` AS `fld_Identity`,`tbl_clientes`.`fld_Phone` AS `fld_Phone`,`tbl_clientes`.`fld_Phone2` AS `fld_Phone2`,`tbl_clientes`.`fld_Address` AS `fld_Address`,`tbl_clientes`.`fld_City_id` AS `fld_City_id`,`tbl_clientes`.`fld_City` AS `fld_City`,`tbl_clientes`.`fld_Status` AS `fld_Status`,`tbl_clientes`.`fld_bce` AS `fld_bce`,`tbl_clientes`.`fld_cod_zona` AS `fld_cod_zona`,`tbl_clientes`.`fld_zona` AS `fld_zona`,`tbl_clientes`.`fld_nombre_con` AS `fld_nombre_con`,`tbl_clientes`.`fld_apodo_con` AS `fld_apodo_con`,`tbl_clientes`.`fld_cedula_con` AS `fld_cedula_con`,`tbl_clientes`.`fld_telefono_con` AS `fld_telefono_con`,`tbl_clientes`.`fld_celular_con` AS `fld_celular_con`,`tbl_clientes`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`,`tbl_clientes`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`,`tbl_clientes`.`fld_nombre_gar` AS `fld_nombre_gar`,`tbl_clientes`.`fld_apodo_gar` AS `fld_apodo_gar`,`tbl_clientes`.`fld_cedula_gar` AS `fld_cedula_gar`,`tbl_clientes`.`fld_telefono_gar` AS `fld_telefono_gar`,`tbl_clientes`.`fld_celular_gar` AS `fld_celular_gar`,`tbl_clientes`.`fld_direccion_gar` AS `fld_direccion_gar`,`tbl_clientes`.`fld_ciudad_gar` AS `fld_ciudad_gar`,`tbl_clientes`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`,`tbl_clientes`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`,`tbl_clientes`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`,`tbl_clientes`.`fld_nombre_banco1` AS `fld_nombre_banco1`,`tbl_clientes`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`,`tbl_clientes`.`fld_nombre_banco2` AS `fld_nombre_banco2`,`tbl_clientes`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`,`tbl_clientes`.`fld_otra_informacion` AS `fld_otra_informacion`,`tbl_clientes`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`,`tbl_clientes`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`,`tbl_clientes`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`,`tbl_clientes`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`,`tbl_clientes`.`fld_celular_con_gar` AS `fld_celular_con_gar`,`tbl_clientes`.`fld_edad` AS `fld_edad`,`tbl_clientes`.`fld_estado_civil` AS `fld_estado_civil`,`tbl_clientes`.`fld_edad_gar` AS `fld_edad_gar`,`tbl_clientes`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`,`tbl_clientes`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`,`tbl_clientes`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`,`tbl_clientes`.`fld_sector_id` AS `fld_sector_id`,`tbl_clientes`.`fld_sector` AS `fld_sector`,`tbl_clientes`.`fld_categoria` AS `fld_categoria`,`tbl_clientes`.`fld_limite` AS `fld_limite`,`tbl_clientes`.`Puesto` AS `Puesto`,`tbl_clientes`.`TimpoTrabajo` AS `TimpoTrabajo`,`tbl_clientes`.`ReferidoPor` AS `ReferidoPor`,`tbl_clientes`.`Oriundo` AS `Oriundo`,`tbl_clientes`.`DataCredito` AS `DataCredito`,`tbl_clientes`.`ctaContable` AS `ctaContable`,`tbl_clientes`.`email` AS `email`,`tbl_clientes`.`fechaIngreso` AS `fechaIngreso`,`tbl_clientes`.`whatsapp` AS `whatsapp`,`tbl_clientes`.`whatsapp_con` AS `whatsapp_con`,`tbl_clientes`.`parentezco_gar` AS `parentezco_gar`,`tbl_clientes`.`fecha_nac_gar` AS `fecha_nac_gar`,`tbl_clientes`.`whatsapp_gar` AS `whatsapp_gar`,`tbl_clientes`.`email_gar` AS `email_gar`,`tbl_clientes`.`empresa_gar` AS `empresa_gar`,`tbl_clientes`.`telefono_Empresa_gar` AS `telefono_Empresa_gar`,`tbl_clientes`.`agno_labor_gar` AS `agno_labor_gar`,`tbl_clientes`.`salario_gar` AS `salario_gar`,`tbl_clientes`.`whatsapp_con_gar` AS `whatsapp_con_gar`,`tbl_clientes`.`fld_ref_parentesco_clie1` AS `fld_ref_parentesco_clie1`,`tbl_clientes`.`fld_ced_ref_personal_clie1` AS `fld_ced_ref_personal_clie1`,`tbl_clientes`.`fld_tel_ref_personal_clie1` AS `fld_tel_ref_personal_clie1`,`tbl_clientes`.`fld_cel_ref_personal_clie1` AS `fld_cel_ref_personal_clie1`,`tbl_clientes`.`fld_whatsapp_ref_personal_clie1` AS `fld_whatsapp_ref_personal_clie1`,`tbl_clientes`.`fld_ref_personal_clie2` AS `fld_ref_personal_clie2`,`tbl_clientes`.`fld_ref_parentesco_clie2` AS `fld_ref_parentesco_clie2`,`tbl_clientes`.`fld_ced_ref_personal_clie2` AS `fld_ced_ref_personal_clie2`,`tbl_clientes`.`fld_tel_ref_personal_clie2` AS `fld_tel_ref_personal_clie2`,`tbl_clientes`.`fld_cel_ref_personal_clie2` AS `fld_cel_ref_personal_clie2`,`tbl_clientes`.`fld_whatsapp_ref_personal_clie2` AS `fld_whatsapp_ref_personal_clie2`,`tbl_clientes`.`Fld_Dir_Ref_Com_Clie1` AS `Fld_Dir_Ref_Com_Clie1`,`tbl_clientes`.`Fld_Rnc_Refe_Com_Clie1` AS `Fld_Rnc_Refe_Com_Clie1`,`tbl_clientes`.`Fld_Tel_Com_clie1` AS `Fld_Tel_Com_clie1`,`tbl_clientes`.`Fld_Whatsapp_Com_Clie1` AS `Fld_Whatsapp_Com_Clie1`,`tbl_clientes`.`fld_ref_comerciales_cliente2` AS `fld_ref_comerciales_cliente2`,`tbl_clientes`.`Fld_Dir_Ref_Com_Clie2` AS `Fld_Dir_Ref_Com_Clie2`,`tbl_clientes`.`Fld_Rnc_Refe_Com_Clie2` AS `Fld_Rnc_Refe_Com_Clie2`,`tbl_clientes`.`Fld_Tel_Com_clie2` AS `Fld_Tel_Com_clie2`,`tbl_clientes`.`Fld_Whatsapp_Com_Clie2` AS `Fld_Whatsapp_Com_Clie2`,`tbl_clientes`.`fld_parentesco_ref_gar1` AS `fld_parentesco_ref_gar1`,`tbl_clientes`.`fld_cedula_ref_gar1` AS `fld_cedula_ref_gar1`,`tbl_clientes`.`fld_tel_ref_gar1` AS `fld_tel_ref_gar1`,`tbl_clientes`.`fld_cel_ref_gar1` AS `fld_cel_ref_gar1`,`tbl_clientes`.`fld_whatsapp_ref_gar1` AS `fld_whatsapp_ref_gar1`,`tbl_clientes`.`fld_ref_personal_gar2` AS `fld_ref_personal_gar2`,`tbl_clientes`.`fld_parentesco_ref_gar2` AS `fld_parentesco_ref_gar2`,`tbl_clientes`.`fld_cedula_ref_gar2` AS `fld_cedula_ref_gar2`,`tbl_clientes`.`fld_tel_ref_gar2` AS `fld_tel_ref_gar2`,`tbl_clientes`.`fld_cel_ref_gar2` AS `fld_cel_ref_gar2`,`tbl_clientes`.`fld_whatsapp_ref_gar2` AS `fld_whatsapp_ref_gar2`,`tbl_clientes`.`Fdl_Dir_Emp_Gar1` AS `Fdl_Dir_Emp_Gar1`,`tbl_clientes`.`Fld_Rnc_Emp_Gar1` AS `Fld_Rnc_Emp_Gar1`,`tbl_clientes`.`Fld_Tel_Emp_Gar1` AS `Fld_Tel_Emp_Gar1`,`tbl_clientes`.`Fld_Whatsapp_emp_Gar1` AS `Fld_Whatsapp_emp_Gar1`,`tbl_clientes`.`Fld_Empra_Gar2` AS `Fld_Empra_Gar2`,`tbl_clientes`.`Fld_Dir_Emp_Gar2` AS `Fld_Dir_Emp_Gar2`,`tbl_clientes`.`Fld_Rnc_Emp_Gar2` AS `Fld_Rnc_Emp_Gar2`,`tbl_clientes`.`Fld_Tel_Emp_Gar2` AS `Fld_Tel_Emp_Gar2`,`tbl_clientes`.`Fld_Whatsapp_Emp_Gar2` AS `Fld_Whatsapp_Emp_Gar2`,`tbl_clientes`.`fld_nom_ref_flia_clie1` AS `fld_nom_ref_flia_clie1`,`tbl_clientes`.`fld_parentesco_ref_flia_clie1` AS `fld_parentesco_ref_flia_clie1`,`tbl_clientes`.`fld_ced_ref_flia_clie1` AS `fld_ced_ref_flia_clie1`,`tbl_clientes`.`fld_tel_ref_flia_clie1` AS `fld_tel_ref_flia_clie1`,`tbl_clientes`.`fld_cel_ref_flia_clie1` AS `fld_cel_ref_flia_clie1`,`tbl_clientes`.`fld_whatsapp_ref_flia_clie1` AS `fld_whatsapp_ref_flia_clie1`,`tbl_clientes`.`fld_nom_ref_flia_clie2` AS `fld_nom_ref_flia_clie2`,`tbl_clientes`.`fld_parentesco_ref_flia_clie2` AS `fld_parentesco_ref_flia_clie2`,`tbl_clientes`.`fld_ced_ref_flia_clie2` AS `fld_ced_ref_flia_clie2`,`tbl_clientes`.`fld_tel_ref_flia_clie2` AS `fld_tel_ref_flia_clie2`,`tbl_clientes`.`fld_cel_ref_flia_clie2` AS `fld_cel_ref_flia_clie2`,`tbl_clientes`.`fld_whats_ref_flia_clie2` AS `fld_whats_ref_flia_clie2`,`tbl_clientes`.`fld_provincia_id` AS `fld_provincia_id`,`tbl_clientes`.`fld_provincia` AS `fld_provincia` from (`tbl_prestamos` join `tbl_clientes`) where (`tbl_prestamos`.`fld_id_del_cliente` = `tbl_clientes`.`fld_id`) */;

--
-- Final view structure for view `view_retiros`
--

/*!50001 DROP TABLE `view_retiros`*/;
/*!50001 DROP VIEW IF EXISTS `view_retiros`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_retiros` AS (select `ar`.`ID` AS `ID`,`ar`.`IDAhorro` AS `IDAhorro`,`ar`.`IDCliente` AS `IDCliente`,`ar`.`Fecha` AS `Fecha`,`ar`.`Tipo` AS `Tipo`,`ar`.`Concepto` AS `Concepto`,`ar`.`Monto` AS `Monto`,`ar`.`Usuario` AS `Usuario`,`c`.`fld_id` AS `fld_id`,`c`.`TipoDocumento` AS `TipoDocumento`,`c`.`fld_FullName` AS `fld_FullName`,`c`.`fld_apodo` AS `fld_apodo`,`c`.`fld_Identity` AS `fld_Identity`,`c`.`fld_Phone` AS `fld_Phone`,`c`.`fld_Phone2` AS `fld_Phone2`,`c`.`fld_Address` AS `fld_Address`,`c`.`fld_City_id` AS `fld_City_id`,`c`.`fld_City` AS `fld_City`,`c`.`fld_Status` AS `fld_Status`,`c`.`fld_bce` AS `fld_bce`,`c`.`fld_cod_zona` AS `fld_cod_zona`,`c`.`fld_zona` AS `fld_zona`,`c`.`fld_nombre_con` AS `fld_nombre_con`,`c`.`fld_apodo_con` AS `fld_apodo_con`,`c`.`fld_cedula_con` AS `fld_cedula_con`,`c`.`fld_telefono_con` AS `fld_telefono_con`,`c`.`fld_celular_con` AS `fld_celular_con`,`c`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`,`c`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`,`c`.`fld_nombre_gar` AS `fld_nombre_gar`,`c`.`fld_apodo_gar` AS `fld_apodo_gar`,`c`.`fld_cedula_gar` AS `fld_cedula_gar`,`c`.`fld_telefono_gar` AS `fld_telefono_gar`,`c`.`fld_celular_gar` AS `fld_celular_gar`,`c`.`fld_direccion_gar` AS `fld_direccion_gar`,`c`.`fld_ciudad_gar` AS `fld_ciudad_gar`,`c`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`,`c`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`,`c`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`,`c`.`fld_nombre_banco1` AS `fld_nombre_banco1`,`c`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`,`c`.`fld_nombre_banco2` AS `fld_nombre_banco2`,`c`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`,`c`.`fld_otra_informacion` AS `fld_otra_informacion`,`c`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`,`c`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`,`c`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`,`c`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`,`c`.`fld_celular_con_gar` AS `fld_celular_con_gar`,`c`.`fld_edad` AS `fld_edad`,`c`.`fld_estado_civil` AS `fld_estado_civil`,`c`.`fld_edad_gar` AS `fld_edad_gar`,`c`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`,`c`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`,`c`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`,`c`.`fld_sector_id` AS `fld_sector_id`,`c`.`fld_sector` AS `fld_sector`,`c`.`fld_categoria` AS `fld_categoria`,`c`.`fld_limite` AS `fld_limite`,`c`.`Puesto` AS `Puesto`,`c`.`TimpoTrabajo` AS `TimpoTrabajo`,`c`.`ReferidoPor` AS `ReferidoPor`,`c`.`Oriundo` AS `Oriundo`,`c`.`DataCredito` AS `DataCredito` from (`tbl_ahorros_retiros` `ar` join `tbl_clientes` `c`) where (`ar`.`IDCliente` = `c`.`fld_id`)) */;

--
-- Final view structure for view `view_ri_cxc`
--

/*!50001 DROP TABLE `view_ri_cxc`*/;
/*!50001 DROP VIEW IF EXISTS `view_ri_cxc`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_ri_cxc` AS select `tbl_clientes`.`fld_id` AS `fld_id`,`tbl_clientes`.`TipoDocumento` AS `TipoDocumento`,`tbl_clientes`.`fld_FullName` AS `fld_FullName`,`tbl_clientes`.`fld_apodo` AS `fld_apodo`,`tbl_clientes`.`fld_Identity` AS `fld_Identity`,`tbl_clientes`.`fld_Phone` AS `fld_Phone`,`tbl_clientes`.`fld_Phone2` AS `fld_Phone2`,`tbl_clientes`.`fld_Address` AS `fld_Address`,`tbl_clientes`.`fld_City` AS `fld_City`,`tbl_clientes`.`fld_Status` AS `fld_Status`,`tbl_clientes`.`fld_bce` AS `fld_bce`,`tbl_clientes`.`fld_cod_zona` AS `fld_cod_zona`,`tbl_clientes`.`fld_zona` AS `fld_zona`,`tbl_clientes`.`fld_nombre_con` AS `fld_nombre_con`,`tbl_clientes`.`fld_apodo_con` AS `fld_apodo_con`,`tbl_clientes`.`fld_cedula_con` AS `fld_cedula_con`,`tbl_clientes`.`fld_telefono_con` AS `fld_telefono_con`,`tbl_clientes`.`fld_celular_con` AS `fld_celular_con`,`tbl_clientes`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`,`tbl_clientes`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`,`tbl_clientes`.`fld_nombre_gar` AS `fld_nombre_gar`,`tbl_clientes`.`fld_apodo_gar` AS `fld_apodo_gar`,`tbl_clientes`.`fld_cedula_gar` AS `fld_cedula_gar`,`tbl_clientes`.`fld_telefono_gar` AS `fld_telefono_gar`,`tbl_clientes`.`fld_celular_gar` AS `fld_celular_gar`,`tbl_clientes`.`fld_direccion_gar` AS `fld_direccion_gar`,`tbl_clientes`.`fld_ciudad_gar` AS `fld_ciudad_gar`,`tbl_clientes`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`,`tbl_clientes`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`,`tbl_clientes`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`,`tbl_clientes`.`fld_nombre_banco1` AS `fld_nombre_banco1`,`tbl_clientes`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`,`tbl_clientes`.`fld_nombre_banco2` AS `fld_nombre_banco2`,`tbl_clientes`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`,`tbl_clientes`.`fld_otra_informacion` AS `fld_otra_informacion`,`tbl_clientes`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`,`tbl_clientes`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`,`tbl_clientes`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`,`tbl_clientes`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`,`tbl_clientes`.`fld_celular_con_gar` AS `fld_celular_con_gar`,`tbl_clientes`.`fld_edad` AS `fld_edad`,`tbl_clientes`.`fld_estado_civil` AS `fld_estado_civil`,`tbl_clientes`.`fld_edad_gar` AS `fld_edad_gar`,`tbl_clientes`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`,`tbl_clientes`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`,`tbl_clientes`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`,`tbl_clientes`.`fld_sector` AS `fld_sector`,`tbl_clientes`.`fld_categoria` AS `fld_categoria`,`tbl_clientes`.`fld_limite` AS `fld_limite`,`tbl_recibo_ingresos_cxc`.`fld_Id_RI` AS `fld_Id_RI`,`tbl_recibo_ingresos_cxc`.`fld_forma_pago` AS `fld_forma_pago`,`tbl_recibo_ingresos_cxc`.`fld_detalle_forma_pago` AS `fld_detalle_forma_pago`,`tbl_recibo_ingresos_cxc`.`fld_id_cliente_ri` AS `fld_id_cliente_ri`,`tbl_recibo_ingresos_cxc`.`fld_date` AS `fld_date`,`tbl_recibo_ingresos_cxc`.`fld_Description` AS `fld_Description`,`tbl_recibo_ingresos_cxc`.`fld_monto` AS `fld_monto`,`tbl_recibo_ingresos_cxc`.`fld_monto_recibido` AS `fld_monto_recibido`,`tbl_recibo_ingresos_cxc`.`fld_fact_afectado` AS `fld_fact_afectado`,`tbl_recibo_ingresos_cxc`.`fdl_nd_afectado` AS `fdl_nd_afectado`,`tbl_recibo_ingresos_cxc`.`fld_User` AS `fld_User`,`tbl_recibo_ingresos_cxc`.`fld_Estado` AS `fld_Estado`,`tbl_recibo_ingresos_cxc`.`fld_id_prestamo` AS `fld_id_prestamo`,`tbl_recibo_ingresos_cxc`.`fld_interes_cobrado` AS `fld_interes_cobrado`,`tbl_recibo_ingresos_cxc`.`fld_capital_cobrado` AS `fld_capital_cobrado`,`tbl_recibo_ingresos_cxc`.`fld_mora_cobrada` AS `fld_mora_cobrada`,`tbl_recibo_ingresos_cxc`.`fld_concepto` AS `fld_concepto`,`tbl_recibo_ingresos_cxc`.`fld_socio` AS `fld_socio`,`tbl_recibo_ingresos_cxc`.`fld_bce_actual` AS `fld_bce_actual`,`tbl_recibo_ingresos_cxc`.`fld_bce_anterior` AS `fld_bce_anterior`,`tbl_recibo_ingresos_cxc`.`fld_adelanto` AS `fld_adelanto`,`tbl_recibo_ingresos_cxc`.`fld_adelanto_aplicado` AS `fld_adelanto_aplicado` from (`tbl_clientes` join `tbl_recibo_ingresos_cxc`) where (`tbl_clientes`.`fld_id` = `tbl_recibo_ingresos_cxc`.`fld_id_cliente_ri`) */;

--
-- Final view structure for view `view_tabla_prestamos`
--

/*!50001 DROP TABLE `view_tabla_prestamos`*/;
/*!50001 DROP VIEW IF EXISTS `view_tabla_prestamos`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_tabla_prestamos` AS (select `tp`.`fld_id_prestamos` AS `fld_id_prestamos`,`tp`.`fld_id_del_cliente` AS `fld_id_del_cliente`,`tp`.`fld_socio` AS `fld_socio`,`tp`.`fld_socio_rnc` AS `fld_socio_rnc`,`tp`.`fld_clasificacion` AS `fld_clasificacion`,`tp`.`fld_fecha_entrega` AS `fld_fecha_entrega`,`tp`.`fld_fecha_termina` AS `fld_fecha_termina`,`tp`.`fld_fecha_calcula_interes` AS `fld_fecha_calcula_interes`,`tp`.`fld_cantidad_cuotas` AS `fld_cantidad_cuotas`,`tp`.`fld_monto_cuotas_a` AS `fld_monto_cuotas_a`,`tp`.`fld_capital_prestamo` AS `fld_capital_prestamo`,`tp`.`fld_monto` AS `fld_monto`,`tp`.`fld_abono` AS `fld_abono`,`tp`.`fld_balance` AS `fld_balance`,`tp`.`fld_usuario` AS `fld_usuario`,`tp`.`fld_fecha_ultimo_abono` AS `fld_fecha_ultimo_abono`,`tp`.`fld_status_prestamos` AS `fld_status_prestamos`,`tp`.`fld_anos` AS `fld_anos`,`tp`.`fld_interes_p` AS `fld_interes_p`,`tp`.`fld_tipo_prestamo` AS `fld_tipo_prestamo`,`tp`.`fld_ck_no` AS `fld_ck_no`,`tp`.`fld_tipo_garantia` AS `fld_tipo_garantia`,`tp`.`fld_garantia` AS `fld_garantia`,`tp`.`fldFinanciamiento` AS `fldFinanciamiento`,`tp`.`fldMontoFinan` AS `fldMontoFinan`,`tp`.`fldMontoInicial` AS `fldMontoInicial`,`tp`.`fldCodInm` AS `fldCodInm`,`tp`.`fldDescInm` AS `fldDescInm`,`tp`.`fldMetros` AS `fldMetros`,`tp`.`fldPrecioMetro` AS `fldPrecioMetro`,`tp`.`fldTazaMora` AS `fldTazaMora`,`tp`.`fldNota` AS `fldNota`,`tc`.`fld_id_cuotas` AS `fld_id_cuotas`,`tc`.`fld_no_cuotas` AS `fld_no_cuotas`,`tc`.`fld_id_del_cliente_cuotas` AS `fld_id_del_cliente_cuotas`,`tc`.`fld_id_del_prestamo` AS `fld_id_del_prestamo`,`tc`.`fld_fecha_entrega_cuotas` AS `fld_fecha_entrega_cuotas`,`tc`.`fld_fecha_termina_cuotas` AS `fld_fecha_termina_cuotas`,`tc`.`fld_fecha_ultimo_abono_cuotas` AS `fld_fecha_ultimo_abono_cuotas`,`tc`.`fld_capital_cuota` AS `fld_capital_cuota`,`tc`.`fld_interes_cuota` AS `fld_interes_cuota`,`tc`.`fld_monto_cuotas` AS `fld_monto_cuotas`,`tc`.`fld_abono_cuotas` AS `fld_abono_cuotas`,`tc`.`fld_balance_cuotas` AS `fld_balance_cuotas`,`tc`.`fld_usuario_cuotas` AS `fld_usuario_cuotas`,`tc`.`fld_status_cuotas` AS `fld_status_cuotas`,`tc`.`fld_pendiente_amortizar` AS `fld_pendiente_amortizar`,`tc`.`fld_total_amortizado` AS `fld_total_amortizado`,`tc`.`fld_capital_cuota_abono` AS `fld_capital_cuota_abono`,`tc`.`fld_capital_cuota_balance` AS `fld_capital_cuota_balance`,`tc`.`fld_interes_cuota_abono` AS `fld_interes_cuota_abono`,`tc`.`fld_interes_cuota_balance` AS `fld_interes_cuota_balance`,`tc`.`fld_ultimo_abono_interes` AS `fld_ultimo_abono_interes`,`tc`.`fld_ultimo_abono_capital` AS `fld_ultimo_abono_capital`,`tc`.`fld_monto_mora` AS `fld_monto_mora`,`tc`.`fld_abono_mora` AS `fld_abono_mora`,`tc`.`fld_balance_mora` AS `fld_balance_mora`,`tc`.`fld_ultimo_abono_mora` AS `fld_ultimo_abono_mora`,`tc`.`fld_dias_vencimiento` AS `fld_dias_vencimiento`,`tc`.`fld_atraso_cuotas` AS `fld_atraso_cuotas`,`tc`.`fld_tipo_cuotas` AS `fld_tipo_cuotas`,`tc`.`fld_bce_prestamo` AS `fld_bce_prestamo`,`tc`.`fld_cant_cuotas` AS `fld_cant_cuotas`,`tc`.`fldchk` AS `fldchk`,`tc`.`fld_termina_calculo_interes` AS `fld_termina_calculo_interes`,`tc`.`fld_fecha_calculo_interes` AS `fld_fecha_calculo_interes` from (`tbl_tabla_prestamos` `tp` join `tbl_tabla_cuotas` `tc`) where (`tc`.`fld_id_del_prestamo` = `tp`.`fld_id_prestamos`)) */;

--
-- Final view structure for view `wiew_cuentasprestamo`
--

/*!50001 DROP TABLE `wiew_cuentasprestamo`*/;
/*!50001 DROP VIEW IF EXISTS `wiew_cuentasprestamo`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `wiew_cuentasprestamo` AS select `tbl_catalogo`.`Descripcion` AS `Descripcion` from `tbl_catalogo` where (`tbl_catalogo`.`CuentaNo` in (_latin1'101-01-01-01',_latin1'101-01-01-02',_latin1'101-01-01-03',_latin1'101-01-01-04',_latin1'101-01-01-05',_latin1'101-01-01-06',_latin1'101-01-02',_latin1'101-01-02-01',_latin1'101-01-02-02',_latin1'101-01-02-03')) */;

--
-- Final view structure for view `wiew_cuentasprestamos`
--

/*!50001 DROP TABLE `wiew_cuentasprestamos`*/;
/*!50001 DROP VIEW IF EXISTS `wiew_cuentasprestamos`*/;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `wiew_cuentasprestamos` AS select `tbl_catalogo`.`CuentaNo` AS `CuentaNo`,`tbl_catalogo`.`Descripcion` AS `Descripcion` from `tbl_catalogo` where (`tbl_catalogo`.`CuentaNo` in (_latin1'101-01-01-01',_latin1'101-01-01-02',_latin1'101-01-01-03',_latin1'101-01-01-04',_latin1'101-01-01-05',_latin1'101-01-01-06',_latin1'101-01-02',_latin1'101-01-02-01',_latin1'101-01-02-02',_latin1'101-01-02-03')) */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-07 20:59:05
