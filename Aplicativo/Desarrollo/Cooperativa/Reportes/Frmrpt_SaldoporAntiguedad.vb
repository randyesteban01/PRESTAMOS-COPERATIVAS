Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Frmrpt_SaldoporAntiguedad
    Private Sub Frmrpt_SaldoporAntiguedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Saldo_por_Antiguedad_3060__Dias()
    End Sub
    Private Sub Saldo_por_Antiguedad_3060__Dias()
        Dim dt As New DataTable
        Dim da As MySqlDataAdapter
        Dim rpt As New RPT_SaldoXantiguedad30_60_dias
        Try
            da = New MySqlDataAdapter("SELECT fld_fullname,fld_fecha_termina_cuotas,fld_monto_cuotas,fldCompany,fldAddress,fldPhone,fldRnc,foto, IF (DATEDIFF(fld_fecha_termina_cuotas,DATE(NOW()))=30,'A','B') AS clasificacion
 FROM view_cuotas_todas 
 CROSS JOIN tbl_profiledocument
WHERE fld_fecha_termina_cuotas BETWEEN '2021-09-01' AND '2021-10-29'", conn)
            da.Fill(dt)
            rpt.SetDataSource(dt)
            CrVSaldoPorAntiguedad.ReportSource = rpt
            rpt.Refresh()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class