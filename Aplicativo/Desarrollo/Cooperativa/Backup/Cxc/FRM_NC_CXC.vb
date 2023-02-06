Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing
Public Class FRM_NC_CXC
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFormaDePago As System.Windows.Forms.ComboBox
    Friend WithEvents fld_detalle_forma_pago As System.Windows.Forms.TextBox
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_NC_CXC))
        Me.DG = New System.Windows.Forms.DataGrid
        Me.fld_fecha = New System.Windows.Forms.DateTimePicker
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
        'DG
        '
        Me.DG.BackgroundColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.DG.CaptionVisible = False
        Me.DG.DataMember = ""
        Me.DG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG.Location = New System.Drawing.Point(5, 160)
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(776, 264)
        Me.DG.TabIndex = 14
        '
        'fld_fecha
        '
        Me.fld_fecha.CustomFormat = "dd / MMM / yyyy"
        Me.fld_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha.Location = New System.Drawing.Point(648, 16)
        Me.fld_fecha.Name = "fld_fecha"
        Me.fld_fecha.Size = New System.Drawing.Size(128, 20)
        Me.fld_fecha.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(528, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Fecha de Servidor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_total_mora
        '
        Me.fld_total_mora.BackColor = System.Drawing.Color.White
        Me.fld_total_mora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_total_mora.Location = New System.Drawing.Point(629, 184)
        Me.fld_total_mora.Name = "fld_total_mora"
        Me.fld_total_mora.Size = New System.Drawing.Size(128, 20)
        Me.fld_total_mora.TabIndex = 18
        Me.fld_total_mora.Text = "0.00"
        Me.fld_total_mora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_total_mora.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(477, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Total Mora y Otros"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'fld_total_interes
        '
        Me.fld_total_interes.BackColor = System.Drawing.Color.White
        Me.fld_total_interes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_total_interes.Location = New System.Drawing.Point(629, 160)
        Me.fld_total_interes.Name = "fld_total_interes"
        Me.fld_total_interes.Size = New System.Drawing.Size(128, 20)
        Me.fld_total_interes.TabIndex = 17
        Me.fld_total_interes.Text = "0.00"
        Me.fld_total_interes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_total_interes.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(576, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total Interes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'fld_concepto
        '
        Me.fld_concepto.BackColor = System.Drawing.Color.White
        Me.fld_concepto.Location = New System.Drawing.Point(408, 40)
        Me.fld_concepto.MaxLength = 150
        Me.fld_concepto.Multiline = True
        Me.fld_concepto.Name = "fld_concepto"
        Me.fld_concepto.Size = New System.Drawing.Size(376, 72)
        Me.fld_concepto.TabIndex = 3
        Me.fld_concepto.Text = "N/A"
        '
        'fld_id_prestamo
        '
        Me.fld_id_prestamo.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.fld_id_prestamo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_id_prestamo.Location = New System.Drawing.Point(109, 88)
        Me.fld_id_prestamo.MaxLength = 8
        Me.fld_id_prestamo.Name = "fld_id_prestamo"
        Me.fld_id_prestamo.ReadOnly = True
        Me.fld_id_prestamo.Size = New System.Drawing.Size(272, 20)
        Me.fld_id_prestamo.TabIndex = 25
        Me.fld_id_prestamo.Text = "0"
        Me.fld_id_prestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_detalle_forma_pago
        '
        Me.fld_detalle_forma_pago.BackColor = System.Drawing.Color.White
        Me.fld_detalle_forma_pago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_detalle_forma_pago.Location = New System.Drawing.Point(109, 136)
        Me.fld_detalle_forma_pago.Name = "fld_detalle_forma_pago"
        Me.fld_detalle_forma_pago.ReadOnly = True
        Me.fld_detalle_forma_pago.Size = New System.Drawing.Size(272, 20)
        Me.fld_detalle_forma_pago.TabIndex = 2
        Me.fld_detalle_forma_pago.Text = "N/A"
        Me.fld_detalle_forma_pago.Visible = False
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(5, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Forma de pago"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'txtFormaDePago
        '
        Me.txtFormaDePago.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.txtFormaDePago.ForeColor = System.Drawing.Color.White
        Me.txtFormaDePago.ItemHeight = 13
        Me.txtFormaDePago.Items.AddRange(New Object() {"CHEQUE", "TARJETA", "EFECTIVO"})
        Me.txtFormaDePago.Location = New System.Drawing.Point(109, 112)
        Me.txtFormaDePago.Name = "txtFormaDePago"
        Me.txtFormaDePago.Size = New System.Drawing.Size(272, 21)
        Me.txtFormaDePago.TabIndex = 1
        Me.txtFormaDePago.Text = "EFECTIVO"
        Me.txtFormaDePago.Visible = False
        '
        'txtMontoCobrar
        '
        Me.txtMontoCobrar.BackColor = System.Drawing.Color.White
        Me.txtMontoCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCobrar.Location = New System.Drawing.Point(597, 112)
        Me.txtMontoCobrar.Name = "txtMontoCobrar"
        Me.txtMontoCobrar.Size = New System.Drawing.Size(192, 30)
        Me.txtMontoCobrar.TabIndex = 4
        Me.txtMontoCobrar.Text = "0.00"
        Me.txtMontoCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.White
        Me.txtBalance.Location = New System.Drawing.Point(109, 64)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(272, 20)
        Me.txtBalance.TabIndex = 24
        Me.txtBalance.Text = "0.00"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.SystemColors.Control
        Me.btnBusca.ForeColor = System.Drawing.Color.Black
        Me.btnBusca.Image = CType(resources.GetObject("btnBusca.Image"), System.Drawing.Image)
        Me.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBusca.Location = New System.Drawing.Point(224, 4)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(155, 32)
        Me.btnBusca.TabIndex = 0
        Me.btnBusca.Text = "&Lista de Clientes (F5)"
        Me.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(21, 40)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(72, 16)
        Me.lblFirstName.TabIndex = 9
        Me.lblFirstName.Text = "Cliente"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCustomerID
        '
        Me.lblCustomerID.Location = New System.Drawing.Point(21, 16)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(72, 16)
        Me.lblCustomerID.TabIndex = 8
        Me.lblCustomerID.Text = "Código"
        Me.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstName.Location = New System.Drawing.Point(109, 40)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(272, 20)
        Me.txtFirstName.TabIndex = 23
        Me.txtFirstName.Text = ""
        '
        'txtCustomerID
        '
        Me.txtCustomerID.BackColor = System.Drawing.Color.White
        Me.txtCustomerID.Location = New System.Drawing.Point(109, 16)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(107, 20)
        Me.txtCustomerID.TabIndex = 22
        Me.txtCustomerID.Text = "0"
        '
        'lblBalance
        '
        Me.lblBalance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(29, 64)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(64, 16)
        Me.lblBalance.TabIndex = 10
        Me.lblBalance.Text = "Balance"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cod. Préstamo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(389, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 24)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "MONTO CREDITO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(408, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Concepto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.fld_id_cuotas)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.fld_monto_mora)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(85, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 40)
        Me.GroupBox2.TabIndex = 15
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
        Me.Button1.TabIndex = 4
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
        Me.fld_id_cuotas.TabIndex = 3
        Me.fld_id_cuotas.Text = "0"
        Me.fld_id_cuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(180, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 2
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
        Me.fld_monto_mora.TabIndex = 1
        Me.fld_monto_mora.Text = "0.00"
        Me.fld_monto_mora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Monto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btnCerrar.Location = New System.Drawing.Point(704, 432)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 7
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
        Me.btnGuradar.Location = New System.Drawing.Point(80, 432)
        Me.btnGuradar.Name = "btnGuradar"
        Me.btnGuradar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuradar.TabIndex = 5
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
        Me.btnNueva.Location = New System.Drawing.Point(8, 432)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(72, 56)
        Me.btnNueva.TabIndex = 6
        Me.btnNueva.Text = "&Nueva"
        Me.btnNueva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(200, 432)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(432, 32)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "NOTA DE CREDITO A INTERES"
        '
        'FRM_NC_CXC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(786, 499)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuradar)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fld_concepto)
        Me.Controls.Add(Me.txtFormaDePago)
        Me.Controls.Add(Me.fld_id_prestamo)
        Me.Controls.Add(Me.btnBusca)
        Me.Controls.Add(Me.fld_detalle_forma_pago)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.fld_fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.fld_total_mora)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMontoCobrar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.fld_total_interes)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_NC_CXC"
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
    Dim description_interes As String = "", description_capital As String = "", description_nd As String = "", descripcion_cliente As String = ""
    Dim isNewDoc As Boolean = True
    Dim isValidated As Boolean = True
    Dim CustBce As Single
    Dim CustAddress As String

    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    Dim monto As Single, table_select As String, nd_afectada As String, fact_afectada As String
    Dim TABLA As String, view As String, capital_cobrado As Double, interes_cobrado As Double, monto_cta_cobrado As Double, mora_cobrada As Double


    '/PROPIEDADES DEL FORMULARIO
   
    Private Sub FrmCustomer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub
    Private Sub FrmCustomer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        description_nd = ""
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

    Private Sub SAVE_CHAGER_ND(ByVal id_doc As String, ByVal abono As Double, ByVal bce As Double)

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_nd_cxc SET fld_balance=" & bce & ", fld_abono=" & abono & "  WHERE  fld_id_nd_cxc=" & id_doc & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd = Nothing
    End Sub
    Private Function retunr_tipo_prestamo(ByVal id_pret As String) As String

        Dim data As String
        Dim ds1 As New DataSet
        Dim da1 As New MySqlDataAdapter("SELECT fld_tipo_prestamo FROM tbl_prestamos WHERE fld_id_prestamos=" & id_pret & "", conn)
        da1.Fill(ds1, "tbl_prestamos")

        Dim nr As DataRow
        For Each nr In ds1.Tables(0).Rows
            data = nr("fld_tipo_prestamo")
        Next

        ds1.Dispose()
        da1.Dispose()

        retunr_tipo_prestamo = data
    End Function
    Private Function retunr_interes_prestamo(ByVal id_pret As String) As Double

        Dim data As Double
        Dim ds1 As New DataSet
        Dim da1 As New MySqlDataAdapter("SELECT fld_interes_p FROM tbl_prestamos WHERE fld_id_prestamos=" & id_pret & "", conn)
        da1.Fill(ds1, "tbl_prestamos")

        Dim nr As DataRow
        For Each nr In ds1.Tables(0).Rows
            data = nr("fld_interes_p")
        Next

        ds1.Dispose()
        da1.Dispose()

        retunr_interes_prestamo = data
    End Function

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
            If FRMS_LIST_PRESTAMOS_POR_CLIENTE(txtFirstName.Text, Id) = True Then
                fld_id_prestamo.Text = Id
                LOAD_CUOTAS(fld_id_prestamo.Text)
                txtFormaDePago.Focus()
            End If
            BCE()
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
        ds = New DataSet
        da = New MySqlDataAdapter("SELECT * FROM tbl_clientes WHERE fld_id=" & id_CUST & "", conn)
        da.Fill(ds, "tbl_clientes")

        Dim nr As DataRow
        For Each nr In ds.Tables(0).Rows
            txtCustomerID.Text = id_CUST
            txtFirstName.Text = nr("fld_FullName")
        Next
        conn.Close()


    End Sub
    Dim porciento As Double = 0

    Private Sub LOAD_CUOTAS(ByVal id_CUST As String)

        Dim SQLSTRING As String
        SQLSTRING = "SELECT * FROM tbl_cuotas WHERE  fld_balance_cuotas > 0 AND fld_id_del_prestamo=" & id_CUST & "  ORDER BY fld_no_cuotas"

        StyleFact()

        ds = New DataSet
        da = New MySqlDataAdapter(SQLSTRING, conn)
        da.Fill(ds, "tbl_cuotas")

        DG.DataSource = ds.Tables(0)

        Dim DataTable As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable = ds.Tables(0)
        DataTable.DefaultView.AllowNew = False

        BCE()
    End Sub
     
    Private Sub CREATE_NC()

        Dim description As String = description_nd + " / " + description_interes + " / " + description_capital

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

        Dim TextCol0 As New DataGridTextBoxColumn
        TextCol0.MappingName = "fld_no_cuotas"
        TextCol0.HeaderText = "Cuota No."
        TextCol0.Width = 100
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
            bce_interes = bce_interes + Format(dr("fld_interes_cuota_balance"), "C20")
        Next
        txtBalance.Text = Format((bce_interes) + (bce_capital + bce_mora), "C2")
    End Sub
    Private Sub CALCULO()

        ds.RejectChanges()
        description_nd = ""
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



        interes_cobrado = 0
        mora_cobrada = 0

        For Each rows In ds.Tables(0).Rows

            If monto >= rows("fld_interes_cuota_balance") Then 'TRABAJA CON EL INTERES DE LA CUAOTA


                rows("fld_interes_cuota_abono") = rows("fld_interes_cuota_abono") + rows("fld_interes_cuota_balance")
                monto = monto - rows("fld_interes_cuota_balance")
                rows("fld_fecha_ultimo_abono_cuotas") = Now.Date
                rows("fld_ultimo_abono_interes") = rows("fld_interes_cuota_balance")
                rows("fld_status_cuotas") = "Pagada"

                interes_cobrado = interes_cobrado + rows("fld_interes_cuota_balance")

                rows("fld_interes_cuota_balance") = 0

                If description_interes <> "" Then
                    description_interes = description_interes & " | " & " INTERES CTA# " & rows("fld_no_cuotas")
                    fact_afectada = fact_afectada & "," & rows("fld_no_cuotas")
                Else
                    description_interes = "INTERES CTA# " & rows("fld_no_cuotas")
                    fact_afectada = rows("fld_no_cuotas")
                End If

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

                If description_interes <> "" Then
                    description_interes = description_interes & " ( " & " INTERES DE " & Format(monto, "C2") & " A LA CTA# " & rows("fld_no_cuotas") & ")"
                    fact_afectada = fact_afectada & "," & rows("fld_no_cuotas")
                Else
                    description_interes = "( " & "" & Format(monto, "C2") & " A INTERES DE LA CTA# " & rows("fld_no_cuotas") & ")"
                    fact_afectada = rows("fld_no_cuotas")
                End If

                monto = monto - monto

            End If
        Next



        DG.DataSource = ds.Tables(0)
        Dim DataTable As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable = ds.Tables(0)
        DataTable.DefaultView.AllowNew = False





        DG.DataSource = ds.Tables(0)

        DataTable = ds.Tables(0)
        DataTable.DefaultView.AllowNew = False

        fld_total_mora.Text = Format(monto_mora + mora_cobrada, "C2")
        fld_total_interes.Text = Format(interes_cobrado, "C2")



        fld_total_mora.Text = Format(monto_mora + mora_cobrada, "C2")
        fld_total_interes.Text = Format(interes_cobrado, "C2")




    End Sub
    Private Sub COBRANDO()
        CALCULO()
        If interes_cobrado + capital_cobrado + mora_cobrada = 0 Then
            Alerta("Escriba el monto de CREDITO y pulse la tecla ENTER para ver los cambios en pantalla y luego pulse el botón GUARDAR para aplicar los cambios")
            txtMontoCobrar.Text = "0.00"
            Exit Sub
        End If
        If CDbl(txtMontoCobrar.Text) > CDbl(txtBalance.Text) Then
            txtMontoCobrar.Text = "0.00"
            txtMontoCobrar.SelectAll()
            Alerta("Está cobrando más dinero que el balance de este CLIENTE")
            Exit Sub
        End If

        If Alerta("Verifique que todo sea correcto" & Chr(13) & "¿Desea continuar?") = False Then
            DESHACER_DS()
            Exit Sub
        End If

        Dim show As New FrmPopupMessage
        show.Show("Actualizando... Por favor espere")



        Dim dr_cuotas As DataRow, dr_nd As DataRow

        For Each dr_cuotas In ds.Tables(0).Rows
            If dr_cuotas("fld_ultimo_abono_interes") > 0 Or dr_cuotas("fld_ultimo_abono_capital") > 0 Or dr_cuotas("fld_ultimo_abono_mora") > 0 Then
                SAVE_CHAGER_CUOTAS(dr_cuotas("fld_id_cuotas"), dr_cuotas("fld_ultimo_abono_interes"), dr_cuotas("fld_ultimo_abono_capital"), dr_cuotas("fld_abono_mora"))
                SAVE_DETALLE_NC(dr_cuotas("fld_id_cuotas"), dr_cuotas("fld_ultimo_abono_interes"), dr_cuotas("fld_ultimo_abono_capital"), UltimoID("tbl_nc_cxc", "fld_id_nc_cxc") + 1, "C", dr_cuotas("fld_ultimo_abono_mora"))
            End If
        Next

        CREATE_NC()
        Dim idDoc As Integer = UltimoID("tbl_nc_cxc", "fld_id_nc_cxc")
        create_row_estado_cliente(txtCustomerID.Text, CDbl(txtMontoCobrar.Text), "NCCXC", idDoc, fld_concepto.Text, formatDate(fld_fecha.Value.Date))

        InterfarContableAutomatico("Cuenta por Cobrar", "Nota de Crédito", fld_fecha.Value.Date, CDec(txtMontoCobrar.Text), idDoc, fld_concepto.Text)

        UPDATE_PRESTAMOS(fld_id_prestamo.Text)

        LOAD_CUSTOMER(txtCustomerID.Text)
        LOAD_CUOTAS(fld_id_prestamo.Text)

        txtMontoCobrar.Text = "0.00"
        fld_concepto.Text = ""
        fld_total_interes.Text = "0.00"
        fld_total_mora.Text = "0.00"

        show.Close()

        description_nd = ""
        description_interes = ""
        description_capital = ""
        CustBce = Nothing
        CustAddress = Nothing
        print_doc_nc(UltimoID("tbl_nc_cxc", "fld_id_nc_cxc"))


    End Sub
    Private Sub DESHACER_DS()
        description_nd = ""
        description_interes = ""
        description_capital = ""
        nd_afectada = ""
        fact_afectada = ""
        ds.RejectChanges()

    End Sub

    Private Sub print_doc_nc(ByVal id_doc As Integer)
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
    Private Sub btnOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            dr("fldchk") = True
        Next


    End Sub
    Private Sub btnOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
                    LOAD_CUOTAS(fld_id_prestamo.Text)
                End If


                txtFormaDePago.Focus()
            End If
        End If
    End Sub


    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        LISTA_CLIENTES()
    End Sub


    Private Sub txtFormaDePago_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFormaDePago.SelectedValueChanged

        If txtFormaDePago.Text <> "EFECTIVO" Then
            fld_detalle_forma_pago.ReadOnly = False
        Else
            fld_detalle_forma_pago.ReadOnly = True
        End If

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CDbl(fld_monto_mora.Text) = 0 Then
            Alerta("Debe introducir el Monto de la mora")
            Exit Sub
        End If

        If CDbl(fld_id_cuotas.Text) = 0 Then
            Alerta("Debe introducir el Id. No. de la Cuota")
            Exit Sub
        End If

        If Alerta("Verifique los datos...¿Desea continuar?") = True Then
            Dim cmd As New MySqlCommand
            With cmd
                .Connection = conn
                .Connection.Open()
                .CommandText = "UPDATE tbl_cuotas SET fld_monto_mora=" & CDbl(fld_monto_mora.Text) & ", fld_balance_mora=" & CDbl(fld_monto_mora.Text) & " WHERE fld_id_cuotas =" & fld_id_cuotas.Text & ""
                .ExecuteNonQuery()
                .Connection.Close()
            End With
            cmd.Dispose()

            LOAD_CUOTAS(fld_id_prestamo.Text)
        End If

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

    Private Sub FRM_NC_CXC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            LISTA_CLIENTES()
        End If
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub

    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        Print(1)
        Exit Sub
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


End Class
