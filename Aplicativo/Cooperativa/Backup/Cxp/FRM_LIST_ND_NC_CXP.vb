Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing
Public Class FRM_LIST_ND_NC_CXP
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
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_LIST_ND_NC_CXP))
        Me.LV = New System.Windows.Forms.ListView
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(0, 32)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(635, 208)
        Me.LV.TabIndex = 1
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(112, 8)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(520, 20)
        Me.txtBuscar.TabIndex = 0
        Me.txtBuscar.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Seleccione un documento y pulse la tecla ( P ) para ReImprimir"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Barra de Búsqueda :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FRM_LIST_ND_NC_CXP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(642, 275)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_LIST_ND_NC_CXP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NC / ND CxC"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter




    '/PROPIEDADES DEL FORM
    Private Sub FRM_LIST_ND_NC_CXP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillListView()
    End Sub
    Private Sub FRM_LIST_ND_NC_CXP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub PRINT_DOC_NC(ByVal id_doc As Integer)


        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        PrintDialog1.Document = docToPrint

        Dim pd As New PrintDocument, strOldPrinter As String
        strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print 

        Dim WshNetwork As Object
        WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
        WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName) 'Set the Default Print 

        Dim result As DialogResult = PrintDialog1.ShowDialog()



        ' If the result is OK then print the document.
        If (result = Windows.Forms.DialogResult.OK) Then
            Dim ds As New DataSet

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")


            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_nota_credito_cxp WHERE fld_id=" & id_doc & "", conn)
            daP1.Fill(ds, "view_nota_credito_cxp")

            Dim dr As DataRow
            For Each dr In ds.Tables(1).Rows
                Dim largo = Len(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")))
                Dim decimales = Mid(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")), largo - 2)

                dr("fld_banco") = Num2Text(dr("fld_monto") - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
            Next


            Dim Report As New RPT_NC_CXP
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, 0, 0)
         

        End If


        WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print

    End Sub
    Private Sub PRINT_DOC_ND(ByVal id_doc As Integer)


        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        PrintDialog1.Document = docToPrint

        Dim pd As New PrintDocument, strOldPrinter As String
        strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print 

        Dim WshNetwork As Object
        WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
        WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName) 'Set the Default Print 

        Dim result As DialogResult = PrintDialog1.ShowDialog()



        ' If the result is OK then print the document.
        If (result = Windows.Forms.DialogResult.OK) Then
            Dim ds As New DataSet

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")


            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_nota_debito_cxp WHERE fld_id=" & id_doc & "", conn)
            daP1.Fill(ds, "view_nota_debito_cxp")

            Dim dr As DataRow
            For Each dr In ds.Tables(1).Rows
                Dim largo = Len(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")))
                Dim decimales = Mid(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")), largo - 2)

                dr("fld_banco") = Num2Text(dr("fld_monto") - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
            Next

                Dim Report As New RPT_ND_CXP
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
                Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, 0, 0)
 

        End If


        WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print

    End Sub

    '/SUB PROGRAMAS

    Private Sub FillListView()
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.Ascending

        Dim fldToSearch As String = "fldCompany"



        Dim strTosearch As String = "'%" & txtBuscar.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short
        Trim(strTosearch)

        If Me.Text = "Lista de Nota de Débito CXP" Then
            If strTosearch <> "" Then

                sqlSearch = "SELECT fld_id, fld_fecha, fld_concepto, fldCompany, fld_monto FROM view_nota_debito_cxp WHERE " & fldToSearch & " LIKE " & strTosearch & ""
            Else
                sqlSearch = "SELECT fld_id, fld_fecha, fld_concepto, fldCompany, fld_monto FROM view_nota_debito_cxp"

            End If


            ds.Reset()
            da = New MySqlDataAdapter(sqlSearch, conn)
            da.Fill(ds, "view_nota_debito_cxp")

            Dim columnText(6) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
            columnText(0) = "COD."
            columnText(1) = "FECHA"
            columnText(2) = "CONCEPTO"
            columnText(3) = "PROVEEDOR"
            columnText(4) = "MONTO"

            Dim columnWidth(6) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
            columnWidth(0) = 40
            columnWidth(1) = 75
            columnWidth(2) = 230
            columnWidth(3) = 170
            columnWidth(4) = 85


            Dim columnAlign(6) As Int32 'PARA ALINEAR LOS DATOS
            columnAlign(0) = 0 'IZQUIERDA
            columnAlign(1) = 0 'IZQUIERDA
            columnAlign(2) = 0 'IZQUIERDA
            columnAlign(3) = 0 'IZQUIERDA
            columnAlign(4) = 1 'IZQUIERDA

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
            Dim str(Me.ds.Tables(0).Columns.Count) As String
            'adding Datarows as listview Grids
            Dim rr As DataRow



            For Each rr In dt.Rows

                For col As Integer = 0 To Me.ds.Tables(0).Columns.Count - 1
                    '/FORMATEAMO LOS DATOS DE ACUERDO A SU FORMATO, ESTO SE HACE POR CADA COLUMNA QUE EXISTA
                    If rr(col).GetType().FullName.ToString = "System.Int32" Then
                        str(col) = Format(rr(col), "00000")
                    ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                        str(col) = Format(rr(col), "d")
                    ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                        str(col) = rr(col).ToString()
                    ElseIf rr(col).GetType().FullName.ToString = "System.Decimal" Then
                        str(col) = Format(rr(col), "C2")
                    ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                        str(col) = Format(rr(col), "C2")
                    End If
                Next

                Dim ii As New ListViewItem(str)
                Me.LV.Items.Add(ii)
                'showing the number of records still added
            Next
        ElseIf Me.Text = "Lista de Nota de Crédito CXP" Then

            If strTosearch <> "" Then

                sqlSearch = "SELECT fld_id, fld_fecha, fld_concepto, fldCompany, fld_monto, fld_abono, fld_balance FROM view_nota_credito_cxp WHERE " & fldToSearch & " LIKE " & strTosearch & ""
            Else
                sqlSearch = "SELECT fld_id, fld_fecha, fld_concepto, fldCompany, fld_monto, fld_abono, fld_balance FROM view_nota_credito_cxp"

            End If

            ds.Reset()
            da = New MySqlDataAdapter(sqlSearch, conn)
            da.Fill(ds, "view_nota_credito_cxp")



            Dim columnText(7) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
            columnText(0) = "COD."
            columnText(1) = "FECHA"
            columnText(2) = "CONCEPTO"
            columnText(3) = "PROVEEDOR"
            columnText(4) = "MONTO"
            columnText(5) = "ABONO"
            columnText(6) = "BALANCE"

            Dim columnWidth(7) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
            columnWidth(0) = 40
            columnWidth(1) = 75
            columnWidth(2) = 145
            columnWidth(3) = 85
            columnWidth(4) = 85
            columnWidth(5) = 85
            columnWidth(6) = 85

            Dim columnAlign(7) As Int32 'PARA ALINEAR LOS DATOS
            columnAlign(0) = 0 'IZQUIERDA
            columnAlign(1) = 0 'IZQUIERDA
            columnAlign(2) = 0 'IZQUIERDA
            columnAlign(3) = 0 'IZQUIERDA
            columnAlign(4) = 1 'IZQUIERDA
            columnAlign(5) = 1 'IZQUIERDA
            columnAlign(6) = 1 'IZQUIERDA
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
            Dim str(Me.ds.Tables(0).Columns.Count) As String
            'adding Datarows as listview Grids
            Dim rr As DataRow



            For Each rr In dt.Rows

                For col As Integer = 0 To Me.ds.Tables(0).Columns.Count - 1
                    '/FORMATEAMO LOS DATOS DE ACUERDO A SU FORMATO, ESTO SE HACE POR CADA COLUMNA QUE EXISTA
                    If rr(col).GetType().FullName.ToString = "System.Int32" Then
                        str(col) = Format(rr(col), "00000")
                    ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                        str(col) = Format(rr(col), "d")
                    ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                        str(col) = rr(col).ToString()
                    ElseIf rr(col).GetType().FullName.ToString = "System.Decimal" Then
                        str(col) = Format(rr(col), "C2")
                    ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                        str(col) = Format(rr(col), "C2")
                    End If
                Next

                Dim ii As New ListViewItem(str)
                Me.LV.Items.Add(ii)
                'showing the number of records still added
            Next
        End If





    End Sub

    '/KEY PRESS FIELDS
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Enter Then
            If txtBuscar.Text <> "" Then
                FillListView()
            Else
                LV.Items(0).Selected = True
                LV.Select()
            End If
        End If
    End Sub

    '/PROPIEDADES LISTVIEW
    Private Sub LV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LV.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Enter Then
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

    Private Sub txtBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        FillListView()
    End Sub


    Private Sub LV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown

        If e.KeyCode = Keys.P Then
            If LV.Focus = True Then
                Dim id_proveedor As Double
                If Me.Text = "Lista de Nota de Débito CXP" Then
                    PRINT_DOC_ND(LV.FocusedItem.Text)
                Else
                    PRINT_DOC_NC(LV.FocusedItem.Text)
                End If
            End If
        End If

    End Sub

End Class
