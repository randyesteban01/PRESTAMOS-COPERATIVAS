Imports MySql.Data.MySqlClient
Public Class FRM_LIST_CK
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_LIST_CK))
        Me.LV = New System.Windows.Forms.ListView
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.LV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.Location = New System.Drawing.Point(0, 43)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(762, 344)
        Me.LV.TabIndex = 1
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.Color.White
        Me.txtdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(112, 8)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(648, 26)
        Me.txtdescription.TabIndex = 0
        Me.txtdescription.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Barra de Búsqueda :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FRM_LIST_CK
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(762, 387)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_LIST_CK"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de cheques"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim CurrentId As String

    Private Sub FRM_LIST_CK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillLV()
    End Sub

    Private Sub FRM_LIST_CK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

#Region "ALL SUB"

    Private Sub FillLV()

        'Alerta(sqlSearch)

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.None


        Dim fldToSearch As String = "fld_beneficiario"
        Dim strTosearch As String = "'%" & txtdescription.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short
        If Me.Text = "Solicitudes de cheques" Then
            If strTosearch <> "" Then
                sqlSearch = "SELECT fld_id_doc, fld_ck_no,  fld_fecha, fld_beneficiario, fld_monto FROM tbl_cheques_solicitud WHERE " & fldToSearch & " LIKE " & strTosearch & " ORDER BY fld_fecha, fld_beneficiario LIMIT 1500"
            Else
                sqlSearch = "SELECT fld_id_doc, fld_ck_no,  fld_fecha, fld_beneficiario, fld_monto FROM tbl_cheques_solicitud ORDER BY fld_fecha, fld_beneficiario LIMIT 1500"
            End If
        Else
            If strTosearch <> "" Then
                sqlSearch = "SELECT fld_id_doc, fld_ck_no,  fld_fecha, fld_beneficiario, fld_monto FROM tbl_cheques WHERE " & fldToSearch & " LIKE " & strTosearch & " AND  fld_estado = 'EMISION' ORDER BY fld_fecha, fld_beneficiario LIMIT 1500"
            Else
                sqlSearch = "SELECT fld_id_doc, fld_ck_no,  fld_fecha, fld_beneficiario, fld_monto FROM tbl_cheques WHERE fld_estado = 'EMISION' ORDER BY fld_fecha, fld_beneficiario LIMIT 1500"
            End If
        End If

        ds.Reset()

        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_cheques")


        Dim columnText(5) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "01"
        columnText(1) = "CK. No."
        columnText(2) = "FECHA"
        columnText(3) = "BENECIFIARIO"
        columnText(4) = "MONTO"

        Dim columnWidth(5) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 70
        columnWidth(2) = 125
        columnWidth(3) = 410
        columnWidth(4) = 125

        Dim columnAlign(5) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
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

#End Region

    Private Sub txtdescription_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescription.KeyPress

        If e.KeyChar = Chr(13) Then
            FillLV()
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
End Class
