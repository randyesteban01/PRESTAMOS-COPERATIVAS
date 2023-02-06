Imports System.Management
Imports Microsoft.Win32
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing
Imports System.IO
Module _Module

    Friend Id As String
    Friend ID_RI As Integer
    Friend Idretiro As Integer
    Friend IdCatCta As Integer

    Friend admin_clave As String, borrar_clave As String
    Friend User(6) As String 'Guardar los datos del usuario logeado
    Friend DiasGracias As Integer 'Esteblece los días de gracias para la mora


    Friend DataBaseName As String
    Friend ServerName As String
    Friend ServerPort As String

    Friend fecha1 As String
    Friend fecha2 As String
    Friend fecha_rango As String

    Friend ReportName As String 'Identifica los reporte para ser mostrado
    Friend ParametroReporte As String 'Concatena parametros sql para reportes
    Friend Estado As String 'Marca el estado de los documentos de banco
    Friend Filtro As String = "" ' Filtra la descripcion para el reporte de saldo
    Friend ds_print_list As DataSet
    Friend Clave(3) As String

    Friend AppPath As String = System.AppDomain.CurrentDomain.BaseDirectory()

    Friend sysDir As String = Environment.SystemDirectory

    Friend conn As MySqlConnection

    Public appIcon As Icon = New System.Drawing.Icon(AppPath & "\Icon1.ico")
 
    Friend objIniFile As New IniFile(AppPath & "\Settings.ini") '/INI FILE

    Friend Estacion As String = objIniFile.GetString("COMPANY", "Estacion", "(none)")

    Friend WithEvents docToPrint As New Printing.PrintDocument

    Friend Pnormal, Patraso, Plegal, Pcastigado, Psaldado As Integer
    Friend Pstnormal, Pstatraso, Pstlegal, Pstcastigado, Pstsaldado As String

    Public Function Redondear(ByVal num As Double, ByVal decim As Integer) As Double
        Dim multi As Double
        multi = Math.Pow(10D, CDbl(decim))
        Return CInt(num * multi) / multi

    End Function
    Friend Sub UPDATE_PRESTAMOS(ByVal IdPrestamo As Integer)
        Dim cmd_mon_capt As New MySqlCommand, cmd_mon_interes As New MySqlCommand, monto As Double = 0, dr As MySqlDataReader, mont_interes As Double, mont_capital As Double
        With cmd_mon_capt
            .Connection = conn
            .CommandText = "SELECT SUM(fld_capital_cuota_balance) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & IdPrestamo & ""
            .Connection.Open()
            mont_capital = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_mon_capt = Nothing
        With cmd_mon_interes
            .Connection = conn
            .CommandText = "SELECT SUM(fld_interes_cuota_balance) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & IdPrestamo & ""
            .Connection.Open()
            mont_interes = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_mon_interes = Nothing

        monto = mont_interes + mont_capital
        Dim CMD As New MySqlCommand
        With CMD
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_prestamos SET fld_balance=" & monto & ", fld_abono=fld_monto-fld_balance WHERE fld_id_prestamos=" & IdPrestamo & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        CMD.Dispose()
    End Sub

    Friend Sub UPDATE_CUOTAS()

        Dim CMD As New MySqlCommand
        With CMD
            .Connection = conn
            .Connection.Open()
            .CommandText = "update tbl_cuotas set fld_balance_cuotas=0 where fld_interes_cuota_balance =0 and fld_capital_cuota_balance = 0" '
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        CMD.Dispose()
    End Sub

    Friend Sub UPDATE_FECHA_ULT_ABONO()

        Dim CMD As New MySqlCommand
        With CMD
            .Connection = conn
            .Connection.Open()
            .CommandText = "update tbl_prestamos set fld_fecha_ultimo_abono=fld_fecha_entrega where fld_fecha_ultimo_abono IS NULL" '
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        CMD.Dispose()
    End Sub

    Public Function Num2Text(ByVal value As Long) As String
        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select

    End Function

    Friend Sub AllReportSinFecha(ByVal R_Name As String)
        ReportName = R_Name
        Dim rep As New FRM_REPORTS
        rep.Show()
    End Sub
    Friend Sub AllReport_Tipo_Ahorro(ByVal R_Name As String)
        ReportName = R_Name
        Dim rep As New FRM_REPORTS
        rep.Show()
    End Sub

    Friend Sub AllReport(ByVal R_Name As String)

        Dim popuDate As New FRM_POPUP_FECHAS
        popuDate.ShowDialog()

        If popuDate.Text = "ACEPTAR" Then
            ReportName = R_Name

            Dim rep As New FRM_REPORTS
            rep.Show()
        Else
            popuDate.Dispose()
        End If
    End Sub

    Friend Sub AllReportCaja(ByVal R_Name As String)

        Dim popuDate As New frmFechasCajas
        popuDate.ShowDialog()

        If popuDate.Text = "ACEPTAR" Then
            ReportName = R_Name

            Dim rep As New FRM_REPORTS
            rep.Show()
        Else
            popuDate.Dispose()
        End If
    End Sub

    Friend Sub AllReport_una_fecha(ByVal R_Name As String)

        Dim popuDate As New FRM_POPUP_UNA_FECHA
        popuDate.ShowDialog()

        If popuDate.Text = "ACEPTAR" Then
            ReportName = R_Name

            Dim rep As New FRM_REPORTS
            rep.Show()
        Else
            popuDate.Dispose()
        End If
    End Sub
    Friend Sub AllReport_una_fechaMes(ByVal R_Name As String)

        Dim popuDate As New frmPopupUnMes
        popuDate.ShowDialog()

        If popuDate.Text = "ACEPTAR" Then
            ReportName = R_Name

            Dim rep As New FRM_REPORTS
            rep.Show()
        Else
            popuDate.Dispose()
        End If
    End Sub
    Friend Function MySQLConn(ByVal Server As String, ByVal DataBase As String, ByVal PortServer As String, ByVal User As String, ByVal Password As String) As MySqlConnection
        Dim Conn As New MySqlConnection("UID=" & User & ";PASSWORD=" & Password & ";DATABASE=" & DataBase & ";SERVER=" & Server & ";PORT=" & PortServer & "")
        Return Conn
    End Function

    Friend Sub CloseConn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Friend Function UltimoID(ByVal table, ByVal field) As Integer
        Dim newID As Integer = 0
        conn.Close()
        conn.Open()
        Dim idCMD As MySqlCommand = New MySqlCommand("SELECT MAX(" & field & ") FROM " & table & "", conn)
        If idCMD.ExecuteScalar().GetType.ToString = "System.DBNull" Then
            newID = 0
        Else
            newID = idCMD.ExecuteScalar()
        End If
        conn.Close()
        Return newID
    End Function

    Friend Function formatDate(ByVal Date_Time As DateTime) As String
        'FORMATEA LA FECHA EN INGLES, ESTO ES PARA HACER LA BUSQUEDA EN SQL CUANDO LA BASE DE DATOS TIENE FORMATO
        'DE FECHA EN ESPAÑOL. LA RAZON ES QUE SQL SOLO HACETA BUSQUEDE DE FECHA EN FORMATO INGLES

        Dim Dia, Mes, Año, Fecha As String
        Dia = Format(Date_Time.Day, "00")
        Mes = Format(Date_Time.Month, "00")
        Año = Date_Time.Year
        Fecha = ("" & Año & "-" & Mes & "-" & Dia & "")

        Return Fecha

    End Function

    Friend Function formatDateAccess(ByVal Date_Time As DateTime) As String
        'FORMATEA LA FECHA EN INGLES, ESTO ES PARA HACER LA BUSQUEDA EN SQL CUANDO LA BASE DE DATOS TIENE FORMATO
        'DE FECHA EN ESPAÑOL. LA RAZON ES QUE SQL SOLO HACETA BUSQUEDE DE FECHA EN FORMATO INGLES

        Dim Dia, Mes, Año, Fecha As String
        Dia = Date_Time.Day
        Mes = Date_Time.Month
        Año = Date_Time.Year
        Fecha = ("" & Mes & "/" & Dia & "/" & Año & "")

        Return Fecha

    End Function

    Friend Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890.", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function

    Friend Function SoloNumerosSINPUNTO(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumerosSINPUNTO = 0
        Else
            SoloNumerosSINPUNTO = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumerosSINPUNTO = Keyascii
            Case 13
                SoloNumerosSINPUNTO = Keyascii
        End Select
    End Function

    Friend Function CTA_CONTABLE(ByVal Keyascii As Short) As Short
        If InStr("1234567890-", Chr(Keyascii)) = 0 Then
            CTA_CONTABLE = 0
        Else
            CTA_CONTABLE = Keyascii
        End If
        Select Case Keyascii
            Case 8
                CTA_CONTABLE = Keyascii
            Case 13
                CTA_CONTABLE = Keyascii
        End Select
    End Function

    Friend Function GuardaCodigo(ByVal Letra As String) As String

        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_codigos_articulos", conn)
        da.Fill(ds, "tbl_codigos_articulos")

        dr = ds.Tables(0).NewRow
        dr("fld_Letra") = Letra
        dr("fld_Codigo") = 1001
        ds.Tables(0).Rows.Add(dr)

        conn.Open()
        Dim cmd As New MySqlCommandBuilder(da)
        da.InsertCommand = cmd.GetInsertCommand
        da.Update(ds, "tbl_codigos_articulos")
        ds.AcceptChanges()
        conn.Close()

    End Function

    Friend Function GeneraCodigo(ByVal Letra As String) As String
        Try


            Dim co As String
            Dim dr As DataRow
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter("SELECT * FROM tbl_codigos_articulos WHERE fld_Letra='" & Letra & "'", conn)
            da.Fill(ds, "tbl_codigos_articulos")


            For Each dr In ds.Tables("tbl_codigos_articulos").Rows
                dr("fld_Codigo") += 1
                co = dr("fld_Codigo")
                GoTo ACTUALIZA
            Next

            GuardaCodigo(Letra)
            Return "1001"
            Exit Function

ACTUALIZA:


            conn.Open()
            Dim cmd As New MySqlCommandBuilder(da)
            da.UpdateCommand = cmd.GetUpdateCommand
            da.Update(ds, "tbl_codigos_articulos")
            ds.AcceptChanges()
            conn.Close()

            Return co
        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Function

    Friend Function create_cod_ri(ByVal campo As String, ByVal dptos As String) As Double
        Dim cmd As New MySqlCommand
        CloseConn()
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_cod_ri SET " & campo & " = " & campo & " + 1 WHERE fld_dpto='" & dptos & "'"
            ' Alerta(.CommandText)
            .ExecuteNonQuery()
            .Connection.Close()
        End With


        Dim cmd_cod As New MySqlCommand
        CloseConn()

        Dim cod As Double
        With cmd_cod
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT " & campo & " FROM tbl_cod_ri WHERE fld_dpto='" & dptos & "'"
            cod = .ExecuteScalar()
            .Connection.Close()
        End With
        Return cod

    End Function

    Friend Function VALIDA_DATA(ByVal tabla As String, ByVal campo As String, ByVal texto As String) As Boolean
        Try
            Dim dr As DataRow, S As String = "SELECT * FROM " & tabla & "" '" & campo & "
            ' Alerta(S)
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter(S, conn)
            da.Fill(ds, tabla)

            For Each dr In ds.Tables(0).Rows
                If dr("" + campo + "") = texto Then

                    Return True
                End If
            Next

            Return False


        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Function

    Friend Sub create_row_estado_cliente(ByVal idCliente As String, ByVal monto As Double, ByVal tipo_doc As String, ByVal tipo_doc_id As String, ByVal descripcion As String, ByVal Fecha As Date)


        NON_QUERY("CALL set_bce_cliente(" & idCliente & ");")

        Dim Debito As Double = 0, Credito As Double = 0

        If tipo_doc = "PRESTAMOS" Then
            Debito = monto
        ElseIf tipo_doc = "DEVOLUCION_PRESTAMOS" Then
            Credito = monto
        ElseIf tipo_doc = "RECIBOCOBROCXC" Then
            Credito = monto
        ElseIf tipo_doc = "INGRESO NULOS" Then
            Debito = monto
        ElseIf tipo_doc = "NDCXC" Then
            Debito = monto
        ElseIf tipo_doc = "NCCXC" Then
            Credito = monto
        ElseIf tipo_doc = "EGRESOS" Then
            Debito = monto
        ElseIf tipo_doc = "EGRESOS NULOS" Then
            Credito = monto
        ElseIf tipo_doc = "OTROS INGRESOS" Then
            Credito = monto
        End If

        Dim cmd As New MySqlCommand

        With cmd 'formatDate(fecha)
            .Connection = conn
            .CommandText = "INSERT INTO tbl_estado_clientes (fld_date, fld_description, fld_dr, fld_cr, fld_bce_cliente, fld_cliente_id, fld_tipo_doc, fld_usuario, fld_tipo_doc_id) VALUES('" & formatDate(Fecha) & "','" & descripcion & "'," & Debito & "," & Credito & "," & update_bce_cliente(idCliente, monto, tipo_doc) & "," & idCliente & ",'" & tipo_doc & "','" & User(0) & "','" & tipo_doc_id & "')"
            .Connection.Open()
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()

    End Sub

    Friend Function update_bce_cliente(ByVal id_doc As String, ByVal Monto As Double, ByVal tipo As String) As Double
        conn.Close()


        Dim cmd As New MySqlCommand
        Dim SQL As String
        With cmd


            If tipo = "PRESTAMOS" Then

                SQL = "UPDATE tbl_clientes SET fld_bce = fld_bce + " & Monto & "   WHERE fld_id = " & id_doc & ""

            ElseIf tipo = "DEVOLUCION_PRESTAMOS" Then

                SQL = "UPDATE tbl_clientes SET fld_bce = fld_bce - " & Monto & "   WHERE fld_id = " & id_doc & ""

            ElseIf tipo = "RECIBOCOBROCXC" Then

                SQL = "UPDATE tbl_clientes SET fld_bce = fld_bce - " & Monto & "   WHERE fld_id = " & id_doc & ""

            ElseIf tipo = "INGRESO NULOS" Then

                SQL = "UPDATE tbl_clientes SET fld_bce = fld_bce + " & Monto & "   WHERE fld_id = " & id_doc & ""

            ElseIf tipo = "NDCXC" Then

                SQL = "UPDATE tbl_clientes SET fld_bce = fld_bce + " & Monto & "   WHERE fld_id = " & id_doc & ""

            ElseIf tipo = "EGRESOS" Then

                SQL = "UPDATE tbl_clientes SET fld_bce = fld_bce + " & Monto & "   WHERE fld_id = " & id_doc & ""

            ElseIf tipo = "EGRESOS NULOS" Then

                SQL = "UPDATE tbl_clientes SET fld_bce = fld_bce - " & Monto & "   WHERE fld_id = " & id_doc & ""

            ElseIf tipo = "NCCXC" Then

                SQL = "UPDATE tbl_clientes SET fld_bce = fld_bce - " & Monto & "   WHERE fld_id = " & id_doc & ""

            ElseIf tipo = "OTROS INGRESOS" Then

                SQL = "UPDATE tbl_clientes SET fld_bce = fld_bce - " & Monto & "   WHERE fld_id = " & id_doc & ""

            End If

            .Connection = conn
            .Connection.Open()
            .CommandText = SQL

            .ExecuteNonQuery()

            .Connection.Close()

        End With

        cmd.Dispose()


        Dim bce As Double

        Dim cmd1 As New MySqlCommand
        Dim SQL1 As String

        With cmd1

            SQL1 = "SELECT fld_bce FROM tbl_clientes WHERE fld_id = " & id_doc & ""
            .Connection = conn
            .Connection.Open()
            .CommandText = SQL1

            bce = .ExecuteScalar

            .Connection.Close()

        End With

        cmd1.Dispose()

        Return bce

    End Function

    Friend Sub create_row_estado_proveedor(ByVal id_proveedor As String, ByVal monto As Double, ByVal tipo_doc As String, ByVal tipo_doc_id As String, ByVal descripcion As String, ByVal fecha As Date)
        Dim cmd As New MySqlCommand

        NON_QUERY("CALL set_bce_proveedor(" & id_proveedor & ");")

        Dim Debito As Double = 0, Credito As Double = 0

        If tipo_doc = "FACTURACREDITO" Then
            Credito = monto
        ElseIf tipo_doc = "DEVOLUCION_VENTAS" Then
            Debito = monto
        ElseIf tipo_doc = "CK" Then
            Debito = monto
        ElseIf tipo_doc = "NDCXP" Then
            Debito = monto
        ElseIf tipo_doc = "NCCXP" Or tipo_doc = "NCCXP_F" Then
            Credito = monto
        ElseIf tipo_doc = "EGRESOS" Then
            Debito = monto
        ElseIf tipo_doc = "EGRESOS NULOS" Then
            Credito = monto
        ElseIf tipo_doc = "OTROS INGRESOS" Then
            Credito = monto
        End If


        With cmd

            .Connection = conn


            .CommandText = "INSERT INTO tbl_estado_proveedor (fld_date, fld_description, fld_dr, fld_cr, fld_bce_proveedor, fld_proveedor_id, fld_tipo_doc, fld_usuario, fld_tipo_doc_id)" & "VALUES('" & formatDate(fecha) & "','" & descripcion & "'," & Debito & "," & Credito & "," & update_bce_proveedor(id_proveedor, monto, tipo_doc) & "," & id_proveedor & ",'" & tipo_doc & "','" & User(0) & "','" & tipo_doc_id & "') "
            .Connection.Open()
            .ExecuteNonQuery()
            .Connection.Close()

        End With

        cmd.Dispose()


    End Sub

    Friend Function update_bce_proveedor(ByVal id As String, ByVal Monto As Double, ByVal tipo As String) As Double
        Dim cmd As New MySqlCommand
        Dim SQL As String
        With cmd

            If tipo = "FACTURACREDITO" Then
                SQL = "UPDATE tbl_supplier SET fldBalance = fldBalance + " & Monto & "   WHERE fldSupplierID = " & id & ""
            ElseIf tipo = "DEVOLUCION_VENTAS" Then
                SQL = "UPDATE tbl_supplier SET fldBalance = fldBalance - " & Monto & "   WHERE fldSupplierID = " & id & ""
            ElseIf tipo = "CK" Then
                SQL = "UPDATE tbl_supplier SET fldBalance = fldBalance - " & Monto & "   WHERE fldSupplierID = " & id & ""
            ElseIf tipo = "NDCXP" Then
                SQL = "UPDATE tbl_supplier SET fldBalance = fldBalance - " & Monto & "   WHERE fldSupplierID = " & id & ""
            ElseIf tipo = "NCCXP" Or tipo = "NCCXP_F" Then
                SQL = "UPDATE tbl_supplier SET fldBalance = fldBalance + " & Monto & "   WHERE fldSupplierID = " & id & ""
            ElseIf tipo = "EGRESOS" Then
                SQL = "UPDATE tbl_supplier SET fldBalance = fldBalance - " & Monto & "   WHERE fldSupplierID = " & id & ""
            ElseIf tipo = "EGRESOS NULOS" Then
                SQL = "UPDATE tbl_supplier SET fldBalance = fldBalance + " & Monto & "   WHERE fldSupplierID = " & id & ""
            ElseIf tipo = "OTROS INGRESOS" Then
                SQL = "UPDATE tbl_supplier SET fldBalance = fldBalance + " & Monto & "   WHERE fldSupplierID = " & id & ""
            End If


            .Connection = conn
            .Connection.Open()
            .CommandText = SQL
            .ExecuteNonQuery()
            .Connection.Close()

        End With

        cmd.Dispose()


        Dim bce As Double

        Dim cmd1 As New MySqlCommand
        Dim SQL1 As String

        With cmd1

            SQL1 = "SELECT fldBalance FROM tbl_supplier WHERE fldSupplierID = " & id & ""
            .Connection = conn
            .Connection.Open()
            .CommandText = SQL1
            bce = .ExecuteScalar
            .Connection.Close()

        End With

        cmd1.Dispose()
        Return bce

    End Function


    Friend Sub create_row_estado_banco(ByVal id_banco As String, ByVal monto As Double, ByVal tipo_doc As String, ByVal tipo_doc_id As String, ByVal descripcion As String, ByVal fecha As Date)
        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            If tipo_doc = "DEP" Then
                .CommandText = "INSERT INTO tbl_estado_banco (fld_date, fld_description, fld_dr, fld_cr, fld_bce_banco, fld_banco_id, fld_tipo_doc, fld_usuario, fld_tipo_doc_id)" _
                                           & "VALUES('" & formatDate(fecha) & "','" & descripcion & "'," & monto & "," & 0 & "," & update_bce_banco(id_banco, monto, tipo_doc) & ",'" & id_banco & "','" & tipo_doc & "','" & User(0) & "','" & tipo_doc_id & "')"
            ElseIf tipo_doc = "CK" Then
                .CommandText = "INSERT INTO tbl_estado_banco (fld_date, fld_description, fld_dr, fld_cr, fld_bce_banco, fld_banco_id, fld_tipo_doc, fld_usuario, fld_tipo_doc_id)" _
                                         & "VALUES('" & formatDate(fecha) & "','" & descripcion & "'," & 0 & "," & monto & "," & update_bce_banco(id_banco, monto, tipo_doc) & ",'" & id_banco & "','" & tipo_doc & "','" & User(0) & "','" & tipo_doc_id & "')"
            ElseIf tipo_doc = "NC" Then
                .CommandText = "INSERT INTO tbl_estado_banco (fld_date, fld_description, fld_dr, fld_cr, fld_bce_banco, fld_banco_id, fld_tipo_doc, fld_usuario, fld_tipo_doc_id)" _
                                          & "VALUES('" & formatDate(fecha) & "','" & descripcion & "'," & monto & ",0," & update_bce_banco(id_banco, monto, tipo_doc) & ",'" & id_banco & "','" & tipo_doc & "','" & User(0) & "','" & tipo_doc_id & "')"
            ElseIf tipo_doc = "ND" Then
                .CommandText = "INSERT INTO tbl_estado_banco (fld_date, fld_description, fld_dr, fld_cr, fld_bce_banco, fld_banco_id, fld_tipo_doc, fld_usuario, fld_tipo_doc_id)" _
                                          & "VALUES('" & formatDate(fecha) & "','" & descripcion & "',0," & monto & "," & update_bce_banco(id_banco, monto, tipo_doc) & ",'" & id_banco & "','" & tipo_doc & "','" & User(0) & "','" & tipo_doc_id & "')"
            ElseIf tipo_doc = "CKNULO" Then
                .CommandText = "INSERT INTO tbl_estado_banco (fld_date, fld_description, fld_dr, fld_cr, fld_bce_banco, fld_banco_id, fld_tipo_doc, fld_usuario, fld_tipo_doc_id)" _
                                           & "VALUES('" & formatDate(fecha) & "','" & descripcion & "'," & monto & "," & 0 & "," & update_bce_banco(id_banco, monto, tipo_doc) & ",'" & id_banco & "','" & tipo_doc & "','" & User(0) & "','" & tipo_doc_id & "')"


            End If
            .Connection.Open()
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()

    End Sub
    Friend Function update_bce_banco(ByVal id As String, ByVal Monto As Double, ByVal tipo As String) As Double
        Dim cmd As New MySqlCommand
        Dim SQL As String
        With cmd

            If tipo = "DEP" Then
                SQL = "UPDATE tbl_bancos SET fld_balance = fld_balance + " & Monto & "   WHERE fld_codigo = '" & id & "'"
            ElseIf tipo = "CK" Then
                SQL = "UPDATE tbl_bancos SET fld_balance = fld_balance - " & Monto & "   WHERE fld_codigo = '" & id & "'"
            ElseIf tipo = "ND" Then
                SQL = "UPDATE tbl_bancos SET fld_balance = fld_balance - " & Monto & "   WHERE fld_codigo = '" & id & "'"
            ElseIf tipo = "NC" Then
                SQL = "UPDATE tbl_bancos SET fld_balance = fld_balance + " & Monto & "   WHERE fld_codigo = '" & id & "'"
            ElseIf tipo = "CKNULO" Then
                SQL = "UPDATE tbl_bancos SET fld_balance = fld_balance + " & Monto & "   WHERE fld_codigo = '" & id & "'"
            End If

            .Connection = conn
            .Connection.Open()
            .CommandText = SQL
            .ExecuteNonQuery()
            .Connection.Close()

        End With

        cmd.Dispose()


        Dim bce As Double

        Dim cmd1 As New MySqlCommand
        Dim SQL1 As String

        With cmd1

            SQL1 = "SELECT fld_balance FROM tbl_bancos WHERE fld_codigo = '" & id & "'"
            .Connection = conn
            .Connection.Open()
            .CommandText = SQL1
            bce = .ExecuteScalar
            .Connection.Close()

        End With

        cmd1.Dispose()
        Return bce

    End Function

    Friend Function RANGO_FECHA_LETRA(ByVal Date_Time1 As DateTime, ByVal Date_Time2 As DateTime) As String
        'FORMATEA LA FECHA EN INGLES, ESTO ES PARA HACER LA BUSQUEDA EN SQL CUANDO LA BASE DE DATOS TIENE FORMATO
        'DE FECHA EN ESPAÑOL. LA RAZON ES QUE SQL SOLO HACETA BUSQUEDE DE FECHA EN FORMATO INGLES

        Dim Dia1, Mes1, Año1, Dia2, Mes2, Año2, Fecha As String
        Dia1 = Date_Time1.Day
        Select Case Date_Time1.Month
            Case 1
                Mes1 = "ENERO"
            Case 2
                Mes1 = "FEBRERO"
            Case 3
                Mes1 = "MARZO"
            Case 4
                Mes1 = "ABRIL"
            Case 5
                Mes1 = "MAYO"
            Case 6
                Mes1 = "JUNIO"
            Case 7
                Mes1 = "JULIO"
            Case 8
                Mes1 = "AGOSTO"
            Case 9
                Mes1 = "SEPTIEMBRE"
            Case 10
                Mes1 = "OCTUBRE"
            Case 11
                Mes1 = "NOVIEMBRE"
            Case 12
                Mes1 = "DICIEMBRE"

        End Select
        Año1 = Date_Time1.Year


        Dia2 = Date_Time2.Day
        Select Case Date_Time2.Month
            Case 1
                Mes2 = "ENERO"
            Case 2
                Mes2 = "FEBRERO"
            Case 3
                Mes2 = "MARZO"
            Case 4
                Mes2 = "ABRIL"
            Case 5
                Mes2 = "MAYO"
            Case 6
                Mes2 = "JUNIO"
            Case 7
                Mes2 = "JULIO"
            Case 8
                Mes2 = "AGOSTO"
            Case 9
                Mes2 = "SEPTIEMBRE"
            Case 10
                Mes2 = "OCTUBRE"
            Case 11
                Mes2 = "NOVIEMBRE"
            Case 12
                Mes2 = "DICIEMBRE"

        End Select
        Año2 = Date_Time2.Year
        Fecha = "Desde " & Dia1 & "/" & Mes1 & "/" & Año1 & " Hasta " & Dia2 & "/" & Mes2 & "/" & Año2

        Return Fecha

    End Function


    Friend Sub PRINT_DOCUMENTO_RI(ByVal RecID As String, ByVal nombre_printer As String)

        Dim ds As New DataSet

        Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
        daProf.Fill(ds, "tbl_profiledocument")




        If objIniFile.GetString("COMPANY", "Tipo Impresora RI", "Normal") = "Normal" Then
            Dim daInv As New MySqlDataAdapter("SELECT * FROM view_ri_cxc WHERE fld_id_ri=" & RecID & "", conn)
            daInv.Fill(ds, "view_ri_cxc")
            Dim dr As DataRow

            For Each dr In ds.Tables(1).Rows
                Dim largo = Len(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")))
                Dim decimales = Mid(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")), largo - 2)
                dr("fld_Description") = Num2Text(dr("fld_monto") - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
                dr("fld_bce_anterior") = SCALAR_NUM("SELECT IFNULL(SUM(fld_interes_cuota_balance),0) FROM tbl_cuotas WHERE fld_id_del_cliente_cuotas = " & dr("fld_id_cliente_ri") & " AND fld_fecha_termina_cuotas < DATE(NOW()) AND fld_interes_cuota_balance > 0")
            Next

            Dim Report As New RPT_RECIBO_INGRESO
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PrinterName = nombre_printer
            Report.PrintToPrinter(1, True, 0, 0)
        Else

            Dim daInv As New MySqlDataAdapter("SELECT * FROM tbl_recibo_ingresos_imprimir WHERE ReciboNo=" & RecID & "", conn)
            daInv.Fill(ds, "tbl_recibo_ingresos_imprimir")

            Dim Report As New RPT_RECIBO_INGRESO_SP
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PrinterName = nombre_printer
            Report.PrintToPrinter(1, True, 0, 0)
        End If



    End Sub

    Public Sub PRINT_DOCUMENTO_NCCXC(ByVal field_id As String, ByVal nombre_printer As String)



        Dim ds As New DataSet

        Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
        daP.Fill(ds, "tbl_profiledocument")

        Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_cxc_nota_credito WHERE fld_id_nc_cxc=" & field_id & "", conn)
        daP1.Fill(ds, "view_cxc_nota_credito")


        Dim dr As DataRow

        For Each dr In ds.Tables(1).Rows
            Dim largo = Len(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")))
            Dim decimales = Mid(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")), largo - 2)

            dr("fld_nombre_banco2") = Num2Text(dr("fld_monto") - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
        Next

        Dim Report As New RPT_NC_CXC
        Report.Database.Tables(0).SetDataSource(ds)
        Report.PrintOptions.PrinterName = nombre_printer
        Report.PrintToPrinter(1, True, 0, 0)




    End Sub
    Public Sub ImprimirEgreso(ByVal IdDoc As Integer)

        Dim PrintDialog1 As New PrintDialog
        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        PrintDialog1.Document = docToPrint

        Dim result As DialogResult = PrintDialog1.ShowDialog()

        ' If the result is OK then print the document.
        If (result = Windows.Forms.DialogResult.OK) Then


            Dim ds As New DataSet


            Dim pd As New PrintDocument, strOldPrinter As String
            strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print 


            Dim WshNetwork As Object
            WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
            WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName) 'Set the Default Print 


            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim da As New MySqlDataAdapter("SELECT * FROM tbl_recibo_egresos WHERE fldIdDoc=" & IdDoc & "  ", conn)
            da.Fill(ds, "tbl_recibo_egresos")

            Dim dr As DataRow

            For Each dr In ds.Tables(1).Rows
                Dim largo = Len(CStr(Format(CDbl(dr("fldMonto")), "##,###.00")))
                Dim decimales = Mid(CStr(Format(CDbl(dr("fldMonto")), "##,###.00")), largo - 2)

                dr("fldMontoLetra") = Num2Text(dr("fldMonto") - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
            Next
            If objIniFile.GetString("COMPANY", "Tipo Impresora RI", "Normal") = "Normal" Then
                Dim Report As New RPT_EGRESO_DE_CAJA
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
                Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
                Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, 0, 0)
            Else
                Dim Report As New rptEgresoDeCajaSP
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
                Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
                Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, 0, 0)
            End If



            WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print

        End If

    End Sub


    Public Sub AutoCompleteCombo_KeyUp(ByVal cbo As ComboBox, ByVal e As KeyEventArgs)
        Dim sTypedText As String
        Dim iFoundIndex As Integer
        Dim oFoundItem As Object
        Dim sFoundText As String
        Dim sAppendText As String

        'Allow select keys without Autocompleting
        Select Case e.KeyCode
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Up, Keys.Delete, Keys.Down
                Return
        End Select

        'Get the Typed Text and Find it in the list
        sTypedText = cbo.Text
        iFoundIndex = cbo.FindString(sTypedText)

        'If we found the Typed Text in the list then Autocomplete
        If iFoundIndex >= 0 Then

            'Get the Item from the list (Return Type depends if Datasource was bound 
            ' or List Created)
            oFoundItem = cbo.Items(iFoundIndex)

            'Use the ListControl.GetItemText to resolve the Name in case the Combo 
            ' was Data bound
            sFoundText = cbo.GetItemText(oFoundItem)

            'Append then found text to the typed text to preserve case
            sAppendText = sFoundText.Substring(sTypedText.Length)
            cbo.Text = sTypedText & sAppendText

            'Select the Appended Text
            cbo.SelectionStart = sTypedText.Length
            cbo.SelectionLength = sAppendText.Length

        End If

    End Sub
    Public Sub AutoCompleteCombo_Leave(ByVal cbo As ComboBox)
        Dim iFoundIndex As Integer
        iFoundIndex = cbo.FindStringExact(cbo.Text)
        cbo.SelectedIndex = iFoundIndex
    End Sub
    Friend Sub create_cod_ck(ByVal cta As String)
        NON_QUERY("UPDATE tbl_cod_ck SET fld_ck_no = fld_ck_no + 1 WHERE fld_cuenta_no = '" & cta & "'")
    End Sub

    Friend Function edadExacta(ByVal fecha As Date)
        'Try
        Dim fecActual As Date
            Dim fecNac As Date
            Dim edad_en_anios, edad_en_meses, edad_en_dias As Long
            fecActual = Now
        fecNac = fecha
        Try
            edad_en_anios = DateDiff("yyyy", fecNac, fecActual)

            If fecActual.Month < fecNac.Month Then
                edad_en_anios = edad_en_anios - 1
            End If
            edad_en_meses = DateDiff("m", fecNac, fecActual) - (edad_en_anios * 12)
            edad_en_dias = DateDiff("d", CDate(fecNac.Day & "/" & (Month(fecActual) - IIf(fecNac.Day >= fecActual.Day, 1, 0)) & "/" & Year(fecActual)), Now)
        Catch ex As Exception

        End Try
        Return edad_en_anios & " Años " & edad_en_meses & " Meses " & edad_en_dias & " Dias "

        'vbCrLf
    End Function


End Module
