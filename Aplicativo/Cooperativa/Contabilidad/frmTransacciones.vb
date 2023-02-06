Imports MySql.Data.MySqlClient
Public Class frmTransacciones
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTransID As System.Windows.Forms.TextBox
    Friend WithEvents dtpTransFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTransDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents cmbTransIDTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtTransDCuentaNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTransDDescripcionCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtTransDDebito As System.Windows.Forms.TextBox
    Friend WithEvents txtTransDCredito As System.Windows.Forms.TextBox
    Friend WithEvents lvData As System.Windows.Forms.ListView
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtTotalCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDebito As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDiferencia As System.Windows.Forms.TextBox
    Friend WithEvents txtIDRegistro As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregaRegistroDS As System.Windows.Forms.Button
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents txtIDDocAfectado As System.Windows.Forms.TextBox
    Friend WithEvents txtFrm As System.Windows.Forms.TextBox
    Friend WithEvents ctaContableBtn As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTransacciones))
        Me.txtTransID = New System.Windows.Forms.TextBox
        Me.dtpTransFecha = New System.Windows.Forms.DateTimePicker
        Me.txtTransDescripcion = New System.Windows.Forms.TextBox
        Me.cmbTransIDTipo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTransDCuentaNo = New System.Windows.Forms.TextBox
        Me.txtTransDDescripcionCuenta = New System.Windows.Forms.TextBox
        Me.txtTransDDebito = New System.Windows.Forms.TextBox
        Me.txtTransDCredito = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lvData = New System.Windows.Forms.ListView
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.txtTotalCredito = New System.Windows.Forms.TextBox
        Me.txtTotalDebito = New System.Windows.Forms.TextBox
        Me.txtDiferencia = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnAgregaRegistroDS = New System.Windows.Forms.Button
        Me.txtIDRegistro = New System.Windows.Forms.TextBox
        Me.btnNueva = New System.Windows.Forms.Button
        Me.PrintDialog = New System.Windows.Forms.PrintDialog
        Me.txtIDDocAfectado = New System.Windows.Forms.TextBox
        Me.txtFrm = New System.Windows.Forms.TextBox
        Me.ctaContableBtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtTransID
        '
        Me.txtTransID.Location = New System.Drawing.Point(688, 8)
        Me.txtTransID.Name = "txtTransID"
        Me.txtTransID.ReadOnly = True
        Me.txtTransID.Size = New System.Drawing.Size(112, 20)
        Me.txtTransID.TabIndex = 15
        Me.txtTransID.Text = ""
        '
        'dtpTransFecha
        '
        Me.dtpTransFecha.CustomFormat = "dd-MMMM-yyyy"
        Me.dtpTransFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransFecha.Location = New System.Drawing.Point(400, 8)
        Me.dtpTransFecha.Name = "dtpTransFecha"
        Me.dtpTransFecha.Size = New System.Drawing.Size(216, 20)
        Me.dtpTransFecha.TabIndex = 1
        '
        'txtTransDescripcion
        '
        Me.txtTransDescripcion.Location = New System.Drawing.Point(88, 32)
        Me.txtTransDescripcion.MaxLength = 249
        Me.txtTransDescripcion.Name = "txtTransDescripcion"
        Me.txtTransDescripcion.Size = New System.Drawing.Size(712, 20)
        Me.txtTransDescripcion.TabIndex = 2
        Me.txtTransDescripcion.Text = ""
        '
        'cmbTransIDTipo
        '
        Me.cmbTransIDTipo.Location = New System.Drawing.Point(88, 8)
        Me.cmbTransIDTipo.Name = "cmbTransIDTipo"
        Me.cmbTransIDTipo.Size = New System.Drawing.Size(264, 21)
        Me.cmbTransIDTipo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Tipo :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Descripción :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(352, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fecha :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(632, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Código :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransDCuentaNo
        '
        Me.txtTransDCuentaNo.Location = New System.Drawing.Point(8, 88)
        Me.txtTransDCuentaNo.Name = "txtTransDCuentaNo"
        Me.txtTransDCuentaNo.Size = New System.Drawing.Size(120, 20)
        Me.txtTransDCuentaNo.TabIndex = 3
        Me.txtTransDCuentaNo.Text = ""
        '
        'txtTransDDescripcionCuenta
        '
        Me.txtTransDDescripcionCuenta.Location = New System.Drawing.Point(128, 88)
        Me.txtTransDDescripcionCuenta.Name = "txtTransDDescripcionCuenta"
        Me.txtTransDDescripcionCuenta.ReadOnly = True
        Me.txtTransDDescripcionCuenta.Size = New System.Drawing.Size(328, 20)
        Me.txtTransDDescripcionCuenta.TabIndex = 18
        Me.txtTransDDescripcionCuenta.Text = ""
        '
        'txtTransDDebito
        '
        Me.txtTransDDebito.BackColor = System.Drawing.Color.Gold
        Me.txtTransDDebito.Location = New System.Drawing.Point(456, 88)
        Me.txtTransDDebito.Name = "txtTransDDebito"
        Me.txtTransDDebito.Size = New System.Drawing.Size(120, 20)
        Me.txtTransDDebito.TabIndex = 4
        Me.txtTransDDebito.Text = "0.00"
        Me.txtTransDDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTransDCredito
        '
        Me.txtTransDCredito.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtTransDCredito.Location = New System.Drawing.Point(576, 88)
        Me.txtTransDCredito.Name = "txtTransDCredito"
        Me.txtTransDCredito.Size = New System.Drawing.Size(120, 20)
        Me.txtTransDCredito.TabIndex = 5
        Me.txtTransDCredito.Text = "0.00"
        Me.txtTransDCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Cuenta No. :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(128, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Descripción de la Cuenta :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(504, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Débito :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(624, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Crédito :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lvData
        '
        Me.lvData.Location = New System.Drawing.Point(8, 112)
        Me.lvData.Name = "lvData"
        Me.lvData.Size = New System.Drawing.Size(712, 336)
        Me.lvData.TabIndex = 21
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGuardar.Location = New System.Drawing.Point(728, 256)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 56)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnImprimir.ForeColor = System.Drawing.Color.Black
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnImprimir.Location = New System.Drawing.Point(728, 320)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(72, 56)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "&Imprimir "
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCerrar.Location = New System.Drawing.Point(728, 384)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 56)
        Me.btnCerrar.TabIndex = 10
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtTotalCredito
        '
        Me.txtTotalCredito.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtTotalCredito.Location = New System.Drawing.Point(576, 448)
        Me.txtTotalCredito.Name = "txtTotalCredito"
        Me.txtTotalCredito.Size = New System.Drawing.Size(120, 20)
        Me.txtTotalCredito.TabIndex = 27
        Me.txtTotalCredito.Text = "0.00"
        Me.txtTotalCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDebito
        '
        Me.txtTotalDebito.BackColor = System.Drawing.Color.Gold
        Me.txtTotalDebito.Location = New System.Drawing.Point(456, 448)
        Me.txtTotalDebito.Name = "txtTotalDebito"
        Me.txtTotalDebito.Size = New System.Drawing.Size(120, 20)
        Me.txtTotalDebito.TabIndex = 26
        Me.txtTotalDebito.Text = "0.00"
        Me.txtTotalDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiferencia
        '
        Me.txtDiferencia.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtDiferencia.Location = New System.Drawing.Point(576, 472)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Size = New System.Drawing.Size(120, 20)
        Me.txtDiferencia.TabIndex = 28
        Me.txtDiferencia.Text = "0.00"
        Me.txtDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(376, 450)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Totales :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(504, 474)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Diferencia :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAgregaRegistroDS
        '
        Me.btnAgregaRegistroDS.Image = CType(resources.GetObject("btnAgregaRegistroDS.Image"), System.Drawing.Image)
        Me.btnAgregaRegistroDS.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregaRegistroDS.Location = New System.Drawing.Point(728, 60)
        Me.btnAgregaRegistroDS.Name = "btnAgregaRegistroDS"
        Me.btnAgregaRegistroDS.Size = New System.Drawing.Size(72, 56)
        Me.btnAgregaRegistroDS.TabIndex = 6
        Me.btnAgregaRegistroDS.Text = "&Agregar"
        Me.btnAgregaRegistroDS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtIDRegistro
        '
        Me.txtIDRegistro.Location = New System.Drawing.Point(24, 464)
        Me.txtIDRegistro.Name = "txtIDRegistro"
        Me.txtIDRegistro.TabIndex = 22
        Me.txtIDRegistro.Text = "0"
        Me.txtIDRegistro.Visible = False
        '
        'btnNueva
        '
        Me.btnNueva.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnNueva.ForeColor = System.Drawing.Color.Black
        Me.btnNueva.Image = CType(resources.GetObject("btnNueva.Image"), System.Drawing.Image)
        Me.btnNueva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNueva.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNueva.Location = New System.Drawing.Point(728, 192)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(72, 56)
        Me.btnNueva.TabIndex = 8
        Me.btnNueva.Text = "&Nueva"
        Me.btnNueva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtIDDocAfectado
        '
        Me.txtIDDocAfectado.Location = New System.Drawing.Point(136, 464)
        Me.txtIDDocAfectado.Name = "txtIDDocAfectado"
        Me.txtIDDocAfectado.TabIndex = 23
        Me.txtIDDocAfectado.Text = "-1"
        Me.txtIDDocAfectado.Visible = False
        '
        'txtFrm
        '
        Me.txtFrm.Location = New System.Drawing.Point(248, 464)
        Me.txtFrm.Name = "txtFrm"
        Me.txtFrm.TabIndex = 24
        Me.txtFrm.Text = "Formulario"
        Me.txtFrm.Visible = False
        '
        'ctaContableBtn
        '
        Me.ctaContableBtn.Image = CType(resources.GetObject("ctaContableBtn.Image"), System.Drawing.Image)
        Me.ctaContableBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ctaContableBtn.Location = New System.Drawing.Point(104, 64)
        Me.ctaContableBtn.Name = "ctaContableBtn"
        Me.ctaContableBtn.Size = New System.Drawing.Size(24, 23)
        Me.ctaContableBtn.TabIndex = 30
        Me.ctaContableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmTransacciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(808, 499)
        Me.Controls.Add(Me.ctaContableBtn)
        Me.Controls.Add(Me.txtFrm)
        Me.Controls.Add(Me.txtIDDocAfectado)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.txtIDRegistro)
        Me.Controls.Add(Me.btnAgregaRegistroDS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDiferencia)
        Me.Controls.Add(Me.txtTotalCredito)
        Me.Controls.Add(Me.txtTotalDebito)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lvData)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTransDCredito)
        Me.Controls.Add(Me.txtTransDDebito)
        Me.Controls.Add(Me.txtTransDDescripcionCuenta)
        Me.Controls.Add(Me.txtTransDCuentaNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTransIDTipo)
        Me.Controls.Add(Me.txtTransDescripcion)
        Me.Controls.Add(Me.dtpTransFecha)
        Me.Controls.Add(Me.txtTransID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransacciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaccione Contable"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    Dim count_id As Integer


           

    Private Sub LlenarTipo()
        Dim da As New MySqlDataAdapter("SELECT fld_id, fld_descripcion FROM tbl_interfascontableotrastipo ORDER BY fld_descripcion", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cmbTransIDTipo.DataSource = dt
        cmbTransIDTipo.DisplayMember = "fld_descripcion"
        cmbTransIDTipo.ValueMember = "fld_id"
    End Sub
    Private Sub ListaCuentasContables()
        If frmsListaCatalogoCuentaContable() = True Then
            txtTransDCuentaNo.Text = Id
            txtTransDDescripcionCuenta.Text = SCALAR_STRING("SELECT Descripcion FROM tbl_catalogo WHERE CuentaNo='" & Id & "'")
            txtTransDCuentaNo.Enabled = False
            txtTransDDebito.Focus()
        End If
    End Sub
    Private Sub LimpiarRegistroCuentaContable()
        txtTransDCuentaNo.Enabled = True
        txtTransDCuentaNo.Text = String.Empty
        txtTransDCuentaNo.Focus()
        txtTransDDescripcionCuenta.Text = String.Empty
        txtTransDDebito.Text = 0
        txtTransDCredito.Text = 0
        txtIDRegistro.Text = 0
    End Sub

#Region "Todo con el DS"

    Private Function ValidaDataAlDS() As Boolean
        If txtTransDDebito.Text = String.Empty Then txtTransDDebito.Text = 0
        If txtTransDCredito.Text = String.Empty Then txtTransDCredito.Text = 0
        If Trim(txtTransDCuentaNo.Text) = "" Then
            Alerta("Por favor seleccione una cuenta contable, posicione el cursor en el campo Cuenta No. y precione la tecla F5 para desplegar el listado de las cuentas contable")
            txtTransDCuentaNo.Focus()
            Return False
        ElseIf CDbl(txtTransDDebito.Text) = 0 And CDbl(txtTransDCredito.Text) = 0 Then
            Alerta("Por favor debe escribir el débito o el crédito de éste registro")
            txtTransDDebito.Focus()
            Return False
        ElseIf CDbl(txtTransDDebito.Text) > 0 And CDbl(txtTransDCredito.Text) > 0 Then
            Alerta("Una transacción no debe tener débito y crédito asignado a la misma")
            txtTransDDebito.Text = "0.00"
            txtTransDCredito.Text = "0.00"
            txtTransDDebito.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub InicializaDS()
        ds = New DataSet
        da = New MySqlDataAdapter("SELECT TransDID, TransDCuentaNo, TransDDescripcionCuenta, TransDDebito, TransDCredito, TransDBalance, TransDIDTrans FROM  tbl_interfasecontabletransaccionesdetalles_tmp", conn)
        da.Fill(ds, "tbl_interfasecontabletransaccionesdetalles_tmp")
        LlenarLV()
    End Sub
    Private Sub AgregarRegistroDS()
        If ValidaDataAlDS() = False Then Return
        Dim dr As DataRow
        Dim findrow As DataRow

        With ds.Tables(0)
            .PrimaryKey = New DataColumn() {.Columns("TransDID")}
        End With

        findrow = ds.Tables(0).Rows.Find(txtIDRegistro.Text)

        If Not (findrow Is Nothing) Then

            findrow("TransDCuentaNo") = txtTransDCuentaNo.Text
            findrow("TransDDescripcionCuenta") = txtTransDDescripcionCuenta.Text
            If Trim(txtTransDDebito.Text) = "" Then
                txtTransDDebito.Text = "0.00"
            End If
            If Trim(txtTransDCredito.Text) = "" Then
                txtTransDCredito.Text = "0.00"
            End If
            findrow("TransDDebito") = CDbl(txtTransDDebito.Text)
            findrow("TransDCredito") = CDbl(txtTransDCredito.Text)
            findrow("TransDBalance") = 0
            findrow("TransDIDTrans") = 0

        Else

            dr = ds.Tables("tbl_interfasecontabletransaccionesdetalles_tmp").NewRow 'crea un row en blanco

            dr("TransDID") = -1
            dr("TransDCuentaNo") = txtTransDCuentaNo.Text
            dr("TransDDescripcionCuenta") = txtTransDDescripcionCuenta.Text
            If Trim(txtTransDDebito.Text) = "" Then
                txtTransDDebito.Text = "0.00"
            End If
            If Trim(txtTransDCredito.Text) = "" Then
                txtTransDCredito.Text = "0.00"
            End If
            dr("TransDDebito") = CDbl(txtTransDDebito.Text)
            dr("TransDCredito") = CDbl(txtTransDCredito.Text)
            dr("TransDBalance") = 0
            dr("TransDIDTrans") = 0

            ds.Tables("tbl_interfasecontabletransaccionesdetalles_tmp").Rows.Add(dr)

        End If
        LimpiarRegistroCuentaContable()
        LlenarLV()

    End Sub
    Private Sub BorraRegistroDS(ByVal id_tras As Integer)

        Dim findrow As DataRow

        With ds.Tables("tbl_interfasecontabletransaccionesdetalles_tmp")
            .PrimaryKey = New DataColumn() {.Columns("TransDID")}
        End With

        findrow = ds.Tables("tbl_interfasecontabletransaccionesdetalles_tmp").Rows.Find(id_tras)

        If Not (findrow Is Nothing) Then
            ds.Tables(0).Rows.Remove(findrow)
        End If

        LlenarLV()



    End Sub
    Private Sub CargarRegistroDS(ByVal Id_Trans As Integer)

        Dim findrow As DataRow

        For Each findrow In ds.Tables(0).Rows

            If findrow("TransDID") = Id_Trans Then
                txtIDRegistro.Text = findrow("TransDID")
                txtTransDCuentaNo.Text = findrow("TransDCuentaNo")
                txtTransDDescripcionCuenta.Text = findrow("TransDDescripcionCuenta")
                txtTransDDebito.Text = findrow("TransDDebito")
                txtTransDCredito.Text = findrow("TransDCredito")
                If CDbl(txtTransDDebito.Text) > 0 Then
                    txtTransDDebito.Focus()
                Else
                    txtTransDCredito.Focus()
                End If
                txtTransDCuentaNo.Enabled = False
            End If

        Next


    End Sub
    Private Sub Totalizar()
        Dim myrow As DataRow
        Dim totalDR As Double
        Dim totalCR As Double

        count_id = 0
        For Each myrow In ds.Tables("tbl_interfasecontabletransaccionesdetalles_tmp").Rows
            count_id = count_id + 1
            myrow("TransDID") = count_id
            totalDR = (totalDR + myrow("TransDDebito"))
            totalCR = (totalCR + myrow("TransDCredito"))
        Next
        txtTotalCredito.Text = Format(totalCR, "##,##0.00")
        txtTotalDebito.Text = Format(totalDR, "##,##0.00")
        txtDiferencia.Text = Format(totalDR - totalCR, "##,##0.00")
        If CDbl(txtDiferencia.Text) > 0 Then
            txtDiferencia.BackColor = Color.BlueViolet
        ElseIf CDbl(txtDiferencia.Text) = 0 Then
            txtDiferencia.BackColor = Color.White
        Else
            txtDiferencia.BackColor = Color.Red
        End If

    End Sub
    Private Sub LlenarLV()
        Totalizar()
        lvData.Clear()
        lvData.View = View.Details
        lvData.LabelEdit = False
        lvData.FullRowSelect = True
        lvData.GridLines = True
        lvData.Sorting = SortOrder.None




        Dim columnText(12) As String 'PARA ESCRIBIRLE EL TEXT A LAS COLUMNAS
        columnText(0) = "ID"
        columnText(1) = "CTA."
        columnText(2) = "DETALLE"
        columnText(3) = "DEBITO"
        columnText(4) = "CREDITO"

        Dim columnWidth(12) As Int32 'PARA DARLE EL ANCHO A LAS COLUMNAS
        columnWidth(0) = 0
        columnWidth(1) = 120
        columnWidth(2) = 328
        columnWidth(3) = 120
        columnWidth(4) = 120

        Dim columnAlign(12) As Int32 'PARA ALINEAR LOS DATOS
        columnAlign(0) = 0 'IZQUIERDA
        columnAlign(1) = 0 'IZQUIERDA
        columnAlign(2) = 0 'IZQUIERDA
        columnAlign(3) = 1
        columnAlign(4) = 1

        Dim count = 0
        Dim c As DataColumn
        For Each c In ds.Tables(0).Columns
            'adding names of columns as Listview columns				
            Dim h As New ColumnHeader
            h.Text = columnText(count) ' c.ColumnName
            h.TextAlign = columnAlign(count)
            h.Width = columnWidth(count)
            Me.lvData.Columns.Add(h)
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
                    str(col) = Format(rr(col), "##,##0.00")
                End If
            Next

            Dim ii As New ListViewItem(str)
            Me.lvData.Items.Add(ii)
            'showing the number of records still added
        Next


    End Sub

#End Region

#Region "Emcabezado y Detalle"

    Private Function ValidaEmcabezado() As Boolean
        If SCALAR_STRING("SELECT fld_estado_pc FROM tbl_periodos_contables WHERE YEAR(fld_fecha_inicia_pc)=" & dtpTransFecha.Value.Date.Year & "") = "CERRADO" Then
            Alerta("No se puede guardar la entrega en un período contable diferente al actual.")
            Return False
        ElseIf SCALAR_STRING("SELECT fld_estado_mes_pc FROM tbl_periodos_contables_meses WHERE YEAR(fld_fecha_mes_pc)=" & dtpTransFecha.Value.Date.Year & " AND MONTH(fld_fecha_mes_pc)=" & dtpTransFecha.Value.Date.Month & " ") = "CERRADO" Then
            Alerta("El mes seleccionado ha sido cerrado, no se puede guardar la entrada.")
            Return False
        End If

        If cmbTransIDTipo.SelectedIndex.Equals(-1) Then
            Alerta("Debe seleccionar el tipo de transacción")
            cmbTransIDTipo.Focus()
            Return False
        ElseIf txtTransDescripcion.Text = String.Empty Then
            Alerta("La transacción no tiene ninguna descripción, no se puede guardar")
            txtTransDescripcion.Focus()
            Return False
        ElseIf CDbl(txtDiferencia.Text) <> 0 Then
            Alerta("La transacción no está cuadrada, no se puede guardar")
            Return False
        ElseIf CDbl(txtTotalDebito.Text) = 0 Then
            Alerta("La transacción no está completa, no se puede guardar")
            Return False
        End If
        Return True
    End Function

    Private Sub GuardarEmcabezado()


        txtTransID.Text = Format(GuardarTransaccion(dtpTransFecha.Value.Date, txtTransDescripcion.Text, cmbTransIDTipo.SelectedValue, txtIDDocAfectado.Text, txtFrm.Text, txtTransDescripcion.Text), "000000")
        GuardarDetalle(CInt(txtTransID.Text))
        btnImprimir.Enabled = True
        btnGuardar.Enabled = False
    End Sub

    Private Sub GuardarDetalle(ByVal TransDIDTrans As Integer)
        Dim dr As DataRow

        For Each dr In ds.Tables("tbl_interfasecontabletransaccionesdetalles_tmp").Rows
            GuardarTransaccionDetalle(TransDIDTrans, dr("TransDCuentaNo"), dr("TransDDescripcionCuenta"), dr("TransDDebito"), dr("TransDCredito"))
        Next


    End Sub

    Private Sub LimpiarEmcabezado()
        btnGuardar.Enabled = True
        btnImprimir.Enabled = False
        txtTransDescripcion.Text = String.Empty
        InicializaDS()
        LimpiarRegistroCuentaContable()
    End Sub

    Private Sub ImprimirEntreda()

        PrintDialog.AllowSomePages = True
        PrintDialog.ShowHelp = True
        PrintDialog.Document = docToPrint
        Dim result As DialogResult = PrintDialog.ShowDialog()

        ' If the result is OK then print the document.
        'If (result = Windows.Forms.DialogResult.OK) Then
        Dim ds As New DataSet
            Dim daRecord1 As New MySqlDataAdapter("SELECT * FROM tbl_profiledocument ", conn)
            daRecord1.Fill(ds, "tbl_profiledocument")
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                dr("fldColorForm") = SCALAR_STRING("SELECT fld_descripcion FROM tbl_interfascontableotrastipo WHERE fld_id=" & cmbTransIDTipo.SelectedValue & "")
                Exit For
            Next
            Dim daRecord As New MySqlDataAdapter("SELECT * FROM tbl_interfascontabletransacciones WHERE TransID=" & txtTransID.Text & "", conn)
            daRecord.Fill(ds, "tbl_interfascontabletransacciones")

            Dim daRecordDetails As New MySqlDataAdapter("SELECT * FROM tbl_interfasecontabletransaccionesdetalles WHERE TransDIDTrans=" & txtTransID.Text & "", conn)
            daRecordDetails.Fill(ds, "tbl_interfasecontabletransaccionesdetalles")

            Dim Report As New rptTransacciones
            Report.Database.Tables(0).SetDataSource(ds)
            Report.PrintOptions.PrinterName = PrintDialog.PrinterSettings.PrinterName
            Report.PrintToPrinter(PrintDialog.PrinterSettings.Copies, True, PrintDialog.PrinterSettings.FromPage, PrintDialog.PrinterSettings.ToPage)

        'End If


    End Sub

#End Region
    Friend idTipo As Integer = 0


    Private Sub frmTransacciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
        InicializaDS()
        LlenarTipo()

        If idTipo > 0 Then
            cmbTransIDTipo.SelectedValue = idTipo
            cmbTransIDTipo.Enabled = False
            txtTransDCuentaNo.Focus()
        End If


        If Me.Text = "Transacción de Interfas" Then
            AgregarRegistroDS()
        End If
        txtTransDCuentaNo.Focus()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If ValidaEmcabezado() = False Then Return
        If Alerta("¿Seguro que desea procesar el documento?") = False Then Return
        GuardarEmcabezado()
        btnImprimir.Enabled = True

        If Me.Text = "Transacción de Interfas" Then
            Me.Close()
            Me.Text = "ACEPTAR"
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        ImprimirEntreda()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
        
    End Sub

    Private Sub btnAgregaRegistroDS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregaRegistroDS.Click
        AgregarRegistroDS()
    End Sub

    Private Sub txtTransDDebito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTransDDebito.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTransDCredito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTransDCredito.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub lvData_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvData.KeyDown
        If e.KeyCode = Keys.Delete Then
            BorraRegistroDS(CInt(lvData.FocusedItem.Text))
        ElseIf e.KeyCode = Keys.Enter Then
            CargarRegistroDS(CInt(lvData.FocusedItem.Text))
        End If
    End Sub

    Private Sub lvData_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvData.DoubleClick
        CargarRegistroDS(CInt(lvData.FocusedItem.Text))
    End Sub

    Private Sub frmTransacciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            ListaCuentasContables()
        End If
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        LimpiarEmcabezado()
    End Sub

    Private Sub cmbTransIDTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTransIDTipo.SelectedIndexChanged

    End Sub

    Private Sub cmbTransIDTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTransIDTipo.KeyPress
        e.Handled = True
    End Sub

    

    Private Sub txtTransDDebito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTransDDebito.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtTransDDebito.Text = String.Empty Then txtTransDDebito.Text = 0
            If txtTransDCredito.Text = String.Empty Then txtTransDCredito.Text = 0
            If CDec(txtTransDDebito.Text) > 0 And CDec(txtTransDCredito.Text) = 0 Then
                AgregarRegistroDS()
            ElseIf CDec(txtTransDDebito.Text) = 0 Then
                txtTransDCredito.Focus()

            End If


        End If
    End Sub

    Private Sub txtTransDCredito_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransDCredito.TextChanged

    End Sub

    Private Sub txtTransDCredito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTransDCredito.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtTransDDebito.Text = String.Empty Then txtTransDDebito.Text = 0
            If txtTransDCredito.Text = String.Empty Then txtTransDCredito.Text = 0
            If CDec(txtTransDCredito.Text) > 0 And CDec(txtTransDDebito.Text) = 0 Then
                AgregarRegistroDS()
            
            End If


        End If
    End Sub

    Private Sub txtTransDCuentaNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransDCuentaNo.TextChanged

    End Sub

    Private Sub txtTransDCuentaNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTransDCuentaNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtTransDDescripcionCuenta.Text = SCALAR_STRING("SELECT Descripcion FROM tbl_catalogo WHERE CuentaNo='" & txtTransDCuentaNo.Text & "'")
            If txtTransDDescripcionCuenta.Text = String.Empty Then
                Alerta("La cuenta contable no existe")
                Return
            End If
            txtTransDCuentaNo.Enabled = False
            txtTransDDebito.Focus()
        End If
    End Sub

    
    Private Sub cmbTransIDTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTransIDTipo.KeyDown
        If e.KeyCode = Keys.F5 Then
            ListaCuentasContables()
        End If
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

     

    Private Sub dtpTransFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpTransFecha.KeyDown
        If e.KeyCode = Keys.F5 Then
            ListaCuentasContables()
        End If
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub ctaContableBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctaContableBtn.Click
        ListaCuentasContables()
    End Sub
End Class
