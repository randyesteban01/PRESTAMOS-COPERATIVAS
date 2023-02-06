Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing
 
Public Class FRM_NC_CXP

    Inherits System.Windows.Forms.Form
    Dim bce As Single
    Dim Phone As String
    Dim Concep As String
    Dim IdFact As String
    Dim objIniFile As New IniFile(AppPath & "\Settings_Compras_CxP.ini") '/INI FILE
    Friend consulta As Boolean
    Dim categoria As String
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
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents fld_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents fld_id As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents fld_detalle_forma_pago As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFormaDePago As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_NC_CXP))
        Me.Label10 = New System.Windows.Forms.Label
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
        Me.fld_id = New System.Windows.Forms.TextBox
        Me.btnConsulta = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnGuradar = New System.Windows.Forms.Button
        Me.btnNueva = New System.Windows.Forms.Button
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.lblTipo = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.fld_detalle_forma_pago = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtFormaDePago = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(0, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Fecha"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_fecha
        '
        Me.fld_fecha.CustomFormat = "dd / MMM / yyyy"
        Me.fld_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha.Location = New System.Drawing.Point(88, 40)
        Me.fld_fecha.Name = "fld_fecha"
        Me.fld_fecha.Size = New System.Drawing.Size(120, 20)
        Me.fld_fecha.TabIndex = 76
        '
        'txtConcepto
        '
        Me.txtConcepto.BackColor = System.Drawing.Color.White
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Location = New System.Drawing.Point(88, 160)
        Me.txtConcepto.MaxLength = 255
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(456, 64)
        Me.txtConcepto.TabIndex = 62
        Me.txtConcepto.Text = ""
        '
        'txtMonto
        '
        Me.txtMonto.AcceptsTab = True
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.Location = New System.Drawing.Point(88, 136)
        Me.txtMonto.MaxLength = 12
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(456, 20)
        Me.txtMonto.TabIndex = 54
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(0, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Monto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(0, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Bce."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBalance
        '
        Me.txtBalance.AcceptsTab = True
        Me.txtBalance.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtBalance.Location = New System.Drawing.Point(88, 112)
        Me.txtBalance.MaxLength = 12
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(456, 20)
        Me.txtBalance.TabIndex = 52
        Me.txtBalance.Text = "0.00"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(0, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Concepto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusca.ForeColor = System.Drawing.Color.Black
        Me.btnBusca.Image = CType(resources.GetObject("btnBusca.Image"), System.Drawing.Image)
        Me.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBusca.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBusca.Location = New System.Drawing.Point(432, 8)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(112, 56)
        Me.btnBusca.TabIndex = 42
        Me.btnBusca.Text = "&Lista de Proveedores"
        Me.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtFullName
        '
        Me.TxtFullName.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.TxtFullName.Location = New System.Drawing.Point(88, 88)
        Me.TxtFullName.Name = "TxtFullName"
        Me.TxtFullName.ReadOnly = True
        Me.TxtFullName.Size = New System.Drawing.Size(456, 20)
        Me.TxtFullName.TabIndex = 7
        Me.TxtFullName.Text = ""
        '
        'TxtCustomerID
        '
        Me.TxtCustomerID.AcceptsTab = True
        Me.TxtCustomerID.BackColor = System.Drawing.Color.White
        Me.TxtCustomerID.Location = New System.Drawing.Point(88, 64)
        Me.TxtCustomerID.MaxLength = 12
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.Size = New System.Drawing.Size(120, 20)
        Me.TxtCustomerID.TabIndex = 4
        Me.TxtCustomerID.Text = ""
        '
        'LblCliente
        '
        Me.LblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblCliente.Location = New System.Drawing.Point(0, 88)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(80, 16)
        Me.LblCliente.TabIndex = 6
        Me.LblCliente.Text = "Proveedor"
        Me.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCodigo
        '
        Me.LblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblCodigo.Location = New System.Drawing.Point(0, 64)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(80, 16)
        Me.LblCodigo.TabIndex = 5
        Me.LblCodigo.Text = "Código"
        Me.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_id
        '
        Me.fld_id.AcceptsTab = True
        Me.fld_id.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fld_id.Location = New System.Drawing.Point(24, 336)
        Me.fld_id.MaxLength = 12
        Me.fld_id.Name = "fld_id"
        Me.fld_id.ReadOnly = True
        Me.fld_id.Size = New System.Drawing.Size(112, 20)
        Me.fld_id.TabIndex = 78
        Me.fld_id.Text = "0"
        Me.fld_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_id.Visible = False
        '
        'btnConsulta
        '
        Me.btnConsulta.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulta.ForeColor = System.Drawing.Color.Black
        Me.btnConsulta.Image = CType(resources.GetObject("btnConsulta.Image"), System.Drawing.Image)
        Me.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsulta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConsulta.Location = New System.Drawing.Point(232, 304)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(136, 56)
        Me.btnConsulta.TabIndex = 51
        Me.btnConsulta.Text = "C&onsultar / ReImprimir"
        Me.btnConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCerrar.Location = New System.Drawing.Point(472, 304)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 49
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuradar
        '
        Me.btnGuradar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuradar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuradar.ForeColor = System.Drawing.Color.Black
        Me.btnGuradar.Image = CType(resources.GetObject("btnGuradar.Image"), System.Drawing.Image)
        Me.btnGuradar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuradar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGuradar.Location = New System.Drawing.Point(160, 304)
        Me.btnGuradar.Name = "btnGuradar"
        Me.btnGuradar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuradar.TabIndex = 48
        Me.btnGuradar.Text = "&Guardar"
        Me.btnGuradar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNueva
        '
        Me.btnNueva.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNueva.ForeColor = System.Drawing.Color.Black
        Me.btnNueva.Image = CType(resources.GetObject("btnNueva.Image"), System.Drawing.Image)
        Me.btnNueva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNueva.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNueva.Location = New System.Drawing.Point(88, 304)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(72, 56)
        Me.btnNueva.TabIndex = 47
        Me.btnNueva.Text = "&Nueva"
        Me.btnNueva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblTipo
        '
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(0, 8)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(520, 23)
        Me.lblTipo.TabIndex = 79
        Me.lblTipo.Text = "REGISTRO DE FACTURA"
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(-8, 256)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Detalle"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_detalle_forma_pago
        '
        Me.fld_detalle_forma_pago.BackColor = System.Drawing.Color.White
        Me.fld_detalle_forma_pago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_detalle_forma_pago.Location = New System.Drawing.Point(88, 256)
        Me.fld_detalle_forma_pago.Multiline = True
        Me.fld_detalle_forma_pago.Name = "fld_detalle_forma_pago"
        Me.fld_detalle_forma_pago.Size = New System.Drawing.Size(272, 40)
        Me.fld_detalle_forma_pago.TabIndex = 82
        Me.fld_detalle_forma_pago.Text = "N/A"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(-8, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Forma de pago"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFormaDePago
        '
        Me.txtFormaDePago.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.txtFormaDePago.ForeColor = System.Drawing.Color.White
        Me.txtFormaDePago.ItemHeight = 13
        Me.txtFormaDePago.Items.AddRange(New Object() {"CHEQUE", "TARJETA", "EFECTIVO"})
        Me.txtFormaDePago.Location = New System.Drawing.Point(88, 232)
        Me.txtFormaDePago.Name = "txtFormaDePago"
        Me.txtFormaDePago.Size = New System.Drawing.Size(272, 21)
        Me.txtFormaDePago.TabIndex = 81
        Me.txtFormaDePago.Text = "EFECTIVO"
        '
        'FRM_NC_CXP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(562, 379)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.fld_detalle_forma_pago)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFormaDePago)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuradar)
        Me.Controls.Add(Me.TxtCustomerID)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.TxtFullName)
        Me.Controls.Add(Me.fld_id)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.fld_fecha)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.LblCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBusca)
        Me.Controls.Add(Me.lblTipo)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_NC_CXP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota de Crédito CxP"
        Me.ResumeLayout(False)

    End Sub

#End Region

    '/PROPETIES OF FORM
    Private Sub FRM_NC_CXP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
    End Sub
    Private Sub FRM_NC_CXP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    '/SUB PROGRAMAS

    Private Sub LOAD_PROVEEDOR(ByVal ids As Integer)
        NON_QUERY("CALL set_bce_proveedor(" & ids & ")")
        Dim dsCustomer As New DataSet
        Dim daCustomer As MySqlDataAdapter
        Dim dr As DataRow

        daCustomer = New MySqlDataAdapter("SELECT * FROM tbl_Supplier", conn)

        daCustomer.Fill(dsCustomer, "tbl_Supplier")

        With dsCustomer.Tables(0) 'Cuando usamo el metodo find debemos manualmente esp. el primarykey
            .PrimaryKey = New DataColumn() {.Columns("fldSupplierID")}
        End With

        dr = dsCustomer.Tables(0).Rows.Find(ids)


        If Not (dr Is Nothing) Then
            TxtCustomerID.Text = dr("fldSupplierID")
            TxtFullName.Text = dr("fldCompany")

            txtBalance.Text = Format(dr("fldBalance"), "C2")
            txtMonto.Focus()
            categoria = dr("fld_clasificacion")
        Else
            Alerta("No se encontró el proveedor, verifique el código")
        End If
        dsCustomer.Reset()
        dsCustomer.Dispose()
        daCustomer.Dispose()


    End Sub
    Private Sub SAVE_DATA()
        Dim CTA_DR As String, CTA_CR As String, ID_tras As Integer
        Dim objIniFile As New IniFile(AppPath & "\Settings_Contabilidad.ini") '/INI FILE
        Dim TIPE As String
        Dim DOC_AFECTADO As String

        SAVE_NC()
        Dim lastCod = UltimoID("tbl_nc_cxp", "fld_id") '/CREA EL CODIGO QUE SE VERA EN EL ESTADO DE CTAS
        create_row_estado_proveedor(TxtCustomerID.Text, CDbl(txtMonto.Text), "NCCXP", CStr(lastCod), txtConcepto.Text, fld_fecha.Value.Date)

        InterfarContableAutomatico("Cuenta por Pagar", "Nota de Crédito(Facturas)", fld_fecha.Value.Date, CDec(txtMonto.Text), lastCod, txtConcepto.Text)

        If lblTipo.Text = "INGRESO A CAJA DE CUENTA POR PAGAR" Then
            NON_QUERY("INSERT INTO tbl_recibo_ingresos_cxc (fld_forma_pago,fld_detalle_forma_pago,fld_id_cliente_ri,fld_date,fld_Description,fld_monto,fld_fact_afectado,fdl_nd_afectado,fld_User,fld_Estado,fld_id_prestamo, fld_concepto, fld_interes_cobrado, fld_capital_cobrado, fld_mora_cobrada, fld_socio) VALUES('" & txtFormaDePago.Text & "','" & fld_detalle_forma_pago.Text & "',0,Now(),'" & txtConcepto.Text & "'," & CDec(txtMonto.Text) & ",'0','0','" & User(0) & "','NEW',0,'" & txtConcepto.Text & "',0, 0, 0,'" & TxtFullName.Text & "')")
        End If

        ImprimirDoc(lastCod)

        ClearField()

    End Sub
    Private Sub SAVE_NC()

        Dim FirstInvoice = objIniFile.GetString("COMPANY", "First NCCXP", "(none)")


        Dim nr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_nc_cxp", conn)
        da.Fill(ds, "tbl_nc_cxp")

        nr = ds.Tables(0).NewRow


        'nr("fld_ncf_nc_cxp") = "A0100100" & CStr(ncf("Notas de Crédito"))
        nr("fld_proveedor_id_nc") = CInt(TxtCustomerID.Text)
        nr("fld_fecha") = "'" & formatDate(fld_fecha.Value) & "'"
        nr("fld_concepto") = txtConcepto.Text
        nr("fld_monto") = CDbl(txtMonto.Text)
        nr("fld_abono") = 0
        nr("fld_balance") = CDbl(txtMonto.Text)
        nr("fld_user") = User(0)
        nr("fldStatus") = "N"
        nr("fld_chk") = "True"
        nr("fld_ultimo_abono") = 0

        ds.Tables(0).Rows.Add(nr)


        conn.Open()
        Dim cmd As New MySqlCommandBuilder(da)
        da.InsertCommand = cmd.GetInsertCommand
        da.Update(ds, "tbl_nc_cxp")
        ds.AcceptChanges()
        conn.Close()

        ds.Dispose()
        da.Dispose()


    End Sub



    Private Sub LOAD_NC(ByVal id_doc As String)
        Dim dsCustomer As New DataSet
        Dim daCustomer As MySqlDataAdapter
        Dim dr As DataRow



        daCustomer = New MySqlDataAdapter("SELECT * FROM tbl_nc_cxp where fld_id=" & id_doc & "", conn)
        daCustomer.Fill(dsCustomer, "tbl_nc_cxp")

        For Each dr In dsCustomer.Tables(0).Rows
            fld_id.Text = id_doc
            LOAD_PROVEEDOR(dr("fld_proveedor_id_nc"))
            fld_fecha.Value = CDate(dr("fld_fecha"))
            txtConcepto.Text = dr("fld_concepto")
            txtMonto.Text = dr("fld_monto")
            btnGuradar.Enabled = False
        Next


        dsCustomer.Dispose()
        daCustomer.Dispose()


    End Sub
    Private Sub ClearField()
        TxtCustomerID.Text = ""
        TxtFullName.Text = ""
        txtMonto.Text = "0.00"
        txtConcepto.Text = ""
        txtBalance.Text = "0.00"

        btnGuradar.Enabled = True
    End Sub


    Private Sub ImprimirDoc(ByVal IdDoc As Integer)
        PrintDialog1.AllowSomePages = True


        PrintDialog1.ShowHelp = True

        PrintDialog1.Document = docToPrint


        Dim result As DialogResult = PrintDialog1.ShowDialog()

        ' If the result is OK then print the document.
        If (result = Windows.Forms.DialogResult.OK) Then


            Dim ds As New DataSet


            Dim pd As New PrintDocument, strOldPrinter As String
            strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print 


            Dim WshNetwork As Object
            WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
            WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName) 'Set the Default Print 

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_nota_credito_cxp WHERE fld_id=" & IdDoc & "", conn)
            daP1.Fill(ds, "view_nota_credito_cxp")
            Dim dr As DataRow
            For Each dr In ds.Tables(1).Rows
                Dim largo = Len(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")))
                Dim decimales = Mid(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")), largo - 2)

                dr("fld_banco") = Num2Text(dr("fld_monto") - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
            Next

            Dim Report As New RPT_NC_CXP
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
            Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            Report.PrintToPrinter(1, True, 0, 0)




            WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print




        End If
    End Sub




    '/PROPETIES OF TXTBOXES
    Private Sub TxtCustomerID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCustomerID.KeyPress
        If e.KeyChar = Chr(13) Then

            If Trim(TxtCustomerID.Text) = "" Then
            Else
                LOAD_PROVEEDOR(Trim(TxtCustomerID.Text))
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

        Dim asking = Alerta("¿Está seguro que desea continuar?")
        If asking = False Then
            Exit Sub
        End If


        SAVE_DATA()

    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        If FRMS_POPUP_PROVEEDORES() = True Then
            LOAD_PROVEEDOR(Id)
        End If
    End Sub




    Private Sub txtMonto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim amount As Decimal = CType(txtMonto.Text, Decimal)
            Me.txtMonto.Text = String.Format("{0:n2}", amount)
        End If
    End Sub



    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click

        If FRMS_LIST_ND_NC_CXP("NC") = True Then
            LOAD_NC(Id)
        End If


    End Sub
End Class
