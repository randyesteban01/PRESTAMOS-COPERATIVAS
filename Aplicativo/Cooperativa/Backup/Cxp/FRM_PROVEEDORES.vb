Imports MySql.Data.MySqlClient

Public Class FRM_PROVEEDORES
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
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents lblSupplierID As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplierID As System.Windows.Forms.TextBox
    Friend WithEvents btnCierra As System.Windows.Forms.Button
    Friend WithEvents btnAnula As System.Windows.Forms.Button
    Friend WithEvents btnGuarda As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fld_Fax As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fld_Cel As System.Windows.Forms.TextBox
    Friend WithEvents lvwCust As System.Windows.Forms.ListView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents fld_clasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents fld_tipo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fld_correo As System.Windows.Forms.TextBox
    Friend WithEvents fld_banco As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtLimiteCR As System.Windows.Forms.TextBox
    Friend WithEvents buscaCtaContableBtn As System.Windows.Forms.Button
    Friend WithEvents lblCuentaContable As System.Windows.Forms.Label
    Friend WithEvents txtCuentaContable As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_PROVEEDORES))
        Me.Label5 = New System.Windows.Forms.Label
        Me.fld_banco = New System.Windows.Forms.TextBox
        Me.fld_correo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.fld_tipo = New System.Windows.Forms.TextBox
        Me.fld_clasificacion = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.fld_Cel = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.fld_Fax = New System.Windows.Forms.TextBox
        Me.lblContact = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.lblSupplierID = New System.Windows.Forms.Label
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.txtSupplierID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnCierra = New System.Windows.Forms.Button
        Me.btnAnula = New System.Windows.Forms.Button
        Me.btnGuarda = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.lvwCust = New System.Windows.Forms.ListView
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.txtLimiteCR = New System.Windows.Forms.TextBox
        Me.buscaCtaContableBtn = New System.Windows.Forms.Button
        Me.lblCuentaContable = New System.Windows.Forms.Label
        Me.txtCuentaContable = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Cta. banco"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_banco
        '
        Me.fld_banco.BackColor = System.Drawing.Color.White
        Me.fld_banco.Location = New System.Drawing.Point(112, 224)
        Me.fld_banco.Name = "fld_banco"
        Me.fld_banco.Size = New System.Drawing.Size(384, 20)
        Me.fld_banco.TabIndex = 9
        Me.fld_banco.Text = "Cta.-No "
        '
        'fld_correo
        '
        Me.fld_correo.BackColor = System.Drawing.Color.White
        Me.fld_correo.Location = New System.Drawing.Point(112, 200)
        Me.fld_correo.Name = "fld_correo"
        Me.fld_correo.Size = New System.Drawing.Size(384, 20)
        Me.fld_correo.TabIndex = 8
        Me.fld_correo.Text = "@"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Correo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_tipo
        '
        Me.fld_tipo.Location = New System.Drawing.Point(568, 176)
        Me.fld_tipo.Name = "fld_tipo"
        Me.fld_tipo.TabIndex = 75
        Me.fld_tipo.Text = "normal"
        Me.fld_tipo.Visible = False
        '
        'fld_clasificacion
        '
        Me.fld_clasificacion.BackColor = System.Drawing.Color.FromArgb(CType(27, Byte), CType(116, Byte), CType(179, Byte))
        Me.fld_clasificacion.ForeColor = System.Drawing.Color.White
        Me.fld_clasificacion.Items.AddRange(New Object() {"INTERNACIONALES", "LOCALES", "NACIONALES", "OTROS"})
        Me.fld_clasificacion.Location = New System.Drawing.Point(112, 32)
        Me.fld_clasificacion.Name = "fld_clasificacion"
        Me.fld_clasificacion.Size = New System.Drawing.Size(384, 21)
        Me.fld_clasificacion.Sorted = True
        Me.fld_clasificacion.TabIndex = 1
        Me.fld_clasificacion.Text = "LOCALES"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "RNC"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_Cel
        '
        Me.fld_Cel.BackColor = System.Drawing.Color.White
        Me.fld_Cel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_Cel.Location = New System.Drawing.Point(112, 80)
        Me.fld_Cel.MaxLength = 12
        Me.fld_Cel.Name = "fld_Cel"
        Me.fld_Cel.Size = New System.Drawing.Size(384, 20)
        Me.fld_Cel.TabIndex = 3
        Me.fld_Cel.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Fax"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fld_Fax
        '
        Me.fld_Fax.BackColor = System.Drawing.Color.White
        Me.fld_Fax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.fld_Fax.Location = New System.Drawing.Point(112, 128)
        Me.fld_Fax.MaxLength = 14
        Me.fld_Fax.Name = "fld_Fax"
        Me.fld_Fax.Size = New System.Drawing.Size(384, 20)
        Me.fld_Fax.TabIndex = 5
        Me.fld_Fax.Text = ""
        '
        'lblContact
        '
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(24, 178)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(80, 16)
        Me.lblContact.TabIndex = 61
        Me.lblContact.Text = "Contacto"
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(24, 154)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(80, 16)
        Me.lblAddress.TabIndex = 60
        Me.lblAddress.Text = "Dirección"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPhone
        '
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(24, 106)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(80, 16)
        Me.lblPhone.TabIndex = 3
        Me.lblPhone.Text = "Tel.:"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCompany
        '
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(24, 58)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(80, 16)
        Me.lblCompany.TabIndex = 58
        Me.lblCompany.Text = "Compañía"
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSupplierID
        '
        Me.lblSupplierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierID.Location = New System.Drawing.Point(24, 10)
        Me.lblSupplierID.Name = "lblSupplierID"
        Me.lblSupplierID.Size = New System.Drawing.Size(80, 16)
        Me.lblSupplierID.TabIndex = 57
        Me.lblSupplierID.Text = "Código"
        Me.lblSupplierID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.White
        Me.txtContact.Location = New System.Drawing.Point(112, 176)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(384, 20)
        Me.txtContact.TabIndex = 7
        Me.txtContact.Text = ""
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.Location = New System.Drawing.Point(112, 152)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(384, 20)
        Me.txtAddress.TabIndex = 6
        Me.txtAddress.Text = ""
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPhone.Location = New System.Drawing.Point(112, 104)
        Me.txtPhone.MaxLength = 12
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(384, 20)
        Me.txtPhone.TabIndex = 4
        Me.txtPhone.Text = ""
        '
        'txtCompany
        '
        Me.txtCompany.BackColor = System.Drawing.Color.White
        Me.txtCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompany.Location = New System.Drawing.Point(112, 56)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(384, 20)
        Me.txtCompany.TabIndex = 2
        Me.txtCompany.Text = ""
        '
        'txtSupplierID
        '
        Me.txtSupplierID.BackColor = System.Drawing.Color.White
        Me.txtSupplierID.Location = New System.Drawing.Point(112, 8)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.Size = New System.Drawing.Size(384, 20)
        Me.txtSupplierID.TabIndex = 0
        Me.txtSupplierID.Text = ""
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(0, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Categoría"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCierra
        '
        Me.btnCierra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCierra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCierra.ForeColor = System.Drawing.Color.Black
        Me.btnCierra.Image = CType(resources.GetObject("btnCierra.Image"), System.Drawing.Image)
        Me.btnCierra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCierra.Location = New System.Drawing.Point(424, 408)
        Me.btnCierra.Name = "btnCierra"
        Me.btnCierra.Size = New System.Drawing.Size(72, 56)
        Me.btnCierra.TabIndex = 15
        Me.btnCierra.Text = "&Cerrar"
        Me.btnCierra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnAnula
        '
        Me.btnAnula.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAnula.Enabled = False
        Me.btnAnula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnula.ForeColor = System.Drawing.Color.Black
        Me.btnAnula.Image = CType(resources.GetObject("btnAnula.Image"), System.Drawing.Image)
        Me.btnAnula.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAnula.Location = New System.Drawing.Point(224, 408)
        Me.btnAnula.Name = "btnAnula"
        Me.btnAnula.Size = New System.Drawing.Size(72, 56)
        Me.btnAnula.TabIndex = 13
        Me.btnAnula.Text = "&Borrar"
        Me.btnAnula.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnGuarda
        '
        Me.btnGuarda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuarda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuarda.ForeColor = System.Drawing.Color.Black
        Me.btnGuarda.Image = CType(resources.GetObject("btnGuarda.Image"), System.Drawing.Image)
        Me.btnGuarda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuarda.Location = New System.Drawing.Point(80, 408)
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(72, 56)
        Me.btnGuarda.TabIndex = 11
        Me.btnGuarda.Text = "&Guardar"
        Me.btnGuarda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(8, 408)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 56)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lvwCust
        '
        Me.lvwCust.BackColor = System.Drawing.Color.White
        Me.lvwCust.Location = New System.Drawing.Point(8, 288)
        Me.lvwCust.Name = "lvwCust"
        Me.lvwCust.Size = New System.Drawing.Size(490, 112)
        Me.lvwCust.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(296, 408)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 56)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "&Imprimir Listado"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(16, 88)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.TabIndex = 80
        Me.txtBalance.Text = "0"
        Me.txtBalance.Visible = False
        '
        'txtLimiteCR
        '
        Me.txtLimiteCR.Location = New System.Drawing.Point(24, 128)
        Me.txtLimiteCR.Name = "txtLimiteCR"
        Me.txtLimiteCR.TabIndex = 81
        Me.txtLimiteCR.Text = "0"
        Me.txtLimiteCR.Visible = False
        '
        'buscaCtaContableBtn
        '
        Me.buscaCtaContableBtn.Image = CType(resources.GetObject("buscaCtaContableBtn.Image"), System.Drawing.Image)
        Me.buscaCtaContableBtn.Location = New System.Drawing.Point(272, 247)
        Me.buscaCtaContableBtn.Name = "buscaCtaContableBtn"
        Me.buscaCtaContableBtn.Size = New System.Drawing.Size(32, 23)
        Me.buscaCtaContableBtn.TabIndex = 85
        '
        'lblCuentaContable
        '
        Me.lblCuentaContable.Location = New System.Drawing.Point(112, 272)
        Me.lblCuentaContable.Name = "lblCuentaContable"
        Me.lblCuentaContable.Size = New System.Drawing.Size(272, 16)
        Me.lblCuentaContable.TabIndex = 84
        Me.lblCuentaContable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.BackColor = System.Drawing.Color.White
        Me.txtCuentaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContable.Location = New System.Drawing.Point(112, 248)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.ReadOnly = True
        Me.txtCuentaContable.Size = New System.Drawing.Size(160, 20)
        Me.txtCuentaContable.TabIndex = 82
        Me.txtCuentaContable.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(0, 250)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "Cta. Contable"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRM_PROVEEDORES
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(506, 467)
        Me.Controls.Add(Me.buscaCtaContableBtn)
        Me.Controls.Add(Me.lblCuentaContable)
        Me.Controls.Add(Me.txtCuentaContable)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtLimiteCR)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.fld_clasificacion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCierra)
        Me.Controls.Add(Me.btnAnula)
        Me.Controls.Add(Me.btnGuarda)
        Me.Controls.Add(Me.lvwCust)
        Me.Controls.Add(Me.fld_Fax)
        Me.Controls.Add(Me.fld_banco)
        Me.Controls.Add(Me.fld_correo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblSupplierID)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.fld_Cel)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSupplierID)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fld_tipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCompany)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_PROVEEDORES"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maestro de proveedores"
        Me.ResumeLayout(False)

    End Sub

