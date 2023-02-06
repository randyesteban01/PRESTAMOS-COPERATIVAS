Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class FRM_SELECCIONAR_DOC_TRANSITOS
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        If conn.State = ConnectionState.Open Then
            conn.Close()

        End If
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_marcar_como_llegado As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fld_doc_transito As System.Windows.Forms.RadioButton
    Friend WithEvents fld_doc_pagados As System.Windows.Forms.RadioButton
    Friend WithEvents fld_dep As System.Windows.Forms.RadioButton
    Friend WithEvents fld_ck As System.Windows.Forms.RadioButton
    Friend WithEvents fld_id_banco As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_SELECCIONAR_DOC_TRANSITOS))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.fld_dep = New System.Windows.Forms.RadioButton
        Me.fld_ck = New System.Windows.Forms.RadioButton
        Me.fld_id_banco = New System.Windows.Forms.TextBox
        Me.fld_doc_pagados = New System.Windows.Forms.RadioButton
        Me.fld_doc_transito = New System.Windows.Forms.RadioButton
        Me.Button3 = New System.Windows.Forms.Button
        Me.btn_marcar_como_llegado = New System.Windows.Forms.Button
        Me.LV = New System.Windows.Forms.ListView
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.lblStatus = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnAnular = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.fld_id_banco)
        Me.GroupBox1.Controls.Add(Me.fld_doc_pagados)
        Me.GroupBox1.Controls.Add(Me.fld_doc_transito)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btn_marcar_como_llegado)
        Me.GroupBox1.Controls.Add(Me.LV)
        Me.GroupBox1.Controls.Add(Me.txtdescription)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.btnCerrar)
        Me.GroupBox1.Controls.Add(Me.btnAnular)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(4, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 395)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Location = New System.Drawing.Point(432, 312)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(160, 80)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccionar Todos"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(8, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 56)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Si"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(80, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 56)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "&No"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.fld_dep)
        Me.GroupBox2.Controls.Add(Me.fld_ck)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 48)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'fld_dep
        '
        Me.fld_dep.Location = New System.Drawing.Point(8, 26)
        Me.fld_dep.Name = "fld_dep"
        Me.fld_dep.Size = New System.Drawing.Size(88, 16)
        Me.fld_dep.TabIndex = 14
        Me.fld_dep.Text = "Dépositos"
        '
        'fld_ck
        '
        Me.fld_ck.Location = New System.Drawing.Point(8, 10)
        Me.fld_ck.Name = "fld_ck"
        Me.fld_ck.Size = New System.Drawing.Size(88, 16)
        Me.fld_ck.TabIndex = 13
        Me.fld_ck.Text = "Cheques"
        '
        'fld_id_banco
        '
        Me.fld_id_banco.Location = New System.Drawing.Point(400, 72)
        Me.fld_id_banco.Name = "fld_id_banco"
        Me.fld_id_banco.TabIndex = 15
        Me.fld_id_banco.Text = "0"
        Me.fld_id_banco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_id_banco.Visible = False
        '
        'fld_doc_pagados
        '
        Me.fld_doc_pagados.Location = New System.Drawing.Point(127, 76)
        Me.fld_doc_pagados.Name = "fld_doc_pagados"
        Me.fld_doc_pagados.Size = New System.Drawing.Size(144, 16)
        Me.fld_doc_pagados.TabIndex = 12
        Me.fld_doc_pagados.Text = "Documentos pagados"
        '
        'fld_doc_transito
        '
        Me.fld_doc_transito.Location = New System.Drawing.Point(127, 60)
        Me.fld_doc_transito.Name = "fld_doc_transito"
        Me.fld_doc_transito.Size = New System.Drawing.Size(144, 16)
        Me.fld_doc_transito.TabIndex = 11
        Me.fld_doc_transito.Text = "Documentos en transito"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(152, 320)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 56)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Marcar como Transito"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_marcar_como_llegado
        '
        Me.btn_marcar_como_llegado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_marcar_como_llegado.ForeColor = System.Drawing.Color.Black
        Me.btn_marcar_como_llegado.Image = CType(resources.GetObject("btn_marcar_como_llegado.Image"), System.Drawing.Image)
        Me.btn_marcar_como_llegado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_marcar_como_llegado.Location = New System.Drawing.Point(16, 320)
        Me.btn_marcar_como_llegado.Name = "btn_marcar_como_llegado"
        Me.btn_marcar_como_llegado.Size = New System.Drawing.Size(131, 56)
        Me.btn_marcar_como_llegado.TabIndex = 9
        Me.btn_marcar_como_llegado.Text = "Marcar como Pagado"
        Me.btn_marcar_como_llegado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.LV.CheckBoxes = True
        Me.LV.Location = New System.Drawing.Point(13, 104)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(584, 208)
        Me.LV.TabIndex = 1
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.Color.White
        Me.txtdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescription.Location = New System.Drawing.Point(13, 16)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(584, 20)
        Me.txtdescription.TabIndex = 0
        Me.txtdescription.Text = ""
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Location = New System.Drawing.Point(16, 248)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 23)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "&NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(360, 256)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 16)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Label1"
        Me.lblStatus.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(271, 248)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 23)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "&CERRAR"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnAnular
        '
        Me.btnAnular.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnular.ForeColor = System.Drawing.Color.Black
        Me.btnAnular.Location = New System.Drawing.Point(186, 248)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(72, 23)
        Me.btnAnular.TabIndex = 3
        Me.btnAnular.Text = "&ANULAR"
        Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(101, 248)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 23)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "&GUARDAR"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FRM_SELECCIONAR_DOC_TRANSITOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(618, 412)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_SELECCIONAR_DOC_TRANSITOS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcando documento que llegaron"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim CurrentId As String

    Private Sub FRM_SELECCIONAR_DOC_TRANSITOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Icon = appIcon  
    End Sub

    Private Sub FRM_SELECCIONAR_DOC_TRANSITOS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

