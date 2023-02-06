Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class FRM_LIST_NOTA_CREDITO
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
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_LIST_NOTA_CREDITO))
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.LV = New System.Windows.Forms.ListView
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(704, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 56)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Cerrar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seleccione un documento y pulse la tecla ( P ) para ReImprimir"
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.White
        Me.LV.Location = New System.Drawing.Point(8, 32)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(768, 192)
        Me.LV.TabIndex = 1
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.Color.White
        Me.txtdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescription.Location = New System.Drawing.Point(112, 8)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(664, 20)
        Me.txtdescription.TabIndex = 0
        Me.txtdescription.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Barra de Búsqueda :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FRM_LIST_NOTA_CREDITO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(786, 291)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_LIST_NOTA_CREDITO"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Nota de Crédito"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim CurrentId As String, tabla As String

    Private Sub FRM_LIST_NOTA_CREDITO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillLV()
    End Sub

    Private Sub FRM_LIST_NOTA_CREDITO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub

#Region "ALL SUB"

    Private Sub FillLV()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV.Clear()
        LV.View = System.Windows.Forms.View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.Ascending


        Dim fldToSearch As String
        Dim strTosearch As String = "'%" & txtdescription.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short


        fldToSearch = "fld_FullName"


        tabla = "view_cxc_nota_credito"


        If strTosearch <> "" Then
            sqlSearch = "SELECT fld_id_nc_cxc, fld_fecha, fld_FullName, fld_concepto, fld_monto FROM " & tabla & " WHERE " & fldToSearch & " LIKE " & strTosearch & ""
        Else
            sqlSearch = "SELECT fld_id_nc_cxc, fld_fecha, fld_FullName, fld_concepto, fld_monto FROM " & tabla & ""
        End If

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "view_cxc_nota_credito")


        Dim columnText(6) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "NC No."
        columnText(1) = "Fecha"
        columnText(2) = "Cliente"
        columnText(3) = "Concepto"
        columnText(4) = "Monto"
        columnText(5) = ""

        Dim columnWidth(6) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 85
        columnWidth(1) = 85
        columnWidth(2) = 230
        columnWidth(3) = 260
        columnWidth(4) = 85
        columnWidth(5) = 85

        Dim columnAlign(6) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 0 'DERECHA
        columnAlign(4) = 1 'IZQUIERDA
        columnAlign(5) = 1 'DERECHA



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
                ElseIf rr(col).GetType().FullName.ToString = "System.Int" Then
                    str(col) = Format(rr(col), "00000")
                ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                    str(col) = Format(rr(col), "dd/MMM/yy")
                ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                    str(col) = rr(col).ToString()
                ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                    str(col) = Format(rr(col), "C2")
                ElseIf rr(col).GetType().FullName.ToString = "System.Decimal" Then
                    str(col) = Format(rr(col), "C2")
                End If
            Next

            Dim ii As New ListViewItem(str)
            LV.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub

#End Region

    Private Sub txtdescription_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescription.KeyPress
        If e.KeyChar = Chr(13) Then
            FillLV()
            'LV.Focus() 'LoadData(CurrentId)
        End If
    End Sub

    Private Sub LV_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LV.KeyPress
        If e.KeyChar = Chr(13) Then
            Id = LV.FocusedItem.Text

        End If
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        Id = LV.FocusedItem.Text

    End Sub

    Private Sub cboSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub
    Private WithEvents docToPrint As New Printing.PrintDocument

    Private Sub LV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.P Then
            PrintDialog1.AllowSomePages = True


            PrintDialog1.ShowHelp = True

            PrintDialog1.Document = docToPrint


            Dim result As DialogResult = PrintDialog1.ShowDialog()

            'If the result is OK then print the document.
            If (result = Windows.Forms.DialogResult.OK) Then
                PRINT_DOCUMENTO_NCCXC(LV.FocusedItem.Text, PrintDialog1.PrinterSettings.PrinterName)
            End If



        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
