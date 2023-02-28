/*Table structure for table `tbl_modulos` */

DROP TABLE IF EXISTS `tbl_modulos`;

create table `tbl_modulos` ( 
   
`fld_id_doc` int(11) NOT NULL AUTO_INCREMENT , 
   
`fld_taller` varchar(15) DEFAULT 'False' , 
   
`fld_nomina` varchar(15) DEFAULT 'False' , 
   
`fld_empenos` varchar(15) DEFAULT 'False' , 
   
`fld_cedula` varchar(15) DEFAULT 'False' , 
   
`fld_restaurant` varchar(15) DEFAULT '0' , 
   
PRIMARY KEY (`fld_id_doc`)
 
)ENGINE=MyISAM DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_agenda`;

CREATE TABLE `tbl_agenda` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_nombre` varchar(150) default NULL,
  `fld_celular` varchar(15) default NULL,
  `fld_trabajo` varchar(15) default NULL,
  `fld_casa` varchar(15) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_ajuste_inventario` */

DROP TABLE IF EXISTS `tbl_ajuste_inventario`;

CREATE TABLE `tbl_ajuste_inventario` (
  `fld_id_ei` int(11) NOT NULL auto_increment,
  `fld_fecha_ei` date default NULL,
  `fld_user_ei` text,
  `fld_concepto_ei` varchar(500) default NULL,
  `fld_importes_ei` double(12,2) default NULL,
  `fld_almacen_ei` text,
  PRIMARY KEY  (`fld_id_ei`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_ajuste_inventario_detalle` */

DROP TABLE IF EXISTS `tbl_ajuste_inventario_detalle`;

