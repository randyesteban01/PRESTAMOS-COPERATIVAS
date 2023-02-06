Imports MySql.Data.MySqlClient
Public Class frmAporteSocioLista
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
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
    Friend WithEvents lv As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAporteSocioLista))
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.lv = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(0, 0)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(648, 20)
        Me.txtBuscar.TabIndex = 0
        Me.txtBuscar.Text = ""
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.White
        Me.lv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lv.Location = New System.Drawing.Point(0, 28)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(666, 280)
        Me.lv.TabIndex = 1
        '
        'frmAporteSocioLista
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(666, 308)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAporteSocioLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Aporte de Socios"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAporteSocioLista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillListView()
    End Sub
    Public Sub FillListView()

        lv.Clear()
        lv.View = View.Details
        lv.LabelEdit = False
        lv.FullRowSelect = True
        lv.GridLines = True
        lv.Sorting = SortOrder.None

        Dim fldToSearch As String
        Dim strTosearch As String = "'%" & txtBuscar.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short

        fldToSearch = "CONCAT(cl.fld_Identity,' ',cl.fld_FullName )"

        If Trim(txtBuscar.Text) <> "" Then
            sqlSearch = "SELECT aa.ID AS ahoid, aa.Fecha AS ahofecha, cl.fld_Identity AS clicedula, cl.fld_FullName AS clinombre, aa.Monto AS ahomonto, cl.fld_id AS clicod, cl.fld_apodo AS cliapodo, cl.fld_Address AS clidireccion, cl.fld_City AS cliciudad, aa.Concepto AS ahoconcepto, mc.CtaContable AS cajactacontable, mc.Descripcion AS cajanombre FROM tbl_clientes AS cl  INNER JOIN tbl_ahorros_aportacion AS aa  ON aa.IDSocio=cl.fld_id INNER JOIN cajamantenimiento AS mc ON aa.IDCaja=mc.ID  AND " & fldToSearch & " LIKE " & strTosearch & "  ORDER BY aa.Fecha ASC LIMIT 0, 50; "
        Else
            sqlSearch = "SELECT aa.ID AS ahoid, aa.Fecha AS ahofecha, cl.fld_Identity AS clicedula, cl.fld_FullName AS clinombre, aa.Monto AS ahomonto, cl.fld_id AS clicod, cl.fld_apodo AS cliapodo, cl.fld_Address AS clidireccion, cl.fld_City AS cliciudad, aa.Concepto AS ahoconcepto, mc.CtaContable AS cajactacontable, mc.Descripcion AS cajanombre FROM tbl_clientes AS cl  INNER JOIN tbl_ahorros_aportacion AS aa  ON aa.IDSocio=cl.fld_id INNER JOIN cajamantenimiento AS mc ON aa.IDCaja=mc.ID ORDER BY aa.Fecha ASC LIMIT 0, 50; "
        End If


        Dim ds As New DataSet
        Dim da As MySqlDataAdapter

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds)

        Dim columnText(17) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "ID"
        columnText(1) = "Fecha"
        columnText(2) = "Cédula"
        columnText(3) = "Cliente"
        columnText(4) = "Monto"


        Dim columnWidth(17) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 100
        columnWidth(2) = 125
        columnWidth(3) = 300
        columnWidth(4) = 100


        Dim columnAlign(17) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 0 'DERECHA
        columnAlign(4) = 1 'IZQUIERDA


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
            '

            Dim ii As New ListViewItem(str)
            lv.Items.Add(ii)

            If txtBuscar.Text <> "" And accion = 2 Then
                lv.Items(0).Selected = True

            End If
            'showing the number of records still added
        Next



    End Sub


    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If txtBuscar.Text <> "" Then
            FillListView()

        Else
            lv.Items(0).Selected = True

        End If

    End Sub



    Private Sub lv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv.DoubleClick
        Id = lv.FocusedItem.Text
        Me.Text = "ACEPTAR"
        Me.Close()
    End Sub

    Private Sub lv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lv.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Enter Then
            Id = lv.FocusedItem.Text
            Me.Text = "ACEPTAR"
            Me.Close()
        End If
    End Sub

   

    Private Sub frmAporteSocioLista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
