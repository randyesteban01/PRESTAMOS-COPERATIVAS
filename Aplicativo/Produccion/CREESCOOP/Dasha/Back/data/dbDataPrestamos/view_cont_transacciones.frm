TYPE=VIEW
query=(select `t`.`TransID` AS `TransID`,`t`.`TransFecha` AS `TransFecha`,`t`.`TransFechaMovimiento` AS `TransFechaMovimiento`,`t`.`TransDescripcion` AS `TransDescripcion`,`t`.`TransIDTipo` AS `TransIDTipo`,`t`.`TransUsuario` AS `TransUsuario`,`t`.`TransEstado` AS `TransEstado`,`t`.`TransIDDoc` AS `TransIDDoc`,`t`.`TransDoc` AS `TransDoc`,`t`.`TransDocDetalle` AS `TransDocDetalle`,`td`.`TransDID` AS `TransDID`,`td`.`TransDIDTrans` AS `TransDIDTrans`,`td`.`TransDCuentaNo` AS `TransDCuentaNo`,`td`.`TransDDescripcionCuenta` AS `TransDDescripcionCuenta`,`td`.`TransDDebito` AS `TransDDebito`,`td`.`TransDCredito` AS `TransDCredito`,`td`.`TransDBalance` AS `TransDBalance`,`tp`.`fld_id` AS `fld_id`,`tp`.`fld_codigo` AS `fld_codigo`,`tp`.`fld_descripcion` AS `fld_descripcion`,`tp`.`fld_modulo` AS `fld_modulo` from ((`dbdataprestamos`.`tbl_interfascontabletransacciones` `t` join `dbdataprestamos`.`tbl_interfasecontabletransaccionesdetalles` `td`) join `dbdataprestamos`.`tbl_interfascontableotrastipo` `tp`) where ((`td`.`TransDIDTrans` = `t`.`TransID`) and (`t`.`TransIDTipo` = `tp`.`fld_id`)))
md5=aee09d65e06acb09c3f243192c523b5d
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=1
with_check_option=0
timestamp=2016-04-05 00:35:58
create-version=1
source=(select `t`.`TransID` AS `TransID`,`t`.`TransFecha` AS `TransFecha`,`t`.`TransFechaMovimiento` AS `TransFechaMovimiento`,`t`.`TransDescripcion` AS `TransDescripcion`,`t`.`TransIDTipo` AS `TransIDTipo`,`t`.`TransUsuario` AS `TransUsuario`,`t`.`TransEstado` AS `TransEstado`,`t`.`TransIDDoc` AS `TransIDDoc`,`t`.`TransDoc` AS `TransDoc`,`t`.`TransDocDetalle` AS `TransDocDetalle`,`td`.`TransDID` AS `TransDID`,`td`.`TransDIDTrans` AS `TransDIDTrans`,`td`.`TransDCuentaNo` AS `TransDCuentaNo`,`td`.`TransDDescripcionCuenta` AS `TransDDescripcionCuenta`,`td`.`TransDDebito` AS `TransDDebito`,`td`.`TransDCredito` AS `TransDCredito`,`td`.`TransDBalance` AS `TransDBalance`,`tp`.`fld_id` AS `fld_id`,`tp`.`fld_codigo` AS `fld_codigo`,`tp`.`fld_descripcion` AS `fld_descripcion`,`tp`.`fld_modulo` AS `fld_modulo` from ((`tbl_interfascontabletransacciones` `t` join `tbl_interfasecontabletransaccionesdetalles` `td`) join `tbl_interfascontableotrastipo` `tp`) where ((`td`.`TransDIDTrans` = `t`.`TransID`) and (`t`.`TransIDTipo` = `tp`.`fld_id`)))
