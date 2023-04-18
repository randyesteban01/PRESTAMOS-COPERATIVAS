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
    Friend WithEvents fld_Address As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents fld_apodo_con As System.Windows.Forms.TextBox
    Friend WithEvents fld_nombre_con As System.Windows.Forms.TextBox
    Friend WithEvents fld_cedula_con As System.Windows.Forms.TextBox
    Friend WithEvents fld_apodo_con_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_nombre_con_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_cedula_con_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_apodo_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_nombre_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_direccion_gar As System.Windows.Forms.TextBox
    Friend WithEvents fld_cedula_gar As System.Windows.Forms.TextBox
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
    Friend WithEvents fld_ocupacion_gar1 As System.Windows.Forms.TextBox
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
    Friend WithEvents txtPuesto1 As System.Windows.Forms.TextBox
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
    Friend WithEvents Label51 As Label
    Friend WithEvents CobProvincia As ComboBox
    Friend WithEvents BtnProvincia As Button
    Friend WithEvents Label52 As Label
    Friend WithEvents CobProvincia_gar As ComboBox
    Friend WithEvents fld_Phone As MaskedTextBox
    Friend WithEvents CobSector As ComboBox
    Friend WithEvents BtnSector As Button
    Friend WithEvents fld_Phone2 As MaskedTextBox
    Friend WithEvents fld_Whatsapp As MaskedTextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents fld_Whatsaap_con As MaskedTextBox
    Friend WithEvents fld_celular_con As MaskedTextBox
    Friend WithEvents fld_telefono_con As MaskedTextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents CobSector_gar As ComboBox
    Friend WithEvents Label57 As Label
    Friend WithEvents CobParentezco As ComboBox
    Friend WithEvents Label58 As Label
    Friend WithEvents fld_whatsaap_gar As MaskedTextBox
    Friend WithEvents fld_celular_gar As MaskedTextBox
    Friend WithEvents fld_telefono_gar As MaskedTextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents fld_whatsaap_con_gar As MaskedTextBox
    Friend WithEvents fld_celular_con_gar As MaskedTextBox
    Friend WithEvents fld_telefono_con_gar As MaskedTextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label63 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents fld_telefono_empresa_gar As MaskedTextBox
    Friend WithEvents fld_empresa_gar As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents fld_agno_Labor_gar As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents fld_salario_gar As TextBox
    Friend WithEvents DtpEdad_gar As DateTimePicker
    Friend WithEvents Label64 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents fld_Email_gar As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents fld_ocupacion_cliente1 As TextBox
    Friend WithEvents TabReferencias As TabControl
    Friend WithEvents Tab_Personal As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents Fld_Whatsapp_Ref_Gar2 As MaskedTextBox
    Friend WithEvents Fld_Cel_Ref_Gar2 As MaskedTextBox
    Friend WithEvents Fld_Tel_Ref_gar2 As MaskedTextBox
    Friend WithEvents Fld_Ref_Personal_Gar2 As TextBox
    Friend WithEvents Label78 As Label
    Friend WithEvents Fld_Cedula_Ref_Gar2 As TextBox
    Friend WithEvents Label79 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents Fld_Whatsapp__Ref_Gar1 As MaskedTextBox
    Friend WithEvents Fld_Cel_Ref_Gar1 As MaskedTextBox
    Friend WithEvents Fld_Tel_Ref_Gar1 As MaskedTextBox
    Friend WithEvents fld_ref_personales_gar As TextBox
    Friend WithEvents Label73 As Label
    Friend WithEvents Fld_Cedula_Ref_Gar1 As TextBox
    Friend WithEvents Label74 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents TabComercial As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label83 As Label
    Friend WithEvents Fld_Whatsapp_Emp_Gar2 As MaskedTextBox
    Friend WithEvents Fld_Tel_Emp_Gar2 As MaskedTextBox
    Friend WithEvents Fld_Dir_Emp_Gar2 As TextBox
    Friend WithEvents Fld_Empra_Gar2 As TextBox
    Friend WithEvents Label84 As Label
    Friend WithEvents Fld_Rnc_Emp_Gar2 As TextBox
    Friend WithEvents Label85 As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Fld_Whatsapp_emp_Gar1 As MaskedTextBox
    Friend WithEvents Fld_Tel_Emp_Gar1 As MaskedTextBox
    Friend WithEvents Fdl_Dir_Emp_Gar1 As TextBox
    Friend WithEvents fld_ref_comerciales_gar As TextBox
    Friend WithEvents Label90 As Label
    Friend WithEvents Fld_Rnc_Emp_Gar1 As TextBox
    Friend WithEvents Label91 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents CobParentesco_gar2 As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents CobParentesco_Ref_Gar1 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Cob_Ref_Pesonal_clie2 As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Cob_Ref_Pesonal_clie1 As ComboBox
    Friend WithEvents Label67 As Label
    Friend WithEvents Fld_Whatsapp_Ref_Personal_Clie2 As MaskedTextBox
    Friend WithEvents Fld_Cel_Ref_Personal_Clie2 As MaskedTextBox
    Friend WithEvents Fld_Tel_Ref_Personal_Clie2 As MaskedTextBox
    Friend WithEvents Fld_Ref_Personal_clie2 As TextBox
    Friend WithEvents Label68 As Label
    Friend WithEvents Fld_Ced_Ref_Personal_Clie2 As TextBox
    Friend WithEvents Label69 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Fld_Whatsapp_Ref_Personal_Clie1 As MaskedTextBox
    Friend WithEvents Fld_Cel_Ref_Personal_Clie1 As MaskedTextBox
    Friend WithEvents Fld_Tel_Ref_Personal_Clie1 As MaskedTextBox
    Friend WithEvents Fld_Ref_Personal_clie1 As TextBox
    Friend WithEvents Label81 As Label
    Friend WithEvents Fld_Ced_Ref_Personal_Clie1 As TextBox
    Friend WithEvents Label95 As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label98 As Label
    Friend WithEvents Fld_Whatsapp_Com_Clie2 As MaskedTextBox
    Friend WithEvents Fld_Tel_Com_clie2 As MaskedTextBox
    Friend WithEvents Fld_Dir_Ref_Com_Clie2 As TextBox
    Friend WithEvents fld_ref_comerciales_cliente2 As TextBox
    Friend WithEvents Label99 As Label
    Friend WithEvents Fld_Rnc_Refe_Com_Clie2 As TextBox
    Friend WithEvents Label100 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents Fld_Whatsapp_Com_Clie1 As MaskedTextBox
    Friend WithEvents Fld_Tel_Com_clie1 As MaskedTextBox
    Friend WithEvents Fld_Dir_Ref_Com_Clie1 As TextBox
    Friend WithEvents fld_ref_comerciales_cliente As TextBox
    Friend WithEvents Label105 As Label
    Friend WithEvents Fld_Rnc_Refe_Com_Clie1 As TextBox
    Friend WithEvents Label106 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents Label109 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label86 As Label
    Friend WithEvents CobParentesco_Ref_Flia_Clie2 As ComboBox
    Friend WithEvents Label92 As Label
    Friend WithEvents CobParentesco_Ref_Flia_Clie1 As ComboBox
    Friend WithEvents Label110 As Label
    Friend WithEvents Fld_Whatsapp_Ref_Flia_Clie2 As MaskedTextBox
    Friend WithEvents Fld_Cel_Ref_Flia_Clie2 As MaskedTextBox
    Friend WithEvents Fld_Tel_Ref_Flia_Clie2 As MaskedTextBox
    Friend WithEvents fld_nom_Ref_Flia_Clie2 As TextBox
    Friend WithEvents Label111 As Label
    Friend WithEvents Fld_Ced_Ref_Flia_Clie2 As TextBox
    Friend WithEvents Label112 As Label
    Friend WithEvents Label113 As Label
    Friend WithEvents Label114 As Label
    Friend WithEvents Label115 As Label
    Friend WithEvents Fld_Whatsapp_Ref_Flia_Clie1 As MaskedTextBox
    Friend WithEvents Fld_Cel_Ref_Flia_Clie1 As MaskedTextBox
    Friend WithEvents Fld_Tel_Ref_Flia_Clie1 As MaskedTextBox
    Friend WithEvents fld_nom_Ref_Flia_Clie1 As TextBox
    Friend WithEvents Label116 As Label
    Friend WithEvents Fld_Ced_Ref_Flia_Clie1 As TextBox
    Friend WithEvents Label117 As Label
    Friend WithEvents Label118 As Label
    Friend WithEvents Label119 As Label
    Friend WithEvents txtPuesto As ComboBox
    Friend WithEvents fld_ocupacion_gar As ComboBox
    Friend WithEvents fld_ocupacion_cliente As ComboBox
    Friend WithEvents txtRetiroInteresCert As TextBox
    Friend WithEvents lblRetiroInteres As Label
    Friend WithEvents fldtiempoempresa As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CLIENTES))
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TP_FICHA_GRAL1 = New System.Windows.Forms.TabPage()
        Me.buscaCtaContableBtn = New System.Windows.Forms.Button()
        Me.fld_ocupacion_cliente = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cob_Ref_Pesonal_clie2 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Cob_Ref_Pesonal_clie1 = New System.Windows.Forms.ComboBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Fld_Whatsapp_Ref_Personal_Clie2 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Cel_Ref_Personal_Clie2 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Tel_Ref_Personal_Clie2 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Ref_Personal_clie2 = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Fld_Ced_Ref_Personal_Clie2 = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Fld_Whatsapp_Ref_Personal_Clie1 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Cel_Ref_Personal_Clie1 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Tel_Ref_Personal_Clie1 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Ref_Personal_clie1 = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Fld_Ced_Ref_Personal_Clie1 = New System.Windows.Forms.TextBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Fld_Whatsapp_Com_Clie2 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Tel_Com_clie2 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Dir_Ref_Com_Clie2 = New System.Windows.Forms.TextBox()
        Me.fld_ref_comerciales_cliente2 = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Fld_Rnc_Refe_Com_Clie2 = New System.Windows.Forms.TextBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Fld_Whatsapp_Com_Clie1 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Tel_Com_clie1 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Dir_Ref_Com_Clie1 = New System.Windows.Forms.TextBox()
        Me.fld_ref_comerciales_cliente = New System.Windows.Forms.TextBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Fld_Rnc_Refe_Com_Clie1 = New System.Windows.Forms.TextBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.txtCuentaContable = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.fld_Whatsapp = New System.Windows.Forms.MaskedTextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.fld_Phone2 = New System.Windows.Forms.MaskedTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.fld_Phone = New System.Windows.Forms.MaskedTextBox()
        Me.CobSector = New System.Windows.Forms.ComboBox()
        Me.BtnSector = New System.Windows.Forms.Button()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.CobProvincia = New System.Windows.Forms.ComboBox()
        Me.BtnProvincia = New System.Windows.Forms.Button()
        Me.fldedad = New System.Windows.Forms.TextBox()
        Me.dtpEdad = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.emailTxt = New System.Windows.Forms.TextBox()
        Me.btnLimite = New System.Windows.Forms.Button()
        Me.lblLimite = New System.Windows.Forms.Label()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.fld_Codigo = New System.Windows.Forms.TextBox()
        Me.lblTeléfono = New System.Windows.Forms.Label()
        Me.fld_Address = New System.Windows.Forms.TextBox()
        Me.lbDirección = New System.Windows.Forms.Label()
        Me.fld_apodo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdZonas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblExcluido = New System.Windows.Forms.Label()
        Me.fld_FullName = New System.Windows.Forms.TextBox()
        Me.fld_estado_civil = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.fld_Whatsaap_con = New System.Windows.Forms.MaskedTextBox()
        Me.fld_celular_con = New System.Windows.Forms.MaskedTextBox()
        Me.fld_telefono_con = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fld_apodo_con = New System.Windows.Forms.TextBox()
        Me.fld_nombre_con = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fld_cedula_con = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.fld_City = New System.Windows.Forms.ComboBox()
        Me.fld_Identity = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.fld_Email_gar = New System.Windows.Forms.TextBox()
        Me.DtpEdad_gar = New System.Windows.Forms.DateTimePicker()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.fld_ocupacion_gar = New System.Windows.Forms.ComboBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.fld_telefono_empresa_gar = New System.Windows.Forms.MaskedTextBox()
        Me.fld_empresa_gar = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.fld_agno_Labor_gar = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.fld_salario_gar = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.fld_whatsaap_gar = New System.Windows.Forms.MaskedTextBox()
        Me.fld_ocupacion_gar1 = New System.Windows.Forms.TextBox()
        Me.fld_celular_gar = New System.Windows.Forms.MaskedTextBox()
        Me.fld_telefono_gar = New System.Windows.Forms.MaskedTextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.CobParentezco = New System.Windows.Forms.ComboBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.CobSector_gar = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.CobProvincia_gar = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.fld_estado_civil_gar = New System.Windows.Forms.ComboBox()
        Me.fld_edad_gar = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.fld_whatsaap_con_gar = New System.Windows.Forms.MaskedTextBox()
        Me.fld_celular_con_gar = New System.Windows.Forms.MaskedTextBox()
        Me.fld_telefono_con_gar = New System.Windows.Forms.MaskedTextBox()
        Me.fld_apodo_con_gar = New System.Windows.Forms.TextBox()
        Me.fld_nombre_con_gar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fld_cedula_con_gar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fld_apodo_gar = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.fld_nombre_gar = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.fld_direccion_gar = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.fld_cedula_gar = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TabReferencias = New System.Windows.Forms.TabControl()
        Me.Tab_Personal = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.CobParentesco_gar2 = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.CobParentesco_Ref_Gar1 = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Fld_Whatsapp_Ref_Gar2 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Cel_Ref_Gar2 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Tel_Ref_gar2 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Ref_Personal_Gar2 = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Fld_Cedula_Ref_Gar2 = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Fld_Whatsapp__Ref_Gar1 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Cel_Ref_Gar1 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Tel_Ref_Gar1 = New System.Windows.Forms.MaskedTextBox()
        Me.fld_ref_personales_gar = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Fld_Cedula_Ref_Gar1 = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.TabComercial = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Fld_Whatsapp_Emp_Gar2 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Tel_Emp_Gar2 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Dir_Emp_Gar2 = New System.Windows.Forms.TextBox()
        Me.Fld_Empra_Gar2 = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Fld_Rnc_Emp_Gar2 = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Fld_Whatsapp_emp_Gar1 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Tel_Emp_Gar1 = New System.Windows.Forms.MaskedTextBox()
        Me.Fdl_Dir_Emp_Gar1 = New System.Windows.Forms.TextBox()
        Me.fld_ref_comerciales_gar = New System.Windows.Forms.TextBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Fld_Rnc_Emp_Gar1 = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.fld_ciudad_gar = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtPuesto = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.CobParentesco_Ref_Flia_Clie2 = New System.Windows.Forms.ComboBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.CobParentesco_Ref_Flia_Clie1 = New System.Windows.Forms.ComboBox()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Fld_Whatsapp_Ref_Flia_Clie2 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Cel_Ref_Flia_Clie2 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Tel_Ref_Flia_Clie2 = New System.Windows.Forms.MaskedTextBox()
        Me.fld_nom_Ref_Flia_Clie2 = New System.Windows.Forms.TextBox()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Fld_Ced_Ref_Flia_Clie2 = New System.Windows.Forms.TextBox()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.Fld_Whatsapp_Ref_Flia_Clie1 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Cel_Ref_Flia_Clie1 = New System.Windows.Forms.MaskedTextBox()
        Me.Fld_Tel_Ref_Flia_Clie1 = New System.Windows.Forms.MaskedTextBox()
        Me.fld_nom_Ref_Flia_Clie1 = New System.Windows.Forms.TextBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Fld_Ced_Ref_Flia_Clie1 = New System.Windows.Forms.TextBox()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.fldtiempoempresa = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.balancePrestamosTxt = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.disponibilidadTxt = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.fld_nombre_banco2 = New System.Windows.Forms.TextBox()
        Me.balanceGralTxt = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.aportacionMontoTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ahorroBalanceTxt = New System.Windows.Forms.TextBox()
        Me.ahorroSalidaTxt = New System.Windows.Forms.TextBox()
        Me.ahorroEntradaTxt = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.dtpFechaIngresos = New System.Windows.Forms.DateTimePicker()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnOtrasObligaciones = New System.Windows.Forms.Button()
        Me.btnEstadoIngresoEgresos = New System.Windows.Forms.Button()
        Me.btnCuentasBanco = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtReferidoPor = New System.Windows.Forms.TextBox()
        Me.txtOriundo = New System.Windows.Forms.TextBox()
        Me.txtPuesto1 = New System.Windows.Forms.TextBox()
        Me.fld_ingresos_mesuales = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.fld_otra_informacion = New System.Windows.Forms.TextBox()
        Me.fld_nombre_banco1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.certificadoBalanceTxt = New System.Windows.Forms.TextBox()
        Me.certificadoSalidaTxt = New System.Windows.Forms.TextBox()
        Me.certificadoEntradaTxt = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.fld_ocupacion_cliente1 = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.fotoBtn = New System.Windows.Forms.Button()
        Me.lblCuentaContable = New System.Windows.Forms.Label()
        Me.txtRetiroInteresCert = New System.Windows.Forms.TextBox()
        Me.lblRetiroInteres = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.TP_FICHA_GRAL1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabReferencias.SuspendLayout()
        Me.Tab_Personal.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabComercial.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnCerrar.Location = New System.Drawing.Point(769, 486)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(57, 49)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCerrar.UseVisualStyleBackColor = False
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
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(90, 487)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(57, 49)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "&Guardar"
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
        Me.btnNuevo.Location = New System.Drawing.Point(11, 487)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(57, 49)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.TabStop = False
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.TabControl.Size = New System.Drawing.Size(911, 480)
        Me.TabControl.TabIndex = 0
        '
        'TP_FICHA_GRAL1
        '
        Me.TP_FICHA_GRAL1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TP_FICHA_GRAL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TP_FICHA_GRAL1.Controls.Add(Me.buscaCtaContableBtn)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_ocupacion_cliente)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.GroupBox3)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.txtCuentaContable)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label12)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label65)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label55)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_Whatsapp)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label53)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_Phone2)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Button2)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_Phone)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.CobSector)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.BtnSector)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label51)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.CobProvincia)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.BtnProvincia)
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
        Me.TP_FICHA_GRAL1.Controls.Add(Me.lblApellidos)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_Codigo)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.lblTeléfono)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_Address)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.lbDirección)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_apodo)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label2)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.cmdZonas)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.Label4)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.lblExcluido)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_FullName)
        Me.TP_FICHA_GRAL1.Controls.Add(Me.fld_estado_civil)
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
        Me.TP_FICHA_GRAL1.Size = New System.Drawing.Size(903, 451)
        Me.TP_FICHA_GRAL1.TabIndex = 0
        Me.TP_FICHA_GRAL1.Text = "Datos del Socio"
        '
        'buscaCtaContableBtn
        '
        Me.buscaCtaContableBtn.Image = CType(resources.GetObject("buscaCtaContableBtn.Image"), System.Drawing.Image)
        Me.buscaCtaContableBtn.Location = New System.Drawing.Point(278, 350)
        Me.buscaCtaContableBtn.Name = "buscaCtaContableBtn"
        Me.buscaCtaContableBtn.Size = New System.Drawing.Size(45, 23)
        Me.buscaCtaContableBtn.TabIndex = 11
        '
        'fld_ocupacion_cliente
        '
        Me.fld_ocupacion_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fld_ocupacion_cliente.ForeColor = System.Drawing.Color.White
        Me.fld_ocupacion_cliente.Items.AddRange(New Object() {"ABOGADO (A)", "AMA DE CASA", "ADMINISTRADOR (A)", "AGENTE DE VIAJES", "ALMACENISTA", "ARQUITECTO (A)", "AYUDANTE DE COCINA", "AYUDANTE DE CONSTRUCCION", "AUXILIAR DE OPERACIONES", "AUXILIAR DE CONTABILIDAD", "AUXILAR DE BANCA DE LOTERIA", "AVICULTOR (A)", "ALBANIL", "BARRENDERO (A)", "BARBERO", "BOMBERO", "BARTHENDER", "CAMARERO (A)", "CARNICERO (A)", "CARDIOLOGO (A)", "CONDUCTOR DE AUTOBUS", "CONDUCTOR DE CAMION", "CONSERJE", "CONTABLE", "COMERCIANTE", "DOCTOR (A)", "DIRECTOR (A)", "DECORADOR (A)", "DENTISTA", "DISEÑADOR (A)", "DIGITADOR (A)", "DELIVERY", "EMPRESARIO", "EDUCADOR (A)", "ELECTRICISTA", "EPIDEMIOLOGO (A)", "ENFERMERO (A)", "FARMACEUTICO (A)", "FLORISTA", "FOTOGRAFO (A)", "INFORMATICO (A)", "JARDINERO (A)", "JUEZ (A)", "LIMPIADOR (A)", "MAESTRO CONSTRUCTOR", "MECANICO (A)", "OFICINISTA", "ORTOPEDA", "PELUQUERO (A)", "PERIODISTA", "PORTERO (A)", "PEDIATRA", "PANADERO (A)", "POLICIA", "PORTERO (A)", "PROGRAMADOR (A)", "PRESTAMISTA", "PUBLICISTA", "PLOMERO", "RADIOLOGO (A)", "RECEPCIONISTA", "SASTRE", "SOLDADOR", "SOCORRISTA", "SOLDADO", "SEXOLOGO", "TAXISTA", "TELEFONISTA", "TRAUMATOLOGO", "UROGOLO", "VENDEDOR (A)", "VETERINARIO (A)", "ZAPATERO", "MOTOCONCHO", "MENSAJERO (A)", "MANICURISTA", "GERENTE", "FINANCIERO (A)", "OPERARIO (A)", "OTROS"})
        Me.fld_ocupacion_cliente.Location = New System.Drawing.Point(114, 139)
        Me.fld_ocupacion_cliente.Name = "fld_ocupacion_cliente"
        Me.fld_ocupacion_cliente.Size = New System.Drawing.Size(282, 21)
        Me.fld_ocupacion_cliente.TabIndex = 79
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Location = New System.Drawing.Point(502, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox3.Size = New System.Drawing.Size(328, 285)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Referencias"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(6, 14)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(322, 265)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(314, 239)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Referencias Personales"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Cob_Ref_Pesonal_clie2)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Cob_Ref_Pesonal_clie1)
        Me.Panel1.Controls.Add(Me.Label67)
        Me.Panel1.Controls.Add(Me.Fld_Whatsapp_Ref_Personal_Clie2)
        Me.Panel1.Controls.Add(Me.Fld_Cel_Ref_Personal_Clie2)
        Me.Panel1.Controls.Add(Me.Fld_Tel_Ref_Personal_Clie2)
        Me.Panel1.Controls.Add(Me.Fld_Ref_Personal_clie2)
        Me.Panel1.Controls.Add(Me.Label68)
        Me.Panel1.Controls.Add(Me.Fld_Ced_Ref_Personal_Clie2)
        Me.Panel1.Controls.Add(Me.Label69)
        Me.Panel1.Controls.Add(Me.Label70)
        Me.Panel1.Controls.Add(Me.Label71)
        Me.Panel1.Controls.Add(Me.Label76)
        Me.Panel1.Controls.Add(Me.Fld_Whatsapp_Ref_Personal_Clie1)
        Me.Panel1.Controls.Add(Me.Fld_Cel_Ref_Personal_Clie1)
        Me.Panel1.Controls.Add(Me.Fld_Tel_Ref_Personal_Clie1)
        Me.Panel1.Controls.Add(Me.Fld_Ref_Personal_clie1)
        Me.Panel1.Controls.Add(Me.Label81)
        Me.Panel1.Controls.Add(Me.Fld_Ced_Ref_Personal_Clie1)
        Me.Panel1.Controls.Add(Me.Label95)
        Me.Panel1.Controls.Add(Me.Label96)
        Me.Panel1.Controls.Add(Me.Label97)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 248)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Parentesco"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cob_Ref_Pesonal_clie2
        '
        Me.Cob_Ref_Pesonal_clie2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Cob_Ref_Pesonal_clie2.ForeColor = System.Drawing.Color.White
        Me.Cob_Ref_Pesonal_clie2.Items.AddRange(New Object() {"HERMANO (A)", "PRIMO (A)", "SOBRINO (A)", "TIO (A)", "CUÑADO(A)", "SUEGRO(A)", "PADRASTRO", "MADRASTRA", "AMIGO(A)"})
        Me.Cob_Ref_Pesonal_clie2.Location = New System.Drawing.Point(8, 173)
        Me.Cob_Ref_Pesonal_clie2.Name = "Cob_Ref_Pesonal_clie2"
        Me.Cob_Ref_Pesonal_clie2.Size = New System.Drawing.Size(153, 21)
        Me.Cob_Ref_Pesonal_clie2.TabIndex = 77
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.Location = New System.Drawing.Point(7, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Parentesco"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cob_Ref_Pesonal_clie1
        '
        Me.Cob_Ref_Pesonal_clie1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Cob_Ref_Pesonal_clie1.ForeColor = System.Drawing.Color.White
        Me.Cob_Ref_Pesonal_clie1.Items.AddRange(New Object() {"HERMANO (A)", "PRIMO (A)", "SOBRINO (A)", "TIO (A)", "CUÑADO(A)", "SUEGRO(A)", "PADRASTRO", "MADRASTRA", "AMIGO(A)"})
        Me.Cob_Ref_Pesonal_clie1.Location = New System.Drawing.Point(3, 59)
        Me.Cob_Ref_Pesonal_clie1.Name = "Cob_Ref_Pesonal_clie1"
        Me.Cob_Ref_Pesonal_clie1.Size = New System.Drawing.Size(153, 21)
        Me.Cob_Ref_Pesonal_clie1.TabIndex = 29
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label67.Location = New System.Drawing.Point(199, 198)
        Me.Label67.Name = "Label67"
        Me.Label67.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label67.Size = New System.Drawing.Size(88, 16)
        Me.Label67.TabIndex = 75
        Me.Label67.Text = "Whatsaap"
        '
        'Fld_Whatsapp_Ref_Personal_Clie2
        '
        Me.Fld_Whatsapp_Ref_Personal_Clie2.Location = New System.Drawing.Point(195, 214)
        Me.Fld_Whatsapp_Ref_Personal_Clie2.Mask = "000-000-0000"
        Me.Fld_Whatsapp_Ref_Personal_Clie2.Name = "Fld_Whatsapp_Ref_Personal_Clie2"
        Me.Fld_Whatsapp_Ref_Personal_Clie2.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Whatsapp_Ref_Personal_Clie2.TabIndex = 74
        '
        'Fld_Cel_Ref_Personal_Clie2
        '
        Me.Fld_Cel_Ref_Personal_Clie2.Location = New System.Drawing.Point(99, 213)
        Me.Fld_Cel_Ref_Personal_Clie2.Mask = "000-000-0000"
        Me.Fld_Cel_Ref_Personal_Clie2.Name = "Fld_Cel_Ref_Personal_Clie2"
        Me.Fld_Cel_Ref_Personal_Clie2.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Cel_Ref_Personal_Clie2.TabIndex = 73
        '
        'Fld_Tel_Ref_Personal_Clie2
        '
        Me.Fld_Tel_Ref_Personal_Clie2.Location = New System.Drawing.Point(3, 213)
        Me.Fld_Tel_Ref_Personal_Clie2.Mask = "000-000-0000"
        Me.Fld_Tel_Ref_Personal_Clie2.Name = "Fld_Tel_Ref_Personal_Clie2"
        Me.Fld_Tel_Ref_Personal_Clie2.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Tel_Ref_Personal_Clie2.TabIndex = 72
        '
        'Fld_Ref_Personal_clie2
        '
        Me.Fld_Ref_Personal_clie2.BackColor = System.Drawing.Color.White
        Me.Fld_Ref_Personal_clie2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Ref_Personal_clie2.Location = New System.Drawing.Point(5, 134)
        Me.Fld_Ref_Personal_clie2.MaxLength = 55
        Me.Fld_Ref_Personal_clie2.Name = "Fld_Ref_Personal_clie2"
        Me.Fld_Ref_Personal_clie2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Ref_Personal_clie2.Size = New System.Drawing.Size(304, 20)
        Me.Fld_Ref_Personal_clie2.TabIndex = 65
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label68.Location = New System.Drawing.Point(5, 198)
        Me.Label68.Name = "Label68"
        Me.Label68.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label68.Size = New System.Drawing.Size(88, 16)
        Me.Label68.TabIndex = 70
        Me.Label68.Text = "Teléfono"
        '
        'Fld_Ced_Ref_Personal_Clie2
        '
        Me.Fld_Ced_Ref_Personal_Clie2.BackColor = System.Drawing.Color.White
        Me.Fld_Ced_Ref_Personal_Clie2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Ced_Ref_Personal_Clie2.Location = New System.Drawing.Point(164, 174)
        Me.Fld_Ced_Ref_Personal_Clie2.MaxLength = 15
        Me.Fld_Ced_Ref_Personal_Clie2.Name = "Fld_Ced_Ref_Personal_Clie2"
        Me.Fld_Ced_Ref_Personal_Clie2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Ced_Ref_Personal_Clie2.Size = New System.Drawing.Size(144, 20)
        Me.Fld_Ced_Ref_Personal_Clie2.TabIndex = 69
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label69.Location = New System.Drawing.Point(121, 119)
        Me.Label69.Name = "Label69"
        Me.Label69.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label69.Size = New System.Drawing.Size(88, 16)
        Me.Label69.TabIndex = 64
        Me.Label69.Text = "Nombre"
        '
        'Label70
        '
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label70.Location = New System.Drawing.Point(101, 198)
        Me.Label70.Name = "Label70"
        Me.Label70.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label70.Size = New System.Drawing.Size(88, 16)
        Me.Label70.TabIndex = 71
        Me.Label70.Text = "Celular"
        '
        'Label71
        '
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label71.Location = New System.Drawing.Point(169, 156)
        Me.Label71.Name = "Label71"
        Me.Label71.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label71.Size = New System.Drawing.Size(88, 16)
        Me.Label71.TabIndex = 68
        Me.Label71.Text = "Cédula"
        '
        'Label76
        '
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label76.Location = New System.Drawing.Point(199, 82)
        Me.Label76.Name = "Label76"
        Me.Label76.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label76.Size = New System.Drawing.Size(88, 16)
        Me.Label76.TabIndex = 63
        Me.Label76.Text = "Whatsaap"
        '
        'Fld_Whatsapp_Ref_Personal_Clie1
        '
        Me.Fld_Whatsapp_Ref_Personal_Clie1.Location = New System.Drawing.Point(195, 98)
        Me.Fld_Whatsapp_Ref_Personal_Clie1.Mask = "000-000-0000"
        Me.Fld_Whatsapp_Ref_Personal_Clie1.Name = "Fld_Whatsapp_Ref_Personal_Clie1"
        Me.Fld_Whatsapp_Ref_Personal_Clie1.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Whatsapp_Ref_Personal_Clie1.TabIndex = 62
        '
        'Fld_Cel_Ref_Personal_Clie1
        '
        Me.Fld_Cel_Ref_Personal_Clie1.Location = New System.Drawing.Point(99, 97)
        Me.Fld_Cel_Ref_Personal_Clie1.Mask = "000-000-0000"
        Me.Fld_Cel_Ref_Personal_Clie1.Name = "Fld_Cel_Ref_Personal_Clie1"
        Me.Fld_Cel_Ref_Personal_Clie1.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Cel_Ref_Personal_Clie1.TabIndex = 61
        '
        'Fld_Tel_Ref_Personal_Clie1
        '
        Me.Fld_Tel_Ref_Personal_Clie1.Location = New System.Drawing.Point(3, 97)
        Me.Fld_Tel_Ref_Personal_Clie1.Mask = "000-000-0000"
        Me.Fld_Tel_Ref_Personal_Clie1.Name = "Fld_Tel_Ref_Personal_Clie1"
        Me.Fld_Tel_Ref_Personal_Clie1.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Tel_Ref_Personal_Clie1.TabIndex = 60
        '
        'Fld_Ref_Personal_clie1
        '
        Me.Fld_Ref_Personal_clie1.BackColor = System.Drawing.Color.White
        Me.Fld_Ref_Personal_clie1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Ref_Personal_clie1.Location = New System.Drawing.Point(5, 20)
        Me.Fld_Ref_Personal_clie1.MaxLength = 55
        Me.Fld_Ref_Personal_clie1.Name = "Fld_Ref_Personal_clie1"
        Me.Fld_Ref_Personal_clie1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Ref_Personal_clie1.Size = New System.Drawing.Size(304, 20)
        Me.Fld_Ref_Personal_clie1.TabIndex = 53
        '
        'Label81
        '
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label81.Location = New System.Drawing.Point(5, 82)
        Me.Label81.Name = "Label81"
        Me.Label81.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label81.Size = New System.Drawing.Size(88, 16)
        Me.Label81.TabIndex = 58
        Me.Label81.Text = "Teléfono"
        '
        'Fld_Ced_Ref_Personal_Clie1
        '
        Me.Fld_Ced_Ref_Personal_Clie1.BackColor = System.Drawing.Color.White
        Me.Fld_Ced_Ref_Personal_Clie1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Ced_Ref_Personal_Clie1.Location = New System.Drawing.Point(164, 59)
        Me.Fld_Ced_Ref_Personal_Clie1.MaxLength = 15
        Me.Fld_Ced_Ref_Personal_Clie1.Name = "Fld_Ced_Ref_Personal_Clie1"
        Me.Fld_Ced_Ref_Personal_Clie1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Ced_Ref_Personal_Clie1.Size = New System.Drawing.Size(144, 20)
        Me.Fld_Ced_Ref_Personal_Clie1.TabIndex = 57
        '
        'Label95
        '
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label95.Location = New System.Drawing.Point(121, 5)
        Me.Label95.Name = "Label95"
        Me.Label95.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label95.Size = New System.Drawing.Size(88, 16)
        Me.Label95.TabIndex = 52
        Me.Label95.Text = "Nombre"
        '
        'Label96
        '
        Me.Label96.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label96.Location = New System.Drawing.Point(101, 82)
        Me.Label96.Name = "Label96"
        Me.Label96.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label96.Size = New System.Drawing.Size(88, 16)
        Me.Label96.TabIndex = 59
        Me.Label96.Text = "Celular"
        '
        'Label97
        '
        Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label97.Location = New System.Drawing.Point(169, 42)
        Me.Label97.Name = "Label97"
        Me.Label97.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label97.Size = New System.Drawing.Size(88, 16)
        Me.Label97.TabIndex = 56
        Me.Label97.Text = "Cédula"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.Panel4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(314, 239)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Referencias Comerciales"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label98)
        Me.Panel4.Controls.Add(Me.Fld_Whatsapp_Com_Clie2)
        Me.Panel4.Controls.Add(Me.Fld_Tel_Com_clie2)
        Me.Panel4.Controls.Add(Me.Fld_Dir_Ref_Com_Clie2)
        Me.Panel4.Controls.Add(Me.fld_ref_comerciales_cliente2)
        Me.Panel4.Controls.Add(Me.Label99)
        Me.Panel4.Controls.Add(Me.Fld_Rnc_Refe_Com_Clie2)
        Me.Panel4.Controls.Add(Me.Label100)
        Me.Panel4.Controls.Add(Me.Label102)
        Me.Panel4.Controls.Add(Me.Label103)
        Me.Panel4.Controls.Add(Me.Label104)
        Me.Panel4.Controls.Add(Me.Fld_Whatsapp_Com_Clie1)
        Me.Panel4.Controls.Add(Me.Fld_Tel_Com_clie1)
        Me.Panel4.Controls.Add(Me.Fld_Dir_Ref_Com_Clie1)
        Me.Panel4.Controls.Add(Me.fld_ref_comerciales_cliente)
        Me.Panel4.Controls.Add(Me.Label105)
        Me.Panel4.Controls.Add(Me.Fld_Rnc_Refe_Com_Clie1)
        Me.Panel4.Controls.Add(Me.Label106)
        Me.Panel4.Controls.Add(Me.Label108)
        Me.Panel4.Controls.Add(Me.Label109)
        Me.Panel4.Location = New System.Drawing.Point(2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(312, 248)
        Me.Panel4.TabIndex = 6
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label98.Location = New System.Drawing.Point(235, 192)
        Me.Label98.Name = "Label98"
        Me.Label98.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label98.Size = New System.Drawing.Size(56, 13)
        Me.Label98.TabIndex = 75
        Me.Label98.Text = "Whatsaap"
        '
        'Fld_Whatsapp_Com_Clie2
        '
        Me.Fld_Whatsapp_Com_Clie2.Location = New System.Drawing.Point(231, 208)
        Me.Fld_Whatsapp_Com_Clie2.Mask = "000-000-0000"
        Me.Fld_Whatsapp_Com_Clie2.Name = "Fld_Whatsapp_Com_Clie2"
        Me.Fld_Whatsapp_Com_Clie2.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Whatsapp_Com_Clie2.TabIndex = 74
        '
        'Fld_Tel_Com_clie2
        '
        Me.Fld_Tel_Com_clie2.Location = New System.Drawing.Point(155, 207)
        Me.Fld_Tel_Com_clie2.Mask = "000-000-0000"
        Me.Fld_Tel_Com_clie2.Name = "Fld_Tel_Com_clie2"
        Me.Fld_Tel_Com_clie2.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Tel_Com_clie2.TabIndex = 72
        '
        'Fld_Dir_Ref_Com_Clie2
        '
        Me.Fld_Dir_Ref_Com_Clie2.BackColor = System.Drawing.Color.White
        Me.Fld_Dir_Ref_Com_Clie2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Dir_Ref_Com_Clie2.Location = New System.Drawing.Point(5, 170)
        Me.Fld_Dir_Ref_Com_Clie2.MaxLength = 55
        Me.Fld_Dir_Ref_Com_Clie2.Name = "Fld_Dir_Ref_Com_Clie2"
        Me.Fld_Dir_Ref_Com_Clie2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Dir_Ref_Com_Clie2.Size = New System.Drawing.Size(304, 20)
        Me.Fld_Dir_Ref_Com_Clie2.TabIndex = 67
        '
        'fld_ref_comerciales_cliente2
        '
        Me.fld_ref_comerciales_cliente2.BackColor = System.Drawing.Color.White
        Me.fld_ref_comerciales_cliente2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ref_comerciales_cliente2.Location = New System.Drawing.Point(5, 134)
        Me.fld_ref_comerciales_cliente2.MaxLength = 55
        Me.fld_ref_comerciales_cliente2.Name = "fld_ref_comerciales_cliente2"
        Me.fld_ref_comerciales_cliente2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_ref_comerciales_cliente2.Size = New System.Drawing.Size(304, 20)
        Me.fld_ref_comerciales_cliente2.TabIndex = 65
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label99.Location = New System.Drawing.Point(157, 192)
        Me.Label99.Name = "Label99"
        Me.Label99.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label99.Size = New System.Drawing.Size(49, 13)
        Me.Label99.TabIndex = 70
        Me.Label99.Text = "Teléfono"
        '
        'Fld_Rnc_Refe_Com_Clie2
        '
        Me.Fld_Rnc_Refe_Com_Clie2.BackColor = System.Drawing.Color.White
        Me.Fld_Rnc_Refe_Com_Clie2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Rnc_Refe_Com_Clie2.Location = New System.Drawing.Point(4, 207)
        Me.Fld_Rnc_Refe_Com_Clie2.MaxLength = 15
        Me.Fld_Rnc_Refe_Com_Clie2.Name = "Fld_Rnc_Refe_Com_Clie2"
        Me.Fld_Rnc_Refe_Com_Clie2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Rnc_Refe_Com_Clie2.Size = New System.Drawing.Size(144, 20)
        Me.Fld_Rnc_Refe_Com_Clie2.TabIndex = 69
        '
        'Label100
        '
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label100.Location = New System.Drawing.Point(121, 119)
        Me.Label100.Name = "Label100"
        Me.Label100.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label100.Size = New System.Drawing.Size(88, 16)
        Me.Label100.TabIndex = 64
        Me.Label100.Text = "Empresa"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label102.Location = New System.Drawing.Point(5, 156)
        Me.Label102.Name = "Label102"
        Me.Label102.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label102.Size = New System.Drawing.Size(52, 13)
        Me.Label102.TabIndex = 66
        Me.Label102.Text = "Dirección"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label103.Location = New System.Drawing.Point(9, 193)
        Me.Label103.Name = "Label103"
        Me.Label103.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label103.Size = New System.Drawing.Size(30, 13)
        Me.Label103.TabIndex = 68
        Me.Label103.Text = "RNC"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label104.Location = New System.Drawing.Point(231, 78)
        Me.Label104.Name = "Label104"
        Me.Label104.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label104.Size = New System.Drawing.Size(56, 13)
        Me.Label104.TabIndex = 63
        Me.Label104.Text = "Whatsaap"
        '
        'Fld_Whatsapp_Com_Clie1
        '
        Me.Fld_Whatsapp_Com_Clie1.Location = New System.Drawing.Point(227, 94)
        Me.Fld_Whatsapp_Com_Clie1.Mask = "000-000-0000"
        Me.Fld_Whatsapp_Com_Clie1.Name = "Fld_Whatsapp_Com_Clie1"
        Me.Fld_Whatsapp_Com_Clie1.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Whatsapp_Com_Clie1.TabIndex = 62
        '
        'Fld_Tel_Com_clie1
        '
        Me.Fld_Tel_Com_clie1.Location = New System.Drawing.Point(151, 94)
        Me.Fld_Tel_Com_clie1.Mask = "000-000-0000"
        Me.Fld_Tel_Com_clie1.Name = "Fld_Tel_Com_clie1"
        Me.Fld_Tel_Com_clie1.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Tel_Com_clie1.TabIndex = 60
        '
        'Fld_Dir_Ref_Com_Clie1
        '
        Me.Fld_Dir_Ref_Com_Clie1.BackColor = System.Drawing.Color.White
        Me.Fld_Dir_Ref_Com_Clie1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Dir_Ref_Com_Clie1.Location = New System.Drawing.Point(5, 56)
        Me.Fld_Dir_Ref_Com_Clie1.MaxLength = 55
        Me.Fld_Dir_Ref_Com_Clie1.Name = "Fld_Dir_Ref_Com_Clie1"
        Me.Fld_Dir_Ref_Com_Clie1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Dir_Ref_Com_Clie1.Size = New System.Drawing.Size(305, 20)
        Me.Fld_Dir_Ref_Com_Clie1.TabIndex = 55
        '
        'fld_ref_comerciales_cliente
        '
        Me.fld_ref_comerciales_cliente.BackColor = System.Drawing.Color.White
        Me.fld_ref_comerciales_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ref_comerciales_cliente.Location = New System.Drawing.Point(5, 20)
        Me.fld_ref_comerciales_cliente.MaxLength = 55
        Me.fld_ref_comerciales_cliente.Name = "fld_ref_comerciales_cliente"
        Me.fld_ref_comerciales_cliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_ref_comerciales_cliente.Size = New System.Drawing.Size(304, 20)
        Me.fld_ref_comerciales_cliente.TabIndex = 53
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label105.Location = New System.Drawing.Point(153, 78)
        Me.Label105.Name = "Label105"
        Me.Label105.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label105.Size = New System.Drawing.Size(49, 13)
        Me.Label105.TabIndex = 58
        Me.Label105.Text = "Teléfono"
        '
        'Fld_Rnc_Refe_Com_Clie1
        '
        Me.Fld_Rnc_Refe_Com_Clie1.BackColor = System.Drawing.Color.White
        Me.Fld_Rnc_Refe_Com_Clie1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Rnc_Refe_Com_Clie1.Location = New System.Drawing.Point(0, 94)
        Me.Fld_Rnc_Refe_Com_Clie1.MaxLength = 15
        Me.Fld_Rnc_Refe_Com_Clie1.Name = "Fld_Rnc_Refe_Com_Clie1"
        Me.Fld_Rnc_Refe_Com_Clie1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Rnc_Refe_Com_Clie1.Size = New System.Drawing.Size(144, 20)
        Me.Fld_Rnc_Refe_Com_Clie1.TabIndex = 57
        '
        'Label106
        '
        Me.Label106.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label106.Location = New System.Drawing.Point(121, 5)
        Me.Label106.Name = "Label106"
        Me.Label106.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label106.Size = New System.Drawing.Size(88, 16)
        Me.Label106.TabIndex = 52
        Me.Label106.Text = "Empresa"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label108.Location = New System.Drawing.Point(5, 42)
        Me.Label108.Name = "Label108"
        Me.Label108.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label108.Size = New System.Drawing.Size(52, 13)
        Me.Label108.TabIndex = 54
        Me.Label108.Text = "Dirección"
        '
        'Label109
        '
        Me.Label109.AutoEllipsis = True
        Me.Label109.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label109.Location = New System.Drawing.Point(5, 80)
        Me.Label109.Name = "Label109"
        Me.Label109.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label109.Size = New System.Drawing.Size(40, 16)
        Me.Label109.TabIndex = 56
        Me.Label109.Text = "RNC"
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.BackColor = System.Drawing.Color.White
        Me.txtCuentaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaContable.ForeColor = System.Drawing.Color.Green
        Me.txtCuentaContable.Location = New System.Drawing.Point(112, 351)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.ReadOnly = True
        Me.txtCuentaContable.Size = New System.Drawing.Size(160, 22)
        Me.txtCuentaContable.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 351)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Cuenta Contable"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label65.Location = New System.Drawing.Point(8, 141)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(88, 16)
        Me.Label65.TabIndex = 48
        Me.Label65.Text = "Ocupación"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label55.Location = New System.Drawing.Point(8, 242)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(88, 16)
        Me.Label55.TabIndex = 47
        Me.Label55.Text = "Sector"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_Whatsapp
        '
        Me.fld_Whatsapp.Location = New System.Drawing.Point(385, 167)
        Me.fld_Whatsapp.Mask = "000-000-0000"
        Me.fld_Whatsapp.Name = "fld_Whatsapp"
        Me.fld_Whatsapp.Size = New System.Drawing.Size(74, 20)
        Me.fld_Whatsapp.TabIndex = 46
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label53.Location = New System.Drawing.Point(328, 171)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(56, 13)
        Me.Label53.TabIndex = 45
        Me.Label53.Text = "Whatsapp"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_Phone2
        '
        Me.fld_Phone2.Location = New System.Drawing.Point(250, 167)
        Me.fld_Phone2.Mask = "000-000-0000"
        Me.fld_Phone2.Name = "fld_Phone2"
        Me.fld_Phone2.Size = New System.Drawing.Size(74, 20)
        Me.fld_Phone2.TabIndex = 44
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(219, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'fld_Phone
        '
        Me.fld_Phone.Location = New System.Drawing.Point(112, 167)
        Me.fld_Phone.Mask = "000-000-0000"
        Me.fld_Phone.Name = "fld_Phone"
        Me.fld_Phone.Size = New System.Drawing.Size(74, 20)
        Me.fld_Phone.TabIndex = 43
        '
        'CobSector
        '
        Me.CobSector.BackColor = System.Drawing.Color.SteelBlue
        Me.CobSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CobSector.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CobSector.ForeColor = System.Drawing.Color.White
        Me.CobSector.ItemHeight = 13
        Me.CobSector.Location = New System.Drawing.Point(112, 242)
        Me.CobSector.Name = "CobSector"
        Me.CobSector.Size = New System.Drawing.Size(187, 21)
        Me.CobSector.TabIndex = 41
        '
        'BtnSector
        '
        Me.BtnSector.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSector.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSector.ForeColor = System.Drawing.Color.Black
        Me.BtnSector.Location = New System.Drawing.Point(299, 241)
        Me.BtnSector.Name = "BtnSector"
        Me.BtnSector.Size = New System.Drawing.Size(24, 22)
        Me.BtnSector.TabIndex = 42
        Me.BtnSector.Text = "..."
        Me.BtnSector.UseVisualStyleBackColor = False
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label51.Location = New System.Drawing.Point(8, 218)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(88, 16)
        Me.Label51.TabIndex = 38
        Me.Label51.Text = "Provincia"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CobProvincia
        '
        Me.CobProvincia.BackColor = System.Drawing.Color.SteelBlue
        Me.CobProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CobProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CobProvincia.ForeColor = System.Drawing.Color.White
        Me.CobProvincia.ItemHeight = 13
        Me.CobProvincia.Location = New System.Drawing.Point(112, 216)
        Me.CobProvincia.Name = "CobProvincia"
        Me.CobProvincia.Size = New System.Drawing.Size(187, 21)
        Me.CobProvincia.TabIndex = 39
        '
        'BtnProvincia
        '
        Me.BtnProvincia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProvincia.ForeColor = System.Drawing.Color.Black
        Me.BtnProvincia.Location = New System.Drawing.Point(299, 215)
        Me.BtnProvincia.Name = "BtnProvincia"
        Me.BtnProvincia.Size = New System.Drawing.Size(24, 22)
        Me.BtnProvincia.TabIndex = 40
        Me.BtnProvincia.Text = "..."
        Me.BtnProvincia.UseVisualStyleBackColor = False
        '
        'fldedad
        '
        Me.fldedad.BackColor = System.Drawing.Color.White
        Me.fldedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fldedad.Enabled = False
        Me.fldedad.Location = New System.Drawing.Point(314, 92)
        Me.fldedad.MaxLength = 20
        Me.fldedad.Multiline = True
        Me.fldedad.Name = "fldedad"
        Me.fldedad.ReadOnly = True
        Me.fldedad.Size = New System.Drawing.Size(126, 41)
        Me.fldedad.TabIndex = 36
        '
        'dtpEdad
        '
        Me.dtpEdad.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEdad.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEdad.Location = New System.Drawing.Point(112, 92)
        Me.dtpEdad.Name = "dtpEdad"
        Me.dtpEdad.Size = New System.Drawing.Size(168, 20)
        Me.dtpEdad.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(-16, 327)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 16)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Èmail"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'emailTxt
        '
        Me.emailTxt.Location = New System.Drawing.Point(114, 324)
        Me.emailTxt.MaxLength = 100
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.Size = New System.Drawing.Size(328, 20)
        Me.emailTxt.TabIndex = 31
        Me.emailTxt.Text = "alguien@alguien.com"
        '
        'btnLimite
        '
        Me.btnLimite.Location = New System.Drawing.Point(292, 415)
        Me.btnLimite.Name = "btnLimite"
        Me.btnLimite.Size = New System.Drawing.Size(75, 23)
        Me.btnLimite.TabIndex = 34
        Me.btnLimite.Text = "Establecer"
        Me.btnLimite.Visible = False
        '
        'lblLimite
        '
        Me.lblLimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblLimite.Location = New System.Drawing.Point(52, 418)
        Me.lblLimite.Name = "lblLimite"
        Me.lblLimite.Size = New System.Drawing.Size(112, 24)
        Me.lblLimite.TabIndex = 32
        Me.lblLimite.Text = "Límite PRE-Aprobado"
        Me.lblLimite.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLimite.Visible = False
        '
        'txtLimite
        '
        Me.txtLimite.Location = New System.Drawing.Point(180, 416)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(100, 20)
        Me.txtLimite.TabIndex = 33
        Me.txtLimite.Text = "0.00"
        Me.txtLimite.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(112, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(128, 16)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "DATA CRÉDITO"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.Location = New System.Drawing.Point(264, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 16)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Tipo"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocumento.ForeColor = System.Drawing.Color.White
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(312, 69)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(128, 21)
        Me.cmbTipoDocumento.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(301, 297)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 22)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(54, 270)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(42, 16)
        Me.lblFechaNacimiento.TabIndex = 24
        Me.lblFechaNacimiento.Text = "Ciudad"
        Me.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblApellidos.Location = New System.Drawing.Point(190, 171)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(39, 13)
        Me.lblApellidos.TabIndex = 20
        Me.lblApellidos.Text = "Celular"
        Me.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_Codigo
        '
        Me.fld_Codigo.BackColor = System.Drawing.Color.White
        Me.fld_Codigo.Location = New System.Drawing.Point(112, 24)
        Me.fld_Codigo.Name = "fld_Codigo"
        Me.fld_Codigo.Size = New System.Drawing.Size(74, 20)
        Me.fld_Codigo.TabIndex = 2
        '
        'lblTeléfono
        '
        Me.lblTeléfono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTeléfono.Location = New System.Drawing.Point(8, 171)
        Me.lblTeléfono.Name = "lblTeléfono"
        Me.lblTeléfono.Size = New System.Drawing.Size(88, 16)
        Me.lblTeléfono.TabIndex = 18
        Me.lblTeléfono.Text = "Teléfono "
        Me.lblTeléfono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_Address
        '
        Me.fld_Address.BackColor = System.Drawing.Color.White
        Me.fld_Address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_Address.Location = New System.Drawing.Point(112, 192)
        Me.fld_Address.Name = "fld_Address"
        Me.fld_Address.Size = New System.Drawing.Size(355, 20)
        Me.fld_Address.TabIndex = 23
        '
        'lbDirección
        '
        Me.lbDirección.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbDirección.Location = New System.Drawing.Point(8, 196)
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
        Me.fld_apodo.Location = New System.Drawing.Point(385, 47)
        Me.fld_apodo.Name = "fld_apodo"
        Me.fld_apodo.Size = New System.Drawing.Size(99, 20)
        Me.fld_apodo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(341, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Apodo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdZonas
        '
        Me.cmdZonas.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.cmdZonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdZonas.ForeColor = System.Drawing.Color.White
        Me.cmdZonas.Location = New System.Drawing.Point(114, 297)
        Me.cmdZonas.Name = "cmdZonas"
        Me.cmdZonas.Size = New System.Drawing.Size(187, 21)
        Me.cmdZonas.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(53, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Cartera"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblExcluido
        '
        Me.lblExcluido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExcluido.ForeColor = System.Drawing.Color.Red
        Me.lblExcluido.Location = New System.Drawing.Point(216, 20)
        Me.lblExcluido.Name = "lblExcluido"
        Me.lblExcluido.Size = New System.Drawing.Size(10, 23)
        Me.lblExcluido.TabIndex = 3
        Me.lblExcluido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fld_FullName
        '
        Me.fld_FullName.BackColor = System.Drawing.Color.White
        Me.fld_FullName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_FullName.Location = New System.Drawing.Point(112, 46)
        Me.fld_FullName.Name = "fld_FullName"
        Me.fld_FullName.Size = New System.Drawing.Size(224, 20)
        Me.fld_FullName.TabIndex = 5
        '
        'fld_estado_civil
        '
        Me.fld_estado_civil.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fld_estado_civil.ForeColor = System.Drawing.Color.White
        Me.fld_estado_civil.Items.AddRange(New Object() {"CASADO (A)", "SOLTERO (A)", "UNION LIBRE", "VIUDO (A)"})
        Me.fld_estado_civil.Location = New System.Drawing.Point(112, 115)
        Me.fld_estado_civil.Name = "fld_estado_civil"
        Me.fld_estado_civil.Size = New System.Drawing.Size(168, 21)
        Me.fld_estado_civil.TabIndex = 15
        Me.fld_estado_civil.Text = "CASADO (A)"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label31.Location = New System.Drawing.Point(0, 95)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(96, 16)
        Me.Label31.TabIndex = 12
        Me.Label31.Text = "Fecha Nacimiento"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label54)
        Me.GroupBox2.Controls.Add(Me.fld_Whatsaap_con)
        Me.GroupBox2.Controls.Add(Me.fld_celular_con)
        Me.GroupBox2.Controls.Add(Me.fld_telefono_con)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.fld_apodo_con)
        Me.GroupBox2.Controls.Add(Me.fld_nombre_con)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.fld_cedula_con)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(503, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(328, 152)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cónyuge"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label54.Location = New System.Drawing.Point(176, 97)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(56, 13)
        Me.Label54.TabIndex = 47
        Me.Label54.Text = "Whatsapp"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_Whatsaap_con
        '
        Me.fld_Whatsaap_con.Location = New System.Drawing.Point(172, 116)
        Me.fld_Whatsaap_con.Mask = "000-000-0000"
        Me.fld_Whatsaap_con.Name = "fld_Whatsaap_con"
        Me.fld_Whatsaap_con.Size = New System.Drawing.Size(74, 20)
        Me.fld_Whatsaap_con.TabIndex = 49
        '
        'fld_celular_con
        '
        Me.fld_celular_con.Location = New System.Drawing.Point(93, 116)
        Me.fld_celular_con.Mask = "000-000-0000"
        Me.fld_celular_con.Name = "fld_celular_con"
        Me.fld_celular_con.Size = New System.Drawing.Size(74, 20)
        Me.fld_celular_con.TabIndex = 48
        '
        'fld_telefono_con
        '
        Me.fld_telefono_con.Location = New System.Drawing.Point(12, 116)
        Me.fld_telefono_con.Mask = "000-000-0000"
        Me.fld_telefono_con.Name = "fld_telefono_con"
        Me.fld_telefono_con.Size = New System.Drawing.Size(74, 20)
        Me.fld_telefono_con.TabIndex = 47
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
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(12, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Teléfono"
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
        Me.Label11.Location = New System.Drawing.Point(169, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nombre"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(108, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(46, 16)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Celular"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label32.Location = New System.Drawing.Point(8, 116)
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
        Me.fld_City.Location = New System.Drawing.Point(114, 270)
        Me.fld_City.Name = "fld_City"
        Me.fld_City.Size = New System.Drawing.Size(187, 21)
        Me.fld_City.TabIndex = 25
        '
        'fld_Identity
        '
        Me.fld_Identity.BackColor = System.Drawing.Color.White
        Me.fld_Identity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_Identity.Location = New System.Drawing.Point(112, 68)
        Me.fld_Identity.MaxLength = 13
        Me.fld_Identity.Name = "fld_Identity"
        Me.fld_Identity.Size = New System.Drawing.Size(152, 20)
        Me.fld_Identity.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(301, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 22)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblCedula
        '
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCedula.Location = New System.Drawing.Point(-16, 72)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(112, 16)
        Me.lblCedula.TabIndex = 8
        Me.lblCedula.Text = "Doc. de  Identidad"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNombre.Location = New System.Drawing.Point(8, 47)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(88, 16)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Socio"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label40.Location = New System.Drawing.Point(279, 97)
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
        Me.TabPage1.Controls.Add(Me.Label35)
        Me.TabPage1.Controls.Add(Me.fld_Email_gar)
        Me.TabPage1.Controls.Add(Me.DtpEdad_gar)
        Me.TabPage1.Controls.Add(Me.Label64)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.Label58)
        Me.TabPage1.Controls.Add(Me.fld_whatsaap_gar)
        Me.TabPage1.Controls.Add(Me.fld_ocupacion_gar1)
        Me.TabPage1.Controls.Add(Me.fld_celular_gar)
        Me.TabPage1.Controls.Add(Me.fld_telefono_gar)
        Me.TabPage1.Controls.Add(Me.Label57)
        Me.TabPage1.Controls.Add(Me.CobParentezco)
        Me.TabPage1.Controls.Add(Me.Label56)
        Me.TabPage1.Controls.Add(Me.CobSector_gar)
        Me.TabPage1.Controls.Add(Me.Label52)
        Me.TabPage1.Controls.Add(Me.CobProvincia_gar)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.fld_estado_civil_gar)
        Me.TabPage1.Controls.Add(Me.fld_edad_gar)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.fld_apodo_gar)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.fld_nombre_gar)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.fld_direccion_gar)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.fld_cedula_gar)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.fld_ciudad_gar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(903, 451)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Ficha del Garante (F2)"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.Location = New System.Drawing.Point(-24, 243)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(120, 16)
        Me.Label35.TabIndex = 55
        Me.Label35.Text = "Èmail"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_Email_gar
        '
        Me.fld_Email_gar.Location = New System.Drawing.Point(112, 240)
        Me.fld_Email_gar.MaxLength = 100
        Me.fld_Email_gar.Name = "fld_Email_gar"
        Me.fld_Email_gar.Size = New System.Drawing.Size(328, 20)
        Me.fld_Email_gar.TabIndex = 56
        Me.fld_Email_gar.Text = "alguien@alguien.com"
        '
        'DtpEdad_gar
        '
        Me.DtpEdad_gar.CustomFormat = "dd-MMM-yyyy"
        Me.DtpEdad_gar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpEdad_gar.Location = New System.Drawing.Point(112, 50)
        Me.DtpEdad_gar.Name = "DtpEdad_gar"
        Me.DtpEdad_gar.Size = New System.Drawing.Size(153, 20)
        Me.DtpEdad_gar.TabIndex = 54
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label64.Location = New System.Drawing.Point(0, 53)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(96, 16)
        Me.Label64.TabIndex = 53
        Me.Label64.Text = "Fecha Nacimiento"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.fld_ocupacion_gar)
        Me.GroupBox7.Controls.Add(Me.Label63)
        Me.GroupBox7.Controls.Add(Me.Label60)
        Me.GroupBox7.Controls.Add(Me.fld_telefono_empresa_gar)
        Me.GroupBox7.Controls.Add(Me.fld_empresa_gar)
        Me.GroupBox7.Controls.Add(Me.Label61)
        Me.GroupBox7.Controls.Add(Me.fld_agno_Labor_gar)
        Me.GroupBox7.Controls.Add(Me.Label62)
        Me.GroupBox7.Controls.Add(Me.fld_salario_gar)
        Me.GroupBox7.Controls.Add(Me.Label36)
        Me.GroupBox7.Location = New System.Drawing.Point(45, 266)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox7.Size = New System.Drawing.Size(441, 104)
        Me.GroupBox7.TabIndex = 52
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Datos Laborales"
        '
        'fld_ocupacion_gar
        '
        Me.fld_ocupacion_gar.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fld_ocupacion_gar.ForeColor = System.Drawing.Color.White
        Me.fld_ocupacion_gar.Items.AddRange(New Object() {"ABOGADO (A)", "AMA DE CASA", "ADMINISTRADOR (A)", "AGENTE DE VIAJES", "ALMACENISTA", "ARQUITECTO (A)", "AYUDANTE DE COCINA", "AYUDANTE DE CONSTRUCCION", "AUXILIAR DE OPERACIONES", "AUXILIAR DE CONTABILIDAD", "AUXILAR DE BANCA DE LOTERIA", "AVICULTOR (A)", "ALBANIL", "BARRENDERO (A)", "BARBERO", "BOMBERO", "BARTHENDER", "CAMARERO (A)", "CARNICERO (A)", "CARDIOLOGO (A)", "CONDUCTOR DE AUTOBUS", "CONDUCTOR DE CAMION", "CONSERJE", "CONTABLE", "COMERCIANTE", "DOCTOR (A)", "DIRECTOR (A)", "DECORADOR (A)", "DENTISTA", "DISEÑADOR (A)", "DIGITADOR (A)", "DELIVERY", "EMPRESARIO", "EDUCADOR (A)", "ELECTRICISTA", "EPIDEMIOLOGO (A)", "ENFERMERO (A)", "FARMACEUTICO (A)", "FLORISTA", "FOTOGRAFO (A)", "INFORMATICO (A)", "JARDINERO (A)", "JUEZ (A)", "LIMPIADOR (A)", "MAESTRO CONSTRUCTOR", "MECANICO (A)", "OFICINISTA", "ORTOPEDA", "PELUQUERO (A)", "PERIODISTA", "PORTERO (A)", "PEDIATRA", "PANADERO (A)", "POLICIA", "PORTERO (A)", "PROGRAMADOR (A)", "PRESTAMISTA", "PUBLICISTA", "PLOMERO", "RADIOLOGO (A)", "RECEPCIONISTA", "SASTRE", "SOLDADOR", "SOCORRISTA", "SOLDADO", "SEXOLOGO", "TAXISTA", "TELEFONISTA", "TRAUMATOLOGO", "UROGOLO", "VENDEDOR (A)", "VETERINARIO (A)", "ZAPATERO", "MOTOCONCHO", "MENSAJERO (A)", "MANICURISTA", "GERENTE", "FINANCIERO (A)", "OPERARIO (A)", "OTROS"})
        Me.fld_ocupacion_gar.Location = New System.Drawing.Point(6, 75)
        Me.fld_ocupacion_gar.Name = "fld_ocupacion_gar"
        Me.fld_ocupacion_gar.Size = New System.Drawing.Size(260, 21)
        Me.fld_ocupacion_gar.TabIndex = 79
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label63.Location = New System.Drawing.Point(326, 57)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(39, 13)
        Me.Label63.TabIndex = 50
        Me.Label63.Text = "Salario"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label60.Location = New System.Drawing.Point(265, 56)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(43, 16)
        Me.Label60.TabIndex = 49
        Me.Label60.Text = "Años"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_telefono_empresa_gar
        '
        Me.fld_telefono_empresa_gar.Location = New System.Drawing.Point(339, 30)
        Me.fld_telefono_empresa_gar.Mask = "000-000-0000"
        Me.fld_telefono_empresa_gar.Name = "fld_telefono_empresa_gar"
        Me.fld_telefono_empresa_gar.Size = New System.Drawing.Size(74, 20)
        Me.fld_telefono_empresa_gar.TabIndex = 48
        '
        'fld_empresa_gar
        '
        Me.fld_empresa_gar.BackColor = System.Drawing.Color.White
        Me.fld_empresa_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_empresa_gar.Location = New System.Drawing.Point(8, 30)
        Me.fld_empresa_gar.MaxLength = 55
        Me.fld_empresa_gar.Name = "fld_empresa_gar"
        Me.fld_empresa_gar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_empresa_gar.Size = New System.Drawing.Size(325, 20)
        Me.fld_empresa_gar.TabIndex = 1
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label61.Location = New System.Drawing.Point(339, 13)
        Me.Label61.Name = "Label61"
        Me.Label61.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label61.Size = New System.Drawing.Size(52, 15)
        Me.Label61.TabIndex = 6
        Me.Label61.Text = "Teléfono"
        '
        'fld_agno_Labor_gar
        '
        Me.fld_agno_Labor_gar.BackColor = System.Drawing.Color.White
        Me.fld_agno_Labor_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_agno_Labor_gar.Location = New System.Drawing.Point(272, 74)
        Me.fld_agno_Labor_gar.MaxLength = 15
        Me.fld_agno_Labor_gar.Name = "fld_agno_Labor_gar"
        Me.fld_agno_Labor_gar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_agno_Labor_gar.Size = New System.Drawing.Size(42, 20)
        Me.fld_agno_Labor_gar.TabIndex = 5
        Me.fld_agno_Labor_gar.Text = "0"
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label62.Location = New System.Drawing.Point(18, 12)
        Me.Label62.Name = "Label62"
        Me.Label62.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label62.Size = New System.Drawing.Size(88, 16)
        Me.Label62.TabIndex = 0
        Me.Label62.Text = "Empresa"
        '
        'fld_salario_gar
        '
        Me.fld_salario_gar.BackColor = System.Drawing.Color.White
        Me.fld_salario_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_salario_gar.Location = New System.Drawing.Point(323, 74)
        Me.fld_salario_gar.MaxLength = 55
        Me.fld_salario_gar.Name = "fld_salario_gar"
        Me.fld_salario_gar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_salario_gar.Size = New System.Drawing.Size(93, 20)
        Me.fld_salario_gar.TabIndex = 3
        Me.fld_salario_gar.Text = "0"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label36.Location = New System.Drawing.Point(18, 57)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(59, 13)
        Me.Label36.TabIndex = 10
        Me.Label36.Text = "Ocupación"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label58.Location = New System.Drawing.Point(310, 122)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(56, 13)
        Me.Label58.TabIndex = 47
        Me.Label58.Text = "Whatsaap"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_whatsaap_gar
        '
        Me.fld_whatsaap_gar.Location = New System.Drawing.Point(368, 118)
        Me.fld_whatsaap_gar.Mask = "000-000-0000"
        Me.fld_whatsaap_gar.Name = "fld_whatsaap_gar"
        Me.fld_whatsaap_gar.Size = New System.Drawing.Size(74, 20)
        Me.fld_whatsaap_gar.TabIndex = 46
        '
        'fld_ocupacion_gar1
        '
        Me.fld_ocupacion_gar1.BackColor = System.Drawing.Color.White
        Me.fld_ocupacion_gar1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ocupacion_gar1.Location = New System.Drawing.Point(98, 412)
        Me.fld_ocupacion_gar1.MaxLength = 55
        Me.fld_ocupacion_gar1.Name = "fld_ocupacion_gar1"
        Me.fld_ocupacion_gar1.Size = New System.Drawing.Size(187, 20)
        Me.fld_ocupacion_gar1.TabIndex = 11
        Me.fld_ocupacion_gar1.Visible = False
        '
        'fld_celular_gar
        '
        Me.fld_celular_gar.Location = New System.Drawing.Point(230, 118)
        Me.fld_celular_gar.Mask = "000-000-0000"
        Me.fld_celular_gar.Name = "fld_celular_gar"
        Me.fld_celular_gar.Size = New System.Drawing.Size(74, 20)
        Me.fld_celular_gar.TabIndex = 45
        '
        'fld_telefono_gar
        '
        Me.fld_telefono_gar.Location = New System.Drawing.Point(112, 118)
        Me.fld_telefono_gar.Mask = "000-000-0000"
        Me.fld_telefono_gar.Name = "fld_telefono_gar"
        Me.fld_telefono_gar.Size = New System.Drawing.Size(74, 20)
        Me.fld_telefono_gar.TabIndex = 44
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label57.Location = New System.Drawing.Point(8, 74)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(88, 16)
        Me.Label57.TabIndex = 26
        Me.Label57.Text = "Parentezco"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CobParentezco
        '
        Me.CobParentezco.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.CobParentezco.ForeColor = System.Drawing.Color.White
        Me.CobParentezco.Items.AddRange(New Object() {"HERMANO (A)", "PRIMO (A)", "SOBRINO (A)", "TIO (A)", "CUÑADO(A)", "SUEGRO(A)", "PADRASTRO", "MADRASTRA", "AMIGO(A)"})
        Me.CobParentezco.Location = New System.Drawing.Point(112, 71)
        Me.CobParentezco.Name = "CobParentezco"
        Me.CobParentezco.Size = New System.Drawing.Size(153, 21)
        Me.CobParentezco.TabIndex = 27
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label56.Location = New System.Drawing.Point(8, 218)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(88, 16)
        Me.Label56.TabIndex = 24
        Me.Label56.Text = "Sector"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CobSector_gar
        '
        Me.CobSector_gar.BackColor = System.Drawing.Color.SteelBlue
        Me.CobSector_gar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CobSector_gar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CobSector_gar.ForeColor = System.Drawing.Color.White
        Me.CobSector_gar.ItemHeight = 13
        Me.CobSector_gar.Location = New System.Drawing.Point(112, 216)
        Me.CobSector_gar.Name = "CobSector_gar"
        Me.CobSector_gar.Size = New System.Drawing.Size(187, 21)
        Me.CobSector_gar.TabIndex = 25
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label52.Location = New System.Drawing.Point(8, 167)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(88, 16)
        Me.Label52.TabIndex = 22
        Me.Label52.Text = "Provincia"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CobProvincia_gar
        '
        Me.CobProvincia_gar.BackColor = System.Drawing.Color.SteelBlue
        Me.CobProvincia_gar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CobProvincia_gar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CobProvincia_gar.ForeColor = System.Drawing.Color.White
        Me.CobProvincia_gar.ItemHeight = 13
        Me.CobProvincia_gar.Location = New System.Drawing.Point(112, 165)
        Me.CobProvincia_gar.Name = "CobProvincia_gar"
        Me.CobProvincia_gar.Size = New System.Drawing.Size(187, 21)
        Me.CobProvincia_gar.TabIndex = 23
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label33.Location = New System.Drawing.Point(8, 95)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(88, 16)
        Me.Label33.TabIndex = 8
        Me.Label33.Text = "Estado Civil"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_estado_civil_gar
        '
        Me.fld_estado_civil_gar.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.fld_estado_civil_gar.ForeColor = System.Drawing.Color.White
        Me.fld_estado_civil_gar.Items.AddRange(New Object() {"CASADO (A)", "SOLTERO (A)", "UNION LIBRE", "VIUDO (A)"})
        Me.fld_estado_civil_gar.Location = New System.Drawing.Point(112, 94)
        Me.fld_estado_civil_gar.Name = "fld_estado_civil_gar"
        Me.fld_estado_civil_gar.Size = New System.Drawing.Size(153, 21)
        Me.fld_estado_civil_gar.TabIndex = 9
        '
        'fld_edad_gar
        '
        Me.fld_edad_gar.BackColor = System.Drawing.Color.White
        Me.fld_edad_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_edad_gar.Location = New System.Drawing.Point(311, 50)
        Me.fld_edad_gar.Multiline = True
        Me.fld_edad_gar.Name = "fld_edad_gar"
        Me.fld_edad_gar.Size = New System.Drawing.Size(175, 61)
        Me.fld_edad_gar.TabIndex = 7
        Me.fld_edad_gar.Text = "0"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label34.Location = New System.Drawing.Point(273, 53)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(32, 16)
        Me.Label34.TabIndex = 6
        Me.Label34.Text = "Edad"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label59)
        Me.GroupBox5.Controls.Add(Me.fld_whatsaap_con_gar)
        Me.GroupBox5.Controls.Add(Me.fld_celular_con_gar)
        Me.GroupBox5.Controls.Add(Me.fld_telefono_con_gar)
        Me.GroupBox5.Controls.Add(Me.fld_apodo_con_gar)
        Me.GroupBox5.Controls.Add(Me.fld_nombre_con_gar)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.fld_cedula_con_gar)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(504, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox5.Size = New System.Drawing.Size(328, 128)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos del Cónyuge"
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label59.Location = New System.Drawing.Point(202, 80)
        Me.Label59.Name = "Label59"
        Me.Label59.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label59.Size = New System.Drawing.Size(88, 16)
        Me.Label59.TabIndex = 51
        Me.Label59.Text = "Whatsaap"
        '
        'fld_whatsaap_con_gar
        '
        Me.fld_whatsaap_con_gar.Location = New System.Drawing.Point(198, 96)
        Me.fld_whatsaap_con_gar.Mask = "000-000-0000"
        Me.fld_whatsaap_con_gar.Name = "fld_whatsaap_con_gar"
        Me.fld_whatsaap_con_gar.Size = New System.Drawing.Size(74, 20)
        Me.fld_whatsaap_con_gar.TabIndex = 50
        '
        'fld_celular_con_gar
        '
        Me.fld_celular_con_gar.Location = New System.Drawing.Point(102, 96)
        Me.fld_celular_con_gar.Mask = "000-000-0000"
        Me.fld_celular_con_gar.Name = "fld_celular_con_gar"
        Me.fld_celular_con_gar.Size = New System.Drawing.Size(74, 20)
        Me.fld_celular_con_gar.TabIndex = 49
        '
        'fld_telefono_con_gar
        '
        Me.fld_telefono_con_gar.Location = New System.Drawing.Point(6, 96)
        Me.fld_telefono_con_gar.Mask = "000-000-0000"
        Me.fld_telefono_con_gar.Name = "fld_telefono_con_gar"
        Me.fld_telefono_con_gar.Size = New System.Drawing.Size(74, 20)
        Me.fld_telefono_con_gar.TabIndex = 48
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
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(8, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Teléfono"
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
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(124, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nombre"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(104, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Celular"
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
        Me.fld_apodo_gar.Location = New System.Drawing.Point(387, 4)
        Me.fld_apodo_gar.MaxLength = 55
        Me.fld_apodo_gar.Name = "fld_apodo_gar"
        Me.fld_apodo_gar.Size = New System.Drawing.Size(99, 20)
        Me.fld_apodo_gar.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(339, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Apodo"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_nombre_gar
        '
        Me.fld_nombre_gar.BackColor = System.Drawing.Color.White
        Me.fld_nombre_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_nombre_gar.Location = New System.Drawing.Point(112, 4)
        Me.fld_nombre_gar.MaxLength = 55
        Me.fld_nombre_gar.Name = "fld_nombre_gar"
        Me.fld_nombre_gar.Size = New System.Drawing.Size(224, 20)
        Me.fld_nombre_gar.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.Location = New System.Drawing.Point(8, 192)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 16)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Ciudad"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label22.Location = New System.Drawing.Point(8, 117)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 16)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Teléfono"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_direccion_gar
        '
        Me.fld_direccion_gar.BackColor = System.Drawing.Color.White
        Me.fld_direccion_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_direccion_gar.Location = New System.Drawing.Point(112, 141)
        Me.fld_direccion_gar.MaxLength = 255
        Me.fld_direccion_gar.Name = "fld_direccion_gar"
        Me.fld_direccion_gar.Size = New System.Drawing.Size(328, 20)
        Me.fld_direccion_gar.TabIndex = 17
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.Location = New System.Drawing.Point(8, 142)
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
        Me.fld_cedula_gar.Location = New System.Drawing.Point(112, 27)
        Me.fld_cedula_gar.MaxLength = 13
        Me.fld_cedula_gar.Name = "fld_cedula_gar"
        Me.fld_cedula_gar.Size = New System.Drawing.Size(152, 20)
        Me.fld_cedula_gar.TabIndex = 5
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label24.Location = New System.Drawing.Point(8, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 16)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Cédula"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label25.Location = New System.Drawing.Point(8, 6)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Nombre"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.Location = New System.Drawing.Point(192, 121)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(39, 13)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "Celular"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TabReferencias)
        Me.GroupBox6.Location = New System.Drawing.Point(504, 131)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox6.Size = New System.Drawing.Size(328, 285)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Referencias"
        '
        'TabReferencias
        '
        Me.TabReferencias.Controls.Add(Me.Tab_Personal)
        Me.TabReferencias.Controls.Add(Me.TabComercial)
        Me.TabReferencias.Location = New System.Drawing.Point(6, 14)
        Me.TabReferencias.Name = "TabReferencias"
        Me.TabReferencias.SelectedIndex = 0
        Me.TabReferencias.Size = New System.Drawing.Size(322, 265)
        Me.TabReferencias.TabIndex = 5
        '
        'Tab_Personal
        '
        Me.Tab_Personal.BackColor = System.Drawing.SystemColors.Control
        Me.Tab_Personal.Controls.Add(Me.Panel2)
        Me.Tab_Personal.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Personal.Name = "Tab_Personal"
        Me.Tab_Personal.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Personal.Size = New System.Drawing.Size(314, 239)
        Me.Tab_Personal.TabIndex = 0
        Me.Tab_Personal.Text = "Referencias Personales"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label66)
        Me.Panel2.Controls.Add(Me.CobParentesco_gar2)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.CobParentesco_Ref_Gar1)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Fld_Whatsapp_Ref_Gar2)
        Me.Panel2.Controls.Add(Me.Fld_Cel_Ref_Gar2)
        Me.Panel2.Controls.Add(Me.Fld_Tel_Ref_gar2)
        Me.Panel2.Controls.Add(Me.Fld_Ref_Personal_Gar2)
        Me.Panel2.Controls.Add(Me.Label78)
        Me.Panel2.Controls.Add(Me.Fld_Cedula_Ref_Gar2)
        Me.Panel2.Controls.Add(Me.Label79)
        Me.Panel2.Controls.Add(Me.Label80)
        Me.Panel2.Controls.Add(Me.Label82)
        Me.Panel2.Controls.Add(Me.Label72)
        Me.Panel2.Controls.Add(Me.Fld_Whatsapp__Ref_Gar1)
        Me.Panel2.Controls.Add(Me.Fld_Cel_Ref_Gar1)
        Me.Panel2.Controls.Add(Me.Fld_Tel_Ref_Gar1)
        Me.Panel2.Controls.Add(Me.fld_ref_personales_gar)
        Me.Panel2.Controls.Add(Me.Label73)
        Me.Panel2.Controls.Add(Me.Fld_Cedula_Ref_Gar1)
        Me.Panel2.Controls.Add(Me.Label74)
        Me.Panel2.Controls.Add(Me.Label75)
        Me.Panel2.Controls.Add(Me.Label77)
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(312, 248)
        Me.Panel2.TabIndex = 5
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label66.Location = New System.Drawing.Point(12, 156)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(61, 13)
        Me.Label66.TabIndex = 76
        Me.Label66.Text = "Parentesco"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CobParentesco_gar2
        '
        Me.CobParentesco_gar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.CobParentesco_gar2.ForeColor = System.Drawing.Color.White
        Me.CobParentesco_gar2.Items.AddRange(New Object() {"HERMANO (A)", "PRIMO (A)", "SOBRINO (A)", "TIO (A)", "CUÑADO(A)", "SUEGRO(A)", "PADRASTRO", "MADRASTRA", "AMIGO(A)"})
        Me.CobParentesco_gar2.Location = New System.Drawing.Point(8, 173)
        Me.CobParentesco_gar2.Name = "CobParentesco_gar2"
        Me.CobParentesco_gar2.Size = New System.Drawing.Size(153, 21)
        Me.CobParentesco_gar2.TabIndex = 77
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label28.Location = New System.Drawing.Point(7, 43)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(61, 13)
        Me.Label28.TabIndex = 28
        Me.Label28.Text = "Parentesco"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CobParentesco_Ref_Gar1
        '
        Me.CobParentesco_Ref_Gar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.CobParentesco_Ref_Gar1.ForeColor = System.Drawing.Color.White
        Me.CobParentesco_Ref_Gar1.Items.AddRange(New Object() {"HERMANO (A)", "PRIMO (A)", "SOBRINO (A)", "TIO (A)", "CUÑADO(A)", "SUEGRO(A)", "PADRASTRO", "MADRASTRA", "AMIGO(A)"})
        Me.CobParentesco_Ref_Gar1.Location = New System.Drawing.Point(3, 60)
        Me.CobParentesco_Ref_Gar1.Name = "CobParentesco_Ref_Gar1"
        Me.CobParentesco_Ref_Gar1.Size = New System.Drawing.Size(153, 21)
        Me.CobParentesco_Ref_Gar1.TabIndex = 29
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.Location = New System.Drawing.Point(199, 196)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(88, 16)
        Me.Label27.TabIndex = 75
        Me.Label27.Text = "Whatsaap"
        '
        'Fld_Whatsapp_Ref_Gar2
        '
        Me.Fld_Whatsapp_Ref_Gar2.Location = New System.Drawing.Point(195, 212)
        Me.Fld_Whatsapp_Ref_Gar2.Mask = "000-000-0000"
        Me.Fld_Whatsapp_Ref_Gar2.Name = "Fld_Whatsapp_Ref_Gar2"
        Me.Fld_Whatsapp_Ref_Gar2.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Whatsapp_Ref_Gar2.TabIndex = 74
        '
        'Fld_Cel_Ref_Gar2
        '
        Me.Fld_Cel_Ref_Gar2.Location = New System.Drawing.Point(99, 211)
        Me.Fld_Cel_Ref_Gar2.Mask = "000-000-0000"
        Me.Fld_Cel_Ref_Gar2.Name = "Fld_Cel_Ref_Gar2"
        Me.Fld_Cel_Ref_Gar2.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Cel_Ref_Gar2.TabIndex = 73
        '
        'Fld_Tel_Ref_gar2
        '
        Me.Fld_Tel_Ref_gar2.Location = New System.Drawing.Point(3, 211)
        Me.Fld_Tel_Ref_gar2.Mask = "000-000-0000"
        Me.Fld_Tel_Ref_gar2.Name = "Fld_Tel_Ref_gar2"
        Me.Fld_Tel_Ref_gar2.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Tel_Ref_gar2.TabIndex = 72
        '
        'Fld_Ref_Personal_Gar2
        '
        Me.Fld_Ref_Personal_Gar2.BackColor = System.Drawing.Color.White
        Me.Fld_Ref_Personal_Gar2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Ref_Personal_Gar2.Location = New System.Drawing.Point(5, 134)
        Me.Fld_Ref_Personal_Gar2.MaxLength = 55
        Me.Fld_Ref_Personal_Gar2.Name = "Fld_Ref_Personal_Gar2"
        Me.Fld_Ref_Personal_Gar2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Ref_Personal_Gar2.Size = New System.Drawing.Size(304, 20)
        Me.Fld_Ref_Personal_Gar2.TabIndex = 65
        '
        'Label78
        '
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label78.Location = New System.Drawing.Point(5, 196)
        Me.Label78.Name = "Label78"
        Me.Label78.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label78.Size = New System.Drawing.Size(88, 16)
        Me.Label78.TabIndex = 70
        Me.Label78.Text = "Teléfono"
        '
        'Fld_Cedula_Ref_Gar2
        '
        Me.Fld_Cedula_Ref_Gar2.BackColor = System.Drawing.Color.White
        Me.Fld_Cedula_Ref_Gar2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Cedula_Ref_Gar2.Location = New System.Drawing.Point(164, 174)
        Me.Fld_Cedula_Ref_Gar2.MaxLength = 15
        Me.Fld_Cedula_Ref_Gar2.Name = "Fld_Cedula_Ref_Gar2"
        Me.Fld_Cedula_Ref_Gar2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Cedula_Ref_Gar2.Size = New System.Drawing.Size(144, 20)
        Me.Fld_Cedula_Ref_Gar2.TabIndex = 69
        '
        'Label79
        '
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label79.Location = New System.Drawing.Point(125, 119)
        Me.Label79.Name = "Label79"
        Me.Label79.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label79.Size = New System.Drawing.Size(88, 16)
        Me.Label79.TabIndex = 64
        Me.Label79.Text = "Nombre"
        '
        'Label80
        '
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label80.Location = New System.Drawing.Point(101, 196)
        Me.Label80.Name = "Label80"
        Me.Label80.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label80.Size = New System.Drawing.Size(88, 16)
        Me.Label80.TabIndex = 71
        Me.Label80.Text = "Celular"
        '
        'Label82
        '
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label82.Location = New System.Drawing.Point(169, 156)
        Me.Label82.Name = "Label82"
        Me.Label82.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label82.Size = New System.Drawing.Size(88, 16)
        Me.Label82.TabIndex = 68
        Me.Label82.Text = "Cédula"
        '
        'Label72
        '
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label72.Location = New System.Drawing.Point(199, 82)
        Me.Label72.Name = "Label72"
        Me.Label72.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label72.Size = New System.Drawing.Size(88, 16)
        Me.Label72.TabIndex = 63
        Me.Label72.Text = "Whatsaap"
        '
        'Fld_Whatsapp__Ref_Gar1
        '
        Me.Fld_Whatsapp__Ref_Gar1.Location = New System.Drawing.Point(195, 99)
        Me.Fld_Whatsapp__Ref_Gar1.Mask = "000-000-0000"
        Me.Fld_Whatsapp__Ref_Gar1.Name = "Fld_Whatsapp__Ref_Gar1"
        Me.Fld_Whatsapp__Ref_Gar1.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Whatsapp__Ref_Gar1.TabIndex = 62
        '
        'Fld_Cel_Ref_Gar1
        '
        Me.Fld_Cel_Ref_Gar1.Location = New System.Drawing.Point(99, 98)
        Me.Fld_Cel_Ref_Gar1.Mask = "000-000-0000"
        Me.Fld_Cel_Ref_Gar1.Name = "Fld_Cel_Ref_Gar1"
        Me.Fld_Cel_Ref_Gar1.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Cel_Ref_Gar1.TabIndex = 61
        '
        'Fld_Tel_Ref_Gar1
        '
        Me.Fld_Tel_Ref_Gar1.Location = New System.Drawing.Point(3, 98)
        Me.Fld_Tel_Ref_Gar1.Mask = "000-000-0000"
        Me.Fld_Tel_Ref_Gar1.Name = "Fld_Tel_Ref_Gar1"
        Me.Fld_Tel_Ref_Gar1.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Tel_Ref_Gar1.TabIndex = 60
        '
        'fld_ref_personales_gar
        '
        Me.fld_ref_personales_gar.BackColor = System.Drawing.Color.White
        Me.fld_ref_personales_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ref_personales_gar.Location = New System.Drawing.Point(5, 20)
        Me.fld_ref_personales_gar.MaxLength = 55
        Me.fld_ref_personales_gar.Name = "fld_ref_personales_gar"
        Me.fld_ref_personales_gar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_ref_personales_gar.Size = New System.Drawing.Size(304, 20)
        Me.fld_ref_personales_gar.TabIndex = 53
        '
        'Label73
        '
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label73.Location = New System.Drawing.Point(5, 82)
        Me.Label73.Name = "Label73"
        Me.Label73.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label73.Size = New System.Drawing.Size(88, 16)
        Me.Label73.TabIndex = 58
        Me.Label73.Text = "Teléfono"
        '
        'Fld_Cedula_Ref_Gar1
        '
        Me.Fld_Cedula_Ref_Gar1.BackColor = System.Drawing.Color.White
        Me.Fld_Cedula_Ref_Gar1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Cedula_Ref_Gar1.Location = New System.Drawing.Point(164, 60)
        Me.Fld_Cedula_Ref_Gar1.MaxLength = 15
        Me.Fld_Cedula_Ref_Gar1.Name = "Fld_Cedula_Ref_Gar1"
        Me.Fld_Cedula_Ref_Gar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Cedula_Ref_Gar1.Size = New System.Drawing.Size(144, 20)
        Me.Fld_Cedula_Ref_Gar1.TabIndex = 57
        '
        'Label74
        '
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label74.Location = New System.Drawing.Point(121, 5)
        Me.Label74.Name = "Label74"
        Me.Label74.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label74.Size = New System.Drawing.Size(88, 16)
        Me.Label74.TabIndex = 52
        Me.Label74.Text = "Nombre"
        '
        'Label75
        '
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label75.Location = New System.Drawing.Point(101, 82)
        Me.Label75.Name = "Label75"
        Me.Label75.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label75.Size = New System.Drawing.Size(88, 16)
        Me.Label75.TabIndex = 59
        Me.Label75.Text = "Celular"
        '
        'Label77
        '
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label77.Location = New System.Drawing.Point(169, 42)
        Me.Label77.Name = "Label77"
        Me.Label77.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label77.Size = New System.Drawing.Size(88, 16)
        Me.Label77.TabIndex = 56
        Me.Label77.Text = "Cédula"
        '
        'TabComercial
        '
        Me.TabComercial.BackColor = System.Drawing.SystemColors.Control
        Me.TabComercial.Controls.Add(Me.Panel3)
        Me.TabComercial.Location = New System.Drawing.Point(4, 22)
        Me.TabComercial.Name = "TabComercial"
        Me.TabComercial.Padding = New System.Windows.Forms.Padding(3)
        Me.TabComercial.Size = New System.Drawing.Size(314, 239)
        Me.TabComercial.TabIndex = 1
        Me.TabComercial.Text = "Referencias Comerciales"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label83)
        Me.Panel3.Controls.Add(Me.Fld_Whatsapp_Emp_Gar2)
        Me.Panel3.Controls.Add(Me.Fld_Tel_Emp_Gar2)
        Me.Panel3.Controls.Add(Me.Fld_Dir_Emp_Gar2)
        Me.Panel3.Controls.Add(Me.Fld_Empra_Gar2)
        Me.Panel3.Controls.Add(Me.Label84)
        Me.Panel3.Controls.Add(Me.Fld_Rnc_Emp_Gar2)
        Me.Panel3.Controls.Add(Me.Label85)
        Me.Panel3.Controls.Add(Me.Label87)
        Me.Panel3.Controls.Add(Me.Label88)
        Me.Panel3.Controls.Add(Me.Label89)
        Me.Panel3.Controls.Add(Me.Fld_Whatsapp_emp_Gar1)
        Me.Panel3.Controls.Add(Me.Fld_Tel_Emp_Gar1)
        Me.Panel3.Controls.Add(Me.Fdl_Dir_Emp_Gar1)
        Me.Panel3.Controls.Add(Me.fld_ref_comerciales_gar)
        Me.Panel3.Controls.Add(Me.Label90)
        Me.Panel3.Controls.Add(Me.Fld_Rnc_Emp_Gar1)
        Me.Panel3.Controls.Add(Me.Label91)
        Me.Panel3.Controls.Add(Me.Label93)
        Me.Panel3.Controls.Add(Me.Label94)
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(312, 248)
        Me.Panel3.TabIndex = 6
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label83.Location = New System.Drawing.Point(199, 192)
        Me.Label83.Name = "Label83"
        Me.Label83.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label83.Size = New System.Drawing.Size(56, 13)
        Me.Label83.TabIndex = 75
        Me.Label83.Text = "Whatsaap"
        '
        'Fld_Whatsapp_Emp_Gar2
        '
        Me.Fld_Whatsapp_Emp_Gar2.Location = New System.Drawing.Point(195, 208)
        Me.Fld_Whatsapp_Emp_Gar2.Mask = "000-000-0000"
        Me.Fld_Whatsapp_Emp_Gar2.Name = "Fld_Whatsapp_Emp_Gar2"
        Me.Fld_Whatsapp_Emp_Gar2.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Whatsapp_Emp_Gar2.TabIndex = 74
        '
        'Fld_Tel_Emp_Gar2
        '
        Me.Fld_Tel_Emp_Gar2.Location = New System.Drawing.Point(118, 208)
        Me.Fld_Tel_Emp_Gar2.Mask = "000-000-0000"
        Me.Fld_Tel_Emp_Gar2.Name = "Fld_Tel_Emp_Gar2"
        Me.Fld_Tel_Emp_Gar2.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Tel_Emp_Gar2.TabIndex = 72
        '
        'Fld_Dir_Emp_Gar2
        '
        Me.Fld_Dir_Emp_Gar2.BackColor = System.Drawing.Color.White
        Me.Fld_Dir_Emp_Gar2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Dir_Emp_Gar2.Location = New System.Drawing.Point(5, 170)
        Me.Fld_Dir_Emp_Gar2.MaxLength = 55
        Me.Fld_Dir_Emp_Gar2.Name = "Fld_Dir_Emp_Gar2"
        Me.Fld_Dir_Emp_Gar2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Dir_Emp_Gar2.Size = New System.Drawing.Size(304, 20)
        Me.Fld_Dir_Emp_Gar2.TabIndex = 67
        '
        'Fld_Empra_Gar2
        '
        Me.Fld_Empra_Gar2.BackColor = System.Drawing.Color.White
        Me.Fld_Empra_Gar2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Empra_Gar2.Location = New System.Drawing.Point(5, 134)
        Me.Fld_Empra_Gar2.MaxLength = 55
        Me.Fld_Empra_Gar2.Name = "Fld_Empra_Gar2"
        Me.Fld_Empra_Gar2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Empra_Gar2.Size = New System.Drawing.Size(304, 20)
        Me.Fld_Empra_Gar2.TabIndex = 65
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label84.Location = New System.Drawing.Point(120, 193)
        Me.Label84.Name = "Label84"
        Me.Label84.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label84.Size = New System.Drawing.Size(49, 13)
        Me.Label84.TabIndex = 70
        Me.Label84.Text = "Teléfono"
        '
        'Fld_Rnc_Emp_Gar2
        '
        Me.Fld_Rnc_Emp_Gar2.BackColor = System.Drawing.Color.White
        Me.Fld_Rnc_Emp_Gar2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Rnc_Emp_Gar2.Location = New System.Drawing.Point(5, 207)
        Me.Fld_Rnc_Emp_Gar2.MaxLength = 15
        Me.Fld_Rnc_Emp_Gar2.Name = "Fld_Rnc_Emp_Gar2"
        Me.Fld_Rnc_Emp_Gar2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Rnc_Emp_Gar2.Size = New System.Drawing.Size(107, 20)
        Me.Fld_Rnc_Emp_Gar2.TabIndex = 69
        '
        'Label85
        '
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label85.Location = New System.Drawing.Point(121, 119)
        Me.Label85.Name = "Label85"
        Me.Label85.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label85.Size = New System.Drawing.Size(88, 16)
        Me.Label85.TabIndex = 64
        Me.Label85.Text = "Empresa"
        '
        'Label87
        '
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label87.Location = New System.Drawing.Point(5, 156)
        Me.Label87.Name = "Label87"
        Me.Label87.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label87.Size = New System.Drawing.Size(88, 16)
        Me.Label87.TabIndex = 66
        Me.Label87.Text = "Dirección"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label88.Location = New System.Drawing.Point(10, 193)
        Me.Label88.Name = "Label88"
        Me.Label88.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label88.Size = New System.Drawing.Size(30, 13)
        Me.Label88.TabIndex = 68
        Me.Label88.Text = "RNC"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label89.Location = New System.Drawing.Point(199, 78)
        Me.Label89.Name = "Label89"
        Me.Label89.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label89.Size = New System.Drawing.Size(56, 13)
        Me.Label89.TabIndex = 63
        Me.Label89.Text = "Whatsaap"
        '
        'Fld_Whatsapp_emp_Gar1
        '
        Me.Fld_Whatsapp_emp_Gar1.Location = New System.Drawing.Point(195, 94)
        Me.Fld_Whatsapp_emp_Gar1.Mask = "000-000-0000"
        Me.Fld_Whatsapp_emp_Gar1.Name = "Fld_Whatsapp_emp_Gar1"
        Me.Fld_Whatsapp_emp_Gar1.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Whatsapp_emp_Gar1.TabIndex = 62
        '
        'Fld_Tel_Emp_Gar1
        '
        Me.Fld_Tel_Emp_Gar1.Location = New System.Drawing.Point(119, 94)
        Me.Fld_Tel_Emp_Gar1.Mask = "000-000-0000"
        Me.Fld_Tel_Emp_Gar1.Name = "Fld_Tel_Emp_Gar1"
        Me.Fld_Tel_Emp_Gar1.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Tel_Emp_Gar1.TabIndex = 60
        '
        'Fdl_Dir_Emp_Gar1
        '
        Me.Fdl_Dir_Emp_Gar1.BackColor = System.Drawing.Color.White
        Me.Fdl_Dir_Emp_Gar1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fdl_Dir_Emp_Gar1.Location = New System.Drawing.Point(5, 56)
        Me.Fdl_Dir_Emp_Gar1.MaxLength = 55
        Me.Fdl_Dir_Emp_Gar1.Name = "Fdl_Dir_Emp_Gar1"
        Me.Fdl_Dir_Emp_Gar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fdl_Dir_Emp_Gar1.Size = New System.Drawing.Size(305, 20)
        Me.Fdl_Dir_Emp_Gar1.TabIndex = 55
        '
        'fld_ref_comerciales_gar
        '
        Me.fld_ref_comerciales_gar.BackColor = System.Drawing.Color.White
        Me.fld_ref_comerciales_gar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ref_comerciales_gar.Location = New System.Drawing.Point(5, 20)
        Me.fld_ref_comerciales_gar.MaxLength = 55
        Me.fld_ref_comerciales_gar.Name = "fld_ref_comerciales_gar"
        Me.fld_ref_comerciales_gar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_ref_comerciales_gar.Size = New System.Drawing.Size(304, 20)
        Me.fld_ref_comerciales_gar.TabIndex = 53
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label90.Location = New System.Drawing.Point(121, 79)
        Me.Label90.Name = "Label90"
        Me.Label90.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label90.Size = New System.Drawing.Size(49, 13)
        Me.Label90.TabIndex = 58
        Me.Label90.Text = "Teléfono"
        '
        'Fld_Rnc_Emp_Gar1
        '
        Me.Fld_Rnc_Emp_Gar1.BackColor = System.Drawing.Color.White
        Me.Fld_Rnc_Emp_Gar1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Rnc_Emp_Gar1.Location = New System.Drawing.Point(6, 95)
        Me.Fld_Rnc_Emp_Gar1.MaxLength = 15
        Me.Fld_Rnc_Emp_Gar1.Name = "Fld_Rnc_Emp_Gar1"
        Me.Fld_Rnc_Emp_Gar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Rnc_Emp_Gar1.Size = New System.Drawing.Size(107, 20)
        Me.Fld_Rnc_Emp_Gar1.TabIndex = 57
        '
        'Label91
        '
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label91.Location = New System.Drawing.Point(121, 5)
        Me.Label91.Name = "Label91"
        Me.Label91.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label91.Size = New System.Drawing.Size(88, 16)
        Me.Label91.TabIndex = 52
        Me.Label91.Text = "Empresa"
        '
        'Label93
        '
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label93.Location = New System.Drawing.Point(5, 42)
        Me.Label93.Name = "Label93"
        Me.Label93.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label93.Size = New System.Drawing.Size(88, 16)
        Me.Label93.TabIndex = 54
        Me.Label93.Text = "Dirección"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label94.Location = New System.Drawing.Point(11, 79)
        Me.Label94.Name = "Label94"
        Me.Label94.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label94.Size = New System.Drawing.Size(30, 13)
        Me.Label94.TabIndex = 56
        Me.Label94.Text = "RNC"
        '
        'fld_ciudad_gar
        '
        Me.fld_ciudad_gar.BackColor = System.Drawing.Color.SteelBlue
        Me.fld_ciudad_gar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fld_ciudad_gar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fld_ciudad_gar.ForeColor = System.Drawing.Color.White
        Me.fld_ciudad_gar.ItemHeight = 13
        Me.fld_ciudad_gar.Location = New System.Drawing.Point(112, 190)
        Me.fld_ciudad_gar.Name = "fld_ciudad_gar"
        Me.fld_ciudad_gar.Size = New System.Drawing.Size(187, 21)
        Me.fld_ciudad_gar.TabIndex = 19
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.txtPuesto)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.fldtiempoempresa)
        Me.TabPage2.Controls.Add(Me.Label50)
        Me.TabPage2.Controls.Add(Me.balancePrestamosTxt)
        Me.TabPage2.Controls.Add(Me.Label49)
        Me.TabPage2.Controls.Add(Me.disponibilidadTxt)
        Me.TabPage2.Controls.Add(Me.Label48)
        Me.TabPage2.Controls.Add(Me.fld_nombre_banco2)
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
        Me.TabPage2.Controls.Add(Me.txtPuesto1)
        Me.TabPage2.Controls.Add(Me.fld_ingresos_mesuales)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.fld_otra_informacion)
        Me.TabPage2.Controls.Add(Me.fld_nombre_banco1)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(903, 451)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Otras informaciones (F3)"
        '
        'txtPuesto
        '
        Me.txtPuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.txtPuesto.ForeColor = System.Drawing.Color.White
        Me.txtPuesto.Items.AddRange(New Object() {"ABOGADO (A)", "AMA DE CASA", "ADMINISTRADOR (A)", "AGENTE DE VIAJES", "ALMACENISTA", "ARQUITECTO (A)", "AYUDANTE DE COCINA", "AYUDANTE DE CONSTRUCCION", "AUXILIAR DE OPERACIONES", "AUXILIAR DE CONTABILIDAD", "AUXILAR DE BANCA DE LOTERIA", "AVICULTOR (A)", "ALBANIL", "BARRENDERO (A)", "BARBERO", "BOMBERO", "BARTHENDER", "CAMARERO (A)", "CARNICERO (A)", "CARDIOLOGO (A)", "CONDUCTOR DE AUTOBUS", "CONDUCTOR DE CAMION", "CONSERJE", "CONTABLE", "COMERCIANTE", "DOCTOR (A)", "DIRECTOR (A)", "DECORADOR (A)", "DENTISTA", "DISEÑADOR (A)", "DIGITADOR (A)", "DELIVERY", "EMPRESARIO", "EDUCADOR (A)", "ELECTRICISTA", "EPIDEMIOLOGO (A)", "ENFERMERO (A)", "FARMACEUTICO (A)", "FLORISTA", "FOTOGRAFO (A)", "INFORMATICO (A)", "JARDINERO (A)", "JUEZ (A)", "LIMPIADOR (A)", "MAESTRO CONSTRUCTOR", "MECANICO (A)", "OFICINISTA", "ORTOPEDA", "PELUQUERO (A)", "PERIODISTA", "PORTERO (A)", "PEDIATRA", "PANADERO (A)", "POLICIA", "PORTERO (A)", "PROGRAMADOR (A)", "PRESTAMISTA", "PUBLICISTA", "PLOMERO", "RADIOLOGO (A)", "RECEPCIONISTA", "SASTRE", "SOLDADOR", "SOCORRISTA", "SOLDADO", "SEXOLOGO", "TAXISTA", "TELEFONISTA", "TRAUMATOLOGO", "UROGOLO", "VENDEDOR (A)", "VETERINARIO (A)", "ZAPATERO", "MOTOCONCHO", "MENSAJERO (A)", "MANICURISTA", "GERENTE", "FINANCIERO (A)", "OPERARIO (A)", "OTROS"})
        Me.txtPuesto.Location = New System.Drawing.Point(130, 40)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(282, 21)
        Me.txtPuesto.TabIndex = 78
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label86)
        Me.Panel5.Controls.Add(Me.CobParentesco_Ref_Flia_Clie2)
        Me.Panel5.Controls.Add(Me.Label92)
        Me.Panel5.Controls.Add(Me.CobParentesco_Ref_Flia_Clie1)
        Me.Panel5.Controls.Add(Me.Label110)
        Me.Panel5.Controls.Add(Me.Fld_Whatsapp_Ref_Flia_Clie2)
        Me.Panel5.Controls.Add(Me.Fld_Cel_Ref_Flia_Clie2)
        Me.Panel5.Controls.Add(Me.Fld_Tel_Ref_Flia_Clie2)
        Me.Panel5.Controls.Add(Me.fld_nom_Ref_Flia_Clie2)
        Me.Panel5.Controls.Add(Me.Label111)
        Me.Panel5.Controls.Add(Me.Fld_Ced_Ref_Flia_Clie2)
        Me.Panel5.Controls.Add(Me.Label112)
        Me.Panel5.Controls.Add(Me.Label113)
        Me.Panel5.Controls.Add(Me.Label114)
        Me.Panel5.Controls.Add(Me.Label115)
        Me.Panel5.Controls.Add(Me.Fld_Whatsapp_Ref_Flia_Clie1)
        Me.Panel5.Controls.Add(Me.Fld_Cel_Ref_Flia_Clie1)
        Me.Panel5.Controls.Add(Me.Fld_Tel_Ref_Flia_Clie1)
        Me.Panel5.Controls.Add(Me.fld_nom_Ref_Flia_Clie1)
        Me.Panel5.Controls.Add(Me.Label116)
        Me.Panel5.Controls.Add(Me.Fld_Ced_Ref_Flia_Clie1)
        Me.Panel5.Controls.Add(Me.Label117)
        Me.Panel5.Controls.Add(Me.Label118)
        Me.Panel5.Controls.Add(Me.Label119)
        Me.Panel5.Location = New System.Drawing.Point(524, 27)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(312, 248)
        Me.Panel5.TabIndex = 38
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label86.Location = New System.Drawing.Point(12, 156)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(61, 13)
        Me.Label86.TabIndex = 76
        Me.Label86.Text = "Parentesco"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CobParentesco_Ref_Flia_Clie2
        '
        Me.CobParentesco_Ref_Flia_Clie2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.CobParentesco_Ref_Flia_Clie2.ForeColor = System.Drawing.Color.White
        Me.CobParentesco_Ref_Flia_Clie2.Items.AddRange(New Object() {"HERMANO (A)", "PRIMO (A)", "SOBRINO (A)", "TIO (A)", "CUÑADO(A)", "SUEGRO(A)", "PADRASTRO", "MADRASTRA", "AMIGO(A)"})
        Me.CobParentesco_Ref_Flia_Clie2.Location = New System.Drawing.Point(8, 173)
        Me.CobParentesco_Ref_Flia_Clie2.Name = "CobParentesco_Ref_Flia_Clie2"
        Me.CobParentesco_Ref_Flia_Clie2.Size = New System.Drawing.Size(153, 21)
        Me.CobParentesco_Ref_Flia_Clie2.TabIndex = 77
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label92.Location = New System.Drawing.Point(7, 43)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(61, 13)
        Me.Label92.TabIndex = 28
        Me.Label92.Text = "Parentesco"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CobParentesco_Ref_Flia_Clie1
        '
        Me.CobParentesco_Ref_Flia_Clie1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.CobParentesco_Ref_Flia_Clie1.ForeColor = System.Drawing.Color.White
        Me.CobParentesco_Ref_Flia_Clie1.Items.AddRange(New Object() {"HERMANO (A)", "PRIMO (A)", "SOBRINO (A)", "TIO (A)", "CUÑADO(A)", "SUEGRO(A)", "PADRASTRO", "MADRASTRA", "AMIGO(A)"})
        Me.CobParentesco_Ref_Flia_Clie1.Location = New System.Drawing.Point(3, 59)
        Me.CobParentesco_Ref_Flia_Clie1.Name = "CobParentesco_Ref_Flia_Clie1"
        Me.CobParentesco_Ref_Flia_Clie1.Size = New System.Drawing.Size(153, 21)
        Me.CobParentesco_Ref_Flia_Clie1.TabIndex = 29
        '
        'Label110
        '
        Me.Label110.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label110.Location = New System.Drawing.Point(201, 195)
        Me.Label110.Name = "Label110"
        Me.Label110.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label110.Size = New System.Drawing.Size(88, 16)
        Me.Label110.TabIndex = 75
        Me.Label110.Text = "Whatsaap"
        '
        'Fld_Whatsapp_Ref_Flia_Clie2
        '
        Me.Fld_Whatsapp_Ref_Flia_Clie2.Location = New System.Drawing.Point(195, 214)
        Me.Fld_Whatsapp_Ref_Flia_Clie2.Mask = "000-000-0000"
        Me.Fld_Whatsapp_Ref_Flia_Clie2.Name = "Fld_Whatsapp_Ref_Flia_Clie2"
        Me.Fld_Whatsapp_Ref_Flia_Clie2.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Whatsapp_Ref_Flia_Clie2.TabIndex = 74
        '
        'Fld_Cel_Ref_Flia_Clie2
        '
        Me.Fld_Cel_Ref_Flia_Clie2.Location = New System.Drawing.Point(99, 213)
        Me.Fld_Cel_Ref_Flia_Clie2.Mask = "000-000-0000"
        Me.Fld_Cel_Ref_Flia_Clie2.Name = "Fld_Cel_Ref_Flia_Clie2"
        Me.Fld_Cel_Ref_Flia_Clie2.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Cel_Ref_Flia_Clie2.TabIndex = 73
        '
        'Fld_Tel_Ref_Flia_Clie2
        '
        Me.Fld_Tel_Ref_Flia_Clie2.Location = New System.Drawing.Point(3, 213)
        Me.Fld_Tel_Ref_Flia_Clie2.Mask = "000-000-0000"
        Me.Fld_Tel_Ref_Flia_Clie2.Name = "Fld_Tel_Ref_Flia_Clie2"
        Me.Fld_Tel_Ref_Flia_Clie2.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Tel_Ref_Flia_Clie2.TabIndex = 72
        '
        'fld_nom_Ref_Flia_Clie2
        '
        Me.fld_nom_Ref_Flia_Clie2.BackColor = System.Drawing.Color.White
        Me.fld_nom_Ref_Flia_Clie2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_nom_Ref_Flia_Clie2.Location = New System.Drawing.Point(5, 134)
        Me.fld_nom_Ref_Flia_Clie2.MaxLength = 55
        Me.fld_nom_Ref_Flia_Clie2.Name = "fld_nom_Ref_Flia_Clie2"
        Me.fld_nom_Ref_Flia_Clie2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_nom_Ref_Flia_Clie2.Size = New System.Drawing.Size(304, 20)
        Me.fld_nom_Ref_Flia_Clie2.TabIndex = 65
        '
        'Label111
        '
        Me.Label111.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label111.Location = New System.Drawing.Point(5, 198)
        Me.Label111.Name = "Label111"
        Me.Label111.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label111.Size = New System.Drawing.Size(88, 16)
        Me.Label111.TabIndex = 70
        Me.Label111.Text = "Teléfono"
        '
        'Fld_Ced_Ref_Flia_Clie2
        '
        Me.Fld_Ced_Ref_Flia_Clie2.BackColor = System.Drawing.Color.White
        Me.Fld_Ced_Ref_Flia_Clie2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Ced_Ref_Flia_Clie2.Location = New System.Drawing.Point(164, 174)
        Me.Fld_Ced_Ref_Flia_Clie2.MaxLength = 15
        Me.Fld_Ced_Ref_Flia_Clie2.Name = "Fld_Ced_Ref_Flia_Clie2"
        Me.Fld_Ced_Ref_Flia_Clie2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Ced_Ref_Flia_Clie2.Size = New System.Drawing.Size(144, 20)
        Me.Fld_Ced_Ref_Flia_Clie2.TabIndex = 69
        '
        'Label112
        '
        Me.Label112.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label112.Location = New System.Drawing.Point(131, 119)
        Me.Label112.Name = "Label112"
        Me.Label112.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label112.Size = New System.Drawing.Size(88, 16)
        Me.Label112.TabIndex = 64
        Me.Label112.Text = "Nombre"
        '
        'Label113
        '
        Me.Label113.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label113.Location = New System.Drawing.Point(101, 198)
        Me.Label113.Name = "Label113"
        Me.Label113.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label113.Size = New System.Drawing.Size(88, 16)
        Me.Label113.TabIndex = 71
        Me.Label113.Text = "Celular"
        '
        'Label114
        '
        Me.Label114.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label114.Location = New System.Drawing.Point(169, 156)
        Me.Label114.Name = "Label114"
        Me.Label114.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label114.Size = New System.Drawing.Size(88, 16)
        Me.Label114.TabIndex = 68
        Me.Label114.Text = "Cédula"
        '
        'Label115
        '
        Me.Label115.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label115.Location = New System.Drawing.Point(199, 82)
        Me.Label115.Name = "Label115"
        Me.Label115.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label115.Size = New System.Drawing.Size(88, 16)
        Me.Label115.TabIndex = 63
        Me.Label115.Text = "Whatsaap"
        '
        'Fld_Whatsapp_Ref_Flia_Clie1
        '
        Me.Fld_Whatsapp_Ref_Flia_Clie1.Location = New System.Drawing.Point(195, 98)
        Me.Fld_Whatsapp_Ref_Flia_Clie1.Mask = "000-000-0000"
        Me.Fld_Whatsapp_Ref_Flia_Clie1.Name = "Fld_Whatsapp_Ref_Flia_Clie1"
        Me.Fld_Whatsapp_Ref_Flia_Clie1.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Whatsapp_Ref_Flia_Clie1.TabIndex = 62
        '
        'Fld_Cel_Ref_Flia_Clie1
        '
        Me.Fld_Cel_Ref_Flia_Clie1.Location = New System.Drawing.Point(99, 97)
        Me.Fld_Cel_Ref_Flia_Clie1.Mask = "000-000-0000"
        Me.Fld_Cel_Ref_Flia_Clie1.Name = "Fld_Cel_Ref_Flia_Clie1"
        Me.Fld_Cel_Ref_Flia_Clie1.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Cel_Ref_Flia_Clie1.TabIndex = 61
        '
        'Fld_Tel_Ref_Flia_Clie1
        '
        Me.Fld_Tel_Ref_Flia_Clie1.Location = New System.Drawing.Point(3, 97)
        Me.Fld_Tel_Ref_Flia_Clie1.Mask = "000-000-0000"
        Me.Fld_Tel_Ref_Flia_Clie1.Name = "Fld_Tel_Ref_Flia_Clie1"
        Me.Fld_Tel_Ref_Flia_Clie1.Size = New System.Drawing.Size(74, 20)
        Me.Fld_Tel_Ref_Flia_Clie1.TabIndex = 60
        '
        'fld_nom_Ref_Flia_Clie1
        '
        Me.fld_nom_Ref_Flia_Clie1.BackColor = System.Drawing.Color.White
        Me.fld_nom_Ref_Flia_Clie1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_nom_Ref_Flia_Clie1.Location = New System.Drawing.Point(5, 20)
        Me.fld_nom_Ref_Flia_Clie1.MaxLength = 55
        Me.fld_nom_Ref_Flia_Clie1.Name = "fld_nom_Ref_Flia_Clie1"
        Me.fld_nom_Ref_Flia_Clie1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fld_nom_Ref_Flia_Clie1.Size = New System.Drawing.Size(304, 20)
        Me.fld_nom_Ref_Flia_Clie1.TabIndex = 53
        '
        'Label116
        '
        Me.Label116.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label116.Location = New System.Drawing.Point(5, 82)
        Me.Label116.Name = "Label116"
        Me.Label116.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label116.Size = New System.Drawing.Size(88, 16)
        Me.Label116.TabIndex = 58
        Me.Label116.Text = "Teléfono"
        '
        'Fld_Ced_Ref_Flia_Clie1
        '
        Me.Fld_Ced_Ref_Flia_Clie1.BackColor = System.Drawing.Color.White
        Me.Fld_Ced_Ref_Flia_Clie1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Fld_Ced_Ref_Flia_Clie1.Location = New System.Drawing.Point(164, 59)
        Me.Fld_Ced_Ref_Flia_Clie1.MaxLength = 15
        Me.Fld_Ced_Ref_Flia_Clie1.Name = "Fld_Ced_Ref_Flia_Clie1"
        Me.Fld_Ced_Ref_Flia_Clie1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Fld_Ced_Ref_Flia_Clie1.Size = New System.Drawing.Size(144, 20)
        Me.Fld_Ced_Ref_Flia_Clie1.TabIndex = 57
        '
        'Label117
        '
        Me.Label117.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label117.Location = New System.Drawing.Point(121, 5)
        Me.Label117.Name = "Label117"
        Me.Label117.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label117.Size = New System.Drawing.Size(88, 16)
        Me.Label117.TabIndex = 52
        Me.Label117.Text = "Nombre"
        '
        'Label118
        '
        Me.Label118.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label118.Location = New System.Drawing.Point(101, 82)
        Me.Label118.Name = "Label118"
        Me.Label118.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label118.Size = New System.Drawing.Size(88, 16)
        Me.Label118.TabIndex = 59
        Me.Label118.Text = "Celular"
        '
        'Label119
        '
        Me.Label119.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label119.Location = New System.Drawing.Point(169, 42)
        Me.Label119.Name = "Label119"
        Me.Label119.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label119.Size = New System.Drawing.Size(88, 16)
        Me.Label119.TabIndex = 56
        Me.Label119.Text = "Cédula"
        '
        'fldtiempoempresa
        '
        Me.fldtiempoempresa.BackColor = System.Drawing.Color.White
        Me.fldtiempoempresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fldtiempoempresa.Enabled = False
        Me.fldtiempoempresa.Location = New System.Drawing.Point(290, 64)
        Me.fldtiempoempresa.MaxLength = 20
        Me.fldtiempoempresa.Multiline = True
        Me.fldtiempoempresa.Name = "fldtiempoempresa"
        Me.fldtiempoempresa.ReadOnly = True
        Me.fldtiempoempresa.Size = New System.Drawing.Size(232, 24)
        Me.fldtiempoempresa.TabIndex = 37
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(3, 304)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(96, 13)
        Me.Label50.TabIndex = 32
        Me.Label50.Text = "Bce. de Préstamos"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'balancePrestamosTxt
        '
        Me.balancePrestamosTxt.Enabled = False
        Me.balancePrestamosTxt.Location = New System.Drawing.Point(118, 299)
        Me.balancePrestamosTxt.Name = "balancePrestamosTxt"
        Me.balancePrestamosTxt.Size = New System.Drawing.Size(144, 20)
        Me.balancePrestamosTxt.TabIndex = 31
        Me.balancePrestamosTxt.Text = "0.00"
        Me.balancePrestamosTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(301, 304)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(67, 13)
        Me.Label49.TabIndex = 30
        Me.Label49.Text = "Diponibilidad"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'disponibilidadTxt
        '
        Me.disponibilidadTxt.Enabled = False
        Me.disponibilidadTxt.Location = New System.Drawing.Point(374, 299)
        Me.disponibilidadTxt.Name = "disponibilidadTxt"
        Me.disponibilidadTxt.Size = New System.Drawing.Size(144, 20)
        Me.disponibilidadTxt.TabIndex = 29
        Me.disponibilidadTxt.Text = "0.00"
        Me.disponibilidadTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(320, 270)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(46, 13)
        Me.Label48.TabIndex = 28
        Me.Label48.Text = "Balance"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_nombre_banco2
        '
        Me.fld_nombre_banco2.BackColor = System.Drawing.Color.White
        Me.fld_nombre_banco2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_nombre_banco2.Location = New System.Drawing.Point(290, 14)
        Me.fld_nombre_banco2.MaxLength = 55
        Me.fld_nombre_banco2.Multiline = True
        Me.fld_nombre_banco2.Name = "fld_nombre_banco2"
        Me.fld_nombre_banco2.Size = New System.Drawing.Size(10, 22)
        Me.fld_nombre_banco2.TabIndex = 15
        '
        'balanceGralTxt
        '
        Me.balanceGralTxt.Enabled = False
        Me.balanceGralTxt.Location = New System.Drawing.Point(374, 267)
        Me.balanceGralTxt.Name = "balanceGralTxt"
        Me.balanceGralTxt.Size = New System.Drawing.Size(144, 20)
        Me.balanceGralTxt.TabIndex = 27
        Me.balanceGralTxt.Text = "0.00"
        Me.balanceGralTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(30, 266)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(69, 13)
        Me.Label47.TabIndex = 26
        Me.Label47.Text = "Aportaciones"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'aportacionMontoTxt
        '
        Me.aportacionMontoTxt.Enabled = False
        Me.aportacionMontoTxt.Location = New System.Drawing.Point(118, 267)
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
        Me.GroupBox1.Location = New System.Drawing.Point(11, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 115)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta de ahorro"
        '
        'ahorroBalanceTxt
        '
        Me.ahorroBalanceTxt.Enabled = False
        Me.ahorroBalanceTxt.Location = New System.Drawing.Point(96, 67)
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
        Me.Label42.Location = New System.Drawing.Point(8, 66)
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
        Me.dtpFechaIngresos.Location = New System.Drawing.Point(130, 64)
        Me.dtpFechaIngresos.Name = "dtpFechaIngresos"
        Me.dtpFechaIngresos.Size = New System.Drawing.Size(160, 20)
        Me.dtpFechaIngresos.TabIndex = 22
        '
        'ListView3
        '
        Me.ListView3.Location = New System.Drawing.Point(680, 337)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(120, 56)
        Me.ListView3.TabIndex = 21
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.Visible = False
        '
        'ListView2
        '
        Me.ListView2.Location = New System.Drawing.Point(568, 337)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(108, 56)
        Me.ListView2.TabIndex = 19
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.Visible = False
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(480, 337)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(88, 56)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.Visible = False
        '
        'btnOtrasObligaciones
        '
        Me.btnOtrasObligaciones.Location = New System.Drawing.Point(680, 313)
        Me.btnOtrasObligaciones.Name = "btnOtrasObligaciones"
        Me.btnOtrasObligaciones.Size = New System.Drawing.Size(48, 23)
        Me.btnOtrasObligaciones.TabIndex = 20
        Me.btnOtrasObligaciones.Text = "Préstamos u Otras Obligaciones"
        Me.btnOtrasObligaciones.Visible = False
        '
        'btnEstadoIngresoEgresos
        '
        Me.btnEstadoIngresoEgresos.Location = New System.Drawing.Point(568, 313)
        Me.btnEstadoIngresoEgresos.Name = "btnEstadoIngresoEgresos"
        Me.btnEstadoIngresoEgresos.Size = New System.Drawing.Size(100, 23)
        Me.btnEstadoIngresoEgresos.TabIndex = 18
        Me.btnEstadoIngresoEgresos.Text = "Estado de Ingresos y Egresos"
        Me.btnEstadoIngresoEgresos.Visible = False
        '
        'btnCuentasBanco
        '
        Me.btnCuentasBanco.Location = New System.Drawing.Point(396, 315)
        Me.btnCuentasBanco.Name = "btnCuentasBanco"
        Me.btnCuentasBanco.Size = New System.Drawing.Size(88, 23)
        Me.btnCuentasBanco.TabIndex = 16
        Me.btnCuentasBanco.Text = "Cuentas de Banco"
        Me.btnCuentasBanco.Visible = False
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(629, 8)
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
        Me.txtReferidoPor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferidoPor.Location = New System.Drawing.Point(130, 88)
        Me.txtReferidoPor.MaxLength = 100
        Me.txtReferidoPor.Name = "txtReferidoPor"
        Me.txtReferidoPor.Size = New System.Drawing.Size(392, 20)
        Me.txtReferidoPor.TabIndex = 7
        '
        'txtOriundo
        '
        Me.txtOriundo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOriundo.Location = New System.Drawing.Point(130, 112)
        Me.txtOriundo.MaxLength = 100
        Me.txtOriundo.Name = "txtOriundo"
        Me.txtOriundo.Size = New System.Drawing.Size(392, 20)
        Me.txtOriundo.TabIndex = 9
        '
        'txtPuesto1
        '
        Me.txtPuesto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPuesto1.Location = New System.Drawing.Point(442, 38)
        Me.txtPuesto1.MaxLength = 100
        Me.txtPuesto1.Name = "txtPuesto1"
        Me.txtPuesto1.Size = New System.Drawing.Size(71, 20)
        Me.txtPuesto1.TabIndex = 3
        Me.txtPuesto1.Visible = False
        '
        'fld_ingresos_mesuales
        '
        Me.fld_ingresos_mesuales.BackColor = System.Drawing.Color.White
        Me.fld_ingresos_mesuales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ingresos_mesuales.Location = New System.Drawing.Point(130, 16)
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
        Me.fld_otra_informacion.Location = New System.Drawing.Point(672, 160)
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
        Me.fld_nombre_banco1.Location = New System.Drawing.Point(728, 160)
        Me.fld_nombre_banco1.MaxLength = 55
        Me.fld_nombre_banco1.Name = "fld_nombre_banco1"
        Me.fld_nombre_banco1.Size = New System.Drawing.Size(64, 20)
        Me.fld_nombre_banco1.TabIndex = 14
        Me.fld_nombre_banco1.Text = "N/A"
        Me.fld_nombre_banco1.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtRetiroInteresCert)
        Me.GroupBox4.Controls.Add(Me.lblRetiroInteres)
        Me.GroupBox4.Controls.Add(Me.certificadoBalanceTxt)
        Me.GroupBox4.Controls.Add(Me.certificadoSalidaTxt)
        Me.GroupBox4.Controls.Add(Me.certificadoEntradaTxt)
        Me.GroupBox4.Controls.Add(Me.Label44)
        Me.GroupBox4.Controls.Add(Me.Label45)
        Me.GroupBox4.Controls.Add(Me.Label46)
        Me.GroupBox4.Location = New System.Drawing.Point(265, 146)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 115)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cuenta de certificado"
        '
        'certificadoBalanceTxt
        '
        Me.certificadoBalanceTxt.Enabled = False
        Me.certificadoBalanceTxt.Location = New System.Drawing.Point(96, 92)
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
        Me.Label45.Location = New System.Drawing.Point(2, 91)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(88, 23)
        Me.Label45.TabIndex = 1
        Me.Label45.Text = "Balance Capital"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(8, 40)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(80, 23)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "Retiros Capital"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_ocupacion_cliente1
        '
        Me.fld_ocupacion_cliente1.BackColor = System.Drawing.Color.White
        Me.fld_ocupacion_cliente1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_ocupacion_cliente1.Location = New System.Drawing.Point(319, 509)
        Me.fld_ocupacion_cliente1.MaxLength = 55
        Me.fld_ocupacion_cliente1.Name = "fld_ocupacion_cliente1"
        Me.fld_ocupacion_cliente1.Size = New System.Drawing.Size(328, 20)
        Me.fld_ocupacion_cliente1.TabIndex = 49
        Me.fld_ocupacion_cliente1.Visible = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrar.Location = New System.Drawing.Point(173, 486)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(57, 49)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBorrar.UseVisualStyleBackColor = False
        Me.btnBorrar.Visible = False
        '
        'cmbEstado
        '
        Me.cmbEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.cmbEstado.ForeColor = System.Drawing.Color.White
        Me.cmbEstado.Items.AddRange(New Object() {"BUENO", "MALO", "DESLINDE", "OTROS"})
        Me.cmbEstado.Location = New System.Drawing.Point(650, 496)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(120, 21)
        Me.cmbEstado.TabIndex = 7
        Me.cmbEstado.Text = "BUENO"
        Me.cmbEstado.Visible = False
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(538, 496)
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
        Me.fotoBtn.FlatAppearance.BorderSize = 0
        Me.fotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fotoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.fotoBtn.ForeColor = System.Drawing.Color.Black
        Me.fotoBtn.Image = CType(resources.GetObject("fotoBtn.Image"), System.Drawing.Image)
        Me.fotoBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.fotoBtn.Location = New System.Drawing.Point(251, 486)
        Me.fotoBtn.Name = "fotoBtn"
        Me.fotoBtn.Size = New System.Drawing.Size(57, 49)
        Me.fotoBtn.TabIndex = 5
        Me.fotoBtn.TabStop = False
        Me.fotoBtn.Text = "&Agregar foto"
        Me.fotoBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.fotoBtn.UseVisualStyleBackColor = False
        Me.fotoBtn.Visible = False
        '
        'lblCuentaContable
        '
        Me.lblCuentaContable.Location = New System.Drawing.Point(468, 520)
        Me.lblCuentaContable.Name = "lblCuentaContable"
        Me.lblCuentaContable.Size = New System.Drawing.Size(272, 16)
        Me.lblCuentaContable.TabIndex = 8
        Me.lblCuentaContable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRetiroInteresCert
        '
        Me.txtRetiroInteresCert.Enabled = False
        Me.txtRetiroInteresCert.Location = New System.Drawing.Point(96, 67)
        Me.txtRetiroInteresCert.Name = "txtRetiroInteresCert"
        Me.txtRetiroInteresCert.Size = New System.Drawing.Size(144, 20)
        Me.txtRetiroInteresCert.TabIndex = 7
        Me.txtRetiroInteresCert.Text = "0.00"
        Me.txtRetiroInteresCert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRetiroInteres
        '
        Me.lblRetiroInteres.Location = New System.Drawing.Point(8, 66)
        Me.lblRetiroInteres.Name = "lblRetiroInteres"
        Me.lblRetiroInteres.Size = New System.Drawing.Size(80, 23)
        Me.lblRetiroInteres.TabIndex = 6
        Me.lblRetiroInteres.Text = "Retiros Interes"
        Me.lblRetiroInteres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRM_CLIENTES
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(911, 574)
        Me.Controls.Add(Me.lblCuentaContable)
        Me.Controls.Add(Me.fotoBtn)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.fld_ocupacion_cliente1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FRM_CLIENTES"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Socios"
        Me.TabControl.ResumeLayout(False)
        Me.TP_FICHA_GRAL1.ResumeLayout(False)
        Me.TP_FICHA_GRAL1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.TabReferencias.ResumeLayout(False)
        Me.Tab_Personal.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabComercial.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FRM_CLIENTES_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        LlenarTipoDocumento()
        LlenarProvincia()
        LlenarCiudad()
        LlenarSector()
        LlenarZona()
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
        Dim retiroaportacion As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) AS monto FROM tbl_retiro_ahorros_aportacion WHERE IDSocio=" & idCliente & ";")
        aportacionMontoTxt.Text = Format(aportacion - retiroaportacion, "N2")

        '//// CERTIFICADOS
        Dim depositoCertificado As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(SaldoCapital),0) AS monto FROM tbl_ahorros_certificado WHERE IDCliente=" & idCliente & " AND Estado = 'Activa';")
        certificadoEntradaTxt.Text = Format(depositoCertificado, "N2")

        Dim retiroCertificado As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) AS monto FROM tbl_ahorros_certificado_retiros WHERE IDCliente=" & idCliente & " AND Tipo<>'Interes';")
        certificadoSalidaTxt.Text = Format(retiroCertificado, "N2")
        certificadoBalanceTxt.Text = Format(depositoCertificado - retiroCertificado, "N2")

        Dim retiroInteresCertificado As Decimal = SCALAR_NUM("SELECT IFNULL(SUM(Monto),0) AS monto FROM tbl_ahorros_certificado_retiros WHERE IDCliente=" & idCliente & " AND Tipo='Interes';")
        txtRetiroInteresCert.Text = Format(retiroInteresCertificado, "N2")


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

    Private Sub LlenarProvincia()

        Dim da As New MySqlDataAdapter("SELECT fldCodigo, fldDescripcion FROM tbl_provincia ORDER BY fldDescripcion", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        CobProvincia.DataSource = dt
        CobProvincia.DisplayMember = "fldDescripcion"
        CobProvincia.ValueMember = "fldCodigo"

        CobProvincia_gar.DataSource = dt
        CobProvincia_gar.DisplayMember = "fldDescripcion"
        CobProvincia_gar.ValueMember = "fldCodigo"

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
    Private Sub LlenarSector()

        Dim da As New MySqlDataAdapter("SELECT fldCodigo, fldDescripcion FROM tbl_urbanizacion ORDER BY fldDescripcion", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        CobSector.DataSource = dt
        CobSector.DisplayMember = "fldDescripcion"
        CobSector.ValueMember = "fldCodigo"

        CobSector_gar.DataSource = dt
        CobSector_gar.DisplayMember = "fldDescripcion"
        CobSector_gar.ValueMember = "fldCodigo"

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
        fldtiempoempresa.Text = ""
        fldedad.Text = ""
        emailTxt.Text = "alguien@alguien.com"
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
        Fld_Ref_Personal_clie1.Text = ""
        Cob_Ref_Pesonal_clie1.Text = ""
        Fld_Ced_Ref_Personal_Clie1.Text = ""
        Fld_Tel_Ref_Personal_Clie1.Text = ""
        Fld_Cel_Ref_Personal_Clie1.Text = ""
        Fld_Whatsapp_Ref_Personal_Clie1.Text = ""
        Fld_Ref_Personal_clie2.Text = ""
        Cob_Ref_Pesonal_clie2.Text = ""
        Fld_Ced_Ref_Personal_Clie2.Text = ""
        Fld_Tel_Ref_Personal_Clie2.Text = ""
        Fld_Cel_Ref_Personal_Clie2.Text = ""
        Fld_Whatsapp_Ref_Personal_Clie2.Text = ""
        fld_ref_comerciales_cliente.Text = ""
        Fld_Dir_Ref_Com_Clie1.Text = ""
        Fld_Rnc_Refe_Com_Clie1.Text = ""
        Fld_Tel_Com_clie1.Text = ""
        Fld_Whatsapp_Com_Clie1.Text = ""
        fld_ref_comerciales_cliente2.Text = ""
        Fld_Dir_Ref_Com_Clie2.Text = ""
        Fld_Dir_Ref_Com_Clie2.Text = ""
        Fld_Rnc_Refe_Com_Clie2.Text = ""
        Fld_Tel_Com_clie2.Text = ""
        Fld_Whatsapp_Com_Clie2.Text = ""
        fld_nombre_gar.Text = ""
        fld_apodo_gar.Text = ""
        fld_cedula_gar.Text = ""
        fld_telefono_gar.Text = ""
        fld_celular_gar.Text = ""
        fld_direccion_gar.Text = ""
        fld_ciudad_gar.Text = ""
        fld_ref_personales_gar.Text = ""
        CobParentesco_Ref_Gar1.SelectedText = ""
        Fld_Cedula_Ref_Gar1.Text = ""
        Fld_Tel_Ref_Gar1.Text = ""
        Fld_Cel_Ref_Gar1.Text = ""
        Fld_Whatsapp__Ref_Gar1.Text = ""
        Fld_Ref_Personal_Gar2.Text = ""
        CobParentesco_gar2.Text = ""
        Fld_Cedula_Ref_Gar2.Text = ""
        Fld_Tel_Ref_gar2.Text = ""
        Fld_Cel_Ref_Gar2.Text = ""
        Fld_Whatsapp_Ref_Gar2.Text = ""
        fld_ref_comerciales_gar.Text = ""
        Fdl_Dir_Emp_Gar1.Text = ""
        Fld_Rnc_Emp_Gar1.Text = ""
        Fld_Tel_Emp_Gar1.Text = ""
        Fld_Whatsapp_emp_Gar1.Text = ""
        Fld_Empra_Gar2.Text = ""
        Fld_Dir_Emp_Gar2.Text = ""
        Fld_Rnc_Emp_Gar2.Text = ""
        fld_ingresos_mesuales.Text = "0.00"
        fld_nombre_banco1.Text = ""
        Fld_Tel_Emp_Gar2.Text = ""
        Fld_Whatsapp_Emp_Gar2.Text = ""
        fld_nombre_banco2.Text = ""
        txtCuentaContable.Text = ""
        lblCuentaContable.Text = ""
        fld_otra_informacion.Text = ""
        fld_nom_Ref_Flia_Clie1.Text = ""
        CobParentesco_Ref_Flia_Clie1.Text = ""
        Fld_Ced_Ref_Flia_Clie1.Text = ""
        Fld_Tel_Ref_Flia_Clie1.Text = ""
        Fld_Cel_Ref_Flia_Clie1.Text = ""
        Fld_Whatsapp_Ref_Flia_Clie1.Text = ""
        fld_nom_Ref_Flia_Clie2.Text = ""
        CobParentesco_Ref_Flia_Clie2.Text = ""
        Fld_Ced_Ref_Flia_Clie2.Text = ""
        Fld_Tel_Ref_Flia_Clie2.Text = ""
        Fld_Cel_Ref_Flia_Clie2.Text = ""
        Fld_Whatsapp_Ref_Flia_Clie2.Text = ""
        fld_nombre_con_gar.Text = ""
        fld_apodo_con_gar.Text = ""
        fld_cedula_con_gar.Text = ""
        fld_telefono_con_gar.Text = ""
        fld_celular_con_gar.Text = ""
        dtpEdad.Value = Now.Date
        fld_estado_civil.Text = Nothing
        fld_edad_gar.Text = ""
        fld_estado_civil_gar.Text = Nothing
        fld_ocupacion_cliente1.Text = ""
        fld_ocupacion_gar1.Text = ""
        txtPuesto1.Text = ""
        dtpFechaIngresos.Value = Now.Date
        txtReferidoPor.Text = ""
        txtOriundo.Text = ""
        btnGuardar.Text = "&Guardar"
        cmbEstado.Text = "BUENO"
        lblLimite.Visible = False
        txtLimite.Visible = False
        btnLimite.Visible = False
        fotoBtn.Visible = False
    End Sub
    Dim guardarDatos As Boolean = False

    Dim modificarDatos As Boolean = False
    Private Sub SaveData()
        Try
            If Trim(fld_ingresos_mesuales.Text) = "" Then
                fld_ingresos_mesuales.Text = 0
            End If

            If Trim(fld_edad_gar.Text) = "" Then
                fld_edad_gar.Text = 0
            End If

            Dim cmd As New MySqlCommand

            'With cmd
            '    '.CommandText = "INSERT INTO tbl_clientes (fld_FullName, fld_apodo, TipoDocumento, fld_Identity, fld_Phone, fld_Phone2, fld_Address, fld_City, fld_Status, fld_bce, fld_cod_zona, fld_zona, fld_nombre_con,  fld_apodo_con,  fld_cedula_con,   fld_telefono_con,  fld_celular_con,   fld_ref_personales_cliente,   fld_ref_comerciales_cliente,  fld_nombre_gar,   fld_apodo_gar,   fld_cedula_gar,   fld_telefono_gar,  fld_celular_gar,   fld_direccion_gar,   fld_ciudad_gar,  fld_ref_personales_gar,  fld_ref_comerciales_gar,  fld_ingresos_mesuales,   fld_nombre_banco1,   fld_cuenta_banco1,   fld_nombre_banco2,   fld_cuenta_banco2,   fld_otra_informacion, fld_nombre_con_gar, fld_apodo_con_gar,fld_cedula_con_gar,fld_telefono_con_gar, fld_celular_con_gar, fld_edad, fld_estado_civil, fld_edad_gar, fld_estado_civil_gar, fld_ocupacion_cliente, fld_ocupacion_gar, fld_categoria, Puesto, ReferidoPor, Oriundo,ctaContable,email,fechaIngreso) VALUES('" & fld_FullName.Text & "','" & fld_apodo.Text & "'," & cmbTipoDocumento.SelectedValue & " ,'" & fld_Identity.Text & "', '" & fld_Phone.Text & "', '" & fld_Phone2.Text & "', '" & fld_Address.Text & "','" & fld_City.Text & "', 'N',0, " & cmdZonas.SelectedValue & ", '" & cmdZonas.Text & "', '" & fld_nombre_con.Text & " ','" & fld_apodo_con.Text & "','" & fld_cedula_con.Text & "','" & fld_telefono_con.Text & "','" & fld_celular_con.Text & "','" & fld_ref_personales_cliente.Text & "','" & fld_ref_comerciales_cliente.Text & "','" & fld_nombre_gar.Text & "','" & fld_apodo_gar.Text & "','" & fld_cedula_gar.Text & "','" & fld_telefono_gar.Text & "','" & fld_celular_gar.Text & "','" & fld_direccion_gar.Text & "','" & fld_ciudad_gar.Text & "','" & fld_ref_personales_gar.Text & "','" & fld_ref_comerciales_gar.Text & "'," & CDbl(fld_ingresos_mesuales.Text) & ",'" & fld_nombre_banco1.Text & "','','" & fld_nombre_banco2.Text & "','','" & fld_otra_informacion.Text & "', '" & fld_nombre_con_gar.Text & " ', '" & fld_apodo_con_gar.Text & "', '" & fld_cedula_con_gar.Text & "', '" & fld_telefono_con_gar.Text & "', '" & fld_celular_con_gar.Text & "',  '" & formatDate(dtpEdad.Value.Date) & "', '" & fld_estado_civil.Text & "',  " & CInt(fld_edad_gar.Text) & ", '" & fld_estado_civil_gar.Text & "',  '" & fld_ocupacion_cliente.Text & "', '" & fld_ocupacion_gar.Text & "','" & cmbEstado.Text & "','" & txtPuesto.Text & "','" & txtReferidoPor.Text & "','" & txtOriundo.Text & "','" & txtCuentaContable.Text & "','" & emailTxt.Text & "','" & formatDate(dtpFechaIngresos.Value.Date) & "')"
            '    '.CommandText = "INSERT INTO tbl_clientes (fld_FullName, fld_apodo, TipoDocumento, fld_Identity, fld_Phone, fld_Phone2, fld_Address, fld_City, fld_Status, fld_bce, fld_cod_zona, fld_zona, fld_nombre_con,  fld_apodo_con,  fld_cedula_con,   fld_telefono_con,  fld_celular_con,   fld_ref_personales_cliente,fld_ref_comerciales_cliente,fld_nombre_gar,fld_apodo_gar,fld_cedula_gar,fld_telefono_gar,fld_celular_gar,fld_direccion_gar,fld_ciudad_gar,fld_ref_personales_gar,fld_ref_comerciales_gar,fld_ingresos_mesuales,fld_nombre_banco1,fld_cuenta_banco1,fld_nombre_banco2,fld_cuenta_banco2,fld_otra_informacion, fld_nombre_con_gar, fld_apodo_con_gar,fld_cedula_con_gar,fld_telefono_con_gar, fld_celular_con_gar,fld_edad,fld_estado_civil,fld_edad_gar,fld_estado_civil_gar,fld_ocupacion_cliente,fld_ocupacion_gar,fld_categoria,Puesto,ReferidoPor,Oriundo,ctaContable,email,fechaIngreso,whatsapp,whatsapp_con,parentezco_gar,fecha_nac_gar,whatsapp_gar,email_gar,empresa_gar,telefono_empresa_gar,agno_labor_gar,salario_gar,whatsapp_con_gar,fld_ref_parentesco_clie1,fld_ced_ref_personal_clie1,fld_tel_ref_personal_clie1,fld_cel_ref_personal_clie1,fld_whatsapp_ref_personal_clie1,fld_ref_personal_clie2,fld_ref_parentesco_clie2,fld_ced_ref_personal_clie2,fld_tel_ref_personal_clie2,fld_cel_ref_personal_clie2,fld_whatsapp_ref_personal_clie2,Fld_Dir_Ref_Com_Clie1,Fld_Rnc_Refe_Com_Clie1,Fld_Tel_Com_clie1,Fld_Whatsapp_Com_Clie1,fld_ref_comerciales_cliente2,Fld_Dir_Ref_Com_Clie2,Fld_Rnc_Refe_Com_Clie2,Fld_Tel_Com_clie2,Fld_Whatsapp_Com_Clie2,fld_parentesco_ref_gar1,fld_cedula_ref_gar1,fld_tel_ref_gar1,fld_cel_ref_gar1,fld_whatsapp_ref_gar1,fld_ref_personal_gar2,fld_parentesco_ref_gar2,fld_cedula_ref_gar2,fld_tel_ref_gar2,fld_cel_ref_gar2,fld_whatsapp_ref_gar2,Fdl_Dir_Emp_Gar1,Fld_Rnc_Emp_Gar1,Fld_Tel_Emp_Gar1,Fld_Whatsapp_emp_Gar1,Fld_Empra_Gar2,Fld_Dir_Emp_Gar2,Fld_Rnc_Emp_Gar2,Fld_Tel_Emp_Gar2,Fld_Whatsapp_Emp_Gar2,fld_nom_ref_flia_clie1,fld_parentesco_ref_flia_clie1,fld_ced_ref_flia_clie1,fld_tel_ref_flia_clie1,fld_cel_ref_flia_clie1,fld_whatsapp_ref_flia_clie1,fld_nom_ref_flia_clie2,fld_parentesco_ref_flia_clie2,fld_ced_ref_flia_clie2,fld_tel_ref_flia_clie2,fld_cel_ref_flia_clie2,fld_whats_ref_flia_clie2) VALUES('" & fld_FullName.Text & "','" & fld_apodo.Text & "'," & cmbTipoDocumento.SelectedValue & " ,'" & fld_Identity.Text & "', '" & fld_Phone.Text & "', '" & fld_Phone2.Text & "', '" & fld_Address.Text & "','" & fld_City.Text & "', 'N',0, " & cmdZonas.SelectedValue & ", '" & cmdZonas.Text & "', '" & fld_nombre_con.Text & " ','" & fld_apodo_con.Text & "','" & fld_cedula_con.Text & "','" & fld_telefono_con.Text & "','" & fld_celular_con.Text & "','" & fld_ref_personales_gar.Text & "','" & Fld_Ref_Personal_clie1.Text & "','" & fld_nombre_gar.Text & "','" & fld_apodo_gar.Text & "','" & fld_cedula_gar.Text & "','" & fld_telefono_gar.Text & "','" & fld_celular_gar.Text & "','" & fld_direccion_gar.Text & "','" & fld_ciudad_gar.Text & "','" & fld_ref_personales_gar.Text & "','" & fld_ref_comerciales_gar.Text & "'," & CDbl(fld_ingresos_mesuales.Text) & ",'" & fld_nombre_banco1.Text & "','','" & fld_nombre_banco2.Text & "','','" & fld_otra_informacion.Text & "', '" & fld_nombre_con_gar.Text & " ', '" & fld_apodo_con_gar.Text & "', '" & fld_cedula_con_gar.Text & "', '" & fld_telefono_con_gar.Text & "', '" & fld_celular_con_gar.Text & "',  '" & formatDate(dtpEdad.Value.Date) & "', '" & fld_estado_civil.Text & "',  '" & fld_edad_gar.Text & "', '" & fld_estado_civil_gar.Text & "',  '" & fld_ocupacion_cliente.Text & "', '" & fld_ocupacion_gar.Text & "','" & cmbEstado.Text & "','" & txtPuesto.Text & "','" & txtReferidoPor.Text & "','" & txtOriundo.Text & "','" & txtCuentaContable.Text & "','" & emailTxt.Text & "','" & formatDate(dtpFechaIngresos.Value.Date) & "','" & fld_Whatsapp.Text & "','" & fld_Whatsaap_con.Text & "','" & CobParentezco.Text & "','" & formatDate(DtpEdad_gar.Value.Date) & "','" & fld_whatsaap_gar.Text & "','" & fld_Email_gar.Text & "','" & fld_empresa_gar.Text & "','" & fld_telefono_empresa_gar.Text & "','" & fld_agno_Labor_gar.Text & "','" & fld_salario_gar.Text & "','" & fld_whatsaap_con_gar.Text & "','" & Cob_Ref_Pesonal_clie1.Text & "','" & Fld_Ced_Ref_Personal_Clie1.Text & "','" & Fld_Tel_Ref_Personal_Clie1.Text & "','" & Fld_Cel_Ref_Personal_Clie1.Text & "','" & Fld_Whatsapp_Ref_Personal_Clie1.Text & "','" & Fld_Ref_Personal_clie2.Text & "','" & Cob_Ref_Pesonal_clie2.Text & "','" & Fld_Ced_Ref_Personal_Clie2.Text & "','" & Fld_Tel_Ref_Personal_Clie2.Text & "','" & Fld_Cel_Ref_Personal_Clie2.Text & "','" & Fld_Whatsapp_Ref_Personal_Clie2.Text & "','" & Fld_Dir_Ref_Com_Clie1.Text & "','" & Fld_Rnc_Refe_Com_Clie1.Text & "','" & Fld_Tel_Com_clie1.Text & "','" & Fld_Whatsapp_Com_Clie1.Text & "','" & fld_ref_comerciales_cliente2.Text & "','" & Fld_Dir_Ref_Com_Clie2.Text & "','" & Fld_Rnc_Refe_Com_Clie2.Text & "','" & Fld_Tel_Com_clie2.Text & "','" & Fld_Whatsapp_Com_Clie2.Text & "','" & CobParentesco_Ref_Gar1.Text & "','" & Fld_Cedula_Ref_Gar1.Text & "','" & Fld_Tel_Ref_Gar1.Text & "','" & Fld_Cel_Ref_Gar1.Text & "','" & Fld_Whatsapp__Ref_Gar1.Text & "','" & Fld_Ref_Personal_Gar2.Text & "','" & CobParentesco_gar2.Text & "','" & Fld_Cedula_Ref_Gar2.Text & "','" & Fld_Tel_Ref_gar2.Text & "','" & Fld_Cel_Ref_Gar2.Text & "','" & Fld_Whatsapp_Ref_Gar2.Text & "','" & Fld_Dir_Ref_Com_Clie2.Text & "','" & Fld_Rnc_Refe_Com_Clie2.Text & "','" & Fld_Tel_Com_clie2.Text & "','" & Fld_Whatsapp_Com_Clie2.Text & "','" & Fdl_Dir_Emp_Gar1.Text & "','" & Fld_Rnc_Emp_Gar1.Text & "','" & Fld_Tel_Emp_Gar1.Text & "','" & Fld_Whatsapp_emp_Gar1.Text & "','" & Fld_Empra_Gar2.Text & "','" & Fld_Dir_Emp_Gar2.Text & "','" & Fld_Rnc_Emp_Gar2.Text & "','" & Fld_Tel_Emp_Gar2.Text & "','" & Fld_Whatsapp_Emp_Gar2.Text & "','" & fld_nom_Ref_Flia_Clie1.Text & "','" & CobParentesco_Ref_Flia_Clie1.Text & "','" & Fld_Ced_Ref_Flia_Clie1.Text & "','" & Fld_Tel_Ref_Flia_Clie1.Text & "','" & Fld_Cel_Ref_Flia_Clie1.Text & "','" & Fld_Whatsapp_Ref_Flia_Clie1.Text & "','" & fld_nom_Ref_Flia_Clie2.Text & "','" & CobParentesco_Ref_Flia_Clie2.Text & "','" & Fld_Ced_Ref_Flia_Clie2.Text & "','" & Fld_Tel_Ref_Flia_Clie2.Text & "','" & Fld_Cel_Ref_Flia_Clie2.Text & "','" & Fld_Whatsapp_Ref_Flia_Clie2.Text & "')"
            '    .Connection = conn

            '    .Connection.Open()
            '    .ExecuteNonQuery()
            '    .Connection.Close()
            'End With
            conn.Open()
            cmd = New MySqlCommand("sp_Insertar_socios", conn)
            cmd.CommandType = 4
            cmd.Parameters.Add("_fld_FullName", fld_FullName.Text)
            cmd.Parameters.Add("_fld_apodo", fld_apodo.Text)
            cmd.Parameters.Add("_TipoDocumento", cmbTipoDocumento.SelectedValue)
            cmd.Parameters.Add("_fld_Identity", fld_Identity.Text)
            cmd.Parameters.Add("_fld_Phone", fld_Phone.Text)
            cmd.Parameters.Add("_fld_Phone2", fld_Phone2.Text)
            cmd.Parameters.Add("_fld_Address", fld_Address.Text)
            cmd.Parameters.Add("_fld_City", fld_City.Text)
            cmd.Parameters.Add("_fld_Status", "N")
            cmd.Parameters.Add("_fld_bce", 0)
            cmd.Parameters.Add("_fld_cod_zona", cmdZonas.SelectedValue)
            cmd.Parameters.Add("_fld_zona", cmdZonas.Text)
            cmd.Parameters.Add("_fld_nombre_con", fld_nombre_con.Text)
            cmd.Parameters.Add("_fld_apodo_con", fld_apodo_con.Text)
            cmd.Parameters.Add("_fld_cedula_con", fld_cedula_con.Text)
            cmd.Parameters.Add("_fld_telefono_con", fld_telefono_con.Text)
            cmd.Parameters.Add("_fld_celular_con", fld_celular_con.Text)
            cmd.Parameters.Add("_fld_ref_personales_cliente", Fld_Ref_Personal_clie1.Text)
            cmd.Parameters.Add("_fld_ref_comerciales_cliente", fld_ref_comerciales_cliente.Text)
            cmd.Parameters.Add("_fld_nombre_gar", fld_nombre_gar.Text)
            cmd.Parameters.Add("_fld_apodo_gar", fld_apodo_gar.Text)
            cmd.Parameters.Add("_fld_cedula_gar", fld_cedula_gar.Text)
            cmd.Parameters.Add("_fld_telefono_gar", fld_telefono_gar.Text)
            cmd.Parameters.Add("_fld_celular_gar", fld_cedula_gar.Text)
            cmd.Parameters.Add("_fld_direccion_gar", fld_direccion_gar.Text)
            cmd.Parameters.Add("_fld_ciudad_gar", fld_ciudad_gar.Text)
            cmd.Parameters.Add("_fld_ref_personales_gar", fld_ref_personales_gar.Text)
            cmd.Parameters.Add("_fld_ref_comerciales_gar", fld_ref_comerciales_gar.Text)
            cmd.Parameters.Add("_fld_ingresos_mesuales", fld_ingresos_mesuales.Text)
            cmd.Parameters.Add("_fld_nombre_banco1", "N/A")
            cmd.Parameters.Add("_fld_cuenta_banco1", "N/A")
            cmd.Parameters.Add("_fld_nombre_banco2", "N/A")
            cmd.Parameters.Add("_fld_cuenta_banco2", "N/A")
            cmd.Parameters.Add("_fld_otra_informacion", fld_otra_informacion.Text)
            cmd.Parameters.Add("_fld_nombre_con_gar", fld_nombre_con_gar.Text)
            cmd.Parameters.Add("_fld_apodo_con_gar", fld_apodo_con_gar.Text)
            cmd.Parameters.Add("_fld_cedula_con_gar", fld_cedula_con_gar.Text)
            cmd.Parameters.Add("_fld_telefono_con_gar", fld_telefono_con_gar.Text)
            cmd.Parameters.Add("_fld_celular_con_gar", fld_cedula_con_gar.Text)
            cmd.Parameters.Add("_fld_edad", formatDate(dtpEdad.Value.Date))
            cmd.Parameters.Add("_fld_estado_civil", fld_estado_civil.Text)
            cmd.Parameters.Add("_fld_edad_gar", fld_edad_gar.Text)
            cmd.Parameters.Add("_fld_estado_civil_gar", fld_estado_civil_gar.Text)
            cmd.Parameters.Add("_fld_ocupacion_cliente", fld_ocupacion_cliente.Text)
            cmd.Parameters.Add("_fld_ocupacion_gar", fld_ocupacion_gar.Text)
            cmd.Parameters.Add("_fld_categoria", cmbEstado.Text)
            cmd.Parameters.Add("_Puesto", txtPuesto.Text)
            cmd.Parameters.Add("_ReferidoPor", txtReferidoPor.Text)
            cmd.Parameters.Add("_Oriundo", txtOriundo.Text)
            cmd.Parameters.Add("_ctaContable", txtCuentaContable.Text)
            cmd.Parameters.Add("_email", emailTxt.Text)
            cmd.Parameters.Add("_fechaIngreso", formatDate(dtpFechaIngresos.Value.Date))
            cmd.Parameters.Add("_whatsapp", fld_Whatsapp.Text)
            cmd.Parameters.Add("_whatsapp_con", fld_Whatsaap_con.Text)
            cmd.Parameters.Add("_parentezco_gar", CobParentezco.Text)
            cmd.Parameters.Add("_fecha_nac_gar", formatDate(DtpEdad_gar.Value.Date))
            cmd.Parameters.Add("_whatsapp_gar", fld_whatsaap_gar.Text)
            cmd.Parameters.Add("_email_gar", fld_Email_gar.Text)
            cmd.Parameters.Add("_empresa_gar", fld_empresa_gar.Text)
            cmd.Parameters.Add("_telefono_empresa_gar", fld_telefono_empresa_gar.Text)
            cmd.Parameters.Add("_agno_labor_gar", fld_agno_Labor_gar.Text)
            cmd.Parameters.Add("_salario_gar", fld_salario_gar.Text)
            cmd.Parameters.Add("_whatsapp_con_gar", fld_whatsaap_con_gar.Text)
            cmd.Parameters.Add("_fld_ref_parentesco_clie1", Cob_Ref_Pesonal_clie1.Text)
            cmd.Parameters.Add("_Fld_Ced_Ref_Personal_Clie1", Fld_Ced_Ref_Personal_Clie1.Text)
            cmd.Parameters.Add("_Fld_Tel_Ref_Personal_Clie1", Fld_Tel_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_Fld_Cel_Ref_Personal_Clie1", Fld_Cel_Ref_Personal_Clie1.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Ref_Personal_Clie1", Fld_Whatsapp_Ref_Personal_Clie1.Text)
            cmd.Parameters.Add("_Fld_Ref_Personal_clie2", Fld_Ref_Personal_clie2.Text)
            cmd.Parameters.Add("_fld_ref_parentesco_clie2", Fld_Whatsapp_Ref_Personal_Clie1.Text)
            cmd.Parameters.Add("_Fld_Ced_Ref_Personal_Clie2", Fld_Ced_Ref_Personal_Clie2.Text)
            cmd.Parameters.Add("_Fld_Tel_Ref_Personal_Clie2", Fld_Tel_Ref_Personal_Clie2.Text)
            cmd.Parameters.Add("_Fld_Cel_Ref_Personal_Clie2", Fld_Cel_Ref_Personal_Clie2.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Ref_Personal_Clie2", Fld_Whatsapp_Ref_Personal_Clie2.Text)
            cmd.Parameters.Add("_Fld_Dir_Ref_Com_Clie1", Fld_Dir_Ref_Com_Clie1.Text)
            cmd.Parameters.Add("_Fld_Rnc_Refe_Com_Clie1", Fld_Rnc_Refe_Com_Clie1.Text)
            cmd.Parameters.Add("_Fld_Tel_Com_clie1", Fld_Tel_Com_clie1.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Com_Clie1", Fld_Whatsapp_Com_Clie1.Text)
            cmd.Parameters.Add("_fld_ref_comerciales_cliente2", fld_ref_comerciales_cliente2.Text)
            cmd.Parameters.Add("_Fld_Dir_Ref_Com_Clie2", Fld_Dir_Ref_Com_Clie2.Text)
            cmd.Parameters.Add("_Fld_Rnc_Refe_Com_Clie2", Fld_Rnc_Refe_Com_Clie2.Text)
            cmd.Parameters.Add("_Fld_Tel_Com_clie2", Fld_Tel_Com_clie2.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Com_Clie2", Fld_Whatsapp_Com_Clie2.Text)
            cmd.Parameters.Add("_fld_parentesco_ref_gar1", CobParentesco_Ref_Gar1.Text)
            cmd.Parameters.Add("_Fld_Cedula_Ref_Gar1", Fld_Cedula_Ref_Gar1.Text)
            cmd.Parameters.Add("_Fld_Tel_Ref_Gar1", Fld_Tel_Ref_Gar1.Text)
            cmd.Parameters.Add("_Fld_Cel_Ref_Gar1", Fld_Cel_Ref_Gar1.Text)
            cmd.Parameters.Add("_fld_whatsapp_ref_gar1", Fld_Whatsapp__Ref_Gar1.Text)
            cmd.Parameters.Add("_Fld_Ref_Personal_Gar2", Fld_Ref_Personal_Gar2.Text)
            cmd.Parameters.Add("_fld_parentesco_ref_gar2", CobParentesco_gar2.Text)
            cmd.Parameters.Add("_Fld_Cedula_Ref_Gar2", Fld_Cedula_Ref_Gar2.Text)
            cmd.Parameters.Add("_Fld_Tel_Ref_gar2", Fld_Tel_Ref_gar2.Text)
            cmd.Parameters.Add("_Fld_Cel_Ref_Gar2", Fld_Cel_Ref_Gar2.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Ref_Gar2", Fld_Whatsapp_Ref_Gar2.Text)
            cmd.Parameters.Add("_Fdl_Dir_Emp_Gar1", Fdl_Dir_Emp_Gar1.Text)
            cmd.Parameters.Add("_Fld_Rnc_Emp_Gar1", Fld_Rnc_Emp_Gar1.Text)
            cmd.Parameters.Add("_Fld_Tel_Emp_Gar1", Fld_Tel_Emp_Gar1.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_emp_Gar1", Fld_Whatsapp_emp_Gar1.Text)
            cmd.Parameters.Add("_Fld_Empra_Gar2", Fld_Empra_Gar2.Text)
            cmd.Parameters.Add("_Fld_Dir_Emp_Gar2", Fld_Dir_Emp_Gar2.Text)
            cmd.Parameters.Add("_Fld_Rnc_Emp_Gar2", Fld_Rnc_Emp_Gar2.Text)
            cmd.Parameters.Add("_Fld_Tel_Emp_Gar2", Fld_Tel_Emp_Gar2.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Emp_Gar2", Fld_Whatsapp_Emp_Gar2.Text)
            cmd.Parameters.Add("_fld_nom_Ref_Flia_Clie1", fld_nom_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_fld_parentesco_ref_flia_clie1", CobParentesco_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_Fld_Ced_Ref_Flia_Clie1", Fld_Ced_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_Fld_Tel_Ref_Flia_Clie1", Fld_Tel_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_Fld_Cel_Ref_Flia_Clie1", Fld_Cel_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Ref_Flia_Clie1", Fld_Whatsapp_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_fld_nom_Ref_Flia_Clie2", fld_nom_Ref_Flia_Clie2.Text)
            cmd.Parameters.Add("_fld_parentesco_ref_flia_clie2", CobParentesco_Ref_Flia_Clie2.Text)
            cmd.Parameters.Add("_Fld_Ced_Ref_Flia_Clie2", Fld_Ced_Ref_Flia_Clie2.Text)
            cmd.Parameters.Add("_Fld_Tel_Ref_Flia_Clie2", Fld_Tel_Ref_Flia_Clie2.Text)
            cmd.Parameters.Add("_Fld_Cel_Ref_Flia_Clie2", Fld_Cel_Ref_Flia_Clie2.Text)
            cmd.Parameters.Add("_fld_whats_ref_flia_clie2", Fld_Whatsapp_Ref_Flia_Clie2.Text)

            cmd.Parameters.Add("_fld_sector_id", CobSector.SelectedValue)
            cmd.Parameters.Add("_fld_sector", CobSector.Text)
            cmd.Parameters.Add("_fld_provincia_id", CobProvincia.SelectedValue)
            cmd.Parameters.Add("_fld_provincia", CobProvincia.Text)


            cmd.ExecuteNonQuery()
            conn.Close()
            guardarDatos = True
            'cmd.Dispose()
            fld_Codigo.Text = Format(UltimoID("tbl_clientes", "fld_id"), "0000")
            fld_Codigo.ReadOnly = True
            btnGuardar.Text = "&Modificar"
            fotoBtn.Visible = True
            btnLimite.Visible = True
            txtLimite.Visible = True
            lblLimite.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace)
            'Alerta(ex.Message)
            guardarDatos = False
            conn.Close()
        Finally
            'guardarDatos = True
            conn.Close()
        End Try
    End Sub

    Private Sub save_doc()

        CloseConn()


        If Trim(fld_edad_gar.Text) = "" Then
            fld_edad_gar.Text = 0
        End If
        If btnGuardar.Text = "&Modificar" Then
            If FRMS_CLAVE_MAESTRA("Acceso") = False Then Exit Sub
            If Alerta("Modificando Datos, ¿Seguro que desea Modificar?") = True Then
                UpDateData(CInt(fld_Codigo.Text))
                If modificarDatos = True Then
                    MessageBox.Show("Los Datos del Socio se han Modificado Correctamente", "Modificando Datos Del Nuevo Socio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Los Datos del Socio no se han Modificado Correctamente", "Modificando Datos Del Nuevo Socio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else

            If ValidaFields() = False Then Exit Sub
            If btnGuardar.Text = "&Guardar" Then

                If Alerta("Guardando Datos, ¿Seguro que desea Guardar?") = True Then
                    SaveData()
                    If guardarDatos = True Then
                        MessageBox.Show("Los Datos del Socio se han Guardado Correctamente", "Guardando Datos Del Nuevo Socio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Los Datos del Socio no se han Guardado Correctamente", "Guardando Datos Del Nuevo Socio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                'If FRMS_CLAVE_MAESTRA("Acceso") = False Then Exit Sub
                'If Alerta("Modificando Datos, ¿Seguro que desea Modificar?") = True Then
                '    UpDateData(CInt(fld_Codigo.Text))
                '    If modificarDatos = True Then
                '        MessageBox.Show("Los Datos del Socio se han Modificado Correctamente", "Modificando Datos Del Nuevo Socio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    Else
                '        MessageBox.Show("Los Datos del Socio no se han Modificado Correctamente", "Modificando Datos Del Nuevo Socio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    End If
                'End If

                'UpDateData()
            End If
        End If

    End Sub

    Private Sub LoadData(ByVal idCliente As Integer)


        Dim cmd As New MySqlCommand, dr As MySqlDataReader
        Try
            With cmd
                .CommandText = "SELECT * FROM tbl_clientes WHERE fld_id=" & idCliente & ""
                .Connection = conn
                .Connection.Open()
                dr = .ExecuteReader
            End With
            Dim z As String = ""
            If dr.Read Then
                fld_Codigo.Text = idCliente
                fld_FullName.Text = dr("fld_FullName").ToString
                fld_apodo.Text = dr("fld_apodo").ToString
                fld_Identity.Text = dr("fld_Identity").ToString
                fld_Phone.Text = dr("fld_Phone").ToString
                fld_Phone2.Text = dr("fld_Phone2").ToString
                fld_Address.Text = dr("fld_Address").ToString
                cmbTipoDocumento.SelectedValue = dr("TipoDocumento").ToString
                fld_City.Text = dr("fld_City").ToString
                fld_nombre_con.Text = dr("fld_nombre_con").ToString
                fld_apodo_con.Text = dr("fld_apodo_con").ToString
                fld_cedula_con.Text = dr("fld_cedula_con").ToString
                fld_telefono_con.Text = dr("fld_telefono_con").ToString
                fld_celular_con.Text = dr("fld_celular_con").ToString
                fld_ref_personales_gar.Text = dr("fld_ref_personales_cliente").ToString
                Fld_Ref_Personal_clie1.Text = dr("fld_ref_comerciales_cliente").ToString
                fld_nombre_gar.Text = dr("fld_nombre_gar").ToString
                fld_apodo_gar.Text = dr("fld_apodo_gar").ToString
                fld_cedula_gar.Text = dr("fld_cedula_gar").ToString
                fld_telefono_gar.Text = dr("fld_telefono_gar").ToString
                fld_celular_gar.Text = dr("fld_celular_gar").ToString
                fld_direccion_gar.Text = dr("fld_direccion_gar").ToString
                fld_ciudad_gar.Text = dr("fld_ciudad_gar").ToString
                fld_ref_personales_gar.Text = dr("fld_ref_personales_gar").ToString
                fld_ref_comerciales_gar.Text = dr("fld_ref_comerciales_gar").ToString
                fld_ingresos_mesuales.Text = dr("fld_ingresos_mesuales").ToString
                fld_nombre_banco1.Text = dr("fld_nombre_banco1").ToString

                fld_nombre_banco2.Text = dr("fld_nombre_banco2").ToString

                fld_otra_informacion.Text = dr("fld_otra_informacion").ToString



                txtPuesto.Text = dr("Puesto").ToString
                dtpFechaIngresos.Text = dr("fechaIngreso").ToString
                txtReferidoPor.Text = dr("ReferidoPor").ToString
                txtOriundo.Text = dr("Oriundo").ToString

                fld_nombre_con_gar.Text = dr("fld_nombre_con_gar").ToString
                fld_apodo_con_gar.Text = dr("fld_apodo_con_gar").ToString
                fld_cedula_con_gar.Text = dr("fld_cedula_con_gar").ToString
                fld_telefono_con_gar.Text = dr("fld_telefono_con_gar").ToString
                fld_celular_con_gar.Text = dr("fld_celular_con_gar").ToString
                dtpEdad.Value = dr("fld_edad").ToString
                fld_estado_civil.Text = dr("fld_estado_civil").ToString
                fld_edad_gar.Text = dr("fld_edad_gar").ToString
                fld_estado_civil_gar.Text = dr("fld_estado_civil_gar").ToString

                fld_ocupacion_cliente.Text = dr("fld_ocupacion_cliente").ToString
                fld_ocupacion_gar.Text = dr("fld_ocupacion_gar").ToString
                cmdZonas.SelectedValue = dr("fld_cod_zona").ToString
                cmbEstado.Text = dr("fld_categoria").ToString
                txtCuentaContable.Text = dr("ctaContable").ToString
                emailTxt.Text = dr("email").ToString
                dtpFechaIngresos.Text = dr("fechaIngreso").ToString
                'Campos Nuevos Agregados a la tabla Clintes
                fld_Whatsapp.Text = Convert.ToString(dr("whatsapp"))
                fld_Whatsaap_con.Text = Convert.ToString(dr("whatsapp_con"))
                CobParentezco.Text = Convert.ToString((dr("parentezco_gar")))
                DtpEdad_gar.Text = dr("fecha_nac_gar").ToString
                fld_whatsaap_gar.Text = Convert.ToString(dr("whatsapp_gar"))
                fld_Email_gar.Text = Convert.ToString(dr("email_gar"))
                fld_empresa_gar.Text = Convert.ToString(dr("empresa_gar"))
                fld_telefono_empresa_gar.Text = Convert.ToString(dr("telefono_Empresa_gar"))
                fld_ocupacion_gar.Text = Convert.ToString(dr("fld_ocupacion_gar")).ToString
                fld_agno_Labor_gar.Text = dr("agno_labor_gar").ToString
                fld_salario_gar.Text = dr("salario_gar").ToString
                fld_whatsaap_con_gar.Text = dr("whatsapp_con_gar").ToString
                Cob_Ref_Pesonal_clie1.Text = Convert.ToString(dr("fld_ref_parentesco_clie1"))
                Fld_Ced_Ref_Personal_Clie1.Text = Convert.ToString(dr("fld_ced_ref_personal_clie1"))
                Fld_Tel_Ref_Personal_Clie1.Text = dr("fld_tel_ref_personal_clie1").ToString
                Fld_Cel_Ref_Personal_Clie1.Text = dr("fld_cel_ref_personal_clie1").ToString
                Fld_Whatsapp_Ref_Personal_Clie1.Text = dr("fld_whatsapp_ref_personal_clie1").ToString
                Fld_Ref_Personal_clie2.Text = Convert.ToString(dr("fld_ref_personal_clie2"))
                Cob_Ref_Pesonal_clie2.Text = Convert.ToString(dr("fld_ref_parentesco_clie2"))
                Fld_Ced_Ref_Personal_Clie2.Text = Convert.ToString(dr("fld_ced_ref_personal_clie2"))
                Fld_Tel_Ref_Personal_Clie2.Text = Convert.ToString(dr("fld_tel_ref_personal_clie2"))
                Fld_Cel_Ref_Personal_Clie2.Text = Convert.ToString(dr("fld_cel_ref_personal_clie2"))
                Fld_Whatsapp_Ref_Personal_Clie2.Text = Convert.ToString(dr("fld_whatsapp_ref_personal_clie2"))
                CobParentesco_Ref_Gar1.Text = Convert.ToString(dr("fld_parentesco_ref_gar1"))
                Fld_Cedula_Ref_Gar1.Text = Convert.ToString(dr("fld_cedula_ref_gar1"))
                Fld_Tel_Ref_Gar1.Text = Convert.ToString(dr("fld_tel_ref_gar1"))
                Fld_Cel_Ref_Gar1.Text = Convert.ToString(dr("fld_cel_ref_gar1"))
                Fld_Whatsapp__Ref_Gar1.Text = Convert.ToString(dr("fld_whatsapp_ref_gar1"))
                Fld_Ref_Personal_Gar2.Text = Convert.ToString(dr("fld_ref_personal_gar2"))
                CobParentesco_gar2.Text = Convert.ToString(dr("fld_parentesco_ref_gar2"))
                Fld_Cedula_Ref_Gar2.Text = Convert.ToString(dr("fld_cedula_ref_gar2"))
                Fld_Tel_Ref_gar2.Text = Convert.ToString(dr("fld_tel_ref_gar2"))
                Fld_Cel_Ref_Gar2.Text = Convert.ToString(dr("fld_cel_ref_gar2"))
                Fld_Whatsapp_Ref_Gar2.Text = dr("fld_whatsapp_ref_gar2").ToString
                fld_nom_Ref_Flia_Clie1.Text = Convert.ToString(dr("fld_nom_ref_flia_clie1"))
                CobParentesco_Ref_Flia_Clie1.Text = Convert.ToString(dr("fld_parentesco_ref_flia_clie1"))
                Fld_Ced_Ref_Flia_Clie1.Text = Convert.ToString(dr("fld_ced_ref_flia_clie1"))
                Fld_Tel_Ref_Flia_Clie1.Text = Convert.ToString(dr("fld_tel_ref_flia_clie1"))
                Fld_Cel_Ref_Flia_Clie1.Text = Convert.ToString(dr("fld_cel_ref_flia_clie1"))
                Fld_Whatsapp_Ref_Flia_Clie1.Text = Convert.ToString(dr("fld_whatsapp_ref_flia_clie1"))
                fld_nom_Ref_Flia_Clie2.Text = Convert.ToString(dr("fld_nom_ref_flia_clie2"))
                CobParentesco_Ref_Flia_Clie2.Text = Convert.ToString(dr("fld_parentesco_ref_flia_clie2"))
                Fld_Ced_Ref_Flia_Clie2.Text = Convert.ToString(dr("fld_ced_ref_flia_clie2"))
                Fld_Tel_Ref_Flia_Clie2.Text = Convert.ToString(dr("fld_tel_ref_flia_clie2"))
                Fld_Cel_Ref_Flia_Clie2.Text = Convert.ToString(dr("fld_cel_ref_flia_clie2"))
                Fld_Whatsapp_Ref_Flia_Clie2.Text = Convert.ToString(dr("fld_whats_ref_flia_clie2"))

                CobSector.SelectedValue = dr("fld_sector_id").ToString
                CobProvincia.SelectedValue = dr("fld_provincia_id").ToString


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
        Catch ex As Exception
            MessageBox.Show(ex.Message)

            conn.Close()
        Finally
            conn.Close()

        End Try


        establecerDisponibilidad(idCliente)
        txtLimite.Text = Format(SCALAR_NUM("SELECT fld_limite FROM tbl_clientes WHERE fld_id=" & idCliente & ""), "N2")

        lblCuentaContable.Text = ReturnDescripcion(txtCuentaContable.Text)
    End Sub

    Private Sub UpDateData(Id_Doc As Integer)

        Dim cmd As New MySqlCommand

        'With cmd

        '    .CommandText = "UPDATE tbl_clientes SET TipoDocumento=" & cmbTipoDocumento.SelectedValue & ",fld_FullName='" & fld_FullName.Text & "', fld_apodo='" & fld_apodo.Text & "', fld_Identity='" & fld_Identity.Text & "', fld_Phone='" & fld_Phone.Text & "', fld_Phone2='" & fld_Phone2.Text & "', fld_Address='" & fld_Address.Text & "', fld_City='" & fld_City.Text & "', fld_Status='N', fld_bce=0, fld_cod_zona=" & cmdZonas.SelectedValue & ", fld_zona='" & cmdZonas.Text & "', fld_nombre_con='" & fld_nombre_con.Text & "',  fld_apodo_con='" & fld_apodo_con.Text & "',  fld_cedula_con='" & fld_cedula_con.Text & "',   fld_telefono_con='" & fld_telefono_con.Text & "',  fld_celular_con='" & fld_celular_con.Text & "',   fld_ref_personales_cliente='" & fld_ref_personales_gar.Text & "',   fld_ref_comerciales_cliente='" & Fld_Ref_Personal_clie1.Text & "',  fld_nombre_gar='" & fld_nombre_gar.Text & "',   fld_apodo_gar='" & fld_apodo_gar.Text & "',   fld_cedula_gar='" & fld_cedula_gar.Text & "',   fld_telefono_gar='" & fld_telefono_gar.Text & "',  fld_celular_gar='" & fld_celular_gar.Text & "',   fld_direccion_gar='" & fld_direccion_gar.Text & "',   fld_ciudad_gar='" & fld_ciudad_gar.Text & "',  fld_ref_personales_gar='" & fld_ref_personales_gar.Text & "',  fld_ref_comerciales_gar='" & fld_ref_comerciales_gar.Text & "',  fld_ingresos_mesuales=" & CDbl(fld_ingresos_mesuales.Text) & ",   fld_nombre_banco1='" & fld_nombre_banco1.Text & "',   fld_cuenta_banco1='',   fld_nombre_banco2='" & fld_nombre_banco2.Text & "',   fld_cuenta_banco2='',   fld_otra_informacion='" & fld_otra_informacion.Text & "', fld_nombre_con_gar='" & fld_nombre_con_gar.Text & "', fld_apodo_con_gar='" & fld_apodo_con_gar.Text & "',fld_cedula_con_gar='" & fld_cedula_con_gar.Text & "',fld_telefono_con_gar='" & fld_telefono_con_gar.Text & "', fld_celular_con_gar='" & fld_celular_con_gar.Text & "', fld_edad='" & formatDate(dtpEdad.Value.Date) & "', fld_estado_civil='" & fld_estado_civil.Text & "', fld_edad_gar=" & fld_edad_gar.Text & ", fld_estado_civil_gar='" & fld_estado_civil_gar.Text & "', fld_ocupacion_cliente='" & fld_ocupacion_cliente.Text & "', fld_ocupacion_gar ='" & fld_ocupacion_gar.Text & "', fld_categoria='" & cmbEstado.Text & "', Puesto='" & txtPuesto.Text & "', ReferidoPor='" & txtReferidoPor.Text & "', Oriundo='" & txtOriundo.Text & "', ctaContable='" & txtCuentaContable.Text & "',email='" & emailTxt.Text & "', fechaIngreso='" & formatDate(dtpFechaIngresos.Value.Date) & "' WHERE fld_id=" & id_doc & ""

        '    .Connection = conn
        '    .Connection.Open()
        '    .ExecuteNonQuery()
        '    .Connection.Close()
        'End With

        'cmd.Dispose()
        Try
            conn.Open()
            cmd = New MySqlCommand("sp_Actualiar_socios", conn)
            cmd.CommandType = 4
            cmd.Parameters.Add("_fld_ID", Id_Doc)
            cmd.Parameters.Add("_fld_FullName", fld_FullName.Text)
            cmd.Parameters.Add("_fld_apodo", fld_apodo.Text)
            cmd.Parameters.Add("_TipoDocumento", cmbTipoDocumento.SelectedValue)
            cmd.Parameters.Add("_fld_Identity", fld_Identity.Text)
            cmd.Parameters.Add("_fld_Phone", fld_Phone.Text)
            cmd.Parameters.Add("_fld_Phone2", fld_Phone2.Text)
            cmd.Parameters.Add("_fld_Address", fld_Address.Text)
            cmd.Parameters.Add("_fld_City", fld_City.Text)
            cmd.Parameters.Add("_fld_Status", "N")
            cmd.Parameters.Add("_fld_bce", 0)
            cmd.Parameters.Add("_fld_cod_zona", cmdZonas.SelectedValue)
            cmd.Parameters.Add("_fld_zona", cmdZonas.Text)
            cmd.Parameters.Add("_fld_nombre_con", fld_nombre_con.Text)
            cmd.Parameters.Add("_fld_apodo_con", fld_apodo_con.Text)
            cmd.Parameters.Add("_fld_cedula_con", fld_cedula_con.Text)
            cmd.Parameters.Add("_fld_telefono_con", fld_telefono_con.Text)
            cmd.Parameters.Add("_fld_celular_con", fld_celular_con.Text)
            cmd.Parameters.Add("_fld_ref_personales_cliente", Fld_Ref_Personal_clie1.Text)
            cmd.Parameters.Add("_fld_ref_comerciales_cliente", fld_ref_comerciales_cliente.Text)
            cmd.Parameters.Add("_fld_nombre_gar", fld_nombre_gar.Text)
            cmd.Parameters.Add("_fld_apodo_gar", fld_apodo_gar.Text)
            cmd.Parameters.Add("_fld_cedula_gar", fld_cedula_gar.Text)
            cmd.Parameters.Add("_fld_telefono_gar", fld_telefono_gar.Text)
            cmd.Parameters.Add("_fld_celular_gar", fld_cedula_con.Text)
            cmd.Parameters.Add("_fld_direccion_gar", fld_direccion_gar.Text)
            cmd.Parameters.Add("_fld_ciudad_gar", fld_ciudad_gar.Text)
            cmd.Parameters.Add("_fld_ref_personales_gar", fld_ref_personales_gar.Text)
            cmd.Parameters.Add("_fld_ref_comerciales_gar", fld_ref_comerciales_gar.Text)
            cmd.Parameters.Add("_fld_ingresos_mesuales", fld_ingresos_mesuales.Text)
            cmd.Parameters.Add("_fld_nombre_banco1", "N/A")
            cmd.Parameters.Add("_fld_cuenta_banco1", "N/A")
            cmd.Parameters.Add("_fld_nombre_banco2", "N/A")
            cmd.Parameters.Add("_fld_cuenta_banco2", "N/A")
            cmd.Parameters.Add("_fld_otra_informacion", fld_otra_informacion.Text)
            cmd.Parameters.Add("_fld_nombre_con_gar", fld_nombre_con_gar.Text)
            cmd.Parameters.Add("_fld_apodo_con_gar", fld_apodo_con_gar.Text)
            cmd.Parameters.Add("_fld_cedula_con_gar", fld_cedula_con_gar.Text)
            cmd.Parameters.Add("_fld_telefono_con_gar", fld_telefono_con_gar.Text)
            cmd.Parameters.Add("_fld_celular_con_gar", fld_cedula_con_gar.Text)
            cmd.Parameters.Add("_fld_edad", formatDate(dtpEdad.Value.Date))
            cmd.Parameters.Add("_fld_estado_civil", fld_estado_civil.Text)
            cmd.Parameters.Add("_fld_edad_gar", fld_edad_gar.Text)
            cmd.Parameters.Add("_fld_estado_civil_gar", fld_estado_civil_gar.Text)
            cmd.Parameters.Add("_fld_ocupacion_cliente", fld_ocupacion_cliente1.Text)
            cmd.Parameters.Add("_fld_ocupacion_gar", fld_ocupacion_gar1.Text)
            cmd.Parameters.Add("_fld_categoria", cmbEstado.Text)
            cmd.Parameters.Add("_Puesto", txtPuesto1.Text)
            cmd.Parameters.Add("_ReferidoPor", txtReferidoPor.Text)
            cmd.Parameters.Add("_Oriundo", txtOriundo.Text)
            cmd.Parameters.Add("_ctaContable", txtCuentaContable.Text)
            cmd.Parameters.Add("_email", emailTxt.Text)
            cmd.Parameters.Add("_fechaIngreso", formatDate(dtpFechaIngresos.Value.Date))
            cmd.Parameters.Add("_whatsapp", fld_Whatsapp.Text)
            cmd.Parameters.Add("_whatsapp_con", fld_Whatsaap_con.Text)
            cmd.Parameters.Add("_parentezco_gar", CobParentezco.Text)
            cmd.Parameters.Add("_fecha_nac_gar", formatDate(DtpEdad_gar.Value.Date))
            cmd.Parameters.Add("_whatsapp_gar", fld_whatsaap_gar.Text)
            cmd.Parameters.Add("_email_gar", fld_Email_gar.Text)
            cmd.Parameters.Add("_empresa_gar", fld_empresa_gar.Text)
            cmd.Parameters.Add("_telefono_empresa_gar", fld_telefono_empresa_gar.Text)
            cmd.Parameters.Add("_agno_labor_gar", fld_agno_Labor_gar.Text)
            cmd.Parameters.Add("_salario_gar", fld_salario_gar.Text)
            cmd.Parameters.Add("_whatsapp_con_gar", fld_whatsaap_con_gar.Text)
            cmd.Parameters.Add("_fld_ref_parentesco_clie1", Cob_Ref_Pesonal_clie1.Text)
            cmd.Parameters.Add("_Fld_Ced_Ref_Personal_Clie1", Fld_Ced_Ref_Personal_Clie1.Text)
            cmd.Parameters.Add("_Fld_Tel_Ref_Personal_Clie1", Fld_Tel_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_Fld_Cel_Ref_Personal_Clie1", Fld_Cel_Ref_Personal_Clie1.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Ref_Personal_Clie1", Fld_Whatsapp_Ref_Personal_Clie1.Text)
            cmd.Parameters.Add("_Fld_Ref_Personal_clie2", Fld_Ref_Personal_clie2.Text)
            cmd.Parameters.Add("_fld_ref_parentesco_clie2", Fld_Whatsapp_Ref_Personal_Clie1.Text)
            cmd.Parameters.Add("_Fld_Ced_Ref_Personal_Clie2", Fld_Ced_Ref_Personal_Clie2.Text)
            cmd.Parameters.Add("_Fld_Tel_Ref_Personal_Clie2", Fld_Tel_Ref_Personal_Clie2.Text)
            cmd.Parameters.Add("_Fld_Cel_Ref_Personal_Clie2", Fld_Cel_Ref_Personal_Clie2.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Ref_Personal_Clie2", Fld_Whatsapp_Ref_Personal_Clie2.Text)
            cmd.Parameters.Add("_Fld_Dir_Ref_Com_Clie1", Fld_Dir_Ref_Com_Clie1.Text)
            cmd.Parameters.Add("_Fld_Rnc_Refe_Com_Clie1", Fld_Rnc_Refe_Com_Clie1.Text)
            cmd.Parameters.Add("_Fld_Tel_Com_clie1", Fld_Tel_Com_clie1.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Com_Clie1", Fld_Whatsapp_Com_Clie1.Text)
            cmd.Parameters.Add("_fld_ref_comerciales_cliente2", fld_ref_comerciales_cliente2.Text)
            cmd.Parameters.Add("_Fld_Dir_Ref_Com_Clie2", Fld_Dir_Ref_Com_Clie2.Text)
            cmd.Parameters.Add("_Fld_Rnc_Refe_Com_Clie2", Fld_Rnc_Refe_Com_Clie2.Text)
            cmd.Parameters.Add("_Fld_Tel_Com_clie2", Fld_Tel_Com_clie2.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Com_Clie2", Fld_Whatsapp_Com_Clie2.Text)
            cmd.Parameters.Add("_fld_parentesco_ref_gar1", CobParentesco_Ref_Gar1.Text)
            cmd.Parameters.Add("_Fld_Cedula_Ref_Gar1", Fld_Cedula_Ref_Gar1.Text)
            cmd.Parameters.Add("_Fld_Tel_Ref_Gar1", Fld_Tel_Ref_Gar1.Text)
            cmd.Parameters.Add("_Fld_Cel_Ref_Gar1", Fld_Cel_Ref_Gar1.Text)
            cmd.Parameters.Add("_fld_whatsapp_ref_gar1", Fld_Whatsapp__Ref_Gar1.Text)
            cmd.Parameters.Add("_Fld_Ref_Personal_Gar2", Fld_Ref_Personal_Gar2.Text)
            cmd.Parameters.Add("_fld_parentesco_ref_gar2", CobParentesco_gar2.Text)
            cmd.Parameters.Add("_Fld_Cedula_Ref_Gar2", Fld_Cedula_Ref_Gar2.Text)
            cmd.Parameters.Add("_Fld_Tel_Ref_gar2", Fld_Tel_Ref_gar2.Text)
            cmd.Parameters.Add("_Fld_Cel_Ref_Gar2", Fld_Cel_Ref_Gar2.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Ref_Gar2", Fld_Whatsapp_Ref_Gar2.Text)
            cmd.Parameters.Add("_Fdl_Dir_Emp_Gar1", Fdl_Dir_Emp_Gar1.Text)
            cmd.Parameters.Add("_Fld_Rnc_Emp_Gar1", Fld_Rnc_Emp_Gar1.Text)
            cmd.Parameters.Add("_Fld_Tel_Emp_Gar1", Fld_Tel_Emp_Gar1.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_emp_Gar1", Fld_Whatsapp_emp_Gar1.Text)
            cmd.Parameters.Add("_Fld_Empra_Gar2", Fld_Empra_Gar2.Text)
            cmd.Parameters.Add("_Fld_Dir_Emp_Gar2", Fld_Dir_Emp_Gar2.Text)
            cmd.Parameters.Add("_Fld_Rnc_Emp_Gar2", Fld_Rnc_Emp_Gar2.Text)
            cmd.Parameters.Add("_Fld_Tel_Emp_Gar2", Fld_Tel_Emp_Gar2.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Emp_Gar2", Fld_Whatsapp_Emp_Gar2.Text)
            cmd.Parameters.Add("_fld_nom_Ref_Flia_Clie1", fld_nom_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_fld_parentesco_ref_flia_clie1", CobParentesco_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_Fld_Ced_Ref_Flia_Clie1", Fld_Ced_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_Fld_Tel_Ref_Flia_Clie1", Fld_Tel_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_Fld_Cel_Ref_Flia_Clie1", Fld_Cel_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_Fld_Whatsapp_Ref_Flia_Clie1", Fld_Whatsapp_Ref_Flia_Clie1.Text)
            cmd.Parameters.Add("_fld_nom_Ref_Flia_Clie2", fld_nom_Ref_Flia_Clie2.Text)
            cmd.Parameters.Add("_fld_parentesco_ref_flia_clie2", CobParentesco_Ref_Flia_Clie2.Text)
            cmd.Parameters.Add("_Fld_Ced_Ref_Flia_Clie2", Fld_Ced_Ref_Flia_Clie2.Text)
            cmd.Parameters.Add("_Fld_Tel_Ref_Flia_Clie2", Fld_Tel_Ref_Flia_Clie2.Text)
            cmd.Parameters.Add("_Fld_Cel_Ref_Flia_Clie2", Fld_Cel_Ref_Flia_Clie2.Text)
            cmd.Parameters.Add("_fld_whats_ref_flia_clie2", Fld_Whatsapp_Ref_Flia_Clie2.Text)

            cmd.Parameters.Add("_fld_sector_id", CobSector.SelectedValue)
            cmd.Parameters.Add("_fld_sector", CobSector.Text)
            cmd.Parameters.Add("_fld_provincia_id", CobProvincia.SelectedValue)
            cmd.Parameters.Add("_fld_provincia", CobProvincia.Text)

            cmd.ExecuteNonQuery()
            modificarDatos = True
            'If cmd.ExecuteNonQuery() = True Then
            '    MessageBox.Show("Los Datos del Socio se Han Actualiado Correctamente", "Actualizando....", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            '    MessageBox.Show("Los Datos del Socio No se Han Actualiado Correctamente", "Actualizando....", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If

        Catch ex As Exception
            Alerta(ex.Message)
            modificarDatos = False
            conn.Close()
        Finally

            conn.Close()

        End Try
    End Sub

    Private Function ValidaFields() As Boolean
        If fld_FullName.Text = "" Then
            Alerta("Falta el NOMBRE del Socio")
            fld_FullName.Focus()
            Return False
            Exit Function
        ElseIf fld_Identity.Text = "" Then
            Alerta("Falta la Cédula del Socio")
            fld_Identity.Focus()
            Return False
            Exit Function
        ElseIf Trim(lblCuentaContable.Text) = String.Empty Then
            Alerta("Falta la cuenta contable del Socio")
            txtCuentaContable.Focus()
            Return False
            Exit Function
        ElseIf emailTxt.Text = "" Then
            Alerta("Falta el Correo del Socio")
            emailTxt.Focus()
            Return False
            Exit Function

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

        Dim sqlstring As String = "SELECT * FROM tbl_clientes"
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

    Private Sub BtnProvincia_Click(sender As Object, e As EventArgs) Handles BtnProvincia.Click
        Dim f As New FRM_PROVINCIAS
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub BtnSector_Click(sender As Object, e As EventArgs) Handles BtnSector.Click
        Dim f As New FRM_URBANIZACIONES
        f.MdiParent = FRM_DEFAULT.GlobalForm
        f.Show()
    End Sub

    Private Sub DtpEdad_gar_LostFocus(sender As Object, e As EventArgs) Handles DtpEdad_gar.LostFocus
        fld_edad_gar.Text = edadExacta(DtpEdad_gar.Value)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Fld_Whatsapp_Ref_Flia_Clie1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles Fld_Whatsapp_Ref_Flia_Clie1.MaskInputRejected

    End Sub

    Private Sub fld_ocupacion_cliente1_TextChanged(sender As Object, e As EventArgs) Handles fld_ocupacion_cliente1.TextChanged

    End Sub

    Private Sub fld_nombre_banco2_TextChanged(sender As Object, e As EventArgs) Handles fld_nombre_banco2.TextChanged

    End Sub


End Class