#Region "ALL SUB"

    Private Sub FillLV_ck()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.None


        Dim fldToSearch As String = "fld_concepto"
        Dim strTosearch As String = "'" & txtdescription.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short, estado As String
        If fld_doc_pagados.Checked = True Then
            estado = "NO"
        End If
        If fld_doc_transito.Checked = True Then
            estado = "SI"
        End If


        If strTosearch <> "" Then
            sqlSearch = "SELECT fld_id_doc, fld_ck_no, fld_fecha, fld_concepto, fld_monto FROM tbl_cheques WHERE " & fldToSearch & " LIKE " & strTosearch & " AND  fld_transito='" & estado & "' AND fld_ck_no > 0 AND fld_id_banco='" & fld_id_banco.Text & "' ORDER BY fld_ck_no ASC"
        Else
            sqlSearch = "SELECT fld_id_doc, fld_ck_no, fld_fecha, fld_concepto, fld_monto FROM tbl_cheques WHERE fld_transito='" & estado & "' AND fld_ck_no > 0 AND fld_id_banco='" & fld_id_banco.Text & "' ORDER BY fld_ck_no ASC"
        End If

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_cheques")


        Dim columnText(5) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "ID"
        columnText(1) = "CK No."
        columnText(2) = "FECHA"
        columnText(3) = "CONCEPTO"
        columnText(4) = "MONTO"

        Dim columnWidth(5) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 20
        columnWidth(1) = 60
        columnWidth(2) = 85
        columnWidth(3) = 310
        columnWidth(4) = 85

        Dim columnAlign(5) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 0 'DERECHA
        columnAlign(4) = 1 'DERECHA


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
                    str(col) = Format(rr(col), "C2")
                End If
            Next

            Dim ii As New ListViewItem(str)
            LV.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub
    Private Sub FillLV_dep()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.None


        Dim fldToSearch As String = "fld_descripcion"
        Dim strTosearch As String = "'" & txtdescription.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short, estado As String
        If fld_doc_pagados.Checked = True Then
            estado = "NO"
        End If
        If fld_doc_transito.Checked = True Then
            estado = "SI"
        End If


        If strTosearch <> "" Then
            sqlSearch = "SELECT fld_id_doc,  fld_fecha, fld_descripcion, fld_monto FROM tbl_deposito WHERE " & fldToSearch & " LIKE " & strTosearch & " AND  fld_transito='" & estado & "' AND fld_id_banco='" & fld_id_banco.Text & "' ORDER BY fld_fecha ASC"
        Else
            sqlSearch = "SELECT fld_id_doc,  fld_fecha, fld_descripcion, fld_monto FROM tbl_deposito WHERE fld_transito='" & estado & "' AND fld_id_banco='" & fld_id_banco.Text & "' ORDER BY fld_fecha ASC"
        End If

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_deposito")


        Dim columnText(5) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "ID"
        columnText(1) = "FECHA"
        columnText(2) = "CONCEPTO"
        columnText(3) = "MONTO"
        columnText(4) = "MONTO"

        Dim columnWidth(5) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 20
        columnWidth(1) = 60
        columnWidth(2) = 400
        columnWidth(3) = 85
        columnWidth(4) = 0

        Dim columnAlign(5) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 0 'DERECHA
        columnAlign(4) = 1 'DERECHA


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
                    str(col) = Format(rr(col), "C2")
                End If
            Next

            Dim ii As New ListViewItem(str)
            LV.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub

    Private Sub marcar_pagado()
        If Alerta("¿Seguro que desea continuar?") = True Then
            For Each lvitem As ListViewItem In Me.LV.Items
                If lvitem.Checked = True Then

                    If fld_ck.Checked = True Then
                        MARCAR_DOC("tbl_cheques", lvitem.Text, "NO")
                    Else
                        MARCAR_DOC("tbl_deposito", lvitem.Text, "NO")
                    End If

                End If
            Next
        End If
    End Sub
    Private Sub marcar_transito()
        If Alerta("¿Seguro que desea continuar?") = True Then
            For Each lvitem As ListViewItem In Me.LV.Items
                If lvitem.Checked = True Then
                    If fld_ck.Checked = True Then
                        MARCAR_DOC("tbl_cheques", lvitem.Text, "SI")
                    Else
                        MARCAR_DOC("tbl_deposito", lvitem.Text, "SI")
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub seleccionar_todo()
        For Each lvitem As ListViewItem In Me.LV.Items
            ' If lvitem.Checked = False Then
            lvitem.Checked = True
            'Else
            '   lvitem.Checked = False
            'End If
        Next

    End Sub
    Private Sub seleccionar_todo_no()
        For Each lvitem As ListViewItem In Me.LV.Items
            ' If lvitem.Checked = False Then
            lvitem.Checked = False
            'Else
            '   lvitem.Checked = False
            'End If
        Next

    End Sub

    Private Sub MARCAR_DOC(ByVal TABLA As String, ByVal IDS As String, ByVal estado As String)
        NON_QUERY("UPDATE " & TABLA & " SET fld_transito='" & estado & "' WHERE fld_id_doc =" & IDS & "")
    End Sub

