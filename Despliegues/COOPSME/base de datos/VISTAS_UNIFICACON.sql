-- Autor: Enrique José Escobar Maradiaga
-- Fecha: 27/02/2023
-- Descripcion: Script para unificar estructura de base de datos

-- ----------------------------
--  View definition for `ventaview`
-- ----------------------------
DROP 
  VIEW IF EXISTS `ventaview`;
CREATE VIEW `ventaview` AS 
SELECT 
  venta.ID, 
  venta.DocNo, 
  venta.Fecha, 
  tbl_clientes.fld_FullName, 
  tbl_clientes.fld_apodo, 
  tbl_clientes.fld_Identity, 
  tbl_clientes.fld_Phone, 
  tbl_clientes.fld_Phone2, 
  tbl_clientes.fld_Address, 
  tbl_clientes.fld_City, 
  ventacondicion.Descripcion AS Condicion, 
  ncftipo.Descripcion AS TipoNCF, 
  venta.NCF, 
  formapago.Descripcion AS FormaPago, 
  venta.DescripcionPago, 
  vendedor.Descripcion AS Vendedor, 
  vendedor.Comision, 
  moneda.Descripcion AS Moneda, 
  moneda.tasa, 
  venta.Nota AS NotaVenta, 
  almacen.Descripcion AS Almacen, 
  venta.Monto, 
  venta.Itbis, 
  venta.Descuento, 
  venta.Abono, 
  vehiculotipo.Descripcion AS TipoVehiculo, 
  vehiculomarca.Descripcion AS Marca, 
  vehiculomodelo.Descripcion AS Modelo, 
  ventadetallefinanciamiento.Chasis, 
  vehiculoestado.Descripcion AS EstadoVehiculo, 
  vehiculocolor.Descripcion AS Color, 
  vehiculotransmision.Descripcion AS Transmision, 
  vehiculotraccion.Descripcion AS Traccion, 
  ventadetallefinanciamiento.Kilometraje, 
  ventadetallefinanciamiento.Ano, 
  ventadetallefinanciamiento.Importado, 
  ventadetallefinanciamiento.Nota, 
  ventadetallefinanciamiento.Caracteristicas 
FROM 
  venta 
  INNER JOIN ventadetallefinanciamiento ON venta.ID = ventadetallefinanciamiento.IDVenta 
  INNER JOIN tbl_clientes ON tbl_clientes.fld_id = venta.IDCliente 
  INNER JOIN ventacondicion ON ventacondicion.ID = venta.IDCondicion 
  INNER JOIN ncftipo ON ncftipo.ID = venta.IDTipoNCF 
  INNER JOIN formapago ON formapago.ID = venta.IDFormaPago 
  INNER JOIN vendedor ON vendedor.ID = venta.IDVendedor 
  INNER JOIN moneda ON moneda.ID = venta.IDMoneda 
  INNER JOIN almacen ON almacen.ID = venta.IDAlmacen 
  INNER JOIN vehiculotipo ON vehiculotipo.ID = ventadetallefinanciamiento.IDTipo 
  INNER JOIN vehiculomarca ON vehiculomarca.ID = ventadetallefinanciamiento.IDMarca 
  INNER JOIN vehiculomodelo ON vehiculomodelo.ID = ventadetallefinanciamiento.IDModelo 
  INNER JOIN vehiculoestado ON vehiculoestado.ID = ventadetallefinanciamiento.IDEstado 
  INNER JOIN vehiculocolor ON vehiculocolor.ID = ventadetallefinanciamiento.IDColor 
  INNER JOIN vehiculotransmision ON vehiculotransmision.ID = ventadetallefinanciamiento.IDTransmision 
  INNER JOIN vehiculotraccion ON vehiculotraccion.ID = ventadetallefinanciamiento.IDTraccion;
-- ----------------------------
--  View definition for `view_ahorros`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_ahorros`;
CREATE VIEW `view_ahorros` AS (
  select 
    distinct `a`.`ID` AS `ID`, 
    `a`.`IDCliente` AS `IDCliente`, 
    `a`.`CuentaNo` AS `CuentaNo`, 
    `a`.`FechaApertura` AS `FechaApertura`, 
    `a`.`FechaCancelada` AS `FechaCancelada`, 
    `a`.`TasaIteres` AS `TasaIteres`, 
    `a`.`SaldoCapital` AS `SaldoCapital`, 
    `a`.`SaldoInteres` AS `SaldoInteres`, 
    `a`.`SaldoRetiros` AS `SaldoRetiros`, 
    `a`.`Usuario` AS `Usuario`, 
    `a`.`Nota` AS `Nota`, 
    `a`.`Categoria` AS `Categoria`, 
    `a`.`Estado` AS `Estado`, 
    `ac`.`Descripcion` AS `Descripcion`, 
    `c`.`fld_id` AS `fld_id`, 
    `c`.`TipoDocumento` AS `TipoDocumento`, 
    `c`.`fld_FullName` AS `fld_FullName`, 
    `c`.`fld_apodo` AS `fld_apodo`, 
    `c`.`fld_Identity` AS `fld_Identity`, 
    `c`.`fld_Phone` AS `fld_Phone`, 
    `c`.`fld_Phone2` AS `fld_Phone2`, 
    `c`.`fld_Address` AS `fld_Address`, 
    `c`.`fld_City_id` AS `fld_City_id`, 
    `c`.`fld_City` AS `fld_City`, 
    `c`.`fld_Status` AS `fld_Status`, 
    `c`.`fld_bce` AS `fld_bce`, 
    `c`.`fld_cod_zona` AS `fld_cod_zona`, 
    `c`.`fld_zona` AS `fld_zona`, 
    `c`.`fld_nombre_con` AS `fld_nombre_con`, 
    `c`.`fld_apodo_con` AS `fld_apodo_con`, 
    `c`.`fld_cedula_con` AS `fld_cedula_con`, 
    `c`.`fld_telefono_con` AS `fld_telefono_con`, 
    `c`.`fld_celular_con` AS `fld_celular_con`, 
    `c`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`, 
    `c`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`, 
    `c`.`fld_nombre_gar` AS `fld_nombre_gar`, 
    `c`.`fld_apodo_gar` AS `fld_apodo_gar`, 
    `c`.`fld_cedula_gar` AS `fld_cedula_gar`, 
    `c`.`fld_telefono_gar` AS `fld_telefono_gar`, 
    `c`.`fld_celular_gar` AS `fld_celular_gar`, 
    `c`.`fld_direccion_gar` AS `fld_direccion_gar`, 
    `c`.`fld_ciudad_gar` AS `fld_ciudad_gar`, 
    `c`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`, 
    `c`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`, 
    `c`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`, 
    `c`.`fld_nombre_banco1` AS `fld_nombre_banco1`, 
    `c`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`, 
    `c`.`fld_nombre_banco2` AS `fld_nombre_banco2`, 
    `c`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`, 
    `c`.`fld_otra_informacion` AS `fld_otra_informacion`, 
    `c`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`, 
    `c`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`, 
    `c`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`, 
    `c`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`, 
    `c`.`fld_celular_con_gar` AS `fld_celular_con_gar`, 
    `c`.`fld_edad` AS `fld_edad`, 
    `c`.`fld_estado_civil` AS `fld_estado_civil`, 
    `c`.`fld_edad_gar` AS `fld_edad_gar`, 
    `c`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`, 
    `c`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`, 
    `c`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`, 
    `c`.`fld_sector_id` AS `fld_sector_id`, 
    `c`.`fld_sector` AS `fld_sector`, 
    `c`.`fld_categoria` AS `fld_categoria`, 
    `c`.`fld_limite` AS `fld_limite`, 
    `c`.`Puesto` AS `Puesto`, 
    `c`.`TimpoTrabajo` AS `TimpoTrabajo`, 
    `c`.`ReferidoPor` AS `ReferidoPor`, 
    `c`.`Oriundo` AS `Oriundo`, 
    `c`.`DataCredito` AS `DataCredito`, 
    `ar`.`IDAhorro` AS `idAhorro`, 
    `ad`.`IDCuenta` AS `idcuenta`, 
    ad.Monto as Deposito, 
    ad.fecha as Fecha 
  from 
    (
      (
        (
          (
            `tbl_ahorros_cuentas` `a` 
            join `tbl_ahorros_categorias` `ac` on (
              (`a`.`Categoria` = `ac`.`ID`)
            )
          ) 
          join `tbl_clientes` `c` on (
            (`c`.`fld_id` = `a`.`IDCliente`)
          )
        ) 
        join `tbl_ahorros_retiros` `ar` on (
          (`ar`.`IDCliente` = `c`.`fld_id`)
        )
      ) 
      join `tbl_ahorros_depositos` `ad` on (
        (
          `ad`.`IDCliente` = `ar`.`IDCliente`
        )
      )
    ) 
  group by 
    `a`.`ID`
);
-- ----------------------------
--  View definition for `view_ahorros_depositos`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_ahorros_depositos`;
CREATE VIEW `view_ahorros_depositos` AS (
  SELECT 
    d.*, 
    c.*, 
    ac.CuentaNo 
  FROM 
    tbl_ahorros_depositos AS d, 
    tbl_clientes AS c, 
    tbl_ahorros_cuentas AS ac 
  WHERE 
    d.IDCliente = c.fld_id 
    AND ac.ID = d.IDCuenta
);
-- ----------------------------
--  View definition for `view_ahorros_retiros`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_ahorros_retiros`;
CREATE VIEW `view_ahorros_retiros` AS (
  SELECT 
    * 
  FROM 
    tbl_clientes AS c, 
    tbl_ahorros_retiros as ar 
  where 
    ar.IDCliente = c.fld_id
);
-- ----------------------------
--  View definition for `view_clientes_con_prestamos`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_clientes_con_prestamos`;
CREATE VIEW `view_clientes_con_prestamos` AS 
select 
  * 
