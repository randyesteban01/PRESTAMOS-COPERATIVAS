Imports MySql.Data.MySqlClient
Public Class FRM_LIST_DOC_TRANSITO
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
    Friend WithEvents lbl_doc As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents fld_monto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_LIST_DOC_TRANSITO))
        Me.lbl_doc = New System.Windows.Forms.Label
        Me.LV = New System.Windows.Forms.ListView
        Me.fld_monto = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_doc
        '
        Me.lbl_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_doc.Location = New System.Drawing.Point(8, 16)
        Me.lbl_doc.Name = "lbl_doc"
        Me.lbl_doc.Size = New System.Drawing.Size(464, 23)
        Me.lbl_doc.TabIndex = 3
        Me.lbl_doc.Text = "Documento"
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.LV.CheckBoxes = True
        Me.LV.Location = New System.Drawing.Point(12, 64)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(592, 224)
        Me.LV.TabIndex = 0
        '
        'fld_monto
        '
        Me.fld_monto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fld_monto.Location = New System.Drawing.Point(408, 296)
        Me.fld_monto.Name = "fld_monto"
        Me.fld_monto.Size = New System.Drawing.Size(192, 20)
        Me.fld_monto.TabIndex = 1
        Me.fld_monto.Text = "0.00"
        Me.fld_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(304, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRM_LIST_DOC_TRANSITO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(616, 334)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fld_monto)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.lbl_doc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_LIST_DOC_TRANSITO"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documento en Transito"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRM_LIST_DOC_TRANSITO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        If lbl_doc.Text = "Depósitos en Transido" Then
            FillLV_dep()
        Else
            FillLV_ck()
        End If
    End Sub

    Private Sub FillLV_ck()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.None


        Dim fldToSearch As String
        Dim strTosearch As String
        Dim sqlSearch As String
        Dim accion As Short, estado As String

        sqlSearch = "SELECT fld_no_ck, fld_fecha_ck, fld_monto_ck FROM tbl_cheques_trans WHERE fld_id_conciliacion_ck=" & Id & "  ORDER BY fld_no_ck ASC"


        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_cheques_trans")

        fld_monto.Text = 0
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            fld_monto.Text = Format(CDbl(fld_monto.Text) + dr("fld_monto_ck"), "C2")
        Next



        Dim columnText(5) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "CK No."
        columnText(1) = "FECHA"
        columnText(2) = "MONTO"
        columnText(3) = "CONCEPTO"
        columnText(4) = "MONTO"

        Dim columnWidth(5) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 100
        columnWidth(1) = 100
        columnWidth(2) = 100
        columnWidth(3) = 310
        columnWidth(4) = 85

        Dim columnAlign(5) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 1 'IZQUIERDA
        columnAlign(3) = 0 'DERECHA
        columnAlign(4) = 1 'DERECHA


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
                    str(col) = Format(rr(col), "C2")
                End If
            Next

            Dim ii As New ListViewItem(str)
            LV.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub
    Private Sub FillLV_dep()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.None


        Dim fldToSearch As String
        Dim strTosearch As String
        Dim sqlSearch As String
        Dim accion As Short, estado As String
     

        
        sqlSearch = "SELECT fld_no_dep, fld_fecha_dep, fld_monto_dep FROM tbl_deposito_trans WHERE fld_id_conciliacion_dep=" & Id & "  ORDER BY fld_fecha_dep ASC"


        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_deposito_trans")
        fld_monto.Text = 0
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            fld_monto.Text = Format(CDbl(fld_monto.Text) + dr("fld_monto_dep"), "C2")
        Next


        Dim columnText(5) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "NO"
        columnText(1) = "FECHA"
        columnText(2) = "MONTO"
        columnText(3) = "MONTO"
        columnText(4) = "MONTO"

        Dim columnWidth(5) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 100
        columnWidth(1) = 100
        columnWidth(2) = 100
        columnWidth(3) = 85
        columnWidth(4) = 0

        Dim columnAlign(5) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 1 'IZQUIERDA
        columnAlign(3) = 0 'DERECHA
        columnAlign(4) = 1 'DERECHA


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
                    str(col) = Format(rr(col), "C2")
                End If
            Next

            Dim ii As New ListViewItem(str)
            LV.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub
End Class
