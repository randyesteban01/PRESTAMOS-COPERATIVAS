Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing
Public Class FRM_ND_CXC

    Inherits System.Windows.Forms.Form
    Dim bce As Single
    Dim Phone As String
    Dim Concep As String
    Dim IdFact As String
     '/INI FILE
    Dim CxC As New IniFile(AppPath & "\ND_NC_CxC.ini")
    Friend consulta As Boolean
    Dim categoria As String, ventas As String
    Dim CTA_CONTABLE As String
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
    Friend WithEvents TxtFullName As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents LblCliente As System.Windows.Forms.Label
    Friend WithEvents LblCodigo As System.Windows.Forms.Label
    Friend WithEvents btnBusca As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuradar As System.Windows.Forms.Button
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents fld_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents fld_id As System.Windows.Forms.TextBox
    Friend WithEvents cbEgresoCaja As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_ND_CXC))
        Me.fld_id = New System.Windows.Forms.TextBox
        Me.fld_fecha = New System.Windows.Forms.DateTimePicker
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBusca = New System.Windows.Forms.Button
        Me.TxtFullName = New System.Windows.Forms.TextBox
        Me.TxtCustomerID = New System.Windows.Forms.TextBox
        Me.LblCliente = New System.Windows.Forms.Label
        Me.LblCodigo = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnConsulta = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnImprime = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnGuradar = New System.Windows.Forms.Button
        Me.btnNueva = New System.Windows.Forms.Button
        Me.cbEgresoCaja = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'fld_id
        '
        Me.fld_id.Location = New System.Drawing.Point(240, 64)
        Me.fld_id.Name = "fld_id"
        Me.fld_id.TabIndex = 18
        Me.fld_id.Text = "0"
        Me.fld_id.Visible = False
        '
        'fld_fecha
        '
        Me.fld_fecha.CustomFormat = "dd / MMM / yyyy"
        Me.fld_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha.Location = New System.Drawing.Point(416, 16)
        Me.fld_fecha.Name = "fld_fecha"
        Me.fld_fecha.Size = New System.Drawing.Size(120, 20)
        Me.fld_fecha.TabIndex = 15
        '
        'txtConcepto
        '
        Me.txtConcepto.BackColor = System.Drawing.Color.White
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Location = New System.Drawing.Point(56, 88)
        Me.txtConcepto.MaxLength = 255
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(480, 120)
        Me.txtConcepto.TabIndex = 3
        Me.txtConcepto.Text = ""
        '
        'txtMonto
        '
        Me.txtMonto.AcceptsTab = True
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.Location = New System.Drawing.Point(56, 64)
        Me.txtMonto.MaxLength = 12
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(152, 20)
        Me.txtMonto.TabIndex = 2
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(-12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Monto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(352, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Bce."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'txtBalance
        '
        Me.txtBalance.AcceptsTab = True
        Me.txtBalance.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.txtBalance.Location = New System.Drawing.Point(424, 64)
        Me.txtBalance.MaxLength = 12
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(112, 20)
        Me.txtBalance.TabIndex = 16
        Me.txtBalance.Text = "0.00"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBalance.Visible = False
        '
        'Label1
        '
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(-12, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Concepto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.SystemColors.Control
        Me.btnBusca.ForeColor = System.Drawing.Color.Black
        Me.btnBusca.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBusca.Location = New System.Drawing.Point(208, 16)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(88, 20)
        Me.btnBusca.TabIndex = 0
        Me.btnBusca.Text = "&Buscar Cliente"
        '
        'TxtFullName
        '
        Me.TxtFullName.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.TxtFullName.Location = New System.Drawing.Point(56, 40)
        Me.TxtFullName.Name = "TxtFullName"
        Me.TxtFullName.ReadOnly = True
        Me.TxtFullName.Size = New System.Drawing.Size(480, 20)
        Me.TxtFullName.TabIndex = 13
        Me.TxtFullName.Text = ""
        '
        'TxtCustomerID
        '
        Me.TxtCustomerID.AcceptsTab = True
        Me.TxtCustomerID.BackColor = System.Drawing.Color.White
        Me.TxtCustomerID.Location = New System.Drawing.Point(56, 16)
        Me.TxtCustomerID.MaxLength = 12
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.Size = New System.Drawing.Size(152, 20)
        Me.TxtCustomerID.TabIndex = 1
        Me.TxtCustomerID.Text = ""
        '
        'LblCliente
        '
        Me.LblCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblCliente.Location = New System.Drawing.Point(-12, 40)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(64, 16)
        Me.LblCliente.TabIndex = 10
        Me.LblCliente.Text = "Cliente"
        Me.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCodigo
        '
        Me.LblCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblCodigo.Location = New System.Drawing.Point(-12, 16)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(64, 16)
        Me.LblCodigo.TabIndex = 9
        Me.LblCodigo.Text = "Código"
        Me.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(296, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Fecha de Servidor"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnConsulta
        '
        Me.btnConsulta.BackColor = System.Drawing.SystemColors.Control
        Me.btnConsulta.ForeColor = System.Drawing.Color.Black
        Me.btnConsulta.Image = CType(resources.GetObject("btnConsulta.Image"), System.Drawing.Image)
        Me.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsulta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConsulta.Location = New System.Drawing.Point(200, 248)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(72, 56)
        Me.btnConsulta.TabIndex = 6
        Me.btnConsulta.Text = "C&onsultar"
        Me.btnConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprime.ForeColor = System.Drawing.Color.Black
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprime.Location = New System.Drawing.Point(272, 248)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(72, 56)
        Me.btnImprime.TabIndex = 7
        Me.btnImprime.Text = "&Imprimir"
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCerrar.Location = New System.Drawing.Point(456, 248)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuradar
        '
        Me.btnGuradar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuradar.ForeColor = System.Drawing.Color.Black
        Me.btnGuradar.Image = CType(resources.GetObject("btnGuradar.Image"), System.Drawing.Image)
        Me.btnGuradar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuradar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGuradar.Location = New System.Drawing.Point(128, 248)
        Me.btnGuradar.Name = "btnGuradar"
        Me.btnGuradar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuradar.TabIndex = 4
        Me.btnGuradar.Text = "&Guardar"
        Me.btnGuradar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNueva
        '
        Me.btnNueva.BackColor = System.Drawing.SystemColors.Control
        Me.btnNueva.ForeColor = System.Drawing.Color.Black
        Me.btnNueva.Image = CType(resources.GetObject("btnNueva.Image"), System.Drawing.Image)
        Me.btnNueva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNueva.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNueva.Location = New System.Drawing.Point(56, 248)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(72, 56)
        Me.btnNueva.TabIndex = 5
        Me.btnNueva.Text = "&Nueva"
        Me.btnNueva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cbEgresoCaja
        '
        Me.cbEgresoCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEgresoCaja.Location = New System.Drawing.Point(56, 216)
        Me.cbEgresoCaja.Name = "cbEgresoCaja"
        Me.cbEgresoCaja.Size = New System.Drawing.Size(272, 24)
        Me.cbEgresoCaja.TabIndex = 19
        Me.cbEgresoCaja.Text = "Generar Egreso de Caja"
        Me.cbEgresoCaja.Visible = False
        '
        'FRM_ND_CXC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(538, 307)
        Me.Controls.Add(Me.cbEgresoCaja)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuradar)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.btnImprime)
        Me.Controls.Add(Me.LblCliente)
        Me.Controls.Add(Me.TxtCustomerID)
        Me.Controls.Add(Me.TxtFullName)
        Me.Controls.Add(Me.btnBusca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.fld_fecha)
        Me.Controls.Add(Me.fld_id)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_ND_CXC"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ND y/o NC"
        Me.ResumeLayout(False)

    End Sub

#End Region

    '/PROPETIES OF FORM
    Private Sub FRM_ND_CXC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        fld_fecha.Value = SCALAR_STRING("SELECT DATE(Now())")

    End Sub
    Private Sub FRM_ND_CXC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub
    Private Sub FRM_ND_CXC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    '/SUB PROGRAMAS

    Private Sub LOAD_CLIENTES(ByVal ids As String)

        Dim dsCustomer As New DataSet
        Dim daCustomer As MySqlDataAdapter
        Dim dr As DataRow

        daCustomer = New MySqlDataAdapter("SELECT * FROM tbl_clientes", conn)

        daCustomer.Fill(dsCustomer, "tbl_clientes")

        With dsCustomer.Tables(0) 'Cuando usamo el metodo find debemos manualmente esp. el primarykey
            .PrimaryKey = New DataColumn() {.Columns("fld_id")}
        End With

        dr = dsCustomer.Tables(0).Rows.Find(ids)


        If Not (dr Is Nothing) Then
            TxtCustomerID.Text = dr("fld_id")
            TxtFullName.Text = dr("fld_FullName")
            Phone = dr("fld_Phone")
            txtBalance.Text = Format(dr("fld_Bce"), "C2")
            txtMonto.Focus()

        Else
            Alerta("No se encontró el cliente, verifique el código")
        End If
        dsCustomer.Reset()
        dsCustomer.Dispose()
        daCustomer.Dispose()


    End Sub
    Private Sub SAVE_DATA()
        SAVE_ND()
        Dim lastCod = UltimoID("tbl_nd_cxc", "fld_id_nd_cxc") '/CREA EL CODIGO QUE SE VERA EN EL ESTADO DE CTAS
        CREA_CUOTAS("ND-" & CStr(lastCod), CDbl(txtMonto.Text), CDbl(txtMonto.Text), 0)
        create_row_estado_cliente(TxtCustomerID.Text, CDbl(txtMonto.Text), "NDCXC", CStr(lastCod), txtConcepto.Text, formatDate(fld_fecha.Value.Date))
        If cbEgresoCaja.Checked = True Then
            NON_QUERY("INSERT INTO tbl_recibo_egresos (fldFecha, fldTipo, fldIdTipo, fldEntregado, fldConcepto, fldMonto, fldMontoLetra, fldUsuario) VALUES(Now(),'PROVEEDORES'," & TxtCustomerID.Text & " ,'" & TxtFullName.Text & "','" & txtConcepto.Text & "'," & CDbl(txtMonto.Text) & ",'','" & User(0) & "')")
        End If
    End Sub
    Private Sub SAVE_ND()

        Dim nr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_nd_cxc", conn)
        da.Fill(ds, "tbl_nd_cxc")

        nr = ds.Tables("tbl_nd_cxc").NewRow

        nr("fld_cliente_id_nd") = CInt(TxtCustomerID.Text)


        '' nr("fld_fecha") = "'" & formatDate(fld_fecha.Value) & "'"
        ''Autor: EESCOBAR
        ''Fecha: 25/01/2023
        ''Descripcion: Error de conversion en fechas al momento de guardar
        ''Mejora: No es neceario concatenar comillas simples al inicio y final del campo fecha.
        nr("fld_fecha") = formatDate(fld_fecha.Value)

        nr("fld_concepto") = txtConcepto.Text
        nr("fld_monto") = CDbl(txtMonto.Text)
        nr("fld_abono") = 0
        nr("fld_balance") = CDbl(txtMonto.Text)
        nr("fld_user") = User(0)
        nr("fld_status_nd") = "N"

        ds.Tables(0).Rows.Add(nr)


        conn.Open()
        Dim cmd As New MySqlCommandBuilder(da)
        da.InsertCommand = cmd.GetInsertCommand
        da.Update(ds, "tbl_nd_cxc")
        ds.AcceptChanges()
        conn.Close()

        ds.Dispose()
        da.Dispose()


    End Sub
    Private Sub CREA_CUOTAS(ByVal no_cuotas As String, ByVal monto_cuota As Double, ByVal capital_cuotas As Double, ByVal interes_cuota As Double)

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "INSERT INTO tbl_cuotas (fld_no_cuotas,fld_id_del_cliente_cuotas,fld_id_del_prestamo,fld_fecha_entrega_cuotas,fld_fecha_termina_cuotas,fld_capital_cuota,fld_interes_cuota,fld_monto_cuotas,fld_abono_cuotas,fld_balance_cuotas,fld_usuario_cuotas,fld_status_cuotas,fld_pendiente_amortizar,fld_total_amortizado, fld_capital_cuota_abono, fld_capital_cuota_balance,fld_interes_cuota_abono,fld_interes_cuota_balance,fld_fecha_ultimo_abono_cuotas,fld_monto_mora, fld_abono_mora, fld_balance_mora, fld_ultimo_abono_mora,fld_ultimo_abono_interes,fld_ultimo_abono_capital,fld_socio,fld_tipo_cuotas,fld_cant_cuotas) VALUES('" & no_cuotas & "'," & CInt(TxtCustomerID.Text) & ", 0, '" & formatDate(fld_fecha.Value.Date) & "','" & formatDate(fld_fecha.Value.Date) & "'," & capital_cuotas & "," & interes_cuota & ", " & monto_cuota & ", 0, " & monto_cuota & ",'" & User(0) & "', 'Nueva',0,0,0," & capital_cuotas & ",0," & interes_cuota & ",'" & formatDate(fld_fecha.Value.Date) & "',0,0,0,0,0,0,'','ND',0)"
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()

    End Sub




    Private Sub PRINT_DOC(ByVal TIPO As String, ByVal field_id As String)

        Dim PrintDialog1 As New PrintDialog
        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        PrintDialog1.Document = docToPrint

        Dim result As DialogResult = PrintDialog1.ShowDialog()

        ' If the result is OK then print the document.
        If (result = Windows.Forms.DialogResult.OK) Then



            Dim pd As New PrintDocument, strOldPrinter As String
            strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print 


            Dim WshNetwork As Object
            WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
            WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName) 'Set the Default Print 


            Dim ds As New DataSet

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM " & TIPO & " WHERE " & field_id & "=" & fld_id.Text & "", conn)
            daP1.Fill(ds, TIPO)

            Dim daP2 As New MySqlDataAdapter("SELECT * FROM tbl_clientes WHERE fld_id=" & TxtCustomerID.Text & "", conn)
            daP2.Fill(ds, "tbl_clientes")


            Dim Report As New RPT_ND_CXC
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
            Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, 0, 0)


            WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print




        End If




    End Sub

    Private Sub LOAD_ND(ByVal id_doc As String)
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim dr As DataRow



        da = New MySqlDataAdapter("SELECT * FROM tbl_nd_cxc where fld_id_nd_cxc=" & id_doc & "", conn)
        da.Fill(ds, "tbl_nd_cxc")


        For Each dr In ds.Tables(0).Rows
            fld_id.Text = id_doc
            txtConcepto.Text = dr("fld_concepto")
            fld_fecha.Value = dr("fld_fecha")
            txtMonto.Text = dr("fld_monto")

            LOAD_CLIENTES(dr("fld_cliente_id_nd"))
            btnGuradar.Enabled = False
        Next

        da.Dispose()
        ds.Dispose()



    End Sub


    Private Sub ClearField()
        TxtCustomerID.Text = ""
        TxtFullName.Text = ""
        txtMonto.Text = "0.00"
        txtConcepto.Text = ""
        txtBalance.Text = "0.00"

    End Sub



    '/PROPETIES OF TXTBOXES
    Private Sub TxtCustomerID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCustomerID.KeyPress
        If e.KeyChar = Chr(13) Then

            If Trim(TxtCustomerID.Text) = "" Then
            Else
                LOAD_CLIENTES(Trim(TxtCustomerID.Text))
            End If

        End If

    End Sub
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If e.KeyChar = Chr(13) Then
            txtConcepto.Focus()
        End If
    End Sub

    '/PROPETIES OF BOTTONS

    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        ClearField()
        btnGuradar.Enabled = True
        TxtCustomerID.Focus()
    End Sub
    Private Sub btnGuradar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuradar.Click


        If Trim(TxtFullName.Text) = "" Then
            TxtFullName.Focus()
            Alerta("Aun no ha buscado los datos del cliente")
            Exit Sub
        ElseIf Trim(txtMonto.Text) = "" Or Val(txtMonto.Text) = 0 Then
            txtMonto.Focus()
            Alerta("Aun no ha digitado el monto")
            Exit Sub
        ElseIf Trim(txtConcepto.Text) = "" Then
            txtConcepto.Focus()
            Alerta("Aun no ha digitado el concepto")
            Exit Sub
        End If

        If Alerta("¿Está seguro que desea continuar?") = False Then
            Exit Sub
        End If


        SAVE_DATA()

        fld_id.Text = UltimoID("tbl_nd_cxc", "fld_id_nd_cxc")
        InterfarContableAutomatico("Cuenta por Cobrar", "Nota de Débito", fld_fecha.Value.Date, CDec(txtMonto.Text), CInt(fld_id.Text), txtConcepto.Text)
        PRINT_DOC("tbl_nd_cxc", "fld_id_nd_cxc")
        ClearField()



    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            LOAD_CLIENTES(Id)
            txtMonto.Focus()
        End If
    End Sub

    Private Sub txtMonto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim amount As Decimal = CType(txtMonto.Text, Decimal)
            Me.txtMonto.Text = String.Format("{0:n2}", amount)
        End If

    End Sub
    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click

        If FRMS_LIST_ND_NC_CXC("ND", "TODOS") = True Then
            LOAD_ND(Id)
        End If

    End Sub

    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime.Click

        PRINT_DOC("tbl_nd_cxc", "fld_id_nd_cxc")

    End Sub


End Class
