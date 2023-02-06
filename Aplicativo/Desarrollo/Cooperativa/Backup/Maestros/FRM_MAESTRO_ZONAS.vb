Imports  MySql.Data.MySqlClient

Public Class FRM_MAESTRO_ZONAS
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
    Friend WithEvents btnCierra As System.Windows.Forms.Button
    Friend WithEvents bntBorra As System.Windows.Forms.Button
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents btnGuarda As System.Windows.Forms.Button
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lvwCust As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmdCobrador As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_MAESTRO_ZONAS))
        Me.lvwCust = New System.Windows.Forms.ListView
        Me.btnCierra = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bntBorra = New System.Windows.Forms.Button
        Me.btnNueva = New System.Windows.Forms.Button
        Me.btnGuarda = New System.Windows.Forms.Button
        Me.TxtDescription = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdCobrador = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lvwCust
        '
        Me.lvwCust.BackColor = System.Drawing.Color.White
        Me.lvwCust.Location = New System.Drawing.Point(8, 56)
        Me.lvwCust.Name = "lvwCust"
        Me.lvwCust.Size = New System.Drawing.Size(552, 160)
        Me.lvwCust.TabIndex = 6
        '
        'btnCierra
        '
        Me.btnCierra.BackColor = System.Drawing.SystemColors.Control
        Me.btnCierra.ForeColor = System.Drawing.Color.Black
        Me.btnCierra.Image = CType(resources.GetObject("btnCierra.Image"), System.Drawing.Image)
        Me.btnCierra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierra.Location = New System.Drawing.Point(224, 224)
        Me.btnCierra.Name = "btnCierra"
        Me.btnCierra.Size = New System.Drawing.Size(72, 56)
        Me.btnCierra.TabIndex = 5
        Me.btnCierra.Text = "&Cerrar"
        Me.btnCierra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'bntBorra
        '
        Me.bntBorra.BackColor = System.Drawing.SystemColors.Control
        Me.bntBorra.Enabled = False
        Me.bntBorra.ForeColor = System.Drawing.Color.Black
        Me.bntBorra.Image = CType(resources.GetObject("bntBorra.Image"), System.Drawing.Image)
        Me.bntBorra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bntBorra.Location = New System.Drawing.Point(152, 224)
        Me.bntBorra.Name = "bntBorra"
        Me.bntBorra.Size = New System.Drawing.Size(72, 56)
        Me.bntBorra.TabIndex = 4
        Me.bntBorra.Text = "&Borrar"
        Me.bntBorra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNueva
        '
        Me.btnNueva.BackColor = System.Drawing.SystemColors.Control
        Me.btnNueva.ForeColor = System.Drawing.Color.Black
        Me.btnNueva.Image = CType(resources.GetObject("btnNueva.Image"), System.Drawing.Image)
        Me.btnNueva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNueva.Location = New System.Drawing.Point(8, 224)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(72, 56)
        Me.btnNueva.TabIndex = 3
        Me.btnNueva.Text = "&Nueva"
        Me.btnNueva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuarda
        '
        Me.btnGuarda.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuarda.ForeColor = System.Drawing.Color.Black
        Me.btnGuarda.Image = CType(resources.GetObject("btnGuarda.Image"), System.Drawing.Image)
        Me.btnGuarda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuarda.Location = New System.Drawing.Point(80, 224)
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(72, 56)
        Me.btnGuarda.TabIndex = 2
        Me.btnGuarda.Text = "&Guardar"
        Me.btnGuarda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TxtDescription
        '
        Me.TxtDescription.BackColor = System.Drawing.Color.White
        Me.TxtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescription.ForeColor = System.Drawing.Color.Black
        Me.TxtDescription.Location = New System.Drawing.Point(8, 32)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(296, 20)
        Me.TxtDescription.TabIndex = 0
        Me.TxtDescription.Text = ""
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.ForeColor = System.Drawing.Color.Black
        Me.txtId.Location = New System.Drawing.Point(200, 8)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(64, 20)
        Me.txtId.TabIndex = 8
        Me.txtId.Text = ""
        Me.txtId.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descripción"
        '
        'cmdCobrador
        '
        Me.cmdCobrador.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.cmdCobrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdCobrador.ForeColor = System.Drawing.Color.White
        Me.cmdCobrador.Location = New System.Drawing.Point(312, 32)
        Me.cmdCobrador.Name = "cmdCobrador"
        Me.cmdCobrador.Size = New System.Drawing.Size(248, 21)
        Me.cmdCobrador.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(312, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cobrador"
        '
        'FRM_MAESTRO_ZONAS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(578, 283)
        Me.Controls.Add(Me.btnGuarda)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.bntBorra)
        Me.Controls.Add(Me.btnCierra)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCobrador)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lvwCust)
        Me.Controls.Add(Me.TxtDescription)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_MAESTRO_ZONAS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de  CARTERA"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRM_MAESTRO_ZONAS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    '/SUBPROGRAMAS

    Private Sub Guardar()
        NON_QUERY("INSERT INTO tbl_maestro_zonas (fldDescripcion, fldIdCobrador) VALUES	('" & TxtDescription.Text & "'," & cmdCobrador.SelectedValue & ")")
    End Sub

    Private Sub Borrar(ByVal IdDoc As Integer)
        NON_QUERY("DELETE FROM tbl_maestro_zonas WHERE fldID=" & IdDoc & "")
    End Sub

    Private Sub Modificar(ByVal IdDoc As Integer)
        NON_QUERY("UPDATE tbl_maestro_zonas SET fldDescripcion='" & TxtDescription.Text & "', fldIdCobrador=" & cmdCobrador.SelectedValue & " WHERE fldId=" & IdDoc & "")
    End Sub

    Private Sub Buscar(ByVal idDoc As Integer)
        Dim ds As New DataSet
        Dim dr As DataRow

        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_maestro_zonas WHERE fldId=" & idDoc & "", conn)
        da.Fill(ds, "tbl_maestro_zonas")

        For Each dr In ds.Tables(0).Rows
            txtId.Text = Format(dr("fldId"), "0000")
            TxtDescription.Text = dr("fldDescripcion")
            cmdCobrador.SelectedValue = dr("fldIdCobrador")
            btnGuarda.Text = "&Modificar"
            bntBorra.Enabled = True
        Next

        ds.Clear()
        ds.Dispose()
        da.Dispose()
        conn.Close()
    End Sub
    Private Sub Cls_Fields()
        btnGuarda.Text = "&Guardar"
        txtId.Text = "0"
        TxtDescription.Text = ""
        bntBorra.Enabled = False
        FillListView()
    End Sub

    Private Sub LlenarCobradores()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT ID, Descripcion FROM tbl_maestro_cobrador ORDER BY Descripcion", conn)
        da.Fill(dt)

        cmdCobrador.DataSource = dt
        cmdCobrador.DisplayMember = "Descripcion"
        cmdCobrador.ValueMember = "ID"

        da.Dispose()
    End Sub
    Public Sub FillListView()
        lvwCust.Clear()
        lvwCust.View = View.Details
        lvwCust.LabelEdit = False
        lvwCust.FullRowSelect = True
        lvwCust.GridLines = True
        lvwCust.Sorting = SortOrder.None

        Dim fldToSearch As String = "z.fldDescripcion"
        Dim strTosearch As String = "'%" & TxtDescription.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short

        If strTosearch <> "" Then
            sqlSearch = "SELECT z.fldId, z.fldDescripcion  FROM tbl_maestro_zonas as z WHERE  " & fldToSearch & " LIKE " & strTosearch & " ORDER BY z.fldDescripcion"
        Else
            sqlSearch = "SELECT z.fldId, z.fldDescripcion FROM tbl_maestro_zonas as z ORDER BY z.fldDescripcion"
        End If

        Try
            Dim ocmd As MySqlCommand
            ocmd = New MySqlCommand
            Dim dReader As MySqlDataReader

            With ocmd
                .Connection = conn
                .Connection.Open()
                .CommandText = sqlSearch
                dReader = .ExecuteReader
            End With

            Dim lvwColumn As ColumnHeader
            Dim shtCntr As Short

            lvwColumn = New ColumnHeader
            lvwColumn.Text = "Código"
            lvwColumn.Width = 50
            lvwCust.Columns.Add(lvwColumn)

            lvwColumn = New ColumnHeader
            lvwColumn.Text = "Descripción"
            lvwColumn.Width = 450
            lvwCust.Columns.Add(lvwColumn)



            Dim itmListItem As ListViewItem

            accion = 1
            Do While dReader.Read
                accion = 2
                itmListItem = New ListViewItem
                itmListItem.Text = dReader(0)

                For shtCntr = 1 To dReader.FieldCount() - 1
                    If dReader.IsDBNull(shtCntr) Then
                        itmListItem.SubItems.Add("")
                    Else
                        itmListItem.SubItems.Add(dReader.GetString(shtCntr))
                    End If
                Next shtCntr


                lvwCust.Items.Add(itmListItem)
            Loop

            ocmd.Connection.Close()
        Catch oException As Exception
            Alerta(oException.Message)
        End Try

        If TxtDescription.Text <> "" And accion = 2 Then
            lvwCust.Items(0).Selected = True
            lvwCust.Select()
        End If

    End Sub


    '/BOTONES
    Private Sub btnGuarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuarda.Click
        If btnGuarda.Text = "&Guardar" Then
            Guardar()
        Else
            Modificar(txtId.Text)
        End If
        Cls_Fields()

    End Sub
    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click

        Cls_Fields()

    End Sub
    Private Sub btnCierra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierra.Click
        Me.Close()
    End Sub
    Private Sub bntBorra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntBorra.Click

        If Alerta("¿Seguro que desea borrar esta unidad?") = True Then

            Borrar(txtId.Text)
            Cls_Fields()
        End If
    End Sub


    '/FIELD KEY PRESS



    Private Sub FRM_MAESTRO_ZONAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarCobradores()
        FillListView()
    End Sub

    Private Sub lvwCust_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvwCust.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Enter Then
            Buscar(lvwCust.FocusedItem.Text)
        End If
    End Sub
    Private Sub lvwCust_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwCust.DoubleClick
        Buscar(lvwCust.FocusedItem.Text)
    End Sub

    Private Sub TxtDescription_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescription.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Enter Then
            If TxtDescription.Text <> "" Then
                FillListView()
            Else
                lvwCust.Items(0).Selected = True
                lvwCust.Select()
            End If
        End If
    End Sub


    Private Sub FRM_MAESTRO_ZONAS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    

    Private Sub cmdCobrador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmdCobrador.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
