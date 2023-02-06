Imports MySql.Data.MySqlClient
Public Class frmCertificadoApertura
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTasaInteres As System.Windows.Forms.TextBox
    Friend WithEvents txtIDAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtNotas As System.Windows.Forms.TextBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents fld_phone As System.Windows.Forms.TextBox
    Friend WithEvents fld_phone2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIDCliente As System.Windows.Forms.TextBox
    Friend WithEvents cmbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnModificaNota As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents btnNuevoCliente As System.Windows.Forms.Button
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SaldoCapitalTxt As System.Windows.Forms.TextBox
    Friend WithEvents tiempoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCajas As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCertificadoApertura))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTasaInteres = New System.Windows.Forms.TextBox()
        Me.txtIDAhorro = New System.Windows.Forms.TextBox()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.fld_phone = New System.Windows.Forms.TextBox()
        Me.fld_phone2 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIDCliente = New System.Windows.Forms.TextBox()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpFechaInicia = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnModificaNota = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaldoCapitalTxt = New System.Windows.Forms.TextBox()
        Me.tiempoTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCajas = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(17, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Cuenta No. :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(105, 153)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(104, 20)
        Me.txtCuenta.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(33, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nota :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(17, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 8)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.SystemColors.Control
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.Black
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.Location = New System.Drawing.Point(456, 68)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(144, 56)
        Me.btnConsultar.TabIndex = 9
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
        Me.btnCerrar.Location = New System.Drawing.Point(528, 124)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 10
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(456, 124)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(72, 56)
        Me.btnBorrar.TabIndex = 11
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(528, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 7
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
        Me.btnNuevo.Location = New System.Drawing.Point(456, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(215, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 18)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Interes (Mensual):"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTasaInteres
        '
        Me.txtTasaInteres.BackColor = System.Drawing.Color.White
        Me.txtTasaInteres.Location = New System.Drawing.Point(313, 180)
        Me.txtTasaInteres.Name = "txtTasaInteres"
        Me.txtTasaInteres.Size = New System.Drawing.Size(128, 20)
        Me.txtTasaInteres.TabIndex = 3
        Me.txtTasaInteres.Text = "0"
        Me.txtTasaInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIDAhorro
        '
        Me.txtIDAhorro.BackColor = System.Drawing.Color.White
        Me.txtIDAhorro.Location = New System.Drawing.Point(456, 36)
        Me.txtIDAhorro.Name = "txtIDAhorro"
        Me.txtIDAhorro.Size = New System.Drawing.Size(48, 20)
        Me.txtIDAhorro.TabIndex = 31
        Me.txtIDAhorro.Text = "0"
        Me.txtIDAhorro.Visible = False
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(104, 232)
        Me.txtNotas.MaxLength = 550
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtNotas.Size = New System.Drawing.Size(337, 72)
        Me.txtNotas.TabIndex = 6
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Location = New System.Drawing.Point(105, 88)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(336, 20)
        Me.txtCedula.TabIndex = 33
        '
        'fld_phone
        '
        Me.fld_phone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.fld_phone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_phone.Location = New System.Drawing.Point(105, 112)
        Me.fld_phone.Name = "fld_phone"
        Me.fld_phone.ReadOnly = True
        Me.fld_phone.Size = New System.Drawing.Size(144, 20)
        Me.fld_phone.TabIndex = 34
        '
        'fld_phone2
        '
        Me.fld_phone2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.fld_phone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_phone2.Location = New System.Drawing.Point(297, 112)
        Me.fld_phone2.Name = "fld_phone2"
        Me.fld_phone2.ReadOnly = True
        Me.fld_phone2.Size = New System.Drawing.Size(144, 20)
        Me.fld_phone2.TabIndex = 35
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(105, 64)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(336, 20)
        Me.txtNombre.TabIndex = 32
        '
        'txtIDCliente
        '
        Me.txtIDCliente.BackColor = System.Drawing.Color.White
        Me.txtIDCliente.Enabled = False
        Me.txtIDCliente.Location = New System.Drawing.Point(105, 40)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIDCliente.TabIndex = 13
        Me.txtIDCliente.Text = "0"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.cmbCategoria.ForeColor = System.Drawing.Color.White
        Me.cmbCategoria.Location = New System.Drawing.Point(313, 154)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(128, 21)
        Me.cmbCategoria.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(241, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Categoría :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFechaInicia
        '
        Me.dtpFechaInicia.CustomFormat = "dd / MMM /yyyy"
        Me.dtpFechaInicia.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicia.Location = New System.Drawing.Point(105, 180)
        Me.dtpFechaInicia.Name = "dtpFechaInicia"
        Me.dtpFechaInicia.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicia.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(9, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Fecha Apertura :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnModificaNota
        '
        Me.btnModificaNota.Enabled = False
        Me.btnModificaNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaNota.Location = New System.Drawing.Point(456, 180)
        Me.btnModificaNota.Name = "btnModificaNota"
        Me.btnModificaNota.Size = New System.Drawing.Size(144, 24)
        Me.btnModificaNota.TabIndex = 12
        Me.btnModificaNota.Text = "&Modificar Nota"
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(33, 72)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(64, 16)
        Me.lblNombre.TabIndex = 17
        Me.lblNombre.Text = "Socio :"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApellidos
        '
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblApellidos.Location = New System.Drawing.Point(33, 120)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(64, 16)
        Me.lblApellidos.TabIndex = 19
        Me.lblApellidos.Text = "Telefonos :"
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnNuevoCliente.ForeColor = System.Drawing.Color.Black
        Me.btnNuevoCliente.Location = New System.Drawing.Point(345, 40)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(96, 22)
        Me.btnNuevoCliente.TabIndex = 14
        Me.btnNuevoCliente.Text = "Nu&evo Socio"
        Me.btnNuevoCliente.UseVisualStyleBackColor = False
        Me.btnNuevoCliente.Visible = False
        '
        'lblId
        '
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblId.Location = New System.Drawing.Point(9, 48)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(88, 16)
        Me.lblId.TabIndex = 16
        Me.lblId.Text = "Código :"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBuscarCliente.ForeColor = System.Drawing.Color.Black
        Me.btnBuscarCliente.Location = New System.Drawing.Point(241, 40)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(96, 22)
        Me.btnBuscarCliente.TabIndex = 1
        Me.btnBuscarCliente.Text = "B&uscar Socio"
        Me.btnBuscarCliente.UseVisualStyleBackColor = False
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCedula.Location = New System.Drawing.Point(33, 96)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(64, 16)
        Me.lblCedula.TabIndex = 18
        Me.lblCedula.Text = "Cédula :"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OliveDrab
        Me.Label3.Location = New System.Drawing.Point(0, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(649, 32)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "APERTURA DE CERTIFICADO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(252, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Monto :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SaldoCapitalTxt
        '
        Me.SaldoCapitalTxt.BackColor = System.Drawing.Color.White
        Me.SaldoCapitalTxt.Location = New System.Drawing.Point(313, 206)
        Me.SaldoCapitalTxt.Name = "SaldoCapitalTxt"
        Me.SaldoCapitalTxt.Size = New System.Drawing.Size(128, 20)
        Me.SaldoCapitalTxt.TabIndex = 5
        Me.SaldoCapitalTxt.Text = "0"
        Me.SaldoCapitalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tiempoTxt
        '
        Me.tiempoTxt.Location = New System.Drawing.Point(104, 206)
        Me.tiempoTxt.Name = "tiempoTxt"
        Me.tiempoTxt.Size = New System.Drawing.Size(104, 20)
        Me.tiempoTxt.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(9, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Plazo (Meses) :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbCajas
        '
        Me.cmbCajas.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.cmbCajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCajas.ForeColor = System.Drawing.Color.White
        Me.cmbCajas.Location = New System.Drawing.Point(104, 16)
        Me.cmbCajas.Name = "cmbCajas"
        Me.cmbCajas.Size = New System.Drawing.Size(337, 21)
        Me.cmbCajas.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(25, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Caja :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCertificadoApertura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(649, 341)
        Me.Controls.Add(Me.cmbCajas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tiempoTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SaldoCapitalTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTasaInteres)
        Me.Controls.Add(Me.txtIDAhorro)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.fld_phone)
        Me.Controls.Add(Me.fld_phone2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIDCliente)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dtpFechaInicia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnModificaNota)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.btnNuevoCliente)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.lblCedula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCertificadoApertura"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apertura de Certificado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim ctaContableCertificados As String = "0"

    Private Sub Nuevo()
        txtCuenta.Text = String.Empty
        txtIDCliente.Text = 0
        txtIDAhorro.Text = 0
        txtNombre.Text = String.Empty
        fld_phone.Text = String.Empty
        fld_phone2.Text = String.Empty
        txtCedula.Text = String.Empty

        cmbCategoria.SelectedIndex = -1
        dtpFechaInicia.Value = DateTime.Now()
        txtTasaInteres.Text = 0

        txtNotas.Text = String.Empty

        SaldoCapitalTxt.Text = "0.00"

        btnBorrar.Enabled = False

        btnModificaNota.Enabled = False
    End Sub
    Private Function validarDocumento() As Boolean
        If txtIDCliente.Text = String.Empty Then txtIDCliente.Text = 0
        If txtTasaInteres.Text = String.Empty Then txtTasaInteres.Text = 0
        If tiempoTxt.Text = String.Empty Then tiempoTxt.Text = 0

        If SaldoCapitalTxt.Text = String.Empty Then SaldoCapitalTxt.Text = 0
        If SCALAR_NUM("SELECT IFNULL(1,0) FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & Me.Text & "'") = 0 Then
            Alerta("El Interfas contable no está configurado, no se puede guardar el documento.")
            Return False
        End If
        ctaContableCertificados = SCALAR_STRING("SELECT IFNULL(Certificados,0) FROM tbl_interfascontableotras WHERE ID=1")

        If SCALAR_STRING("SELECT Descripcion FROM tbl_catalogo WHERE CuentaNo='" & ctaContableCertificados & "'") = String.Empty Then
            Alerta("Debe configurar la cuenta de Certificados en Interfas contable")
            Return False
        End If
        If CDbl(txtIDCliente.Text) <= 0 Then
            Alerta("Seleccione un cliente")
            txtIDCliente.Focus()
            Return False
        ElseIf cmbCategoria.SelectedIndex = -1 Then
            Alerta("Seleccione una categoría")
            cmbCategoria.Focus()
            Return False
        ElseIf CDbl(tiempoTxt.Text) <= 0 Then
            Alerta("Debe establecer el plazo de tiempo en meses")
            tiempoTxt.Focus()
            Return False
        ElseIf CDbl(SaldoCapitalTxt.Text) <= 0 Then
            Alerta("Escriba el monto por favor")
            SaldoCapitalTxt.Focus()
            Return False

        End If

        Return True
    End Function
    Private Sub LlenarCategoria()

        Dim da As New MySqlDataAdapter("SELECT ID, Descripcion FROM tbl_ahorros_categorias ORDER BY Descripcion", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbCategoria.DataSource = dt
        cmbCategoria.DisplayMember = "Descripcion"
        cmbCategoria.ValueMember = "ID"

    End Sub
    Private Sub BuscarCliente(ByVal idCliente As Integer)
        Dim isdata As Boolean = False
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_clientes WHERE fld_id=" & idCliente & "", conn)
        da.Fill(ds, "tbl_clientes")

        Dim nr As DataRow
        If ds.Tables(0).Rows.Count = 0 Then Return
        For Each nr In ds.Tables(0).Rows

            txtIDCliente.Text = idCliente
            txtNombre.Text = nr("fld_FullName")
            fld_phone.Text = nr("fld_phone")
            fld_phone2.Text = nr("fld_phone2")
            txtCedula.Text = nr("fld_Identity")

            cmbCategoria.Text = nr("fld_zona")
            GoTo sigue
        Next
        Alerta("No se encontró el documento solicitado")
        txtIDCliente.Focus()
        da.Dispose()
        ds.Dispose()
        Exit Sub
sigue:
        cmbCategoria.Focus()
        da.Dispose()
        ds.Dispose()
    End Sub
    Private Sub BuscarAhorro(ByVal idAhorro As Integer)
        Dim isdata As Boolean = False
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_ahorros_certificado WHERE ID=" & idAhorro & "", conn)
        da.Fill(ds, "tbl_ahorros_certificado")

        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            txtCuenta.Text = dr("CuentaNo")
            txtIDAhorro.Text = Format(idAhorro, "00000")
            dtpFechaInicia.Value = dr("FechaApertura")
            cmbCategoria.SelectedItem = dr("Categoria")
            txtTasaInteres.Text = dr("TasaIteres")

            txtNotas.Text = dr("Nota")

            SaldoCapitalTxt.Text = dr("SaldoCapital")
            tiempoTxt.Text = dr("Tiempo")

            BuscarCliente(dr("IDCliente"))
            btnBorrar.Enabled = True
            btnModificaNota.Enabled = True
        Next

        da.Dispose()
        ds.Dispose()
    End Sub

    Private Sub LlenarCajas()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT Id, Descripcion FROM cajamantenimiento ORDER BY Descripcion", conn)
        da.Fill(dt)

        cmbCajas.DataSource = dt
        cmbCajas.DisplayMember = "Descripcion"
        cmbCajas.ValueMember = "Id"
        da.Dispose()
    End Sub

    Private Sub guardarTransaccionContable(ByVal idDocAfectado As Integer)

        Dim idTipoTrans = SCALAR_NUM("SELECT IdTipo FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & Me.Text & "'")

        NON_QUERY("CALL cont_insert_trans(Now(),'" & txtNotas.Text & "'," & idTipoTrans & ",'" & User(0) & "'," & idDocAfectado & ",'CERTIFICADO DE AHORRO','" & " Certificado de ahorro a cta. no. " & txtCuenta.Text & "')")

        Dim idTras = UltimoID("tbl_interfascontabletransacciones", "TransID")

        Dim ctaContableCaja = SCALAR_STRING("SELECT CtaContable  FROM cajamantenimiento WHERE ID=" & cmbCajas.SelectedValue & "")

        'Guardar detalle débito
        Dim DescripcionCuenta = ReturnDescripcion(ctaContableCaja)
        GuardarTransaccionDetalle(idTras, ctaContableCaja, DescripcionCuenta, CDbl(SaldoCapitalTxt.Text), 0)

        'Guardar detalle crédito
        DescripcionCuenta = ReturnDescripcion(ctaContableCertificados)
        GuardarTransaccionDetalle(idTras, ctaContableCertificados, DescripcionCuenta, 0, CDbl(SaldoCapitalTxt.Text))
    End Sub

    Private Sub reversarTransaccionContable(ByVal idDocAfectado As Integer)

        Dim idTrans = SCALAR_NUM("SELECT IFNULL(ict.TransID, 0) FROM tbl_interfascontabletipotrans_conf AS icttc INNER JOIN tbl_interfascontabletransacciones AS ict ON icttc.IdTipo = ict.TransIDTipo WHERE icttc.Frm = '" & Me.Text & "' AND ict.TransIDDoc = " & idDocAfectado)

        If idTrans <> 0 Then
            Dim ctaContableCaja = SCALAR_STRING("SELECT IFNULL(cm.CtaContable, 0) FROM cajamantenimiento AS cm INNER JOIN tbl_ahorros_certificado AS ac ON cm.ID = ac.IdCaja WHERE ac.ID = " & idDocAfectado)

            Dim saldoCapital = SCALAR_NUM("SELECT IFNULL(-SaldoCapital, 0) FROM tbl_ahorros_certificado WHERE ID = " & idDocAfectado)

            Dim ctaContableCertificados = SCALAR_STRING("SELECT IFNULL(Certificados, 0) FROM tbl_interfascontableotras WHERE ID = 1")

            'Reversa detalle débito
            Dim DescripcionCuenta = ReturnDescripcion(ctaContableCaja)
            GuardarTransaccionDetalle(idTrans, ctaContableCaja, DescripcionCuenta, saldoCapital, 0)

            'Reversa detalle crédito
            DescripcionCuenta = ReturnDescripcion(ctaContableCertificados)
            GuardarTransaccionDetalle(idTrans, ctaContableCertificados, DescripcionCuenta, 0, saldoCapital)
        End If
    End Sub

    Private Sub frmCertificadoApertura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarCategoria()
        LlenarCajas()
    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            BuscarCliente(Id)
            cmbCategoria.Focus()
        End If
    End Sub

    Private Sub btnNuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCliente.Click
        Dim f As New FRM_CLIENTES
        f.ShowDialog()
        f.Dispose()
        If Alerta("¿Desea cargar los datos del último socio creado?") = True Then
            BuscarCliente(UltimoID("tbl_clientes", "fld_id"))
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Nuevo()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If validarDocumento() = False Then Return
        If Alerta("¿Seguro que desea guardar el documento?") = False Then Return

        Dim cuentaNo As String = txtCuenta.Text

        If cuentaNo = String.Empty Then
            Dim prefijo As String = SCALAR_STRING("SELECT PreFijo FROM tbl_ahorros_prefijos_cta WHERE Categoria=" & cmbCategoria.SelectedValue & "")
            Dim idAhorro As Integer = UltimoID("tbl_ahorros_certificado", "ID") + 1
            cuentaNo = prefijo & "-" & Format(idAhorro, "00000")

            txtCuenta.Text = cuentaNo
            txtIDAhorro.Text = idAhorro

            NON_QUERY("INSERT INTO tbl_ahorros_certificado (CuentaNo, IDCliente, Categoria, FechaApertura, FechaCancelada, TasaIteres, SaldoCapital, SaldoInteres, SaldoRetiros, Usuario, Nota, Estado, Tiempo, IdCaja) VALUES('" & cuentaNo & "'," & txtIDCliente.Text & "," & cmbCategoria.SelectedValue & ",'" & Format(dtpFechaInicia.Value, "yyyy-MM-dd") & "','" & Format(dtpFechaInicia.Value, "yyyy-MM-dd") & "'," & CDbl(txtTasaInteres.Text) & "," & CDbl(SaldoCapitalTxt.Text) & ",0,0,'" & User(0) & "','" & txtNotas.Text & "','Activa'," & CInt(tiempoTxt.Text) & "," & cmbCajas.SelectedValue & ")")
            guardarTransaccionContable(idAhorro)
        Else
            Dim idAhorro As Integer = CInt(txtIDAhorro.Text)

            Dim totalRetiros As Double = SCALAR_NUM("SELECT IFNULL(Monto, 0) FROM tbl_ahorros_certificado_retiros WHERE IDAhorro = " & idAhorro)

            If totalRetiros = 0 Then
                If FRMS_CLAVE_MAESTRA("Acceso") = False Then Return

                reversarTransaccionContable(idAhorro)
                'NON_QUERY("UPDATE tbl_ahorros_certificado SET Categoria = " & cmbCategoria.SelectedValue & ", FechaApertura = '" & Format(dtpFechaInicia.Value, "yyyy-MM-dd") & "', FechaCancelada = '" & Format(dtpFechaInicia.Value, "yyyy-MM-dd") & "', TasaIteres = " & CDbl(txtTasaInteres.Text) & ", SaldoCapital = " & CDbl(SaldoCapitalTxt.Text) & ", Usuario = '" & User(0) & "', Nota = '" & txtNotas.Text & "', Tiempo = " & CInt(tiempoTxt.Text) & ", IdCaja = " & cmbCajas.SelectedValue & " WHERE CuentaNo = '" & cuentaNo & "'")
                NON_QUERY("UPDATE tbl_ahorros_certificado SET TasaIteres = " & CDbl(txtTasaInteres.Text) & ", SaldoCapital = " & CDbl(SaldoCapitalTxt.Text) & ", Usuario = '" & User(0) & "', Nota = '" & txtNotas.Text & "', Tiempo = " & CInt(tiempoTxt.Text) & " WHERE CuentaNo = '" & cuentaNo & "'")
                guardarTransaccionContable(idAhorro)
            Else
                Alerta("Solo se pueden borrar certificados sin retiros")
            End If
        End If

        btnNuevo_Click(sender, e)
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If FRMS_LIST_CERTIFICADO() = True Then
            BuscarAhorro(Id)
        End If
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        Dim idAhorro As Integer = CInt(txtIDAhorro.Text)

        Dim totalRetiros As Double = SCALAR_NUM("SELECT IFNULL(Monto, 0) FROM tbl_ahorros_certificado_retiros WHERE IDAhorro = " & idAhorro)

        If totalRetiros = 0 Then
            If FRMS_CLAVE_MAESTRA("Acceso") = True Then
                If Alerta("¿Está seguro que desea Cancelar esta cuenta?") = False Then Return

                NON_QUERY("UPDATE tbl_ahorros_certificado SET Estado='Cancelada' WHERE ID=" & CInt(txtIDAhorro.Text) & "")
                reversarTransaccionContable(idAhorro)

                Nuevo()
            End If
        Else
            Alerta("Solo se pueden borrar certificados sin retiros")
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnModificaNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificaNota.Click
        NON_QUERY("UPDATE tbl_ahorros_certificado SET Nota='" & txtNotas.Text & "' WHERE ID=" & CInt(txtIDAhorro.Text) & "")
        Alerta("Nota modificada")
    End Sub



    Private Sub txtTasaInteres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTasaInteres.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub



    Private Sub SaldoCapitalTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SaldoCapitalTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub



    Private Sub SaldoCapitalTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SaldoCapitalTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim amount As Decimal = CType(SaldoCapitalTxt.Text, Decimal)
            Me.SaldoCapitalTxt.Text = String.Format("{0:n2}", amount)
            SaldoCapitalTxt.Focus()
        End If
    End Sub
    '


    Private Sub tiempoTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tiempoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmCertificadoApertura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategoria.SelectedIndexChanged

    End Sub

    Private Sub cmbCategoria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCategoria.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub cmbCajas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCajas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtTasaInteres_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTasaInteres.TextChanged

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class
