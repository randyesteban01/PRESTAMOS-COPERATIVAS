Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmConsultaTransacciones
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents txtdescription As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbDetalle As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmConsultaTransacciones))
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker
        Me.btn_imprimir = New System.Windows.Forms.Button
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LV = New System.Windows.Forms.ListView
        Me.txtdescription = New System.Windows.Forms.TextBox
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.lblStatus = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnAnular = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.PrintDialog = New System.Windows.Forms.PrintDialog
        Me.cbDetalle = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(384, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Hasta"
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.CustomFormat = "dd/MMMM/yyyy"
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaHasta.Location = New System.Drawing.Point(432, 32)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(136, 20)
        Me.dtpFechaHasta.TabIndex = 34
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btn_imprimir.ForeColor = System.Drawing.Color.Black
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_imprimir.Location = New System.Drawing.Point(712, 8)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(72, 56)
        Me.btn_imprimir.TabIndex = 32
        Me.btn_imprimir.Text = "&Imprimir"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_filtrar
        '
        Me.btn_filtrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_filtrar.ForeColor = System.Drawing.Color.Black
        Me.btn_filtrar.Image = CType(resources.GetObject("btn_filtrar.Image"), System.Drawing.Image)
        Me.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_filtrar.Location = New System.Drawing.Point(632, 8)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(72, 56)
        Me.btn_filtrar.TabIndex = 30
        Me.btn_filtrar.Text = "&Filtrar"
        Me.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.CustomFormat = "dd/MMMM/yyyy"
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaDesde.Location = New System.Drawing.Point(432, 8)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(136, 20)
        Me.dtpFechaDesde.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(384, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Desde"
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.Location = New System.Drawing.Point(72, 8)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(296, 21)
        Me.cmbTipo.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Tipo:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.White
        Me.LV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LV.Location = New System.Drawing.Point(0, 69)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(794, 286)
        Me.LV.TabIndex = 20
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtdescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescription.Location = New System.Drawing.Point(424, 136)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(27, 20)
        Me.txtdescription.TabIndex = 19
        Me.txtdescription.Text = ""
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Location = New System.Drawing.Point(16, 240)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 23)
        Me.btnNuevo.TabIndex = 25
        Me.btnNuevo.Text = "&NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(176, 208)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 16)
        Me.lblStatus.TabIndex = 24
        Me.lblStatus.Text = "Label1"
        Me.lblStatus.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(272, 240)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 23)
        Me.btnCerrar.TabIndex = 23
        Me.btnCerrar.Text = "&CERRAR"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnAnular
        '
        Me.btnAnular.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnular.ForeColor = System.Drawing.Color.Black
        Me.btnAnular.Location = New System.Drawing.Point(192, 240)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(72, 23)
        Me.btnAnular.TabIndex = 22
        Me.btnAnular.Text = "&ANULAR"
        Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(104, 240)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 23)
        Me.btnGuardar.TabIndex = 21
        Me.btnGuardar.Text = "&GUARDAR"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cbDetalle
        '
        Me.cbDetalle.Location = New System.Drawing.Point(72, 32)
        Me.cbDetalle.Name = "cbDetalle"
        Me.cbDetalle.Size = New System.Drawing.Size(104, 16)
        Me.cbDetalle.TabIndex = 36
        Me.cbDetalle.Text = "Detalles"
        '
        'frmConsultaTransacciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(794, 355)
        Me.Controls.Add(Me.cbDetalle)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.lblStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaTransacciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de trasacciones "
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim CurrentId As String
    Dim fecha_1 As String, fecha_2 As String


    Private Sub frmConsultaTransacciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarTipo()
    End Sub

    Private Sub frmConsultaTransacciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

