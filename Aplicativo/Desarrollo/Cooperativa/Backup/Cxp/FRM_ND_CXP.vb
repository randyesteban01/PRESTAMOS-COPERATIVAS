Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing
Public Class FRM_ND_CXP
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
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
    Friend WithEvents btnCierra As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btn_cobrar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents fld_concepto As System.Windows.Forms.TextBox
    Friend WithEvents btnGuarda As System.Windows.Forms.Button
    Friend WithEvents txtMontoCobrar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents btnBusca As System.Windows.Forms.Button
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DG_ND As System.Windows.Forms.DataGrid
    Friend WithEvents btnOn As System.Windows.Forms.Button
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents fld_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnImprime As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents cbEgresoCaja As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_ND_CXP))
        Me.btn_cobrar = New System.Windows.Forms.Button
        Me.btnCierra = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.fld_fecha = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnOff = New System.Windows.Forms.Button
        Me.btnOn = New System.Windows.Forms.Button
        Me.fld_concepto = New System.Windows.Forms.TextBox
        Me.btnGuarda = New System.Windows.Forms.Button
        Me.txtMontoCobrar = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.btnBusca = New System.Windows.Forms.Button
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.lblCustomerID = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtCustomerID = New System.Windows.Forms.TextBox
        Me.lblBalance = New System.Windows.Forms.Label
        Me.DG_ND = New System.Windows.Forms.DataGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnImprime = New System.Windows.Forms.Button
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.cbEgresoCaja = New System.Windows.Forms.CheckBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DG_ND, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cobrar
        '
        Me.btn_cobrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_cobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cobrar.ForeColor = System.Drawing.Color.Black
        Me.btn_cobrar.Image = CType(resources.GetObject("btn_cobrar.Image"), System.Drawing.Image)
        Me.btn_cobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cobrar.Location = New System.Drawing.Point(80, 384)
        Me.btn_cobrar.Name = "btn_cobrar"
        Me.btn_cobrar.Size = New System.Drawing.Size(72, 56)
        Me.btn_cobrar.TabIndex = 14
        Me.btn_cobrar.Text = "&Guardar"
        Me.btn_cobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnCierra
        '
        Me.btnCierra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCierra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCierra.ForeColor = System.Drawing.Color.Black
        Me.btnCierra.Image = CType(resources.GetObject("btnCierra.Image"), System.Drawing.Image)
        Me.btnCierra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierra.Location = New System.Drawing.Point(224, 384)
        Me.btnCierra.Name = "btnCierra"
        Me.btnCierra.Size = New System.Drawing.Size(72, 56)
        Me.btnCierra.TabIndex = 15
        Me.btnCierra.Text = "&Cerrar"
        Me.btnCierra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(8, 384)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(650, 376)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.fld_fecha)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.btnOff)
        Me.TabPage1.Controls.Add(Me.btnOn)
        Me.TabPage1.Controls.Add(Me.fld_concepto)
        Me.TabPage1.Controls.Add(Me.btnGuarda)
        Me.TabPage1.Controls.Add(Me.txtMontoCobrar)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtBalance)
        Me.TabPage1.Controls.Add(Me.btnBusca)
        Me.TabPage1.Controls.Add(Me.lblFirstName)
        Me.TabPage1.Controls.Add(Me.lblCustomerID)
        Me.TabPage1.Controls.Add(Me.txtFirstName)
        Me.TabPage1.Controls.Add(Me.txtCustomerID)
        Me.TabPage1.Controls.Add(Me.lblBalance)
        Me.TabPage1.Controls.Add(Me.DG_ND)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(642, 347)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ficha General"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(312, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Concepto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(456, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Fecha"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_fecha
        '
        Me.fld_fecha.CustomFormat = "dd / MMM / yyyy"
        Me.fld_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fld_fecha.Location = New System.Drawing.Point(504, 8)
        Me.fld_fecha.Name = "fld_fecha"
        Me.fld_fecha.Size = New System.Drawing.Size(120, 20)
        Me.fld_fecha.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(536, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Seleccionar todo"
        '
        'btnOff
        '
        Me.btnOff.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOff.ForeColor = System.Drawing.Color.Black
        Me.btnOff.Location = New System.Drawing.Point(584, 152)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(40, 24)
        Me.btnOff.TabIndex = 100
        Me.btnOff.Text = "No"
        '
        'btnOn
        '
        Me.btnOn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn.ForeColor = System.Drawing.Color.Black
        Me.btnOn.Location = New System.Drawing.Point(536, 152)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(40, 24)
        Me.btnOn.TabIndex = 99
        Me.btnOn.Text = "Si"
        '
        'fld_concepto
        '
        Me.fld_concepto.BackColor = System.Drawing.Color.White
        Me.fld_concepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_concepto.ForeColor = System.Drawing.Color.Black
        Me.fld_concepto.Location = New System.Drawing.Point(312, 32)
        Me.fld_concepto.MaxLength = 355
        Me.fld_concepto.Multiline = True
        Me.fld_concepto.Name = "fld_concepto"
        Me.fld_concepto.Size = New System.Drawing.Size(312, 64)
        Me.fld_concepto.TabIndex = 9
        Me.fld_concepto.Text = ""
        '
        'btnGuarda
        '
        Me.btnGuarda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuarda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuarda.ForeColor = System.Drawing.Color.Black
        Me.btnGuarda.Location = New System.Drawing.Point(88, 80)
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(72, 24)
        Me.btnGuarda.TabIndex = 6
        Me.btnGuarda.Text = "Deshacer"
        Me.btnGuarda.Visible = False
        '
        'txtMontoCobrar
        '
        Me.txtMontoCobrar.BackColor = System.Drawing.Color.White
        Me.txtMontoCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCobrar.ForeColor = System.Drawing.Color.Black
        Me.txtMontoCobrar.Location = New System.Drawing.Point(312, 98)
        Me.txtMontoCobrar.Name = "txtMontoCobrar"
        Me.txtMontoCobrar.Size = New System.Drawing.Size(312, 38)
        Me.txtMontoCobrar.TabIndex = 10
        Me.txtMontoCobrar.Text = "0.00"
        Me.txtMontoCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(136, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 32)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Monto RD$"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtBalance.ForeColor = System.Drawing.Color.Black
        Me.txtBalance.Location = New System.Drawing.Point(88, 60)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(208, 20)
        Me.txtBalance.TabIndex = 3
        Me.txtBalance.Text = "0.00"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBusca
        '
        Me.btnBusca.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusca.ForeColor = System.Drawing.Color.Black
        Me.btnBusca.Image = CType(resources.GetObject("btnBusca.Image"), System.Drawing.Image)
        Me.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBusca.Location = New System.Drawing.Point(184, 6)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(104, 32)
        Me.btnBusca.TabIndex = 0
        Me.btnBusca.Text = "&Proveedores"
        Me.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFirstName
        '
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.Black
        Me.lblFirstName.Location = New System.Drawing.Point(8, 38)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(72, 16)
        Me.lblFirstName.TabIndex = 83
        Me.lblFirstName.Text = "Proveedor"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCustomerID
        '
        Me.lblCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerID.ForeColor = System.Drawing.Color.Black
        Me.lblCustomerID.Location = New System.Drawing.Point(8, 15)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(72, 16)
        Me.lblCustomerID.TabIndex = 82
        Me.lblCustomerID.Text = "Código"
        Me.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstName.ForeColor = System.Drawing.Color.Black
        Me.txtFirstName.Location = New System.Drawing.Point(88, 36)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(208, 20)
        Me.txtFirstName.TabIndex = 2
        Me.txtFirstName.Text = ""
        '
        'txtCustomerID
        '
        Me.txtCustomerID.BackColor = System.Drawing.Color.White
        Me.txtCustomerID.ForeColor = System.Drawing.Color.Black
        Me.txtCustomerID.Location = New System.Drawing.Point(88, 12)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(88, 20)
        Me.txtCustomerID.TabIndex = 1
        Me.txtCustomerID.Text = ""
        '
        'lblBalance
        '
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(16, 60)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(64, 16)
        Me.lblBalance.TabIndex = 85
        Me.lblBalance.Text = "Balance"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DG_ND
        '
        Me.DG_ND.BackgroundColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.DG_ND.CaptionVisible = False
        Me.DG_ND.DataMember = ""
        Me.DG_ND.ForeColor = System.Drawing.Color.Green
        Me.DG_ND.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DG_ND.Location = New System.Drawing.Point(8, 176)
        Me.DG_ND.Name = "DG_ND"
        Me.DG_ND.Size = New System.Drawing.Size(616, 160)
        Me.DG_ND.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Documentos"
        '
        'btnImprime
        '
        Me.btnImprime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprime.ForeColor = System.Drawing.Color.Black
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprime.Location = New System.Drawing.Point(152, 384)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(72, 56)
        Me.btnImprime.TabIndex = 69
        Me.btnImprime.Text = "&ReImprimir"
        Me.btnImprime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cbEgresoCaja
        '
        Me.cbEgresoCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEgresoCaja.Location = New System.Drawing.Point(320, 376)
        Me.cbEgresoCaja.Name = "cbEgresoCaja"
        Me.cbEgresoCaja.Size = New System.Drawing.Size(272, 32)
        Me.cbEgresoCaja.TabIndex = 105
        Me.cbEgresoCaja.Text = "Generar Egreso de Caja"
        Me.cbEgresoCaja.Visible = False
        '
        'FRM_ND_CXP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(650, 443)
        Me.Controls.Add(Me.btnImprime)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCierra)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btn_cobrar)
        Me.Controls.Add(Me.cbEgresoCaja)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_ND_CXP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas de Débitos CxP"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DG_ND, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsCustomer As New DataSet
    Private daCustomer As MySqlDataAdapter
    Dim description As String
    Dim isNewDoc As Boolean = True
    Dim isValidated As Boolean = True
    Dim CustBce As Single
    Dim CustAddress As String

    Dim ds As DataSet, dsND As DataSet
    Dim da As MySqlDataAdapter, daND As MySqlDataAdapter
    Dim monto As Single, nd_afectada As String, fact_afectada As String

    Dim objIniFile As New IniFile(AppPath & "\Settings_Compras_CxP.ini") '/INI FILE
    '/PROPIEDADES DEL FORMULARIO
    Private Sub FrmCustomer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub
    
    '/SUB PROGRAMAS
    Private Sub DESABLE_FIELDS()
        txtFirstName.Enabled = False
        txtBalance.Enabled = False
    End Sub

    Private Sub ENABLE_FIELDS()
        txtFirstName.Enabled = True
        txtBalance.Enabled = True
    End Sub

    Private Sub CLEAR_FIELDS()
        txtCustomerID.Text = ""
        txtFirstName.Text = ""
        txtBalance.Text = "0.00"
        txtMontoCobrar.Text = "0.00"
        fld_concepto.Text = ""
    End Sub

    Private Sub LOAD_SUPLIDOR(ByVal id_doc As Integer)
        NON_QUERY("CALL set_bce_proveedor(" & id_doc & ")")
        Dim isdata As Boolean = False
        ds = New DataSet
        da = New MySqlDataAdapter("SELECT * FROM tbl_Supplier WHERE fldSupplierID=" & id_doc & "", conn)
        da.Fill(ds, "tbl_Supplier")

        Dim nr As DataRow
        For Each nr In ds.Tables(0).Rows

            txtCustomerID.Text = id_doc
            txtFirstName.Text = nr("fldCompany")
            LOAD_NC()
            BCE()
        Next
        ON_Select()


        conn.Close()
    End Sub
    Private Sub LOAD_NC()


        Dim SQLSTRING As String
        SQLSTRING = "SELECT *  FROM tbl_nc_cxp WHERE fld_proveedor_id_nc=" & txtCustomerID.Text & "  AND fld_balance > 0 ORDER BY fld_fecha"
        dsND = New DataSet
        daND = New MySqlDataAdapter(SQLSTRING, conn)
        StyleND()
        daND.Fill(dsND, "tbl_nc_cxp")
        DG_ND.DataSource = dsND.Tables("tbl_nc_cxp")
        Dim dr As DataRow

        Dim DataTable As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable = dsND.Tables("tbl_nc_cxp")
        DataTable.DefaultView.AllowNew = False

    End Sub

    Private Sub PRINT_DOC(ByVal idDoc As Integer)

        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        PrintDialog1.Document = docToPrint

        Dim pd As New PrintDocument, strOldPrinter As String
        strOldPrinter = pd.PrinterSettings.PrinterName 'Get the Default Print 

        Dim WshNetwork As Object
        WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
        WshNetwork.SetDefaultPrinter(PrintDialog1.PrinterSettings.PrinterName) 'Set the Default Print 

        Dim result As DialogResult = PrintDialog1.ShowDialog()



        ' If the result is OK then print the document.
        If (result = Windows.Forms.DialogResult.OK) Then
            Dim ds As New DataSet

            Dim daP As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument", conn)
            daP.Fill(ds, "tbl_profiledocument")

            Dim daP1 As New MySqlDataAdapter("SELECT * FROM view_nota_debito_cxp WHERE fld_id=" & idDoc & "", conn)
            daP1.Fill(ds, "view_nota_debito_cxp")

            Dim dr As DataRow
            For Each dr In ds.Tables(1).Rows
                Dim largo = Len(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")))
                Dim decimales = Mid(CStr(Format(CDbl(dr("fld_monto")), "##,###.00")), largo - 2)

                dr("fld_banco") = Num2Text(dr("fld_monto") - decimales) & " CON " & Mid(decimales, Len(decimales) - 1).ToUpper & " / 100" & " "
            Next


            Dim Report As New RPT_ND_CXP
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PrinterName = PrintDialog1.PrinterSettings.PrinterName
            Report.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, 0, 0)



        End If


        WshNetwork.SetDefaultPrinter(strOldPrinter) 'Get the Default Print



    End Sub



    Private Sub StyleND()
        DG_ND.TableStyles.Clear()

        ' Create a new DataGridTableStyle and set 
        ' its MappingName to the TableName of a DataTable. 

        Dim ts1 As New DataGridTableStyle
        ts1.GridLineColor = Color.Peru
        ts1.MappingName = "tbl_nc_cxp"

        Dim checkbox = New DataGridBoolColumn
        checkbox.MappingName = "fld_chk"
        checkbox.HeaderText = "S"
        checkbox.Width = 20
        checkbox.FalseValue = "False"
        checkbox.TrueValue = "True"
        checkbox.AllowNull = False
        checkbox.NullValue = "False"
        'AddHandler checkbox.Boolean.KeyPress, New KeyPressEventHandler(AddressOf KeyPress)
        ts1.GridColumnStyles.Add(checkbox)
        'Add a GridColumnStyle and set its MappingName 
        'to the name of a DataColumn in the DataTable. 
        'Set the HeaderText and Width properties. 

        ' Add a second column style. 
        Dim TextCol0 As New DataGridTextBoxColumn
        TextCol0.MappingName = "fld_id"
        TextCol0.HeaderText = "CODIGO"
        TextCol0.Width = 40
        TextCol0.ReadOnly = True
        TextCol0.NullText = ""
        ts1.GridColumnStyles.Add(TextCol0)

        ' Add a second column style. 
        Dim TextCol1 As New DataGridTextBoxColumn
        TextCol1.MappingName = "fld_fecha"
        TextCol1.HeaderText = "FECHA"
        TextCol1.Width = 80
        TextCol1.ReadOnly = True
        TextCol1.NullText = ""
        TextCol1.Format = "dd/MMM/yyyy"
        ts1.GridColumnStyles.Add(TextCol1)

        Dim TextCol11 As New DataGridTextBoxColumn
        TextCol11.MappingName = "fld_concepto"
        TextCol11.HeaderText = "DESCRIPCION"
        TextCol11.Width = 200
        TextCol11.ReadOnly = True
        TextCol11.NullText = ""
        ts1.GridColumnStyles.Add(TextCol11)

        ' Add a second column style. 
        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "fld_monto"
        TextCol2.HeaderText = "TOTAL"
        TextCol2.Width = 80
        TextCol2.ReadOnly = True
        TextCol2.Format = "C2"
        TextCol2.NullText = ""
        TextCol2.Alignment = HorizontalAlignment.Right
        ts1.GridColumnStyles.Add(TextCol2)

        ' Add a second column style. 
        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "fld_abono"
        TextCol3.HeaderText = "ABONO"
        TextCol3.Width = 80
        TextCol3.Format = "C2"
        TextCol3.Alignment = HorizontalAlignment.Right
        TextCol3.ReadOnly = True
        TextCol3.NullText = ""
        ts1.GridColumnStyles.Add(TextCol3)

        ' Add a second column style. 
        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "fld_balance"
        TextCol4.HeaderText = "BALANCE"
        TextCol4.Width = 80
        TextCol4.Format = "C2"
        TextCol4.Alignment = HorizontalAlignment.Right
        TextCol4.ReadOnly = True
        TextCol4.NullText = ""
        ts1.GridColumnStyles.Add(TextCol4)



        ts1.RowHeadersVisible = False

        ' Add the DataGridTableStyle objects to the collection. 
        DG_ND.GridLineColor.GetHashCode()
        DG_ND.TableStyles.Add(ts1)



    End Sub

    Private Sub SAVE_CHAGER_FACTURA(ByVal id_doc As String, ByVal abono As Double, ByVal bce As Double)

        NON_QUERY("UPDATE tbl_recepcion SET fld_Balance=" & bce & ", fldAbono=" & abono & "  WHERE  fldInvoiceID=" & id_doc & "")
    End Sub
    Private Sub SAVE_CHAGER_NC(ByVal id_doc As String, ByVal abono As Double, ByVal bce As Double)
        NON_QUERY("UPDATE tbl_nc_cxp SET fld_balance=" & bce & ", fld_abono=" & abono & "  WHERE  fld_id=" & id_doc & "")
    End Sub
    Private Sub SAVE_DETALLE_PAGO(ByVal id_doc As String, ByVal abono As Double, ByVal ri_no As Integer, ByVal tipo As String)
        NON_QUERY("INSERT INTO tbl_recibo_pago_cxp_detalle SET fld_id_doc=" & id_doc & ", fld_ult_abono=" & abono & ", fld_id_ri_padre=" & ri_no & ", fld_tipo_doc_ri_d='" & tipo & "'")
    End Sub
    Private Sub BCE()

        Dim dr_nc As DataRow
        Dim bce_nc As Double = 0
        For Each dr_nc In dsND.Tables(0).Rows
            bce_nc = bce_nc + dr_nc("fld_balance")
        Next

        txtBalance.Text = Format(bce_nc, "C2")


    End Sub

    Private Sub SAVE_ND()


        Dim nr As DataRow
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter("SELECT * FROM tbl_nd_cxp", conn)
        da.Fill(ds, "tbl_nd_cxp")

        nr = ds.Tables(0).NewRow

        'nr("fld_ncf_nd_cxp") = "A0100100" & CStr(ncf("notas de debito"))
        nr("fld_proveedor_id_nd") = CInt(txtCustomerID.Text)
        nr("fld_fecha") = "'" & Format(fld_fecha.Value.Date, "yyyy-MM-dd") & "'"
        nr("fld_concepto") = fld_concepto.Text
        nr("fld_monto") = CDbl(txtMontoCobrar.Text)
        nr("fld_user") = User(0)
        nr("fldStatus") = "N"
        nr("fld_doc_afectado") = ""
        nr("fld_doc_afectado_id") = "0"

        ds.Tables(0).Rows.Add(nr)


        conn.Open()
        Dim cmd As New MySqlCommandBuilder(da)
        da.InsertCommand = cmd.GetInsertCommand
        da.Update(ds, "tbl_nd_cxp")
        ds.AcceptChanges()
        conn.Close()

        ds.Dispose()
        da.Dispose()

    End Sub
    Private Sub CALCULO()
        monto = 0

        monto = CDec(txtMontoCobrar.Text)

        If monto > CDec(txtBalance.Text) Then
            txtMontoCobrar.Text = "0.00"
            txtMontoCobrar.SelectAll()
            Help.ShowPopup(txtCustomerID, "Está pagando más dinero que el balance de este PROVEEDOR", New Point(550, 375))
            Exit Sub
        ElseIf monto < CDec(txtBalance.Text) Then


        End If
        Dim rows As DataRow



        '/// NOTA DE CRÉDITO

        For Each rows In dsND.Tables("tbl_nc_cxp").Rows
            If rows("fld_chk") = "True" Then
                If monto >= rows("fld_balance") Then
                    rows("fld_fecha") = Format(Now, "d")
                    rows("fld_abono") = rows("fld_abono") + rows("fld_balance")
                    monto = monto - rows("fld_balance")
                    rows("fld_ultimo_abono") = rows("fld_balance")
                    rows("fld_balance") = 0

                    If description <> "" Then
                        nd_afectada = nd_afectada & "," & rows("fld_id")
                        description = description & " | " & "Saldo NC# " & Format(rows("fld_id"), "00000")
                    Else
                        description = " Saldo NC# " & Format(rows("fld_id"), "00000")
                        nd_afectada = rows("fld_id")
                    End If

                ElseIf monto < rows("fld_balance") Then
                    rows("fld_fecha") = Format(Now, "d")
                    rows("fld_abono") = rows("fld_abono") + monto
                    rows("fld_balance") = rows("fld_balance") - monto
                    rows("fld_ultimo_abono") = monto
                    If description <> "" Then
                        nd_afectada = nd_afectada & "," & rows("fld_id")
                        description = description & " ( " & "Abono de " & Format(monto, "c") & " a la NC# " & Format(rows("fld_id"), "00000") & ")"
                    Else
                        nd_afectada = rows("fld_id")
                        description = "( " & "Abono de " & Format(monto, "c") & " a la NC# " & Format(rows("fld_id"), "00000") & ")"
                    End If
                    monto = monto - monto
                End If
            End If
        Next

        DG_ND.DataSource = dsND.Tables("tbl_nc_cxp")
        Dim DataTable1 As DataTable '/PARA QUE NO HAGA LA ULTIMA LINEA EN BLANCO
        DataTable1 = dsND.Tables("tbl_nc_cxp")
        DataTable1.DefaultView.AllowNew = False





    End Sub
    Private Sub COBRANDO()


        Dim Num As String
        Num = CDbl(txtMontoCobrar.Text)
        Dim mesage As String = "¿Desea continuar?"

        Dim asking = Alerta(mesage)
        If asking = False Then
            DESHACER_DS()
            Exit Sub
        End If

        Dim show As New FrmPopupMessage
        show.Show("Actualizando... Por favor espere")

        Dim dr_fact As DataRow, dr_nd As DataRow
        'crear la ND Y documento de estado de cuenta
        If ds.HasChanges = True Then
            For Each dr_fact In ds.Tables(0).Rows
                SAVE_CHAGER_FACTURA(dr_fact("fldInvoiceID"), dr_fact("fldAbono"), dr_fact("fld_Balance"))
            Next
        End If
        If dsND.HasChanges = True Then
            For Each dr_nd In dsND.Tables("tbl_nc_cxp").Rows
                SAVE_CHAGER_NC(dr_nd("fld_id"), dr_nd("fld_abono"), dr_nd("fld_balance"))
            Next
        End If

        SAVE_ND()

        Dim lastCod = UltimoID("tbl_nd_cxp", "fld_id") '/CREA EL CODIGO QUE SE VERA EN EL ESTADO DE CTAS

        create_row_estado_proveedor(txtCustomerID.Text, CDbl(txtMontoCobrar.Text), "NDCXP", CStr(lastCod), fld_concepto.Text, fld_fecha.Value.Date)

        InterfarContableAutomatico("Cuenta por Pagar", "Nota de Débito(Pagos)", fld_fecha.Value.Date, CDec(txtMontoCobrar.Text), lastCod, fld_concepto.Text)

        If cbEgresoCaja.Checked = True Then
            NON_QUERY("INSERT INTO tbl_recibo_egresos (fldFecha, fldTipo, fldIdTipo, fldEntregado, fldConcepto, fldMonto, fldMontoLetra, fldUsuario) VALUES(Now(),'PROVEEDORES',0,'" & txtFirstName.Text & "','" & fld_concepto.Text & "'," & CDbl(txtMontoCobrar.Text) & ",'','" & User(0) & "')")
        End If

        LOAD_SUPLIDOR(txtCustomerID.Text)

        txtMontoCobrar.Text = "0.00"

        show.Close()
        PRINT_DOC(lastCod)

        description = Nothing
        CustBce = Nothing
        CustAddress = Nothing

        CLEAR_FIELDS()
        ENABLE_FIELDS()
        ds.Reset()
        dsND.Reset()
    End Sub
    Private Sub DESHACER_DS()
        description = ""
        nd_afectada = ""
        fact_afectada = ""
        ds.RejectChanges()
        dsND.RejectChanges()
    End Sub
    Private Sub COBRAR()
        If Trim(txtMontoCobrar.Text) = "" Then
            txtMontoCobrar.Text = "0.00"
        End If
        If Trim(fld_concepto.Text) = "" Then
            Alerta("Debe escribir el concepto")
            fld_concepto.Focus()
            Exit Sub

        ElseIf CDbl(txtMontoCobrar.Text) = 0 Or CDbl(txtMontoCobrar.Text) < 0 Then
            Alerta("Debe escribir el Monto a Cobrar")
            txtMontoCobrar.Focus()
            txtMontoCobrar.SelectAll()
            Exit Sub
        ElseIf CDbl(txtMontoCobrar.Text) > CDbl(txtBalance.Text) Then
            Alerta("No puede cobrar más dinero de lo que debe el cliente")
            Exit Sub
        End If
        CALCULO()
        COBRANDO()
    End Sub

    Private Sub ON_Select()
        Dim dr As DataRow

        For Each dr In dsND.Tables(0).Rows
            dr("fld_chk") = "True"
        Next
    End Sub
    Private Sub Off_Select()
        Dim dr As DataRow

        For Each dr In dsND.Tables(0).Rows
            dr("fld_chk") = "False"
        Next
    End Sub


    '/BOTONES
    Private Sub btnCierra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierra.Click
        'id = Nothing
        Me.Close()
    End Sub

    Private Sub btnGuarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuarda.Click
        DESHACER_DS()
    End Sub
    Private Sub btnOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOn.Click
        ON_Select()
    End Sub
    Private Sub btnOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOff.Click
        Off_Select()
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        CLEAR_FIELDS()
        ENABLE_FIELDS()
        ds.Reset()
        dsND.Reset()
    End Sub

    '/FIELD PROPIEDADES
    Private Sub txtMontoCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoCobrar.Click
        txtMontoCobrar.SelectAll()
    End Sub
    Private Sub txtMontoCobrar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoCobrar.Enter
        txtMontoCobrar.SelectAll()
    End Sub
    Private Sub txtMontoCobrar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoCobrar.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If


        If e.KeyChar = Chr(13) Then
            btn_cobrar.Focus()
        End If
    End Sub
    Private Sub txtCustomerID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustomerID.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            If txtCustomerID.Text <> "" Then
                LOAD_SUPLIDOR(txtCustomerID.Text)

                LOAD_NC()
                fld_concepto.Focus()
            End If
        End If
    End Sub


    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        If FRMS_POPUP_PROVEEDORES() = True Then
            NON_QUERY("CALL set_bce_proveedor(" & Id & ")")
            LOAD_SUPLIDOR(Id)
        End If
    End Sub


    Private Sub btn_cobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cobrar.Click
        If Trim(txtMontoCobrar.Text) = "" Then txtMontoCobrar.Text = 0
        If CDbl(txtMontoCobrar.Text) <= 0 Then Exit Sub
        COBRAR()
    End Sub

    Private Sub txtFormaDePago_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub txtMontoCobrar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoCobrar.KeyDown

        If e.KeyCode = Keys.Enter Then
            Dim amount As Decimal = CType(txtMontoCobrar.Text, Decimal)
            Me.txtMontoCobrar.Text = String.Format("{0:n2}", amount)
            Me.btn_cobrar.Focus()
        End If
    End Sub

    Private Sub btnBusca_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        If txtCustomerID.Text <> "" Then
            LOAD_SUPLIDOR(txtCustomerID.Text)

            LOAD_NC()
            fld_concepto.Focus()
        End If
    End Sub

    Private Sub txtCustomerID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerID.TextChanged

    End Sub

    Private Sub btnImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprime.Click
        If FRMS_LIST_ND_NC_CXP("ND") = True Then

        End If
    End Sub

    Private Sub FRM_ND_CXP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
    End Sub

    Private Sub cbEgresoCaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEgresoCaja.CheckedChanged

    End Sub

    Private Sub txtMontoCobrar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoCobrar.TextChanged

    End Sub
End Class
