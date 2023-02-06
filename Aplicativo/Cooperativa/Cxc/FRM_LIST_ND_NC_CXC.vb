Imports MySql.Data.MySqlClient

Public Class FRM_LIST_ND_NC_CXC
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
    Friend WithEvents fld_tipo_doc As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_LIST_ND_NC_CXC))
        Me.LV = New System.Windows.Forms.ListView
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.fld_tipo_doc = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.White
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(8, 32)
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
        Me.txtBuscar.Size = New System.Drawing.Size(528, 20)
        Me.txtBuscar.TabIndex = 0
        Me.txtBuscar.Text = ""
        '
        'fld_tipo_doc
        '
        Me.fld_tipo_doc.Location = New System.Drawing.Point(272, 280)
        Me.fld_tipo_doc.Name = "fld_tipo_doc"
        Me.fld_tipo_doc.TabIndex = 5
        Me.fld_tipo_doc.Text = "TextBox1"
        Me.fld_tipo_doc.Visible = False
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(568, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 56)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Cerrar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seleccione un documento y pulse la tecla ( P ) para ReImprimir"
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
        'FRM_LIST_ND_NC_CXC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(650, 307)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fld_tipo_doc)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_LIST_ND_NC_CXC"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NC / ND CxC"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter




    '/PROPIEDADES DEL FORM
    Private Sub FRM_LIST_ND_NC_CXC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillListView()
    End Sub
    Private Sub FRM_LIST_ND_NC_CXC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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

        Dim fldToSearch As String = "fld_FullName"



        Dim strTosearch As String = "'%" & txtBuscar.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short
        Trim(strTosearch)
        Try
           
               
            If strTosearch <> "'%%'" Then
                sqlSearch = "SELECT fld_id_nd_cxc, fld_fecha, fld_FullName, fld_monto, fld_abono, fld_balance, fld_cliente_id_nd FROM view_cxc_nota_debito WHERE " & fldToSearch & " LIKE " & strTosearch & " "
            Else
                sqlSearch = "SELECT fld_id_nd_cxc, fld_fecha, fld_FullName, fld_monto, fld_abono, fld_balance, fld_cliente_id_nd FROM view_cxc_nota_debito "
            End If




            ds.Reset()
            da = New MySqlDataAdapter(sqlSearch, conn)
            da.Fill(ds, "tbl_nd_cxc")

            Dim columnText(7) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
            columnText(0) = "COD."
            columnText(1) = "FECHA"
            columnText(2) = "CLIENTE"
            columnText(3) = "MONTO"
            columnText(4) = "ABONO"
            columnText(5) = "BALANCE"


            Dim columnWidth(7) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
            columnWidth(0) = 40
            columnWidth(1) = 75
            columnWidth(2) = 230
            columnWidth(3) = 85
            columnWidth(4) = 85
            columnWidth(5) = 85


            Dim columnAlign(7) As Int32 'PARA ALINEAR LOS DATOS
            columnAlign(0) = 0 'IZQUIERDA
            columnAlign(1) = 0 'IZQUIERDA
            columnAlign(2) = 0 'IZQUIERDA
            columnAlign(3) = 1 'IZQUIERDA
            columnAlign(4) = 1 'IZQUIERDA
            columnAlign(5) = 1 'IZQUIERDA

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FRM_LIST_ND_NC_CXC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub
End Class
