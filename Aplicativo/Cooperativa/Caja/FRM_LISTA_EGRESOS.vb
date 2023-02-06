Imports MySql.Data.MySqlClient

Public Class FRM_LISTA_EGRESOS
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_LISTA_EGRESOS))
        Me.LV = New System.Windows.Forms.ListView
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.White
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(8, 32)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(768, 304)
        Me.LV.TabIndex = 1
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(8, 8)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(768, 20)
        Me.txtBuscar.TabIndex = 0
        Me.txtBuscar.Text = ""
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(8, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "- Oprimiendo la tecla ( P ) : ReImprime el documento"
        '
        'FRM_LISTA_EGRESOS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(786, 364)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_LISTA_EGRESOS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Egresos de Caja"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter


    '/PROPIEDADES DEL FORM
    Private Sub FRM_LISTA_EGRESOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillListView()
    End Sub
    Private Sub FRM_LISTA_EGRESOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
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

        Dim fldToSearch As String = "CONCAT(fldConcepto,' ',fldEntregado)"



        Dim strTosearch As String = "'%" & Trim(txtBuscar.Text) & "%'"
        Dim sqlSearch As String
        Dim accion As Short
        Trim(strTosearch)
        Try
         
                
            If strTosearch <> "'%%'" Then
                sqlSearch = "SELECT fldIdDoc, fldFecha, fldMonto, fldConcepto, fldEntregado  FROM tbl_recibo_egresos WHERE " & fldToSearch & " LIKE " & strTosearch & " "
            Else
                sqlSearch = "SELECT fldIdDoc, fldFecha, fldMonto, fldConcepto, fldEntregado fldMonto FROM tbl_recibo_egresos"

            End If




            ds.Reset()
            da = New MySqlDataAdapter(sqlSearch, conn)
            da.Fill(ds, "tbl_recibo_egresos")

            Dim columnText(7) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
            columnText(0) = "COD."
            columnText(1) = "FECHA"
            columnText(2) = "MONTO"
            columnText(3) = "CONCEPTO"
            columnText(4) = "ENTREGADO A:"
            columnText(5) = "BALANCE"


            Dim columnWidth(7) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
            columnWidth(0) = 40
            columnWidth(1) = 75
            columnWidth(2) = 100
            columnWidth(3) = 250
            columnWidth(4) = 200
            columnWidth(5) = 85


            Dim columnAlign(7) As Int32 'PARA ALINEAR LOS DATOS
            columnAlign(0) = 0 'IZQUIERDA
            columnAlign(1) = 0 'IZQUIERDA
            columnAlign(2) = 1 'IZQUIERDA
            columnAlign(3) = 0 'IZQUIERDA
            columnAlign(4) = 0 'IZQUIERDA
            columnAlign(5) = 0  'IZQUIERDA

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

        Catch ex As Exception
            Alerta(ex.Message)
        End Try



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
    

    Private Sub txtBuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        FillListView()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub LV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.P Then

            If CBool(SCALAR_NUM("SELECT VistaPreviaImpresion FROM parametrosgenerales WHERE ID=1")) = True Then
                Id = LV.FocusedItem.Text
                AllReportSinFecha("Recibo Egreso")
                Me.Close()
            Else
                ImprimirEgreso(LV.FocusedItem.Text)
            End If

        ElseIf e.KeyCode = Keys.Delete Then
            'If FRMS_CLAVE_MAESTRA("Acceso") = True Then
            '    'READER("SELECT fldTipo, fldIdTipo, fldMonto, fldConcepto FROM tbl_recibo_egresos WHERE fldIdDoc=" & LV.FocusedItem.Text & "")
            '    'Dim tipo As String = "", IdTipo As Integer, Monto As Double = 0, Concepto As String = ""
            '    'If reader_values.Length > 0 Then
            '    '    tipo = reader_values(0)
            '    '    IdTipo = reader_values(1)
            '    '    Monto = reader_values(2)
            '    '    Concepto = reader_values(3)
            '    'End If
            '    'If tipo = "CLIENTES" Then
            '    '    create_row_estado_cliente(IdTipo, Monto, "EGRESOS NULOS", LV.FocusedItem.Text, "(NULO) " + Concepto, SCALAR_STRING("SELECT DATE(Now())"))
            '    'ElseIf tipo = "PROVEEDORES" Then
            '    '    create_row_estado_proveedor(IdTipo, Monto, "EGRESOS NULOS", LV.FocusedItem.Text, "(NULO) " + Concepto, SCALAR_STRING("SELECT DATE(Now()"))
            '    'End If

            '    NON_QUERY("UPDATE tbl_recibo_egresos SET fldMonto=0 WHERE fldIdDoc=" & LV.FocusedItem.Text & "")
            '    FillListView()
            'End If

        End If
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub

    Private Sub FRM_LISTA_EGRESOS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        ImprimirEgreso(LV.FocusedItem.Text)
    End Sub
End Class
