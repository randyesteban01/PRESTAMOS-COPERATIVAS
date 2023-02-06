Imports MySql.Data.MySqlClient
Public Class FRM_DIARIO_BANCO_LIST
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
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents LBL_TITLE As System.Windows.Forms.Label
    Friend WithEvents lbl_banco As System.Windows.Forms.Label
    Friend WithEvents fld_id_banco As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_DIARIO_BANCO_LIST))
        Me.lbl_banco = New System.Windows.Forms.Label
        Me.LBL_TITLE = New System.Windows.Forms.Label
        Me.LV = New System.Windows.Forms.ListView
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.lblStatus = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnAnular = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.fld_id_banco = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lbl_banco
        '
        Me.lbl_banco.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lbl_banco.Location = New System.Drawing.Point(0, 32)
        Me.lbl_banco.Name = "lbl_banco"
        Me.lbl_banco.Size = New System.Drawing.Size(576, 24)
        Me.lbl_banco.TabIndex = 3
        Me.lbl_banco.Text = "lbl_banco"
        '
        'LBL_TITLE
        '
        Me.LBL_TITLE.Font = New System.Drawing.Font("Arial", 20.25!)
        Me.LBL_TITLE.Location = New System.Drawing.Point(0, 0)
        Me.LBL_TITLE.Name = "LBL_TITLE"
        Me.LBL_TITLE.Size = New System.Drawing.Size(576, 32)
        Me.LBL_TITLE.TabIndex = 2
        Me.LBL_TITLE.Text = "Label1"
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.LV.Location = New System.Drawing.Point(0, 88)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(579, 232)
        Me.LV.TabIndex = 1
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.Color.White
        Me.txtdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescription.Location = New System.Drawing.Point(0, 64)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(579, 20)
        Me.txtdescription.TabIndex = 0
        Me.txtdescription.Text = ""
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Location = New System.Drawing.Point(40, 328)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 23)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "&NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(344, 240)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 16)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Label1"
        Me.lblStatus.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(256, 232)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 23)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "&CERRAR"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnAnular
        '
        Me.btnAnular.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnular.ForeColor = System.Drawing.Color.Black
        Me.btnAnular.Location = New System.Drawing.Point(168, 232)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(72, 23)
        Me.btnAnular.TabIndex = 7
        Me.btnAnular.Text = "&ANULAR"
        Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(88, 232)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "&GUARDAR"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'fld_id_banco
        '
        Me.fld_id_banco.Location = New System.Drawing.Point(376, 96)
        Me.fld_id_banco.Name = "fld_id_banco"
        Me.fld_id_banco.TabIndex = 4
        Me.fld_id_banco.Text = "0"
        '
        'FRM_DIARIO_BANCO_LIST
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(586, 324)
        Me.Controls.Add(Me.lbl_banco)
        Me.Controls.Add(Me.LBL_TITLE)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.fld_id_banco)
        Me.Controls.Add(Me.btnNuevo)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_DIARIO_BANCO_LIST"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim CurrentId As String

    Private Sub FRM_DIARIO_BANCO_LIST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillLV()
    End Sub

    Private Sub FRM_DIARIO_BANCO_LIST_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
        LV.Sorting = SortOrder.Ascending


        Dim fldToSearch As String = "fld_descripcion" ' = cboSearch.Text
        Dim strTosearch As String = "'" & txtdescription.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short
        Dim tabla As String
        If Me.Text = "ND Bancaria" Then
            tabla = "tbl_nd_bancaria"

        ElseIf Me.Text = "NC Bancaria" Then
            tabla = "tbl_nc_bancaria"

        ElseIf Me.Text = "Depósito Bancario" Then
            tabla = "tbl_deposito"

        End If

        If strTosearch <> "" Then
            sqlSearch = "SELECT fld_id_doc, fld_fecha, fld_descripcion, fld_monto FROM " & tabla & " WHERE " & fldToSearch & " LIKE " & strTosearch & " AND fld_id_banco ='" & fld_id_banco.Text & "'"
        Else
            sqlSearch = "SELECT fld_id_doc, fld_fecha, fld_descripcion, fld_monto FROM " & tabla & " WHERE fld_id_banco ='" & fld_id_banco.Text & "'"
        End If


        ds.Reset()

        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, tabla)


        Dim columnText(4) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "CODIGO"
        columnText(1) = "FECHA"
        columnText(2) = "DESCRIPCION"
        columnText(3) = "MONTO"

        Dim columnWidth(4) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 60
        columnWidth(1) = 80
        columnWidth(2) = 310
        columnWidth(3) = 100

        Dim columnAlign(4) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 1 'DERECHA



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
                    str(col) = Format(rr(col), "dd/MMM/yy")
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
        FillLV()
        If e.KeyChar = Chr(13) Then
            LV.Focus() 'LoadData(CurrentId)
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
