Imports MySql.Data.MySqlClient

Module CUADRE_CAJA

    Dim min(9) As Integer, max(9) As Integer, monto(9) As Decimal, registro(9) As Integer, count_cuadre As Integer = 0, doc_afectado_dev(2) As String, fact_nulas(2) As String

    Friend Sub RETURN_VENTAS_CONTADO(ByVal fecha As Date)
        Dim cmd_min As New MySqlCommand
        Dim cmd_max As New MySqlCommand
        Dim cmd_mont As New MySqlCommand
        Dim cmd_registro As New MySqlCommand



        With cmd_registro
            .Connection = conn
            .Connection.Open()

            .CommandText = "SELECT COUNT(*) FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion='CONTADO' AND fldStatus='PROCESADA'"

            registro(0) = .ExecuteScalar
            .Connection.Close()
        End With

        cmd_registro.Dispose()

        If registro(0) = 0 Then
            min(0) = 0
            max(0) = 0
            monto(0) = 0
            Exit Sub
        End If


        With cmd_min
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MIN(fld_fact_no_contado) FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fld_fact_no_contado > 0 AND fldStatus='PROCESADA'"
            'Alerta(.CommandText)
            min(0) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_min.Dispose()


        With cmd_max
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MAX(fld_fact_no_contado) FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fld_fact_no_contado > 0 AND fldStatus='PROCESADA'"
            'Alerta(.CommandText)
            max(0) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_max.Dispose()

        With cmd_mont
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fldImporte) FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion='CONTADO' AND fldStatus='PROCESADA'"

            'Alerta(.CommandText)
            monto(0) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_mont.Dispose()



    End Sub
    Friend Sub RETURN_VENTAS_CONTADO_NULAS(ByVal fecha As Date)
        Dim cmd_min As New MySqlCommand
        Dim cmd_max As New MySqlCommand
        Dim cmd_mont As New MySqlCommand
        Dim cmd_registro As New MySqlCommand



        With cmd_registro
            .Connection = conn
            .Connection.Open()

            .CommandText = "SELECT COUNT(*) FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion='CONTADO' AND fldStatus<>'PROCESADA'"

            registro(1) = .ExecuteScalar
            .Connection.Close()
        End With

        cmd_registro.Dispose()

        If registro(1) = 0 Then
            min(1) = 0
            max(1) = 0
            monto(1) = 0
            Exit Sub
        End If

        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion='CONTADO' AND fldStatus<>'PROCESADA'", conn)
        da.Fill(ds, "tbl_ventas_devoluciones")
        For Each dr In ds.Tables(0).Rows
            If fact_nulas(0) = "" Then
                fact_nulas(0) = CStr(dr("fld_fact_no_contado"))
            Else
                fact_nulas(0) = fact_nulas(0) + ", " + CStr(dr("fld_fact_no_contado"))
            End If

        Next
        da.Dispose()
        ds.Dispose()


        With cmd_mont
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fldImporte) FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion='CONTADO' AND fldStatus<>'PROCESADA'"

            'Alerta(.CommandText)
            monto(1) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_mont.Dispose()



    End Sub
    Friend Sub RETURN_VENTAS_DEV_CONTADO(ByVal fecha As Date)
        Dim cmd_min As New MySqlCommand
        Dim cmd_max As New MySqlCommand
        Dim cmd_mont As New MySqlCommand
        Dim cmd_registro As New MySqlCommand



        With cmd_registro
            .Connection = conn
            .Connection.Open()

            .CommandText = "SELECT COUNT(*) FROM tbl_ventas_devoluciones WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion='CONTADO'"

            registro(2) = .ExecuteScalar
            .Connection.Close()
        End With

        cmd_registro.Dispose()

        If registro(2) = 0 Then
            min(2) = 0
            max(2) = 0
            monto(2) = 0
            Exit Sub
        End If


        With cmd_min
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MIN(fld_fact_no_contado) FROM tbl_ventas_devoluciones WHERE fldInvDate='" & formatDate(fecha) & "' AND fld_fact_no_contado > 0 "
            'Alerta(.CommandText)
            min(2) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_min.Dispose()


        With cmd_max
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MAX(fld_fact_no_contado) FROM tbl_ventas_devoluciones WHERE fldInvDate='" & formatDate(fecha) & "' AND fld_fact_no_contado > 0"
            'Alerta(.CommandText)
            max(2) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_max.Dispose()

        With cmd_mont
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fldImporte) FROM tbl_ventas_devoluciones WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion='CONTADO'"

            'Alerta(.CommandText)
            monto(2) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_mont.Dispose()



    End Sub
    Friend Sub RETURN_DOC_AFECTADO_DEV_CONTADO(ByVal fecha As Date)
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_ventas_devoluciones WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion='CONTADO'", conn)
        da.Fill(ds, "tbl_ventas_devoluciones")
        For Each dr In ds.Tables(0).Rows
            If doc_afectado_dev(1) = "" Then
                doc_afectado_dev(1) = CStr(dr("fld_fact_afectada"))
            Else
                doc_afectado_dev(1) = doc_afectado_dev(0) + ", " + CStr(dr("fld_fact_afectada"))
            End If

        Next
        da.Dispose()
        ds.Dispose()
    End Sub


    Friend Sub RETURN_VENTAS_CREDITO(ByVal fecha As Date)
        Dim cmd_min As New MySqlCommand
        Dim cmd_max As New MySqlCommand
        Dim cmd_mont As New MySqlCommand
        Dim cmd_registro As New MySqlCommand



        With cmd_registro
            .Connection = conn
            .Connection.Open()

            .CommandText = "SELECT COUNT(*) FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion<>'CONTADO' AND fldStatus='PROCESADA'"

            registro(3) = .ExecuteScalar
            .Connection.Close()
        End With

        cmd_registro.Dispose()

        If registro(3) = 0 Then
            min(3) = 0
            max(3) = 0
            monto(3) = 0
            Exit Sub
        End If


        With cmd_min
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MIN(fld_fact_no_credito) FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fld_fact_no_credito > 0 AND fldStatus='PROCESADA'"
            'Alerta(.CommandText)
            min(3) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_min.Dispose()


        With cmd_max
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MAX(fld_fact_no_credito) FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fld_fact_no_credito > 0 AND fldStatus='PROCESADA'"
            'Alerta(.CommandText)
            max(3) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_max.Dispose()

        With cmd_mont
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fldImporte) FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion<>'CONTADO' AND fldStatus='PROCESADA'"

            'Alerta(.CommandText)
            monto(3) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_mont.Dispose()



    End Sub
    Friend Sub RETURN_VENTAS_CREDITO_NULAS(ByVal fecha As Date)
        Dim cmd_min As New MySqlCommand
        Dim cmd_max As New MySqlCommand
        Dim cmd_mont As New MySqlCommand
        Dim cmd_registro As New MySqlCommand



        With cmd_registro
            .Connection = conn
            .Connection.Open()

            .CommandText = "SELECT COUNT(*) FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion<>'CONTADO' AND fldStatus<>'PROCESADA'"

            registro(4) = .ExecuteScalar
            .Connection.Close()
        End With

        cmd_registro.Dispose()

        If registro(4) = 0 Then
            min(4) = 0
            max(4) = 0
            monto(4) = 0
            Exit Sub
        End If


        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion<>'CONTADO' AND fldStatus<>'PROCESADA'", conn)
        da.Fill(ds, "tbl_ventas_devoluciones")
        For Each dr In ds.Tables(0).Rows
            If fact_nulas(1) = "" Then
                fact_nulas(1) = CStr(dr("fld_fact_no_credito"))
            Else
                fact_nulas(1) = fact_nulas(1) + ", " + CStr(dr("fld_fact_no_credito"))

            End If

        Next
        da.Dispose()
        ds.Dispose()

        With cmd_mont
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fldImporte) FROM tbl_ventas WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion<>'CONTADO' AND fldStatus<>'PROCESADA'"

            'Alerta(.CommandText)
            monto(4) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_mont.Dispose()



    End Sub
    Friend Sub RETURN_VENTAS_DEV_CREDITO(ByVal fecha As Date)
        Dim cmd_min As New MySqlCommand
        Dim cmd_max As New MySqlCommand
        Dim cmd_mont As New MySqlCommand
        Dim cmd_registro As New MySqlCommand



        With cmd_registro
            .Connection = conn
            .Connection.Open()

            .CommandText = "SELECT COUNT(*) FROM tbl_ventas_devoluciones WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion<>'CONTADO'"

            registro(5) = .ExecuteScalar
            .Connection.Close()
        End With

        cmd_registro.Dispose()

        If registro(5) = 0 Then
            min(5) = 0
            max(5) = 0
            monto(5) = 0
            Exit Sub
        End If


        With cmd_min
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MIN(fld_fact_no_credito) FROM tbl_ventas_devoluciones WHERE fldInvDate='" & formatDate(fecha) & "' AND fld_fact_no_credito > 0 "
            'Alerta(.CommandText)
            min(5) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_min.Dispose()


        With cmd_max
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MAX(fld_fact_no_credito) FROM tbl_ventas_devoluciones WHERE fldInvDate='" & formatDate(fecha) & "' AND fld_fact_no_credito > 0"
            'Alerta(.CommandText)
            max(5) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_max.Dispose()

        With cmd_mont
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fldImporte) FROM tbl_ventas_devoluciones WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion<>'CONTADO'"

            'Alerta(.CommandText)
            monto(5) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_mont.Dispose()



    End Sub
    Friend Sub RETURN_DOC_AFECTADO_DEV_CREDITO(ByVal fecha As Date)
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_ventas_devoluciones WHERE fldInvDate='" & formatDate(fecha) & "' AND fldCondicion<>'CONTADO'", conn)
        da.Fill(ds, "tbl_ventas_devoluciones")
        For Each dr In ds.Tables(0).Rows
            If doc_afectado_dev(0) = "" Then
                doc_afectado_dev(0) = CStr(dr("fld_fact_afectada"))
            Else
                doc_afectado_dev(0) = doc_afectado_dev(0) + ", " + CStr(dr("fld_fact_afectada"))
            End If

        Next
        da.Dispose()
        ds.Dispose()
    End Sub

    Friend Sub RETURN_RECIBOS_INGRESOS_CXC(ByVal fecha As Date)
        Dim cmd_min As New MySqlCommand
        Dim cmd_max As New MySqlCommand
        Dim cmd_mont As New MySqlCommand
        Dim cmd_registro As New MySqlCommand



        With cmd_registro
            .Connection = conn
            .Connection.Open()

            .CommandText = "SELECT COUNT(*) FROM tbl_recibo_ingresos_cxc WHERE fld_date='" & formatDate(fecha) & "'"

            registro(6) = .ExecuteScalar
            .Connection.Close()
        End With

        cmd_registro.Dispose()

        If registro(6) = 0 Then
            min(6) = 0
            max(6) = 0
            monto(6) = 0
            Exit Sub
        End If


        With cmd_min
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MIN(fld_Id_RI) FROM tbl_recibo_ingresos_cxc WHERE fld_date='" & formatDate(fecha) & "' AND fld_Id_RI > 0 "
            'Alerta(.CommandText)
            min(6) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_min.Dispose()


        With cmd_max
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MAX(fld_Id_RI) FROM tbl_recibo_ingresos_cxc WHERE fld_date='" & formatDate(fecha) & "' AND fld_Id_RI > 0 "
            'Alerta(.CommandText)
            max(6) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_max.Dispose()

        With cmd_mont
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fld_monto) FROM tbl_recibo_ingresos_cxc WHERE fld_date='" & formatDate(fecha) & "' "

            'Alerta(.CommandText)
            monto(6) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_mont.Dispose()



    End Sub
    Friend Sub RETURN_INGRESOS_CAJA(ByVal fecha As Date)
        Dim cmd_min As New MySqlCommand
        Dim cmd_max As New MySqlCommand
        Dim cmd_mont As New MySqlCommand
        Dim cmd_registro As New MySqlCommand



        With cmd_registro
            .Connection = conn
            .Connection.Open()

            .CommandText = "SELECT COUNT(*) FROM tbl_otros_ingresos_caja WHERE fld_fecha='" & formatDate(fecha) & "' "
            'Alerta(.CommandText)
            registro(7) = .ExecuteScalar

            .Connection.Close()
        End With
        'Alerta(registro(7))
        cmd_registro.Dispose()

        If registro(7) = 0 Then
            min(7) = 0
            max(7) = 0
            monto(7) = 0
            Exit Sub
        End If


        With cmd_min
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MIN(fld_id_doc) FROM tbl_otros_ingresos_caja WHERE fld_fecha='" & formatDate(fecha) & "' AND fld_id_doc > 0 "
            min(7) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_min.Dispose()


        With cmd_max
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MAX(fld_id_doc) FROM tbl_otros_ingresos_caja WHERE fld_fecha='" & formatDate(fecha) & "' AND fld_id_doc > 0 "
            max(7) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_max.Dispose()

        With cmd_mont
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fld_monto) FROM tbl_otros_ingresos_caja WHERE fld_fecha='" & formatDate(fecha) & "'"
            monto(7) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_mont.Dispose()



    End Sub
    Friend Sub RETURN_SALIDA_CAJA(ByVal fecha As Date)
        Dim cmd_min As New MySqlCommand
        Dim cmd_max As New MySqlCommand
        Dim cmd_mont As New MySqlCommand
        Dim cmd_registro As New MySqlCommand



        With cmd_registro
            .Connection = conn
            .Connection.Open()

            .CommandText = "SELECT COUNT(*) FROM tbl_compras_salida_caja WHERE fld_fecha='" & formatDate(fecha) & "'"

            registro(8) = .ExecuteScalar
            .Connection.Close()
        End With

        cmd_registro.Dispose()

        If registro(8) = 0 Then
            min(8) = 0
            max(8) = 0
            monto(8) = 0
            Exit Sub
        End If


        With cmd_min
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MIN(fld_id_doc) FROM tbl_compras_salida_caja WHERE fld_fecha='" & formatDate(fecha) & "' AND fld_id_doc > 0 "
            'Alerta(.CommandText)
            min(8) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_min.Dispose()


        With cmd_max
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT MAX(fld_id_doc) FROM tbl_compras_salida_caja WHERE fld_fecha='" & formatDate(fecha) & "' AND fld_id_doc > 0"
            'Alerta(.CommandText)
            max(8) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_max.Dispose()

        With cmd_mont
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT SUM(fld_monto) FROM tbl_compras_salida_caja WHERE fld_fecha='" & formatDate(fecha) & "'"

            'Alerta(.CommandText)
            monto(8) = .ExecuteScalar
            .Connection.Close()
        End With
        cmd_mont.Dispose()



    End Sub

    Friend Sub procesa_cuadre_caja(ByVal fecha_seleccionada As Date)
        RETURN_VENTAS_CONTADO(fecha_seleccionada)
        RETURN_VENTAS_CONTADO_NULAS(fecha_seleccionada)
        RETURN_VENTAS_DEV_CONTADO(fecha_seleccionada)
        RETURN_DOC_AFECTADO_DEV_CONTADO(fecha_seleccionada)

        RETURN_VENTAS_CREDITO(fecha_seleccionada)
        RETURN_VENTAS_CREDITO_NULAS(fecha_seleccionada)
        RETURN_VENTAS_DEV_CREDITO(fecha_seleccionada)
        RETURN_DOC_AFECTADO_DEV_CREDITO(fecha_seleccionada)

        RETURN_RECIBOS_INGRESOS_CXC(fecha_seleccionada)
        RETURN_INGRESOS_CAJA(fecha_seleccionada)
        RETURN_SALIDA_CAJA(fecha_seleccionada)

        Dim tabla_cuadre As String = "tbl_cuadre_caja"
        to_know_is_exit_cuadre(tabla_cuadre, fecha_seleccionada)
        CREATE_DOC_CAJA(tabla_cuadre, formatDate(fecha_seleccionada), CStr(Format(min(0), "00000") & " AL " & Format(max(0), "00000")), monto(0), CStr(Format(min(3), "00000") & " AL " & Format(max(3), "00000")), monto(3), CStr(Format(min(6), "00000") & " AL " & Format(max(6), "00000")), monto(6), CStr(Format(min(8), "00000") & " AL " & Format(max(8), "00000")), monto(8), fact_nulas(0), monto(1), fact_nulas(1), monto(4), CStr(Format(min(5), "00000") & " AL " & Format(max(5), "00000")), monto(5), CStr(Format(min(2), "00000") & " AL " & Format(max(2), "00000")), monto(2), doc_afectado_dev(0), doc_afectado_dev(1), CStr(Format(min(7), "00000") & " AL " & Format(max(7), "00000")), monto(7))




    End Sub
    Friend Sub to_know_is_exit_cuadre(ByVal tabla As String, ByVal fecha As Date)
        Dim cmd As New MySqlCommand, cantidad As Integer
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "DELETE  FROM " & tabla & " WHERE fld_fecha='" & formatDate(fecha) & "'"
            .ExecuteNonQuery()
            .Connection.Close()
        End With

        cmd.Dispose()


    End Sub


    Friend Sub CREATE_DOC_CAJA(ByVal tabla As String, ByVal fecha As String, ByVal d_v_contado As String, ByVal m_v_contado As String, ByVal d_v_credito As String, ByVal m_v_credito As String, ByVal d_r_i As String, ByVal m_r_i As String, ByVal d_s_caja As String, ByVal m_s_caja As String, ByVal d_v_contado_nula As String, ByVal m_v_contado_nula As String, ByVal d_v_credito_nula As String, ByVal m_v_credito_nula As String, ByVal d_d_v_credito As String, ByVal m_d_v_credito As String, ByVal d_d_v_contado As String, ByVal m_d_v_contado As String, ByVal doc_afectado_dev_credito As String, ByVal doc_afectado_dev_contado As String, ByVal d_i_caja As String, ByVal m_i_caja As String)
        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "INSERT INTO " & tabla & " (fld_fecha,fld_detalle_venta_contado,fld_monto_venta_contado,fld_detalle_venta_credito,fld_monto_venta_credito,fld_detalle_recibo_ingreso,fld_monto_recibo_ingreso,fld_detalle_salida_caja,fld_monto_salida_caja,fld_detalle_ventas_nulas_contado,fld_monto_ventas_nulas_contado,fld_detalle_ventas_nulas_credito,fld_monto_ventas_nulas_credito,fld_detalle_dev_ventas_credito,fld_monto_dev_ventas_credito,fld_detalle_dev_ventas_contado,fld_monto_dev_ventas_contado,fld_doc_afectado_dev_credito,fld_doc_afectado_dev_contado,fld_detalle_ingreso_caja,fld_monto_ingreso_caja) VALUES('" & fecha & "','" & d_v_contado & "'," & m_v_contado & ",'" & d_v_credito & "'," & m_v_credito & ",'" & d_r_i & "'," & m_r_i & ",'" & d_s_caja & "'," & m_s_caja & ",'" & d_v_contado_nula & "'," & m_v_contado_nula & ",'" & d_v_credito_nula & "'," & m_v_credito_nula & ",'" & d_d_v_credito & "'," & m_d_v_credito & ",'" & d_d_v_contado & "'," & m_d_v_contado & ",'" & doc_afectado_dev_credito & "','" & doc_afectado_dev_contado & "','" & d_i_caja & "'," & m_i_caja & ")"
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()

    End Sub



End Module
