TYPE=VIEW
query=select `td`.`TransDID` AS `TransDID`,`td`.`TransDIDTrans` AS `TransDIDTrans`,`td`.`TransDCuentaNo` AS `TransDCuentaNo`,`td`.`TransDDescripcionCuenta` AS `TransDDescripcionCuenta`,`td`.`TransDDebito` AS `TransDDebito`,`td`.`TransDCredito` AS `TransDCredito`,`td`.`TransDBalance` AS `TransDBalance`,`t`.`TransID` AS `TransID`,`t`.`TransFecha` AS `TransFecha`,`t`.`TransFechaMovimiento` AS `TransFechaMovimiento`,`t`.`TransDescripcion` AS `TransDescripcion`,`t`.`TransIDTipo` AS `TransIDTipo`,`t`.`TransUsuario` AS `TransUsuario`,`t`.`TransEstado` AS `TransEstado`,`t`.`TransIDDoc` AS `TransIDDoc`,`t`.`TransDoc` AS `TransDoc`,`t`.`TransDocDetalle` AS `TransDocDetalle`,`c`.`ID` AS `ID`,`c`.`CuentaNo` AS `CuentaNo`,`c`.`Descripcion` AS `Descripcion`,`c`.`Grupo` AS `Grupo`,`c`.`Tipo` AS `Tipo`,`c`.`Debito` AS `Debito`,`c`.`Credito` AS `Credito`,`c`.`Balance` AS `Balance`,`c`.`CtaControl` AS `CtaControl`,`c`.`NombreMes` AS `NombreMes`,`c`.`NumeroMes` AS `NumeroMes`,`c`.`BalanceGeneral` AS `BalanceGeneral`,`c`.`EstadoResultado` AS `EstadoResultado`,`c`.`OrdenEstadoResultado` AS `OrdenEstadoResultado`,`c`.`AccionEstatoResultado` AS `AccionEstatoResultado`,`c`.`VerEnCero` AS `VerEnCero`,`c`.`Fecha` AS `Fecha`,`c`.`Usuario` AS `Usuario` from (`dbdataprestamos`.`tbl_interfasecontabletransaccionesdetalles` `td` join `dbdataprestamos`.`tbl_interfascontabletransacciones` `t` join `dbdataprestamos`.`tbl_catalogo` `c`) where ((`td`.`TransDIDTrans` = `t`.`TransID`) and (`td`.`TransDCuentaNo` = `c`.`CuentaNo`))
md5=4f1cfba361ad4add442649f457080f48
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=1
with_check_option=0
timestamp=2016-04-05 00:36:45
create-version=1
source=select \n*\nfrom (tbl_interfasecontabletransaccionesdetalles AS td, tbl_interfascontabletransacciones AS t, tbl_catalogo as  c) \nwhere (td.TransDIDTrans=t.TransID and td.TransDCuentaNo=c.CuentaNo)
