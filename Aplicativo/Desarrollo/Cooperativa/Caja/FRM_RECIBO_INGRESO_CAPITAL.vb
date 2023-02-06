Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing
Imports System.IO
Public Class FRM_RECIBO_INGRESO_CAPITAL
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
    Friend WithEvents btnCierra As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFormaDePago As System.Windows.Forms.ComboBox
    Friend WithEvents fld_detalle_forma_pago As System.Windows.Forms.TextBox
    Friend WithEvents btn_cobrar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents fld_id_prestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fld_concepto As System.Windows.Forms.TextBox
    Friend WithEvents fld_total_interes As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fld_total_mora As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cbOmitirMora As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBceMora As System.Windows.Forms.TextBox
    Friend WithEvents fld_monto_mora As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents btnOn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBceCapital As System.Windows.Forms.TextBox
    Friend WithEvents txtBceInteres As System.Windows.Forms.TextBox
    Friend WithEvents cbAdelanto As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents fld_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ctaContableTxt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_RECIBO_INGRESO_CAPITAL))
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnOff = New System.Windows.Forms.Button
        Me.btnOn = New System.Windows.Forms.Button
        Me.fld_monto_mora = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbOmitirMora = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.fld_total_mora = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.fld_total_interes = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.fld_concepto = New System.Windows.Forms.TextBox
        Me.fld_id_prestamo = New System.Windows.Forms.TextBox
        Me.fld_detalle_forma_pago = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtFormaDePago = New System.Windows.Forms.ComboBox
        Me.txtMontoCobrar = New System.Windows.Forms.TextBox
        Me.DG = New System.Windows.Forms.DataGrid
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.btnBusca = New System.Windows.Forms.Button
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.lblCustomerID = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtCustomerID = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_cobrar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCierra = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.txtBceCapital = New System.Windows.Forms.TextBox
        Me.txtBceInteres = New System.Windows.Forms.TextBox
        Me.txtBceMora = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.cbAdelanto = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.fld_fecha = New System.Windows.Forms.DateTimePicker
        Me.ctaContableTxt = New System.Windows.Forms.TextBox
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(360, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Seleccionar todo"
        '
        'btnOff
        '
        Me.btnOff.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOff.ForeColor = System.Drawing.Color.Black
        Me.btnOff.Location = New System.Drawing.Point(408, 142)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(40, 24)
        Me.btnOff.TabIndex = 103
        Me.btnOff.Text = "No"
        '
        'btnOn
        '
        Me.btnOn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn.ForeColor = System.Drawing.Color.Black
        Me.btnOn.Location = New System.Drawing.Point(360, 142)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(40, 24)
        Me.btnOn.TabIndex = 102
        Me.btnOn.Text = "Si"
        '
        'fld_monto_mora
        '
        Me.fld_monto_mora.Location = New System.Drawing.Point(56, 184)
        Me.fld_monto_mora.Name = "fld_monto_mora"
        Me.fld_monto_mora.TabIndex = 81
        Me.fld_monto_mora.Text = "0.00"
        Me.fld_monto_mora.Visible = False
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(-8, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "Detalle:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbOmitirMora
        '
        Me.cbOmitirMora.Checked = True
        Me.cbOmitirMora.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbOmitirMora.Location = New System.Drawing.Point(368, 56)
        Me.cbOmitirMora.Name = "cbOmitirMora"
        Me.cbOmitirMora.TabIndex = 78
        Me.cbOmitirMora.Text = "Omitir Mora"
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(504, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(264, 24)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "El Bce. incluye la Mora y Notas de Débitos"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(376, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Fecha :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_total_mora
        '
        Me.fld_total_mora.BackColor = System.Drawing.Color.White
        Me.fld_total_mora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_total_mora.Location = New System.Drawing.Point(960, 128)
        Me.fld_total_mora.Name = "fld_total_mora"
        Me.fld_total_mora.ReadOnly = True
        Me.fld_total_mora.Size = New System.Drawing.Size(128, 20)
        Me.fld_total_mora.TabIndex = 9
        Me.fld_total_mora.Text = "0.00"
        Me.fld_total_mora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(816, 128)
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
        Me.fld_total_interes.Location = New System.Drawing.Point(960, 104)
        Me.fld_total_interes.Name = "fld_total_interes"
        Me.fld_total_interes.ReadOnly = True
        Me.fld_total_interes.Size = New System.Drawing.Size(128, 20)
        Me.fld_total_interes.TabIndex = 8
        Me.fld_total_interes.Text = "0.00"
        Me.fld_total_interes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(864, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Total Interes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_concepto
        '
        Me.fld_concepto.BackColor = System.Drawing.Color.White
        Me.fld_concepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_concepto.Location = New System.Drawing.Point(504, 36)
        Me.fld_concepto.MaxLength = 1000
        Me.fld_concepto.Multiline = True
        Me.fld_concepto.Name = "fld_concepto"
        Me.fld_concepto.Size = New System.Drawing.Size(272, 48)
        Me.fld_concepto.TabIndex = 6
        Me.fld_concepto.Text = "N/A"
        '
        'fld_id_prestamo
        '
        Me.fld_id_prestamo.BackColor = System.Drawing.Color.White
        Me.fld_id_prestamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_id_prestamo.Location = New System.Drawing.Point(88, 80)
        Me.fld_id_prestamo.MaxLength = 8
        Me.fld_id_prestamo.Name = "fld_id_prestamo"
        Me.fld_id_prestamo.ReadOnly = True
        Me.fld_id_prestamo.Size = New System.Drawing.Size(272, 20)
        Me.fld_id_prestamo.TabIndex = 3
        Me.fld_id_prestamo.Text = "0"
        Me.fld_id_prestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_detalle_forma_pago
        '
        Me.fld_detalle_forma_pago.BackColor = System.Drawing.Color.White
        Me.fld_detalle_forma_pago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_detalle_forma_pago.Location = New System.Drawing.Point(88, 126)
        Me.fld_detalle_forma_pago.Multiline = True
        Me.fld_detalle_forma_pago.Name = "fld_detalle_forma_pago"
        Me.fld_detalle_forma_pago.ReadOnly = True
        Me.fld_detalle_forma_pago.Size = New System.Drawing.Size(272, 40)
        Me.fld_detalle_forma_pago.TabIndex = 5
        Me.fld_detalle_forma_pago.Text = "N/A"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(-8, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Forma de pago:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFormaDePago
        '
        Me.txtFormaDePago.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.txtFormaDePago.ForeColor = System.Drawing.Color.White
        Me.txtFormaDePago.ItemHeight = 13
        Me.txtFormaDePago.Items.AddRange(New Object() {"CHEQUE", "TARJETA", "EFECTIVO"})
        Me.txtFormaDePago.Location = New System.Drawing.Point(88, 102)
        Me.txtFormaDePago.Name = "txtFormaDePago"
        Me.txtFormaDePago.Size = New System.Drawing.Size(272, 21)
        Me.txtFormaDePago.TabIndex = 4
        Me.txtFormaDePago.Text = "EFECTIVO"
        '
        'txtMontoCobrar
        '
        Me.txtMontoCobrar.BackColor = System.Drawing.Color.White
        Me.txtMontoCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCobrar.Location = New System.Drawing.Point(504, 88)
        Me.txtMontoCobrar.Name = "txtMontoCobrar"
        Me.txtMontoCobrar.Size = New System.Drawing.Size(272, 29)
        Me.txtMontoCobrar.TabIndex = 7
        Me.txtMontoCobrar.Text = "0.00"
        Me.txtMontoCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DG
        '
        Me.DG.BackgroundColor = System.Drawing.Color.White
        Me.DG.CaptionVisible = False
        Me.DG.DataMember = ""
        Me.DG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG.Location = New System.Drawing.Point(0, 216)
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(776, 232)
        Me.DG.TabIndex = 15
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.White
        Me.txtBalance.Location = New System.Drawing.Point(88, 58)
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
        Me.btnBusca.Location = New System.Drawing.Point(232, 12)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(128, 24)
        Me.btnBusca.TabIndex = 0
        Me.btnBusca.Text = "&Lista de Préstamos"
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(8, 38)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(72, 16)
        Me.lblFirstName.TabIndex = 36
        Me.lblFirstName.Text = "Socio:"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCustomerID
        '
        Me.lblCustomerID.Location = New System.Drawing.Point(8, 16)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(72, 16)
        Me.lblCustomerID.TabIndex = 35
        Me.lblCustomerID.Text = "Código:"
        Me.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.White
        Me.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstName.Location = New System.Drawing.Point(88, 36)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(272, 20)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.Text = ""
        '
        'txtCustomerID
        '
        Me.txtCustomerID.BackColor = System.Drawing.Color.White
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(88, 14)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(88, 20)
        Me.txtCustomerID.TabIndex = 0
        Me.txtCustomerID.Text = "0"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(-8, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Cod. Préstamo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Monto a cobrar:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(376, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Concepto :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_cobrar
        '
        Me.btn_cobrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cobrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cobrar.Image = CType(resources.GetObject("btn_cobrar.Image"), System.Drawing.Image)
        Me.btn_cobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cobrar.Location = New System.Drawing.Point(80, 456)
        Me.btn_cobrar.Name = "btn_cobrar"
        Me.btn_cobrar.Size = New System.Drawing.Size(72, 56)
        Me.btn_cobrar.TabIndex = 12
        Me.btn_cobrar.Text = "&Guardar"
        Me.btn_cobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnCierra
        '
        Me.btnCierra.BackColor = System.Drawing.SystemColors.Control
        Me.btnCierra.ForeColor = System.Drawing.Color.Black
        Me.btnCierra.Image = CType(resources.GetObject("btnCierra.Image"), System.Drawing.Image)
        Me.btnCierra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierra.Location = New System.Drawing.Point(704, 456)
        Me.btnCierra.Name = "btnCierra"
        Me.btnCierra.Size = New System.Drawing.Size(72, 56)
        Me.btnCierra.TabIndex = 13
        Me.btnCierra.Text = "&Cerrar"
        Me.btnCierra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(8, 456)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtBceCapital
        '
        Me.txtBceCapital.BackColor = System.Drawing.Color.White
        Me.txtBceCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBceCapital.Location = New System.Drawing.Point(504, 192)
        Me.txtBceCapital.Name = "txtBceCapital"
        Me.txtBceCapital.ReadOnly = True
        Me.txtBceCapital.Size = New System.Drawing.Size(125, 20)
        Me.txtBceCapital.TabIndex = 11
        Me.txtBceCapital.Text = "0.00"
        Me.txtBceCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBceInteres
        '
        Me.txtBceInteres.BackColor = System.Drawing.Color.White
        Me.txtBceInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBceInteres.Location = New System.Drawing.Point(376, 192)
        Me.txtBceInteres.Name = "txtBceInteres"
        Me.txtBceInteres.ReadOnly = True
        Me.txtBceInteres.Size = New System.Drawing.Size(125, 20)
        Me.txtBceInteres.TabIndex = 10
        Me.txtBceInteres.Text = "0.00"
        Me.txtBceInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBceMora
        '
        Me.txtBceMora.BackColor = System.Drawing.Color.White
        Me.txtBceMora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBceMora.Location = New System.Drawing.Point(248, 192)
        Me.txtBceMora.Name = "txtBceMora"
        Me.txtBceMora.ReadOnly = True
        Me.txtBceMora.Size = New System.Drawing.Size(125, 20)
        Me.txtBceMora.TabIndex = 9
        Me.txtBceMora.Text = "0.00"
        Me.txtBceMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(320, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Mora:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(736, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Limpiar Préstamos"
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(856, 216)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 56)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "&Recarcular Interes"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.Visible = False
        '
        'cbAdelanto
        '
        Me.cbAdelanto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAdelanto.Location = New System.Drawing.Point(856, 184)
        Me.cbAdelanto.Name = "cbAdelanto"
        Me.cbAdelanto.Size = New System.Drawing.Size(424, 24)
        Me.cbAdelanto.TabIndex = 16
        Me.cbAdelanto.Text = "Adelanto de Efectivo a Cuenta por Cobrar"
        Me.cbAdelanto.Visible = False
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(413, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Interes:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(541, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 107
        Me.Label12.Text = "Capital:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(240, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 48)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sumatorias"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(160, 472)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(456, 24)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "ABONO A CAPITAL"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 111
        Me.Label15.Text = "Balance:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_fecha
        '
        Me.fld_fecha.CustomFormat = "dd / MMM / yyyy"
        Me.fld_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha.Location = New System.Drawing.Point(504, 14)
        Me.fld_fecha.Name = "fld_fecha"
        Me.fld_fecha.Size = New System.Drawing.Size(272, 20)
        Me.fld_fecha.TabIndex = 5
        Me.fld_fecha.Value = New Date(2016, 5, 13, 11, 49, 59, 445)
        '
        'ctaContableTxt
        '
        Me.ctaContableTxt.Location = New System.Drawing.Point(168, 176)
        Me.ctaContableTxt.Name = "ctaContableTxt"
        Me.ctaContableTxt.TabIndex = 112
        Me.ctaContableTxt.Text = "0.00"
        Me.ctaContableTxt.Visible = False
        '
        'FRM_RECIBO_INGRESO_CAPITAL
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(778, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.ctaContableTxt)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbAdelanto)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnCierra)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btn_cobrar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtBceInteres)
        Me.Controls.Add(Me.txtBceMora)
        Me.Controls.Add(Me.txtBceCapital)
        Me.Controls.Add(Me.fld_total_mora)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.fld_total_interes)
        Me.Controls.Add(Me.fld_concepto)
        Me.Controls.Add(Me.fld_id_prestamo)
        Me.Controls.Add(Me.fld_detalle_forma_pago)
        Me.Controls.Add(Me.txtMontoCobrar)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.fld_monto_mora)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFormaDePago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.btnBusca)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnOn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbOmitirMora)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.fld_fecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_RECIBO_INGRESO_CAPITAL"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo de ingresos por Abono  a Capital"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim dsCuotas As DataSet
    Dim da As MySqlDataAdapter
    Dim monto As Double
    Dim capitalCobrado As Double, interesCobrado As Double, moraCobrada As Double
    Dim tipoPrestamo As String

#Region "Limpia Prestamo"

    Private Sub clear_cuotas()

        Dim cmd As New MySqlCommand
        With cmd
            .CommandText = "UPDATE tbl_cuotas set fld_abono_cuotas=fld_monto_cuotas, fld_balance_cuotas=0, fld_capital_cuota_abono=fld_capital_cuota, fld_capital_cuota_balance=0, fld_interes_cuota_abono=fld_interes_cuota, fld_interes_cuota_balance=0 where fld_id_del_prestamo=" & fld_id_prestamo.Text & ""
            .Connection = conn
            .Connection.Open()
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()
    End Sub

    Private Sub clear_prestamo()

        Dim cmd As New MySqlCommand
        With cmd
            .CommandText = "UPDATE tbl_prestamos SET fld_abono=fld_monto, fld_balance=0 WHERE fld_id_prestamos=" & fld_id_prestamo.Text & ""
            .Connection = conn
            .Connection.Open()
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()

    End Sub

#End Region


    Private Sub aplicaInteres(ByVal idPrestamos As Integer)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT c.fld_id_cuotas, c.fld_fecha_entrega_cuotas, c.fld_fecha_termina_cuotas, p.fld_fecha_calcula_interes, p.fld_clasificacion, p.fld_interes_p, p.fld_id_prestamos, p.fld_capital_prestamo, p.fld_tipo_prestamo FROM tbl_cuotas AS c INNER JOIN tbl_prestamos AS p ON c.fld_id_del_prestamo=p.fld_id_prestamos WHERE MONTH(fld_fecha_termina_cuotas)= MONTH(Now()) AND c.fld_balance_cuotas > 0 AND p.fld_id_prestamos=" & idPrestamos & "", conn)
        da.Fill(ds)

        Dim nr As DataRow
        Dim doc_date As Date, sys_date As Date

        sys_date = CDate(SCALAR_STRING("SELECT DATE(Now())"))

        Dim bceCapital As Double = SCALAR_NUM("SELECT SUM(fld_capital_cuota_balance) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & CInt(fld_id_prestamo.Text) & "")

        Dim dias As Integer = 0


        For Each nr In ds.Tables(0).Rows

            'Solo válidamos los préstamos que son con intereses diarios  
            If nr("fld_clasificacion") = "Int. Diario Sobre Saldo Insoluto" Or nr("fld_clasificacion") = "Int. Diario Sobre Capital Inicial" Then
                'Validamos solo las que vence en el mes actual, esto es para controlar que no me le siga calculando a las cuotas que ya han sido calculada 
                'en su totalidad "Meses anteriores"
                MessageBox.Show(dias)

                dias = DateDiff(DateInterval.Day, nr("fld_fecha_calcula_interes"), sys_date) 'Devuelve los días desde el útimo
                'día que se calculo el interes


                Dim Interes As Double = 0
                Interes = nr("fld_interes_p") / 30
                If nr("fld_tipo_prestamo") <> "MENSUAL" Then
                    Interes = nr("fld_interes_p") / 15
                End If
                If nr("fld_clasificacion") = "Int. Diario Sobre Saldo Insoluto" Then
                    Interes = (bceCapital * Interes / 100) * dias
                ElseIf nr("fld_clasificacion") = "Int. Diario Sobre Capital Inicial" Then
                    Interes = CDbl((nr("fld_capital_prestamo") * Interes) / 100) * dias
                End If

                If dias > 0 Then
                    NON_QUERY("UPDATE tbl_cuotas SET fld_interes_cuota=fld_interes_cuota + " & Interes & ", fld_interes_cuota_balance=fld_interes_cuota-fld_interes_cuota_abono, fld_balance_cuotas=fld_interes_cuota_balance+fld_capital_cuota_balance, fld_monto_cuotas=fld_interes_cuota_balance+fld_capital_cuota_balance WHERE fld_id_cuotas=" & nr("fld_id_cuotas") & "; UPDATE tbl_prestamos SET fld_fecha_calcula_interes=Now() WHERE fld_id_prestamos=" & nr("fld_id_prestamos") & "")
                End If

            End If
        Next

    End Sub

    '/PROPIEDADES DEL FORMULARIO
    Private Sub FrmCustomer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon

        fld_fecha.Value = SCALAR_STRING("SELECT DATE(Now())")

    End Sub

    '/SUB PROGRAMAS
    Private Sub SAVE_CHAGER_CUOTAS(ByVal id_doc As String, ByVal abono_interes As Double, ByVal abono_capital As Double, ByVal abono_cuota As Double, ByVal abono_mora As Double)

        NON_QUERY("UPDATE tbl_cuotas SET fld_interes_cuota_abono=fld_interes_cuota_abono + " & abono_interes & ",  fld_interes_cuota_balance=fld_interes_cuota-fld_interes_cuota_abono,  fld_capital_cuota_abono=fld_capital_cuota_abono+" & abono_capital & ",fld_capital_cuota_balance=fld_capital_cuota-fld_capital_cuota_abono, fld_fecha_ultimo_abono_cuotas='" & formatDate(fld_fecha.Value.Date) & "', fld_abono_cuotas=fld_abono_cuotas + " & abono_capital + abono_interes & ", fld_balance_cuotas=fld_monto_cuotas-fld_abono_cuotas WHERE  fld_id_cuotas=" & id_doc & "")

    End Sub

    Private Sub SAVE_DETALLE_INGRESOS(ByVal id_doc As String, ByVal abono_interes As Double, ByVal abono_capital As Double, ByVal ri_no As Integer, ByVal tipo As String, ByVal abono_mora As Double)

        NON_QUERY("INSERT INTO tbl_recibo_ingresos_cxc_detalle (fld_cuota_id,fld_ult_abono_interes,fld_ult_abono_capital,fld_id_ri_padre, fld_tipo_doc_ri_d, fld_ultimo_abono_mora) VALUES(" & id_doc & ", " & abono_interes & ", " & abono_capital & ", " & ri_no & ", '" & tipo & "', " & abono_mora & ")")


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
        fld_total_mora.Text = "0.00"
        fld_concepto.Text = ""
        txtCustomerID.Text = ""
        txtFirstName.Text = ""

        txtBalance.Text = "0.00"
        txtMontoCobrar.Text = "0.00"
        fld_id_prestamo.Text = "0"
        fld_total_interes.Text = "0.00"
        cbOmitirMora.Checked = False
        ctaContableTxt.Text = ""
        monto = 0
        capitalCobrado = 0
        interesCobrado = 0
        moraCobrada = 0
    End Sub

    Private Sub LOAD_CUSTOMER(ByVal id_CUST As String)
        Dim isdata As Boolean = False
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT fld_id, fld_FullName,ctaContable FROM tbl_clientes WHERE fld_id=" & id_CUST & "", conn)
        da.Fill(ds, "tbl_clientes")

        Dim nr As DataRow
        For Each nr In ds.Tables(0).Rows
            txtCustomerID.Text = nr("fld_id")
            txtFirstName.Text = nr("fld_FullName")
            ctaContableTxt.Text = nr("ctaContable")
        Next
        conn.Close()


    End Sub
    Dim porciento As Double = 0 '/INI FILE

    Private Sub UPDATE_DATE_PRESTAMO(ByVal ID_P As String, ByVal FECHA As String)
        Dim CMD As New MySqlCommand
        With CMD
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_prestamos SET fld_fecha_ultimo_abono='" & FECHA & "' WHERE fld_id_prestamos=" & ID_P & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        CMD.Dispose()
    End Sub

    Private Sub LOAD_CUOTAS(ByVal IdPrest As Integer, ByVal IdCliente As Integer)

        Dim SQLSTRING As String
        SQLSTRING = "SELECT *, fld_interes_cuota_balance+fld_capital_cuota_balance+fld_balance_mora as totalCuota FROM tbl_cuotas WHERE fld_capital_cuota_balance > 0 AND (fld_id_del_prestamo=" & IdPrest & " OR fld_id_del_prestamo=0) AND fld_id_del_cliente_cuotas=" & IdCliente & " ORDER BY fld_no_cuotas"
        StyleFact()
        




        dsCuotas = New DataSet
        da = New MySqlDataAdapter(SQLSTRING, conn)
        da.Fill(dsCuotas, "tbl_cuotas")


        AplicaMora()



        'If txtClasificacion.Text = "Int. Diario Sobre Saldo Insoluto" Or txtClasificacion.Text = "Int. Diario Sobre Capital Inicial" Then
        Dim dr As DataRow
        Dim bceCapital As Double = 0


        For Each dr In dsCuotas.Tables(0).Rows
            bceCapital = bceCapital + dr("fld_capital_cuota_balance")
            'bceAcumulado = bceAcumulado + bceInteres
            dr("fld_balance_cuotas") = bceCapital
            dr("fld_status_cuotas") = "Por Cobrar"
            If dr("fld_capital_cuota_balance") = 0 Then
                dr("fld_balance_cuotas") = 0

                If CDate(dr("fld_fecha_termina_cuotas")) < fld_fecha.Value.Date Then
                    dr("fld_status_cuotas") = "Salda"

                End If

            End If

        Next
        'End If


        DG.DataSource = dsCuotas.Tables(0)

        Dim DataTable As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable = dsCuotas.Tables(0)
        DataTable.DefaultView.AllowNew = False

        BCE()

    End Sub

    Private Sub AplicaMora()
        If cbOmitirMora.Checked = True Then Exit Sub
        Dim nr As DataRow
        Dim doc_date As Date, sys_date As Date
        sys_date = Now.Date

        Dim porciento As Double = SCALAR_NUM("SELECT fldTazaMora FROM tbl_prestamos WHERE fld_id_prestamos=" & CInt(fld_id_prestamo.Text) & "") / 30


        For Each nr In dsCuotas.Tables(0).Rows
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

    Private Sub CREATE_INGRESOS()

        Dim adelanto As String = "False"
        If cbAdelanto.Checked = True Then
            adelanto = "True"
        End If


        Dim bceCapital As Double = SCALAR_NUM("SELECT SUM(fld_capital_cuota_balance) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_id_prestamo.Text & "")

        Dim capitalCobrado As Double = CDbl(txtMontoCobrar.Text) - (CDbl(fld_total_interes.Text) + CDbl(fld_total_mora.Text))

        Try
            Dim cmd As New MySqlCommand
            With cmd
                .Connection = conn
                .Connection.Open()
                .CommandText = "INSERT INTO tbl_recibo_ingresos_cxc (fld_forma_pago,fld_detalle_forma_pago,fld_id_cliente_ri,fld_date,fld_Description,fld_monto,fld_fact_afectado,fdl_nd_afectado,fld_User,fld_Estado,fld_id_prestamo, fld_concepto, fld_interes_cobrado, fld_capital_cobrado, fld_mora_cobrada, fld_socio,fld_adelanto, fld_bce_actual, fld_monto_recibido) VALUES('" & txtFormaDePago.Text & "','" & fld_detalle_forma_pago.Text & "'," & txtCustomerID.Text & ",'" & formatDate(fld_fecha.Value) & "','" & fld_concepto.Text & "'," & CDec(txtMontoCobrar.Text) & ",'0','0','" & User(0) & "','NEW'," & fld_id_prestamo.Text & ",'" & fld_concepto.Text & "'," & CDbl(fld_total_interes.Text) & ", " & capitalCobrado & ", " & CDbl(fld_total_mora.Text) & ",'" & txtFirstName.Text & "','" & adelanto & "', " & bceCapital & ",0)"
                .ExecuteNonQuery()
                .Connection.Close()
            End With
            cmd.Dispose()

            Dim Atraso As Double = SCALAR_NUM("SELECT IFNULL(SUM(fld_capital_cuota_balance) + SUM(fld_interes_cuota_balance),0) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_id_prestamo.Text & " AND DATE(fld_fecha_termina_cuotas) < DATE(NOW())")

            Dim RI As Integer = UltimoID("tbl_recibo_ingresos_cxc", "fld_Id_RI")

            'InterfarContableRecibosIngresosCxC(fld_fecha.Value.Date, CDec(capitalCobrado), CDec(fld_total_interes.Text), CDec(fld_total_mora.Text), 0, RI, fld_concepto.Text, ctaContableTxt.Text)

            Dim FechaVencePrestamos As Date = SCALAR_STRING("SELECT fld_fecha_termina FROM tbl_prestamos WHERE fld_id_prestamos=" & fld_id_prestamo.Text & "")

            Dim MontoCuota As Double = SCALAR_NUM("SELECT fld_monto_cuotas_a FROM tbl_prestamos WHERE fld_id_prestamos=" & fld_id_prestamo.Text & "")
            Dim MontoPrestamos As Double = SCALAR_NUM("SELECT fld_capital_prestamo FROM tbl_prestamos WHERE fld_id_prestamos=" & fld_id_prestamo.Text & "")
            NON_QUERY("INSERT INTO tbl_recibo_ingresos_imprimir (ReciboNo, FechaRecibo, Cliente, PrestamoNo, MontoPrestamo, FechaVencePrestamo, MontoCuota, CapitalPagado, InterePagado, MoraPagada, OtroMontoPagado, MontoRecibido, CapitalAdeudado, Atraso, Concepto, Usuario) (SELECT fld_Id_RI, fld_date, fld_socio, fld_id_prestamo," & MontoPrestamos & ", '" & formatDate(FechaVencePrestamos) & "'," & MontoCuota & ", fld_capital_cobrado, fld_interes_cobrado, fld_mora_cobrada,0,fld_monto_recibido," & bceCapital & "," & Atraso & ",fld_Description, fld_User FROM tbl_recibo_ingresos_cxc WHERE fld_Id_RI=" & RI & ")")
        Catch ex As Exception

        End Try


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
        TextCol0.HeaderText = "DOC.NO."
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


        ' Add a second column style. 
        Dim TextCol40 As New DataGridTextBoxColumn
        TextCol40.MappingName = "fld_balance_mora"
        TextCol40.HeaderText = "Bce. de Mora"
        TextCol40.Width = 125
        TextCol40.Format = "C2"
        TextCol40.Alignment = HorizontalAlignment.Right
        TextCol40.ReadOnly = True
        TextCol40.NullText = ""
        ts1.GridColumnStyles.Add(TextCol40)



        ' Add a second column style. 
        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "fld_interes_cuota_balance"
        TextCol4.HeaderText = "Bce. de Interes"
        TextCol4.Width = 125
        TextCol4.Format = "C2"
        TextCol4.Alignment = HorizontalAlignment.Right
        TextCol4.ReadOnly = True
        TextCol4.NullText = ""
        ts1.GridColumnStyles.Add(TextCol4)

        'Add a second column style. 
        Dim TextCol7 As New DataGridTextBoxColumn
        TextCol7.MappingName = "fld_capital_cuota_balance"
        TextCol7.HeaderText = "Bce. de Capital"
        TextCol7.Width = 125
        TextCol7.Format = "C2"
        TextCol7.Alignment = HorizontalAlignment.Right
        TextCol7.ReadOnly = True
        TextCol7.NullText = ""
        ts1.GridColumnStyles.Add(TextCol7)

        'Add a second column style. 
        Dim TextCol8 As New DataGridTextBoxColumn
        TextCol8.MappingName = "fld_balance_cuotas"
        TextCol8.HeaderText = "Acumulado"
        TextCol8.Width = 125
        TextCol8.Format = "C2"
        TextCol8.Alignment = HorizontalAlignment.Right
        TextCol8.ReadOnly = True
        TextCol8.NullText = ""
        ts1.GridColumnStyles.Add(TextCol8)

        'Add a second column style. 
        'Dim TextCol9 As New DataGridTextBoxColumn
        'TextCol9.MappingName = "totalCuota"
        'TextCol9.HeaderText = "TOTAL CUOTA"
        'TextCol9.Width = 125
        'TextCol9.Format = "C2"
        'TextCol9.Alignment = HorizontalAlignment.Right
        'TextCol9.ReadOnly = True
        'TextCol9.NullText = ""
        'ts1.GridColumnStyles.Add(TextCol9)

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
        Dim bce_cuota As Double = 0, bce_mora As Double = 0, bce_capital As Double = 0, bce_interes As Double = 0
        If Trim(fld_id_prestamo.Text) = "" Then fld_id_prestamo.Text = 0

        For Each dr In dsCuotas.Tables(0).Rows
            bce_interes = bce_interes + Format(dr("fld_interes_cuota_balance"), "C20")
            bce_capital = bce_capital + Format(dr("fld_capital_cuota_balance"), "C20")
            bce_mora = bce_mora + Format(dr("fld_balance_mora"), "C20")
            bce_cuota = bce_cuota + dr("fld_balance_cuotas")

        Next
        txtBalance.Text = Format(bce_mora + (bce_interes + bce_capital), "C2")
        txtBceMora.Text = Format(bce_mora, "C2")
        txtBceInteres.Text = Format(bce_interes, "C2")
        txtBceCapital.Text = Format(bce_capital, "C2")
        'txtBceCuota.Text = Format(bce_interes + bce_capital, "C2")
       


    End Sub

    Private Sub Calcular()

        Dim detalleConcepto As String = String.Empty
        Dim monto_cliente_detalle As Double
        monto = 0
        capitalCobrado = 0
        interesCobrado = 0
        moraCobrada = 0

        monto = CDbl(txtMontoCobrar.Text)

        monto_cliente_detalle = monto

        Dim rows As DataRow



        For Each rows In dsCuotas.Tables(0).Rows

            If rows("fldchk") = "True" Then

                '                If monto >= rows("fld_balance_mora") Then 'TRABAJA CON LA MORA
                '                    rows("fld_abono_mora") = rows("fld_abono_mora") + rows("fld_balance_mora")
                '                    monto = monto - rows("fld_balance_mora")
                '                    rows("fld_ultimo_abono_mora") = rows("fld_balance_mora")
                '                    moraCobrada = moraCobrada + rows("fld_balance_mora")
                '                    rows("fld_balance_mora") = 0

                '                ElseIf monto < rows("fld_balance_mora") Then

                '                    If monto <= 0 Then
                '                        Exit For
                '                    End If

                '                    rows("fld_abono_mora") = rows("fld_abono_mora") + monto
                '                    rows("fld_balance_mora") = rows("fld_balance_mora") - monto
                '                    rows("fld_ultimo_abono_mora") = monto
                '                    moraCobrada = moraCobrada + monto
                '                    monto = monto - monto

                '                End If
                'sigue:
                '                If monto >= rows("fld_interes_cuota_balance") Then 'TRABAJA CON EL INTERES DE LA CUAOTA
                '                    rows("fld_interes_cuota_abono") = rows("fld_interes_cuota_abono") + rows("fld_interes_cuota_balance")
                '                    monto = monto - rows("fld_interes_cuota_balance")
                '                    rows("fld_fecha_ultimo_abono_cuotas") = Now.Date
                '                    rows("fld_ultimo_abono_interes") = rows("fld_interes_cuota_balance")
                '                    rows("fld_status_cuotas") = "Pagada"
                '                    interesCobrado = interesCobrado + rows("fld_interes_cuota_balance")
                '                    rows("fld_interes_cuota_balance") = 0

                '                ElseIf monto < rows("fld_interes_cuota_balance") Then

                '                    If monto < 0 Then
                '                        Exit For
                '                    End If

                '                    rows("fld_interes_cuota_abono") = rows("fld_interes_cuota_abono") + monto
                '                    rows("fld_interes_cuota_balance") = rows("fld_interes_cuota_balance") - monto
                '                    rows("fld_fecha_ultimo_abono_cuotas") = Now.Date
                '                    rows("fld_ultimo_abono_interes") = monto
                '                    rows("fld_status_cuotas") = "Abono"
                '                    interesCobrado = interesCobrado + monto
                '                    monto = monto - monto

                '                End If

                 

                If monto >= rows("fld_capital_cuota_balance") Then 'TRABAJA CON EL CAPITAL DE LA CUOTA

                    rows("fld_capital_cuota_abono") = rows("fld_capital_cuota_abono") + rows("fld_capital_cuota_balance")
                    monto = monto - rows("fld_capital_cuota_balance")
                    rows("fld_fecha_ultimo_abono_cuotas") = Now.Date
                    rows("fld_ultimo_abono_capital") = rows("fld_capital_cuota_balance")
                    rows("fld_status_cuotas") = "Pagada"
                    If rows("fld_tipo_cuotas") = "ND" Then
                        moraCobrada = moraCobrada + rows("fld_capital_cuota_balance")
                    Else
                        capitalCobrado = capitalCobrado + rows("fld_capital_cuota_balance")
                    End If


                    rows("fld_capital_cuota_balance") = 0

                ElseIf monto < rows("fld_capital_cuota_balance") Then

                    If monto < 0 Then
                        Exit For
                    End If

                    rows("fld_capital_cuota_abono") = rows("fld_capital_cuota_abono") + monto
                    rows("fld_capital_cuota_balance") = rows("fld_capital_cuota_balance") - monto
                    rows("fld_fecha_ultimo_abono_cuotas") = Now.Date
                    rows("fld_ultimo_abono_capital") = monto
                    rows("fld_status_cuotas") = "Abono"

                    If rows("fld_tipo_cuotas") = "ND" Then
                        moraCobrada = moraCobrada + monto
                    Else
                        capitalCobrado = capitalCobrado + monto
                    End If


                    monto = monto - monto
                End If


            End If
        Next

        DG.DataSource = dsCuotas.Tables(0)
        Dim DataTable As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable = dsCuotas.Tables(0)
        DataTable.DefaultView.AllowNew = False

        fld_total_mora.Text = Format(moraCobrada, "C2")
        fld_total_interes.Text = Format(interesCobrado, "C2")

        If moraCobrada > 0 Then
            monto_cliente_detalle = monto_cliente_detalle - moraCobrada ' + CDbl(fld_total_interes.Text))
            fld_concepto.Text = "Mora cobrada = " & moraCobrada & " " & fld_concepto.Text
        End If

    End Sub

    Private Sub COBRANDO()
        If txtFormaDePago.Text = "" Then
            Alerta("Por favor seleccione una forma de pago")
            txtFormaDePago.Focus()
            Exit Sub
        End If


        If monto = CDbl(txtMontoCobrar.Text) Then
            Alerta("No se ha podido aplicar el COBRO, selecione los documentos que serán afectados")
            txtMontoCobrar.Text = "0.00"
            Exit Sub
        End If

        Calcular()


        If Alerta("¿Seguro que desea continuar?") = False Then Return

        Dim show As New FrmPopupMessage
        show.Show("Actualizando... Por favor espere")
        Dim IdRecibo As Integer = UltimoID("tbl_recibo_ingresos_cxc", "fld_Id_RI") + 1

        If cbAdelanto.Checked = False Then

            Dim dr_cuotas As DataRow
            For Each dr_cuotas In dsCuotas.Tables(0).Rows
                If dr_cuotas("fld_ultimo_abono_interes") > 0 Or dr_cuotas("fld_ultimo_abono_capital") > 0 Or dr_cuotas("fld_ultimo_abono_mora") > 0 Then
                    SAVE_CHAGER_CUOTAS(dr_cuotas("fld_id_cuotas"), dr_cuotas("fld_ultimo_abono_interes"), dr_cuotas("fld_ultimo_abono_capital"), dr_cuotas("fld_abono_cuotas"), dr_cuotas("fld_abono_mora"))
                    SAVE_DETALLE_INGRESOS(dr_cuotas("fld_id_cuotas"), dr_cuotas("fld_ultimo_abono_interes"), dr_cuotas("fld_ultimo_abono_capital"), IdRecibo, "C", dr_cuotas("fld_ultimo_abono_mora"))
                End If
            Next

            UPDATE_DATE_PRESTAMO(fld_id_prestamo.Text, formatDate(fld_fecha.Value.Date))

            If CDbl(fld_total_mora.Text) > 0 Then
                create_row_estado_cliente(txtCustomerID.Text, CDbl(fld_total_mora.Text), "NDCXC", IdRecibo, "MORA GENERADA MEDIANTE RECIBO No." & IdRecibo, formatDate(fld_fecha.Value.Date))
            End If
            create_row_estado_cliente(txtCustomerID.Text, CDbl(txtMontoCobrar.Text), "RECIBOCOBROCXC", IdRecibo, fld_concepto.Text, formatDate(fld_fecha.Value.Date))

            UPDATE_PRESTAMOS(fld_id_prestamo.Text)

        Else

            create_row_estado_cliente(txtCustomerID.Text, CDbl(txtMontoCobrar.Text), "RECIBOCOBROCXC", fld_id_prestamo.Text, fld_concepto.Text, formatDate(fld_fecha.Value.Date))
            NON_QUERY("INSERT INTO tbl_historia_delantos_cxc (IDCliente, IDRecibo, Fecha, Monto, Usuario) VALUES(" & txtCustomerID.Text & "," & IdRecibo & ",Now()," & CDbl(txtMontoCobrar.Text) & ",'" & User(0) & "')")

        End If

        LOAD_CUSTOMER(txtCustomerID.Text)
        LOAD_CUOTAS(fld_id_prestamo.Text, txtCustomerID.Text)

        CREATE_INGRESOS()

        txtMontoCobrar.Text = "0.00"
        fld_concepto.Text = String.Empty
        fld_total_interes.Text = "0.00"
        fld_total_mora.Text = "0.00"


        show.Close()

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
            PRINT_DOCUMENTO_RI(IdRecibo, PrintDialog1.PrinterSettings.PrinterName)
        End If
        WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print
        CLEAR_FIELDS()
        ENABLE_FIELDS()
        dsCuotas.Clear()

    End Sub

    Private Sub DESHACER_DS()
        dsCuotas.RejectChanges()
        txtMontoCobrar.Text = "0.00"
        fld_total_interes.Text = "0.00"
    End Sub



    '/BOTONES
    Private Sub btnCierra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierra.Click
        'id = Nothing
        Me.Close()
    End Sub

    Private Sub btnOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOn.Click
        Dim dr As DataRow
        For Each dr In dsCuotas.Tables(0).Rows
            dr("fldchk") = True
        Next
    End Sub

    Private Sub btnOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOff.Click
        Dim dr As DataRow
        For Each dr In dsCuotas.Tables(0).Rows
            dr("fldchk") = False
        Next
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        CLEAR_FIELDS()
        ENABLE_FIELDS()
        dsCuotas.Reset()
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
            Me.btn_cobrar.Focus()
        End If

    End Sub


    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        If FRMS_LIST_PRESTAMOS() = True Then '
            fld_id_prestamo.Text = Id
            'aplicaInteres(Id)
            'txtClasificacion.Text = SCALAR_STRING("SELECT fld_clasificacion FROM tbl_prestamos WHERE fld_id_prestamos=" & Id & "")
            Dim idCliente = SCALAR_NUM("SELECT fld_id_del_cliente FROM tbl_prestamos WHERE fld_id_prestamos=" & Id & "")
            LOAD_CUSTOMER(idCliente)
            LOAD_CUOTAS(Id, idCliente)
            txtFormaDePago.Focus()
        End If
    End Sub


    Private Sub txtFormaDePago_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFormaDePago.SelectedValueChanged

        If txtFormaDePago.Text <> "EFECTIVO" Then
            fld_detalle_forma_pago.ReadOnly = False
        Else
            fld_detalle_forma_pago.ReadOnly = True
        End If

    End Sub

    Private Sub btn_cobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cobrar.Click
        If fld_concepto.TextLength <= 10 Then
            Alerta("Escriba un concepto válido")
            fld_concepto.Focus()
            Exit Sub
        End If
        If Trim(txtMontoCobrar.Text) = "" Then txtMontoCobrar.Text = 0
        If CDbl(txtMontoCobrar.Text) <= 0 Then Exit Sub
        If cbAdelanto.Checked = False Then
            If CDbl(txtMontoCobrar.Text) > CDbl(txtBalance.Text) Then
                Alerta("No puede cobrar más dinero que el balance del cliente")
                Exit Sub
            End If
        End If
        COBRANDO()
    End Sub

    Private Sub txtFormaDePago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFormaDePago.KeyDown
        If e.KeyCode = Keys.Enter Then
            fld_detalle_forma_pago.Focus()
        End If
    End Sub

    Private Sub txtFormaDePago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFormaDePago.KeyPress
        e.Handled = True
    End Sub

    Private Sub fld_detalle_forma_pago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_detalle_forma_pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            fld_concepto.Focus()
        End If
    End Sub

    Private Sub txtMontoCobrar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoCobrar.TextChanged

    End Sub

    Private Sub fld_monto_mora_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_id_cuotas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosSINPUNTO(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If FRMS_CLAVE_MAESTRA("Borrar") = True Then
            If Alerta("Seguro que desea limpiar este préstamo?") = True Then
                clear_prestamo()
                clear_cuotas()
                CLEAR_FIELDS()
                ENABLE_FIELDS()
                dsCuotas.Reset()
            End If

        End If
    End Sub

    Private Sub cbOmitirMora_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbOmitirMora.Click
        If FRMS_CLAVE_MAESTRA("Acceso") = False Then cbOmitirMora.Checked = False

    End Sub


    Private Sub txtCustomerID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerID.TextChanged

    End Sub
End Class
