Imports  MySql.Data.MySqlClient
Public Class FRM_TIPO_INGRESOS_CAJA
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents btnGuarda As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBusca As System.Windows.Forms.Button
    Friend WithEvents btnCierra As System.Windows.Forms.Button
    Friend WithEvents bntBorra As System.Windows.Forms.Button
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_TIPO_INGRESOS_CAJA))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnBusca = New System.Windows.Forms.Button
        Me.btnCierra = New System.Windows.Forms.Button
        Me.bntBorra = New System.Windows.Forms.Button
        Me.btnNueva = New System.Windows.Forms.Button
        Me.btnGuarda = New System.Windows.Forms.Button
        Me.TxtDescription = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBusca)
        Me.GroupBox1.Controls.Add(Me.TxtDescription)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 88)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.Color.FromArgb(CType(183, Byte), CType(219, Byte), CType(255, Byte))
        Me.btnBusca.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBusca.ForeColor = System.Drawing.Color.Black
        Me.btnBusca.Location = New System.Drawing.Point(9, 8)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(96, 24)
        Me.btnBusca.TabIndex = 8
        Me.btnBusca.Text = "&Lista Unidades"
        '
        'btnCierra
        '
        Me.btnCierra.BackColor = System.Drawing.Color.FromArgb(CType(183, Byte), CType(219, Byte), CType(255, Byte))
        Me.btnCierra.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCierra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCierra.ForeColor = System.Drawing.Color.Black
        Me.btnCierra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierra.ImageIndex = 3
        Me.btnCierra.ImageList = Me.ImageList1
        Me.btnCierra.Location = New System.Drawing.Point(272, 144)
        Me.btnCierra.Name = "btnCierra"
        Me.btnCierra.Size = New System.Drawing.Size(72, 40)
        Me.btnCierra.TabIndex = 7
        Me.btnCierra.Text = "&Cerrar"
        Me.btnCierra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'bntBorra
        '
        Me.bntBorra.BackColor = System.Drawing.Color.FromArgb(CType(183, Byte), CType(219, Byte), CType(255, Byte))
        Me.bntBorra.Cursor = System.Windows.Forms.Cursors.Default
        Me.bntBorra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bntBorra.ForeColor = System.Drawing.Color.Black
        Me.bntBorra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bntBorra.ImageIndex = 5
        Me.bntBorra.ImageList = Me.ImageList1
        Me.bntBorra.Location = New System.Drawing.Point(184, 144)
        Me.bntBorra.Name = "bntBorra"
        Me.bntBorra.Size = New System.Drawing.Size(72, 40)
        Me.bntBorra.TabIndex = 6
        Me.bntBorra.Text = "&Borrar"
        Me.bntBorra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNueva
        '
        Me.btnNueva.BackColor = System.Drawing.Color.FromArgb(CType(183, Byte), CType(219, Byte), CType(255, Byte))
        Me.btnNueva.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNueva.ForeColor = System.Drawing.Color.Black
        Me.btnNueva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNueva.ImageIndex = 6
        Me.btnNueva.ImageList = Me.ImageList1
        Me.btnNueva.Location = New System.Drawing.Point(3, 144)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(72, 40)
        Me.btnNueva.TabIndex = 5
        Me.btnNueva.Text = "&Nueva"
        Me.btnNueva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuarda
        '
        Me.btnGuarda.BackColor = System.Drawing.Color.FromArgb(CType(183, Byte), CType(219, Byte), CType(255, Byte))
        Me.btnGuarda.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGuarda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuarda.ForeColor = System.Drawing.Color.Black
        Me.btnGuarda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuarda.ImageIndex = 0
        Me.btnGuarda.ImageList = Me.ImageList1
        Me.btnGuarda.Location = New System.Drawing.Point(96, 144)
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(72, 40)
        Me.btnGuarda.TabIndex = 4
        Me.btnGuarda.Text = "&Guardar"
        Me.btnGuarda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TxtDescription
        '
        Me.TxtDescription.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescription.ForeColor = System.Drawing.Color.Black
        Me.TxtDescription.Location = New System.Drawing.Point(9, 56)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(296, 20)
        Me.TxtDescription.TabIndex = 0
        Me.TxtDescription.Text = ""
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtId.ForeColor = System.Drawing.Color.Black
        Me.txtId.Location = New System.Drawing.Point(272, 24)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(28, 20)
        Me.txtId.TabIndex = 2
        Me.txtId.Text = ""
        Me.txtId.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Descripción"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(346, 136)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(338, 107)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "www.softwaremc.com / 809.256.3210"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FRM_TIPO_INGRESOS_CAJA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(346, 192)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCierra)
        Me.Controls.Add(Me.bntBorra)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.btnGuarda)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_TIPO_INGRESOS_CAJA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Unidades"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '/FROM'S PROPETIES 
    Private Sub FRM_TIPO_INGRESOS_CAJA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.BackColor = Color.FromArgb(colorr(0), colorr(1), colorr(2))
    End Sub
    Private Sub FRM_TIPO_INGRESOS_CAJA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub
    Private Sub FRM_TIPO_INGRESOS_CAJA_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    End Sub

    '/SUBPROGRAMAS
    Private Sub Pausa()
        Dim i As Integer
        For i = 1 To 100
            Application.DoEvents()
        Next
    End Sub
    Private Sub Save()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim dr As DataRow

        da = New MySqlDataAdapter("SELECT * FROM tbl_Unidades", conn)
        da.Fill(ds, "tbl_Unidades")

        dr = ds.Tables("tbl_Unidades").NewRow
        dr("fldDescripcion") = TxtDescription.Text
        ds.Tables("tbl_Unidades").Rows.Add(dr)



        Dim cmd As New MySqlCommandBuilder(da)

        conn.Open()
        da.InsertCommand = cmd.GetInsertCommand
        da.Update(ds, "tbl_Unidades")
        ds.AcceptChanges()
        conn.Close()

        ds.Dispose()
        da.Dispose()
    End Sub
    Private Sub Delete()
        Dim idloan = txtId.Text



        Dim oleDA As MySqlDataAdapter = New MySqlDataAdapter
        Dim SQL As String


        SQL = "DELETE * FROM tbl_Unidades WHERE fldID=" & idloan & ""
        oleDA.SelectCommand = New MySqlCommand(SQL, conn)
        conn.Open()
        oleDA.SelectCommand.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub Modifica()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim dr As DataRow

        da = New MySqlDataAdapter("SELECT * FROM tbl_Unidades", conn)
        da.Fill(ds, "tbl_Unidades")


        With ds.Tables("tbl_Unidades") 'Cuando usamo el metodo find debemos manualmente esp. el primarykey
            .PrimaryKey = New DataColumn() {.Columns("fldId")}
        End With

        dr = ds.Tables("tbl_Unidades").Rows.Find(txtId.Text)

        If Not (dr Is Nothing) Then
            dr("fldDescripcion") = TxtDescription.Text
        End If


        Dim cmd As New MySqlCommandBuilder(da)

        conn.Open()

        da.UpdateCommand = cmd.GetUpdateCommand
        da.Update(ds, "tbl_Unidades")
        ds.AcceptChanges()


        conn.Close()
    End Sub
    Private Sub Search(ByVal id As String)
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter

        If id Is Nothing Then Exit Sub



        Dim dr As DataRow

        da = New MySqlDataAdapter("SELECT * FROM tbl_Unidades", conn)
        da.Fill(ds, "tbl_Unidades")

        With ds.Tables("tbl_Unidades") 'Cuando usamo el metodo find debemos manualmente esp. el primarykey
            .PrimaryKey = New DataColumn() {.Columns("fldId")}
        End With

        dr = ds.Tables("tbl_Unidades").Rows.Find(id)

        If Not (dr Is Nothing) Then
            txtId.Text = Format(dr("fldId"), "0000")
            TxtDescription.Text = dr("fldDescripcion")
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
    End Sub


    '/BOTONES
    Private Sub btnGuarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuarda.Click
        If Isnewdoc = True Then
            Save()
            txtId.Text = Format(loadLastInvoiceID("tbl_Unidades", "fldId"), "0000")
        Else
            Modifica()
        End If

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
        Dim ask = MessageBox.Show("¿Seguro que desea borrar esta unidad?", "Borrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ask = DialogResult.Yes Then
            Pausa()
            Delete()
            Isnewdoc = True
            Cls_Fields()
        End If
    End Sub
    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        Id = Nothing
        Dim Busca As New FrmSearch_Unidades
        Busca.ShowInTaskbar = False
        Busca.ShowDialog()
        Pausa()
        Search(Id)
        Id = Nothing
    End Sub

    '/FIELD KEY PRESS
    Private Sub txtId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtId.Text = "" Then
                Id = Nothing
                Dim Busca As New FrmSearch_Unidades
                Busca.ShowInTaskbar = False
                Busca.ShowDialog()
                MessageBox.Show(Id)
                Pausa()
                Search(Id)
                Id = Nothing
            Else
                Search(txtId.Text)
            End If
        End If
    End Sub


End Class
