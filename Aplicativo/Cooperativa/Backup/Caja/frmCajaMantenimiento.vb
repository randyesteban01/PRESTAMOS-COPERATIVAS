Imports MySql.Data.MySqlClient
Public Class frmCajaMantenimiento
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents fld_id As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BTN_GUARDA As System.Windows.Forms.Button
    Friend WithEvents buscaCtaContableBtn As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DescripcionTxt As System.Windows.Forms.TextBox
    Friend WithEvents CtaContableTxt As System.Windows.Forms.TextBox
    Friend WithEvents lblCuentaContable As System.Windows.Forms.Label
    Friend WithEvents cbPredeterminada As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCajaMantenimiento))
        Me.DescripcionTxt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LV = New System.Windows.Forms.ListView
        Me.fld_id = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BTN_GUARDA = New System.Windows.Forms.Button
        Me.buscaCtaContableBtn = New System.Windows.Forms.Button
        Me.CtaContableTxt = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblCuentaContable = New System.Windows.Forms.Label
        Me.cbPredeterminada = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'DescripcionTxt
        '
        Me.DescripcionTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescripcionTxt.Location = New System.Drawing.Point(96, 8)
        Me.DescripcionTxt.MaxLength = 100
        Me.DescripcionTxt.Name = "DescripcionTxt"
        Me.DescripcionTxt.Size = New System.Drawing.Size(272, 20)
        Me.DescripcionTxt.TabIndex = 0
        Me.DescripcionTxt.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(-8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LV
        '
        Me.LV.Location = New System.Drawing.Point(8, 72)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(354, 224)
        Me.LV.TabIndex = 10
        '
        'fld_id
        '
        Me.fld_id.Location = New System.Drawing.Point(312, 56)
        Me.fld_id.Name = "fld_id"
        Me.fld_id.Size = New System.Drawing.Size(22, 20)
        Me.fld_id.TabIndex = 9
        Me.fld_id.Text = "0"
        Me.fld_id.Visible = False
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
        Me.Button2.Location = New System.Drawing.Point(144, 305)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 56)
        Me.Button2.TabIndex = 3
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
        Me.BtnCancelar.Location = New System.Drawing.Point(288, 305)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(72, 56)
        Me.BtnCancelar.TabIndex = 4
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
        Me.BTN_GUARDA.Location = New System.Drawing.Point(216, 305)
        Me.BTN_GUARDA.Name = "BTN_GUARDA"
        Me.BTN_GUARDA.Size = New System.Drawing.Size(72, 56)
        Me.BTN_GUARDA.TabIndex = 2
        Me.BTN_GUARDA.Text = "&Guardar"
        Me.BTN_GUARDA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'buscaCtaContableBtn
        '
        Me.buscaCtaContableBtn.Image = CType(resources.GetObject("buscaCtaContableBtn.Image"), System.Drawing.Image)
        Me.buscaCtaContableBtn.Location = New System.Drawing.Point(200, 31)
        Me.buscaCtaContableBtn.Name = "buscaCtaContableBtn"
        Me.buscaCtaContableBtn.Size = New System.Drawing.Size(24, 23)
        Me.buscaCtaContableBtn.TabIndex = 1
        '
        'CtaContableTxt
        '
        Me.CtaContableTxt.BackColor = System.Drawing.Color.White
        Me.CtaContableTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CtaContableTxt.Location = New System.Drawing.Point(96, 32)
        Me.CtaContableTxt.Name = "CtaContableTxt"
        Me.CtaContableTxt.ReadOnly = True
        Me.CtaContableTxt.Size = New System.Drawing.Size(104, 20)
        Me.CtaContableTxt.TabIndex = 7
        Me.CtaContableTxt.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(-32, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Cuenta Contable"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCuentaContable
        '
        Me.lblCuentaContable.Location = New System.Drawing.Point(96, 56)
        Me.lblCuentaContable.Name = "lblCuentaContable"
        Me.lblCuentaContable.Size = New System.Drawing.Size(272, 16)
        Me.lblCuentaContable.TabIndex = 8
        Me.lblCuentaContable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbPredeterminada
        '
        Me.cbPredeterminada.Location = New System.Drawing.Point(256, 34)
        Me.cbPredeterminada.Name = "cbPredeterminada"
        Me.cbPredeterminada.Size = New System.Drawing.Size(104, 16)
        Me.cbPredeterminada.TabIndex = 11
        Me.cbPredeterminada.Text = "Predeterminada"
        '
        'frmCajaMantenimiento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(378, 364)
        Me.Controls.Add(Me.cbPredeterminada)
        Me.Controls.Add(Me.lblCuentaContable)
        Me.Controls.Add(Me.DescripcionTxt)
        Me.Controls.Add(Me.buscaCtaContableBtn)
        Me.Controls.Add(Me.CtaContableTxt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BTN_GUARDA)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fld_id)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCajaMantenimiento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Caja"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCajaMantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        limpiarDatos()
        FillLV()

    End Sub

    Private Sub frmCajaMantenimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
   

    Private Sub guardarDatos()
        Dim Orden As Integer = 0
        If cbPredeterminada.Checked = True Then
            Orden = -1
        End If
        NON_QUERY("INSERT INTO cajamantenimiento(Descripcion, CtaContable, Orden) VALUES('" & DescripcionTxt.Text & "','" & CtaContableTxt.Text & "'," & Orden & ")")

    End Sub
    Private Sub actualizarDatos(ByVal idDoc As Integer)
        Dim Orden As Integer = 0
        If cbPredeterminada.Checked = True Then
            Orden = -1
        End If
        NON_QUERY("UPDATE cajamantenimiento SET  Descripcion = '" & DescripcionTxt.Text & "', CtaContable = '" & CtaContableTxt.Text & "', Orden=" & Orden & " WHERE id=" & idDoc & "")

    End Sub
    Private Sub buscarDatos(ByVal idDoc As Integer)
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT * FROM cajamantenimiento WHERE ID=" & idDoc & ""
            dr = .ExecuteReader()

        End With
        If dr.Read() Then
            fld_id.Text = idDoc
            If dr("Orden") = 0 Then
                cbPredeterminada.Checked = False
            Else
                cbPredeterminada.Checked = True
            End If
            DescripcionTxt.Text = dr("Descripcion")
            CtaContableTxt.Text = dr("CtaContable")

            BTN_GUARDA.Text = "&Modificar"
        End If
            cmd.Connection.Close()
            cmd.Dispose()
    End Sub

    Private Sub limpiarDatos()
        fld_id.Text = 0

        DescripcionTxt.Text = ""
        CtaContableTxt.Text = ""
        BTN_GUARDA.Text = "&Guardar"
        cbPredeterminada.Checked = False
    End Sub
    Private Function validarDatos() As Boolean
        If Trim(DescripcionTxt.Text) = "" Then
            Alerta("Debe escribir la descripción")
            DescripcionTxt.Focus()
            Return False
        ElseIf Trim(CtaContableTxt.Text) = "" Then
            Alerta("Debe seleccionar la Cta. contable")
            DescripcionTxt.Focus()
            Return False
        ElseIf cbPredeterminada.Checked = True Then

            If SCALAR_NUM("SELECT IFNULL(1,0) FROM cajamantenimiento WHERE Orden=-1") = 1 Then
                Alerta("Ya existe una caja predeterminada")
                DescripcionTxt.Focus()
                Return False
            End If
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


        Dim fldToSearch As String = "Descripcion" ' = cboSearch.Text
        Dim strTosearch As String = "'%" & DescripcionTxt.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short

        If strTosearch <> "" Then
            sqlSearch = "SELECT Id,  Descripcion, CtaContable, Orden FROM cajamantenimiento  WHERE " & fldToSearch & " LIKE " & strTosearch & " "
        Else
            sqlSearch = "SELECT Id,  Descripcion, CtaContable, Orden FROM cajamantenimiento  WHERE cm.IdTipoTrans=tt.fld_id"
        End If

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "cajamantenimiento")


        Dim columnText(4) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "CODIGO"
        columnText(1) = "Descripción"
        columnText(2) = "Cta. Contable"


        Dim columnWidth(4) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 250
        columnWidth(2) = 90



        Dim columnAlign(4) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA




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


            Dim i As Integer

            For i = 0 To LV.Items.Count - 1

                'MessageBox.Show(CDbl(Me.lv.Items(i).SubItems(7).Text))
                If CDbl(Me.LV.Items(i).SubItems(3).Text) < 0 Then
                    LV.Items.Item(i).BackColor = System.Drawing.Color.LimeGreen
                    LV.Items.Item(i).ForeColor = System.Drawing.Color.White

                End If

            Next i
        Next


    End Sub

    Private Sub Descripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DescripcionTxt.KeyPress
        'If e.KeyChar = Chr(13) Then
        '    If validarDatos() = False Then Exit Sub
        '    If BTN_GUARDA.Text = "&Guardar" Then
        '        guardarDatos()
        '    Else
        '        actualizarDatos(fld_id.Text)
        '    End If
        '    FillLV()
        '    limpiarDatos()
        'End If

    End Sub

    Private Sub LV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.Enter Then
            buscarDatos(LV.FocusedItem.Text)
        End If
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        buscarDatos(LV.FocusedItem.Text)
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        limpiarDatos()
    End Sub

    Private Sub BTN_GUARDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GUARDA.Click
        If validarDatos() = False Then Return
        If BTN_GUARDA.Text = "&Guardar" Then

            guardarDatos()

        Else
            actualizarDatos(fld_id.Text)


        End If
        limpiarDatos()
        FillLV()

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub buscaCtaContableBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscaCtaContableBtn.Click
        If frmsListaCatalogoCuentaContable() = True Then
            CtaContableTxt.Text = Id
            lblCuentaContable.Text = ReturnDescripcion(Id)
        End If
    End Sub
End Class
