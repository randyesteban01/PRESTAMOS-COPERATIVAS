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
INSERT INTO `ncftipo` VALUES (1,'Comprobantes Gubernamentales','ventacompra'),(2,'Comprobantes especiales de tributación','ventacompra'),(3,'Facturas con Valor de Crédito Fiscal','ventacompra'),(4,'Facturas a Consumidores Finales','ventacompra'),(5,'Notas de Débito','notadebito'),(6,'Notas de Crédito','notacredito'),(7,'Proveedores Informales','prov.infor.'),(8,'Registro Único de Ingreso','unicoingreso'),(9,'Gastos Menores','gastomenor');
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
INSERT INTO `tbl_catalogo` VALUES (1,'1','ACTIVOS',1,'Cuenta','1085.33','0.00','1085.33','0','0',1,'0','SI','0','0','0','0','2020-09-18 10:17:51','ADMIN',1),(7,'10','ACTIVOS CORRIENTES',1,'Grupo','1085.33','0.00','1085.33','1','0',1,'0','SI','0','0','0','0','2020-09-18 10:19:51','ADMIN',1),(12,'100','EFECTIVO EN BANCO',1,'Grupo','1085.33','0.00','1085.33','10','0',1,'0','SI','0','0','0','0','2020-09-18 11:38:04','ADMIN',1),(13,'100-00','CAJA Y BOVEDAS',1,'Grupo','0.00','0.00','0.00','100','0',1,'0','NO','0','0','0','0','2020-09-18 11:46:01','ADMIN',1),(15,'100-00-01','Caja General',1,'Auxiliar','1085.33','0.00','1085.33','100-00','0',1,'0','NO','0','0','0','0','2020-09-18 11:56:08','ADMIN',1),(16,'100-00-02','Bóvedas',1,'Auxiliar','0.00','0.00','0.00','100-00','0',1,'0','NO','0','0','0','0','2020-09-18 11:56:19','ADMIN',1),(14,'100-01','CAJAS CHICAS',1,'Grupo','0.00','0.00','0.00','100','0',1,'0','NO','0','0','0','0','2020-09-18 11:47:32','ADMIN',1),(17,'100-01-01','Caja Chica Oficina',1,'Auxiliar','0.00','0.00','0.00','100-01','0',1,'0','SI','0','0','0','0','2020-09-18 12:33:05','ADMIN',1),(18,'100-01-02','Caja Chica Ahorro y Créditos',1,'Auxiliar','0.00','0.00','0.00','100-01','0',1,'0','NO','0','0','0','0','2020-09-18 12:33:24','ADMIN',1),(19,'100-02','CAJA DOLARES',1,'Grupo','0.00','0.00','0.00','100','0',1,'0','NO','0','0','0','0','2020-09-21 07:30:51','ADMIN',1),(34,'100-02-01','Caja Dólares',1,'Auxiliar','0.00','0.00','0.00','100-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:43:08','ADMIN',1),(35,'100-02-02','Prima Caja Dólares',1,'Auxiliar','0.00','0.00','0.00','100-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:43:25','ADMIN',1),(20,'100-03','FONDOS DE OPERACIONES',1,'Grupo','0.00','0.00','0.00','100','0',1,'0','NO','0','0','0','0','2020-09-21 07:31:09','ADMIN',1),(36,'100-03-01','Fondo Operaciones Proyectos',1,'Auxiliar','0.00','0.00','0.00','100-03','0',1,'0','NO','0','0','0','0','2020-09-21 07:43:45','ADMIN',1),(37,'100-03-02','Fondo Operaciones Ahorro y Crédito',1,'Auxiliar','0.00','0.00','0.00','100-03','0',1,'0','NO','0','0','0','0','2020-09-21 07:43:56','ADMIN',1),(21,'100-04','BANCOS',1,'Grupo','0.00','0.00','0.00','100','0',1,'0','NO','0','0','0','0','2020-09-21 07:31:21','ADMIN',1),(38,'100-04-01','Banco Popular',1,'Auxiliar','0.00','0.00','0.00','100-04','0',1,'0','SI','0','0','0','0','2020-09-21 07:44:10','ADMIN',1),(39,'100-04-02','Banco de Reservas',1,'Auxiliar','0.00','0.00','0.00','100-04','0',1,'0','NO','0','0','0','0','2020-09-21 07:44:24','ADMIN',1),(40,'100-04-03','Banco',1,'Auxiliar','0.00','0.00','0.00','100-04','0',1,'0','NO','0','0','0','0','2020-09-21 07:44:32','ADMIN',1),(22,'101','CUENTAS DOCUMENTOS POR COBRAR',1,'Grupo','0.00','0.00','0.00','10','0',1,'0','NO','0','0','0','0','2020-09-21 07:32:11','ADMIN',1),(23,'101-00','CUENTAS POR COBRAR',1,'Grupo','0.00','0.00','0.00','101','0',1,'0','NO','0','0','0','0','2020-09-21 07:32:49','ADMIN',1),(24,'101-00-01','SERVICIOS CRESCOOP',1,'Grupo','0.00','0.00','0.00','101-00','0',1,'0','NO','0','0','0','0','2020-09-21 07:35:55','ADMIN',1),(41,'101-00-01-01','Supermercado',1,'Auxiliar','0.00','0.00','0.00','101-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:45:06','ADMIN',1),(42,'101-00-01-02','Farmacias',1,'Auxiliar','0.00','0.00','0.00','101-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:45:35','ADMIN',1),(43,'101-00-01-03','Ferretería',1,'Auxiliar','0.00','0.00','0.00','101-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:46:21','ADMIN',1),(44,'101-00-01-04','Tiendas',1,'Auxiliar','0.00','0.00','0.00','101-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:46:33','ADMIN',1),(25,'101-01','DOCUMENTOS POR COBRAR',1,'Grupo','0.00','0.00','0.00','101','0',1,'0','NO','0','0','0','0','2020-09-21 07:36:31','ADMIN',1),(26,'101-01-01','PRESTAMOS POR COBRAR CRESCOOP',1,'Grupo','0.00','0.00','0.00','101-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:36:56','ADMIN',1),(45,'101-01-01-01','Préstamos Normales',1,'Auxiliar','0.00','0.00','0.00','101-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:47:07','ADMIN',1),(46,'101-01-01-02','Préstamos Gerenciales',1,'Auxiliar','0.00','0.00','0.00','101-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:47:37','ADMIN',1),(47,'101-01-01-03','Préstamos Emergencia',1,'Auxiliar','0.00','0.00','0.00','101-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:47:54','ADMIN',1),(48,'101-01-01-04','Préstamos Servicios',1,'Auxiliar','0.00','0.00','0.00','101-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:48:06','ADMIN',1),(49,'101-01-01-05','Préstamos Escolares',1,'Auxiliar','0.00','0.00','0.00','101-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:48:18','ADMIN',1),(50,'101-01-01-06','Préstamos Vehículos',1,'Auxiliar','0.00','0.00','0.00','101-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:48:29','ADMIN',1),(27,'101-01-02','PRESTAMOS ESPECIALES',1,'Grupo','0.00','0.00','0.00','101-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:37:17','ADMIN',1),(51,'101-01-02-01','Préstamos a Empresas Asociadas',1,'Auxiliar','0.00','0.00','0.00','101-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:48:49','ADMIN',1),(52,'101-01-02-02','Préstamos Funcionarios y Empleados',1,'Auxiliar','0.00','0.00','0.00','101-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:48:59','ADMIN',1),(53,'101-01-02-03','Préstamos',1,'Auxiliar','0.00','0.00','0.00','101-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:49:40','ADMIN',1),(28,'101-01-03','OTRAS CUENTAS POR COBRAR',1,'Grupo','0.00','0.00','0.00','101-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:37:36','ADMIN',1),(54,'101-01-03-01','Cheques Devueltos',1,'Auxiliar','0.00','0.00','0.00','101-01-03','0',1,'0','NO','0','0','0','0','2020-09-21 07:50:30','ADMIN',1),(55,'101-01-03-02','Intereses Vencidos Inversiones',1,'Auxiliar','0.00','0.00','0.00','101-01-03','0',1,'0','NO','0','0','0','0','2020-09-21 07:50:46','ADMIN',1),(29,'102','INVERSIONES',1,'Grupo','0.00','0.00','0.00','10','0',1,'0','NO','0','0','0','0','2020-09-21 07:38:07','ADMIN',1),(30,'102-00','CERTIFICADOS Y DEPOSITOS',1,'Grupo','0.00','0.00','0.00','102','0',1,'0','NO','0','0','0','0','2020-09-21 07:38:30','ADMIN',1),(31,'102-00-01','INSTITUCIONES FINANCIERAS',1,'Grupo','0.00','0.00','0.00','102-00','0',1,'0','NO','0','0','0','0','2020-09-21 07:38:57','ADMIN',1),(56,'102-00-01-01','Banco de Reservas',1,'Auxiliar','0.00','0.00','0.00','102-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:51:10','ADMIN',1),(57,'102-00-01-02','Banco Popular',1,'Auxiliar','0.00','0.00','0.00','102-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:51:23','ADMIN',1),(58,'102-00-01-03','Banco',1,'Auxiliar','0.00','0.00','0.00','102-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:51:33','ADMIN',1),(32,'102-01','ACCIONES Y MEMBRESIAS',1,'Grupo','0.00','0.00','0.00','102','0',1,'0','NO','0','0','0','0','2020-09-21 07:39:16','ADMIN',1),(33,'102-01-01','INSTITUCIONES RELACIONADAS',1,'Grupo','0.00','0.00','0.00','102-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:39:49','ADMIN',1),(59,'102-01-01-01','COOPSEGUROS',1,'Auxiliar','0.00','0.00','0.00','102-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:52:14','ADMIN',1),(60,'102-01-01-02','CONACOOP',1,'Auxiliar','0.00','0.00','0.00','102-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:52:26','ADMIN',1),(61,'103','ACTIVOS DIFERIDOS',1,'Grupo','0.00','0.00','0.00','1','0',1,'0','SI','0','0','0','0','2020-09-21 07:54:33','ADMIN',1),(62,'103-00','GASTOS ANTICIPADOS',1,'Grupo','0.00','0.00','0.00','103','0',1,'0','NO','0','0','0','0','2020-09-21 07:56:12','ADMIN',1),(63,'103-00-01','FIANZAS Y DEPOSITOS',1,'Grupo','0.00','0.00','0.00','103-00','0',1,'0','NO','0','0','0','0','2020-09-21 07:56:33','ADMIN',1),(66,'103-00-01-01','Fianzas Energía Eléctrica',1,'Auxiliar','0.00','0.00','0.00','103-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:57:58','ADMIN',1),(67,'103-00-01-02','Fianzas Comunicaciones',1,'Auxiliar','0.00','0.00','0.00','103-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 07:58:09','ADMIN',1),(64,'103-00-02','SEGUROS Y CONTINGENCIAS',1,'Grupo','0.00','0.00','0.00','103-00','0',1,'0','NO','0','0','0','0','2020-09-21 07:57:01','ADMIN',1),(68,'103-00-02-01','Seguros a la Propiedad',1,'Auxiliar','0.00','0.00','0.00','103-00-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:58:26','ADMIN',1),(69,'103-00-02-02','Fianzas de Fidelidad',1,'Auxiliar','0.00','0.00','0.00','103-00-02','0',1,'0','NO','0','0','0','0','2020-09-21 07:58:38','ADMIN',1),(65,'103-00-03','ORGANIZACIÓN Y CONSTITUCION',1,'Grupo','0.00','0.00','0.00','103-00','0',1,'0','NO','0','0','0','0','2020-09-21 07:57:31','ADMIN',1),(70,'103-00-03-01','Organización y Constitución',1,'Auxiliar','0.00','0.00','0.00','103-00-03','0',1,'0','SI','0','0','0','0','2020-09-21 07:58:51','ADMIN',1),(71,'103-00-03-02','Manuales Administrativos',1,'Auxiliar','0.00','0.00','0.00','103-00-03','0',1,'0','NO','0','0','0','0','2020-09-21 07:59:01','ADMIN',1),(72,'11','ACTIVOS FIJOS',1,'Grupo','0.00','0.00','0.00','1','0',1,'0','SI','0','0','0','0','2020-09-21 08:00:17','ADMIN',1),(73,'11-00','PROPIEDAD, PLANTA Y EQUIPOS',1,'Grupo','0.00','0.00','0.00','11','0',1,'0','NO','0','0','0','0','2020-09-21 08:01:34','ADMIN',1),(74,'11-00-01','TERRENOS',1,'Grupo','0.00','0.00','0.00','11-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:01:58','ADMIN',1),(78,'11-00-01-01','Terrenos',1,'Auxiliar','0.00','0.00','0.00','11-00-01','0',1,'0','NO','0','0','0','0','2020-09-21 08:03:19','ADMIN',1),(75,'11-00-02','ACTIVOS CATEGORIA I',1,'Grupo','0.00','0.00','0.00','11-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:02:22','ADMIN',1),(79,'11-00-02-01','Edificaciones',1,'Auxiliar','0.00','0.00','0.00','11-00-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:03:32','ADMIN',1),(76,'11-00-03','ACTIVOS CATEGORIA II',1,'Grupo','0.00','0.00','0.00','11-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:02:44','ADMIN',1),(80,'11-00-03-01','Muebles de Oficina',1,'Auxiliar','0.00','0.00','0.00','11-00-03','0',1,'0','NO','0','0','0','0','2020-09-21 08:03:48','ADMIN',1),(81,'11-00-03-02','Equipos de Cómputos',1,'Auxiliar','0.00','0.00','0.00','11-00-03','0',1,'0','SI','0','0','0','0','2020-09-21 08:04:01','ADMIN',1),(82,'11-00-03-03','Equipos de Transporte',1,'Auxiliar','0.00','0.00','0.00','11-00-03','0',1,'0','NO','0','0','0','0','2020-09-21 08:04:13','ADMIN',1),(83,'11-00-03-04','Equipos de Vigilancia',1,'Auxiliar','0.00','0.00','0.00','11-00-03','0',1,'0','NO','0','0','0','0','2020-09-21 08:04:23','ADMIN',1),(84,'11-00-03-05','Equipos Educativos',1,'Auxiliar','0.00','0.00','0.00','11-00-03','0',1,'0','NO','0','0','0','0','2020-09-21 08:04:34','ADMIN',1),(77,'11-00-04','CONSTRUCCION EN PROCESO',1,'Grupo','0.00','0.00','0.00','11-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:03:02','ADMIN',1),(85,'11-00-04-01','Edificaciones',1,'Auxiliar','0.00','0.00','0.00','11-00-04','0',1,'0','NO','0','0','0','0','2020-09-21 08:04:48','ADMIN',1),(86,'11-01','DEPRECIACION Y AMORTIZACION',1,'Grupo','0.00','0.00','0.00','11','0',1,'0','NO','0','0','0','0','2020-09-21 08:05:17','ADMIN',1),(87,'11-01-01','DEPRECIACION',1,'Grupo','0.00','0.00','0.00','11-01','0',1,'0','NO','0','0','0','0','2020-09-21 08:05:38','ADMIN',1),(89,'11-01-01-01','Activos Categoría I',1,'Auxiliar','0.00','0.00','0.00','11-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 08:06:10','ADMIN',1),(90,'11-01-01-02','Activos Categoría II',1,'Auxiliar','0.00','0.00','0.00','11-01-01','0',1,'0','NO','0','0','0','0','2020-09-21 08:06:22','ADMIN',1),(88,'11-01-02','AMORTIZACION',1,'Grupo','0.00','0.00','0.00','11-01','0',1,'0','NO','0','0','0','0','2020-09-21 08:05:47','ADMIN',1),(91,'11-01-02-01','Sistema de Información Contable',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:06:39','ADMIN',1),(92,'11-01-02-02','Manuales de Administración',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:06:49','ADMIN',1),(93,'11-01-02-03','Organización y Constitución',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:08:23','ADMIN',1),(94,'11-01-02-04','Seguros',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:08:38','ADMIN',1),(95,'11-01-02-05','Fianzas',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:08:48','ADMIN',1),(96,'11-01-02-06','Cobros Anticipados',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','NO','0','0','0','0','2020-09-21 08:09:00','ADMIN',1),(2,'2','PASIVOS',2,'Cuenta','0.00','833.33','833.33','0','0',1,'0','SI','0','0','0','0','2020-09-18 10:18:12','ADMIN',1),(97,'20','PASIVOS CORRIENTES',2,'Grupo','0.00','833.33','833.33','2','0',1,'0','SI','0','0','0','0','2020-09-21 08:11:27','ADMIN',1),(98,'200','CUENTAS POR PAGAR',2,'Grupo','0.00','833.33','833.33','20','0',1,'0','SI','0','0','0','0','2020-09-21 08:11:48','ADMIN',1),(99,'200-00','AHORROS DE LOS ASOCIADOS',2,'Grupo','0.00','0.00','0.00','200','0',1,'0','NO','0','0','0','0','2020-09-21 08:12:05','ADMIN',1),(100,'200-01','DEPOSITOS A PLAZOS',2,'Grupo','0.00','0.00','0.00','200','0',1,'0','NO','0','0','0','0','2020-09-21 08:30:03','ADMIN',1),(101,'200-02','PROVEEDORES',2,'Grupo','0.00','0.00','0.00','200','0',1,'0','NO','0','0','0','0','2020-09-21 08:30:24','ADMIN',1),(102,'200-03','RETENCIONES Y ACUMULACIONES',2,'Grupo','0.00','0.00','0.00','200','0',1,'0','NO','0','0','0','0','2020-09-21 08:30:34','ADMIN',1),(103,'201','DOCUMENTOS POR PAGAR',2,'Grupo','0.00','0.00','0.00','20','0',1,'0','NO','0','0','0','0','2020-09-21 08:30:48','ADMIN',1),(104,'201-00','PRESTAMOS POR PAGAR',2,'Grupo','0.00','0.00','0.00','201','0',1,'0','NO','0','0','0','0','2020-09-21 08:31:10','ADMIN',1),(105,'201-01','DEPOSITOS A PLAZOS',2,'Grupo','0.00','0.00','0.00','201','0',1,'0','NO','0','0','0','0','2020-09-21 08:31:21','ADMIN',1),(106,'201-02','OTROS PASIVOS',2,'Grupo','0.00','0.00','0.00','201','0',1,'0','NO','0','0','0','0','2020-09-21 08:31:30','ADMIN',1),(3,'3','PATRIMONIO',3,'Cuenta','0.00','0.00','0.00','0','0',1,'0','SI','0','0','0','0','2020-09-18 10:18:33','ADMIN',1),(107,'30','PATRIMONIO, RESERVAS Y EXCEDENTES',3,'Grupo','0.00','0.00','0.00','3','0',1,'0','SI','0','0','0','0','2020-09-21 08:31:50','ADMIN',1),(108,'300','APORTACIONES',3,'Grupo','0.00','0.00','0.00','30','0',1,'0','SI','0','0','0','0','2020-09-21 08:36:05','ADMIN',1),(109,'300-00','SOCIOS',3,'Grupo','0.00','0.00','0.00','300','0',1,'0','NO','0','0','0','0','2020-09-21 08:36:29','ADMIN',1),(115,'300-00-01','Aportaciones de Socios.',3,'Auxiliar','0.00','0.00','0.00','300-00','0',1,'0','SI','0','0','0','0','2020-09-21 08:39:42','ADMIN',1),(116,'300-00-02','Aportaciones Relacionados',3,'Auxiliar','0.00','0.00','0.00','300-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:39:52','ADMIN',1),(117,'300-00-03','Aportaciones Empresas Relacionadas',3,'Auxiliar','0.00','0.00','0.00','300-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:40:02','ADMIN',1),(118,'300-00-04','Otros Aportes',3,'Auxiliar','0.00','0.00','0.00','300-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:40:14','ADMIN',1),(110,'300-01','APORTES INSTITUCIONALES',3,'Grupo','0.00','0.00','0.00','300','0',1,'0','NO','0','0','0','0','2020-09-21 08:36:47','ADMIN',1),(119,'300-01-01','Donaciones y Contribuciones',3,'Auxiliar','0.00','0.00','0.00','300-01','0',1,'0','NO','0','0','0','0','2020-09-21 08:40:39','ADMIN',1),(111,'301','EXCEDENTES',3,'Grupo','0.00','0.00','0.00','30','0',1,'0','SI','0','0','0','0','2020-09-21 08:37:44','ADMIN',1),(120,'301-00','Excedentes años anteriores',3,'Auxiliar','0.00','0.00','0.00','301','0',1,'0','NO','0','0','0','0','2020-09-21 08:43:42','ADMIN',1),(121,'301-01','Excedentes Acumulados Años Anteriores',3,'Auxiliar','0.00','0.00','0.00','301','0',1,'0','NO','0','0','0','0','2020-09-21 08:44:06','ADMIN',1),(122,'301-02','Excedentes Capitalizados',3,'Auxiliar','0.00','0.00','0.00','301','0',1,'0','NO','0','0','0','0','2020-09-21 08:44:20','ADMIN',1),(123,'301-03','Ajustes Años Anteriores',3,'Auxiliar','0.00','0.00','0.00','301','0',1,'0','NO','0','0','0','0','2020-09-21 08:44:31','ADMIN',1),(124,'301-04','Excedentes del Periodo',3,'Auxiliar','0.00','0.00','0.00','301','0',1,'0','SI','0','0','0','0','2020-09-21 08:44:39','ADMIN',1),(112,'302','RESERVAS',3,'Grupo','0.00','0.00','0.00','30','0',1,'0','NO','0','0','0','0','2020-09-21 08:38:13','ADMIN',1),(113,'302-00','RESERVAS ESTATUTARIAS',3,'Grupo','0.00','0.00','0.00','302','0',1,'0','NO','0','0','0','0','2020-09-21 08:38:44','ADMIN',1),(125,'302-00-01','General',3,'Auxiliar','0.00','0.00','0.00','302-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:45:07','ADMIN',1),(126,'302-00-02','Educativa',3,'Auxiliar','0.00','0.00','0.00','302-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:45:16','ADMIN',1),(127,'302-00-03','Crecimiento',3,'Auxiliar','0.00','0.00','0.00','302-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:45:25','ADMIN',1),(128,'302-00-04','Ayuda Mutua',3,'Auxiliar','0.00','0.00','0.00','302-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:45:34','ADMIN',1),(129,'302-00-05','Aportaciones',3,'Auxiliar','0.00','0.00','0.00','302-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:45:45','ADMIN',1),(130,'302-00-06','Adquisición de Activos',3,'Auxiliar','0.00','0.00','0.00','302-00','0',1,'0','NO','0','0','0','0','2020-09-21 08:45:55','ADMIN',1),(114,'302-01','ADQUISICION DE ACTIVOS',3,'Grupo','0.00','0.00','0.00','302','0',1,'0','NO','0','0','0','0','2020-09-21 08:39:12','ADMIN',1),(4,'4','INGRESOS',4,'Cuenta','0.00','252.00','252.00','0','0',1,'0','0','SI','0','0','0','2020-09-18 10:18:46','ADMIN',1),(131,'40','INGRESOS FINANCIEROS',4,'Grupo','0.00','252.00','252.00','4','0',1,'0','0','SI','0','0','0','2020-09-21 08:47:13','ADMIN',1),(132,'400','INGRESOS OPERACIONES',4,'Grupo','0.00','252.00','252.00','40','0',1,'0','0','SI','0','0','0','2020-09-21 08:47:38','ADMIN',1),(135,'400-00','Intereses de Préstamos Vigentes',4,'Auxiliar','0.00','250.00','250.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:49:19','ADMIN',1),(136,'400-01','Seguros de Préstamos',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:49:28','ADMIN',1),(137,'400-02','Comisión por Mora',4,'Auxiliar','0.00','2.00','2.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:49:37','ADMIN',1),(138,'400-03','Comisiones de Pagos a Suplidores',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:49:46','ADMIN',1),(139,'400-04','Ingresos por Servicios Legales',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:49:54','ADMIN',1),(140,'400-05','Recuperación de Cartera',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:50:01','ADMIN',1),(141,'400-06','Préstamos Vencidos',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:50:13','ADMIN',1),(142,'400-07','Gastos Administrativos',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','NO','0','0','0','2020-09-21 08:50:23','ADMIN',1),(133,'401','INTERESES INVERSIONES EN VALORES',4,'Grupo','0.00','0.00','0.00','40','0',1,'0','0','SI','0','0','0','2020-09-21 08:48:19','ADMIN',1),(143,'401-00','INTERESES INVERSIONES',4,'Grupo','0.00','0.00','0.00','401','0',1,'0','0','NO','0','0','0','2020-09-21 08:50:57','ADMIN',1),(144,'401-00-01','Depósitos a Plazos',4,'Auxiliar','0.00','0.00','0.00','401-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:51:15','ADMIN',1),(145,'401-00-02','Cuentas Corrientes',4,'Auxiliar','0.00','0.00','0.00','401-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:51:29','ADMIN',1),(146,'401-00-03','Cuentas de Ahorros',4,'Auxiliar','0.00','0.00','0.00','401-00','0',1,'0','0','SI','0','0','0','2020-09-21 08:51:38','ADMIN',1),(147,'401-00-04','Acciones en Cooperativas',4,'Auxiliar','0.00','0.00','0.00','401-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:51:49','ADMIN',1),(134,'402','INGRESOS POR SERVICIOS',4,'Grupo','0.00','0.00','0.00','40','0',1,'0','0','NO','0','0','0','2020-09-21 08:48:45','ADMIN',1),(148,'402-00','CONSULTORIA Y ACESORIA',4,'Grupo','0.00','0.00','0.00','402','0',1,'0','0','NO','0','0','0','2020-09-21 08:52:58','ADMIN',1),(149,'402-00-01','Educación y Capacitación',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:53:23','ADMIN',1),(150,'402-00-02','Asesoría en Desarrollo',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:53:36','ADMIN',1),(151,'402-00-03','Elaboración y Ejecución de Proyectos',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:53:46','ADMIN',1),(152,'402-00-04','Viajes y Eventos Educativos',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:54:10','ADMIN',1),(153,'402-00-05','Excursiones',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:55:15','ADMIN',1),(154,'402-00-06','Ventas de Útiles Educativos',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:55:25','ADMIN',1),(155,'402-00-07','Ventas Libros y Folletos',4,'Auxiliar','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-21 08:55:35','ADMIN',1),(5,'5','COSTOS OPERACIONALES',5,'Cuenta','0.00','0.00','0.00','402-00','0',1,'0','0','NO','0','0','0','2020-09-18 10:18:56','ADMIN',1),(156,'50','COSTOS FINANCIEROS',5,'Grupo','0.00','0.00','0.00','5','0',1,'0','0','NO','0','0','0','2020-09-21 08:56:22','ADMIN',1),(157,'500','INTERESES DEPOSITOS A PLAZOS',5,'Grupo','0.00','0.00','0.00','50','0',1,'0','0','NO','0','0','0','2020-09-21 08:56:58','ADMIN',1),(160,'500-01','Intereses Pagados Líneas de Crédito',5,'Auxiliar','0.00','0.00','0.00','500','0',1,'0','0','NO','0','0','0','2020-09-21 08:58:01','ADMIN',1),(161,'500-02','Intereses Pagados Ahorros San',5,'Auxiliar','0.00','0.00','0.00','500','0',1,'0','0','NO','0','0','0','2020-09-21 08:58:10','ADMIN',1),(162,'500-03','Intereses Pagados a Socios',5,'Auxiliar','0.00','0.00','0.00','500','0',1,'0','0','NO','0','0','0','2020-09-21 08:58:20','ADMIN',1),(163,'500-04','Intereses Pagados Ahorros Retirables',5,'Auxiliar','0.00','0.00','0.00','500','0',1,'0','0','NO','0','0','0','2020-09-21 08:58:29','ADMIN',1),(164,'500-05','Intereses Pagados Aportación',5,'Auxiliar','0.00','0.00','0.00','500','0',1,'0','0','NO','0','0','0','2020-09-21 08:58:37','ADMIN',1),(165,'500-06','Penalidad Por Cancelación De Certificado',5,'Auxiliar','0.00','0.00','0.00','500','0',1,'0','0','NO','0','0','0','2020-09-21 08:58:45','ADMIN',1),(158,'51','COSTOS DE LOS SERVICIOS',5,'Grupo','0.00','0.00','0.00','5','0',1,'0','0','NO','0','0','0','2020-09-21 08:57:12','ADMIN',1),(159,'510','COSTOS VARIADOS',5,'Grupo','0.00','0.00','0.00','51','0',1,'0','0','NO','0','0','0','2020-09-21 08:57:36','ADMIN',1),(166,'510-01','Compras útiles Escolares',5,'Auxiliar','0.00','0.00','0.00','510','0',1,'0','0','NO','0','0','0','2020-09-21 08:59:00','ADMIN',1),(167,'510-02','Publicidad y Promoción',5,'Auxiliar','0.00','0.00','0.00','510','0',1,'0','0','NO','0','0','0','2020-09-21 08:59:10','ADMIN',1),(6,'6','GASTOS',6,'Cuenta','0.00','0.00','0.00','0','0',1,'0','0','SI','0','0','0','2020-09-18 10:19:10','ADMIN',1),(168,'60','GENERALES Y ADMINISTRATIVOS',6,'Grupo','0.00','0.00','0.00','6','0',1,'0','0','SI','0','0','0','2020-09-21 09:00:25','ADMIN',1),(169,'600','REMUNERACION AL PERSONAL',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','NO','0','0','0','2020-09-21 09:00:52','ADMIN',1),(179,'600-01','Sueldos y Salarios',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:03:11','ADMIN',1),(180,'600-02','Horas Extras',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:03:18','ADMIN',1),(181,'600-03','Salario de Navidad',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:03:26','ADMIN',1),(182,'600-04','Seguros Familiar de Salud',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:03:35','ADMIN',1),(183,'600-05','Plan de Pensiones',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:04:58','ADMIN',1),(184,'600-06','Seguros Riesgos Laborales',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:05:08','ADMIN',1),(185,'600-07','Incentivos',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:30:38','ADMIN',1),(186,'600-08','Uniformes',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:30:45','ADMIN',1),(187,'600-09','Vacaciones',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:30:54','ADMIN',1),(188,'600-10','Prestaciones Laborales',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:31:20','ADMIN',1),(189,'600-11','Atenciones',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:31:28','ADMIN',1),(190,'600-12','Cursos y Entrenamientos',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:31:35','ADMIN',1),(191,'600-13','Bonificaciones',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:31:42','ADMIN',1),(192,'600-14','Seguro Médico',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:31:50','ADMIN',1),(193,'600-15','Dietas y Viajes',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:31:57','ADMIN',1),(194,'600-16','Asignación de Vehículos',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:32:05','ADMIN',1),(195,'600-17','Combustibles y Lubricantes',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:32:18','ADMIN',1),(196,'600-99','Otras Remuneraciones',6,'Auxiliar','0.00','0.00','0.00','600','0',1,'0','0','NO','0','0','0','2020-09-21 09:32:31','ADMIN',1),(170,'601','SERVICOS Y SUMINISTROS',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','NO','0','0','0','2020-09-21 09:01:04','ADMIN',1),(197,'601-01','Buró de Crédito',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:32:46','ADMIN',1),(198,'601-02','Comunicaciones',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:32:56','ADMIN',1),(199,'601-03','Refrigerios y Reuniones',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:06','ADMIN',1),(200,'601-04','Viajes y Transportes',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:17','ADMIN',1),(201,'601-05','Energía Eléctrica',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:25','ADMIN',1),(202,'601-06','Agua y Basura',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:34','ADMIN',1),(203,'601-07','Alquileres',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:40','ADMIN',1),(204,'601-08','Cuotas y Suscripciones',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:48','ADMIN',1),(205,'601-09','Material Gastable',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:33:56','ADMIN',1),(206,'601-10','Seguridad y Vigilancia',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:34:07','ADMIN',1),(207,'601-11','Servicios Técnicos',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:34:15','ADMIN',1),(208,'601-12','Transportes y Envíos',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:34:53','ADMIN',1),(209,'601-13','Seguros a la Propiedad',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:35:36','ADMIN',1),(210,'601-14','Fianzas de Fidelidad',6,'Auxiliar','0.00','0.00','0.00','601','0',1,'0','0','NO','0','0','0','2020-09-21 09:36:33','ADMIN',1),(171,'602','GOBERNABILIDAD',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','SI','0','0','0','2020-09-21 09:01:11','ADMIN',1),(211,'602-01','Reuniones Comité Ejecutivo',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:37:11','ADMIN',1),(212,'602-02','Reuniones Consejo de Administración',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:37:30','ADMIN',1),(213,'602-03','Reuniones Consejo de Vigilancia',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:37:39','ADMIN',1),(214,'602-04','Reuniones Comité de Crédito',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:37:51','ADMIN',1),(215,'602-05','Asambleas Cooperativas Relacionadas',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:38:00','ADMIN',1),(216,'602-06','Asambleas Generales',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','SI','0','0','0','2020-09-21 09:38:11','ADMIN',1),(217,'602-07','Dietas y Viajes de Directivos',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:38:20','ADMIN',1),(218,'602-08','Representaciones',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:38:28','ADMIN',1),(219,'602-09','Donaciones y Contribuciones',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:38:54','ADMIN',1),(220,'602-10','Atenciones',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:39:03','ADMIN',1),(221,'602-11','Festejos y Celebraciones',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:39:24','ADMIN',1),(222,'602-12','Incentivos a Directivos',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:39:35','ADMIN',1),(223,'602-13','Seguros Médicos Directivos',6,'Auxiliar','0.00','0.00','0.00','602','0',1,'0','0','NO','0','0','0','2020-09-21 09:39:45','ADMIN',1),(172,'603','GASTOS BANCARIOS',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','SI','0','0','0','2020-09-21 09:01:20','ADMIN',1),(224,'603-01','Cargos Ley 0.15%',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','SI','0','0','0','2020-09-21 09:40:01','ADMIN',1),(225,'603-02','Certificación de Cheques',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:40:09','ADMIN',1),(226,'603-03','Sobregiro Bancario',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:40:22','ADMIN',1),(227,'603-04','Manejo de Cuenta Bancaria',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','SI','0','0','0','2020-09-21 09:40:29','ADMIN',1),(228,'603-05','Comisiones por Transferencia Bancaria',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:40:37','ADMIN',1),(229,'603-06','Confección de Cheques',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:40:46','ADMIN',1),(230,'603-07','Cargos y Comisiones Bancarias',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','SI','0','0','0','2020-09-21 09:40:54','ADMIN',1),(231,'603-08','Retención Estados Bancarios',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:41:04','ADMIN',1),(232,'603-09','Comisión por Cheques Devueltos',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:41:12','ADMIN',1),(233,'603-10','Moras y Recargos',6,'Auxiliar','0.00','0.00','0.00','603','0',1,'0','0','NO','0','0','0','2020-09-21 09:41:23','ADMIN',1),(173,'604','REPARACION Y MANTENIMIENTO',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','NO','0','0','0','2020-09-21 09:01:27','ADMIN',1),(234,'604-01','Mantenimientos Terrenos',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:41:35','ADMIN',1),(235,'604-02','Mantenimiento Equipos de Transporte',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:41:43','ADMIN',1),(236,'604-03','Mantenimientos Equipos de Oficina',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:41:51','ADMIN',1),(237,'604-04','Mantenimientos Equipos de Cómputos',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:00','ADMIN',1),(238,'604-05','Mantenimientos Equipos de Seguridad',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:07','ADMIN',1),(239,'604-06','Mantenimiento del Local',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:15','ADMIN',1),(240,'604-07','Combustibles y Lubricantes',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:23','ADMIN',1),(241,'604-08','Placas y Revistas',6,'Auxiliar','0.00','0.00','0.00','604','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:33','ADMIN',1),(174,'605','RELACIONES PUBLICAS',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','NO','0','0','0','2020-09-21 09:01:37','ADMIN',1),(242,'605-01','Promoción y Publicidad',6,'Auxiliar','0.00','0.00','0.00','605','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:41','ADMIN',1),(243,'605-02','Atenciones a Socios y Relacionados',6,'Auxiliar','0.00','0.00','0.00','605','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:48','ADMIN',1),(175,'606','HONORARIOS E IMPUESTOS',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','SI','0','0','0','2020-09-21 09:01:48','ADMIN',1),(244,'606-01','Impuestos a la Propiedad',6,'Auxiliar','0.00','0.00','0.00','606','0',1,'0','0','NO','0','0','0','2020-09-21 09:42:57','ADMIN',1),(245,'606-02','Honorarios Profesionales',6,'Auxiliar','0.00','0.00','0.00','606','0',1,'0','0','NO','0','0','0','2020-09-21 09:43:05','ADMIN',1),(246,'606-03','Honorarios Legales',6,'Auxiliar','0.00','0.00','0.00','606','0',1,'0','0','SI','0','0','0','2020-09-21 09:43:13','ADMIN',1),(176,'607','DEPRECIACION Y AMORTIZACION',6,'Grupo','0.00','0.00','0.00','60','0',1,'0','0','NO','0','0','0','2020-09-21 09:01:57','ADMIN',1),(177,'607-01','Depreciaciones',6,'Auxiliar','0.00','0.00','0.00','607','0',1,'0','0','NO','0','0','0','2020-09-21 09:02:33','ADMIN',1),(247,'607-01-01','Depreciación Activos Categoría I',6,'Auxiliar','0.00','0.00','0.00','607-01','0',1,'0','0','NO','0','0','0','2020-09-21 09:43:29','ADMIN',1),(248,'607-01-02','Depreciación Activos Categoría II',6,'Auxiliar','0.00','0.00','0.00','607-01','0',1,'0','0','NO','0','0','0','2020-09-21 09:43:37','ADMIN',1),(178,'607-02','Amortizaciones',6,'Auxiliar','0.00','0.00','0.00','607','0',1,'0','0','NO','0','0','0','2020-09-21 09:02:45','ADMIN',1),(249,'607-02-01','Sistema de Contabilidad',6,'Auxiliar','0.00','0.00','0.00','607-02','0',1,'0','0','NO','0','0','0','2020-09-21 09:43:49','ADMIN',1),(250,'607-02-02','Pagina Web',6,'Auxiliar','0.00','0.00','0.00','607-02','0',1,'0','0','NO','0','0','0','2020-09-21 09:43:59','ADMIN',1),(251,'200-00-01','Ahorros a la Vista',2,'Auxiliar','0.00','833.33','833.33','200-00','0',1,'0','SI','0','0','0','0','2020-09-23 10:23:24','RANDY',1),(252,'200-00-02','Ahorro Juvenil',2,'Auxiliar','0.00','0.00','0.00','200-00','0',1,'0','NO','0','0','0','0','2020-09-23 10:28:21','RANDY',1),(253,'200-00-03','Ahorro Navideño',2,'Auxiliar','0.00','0.00','0.00','200-00','0',1,'0','NO','0','0','0','0','2020-09-23 10:28:46','RANDY',1),(254,'200-00-04','Ahorro Educativo',2,'Auxiliar','0.00','0.00','0.00','200-00','0',1,'0','NO','0','0','0','0','2020-09-23 10:29:11','RANDY',1),(255,'200-00-05','Ahorro Vacacional',2,'Auxiliar','0.00','0.00','0.00','200-00','0',1,'0','NO','0','0','0','0','2020-09-23 10:30:01','RANDY',1),(256,'200-01-01','Asociados',2,'Auxiliar','0.00','0.00','0.00','200-01','0',1,'0','NO','0','0','0','0','2020-09-23 10:31:52','RANDY',1),(257,'200-01-02','Institucionales',2,'Auxiliar','0.00','0.00','0.00','200-01','0',1,'0','NO','0','0','0','0','2020-09-23 10:32:10','RANDY',1),(258,'200-02-01','Servicios Profesionales',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:33:24','RANDY',1),(259,'200-02-02','Supermercados',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:33:47','RANDY',1),(260,'200-02-03','Tiendas y Eléctrodomésticos',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:34:36','RANDY',1),(261,'200-02-04','Farmacias',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:35:13','RANDY',1),(262,'200-02-05','Ferreterías',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:35:43','RANDY',1),(263,'200-03-01','Sueldos y Salarios',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:37:54','RANDY',1),(264,'200-03-02','Salario de Navidad',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:38:18','RANDY',1),(265,'200-03-03','Seguridad Social',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:38:37','RANDY',1),(266,'200-03-04','Seguro Médico',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:38:55','RANDY',1),(267,'200-03-05','Impuestos s/Renta',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:39:17','RANDY',1),(268,'200-03-06','Retenciones Honorarios',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:39:35','RANDY',1),(269,'200-03-07','Bonificaciones',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:39:52','RANDY',1),(270,'200-03-08','ITBIS',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','NO','0','0','0','0','2020-09-23 10:40:07','RANDY',1),(271,'201-00-01','Empresas Relacionadas',2,'Auxiliar','0.00','0.00','0.00','201-00','0',1,'0','NO','0','0','0','0','2020-09-23 10:50:15','RANDY',1),(272,'201-01-01','Depósitos de Asociados',2,'Auxiliar','0.00','0.00','0.00','201-01','0',1,'0','NO','0','0','0','0','2020-09-23 10:51:18','RANDY',1),(273,'201-01-02','Depósitos Institucionales',2,'Auxiliar','0.00','0.00','0.00','201-01','0',1,'0','NO','0','0','0','0','2020-09-23 10:51:41','RANDY',1),(274,'201-01-03','Depósitos de Relacionados',2,'Auxiliar','0.00','0.00','0.00','201-01','0',1,'0','NO','0','0','0','0','2020-09-23 10:52:00','RANDY',1),(275,'201-02-01','Intereses Depósitos a Plazos',2,'Auxiliar','0.00','0.00','0.00','201-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:54:00','RANDY',1),(276,'201-02-02','Plan Funeral',2,'Auxiliar','0.00','0.00','0.00','201-02','0',1,'0','NO','0','0','0','0','2020-09-23 10:54:22','RANDY',1),(277,'400-08','Ingresos Pago Inscripción Socios CRESCOOP',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','SI','0','0','0','2020-10-05 21:17:42','RANDY',1),(278,'400-09','Otros Ingresos Aporte Conformación CRESCOOP',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','SI','0','0','0','2020-10-08 17:27:19','RANDY',1),(279,'103-00-01-03','Deposito Local',1,'Auxiliar','0.00','0.00','0.00','103-00-01','0',1,'0','0','0','0','0','0','2020-10-23 16:33:04','RANDY',1),(280,'400-99','Ingresos Varios Menores',4,'Auxiliar','0.00','0.00','0.00','400','0',1,'0','0','0','0','0','0','2021-02-04 14:41:53','RMENDEZ',1),(281,'601-15','Suministros Eléctricos',6,'Auxiliar','0.00','0.00','0.00','6','0',1,'0','0','0','0','0','0','2021-02-05 11:02:19','RMENDEZ',1),(282,'601-16','Gastos de acondicionamiento y pintura',6,'Auxiliar','0.00','0.00','0.00','6','0',1,'0','0','0','0','0','0','2021-02-05 11:08:24','RMENDEZ',1),(283,'601-17','Otros gastos de condominio',6,'Auxiliar','0.00','0.00','0.00','6','0',1,'0','0','0','0','0','0','2021-02-05 15:03:23','RMENDEZ',1),(284,'103-00-01-04','Sistemas informáticos',1,'Auxiliar','0.00','0.00','0.00','1','0',1,'0','0','0','0','0','0','2021-02-06 09:03:38','RMENDEZ',1),(285,'101-00-01-99','Cuentas por cobrar varis provisional',1,'Auxiliar','0.00','0.00','0.00','101-00-01','0',1,'0','0','0','0','0','0','2021-02-19 10:07:20','RMENDEZ',1),(286,'200-03-09','Retención para pago de seguros préstamos',2,'Auxiliar','0.00','0.00','0.00','200-03','0',1,'0','0','0','0','0','0','2021-04-19 14:27:05','RMENDEZ',1),(287,'200-02-06','Claro comunicaciones',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','0','0','0','0','0','2021-06-23 10:21:30','RMENDEZ',1),(288,'200-02-07','Condominio Plaza Italia',2,'Auxiliar','0.00','0.00','0.00','200-02','0',1,'0','0','0','0','0','0','2021-06-23 11:14:25','RMENDEZ',1),(289,'605-03','Dietas y Viáticos',6,'Auxiliar','0.00','0.00','0.00','605','0',1,'0','0','0','0','0','0','2021-06-25 10:12:13','RMENDEZ',1),(290,'11-01-02-07','Libretas Socio Crescoop a amortizar',1,'Auxiliar','0.00','0.00','0.00','11-01-02','0',1,'0','0','0','0','0','0','2021-10-16 12:28:02','RMENDEZ',1),(291,'201-02-99','Otros pasivos miscelaneos',2,'Auxiliar','0.00','0.00','0.00','201-02','0',1,'0','0','0','0','0','0','2021-10-21 09:19:14','RMENDEZ',1),(292,'100-04-04','Banco Popular Cta. No. 825981673',1,'Auxiliar','0.00','0.00','0.00','100-04','0',1,'0','0','0','0','0','0','2022-02-09 09:16:33','RMENDEZ',1);
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
INSERT INTO `tbl_interfascontableformularios` VALUES (1,1,'Depósito Bancario'),(2,1,'ND Bancaria'),(3,1,'NC Bancaria'),(4,2,'Egreso de Caja'),(5,2,'Otro Ingreso a Caja'),(6,3,'Nuevo Depósito'),(7,3,'Nuevo Retiro'),(8,3,'Aporte de Socio'),(9,3,'Cancelación de Certificado'),(10,3,'Apertura de Certificado');
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
INSERT INTO `tbl_interfascontableotrastipo` VALUES (1,'001','CIERRE DEL PERIODO',''),(2,'00S1','PAGOS A PROVEEDORES',''),(3,NULL,'RECIBOS DE INGRESOS CXC',''),(4,NULL,'NC BANCARIA',''),(5,NULL,'ND BANCARIA',''),(6,NULL,'DEPOSITO BANCARIO',''),(7,NULL,'EMISION DE CHEQUES',''),(8,NULL,'MOVIMIENTO DE CAJA',''),(9,NULL,'RETIRO DE AHORROS',''),(10,NULL,'DEPOSITO DE AHORROS',''),(11,NULL,'DESEMBOLSO DE PRESTAMOS',''),(12,NULL,'ANULACION DEPOSITO',''),(13,NULL,'APERTURA CERTIFICADO',''),(14,NULL,'APORTE SOCIOS',''),(15,NULL,'CANCELACION CERTIFICADO',''),(16,NULL,'SALIDAS DE CAJAS',''),(17,NULL,'OTROS INGRESOS',''),(18,NULL,'CORRECCIÓN DE REGISTRO',''),(19,NULL,'REGISTRO DE NOMINA',''),(20,NULL,'FACTURAS A CREDITO','');
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
INSERT INTO `tbl_interfascontabletipotrans_conf` VALUES (1,10,'Nuevo Depósito'),(2,9,'Nuevo Retiro'),(3,13,'Apertura de Certificado'),(4,14,'Aporte de Socio'),(5,15,'Cancelación de Certificado'),(6,6,'Depósito Bancario'),(7,4,'NC Bancaria'),(8,5,'ND Bancaria'),(9,16,'Egreso de Caja'),(10,17,'Otro Ingreso a Caja'),(11,11,'Egreso de Caja'),(12,12,'Apertura de Certificado');
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
INSERT INTO `tbl_profiledocument` VALUES (1,'CRESCOOP','Local 12, 2do. Nivel, Plaza Italia','809-795-6278','','','','','','','',5,'����\0JFIF\0\0\0\0\0\0\0��\0C\0	\n\n			\n\n		\r\r\n��\0C	��\0\0\0\"\0��\0\0\0\0\0\0\0\0\0\0\0\0\0	\n��\0k\0\0\0!1AQaq��	\"2Vt����#57BRrs�������34STbu��$%\'68CDFUcd�����Ev��ᤴ���&We����\0\0\0\0\0\0\0\0\0\0\0	��\0K\0\0\0!1AQa��\"4Rq����2r�BS���#35Cb��$%��T���D����\0\0\0?\0ڀ\0�|\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0ޏ=P,�k�>>k͸N�+���M����y�F��t�̙�U0��)�{�:��W|��_sǼ�f��*�.εsSN�&+k|��H�ɴ\\��Ԗ9�-�T\\��o��X��<��L��\nW����%N�q�RUi�)9&�Z��!ZիԕZ�gRrz�R����H��p���E{)�|Fi�Ӈ��4N�s�&x��~4���E�\"#��\0�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0Z���1�Զ��l�Q���+p����⿗7����Ԭ6o�:�P��nb�in�\r~�_�_	�k�8�|_����Ĝ�R_�.���\0n��[Ctx�}��\0���\0�js�0�\0���_w5�:b���!R�W��HR���<�>:��,+���\\��S]��g�ʱT�sʪu��݄����3�h|Y��Y%z%�G���dX6R?���|%�ʽ*�߃>����\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0����x�`�$�h���Ƥ߱��oC�JM=5Љ}#v�S3fo���p�\"MKu�q�R}�OuyM>w��W�����u>�Ӌ��%������Y�6b������u����_[J��+�%��Y��E��w+��s]s����6�湚��fW�t*��|h�I-�3�>`}�4>,��̒����0{��őa�O�[~ʿ�-�S�T���\0u�\0\0\0\0Cư�\Z�.q\\B�Ҍ橪�����oM_��;��\0%{k½���j��]Q�0���t�z\0y�\0����\n��>Q��\0����^���|�ݏ^;���z\0y�\0����\n��>Q��\0����^���G����G��@������a~���>�W��/�P�I��w��h�����\0�^ڰ�}C�)��\0���a~���<jǯ�xZ:a����W��/�P�G��K�Յ��(��w��(釠����~ڰ�}C�?�/�5a~���<jǯ�xJ:a��>rg��/�P�G��L�Ӆ��(��w��h�}�|�ܛ���>Q�����a~���<jǯ�xZ:_|��\'{i�������N�х��(��w�<-/����M�F�|�~~rw��3�0�G�X���h��������0�|��?Y7�F�|�Ƭz�����t�̘��ц{�)c�I�<ׅ/�>R<o��|�Z�s艑��v�|�m#>Y�\n�P�G�a�yO|#�������ig��W]�цK�K�|�r�a�.V�1�)�F�_�>��٫�����L��+Ӫ��ՅE�&��/S�X}*\0$\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\r�����vl�Lɘ�:�Zt];t�ʴ�C���� �j�n+T��7:�d�9>m�-�\'��c{�6U�Qn�+��O�^�\Z���#����]��F;��\n#N��?(�Us��r�\0��⮫����F�r�WiR����޸����ft���#F���Z���=�C�H�l������\0l�yO�S��g���\0\0>@��ۖ���s�[Q��{X��).;����W���Tl:�#R��8�FQjI�\ru��k��\"�+�8Ғ��n��zpt�����|����m2���Ln�3�����������?\'�OB��-�R�F�ȚH��8�cV4��ѫ�,M.���Έ�v���e��T�Z\0�L�������\\Ʊ|J48�E5]�����#Ap-MkȻTF���K���k��`�><ʜjoR���\"a+�iTքh*]�\rJ2kN�[���i�1�))Ybה\Z�+�~��`�j�N��s5��#Ν�cY>�d�����te�8�N\Zu�r�}�0�������ԁ˽(*7\nY�/�.N��ޟ�\'�g�2�U�&S�1���4���WBor����!*��rй�oV�U�*�jP�$�(�֚�Y�g���SK�����Ķsk���O:=��)=z��� ��0�K���G�)�>�����\"�,w	�X}W��umYk�Z�Zk��+��:ث��x����᱖�Q������v�n�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\'��T^YS���!�H�bX��q*JZ�����)��_�w�i����O=c����W?r�5�#ϜKs��\\�~*&&��z��fW��J�v�z�����㫓T�bz�բ4_�G�|��DgR�$�D�8>`�U�\"����\0u��_��)��{~	\0:��\0\0\0\0�Z��ݜ��W�gN0�#h�[:��u�\r�Ip��{����h���\'\roj�7cZf4���tݢh����}cy�^V����B��n�JsZJ2OF���b%F�v.�U�r�,Z�\rס����Z�H�R(ԕ\ZД*BN2���5�4q��)��_�U�xOL}zT�^�%�L�敺�5]��1u\n�)Ǹ�>�W{N��� r)-9�Q�]�F�����)\'ȍ\n�O��\0�p,�T��j��Ή�T�Z+��[�\Z�v�̮��{����\\\nk�T��z\r� ��M�̰��\Z��7�ƺ�{��Sԍ&����+�F�����@�W�EÕ)���f߃���S�<Ϋ������z�\Z�]�:U%�Eu[�*�t�M�������«8Պҽ���(ϱ����z�$�&A���񌕍Qưz�3�ׄ�\'�*î]k�s&E��Vx��c8l�r������5���Q�vshhͨ�Ww]�=}q�/��*95�(��()��Щil�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0g=�9.,u\Zmh��\'>�{(���X��vְ���U���(��F���?=�z�(a�	e-t�n��%�����Dis��y�εtG�h`b�]�N��	��r��:�Rc���s��n)�b{U�<B���R��&�Ք�z.�K��(̼�bo�<��\Zk�C���~#M�Yn\'&�I=NC����Xm�]tܡR_�fʩ�&Yrם�wswZ�OWV���{z�E��������u�z�����\05`]��MtFz�������#!&�\"�H�^���,/�)o���-�Q�T��\0u��\0\0\0\0\0l০��8�gl��ͪ�b���C�ޫG]�w^>���������2z��x�\r���ٿ\ZǾ:��~��&����;�>�\0��a��U���7\n����Q�|SG��;F�.X����/J���oh�oǇ%�K��_=�7d��N�ײ���\"�JK�_�}�噶�brɚ�9V�c��W�]�α�����ꆩ�yJ�_ѯ\\\n)v�����P�M��(T\'Uw��UI\"�!B44r���j�N=��UIjF���5Т�|�.�cU�[��\Z�WԊ��Y.+�-װ�״h�UՕZ��4��X�����^2�hj��o2��v�ue�ud\Z�O��[.��@�P���;�����5�K�K�~C�\'�WU�{�0�i�ft���v�Uj����a?p��|FΕ��Xգ^*�9��Z�3�`N�{@�uk_#b5���u�e\'�s���fz��k��2�ƌ�N\"�~1�<��s.x[��mE�T\0l�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0����jT�ΥI�0�u�oD�kdp�R4����a�r��$GM���Vү��hά[�W������kn�u��k��YF�P©7N����>�����5=J{��L�;���}{���6�f�}����w�W�3����^�W�:�&�)7����$�E�����_�,�у�G�u�*&1\r�.�u({���D�:f��\0��柄-�/�v��>~?��%o�Ϡt1��`������e����ckW��k�W{��y��ue5]�TF�W{��z������#1{���Ȍ��I���Q��m�,���\0�[�/��e�z]=��\0ap\0\0\0\0\0\0\0\0Q�>i2ˋ{{�3�sB�ZsMJ��d�\Z|�@D�N�o;tl�9�Uor������MoP�����p�0fm؆в��j�4��a��E�ub�k����hMr��N�c�_�����U�O��5����rg���FQ���ԗ4֍zc�(�I9�yr��r\\jN�S�e�<m�\0G����Mջ�\\�%�*��/L�\0e]5G^����u䗣�U�C�Y]�J�tZ�5q��)�xT�\0<N?R�F�\0Jb���ĝ�̺#���|OWz+�%R译�c�?����r赐��v)�h��}�̺#��>\'���+�KY��)�h��Ե��⟖_ ���tSޟ#�c����E	]�Z�?�qO�/�z����W����Ϣ�������Q*�+�K���)�X��Թ��b����>�f}�������SRЮ�q*�K���+�h��Թ��b����G��ˢ��y�ފ���Ī�/d㘯���/d�x����ٟE=��=]�	Y�_�ƱO�/�z�2�S�������S�y�ފ��u�Е~���k��~A�`�ƱO�G�s�>�{�#�z��T����?�⟖��W�Ő?�⟖_ ���tS�y�ފ��2Uz�r�O������g�������S��\'�����VZ.��Ȕ�����qO˯�z���S���ss>�{��lOWz+�QRTz���S������\0�b��_!ss>�{�\0D��ފ��>�,��g����� Ŀ,�B>�f}�������o����*�\\?������\'��Q�I�oZ��\nwd�N�T�%���L�o�AMiq��Y|�U�0�XFg�P��J΄(BSz��1I7ߢ./�cr��o�&t��u��߻���0���U78K�\0-��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�%����?lN2���u��╩˛�?���2��6�OgY>�սX�Ӿn��\Z�R��O�����!j�nkT��VU*Փ��\'��oV�yMڌ�lS�vgΟ���kE�c��xs�x�:;V��Uí��*�]�TZW�h{���QK����D�!�E�U��+����t���	�����$�^��OZ�W��ޢ��;�W��t�h���_��w�����-�p�:_��w��@�K�j�@�:�$�D/����6�\0DaՒ{��l���#���\0t��_��(���{~	\0:��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0Nr��i�kļ��Y�K%�g��kS�t���T���9k�L�v��_�������3]\\!���%�6�w�*�Xa���-xz����~dce�Jr�\'9�����|�iC��o׊�U���:���~�W*�+�EV����<׽:�n���#A��.qڥq\\|TL�\ZtZ�Z����gJ�/@��?[�OEퟐu�?��+�L�+;\'[_������2�_�ݮ&ޣTSU֊9Ηj�J������=\n�v�� ��h/�w����%��o�dFO�@��?t��Y���\0��_��\'��{~	\0:��\0\0\0\0\0\0\0\0\0\0\0\0\0\0Ḹ��UqmS��Ijޝ��ē�I��U%J��1A��zZ<\Z潑�#-uZ�̃�fʲ�;A�,=�{��n���ӛׇ�꼅oh�^Yj��m4��u�}�6�3������ΐ^�m��\0���?�=T�3���l�jO^e�����ٔz�߫M�OWr]z�vi�3�X���Rl��cޱ��\"�ƫ������{�S�8����Q���_ޱ���ٯ�8��c�dG��+�|3/��~��q=]�o�ٯ�8ǽc�e}T{5���l�����G���=ߩ�OWr\\���k�/�X��_U������\"2zv��^��|3/��~��q=]�q�ٯ�X����E=T[5���h�>W�W�|3/��~��q=]�o�٧�x��c�c�C�_�z�����cW�>�f_���S�OWr[��vm�/�X���P���,_ޱ��$�v�W]zߜ}�̿����Y��w%���f��b�����O���,_ޱ��$�_�y_���9��{�S�8���]\'�k����c�e}S�6���h�\Z��O�>��_���O,�z����=�o��z����{f�������\'Q��#�e����>X��w%��=���X����E��Η+la�\0�C�ș��*��}���\0��������}(�v�Xco�oO�Ǫ�g���o���\0�E>:���|����i�<����K���̞������L���\'�\Z�J���~��O��DP�N�fQǓ=���&:;�>�n{0�iS�4)�r���OO�G�ó�VŒxn`����.#��j@�x�]\n��-�s�$���2�m�*����3��>�j3�����lU���|e�A������g�����\"�Q�?O�\'��#.e.�������wV|<��?!��m�1M�h����8�}����ҿ6}����_��~�˸��kM����(�+�}��b�-V��z�����Jj��ZgXT\0z$\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0#�K�u�e�/ӗ˩\\Mk�B:/�L��F�s����õ�Za�Z}ܟ�-�������=�nms��*ӟH`��#{��r*r��zW\'�Bz�����״��i�\0uZ�����2�/�C�W���I�?@��?[�OE����.>�?�����������J�\0�\rp��_QT�i�4s�J�܊j�A\08���W]:�A���6c�M�ő�C����ُ�6�\0f�f����%���.�߂C���\0\0\0\0\0\0\0\0\0\0\0\0\0\0��ߞ̭�w���`ѕM#]R��8�4�^\'�f�Q�%GT�Mv���b�=��=�+�i�nm��Z�^���g�1�fL����f���޳|c��vk��N7����ު���������&�|`���O��1^K���K\Z\'W&�OR�⺮�4�Yjo���j>t���qn�/��V�\0�ՔO�j\rU���Re\0�+�o\"�Dh*W^�Q=A	W^�P\0j���)4\n�\"�\\YW#�j�\Z\Z9Jh�4޼�M����\n�t(��H�����1L�gsM�ڔ��}�u�����.�c�J��e�i\nWK�\ZϩK�$���G��mr���Wʳ>o=3�~��VwV�N�f�#(�*Q��kT��T��\Zۭ�Z�Y���I��Sz�۱I���^\"OQ�F�+P�\Z��%(J/U$֩����YVmc6��-N�c�?�i[0��x�9Tv�C�\0m \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0	:Mܻ��bPo_Kз������bl��]��U��c�~ƭ(y�Am��L1�T|%��gL<G_�X�K������*��f���p(�PF���k���i�J��<�>��=�q�I�t���	�����#�^��[za�?y��gd��S�~�?���[���M����B��Av�*������}�̞���\"�z�����fG��o�fovf?�v�~����Oo�\"@T\\�\0\0\0\0\0\0\0\0\0\0\0\0\0\0���X6��w8N1gN����Js���S�k�d3���1M��~\Z�*\\`�3���wؿ�����t��%�������ml+��uksʴ�Mv��4�&s�Zͭi;��򞯃��F�*�יC-�{`ؾI�S\Z�Ы�M�KukR׺k�?��W��S�b�W�7f��t���P�b�=|�������+�8���W�h#Av��Wڎ2���L\'U��\'�khE��|�/*�H�_(��#Av���-�qR� ��޸j�\'�Pj��+�-D��Q]�40BB�i�P�m)���/�בU��\Z�����;��n(d��v�!V[�U�K�	�Pm��|��0V�.Rѧ���˱����~��1���߯\rr.Q�\0-��jZi��q���ߞ�	�8���-��GYK�z<�������ˉ�v�6�a��k����;��n.Q�U\0�P\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0���3n���f]�����\\׌�[t�mo3&�\0��ĉS��E��|��Ͽ����R�Y]Q@U\0��5}��uf��]������@����W������&���S�\'�O���{g�\\O����?������\0x�}��:�\0�\rn���4s�e]�WTZu]�`�2���{R�(z}F̋����̋�Ȕ]���Ot��Y�ݚ�\0����(��{~	\0:��\0\0\0\0\0\0\0\0\0uo1;9��ӥ���\\ٍ����6��&����5LDG�gH}SEU�&��]��-w�쩷;j���)z��&�;��_�cF��9~m�ױ�T��&�Q�n���\0)ҙ���O�������\Z�1�\\ɎU�{���V�����qIq�%t�u��G�\0Q�=3�v��)�ML�v~��*��ʺ�\r_a��+�G��WK�Z_)إ���Zn�U��lԿ8��\0���?�;��T�W�i*����\\{�8���x|���Z4�.����Zg�*�+�j�_�G�/���?m{��QV\"mU<�)��i�ܟk\'_c�ԡN�:�ތ�M>MGj=0l�V�1�gK�%�n��=gܗK�p��3E�\'e�;�u{R|W�sGa�2�%��*���p�U3M�\'�T�L{ba��a)��=�Z��/3d��e�p���ըNQ��;�.L���1L	���a��B�ڪ�t��N/��\'��,�NU.���L*�Z�֭{��y�M�6B���a\'��~��W19-�7ٝc���R�2g�.�rÕI������X?�{����xK��9�w�u��<jSqk�U��/��ޢi��j.Y�ft�LËU�\n2����\Z��*�\0*��WTZ�_üo2�Y]���D�2�\Z��E�݄L�n��}�h.Օ�v��\r˵L�f�״����\'U�̮��������U=@\"U��P\0�_w$�ܛ��s����E�#�:o���h�8>#m��ح�E:t�Z��\'-Q��WZtc�uq��S���<�Ti���t|��^$��������up�|{c�||���\0&�ٞ�=��\0:R�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�}D��Q��fZ�\0�E�\0���r��;�b̫����`U6�5����R����S��K��y�)��P4T�OB�$ʐ.�Š��[�C�W�D-���b���>)4�����?�~�d~��? �b��k������~����+,u�n%��^��X���]eN+����+�-\Z.��T�]\n������s�#2{���̋��Pt9���_�M�ř�ٿ�+}�	m2K�������`\0\0\0\0Z3�U�v�K���w]\'�.2~C������R�)U���_�x���\\T�j�%Rr��\'�g��\0�CUX�\"���5�L�~9�LDt����J�n���~���g;��*vq��.Z�����~�J�f�U��\'����h?)g�S�m=�\0��*�<�3�ǲ�Ҙ셞�\Z�\Z96��\0\Z�\0\0\0\0\0�u*R��Jr��\'�G��3���T�W�iv�^^�΂��mNq��>U�����O�?���g��ֱ1ɻN���c8�5;J�O�����$�IF�kj��B���/U(�\Z=��!r�k�8Ӫ�*��/c?Vlۆ>��yb��W�uOo��\'�\'r��ɫ�]���s���t]��^axn �o��k��V�f�v�O�}���Ih�5�/9_g��Z��XL��!̎��f�$���¿ �X	����?nf;�Ql�g��n�Ul�g���-�~C��x�������s˭�d�+�����yچ�x�����ԧ�oՎ���jW�����A�����?!��L?�Ot߫�1�4�>�p�{G�CL��G\n��~CӁ�R;��6�X�y���B���{�? �\Zd?j8W������������s�}\r2�+�����!�Q½����x��t�A�m���?C\\��K��~A�5Ȟ԰�{G�=0)���=�x~�w<���\"/�K��~B�C|��O_��J�a�J{��6�X�y���C����� ��?j�_�a���=J{��6�X�y���C����� ��?j�_�a����S�����s��\r��L/ް���!�T������x��R��<�V;�k�q�������>�YpYO\n��~Cҁ�R��<\r�Vk�{���a^���>��چ�x����0�\0���GDw<���#{P½����>��1�	���f�EB���\\��w���=�sʢ���M6�u��\0{>�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0��Cj�˙���?��OIr oHm~�����AL�mg�Q��R���\0�S��K�!��(\n���UI��Z�U=HG$eÉ]�X���4K2tU�f��\0b����!OEO�տ�+��Mc�l�i���?\\2/EퟐuqO�z��gh�b��.>�?���[�ke4T���+Ǵ��o����uDh�@\0�:���p�\0�Y��[|Y�x��8ṝ\'�����7{7�%o��-�O���D\0u�\0\0\0���L��Rs�b�&��6��sD��p����3��S��_�3�NXe���f���.���>�>�k�\\���z[�i�r?jy�}X�T��ݮ���+�b/ލ���\0慈\0\0\0\0\0\0\0\0\0\0\0\0\0��i���c�Mʃ�	�.>���q�T��Mj��1�r�c���_OZR�Jm������\0c�\0kU�n[�����u���3�ES��\ng�gt��]Ͳ��&����7�ԩ�ϊ�\0	\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�\"����o���2zK��C�ys7�����WڿD��|����\0����:ՕԴ5�X�E5�o���aMZ�WU�4O�ј�*?�m�+��MbtS�������\\�{-�3����E轳��)����3���LW�}��g�Yc���p֪�iU$q�_i�4sg(ӽ�o�S�|���W{��=@�=��U������T\"�)��q��%ē�wt\"����o6r?�Ti���&ߌ�������`\0�sn8��oI�OK��_c���.�Y[Ժ�-!N.L����lJ��w�=t�]H�_m{wV�eQ�����5�4�ª��\r=����^3w�Wm>�u���l�K�J5�\\SUhԌ��J/T�3���K&�K�ҭ\nN��~ڴ�lW����1�F��S���f��S��j:�r|gF�������.f1x���yDgn�i���ᙦ;g����X��[�*�u�3��;b*��f�R:��*V�`\0\0\0\0\0\0\0\0\05�QHT�H��JQ��5�����q��e˫��J���ǋ��|W�>Fʱ�`/�=���Z�.���⼈����2��h���g�1�Mey��1�������ӻY�{p�l��\0)c�������A./����g�F\'��aה�(?]M�S]h�VwT�m��Qz¤T��{�Sn�ڌ�r�mZ�p�����1�j��*nq��k���j�K�\0v֘\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0I\'�Gכ3}���)��D\n��ћ3}���)�}��J?7�Z,�\0u�}�)c��]Qh(*���MX�	T\ru\0f>�]�oq\\|Rl����k������:�z�i�Bߑz/l�����O���O�����~��}��e���-�Z^\Z��օN2�ƫ��v}�*��]�Y�i]u#Az�1z&ar�٥lB�\Zx�#V�_�B���\"S��J0�\\�)(�.m���l+fYe�<��`.\ZN��N�����&Y�W���w�����y�ښ��s�#��KՀ��\0ͨ�&�IjȪb��S����%�\ZXe)q��*x���N�/y+�J��OU9���/��ο�=��j���k�kɣ��wG➹����.�|��Ф�oN\'G\Z�l�\\&����ogFU�?��k�)���z�mۍff\"#�g�*���f��H�v�=�]�1e�-��N�>���Ԓ�)���1�ɳcɹ���Svڬ�-s�D�χ��~C�f,v�3c�����u�yU��]�����|�:ꞇ�<�e����#�\Z�4M5��Q�O|Ν�ι�ww�ՙ۝�TM>������S�e��U��2�lO8<ߐ�\\�޼�פ�uz�ഌ���~=L��#��m���1�p7�\0������Lo��~��b����bm~\Z�&;~��\rs(\0\0\0\0\0\0\0����#\r�Į$�-�J���p^W��zZ�]��n5�f\"#�x>k��t�uN��6���{��R��lb���.z����ϕ��o�.f��ݡv�My-}��=?{wZ���ķ�W��/g.Z��o�س�FQW��rg�<g�{�b3{�39�i���=��;�$��q��z���ԫ(�:�\0v�7���>�������W��\ZUD�Oc���ъ�M�|*���e�q-�U�*K�~�O�֏\Zw0��a����z(M)w��m�;�Z�Sh���|�y5�J�U����!�����|���T\\�H�J*I��?���Lk\n\0%\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0���F���d�ӌ\\�$�����]��B�,�R�����o��R�jT��%S����C�����_�)������Sʹ:C*oG�q*G��5gm�a}XY��ו�\n��s�$��K�>\\�Q#a��ӑ��V3*&�:|\'���b�⩚����P��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0[\"t�o�͙��\0G���\"�k�͙��\0G�����%��-�qO��,w��i�8��(Z*K�����#AQ��FN���G�o�+��M��Q�������h�{/�S����E�ퟐu1_��y��Y�:x����_�j|VXk�2ܵ��Ք\\����Օ�2�4������\Z��L�,鴌:ڭ\';<=�z��(A����y{��b�Zp0�F�󫑾n^�ܿ��k�yq���^f���+H���#����0�UQ�U�~^���_<j��T\0o�0�������U�����|m��Ϥy��p��۩i�j�5ڒ�Z)�h��/���:UM��?5^m>��f׆��D��7�0\0�r��K��½&so�̷m�-�i[��T��1�Zy��9(�Rm$���H�;ZͲ�Y���Q�ք�+h��C����~S�}��W�i�܏��G.7\nc���7nsO\'�sj��������������\0�\0~�pf\\�ߛ~bg)`Tm�nE7�����ε^bV.F�,�.p���u%N��X֥8��Mw�ϓ�5ۖ��z�wK���~�|���S�o�NA���YŨ�nG&��O	�w���i�������7��=��}�Ý \0\0\0\0\0\0oCm��vv�q�%V���W�O���dj��8Js��b��o��#�k�^`Ǯ�=_���i\'�Mp���/�\0gyO��5\\y��_����Kls�x\ngι��������w�!{������מ��������yW�2�z������P����Kz��#$fG���(4�qMTZw�G�K�<[Fan<ۑ��h�Ɲ����|-XJ�}=����;@��웗���kY�e��\'޸~��_!��}Ż���]�_�3�џ���s����j�j��13��|ڽ�*>ׁ��G_�x\0.L0\0\0\0\0\0\0\0\0\0\0\0\0\0�}�����/d�x�?}�zIzȮ5*K�cx���]�`{9���b�#*�5���e��ϱw.\Z��g�����n�3�\\�M��POJt)�F+��;ew;ϭ��;{�O7G\\�\Z��1��w�>�k��3n��=իecR����m�O�ԏ5$���3o.�ɔ9�\'{rn߫Y���;��_��ru�@�?���\\K�z���8��)s`�]ܹ�����8��K�����.E��{~P�\0��@\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0è�\"~�����AL�R \'H�6f��/�S+Q�~o��[A��>ߔ�֥w�h(�*+�>��{-*��h��uh�x��Bd�&��m�eq�I�B.��\0]�oq\\�Rn�f=\n4�!qȽ�~A�ſx\\���gp��߼.~�S��_���WVZ�/S���J�Wh-\Z���]�szw�a�2����F��)�#j����(����<V[˸�lƭp�U����K��ԗ6��͝a{6ʴ0+=��\r*��;�:՚���]Iv܏+�}�]q�Sǯ����ex����d{���ڍ*4!B�)ӊ�#�IrH�	%�\"#E�\0���5�������������\0l�.�?�g �s�6�/L~�V��\08��m�Ƹ�}��y��Mux�f�\0�,�}qJ������n��կSd5��o���G��\r�W+\\\Z\r\'�֗?\"�^G�bC���vA�L���#K����O����p]��<��Un��-��������\0��\Zk̐��j�Cɗ5�}/��D�8�H�q~W�G���\\�[(��7�6��u�|%N\\$���}�ȣh�[��:cZ5;㿄�L��9��Q�[����J�,��=��;�7�Ԯ�J��-yŭS9���S4U4�\ZL?F��ư\0��\0\0|��[M����P�=+^�<w_�~o�`��S��;����kNz��/�/�~~�y�v��I�(�ƕ�󧷄vF������>?�UϛG��g��\0z��2��1�L���:��������\'�y�11�r�2�,�i|�75N�|�ݪ�c9ʮ��<�U?�>�㵺���ɸ�.����}���ؐi�T�eEJ/T֩����Gqz��SK��Z�(F^g�\0��O���W�����ݟa�f��ئf���\0���JΣLe^��\0�� \0\0\0\0\0\0\0\0\0\0\0�s�p²>w�q��\n���^ʬ߱�W\\��}��#J.��Ŷ��%�C\r��J{@�Ұ�kI��d�;t�\n�	T~^��gY�9f��wD|�����#k��<K?g�_h9��=��z�XP����O^���-o�L�nW~��ru���]W*���fW\'�]��������;z�w-����fN8{A͂}w2ߺ*~�d���lo����P��^�W��\n�{t\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�D��ћ3}���)��]D��ϙ֟��~��YڏE��|���\r�z7�X�aTּ�j�E�R�+�]�U�[�������3/D��׭Wm���&��(�-�Y��;��p���)�����!�Y���:���럼����\\S�u��j|VXk�2��Y+د]YjkE�*q��v��Go\n�1o�°�J�WwST�R��JO��eL����-O�XeK˚�\'���O�\'�+�M-�l+م���T����u�\\!�\n}����\r�Y�]�kݺ��?N���\\�կ\ny����^Ŭve�;�B0���i�LV�G�(~���q��)��h���l5�%��j4�]lY�D[�\ZD\0!�\0\03���i}mS�T��?��py,�\0GZV��R����g(�k��\'b�sLo�h���b}��d�rq����x��f��m�2�#�n�T��i}��F>7&���z���mt�Xd�j�j��w)v.��_��v?\"���l`?fgZ�,o��7G\\���fQ���q\\����=��\0�_\\bw������U�Z��m�vp\0~ۦ�h�)�4�~m���f���\0>� `,�;��L�O	����/K�7�T�\Zr�k�2�6�~u���*�wm1E�:ھ\Z�`�\0E�d�R��&~A�P�<��ܮ�in����Q��ϲa��34�WDW:�o͞���T\0s��\0\0>Vg�!��Wx��ޥ��f�EyϪ��l8۫sm�џ���=d��>^E���l�S9�ik\r?�]j���{�v��af���\\#�<;��1��N�I֨۔����e\n\"��؈���:β\0��R�P3�����1�=n,�����^����z�\nl����caVzQ�^�স����f���߶�O�s{��\ZQ_�Oo�{4v���<��QUS�S��g���r���ԩ%����9�T�.;e/\"m�tz��?؞p����}s]]���j3��Xʺ��\0��`\0\0\0\0\0\0\0\0\0\0�v���HҦ�M���}H��0�\0I}�K*�8�X}�4�I��]\n����|���o�i�{=�gJ��=�����h���G�4��^w��/U��M���0��\\O�����T���W�����T���TT�0\0\0`]���9�%� �����s�?E2s�K�tm��:�\07��������Pmn�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0˨�=\"Z[h����\nd��4k�\0�T��Ng��QK�����-��-��=?�>�z�ĵ4WyuA^=eJj�����S�T��/�T�[b�ﴹ��� �D�o��Zp�����\'}ٟC��?\\�E�l�����C\r��7��V�\n�:�JN2�Z���E���4n���3	�1��a�Fqys>�B�����g��^?V��s���h�A5+���9C��ĸ������)�`�x}{��#I7��W�*I-5e_	�6��U���=#��hp�\r�sʽ<����? 匉�����JΔ4ߒ�R�휟3рY�ۦ�1E�C{M4��cH\0�@\0\0\0�g_L��d����Uy8?���WTcsoR�Inԃ��I��Tg�>+-��m�L{f&\"{\'I{�����a۫�6�+]W��*�J�oE��o�A���+g,݉f\Z�J��g�#.p�^d��RLt���ʹB�J��y��v�\'��kٿ6��D�����U����q�]S4S�4S>w}[����E�|-�y}��O�>����@���\0\0\0XNt�\Z���85(�=\Zk�&���ds�Lñ��;��ܥ�Z%�ן��mj�]fr����\'�^���K� �-�|<$=�������d>Vȧn5�by_�¨�ү�^64����6������jK������O���\0\0ỹ�gkZ��j��U\'\'Ԓղ:c8�\\g���7�qQ�\'Ժ��Wk8ߤpHa4g�[�i-?�\\_��a���g������o�:G召�!���1�pTN�7϶~��T\0t�\0\0\0ZujP�\nԦ�R���%�$�2Ee�b�9��bpkZ�Ӛ]S^�y�硔v/�J��l�9���V�O��R_\n~r����W�e�ޱN�-��8�U�Lw�=����1��͊�͹����ޗ��I�%ZN���_G�8m-�mkJ��8(�\"9���7�FG����\0*�4��DL�β��.�{�\\限\0o\0\0\0\0\0\0\0\0\0\0����tvi�^ҫ�swco�G�S���\'�2�KX�Y�acӔ��\\���UojG����I��Vu��&��㦑۹���60��tӿr7>/R�]�u]�%�F\n��#Av�\Z��F�!�\r�\0u���9��[`O���tT���b�����u�o�-Y����B��݀\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0-��5��/�ә��K�̀�e�5��-�����_��V��Ѩ��)hv�����)c��\n�܊D �}�w��,E\"����dh3�C�	\\�\"��E��aӓ}�R�I�Fn��zt0|{4Շ響vT[즷���>bL�g�M�\r:��+�Mnh�ӯ>�\0\r�h\0\0\0\0\0\0\0\0\0\0U�(�*/��S��l��{��c1��7��{D�W��`���g����]\\#{���mQ7*��t�����q5c=�)�J�����\'垾D�S��;�V�qZu�MΥI9�O��|Yg#��S3��bfgH�����̹^/^2�W�N�3�\0����\0\0\0\0���e�n����{*�ۣէ�֩�3�\Z׃<�ڢ���܍i�������r�U�tN��{a>p,Z��mq�)\'B�kC�5��}N���2���廬�sW[�.{��|eFz��K_:3\\^�C������m/��n�w�=��ҹ>aNk������T��T>\\A��7�-�\\BZV��.<w��_6����������U�Dv��X�0�k�s�13�ę�X�e��NM�ۿG�G�~W��hy�ϋ��\rof<�\"\";��~��8�3 \0�c�\0\0\0�ʘ�l��p�v�z�W�F�c�Kͯ��@��\\۪+��o}QT�TUOO[����J�tn)Ƥ$�4֨����o���%���n���\\xʌ���8��Wi���c)�0�bh�����d�{�~�\\�p\0g=�\0\0\0\0\0\0q׫\n1�J�!��\'�R�l�ٟ����IЩ�#}^�N�.�ױ���&=�U�4r�U�\\��^�f9W&\":�4v��qB��ݫ5�=\Z��=�u��[S�yQ�W]J�ҩ[7����5r����N+�\n�PO]�ݦ�Y�/������5Gͨ��L.�p��5A=F������yh�Wj�-REw�Y`]ܷ�����:c�Q6���[��O�̝q�(�{!��o�-Y�{~P�\0�7`\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0e�\Z�������\nf���\Z�������\neoi����hwa���)cr���HTL�>�Y�A=\0�]K�S�Z�(ы��IF	sm�G\Z}�Z�ճ�g��[�]Qr�pM/n[\\%4��O�-�,��ثv�T�{X�V\"�6��2��\"�?8�=�r���ZTK��g���hQr\\:��Fժl�����ۢ-�S�7\0��\0\0\0\0\0\0\0\0\0\0���$���˦�~����܁g_[|*>��Q|y�\"�\r�;%�h��2�}�qJ�\n�\r��uZ]��u��5��3%�p̸�g�d�|F�u��)�]�h���<�x;Qf8���oi1~)�W�?W�\0E\0\0\0\0\0\0\0��Q�哳��J��\n����׃�>_��	�JQ�����j5�ɓ��ߐ��W��{��\0a����e厞]N�א�v��V���_�w�=��l:���i���k�>u?\n��=쁪]f��:ﱚx=�F�k=9:���Z/9��|F��\\�U�-�ʣ���y�Dt���}wZ��ީZr��m�Q����ט܍��H��Ǻ>-���\rN��^��G�~ ۜ�\0\0\0\0\0\0\0�/��usݜ�Tݵ�~���᤟�o�-	��ɢ-�趚z�:�2�S�>|rV�֩�wN*����ߕi/)�v1֚�5�:>	�Xr\\F�>����\0��\0\0d��Ѐ�%���u�c-���+�ڜ�X�0��,��z��*��ק6xM��:�G!�ƥ�֝��t�hv��]����wW��]]V�Z�Y9�u$�)7Ͷ��<�h�3c��y�gL���8�36�o����{,���\Z��/�ԥc)k*p��k켺�)i��~r�5{�\Z�똊���L�Z�r�wj�W:�exg��O�S���l7�u��!�Q�;%�8(�yQ\nzO�6�y�Ko�Mgȅ](S[Y�}�V���\\k���	i��E�l|ؔ\0s�UR�+��-W,*�k�����[��_�̝��(�[k迖��\0W�3\'lyd}��?Z�G���@��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0R\\ѯ���^���_��l\\ѯ���^���_��V��~\Z���h�\Z���9��␧\0�P�U�	՜iS����c�ro�H��ً��C������b:]_j��Mp��+��StU����N;F���~��5��e�zu���.�aSMA&�e�g��5r7�gOjّ`f�|f�o�Ξ�˂�\0Z�0\0\0\0\0\0\0\0\0\0\0���oMt�*q\\�4�ʤ��[|�D��S?����Y\Zή��5W�\\%.*�7�O��O1\n��� ��h�6ӱ|j������WW���T�	�/�1�E�q3�����=�g�b�sUq�7G�?�@�Հ\0\0\0\0\0\0\0(֦Z��>a�9`w7m��x4��,uq�+�bc���������r�ͽXU���MI8��H���M��,����]3\Z�O���[�^Y�����g_ls�lk	o��uҲ��iT�U����ڧ�W���Ŝ��5���;����S�V0�Zz�h�#�sM��<����U������wd,��c�Luw����dp���\0\r�N\0\0\0\0\0\0\0\0��VlX~c���5t�����M���Z��~c\r��#��qKL^�n5��B�6�b��F�*�U��-�c�g�����ޜ=�nG2x�j�yq���3m�pk,j�iҼ�\Z�K�U�yh��{�]7)��bw���U\Z�\0>ҷ�-ZK�#�H����|��.��\'��K��p��f���Ok����f�rT0����\"�N�/��\\S��r|;��n./+Ժ��*իIΥI�e)7�m��T��8��\'Ξ3��hs|�lǀ�>t���V997\'&���|�zq\\t*��w��\\��Eu�ƥ�a]u#D�_��N���>*;[��k������a�#��z/*!gJW��.=�m�I�>^U��Wқ�q�o�V���c�G�Z|��{c��i�,+Ǵ�Jz�[���H�LJ�4N�����\\_����;�A�}x2��\0]W�	ޖ�C�l��W���^C��{~P\0[v\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0���^�#��6f�tR�3`��{���f�tR�2����O��KA�^�O��K�.�%ugTޥ+E9r2��65�mO�{�U(`6U��kO��(>��=9\"��N=�<B�jv9~�k�mh���[��ϕr��0k|��kgg\Zp���[|[�7�NO8�����>?�{��3���z4����v�/�p�|3�����5F�*kH�����wRӀ�\")�!s���\0\0�\0\0\0\0\0\0\0\0\0\0:ؖk�X\\a�Д��ʕX�r�q�ѥ(���3����$��t�蝰n��?����R����J��N�������Xo���?\'`�\0uO��ш=I���?����Q�N�?���\0���\0�|�~��<����?�F �\'l�T�\0�w�H��O$e��m2�]�Xs���cB���T��䞯zro��ث�@��^��͖�����\rf�*�DD�#��mc˷n\"u�����;�-��f���;ԫ�R�8�ֱrI�Wq-�O�&��?\\~��T�>-S��O�6Q}�)OY��.��J�W��h=�yͻX���Tx>W.�.MN�i:k:i<������e��z1��}:MT�Zq׌N��}�7������ǩ�d��\'���2��ZƬuu,�R?mKׯ���%A�8���և�|�5����/�mU�Uw)����K��d�c[x{S좟���vM�b~��������UmZ���%:rR�w�ލw9�\Z��ݠ��q׿���^���Q�\ro�)�<���%�%�>�Y+���W��R�Y��\0*����zy.�\0�����[�e�����5h}�W�����1�ސ���KS��e�j��;)Ӌ�*��|<M�[�ڜ����v��f�����s,ʬƷ,ۏm4�	��%u`��5h�Y�\n��s%����T)�1�r�X����,lr-i<B��|�!�y�ٷ+Z{H�m���S�(���v���ͬ�i��?�1EQɊ*�j�Y߬ƳLi1�]�����0�N�1W*7�1����x jPW*X��y�	ïi�K{��4j�y��Ji5��>�R�`�*|�̽�q�daȿ߮��o�H��b�8\\]����MSb\'�����[�ES]1;��V>�l��̽�q�c���k2����o\"��z?���s����{��O��{�����e>�e���2E���-?C�0�\0���3/e�#*��|�T-)6�NUgSwW��ɷ�LaE�mSQ\ZDp��x�)�#�|�o��p�[��Z�ҕj�}QH�$v�q�~e`��¾���Eڌ���/H��RO�i��b��a�<�=��^\"0�j�<�봌���7_fK��\n�-���W~�6�ug��E�v��Sv��W7+�fw�5�Uʦ��Y����OC�Gʮ=�V��SUև����0ߩֿx��Gd���S�~����٨�0��l���~r��{�Y�_�6����>U��Uү�_�6��mO��揄�����͈w�ʩp8���Sܠ�y�>$h95�oi̵KR�������꿠�Ot~��忿��Bx�d���?[2G��|�\0��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0l��^�#��6f���K�̈́I=uF��2�t�؞u̸��Jx�XT����4�a���m=ޤ��4���6�6�F�~R���K��T۵���(M��x�7{O�,k�]VzB�\Znroĉ/�.�5eK�||5R��R��]�d�}���ȑyKgY?#Z�<��m0�h��S��\'�)�e/+=6��L�۳1^\"yS�����Y\r�˿<����]<+\r�­iX��t�m�Cr�\ZQQ�\"��Gt�\ZC��\0H\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0>D	�����k��=�\"����U�l����羍���I�=��`�Qs��ʿ�F��o�H�T5W��������6�ޅ�g�\\����+���l|���imq���:�u�]����ooY���h�LU\Zǽm��gX|ʹk���Ik��~\'��k�Q�oR�Isev��l�*u���V�6��2)�b)�\\����\'�Q��Y?F�zyo��8}7��}=��7��0��xY�����t}\n�����=��imm��ޝ?��G1G8��E�z\"�fͬ=�1LtDi�Ǚ��YU�o�\\�O�(���\"��~&��G�h�m��u?�>�g^�߫�J�>�E��p/��D��\"�\0~���\"N����^�{�G�d��\0���\n��x\0\0\0\0ṫ\nP�J�݌\"��b\\[�\Z�ڶn����/�ʦ�)�t��R�[��Ri��1���{�7\n����Z|T���ok�5�ώ�/j�;��Ƕ~�V����\"�{~�5w���KAMV�\\uew�BU*�OR���8�ٞ�:��0���l7�u��a�Q�;%�\"8).D(�Y��j�_�6����B���M�W�\r��+�S�Q���->y轰�븣m1��W�����U���>@йM����eH���[��z���O.d�������\Z��\"�\0�~�_��Bې�=_��\n�Sv\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0Z��\Z�p8k��[G~�zt►�I#��g��c���R�����O�5���/�#���E��\0UQ{Z�^���>����7�S<5��pz\\,�.nSzA~��\Z�kX�]}\'��R��7�hR��\0k;%��\'˞�)��|G\'����3��\Z{f#�e-���5���;E�W\r�}\nI�S�����W9���������Ɗ�/��$��ap�+��i��S�l-�&��]1�?Fx�}iE7V���We�{2mz������������\r䞫U��U+U���VS�z������:߃���c]w�3���[8�>���]�9�U��6�n�s����ʐ�񤏫m���W����[���/O�Ԓ��^�[�k��ݺc�T�\0��a��/���]w*��S�`���<�a�X�Wض��ӯ(�s�j2ON1]�����\\�`�}��\0эA�G���ى��z(���`67(ˢi�D��R�S��ޟK��/���מֱ��0�X�3<(1���mu�8ڣ�M𥳌�/�����^�诎u�ڿ#�K��q�����7�xa��O�^��u~��r\\�\0�v���}�j�\0\n_)ȶ��}�o䜏���q;4��F����z�ݤٙc�\'m.Uɳ���ꦙ�\0��VK�����v���׮����F^��W�X�+?��T��d���r�p���[<�uya�+�U\"�Y��mw�n#}��W�\0f?����-������u���\0��\0��[@����E�c�r��`�����K���ȑَh���oU��H�1˝kE�\0��\0R2�X����Z�Y�4��TF�\0�#-��E<��L~i�K	�\r�4�S׾�_�ᩳ�M~�}m/��_�3;�d�콕��\n�sGdx�^��^(ɘ�ro�Z��,϶(��5�2\r������V�9?�36�]N�е��Z��6ڌf�ᦼ�(�m)U|1hǇ�Ӝ:<�vE{�X��e�\0Y����c�^+f�\0�]2�i�-Qk.�TU:�*�c�K������&-^�5����gK8e������Q���x�W�,R�~*�<DvEog�Tsn���Xl�\r�<^�K�E�\r�}����]��\0-1�\0�H��~����~��0����7��i���%�Zg����\Z~i��g�S�Kg8E.1ıN�:~do�����\0.�����rĹ��G�3�?��o.��|JF��؋Ӷ�����T�xB�yp��e?���>��\0�Y��e|��a�r�4�\n�{4��_LlJv�=�p�KONbpr�!\'����C�ބ��Sw����+��iޣO�dS�R����TO4G�U;�\\d�DB���u]��w��w�E�R��h-Յ.�4�=E5]��N����S�~������~�Z������aң���B~��]�W�\r��&Ĺ��g�n��6���G�G揄������Ք=S�ow�-Av��*�������dn��^<������O8� WG���2������=cȿl��W��P��>�W��B��݀\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0��:��aQ���ЍiZ4���_\'��������ZѾ��gq\r�U`�(��i6�+�:ʯ�-�4U]3TL����Mx�ư��_�5�n�k;�*�\\�Kz��J���N_��՝�k���w}n.��O��Ή���ٿ��Wg�\\�f*׎�:O��m�MtETp���\0\0���%Ŷ��>��V��-=\'�W�d�;30y~/0���-Ur��i���\"^w.۵��DG\\�� �)�k�+��{e�g/��=\r���+}�k��vo(����d{W�iT��3�]QO�}_��W���ܽg�5����2;v�V%-�����7��͖YW.�5�|&�5�S����!�$��%��B�>�nեY�2#��f�c��E���7Y��?(����γM֎VJ�>��K�\\O�k�K�h�1Jp]j���d��{�}��O\rMwg�Ui�ȥ����럇J}�����vU������WӲJ+�GسșRӌ0zSi��?��=\0I.H�`vf��\'���LU=�k>���k�����ߧ�֡���-��jZ}�(��#�S���E��ڱj�rmS�TD0j���Z�U7c֊�\0=4B�%��v\07W`�v\"�!M]R\0��D\0�\0��]7�eO���ZDT\\�[�[�VU�7_��o���|!H�wcj��B����ţDi�j�j��-+�#D��@�\r\nowb�0ߩֿx��Gd�a�Sm>�O⣲v\n:TpR\\�Kһ�_�6��R�BN��-�\\{���ݨ�(���=�X��j�Ք�R�=S�\\��W��O��z��z=}y2������=c�H���ɖ~�\0W�5	�E�e=���!�z�7�\0��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�v���ѥ�Ч�\rR���~���h����Xװ��t����W3��l��/{ĪT�M%���o�G�ng�g��ɭ��v5�Y��j��;�h�wDκ��6yc\r��X���ßX���~��M+6�T��A���fL;&e�/Go�є�)�[�����1����RK�\\���ZW���?�n5�\0ʭ4�Y}b6���b޽s���,�nt��Z6�|�{��#���,�풝�Z�r\\�{��.?	�V�q*t���er�*�Tsܙ��\0��\0���6�w/�[��}�e�`�r��\r���Z�o�Ϡ�Pt6��-��)�jb\";����wgZ�Y�\0K�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\Zzk}G������@�\Z7ĕ�5���t��XCVs��?��|!HΧ���τ\Z2������]�\Z�[�z*�*W��\09n�*�d��a�S�~������~�Z����S�a�を��Eҷ�q�o�M�Ȅ],�\\��\r��+�O�Q����羉�6*��еK��3����A4��Dh/Ѡ[��Wy�Ƚxm�,����j�<�	��Zm�,��*/�)��<���z-��vA��~o�*\0-\r�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0��3k�[e�7Y���Rt�;jJ��)7��i��^���vc��_�w�Td���e��T�;��ĩ�+W(E8Ԋ����v���fX��E\Zrf5���m�b��Drf5�c��;=Y{��=�lz��=َ{�~�5]�U�k|����j��c:)��S�Օ���s�K�ǫ+c�\0k�{�?�AMF�����/���Ō觻�N�VV�����������\0f9�%�d��Un�ɏ/�����XΊ{�T��d����lz�v?َ{�?�A]\n�y�ܟ�X��{�T��d��q�yG��z��?��缗�_R�����gWq������:=Y;�\\s�Q������c���cDQ(�/�:���8Ί{�T��d��1�yG�ǫ\'d/�1�y/� ƀ��ή���ŋ���9�Y �\\s�K���#d?k�{�~�u(>�c:��������G�d?k���~��c샳����k�5�x1�]��_Dw~�������~�_�L}������h�:�©������}���Gwꜞ���}�7�5�CՏ�/����� �Ȧ�}��uwxq}���/�d_i���~��cl��<q����d�eu]�}��uwx1}]ߪp��$ꡏ?�8~�G�+d���~+8� �\0���ή��/���M��/dϝ�`_�t�\0��0�?Y�V�1n�]K-~,��]cT�m2:;��/���l+���nJ��֌��\\�t_��=���8�%q��6����~�h�|��>g��3=��ay��7���c;z�^fd��[�?�����eZ�:���\'ٻ��\'��\\B́�9��y�ʎ9k�N�)R�K��[/*O���m�hэ,\Z��-]����������f�l^�*�z\'t��\\�\r��EZOD�����[qM��ɞ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�=6�.W�W?O�v�����\\��&js��\0�B�τ)צ����&��q,�v�o�f�p(�eBN�W2�]�0�[<�~�Z������N���>*;\'^��å�\"����\\{���z\\�A���ۏp�|R��ޅ�>�g���6+�-��+̠)�������U�\n��\Z%����XӮ�=9#`����0�ov�\0RF��z�_F��|�m��\0G��|�\0��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�qkB�J�ӫ	��i�(���mq��\0{�ƓX}�wX}M=l�ɿ[�[��/ůY��Żx�=��r]K\nT�_ޯ�Vk�����Ii���f�/���(��8�x��7�S�>��w�C����\n���qz��V�%J�*�IBi��87��Q�4�%ϴ��%r�h�E�tdh.��W{����X�-OR�\'�����j�@�W�-ԯ����U�u�e�\Z����W{���T��!!]t(���w��@��_iU.$h�uЪ}�7�h.*YǼj�H���\"��5]�CU�G���Z��h\\�U�\Z��	ӓ���&���-{T��dĤ6��Yf����@�\\W���N��ۥ�Ǽ��f��NG�1J7�uҔ*і�����|Q�=���l�k9�e��o�K�;J�^�����^=|>�]��7�vyr�żF�zy������v&-�<�zy���\0<^�6��v���ư�ZI\\[TM�����3��f�|�e���n��:Į�Sv����%P��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0F��_Q2���~$�KN�P򷺮~$��s������B��zm]�T\rWi]M6�Q��.O����4�\rQg�|��-��S�~�����þ������S�28).D �e�k�?�m�)7��H?���q�o�h6�~?4|%��}�pj�(:)�����	]�`��Q]Z �\n.[`�	s��~jr6���/�|���\n����*~�	��S/;-�����P�l�����P�\0���\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0I�b�iPo�5��s���2��^9oK[�ji\'{�5�Q.�%�B�ӝ9ʝH�3���d�i�]y`�N:GN}dq�	ђ�ou�G�J�6ӝ{5��sk�T��f�W������=p��4����;�:z�⅜�\"�˳�9��op�ʸv%iZ���niU���%��85]�VcN*\r�j���A��\Z	�SV���\\�h�Ӽ�\Z\Z�����F��]t*�i@�TT�j��W�5e5EHN���״���ܸ����Dh*\nj���B��Ҁ��+ω`#D�\Z2�_iU&����=\n�\"�F��QRº����гͳŁW{�{��I�^�\\$�_S\'�����m\'.P�X%]�?Yqo\'�����_�>Mq5�����=���6ѿR�\\*�J�!n�������h�^cs��s��Ȯ|��u�[��2�~��\'���lR2����T�a��+eGëF���8գRU(�j�;��&&5��\']�\0	\0\0\0\0\0\0\0\0\0\0\0\0\0\0���k�����\"N���7>��_u��H)7�3�gޟ_g�|��j��w��N�.��kZ\rt⫁j�i]uhxw��o��⣰u��}��\0S����i���AޖOM��i�F�Ⓣ� �K\'��k����A����>m6}蝱�a��F��o���iBR܀�6]�����z�\Z\'V`�g+���V�u����n=^�G��ㆻ�R �5¥_7cX����������DK����������k�3?/�����D���\0��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0-�7�㦝����6����kiT���?�~��Ђ���5��^�<x2m\'a��\0e�e<k����������`����$pR��l�ioqNtn)F�:�p�&��(�i���W�ʭb�m]?V�������5t��\Z�R�ӎ����y�މ�0�ҫy����/&����T��|���t0Vi�c��*r��o��n�~�P�׊~��En�Q��Tu}8�،�b|�yQ����Z�<���vO�̳9G��ͼc�u��S�N	���3V��j��JmpjpkO:5�۪�Ҩѫ��v�J��ÏG�5k���:�����\n���[�N�H�\\�OB�u]z��q\Z���\"����:�Jj��j�\Z\Z����ūV4}�+֏�����.��̯�\Z��N�y�4N�+�j��u���T\r{�ԃP�z������\0��T5E�t@\\<\\�o\r|Dhj��v�,C�پ+_z��.�r�P�I��[MwI�n2�Z�kOey��K�	���q��F��M�S��O�F͔ZՅj1�NJQ��Mu�Ļ�8����uq�wg2����U;�����r�\r�v\0\0\0\0\0\0\0\0\0\0\0\0\0\0��7x`Y[�w?IO�%�M���ʫ����@�=ϣ���τ(�����^S�MY]Q�ѩT�2�\'S�i]tE\n7�\r[F��\0x[}����}O���>*;Y��:|pQ�s���v��m�)8��[ �Kg�׮�\r��4I�����gމ�6\Z��P��*�ER�׀\\\n�F���U=;�S�粴��o(XZ�u+�T�*p\\�)=\Zt\Zΐ�}r�r\r�`�\r�b��0ms�In���s^C?�M8#���o�rf�-�Q��aJm-7�i��哓��?�ᨵ<b7�y����(���p\0f2@\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0q�惄_8�Tn�u�C�y�ซo�쮛�\Z����&\"wI1��y���l��q��I9s�ʚ����b�\'�����g���A�6-O\Zc�Sb��;�ᾁ�\"�\0�}�~@�lGd����o{�ۂ<ZϩЏ��Gt<Rض�#� `��E�c{+_��X����}H��^�wC�}vY���G�we�а_z�� x��R;���X����X��l���X����Gt׫���Aݖ{B�}���g�,ޱ=�/gԎ�<�V;�㾃�,�����#�;��hX/�b{<^ϩ�x^�wC�}vY���J��[���O`���#�kՎ�x�\0���}�`���G�ݖ>y��Ob���#�kՎ�xߠ����`����\r��\r�h����Gt׫��A͖{B�����g�,��=�/gԎ�<�V;�㾃�,���{�#�9��hx7���@�{>�wA�-z����g�<��}6Y���=�/gԎ�<�V;�㾃�,���{����=����G����������t<r���S�d<>�K#�R�N�8ңA%��I��t[��}�n�?D\0��\0\0\0\0\0\0\0\0\0\0\0\0\0\0��7��e_u��H��K~�P��~$���=���>�g��Wg�z�Ө��\Z��qT�K��]����9��F��iw��_��⣰up���پ���Q�:�<!�#���A���]��p��VNI�A���]��p��Vhv����GͦϽ�>l05]�E+SP�,\rt	]�}l�=6w<ѝ^i��o\r�t���	ܿa�Z��;L=��S4cvy��{�ꪕ(Eso��$�m�#a�.Ș~β}�X��e*1߸��\Z�����rF�\"�N*�]����h��.\nq�-Q������U&�8.����\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0��c���O�h�����\n�خ)�[F���ƽ{z�V� ��8�i/)cӣ:�),��~V��abq�p�w�����0�)��:k�t�i�F��������+��_�.�9�^+_��~S�XN��a�{����Z�Қ������\0��\'�*��=\\���n	�J�)Z�t�t�^�����&��j�]����pO�U�G��<{M�?)W�[�t�t�^�����&���\0�7��\\���f	�J�)Gӛ;�d��~Q�\'L�I���h�!��]�����pO�U�J�����\0��\'�*���xN����_�)��\Z�z�3����~Q����0?�U�G��3�\'��>��Jgꆨ��<��3��_�z�3�^L�?)W�#�xN���w�Ot�~����!���;�L�?)W���Ǟ���~=o�\\���t���_�)��ѽ����Ǵ���~�OWx����=o�\'˘>��y{�{�3��i]Wi�\\y��n���h��ŝ����~=_��.`�g�S���Jg�QMWj!������`��W����<{N��\0��.��g�O/`}ot�v��\rWj!���<{N��\0��Wx����=o�]���t�]�z��L��چ��!�����,���e[��}[��]VQ���߶G�p}3�y{�Ot����j�HZ�n�_[�2�_s_���G��yR����H�BU���Ǘp}3�y{�Ot�f�{~�|H��������]u-q?�(X��k���1�B����\rVI-/hz��PrK�dZ�pwgH�;w|Y�\\��r;w|Y�/��c����Z�d�߷������J5��S>*��X��&&5���\0\0\0\0\0\0\0\0\0\0F^�P����~$��r%�N~ae_u��H>?�}:�τ(�����W�WVP\Zv��\0WVP�D����a���\0������˸[��\0���uZ?:}<!l�g���l>�������\0�D�q�l\Z����Vh���#�Gͦ���>l2�iR��yJ&�J��T�ש\n6��R��Aj��$������-hεj�P�8E�S��\\�0z<�v��#G9�[zu1��~��KUh��K��������.�r(��<����nc�rh��=�ѻb �k3�X��b}l&�������O��c9B.-껄 ��z��������_p�z0��վ\0��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0��ގ;�ӊ5����Wg{FŲ���vγ��zh�Bm�:x��!�.z�����w�K6`����NP����~�=�>�yWY��0���ʧ�;��6y��^�Dy�������_�iB�T�|��?�T��wZu��Q	\\�`���h����]Q\Z \0\ruew�ah!.M⺣���Dhj�\rw�)��\\�F��ծ\ZjWQ�i��4W�yA�aN=`�R��Q5�8>A�EK\n�24N��z��+�d\Z���Wy���_&9-<ź���>��sW��#�q��:⟱�mZP~\'���B��n;�J��а��T4Qw��T�%�(-#\'�Ќ鎽L�62�u�V��^��N���:9��7�[H�;BÖ#�1��IxJ{۵h��8>1=,%��5m�s.;��:x�]��,.�=UJ2�U��&��/�\'ҫ\r͒��3��a���n�P��Rz�	?3��ZpݼD��ڽ��[2���*b��6�t�0Ӗ�8�T����E���\0�\0\0\0\0\0�Ӌ�U�]�ā	uӋ�U�]�ā�@�=:�τ(���쏂�[�	�P�/�+��,�#D��:�uh�o�Ɔ��嵻�p��YP_�G�:�]o�Z[���\np�E#�uZ#JbB8-��_��bt���\\{��ⓚ��O����mj�q���qe+J�3R�)�M.<d���is�U���6�fu��Nwj��^M���c�/��z\\���״,V8NVª]M5�j�Ek�r�;�$NC�kkm:W�C�cu%�v6:�~)T|_�%�$v]��{,at𜿄а��ʝ����[�f���n�U��c�����4�<����b<�����c]r�����T�LzQK�S���.�J/��s��4�^�M�T�\"�߇�Z�Q�F��ٱoD[�\ZD\0��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0N�*�Jt�%5��Z�����+l�1T�Y~��.��\\���i]�eM�\0%�->�j��.a9���1��X�St�Ғ�{�景���;�;��]�7�~������=8)��\\��i�M�����g��(��S8j�f<����1�Ө�I���⺮���.�\r��:���+i̴�������euDh�\0B\r_k.��-\0r)&T�.��F��~���O��H�=W24O]82�˸j�A\0\ni��]A\Z/�oB��y�|��:��>��Wi\Z\Z�uәn�P�w�T�⺹�$�Gޓ�x�d��^J�&���3�s�|�*>�w�^.S�zw�֣R3�R*Q�^�I��j�{BKt_���{�M�g;����T�˺���&�R�`�-y>�,�Nm4�a���i�Jѓ�|D�柔�H(��RM�ʖŴ\0\0\0\0\0�q?�T�]�ā���yӓ�T�e�āJy���|!C�=:�τ/�uf�F�p���L��U>ӹ��z{��\\]��:Z}Ԓ�gH��!�%��C+Y(�\'�P�$�8�jr�\"ϫTr�ze�f�]�h�l�-]�J\'�O�:��(ҒѭP܂㺊�)��U$� \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�Z��O������k��(����r�*�4�\Z�k����kU��U1Ti(���I��s�՘vgs[\Z�ԫbynOz5#궫�j%Ծ�p宝xD�Ekh\\S�\Z���5��(���\Z#��:���V�9���pLN�s��Oҵe���\0�wⷍɦ&k����*��γw	��O���}�獝^;<ݗ�l���N���\Z�s5����e=M\rtUD�j�%U��v��W\ZOD�W{��>t|�0�T�hբ4N��E.Һ������������Bº�&���*��#@*�e<�����w�e�!˪�B�L�Z�4�q\\�Tʩ&F��oH����^:�ЁP�����7�B�.���-M2�h��n/y6���STS^\" �::+�~Y�.O,��Jx��K�\\[��������1�eɚ�ٞw���v�3U�I\'kU+�\'­p�����]��\'�Ŭm�K\Z���Q�Jk���h�������W���s/�:qv9ϝN�lsK�\07M�\0\0\00�����=�s� D\"^t������~$��(yߧW���=�꽑�\\\nj����|\0\0�U�����V�m��_JT�j�\r��M(G�3\n�	�з(��,���R�n���]:\\d׎oO�6YM����9�sg�����#�7�~�5�S\\��(��hT�.�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0N�g��E����b�u0�N΍ݭe�R�zj�$�ԵF�vK��;�:�����[*�K�Ij��C8\r�{W�K�ļ/�l�cK���P�0�\Z���el��ǜi^ӝy⤾c�_��ܰ�\'�N��^��w�f��JQ��lC�C�x8뮚\Z��\\5|5�d�Z��;���bi�O�V�.�+����ͳ\nӛ���/<SG̫���A�[&cp}�����6����㮺���\\�1\'e��\\�sU�$��*���Χ�>rs��\05qoy��\r��G�x8��ϟ S��wꏺֿy=�X�\"gy?[�q�x�j��ʶ}���d�m��j|��\\\"��+���~�_���6^��\'�\Z�[;��J�=�S�+�:��ұ�xU�\r�n��\'������k���\r[���\0��s�>A�9���s�>Ci��nǰ�������ص����Y��^9�\n� �g�ix�*|��4CD>����q�b��\'�\Z�[;�����=�S�+�<Ͼ���xT�\r�h��w�����k���\r\\�3ﴼs�>A�;Ͼ��x��\r�n��cDG��=q�b��\'�\Z����ix߼j|�^��������S�6����C������k���\r]-���i�߼*���w�}�c~��E܏ڡ��C������ů�OsWC�����o�5~B�C���3��O���~�\r���#����?vm��{��{>Ϗ�����S�g���x߼j|���c�7c�>�����Gݛ���~����^7�\Z�!O��|_�f9�\n�!�=��\r��>�����Oݛ���>����f9�\n�!_��z���{Ƨ�mD7#��}ݣ������ͯ�OsW�C��ד�:�\0�j|�����c�[)���wiu�U�e�sFT�(E�A�%�vIy���u�#�Ff)�\r�	Mz�Ӄ?/�)��M�+��4T\0n�\0\0\0`�ϧ���\0��~$�ּ�/�t}@ʏ����@������m}�P��N���ue����jZuW\\���\"����0�]�����	�Su.��B�(��4�6[����L�NW�IRí�KT����O�ɷ�#D\r�Թ���r�J4���K�T~ί�p]��\"]�ZA\"�`�չ�\\o����]66-M�������\\�°\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\"�\0N��_ʾ���!��&N��*����@��2��zm}�Ps�\0N�����{��h��W�d-����i�IN�j�S���S�X���%�Ϩ��0نcڦb��`T\\i&�ww$�-�������lg;?�vk�h��4�V����U�)����|�,�]|���G����eUX��-��#���}�	�0\\&�	­iг��\ZTi�)(�-���)$�K@�1Ɛ�DDF�\0	\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0{�_���=�s� C�e�L�o�A��7s���#O��uϗ��ʙr��M�걦�\Zk�u��񲑜QUxꢘ�w|!D���aU4F�����u2��6���yN�a�\Z��q\n��Irq���_3�����L���H���\\�$�(����\'.s��_���xu�B����+{zQ�F�a�$�����uW1^#tts��32������������9g�sf�%-XB�\nkZ���i��r���vi��\0�(��1M1�B�Eۦ)�4�\0��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�qܩ�s3�x�i~�d�E\\R�E�����g�Ya�񵱷�oJ#\nPP��$�;@���ʈގLk���x5���% \0�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0T\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�D�� T\0H\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0��5]�T\rS�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0���Q�1�˂�bX�!F���RZ7ܗ6���]�-S5�:Ds�&��5��s�zjq׼���;����҂�S�5�w�ȏYӤ���J��/Tijһ�Z�]�%���bs4f,�Y��q���7�U*7�%�E;0�l\Zf�<M����}ݭM��չ�ߝ>�Ŷϳ\\\"R�_4�V����u����\\t���6�F8�m5n�~ycA�Y��9�s��4�ɟ�]^u~D%>��Rҥ�)M>�n�����m�f7�FX����(N+ΓK�D=��ͽ�̩�:)���J)�q�\"{�\n�x;K�`�ŝ�7o^54���Cy%���@{{��:Ѹ���B���9��x�2W۶|ˮ4�o��[.��i�5�ϩ��m݋����=q�;��Y�s�*�v�=���I>ELu�vٔ��嬪�;����=7��%�^.}�C�����cn.�늣�����Z�E�yTN��\0e=�R�Ө��}\'����B���:Ѹu!N��鹦�><٭ͳ��b��W\'M�8�G�኿�֦�ƺ3}�5�ؽ/qKKw���a��О{���L���K��� �ս[վ-���R�^�]��b;j��CI9�\\�{�}m!7����F���=d���KňR� �C�6��f��G�+�!:#���̸ְT�W��\0h�fl��c�w����ӳA�y�}w��4�^\\��������TzS�ld�� �\0Yۅ�\n�ߧV�j�h��$r���ZMU���Fk������F���v?��\0��3Κ=�\0�{��KW���kUȆXֶ���k��k�\\�\\����7��;��	����s$!�bj0���ϱ7�_s���o�ݮ�fE��������ѝ��l_�L^��z8�S�יyi�ղ\0�9��e��4�rI.�ȥX�� �\'�_�]U�����ߗ\Z�e>��W3��28��>_+^}8i�=,v;Ģ<�uN:��k��\Z���ˈG�S;�OJ����b���9�ЫU��g�؏柤5��U�G��M�m C�gl�#E�\0X�{J���\0=�O%�7��M�����Y��_>\\��Bl=�l���/�i��V�6z�\0�\\ߴ�Rh4#��+�T��.\\�a7#�m�˖w����h�}���s9`r׳��\0�A�\Zu#�6��f��O�.z���vT���������7�c�K�k�(bv�5�J����\rJv���X���Q�O=�\0�?H>)��.\\LIѮR�@���ݿ����mrE�.����N�r�]8��|=�ni��\0Q��k�R�J<Ζ+�a�%�\\G��kmEk:�%�W����zI�׭R�#�*4��};qe>�Ò���F�3�pyU�E[�F��ϟ6#k\Zܞ�t������+�˪V������B+��?�V��ʝ\\�m^q�e*�S_	��Ŏ�+�s���W�o_��m/伇�Ӽ�b���Θ[Q�V�\0ti��wW�t��]N�7�-����U��\"�#�mZJ3��Q׮����t�\Z\Z������߫��8�y��?	���q�F��l��Ir�ĝ�g�4՞��zU`�S��d�R��t>�^ι�+T��<n��1z�-��o����6��t�Z�:i�OՑk;��i�N\r��Yrz�{L��F�_U��gkh�ԛQ��$�ˏ8�֫�f�k�k����\n�jEJ!$�$��E�.�p���	��^��lP�X����ʷ.p�{�\0\0oD�`,ua\r�s8�)�L-⹫�cG�#\'�J��\\dȳ�>����[���z�7�)N�k�G���f+0����w�G32��c�Z��G¾�0�.�w���Jֳ�^�a��ވǘ�I=�`R�:����~�����(\'��y�7f|�r��&={��oU��9(���y�4]\\\rݡ�3��\"=�����g�\n\"=����鑱�rq���rp�I|3�26?Q�W��.��ů�d���^��w0���5�ww��v�sb���g:V�%�7t*R�\\w~ a9�\0�����Y�4��J�<[5c�hv��W��cy��76U���Kz��%�Lȵ�7b��\'ٻ�ʵ��c��\"}����o���+)�b�D\n��,v��eN����,�t�֕t�U�Ԕ{0����S������U��ay5���\\�����.k��O&\'I���aq�ɦ�*��FS\Z��SQ��6�\0�\0�UTd֜����T����C�g��䝝Y;�׌R��kN�^�j�s���>t��؜���,�j��nnR�q%ۧ�������p�M�տ�8�1����[�#|�\0^�˩qF�\\��0�V�Ri%�g��6ǲ�n�+��JU#���&�q�m\Z�̙�\0:�����s>#��+�qx��j��in��\0�G|�v�u���|����un���\'��ɯ�����g=�I=�^�B����ѭIy��t��2����\'է��cF�bu�E>�\0�hxzə�\'��N�6�ݵ��RK��^T}��_��%:�(�5iT�\'��^�3!d��T�r�,3E�ݴ?ɯ_��]����3.���3��4돧�ͱ��L�z�:�{cQ���j\\G}�t��y��,\';ڬ�������G�.tߏU�g�k��a^�q�J�T�RR���Mu�>*�*�U��X�ػ8�9vj�?�gd��Z�2Y\0\0\0\0k���E\'UBJ-s���{Y�C�6}:�V�;�GX�f�\Z�eN���Wۡ�o\rO.����Xj<%ڴ�l���<�e��r�IP����eB5�-U�5��S>m�i���HbX�[K9ꕝ�t�����/+1�nM�OV�������u�{g���X���\'L=\Z����O+������R�O��d���Ч�;d�ߵ�c�g�bh��縹�ww5Ӵ�ٝ�߫`8GJ��T�fj���znҤW��I/+2>�2�j���Z�8~)Msv����Qz�)�}_=N{B�\0���{^���5h�p��5����7���\'ٻ�ɳ�����h����VգZz\'���;g�,v���Ѷ�3�a��Ҕ.%�YG_���?\Zd�پ��6�,�W/��1ֵ�Ɛ�M���%�W���3L>/ͦt����6�c��\'J�\'�ރ��W7����r&�\0F�So�:wx�a-��N��Zk�Zч�,�Oؿ�_-6�t��g�0�Nׄ��~�������8��MK��d?�y����1*1��#��m�dV��]�eק�b��[5�\r��j#ޮN�]��n;���#b�x�hXc��7���ά�Ll6�?��-���\Z���5�<�hq<������i�<�S���#�;��m��kp�=3�k�c�*[D�c�]Yʚ��$�p���C�禟ԍ��s�O�����N>�p<߂��(�_Ҫߒ2g�Ua%�z��T<u�=\Z�=6^�n�2��<7▱�*j�R���m|M������|YV��8]��?�ųuZ���^��HY��hf�*�;|�P��uJu���^+�Oc/��Yk+iV\n�*Ɐ8�x[j�B���7�Q���8|^�\'D�op����[�\'t�\0^Ǳ���p�����\0H\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�ij���l�J��/��nj]�~҇]J�s��W6�S�����U볥4Ƴ/��)�L�T���3jXFϬ�ݹīE�{X�F�\0�.�|�U�9��x��,z�U��ܦ�S��#�t�g�8��3�\\J��̷�9?2]�u#�q��h/��&��M��9韇2���׋�H�OG�M\n�WZ��y$��@T\rʋ����L1�@��	8��M=4fh�6�o0����u+��(�O�J�M�{��5�0���]�b2��{V����0���na���)�o^��(W�R5)Ԋ�\'�e�M>�r��j�e��{��%)�ӛ��K_�x�$[q՝�)����Zq�c�y���\\0��qV��*��O��s�nW�$:S�u��\0�kv��\"���\0����W��\0YO\0\0\0\0\0\0\ni�R����#�J������r�J�P�����No�>��ˉ\"c=t���R�i��i��%�����XVx�E,G\nq�Y�u!����E��]�L����D��\"u��3����Ա�8�������d��[ճ�/��s�����ڣ��s M�w/�s����/�Z���\'\0���\0\0\0\0\0\0\0O�f���k������;юZ��������Ď糓�Wc�F��>G�̙��=�5��T����\\�TR�l���/�E]�����1�.�W���3p���Zܥ\'ڗ%�\0�ϳjr|$��T�:��cqQ�����y��m#\Z�+:�St,)ɫkHK��=��iv��y \'����ݛת֩�*m˕]�k�u�\0����ÉTJU\0�42N����1\nxV)ZU�Z�ݔ$�v����ڌnSC3�����N�G���=lޮ�q]�=�o)^R�qo8ԥZ*p�^�Q|�;�ۜ���V���_	�v���K��_Fh;�Y��2�щ����y�t�^�E���\0�{����[s��l�ڦ��8�c�Yo���ה��G�;!6�o�|��0�ƶ?��P���j�~ʴ�b�]o���bw��!q�bwu.n�J�j�z�ro�4�k8o�lϝ�=����)�����=����~cθ�\\o3b�������?[�ǔR�H��*����T�*=UU\\�UN�\0�\0����)��.tj���5�-E�y\0@]J�Z!Z�IS��E���Mr-)=�N��v5����=1k6�������U���\\�^�R��:��ZU!:up�^�I�i���%�D�\\bԞ�q�R�Λ��T��r�eKW�w��שl�4�j�=�ע~_E�#�뮨�ߝz\'�?$�\0���R�^%�mR�GZpZ�H񷞔699�eL�*W������G��s����q����l�o,����q��z^]A�/��d��.=d/��9:������oV�k}o���ٴڙ�bw��GTu��u6&p�y�磪:��w\Z�1�ňUű�J���Z�ܤ�E܎�Zffu�6fj�j�\0@\0\0\0���{���_{K��S��$�[IɹQ_oI�O����b@zٽ^����/l>\"���jt��2�k��~m�r��;���Npz���%����>�[k�s5���\0l��,̱���9��J�c{G���*�]���x��;+�7��n�µ*�U)Ԅ�����&���^2�}8�z�8áe��9��W\n��\\��\0�8/.��Н��XS�J.u\'9n�1\\[o��$�Wi�S��3y_f�R�v��[���9~�Q��\\��>ת�0��0V��]��,<v6��ݯ�:e���J+��R�(��i��ۍK����;���)I�JM��m�e�G��|���������.K�b�q�&���G�\0�`\0\0\0\0�a��#��Qİ��֗T$�N���-uꎨ&&bu�&bu�����r�9;|��%J�iS���\Zw�.	�Q�w\'�H�r���Iq�j��9ƥ)��XI=\Z}��o�.ݫ��5e�y������Y�+�K���.\Z��KVS��ً�4��O_�s�s��1��O��==S����0YJNPվ��Ƴ�/b�D\r邷v�s�^m�Y<�&@�k��V}�u�����=��hv�лa�\05C\0\0\0\0\0\0�����X�(cX#Z���JT�R��]ϵw3�bf\'XM5M3F�On��}�ڥ��qeJ�1�CZ��\\�pu)�κ�q��zi�ծX̸�OǬ�&p����U!.������l�g9��P�sn\Z��EJ�=ut����RM|%�(�\'G��>t{�|�39��6�ϟO�:~�N\07m�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0`q\\V�F�Jժ����RoE���m�,�[=f���9zJݺ6po�������3�H�S/䊘}�]˜^~�M>*�9�*��dS]��i���]8\n\'to���>�Ws�L�ň�ʠ��\n���[6�9��s�P����u[X҇���r�}M��ξ�q�T�ߧ��8�����|U8���Լd���ʖ��B�ڄTiӦ��Qq�ݗ�4���žm8���/�g��~,Y�z7�.�*c����\Z\'-_���tW�l�fC��TT,��M%��ǌ���z\0t�.Q��F�-S��|�X�alٍ(�\Z�.\r8�9�6r��v�k�W1� �:sW8\rj�=+Z��M?\':=�2/`���yh�����v��\ZU(������#���,%q�я�).���ˇ����F5�*Ui��kIFI4�g>mk`�hT���5��)k:�|8�>�O�\'��s������p�<���t�W���M�,p��0QG�}#\0�1�F8F�ֹ�����<c�M_b�d���G�3t�l������Z.4)��}�]��eg*�1y�zX�͎5O��T5�l�T�Dn�c�l�8�<V����l�kB�okE����\\y���]丧���|z�hQ�\nj�((B<#�I�\\�2[Y-��n������9����gY�!:S��|W_�� ��ҟ�e����k���\0���z-]�`@�T�ϻ\'��K�y*�1c�.��]J��yB:F���K�LɃ��nl�_ɸ~{����v�7U�\"��&t��~���E�/^��5�>p���.��/�S��U���.����T�O�_lk�~�!��y/�OG���c�K�w0�1ѣ%���ɾ�0�=�\\��>�./�a���<Ӑu����;]#yA=կ%5�/��&9��,-�K*�}�ַ���ԧ%��Z�j3���v���ȯ�c�lpbb2�i�Drg�聈��s�[yK6�yV�kY�m�t䔢����Ub�V��L�O�J�*�j��v��mʌ��C�Ң��^��Iy�|v0��f#k�PmT��\n�Ӷ2M~c���&��fb~��&��k�iO(6���R�N[єSO���^�d�? M���|��\'�Oc/�d\n���[���:����\0ՠ�xQ��q\0n�=^˲��s��b���n<#��\'�`�5�$:<lӎ�y���f��K�m:�Z~�oq?�6�Y-#�����f���\"�5O*x�N�!c�pؚ֮�S:�{�=6b�ԋ�㻩�.��2_�-o}T�L�ld�l�G��i<<~�wC-���<�����)ȶ��/�{y��A�d�|�G���>)cԎ�x�ݚ\'��G�V)�����_����݃�2��G���>+cԎ�|l��p,�iR�\0����Z����r�-x�$}��EA�n�i�-Ƒ���M1LiO��x���Tű��u��Z�Ey�!\rZ�+Օj�r�I9I�m�-���mp�=�cʏ5F�zv*�o�ԇ�1�˵N*ծh�^ٙ��+��S�)��@\0P�7���c�ݾ�SR�]�]/c�r}Ȓy_��H��Ӗ+Fx��Z�u��={��%������VO�J�j���l�5��m������K��a^޴*R�(Nތ��4�4t���0�_�UȞ�H���Ұ�8k(��j�>5�K�Vt���F>���|Kg�\'���e|:kNq���t=&���}��y3Di��mQ1��܏{P��\0a��U�Ku�+e�+X�[�P\\�6������>��T[���������q뚗����V[ӕ�]��n씢����c�f���DS�O��ӃO��|%\\�\ZGR%�I�軕�����V�/ԋWE����ˉ?��������\rw�1]��}/jZ��/YumV��n�U�X�$�//d�z�`��1��#(�5�7=r��KS&f2�NY����yS<u�:7�u��k<��u��q�?.�W��)r�ZXP��i��E6��8w�M�.l�=4s���u�Q���W\Z��W���)���ɯ1��b#b�����{cq1��U���Em�g�OiY��\04�NQ��ڡE�U\Z+�!ݢ�ߩ�ʾ\r��=���U5�:̹�˕]�k�u�� �ӏ���b�[Z�r�|�G\0�%�ԏQ�k��R�vl�~��n5�}a�\\�\\�V�Y��نĳ��.�,��	���.S�v���o�|�O�z l�/ѧW��?w��p�&����^6�ق��v�Q�p�\n6v��T�Q���+��McLM��U�ù{�dXl-15�*����/�l� ��3&��\\դ$��j}J�g.V�*ur�R:?[+Jmy�>�6�j�cH�n\"�Ƒ�Yˣ��s�\n�-S�����E��k�4D��tx��+�<B���)z��P�T����_z�~e����Y���,���P��*R�(�/�i�5�̦�*��ɫ�>mf;\'�c)�ܚ�c���G>�I-��Y����3V�,���֭|:\Zʥ�[t���q�F�9\'6g,G�VZ�o1����M�Ï9�Q�	{s�W����.\'����5ӿ�M�����o�3.{�sNX��p��R/q�=eJ+�ܣ�t\\4|L���ԭ�P�6�w�\'6�Ko�d�⎞2NaX=�\reG¬hY��J0�F��\"�\\��_�ܪ��tG7?��or̂��M�O����~ޏ����k��Q�v��-��lC4�ܩ^�7-(���yp��k��&{�\Z������fD���E]�E>\Z�����q�#}��|SUqǄ{ec��~%���q����G|g�q�V�\ZŮ�qy{VU�U��)7����9p\\��A���e�&f��x�a	ԜiӃ��ҌRն��D�i%�|��ɡ�ã��X������5�*�����l����\Zӟ/9�������Q�=�s0�����z�f3�t�,S4������O~�Ei�/3$6Z诱���\\Z�x���\\��ܭ��q����-�l�\r��ì�����a0�=3��6�ɶkF\n�E�c�� ���ld��\'J�\"��ׇ��Jk��dPfN\Z�Q���Μ5��I�4�B+m�fZ�[�cUhW�����ާ>��\\c�Oƈ��2�aɘ�L3a��n���H����z6�x-��/�O.��1�X��\\�/V���S���]f��Z�^u]��h�\r��z��\r��9����>�r�X�F̷�[�t��g��\'�3��Mi�˩�J�T�4���������I���֤��{����Y�Ș�̧u��	j�-[�o���i��{εr�0<uTݷ�µ�]N�_[&�t�Iw��v&p��k��>��{a�������Ӻ}����\"�E&ڎ��FI�=u�.\"kX5�_�%��GmUl�!�Xud��_[[�\ZkO_W�c��M\Z�\0�Rug*�f�9��Ro�o��e����y�j7�tk9Y`��	>����e�����ع��&#�Ӻ>n{��\'��b|�wG�{����1�s�X���k�ꛑ�y�R}QI6�g��SL�1Lq���j�����e���w�X�,/a���+KHR�ߗ�%��%vyк�z4����T���3�4r_wU��~3<l�dwe<?\n��\\B�R���S�^}|~�+�+�󷐋^#�DEx����U�/��V���^u]���1���dc|�iq(��.��I�3>��Y������.�첆�����Ӆ�DiM�\r�8k4F���Q�:4l0R�*eZv5d��l�*RO���L�y�2�*��B��5ie+:�Q�������s&�1�^\ZM:OLnbb��&*4������͵͝z��t\'F�)8T�8��2\\�O�8���C`��	��b���9T�\niGӴ����\0-%���d�e	8N.2�Ѧ����n\n��E\\9��F�r��}�E[�xOO����b�r�=c��K�P���F�9\'��s��Mj��M�0q3L�\Zj�f*��6u���g웆�>QP���R���:����z���\n�㣈�;���.!�B�>��HԊ�ũ~%�}��/�x������K˱~;���??�8��2����U�l���;��_��1[b�~m�c?�X��ͯ�?B�\0��N<\'����[]\\[╥Z�&�\0�d�n)�$A�\Z��mKz��{���Ȱ��W�i��N=�.�a��&熦*�N=�K�����ݼ��_U�8�z$�b�\rR�/�ɮ��MW����/\'�wд�;	��\n��E��З	�oR�I�WV�Q[ѷ��jR��ߎ�>=��#6u�y�g���LׅԳ�Kz�S����I@1�ݶma���{�Ե��JR������X��O�\\S\\���~Kj�&��Q��-Na�عnk�G&��方�Y�T�*sZJ\rŭ:�B�������qrx�F���a���׻SO�?)��{�	��o�ҿu����:r������ޛ�*�ӿsc�^��uG<�߹�����e%��u���� \0�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0:K�2��v�4g�0�H�$�N�m�\n>s��l��6��֜�t��S���Opl���s�\'֘��=Ф�k���\n(�MF+W.���M�1L���#�N���5�R:�\Z��6���m�������zR�fyJ�Qɸ~(֕%Z�飕Y�寋���r)b�����(�Z�͸�LDGb�n��LQO\0��\0\0(�*\0�Z�}��{�Kj5���^�:j2��d���NڋOW�p>i��cJa\0����*=�\\�\0y���Gޕ�./u�+{[�w��\r~i��|a�\0S�}��ج76]�.������!�&~�a��i���key���l�ܟ�|��?����\0Qeg�VOE�׽�����yuV4�Ћ�Rrz(�-[~C橊cY\'r+��_D��OM�kC�~Mfz\r�fE�s�)���s[JZ�T�c�$y�����^��ULǳU\\\\�]T𙐣⊝�*Ʀ)��ᴖ���N�|r�K�4S5��xDk:Bs`�K	�S�Jڞ�=թ�,��*Z(��/?EQ�b��\Z-��L�7��}�_�����D	��w_����{��_��9�\n;~N ���خg�r�s����}+kJ��S��~�N:-\"�� )��e_�ZO�����Xвe[O��,x��i��g|N���\r�2������^�TÎܶW.Y���ڲ��9c���˖n�^:UW�Ho���F�c����W�\0�+�w�X��S1m�fR�l|�������e�9�Z�~r�4>�o1�����S廾�{�V;S�Ԗ�:a[�/��Cae�ZS�î���֎�:�����2�L��T��0�g�BP�Z�_��l���αY�DS�:�צ#����\Z�&��#H��ɶ|�ǃ��������(?Z��9�X\\�w�u�7\n��%Nq|�M������`�.�Z���A�{��\n0\\x.V���R���Ux��ƵQ��������o[��q���@��NR��ּ���(m38d��X>\'\'j��ַ��ߢ~��y`{X����,�4���E��O*��R+-����(����kZ��Hx�^�ͩ�0-�d���l�e^R�\0)�:��	�/����E�FM5�i�Bق�l~\"���t���skg9�F��\'�)��FKX�Wp�Z�B\\hy�/���̷��P�M�~,�FD��&�5��O1a��%�t[�W���E�	��ۯD�=����lmg6+�\\L_�2L\'���e��|�([Q�v7r�^i�t�?9�D֩�62�2�	��*�����.�*�����ʜ GK\\�<wl7�|g�ڍ��7�|$��Z�?>\'��CY�X��\'���}7��Ůt��Q���$W���Ŋh�y�+�Mri�SDs��Q�\0!XFS�aܤ�Isl�&�r\r���\0�#B0��1�y$�ʼֲ����@͍���2�^\nt��tgR\rj�K~I�5��SZ>�Ò,�=b&k�>������ƕߞ<#�?\' \0�-�\0\0\0*FR�M<�V���U���7R�����\'��\\Y�i)�Ro]\n�H����n���捤f<rsrW8�]��N/r��y\r��w������j��Ql՝�Ow^�z�Փ�[�egh��-��Wj.LQn�L��ˀ\0U��e賳�|�zw�����(��%c:��./�^:$�꜔��á>\n��R�{�x\r�F�8�Y�L��\"�*�{��Xzl`�������\0n܀\0���Z.\0F�?�w�Xm\nւW6#gu(�2�6��K����VڰJx��3VR*NXej�֟�)��G�PF�tӁL�lE�LW��h��k)�����t*85(��>��Z\r\"�ٞ�q�fM�e�jozWX}NZ�R�V��Θ�2�Q�s���XֹI��0m/+�yLs�j�W���)k�]z	wF�Gc��%;\r����������L��~c��:��2�D����u�j����k���w5J��*�&��M���a���e�7��++\\���x�{��m9.0����Iq�H��6֜�Hٮ�0ZXβ�F;��o�����o2w5��ǾV-����Dݫ�c�?ԽJ䊀\\��\0\0\0%�_���J�G$�6浍N�\Z����+E��D�	7�6/b�D_���ӫ���`P[���l�$������\0�~sO�ً�Y����.b/`������@\0�?{M�f\Z�[js��c�tg��XM�Iy�͕��/�k+�Y���A��5cQx��F������l�w����n�L���s4ܣ�?�r��5�r�D���\0ô�?�c���\0��<���2	t�_݁>�*��32��E폛3h��0\0S%�6��޸\Z�l��Dj�Mxr6��޹w}�T�\0\Z,�9��v|ֽ��w�~o�\0-+xq�M��9��b�Xs��u�J�Ό�՜��1�z�3\Z�3�k-mm_���34ᖩ*1k�I.J�q^D����1��ٌ�9�\'^�N�9�%�OC�����3O\r\\��T�v���3:w�����\r���Mz������?��ƙ#��<cmZ�bڡv���(Jz����&��Dt�����j�[�=h��+M�k�/,�שy��Ԁ \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0`B]��P�cR��)r���k�h�ۆ�ݧ�1��\\N��n�8��-��<)��\03�6��h�j��ʍ��i�\\OL�����,��^���1;m�����	��V��zwޓ�58�ƞ�����7i��1=��W\"���>c�>NYƩf�hIJ����\\W�S��mܦ�]<\'z�MQTk\0\0�H\0\0\0\0\0\0\0\0G�+Ie����d�#�J�e��\0޿啽��\0��?�i��|a��S�|�+����\0�xF�_\\�W���B���q�K��k�ԍM\'�h�\r�S�_��M�<D�Ɠ���+��	T�G?Jc��N̮�Ͷ��*C����&�)GzY���GzO�D5�v!�,q���?����l<�{ՏzU�=\"�{���B��%QqJ���g��0��6͘��7�ӏ��/]�oJZ��rߗ_��n�>�\ra��v�0̨�U��<b��_o��q��Drft��$�\"�ֽC l+\0�=�L>r��=�ʏN���\0I�1�!Ԝiӄ�)�#�[d��n�*d����N���)�J��a�4�}o���X�c,�0��:y�LU3����l2�<߿����T��f�k U����\0|��\'��?�~W��;9�����\0��{ߓ�\0suxc	ͨӄ�\'Ԗ���Ik>��2���*��&\"g����1(�+��%��7gyekYx���uGO&\\`�Ю�ѩ���w�^��+��F\r�ə�92�d��B��f�������L����d��3\0�ݜ���St��v�IhL����o��\'�\n�禛�K�K��~R�\0��+�bk��L�<�5��31?&�%�]7*�1�i��\0��\rj�8�R���8�E�i�V� i>dLj0.�:>F��lo\"Ɲ*�nul$�a)>-�c�/��������s��lkZ�SzN�X8�y��znǱ/�2P��9��^A.�r��\\א�f���U7p�Ȫy�f~����|VQn����&}�/���:6d�Eʦy{�M�ҋU)�����F��c�S�,1:k�w�\n��-c�\"���L���򣦙�����\\��6�\0g_c��9:���ke��1_g����\0	j�>Ԕ�z��4l\\�W&�3L�Lh�����*�\0O���&��i�2�̶��I��3\rI��:��r�V�%���/�b��n0�e�b��\'�=S�k�a��۝%<��R����a��mqR�H=T����z?m�	�S�8��xv!--��\n5���R��Ӵ�pm�:��%ͨ��~���c�~��N*�Wyʚ�5�#(g|~ZJ8��~?	#g�^�<tz��[;l�%�mo6X�.:b���\"rߏ�d�M��m�=r�mE3�m����$\0U�E��sN�m9R�V��㦵�9�|2F����i��L���˙���V��ۺ7P]��Ԓ�\r�ฝ�3am�XUU-/hB���$�O�-{=r&�v����\0��f.Dٮ�<N���>�\0���\0\0\0\0\0\0\0���ʮ\\�)C�NδW�������z�|���ͫ�S�j3�Qk�.�j�6a�0�ϋau��;K��d�V���E_h��n�o�SڊgKu{~O�\0+*�pt0��M�\\QO�Q���.�\nm~�1 �Ћ2�G1e9�JmҾ���]5��bKB���������=ȹ��1�\Zw\0b�\0\0\0\0>6t�8enu��qî\\���R����c]!s%,����w*�5.�%aG�η��ޣ)?!�^��m\rq7h��>?��Eq7m��3��\0\0\0�*���2�Xop^��q��9�XӜ�1�nhI�S�\0��ч��|[��V�ӵN�i�G�F��zPީJ��1��r���&^)�g-���>N�M��W#���k�\0Q��T�i�Z�H��u��[�i�W��ӱӋ5mֻ\r��{����\"�.aWz�������3��R�$Xvz�Sv�:c��\0+>�܈�r�爞��d�-��\0\0\0��2�2;�ל#��2��ޞ;Kuu�[W�\0}����-�#��d�R�\\�t�k*~����~j�sY��`�ןw���nE�\rɞxӽ���9�I���*`�~��5��4j����������\nK�&��6��P��im��\n�8i�E�gbyW\'��[6Z���^ϛ��O�J�k���m�4���2\nt���S�h������{a��/B�\n\0�����2�m채IJ:;v�z�\0���~��q\\R!�]G�ZK��,�0�	�y:�ףo�f���s4�Zs��_�jn�K]�[*��(��Y|���\0�7����q�ű[��W���E�S�&�m~�G���\0�q����{�\0F��~�6u��T�`͸u:�_��UUk����^]���W�}7������\n2֦��m�O�����`��k���U3Dy��Gի�g��e3n���<t��p\\.�P\0�4�%ze)_f�c8V�Ұ�_JR���Ti�O����B�k���J�Z�P� ���މ%�͌l#g?C-�a�� �\Z��������KX���|��%�M�LW<)������o�$�o7ױ�#	�)P��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0 #�I�\nT�l/1���kV_ʋޏ�ل	����<璯p���(/LZ����H��yQ\r�\\$�(���\Z|��8���\'�M�6�k��~���mbm���T\0\n�T�s�*��r.#[v�9:�.O���8x�5��a�]��X~!y�_P�l+ʍż�Js�Ѧ�_�ͭaY��ws�i�PK�ЗWO��j�接���F��U?��:=��Yr�tULX�w��G7��j5O���Tm\'��|��v�#0f++�u��f���I��Iu�����v��2����k��7JΌ��7���=�ɩs��3�U�+W��R�[��K��[�l��K�ʩ�tLUw�����-v71���M;����~�m��u#BX��j��Wpp_��ڽ�P��Z)�[ќd���Mpd|Q��N��VD�O	��KG-jY�nT�ۢ�ފ�]�5�QN:�Ӧ���F��N�_��1�M0x}�mS/g�Gj���)����~�w�����{���·��Y�Z��*���xo�ܢ�1]�~�S�mx��\0���*K-��u�\0(��o�E���\0t0�OD���\08���{����$T� NRP�nO���{��im�f*�����G�!q�\r�:O��e`��7�����#Y�\Z�,���\Z�\'l[b��9�6[7xҝ���|�5�݋���:h�T�Z�r.;�Y����E���y�zeu����QȠ\0���~\"^�����~vOJ��z���O���\0;9���?���g�(��8@7W�W�u:5v�Z�¤^WE8��ߧǉ(��Њ��)��E�����+ﰬ����ν�:NY�S�Z�F핮��^ʅ7�,����������\rWin�i�0��u�ea���_���/���7�;*k�i�so.Ҥr)�di\nn��Tj����H\no.Ҽ�1�(���1�K[J����߯i��^&y��m�.X���3�\n��	�/�L^4��R�B�9nI9?��\"��}��<fO��՚i�f\"w���O<4نawr(�#I����6e.y�/��wl�����(QͶJR�7Α\rJ5���n��>u�\'����=1�O{+�K�h]Y�Q��>1�JjQ~&�����3O��~�-���4/�oЧ9z�Z��n-��D�����kM�����H��i;�c]t���o0x��Z����c88�)��i�u<�cنH�1��L�Ԓ��Q������?)끟kO\"�1TtLjȮ�7#J�XF<�����TĲ��LN����Z\\Awi�~D�F�%Nr�R.2�jQkF��O��-<�e�!�0L0���l�Ҹ�a9\\���֕{��k�u��j6f�\n��0���4�wk���e�Qf��kwL1\0(�9�D��j��aqBn)IN\\�%�����qřr��$����ViuOM&��My8�a~�u5�v�^/\r2��w��v�4ӯlLG�[̒���Qͧ��{���L�]1���m�����,rƝYKN�/��~*����0_K��,ճ�cV�K��?M$�E𨼋G�/������N1���՟�a���#�o���T���/�z����\n+���wi4�mJ�˒��)v�%�BR�S�\Z������[Ѯƻ�Z},��ql���f�v׶UZU\"��S�O�]kS7���9����8�w���Si���4ʘ�b} ���,!cu^��)A*�U���gI���:�ZU �ˑ{�~�\"��nu�tk��h���X����_\'�V�Z��P6�սZij�<v�v���c�K���˅��7�k�u(ǳ����r�T�uΑ��)�L�\\��m>�ݝ�U3d�Tm��!�Z}P�z����Ll�5Յ�<��ۚ�%N�	j�����Qv��|͵l~x�5_r֞����\'��S}������&׏�k������O_:���Z�����<g�����֣N�*Щ	�8�2MIv����Q|F�6a����\n��X����u7*Ik�s��õOeg�[X�c[�����ͅi%V�z�h����`�[8�7�]F�/�,c���j蟗K!��s��ޔ�Vygl8�hCKlaC��羴��\0$g�F���Z.dr限g��<�iCz�����պ|�����<�7�1Ɲ�\0W�{��F���;���.���g�-�V٦}�sDT�mJ~\n�~΄�Mxײ]�±;b���n�^��jѫ��Z�q�\Z�3�G�������S���?�W�)YI�<:�o2|�0�M���ϺV<�4�	Tؽ>l��O�9��q�\'���a8��K��ҭF��&�Zk��U �o�&5��\'X��I�L9E-[�BEK*InI)-t):�cNU%R1�V����#N�:P�~��(���7����q�R��ש�r�9�����b�a(�ܟՍ��Z�[�gH�ϱ��_�J�?������K\\n���-c+�4P�����G�j֩*��J����)=[~2҅��U��7j�s|f*�m�W��嶶�wqJ֌\\�W�i�.{��#0t^����L����sð���W	T��T<����ϋj�r�T�|�lU��M�x̧J���G���ʍi��+{���x�m���E�u�{oRު�L���w%�ԤޑoS�EM<���QLE<���v9�]e�j�����qRڢ�T$���Dν.�4���~y-���f\n~��*���^6�_��G;�ٜ=�O4�~38[�ڞi�s{�Ft@ڝ�]�nv}��T�1���U&�.R��ip�]�s/�Z�\n��B��է%(J/G\'�d�qan��y�*��oQ��v����o/9q\Z��s̔mr��/!g�GJT/�=�wirRc?��vJ5�I\'\Z��-S\\��/�lU�]�s�:Nkn.Z�c��^|$�KW�<$5�KVd��V�z9q]G��3.�p���?�[��[�z�j�݊�]��q>f��5�D�S\Z�.5��w��ה��(εj���1KV�m�_>�m\'=bY���(ש�kN\\�Џ/7�̃���;L�,���5�]�Sz[ͩ�I>��Z���a��f1��-[�1�=�)�U,ϙ�3�\0i��>Y�k��^�w7�ӺWU�:^��cd1�+G�+t-�쭬�=��Q�wk�\r��i�Rk��c�/��+�H�dv&��<j��̿l�\Zla9uq�g7�WȂ�3~�����=Rt�D霴�ݿ~\ro����;aE�S�\0�A��\0��j�W�\0�w[�\05�ב����sM�<3.`�x��Y$���sk���w���.��c�ti\\פ�J8]9�Ӄ�\0Y$���=;ٗ��^�U�������e،uZZ��<����u^���3m��oK�aV�c��/᤺�����KȮ:�t(F��F�i҂�1�IE%�$��b��Q�����t\n��Z��=2\0�`\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�����͞O-c���m�����M�wŮ���))��h|�{óq�b�kk�8N/�k��i�\\�)�8�͙�To�z\'�<�Ln1v���̂I�T��H��/��VTn#*�}y?Jݥ�f���Iu�)�\'��]�]���t�8r�V��+�&9-�nl�!ui^�\Zԥ�\n���(��`���gX|D�w)t���5(Zf+\ZX���&�����F��K�d[��?�MJ�����c;x�O,d�\"�hY0�Y��)�r�Q�������Z�16�Mu���)�k$P���b��~�:p��nM�31�i�������C�-V���]>����VT��mVi��L����cOz.�x���+Ob�����󺻸�Z�G�9ԓ����,\0���S��&u\0;8^�cw�0�.�wW2ܥNW\'��y4�5�SLk2DLΐ��\'˸�d�Xm�R���W���ӥ����]��L�i($�d�6��8�U®%y�K����}��ih�;>��eX=.�:��ttG�o�p����q���\0�O,���\0�H?���9m���\0�>������\0��4�Z�>0�@�)�2Vl�f9�$����Z��uueJ�Z�b��&��$Sd��z�gYs�����.�����\\��ZS�\Z��s�QMw*�F�����G�<���g�G����f7kR�C�E�M�t[t��W���\nIj��:6#)�bh�.ڦc��1��k7#J���Ywʸ�|\Z��7V��X�=R��\\S>q\'zCdH�Ys�Ƃw�D\\��2��^=�e�#���UVQ��<i���W��R��g	vh��TBu)�T�\'A�E��4�4�:0��c;G��0(���_5���\\A�5#�5����̕� �S�ؖOǭq�.��[yz��T��Q}�7)�;7�Vx�QJ��5q׍9���\Zg`�\\�3;��\0kG�:~��ٖc|b�E_�=�\0-��ʜ�������̞u}��b f!��������[�p�\0��\0�A�p����\0�^}����|���o�%r�ʗ�!��eχ����h�������\0ًA��f��vi���,�x��c�n��eE�Ghk�0����\0�z�)�Ά�\0���?x3O������O�,��Kg���\n�2����g=�x~�\0���F#���?Q�O�,��Ng��\0����\0j��.���^8.\n�\0���ه�?y3_���O�1^��ȳ�+�,�q�ⶶ��i]J�F�IGE�_\\�\'��%���2?�\0�����8�r:�Gz�\'/�v��T��Z�u�r�5�:�íeF�����\nT�)J���Z4A�с\\���]E��V�4�\\u��ʚd�|��:A�ڦ7g�۹��Sq��ƭ�^8��x�&��Uc��~�kU�g���{�y�o���Ɵ�7��9\Z�����ֽ;�ZҥV���8�%�4�ב�H���l�wJ)E^ۥ�W�ǂ��5�f)�a�f����^\Z�:c�}�����[r���2a�e�fKM���?5�R���\Z�<#�-~���O>�ӎ����Z�uf�ce���ފt�f&z�c�?ڜ�:�z]�=�d��kSs�!{�;kV�ܺ���Ew�r,��ӊg<r�=�M:�tQ�~��(.�|}��w9�Vs�74��揌����}�^�GB�@�V�iƍ(�N�Q�\\�|7�6\n��S�p9�*ZZS�]	����dt����\\��}A�7\n��5�j�\\cۧ7�%<`�����f�x���n�dq���,�6h�oO?b�weF��K{�q�F�7J�$�R����i��_f5n�����n�W��,iR��/e*�u]8n7ƞ��oO�������\\jb�.�0Q��e��W����	��u5֛5��vs�ke��i*Ua���K�W��8>���H�2��\\��2}�_E9���ܛ��̟wW�����r[��Y�S���R�jRR�Jrq�_jk�3^E�m���F��3|�i�WM²]��x��0�=��.��j�|]�%\\�5L&��cg�tb��\Zë��(S�M~�e�������:\r�x�y4�e;�����A_0���y���X�mi�<lF���~�;�:kb�����,�K�����WN�ӏ����H���2�ٳ��f<V���^ukKV�b]K�08�e�T�v�~\rn+�����k��\0�bW�ŕq�͵�&�sqko��^�W�&��*�}joH����c<ı�N��,��^]�T�ѧe93`[�\r��2�-.<Lb������[�T���?�Vm2�X��W�Ӿ~��I������Ӿg����\0|Ζ;��c�]���½��)P�J\\�	-\Z;峂�Ӈ���DƎ�1\ZKZ�Z������[�ߝ���e^K�j\r�ׯj\\z<g>&Ŷ۱�#j�^Xuy*��u,/4�Ni.�K�^&k�4e|o&�9w0�Ե�����%�uJ/�5�>���`�kLy���百YV�*��\'�WS�\0\r[P�yjY�gw*���ܷ�n������-t�ŭ�\nY�%���p�{�I���&��$Fe��b0ѥ��#�=��6e��F���:8ǽ4�t��ǁ֮V�j�\\cN���7W�o��CvP�no�[���q�����eQ�+N�fU�㪍9Q�ȹ�o�M�gm�c�����gd�\Zzv=�^6c��z�0\ru˵ޫ�ru��������wj������N4��S�ڌc�l�y�--no�X�P�k��Ɲ*PZ�roD�]�Ca[�?л#��ܪo�^��&��6�SO�+��Stg��S,ʎ�։br����־�M{9��k��O��ZE\"ے��f<=��t.�W8h���O菬��$���hT��v�}�d+�r�(/L��_�W����/��k����\r����P��z��V�֎2OF�6�V�������d�I��xک�\\�k��S��%gN<n#�_n���]�Z�u���|=��z��V��q4�Ũ�\\~�zM=\Zi��\n��q2FC���ӧi�c��ʚ�6��զ�b��G��nKwk�W*��=Ok7�X��j���J��#ǐ%��V����	Ǉ�3���ÒcOz�&cu*��jN�c�R����Ӝ�\"4�{���?�S\Zr�{!$�/M��}	���K���\Z�esQw��b���;8m8�ۿN�z��i�NzS���p^c��7��v���s�bq{�W3#�\0��9-OQ�}��;J��Y[�ӭQ;��z��[ӗ�yދ���c,�y�\Z���v¥����c.]�o�.�}�;b�V�2ߥ��q�]�;�Ǜ���Y��r���7��?&�)�+���c̎3���sʸ�^�(ƕ��Ѧ����}���]k��F;�B��b���D���4��A��M������\0��Ngȃ]4��Z���m�\0IT��މ�\r&�z�a�\0-A:��|�����K��n3v9\n�V��N0T�b��Z�]8����i�j;�s\n���P_�h��[8����릋�`�b�熧]4���w {n���Ut�	�͹���BG�����޲�����ݷB��Вu��~�.�צ��X#�`��7��T�ە��o.\'Q7�����2�%�[��n��ϗ��.ګ<	��诰��\Zi��\\O���. ̊b���Li\0\0��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\ZMhʀ>f?��ǆ��q{:w6Ֆ����SO���4ma�U�\\S/S��aI�5�Z��TW�K�������庍.o�as�4�\ZU*�1���&+k�jQmI4��F	���9����W��ݝ��\0�m4���^�^Ta��ѷ7ᒝL\n�������];��O��i�l�a��m�˧��=�{�Wo�W�o�9Q��b0}�S!�<\Zn8�Z�)n�mP����p>$�V�-����(���v��3��f\'�4kꢪ7U\Z(��%E�����vW3brQ��B���XЖ�}4\"�Uݝ(���E4UW��(d�`D��\\���i>s���_�_�el���)��9��3s����E�A=_�����e����4�ջ���ͳ��/~Α׹��f�3Fz�T0[	�$��TN4i��u����ٶʰ\r���v���#V:V��}s�W�Ǹ�VvV𳲴�B�5�\nt���9�R�:6K�l�b�^}Ι��Gϊ���m�|��WOЌ#t�z��v�0J�����]�\0�3���峼ǟ�C/ӡ7c+�[��P�j�k�,��5�����4�UN�Dq�P��h��\Z�h�ft��-�\'z����Z��Q+�s�O�k%�NM���wJ��8�R{���gf�M�e��g�\0ƈ��:m!�X�n�%�fu��,�QWV4m꨽V� ����s�̻��\\�ni���4�m�=�7*���n}���z4�ѝ\n���ԋ��%��_��1�nL���e���)Q���k��\'�y9y	��|඿��9�\0.�Vф1K=ggQ�|5�\'�%�z2��<�MmG��o���������my��8}���\0�侣P��?������\0���P�NW�L���\0,���z���~3.tw�0<���g�,Z_KM��t�5�KO1�{N�\0A���>S��b;Uî�_�����F�9+�p�^���Fv[��2�U�,W�ϫ;�;a��݋�D�ꔵ�m�ˎ��J�hS�^���8)Nk\'�y���u�W޲��k��2�\0���ߧ�<���K���G�\0�����P�RS��w�z��Em2�V:�3��j��ӯF�8�r�Q���M~LJ�_`�O���?����gR��v�O�X�/��_�9�Y>aO�\0,�\Z�_�4Ot�H=��?�����ē�e�d�I_�v!���<�,���5,�>-{Ԟ�y zϡ6�=��?��R�d�I�~!���#ɸ��U���<Z��=��@��d;KkU�/��+�9#���˞T�^=��Ϩ����_�?Cůz��/s\r�m6�ᖪ�H��v�li��ZQ���kC0����\0�~���ߟ؞�e����=���\0G1�b�/��b�\n��Jo%^*�E5���u�fE��-Nːڮ�]f��Ҩ��<V�5Q����I�Wǁ�R�kMu���9I�fٔ�Z�Mhկ�2=��f�J�|z�Mu��>��ԥV�IR�NP�����>�O���/:�&�V��8��k�ݳP����E;��q5M��5O\Zy������i1�L\\������Cpe��ѳ6�ӝ\\����FO�UK��?#���x����1i�\Z.k������9�����X�a����g��/>Z�7��ݯi^�\\��qƕZ�v�9��(�k����X�L(�e��.#%���8[ͯ>�|\'����\\jQ��l0�o���n��&�/�b�S��uU�zч�wu��1ޯ�3 l�dX�|���zs������::�ɦ�7��x��&�x�����\n��n�Ԓ�7(E�CV���#,з�oJhQ�:p��a��ċ�O�U�Qw1��q�l�;ۜ&O:��}]�2�m��6�km�A/;}�)��*t�(��1E1�B�LE1�\0�+\\m���Wh{4ʻK����kV1nt+�Je	u~g�z���>+�M�f��X��tSr����%���tqλ6�S��<gr{���nT���Ú}�U��b^ON�f�*ҥ88�\nQkF��U�bl�ѯe��Ժ��K�*j�7���l�������^C�j��d�U\\n��<�,�O�~��~C殅��\r�R�U�0�f��T�޶��=c旐�X��v���J�\0\"�n1�:4�,_��SGw����z�[��>}�������W3�7���Qk���H�\0UT��;U���q	��i�̌~MQ�F\'���]\0z�;e�F����#\Z��ɻ9�?+H��s�f�q�A�a��=s��u���GV{[�߻�(��dZ��owD�cx�S��g�������=[���[�-�#�ӟ$��������G�w/3�%s��Ǐ��|���M�^V��3����\r�0��������P��#q��n�<�D������n�sbgH�?O��_`od���G�Ov������8S_b���-n-S��+�4ӁR�fż=E���-ᨋv�H�\0{=V�����c��k*�[��/AP��-/��xZO�����b����_�;���L�\\k��j��M���K\\N؎y�m��a�ä����EΌ�V�\\%ڥ�v�?��ͭ\\��^P��ݭ*�j-�ө(�v4�3g���6;���^���T�FR}r�.��X��5�3Vu����Xݚ�&j�����PX�2t9چ9��ñ�غU|���Z��<\'��a2q��x�Ӯ�Qy㩥���Z�+�{��~*��������s����x�~��\'z�c�Q��g�1�����҇���7&t�g��{�:E�/ї�$��ey�Za4��w�U�0M��$t1ɸ;��tƮqˈ�/Exu���^u�3leX��#�w�����D�Lt���܉�G\"����C\n�x%��y�&ⴄ;�7�b���/b=2���K���c�Ҕ4Zе���%��ɡ�r�Z�2͜0������J�5�ӟ��фa�b����Z�LWsΫ�N]�Y��\\��U�d|�Ɣb�Z�/K@\r�z\0	�ӌ�rׇap8�Ϣ��m�q��}\n8���^��\n7R�i򄟙�zs!�9�cyk��c�]ͅ�\'��׆��~4�6��4y��ܝ�l�a�p+k�-Tg8�R�|f��E��mߙ�gͫ�?E1�m��nY�M^��5�	Y���ԩy��͹\r7��$�k�5b�)����;b�󒭓����[9��k���+���M��������:�����c@}�����d�{���-}��]<��Z�X̵e�G/�u%�J���LNEQ�a�6��1/�a��i���?\"�7��k(%喆F��6���1��%��*�|-M;�\rV�6�kX<E��D�c\"�_��:[�3��,�{1�fzڅ�`���/��71q���˹yZ%f��\'��(N��-J�a��O�^%\Z*_ɤ�~3�����-h���ڝ*T��!��+�%���2\n�b�L��X0[7T�U�����ӽ�O�����5�`����X�L�Ruj�����_	�iӍ4�u��ʨ�rI,֭Qf����!k�j�4E�H�\0z=ɐs����6/���j��&EN�{��v�i�eL]���h�ʣ�%5V�k�>ƍFun��nM��\Zl����9��Lα���-�\"�NxE�~�����};^�;U�µ�o�w3,�F_����M�+�����0\'3jx$w0[}��%�C�������*z>*��&��D̳��{J7��t�\rR�]��#�^�Msv�5����\n��M�t�M=�`aY\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0i5�I�����E��iIw�3�1�u�X�R�S��4�x�1ZF)x�PDS�4�\Z �\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\r\'����/eB���V�ˊ�����rc���!�^$T@\0\0\0\0\0\0\0\0\0E�\0�R�?eNƑj�Ar�Mx��@F��\\\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0D\0\0\0\0\0\0\0\0\0\0\0\0\0�!/e�h�Q������^\0 \0\0\0\0\0\0\0\0\0�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0�j)��\\@�mPn:껵�\0�!�?D�`�3�`�p\\�{+�������tk8M�~���n2�T�\\�?���hl�a���t�+���sM���z�(��XŹp��4��ߜ�ޞf���f]\"3!��E�=a}��F�T�ZixZ{ۭ�T��V�*z릛���Ƅb֚k�]xk��_F=�T�6۲�nu�-ҳ�㢕�oY={�z�	�+\n���ҭF[��Gz2��\'��y�s��z-_Q��j1���<��`Q�1Z�R!Qk�$\\\'V�R�Wˁr�d�OT��8�5G}C{�=xi�\0}�$�E�OD��8�1I�-Z��*��=5��.d��;�0�.���q�ދ���\\�r�M�ϓ�\0����NR܋m��K�N�)���M�ȥ;�U^���� 8�uB2psѮ}�$\'�N/� 8�x7�zqE��*\nj���Ppջ�F[�\'�}�,Z�T�&� T~����\\��Ҧ��~`9��h���\\��.�XM7�=��k��ח>��sE6���N�9AIN1Z��+�Mj�5���*m)K�Z�/��5�^��\r�$��&����`w4��m�� x�g+���1�6Ε���V��F�j���Rӎ�.$\0�\0�#iM��3�_���Ͻ�\0z�{�hU��5��r�k��4��y����r����x�mh�]c�eڴ���	N:�x��=��z-����\0����2�i&�%�A*���P�NS�7�׆��+�2z)j������u�ǃo�]	Ƥw��\\�\0\0\0[:������ *���$��g���+d�2�9�s�a�c��/.#N��ϳN-�41�I��_��M��{J7���p�5MBU���rm=)ǆ�GԴf�v��M��0T�9��yRS���A��[\'�4��W7��S������C-\\Բ�Xn9�jS���km.��Uj�Ӱ�Q�T��\0�����>Z�ڃzx�����P�Y���S.�8���z������]������H{[�u�C��m����W�ܧ��F���6�l:\\R��lS)\\�q��\'AT�m�xZ[�.��)w/�.;aO�1kK�\Z�S�qo^5i�>MJ-��4�hc�1��{<3¯0�q���Q.��$́�.�J�F9O���a�xM̜�nc��N?c.�G��	Ӝ�n�2�����2�8��r�ܶyi�rݥŝ;��w6����x��MKD��%�u.K#�\0��\Zz�KM9��=3Gw{�����5sK�]\n��ڋ���u�Ӗ��^N�@q��R�Gϗ�Z��\" 8���r�]\n���\"�ǚ$Y^+yI�Ǉk���;m��~�V�36�0܁�^[`W�֝z��*�[���e�_Q<+Ԅe��T����a=zMm\r��^O�#�<ͅ�;�A��J�͗�[�0���g\ZJ�U%�|:����zi�W.��t��m��g��\rW���ug�[I�ButoY��1�����p�GB�j~�u���\Z~-�:slG6m�ev��4U�)��#J�-o]A��q�z�M-x�.��YO�+��c�q�p��gSJ�ֶ�Vo��ԟ�\'��l�&��vj��9���YbvԮ������~>?�����mY�3Q��fα�7U*�u*]�T�F����S�Q�q׏Q�}�e\nyg�J�q���гu~��:6���Bws#���l��\r)�5��c����O]	C�:��r��=9o����#T��Įi>M���էZ;���D�x�҆���Mz�\0�\Z�JQ�SN=�W��r��� r�V�7�Ǚy \0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0Y[�)�Z���/>.d̶9g\0ĳ-R���J�U�)i�!\'��̉K\\�����5��M��:����c�UY?	wƓR��7qv)��ö��W\'��W��^b�%�c�I�/�~����V��G��Vu��6}ǳ�\'9J�3}V��?c�l|J:/!?�ݖ��ȸ�ԯ�R��7\n��R\\}-F^�KU�Smp�W�8By�ߩJ�\Z��V�Jrq�Z�Ů\r>�n?��ש�W`Y{�����<\r��KYJ⎊3m�s�*S׶R]F�:jl�[1��;ooo���u�ٳӖ�V�\"O�J�i����jmC�wi���o�w-3M���R|��]�~a<5:�BMT���J:�%����ٺ<,����_��1G;K��YU�R��>��5c�g-�9��KX���ъzLl����1�2�ix[�[J��j�uO�Sӯ����0�C��\"{I�[T�2��l�ͮ�ܫ)�X�U�V�j�)KzUd���OU�=z���9k5-5Zj�_f�g�+�BJT�Щ��\'�4Ѻ���V�ض1�f��ST#i�i��T����増�s����V�����K��YX�T���\'�iтޜ��Ijk\'�M��^�e�)���5W�4����}���9F�S�����\"Kz#{Z����<����byʫ�I=%ZzJ��\\c�5��l��m/>�9��w��R��ѵN2���-8��\nRo�,u�M�tN�6�6��\Z;B�e�i[����8}��GҫH��JrrnJmv-����L��ܣy�s�#�.�H�ZkR��5N�)>KO����S(a7,a�c��p�Jv�#����R�蹽5~3T]9v�}���_e�6�_;YJ���*q�q�^v���z�8���S��\ZJw=��=���W�m�W��e�=I�\\�э��E�ڗ���>��t��Qi{N��hv������e\Zr�~\n�%�h��\n�|���[ɖ��Ѷ���b/v�ΓzoI�Tc�}�6�m��q�(_mC\Z�\'�ҭ;JP�ޜ>����~��w�S�Ic�l�0P�XE���0��E�U����u�\\����H�4��^HŰ�M�DB*��JIh���?��m�;��}��F���Ʋ���-1{XJ1��Ճ���N:k$���za5�B%�ݍ�,W<�*g,g�ѽ��k��P��J5*CzJ1��}��=3�Z�K��~���H�����b���FΥYF����q���!z4}`vy�\0�,?D�#�}w2����>��}<�f��l���\\����s�0�ѹ�^1�]8oU��M�˖���g��o�M���ף�[\\?+a�O�ԫm˩GW�^J��n=9&D�;\r��1l+��swwV4hQ�eRrz(���\'���;{̵N�\0iY������zK�N�m&�R�ԝM5Z��.k^�w&w+�!�%�LN��fó�k~��\n����ʄ)���>#`�zRd���n��Ea���K�U:�S�R��7��.Mh�ᮮzGt{��,�������>�ñQ�/\rO]\Z���_5�\\SL�=�f\'��Hek|>��K�<*�\nZ)ҩ����w��Y�m�w�v]��մ��\'�`vq����\'R���#��i��|�|y�_��t��\0Dd��e���6���3j�>��y�_]Y���ڵ{m��k�־��N��e�8A�苛�{������\0��O�#$�\0�+�\0�)�\0��H��FI�\0�W�\0�|�I��­p<�b����F��t7)�E�*�P����ǋ��VG��,{j��Yj�տ�n�ov�9ά��AJR}J,�F���m� 0�_;m�/����xr���F����Ԟ���Zp[�kO])v��8�k�2�u��+�8~Aֹ��QF���I���V��#e�6��g�p����S��m�B-%�I�\\�I�����@�D�n7w����p���\r�J�ݖ�\Z�qR�I����^9��\'���v6���1�#b8���f�lJ��Z�4ޅ.\n+�o�w�C��J�W�it��]/��|b���-<�\"پ��~�3}�I�L��K�=�\'�\np\\eRr|#���Bse_B�/GS��K��J+z8m�)Ч6�\'QJU�[���A���W�CN��\\�ng���ݥ�a�h�m�\0���q���^��Χ�e��j���y*P���[����?�;��y�n<�bk2�M+��[�U�[i\'V	�8qK~/���!�ns�^�s^��9e���>�!s}sk8Xѕ:[����2��-:�|G���>�w��o\ZȔ0�ձ���+�B�uc�\nI�Fq�zɜ~�?�1�_��\0�1Ǣ����o�K��D��v:ٿ�M��_=�xnШ���qybw4p��+��_��#��d�K��!���61���X})�0��\n*��U�(Ӗ����-z�!��D��/�͉缳c�v���\ZX�(�[a�Tc+�R���Y�8�Mh�4|\Zթk3�:!�p�D�6}J��>��T��Wmq��B���StiBz>�\"qtU魖����q�6.m���zV3օ�4�|����<���RmA��}������jX�[�j�zW3��Z޾�J�D�k�)�%����1.��e�F�^Y�xuIƮ���{�G(o�8�b���7�J��MTQk^��Ki;S�)�w��:߫2�8�oG*���N?e&�h�S�Z����pZ��/%�R];6�}�m���+�,���*XZP��d�\"�kVk��\'�����R�Jv��_ֵ�^e���&�\\��WWsI��\\5Zz�˙��ޟ�)�.�qs�\\B�\Zn���T��G��F^U$���݂筿f���m�*t��__���)��si6�ӄRտ+S6�й�P�����uqD�V�gJ5�����_�F�N���O�k;�h8E,1��u��V�rvws�zA\'Ɯ�Rz��^DFn��G>�u��w�է�e��\n�����/�Ճo�M��Z�ֺ6�K	\"cNdKw=���g�~����F5h��[��$�K�z�Ii�����:���\0O�|B-�#=\"�r�\Z�ד�y��+�v✴�;y6�[��s�R�ӄ\\t~��9����#ys)bW9kc�]�c������.�?I)�\ZAE�Y\'��_Sk����)�.�\\Z���96���[)S�}K�Ҝ��a\\��sN�sM�LɘMLG�g��уI.�JO�b�\'�\"td�B������<NTԧK�Х?�S����;�׳��	����&�~^���i��\'$�o�BҾ�ɕ$������1����U.��JX����\n�j76��D���C�K��5��3�Nuؾ_:�|n�/ڷ+��:Wv��z��V�x7Ç\rj>��h٣e9�\r�9?��#�OU���NKIҚ�(J-���Z4�Ӡ���	��N<�\\x���#ږ�p<���F���_�뫥7��7�FK�{Q���Uh��N��q�*	՜��Q�Z��H�פ�7_.l#<�6�J�0[�voA���HjG����=��s\Z��5��:�iYa45{�l���)O���S}ǲ��b�6g���+�e\Zq��z|\'uS���\'��i�\\wT��$G�/�|��t4ȸvQ�铩�PT��6K����V����഻��u�NIٮO��_��y+����t�h���OD��%�ri-e-[�l�r���Ԧ��5ӫ���9�(G�Z\Z���l�kY~����\'o$�:���qo\'�t��(K��>:h�\\M���T���lS3S���[����}S^.�Q\\��Y���ћ�H�Gmc�g4�wy��Bu�|����<�����Z��a�fJ4m�h�HR�\\�[�oVޭ��gоĭ��N���\nt��9�j*1Zo6��kV�IK�5��$��~?l����\0H�G���ܡ{:����=sJN2t�Ɲ���-�v�Av���������ys��v1�P�n)JP�-z��#5��t�R��s�)�����Ҧ��U����NJ���=��Q���a����6m?5Ydܗ���\0����{���9>�W\'�\"t�/B��g��_����O	��(S�攪�R�]�G^�\'HN�-���K���wB��\n�JIT������^���<�$��OI-�m��-��e�\n>��.cuo\'�X��-�S^�����H�bXL뗱u�rݾ�����76Z��ڝ>K}h��X����f�sN�s��r���^�M����p�J�~�2Z�<MqHi��-�R����u=9�C�]-v���h�&[��X\r{LC	��W�ZT�5S�N\ZFP�\r#�<�*6a����dL=��n�\Z��uI�*m�]���\Z��S~��[�\0NG�\0����}��#y�͗l�.�r����������T��VI�6�i�6�I��6���0_U��{l?+a��Ҫ�֝����*��v��dKð��^���mj\\��Յ\ni�eR��Q�]m��;�u�cP�˴/v���lq{�J����0p��Z�Nu�is�wGÊ�M����gIl�w�fl;1Z���K�*ތd���Si����3`}:Ne��z��	�v�,G	�ӝ�J�^�z�|7���>�X#�<f>��Ɔ^�o��xv#C�8~!N����OI�Q|c8�}M8��E�z�,G\'t��>��8�Ʈ%�]�OHԥYh��wf�/P냪SӦ�H������D�������[\\,F�u��!��w\'��ޤj�hy�\Z�fuų�b�kK�鋘�A��^�6�\\6��t��ՕzH`�6�1�[���T��+����ߌ�.�R�s�����f��a�7vx�^�w�Ԋ�z�u%��!A���[E��O\Z��-0J��eo;��Zή���88T���l����=\'���t0�zAд�^c�.�\n�egSҊ��GES{�ҏ�u�+t0詔:K[��٫1�[��,aAa�銺�彿r�1�M9�Kt�َ���V�4���������?	qZ���Ipu\ZZ.I	L0��M�\n���ޮ�Tjׄ[�]5�Ӈ����6���I���u�r��N�ѽqO���ˑ�,#굗�i�do�i`8ss�J֞�^_KK_�N�<�ضђ6)��f��+kx��)���T�:q�W\'�Ը�\rzm\'�\'�.`��=�Z�e\\>2~\nS����\'WXy7��\\���f��K�7S���k���z\n^��BN.��mQ�-y���>.��:g�y���hҴì�x�+r��{d�G��}P\\��Z�r��{�+��M��F��>Y��[�.�[8�k��4�=?��G�KK�~`��e�g�8�ÕXε��U8)%�R��w����4��}�^��I����ڎ;,Qǅh�ҍ��g�~�O�\"?H����+Ec5ib���lq{x8£\\w*A���N;������$nd��t���Q��:a���ׇӁ����^c�;����q<>�����=���q�hQ��l��eMԟ��˟�\"L�s>�)��`���q\Z��[Zҕz��MF��j�&�$�v��Zḥ��,�T�,c��S��*q�R]��G��F�D���g�ò�!;|:���ʌ�w5d��F_ɌZ�]nK^Ze�+�;b���3$������ԩR[���&��T��v+^��$���^��J�՝J;I�m�T���+�Yє������,��uF��p|32X�/	Z�/I�i����9p׃�FP�ޅ�U��kچ/[�5����ҡ	?��ޜ��;���[�6a��a�G1�W%\n���U���IV��������ui=�V���ٖ�vﳽ�eט�)�Ov�3�V�:�R��5\\��l�z6�K%P����-4��]|]ƍ��,ð�a����N��N��KH�ڶ��>�Z����f�fa�3vX�3Vv�p�bҍ��T�ޥR\nQmu=���\'�l\0J\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0 z\"�X�H���}��\'��}&�f��gI�֖��MƟ\rTzq�/�]���\0O��������Upܭ��h�n�u��\0�r_�١�0��QrJME7��=ٯM�;5��B±�vvX�+8O�=H�G�*�/���O�L�=;��ݵ�j�<� 姘�����\0�.�\0#/��.�qm�`|�X\r�B�q)f\\\n�T�0�҅[:��d\\�\\g\Zn:�9��W!�Wg����$����^�RovnM�Z}���}͟;�N+������C�R�JSt�Ӕ\'q�ѯ 5o�(f�;:�\'6�W���ѽ���W\n��I�ֵѮiş~��R��ۡ\r}\r���ղ���{q�{�n���Z�Z���\0���eW��\\��A-A���v_�LG�m]7k�ڥʝy?�}�LnI.\n5\"����hm�e�����Vy���å9%^Q�s��t�z�Β]d����8�a�Y���M4��8k)�(�Y-9�O׷ԩ��~�b�g���+ږw�5[z�ޒ��&�O;6t��]������U�|��a�>�n�N���o^{�������:��qͱbv�Ké��%%�6qִ��Z��u\\}{\\� ����/�R���V����iS��:�g-K�m��f�?��c[%���i����3���w?]Zk�o6�b����og����YS��7\Z�xuz��)�K�\ZĮg{�]^U�s�Zu$�6�&��7���q\\\"�	���ymR�M.Q�\\_���\\�{�3�7�q*�u��u��i(�Zk�L#���C�\'��?G�,f��}9�]�\\���G-ٸEy�IK�z-4�/W�Є>���0LW#��#N���T���Rz;�j�O�v�ɴ�弹��oӖ��Wϓ�\"	bN�?ͻϘf%oF�w�P�Z�:�ԥZ�]���^-M)#o:�̓l�c��i�s6YU�lm�N{�c�Z�]J0��lѨt!3��΍X����\"�(�]̳���\06D����������� ������?��dB۠V\\�̝&��;�uZ�J�Qk]\'N���N,��Z-J3��������C�\'�o���3mT�K��O8����Ee|��B����Q׭�S����3I�o�	Ŵ�n[r��l�*��G�\0���\n!7F���B�|���8Jt���sf`²�Zĳ.9wk2�wWg��տ�ԛ�ݖ�G�sD�Iz@ִ���F[��gy^�҄��Rzѡ�{Jr�Q]�J!\r6�[m{P�s�%R�����hI��a5�Ë픛�ɻ�pl�-��fa�ݽ�a+l\"3����d��G�r�K�E�2�q�������d�0�?}\\��r��[�W�+�F�p#\r�p�\\��meaF��i�HS��ǹE%�О�b��S����\'�����#t��jf\r���9��f+�\r�j�kJ0^H�+�or�[��K]tӬ��L,�u��Jg�6⏃��+S�j:FTn�����|qb�>��Q��ws�t�B��\Z��p���YB�a��}Z�K]9�	�+z2z�\Z���5v׀e<Ǌ�2^ҳ�⸥w�֫-���+vTu|�t�]m5ͣf��M_\'2��#1`��1a�Bޥ��	�Jpq�|���49���`�����u#a{^�3kM�	����ݮ޶���1��K<f��mJQ����ww2�T�Eu������� ��8���\'y=���ӯV_m9��O���9�_�9�\0��\n�x��!�=O�#:]��&G�9�\0��\n�x��!�=O�#:]��$G�6�)f�dܷ^����ZҜ4�z>6�|�#x��T)��T�a��I&�^m\r-�NI����kT��o�n�F)ꢼ��j����B�\0��?}�,*�\0�����aGUߥf�M���m^[�-��Ŧ��7���3ϋ�\0�;SO���}�?�\Z��s�S�2��曍������zF�o�㮆��.���W����Z⤪ԓ|e)6��}�ԩ\\`��k���`���:8-�u���&t�7�/7�YG��s��ײ������_�5��ͦz�;�z9�奴]�d������뛅yЄ[�Q��w��P�K����������^��O��\'yJ�\Z���\\XR��]՝Y:���*Jz���;�zrQ[݀�&�I��|۰|�bV�V^✚mөN;��I&i=x�϶�f[\Z��J��~o�J50�:�׽��R��#.-��+�Mj�A<����;�\0����OLLZ��/��^�s��-;H=uҝ4�Ǳ$m[���:���\0O�|CX]:2e�N�-���)Ǝ9RŬ�tU)�\\\\{R�gX� ����T�y��*^�J�\r�\'�8MJs��j�W��Dm��[ц�M5׫���\0���|#g�[g���cC4�S��Vjw��(9>NQ�K���=\r�ZUu&���Z�F�n�~&9�3�a���\\;��qkuNtjҜT�8Ih����3E[M�6�/i�\'ZUuh`X��Jmh�\n���D݆����vI�1�!J����%+��aJ	󔞉.���fl~�5f<[4b�߽�/��2]uj�s��Ɉ�s6m�e�W8��12⬥O	��c�(J�*�~5I\rr\"��ߒ�2�G{;�B���1�8��֟K{��/�4���\\��C\Zt��n3���k�V�nd��A��S%�,^��͍K[�Ftk\'Nq��J-h�]�	!�\r&nS��u����u{K�Φe�:�)-aR��Z�]�Ǚ���{\"Ķ+��w&�ѩ�q;�*�Qj7U$�)&�����7�-8�\0��J��3�\r��ջ���+�R��[J�h�ӏ�p�(���⸸����m�E����ˏ!���U��~�0���e�a�0ޅkj�zr�2I�FKU�ZM��Ҝ�z=�\"Q1��c��!�/V�y�4Z����t�SZ���R�]R\\V�-�����\0�L�n6��9��M��ݶ���(q��=5��S�r��jh�mʋK_\'v��~I�(���=�7Sr��+R����A��-z�H���Xf.�\Z��\n7�7��sksB��:��(�I=\Zi�����g�˼��?7�W��G�X���E*U⦴���E��#y̓~��O�\'��,�^�/=3C�==u:j.r�ի��O�J��WM?��Cgl�.Q�X�����V�<��s�T�-�i���Q|�8�ͣg����/��`XN7�]���.��h�޽	��R����kTh{7����m���*��<3������S�(\'�~���׵���͞�9�2]Ӎ+JO��򞓻����ۖ��-_Q�_���k�f���sqR��9T������Q������b�*a�r�\r��ZRת�*������y2�����\0��JC�$����M��)S�Ǯ�Ⲍ�=ɵ\ZoN�B,��oד+���\0������2ͦd�;����.(�To1-��4�\n�9x�Rp�}N)�|�il�����x��5C�l��K�j���_s�@�,���(@�E/��J���)EU�%sIͿ]����f��t_zt���~d�_��&������M�%�����)����\0�El��\0R���\"	n�IEE%�y\Z^��{D�x�ā�)�}�4���&����/� �J�B����>���[�-z#���}��a��b_B����>���[�-z#���}��a��I��.�Z��4�27��.����qZ��Z�-�֧%-\Z�m[O΍�U���O�#{�4s@�_��bxD��)-RU(n7��Lnhvs�Iʤ��M��ٷރ9;�}r�ݍ(�lf�\\B�{��՝F�oE�H��-���^���B���g^�֎)��I��fŽ�x/���c��m�`����5�(��IKyƓ|��&��O\\�)h�GBp�4��8%��}/2&\r�:7��K�zJXf\r_��%��V�.�\\{T�|Sk���WM���ۡ��&H�~%��+�|ɚ��Z�i�m�Y9�6uV�S��Z�kD�!�U������eN-/��z���`�#{{3_��)>0k.y��$�\r-m��̛a����֭�?6��v>j1]�$�r\'ϡ��p�M����x�ű�Xʦ��6�)Sq��՛��ش�]\'r]�B��w�n-�*s��/m�W��7V\Z>��|qd��4�σa�1���ԭ.oo>ka�-y��j)��J�%��><q̞v�<\r=7wx>�O;���f�����^�5�/�+Щ	-V��Z��z*�v�����_��b.�[e�6+��_2㘌�j-p�YTN��ܓP�#��/e&��-_a2�is�V8�Քe���Β���dֿ��C�0\\��K{��<&��h�o���x�5sqV���yoT�9T��z��܇B�u��7eKB����tg�֧.>���5\\��~]z�<\0	@\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0m�i��!�Fgϵ%La֕ccN||%�����T�8���$^]\\��־��:�%V�Y�e9��)7��f�����/Pʹ���p�^����(ҕZ�5�\0	Nz��塅m}=�Y�ѻ�b���B�j*U��]9��ݒV��4z5��ܙz���\'��6��^[�<_3�X��q�J3IQ��4�_t�2I7��\ZV�)B�*0�8S�����]�hw��	I����Z7�\Z��KvQO+mO�Vk���U�i^n�E�	G^��J��I��E1��6\r�6��㔳����ҹ��+�\n���S�SZFU!4�\\���B�������ς��x.#��1U_Ҫ>�ڪ\r������U�9�)���P�0vksN��5�N��8Mb��\'����J�\'	�í-l��ֹ��#Z���WD���Ij��袵��R֍�[;�1�J�>\n�9�J2��I4�5�|��H��l{k��#T��kiu*����f��4�=\"�o�3x�\"���z멁����f=!1�Ϝ�q�B��ґ�uF��O{y*���kV�Zp�+���,v���9��U0��Mbw����{�#����\r�ٷ+jrkM��l��G��o��Hw�Į�9sw�Յ[��AF0��wb�ii�Rz�2�8��GM*�k	%֙�D��-s�TۮB�*�F�8�0�ц�R�Tct��b����\\ܙ��ꊸ��A���RZ���X!�L+�0F��q��I��.-�8T�5��K�fr����f�x=<��A�=1Vʌ�	~��R\'f����mC��p�7yK�-�p�K֓�)ДwS��\Z�oW��^�6V�u	�_�nm�����t�ͭz��I/�c�x .c̹�i���`̸�\'��N��ׯ^r�(R�����D�>���Ά�\Z�;=�6u�pk�Z�ʥ�#���#Z��M�YA�<֑Q����^1��]l�:��>ou�Zp�\0��%�}\Z*S�\0��o�V\\��G��K�D�P䥵̳��\0��\0��ؾE�6�(�/\n�Z��gJ��wN��N:)M�����\\��v���g= �-�d��c��aj�)G��Jy�9*�fܵ}��=F�I�9��XM�\0�ʹӔeZ�#��:l�ayކɘ�i�ĨP�m\Zx��\n�\\*GF��F^]zw�9SO�̞q}^9#�����\n!/F��߲��o�m��F���3��|��6��E��h<2�*S��֤�S���k�#d�C�c�6�9��Yƥ�\rw�x��Zʔ��RQ�M�A:�f���G���q����~��9R�	(���S���&��tO]��s�p�6��1L��|G���yrI���{\"��.���\r��k�� 0�9�,�a�a���haWTiF�F�ޟ��6�����0��]��������\0��k�\0c�!6��y�Uvoae[T�uV��*�a��T���շ��ðɿ�����ۅ�\0���\0d��]t~�ӟ�����u���N}�\0�Z�bP��!�j|�y��q�k�`Q�����AAV�ׄ�q-�|>}�/O�x�����2m��sF^��΅8���=w�l�\'\'֜�Z2���+dn�SǾp�lv��Z�ib�j�����ӧ��Z�$fXR�����$���w�<�ՠ	����:��kumSIFI¥)���i�fܫ�g��Q�#�a��w6��M�ZҸ���Js�|����-��ۮ*b��[�d���UEN�W�O\r	\'N���*\\4RH�2�)2ڸߎ��\'C]|̈oiٽ�t�	��5������c��3v`�3!RJ����Z7�F�(�|�#�J2��&��^�>�nKb��I��C˘M\\O\Z���؜�R�j�ƞ�B����>�3\Z�B�\0`��N�|ўԧ\'&��Zi������;^�<)k�\0���1Ǣ�8�$de&�)w�(��c;�{��v��q+�6��[�T�*¥m��zZ�B1|u�H�\Zx�?���97�M��g�K���\\N�̺��JR�T^�N�\r�!-WtM�\0	M��\0?�|cv$^���M��|>�9�9��0+�^�S����NT��o׉�(O��=t��\0����?�N�����}��7��M��{j��#�l�w}m��Ҡ�j���J�+GvS����(��_G\n~���)TUc���pjQO��T������!)u�q¬��O�_^�GE�f���,����c�?kB;� ⒍�b��5���V��oM�a�����i���A7ͥ�^��8k�pֲ�E8�p�fު\\uO��!��\'�pF�/��76ֳߣqoQөN]�K�3��NޓV�;���h��4gq��1�^�umw��ؾ�1\n��F�)b�s�W\nk�����V��)�Æ�ެ�>�6W�u	�;^�n-��t��t�NK�MԒO�u��xs�6a�y�ix��=��,K��JU�׫)U�iG�ɂ^$�?�n_+�>�K��3����ն���N��|$e�W�5�ZҋQ�j���՘�^����n�l���6��\0�F��u���;�\0�����3z1���KX�n����gS\r��zf�mԷ��S�8vK^�g����\r��\"�W��;:vT*\\8������%��#�Ik�OU��hj�1�cY[����>�\r��*�u�W��V�������1���#�^�[�zpT��~ޝ���)M7�9��E͓��ټ�����Qݥ��IP����ľ�⨤��H߈z�Z�ԧ��w��m�ӯ�ӭ4������k�����G����{ݠf��Y�zҥVzQ���i�#ڞ���FL˷��k᭮-2��h��T4߂���ׄ�KM5⢛�OE5r����}O���-�%I�Fڼ�����M������=IS�����.^�l��e�F�ҌiR��#���^���w/�X~��`�M�;[+x[�т�4��%�G�-�\nq��p|�$���A#t��ɀ��*�ʞ�0�Φ��ڌ���TK��-}k��M����ﲜ�[,g��\r��&��֝X���p�{ѾG^\\\Z�<�yٖG�N<=e\\7���N�f��\r�KM�>��#�uh�.f�Փ��T�x�q-7�Y\\΋�]R�|W����Ut�����Wk�����t��	;3�����n��S̘�[u$ڷU!wB�슨�O<��a�Q`[���=�������a���5�㙒�X�a�/q+��{��6�7��Ӹ�;�鴭�c��̛�N�W���%[X��-=t����\\͂�/C[a�R��d���˚OyR��T-�n�$��R�]��{-e�+*���0<*���N4�е�\ZT��IF).I/ �y���؞���������,5��.��ԓ�RQM�-yF/E�;Ӄ�\n۶S��2��ᗩKҋM�e+v�y�?�mp�d�8jR���Mx���ݧ!�5hñ|��V�q;K�?���V�H�uhԋ�OF�h�9W��I<���\"�h5.�B\nx��;��+�R�r�6e�n��$ۜl喣OI*x��UowMvon�5�5$�m$��}�Se��2���R�ݿ[J�N����E?�C^�6��ͣmb��!��}�Ώ\n4�OJT�w ��|�S\'�O诙v�\0�h_�Z�Y��6���_�~����u��.N\\���L͟z\Zʗ��,ۊ⹺��F��J��Z}�)��x���L��w.�Yb��vxu�(P���\Zt�Er�c�]ê�����l���������B�V��N)(�w$�5��q�&Vk�.E������·�7���sNu�s��d�(���J���J3m�\'ɮ��\Z������-n�%�_P�$�Qm��b�6e��������s�B֭���n�T��SM^���Z��\ZH�U#�	G�h�S\'l�\'(�6����Q\n:0p���}����&�v�ѿ\'t�°�=bX͕�q+�/�J���֛�9��;��c��ul_g����1�*��}J��w����S��T�x���=\Z%�	$�$�����\0L7�I������ā��4+�ZKu��Ip��\0�F�����~v���b�YƎ#�\\;��vw�Уh��S�).	s�㯈@Þ�$�-��I-ka\Zw���-z#s���}%�Ŭ8kǜ���N�y#��͸d\\W�����w��U������t�鯅�=OE�m�eݺd��<�y���.)\\Nx}XB��6�ts��O^:�Ȅ�i	��e��©��Q��mK]�`��C`��i\\�f|�*���O��T������%K�G+�u+V�^�+g=)C~��N�Ei��\\��D oOn��%���f�MK��V;�І�J�%sN\\�i$��؀4k\\�\\B�\n�m�О�\'	8�O�k�i�W��G�7xv�1���Z��O��5����=1�o.pK(a��5��I|̿�sT5t�.��I��=mtO��go��C��mo2F���sӍ��߮�OO͙�x�`��-+:N����Uӆ�9ը���Z�ųf�>�wGK�w�X�q��\r&��:�5�&�ф��I>�x>�ٟb[؎%�M��M�1����^����jB��\\�M��J\n)M�56�$5�\":Z�7ǲ�N���\Z�q�<�2�Z4�x3F9S��9�	�vT�:إ�H$��9���|�z���U��\0�-�Q�X����L�G2(���{�,.�в%�jf���[T��#m����\\S�K�����r�(��N��V�U*�*��d�7�^��I��5ß_��0��z�gmӖ#�r��d������/�ގ2k��5�k���_/a?1����(:q�{iJ�hǺr��W�v������o>fk�b�)Ɯ�\'�iE�P�(��\'�ϡK�%^R��\'J�~�0�s�]�UR���?C{bY\"��-�kb9��R��*6�K�t��r�_Z?�o�K0m�6���Ǆգ��и�R�c�N2�P����mz��Nٶ�\nN��$�QO�K�p\\�8Fg��S��lhZZQ��J���\\�K�.��w�Y \0�\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\r�Y$��|Wy�\0�M��8�L�7�O�vV�/�3��#���r��U�nS�WE�_a˖�3�J���R�J�kR���[��%֟4��[ZU�S^Zpf,��6�*���4ª\\�z���ڬ�r���KO56����̊�Q�Ӱ�wҲ��];77���yXB�8T�Z��I\')NO�l���=z+)����s�O�7zy�!�2F}��Ҥnr~��;�{�����֚��i��Oj!t�w�Xc�{g�v+	Z���0��zUr|�X�1I7�z�zp�a)J�Z��o���e��i9R��Z�H�#�H\0%\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0��\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0');
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
INSERT INTO `vehiculotipo` VALUES (1,'AUTOMÓVIL'),(2,'CAMIONETA'),(3,'JEEPETA'),(4,'OTROS'),(5,'MOTOCICLETA');
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
