Imports MySql.Data.MySqlClient
Public Class FRM_DIARIO_BANCO
    Inherits System.Windows.Forms.Form
    Dim BANCO As New IniFile(AppPath & "\BANCO.ini") '/INI FILE
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
    Friend WithEvents fld_id_doc As System.Windows.Forms.TextBox
    Friend WithEvents fld_monto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fld_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents fld_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents FLD_BALANCE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FLD_CUENTA As System.Windows.Forms.TextBox
    Friend WithEvents FLD_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FLD_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_lista_art As System.Windows.Forms.Button
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_procesar As System.Windows.Forms.Button
    Friend WithEvents CtaContableTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbAfectaCaja As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_DIARIO_BANCO))
        Me.btn_lista_art = New System.Windows.Forms.Button
        Me.fld_id_doc = New System.Windows.Forms.TextBox
        Me.fld_monto = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.fld_descripcion = New System.Windows.Forms.TextBox
        Me.fld_date = New System.Windows.Forms.DateTimePicker
        Me.FLD_BALANCE = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.FLD_CUENTA = New System.Windows.Forms.TextBox
        Me.FLD_NOMBRE = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.FLD_CODIGO = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LV = New System.Windows.Forms.ListView
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btn_cerrar = New System.Windows.Forms.Button
        Me.btn_procesar = New System.Windows.Forms.Button
        Me.CtaContableTxt = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbAfectaCaja = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'btn_lista_art
        '
        Me.btn_lista_art.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_lista_art.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lista_art.ForeColor = System.Drawing.Color.Black
        Me.btn_lista_art.Image = CType(resources.GetObject("btn_lista_art.Image"), System.Drawing.Image)
        Me.btn_lista_art.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_lista_art.Location = New System.Drawing.Point(152, 30)
        Me.btn_lista_art.Name = "btn_lista_art"
        Me.btn_lista_art.Size = New System.Drawing.Size(99, 24)
        Me.btn_lista_art.TabIndex = 1
        Me.btn_lista_art.Text = "&Buscar banco"
        Me.btn_lista_art.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_id_doc
        '
        Me.fld_id_doc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fld_id_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_id_doc.Location = New System.Drawing.Point(296, 16)
        Me.fld_id_doc.Name = "fld_id_doc"
        Me.fld_id_doc.Size = New System.Drawing.Size(48, 20)
        Me.fld_id_doc.TabIndex = 20
        Me.fld_id_doc.Text = "0"
        Me.fld_id_doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_id_doc.Visible = False
        '
        'fld_monto
        '
        Me.fld_monto.BackColor = System.Drawing.Color.White
        Me.fld_monto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_monto.Location = New System.Drawing.Point(80, 104)
        Me.fld_monto.Name = "fld_monto"
        Me.fld_monto.Size = New System.Drawing.Size(176, 20)
        Me.fld_monto.TabIndex = 2
        Me.fld_monto.Text = "0.00"
        Me.fld_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(0, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Monto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_descripcion
        '
        Me.fld_descripcion.BackColor = System.Drawing.Color.White
        Me.fld_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_descripcion.Location = New System.Drawing.Point(80, 128)
        Me.fld_descripcion.MaxLength = 150
        Me.fld_descripcion.Multiline = True
        Me.fld_descripcion.Name = "fld_descripcion"
        Me.fld_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fld_descripcion.Size = New System.Drawing.Size(440, 40)
        Me.fld_descripcion.TabIndex = 3
        Me.fld_descripcion.Text = ""
        '
        'fld_date
        '
        Me.fld_date.CustomFormat = "dd / MMM / yyyy"
        Me.fld_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_date.Location = New System.Drawing.Point(384, 32)
        Me.fld_date.Name = "fld_date"
        Me.fld_date.Size = New System.Drawing.Size(136, 20)
        Me.fld_date.TabIndex = 22
        '
        'FLD_BALANCE
        '
        Me.FLD_BALANCE.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.FLD_BALANCE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_BALANCE.Enabled = False
        Me.FLD_BALANCE.Location = New System.Drawing.Point(344, 104)
        Me.FLD_BALANCE.Name = "FLD_BALANCE"
        Me.FLD_BALANCE.ReadOnly = True
        Me.FLD_BALANCE.Size = New System.Drawing.Size(176, 20)
        Me.FLD_BALANCE.TabIndex = 19
        Me.FLD_BALANCE.Text = "0.00"
        Me.FLD_BALANCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(264, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Balance"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FLD_CUENTA
        '
        Me.FLD_CUENTA.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.FLD_CUENTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_CUENTA.Enabled = False
        Me.FLD_CUENTA.Location = New System.Drawing.Point(80, 80)
        Me.FLD_CUENTA.Name = "FLD_CUENTA"
        Me.FLD_CUENTA.ReadOnly = True
        Me.FLD_CUENTA.Size = New System.Drawing.Size(176, 20)
        Me.FLD_CUENTA.TabIndex = 15
        Me.FLD_CUENTA.Text = ""
        '
        'FLD_NOMBRE
        '
        Me.FLD_NOMBRE.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.FLD_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_NOMBRE.Enabled = False
        Me.FLD_NOMBRE.Location = New System.Drawing.Point(80, 56)
        Me.FLD_NOMBRE.Name = "FLD_NOMBRE"
        Me.FLD_NOMBRE.ReadOnly = True
        Me.FLD_NOMBRE.Size = New System.Drawing.Size(440, 20)
        Me.FLD_NOMBRE.TabIndex = 14
        Me.FLD_NOMBRE.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(288, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Fecha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FLD_CODIGO
        '
        Me.FLD_CODIGO.BackColor = System.Drawing.Color.White
        Me.FLD_CODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_CODIGO.Location = New System.Drawing.Point(80, 32)
        Me.FLD_CODIGO.Name = "FLD_CODIGO"
        Me.FLD_CODIGO.Size = New System.Drawing.Size(72, 20)
        Me.FLD_CODIGO.TabIndex = 13
        Me.FLD_CODIGO.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(0, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Cod. Banco"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Concepto "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Cta. bancaria"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LV
        '
        Me.LV.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.LV.Location = New System.Drawing.Point(8, 232)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(512, 192)
        Me.LV.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(80, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 56)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&Nuevo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(224, 176)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(72, 56)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "&Consultar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cerrar.Location = New System.Drawing.Point(448, 176)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(72, 56)
        Me.btn_cerrar.TabIndex = 7
        Me.btn_cerrar.Text = "&Cerrar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_procesar
        '
        Me.btn_procesar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_procesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_procesar.ForeColor = System.Drawing.Color.Black
        Me.btn_procesar.Image = CType(resources.GetObject("btn_procesar.Image"), System.Drawing.Image)
        Me.btn_procesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_procesar.Location = New System.Drawing.Point(152, 176)
        Me.btn_procesar.Name = "btn_procesar"
        Me.btn_procesar.Size = New System.Drawing.Size(72, 56)
        Me.btn_procesar.TabIndex = 4
        Me.btn_procesar.Text = "&Guardar"
        Me.btn_procesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CtaContableTxt
        '
        Me.CtaContableTxt.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.CtaContableTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CtaContableTxt.Enabled = False
        Me.CtaContableTxt.Location = New System.Drawing.Point(344, 80)
        Me.CtaContableTxt.Name = "CtaContableTxt"
        Me.CtaContableTxt.ReadOnly = True
        Me.CtaContableTxt.Size = New System.Drawing.Size(176, 20)
        Me.CtaContableTxt.TabIndex = 18
        Me.CtaContableTxt.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(256, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Cta. Contable"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbAfectaCaja
        '
        Me.cbAfectaCaja.Location = New System.Drawing.Point(80, 8)
        Me.cbAfectaCaja.Name = "cbAfectaCaja"
        Me.cbAfectaCaja.Size = New System.Drawing.Size(104, 16)
        Me.cbAfectaCaja.TabIndex = 0
        Me.cbAfectaCaja.Text = "Afecta Caja"
        Me.cbAfectaCaja.Visible = False
        '
        'FRM_DIARIO_BANCO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(530, 435)
        Me.Controls.Add(Me.cbAfectaCaja)
        Me.Controls.Add(Me.CtaContableTxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_procesar)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.fld_descripcion)
        Me.Controls.Add(Me.fld_date)
        Me.Controls.Add(Me.FLD_BALANCE)
        Me.Controls.Add(Me.FLD_CUENTA)
        Me.Controls.Add(Me.btn_lista_art)
        Me.Controls.Add(Me.FLD_NOMBRE)
        Me.Controls.Add(Me.fld_id_doc)
        Me.Controls.Add(Me.FLD_CODIGO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fld_monto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_DIARIO_BANCO"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diario de Banco"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRM_DIARIO_BANCO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        fld_date.Value = Now
        

    End Sub
    'create estado de cta. banco

   
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
        Dim strTosearch As String
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

        sqlSearch = "SELECT fld_id_doc, fld_fecha, fld_descripcion, fld_monto, fld_cod_concepto FROM " & tabla & " WHERE fld_id_banco = '" & FLD_CODIGO.Text & "' AND MONTH(fld_fecha)= " & fld_date.Value.Month & "  AND YEAR(fld_fecha)=" & fld_date.Value.Year & " ORDER BY fld_fecha, fld_cod_concepto"



        ds.Reset()

        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, tabla)


        Dim columnText(5) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "CODIGO"
        columnText(1) = "FECHA"
        columnText(2) = "DESCRIPCION"
        columnText(3) = "MONTO"
        columnText(4) = "CONCEPTO"

        Dim columnWidth(5) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 60
        columnWidth(1) = 80
        columnWidth(2) = 300
        columnWidth(3) = 100
        columnWidth(4) = 100


        Dim columnAlign(4) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 1 'DERECHA
        columnAlign(4) = 0 'DERECHA



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
    Private Function VALIDA_DATA() As Boolean
        If SCALAR_NUM("SELECT IFNULL(1,0) FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & Me.Text & "'") = 0 Then
            Alerta("El Interfas contable no está configurado, no se puede guardar el documento.")
            Return False
        End If

        If FLD_CODIGO.Text = "" Then
            Alerta("Faltan los datos del Banco")
            Return False
        ElseIf Trim(fld_descripcion.Text) = "" Then
            fld_descripcion.Focus()
            Alerta("Falta la descripcion")
            Return False
        ElseIf Trim(fld_monto.Text) = "" Or CDbl(fld_monto.Text) = 0 Then
            fld_monto.Focus()
            Alerta("Falta el monto")
            Return False
        End If

        Return True

    End Function
    Private Function guardarDoc(ByVal TableName As String, ByVal transito As String) As Integer
        If cbAfectaCaja.Checked = True Then
            NON_QUERY("INSERT INTO " & TableName & " (fld_id_banco, fld_fecha, fld_descripcion, fld_monto, fld_estado, fld_transito, fld_cod_concepto, afectacaja)" _
                         & " VALUES('" & FLD_CODIGO.Text & "','" & formatDate(fld_date.Value.Date) & "','" & fld_descripcion.Text & "'," & CDbl(fld_monto.Text) & ",'N','" & transito & "','N/A',1)")
        Else
            NON_QUERY("INSERT INTO " & TableName & " (fld_id_banco, fld_fecha, fld_descripcion, fld_monto, fld_estado, fld_transito, fld_cod_concepto)" _
                         & " VALUES('" & FLD_CODIGO.Text & "','" & formatDate(fld_date.Value.Date) & "','" & fld_descripcion.Text & "'," & CDbl(fld_monto.Text) & ",'N','" & transito & "','N/A')")
        End If
        

        Return SCALAR_NUM("SELECT MAX(fld_id_doc) FROM " & TableName & "")
    End Function
    Private Sub LOAD_DATA(ByVal Valor As String)
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM TBL_BANCOS WHERE FLD_CODIGO='" & Valor & "'", conn)
        da.Fill(ds, "TBL_BANCOS")
        For Each dr In ds.Tables(0).Rows
            FLD_CODIGO.Text = dr("FLD_CODIGO")
            FLD_NOMBRE.Text = dr("FLD_NOMBRE")
            FLD_CUENTA.Text = dr("FLD_CUENTA")
            CtaContableTxt.Text = dr("FLD_CTA_CONTABLE")
            FLD_BALANCE.Text = Format(dr("FLD_BALANCE"), "C2")

            fld_descripcion.Focus()

            GoTo exite
        Next
        Alerta("EL DOCUMENTO SOLICITADO NO EXISTE NE LA BASE DE DATOS")

        ds.Dispose()
        da.Dispose()
        Exit Sub
exite:
        ds.Dispose()
        da.Dispose()
    End Sub 'LOAD DATA FROM DATA BASE "TBL_BANCO"
    Private Sub LOAD_DATA_DOC(ByVal TABLA As String, ByVal id_doc As String)
        Dim dr As DataRow
        Dim ds As New DataSet, idbanco As String
        Dim da As New MySqlDataAdapter("SELECT * FROM " & TABLA & " WHERE fld_id_doc=" & id_doc & "", conn)
        da.Fill(ds, TABLA)
        For Each dr In ds.Tables(0).Rows
            fld_date.Text = dr("fld_fecha")
            fld_descripcion.Text = dr("fld_descripcion")
            fld_monto.Text = Format(dr("fld_monto"), "C2")

            idbanco = dr("fld_id_banco")

        Next
        ds.Dispose()
        da.Dispose()
        LOAD_DATA(idbanco)
        idbanco = Nothing
    End Sub 'LOAD DATA FROM DATA BASE "TBL_BANCO"
    Private Sub SAVE_DATA()
        If VALIDA_DATA() = False Then Exit Sub

        Dim idTipoTrans = SCALAR_NUM("SELECT IdTipo FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & Me.Text & "'")
        If Me.Text = "ND Bancaria" Then
            If fld_id_doc.Text = "0" Then

                Dim idTran = CargarFrmInterfas(CtaContableTxt.Text, ReturnDescripcion(CtaContableTxt.Text), 0, CDbl(fld_monto.Text), 0, "Nota de Débito Banco", fld_descripcion.Text, fld_date.Value, idTipoTrans)

                If idTran > 0 Then
                    Dim idDoc = guardarDoc("tbl_nd_bancaria", "SI")
                    create_row_estado_banco(FLD_CODIGO.Text, CDbl(fld_monto.Text), "ND", CStr(UltimoID("tbl_nd_bancaria", "fld_id_doc")), fld_descripcion.Text, fld_date.Value.Date)
                    NON_QUERY("UPDATE tbl_interfascontabletransacciones SET TransIDDoc=" & idDoc & " WHERE TransID=" & idTran & "")
                Else
                    Alerta("La operación ha sido cancelada")
                    Return
                End If
            End If

        ElseIf Me.Text = "NC Bancaria" Then
            If fld_id_doc.Text = "0" Then

                Dim idTran = CargarFrmInterfas(CtaContableTxt.Text, ReturnDescripcion(CtaContableTxt.Text), CDbl(fld_monto.Text), 0, 0, "Nota de Crédito Banco", fld_descripcion.Text, fld_date.Value, idTipoTrans)

                If idTran > 0 Then
                    Dim idDoc = guardarDoc("tbl_nc_bancaria", "SI")
                    create_row_estado_banco(FLD_CODIGO.Text, CDbl(fld_monto.Text), "NC", CStr(UltimoID("tbl_nc_bancaria", "fld_id_doc")), fld_descripcion.Text, fld_date.Value.Date)

                    NON_QUERY("UPDATE tbl_interfascontabletransacciones SET TransIDDoc=" & idDoc & " WHERE TransID=" & idTran & "")
                Else
                    Alerta("La operación ha sido cancelada")
                    Return
                End If

            End If

        ElseIf Me.Text = "Depósito Bancario" Then

            If fld_id_doc.Text = "0" Then


                Dim idTran = CargarFrmInterfas(CtaContableTxt.Text, ReturnDescripcion(CtaContableTxt.Text), CDbl(fld_monto.Text), 0, 0, "Depósito", fld_descripcion.Text, fld_date.Value, idTipoTrans)
                If idTran > 0 Then
                    Dim idDoc = guardarDoc("tbl_deposito", "SI")
                    create_row_estado_banco(FLD_CODIGO.Text, CDbl(fld_monto.Text), "DEP", CStr(UltimoID("tbl_deposito", "fld_id_doc")), fld_descripcion.Text, fld_date.Value.Date)

                    NON_QUERY("UPDATE tbl_interfascontabletransacciones SET TransIDDoc=" & idDoc & " WHERE TransID=" & idTran & "")
                Else
                    Alerta("La operación ha sido cancelada")
                    Return
                End If

            End If

        End If
        CLEAR_FIELD()
    End Sub

    Private Sub CLEAR_FIELD()
        FLD_CODIGO.Text = ""
        FLD_NOMBRE.Text = ""
        FLD_CUENTA.Text = ""

        FLD_BALANCE.Text = "0.00"
        fld_descripcion.Text = ""
        fld_monto.Text = "0.00"

        fld_id_doc.Text = "0"

    End Sub
    Private Function RETURN_NOMBRE_BANCO(ByVal id_banco As String) As String
        Dim CMD As New MySqlCommand, valor As String
        With CMD
            .CommandText = "SELECT fld_nombre FROM tbl_bancos WHERE fld_codigo='" & id_banco & "'"
            .Connection = conn
            .Connection.Open()
            valor = .ExecuteScalar
            .Connection.Close()
        End With
        CMD = Nothing
        RETURN_NOMBRE_BANCO = valor
    End Function

    Private Sub UPDATE_DOC(ByVal TableName As String, ByVal id_doc As String)

        NON_QUERY("UPDATE " & TableName & " SET fld_id_banco='" & FLD_CODIGO.Text & "', fld_fecha='" & formatDate(fld_date.Value.Date) & "', fld_descripcion='" & fld_descripcion.Text & "', fld_monto=" & CDbl(fld_monto.Text) & " WHERE fld_id_doc=" & id_doc & "")
    End Sub


    Private Sub btn_procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SAVE_DATA()
        CLEAR_FIELD()
    End Sub
    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CLEAR_FIELD()
    End Sub
    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub fld_monto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            fld_descripcion.Focus()
        End If
    End Sub

    Private Sub fld_monto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Dim amount As Decimal = CType(fld_monto.Text, Decimal)
            Me.fld_monto.Text = String.Format("{0:n2}", amount)
        End If
    End Sub



    Private Sub btn_lista_art_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_lista_art.Click
        If FRMS_LIST_BANCOS() = True Then
            LOAD_DATA(Id)
            FillLV()
            fld_monto.Focus()
        End If
    End Sub


    Private Sub fld_monto_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_monto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim amount As Decimal = CType(fld_monto.Text, Decimal)
            Me.fld_monto.Text = String.Format("{0:n2}", amount)
            fld_descripcion.Focus()
        End If
    End Sub

    Private Sub fld_monto_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_monto.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CLEAR_FIELD()
    End Sub

    Private Sub btn_procesar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_procesar.Click
        SAVE_DATA()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim tabla As String
        If Me.Text = "ND Bancaria" Then
            tabla = "tbl_nd_bancaria"
        ElseIf Me.Text = "NC Bancaria" Then
            tabla = "tbl_nc_bancaria"
        ElseIf Me.Text = "Depósito Bancario" Then
            tabla = "tbl_deposito"
        End If
        If FRMS_LIST_BANCOS() = True Then
            If FRMS_DIARIO_BANCO_LIST(Me.Text, Id, RETURN_NOMBRE_BANCO(Id)) = True Then
                fld_id_doc.Text = Id
                LOAD_DATA_DOC(tabla, fld_id_doc.Text)
            End If
        End If
    End Sub

    Private Sub btn_cerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub


    Private Sub FRM_DIARIO_BANCO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
