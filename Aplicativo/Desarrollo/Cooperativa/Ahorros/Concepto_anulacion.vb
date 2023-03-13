Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class Concepto_anulacion
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        AnularRecibos()
    End Sub

    Private Sub ActualizaCuotas(ByVal IdRecibo As Integer)
        'Actuliza las Cuotas a su estado anterior al pago que se está anulando
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_recibo_ingresos_cxc_detalle WHERE fld_id_ri_padre=" & IdRecibo & "", conn)
        da.Fill(ds, "tbl_recibo_ingresos_cxc_detalle")
        Dim dr As DataRow

        For Each dr In ds.Tables(0).Rows
            NON_QUERY("UPDATE tbl_cuotas SET fld_abono_cuotas=fld_abono_cuotas-(" & dr("fld_ult_abono_interes") + dr("fld_ult_abono_capital") & "), fld_interes_cuota_abono=fld_interes_cuota_abono-" & dr("fld_ult_abono_interes") & ", fld_capital_cuota_abono=fld_capital_cuota_abono-" & dr("fld_ult_abono_capital") & ", fld_balance_cuotas=fld_monto_cuotas-fld_abono_cuotas, fld_interes_cuota_balance=fld_interes_cuota-fld_interes_cuota_abono, fld_capital_cuota_balance = fld_capital_cuota - fld_capital_cuota_abono WHERE fld_id_cuotas=" & dr("fld_cuota_id") & "")
        Next
        ds.Dispose()
        da.Dispose()

    End Sub

    Private Sub AnularRecibos()
        'If FRMS_CLAVE_MAESTRA("Borrar") = True Then

        If Alerta("¿Desea ANULAR el documento seleccionado?") = False Then Exit Sub
        READER("SELECT fld_id_cliente_ri, fld_monto, fld_concepto FROM tbl_recibo_ingresos_cxc WHERE fld_Id_RI=" & id_RI & "")

        Dim idCliente As Integer, Monto As Double = 0, Concepto As String = ""
        If reader_values.Length > 0 Then
            idCliente = reader_values(0)
            Monto = reader_values(1)
            Concepto = reader_values(2)
            'End If
            ActualizaCuotas(CInt(ID_RI))

            'formatDate(fld_fecha.Value.Date)

            create_row_estado_cliente(CStr(idCliente), Monto, "INGRESO NULOS", ID_RI, "(NULO) " & Concepto, formatDate(Now.Date))

            NON_QUERY("UPDATE tbl_recibo_ingresos_cxc SET fld_concepto=CONCAT('(NULO) ',fld_concepto),fld_interes_cobrado=0, fld_capital_cobrado=0, fld_mora_cobrada=0, fld_monto=0 WHERE fld_Id_RI=" & ID_RI & "")

            'Ingresar_concepto()

            RevertirAsientoContable()

            Alerta("El documento ha sido anulado")

            Me.Close()
        End If

    End Sub

    Private Sub RevertirAsientoContable()
        READER("SELECT TransID FROM tbl_interfascontabletransacciones WHERE TransIDDoc=" & CInt(ID_RI) & " AND TransIDTipo=3 LIMIT 1")

        Dim intTransID As Integer = 0
        If reader_values.Length > 0 Then
            intTransID = reader_values(0)


            NON_QUERY("UPDATE tbl_interfasecontabletransaccionesdetalles SET TransDDebito=0,TransDCredito=0,TransDBalance=0 WHERE TransDIDTrans=" & intTransID & "")

        End If


    End Sub

    Private Sub Ingresar_concepto()
        Try
            'NON_QUERY("Insert into cb_tbl_maestro_concepto(fld_id_mc,fld_creado_mc,fld_id_doc,fld_cod_concepto)values(null,'" & formatDate(Now.Date) & "','" & ID_RI & "','" & TxtAnulacion.Text & "')")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Llenar_comboBox_anulaciones()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter
        Try
            conn.Open()
            da = New MySqlDataAdapter("select * from tbl_descripcionConcepto", conn)
            da.Fill(dt)
            'CobAnulaciones.DataSource = dt
            'CobAnulaciones.ValueMember = "fld_cod_concepto"
            'CobAnulaciones.DisplayMember = "descripcion"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Concepto_anulacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        'Llenar_comboBox_anulaciones()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Concepto_anulacion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class