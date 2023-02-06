Imports MySql.Data.MySqlClient
Public Class frmSolicitudCredito
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
    Friend WithEvents lblTasaIntere As System.Windows.Forms.Label
    Friend WithEvents fld_tipo_prestamo As System.Windows.Forms.ComboBox
    Friend WithEvents fld_porciento As System.Windows.Forms.TextBox
    Friend WithEvents fld_monto_prestamo As System.Windows.Forms.TextBox
    Friend WithEvents fld_clasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents fld_fecha_entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents fld_cod_prestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fld_cantidad_cuotas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMontoCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents fldTazaMora As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNotaGeneral As System.Windows.Forms.TextBox
    Friend WithEvents btn_nuevo_cliente As System.Windows.Forms.Button
    Friend WithEvents fld_phone2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents fld_phone As System.Windows.Forms.TextBox
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnListaPrestamos As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAccion As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MontoSolicitadoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SeguroTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GastoLegalTxt As System.Windows.Forms.TextBox
    Friend WithEvents comentarioBtn As System.Windows.Forms.Button
    Friend WithEvents socioExistenteBtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSolicitudCredito))
        Me.lblTasaIntere = New System.Windows.Forms.Label
        Me.fld_tipo_prestamo = New System.Windows.Forms.ComboBox
        Me.fld_porciento = New System.Windows.Forms.TextBox
        Me.fld_monto_prestamo = New System.Windows.Forms.TextBox
        Me.fld_clasificacion = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.fld_fecha_entrega = New System.Windows.Forms.DateTimePicker
        Me.fld_cod_prestamo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.fld_cantidad_cuotas = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMontoCuota = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.fldTazaMora = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtNotaGeneral = New System.Windows.Forms.TextBox
        Me.btn_nuevo_cliente = New System.Windows.Forms.Button
        Me.fld_phone2 = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtCedula = New System.Windows.Forms.TextBox
        Me.lblCedula = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.fld_phone = New System.Windows.Forms.TextBox
        Me.lblApellidos = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.btnListaPrestamos = New System.Windows.Forms.Button
        Me.btnBorrar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnImprime = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnAccion = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.MontoSolicitadoTxt = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.SeguroTxt = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GastoLegalTxt = New System.Windows.Forms.TextBox
        Me.comentarioBtn = New System.Windows.Forms.Button
        Me.socioExistenteBtn = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblTasaIntere
        '
        Me.lblTasaIntere.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTasaIntere.Location = New System.Drawing.Point(320, 288)
        Me.lblTasaIntere.Name = "lblTasaIntere"
        Me.lblTasaIntere.Size = New System.Drawing.Size(120, 16)
        Me.lblTasaIntere.TabIndex = 37
        Me.lblTasaIntere.Text = "Tasa de Interes"
        Me.lblTasaIntere.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_tipo_prestamo
        '
        Me.fld_tipo_prestamo.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.fld_tipo_prestamo.ForeColor = System.Drawing.Color.White
        Me.fld_tipo_prestamo.Items.AddRange(New Object() {"DIARIO", "SEMANAL", "QUINCENAL", "MENSUAL", "BIMESTRAL", "TRIMESTRAL", "SEMESTRAL", "ANUAL"})
        Me.fld_tipo_prestamo.Location = New System.Drawing.Point(136, 208)
        Me.fld_tipo_prestamo.Name = "fld_tipo_prestamo"
        Me.fld_tipo_prestamo.Size = New System.Drawing.Size(176, 21)
        Me.fld_tipo_prestamo.TabIndex = 3
        Me.fld_tipo_prestamo.Text = "MENSUAL"
        '
        'fld_porciento
        '
        Me.fld_porciento.BackColor = System.Drawing.Color.White
        Me.fld_porciento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_porciento.Location = New System.Drawing.Point(448, 288)
        Me.fld_porciento.Name = "fld_porciento"
        Me.fld_porciento.Size = New System.Drawing.Size(192, 20)
        Me.fld_porciento.TabIndex = 10
        Me.fld_porciento.Text = "0"
        Me.fld_porciento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_monto_prestamo
        '
        Me.fld_monto_prestamo.BackColor = System.Drawing.Color.White
        Me.fld_monto_prestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_monto_prestamo.Location = New System.Drawing.Point(448, 312)
        Me.fld_monto_prestamo.Name = "fld_monto_prestamo"
        Me.fld_monto_prestamo.ReadOnly = True
        Me.fld_monto_prestamo.Size = New System.Drawing.Size(192, 20)
        Me.fld_monto_prestamo.TabIndex = 11
        Me.fld_monto_prestamo.Text = "0.00"
        Me.fld_monto_prestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_clasificacion
        '
        Me.fld_clasificacion.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.fld_clasificacion.ForeColor = System.Drawing.Color.White
        Me.fld_clasificacion.Items.AddRange(New Object() {"Int. y Capital Amorizable", "Int. y Capital Fijos", "Int. Diario Sobre Saldo Insoluto", "Int. Diario Sobre Capital Inicial"})
        Me.fld_clasificacion.Location = New System.Drawing.Point(136, 184)
        Me.fld_clasificacion.Name = "fld_clasificacion"
        Me.fld_clasificacion.Size = New System.Drawing.Size(176, 21)
        Me.fld_clasificacion.TabIndex = 2
        Me.fld_clasificacion.Text = "Int. y Capital Fijos"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(8, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Condición de pago"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(8, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Composición de Cuota"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(320, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Monto Préstamo RD$"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_fecha_entrega
        '
        Me.fld_fecha_entrega.CustomFormat = "dd / MMM /yyyy"
        Me.fld_fecha_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha_entrega.Location = New System.Drawing.Point(136, 232)
        Me.fld_fecha_entrega.Name = "fld_fecha_entrega"
        Me.fld_fecha_entrega.Size = New System.Drawing.Size(176, 20)
        Me.fld_fecha_entrega.TabIndex = 4
        '
        'fld_cod_prestamo
        '
        Me.fld_cod_prestamo.BackColor = System.Drawing.Color.White
        Me.fld_cod_prestamo.Location = New System.Drawing.Point(136, 160)
        Me.fld_cod_prestamo.Name = "fld_cod_prestamo"
        Me.fld_cod_prestamo.Size = New System.Drawing.Size(176, 20)
        Me.fld_cod_prestamo.TabIndex = 1
        Me.fld_cod_prestamo.Text = "0"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(8, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Código "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_cantidad_cuotas
        '
        Me.fld_cantidad_cuotas.BackColor = System.Drawing.Color.White
        Me.fld_cantidad_cuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_cantidad_cuotas.Location = New System.Drawing.Point(448, 336)
        Me.fld_cantidad_cuotas.Name = "fld_cantidad_cuotas"
        Me.fld_cantidad_cuotas.Size = New System.Drawing.Size(192, 20)
        Me.fld_cantidad_cuotas.TabIndex = 12
        Me.fld_cantidad_cuotas.Text = "0"
        Me.fld_cantidad_cuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(8, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Fecha de Inicio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(320, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Cantidad Cuotas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoCuota
        '
        Me.txtMontoCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCuota.Location = New System.Drawing.Point(448, 360)
        Me.txtMontoCuota.Name = "txtMontoCuota"
        Me.txtMontoCuota.Size = New System.Drawing.Size(192, 20)
        Me.txtMontoCuota.TabIndex = 13
        Me.txtMontoCuota.Text = "0.00"
        Me.txtMontoCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(320, 360)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 16)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "Monto Cuota RD$"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fldTazaMora
        '
        Me.fldTazaMora.BackColor = System.Drawing.Color.White
        Me.fldTazaMora.Location = New System.Drawing.Point(136, 256)
        Me.fldTazaMora.Name = "fldTazaMora"
        Me.fldTazaMora.Size = New System.Drawing.Size(88, 20)
        Me.fldTazaMora.TabIndex = 5
        Me.fldTazaMora.Text = "0"
        Me.fldTazaMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.fldTazaMora.Visible = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(8, 256)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 16)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "% Mora Mensual"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 8)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'txtNotaGeneral
        '
        Me.txtNotaGeneral.Location = New System.Drawing.Point(136, 288)
        Me.txtNotaGeneral.MaxLength = 1024
        Me.txtNotaGeneral.Multiline = True
        Me.txtNotaGeneral.Name = "txtNotaGeneral"
        Me.txtNotaGeneral.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtNotaGeneral.Size = New System.Drawing.Size(176, 160)
        Me.txtNotaGeneral.TabIndex = 6
        Me.txtNotaGeneral.Text = ""
        '
        'btn_nuevo_cliente
        '
        Me.btn_nuevo_cliente.BackColor = System.Drawing.SystemColors.Control
        Me.btn_nuevo_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btn_nuevo_cliente.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo_cliente.Location = New System.Drawing.Point(440, 88)
        Me.btn_nuevo_cliente.Name = "btn_nuevo_cliente"
        Me.btn_nuevo_cliente.Size = New System.Drawing.Size(96, 24)
        Me.btn_nuevo_cliente.TabIndex = 46
        Me.btn_nuevo_cliente.Text = "Nu&evo Socio"
        '
        'fld_phone2
        '
        Me.fld_phone2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.fld_phone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_phone2.Location = New System.Drawing.Point(296, 88)
        Me.fld_phone2.Name = "fld_phone2"
        Me.fld_phone2.ReadOnly = True
        Me.fld_phone2.Size = New System.Drawing.Size(144, 20)
        Me.fld_phone2.TabIndex = 44
        Me.fld_phone2.Text = ""
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(200, 40)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(240, 20)
        Me.txtNombre.TabIndex = 41
        Me.txtNombre.Text = ""
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Location = New System.Drawing.Point(440, 64)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(96, 22)
        Me.btnBuscar.TabIndex = 45
        Me.btnBuscar.Text = "B&uscar Nuevo"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.White
        Me.txtId.Location = New System.Drawing.Point(136, 40)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(56, 20)
        Me.txtId.TabIndex = 0
        Me.txtId.Text = "0"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Location = New System.Drawing.Point(136, 64)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(304, 20)
        Me.txtCedula.TabIndex = 42
        Me.txtCedula.Text = ""
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCedula.Location = New System.Drawing.Point(8, 64)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(120, 16)
        Me.lblCedula.TabIndex = 23
        Me.lblCedula.Text = "Cédula"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(8, 40)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(120, 16)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_phone
        '
        Me.fld_phone.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(251, Byte), CType(145, Byte))
        Me.fld_phone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_phone.Location = New System.Drawing.Point(136, 88)
        Me.fld_phone.Name = "fld_phone"
        Me.fld_phone.ReadOnly = True
        Me.fld_phone.Size = New System.Drawing.Size(144, 20)
        Me.fld_phone.TabIndex = 43
        Me.fld_phone.Text = ""
        '
        'lblApellidos
        '
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblApellidos.Location = New System.Drawing.Point(8, 88)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(120, 16)
        Me.lblApellidos.TabIndex = 24
        Me.lblApellidos.Text = "Telefonos"
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.Location = New System.Drawing.Point(8, 288)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(120, 16)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "Nota General"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnListaPrestamos
        '
        Me.btnListaPrestamos.BackColor = System.Drawing.SystemColors.Control
        Me.btnListaPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnListaPrestamos.ForeColor = System.Drawing.Color.Black
        Me.btnListaPrestamos.Image = CType(resources.GetObject("btnListaPrestamos.Image"), System.Drawing.Image)
        Me.btnListaPrestamos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnListaPrestamos.Location = New System.Drawing.Point(656, 72)
        Me.btnListaPrestamos.Name = "btnListaPrestamos"
        Me.btnListaPrestamos.Size = New System.Drawing.Size(144, 56)
        Me.btnListaPrestamos.TabIndex = 16
        Me.btnListaPrestamos.Text = "&Consulta Nueva"
        Me.btnListaPrestamos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(656, 360)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(72, 56)
        Me.btnBorrar.TabIndex = 19
        Me.btnBorrar.Text = "&Rechazar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(728, 360)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 20
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.SystemColors.Control
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnProcesar.ForeColor = System.Drawing.Color.Black
        Me.btnProcesar.Image = CType(resources.GetObject("btnProcesar.Image"), System.Drawing.Image)
        Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProcesar.Location = New System.Drawing.Point(728, 16)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(72, 56)
        Me.btnProcesar.TabIndex = 15
        Me.btnProcesar.Text = "&Guardar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(656, 16)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "&Nueva"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprime.Enabled = False
        Me.btnImprime.ForeColor = System.Drawing.Color.Black
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprime.Location = New System.Drawing.Point(656, 192)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(144, 56)
        Me.btnImprime.TabIndex = 17
        Me.btnImprime.Text = "&Imprimir"
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "DATOS DEL SOCIO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(8, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "DATOS DE LA SOLICITUD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(8, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 8)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'btnAccion
        '
        Me.btnAccion.BackColor = System.Drawing.SystemColors.Control
        Me.btnAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnAccion.ForeColor = System.Drawing.Color.Black
        Me.btnAccion.Image = CType(resources.GetObject("btnAccion.Image"), System.Drawing.Image)
        Me.btnAccion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAccion.Location = New System.Drawing.Point(656, 248)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(144, 56)
        Me.btnAccion.TabIndex = 18
        Me.btnAccion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAccion.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(320, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Monto solicitado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MontoSolicitadoTxt
        '
        Me.MontoSolicitadoTxt.BackColor = System.Drawing.Color.White
        Me.MontoSolicitadoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoSolicitadoTxt.Location = New System.Drawing.Point(448, 160)
        Me.MontoSolicitadoTxt.Name = "MontoSolicitadoTxt"
        Me.MontoSolicitadoTxt.Size = New System.Drawing.Size(192, 20)
        Me.MontoSolicitadoTxt.TabIndex = 7
        Me.MontoSolicitadoTxt.Text = "0"
        Me.MontoSolicitadoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(320, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Monto Seguro"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SeguroTxt
        '
        Me.SeguroTxt.BackColor = System.Drawing.Color.White
        Me.SeguroTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeguroTxt.Location = New System.Drawing.Point(448, 184)
        Me.SeguroTxt.Name = "SeguroTxt"
        Me.SeguroTxt.Size = New System.Drawing.Size(192, 20)
        Me.SeguroTxt.TabIndex = 8
        Me.SeguroTxt.Text = "0"
        Me.SeguroTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(320, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Gastos Legales"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GastoLegalTxt
        '
        Me.GastoLegalTxt.BackColor = System.Drawing.Color.White
        Me.GastoLegalTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GastoLegalTxt.Location = New System.Drawing.Point(448, 208)
        Me.GastoLegalTxt.Name = "GastoLegalTxt"
        Me.GastoLegalTxt.Size = New System.Drawing.Size(192, 20)
        Me.GastoLegalTxt.TabIndex = 9
        Me.GastoLegalTxt.Text = "0"
        Me.GastoLegalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'comentarioBtn
        '
        Me.comentarioBtn.BackColor = System.Drawing.SystemColors.Control
        Me.comentarioBtn.Enabled = False
        Me.comentarioBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.comentarioBtn.ForeColor = System.Drawing.Color.Black
        Me.comentarioBtn.Image = CType(resources.GetObject("comentarioBtn.Image"), System.Drawing.Image)
        Me.comentarioBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.comentarioBtn.Location = New System.Drawing.Point(656, 304)
        Me.comentarioBtn.Name = "comentarioBtn"
        Me.comentarioBtn.Size = New System.Drawing.Size(144, 56)
        Me.comentarioBtn.TabIndex = 47
        Me.comentarioBtn.Text = "Comentarios"
        Me.comentarioBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'socioExistenteBtn
        '
        Me.socioExistenteBtn.BackColor = System.Drawing.SystemColors.Control
        Me.socioExistenteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.socioExistenteBtn.ForeColor = System.Drawing.Color.Black
        Me.socioExistenteBtn.Location = New System.Drawing.Point(440, 40)
        Me.socioExistenteBtn.Name = "socioExistenteBtn"
        Me.socioExistenteBtn.Size = New System.Drawing.Size(96, 22)
        Me.socioExistenteBtn.TabIndex = 48
        Me.socioExistenteBtn.Text = "Buscar Existente"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(656, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 56)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "&Consulta Aprobada"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmSolicitudCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(808, 452)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.socioExistenteBtn)
        Me.Controls.Add(Me.comentarioBtn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GastoLegalTxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.SeguroTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MontoSolicitadoTxt)
        Me.Controls.Add(Me.btnAccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnListaPrestamos)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnImprime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTasaIntere)
        Me.Controls.Add(Me.fld_tipo_prestamo)
        Me.Controls.Add(Me.fld_porciento)
        Me.Controls.Add(Me.fld_monto_prestamo)
        Me.Controls.Add(Me.fld_clasificacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.fld_fecha_entrega)
        Me.Controls.Add(Me.fld_cod_prestamo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fld_cantidad_cuotas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMontoCuota)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.fldTazaMora)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtNotaGeneral)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.btn_nuevo_cliente)
        Me.Controls.Add(Me.fld_phone2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.fld_phone)
        Me.Controls.Add(Me.lblApellidos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSolicitudCredito"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Crédito"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim SocioNuevo As Boolean = True

    Private Sub frmSolicitudCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        fld_porciento.Text = SCALAR_NUM("SELECT TasaInteres FROM parametrosgenerales WHERE ID=1")

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim F As New frmSolicitudCreditoClienteList
        F.Text = "Lista de Clientes Todos"
        F.ShowDialog()
        If F.Text = "ACEPTAR" Then

            buscarSocio(Id, True)
        End If
        F.Dispose()

    End Sub

    Private Function CrearSocio() As Integer


        NON_QUERY("INSERT INTO tbl_clientes ( TipoDocumento, fld_FullName, fld_apodo, fld_Identity, fld_Phone, fld_Phone2, fld_Address, fld_City_id, fld_City, fld_Status, fld_bce, fld_cod_zona, fld_zona,fld_nombre_con, fld_apodo_con, fld_cedula_con, fld_telefono_con, fld_celular_con, fld_ref_personales_cliente, fld_ref_comerciales_cliente, fld_nombre_gar, fld_apodo_gar, fld_cedula_gar, fld_telefono_gar, fld_celular_gar, fld_direccion_gar, fld_ciudad_gar, fld_ref_personales_gar, fld_ref_comerciales_gar, fld_ingresos_mesuales, fld_nombre_banco1, fld_cuenta_banco1, fld_nombre_banco2,fld_cuenta_banco2, fld_otra_informacion, fld_nombre_con_gar, fld_apodo_con_gar, fld_cedula_con_gar, fld_telefono_con_gar, fld_celular_con_gar, fld_edad, fld_estado_civil, fld_edad_gar, fld_estado_civil_gar, fld_ocupacion_cliente, fld_ocupacion_gar, fld_sector_id, fld_sector, fld_categoria, fld_limite, Puesto, TimpoTrabajo, ReferidoPor, Oriundo, DataCredito, ctaContable, email, fechaIngreso) (SELECT TipoDocumento, fld_FullName, fld_apodo, fld_Identity, fld_Phone, fld_Phone2, fld_Address, fld_City_id, fld_City, fld_Status, fld_bce, fld_cod_zona, fld_zona, fld_nombre_con, fld_apodo_con, fld_cedula_con, fld_telefono_con, fld_celular_con, fld_ref_personales_cliente, fld_ref_comerciales_cliente, fld_nombre_gar, fld_apodo_gar, fld_cedula_gar, fld_telefono_gar, fld_celular_gar, fld_direccion_gar, fld_ciudad_gar, fld_ref_personales_gar, fld_ref_comerciales_gar, fld_ingresos_mesuales, fld_nombre_banco1, fld_cuenta_banco1, fld_nombre_banco2, fld_cuenta_banco2, fld_otra_informacion, fld_nombre_con_gar,fld_apodo_con_gar, fld_cedula_con_gar, fld_telefono_con_gar, fld_celular_con_gar, fld_edad, fld_estado_civil, fld_edad_gar, fld_estado_civil_gar,fld_ocupacion_cliente, fld_ocupacion_gar, fld_sector_id, fld_sector, fld_categoria, fld_limite, Puesto, TimpoTrabajo, ReferidoPor, Oriundo, DataCredito, ctaContable, email, fechaIngreso FROM solicitudcreditocliente WHERE fld_id=" & CInt(txtId.Text) & ")")

        Return UltimoID("tbl_clientes", "fld_id")
    End Function

    Private Sub buscarSocio(ByVal idSocio As Integer, ByVal socioesNuevo As Boolean)
        Dim ds As New DataSet
        Dim Sql As String = "SELECT * FROM SolicitudCreditoCliente WHERE fld_id=" & idSocio & ""
        If socioesNuevo = False Then
            Sql = "SELECT * FROM tbl_clientes WHERE fld_id=" & idSocio & ""
        End If

        Dim da As New MySqlDataAdapter(Sql, conn)
        da.Fill(ds)

        Dim nr As DataRow

        For Each nr In ds.Tables(0).Rows

            txtId.Text = idSocio
            txtNombre.Text = nr("fld_FullName")
            fld_phone.Text = nr("fld_phone")
            fld_phone2.Text = nr("fld_phone2")
            txtCedula.Text = nr("fld_Identity")
            SocioNuevo = socioesNuevo

            GoTo sigue
        Next
        Alerta("No se encontró el documento solicitado")
        txtId.Focus()
        da.Dispose()
        ds.Dispose()
        Exit Sub
sigue:
        fld_fecha_entrega.Focus()
        da.Dispose()
        ds.Dispose()
    End Sub

    Private Sub buscarSolicitud(ByVal IdDoc As Integer)
        Dim isdata As Boolean = False
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM solicitudcredito WHERE Id=" & IdDoc & "", conn)
        da.Fill(ds, "solicitudcredito")

        Dim nr As DataRow
        For Each nr In ds.Tables(0).Rows
            fld_cod_prestamo.Text = IdDoc
            fld_fecha_entrega.Value = nr("FechaInicio")
            fld_monto_prestamo.Text = Format(nr("Monto"), "N2")
            txtMontoCuota.Text = Format(nr("MontoCuotas"), "N2")
            fld_cantidad_cuotas.Text = nr("CantCuotas")
            fld_clasificacion.Text = nr("Clasificacion")
            fld_tipo_prestamo.Text = nr("Condicion")
            fld_porciento.Text = nr("Interes")
            'fldTazaMora.Text = nr("fldTazaMora")
            txtNotaGeneral.Text = nr("Notas")
            MontoSolicitadoTxt.Text = Format(nr("MontoSolicitado"), "N2")
            GastoLegalTxt.Text = Format(nr("MontoLegal"), "N2")
            SeguroTxt.Text = Format(nr("Seguro"), "N2")

            If nr("SocioNuevo") > 0 Then
                buscarSocio(nr("Socio"), True)
            Else
                buscarSocio(nr("Socio"), False)
            End If
            btnAccion.Visible = True

            btnImprime.Enabled = True
            btnProcesar.Enabled = False
            comentarioBtn.Enabled = True
            btnBorrar.Enabled = True
            comentarioBtn.Enabled = True

            If nr("Estado") = "Nueva" Then
                btnAccion.Text = "Aprobar"

            ElseIf nr("Estado") = "Aprobada" Then

                btnAccion.Text = "Procesar"
                btnBorrar.Enabled = False
                comentarioBtn.Enabled = False
                btnImprime.Enabled = False
            Else
                btnAccion.Visible = False
            End If





            GoTo sigue
        Next


        Alerta("No se encontró el documento solicitado")
        fld_cod_prestamo.Text = "0"
        fld_cod_prestamo.Focus()

sigue:

        da.Dispose()
        ds.Dispose()
    End Sub

    Private Sub calculoCuota()
        Dim interes_cuota As Double = Redondear((CDec(fld_monto_prestamo.Text) * CDec(fld_porciento.Text)) / 100, 2)
        Dim capital As Double = Redondear(CDec(fld_monto_prestamo.Text) / CDec(fld_cantidad_cuotas.Text), 2)


        If fld_clasificacion.Text = "Int. Adelantado" Then
            txtMontoCuota.Text = Format(interes_cuota, "C2")
        ElseIf fld_clasificacion.Text = "Int. y Capital Amorizable" Then
            Dim Interes = CDec(fld_porciento.Text)
            Dim totalCuotas = CDec(fld_cantidad_cuotas.Text)
            Dim montoPrestamo = CDec(fld_monto_prestamo.Text)
            If Interes > 0 Then Interes = Interes / 100
            txtMontoCuota.Text = Format(Pmt(Interes, totalCuotas, -montoPrestamo, 0, DueDate.EndOfPeriod), "C2")
        ElseIf fld_clasificacion.Text = "Int. y Capital Fijos" Then
            txtMontoCuota.Text = Format(interes_cuota + capital, "C2")
        Else
            txtMontoCuota.Text = Format(capital, "C2")
        End If


    End Sub

    Private Function validarDatos() As Boolean

        If Trim(fld_porciento.Text) = "" Then fld_porciento.Text = "0.00"

        If fldTazaMora.Text = String.Empty Then fldTazaMora.Text = 0

        If MontoSolicitadoTxt.Text = String.Empty Then MontoSolicitadoTxt.Text = 0

        If SeguroTxt.Text = String.Empty Then SeguroTxt.Text = 0

        If GastoLegalTxt.Text = String.Empty Then GastoLegalTxt.Text = 0


        If txtNombre.Text = "" Then
            Alerta("Debe cargar los datos del cliente")
            Return False
        ElseIf CDec(Trim(fld_monto_prestamo.Text)) = 0 Then
            fld_monto_prestamo.Focus()
            Alerta("Introduzca el monto del préstamo")
            Return False
        ElseIf CDbl(Trim(fld_cantidad_cuotas.Text)) = 0 Then
            fld_cantidad_cuotas.Focus()
            Alerta("Introduzca la cantidad de cuotas")
            Return False
        ElseIf CDbl(Trim(MontoSolicitadoTxt.Text)) = 0 Then
            MontoSolicitadoTxt.Focus()
            Alerta("Introduzca el monto de la solicitud")
            Return False
        ElseIf CDbl(Trim(SeguroTxt.Text)) = 0 Then
            SeguroTxt.Focus()
            Alerta("Introduzca el monto del seguro")
            Return False
        ElseIf CDbl(Trim(GastoLegalTxt.Text)) = 0 Then
            GastoLegalTxt.Focus()
            Alerta("Introduzca el monto de gasto legal")
            Return False
        End If

        Return True

    End Function

    Private Sub guardarDoc()

        If validarDatos() = False Then Exit Sub
        calculoCuota()

        If CDec(Trim(fld_cantidad_cuotas.Text)) > 0 Then
            'HACER LOS CALCULOS Y GENERAL EL PRESTAMO SI EL USUARIO ACEPTA
            If Alerta("Verifique que los datos esten correcto..." & Chr(13) & "¿Desea continuar?") = True Then
                If SocioNuevo = True Then

                    NON_QUERY("INSERT INTO solicitudcredito (FechaCreada, FechaAprobacion, CreadoPor, AprobadoPOr,Condicion, Clasificacion, FechaInicio, Monto, Interes, CantCuotas, MontoCuotas, Notas, Socio, SocioNuevo, MontoSolicitado, Seguro, Montolegal) VALUES(Now(),Now()," & User(5) & ",0,'" & fld_tipo_prestamo.Text & "','" & fld_clasificacion.Text & "','" & formatDate(fld_fecha_entrega.Value.Date) & "'," & CDec(fld_monto_prestamo.Text) & "," & CDec(fld_porciento.Text) & "," & CInt(fld_cantidad_cuotas.Text) & "," & CDec(txtMontoCuota.Text) & ",'" & txtNotaGeneral.Text & "'," & CInt(txtId.Text) & ",1," & CDec(MontoSolicitadoTxt.Text) & ", " & CDec(SeguroTxt.Text) & ", " & CDec(GastoLegalTxt.Text) & ")")

                Else

                    NON_QUERY("INSERT INTO solicitudcredito (FechaCreada, FechaAprobacion, CreadoPor, AprobadoPOr,Condicion, Clasificacion, FechaInicio, Monto, Interes, CantCuotas, MontoCuotas, Notas, Socio, SocioNuevo, MontoSolicitado, Seguro, Montolegal) VALUES(Now(),Now()," & User(5) & ",0,'" & fld_tipo_prestamo.Text & "','" & fld_clasificacion.Text & "','" & formatDate(fld_fecha_entrega.Value.Date) & "'," & CDec(fld_monto_prestamo.Text) & "," & CDec(fld_porciento.Text) & "," & CInt(fld_cantidad_cuotas.Text) & "," & CDec(txtMontoCuota.Text) & ",'" & txtNotaGeneral.Text & "'," & CInt(txtId.Text) & ",0," & CDec(MontoSolicitadoTxt.Text) & ", " & CDec(SeguroTxt.Text) & ", " & CDec(GastoLegalTxt.Text) & ")")

                End If

            End If

            fld_cod_prestamo.Text = UltimoID("solicitudcredito", "Id")
            fld_cod_prestamo.Enabled = False
            txtId.Enabled = False
            btnImprime.Enabled = True
            btnProcesar.Enabled = False
            btnBorrar.Enabled = True
            comentarioBtn.Enabled = True
            Alerta("Documento guardado")
        End If

    End Sub

    Private Sub modificarDoc(ByVal idDoc As Integer, ByVal User As String)

        If validarDatos() = False Then Exit Sub
        calculoCuota()

        If CDec(Trim(fld_cantidad_cuotas.Text)) > 0 Then
            'HACER LOS CALCULOS Y GENERAL EL PRESTAMO SI EL USUARIO ACEPTA
            If Alerta("Verifique que los datos esten correcto..." & Chr(13) & "¿Desea continuar?") = True Then
                Dim idUser = SCALAR_NUM("SELECT fld_id FROM tbl_user WHERE fld_UserID='" & User & "'")


                NON_QUERY("UPDATE solicitudcredito SET Condicion='" & fld_tipo_prestamo.Text & "', Clasificacion='" & fld_clasificacion.Text & "', FechaInicio='" & formatDate(fld_fecha_entrega.Value.Date) & "', Monto=" & CDec(fld_monto_prestamo.Text) & ", Interes=" & CDec(fld_porciento.Text) & ", CantCuotas=" & CInt(fld_cantidad_cuotas.Text) & ", MontoCuotas=" & CDec(txtMontoCuota.Text) & ", Notas='" & txtNotaGeneral.Text & "', MontoSolicitado=" & CDec(MontoSolicitadoTxt.Text) & ", Seguro=" & CDec(SeguroTxt.Text) & ", Montolegal=" & CDec(GastoLegalTxt.Text) & ", AprobadoPor=" & idUser & ", Estado='Aprobada', FechaAprobacion=Now() WHERE Id=" & idDoc & "")

                Alerta("Documento guardado y Aprobado")
            End If
        End If
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        guardarDoc()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        txtMontoCuota.Text = "0.00"
        txtId.Text = "0"
        txtNombre.Text = ""
        fld_phone.Text = ""
        fld_phone2.Text = ""
        txtCedula.Text = ""
        txtNotaGeneral.Text = ""
        GastoLegalTxt.Text = "0.00"
        SeguroTxt.Text = "0.00"
        MontoSolicitadoTxt.Text = "0.00"
        fld_monto_prestamo.Text = "0.00"
        fld_cantidad_cuotas.Text = "0"
        fld_cod_prestamo.Enabled = True
        btnProcesar.Enabled = True
        btnBorrar.Enabled = False
        btnImprime.Enabled = False
        fld_cod_prestamo.Text = 0
        txtId.Focus()
        comentarioBtn.Enabled = False
        txtId.Enabled = True
        SocioNuevo = True
        fld_porciento.Text = SCALAR_NUM("SELECT TasaInteres FROM parametrosgenerales WHERE ID=1")

    End Sub

    Private Sub btn_nuevo_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo_cliente.Click
        Dim f As New frmSolicitudCreditoCliente
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub fld_porciento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_porciento.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_monto_prestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_monto_prestamo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_cantidad_cuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_cantidad_cuotas.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMontoCuota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoCuota.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fldTazaMora_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fldTazaMora.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_fecha_entrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_fecha_entrega.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' If docientoTxt.Text = String.Empty Then docientoTxt.Text = "0.00"
            'resDocientoTxt.Text = Format(CInt(docientoTxt.Text) * 200, "N2")
            MontoSolicitadoTxt.Focus()

        End If
    End Sub

    Private Sub fldTazaMora_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fldTazaMora.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' If docientoTxt.Text = String.Empty Then docientoTxt.Text = "0.00"
            'resDocientoTxt.Text = Format(CInt(docientoTxt.Text) * 200, "N2")
            fld_porciento.Focus()

        End If
    End Sub

    Private Sub fld_porciento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_porciento.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' If docientoTxt.Text = String.Empty Then docientoTxt.Text = "0.00"
            'resDocientoTxt.Text = Format(CInt(docientoTxt.Text) * 200, "N2")
            fld_monto_prestamo.Focus()

        End If
    End Sub

    Private Sub fld_monto_prestamo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_monto_prestamo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If fld_monto_prestamo.Text = String.Empty Then fld_monto_prestamo.Text = "0.00"

            Dim amount As Decimal = CType(fld_monto_prestamo.Text, Decimal)
            Me.fld_monto_prestamo.Text = String.Format("{0:n2}", amount)

            fld_cantidad_cuotas.Focus()

        End If


    End Sub

    Private Sub fld_cantidad_cuotas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_cantidad_cuotas.KeyDown
        If e.KeyCode = Keys.Enter Then
            If validarDatos() = False Then Exit Sub
            calculoCuota()

            btnProcesar.Focus()
        End If
    End Sub

    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime.Click
        ReportName = "SOLICITUD DE CREDITO"
        Dim rep As New FRM_REPORTS
        rep.idDoc = CInt(fld_cod_prestamo.Text)
        rep.idSocio = CInt(txtId.Text)

        rep.Show()
    End Sub

    Private Sub btnListaPrestamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaPrestamos.Click
        Dim f As New frmSolicitudCreditoLista
        f.Text = "Solicitud nueva"
        If MessageBox.Show("El socio es nuevo?", "Socio", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
            f.socioNuevo = False

        End If

        f.ShowDialog()
        If f.Text = "ACEPTAR" Then
            buscarSolicitud(Id)
        End If

        f.Dispose()
    End Sub
    Private Sub btnAccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccion.Click
        If btnAccion.Text = "Aprobar" Then
            Dim f As New frmAutorizacion
            f.ShowDialog()
            If f.Text = "ACEPTAR" Then
                If SocioNuevo = True Then  'Si el socio es nuevo, lo crea
                    NON_QUERY("UPDATE SolicitudCreditoCliente SET fld_status='P' WHERE fld_id=" & CInt(txtId.Text) & "")

                    Dim IdSocio = CrearSocio()

                    NON_QUERY("UPDATE solicitudcredito SET Socio=" & IdSocio & ", SocioNuevo=0 WHERE Id=" & CInt(fld_cod_prestamo.Text) & "")

                Else

                    NON_QUERY("UPDATE solicitudcredito SET Socio=" & CInt(txtId.Text) & " WHERE Id=" & CInt(fld_cod_prestamo.Text) & "")

                End If

                btnAccion.Text = "Procesar"
                modificarDoc(CInt(fld_cod_prestamo.Text), f.txtUserID.Text)
                btnNuevo_Click(sender, e)
            End If
        ElseIf btnAccion.Text = "Procesar" Then
            If Alerta("Seguro que desea procesar la solicitud?") = False Then Exit Sub
            Dim f As New FRM_PRESTAMO_MAESTRO
            f.IdSolicitudTxt.Text = fld_cod_prestamo.Text
            f.txtId.Text = txtId.Text
            f.ShowDialog()
            If f.Text = "ACEPTAR" Then
                NON_QUERY("UPDATE solicitudcredito SET Estado='Procesada' WHERE Id=" & CInt(fld_cod_prestamo.Text) & "")

                btnNuevo_Click(sender, e)
                Me.Close()
            End If
            F.Dispose()
        End If
    End Sub

    Private Sub MontoSolicitadoTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MontoSolicitadoTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If MontoSolicitadoTxt.Text = String.Empty Then MontoSolicitadoTxt.Text = "0.00"

            Dim amount As Decimal = CType(MontoSolicitadoTxt.Text, Decimal)
            Me.MontoSolicitadoTxt.Text = String.Format("{0:n2}", amount)

            SeguroTxt.Focus()

        End If

    End Sub

    Private Sub SeguroTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SeguroTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If SeguroTxt.Text = String.Empty Then SeguroTxt.Text = "0.00"

            Dim amount As Decimal = CType(SeguroTxt.Text, Decimal)
            Me.SeguroTxt.Text = String.Format("{0:n2}", amount)

            GastoLegalTxt.Focus()

        End If

    End Sub

    Private Sub GastoLegalTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GastoLegalTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If GastoLegalTxt.Text = String.Empty Then GastoLegalTxt.Text = "0.00"

            Dim amount As Decimal = CType(GastoLegalTxt.Text, Decimal)
            Me.GastoLegalTxt.Text = String.Format("{0:n2}", amount)

            fld_porciento.Focus()
            fld_monto_prestamo.Text = String.Format("{0:n2}", CDec(MontoSolicitadoTxt.Text) + CDec(GastoLegalTxt.Text) + CDec(SeguroTxt.Text))

        End If

    End Sub

    Private Sub MontoSolicitadoTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MontoSolicitadoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub SeguroTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SeguroTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub GastoLegalTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GastoLegalTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub GastoLegalTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GastoLegalTxt.TextChanged

    End Sub

    Private Sub comentarioBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comentarioBtn.Click
        Dim f As New frmSolicitudCreditoNota
        f.IdSolicitud = CInt(fld_cod_prestamo.Text)
        f.ShowDialog()
        f.Dispose()

    End Sub

    Private Sub socioExistenteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles socioExistenteBtn.Click
        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            buscarSocio(Id, False)

        End If
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If Alerta("Seguro que desea rechazar la solicituD?") = True Then
            Dim f As New frmAutorizacion
            f.ShowDialog()
            If f.Text = "ACEPTAR" Then
                NON_QUERY("UPDATE solicitudcredito SET Estado='Rechazada' WHERE Id=" & CInt(fld_cod_prestamo.Text) & "")
                btnNuevo_Click(sender, e)
            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As New frmSolicitudCreditoLista
        f.Text = "Solicitud Aprobada"
        f.ShowDialog()

        If f.Text = "ACEPTAR" Then
            buscarSolicitud(Id)
        End If

        f.Dispose()
    End Sub

    Private Sub MontoSolicitadoTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MontoSolicitadoTxt.TextChanged

    End Sub
End Class
