Imports MySql.Data.MySqlClient
Public Class frmCertificadoRetiro
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
    Friend WithEvents txtSaldoCapital As System.Windows.Forms.TextBox
    Friend WithEvents dtpUltimoRetiro As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDiasAcumulados As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIDCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSaldoInteres As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIdAhorro As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCajas As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCertificadoRetiro))
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtCuentaNo = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.txtSaldoCapital = New System.Windows.Forms.TextBox()
        Me.dtpUltimoRetiro = New System.Windows.Forms.DateTimePicker()
        Me.txtDiasAcumulados = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSaldoInteres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdAhorro = New System.Windows.Forms.TextBox()
        Me.txtIDCliente = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lv = New System.Windows.Forms.ListView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInteresRetirado = New System.Windows.Forms.TextBox()
        Me.txtCapitalRetirado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalRetirado = New System.Windows.Forms.TextBox()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCajas = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.White
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Location = New System.Drawing.Point(96, 80)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(304, 20)
        Me.txtCedula.TabIndex = 6
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(96, 57)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(304, 20)
        Me.txtCliente.TabIndex = 4
        '
        'txtCuentaNo
        '
        Me.txtCuentaNo.BackColor = System.Drawing.Color.White
        Me.txtCuentaNo.Location = New System.Drawing.Point(96, 34)
        Me.txtCuentaNo.Name = "txtCuentaNo"
        Me.txtCuentaNo.Size = New System.Drawing.Size(200, 20)
        Me.txtCuentaNo.TabIndex = 1
        Me.txtCuentaNo.Text = "0"
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(24, 59)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(64, 16)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Socio"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblId
        '
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblId.Location = New System.Drawing.Point(24, 36)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(64, 16)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Cuenta No."
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCedula.Location = New System.Drawing.Point(24, 82)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(64, 16)
        Me.lblCedula.TabIndex = 5
        Me.lblCedula.Text = "Cédula"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(96, 212)
        Me.txtConcepto.MaxLength = 150
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(304, 72)
        Me.txtConcepto.TabIndex = 18
        '
        'txtSaldoCapital
        '
        Me.txtSaldoCapital.Enabled = False
        Me.txtSaldoCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoCapital.Location = New System.Drawing.Point(96, 126)
        Me.txtSaldoCapital.Name = "txtSaldoCapital"
        Me.txtSaldoCapital.Size = New System.Drawing.Size(304, 26)
        Me.txtSaldoCapital.TabIndex = 12
        Me.txtSaldoCapital.Text = "0.00"
        Me.txtSaldoCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpUltimoRetiro
        '
        Me.dtpUltimoRetiro.CustomFormat = "dd/MMM/yyyy"
        Me.dtpUltimoRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpUltimoRetiro.Location = New System.Drawing.Point(280, 323)
        Me.dtpUltimoRetiro.Name = "dtpUltimoRetiro"
        Me.dtpUltimoRetiro.Size = New System.Drawing.Size(100, 20)
        Me.dtpUltimoRetiro.TabIndex = 8
        Me.dtpUltimoRetiro.Visible = False
        '
        'txtDiasAcumulados
        '
        Me.txtDiasAcumulados.Location = New System.Drawing.Point(300, 103)
        Me.txtDiasAcumulados.Name = "txtDiasAcumulados"
        Me.txtDiasAcumulados.ReadOnly = True
        Me.txtDiasAcumulados.Size = New System.Drawing.Size(100, 20)
        Me.txtDiasAcumulados.TabIndex = 10
        Me.txtDiasAcumulados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(-16, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Saldo de Capital"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(200, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Días Acumulados"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(0, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Saldo de Interes"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSaldoInteres
        '
        Me.txtSaldoInteres.Enabled = False
        Me.txtSaldoInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoInteres.Location = New System.Drawing.Point(96, 155)
        Me.txtSaldoInteres.Name = "txtSaldoInteres"
        Me.txtSaldoInteres.Size = New System.Drawing.Size(304, 26)
        Me.txtSaldoInteres.TabIndex = 14
        Me.txtSaldoInteres.Text = "0.00"
        Me.txtSaldoInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(24, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nota"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(96, 291)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(304, 26)
        Me.txtMonto.TabIndex = 20
        Me.txtMonto.Text = "0.00"
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(0, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Monto del Retiro"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIdAhorro
        '
        Me.txtIdAhorro.Enabled = False
        Me.txtIdAhorro.Location = New System.Drawing.Point(24, 363)
        Me.txtIdAhorro.Name = "txtIdAhorro"
        Me.txtIdAhorro.ReadOnly = True
        Me.txtIdAhorro.Size = New System.Drawing.Size(32, 20)
        Me.txtIdAhorro.TabIndex = 159
        Me.txtIdAhorro.Text = "0"
        '
        'txtIDCliente
        '
        Me.txtIDCliente.Enabled = False
        Me.txtIDCliente.Location = New System.Drawing.Point(24, 387)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(56, 20)
        Me.txtIDCliente.TabIndex = 160
        Me.txtIDCliente.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Buscar"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.SystemColors.Control
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.Black
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.Location = New System.Drawing.Point(240, 355)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(72, 56)
        Me.btnConsultar.TabIndex = 163
        Me.btnConsultar.Text = "&Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(312, 355)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 166
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(168, 355)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 162
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(96, 355)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 161
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'lv
        '
        Me.lv.Location = New System.Drawing.Point(408, 7)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(424, 310)
        Me.lv.TabIndex = 167
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(416, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(208, 16)
        Me.Label8.TabIndex = 168
        Me.Label8.Text = "Monto Interes retirado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtInteresRetirado
        '
        Me.txtInteresRetirado.Enabled = False
        Me.txtInteresRetirado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInteresRetirado.Location = New System.Drawing.Point(632, 322)
        Me.txtInteresRetirado.Name = "txtInteresRetirado"
        Me.txtInteresRetirado.Size = New System.Drawing.Size(200, 26)
        Me.txtInteresRetirado.TabIndex = 169
        Me.txtInteresRetirado.Text = "0.00"
        Me.txtInteresRetirado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCapitalRetirado
        '
        Me.txtCapitalRetirado.Enabled = False
        Me.txtCapitalRetirado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapitalRetirado.Location = New System.Drawing.Point(632, 350)
        Me.txtCapitalRetirado.Name = "txtCapitalRetirado"
        Me.txtCapitalRetirado.Size = New System.Drawing.Size(200, 26)
        Me.txtCapitalRetirado.TabIndex = 170
        Me.txtCapitalRetirado.Text = "0.00"
        Me.txtCapitalRetirado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(416, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(208, 16)
        Me.Label9.TabIndex = 171
        Me.Label9.Text = "Monto Capital retirado"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(416, 383)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 16)
        Me.Label10.TabIndex = 172
        Me.Label10.Text = "Monto Total retirado"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalRetirado
        '
        Me.txtTotalRetirado.Enabled = False
        Me.txtTotalRetirado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRetirado.Location = New System.Drawing.Point(632, 378)
        Me.txtTotalRetirado.Name = "txtTotalRetirado"
        Me.txtTotalRetirado.Size = New System.Drawing.Size(200, 26)
        Me.txtTotalRetirado.TabIndex = 173
        Me.txtTotalRetirado.Text = "0.00"
        Me.txtTotalRetirado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(96, 106)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.TabIndex = 174
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(16, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 175
        Me.Label11.Text = "Fecha"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OliveDrab
        Me.Label3.Location = New System.Drawing.Point(0, 435)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(842, 32)
        Me.Label3.TabIndex = 176
        Me.Label3.Text = "RETIROS/CANCELACION DE CERTIFICADO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTipo
        '
        Me.cmbTipo.Items.AddRange(New Object() {"Interes", "Capital e Interes"})
        Me.cmbTipo.Location = New System.Drawing.Point(96, 186)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 177
        Me.cmbTipo.Text = "Interes"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(8, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Tipo Retiro"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbCajas
        '
        Me.cmbCajas.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.cmbCajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCajas.ForeColor = System.Drawing.Color.White
        Me.cmbCajas.Location = New System.Drawing.Point(96, 7)
        Me.cmbCajas.Name = "cmbCajas"
        Me.cmbCajas.Size = New System.Drawing.Size(304, 21)
        Me.cmbCajas.TabIndex = 179
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(16, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 180
        Me.Label12.Text = "Caja :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCertificadoRetiro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(842, 467)
        Me.Controls.Add(Me.cmbCajas)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtTotalRetirado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCapitalRetirado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtInteresRetirado)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtIDCliente)
        Me.Controls.Add(Me.txtIdAhorro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSaldoInteres)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDiasAcumulados)
        Me.Controls.Add(Me.dtpUltimoRetiro)
        Me.Controls.Add(Me.txtSaldoCapital)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtCuentaNo)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblCedula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCertificadoRetiro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancelación de Certificado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim fechaServidor As DateTime

    '

    Public Sub LlenarLV(ByVal IDCliente As Integer)

        lv.Clear()
        lv.View = View.Details
        lv.LabelEdit = False
        lv.FullRowSelect = True
        lv.GridLines = True
        lv.Sorting = SortOrder.None


        Dim sqlSearch As String
        sqlSearch = "SELECT ID, Fecha, Tipo, Monto, Concepto FROM tbl_ahorros_certificado_retiros WHERE IDCliente=" & IDCliente & " ORDER BY Fecha DESC"



        Dim ds As New DataSet
        Dim da As MySqlDataAdapter

        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds)
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            If dr("Tipo") = "Interes" Then
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

        txtConcepto.Text = String.Empty
        txtMonto.Text = Format(0, "N2")
        txtInteresRetirado.Text = Format(0, "C2")
        txtCapitalRetirado.Text = Format(0, "C2")
        txtTotalRetirado.Text = Format(0, "C2")
    End Sub

    

    Private Function Validar() As Boolean
        If txtMonto.Text = String.Empty Then txtMonto.Text = "0.00"

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

    Private Sub LlenarCajas()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT Id, Descripcion FROM cajamantenimiento ORDER BY Orden, Descripcion", conn)
        da.Fill(dt)

        cmbCajas.DataSource = dt
        cmbCajas.DisplayMember = "Descripcion"
        cmbCajas.ValueMember = "Id"
        da.Dispose()

    End Sub

    Private Sub Guardar()

        If cmbTipo.Text = "Interes" Then
            NON_QUERY("INSERT INTO tbl_ahorros_certificado_retiros (IDAhorro, Fecha, Tipo, Concepto, Monto, Usuario, IDCliente) VALUES(" & CInt(txtIdAhorro.Text) & ",'" & formatDate(dtpFecha.Value.Date) & "','" & cmbTipo.Text & "','" & txtConcepto.Text & "'," & CDbl(txtSaldoInteres.Text) & ",'" & User(0) & "'," & CInt(txtIDCliente.Text) & ")")

        Else
            '' INTERES 
            NON_QUERY("INSERT INTO tbl_ahorros_certificado_retiros (IDAhorro, Fecha, Tipo, Concepto, Monto, Usuario, IDCliente) VALUES(" & CInt(txtIdAhorro.Text) & ",'" & formatDate(dtpFecha.Value.Date) & "','Interes','" & txtConcepto.Text & "'," & CDbl(txtSaldoInteres.Text) & ",'" & User(0) & "'," & CInt(txtIDCliente.Text) & ")")

            '' CAPITAL
            NON_QUERY("INSERT INTO tbl_ahorros_certificado_retiros (IDAhorro, Fecha, Tipo, Concepto, Monto, Usuario, IDCliente) VALUES(" & CInt(txtIdAhorro.Text) & ",'" & formatDate(dtpFecha.Value.Date) & "','" & cmbTipo.Text & "','" & txtConcepto.Text & "'," & CDbl(txtSaldoCapital.Text) & ",'" & User(0) & "'," & CInt(txtIDCliente.Text) & ")")

        End If


        Idretiro = UltimoID("tbl_ahorros_certificado_retiros", "id")

        guardarTransaccionContable(Idretiro)

    End Sub


    Private Sub guardarTransaccionContable(ByVal idDocAfectado As Integer)

        Dim idTipoTrans = SCALAR_NUM("SELECT IdTipo FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & Me.Text & "'")

        If cmbTipo.Text = "Interes" Then
            NON_QUERY("CALL cont_insert_trans(Now(),'" & txtConcepto.Text & "'," & idTipoTrans & ",'" & User(0) & "'," & idDocAfectado & ",'RETIRO DE INTERES CERTIFICADO','" & " Retiro de interes a cta. no. " & txtCuentaNo.Text & "')")
        Else
            NON_QUERY("CALL cont_insert_trans(Now(),'" & txtConcepto.Text & "'," & idTipoTrans & ",'" & User(0) & "'," & idDocAfectado & ",'RETIRO DE CAPITAL E INTERES CERTIFICADO','" & " Retiro de ahorro a cta. no. " & txtCuentaNo.Text & "')")
        End If

        Dim idTras = UltimoID("tbl_interfascontabletransacciones", "TransID")

        Dim ctaContableCaja = SCALAR_STRING("SELECT CtaContable  FROM cajamantenimiento WHERE ID=" & cmbCajas.SelectedValue & "") '' Caja General
        Dim ctaContableIntCert = SCALAR_STRING("SELECT CertificadoInteresGenerado  FROM tbl_interfascontableotras WHERE ID=1") ''Interees Certificado Generado
        Dim ctaContableRetIntCert = SCALAR_STRING("SELECT CertificadoInteres  FROM tbl_interfascontableotras WHERE ID=1") ''Interees Certificado
        Dim ctaContableCertificado = SCALAR_STRING("SELECT Certificados  FROM tbl_interfascontableotras WHERE ID=1") '' Certificados

        Dim DescripcionCuenta = String.Empty


        Dim dblSaldoCapital As Double = txtSaldoCapital.Text
        Dim dblSaldoInteres As Double = txtSaldoInteres.Text


        If cmbTipo.Text = "Interes" Then

            If dblSaldoInteres > 0 Then
                '' Un crédito a Intereses Depósitos a Plazos (201-02-01)
                DescripcionCuenta = ReturnDescripcion(ctaContableIntCert)
                GuardarTransaccionDetalle(idTras, ctaContableIntCert, DescripcionCuenta, 0, CDbl(txtSaldoInteres.Text))

                '' Un debito a Intereses Depósitos a Plazos (201-02-01)
                DescripcionCuenta = ReturnDescripcion(ctaContableIntCert)
                GuardarTransaccionDetalle(idTras, ctaContableIntCert, DescripcionCuenta, CDbl(txtSaldoInteres.Text), 0)

                '' Un crédito la caja general.
                DescripcionCuenta = ReturnDescripcion(ctaContableCaja)
                GuardarTransaccionDetalle(idTras, ctaContableCaja, DescripcionCuenta, 0, CDbl(txtSaldoInteres.Text))

                '' Débito intereses pagados a socios (500-03)
                DescripcionCuenta = ReturnDescripcion(ctaContableRetIntCert)
                GuardarTransaccionDetalle(idTras, ctaContableRetIntCert, DescripcionCuenta, CDbl(txtSaldoInteres.Text), 0)
            End If

        Else

            If dblSaldoInteres > 0 Then
                '' Un crédito a Intereses Depósitos a Plazos
                DescripcionCuenta = ReturnDescripcion(ctaContableIntCert)
                GuardarTransaccionDetalle(idTras, ctaContableIntCert, DescripcionCuenta, 0, CDbl(txtSaldoInteres.Text))

                '' Un debito a Intereses Depósitos a Plazos
                DescripcionCuenta = ReturnDescripcion(ctaContableIntCert)
                GuardarTransaccionDetalle(idTras, ctaContableIntCert, DescripcionCuenta, CDbl(txtSaldoInteres.Text), 0)

                '' Un crédito la caja general.
                DescripcionCuenta = ReturnDescripcion(ctaContableCaja)
                GuardarTransaccionDetalle(idTras, ctaContableCaja, DescripcionCuenta, 0, CDbl(txtSaldoInteres.Text))

                '' Débito 500-03 intereses pagados a socios
                DescripcionCuenta = ReturnDescripcion(ctaContableRetIntCert)
                GuardarTransaccionDetalle(idTras, ctaContableRetIntCert, DescripcionCuenta, CDbl(txtSaldoInteres.Text), 0)
            End If

            If dblSaldoCapital > 0 Then
                '' Un crédito la caja general.
                DescripcionCuenta = ReturnDescripcion(ctaContableCaja)
                GuardarTransaccionDetalle(idTras, ctaContableCaja, DescripcionCuenta, 0, CDbl(txtSaldoCapital.Text))

                '' Débito a la cuenta 200-01-01 certificado asociados 
                DescripcionCuenta = ReturnDescripcion(ctaContableCertificado)
                GuardarTransaccionDetalle(idTras, ctaContableCertificado, DescripcionCuenta, CDbl(txtSaldoCapital.Text), 0)
            End If

        End If

    End Sub

    Private Sub FechaUltimoRetiro()

        dtpUltimoRetiro.Value = fechaServidor
        If SCALAR_NUM("SELECT IFNULL(1,0) FROM tbl_ahorros_certificado_retiros WHERE IDAhorro=" & CInt(txtIdAhorro.Text) & "") > 0 Then
            dtpUltimoRetiro.Value = SCALAR_STRING("SELECT MAX(Fecha) FROM tbl_ahorros_certificado_retiros WHERE IDAhorro=" & CInt(txtIdAhorro.Text) & "")
        Else
            dtpUltimoRetiro.Value = SCALAR_STRING("SELECT FechaApertura FROM tbl_ahorros_certificado WHERE ID=" & CInt(txtIdAhorro.Text) & "")
        End If
    End Sub

    Private Sub BuscarAhorro(ByVal CtaAhorro As Integer)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_ahorros_certificado WHERE ID=" & CtaAhorro & "", conn)
        da.Fill(ds, "tbl_ahorros_certificado")

        Dim dr As DataRow

        Dim tasa As Decimal = 0


        For Each dr In ds.Tables(0).Rows
            txtCuentaNo.Text = dr("CuentaNo")
            txtIdAhorro.Text = dr("ID")
            txtIDCliente.Text = dr("IDCliente")
        Next

        tasa = SCALAR_NUM("SELECT IFNULL(TasaIteres,0) FROM tbl_ahorros_certificado WHERE ID=" & CInt(txtIdAhorro.Text) & "") / 30

        Dim capitalAhorrado As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(SaldoCapital),0) FROM tbl_ahorros_certificado WHERE ID=" & CtaAhorro & " GROUP BY IDCliente")
        Dim capitalRetirado As Decimal = SCALAR_STRING("SELECT IFNULL(SUM(Monto),0) FROM tbl_ahorros_certificado_retiros WHERE IDAhorro=" & CInt(txtIdAhorro.Text) & " AND Tipo <> 'Interes'")



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

        txtSaldoCapital.Text = Format(capitalAhorrado - capitalRetirado, "N2")
        txtSaldoInteres.Text = Format((CDec(txtSaldoCapital.Text) * tasa / 100) * CDec(txtDiasAcumulados.Text), "N2")
        txtMonto.Text = Format(CDbl(txtSaldoCapital.Text) + CDbl(txtSaldoInteres.Text), "N2")



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

    Private Sub cmbTipo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub frmCertificadoRetiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarCajas()
        Nuevo()
    End Sub



    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Validar() = False Then Return
        If Alerta("¿Seguro que desea realizar el retiro?") = False Then Return
        Guardar()
        Nuevo()
    End Sub

    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click

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

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FRMS_LIST_CERTIFICADO() = True Then
            BuscarAhorro(Id)
        End If
    End Sub

    Private Sub txtCuentaNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaNo.TextChanged

    End Sub

    Private Sub txtMonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.TextChanged

    End Sub
End Class
