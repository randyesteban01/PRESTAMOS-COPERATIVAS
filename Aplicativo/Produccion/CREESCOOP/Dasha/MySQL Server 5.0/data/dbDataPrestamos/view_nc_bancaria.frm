TYPE=VIEW
query=select `dbdataprestamos`.`tbl_bancos`.`fld_id` AS `fld_id`,`dbdataprestamos`.`tbl_bancos`.`fld_nombre` AS `fld_nombre`,`dbdataprestamos`.`tbl_bancos`.`fld_cuenta` AS `fld_cuenta`,`dbdataprestamos`.`tbl_bancos`.`fld_cta_contable` AS `fld_cta_contable`,`dbdataprestamos`.`tbl_bancos`.`fld_contacto` AS `fld_contacto`,`dbdataprestamos`.`tbl_bancos`.`fld_sucursal` AS `fld_sucursal`,`dbdataprestamos`.`tbl_bancos`.`fld_balance` AS `fld_balance`,`dbdataprestamos`.`tbl_bancos`.`fld_status` AS `fld_status`,`dbdataprestamos`.`tbl_bancos`.`fld_direccion` AS `fld_direccion`,`dbdataprestamos`.`tbl_bancos`.`fld_codigo` AS `fld_codigo`,`dbdataprestamos`.`tbl_bancos`.`fld_tt_ck` AS `fld_tt_ck`,`dbdataprestamos`.`tbl_bancos`.`fld_tt_dep` AS `fld_tt_dep`,`dbdataprestamos`.`tbl_bancos`.`fld_tt_nc` AS `fld_tt_nc`,`dbdataprestamos`.`tbl_bancos`.`fld_tt_nd` AS `fld_tt_nd`,`dbdataprestamos`.`tbl_nc_bancaria`.`fld_id_doc` AS `fld_id_doc`,`dbdataprestamos`.`tbl_nc_bancaria`.`fld_id_banco` AS `fld_id_banco`,`dbdataprestamos`.`tbl_nc_bancaria`.`fld_fecha` AS `fld_fecha`,`dbdataprestamos`.`tbl_nc_bancaria`.`fld_descripcion` AS `fld_descripcion`,`dbdataprestamos`.`tbl_nc_bancaria`.`fld_monto` AS `fld_monto`,`dbdataprestamos`.`tbl_nc_bancaria`.`fld_estado` AS `fld_estado`,`dbdataprestamos`.`tbl_nc_bancaria`.`fld_transito` AS `fld_transito` from (`dbdataprestamos`.`tbl_bancos` join `dbdataprestamos`.`tbl_nc_bancaria`) where (`dbdataprestamos`.`tbl_bancos`.`fld_id` = `dbdataprestamos`.`tbl_nc_bancaria`.`fld_id_banco`)
md5=da7bb9d5fa82c6f8af97cb2aee37882f
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=1
with_check_option=0
timestamp=2016-04-05 00:36:47
create-version=1
source=select `tbl_bancos`.`fld_id` AS `fld_id`,`tbl_bancos`.`fld_nombre` AS `fld_nombre`,`tbl_bancos`.`fld_cuenta` AS `fld_cuenta`,`tbl_bancos`.`fld_cta_contable` AS `fld_cta_contable`,`tbl_bancos`.`fld_contacto` AS `fld_contacto`,`tbl_bancos`.`fld_sucursal` AS `fld_sucursal`,`tbl_bancos`.`fld_balance` AS `fld_balance`,`tbl_bancos`.`fld_status` AS `fld_status`,`tbl_bancos`.`fld_direccion` AS `fld_direccion`,`tbl_bancos`.`fld_codigo` AS `fld_codigo`,`tbl_bancos`.`fld_tt_ck` AS `fld_tt_ck`,`tbl_bancos`.`fld_tt_dep` AS `fld_tt_dep`,`tbl_bancos`.`fld_tt_nc` AS `fld_tt_nc`,`tbl_bancos`.`fld_tt_nd` AS `fld_tt_nd`,`tbl_nc_bancaria`.`fld_id_doc` AS `fld_id_doc`,`tbl_nc_bancaria`.`fld_id_banco` AS `fld_id_banco`,`tbl_nc_bancaria`.`fld_fecha` AS `fld_fecha`,`tbl_nc_bancaria`.`fld_descripcion` AS `fld_descripcion`,`tbl_nc_bancaria`.`fld_monto` AS `fld_monto`,`tbl_nc_bancaria`.`fld_estado` AS `fld_estado`,`tbl_nc_bancaria`.`fld_transito` AS `fld_transito` from (`tbl_bancos` join `tbl_nc_bancaria`) where (`tbl_bancos`.`fld_id` = `tbl_nc_bancaria`.`fld_id_banco`)