from 
  (
    `tbl_prestamos` 
    join `tbl_clientes`
  ) 
where 
  (
    `tbl_prestamos`.`fld_id_del_cliente` = `tbl_clientes`.`fld_id`
  );
-- ----------------------------
--  View definition for `view_cont_catalogo`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_cont_catalogo`;
CREATE VIEW `view_cont_catalogo` AS (
  select 
    `cg`.`ID` AS `IDg`, 
    `cg`.`Descripcion` AS `Descripciong`, 
    `cg`.`Origen` AS `Origen`, 
    `c`.`ID` AS `ID`, 
    `c`.`CuentaNo` AS `CuentaNo`, 
    `c`.`Descripcion` AS `Descripcion`, 
    `c`.`Grupo` AS `Grupo`, 
    `c`.`Tipo` AS `Tipo`, 
    `c`.`Debito` AS `Debito`, 
    `c`.`Credito` AS `Credito`, 
    `c`.`Balance` AS `Balance`, 
    `c`.`CtaControl` AS `CtaControl`, 
    `c`.`NombreMes` AS `NombreMes`, 
    `c`.`NumeroMes` AS `NumeroMes`, 
    `c`.`BalanceGeneral` AS `BalanceGeneral`, 
    `c`.`EstadoResultado` AS `EstadoResultado`, 
    `c`.`OrdenEstadoResultado` AS `OrdenEstadoResultado`, 
    `c`.`AccionEstatoResultado` AS `AccionEstatoResultado`, 
    `c`.`VerEnCero` AS `VerEnCero`, 
    `c`.`Fecha` AS `Fecha`, 
    `c`.`Usuario` AS `Usuario` 
  from 
    (
      `tbl_catalogo` `c` 
      join `tbl_catalogo_grupo` `cg`
    ) 
  where 
    (`c`.`Grupo` = `cg`.`ID`)
);
-- ----------------------------
--  View definition for `view_cont_libro_general`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_cont_libro_general`;
CREATE VIEW `view_cont_libro_general` AS 
select 
  * 
from 
  (
    `tbl_interfascontabletransacciones` `t` 
    join `tbl_interfasecontabletransaccionesdetalles` `td` 
    JOIN tbl_catalogo as c
  ) 
where 
  (
    `td`.`TransDIDTrans` = `t`.`TransID`
  ) 
  and (td.TransDCuentaNo = c.CuentaNo);
-- ----------------------------
--  View definition for `view_cont_transacciones`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_cont_transacciones`;
CREATE VIEW `view_cont_transacciones` AS (
  select 
    `t`.`TransID` AS `TransID`, 
    `t`.`TransFecha` AS `TransFecha`, 
    `t`.`TransFechaMovimiento` AS `TransFechaMovimiento`, 
    `t`.`TransDescripcion` AS `TransDescripcion`, 
    `t`.`TransIDTipo` AS `TransIDTipo`, 
    `t`.`TransUsuario` AS `TransUsuario`, 
    `t`.`TransEstado` AS `TransEstado`, 
    `t`.`TransIDDoc` AS `TransIDDoc`, 
    `t`.`TransDoc` AS `TransDoc`, 
    `t`.`TransDocDetalle` AS `TransDocDetalle`, 
    `td`.`TransDID` AS `TransDID`, 
    `td`.`TransDIDTrans` AS `TransDIDTrans`, 
    `td`.`TransDCuentaNo` AS `TransDCuentaNo`, 
    `td`.`TransDDescripcionCuenta` AS `TransDDescripcionCuenta`, 
    `td`.`TransDDebito` AS `TransDDebito`, 
    `td`.`TransDCredito` AS `TransDCredito`, 
    `td`.`TransDBalance` AS `TransDBalance`, 
    `tp`.`fld_id` AS `fld_id`, 
    `tp`.`fld_codigo` AS `fld_codigo`, 
    `tp`.`fld_descripcion` AS `fld_descripcion`, 
    `tp`.`fld_modulo` AS `fld_modulo` 
  from 
    (
      (
        `tbl_interfascontabletransacciones` `t` 
        join `tbl_interfasecontabletransaccionesdetalles` `td`
      ) 
      join `tbl_interfascontableotrastipo` `tp`
    ) 
  where 
    (
      (
        `td`.`TransDIDTrans` = `t`.`TransID`
      ) 
      and (
        `t`.`TransIDTipo` = `tp`.`fld_id`
      )
    )
);
-- ----------------------------
--  View definition for `view_cuotas_todas`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_cuotas_todas`;
CREATE VIEW `view_cuotas_todas` AS 
select 
  * 
from 
  (
    `tbl_clientes` 
    join `tbl_cuotas`
  ) 
where 
  (
    `tbl_clientes`.`fld_id` = `tbl_cuotas`.`fld_id_del_cliente_cuotas`
  );
