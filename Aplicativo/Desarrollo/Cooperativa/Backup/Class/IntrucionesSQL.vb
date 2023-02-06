Imports MySql.Data.MySqlClient
Module IntrucionesSQL

    
    Public Sub NON_QUERY(ByVal query As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        'Try

        Dim cmd As New MySqlCommand
        With cmd
            .CommandText = query
            .Connection = conn
            .Connection.Open()
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()

        'Catch ex As Exception
        '    Alerta("Ha ocurrido una interruci�n de tipo TEXTO, la misma se mostrar� a continuaci�n.")
        '    Alerta(ex.Message)

        'End Try
    End Sub
    Public Function SCALAR_STRING(ByVal query As String) As String
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Try
            Dim cmd As New MySqlCommand, values As String = ""
            With cmd
                .CommandText = query
                .Connection = conn
                .Connection.Open()
                values = .ExecuteScalar
                .Connection.Close()
            End With
            cmd.Dispose()
            SCALAR_STRING = values
        Catch ex As Exception
            Alerta("Ha ocurrido una interruci�n de tipo TEXTO, la misma se mostrar� a continuaci�n.")
            Alerta(ex.Message)

        End Try
    End Function
    Public Function SCALAR_NUM(ByVal query As String) As Double
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Try
            Dim cmd As New MySqlCommand, values As Double = 0
            With cmd
                .CommandText = query
                .Connection = conn
                .Connection.Open()
                values = .ExecuteScalar
                .Connection.Close()
            End With
            cmd.Dispose()
            SCALAR_NUM = values
        Catch ex As Exception
            Alerta("ha ocurrido una interruci�n de tipo NUMERO, la misma se mostrar� a continuaci�n.")
            Alerta(ex.Message)

        End Try
    End Function
    Public reader_values()
    Public Sub READER(ByVal query As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Try
            Dim cmd As New MySqlCommand, dr As MySqlDataReader
            With cmd
                .CommandText = query
                .Connection = conn
                .Connection.Open()
                dr = .ExecuteReader
            End With

            Dim i
            If dr.Read Then
                ReDim reader_values(dr.FieldCount)

                For i = 0 To dr.FieldCount - 1
                    reader_values(i) = dr(i)
                Next

            End If
            dr.Close()
            cmd.Connection.Close()
            cmd.Dispose()
        Catch ex As Exception
            Alerta("ha ocurrido una interruci�n, la misma se mostrar� a continuaci�n.")
            Alerta(ex.Message)

        End Try
    End Sub


End Module
