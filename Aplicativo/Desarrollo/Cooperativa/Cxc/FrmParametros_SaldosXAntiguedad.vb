Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class FrmParametros_SaldosXAntiguedad
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub Limpiar()
        TxtNormal.Text = "" : TxtNA.Text = ""
        TxtNA2.Text = "" : TxtSna.Text = ""
        TxtCc.Text = "" : TxtCc2.Text = ""
        TxtStAtraso.Text = "" : TxtCL.Text = ""
        TxtCL2.Text = "" : TxtStCL.Text = ""
        TxtPc.Text = "" : TxtstPC.Text = ""
    End Sub
    Private Sub Insertar_Par_Saldo_X_Antiguedad()
        Dim cmd As New MySqlCommand
        Try
            cmd = New MySqlCommand("Par_Saldo_POr_Antiguedad", conn)
            cmd.CommandType = 4
            cmd.Parameters.Add("_N", TxtNormal.Text)
            cmd.Parameters.Add("_Status_N", TxtStNormal.Text)
            cmd.Parameters.Add("_CC1", TxtCc.Text)
            cmd.Parameters.Add("_CC2", TxtCc2.Text)
            cmd.Parameters.Add("_Status_CC", TxtStAtraso.Text)
            cmd.Parameters.Add("_NA1", TxtNA.Text)
            cmd.Parameters.Add("_NA2", TxtNA2.Text)
            cmd.Parameters.Add("_Statuss_NA", TxtSna.Text)
            cmd.Parameters.Add("_CL1", TxtCL.Text)
            cmd.Parameters.Add("_CL2", TxtCL2.Text)
            cmd.Parameters.Add("_Status_CL", TxtStCL.Text)
            cmd.Parameters.Add("_PC1", TxtPc.Text)
            cmd.Parameters.Add("_Statuss_PC", TxtstPC.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Insertar_Par_Saldo_X_Antiguedad()
    End Sub
End Class