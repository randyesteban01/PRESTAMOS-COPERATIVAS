Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing
Imports System.IO
Public Class FRM_MAESTRO_CKS

    Inherits System.Windows.Forms.Form
    Dim id_entrada As Integer
    Dim ds_nc As DataSet
    Dim ds_detalle As New DataSet
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
    Friend WithEvents fld_monto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fld_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FLD_BALANCE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FLD_CUENTA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FLD_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FLD_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents fld_id_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents fld_cantidad_letra As System.Windows.Forms.TextBox
    Friend WithEvents fld_ck_no As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fld_codigo_transacion As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents fld_id_ck As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents fld_codigo_beneficiario As System.Windows.Forms.TextBox
    Friend WithEvents fld_tipo_beneficiario As System.Windows.Forms.ComboBox
    Friend WithEvents fld_bce_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DG_NC As System.Windows.Forms.DataGrid
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents fld_id_banco As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents fld_aplicar_pagos As System.Windows.Forms.TextBox
    Friend WithEvents fld_beneficiario As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents fld_solicitud_no As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btn_procesar As System.Windows.Forms.Button
    Friend WithEvents btnAnula As System.Windows.Forms.Button
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Friend WithEvents fld_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContable As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_MAESTRO_CKS))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.fld_monto = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.fld_descripcion = New System.Windows.Forms.TextBox
        Me.fld_date = New System.Windows.Forms.DateTimePicker
        Me.txtCuentaContable = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.FLD_BALANCE = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.FLD_CUENTA = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.FLD_NOMBRE = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.FLD_CODIGO = New System.Windows.Forms.TextBox
        Me.fld_id_proveedor = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.fld_cantidad_letra = New System.Windows.Forms.TextBox
        Me.fld_ck_no = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.fld_codigo_transacion = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.fld_id_ck = New System.Windows.Forms.TextBox
        Me.fld_codigo_beneficiario = New System.Windows.Forms.TextBox
        Me.fld_tipo_beneficiario = New System.Windows.Forms.ComboBox
        Me.fld_bce_proveedor = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.DG_NC = New System.Windows.Forms.DataGrid
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.fld_id_banco = New System.Windows.Forms.TextBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Label14 = New System.Windows.Forms.Label
        Me.fld_aplicar_pagos = New System.Windows.Forms.TextBox
        Me.fld_beneficiario = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.fld_solicitud_no = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnAnula = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btn_procesar = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.btnImprime = New System.Windows.Forms.Button
        CType(Me.DG_NC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'fld_monto
        '
        Me.fld_monto.BackColor = System.Drawing.Color.White
        Me.fld_monto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_monto.Location = New System.Drawing.Point(482, 88)
        Me.fld_monto.Name = "fld_monto"
        Me.fld_monto.Size = New System.Drawing.Size(136, 20)
        Me.fld_monto.TabIndex = 4
        Me.fld_monto.Text = "0.00"
        Me.fld_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Concepto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_descripcion
        '
        Me.fld_descripcion.BackColor = System.Drawing.Color.White
        Me.fld_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_descripcion.Location = New System.Drawing.Point(80, 184)
        Me.fld_descripcion.MaxLength = 53
        Me.fld_descripcion.Name = "fld_descripcion"
        Me.fld_descripcion.Size = New System.Drawing.Size(536, 20)
        Me.fld_descripcion.TabIndex = 6
        Me.fld_descripcion.Text = ""
        '
        'fld_date
        '
        Me.fld_date.CustomFormat = "dd / MMM / yyyy"
        Me.fld_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_date.Location = New System.Drawing.Point(482, 64)
        Me.fld_date.Name = "fld_date"
        Me.fld_date.Size = New System.Drawing.Size(136, 20)
        Me.fld_date.TabIndex = 3
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.BackColor = System.Drawing.SystemColors.Control
        Me.txtCuentaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContable.Location = New System.Drawing.Point(632, 128)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.ReadOnly = True
        Me.txtCuentaContable.Size = New System.Drawing.Size(136, 20)
        Me.txtCuentaContable.TabIndex = 34
        Me.txtCuentaContable.Text = ""
        Me.txtCuentaContable.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(632, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Cta. Cont."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'FLD_BALANCE
        '
        Me.FLD_BALANCE.BackColor = System.Drawing.SystemColors.Control
        Me.FLD_BALANCE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_BALANCE.Location = New System.Drawing.Point(288, 88)
        Me.FLD_BALANCE.Name = "FLD_BALANCE"
        Me.FLD_BALANCE.ReadOnly = True
        Me.FLD_BALANCE.Size = New System.Drawing.Size(104, 20)
        Me.FLD_BALANCE.TabIndex = 21
        Me.FLD_BALANCE.Text = "0.00"
        Me.FLD_BALANCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(241, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Balance"
        '
        'FLD_CUENTA
        '
        Me.FLD_CUENTA.BackColor = System.Drawing.SystemColors.Control
        Me.FLD_CUENTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_CUENTA.Location = New System.Drawing.Point(80, 88)
        Me.FLD_CUENTA.Name = "FLD_CUENTA"
        Me.FLD_CUENTA.ReadOnly = True
        Me.FLD_CUENTA.Size = New System.Drawing.Size(136, 20)
        Me.FLD_CUENTA.TabIndex = 25
        Me.FLD_CUENTA.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-18, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cta. Bancaria"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FLD_NOMBRE
        '
        Me.FLD_NOMBRE.BackColor = System.Drawing.SystemColors.Control
        Me.FLD_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_NOMBRE.Location = New System.Drawing.Point(80, 64)
        Me.FLD_NOMBRE.Name = "FLD_NOMBRE"
        Me.FLD_NOMBRE.ReadOnly = True
        Me.FLD_NOMBRE.Size = New System.Drawing.Size(312, 20)
        Me.FLD_NOMBRE.TabIndex = 24
        Me.FLD_NOMBRE.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(-18, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(392, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Fecha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FLD_CODIGO
        '
        Me.FLD_CODIGO.BackColor = System.Drawing.Color.White
        Me.FLD_CODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_CODIGO.Location = New System.Drawing.Point(80, 40)
        Me.FLD_CODIGO.Name = "FLD_CODIGO"
        Me.FLD_CODIGO.ReadOnly = True
        Me.FLD_CODIGO.Size = New System.Drawing.Size(95, 20)
        Me.FLD_CODIGO.TabIndex = 23
        Me.FLD_CODIGO.Text = ""
        '
        'fld_id_proveedor
        '
        Me.fld_id_proveedor.BackColor = System.Drawing.Color.White
        Me.fld_id_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_id_proveedor.Location = New System.Drawing.Point(624, 296)
        Me.fld_id_proveedor.Name = "fld_id_proveedor"
        Me.fld_id_proveedor.ReadOnly = True
        Me.fld_id_proveedor.Size = New System.Drawing.Size(56, 20)
        Me.fld_id_proveedor.TabIndex = 53
        Me.fld_id_proveedor.Text = "0"
        Me.fld_id_proveedor.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(-18, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Beneficiario"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_cantidad_letra
        '
        Me.fld_cantidad_letra.BackColor = System.Drawing.Color.White
        Me.fld_cantidad_letra.Location = New System.Drawing.Point(80, 136)
        Me.fld_cantidad_letra.Name = "fld_cantidad_letra"
        Me.fld_cantidad_letra.ReadOnly = True
        Me.fld_cantidad_letra.Size = New System.Drawing.Size(536, 20)
        Me.fld_cantidad_letra.TabIndex = 19
        Me.fld_cantidad_letra.Text = ""
        '
        'fld_ck_no
        '
        Me.fld_ck_no.BackColor = System.Drawing.Color.White
        Me.fld_ck_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ck_no.Location = New System.Drawing.Point(482, 40)
        Me.fld_ck_no.Name = "fld_ck_no"
        Me.fld_ck_no.Size = New System.Drawing.Size(136, 20)
        Me.fld_ck_no.TabIndex = 2
        Me.fld_ck_no.Text = "0"
        Me.fld_ck_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(392, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Ck. No."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(400, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Monto"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Banco ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_codigo_transacion
        '
        Me.fld_codigo_transacion.BackColor = System.Drawing.SystemColors.Control
        Me.fld_codigo_transacion.Location = New System.Drawing.Point(632, 168)
        Me.fld_codigo_transacion.Name = "fld_codigo_transacion"
        Me.fld_codigo_transacion.ReadOnly = True
        Me.fld_codigo_transacion.Size = New System.Drawing.Size(136, 20)
        Me.fld_codigo_transacion.TabIndex = 16
        Me.fld_codigo_transacion.Text = ""
        Me.fld_codigo_transacion.Visible = False
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(624, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 16)
        Me.Label19.TabIndex = 117
        Me.Label19.Text = "Cod. trans."
        Me.Label19.Visible = False
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(-42, 136)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 16)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Cant. letras"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_id_ck
        '
        Me.fld_id_ck.BackColor = System.Drawing.Color.White
        Me.fld_id_ck.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_id_ck.Location = New System.Drawing.Point(632, 16)
        Me.fld_id_ck.Name = "fld_id_ck"
        Me.fld_id_ck.ReadOnly = True
        Me.fld_id_ck.Size = New System.Drawing.Size(104, 20)
        Me.fld_id_ck.TabIndex = 125
        Me.fld_id_ck.Text = "0"
        Me.fld_id_ck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_id_ck.Visible = False
        '
        'fld_codigo_beneficiario
        '
        Me.fld_codigo_beneficiario.Location = New System.Drawing.Point(632, 200)
        Me.fld_codigo_beneficiario.Name = "fld_codigo_beneficiario"
        Me.fld_codigo_beneficiario.ReadOnly = True
        Me.fld_codigo_beneficiario.Size = New System.Drawing.Size(72, 20)
        Me.fld_codigo_beneficiario.TabIndex = 127
        Me.fld_codigo_beneficiario.Text = ""
        Me.fld_codigo_beneficiario.Visible = False
        '
        'fld_tipo_beneficiario
        '
        Me.fld_tipo_beneficiario.Items.AddRange(New Object() {"General", "Proveedores"})
        Me.fld_tipo_beneficiario.Location = New System.Drawing.Point(400, 160)
        Me.fld_tipo_beneficiario.Name = "fld_tipo_beneficiario"
        Me.fld_tipo_beneficiario.Size = New System.Drawing.Size(104, 21)
        Me.fld_tipo_beneficiario.TabIndex = 29
        Me.fld_tipo_beneficiario.Text = "General"
        Me.fld_tipo_beneficiario.Visible = False
        '
        'fld_bce_proveedor
        '
        Me.fld_bce_proveedor.BackColor = System.Drawing.Color.White
        Me.fld_bce_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_bce_proveedor.Location = New System.Drawing.Point(528, 160)
        Me.fld_bce_proveedor.Name = "fld_bce_proveedor"
        Me.fld_bce_proveedor.ReadOnly = True
        Me.fld_bce_proveedor.Size = New System.Drawing.Size(90, 20)
        Me.fld_bce_proveedor.TabIndex = 31
        Me.fld_bce_proveedor.Text = "0.00"
        Me.fld_bce_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(504, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 16)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Bce."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(624, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 133
        Me.Button1.Text = "Aplicar pago"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Visible = False
        '
        'DG_NC
        '
        Me.DG_NC.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.DG_NC.CaptionVisible = False
        Me.DG_NC.DataMember = ""
        Me.DG_NC.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG_NC.Location = New System.Drawing.Point(80, 280)
        Me.DG_NC.Name = "DG_NC"
        Me.DG_NC.Size = New System.Drawing.Size(536, 96)
        Me.DG_NC.TabIndex = 135
        Me.DG_NC.Visible = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(-10, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 136
        Me.Label13.Text = "Documentos"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Visible = False
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(624, 320)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 23)
        Me.Button4.TabIndex = 137
        Me.Button4.Text = "Deshacer"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(178, 38)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 24)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "&List. Banco"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_id_banco
        '
        Me.fld_id_banco.Location = New System.Drawing.Point(632, 56)
        Me.fld_id_banco.Name = "fld_id_banco"
        Me.fld_id_banco.Size = New System.Drawing.Size(56, 20)
        Me.fld_id_banco.TabIndex = 145
        Me.fld_id_banco.Text = "0"
        Me.fld_id_banco.Visible = False
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(736, 304)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(336, 80)
        Me.DataGrid1.TabIndex = 146
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(632, 256)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 148
        Me.Label14.Text = "Pago a Fact."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Visible = False
        '
        'fld_aplicar_pagos
        '
        Me.fld_aplicar_pagos.BackColor = System.Drawing.Color.White
        Me.fld_aplicar_pagos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_aplicar_pagos.Location = New System.Drawing.Point(624, 272)
        Me.fld_aplicar_pagos.Name = "fld_aplicar_pagos"
        Me.fld_aplicar_pagos.Size = New System.Drawing.Size(88, 20)
        Me.fld_aplicar_pagos.TabIndex = 147
        Me.fld_aplicar_pagos.Text = "0.00"
        Me.fld_aplicar_pagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_aplicar_pagos.Visible = False
        '
        'fld_beneficiario
        '
        Me.fld_beneficiario.Location = New System.Drawing.Point(80, 160)
        Me.fld_beneficiario.Name = "fld_beneficiario"
        Me.fld_beneficiario.Size = New System.Drawing.Size(312, 21)
        Me.fld_beneficiario.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(4, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(811, 24)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "CHEQUE DEL BANCO "
        '
        'fld_solicitud_no
        '
        Me.fld_solicitud_no.BackColor = System.Drawing.Color.White
        Me.fld_solicitud_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_solicitud_no.Location = New System.Drawing.Point(328, 40)
        Me.fld_solicitud_no.Name = "fld_solicitud_no"
        Me.fld_solicitud_no.Size = New System.Drawing.Size(64, 20)
        Me.fld_solicitud_no.TabIndex = 1
        Me.fld_solicitud_no.Text = "0"
        Me.fld_solicitud_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(256, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 32)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Solicitud. No."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(216, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 56)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "&Consultar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnAnula
        '
        Me.btnAnula.BackColor = System.Drawing.SystemColors.Control
        Me.btnAnula.Enabled = False
        Me.btnAnula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnAnula.ForeColor = System.Drawing.Color.Black
        Me.btnAnula.Image = CType(resources.GetObject("btnAnula.Image"), System.Drawing.Image)
        Me.btnAnula.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAnula.Location = New System.Drawing.Point(360, 208)
        Me.btnAnula.Name = "btnAnula"
        Me.btnAnula.Size = New System.Drawing.Size(72, 56)
        Me.btnAnula.TabIndex = 32
        Me.btnAnula.Text = "&Anular"
        Me.btnAnula.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(544, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 56)
        Me.Button3.TabIndex = 11
        Me.Button3.TabStop = False
        Me.Button3.Text = "&Cerrar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_procesar
        '
        Me.btn_procesar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_procesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btn_procesar.ForeColor = System.Drawing.Color.Black
        Me.btn_procesar.Image = CType(resources.GetObject("btn_procesar.Image"), System.Drawing.Image)
        Me.btn_procesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_procesar.Location = New System.Drawing.Point(144, 208)
        Me.btn_procesar.Name = "btn_procesar"
        Me.btn_procesar.Size = New System.Drawing.Size(72, 56)
        Me.btn_procesar.TabIndex = 7
        Me.btn_procesar.TabStop = False
        Me.btn_procesar.Text = "&Guardar"
        Me.btn_procesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(72, 208)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 56)
        Me.Button5.TabIndex = 8
        Me.Button5.TabStop = False
        Me.Button5.Text = "&Nuevo"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprime.Enabled = False
        Me.btnImprime.ForeColor = System.Drawing.Color.Black
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprime.Location = New System.Drawing.Point(288, 208)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(72, 56)
        Me.btnImprime.TabIndex = 10
        Me.btnImprime.Text = "&Imprimir"
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FRM_MAESTRO_CKS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(626, 268)
        Me.Controls.Add(Me.btnImprime)
        Me.Controls.Add(Me.btnAnula)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_procesar)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fld_id_ck)
        Me.Controls.Add(Me.fld_solicitud_no)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.fld_beneficiario)
        Me.Controls.Add(Me.fld_bce_proveedor)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.fld_aplicar_pagos)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.fld_id_banco)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DG_NC)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.fld_codigo_beneficiario)
        Me.Controls.Add(Me.fld_cantidad_letra)
        Me.Controls.Add(Me.fld_codigo_transacion)
        Me.Controls.Add(Me.fld_ck_no)
        Me.Controls.Add(Me.fld_id_proveedor)
        Me.Controls.Add(Me.fld_monto)
        Me.Controls.Add(Me.fld_descripcion)
        Me.Controls.Add(Me.txtCuentaContable)
        Me.Controls.Add(Me.FLD_BALANCE)
        Me.Controls.Add(Me.FLD_CUENTA)
        Me.Controls.Add(Me.FLD_NOMBRE)
        Me.Controls.Add(Me.FLD_CODIGO)
        Me.Controls.Add(Me.fld_tipo_beneficiario)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fld_date)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_MAESTRO_CKS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de Cheque"
        CType(Me.DG_NC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub RellenaBeneficiario()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT fld_id, fld_beneficiario FROM tbl_beneficiarios ORDER BY fld_beneficiario", conn)
        da.Fill(dt)

        fld_beneficiario.DataSource = dt
        fld_beneficiario.DisplayMember = "fld_beneficiario"
        fld_beneficiario.ValueMember = "fld_id"

        da.Dispose()

    End Sub

    Private Sub FRM_MAESTRO_CKS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        If Me.Text = "Maestro de Cheques (SOLICITUD)" Then
            btn_procesar.Text = "&Guardar"
        End If

        fld_id_proveedor.Text = "0"
        RellenaBeneficiario()

    End Sub
    Private Function VALIDA_DATA() As Boolean

        If FLD_CODIGO.Text = "" Then
            Alerta("Faltan los datos del Banco")
            Return False
        End If
        If Trim(fld_descripcion.Text) = "" Then
            fld_descripcion.Focus()
            Alerta("Falta la descripcion")
            Return False
        End If
        If Trim(fld_monto.Text) = "" Or CDbl(fld_monto.Text) = 0 Then
            fld_monto.Focus()
            Alerta("Falta el monto")
            Return False

        End If
        If Trim(fld_beneficiario.Text) = "" Then
            fld_beneficiario.Focus()
            Alerta("Falta los datos del beneficiario")
            Return False
        End If
        If Trim(fld_ck_no.Text) = "" Or Val(fld_ck_no.Text) = 0 Then
            Alerta("Falta el No. de cheque")
            fld_ck_no.Focus()
            Return False
        End If


        Return True

    End Function
    Private Sub ANULA_CK(ByVal id_ck As String)
        NON_QUERY("UPDATE tbl_cheques SET fld_estado='NULO', fld_concepto=CONCAT('NULO ',fld_concepto), fld_transito='NO' WHERE fld_id_doc=" & id_ck & "")
        NON_QUERY("UPDATE tbl_estado_banco SET fld_dr=0, fld_cr=0, fld_description=CONCAT('NULO ',fld_description) WHERE fld_banco_id='" & FLD_CODIGO.Text & "' AND fld_tipo_doc='CK' AND fld_tipo_doc_id='" & fld_ck_no.Text & "'")
        Dim idTrasacion As Integer = SCALAR_NUM("SELECT fld_id_entrada FROM tbl_cheques WHERE fld_id_doc=" & id_ck & "")
        NON_QUERY("CALL cont_delete_trans(" & idTrasacion & ");")
    End Sub
    Private Sub SAVE_DOC(ByVal TableName As String)

       
        Dim estado As String = "EMISION"
        id_entrada = UltimoID("tbl_interfascontabletransacciones", "TransID")

        NON_QUERY("INSERT INTO " & TableName & " (fld_ck_no, fld_id_banco, fld_fecha, fld_concepto, fld_monto, fld_estado, fld_cta_axu_id, fld_beneficiario, fld_monto_letras,  fld_id_entrada, fld_transito) VALUES(" & CInt(fld_ck_no.Text) & ",'" & FLD_CODIGO.Text & "','" & formatDate(fld_date.Value.Date) & "','" & fld_descripcion.Text & "'," & CDbl(fld_monto.Text) & ",'" & estado & "', " & fld_id_proveedor.Text & ",'" & fld_beneficiario.Text & "','" & fld_cantidad_letra.Text & "'," & id_entrada & ",'SI')")

        create_cod_ck(FLD_CUENTA.Text)
    End Sub
    Private Sub UPDATE_DOC(ByVal id_ck As Integer)
        NON_QUERY("UPDATE tbl_cheques SET fld_ck_no=" & CInt(fld_ck_no.Text) & ",fld_fecha='" & formatDate(fld_date.Value.Date) & "', fld_beneficiario='" & fld_beneficiario.Text & "',  fld_concepto='" & fld_descripcion.Text & "'  WHERE fld_id_doc=" & id_ck & "")
    End Sub
    Private Sub UPDATE_SOLICITUD_TO_CK(ByVal id_ck As String)
        NON_QUERY("UPDATE tbl_cheques SET fld_fecha='" & formatDate(fld_date.Value.Date) & "', fld_estado='EMISION',  fld_ck_no=" & CInt(fld_ck_no.Text) & ", fld_cta_axu_id=" & CInt(fld_id_proveedor.Text) & " WHERE fld_id_doc=" & id_ck & "")
    End Sub
    Private Sub LOAD_DATA_BANCO(ByVal Valor As String)
        Label15.Text = String.Empty
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM TBL_BANCOS WHERE FLD_CODIGO='" & Valor & "'", conn)
        da.Fill(ds, "TBL_BANCOS")
        For Each dr In ds.Tables(0).Rows
            Label15.Text = Label15.Text & " " & dr("FLD_NOMBRE")
            FLD_CODIGO.Text = dr("FLD_CODIGO")
            FLD_NOMBRE.Text = dr("FLD_NOMBRE")
            FLD_CUENTA.Text = dr("FLD_CUENTA")
            txtCuentaContable.Text = dr("FLD_CTA_CONTABLE")
            FLD_BALANCE.Text = Format(dr("FLD_BALANCE"), "C2")
            fld_codigo_transacion.Text = dr("fld_tt_ck")
            fld_id_banco.Text = dr("fld_id")
            fld_monto.Focus()

            GoTo exite
        Next
        Alerta("El Documento no existe en la Base de Datos")

        ds.Dispose()
        da.Dispose()
        Exit Sub
exite:
        ds.Dispose()
        da.Dispose()
    End Sub ' LOAD DATA FROM DATA BASE "TBL_BANCO"
    Private Sub LOAD_DATA_CK(ByVal Valor As Integer)
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_cheques WHERE fld_id_doc=" & Valor & "", conn)
        da.Fill(ds, "tbl_cheques")

        Dim banco As String, proveedor As String
        For Each dr In ds.Tables(0).Rows
            fld_id_ck.Text = Valor
            banco = dr("fld_id_banco")
            proveedor = dr("fld_cta_axu_id")
            fld_date.Text = dr("fld_fecha")
            fld_descripcion.Text = dr("fld_concepto")
            fld_monto.Text = Format(dr("fld_monto"), "C2")
            fld_ck_no.Text = dr("fld_ck_no")
            fld_cantidad_letra.Text = dr("fld_monto_letras")
            fld_beneficiario.Text = dr("fld_beneficiario")
            id_entrada = dr("fld_id_entrada")
            fld_descripcion.Focus()
            btn_procesar.Text = "&Modificar"
            btnImprime.Enabled = True
            btnAnula.Enabled = True
            GoTo exite
        Next
        Alerta("EL DOCUMENTO SOLICITADO NO EXISTE EN LA BASE DE DATOS")

        ds.Dispose()
        da.Dispose()
        Exit Sub
exite:
        ds.Dispose()
        da.Dispose()

        LOAD_DATA_BANCO(banco)


    End Sub
    Private Sub LOAD_DATA_CK_SOLICITUD(ByVal Id_doc As Integer)
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_cheques_solicitud WHERE fld_id_doc=" & Id_doc & "", conn)
        da.Fill(ds, "tbl_cheques_solicitud")

        Dim banco As String, proveedor As String
        For Each dr In ds.Tables(0).Rows
            ' fld_id_ck.Text = Valor
            banco = dr("fld_id_banco")
            proveedor = dr("fld_cta_axu_id")
            fld_date.Text = dr("fld_fecha")
            fld_descripcion.Text = dr("fld_concepto")
            fld_monto.Text = Format(dr("fld_monto"), "C2")
            fld_ck_no.Text = dr("fld_ck_no")
            fld_cantidad_letra.Text = dr("fld_monto_letras")
            fld_beneficiario.Text = dr("fld_beneficiario")
            id_entrada = dr("fld_id_entrada")
            fld_descripcion.Focus()
        Next

        ds.Dispose()
        da.Dispose()

        LOAD_DATA_BANCO(banco)


    End Sub
    Private Sub SAVE_DATA()
        'fld_cantidad_letra.Text = Letras(fld_monto.Text).ToUpper
        If VALIDA_DATA() = False Then Exit Sub


        If Alerta("¿Seguro que desea procesar ese documento?") = False Then Exit Sub

        Dim idDocAfectado = CInt(UltimoID("tbl_cheques", "fld_id_doc") + 1)



        If fld_tipo_beneficiario.Text = "Proveedores" Then 'si el pago es a un proveedor
            Dim dr_fact As DataRow, dr_nd As DataRow


            If ds_nc.HasChanges = True Then
                For Each dr_nd In ds_nc.Tables("tbl_nc_cxp").Rows
                    SAVE_CHAGER_NC(dr_nd("fld_id"), dr_nd("fld_abono"), dr_nd("fld_balance"))
                    SAVE_DETALLE_PAGO(dr_nd("fld_id"), dr_nd("fld_ultimo_abono"), idDocAfectado, "NC_CXP")
                Next
            End If

            create_row_estado_proveedor(fld_codigo_beneficiario.Text, CDbl(fld_monto.Text), "CK", idDocAfectado, fld_descripcion.Text, fld_date.Value.Date)
        Else
            If CargarFrmInterfas(txtCuentaContable.Text, ReturnDescripcion(txtCuentaContable.Text), 0, CDbl(fld_monto.Text), idDocAfectado, "Cheque", fld_descripcion.Text, fld_date.Value, 0) = False Then
                Alerta("La operación ha sido cancelada por el usuario")
                Return
            End If
        End If

        SAVE_DOC("tbl_cheques")
        create_row_estado_banco(FLD_CODIGO.Text, CDbl(fld_monto.Text), "CK", fld_ck_no.Text, fld_descripcion.Text, fld_date.Value.Date)
        fld_id_ck.Text = idDocAfectado

        PrintCk(fld_id_ck.Text)

        CLEAR_FIELD()
    End Sub
    Private Sub CLEAR_FIELD()
        btn_procesar.Enabled = True
        fld_bce_proveedor.Text = "0.00"
        FLD_CODIGO.Text = String.Empty
        FLD_NOMBRE.Text = String.Empty
        FLD_CUENTA.Text = String.Empty
        txtCuentaContable.Text = String.Empty
        FLD_BALANCE.Text = "0.00"
        fld_descripcion.Text = String.Empty
        fld_monto.Text = "0.00"
        fld_beneficiario.Text = String.Empty
        fld_codigo_beneficiario.Text = "0"
        fld_cantidad_letra.Text = String.Empty
        fld_ck_no.Text = "0"
        fld_id_proveedor.Text = "0"
        Label15.Text = "CHEQUE DEL BANCO "
        btn_procesar.Text = "&Guardar"
        DG_NC.DataSource = Nothing
        btnImprime.Enabled = False
        btnAnula.Enabled = False
        fld_codigo_transacion.Text = "0"
        RellenaBeneficiario()
    End Sub
    Private Sub UPDATE_ID_ENTRADA_EN_CK(ByVal IDS_DOC As String, ByVal IDS_ENTRADA As String)
        NON_QUERY("UPDATE tbl_cheques SET fld_id_entrada = " & IDS_ENTRADA & " WHERE fld_id_doc =" & IDS_DOC & "")
    End Sub

    'DETALLE DE PAGO
    Private Sub CREA_DOC_DETALLE(ByVal cod_doc As Integer, ByVal ck_id As Integer, ByVal bce As Double, ByVal abono As Double, ByVal nuevo_bce As Double, ByVal tipo As String)
        NON_QUERY("INSERT INTO tbl_detalle_pago_ck (fld_cod_doc,fld_ck_id,fld_bce,fld_abono,fld_nuevo_bce,fld_tipo) VALUES(" & cod_doc & "," & ck_id & "," & bce & "," & abono & ", " & nuevo_bce & ",'" & tipo & "')")

    End Sub

    Private Sub DELECT_DOC_DETALLE(ByVal ID_DOC As String)
        NON_QUERY("DELETE FROM tbl_detalle_pago_ck WHERE fld_id_detalle=" & CInt(ID_DOC) & "")

    End Sub

    Private Sub BUSCA_DOC_DETALLE()
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_detalle_pago_ck WHERE fld_ck_id=" & fld_id_ck.Text & "", conn)
        da.Fill(ds, "tbl_detalle_pago_ck")
        For Each dr In ds.Tables(0).Rows
            If dr("fld_tipo") = "RECEPCIONES" Then
                ACTUALIZA_DOC_DETALLE("tbl_recepcion", "fldInvoiceID", dr("fld_cod_doc"), "fldAbono", dr("fld_abono"), "fld_Balance", dr("fld_nuevo_bce"))
            ElseIf dr("fld_tipo") = "FACTURAS" Then
                ACTUALIZA_DOC_DETALLE("tbl_nc_cxp_servicios", "fld_id", dr("fld_cod_doc"), "fld_abono", dr("fld_abono"), "fld_balance", dr("fld_nuevo_bce"))
            ElseIf dr("fld_tipo") = "NOTAS DE CREDITO" Then
                ACTUALIZA_DOC_DETALLE("tbl_nc_cxp", "fld_id_nc_cxp", dr("fld_cod_doc"), "fld_abono", dr("fld_abono"), "fld_balance", dr("fld_nuevo_bce"))
            End If
        Next

        da.Dispose()
        ds.Dispose()
    End Sub

    Private Sub ACTUALIZA_DOC_DETALLE(ByVal tbl_tabla As String, ByVal fld_id_doc As String, ByVal value_id_doc As String, ByVal fld_abono As String, ByVal value_abono As Double, ByVal fld_bce As String, ByVal value_bce As Double)
        NON_QUERY("UPDATE " & tbl_tabla & " SET " & fld_abono & "=" & fld_abono & "+" & value_abono & ", " & fld_bce & "=" & value_bce & " WHERE " & fld_id_doc & "=" & value_id_doc & "")
    End Sub

#Region "CHEQUE APLICADO A CXP"



    Private Sub SAVE_CHAGER_FACTURA(ByVal id_doc As String, ByVal abono As Double, ByVal bce As Double)

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_recepcion SET fld_Balance=" & bce & ", fldAbono=" & abono & "  WHERE  fldInvoiceID=" & id_doc & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd = Nothing
    End Sub
    Private Sub SAVE_CHAGER_NC(ByVal id_doc As String, ByVal abono As Double, ByVal bce As Double)

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_nc_cxp SET fld_balance=" & bce & ", fld_abono=" & abono & "  WHERE  fld_id=" & id_doc & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd = Nothing
    End Sub
    Private Sub SAVE_DETALLE_PAGO(ByVal id_doc As String, ByVal abono As Double, ByVal ck_no As Integer, ByVal tipo As String)

        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "INSERT INTO tbl_detalle_pago_ck SET fld_cod_doc=" & id_doc & ", fld_abono=" & abono & ", fld_ck_id=" & ck_no & ", fld_tipo='" & tipo & "'"
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd = Nothing
    End Sub

    Private Sub preview_pay()
        If CDbl(fld_aplicar_pagos.Text) > CDbl(fld_monto.Text) Then
            Alerta("No puede aplicar más dinero a las factura que el monto del cheque")
            fld_tipo_beneficiario.Text = "General"
            fld_codigo_beneficiario.Text = "0"

            DG_NC.DataSource = Nothing
            Exit Sub
        End If

        Dim monto = CDec(fld_aplicar_pagos.Text)
        Dim dr As DataRow

        For Each dr In ds_nc.Tables(0).Rows
            If dr("fld_chk") = "True" Then
                If monto >= dr("fld_balance") Then
                    dr("fld_ultimo_abono") = dr("fld_balance")
                    dr("fld_abono") = dr("fld_abono") + dr("fld_balance")
                    monto = monto - dr("fld_balance")
                    dr("fld_balance") = 0
                ElseIf monto < dr("fld_balance") Then
                    If monto = 0 Then
                        Exit Sub
                    End If
                    dr("fld_ultimo_abono") = monto
                    dr("fld_abono") = dr("fld_abono") + monto
                    dr("fld_balance") = dr("fld_balance") - monto
                    monto = monto - monto
                End If
            End If

        Next


    End Sub



    Private Sub LOAD_NC_CXP(ByVal ID_PROVEEDOR As String)

        Dim SQLSTRING As String
        SQLSTRING = "SELECT fld_id, fld_fecha, fld_monto, fld_abono, fld_balance, fld_chk, fld_ultimo_abono, fld_concepto FROM tbl_nc_cxp WHERE fld_proveedor_id_nc=" & ID_PROVEEDOR & " AND fld_balance > 0 AND fldstatus <> 'NULO'"
        StyleNC()


        ds_nc = New DataSet
        Dim da As New MySqlDataAdapter(SQLSTRING, conn)
        da.Fill(ds_nc, "tbl_nc_cxp")
        Dim dr As DataRow

        For Each dr In ds_nc.Tables(0).Rows
            fld_bce_proveedor.Text = Format(CDbl(fld_bce_proveedor.Text) + dr("fld_balance"), "C2")
        Next



        DG_NC.DataSource = ds_nc.Tables(0)

        Dim DataTable As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable = ds_nc.Tables(0)
        DataTable.DefaultView.AllowNew = False


    End Sub
    Private Sub StyleNC()
        DG_NC.TableStyles.Clear()

        ' Create a new DataGridTableStyle and set 
        ' its MappingName to the TableName of a DataTable. 

        Dim ts1 As New DataGridTableStyle
        ts1.GridLineColor = Color.Peru
        ts1.MappingName = "tbl_nc_cxp"


        ' Add a GridColumnStyle and set its MappingName 
        ' to the name of a DataColumn in the DataTable. 
        ' Set the HeaderText and Width properties. 
        Dim checkbox = New DataGridBoolColumn
        checkbox.MappingName = "fld_chk"
        checkbox.HeaderText = " "
        checkbox.Width = 20
        checkbox.FalseValue = ""
        checkbox.TrueValue = True
        checkbox.AllowNull = False
        checkbox.NullValue = ""
        ts1.GridColumnStyles.Add(checkbox)


        ' Add a second column style. 
        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "fld_id"
        TextCol.HeaderText = "CODIGO "
        TextCol.Width = 50
        TextCol.ReadOnly = True
        TextCol.NullText = ""
        ts1.GridColumnStyles.Add(TextCol)



        ' Add a second column style. 
        Dim TextCol1 As New DataGridTextBoxColumn
        TextCol1.MappingName = "fld_fecha"
        TextCol1.HeaderText = "FECHA "
        TextCol1.Format = "dd/MMM/yy"
        TextCol1.Width = 80
        TextCol1.ReadOnly = True
        TextCol1.NullText = ""
        ts1.GridColumnStyles.Add(TextCol1)

        Dim TextCol111 As New DataGridTextBoxColumn
        TextCol111.MappingName = "fld_monto"
        TextCol111.HeaderText = "IMPORTE_"
        TextCol111.Width = 88
        TextCol111.ReadOnly = True
        TextCol111.Alignment = HorizontalAlignment.Right
        TextCol111.Format = "C2"
        TextCol111.NullText = ""
        ts1.GridColumnStyles.Add(TextCol111)


        Dim TextCol11 As New DataGridTextBoxColumn
        TextCol11.MappingName = "fld_abono"
        TextCol11.HeaderText = "ABONO_"
        TextCol11.Width = 88
        TextCol11.ReadOnly = True
        TextCol11.Alignment = HorizontalAlignment.Right
        TextCol11.Format = "C2"
        TextCol11.NullText = ""
        ts1.GridColumnStyles.Add(TextCol11)

        ' Add a second column style. 
        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "fld_Balance"
        TextCol2.HeaderText = "BALANCE_"
        TextCol2.Width = 88
        TextCol2.Format = "C2"
        TextCol2.Alignment = HorizontalAlignment.Right
        TextCol2.ReadOnly = True
        TextCol2.NullText = ""
        ts1.GridColumnStyles.Add(TextCol2)

        Dim TextCol1122 As New DataGridTextBoxColumn
        TextCol1122.MappingName = "fld_concepto"
        TextCol1122.HeaderText = "DESCRIPCION "
        TextCol1122.Width = 150
        TextCol1122.ReadOnly = True
        TextCol1122.NullText = ""
        ts1.GridColumnStyles.Add(TextCol1122)


        ts1.RowHeadersVisible = False
        ts1.AllowSorting = False
        ts1.RowHeadersVisible = False

        ' Add the DataGridTableStyle objects to the collection. 
        DG_NC.GridLineColor.GetHashCode()
        DG_NC.TableStyles.Add(ts1)



    End Sub
#End Region

    Private Sub fld_monto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_monto.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If


        If e.KeyChar = Chr(13) Then
            Dim largo = Len(CStr(Format(CDbl(fld_monto.Text), "##,###.00")))
            Dim decimales = Mid(CStr(Format(CDbl(fld_monto.Text), "##,###.00")), largo - 2)
            fld_cantidad_letra.Text = "SOLO " & Num2Text(fld_monto.Text - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
        End If

    End Sub

    Private Sub fld_monto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_monto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim amount As Decimal = CType(fld_monto.Text, Decimal)
            Me.fld_monto.Text = String.Format("{0:n2}", amount)
            fld_beneficiario.Focus()
        End If
    End Sub

    Public Sub PrintCk(ByVal ck_no As Integer)


        Try
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
                WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName)  'Set the Default Print

                Imprimir_cheque(ck_no, PrintDialog1.PrinterSettings.PrinterName, CInt(fld_id_banco.Text))
                WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print

            End If

        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub

    Public Sub Print_solicitud(ByVal ck As String)

        '/INI FILE
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
            Dim ds As New DataSet

            '/PROFILE
            Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daProf.Fill(ds, "tbl_profiledocument")

            Dim daInvoiceDetail As New MySqlDataAdapter("SELECT * FROM view_solicitud_ck WHERE fld_id_doc=" & ck & "", conn)
            daInvoiceDetail.Fill(ds, "view_solicitud_ck")


            Dim Report As New RPT_SOLICITUD_CK
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
            Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            Report.PrintToPrinter(1, True, 0, 0)
        End If
        WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print

    End Sub



    Private Sub Mnu_Lista_Solicitudes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If FRMS_LIST_CK("S") = True Then
            LOAD_DATA_CK(Id)
            If Me.Text = "Maestro de Cheques (SOLICITUD)" Then
                btn_procesar.Enabled = False
            End If
        End If
    End Sub

    Private Sub FLD_CODIGO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FLD_CODIGO.KeyPress
        If e.KeyChar = Chr(13) Then
            If Trim(FLD_CODIGO.Text) = "" Then

            Else
                If FRMS_LIST_BANCOS() = True Then
                    LOAD_DATA_BANCO(Id)
                End If
            End If
        End If
    End Sub

    Private Sub btn_nuevo_beneficiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FRMS_BENEFICIARIOS()

    End Sub

    Private Sub fld_beneficiario_KeyPress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            fld_descripcion.Focus()
        End If
    End Sub

    Private Sub fld_dr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub fld_cr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub

    Private Sub fld_id_ck_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumerosSINPUNTO(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_abono_detalle_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DOC_AFECTADO = "SOLICITUD CK-" & CStr(CInt(fld_id_ck.Text))
        'If FRMS_TRANSACCIONES_INTERFACE("Interface de cuentas contable", "CREDITO", FLD_CTA_CONTABLE.Text, fld_descripcion.Text, fld_monto.Text, DOC_AFECTADO, FLD_NOMBRE.Text, fld_descripcion.Text, fld_codigo_transacion.Text, ReturnDescripcion(FLD_CTA_CONTABLE.Text)) = False Then
        'Alerta("Operación cancelada" & Chr(13) & "No ha completado el proceso de interface de cuenta contable")
        'Exit Sub
        'End If
    End Sub

    Private Sub fld_tipo_beneficiario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_tipo_beneficiario.KeyPress
        e.Handled = True
    End Sub
    Private Sub fld_tipo_beneficiario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_tipo_beneficiario.SelectedIndexChanged
        If fld_tipo_beneficiario.Text = "Clientes" Then

            If FRMS_POPUP_CLIENTES("TODOS") = True Then
                READER("SELECT fld_id, fld_FirstName FROM tbl_clientes WHERE fld_id=" & Id & "")
                If reader_values.Length > 0 Then
                    fld_codigo_beneficiario.Text = reader_values(0)
                    fld_beneficiario.Text = reader_values(1)
                End If
            End If

        ElseIf fld_tipo_beneficiario.Text = "Proveedores" Then

            If FRMS_POPUP_PROVEEDORES() = True Then
                READER("SELECT fldSupplierID, fldCompany FROM tbl_supplier WHERE fldSupplierID=" & Id & "")
                If reader_values.Length > 0 Then
                    fld_codigo_beneficiario.Text = reader_values(0)
                    fld_beneficiario.Text = reader_values(1)
                    LOAD_NC_CXP(reader_values(0))
                End If
            End If

        Else
            fld_codigo_beneficiario.Text = 0
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        preview_pay()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        ds_nc.RejectChanges()
    End Sub



    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If FRMS_LIST_BANCOS() = True Then
            LOAD_DATA_BANCO(Id)
            fld_ck_no.Text = SCALAR_NUM("SELECT IFNULL(fld_ck_no,0) FROM tbl_cod_ck WHERE fld_cuenta_no='" & FLD_CUENTA.Text & "'")
            fld_ck_no.Focus()
        End If
    End Sub

    Private Sub fld_beneficiario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_beneficiario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If SCALAR_NUM("SELECT COUNT(*) FROM tbl_beneficiarios WHERE fld_beneficiario='" & Trim(fld_beneficiario.Text) & "'") > 0 Then Exit Sub 'Existe el beneficiario
            NON_QUERY("INSERT INTO tbl_beneficiarios (fld_beneficiario) VALUES('" & fld_beneficiario.Text & "')")
        End If
    End Sub

    Private Sub fld_beneficiario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_beneficiario.SelectedIndexChanged

    End Sub
    Private Sub fld_beneficiario_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles fld_beneficiario.Leave
        AutoCompleteCombo_Leave(fld_beneficiario)
    End Sub

    Private Sub fld_beneficiario_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_beneficiario.KeyUp
        AutoCompleteCombo_KeyUp(fld_beneficiario, e)
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If FRMS_LIST_CK("S") = True Then
            LOAD_DATA_CK_SOLICITUD(Id)
        End If
    End Sub

    Private Sub fld_solicitud_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_solicitud_no.TextChanged

    End Sub

    Private Sub fld_solicitud_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_solicitud_no.KeyDown
        If e.KeyData = Keys.Enter Then
            If IsNumeric(Trim(fld_solicitud_no.Text)) Then
                LOAD_DATA_CK_SOLICITUD(Trim(fld_solicitud_no.Text))
            End If
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If FRMS_LIST_CK("E") = True Then
            LOAD_DATA_CK(Id)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        CLEAR_FIELD()
    End Sub

    Private Sub btnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_procesar.Click

        If btn_procesar.Text = "&Guardar" Then
            SAVE_DATA()
        Else
            UPDATE_DOC(fld_id_ck.Text)
            CLEAR_FIELD()
        End If

    End Sub

    Private Sub btnAnula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnula.Click
        Dim TIPE = "DEBITO"
        Dim DOC_AFECTADO = CStr(FLD_CODIGO.Text)

        'If FRMS_TRANSACCIONES_INTERFACE("Interface de cuentas contable", TIPE, FLD_CTA_CONTABLE.Text, "ANULANDO CK.# " & fld_ck_no.Text, CDbl(fld_monto.Text), DOC_AFECTADO, "CKS. " & FLD_NOMBRE.Text, fld_descripcion.Text, "027", ReturnDescripcion(FLD_CTA_CONTABLE.Text)) = False Then
        '    Alerta("Operación cancelada" & Chr(13) & "No ha completado el proceso de interface de cuenta contable")
        '    Exit Sub
        'End If
        If Alerta("¿Seguro que desea Anular el documento?") = False Then Return
        create_row_estado_banco(FLD_CODIGO.Text, CDbl(fld_monto.Text), "CKNULO", fld_ck_no.Text, "ANULANDO CK.# " & fld_ck_no.Text, fld_date.Value.Date)

        ANULA_CK(CInt(fld_id_ck.Text))
        CLEAR_FIELD()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime.Click
        PrintCk(fld_id_ck.Text)
    End Sub

    Private Sub fld_monto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_monto.TextChanged

    End Sub

    Private Sub FRM_MAESTRO_CKS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