CREATE TABLE `tbl_ajuste_inventario_detalle` (
  `fld_Id_doc_ei` int(11) NOT NULL auto_increment,
  `fldProductID_ei` text,
  `fldDescription_ei` text,
  `fldId_ei` int(11) default '0',
  `fldQuantity_ei` double(12,2) default NULL,
  `fldCost_ei` double(12,6) default NULL,
  `fld_Importe_ei` double(12,2) default NULL,
  `fldEstado_ei` varchar(60) default NULL,
  `fldReferencia_ei` text,
  PRIMARY KEY  (`fld_Id_doc_ei`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_ajuste_inventario_detalle_tmp` */

DROP TABLE IF EXISTS `tbl_ajuste_inventario_detalle_tmp`;

CREATE TABLE `tbl_ajuste_inventario_detalle_tmp` (
  `fld_Id_doc_ei` int(11) NOT NULL auto_increment,
  `fldProductID_ei` text,
  `fldDescription_ei` text,
  `fldId_ei` int(11) default '0',
  `fldQuantity_ei` int(11) default '0',
  `fldCost_ei` double(12,6) default NULL,
  `fld_Importe_ei` double(12,2) default NULL,
  `fldEstado_ei` varchar(180) default NULL,
  `fldReferencia_ei` text,
  PRIMARY KEY  (`fld_Id_doc_ei`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_almacen` */

DROP TABLE IF EXISTS `tbl_almacen`;

CREATE TABLE `tbl_almacen` (
  `fldId` int(11) NOT NULL auto_increment,
  `fldDescripcion` varchar(150) default NULL,
  PRIMARY KEY  (`fldId`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_bancos` */

DROP TABLE IF EXISTS `tbl_bancos`;

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

/*Table structure for table `tbl_beneficiarios` */

DROP TABLE IF EXISTS `tbl_beneficiarios`;

CREATE TABLE `tbl_beneficiarios` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_beneficiario` varchar(300) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_canjeo_puntos` */

DROP TABLE IF EXISTS `tbl_canjeo_puntos`;

CREATE TABLE `tbl_canjeo_puntos` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_id_del_cliente` int(11) default NULL,
  `fld_puntos_acumulados` double(12,2) default NULL,
  `fld_puntos_canjeados` double(12,2) default NULL,
  `fld_puntos_acumulados_bce` double(12,2) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_catalogo_cta` */

DROP TABLE IF EXISTS `tbl_catalogo_cta`;

CREATE TABLE `tbl_catalogo_cta` (
  `FLD_ID` int(11) NOT NULL auto_increment,
  `FLD_CUENTA_NO` varchar(50) default NULL,
  `FLD_DESCRIPCION_CTA` varchar(75) default NULL,
  `FLD_ORIGEN` varchar(50) default NULL,
  `FLD_GRUPO` varchar(50) default NULL,
  `FLD_TIPO` varchar(50) default NULL,
  `FLD_CTA_CONTROL` varchar(120) default NULL,
  `FLD_DEBITO` double(12,2) default '0.00',
  `FLD_CREDITO` double(12,2) default '0.00',
  `FLD_BALANCE` double(12,2) default '0.00',
  `FLD_CREADA` varchar(75) default NULL,
  `FLD_FECHA_CREADA` datetime default NULL,
  `FLD_STATUS_CTA` varchar(2) default NULL,
  `FLD_BCE_ANTERIOR` double(12,2) default NULL,
  `fld_bce_enero` double(12,2) default NULL,
  `fld_bce_gral` varchar(11) default NULL,
  `fld_estado_resultado` varchar(11) default NULL,
  `fld_orden_er` varchar(11) default NULL,
  `fld_accion_er` varchar(11) default NULL,
  PRIMARY KEY  (`FLD_ID`),
  KEY `FLD_ID` (`FLD_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=182 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_categorias_productos` */

DROP TABLE IF EXISTS `tbl_categorias_productos`;

CREATE TABLE `tbl_categorias_productos` (
  `fldId` int(10) NOT NULL auto_increment,
  `fldDescripcion` varchar(50) default NULL,
  PRIMARY KEY  (`fldId`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_check_in_out` */

DROP TABLE IF EXISTS `tbl_check_in_out`;

CREATE TABLE `tbl_check_in_out` (
  `fld_id_c_o` int(11) NOT NULL auto_increment,
  `fld_fecha` datetime default NULL,
  `fld_id_empleado` int(11) default NULL,
  `fld_tipo` varchar(255) default NULL,
  `t_1_hasta_ch` datetime default NULL,
  `t_2_hasta_ch` datetime default NULL,
  `t_2_desde_ch` datetime default NULL,
  `t_1_desde_ch` datetime default NULL,
  PRIMARY KEY  (`fld_id_c_o`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_cheques` */

DROP TABLE IF EXISTS `tbl_cheques`;

CREATE TABLE `tbl_cheques` (
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

/*Table structure for table `tbl_cheques_trans` */

DROP TABLE IF EXISTS `tbl_cheques_trans`;

CREATE TABLE `tbl_cheques_trans` (
  `fld_id_doc_ck_trans` int(11) NOT NULL auto_increment,
  `fld_id_conciliacion_ck` int(11) default NULL,
  `fld_no_ck` text,
  `fld_fecha_ck` date default NULL,
  `fld_monto_ck` double(12,2) default NULL,
  PRIMARY KEY  (`fld_id_doc_ck_trans`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_cierre_caja` */

DROP TABLE IF EXISTS `tbl_cierre_caja`;

CREATE TABLE `tbl_cierre_caja` (
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
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_ciudad` */

DROP TABLE IF EXISTS `tbl_ciudad`;

CREATE TABLE `tbl_ciudad` (
  `id` int(11) NOT NULL auto_increment,
  `fld_descripcion` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Table structure for table `tbl_clientes` */

DROP TABLE IF EXISTS `tbl_clientes`;

CREATE TABLE `tbl_clientes` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_cod_personalizado` varchar(255) default NULL,
  `fld_FirstName` varchar(765) default NULL,
  `fld_LastName1` varchar(765) default NULL,
  `fld_LastName2` varchar(765) default NULL,
  `fld_Identity` varchar(765) default NULL,
  `fld_Phone` varchar(765) default NULL,
  `fld_Address` varchar(765) default NULL,
  `fld_Barrio` text,
  `fld_City` varchar(765) default NULL,
  `fld_Status` varchar(765) default NULL,
  `FLD_ESTADO_CIVIL` varchar(60) default NULL,
  `FLD_SEXO` varchar(33) default NULL,
  `fld_bce` double(11,2) default NULL,
  `fld_clasificacion` varchar(150) default NULL,
  `fld_ventas` text,
  `fld_cod_zona` int(11) default NULL,
  `fld_zona` text,
  `fld_dia_cobro1` text,
  `fld_dia_cobro2` text,
  `fld_referencia` varchar(100) default NULL,
  `fld_limite_cr` double(12,2) default NULL,
  `fld_created` date default NULL,
  `fld_cta_contable` varchar(45) default NULL,
  PRIMARY KEY  (`fld_id`),
  KEY `fld_cod_personalizado` (`fld_cod_personalizado`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_cod_ck` */

DROP TABLE IF EXISTS `tbl_cod_ck`;

CREATE TABLE `tbl_cod_ck` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_cuenta_no` varchar(255) default NULL,
  `fld_ck_no` int(11) default NULL,
  PRIMARY KEY  (`fld_id`),
  FULLTEXT KEY `idx_cta_no` (`fld_cuenta_no`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_cod_conduces` */

DROP TABLE IF EXISTS `tbl_cod_conduces`;

CREATE TABLE `tbl_cod_conduces` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_fact_credito` double(11,0) default NULL,
  `fld_fact_contado` double(12,0) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_cod_cotizaciones` */

DROP TABLE IF EXISTS `tbl_cod_cotizaciones`;

CREATE TABLE `tbl_cod_cotizaciones` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_fact_credito` double(11,0) default NULL,
  `fld_fact_contado` double(12,0) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_cod_fact` */

DROP TABLE IF EXISTS `tbl_cod_fact`;

CREATE TABLE `tbl_cod_fact` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_fact_credito` double(11,0) default NULL,
  `fld_fact_contado` double(12,0) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_cod_fact_dev` */

DROP TABLE IF EXISTS `tbl_cod_fact_dev`;

CREATE TABLE `tbl_cod_fact_dev` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_fact_credito` double(11,0) default NULL,
  `fld_fact_contado` double(12,0) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_cod_ncf` */

DROP TABLE IF EXISTS `tbl_cod_ncf`;

CREATE TABLE `tbl_cod_ncf` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_tipo` varchar(255) default NULL,
  `fld_fecha_creacion` date default NULL,
  `fld_prefijo` varchar(255) default NULL,
  `fld_ncf_inicia` double(11,0) default NULL,
  `fld_ncf_finaliza` double(11,0) default NULL,
  `fld_ncf_secuencia_actual` double(11,0) default NULL,
  `fld_status` varchar(25) default NULL,
  `fld_usuario` int(11) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_cod_recepcion` */

DROP TABLE IF EXISTS `tbl_cod_recepcion`;

CREATE TABLE `tbl_cod_recepcion` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_fact_credito` int(11) default NULL,
  `fld_fact_contado` int(11) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_compras_salida_caja` */

DROP TABLE IF EXISTS `tbl_compras_salida_caja`;

CREATE TABLE `tbl_compras_salida_caja` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_fecha` date default NULL,
  `fld_concepto` longtext,
  `fld_proveedor` text,
  `fld_fact_proveedor` text,
  `fld_monto` decimal(10,2) default NULL,
  `fld_user` char(30) default NULL,
  PRIMARY KEY  (`fld_id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_conciliacion` */

DROP TABLE IF EXISTS `tbl_conciliacion`;

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

/*Table structure for table `tbl_conduce` */

DROP TABLE IF EXISTS `tbl_conduce`;

CREATE TABLE `tbl_conduce` (
  `fldInvoiceID` int(11) NOT NULL auto_increment,
  `fld_fact_no_contado` int(11) default '0',
  `fld_fact_no_credito` int(11) default '0',
  `fldInvDate` date default NULL,
  `fld_dias_vencimiento` int(11) default NULL,
  `fldCondicion` text,
  `fldCliente` int(11) default NULL,
  `fldUserID` text,
  `fldSubTotal` double(11,2) default NULL,
  `fldDescuento` double(11,2) default NULL,
  `fldItbis` double(11,2) default NULL,
  `fldImporte` double(11,2) default NULL,
  `fldAlmacen` varchar(550) default NULL,
  `fldStatus` varchar(180) default NULL,
  `fld_cobrado_con` double(12,2) default NULL,
  `fldAbono` double(12,2) default NULL,
  `fldBalance` double(12,2) default NULL,
  `fld_cliente_contado` varchar(765) default NULL,
  `fld_id_medico` int(11) default NULL,
  `fld_ultimo_abono` decimal(10,2) default NULL,
  `fld_by` text,
  `fld_fact_afectada` int(11) default NULL,
  PRIMARY KEY  (`fldInvoiceID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_conduce_detalle_tmp` */

DROP TABLE IF EXISTS `tbl_conduce_detalle_tmp`;

CREATE TABLE `tbl_conduce_detalle_tmp` (
  `fld_Id` int(11) NOT NULL auto_increment,
  `fldProductID` text,
  `fldDescription` text,
  `fldVentaIDContado` int(11) default '0',
  `fldVentaIDCredito` int(11) default NULL,
  `fldQuantity` double(12,2) default NULL,
  `fldPrice` double(12,2) default NULL,
  `fldCost` double(12,6) default NULL,
  `fld_Importe` double(11,2) default NULL,
  `fldDescuentoTotal` double(12,2) default NULL,
  `fldImporteNeto` double(12,2) default NULL,
  `fldEstado` varchar(60) default NULL,
  `fldReferencia` text,
  `fld_itbis` double(12,2) default NULL,
  `fld_cr` varchar(50) default NULL,
  `fld_dr` varchar(50) default NULL,
  `fld_id_de_la_dev` int(11) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_cotizaciones` */

DROP TABLE IF EXISTS `tbl_cotizaciones`;

CREATE TABLE `tbl_cotizaciones` (
  `fldInvoiceID` int(11) NOT NULL auto_increment,
  `fld_ncf_facturas` varchar(255) default NULL,
  `fld_fact_no_contado` int(11) default '0',
  `fld_fact_no_credito` int(11) default '0',
  `fldInvDate` date default NULL,
  `fld_dias_vencimiento` int(11) default NULL,
  `fldCondicion` text,
  `fldCliente` int(11) default NULL,
  `fldUserID` text,
  `fldSubTotal` double(11,2) default NULL,
  `fldDescuento` double(11,2) default NULL,
  `fldItbis` double(11,2) default NULL,
  `fldImporte` double(11,2) default NULL,
  `fldAlmacen` text,
  `fldStatus` varchar(60) default NULL,
  `fld_cobrado_con` double(12,2) default NULL,
  `fldAbono` double(12,2) default NULL,
  `fldBalance` double(12,2) default NULL,
  `fld_cliente_contado` varchar(255) default NULL,
  `fld_cliente_contado_direccion` text,
  `fld_id_medico` int(11) default NULL,
  `fld_ultimo_abono` double(12,2) default NULL,
  `fld_by` text,
  `fld_cod_zona_fact` int(11) default NULL,
  `fld_fecha_vende` date default NULL,
  `fld_orden_no` varchar(255) default NULL,
  `fld_nota_observacion` varchar(500) default NULL,
  `fld_hora` varchar(30) default NULL,
  PRIMARY KEY  (`fldInvoiceID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_cotizaciones_detalle` */

DROP TABLE IF EXISTS `tbl_cotizaciones_detalle`;

CREATE TABLE `tbl_cotizaciones_detalle` (
  `fld_Id` int(11) NOT NULL auto_increment,
  `fldProductID` varchar(255) default NULL,
  `fldDescription` varchar(255) default NULL,
  `fldVentaIDContado` int(11) default '0',
  `fldVentaIDCredito` int(11) default NULL,
  `fldQuantity` decimal(12,2) default NULL,
  `fldPrice` decimal(12,2) default NULL,
  `fldCost` decimal(12,2) default NULL,
  `fld_Importe` decimal(12,2) default NULL,
  `fldEstado` varchar(20) default NULL,
  `fldImporteNeto` decimal(12,2) default NULL,
  `fldDescuentoTotal` decimal(12,2) default NULL,
  `fldReferencia` text,
  `fld_itbis` decimal(12,2) default NULL,
  `fldSerieCell` text,
  `fld_precio_ventas` decimal(12,2) default NULL,
  `fld_dr` varchar(50) default NULL,
  `fld_cr` varchar(50) default NULL,
  `fld_id_de_la_factura_venta` int(11) default NULL,
  `fld_art_vece` varchar(11) default NULL,
  `fld_desc_vencimiento` int(11) default NULL,
  `fldQuantity_bce` double(12,2) default NULL,
  `fld_id_mesa` int(11) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_cotizaciones_detalle_tmp` */

DROP TABLE IF EXISTS `tbl_cotizaciones_detalle_tmp`;

CREATE TABLE `tbl_cotizaciones_detalle_tmp` (
  `fld_Id` int(11) NOT NULL auto_increment,
  `fldProductID` text,
  `fldDescription` text,
  `fldVentaIDContado` int(11) default '0',
  `fldVentaIDCredito` int(11) default NULL,
  `fldQuantity` decimal(12,2) default NULL,
  `fldPrice` decimal(12,2) default NULL,
  `fldCost` decimal(12,2) default NULL,
  `fld_Importe` decimal(12,2) default NULL,
  `fldEstado` varchar(20) default NULL,
  `fldImporteNeto` decimal(12,8) default NULL,
  `fldDescuentoTotal` decimal(12,2) default NULL,
  `fldReferencia` text,
  `fld_itbis` decimal(12,8) default NULL,
  `fldSerieCell` text,
  `fld_precio_ventas` double(12,2) default NULL,
  `fld_dr` varchar(50) default NULL,
  `fld_cr` varchar(50) default NULL,
  `fld_id_de_la_factura_venta` int(11) default NULL,
  `fld_art_vece` varchar(11) default NULL,
  `fld_desc_vencimiento` int(11) default NULL,
  `fldQuantity_bce` double(12,2) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_cuadre_caja` */

DROP TABLE IF EXISTS `tbl_cuadre_caja`;

CREATE TABLE `tbl_cuadre_caja` (
  `fld_id_cc` int(11) NOT NULL auto_increment,
  `fld_fecha` date default NULL,
  `fld_detalle_venta_contado` text,
  `fld_monto_venta_contado` double(12,2) default '0.00',
  `fld_detalle_venta_credito` text,
  `fld_monto_venta_credito` double(12,2) default '0.00',
  `fld_detalle_recibo_ingreso` text,
  `fld_monto_recibo_ingreso` double(12,2) default '0.00',
  `fld_detalle_salida_caja` text,
  `fld_monto_salida_caja` double(12,2) default '0.00',
  `fld_detalle_ventas_nulas_contado` text,
  `fld_monto_ventas_nulas_contado` double(12,2) default '0.00',
  `fld_detalle_ventas_nulas_credito` text,
  `fld_monto_ventas_nulas_credito` double(12,2) default '0.00',
  `fld_detalle_ingreso_caja` text,
  `fld_monto_ingreso_caja` double(12,2) default '0.00',
  `fld_detalle_dev_ventas_credito` text,
  `fld_monto_dev_ventas_credito` double(12,2) default '0.00',
  `fld_detalle_dev_ventas_contado` text,
  `fld_monto_dev_ventas_contado` double(12,2) default '0.00',
  `fld_doc_afectado_dev_credito` text,
  `fld_doc_afectado_dev_contado` text,
  `fld_user` char(30) default NULL,
  PRIMARY KEY  (`fld_id_cc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_deposito` */

DROP TABLE IF EXISTS `tbl_deposito`;

CREATE TABLE `tbl_deposito` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_id_banco` text,
  `fld_fecha` date default NULL,
  `fld_descripcion` varchar(255) default NULL,
  `fld_monto` double(11,2) default NULL,
  `fld_estado` text,
  `fld_transito` text,
  `fld_cod_concepto` varchar(11) default NULL,
  PRIMARY KEY  (`fld_id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_deposito_trans` */

DROP TABLE IF EXISTS `tbl_deposito_trans`;

CREATE TABLE `tbl_deposito_trans` (
  `fld_id_doc_dep_trans` int(11) NOT NULL auto_increment,
  `fld_id_conciliacion_dep` int(11) default NULL,
  `fld_no_dep` text,
  `fld_fecha_dep` date default NULL,
  `fld_monto_dep` double(12,2) default NULL,
  PRIMARY KEY  (`fld_id_doc_dep_trans`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_detalle_pago_ck` */

DROP TABLE IF EXISTS `tbl_detalle_pago_ck`;

CREATE TABLE `tbl_detalle_pago_ck` (
  `fld_id_detalle` int(11) NOT NULL auto_increment,
  `fld_cod_doc` int(11) default NULL,
  `fld_ck_id` int(11) default NULL,
  `fld_bce` decimal(10,2) default NULL,
  `fld_abono` decimal(10,2) default NULL,
  `fld_nuevo_bce` decimal(10,2) default NULL,
  `fld_tipo` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id_detalle`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_empenos` */

DROP TABLE IF EXISTS `tbl_empenos`;

CREATE TABLE `tbl_empenos` (
  `fld_id_emp` int(11) NOT NULL auto_increment,
  `fld_fecha_emp` datetime default NULL,
  `fld_condicion_emp` varchar(15) default NULL,
  `fld_fecha_inicia_emp` datetime default NULL,
  `fld_fecha_termina_emp` datetime default NULL,
  `fld_codigo_cliente_emp` int(11) default '0',
  `fld_codigo_productos_emp` int(11) default '0',
  `fld_capital_emp` double(12,2) default '0.00',
  `fld_cant_cuotas_emp` double(12,2) default '0.00',
  `fld_monto_cuota_emp` double(12,2) default '0.00',
  `fld_interes_emp` double(12,2) default '0.00',
  `fld_monto_emp` double(12,2) default '0.00',
  `fld_abono_emp` double(12,2) default '0.00',
  `fld_balance_emp` double(12,2) default '0.00',
  `fld_nota_emp` varchar(500) default 'n/a',
  `fld_usuario_emp` varchar(255) default 'n/a',
  PRIMARY KEY  (`fld_id_emp`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_empenos_cuotas` */

DROP TABLE IF EXISTS `tbl_empenos_cuotas`;

CREATE TABLE `tbl_empenos_cuotas` (
  `fld_id_cuota` int(11) NOT NULL auto_increment,
  `fld_no_cuota` varchar(5) default NULL,
  `fld_id_emp_cuota` int(11) default '0',
  `fld_fecha_entrega_cuota` date default NULL,
  `fld_fecha_termina_cuota` date default NULL,
  `fld_capital_cuota` double(12,2) default '0.00',
  `fld_monto_cuota` double(12,2) default '0.00',
  `fld_abono_cuota` double(12,2) default '0.00',
  `fld_balance_cuota` double(12,2) default '0.00',
  PRIMARY KEY  (`fld_id_cuota`)
) ENGINE=MyISAM AUTO_INCREMENT=51 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_empleados` */

DROP TABLE IF EXISTS `tbl_empleados`;

CREATE TABLE `tbl_empleados` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_empleado` varchar(255) default NULL COMMENT 'Empleado',
  `fld_fecha_nacimiento` date default NULL COMMENT 'Fecha Nacimiento',
  `fld_sexo` varchar(100) default NULL,
  `fld_estado_civil` varchar(15) default NULL,
  `fld_cedula` varchar(15) default NULL,
  `fld_tipificacion` varchar(5) default NULL,
  `fld_direccion` varchar(255) default NULL,
  `fld_ciudad` varchar(50) default NULL,
  `fld_telefonos` varchar(255) default NULL,
  `fld_tipo_empleado` varchar(10) default NULL,
  `fld_departamento` varchar(25) default NULL,
  `fld_sueldo_mensual` double(12,2) default NULL,
  `fld_afp` double(12,2) default NULL,
  `fld_ars` double(12,2) default NULL,
  `fld_seguro_social` varchar(255) default NULL,
  `t_1_desde` datetime default NULL,
  `t_1_hasta` datetime default NULL,
  `t_2_desde` datetime default NULL,
  `t_2_hasta` datetime default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_entrada_diarias` */

DROP TABLE IF EXISTS `tbl_entrada_diarias`;

CREATE TABLE `tbl_entrada_diarias` (
  `fld_Entrada_ID` int(11) NOT NULL auto_increment,
  `FLD_DATE_ENTRADA` date default NULL,
  `fld_user` varchar(50) default NULL,
  `fld_acentada` varchar(4) default NULL,
  `fld_tipo_entrada` varchar(100) default NULL,
  `FLD_STATUS_ENTRADA` varchar(2) default NULL,
  `FLD_VER_EN_INTERFACE` varchar(11) default NULL,
  `FLD_DOC_AFECTADO` text,
  `FLD_DETALLE1` text,
  `FLD_DETALLE2` text,
  `fld_monto` double(10,2) default NULL,
  `FLD_CTA_DEBITO` text,
  `FLD_CTA_CREDITO` text,
  `FLD_DOC_MIXTO` text,
  `fld_id` int(11) default NULL,
  PRIMARY KEY  (`fld_Entrada_ID`),
  KEY `fld_Entrada_ID` (`fld_Entrada_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_entrada_inventario` */

DROP TABLE IF EXISTS `tbl_entrada_inventario`;

CREATE TABLE `tbl_entrada_inventario` (
  `fld_id_ei` int(11) NOT NULL auto_increment,
  `fld_fecha_ei` date default NULL,
  `fld_user_ei` text,
  `fld_concepto_ei` varchar(500) default NULL,
  `fld_importes_ei` double(12,2) default NULL,
  `fld_almacen_ei` text,
  PRIMARY KEY  (`fld_id_ei`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_entrada_inventario_detalle` */

DROP TABLE IF EXISTS `tbl_entrada_inventario_detalle`;

CREATE TABLE `tbl_entrada_inventario_detalle` (
  `fld_Id_doc_ei` int(11) NOT NULL auto_increment,
  `fldProductID_ei` text,
  `fldDescription_ei` text,
  `fldId_ei` int(11) default '0',
  `fldQuantity_ei` double(12,2) default NULL,
  `fldCost_ei` double(12,6) default NULL,
  `fld_Importe_ei` double(12,2) default NULL,
  `fldEstado_ei` varchar(60) default NULL,
  `fldReferencia_ei` text,
  `fld_presentacion` varchar(255) default NULL,
  `fld_und_vendidas` double(12,2) default NULL,
  PRIMARY KEY  (`fld_Id_doc_ei`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_entrada_inventario_detalle_tmp` */

DROP TABLE IF EXISTS `tbl_entrada_inventario_detalle_tmp`;

CREATE TABLE `tbl_entrada_inventario_detalle_tmp` (
  `fld_Id_doc_ei` int(11) NOT NULL auto_increment,
  `fldProductID_ei` text,
  `fldDescription_ei` text,
  `fldId_ei` int(11) default '0',
  `fldQuantity_ei` int(11) default '0',
  `fldCost_ei` double(12,6) default NULL,
  `fld_Importe_ei` double(12,2) default NULL,
  `fldEstado_ei` varchar(180) default NULL,
  `fldReferencia_ei` text,
  `fld_presentacion` varchar(255) default NULL,
  `fld_und_vendidas` double(12,2) default NULL,
  PRIMARY KEY  (`fld_Id_doc_ei`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_estaciones` */

DROP TABLE IF EXISTS `tbl_estaciones`;

CREATE TABLE `tbl_estaciones` (
  `id` int(11) NOT NULL auto_increment,
  `fld_estacion` varchar(255) default NULL,
  `fld_num_fact_temp` int(11) default NULL,
  `fld_num_recepcion_temp` int(11) default NULL,
  `fld_num_cotizacion_temp` int(11) default NULL,
  `fld_num_orden_compra_temp` int(11) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_estado_banco` */

DROP TABLE IF EXISTS `tbl_estado_banco`;

CREATE TABLE `tbl_estado_banco` (
  `fld_id_ec_b` int(11) NOT NULL auto_increment,
  `fld_date` date default NULL,
  `fld_description` text,
  `fld_dr` double(11,2) default NULL,
  `fld_cr` double(11,2) default NULL,
  `fld_bce_banco` double(11,2) default NULL,
  `fld_banco_id` text,
  `fld_tipo_doc` text,
  `fld_tipo_doc_id` text,
  `fld_usuario` text,
  PRIMARY KEY  (`fld_id_ec_b`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_estado_clientes` */

DROP TABLE IF EXISTS `tbl_estado_clientes`;

CREATE TABLE `tbl_estado_clientes` (
  `fld_id_ec` int(11) NOT NULL auto_increment,
  `fld_date` date default NULL,
  `fld_description` varchar(255) default NULL,
  `fld_dr` double(11,2) default NULL,
  `fld_cr` double(11,2) default NULL,
  `fld_bce_cliente` double(11,2) default NULL,
  `fld_cliente_id` int(11) default NULL,
  `fld_tipo_doc` text,
  `fld_tipo_doc_id` text,
  `fld_usuario` text,
  PRIMARY KEY  (`fld_id_ec`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_estado_proveedor` */

DROP TABLE IF EXISTS `tbl_estado_proveedor`;

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
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_inv_vencimiento` */

DROP TABLE IF EXISTS `tbl_inv_vencimiento`;

CREATE TABLE `tbl_inv_vencimiento` (
  `FLD_ID_IV` int(11) NOT NULL auto_increment,
  `FLD_PROD_ID` varchar(50) NOT NULL,
  `FLD_CANTIDAD` double(11,2) default NULL,
  `FLD_FECHA_VENCE` date default NULL,
  PRIMARY KEY  (`FLD_ID_IV`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_inv_vencimiento_tmp` */

DROP TABLE IF EXISTS `tbl_inv_vencimiento_tmp`;

CREATE TABLE `tbl_inv_vencimiento_tmp` (
  `FLD_ID_IV` int(11) NOT NULL auto_increment,
  `FLD_PROD_ID` varchar(150) NOT NULL,
  `FLD_CANTIDAD` double(11,2) default NULL,
  `FLD_FECHA_VENCE` date default NULL,
  PRIMARY KEY  (`FLD_ID_IV`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_maestro_concepto` */

DROP TABLE IF EXISTS `tbl_maestro_concepto`;

CREATE TABLE `tbl_maestro_concepto` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_cod_MC` varchar(20) default NULL,
  `fld_concepto_MC` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*Table structure for table `tbl_maestro_medidas` */

DROP TABLE IF EXISTS `tbl_maestro_medidas`;

CREATE TABLE `tbl_maestro_medidas` (
  `fldId` int(10) NOT NULL auto_increment,
  `fldDescripcion` varchar(50) default NULL,
  PRIMARY KEY  (`fldId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_maestro_meseros` */

DROP TABLE IF EXISTS `tbl_maestro_meseros`;

CREATE TABLE `tbl_maestro_meseros` (
  `fldId` int(11) NOT NULL auto_increment,
  `fldDescripcion` varchar(450) default NULL,
  `fldPorciento` int(11) default NULL,
  `fldCelular` text,
  PRIMARY KEY  (`fldId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_maestro_planes` */

DROP TABLE IF EXISTS `tbl_maestro_planes`;

CREATE TABLE `tbl_maestro_planes` (
  `id` int(11) NOT NULL auto_increment,
  `fld_descripcion` varchar(255) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Table structure for table `tbl_maestro_series` */

DROP TABLE IF EXISTS `tbl_maestro_series`;

CREATE TABLE `tbl_maestro_series` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_fecha` date default NULL,
  `fld_concepto` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_maestro_series_detalle` */

DROP TABLE IF EXISTS `tbl_maestro_series_detalle`;

CREATE TABLE `tbl_maestro_series_detalle` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_cod_prod` varchar(255) default NULL,
  `fld_serie` varchar(255) default NULL,
  `fld_fact_compra` int(11) default NULL,
  `fld_fecha_compra` date default NULL,
  `fld_fact_venta` int(11) default NULL,
  `fld_fecha_venta` date default NULL,
  `fld_id_maestro_serie` int(11) default NULL,
  PRIMARY KEY  (`fld_id_doc`),
  KEY `idx_serie` (`fld_serie`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_maestro_vehiculos` */

DROP TABLE IF EXISTS `tbl_maestro_vehiculos`;

CREATE TABLE `tbl_maestro_vehiculos` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_nombre` varchar(150) default NULL,
  `fld_celular` varchar(15) default NULL,
  `fld_trabajo` varchar(15) default NULL,
  `fld_casa` varchar(15) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_maestro_vendedor` */

DROP TABLE IF EXISTS `tbl_maestro_vendedor`;

CREATE TABLE `tbl_maestro_vendedor` (
  `fldId` int(11) NOT NULL auto_increment,
  `fldDescripcion` varchar(450) default NULL,
  `fldCodZona` int(11) default NULL,
  `fldPorciento` int(11) default NULL,
  `fldCelular` text,
  PRIMARY KEY  (`fldId`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_maestro_zonas` */

DROP TABLE IF EXISTS `tbl_maestro_zonas`;

CREATE TABLE `tbl_maestro_zonas` (
  `fldId` int(11) NOT NULL auto_increment,
  `fldDescripcion` varchar(150) default NULL,
  `fld_cod_vendedor` int(11) default NULL,
  `fld_vendedor` text,
  PRIMARY KEY  (`fldId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_marcas` */

DROP TABLE IF EXISTS `tbl_marcas`;

CREATE TABLE `tbl_marcas` (
  `fldID` int(11) NOT NULL auto_increment,
  `fldDescripcion` varchar(150) default NULL,
  PRIMARY KEY  (`fldID`),
  KEY `fldID` (`fldID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_movimiento_inventario` */

DROP TABLE IF EXISTS `tbl_movimiento_inventario`;

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
  `fld_cant_medida_mi` double(12,2) default NULL,
  `fld_medida_mi` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id_mi`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_nc_bancaria` */

DROP TABLE IF EXISTS `tbl_nc_bancaria`;

CREATE TABLE `tbl_nc_bancaria` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_id_banco` text,
  `fld_fecha` date default NULL,
  `fld_descripcion` varchar(2295) default NULL,
  `fld_monto` double(11,2) default NULL,
  `fld_estado` text,
  `fld_transito` text,
  PRIMARY KEY  (`fld_id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_nc_cxc` */

DROP TABLE IF EXISTS `tbl_nc_cxc`;

CREATE TABLE `tbl_nc_cxc` (
  `fld_id_nc_cxc` int(11) NOT NULL auto_increment,
  `fld_cliente_id_nc` int(11) default NULL,
  `fld_fecha` date default NULL,
  `fld_concepto` varchar(765) default NULL,
  `fld_monto` double(12,2) default NULL,
  `fld_user` varchar(150) default NULL,
  `fld_status_nc` text,
  `fld_doc_afectado` text,
  `fld_doc_afectado_id` int(11) default NULL,
  `fld_ncf_nc_cxc` text,
  PRIMARY KEY  (`fld_id_nc_cxc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_nc_cxp` */

DROP TABLE IF EXISTS `tbl_nc_cxp`;

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

/*Table structure for table `tbl_nd_bancaria` */

DROP TABLE IF EXISTS `tbl_nd_bancaria`;

CREATE TABLE `tbl_nd_bancaria` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_id_banco` text,
  `fld_fecha` date default NULL,
  `fld_descripcion` varchar(765) default NULL,
  `fld_monto` double(11,2) default NULL,
  `fld_estado` text,
  `fld_transito` text,
  PRIMARY KEY  (`fld_id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_nd_cxc` */

DROP TABLE IF EXISTS `tbl_nd_cxc`;

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
  `fld_ncf_nd_cxc` text,
  `fld_chk` varchar(45) default NULL,
  PRIMARY KEY  (`fld_id_nd_cxc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_nd_cxp` */

DROP TABLE IF EXISTS `tbl_nd_cxp`;

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

/*Table structure for table `tbl_orden_compra` */

DROP TABLE IF EXISTS `tbl_orden_compra`;

CREATE TABLE `tbl_orden_compra` (
  `fldInvoiceID` int(11) NOT NULL auto_increment,
  `fld_ncf_costos` text,
  `fldInvDate` date default NULL,
  `fld_dias_vencimiento` int(11) default NULL,
  `fldCondicion` text,
  `fldSupplier` int(11) default NULL,
  `fldUserID` text,
  `fldSupplierFact` varchar(255) default NULL,
  `fldOrdenNo` int(11) default NULL,
  `fldSubTotal` double(11,2) default NULL,
  `fldItbis` double(11,2) default NULL,
  `fldImporte` double(11,2) default NULL,
  `fldDescuento` double(11,2) default NULL,
  `fldFlete` double(11,2) default NULL,
  `fldMontoFact` double(11,2) default NULL,
  `fldStatus` varchar(20) default NULL,
  `fldAbono` double(12,2) default NULL,
  `fld_Balance` double(12,2) default NULL,
  `fldActAux` varchar(2) default NULL,
  `fldFechaFactProv` date default NULL,
  `fldAlmacen` varchar(100) default NULL,
  `fld_fact_no_credito` int(11) default NULL,
  `fld_fact_no_contado` int(11) default NULL,
  `fld_fecha_vence` date default NULL,
  `fld_dias_vencido` int(11) default '0',
  `fld_proveedor_nombre` varchar(500) default NULL,
  `fld_ultimo_abono` double(12,2) default NULL,
  `fld_chk` varchar(45) default NULL,
  PRIMARY KEY  (`fldInvoiceID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_orden_compra_detalle` */

DROP TABLE IF EXISTS `tbl_orden_compra_detalle`;

CREATE TABLE `tbl_orden_compra_detalle` (
  `fld_Id` int(11) NOT NULL auto_increment,
  `fldProductID` varchar(150) default NULL,
  `fldDescription` varchar(300) default NULL,
  `fldRecepcionID` int(11) default '0',
  `fldOrdenID` int(11) default NULL,
  `fldQuantity` double(12,2) default NULL,
  `fldCost` double(12,4) default NULL,
  `fld_Importe` double(12,2) default NULL,
  `fldEstado` varchar(20) default NULL,
  `fld_Oferta` varchar(45) default NULL,
  `fld_precio1` double(12,2) default NULL,
  `fld_precio2` double(12,2) default NULL,
  `fld_precio3` double(12,2) default NULL,
  `fld_referencias` text,
  `fld_cargos` double(12,2) default NULL,
  `fld_descuento` double(12,2) default NULL,
  `fld_costo_bruto` double(12,2) default NULL,
  `fld_itbis` double(12,2) default NULL,
  `fldSerie` varchar(21000) default NULL,
  `fld_id_estacion` int(11) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_orden_compra_detalle_tmp` */

DROP TABLE IF EXISTS `tbl_orden_compra_detalle_tmp`;

CREATE TABLE `tbl_orden_compra_detalle_tmp` (
  `fld_Id` int(11) NOT NULL auto_increment,
  `fldProductID` varchar(150) default NULL,
  `fldDescription` varchar(300) default NULL,
  `fldRecepcionID` int(11) default '0',
  `fldOrdenID` int(11) default NULL,
  `fldQuantity` double(12,2) default NULL,
  `fldCost` double(12,4) default NULL,
  `fld_Importe` double(12,2) default NULL,
  `fldEstado` varchar(20) default NULL,
  `fld_Oferta` varchar(45) default NULL,
  `fld_precio1` double(12,2) default NULL,
  `fld_precio2` double(12,2) default NULL,
  `fld_precio3` double(12,2) default NULL,
  `fld_referencias` text,
  `fld_cargos` double(12,2) default NULL,
  `fld_descuento` double(12,2) default NULL,
  `fld_costo_bruto` double(12,2) default NULL,
  `fld_itbis` double(12,2) default NULL,
  `fldSerie` varchar(21000) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_otros_ingresos_caja` */

DROP TABLE IF EXISTS `tbl_otros_ingresos_caja`;

CREATE TABLE `tbl_otros_ingresos_caja` (
  `fld_id_doc` int(11) NOT NULL auto_increment,
  `fld_fecha` date default NULL,
  `fld_concepto` longtext,
  `fld_proveedor` text,
  `fld_fact_proveedor` text,
  `fld_monto` decimal(10,2) default NULL,
  `fld_user` char(30) default NULL,
  PRIMARY KEY  (`fld_id_doc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_periodos_contables` */

DROP TABLE IF EXISTS `tbl_periodos_contables`;

CREATE TABLE `tbl_periodos_contables` (
  `fld_id_pc` int(11) NOT NULL auto_increment,
  `fld_fecha_inicia_pc` date default NULL,
  `fld_fecha_termina_pc` date default NULL,
  `fld_estado_pc` varchar(10) default NULL,
  PRIMARY KEY  (`fld_id_pc`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*Table structure for table `tbl_periodos_contables_meses` */

DROP TABLE IF EXISTS `tbl_periodos_contables_meses`;

CREATE TABLE `tbl_periodos_contables_meses` (
  `fld_id_mes_pc` int(11) NOT NULL auto_increment,
  `fld_no_mes_pc` varchar(5) default NULL,
  `fld_fecha_mes_pc` date default NULL,
  `fld_estado_mes_pc` varchar(10) default NULL,
  `fld_id_del_periodo_contable` int(11) default NULL,
  PRIMARY KEY  (`fld_id_mes_pc`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*Table structure for table `tbl_planes_ventas` */

DROP TABLE IF EXISTS `tbl_planes_ventas`;

CREATE TABLE `tbl_planes_ventas` (
  `fld_id_planes` int(11) NOT NULL auto_increment,
  `fld_descripcion` varchar(255) default 'n/a',
  `fld_renta` double(12,2) default '0.00',
  `fld_diferencia` double(12,2) default '0.00',
  `fld_codigo_art` int(11) default '0',
  `fld_usuario` varchar(255) default 'n/a',
  PRIMARY KEY  (`fld_id_planes`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_prestamos` */

DROP TABLE IF EXISTS `tbl_prestamos`;

CREATE TABLE `tbl_prestamos` (
  `fld_id_pres` int(11) NOT NULL auto_increment,
  `fld_fecha_entrega` date default NULL,
  `fld_fecha_termina` date default NULL,
  `fld_monto` double(12,2) default '0.00',
  `fld_abono` double(12,2) default '0.00',
  `fld_balance` double(12,2) default '0.00',
  `fld_interes` double(12,2) default '0.00',
  `fld_monto_cuotas` double(12,2) default '0.00',
  `fld_capital_cuota` double(12,2) default '0.00',
  `fld_cantidad_cuotas` double(12,2) default '0.00',
  `fld_descontar` varchar(5) default 'SI',
  `fld_cod_empleado` int(11) default '0',
  PRIMARY KEY  (`fld_id_pres`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_prestamos_cuotas` */

DROP TABLE IF EXISTS `tbl_prestamos_cuotas`;

CREATE TABLE `tbl_prestamos_cuotas` (
  `fld_id_c` int(11) NOT NULL auto_increment,
  `fld_no_cuotas` varchar(3) default NULL,
  `fld_fecha_entrega_c` date default NULL,
  `fld_fecha_termina_c` date default NULL,
  `fld_capital_c` double(12,2) default '0.00',
  `fld_monto_c` double(12,2) default '0.00',
  `fld_abono_c` double(12,2) default '0.00',
  `fld_balance_c` double(12,2) default '0.00',
  `fld_id_prestamo_c` int(11) default '0',
  `fld_id_empleado_c` int(11) default '0',
  PRIMARY KEY  (`fld_id_c`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_product_label` */

DROP TABLE IF EXISTS `tbl_product_label`;

CREATE TABLE `tbl_product_label` (
  `fld_CodPersonalizado` varchar(255) default NULL,
  `fldDescription` varchar(255) default NULL,
  `fld_title` varchar(255) default NULL,
  `fld_phones` varchar(25) default NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_productos` */

DROP TABLE IF EXISTS `tbl_productos`;

CREATE TABLE `tbl_productos` (
  `ID` int(10) NOT NULL auto_increment,
  `fld_CodPersonalizado` int(11) default NULL,
  `fld_codigo_barra` varchar(55) default NULL,
  `fldDescription` varchar(255) default NULL,
  `fldQuantity` double(12,2) default NULL,
  `fldStatus` varchar(50) default NULL,
  `fldBy` varchar(255) default NULL,
  `fldMedida` varchar(255) default NULL,
  `fldUnidades` varchar(350) default NULL,
  `fldReferencia` varchar(50) default NULL,
  `fldUbicacion` varchar(50) default NULL,
  `fldImpuesto` decimal(12,2) default NULL,
  `fldCost` decimal(12,2) default NULL,
  `fldCost1` decimal(12,2) default NULL,
  `fldCost2` decimal(12,2) default NULL,
  `fldPrice` decimal(12,2) default NULL,
  `fldPrice2` decimal(12,2) default NULL,
  `fldPrice3` decimal(12,2) default NULL,
  `fldPorciento` decimal(12,2) default NULL,
  `fldPorciento2` decimal(12,2) default NULL,
  `fldPorciento3` decimal(12,2) default NULL,
  `fldCategory` varchar(50) default NULL,
  `fldCantidadPedido` int(10) default NULL,
  `fldVendeen0` varchar(50) default NULL,
  `fldTotalEntrada` int(10) default NULL,
  `fldTotalSalida` int(10) default NULL,
  `fldProveedor` varchar(50) default NULL,
  `fldNota` text,
  `fldVence` text,
  `fldSerie` varchar(50) default NULL,
  `fldMarca` text,
  `fldAlmacen` varchar(50) default NULL,
  `fld_Oferta` varchar(3) default NULL,
  `lbImg` text,
  `fld_dr` varchar(50) default NULL,
  `fld_cr` varchar(50) default NULL,
  `fld_proveedor` varchar(255) default NULL,
  `fld_presentacion` varchar(255) default NULL,
  `fld_presentacion1` varchar(255) default 'N/A',
  `fld_presentacion2` varchar(255) default 'N/A',
  `fld_cant_presentacion1` double(12,2) default '0.00',
  `fld_cant_presentacion2` double(12,2) default '0.00',
  `fld_aplica_planes` varchar(25) default 'False',
  PRIMARY KEY  (`ID`),
  KEY `idx_code` (`fld_CodPersonalizado`,`fld_codigo_barra`)
) ENGINE=MyISAM AUTO_INCREMENT=2852 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_productos_empeno` */

DROP TABLE IF EXISTS `tbl_productos_empeno`;

CREATE TABLE `tbl_productos_empeno` (
  `id` int(11) NOT NULL auto_increment,
  `fld_descripcion` varchar(255) default 'n/a',
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_productos_ofertas` */

DROP TABLE IF EXISTS `tbl_productos_ofertas`;

CREATE TABLE `tbl_productos_ofertas` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_cod` text,
  `fld_desp` text,
  `fld_cost` double(12,2) default NULL,
  `fld_cant` double(12,0) default NULL,
  `fld_cod_padre` text,
  `fld_cantidad_sincronizada` text,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_profiledocument` */

DROP TABLE IF EXISTS `tbl_profiledocument`;

CREATE TABLE `tbl_profiledocument` (
  `fldCompanyID` int(11) NOT NULL auto_increment,
  `fldCompany` varchar(50) default NULL,
  `fldAddress` varchar(50) default NULL,
  `fldPhone` varchar(50) default NULL,
  `fldRnc` varchar(50) default NULL,
  `fldPassDescuento` varchar(50) default NULL,
  `fldPassConfig` varchar(50) default NULL,
  `fldPassAdmin` varchar(50) default NULL,
  `fldDiasVenceFC` varchar(50) default NULL,
  `fldColorForm` varchar(255) default NULL,
  `fld_nota_facturas_credito` longtext,
  `fld_nota_facturas_contado` longtext,
  `fld_nota_recibos_ingresos` longtext,
  `fldNotaRecepcion` varchar(255) default NULL,
  PRIMARY KEY  (`fldCompanyID`),
  KEY `fldCompanyID` (`fldCompanyID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_recepcion` */

DROP TABLE IF EXISTS `tbl_recepcion`;

CREATE TABLE `tbl_recepcion` (
  `fldInvoiceID` int(11) NOT NULL auto_increment,
  `fld_ncf_costos` text,
  `fldInvDate` date default NULL,
  `fld_dias_vencimiento` int(11) default NULL,
  `fldCondicion` text,
  `fldSupplier` int(11) default NULL,
  `fldUserID` text,
  `fldSupplierFact` varchar(255) default NULL,
  `fldOrdenNo` int(11) default NULL,
  `fldSubTotal` double(11,2) default NULL,
  `fldItbis` double(11,2) default NULL,
  `fldImporte` double(11,2) default NULL,
  `fldDescuento` double(11,2) default NULL,
  `fldFlete` double(11,2) default NULL,
  `fldMontoFact` double(11,2) default NULL,
  `fldStatus` varchar(20) default NULL,
  `fldAbono` double(12,2) default NULL,
  `fld_Balance` double(12,2) default NULL,
  `fldActAux` varchar(2) default NULL,
  `fldFechaFactProv` date default NULL,
  `fldAlmacen` varchar(100) default NULL,
  `fld_fact_no_credito` int(11) default NULL,
  `fld_fact_no_contado` int(11) default NULL,
  `fld_fecha_vence` date default NULL,
  `fld_dias_vencido` int(11) default '0',
  `fld_proveedor_nombre` varchar(500) default NULL,
  `fld_ultimo_abono` double(12,2) default NULL,
  `fld_chk` varchar(45) default NULL,
  PRIMARY KEY  (`fldInvoiceID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_recepcion_detalle` */

DROP TABLE IF EXISTS `tbl_recepcion_detalle`;

CREATE TABLE `tbl_recepcion_detalle` (
  `fld_Id` int(11) NOT NULL auto_increment,
  `fldProductID` varchar(150) default NULL,
  `fldDescription` varchar(300) default NULL,
  `fldRecepcionID` int(11) default '0',
  `fldOrdenID` int(11) default NULL,
  `fldQuantity` double(12,2) default NULL,
  `fldCost` double(12,4) default NULL,
  `fld_Importe` double(12,2) default NULL,
  `fldEstado` varchar(20) default NULL,
  `fld_Oferta` varchar(45) default NULL,
  `fld_precio1` double(12,2) default NULL,
  `fld_precio2` double(12,2) default NULL,
  `fld_precio3` double(12,2) default NULL,
  `fld_referencias` text,
  `fld_cargos` double(12,2) default NULL,
  `fld_descuento` double(12,2) default NULL,
  `fld_costo_bruto` double(12,2) default NULL,
  `fld_itbis` double(12,2) default NULL,
  `fldSerie` varchar(21000) default NULL,
  `fld_id_estacion` int(11) default NULL,
  `fld_presentacion` varchar(255) default NULL,
  `fld_und_vendidas` double(12,2) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_recepcion_detalle_tmp` */

DROP TABLE IF EXISTS `tbl_recepcion_detalle_tmp`;

CREATE TABLE `tbl_recepcion_detalle_tmp` (
  `fld_Id` int(11) NOT NULL auto_increment,
  `fldProductID` varchar(150) default NULL,
  `fldDescription` varchar(300) default NULL,
  `fldRecepcionID` int(11) default '0',
  `fldOrdenID` int(11) default NULL,
  `fldQuantity` double(12,2) default NULL,
  `fldCost` double(12,2) default NULL,
  `fld_Importe` double(12,2) default NULL,
  `fldEstado` varchar(20) default NULL,
  `fld_Oferta` varchar(45) default NULL,
  `fld_precio1` double(12,2) default NULL,
  `fld_precio2` double(12,2) default NULL,
  `fld_precio3` double(12,2) default NULL,
  `fld_referencias` text,
  `fld_cargos` double(12,2) default NULL,
  `fld_descuento` double(12,2) default NULL,
  `fld_costo_bruto` double(12,2) default NULL,
  `fld_itbis` double(12,2) default NULL,
  `fldSerie` varchar(21000) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_recepcion_dev` */

DROP TABLE IF EXISTS `tbl_recepcion_dev`;

CREATE TABLE `tbl_recepcion_dev` (
  `fldInvoiceID` int(11) NOT NULL auto_increment,
  `fld_ncf_costos` text,
  `fldInvDate` date default NULL,
  `fld_dias_vencimiento` int(11) default NULL,
  `fldCondicion` text,
  `fldSupplier` int(11) default NULL,
  `fldUserID` text,
  `fldSupplierFact` text,
  `fldOrdenNo` int(11) default NULL,
  `fldSubTotal` double(11,2) default NULL,
  `fldItbis` double(11,2) default NULL,
  `fldImporte` double(11,2) default NULL,
  `fldDescuento` double(11,2) default NULL,
  `fldFlete` double(11,2) default NULL,
  `fldMontoFact` double(11,2) default NULL,
  `fldStatus` varchar(60) default NULL,
  `fldAbono` double(12,2) default NULL,
  `fld_Balance` double(12,2) default NULL,
  `fldActAux` varchar(6) default NULL,
  `fldFechaFactProv` date default NULL,
  `fldAlmacen` varchar(300) default NULL,
  `fld_fact_no_credito` int(11) default NULL,
  `fld_fact_no_contado` int(11) default NULL,
  `fld_fecha_vence` date default NULL,
  `fld_dias_vencido` int(11) default '0',
  `fld_fact_afectada` int(11) default NULL,
  PRIMARY KEY  (`fldInvoiceID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_recepcion_dev_detalle` */

DROP TABLE IF EXISTS `tbl_recepcion_dev_detalle`;

CREATE TABLE `tbl_recepcion_dev_detalle` (
  `fld_Id` int(11) NOT NULL auto_increment,
  `fldProductID` varchar(450) default NULL,
  `fldDescription` varchar(900) default NULL,
  `fldRecepcionID` int(11) default '0',
  `fldOrdenID` int(11) default NULL,
  `fldQuantity` int(11) default '0',
  `fldCost` double(12,2) default NULL,
  `fld_Importe` double(12,2) default NULL,
  `fldEstado` varchar(60) default NULL,
  `fld_Oferta` varchar(135) default NULL,
  `fld_precio1` double(12,2) default NULL,
  `fld_precio2` double(12,2) default NULL,
  `fld_precio3` double(12,2) default NULL,
  `fld_referencias` text,
  `fld_cargos` double(12,2) default NULL,
  `fld_descuento` double(12,2) default NULL,
  `fld_costo_bruto` double(12,2) default NULL,
  `fld_itbis` double(12,2) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_recepcion_dev_detalle_tmp` */

DROP TABLE IF EXISTS `tbl_recepcion_dev_detalle_tmp`;

CREATE TABLE `tbl_recepcion_dev_detalle_tmp` (
  `fld_Id` int(11) NOT NULL auto_increment,
  `fldProductID` varchar(450) default NULL,
  `fldDescription` varchar(900) default NULL,
  `fldRecepcionID` int(11) default '0',
  `fldOrdenID` int(11) default NULL,
  `fldQuantity` int(11) default '0',
  `fldCost` double(12,2) default NULL,
  `fld_Importe` double(12,2) default NULL,
  `fldEstado` varchar(60) default NULL,
  `fld_Oferta` varchar(135) default NULL,
  `fld_precio1` double(12,2) default NULL,
  `fld_precio2` double(12,2) default NULL,
  `fld_precio3` double(12,2) default NULL,
  `fld_referencias` text,
  `fld_cargos` double(12,2) default NULL,
  `fld_descuento` double(12,2) default NULL,
  `fld_costo_bruto` double(12,2) default NULL,
  `fld_itbis` double(12,2) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_recibo_ingresos_cxc` */

DROP TABLE IF EXISTS `tbl_recibo_ingresos_cxc`;

CREATE TABLE `tbl_recibo_ingresos_cxc` (
  `fld_Id_RI` int(11) NOT NULL auto_increment,
  `fld_forma_pago` text,
  `fld_detalle_forma_pago` text,
  `fld_id_cliente_ri` int(11) default '0',
  `fld_date` date default NULL,
  `fld_Description` longtext,
  `fld_monto` double(11,2) default NULL,
  `fld_fact_afectado` text,
  `fdl_nd_afectado` text,
  `fld_User` text,
  `fld_Estado` varchar(255) default NULL,
  `fld_nota` longtext,
  `fld_monto_mora` double(12,2) default NULL,
  PRIMARY KEY  (`fld_Id_RI`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*Table structure for table `tbl_recibo_ingresos_cxc_detalle` */

DROP TABLE IF EXISTS `tbl_recibo_ingresos_cxc_detalle`;

CREATE TABLE `tbl_recibo_ingresos_cxc_detalle` (
  `fld_d_ri` int(11) NOT NULL auto_increment,
  `fld_id_doc` int(11) default NULL,
  `fld_ult_abono` double(12,2) default NULL,
  `fld_id_ri_padre` int(11) default NULL,
  `fld_tipo_doc_ri_d` varchar(11) default NULL COMMENT 'F=FACTURA, N=NOTA DEBITO',
  PRIMARY KEY  (`fld_d_ri`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*Table structure for table `tbl_recibo_pago_cxp` */

DROP TABLE IF EXISTS `tbl_recibo_pago_cxp`;

CREATE TABLE `tbl_recibo_pago_cxp` (
  `fld_Id_RI` int(11) NOT NULL auto_increment,
  `fld_forma_pago` text,
  `fld_detalle_forma_pago` text,
  `fld_id_cliente_ri` int(11) default '0',
  `fld_date` date default NULL,
  `fld_Description` longtext,
  `fld_monto` double(11,2) default NULL,
  `fld_fact_afectado` text,
  `fdl_nd_afectado` text,
  `fld_User` text,
  `fld_Estado` varchar(255) default NULL,
  `fld_nota` longtext,
  `fld_monto_mora` double(12,2) default NULL,
  PRIMARY KEY  (`fld_Id_RI`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*Table structure for table `tbl_recibo_pago_cxp_detalle` */

DROP TABLE IF EXISTS `tbl_recibo_pago_cxp_detalle`;

CREATE TABLE `tbl_recibo_pago_cxp_detalle` (
  `fld_d_ri` int(11) NOT NULL auto_increment,
  `fld_id_doc` int(11) default NULL,
  `fld_ult_abono` double(12,2) default NULL,
  `fld_id_ri_padre` int(11) default NULL,
  `fld_tipo_doc_ri_d` varchar(11) default NULL COMMENT 'F=FACTURA, N=NOTA DEBITO',
  PRIMARY KEY  (`fld_d_ri`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

/*Table structure for table `tbl_salida_inventario` */

DROP TABLE IF EXISTS `tbl_salida_inventario`;

CREATE TABLE `tbl_salida_inventario` (
  `fld_id_si` int(11) NOT NULL auto_increment,
  `fld_fecha_si` date default NULL,
  `fld_user_si` text,
  `fld_concepto_si` varchar(765) default NULL,
  `fld_importes_si` double(11,2) default NULL,
  `fld_almacen_si` text,
  PRIMARY KEY  (`fld_id_si`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_salida_inventario_detalle` */

DROP TABLE IF EXISTS `tbl_salida_inventario_detalle`;

CREATE TABLE `tbl_salida_inventario_detalle` (
  `fld_Id_doc_si` int(11) NOT NULL auto_increment,
  `fldProductID_si` text,
  `fldDescription_si` text,
  `fldId_si` int(11) default '0',
  `fldQuantity_si` int(11) default '0',
  `fldCost_si` double(12,6) default NULL,
  `fld_Importe_si` double(12,2) default NULL,
  `fldEstado_si` varchar(180) default NULL,
  `fldReferencia_si` text,
  `fld_und_vendidas` double(12,2) default NULL,
  `fld_presentacion` varchar(255) default NULL,
  PRIMARY KEY  (`fld_Id_doc_si`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_salida_inventario_detalle_tmp` */

DROP TABLE IF EXISTS `tbl_salida_inventario_detalle_tmp`;

CREATE TABLE `tbl_salida_inventario_detalle_tmp` (
  `fld_Id_doc_si` int(11) NOT NULL auto_increment,
  `fldProductID_si` text,
  `fldDescription_si` text,
  `fldId_si` int(11) default '0',
  `fldQuantity_si` int(11) default '0',
  `fldCost_si` double(12,6) default NULL,
  `fld_Importe_si` double(12,2) default NULL,
  `fldEstado_si` varchar(540) default NULL,
  `fldReferencia_si` text,
  `fld_presentacion` varchar(255) default NULL,
  `fld_und_vendidas` double(12,2) default NULL,
  PRIMARY KEY  (`fld_Id_doc_si`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_series` */

DROP TABLE IF EXISTS `tbl_series`;

CREATE TABLE `tbl_series` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_serie` varchar(255) default NULL,
  `fld_cod_pro` int(11) default NULL,
  `fld_product` varchar(255) default NULL,
  `fld_id_factura` int(11) default NULL,
  `fld_datos_facturas` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_supplier` */

DROP TABLE IF EXISTS `tbl_supplier`;

CREATE TABLE `tbl_supplier` (
  `fldSupplierID` int(11) NOT NULL auto_increment,
  `fldCompany` varchar(450) default NULL,
  `fldAddress` varchar(450) default NULL,
  `fldPhone` varchar(450) default NULL,
  `fldContact` varchar(450) default NULL,
  `fldLimiteCR` int(11) default '0',
  `fldBalance` double(12,2) default NULL,
  `fld_Status` varchar(255) default NULL,
  `fldBy` varchar(450) default NULL,
  `fldfax` varchar(39) default NULL,
  `fldcel` varchar(39) default NULL,
  `fld_clasificacion` text,
  `fld_cta_contable` varchar(45) default NULL,
  PRIMARY KEY  (`fldSupplierID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_taller` */

DROP TABLE IF EXISTS `tbl_taller`;

CREATE TABLE `tbl_taller` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_date` date default NULL,
  `fld_cliente` varchar(255) default NULL,
  `fld_telefono` varchar(25) default NULL,
  `fld_equipo` varchar(255) default NULL,
  `fld_serie` varchar(255) default NULL,
  `fld_marca` varchar(255) default NULL,
  `fld_modelo` varchar(255) default NULL,
  `fld_problema` varchar(550) default NULL,
  `fld_otros` varchar(550) default NULL,
  `fld_estado` varchar(25) default NULL,
  `fld_user` varchar(255) default NULL,
  `fld_tecnico` varchar(255) default NULL,
  `fld_valor` double(12,2) default NULL,
  `fld_mercnacia_utilizadas` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_tipo_entrada_diario` */

DROP TABLE IF EXISTS `tbl_tipo_entrada_diario`;

CREATE TABLE `tbl_tipo_entrada_diario` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_codigo` varchar(20) default NULL,
  `fld_descripcion` varchar(100) default NULL,
  `fld_modulo` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_transacciones` */

DROP TABLE IF EXISTS `tbl_transacciones`;

CREATE TABLE `tbl_transacciones` (
  `fld_Codigo` varchar(50) default NULL,
  `fld_Descripcion` varchar(255) default NULL,
  `fld_DR` double(11,2) default NULL,
  `fld_CR` double(11,2) default NULL,
  `fld_Bce_cta` double(12,2) default NULL,
  `fld_Date` date default NULL,
  `fld_CreadoPor` varchar(50) default NULL,
  `fld_Status` varchar(50) default NULL,
  `fld_IdEntrada` int(11) default NULL,
  `fld_id_cod` int(11) NOT NULL auto_increment,
  `fld_nombre_cuenta` text,
  `fld_tipo_entrada_cod` text,
  `fld_acentada_t` text,
  PRIMARY KEY  (`fld_id_cod`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_unidades` */

DROP TABLE IF EXISTS `tbl_unidades`;

CREATE TABLE `tbl_unidades` (
  `fldID` int(11) NOT NULL auto_increment,
  `fldDescripcion` varchar(50) default NULL,
  PRIMARY KEY  (`fldID`),
  KEY `fldID` (`fldID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_user` */

DROP TABLE IF EXISTS `tbl_user`;

CREATE TABLE `tbl_user` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_UserID` varchar(50) default NULL,
  `fld_Password` varchar(255) default NULL,
  `fld_cargo` varchar(50) default NULL,
  `fld_FirstName` varchar(50) default NULL,
  `fld_LastName` varchar(50) default NULL,
  `fld_departamento` varchar(50) default NULL,
  `fld_Status` varchar(50) default NULL,
  `fld_Created` varchar(19) default NULL,
  `fld_tipo` varchar(255) default NULL,
  `fld_id_company` int(11) default NULL,
  `Mnu_Archivo` varchar(255) default NULL,
  `Mnu_Archivo_Usuarios` varchar(255) default NULL,
  `Mnu_Archivo_Cambia_Clave` varchar(255) default NULL,
  `Mnu_Archivo_vendedores` varchar(255) default NULL,
  `Mnu_Archivo_Ciudad` varchar(255) default NULL,
  `Mnu_Archivo_Utilidades` varchar(255) default NULL,
  `Mnu_Archivo_Utilidades_Ejecuta_SQL` varchar(255) default NULL,
  `Mnu_Archivo_Conf_Timbrado` varchar(255) default NULL,
  `Mnu_Archivo_Conf_Ventas` varchar(255) default NULL,
  `Mnu_Archivo_Conf_Inventario` varchar(255) default NULL,
  `Mnu_Archivo_Conf_CXC` varchar(255) default NULL,
  `Mnu_Archivo_Conf_CXP` varchar(255) default NULL,
  `Mnu_Archivo_Conf_Contabilidad` varchar(255) default NULL,
  `Mnu_Banco` varchar(255) default NULL,
  `Mnu_Banco_Maestro` varchar(255) default NULL,
  `Mnu_Banco_Diario` varchar(255) default NULL,
  `Mnu_Banco_Diario_Solicitud` varchar(255) default NULL,
  `Mnu_Banco_Diario_Emision` varchar(255) default NULL,
  `Mnu_Banco_Diario_Deposito` varchar(255) default NULL,
  `Mnu_Banco_Diario_ND` varchar(255) default NULL,
  `Mnu_Banco_Diario_NC` varchar(255) default NULL,
  `Mnu_Banco_Conciliacion` varchar(255) default NULL,
  `Mnu_Banco_Estado` varchar(255) default NULL,
  `Mnu_Banco_Depositos` varchar(255) default NULL,
  `Mnu_Banco_Depositos_Todos` varchar(255) default NULL,
  `Mnu_Banco_Depositos_Uno` varchar(255) default NULL,
  `Mnu_Banco_ck` varchar(255) default NULL,
  `Mnu_Banco_ck_todos` varchar(255) default NULL,
  `Mnu_Banco_ck_Uno` varchar(255) default NULL,
  `Mnu_Banco_NC` varchar(255) default NULL,
  `Mnu_Banco_NC_Todas` varchar(255) default NULL,
  `Mnu_Banco_NC_Una` varchar(255) default NULL,
  `Mnu_Banco_ND` varchar(255) default NULL,
  `Mnu_Banco_ND_Todas` varchar(255) default NULL,
  `Mnu_Banco_ND_Una` varchar(255) default NULL,
  `Mnu_Conta` varchar(255) default NULL,
  `Mnu_Conta_Catalogo` varchar(255) default NULL,
  `Mnu_Conta_Transacciones` varchar(255) default NULL,
  `Mnu_Conta_Entrada` varchar(255) default NULL,
  `Mnu_Conta_Entrada_Nueva` varchar(255) default NULL,
  `Mnu_Conta_Entrada_Consulta` varchar(255) default NULL,
  `Mnu_Conta_Balance_Comprobacion` varchar(255) default NULL,
  `Mnu_Conta_Balance_General` varchar(255) default NULL,
  `Mnu_Conta_Estado_Resultado` varchar(255) default NULL,
  `Mnu_Conta_Libro_Mayor` varchar(255) default NULL,
  `Mnu_Conta_diario_general` varchar(255) default NULL,
  `Mnu_Conta_diario_general_una_cuenta` varchar(255) default NULL,
  `Mnu_Conta_diario_general_todas` varchar(255) default NULL,
  `Mnu_Conta_diario_general_rango_cuenta` varchar(255) default NULL,
  `Mnu_Conta_Catalogo_Rep` varchar(255) default NULL,
  `Mnu_Ventas` varchar(255) default NULL,
  `Mnu_Ventas_Nueva_Fact` varchar(255) default NULL,
  `Mnu_Ventas_Anula` varchar(255) default NULL,
  `Mnu_Ventas_devolucion` varchar(255) default NULL,
  `Mnu_Ventas_cuadre` varchar(255) default NULL,
  `Mnu_Ventas_Cuadre_otro` varchar(255) default NULL,
  `Mnu_Ventas_ingreso_caja_chica` varchar(255) default NULL,
  `Mnu_Ventas_salida_caja` varchar(255) default NULL,
  `Mnu_Ventas_Porciento_Venta` varchar(255) default NULL,
  `Mnu_Ventas_credito_cliente` varchar(255) default NULL,
  `Mnu_Ventas_todas` varchar(255) default NULL,
  `Mnu_Ventas_resumen` varchar(255) default NULL,
  `Mnu_Ventas_resumen_venta_contado` varchar(255) default NULL,
  `Mnu_Ventas_resumen_venta_credito` varchar(255) default NULL,
  `Mnu_Ventas_detalle` varchar(255) default NULL,
  `Mnu_Ventas_detalle_venta_contado` varchar(255) default NULL,
  `Mnu_Ventas_detalle_venta_credito` varchar(255) default NULL,
  `Mnu_Ventas_nulas` varchar(255) default NULL,
  `Mnu_Ventas_devoluciones` varchar(255) default NULL,
  `Mnu_Ventas_Ganancia_Contado` varchar(255) default NULL,
  `Mnu_Ventas_Ganacias_Credito` varchar(255) default NULL,
  `Mnu_Ventas_Ingresos_Caja_Chica` varchar(255) default NULL,
  `Mnu_Ventas_Salida_Caja_Chica` varchar(255) default NULL,
  `Mnu_Inventario` varchar(255) default NULL,
  `Mnu_Inventario_Maestro_Articulos` varchar(255) default NULL,
  `Mnu_Inventario_Maestro_Almacen` varchar(255) default NULL,
  `Mnu_Inventario_Maestro_Categoria` varchar(255) default NULL,
  `Mnu_Inventario_Imprimir_Etiqueta` varchar(255) default NULL,
  `Mnu_Inventario_Maestro_Vencimiento` varchar(255) default NULL,
  `Mnu_Inventario_Movimiento_Articulos` varchar(255) default NULL,
  `Mnu_Inventario_Entrada_Inventario` varchar(255) default NULL,
  `Mnu_Inventario_Salida_Inventario` varchar(255) default NULL,
  `Mnu_Inventario_Aumento_Disminucion` varchar(255) default NULL,
  `Mnu_Inventario_Vencimientos_Articulos` varchar(255) default NULL,
  `Mnu_Inventario_Rep_Exitenecia_precio` varchar(255) default NULL,
  `Mnu_Inventario_Rep_Art_con_Itbis` varchar(255) default NULL,
  `Mnu_Inventario_Rep_Art_Sin_Itbis` varchar(255) default NULL,
  `Mnu_Inventario_Rep_Valor_Inv` varchar(255) default NULL,
  `Mnu_Inventario_Articulos_Sin_Costos` varchar(255) default NULL,
  `Mnu_Inventario_Rep_Inventariar` varchar(255) default NULL,
  `Mnu_Inventario_Rep_Pedido` varchar(255) default NULL,
  `Mnu_Inventario_Rep_Entrada_inv` varchar(255) default NULL,
  `Mnu_Inventario_Rep_Art_Categoria` varchar(255) default NULL,
  `Mnu_CXC` varchar(255) default NULL,
  `Mnu_CXC_Maestro_Clientes` varchar(255) default NULL,
  `Mnu_CXC_ND` varchar(255) default NULL,
  `Mnu_CXC_NC` varchar(255) default NULL,
  `Mnu_CXC_Recibo_Ingreso` varchar(255) default NULL,
  `Mnu_CXC_Recibo_Ingreso_Crear` varchar(255) default NULL,
  `Mnu_CXC_Recibo_Ingreso_Consulta` varchar(255) default NULL,
  `Mnu_CXC_Estado_Clientes` varchar(255) default NULL,
  `Mnu_CXC_CXC_Rep` varchar(255) default NULL,
  `Mnu_CXC_FCR` varchar(255) default NULL,
  `Mnu_CXC_ND_Rep` varchar(255) default NULL,
  `Mnu_CXC_NC_Rep` varchar(255) default NULL,
  `Mnu_CXC_Recibos_Ingresos` varchar(255) default NULL,
  `Mnu_CXP` varchar(255) default NULL,
  `Mnu_Compras_Recepcion_Mercancia` varchar(255) default NULL,
  `Mnu_CXP_Anular_Compras` varchar(255) default NULL,
  `Mnu_CXP_Devolucion_Compras` varchar(255) default NULL,
  `Mnu_CXP_Proveedores` varchar(255) default NULL,
  `Mnu_CXP_Nota_Debito` varchar(255) default NULL,
  `Mnu_CXP_Nota_Credito` varchar(255) default NULL,
  `Mnu_CXP_Recibos_Pago` varchar(255) default NULL,
  `Mnu_CXP_Recibos_Pago_Crear` varchar(255) default NULL,
  `Mnu_CXP_Recibos_Pago_Consultar` varchar(255) default NULL,
  `Mnu_CXP_Compra_Contado` varchar(255) default NULL,
  `Mnu_CXP_Compra_Credito` varchar(255) default NULL,
  `Mnu_CXP_Compras_Nulas` varchar(255) default NULL,
  `Mnu_CXP_Devoluciones_Compras` varchar(255) default NULL,
  `Mnu_CXP_Estado_Proveedor` varchar(255) default NULL,
  `Mnu_CXP_Cuentas_PAgar` varchar(255) default NULL,
  `Mnu_CXP_Notas_Debito` varchar(255) default NULL,
  `Mnu_CXP_Notas_Credito` varchar(255) default NULL,
  `Mnu_CXP_Recibos_de_pago` varchar(255) default NULL,
  `btn_ventas` varchar(255) default NULL,
  `btn_cxc` varchar(255) default NULL,
  `btn_estado_cuenta` varchar(255) default NULL,
  `btn_nd_cxc` varchar(255) default NULL,
  `btn_nc_cxc` varchar(255) default NULL,
  `btn_maestro_articulos` varchar(255) default NULL,
  `btn_agenta` varchar(255) default NULL,
  `Mnu_Ventas_Ventas_rep` varchar(255) default NULL,
  `Mnu_Ventas_por_usuario` varchar(255) default NULL,
  `Mnu_Ventas_Lista_NCF` varchar(255) default NULL,
  `Mnu_Ventas_Conduce` varchar(255) default NULL,
  `Mnu_Ventas_Cotizaciones` varchar(255) default NULL,
  `Mnu_Ventas_por_articulos` varchar(255) default NULL,
  `Mnu_Ventas_por_articulos_todos` varchar(255) default NULL,
  `Mnu_Ventas_por_articulos_uno` varchar(255) default NULL,
  `Mnu_Ventas_cotizaciones_rep` varchar(255) default NULL,
  `Mnu_Nomina` varchar(255) default NULL,
  `Mnu_Nomina_genera` varchar(255) default NULL,
  `Mnu_Nomina_empleados` varchar(255) default NULL,
  `Mnu_Nomina_prestamos` varchar(255) default NULL,
  `Mnu_Nomina_abono` varchar(255) default NULL,
  `Mnu_Nomina_control` varchar(255) default NULL,
  `Mnu_Nomina_control_entrada` varchar(255) default NULL,
  `Mnu_Nomina_control_salida` varchar(255) default NULL,
  `Mnu_Nomina_rep_lista_empleados` varchar(255) default NULL,
  `Mnu_Nomina_rep_prestamos_empleados` varchar(255) default NULL,
  PRIMARY KEY  (`fld_id`),
  KEY `fld_id` (`fld_id`),
  KEY `fld_UserID` (`fld_UserID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_vencimiento_maestro` */

DROP TABLE IF EXISTS `tbl_vencimiento_maestro`;

CREATE TABLE `tbl_vencimiento_maestro` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_fecha_registro` date default NULL,
  `fld_fecha_vence` date default NULL,
  `fld_cod_art` varchar(11) default NULL,
  `fld_cant` int(11) default NULL,
  `fld_cant_disponible` int(11) default NULL,
  `fld_tipo_doc` varchar(25) default NULL,
  `fld_id_doc_master` int(11) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_ventas` */

DROP TABLE IF EXISTS `tbl_ventas`;

CREATE TABLE `tbl_ventas` (
  `fldInvoiceID` int(11) NOT NULL auto_increment,
  `fld_ncf_facturas` varchar(255) default NULL,
  `fld_fact_no_contado` int(11) default '0',
  `fld_fact_no_credito` int(11) default '0',
  `fldInvDate` date default NULL,
  `fld_dias_vencimiento` int(11) default NULL,
  `fldCondicion` text,
  `fldCliente` int(11) default NULL,
  `fldUserID` text,
  `fldSubTotal` double(11,2) default NULL,
  `fldDescuento` double(11,2) default NULL,
  `fldItbis` double(11,2) default NULL,
  `fldImporte` double(11,2) default NULL,
  `fldAlmacen` text,
  `fldStatus` varchar(60) default NULL,
  `fld_cobrado_con` double(12,2) default NULL,
  `fldAbono` double(12,2) default NULL,
  `fldBalance` double(12,2) default NULL,
  `fld_cliente_contado` varchar(255) default NULL,
  `fld_cliente_contado_direccion` varchar(550) default NULL,
  `fld_id_medico` int(11) default NULL,
  `fld_ultimo_abono` double(12,2) default NULL,
  `fld_by` text,
  `fld_cod_zona_fact` int(11) default NULL,
  `fld_fecha_vende` date default NULL,
  `fld_orden_no` varchar(255) default NULL,
  `fld_nota_observacion` varchar(500) default NULL,
  `fld_hora` varchar(255) default NULL,
  `fld_punto_canjeados` int(11) default NULL,
  `fld_chk` varchar(45) default NULL,
  PRIMARY KEY  (`fldInvoiceID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_ventas_detalle` */

DROP TABLE IF EXISTS `tbl_ventas_detalle`;

CREATE TABLE `tbl_ventas_detalle` (
  `fld_Id` int(11) NOT NULL auto_increment,
  `fldProductID` varchar(255) default NULL,
  `fldDescription` varchar(255) default NULL,
  `fldVentaIDContado` int(11) default '0',
  `fldVentaIDCredito` int(11) default NULL,
  `fldQuantity` decimal(12,2) default NULL,
  `fldPrice` decimal(12,2) default NULL,
  `fldCost` decimal(12,2) default NULL,
  `fld_Importe` decimal(12,2) default NULL,
  `fldEstado` varchar(20) default NULL,
  `fldImporteNeto` decimal(12,2) default NULL,
  `fldDescuentoTotal` decimal(12,2) default NULL,
  `fldReferencia` text,
  `fld_itbis` decimal(12,2) default NULL,
  `fldSerieCell` text,
  `fld_precio_ventas` decimal(12,2) default NULL,
  `fld_dr` varchar(50) default NULL,
  `fld_cr` varchar(50) default NULL,
  `fld_id_de_la_factura_venta` int(11) default NULL,
  `fld_art_vece` varchar(11) default NULL,
  `fld_desc_vencimiento` int(11) default NULL,
  `fldQuantity_bce` double(12,2) default NULL,
  `fld_id_mesa` int(11) default NULL,
  `fld_presentacion` varchar(255) default NULL,
  `fld_und_vendidas` double(12,2) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_ventas_detalle_tmp` */

DROP TABLE IF EXISTS `tbl_ventas_detalle_tmp`;

CREATE TABLE `tbl_ventas_detalle_tmp` (
  `fld_Id` int(11) NOT NULL default '0',
  `fldProductID` text,
  `fldDescription` text,
  `fldVentaIDContado` int(11) default '0',
  `fldVentaIDCredito` int(11) default NULL,
  `fldQuantity` decimal(12,2) default NULL,
  `fldPrice` decimal(12,2) default NULL,
  `fldCost` decimal(12,2) default NULL,
  `fld_Importe` decimal(12,2) default NULL,
  `fldEstado` varchar(20) default NULL,
  `fldImporteNeto` decimal(12,8) default NULL,
  `fldDescuentoTotal` decimal(12,2) default NULL,
  `fldReferencia` text,
  `fld_itbis` decimal(12,8) default NULL,
  `fldSerieCell` text,
  `fld_precio_ventas` double(12,2) default NULL,
  `fld_dr` varchar(50) default NULL,
  `fld_cr` varchar(50) default NULL,
  `fld_id_de_la_factura_venta` int(11) default NULL,
  `fld_art_vece` varchar(11) default NULL,
  `fld_desc_vencimiento` int(11) default NULL,
  `fldQuantity_bce` double(12,2) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_ventas_devoluciones` */

DROP TABLE IF EXISTS `tbl_ventas_devoluciones`;

CREATE TABLE `tbl_ventas_devoluciones` (
  `fldInvoiceID` int(11) NOT NULL auto_increment,
  `fld_fact_no_contado` int(11) default '0',
  `fld_fact_no_credito` int(11) default '0',
  `fldInvDate` date default NULL,
  `fld_dias_vencimiento` int(11) default NULL,
  `fldCondicion` text,
  `fldCliente` int(11) default NULL,
  `fldUserID` text,
  `fldSubTotal` double(11,2) default NULL,
  `fldDescuento` double(11,2) default NULL,
  `fldItbis` double(11,2) default NULL,
  `fldImporte` double(11,2) default NULL,
  `fldAlmacen` text,
  `fldStatus` varchar(180) default NULL,
  `fld_cobrado_con` double(12,2) default NULL,
  `fldAbono` double(12,2) default NULL,
  `fldBalance` double(12,2) default NULL,
  `fld_cliente_contado` varchar(765) default NULL,
  `fld_id_medico` int(11) default NULL,
  `fld_ultimo_abono` decimal(10,2) default NULL,
  `fld_by` text,
  `fld_fact_afectada` int(11) default NULL,
  PRIMARY KEY  (`fldInvoiceID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_ventas_devoluciones_detalle` */

DROP TABLE IF EXISTS `tbl_ventas_devoluciones_detalle`;

CREATE TABLE `tbl_ventas_devoluciones_detalle` (
  `fld_Id` int(11) NOT NULL auto_increment,
  `fldProductID` text,
  `fldDescription` text,
  `fldVentaIDContado` int(11) default '0',
  `fldVentaIDCredito` int(11) default NULL,
  `fldQuantity` double(12,2) default NULL,
  `fldPrice` double(12,2) default NULL,
  `fldCost` double(12,6) default NULL,
  `fld_Importe` double(11,2) default NULL,
  `fldDescuentoTotal` double(12,2) default NULL,
  `fldImporteNeto` double(12,2) default NULL,
  `fldEstado` varchar(60) default NULL,
  `fldReferencia` text,
  `fld_itbis` double(12,2) default NULL,
  `fld_cr` varchar(50) default NULL,
  `fld_dr` varchar(50) default NULL,
  `fld_id_de_la_dev` int(11) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_ventas_devoluciones_detalle_tmp` */

DROP TABLE IF EXISTS `tbl_ventas_devoluciones_detalle_tmp`;

CREATE TABLE `tbl_ventas_devoluciones_detalle_tmp` (
  `fld_Id` int(11) NOT NULL auto_increment,
  `fldProductID` text,
  `fldDescription` text,
  `fldVentaIDContado` int(11) default '0',
  `fldVentaIDCredito` int(11) default NULL,
  `fldQuantity` double(12,2) default NULL,
  `fldPrice` double(12,0) default NULL,
  `fldCost` double(12,6) default NULL,
  `fld_Importe` double(12,2) default NULL,
  `fldEstado` varchar(60) default NULL,
  `fldImporteNeto` double(12,2) default NULL,
  `fldDescuentoTotal` double(12,2) default NULL,
  `fldReferencia` text,
  `fld_itbis` double(12,2) default NULL,
  `fld_cr` varchar(50) default NULL,
  `fld_dr` varchar(50) default NULL,
  `fld_id_de_la_dev` int(11) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_ventas_mesas` */

DROP TABLE IF EXISTS `tbl_ventas_mesas`;

CREATE TABLE `tbl_ventas_mesas` (
  `fld_id` int(11) NOT NULL auto_increment,
  `fld_fecha` datetime default NULL,
  `fld_mesa` varchar(15) default NULL,
  `fld_mesero` int(11) default NULL,
  `fld_estado` varchar(15) default NULL,
  PRIMARY KEY  (`fld_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Table structure for table `tbl_ventas_mesas_detalle` */

DROP TABLE IF EXISTS `tbl_ventas_mesas_detalle`;

CREATE TABLE `tbl_ventas_mesas_detalle` (
  `fld_Id` int(11) NOT NULL auto_increment,
  `fldProductID` varchar(255) default NULL,
  `fldDescription` varchar(255) default NULL,
  `fldVentaIDContado` int(11) default '0',
  `fldVentaIDCredito` int(11) default '0',
  `fldQuantity` decimal(12,2) default NULL,
  `fldPrice` decimal(12,2) default NULL,
  `fldCost` decimal(12,2) default NULL,
  `fld_Importe` decimal(12,2) default NULL,
  `fldEstado` varchar(20) default NULL,
  `fldImporteNeto` decimal(12,2) default NULL,
  `fldDescuentoTotal` decimal(12,2) default NULL,
  `fldReferencia` text,
  `fld_itbis` decimal(12,2) default NULL,
  `fldSerieCell` text,
  `fld_precio_ventas` decimal(12,2) default NULL,
  `fld_dr` varchar(50) default NULL,
  `fld_cr` varchar(50) default NULL,
  `fld_id_de_la_factura_venta` int(11) default NULL,
  `fld_art_vece` varchar(11) default NULL,
  `fld_desc_vencimiento` int(11) default NULL,
  `fldQuantity_bce` double(12,2) default NULL,
  `fld_id_mesa` int(11) default NULL,
  PRIMARY KEY  (`fld_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;


CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_compras_de_articulos` AS select
*
from (`tbl_recepcion` join `tbl_recepcion_detalle`) where (`tbl_recepcion`.`fldInvoiceID` = `tbl_recepcion_detalle`.`fldRecepcionID`); 

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_cxc_nota_credito` AS select
* from (`tbl_clientes` join `tbl_nc_cxc`) where (`tbl_clientes`.`fld_id` = `tbl_nc_cxc`.`fld_cliente_id_nc`); 

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_cxc_nota_debito` AS select
* from (`tbl_clientes` join `tbl_nd_cxc`) where (`tbl_clientes`.`fld_id` = `tbl_nd_cxc`.`fld_cliente_id_nd`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_dev_ventas_contado` AS select
*
from (`tbl_ventas_devoluciones` join `tbl_ventas_devoluciones_detalle`) where ((`tbl_ventas_devoluciones`.`fldCondicion` = _latin1'CONTADO')
and (`tbl_ventas_devoluciones`.`fld_fact_no_contado` = `tbl_ventas_devoluciones_detalle`.`fldVentaIDCredito`));

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_dev_ventas_creditos` AS select
*
from (`tbl_ventas_devoluciones` join `tbl_ventas_devoluciones_detalle`)
where ((`tbl_ventas_devoluciones`.`fldCondicion` = _latin1'CREDITO')
and (`tbl_ventas_devoluciones`.`fld_fact_no_credito` = `tbl_ventas_devoluciones_detalle`.`fldVentaIDCredito`));

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_dev_ventas_todas` AS select
*
from (`tbl_ventas_devoluciones` join `tbl_ventas_devoluciones_detalle`) where (`tbl_ventas_devoluciones`.`fldInvoiceID` = `tbl_ventas_devoluciones_detalle`.`fld_id_de_la_dev`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_entrada_articulos` AS select
* from (`tbl_recepcion_detalle` join `tbl_recepcion`)
where (`tbl_recepcion_detalle`.`fldRecepcionID` = `tbl_recepcion`.`fldInvoiceID`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_entrada_articulo_inventario` AS select
*
from (`tbl_entrada_inventario` join `tbl_entrada_inventario_detalle`) where (`tbl_entrada_inventario`.`fld_id_ei` = `tbl_entrada_inventario_detalle`.`fldId_ei`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_estado_banco` AS select
* from (`tbl_estado_banco` join `tbl_bancos`) where (`tbl_estado_banco`.`fld_banco_id` = `tbl_bancos`.`fld_codigo`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_estado_clientes` AS select
* from (`tbl_clientes` join `tbl_estado_clientes`) where (`tbl_clientes`.`fld_id` = `tbl_estado_clientes`.`fld_cliente_id`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_estado_proveedor` AS select
* from (`tbl_supplier` join `tbl_estado_proveedor`) where (`tbl_supplier`.`fldSupplierID` = `tbl_estado_proveedor`.`fld_proveedor_id`); 

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_ganancias_brutas_ventas_contado` AS select
* from (`tbl_ventas` join `tbl_ventas_detalle`)
 where ((`tbl_ventas`.`fldInvoiceID` = `tbl_ventas_detalle`.`fld_id_de_la_factura_venta`) and (`tbl_ventas`.`fldCondicion` = _latin1'CONTADO'));

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_ganancias_brutas_ventas_credito` AS select
* from (`tbl_ventas` join `tbl_ventas_detalle`)
where ((`tbl_ventas`.`fld_fact_no_credito` = `tbl_ventas_detalle`.`fldVentaIDCredito`) and (`tbl_ventas`.`fldCondicion` = _latin1'CREDITO')); 

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_horario_empleado` AS select
*
from (`tbl_empleados` `e` join `tbl_check_in_out` `ch`)
where (`e`.`fld_id` = `ch`.`fld_id_empleado`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_libro_diario_general` AS select
* from (`tbl_transacciones` join `tbl_entrada_diarias`) where (`tbl_transacciones`.`fld_IdEntrada` = `tbl_entrada_diarias`.`fld_Entrada_ID`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_libro_mayor` AS select
*
from (`tbl_catalogo_cta` join `tbl_transacciones`) where (`tbl_transacciones`.`fld_Codigo` = `tbl_catalogo_cta`.`FLD_CUENTA_NO`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_lista_facturas_credito` AS select
* from (`tbl_clientes` join `tbl_ventas`) where (`tbl_clientes`.`fld_id` = `tbl_ventas`.`fldCliente`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_nota_credito_cxp` AS select
* from (`tbl_supplier` join `tbl_nc_cxp`) where (`tbl_supplier`.`fldSupplierID` = `tbl_nc_cxp`.`fld_proveedor_id_nc`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_nota_debito_cxp` AS select
* from (`tbl_supplier` join `tbl_nd_cxp`) where (`tbl_supplier`.`fldSupplierID` = `tbl_nd_cxp`.`fld_proveedor_id_nd`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_orden_details` AS select
* from (`tbl_recepcion_detalle` join `tbl_recepcion`) where (`tbl_recepcion_detalle`.`fldRecepcionID` = `tbl_recepcion`.`fldInvoiceID`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_porciento_ventas` AS select
 *
 from (`tbl_ventas` join `tbl_maestro_vendedor`) where (`tbl_ventas`.`fld_id_medico` = `tbl_maestro_vendedor`.`fldId`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_recepciones` AS select
*
from (`tbl_recepcion` join `tbl_supplier`) where (`tbl_recepcion`.`fldSupplier` = `tbl_supplier`.`fldSupplierID`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_recepcion_detalles` AS select
* from (`tbl_recepcion_detalle` join `tbl_recepcion`) where (`tbl_recepcion_detalle`.`fldRecepcionID` = `tbl_recepcion`.`fldInvoiceID`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_ri_cxc` AS select
* from (`tbl_clientes` join `tbl_recibo_ingresos_cxc`) where (`tbl_clientes`.`fld_id` = `tbl_recibo_ingresos_cxc`.`fld_id_cliente_ri`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_rp_cxp` AS select
* from (`tbl_recibo_pago_cxp` join `tbl_supplier`) where (`tbl_recibo_pago_cxp`.`fld_id_cliente_ri` = `tbl_supplier`.`fldSupplierID`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_salida_articulos` AS select
* from (`tbl_ventas` join `tbl_ventas_detalle`)
where ((`tbl_ventas`.`fld_fact_no_contado` = `tbl_ventas_detalle`.`fldVentaIDContado`) and (`tbl_ventas`.`fld_fact_no_credito` = `tbl_ventas_detalle`.`fldVentaIDCredito`));

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_salida_articulo_inventario` AS select
* from (`tbl_salida_inventario` join `tbl_salida_inventario_detalle`) where (`tbl_salida_inventario`.`fld_id_si` = `tbl_salida_inventario_detalle`.`fldId_si`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_vencimiento_art` AS select
* from (`tbl_vencimiento_maestro` join `tbl_productos`) where (`tbl_vencimiento_maestro`.`fld_cod_art` = `tbl_productos`.`fld_CodPersonalizado`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_ventas_detalles_contado` AS select
* from (`tbl_ventas` join `tbl_ventas_detalle`) where (`tbl_ventas`.`fld_fact_no_contado` = `tbl_ventas_detalle`.`fldVentaIDContado`);

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_ventas_detalles_credito` AS select
* from (`tbl_ventas` join `tbl_ventas_detalle`)
where ((`tbl_ventas`.`fldInvoiceID` = `tbl_ventas_detalle`.`fld_id_de_la_factura_venta`) and (`tbl_ventas`.`fldCondicion` = _latin1'CREDITO'));

CREATE OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_ventas_de_articulos` AS select
* from (`tbl_ventas` join `tbl_ventas_detalle`) where (`tbl_ventas`.`fldInvoiceID` = `tbl_ventas_detalle`.`fld_id_de_la_factura_venta`);

CREATE DEFINER=`root`@`localhost` PROCEDURE `actualiza_cat_cta_auxiliares`()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE a CHAR(50);
    DECLARE dr DOUBLE(12,2);
    DECLARE cr  DOUBLE(12,2);
    DECLARE o CHAR(50);
    DECLARE cur1 CURSOR FOR SELECT t.fld_codigo, SUM(t.fld_dr), SUM(t.fld_cr), c.FLD_ORIGEN 
    FROM tbl_transacciones AS t
    LEFT JOIN tbl_catalogo_cta AS c
    ON c.FLD_CUENTA_NO=t.fld_Codigo 
    WHERE c.fld_tipo='AUXILIAR'
    GROUP BY t.fld_codigo;
    DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET done = 1;
    OPEN cur1;
    REPEAT
     FETCH cur1 INTO a, dr, cr, o;
      IF NOT done THEN
	if o='CREDITO' THEN
	 UPDATE tbl_catalogo_cta SET fld_debito=dr, fld_credito=cr, fld_balance=fld_credito-fld_debito WHERE fld_cuenta_no=a;
	ELSE
	 UPDATE tbl_catalogo_cta SET fld_debito=dr, fld_credito=cr, fld_balance=fld_debito-fld_credito WHERE fld_cuenta_no=a;
	END IF;
      END IF;
     UNTIL done END REPEAT;
    CLOSE cur1; 
    END;


CREATE DEFINER=`root`@`localhost` PROCEDURE `actualiza_cat_cta_control`()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE dr DOUBLE(12,2);
    DECLARE cr  DOUBLE(12,2);
    DECLARE ct CHAR(50);
    DECLARE o CHAR(50);
    DECLARE cur1 CURSOR FOR SELECT FLD_CTA_CONTROL, SUM(fld_debito), SUM(fld_credito),  FLD_ORIGEN 
    FROM tbl_catalogo_cta 
    WHERE FLD_TIPO='SUB-CTA'
    GROUP BY FLD_CTA_CONTROL;
    DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET done = 1;
    OPEN cur1;
    REPEAT
     FETCH cur1 INTO ct, dr, cr, o;
      IF NOT done THEN
	IF o='CREDITO' THEN
	 UPDATE tbl_catalogo_cta SET fld_debito=dr, fld_credito=cr, fld_balance=fld_credito-fld_debito WHERE fld_cuenta_no=ct;
	ELSE
	 UPDATE tbl_catalogo_cta SET fld_debito=dr, fld_credito=cr, fld_balance=fld_debito-fld_credito WHERE fld_cuenta_no=ct;
	END IF;
      END IF;
     UNTIL done END REPEAT;
    CLOSE cur1; 
    END;


CREATE DEFINER=`root`@`localhost` PROCEDURE `actualiza_cat_sub_cuentas`()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE dr DOUBLE(12,2);
    DECLARE cr  DOUBLE(12,2);
    DECLARE ct CHAR(50);
    DECLARE o CHAR(50);
    DECLARE cur1 CURSOR FOR SELECT FLD_CTA_CONTROL, SUM(fld_debito), SUM(fld_credito),  FLD_ORIGEN 
    FROM tbl_catalogo_cta 
    WHERE FLD_TIPO='AUXILIAR'
    GROUP BY FLD_CTA_CONTROL;
    DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET done = 1;
    OPEN cur1;
    REPEAT
     FETCH cur1 INTO ct, dr, cr, o;
      IF NOT done THEN
	IF o='CREDITO' THEN
	 UPDATE tbl_catalogo_cta SET fld_debito=dr, fld_credito=cr, fld_balance=fld_credito-fld_debito WHERE fld_cuenta_no=ct;
	ELSE
	 UPDATE tbl_catalogo_cta SET fld_debito=dr, fld_credito=cr, fld_balance=fld_debito-fld_credito WHERE fld_cuenta_no=ct;
	END IF;
      END IF;
     UNTIL done END REPEAT;
    CLOSE cur1; 
    END;


CREATE DEFINER=`root`@`localhost` PROCEDURE `act_catalogo`(CUENTA VARCHAR(20))
BEGIN
     DECLARE debito decimal(12,2);
     DECLARE credito decimal(12,2);
     SELECT SUM(FLD_DEBITO) , SUM(FLD_CREDITO) INTO debito, credito FROM tbl_catalogo_cta WHERE FLD_CTA_CONTROL=CUENTA;
     UPDATE tbl_catalogo_cta SET FLD_DEBITO=debito, FLD_CREDITO= credito WHERE FLD_CUENTA_NO=CUENTA;     
END;


CREATE DEFINER=`root`@`localhost` PROCEDURE `bce_clientes`()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE a CHAR(50);
    DECLARE cur1 CURSOR FOR SELECT fld_id FROM tbl_clientes;
    DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET done = 1;
    OPEN cur1;
  
    REPEAT
     FETCH cur1 INTO a;
     IF NOT done THEN
      call set_bce_cliente(a);     
    END IF;
    UNTIL done END REPEAT;
    CLOSE cur1; 
END;


CREATE DEFINER=`root`@`localhost` PROCEDURE `bce_provee`()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE a CHAR(50);
    DECLARE cur1 CURSOR FOR SELECT fldSupplierID FROM tbl_supplier;
    DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET done = 1;
    OPEN cur1;
  
    REPEAT
     FETCH cur1 INTO a;
     IF NOT done THEN
      call set_bce_proveedor(a);     
    END IF;
    UNTIL done END REPEAT;
    CLOSE cur1; 
END;


CREATE DEFINER=`root`@`localhost` PROCEDURE `calcula_entrada_inventario`(in id_producto varchar(50))
BEGIN
     DECLARE compra double(12,2);
     DECLARE venta_nula double(12,2);
     DECLARE venta_dev double(12,2);
     DECLARE entrada_directa double(12,2);            
    select IFNULL(sum(de.fldquantity),0) as cant_compra INTO compra  
    from tbl_recepcion_detalle as de 
    left join tbl_recepcion as re 
    ON de.fldREcepcionID = re.fldInvoiceID 
    where de.fldProductID=id_producto;
    select IFNULL(sum(fldquantity),0) into venta_nula 
    from tbl_ventas_detalle as ven_de 
    left join tbl_ventas as ven 
    on ven.fldInvoiceID=ven_de.fld_id_de_la_factura_venta
    where ven_de.fldProductID=id_producto AND  fldStatus = 'NULO';
    
    SELECT IFNULL(SUM(devd.fldQuantity),0) into venta_dev from tbl_ventas_devoluciones as dev 
    left join tbl_ventas_devoluciones_detalle as devd 
    on dev.fldInvoiceID=devd.fld_id_de_la_dev 
    WHERE  devd.fldProductID=id_producto;
    
    select IFNULL(sum(fldquantity_ei),0) as cant_entrada INTO entrada_directa 
    from tbl_entrada_inventario_detalle ed 
    left join tbl_entrada_inventario as en
    on en.fld_id_ei=ed.fld_id_doc_ei
    where ed.fldProductID_ei=id_producto; 
    
    UPDATE tbl_productos set fldTotalEntrada = (compra + entrada_directa) + (venta_dev + venta_nula)
    where fld_CodPersonalizado=id_producto;
END;


CREATE DEFINER=`root`@`localhost` FUNCTION `calcula_exitencia`(iddoc VARCHAR(5)) RETURNS int(10)
BEGIN
    
    DECLARE exitencia INT(10) DEFAULT 0;
    SELECT IFNULL(fldTotalEntrada-fldTotalSalida,0) into exitencia FROM tbl_productos;
    RETURN exitencia;
END;


CREATE DEFINER=`root`@`localhost` PROCEDURE `calcula_salida_inventario`(in id_producto varchar(50))
BEGIN
     DECLARE venta double(12,2);
     DECLARE salida_directa double(12,2);    
     DECLARE compra_nula double(12,2);
     DECLARE compra_dev double(12,2);
     
    select IFNULL(sum(fldquantity),0) into venta 
    from tbl_ventas_detalle as ven_de 
    left join tbl_ventas as ven 
    on ven.fldInvoiceID=ven_de.fld_id_de_la_factura_venta
    where ven_de.fldProductID=id_producto;
    
    select IFNULL(sum(fldquantity_si),0) into salida_directa 
    from tbl_salida_inventario_detalle as sid
    LEFT join tbl_salida_inventario as si
    on si.fld_id_si=sid.fld_id_doc_si
    where sid.fldProductID_si=id_producto;
    SELECT IFNULL(SUM(de.fldQuantity),0) into compra_nula FROM tbl_recepcion_detalle as de 
    left join tbl_recepcion as recep on de.fldRecepcionID=recep.fldInvoiceID 
    where de.fldProductID=id_producto and recep.fldStatus='NULO';
    
    SELECT IFNULL(SUM(devd.fldQuantity),0) into compra_dev FROM tbl_recepcion_dev as dev 
    left join tbl_recepcion_dev_detalle as devd 
    on devd.fldRecepcionID=dev.fldInvoiceID 
    where devd.fldProductID=id_producto;    
       
    UPDATE tbl_productos set fldTotalSalida = (venta + salida_directa) + (compra_nula + compra_dev)  
    where fld_CodPersonalizado=id_producto;
END;


CREATE DEFINER=`root`@`localhost` PROCEDURE `codigo`(IN COD INT(10))
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE a CHAR(50);
    DECLARE cur1 CURSOR FOR SELECT ID FROM tbl_productos ORDER BY fldDescription ASC;
    DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET done = 1;
    OPEN cur1;
  
    REPEAT
     FETCH cur1 INTO a;
     IF NOT done THEN
       UPDATE tbl_productos SET fld_CodPersonalizado = COD WHERE ID=a;
    END IF;
    set COD=COD+1;
    UNTIL done END REPEAT;
    CLOSE cur1; 
END;


CREATE DEFINER=`root`@`localhost` PROCEDURE `codigo_entrada_inventario`()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE a CHAR(255);
    DECLARE b CHAR(255);
    DECLARE cur1 CURSOR FOR SELECT fld_CodPersonalizado, fldDescription FROM tbl_productos;
    DECLARE CONTINUE HANDLER FOR SQLSTATE '02000' SET done = 1;
    OPEN cur1;
  
    REPEAT
     FETCH cur1 INTO a, b;
     IF NOT done THEN
       UPDATE tbl_entrada_inventario_detalle SET fldProductID_ei = a WHERE fldDescription_ei=b;
    END IF;
    
    UNTIL done END REPEAT;
    CLOSE cur1; 
END;


CREATE DEFINER=`root`@`localhost` FUNCTION `funct_cantidad_inve`(entrada VARCHAR(10)) RETURNS int(10)
BEGIN
     DECLARE cant int(10);
     SELECT IFNULL(fldTotalEntrada-fldTotalSalida,0) INTO cant FROM tbl_productos WHERE fld_CodPersonalizado=entrada;
     RETURN cant;
END;


CREATE DEFINER=`root`@`localhost` PROCEDURE `set_bce_cliente`(id_cliente int(10))
BEGIN
    DECLARE dr double(12,2);
    DECLARE cr double(12,2);
    SELECT IFNULL(SUM(fld_dr),0) INTO dr FROM tbl_estado_clientes WHERE fld_cliente_id=id_cliente;
    SELECT IFNULL(SUM(fld_cr),0) INTO cr FROM tbl_estado_clientes WHERE fld_cliente_id=id_cliente;
    UPDATE tbl_clientes set fld_bce=(dr-cr) where fld_id=id_cliente;
END;


CREATE DEFINER=`root`@`localhost` PROCEDURE `set_bce_proveedor`(id_prove int(10))
BEGIN
    DECLARE dr double(12,2);
    DECLARE cr double(12,2);
    SELECT IFNULL(SUM(fld_dr),0) INTO dr FROM tbl_estado_proveedor WHERE fld_proveedor_id=id_prove;
    SELECT IFNULL(SUM(fld_cr),0) INTO cr FROM tbl_estado_proveedor WHERE fld_proveedor_id=id_prove;
    UPDATE tbl_supplier set fldBalance=(cr-dr) where fldSupplierID =id_prove;
END;


CREATE DEFINER=`root`@`localhost` PROCEDURE `set_horarios`()
BEGIN
   update tbl_check_in_out AS ch set t_1_hasta_ch=concat(concat(date(fld_fecha),' '),(
select time(t_1_hasta)from tbl_empleados as em
where ch.fld_id_empleado=em.fld_id));

update tbl_check_in_out AS ch set t_1_desde_ch=concat(concat(date(fld_fecha),' '),(
select time(t_1_desde)from tbl_empleados as em
where ch.fld_id_empleado=em.fld_id));

update tbl_check_in_out AS ch set t_2_hasta_ch=concat(concat(date(fld_fecha),' '),(
select time(t_2_hasta)from tbl_empleados as em
where ch.fld_id_empleado=em.fld_id));

update tbl_check_in_out AS ch set t_2_desde_ch=concat(concat(date(fld_fecha),' '),(
select time(t_2_desde)from tbl_empleados as em
where ch.fld_id_empleado=em.fld_id));

END;

CREATE TRIGGER `trg_bce_cliente` AFTER INSERT ON `tbl_estado_clientes`
  FOR EACH ROW CALL set_bce_cliente(NEW.fld_cliente_id);

CREATE TRIGGER `trg_bce_proveedor` AFTER INSERT ON `tbl_estado_proveedor`
  FOR EACH ROW CALL set_bce_proveedor(NEW.fld_proveedor_id);

CREATE TRIGGER `trg_set_entr_sali_inve` BEFORE INSERT ON `tbl_movimiento_inventario`
  FOR EACH ROW BEGIN
	update tbl_productos set fldTotalEntrada=fldTotalEntrada + new.fld_entrada_mi, 
	fldTotalSalida=fldTotalSalida + new.fld_salida_mi where fld_CodPersonalizado=new.fld_pro_id_mi;
  END;


INSERT INTO `tbl_almacen` VALUES (1,'LOCAL');
INSERT INTO `tbl_catalogo_cta` VALUES (1,'1','ACTIVOS','DEBITO','ACTIVOS','CONTROL','0',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (2,'11','EFECTIVO EN CAJA Y BANCOS','DEBITO','ACTIVOS','SUB-CTA','1',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (3,'11-01-01','CAJA GENERAL','DEBITO','ACTIVOS','AUXILIAR','11',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (4,'11-02-01','CAJA CHICA','DEBITO','ACTIVOS','AUXILIAR','11',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (5,'11-03-01','BANCO POPULAR','DEBITO','ACTIVOS','AUXILIAR','11',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (6,'11-03-02','REPUBLIC BANK.','DEBITO','ACTIVOS','AUXILIAR','11',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (7,'11-03-03','ASOC. LA NACIONAL DE AHORROS Y PRESTAMOS','DEBITO','ACTIVOS','AUXILIAR','11',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (8,'11-03-09','TRANSFERENCIAS  DE FONDOS','DEBITO','ACTIVOS','AUXILIAR','11',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (9,'11-04','INVERSIONES','DEBITO','ACTIVOS','SUB-CTA','1',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (10,'11-04-03','DEPOSITOS A LA VISTA','DEBITO','ACTIVOS','AUXILIAR','11-04',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (11,'11-04-04','DEPOSITOS DE AHORRO','DEBITO','ACTIVOS','AUXILIAR','11-04',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (12,'11-04-05','DEPOSITOS A CORTO PLAZO','DEBITO','ACTIVOS','AUXILIAR','11-04',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (13,'11-04-06','DEPOSITOS A LARGO PLAZO','DEBITO','ACTIVOS','AUXILIAR','11-04',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (14,'11-04-07','INVERSIONES EN VALORES A NEGOCIAR','DEBITO','ACTIVOS','AUXILIAR','11-04',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (15,'11-04-08','INVERSIONES EN EL SECTOR PUBLICO','DEBITO','ACTIVOS','AUXILIAR','11-04',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (16,'11-04-09','INVERSIONES EN EL SECTOR PRIVADO NO FINANCIERO','DEBITO','ACTIVOS','AUXILIAR','11-04',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (17,'12','CUENTAS  Y DOCUMENTOS POR COBRAR','DEBITO','ACTIVOS','SUB-CTA','1',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (18,'12-01-01','DOCUMENTOS Y CUENTAS POR COBRAR ACCIONISTAS','DEBITO','ACTIVOS','AUXILIAR','12',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (19,'12-01-02','CUENTAS POR COBRAR CLIENTES LOCALES','DEBITO','ACTIVOS','AUXILIAR','12',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (20,'12-01-03','CUENTAS POR COBRAR CLIENTES INTERNACIONALES','DEBITO','ACTIVOS','AUXILIAR','12',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (21,'12-01-04','CUENTA POR COBRAR FUNCIONARIO Y EMPLEADOS','DEBITO','ACTIVOS','AUXILIAR','12',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (22,'12-01-05','CUENTAS POR COBRAR OTRAS','DEBITO','ACTIVOS','AUXILIAR','12',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (23,'12-01-06','RESERVAS PARA CUENTAS INCOBRABLES LOCALES','DEBITO','ACTIVOS','AUXILIAR','12',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (24,'12-01-07','RESERVAS PARA CUENTAS INCOBRABLES INTERNACIONALES','DEBITO','ACTIVOS','AUXILIAR','12',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (25,'12-01-08','DEPOSITOS JUDICIALES Y ADMINISTRATIVOS','DEBITO','ACTIVOS','AUXILIAR','12',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (26,'12-01-09','PRIMAS DE SEGURO POR COBRAR','DEBITO','ACTIVOS','AUXILIAR','12',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (27,'13','INVENTARIOS','DEBITO','ACTIVOS','SUB-CTA','1',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (28,'13-01-01','INVENTARIO DE MERCANCIA ','DEBITO','ACTIVOS','AUXILIAR','13',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (29,'13-01-02','INVENTARIO DE MERCANCIAS EN TRANSITO','DEBITO','ACTIVOS','AUXILIAR','13',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (30,'13-01-03','INVENTARIO DE MERCANCIAS A CONSIGNACION','DEBITO','ACTIVOS','AUXILIAR','13',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (31,'13-01-04','INVENTARIO DE MERCANCIAS DESCOMPUESTAS','DEBITO','ACTIVOS','AUXILIAR','13',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (32,'13-01-05','INVENTARIO DE CILINDRO 25','DEBITO','ACTIVOS','AUXILIAR','13',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (33,'14','GASTOS PAGADOS POR ANTICIPADO','DEBITO','ACTIVOS','SUB-CTA','1',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (34,'14-01-01','GASTOS PAGADOS POR ANTICIPADO GENERALES','DEBITO','ACTIVOS','AUXILIAR','14',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (35,'14-01-02','SEGUROS PAGADOS POR ADELANTADO','DEBITO','ACTIVOS','AUXILIAR','14',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (36,'14-01-03','ARRENDAMIENTOS PAGADOS POR ADELANTADO','DEBITO','ACTIVOS','AUXILIAR','14',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (37,'14-01-04','FIANZAS Y DEPOSITOS','DEBITO','ACTIVOS','AUXILIAR','14',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (38,'14-01-05','PLACAS Y REVISTAS','DEBITO','ACTIVOS','AUXILIAR','14',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (39,'14-01-06','FIANZA Y DEPOSITOS','DEBITO','ACTIVOS','AUXILIAR','14',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (40,'14-01-07','GASTOS DE ORGANIZACIÓN PAGADOS POR ADELANTADO','DEBITO','ACTIVOS','AUXILIAR','14',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (41,'14-01-08','SUSCRIPCIONES Y CUOTAS','DEBITO','ACTIVOS','AUXILIAR','14',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (42,'14-01-09','ANTICIPOS PARA VIAJES','DEBITO','ACTIVOS','AUXILIAR','14',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (43,'14-01-10','MEJORAS EN PROPIEDADES ARRENDADAS','DEBITO','ACTIVOS','AUXILIAR','14',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (44,'14-01-11','OTROS.','DEBITO','ACTIVOS','AUXILIAR','14',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (45,'15','ACTIVOS FIJOS','DEBITO','ACTIVOS','SUB-CTA','1',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (46,'15-01-01','TERRENOS','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (47,'15-01-02','DEPRECIACION ACUM. TERRENOS','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (48,'15-01-03','EDIFICACIONES','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (49,'15-01-04','DEPRECIACION ACUM. EDIFICACIONES','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (50,'15-01-05','MOBILIARIO Y EQUIPOS DE OFICINA','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (51,'15-01-06','DEPRECIACION ACUM. MOB. Y EQUIPOS OFICINA','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (52,'15-01-07','EQUIPO DE TRANSPORTE','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (53,'15-01-08','DEPRECIACION ACUMULADA EQUIPOS DE TRANSPORTE','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (54,'15-01-09','EQUIPO DE COMUNICACIÓN','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (55,'15-01-10','DEPRECIACION ACUM. EQUIPO DE COMUNICACION','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (56,'15-01-11','EQUPOS DE COMPUTOS','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (57,'15-01-12','DEPRECIACION ACUM. EQUIPOS DE COMPUTOS','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (58,'15-01-13','SOFWARE','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (59,'15-01-14','DEPRECIACION ACUM. SOFWARE','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (60,'15-01-15','EQUIPOS DE SEGURIDAD','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (61,'15-01-16','DEPRECIACION ACUMULADA EQUIPO','DEBITO','ACTIVOS','AUXILIAR','15',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (62,'2','PASIVOS    ','CREDITO','PASIVOS','CONTROL','0',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (63,'21','CUENTAS Y DOCUMENTOS POR PAGAR','CREDITO','PASIVOS','SUB-CTA','2',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (64,'21-01-01','DOCUMENTOS POR PAGAR A CORTO Y MEDIANO PLAZO','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (65,'21-01-02','DOCUMENTOS POR PAGAR A LARGO PLAZO','CREDITO','PASIVOS','SUB-CTA','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (66,'21-01-03','C X P SUPLIDORES INTERNACIONALES','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (67,'21-01-04','C X P SUPLIDORES LOCALES','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (68,'21-01-05','PRESTAMOS POR PAGAR','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (69,'21-01-06','C X P SOCIOS','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (70,'21-01-07','OBLIGACIONES FINANCIERAS A LA VISTA','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (71,'21-01-08','INTERESES Y COMISIONES POR PAGAR','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (72,'21-01-20','C X P OTROS','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (73,'21-02-01','RETENCIONES POR PAGAR','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (74,'21-02-02','RETENCIONES EMPLEADOS','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (75,'21-02-03','IMPUESTO S/R POR PAGAR','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (76,'21-02-04','FONDO DE PENSIONES Y JUBILACIONES (TSS)','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (77,'21-02-05','SEGURO FAMILIAR DE SALUD POR PAGAR','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (78,'21-02-06','RETENCION DE ITBIS','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (79,'21-02-07','ISR LEY 11/92 EMPLEADOS POR PAGAR','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (80,'21-02-08','RETENCION SOBRE ALGUILERES 20%','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (81,'21-02-09','RETENCIONES A TERCEROS 2%','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (82,'21-02-20','OTRAS RETENCIONES POR PAGAR','CREDITO','PASIVOS','AUXILIAR','21',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (83,'3','CAPITAL','CREDITO','CAPITAL','CONTROL','0',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (84,'31','CAPITAL','CREDITO','CAPITAL','SUB-CTA','3',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (85,'31-01-01','GANANCIA O PERDIDAS AÑOS ANTERIORES','CREDITO','CAPITAL','AUXILIAR','31',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (86,'31-01-02','RESUMEN DE GANANCIAS Y PERDIDA','CREDITO','CAPITAL','AUXILIAR','31',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (87,'31-01-03','UTILIDADES RETENIDAS','CREDITO','CAPITAL','AUXILIAR','31',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (88,'31-01-04','CAPITAL DONADO POR INSTITUCIONES','CREDITO','CAPITAL','AUXILIAR','31',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'SI',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (89,'4','INGRESOS','CREDITO','INGRESOS','CONTROL','0',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI','0','+');
INSERT INTO `tbl_catalogo_cta` VALUES (90,'41','INGRESOS POR VENTAS','CREDITO','INGRESOS','SUB-CTA','4',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI','0','+');
INSERT INTO `tbl_catalogo_cta` VALUES (91,'41-01-01','INGRESOS POR VENTAS CONTADO','CREDITO','INGRESOS','AUXILIAR','41',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI','0','+');
INSERT INTO `tbl_catalogo_cta` VALUES (92,'41-01-02','INGRESOS POR VENTAS A CREDITO','CREDITO','INGRESOS','AUXILIAR','41',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI',NULL,'+');
INSERT INTO `tbl_catalogo_cta` VALUES (93,'41-01-03','LIQUIDACION DE MERCANCIAS AL CONTADO','CREDITO','INGRESOS','AUXILIAR','41',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI',NULL,'+');
INSERT INTO `tbl_catalogo_cta` VALUES (94,'41-01-04','LIQUIDACION DE MERCANCIAS A CREDITO','CREDITO','INGRESOS','AUXILIAR','41',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI',NULL,'+');
INSERT INTO `tbl_catalogo_cta` VALUES (95,'41-01-10','OTROS INGRESOS','CREDITO','INGRESOS','AUXILIAR','41',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI','2','+');
INSERT INTO `tbl_catalogo_cta` VALUES (96,'5','COSTOS','DEBITO','COSTOS','CONTROL','0',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI','0','-');
INSERT INTO `tbl_catalogo_cta` VALUES (97,'51','COSTO DE VENTA','DEBITO','COSTOS','SUB-CTA','5',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI','0','-');
INSERT INTO `tbl_catalogo_cta` VALUES (98,'51-01-01','COSTO MERCANCIA DISPONIBLE PARA LA VENTA','DEBITO','COSTOS','AUXILIAR','51',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI',NULL,'-');
INSERT INTO `tbl_catalogo_cta` VALUES (99,'51-01-02','COSTO MERCANCIA EN TRANSITO','DEBITO','COSTOS','AUXILIAR','51',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI',NULL,'-');
INSERT INTO `tbl_catalogo_cta` VALUES (100,'51-01-03','OTROS COSTOS','DEBITO','COSTOS','AUXILIAR','51',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI',NULL,'-');
INSERT INTO `tbl_catalogo_cta` VALUES (101,'6','GASTOS','DEBITO','GASTOS','CONTROL','0',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI','0','-');
INSERT INTO `tbl_catalogo_cta` VALUES (102,'61','GASTOS GENERALES Y ADMINISTRATIVOS','DEBITO','GASTOS','SUB-CTA','6',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI','0','-');
INSERT INTO `tbl_catalogo_cta` VALUES (103,'61-01-01','SALARIOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO','SI',NULL,'-');
INSERT INTO `tbl_catalogo_cta` VALUES (104,'61-01-02','REAGALIA PASCUAL','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (105,'61-01-03','VACACIONES','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (106,'61-01-04','PRESTACIONES LABORALES','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (107,'61-01-05','HORAS EXTRAS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (108,'61-01-06','DIETAS Y VIATICOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (109,'61-01-07','BONIFICACIONES','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (110,'61-01-08','ALQUILER LOCAL','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (111,'61-01-09','ALQUILERES EQUIPOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (112,'61-01-10','TELEFONOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (113,'61-01-11','ELECTRICIDAD','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (114,'61-01-12','AGUA Y BASURA','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (115,'61-01-13','COMBUSTIBLES','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (116,'61-01-14','MATERIALES DE LIMPIEZA','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (117,'61-01-15','TRANSPORTES Y ACARREOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (118,'61-01-16','PLACAS Y SEGUROS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (119,'61-01-17','FLETES Y ACARREOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (120,'61-01-18','ENVIO DE DOCUEMENTOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (121,'61-01-19','DONACIONES','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (122,'61-01-20','OBSEQUIOS AL PERSONAL','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (123,'61-01-21','SEGURO MEDICO','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (124,'61-01-22','PLAN DE PENSIONES Y JUBILACIONES','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (125,'61-01-23','PLAN GENERAL DE SALUD','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (126,'61-01-24','SEGURO DE RIESGO LABORAL','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (127,'61-01-25','ASIGNACION VEHICULO','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (128,'61-01-26','COMISIONES SOBRE LAS VENTAS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (129,'61-01-27','REFRIGERIOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (130,'61-01-28','GASTOS DE REPRESENTACION','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (131,'61-01-29','TRANSPORTE EMPLEADOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (132,'61-01-30','ASIGNACION DE COMBUSTIBLE','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (133,'61-01-31','SERVICIOS PRESTADOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (134,'61-01-32','PUBLICIDAD','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (135,'61-01-33','REPARACION Y MANTENIMIENTO DE VEHICULOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (136,'61-01-34','MULTAS Y RECARGOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (137,'61-01-35','IMPUESTO SOBRE LA RENTA','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (138,'61-01-36','MATERIALES GASTABLE DE OFICINA','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (139,'61-01-37','GASTOS LEGALES','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (140,'61-01-38','PLACAS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (141,'61-01-39','REVISTAS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (142,'61-01-40','SEGURO VEHICULOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (143,'61-01-41','AUDITORIA EXTERNA','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (144,'61-01-42','ASSESORIAS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (145,'61-01-43','HONORARIOS PROFESIONALES','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (146,'61-01-44','VIGILANCIA Y SEGURIDAD','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (147,'61-01-45','REPARACION EDIFIACIONES PROPIAS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (148,'61-01-46','MANTENIMIENTO EDIFICACION','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (149,'61-01-47','MANTENIMIENTO Y REPARACION EQUIPOS DE COMPUTO','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (150,'61-01-48','INTERESES SOBRE PRESTAMOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (151,'61-01-49','COMISIONES BANCARIAS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (152,'61-01-50','COMISION 1.5% SOBRE PAGO DE CHEQUES','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (153,'61-01-51','CARGOS POR CK. DEVUELTOS DEPOSITADOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (154,'61-01-52','COMISIONES SOBRE TRANSFERENCIAS BANCARIAS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (155,'61-01-53','EMISION DE CHEQUERAS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (156,'61-01-54','OTROS CARGOS Y COMISIONES BANCARIAS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (158,'61-01-56','GARANTIA EN VENTA','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'ADMIN','2009-12-01 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (159,'61-01-57','IMPUESTOS PO LETREROS Y CRUSACALLES','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (160,'61-01-58','GASTOS DE GARANTIA','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (162,'61-01-99','OTROS GASTOS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'Admin','2007-07-04 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (163,'13-01-06','INVENTARIO DE CILINDRO 50','DEBITO','ACTIVOS','AUXILIAR','13',0,0,0,'ADMIN','2007-07-05 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (164,'13-01-07','INVENTARIO DE CILINDRO 100','DEBITO','ACTIVOS','AUXILIAR','13',0,0,0,'ADMIN','2007-07-05 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (165,'41-01-05','DESCUENTO EN VENTAS','CREDITO','INGRESOS','AUXILIAR','41',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO','SI',NULL,'-');
INSERT INTO `tbl_catalogo_cta` VALUES (166,'41-01-06','DEVOLUCIONES EN VENTAS','CREDITO','INGRESOS','AUXILIAR','41',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO','SI','1','-');
INSERT INTO `tbl_catalogo_cta` VALUES (167,'13-01-08','INVENTARIO INVERSORES 1.5 KILOS','DEBITO','ACTIVOS','AUXILIAR','13',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (168,'13-01-09','INVENTARIO INVERSORES 2.5 KILOS','DEBITO','ACTIVOS','AUXILIAR','13',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (169,'13-01-10','INVENTARIO INVERSORES 3.6 KILOS','DEBITO','ACTIVOS','AUXILIAR','13',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (170,'13-01-11','INVENTARIO INVERSORES 4.8 KILOS','DEBITO','ACTIVOS','AUXILIAR','13',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (171,'13-01-12','INVENTARIO INVERSORES 6.0 KILOS','DEBITO','ACTIVOS','AUXILIAR','13',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (172,'13-01-13','INVENTARIO INVERSORES 8.0 KILOS','DEBITO','ACTIVOS','AUXILIAR','13',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (173,'51-01-04','CILINDROS  50 LIBRAS','DEBITO','COSTOS','AUXILIAR','51',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (174,'51-01-05','CILINDROS 100 LIBRAS','DEBITO','COSTOS','AUXILIAR','51',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (175,'51-01-06','INVERSORES 1.5 KILOS','DEBITO','COSTOS','AUXILIAR','51',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (176,'51-01-07','INVERSORES 2.5 KILOS','DEBITO','COSTOS','AUXILIAR','51',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (177,'51-01-08','INVERSORES 3.6 KILOS','DEBITO','COSTOS','AUXILIAR','51',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (178,'51-01-09','INVERSORES 4.8 KILOS','DEBITO','COSTOS','AUXILIAR','51',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (179,'51-01-10','INVERSORES 6 KILOS','DEBITO','COSTOS','AUXILIAR','51',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (180,'51-01-11','INVERSORES 8 KILOS','DEBITO','COSTOS','AUXILIAR','51',0,0,0,'ADMIN','2007-07-17 00:00:00','N',0,0,'NO',NULL,NULL,NULL);
INSERT INTO `tbl_catalogo_cta` VALUES (181,'61-01-59','COMIDA PERROS','DEBITO','GASTOS','AUXILIAR','61',0,0,0,'ADMIN','2010-04-01 00:00:00','N',0,0,'NO','SI','0','-');
INSERT INTO `tbl_categorias_productos` VALUES (1,'GENERAL');
INSERT INTO `tbl_cod_conduces` VALUES (1,0,0);
INSERT INTO `tbl_cod_cotizaciones` VALUES (1,0,0);
INSERT INTO `tbl_cod_fact` VALUES (1,0,0);
INSERT INTO `tbl_cod_fact_dev` VALUES (1,0,0);
INSERT INTO `tbl_cod_recepcion` VALUES (1,0,0);
INSERT INTO `tbl_maestro_vendedor` VALUES (1,'LOCAL',0,0,0);
INSERT INTO `tbl_product_label` VALUES ('0','0','0','0');
INSERT INTO `tbl_modulos` VALUES(1,'False','False','False','False','False');
