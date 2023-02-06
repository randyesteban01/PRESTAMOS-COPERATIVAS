Public Class FrmReporte_CXC
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        'ParametroReporte = ""
        'ParametroReporte = nudDiasVencidos.Value
        'If nudDiasVencidos.Value > 0 Then
        'ParametroReporte = " SELECT fld_balance,fld_fecha_ultimo_abono FROM tbl_prestamos WHERE fld_fecha_ultimo_abono BETWEEN" & formatDate(dtpFecha.Value.Date) & " AND " & formatDate(DtFecha2.Value.Date) & ""
        'Else
        'ParametroReporte = ""
        'End If
        fecha1 = formatDate(dtpFecha.Value.Date)
        fecha2 = formatDate(DtFecha2.Value.Date)
        'Me.Text = cmbZona.SelectedValue
        FrmReportes.Show()

        'Me.Close()
    End Sub
End Class