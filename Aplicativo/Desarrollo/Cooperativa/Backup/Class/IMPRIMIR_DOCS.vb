Imports System
Imports Microsoft.VisualBasic
Imports System.IO
Imports Microsoft.Win32
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Module IMPRIMIR_DOCS
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument

    Friend id_orden As Integer = 0

    Dim x_fecha_top As Integer = 0
    Dim y_fecha_top As Integer = 0
    Dim x_concepto As Integer = 0
    Dim y_concepto As Integer = 0
    Dim x_valor_top As Integer = 0
    Dim y_valor_top As Integer = 0
    Dim x_beneficiario As Integer = 0
    Dim y_beneficiario As Integer = 0
    Dim x_valor As Integer = 0
    Dim y_valor As Integer = 0
    Dim x_letras As Integer = 0
    Dim y_letras As Integer = 0
    Dim x_pri_dig_dia As Integer = 0
    Dim y_pri_dig_dia As Integer = 0
    Dim x_seg_dig_dia As Integer = 0
    Dim y_seg_dig_dia As Integer = 0
    Dim x_pri_dig_mes As Integer = 0
    Dim y_pri_dig_mes As Integer = 0
    Dim x_seg_dig_mes As Integer = 0
    Dim y_seg_dig_mes As Integer = 0
    Dim x_pri_dig_ano As Integer = 0
    Dim y_pri_dig_ano As Integer = 0
    Dim x_seg_dig_ano As Integer = 0
    Dim y_seg_dig_ano As Integer = 0
    Dim x_ter_dig_ano As Integer = 0
    Dim y_ter_dig_ano As Integer = 0
    Dim x_cuar_dig_ano As Integer = 0
    Dim y_cuar_dig_ano As Integer = 0

