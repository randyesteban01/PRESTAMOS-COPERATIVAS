TYPE=VIEW
query=(select `s`.`fldSupplierID` AS `fldSupplierID`,`s`.`fldCompany` AS `fldCompany`,`s`.`fldAddress` AS `fldAddress`,`s`.`fldPhone` AS `fldPhone`,`s`.`fldContact` AS `fldContact`,`s`.`fldLimiteCR` AS `fldLimiteCR`,`s`.`fldBalance` AS `fldBalance`,`s`.`fld_Status` AS `fld_Status`,`s`.`fldBy` AS `fldBy`,`s`.`fldfax` AS `fldfax`,`s`.`fldcel` AS `fldcel`,`s`.`fld_clasificacion` AS `fld_clasificacion`,`s`.`fld_cta_contable` AS `fld_cta_contable`,`s`.`fld_telefono` AS `fld_telefono`,`s`.`fld_correo` AS `fld_correo`,`s`.`fld_banco` AS `fld_banco`,`e`.`fld_id_ec_p` AS `fld_id_ec_p`,`e`.`fld_date` AS `fld_date`,`e`.`fld_description` AS `fld_description`,`e`.`fld_dr` AS `fld_dr`,`e`.`fld_cr` AS `fld_cr`,`e`.`fld_bce_proveedor` AS `fld_bce_proveedor`,`e`.`fld_proveedor_id` AS `fld_proveedor_id`,`e`.`fld_tipo_doc` AS `fld_tipo_doc`,`e`.`fld_tipo_doc_id` AS `fld_tipo_doc_id`,`e`.`fld_usuario` AS `fld_usuario` from (`dbdataprestamos`.`tbl_supplier` `s` join `dbdataprestamos`.`tbl_estado_proveedor` `e`) where (`s`.`fldSupplierID` = `e`.`fld_proveedor_id`))
md5=3613c796b92ce4208579fa15e75657ec
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=1
with_check_option=0
timestamp=2016-04-05 00:36:26
create-version=1
source=(select `s`.`fldSupplierID` AS `fldSupplierID`,`s`.`fldCompany` AS `fldCompany`,`s`.`fldAddress` AS `fldAddress`,`s`.`fldPhone` AS `fldPhone`,`s`.`fldContact` AS `fldContact`,`s`.`fldLimiteCR` AS `fldLimiteCR`,`s`.`fldBalance` AS `fldBalance`,`s`.`fld_Status` AS `fld_Status`,`s`.`fldBy` AS `fldBy`,`s`.`fldfax` AS `fldfax`,`s`.`fldcel` AS `fldcel`,`s`.`fld_clasificacion` AS `fld_clasificacion`,`s`.`fld_cta_contable` AS `fld_cta_contable`,`s`.`fld_telefono` AS `fld_telefono`,`s`.`fld_correo` AS `fld_correo`,`s`.`fld_banco` AS `fld_banco`,`e`.`fld_id_ec_p` AS `fld_id_ec_p`,`e`.`fld_date` AS `fld_date`,`e`.`fld_description` AS `fld_description`,`e`.`fld_dr` AS `fld_dr`,`e`.`fld_cr` AS `fld_cr`,`e`.`fld_bce_proveedor` AS `fld_bce_proveedor`,`e`.`fld_proveedor_id` AS `fld_proveedor_id`,`e`.`fld_tipo_doc` AS `fld_tipo_doc`,`e`.`fld_tipo_doc_id` AS `fld_tipo_doc_id`,`e`.`fld_usuario` AS `fld_usuario` from (`tbl_supplier` `s` join `tbl_estado_proveedor` `e`) where (`s`.`fldSupplierID` = `e`.`fld_proveedor_id`))
