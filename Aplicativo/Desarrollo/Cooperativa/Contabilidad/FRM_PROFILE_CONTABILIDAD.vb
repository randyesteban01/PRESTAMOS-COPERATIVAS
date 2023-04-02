Imports MySql.Data.MySqlClient
Public Class FRM_PROFILE_CONTABILIDAD
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents fld_fecha_inicia_pc As System.Windows.Forms.DateTimePicker
    Friend WithEvents fld_fecha_termina_pc As System.Windows.Forms.DateTimePicker
    Friend WithEvents LV_PERIODO As System.Windows.Forms.ListView
    Friend WithEvents LV_PERIODO_MESES As System.Windows.Forms.ListView
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenu2 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents fld_niveles As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents cmbModulo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFrms As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDR As System.Windows.Forms.TextBox
    Friend WithEvents txtCR As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblDr As System.Windows.Forms.Label
    Friend WithEvents lblCr As System.Windows.Forms.Label
    Friend WithEvents btnGuardarInterfas As System.Windows.Forms.Button
    Friend WithEvents txtIDInterfas As System.Windows.Forms.TextBox
    Friend WithEvents lvInterfasCta As System.Windows.Forms.ListView
    Friend WithEvents btnConfEstadoResultado As System.Windows.Forms.Button
    Friend WithEvents btnConfBceGeneral As System.Windows.Forms.Button
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnOtraInterfas As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_PROFILE_CONTABILIDAD))
        Me.LV_PERIODO = New System.Windows.Forms.ListView
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.LV_PERIODO_MESES = New System.Windows.Forms.ListView
        Me.ContextMenu2 = New System.Windows.Forms.ContextMenu
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.fld_fecha_termina_pc = New System.Windows.Forms.DateTimePicker
        Me.fld_fecha_inicia_pc = New System.Windows.Forms.DateTimePicker
        Me.btnConfEstadoResultado = New System.Windows.Forms.Button
        Me.btnConfBceGeneral = New System.Windows.Forms.Button
        Me.Label52 = New System.Windows.Forms.Label
        Me.fld_niveles = New System.Windows.Forms.NumericUpDown
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.cmbModulo = New System.Windows.Forms.ComboBox
        Me.cmbFrms = New System.Windows.Forms.ComboBox
        Me.lvInterfasCta = New System.Windows.Forms.ListView
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDR = New System.Windows.Forms.TextBox
        Me.txtCR = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnGuardarInterfas = New System.Windows.Forms.Button
        Me.lblDr = New System.Windows.Forms.Label
        Me.lblCr = New System.Windows.Forms.Label
        Me.txtIDInterfas = New System.Windows.Forms.TextBox
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnOtraInterfas = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.fld_niveles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LV_PERIODO
        '
        Me.LV_PERIODO.ContextMenu = Me.ContextMenu1
        Me.LV_PERIODO.Location = New System.Drawing.Point(14, 60)
        Me.LV_PERIODO.Name = "LV_PERIODO"
        Me.LV_PERIODO.Size = New System.Drawing.Size(360, 64)
        Me.LV_PERIODO.TabIndex = 2
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Activar"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Cerrar Período"
        '
        'LV_PERIODO_MESES
        '
        Me.LV_PERIODO_MESES.ContextMenu = Me.ContextMenu2
        Me.LV_PERIODO_MESES.Location = New System.Drawing.Point(14, 156)
        Me.LV_PERIODO_MESES.Name = "LV_PERIODO_MESES"
        Me.LV_PERIODO_MESES.Size = New System.Drawing.Size(360, 152)
        Me.LV_PERIODO_MESES.TabIndex = 3
        '
        'ContextMenu2
        '
        Me.ContextMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem5, Me.MenuItem6})
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Cerrar Mes"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Text = "ReAbrir Mes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.fld_fecha_termina_pc)
        Me.GroupBox1.Controls.Add(Me.fld_fecha_inicia_pc)
        Me.GroupBox1.Controls.Add(Me.LV_PERIODO)
        Me.GroupBox1.Controls.Add(Me.LV_PERIODO_MESES)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 328)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período Contable"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Location = New System.Drawing.Point(270, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 24)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "C&rear período"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(278, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Meses del Período"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(134, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hasta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Desde"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fld_fecha_termina_pc
        '
        Me.fld_fecha_termina_pc.CustomFormat = "MMM - dd - yyyy"
        Me.fld_fecha_termina_pc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha_termina_pc.Location = New System.Drawing.Point(134, 36)
        Me.fld_fecha_termina_pc.Name = "fld_fecha_termina_pc"
        Me.fld_fecha_termina_pc.Size = New System.Drawing.Size(120, 20)
        Me.fld_fecha_termina_pc.TabIndex = 5
        '
        'fld_fecha_inicia_pc
        '
        Me.fld_fecha_inicia_pc.CustomFormat = "MMM - dd - yyyy"
        Me.fld_fecha_inicia_pc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha_inicia_pc.Location = New System.Drawing.Point(14, 36)
        Me.fld_fecha_inicia_pc.Name = "fld_fecha_inicia_pc"
        Me.fld_fecha_inicia_pc.Size = New System.Drawing.Size(120, 20)
        Me.fld_fecha_inicia_pc.TabIndex = 4
        '
        'btnConfEstadoResultado
        '
        Me.btnConfEstadoResultado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnConfEstadoResultado.Location = New System.Drawing.Point(432, 464)
        Me.btnConfEstadoResultado.Name = "btnConfEstadoResultado"
        Me.btnConfEstadoResultado.Size = New System.Drawing.Size(144, 48)
        Me.btnConfEstadoResultado.TabIndex = 11
        Me.btnConfEstadoResultado.Text = "Estado de Resultado"
        Me.btnConfEstadoResultado.Visible = False
        '
        'btnConfBceGeneral
        '
        Me.btnConfBceGeneral.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnConfBceGeneral.Location = New System.Drawing.Point(528, 464)
        Me.btnConfBceGeneral.Name = "btnConfBceGeneral"
        Me.btnConfBceGeneral.Size = New System.Drawing.Size(104, 48)
        Me.btnConfBceGeneral.TabIndex = 9
        Me.btnConfBceGeneral.Text = "Balance General"
        Me.btnConfBceGeneral.Visible = False
        '
        'Label52
        '
        Me.Label52.Location = New System.Drawing.Point(408, 584)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(256, 24)
        Me.Label52.TabIndex = 20
        Me.Label52.Text = "Indique los niveles de cuenta que usará en el catalogo"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label52.Visible = False
        '
        'fld_niveles
        '
        Me.fld_niveles.Increment = New Decimal(New Integer() {3, 0, 0, 0})
        Me.fld_niveles.Location = New System.Drawing.Point(312, 560)
        Me.fld_niveles.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.fld_niveles.Name = "fld_niveles"
        Me.fld_niveles.Size = New System.Drawing.Size(88, 20)
        Me.fld_niveles.TabIndex = 19
        Me.fld_niveles.Value = New Decimal(New Integer() {3, 0, 0, 0})
        Me.fld_niveles.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(416, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(344, 48)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Configuración de Impresión de cheque"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.Location = New System.Drawing.Point(656, 432)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 144
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmbModulo
        '
        Me.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModulo.Location = New System.Drawing.Point(424, 160)
        Me.cmbModulo.Name = "cmbModulo"
        Me.cmbModulo.Size = New System.Drawing.Size(168, 21)
        Me.cmbModulo.TabIndex = 145
        '
        'cmbFrms
        '
        Me.cmbFrms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrms.Location = New System.Drawing.Point(592, 160)
        Me.cmbFrms.Name = "cmbFrms"
        Me.cmbFrms.Size = New System.Drawing.Size(168, 21)
        Me.cmbFrms.TabIndex = 146
        '
        'lvInterfasCta
        '
        Me.lvInterfasCta.Location = New System.Drawing.Point(424, 232)
        Me.lvInterfasCta.Name = "lvInterfasCta"
        Me.lvInterfasCta.Size = New System.Drawing.Size(336, 96)
        Me.lvInterfasCta.TabIndex = 147
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(424, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Módulo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(592, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 149
        Me.Label5.Text = "Formulario"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDR
        '
        Me.txtDR.Location = New System.Drawing.Point(368, 360)
        Me.txtDR.Name = "txtDR"
        Me.txtDR.Size = New System.Drawing.Size(136, 20)
        Me.txtDR.TabIndex = 159
        Me.txtDR.Text = ""
        Me.txtDR.Visible = False
        '
        'txtCR
        '
        Me.txtCR.Location = New System.Drawing.Point(544, 360)
        Me.txtCR.Name = "txtCR"
        Me.txtCR.Size = New System.Drawing.Size(136, 20)
        Me.txtCR.TabIndex = 160
        Me.txtCR.Text = ""
        Me.txtCR.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(336, 360)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 16)
        Me.Label12.TabIndex = 161
        Me.Label12.Text = "DR"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(512, 360)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 16)
        Me.Label13.TabIndex = 162
        Me.Label13.Text = "CR"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.Visible = False
        '
        'btnGuardarInterfas
        '
        Me.btnGuardarInterfas.Image = CType(resources.GetObject("btnGuardarInterfas.Image"), System.Drawing.Image)
        Me.btnGuardarInterfas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarInterfas.Location = New System.Drawing.Point(672, 184)
        Me.btnGuardarInterfas.Name = "btnGuardarInterfas"
        Me.btnGuardarInterfas.Size = New System.Drawing.Size(88, 40)
        Me.btnGuardarInterfas.TabIndex = 163
        Me.btnGuardarInterfas.Text = "&Agregar"
        Me.btnGuardarInterfas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDr
        '
        Me.lblDr.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblDr.ForeColor = System.Drawing.Color.Red
        Me.lblDr.Location = New System.Drawing.Point(376, 384)
        Me.lblDr.Name = "lblDr"
        Me.lblDr.Size = New System.Drawing.Size(136, 16)
        Me.lblDr.TabIndex = 170
        Me.lblDr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDr.Visible = False
        '
        'lblCr
        '
        Me.lblCr.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.lblCr.ForeColor = System.Drawing.Color.Red
        Me.lblCr.Location = New System.Drawing.Point(512, 384)
        Me.lblCr.Name = "lblCr"
        Me.lblCr.Size = New System.Drawing.Size(176, 16)
        Me.lblCr.TabIndex = 171
        Me.lblCr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCr.Visible = False
        '
        'txtIDInterfas
        '
        Me.txtIDInterfas.Location = New System.Drawing.Point(432, 424)
        Me.txtIDInterfas.Name = "txtIDInterfas"
        Me.txtIDInterfas.Size = New System.Drawing.Size(48, 20)
        Me.txtIDInterfas.TabIndex = 172
        Me.txtIDInterfas.Text = "0"
        Me.txtIDInterfas.Visible = False
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.Location = New System.Drawing.Point(424, 200)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(168, 21)
        Me.cmbTipo.TabIndex = 173
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(424, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 174
        Me.Label7.Text = "Tipo :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(592, 400)
        Me.txtConcepto.MaxLength = 145
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(312, 20)
        Me.txtConcepto.TabIndex = 175
        Me.txtConcepto.Text = ""
        Me.txtConcepto.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(528, 400)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "Concepto :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'btnOtraInterfas
        '
        Me.btnOtraInterfas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOtraInterfas.Location = New System.Drawing.Point(416, 24)
        Me.btnOtraInterfas.Name = "btnOtraInterfas"
        Me.btnOtraInterfas.Size = New System.Drawing.Size(344, 48)
        Me.btnOtraInterfas.TabIndex = 177
        Me.btnOtraInterfas.Text = "Otras Interfas"
        '
        'FRM_PROFILE_CONTABILIDAD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(786, 348)
        Me.Controls.Add(Me.btnOtraInterfas)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.txtIDInterfas)
        Me.Controls.Add(Me.lblCr)
        Me.Controls.Add(Me.lblDr)
        Me.Controls.Add(Me.btnGuardarInterfas)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCR)
        Me.Controls.Add(Me.txtDR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lvInterfasCta)
        Me.Controls.Add(Me.cmbFrms)
        Me.Controls.Add(Me.cmbModulo)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.fld_niveles)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.btnConfEstadoResultado)
        Me.Controls.Add(Me.btnConfBceGeneral)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_PROFILE_CONTABILIDAD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros de Contabilidad"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fld_niveles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

    Dim intUltimoPC As Integer = 0

    Private Sub FRM_PROFILE_CONTABILIDAD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        FillListView()
        CargarInterfasCta()
        LlenarModulos()

        LlenarTipo()
    End Sub

    Private Sub LlenarTipo()
        Dim da As New MySqlDataAdapter("SELECT fld_id, fld_descripcion FROM tbl_interfascontableotrastipo ORDER BY fld_descripcion", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbTipo.DataSource = dt
        cmbTipo.DisplayMember = "fld_descripcion"
        cmbTipo.ValueMember = "fld_id"
    End Sub

    

    Private Function ValidarInterfas(ByVal nombreFrm As String) As Boolean

        'If cmbFrms.Text = "Emision de cheques" And lblCr.Text = String.Empty Then
        '    Alerta("Para la Emision de cheques, debe espicificar una cuenta crédito, el débito no es necesario.")
        '    Return False
        'End If

        'If cmbFrms.Text <> "Emision de cheques" Then
        '    If lblDr.Text = String.Empty Then
        '        Alerta("Seleccione con la tecla F5 la cuenta débito para ésta interfas")
        '        txtDR.Focus()
        '        Return False
        '    End If
        'End If
        'If lblCr.Text = String.Empty Then
        '    Alerta("Seleccione con la tecla F5 la cuenta crédito para ésta interfas")
        '    txtCR.Focus()
        '    Return False
        'End If

        If CInt(txtIDInterfas.Text) = 0 Then
            If SCALAR_NUM("SELECT IFNULL(1,0) FROM  tbl_interfascontabletipotrans_conf WHERE Frm='" & nombreFrm & "' AND IdTipo=" & cmbTipo.SelectedValue & "") = 1 Then
                Alerta("Éste formulario ya tiene el interfas de cuenta contable")
                Return False
            End If
        End If
        'If txtConcepto.Text = String.Empty Then
        '    Alerta("Escriba un concepto por favor")
        '    txtConcepto.Focus()
        '    Return False
        'End If
        Return True
    End Function

    Private Sub CargarInterfasCta()

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        lvInterfasCta.Clear()
        lvInterfasCta.View = View.Details
        lvInterfasCta.LabelEdit = False
        lvInterfasCta.FullRowSelect = True
        lvInterfasCta.GridLines = True
        lvInterfasCta.MultiSelect = False
        lvInterfasCta.Sorting = SortOrder.None



        Dim sqlSearch As String
        Dim accion As Short

        sqlSearch = "SELECT ttc.ID AS ID, ttc.Frm AS frm, tt.fld_descripcion AS tipo FROM tbl_interfascontabletipotrans_conf AS ttc INNER JOIN tbl_interfascontableotrastipo AS tt ON ttc.IdTipo=tt.fld_id ORDER BY  ttc.Frm"


        ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds)


        Dim columnText(7) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "ID"
        columnText(1) = "Módulo"
        columnText(2) = "Formulario"
        columnText(3) = "Débito"
        columnText(4) = "Crédito"
        columnText(5) = "Tipo"
        columnText(6) = "Concepto"

        Dim columnWidth(7) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 100
        columnWidth(2) = 236
        columnWidth(3) = 100
        columnWidth(4) = 100
        columnWidth(5) = 150
        columnWidth(6) = 200

        Dim columnAlign(7) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 0 'DERECHA
        columnAlign(4) = 0 'DERECHA
        columnAlign(5) = 0 'DERECHA
        columnAlign(6) = 0 'DERECHA


        Dim count = 0
        Dim c As DataColumn
        For Each c In ds.Tables(0).Columns
            'adding names of columns as Listview columns				
            Dim h As New ColumnHeader
            h.Text = columnText(count) ' c.ColumnName
            h.TextAlign = columnAlign(count)
            h.Width = columnWidth(count)
            Me.lvInterfasCta.Columns.Add(h)
            count += 1
        Next



        Dim dt As DataTable = ds.Tables(0)
        Dim str(ds.Tables(0).Columns.Count) As String
        'adding Datarows as listview Grids
        Dim rr As DataRow



        For Each rr In dt.Rows

            For col As Integer = 0 To ds.Tables(0).Columns.Count - 1
                '/FORMATEAMO LOS DATOS DE ACUERDO A SU FORMATO, ESTO SE HACE POR CADA COLUMNA QUE EXISTA
                If rr(col).GetType().FullName.ToString = "System.Int32" Then
                    str(col) = Format(rr(col), "00000")
                ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                    str(col) = Format(rr(col), "d")
                ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                    str(col) = rr(col).ToString()
                ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                    str(col) = Format(rr(col), "##,##0.00")
                End If
            Next

            Dim ii As New ListViewItem(str)
            lvInterfasCta.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub

    Private Sub LimpiarInterfas()
        txtIDInterfas.Text = 0
        txtDR.Text = String.Empty
        txtCR.Text = String.Empty
        txtDR.Enabled = True
        txtCR.Enabled = True
        lblDr.Text = String.Empty
        lblCr.Text = String.Empty
        CargarInterfasCta()
        btnGuardarInterfas.Text = "&Agregar"
        txtConcepto.Text = String.Empty
    End Sub

    Private Sub GuardarInterfasCta()
        If cmbFrms.Text = "Emision de cheques" Then
            txtDR.Text = "n/a"
        End If
        NON_QUERY("INSERT INTO tbl_interfascontable (Fecha,Modulo,Frm,DRCuenta,CRCuenta,IDTipo,Concepto) VALUES(NOW(),'" & cmbModulo.Text & "','" & cmbFrms.Text & "','" & txtDR.Text & "','" & txtCR.Text & "'," & cmbTipo.SelectedValue & ",'" & txtConcepto.Text & "')")
    End Sub

    Private Sub ModificarInterfasCta(ByVal IDInterfas As Integer)
        NON_QUERY("UPDATE tbl_interfascontable SET Modulo='" & cmbModulo.Text & "',Frm='" & cmbFrms.Text & "',DRCuenta='" & txtDR.Text & "',CRCuenta='" & txtCR.Text & "', IDTipo=" & cmbTipo.SelectedValue & ",Concepto='" & txtConcepto.Text & "' WHERE ID=" & IDInterfas & "")
    End Sub

    Private Sub BorrarInterfasCta(ByVal IDInterfas As Integer)
        NON_QUERY("DELETE FROM tbl_interfascontable WHERE ID=" & IDInterfas & "")
        CargarInterfasCta()
    End Sub

    Private Sub BuscarInterfasCta(ByVal IDInterfas As Integer)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT ID,Frm, IDTipo FROM tbl_interfascontabletipotrans_conf WHERE ID=" & IDInterfas & "", conn)
        da.Fill(ds, "tbl_interfascontabletipotrans_conf")
        Dim dr As DataRow

        For Each dr In ds.Tables(0).Rows
            txtIDInterfas.Text = dr("ID")

            cmbFrms.Text = dr("Frm")
             
            cmbTipo.SelectedValue = dr("IDTipo")

            btnGuardarInterfas.Text = "&Modificar"
        Next
        ds.Dispose()
        da.Dispose()
        
    End Sub

    Private Sub LlenarModulos()
        Dim da As New MySqlDataAdapter("SELECT ID, Descripcion FROM tbl_interfascontablemodulos ORDER BY Descripcion", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbModulo.DataSource = dt
        cmbModulo.DisplayMember = "Descripcion"
        cmbModulo.ValueMember = "ID"
    End Sub

    Private Sub LlenarFormulario(ByVal IDModulo As Integer)
        Dim da As New MySqlDataAdapter("SELECT ID, Descripcion FROM tbl_interfascontableformularios WHERE IDModulo=" & IDModulo & " ORDER BY Descripcion", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbFrms.DataSource = dt
        cmbFrms.DisplayMember = "Descripcion"
        cmbFrms.ValueMember = "ID"
    End Sub
 
    
 
    'VERIFICAR Y VALIDAR LAS FECHAS DE LOS PERIODOS CONTABLE
    Private Sub CREAR_PERIODO_CONTABLE()
        NON_QUERY("INSERT INTO tbl_periodos_contables (fld_fecha_inicia_pc,fld_fecha_termina_pc,fld_estado_pc) VALUES('" & formatDate(fld_fecha_inicia_pc.Value.Date) & "','" & formatDate(fld_fecha_termina_pc.Value.Date) & "','INACTIVO')")
        CREAR_MESES_CONTABLES()
    End Sub
    Private Sub ACTIVAR_PERIODO(ByVal id_pc As String)

        If ESTADO_PERIODO(intUltimoPC) <> "CERRADO" Then
            NON_QUERY("UPDATE tbl_periodos_contables_meses SET fld_estado_mes_pc='ACTIVO' WHERE fld_id_del_periodo_contable=" & id_pc & "")
            FillListView_MESES(id_pc)
        End If

        NON_QUERY("UPDATE tbl_periodos_contables SET fld_estado_pc='ACTIVO' WHERE fld_id_pc=" & id_pc & "")
        FillListView()

    End Sub
    Private Sub CERRAR_PERIODO(ByVal id_pc As Integer)

        NON_QUERY("UPDATE tbl_periodos_contables SET fld_estado_pc='CERRADO' WHERE fld_id_pc=" & id_pc & "")
        NON_QUERY("UPDATE tbl_periodos_contables_meses SET fld_estado_mes_pc='CERRADO' WHERE fld_id_del_periodo_contable=" & id_pc & "")


        Dim desde As String = SCALAR_STRING("SELECT  DATE_FORMAT(fld_fecha_inicia_pc, '%Y-%m-%d') FROM tbl_periodos_contables  WHERE fld_id_pc=" & id_pc & "")
        Dim hasta As String = SCALAR_STRING("SELECT  DATE_FORMAT(fld_fecha_termina_pc, '%Y-%m-%d') FROM tbl_periodos_contables  WHERE fld_id_pc=" & id_pc & "")


        'NON_QUERY("INSERT INTO TBL_ENTRADA_DIARIAS (FLD_VER_EN_INTERFACE, FLD_DATE_ENTRADA, FLD_USER, FLD_ACENTADA, FLD_TIPO_ENTRADA,fld_ncf, FLD_STATUS_ENTRADA, FLD_DOC_AFECTADO, FLD_DETALLE1, FLD_DETALLE2, FLD_MONTO, FLD_DOC_MIXTO,FLD_CTA_DEBITO,FLD_CTA_CREDITO) VALUES('NO','" & hasta & "','" & User(0) & "','SI','CIERRE','n/a','N',CONCAT('CIERRE DEL PERIODO No. '," & id_pc & "), CONCAT('CIERRE DEL PERIODO No. '," & id_pc & ",' Desde ','" & desde & "',' Hasta ', '" & hasta & "'),CONCAT('CIERRE DEL PERIODO No. '," & id_pc & ",' Desde ','" & desde & "',' Hasta ', '" & hasta & "'),0,'SI','" & txt_cta_cierre.Text & "','" & txt_cta_cierre.Text & "');")


        'CierrePeriodo(desde, hasta, txt_cta_cierre.Text, lblCierre.Text)

    End Sub
    Private Sub CERRAR_MES(ByVal id_pc As String, ByVal estado As String)
        NON_QUERY("UPDATE tbl_periodos_contables_meses SET fld_estado_mes_pc='" & estado & "' WHERE fld_id_mes_pc=" & id_pc & "")
        Dim mesCerrado As Date = CDate(SCALAR_STRING("SELECT fld_fecha_mes_pc FROM tbl_periodos_contables_meses  WHERE fld_id_mes_pc=" & id_pc & ""))
        ''NON_QUERY("CALL cont_cierre_mes('" & formatDate(PrimerDiaDelMes(mesCerrado)) & "','" & formatDate(UltimoDiaDelMes(mesCerrado)) & "')")
        FillListView()
    End Sub
    Private Sub CREAR_MESES_CONTABLES()
        Dim meses As Integer = DateDiff(DateInterval.Month, fld_fecha_inicia_pc.Value.Date, fld_fecha_termina_pc.Value.Date)
        Dim id_pc = UltimoID("tbl_periodos_contables", "fld_id_pc")
        Dim i As Integer, count = 1, mes As Date = fld_fecha_inicia_pc.Value.Date
        For i = 1 To meses + 1
            NON_QUERY("INSERT INTO tbl_periodos_contables_meses (fld_fecha_mes_pc,fld_estado_mes_pc,fld_id_del_periodo_contable,fld_no_mes_pc) VALUES('" & formatDate(mes) & "','INACTIVO'," & id_pc & ",'" & Format(count, "00") & "')")

            mes = fld_fecha_inicia_pc.Value.AddMonths(count)

            count = count + 1
        Next
        FillListView_MESES(id_pc)
    End Sub

    Private Sub FillListView()
        LV_PERIODO.Clear()
        LV_PERIODO.View = View.Details
        LV_PERIODO.LabelEdit = False
        LV_PERIODO.FullRowSelect = True
        LV_PERIODO.GridLines = True
        LV_PERIODO.MultiSelect = False
        LV_PERIODO.Sorting = SortOrder.None


        Dim sqlSearch As String
        Dim accion As Short

        Try

            sqlSearch = "SELECT fld_id_pc, fld_fecha_inicia_pc, fld_fecha_termina_pc, fld_estado_pc FROM tbl_periodos_contables"

            Dim ds As New DataSet
            Dim da As MySqlDataAdapter
            ds.Reset()
            da = New MySqlDataAdapter(sqlSearch, conn)
            da.Fill(ds, "tbl_periodos_contables")

            Dim columnText(7) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
            columnText(0) = "COD."
            columnText(1) = "INICIA"
            columnText(2) = "TERMINA"
            columnText(3) = "ESTADO"
            columnText(4) = "ABONO"
            columnText(5) = "BALANCE"


            Dim columnWidth(7) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
            columnWidth(0) = 0
            columnWidth(1) = 125
            columnWidth(2) = 125
            columnWidth(3) = 85
            columnWidth(4) = 85
            columnWidth(5) = 85


            Dim columnAlign(7) As Int32 'PARA ALINEAR LOS DATOS
            columnAlign(0) = 0 'IZQUIERDA
            columnAlign(1) = 0 'IZQUIERDA
            columnAlign(2) = 0 'IZQUIERDA
            columnAlign(3) = 0 'IZQUIERDA
            columnAlign(4) = 1 'IZQUIERDA
            columnAlign(5) = 1 'IZQUIERDA

            Dim count = 0
            Dim c As DataColumn
            For Each c In ds.Tables(0).Columns
                'adding names of columns as Listview columns				
                Dim h As New ColumnHeader
                h.Text = columnText(count) ' c.ColumnName
                h.TextAlign = columnAlign(count)
                h.Width = columnWidth(count)
                Me.LV_PERIODO.Columns.Add(h)
                count += 1
            Next



            Dim dt As DataTable = ds.Tables(0)
            Dim str(ds.Tables(0).Columns.Count) As String
            'adding Datarows as listview Grids
            Dim rr As DataRow



            For Each rr In dt.Rows

                For col As Integer = 0 To ds.Tables(0).Columns.Count - 1
                    '/FORMATEAMO LOS DATOS DE ACUERDO A SU FORMATO, ESTO SE HACE POR CADA COLUMNA QUE EXISTA
                    If rr(col).GetType().FullName.ToString = "System.Int32" Then
                        str(col) = Format(rr(col), "00000")
                    ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                        str(col) = Format(rr(col), "dd/MMM/yyyy")
                    ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                        str(col) = rr(col).ToString()
                    ElseIf rr(col).GetType().FullName.ToString = "System.Decimal" Then
                        str(col) = Format(rr(col), "##,##0.00")
                    ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                        str(col) = Format(rr(col), "##,##0.00")
                    End If
                Next

                Dim ii As New ListViewItem(str)
                Me.LV_PERIODO.Items.Add(ii)
                'showing the number of records still added
            Next




        Catch ex As Exception
            Alerta(ex.Message)
        End Try








    End Sub
    Private Sub FillListView_MESES(ByVal ID_PC As String)
        LV_PERIODO_MESES.Clear()
        LV_PERIODO_MESES.View = View.Details
        LV_PERIODO_MESES.LabelEdit = False
        LV_PERIODO_MESES.FullRowSelect = True
        LV_PERIODO_MESES.GridLines = True
        LV_PERIODO_MESES.MultiSelect = False
        LV_PERIODO_MESES.Sorting = SortOrder.None


        Dim sqlSearch As String
        Dim accion As Short


        sqlSearch = "SELECT fld_id_mes_pc, fld_no_mes_pc, fld_fecha_mes_pc, fld_estado_mes_pc FROM tbl_periodos_contables_meses WHERE fld_id_del_periodo_contable=" & ID_PC & ""

        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        'ds.Reset()
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_periodos_contables_meses")

        Dim columnText(7) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "COD."
        columnText(1) = "No."
        columnText(2) = "MES"
        columnText(3) = "ESTADO"
        columnText(4) = "ABONO"
        columnText(5) = "BALANCE"


        Dim columnWidth(7) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 125
        columnWidth(2) = 125
        columnWidth(3) = 85
        columnWidth(4) = 85
        columnWidth(5) = 85


        Dim columnAlign(7) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 0 'IZQUIERDA
        columnAlign(4) = 1 'IZQUIERDA
        columnAlign(5) = 1 'IZQUIERDA

        Dim count = 0
        Dim c As DataColumn
        For Each c In ds.Tables(0).Columns
            'adding names of columns as Listview columns				
            Dim h As New ColumnHeader
            h.Text = columnText(count) ' c.ColumnName
            h.TextAlign = columnAlign(count)
            h.Width = columnWidth(count)
            Me.LV_PERIODO_MESES.Columns.Add(h)
            count += 1
        Next



        Dim dt As DataTable = ds.Tables(0)
        Dim str(ds.Tables(0).Columns.Count) As String
        'adding Datarows as listview Grids
        Dim rr As DataRow



        For Each rr In dt.Rows

            For col As Integer = 0 To ds.Tables(0).Columns.Count - 1
                '/FORMATEAMO LOS DATOS DE ACUERDO A SU FORMATO, ESTO SE HACE POR CADA COLUMNA QUE EXISTA
                If rr(col).GetType().FullName.ToString = "System.Int32" Then
                    str(col) = Format(rr(col), "00000")
                ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                    str(col) = Format(rr(col), "MMMM/yyyy")
                ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                    str(col) = rr(col).ToString()
                ElseIf rr(col).GetType().FullName.ToString = "System.Decimal" Then
                    str(col) = Format(rr(col), "##,##0.00")
                ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                    str(col) = Format(rr(col), "##,##0.00")
                End If
            Next

            Dim ii As New ListViewItem(str)
            Me.LV_PERIODO_MESES.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub

    Private Function ESTADO_PERIODO(ByVal Id_Doc As Integer) As String
        ESTADO_PERIODO = SCALAR_STRING("SELECT IFNULL(fld_estado_pc,'n/a') FROM tbl_periodos_contables WHERE fld_id_pc=" & Id_Doc & "")
    End Function


    Private Sub btnConfBceGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfBceGeneral.Click
        frmsConfiguracionBceGeneral()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If SCALAR_NUM("SELECT IFNULL(1,0) FROM tbl_periodos_contables WHERE fld_estado_pc='ACTIVO'") > 0 Then
            Alerta("No puede tener dos períodos ACTIVOS")
            Exit Sub
        End If

        If Alerta("Verifique que los datos sean correctos " & Chr(13) & "¿Desea crear el Período?") = True Then
            CREAR_PERIODO_CONTABLE()
            FillListView()
            Alerta("Período creado con exito")
        End If

    End Sub
    Private Sub LV_PERIODO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV_PERIODO.KeyDown
        If e.KeyCode = Keys.Enter Then
            FillListView_MESES(LV_PERIODO.FocusedItem.Text)
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If ESTADO_PERIODO(LV_PERIODO.FocusedItem.Text) = "ACTIVO" Then
            Alerta("Este périodo ya está ACTIVO")
            Exit Sub
        ElseIf SCALAR_NUM("SELECT COUNT(*) FROM tbl_periodos_contables WHERE fld_estado_pc='ACTIVO'") > 0 Then
            Alerta("Solo se permite un périodo ACTIVO")
            Exit Sub
            'ElseIf ESTADO_PERIODO(LV_PERIODO.FocusedItem.Text) = "CERRADO" Then
            '    Alerta("Este périodo ha sido CERRADO")
            '    Exit Sub
        End If
        ACTIVAR_PERIODO(LV_PERIODO.FocusedItem.Text)
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        If ESTADO_PERIODO(LV_PERIODO.FocusedItem.Text) <> "ACTIVO" Then
            Alerta("El periodo que intenta cerrar no está ACTIVO")
            Exit Sub
        End If
        If Alerta("Está a punto de cerrar el período contable que está activo ¿Seguro que desea continuar?") = False Then Exit Sub
        CERRAR_PERIODO(LV_PERIODO.FocusedItem.Text)
        FillListView()
        FillListView_MESES(intUltimoPC)
        Alerta("Cierre realizado con exito, consulte transacción de tipo (CIERRE) para confirmar")
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        CERRAR_MES(LV_PERIODO_MESES.FocusedItem.Text, "CERRADO")
        FillListView_MESES(intUltimoPC)
    End Sub
 
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim f As New FRM_CONF_CHEQUERA
        f.ShowDialog()
        f.Dispose()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If ESTADO_PERIODO(intUltimoPC) = "ACTIVO" Then
            CERRAR_MES(LV_PERIODO_MESES.FocusedItem.Text, "ACTIVO")
            FillListView_MESES(intUltimoPC)
        Else
            Alerta("No se puede activar un mes si el periodo esta cerrado o inactivo.")
        End If
    End Sub

    Private Sub cmbModulo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbModulo.SelectedValueChanged
        If cmbModulo.SelectedValue.GetType.ToString <> "System.Data.DataRpwView" Then

            Try
                LlenarFormulario(cmbModulo.SelectedValue)
            Catch ex As Exception
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub cmbModulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbModulo.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbFrms_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbFrms.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtDR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDR.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txtDR.Text = Id
                lblDr.Text = ReturnDescripcion(Id)
                txtDR.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtCR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCR.KeyDown
        If e.KeyCode = Keys.F5 Then
            If frmsListaCatalogoCuentaContable() = True Then
                txtCR.Text = Id
                lblCr.Text = ReturnDescripcion(Id)
                txtCR.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnGuardarInterfas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarInterfas.Click
        If ValidarInterfas(cmbFrms.Text) = False Then Return
        If btnGuardarInterfas.Text = "&Agregar" Then
            'GuardarInterfasCta()
            NON_QUERY("INSERT INTO tbl_interfascontabletipotrans_conf (IdTipo, Frm) VALUES(" & cmbTipo.SelectedValue & ",'" & cmbFrms.Text & "')")
        Else
            NON_QUERY("UPDATE tbl_interfascontabletipotrans_conf SET IdTipo=" & cmbTipo.SelectedValue & ", Frm='" & cmbFrms.Text & "' WHERE ID=" & txtIDInterfas.Text & "")
            'ModificarInterfasCta()
        End If
        LimpiarInterfas()
    End Sub

    Private Sub btnConfEstadoResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfEstadoResultado.Click
        frmsConfiguracionEstadoResultado()
    End Sub

    Private Sub lvInterfasCta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvInterfasCta.SelectedIndexChanged

    End Sub

    Private Sub lvInterfasCta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvInterfasCta.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Alerta("¿Seguro que desea borrar ésta configuración de interfas?") = True Then
                BorrarInterfasCta(CInt(lvInterfasCta.FocusedItem.Text))
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            BuscarInterfasCta(CInt(lvInterfasCta.FocusedItem.Text))
        End If
    End Sub

    Private Sub lvInterfasCta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvInterfasCta.DoubleClick
        BuscarInterfasCta(CInt(lvInterfasCta.FocusedItem.Text))
    End Sub

    Private Sub LV_PERIODO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV_PERIODO.SelectedIndexChanged
        If Not IsNothing(LV_PERIODO.FocusedItem) Then
            FillListView_MESES(LV_PERIODO.FocusedItem.Text)
            intUltimoPC = CInt(LV_PERIODO.FocusedItem.Text)
        End If
    End Sub

    Private Sub txtDR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDR.TextChanged

    End Sub

    Private Sub btnOtraInterfas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtraInterfas.Click
        Dim f As New frmInterfasRecibosIngresos
        f.ShowDialog()
        f.Dispose()
    End Sub

End Class