-- ----------------------------
--  View definition for `view_cxc_nota_credito`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_cxc_nota_credito`;
CREATE SQL SECURITY DEFINER VIEW `view_cxc_nota_credito` AS 
select 
  `tbl_clientes`.`fld_id` AS `fld_id`, 
  `tbl_clientes`.`fld_FullName` AS `fld_FullName`, 
  `tbl_clientes`.`fld_apodo` AS `fld_apodo`, 
  `tbl_clientes`.`fld_Identity` AS `fld_Identity`, 
  `tbl_clientes`.`fld_Phone` AS `fld_Phone`, 
  `tbl_clientes`.`fld_Phone2` AS `fld_Phone2`, 
  `tbl_clientes`.`fld_Address` AS `fld_Address`, 
  `tbl_clientes`.`fld_City` AS `fld_City`, 
  `tbl_clientes`.`fld_Status` AS `fld_Status`, 
  `tbl_clientes`.`fld_bce` AS `fld_bce`, 
  `tbl_clientes`.`fld_cod_zona` AS `fld_cod_zona`, 
  `tbl_clientes`.`fld_zona` AS `fld_zona`, 
  `tbl_clientes`.`fld_nombre_con` AS `fld_nombre_con`, 
  `tbl_clientes`.`fld_apodo_con` AS `fld_apodo_con`, 
  `tbl_clientes`.`fld_cedula_con` AS `fld_cedula_con`, 
  `tbl_clientes`.`fld_telefono_con` AS `fld_telefono_con`, 
  `tbl_clientes`.`fld_celular_con` AS `fld_celular_con`, 
  `tbl_clientes`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`, 
  `tbl_clientes`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`, 
  `tbl_clientes`.`fld_nombre_gar` AS `fld_nombre_gar`, 
  `tbl_clientes`.`fld_apodo_gar` AS `fld_apodo_gar`, 
  `tbl_clientes`.`fld_cedula_gar` AS `fld_cedula_gar`, 
  `tbl_clientes`.`fld_telefono_gar` AS `fld_telefono_gar`, 
  `tbl_clientes`.`fld_celular_gar` AS `fld_celular_gar`, 
  `tbl_clientes`.`fld_direccion_gar` AS `fld_direccion_gar`, 
  `tbl_clientes`.`fld_ciudad_gar` AS `fld_ciudad_gar`, 
  `tbl_clientes`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`, 
  `tbl_clientes`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`, 
  `tbl_clientes`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`, 
  `tbl_clientes`.`fld_nombre_banco1` AS `fld_nombre_banco1`, 
  `tbl_clientes`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`, 
  `tbl_clientes`.`fld_nombre_banco2` AS `fld_nombre_banco2`, 
  `tbl_clientes`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`, 
  `tbl_clientes`.`fld_otra_informacion` AS `fld_otra_informacion`, 
  `tbl_clientes`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`, 
  `tbl_clientes`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`, 
  `tbl_clientes`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`, 
  `tbl_clientes`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`, 
  `tbl_clientes`.`fld_celular_con_gar` AS `fld_celular_con_gar`, 
  `tbl_clientes`.`fld_edad` AS `fld_edad`, 
  `tbl_clientes`.`fld_estado_civil` AS `fld_estado_civil`, 
  `tbl_clientes`.`fld_edad_gar` AS `fld_edad_gar`, 
  `tbl_clientes`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`, 
  `tbl_clientes`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`, 
  `tbl_clientes`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`, 
  `tbl_nc_cxc`.`fld_id_nc_cxc` AS `fld_id_nc_cxc`, 
  `tbl_nc_cxc`.`fld_cliente_id_nc` AS `fld_cliente_id_nc`, 
  `tbl_nc_cxc`.`fld_fecha` AS `fld_fecha`, 
  `tbl_nc_cxc`.`fld_concepto` AS `fld_concepto`, 
  `tbl_nc_cxc`.`fld_monto` AS `fld_monto`, 
  `tbl_nc_cxc`.`fld_user` AS `fld_user`, 
  `tbl_nc_cxc`.`fld_status_nc` AS `fld_status_nc` 
from 
  (
    `tbl_clientes` 
    join `tbl_nc_cxc`
  ) 
where 
  (
    `tbl_clientes`.`fld_id` = `tbl_nc_cxc`.`fld_cliente_id_nc`
  );
-- ----------------------------
--  View definition for `view_cxc_nota_debito`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_cxc_nota_debito`;
CREATE VIEW `view_cxc_nota_debito` AS 
select 
  `tbl_clientes`.`fld_id` AS `fld_id`, 
  `tbl_clientes`.`fld_FullName` AS `fld_FullName`, 
  `tbl_clientes`.`fld_apodo` AS `fld_apodo`, 
  `tbl_clientes`.`fld_Identity` AS `fld_Identity`, 
  `tbl_clientes`.`fld_Phone` AS `fld_Phone`, 
  `tbl_clientes`.`fld_Phone2` AS `fld_Phone2`, 
  `tbl_clientes`.`fld_Address` AS `fld_Address`, 
  `tbl_clientes`.`fld_City` AS `fld_City`, 
  `tbl_clientes`.`fld_Status` AS `fld_Status`, 
  `tbl_clientes`.`fld_bce` AS `fld_bce`, 
  `tbl_clientes`.`fld_cod_zona` AS `fld_cod_zona`, 
  `tbl_clientes`.`fld_zona` AS `fld_zona`, 
  `tbl_clientes`.`fld_nombre_con` AS `fld_nombre_con`, 
  `tbl_clientes`.`fld_apodo_con` AS `fld_apodo_con`, 
  `tbl_clientes`.`fld_cedula_con` AS `fld_cedula_con`, 
  `tbl_clientes`.`fld_telefono_con` AS `fld_telefono_con`, 
  `tbl_clientes`.`fld_celular_con` AS `fld_celular_con`, 
  `tbl_clientes`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`, 
  `tbl_clientes`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`, 
  `tbl_clientes`.`fld_nombre_gar` AS `fld_nombre_gar`, 
  `tbl_clientes`.`fld_apodo_gar` AS `fld_apodo_gar`, 
  `tbl_clientes`.`fld_cedula_gar` AS `fld_cedula_gar`, 
  `tbl_clientes`.`fld_telefono_gar` AS `fld_telefono_gar`, 
  `tbl_clientes`.`fld_celular_gar` AS `fld_celular_gar`, 
  `tbl_clientes`.`fld_direccion_gar` AS `fld_direccion_gar`, 
  `tbl_clientes`.`fld_ciudad_gar` AS `fld_ciudad_gar`, 
  `tbl_clientes`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`, 
  `tbl_clientes`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`, 
  `tbl_clientes`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`, 
  `tbl_clientes`.`fld_nombre_banco1` AS `fld_nombre_banco1`, 
  `tbl_clientes`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`, 
  `tbl_clientes`.`fld_nombre_banco2` AS `fld_nombre_banco2`, 
  `tbl_clientes`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`, 
  `tbl_clientes`.`fld_otra_informacion` AS `fld_otra_informacion`, 
  `tbl_clientes`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`, 
  `tbl_clientes`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`, 
  `tbl_clientes`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`, 
  `tbl_clientes`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`, 
  `tbl_clientes`.`fld_celular_con_gar` AS `fld_celular_con_gar`, 
  `tbl_clientes`.`fld_edad` AS `fld_edad`, 
  `tbl_clientes`.`fld_estado_civil` AS `fld_estado_civil`, 
  `tbl_clientes`.`fld_edad_gar` AS `fld_edad_gar`, 
  `tbl_clientes`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`, 
  `tbl_clientes`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`, 
  `tbl_clientes`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`, 
  `tbl_nd_cxc`.`fld_id_nd_cxc` AS `fld_id_nd_cxc`, 
  `tbl_nd_cxc`.`fld_cliente_id_nd` AS `fld_cliente_id_nd`, 
  `tbl_nd_cxc`.`fld_fecha` AS `fld_fecha`, 
  `tbl_nd_cxc`.`fld_concepto` AS `fld_concepto`, 
  `tbl_nd_cxc`.`fld_monto` AS `fld_monto`, 
  `tbl_nd_cxc`.`fld_abono` AS `fld_abono`, 
  `tbl_nd_cxc`.`fld_balance` AS `fld_balance`, 
  `tbl_nd_cxc`.`fld_user` AS `fld_user`, 
  `tbl_nd_cxc`.`fld_status_nd` AS `fld_status_nd`, 
  `tbl_nd_cxc`.`fld_ultimo_abono` AS `fld_ultimo_abono` 