#End Region



    Dim objIniFile_contabilidad As New IniFile(AppPath & "\Settings_Contabilidad.ini") '/INI FILE
    '/PROPIEDADES DEL FORMULARIO
    Private Sub FRM_PROVEEDORES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        If fld_tipo.Text = "LISTA" Then

        End If
        txtCompany.Focus()
        FillListView()
    End Sub
    Private Sub FRM_PROVEEDORES_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If

        If e.KeyChar = vbCr Then 'BIGIN /DESABLED THE BEEP
            e.Handled = True
        End If 'END /DESABLED THE BEEP


        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            SendKeys.Send(vbTab)
        End If
    End Sub


    '/SUB PROGRAMAS
    Private Sub SaveSupplier()
        Dim dsSupplier As New DataSet
        Dim daSupplier As MySqlDataAdapter
        daSupplier = New MySqlDataAdapter("SELECT * FROM tbl_Supplier", conn)
        daSupplier.Fill(dsSupplier, "tbl_Supplier")


        Dim nr As DataRow = dsSupplier.Tables(0).NewRow
        nr("fldCompany") = txtCompany.Text
        nr("fld_clasificacion") = fld_clasificacion.Text
        nr("fldPhone") = txtPhone.Text
        nr("fldFax") = fld_Fax.Text
        nr("fldCel") = fld_Cel.Text
        nr("fldAddress") = txtAddress.Text
        nr("fldContact") = txtContact.Text
        nr("fldLimiteCR") = CDec(txtLimiteCR.Text)
        nr("fld_Status") = "N"
        nr("fldBalance") = CDec(txtBalance.Text)
        nr("fld_correo") = fld_correo.Text
        nr("fld_banco") = fld_banco.Text
        nr("fld_cta_contable") = txtCuentaContable.Text
        dsSupplier.Tables(0).Rows.Add(nr)


        Dim cmd As New MySqlCommandBuilder(daSupplier)

        conn.Open()
        daSupplier.InsertCommand = cmd.GetInsertCommand
        daSupplier.Update(dsSupplier, "tbl_Supplier")
        dsSupplier.AcceptChanges()
        conn.Close()
        daSupplier.Dispose()
        dsSupplier.Dispose()
    End Sub
    Private Sub UpdateSupplier()
        Dim dsSupplier As New DataSet
        Dim daSupplier As MySqlDataAdapter
        daSupplier = New MySqlDataAdapter("SELECT * FROM tbl_Supplier", conn)
        daSupplier.Fill(dsSupplier, "tbl_Supplier")


        With dsSupplier.Tables("tbl_Supplier")
            .PrimaryKey = New DataColumn() {.Columns("fldSupplierID")}
        End With

        Dim nr As DataRow = dsSupplier.Tables("tbl_Supplier").Rows.Find(txtSupplierID.Text)



        nr("fldCompany") = txtCompany.Text
        nr("fldPhone") = txtPhone.Text
        nr("fld_clasificacion") = fld_clasificacion.Text
        nr("fldFax") = fld_Fax.Text
        nr("fldCel") = fld_Cel.Text
        nr("fldAddress") = txtAddress.Text
        nr("fldContact") = txtContact.Text
        nr("fldLimiteCR") = CDec(txtLimiteCR.Text)
        nr("fld_Status") = "N"
        nr("fld_correo") = fld_correo.Text
        nr("fld_banco") = fld_banco.Text
        nr("fld_cta_contable") = txtCuentaContable.Text
        Dim cmb As MySqlCommandBuilder = New MySqlCommandBuilder(daSupplier)

        conn.Open()
        daSupplier.UpdateCommand = cmb.GetUpdateCommand

        daSupplier.Update(dsSupplier, "tbl_Supplier")
        dsSupplier.AcceptChanges()
        conn.Close()

        daSupplier.Dispose()
        dsSupplier.Dispose()
    End Sub
    Private Sub CleardFields()
        btnAnula.Enabled = False

        btnGuarda.Text = "&Guardar"
        txtSupplierID.Text = ""
        txtCompany.Text = ""
        txtPhone.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
        txtBalance.Text = "0.00"
        txtLimiteCR.Text = "0.00"
        fld_Fax.Text = ""
        fld_Cel.Text = ""
        fld_clasificacion.Text = "LOCALES"
        fld_correo.Text = "@"
        fld_banco.Text = "Cta.-No "
        txtCuentaContable.Text = ""
        lblCuentaContable.Text = ""
    End Sub

    Private Sub AnulaSupplier()


        Dim dsSupplier As New DataSet
        Dim daSupplier As MySqlDataAdapter
        daSupplier = New MySqlDataAdapter("SELECT * FROM tbl_Supplier", conn)
        daSupplier.Fill(dsSupplier, "tbl_Supplier")

        Try
            Dim newrow As DataRow
            With dsSupplier.Tables("tbl_Supplier")
                .PrimaryKey = New DataColumn() {.Columns("fldSupplierID")}
            End With

            newrow = dsSupplier.Tables("tbl_Supplier").Rows.Find(txtSupplierID.Text)  'crea un row en blanco

            If Not (newrow Is Nothing) Then
                newrow("fld_Status") = "B"
                newrow("fldBy") = User(0)
            Else
                Help.ShowPopup(txtSupplierID, "Este código no existe en la Base de Datos", New Point(550, 375))
                daSupplier.Dispose()
                dsSupplier.Dispose()
                Exit Sub

            End If

            Dim cmb As MySqlCommandBuilder = New MySqlCommandBuilder(daSupplier)

            conn.Open()
            daSupplier.UpdateCommand = cmb.GetUpdateCommand
            daSupplier.Update(dsSupplier, "tbl_Supplier") 'actualiza la base de dato
            dsSupplier.AcceptChanges()
            conn.Close()


        Catch oException As Exception
            Alerta(oException.Message)
        End Try
        CleardFields()
        Id = Nothing
        daSupplier.Dispose()
        dsSupplier.Dispose()
    End Sub
    Private Sub LoadSupplier(ByVal id As String)

        Dim dsSupplier As New DataSet
        Dim daSupplier As MySqlDataAdapter
        daSupplier = New MySqlDataAdapter("SELECT * FROM tbl_Supplier", conn)
        daSupplier.Fill(dsSupplier, "tbl_Supplier")

        Dim dr As DataRow
        With dsSupplier.Tables("tbl_Supplier")
            .PrimaryKey = New DataColumn() {.Columns("fldSupplierID")}
        End With

        dr = dsSupplier.Tables("tbl_Supplier").Rows.Find(id)

        If Not (dr Is Nothing) Then
            txtSupplierID.Text = dr("fldSupplierID")
            txtCompany.Text = dr("fldCompany")
            fld_clasificacion.Text = dr("fld_clasificacion")
            txtPhone.Text = dr("fldPhone")
            fld_Fax.Text = dr("fldFax")
            fld_Cel.Text = dr("fldCel")
            txtAddress.Text = dr("fldAddress")
            txtCuentaContable.Text = dr("fld_cta_contable")
            txtContact.Text = dr("fldContact")
            txtLimiteCR.Text = Format(dr("fldLimiteCR"), "C2")
            txtBalance.Text = Format(dr("fldBalance"), "C2")
            fld_correo.Text = dr("fld_correo")
            fld_banco.Text = dr("fld_banco")
            btnAnula.Enabled = True

            btnGuarda.Text = "&Modificar"
        Else
            Help.ShowPopup(txtSupplierID, "Este código no existe en la Base de Datos", New Point(550, 375))
        End If
        daSupplier.Dispose()
        dsSupplier.Dispose()


    End Sub

    Private Function ValidatedSupplier() As Boolean
        If txtCompany.Text = "" Then
            Alerta("El nombre de la compañía es requerido")
            txtCompany.Focus()
            return False 
        ElseIf txtPhone.Text = "" Then
            Alerta("El teléfono requerido")
            txtPhone.Focus()
            return False 
        ElseIf txtAddress.Text = "" Then
            Alerta("La dirección es requerida")
            txtAddress.Focus()
            return False 
        ElseIf Trim(lblCuentaContable.Text) = String.Empty Then
            Alerta("La cuenta contable es requerida")
            txtCuentaContable.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub FillListView()
        lvwCust.Clear()
        lvwCust.View = View.Details
        lvwCust.LabelEdit = False
        lvwCust.FullRowSelect = True
        lvwCust.GridLines = True
        lvwCust.Sorting = SortOrder.Ascending

        Dim fldToSearch As String = "fldCompany"
        Dim strTosearch As String = "'" & txtCompany.Text & "%'"
        Dim sqlSearch As String
        Dim accion As Short


        If strTosearch <> "" Then
            sqlSearch = "SELECT fldSupplierID, fldCompany, fldCel FROM tbl_Supplier WHERE " & fldToSearch & " LIKE " & strTosearch & " AND fld_Status='N'"
        Else
            sqlSearch = "SELECT fldSupplierID, fldCompany, fldCel FROM tbl_Supplier"
        End If


        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        da = New MySqlDataAdapter(sqlSearch, conn)
        da.Fill(ds, "tbl_Customer")



        Dim columnText(3) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "Cod."
        columnText(1) = "Proveedor"
        columnText(2) = "RNC"



        Dim columnWidth(3) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 80
        columnWidth(1) = 300
        columnWidth(2) = 80



        Dim columnAlign(3) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0


        Dim count = 0
        Dim c As DataColumn
        For Each c In ds.Tables(0).Columns
            'adding names of columns as Listview columns				
            Dim h As New ColumnHeader
            h.Text = columnText(count) ' c.ColumnName
            h.TextAlign = columnAlign(count)
            h.Width = columnWidth(count)
            Me.lvwCust.Columns.Add(h)
            count += 1
        Next



        Dim dt As DataTable = ds.Tables(0)
        Dim str(ds.Tables(0).Columns.Count) As String
        'adding Datarows as listview Grids
        Dim rr As DataRow



        For Each rr In dt.Rows

            For col As Integer = 0 To ds.Tables(0).Columns.Count - 1
                '/FORMATEAMO LOS DATOS DE ACUERDO A SU FORMATO, ESTO SE HACE POR CADA COLUMNA QUE EXISTA
                If rr(col).GetType().FullName.ToString = "System.UInt32" Then
                    str(col) = Format(rr(col), "000")
                ElseIf rr(col).GetType().FullName.ToString = "System.Int32" Then
                    str(col) = Format(rr(col), "000")
                ElseIf rr(col).GetType().FullName.ToString = "System.DateTime" Then
                    str(col) = Format(rr(col), "d")
                ElseIf rr(col).GetType().FullName.ToString = "System.String" Then
                    str(col) = rr(col).ToString()
                ElseIf rr(col).GetType().FullName.ToString = "System.Decimal" Then
                    str(col) = Format(rr(col), "C2")
                ElseIf rr(col).GetType().FullName.ToString = "System.Double" Then
                    str(col) = Format(rr(col), "C2")
                End If
            Next

            Dim ii As New ListViewItem(str)
            Me.lvwCust.Items.Add(ii)
            'showing the number of records still added
        Next
    End Sub

    '/BOTONES
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        CleardFields()
    End Sub

    Private Sub btnGuarda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuarda.Click



        If ValidatedSupplier() = False Then Exit Sub
        If btnGuarda.Text = "&Guardar" Then
            SaveSupplier()
        Else
            UpdateSupplier()
        End If

        CleardFields()
        FillListView()
    End Sub

     
    Private Sub btnAnula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnula.Click
        If Trim(txtSupplierID.Text) = "" Then
            Alerta("Para anular un proveedor del sistema, éste debe estar en el mismo")
            Exit Sub
        End If
        If Val(txtBalance.Text) > 0 Then
            Alerta("Para anular un proveedor del sistema, éste debe tener su balance en 0.00")
            Exit Sub
        End If
        Dim Result = Alerta("¿Esta seguro que desea ANULAR este Proveedor?")

        If Not Result = True Then
            Exit Sub
        End If

        AnulaSupplier()
    End Sub
    Private Sub btnCierra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCierra.Click
        Me.Close()
    End Sub


    '/KEY PRESS FIELDS
    Private Sub txtCompany_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            txtPhone.Focus()
        End If
    End Sub
    Private Sub txtPhone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            txtAddress.Focus()
        End If
    End Sub
    Private Sub txtAddress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            txtContact.Focus()
        End If
    End Sub
    Private Sub txtContact_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            txtLimiteCR.Focus()
        End If
    End Sub
    Private Sub txtLimiteCR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            txtCompany.Focus()
        End If
    End Sub
    Private Sub txtSupplierID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSupplierID.KeyPress
        If e.KeyChar = Chr(13) Then
            If Trim(txtSupplierID.Text) = "" Then

            Else
                LoadSupplier(txtSupplierID.Text)
            End If

        End If
    End Sub
    Private Sub txtLimiteCR_KeyPress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCompany_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompany.KeyPress
        FillListView()
    End Sub
    Private Sub lvwCust_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwCust.DoubleClick

        LoadSupplier(lvwCust.FocusedItem.Text)

    End Sub

    Private Sub lvwCust_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwCust.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadSupplier(lvwCust.FocusedItem.Text)
        End If
    End Sub





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AllReportSinFecha("LISTADO DE PROVEEDORES")
    End Sub

    Private Sub buscaCtaContableBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscaCtaContableBtn.Click
        If frmsListaCatalogoCuentaContable() = True Then
            txtCuentaContable.Text = Id
            lblCuentaContable.Text = ReturnDescripcion(Id)
        End If
    End Sub
End Class
