Imports MySql.Data.MySqlClient
Public Class frmInterfasRecibosIngresos
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
    Friend WithEvents lblDebitoIngreso As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_cta_db_ingresos As System.Windows.Forms.TextBox
    Friend WithEvents lblOtros As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_cta_ing_otros As System.Windows.Forms.TextBox
    Friend WithEvents lblMora As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_cta_ing_mora As System.Windows.Forms.TextBox
    Friend WithEvents lblInteres As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_cta_ing_interes As System.Windows.Forms.TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btn_procesar As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents lblCierre As System.Windows.Forms.Label
    Friend WithEvents lblUtilidades As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txt_cta_utilidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_cta_cierre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents ctaCertificadosLbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblctaCertificados As Label
    Friend WithEvents LblCta_aportaciones As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents FldCtas_Certificados As TextBox
    Friend WithEvents lblctadepositos As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblctaPrestamos As Label
    Friend WithEvents lblctasCxC As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents FldCtas_CxC As TextBox
    Friend WithEvents lblctasretiros As Label
    Friend WithEvents FldCtas_Prestamos As TextBox
    Friend WithEvents FldCta_Aportaciones As TextBox
    Friend WithEvents FldCtas_Depositos As TextBox
    Friend WithEvents FldCta_Retiros As TextBox
    Friend WithEvents BtnCtasCertificados As Button
    Friend WithEvents BtnCtasPrestamos As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnBuscarCtasRetiros As Button
    Friend WithEvents BtnBuscarCtas_Depositos As Button
    Friend WithEvents buscaCtaContableBtn As Button
    Friend WithEvents ctaRetIntCertificadosLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRetiroInteresesCert As TextBox
    Friend WithEvents ctaIntCertificadosLbl As Label
    Friend WithEvents lblCtaIntCertificados As Label
    Friend WithEvents txtInteresCertificados As TextBox
    Friend WithEvents ctaCertificadosTxt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInterfasRecibosIngresos))
        Me.lblDebitoIngreso = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_cta_db_ingresos = New System.Windows.Forms.TextBox()
        Me.lblOtros = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_cta_ing_otros = New System.Windows.Forms.TextBox()
        Me.lblMora = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cta_ing_mora = New System.Windows.Forms.TextBox()
        Me.lblInteres = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cta_ing_interes = New System.Windows.Forms.TextBox()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btn_procesar = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.lblCierre = New System.Windows.Forms.Label()
        Me.lblUtilidades = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txt_cta_utilidad = New System.Windows.Forms.TextBox()
        Me.txt_cta_cierre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.ctaCertificadosLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ctaCertificadosTxt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ctaRetIntCertificadosLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRetiroInteresesCert = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCtasCertificados = New System.Windows.Forms.Button()
        Me.BtnCtasPrestamos = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnBuscarCtasRetiros = New System.Windows.Forms.Button()
        Me.BtnBuscarCtas_Depositos = New System.Windows.Forms.Button()
        Me.buscaCtaContableBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblctaCertificados = New System.Windows.Forms.Label()
        Me.LblCta_aportaciones = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FldCtas_Certificados = New System.Windows.Forms.TextBox()
        Me.lblctadepositos = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblctaPrestamos = New System.Windows.Forms.Label()
        Me.lblctasCxC = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FldCtas_CxC = New System.Windows.Forms.TextBox()
        Me.lblctasretiros = New System.Windows.Forms.Label()
        Me.FldCtas_Prestamos = New System.Windows.Forms.TextBox()
        Me.FldCta_Aportaciones = New System.Windows.Forms.TextBox()
        Me.FldCtas_Depositos = New System.Windows.Forms.TextBox()
        Me.FldCta_Retiros = New System.Windows.Forms.TextBox()
        Me.ctaIntCertificadosLbl = New System.Windows.Forms.Label()
        Me.lblCtaIntCertificados = New System.Windows.Forms.Label()
        Me.txtInteresCertificados = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDebitoIngreso
        '
        Me.lblDebitoIngreso.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblDebitoIngreso.ForeColor = System.Drawing.Color.Red
        Me.lblDebitoIngreso.Location = New System.Drawing.Point(320, 311)
        Me.lblDebitoIngreso.Name = "lblDebitoIngreso"
        Me.lblDebitoIngreso.Size = New System.Drawing.Size(248, 20)
        Me.lblDebitoIngreso.TabIndex = 14
        Me.lblDebitoIngreso.Text = "Label21"
        Me.lblDebitoIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDebitoIngreso.Visible = False
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(216, 295)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(216, 16)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Cta. Débito de Recibos de Ingresos"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label17.Visible = False
        '
        'txt_cta_db_ingresos
        '
        Me.txt_cta_db_ingresos.Location = New System.Drawing.Point(216, 311)
        Me.txt_cta_db_ingresos.Name = "txt_cta_db_ingresos"
        Me.txt_cta_db_ingresos.Size = New System.Drawing.Size(100, 20)
        Me.txt_cta_db_ingresos.TabIndex = 13
        Me.txt_cta_db_ingresos.Text = "0"
        Me.txt_cta_db_ingresos.Visible = False
        '
        'lblOtros
        '
        Me.lblOtros.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblOtros.ForeColor = System.Drawing.Color.Red
        Me.lblOtros.Location = New System.Drawing.Point(116, 103)
        Me.lblOtros.Name = "lblOtros"
        Me.lblOtros.Size = New System.Drawing.Size(248, 20)
        Me.lblOtros.TabIndex = 11
        Me.lblOtros.Text = "Label21"
        Me.lblOtros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(12, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Cta. para Otros Ingresos RI"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_cta_ing_otros
        '
        Me.txt_cta_ing_otros.Location = New System.Drawing.Point(12, 103)
        Me.txt_cta_ing_otros.Name = "txt_cta_ing_otros"
        Me.txt_cta_ing_otros.Size = New System.Drawing.Size(100, 20)
        Me.txt_cta_ing_otros.TabIndex = 10
        '
        'lblMora
        '
        Me.lblMora.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblMora.ForeColor = System.Drawing.Color.Red
        Me.lblMora.Location = New System.Drawing.Point(116, 63)
        Me.lblMora.Name = "lblMora"
        Me.lblMora.Size = New System.Drawing.Size(248, 20)
        Me.lblMora.TabIndex = 8
        Me.lblMora.Text = "Label21"
        Me.lblMora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(12, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Cta. para Mora RI"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_cta_ing_mora
        '
        Me.txt_cta_ing_mora.Location = New System.Drawing.Point(12, 63)
        Me.txt_cta_ing_mora.Name = "txt_cta_ing_mora"
        Me.txt_cta_ing_mora.Size = New System.Drawing.Size(100, 20)
        Me.txt_cta_ing_mora.TabIndex = 7
        '
        'lblInteres
        '
        Me.lblInteres.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblInteres.ForeColor = System.Drawing.Color.Red
        Me.lblInteres.Location = New System.Drawing.Point(116, 23)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(248, 20)
        Me.lblInteres.TabIndex = 5
        Me.lblInteres.Text = "Label21"
        Me.lblInteres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Cta. para Interes RI"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_cta_ing_interes
        '
        Me.txt_cta_ing_interes.Location = New System.Drawing.Point(12, 23)
        Me.txt_cta_ing_interes.Name = "txt_cta_ing_interes"
        Me.txt_cta_ing_interes.Size = New System.Drawing.Size(100, 20)
        Me.txt_cta_ing_interes.TabIndex = 4
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(216, 351)
        Me.txtConcepto.MaxLength = 145
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(312, 20)
        Me.txtConcepto.TabIndex = 16
        Me.txtConcepto.Text = "0"
        Me.txtConcepto.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(216, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Concepto :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(763, 239)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 26
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btn_procesar
        '
        Me.btn_procesar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_procesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_procesar.Image = CType(resources.GetObject("btn_procesar.Image"), System.Drawing.Image)
        Me.btn_procesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_procesar.Location = New System.Drawing.Point(685, 239)
        Me.btn_procesar.Name = "btn_procesar"
        Me.btn_procesar.Size = New System.Drawing.Size(72, 56)
        Me.btn_procesar.TabIndex = 25
        Me.btn_procesar.Text = "&Guardar"
        Me.btn_procesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_procesar.UseVisualStyleBackColor = False
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(403, 7)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(100, 16)
        Me.Label46.TabIndex = 19
        Me.Label46.Text = "Cta. Utilidades"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCierre
        '
        Me.lblCierre.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblCierre.ForeColor = System.Drawing.Color.Red
        Me.lblCierre.Location = New System.Drawing.Point(507, 63)
        Me.lblCierre.Name = "lblCierre"
        Me.lblCierre.Size = New System.Drawing.Size(272, 20)
        Me.lblCierre.TabIndex = 24
        Me.lblCierre.Text = "Label21"
        Me.lblCierre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUtilidades
        '
        Me.lblUtilidades.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblUtilidades.ForeColor = System.Drawing.Color.Red
        Me.lblUtilidades.Location = New System.Drawing.Point(507, 23)
        Me.lblUtilidades.Name = "lblUtilidades"
        Me.lblUtilidades.Size = New System.Drawing.Size(272, 20)
        Me.lblUtilidades.TabIndex = 21
        Me.lblUtilidades.Text = "Label21"
        Me.lblUtilidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(403, 47)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(256, 16)
        Me.Label51.TabIndex = 22
        Me.Label51.Text = "Cta. del Grupo Capital para el cierre del período"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_cta_utilidad
        '
        Me.txt_cta_utilidad.Location = New System.Drawing.Point(403, 23)
        Me.txt_cta_utilidad.Name = "txt_cta_utilidad"
        Me.txt_cta_utilidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cta_utilidad.TabIndex = 20
        '
        'txt_cta_cierre
        '
        Me.txt_cta_cierre.Location = New System.Drawing.Point(403, 63)
        Me.txt_cta_cierre.Name = "txt_cta_cierre"
        Me.txt_cta_cierre.Size = New System.Drawing.Size(100, 20)
        Me.txt_cta_cierre.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Tipo :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.Location = New System.Drawing.Point(12, 143)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(168, 21)
        Me.cmbTipo.TabIndex = 18
        '
        'ctaCertificadosLbl
        '
        Me.ctaCertificadosLbl.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.ctaCertificadosLbl.ForeColor = System.Drawing.Color.Red
        Me.ctaCertificadosLbl.Location = New System.Drawing.Point(507, 103)
        Me.ctaCertificadosLbl.Name = "ctaCertificadosLbl"
        Me.ctaCertificadosLbl.Size = New System.Drawing.Size(272, 20)
        Me.ctaCertificadosLbl.TabIndex = 29
        Me.ctaCertificadosLbl.Text = "Label21"
        Me.ctaCertificadosLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(403, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Cta. para Certificados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ctaCertificadosTxt
        '
        Me.ctaCertificadosTxt.Location = New System.Drawing.Point(403, 103)
        Me.ctaCertificadosTxt.Name = "ctaCertificadosTxt"
        Me.ctaCertificadosTxt.Size = New System.Drawing.Size(100, 20)
        Me.ctaCertificadosTxt.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ctaIntCertificadosLbl)
        Me.Panel1.Controls.Add(Me.lblCtaIntCertificados)
        Me.Panel1.Controls.Add(Me.txtInteresCertificados)
        Me.Panel1.Controls.Add(Me.ctaRetIntCertificadosLbl)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtRetiroInteresesCert)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ctaCertificadosLbl)
        Me.Panel1.Controls.Add(Me.lblInteres)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.ctaCertificadosTxt)
        Me.Panel1.Controls.Add(Me.lblMora)
        Me.Panel1.Controls.Add(Me.Label46)
        Me.Panel1.Controls.Add(Me.lblCierre)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblUtilidades)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label51)
        Me.Panel1.Controls.Add(Me.cmbTipo)
        Me.Panel1.Controls.Add(Me.txt_cta_utilidad)
        Me.Panel1.Controls.Add(Me.lblOtros)
        Me.Panel1.Controls.Add(Me.txt_cta_cierre)
        Me.Panel1.Controls.Add(Me.txt_cta_ing_interes)
        Me.Panel1.Controls.Add(Me.txt_cta_ing_mora)
        Me.Panel1.Controls.Add(Me.txt_cta_ing_otros)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 205)
        Me.Panel1.TabIndex = 30
        '
        'ctaRetIntCertificadosLbl
        '
        Me.ctaRetIntCertificadosLbl.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.ctaRetIntCertificadosLbl.ForeColor = System.Drawing.Color.Red
        Me.ctaRetIntCertificadosLbl.Location = New System.Drawing.Point(507, 143)
        Me.ctaRetIntCertificadosLbl.Name = "ctaRetIntCertificadosLbl"
        Me.ctaRetIntCertificadosLbl.Size = New System.Drawing.Size(272, 20)
        Me.ctaRetIntCertificadosLbl.TabIndex = 32
        Me.ctaRetIntCertificadosLbl.Text = "Label21"
        Me.ctaRetIntCertificadosLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(403, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Cta. Interes Pagado Certificados"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRetiroInteresesCert
        '
        Me.txtRetiroInteresesCert.Location = New System.Drawing.Point(403, 143)
        Me.txtRetiroInteresesCert.Name = "txtRetiroInteresesCert"
        Me.txtRetiroInteresesCert.Size = New System.Drawing.Size(100, 20)
        Me.txtRetiroInteresesCert.TabIndex = 31
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(841, 237)
        Me.TabControl1.TabIndex = 31
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(833, 211)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ctas Recibos de Ingresos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(833, 192)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ctas Socios"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnCtasCertificados)
        Me.Panel2.Controls.Add(Me.BtnCtasPrestamos)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.BtnBuscarCtasRetiros)
        Me.Panel2.Controls.Add(Me.BtnBuscarCtas_Depositos)
        Me.Panel2.Controls.Add(Me.buscaCtaContableBtn)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblctaCertificados)
        Me.Panel2.Controls.Add(Me.LblCta_aportaciones)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.FldCtas_Certificados)
        Me.Panel2.Controls.Add(Me.lblctadepositos)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.lblctaPrestamos)
        Me.Panel2.Controls.Add(Me.lblctasCxC)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.FldCtas_CxC)
        Me.Panel2.Controls.Add(Me.lblctasretiros)
        Me.Panel2.Controls.Add(Me.FldCtas_Prestamos)
        Me.Panel2.Controls.Add(Me.FldCta_Aportaciones)
        Me.Panel2.Controls.Add(Me.FldCtas_Depositos)
        Me.Panel2.Controls.Add(Me.FldCta_Retiros)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(827, 183)
        Me.Panel2.TabIndex = 0
        '
        'BtnCtasCertificados
        '
        Me.BtnCtasCertificados.Image = CType(resources.GetObject("BtnCtasCertificados.Image"), System.Drawing.Image)
        Me.BtnCtasCertificados.Location = New System.Drawing.Point(396, 131)
        Me.BtnCtasCertificados.Name = "BtnCtasCertificados"
        Me.BtnCtasCertificados.Size = New System.Drawing.Size(32, 20)
        Me.BtnCtasCertificados.TabIndex = 53
        Me.BtnCtasCertificados.Visible = False
        '
        'BtnCtasPrestamos
        '
        Me.BtnCtasPrestamos.Image = CType(resources.GetObject("BtnCtasPrestamos.Image"), System.Drawing.Image)
        Me.BtnCtasPrestamos.Location = New System.Drawing.Point(396, 90)
        Me.BtnCtasPrestamos.Name = "BtnCtasPrestamos"
        Me.BtnCtasPrestamos.Size = New System.Drawing.Size(32, 21)
        Me.BtnCtasPrestamos.TabIndex = 52
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(396, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 21)
        Me.Button3.TabIndex = 51
        '
        'BtnBuscarCtasRetiros
        '
        Me.BtnBuscarCtasRetiros.Image = CType(resources.GetObject("BtnBuscarCtasRetiros.Image"), System.Drawing.Image)
        Me.BtnBuscarCtasRetiros.Location = New System.Drawing.Point(6, 129)
        Me.BtnBuscarCtasRetiros.Name = "BtnBuscarCtasRetiros"
        Me.BtnBuscarCtasRetiros.Size = New System.Drawing.Size(32, 22)
        Me.BtnBuscarCtasRetiros.TabIndex = 50
        Me.BtnBuscarCtasRetiros.Visible = False
        '
        'BtnBuscarCtas_Depositos
        '
        Me.BtnBuscarCtas_Depositos.Image = CType(resources.GetObject("BtnBuscarCtas_Depositos.Image"), System.Drawing.Image)
        Me.BtnBuscarCtas_Depositos.Location = New System.Drawing.Point(6, 91)
        Me.BtnBuscarCtas_Depositos.Name = "BtnBuscarCtas_Depositos"
        Me.BtnBuscarCtas_Depositos.Size = New System.Drawing.Size(32, 20)
        Me.BtnBuscarCtas_Depositos.TabIndex = 49
        '
        'buscaCtaContableBtn
        '
        Me.buscaCtaContableBtn.Image = CType(resources.GetObject("buscaCtaContableBtn.Image"), System.Drawing.Image)
        Me.buscaCtaContableBtn.Location = New System.Drawing.Point(6, 51)
        Me.buscaCtaContableBtn.Name = "buscaCtaContableBtn"
        Me.buscaCtaContableBtn.Size = New System.Drawing.Size(32, 20)
        Me.buscaCtaContableBtn.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Cta. de Aportaciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblctaCertificados
        '
        Me.lblctaCertificados.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblctaCertificados.ForeColor = System.Drawing.Color.Red
        Me.lblctaCertificados.Location = New System.Drawing.Point(533, 131)
        Me.lblctaCertificados.Name = "lblctaCertificados"
        Me.lblctaCertificados.Size = New System.Drawing.Size(272, 20)
        Me.lblctaCertificados.TabIndex = 47
        Me.lblctaCertificados.Text = "Label21"
        Me.lblctaCertificados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblctaCertificados.Visible = False
        '
        'LblCta_aportaciones
        '
        Me.LblCta_aportaciones.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.LblCta_aportaciones.ForeColor = System.Drawing.Color.Red
        Me.LblCta_aportaciones.Location = New System.Drawing.Point(143, 51)
        Me.LblCta_aportaciones.Name = "LblCta_aportaciones"
        Me.LblCta_aportaciones.Size = New System.Drawing.Size(248, 20)
        Me.LblCta_aportaciones.TabIndex = 32
        Me.LblCta_aportaciones.Text = "Label21"
        Me.LblCta_aportaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(426, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Cta. para Certificados"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Cta. Depositos"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FldCtas_Certificados
        '
        Me.FldCtas_Certificados.Location = New System.Drawing.Point(429, 131)
        Me.FldCtas_Certificados.Name = "FldCtas_Certificados"
        Me.FldCtas_Certificados.Size = New System.Drawing.Size(100, 20)
        Me.FldCtas_Certificados.TabIndex = 46
        Me.FldCtas_Certificados.Visible = False
        '
        'lblctadepositos
        '
        Me.lblctadepositos.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblctadepositos.ForeColor = System.Drawing.Color.Red
        Me.lblctadepositos.Location = New System.Drawing.Point(143, 91)
        Me.lblctadepositos.Name = "lblctadepositos"
        Me.lblctadepositos.Size = New System.Drawing.Size(248, 20)
        Me.lblctadepositos.TabIndex = 35
        Me.lblctadepositos.Text = "Label21"
        Me.lblctadepositos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(429, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Cta. CXC"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblctaPrestamos
        '
        Me.lblctaPrestamos.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblctaPrestamos.ForeColor = System.Drawing.Color.Red
        Me.lblctaPrestamos.Location = New System.Drawing.Point(533, 91)
        Me.lblctaPrestamos.Name = "lblctaPrestamos"
        Me.lblctaPrestamos.Size = New System.Drawing.Size(272, 20)
        Me.lblctaPrestamos.TabIndex = 44
        Me.lblctaPrestamos.Text = "Label21"
        Me.lblctaPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblctasCxC
        '
        Me.lblctasCxC.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblctasCxC.ForeColor = System.Drawing.Color.Red
        Me.lblctasCxC.Location = New System.Drawing.Point(533, 51)
        Me.lblctasCxC.Name = "lblctasCxC"
        Me.lblctasCxC.Size = New System.Drawing.Size(272, 20)
        Me.lblctasCxC.TabIndex = 41
        Me.lblctasCxC.Text = "Label21"
        Me.lblctasCxC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(39, 115)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Cta. Retiros"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(429, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Prestamos"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FldCtas_CxC
        '
        Me.FldCtas_CxC.Location = New System.Drawing.Point(429, 51)
        Me.FldCtas_CxC.Name = "FldCtas_CxC"
        Me.FldCtas_CxC.Size = New System.Drawing.Size(100, 20)
        Me.FldCtas_CxC.TabIndex = 40
        '
        'lblctasretiros
        '
        Me.lblctasretiros.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblctasretiros.ForeColor = System.Drawing.Color.Red
        Me.lblctasretiros.Location = New System.Drawing.Point(143, 131)
        Me.lblctasretiros.Name = "lblctasretiros"
        Me.lblctasretiros.Size = New System.Drawing.Size(248, 20)
        Me.lblctasretiros.TabIndex = 38
        Me.lblctasretiros.Text = "Label21"
        Me.lblctasretiros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FldCtas_Prestamos
        '
        Me.FldCtas_Prestamos.Location = New System.Drawing.Point(429, 91)
        Me.FldCtas_Prestamos.Name = "FldCtas_Prestamos"
        Me.FldCtas_Prestamos.Size = New System.Drawing.Size(100, 20)
        Me.FldCtas_Prestamos.TabIndex = 43
        '
        'FldCta_Aportaciones
        '
        Me.FldCta_Aportaciones.Location = New System.Drawing.Point(39, 51)
        Me.FldCta_Aportaciones.Name = "FldCta_Aportaciones"
        Me.FldCta_Aportaciones.Size = New System.Drawing.Size(100, 20)
        Me.FldCta_Aportaciones.TabIndex = 31
        '
        'FldCtas_Depositos
        '
        Me.FldCtas_Depositos.Location = New System.Drawing.Point(39, 91)
        Me.FldCtas_Depositos.Name = "FldCtas_Depositos"
        Me.FldCtas_Depositos.Size = New System.Drawing.Size(100, 20)
        Me.FldCtas_Depositos.TabIndex = 34
        '
        'FldCta_Retiros
        '
        Me.FldCta_Retiros.Location = New System.Drawing.Point(39, 131)
        Me.FldCta_Retiros.Name = "FldCta_Retiros"
        Me.FldCta_Retiros.Size = New System.Drawing.Size(100, 20)
        Me.FldCta_Retiros.TabIndex = 37
        '
        'ctaIntCertificadosLbl
        '
        Me.ctaIntCertificadosLbl.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.ctaIntCertificadosLbl.ForeColor = System.Drawing.Color.Red
        Me.ctaIntCertificadosLbl.Location = New System.Drawing.Point(507, 182)
        Me.ctaIntCertificadosLbl.Name = "ctaIntCertificadosLbl"
        Me.ctaIntCertificadosLbl.Size = New System.Drawing.Size(272, 20)
        Me.ctaIntCertificadosLbl.TabIndex = 35
        Me.ctaIntCertificadosLbl.Text = "Label21"
        Me.ctaIntCertificadosLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCtaIntCertificados
        '
        Me.lblCtaIntCertificados.Location = New System.Drawing.Point(403, 166)
        Me.lblCtaIntCertificados.Name = "lblCtaIntCertificados"
        Me.lblCtaIntCertificados.Size = New System.Drawing.Size(256, 16)
        Me.lblCtaIntCertificados.TabIndex = 33
        Me.lblCtaIntCertificados.Text = "Cta.Interes Generado Certificados"
        Me.lblCtaIntCertificados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInteresCertificados
        '
        Me.txtInteresCertificados.Location = New System.Drawing.Point(403, 182)
        Me.txtInteresCertificados.Name = "txtInteresCertificados"
        Me.txtInteresCertificados.Size = New System.Drawing.Size(100, 20)
        Me.txtInteresCertificados.TabIndex = 34
        '
        'frmInterfasRecibosIngresos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(841, 299)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btn_procesar)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txt_cta_db_ingresos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDebitoIngreso)
        Me.Controls.Add(Me.Label17)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInterfasRecibosIngresos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interfas Contable"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmInterfasRecibosIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        If SCALAR_NUM("SELECT IFNULL(1,0) FROM tbl_interfascontableingresos") = 1 Then btn_procesar.Text = "&Modificar"
        LlenarTipo()
        Buscar()
    End Sub

    Private Sub LlenarTipo()
        Dim da As New MySqlDataAdapter("SELECT fld_id, fld_descripcion FROM tbl_interfascontableotrastipo ORDER BY fld_descripcion", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbTipo.DataSource = dt
        cmbTipo.DisplayMember = "fld_descripcion"
        cmbTipo.ValueMember = "fld_id"
    End Sub

    Private Sub Guardar()
        NON_QUERY("INSERT INTO tbl_interfascontableingresos (Debito, Capital, Interes, Mora, Otros, Cliente, Proveedor, IdTipo, DescripcionTipo) VALUES('" & txt_cta_db_ingresos.Text & "','', '" & txt_cta_ing_interes.Text & "','" & txt_cta_ing_mora.Text & "','" & txt_cta_ing_otros.Text & "','',''," & cmbTipo.SelectedValue & ",'" & txtConcepto.Text & "'); INSERT INTO tbl_interfascontableotras(Utilidad,Cierre,Certificados,CertificadoInteres,CertificadoInteresGenerado) VALUES('" & txt_cta_utilidad.Text & "','" & txt_cta_cierre.Text & "','" & ctaCertificadosTxt.Text & "','" & txtRetiroInteresesCert.Text & "','" & txtInteresCertificados.Text & "')")
    End Sub

    Private Sub Modificar()
        NON_QUERY("UPDATE tbl_interfascontableingresos SET Debito='" & txt_cta_db_ingresos.Text & "', Capital='', Interes='" & txt_cta_ing_interes.Text & "', Mora='" & txt_cta_ing_mora.Text & "', Otros='" & txt_cta_ing_otros.Text & "', IdTipo=" & cmbTipo.SelectedValue & ", DescripcionTipo='" & txtConcepto.Text & "' WHERE ID=1; UPDATE tbl_interfascontableotras SET Utilidad='" & txt_cta_utilidad.Text & "',Cierre='" & txt_cta_cierre.Text & "',Certificados='" & ctaCertificadosTxt.Text & "',CertificadoInteres='" & txtRetiroInteresesCert.Text & "', CertificadoInteresGenerado='" & txtInteresCertificados.Text & "'  WHERE ID=1")
    End Sub

    Private Sub Buscar()

        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT Debito, Interes, Mora, Otros, Cliente, Proveedor,  IdTIpo, DescripcionTipo FROM tbl_interfascontableingresos WHERE ID=1", conn)
        da.Fill(ds, "tbl_interfascontableingresos")
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            txt_cta_db_ingresos.Text = dr("Debito")

            txt_cta_ing_interes.Text = dr("Interes")
            txt_cta_ing_mora.Text = dr("Mora")
            txt_cta_ing_otros.Text = dr("Otros")

            cmbTipo.SelectedValue = dr("IdTIpo")
            txtConcepto.Text = dr("DescripcionTipo")
        Next
        da.Dispose()
        ds.Dispose()
        lblDebitoIngreso.Text = ReturnDescripcion(txt_cta_db_ingresos.Text)

        lblInteres.Text = ReturnDescripcion(txt_cta_ing_interes.Text)
        lblMora.Text = ReturnDescripcion(txt_cta_ing_mora.Text)
        lblOtros.Text = ReturnDescripcion(txt_cta_ing_otros.Text)


        Dim ds1 As New DataSet
        Dim da1 As New MySqlDataAdapter("SELECT Utilidad, Cierre, Certificados,CertificadoInteres,CertificadoInteresGenerado FROM tbl_interfascontableotras WHERE ID=1", conn)
        da1.Fill(ds1, "tbl_interfascontableotras")

        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            txt_cta_utilidad.Text = dr1("Utilidad")
            txt_cta_cierre.Text = dr1("Cierre")
            ctaCertificadosTxt.Text = dr1("Certificados")
            txtRetiroInteresesCert.Text = dr1("CertificadoInteres")
            txtInteresCertificados.Text = dr1("CertificadoInteresGenerado")

        Next
        da1.Dispose()
        ds1.Dispose()
        lblUtilidades.Text = ReturnDescripcion(txt_cta_utilidad.Text)
        lblCierre.Text = ReturnDescripcion(txt_cta_cierre.Text)
        ctaCertificadosLbl.Text = ReturnDescripcion(ctaCertificadosTxt.Text)
        ctaRetIntCertificadosLbl.Text = ReturnDescripcion(txtRetiroInteresesCert.Text)
        ctaIntCertificadosLbl.Text = ReturnDescripcion(txtInteresCertificados.Text)


    End Sub

    Private Sub txt_cta_ing_interes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta_ing_interes.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txt_cta_ing_interes.Text = Id
                lblInteres.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub txt_cta_ing_mora_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta_ing_mora.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txt_cta_ing_mora.Text = Id
                lblMora.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub txt_cta_ing_otros_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta_ing_otros.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txt_cta_ing_otros.Text = Id
                lblOtros.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub txt_cta_db_ingresos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta_db_ingresos.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txt_cta_db_ingresos.Text = Id
                lblDebitoIngreso.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub btn_procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_procesar.Click
        If btn_procesar.Text = "&Modificar" Then
            Modificar()
        Else
            Guardar()
        End If
        Alerta("Documento guardado")
        Me.Close()
    End Sub

    Private Sub fld_cta_utilidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta_utilidad.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txt_cta_utilidad.Text = Id
                lblUtilidades.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub fld_cta_cierre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cta_cierre.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txt_cta_cierre.Text = Id
                lblCierre.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub



    Private Sub ctaCertificadosTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ctaCertificadosTxt.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                ctaCertificadosTxt.Text = Id
                ctaCertificadosLbl.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub buscaCtaContableBtn_Click(sender As Object, e As EventArgs) Handles buscaCtaContableBtn.Click
        If frmsListaCatalogoCuentaContable() = True Then
            FldCta_Aportaciones.Text = Id
            LblCta_aportaciones.Text = ReturnDescripcion(Id)
        End If
    End Sub

    Private Sub BtnBuscarCtas_Depositos_Click(sender As Object, e As EventArgs) Handles BtnBuscarCtas_Depositos.Click
        If frmsListaCatalogoCuentaContable() = True Then
            FldCtas_Depositos.Text = Id
            lblctadepositos.Text = ReturnDescripcion(Id)
        End If
    End Sub

    Private Sub BtnBuscarCtasRetiros_Click(sender As Object, e As EventArgs) Handles BtnBuscarCtasRetiros.Click
        If frmsListaCatalogoCuentaContable() = True Then
            FldCta_Retiros.Text = Id
            lblctasretiros.Text = ReturnDescripcion(Id)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If frmsListaCatalogoCuentaContable() = True Then
            FldCtas_CxC.Text = Id
            lblctasCxC.Text = ReturnDescripcion(Id)
        End If
    End Sub

    Private Sub BtnCtasPrestamos_Click(sender As Object, e As EventArgs) Handles BtnCtasPrestamos.Click
        If frmsListaCatalogoCuentaContable() = True Then
            FldCtas_Prestamos.Text = Id
            lblctaPrestamos.Text = ReturnDescripcion(Id)
        End If
    End Sub

    Private Sub BtnCtasCertificados_Click(sender As Object, e As EventArgs) Handles BtnCtasCertificados.Click
        If frmsListaCatalogoCuentaContable() = True Then
            FldCtas_Certificados.Text = Id
            lblctaCertificados.Text = ReturnDescripcion(Id)
        End If
    End Sub

    Private Sub txtRetiroInteresesCert_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRetiroInteresesCert.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txtRetiroInteresesCert.Text = Id
                ctaRetIntCertificadosLbl.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

    Private Sub txtInteresCertificados_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInteresCertificados.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txtInteresCertificados.Text = Id
                ctaIntCertificadosLbl.Text = ReturnDescripcion(Id)
            End If
        End If
    End Sub

End Class
