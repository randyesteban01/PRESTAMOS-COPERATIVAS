TYPE=VIEW
query=select `dbdataprestamos`.`tbl_catalogo`.`Descripcion` AS `Descripcion` from `dbdataprestamos`.`tbl_catalogo` where (`dbdataprestamos`.`tbl_catalogo`.`CuentaNo` in (_latin1\'101-01-01-01\',_latin1\'101-01-01-02\',_latin1\'101-01-01-03\',_latin1\'101-01-01-04\',_latin1\'101-01-01-05\',_latin1\'101-01-01-06\',_latin1\'101-01-02\',_latin1\'101-01-02-01\',_latin1\'101-01-02-02\',_latin1\'101-01-02-03\'))
md5=c28320f2bb2c1ff03081ff7da6ac1c6d
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=1
with_check_option=0
revision=1
timestamp=2022-05-27 12:57:03
create-version=1
source=SELECT\n  `tbl_catalogo`.`Descripcion` AS `Descripcion`\nFROM `tbl_catalogo`\nWHERE (`tbl_catalogo`.`CuentaNo` IN(_latin1\'101-01-01-01\',_latin1\'101-01-01-02\',_latin1\'101-01-01-03\',_latin1\'101-01-01-04\',_latin1\'101-01-01-05\',_latin1\'101-01-01-06\',_latin1\'101-01-02\',_latin1\'101-01-02-01\',_latin1\'101-01-02-02\',_latin1\'101-01-02-03\'))