from 
  (
    `tbl_clientes` 
    join `tbl_nd_cxc`
  ) 
where 
  (
    `tbl_clientes`.`fld_id` = `tbl_nd_cxc`.`fld_cliente_id_nd`
  );
-- ----------------------------
--  View definition for `view_depositos`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_depositos`;
CREATE VIEW `view_depositos` AS 
SELECT 
  * 
FROM 
  (
    `tbl_bancos` 
    JOIN `tbl_deposito`
  ) 
WHERE 
  (
    `tbl_bancos`.`fld_codigo` = `tbl_deposito`.`fld_id_banco`
  );
-- ----------------------------
--  View definition for `view_estado_banco`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_estado_banco`;
CREATE VIEW `view_estado_banco` AS 
select 
  `tbl_estado_banco`.`fld_id_ec_b` AS `fld_id_ec_b`, 
  `tbl_estado_banco`.`fld_date` AS `fld_date`, 
  `tbl_estado_banco`.`fld_description` AS `fld_description`, 
  `tbl_estado_banco`.`fld_dr` AS `fld_dr`, 
  `tbl_estado_banco`.`fld_cr` AS `fld_cr`, 
  `tbl_estado_banco`.`fld_bce_banco` AS `fld_bce_banco`, 
  `tbl_estado_banco`.`fld_banco_id` AS `fld_banco_id`, 
  `tbl_estado_banco`.`fld_tipo_doc` AS `fld_tipo_doc`, 
  `tbl_estado_banco`.`fld_tipo_doc_id` AS `fld_tipo_doc_id`, 
  `tbl_estado_banco`.`fld_usuario` AS `fld_usuario`, 
  `tbl_bancos`.`fld_id` AS `fld_id`, 
  `tbl_bancos`.`fld_nombre` AS `fld_nombre`, 
  `tbl_bancos`.`fld_cuenta` AS `fld_cuenta`, 
  `tbl_bancos`.`fld_cta_contable` AS `fld_cta_contable`, 
  `tbl_bancos`.`fld_contacto` AS `fld_contacto`, 
  `tbl_bancos`.`fld_sucursal` AS `fld_sucursal`, 
  `tbl_bancos`.`fld_balance` AS `fld_balance`, 
  `tbl_bancos`.`fld_status` AS `fld_status`, 
  `tbl_bancos`.`fld_direccion` AS `fld_direccion`, 
  `tbl_bancos`.`fld_codigo` AS `fld_codigo`, 
  `tbl_bancos`.`fld_tt_ck` AS `fld_tt_ck`, 
  `tbl_bancos`.`fld_tt_dep` AS `fld_tt_dep`, 
  `tbl_bancos`.`fld_tt_nc` AS `fld_tt_nc`, 
  `tbl_bancos`.`fld_tt_nd` AS `fld_tt_nd` 
from 
  (
    `tbl_estado_banco` 
    join `tbl_bancos`
  ) 
where 
  (
    `tbl_estado_banco`.`fld_banco_id` = `tbl_bancos`.`fld_codigo`
  );
