Imports  MySql.Data.MySqlClient
Public Class frmListaCatalogoCuentaContable
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
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmListaCatalogoCuentaContable))
        Me.LV = New System.Windows.Forms.ListView
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.White
        Me.LV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LV.Location = New System.Drawing.Point(0, 35)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(746, 368)
        Me.LV.TabIndex = 2
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.Color.White
        Me.txtdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescription.Location = New System.Drawing.Point(120, 8)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(624, 20)
        Me.txtdescription.TabIndex = 1
        Me.txtdescription.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barra de Búsqueda :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmListaCatalogoCuentaContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(746, 403)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListaCatalogoCuentaContable"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Cuenta"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim CurrentId As String

    Private Sub frmListaCatalogoCuentaContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillLV()
    End Sub

    Private Sub frmListaCatalogoCuentaContable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

#Region "ALL SUB"




    Private Sub FillLV()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.None


        Dim fldToSearch As String = "c.Descripcion" ' = cboSearch.Text
        Dim strTosearch As String = "'%" & txtdescription.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short



        If strTosearch <> "" Then
            sqlSearch = "SELECT c.CuentaNo, c.Descripcion, cg.Descripcion FROM tbl_catalogo AS c, tbl_catalogo_grupo AS cg WHERE c.Grupo=cg.ID AND c.Tipo='Auxiliar' AND " & fldToSearch & " LIKE " & strTosearch & " ORDER BY c.CuentaNo"
        Else
            sqlSearch = "SELECT c.CuentaNo, c.Descripcion, cg.Descripcion FROM tbl_catalogo AS c, tbl_catalogo_grupo AS cg WHERE c.Grupo=cg.ID AND c.Tipo='Auxiliar' ORDER BY c.CuentaNo"
        End If

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_catalogo")


        Dim columnText(5) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "Cuenta No."
        columnText(1) = "Descripción"
        columnText(2) = "Grupo"


        Dim columnWidth(5) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 125
        columnWidth(1) = 480
        columnWidth(2) = 128


        Dim columnAlign(5) As Int32 'PARA ALINEAR LOS DATOS
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
        Next


    End Sub

#End Region

    Private Sub txtdescription_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescription.KeyPress
        FillLV()
        If e.KeyChar = Chr(13) Then
            LV.Focus() 'LoadData(CurrentId)
        End If
    End Sub

    Private Sub LV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LV.KeyPress
        If e.KeyChar = Chr(13) Then
            Id = LV.FocusedItem.Text
            Me.Text = "ACEPTAR"
            Me.Close()
        End If
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        Id = LV.FocusedItem.Text
        Me.Text = "ACEPTAR"
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
