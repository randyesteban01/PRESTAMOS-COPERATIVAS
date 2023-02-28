Imports MySql.Data.MySqlClient
Public Class frmCuentaAhorros
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
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtIDAhorro As System.Windows.Forms.TextBox
    Friend WithEvents btnModificaNota As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTasaInteres As TextBox
    Friend WithEvents txtNotas As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents fld_phone As TextBox
    Friend WithEvents fld_phone2 As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIDCliente As TextBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpFechaInicia As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents btnNuevoCliente As Button
    Friend WithEvents lblId As Label
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents lblCedula As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtCedula2doTitular As TextBox
    Friend WithEvents txtNombre2doTitular As TextBox
    Friend WithEvents txtIDCliente2doTitular As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNota2doTitular As TextBox
    Friend WithEvents txtTel2doTitular As MaskedTextBox
    Friend WithEvents txtWhatsapp2doTitular As MaskedTextBox
    Friend WithEvents txtCel2doTitular As MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuentaAhorros))
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtIDAhorro = New System.Windows.Forms.TextBox()
        Me.btnModificaNota = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTasaInteres = New System.Windows.Forms.TextBox()
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtWhatsapp2doTitular = New System.Windows.Forms.MaskedTextBox()
        Me.txtCel2doTitular = New System.Windows.Forms.MaskedTextBox()
        Me.txtTel2doTitular = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNota2doTitular = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCedula2doTitular = New System.Windows.Forms.TextBox()
        Me.txtNombre2doTitular = New System.Windows.Forms.TextBox()
        Me.txtIDCliente2doTitular = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.SystemColors.Control
        Me.btnConsultar.FlatAppearance.BorderSize = 0
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnConsultar.ForeColor = System.Drawing.Color.Black
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.Location = New System.Drawing.Point(458, 90)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(144, 56)
        Me.btnConsultar.TabIndex = 8
        Me.btnConsultar.Text = "&Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(530, 146)
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
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(458, 146)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(72, 56)
        Me.btnBorrar.TabIndex = 9
        Me.btnBorrar.Text = "&Cancelar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(530, 34)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(458, 34)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txtIDAhorro
        '
        Me.txtIDAhorro.BackColor = System.Drawing.Color.White
        Me.txtIDAhorro.Location = New System.Drawing.Point(534, 126)
        Me.txtIDAhorro.Name = "txtIDAhorro"
        Me.txtIDAhorro.Size = New System.Drawing.Size(48, 20)
        Me.txtIDAhorro.TabIndex = 29
        Me.txtIDAhorro.Text = "0"
        Me.txtIDAhorro.Visible = False
        '
        'btnModificaNota
        '
        Me.btnModificaNota.Enabled = False
        Me.btnModificaNota.FlatAppearance.BorderSize = 0
        Me.btnModificaNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificaNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaNota.Location = New System.Drawing.Point(458, 202)
        Me.btnModificaNota.Name = "btnModificaNota"
        Me.btnModificaNota.Size = New System.Drawing.Size(144, 24)
        Me.btnModificaNota.TabIndex = 11
        Me.btnModificaNota.Text = "&Modificar Nota"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(0, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(606, 32)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "APERTURA DE CUENTA DE AHORRO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(446, 284)
        Me.TabControl1.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtCuenta)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.txtTasaInteres)
        Me.TabPage1.Controls.Add(Me.txtNotas)
        Me.TabPage1.Controls.Add(Me.txtCedula)
        Me.TabPage1.Controls.Add(Me.fld_phone)
        Me.TabPage1.Controls.Add(Me.fld_phone2)
        Me.TabPage1.Controls.Add(Me.txtNombre)
        Me.TabPage1.Controls.Add(Me.txtIDCliente)
        Me.TabPage1.Controls.Add(Me.cmbCategoria)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.dtpFechaInicia)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblNombre)
        Me.TabPage1.Controls.Add(Me.lblApellidos)
        Me.TabPage1.Controls.Add(Me.btnNuevoCliente)
        Me.TabPage1.Controls.Add(Me.lblId)
        Me.TabPage1.Controls.Add(Me.btnBuscarCliente)
        Me.TabPage1.Controls.Add(Me.lblCedula)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(438, 258)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos del 1er. Titular"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(8, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Cuenta No. :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCuenta
        '
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(96, 124)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(104, 20)
        Me.txtCuenta.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(24, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Nota :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 8)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'txtTasaInteres
        '
        Me.txtTasaInteres.BackColor = System.Drawing.Color.White
        Me.txtTasaInteres.Location = New System.Drawing.Point(272, 146)
        Me.txtTasaInteres.Name = "txtTasaInteres"
        Me.txtTasaInteres.Size = New System.Drawing.Size(128, 20)
        Me.txtTasaInteres.TabIndex = 33
        Me.txtTasaInteres.Text = "0"
        Me.txtTasaInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(96, 172)
        Me.txtNotas.MaxLength = 550
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtNotas.Size = New System.Drawing.Size(304, 56)
        Me.txtNotas.TabIndex = 34
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Location = New System.Drawing.Point(96, 60)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(304, 20)
        Me.txtCedula.TabIndex = 49
        '
        'fld_phone
        '
        Me.fld_phone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.fld_phone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_phone.Location = New System.Drawing.Point(96, 84)
        Me.fld_phone.Name = "fld_phone"
        Me.fld_phone.ReadOnly = True
        Me.fld_phone.Size = New System.Drawing.Size(144, 20)
        Me.fld_phone.TabIndex = 48
        '
        'fld_phone2
        '
        Me.fld_phone2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.fld_phone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_phone2.Location = New System.Drawing.Point(256, 84)
        Me.fld_phone2.Name = "fld_phone2"
        Me.fld_phone2.ReadOnly = True
        Me.fld_phone2.Size = New System.Drawing.Size(144, 20)
        Me.fld_phone2.TabIndex = 47
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(96, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(304, 20)
        Me.txtNombre.TabIndex = 50
        '
        'txtIDCliente
        '
        Me.txtIDCliente.BackColor = System.Drawing.Color.White
        Me.txtIDCliente.Enabled = False
        Me.txtIDCliente.Location = New System.Drawing.Point(96, 12)
        Me.txtIDCliente.Name = "txtIDCliente"
        Me.txtIDCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIDCliente.TabIndex = 30
        Me.txtIDCliente.Text = "0"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.cmbCategoria.ForeColor = System.Drawing.Color.White
        Me.cmbCategoria.Location = New System.Drawing.Point(272, 124)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(128, 21)
        Me.cmbCategoria.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(202, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Categoría :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFechaInicia
        '
        Me.dtpFechaInicia.CustomFormat = "dd / MMM /yyyy"
        Me.dtpFechaInicia.Enabled = False
        Me.dtpFechaInicia.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicia.Location = New System.Drawing.Point(96, 148)
        Me.dtpFechaInicia.Name = "dtpFechaInicia"
        Me.dtpFechaInicia.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicia.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(0, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Fecha Apertura :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(24, 38)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(64, 16)
        Me.lblNombre.TabIndex = 37
        Me.lblNombre.Text = "Nombre :"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApellidos
        '
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblApellidos.Location = New System.Drawing.Point(24, 86)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(64, 16)
        Me.lblApellidos.TabIndex = 39
        Me.lblApellidos.Text = "Telefonos :"
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevoCliente.FlatAppearance.BorderSize = 0
        Me.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnNuevoCliente.ForeColor = System.Drawing.Color.Black
        Me.btnNuevoCliente.Location = New System.Drawing.Point(304, 11)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(96, 22)
        Me.btnNuevoCliente.TabIndex = 35
        Me.btnNuevoCliente.Text = "Nu&evo Socio"
        Me.btnNuevoCliente.UseVisualStyleBackColor = False
        '
        'lblId
        '
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblId.Location = New System.Drawing.Point(0, 14)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(88, 16)
        Me.lblId.TabIndex = 36
        Me.lblId.Text = "Código :"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscarCliente.FlatAppearance.BorderSize = 0
        Me.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBuscarCliente.ForeColor = System.Drawing.Color.Black
        Me.btnBuscarCliente.Location = New System.Drawing.Point(200, 11)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(96, 22)
        Me.btnBuscarCliente.TabIndex = 29
        Me.btnBuscarCliente.Text = "B&uscar Socio"
        Me.btnBuscarCliente.UseVisualStyleBackColor = False
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCedula.Location = New System.Drawing.Point(24, 62)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(64, 16)
        Me.lblCedula.TabIndex = 38
        Me.lblCedula.Text = "Cédula :"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(194, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Int. Mensual:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtWhatsapp2doTitular)
        Me.TabPage2.Controls.Add(Me.txtCel2doTitular)
        Me.TabPage2.Controls.Add(Me.txtTel2doTitular)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.txtNota2doTitular)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtCedula2doTitular)
        Me.TabPage2.Controls.Add(Me.txtNombre2doTitular)
        Me.TabPage2.Controls.Add(Me.txtIDCliente2doTitular)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(438, 258)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos del 2do. Titular"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtWhatsapp2doTitular
        '
        Me.txtWhatsapp2doTitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtWhatsapp2doTitular.Location = New System.Drawing.Point(308, 86)
        Me.txtWhatsapp2doTitular.Mask = "000-000-0000"
        Me.txtWhatsapp2doTitular.Name = "txtWhatsapp2doTitular"
        Me.txtWhatsapp2doTitular.Size = New System.Drawing.Size(105, 20)
        Me.txtWhatsapp2doTitular.TabIndex = 68
        '
        'txtCel2doTitular
        '
        Me.txtCel2doTitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtCel2doTitular.Location = New System.Drawing.Point(79, 83)
        Me.txtCel2doTitular.Mask = "000-000-0000"
        Me.txtCel2doTitular.Name = "txtCel2doTitular"
        Me.txtCel2doTitular.Size = New System.Drawing.Size(124, 20)
        Me.txtCel2doTitular.TabIndex = 67
        '
        'txtTel2doTitular
        '
        Me.txtTel2doTitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtTel2doTitular.Location = New System.Drawing.Point(308, 58)
        Me.txtTel2doTitular.Mask = "000-000-0000"
        Me.txtTel2doTitular.Name = "txtTel2doTitular"
        Me.txtTel2doTitular.Size = New System.Drawing.Size(105, 20)
        Me.txtTel2doTitular.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(37, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Nota :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(21, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 8)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        '
        'txtNota2doTitular
        '
        Me.txtNota2doTitular.Location = New System.Drawing.Point(109, 172)
        Me.txtNota2doTitular.MaxLength = 550
        Me.txtNota2doTitular.Multiline = True
        Me.txtNota2doTitular.Name = "txtNota2doTitular"
        Me.txtNota2doTitular.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtNota2doTitular.Size = New System.Drawing.Size(304, 56)
        Me.txtNota2doTitular.TabIndex = 63
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(236, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Whatsapp :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(236, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Telefono :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCedula2doTitular
        '
        Me.txtCedula2doTitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtCedula2doTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula2doTitular.Location = New System.Drawing.Point(79, 58)
        Me.txtCedula2doTitular.Name = "txtCedula2doTitular"
        Me.txtCedula2doTitular.Size = New System.Drawing.Size(124, 20)
        Me.txtCedula2doTitular.TabIndex = 58
        '
        'txtNombre2doTitular
        '
        Me.txtNombre2doTitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtNombre2doTitular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre2doTitular.Location = New System.Drawing.Point(79, 34)
        Me.txtNombre2doTitular.Name = "txtNombre2doTitular"
        Me.txtNombre2doTitular.Size = New System.Drawing.Size(334, 20)
        Me.txtNombre2doTitular.TabIndex = 59
        '
        'txtIDCliente2doTitular
        '
        Me.txtIDCliente2doTitular.BackColor = System.Drawing.Color.White
        Me.txtIDCliente2doTitular.Enabled = False
        Me.txtIDCliente2doTitular.Location = New System.Drawing.Point(79, 10)
        Me.txtIDCliente2doTitular.Name = "txtIDCliente2doTitular"
        Me.txtIDCliente2doTitular.Size = New System.Drawing.Size(100, 20)
        Me.txtIDCliente2doTitular.TabIndex = 51
        Me.txtIDCliente2doTitular.Text = "0"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(7, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Nombre :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(7, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Celular:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(-17, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Código :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(7, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Cédula :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCuentaAhorros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(606, 331)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtIDAhorro)
        Me.Controls.Add(Me.btnModificaNota)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCuentaAhorros"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apertura de Cuenta de Ahorros"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Nuevo()
        btnGuardar.Text = "Guardar"

        txtCuenta.Text = String.Empty
        txtIDCliente.Text = 0
        txtIDCliente2doTitular.Text = 0
        txtIDAhorro.Text = 0
        txtNombre.Text = String.Empty
        txtNombre2doTitular.Text = String.Empty

        fld_phone.Text = String.Empty
        fld_phone2.Text = String.Empty
        txtCedula.Text = String.Empty
        txtCedula2doTitular.Text = String.Empty

        txtTel2doTitular.Text = String.Empty
        txtCel2doTitular.Text = String.Empty
        txtWhatsapp2doTitular.Text = String.Empty
        txtNota2doTitular.Text = String.Empty

        cmbCategoria.SelectedIndex = -1
        dtpFechaInicia.Value = DateTime.Now()
        txtTasaInteres.Text = 0

        txtNotas.Text = String.Empty



        btnBorrar.Enabled = False

        btnModificaNota.Enabled = False
    End Sub
    Private Function Validar() As Boolean
        If txtIDCliente.Text = String.Empty Then txtIDCliente.Text = 0
        If Me.txtIDCliente2doTitular.Text = String.Empty Then txtIDCliente2doTitular.Text = 0

        If txtTasaInteres.Text = String.Empty Then txtTasaInteres.Text = 0




        If CDbl(txtIDCliente.Text) <= 0 Then
            Alerta("Seleccione un cliente")
            txtIDCliente.Focus()
            Return False
        ElseIf cmbCategoria.SelectedIndex = -1 Then
            Alerta("Seleccione una categoría")
            cmbCategoria.Focus()
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
    Private Sub Cargar_Tasa_Ctas()
        Dim cmd As New MySqlCommand
        Dim dr As MySqlDataReader
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT tasacuenta FROM tbl_ahorros_categorIas WHERE descripcion='" & cmbCategoria.Text & "'", conn)
            dr = cmd.ExecuteReader
            With dr.Read
                txtTasaInteres.Text = dr(0).ToString
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            conn.Close()
        Finally
            conn.Close()
        End Try
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
            txtIDCliente2doTitular.Text = idCliente
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
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_ahorros_cuentas WHERE ID=" & idAhorro & "", conn)
        da.Fill(ds, "tbl_ahorros")

        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            txtCuenta.Text = dr("CuentaNo")
            txtIDAhorro.Text = Format(idAhorro, "00000")
            dtpFechaInicia.Value = dr("FechaApertura")
            cmbCategoria.SelectedValue = dr("Categoria")
            txtTasaInteres.Text = dr("TasaIteres")

            txtNotas.Text = dr("Nota")


            BuscarCliente(dr("IDCliente"))
            btnBorrar.Enabled = True
            btnModificaNota.Enabled = True
        Next

        da.Dispose()
        ds.Dispose()
    End Sub


    Private Sub Buscar2doTitular(ByVal idAhorro As Integer)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tlb_segundo_titular_cta_ahorros WHERE fldIdAhorro=" & idAhorro & "", conn)
        da.Fill(ds, "tlb_segundo_titular_cta_ahorros")

        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            txtNombre2doTitular.Text = dr("fldNombre2doTitular")
            txtCedula2doTitular.Text = dr("fldCedula2doTitular")
            txtTel2doTitular.Text = dr("fldTelefono2doTitular")
            txtCel2doTitular.Text = dr("fldCelular2doTitular")
            txtWhatsapp2doTitular.Text = dr("fldWhatsapp2doTitular")
            txtNota2doTitular.Text = dr("fldNotas2doTitular")
        Next

        da.Dispose()
        ds.Dispose()
    End Sub



    Private Sub frmCuentaAhorros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarCategoria()
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
        If Validar() = False Then Return

        If btnGuardar.Text = "Guardar" Then

            If Alerta("¿Seguro que desea guardar el documento?") = False Then Return

            Dim prefijo As String = SCALAR_STRING("SELECT PreFijo FROM tbl_ahorros_prefijos_cta WHERE Categoria=" & cmbCategoria.SelectedValue & "")
            Dim idAhorro As Integer = UltimoID("tbl_ahorros_cuentas", "ID") + 1
            Dim cuentaNo As String = prefijo & "-" & Format(idAhorro, "00000")

            txtCuenta.Text = cuentaNo
            txtIDAhorro.Text = idAhorro

            NON_QUERY("INSERT INTO tbl_ahorros_cuentas (CuentaNo, IDCliente, Categoria, FechaApertura, FechaCancelada, TasaIteres, SaldoCapital, SaldoInteres, SaldoRetiros, Usuario, Nota, Estado) VALUES('" & cuentaNo & "'," & txtIDCliente.Text & "," & cmbCategoria.SelectedValue & ",'" & Format(dtpFechaInicia.Value, "yyyy-MM-dd") & "','" & Format(dtpFechaInicia.Value, "yyyy-MM-dd") & "'," & CDbl(txtTasaInteres.Text) & ",0,0,0,'" & User(0) & "','" & txtNotas.Text & "','Activa')")
            NON_QUERY("INSERT INTO tlb_segundo_titular_cta_ahorros (fldIdAhorro,fldCodSocio, fldNombre2doTitular, fldCedula2doTitular, fldTelefono2doTitular, fldCelular2doTitular, fldWhatsapp2doTitular, fldNotas2doTitular) VALUES('" & idAhorro & "'," & txtIDCliente2doTitular.Text & ",'" & txtNombre2doTitular.Text & "','" & txtCedula2doTitular.Text & "','" & txtTel2doTitular.Text & "','" & txtCel2doTitular.Text & "','" & txtWhatsapp2doTitular.Text & "','" & txtNota2doTitular.Text & "')")


            btnBorrar.Enabled = True

            btnGuardar.Text = "Editar"

        Else
            If btnGuardar.Text = "Editar" Then
                ModificarCuenta()
            End If
        End If

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If frmsListaCuentaAhorro() = True Then
            BuscarAhorro(Id)
            Buscar2doTitular(Id)
            btnGuardar.Text = "Editar"
        End If
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If FRMS_CLAVE_MAESTRA("Acceso") = True Then
            If Alerta("¿Está seguro que desea Cancelar esta cuenta?") = False Then Return
            NON_QUERY("UPDATE tbl_ahorros_cuentas SET Estado='Cancelada' WHERE ID=" & CInt(txtIDAhorro.Text) & "")
            Nuevo()
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub ModificarCuenta()

        NON_QUERY("UPDATE tlb_segundo_titular_cta_ahorros SET fldNombre2doTitular='" & txtNombre2doTitular.Text & "', fldCedula2doTitular='" & txtCedula2doTitular.Text & "', fldTelefono2doTitular='" & txtTel2doTitular.Text & "', fldCelular2doTitular='" & txtCel2doTitular.Text & "', fldWhatsapp2doTitular='" & txtWhatsapp2doTitular.Text & "', fldNotas2doTitular='" & txtNota2doTitular.Text & "'  WHERE fldIdAhorro=" & CInt(txtIDAhorro.Text) & "")

        Alerta("Datos modificados")

    End Sub


    Private Sub btnModificaNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificaNota.Click

        NON_QUERY("UPDATE tbl_ahorros_cuentas SET Nota='" & txtNotas.Text & "' WHERE ID=" & CInt(txtIDAhorro.Text) & "")
        Alerta("Nota modificada")

    End Sub

    Private Sub txtTasaInteres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmCuentaAhorros_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cargar_Tasa_Ctas()
    End Sub

    Private Sub cmbCategoria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Cargar_Tasa_Ctas()
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class
