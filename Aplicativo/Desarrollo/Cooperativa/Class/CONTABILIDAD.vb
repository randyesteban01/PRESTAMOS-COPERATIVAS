Imports MySql.Data.MySqlClient
Module CONTABILIDAD


    Friend fechaInicioPeriodo As Date = CDate(SCALAR_STRING("SELECT MIN(fld_fecha_inicia_pc) FROM tbl_periodos_contables"))
    Friend ctaUtilidad = SCALAR_STRING("SELECT Utilidad FROM tbl_interfascontableotras WHERE id=1")

    Friend Function CargarFrmInterfas(ByVal CuentaNo As String, ByVal DescripcionCuenta As String, ByVal Debito As Decimal, ByVal Credito As Decimal, ByVal IDDocAfectado As Integer, ByVal Frm As String, ByVal Concepto As String, ByVal Fecha As DateTime, ByVal idTipo As Integer) As Integer
        Dim f As New frmTransacciones

        f.idTipo = idTipo

        f.txtTransDCuentaNo.Text = CuentaNo
        f.txtTransDDescripcionCuenta.Text = DescripcionCuenta
        f.txtTransDDebito.Text = Debito
        f.txtTransDCredito.Text = Credito
        f.txtIDDocAfectado.Text = IDDocAfectado
        f.txtFrm.Text = Frm
        f.txtTransDescripcion.Text = Concepto
        f.dtpTransFecha.Value = Fecha
        f.dtpTransFecha.Enabled = False
        f.Text = "Transacción de Interfas"
        f.txtTransDCuentaNo.Focus()
        f.ShowDialog()

        If f.Text = "ACEPTAR" Then
            Dim idDoc = SCALAR_NUM("SELECT MAX(TransID) FROM tbl_interfascontabletransacciones")
            Return idDoc
        Else
            Return 0
        End If

    End Function

    Friend Function ValidaTipoCtaContable(ByVal CantDigito As Integer, ByVal Tipo As String) As Boolean

        If CantDigito = 1 And Tipo = "Cuenta" Then
            Return True
        ElseIf CantDigito = 2 And Tipo = "Grupo" Then
            Return True
        ElseIf CantDigito = 3 And Tipo = "SubGrupo" Then
            Return True
        ElseIf CantDigito > 4 And Tipo = "Auxiliar" Then
            Return True
        End If

        Return False

    End Function

    Friend Function ReturnBceAnterior(ByVal CuentaNo As String, ByVal Hasta As Date) As Decimal
        Dim Balance As Decimal
        Dim FechaUltPeriodoAct As Date = CDate(SCALAR_STRING("SELECT fld_fecha_inicia_pc FROM tbl_periodos_contables WHERE fld_estado_pc='ACTIVO'"))

        Dim Debitos As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(TransDDebito),0) FROM view_cont_libro_general WHERE TransDCuentaNo='" & CuentaNo & "' AND TransFechaMovimiento >= '" & formatDate(FechaUltPeriodoAct) & "' AND TransFechaMovimiento <'" & formatDate(Hasta) & "'")

        Dim Creditos As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(TransDCredito),0) FROM view_cont_libro_general WHERE TransDCuentaNo='" & CuentaNo & "' AND TransFechaMovimiento >= '" & formatDate(FechaUltPeriodoAct) & "' AND TransFechaMovimiento <'" & formatDate(Hasta) & "'")

        Dim Origen = SCALAR_NUM("SELECT Origen FROM tbl_catalogo_grupo AS cg, tbl_catalogo AS c WHERE c.Grupo=cg.ID AND c.CuentaNo='" & CuentaNo & "'")


        If Origen = 2 Then
            Balance = Creditos - Debitos
        Else
            Balance = Debitos - Creditos
        End If
        Return Balance


    End Function
    Friend Function ReturnDescripcion(ByVal CuentaNo As String) As String
        '/SET PRIMARY KEY ON TABLE
        Try

            Return SCALAR_STRING("SELECT IFNULL(Descripcion,'no existe') FROM tbl_catalogo WHERE CuentaNo='" & CuentaNo & "'")


        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Function

    Friend Function InterfarContableAutomatico(ByVal Modulo As String, ByVal Frm As String, ByVal fecha As Date, ByVal monto As Decimal, ByVal idDocAfectado As Integer, ByVal TransDocDetalle As String) As Boolean
        Dim IdTras As Integer, DescripcionCuenta As String

        If SCALAR_NUM("SELECT  IFNULL(1,0) FROM tbl_interfascontable WHERE Modulo='" & Modulo & "' AND Frm='" & Frm & "'") = 0 Then Exit Function

        READER("SELECT  DRCuenta, CRCuenta, IDTipo, Concepto, Frm  FROM tbl_interfascontable WHERE Modulo='" & Modulo & "' AND Frm='" & Frm & "'")
        If reader_values.Length > 0 Then

            IdTras = GuardarTransaccion(fecha, reader_values(3), reader_values(2), idDocAfectado, reader_values(4), TransDocDetalle)
            'Guardar detalle débito
            DescripcionCuenta = ReturnDescripcion(reader_values(0))
            GuardarTransaccionDetalle(IdTras, reader_values(0), DescripcionCuenta, monto, 0)
            'Guardar detalle crédito
            DescripcionCuenta = ReturnDescripcion(reader_values(1))
            GuardarTransaccionDetalle(IdTras, reader_values(1), DescripcionCuenta, 0, monto)

        End If
    End Function

    Friend Function crarEntradaUtilidad() As Boolean
        Dim ctaUtilidad As String = SCALAR_STRING("SELECT IFNULL(Utilidad,'N/A') FROM tbl_interfascontableotras WHERE id=1")

        If ctaUtilidad = "N/A" Then
            Alerta("Debe configurar la cuenta para la utilidad del período")
            Return False
        End If

        Dim idTrasBorrar As Integer = SCALAR_NUM("SELECT IFNULL(TransID,0) FROM tbl_interfascontabletransacciones WHERE TransIDTipo=-1 AND TransIDDoc=-100")
        'MessageBox.Show(idTrasBorrar)

        NON_QUERY("DELETE FROM tbl_interfascontabletransacciones WHERE TransID=" & idTrasBorrar & "; DELETE FROM tbl_interfasecontabletransaccionesdetalles WHERE TransDIDTrans=" & idTrasBorrar & ";")

        'MessageBox.Show("DELETE FROM tbl_interfascontabletransacciones WHERE TransID=" & idTrasBorrar & "; DELETE FROM tbl_interfasecontabletransaccionesdetalles WHERE TransDIDTrans=" & idTrasBorrar & ";")


        actualizarCuentas(formatDate(fechaInicioPeriodo), formatDate(UltimoDiaDelMes(fecha2))) '/ primera actualización para buscar los ingresos, costo y gastos

        Dim ingresos As Decimal = SCALAR_NUM("SELECT SUM(Balance) FROM tbl_catalogo WHERE Grupo =4 AND Tipo='Auxiliar'")
        Dim costogastos As Decimal = SCALAR_NUM("SELECT SUM(Balance) FROM tbl_catalogo WHERE Grupo IN (5,6) AND Tipo='Auxiliar'")

        If ingresos - (costogastos) > 0 Then 'BENEFICIOS EN EL PERIODO
            Dim idTras As Integer = GuardarTransaccion(formatDate(UltimoDiaDelMes(fecha2)), "Beneficios del Período", -1, -100, "Estado de Situación", "Registro de Beneficios del Periodo")
            GuardarTransaccionDetalle(idTras, ctaUtilidad, "Beneficios del Período", 0, ingresos - (costogastos))

        End If

        If ingresos - (costogastos) < 0 Then 'PERDIDA EN EL PERIODO
            'Dim VALUES_NEG As Double = INGRESOS - (COST + GAST)
            Dim idTras As Integer = GuardarTransaccion(formatDate(UltimoDiaDelMes(fecha2)), "Pérdida del Período", -1, -100, "Estado de Situación", "Registro de Pérdida del Periodo")
            GuardarTransaccionDetalle(idTras, ctaUtilidad, "Pérdida del Período", ingresos - (costogastos), (ingresos - (costogastos)) + (ingresos - (costogastos)))
        End If

        If ingresos - (costogastos) = 0 Then 'NI GANANCIA NI PERDIDA
            Dim idTras As Integer = GuardarTransaccion(formatDate(UltimoDiaDelMes(fecha2)), "Utilidad del Período", -1, -100, "Estado de Situación", "Registro de Utilidad del Periodo")
            GuardarTransaccionDetalle(idTras, ctaUtilidad, "Utilidad del Período", 0, 0)
        End If

        NON_QUERY("UPDATE tbl_catalogo SET Balance=" & ingresos - (costogastos) & " WHERE CuentaNo='" & ctaUtilidad & "';")
        Return True
    End Function


    Friend Function InterfarContableRecibosIngresosCxC(ByVal FechaTransaccion As String, ByVal montoCapital As Decimal, ByVal montoInteres As Decimal, ByVal montoMora As Decimal, ByVal montoOtros As Decimal, ByVal idDocAfectado As Integer, ByVal TransDocDetalle As String, ByVal ctaContableCliente As String, ByVal ctaContableCaja As String) As Boolean


        Dim IdTras As Integer, DescripcionCuenta As String
        If SCALAR_NUM("SELECT  IFNULL(1,0) FROM tbl_interfascontableingresos ") = 0 Then Exit Function

        Dim monto As Decimal = montoCapital + montoInteres + montoMora + montoOtros
        READER("SELECT Interes, Mora, Otros, IdTipo, DescripcionTipo  FROM tbl_interfascontableingresos")

        If reader_values.Length > 0 Then

            NON_QUERY("CALL cont_insert_trans('" & FechaTransaccion & "','" & reader_values(4) & "'," & reader_values(3) & ",'" & User(0) & "'," & idDocAfectado & ",'RECIBO DE INGRESO CXC','" & TransDocDetalle & "')")

            IdTras = UltimoID("tbl_interfascontabletransacciones", "TransID")

            'Guardar detalle débito
            DescripcionCuenta = ReturnDescripcion(ctaContableCaja)
            ' GuardarTransaccionDetalle(IdTras, reader_values(0), DescripcionCuenta, monto, 0)
            ' EESCOBAR
            GuardarTransaccionDetalle(IdTras, ctaContableCaja, DescripcionCuenta, monto, 0)

            'Guardar detalle crédito montoCapital
            If montoCapital > 0 Then
                DescripcionCuenta = ReturnDescripcion(ctaContableCliente)
                GuardarTransaccionDetalle(IdTras, ctaContableCliente, DescripcionCuenta, 0, montoCapital)
            End If
            'Guardar detalle crédito montoInteres
            If montoInteres > 0 Then
                DescripcionCuenta = ReturnDescripcion(reader_values(0))
                GuardarTransaccionDetalle(IdTras, reader_values(0), DescripcionCuenta, 0, montoInteres)
            End If
            'Guardar detalle crédito montoMora
            If montoMora > 0 Then
                DescripcionCuenta = ReturnDescripcion(reader_values(1))
                GuardarTransaccionDetalle(IdTras, reader_values(1), DescripcionCuenta, 0, montoMora)
            End If
            'Guardar detalle crédito montoOtros
            If montoOtros > 0 Then
                DescripcionCuenta = ReturnDescripcion(reader_values(2))
                GuardarTransaccionDetalle(IdTras, reader_values(2), DescripcionCuenta, 0, montoOtros)
            End If

        End If
    End Function



    Friend Function InterfarContableRecibosIngresosCxC(ByVal montoCapital As Decimal, ByVal montoInteres As Decimal, ByVal montoMora As Decimal, ByVal montoOtros As Decimal, ByVal idDocAfectado As Integer, ByVal TransDocDetalle As String, ByVal ctaContableCliente As String, ByVal ctaContableCaja As String) As Boolean


        Dim IdTras As Integer, DescripcionCuenta As String
        If SCALAR_NUM("SELECT  IFNULL(1,0) FROM tbl_interfascontableingresos ") = 0 Then Exit Function

        Dim monto As Decimal = montoCapital + montoInteres + montoMora + montoOtros
        READER("SELECT Interes, Mora, Otros, IdTipo, DescripcionTipo  FROM tbl_interfascontableingresos")

        If reader_values.Length > 0 Then

            NON_QUERY("CALL cont_insert_trans(Now(),'" & reader_values(4) & "'," & reader_values(3) & ",'" & User(0) & "'," & idDocAfectado & ",'RECIBO DE INGRESO CXC','" & TransDocDetalle & "')")

            IdTras = UltimoID("tbl_interfascontabletransacciones", "TransID")

            'Guardar detalle débito
            DescripcionCuenta = ReturnDescripcion(ctaContableCaja)
            ' GuardarTransaccionDetalle(IdTras, reader_values(0), DescripcionCuenta, monto, 0)
            ' EESCOBAR
            GuardarTransaccionDetalle(IdTras, ctaContableCaja, DescripcionCuenta, monto, 0)

            'Guardar detalle crédito montoCapital
            If montoCapital > 0 Then
                DescripcionCuenta = ReturnDescripcion(ctaContableCliente)
                GuardarTransaccionDetalle(IdTras, ctaContableCliente, DescripcionCuenta, 0, montoCapital)
            End If
            'Guardar detalle crédito montoInteres
            If montoInteres > 0 Then
                DescripcionCuenta = ReturnDescripcion(reader_values(0))
                GuardarTransaccionDetalle(IdTras, reader_values(0), DescripcionCuenta, 0, montoInteres)
            End If
            'Guardar detalle crédito montoMora
            If montoMora > 0 Then
                DescripcionCuenta = ReturnDescripcion(reader_values(1))
                GuardarTransaccionDetalle(IdTras, reader_values(1), DescripcionCuenta, 0, montoMora)
            End If
            'Guardar detalle crédito montoOtros
            If montoOtros > 0 Then
                DescripcionCuenta = ReturnDescripcion(reader_values(2))
                GuardarTransaccionDetalle(IdTras, reader_values(2), DescripcionCuenta, 0, montoOtros)
            End If

        End If
    End Function

    Friend Function GuardarTransaccion(ByVal Fecha As Date, ByVal descripcion As String, ByVal tipo As Integer, ByVal TransIDDoc As Integer, ByVal TransDoc As String, ByVal TransDocDetalle As String) As Integer
        NON_QUERY("CALL cont_insert_trans('" & Format(Fecha.Date, "yyyy-MM-dd") & "','" & descripcion & "'," & tipo & ",'" & User(0) & "'," & TransIDDoc & ",'" & TransDoc & "','" & TransDocDetalle & "')")

        Return UltimoID("tbl_interfascontabletransacciones", "TransID")

    End Function

    Friend Sub GuardarTransaccionDetalle(ByVal IdTransaccion As Integer, ByVal CuentaNo As String, ByVal DescripcionCuenta As String, ByVal Debito As Decimal, ByVal Credito As Decimal)
        NON_QUERY("CALL cont_insert_trans_detalle(" & IdTransaccion & ",'" & CuentaNo & "','" & DescripcionCuenta & "'," & Debito & "," & Credito & ")")
    End Sub


    Friend Sub CierrePeriodo(ByVal desde As String, ByVal hasta As String, ByVal cta_cierre As String, ByVal descripcion_cta_cierre As String)

        Dim Monto_utilidad As Double = 0
        Dim Id_Entrada As Integer = UltimoID("tbl_entrada_diarias", "fld_Entrada_ID")

        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT t.fld_codigo as Cuenta, c.FLD_DESCRIPCION_CTA as Nombre_cuenta, c.FLD_ORIGEN as Origen, IFNULL(SUM(t.fld_dr),0) as Debito, IFNULL(SUM(t.fld_cr),0) AS Credito, c.FLD_GRUPO as Grupo FROM tbl_transacciones AS t, tbl_catalogo AS c WHERE(t.fld_codigo = c.CuentaNo) AND t.fld_date BETWEEN '" & desde & "' AND '" & hasta & "' AND c.FLD_GRUPO IN ('INGRESOS', 'GASTOS', 'COSTOS') GROUP BY t.fld_codigo ORDER BY t.fld_codigo;", conn)
        da.Fill(ds, "tbl_transacciones")
        Dim dr As DataRow

        For Each dr In ds.Tables(0).Rows

            If dr("Origen") = "CREDITO" Then
                NON_QUERY("INSERT INTO tbl_transacciones (fld_Codigo, fld_Descripcion, fld_nombre_cuenta, fld_DR, fld_CR, fld_Date, fld_Creadopor, fld_Status, fld_IdEntrada, fld_Bce_cta,Tipo_entrada_cod,fld_acentada_t) VALUES('" & dr("Cuenta") & "','CIERRE DEL PERIODO','" & dr("Nombre_cuenta") & "'," & (dr("Credito") - dr("Debito")) & ",0,'" & hasta & "','" & User(0) & "','N'," & Id_Entrada & ",0,'CIERRE','S');")
            Else
                NON_QUERY("INSERT INTO tbl_transacciones (fld_Codigo, fld_Descripcion, fld_nombre_cuenta, fld_DR, fld_CR, fld_Date, fld_Creadopor, fld_Status, fld_IdEntrada, fld_Bce_cta,Tipo_entrada_cod,fld_acentada_t) VALUES('" & dr("Cuenta") & "','CIERRE DEL PERIODO','" & dr("Nombre_cuenta") & "',0," & (dr("Debito") - dr("Credito")) & ",'" & hasta & "','" & User(0) & "','N'," & Id_Entrada & ",0,'CIERRE','S');")
            End If

            If dr("Grupo") = "INGRESOS" Then
                Monto_utilidad = Monto_utilidad + (dr("Credito") - dr("Debito"))
            Else
                Monto_utilidad = Monto_utilidad - (dr("Debito") - dr("Credito"))
            End If

        Next


        If Monto_utilidad > 0 Then 'Si el utilidad del período es negativa
            NON_QUERY("INSERT INTO tbl_transacciones (fld_Codigo, fld_Descripcion, fld_nombre_cuenta, fld_DR, fld_CR, fld_Date, fld_Creadopor, fld_Status,fld_IdEntrada,fld_Bce_cta,Tipo_entrada_cod,fld_acentada_t) VALUES('" & cta_cierre & "','CIERRE DEL PERIODO','" & descripcion_cta_cierre & "',0," & Monto_utilidad & ",'" & hasta & "','" & User(0) & "','N'," & Id_Entrada & ",0,'CIERRE','S');")
        ElseIf Monto_utilidad < 0 Then
            NON_QUERY("INSERT INTO tbl_transacciones (fld_Codigo, fld_Descripcion, fld_nombre_cuenta, fld_DR, fld_CR, fld_Date, fld_Creadopor, fld_Status,fld_IdEntrada,fld_Bce_cta,Tipo_entrada_cod,fld_acentada_t) VALUES('" & cta_cierre & "','CIERRE DEL PERIODO','" & descripcion_cta_cierre & "'," & Monto_utilidad & ",0,'" & hasta & "','" & User(0) & "','N'," & Id_Entrada & ",0,'CIERRE','S');")
        End If

    End Sub


    'para saber el primer dia del mes 
    ' eescobar
    Friend Function PrimerDiaDelMes(ByVal dtmFecha As Date) As Date
        Try
            PrimerDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha), 1)


        Catch ex As Exception

        End Try
    End Function

    'para saber el ultimo dia del mes
    ' eescobar
    Friend Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        Try
            UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)

        Catch ex As Exception

        End Try

    End Function

    Friend Sub actualizarCuentas(ByVal fechaDesde As String, ByVal fechaHasta As String)

        NON_QUERY("CALL cont_actualizar_cta_controles_a_cero();  CALL cont_actualizar_cta_detalles_a_cero();")
        NON_QUERY("CALL cont_actualizar_cta_controles('" & fechaDesde & "','" & fechaHasta & "'); CALL cont_actualizar_cta_detalles('" & fechaDesde & "','" & fechaHasta & "');")

    End Sub

    Friend Sub actualizarCuentasBceAnterior(ByVal fechaDesde As String, ByVal fechaHasta As String)

        NON_QUERY("UPDATE tbl_catalogo SET BalanceAnterior=0;")
        NON_QUERY("CALL cont_actualizar_cta_controlesBceAnt('" & fechaDesde & "','" & fechaHasta & "'); CALL cont_actualizar_cta_detallesBceAnt('" & fechaDesde & "','" & fechaHasta & "');")

    End Sub






End Module
