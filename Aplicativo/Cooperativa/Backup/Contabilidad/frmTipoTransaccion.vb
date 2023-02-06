Imports MySql.Data.MySqlClient
Public Class frmTipoTransaccion
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents fld_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents fld_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_cta_relacionada As System.Windows.Forms.Button
    Friend WithEvents fld_modulo As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BTN_GUARDA As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTipoTransaccion))
        Me.fld_descripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LV = New System.Windows.Forms.ListView
        Me.fld_id = New System.Windows.Forms.TextBox
        Me.btn_cta_relacionada = New System.Windows.Forms.Button
        Me.fld_modulo = New System.Windows.Forms.ComboBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BTN_GUARDA = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'fld_descripcion
        '
        Me.fld_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_descripcion.Location = New System.Drawing.Point(8, 24)
        Me.fld_descripcion.MaxLength = 100
        Me.fld_descripcion.Name = "fld_descripcion"
        Me.fld_descripcion.Size = New System.Drawing.Size(336, 20)
        Me.fld_descripcion.TabIndex = 0
        Me.fld_descripcion.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción"
        '
        'LV
        '
        Me.LV.Location = New System.Drawing.Point(8, 48)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(354, 207)
        Me.LV.TabIndex = 4
        '
        'fld_id
        '
        Me.fld_id.Location = New System.Drawing.Point(312, 112)
        Me.fld_id.Name = "fld_id"
        Me.fld_id.Size = New System.Drawing.Size(22, 20)
        Me.fld_id.TabIndex = 6
        Me.fld_id.Text = "0"
        Me.fld_id.Visible = False
        '
        'btn_cta_relacionada
        '
        Me.btn_cta_relacionada.Location = New System.Drawing.Point(413, 168)
        Me.btn_cta_relacionada.Name = "btn_cta_relacionada"
        Me.btn_cta_relacionada.Size = New System.Drawing.Size(40, 23)
        Me.btn_cta_relacionada.TabIndex = 6
        Me.btn_cta_relacionada.Text = "CTA."
        Me.btn_cta_relacionada.Visible = False
        '
        'fld_modulo
        '
        Me.fld_modulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fld_modulo.Items.AddRange(New Object() {"BANCO", "VENTAS", "COMPRAS", "INVENTARIO", "CUENTA X COBRAR", "CUENTA X PAGAR"})
        Me.fld_modulo.Location = New System.Drawing.Point(392, 16)
        Me.fld_modulo.Name = "fld_modulo"
        Me.fld_modulo.Size = New System.Drawing.Size(121, 21)
        Me.fld_modulo.TabIndex = 7
        Me.fld_modulo.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(144, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 56)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Nueva"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCancelar.Location = New System.Drawing.Point(288, 264)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(72, 56)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "&Cerrar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BTN_GUARDA
        '
        Me.BTN_GUARDA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_GUARDA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_GUARDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BTN_GUARDA.ForeColor = System.Drawing.Color.Black
        Me.BTN_GUARDA.Image = CType(resources.GetObject("BTN_GUARDA.Image"), System.Drawing.Image)
        Me.BTN_GUARDA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_GUARDA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_GUARDA.Location = New System.Drawing.Point(216, 264)
        Me.BTN_GUARDA.Name = "BTN_GUARDA"
        Me.BTN_GUARDA.Size = New System.Drawing.Size(72, 56)
        Me.BTN_GUARDA.TabIndex = 1
        Me.BTN_GUARDA.Text = "&Guardar"
        Me.BTN_GUARDA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmTipoTransaccion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(370, 323)
        Me.Controls.Add(Me.BTN_GUARDA)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.fld_modulo)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fld_descripcion)
        Me.Controls.Add(Me.btn_cta_relacionada)
        Me.Controls.Add(Me.fld_id)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTipoTransaccion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de transacciones"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmTipoTransaccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        CLEAR_FIELDS()
        FillLV()

    End Sub

    Private Sub frmTipoTransaccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub SAVE_DATA()
        NON_QUERY("INSERT INTO tbl_interfascontableotrastipo(fld_descripcion, fld_modulo) VALUES('" & fld_descripcion.Text & "','" & fld_modulo.Text & "')")

    End Sub
    Private Sub UPDATE_DATA(ByVal ID_DATA As String)
        NON_QUERY("UPDATE tbl_interfascontableotrastipo SET  fld_descripcion = '" & fld_descripcion.Text & "', fld_modulo = '" & fld_modulo.Text & "' WHERE fld_id=" & CInt(fld_id.Text) & "")

    End Sub
    Private Sub LOAD_DATA(ByVal ID_DATA As String)
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT * FROM tbl_interfascontableotrastipo WHERE fld_id=" & ID_DATA & ""
            dr = .ExecuteReader()

        End With
        If dr.Read() Then
            fld_id.Text = ID_DATA

            fld_descripcion.Text = dr("fld_descripcion")
            fld_modulo.Text = dr("fld_modulo")
            BTN_GUARDA.Text = "&Modificar"
        End If
        cmd.Connection.Close()
        cmd.Dispose()
    End Sub
    Private Sub DELETE_DATA(ByVal ID_DATA As String)
        NON_QUERY("DELETE FROM tbl_interfascontableotrastipo WHERE fld_id=" & ID_DATA & "")
    End Sub
    Private Sub CLEAR_FIELDS()
        fld_id.Text = 0

        fld_descripcion.Text = ""
        fld_modulo.Text = Nothing
        BTN_GUARDA.Text = "&Guardar"
    End Sub
    Private Function VALIDA_DATA() As Boolean
        If Trim(fld_descripcion.Text) = "" Then
            Alerta("Debe escribir la descripción del documento")
            fld_descripcion.Focus()
            Return False

        End If
        Return True
    End Function


    Private Sub FillLV()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.Ascending


        Dim fldToSearch As String = "fld_descripcion" ' = cboSearch.Text
        Dim strTosearch As String = "'" & fld_descripcion.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short

        If strTosearch <> "" Then
            sqlSearch = "SELECT fld_id,  fld_descripcion FROM tbl_interfascontableotrastipo WHERE " & fldToSearch & " LIKE " & strTosearch & " "
        Else
            sqlSearch = "SELECT fld_id,  fld_descripcion FROM tbl_interfascontableotrastipo"
        End If

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_interfascontableotrastipo")


        Dim columnText(4) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "CODIGO"
        columnText(1) = "Código"
        columnText(2) = "Descripción"
        columnText(3) = "Cta. Relacionada"

        Dim columnWidth(4) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 336
        columnWidth(2) = 265
        columnWidth(3) = 118


        Dim columnAlign(4) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 0 'IZQUIERDA



        Dim count = 0
        Dim c As DataColumn
        For Each c In ds.Tables(0).Columns
            'adding names of columns as Listview columns				
            Dim h As New ColumnHeader
            h.Text = columnText(count) ' c.ColumnName
            h.TextAlign = columnAlign(count)
            h.Width = columnWidth(count)
            Me.LV.Columns.Add(h)
            count += 1
        Next



        Dim dt As DataTable = ds.Tables(0)
        Dim str(ds.Tables(0).Columns.Count) As String
        'adding Datarows as listview Grids
        Dim rr As DataRow



        For Each rr In dt.Rows

            For col As Integer = 0 To ds.Tables(0).Columns.Count - 1
                '/FORMATEAMO LOS DATOS DE ACUERDO A SU FORMATO, ESTO SE HACE POR CADA COLUMNA QUE EXISTA
                If rr(col).GetType().FullName.ToString = "System.Int32" Then
                    str(col) = Format(rr(col), "00000")
                ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                    str(col) = Format(rr(col), "d")
                ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                    str(col) = rr(col).ToString()
                ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                    str(col) = Format(rr(col), "##,##0.00")
                End If
            Next

            Dim ii As New ListViewItem(str)
            LV.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub

    Private Sub fld_descripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_descripcion.KeyPress
        If e.KeyChar = Chr(13) Then
            If VALIDA_DATA() = False Then Exit Sub
            If BTN_GUARDA.Text = "&Guardar" Then
                SAVE_DATA()
                Alerta("Documento guardado")
            Else
                UPDATE_DATA(fld_id.Text)
                Alerta("Documento modificado")
            End If
            FillLV()
            CLEAR_FIELDS()
        End If

    End Sub

    Private Sub LV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.Enter Then
            LOAD_DATA(LV.FocusedItem.Text)
        End If
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        LOAD_DATA(LV.FocusedItem.Text)
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CLEAR_FIELDS()
    End Sub

    Private Sub BTN_GUARDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDA.Click
        If VALIDA_DATA() = False Then Return
        If BTN_GUARDA.Text = "&Guardar" Then

            SAVE_DATA()

        Else
            UPDATE_DATA(fld_id.Text)


        End If
        CLEAR_FIELDS()
        FillLV()

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class
