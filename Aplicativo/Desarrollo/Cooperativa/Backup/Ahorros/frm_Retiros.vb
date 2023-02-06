Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class FRM_RETIROS
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
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoCapital As System.Windows.Forms.TextBox
    Friend WithEvents dtpUltimoRetiro As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDiasAcumulados As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIDCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSaldoInteres As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtInteresRetirado As System.Windows.Forms.TextBox
    Friend WithEvents txtCapitalRetirado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRetirado As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents txtIdAhorro As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Friend WithEvents cmbCajas As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cambioTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents totalTxt As System.Windows.Forms.TextBox
    Friend WithEvents resCincoTxt As System.Windows.Forms.TextBox
    Friend WithEvents resDiezTxt As System.Windows.Forms.TextBox
    Friend WithEvents resVeiticincoTxt As System.Windows.Forms.TextBox
    Friend WithEvents resCincuentaTxt As System.Windows.Forms.TextBox
    Friend WithEvents resCienTxt As System.Windows.Forms.TextBox
    Friend WithEvents resDocientoTxt As System.Windows.Forms.TextBox
    Friend WithEvents resQuinientoTxt As System.Windows.Forms.TextBox
    Friend WithEvents resMilTxt As System.Windows.Forms.TextBox
    Friend WithEvents resDosmilTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cheque As System.Windows.Forms.TextBox
    Friend WithEvents cincoTxt As System.Windows.Forms.TextBox
    Friend WithEvents diezTxt As System.Windows.Forms.TextBox
    Friend WithEvents venticincoTxt As System.Windows.Forms.TextBox
    Friend WithEvents cincuentaTxt As System.Windows.Forms.TextBox
    Friend WithEvents cienTxt As System.Windows.Forms.TextBox
    Friend WithEvents docientoTxt As System.Windows.Forms.TextBox
    Friend WithEvents quinientoTxt As System.Windows.Forms.TextBox
    Friend WithEvents milTxt As System.Windows.Forms.TextBox
    Friend WithEvents dosmilTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents resUnoTxt As System.Windows.Forms.TextBox
    Friend WithEvents unoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_RETIROS))
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.txtCuentaNo = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblId = New System.Windows.Forms.Label
        Me.lblCedula = New System.Windows.Forms.Label
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSaldoCapital = New System.Windows.Forms.TextBox
        Me.dtpUltimoRetiro = New System.Windows.Forms.DateTimePicker
        Me.txtDiasAcumulados = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSaldoInteres = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtIdAhorro = New System.Windows.Forms.TextBox
        Me.txtIDCliente = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.lv = New System.Windows.Forms.ListView
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtInteresRetirado = New System.Windows.Forms.TextBox
        Me.txtCapitalRetirado = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTotalRetirado = New System.Windows.Forms.TextBox
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.btnImprime = New System.Windows.Forms.Button
        Me.cmbCajas = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.resUnoTxt = New System.Windows.Forms.TextBox
        Me.unoTxt = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.cambioTxt = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.totalTxt = New System.Windows.Forms.TextBox
        Me.resCincoTxt = New System.Windows.Forms.TextBox
        Me.resDiezTxt = New System.Windows.Forms.TextBox
        Me.resVeiticincoTxt = New System.Windows.Forms.TextBox
        Me.resCincuentaTxt = New System.Windows.Forms.TextBox
        Me.resCienTxt = New System.Windows.Forms.TextBox
        Me.resDocientoTxt = New System.Windows.Forms.TextBox
        Me.resQuinientoTxt = New System.Windows.Forms.TextBox
        Me.resMilTxt = New System.Windows.Forms.TextBox
        Me.resDosmilTxt = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cheque = New System.Windows.Forms.TextBox
        Me.cincoTxt = New System.Windows.Forms.TextBox
        Me.diezTxt = New System.Windows.Forms.TextBox
        Me.venticincoTxt = New System.Windows.Forms.TextBox
        Me.cincuentaTxt = New System.Windows.Forms.TextBox
        Me.cienTxt = New System.Windows.Forms.TextBox
        Me.docientoTxt = New System.Windows.Forms.TextBox
        Me.quinientoTxt = New System.Windows.Forms.TextBox
        Me.milTxt = New System.Windows.Forms.TextBox
        Me.dosmilTxt = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Location = New System.Drawing.Point(96, 80)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(304, 20)
        Me.txtCedula.TabIndex = 16
        Me.txtCedula.Text = ""
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(96, 56)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(304, 20)
        Me.txtCliente.TabIndex = 14
        Me.txtCliente.Text = ""
        '
        'txtCuentaNo
        '
        Me.txtCuentaNo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCuentaNo.Location = New System.Drawing.Point(96, 32)
        Me.txtCuentaNo.Name = "txtCuentaNo"
        Me.txtCuentaNo.Size = New System.Drawing.Size(200, 20)
        Me.txtCuentaNo.TabIndex = 12
        Me.txtCuentaNo.Text = "0"
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(24, 56)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(64, 16)
        Me.lblNombre.TabIndex = 13
        Me.lblNombre.Text = "Socio"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblId
        '
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblId.Location = New System.Drawing.Point(24, 32)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(64, 16)
        Me.lblId.TabIndex = 11
        Me.lblId.Text = "Cuenta No."
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCedula.Location = New System.Drawing.Point(24, 80)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(64, 16)
        Me.lblCedula.TabIndex = 15
        Me.lblCedula.Text = "Cédula"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(96, 215)
        Me.txtConcepto.MaxLength = 150
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(304, 56)
        Me.txtConcepto.TabIndex = 3
        Me.txtConcepto.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(8, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Tipo Retiro"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSaldoCapital
        '
        Me.txtSaldoCapital.Enabled = False
        Me.txtSaldoCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoCapital.Location = New System.Drawing.Point(96, 127)
        Me.txtSaldoCapital.Name = "txtSaldoCapital"
        Me.txtSaldoCapital.Size = New System.Drawing.Size(304, 26)
        Me.txtSaldoCapital.TabIndex = 20
        Me.txtSaldoCapital.Text = "0.00"
        Me.txtSaldoCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpUltimoRetiro
        '
        Me.dtpUltimoRetiro.CustomFormat = "dd/MMM/yyyy"
        Me.dtpUltimoRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpUltimoRetiro.Location = New System.Drawing.Point(280, 191)
        Me.dtpUltimoRetiro.Name = "dtpUltimoRetiro"
        Me.dtpUltimoRetiro.Size = New System.Drawing.Size(120, 20)
        Me.dtpUltimoRetiro.TabIndex = 25
        '
        'txtDiasAcumulados
        '
        Me.txtDiasAcumulados.Location = New System.Drawing.Point(300, 104)
        Me.txtDiasAcumulados.Name = "txtDiasAcumulados"
        Me.txtDiasAcumulados.ReadOnly = True
        Me.txtDiasAcumulados.TabIndex = 18
        Me.txtDiasAcumulados.Text = ""
        Me.txtDiasAcumulados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(-16, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Saldo de Capital"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(216, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Últ. Retiro"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(200, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Días Acumulados"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTipo
        '
        Me.cmbTipo.Items.AddRange(New Object() {"Retiro de Interes", "Retiro de Capital"})
        Me.cmbTipo.Location = New System.Drawing.Point(96, 191)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 2
        Me.cmbTipo.Text = "Retiro de Interes"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(0, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Saldo de Interes"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSaldoInteres
        '
        Me.txtSaldoInteres.Enabled = False
        Me.txtSaldoInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoInteres.Location = New System.Drawing.Point(96, 159)
        Me.txtSaldoInteres.Name = "txtSaldoInteres"
        Me.txtSaldoInteres.Size = New System.Drawing.Size(304, 26)
        Me.txtSaldoInteres.TabIndex = 22
        Me.txtSaldoInteres.Text = "0.00"
        Me.txtSaldoInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(24, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Nota"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(96, 271)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(304, 26)
        Me.txtMonto.TabIndex = 4
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(0, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Monto del Retiro"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIdAhorro
        '
        Me.txtIdAhorro.Enabled = False
        Me.txtIdAhorro.Location = New System.Drawing.Point(24, 312)
        Me.txtIdAhorro.Name = "txtIdAhorro"
        Me.txtIdAhorro.ReadOnly = True
        Me.txtIdAhorro.Size = New System.Drawing.Size(32, 20)
        Me.txtIdAhorro.TabIndex = 28
        Me.txtIdAhorro.Text = "0"
        Me.txtIdAhorro.Visible = False
        '
        'txtIDCliente
        '
        Me.txtIDCliente.Enabled = False
        Me.txtIDCliente.Location = New System.Drawing.Point(24, 336)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(56, 20)
        Me.txtIDCliente.TabIndex = 29
        Me.txtIDCliente.Text = "0"
        Me.txtIDCliente.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Buscar"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(312, 304)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(168, 304)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(96, 304)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(712, 8)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(536, 256)
        Me.lv.TabIndex = 30
        Me.lv.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(832, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(208, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Monto Interes retirado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'txtInteresRetirado
        '
        Me.txtInteresRetirado.Enabled = False
        Me.txtInteresRetirado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInteresRetirado.Location = New System.Drawing.Point(1048, 264)
        Me.txtInteresRetirado.Name = "txtInteresRetirado"
        Me.txtInteresRetirado.Size = New System.Drawing.Size(200, 26)
        Me.txtInteresRetirado.TabIndex = 27
        Me.txtInteresRetirado.Text = "0.00"
        Me.txtInteresRetirado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtInteresRetirado.Visible = False
        '
        'txtCapitalRetirado
        '
        Me.txtCapitalRetirado.Enabled = False
        Me.txtCapitalRetirado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapitalRetirado.Location = New System.Drawing.Point(1048, 290)
        Me.txtCapitalRetirado.Name = "txtCapitalRetirado"
        Me.txtCapitalRetirado.Size = New System.Drawing.Size(200, 26)
        Me.txtCapitalRetirado.TabIndex = 29
        Me.txtCapitalRetirado.Text = "0.00"
        Me.txtCapitalRetirado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCapitalRetirado.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(832, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(208, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Monto Capital retirado"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(832, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 16)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Monto Total retirado"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'txtTotalRetirado
        '
        Me.txtTotalRetirado.Enabled = False
        Me.txtTotalRetirado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRetirado.Location = New System.Drawing.Point(1048, 320)
        Me.txtTotalRetirado.Name = "txtTotalRetirado"
        Me.txtTotalRetirado.Size = New System.Drawing.Size(200, 26)
        Me.txtTotalRetirado.TabIndex = 31
        Me.txtTotalRetirado.Text = "0.00"
        Me.txtTotalRetirado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalRetirado.Visible = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Imprimir"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Borrar"
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprime.ForeColor = System.Drawing.Color.Black
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprime.Location = New System.Drawing.Point(240, 304)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(72, 56)
        Me.btnImprime.TabIndex = 8
        Me.btnImprime.Text = "&Imprimir"
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmbCajas
        '
        Me.cmbCajas.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.cmbCajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCajas.ForeColor = System.Drawing.Color.White
        Me.cmbCajas.Location = New System.Drawing.Point(96, 8)
        Me.cmbCajas.Name = "cmbCajas"
        Me.cmbCajas.Size = New System.Drawing.Size(304, 21)
        Me.cmbCajas.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(16, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Caja :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.resUnoTxt)
        Me.GroupBox1.Controls.Add(Me.unoTxt)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cambioTxt)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.totalTxt)
        Me.GroupBox1.Controls.Add(Me.resCincoTxt)
        Me.GroupBox1.Controls.Add(Me.resDiezTxt)
        Me.GroupBox1.Controls.Add(Me.resVeiticincoTxt)
        Me.GroupBox1.Controls.Add(Me.resCincuentaTxt)
        Me.GroupBox1.Controls.Add(Me.resCienTxt)
        Me.GroupBox1.Controls.Add(Me.resDocientoTxt)
        Me.GroupBox1.Controls.Add(Me.resQuinientoTxt)
        Me.GroupBox1.Controls.Add(Me.resMilTxt)
        Me.GroupBox1.Controls.Add(Me.resDosmilTxt)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cheque)
        Me.GroupBox1.Controls.Add(Me.cincoTxt)
        Me.GroupBox1.Controls.Add(Me.diezTxt)
        Me.GroupBox1.Controls.Add(Me.venticincoTxt)
        Me.GroupBox1.Controls.Add(Me.cincuentaTxt)
        Me.GroupBox1.Controls.Add(Me.cienTxt)
        Me.GroupBox1.Controls.Add(Me.docientoTxt)
        Me.GroupBox1.Controls.Add(Me.quinientoTxt)
        Me.GroupBox1.Controls.Add(Me.milTxt)
        Me.GroupBox1.Controls.Add(Me.dosmilTxt)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Location = New System.Drawing.Point(408, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 352)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Denominación de Dinero"
        '
        'resUnoTxt
        '
        Me.resUnoTxt.Location = New System.Drawing.Point(168, 240)
        Me.resUnoTxt.Name = "resUnoTxt"
        Me.resUnoTxt.ReadOnly = True
        Me.resUnoTxt.Size = New System.Drawing.Size(144, 20)
        Me.resUnoTxt.TabIndex = 31
        Me.resUnoTxt.Text = "0.00"
        Me.resUnoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'unoTxt
        '
        Me.unoTxt.Location = New System.Drawing.Point(96, 240)
        Me.unoTxt.Name = "unoTxt"
        Me.unoTxt.ReadOnly = True
        Me.unoTxt.Size = New System.Drawing.Size(56, 20)
        Me.unoTxt.TabIndex = 9
        Me.unoTxt.Text = "0"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 240)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 16)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "1.00"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(88, 312)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 16)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "CAMBIO"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cambioTxt
        '
        Me.cambioTxt.Location = New System.Drawing.Point(168, 312)
        Me.cambioTxt.Name = "cambioTxt"
        Me.cambioTxt.ReadOnly = True
        Me.cambioTxt.Size = New System.Drawing.Size(144, 20)
        Me.cambioTxt.TabIndex = 34
        Me.cambioTxt.Text = "0.00"
        Me.cambioTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(88, 288)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "TOTAL"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'totalTxt
        '
        Me.totalTxt.Location = New System.Drawing.Point(168, 288)
        Me.totalTxt.Name = "totalTxt"
        Me.totalTxt.ReadOnly = True
        Me.totalTxt.Size = New System.Drawing.Size(144, 20)
        Me.totalTxt.TabIndex = 32
        Me.totalTxt.Text = "0.00"
        Me.totalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resCincoTxt
        '
        Me.resCincoTxt.Location = New System.Drawing.Point(168, 216)
        Me.resCincoTxt.Name = "resCincoTxt"
        Me.resCincoTxt.ReadOnly = True
        Me.resCincoTxt.Size = New System.Drawing.Size(144, 20)
        Me.resCincoTxt.TabIndex = 30
        Me.resCincoTxt.Text = "0.00"
        Me.resCincoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resDiezTxt
        '
        Me.resDiezTxt.Location = New System.Drawing.Point(168, 192)
        Me.resDiezTxt.Name = "resDiezTxt"
        Me.resDiezTxt.ReadOnly = True
        Me.resDiezTxt.Size = New System.Drawing.Size(144, 20)
        Me.resDiezTxt.TabIndex = 29
        Me.resDiezTxt.Text = "0.00"
        Me.resDiezTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resVeiticincoTxt
        '
        Me.resVeiticincoTxt.Location = New System.Drawing.Point(168, 168)
        Me.resVeiticincoTxt.Name = "resVeiticincoTxt"
        Me.resVeiticincoTxt.ReadOnly = True
        Me.resVeiticincoTxt.Size = New System.Drawing.Size(144, 20)
        Me.resVeiticincoTxt.TabIndex = 28
        Me.resVeiticincoTxt.Text = "0.00"
        Me.resVeiticincoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resCincuentaTxt
        '
        Me.resCincuentaTxt.Location = New System.Drawing.Point(168, 144)
        Me.resCincuentaTxt.Name = "resCincuentaTxt"
        Me.resCincuentaTxt.ReadOnly = True
        Me.resCincuentaTxt.Size = New System.Drawing.Size(144, 20)
        Me.resCincuentaTxt.TabIndex = 27
        Me.resCincuentaTxt.Text = "0.00"
        Me.resCincuentaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resCienTxt
        '
        Me.resCienTxt.Location = New System.Drawing.Point(168, 120)
        Me.resCienTxt.Name = "resCienTxt"
        Me.resCienTxt.ReadOnly = True
        Me.resCienTxt.Size = New System.Drawing.Size(144, 20)
        Me.resCienTxt.TabIndex = 26
        Me.resCienTxt.Text = "0.00"
        Me.resCienTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resDocientoTxt
        '
        Me.resDocientoTxt.Location = New System.Drawing.Point(168, 96)
        Me.resDocientoTxt.Name = "resDocientoTxt"
        Me.resDocientoTxt.ReadOnly = True
        Me.resDocientoTxt.Size = New System.Drawing.Size(144, 20)
        Me.resDocientoTxt.TabIndex = 25
        Me.resDocientoTxt.Text = "0.00"
        Me.resDocientoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resQuinientoTxt
        '
        Me.resQuinientoTxt.Location = New System.Drawing.Point(168, 72)
        Me.resQuinientoTxt.Name = "resQuinientoTxt"
        Me.resQuinientoTxt.ReadOnly = True
        Me.resQuinientoTxt.Size = New System.Drawing.Size(144, 20)
        Me.resQuinientoTxt.TabIndex = 23
        Me.resQuinientoTxt.Text = "0.00"
        Me.resQuinientoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resMilTxt
        '
        Me.resMilTxt.Location = New System.Drawing.Point(168, 48)
        Me.resMilTxt.Name = "resMilTxt"
        Me.resMilTxt.ReadOnly = True
        Me.resMilTxt.Size = New System.Drawing.Size(144, 20)
        Me.resMilTxt.TabIndex = 24
        Me.resMilTxt.Text = "0.00"
        Me.resMilTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resDosmilTxt
        '
        Me.resDosmilTxt.Location = New System.Drawing.Point(168, 24)
        Me.resDosmilTxt.Name = "resDosmilTxt"
        Me.resDosmilTxt.ReadOnly = True
        Me.resDosmilTxt.Size = New System.Drawing.Size(144, 20)
        Me.resDosmilTxt.TabIndex = 22
        Me.resDosmilTxt.Text = "0.00"
        Me.resDosmilTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(88, 264)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "CHEQUE"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cheque
        '
        Me.cheque.Location = New System.Drawing.Point(168, 264)
        Me.cheque.Name = "cheque"
        Me.cheque.ReadOnly = True
        Me.cheque.Size = New System.Drawing.Size(144, 20)
        Me.cheque.TabIndex = 10
        Me.cheque.Text = "0.00"
        Me.cheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cincoTxt
        '
        Me.cincoTxt.Location = New System.Drawing.Point(96, 216)
        Me.cincoTxt.Name = "cincoTxt"
        Me.cincoTxt.ReadOnly = True
        Me.cincoTxt.Size = New System.Drawing.Size(56, 20)
        Me.cincoTxt.TabIndex = 8
        Me.cincoTxt.Text = "0"
        '
        'diezTxt
        '
        Me.diezTxt.Location = New System.Drawing.Point(96, 192)
        Me.diezTxt.Name = "diezTxt"
        Me.diezTxt.ReadOnly = True
        Me.diezTxt.Size = New System.Drawing.Size(56, 20)
        Me.diezTxt.TabIndex = 7
        Me.diezTxt.Text = "0"
        '
        'venticincoTxt
        '
        Me.venticincoTxt.Location = New System.Drawing.Point(96, 168)
        Me.venticincoTxt.Name = "venticincoTxt"
        Me.venticincoTxt.ReadOnly = True
        Me.venticincoTxt.Size = New System.Drawing.Size(56, 20)
        Me.venticincoTxt.TabIndex = 6
        Me.venticincoTxt.Text = "0"
        '
        'cincuentaTxt
        '
        Me.cincuentaTxt.Location = New System.Drawing.Point(96, 144)
        Me.cincuentaTxt.Name = "cincuentaTxt"
        Me.cincuentaTxt.ReadOnly = True
        Me.cincuentaTxt.Size = New System.Drawing.Size(56, 20)
        Me.cincuentaTxt.TabIndex = 5
        Me.cincuentaTxt.Text = "0"
        '
        'cienTxt
        '
        Me.cienTxt.Location = New System.Drawing.Point(96, 120)
        Me.cienTxt.Name = "cienTxt"
        Me.cienTxt.ReadOnly = True
        Me.cienTxt.Size = New System.Drawing.Size(56, 20)
        Me.cienTxt.TabIndex = 4
        Me.cienTxt.Text = "0"
        '
        'docientoTxt
        '
        Me.docientoTxt.Location = New System.Drawing.Point(96, 96)
        Me.docientoTxt.Name = "docientoTxt"
        Me.docientoTxt.ReadOnly = True
        Me.docientoTxt.Size = New System.Drawing.Size(56, 20)
        Me.docientoTxt.TabIndex = 3
        Me.docientoTxt.Text = "0"
        '
        'quinientoTxt
        '
        Me.quinientoTxt.Location = New System.Drawing.Point(96, 72)
        Me.quinientoTxt.Name = "quinientoTxt"
        Me.quinientoTxt.ReadOnly = True
        Me.quinientoTxt.Size = New System.Drawing.Size(56, 20)
        Me.quinientoTxt.TabIndex = 2
        Me.quinientoTxt.Text = "0"
        '
        'milTxt
        '
        Me.milTxt.Location = New System.Drawing.Point(96, 48)
        Me.milTxt.Name = "milTxt"
        Me.milTxt.ReadOnly = True
        Me.milTxt.Size = New System.Drawing.Size(56, 20)
        Me.milTxt.TabIndex = 1
        Me.milTxt.Text = "0"
        '
        'dosmilTxt
        '
        Me.dosmilTxt.Location = New System.Drawing.Point(96, 24)
        Me.dosmilTxt.Name = "dosmilTxt"
        Me.dosmilTxt.ReadOnly = True
        Me.dosmilTxt.Size = New System.Drawing.Size(56, 20)
        Me.dosmilTxt.TabIndex = 0
        Me.dosmilTxt.Text = "0"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 218)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "5.00"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 194)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "10.00"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 170)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "25.00"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 146)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "50.00"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 16)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "100.00"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 98)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 16)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "200.00"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "500.00"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 50)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 16)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "1,000.00"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "2,000.00"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRM_RETIROS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(734, 363)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbCajas)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnImprime)
        Me.Controls.Add(Me.txtTotalRetirado)
        Me.Controls.Add(Me.txtCapitalRetirado)
        Me.Controls.Add(Me.txtInteresRetirado)
        Me.Controls.Add(Me.txtIDCliente)
        Me.Controls.Add(Me.txtIdAhorro)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.txtSaldoInteres)
        Me.Controls.Add(Me.txtDiasAcumulados)
        Me.Controls.Add(Me.txtSaldoCapital)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtCuentaNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpUltimoRetiro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblCedula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_RETIROS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Retiro"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim fechaServidor As DateTime

    '
    Private Sub guardarTransaccionContable(ByVal idDocAfectado As Integer)

        Dim idTipoTrans = SCALAR_NUM("SELECT IdTipo FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & Me.Text & "'")

        NON_QUERY("CALL cont_insert_trans(Now(),'" & txtConcepto.Text & "'," & idTipoTrans & ",'" & User(0) & "'," & idDocAfectado & ",'RETIRO DE AHORRO','" & " Retiro de ahorro a cta. no. " & txtCuentaNo.Text & "')")

        Dim idTras = UltimoID("tbl_interfascontabletransacciones", "TransID")

        Dim ctaContableCaja = SCALAR_STRING("SELECT CtaContable  FROM cajamantenimiento WHERE ID=" & cmbCajas.SelectedValue & "")
        Dim ctaContableSocio = SCALAR_STRING("SELECT ctaContable  FROM tbl_clientes WHERE fld_id=" & txtIDCliente.Text & "")


        'Guardar detalle débito

        Dim DescripcionCuenta = ReturnDescripcion(ctaContableCaja)
        GuardarTransaccionDetalle(idTras, ctaContableCaja, DescripcionCuenta, 0, CDbl(txtMonto.Text))
        'Guardar detalle crédito

        DescripcionCuenta = ReturnDescripcion(ctaContableSocio)
        GuardarTransaccionDetalle(idTras, ctaContableSocio, DescripcionCuenta, CDbl(txtMonto.Text), 0)


    End Sub
    Private Sub sumaTotales()
        Dim total As Double = CDbl(resDosmilTxt.Text) + CDbl(resMilTxt.Text) + CDbl(resQuinientoTxt.Text) + CDbl(resDocientoTxt.Text) + CDbl(resCienTxt.Text) + CDbl(resCincuentaTxt.Text) + CDbl(resVeiticincoTxt.Text) + CDbl(resDiezTxt.Text) + CDbl(resCincoTxt.Text) + CDbl(cheque.Text) + CDbl(unoTxt.Text)
        totalTxt.Text = Format(total, "N2")
        cambioTxt.Text = Format(total - CDbl(txtMonto.Text), "N2")
    End Sub


    Public Sub LlenarLV(ByVal IDCliente As Integer)

        lv.Clear()
        lv.View = View.Details
        lv.LabelEdit = False
        lv.FullRowSelect = True
        lv.GridLines = True
        lv.Sorting = SortOrder.None


        Dim sqlSearch As String
        sqlSearch = "SELECT ID, Fecha, Tipo, Monto, Concepto FROM tbl_ahorros_retiros WHERE IDCliente=" & IDCliente & " ORDER BY Fecha DESC"



        Dim ds As New DataSet
        Dim da As MySqlDataAdapter

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds)
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            If dr("Tipo") = "Retiro de Interes" Then
                txtInteresRetirado.Text = Format(CDec(txtInteresRetirado.Text) + dr("Monto"), "C2")
            Else
                txtCapitalRetirado.Text = Format(CDec(txtCapitalRetirado.Text) + dr("Monto"), "C2")
            End If
        Next


        txtTotalRetirado.Text = Format(CDec(txtCapitalRetirado.Text) + CDec(txtInteresRetirado.Text), "C2")


        Dim columnText(7) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "ID"
        columnText(1) = "Fecha"
        columnText(2) = "Tipo"
        columnText(3) = "Monto"
        columnText(4) = "Concepto"
        columnText(5) = "Monto Prest."
        columnText(6) = ""


        Dim columnWidth(7) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 70
        columnWidth(2) = 100
        columnWidth(3) = 100
        columnWidth(4) = 200
        columnWidth(5) = 100
        columnWidth(6) = 70

        Dim columnAlign(7) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 1 'DERECHA
        columnAlign(4) = 0 'IZQUIERDA
        columnAlign(5) = 1 'DERECHA
        columnAlign(6) = 1 'DERECHA



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


        Next



    End Sub

    Private Sub Nuevo()
        lv.Clear()
        fechaServidor = SCALAR_STRING("SELECT NOW()")   'Busca la fecha del servidor, para calcular los días acumulado
        txtCuentaNo.Text = String.Empty
        txtIdAhorro.Text = 0
        txtIDCliente.Text = 0
        txtCliente.Text = String.Empty
        txtCedula.Text = String.Empty
        dtpUltimoRetiro.Value = fechaServidor
        txtDiasAcumulados.Text = 0
        txtSaldoCapital.Text = Format(0, "C2")
        txtSaldoInteres.Text = Format(0, "C2")
        cmbTipo.Text = "Retiro de Interes"
        txtConcepto.Text = String.Empty
        txtMonto.Text = Format(0, "N2")
        txtInteresRetirado.Text = Format(0, "C2")
        txtCapitalRetirado.Text = Format(0, "C2")
        txtTotalRetirado.Text = Format(0, "C2")

        dosmilTxt.ReadOnly = True
        milTxt.ReadOnly = True
        quinientoTxt.ReadOnly = True
        docientoTxt.ReadOnly = True
        cienTxt.ReadOnly = True
        cincuentaTxt.ReadOnly = True
        venticincoTxt.ReadOnly = True
        diezTxt.ReadOnly = True
        cincoTxt.ReadOnly = True
        unoTxt.ReadOnly = True
        cheque.ReadOnly = True

        dosmilTxt.Text = 0
        milTxt.Text = 0
        quinientoTxt.Text = 0
        docientoTxt.Text = 0
        cienTxt.Text = 0
        cincuentaTxt.Text = 0
        venticincoTxt.Text = 0
        diezTxt.Text = 0
        cincoTxt.Text = 0
        unoTxt.Text = 0
        cheque.Text = 0

        resDosmilTxt.Text = 0
        resMilTxt.Text = 0
        resQuinientoTxt.Text = 0
        resDocientoTxt.Text = 0
        resCienTxt.Text = 0
        resCincuentaTxt.Text = 0
        resVeiticincoTxt.Text = 0
        resDiezTxt.Text = 0
        resCincoTxt.Text = 0
        resUnoTxt.Text = 0
        cheque.Text = 0

        totalTxt.Text = Format(0, "C2")
        cambioTxt.Text = Format(0, "C2")
    End Sub

    Private Sub TipoRetiro()
        If cmbTipo.Text <> "Retiro de Interes" Then
            txtMonto.Enabled = True
            txtMonto.Text = "0.00"
        Else
            txtMonto.Enabled = False
            txtMonto.Text = txtSaldoInteres.Text
        End If
    End Sub

    Private Function validarCampos() As Boolean
        If txtMonto.Text = String.Empty Then txtMonto.Text = "0.00"
        If SCALAR_NUM("SELECT IFNULL(1,0) FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & Me.Text & "'") = 0 Then
            Alerta("El Interfas contable no está configurado, no se puede guardar el documento.")
            Return False
        End If
        If txtIdAhorro.Text = "0" Then
            Alerta("Debe cargar los datos de una cuenta de ahorro")
            txtCuentaNo.Focus()
            Return False
        End If



        If txtConcepto.Text = String.Empty Then
            Alerta("Escriba un concepto por favor")
            txtConcepto.Focus()
            Return False
        End If


        If cmbTipo.Text = "Retiro de Capital" Then
            If CDbl(txtSaldoInteres.Text) > 0 Then
                Alerta("Para hacer retiro de capital, el saldo de interes debe ser igual a cero")
                Return False
            End If
            If CDbl(txtMonto.Text) > CDbl(txtSaldoCapital.Text) Then
                Alerta("No puede retirar más dinero que el Saldo del Capital disponible")
                Return False
            End If


        End If

        If CDbl(txtMonto.Text) = 0 Then
            Alerta("Escriba el monto del retiro")
            txtMonto.Focus()
            Return False
        End If

        If CDbl(txtMonto.Text) < 0 Then
            Alerta("Escriba un valor positivo en Monto del Retiro")
            txtMonto.Focus()
            Return False
        End If


        Return True
    End Function
    Private Sub imprimirDocumento(ByVal idDoc As Integer)
        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        PrintDialog1.Document = docToPrint


        Dim pd As New PrintDocument, strOldPrinter As String
        strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print 


        Dim WshNetwork As Object
        WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")

        'Dim TamañoPersonal = New Printing.PaperSize(PrintDialog1.PrinterSettings.PrinterName, 8.5, 5.5)
        'PrintDialog1.PrinterSettings.DefaultPageSettings.PaperSize = TamañoPersonal
        Dim result As DialogResult = PrintDialog1.ShowDialog()

        ' If the result is OK then print the document.
        If (result = Windows.Forms.DialogResult.OK) Then
            WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName) 'Set the Default Print 
            Dim ds As New DataSet

            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")

            Dim daInv As New MySqlDataAdapter("SELECT ret.ID, cl.fld_id, cl.fld_FullName, cl.fld_Identity, cta.CuentaNo, ret.Fecha, ret.Monto, ret.Concepto, ret.Usuario, mc.Descripcion, dosMil,Mil,Quiniento,Dosciento,Cien,Cincuenta,Veinticinco,Diez,Cinco,Cheque,Uno FROM tbl_clientes AS cl INNER JOIN tbl_ahorros_retiros AS ret ON ret.IDCliente=cl.fld_id INNER JOIN tbl_ahorros_cuentas AS cta ON ret.IDAhorro=cta.ID INNER JOIN cajamantenimiento AS mc ON ret.IdCaja=mc.ID WHERE ret.ID = " & idDoc & "", conn)
            daInv.Fill(ds, "tbl_ahorroretiro")

            If objIniFile.GetString("COMPANY", "Tipo Impresora RI", "Normal") = "Normal" Then
                Dim Report As New rptAhorroRetiro
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
                Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, 0, 0)
            Else
                Dim Report As New rptAhorroRetiroSP
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
                Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, 0, 0)
            End If



        End If
        WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print
    End Sub
    '
    Private Sub Guardar()


        If validarCampos() Then
            sumaTotales()
            If CDbl(cambioTxt.Text) < 0 Then
                Alerta("Está retirando menos dinero del que desea ratirar")
                Return
            End If
            If CDbl(totalTxt.Text) <= 0 Then
                Alerta("Es obligatorio hacer el desglose de dinero a retirar")
                Return
            End If
            If Alerta("¿Seguro que desea guardar el documento?") = False Then Return

            NON_QUERY("INSERT INTO tbl_ahorros_retiros (IDAhorro, Fecha, Tipo, Concepto, Monto, Usuario, IDCliente, IdCaja, dosMil, Mil, Quiniento, Dosciento, Cien, Cincuenta, Veinticinco, Diez, Cinco, Cheque, Uno) VALUES(" & CInt(txtIdAhorro.Text) & ",Now(),'" & cmbTipo.Text & "','" & txtConcepto.Text & "'," & CDbl(txtMonto.Text) & ",'" & User(0) & "'," & CInt(txtIDCliente.Text) & "," & cmbCajas.SelectedValue & "," & CDbl(dosmilTxt.Text) & "," & CDbl(milTxt.Text) & "," & CDbl(quinientoTxt.Text) & "," & CDbl(docientoTxt.Text) & "," & CDbl(cienTxt.Text) & "," & CDbl(cincuentaTxt.Text) & "," & CDbl(venticincoTxt.Text) & "," & CDbl(diezTxt.Text) & "," & CDbl(cincoTxt.Text) & "," & CDbl(cheque.Text) & "," & CDbl(unoTxt.Text) & ")")

            Dim Idretiro = UltimoID("tbl_ahorros_retiros", "id")

            guardarTransaccionContable(Idretiro)
            If CBool(SCALAR_NUM("SELECT VistaPreviaImpresion FROM parametrosgenerales WHERE ID=1")) = True Then
                Id = Id
                AllReportSinFecha("Recibo Retiro")
                Me.Close()
            Else
                imprimirDocumento(Idretiro)
                Nuevo()
            End If
            
        End If
    End Sub

    Private Sub FechaUltimoRetiro()

        dtpUltimoRetiro.Value = fechaServidor
        If SCALAR_NUM("SELECT IFNULL(1,0) FROM tbl_ahorros_retiros WHERE IDAhorro=" & CInt(txtIdAhorro.Text) & "") > 0 Then
            dtpUltimoRetiro.Value = SCALAR_STRING("SELECT MAX(Fecha) FROM tbl_ahorros_retiros WHERE IDAhorro=" & CInt(txtIdAhorro.Text) & "")
        Else
            dtpUltimoRetiro.Value = SCALAR_STRING("SELECT FechaApertura FROM tbl_ahorros_cuentas WHERE ID=" & CInt(txtIdAhorro.Text) & "")
        End If
    End Sub

    Private Sub BuscarAhorro(ByVal CtaAhorro As Integer)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_ahorros_cuentas WHERE ID=" & CtaAhorro & "", conn)
        da.Fill(ds, "tbl_ahorros_cuentas")

        Dim dr As DataRow

        Dim tasa As Decimal = 0


        For Each dr In ds.Tables(0).Rows
            txtCuentaNo.Text = dr("CuentaNo")
            txtIdAhorro.Text = dr("ID")
            txtIDCliente.Text = dr("IDCliente")
        Next

        tasa = SCALAR_NUM("SELECT IFNULL(TasaIteres,0) FROM tbl_ahorros_cuentas WHERE ID=" & CInt(txtIdAhorro.Text) & "") / 30

        Dim capitalAhorrado As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) FROM tbl_ahorros_depositos WHERE IDCuenta=" & CInt(txtIdAhorro.Text) & " GROUP BY IDCliente")
        Dim capitalRetirado As Decimal = SCALAR_STRING("SELECT IFNULL(SUM(Monto),0) FROM tbl_ahorros_retiros WHERE IDAhorro=" & CInt(txtIdAhorro.Text) & " AND Tipo <> 'Retiro de Interes'")



        LlenarLV(CInt(txtIDCliente.Text))

        da.Dispose()
        ds.Dispose()
        If ds.Tables(0).Rows.Count = 0 Then
            Alerta("El número de cuenta solicidado no existe")
            Return
        End If
        BuscarCliente(txtIDCliente.Text)
        FechaUltimoRetiro()

        txtDiasAcumulados.Text = DateDiff(DateInterval.Day, dtpUltimoRetiro.Value, fechaServidor)

        txtSaldoCapital.Text = Format(capitalAhorrado - capitalRetirado, "C2")
        txtSaldoInteres.Text = Format((CDec(txtSaldoCapital.Text) * tasa / 100) * CDec(txtDiasAcumulados.Text), "C2")

        TipoRetiro()



    End Sub
    Private Sub LlenarCajas()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT Id, Descripcion FROM cajamantenimiento ORDER BY Orden, Descripcion", conn)
        da.Fill(dt)

        cmbCajas.DataSource = dt
        cmbCajas.DisplayMember = "Descripcion"
        cmbCajas.ValueMember = "Id"
        da.Dispose()

    End Sub
    Private Sub BuscarCliente(ByVal IDCliente As Integer)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT fld_FullName, fld_Identity FROM tbl_clientes WHERE fld_id=" & IDCliente & "", conn)
        da.Fill(ds, "tbl_clientes")

        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            txtCliente.Text = dr("fld_FullName")
            txtCedula.Text = dr("fld_Identity")
        Next

        da.Dispose()
        ds.Dispose()
    End Sub

    Private Sub cmbTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipo.KeyPress
        e.Handled = True
    End Sub

    Private Sub FRM_RETIROS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarCajas()
        Nuevo()
    End Sub



    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Guardar()

    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged
        TipoRetiro()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If frmsListaCuentaAhorro() = True Then
            BuscarAhorro(Id)
            cmbTipo.Focus()
        End If
    End Sub


    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime.Click
        Dim f As New frmRetirosLista
        f.ShowDialog()
        If f.Text = "ACEPTAR" Then
            If CBool(SCALAR_NUM("SELECT VistaPreviaImpresion FROM parametrosgenerales WHERE ID=1")) = True Then
                Id = Id
                AllReportSinFecha("Recibo Retiro")
                Me.Close()
            Else
                imprimirDocumento(Id)
                btnNuevo_Click(sender, e)
            End If


        End If
        f.Dispose()
    End Sub
    Private Sub dosmilTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dosmilTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dosmilTxt.Text = String.Empty Then dosmilTxt.Text = "0.00"
            resDosmilTxt.Text = Format(CInt(dosmilTxt.Text) * 2000, "N2")
            milTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub dosmilTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dosmilTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub milTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles milTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If milTxt.Text = String.Empty Then milTxt.Text = "0.00"
            resMilTxt.Text = Format(CInt(milTxt.Text) * 1000, "N2")
            quinientoTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub milTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles milTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub quinientoTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles quinientoTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If quinientoTxt.Text = String.Empty Then quinientoTxt.Text = "0.00"
            resQuinientoTxt.Text = Format(CInt(quinientoTxt.Text) * 500, "N2")
            docientoTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub quinientoTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles quinientoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub docientoTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles docientoTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If docientoTxt.Text = String.Empty Then docientoTxt.Text = "0.00"
            resDocientoTxt.Text = Format(CInt(docientoTxt.Text) * 200, "N2")
            cienTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub docientoTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles docientoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cienTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cienTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cienTxt.Text = String.Empty Then cienTxt.Text = "0.00"
            resCienTxt.Text = Format(CInt(cienTxt.Text) * 100, "N2")
            cincuentaTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub cienTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cienTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cincuentaTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cincuentaTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cincuentaTxt.Text = String.Empty Then cincuentaTxt.Text = "0.00"
            resCincuentaTxt.Text = Format(CInt(cincuentaTxt.Text) * 50, "N2")
            venticincoTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub cincuentaTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cincuentaTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub venticincoTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles venticincoTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If venticincoTxt.Text = String.Empty Then venticincoTxt.Text = "0.00"
            resVeiticincoTxt.Text = Format(CInt(venticincoTxt.Text) * 25, "N2")
            diezTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub venticincoTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles venticincoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub diezTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles diezTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If diezTxt.Text = String.Empty Then diezTxt.Text = "0.00"
            resDiezTxt.Text = Format(CInt(diezTxt.Text) * 10, "N2")
            cincoTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub diezTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles diezTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cincoTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cincoTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cincoTxt.Text = String.Empty Then cincoTxt.Text = "0.00"
            resCincoTxt.Text = Format(CInt(cincoTxt.Text) * 5, "N2")
            unoTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub cincoTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cincoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub unoTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles unoTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If unoTxt.Text = String.Empty Then unoTxt.Text = "0.00"
            resUnoTxt.Text = Format(CInt(unoTxt.Text) * 1, "N2")
            cheque.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub unoTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles unoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cheque_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cheque.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cheque.Text = String.Empty Then cheque.Text = "0.00"

            Dim amount As Decimal = CType(cheque.Text, Decimal)
            Me.cheque.Text = String.Format("{0:n2}", amount)
            btnGuardar.Focus()
        End If
    End Sub

    Private Sub cheque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cheque.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMonto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtMonto.Text = String.Empty Then txtMonto.Text = "0.00"

            Dim amount As Decimal = CType(txtMonto.Text, Decimal)
            Me.txtMonto.Text = String.Format("{0:n2}", amount)
            If CDbl(txtMonto.Text) > 0 Then
                dosmilTxt.ReadOnly = False
                dosmilTxt.Focus()
                milTxt.ReadOnly = False
                quinientoTxt.ReadOnly = False
                docientoTxt.ReadOnly = False
                cienTxt.ReadOnly = False
                cincuentaTxt.ReadOnly = False
                venticincoTxt.ReadOnly = False
                diezTxt.ReadOnly = False
                cincoTxt.ReadOnly = False
                unoTxt.ReadOnly = False
                cheque.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub FRM_RETIROS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cmbTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cheque_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheque.TextChanged

    End Sub

    Private Sub txtMonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.TextChanged

    End Sub

    Private Sub txtConcepto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConcepto.TextChanged

    End Sub

    Private Sub txtConcepto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConcepto.KeyDown
        If e.KeyCode = Keys.Enter Then
            dosmilTxt.ReadOnly = False
            dosmilTxt.Focus()
            milTxt.ReadOnly = False
            quinientoTxt.ReadOnly = False
            docientoTxt.ReadOnly = False
            cienTxt.ReadOnly = False
            cincuentaTxt.ReadOnly = False
            venticincoTxt.ReadOnly = False
            diezTxt.ReadOnly = False
            cincoTxt.ReadOnly = False
            unoTxt.ReadOnly = False
            cheque.ReadOnly = False
        End If
    End Sub
End Class
