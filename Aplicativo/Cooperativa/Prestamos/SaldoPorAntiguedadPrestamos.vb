Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class SaldoPorAntiguedadPrestamos
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub SaldoPorAntiguedadPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        crear_tabla()
    End Sub
    Private Sub Eliminar_Tabla()
        Dim CMD As New MySqlCommand
        Try

            With CMD
                .CommandText = "DROP  TABLE  IF EXISTS tbl_reporte_saldos"
                .Connection = conn
                .Connection.Open()
                .ExecuteNonQuery()
                .Connection.Close()
            End With
            CMD.Dispose()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub crear_tabla()
        Eliminar_Tabla()

        Dim CMD As New MySqlCommand
        Try
            With CMD
                .CommandText = "CREATE TABLE tbl_reporte_saldos
(fld_entidad VARCHAR(100),
fld_cod_cliente INT(11),
fld_relacion_cliente VARCHAR(255),
fld_cliente VARCHAR(255),
fld_cedula VARCHAR(16),
fld_direccion VARCHAR(255),
fld_celular VARCHAR(16),
fld_razon_social VARCHAR(100),
fld_cod_prestamo INT(11),
fld_unidad_moneda CHAR(6),
fld_clasificacion VARCHAR(100),
fld_forma_pago VARCHAR(50),
fld_fecha DATE,
fld_fecha_vencimiento DATE,
fld_monto_prestamo DOUBLE(11,2),
fld_monto_cuota DOUBLE(11,2),
fld_cantidad_cuotas INT(11),
fld_fecha_ult_corte_prestamo DATE,
fld_fecha_ult_abono DATE,
fld_monto_ultimo_pago DOUBLE(11,2),
fld_balance DOUBLE(11,2),
fld_atraso DOUBLE(11,2),
fld_cant_cuotas_atrasadas INT(11),
fld_status VARCHAR(5),
fld_estado_ctas CHAR(6),
fld_saldo_vencido30 DOUBLE(11,2),
fld_saldo_vencido60 DOUBLE(11,2),
fld_saldo_vencido90 DOUBLE(11,2),
fld_saldo_vencido120 DOUBLE(11,2),
fld_saldo_vencido150 DOUBLE(11,2),
fld_saldo_vencido180 DOUBLE(11,2),
fld_saldo_vencido181 DOUBLE(11,2)
);"

                .Connection = conn

                .Connection.Open()
                .ExecuteNonQuery()
                .Connection.Close()
            End With
            CMD.Dispose()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub llenar_tabla()

    End Sub
    Public Sub Exportar_Excel_1(ByVal dgv As DataGridView, ByVal pth As String)
        Dim xlApp As Object = CreateObject("Excel.Application")
        Dim xlWB As Object = xlApp.WorkBooks.add
        Dim xlWS As Object = xlApp.WorkSheets(1)
        For c As Integer = 0 To DgvDatacredito.Columns.Count - 1
            xlWS.cells(1, c + 1).value = DgvDatacredito.Columns(c).HeaderText
        Next
        For r As Integer = 0 To DgvDatacredito.RowCount - 1
            For c As Integer = 0 To DgvDatacredito.Columns.Count - 1
                xlWS.cells(r + 2, c + 1).value = DgvDatacredito.Item(c, r).Value
            Next
        Next
        xlWB.saveas(pth)
        xlWS = Nothing
        xlWB = Nothing
        xlApp.quit()
        xlApp = Nothing
    End Sub
    Private Sub EXPORT_TO_ACCESS_DATA_CREDITO()

        Try
            Dim popuDate As New FRM_POPUP_FECHAS
            popuDate.ShowDialog()
            If popuDate.Text = "ACEPTAR" Then
                Dim show As New FrmPopupMessage
                show.Show("Actualizando préstamos... Por favor espere")
                UPDATE_CUOTAS()
                UPDATE_FECHA_ULT_ABONO()


                Dim ds As New DataSet
                Dim dr As DataRow

                Dim sql As String = "SELECT * FROM view_data_credito WHERE fld_balance_cuotas > 0  AND fld_fecha_ultimo_abono BETWEEN '" & fecha1 & "' AND '" & fecha2 & "' GROUP BY fld_id_prestamos"


                Dim daP1 As New MySqlDataAdapter(sql, conn)
                daP1.Fill(ds, "view_data_credito")

                For Each dr In ds.Tables(0).Rows
                    'UPDATE_CUOTAS_P(dr("fld_id_prestamos"))
                    'UPDATE_PRESTAMOS(dr("fld_id_prestamos"))
                Next
                'show.Close()
                'End If

                'f.Dispose()
                'CREATE_TABLE()
                Dim ds1 As New DataSet
                Dim dr1 As DataRow
                'Dim fecha1 As Date = Now.Date.AddDays(-CInt(Id))
                Dim sql1 As String = "SELECT * FROM view_data_credito WHERE fld_balance_cuotas > 0   GROUP BY fld_id_prestamos" 'fld_fecha_termina_cuotas <='" & formatDate(fecha1) & "' AND 

                Dim daP11 As New MySqlDataAdapter(sql1, conn)
                daP11.Fill(ds1, "view_data_credito")
                Dim STATUS As String = ""
                Par_data_credito()

                For Each dr1 In ds1.Tables(0).Rows
                    Id = DateDiff(DateInterval.Day, dr1("fld_fecha_termina_cuotas"), Now.Date)

                    'If Id <= 60 Then
                    If Id <= Pnormal Then
                        STATUS = Pstnormal
                        'STATUS = "N"
                    ElseIf Id > Pnormal And Id < Patraso Then
                        STATUS = Pstatraso
                    ElseIf Id > Patraso And Id < Plegal Then
                        STATUS = Pstlegal
                    ElseIf Id > Plegal Then
                        STATUS = Pstcastigado

                    ElseIf Id > Psaldado And dr1("fld_balance") = 0 Then

                        STATUS = Pstsaldado
                    End If
                    COPY_DATA_BASE_ACCESS(dr1("fld_clasificacion"), dr1("fld_id_prestamos"), dr1("fld_id"), dr1("fld_Identity"), dr1("fld_FullName"), dr1("fld_Address"), dr1("fld_Phone"), dr1("fld_nombre_gar"), STATUS, dr1("fld_capital_prestamo"), dr1("fld_fecha_entrega"), CANT_CUOTAS(dr1("fld_id_prestamos")), dr1("fld_monto_cuotas_a"), dr1("fld_fecha_ultimo_abono"), dr1("fld_balance"), BCE_CUOTAS(dr1("fld_id_prestamos")), dr1("fld_fecha_termina"), dr1("fld_ult_pago"))

                Next


                'DEBE COPIAR EL ARCHIVO DONDE ELLOS DIGAN
                MessageBox.Show("Proceso terminado con exito", "DASHA", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cargar_datos_access()
                show.Close()
            End If
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Par_data_credito()
        Dim adap As MySqlDataAdapter
        Dim ds As New DataSet
        Try

            adap = New MySqlDataAdapter("select * from tbl_estado_Credito", conn)
            adap.Fill(ds, "tbl_estado_Credito")
            For Each fila As DataRow In ds.Tables(0).Rows
                Pnormal = fila("fld_normal")
                Pstnormal = fila("fld_st_normal")
                Patraso = fila("fld_atraso")
                Pstatraso = fila("fld_st_atraso")
                Plegal = fila("fld_legal")
                Pstlegal = fila("fld_st_legal")
                Pcastigado = fila("fld_castigado")
                Pstcastigado = fila("fld_st_castigado")
                Psaldado = fila("fld_saldado")
                Pstsaldado = fila("fld_st_saldado")
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DASHa")
            conn.Close()
        End Try
    End Sub
    Private Sub COPY_DATA_BASE_ACCESS(ByVal fld_clasificacion As String, ByVal fld_cod_prestamo As Integer, ByVal fld_cod_cliente As Integer, ByVal fld_cedula As String, ByVal fld_cliente As String, ByVal fld_direccion As String, ByVal fld_celular As String, fld_garante As String, ByVal fld_estatus As String, ByVal fld_monto_prestamo As Double, ByVal fld_fecha As Date, ByVal fld_cantidad_cuotas As Integer, ByVal fld_monto_cuotas As Double, ByVal fld_fecha_ult_abono As Date, ByVal fld_balance As Double, ByVal fld_atraso As Double, ByVal fld_fecha_vencimiento As Date, ByVal fld_monto_ult_pago As Double)
        'If connA.State = ConnectionState.Open Then
        '    connA.Close()
        'End If
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        'Dim CMD As New OleDbCommand
        Dim CMD As New MySqlCommand
        With CMD
            .CommandText = "INSERT INTO tbl_reporte_credito (fld_clasificacion,fld_unidad_moneda, fld_cod_prestamo,fld_cod_cliente,fld_cedula,fld_cliente, fld_direccion, fld_celular,fld_relacion_cliente, fld_status, fld_monto_prestamo, fld_fecha, fld_cantidad_cuotas, fld_monto_cuota,fld_forma_pago, fld_fecha_ult_abono, fld_balance, fld_atraso,fld_fecha_vencimiento,fld_monto_ultimo_pago) VALUES('" & fld_clasificacion & "','RD$'," & fld_cod_prestamo & "," & fld_cod_cliente & ",'" & fld_cedula & "','" & fld_cliente & "', '" & fld_direccion & "','" & fld_celular & "','" & fld_garante & "','" & fld_estatus & "', " & fld_monto_prestamo & ",'" & formatDate(fld_fecha) & "', " & fld_cantidad_cuotas & ", " & fld_monto_cuotas & ",'EFECTIVO','" & formatDate(fld_fecha_ult_abono) & "'," & fld_balance & ", " & fld_atraso & ",'" & formatDate((fld_fecha_vencimiento)) & "'," & fld_monto_ult_pago & ")"
            .Connection = conn
            .Connection.Open()
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        CMD.Dispose()
    End Sub
    Private Function cargar_datos_access() As DataSet

        Dim adap As MySqlDataAdapter
        Dim ds As New DataSet
        Try

            adap = New MySqlDataAdapter("select * from tbl_reporte_credito", conn)
            ds = New DataSet
            'ds.Clear()
            adap.Fill(ds)
            DgvDatacredito.DataSource = ds.Tables(0)
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Prestamos Dasha")


            Return Nothing
        End Try
        Return Nothing

    End Function
    Private Function CANT_CUOTAS(ByVal ID_PREST As Integer) As Integer
        Dim CMD As New MySqlCommand, VALUES As Integer
        With CMD
            .CommandText = "SELECT COUNT(*) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & ID_PREST & ""
            .Connection = conn
            .Connection.Open()
            VALUES = .ExecuteScalar
            .Connection.Close()
        End With
        CMD.Dispose()
        CANT_CUOTAS = VALUES
    End Function
    Private Function BCE_CUOTAS(ByVal ID_PREST As Integer) As Double
        Dim CMD As New MySqlCommand, VALUES As Double
        With CMD
            .CommandText = "SELECT SUM(fld_balance_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & ID_PREST & " AND fld_fecha_termina_cuotas<'" & formatDate(Now.Date) & "'"
            .Connection = conn
            .Connection.Open()
            If .ExecuteScalar().GetType.ToString = "System.DBNull" Then
                VALUES = 0
            Else
                VALUES = .ExecuteScalar
            End If

            .Connection.Close()
        End With
        CMD.Dispose()
        BCE_CUOTAS = VALUES
    End Function

End Class