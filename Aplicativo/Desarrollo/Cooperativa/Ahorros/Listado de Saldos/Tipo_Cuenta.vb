Public Class Tipo_Cuenta
    Private Sub SetDates()
        If DateTime1.Value > DateTime2.Value Then
            Help.ShowPopup(DateTime1, "La primera fecha debe ser menor a la segunda", New Point(550, 375))
            Exit Sub
        End If
        fecha1 = formatDate(DateTime1.Value)
        fecha2 = formatDate(DateTime2.Value)
        fecha_rango = RANGO_FECHA_LETRA(DateTime1.Value, DateTime2.Value)
        Me.Text = "ACEPTAR"
        Me.Close()
    End Sub
    Private Sub Cargar_Lista()
        With LvSaldos
            .Items.Clear()
            .View = View.Details
            .GridLines = True
            .FullRowSelect = True
            .Scrollable = True
            .HideSelection = True
            .Columns.Add("Codigo", 0, HorizontalAlignment.Left)
            .Columns.Add("Tipos de Cuentas", 200, HorizontalAlignment.Left)

        End With


    End Sub
    Private Sub Cargar_Categoria_de_ahorro()
        Dim dato As New DataTable
        LLenar_ListView(dato)
        LvSaldos.Items.Clear()

        For Each registro As DataRow In dato.Rows
            Dim fila As ListViewItem

            fila = LvSaldos.Items.Add(registro("ID"))
            With fila
                .SubItems.Add(registro("Descripcion"))
            End With
        Next

    End Sub
    Private Sub Tipo_Cuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        ElseIf e.KeyChar = Chr(13) Then
            SetDates()
        End If
    End Sub

    Private Sub Tipo_Cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        DateTime1.Value = PrimerDiaDelMes(DateTime1.Value.Date)
        DateTime2.Value = UltimoDiaDelMes(DateTime2.Value.Date)
        Cargar_Lista()
        Cargar_Categoria_de_ahorro()
        Dim resaltar As New listviewResaltar
        resaltar.pintar_Columnas_listview(LvSaldos)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub LvSaldos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LvSaldos.MouseDoubleClick
        seleccionar_descripcion()
        Me.Text = "ACEPTAR"
        AllReportSinFecha("Listado por Tipo de Ahorros")
        Me.Close()
    End Sub
    Private Sub seleccionar_descripcion()
        Dim list As ListViewItem = LvSaldos.SelectedItems(0)
        If LvSaldos.SelectedIndices.Count = 0 Then
        Else
            Filtro = list.SubItems(1).Text
        End If
        Me.Close()
    End Sub
    Private Sub LvSaldos_KeyDown(sender As Object, e As KeyEventArgs) Handles LvSaldos.KeyDown
        Dim list As ListViewItem = LvSaldos.SelectedItems(0)
        If LvSaldos.SelectedIndices.Count = 0 Then
        Else
            Filtro = list.SubItems(1).Text
        End If
        Me.Close()
    End Sub

    Private Sub BtnSocios_Click(sender As Object, e As EventArgs) Handles BtnSocios.Click
        ReportName = "Listado de  Ahorros por socio"
        Filtro = "A"
        FRM_POPUP_CLIENTES.ShowDialog()
        Me.Close()
    End Sub
End Class