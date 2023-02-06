Imports  MySql.Data.MySqlClient

Public Class FRM_CLIENTES
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
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents lblExcluido As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblTeléfono As System.Windows.Forms.Label
    Friend WithEvents lbDirección As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellidos As System.Windows.Forms.Label
    Friend WithEvents TP_FICHA_GRAL1 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents fld_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents fld_FullName As System.Windows.Forms.TextBox
    Friend WithEvents fld_Phone As System.Windows.Forms.TextBox
    Friend WithEvents fld_Address As System.Windows.Forms.TextBox
    Friend WithEvents fld_Phone2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents fld_otra_informacion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents fld_apodo_con As System.Windows.Forms.TextBox
    Friend WithEvents fld_nombre_con As System.Windows.Forms.TextBox
    Friend WithEvents fld_telefono_con As System.Windows.Forms.TextBox
    Friend WithEvents fld_cedula_con As System.Windows.Forms.TextBox
    Friend WithEvents fld_celular_con As System.Windows.Forms.TextBox
    Friend WithEvents fld_ref_comerciales_cliente As System.Windows.Forms.TextBox
    Friend WithEvents fld_ref_personales_cliente As System.Windows.Forms.TextBox
    Friend WithEvents fld_apodo_con_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_nombre_con_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_telefono_con_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_cedula_con_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_celular_con_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_apodo_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_nombre_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_telefono_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_direccion_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_cedula_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_celular_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_ref_comerciales_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_ref_personales_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_nombre_banco1 As System.Windows.Forms.TextBox
    Friend WithEvents fld_ingresos_mesuales As System.Windows.Forms.TextBox
    Friend WithEvents fld_nombre_banco2 As System.Windows.Forms.TextBox
    Friend WithEvents fld_apodo As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents fld_estado_civil As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents fld_estado_civil_gar As System.Windows.Forms.ComboBox
    Friend WithEvents fld_edad_gar As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents fld_ocupacion_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents fld_ocupacion_gar As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fld_City As System.Windows.Forms.ComboBox
    Friend WithEvents fld_ciudad_gar As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents fld_Identity As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtLimite As System.Windows.Forms.TextBox
    Friend WithEvents lblLimite As System.Windows.Forms.Label
    Friend WithEvents btnLimite As System.Windows.Forms.Button
    Friend WithEvents txtPuesto As System.Windows.Forms.TextBox
    Friend WithEvents txtOriundo As System.Windows.Forms.TextBox
    Friend WithEvents txtReferidoPor As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents btnCuentasBanco As System.Windows.Forms.Button
    Friend WithEvents btnEstadoIngresoEgresos As System.Windows.Forms.Button
    Friend WithEvents btnOtrasObligaciones As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents cmdZonas As System.Windows.Forms.ComboBox
    Friend WithEvents fotoBtn As System.Windows.Forms.Button
    Friend WithEvents lblCuentaContable As System.Windows.Forms.Label
    Friend WithEvents txtCuentaContable As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents buscaCtaContableBtn As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents emailTxt As System.Windows.Forms.TextBox
    Friend WithEvents dtpEdad As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIngresos As System.Windows.Forms.DateTimePicker
    Friend WithEvents fldedad As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents ahorroEntradaTxt As System.Windows.Forms.TextBox
    Friend WithEvents ahorroSalidaTxt As System.Windows.Forms.TextBox
    Friend WithEvents ahorroBalanceTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents certificadoBalanceTxt As System.Windows.Forms.TextBox
    Friend WithEvents certificadoSalidaTxt As System.Windows.Forms.TextBox
    Friend WithEvents certificadoEntradaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents aportacionMontoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents balanceGralTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents disponibilidadTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents balancePrestamosTxt As System.Windows.Forms.TextBox
    Friend WithEvents fldtiempoempresa As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_CLIENTES))
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.TP_FICHA_GRAL1 = New System.Windows.Forms.TabPage
        Me.fldedad = New System.Windows.Forms.TextBox
        Me.dtpEdad = New System.Windows.Forms.DateTimePicker
        Me.Label19 = New System.Windows.Forms.Label
        Me.emailTxt = New System.Windows.Forms.TextBox
        Me.btnLimite = New System.Windows.Forms.Button
        Me.lblLimite = New System.Windows.Forms.Label
        Me.txtLimite = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.lblId = New System.Windows.Forms.Label
        Me.lblFechaNacimiento = New System.Windows.Forms.Label
        Me.fld_Phone2 = New System.Windows.Forms.TextBox
        Me.lblApellidos = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.fld_ref_comerciales_cliente = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.fld_ref_personales_cliente = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.fld_Phone = New System.Windows.Forms.TextBox
        Me.fld_Codigo = New System.Windows.Forms.TextBox
        Me.lblTeléfono = New System.Windows.Forms.Label
        Me.fld_Address = New System.Windows.Forms.TextBox
        Me.lbDirección = New System.Windows.Forms.Label
        Me.fld_apodo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdZonas = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblExcluido = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.fld_FullName = New System.Windows.Forms.TextBox
        Me.fld_estado_civil = New System.Windows.Forms.ComboBox
        Me.fld_ocupacion_cliente = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.fld_apodo_con = New System.Windows.Forms.TextBox
        Me.fld_nombre_con = New System.Windows.Forms.TextBox
        Me.fld_telefono_con = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.fld_cedula_con = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.fld_celular_con = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.fld_City = New System.Windows.Forms.ComboBox
        Me.fld_Identity = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblCedula = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.fld_estado_civil_gar = New System.Windows.Forms.ComboBox
        Me.fld_edad_gar = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.fld_apodo_con_gar = New System.Windows.Forms.TextBox
        Me.fld_nombre_con_gar = New System.Windows.Forms.TextBox
        Me.fld_telefono_con_gar = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.fld_cedula_con_gar = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.fld_celular_con_gar = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.fld_apodo_gar = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.fld_nombre_gar = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.fld_telefono_gar = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.fld_direccion_gar = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.fld_cedula_gar = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.fld_celular_gar = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.fld_ref_comerciales_gar = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.fld_ref_personales_gar = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.fld_ciudad_gar = New System.Windows.Forms.ComboBox
        Me.fld_ocupacion_gar = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.fldtiempoempresa = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.balancePrestamosTxt = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.disponibilidadTxt = New System.Windows.Forms.TextBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.balanceGralTxt = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.aportacionMontoTxt = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ahorroBalanceTxt = New System.Windows.Forms.TextBox
        Me.ahorroSalidaTxt = New System.Windows.Forms.TextBox
        Me.ahorroEntradaTxt = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.dtpFechaIngresos = New System.Windows.Forms.DateTimePicker
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.btnOtrasObligaciones = New System.Windows.Forms.Button
        Me.btnEstadoIngresoEgresos = New System.Windows.Forms.Button
        Me.btnCuentasBanco = New System.Windows.Forms.Button
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtReferidoPor = New System.Windows.Forms.TextBox
        Me.txtOriundo = New System.Windows.Forms.TextBox
        Me.txtPuesto = New System.Windows.Forms.TextBox
        Me.fld_ingresos_mesuales = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.fld_otra_informacion = New System.Windows.Forms.TextBox
        Me.fld_nombre_banco1 = New System.Windows.Forms.TextBox
        Me.fld_nombre_banco2 = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.certificadoBalanceTxt = New System.Windows.Forms.TextBox
        Me.certificadoSalidaTxt = New System.Windows.Forms.TextBox
        Me.certificadoEntradaTxt = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnBorrar = New System.Windows.Forms.Button
        Me.cmbEstado = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.fotoBtn = New System.Windows.Forms.Button
        Me.lblCuentaContable = New System.Windows.Forms.Label
        Me.txtCuentaContable = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.buscaCtaContableBtn = New System.Windows.Forms.Button
        Me.TabControl.SuspendLayout()
        Me.TP_FICHA_GRAL1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(296, 400)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(224, 400)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(8, 400)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.TabStop = False
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TabControl
        '
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl.Controls.Add(Me.TP_FICHA_GRAL1)
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(818, 392)
        Me.TabControl.TabIndex = 0
        '
        'TP_FICHA_GRAL1
        '
        Me.TP_FICHA_GRAL1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TP_FICHA_GRAL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fldedad)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.dtpEdad)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label19)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.emailTxt)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.btnLimite)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.lblLimite)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.txtLimite)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.CheckBox1)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label18)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.cmbTipoDocumento)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Button3)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.lblId)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.lblFechaNacimiento)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_Phone2)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.lblApellidos)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.GroupBox3)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_Phone)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_Codigo)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.lblTeléfono)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_Address)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.lbDirección)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_apodo)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label2)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.cmdZonas)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label4)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.lblExcluido)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label35)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_FullName)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_estado_civil)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_ocupacion_cliente)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label31)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.GroupBox2)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label32)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_City)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_Identity)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Button1)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.lblCedula)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.lblNombre)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label40)
        Me.TP_FICHA_GRAL1.Location = New System.Drawing.Point(4, 25)
        Me.TP_FICHA_GRAL1.Name = "TP_FICHA_GRAL1"
        Me.TP_FICHA_GRAL1.Size = New System.Drawing.Size(810, 363)
        Me.TP_FICHA_GRAL1.TabIndex = 0
        Me.TP_FICHA_GRAL1.Text = "Datos del Socio"
        '
        'fldedad
        '
        Me.fldedad.BackColor = System.Drawing.Color.White
        Me.fldedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fldedad.Enabled = False
        Me.fldedad.Location = New System.Drawing.Point(312, 120)
        Me.fldedad.MaxLength = 20
        Me.fldedad.Multiline = True
        Me.fldedad.Name = "fldedad"
        Me.fldedad.ReadOnly = True
        Me.fldedad.Size = New System.Drawing.Size(128, 44)
        Me.fldedad.TabIndex = 36
        Me.fldedad.Text = ""
        '
        'dtpEdad
        '
        Me.dtpEdad.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEdad.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEdad.Location = New System.Drawing.Point(112, 120)
        Me.dtpEdad.Name = "dtpEdad"
        Me.dtpEdad.Size = New System.Drawing.Size(168, 20)
        Me.dtpEdad.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(-24, 312)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 16)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Èmail"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'emailTxt
        '
        Me.emailTxt.Location = New System.Drawing.Point(112, 312)
        Me.emailTxt.MaxLength = 100
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.Size = New System.Drawing.Size(328, 20)
        Me.emailTxt.TabIndex = 31
        Me.emailTxt.Text = ""
        '
        'btnLimite
        '
        Me.btnLimite.Location = New System.Drawing.Point(224, 333)
        Me.btnLimite.Name = "btnLimite"
        Me.btnLimite.TabIndex = 34
        Me.btnLimite.Text = "Establecer"
        Me.btnLimite.Visible = False
        '
        'lblLimite
        '
        Me.lblLimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblLimite.Location = New System.Drawing.Point(-16, 336)
        Me.lblLimite.Name = "lblLimite"
        Me.lblLimite.Size = New System.Drawing.Size(112, 24)
        Me.lblLimite.TabIndex = 32
        Me.lblLimite.Text = "Límite PRE-Aprobado"
        Me.lblLimite.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLimite.Visible = False
        '
        'txtLimite
        '
        Me.txtLimite.Location = New System.Drawing.Point(112, 334)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.TabIndex = 33
        Me.txtLimite.Text = "0.00"
        Me.txtLimite.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(112, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(128, 16)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "DATA CRÉDITO"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(264, 98)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 16)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Tipo"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocumento.ForeColor = System.Drawing.Color.White
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(312, 96)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(128, 21)
        Me.cmbTipoDocumento.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(440, 288)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 22)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "..."
        '
        'lblId
        '
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblId.Location = New System.Drawing.Point(8, 26)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(88, 16)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "Código"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(8, 266)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(88, 16)
        Me.lblFechaNacimiento.TabIndex = 24
        Me.lblFechaNacimiento.Text = "Ciudad"
        Me.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_Phone2
        '
        Me.fld_Phone2.BackColor = System.Drawing.Color.White
        Me.fld_Phone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_Phone2.Location = New System.Drawing.Point(112, 216)
        Me.fld_Phone2.MaxLength = 150
        Me.fld_Phone2.Name = "fld_Phone2"
        Me.fld_Phone2.Size = New System.Drawing.Size(328, 20)
        Me.fld_Phone2.TabIndex = 21
        Me.fld_Phone2.Text = ""
        '
        'lblApellidos
        '
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblApellidos.Location = New System.Drawing.Point(8, 218)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(88, 16)
        Me.lblApellidos.TabIndex = 20
        Me.lblApellidos.Text = "Teléfono 2"
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.fld_ref_comerciales_cliente)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.fld_ref_personales_cliente)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(472, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(328, 176)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Referencias"
        '
        'fld_ref_comerciales_cliente
        '
        Me.fld_ref_comerciales_cliente.BackColor = System.Drawing.Color.White
        Me.fld_ref_comerciales_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ref_comerciales_cliente.Location = New System.Drawing.Point(8, 104)
        Me.fld_ref_comerciales_cliente.MaxLength = 510
        Me.fld_ref_comerciales_cliente.Multiline = True
        Me.fld_ref_comerciales_cliente.Name = "fld_ref_comerciales_cliente"
        Me.fld_ref_comerciales_cliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_ref_comerciales_cliente.Size = New System.Drawing.Size(304, 64)
        Me.fld_ref_comerciales_cliente.TabIndex = 3
        Me.fld_ref_comerciales_cliente.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Comerciales"
        '
        'fld_ref_personales_cliente
        '
        Me.fld_ref_personales_cliente.BackColor = System.Drawing.Color.White
        Me.fld_ref_personales_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ref_personales_cliente.Location = New System.Drawing.Point(8, 32)
        Me.fld_ref_personales_cliente.MaxLength = 510
        Me.fld_ref_personales_cliente.Multiline = True
        Me.fld_ref_personales_cliente.Name = "fld_ref_personales_cliente"
        Me.fld_ref_personales_cliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_ref_personales_cliente.Size = New System.Drawing.Size(304, 48)
        Me.fld_ref_personales_cliente.TabIndex = 1
        Me.fld_ref_personales_cliente.Text = ""
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(8, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(88, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Personales"
        '
        'fld_Phone
        '
        Me.fld_Phone.BackColor = System.Drawing.Color.White
        Me.fld_Phone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_Phone.Location = New System.Drawing.Point(112, 192)
        Me.fld_Phone.MaxLength = 150
        Me.fld_Phone.Name = "fld_Phone"
        Me.fld_Phone.Size = New System.Drawing.Size(328, 20)
        Me.fld_Phone.TabIndex = 19
        Me.fld_Phone.Text = ""
        '
        'fld_Codigo
        '
        Me.fld_Codigo.BackColor = System.Drawing.Color.White
        Me.fld_Codigo.Location = New System.Drawing.Point(112, 24)
        Me.fld_Codigo.Name = "fld_Codigo"
        Me.fld_Codigo.TabIndex = 2
        Me.fld_Codigo.Text = ""
        '
        'lblTeléfono
        '
        Me.lblTeléfono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTeléfono.Location = New System.Drawing.Point(8, 194)
        Me.lblTeléfono.Name = "lblTeléfono"
        Me.lblTeléfono.Size = New System.Drawing.Size(88, 16)
        Me.lblTeléfono.TabIndex = 18
        Me.lblTeléfono.Text = "Teléfono 1"
        Me.lblTeléfono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_Address
        '
        Me.fld_Address.BackColor = System.Drawing.Color.White
        Me.fld_Address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_Address.Location = New System.Drawing.Point(112, 240)
        Me.fld_Address.Name = "fld_Address"
        Me.fld_Address.Size = New System.Drawing.Size(328, 20)
        Me.fld_Address.TabIndex = 23
        Me.fld_Address.Text = ""
        '
        'lbDirección
        '
        Me.lbDirección.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbDirección.Location = New System.Drawing.Point(8, 242)
        Me.lbDirección.Name = "lbDirección"
        Me.lbDirección.Size = New System.Drawing.Size(88, 16)
        Me.lbDirección.TabIndex = 22
        Me.lbDirección.Text = "Direccion"
        Me.lbDirección.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_apodo
        '
        Me.fld_apodo.BackColor = System.Drawing.Color.White
        Me.fld_apodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_apodo.Location = New System.Drawing.Point(112, 72)
        Me.fld_apodo.Name = "fld_apodo"
        Me.fld_apodo.Size = New System.Drawing.Size(328, 20)
        Me.fld_apodo.TabIndex = 7
        Me.fld_apodo.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(8, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Apodo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdZonas
        '
        Me.cmdZonas.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.cmdZonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdZonas.ForeColor = System.Drawing.Color.White
        Me.cmdZonas.Location = New System.Drawing.Point(112, 288)
        Me.cmdZonas.Name = "cmdZonas"
        Me.cmdZonas.Size = New System.Drawing.Size(328, 21)
        Me.cmdZonas.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(8, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Cartera"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblExcluido
        '
        Me.lblExcluido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExcluido.ForeColor = System.Drawing.Color.Red
        Me.lblExcluido.Location = New System.Drawing.Point(216, 24)
        Me.lblExcluido.Name = "lblExcluido"
        Me.lblExcluido.Size = New System.Drawing.Size(224, 23)
        Me.lblExcluido.TabIndex = 3
        Me.lblExcluido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.Location = New System.Drawing.Point(8, 170)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 16)
        Me.Label35.TabIndex = 16
        Me.Label35.Text = "Ocupación"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_FullName
        '
        Me.fld_FullName.BackColor = System.Drawing.Color.White
        Me.fld_FullName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_FullName.Location = New System.Drawing.Point(112, 48)
        Me.fld_FullName.Name = "fld_FullName"
        Me.fld_FullName.Size = New System.Drawing.Size(328, 20)
        Me.fld_FullName.TabIndex = 5
        Me.fld_FullName.Text = ""
        '
        'fld_estado_civil
        '
        Me.fld_estado_civil.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.fld_estado_civil.ForeColor = System.Drawing.Color.White
        Me.fld_estado_civil.Items.AddRange(New Object() {"CASADO (A)", "SOLTERO (A)", "UNION LIBRE", "VIUDO (A)"})
        Me.fld_estado_civil.Location = New System.Drawing.Point(112, 144)
        Me.fld_estado_civil.Name = "fld_estado_civil"
        Me.fld_estado_civil.Size = New System.Drawing.Size(168, 21)
        Me.fld_estado_civil.TabIndex = 15
        Me.fld_estado_civil.Text = "CASADO (A)"
        '
        'fld_ocupacion_cliente
        '
        Me.fld_ocupacion_cliente.BackColor = System.Drawing.Color.White
        Me.fld_ocupacion_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ocupacion_cliente.Location = New System.Drawing.Point(112, 168)
        Me.fld_ocupacion_cliente.MaxLength = 55
        Me.fld_ocupacion_cliente.Name = "fld_ocupacion_cliente"
        Me.fld_ocupacion_cliente.Size = New System.Drawing.Size(328, 20)
        Me.fld_ocupacion_cliente.TabIndex = 17
        Me.fld_ocupacion_cliente.Text = ""
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label31.Location = New System.Drawing.Point(0, 122)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(96, 16)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "Fecha Nacimiento"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.fld_apodo_con)
        Me.GroupBox2.Controls.Add(Me.fld_nombre_con)
        Me.GroupBox2.Controls.Add(Me.fld_telefono_con)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.fld_cedula_con)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.fld_celular_con)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(472, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(328, 152)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cónyuge"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Apodo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_apodo_con
        '
        Me.fld_apodo_con.BackColor = System.Drawing.Color.White
        Me.fld_apodo_con.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_apodo_con.Location = New System.Drawing.Point(12, 72)
        Me.fld_apodo_con.MaxLength = 55
        Me.fld_apodo_con.Name = "fld_apodo_con"
        Me.fld_apodo_con.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_apodo_con.Size = New System.Drawing.Size(144, 20)
        Me.fld_apodo_con.TabIndex = 3
        Me.fld_apodo_con.Text = ""
        '
        'fld_nombre_con
        '
        Me.fld_nombre_con.BackColor = System.Drawing.Color.White
        Me.fld_nombre_con.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_nombre_con.Location = New System.Drawing.Point(12, 32)
        Me.fld_nombre_con.MaxLength = 55
        Me.fld_nombre_con.Name = "fld_nombre_con"
        Me.fld_nombre_con.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_nombre_con.Size = New System.Drawing.Size(304, 20)
        Me.fld_nombre_con.TabIndex = 1
        Me.fld_nombre_con.Text = ""
        '
        'fld_telefono_con
        '
        Me.fld_telefono_con.BackColor = System.Drawing.Color.White
        Me.fld_telefono_con.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_telefono_con.Location = New System.Drawing.Point(12, 120)
        Me.fld_telefono_con.MaxLength = 15
        Me.fld_telefono_con.Name = "fld_telefono_con"
        Me.fld_telefono_con.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_telefono_con.Size = New System.Drawing.Size(144, 20)
        Me.fld_telefono_con.TabIndex = 7
        Me.fld_telefono_con.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(12, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Teléfono 1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_cedula_con
        '
        Me.fld_cedula_con.BackColor = System.Drawing.Color.White
        Me.fld_cedula_con.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_cedula_con.Location = New System.Drawing.Point(172, 72)
        Me.fld_cedula_con.MaxLength = 15
        Me.fld_cedula_con.Name = "fld_cedula_con"
        Me.fld_cedula_con.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_cedula_con.Size = New System.Drawing.Size(144, 20)
        Me.fld_cedula_con.TabIndex = 5
        Me.fld_cedula_con.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(172, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Cédula"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(12, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nombre"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_celular_con
        '
        Me.fld_celular_con.BackColor = System.Drawing.Color.White
        Me.fld_celular_con.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_celular_con.Location = New System.Drawing.Point(172, 120)
        Me.fld_celular_con.MaxLength = 15
        Me.fld_celular_con.Name = "fld_celular_con"
        Me.fld_celular_con.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_celular_con.Size = New System.Drawing.Size(144, 20)
        Me.fld_celular_con.TabIndex = 9
        Me.fld_celular_con.Text = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(172, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Movil"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label32.Location = New System.Drawing.Point(8, 146)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 16)
        Me.Label32.TabIndex = 14
        Me.Label32.Text = "Estado Civil"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_City
        '
        Me.fld_City.BackColor = System.Drawing.Color.SteelBlue
        Me.fld_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fld_City.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_City.ForeColor = System.Drawing.Color.White
        Me.fld_City.ItemHeight = 13
        Me.fld_City.Location = New System.Drawing.Point(112, 264)
        Me.fld_City.Name = "fld_City"
        Me.fld_City.Size = New System.Drawing.Size(328, 21)
        Me.fld_City.TabIndex = 25
        '
        'fld_Identity
        '
        Me.fld_Identity.BackColor = System.Drawing.Color.White
        Me.fld_Identity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_Identity.Location = New System.Drawing.Point(112, 96)
        Me.fld_Identity.MaxLength = 13
        Me.fld_Identity.Name = "fld_Identity"
        Me.fld_Identity.Size = New System.Drawing.Size(152, 20)
        Me.fld_Identity.TabIndex = 9
        Me.fld_Identity.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(440, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 22)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "..."
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCedula.Location = New System.Drawing.Point(-16, 98)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(112, 16)
        Me.lblCedula.TabIndex = 8
        Me.lblCedula.Text = "Doc. de  Identidad"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(8, 50)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(88, 16)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Socio"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label40.Location = New System.Drawing.Point(276, 122)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(32, 16)
        Me.Label40.TabIndex = 37
        Me.Label40.Text = "Edad"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.Label36)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.fld_estado_civil_gar)
        Me.TabPage1.Controls.Add(Me.fld_edad_gar)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.fld_apodo_gar)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.fld_nombre_gar)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.fld_telefono_gar)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.fld_direccion_gar)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.fld_cedula_gar)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.fld_celular_gar)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.fld_ciudad_gar)
        Me.TabPage1.Controls.Add(Me.fld_ocupacion_gar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(810, 363)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Ficha del Garante (F2)"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label36.Location = New System.Drawing.Point(8, 146)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(88, 16)
        Me.Label36.TabIndex = 10
        Me.Label36.Text = "Ocupación"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label33.Location = New System.Drawing.Point(8, 122)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(88, 16)
        Me.Label33.TabIndex = 8
        Me.Label33.Text = "Estado Civil"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_estado_civil_gar
        '
        Me.fld_estado_civil_gar.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.fld_estado_civil_gar.ForeColor = System.Drawing.Color.White
        Me.fld_estado_civil_gar.Items.AddRange(New Object() {"CASADO (A)", "SOLTERO (A)", "UNION LIBRE", "VIUDO (A)"})
        Me.fld_estado_civil_gar.Location = New System.Drawing.Point(112, 120)
        Me.fld_estado_civil_gar.Name = "fld_estado_civil_gar"
        Me.fld_estado_civil_gar.Size = New System.Drawing.Size(328, 21)
        Me.fld_estado_civil_gar.TabIndex = 9
        '
        'fld_edad_gar
        '
        Me.fld_edad_gar.BackColor = System.Drawing.Color.White
        Me.fld_edad_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_edad_gar.Location = New System.Drawing.Point(112, 96)
        Me.fld_edad_gar.Name = "fld_edad_gar"
        Me.fld_edad_gar.Size = New System.Drawing.Size(328, 20)
        Me.fld_edad_gar.TabIndex = 7
        Me.fld_edad_gar.Text = "0"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label34.Location = New System.Drawing.Point(8, 98)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(88, 16)
        Me.Label34.TabIndex = 6
        Me.Label34.Text = "Edad"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.fld_apodo_con_gar)
        Me.GroupBox5.Controls.Add(Me.fld_nombre_con_gar)
        Me.GroupBox5.Controls.Add(Me.fld_telefono_con_gar)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.fld_cedula_con_gar)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.fld_celular_con_gar)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(472, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox5.Size = New System.Drawing.Size(328, 128)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos del Cónyuge"
        '
        'fld_apodo_con_gar
        '
        Me.fld_apodo_con_gar.BackColor = System.Drawing.Color.White
        Me.fld_apodo_con_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_apodo_con_gar.Location = New System.Drawing.Point(8, 60)
        Me.fld_apodo_con_gar.MaxLength = 55
        Me.fld_apodo_con_gar.Name = "fld_apodo_con_gar"
        Me.fld_apodo_con_gar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_apodo_con_gar.Size = New System.Drawing.Size(144, 20)
        Me.fld_apodo_con_gar.TabIndex = 3
        Me.fld_apodo_con_gar.Text = ""
        '
        'fld_nombre_con_gar
        '
        Me.fld_nombre_con_gar.BackColor = System.Drawing.Color.White
        Me.fld_nombre_con_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_nombre_con_gar.Location = New System.Drawing.Point(8, 24)
        Me.fld_nombre_con_gar.MaxLength = 55
        Me.fld_nombre_con_gar.Name = "fld_nombre_con_gar"
        Me.fld_nombre_con_gar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_nombre_con_gar.Size = New System.Drawing.Size(304, 20)
        Me.fld_nombre_con_gar.TabIndex = 1
        Me.fld_nombre_con_gar.Text = ""
        '
        'fld_telefono_con_gar
        '
        Me.fld_telefono_con_gar.BackColor = System.Drawing.Color.White
        Me.fld_telefono_con_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_telefono_con_gar.Location = New System.Drawing.Point(8, 96)
        Me.fld_telefono_con_gar.MaxLength = 15
        Me.fld_telefono_con_gar.Name = "fld_telefono_con_gar"
        Me.fld_telefono_con_gar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_telefono_con_gar.Size = New System.Drawing.Size(144, 20)
        Me.fld_telefono_con_gar.TabIndex = 7
        Me.fld_telefono_con_gar.Text = ""
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(8, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Teléfono 1"
        '
        'fld_cedula_con_gar
        '
        Me.fld_cedula_con_gar.BackColor = System.Drawing.Color.White
        Me.fld_cedula_con_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_cedula_con_gar.Location = New System.Drawing.Point(172, 60)
        Me.fld_cedula_con_gar.MaxLength = 15
        Me.fld_cedula_con_gar.Name = "fld_cedula_con_gar"
        Me.fld_cedula_con_gar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_cedula_con_gar.Size = New System.Drawing.Size(144, 20)
        Me.fld_cedula_con_gar.TabIndex = 5
        Me.fld_cedula_con_gar.Text = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(8, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nombre"
        '
        'fld_celular_con_gar
        '
        Me.fld_celular_con_gar.BackColor = System.Drawing.Color.White
        Me.fld_celular_con_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_celular_con_gar.Location = New System.Drawing.Point(172, 96)
        Me.fld_celular_con_gar.MaxLength = 15
        Me.fld_celular_con_gar.Name = "fld_celular_con_gar"
        Me.fld_celular_con_gar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_celular_con_gar.Size = New System.Drawing.Size(144, 20)
        Me.fld_celular_con_gar.TabIndex = 9
        Me.fld_celular_con_gar.Text = ""
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(172, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Movil"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(8, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Apodo"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(172, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Cédula"
        '
        'fld_apodo_gar
        '
        Me.fld_apodo_gar.BackColor = System.Drawing.Color.White
        Me.fld_apodo_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_apodo_gar.Location = New System.Drawing.Point(112, 48)
        Me.fld_apodo_gar.MaxLength = 55
        Me.fld_apodo_gar.Name = "fld_apodo_gar"
        Me.fld_apodo_gar.Size = New System.Drawing.Size(328, 20)
        Me.fld_apodo_gar.TabIndex = 3
        Me.fld_apodo_gar.Text = ""
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(8, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Apodo"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_nombre_gar
        '
        Me.fld_nombre_gar.BackColor = System.Drawing.Color.White
        Me.fld_nombre_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_nombre_gar.Location = New System.Drawing.Point(112, 24)
        Me.fld_nombre_gar.MaxLength = 55
        Me.fld_nombre_gar.Name = "fld_nombre_gar"
        Me.fld_nombre_gar.Size = New System.Drawing.Size(328, 20)
        Me.fld_nombre_gar.TabIndex = 1
        Me.fld_nombre_gar.Text = ""
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.Location = New System.Drawing.Point(8, 242)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 16)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Ciudad"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_telefono_gar
        '
        Me.fld_telefono_gar.BackColor = System.Drawing.Color.White
        Me.fld_telefono_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_telefono_gar.Location = New System.Drawing.Point(112, 168)
        Me.fld_telefono_gar.MaxLength = 15
        Me.fld_telefono_gar.Name = "fld_telefono_gar"
        Me.fld_telefono_gar.Size = New System.Drawing.Size(328, 20)
        Me.fld_telefono_gar.TabIndex = 13
        Me.fld_telefono_gar.Text = ""
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label22.Location = New System.Drawing.Point(8, 170)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 16)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Teléfono 1"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_direccion_gar
        '
        Me.fld_direccion_gar.BackColor = System.Drawing.Color.White
        Me.fld_direccion_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_direccion_gar.Location = New System.Drawing.Point(112, 216)
        Me.fld_direccion_gar.MaxLength = 255
        Me.fld_direccion_gar.Name = "fld_direccion_gar"
        Me.fld_direccion_gar.Size = New System.Drawing.Size(328, 20)
        Me.fld_direccion_gar.TabIndex = 17
        Me.fld_direccion_gar.Text = ""
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.Location = New System.Drawing.Point(8, 218)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 16)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "Direccion"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_cedula_gar
        '
        Me.fld_cedula_gar.BackColor = System.Drawing.Color.White
        Me.fld_cedula_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_cedula_gar.Location = New System.Drawing.Point(112, 72)
        Me.fld_cedula_gar.MaxLength = 13
        Me.fld_cedula_gar.Name = "fld_cedula_gar"
        Me.fld_cedula_gar.Size = New System.Drawing.Size(328, 20)
        Me.fld_cedula_gar.TabIndex = 5
        Me.fld_cedula_gar.Text = ""
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label24.Location = New System.Drawing.Point(8, 74)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 16)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Cédula"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label25.Location = New System.Drawing.Point(8, 26)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Nombre"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_celular_gar
        '
        Me.fld_celular_gar.BackColor = System.Drawing.Color.White
        Me.fld_celular_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_celular_gar.Location = New System.Drawing.Point(112, 192)
        Me.fld_celular_gar.MaxLength = 15
        Me.fld_celular_gar.Name = "fld_celular_gar"
        Me.fld_celular_gar.Size = New System.Drawing.Size(328, 20)
        Me.fld_celular_gar.TabIndex = 15
        Me.fld_celular_gar.Text = ""
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.Location = New System.Drawing.Point(8, 194)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 16)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "Movil"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.fld_ref_comerciales_gar)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.fld_ref_personales_gar)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Location = New System.Drawing.Point(472, 144)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox6.Size = New System.Drawing.Size(328, 184)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Referencias"
        '
        'fld_ref_comerciales_gar
        '
        Me.fld_ref_comerciales_gar.BackColor = System.Drawing.Color.White
        Me.fld_ref_comerciales_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ref_comerciales_gar.Location = New System.Drawing.Point(8, 106)
        Me.fld_ref_comerciales_gar.MaxLength = 510
        Me.fld_ref_comerciales_gar.Multiline = True
        Me.fld_ref_comerciales_gar.Name = "fld_ref_comerciales_gar"
        Me.fld_ref_comerciales_gar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_ref_comerciales_gar.Size = New System.Drawing.Size(302, 70)
        Me.fld_ref_comerciales_gar.TabIndex = 1
        Me.fld_ref_comerciales_gar.Text = ""
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.Location = New System.Drawing.Point(8, 90)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(88, 16)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "Comerciales"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_ref_personales_gar
        '
        Me.fld_ref_personales_gar.BackColor = System.Drawing.Color.White
        Me.fld_ref_personales_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ref_personales_gar.Location = New System.Drawing.Point(8, 32)
        Me.fld_ref_personales_gar.MaxLength = 510
        Me.fld_ref_personales_gar.Multiline = True
        Me.fld_ref_personales_gar.Name = "fld_ref_personales_gar"
        Me.fld_ref_personales_gar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_ref_personales_gar.Size = New System.Drawing.Size(304, 56)
        Me.fld_ref_personales_gar.TabIndex = 2
        Me.fld_ref_personales_gar.Text = ""
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label28.Location = New System.Drawing.Point(8, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(88, 16)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Personales"
        '
        'fld_ciudad_gar
        '
        Me.fld_ciudad_gar.BackColor = System.Drawing.Color.SteelBlue
        Me.fld_ciudad_gar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fld_ciudad_gar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_ciudad_gar.ForeColor = System.Drawing.Color.White
        Me.fld_ciudad_gar.ItemHeight = 13
        Me.fld_ciudad_gar.Location = New System.Drawing.Point(112, 240)
        Me.fld_ciudad_gar.Name = "fld_ciudad_gar"
        Me.fld_ciudad_gar.Size = New System.Drawing.Size(328, 21)
        Me.fld_ciudad_gar.TabIndex = 19
        '
        'fld_ocupacion_gar
        '
        Me.fld_ocupacion_gar.BackColor = System.Drawing.Color.White
        Me.fld_ocupacion_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ocupacion_gar.Location = New System.Drawing.Point(112, 144)
        Me.fld_ocupacion_gar.MaxLength = 55
        Me.fld_ocupacion_gar.Name = "fld_ocupacion_gar"
        Me.fld_ocupacion_gar.Size = New System.Drawing.Size(328, 20)
        Me.fld_ocupacion_gar.TabIndex = 11
        Me.fld_ocupacion_gar.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.fldtiempoempresa)
        Me.TabPage2.Controls.Add(Me.Label50)
        Me.TabPage2.Controls.Add(Me.balancePrestamosTxt)
        Me.TabPage2.Controls.Add(Me.Label49)
        Me.TabPage2.Controls.Add(Me.disponibilidadTxt)
        Me.TabPage2.Controls.Add(Me.Label48)
        Me.TabPage2.Controls.Add(Me.balanceGralTxt)
        Me.TabPage2.Controls.Add(Me.Label47)
        Me.TabPage2.Controls.Add(Me.aportacionMontoTxt)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.dtpFechaIngresos)
        Me.TabPage2.Controls.Add(Me.ListView3)
        Me.TabPage2.Controls.Add(Me.ListView2)
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Controls.Add(Me.btnOtrasObligaciones)
        Me.TabPage2.Controls.Add(Me.btnEstadoIngresoEgresos)
        Me.TabPage2.Controls.Add(Me.btnCuentasBanco)
        Me.TabPage2.Controls.Add(Me.Label39)
        Me.TabPage2.Controls.Add(Me.Label38)
        Me.TabPage2.Controls.Add(Me.Label37)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.txtReferidoPor)
        Me.TabPage2.Controls.Add(Me.txtOriundo)
        Me.TabPage2.Controls.Add(Me.txtPuesto)
        Me.TabPage2.Controls.Add(Me.fld_ingresos_mesuales)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.fld_otra_informacion)
        Me.TabPage2.Controls.Add(Me.fld_nombre_banco1)
        Me.TabPage2.Controls.Add(Me.fld_nombre_banco2)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(810, 363)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Otras informaciones (F3)"
        '
        'fldtiempoempresa
        '
        Me.fldtiempoempresa.BackColor = System.Drawing.Color.White
        Me.fldtiempoempresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fldtiempoempresa.Enabled = False
        Me.fldtiempoempresa.Location = New System.Drawing.Point(296, 64)
        Me.fldtiempoempresa.MaxLength = 20
        Me.fldtiempoempresa.Multiline = True
        Me.fldtiempoempresa.Name = "fldtiempoempresa"
        Me.fldtiempoempresa.ReadOnly = True
        Me.fldtiempoempresa.Size = New System.Drawing.Size(232, 24)
        Me.fldtiempoempresa.TabIndex = 37
        Me.fldtiempoempresa.Text = ""
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(88, 288)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(136, 23)
        Me.Label50.TabIndex = 32
        Me.Label50.Text = "Bce. de Préstamos"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'balancePrestamosTxt
        '
        Me.balancePrestamosTxt.Enabled = False
        Me.balancePrestamosTxt.Location = New System.Drawing.Point(232, 288)
        Me.balancePrestamosTxt.Name = "balancePrestamosTxt"
        Me.balancePrestamosTxt.Size = New System.Drawing.Size(144, 20)
        Me.balancePrestamosTxt.TabIndex = 31
        Me.balancePrestamosTxt.Text = "0.00"
        Me.balancePrestamosTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(416, 288)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(80, 23)
        Me.Label49.TabIndex = 30
        Me.Label49.Text = "Diponibilidad"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'disponibilidadTxt
        '
        Me.disponibilidadTxt.Enabled = False
        Me.disponibilidadTxt.Location = New System.Drawing.Point(504, 288)
        Me.disponibilidadTxt.Name = "disponibilidadTxt"
        Me.disponibilidadTxt.Size = New System.Drawing.Size(144, 20)
        Me.disponibilidadTxt.TabIndex = 29
        Me.disponibilidadTxt.Text = "0.00"
        Me.disponibilidadTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(416, 256)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(80, 23)
        Me.Label48.TabIndex = 28
        Me.Label48.Text = "Balance"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'balanceGralTxt
        '
        Me.balanceGralTxt.Enabled = False
        Me.balanceGralTxt.Location = New System.Drawing.Point(504, 256)
        Me.balanceGralTxt.Name = "balanceGralTxt"
        Me.balanceGralTxt.Size = New System.Drawing.Size(144, 20)
        Me.balanceGralTxt.TabIndex = 27
        Me.balanceGralTxt.Text = "0.00"
        Me.balanceGralTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label47
        '
        Me.Label47.Location = New System.Drawing.Point(144, 255)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(80, 23)
        Me.Label47.TabIndex = 26
        Me.Label47.Text = "Aportaciones"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'aportacionMontoTxt
        '
        Me.aportacionMontoTxt.Enabled = False
        Me.aportacionMontoTxt.Location = New System.Drawing.Point(232, 256)
        Me.aportacionMontoTxt.Name = "aportacionMontoTxt"
        Me.aportacionMontoTxt.Size = New System.Drawing.Size(144, 20)
        Me.aportacionMontoTxt.TabIndex = 25
        Me.aportacionMontoTxt.Text = "0.00"
        Me.aportacionMontoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ahorroBalanceTxt)
        Me.GroupBox1.Controls.Add(Me.ahorroSalidaTxt)
        Me.GroupBox1.Controls.Add(Me.ahorroEntradaTxt)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Location = New System.Drawing.Point(136, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 100)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta de ahorro"
        '
        'ahorroBalanceTxt
        '
        Me.ahorroBalanceTxt.Enabled = False
        Me.ahorroBalanceTxt.Location = New System.Drawing.Point(96, 73)
        Me.ahorroBalanceTxt.Name = "ahorroBalanceTxt"
        Me.ahorroBalanceTxt.Size = New System.Drawing.Size(144, 20)
        Me.ahorroBalanceTxt.TabIndex = 5
        Me.ahorroBalanceTxt.Text = "0.00"
        Me.ahorroBalanceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ahorroSalidaTxt
        '
        Me.ahorroSalidaTxt.Enabled = False
        Me.ahorroSalidaTxt.Location = New System.Drawing.Point(96, 41)
        Me.ahorroSalidaTxt.Name = "ahorroSalidaTxt"
        Me.ahorroSalidaTxt.Size = New System.Drawing.Size(144, 20)
        Me.ahorroSalidaTxt.TabIndex = 4
        Me.ahorroSalidaTxt.Text = "0.00"
        Me.ahorroSalidaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ahorroEntradaTxt
        '
        Me.ahorroEntradaTxt.Enabled = False
        Me.ahorroEntradaTxt.Location = New System.Drawing.Point(96, 17)
        Me.ahorroEntradaTxt.Name = "ahorroEntradaTxt"
        Me.ahorroEntradaTxt.Size = New System.Drawing.Size(144, 20)
        Me.ahorroEntradaTxt.TabIndex = 3
        Me.ahorroEntradaTxt.Text = "0.00"
        Me.ahorroEntradaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(8, 16)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(80, 23)
        Me.Label43.TabIndex = 2
        Me.Label43.Text = "Depositos"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(8, 72)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(80, 23)
        Me.Label42.TabIndex = 1
        Me.Label42.Text = "Balance"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(8, 40)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(80, 23)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Retiros"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFechaIngresos
        '
        Me.dtpFechaIngresos.CustomFormat = "dd-MMM-yyyy"
        Me.dtpFechaIngresos.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaIngresos.Location = New System.Drawing.Point(136, 64)
        Me.dtpFechaIngresos.Name = "dtpFechaIngresos"
        Me.dtpFechaIngresos.Size = New System.Drawing.Size(160, 20)
        Me.dtpFechaIngresos.TabIndex = 22
        '
        'ListView3
        '
        Me.ListView3.Location = New System.Drawing.Point(680, 328)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(120, 56)
        Me.ListView3.TabIndex = 21
        Me.ListView3.Visible = False
        '
        'ListView2
        '
        Me.ListView2.Location = New System.Drawing.Point(568, 328)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(108, 56)
        Me.ListView2.TabIndex = 19
        Me.ListView2.Visible = False
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(480, 328)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(88, 56)
        Me.ListView1.TabIndex = 17
        Me.ListView1.Visible = False
        '
        'btnOtrasObligaciones
        '
        Me.btnOtrasObligaciones.Location = New System.Drawing.Point(680, 304)
        Me.btnOtrasObligaciones.Name = "btnOtrasObligaciones"
        Me.btnOtrasObligaciones.Size = New System.Drawing.Size(48, 23)
        Me.btnOtrasObligaciones.TabIndex = 20
        Me.btnOtrasObligaciones.Text = "Préstamos u Otras Obligaciones"
        Me.btnOtrasObligaciones.Visible = False
        '
        'btnEstadoIngresoEgresos
        '
        Me.btnEstadoIngresoEgresos.Location = New System.Drawing.Point(568, 304)
        Me.btnEstadoIngresoEgresos.Name = "btnEstadoIngresoEgresos"
        Me.btnEstadoIngresoEgresos.Size = New System.Drawing.Size(100, 23)
        Me.btnEstadoIngresoEgresos.TabIndex = 18
        Me.btnEstadoIngresoEgresos.Text = "Estado de Ingresos y Egresos"
        Me.btnEstadoIngresoEgresos.Visible = False
        '
        'btnCuentasBanco
        '
        Me.btnCuentasBanco.Location = New System.Drawing.Point(480, 304)
        Me.btnCuentasBanco.Name = "btnCuentasBanco"
        Me.btnCuentasBanco.Size = New System.Drawing.Size(88, 23)
        Me.btnCuentasBanco.TabIndex = 16
        Me.btnCuentasBanco.Text = "Cuentas de Banco"
        Me.btnCuentasBanco.Visible = False
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(536, 8)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(136, 16)
        Me.Label39.TabIndex = 12
        Me.Label39.Text = "Referencia Familiar"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label38.Location = New System.Drawing.Point(8, 112)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(120, 16)
        Me.Label38.TabIndex = 8
        Me.Label38.Text = "Oriundo de..:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label37.Location = New System.Drawing.Point(8, 88)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(120, 16)
        Me.Label37.TabIndex = 6
        Me.Label37.Text = "Referido por..:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label29.Location = New System.Drawing.Point(8, 64)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(120, 16)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Ingresó al trabajo..:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(8, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 16)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Puesto en el trabajo..:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtReferidoPor
        '
        Me.txtReferidoPor.Location = New System.Drawing.Point(136, 88)
        Me.txtReferidoPor.MaxLength = 100
        Me.txtReferidoPor.Name = "txtReferidoPor"
        Me.txtReferidoPor.Size = New System.Drawing.Size(392, 20)
        Me.txtReferidoPor.TabIndex = 7
        Me.txtReferidoPor.Text = ""
        '
        'txtOriundo
        '
        Me.txtOriundo.Location = New System.Drawing.Point(136, 112)
        Me.txtOriundo.MaxLength = 100
        Me.txtOriundo.Name = "txtOriundo"
        Me.txtOriundo.Size = New System.Drawing.Size(392, 20)
        Me.txtOriundo.TabIndex = 9
        Me.txtOriundo.Text = ""
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New System.Drawing.Point(136, 40)
        Me.txtPuesto.MaxLength = 100
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(160, 20)
        Me.txtPuesto.TabIndex = 3
        Me.txtPuesto.Text = ""
        '
        'fld_ingresos_mesuales
        '
        Me.fld_ingresos_mesuales.BackColor = System.Drawing.Color.White
        Me.fld_ingresos_mesuales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ingresos_mesuales.Location = New System.Drawing.Point(136, 16)
        Me.fld_ingresos_mesuales.MaxLength = 14
        Me.fld_ingresos_mesuales.Name = "fld_ingresos_mesuales"
        Me.fld_ingresos_mesuales.Size = New System.Drawing.Size(104, 20)
        Me.fld_ingresos_mesuales.TabIndex = 1
        Me.fld_ingresos_mesuales.Text = "0.00"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label30.Location = New System.Drawing.Point(8, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(120, 16)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Ingresos Mensuales..:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_otra_informacion
        '
        Me.fld_otra_informacion.BackColor = System.Drawing.Color.White
        Me.fld_otra_informacion.Location = New System.Drawing.Point(680, 8)
        Me.fld_otra_informacion.MaxLength = 510
        Me.fld_otra_informacion.Name = "fld_otra_informacion"
        Me.fld_otra_informacion.Size = New System.Drawing.Size(56, 20)
        Me.fld_otra_informacion.TabIndex = 13
        Me.fld_otra_informacion.Text = "N/A"
        Me.fld_otra_informacion.Visible = False
        '
        'fld_nombre_banco1
        '
        Me.fld_nombre_banco1.BackColor = System.Drawing.Color.White
        Me.fld_nombre_banco1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_nombre_banco1.Location = New System.Drawing.Point(736, 8)
        Me.fld_nombre_banco1.MaxLength = 55
        Me.fld_nombre_banco1.Name = "fld_nombre_banco1"
        Me.fld_nombre_banco1.Size = New System.Drawing.Size(64, 20)
        Me.fld_nombre_banco1.TabIndex = 14
        Me.fld_nombre_banco1.Text = "N/A"
        Me.fld_nombre_banco1.Visible = False
        '
        'fld_nombre_banco2
        '
        Me.fld_nombre_banco2.BackColor = System.Drawing.Color.White
        Me.fld_nombre_banco2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_nombre_banco2.Location = New System.Drawing.Point(536, 24)
        Me.fld_nombre_banco2.MaxLength = 55
        Me.fld_nombre_banco2.Multiline = True
        Me.fld_nombre_banco2.Name = "fld_nombre_banco2"
        Me.fld_nombre_banco2.Size = New System.Drawing.Size(264, 104)
        Me.fld_nombre_banco2.TabIndex = 15
        Me.fld_nombre_banco2.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.certificadoBalanceTxt)
        Me.GroupBox4.Controls.Add(Me.certificadoSalidaTxt)
        Me.GroupBox4.Controls.Add(Me.certificadoEntradaTxt)
        Me.GroupBox4.Controls.Add(Me.Label44)
        Me.GroupBox4.Controls.Add(Me.Label45)
        Me.GroupBox4.Controls.Add(Me.Label46)
        Me.GroupBox4.Location = New System.Drawing.Point(408, 144)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 100)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cuenta de certificado"
        '
        'certificadoBalanceTxt
        '
        Me.certificadoBalanceTxt.Enabled = False
        Me.certificadoBalanceTxt.Location = New System.Drawing.Point(96, 73)
        Me.certificadoBalanceTxt.Name = "certificadoBalanceTxt"
        Me.certificadoBalanceTxt.Size = New System.Drawing.Size(144, 20)
        Me.certificadoBalanceTxt.TabIndex = 5
        Me.certificadoBalanceTxt.Text = "0.00"
        Me.certificadoBalanceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'certificadoSalidaTxt
        '
        Me.certificadoSalidaTxt.Enabled = False
        Me.certificadoSalidaTxt.Location = New System.Drawing.Point(96, 41)
        Me.certificadoSalidaTxt.Name = "certificadoSalidaTxt"
        Me.certificadoSalidaTxt.Size = New System.Drawing.Size(144, 20)
        Me.certificadoSalidaTxt.TabIndex = 4
        Me.certificadoSalidaTxt.Text = "0.00"
        Me.certificadoSalidaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'certificadoEntradaTxt
        '
        Me.certificadoEntradaTxt.Enabled = False
        Me.certificadoEntradaTxt.Location = New System.Drawing.Point(96, 17)
        Me.certificadoEntradaTxt.Name = "certificadoEntradaTxt"
        Me.certificadoEntradaTxt.Size = New System.Drawing.Size(144, 20)
        Me.certificadoEntradaTxt.TabIndex = 3
        Me.certificadoEntradaTxt.Text = "0.00"
        Me.certificadoEntradaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(8, 16)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(80, 23)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "Depositos"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(8, 72)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(80, 23)
        Me.Label45.TabIndex = 1
        Me.Label45.Text = "Balance"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(8, 40)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(80, 23)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "Retiros"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(80, 400)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 56)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&Lista de Socios"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(152, 400)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(72, 56)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.Visible = False
        '
        'cmbEstado
        '
        Me.cmbEstado.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.cmbEstado.ForeColor = System.Drawing.Color.White
        Me.cmbEstado.Items.AddRange(New Object() {"BUENO", "MALO", "DESLINDE", "OTROS"})
        Me.cmbEstado.Location = New System.Drawing.Point(656, 392)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(120, 21)
        Me.cmbEstado.TabIndex = 7
        Me.cmbEstado.Text = "BUENO"
        Me.cmbEstado.Visible = False
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(544, 392)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 16)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Estado...:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Visible = False
        '
        'fotoBtn
        '
        Me.fotoBtn.BackColor = System.Drawing.SystemColors.Control
        Me.fotoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.fotoBtn.ForeColor = System.Drawing.Color.Black
        Me.fotoBtn.Image = CType(resources.GetObject("fotoBtn.Image"), System.Drawing.Image)
        Me.fotoBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.fotoBtn.Location = New System.Drawing.Point(384, 400)
        Me.fotoBtn.Name = "fotoBtn"
        Me.fotoBtn.Size = New System.Drawing.Size(88, 56)
        Me.fotoBtn.TabIndex = 5
        Me.fotoBtn.TabStop = False
        Me.fotoBtn.Text = "&Agregar foto"
        Me.fotoBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.fotoBtn.Visible = False
        '
        'lblCuentaContable
        '
        Me.lblCuentaContable.Location = New System.Drawing.Point(504, 416)
        Me.lblCuentaContable.Name = "lblCuentaContable"
        Me.lblCuentaContable.Size = New System.Drawing.Size(272, 16)
        Me.lblCuentaContable.TabIndex = 8
        Me.lblCuentaContable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.BackColor = System.Drawing.Color.White
        Me.txtCuentaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContable.Location = New System.Drawing.Point(584, 438)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.ReadOnly = True
        Me.txtCuentaContable.Size = New System.Drawing.Size(160, 20)
        Me.txtCuentaContable.TabIndex = 10
        Me.txtCuentaContable.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(480, 440)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Cuenta Contable"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'buscaCtaContableBtn
        '
        Me.buscaCtaContableBtn.Image = CType(resources.GetObject("buscaCtaContableBtn.Image"), System.Drawing.Image)
        Me.buscaCtaContableBtn.Location = New System.Drawing.Point(744, 437)
        Me.buscaCtaContableBtn.Name = "buscaCtaContableBtn"
        Me.buscaCtaContableBtn.Size = New System.Drawing.Size(32, 23)
        Me.buscaCtaContableBtn.TabIndex = 11
        '
        'FRM_CLIENTES
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(818, 468)
        Me.Controls.Add(Me.buscaCtaContableBtn)
        Me.Controls.Add(Me.lblCuentaContable)
        Me.Controls.Add(Me.txtCuentaContable)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.fotoBtn)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_CLIENTES"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Socios"
        Me.TabControl.ResumeLayout(False)
        Me.TP_FICHA_GRAL1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRM_CLIENTES_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarZona()
        LlenarCiudad()
        LlenarTipoDocumento()
    End Sub

    Private Sub FRM_CLIENTES_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        If e.KeyChar = vbCr Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If

    End Sub

    Private Sub establecerDisponibilidad(ByVal idCliente As Integer)

        '//// APORTACIONES
        Dim aportacion As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) AS monto FROM tbl_ahorros_aportacion WHERE IDSocio=" & idCliente & ";")
        aportacionMontoTxt.Text = Format(aportacion, "N2")

        '//// CERTIFICADOS
        Dim depositoCertificado As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(SaldoCapital),0) AS monto FROM tbl_ahorros_certificado WHERE IDCliente=" & idCliente & ";")
        certificadoEntradaTxt.Text = Format(depositoCertificado, "N2")

        Dim retiroCertificado As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) AS monto FROM tbl_ahorros_certificado_retiros WHERE IDCliente=" & idCliente & ";")
        certificadoSalidaTxt.Text = Format(retiroCertificado, "N2")
        certificadoBalanceTxt.Text = Format(depositoCertificado - retiroCertificado, "N2")

        '//// AHORROS
        Dim ahorroDeposito As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) AS monto FROM tbl_ahorros_depositos WHERE IDCliente=" & idCliente & ";")
        ahorroEntradaTxt.Text = Format(ahorroDeposito, "N2")
        Dim ahorroRetiro As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) AS monto FROM tbl_ahorros_retiros WHERE IDCliente=" & idCliente & ";")
        ahorroSalidaTxt.Text = Format(ahorroRetiro, "N2")
        ahorroBalanceTxt.Text = Format(ahorroDeposito - ahorroRetiro, "N2")

        '//// PRESTAMOS
        Dim balancePrestamos As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(fld_capital_cuota_balance),0) AS monto FROM tbl_cuotas WHERE fld_id_del_cliente_cuotas=" & idCliente & ";")

        balancePrestamosTxt.Text = Format(balancePrestamos, "N2")

        '//// RESUMEN 
        balanceGralTxt.Text = Format((aportacion + CDec(certificadoBalanceTxt.Text) + CDec(ahorroBalanceTxt.Text)) - balancePrestamos, "N2")

        '//// DISPONIBILIDAD
        Dim dispo As Decimal = SCALAR_NUM("SELECT DispPignorada FROM parametrosgenerales WHERE ID=1")
        disponibilidadTxt.Text = Format(balanceGralTxt.Text * dispo, "N2")

        txtLimite.Text = Format(balanceGralTxt.Text * dispo, "N2")
        NON_QUERY("UPDATE tbl_clientes SET fld_limite=" & CDbl(txtLimite.Text) & " WHERE fld_id=" & fld_Codigo.Text & "")

    End Sub


    Private Sub LlenarCiudad()

        Dim da As New MySqlDataAdapter("SELECT fldCodigo, fldDescripcion FROM tbl_ciudad ORDER BY fldDescripcion", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        fld_City.DataSource = dt
        fld_City.DisplayMember = "fldDescripcion"
        fld_City.ValueMember = "fldCodigo"

        fld_ciudad_gar.DataSource = dt
        fld_ciudad_gar.DisplayMember = "fldDescripcion"
        fld_ciudad_gar.ValueMember = "fldCodigo"

    End Sub
    Private Sub LlenarTipoDocumento()

        Dim da As New MySqlDataAdapter("SELECT ID, Descripcion FROM tbl_tipos_documentos ORDER BY ID", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbTipoDocumento.DataSource = dt
        cmbTipoDocumento.DisplayMember = "Descripcion"
        cmbTipoDocumento.ValueMember = "ID"

    End Sub
    Private Sub ClearFields()
        dtpFechaIngresos.Value = Now.Date
        fldtiempoempresa.Text = String.Empty
        fldedad.Text = String.Empty
        emailTxt.Text = String.Empty
        fld_Codigo.Text = ""
        fld_Codigo.ReadOnly = False
        fld_FullName.Text = ""
        fld_apodo.Text = ""
        fld_Identity.Text = ""
        fld_Phone.Text = ""
        fld_Phone2.Text = ""
        fld_Address.Text = ""
        fld_City.Text = ""
        cmbTipoDocumento.SelectedIndex = 1
        fld_nombre_con.Text = ""
        fld_apodo_con.Text = ""
        fld_cedula_con.Text = ""
        fld_telefono_con.Text = ""
        fld_celular_con.Text = ""
        fld_ref_personales_cliente.Text = ""
        fld_ref_comerciales_cliente.Text = ""
        fld_nombre_gar.Text = ""
        fld_apodo_gar.Text = ""
        fld_cedula_gar.Text = ""
        fld_telefono_gar.Text = ""
        fld_celular_gar.Text = ""
        fld_direccion_gar.Text = ""
        fld_ciudad_gar.Text = ""
        fld_ref_personales_gar.Text = ""
        fld_ref_comerciales_gar.Text = ""
        fld_ingresos_mesuales.Text = "0.00"
        fld_nombre_banco1.Text = ""

        fld_nombre_banco2.Text = ""
        txtCuentaContable.Text = ""
        lblCuentaContable.Text = ""
        fld_otra_informacion.Text = ""
        fld_nombre_con_gar.Text = ""
        fld_apodo_con_gar.Text = ""
        fld_cedula_con_gar.Text = ""
        fld_telefono_con_gar.Text = ""
        fld_celular_con_gar.Text = ""
        dtpEdad.Value = Now.Date
        fld_estado_civil.Text = Nothing
        fld_edad_gar.Text = ""
        fld_estado_civil_gar.Text = Nothing
        fld_ocupacion_cliente.Text = ""
        fld_ocupacion_gar.Text = ""
        txtPuesto.Text = String.Empty
        dtpFechaIngresos.Value = Now.Date
        txtReferidoPor.Text = String.Empty
        txtOriundo.Text = String.Empty
        btnGuardar.Text = "&Guardar"
        cmbEstado.Text = "BUENO"
        lblLimite.Visible = False
        txtLimite.Visible = False
        btnLimite.Visible = False
        fotoBtn.Visible = False
    End Sub

    Private Sub SaveData()
        Try
            If Trim(fld_ingresos_mesuales.Text) = "" Then
                fld_ingresos_mesuales.Text = 0
            End If

            If Trim(fld_edad_gar.Text) = "" Then
                fld_edad_gar.Text = 0
            End If

            Dim cmd As New MySqlCommand

            With cmd
                .CommandText = "INSERT INTO tbl_clientes (fld_FullName, fld_apodo, TipoDocumento, fld_Identity, fld_Phone, fld_Phone2, fld_Address, fld_City, fld_Status, fld_bce, fld_cod_zona, fld_zona, fld_nombre_con,  fld_apodo_con,  fld_cedula_con,   fld_telefono_con,  fld_celular_con,   fld_ref_personales_cliente,   fld_ref_comerciales_cliente,  fld_nombre_gar,   fld_apodo_gar,   fld_cedula_gar,   fld_telefono_gar,  fld_celular_gar,   fld_direccion_gar,   fld_ciudad_gar,  fld_ref_personales_gar,  fld_ref_comerciales_gar,  fld_ingresos_mesuales,   fld_nombre_banco1,   fld_cuenta_banco1,   fld_nombre_banco2,   fld_cuenta_banco2,   fld_otra_informacion, fld_nombre_con_gar, fld_apodo_con_gar,fld_cedula_con_gar,fld_telefono_con_gar, fld_celular_con_gar, fld_edad, fld_estado_civil, fld_edad_gar, fld_estado_civil_gar, fld_ocupacion_cliente, fld_ocupacion_gar, fld_categoria, Puesto, ReferidoPor, Oriundo,ctaContable,email,fechaIngreso) VALUES('" & fld_FullName.Text & "','" & fld_apodo.Text & "'," & cmbTipoDocumento.SelectedValue & " ,'" & fld_Identity.Text & "', '" & fld_Phone.Text & "', '" & fld_Phone2.Text & "', '" & fld_Address.Text & "','" & fld_City.Text & "', 'N',0, " & cmdZonas.SelectedValue & ", '" & cmdZonas.Text & "', '" & fld_nombre_con.Text & " ','" & fld_apodo_con.Text & "','" & fld_cedula_con.Text & "','" & fld_telefono_con.Text & "','" & fld_celular_con.Text & "','" & fld_ref_personales_cliente.Text & "','" & fld_ref_comerciales_cliente.Text & "','" & fld_nombre_gar.Text & "','" & fld_apodo_gar.Text & "','" & fld_cedula_gar.Text & "','" & fld_telefono_gar.Text & "','" & fld_celular_gar.Text & "','" & fld_direccion_gar.Text & "','" & fld_ciudad_gar.Text & "','" & fld_ref_personales_gar.Text & "','" & fld_ref_comerciales_gar.Text & "'," & CDbl(fld_ingresos_mesuales.Text) & ",'" & fld_nombre_banco1.Text & "','','" & fld_nombre_banco2.Text & "','','" & fld_otra_informacion.Text & "', '" & fld_nombre_con_gar.Text & " ', '" & fld_apodo_con_gar.Text & "', '" & fld_cedula_con_gar.Text & "', '" & fld_telefono_con_gar.Text & "', '" & fld_celular_con_gar.Text & "',  '" & formatDate(dtpEdad.Value.Date) & "', '" & fld_estado_civil.Text & "',  " & CInt(fld_edad_gar.Text) & ", '" & fld_estado_civil_gar.Text & "',  '" & fld_ocupacion_cliente.Text & "', '" & fld_ocupacion_gar.Text & "','" & cmbEstado.Text & "','" & txtPuesto.Text & "','" & txtReferidoPor.Text & "','" & txtOriundo.Text & "','" & txtCuentaContable.Text & "','" & emailTxt.Text & "','" & formatDate(dtpFechaIngresos.Value.Date) & "')"
                .Connection = conn
                .Connection.Open()
                .ExecuteNonQuery()
                .Connection.Close()
            End With



            cmd.Dispose()
            fld_Codigo.Text = Format(UltimoID("tbl_clientes", "fld_id"), "0000")
            fld_Codigo.ReadOnly = True
            btnGuardar.Text = "&Modificar"
            fotoBtn.Visible = True
            btnLimite.Visible = True
            txtLimite.Visible = True
            lblLimite.Visible = True
        Catch ex As Exception
            Alerta(ex.Message)
        End Try
    End Sub

    Private Sub save_doc()

        CloseConn()


        If Trim(fld_edad_gar.Text) = "" Then
            fld_edad_gar.Text = 0
        End If
        If ValidaFields() = False Then Exit Sub
        If btnGuardar.Text = "&Guardar" Then

            If Alerta("Guardando Datos, ¿Seguro que desea guardar?") = True Then
                SaveData()
            End If
        Else
            If FRMS_CLAVE_MAESTRA("Acceso") = False Then Exit Sub
            UpDateData(CInt(fld_Codigo.Text))
        End If


    End Sub

    Private Sub LoadData(ByVal idCliente As Integer)


        Dim cmd As New MySqlCommand, dr As MySqlDataReader

        With cmd
            .CommandText = "SELECT * FROM tbl_clientes WHERE fld_id=" & idCliente & ""
            .Connection = conn
            .Connection.Open()
            dr = .ExecuteReader
        End With
        Dim z As String = ""
        If dr.Read Then
            fld_Codigo.Text = idCliente
            fld_FullName.Text = dr("fld_FullName")
            fld_apodo.Text = dr("fld_apodo")
            fld_Identity.Text = dr("fld_Identity")
            fld_Phone.Text = dr("fld_Phone")
            fld_Phone2.Text = dr("fld_Phone2")
            fld_Address.Text = dr("fld_Address")
            cmbTipoDocumento.SelectedValue = dr("TipoDocumento")
            fld_City.Text = dr("fld_City")
            fld_nombre_con.Text = dr("fld_nombre_con")
            fld_apodo_con.Text = dr("fld_apodo_con")
            fld_cedula_con.Text = dr("fld_cedula_con")
            fld_telefono_con.Text = dr("fld_telefono_con")
            fld_celular_con.Text = dr("fld_celular_con")
            fld_ref_personales_cliente.Text = dr("fld_ref_personales_cliente")
            fld_ref_comerciales_cliente.Text = dr("fld_ref_comerciales_cliente")
            fld_nombre_gar.Text = dr("fld_nombre_gar")
            fld_apodo_gar.Text = dr("fld_apodo_gar")
            fld_cedula_gar.Text = dr("fld_cedula_gar")
            fld_telefono_gar.Text = dr("fld_telefono_gar")
            fld_celular_gar.Text = dr("fld_celular_gar")
            fld_direccion_gar.Text = dr("fld_direccion_gar")
            fld_ciudad_gar.Text = dr("fld_ciudad_gar")
            fld_ref_personales_gar.Text = dr("fld_ref_personales_gar")
            fld_ref_comerciales_gar.Text = dr("fld_ref_comerciales_gar")
            fld_ingresos_mesuales.Text = dr("fld_ingresos_mesuales")
            fld_nombre_banco1.Text = dr("fld_nombre_banco1")

            fld_nombre_banco2.Text = dr("fld_nombre_banco2")

            fld_otra_informacion.Text = dr("fld_otra_informacion")



            txtPuesto.Text = dr("Puesto")
            dtpFechaIngresos.Value = dr("fechaIngreso")
            txtReferidoPor.Text = dr("ReferidoPor")
            txtOriundo.Text = dr("Oriundo")

            fld_nombre_con_gar.Text = dr("fld_nombre_con_gar")
            fld_apodo_con_gar.Text = dr("fld_apodo_con_gar")
            fld_cedula_con_gar.Text = dr("fld_cedula_con_gar")
            fld_telefono_con_gar.Text = dr("fld_telefono_con_gar")
            fld_celular_con_gar.Text = dr("fld_celular_con_gar")
            dtpEdad.Value = dr("fld_edad")
            fld_estado_civil.Text = dr("fld_estado_civil")
            fld_edad_gar.Text = dr("fld_edad_gar")
            fld_estado_civil_gar.Text = dr("fld_estado_civil_gar")

            fld_ocupacion_cliente.Text = dr("fld_ocupacion_cliente")
            fld_ocupacion_gar.Text = dr("fld_ocupacion_gar")
            cmdZonas.SelectedValue = dr("fld_cod_zona")
            cmbEstado.Text = dr("fld_categoria")
            txtCuentaContable.Text = dr("ctaContable")
            emailTxt.Text = dr("email")
            dtpFechaIngresos.Value = dr("fechaIngreso")
            lblLimite.Visible = True
            txtLimite.Visible = True
            btnLimite.Visible = True
            fld_Codigo.ReadOnly = True
            fotoBtn.Visible = True
            btnGuardar.Text = "&Modificar"

            fldedad.Text = edadExacta(dtpEdad.Value)
            fldtiempoempresa.Text = edadExacta(dtpFechaIngresos.Value)
        Else
            btnGuardar.Text = "&Guardar"

            Alerta("NO SE ENCONTRO DATOS, INTENTE DE NUEVO")
            ClearFields()
            fld_Codigo.Focus()
        End If

        dr.Close()
        dr = Nothing
        cmd.Connection.Close()
        cmd = Nothing
        establecerDisponibilidad(idCliente)
        txtLimite.Text = Format(SCALAR_NUM("SELECT fld_limite FROM tbl_clientes WHERE fld_id=" & idCliente & ""), "N2")

        lblCuentaContable.Text = ReturnDescripcion(txtCuentaContable.Text)
    End Sub

    Private Sub UpDateData(ByVal id_doc As Integer)

        Dim cmd As New MySqlCommand

        With cmd

            .CommandText = "UPDATE tbl_clientes SET TipoDocumento=" & cmbTipoDocumento.SelectedValue & ",fld_FullName='" & fld_FullName.Text & "', fld_apodo='" & fld_apodo.Text & "', fld_Identity='" & fld_Identity.Text & "', fld_Phone='" & fld_Phone.Text & "', fld_Phone2='" & fld_Phone2.Text & "', fld_Address='" & fld_Address.Text & "', fld_City='" & fld_City.Text & "', fld_Status='N', fld_bce=0, fld_cod_zona=" & cmdZonas.SelectedValue & ", fld_zona='" & cmdZonas.Text & "', fld_nombre_con='" & fld_nombre_con.Text & "',  fld_apodo_con='" & fld_apodo_con.Text & "',  fld_cedula_con='" & fld_cedula_con.Text & "',   fld_telefono_con='" & fld_telefono_con.Text & "',  fld_celular_con='" & fld_celular_con.Text & "',   fld_ref_personales_cliente='" & fld_ref_personales_cliente.Text & "',   fld_ref_comerciales_cliente='" & fld_ref_comerciales_cliente.Text & "',  fld_nombre_gar='" & fld_nombre_gar.Text & "',   fld_apodo_gar='" & fld_apodo_gar.Text & "',   fld_cedula_gar='" & fld_cedula_gar.Text & "',   fld_telefono_gar='" & fld_telefono_gar.Text & "',  fld_celular_gar='" & fld_celular_gar.Text & "',   fld_direccion_gar='" & fld_direccion_gar.Text & "',   fld_ciudad_gar='" & fld_ciudad_gar.Text & "',  fld_ref_personales_gar='" & fld_ref_personales_gar.Text & "',  fld_ref_comerciales_gar='" & fld_ref_comerciales_gar.Text & "',  fld_ingresos_mesuales=" & CDbl(fld_ingresos_mesuales.Text) & ",   fld_nombre_banco1='" & fld_nombre_banco1.Text & "',   fld_cuenta_banco1='',   fld_nombre_banco2='" & fld_nombre_banco2.Text & "',   fld_cuenta_banco2='',   fld_otra_informacion='" & fld_otra_informacion.Text & "', fld_nombre_con_gar='" & fld_nombre_con_gar.Text & "', fld_apodo_con_gar='" & fld_apodo_con_gar.Text & "',fld_cedula_con_gar='" & fld_cedula_con_gar.Text & "',fld_telefono_con_gar='" & fld_telefono_con_gar.Text & "', fld_celular_con_gar='" & fld_celular_con_gar.Text & "', fld_edad='" & formatDate(dtpEdad.Value.Date) & "', fld_estado_civil='" & fld_estado_civil.Text & "', fld_edad_gar=" & fld_edad_gar.Text & ", fld_estado_civil_gar='" & fld_estado_civil_gar.Text & "', fld_ocupacion_cliente='" & fld_ocupacion_cliente.Text & "', fld_ocupacion_gar ='" & fld_ocupacion_gar.Text & "', fld_categoria='" & cmbEstado.Text & "', Puesto='" & txtPuesto.Text & "', ReferidoPor='" & txtReferidoPor.Text & "', Oriundo='" & txtOriundo.Text & "', ctaContable='" & txtCuentaContable.Text & "',email='" & emailTxt.Text & "', fechaIngreso='" & formatDate(dtpFechaIngresos.Value.Date) & "' WHERE fld_id=" & id_doc & ""

            .Connection = conn
            .Connection.Open()
            .ExecuteNonQuery()
            .Connection.Close()
        End With

        cmd.Dispose()


    End Sub

    Private Function ValidaFields() As Boolean
        If fld_FullName.Text = "" Then
            Alerta("Falta el NOMBRE del cliente")
            fld_FullName.Focus()
            Return False
            Exit Function
        ElseIf fld_Identity.Text = "" Then
            Alerta("Falta la Cédula del cliente")
            fld_Identity.Focus()
            Return False
            Exit Function
        ElseIf Trim(lblCuentaContable.Text) = String.Empty Then
            Alerta("Falta la cuenta contable del cliente")
            txtCuentaContable.Focus()
            Return False
            Exit Function
        ElseIf fld_City.Text = "" Then
            'Alerta("Falta la Ciudad del cliente")
            'fld_City.Focus()
            'Return False
            'Exit Function

        End If



        Return True
    End Function

    Private Sub NullData(ByVal Id As Integer)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_clientes WHERE fld_id=" & Id & "", conn)

        da.Fill(ds, "tbl_clientes")

        Dim nr As DataRow
        For Each nr In ds.Tables(0).Rows
            nr("fld_Status") = "B"
        Next
        conn.Open()
        Dim cmb As New MySqlCommandBuilder(da)
        da.UpdateCommand = cmb.GetUpdateCommand

        da.Update(ds, "tbl_clientes")
        ds.AcceptChanges()
        conn.Close()

        da.Dispose()
        ds.Dispose()
    End Sub

    Private Sub LlenarZona()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT fldId, fldDescripcion FROM tbl_maestro_zonas ORDER BY fldDescripcion", conn)
        da.Fill(dt)

        cmdZonas.DataSource = dt
        cmdZonas.DisplayMember = "fldDescripcion"
        cmdZonas.ValueMember = "fldId"
        da.Dispose()


    End Sub


    Private Sub CLIENTES_TODOS()

        Dim sqlstring = "SELECT * FROM tbl_clientes"
        Dim dr As DataRow, ds As New DataSet, da As New MySqlDataAdapter(sqlstring, conn), data(5) As String

        da.Fill(ds, "tbl_clientes")

        For Each dr In ds.Tables(0).Rows
            data = Split(dr("fld_FirstName"), " ")
            update_clientes(dr("fld_id"), data(1))
        Next

        ds.Dispose()
        da.Dispose()

    End Sub

    Private Sub update_clientes(ByVal id_cliente As String, ByVal apellido1 As String)
        Dim cmd As New MySqlCommand
        With cmd
            .Connection = conn
            .Connection.Open()
            .CommandText = "UPDATE tbl_clientes SET fld_LastName1='" & apellido1 & "' WHERE fld_id=" & id_cliente & ""
            .ExecuteNonQuery()
            .Connection.Close()
        End With
        cmd.Dispose()
    End Sub
    'POPUPS
    Private Sub LoadPopupPacientes()

        If FRMS_POPUP_CLIENTES("TODOS") = True Then
            LoadData(CInt(Id))

        End If

    End Sub

    Private Sub MARCA_STATUS()
        Dim ds As New DataSet
        Dim dr As DataRow
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_clientes", conn)
        da.Fill(ds, "tbl_clientes")
        For Each dr In ds.Tables(0).Rows
            dr("fld_Status") = "N"
            dr("fld_Phone") = "N/A"
            dr("fld_address") = "N/A"
            dr("fld_city") = "N/A"
            dr("fld_SeguroCompany") = "SEMMA"
            dr("fld_seguroplan") = "N/A"
            dr("fld_dependientes") = "N/A"
        Next

        Dim cmd As New MySqlCommandBuilder(da)
        da.UpdateCommand = cmd.GetUpdateCommand
        da.Update(ds, "tbl_clientes")
        ds.AcceptChanges()

    End Sub



    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        lblExcluido.Text = ""

        ClearFields()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        save_doc()

    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub txtId_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_Codigo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If


    End Sub

    Private Sub txtNombre_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_FullName.Enter
        If Trim(fld_Codigo.Text) = "" Then
        Else
            LoadData(CInt(fld_Codigo.Text))

        End If
    End Sub



    Private Sub fld_edad_gar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fld_edad_gar.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub fld_edad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LlenarCiudad()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As New FRM_CIUDADES
        f.ShowDialog()
        f.Dispose()
        LlenarCiudad()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lblExcluido.Text = ""
        LoadPopupPacientes()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim f As New FRM_MAESTRO_ZONAS
        f.ShowDialog()
        f.Dispose()
        LlenarZona()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        lblExcluido.Text = ""

        ClearFields()

    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedIndexChanged

    End Sub

    Private Sub cmbEstado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbEstado.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnLimite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimite.Click
        If FRMS_CLAVE_MAESTRA("Acceso") = True Then
            NON_QUERY("UPDATE tbl_clientes SET fld_limite=" & CDbl(txtLimite.Text) & " WHERE fld_id=" & fld_Codigo.Text & "")
        End If
    End Sub


    Private Sub txtLimite_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLimite.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCuentasBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuentasBanco.Click
        If btnGuardar.Text = "&Guardar" Then
            Alerta("Debe seleccionar un cliente")
            Return
        End If
        Dim f As New FRM_CUENTAS_DE_BANCOS
        f.txtIDCliente.Text = fld_Codigo.Text
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub btnEstadoIngresoEgresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstadoIngresoEgresos.Click
        If btnGuardar.Text = "&Guardar" Then
            Alerta("Debe seleccionar un cliente")
            Return
        End If
        Dim f As New FRM_ESTADO_FINANCIERO
        f.txtIDCliente.Text = fld_Codigo.Text
        f.ShowDialog()
        f.Dispose()
    End Sub


    Private Sub fotoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fotoBtn.Click
        Dim f As New frmFotoCliente
        f.documento = Trim(fld_Identity.Text)
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub txtCuentaContable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaContable.TextChanged

    End Sub


    Private Sub buscaCtaContableBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscaCtaContableBtn.Click
        If frmsListaCatalogoCuentaContable() = True Then
            txtCuentaContable.Text = Id
            lblCuentaContable.Text = ReturnDescripcion(Id)
        End If
    End Sub


    Private Sub fld_Codigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_Codigo.TextChanged

    End Sub

    Private Sub fld_Codigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_Codigo.KeyDown

    End Sub

    Private Sub FRM_CLIENTES_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub fld_estado_civil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fld_estado_civil.SelectedIndexChanged

    End Sub

    Private Sub fld_estado_civil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fld_estado_civil.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    
    Private Sub dtpEdad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpEdad.LostFocus
        fldedad.Text = edadExacta(dtpEdad.Value)

    End Sub

    
    Private Sub dtpFechaIngresos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaIngresos.LostFocus
        fldtiempoempresa.Text = edadExacta(dtpFechaIngresos.Value)
    End Sub
End Class
