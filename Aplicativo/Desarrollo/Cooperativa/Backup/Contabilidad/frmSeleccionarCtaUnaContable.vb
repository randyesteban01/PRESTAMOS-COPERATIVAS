Imports MySql.Data.MySqlClient
Public Class frmSeleccionarCtaUnaContable
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
    Friend WithEvents BtnProcesar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtTransDCuentaNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTransDDescripcionCuenta As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSeleccionarCtaUnaContable))
        Me.txtTransDCuentaNo = New System.Windows.Forms.TextBox
        Me.txtTransDDescripcionCuenta = New System.Windows.Forms.Label
        Me.BtnProcesar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtTransDCuentaNo
        '
        Me.txtTransDCuentaNo.Location = New System.Drawing.Point(9, 32)
        Me.txtTransDCuentaNo.MaxLength = 11
        Me.txtTransDCuentaNo.Name = "txtTransDCuentaNo"
        Me.txtTransDCuentaNo.Size = New System.Drawing.Size(272, 20)
        Me.txtTransDCuentaNo.TabIndex = 2
        Me.txtTransDCuentaNo.Text = ""
        '
        'txtTransDDescripcionCuenta
        '
        Me.txtTransDDescripcionCuenta.BackColor = System.Drawing.SystemColors.Control
        Me.txtTransDDescripcionCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransDDescripcionCuenta.ForeColor = System.Drawing.Color.Black
        Me.txtTransDDescripcionCuenta.Location = New System.Drawing.Point(9, 16)
        Me.txtTransDDescripcionCuenta.Name = "txtTransDDescripcionCuenta"
        Me.txtTransDDescripcionCuenta.Size = New System.Drawing.Size(272, 16)
        Me.txtTransDDescripcionCuenta.TabIndex = 37
        Me.txtTransDDescripcionCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnProcesar
        '
        Me.BtnProcesar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnProcesar.ForeColor = System.Drawing.Color.Black
        Me.BtnProcesar.Image = CType(resources.GetObject("BtnProcesar.Image"), System.Drawing.Image)
        Me.BtnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnProcesar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnProcesar.Location = New System.Drawing.Point(9, 56)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(72, 56)
        Me.BtnProcesar.TabIndex = 49
        Me.BtnProcesar.Text = "&Aceptar"
        Me.BtnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCancelar.Location = New System.Drawing.Point(209, 56)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(72, 56)
        Me.BtnCancelar.TabIndex = 50
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmSeleccionarCtaUnaContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(290, 123)
        Me.Controls.Add(Me.BtnProcesar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.txtTransDDescripcionCuenta)
        Me.Controls.Add(Me.txtTransDCuentaNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeleccionarCtaUnaContable"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuenta contable"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ListaCuentasContables()
        If frmsListaCatalogoCuentaContable() = True Then
            txtTransDCuentaNo.Text = Id
            txtTransDDescripcionCuenta.Text = SCALAR_STRING("SELECT Descripcion FROM tbl_catalogo WHERE CuentaNo='" & Id & "'")
        End If
    End Sub

    Private Sub frmSeleccionarCtaUnaContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = appIcon
    End Sub

    Private Sub frmSeleccionarCtaUnaContable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            ListaCuentasContables()
        End If
    End Sub

    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesar.Click
        If txtTransDDescripcionCuenta.Text = String.Empty Then
            Alerta("Por favor selecciones una cuenta contable, pulse la tecla F5 para buscar la cuenta")
            Return
        End If
        cta_contable_selecionada = txtTransDCuentaNo.Text
        Me.Text = "ACEPTAR"
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub


End Class
