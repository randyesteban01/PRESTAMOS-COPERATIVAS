Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class FrmReportes

    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imprimir_CXC_Clientes()
    End Sub
    Private Sub imprimir_CXC_Clientes()
        Dim dt As New DataTable
        Dim da As MySqlDataAdapter
        Dim rpt As New RPT_CXC_CLIENTES2
        'dt.Clear()

        Try
            'conn.Close()
            'da = New MySqlDataAdapter("select fld_fullname,fld_apodo,fld_phone,fld_fecha_ultimo_abono,fld_balance from view_prestamos_todos ", conn)
            da = New MySqlDataAdapter("sp_reporte_CXC", conn)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.Add("_fecha1", fecha1)
            da.SelectCommand.Parameters.Add("_fecha2", fecha2)
            da.Fill(dt)
            rpt.SetDataSource(dt)
            'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            Vsr_Imprime.ReportSource = rpt

            rpt.Refresh()

            'Report1.Database.Tables(0).SetDataSource(ds1)
            'Report1.PrintOptions.PaperSize = PaperSize.PaperLetter
            'CrystalReportViewer.ReportSource = Report1
            'CrystalReportViewer.DisplayGroupTree = False
            'CrystalReportViewer.ShowGroupTreeButton = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class