-- ----------------------------
--  View definition for `view_estado_clientes`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_estado_clientes`;
CREATE VIEW `view_estado_clientes` AS 
select 
  * 
from 
  (
    `tbl_clientes` 
    join `tbl_estado_clientes`
  ) 
where 
  (
    `tbl_clientes`.`fld_id` = `tbl_estado_clientes`.`fld_cliente_id`
  );
-- ----------------------------
--  View definition for `view_estado_proveedor`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_estado_proveedor`;
CREATE VIEW `view_estado_proveedor` AS (
  select 
    `s`.`fldSupplierID` AS `fldSupplierID`, 
    `s`.`fldCompany` AS `fldCompany`, 
    `s`.`fldAddress` AS `fldAddress`, 
    `s`.`fldPhone` AS `fldPhone`, 
    `s`.`fldContact` AS `fldContact`, 
    `s`.`fldLimiteCR` AS `fldLimiteCR`, 
    `s`.`fldBalance` AS `fldBalance`, 
    `s`.`fld_Status` AS `fld_Status`, 
    `s`.`fldBy` AS `fldBy`, 
    `s`.`fldfax` AS `fldfax`, 
    `s`.`fldcel` AS `fldcel`, 
    `s`.`fld_clasificacion` AS `fld_clasificacion`, 
    `s`.`fld_cta_contable` AS `fld_cta_contable`, 
    `s`.`fld_telefono` AS `fld_telefono`, 
    `s`.`fld_correo` AS `fld_correo`, 
    `s`.`fld_banco` AS `fld_banco`, 
    `e`.`fld_id_ec_p` AS `fld_id_ec_p`, 
    `e`.`fld_date` AS `fld_date`, 
    `e`.`fld_description` AS `fld_description`, 
    `e`.`fld_dr` AS `fld_dr`, 
    `e`.`fld_cr` AS `fld_cr`, 
    `e`.`fld_bce_proveedor` AS `fld_bce_proveedor`, 
    `e`.`fld_proveedor_id` AS `fld_proveedor_id`, 
    `e`.`fld_tipo_doc` AS `fld_tipo_doc`, 
    `e`.`fld_tipo_doc_id` AS `fld_tipo_doc_id`, 
    `e`.`fld_usuario` AS `fld_usuario` 
  from 
    (
      `tbl_supplier` `s` 
      join `tbl_estado_proveedor` `e`
    ) 
  where 
    (
      `s`.`fldSupplierID` = `e`.`fld_proveedor_id`
    )
);
-- ----------------------------
--  View definition for `view_generar_cuotas`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_generar_cuotas`;
CREATE VIEW `view_generar_cuotas` AS 
select 
  `tbl_clientes`.`fld_id` AS `fld_id`, 
  `tbl_clientes`.`fld_FullName` AS `fld_FullName`, 
  `tbl_clientes`.`fld_apodo` AS `fld_apodo`, 
  `tbl_clientes`.`fld_Identity` AS `fld_Identity`, 
  `tbl_clientes`.`fld_Phone` AS `fld_Phone`, 
  `tbl_clientes`.`fld_Phone2` AS `fld_Phone2`, 
  `tbl_clientes`.`fld_Address` AS `fld_Address`, 
  `tbl_clientes`.`fld_City` AS `fld_City`, 
  `tbl_clientes`.`fld_Status` AS `fld_Status`, 
  `tbl_clientes`.`fld_bce` AS `fld_bce`, 
  `tbl_clientes`.`fld_cod_zona` AS `fld_cod_zona`, 
  `tbl_clientes`.`fld_zona` AS `fld_zona`, 
  `tbl_clientes`.`fld_nombre_con` AS `fld_nombre_con`, 
  `tbl_clientes`.`fld_apodo_con` AS `fld_apodo_con`, 
  `tbl_clientes`.`fld_cedula_con` AS `fld_cedula_con`, 
  `tbl_clientes`.`fld_telefono_con` AS `fld_telefono_con`, 
  `tbl_clientes`.`fld_celular_con` AS `fld_celular_con`, 
  `tbl_clientes`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`, 
  `tbl_clientes`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`, 
  `tbl_clientes`.`fld_nombre_gar` AS `fld_nombre_gar`, 
  `tbl_clientes`.`fld_apodo_gar` AS `fld_apodo_gar`, 
  `tbl_clientes`.`fld_cedula_gar` AS `fld_cedula_gar`, 
  `tbl_clientes`.`fld_telefono_gar` AS `fld_telefono_gar`, 
  `tbl_clientes`.`fld_celular_gar` AS `fld_celular_gar`, 
  `tbl_clientes`.`fld_direccion_gar` AS `fld_direccion_gar`, 
  `tbl_clientes`.`fld_ciudad_gar` AS `fld_ciudad_gar`, 
  `tbl_clientes`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`, 
  `tbl_clientes`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`, 
  `tbl_clientes`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`, 
  `tbl_clientes`.`fld_nombre_banco1` AS `fld_nombre_banco1`, 
  `tbl_clientes`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`, 
  `tbl_clientes`.`fld_nombre_banco2` AS `fld_nombre_banco2`, 
  `tbl_clientes`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`, 
  `tbl_clientes`.`fld_otra_informacion` AS `fld_otra_informacion`, 
  `tbl_clientes`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`, 
  `tbl_clientes`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`, 
  `tbl_clientes`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`, 
  `tbl_clientes`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`, 
  `tbl_clientes`.`fld_celular_con_gar` AS `fld_celular_con_gar`, 
  `tbl_clientes`.`fld_edad` AS `fld_edad`, 
  `tbl_clientes`.`fld_estado_civil` AS `fld_estado_civil`, 
  `tbl_clientes`.`fld_edad_gar` AS `fld_edad_gar`, 
  `tbl_clientes`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`, 
  `tbl_clientes`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`, 
  `tbl_clientes`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`, 
  `tbl_clientes`.`fld_sector` AS `fld_sector`, 
  `tbl_clientes`.`fld_categoria` AS `fld_categoria`, 
  `tbl_cuotas`.`fld_id_cuotas` AS `fld_id_cuotas`, 
  `tbl_cuotas`.`fld_no_cuotas` AS `fld_no_cuotas`, 
  `tbl_cuotas`.`fld_id_del_cliente_cuotas` AS `fld_id_del_cliente_cuotas`, 
  `tbl_cuotas`.`fld_id_del_prestamo` AS `fld_id_del_prestamo`, 
  `tbl_cuotas`.`fld_fecha_entrega_cuotas` AS `fld_fecha_entrega_cuotas`, 
  `tbl_cuotas`.`fld_fecha_termina_cuotas` AS `fld_fecha_termina_cuotas`, 
  `tbl_cuotas`.`fld_fecha_ultimo_abono_cuotas` AS `fld_fecha_ultimo_abono_cuotas`, 
  `tbl_cuotas`.`fld_capital_cuota` AS `fld_capital_cuota`, 
  `tbl_cuotas`.`fld_interes_cuota` AS `fld_interes_cuota`, 
  `tbl_cuotas`.`fld_monto_cuotas` AS `fld_monto_cuotas`, 
  `tbl_cuotas`.`fld_abono_cuotas` AS `fld_abono_cuotas`, 
  `tbl_cuotas`.`fld_balance_cuotas` AS `fld_balance_cuotas`, 
  `tbl_cuotas`.`fld_usuario_cuotas` AS `fld_usuario_cuotas`, 
  `tbl_cuotas`.`fld_status_cuotas` AS `fld_status_cuotas`, 
  `tbl_cuotas`.`fld_pendiente_amortizar` AS `fld_pendiente_amortizar`, 
  `tbl_cuotas`.`fld_total_amortizado` AS `fld_total_amortizado`, 
  `tbl_cuotas`.`fld_capital_cuota_abono` AS `fld_capital_cuota_abono`, 
  `tbl_cuotas`.`fld_capital_cuota_balance` AS `fld_capital_cuota_balance`, 
  `tbl_cuotas`.`fld_interes_cuota_abono` AS `fld_interes_cuota_abono`, 
  `tbl_cuotas`.`fld_interes_cuota_balance` AS `fld_interes_cuota_balance`, 
  `tbl_cuotas`.`fld_ultimo_abono_interes` AS `fld_ultimo_abono_interes`, 
  `tbl_cuotas`.`fld_ultimo_abono_capital` AS `fld_ultimo_abono_capital`, 
  `tbl_cuotas`.`fld_monto_mora` AS `fld_monto_mora`, 
  `tbl_cuotas`.`fld_abono_mora` AS `fld_abono_mora`, 
  `tbl_cuotas`.`fld_balance_mora` AS `fld_balance_mora`, 
  `tbl_cuotas`.`fld_ultimo_abono_mora` AS `fld_ultimo_abono_mora`, 
  `tbl_cuotas`.`fld_dias_vencimiento` AS `fld_dias_vencimiento`, 
  `tbl_cuotas`.`fld_socio` AS `fld_socio`, 
  `tbl_cuotas`.`fld_atraso_cuotas` AS `fld_atraso_cuotas`, 
  `tbl_cuotas`.`fld_tipo_cuotas` AS `fld_tipo_cuotas`, 
  `tbl_cuotas`.`fld_bce_prestamo` AS `fld_bce_prestamo`, 
  `tbl_cuotas`.`fld_cant_cuotas` AS `fld_cant_cuotas` 
from 
  (
    `tbl_clientes` 
    join `tbl_cuotas`
  ) 
where 
  (
    (
      `tbl_clientes`.`fld_id` = `tbl_cuotas`.`fld_id_del_cliente_cuotas`
    )
  );
-- ----------------------------
--  View definition for `view_libro_mayor`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_libro_mayor`;
CREATE VIEW `view_libro_mayor` AS 
select 
  * 
from 
  (
    tbl_interfasecontabletransaccionesdetalles AS td, 
    tbl_interfascontabletransacciones AS t, 
    tbl_catalogo as c
  ) 
where 
  (
    td.TransDIDTrans = t.TransID 
    and td.TransDCuentaNo = c.CuentaNo
  );