#Region "ALL SUB"

    Private Sub LlenarTipo()
        Dim da As New MySqlDataAdapter("SELECT fld_id, fld_descripcion FROM tbl_interfascontableotrastipo ORDER BY fld_descripcion", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbTipo.DataSource = dt
        cmbTipo.DisplayMember = "fld_descripcion"
        cmbTipo.ValueMember = "fld_id"
    End Sub
    Private Function validate_data() As Boolean
        If cmbTipo.Text = "" Then
            Alerta("Debe seleccionar el tipo de documento")
            Return False
        End If
        Return True
    End Function

    Private Sub lvEmcabezado()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.None


        Dim sqlSearch As String
        Dim accion As Short

        sqlSearch = "SELECT t.TransID, t.TransFechaMovimiento, t.TransDescripcion, SUM(td.TransDDebito) FROM tbl_interfascontabletransacciones AS t, tbl_interfasecontabletransaccionesdetalles AS td, tbl_interfascontableotrastipo AS tp WHERE td.TransDIDTrans=t.TransID AND t.TransIDTipo=tp.fld_id AND t.TransFechaMovimiento BETWEEN '" & formatDate(dtpFechaDesde.Value.Date) & "' AND '" & formatDate(dtpFechaHasta.Value.Date) & "' AND t.TransIDTipo= " & cmbTipo.SelectedValue & " GROUP BY td.TransDIDTrans"


        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_entrada_diarias")


        Dim columnText(10) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "Código"
        columnText(1) = "Fecha"
        columnText(2) = "Descripción"
        columnText(3) = "Monto"
        columnText(4) = "CTA. DEBITO"
        columnText(5) = "CTA. CREDITO"
        columnText(6) = "MIXTO"
        columnText(7) = "USUARIO"

        Dim columnWidth(10) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 88
        columnWidth(1) = 128
        columnWidth(2) = 416
        columnWidth(3) = 128
        columnWidth(4) = 85
        columnWidth(5) = 85
        columnWidth(6) = 50
        columnWidth(7) = 145

        Dim columnAlign(10) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 1 'DERECHA
        columnAlign(4) = 0 'IZQUIERDA
        columnAlign(5) = 0 'IZQUIERDA
        columnAlign(6) = 0 'IZQUIERDA
        columnAlign(7) = 0 'DERECHA



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
                    str(col) = Format(rr(col), "##,##0.00")
                ElseIf rr(col).GetType().FullName.ToString = "System.Decimal" Then
                    str(col) = Format(rr(col), "##,##0.00")
                End If
            Next

            Dim ii As New ListViewItem(str)
            LV.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub
    Private Sub lvDetalle()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        LV.Clear()
        LV.View = View.Details
        LV.LabelEdit = False
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.MultiSelect = False
        LV.Sorting = SortOrder.None


        Dim sqlSearch As String
        Dim accion As Short

        sqlSearch = "SELECT t.TransID, t.TransFechaMovimiento, t.TransDescripcion, td.TransDCuentaNo, td.TransDDescripcionCuenta, td.TransDDebito, td.TransDCredito  FROM tbl_interfascontabletransacciones AS t, tbl_interfasecontabletransaccionesdetalles AS td, tbl_interfascontableotrastipo AS tp WHERE td.TransDIDTrans=t.TransID AND t.TransIDTipo=tp.fld_id AND t.TransFechaMovimiento BETWEEN '" & formatDate(dtpFechaDesde.Value.Date) & "' AND '" & formatDate(dtpFechaHasta.Value.Date) & "' AND t.TransIDTipo= " & cmbTipo.SelectedValue & " ORDER BY td.TransDIDTrans, td.TransDCredito"


        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_entrada_diarias")


        Dim columnText(10) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "Código"
        columnText(1) = "Fecha"
        columnText(2) = "Descripción"
        columnText(3) = "Cuenta No."
        columnText(4) = "Descripción Cuenta"
        columnText(5) = "Débito"
        columnText(6) = "Crédito"
        columnText(7) = "USUARIO"

        Dim columnWidth(10) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 50
        columnWidth(1) = 85
        columnWidth(2) = 300
        columnWidth(3) = 100
        columnWidth(4) = 150
        columnWidth(5) = 100
        columnWidth(6) = 100
        columnWidth(7) = 145

        Dim columnAlign(10) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 0 'DERECHA
        columnAlign(4) = 0 'IZQUIERDA
        columnAlign(5) = 1 'IZQUIERDA
        columnAlign(6) = 1 'IZQUIERDA
        columnAlign(7) = 0 'DERECHA



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
                    str(col) = Format(rr(col), "##,##0.00")
                ElseIf rr(col).GetType().FullName.ToString = "System.Decimal" Then
                    str(col) = Format(rr(col), "##,##0.00")
                End If
            Next

            Dim ii As New ListViewItem(str)
            LV.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub


#End Region

    Private Sub LV_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LV.KeyPress
        If e.KeyChar = Chr(13) Then
            Id = LV.FocusedItem.Text
            ' FRMS_TRANSACCIONES("Consultando Transacciones Contable")
        End If
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        Id = LV.FocusedItem.Text
        ' FRMS_TRANSACCIONES("Consultando Transacciones Contable")
    End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        If validate_data() = False Then Exit Sub
        If cbDetalle.Checked = True Then
            lvDetalle()
        Else
            lvEmcabezado()
        End If
    End Sub


    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click
        Imprimir()
    End Sub

    Private Sub Imprimir()
        PrintDialog.AllowSomePages = True
        PrintDialog.ShowHelp = True
        PrintDialog.Document = docToPrint
        Dim result As DialogResult = PrintDialog.ShowDialog()

        If (result = Windows.Forms.DialogResult.OK) Then
            Dim ds As New DataSet

            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")

            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = "Desde " + Format(dtpFechaDesde.Value, "dd-MMMM-yyyy") + " hasta " + Format(dtpFechaHasta.Value, "dd-MMMM-yyyy")
            Next
            Dim daRecord As New MySqlDataAdapter("SELECT * FROM view_cont_transacciones WHERE TransFechaMovimiento >= '" & formatDate(dtpFechaDesde.Value.Date) & "' AND TransFechaMovimiento <= '" & formatDate(dtpFechaHasta.Value.Date) & "' AND TransIDTipo=" & cmbTipo.SelectedValue & " ", conn)
            daRecord.Fill(ds, "view_cont_transacciones")
            Dim Report
            If cbDetalle.Checked = True Then
                Report = New rptTransaccionesListadoDetalle
            Else
                Report = New rptTransaccionesListado
            End If


            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PrinterName = PrintDialog.PrinterSettings.PrinterName
            Report.PrintToPrinter(PrintDialog.PrinterSettings.Copies, True, PrintDialog.PrinterSettings.FromPage, PrintDialog.PrinterSettings.ToPage)
        End If

    End Sub





    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub

    Private Sub lbl_tipo_entrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
