Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing

Public Class FRM_NC_CXC_COMP
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
    Friend WithEvents btnBusca As System.Windows.Forms.Button
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents DG As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMontoCobrar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents fld_id_prestamo As System.Windows.Forms.TextBox
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fld_concepto As System.Windows.Forms.TextBox
    Friend WithEvents fld_total_interes As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fld_total_mora As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents fld_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents fld_monto_mora As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents fld_id_cuotas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuradar As System.Windows.Forms.Button
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbOmitirMora As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents btnOn As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_NC_CXC_COMP))
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnOff = New System.Windows.Forms.Button
        Me.btnOn = New System.Windows.Forms.Button
        Me.fld_fecha = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.fld_total_mora = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.fld_total_interes = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.fld_concepto = New System.Windows.Forms.TextBox
        Me.fld_id_prestamo = New System.Windows.Forms.TextBox
        Me.txtMontoCobrar = New System.Windows.Forms.TextBox
        Me.DG = New System.Windows.Forms.DataGrid
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.btnBusca = New System.Windows.Forms.Button
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.lblCustomerID = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtCustomerID = New System.Windows.Forms.TextBox
        Me.lblBalance = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.fld_id_cuotas = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.fld_monto_mora = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbOmitirMora = New System.Windows.Forms.CheckBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnGuradar = New System.Windows.Forms.Button
        Me.btnNueva = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(96, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 16)
        Me.Label12.TabIndex = 107
        Me.Label12.Text = "Seleccionar todo"
        '
        'btnOff
        '
        Me.btnOff.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOff.ForeColor = System.Drawing.Color.Black
        Me.btnOff.Location = New System.Drawing.Point(144, 128)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(40, 24)
        Me.btnOff.TabIndex = 106
        Me.btnOff.Text = "No"
        '
        'btnOn
        '
        Me.btnOn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn.ForeColor = System.Drawing.Color.Black
        Me.btnOn.Location = New System.Drawing.Point(96, 128)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(40, 24)
        Me.btnOn.TabIndex = 105
        Me.btnOn.Text = "Si"
        '
        'fld_fecha
        '
        Me.fld_fecha.CustomFormat = "dd / MMM / yyyy"
        Me.fld_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha.Location = New System.Drawing.Point(648, 16)
        Me.fld_fecha.Name = "fld_fecha"
        Me.fld_fecha.Size = New System.Drawing.Size(128, 20)
        Me.fld_fecha.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(536, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Fecha de Servidor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_total_mora
        '
        Me.fld_total_mora.BackColor = System.Drawing.Color.White
        Me.fld_total_mora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_total_mora.Location = New System.Drawing.Point(648, 144)
        Me.fld_total_mora.Name = "fld_total_mora"
        Me.fld_total_mora.Size = New System.Drawing.Size(128, 20)
        Me.fld_total_mora.TabIndex = 9
        Me.fld_total_mora.Text = "0.00"
        Me.fld_total_mora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(504, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 16)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Total Mora y Otros"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_total_interes
        '
        Me.fld_total_interes.BackColor = System.Drawing.Color.White
        Me.fld_total_interes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_total_interes.Location = New System.Drawing.Point(648, 120)
        Me.fld_total_interes.Name = "fld_total_interes"
        Me.fld_total_interes.Size = New System.Drawing.Size(128, 20)
        Me.fld_total_interes.TabIndex = 8
        Me.fld_total_interes.Text = "0.00"
        Me.fld_total_interes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(552, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Total Interes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_concepto
        '
        Me.fld_concepto.BackColor = System.Drawing.Color.White
        Me.fld_concepto.Location = New System.Drawing.Point(440, 40)
        Me.fld_concepto.MaxLength = 150
        Me.fld_concepto.Multiline = True
        Me.fld_concepto.Name = "fld_concepto"
        Me.fld_concepto.Size = New System.Drawing.Size(336, 48)
        Me.fld_concepto.TabIndex = 6
        Me.fld_concepto.Text = "N/A"
        '
        'fld_id_prestamo
        '
        Me.fld_id_prestamo.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.fld_id_prestamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_id_prestamo.Location = New System.Drawing.Point(96, 88)
        Me.fld_id_prestamo.MaxLength = 8
        Me.fld_id_prestamo.Name = "fld_id_prestamo"
        Me.fld_id_prestamo.ReadOnly = True
        Me.fld_id_prestamo.Size = New System.Drawing.Size(272, 20)
        Me.fld_id_prestamo.TabIndex = 3
        Me.fld_id_prestamo.Text = "0"
        '
        'txtMontoCobrar
        '
        Me.txtMontoCobrar.BackColor = System.Drawing.Color.White
        Me.txtMontoCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCobrar.Location = New System.Drawing.Point(648, 88)
        Me.txtMontoCobrar.Name = "txtMontoCobrar"
        Me.txtMontoCobrar.Size = New System.Drawing.Size(128, 26)
        Me.txtMontoCobrar.TabIndex = 7
        Me.txtMontoCobrar.Text = "0.00"
        Me.txtMontoCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DG
        '
        Me.DG.BackgroundColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.DG.CaptionVisible = False
        Me.DG.DataMember = ""
        Me.DG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG.Location = New System.Drawing.Point(0, 168)
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(776, 248)
        Me.DG.TabIndex = 15
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.White
        Me.txtBalance.Location = New System.Drawing.Point(96, 64)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(272, 20)
        Me.txtBalance.TabIndex = 2
        Me.txtBalance.Text = "0.00"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.SystemColors.Control
        Me.btnBusca.ForeColor = System.Drawing.Color.Black
        Me.btnBusca.Location = New System.Drawing.Point(192, 16)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(128, 20)
        Me.btnBusca.TabIndex = 0
        Me.btnBusca.Text = "&Lista de Clientes (F5)"
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(16, 40)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(72, 16)
        Me.lblFirstName.TabIndex = 36
        Me.lblFirstName.Text = "Cliente"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCustomerID
        '
        Me.lblCustomerID.Location = New System.Drawing.Point(16, 16)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(72, 16)
        Me.lblCustomerID.TabIndex = 35
        Me.lblCustomerID.Text = "Código"
        Me.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstName.Location = New System.Drawing.Point(96, 40)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(272, 20)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.Text = ""
        '
        'txtCustomerID
        '
        Me.txtCustomerID.BackColor = System.Drawing.Color.White
        Me.txtCustomerID.Location = New System.Drawing.Point(96, 16)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(88, 20)
        Me.txtCustomerID.TabIndex = 0
        Me.txtCustomerID.Text = "0"
        '
        'lblBalance
        '
        Me.lblBalance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(24, 64)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(64, 16)
        Me.lblBalance.TabIndex = 52
        Me.lblBalance.Text = "Balance"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Cod. Préstamo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(440, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "MONTO CREDITO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(376, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Concepto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.fld_id_cuotas)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.fld_monto_mora)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(80, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 40)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aplicar Mora"
        Me.GroupBox2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(308, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 20)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "&aplicar"
        '
        'fld_id_cuotas
        '
        Me.fld_id_cuotas.BackColor = System.Drawing.Color.White
        Me.fld_id_cuotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fld_id_cuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_id_cuotas.Location = New System.Drawing.Point(244, 14)
        Me.fld_id_cuotas.Name = "fld_id_cuotas"
        Me.fld_id_cuotas.Size = New System.Drawing.Size(56, 20)
        Me.fld_id_cuotas.TabIndex = 72
        Me.fld_id_cuotas.Text = "0"
        Me.fld_id_cuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(180, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Id. No."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_monto_mora
        '
        Me.fld_monto_mora.BackColor = System.Drawing.Color.White
        Me.fld_monto_mora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fld_monto_mora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_monto_mora.Location = New System.Drawing.Point(76, 14)
        Me.fld_monto_mora.Name = "fld_monto_mora"
        Me.fld_monto_mora.Size = New System.Drawing.Size(96, 20)
        Me.fld_monto_mora.TabIndex = 70
        Me.fld_monto_mora.Text = "0.00"
        Me.fld_monto_mora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Monto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbOmitirMora
        '
        Me.cbOmitirMora.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbOmitirMora.ForeColor = System.Drawing.Color.Black
        Me.cbOmitirMora.Location = New System.Drawing.Point(336, 16)
        Me.cbOmitirMora.Name = "cbOmitirMora"
        Me.cbOmitirMora.TabIndex = 81
        Me.cbOmitirMora.Text = "Omitir Mora"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCerrar.Location = New System.Drawing.Point(704, 424)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 52
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
        Me.btnGuradar.Location = New System.Drawing.Point(72, 424)
        Me.btnGuradar.Name = "btnGuradar"
        Me.btnGuradar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuradar.TabIndex = 51
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
        Me.btnNueva.Location = New System.Drawing.Point(0, 424)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(72, 56)
        Me.btnNueva.TabIndex = 50
        Me.btnNueva.Text = "&Nueva"
        Me.btnNueva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(144, 440)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(568, 32)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "NOTA DE CREDITO A CAPITAL E INTERES "
        '
        'FRM_NC_CXC_COMP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(778, 483)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuradar)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbOmitirMora)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.fld_total_interes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fld_concepto)
        Me.Controls.Add(Me.fld_id_prestamo)
        Me.Controls.Add(Me.txtMontoCobrar)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.btnBusca)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnOn)
        Me.Controls.Add(Me.fld_fecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.fld_total_mora)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_NC_CXC_COMP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota de Crédito CxC"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsCustomer As New DataSet
    Private daCustomer As MySqlDataAdapter
    Dim description_interes As String = "", description_capital As String = "", descripcion_cliente As String = ""
   

    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    Dim monto As Double
    Dim TABLA As String, view As String, capital_cobrado As Double, interes_cobrado As Double, monto_cta_cobrado As Double, mora_cobrada As Double


    '/PROPIEDADES DEL FORMULARIO


    Private Sub FrmCustomer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If

    End Sub
    Private Sub FrmCustomer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        description_interes = ""
        description_capital = ""
        fld_fecha.Value = SCALAR_STRING("SELECT DATE(Now())")
    End Sub

    '/SUB PROGRAMAS
    Private Sub SAVE_CHAGER_CUOTAS(ByVal id_doc As String, ByVal abono_interes As Double, ByVal abono_capital As Double, ByVal abono_mora As Double)

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_cuotas SET fld_interes_cuota_balance=fld_interes_cuota_balance-" & abono_interes & ", fld_interes_cuota_abono=" & abono_interes & " , fld_capital_cuota_balance=fld_capital_cuota_balance-" & abono_capital & ", fld_capital_cuota_abono=" & abono_capital & ", fld_fecha_ultimo_abono_cuotas='" & formatDate(fld_fecha.Value.Date) & "', fld_balance_cuotas=fld_balance_cuotas-" & abono_interes + abono_capital & ", fld_abono_cuotas=" & abono_interes + abono_capital & ", fld_balance_mora=fld_balance_mora-" & abono_mora & ", fld_abono_mora=" & abono_mora & " WHERE  fld_id_cuotas=" & id_doc & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd = Nothing
    End Sub

    Private Sub SAVE_DETALLE_NC(ByVal id_doc As String, ByVal abono_interes As Double, ByVal abono_capital As Double, ByVal ri_no As Integer, ByVal tipo As String, ByVal abono_mora As Double)

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "INSERT INTO tbl_nc_cxc_detalle (fld_cuota_id,fld_ult_abono_interes,fld_ult_abono_capital,fld_id_ri_padre, fld_tipo_doc_ri_d, fld_ultimo_abono_mora) VALUES(" & id_doc & ", " & abono_interes & ", " & abono_capital & ", " & ri_no & ", '" & tipo & "', " & abono_mora & ")"
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd = Nothing

    End Sub

    Private Sub LISTA_CLIENTES()
        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            LOAD_CUSTOMER(Id)
            Dim idCliente = Id
            If FRMS_LIST_PRESTAMOS_POR_CLIENTE(txtFirstName.Text, Id) = True Then
                fld_id_prestamo.Text = Id

                fld_concepto.Focus()
            End If
            LOAD_CUOTAS(fld_id_prestamo.Text, idCliente)

        End If
    End Sub
    Private Sub DESABLE_FIELDS()
        txtFirstName.Enabled = False


        txtBalance.Enabled = False
    End Sub
    Private Sub ENABLE_FIELDS()
        txtFirstName.Enabled = True

        txtBalance.Enabled = True
    End Sub
    Private Sub CLEAR_FIELDS()
        fld_concepto.Text = ""
        txtCustomerID.Text = ""
        txtFirstName.Text = ""

        txtBalance.Text = "0.00"
        txtMontoCobrar.Text = "0.00"
        fld_id_prestamo.Text = ""
        fld_total_interes.Text = "0.00"
    End Sub
    Private Sub LOAD_CUSTOMER(ByVal id_CUST As String)
        Dim isdata As Boolean = False
        Dim dsCliente As New DataSet
        Dim daCliente As New MySqlDataAdapter("SELECT * FROM tbl_clientes WHERE fld_id=" & id_CUST & "", conn)
        daCliente.Fill(dsCliente, "tbl_clientes")

        Dim nr As DataRow
        For Each nr In dsCliente.Tables(0).Rows
            txtCustomerID.Text = id_CUST
            txtFirstName.Text = nr("fld_FullName")
        Next
        conn.Close()


    End Sub
    Dim porciento As Double = 0

   
    Private Sub AplicaMora()
        If cbOmitirMora.Checked = True Then Exit Sub
        Dim nr As DataRow
        Dim doc_date As Date, sys_date As Date
        sys_date = Now.Date

        Dim porciento As Double = SCALAR_NUM("SELECT fldTazaMora FROM tbl_prestamos WHERE fld_id_prestamos=" & CInt(fld_id_prestamo.Text) & "") / 30


        For Each nr In ds.Tables(0).Rows
            If nr("fld_tipo_cuotas") = "ND" Then GoTo vuela

            If CDate(nr("fld_fecha_ultimo_abono_cuotas")) = CDate(nr("fld_fecha_entrega_cuotas")) Then ' SI LA FECHA DE BONO ES LA MISMA DE ENTREGA, ENTOCES NO SE LE A ABONADO A ESTA CUOTA Y LA FECHA PARA COMPARAR ES LA QUE TERMINA LA CUOTA
                doc_date = nr("fld_fecha_termina_cuotas")
            Else
                doc_date = nr("fld_fecha_ultimo_abono_cuotas")
            End If

            If CDate(nr("fld_fecha_ultimo_abono_cuotas")) <= CDate(nr("fld_fecha_termina_cuotas")) Then
                '//VALIDA QUE CUANDO TENGAN ADELANTO TOME LA FECHA EN QUE TERMINA LA CUOTA PARA CALCULAR LA MORA
                doc_date = nr("fld_fecha_termina_cuotas")
            End If

            If nr("fld_interes_cuota_balance") = nr("fld_interes_cuota") Then
                If nr("fld_capital_cuota_balance") = nr("fld_capital_cuota") Then
                    'VERIFICA QUE EL BCE DEL CAPITAL SEA IGUAL AL CAPITAL Y EL BCE DEL INTERES SEA IGUAL AL INTERES
                    'ESTO PARA ESTABLECER LA FECHA DEL DOC, QUE DEBE SER IGUAL A LA FECHA QUE TERMINA
                    doc_date = nr("fld_fecha_termina_cuotas")
                End If
            End If



            nr("fld_dias_vencimiento") = 0

            If DateDiff(DateInterval.Day, doc_date, sys_date) >= DiasGracias Then 'SI LOS DIAS QUE TIENE DE VENCIDA ES IGUAL O MAYOR A LOS DIAS QUE SE LE DA DE GRACIA ENTONCES ENTRA A CALCULAR

                If DateDiff(DateInterval.Day, doc_date, sys_date) > 0 Then
                    'RETIFICAMOS QUE LOS DÍAS DE DIFERENCIA SEAN MAYOR QUE CERO

                    nr("fld_dias_vencimiento") = DateDiff(DateInterval.Day, doc_date, sys_date)
                    Dim bce_cuota As Double = nr("fld_capital_cuota_balance") + nr("fld_interes_cuota_balance")

                    nr("fld_monto_mora") = Math.Round(CDbl((bce_cuota * CDbl(porciento)) / 100) * nr("fld_dias_vencimiento"))
                    nr("fld_balance_mora") = nr("fld_monto_mora")

                End If

            Else
vuela:
                nr("fld_dias_vencimiento") = 0
                nr("fld_monto_mora") = 0
                nr("fld_balance_mora") = 0
            End If
        Next

    End Sub
    Private Sub LOAD_CUOTAS(ByVal IdPrest As Integer, ByVal IdCliente As Integer)

        Dim SQLSTRING As String
        SQLSTRING = "SELECT * FROM tbl_cuotas WHERE fld_balance_cuotas > 0 AND (fld_id_del_prestamo=" & IdPrest & " OR fld_id_del_prestamo=0) AND fld_id_del_cliente_cuotas=" & IdCliente & "  ORDER BY fld_no_cuotas"


        StyleFact()
        ds = New DataSet
        da = New MySqlDataAdapter(SQLSTRING, conn)
        da.Fill(ds, "tbl_cuotas")
        AplicaMora()

        DG.DataSource = ds.Tables(0)

        Dim DataTable As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable = ds.Tables(0)
        DataTable.DefaultView.AllowNew = False

        BCE()

    End Sub
    Private Sub CREATE_NC()

        Dim description As String = description_interes + " / " + description_capital

        Dim nr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_nc_cxc", conn)
        da.Fill(ds, "tbl_nc_cxc")

        nr = ds.Tables(0).NewRow
        nr("fld_cliente_id_nc") = CInt(txtCustomerID.Text)
        nr("fld_fecha") = "'" & formatDate(fld_fecha.Value) & "'"
        nr("fld_concepto") = fld_concepto.Text
        nr("fld_monto") = CDbl(txtMontoCobrar.Text)
        nr("fld_user") = User(0)
        nr("fld_Status_nc") = "N"
        ds.Tables(0).Rows.Add(nr)


        conn.Open()
        Dim cmd As New MySqlCommandBuilder(da)
        da.InsertCommand = cmd.GetInsertCommand
        da.Update(ds, "tbl_nc_cxc")
        ds.AcceptChanges()
        conn.Close()


        ds.Dispose()
        da.Dispose()

        'CREAR_TRANSACIONES(loadLastInvoiceID("tbl_recibo_ingresos_cxc", "fld_Id_RI"))


    End Sub
    Private WithEvents docToPrint As New Printing.PrintDocument


    Private Sub StyleFact()
        DG.TableStyles.Clear()

        ' Create a new DataGridTableStyle and set 
        ' its MappingName to the TableName of a DataTable. 

        Dim ts1 As New DataGridTableStyle
        ts1.GridLineColor = Color.Peru
        ts1.MappingName = "tbl_cuotas"


        ' Add a GridColumnStyle and set its MappingName 
        ' to the name of a DataColumn in the DataTable. 
        ' Set the HeaderText and Width properties. 

        ' Add a second column style.  
        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "fld_id_cuotas"
        TextCol.HeaderText = "Id. No."
        TextCol.Width = 0
        TextCol.ReadOnly = True
        TextCol.NullText = ""
        ts1.GridColumnStyles.Add(TextCol)


        Dim checkbox = New DataGridBoolColumn
        checkbox.MappingName = "fldchk"
        checkbox.HeaderText = "S"
        checkbox.Width = 20
        checkbox.FalseValue = "False"
        checkbox.TrueValue = "True"
        checkbox.AllowNull = False
        checkbox.NullValue = "False"
        'AddHandler checkbox.Boolean.KeyPress, New KeyPressEventHandler(AddressOf KeyPress)
        ts1.GridColumnStyles.Add(checkbox)


        Dim TextCol0 As New DataGridTextBoxColumn
        TextCol0.MappingName = "fld_no_cuotas"
        TextCol0.HeaderText = "Cuota No."
        TextCol0.Width = 80
        TextCol0.ReadOnly = True
        TextCol0.NullText = ""
        ts1.GridColumnStyles.Add(TextCol0)


        ' Add a second column style. 
        Dim TextCol1 As New DataGridTextBoxColumn
        TextCol1.MappingName = "fld_fecha_termina_cuotas"
        TextCol1.HeaderText = "VENCE"
        TextCol1.Width = 125
        TextCol1.ReadOnly = True
        TextCol1.NullText = ""
        TextCol1.Format = "dd-MMM-yyyy"
        ts1.GridColumnStyles.Add(TextCol1)

        Dim TextCol1121 As New DataGridTextBoxColumn
        TextCol1121.MappingName = "fld_dias_vencimiento"
        TextCol1121.HeaderText = "D"
        TextCol1121.Width = 30
        TextCol1121.ReadOnly = True
        TextCol1121.Alignment = HorizontalAlignment.Center
        TextCol1121.Format = "##,##0"
        TextCol1121.NullText = ""
        ts1.GridColumnStyles.Add(TextCol1121)

        'Dim TextCol112 As New DataGridTextBoxColumn
        'TextCol112.MappingName = "fld_monto_mora"
        'TextCol112.HeaderText = "M. MORA"
        'TextCol112.Width = 65
        'TextCol112.ReadOnly = True
        'TextCol112.Alignment = HorizontalAlignment.Right
        'TextCol112.Format = "C2"
        'TextCol112.NullText = ""
        'ts1.GridColumnStyles.Add(TextCol112)

        '' Add a second column style. 
        'Dim TextCol22 As New DataGridTextBoxColumn
        'TextCol22.MappingName = "fld_abono_mora"
        'TextCol22.HeaderText = "A. MORA"
        'TextCol22.Width = 65
        'TextCol22.Format = "C2"
        'TextCol22.Alignment = HorizontalAlignment.Right
        'TextCol22.ReadOnly = True
        'TextCol22.NullText = ""
        'ts1.GridColumnStyles.Add(TextCol22)



        ' Add a second column style. 
        Dim TextCol42 As New DataGridTextBoxColumn
        TextCol42.MappingName = "fld_balance_mora"
        TextCol42.HeaderText = "B. MORA"
        TextCol42.Width = 125
        TextCol42.Format = "C2"
        TextCol42.Alignment = HorizontalAlignment.Right
        TextCol42.ReadOnly = True
        TextCol42.NullText = ""
        ts1.GridColumnStyles.Add(TextCol42)

        'Dim TextCol11 As New DataGridTextBoxColumn
        'TextCol11.MappingName = "fld_interes_cuota"
        'TextCol11.HeaderText = "M. INTERES"
        'TextCol11.Width = 65
        'TextCol11.ReadOnly = True
        'TextCol11.Alignment = HorizontalAlignment.Right
        'TextCol11.Format = "C2"
        'TextCol11.NullText = ""
        'ts1.GridColumnStyles.Add(TextCol11)

        '' Add a second column style. 
        'Dim TextCol2 As New DataGridTextBoxColumn
        'TextCol2.MappingName = "fld_interes_cuota_abono"
        'TextCol2.HeaderText = "A. INTERES"
        'TextCol2.Width = 65
        'TextCol2.Format = "C2"
        'TextCol2.Alignment = HorizontalAlignment.Right
        'TextCol2.ReadOnly = True
        'TextCol2.NullText = ""
        'ts1.GridColumnStyles.Add(TextCol2)



        ' Add a second column style. 
        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "fld_interes_cuota_balance"
        TextCol4.HeaderText = "B. INTERES"
        TextCol4.Width = 125
        TextCol4.Format = "C2"
        TextCol4.Alignment = HorizontalAlignment.Right
        TextCol4.ReadOnly = True
        TextCol4.NullText = ""
        ts1.GridColumnStyles.Add(TextCol4)


        'Dim TextCol15 As New DataGridTextBoxColumn
        'TextCol15.MappingName = "fld_capital_cuota"
        'TextCol15.HeaderText = "M. CAPITAL"
        'TextCol15.Width = 65
        'TextCol15.ReadOnly = True
        'TextCol15.Alignment = HorizontalAlignment.Right
        'TextCol15.Format = "C2"
        'TextCol15.NullText = ""
        'ts1.GridColumnStyles.Add(TextCol15)

        '' Add a second column style. 
        'Dim TextCol16 As New DataGridTextBoxColumn
        'TextCol16.MappingName = "fld_capital_cuota_abono"
        'TextCol16.HeaderText = "A. CAPITAL"
        'TextCol16.Width = 65
        'TextCol16.Format = "C2"
        'TextCol16.Alignment = HorizontalAlignment.Right
        'TextCol16.ReadOnly = True
        'TextCol16.NullText = ""
        'ts1.GridColumnStyles.Add(TextCol16)

        'Add a second column style. 
        Dim TextCol7 As New DataGridTextBoxColumn
        TextCol7.MappingName = "fld_capital_cuota_balance"
        TextCol7.HeaderText = "B. CAPITAL"
        TextCol7.Width = 125
        TextCol7.Format = "C2"
        TextCol7.Alignment = HorizontalAlignment.Right
        TextCol7.ReadOnly = True
        TextCol7.NullText = ""
        ts1.GridColumnStyles.Add(TextCol7)

        'Add a second column style. 
        Dim TextCol8 As New DataGridTextBoxColumn
        TextCol8.MappingName = "fld_balance_cuotas"
        TextCol8.HeaderText = "B. CUOTA"
        TextCol8.Width = 125
        TextCol8.Format = "C2"
        TextCol8.Alignment = HorizontalAlignment.Right
        TextCol8.ReadOnly = True
        TextCol8.NullText = ""
        ts1.GridColumnStyles.Add(TextCol8)

        'Dim checkbox = New DataGridBoolColumn
        'checkbox.MappingName = "fld_chk"
        'checkbox.HeaderText = "S"
        'checkbox.Width = 20
        'checkbox.FalseValue = ""
        'checkbox.TrueValue = True
        'checkbox.AllowNull = False
        'checkbox.NullValue = ""
        'AddHandler checkbox.Boolean.KeyPress, New KeyPressEventHandler(AddressOf DateKeyPress)
        'ts1.GridColumnStyles.Add(checkbox)

        ts1.RowHeadersVisible = False

        ' Add the DataGridTableStyle objects to the collection. 
        DG.GridLineColor.GetHashCode()
        DG.TableStyles.Add(ts1)



    End Sub


    Private Sub BCE()
        Dim dr As DataRow
        Dim bce_capital As Double = 0, bce_mora As Double = 0, bce_interes As Double = 0
        If Trim(fld_id_prestamo.Text) = "" Then fld_id_prestamo.Text = 0

        For Each dr In ds.Tables(0).Rows
            bce_capital = bce_capital + Format(dr("fld_capital_cuota_balance"), "C20")
            bce_mora = bce_mora + Format(dr("fld_balance_mora"), "C20")
            bce_interes = bce_interes + Format(dr("fld_interes_cuota_balance"), "C20")
        Next

        txtBalance.Text = Format((bce_interes) + (bce_capital + bce_mora), "C2")


    End Sub
    Private Sub CALCULO()

        description_interes = ""
        description_capital = ""

        descripcion_cliente = ""
        Dim monto_cliente_detalle As Double
        monto = 0
        capital_cobrado = 0
        interes_cobrado = 0
        monto_cta_cobrado = 0
        monto = CDbl(txtMontoCobrar.Text)
        monto_cliente_detalle = Format(monto, "C2")
       

        Dim rows As DataRow, monto_mora As Double = 0

        If monto <= 0 Then
            Exit Sub
        End If

        interes_cobrado = 0
        mora_cobrada = 0

        For Each rows In ds.Tables(0).Rows
            If rows("fldchk") = "True" Then

                If monto >= rows("fld_balance_mora") Then 'TRABAJA CON LA MORA
                    rows("fld_abono_mora") = rows("fld_abono_mora") + rows("fld_balance_mora")
                    monto = monto - rows("fld_balance_mora")
                    rows("fld_ultimo_abono_mora") = rows("fld_balance_mora")
                    mora_cobrada = mora_cobrada + rows("fld_balance_mora")
                    rows("fld_balance_mora") = 0
                ElseIf monto < rows("fld_balance_mora") Then
                    If monto <= 0 Then
                        Exit For
                    End If
                    rows("fld_abono_mora") = rows("fld_abono_mora") + monto
                    rows("fld_balance_mora") = rows("fld_balance_mora") - monto
                    rows("fld_ultimo_abono_mora") = monto
                    mora_cobrada = mora_cobrada + monto
                    monto = monto - monto
                End If

                If monto >= rows("fld_interes_cuota_balance") Then 'TRABAJA CON EL INTERES DE LA CUAOTA


                    rows("fld_interes_cuota_abono") = rows("fld_interes_cuota_abono") + rows("fld_interes_cuota_balance")
                    monto = monto - rows("fld_interes_cuota_balance")
                    rows("fld_fecha_ultimo_abono_cuotas") = Now.Date
                    rows("fld_ultimo_abono_interes") = rows("fld_interes_cuota_balance")
                    rows("fld_status_cuotas") = "Pagada"

                    interes_cobrado = interes_cobrado + rows("fld_interes_cuota_balance")

                    rows("fld_interes_cuota_balance") = 0



                ElseIf monto < rows("fld_interes_cuota_balance") Then

                    If monto < 0.009 Then
                        Exit For
                    End If

                    rows("fld_interes_cuota_abono") = rows("fld_interes_cuota_abono") + monto
                    rows("fld_interes_cuota_balance") = rows("fld_interes_cuota_balance") - monto
                    rows("fld_fecha_ultimo_abono_cuotas") = Now.Date
                    rows("fld_ultimo_abono_interes") = monto
                    rows("fld_status_cuotas") = "Abono"
                    interes_cobrado = interes_cobrado + monto



                    monto = monto - monto

                End If

                If monto >= rows("fld_capital_cuota_balance") Then 'TRABAJA CON EL CAPITAL DE LA CUOTA

                    rows("fld_capital_cuota_abono") = rows("fld_capital_cuota_abono") + rows("fld_capital_cuota_balance")
                    monto = monto - rows("fld_capital_cuota_balance")
                    rows("fld_fecha_ultimo_abono_cuotas") = Now.Date
                    rows("fld_ultimo_abono_capital") = rows("fld_capital_cuota_balance")
                    rows("fld_status_cuotas") = "Pagada"
                    capital_cobrado = capital_cobrado + rows("fld_capital_cuota_balance")

                    rows("fld_capital_cuota_balance") = 0



                ElseIf monto < rows("fld_capital_cuota_balance") Then

                    If monto < 0.009 Then
                        Exit For
                    End If

                    rows("fld_capital_cuota_abono") = rows("fld_capital_cuota_abono") + monto
                    rows("fld_capital_cuota_balance") = rows("fld_capital_cuota_balance") - monto
                    rows("fld_fecha_ultimo_abono_cuotas") = Now.Date
                    rows("fld_ultimo_abono_capital") = monto
                    rows("fld_status_cuotas") = "Abono"
                    capital_cobrado = capital_cobrado + monto


                    monto = monto - monto
                End If
            End If
        Next



        DG.DataSource = ds.Tables(0)
        Dim DataTable As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable = ds.Tables(0)
        DataTable.DefaultView.AllowNew = False


        fld_total_mora.Text = Format(monto_mora + mora_cobrada, "C2")
        fld_total_interes.Text = Format(interes_cobrado, "C2")


    End Sub
    Private Sub COBRANDO()
        CALCULO()

        If interes_cobrado + capital_cobrado + mora_cobrada = 0 Then
            Alerta("No se ha podido aplicar el CREDITO, selecione los documentos que serán afectados")
            txtMontoCobrar.Text = "0.00"
            Exit Sub
        End If

        If CDbl(txtMontoCobrar.Text) > CDbl(txtBalance.Text) Then
            txtMontoCobrar.Text = "0.00"
            txtMontoCobrar.SelectAll()
            Alerta("El Monto a Cobrar no es válido, no debe ser mayor al balance del CLIENTE")
            Exit Sub
        End If

      
        If Alerta("Verifique que todo sea correcto" & Chr(13) & "¿Desea continuar?") = False Then
            DESHACER_DS()
            Exit Sub
        End If

        Dim show As New FrmPopupMessage
        show.Show("Actualizando... Por favor espere")

        Dim dr_cuotas As DataRow, dr_nd As DataRow
        If ds.HasChanges = True Then
            For Each dr_cuotas In ds.Tables(0).Rows
                If dr_cuotas("fld_ultimo_abono_interes") > 0 Or dr_cuotas("fld_ultimo_abono_capital") > 0 Or dr_cuotas("fld_ultimo_abono_mora") > 0 Then
                    SAVE_CHAGER_CUOTAS(dr_cuotas("fld_id_cuotas"), dr_cuotas("fld_ultimo_abono_interes"), dr_cuotas("fld_ultimo_abono_capital"), dr_cuotas("fld_abono_mora"))
                    SAVE_DETALLE_NC(dr_cuotas("fld_id_cuotas"), dr_cuotas("fld_ultimo_abono_interes"), dr_cuotas("fld_ultimo_abono_capital"), UltimoID("tbl_nc_cxc", "fld_id_nc_cxc") + 1, "C", dr_cuotas("fld_ultimo_abono_mora"))
                End If
            Next
        End If

        CREATE_NC()

        create_row_estado_cliente(txtCustomerID.Text, CDbl(txtMontoCobrar.Text), "NCCXC", UltimoID("tbl_nc_cxc", "fld_id_nc_cxc"), fld_concepto.Text, formatDate(fld_fecha.Value.Date))


        UPDATE_PRESTAMOS(fld_id_prestamo.Text)

        LOAD_CUSTOMER(txtCustomerID.Text)
        LOAD_CUOTAS(fld_id_prestamo.Text, txtCustomerID.Text)

        txtMontoCobrar.Text = "0.00"
        fld_concepto.Text = ""
        fld_total_interes.Text = "0.00"
        fld_total_mora.Text = "0.00"

        show.Close()


        description_interes = ""
        description_capital = ""

        print_doc_nc(UltimoID("tbl_nc_cxc", "fld_id_nc_cxc"))


    End Sub
    Private Sub DESHACER_DS()
        description_interes = ""
        description_capital = ""
        ds.RejectChanges()
    End Sub

    Private Sub print_doc_nc(ByVal id_doc As String)
        PrintDialog1.AllowSomePages = True


        PrintDialog1.ShowHelp = True

        PrintDialog1.Document = docToPrint


        Dim result As DialogResult = PrintDialog1.ShowDialog()

        ' If the result is OK then print the document.
        If (result = Windows.Forms.DialogResult.OK) Then
            PRINT_DOC(id_doc, PrintDialog1.PrinterSettings.PrinterName)
        End If



    End Sub
    '/BOTONES

    Public Sub PRINT_DOC(ByVal field_id As String, ByVal nombre_printer As String)

        Dim pd As New PrintDocument, strOldPrinter As String
        strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print 


        Dim WshNetwork As Object
        WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
        WshNetwork.SetDefaultPrinter(nombre_printer) 'Set the Default Print 

        Dim ds As New DataSet

        Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
        daP.Fill(ds, "tbl_profiledocument")

        Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_cxc_nota_credito WHERE fld_id_nc_cxc=" & field_id & "", conn)
        daP1.Fill(ds, "view_cxc_nota_credito")


        Dim dr As DataRow

        For Each dr In ds.Tables(1).Rows
            Dim largo = Len(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")))
            Dim decimales = Mid(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")), largo - 2)

            dr("fld_nombre_banco2") = Num2Text(dr("fld_monto") - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
        Next

        Dim Report As New RPT_NC_CXC
        Report.Database.Tables(0).SetDataSource(ds)
        Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
        Report.PrintOptions.PrinterName = nombre_printer
        Report.PrintToPrinter(1, True, 0, 0)


        WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print






    End Sub
    Private Sub btnGuarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DESHACER_DS()
    End Sub
    Private Sub btnOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOn.Click
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            dr("fldchk") = True
        Next


    End Sub
    Private Sub btnOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOff.Click
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            dr("fldchk") = False
        Next

    End Sub


    '/FIELD PROPIEDADES
    Private Sub txtMontoCobrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoCobrar.Click
        txtMontoCobrar.SelectAll()
    End Sub
    Private Sub txtMontoCobrar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoCobrar.Enter
        txtMontoCobrar.SelectAll()
    End Sub
    Private Sub txtMontoCobrar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoCobrar.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If


        If e.KeyChar = Chr(13) Then

            Dim amount As Decimal = CType(txtMontoCobrar.Text, Decimal)
            Me.txtMontoCobrar.Text = String.Format("{0:n2}", amount)
            Me.btnGuradar.Focus()
        End If
    End Sub
    Private Sub txtCustomerID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustomerID.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            If txtCustomerID.Text <> "" Then
                LOAD_CUSTOMER(txtCustomerID.Text)
                If FRMS_LIST_PRESTAMOS_POR_CLIENTE(txtFirstName.Text, txtCustomerID.Text) = True Then
                    fld_id_prestamo.Text = Id
                    LOAD_CUOTAS(fld_id_prestamo.Text, txtCustomerID.Text)
                End If



            End If
        End If
    End Sub


    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        LISTA_CLIENTES()
    End Sub

    Private Sub fld_monto_mora_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_monto_mora.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_id_cuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_id_cuotas.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosSINPUNTO(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub FRM_NC_CXC_COMP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            LISTA_CLIENTES()
        End If
    End Sub

    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        CLEAR_FIELDS()
        ENABLE_FIELDS()
        ds.Reset()
    End Sub

    Private Sub btnGuradar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuradar.Click
        If Trim(txtMontoCobrar.Text) = "" Then txtMontoCobrar.Text = 0
        If CDbl(txtMontoCobrar.Text) <= 0 Then Exit Sub
        COBRANDO()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        'id = Nothing
        Me.Close()
    End Sub

    Private Sub cbOmitirMora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOmitirMora.Click
        If FRMS_CLAVE_MAESTRA("Acceso") = False Then cbOmitirMora.Checked = False

    End Sub


    Private Sub txtMontoCobrar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoCobrar.TextChanged

    End Sub
End Class