-- ----------------------------
--  View definition for `view_nc_bancaria`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_nc_bancaria`;
CREATE VIEW `view_nc_bancaria` AS 
select 
  `tbl_bancos`.`fld_id` AS `fld_id`, 
  `tbl_bancos`.`fld_nombre` AS `fld_nombre`, 
  `tbl_bancos`.`fld_cuenta` AS `fld_cuenta`, 
  `tbl_bancos`.`fld_cta_contable` AS `fld_cta_contable`, 
  `tbl_bancos`.`fld_contacto` AS `fld_contacto`, 
  `tbl_bancos`.`fld_sucursal` AS `fld_sucursal`, 
  `tbl_bancos`.`fld_balance` AS `fld_balance`, 
  `tbl_bancos`.`fld_status` AS `fld_status`, 
  `tbl_bancos`.`fld_direccion` AS `fld_direccion`, 
  `tbl_bancos`.`fld_codigo` AS `fld_codigo`, 
  `tbl_bancos`.`fld_tt_ck` AS `fld_tt_ck`, 
  `tbl_bancos`.`fld_tt_dep` AS `fld_tt_dep`, 
  `tbl_bancos`.`fld_tt_nc` AS `fld_tt_nc`, 
  `tbl_bancos`.`fld_tt_nd` AS `fld_tt_nd`, 
  `tbl_nc_bancaria`.`fld_id_doc` AS `fld_id_doc`, 
  `tbl_nc_bancaria`.`fld_id_banco` AS `fld_id_banco`, 
  `tbl_nc_bancaria`.`fld_fecha` AS `fld_fecha`, 
  `tbl_nc_bancaria`.`fld_descripcion` AS `fld_descripcion`, 
  `tbl_nc_bancaria`.`fld_monto` AS `fld_monto`, 
  `tbl_nc_bancaria`.`fld_estado` AS `fld_estado`, 
  `tbl_nc_bancaria`.`fld_transito` AS `fld_transito` 
from 
  (
    `tbl_bancos` 
    join `tbl_nc_bancaria`
  ) 
where 
  (
    `tbl_bancos`.`fld_id` = `tbl_nc_bancaria`.`fld_id_banco`
  );
-- ----------------------------
--  View definition for `view_nd_bancaria`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_nd_bancaria`;
CREATE VIEW `view_nd_bancaria` AS 
select 
  `tbl_nd_bancaria`.`fld_id_doc` AS `fld_id_doc`, 
  `tbl_nd_bancaria`.`fld_id_banco` AS `fld_id_banco`, 
  `tbl_nd_bancaria`.`fld_fecha` AS `fld_fecha`, 
  `tbl_nd_bancaria`.`fld_descripcion` AS `fld_descripcion`, 
  `tbl_nd_bancaria`.`fld_monto` AS `fld_monto`, 
  `tbl_nd_bancaria`.`fld_estado` AS `fld_estado`, 
  `tbl_nd_bancaria`.`fld_transito` AS `fld_transito`, 
  `tbl_bancos`.`fld_id` AS `fld_id`, 
  `tbl_bancos`.`fld_nombre` AS `fld_nombre`, 
  `tbl_bancos`.`fld_cuenta` AS `fld_cuenta`, 
  `tbl_bancos`.`fld_cta_contable` AS `fld_cta_contable`, 
  `tbl_bancos`.`fld_contacto` AS `fld_contacto`, 
  `tbl_bancos`.`fld_sucursal` AS `fld_sucursal`, 
  `tbl_bancos`.`fld_balance` AS `fld_balance`, 
  `tbl_bancos`.`fld_status` AS `fld_status`, 
  `tbl_bancos`.`fld_direccion` AS `fld_direccion`, 
  `tbl_bancos`.`fld_codigo` AS `fld_codigo`, 
  `tbl_bancos`.`fld_tt_ck` AS `fld_tt_ck`, 
  `tbl_bancos`.`fld_tt_dep` AS `fld_tt_dep`, 
  `tbl_bancos`.`fld_tt_nc` AS `fld_tt_nc`, 
  `tbl_bancos`.`fld_tt_nd` AS `fld_tt_nd` 
from 
  (
    `tbl_nd_bancaria` 
    join `tbl_bancos`
  ) 
where 
  (
    `tbl_nd_bancaria`.`fld_id_banco` = `tbl_bancos`.`fld_id`
  );
