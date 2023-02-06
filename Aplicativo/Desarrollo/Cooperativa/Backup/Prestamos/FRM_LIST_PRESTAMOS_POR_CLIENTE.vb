Imports  MySql.Data.MySqlClient
Public Class FRM_LIST_PRESTAMOS_POR_CLIENTE
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
    Friend WithEvents fld_id As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_LIST_PRESTAMOS_POR_CLIENTE))
        Me.lv = New System.Windows.Forms.ListView
        Me.fld_id = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lv
        '
        Me.lv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv.BackColor = System.Drawing.Color.White
        Me.lv.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.Location = New System.Drawing.Point(1, 1)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(736, 256)
        Me.lv.TabIndex = 8
        '
        'fld_id
        '
        Me.fld_id.Location = New System.Drawing.Point(344, 232)
        Me.fld_id.Name = "fld_id"
        Me.fld_id.TabIndex = 9
        Me.fld_id.Text = "0"
        '
        'FRM_LIST_PRESTAMOS_POR_CLIENTE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(738, 259)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.fld_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_LIST_PRESTAMOS_POR_CLIENTE"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de préstamos"
        Me.ResumeLayout(False)

    End Sub

#End Region


    '/PROPIEDADES DEL FORM
    Private Sub FRM_LIST_PRESTAMOS_POR_CLIENTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillListView()
    End Sub
    Private Sub FRM_LIST_PRESTAMOS_POR_CLIENTE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    '/SUBPROGRAMAS
    Public Sub FillListView()

        lv.Clear()
        lv.View = View.Details
        lv.LabelEdit = False
        lv.FullRowSelect = True
        lv.GridLines = True
        lv.Sorting = SortOrder.Descending

        Dim fldToSearch As String
        Dim strTosearch As String
        Dim sqlSearch As String
        Dim accion As Short

        sqlSearch = "SELECT fld_id_prestamos, fld_fecha_entrega, fld_fecha_termina, fld_monto FROM view_prestamos_todos WHERE fld_balance > 0 AND fld_id_del_cliente=" & fld_id.Text & ""


        Dim ds As New DataSet, dr As DataRow
        Dim da As MySqlDataAdapter

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "view_prestamos_todos")

        For Each dr In ds.Tables(0).Rows
            UPDATE_PRESTAMOS(dr("fld_id_prestamos"))
        Next

        Dim columnText(4) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "DOC.NO."
        columnText(1) = "ENTREGA"
        columnText(2) = "VENCE"
        columnText(3) = "MONTO RD$"


        Dim columnWidth(4) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 125
        columnWidth(1) = 150
        columnWidth(2) = 150
        columnWidth(3) = 250

        Dim columnAlign(4) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 1 'IZQUIERDA
        columnAlign(2) = 1 'DERECHA
        columnAlign(3) = 1 'DERECHA



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
               
                End If
            Next

            Dim ii As New ListViewItem(str)
            lv.Items.Add(ii)


            'showing the number of records still added
        Next



    End Sub

    '/KEY_PRESS FIELDS
   


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
