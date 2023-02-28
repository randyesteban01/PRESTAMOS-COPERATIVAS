TYPE=VIEW
query=(select `s`.`fldSupplierID` AS `fldSupplierID`,`s`.`fldCompany` AS `fldCompany`,`s`.`fldAddress` AS `fldAddress`,`s`.`fldPhone` AS `fldPhone`,`s`.`fldContact` AS `fldContact`,`s`.`fldLimiteCR` AS `fldLimiteCR`,`s`.`fldBalance` AS `fldBalance`,`s`.`fld_Status` AS `fld_Status`,`s`.`fldBy` AS `fldBy`,`s`.`fldfax` AS `fldfax`,`s`.`fldcel` AS `fldcel`,`s`.`fld_clasificacion` AS `fld_clasificacion`,`s`.`fld_cta_contable` AS `fld_cta_contable`,`s`.`fld_telefono` AS `fld_telefono`,`s`.`fld_correo` AS `fld_correo`,`s`.`fld_banco` AS `fld_banco`,`n`.`fld_id` AS `fld_id`,`n`.`fld_proveedor_id_nd` AS `fld_proveedor_id_nd`,`n`.`fld_fecha` AS `fld_fecha`,`n`.`fld_concepto` AS `fld_concepto`,`n`.`fld_monto` AS `fld_monto`,`n`.`fld_user` AS `fld_user`,`n`.`fldstatus` AS `fldstatus`,`n`.`fld_doc_afectado` AS `fld_doc_afectado`,`n`.`fld_doc_afectado_id` AS `fld_doc_afectado_id`,`n`.`fld_ncf_nd_cxp` AS `fld_ncf_nd_cxp` from (`dbdataprestamos`.`tbl_supplier` `s` join `dbdataprestamos`.`tbl_nd_cxp` `n`) where (`s`.`fldSupplierID` = `n`.`fld_proveedor_id_nd`))
md5=e56770447f017860b986e70291abe239
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=1
with_check_option=0
timestamp=2016-04-05 00:36:53
create-version=1
source=(select `s`.`fldSupplierID` AS `fldSupplierID`,`s`.`fldCompany` AS `fldCompany`,`s`.`fldAddress` AS `fldAddress`,`s`.`fldPhone` AS `fldPhone`,`s`.`fldContact` AS `fldContact`,`s`.`fldLimiteCR` AS `fldLimiteCR`,`s`.`fldBalance` AS `fldBalance`,`s`.`fld_Status` AS `fld_Status`,`s`.`fldBy` AS `fldBy`,`s`.`fldfax` AS `fldfax`,`s`.`fldcel` AS `fldcel`,`s`.`fld_clasificacion` AS `fld_clasificacion`,`s`.`fld_cta_contable` AS `fld_cta_contable`,`s`.`fld_telefono` AS `fld_telefono`,`s`.`fld_correo` AS `fld_correo`,`s`.`fld_banco` AS `fld_banco`,`n`.`fld_id` AS `fld_id`,`n`.`fld_proveedor_id_nd` AS `fld_proveedor_id_nd`,`n`.`fld_fecha` AS `fld_fecha`,`n`.`fld_concepto` AS `fld_concepto`,`n`.`fld_monto` AS `fld_monto`,`n`.`fld_user` AS `fld_user`,`n`.`fldstatus` AS `fldstatus`,`n`.`fld_doc_afectado` AS `fld_doc_afectado`,`n`.`fld_doc_afectado_id` AS `fld_doc_afectado_id`,`n`.`fld_ncf_nd_cxp` AS `fld_ncf_nd_cxp` from (`tbl_supplier` `s` join `tbl_nd_cxp` `n`) where (`s`.`fldSupplierID` = `n`.`fld_proveedor_id_nd`))
