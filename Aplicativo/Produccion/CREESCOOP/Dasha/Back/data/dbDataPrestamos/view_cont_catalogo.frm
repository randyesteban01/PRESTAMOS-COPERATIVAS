TYPE=VIEW
query=(select `cg`.`ID` AS `IDg`,`cg`.`Descripcion` AS `Descripciong`,`cg`.`Origen` AS `Origen`,`c`.`ID` AS `ID`,`c`.`CuentaNo` AS `CuentaNo`,`c`.`Descripcion` AS `Descripcion`,`c`.`Grupo` AS `Grupo`,`c`.`Tipo` AS `Tipo`,`c`.`Debito` AS `Debito`,`c`.`Credito` AS `Credito`,`c`.`Balance` AS `Balance`,`c`.`CtaControl` AS `CtaControl`,`c`.`NombreMes` AS `NombreMes`,`c`.`NumeroMes` AS `NumeroMes`,`c`.`BalanceGeneral` AS `BalanceGeneral`,`c`.`EstadoResultado` AS `EstadoResultado`,`c`.`OrdenEstadoResultado` AS `OrdenEstadoResultado`,`c`.`AccionEstatoResultado` AS `AccionEstatoResultado`,`c`.`VerEnCero` AS `VerEnCero`,`c`.`Fecha` AS `Fecha`,`c`.`Usuario` AS `Usuario` from (`dbdataprestamos`.`tbl_catalogo` `c` join `dbdataprestamos`.`tbl_catalogo_grupo` `cg`) where (`c`.`Grupo` = `cg`.`ID`))
md5=29208d5ce2386f3656f2010d568800ac
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=1
with_check_option=0
timestamp=2016-04-05 00:35:36
create-version=1
source=(select `cg`.`ID` AS `IDg`,`cg`.`Descripcion` AS `Descripciong`,`cg`.`Origen` AS `Origen`,`c`.`ID` AS `ID`,`c`.`CuentaNo` AS `CuentaNo`,`c`.`Descripcion` AS `Descripcion`,`c`.`Grupo` AS `Grupo`,`c`.`Tipo` AS `Tipo`,`c`.`Debito` AS `Debito`,`c`.`Credito` AS `Credito`,`c`.`Balance` AS `Balance`,`c`.`CtaControl` AS `CtaControl`,`c`.`NombreMes` AS `NombreMes`,`c`.`NumeroMes` AS `NumeroMes`,`c`.`BalanceGeneral` AS `BalanceGeneral`,`c`.`EstadoResultado` AS `EstadoResultado`,`c`.`OrdenEstadoResultado` AS `OrdenEstadoResultado`,`c`.`AccionEstatoResultado` AS `AccionEstatoResultado`,`c`.`VerEnCero` AS `VerEnCero`,`c`.`Fecha` AS `Fecha`,`c`.`Usuario` AS `Usuario` from (`tbl_catalogo` `c` join `tbl_catalogo_grupo` `cg`) where (`c`.`Grupo` = `cg`.`ID`))
