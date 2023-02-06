Imports  MySql.Data.MySqlClient

Public Class FRM_MAESTRO_VENDEDORES
    Inherits System.Windows.Forms.Form
    Dim Isnewdoc As Boolean = True
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_MAESTRO_VENDEDORES))
        Me.lvwCust = New System.Windows.Forms.ListView
        Me.btnCierra = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bntBorra = New System.Windows.Forms.Button
        Me.btnNueva = New System.Windows.Forms.Button
        Me.btnGuarda = New System.Windows.Forms.Button
        Me.TxtDescription = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lvwCust
        '
        Me.lvwCust.BackColor = System.Drawing.Color.White
        Me.lvwCust.Location = New System.Drawing.Point(8, 48)
        Me.lvwCust.Name = "lvwCust"
        Me.lvwCust.Size = New System.Drawing.Size(496, 184)
        Me.lvwCust.TabIndex = 5
        '
        'btnCierra
        '
        Me.btnCierra.BackColor = System.Drawing.SystemColors.Control
        Me.btnCierra.ForeColor = System.Drawing.Color.Black
        Me.btnCierra.Image = CType(resources.GetObject("btnCierra.Image"), System.Drawing.Image)
        Me.btnCierra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierra.Location = New System.Drawing.Point(224, 240)
        Me.btnCierra.Name = "btnCierra"
        Me.btnCierra.Size = New System.Drawing.Size(72, 56)
        Me.btnCierra.TabIndex = 4
        Me.btnCierra.Text = "&Cierra"
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
        Me.bntBorra.ForeColor = System.Drawing.Color.Black
        Me.bntBorra.Image = CType(resources.GetObject("bntBorra.Image"), System.Drawing.Image)
        Me.bntBorra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bntBorra.Location = New System.Drawing.Point(152, 240)
        Me.bntBorra.Name = "bntBorra"
        Me.bntBorra.Size = New System.Drawing.Size(72, 56)
        Me.bntBorra.TabIndex = 3
        Me.bntBorra.Text = "&Borra"
        Me.bntBorra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNueva
        '
        Me.btnNueva.BackColor = System.Drawing.SystemColors.Control
        Me.btnNueva.ForeColor = System.Drawing.Color.Black
        Me.btnNueva.Image = CType(resources.GetObject("btnNueva.Image"), System.Drawing.Image)
        Me.btnNueva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNueva.Location = New System.Drawing.Point(8, 240)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(72, 56)
        Me.btnNueva.TabIndex = 2
        Me.btnNueva.Text = "&Nueva"
        Me.btnNueva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuarda
        '
        Me.btnGuarda.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuarda.ForeColor = System.Drawing.Color.Black
        Me.btnGuarda.Image = CType(resources.GetObject("btnGuarda.Image"), System.Drawing.Image)
        Me.btnGuarda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuarda.Location = New System.Drawing.Point(80, 240)
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(72, 56)
        Me.btnGuarda.TabIndex = 1
        Me.btnGuarda.Text = "&Guarda"
        Me.btnGuarda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TxtDescription
        '
        Me.TxtDescription.BackColor = System.Drawing.Color.White
        Me.TxtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescription.ForeColor = System.Drawing.Color.Black
        Me.TxtDescription.Location = New System.Drawing.Point(8, 24)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(496, 20)
        Me.TxtDescription.TabIndex = 0
        Me.TxtDescription.Text = ""
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.ForeColor = System.Drawing.Color.Black
        Me.txtId.Location = New System.Drawing.Point(224, 64)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(64, 20)
        Me.txtId.TabIndex = 7
        Me.txtId.Text = ""
        Me.txtId.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre completo"
        '
        'FRM_MAESTRO_VENDEDORES
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(514, 299)
        Me.Controls.Add(Me.btnCierra)
        Me.Controls.Add(Me.bntBorra)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.btnGuarda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.lvwCust)
        Me.Controls.Add(Me.txtId)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_MAESTRO_VENDEDORES"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Cobradores"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FRM_MAESTRO_VENDEDORES_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    '/SUBPROGRAMAS

    Private Sub Save()
       
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim dr As DataRow

        da = New MySqlDataAdapter("SELECT * FROM tbl_maestro_cobrador", conn)
        da.Fill(ds, "tbl_maestro_cobrador")

        dr = ds.Tables("tbl_maestro_cobrador").NewRow
        dr("Descripcion") = TxtDescription.Text

        ds.Tables("tbl_maestro_cobrador").Rows.Add(dr)



        Dim cmd As New MySqlCommandBuilder(da)

        conn.Open()

        da.InsertCommand = cmd.GetInsertCommand
        da.Update(ds, "tbl_maestro_cobrador")
        ds.AcceptChanges()


        conn.Close()
    End Sub
    Private Sub Delete()
        Dim idloan = txtId.Text



        Dim oleDA As MySqlDataAdapter = New MySqlDataAdapter
        Dim SQL As String

        SQL = "DELETE FROM tbl_maestro_cobrador WHERE ID=" & idloan & ""
        oleDA.SelectCommand = New MySqlCommand(SQL, conn)
        conn.Open()
        oleDA.SelectCommand.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub Modifica()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim dr As DataRow

        da = New MySqlDataAdapter("SELECT * FROM tbl_maestro_cobrador", conn)
        da.Fill(ds, "tbl_maestro_cobrador")


        With ds.Tables("tbl_maestro_cobrador") 'Cuando usamo el metodo find debemos manualmente esp. el primarykey
            .PrimaryKey = New DataColumn() {.Columns("ID")}
        End With

        dr = ds.Tables("tbl_maestro_cobrador").Rows.Find(txtId.Text)

        If Not (dr Is Nothing) Then
            dr("Descripcion") = TxtDescription.Text
        End If


        Dim cmd As New MySqlCommandBuilder(da)

        conn.Open()

        da.UpdateCommand = cmd.GetUpdateCommand
        da.Update(ds, "tbl_maestro_cobrador")
        ds.AcceptChanges()


        conn.Close()
    End Sub
    Private Sub Search(ByVal id As String)
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter

        If id Is Nothing Then Exit Sub



        Dim dr As DataRow

        da = New MySqlDataAdapter("SELECT * FROM tbl_maestro_cobrador", conn)
        da.Fill(ds, "tbl_maestro_cobrador")

        With ds.Tables("tbl_maestro_cobrador") 'Cuando usamo el metodo find debemos manualmente esp. el primarykey
            .PrimaryKey = New DataColumn() {.Columns("ID")}
        End With

        dr = ds.Tables("tbl_maestro_cobrador").Rows.Find(id)

        If Not (dr Is Nothing) Then
            txtId.Text = Format(dr("ID"), "0000")
            TxtDescription.Text = dr("Descripcion")
            TxtDescription.Focus()
            Isnewdoc = False
        End If
        ds.Clear()
        ds.Dispose()
        da.Dispose()

        conn.Close()
    End Sub
    Private Sub Cls_Fields()
        txtId.Text = ""
        TxtDescription.Text = ""
        FillListView()

    End Sub
    Private Function valida_data() As Boolean
        If Trim(TxtDescription.Text) = "" Then
            Alerta("Debe registrar el nombre")
            TxtDescription.Focus()
            Return False

        End If
        Return True
    End Function
    Public Sub FillListView()
        lvwCust.Clear()
        lvwCust.View = View.Details
        lvwCust.LabelEdit = False
        lvwCust.FullRowSelect = True
        lvwCust.GridLines = True
        lvwCust.Sorting = SortOrder.Ascending

        Dim fldToSearch As String = "Descripcion"
        Dim strTosearch As String = "'" & TxtDescription.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short

        If strTosearch <> "" Then
            sqlSearch = "SELECT ID, Descripcion FROM tbl_maestro_cobrador WHERE " & fldToSearch & " LIKE " & strTosearch & ""
        Else
            sqlSearch = "SELECT ID, Descripcion  FROM tbl_maestro_cobrador"
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
            lvwColumn.Width = 0
            lvwCust.Columns.Add(lvwColumn)

            lvwColumn = New ColumnHeader
            lvwColumn.Text = "Descripción"
            lvwColumn.Width = 472
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

        If valida_data() = False Then Exit Sub

        If Isnewdoc = True Then
            Save()
            txtId.Text = Format(UltimoID("tbl_maestro_cobrador", "ID"), "0000")
            Alerta("Documento guardado")
        Else

            Modifica()
            Alerta("Documento modificado")
        End If
        Cls_Fields()
        Id = Nothing
    End Sub
    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        Isnewdoc = True
        Cls_Fields()
        Id = Nothing
    End Sub
    Private Sub btnCierra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierra.Click
        Me.Close()
    End Sub
    Private Sub bntBorra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntBorra.Click

        If Alerta("¿Seguro que desea borrar esta unidad?") = True Then

            Delete()
            Isnewdoc = True
            Cls_Fields()
        End If
    End Sub





    Private Sub FRM_MAESTRO_VENDEDORES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillListView()
    End Sub

    Private Sub lvwCust_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvwCust.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Enter Then
            Search(lvwCust.FocusedItem.Text)

        End If
    End Sub
    Private Sub lvwCust_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwCust.DoubleClick
        Search(lvwCust.FocusedItem.Text)
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



    Private Sub fldCodZona_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FRM_MAESTRO_VENDEDORES_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
