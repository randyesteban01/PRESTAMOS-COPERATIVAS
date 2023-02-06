Imports  MySql.Data.MySqlClient
Public Class FRM_LIST_PRESTAMOS_CUOTAS
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
    Friend WithEvents lv As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_LIST_PRESTAMOS_CUOTAS))
        Me.lv = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.White
        Me.lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv.Location = New System.Drawing.Point(0, 0)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(778, 323)
        Me.lv.TabIndex = 8
        '
        'FRM_LIST_PRESTAMOS_CUOTAS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(778, 323)
        Me.Controls.Add(Me.lv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_LIST_PRESTAMOS_CUOTAS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Cuotas del préstamos"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Friend ID_DEL_PRESTAMOS As Integer

    '/PROPIEDADES DEL FORM
    Private Sub FRM_LIST_PRESTAMOS_CUOTAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillListView()
    End Sub
    Private Sub FRM_LIST_PRESTAMOS_CUOTAS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    '/SUBPROGRAMAS
    Public Sub FqqillListView()

        lv.Clear()
        lv.View = View.Details
        lv.LabelEdit = False
        lv.FullRowSelect = True
        lv.GridLines = True
        lv.Sorting = SortOrder.None

        Dim fldToSearch As String

        Dim sqlSearch As String
        Dim accion As Short


        sqlSearch = "SELECT fld_id_prestamos, fld_id, fld_FullName, fld_fecha_entrega, fld_fecha_termina, fld_capital_prestamo FROM view_prestamos_todos WHERE fld_balance > 0  ORDER BY fld_id ASC"



        Dim ds As New DataSet
        Dim da As MySqlDataAdapter

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "view_prestamos_todos")

        Dim columnText(7) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "Cód. P."
        columnText(1) = "Cód. C."
        columnText(2) = "Nombre"
        columnText(3) = "Entrega"
        columnText(4) = "Vence"
        columnText(5) = "Monto Prest."
        columnText(6) = ""


        Dim columnWidth(7) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 65
        columnWidth(1) = 70
        columnWidth(2) = 350
        columnWidth(3) = 70
        columnWidth(4) = 70
        columnWidth(5) = 100
        columnWidth(6) = 70

        Dim columnAlign(7) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 1 'DERECHA
        columnAlign(4) = 1 'IZQUIERDA
        columnAlign(5) = 1 'DERECHA
        columnAlign(6) = 1 'DERECHA



        Dim count = 0
        Dim c As DataColumn
        For Each c In ds.Tables(0).Columns
            'adding names of columns as Listview columns				
            Dim h As New ColumnHeader
            h.Text = columnText(count) ' c.ColumnName
            h.TextAlign = columnAlign(count)
            h.Width = columnWidth(count)
            Me.lv.Columns.Add(h)
            count += 1
        Next



        Dim dt As DataTable = ds.Tables(0)
        Dim str(ds.Tables(0).Columns.Count) As String
        'adding Datarows as listview Grids
        Dim rr As DataRow



        For Each rr In dt.Rows

            For col As Integer = 0 To ds.Tables(0).Columns.Count - 1
                accion = 2 '/FORMATEAMO LOS DATOS DE ACUERDO A SU FORMATO, ESTO SE HACE POR CADA COLUMNA QUE EXISTA
                If rr(col).GetType().FullName.ToString = "System.Int32" Then
                    str(col) = Format(rr(col), "00000")
                ElseIf rr(col).GetType().FullName.ToString = "System.UInt32" Then
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
                Else
                    str(col) = rr(col)
                End If
            Next

            Dim ii As New ListViewItem(str)
            lv.Items.Add(ii)

           
            'showing the number of records still added
        Next



    End Sub


    Private Sub FillListView()

        lv.Clear()
        lv.View = View.Details
        lv.LabelEdit = False
        lv.FullRowSelect = True
        lv.GridLines = True
        lv.Sorting = SortOrder.Ascending

        Dim fldToSearch As String
        Dim strTosearch As String
        Dim sqlSearch As String
        Dim accion As Short


        ' fld_fecha_entrega_cuotas,
        sqlSearch = "SELECT fld_id_cuotas, fld_no_cuotas, fld_fecha_termina_cuotas, fld_monto_cuotas, fld_pendiente_amortizar, fld_interes_cuota, fld_capital_cuota, fld_total_amortizado, fld_abono_cuotas, fld_balance_cuotas, fld_fecha_ultimo_abono_cuotas FROM tbl_cuotas WHERE fld_id_del_prestamo=" & ID_DEL_PRESTAMOS & ""

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_cuotas")

        Dim dr As DataRow
       

        Dim columnText(11) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = ""
        columnText(1) = "Cuota No."
        columnText(2) = "Entrega"
        columnText(3) = "Monto"
        columnText(4) = "Pend. Amort."
        columnText(5) = "Interes"
        columnText(6) = "Capital"
        columnText(7) = "Total Amort."
        columnText(8) = "Pago"
        columnText(9) = "Balance"
        columnText(10) = "Fecha Pago"


        Dim columnWidth(11) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 75
        columnWidth(2) = 100
        columnWidth(3) = 100
        columnWidth(4) = 100
        columnWidth(5) = 100
        columnWidth(6) = 100
        columnWidth(7) = 100
        columnWidth(8) = 100
        columnWidth(9) = 100
        columnWidth(10) = 100

        Dim columnAlign(11) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 1 'DERECHA
        columnAlign(4) = 1 'IZQUIERDA
        columnAlign(5) = 1 'DERECHA
        columnAlign(6) = 1 'DERECHA
        columnAlign(7) = 1 'DERECHA
        columnAlign(8) = 1 'DERECHA
        columnAlign(9) = 1 'DERECHA
        columnAlign(10) = 1 'DERECHA



        Dim count = 0
        Dim c As DataColumn
        For Each c In ds.Tables(0).Columns
            'adding names of columns as Listview columns				
            Dim h As New ColumnHeader
            h.Text = columnText(count) ' c.ColumnName
            h.TextAlign = columnAlign(count)
            h.Width = columnWidth(count)
            Me.lv.Columns.Add(h)
            count += 1
        Next



        Dim dt As DataTable = ds.Tables(0)
        Dim str(ds.Tables(0).Columns.Count) As String
        'adding Datarows as listview Grids
        Dim rr As DataRow



        For Each rr In dt.Rows

            For col As Integer = 0 To ds.Tables(0).Columns.Count - 1
                accion = 2 '/FORMATEAMO LOS DATOS DE ACUERDO A SU FORMATO, ESTO SE HACE POR CADA COLUMNA QUE EXISTA
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
            lv.Items.Add(ii)


            'showing the number of records still added
        Next



    End Sub


    '/LISTVIEW PROPIEDADES
    Private Sub lvwProd_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv.DoubleClick
        Id = lv.FocusedItem.Text
        Me.Text = "ACEPTAR"
        Me.Close()
    End Sub
    Private Sub lvwProd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lv.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Enter Then
            Id = lv.FocusedItem.Text
            Me.Text = "ACEPTAR"
            Me.Close()
        End If
    End Sub


    Private Sub cboSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub
End Class
