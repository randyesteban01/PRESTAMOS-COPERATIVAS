Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing
Imports System.IO
Public Class FRM_RECIBO_INGRESO
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
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fld_concepto As System.Windows.Forms.TextBox
    Friend WithEvents fld_total_interes As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fld_total_mora As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cbOmitirMora As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBceMora As System.Windows.Forms.TextBox
    Friend WithEvents txtBceCuota As System.Windows.Forms.TextBox
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtClasificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ctaContableTxt As System.Windows.Forms.TextBox
    Friend WithEvents cmbCajas As System.Windows.Forms.ComboBox
    Friend WithEvents PaneNroCheque As Panel
    Friend WithEvents PaneTranferencia As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents PaneTargeta As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents resUnoTxt As TextBox
    Friend WithEvents unoTxt As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cambioTxt As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents totalTxt As TextBox
    Friend WithEvents resCincoTxt As TextBox
    Friend WithEvents resDiezTxt As TextBox
    Friend WithEvents resVeiticincoTxt As TextBox
    Friend WithEvents resCincuentaTxt As TextBox
    Friend WithEvents resCienTxt As TextBox
    Friend WithEvents resDocientoTxt As TextBox
    Friend WithEvents resQuinientoTxt As TextBox
    Friend WithEvents resMilTxt As TextBox
    Friend WithEvents resDosmilTxt As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents cheque As TextBox
    Friend WithEvents cincoTxt As TextBox
    Friend WithEvents diezTxt As TextBox
    Friend WithEvents venticincoTxt As TextBox
    Friend WithEvents cincuentaTxt As TextBox
    Friend WithEvents cienTxt As TextBox
    Friend WithEvents docientoTxt As TextBox
    Friend WithEvents quinientoTxt As TextBox
    Friend WithEvents milTxt As TextBox
    Friend WithEvents dosmilTxt As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_RECIBO_INGRESO))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.btnOn = New System.Windows.Forms.Button()
        Me.fld_monto_mora = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbOmitirMora = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fld_total_mora = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fld_total_interes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fld_concepto = New System.Windows.Forms.TextBox()
        Me.fld_id_prestamo = New System.Windows.Forms.TextBox()
        Me.fld_detalle_forma_pago = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFormaDePago = New System.Windows.Forms.ComboBox()
        Me.txtMontoCobrar = New System.Windows.Forms.TextBox()
        Me.DG = New System.Windows.Forms.DataGrid()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cobrar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCierra = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtBceCuota = New System.Windows.Forms.TextBox()
        Me.txtBceCapital = New System.Windows.Forms.TextBox()
        Me.txtBceInteres = New System.Windows.Forms.TextBox()
        Me.txtBceMora = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cbAdelanto = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtClasificacion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ctaContableTxt = New System.Windows.Forms.TextBox()
        Me.cmbCajas = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PaneNroCheque = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PaneTranferencia = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PaneTargeta = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.resUnoTxt = New System.Windows.Forms.TextBox()
        Me.unoTxt = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cambioTxt = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.totalTxt = New System.Windows.Forms.TextBox()
        Me.resCincoTxt = New System.Windows.Forms.TextBox()
        Me.resDiezTxt = New System.Windows.Forms.TextBox()
        Me.resVeiticincoTxt = New System.Windows.Forms.TextBox()
        Me.resCincuentaTxt = New System.Windows.Forms.TextBox()
        Me.resCienTxt = New System.Windows.Forms.TextBox()
        Me.resDocientoTxt = New System.Windows.Forms.TextBox()
        Me.resQuinientoTxt = New System.Windows.Forms.TextBox()
        Me.resMilTxt = New System.Windows.Forms.TextBox()
        Me.resDosmilTxt = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cheque = New System.Windows.Forms.TextBox()
        Me.cincoTxt = New System.Windows.Forms.TextBox()
        Me.diezTxt = New System.Windows.Forms.TextBox()
        Me.venticincoTxt = New System.Windows.Forms.TextBox()
        Me.cincuentaTxt = New System.Windows.Forms.TextBox()
        Me.cienTxt = New System.Windows.Forms.TextBox()
        Me.docientoTxt = New System.Windows.Forms.TextBox()
        Me.quinientoTxt = New System.Windows.Forms.TextBox()
        Me.milTxt = New System.Windows.Forms.TextBox()
        Me.dosmilTxt = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaneNroCheque.SuspendLayout()
        Me.PaneTranferencia.SuspendLayout()
        Me.PaneTargeta.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(360, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 23
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
        Me.btnOff.TabIndex = 27
        Me.btnOff.Text = "No"
        Me.btnOff.UseVisualStyleBackColor = False
        '
        'btnOn
        '
        Me.btnOn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn.ForeColor = System.Drawing.Color.Black
        Me.btnOn.Location = New System.Drawing.Point(360, 142)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(40, 24)
        Me.btnOn.TabIndex = 28
        Me.btnOn.Text = "Si"
        Me.btnOn.UseVisualStyleBackColor = False
        '
        'fld_monto_mora
        '
        Me.fld_monto_mora.Location = New System.Drawing.Point(32, 176)
        Me.fld_monto_mora.Name = "fld_monto_mora"
        Me.fld_monto_mora.Size = New System.Drawing.Size(100, 20)
        Me.fld_monto_mora.TabIndex = 39
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
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Detalle:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbOmitirMora
        '
        Me.cbOmitirMora.Location = New System.Drawing.Point(364, 56)
        Me.cbOmitirMora.Name = "cbOmitirMora"
        Me.cbOmitirMora.Size = New System.Drawing.Size(104, 24)
        Me.cbOmitirMora.TabIndex = 21
        Me.cbOmitirMora.Text = "Omitir Mora"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(525, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(208, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "El Bce. incluye la Mora y Notas de Débitos"
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
        Me.fld_concepto.ReadOnly = True
        Me.fld_concepto.Size = New System.Drawing.Size(272, 48)
        Me.fld_concepto.TabIndex = 4
        Me.fld_concepto.Text = "N/A"
        '
        'fld_id_prestamo
        '
        Me.fld_id_prestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fld_id_prestamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_id_prestamo.Location = New System.Drawing.Point(88, 83)
        Me.fld_id_prestamo.MaxLength = 8
        Me.fld_id_prestamo.Name = "fld_id_prestamo"
        Me.fld_id_prestamo.Size = New System.Drawing.Size(88, 20)
        Me.fld_id_prestamo.TabIndex = 12
        Me.fld_id_prestamo.Text = "0"
        Me.fld_id_prestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_detalle_forma_pago
        '
        Me.fld_detalle_forma_pago.BackColor = System.Drawing.Color.White
        Me.fld_detalle_forma_pago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_detalle_forma_pago.Location = New System.Drawing.Point(88, 129)
        Me.fld_detalle_forma_pago.Multiline = True
        Me.fld_detalle_forma_pago.Name = "fld_detalle_forma_pago"
        Me.fld_detalle_forma_pago.ReadOnly = True
        Me.fld_detalle_forma_pago.Size = New System.Drawing.Size(272, 36)
        Me.fld_detalle_forma_pago.TabIndex = 2
        Me.fld_detalle_forma_pago.Text = "N/A"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(-8, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Forma de pago:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFormaDePago
        '
        Me.txtFormaDePago.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.txtFormaDePago.ForeColor = System.Drawing.Color.White
        Me.txtFormaDePago.ItemHeight = 13
        Me.txtFormaDePago.Items.AddRange(New Object() {"CHEQUE", "TARJETA", "EFECTIVO", "TRANFERENCIA"})
        Me.txtFormaDePago.Location = New System.Drawing.Point(88, 105)
        Me.txtFormaDePago.Name = "txtFormaDePago"
        Me.txtFormaDePago.Size = New System.Drawing.Size(140, 21)
        Me.txtFormaDePago.TabIndex = 1
        Me.txtFormaDePago.Text = "EFECTIVO"
        '
        'txtMontoCobrar
        '
        Me.txtMontoCobrar.BackColor = System.Drawing.Color.White
        Me.txtMontoCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCobrar.Location = New System.Drawing.Point(632, 88)
        Me.txtMontoCobrar.Name = "txtMontoCobrar"
        Me.txtMontoCobrar.Size = New System.Drawing.Size(144, 29)
        Me.txtMontoCobrar.TabIndex = 5
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
        Me.DG.Size = New System.Drawing.Size(776, 240)
        Me.DG.TabIndex = 40
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.White
        Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.Location = New System.Drawing.Point(88, 58)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(149, 24)
        Me.txtBalance.TabIndex = 11
        Me.txtBalance.Text = "0.00"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.SystemColors.Control
        Me.btnBusca.ForeColor = System.Drawing.Color.Black
        Me.btnBusca.Location = New System.Drawing.Point(182, 11)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(128, 24)
        Me.btnBusca.TabIndex = 0
        Me.btnBusca.Text = "&Lista de Préstamos"
        Me.btnBusca.UseVisualStyleBackColor = False
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(8, 38)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(72, 16)
        Me.lblFirstName.TabIndex = 14
        Me.lblFirstName.Text = "Socio:"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New System.Drawing.Point(9, 18)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(30, 13)
        Me.lblCustomerID.TabIndex = 13
        Me.lblCustomerID.Text = "Nro.:"
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
        Me.txtFirstName.TabIndex = 10
        '
        'txtCustomerID
        '
        Me.txtCustomerID.BackColor = System.Drawing.Color.White
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(40, 16)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(88, 20)
        Me.txtCustomerID.TabIndex = 9
        Me.txtCustomerID.Text = "0"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.BackColor = System.Drawing.SystemColors.Control
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblBalance.Location = New System.Drawing.Point(20, 60)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(57, 13)
        Me.lblBalance.TabIndex = 15
        Me.lblBalance.Text = "Balance:"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(-8, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Cod. Préstamo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(532, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Monto a cobrar:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(384, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 20
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
        Me.btn_cobrar.TabIndex = 6
        Me.btn_cobrar.Text = "&Guardar"
        Me.btn_cobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cobrar.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
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
        Me.btnCierra.TabIndex = 8
        Me.btnCierra.Text = "&Cerrar"
        Me.btnCierra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCierra.UseVisualStyleBackColor = False
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
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txtBceCuota
        '
        Me.txtBceCuota.BackColor = System.Drawing.Color.White
        Me.txtBceCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBceCuota.Location = New System.Drawing.Point(632, 192)
        Me.txtBceCuota.Name = "txtBceCuota"
        Me.txtBceCuota.ReadOnly = True
        Me.txtBceCuota.Size = New System.Drawing.Size(125, 20)
        Me.txtBceCuota.TabIndex = 34
        Me.txtBceCuota.Text = "0.00"
        Me.txtBceCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBceCapital
        '
        Me.txtBceCapital.BackColor = System.Drawing.Color.White
        Me.txtBceCapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBceCapital.Location = New System.Drawing.Point(504, 192)
        Me.txtBceCapital.Name = "txtBceCapital"
        Me.txtBceCapital.ReadOnly = True
        Me.txtBceCapital.Size = New System.Drawing.Size(125, 20)
        Me.txtBceCapital.TabIndex = 35
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
        Me.txtBceInteres.TabIndex = 36
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
        Me.txtBceMora.TabIndex = 37
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
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Mora:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(736, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 23)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Limpiar Préstamos"
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.Button4.UseVisualStyleBackColor = False
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
        Me.Label10.TabIndex = 31
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
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Capital:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(669, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Total:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(240, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 48)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sumatorias"
        '
        'txtClasificacion
        '
        Me.txtClasificacion.Location = New System.Drawing.Point(512, 144)
        Me.txtClasificacion.Name = "txtClasificacion"
        Me.txtClasificacion.Size = New System.Drawing.Size(100, 20)
        Me.txtClasificacion.TabIndex = 26
        Me.txtClasificacion.Visible = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(160, 472)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(456, 24)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "ABONO A INTERES"
        '
        'ctaContableTxt
        '
        Me.ctaContableTxt.Location = New System.Drawing.Point(128, 192)
        Me.ctaContableTxt.Name = "ctaContableTxt"
        Me.ctaContableTxt.Size = New System.Drawing.Size(100, 20)
        Me.ctaContableTxt.TabIndex = 38
        Me.ctaContableTxt.Visible = False
        '
        'cmbCajas
        '
        Me.cmbCajas.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.cmbCajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCajas.ForeColor = System.Drawing.Color.White
        Me.cmbCajas.Location = New System.Drawing.Point(504, 8)
        Me.cmbCajas.Name = "cmbCajas"
        Me.cmbCajas.Size = New System.Drawing.Size(272, 21)
        Me.cmbCajas.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(424, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Caja :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PaneNroCheque
        '
        Me.PaneNroCheque.Controls.Add(Me.TextBox1)
        Me.PaneNroCheque.Controls.Add(Me.Label16)
        Me.PaneNroCheque.Controls.Add(Me.txtCustomerID)
        Me.PaneNroCheque.Controls.Add(Me.lblCustomerID)
        Me.PaneNroCheque.Location = New System.Drawing.Point(234, 86)
        Me.PaneNroCheque.Name = "PaneNroCheque"
        Me.PaneNroCheque.Size = New System.Drawing.Size(292, 41)
        Me.PaneNroCheque.TabIndex = 72
        Me.PaneNroCheque.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(179, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(106, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(132, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Banco:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PaneTranferencia
        '
        Me.PaneTranferencia.Controls.Add(Me.TextBox2)
        Me.PaneTranferencia.Controls.Add(Me.Label17)
        Me.PaneTranferencia.Controls.Add(Me.TextBox3)
        Me.PaneTranferencia.Controls.Add(Me.Label18)
        Me.PaneTranferencia.Location = New System.Drawing.Point(234, 85)
        Me.PaneTranferencia.Name = "PaneTranferencia"
        Me.PaneTranferencia.Size = New System.Drawing.Size(292, 41)
        Me.PaneTranferencia.TabIndex = 73
        Me.PaneTranferencia.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(179, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(106, 20)
        Me.TextBox2.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(132, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Banco:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(40, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(88, 20)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 13)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Nro.:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PaneTargeta
        '
        Me.PaneTargeta.Controls.Add(Me.ComboBox2)
        Me.PaneTargeta.Controls.Add(Me.ComboBox1)
        Me.PaneTargeta.Controls.Add(Me.Label19)
        Me.PaneTargeta.Controls.Add(Me.TextBox5)
        Me.PaneTargeta.Controls.Add(Me.Label20)
        Me.PaneTargeta.Location = New System.Drawing.Point(234, 86)
        Me.PaneTargeta.Name = "PaneTargeta"
        Me.PaneTargeta.Size = New System.Drawing.Size(292, 41)
        Me.PaneTargeta.TabIndex = 73
        Me.PaneTargeta.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ComboBox2.ForeColor = System.Drawing.Color.White
        Me.ComboBox2.ItemHeight = 13
        Me.ComboBox2.Items.AddRange(New Object() {"VISA", "MASTERCARD"})
        Me.ComboBox2.Location = New System.Drawing.Point(110, 14)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox2.TabIndex = 75
        Me.ComboBox2.Text = "MASTERCARD"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Items.AddRange(New Object() {"DEBITO", "CREDITO"})
        Me.ComboBox1.Location = New System.Drawing.Point(37, 14)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(68, 21)
        Me.ComboBox1.TabIndex = 74
        Me.ComboBox1.Text = "BEBITO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Tipo:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(246, 14)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(43, 20)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(214, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 13)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Nro.:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(782, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 515)
        Me.Panel1.TabIndex = 74
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 335)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(290, 180)
        Me.Panel2.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.resUnoTxt)
        Me.GroupBox2.Controls.Add(Me.unoTxt)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.cambioTxt)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.totalTxt)
        Me.GroupBox2.Controls.Add(Me.resCincoTxt)
        Me.GroupBox2.Controls.Add(Me.resDiezTxt)
        Me.GroupBox2.Controls.Add(Me.resVeiticincoTxt)
        Me.GroupBox2.Controls.Add(Me.resCincuentaTxt)
        Me.GroupBox2.Controls.Add(Me.resCienTxt)
        Me.GroupBox2.Controls.Add(Me.resDocientoTxt)
        Me.GroupBox2.Controls.Add(Me.resQuinientoTxt)
        Me.GroupBox2.Controls.Add(Me.resMilTxt)
        Me.GroupBox2.Controls.Add(Me.resDosmilTxt)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.cheque)
        Me.GroupBox2.Controls.Add(Me.cincoTxt)
        Me.GroupBox2.Controls.Add(Me.diezTxt)
        Me.GroupBox2.Controls.Add(Me.venticincoTxt)
        Me.GroupBox2.Controls.Add(Me.cincuentaTxt)
        Me.GroupBox2.Controls.Add(Me.cienTxt)
        Me.GroupBox2.Controls.Add(Me.docientoTxt)
        Me.GroupBox2.Controls.Add(Me.quinientoTxt)
        Me.GroupBox2.Controls.Add(Me.milTxt)
        Me.GroupBox2.Controls.Add(Me.dosmilTxt)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 317)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Denominación de Dinero"
        '
        'resUnoTxt
        '
        Me.resUnoTxt.Location = New System.Drawing.Point(168, 240)
        Me.resUnoTxt.Name = "resUnoTxt"
        Me.resUnoTxt.ReadOnly = True
        Me.resUnoTxt.Size = New System.Drawing.Size(91, 20)
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
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(87, 290)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "CAMBIO"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cambioTxt
        '
        Me.cambioTxt.Location = New System.Drawing.Point(167, 290)
        Me.cambioTxt.Name = "cambioTxt"
        Me.cambioTxt.ReadOnly = True
        Me.cambioTxt.Size = New System.Drawing.Size(91, 20)
        Me.cambioTxt.TabIndex = 34
        Me.cambioTxt.Text = "0.00"
        Me.cambioTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(87, 266)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 16)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "TOTAL"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'totalTxt
        '
        Me.totalTxt.Location = New System.Drawing.Point(167, 266)
        Me.totalTxt.Name = "totalTxt"
        Me.totalTxt.ReadOnly = True
        Me.totalTxt.Size = New System.Drawing.Size(91, 20)
        Me.totalTxt.TabIndex = 32
        Me.totalTxt.Text = "0.00"
        Me.totalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resCincoTxt
        '
        Me.resCincoTxt.Location = New System.Drawing.Point(168, 216)
        Me.resCincoTxt.Name = "resCincoTxt"
        Me.resCincoTxt.ReadOnly = True
        Me.resCincoTxt.Size = New System.Drawing.Size(91, 20)
        Me.resCincoTxt.TabIndex = 30
        Me.resCincoTxt.Text = "0.00"
        Me.resCincoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resDiezTxt
        '
        Me.resDiezTxt.Location = New System.Drawing.Point(168, 192)
        Me.resDiezTxt.Name = "resDiezTxt"
        Me.resDiezTxt.ReadOnly = True
        Me.resDiezTxt.Size = New System.Drawing.Size(91, 20)
        Me.resDiezTxt.TabIndex = 29
        Me.resDiezTxt.Text = "0.00"
        Me.resDiezTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resVeiticincoTxt
        '
        Me.resVeiticincoTxt.Location = New System.Drawing.Point(168, 168)
        Me.resVeiticincoTxt.Name = "resVeiticincoTxt"
        Me.resVeiticincoTxt.ReadOnly = True
        Me.resVeiticincoTxt.Size = New System.Drawing.Size(91, 20)
        Me.resVeiticincoTxt.TabIndex = 28
        Me.resVeiticincoTxt.Text = "0.00"
        Me.resVeiticincoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resCincuentaTxt
        '
        Me.resCincuentaTxt.Location = New System.Drawing.Point(168, 144)
        Me.resCincuentaTxt.Name = "resCincuentaTxt"
        Me.resCincuentaTxt.ReadOnly = True
        Me.resCincuentaTxt.Size = New System.Drawing.Size(91, 20)
        Me.resCincuentaTxt.TabIndex = 27
        Me.resCincuentaTxt.Text = "0.00"
        Me.resCincuentaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resCienTxt
        '
        Me.resCienTxt.Location = New System.Drawing.Point(168, 120)
        Me.resCienTxt.Name = "resCienTxt"
        Me.resCienTxt.ReadOnly = True
        Me.resCienTxt.Size = New System.Drawing.Size(91, 20)
        Me.resCienTxt.TabIndex = 26
        Me.resCienTxt.Text = "0.00"
        Me.resCienTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resDocientoTxt
        '
        Me.resDocientoTxt.Location = New System.Drawing.Point(168, 96)
        Me.resDocientoTxt.Name = "resDocientoTxt"
        Me.resDocientoTxt.ReadOnly = True
        Me.resDocientoTxt.Size = New System.Drawing.Size(91, 20)
        Me.resDocientoTxt.TabIndex = 25
        Me.resDocientoTxt.Text = "0.00"
        Me.resDocientoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resQuinientoTxt
        '
        Me.resQuinientoTxt.Location = New System.Drawing.Point(168, 72)
        Me.resQuinientoTxt.Name = "resQuinientoTxt"
        Me.resQuinientoTxt.ReadOnly = True
        Me.resQuinientoTxt.Size = New System.Drawing.Size(91, 20)
        Me.resQuinientoTxt.TabIndex = 23
        Me.resQuinientoTxt.Text = "0.00"
        Me.resQuinientoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resMilTxt
        '
        Me.resMilTxt.Location = New System.Drawing.Point(168, 48)
        Me.resMilTxt.Name = "resMilTxt"
        Me.resMilTxt.ReadOnly = True
        Me.resMilTxt.Size = New System.Drawing.Size(91, 20)
        Me.resMilTxt.TabIndex = 24
        Me.resMilTxt.Text = "0.00"
        Me.resMilTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resDosmilTxt
        '
        Me.resDosmilTxt.Location = New System.Drawing.Point(168, 24)
        Me.resDosmilTxt.Name = "resDosmilTxt"
        Me.resDosmilTxt.ReadOnly = True
        Me.resDosmilTxt.Size = New System.Drawing.Size(91, 20)
        Me.resDosmilTxt.TabIndex = 22
        Me.resDosmilTxt.Text = "0.00"
        Me.resDosmilTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(33, 347)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "CHEQUE"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label23.Visible = False
        '
        'cheque
        '
        Me.cheque.Location = New System.Drawing.Point(45, 324)
        Me.cheque.Name = "cheque"
        Me.cheque.ReadOnly = True
        Me.cheque.Size = New System.Drawing.Size(91, 20)
        Me.cheque.TabIndex = 10
        Me.cheque.Text = "0.00"
        Me.cheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cheque.Visible = False
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
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 218)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 16)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "5.00"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 194)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 16)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "10.00"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(8, 170)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 16)
        Me.Label27.TabIndex = 17
        Me.Label27.Text = "25.00"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(8, 146)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 16)
        Me.Label28.TabIndex = 16
        Me.Label28.Text = "50.00"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(8, 122)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 16)
        Me.Label29.TabIndex = 15
        Me.Label29.Text = "100.00"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(8, 98)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 16)
        Me.Label30.TabIndex = 14
        Me.Label30.Text = "200.00"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(8, 74)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 16)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "500.00"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(8, 50)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(64, 16)
        Me.Label32.TabIndex = 12
        Me.Label32.Text = "1,000.00"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(8, 26)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(64, 16)
        Me.Label33.TabIndex = 11
        Me.Label33.Text = "2,000.00"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRM_RECIBO_INGRESO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1072, 515)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PaneTranferencia)
        Me.Controls.Add(Me.PaneTargeta)
        Me.Controls.Add(Me.PaneNroCheque)
        Me.Controls.Add(Me.cmbCajas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ctaContableTxt)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtClasificacion)
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
        Me.Controls.Add(Me.txtBceCuota)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBceCapital)
        Me.Controls.Add(Me.fld_total_mora)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.fld_total_interes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fld_concepto)
        Me.Controls.Add(Me.fld_id_prestamo)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.fld_detalle_forma_pago)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFormaDePago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMontoCobrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.btnBusca)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnOn)
        Me.Controls.Add(Me.fld_monto_mora)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbOmitirMora)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_RECIBO_INGRESO"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo de Ingreso"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaneNroCheque.ResumeLayout(False)
        Me.PaneNroCheque.PerformLayout()
        Me.PaneTranferencia.ResumeLayout(False)
        Me.PaneTranferencia.PerformLayout()
        Me.PaneTargeta.ResumeLayout(False)
        Me.PaneTargeta.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Dim dsCuotas As DataSet
    Dim da As MySqlDataAdapter
    Dim monto As Double
    Dim capitalCobrado As Double, interesCobrado As Double, moraCobrada As Double
    Dim tipoPrestamo As String
    Dim fechaServidor As Date

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

    Private Sub LlenarCajas()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT Id, Descripcion FROM cajamantenimiento ORDER BY Orden, Descripcion", conn)
        da.Fill(dt)

        cmbCajas.DataSource = dt
        cmbCajas.DisplayMember = "Descripcion"
        cmbCajas.ValueMember = "Id"
        da.Dispose()

    End Sub
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
        LlenarCajas()

        fechaServidor = CDate(SCALAR_STRING("SELECT Now()"))
    End Sub

    '/SUB PROGRAMAS
    Private Sub SAVE_CHAGER_CUOTAS(ByVal id_doc As String, ByVal abono_interes As Double, ByVal abono_capital As Double, ByVal abono_cuota As Double, ByVal abono_mora As Double)

        NON_QUERY("UPDATE tbl_cuotas SET fld_interes_cuota_abono=fld_interes_cuota_abono + " & abono_interes & ",  fld_interes_cuota_balance=fld_interes_cuota-fld_interes_cuota_abono,  fld_capital_cuota_abono=fld_capital_cuota_abono+" & abono_capital & ",fld_capital_cuota_balance=fld_capital_cuota-fld_capital_cuota_abono, fld_fecha_ultimo_abono_cuotas=Now(), fld_abono_cuotas=fld_abono_cuotas + " & abono_capital + abono_interes & ", fld_balance_cuotas=fld_monto_cuotas-fld_abono_cuotas WHERE  fld_id_cuotas=" & id_doc & "")

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

    Private Sub cargarCliente(ByVal id_CUST As Integer)
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

    Private Sub actFechaPrestamos(ByVal ID_P As String)
        Dim CMD As New MySqlCommand
        With CMD
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_prestamos SET fld_fecha_ultimo_abono=Now() WHERE fld_id_prestamos=" & ID_P & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        CMD.Dispose()
    End Sub

    Private Sub cargarCuotas(ByVal IdPrest As Integer, ByVal IdCliente As Integer)

        Dim SQLSTRING As String
        SQLSTRING = "SELECT *, fld_interes_cuota_balance+fld_capital_cuota_balance+fld_balance_mora as totalCuota FROM tbl_cuotas WHERE fld_balance_cuotas > 0 AND (fld_id_del_prestamo=" & IdPrest & " OR fld_id_del_prestamo=0) AND fld_id_del_cliente_cuotas=" & IdCliente & " ORDER BY fld_no_cuotas"
        StyleFact()
        Label14.Visible = True
        txtBceCuota.Visible = True
        Label12.Visible = True
        txtBceCapital.Visible = True
        If txtClasificacion.Text = "Int. Diario Sobre Saldo Insoluto" Or txtClasificacion.Text = "Int. Diario Sobre Capital Inicial" Then


            SQLSTRING = "SELECT * FROM tbl_cuotas WHERE fld_balance_cuotas > 0 AND (fld_id_del_prestamo=" & IdPrest & " OR fld_id_del_prestamo=0) AND fld_id_del_cliente_cuotas=" & IdCliente & " ORDER BY fld_no_cuotas"
            StyleFactIntereses()

            Label14.Visible = False
            txtBceCuota.Visible = False

        End If





        dsCuotas = New DataSet
        da = New MySqlDataAdapter(SQLSTRING, conn)
        da.Fill(dsCuotas, "tbl_cuotas")


        AplicaMora()



        If txtClasificacion.Text = "Int. Diario Sobre Saldo Insoluto" Or txtClasificacion.Text = "Int. Diario Sobre Capital Inicial" Then
            Dim dr As DataRow
            Dim bceInteres As Double = 0
            Dim bceAcumulado As Double = 0

            For Each dr In dsCuotas.Tables(0).Rows
                bceInteres = bceInteres + dr("fld_interes_cuota_balance") + dr("fld_balance_mora")
                'bceAcumulado = bceAcumulado + bceInteres
                dr("fld_balance_cuotas") = bceInteres
                dr("fld_status_cuotas") = "Por Cobrar"
                If dr("fld_interes_cuota_balance") = 0 Then
                    dr("fld_balance_cuotas") = 0

                    If CDate(dr("fld_fecha_termina_cuotas")) < fechaServidor.Date Then
                        dr("fld_status_cuotas") = "Salda"

                    End If

                End If

            Next
        End If


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


    Private Sub OmitirMora()

        Dim nr As DataRow

        For Each nr In dsCuotas.Tables(0).Rows
            nr("fld_dias_vencimiento") = 0
            nr("fld_monto_mora") = 0
            nr("fld_balance_mora") = 0
        Next

    End Sub



    Private Sub crearIngreso()

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
                .CommandText = "INSERT INTO tbl_recibo_ingresos_cxc (fld_forma_pago,fld_detalle_forma_pago,fld_id_cliente_ri,fld_date,fld_Description,fld_monto,fld_fact_afectado,fdl_nd_afectado,fld_User,fld_Estado,fld_id_prestamo, fld_concepto, fld_interes_cobrado, fld_capital_cobrado, fld_mora_cobrada, fld_socio,fld_adelanto, fld_bce_actual, fld_monto_recibido,IdCaja) VALUES('" & txtFormaDePago.Text & "','" & fld_detalle_forma_pago.Text & "'," & txtCustomerID.Text & ",Now(),'" & fld_concepto.Text & "'," & CDec(txtMontoCobrar.Text) & ",'0','0','" & User(0) & "','NEW'," & fld_id_prestamo.Text & ",'" & fld_concepto.Text & "'," & CDbl(fld_total_interes.Text) & ", " & capitalCobrado & ", " & CDbl(fld_total_mora.Text) & ",'" & txtFirstName.Text & "','" & adelanto & "', " & bceCapital & ",0," & cmbCajas.SelectedValue & ")"
                .ExecuteNonQuery()
                .Connection.Close()
            End With
            cmd.Dispose()

            Dim Atraso As Double = SCALAR_NUM("SELECT IFNULL(SUM(fld_capital_cuota_balance) + SUM(fld_interes_cuota_balance),0) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_id_prestamo.Text & " AND DATE(fld_fecha_termina_cuotas) < DATE(NOW())")

            Dim RI As Integer = UltimoID("tbl_recibo_ingresos_cxc", "fld_Id_RI")
            Dim ctaContableCaja = SCALAR_STRING("SELECT CtaContable  FROM cajamantenimiento WHERE ID=" & cmbCajas.SelectedValue & "")

            InterfarContableRecibosIngresosCxC(CDec(capitalCobrado), CDec(fld_total_interes.Text), CDec(fld_total_mora.Text), 0, RI, fld_concepto.Text, ctaContableTxt.Text, ctaContableCaja)

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
        TextCol40.HeaderText = "B. MORA"
        TextCol40.Width = 125
        TextCol40.Format = "C2"
        TextCol40.Alignment = HorizontalAlignment.Right
        TextCol40.ReadOnly = True
        TextCol40.NullText = ""
        ts1.GridColumnStyles.Add(TextCol40)



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

        'Add a second column style. 
        Dim TextCol9 As New DataGridTextBoxColumn
        TextCol9.MappingName = "totalCuota"
        TextCol9.HeaderText = "TOTAL CUOTA"
        TextCol9.Width = 125
        TextCol9.Format = "C2"
        TextCol9.Alignment = HorizontalAlignment.Right
        TextCol9.ReadOnly = True
        TextCol9.NullText = ""
        ts1.GridColumnStyles.Add(TextCol9)

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
    Private Sub StyleFactIntereses()
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
        Dim TextCol7 As New DataGridTextBoxColumn
        TextCol7.MappingName = "fld_status_cuotas"
        TextCol7.HeaderText = "Estado"
        TextCol7.Width = 125
        TextCol7.Format = "C2"
        TextCol7.Alignment = HorizontalAlignment.Right
        TextCol7.ReadOnly = True
        TextCol7.NullText = ""
        ts1.GridColumnStyles.Add(TextCol7)

        ''Add a second column style. 
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
        txtBceCuota.Text = Format(bce_interes + bce_capital, "C2")



    End Sub

    Private Sub Calcular()

        Dim detalleConcepto As String = String.Empty
        Dim monto_cliente_detalle As Double = 0
        monto = 0
        capitalCobrado = 0
        interesCobrado = 0
        moraCobrada = 0

        monto = CDbl(txtMontoCobrar.Text)

        monto_cliente_detalle = monto

        Dim rows As DataRow



        For Each rows In dsCuotas.Tables(0).Rows

            If rows("fldchk") = "True" Then

                If monto >= rows("fld_balance_mora") Then 'TRABAJA CON LA MORA
                    rows("fld_abono_mora") = rows("fld_abono_mora") + rows("fld_balance_mora")
                    monto = monto - rows("fld_balance_mora")
                    rows("fld_ultimo_abono_mora") = rows("fld_balance_mora")
                    moraCobrada = moraCobrada + rows("fld_balance_mora")
                    rows("fld_balance_mora") = 0

                ElseIf monto < rows("fld_balance_mora") Then

                    If monto <= 0 Then
                        Exit For
                    End If

                    rows("fld_abono_mora") = rows("fld_abono_mora") + monto
                    rows("fld_balance_mora") = rows("fld_balance_mora") - monto
                    rows("fld_ultimo_abono_mora") = monto
                    moraCobrada = moraCobrada + monto
                    monto = monto - monto

                End If
sigue:
                If monto >= rows("fld_interes_cuota_balance") Then 'TRABAJA CON EL INTERES DE LA CUAOTA
                    rows("fld_interes_cuota_abono") = rows("fld_interes_cuota_abono") + rows("fld_interes_cuota_balance")
                    monto = monto - rows("fld_interes_cuota_balance")
                    rows("fld_fecha_ultimo_abono_cuotas") = Now.Date
                    rows("fld_ultimo_abono_interes") = rows("fld_interes_cuota_balance")
                    rows("fld_status_cuotas") = "Pagada"
                    interesCobrado = interesCobrado + rows("fld_interes_cuota_balance")
                    rows("fld_interes_cuota_balance") = 0

                ElseIf monto < rows("fld_interes_cuota_balance") Then

                    If monto < 0 Then
                        Exit For
                    End If

                    rows("fld_interes_cuota_abono") = rows("fld_interes_cuota_abono") + monto
                    rows("fld_interes_cuota_balance") = rows("fld_interes_cuota_balance") - monto
                    rows("fld_fecha_ultimo_abono_cuotas") = Now.Date
                    rows("fld_ultimo_abono_interes") = monto
                    rows("fld_status_cuotas") = "Abono"
                    interesCobrado = interesCobrado + monto
                    monto = monto - monto

                End If

                If txtClasificacion.Text = "Int. Diario Sobre Saldo Insoluto" Or txtClasificacion.Text = "Int. Diario Sobre Capital Inicial" Then
                    GoTo Salta
                    'Esto es para que solo descuente las moras y los intereses en estos tipos de préstamo
                End If

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

                    If monto < 0.0 Then
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



Salta:
            End If
        Next

        For Each rows In dsCuotas.Tables(0).Rows

            If rows("fldchk") = "True" Then
                If monto_cliente_detalle >= rows("fld_balance_cuotas") Then
                    If detalleConcepto Is String.Empty Then
                        detalleConcepto = "Saldo cuota No. " & rows("fld_no_cuotas")
                    Else
                        detalleConcepto = detalleConcepto & ", No. " & rows("fld_no_cuotas")
                    End If
                    monto_cliente_detalle = monto_cliente_detalle - rows("fld_balance_cuotas")

                Else
                    If monto_cliente_detalle <= 0 Then Exit For
                    If detalleConcepto Is String.Empty Then
                        detalleConcepto = " Abono a cuota No. " & rows("fld_no_cuotas") & " de RD$ " & Format(monto_cliente_detalle, "C")
                    Else
                        detalleConcepto = detalleConcepto & ", Abono a cuota No. " & rows("fld_no_cuotas") & " de RD$ " & Format(monto_cliente_detalle, "C")
                    End If
                    monto_cliente_detalle = monto_cliente_detalle - rows("fld_balance_cuotas")

                End If
            End If
        Next


        DG.DataSource = dsCuotas.Tables(0)
        Dim DataTable As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable = dsCuotas.Tables(0)
        DataTable.DefaultView.AllowNew = False

        fld_total_mora.Text = Format(moraCobrada, "C2")
        fld_total_interes.Text = Format(interesCobrado, "C2")
        fld_concepto.Text = detalleConcepto
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

            actFechaPrestamos(fld_id_prestamo.Text)

            If CDbl(fld_total_mora.Text) > 0 Then
                create_row_estado_cliente(txtCustomerID.Text, CDbl(fld_total_mora.Text), "NDCXC", IdRecibo, "MORA GENERADA MEDIANTE RECIBO No." & IdRecibo, formatDate(fechaServidor.Date))
            End If
            create_row_estado_cliente(txtCustomerID.Text, CDbl(txtMontoCobrar.Text), "RECIBOCOBROCXC", IdRecibo, fld_concepto.Text, formatDate(fechaServidor.Date))

            UPDATE_PRESTAMOS(fld_id_prestamo.Text)

        Else

            create_row_estado_cliente(txtCustomerID.Text, CDbl(txtMontoCobrar.Text), "RECIBOCOBROCXC", fld_id_prestamo.Text, fld_concepto.Text, formatDate(fechaServidor.Date))
            NON_QUERY("INSERT INTO tbl_historia_delantos_cxc (IDCliente, IDRecibo, Fecha, Monto, Usuario) VALUES(" & txtCustomerID.Text & "," & IdRecibo & ",Now()," & CDbl(txtMontoCobrar.Text) & ",'" & User(0) & "')")

        End If

        cargarCliente(txtCustomerID.Text)
        cargarCuotas(fld_id_prestamo.Text, txtCustomerID.Text)

        crearIngreso()

        txtMontoCobrar.Text = "0.00"
        fld_concepto.Text = String.Empty
        fld_total_interes.Text = "0.00"
        fld_total_mora.Text = "0.00"


        show.Close()
        If CBool(SCALAR_NUM("SELECT VistaPreviaImpresion FROM parametrosgenerales WHERE ID=1")) = True Then
            Id = IdRecibo
            AllReportSinFecha("Recibo Ingreso")
            Me.Close()
        Else
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
        End If





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
        If FRMS_LIST_PRESTAMOS() = True Then
            fld_id_prestamo.Text = Id
            'aplicaInteres(Id)
            txtClasificacion.Text = SCALAR_STRING("SELECT fld_clasificacion FROM tbl_prestamos WHERE fld_id_prestamos=" & Id & "")
            Dim idCliente = SCALAR_NUM("SELECT fld_id_del_cliente FROM tbl_prestamos WHERE fld_id_prestamos=" & Id & "")
            cargarCliente(idCliente)
            cargarCuotas(Id, idCliente)
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

        If Not IsNothing(dsCuotas) Then

            If cbOmitirMora.Checked = False And dsCuotas.Tables(0).Rows.Count > 0 Then
                AplicaMora()
            End If

            If cbOmitirMora.Checked = True And dsCuotas.Tables(0).Rows.Count > 0 Then
                OmitirMora()
            End If

            BCE()
        End If

    End Sub


    Private Sub txtCustomerID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerID.TextChanged

    End Sub

    Private Sub fld_id_prestamo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_id_prestamo.TextChanged

    End Sub

    Private Sub fld_id_prestamo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_id_prestamo.KeyDown
        If e.KeyCode = Keys.Enter Then

            'aplicaInteres(Id)
            txtClasificacion.Text = SCALAR_STRING("SELECT fld_clasificacion FROM tbl_prestamos WHERE fld_id_prestamos=" & fld_id_prestamo.Text & "")
            Dim idCliente = SCALAR_NUM("SELECT fld_id_del_cliente FROM tbl_prestamos WHERE fld_id_prestamos=" & fld_id_prestamo.Text & "")
            cargarCliente(idCliente)
            cargarCuotas(fld_id_prestamo.Text, idCliente)
            txtMontoCobrar.Focus()
        End If
    End Sub

    Private Sub fld_id_prestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_id_prestamo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFormaDePago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtFormaDePago.SelectedIndexChanged
        If txtFormaDePago.Text = "CHEQUE" Then
            PaneTranferencia.Visible = False
            PaneTranferencia.Visible = False
            'PaneTargeta.SendToBack()
            'PaneTranferencia.SendToBack()
            PaneNroCheque.BringToFront()
            PaneNroCheque.Visible = True

        ElseIf txtFormaDePago.Text = "TARJETA" Then
            PaneNroCheque.Visible = False
            PaneTranferencia.Visible = False
            PaneNroCheque.SendToBack()
            'PaneTranferencia.SendToBack()
            PaneTargeta.BringToFront()
            PaneTargeta.Visible = True
        ElseIf txtFormaDePago.Text = "TRANFERENCIA" Then
            PaneNroCheque.Visible = False
            PaneTargeta.Visible = False
            PaneNroCheque.SendToBack()
            'PaneTargeta.SendToBack()
            PaneTranferencia.BringToFront()
            PaneTranferencia.Visible = True

        Else
            PaneNroCheque.Visible = False
            PaneTargeta.Visible = False
            PaneTranferencia.Visible = False


        End If
    End Sub

    Private Sub txtMontoCobrar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMontoCobrar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtMontoCobrar.Text = String.Empty Then txtMontoCobrar.Text = "0.00"

            Dim amount As Decimal = CType(txtMontoCobrar.Text, Decimal)
            Me.txtMontoCobrar.Text = String.Format("{0:n2}", amount)
            If CDbl(txtMontoCobrar.Text) > 0 Then
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

    Private Sub dosmilTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dosmilTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub sumaTotales()
        Dim total As Double = CDbl(resDosmilTxt.Text) + CDbl(resMilTxt.Text) + CDbl(resQuinientoTxt.Text) + CDbl(resDocientoTxt.Text) + CDbl(resCienTxt.Text) + CDbl(resCincuentaTxt.Text) + CDbl(resVeiticincoTxt.Text) + CDbl(resDiezTxt.Text) + CDbl(resCincoTxt.Text) + CDbl(cheque.Text) + CDbl(unoTxt.Text)
        totalTxt.Text = Format(total, "N2")
        cambioTxt.Text = Format(total - CDbl(txtMontoCobrar.Text), "N2")
    End Sub
    Private Sub dosmilTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles dosmilTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dosmilTxt.Text = String.Empty Then dosmilTxt.Text = "0.00"
            resDosmilTxt.Text = Format(CInt(dosmilTxt.Text) * 2000, "N2")
            milTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub milTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles milTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If milTxt.Text = String.Empty Then milTxt.Text = "0.00"
            resMilTxt.Text = Format(CInt(milTxt.Text) * 1000, "N2")
            quinientoTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub milTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles milTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub quinientoTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quinientoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub quinientoTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles quinientoTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If quinientoTxt.Text = String.Empty Then quinientoTxt.Text = "0.00"
            resQuinientoTxt.Text = Format(CInt(quinientoTxt.Text) * 500, "N2")
            docientoTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub docientoTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles docientoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub docientoTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles docientoTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If docientoTxt.Text = String.Empty Then docientoTxt.Text = "0.00"
            resDocientoTxt.Text = Format(CInt(docientoTxt.Text) * 200, "N2")
            cienTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub cienTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cienTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cienTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles cienTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cienTxt.Text = String.Empty Then cienTxt.Text = "0.00"
            resCienTxt.Text = Format(CInt(cienTxt.Text) * 100, "N2")
            cincuentaTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub cincuentaTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cincuentaTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cincuentaTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles cincuentaTxt.KeyDown
        If cincuentaTxt.Text = String.Empty Then cincuentaTxt.Text = "0.00"
        resCincuentaTxt.Text = Format(CInt(cincuentaTxt.Text) * 50, "N2")
        venticincoTxt.Focus()
        sumaTotales()
    End Sub

    Private Sub venticincoTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles venticincoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub venticincoTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles venticincoTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If venticincoTxt.Text = String.Empty Then venticincoTxt.Text = "0.00"
            resVeiticincoTxt.Text = Format(CInt(venticincoTxt.Text) * 25, "N2")
            diezTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub diezTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles diezTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub diezTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles diezTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If diezTxt.Text = String.Empty Then diezTxt.Text = "0.00"
            resDiezTxt.Text = Format(CInt(diezTxt.Text) * 10, "N2")
            cincoTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub cincoTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cincoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cincoTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles cincoTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cincoTxt.Text = String.Empty Then cincoTxt.Text = "0.00"
            resCincoTxt.Text = Format(CInt(cincoTxt.Text) * 5, "N2")
            unoTxt.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub unoTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles unoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub unoTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles unoTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If unoTxt.Text = String.Empty Then unoTxt.Text = "0.00"
            resUnoTxt.Text = Format(CInt(unoTxt.Text) * 1, "N2")
            cheque.Focus()
            sumaTotales()
        End If
    End Sub

    Private Sub totalTxt_KeyDown(sender As Object, e As KeyEventArgs) Handles totalTxt.KeyDown
        If totalTxt.Text < txtMontoCobrar.Text Then
            MessageBox.Show("La Cantidad a Cobrar no puede Ser Menor a Total", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            totalTxt.Focus()
        Else
            If e.KeyCode = Keys.Enter Then
                If totalTxt.Text = String.Empty Then totalTxt.Text = "0.00"

                Dim amount As Decimal = CType(cheque.Text, Decimal)
                Me.totalTxt.Text = String.Format("{0:n2}", amount)
                btn_cobrar_Click(sender, e)
            End If
        End If
    End Sub


    Private Sub FRM_RECIBO_INGRESO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub fld_detalle_forma_pago_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_detalle_forma_pago.TextChanged

    End Sub
End Class
