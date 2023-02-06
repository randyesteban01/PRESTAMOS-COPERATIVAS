Imports  MySql.Data.MySqlClient
Public Class FRM_POPUP_TIPO_INGRESOS_CAJA
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
    Friend WithEvents lvwCust As System.Windows.Forms.ListView
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_POPUP_TIPO_INGRESOS_CAJA))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.lvwCust = New System.Windows.Forms.ListView
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.lvwCust)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.txtBuscar.Location = New System.Drawing.Point(8, 16)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(327, 20)
        Me.txtBuscar.TabIndex = 0
        Me.txtBuscar.Text = ""
        '
        'lvwCust
        '
        Me.lvwCust.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCust.BackColor = System.Drawing.Color.LightYellow
        Me.lvwCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwCust.GridLines = True
        Me.lvwCust.Location = New System.Drawing.Point(8, 40)
        Me.lvwCust.MultiSelect = False
        Me.lvwCust.Name = "lvwCust"
        Me.lvwCust.Size = New System.Drawing.Size(327, 144)
        Me.lvwCust.TabIndex = 9
        Me.lvwCust.View = System.Windows.Forms.View.Details
        '
        'FRM_POPUP_TIPO_INGRESOS_CAJA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(346, 192)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_POPUP_TIPO_INGRESOS_CAJA"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UNIDADES"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRM_POPUP_TIPO_INGRESOS_CAJA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.BackColor = Color.FromArgb(colorr(0), colorr(1), colorr(2))
        FillListView()
    End Sub


    '/SUBPROGRAMAS
    Public Sub FillListView()
        lvwCust.Clear()
        lvwCust.View = View.Details
        lvwCust.LabelEdit = False
        lvwCust.FullRowSelect = True
        lvwCust.GridLines = True
        lvwCust.Sorting = SortOrder.Ascending

        Dim fldToSearch As String = "fldDescripcion"
        Dim strTosearch As String = "'" & txtBuscar.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short

        If strTosearch <> "" Then
            sqlSearch = "SELECT fldId, fldDescripcion FROM tbl_Unidades WHERE " & fldToSearch & " LIKE " & strTosearch & ""
        Else
            sqlSearch = "SELECT fldId, fldDescripcion FROM tbl_Unidades"
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
            lvwColumn.Width = 238
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
                        itmListItem.SubItems.Add(dReader.GetValue(shtCntr))
                    End If
                Next shtCntr


                lvwCust.Items.Add(itmListItem)
            Loop

            ocmd.Connection.Close()
        Catch oException As Exception
            MessageBox.Show(oException.Message)
        End Try

        If txtBuscar.Text <> "" And accion = 2 Then
            lvwCust.Items(0).Selected = True
            lvwCust.Select()
        End If

    End Sub

    '/KEY PRESS FIELDS
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Enter Then
            If txtBuscar.Text <> "" Then
                FillListView()
            Else
                lvwCust.Items(0).Selected = True
                lvwCust.Select()
            End If
        End If
    End Sub

    '/PROPIEDADES LISTVIEW
    Private Sub lvwCust_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvwCust.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Enter Then
            Id = lvwCust.FocusedItem.Text
            Me.Close()
        End If
    End Sub
    Private Sub lvwCust_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwCust.DoubleClick
        Id = lvwCust.FocusedItem.Text
        Me.Close()
    End Sub



    Private Sub FRM_POPUP_TIPO_INGRESOS_CAJA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = vbCr Then 'BIGIN /DESABLED THE BEEP
            e.Handled = True
        End If 'END /DESABLED THE BEEP

        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub
End Class
