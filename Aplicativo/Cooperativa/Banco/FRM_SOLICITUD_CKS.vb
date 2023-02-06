Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing
Imports System.IO
Public Class FRM_SOLICITUD_CKS

    Inherits System.Windows.Forms.Form
    Dim id_entrada As String
    Dim ds_facturas As DataSet, ds_nc As DataSet
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
    Friend WithEvents fld_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents fld_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents FLD_CTA_CONTABLE As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FLD_BALANCE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FLD_CUENTA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FLD_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FLD_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents fld_cantidad_letra As System.Windows.Forms.TextBox
    Friend WithEvents fld_ck_no As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fld_codigo_transacion As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents fld_id_ck As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents fld_codigo_beneficiario As System.Windows.Forms.TextBox
    Friend WithEvents fld_tipo_beneficiario As System.Windows.Forms.ComboBox
    Friend WithEvents fld_bce_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAnula As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btn_procesar As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents fld_beneficiario As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents fld_id_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents fld_id_banco As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_SOLICITUD_CKS))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.fld_monto = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.fld_descripcion = New System.Windows.Forms.TextBox
        Me.fld_date = New System.Windows.Forms.DateTimePicker
        Me.FLD_CTA_CONTABLE = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.FLD_BALANCE = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.FLD_CUENTA = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.FLD_NOMBRE = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.FLD_CODIGO = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.fld_cantidad_letra = New System.Windows.Forms.TextBox
        Me.fld_ck_no = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.fld_codigo_transacion = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.Label21 = New System.Windows.Forms.Label
        Me.fld_id_ck = New System.Windows.Forms.TextBox
        Me.fld_codigo_beneficiario = New System.Windows.Forms.TextBox
        Me.fld_tipo_beneficiario = New System.Windows.Forms.ComboBox
        Me.fld_bce_proveedor = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnAnula = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btn_procesar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnImprime = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.fld_beneficiario = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.fld_id_proveedor = New System.Windows.Forms.TextBox
        Me.fld_id_banco = New System.Windows.Forms.TextBox
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
        Me.fld_monto.Location = New System.Drawing.Point(482, 144)
        Me.fld_monto.Name = "fld_monto"
        Me.fld_monto.Size = New System.Drawing.Size(136, 20)
        Me.fld_monto.TabIndex = 2
        Me.fld_monto.Text = "0.00"
        Me.fld_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Concepto"
        '
        'fld_descripcion
        '
        Me.fld_descripcion.BackColor = System.Drawing.Color.White
        Me.fld_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_descripcion.Location = New System.Drawing.Point(80, 216)
        Me.fld_descripcion.Name = "fld_descripcion"
        Me.fld_descripcion.Size = New System.Drawing.Size(536, 20)
        Me.fld_descripcion.TabIndex = 4
        Me.fld_descripcion.Text = ""
        '
        'fld_date
        '
        Me.fld_date.CustomFormat = "dd / MMM / yyyy"
        Me.fld_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_date.Location = New System.Drawing.Point(482, 96)
        Me.fld_date.Name = "fld_date"
        Me.fld_date.ShowUpDown = True
        Me.fld_date.Size = New System.Drawing.Size(136, 20)
        Me.fld_date.TabIndex = 1
        '
        'FLD_CTA_CONTABLE
        '
        Me.FLD_CTA_CONTABLE.BackColor = System.Drawing.SystemColors.Control
        Me.FLD_CTA_CONTABLE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_CTA_CONTABLE.Location = New System.Drawing.Point(482, 120)
        Me.FLD_CTA_CONTABLE.Name = "FLD_CTA_CONTABLE"
        Me.FLD_CTA_CONTABLE.ReadOnly = True
        Me.FLD_CTA_CONTABLE.Size = New System.Drawing.Size(136, 20)
        Me.FLD_CTA_CONTABLE.TabIndex = 38
        Me.FLD_CTA_CONTABLE.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(401, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Cta. Cont."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FLD_BALANCE
        '
        Me.FLD_BALANCE.BackColor = System.Drawing.SystemColors.Control
        Me.FLD_BALANCE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_BALANCE.Location = New System.Drawing.Point(288, 120)
        Me.FLD_BALANCE.Name = "FLD_BALANCE"
        Me.FLD_BALANCE.ReadOnly = True
        Me.FLD_BALANCE.Size = New System.Drawing.Size(104, 20)
        Me.FLD_BALANCE.TabIndex = 23
        Me.FLD_BALANCE.Text = "0.00"
        Me.FLD_BALANCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(241, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Balance"
        '
        'FLD_CUENTA
        '
        Me.FLD_CUENTA.BackColor = System.Drawing.SystemColors.Control
        Me.FLD_CUENTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_CUENTA.Location = New System.Drawing.Point(80, 120)
        Me.FLD_CUENTA.Name = "FLD_CUENTA"
        Me.FLD_CUENTA.ReadOnly = True
        Me.FLD_CUENTA.Size = New System.Drawing.Size(136, 20)
        Me.FLD_CUENTA.TabIndex = 19
        Me.FLD_CUENTA.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cta. Bancaria"
        '
        'FLD_NOMBRE
        '
        Me.FLD_NOMBRE.BackColor = System.Drawing.SystemColors.Control
        Me.FLD_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_NOMBRE.Location = New System.Drawing.Point(80, 96)
        Me.FLD_NOMBRE.Name = "FLD_NOMBRE"
        Me.FLD_NOMBRE.ReadOnly = True
        Me.FLD_NOMBRE.Size = New System.Drawing.Size(312, 20)
        Me.FLD_NOMBRE.TabIndex = 18
        Me.FLD_NOMBRE.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(401, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Fecha"
        '
        'FLD_CODIGO
        '
        Me.FLD_CODIGO.BackColor = System.Drawing.Color.White
        Me.FLD_CODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FLD_CODIGO.Location = New System.Drawing.Point(80, 72)
        Me.FLD_CODIGO.Name = "FLD_CODIGO"
        Me.FLD_CODIGO.ReadOnly = True
        Me.FLD_CODIGO.Size = New System.Drawing.Size(95, 20)
        Me.FLD_CODIGO.TabIndex = 9
        Me.FLD_CODIGO.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Beneficiario"
        '
        'fld_cantidad_letra
        '
        Me.fld_cantidad_letra.BackColor = System.Drawing.Color.White
        Me.fld_cantidad_letra.Location = New System.Drawing.Point(80, 168)
        Me.fld_cantidad_letra.Name = "fld_cantidad_letra"
        Me.fld_cantidad_letra.ReadOnly = True
        Me.fld_cantidad_letra.Size = New System.Drawing.Size(536, 20)
        Me.fld_cantidad_letra.TabIndex = 21
        Me.fld_cantidad_letra.Text = ""
        '
        'fld_ck_no
        '
        Me.fld_ck_no.BackColor = System.Drawing.Color.White
        Me.fld_ck_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ck_no.Location = New System.Drawing.Point(482, 72)
        Me.fld_ck_no.Name = "fld_ck_no"
        Me.fld_ck_no.Size = New System.Drawing.Size(136, 20)
        Me.fld_ck_no.TabIndex = 29
        Me.fld_ck_no.Text = "0"
        Me.fld_ck_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_ck_no.Visible = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(401, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Solicitud No."
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(401, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Monto"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Banco ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_codigo_transacion
        '
        Me.fld_codigo_transacion.BackColor = System.Drawing.SystemColors.Control
        Me.fld_codigo_transacion.Location = New System.Drawing.Point(80, 144)
        Me.fld_codigo_transacion.Name = "fld_codigo_transacion"
        Me.fld_codigo_transacion.ReadOnly = True
        Me.fld_codigo_transacion.Size = New System.Drawing.Size(136, 20)
        Me.fld_codigo_transacion.TabIndex = 20
        Me.fld_codigo_transacion.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(5, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 16)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Cod. trans."
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Lista de Solicitudes"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(5, 168)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 16)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Cant. letras"
        '
        'fld_id_ck
        '
        Me.fld_id_ck.BackColor = System.Drawing.Color.White
        Me.fld_id_ck.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_id_ck.Location = New System.Drawing.Point(288, 72)
        Me.fld_id_ck.Name = "fld_id_ck"
        Me.fld_id_ck.Size = New System.Drawing.Size(104, 20)
        Me.fld_id_ck.TabIndex = 24
        Me.fld_id_ck.Text = "0"
        Me.fld_id_ck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_id_ck.Visible = False
        '
        'fld_codigo_beneficiario
        '
        Me.fld_codigo_beneficiario.Location = New System.Drawing.Point(624, 184)
        Me.fld_codigo_beneficiario.Name = "fld_codigo_beneficiario"
        Me.fld_codigo_beneficiario.ReadOnly = True
        Me.fld_codigo_beneficiario.Size = New System.Drawing.Size(72, 20)
        Me.fld_codigo_beneficiario.TabIndex = 36
        Me.fld_codigo_beneficiario.Text = ""
        '
        'fld_tipo_beneficiario
        '
        Me.fld_tipo_beneficiario.Items.AddRange(New Object() {"General", "Proveedores"})
        Me.fld_tipo_beneficiario.Location = New System.Drawing.Point(400, 192)
        Me.fld_tipo_beneficiario.Name = "fld_tipo_beneficiario"
        Me.fld_tipo_beneficiario.Size = New System.Drawing.Size(104, 21)
        Me.fld_tipo_beneficiario.TabIndex = 0
        Me.fld_tipo_beneficiario.Text = "General"
        Me.fld_tipo_beneficiario.Visible = False
        '
        'fld_bce_proveedor
        '
        Me.fld_bce_proveedor.BackColor = System.Drawing.Color.White
        Me.fld_bce_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_bce_proveedor.Location = New System.Drawing.Point(528, 192)
        Me.fld_bce_proveedor.Name = "fld_bce_proveedor"
        Me.fld_bce_proveedor.ReadOnly = True
        Me.fld_bce_proveedor.Size = New System.Drawing.Size(90, 20)
        Me.fld_bce_proveedor.TabIndex = 35
        Me.fld_bce_proveedor.Text = "0.00"
        Me.fld_bce_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_bce_proveedor.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(504, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 16)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Bce."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Visible = False
        '
        'btnAnula
        '
        Me.btnAnula.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAnula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnula.ForeColor = System.Drawing.Color.Black
        Me.btnAnula.Image = CType(resources.GetObject("btnAnula.Image"), System.Drawing.Image)
        Me.btnAnula.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAnula.Location = New System.Drawing.Point(536, 272)
        Me.btnAnula.Name = "btnAnula"
        Me.btnAnula.Size = New System.Drawing.Size(88, 96)
        Me.btnAnula.TabIndex = 37
        Me.btnAnula.Text = "&Anular"
        Me.btnAnula.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnula.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(704, 104)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_procesar
        '
        Me.btn_procesar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_procesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_procesar.Image = CType(resources.GetObject("btn_procesar.Image"), System.Drawing.Image)
        Me.btn_procesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_procesar.Location = New System.Drawing.Point(704, 48)
        Me.btn_procesar.Name = "btn_procesar"
        Me.btn_procesar.Size = New System.Drawing.Size(72, 56)
        Me.btn_procesar.TabIndex = 5
        Me.btn_procesar.Text = "&Guardar"
        Me.btn_procesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(632, 48)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnImprime.ForeColor = System.Drawing.Color.Black
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprime.Location = New System.Drawing.Point(632, 104)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(72, 56)
        Me.btnImprime.TabIndex = 7
        Me.btnImprime.Text = "&Imprimir "
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(176, 68)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 24)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "&List. Banco"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(264, 448)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(336, 80)
        Me.DataGrid1.TabIndex = 146
        '
        'fld_beneficiario
        '
        Me.fld_beneficiario.Location = New System.Drawing.Point(80, 192)
        Me.fld_beneficiario.Name = "fld_beneficiario"
        Me.fld_beneficiario.Size = New System.Drawing.Size(536, 21)
        Me.fld_beneficiario.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(812, 24)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "SOLICITUD DE CHEQUE DEL BANCO "
        '
        'fld_id_proveedor
        '
        Me.fld_id_proveedor.BackColor = System.Drawing.Color.White
        Me.fld_id_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_id_proveedor.Location = New System.Drawing.Point(288, 48)
        Me.fld_id_proveedor.Name = "fld_id_proveedor"
        Me.fld_id_proveedor.Size = New System.Drawing.Size(104, 20)
        Me.fld_id_proveedor.TabIndex = 25
        Me.fld_id_proveedor.Text = "0"
        Me.fld_id_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_id_proveedor.Visible = False
        '
        'fld_id_banco
        '
        Me.fld_id_banco.BackColor = System.Drawing.Color.White
        Me.fld_id_banco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_id_banco.Location = New System.Drawing.Point(482, 48)
        Me.fld_id_banco.Name = "fld_id_banco"
        Me.fld_id_banco.Size = New System.Drawing.Size(134, 20)
        Me.fld_id_banco.TabIndex = 28
        Me.fld_id_banco.Text = "0"
        Me.fld_id_banco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.fld_id_banco.Visible = False
        '
        'FRM_SOLICITUD_CKS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(818, 278)
        Me.Controls.Add(Me.fld_id_banco)
        Me.Controls.Add(Me.fld_id_proveedor)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.fld_beneficiario)
        Me.Controls.Add(Me.fld_bce_proveedor)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnImprime)
        Me.Controls.Add(Me.btnAnula)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btn_procesar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.fld_codigo_beneficiario)
        Me.Controls.Add(Me.fld_id_ck)
        Me.Controls.Add(Me.fld_cantidad_letra)
        Me.Controls.Add(Me.fld_codigo_transacion)
        Me.Controls.Add(Me.fld_ck_no)
        Me.Controls.Add(Me.fld_monto)
        Me.Controls.Add(Me.fld_descripcion)
        Me.Controls.Add(Me.FLD_CTA_CONTABLE)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "FRM_SOLICITUD_CKS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Cheque"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub LOAD_DATA_CK_SOLICITUD(ByVal Valor As String)
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_cheques_solicitud WHERE fld_id_doc=" & Valor & "", conn)
        da.Fill(ds, "tbl_cheques_solicitud")

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
        Next

        ds.Dispose()
        da.Dispose()

        LOAD_DATA_BANCO(banco)


    End Sub

    Private Sub RellenaBeneficiario()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT fld_id, fld_beneficiario FROM tbl_beneficiarios ORDER BY fld_beneficiario", conn)
        da.Fill(dt)

        fld_beneficiario.DataSource = dt
        fld_beneficiario.DisplayMember = "fld_beneficiario"
        fld_beneficiario.ValueMember = "fld_id"

        da.Dispose()

    End Sub

    Private Sub FRM_SOLICITUD_CKS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        ElseIf Trim(fld_descripcion.Text) = "" Then
            fld_descripcion.Focus()
            Alerta("Falta la descripcion")
            Return False
        ElseIf Trim(fld_monto.Text) = "" Or CDbl(fld_monto.Text) = 0 Then
            fld_monto.Focus()
            Alerta("Falta el monto")
            Return False

        ElseIf Trim(fld_beneficiario.Text) = "" Then
            fld_beneficiario.Focus()
            Alerta("Falta los datos del beneficiario")
            Return False

        End If

        Return True

    End Function

    Private Sub SAVE_DOC(ByVal TableName As String)
        Dim estado As String = "EMISION"

        NON_QUERY("INSERT INTO " & TableName & " (fld_ck_no, fld_id_banco, fld_fecha, fld_concepto, fld_monto, fld_estado, fld_cta_axu_id, fld_beneficiario, fld_monto_letras,  fld_id_entrada, fld_transito) VALUES(" & CInt(fld_ck_no.Text) & ",'" & FLD_CODIGO.Text & "','" & formatDate(fld_date.Value.Date) & "','" & fld_descripcion.Text & "'," & CDbl(fld_monto.Text) & ",'" & estado & "', " & fld_id_proveedor.Text & ",'" & fld_beneficiario.Text & "','" & fld_cantidad_letra.Text & "',0,'SI')")

    End Sub

    Private Sub LOAD_DATA_BANCO(ByVal Valor As String)
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM TBL_BANCOS WHERE FLD_CODIGO='" & Valor & "'", conn)
        da.Fill(ds, "TBL_BANCOS")
        For Each dr In ds.Tables(0).Rows
            Label15.Text = Label15.Text & " " & dr("FLD_NOMBRE")
            FLD_CODIGO.Text = dr("FLD_CODIGO")
            FLD_NOMBRE.Text = dr("FLD_NOMBRE")
            FLD_CUENTA.Text = dr("FLD_CUENTA")
            FLD_CTA_CONTABLE.Text = dr("FLD_CTA_CONTABLE")
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
    Private Sub LOAD_DATA_CK(ByVal Valor As String)
        Dim dr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_cheques_solicitud WHERE fld_id_doc=" & Valor & "", conn)
        da.Fill(ds, "TBL_BANCOS")

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
           
            If dr("fld_estado") = "EMISION" Then
                btn_procesar.Enabled = False
            End If
            'btn_modificar.Enabled = True
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
    Private Sub SAVE_DATA()
        'fld_cantidad_letra.Text = Letras(fld_monto.Text).ToUpper
        If VALIDA_DATA() = False Then Exit Sub
        If Alerta("¿Seguro que desea procesar ese documento?") = False Then Exit Sub

        SAVE_DOC("tbl_cheques_solicitud")
        fld_id_ck.Text = UltimoID("tbl_cheques_solicitud", "fld_id_doc")
        PrintCk(fld_id_ck.Text)

        CLEAR_FIELD()
    End Sub
    Private Sub CLEAR_FIELD()
        btn_procesar.Enabled = True

        FLD_CODIGO.Text = ""
        FLD_NOMBRE.Text = ""
        FLD_CUENTA.Text = ""
        FLD_CTA_CONTABLE.Text = ""
        FLD_BALANCE.Text = "0.00"
        fld_descripcion.Text = ""
        fld_monto.Text = "0.00"
        fld_beneficiario.Text = ""
        fld_codigo_beneficiario.Text = "0"
        fld_cantidad_letra.Text = ""
        fld_ck_no.Text = "0"
        fld_id_proveedor.Text = "0"



        fld_codigo_transacion.Text = "0"
        RellenaBeneficiario()
    End Sub
    Private Sub UPDATE_ID_ENTRADA_EN_CK(ByVal IDS_DOC As String, ByVal IDS_ENTRADA As String)
        NON_QUERY("UPDATE tbl_cheques_solicitud SET fld_id_entrada = " & IDS_ENTRADA & " WHERE fld_id_doc =" & IDS_DOC & "")
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

            'If the result is OK then print the document.
            If (result = Windows.Forms.DialogResult.OK) Then
                Dim pd As New PrintDocument, strOldPrinter As String
                strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print

                Dim WshNetwork As Object
                WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
                WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName)  'Set the Default Print

                'Imprimir_cheque(ck_no, PrintDialog1.PrinterSettings.PrinterName, CInt(fld_id_banco.Text))

                Dim ds As New DataSet
                Dim daProf As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
                daProf.Fill(ds, "tbl_profiledocument")

                Dim daInvoiceDetail As New MySqlDataAdapter("SELECT * FROM tbl_cheques_solicitud WHERE fld_id_doc=" & ck_no & "", conn)
                daInvoiceDetail.Fill(ds, "tbl_cheques_solicitud")

                Dim Report As New RPT_SOLICITUD_CK
                Report.Database.Tables(0).SetDataSource(ds)
                Report.PrintOptions.PrinterDuplex = PrinterDuplex.Horizontal
                Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
                Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)

                WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print

            End If

        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub



    Private Sub Mnu_ck_Emitidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If FRMS_LIST_CK("E") = True Then
            LOAD_DATA_CK(Id)
            btn_procesar.Enabled = False
        End If
    End Sub

    Private Sub Mnu_Lista_Solicitudes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If FRMS_LIST_CK("S") = True Then
            LOAD_DATA_CK(Id)
            If Me.Text = "Maestro de Cheques (SOLICITUD)" Then
                btn_procesar.Enabled = False

            Else

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

             

        Else
            fld_codigo_beneficiario.Text = 0
        End If
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ds_facturas.RejectChanges()
        ds_nc.RejectChanges()
    End Sub

    Private Sub fld_monto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_monto.TextChanged

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        CLEAR_FIELD()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_procesar.Click
        SAVE_DATA()
        id_entrada = ""
    End Sub



    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime.Click
        PrintCk(fld_id_ck.Text)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If FRMS_LIST_BANCOS() = True Then
            LOAD_DATA_BANCO(Id)
            fld_ck_no.Text = SCALAR_NUM("SELECT IFNULL(fld_ck_no,0) FROM tbl_cod_ck WHERE fld_cuenta_no='" & FLD_CUENTA.Text & "'")
            fld_date.Focus()
        End If
    End Sub


    Private Sub fld_beneficiario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_beneficiario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If SCALAR_NUM("SELECT COUNT(*) FROM tbl_beneficiarios WHERE fld_beneficiario='" & Trim(fld_beneficiario.Text) & "'") > 0 Then Exit Sub 'Existe el beneficiario
            NON_QUERY("INSERT INTO tbl_beneficiarios (fld_beneficiario) VALUES('" & fld_beneficiario.Text & "')")
            fld_descripcion.Focus()
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

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If FRMS_LIST_CK("S") = True Then
            LOAD_DATA_CK_SOLICITUD(Id)
        End If
    End Sub

    Private Sub fld_date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_date.ValueChanged

    End Sub

    Private Sub fld_date_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_date.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
