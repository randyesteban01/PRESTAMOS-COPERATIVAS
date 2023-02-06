Public Class listviewResaltar

    Public Sub pintar_Columnas_listview(ByRef lista As ListView)
        Dim count As Integer = 1
        For i As Integer = 0 To lista.Items.Count - 1

            If count Mod 2 = 0 Then

            Else

                lista.Items(i).BackColor = Color.WhiteSmoke

            End If

            count += 1
        Next
    End Sub
End Class