#End Region

    Private Sub txtdescription_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescription.KeyPress
        If fld_ck.Checked = True Then
            FillLV_ck()
        Else
            FillLV_dep()
        End If

        If e.KeyChar = Chr(13) Then
            LV.Focus() 'LoadData(CurrentId)
        End If
    End Sub





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        seleccionar_todo()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        seleccionar_todo_no()
    End Sub

    Private Sub btn_marcar_como_llegado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_marcar_como_llegado.Click
        marcar_pagado()
        If fld_ck.Checked = True Then
            FillLV_ck()
        Else
            FillLV_dep()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        marcar_transito()
        If fld_ck.Checked = True Then
            FillLV_ck()
        Else
            FillLV_dep()
        End If
    End Sub

    Private Sub fld_doc_pagados_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fld_doc_pagados.CheckedChanged
        If fld_ck.Checked = True Then
            FillLV_ck()
        Else
            FillLV_dep()
        End If
    End Sub

    Private Sub fld_doc_transito_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fld_doc_transito.CheckedChanged
        If fld_ck.Checked = True Then
            FillLV_ck()
        Else
            FillLV_dep()
        End If
    End Sub

    Private Sub fld_ck_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fld_ck.CheckedChanged
        If fld_ck.Checked = True Then
            FillLV_ck()
        Else
            FillLV_dep()
        End If
    End Sub


End Class
