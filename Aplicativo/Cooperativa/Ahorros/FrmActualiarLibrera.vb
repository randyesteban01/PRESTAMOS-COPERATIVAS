Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmActualiarLibrera
    Private Sub btnImprime_Click(sender As Object, e As EventArgs) Handles btnImprime.Click

    End Sub
    Private Sub GuardarDatosLibretas()

    End Sub
    Private Sub ActualizarLibretas()

    End Sub
    Private Sub CargarLibreta()
        Dim da As MySqlDataAdapter
        Dim dt As New DataSet
        Try
            conn.Open()

            If RbtDeposito.Checked = True Then
                da = New MySqlDataAdapter("SELECT d.fecha,monto AS Depositos,a.saldointeres AS Intereses,a.saldocapital AS Balance,d.Usuario AS Cajero 
FROM tbl_ahorros_depositos  AS d
INNER JOIN tbl_ahorros_cuentas AS a
ON d.idcliente=a.idcliente
WHERE d.idCliente='" & TxtCodSocio.Text & "' AND a.CuentaNo='" & TxtNroCuenta.Text & "' AND d.fecha='" & formatDate(DtFecha.Value.Date) & "'", conn)
                'da.SelectCommand.CommandType = 4
                'da.SelectCommand.Parameters.Add("_CodSocio", TxtCodSocio.Text)
                'da.SelectCommand.Parameters.Add("_NroCuenta", TxtNroCuenta.Text)
                'da.SelectCommand.Parameters.Add("_Fecha", formatDate(DtFecha.Value.Date))
                da.Fill(dt)
                DgvLibreta.DataSource = dt.Tables(0)
                conn.Close()
            ElseIf RbtRetiro.Checked = True Then
                da = New MySqlDataAdapter("CargarRetirosLibreta", conn)
                da.SelectCommand.CommandType = 4
                da.SelectCommand.Parameters.Add("_CodSocio", TxtCodSocio.Text)
                da.SelectCommand.Parameters.Add("_NroCuenta", TxtNroCuenta.Text)
                da.SelectCommand.Parameters.Add("_Fecha", formatDate(DtFecha.Value.Date))
                da.Fill(dt)
                DgvLibreta.DataSource = dt.Tables(0)
                DgvLibreta.Columns(4).Visible = False
                'DgvLibreta.Columns(5).Visible = False
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("No hay Datos para mostrar", ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub FrmActualiarLibrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        CargarLibreta()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        'lblExcluido.Text = ""
        LoadPopupPacientes()
    End Sub
    Private Sub LoadPopupPacientes()

        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            LoadData(Id)
            DgvLibreta.Columns(4).Visible = False
            DgvLibreta.Columns(6).Visible = False
        End If

    End Sub
    Private Sub LoadData(ByVal IdCliente As Integer)
        Dim cmd As New MySqlCommand
        Dim lector As MySqlDataReader
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Try

            conn.Open()
            cmd = New MySqlCommand("SELECT Fecha,Deposito,SaldoCapital AS Balance,Usuario AS Cajero,idcliente,CuentaNo,fld_fullname FROM view_Ahorros WHERE idcliente='" & IdCliente & "'", conn)
            lector = cmd.ExecuteReader
            With lector.Read
                TxtCodSocio.Text = lector("idcliente").ToString
                TxtSocio.Text = lector("fld_fullname").ToString
            End With
            conn.Close()
            conn.Open()
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "CuentaNo"
            DgvLibreta.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class