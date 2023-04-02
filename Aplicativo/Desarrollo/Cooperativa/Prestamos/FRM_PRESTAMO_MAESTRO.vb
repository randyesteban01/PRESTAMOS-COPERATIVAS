Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Public Class FRM_PRESTAMO_MAESTRO
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents fld_cantidad_cuotas As System.Windows.Forms.TextBox
    Friend WithEvents fld_monto_prestamo As System.Windows.Forms.TextBox
    Friend WithEvents fld_fecha_entrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents fld_cod_prestamo As System.Windows.Forms.TextBox
    Friend WithEvents fld_porciento As System.Windows.Forms.TextBox
    Friend WithEvents btn_nuevo_cliente As System.Windows.Forms.Button
    Friend WithEvents fld_phone2 As System.Windows.Forms.TextBox
    Friend WithEvents fld_phone As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents fld_tipo_prestamo As System.Windows.Forms.ComboBox
    Friend WithEvents fld_clasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdZona As System.Windows.Forms.ComboBox
    Friend WithEvents fldTazaMora As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNotaGeneral As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnModificaNota As System.Windows.Forms.Button
    Friend WithEvents btnListaPrestamos As System.Windows.Forms.Button
    Friend WithEvents txtMontoCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtMontoAdelanto As System.Windows.Forms.TextBox
    Friend WithEvents DG As System.Windows.Forms.DataGrid
    Friend WithEvents txtBalancePrestamo As System.Windows.Forms.TextBox
    Friend WithEvents btnCambiar As System.Windows.Forms.Button
    Friend WithEvents fld_cuota_pagada As System.Windows.Forms.TextBox
    Friend WithEvents gbAgregarCuotas As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCuotasAgregar As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarCuotas As System.Windows.Forms.Button
    Friend WithEvents lblTasaIntere As System.Windows.Forms.Label
    Friend WithEvents IdSolicitudTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SeguroTxt As System.Windows.Forms.TextBox
    Friend WithEvents GastoLegalTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCtaIngresos As Label
    Friend WithEvents cmbTipoPrestamos As ComboBox
    Friend WithEvents lblTipoPrestamo As Label
    Friend WithEvents lblNoCtaIngresos As Label
    Friend WithEvents btnCambiarTipoPrestamo As Button
    Friend WithEvents MontoSolicitadoTxt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_PRESTAMO_MAESTRO))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMontoAdelanto = New System.Windows.Forms.TextBox()
        Me.btnModificaNota = New System.Windows.Forms.Button()
        Me.txtNotaGeneral = New System.Windows.Forms.TextBox()
        Me.btn_nuevo_cliente = New System.Windows.Forms.Button()
        Me.cmdZona = New System.Windows.Forms.ComboBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.fld_phone2 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.fld_phone = New System.Windows.Forms.TextBox()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.fldTazaMora = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCambiarTipoPrestamo = New System.Windows.Forms.Button()
        Me.lblNoCtaIngresos = New System.Windows.Forms.Label()
        Me.lblCtaIngresos = New System.Windows.Forms.Label()
        Me.cmbTipoPrestamos = New System.Windows.Forms.ComboBox()
        Me.lblTipoPrestamo = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MontoSolicitadoTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SeguroTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GastoLegalTxt = New System.Windows.Forms.TextBox()
        Me.gbAgregarCuotas = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCuotasAgregar = New System.Windows.Forms.TextBox()
        Me.btnAgregarCuotas = New System.Windows.Forms.Button()
        Me.DG = New System.Windows.Forms.DataGrid()
        Me.lblTasaIntere = New System.Windows.Forms.Label()
        Me.fld_porciento = New System.Windows.Forms.TextBox()
        Me.fld_monto_prestamo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fld_cantidad_cuotas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMontoCuota = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnListaPrestamos = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnImprime = New System.Windows.Forms.Button()
        Me.txtBalancePrestamo = New System.Windows.Forms.TextBox()
        Me.fld_cuota_pagada = New System.Windows.Forms.TextBox()
        Me.IdSolicitudTxt = New System.Windows.Forms.TextBox()
        Me.fld_tipo_prestamo = New System.Windows.Forms.ComboBox()
        Me.fld_clasificacion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.fld_fecha_entrega = New System.Windows.Forms.DateTimePicker()
        Me.fld_cod_prestamo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbAgregarCuotas.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMontoAdelanto)
        Me.GroupBox1.Controls.Add(Me.btnModificaNota)
        Me.GroupBox1.Controls.Add(Me.txtNotaGeneral)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo_cliente)
        Me.GroupBox1.Controls.Add(Me.cmdZona)
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.fld_phone2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.lblCedula)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.fld_phone)
        Me.GroupBox1.Controls.Add(Me.lblApellidos)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Location = New System.Drawing.Point(3, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(885, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Socio"
        '
        'txtMontoAdelanto
        '
        Me.txtMontoAdelanto.Location = New System.Drawing.Point(400, 57)
        Me.txtMontoAdelanto.Name = "txtMontoAdelanto"
        Me.txtMontoAdelanto.Size = New System.Drawing.Size(40, 20)
        Me.txtMontoAdelanto.TabIndex = 10
        Me.txtMontoAdelanto.Text = "0.00"
        Me.txtMontoAdelanto.Visible = False
        '
        'btnModificaNota
        '
        Me.btnModificaNota.Enabled = False
        Me.btnModificaNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaNota.Location = New System.Drawing.Point(520, 50)
        Me.btnModificaNota.Name = "btnModificaNota"
        Me.btnModificaNota.Size = New System.Drawing.Size(360, 32)
        Me.btnModificaNota.TabIndex = 11
        Me.btnModificaNota.Text = "&Modificar Nota"
        '
        'txtNotaGeneral
        '
        Me.txtNotaGeneral.Location = New System.Drawing.Point(520, 8)
        Me.txtNotaGeneral.MaxLength = 1000
        Me.txtNotaGeneral.Multiline = True
        Me.txtNotaGeneral.Name = "txtNotaGeneral"
        Me.txtNotaGeneral.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtNotaGeneral.Size = New System.Drawing.Size(360, 38)
        Me.txtNotaGeneral.TabIndex = 10
        '
        'btn_nuevo_cliente
        '
        Me.btn_nuevo_cliente.BackColor = System.Drawing.SystemColors.Control
        Me.btn_nuevo_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btn_nuevo_cliente.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo_cliente.Location = New System.Drawing.Point(452, 57)
        Me.btn_nuevo_cliente.Name = "btn_nuevo_cliente"
        Me.btn_nuevo_cliente.Size = New System.Drawing.Size(16, 20)
        Me.btn_nuevo_cliente.TabIndex = 11
        Me.btn_nuevo_cliente.Text = "Nu&evo Cliente"
        Me.btn_nuevo_cliente.UseVisualStyleBackColor = False
        Me.btn_nuevo_cliente.Visible = False
        '
        'cmdZona
        '
        Me.cmdZona.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.cmdZona.ForeColor = System.Drawing.Color.White
        Me.cmdZona.Items.AddRange(New Object() {"N/A"})
        Me.cmdZona.Location = New System.Drawing.Point(656, 65)
        Me.cmdZona.Name = "cmdZona"
        Me.cmdZona.Size = New System.Drawing.Size(200, 21)
        Me.cmdZona.TabIndex = 14
        Me.cmdZona.Text = "N/A"
        Me.cmdZona.Visible = False
        '
        'txtCiudad
        '
        Me.txtCiudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtCiudad.Location = New System.Drawing.Point(664, 56)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.ReadOnly = True
        Me.txtCiudad.Size = New System.Drawing.Size(152, 20)
        Me.txtCiudad.TabIndex = 15
        Me.txtCiudad.Visible = False
        '
        'fld_phone2
        '
        Me.fld_phone2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.fld_phone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_phone2.Location = New System.Drawing.Point(240, 65)
        Me.fld_phone2.Name = "fld_phone2"
        Me.fld_phone2.ReadOnly = True
        Me.fld_phone2.Size = New System.Drawing.Size(144, 20)
        Me.fld_phone2.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(144, 17)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(240, 20)
        Me.txtNombre.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Location = New System.Drawing.Point(384, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(56, 22)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "B&uscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.White
        Me.txtId.Location = New System.Drawing.Point(80, 17)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(56, 20)
        Me.txtId.TabIndex = 1
        Me.txtId.Text = "0"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedula.Location = New System.Drawing.Point(80, 41)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(304, 20)
        Me.txtCedula.TabIndex = 4
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCedula.Location = New System.Drawing.Point(8, 41)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(64, 16)
        Me.lblCedula.TabIndex = 3
        Me.lblCedula.Text = "Cédula"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(8, 17)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(64, 16)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_phone
        '
        Me.fld_phone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.fld_phone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_phone.Location = New System.Drawing.Point(80, 65)
        Me.fld_phone.Name = "fld_phone"
        Me.fld_phone.ReadOnly = True
        Me.fld_phone.Size = New System.Drawing.Size(144, 20)
        Me.fld_phone.TabIndex = 6
        '
        'lblApellidos
        '
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblApellidos.Location = New System.Drawing.Point(8, 65)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(64, 16)
        Me.lblApellidos.TabIndex = 5
        Me.lblApellidos.Text = "Telefonos"
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.Location = New System.Drawing.Point(446, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(70, 13)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Nota General"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fldTazaMora
        '
        Me.fldTazaMora.BackColor = System.Drawing.Color.White
        Me.fldTazaMora.Location = New System.Drawing.Point(128, 131)
        Me.fldTazaMora.Name = "fldTazaMora"
        Me.fldTazaMora.Size = New System.Drawing.Size(56, 20)
        Me.fldTazaMora.TabIndex = 9
        Me.fldTazaMora.Text = "0"
        Me.fldTazaMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(16, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 16)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "% Mora Mensual"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCambiarTipoPrestamo)
        Me.GroupBox3.Controls.Add(Me.lblNoCtaIngresos)
        Me.GroupBox3.Controls.Add(Me.lblCtaIngresos)
        Me.GroupBox3.Controls.Add(Me.cmbTipoPrestamos)
        Me.GroupBox3.Controls.Add(Me.lblTipoPrestamo)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.MontoSolicitadoTxt)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.SeguroTxt)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.GastoLegalTxt)
        Me.GroupBox3.Controls.Add(Me.gbAgregarCuotas)
        Me.GroupBox3.Controls.Add(Me.DG)
        Me.GroupBox3.Controls.Add(Me.lblTasaIntere)
        Me.GroupBox3.Controls.Add(Me.fld_porciento)
        Me.GroupBox3.Controls.Add(Me.fld_monto_prestamo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.fld_cantidad_cuotas)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtMontoCuota)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.btnListaPrestamos)
        Me.GroupBox3.Controls.Add(Me.btnBorrar)
        Me.GroupBox3.Controls.Add(Me.btnCerrar)
        Me.GroupBox3.Controls.Add(Me.btnProcesar)
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Controls.Add(Me.btnImprime)
        Me.GroupBox3.Controls.Add(Me.txtBalancePrestamo)
        Me.GroupBox3.Controls.Add(Me.fld_cuota_pagada)
        Me.GroupBox3.Controls.Add(Me.IdSolicitudTxt)
        Me.GroupBox3.Controls.Add(Me.fld_tipo_prestamo)
        Me.GroupBox3.Controls.Add(Me.fld_clasificacion)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.fld_fecha_entrega)
        Me.GroupBox3.Controls.Add(Me.fld_cod_prestamo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.btnCambiar)
        Me.GroupBox3.Controls.Add(Me.fldTazaMora)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(885, 465)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Préstamo"
        '
        'btnCambiarTipoPrestamo
        '
        Me.btnCambiarTipoPrestamo.BackColor = System.Drawing.SystemColors.Control
        Me.btnCambiarTipoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCambiarTipoPrestamo.ForeColor = System.Drawing.Color.Black
        Me.btnCambiarTipoPrestamo.Image = CType(resources.GetObject("btnCambiarTipoPrestamo.Image"), System.Drawing.Image)
        Me.btnCambiarTipoPrestamo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCambiarTipoPrestamo.Location = New System.Drawing.Point(271, 9)
        Me.btnCambiarTipoPrestamo.Name = "btnCambiarTipoPrestamo"
        Me.btnCambiarTipoPrestamo.Size = New System.Drawing.Size(24, 22)
        Me.btnCambiarTipoPrestamo.TabIndex = 44
        Me.btnCambiarTipoPrestamo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCambiarTipoPrestamo.UseVisualStyleBackColor = False
        Me.btnCambiarTipoPrestamo.Visible = False
        '
        'lblNoCtaIngresos
        '
        Me.lblNoCtaIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNoCtaIngresos.Location = New System.Drawing.Point(375, 13)
        Me.lblNoCtaIngresos.Name = "lblNoCtaIngresos"
        Me.lblNoCtaIngresos.Size = New System.Drawing.Size(147, 16)
        Me.lblNoCtaIngresos.TabIndex = 43
        Me.lblNoCtaIngresos.Text = "NoCtaIngresos"
        Me.lblNoCtaIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCtaIngresos
        '
        Me.lblCtaIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCtaIngresos.Location = New System.Drawing.Point(296, 12)
        Me.lblCtaIngresos.Name = "lblCtaIngresos"
        Me.lblCtaIngresos.Size = New System.Drawing.Size(82, 16)
        Me.lblCtaIngresos.TabIndex = 42
        Me.lblCtaIngresos.Text = " Ctas. Ingresos"
        Me.lblCtaIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTipoPrestamos
        '
        Me.cmbTipoPrestamos.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.cmbTipoPrestamos.ForeColor = System.Drawing.Color.White
        Me.cmbTipoPrestamos.Location = New System.Drawing.Point(127, 11)
        Me.cmbTipoPrestamos.Name = "cmbTipoPrestamos"
        Me.cmbTipoPrestamos.Size = New System.Drawing.Size(144, 21)
        Me.cmbTipoPrestamos.TabIndex = 41
        Me.cmbTipoPrestamos.Text = "Elegir una Cuenta"
        '
        'lblTipoPrestamo
        '
        Me.lblTipoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTipoPrestamo.Location = New System.Drawing.Point(5, 14)
        Me.lblTipoPrestamo.Name = "lblTipoPrestamo"
        Me.lblTipoPrestamo.Size = New System.Drawing.Size(111, 16)
        Me.lblTipoPrestamo.TabIndex = 40
        Me.lblTipoPrestamo.Text = "Tipo de Prestamos"
        Me.lblTipoPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.Location = New System.Drawing.Point(378, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 39
        Me.ComboBox1.Text = "Elegir una Cuenta"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ComboBox2.ForeColor = System.Drawing.Color.White
        Me.ComboBox2.Location = New System.Drawing.Point(378, 36)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox2.TabIndex = 37
        Me.ComboBox2.Text = "Elegir una Cuenta"
        '
        'Label10
        '
        Me.Label10.AutoEllipsis = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(278, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 16)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Ctas de Ahorros"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(263, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 16)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = " Ctas. Aportaciones"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MontoSolicitadoTxt
        '
        Me.MontoSolicitadoTxt.BackColor = System.Drawing.Color.White
        Me.MontoSolicitadoTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoSolicitadoTxt.Location = New System.Drawing.Point(378, 85)
        Me.MontoSolicitadoTxt.Name = "MontoSolicitadoTxt"
        Me.MontoSolicitadoTxt.Size = New System.Drawing.Size(100, 20)
        Me.MontoSolicitadoTxt.TabIndex = 11
        Me.MontoSolicitadoTxt.Text = "0.00"
        Me.MontoSolicitadoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(292, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Monto Seguro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SeguroTxt
        '
        Me.SeguroTxt.Location = New System.Drawing.Point(378, 109)
        Me.SeguroTxt.Name = "SeguroTxt"
        Me.SeguroTxt.Size = New System.Drawing.Size(100, 20)
        Me.SeguroTxt.TabIndex = 12
        Me.SeguroTxt.Text = "0.00"
        Me.SeguroTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(286, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Gastos Legales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GastoLegalTxt
        '
        Me.GastoLegalTxt.Location = New System.Drawing.Point(378, 133)
        Me.GastoLegalTxt.Name = "GastoLegalTxt"
        Me.GastoLegalTxt.Size = New System.Drawing.Size(100, 20)
        Me.GastoLegalTxt.TabIndex = 13
        Me.GastoLegalTxt.Text = "0.00"
        Me.GastoLegalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbAgregarCuotas
        '
        Me.gbAgregarCuotas.Controls.Add(Me.Label4)
        Me.gbAgregarCuotas.Controls.Add(Me.txtCuotasAgregar)
        Me.gbAgregarCuotas.Controls.Add(Me.btnAgregarCuotas)
        Me.gbAgregarCuotas.Location = New System.Drawing.Point(696, 374)
        Me.gbAgregarCuotas.Name = "gbAgregarCuotas"
        Me.gbAgregarCuotas.Size = New System.Drawing.Size(184, 80)
        Me.gbAgregarCuotas.TabIndex = 29
        Me.gbAgregarCuotas.TabStop = False
        Me.gbAgregarCuotas.Text = "Agregar cuotas"
        Me.gbAgregarCuotas.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cantidad"
        '
        'txtCuotasAgregar
        '
        Me.txtCuotasAgregar.BackColor = System.Drawing.Color.White
        Me.txtCuotasAgregar.Location = New System.Drawing.Point(8, 48)
        Me.txtCuotasAgregar.Name = "txtCuotasAgregar"
        Me.txtCuotasAgregar.Size = New System.Drawing.Size(56, 20)
        Me.txtCuotasAgregar.TabIndex = 1
        Me.txtCuotasAgregar.Text = "0"
        '
        'btnAgregarCuotas
        '
        Me.btnAgregarCuotas.BackColor = System.Drawing.SystemColors.Control
        Me.btnAgregarCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnAgregarCuotas.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarCuotas.Image = CType(resources.GetObject("btnAgregarCuotas.Image"), System.Drawing.Image)
        Me.btnAgregarCuotas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregarCuotas.Location = New System.Drawing.Point(80, 16)
        Me.btnAgregarCuotas.Name = "btnAgregarCuotas"
        Me.btnAgregarCuotas.Size = New System.Drawing.Size(96, 56)
        Me.btnAgregarCuotas.TabIndex = 2
        Me.btnAgregarCuotas.Text = "&Agregar Cuotas"
        Me.btnAgregarCuotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarCuotas.UseVisualStyleBackColor = False
        '
        'DG
        '
        Me.DG.BackgroundColor = System.Drawing.Color.White
        Me.DG.CaptionVisible = False
        Me.DG.DataMember = ""
        Me.DG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG.Location = New System.Drawing.Point(8, 158)
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(680, 288)
        Me.DG.TabIndex = 29
        '
        'lblTasaIntere
        '
        Me.lblTasaIntere.AutoEllipsis = True
        Me.lblTasaIntere.AutoSize = True
        Me.lblTasaIntere.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTasaIntere.Location = New System.Drawing.Point(584, 37)
        Me.lblTasaIntere.Name = "lblTasaIntere"
        Me.lblTasaIntere.Size = New System.Drawing.Size(135, 20)
        Me.lblTasaIntere.TabIndex = 14
        Me.lblTasaIntere.Text = "Tasa de Interes"
        Me.lblTasaIntere.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_porciento
        '
        Me.fld_porciento.BackColor = System.Drawing.Color.White
        Me.fld_porciento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_porciento.Location = New System.Drawing.Point(726, 34)
        Me.fld_porciento.Name = "fld_porciento"
        Me.fld_porciento.Size = New System.Drawing.Size(154, 26)
        Me.fld_porciento.TabIndex = 15
        Me.fld_porciento.Text = "0"
        Me.fld_porciento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'fld_monto_prestamo
        '
        Me.fld_monto_prestamo.BackColor = System.Drawing.Color.White
        Me.fld_monto_prestamo.Enabled = False
        Me.fld_monto_prestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_monto_prestamo.Location = New System.Drawing.Point(726, 64)
        Me.fld_monto_prestamo.Name = "fld_monto_prestamo"
        Me.fld_monto_prestamo.Size = New System.Drawing.Size(154, 26)
        Me.fld_monto_prestamo.TabIndex = 17
        Me.fld_monto_prestamo.Text = "0.00"
        Me.fld_monto_prestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(538, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Monto Préstamo RD$"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_cantidad_cuotas
        '
        Me.fld_cantidad_cuotas.BackColor = System.Drawing.Color.White
        Me.fld_cantidad_cuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_cantidad_cuotas.Location = New System.Drawing.Point(726, 93)
        Me.fld_cantidad_cuotas.Name = "fld_cantidad_cuotas"
        Me.fld_cantidad_cuotas.Size = New System.Drawing.Size(154, 26)
        Me.fld_cantidad_cuotas.TabIndex = 19
        Me.fld_cantidad_cuotas.Text = "0"
        Me.fld_cantidad_cuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoEllipsis = True
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(576, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Cantidad Cuotas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoCuota
        '
        Me.txtMontoCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCuota.Location = New System.Drawing.Point(726, 121)
        Me.txtMontoCuota.Name = "txtMontoCuota"
        Me.txtMontoCuota.Size = New System.Drawing.Size(154, 26)
        Me.txtMontoCuota.TabIndex = 21
        Me.txtMontoCuota.Text = "0.00"
        Me.txtMontoCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoEllipsis = True
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(566, 124)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(153, 20)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "Monto Cuota RD$"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnListaPrestamos
        '
        Me.btnListaPrestamos.BackColor = System.Drawing.SystemColors.Control
        Me.btnListaPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnListaPrestamos.ForeColor = System.Drawing.Color.Black
        Me.btnListaPrestamos.Image = CType(resources.GetObject("btnListaPrestamos.Image"), System.Drawing.Image)
        Me.btnListaPrestamos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnListaPrestamos.Location = New System.Drawing.Point(736, 207)
        Me.btnListaPrestamos.Name = "btnListaPrestamos"
        Me.btnListaPrestamos.Size = New System.Drawing.Size(144, 56)
        Me.btnListaPrestamos.TabIndex = 24
        Me.btnListaPrestamos.Text = "&Lista de Préstamos"
        Me.btnListaPrestamos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnListaPrestamos.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(736, 319)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(72, 56)
        Me.btnBorrar.TabIndex = 26
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(808, 319)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 27
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.SystemColors.Control
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnProcesar.ForeColor = System.Drawing.Color.Black
        Me.btnProcesar.Image = CType(resources.GetObject("btnProcesar.Image"), System.Drawing.Image)
        Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProcesar.Location = New System.Drawing.Point(808, 151)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(72, 56)
        Me.btnProcesar.TabIndex = 23
        Me.btnProcesar.Text = "&Guardar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(736, 151)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 22
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprime.Enabled = False
        Me.btnImprime.ForeColor = System.Drawing.Color.Black
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprime.Location = New System.Drawing.Point(736, 263)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(144, 56)
        Me.btnImprime.TabIndex = 25
        Me.btnImprime.Text = "&Imprimir"
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprime.UseVisualStyleBackColor = False
        '
        'txtBalancePrestamo
        '
        Me.txtBalancePrestamo.Location = New System.Drawing.Point(416, 161)
        Me.txtBalancePrestamo.Name = "txtBalancePrestamo"
        Me.txtBalancePrestamo.Size = New System.Drawing.Size(104, 20)
        Me.txtBalancePrestamo.TabIndex = 25
        Me.txtBalancePrestamo.Text = "0.00"
        Me.txtBalancePrestamo.Visible = False
        '
        'fld_cuota_pagada
        '
        Me.fld_cuota_pagada.Location = New System.Drawing.Point(328, 161)
        Me.fld_cuota_pagada.Name = "fld_cuota_pagada"
        Me.fld_cuota_pagada.Size = New System.Drawing.Size(72, 20)
        Me.fld_cuota_pagada.TabIndex = 24
        Me.fld_cuota_pagada.Text = "0.00"
        Me.fld_cuota_pagada.Visible = False
        '
        'IdSolicitudTxt
        '
        Me.IdSolicitudTxt.Location = New System.Drawing.Point(190, 35)
        Me.IdSolicitudTxt.Name = "IdSolicitudTxt"
        Me.IdSolicitudTxt.Size = New System.Drawing.Size(56, 20)
        Me.IdSolicitudTxt.TabIndex = 30
        Me.IdSolicitudTxt.Text = "0"
        Me.IdSolicitudTxt.Visible = False
        '
        'fld_tipo_prestamo
        '
        Me.fld_tipo_prestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fld_tipo_prestamo.ForeColor = System.Drawing.Color.White
        Me.fld_tipo_prestamo.Items.AddRange(New Object() {"DIARIO", "SEMANAL", "QUINCENAL", "MENSUAL", "BIMESTRAL", "TRIMESTRAL", "SEMESTRAL", "ANUAL"})
        Me.fld_tipo_prestamo.Location = New System.Drawing.Point(128, 83)
        Me.fld_tipo_prestamo.Name = "fld_tipo_prestamo"
        Me.fld_tipo_prestamo.Size = New System.Drawing.Size(144, 21)
        Me.fld_tipo_prestamo.TabIndex = 5
        Me.fld_tipo_prestamo.Text = "MENSUAL"
        '
        'fld_clasificacion
        '
        Me.fld_clasificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fld_clasificacion.ForeColor = System.Drawing.Color.White
        Me.fld_clasificacion.Items.AddRange(New Object() {"Int. y Capital Amorizable", "Int. y Capital Fijos", "Int. Diario Sobre Saldo Insoluto", "Int. Diario Sobre Capital Inicial"})
        Me.fld_clasificacion.Location = New System.Drawing.Point(128, 59)
        Me.fld_clasificacion.Name = "fld_clasificacion"
        Me.fld_clasificacion.Size = New System.Drawing.Size(144, 21)
        Me.fld_clasificacion.TabIndex = 3
        Me.fld_clasificacion.Text = "Int. y Capital Fijos"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(0, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Condición de pago"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(0, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Composición de Cuota"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_fecha_entrega
        '
        Me.fld_fecha_entrega.CustomFormat = "dd / MMM /yyyy"
        Me.fld_fecha_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha_entrega.Location = New System.Drawing.Point(128, 107)
        Me.fld_fecha_entrega.Name = "fld_fecha_entrega"
        Me.fld_fecha_entrega.Size = New System.Drawing.Size(144, 20)
        Me.fld_fecha_entrega.TabIndex = 7
        '
        'fld_cod_prestamo
        '
        Me.fld_cod_prestamo.BackColor = System.Drawing.Color.White
        Me.fld_cod_prestamo.Location = New System.Drawing.Point(128, 35)
        Me.fld_cod_prestamo.Name = "fld_cod_prestamo"
        Me.fld_cod_prestamo.Size = New System.Drawing.Size(56, 20)
        Me.fld_cod_prestamo.TabIndex = 1
        Me.fld_cod_prestamo.Text = "0"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(40, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(8, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fecha de Inicio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCambiar
        '
        Me.btnCambiar.Enabled = False
        Me.btnCambiar.Location = New System.Drawing.Point(192, 131)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(75, 23)
        Me.btnCambiar.TabIndex = 28
        Me.btnCambiar.Text = "&Modificar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(286, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Monto solicitado"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'FRM_PRESTAMO_MAESTRO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(890, 555)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_PRESTAMO_MAESTRO"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de préstamos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbAgregarCuotas.ResumeLayout(False)
        Me.gbAgregarCuotas.PerformLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Tipos de Cuotas"

    'Int. y Capital Amorizable
    'Int. y Capital Fijos
    'Int. Adelantado
    'Int. Diario Sobre Saldo Insoluto
    'Int. Diario Sobre Capital Inicial

    Sub InteresCapitalAmortizables()
        'ACTUALIZACION DE AMORTIZACION
        Dim Plazo As Integer = fld_cantidad_cuotas.Text
        Dim InteresMensual As Double = CDbl(fld_porciento.Text) / 100  '/ 12
        Dim InteresAnual As Double = CDbl(fld_porciento.Text) * 12
        Dim capitalAmortizado As Double = 0
        Dim FechaPago As Date = fld_fecha_entrega.Value
        Dim MiCuota As Double = 0

        Dim SaldoInicial As Double = CDbl(fld_monto_prestamo.Text)
        Dim CapitalPagado As Double = 0
        Dim InteresPagado As Double = 0
        Dim capitalRestante As Double = CDbl(fld_monto_prestamo.Text)

        For i As Integer = 1 To Plazo

            MiCuota = txtMontoCuota.Text
            InteresPagado = SaldoInicial * InteresMensual
            CapitalPagado = MiCuota - InteresPagado
            capitalRestante = capitalRestante - CapitalPagado
            capitalAmortizado = capitalAmortizado + CapitalPagado

            FechaPago = FechaPago.AddMonths(1)
            SaldoInicial = SaldoInicial - CapitalPagado

            CREA_CUOTAS(formatDate(FechaPago), Format(i, "000"), CapitalPagado, InteresPagado, capitalRestante, capitalAmortizado)

        Next

        'Dim montoPrestamo, Interes, numerosPagos, pagoMensual, CuotaNo, P, I As Decimal

        'Dim tipoPago As DueDate

        'montoPrestamo = CDec(fld_monto_prestamo.Text)

        'Interes = CDec(fld_porciento.Text)
        'If Interes > 0 Then Interes = Interes / 100

        'If fld_tipo_prestamo.Text = "DIARIO" Then
        '    Interes = (Interes / 12) / 30
        'ElseIf fld_tipo_prestamo.Text = "SEMANAL" Then
        '    Interes = (Interes / 12) / 7
        'ElseIf fld_tipo_prestamo.Text = "QUINCENAL" Then
        '    Interes = (Interes / 12) / 15
        'ElseIf fld_tipo_prestamo.Text = "MENSUAL AMORTIZABLE" Then
        '    Interes = (Interes / 12)
        'ElseIf fld_tipo_prestamo.Text = "BIMESTRAL" Then
        '    Interes = (Interes / 12) * 2
        'ElseIf fld_tipo_prestamo.Text = "TRIMESTRAL" Then
        '    Interes = (Interes / 12) * 3
        'ElseIf fld_tipo_prestamo.Text = "SEMESTRAL" Then
        '    Interes = (Interes / 12) * 6
        'ElseIf fld_tipo_prestamo.Text = "ANUAL" Then
        '    Interes = Interes
        'End If

        'numerosPagos = CDec(fld_cantidad_cuotas.Text)

        'tipoPago = DueDate.EndOfPeriod

        'pagoMensual = Math.Abs(-Pmt(Interes, numerosPagos, montoPrestamo, 0, tipoPago))

        'Dim fechas As Date

        'For CuotaNo = 1 To numerosPagos

        '    P = PPmt(Interes / 12, CuotaNo, numerosPagos, -montoPrestamo, 0, tipoPago)
        '    ' Round principal.
        '    P = (Int((P + 0.005) * 100) / 100)
        '    I = pagoMensual - P
        '    ' Round interest.
        '    I = (Int((I + 0.005) * 100) / 100)

        '    If fld_tipo_prestamo.Text = "DIARIO" Then
        '        fechas = fld_fecha_entrega.Value.AddDays(CuotaNo)
        '    ElseIf fld_tipo_prestamo.Text = "SEMANAL" Then
        '        fechas = fld_fecha_entrega.Value.AddDays(CuotaNo * 7)
        '    ElseIf fld_tipo_prestamo.Text = "QUINCENAL" Then
        '        fechas = fld_fecha_entrega.Value.AddDays(CuotaNo * 15)
        '    ElseIf fld_tipo_prestamo.Text = "MENSUAL" Then
        '        fechas = fld_fecha_entrega.Value.AddMonths(CuotaNo)
        '    ElseIf fld_tipo_prestamo.Text = "BIMESTRAL" Then
        '        fechas = fld_fecha_entrega.Value.AddMonths(CuotaNo * 2)
        '    ElseIf fld_tipo_prestamo.Text = "TRIMESTRAL" Then
        '        fechas = fld_fecha_entrega.Value.AddMonths(CuotaNo * 3)
        '    ElseIf fld_tipo_prestamo.Text = "SEMESTRAL" Then
        '        fechas = fld_fecha_entrega.Value.AddMonths(CuotaNo * 6)
        '    ElseIf fld_tipo_prestamo.Text = "ANUAL" Then
        '        fechas = fld_fecha_entrega.Value.AddYears(CuotaNo)
        '    End If

        '    CREA_CUOTAS(formatDate(fechas), Format(CuotaNo, "000"), P, I, 0, 0)

        'Next CuotaNo

    End Sub

    Sub InteresCapitalFijosInteresAplicDiario(ByVal interes As Decimal, ByVal capital As Decimal)

        Dim cuotaNo, numerosPagos, bce_capital As Decimal
        Dim fechas As Date

        numerosPagos = CDec(fld_cantidad_cuotas.Text)
        bce_capital = CDec(fld_monto_prestamo.Text)

        If fld_clasificacion.Text = "Int. Adelantado" Then
            numerosPagos = numerosPagos - 1
        End If

        For cuotaNo = 1 To numerosPagos


            If fld_tipo_prestamo.Text = "DIARIO" Then
                fechas = fld_fecha_entrega.Value.AddDays(cuotaNo)
            ElseIf fld_tipo_prestamo.Text = "SEMANAL" Then
                fechas = fld_fecha_entrega.Value.AddDays(cuotaNo * 7)
            ElseIf fld_tipo_prestamo.Text = "QUINCENAL" Then
                fechas = fld_fecha_entrega.Value.AddDays(cuotaNo * 15)
            ElseIf fld_tipo_prestamo.Text = "MENSUAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo)
            ElseIf fld_tipo_prestamo.Text = "BIMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo * 2)
            ElseIf fld_tipo_prestamo.Text = "TRIMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo * 3)
            ElseIf fld_tipo_prestamo.Text = "SEMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo * 6)
            ElseIf fld_tipo_prestamo.Text = "ANUAL" Then
                fechas = fld_fecha_entrega.Value.AddYears(cuotaNo)
            End If

            If fld_clasificacion.Text = "Int. y Capital Fijos" Then
                CREA_CUOTAS(formatDate(fechas), Format(cuotaNo, "000"), capital, interes, 0, 0)
            Else
                CREA_CUOTAS(formatDate(fechas), Format(cuotaNo, "000"), capital, 0, 0, 0)
            End If

        Next cuotaNo



    End Sub

    Sub InteresAdelantado(ByVal interes As Decimal)

        Dim cuotaNo, numerosPagos, capital As Decimal
        Dim fechas As Date

        numerosPagos = CDec(fld_cantidad_cuotas.Text)
        capital = CDec(fld_monto_prestamo.Text)



        For cuotaNo = 1 To numerosPagos - 1


            If fld_tipo_prestamo.Text = "DIARIO" Then
                fechas = fld_fecha_entrega.Value.AddDays(cuotaNo)
            ElseIf fld_tipo_prestamo.Text = "SEMANAL" Then
                fechas = fld_fecha_entrega.Value.AddDays(cuotaNo * 7)
            ElseIf fld_tipo_prestamo.Text = "QUINCENAL" Then
                fechas = fld_fecha_entrega.Value.AddDays(cuotaNo * 15)
            ElseIf fld_tipo_prestamo.Text = "MENSUAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo)
            ElseIf fld_tipo_prestamo.Text = "BIMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo * 2)
            ElseIf fld_tipo_prestamo.Text = "TRIMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo * 3)
            ElseIf fld_tipo_prestamo.Text = "SEMESTRAL" Then
                fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo * 6)
            ElseIf fld_tipo_prestamo.Text = "ANUAL" Then
                fechas = fld_fecha_entrega.Value.AddYears(cuotaNo)
            End If

            CREA_CUOTAS(formatDate(fechas), Format(cuotaNo, "000"), 0, interes, 0, 0)
        Next cuotaNo


        If fld_tipo_prestamo.Text = "DIARIO" Then
            fechas = fld_fecha_entrega.Value.AddDays(cuotaNo + 1)
        ElseIf fld_tipo_prestamo.Text = "SEMANAL" Then
            fechas = fld_fecha_entrega.Value.AddDays(cuotaNo + 7)
        ElseIf fld_tipo_prestamo.Text = "QUINCENAL" Then
            fechas = fld_fecha_entrega.Value.AddDays(cuotaNo + 15)
        ElseIf fld_tipo_prestamo.Text = "MENSUAL" Then
            fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo)
        ElseIf fld_tipo_prestamo.Text = "BIMESTRAL" Then
            fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo + 2)
        ElseIf fld_tipo_prestamo.Text = "TRIMESTRAL" Then
            fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo + 3)
        ElseIf fld_tipo_prestamo.Text = "SEMESTRAL" Then
            fechas = fld_fecha_entrega.Value.AddMonths(cuotaNo + 6)
        ElseIf fld_tipo_prestamo.Text = "ANUAL" Then
            fechas = fld_fecha_entrega.Value.AddYears(cuotaNo + 1)
        End If

        CREA_CUOTAS(formatDate(fechas), Format(cuotaNo, "000"), capital, interes, 0, 0)


    End Sub


    Sub TestRate()
        Dim PVal, Payment, TotPmts, APR As Double
        Dim PayType As DueDate

        ' Define percentage format. 
        Dim Fmt As String = "##0.00"
        Dim Response As MsgBoxResult
        ' Usually 0 for a loan. 
        Dim FVal As Double = 0
        ' Guess of 10 percent. 
        Dim Guess As Double = 0.1
        PVal = CDbl(InputBox("Cantidad a préstar"))
        Payment = CDbl(InputBox("What's your monthly payment?"))
        TotPmts = CDbl(InputBox("How many monthly payments do you have to make?"))
        Response = MsgBox("Do you make payments at the end of the month?", MsgBoxStyle.YesNo)
        If Response = MsgBoxResult.No Then
            PayType = DueDate.BegOfPeriod
        Else
            PayType = DueDate.EndOfPeriod
        End If
        APR = (Rate(TotPmts, -Payment, PVal, FVal, PayType, Guess) * 12) * 100

        MsgBox("Your interest rate is " & Format(CInt(APR), Fmt) & " percent.")
    End Sub
    Sub TestIPMT()
        Dim APR, PVal, Period, IntPmt, TotInt, TotPmts As Double
        Dim PayType As DueDate
        Dim Response As MsgBoxResult

        ' Usually 0 for a loan. 
        Dim Fval As Double = 0
        ' Define money format. 
        Dim Fmt As String = "###,###,##0.00"
        PVal = CDbl(InputBox("Cantidad a préstar?"))
        APR = CDbl(InputBox("Cuál es el interes anual?"))
        If APR > 1 Then APR = APR / 100 ' Ensure proper form.
        TotPmts = CInt(InputBox("Cuánto pagos mensuales?"))
        Response = MsgBox("Los pagos se harán al final de cada mes?", MsgBoxStyle.YesNo)
        If Response = MsgBoxResult.No Then
            PayType = DueDate.BegOfPeriod
        Else
            PayType = DueDate.EndOfPeriod
        End If
        For Period = 1 To TotPmts   ' Total all interest.
            IntPmt = IPmt(APR / 12, Period, TotPmts, -PVal, Fval, PayType)
            TotInt = TotInt + IntPmt
        Next Period

        ' Display results.
        MsgBox("You will pay a total of " & Format(TotInt, Fmt) & " in interest for this loan.")
    End Sub
    Sub TestPMT()
        Dim PVal, APR, Payment, TotPmts As Double
        Dim PayType As DueDate
        Dim Response As MsgBoxResult

        ' Define money format. 
        Dim Fmt As String = "###,###,##0.00"
        ' Usually 0 for a loan. 
        Dim FVal As Double = 0
        PVal = CDbl(InputBox("How much do you want to borrow?"))
        APR = CDbl(InputBox("What is the annual percentage rate of your loan?"))
        If APR > 1 Then APR = APR / 100 ' Ensure proper form.
        TotPmts = CDbl(InputBox("How many monthly payments will you make?"))
        Response = MsgBox("Do you make payments at the end of month?", MsgBoxStyle.YesNo)
        If Response = MsgBoxResult.No Then
            PayType = DueDate.BegOfPeriod
        Else
            PayType = DueDate.EndOfPeriod
        End If
        Payment = Pmt(APR / 12, TotPmts, -PVal, FVal, PayType)

        MsgBox("Your payment will be " & Format(Payment, Fmt) & " per month.")
    End Sub


#End Region

    Private Sub BuscarAdelantos()

        txtMontoAdelanto.Text = Format(SCALAR_NUM("SELECT IFNULL(SUM(fld_monto),0) FROM tbl_recibo_ingresos_cxc WHERE fld_adelanto='True' AND fld_adelanto_aplicado = 'False' AND fld_id_cliente_ri=" & CInt(txtId.Text) & ""), "C2")

    End Sub

    Private Sub AplicarAdelantos()

        Dim dr As DataRow
        For Each dr In dsCuotas.Tables(0).Rows
            If dr("fld_ultimo_abono_interes") > 0 Or dr("fld_ultimo_abono_capital") > 0 Then
                GuardarCambioCuotas(dr("fld_id_cuotas"), dr("fld_ultimo_abono_interes"), dr("fld_ultimo_abono_capital"), dr("fld_abono_cuotas"))
            End If
        Next
        NON_QUERY("UPDATE tbl_recibo_ingresos_cxc SET fld_adelanto_aplicado = 'True' WHERE fld_adelanto='True' AND fld_adelanto_aplicado = 'False' AND fld_id_cliente_ri=" & CInt(txtId.Text) & "")

    End Sub

    Private Sub SumarMontoGastoSeguro()
        fld_monto_prestamo.Text = Format(CDec(MontoSolicitadoTxt.Text) + CDec(SeguroTxt.Text) + CDec(GastoLegalTxt.Text), "N2")
    End Sub

#Region "Cuotas"

    Dim dsCuotas As DataSet

    Private Sub CargarCuotas(ByVal IdPrest As Integer)

        StyleFact()
        dsCuotas = New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_cuotas WHERE fld_id_del_prestamo=" & IdPrest & " ORDER BY fld_no_cuotas", conn)
        da.Fill(dsCuotas, "tbl_cuotas")


        DG.DataSource = dsCuotas.Tables(0)
        Dim dr As DataRow
        For Each dr In dsCuotas.Tables(0).Rows
            txtBalancePrestamo.Text = CDbl(txtBalancePrestamo.Text) + (dr("fld_capital_cuota_balance") + dr("fld_interes_cuota_balance"))
        Next
        Dim DataTable As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable = dsCuotas.Tables(0)
        DataTable.DefaultView.AllowNew = False

    End Sub

    Private Sub StyleFact()
        DG.TableStyles.Clear()

        ' Create a new DataGridTableStyle and set 
        ' its MappingName to the TableName of a DataTable. 

        Dim ts1 As New DataGridTableStyle
        ts1.GridLineColor = Color.Peru
        ts1.MappingName = "tbl_cuotas"




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
    Private Sub Calcular()

        Dim monto_cliente_detalle As Double
        Dim monto As Decimal = 0
        Dim capital_cobrado As Decimal = 0
        Dim interes_cobrado As Decimal = 0

        monto = Format(CDbl(txtMontoAdelanto.Text), "C2")

        monto_cliente_detalle = Format(monto, "C2")

        Dim rows As DataRow, monto_mora As Double = 0



        For Each rows In dsCuotas.Tables(0).Rows

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
        Next

        DG.DataSource = dsCuotas.Tables(0)
        Dim DataTable As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable = dsCuotas.Tables(0)
        DataTable.DefaultView.AllowNew = False

        AplicarAdelantos()

    End Sub
    Private Sub GuardarCambioCuotas(ByVal id_doc As String, ByVal abono_interes As Double, ByVal abono_capital As Double, ByVal abono_cuota As Double)

        NON_QUERY("UPDATE tbl_cuotas SET fld_interes_cuota_abono=fld_interes_cuota_abono + " & abono_interes & ",  fld_interes_cuota_balance=fld_interes_cuota-fld_interes_cuota_abono,  fld_capital_cuota_abono=fld_capital_cuota_abono+" & abono_capital & ",fld_capital_cuota_balance=fld_capital_cuota-fld_capital_cuota_abono, fld_abono_cuotas=fld_abono_cuotas + " & abono_capital + abono_interes & ", fld_balance_cuotas=fld_monto_cuotas-fld_abono_cuotas WHERE  fld_id_cuotas=" & id_doc & "")

    End Sub

#End Region

    Private Sub CREAR()
        If fldTazaMora.Text = String.Empty Then fldTazaMora.Text = 0
        If CDec(fldTazaMora.Text) <= 0 Then
            Alerta("La taza de mora mensual es igual a CERO")
        End If
        CALCULO_CUOTA_INICIAL()
        GENERANDO_PRESTAMO()
    End Sub

    Private Sub FRM_PRESTAMO_MAESTRO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarZona()
        LlenarTiposPrestamos()
        txtId.Focus()
        fld_porciento.Text = SCALAR_NUM("SELECT TasaInteres FROM parametrosgenerales WHERE ID=1")
        fldTazaMora.Text = SCALAR_NUM("SELECT Mora FROM parametrosgenerales WHERE ID=1")
        If CInt(IdSolicitudTxt.Text) > 0 Then
            btnBuscar.Enabled = False
            txtId.Enabled = False
            fld_cod_prestamo.Enabled = False
            fld_clasificacion.Enabled = False
            fld_tipo_prestamo.Enabled = False
            fld_fecha_entrega.Enabled = False
            fld_porciento.Enabled = False
            fld_monto_prestamo.Enabled = False
            fld_cantidad_cuotas.Enabled = False
            txtMontoCuota.Enabled = False
            buscarSolicitud(CInt(IdSolicitudTxt.Text))


        End If

    End Sub

    Private Sub buscarSolicitud(ByVal IdDoc As Integer)

        Dim isdata As Boolean = False
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM solicitudcredito WHERE Id=" & IdDoc & "", conn)
        da.Fill(ds, "solicitudcredito")

        Dim nr As DataRow
        For Each nr In ds.Tables(0).Rows
            'fld_cod_prestamo.Text = IdDoc
            fld_fecha_entrega.Value = CDate(SCALAR_STRING("SELECT Now()"))
            fld_fecha_entrega.Enabled = False
            fld_monto_prestamo.Text = Format(nr("Monto"), "C2")
            fld_monto_prestamo.Enabled = False
            txtMontoCuota.Text = Format(nr("MontoCuotas"), "C2")
            txtMontoCuota.Enabled = False
            MontoSolicitadoTxt.Text = Format(nr("MontoSolicitado"), "C2")
            MontoSolicitadoTxt.Enabled = False
            fld_cantidad_cuotas.Text = nr("CantCuotas")
            fld_cantidad_cuotas.Enabled = False
            fld_clasificacion.Text = nr("Clasificacion")
            fld_clasificacion.Enabled = False
            fld_tipo_prestamo.Text = nr("Condicion")
            fld_tipo_prestamo.Enabled = False
            fld_porciento.Text = nr("Interes")
            fld_porciento.Enabled = False
            GastoLegalTxt.Text = Format(nr("Montolegal"), "C2")
            GastoLegalTxt.Enabled = False
            SeguroTxt.Text = Format(nr("Seguro"), "C2")
            SeguroTxt.Enabled = False
            txtNotaGeneral.Text = nr("Notas")


            txtId.Text = nr("Socio")

        Next

        da.Dispose()
        ds.Dispose()

        LOAD_DATA_CLIENTE(txtId.Text)


    End Sub
    Private Sub buscarSocioSolicitud(ByVal idSocio As Integer)
        Dim isdata As Boolean = False
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM SolicitudCreditoCliente WHERE fld_id=" & idSocio & "", conn)
        da.Fill(ds, "SolicitudCreditoCliente")

        Dim nr As DataRow

        For Each nr In ds.Tables(0).Rows
            If nr("fld_Status") = "B" Then
                txtId.Text = ""
                Alerta("Este socio está excluído de la lista")
            End If
            txtId.Text = idSocio
            txtNombre.Text = nr("fld_FullName")
            fld_phone.Text = nr("fld_phone")
            fld_phone2.Text = nr("fld_phone2")
            txtCedula.Text = nr("fld_Identity")

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

    Private Sub LlenarZona()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT fldId, fldDescripcion FROM tbl_maestro_zonas ORDER BY fldDescripcion", conn)
        da.Fill(dt)
        cmdZona.DataSource = dt
        cmdZona.DisplayMember = "fldDescripcion"
        cmdZona.ValueMember = "fldId"

        da.Dispose()

    End Sub

    Private Sub LlenarTiposPrestamos()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT CuentaNo, Descripcion FROM tbl_catalogo WHERE CtaControl IN ('101-01-01','101-01-02')", conn)
        da.Fill(dt)
        cmbTipoPrestamos.DataSource = dt
        cmbTipoPrestamos.DisplayMember = "Descripcion"
        cmbTipoPrestamos.ValueMember = "CuentaNo"

        da.Dispose()

    End Sub


    Private Sub CLEAR_ALL_DATA()
        txtMontoCuota.Text = "0.00"
        txtId.Text = "0"
        txtMontoAdelanto.Text = "0.00"
        txtNombre.Text = ""
        fld_phone.Text = ""
        fld_phone2.Text = ""
        txtCedula.Text = ""
        txtCiudad.Text = ""
        txtNotaGeneral.Text = ""
        fld_monto_prestamo.Text = "0.00"
        fld_cantidad_cuotas.Text = "0"
        txtBalancePrestamo.Text = "0.00"
        'dsCuotas.Clear()
        fld_cod_prestamo.Enabled = True
        btnProcesar.Enabled = True
        btnModificaNota.Enabled = False
        btnCambiar.Enabled = False
        GastoLegalTxt.Text = "0.00"
        SeguroTxt.Text = "0.00"
        MontoSolicitadoTxt.Text = "0.00"
        btnImprime.Enabled = False
        fld_cod_prestamo.Text = 0
        txtId.Focus()
        fld_porciento.Text = SCALAR_NUM("SELECT TasaInteres FROM parametrosgenerales WHERE ID=1")
        fldTazaMora.Text = SCALAR_NUM("SELECT Mora FROM parametrosgenerales WHERE ID=1")
    End Sub

    Private Sub CargarPrestamos(ByVal IdPrestamo As Integer)
        gbAgregarCuotas.Visible = False
        Dim isdata As Boolean = False
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_prestamos WHERE fld_id_prestamos=" & IdPrestamo & "", conn)
        da.Fill(ds, "tbl_prestamos")

        Dim nr As DataRow
        For Each nr In ds.Tables(0).Rows
            fld_cod_prestamo.Text = Format(IdPrestamo, "00000")

            If nr("CtaIngreso").ToString = "" Then
                cmbTipoPrestamos.Text = String.Empty
                lblNoCtaIngresos.Text = "N/D"
                btnCambiarTipoPrestamo.Visible = True
            Else
                cmbTipoPrestamos.SelectedValue = nr("CtaIngreso")
                btnCambiarTipoPrestamo.Visible = False
            End If

            fld_fecha_entrega.Value = nr("fld_fecha_entrega")
            fld_monto_prestamo.Text = Format(nr("fld_capital_prestamo"), "C2")
            txtMontoCuota.Text = Format(nr("fld_monto_cuotas_a"), "C2")
            fld_cantidad_cuotas.Text = nr("fld_cantidad_cuotas")
            fld_clasificacion.Text = nr("fld_clasificacion")
            fld_tipo_prestamo.Text = nr("fld_tipo_prestamo")
            'txtBalancePrestamo.Text = nr("fld_monto")
            GastoLegalTxt.Text = Format(nr("GastosLegales"), "C2")
            SeguroTxt.Text = Format(nr("Seguro"), "C2")
            MontoSolicitadoTxt.Text = Format(nr("fld_capital_prestamo") - (nr("GastosLegales") + nr("Seguro")), "C2")
            fld_porciento.Text = nr("fld_interes_p")
            fldTazaMora.Text = nr("fldTazaMora")
            txtNotaGeneral.Text = nr("fldNota")
            If nr("fld_clasificacion") = "Int. Adelantado" Or nr("fld_clasificacion") = "Int. Diario Sobre Saldo Insoluto" Or nr("fld_clasificacion") = "Int. Diario Sobre Capital Inicial" Then
                gbAgregarCuotas.Visible = True
            End If

            LOAD_DATA_CLIENTE(nr("fld_id_del_cliente"))
            CargarCuotas(IdPrestamo)
            fld_cod_prestamo.Enabled = False
            btnProcesar.Enabled = False
            btnImprime.Enabled = True
            btnModificaNota.Enabled = True
            btnCambiar.Enabled = True
            GoTo sigue
        Next


        Alerta("No se encontró el documento solicitado")
        fld_cod_prestamo.Text = "0"
        fld_cod_prestamo.Focus()

sigue:

        da.Dispose()
        ds.Dispose()
    End Sub

    Private Sub LOAD_DATA_CLIENTE(ByVal idCliente As Integer)
        Dim isdata As Boolean = False
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_clientes WHERE fld_id=" & idCliente & "", conn)
        da.Fill(ds, "tbl_clientes")

        Dim nr As DataRow



        For Each nr In ds.Tables(0).Rows
            If nr("fld_Status") = "B" Then
                txtId.Text = ""
                Alerta("Este socio está excluído de la lista")
            End If
            txtId.Text = idCliente
            txtNombre.Text = nr("fld_FullName")
            fld_phone.Text = nr("fld_phone")
            fld_phone2.Text = nr("fld_phone2")
            txtCedula.Text = nr("fld_Identity")
            txtCiudad.Text = nr("fld_City")
            cmdZona.SelectedValue = nr("fld_cod_zona")
            BuscarAdelantos()
            If CDec(txtMontoAdelanto.Text) > 0 Then
                Alerta("Este socio ha realizados pagos por adelandos, confirme que sea el monto adecuado.")
            End If
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

    Private Sub CALCULO_CUOTA_INICIAL()
        Dim interes_cuota As Double = (CDec(fld_monto_prestamo.Text) * CDec(fld_porciento.Text)) / 100
        Dim capital As Double = CDec(fld_monto_prestamo.Text) / CDec(fld_cantidad_cuotas.Text)
        Dim interesAnual As Double = CDbl(fld_porciento.Text) * 12


        If fld_clasificacion.Text = "Int. Adelantado" Then
            txtMontoCuota.Text = Format(interes_cuota, "C2")
        ElseIf fld_clasificacion.Text = "Int. y Capital Amorizable" Then
            'Dim Interes = CDec(fld_porciento.Text)
            'Dim totalCuotas = CDec(fld_cantidad_cuotas.Text)
            'Dim montoPrestamo = CDec(fld_monto_prestamo.Text)
            'If Interes > 0 Then Interes = Interes / 100
            'txtMontoCuota.Text = Format(Pmt(Interes, totalCuotas, -montoPrestamo, 0, DueDate.EndOfPeriod), "C2")

            'ACTUALIZACION DE AMORTIZACION
            txtMontoCuota.Text = Operaciones.Calculacuota(CDbl(fld_monto_prestamo.Text), interesAnual, CInt(fld_cantidad_cuotas.Text))

        ElseIf fld_clasificacion.Text = "Int. y Capital Fijos" Then
            txtMontoCuota.Text = Format(interes_cuota + capital, "C2")
        Else
            txtMontoCuota.Text = Format(capital, "C2")
        End If


    End Sub

    Private Function VALIDA_DATOS() As Boolean
        If Trim(fld_cuota_pagada.Text) = "" Then fld_cuota_pagada.Text = "0"
        If Trim(fldTazaMora.Text) = "" Then fldTazaMora.Text = "0"
        If Trim(fld_porciento.Text) = "" Then fld_porciento.Text = "0.00"
        If Trim(GastoLegalTxt.Text) = "" Then GastoLegalTxt.Text = "0.00"
        If Trim(SeguroTxt.Text) = "" Then SeguroTxt.Text = "0.00"
        If Trim(fld_monto_prestamo.Text) = "" Then fld_monto_prestamo.Text = "0.00"
        If Trim(fld_cantidad_cuotas.Text) = "" Then fld_cantidad_cuotas.Text = "0.00"
        If Trim(fld_porciento.Text) = "" Then fld_porciento.Text = "0.00"


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
        End If


        Return True
    End Function

    Private Sub CREA_PRESTAMO()

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "INSERT INTO tbl_prestamos (fld_id_del_cliente,fld_fecha_entrega,fld_cantidad_cuotas,fld_monto_cuotas_a,fld_capital_prestamo,fld_monto,fld_abono,fld_balance,fld_usuario,fld_status_prestamos, fld_anos, fld_interes_p,fld_tipo_prestamo,fld_tipo_garantia, fld_garantia, fld_clasificacion,fld_ck_no, fldFinanciamiento, fldMontoFinan, fldMontoInicial, fldCodInm, fldDescInm, fldMetros, fldPrecioMetro, fldTazaMora,fldNota,GastosLegales,Seguro,CtaIngreso) VALUES(" & txtId.Text & ",'" & formatDate(fld_fecha_entrega.Value.Date) & "'," & fld_cantidad_cuotas.Text & "," & CDec(txtMontoCuota.Text) & "," & CDec(fld_monto_prestamo.Text) & ",0,0,0,'" & User(0) & "','Nuevo', 0, " & CDec(fld_porciento.Text) & ",'" & fld_tipo_prestamo.Text & "','N/A', 'N/A','" & fld_clasificacion.Text & "','','NO',0,0,0,'N/A',0,0," & CDec(fldTazaMora.Text) & ",'" & txtNotaGeneral.Text & "'," & CDec(GastoLegalTxt.Text) & "," & CDec(SeguroTxt.Text) & ",'" & cmbTipoPrestamos.SelectedValue.ToString & "')"
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()
        fld_cod_prestamo.Enabled = False
        btnProcesar.Enabled = False
    End Sub

    Private Sub CREA_CUOTAS(ByVal fecha_termina As String, ByVal no_cuotas As String, ByVal capital_cuotas As Decimal, ByVal interes_cuota As Decimal, ByVal fld_pendiente_amortizar As Decimal, ByVal fld_total_amortizado As Decimal)

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "INSERT INTO tbl_cuotas (fld_no_cuotas,fld_id_del_cliente_cuotas,fld_id_del_prestamo,fld_fecha_entrega_cuotas,fld_fecha_termina_cuotas,fld_capital_cuota,fld_interes_cuota,fld_monto_cuotas,fld_abono_cuotas,fld_balance_cuotas,fld_usuario_cuotas,fld_status_cuotas,fld_pendiente_amortizar,fld_total_amortizado, fld_capital_cuota_abono, fld_capital_cuota_balance,fld_interes_cuota_abono,fld_interes_cuota_balance,fld_fecha_ultimo_abono_cuotas,fld_monto_mora, fld_abono_mora, fld_balance_mora, fld_ultimo_abono_mora,fld_ultimo_abono_interes,fld_ultimo_abono_capital,fld_socio,fld_tipo_cuotas,fld_cant_cuotas, fld_fecha_calculo_interes) VALUES('" & no_cuotas & "'," & CInt(txtId.Text) & ", " & CInt(fld_cod_prestamo.Text) & ", '" & formatDate(fld_fecha_entrega.Value.Date) & "','" & fecha_termina & "'," & capital_cuotas & "," & interes_cuota & ", " & capital_cuotas + interes_cuota & ", 0, " & capital_cuotas + interes_cuota & ",'" & User(0) & "', 'Nueva', " & fld_pendiente_amortizar & "," & fld_total_amortizado & ",0," & capital_cuotas & ",0," & interes_cuota & ",'" & formatDate(fld_fecha_entrega.Value.Date) & "',0,0,0,0,0,0,'','" & fld_tipo_prestamo.Text & "'," & fld_cantidad_cuotas.Text & ", '" & formatDate(fld_fecha_entrega.Value.Date) & "')"
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()

    End Sub

    Private Function UPDATE_CUOTA_PAGADAS(ByVal ID_CUOTA As String) As Double
        Dim CMD As New MySqlCommand
        With CMD
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_cuotas SET fld_abono_cuotas=fld_monto_cuotas, fld_balance_cuotas=0, fld_capital_cuota_abono=fld_capital_cuota, fld_capital_cuota_balance=0, fld_interes_cuota_abono=fld_interes_cuota, fld_interes_cuota_balance=0, fld_fecha_ultimo_abono_cuotas=fld_fecha_termina_cuotas WHERE fld_no_cuotas=" & ID_CUOTA & " AND fld_id_del_prestamo=" & CInt(fld_cod_prestamo.Text) & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        CMD.Dispose()

    End Function

    Private Sub GENERANDO_PRESTAMO()

        If VALIDA_DATOS() = False Then Exit Sub




        Dim limite As Double = SCALAR_NUM("SELECT fld_limite FROM tbl_clientes WHERE fld_id=" & CInt(txtId.Text) & "")
        If CDec(fld_monto_prestamo.Text) > limite Then
            If Alerta("No se puede procesar el monto solicitado... Desea pedir autorización?") = True Then
                Dim f As New frmAutorizacion
                f.ShowDialog()
                If f.Text = "ACEPTAR" Then
                Else
                    Exit Sub
                End If
            Else
                Return
            End If
        End If

        If btnProcesar.Enabled = False Then Exit Sub

        If CDec(Trim(fld_cantidad_cuotas.Text)) > 0 Then
            'HACER LOS CALCULOS Y GENERAL EL PRESTAMO SI EL USUARIO ACEPTA
            If Alerta("Verifique que los datos esten correcto..." & Chr(13) & "¿Desea continuar?") = True Then
                CREA_PRESTAMO() 'Crea el préstamos
                fld_cod_prestamo.Text = UltimoID("tbl_prestamos", "fld_id_prestamos")
                InterfarContableAutomatico("Cuenta por Cobrar", "Crear Préstamo", fld_fecha_entrega.Value.Date, CDec(fld_monto_prestamo.Text), fld_cod_prestamo.Text, "Entrega de préstamos")
                GENERANDO_CUOTAS() 'Genera y crea las cuotas
                If CDec(fld_cuota_pagada.Text) > 0 Then
                    Dim i As Integer
                    For i = 1 To CDec(fld_cuota_pagada.Text)
                        UPDATE_CUOTA_PAGADAS(i)
                    Next
                End If

                CargarCuotas(CInt(fld_cod_prestamo.Text))

                Dim fechaTermina As Date = CDate(SCALAR_STRING("SELECT MAX(fld_fecha_termina_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & ""))
                NON_QUERY("UPDATE tbl_prestamos SET fld_monto=" & CDec(txtBalancePrestamo.Text) & ",  fld_balance=fld_monto, fld_fecha_termina='" & formatDate(fechaTermina) & "' WHERE fld_id_prestamos=" & fld_cod_prestamo.Text & "")

                Calcular()
                create_row_estado_cliente(txtId.Text, CDec(txtBalancePrestamo.Text), "PRESTAMOS", fld_cod_prestamo.Text, "ENTREGA DE PRESTAMO", formatDate(fld_fecha_entrega.Value.Date))
                If CInt(IdSolicitudTxt.Text) > 0 Then
                    Me.Text = "ACEPTAR"
                    'Me.Close()
                End If
                btnImprime.Enabled = True
            End If
        End If
    End Sub

    Private Sub GENERANDO_CUOTAS()


        Dim porciento_prestamo As Double = CDec(fld_porciento.Text)

        'Dim interes_cuota As Double = 0, cap_cuota As Double = 0

        'Int. y Capital Amorizable OK
        'Int. y Capital Fijos
        'Int. Adelantado
        'Int. Diario Sobre Saldo Insoluto
        'Int. Diario Sobre Capital Inicial

        ' cap_cuota = CDec(fld_monto_prestamo.Text) / CDec(fld_cantidad_cuotas.Text)
        'interes_cuota = ((CDec(fld_monto_prestamo.Text) * CDec(porciento_prestamo)) / 100)

        Dim interes_cuota As Decimal = (CDec(fld_monto_prestamo.Text) * CDec(fld_porciento.Text)) / 100
        Dim cap_cuota As Decimal = CDec(fld_monto_prestamo.Text) / CDec(fld_cantidad_cuotas.Text)

        If fld_clasificacion.Text = "Int. y Capital Amorizable" Then
            InteresCapitalAmortizables()
        ElseIf fld_clasificacion.Text = "Int. Adelantado" Then
            InteresAdelantado(interes_cuota)
        Else
            InteresCapitalFijosInteresAplicDiario(interes_cuota, cap_cuota)
        End If

        'If fld_tipo_prestamo.Text = "INT. ADELANTADO MENSUAL" Then
        '    Dim interes As Double = Format(((cdec(fld_monto_prestamo.Text) * cdec(porciento_prestamo)) / 100), "C2")
        '    Dim interes_capital As Double = Format((cdec(fld_monto_prestamo.Text) + ((cdec(fld_monto_prestamo.Text) * cdec(porciento_prestamo)) / 100)), "C2")

        '    For i = 1 To CInt(fld_cantidad_cuotas.Text) - 1
        '        fechas = fld_fecha_entrega.Value.AddMonths(i)
        '        CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), 0, interes, 0, 0)
        '        cuota_no = cuota_no + 1
        '    Next

        '    fechas = fechas.Date.AddMonths(1)
        '    CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), cdec(fld_monto_prestamo.Text), interes, 0, 0)
        '    Exit Sub
        'ElseIf fld_tipo_prestamo.Text = "INT. ADELANTADO QUINCENAL" Then
        '    Dim interes As Double = Format(((cdec(fld_monto_prestamo.Text) * cdec(porciento_prestamo)) / 100), "C2")
        '    Dim dia As Integer = 15
        '    fechas = fld_fecha_entrega.Value.AddDays(dia)

        '    For i = 1 To CInt(fld_cantidad_cuotas.Text) - 1
        '        fechas = fld_fecha_entrega.Value.AddDays(dia)
        '        CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), 0, interes, 0, 0)
        '        cuota_no = cuota_no + 1
        '        dia = dia + 15
        '    Next

        '    fechas = fechas.Date.AddDays(15)
        '    CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), cdec(fld_monto_prestamo.Text), interes, 0, 0)
        '    Exit Sub
        'End If



        'Dim bce_capital As Double = cdec(fld_monto_prestamo.Text)

        'Dim dias As Integer = 7
        'If fld_tipo_prestamo.Text = "QUINCENAL" Then
        '    dias = 15
        'End If

        'For i = 1 To cdec(fld_cantidad_cuotas.Text)

        '    If fld_tipo_prestamo.Text = "QUINCENAL" Then
        '        fechas = fld_fecha_entrega.Value.AddDays(dias)
        '        dias = dias + 15
        '    ElseIf fld_tipo_prestamo.Text = "SEMANAL" Then
        '        fechas = fld_fecha_entrega.Value.AddDays(dias)
        '        dias = dias + 7
        '    Else
        '        fechas = fld_fecha_entrega.Value.AddMonths(i)
        '    End If

        '    If fld_clasificacion.Text = "No Amortizales" Then
        '        CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), cap_cuota, interes_cuota, 0, 0)
        '    ElseIf fld_clasificacion.Text = "Amortizables" Then
        '        CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), cap_cuota, interes_cuota, 0, 0)
        '        interes_cuota = (((bce_capital - cap_cuota) * cdec(porciento_prestamo)) / 100)
        '        bce_capital = bce_capital - cap_cuota
        '    Else
        '        CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), cap_cuota, 0, 0, 0)
        '    End If

        '    cuota_no = cuota_no + 1
        'Next

        'count = 0
        'cuota_no = 1


    End Sub

    Private Sub CREATE_INGRESOS(ByVal description As String, ByVal MONTO As Double, ByVal DOC_AFECT As String)

        Dim TABLA = "tbl_recibo_ingresos_cxc"

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "INSERT INTO " & TABLA & " (fld_forma_pago,fld_detalle_forma_pago,fld_id_cliente_ri,fld_date,fld_Description,fld_monto,fld_fact_afectado,fdl_nd_afectado,fld_User,fld_Estado,fld_id_prestamo) VALUES('EFECTIVO','N/A'," & txtId.Text & ",'" & formatDate(Now.Date) & "','" & description & "'," & MONTO & ",'" & DOC_AFECT & "','N/A','" & User(0) & "','NEW'," & fld_cod_prestamo.Text & ")"
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()
        'create_row_estado_cliente(txtCustomerID.Text, cdec(txtMontoCobrar.Text), "RECIBOCOBROCXC", fld_id_prestamo.Text, description)
    End Sub

    Private Sub BORRAR_PRESTAMO()
        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "DELETE FROM tbl_prestamos WHERE fld_id_prestamos=" & fld_cod_prestamo.Text & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()
    End Sub

    Private Sub BORRAR_CUOTAS()
        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "DELETE FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()
    End Sub

    Private Function UPDATE_CUOTA(ByVal ID_CUOTA As String, ByVal monto As Double) As Double
        Dim CMD As New MySqlCommand
        With CMD
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_cuotas SET fld_abono_cuotas=fld_abono_cuotas+" & monto & ", fld_balance_cuotas=fld_balance_cuotas-" & monto & ", fld_fecha_ultimo_abono_cuotas='" & formatDate(Now.Date) & "' WHERE fld_id_cuotas=" & ID_CUOTA & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        CMD.Dispose()
        '
        Dim CMD1 As New MySqlCommand, CAPITAL As Double
        With CMD1
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT fld_capital_cuota FROM tbl_cuotas  WHERE fld_id_cuotas=" & ID_CUOTA & ""
            CAPITAL = .ExecuteScalar
            .Connection.Close()
        End With
        CMD1.Dispose()
        Return CAPITAL
    End Function

    Private Function BCE_CUOTA(ByVal ID_CUOTA As String) As Double

        Dim CMD1 As New MySqlCommand, CAPITAL As Double
        With CMD1
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT fld_balance_cuotas FROM tbl_cuotas  WHERE fld_id_cuotas=" & ID_CUOTA & ""
            CAPITAL = .ExecuteScalar
            .Connection.Close()
        End With
        CMD1.Dispose()
        BCE_CUOTA = CAPITAL
    End Function

    Private Function RETURN_NO_CUOTA(ByVal ID_CUOTA As String) As String

        Dim CMD1 As New MySqlCommand, CAPITAL As String
        With CMD1
            .Connection = conn
            .Connection.Open()
            .CommandText = "SELECT fld_no_cuotas FROM tbl_cuotas  WHERE fld_id_cuotas=" & ID_CUOTA & ""
            CAPITAL = .ExecuteScalar
            .Connection.Close()
        End With
        CMD1.Dispose()
        Return CAPITAL
    End Function

    Private Sub txtId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtId.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(txtId.Text) <> "" Then
                LOAD_DATA_CLIENTE(CInt(txtId.Text))
            End If
        End If
    End Sub

    'Private Sub fld_fecha_entrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_fecha_entrega.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        fld_porciento.Focus()
    '    End If
    'End Sub

    Private Sub fld_monto_prestamo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_monto_prestamo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CDec(Trim(fld_monto_prestamo.Text)) > 0 Then
                Dim amount As Decimal = CType(fld_monto_prestamo.Text, Decimal)
                Me.fld_monto_prestamo.Text = String.Format("{0:n2}", amount)
                fld_cantidad_cuotas.Focus()
            End If
        End If
    End Sub

    Private Sub fld_monto_prestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_monto_prestamo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            LOAD_DATA_CLIENTE(Id)
        End If
    End Sub

    Private Sub fld_cantidad_cuotas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_cantidad_cuotas.KeyDown
        If e.KeyCode = Keys.Enter Then
            CREAR()
        End If
    End Sub

    Private Sub fld_cantidad_cuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_cantidad_cuotas.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        CLEAR_ALL_DATA()

    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        CREAR()

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

        Me.Close()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        If btnProcesar.Enabled = True Then
            Alerta("Debe buscar el documento que desea borrar")
            Exit Sub
        End If

        If SCALAR_NUM("SELECT SUM(fld_abono_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & "") > 0 Then
            Alerta("El documento ya tiene abono realizado, por tanto no puede ser anulado")
            Exit Sub
        End If

        If FRMS_CLAVE_MAESTRA("Borrar") = True Then
            If Alerta("Está a punto de borrar el préstamo sin posibilidad de recuperarlo" & Chr(13) & Chr(13) & "¿Desea continuar?") = True Then
                BORRAR_CUOTAS()
                BORRAR_PRESTAMO()
                InterfarContableAutomatico("Cuenta por Cobrar", "Anular Préstamo", fld_fecha_entrega.Value.Date, CDec(fld_monto_prestamo.Text), fld_cod_prestamo.Text, "Anulación de Préstamo")
                create_row_estado_cliente(txtId.Text, CDec(txtBalancePrestamo.Text), "DEVOLUCION_PRESTAMOS", fld_cod_prestamo.Text, "Anulación de Préstamo", formatDate(fld_fecha_entrega.Value.Date))
                CLEAR_ALL_DATA()
            End If
        End If

    End Sub

    Private Sub fld_cod_prestamo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_cod_prestamo.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Trim(fld_cod_prestamo.Text) <> "" Then
                CargarPrestamos(fld_cod_prestamo.Text)
            End If
        End If

    End Sub

    Private Sub fld_cod_prestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_cod_prestamo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_cod_zona_prestamos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub fld_tipo_prestamo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub fld_interes_adelantado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub btn_nuevo_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo_cliente.Click
        Dim f As New FRM_CLIENTES
        f.ShowDialog()
        f.Dispose()
        If Alerta("¿Desea cargar los datos del último socio creado?") = True Then
            LOAD_DATA_CLIENTE(UltimoID("tbl_clientes", "fld_id"))
        End If
    End Sub

    Private Sub fld_porciento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_porciento.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_anos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_porciento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_porciento.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(fld_porciento.Text) <> "" Then
                If CDec(fld_porciento.Text) > 0 Then
                    fld_cantidad_cuotas.Focus()

                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Alerta(Format(Math.Round(cdec(fld_monto_prestamo.Text)), "C2"))
        FRMS_RECIBO_INGRESO(txtId.Text)
    End Sub

    Private Sub fld_tipo_prestamo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fld_tipo_prestamo.SelectedValueChanged
        If fld_tipo_prestamo.Text = "INT. DIAS" Then
            fld_cantidad_cuotas.Text = 1
            fld_cantidad_cuotas.ReadOnly = True
        Else
            fld_cantidad_cuotas.ReadOnly = False
        End If
    End Sub

    Private Sub fld_tipo_prestamo_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_tipo_prestamo.KeyPress
        e.Handled = True
    End Sub

    Private Sub fld_tipo_garantia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private WithEvents docToPrint As New Printing.PrintDocument

    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime.Click

        '
        Id = fld_cod_prestamo.Text
        AllReportSinFecha("Recibo de Prestamos")
        Exit Sub
        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        PrintDialog1.Document = docToPrint

        Dim result As DialogResult = PrintDialog1.ShowDialog()



        ' If the result is OK then print the document.
        If (result = Windows.Forms.DialogResult.OK) Then

            Dim pd As New PrintDocument, strOldPrinter As String
            strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print 


            Dim WshNetwork As Object
            WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
            WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName) 'Set the Default Print 


            Dim ds As New DataSet

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_clientes_con_prestamos WHERE fld_id_prestamos=" & fld_cod_prestamo.Text & "", conn)
            daP1.Fill(ds, "view_clientes_con_prestamos")


            Dim Report As New RPT_RECIBO_PRESTAMO
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, 0, 0)


            WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print
        End If

    End Sub

    Private Sub fldMontoInicial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fldMontoAdicional_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fldCodInm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fldCantMetros_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fldPrecioMetro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fldFinanciamiento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub fldTazaMora_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fldTazaMora.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_tipo_prestamo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_tipo_prestamo.SelectedIndexChanged
        'lblTasaInteres.Text = "Tasa de Interes " & fld_tipo_prestamo.Text
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificaNota.Click
        NON_QUERY("UPDATE tbl_prestamos SET fldNota='" & txtNotaGeneral.Text & "' WHERE fld_id_prestamos=" & CInt(fld_cod_prestamo.Text) & "")
    End Sub

    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub txtCuotasAgregar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_clasificacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_clasificacion.SelectedIndexChanged

    End Sub

    Private Sub fld_clasificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_clasificacion.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnListaPrestamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaPrestamos.Click
        If FRMS_LIST_PRESTAMOS() = True Then

            CargarPrestamos(Id)
        End If
    End Sub

    Private Sub fld_cantidad_cuotas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_cantidad_cuotas.TextChanged

    End Sub


    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click
        If btnProcesar.Enabled = True Then
            Alerta("Debe buscar el préstamo al cual desea modificar la Mora")
            Exit Sub
        End If

        NON_QUERY("UPDATE tbl_prestamos set fldTazaMora=" & fldTazaMora.Text & " WHERE fld_id_prestamos=" & CInt(fld_cod_prestamo.Text) & "")
        Alerta("Mora modificada")

    End Sub


    Private Sub btnAgregarCuotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCuotas.Click
        Dim i

        Dim IdCuotaCapital = SCALAR_NUM("SELECT MAX(fld_id_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & " AND fld_fecha_termina_cuotas=(SELECT MAX(fld_fecha_termina_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & ")")

        Dim cuota_no As Integer = SCALAR_NUM("SELECT MAX(fld_no_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & "")
        cuota_no = cuota_no - 1

        Dim count As Integer = 0
        fld_fecha_entrega.Value = CDate(SCALAR_STRING("SELECT MAX(fld_fecha_termina_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & ""))

        Dim fechas As Date = fld_fecha_entrega.Value.Date

        Dim interes As Double = SCALAR_NUM("SELECT fld_interes_cuota FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & " AND fld_fecha_termina_cuotas=(SELECT MAX(fld_fecha_termina_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & ")")

        Dim capital As Double = SCALAR_NUM("SELECT fld_capital_cuota FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & " AND fld_fecha_termina_cuotas=(SELECT MAX(fld_fecha_termina_cuotas) FROM tbl_cuotas WHERE fld_id_del_prestamo=" & fld_cod_prestamo.Text & ")")

        Dim clasificacion As String = SCALAR_NUM("SELECT fld_clasificacion FROM tbl_prestamos WHERE fld_id_prestamos=" & fld_cod_prestamo.Text & "")

        For i = 1 To CInt(txtCuotasAgregar.Text)
            cuota_no = cuota_no + 1
            If clasificacion = "" Then
                CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), 0, interes, 0, 0)
            Else
                CREA_CUOTAS(formatDate(fechas), Format(cuota_no, "000"), capital, interes, 0, 0)

            End If

            fechas = fld_fecha_entrega.Value.AddMonths(i)

        Next
        Dim FECHA As String = SCALAR_STRING("SELECT DATE(NOW())")
        create_row_estado_cliente(txtId.Text, CDec(interes) * CInt(txtCuotasAgregar.Text), "NDCXC", fld_cod_prestamo.Text, "AGREGANDO CUOTAS DE INTERES ADELANTADO", FECHA)

        fechas = fld_fecha_entrega.Value.AddMonths(CInt(txtCuotasAgregar.Text))
        cuota_no = cuota_no + 1
        NON_QUERY("UPDATE tbl_cuotas SET fld_fecha_termina_cuotas='" & formatDate(fechas) & "', fld_no_cuotas='" & Format(cuota_no, "000") & "' WHERE fld_id_cuotas=" & IdCuotaCapital & "")
        CargarCuotas(fld_cod_prestamo.Text)
    End Sub

    Private Sub fld_porciento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_porciento.TextChanged

    End Sub

    Private Sub fld_porciento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles fld_porciento.GotFocus
        fld_porciento.SelectAll()
    End Sub


    Private Sub fld_monto_prestamo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles fld_monto_prestamo.GotFocus
        fld_monto_prestamo.SelectAll()
    End Sub

    Private Sub fld_cantidad_cuotas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles fld_cantidad_cuotas.GotFocus
        fld_cantidad_cuotas.SelectAll()
    End Sub


    Private Sub txtMontoCuota_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoCuota.KeyDown
        If e.KeyData = Keys.Enter Then

            Dim montoCuotaCapital As Decimal = CDec(fld_monto_prestamo.Text) / CDec(fld_cantidad_cuotas.Text) 'monto del capital de cada cuota

            Dim montoInteres As Decimal = CDec(txtMontoCuota.Text) - montoCuotaCapital 'monto de interes de cada cuota
            fld_porciento.Text = (montoInteres / CDec(fld_monto_prestamo.Text)) * 100
            Dim amount1 As Decimal = CType(fld_porciento.Text, Decimal)
            Me.fld_porciento.Text = String.Format("{0:n6}", amount1)

            Dim amount As Decimal = CType(txtMontoCuota.Text, Decimal)
            Me.txtMontoCuota.Text = String.Format("{0:n2}", amount)
        End If
    End Sub


    Private Sub txtMontoCuota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoCuota.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub fld_fecha_entrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_fecha_entrega.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub fldTazaMora_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fldTazaMora.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub GastoLegalTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GastoLegalTxt.KeyPress
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

    Private Sub fldTazaMora_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fldTazaMora.TextChanged

    End Sub


    Private Sub GastoLegalTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GastoLegalTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control

            Dim amount As Decimal = CType(GastoLegalTxt.Text, Decimal)
            Me.GastoLegalTxt.Text = String.Format("{0:n2}", amount)


            SumarMontoGastoSeguro()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub


    Private Sub SeguroTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SeguroTxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control

            Dim amount As Decimal = CType(SeguroTxt.Text, Decimal)
            Me.SeguroTxt.Text = String.Format("{0:n2}", amount)


        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub fld_fecha_entrega_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_fecha_entrega.ValueChanged

    End Sub



    Private Sub MontoSolicitadoTxt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MontoSolicitadoTxt.KeyDown
        If e.KeyCode = Keys.Enter Then

            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'For Select Next Control

            Dim amount As Decimal = CType(MontoSolicitadoTxt.Text, Decimal)
            Me.MontoSolicitadoTxt.Text = String.Format("{0:n2}", amount)

        End If

    End Sub



    Private Sub MontoSolicitadoTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MontoSolicitadoTxt.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_monto_prestamo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_monto_prestamo.TextChanged

    End Sub

    Private Sub MontoSolicitadoTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MontoSolicitadoTxt.TextChanged

    End Sub

    Private Sub SeguroTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeguroTxt.TextChanged

    End Sub

    Private Sub GastoLegalTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GastoLegalTxt.TextChanged

    End Sub

    Private Sub cmbTipoPrestamos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTipoPrestamos.SelectedValueChanged
        If Not IsNothing(cmbTipoPrestamos.SelectedValue) Then
            lblNoCtaIngresos.Text = cmbTipoPrestamos.SelectedValue.ToString
            ''btnCambiarTipoPrestamo.Visible = False
        Else
            cmbTipoPrestamos.Text = String.Empty
            lblNoCtaIngresos.Text = "N/D"
            ''btnCambiarTipoPrestamo.Visible = True
        End If
    End Sub

    Private Sub btnCambiarTipoPrestamo_Click(sender As Object, e As EventArgs) Handles btnCambiarTipoPrestamo.Click
        If lblNoCtaIngresos.Text = "N/D" Then
            Alerta("Favor Seleccionar Tipo Prestamos")
        Else
            NON_QUERY("UPDATE tbl_prestamos set CtaIngreso='" & cmbTipoPrestamos.SelectedValue & "' WHERE fld_id_prestamos=" & CInt(fld_cod_prestamo.Text) & "")
            Alerta("Cuenta de ingresos agregada")
            btnCambiarTipoPrestamo.Visible = False
        End If
    End Sub
End Class
