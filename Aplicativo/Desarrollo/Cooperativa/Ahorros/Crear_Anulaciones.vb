Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class Crear_Anulaciones
    Private Sub Cargar_Lista()
        With LvAnulacion
            .Items.Clear()
            .View = View.Details
            .LabelEdit = False
            .GridLines = True
            .FullRowSelect = True
            .Scrollable = True
            .HideSelection = True
            .Columns.Add("Codigo", 0, HorizontalAlignment.Left)
            .Columns.Add("Conceptos", 150, HorizontalAlignment.Left)

        End With


    End Sub
    Private Sub Cargar_Anulaciones()
        Dim dato As New DataTable
        LLenar_ListView_anulacion(dato)
        LvAnulacion.Items.Clear()

        For Each registro As DataRow In dato.Rows
            Dim fila As ListViewItem

            fila = LvAnulacion.Items.Add(registro("fld_cod_concepto"))
            With fila
                .SubItems.Add(registro("descripcion"))
            End With
        Next

    End Sub

    Private Sub Crear_Anulaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LvAnulacion.Clear()
        Cargar_Lista()
        Cargar_Anulaciones()
        Dim resaltar As New listviewResaltar
        resaltar.pintar_Columnas_listview(LvAnulacion)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub Agregar_anulaciones()
        Dim item As New ListViewItem("fld_cod_concepto")
        item.SubItems.Add(TxtDescripcion.Text)
        LvAnulacion.Items.Add(item)
        Insertar_Anulaciones()
        TxtDescripcion.Text = ""
        Cargar_Anulaciones()
        TxtDescripcion.Focus()
    End Sub
    Private Sub Insertar_Anulaciones()
        Dim cmd As New MySqlCommand
        Try
            conn.Open()
            cmd = New MySqlCommand(" insert into tbl_descripcionConcepto(fld_cod_concepto,descripcion) values(null,'" & TxtDescripcion.Text & "')", conn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Insertar_Anulaciones()
    End Sub

    Private Sub TxtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        If TxtDescripcion.Text.Length > 0 Then
            If e.KeyChar = ChrW(Keys.Enter) Then
                Agregar_anulaciones()
            End If
        Else
            'MessageBox.Show("No se permite Agregar Concepto En Blanco", "Concepto Para Anular", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class