Imports  MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Public Class FRM_PROFILE_DOC
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lclRnc As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtRnc As System.Windows.Forms.TextBox
    Friend WithEvents lblCompania As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCompanyID As System.Windows.Forms.TextBox
    Friend WithEvents txtPassAdmin As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents fld_porciento_semanal_13 As System.Windows.Forms.TextBox
    Friend WithEvents fld_porciento_quincenal As System.Windows.Forms.TextBox
    Friend WithEvents fld_porciento_mensual As System.Windows.Forms.TextBox
    Friend WithEvents fld_porciento_semanal_15 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents fld_tipo_prestamo As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbl_zona_prestamo As System.Windows.Forms.Label
    Friend WithEvents fld_cod_zona_prestamos As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents fld_porciento_semanal As System.Windows.Forms.TextBox
    Friend WithEvents fld_capital_inicial As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btn_capital_inicial As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents fld_clave_borrar As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents buscarBtn As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_PROFILE_DOC))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtPassAdmin = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.fld_clave_borrar = New System.Windows.Forms.TextBox
        Me.btn_capital_inicial = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.fld_capital_inicial = New System.Windows.Forms.TextBox
        Me.txtCompanyID = New System.Windows.Forms.TextBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.lclRnc = New System.Windows.Forms.Label
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtRnc = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.lblCompania = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.fld_porciento_semanal = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.fld_porciento_semanal_15 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.fld_porciento_mensual = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.fld_porciento_quincenal = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.fld_porciento_semanal_13 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lbl_zona_prestamo = New System.Windows.Forms.Label
        Me.fld_cod_zona_prestamos = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.fld_tipo_prestamo = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.buscarBtn = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.btn_capital_inicial)
        Me.GroupBox1.Controls.Add(Me.fld_capital_inicial)
        Me.GroupBox1.Controls.Add(Me.txtCompanyID)
        Me.GroupBox1.Controls.Add(Me.btnCerrar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.lblTelefono)
        Me.GroupBox1.Controls.Add(Me.lclRnc)
        Me.GroupBox1.Controls.Add(Me.lblDireccion)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtRnc)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtCompany)
        Me.GroupBox1.Controls.Add(Me.lblCompania)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 286)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPassAdmin)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(80, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 48)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Claves de Accesos"
        '
        'txtPassAdmin
        '
        Me.txtPassAdmin.BackColor = System.Drawing.Color.White
        Me.txtPassAdmin.Location = New System.Drawing.Point(8, 16)
        Me.txtPassAdmin.MaxLength = 10
        Me.txtPassAdmin.Name = "txtPassAdmin"
        Me.txtPassAdmin.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassAdmin.Size = New System.Drawing.Size(336, 20)
        Me.txtPassAdmin.TabIndex = 5
        Me.txtPassAdmin.Text = ""
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.fld_clave_borrar)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox6.Location = New System.Drawing.Point(440, 184)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 48)
        Me.GroupBox6.TabIndex = 93
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Claves para Borrar"
        '
        'fld_clave_borrar
        '
        Me.fld_clave_borrar.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.fld_clave_borrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fld_clave_borrar.Location = New System.Drawing.Point(8, 16)
        Me.fld_clave_borrar.Name = "fld_clave_borrar"
        Me.fld_clave_borrar.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.fld_clave_borrar.Size = New System.Drawing.Size(176, 20)
        Me.fld_clave_borrar.TabIndex = 5
        Me.fld_clave_borrar.Text = ""
        '
        'btn_capital_inicial
        '
        Me.btn_capital_inicial.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.btn_capital_inicial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_capital_inicial.ForeColor = System.Drawing.Color.White
        Me.btn_capital_inicial.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_capital_inicial.ImageIndex = 0
        Me.btn_capital_inicial.ImageList = Me.ImageList1
        Me.btn_capital_inicial.Location = New System.Drawing.Point(696, 384)
        Me.btn_capital_inicial.Name = "btn_capital_inicial"
        Me.btn_capital_inicial.Size = New System.Drawing.Size(64, 40)
        Me.btn_capital_inicial.TabIndex = 90
        Me.btn_capital_inicial.Text = "&Guardar"
        Me.btn_capital_inicial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_capital_inicial.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'fld_capital_inicial
        '
        Me.fld_capital_inicial.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.fld_capital_inicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fld_capital_inicial.Location = New System.Drawing.Point(656, 328)
        Me.fld_capital_inicial.Name = "fld_capital_inicial"
        Me.fld_capital_inicial.Size = New System.Drawing.Size(104, 20)
        Me.fld_capital_inicial.TabIndex = 48
        Me.fld_capital_inicial.Text = "0.00"
        Me.fld_capital_inicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_capital_inicial.Visible = False
        '
        'txtCompanyID
        '
        Me.txtCompanyID.BackColor = System.Drawing.Color.White
        Me.txtCompanyID.Location = New System.Drawing.Point(312, 168)
        Me.txtCompanyID.Name = "txtCompanyID"
        Me.txtCompanyID.Size = New System.Drawing.Size(24, 20)
        Me.txtCompanyID.TabIndex = 26
        Me.txtCompanyID.Text = ""
        Me.txtCompanyID.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(360, 224)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 20
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(288, 224)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 19
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblTelefono
        '
        Me.lblTelefono.Location = New System.Drawing.Point(16, 88)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(56, 16)
        Me.lblTelefono.TabIndex = 18
        Me.lblTelefono.Text = "Teléfono"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lclRnc
        '
        Me.lclRnc.Location = New System.Drawing.Point(16, 64)
        Me.lclRnc.Name = "lclRnc"
        Me.lclRnc.Size = New System.Drawing.Size(56, 16)
        Me.lclRnc.TabIndex = 17
        Me.lclRnc.Text = "Rnc"
        Me.lclRnc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDireccion
        '
        Me.lblDireccion.Location = New System.Drawing.Point(16, 40)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(56, 16)
        Me.lblDireccion.TabIndex = 16
        Me.lblDireccion.Text = "Dirección"
        Me.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.Location = New System.Drawing.Point(80, 86)
        Me.txtPhone.MaxLength = 150
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(352, 20)
        Me.txtPhone.TabIndex = 15
        Me.txtPhone.Text = ""
        '
        'txtRnc
        '
        Me.txtRnc.BackColor = System.Drawing.Color.White
        Me.txtRnc.Location = New System.Drawing.Point(80, 62)
        Me.txtRnc.MaxLength = 150
        Me.txtRnc.Name = "txtRnc"
        Me.txtRnc.Size = New System.Drawing.Size(352, 20)
        Me.txtRnc.TabIndex = 14
        Me.txtRnc.Text = ""
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.Location = New System.Drawing.Point(80, 38)
        Me.txtAddress.MaxLength = 150
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(352, 20)
        Me.txtAddress.TabIndex = 13
        Me.txtAddress.Text = ""
        '
        'txtCompany
        '
        Me.txtCompany.BackColor = System.Drawing.Color.White
        Me.txtCompany.Location = New System.Drawing.Point(80, 14)
        Me.txtCompany.MaxLength = 150
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(352, 20)
        Me.txtCompany.TabIndex = 12
        Me.txtCompany.Text = ""
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(16, 16)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(56, 16)
        Me.lblCompania.TabIndex = 11
        Me.lblCompania.Text = "Compañía"
        Me.lblCompania.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.fld_porciento_semanal)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.fld_porciento_semanal_15)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.fld_porciento_mensual)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.fld_porciento_quincenal)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.fld_porciento_semanal_13)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox4.Location = New System.Drawing.Point(696, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 248)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "% Tipo de préstamo"
        Me.GroupBox4.Visible = False
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(144, 16)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Semanal"
        '
        'fld_porciento_semanal
        '
        Me.fld_porciento_semanal.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.fld_porciento_semanal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fld_porciento_semanal.Location = New System.Drawing.Point(8, 48)
        Me.fld_porciento_semanal.Name = "fld_porciento_semanal"
        Me.fld_porciento_semanal.Size = New System.Drawing.Size(40, 20)
        Me.fld_porciento_semanal.TabIndex = 35
        Me.fld_porciento_semanal.Text = ""
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(56, 50)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 16)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "%"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(144, 16)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Semanal de 15"
        '
        'fld_porciento_semanal_15
        '
        Me.fld_porciento_semanal_15.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.fld_porciento_semanal_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fld_porciento_semanal_15.Location = New System.Drawing.Point(8, 128)
        Me.fld_porciento_semanal_15.Name = "fld_porciento_semanal_15"
        Me.fld_porciento_semanal_15.Size = New System.Drawing.Size(40, 20)
        Me.fld_porciento_semanal_15.TabIndex = 32
        Me.fld_porciento_semanal_15.Text = ""
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(56, 130)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 16)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "%"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 192)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 16)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Mensual"
        '
        'fld_porciento_mensual
        '
        Me.fld_porciento_mensual.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.fld_porciento_mensual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fld_porciento_mensual.Location = New System.Drawing.Point(8, 208)
        Me.fld_porciento_mensual.Name = "fld_porciento_mensual"
        Me.fld_porciento_mensual.Size = New System.Drawing.Size(40, 20)
        Me.fld_porciento_mensual.TabIndex = 29
        Me.fld_porciento_mensual.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(56, 210)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 16)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "%"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Quicenal"
        '
        'fld_porciento_quincenal
        '
        Me.fld_porciento_quincenal.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.fld_porciento_quincenal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fld_porciento_quincenal.Location = New System.Drawing.Point(8, 168)
        Me.fld_porciento_quincenal.Name = "fld_porciento_quincenal"
        Me.fld_porciento_quincenal.Size = New System.Drawing.Size(40, 20)
        Me.fld_porciento_quincenal.TabIndex = 26
        Me.fld_porciento_quincenal.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(56, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "%"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Semanal de 13 "
        '
        'fld_porciento_semanal_13
        '
        Me.fld_porciento_semanal_13.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.fld_porciento_semanal_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fld_porciento_semanal_13.Location = New System.Drawing.Point(8, 88)
        Me.fld_porciento_semanal_13.Name = "fld_porciento_semanal_13"
        Me.fld_porciento_semanal_13.Size = New System.Drawing.Size(40, 20)
        Me.fld_porciento_semanal_13.TabIndex = 23
        Me.fld_porciento_semanal_13.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(56, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "%"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbl_zona_prestamo)
        Me.GroupBox5.Controls.Add(Me.fld_cod_zona_prestamos)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.fld_tipo_prestamo)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox5.Location = New System.Drawing.Point(696, 264)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 104)
        Me.GroupBox5.TabIndex = 44
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "datos predeterminados en M. Prest."
        Me.GroupBox5.Visible = False
        '
        'lbl_zona_prestamo
        '
        Me.lbl_zona_prestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_zona_prestamo.Location = New System.Drawing.Point(8, 80)
        Me.lbl_zona_prestamo.Name = "lbl_zona_prestamo"
        Me.lbl_zona_prestamo.Size = New System.Drawing.Size(184, 16)
        Me.lbl_zona_prestamo.TabIndex = 88
        Me.lbl_zona_prestamo.Text = "Zona"
        Me.lbl_zona_prestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_cod_zona_prestamos
        '
        Me.fld_cod_zona_prestamos.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.fld_cod_zona_prestamos.ForeColor = System.Drawing.Color.White
        Me.fld_cod_zona_prestamos.Items.AddRange(New Object() {"N/A"})
        Me.fld_cod_zona_prestamos.Location = New System.Drawing.Point(72, 48)
        Me.fld_cod_zona_prestamos.Name = "fld_cod_zona_prestamos"
        Me.fld_cod_zona_prestamos.Size = New System.Drawing.Size(100, 21)
        Me.fld_cod_zona_prestamos.TabIndex = 86
        Me.fld_cod_zona_prestamos.Text = "N/A"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.Location = New System.Drawing.Point(16, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 16)
        Me.Label21.TabIndex = 87
        Me.Label21.Text = "Zona"
        '
        'fld_tipo_prestamo
        '
        Me.fld_tipo_prestamo.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.fld_tipo_prestamo.ForeColor = System.Drawing.Color.White
        Me.fld_tipo_prestamo.Items.AddRange(New Object() {"N/A", "Mensual", "Quincenal", "Semanal", "Semanal 13", "Semanal 15"})
        Me.fld_tipo_prestamo.Location = New System.Drawing.Point(72, 22)
        Me.fld_tipo_prestamo.Name = "fld_tipo_prestamo"
        Me.fld_tipo_prestamo.Size = New System.Drawing.Size(100, 21)
        Me.fld_tipo_prestamo.TabIndex = 82
        Me.fld_tipo_prestamo.Text = "N/A"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(16, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 16)
        Me.Label20.TabIndex = 83
        Me.Label20.Text = "Tipo"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label24.Location = New System.Drawing.Point(664, 360)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 16)
        Me.Label24.TabIndex = 89
        Me.Label24.Text = "Capital Inicial"
        Me.Label24.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(448, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'buscarBtn
        '
        Me.buscarBtn.BackColor = System.Drawing.SystemColors.Control
        Me.buscarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.buscarBtn.ForeColor = System.Drawing.Color.Black
        Me.buscarBtn.Image = CType(resources.GetObject("buscarBtn.Image"), System.Drawing.Image)
        Me.buscarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buscarBtn.Location = New System.Drawing.Point(448, 160)
        Me.buscarBtn.Name = "buscarBtn"
        Me.buscarBtn.Size = New System.Drawing.Size(140, 56)
        Me.buscarBtn.TabIndex = 2
        Me.buscarBtn.Text = "&Buscar"
        Me.buscarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FRM_PROFILE_DOC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(594, 291)
        Me.Controls.Add(Me.buscarBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_PROFILE_DOC"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documento de Configuración"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Dim isnewpro As Boolean = True
     '/INI FILE

    Private Sub buscarFotoBD()
        Try
            Dim Sql As String = "select foto from tbl_profiledocument where fldCompanyID=1"
            Dim lector As MySqlDataReader

            conn.Open()
            If conn.State = ConnectionState.Open Then
                Dim Imag As Byte()
                Dim Comando As New MySqlCommand(Sql, conn)
                lector = Comando.ExecuteReader
                While lector.Read
                    Imag = lector("foto")
                    Me.PictureBox1.Image = Bytes_Imagen(Imag)

                End While
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    '/FROM PROPETIES
    Private Sub FRM_PROFILE_DOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LoadData()
    End Sub
    Private Sub FRM_PROFILE_DOC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(27) Then
            Me.Close()
        End If
    End Sub

    '/SUB PROGRAMAS
    Private Sub UpdateProfile()
        Dim dr As DataRow

        With ds.Tables("tbl_profiledocument")
            .PrimaryKey = New DataColumn() {.Columns("fldCompanyID")}
        End With

        dr = ds.Tables("tbl_profiledocument").Rows.Find(txtCompanyID.Text)
        If Not (dr Is Nothing) Then

            dr("fldPassAdmin") = txtPassAdmin.Text
            dr("fldCompany") = txtCompany.Text
            dr("fldAddress") = txtAddress.Text
            dr("fldPhone") = txtPhone.Text
            dr("fldRnc") = txtRnc.Text
            dr("fldNotaRecepcion") = ""
            dr("fldPassConfig") = fld_clave_borrar.Text
           
        End If


        Dim cmd As New MySqlCommandBuilder(da)
        conn.Open()
        da.UpdateCommand = cmd.GetUpdateCommand
        da.Update(ds, "tbl_profiledocument")
        ds.AcceptChanges()
        conn.Close()
    End Sub

    Private Sub SaveProfile()
        Dim dr As DataRow
        dr = ds.Tables(0).NewRow

        dr("fldPassAdmin") = txtPassAdmin.Text
        dr("fldCompany") = txtCompany.Text
        dr("fldAddress") = txtAddress.Text
        dr("fldPhone") = txtPhone.Text
        dr("fldRnc") = txtRnc.Text
        dr("fldPassConfig") = ""
        ds.Tables(0).Rows.Add(dr)

        Dim cmd As New MySqlCommandBuilder(da)
        conn.Open()
        da.InsertCommand = cmd.GetInsertCommand
        da.Update(ds, "tbl_profiledocument")
        ds.AcceptChanges()
        conn.Close()
    End Sub

    Private Sub SaveUpdateINI()


        objIniFile.WriteString("COMPANY", "Name", txtCompany.Text)
        objIniFile.WriteString("COMPANY", "Address", txtAddress.Text)
        objIniFile.WriteString("COMPANY", "Rnc", txtRnc.Text)
        objIniFile.WriteString("COMPANY", "Phone", txtPhone.Text)
        objIniFile.WriteString("POR CIENTO", "Semanal", fld_porciento_semanal.Text)
        objIniFile.WriteString("POR CIENTO", "Semanal 13", fld_porciento_semanal_13.Text)
        objIniFile.WriteString("POR CIENTO", "Semanal 15", fld_porciento_semanal_15.Text)
        objIniFile.WriteString("POR CIENTO", "Quincenal", fld_porciento_quincenal.Text)
        objIniFile.WriteString("POR CIENTO", "Mensual", fld_porciento_mensual.Text)

        objIniFile.WriteString("MAESTRO PRESTAMO", "TIPO", fld_tipo_prestamo.Text)
        objIniFile.WriteString("MAESTRO PRESTAMO", "COD. ZONA", fld_cod_zona_prestamos.Text)

        '
    End Sub

    Private Sub LoadData()

        da = New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
        da.Fill(ds, "tbl_profiledocument")
        Dim nr As DataRow

        For Each nr In ds.Tables(0).Rows
            txtPassAdmin.Text = nr("fldPassAdmin")
            txtCompanyID.Text = nr("fldCompanyID")
            fld_clave_borrar.Text = nr("fldPassConfig")
            txtCompany.Text = nr("fldCompany")
            txtAddress.Text = nr("fldAddress")
            txtRnc.Text = nr("fldRnc")
            txtPhone.Text = nr("fldPhone")
            
            isnewpro = False
        Next

       buscarFotoBD()
    End Sub

    Private Sub Guarda()

        

        If isnewpro = False Then
            UpdateProfile()
        Else
            SaveProfile()
        End If

        SaveUpdateINI()

        guardarFoto()

        Alerta("Documento guardado exitosamente")
    End Sub

    Private Sub Fill_cod_zona()

        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_maestro_zonas", conn)
        da.Fill(ds, "tbl_maestro_zonas")
        Dim dr As DataRow

        For Each dr In ds.Tables(0).Rows
            fld_cod_zona_prestamos.Items.Add(dr("fldId"))
        Next
        ds.Dispose()
        da.Dispose()
    End Sub

    Private Sub busca_zona(ByVal id_cod As String)
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter

        If fld_cod_zona_prestamos.Text = "(none)" Then Exit Sub
        If fld_cod_zona_prestamos.Text = "N/A" Then Exit Sub
        Dim dr As DataRow

        da = New MySqlDataAdapter("SELECT * FROM tbl_maestro_zonas where fldId=" & id_cod & "", conn)
        da.Fill(ds, "tbl_maestro_zonas")

        For Each dr In ds.Tables(0).Rows
            lbl_zona_prestamo.Text = dr("fldDescripcion")
        Next

        ds.Dispose()
        da.Dispose()

        conn.Close()
    End Sub
    'convertir binario a imágen
    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'convertir imagen a binario
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()

        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If

    End Function
    Private Sub guardarFoto()

        Dim sql As String = "UPDATE tbl_profiledocument SET foto=?foto WHERE fldCompanyID=?documento"

        Dim cmd As New MySqlCommand(sql, conn)
        Dim Imag As Byte()
        Imag = Imagen_Bytes(Me.PictureBox1.Image)
        cmd.Parameters.Add("?documento", 1)
        cmd.Parameters.Add("?foto", Imag)

        conn.Open()
        If conn.State = ConnectionState.Open Then
            cmd.ExecuteNonQuery()
        End If
        conn.Close()

    End Sub

    '/// BOTONES
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Guarda()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub fld_porciento_mensual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_porciento_mensual.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_porciento_quincenal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_porciento_quincenal.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_porciento_semanal_13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_porciento_semanal_13.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_porciento_semanal_15_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_porciento_semanal_15.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_cod_zona_prestamos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fld_cod_zona_prestamos.SelectedValueChanged
        busca_zona(fld_cod_zona_prestamos.Text)
    End Sub




    Private Sub txtDiasGracias_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbTipoImpresoraRI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbTipoImpresoraRI_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub buscarFoto()
        Dim filename As String
        Dim openfiler As New OpenFileDialog
        'Definiendo propiedades al openfiledialog
        With openfiler
            'directorio inicial
            .InitialDirectory = "C:\"
            'archivos que se pueden abrir
            .Filter = "Archivos de imágen(*.jpg)|*.jpg|All Files (*.*)|*.*"
            'indice del archivo de lectura por defecto
            .FilterIndex = 1
            'restaurar el directorio al cerrar el dialogo
            .RestoreDirectory = True
        End With
        '
        If openfiler.ShowDialog = Windows.Forms.DialogResult.OK Then  'Evalua si el usuario hace click en el boton abrir
            'Obteniendo la ruta completa del archivo xml
            filename = openfiler.FileName
            Me.PictureBox1.Image = Image.FromFile(filename)
        End If
    End Sub
    Private Sub buscarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarBtn.Click
        buscarFoto()
    End Sub

    Private Sub disponibilidadTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub disponibilidadTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class
