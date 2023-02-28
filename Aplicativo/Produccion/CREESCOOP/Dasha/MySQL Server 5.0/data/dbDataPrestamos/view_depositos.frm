TYPE=VIEW
query=select `dbdataprestamos`.`tbl_bancos`.`fld_id` AS `fld_id`,`dbdataprestamos`.`tbl_bancos`.`fld_nombre` AS `fld_nombre`,`dbdataprestamos`.`tbl_bancos`.`fld_cuenta` AS `fld_cuenta`,`dbdataprestamos`.`tbl_bancos`.`fld_cta_contable` AS `fld_cta_contable`,`dbdataprestamos`.`tbl_bancos`.`fld_contacto` AS `fld_contacto`,`dbdataprestamos`.`tbl_bancos`.`fld_sucursal` AS `fld_sucursal`,`dbdataprestamos`.`tbl_bancos`.`fld_balance` AS `fld_balance`,`dbdataprestamos`.`tbl_bancos`.`fld_status` AS `fld_status`,`dbdataprestamos`.`tbl_bancos`.`fld_direccion` AS `fld_direccion`,`dbdataprestamos`.`tbl_bancos`.`fld_codigo` AS `fld_codigo`,`dbdataprestamos`.`tbl_bancos`.`fld_tt_ck` AS `fld_tt_ck`,`dbdataprestamos`.`tbl_bancos`.`fld_tt_dep` AS `fld_tt_dep`,`dbdataprestamos`.`tbl_bancos`.`fld_tt_nc` AS `fld_tt_nc`,`dbdataprestamos`.`tbl_bancos`.`fld_tt_nd` AS `fld_tt_nd`,`dbdataprestamos`.`tbl_deposito`.`fld_id_doc` AS `fld_id_doc`,`dbdataprestamos`.`tbl_deposito`.`fld_id_banco` AS `fld_id_banco`,`dbdataprestamos`.`tbl_deposito`.`fld_fecha` AS `fld_fecha`,`dbdataprestamos`.`tbl_deposito`.`fld_descripcion` AS `fld_descripcion`,`dbdataprestamos`.`tbl_deposito`.`fld_monto` AS `fld_monto`,`dbdataprestamos`.`tbl_deposito`.`fld_estado` AS `fld_estado`,`dbdataprestamos`.`tbl_deposito`.`fld_transito` AS `fld_transito`,`dbdataprestamos`.`tbl_deposito`.`fld_cod_concepto` AS `fld_cod_concepto`,`dbdataprestamos`.`tbl_deposito`.`afectacaja` AS `afectacaja` from (`dbdataprestamos`.`tbl_bancos` join `dbdataprestamos`.`tbl_deposito`) where (`dbdataprestamos`.`tbl_bancos`.`fld_codigo` = `dbdataprestamos`.`tbl_deposito`.`fld_id_banco`)
md5=704a87bc91da401edb207b07acee3052
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=1
with_check_option=0
revision=1
timestamp=2020-10-13 09:22:51
create-version=1
source=SELECT\n  *\nFROM (`tbl_bancos`\n   JOIN `tbl_deposito`)\nWHERE (`tbl_bancos`.`fld_codigo` = `tbl_deposito`.`fld_id_banco`)
