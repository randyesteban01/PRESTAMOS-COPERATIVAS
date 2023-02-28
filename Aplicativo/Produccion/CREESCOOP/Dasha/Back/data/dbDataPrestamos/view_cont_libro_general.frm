TYPE=VIEW
query=select `t`.`TransID` AS `TransID`,`t`.`TransFecha` AS `TransFecha`,`t`.`TransFechaMovimiento` AS `TransFechaMovimiento`,`t`.`TransDescripcion` AS `TransDescripcion`,`t`.`TransIDTipo` AS `TransIDTipo`,`t`.`TransUsuario` AS `TransUsuario`,`t`.`TransEstado` AS `TransEstado`,`t`.`TransIDDoc` AS `TransIDDoc`,`t`.`TransDoc` AS `TransDoc`,`t`.`TransDocDetalle` AS `TransDocDetalle`,`td`.`TransDID` AS `TransDID`,`td`.`TransDIDTrans` AS `TransDIDTrans`,`td`.`TransDCuentaNo` AS `TransDCuentaNo`,`td`.`TransDDescripcionCuenta` AS `TransDDescripcionCuenta`,`td`.`TransDDebito` AS `TransDDebito`,`td`.`TransDCredito` AS `TransDCredito`,`td`.`TransDBalance` AS `TransDBalance`,`c`.`ID` AS `ID`,`c`.`CuentaNo` AS `CuentaNo`,`c`.`Descripcion` AS `Descripcion`,`c`.`Grupo` AS `Grupo`,`c`.`Tipo` AS `Tipo`,`c`.`Debito` AS `Debito`,`c`.`Credito` AS `Credito`,`c`.`Balance` AS `Balance`,`c`.`CtaControl` AS `CtaControl`,`c`.`NombreMes` AS `NombreMes`,`c`.`NumeroMes` AS `NumeroMes`,`c`.`BalanceAnterior` AS `BalanceAnterior`,`c`.`BalanceGeneral` AS `BalanceGeneral`,`c`.`EstadoResultado` AS `EstadoResultado`,`c`.`OrdenEstadoResultado` AS `OrdenEstadoResultado`,`c`.`AccionEstatoResultado` AS `AccionEstatoResultado`,`c`.`VerEnCero` AS `VerEnCero`,`c`.`Fecha` AS `Fecha`,`c`.`Usuario` AS `Usuario` from ((`dbdataprestamos`.`tbl_interfascontabletransacciones` `t` join `dbdataprestamos`.`tbl_interfasecontabletransaccionesdetalles` `td`) join `dbdataprestamos`.`tbl_catalogo` `c`) where ((`td`.`TransDIDTrans` = `t`.`TransID`) and (`td`.`TransDCuentaNo` = `c`.`CuentaNo`))
md5=57f0b032c3bc020abe508cf4191a92a6
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=1
with_check_option=0
timestamp=2016-04-05 14:43:10
create-version=1
source=select \n*\nfrom (`tbl_interfascontabletransacciones` `t` join `tbl_interfasecontabletransaccionesdetalles` `td` JOIN tbl_catalogo as c ) \nwhere (`td`.`TransDIDTrans` = `t`.`TransID`)\nand (td.TransDCuentaNo=c.CuentaNo)