-- ----------------------------
--  View definition for `view_nota_credito_cxp`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_nota_credito_cxp`;
CREATE VIEW `view_nota_credito_cxp` AS 
select 
  `tbl_supplier`.`fldSupplierID` AS `fldSupplierID`, 
  `tbl_supplier`.`fldCompany` AS `fldCompany`, 
  `tbl_supplier`.`fldAddress` AS `fldAddress`, 
  `tbl_supplier`.`fldPhone` AS `fldPhone`, 
  `tbl_supplier`.`fldContact` AS `fldContact`, 
  `tbl_supplier`.`fldLimiteCR` AS `fldLimiteCR`, 
  `tbl_supplier`.`fldBalance` AS `fldBalance`, 
  `tbl_supplier`.`fld_Status` AS `fld_Status`, 
  `tbl_supplier`.`fldBy` AS `fldBy`, 
  `tbl_supplier`.`fldfax` AS `fldfax`, 
  `tbl_supplier`.`fldcel` AS `fldcel`, 
  `tbl_supplier`.`fld_clasificacion` AS `fld_clasificacion`, 
  `tbl_supplier`.`fld_cta_contable` AS `fld_cta_contable`, 
  `tbl_supplier`.`fld_telefono` AS `fld_telefono`, 
  `tbl_supplier`.`fld_correo` AS `fld_correo`, 
  `tbl_supplier`.`fld_banco` AS `fld_banco`, 
  `tbl_nc_cxp`.`fld_id` AS `fld_id`, 
  `tbl_nc_cxp`.`fld_proveedor_id_nc` AS `fld_proveedor_id_nc`, 
  `tbl_nc_cxp`.`fld_fecha` AS `fld_fecha`, 
  `tbl_nc_cxp`.`fld_concepto` AS `fld_concepto`, 
  `tbl_nc_cxp`.`fld_monto` AS `fld_monto`, 
  `tbl_nc_cxp`.`fld_abono` AS `fld_abono`, 
  `tbl_nc_cxp`.`fld_balance` AS `fld_balance`, 
  `tbl_nc_cxp`.`fld_user` AS `fld_user`, 
  `tbl_nc_cxp`.`fldstatus` AS `fldstatus`, 
  `tbl_nc_cxp`.`fld_ncf_nc_cxp` AS `fld_ncf_nc_cxp`, 
  `tbl_nc_cxp`.`fld_ultimo_abono` AS `fld_ultimo_abono`, 
  `tbl_nc_cxp`.`fld_chk` AS `fld_chk` 
from 
  (
    `tbl_supplier` 
    join `tbl_nc_cxp`
  ) 
where 
  (
    `tbl_supplier`.`fldSupplierID` = `tbl_nc_cxp`.`fld_proveedor_id_nc`
  );
-- ----------------------------
--  View definition for `view_nota_debito_cxp`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_nota_debito_cxp`;
CREATE VIEW `view_nota_debito_cxp` AS (
  select 
    `s`.`fldSupplierID` AS `fldSupplierID`, 
    `s`.`fldCompany` AS `fldCompany`, 
    `s`.`fldAddress` AS `fldAddress`, 
    `s`.`fldPhone` AS `fldPhone`, 
    `s`.`fldContact` AS `fldContact`, 
    `s`.`fldLimiteCR` AS `fldLimiteCR`, 
    `s`.`fldBalance` AS `fldBalance`, 
    `s`.`fld_Status` AS `fld_Status`, 
    `s`.`fldBy` AS `fldBy`, 
    `s`.`fldfax` AS `fldfax`, 
    `s`.`fldcel` AS `fldcel`, 
    `s`.`fld_clasificacion` AS `fld_clasificacion`, 
    `s`.`fld_cta_contable` AS `fld_cta_contable`, 
    `s`.`fld_telefono` AS `fld_telefono`, 
    `s`.`fld_correo` AS `fld_correo`, 
    `s`.`fld_banco` AS `fld_banco`, 
    `n`.`fld_id` AS `fld_id`, 
    `n`.`fld_proveedor_id_nd` AS `fld_proveedor_id_nd`, 
    `n`.`fld_fecha` AS `fld_fecha`, 
    `n`.`fld_concepto` AS `fld_concepto`, 
    `n`.`fld_monto` AS `fld_monto`, 
    `n`.`fld_user` AS `fld_user`, 
    `n`.`fldstatus` AS `fldstatus`, 
    `n`.`fld_doc_afectado` AS `fld_doc_afectado`, 
    `n`.`fld_doc_afectado_id` AS `fld_doc_afectado_id`, 
    `n`.`fld_ncf_nd_cxp` AS `fld_ncf_nd_cxp` 
  from 
    (
      `tbl_supplier` `s` 
      join `tbl_nd_cxp` `n`
    ) 
  where 
    (
      `s`.`fldSupplierID` = `n`.`fld_proveedor_id_nd`
    )
);
-- ----------------------------
--  View definition for `view_prestamos_todos`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_prestamos_todos`;
CREATE VIEW `view_prestamos_todos` AS 
select 
  * 
from 
  (
    `tbl_prestamos` 
    join `tbl_clientes`
  ) 
where 
  (
    `tbl_prestamos`.`fld_id_del_cliente` = `tbl_clientes`.`fld_id`
  );
-- ----------------------------
--  View definition for `view_retiros`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_retiros`;
CREATE VIEW `view_retiros` AS (
  select 
    `ar`.`ID` AS `ID`, 
    `ar`.`IDAhorro` AS `IDAhorro`, 
    `ar`.`IDCliente` AS `IDCliente`, 
    `ar`.`Fecha` AS `Fecha`, 
    `ar`.`Tipo` AS `Tipo`, 
    `ar`.`Concepto` AS `Concepto`, 
    `ar`.`Monto` AS `Monto`, 
    `ar`.`Usuario` AS `Usuario`, 
    `c`.`fld_id` AS `fld_id`, 
    `c`.`TipoDocumento` AS `TipoDocumento`, 
    `c`.`fld_FullName` AS `fld_FullName`, 
    `c`.`fld_apodo` AS `fld_apodo`, 
    `c`.`fld_Identity` AS `fld_Identity`, 
    `c`.`fld_Phone` AS `fld_Phone`, 
    `c`.`fld_Phone2` AS `fld_Phone2`, 
    `c`.`fld_Address` AS `fld_Address`, 
    `c`.`fld_City_id` AS `fld_City_id`, 
    `c`.`fld_City` AS `fld_City`, 
    `c`.`fld_Status` AS `fld_Status`, 
    `c`.`fld_bce` AS `fld_bce`, 
    `c`.`fld_cod_zona` AS `fld_cod_zona`, 
    `c`.`fld_zona` AS `fld_zona`, 
    `c`.`fld_nombre_con` AS `fld_nombre_con`, 
    `c`.`fld_apodo_con` AS `fld_apodo_con`, 
    `c`.`fld_cedula_con` AS `fld_cedula_con`, 
    `c`.`fld_telefono_con` AS `fld_telefono_con`, 
    `c`.`fld_celular_con` AS `fld_celular_con`, 
    `c`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`, 
    `c`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`, 
    `c`.`fld_nombre_gar` AS `fld_nombre_gar`, 
    `c`.`fld_apodo_gar` AS `fld_apodo_gar`, 
    `c`.`fld_cedula_gar` AS `fld_cedula_gar`, 
    `c`.`fld_telefono_gar` AS `fld_telefono_gar`, 
    `c`.`fld_celular_gar` AS `fld_celular_gar`, 
    `c`.`fld_direccion_gar` AS `fld_direccion_gar`, 
    `c`.`fld_ciudad_gar` AS `fld_ciudad_gar`, 
    `c`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`, 
    `c`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`, 
    `c`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`, 
    `c`.`fld_nombre_banco1` AS `fld_nombre_banco1`, 
    `c`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`, 
    `c`.`fld_nombre_banco2` AS `fld_nombre_banco2`, 
    `c`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`, 
    `c`.`fld_otra_informacion` AS `fld_otra_informacion`, 
    `c`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`, 
    `c`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`, 
    `c`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`, 
    `c`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`, 
    `c`.`fld_celular_con_gar` AS `fld_celular_con_gar`, 
    `c`.`fld_edad` AS `fld_edad`, 
    `c`.`fld_estado_civil` AS `fld_estado_civil`, 
    `c`.`fld_edad_gar` AS `fld_edad_gar`, 
    `c`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`, 
    `c`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`, 
    `c`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`, 
    `c`.`fld_sector_id` AS `fld_sector_id`, 
    `c`.`fld_sector` AS `fld_sector`, 
    `c`.`fld_categoria` AS `fld_categoria`, 
    `c`.`fld_limite` AS `fld_limite`, 
    `c`.`Puesto` AS `Puesto`, 
    `c`.`TimpoTrabajo` AS `TimpoTrabajo`, 
    `c`.`ReferidoPor` AS `ReferidoPor`, 
    `c`.`Oriundo` AS `Oriundo`, 
    `c`.`DataCredito` AS `DataCredito` 
  from 
    (
      `tbl_ahorros_retiros` `ar` 
      join `tbl_clientes` `c`
    ) 
  where 
    (`ar`.`IDCliente` = `c`.`fld_id`)
);
-- ----------------------------
--  View definition for `view_ri_cxc`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_ri_cxc`;
CREATE VIEW `view_ri_cxc` AS 
select 
  `tbl_clientes`.`fld_id` AS `fld_id`, 
  `tbl_clientes`.`TipoDocumento` AS `TipoDocumento`, 
  `tbl_clientes`.`fld_FullName` AS `fld_FullName`, 
  `tbl_clientes`.`fld_apodo` AS `fld_apodo`, 
  `tbl_clientes`.`fld_Identity` AS `fld_Identity`, 
  `tbl_clientes`.`fld_Phone` AS `fld_Phone`, 
  `tbl_clientes`.`fld_Phone2` AS `fld_Phone2`, 
  `tbl_clientes`.`fld_Address` AS `fld_Address`, 
  `tbl_clientes`.`fld_City` AS `fld_City`, 
  `tbl_clientes`.`fld_Status` AS `fld_Status`, 
  `tbl_clientes`.`fld_bce` AS `fld_bce`, 
  `tbl_clientes`.`fld_cod_zona` AS `fld_cod_zona`, 
  `tbl_clientes`.`fld_zona` AS `fld_zona`, 
  `tbl_clientes`.`fld_nombre_con` AS `fld_nombre_con`, 
  `tbl_clientes`.`fld_apodo_con` AS `fld_apodo_con`, 
  `tbl_clientes`.`fld_cedula_con` AS `fld_cedula_con`, 
  `tbl_clientes`.`fld_telefono_con` AS `fld_telefono_con`, 
  `tbl_clientes`.`fld_celular_con` AS `fld_celular_con`, 
  `tbl_clientes`.`fld_ref_personales_cliente` AS `fld_ref_personales_cliente`, 
  `tbl_clientes`.`fld_ref_comerciales_cliente` AS `fld_ref_comerciales_cliente`, 
  `tbl_clientes`.`fld_nombre_gar` AS `fld_nombre_gar`, 
  `tbl_clientes`.`fld_apodo_gar` AS `fld_apodo_gar`, 
  `tbl_clientes`.`fld_cedula_gar` AS `fld_cedula_gar`, 
  `tbl_clientes`.`fld_telefono_gar` AS `fld_telefono_gar`, 
  `tbl_clientes`.`fld_celular_gar` AS `fld_celular_gar`, 
  `tbl_clientes`.`fld_direccion_gar` AS `fld_direccion_gar`, 
  `tbl_clientes`.`fld_ciudad_gar` AS `fld_ciudad_gar`, 
  `tbl_clientes`.`fld_ref_personales_gar` AS `fld_ref_personales_gar`, 
  `tbl_clientes`.`fld_ref_comerciales_gar` AS `fld_ref_comerciales_gar`, 
  `tbl_clientes`.`fld_ingresos_mesuales` AS `fld_ingresos_mesuales`, 
  `tbl_clientes`.`fld_nombre_banco1` AS `fld_nombre_banco1`, 
  `tbl_clientes`.`fld_cuenta_banco1` AS `fld_cuenta_banco1`, 
  `tbl_clientes`.`fld_nombre_banco2` AS `fld_nombre_banco2`, 
  `tbl_clientes`.`fld_cuenta_banco2` AS `fld_cuenta_banco2`, 
  `tbl_clientes`.`fld_otra_informacion` AS `fld_otra_informacion`, 
  `tbl_clientes`.`fld_nombre_con_gar` AS `fld_nombre_con_gar`, 
  `tbl_clientes`.`fld_apodo_con_gar` AS `fld_apodo_con_gar`, 
  `tbl_clientes`.`fld_cedula_con_gar` AS `fld_cedula_con_gar`, 
  `tbl_clientes`.`fld_telefono_con_gar` AS `fld_telefono_con_gar`, 
  `tbl_clientes`.`fld_celular_con_gar` AS `fld_celular_con_gar`, 
  `tbl_clientes`.`fld_edad` AS `fld_edad`, 
  `tbl_clientes`.`fld_estado_civil` AS `fld_estado_civil`, 
  `tbl_clientes`.`fld_edad_gar` AS `fld_edad_gar`, 
  `tbl_clientes`.`fld_estado_civil_gar` AS `fld_estado_civil_gar`, 
  `tbl_clientes`.`fld_ocupacion_cliente` AS `fld_ocupacion_cliente`, 
  `tbl_clientes`.`fld_ocupacion_gar` AS `fld_ocupacion_gar`, 
  `tbl_clientes`.`fld_sector` AS `fld_sector`, 
  `tbl_clientes`.`fld_categoria` AS `fld_categoria`, 
  `tbl_clientes`.`fld_limite` AS `fld_limite`, 
  `tbl_recibo_ingresos_cxc`.`fld_Id_RI` AS `fld_Id_RI`, 
  `tbl_recibo_ingresos_cxc`.`fld_forma_pago` AS `fld_forma_pago`, 
  `tbl_recibo_ingresos_cxc`.`fld_detalle_forma_pago` AS `fld_detalle_forma_pago`, 
  `tbl_recibo_ingresos_cxc`.`fld_id_cliente_ri` AS `fld_id_cliente_ri`, 
  `tbl_recibo_ingresos_cxc`.`fld_date` AS `fld_date`, 
  `tbl_recibo_ingresos_cxc`.`fld_Description` AS `fld_Description`, 
  `tbl_recibo_ingresos_cxc`.`fld_monto` AS `fld_monto`, 
  `tbl_recibo_ingresos_cxc`.`fld_monto_recibido` AS `fld_monto_recibido`, 
  `tbl_recibo_ingresos_cxc`.`fld_fact_afectado` AS `fld_fact_afectado`, 
  `tbl_recibo_ingresos_cxc`.`fdl_nd_afectado` AS `fdl_nd_afectado`, 
  `tbl_recibo_ingresos_cxc`.`fld_User` AS `fld_User`, 
  `tbl_recibo_ingresos_cxc`.`fld_Estado` AS `fld_Estado`, 
  `tbl_recibo_ingresos_cxc`.`fld_id_prestamo` AS `fld_id_prestamo`, 
  `tbl_recibo_ingresos_cxc`.`fld_interes_cobrado` AS `fld_interes_cobrado`, 
  `tbl_recibo_ingresos_cxc`.`fld_capital_cobrado` AS `fld_capital_cobrado`, 
  `tbl_recibo_ingresos_cxc`.`fld_mora_cobrada` AS `fld_mora_cobrada`, 
  `tbl_recibo_ingresos_cxc`.`fld_concepto` AS `fld_concepto`, 
  `tbl_recibo_ingresos_cxc`.`fld_socio` AS `fld_socio`, 
  `tbl_recibo_ingresos_cxc`.`fld_bce_actual` AS `fld_bce_actual`, 
  `tbl_recibo_ingresos_cxc`.`fld_bce_anterior` AS `fld_bce_anterior`, 
  `tbl_recibo_ingresos_cxc`.`fld_adelanto` AS `fld_adelanto`, 
  `tbl_recibo_ingresos_cxc`.`fld_adelanto_aplicado` AS `fld_adelanto_aplicado` 
from 
  (
    `tbl_clientes` 
    join `tbl_recibo_ingresos_cxc`
  ) 
where 
  (
    `tbl_clientes`.`fld_id` = `tbl_recibo_ingresos_cxc`.`fld_id_cliente_ri`
  );
-- ----------------------------
--  View definition for `view_tabla_prestamos`
-- ----------------------------
DROP 
  VIEW IF EXISTS `view_tabla_prestamos`;
CREATE VIEW `view_tabla_prestamos` AS (
  SELECT 
    * 
  FROM 
    (
      `tbl_tabla_prestamos` `tp` 
      JOIN `tbl_tabla_cuotas` `tc`
    ) 
  WHERE 
    (
      `tc`.`fld_id_del_prestamo` = `tp`.`fld_id_prestamos`
    )
);
-- ----------------------------
--  View definition for `wiew_cuentasprestamo`
-- ----------------------------
DROP 
  VIEW IF EXISTS `wiew_cuentasprestamo`;
CREATE VIEW `wiew_cuentasprestamo` AS 
select 
  Descripcion 
from 
  tbl_catalogo 
where 
  CuentaNo in(
    '101-01-01-01', '101-01-01-02', '101-01-01-03', 
    '101-01-01-04', '101-01-01-05', 
    '101-01-01-06', '101-01-02', '101-01-02-01', 
    '101-01-02-02', '101-01-02-03'
  );
-- ----------------------------
--  View definition for `wiew_cuentasprestamos`
-- ----------------------------
DROP 
  VIEW IF EXISTS `wiew_cuentasprestamos`;
CREATE VIEW `wiew_cuentasprestamos` AS 
select 
  CuentaNo, 
  Descripcion 
from 
  tbl_catalogo 
where 
  CuentaNo in(
    '101-01-01-01', '101-01-01-02', '101-01-01-03', 
    '101-01-01-04', '101-01-01-05', 
    '101-01-01-06', '101-01-02', '101-01-02-01', 
    '101-01-02-02', '101-01-02-03'
  );
-- ----------------------------
--  View definition for `_viewlibretadepositos`
-- ----------------------------
DROP 
  VIEW IF EXISTS `_viewlibretadepositos`;
CREATE VIEW `_viewlibretadepositos` AS 
SELECT 
  DISTINCT d.fecha, 
  d.monto AS Depositos, 
  va.saldointeres AS Intereses, 
  va.saldocapital AS Balance, 
  d.Usuario AS Cajero, 
  va.Descripcion, 
  d.idcliente, 
  va.fld_FullName, 
  va.CuentaNo 
FROM 
  tbl_ahorros_depositos AS d 
  INNER JOIN view_ahorros AS va ON d.idcliente = va.idcliente;
