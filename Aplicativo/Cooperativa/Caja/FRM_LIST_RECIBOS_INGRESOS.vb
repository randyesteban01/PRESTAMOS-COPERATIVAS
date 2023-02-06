Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing
Public Class FRM_LIST_RECIBOS_INGRESOS
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
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_LIST_RECIBOS_INGRESOS))
        Me.LV = New System.Windows.Forms.ListView()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.White
        Me.LV.Location = New System.Drawing.Point(10, 37)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(921, 341)
        Me.LV.TabIndex = 1
        Me.LV.UseCompatibleStateImageBehavior = False
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.Color.White
        Me.txtdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescription.Location = New System.Drawing.Point(10, 9)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(921, 22)
        Me.txtdescription.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(556, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione un documento y pulse la tecla ( P ) para ReImprimir"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(556, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seleccione un documento y pulse la tecla ( DELETE ) para Anular"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(950, 65)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(240, 22)
        Me.dtpFecha.TabIndex = 17
        Me.dtpFecha.Visible = False
        '
        'FRM_LIST_RECIBOS_INGRESOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(939, 417)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.txtdescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_LIST_RECIBOS_INGRESOS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de recibos de ingresos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim CurrentId As String, tabla As String

    Private Sub ActualizaCuotas(ByVal IdRecibo As Integer)
        'Actuliza las Cuotas a su estado anterior al pago que se está anulando
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_recibo_ingresos_cxc_detalle WHERE fld_id_ri_padre=" & IdRecibo & "", conn)
        da.Fill(ds, "tbl_recibo_ingresos_cxc_detalle")
        Dim dr As DataRow

        For Each dr In ds.Tables(0).Rows
            NON_QUERY("UPDATE tbl_cuotas SET fld_abono_cuotas=fld_abono_cuotas-(" & dr("fld_ult_abono_interes") + dr("fld_ult_abono_capital") & "), fld_interes_cuota_abono=fld_interes_cuota_abono-" & dr("fld_ult_abono_interes") & ", fld_capital_cuota_abono=fld_capital_cuota_abono-" & dr("fld_ult_abono_capital") & ", fld_balance_cuotas=fld_monto_cuotas-fld_abono_cuotas, fld_interes_cuota_balance=fld_interes_cuota-fld_interes_cuota_abono, fld_capital_cuota_balance = fld_capital_cuota - fld_capital_cuota_abono WHERE fld_id_cuotas=" & dr("fld_cuota_id") & "")
        Next
        ds.Dispose()
        da.Dispose()

    End Sub

    Private Sub FRM_LIST_RECIBOS_INGRESOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        dtpFecha.Value = SCALAR_STRING("SELECT DATE(Now())")
        FillLV()
    End Sub

    Private Sub FRM_LIST_RECIBOS_INGRESOS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

#Region "ALL SUB"

    Public Sub FillLV()

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


        tabla = "view_ri_cxc"


        If strTosearch <> "'%%'" Then
            sqlSearch = "SELECT fld_id_RI, fld_date, fld_FullName, fld_concepto, fld_monto FROM " & tabla & " WHERE " & fldToSearch & " LIKE " & strTosearch & " AND fld_monto > 0"
        Else
            sqlSearch = "SELECT fld_id_RI, fld_date, fld_FullName, fld_concepto, fld_monto FROM " & tabla & " WHERE fld_monto > 0"
        End If

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "view_orden_compra")


        Dim columnText(6) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "R.I. No."
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

    Private Sub txtdescription_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescription.KeyPress
        If e.KeyChar = Chr(13) Then
            FillLV()
            'LV.Focus() 'LoadData(CurrentId)
        End If
    End Sub

    Private Sub LV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LV.KeyPress
        If e.KeyChar = Chr(13) Then
            Id = LV.FocusedItem.Text

        End If
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        Id = LV.FocusedItem.Text

    End Sub

    Private Sub cboSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub
    Private WithEvents docToPrint As New Printing.PrintDocument


    Private Sub LV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.P Then
            If CBool(SCALAR_NUM("SELECT VistaPreviaImpresion FROM parametrosgenerales WHERE ID=1")) = True Then
                Id = CInt(LV.FocusedItem.Text)
                AllReportSinFecha("Recibo Ingreso")
                Me.Close()
            Else
                PrintDialog1.AllowSomePages = True
                PrintDialog1.ShowHelp = True
                PrintDialog1.Document = docToPrint

                Dim pd As New PrintDocument, strOldPrinter As String
                strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print 

                Dim WshNetwork As Object
                WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")

                Dim TamañoPersonal As Printing.PaperSize

                Dim result As DialogResult = PrintDialog1.ShowDialog()

                'If the result is OK then print the document.
                If (result = Windows.Forms.DialogResult.OK) Then
                    'TamañoPersonal = New Printing.PaperSize(PrintDialog1.PrinterSettings.PrinterName, 850, 550)
                    'PrintDialog1.PrinterSettings.DefaultPageSettings.PaperSize = TamañoPersonal
                    WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName) 'Set the Default Print
                    PRINT_DOCUMENTO_RI(LV.FocusedItem.Text, PrintDialog1.PrinterSettings.PrinterName)
                End If

                WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print

            End If

        ElseIf e.KeyCode = Keys.Delete Then

            If FRMS_CLAVE_MAESTRA("Borrar") = True Then
                ID_RI = LV.FocusedItem.Text
                Concepto_anulacion.ShowDialog()
                FillLV()
            End If

        End If
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class