#Region "IMPRIMIR e.Graphics"


    Private Sub CargarVariableChequeras(ByVal idDocumento As Integer)
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_confg_chequera WHERE fld_doc_chequera=" & idDocumento & "", conn)
        da.Fill(ds, "tbl_confg_chequera")
        For Each dr In ds.Tables(0).Rows
            x_fecha_top = dr("fld_x_fecha_top")
            y_fecha_top = dr("fld_y_fecha_top")
            x_concepto = dr("fld_x_concepto")
            y_concepto = dr("fld_y_concepto")
            x_valor_top = dr("fld_x_valor_top")
            y_valor_top = dr("fld_y_valor_top")
            x_beneficiario = dr("fld_x_beneficiario")
            y_beneficiario = dr("fld_y_beneficiario")
            x_valor = dr("fld_x_valor")
            y_valor = dr("fld_y_valor")
            x_letras = dr("fld_x_letras")
            y_letras = dr("fld_y_letras")
            x_pri_dig_dia = dr("fld_x_pri_dig_dia")
            y_pri_dig_dia = dr("fld_y_pri_dig_dia")
            x_seg_dig_dia = dr("fld_x_seg_dig_dia")
            y_seg_dig_dia = dr("fld_y_seg_dig_dia")
            x_pri_dig_mes = dr("fld_x_pri_dig_mes")
            y_pri_dig_mes = dr("fld_y_pri_dig_mes")
            x_seg_dig_mes = dr("fld_x_seg_dig_mes")
            y_seg_dig_mes = dr("fld_y_seg_dig_mes")
            x_pri_dig_ano = dr("fld_x_pri_dig_ano")
            y_pri_dig_ano = dr("fld_y_pri_dig_ano")
            x_seg_dig_ano = dr("fld_x_seg_dig_ano")
            y_seg_dig_ano = dr("fld_y_seg_dig_ano")
            x_ter_dig_ano = dr("fld_x_ter_dig_ano")
            y_ter_dig_ano = dr("fld_y_ter_dig_ano")
            x_cuar_dig_ano = dr("fld_x_cuar_dig_ano")
            y_cuar_dig_ano = dr("fld_y_cuar_dig_ano")
        Next
        ds.Dispose()
        da.Dispose()
        dr = Nothing

    End Sub


    Private Function Repeat(ByVal instr As String, ByVal n As Integer) As String
        Dim result = String.Empty
        Dim i
        For i = 0 To n - 1
            result += instr
        Next
        Return result
    End Function

    
  

    Friend Sub Imprimir_cheque(ByVal id_fact As Integer, ByVal impresora As String, ByVal id_chequera As Integer)
        CargarVariableChequeras(id_chequera)
        Id = id_fact
        PrintDocument2 = New System.Drawing.Printing.PrintDocument
        PrintDocument2.PrinterSettings.PrinterName = impresora 'Print_Name
        PrintDocument2.Print()
        Id = 0
    End Sub

    Private Sub Print_cheque(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage

        '//CUERPO DEL CHEQUE
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_cheques WHERE fld_id_doc=" & Id & "", conn)
        da.Fill(ds, "tbl_cheques")

        For Each dr In ds.Tables(0).Rows
            e.Graphics.DrawString(Format(dr("fld_fecha"), "dd - MMM - yyyy"), New Font("Arial", 10), Brushes.Black, x_fecha_top, y_fecha_top)
            e.Graphics.DrawString(dr("fld_concepto"), New Font("Arial", 10), Brushes.Black, x_concepto, y_concepto)
            e.Graphics.DrawString(Format(dr("fld_monto"), "C2"), New Font("Arial", 10), Brushes.Black, x_valor_top, y_valor_top)
            e.Graphics.DrawString(dr("fld_beneficiario"), New Font("Arial", 10), Brushes.Black, x_beneficiario, y_beneficiario)
            e.Graphics.DrawString(Format(dr("fld_monto"), "C2"), New Font("Arial", 10), Brushes.Black, x_valor, y_valor)
            e.Graphics.DrawString(dr("fld_monto_letras"), New Font("Arial", 10), Brushes.Black, x_letras, y_letras)

            Dim fecha As Date = CType(dr("fld_fecha"), Date)

            Dim p_d_d = Microsoft.VisualBasic.Left(Format(fecha.Day, "00"), 1)
            e.Graphics.DrawString(p_d_d, New Font("Arial", 9), Brushes.Black, x_pri_dig_dia, y_pri_dig_dia)

            Dim s_d_d = Microsoft.VisualBasic.Right(Format(fecha.Day, "00"), 1)
            e.Graphics.DrawString(s_d_d, New Font("Arial", 9), Brushes.Black, x_seg_dig_dia, y_seg_dig_dia)

            Dim p_d_m = Microsoft.VisualBasic.Left(Format(fecha.Month, "00"), 1)
            e.Graphics.DrawString(p_d_m, New Font("Arial", 9), Brushes.Black, x_pri_dig_mes, y_pri_dig_dia)

            Dim s_d_m = Microsoft.VisualBasic.Right(Format(fecha.Month, "00"), 1)
            e.Graphics.DrawString(s_d_m, New Font("Arial", 9), Brushes.Black, x_seg_dig_mes, y_seg_dig_mes)

            Dim grup1_ano = Microsoft.VisualBasic.Left(Format(fecha.Year, "####"), 2)
            Dim p_d_grupo1_ano = Microsoft.VisualBasic.Left(grup1_ano, 1)
            e.Graphics.DrawString(p_d_grupo1_ano, New Font("Arial", 9), Brushes.Black, x_pri_dig_ano, y_pri_dig_ano)

            Dim s_d_grupo1_ano = Microsoft.VisualBasic.Right(grup1_ano, 1)
            e.Graphics.DrawString(s_d_grupo1_ano, New Font("Arial", 9), Brushes.Black, x_seg_dig_ano, y_seg_dig_ano)


            Dim grup2_ano = Microsoft.VisualBasic.Right(Format(fecha.Year, "####"), 2)
            Dim p_d_grupo2_ano = Microsoft.VisualBasic.Left(grup2_ano, 1)
            e.Graphics.DrawString(p_d_grupo2_ano, New Font("Arial", 9), Brushes.Black, x_ter_dig_ano, y_ter_dig_ano)

            Dim s_d_grupo2_ano = Microsoft.VisualBasic.Right(grup2_ano, 1)
            e.Graphics.DrawString(s_d_grupo2_ano, New Font("Arial", 9), Brushes.Black, x_cuar_dig_ano, y_cuar_dig_ano)


        Next


    End Sub


#End Region

  


End Module
